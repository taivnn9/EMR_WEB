using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN
{
    public class BenhAnSanKhoaFunc
    {
        public static void WriteXml(MDB.MDBConnection MyConnection)
        {
            string sql =
                   @"
                  select  a.*,  CTScanner HoSo_CTScanner, SieuAm HoSo_SieuAm, XetNghiem HoSo_XetNghiem,  Khac HoSo_Khac,  Khac_Text HoSo_Khac_Text,  ToanBoHoSo HoSo_ToanBoHoSo, Mach DauSinhTon_Mach,  NhietDo DauSinhTon_NhietDo,  HuyetAp DauSinhTon_HuyetAp,  NhipTho DauSinhTon_NhipTho,  CanNang DauSinhTon_CanNang  
                  from BenhAnSanKhoa a inner join thongtindieutri b on a.maquanly = b.maquanly
                  where rownum = 1
                    ";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            var DataTable = new DataTable { TableName = "BenhAnSanKhoa" };
            DataTable.Load(DataReader as IDataReader);
            DataTable.WriteXml("rptBenhAnSanKhoa.xml");
        }
        public static DataSet SelectDataSet(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql =
                    @"
                  select  a.*,f.hovaten BacSyLamBenhAnHoVaTen ,c.hovaten BacSyDieuTriHoVaTen,d.hovaten NguoiGiaoHoSoHoVaTen,e.hovaten NguoiNhanHoSoHoVaTen, b.XQuang HoSo_XQuang,   b.CTScanner HoSo_CTScanner, b.SieuAm HoSo_SieuAm, b.XetNghiem HoSo_XetNghiem,  b.Khac HoSo_Khac,  b.Khac_Text HoSo_Khac_Text,  b.ToanBoHoSo HoSo_ToanBoHoSo, b.Mach DauSinhTon_Mach, b.NhietDo DauSinhTon_NhietDo,  b.HuyetAp DauSinhTon_HuyetAp,  b.NhipTho DauSinhTon_NhipTho,  b.CanNang DauSinhTon_CanNang  , b.ChieuCao DauSinhTon_ChieuCao, b.BMI DauSinhTon_BMI, b.NgayRaVien 
                 from BenhAnSanKhoa a 
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
                  where a.maquanly = '" + MaQuanLy + "' AND ROWNUM <= 4";
            adt = new MDB.MDBDataAdapter(sql2, MyConnection);
            adt.Fill(ds, "Table2");

            List<TienSuSanKhoa> listTienSuSanKhoa = TienSuSanKhoaFunc.GetListTienSuSanKhoa(MyConnection, MaQuanLy);
            DataTable table3 = new DataTable("Table3");
            table3.Columns.Add("SoLan", typeof(int));
            table3.Columns.Add("Nam");
            table3.Columns.Add("DeDuThang");
            table3.Columns.Add("DeThieuThang");
            table3.Columns.Add("Say");
            table3.Columns.Add("Hut");
            table3.Columns.Add("Nao");
            table3.Columns.Add("Covac");
            table3.Columns.Add("ChuaNgoaiTC");
            table3.Columns.Add("ChuaTrung");
            table3.Columns.Add("ThaiChetLuu");
            table3.Columns.Add("ConHienSong");
            table3.Columns.Add("CanNang");
            table3.Columns.Add("PhuongPhapDe");
            table3.Columns.Add("TaiBien");

            if (listTienSuSanKhoa != null && listTienSuSanKhoa.Count > 0)
            {
                int count = 1;
                foreach(TienSuSanKhoa tienSu in listTienSuSanKhoa)
                {
                    table3.Rows.Add(count,
                        tienSu.Nam,
                        tienSu.DeDuThang ? "1" : "0",
                        tienSu.DeThieuThang ? "1" : "0",
                        tienSu.Say ? "1" : "0",
                        tienSu.Hut ? "1" : "0",
                        tienSu.Nao ? "1" : "0",
                        tienSu.Covac ? "1" : "0",
                        tienSu.ChuaNgoaiTC ? "1" : "0",
                        tienSu.ChuaTrung ? "1" : "0",
                        tienSu.ThaiChetLuu ? "1" : "0",
                        tienSu.ConHienSong ? "1" : "0",
                        tienSu.CanNang,
                        tienSu.PhuongPhapDe,
                        tienSu.TaiBien ? "1" : "0");
                    count++;
                }    
            }
            ds.Tables.Add(table3);
            List<PhauThuatThuThuat> listEkip = PhauThuatThuThuatFunc.GetListPhauThuatThuThuat(MyConnection, MaQuanLy);
            DataTable dt = new DataTable("ListEkip");
            dt.Columns.Add("NgayGioThucHien");
            dt.Columns.Add("PhuongPhapPhauThuat");
            dt.Columns.Add("PhauThuatVien");
            dt.Columns.Add("BacSyGayMe");
            for (int i = 0; i < listEkip.Count; i++)
            {
                PhauThuatThuThuat ekip = listEkip[i];
                DataRow row = dt.NewRow();
                row[0] = "";
                row[1] = "";
                row[2] = "";
                row[3] = "";
                row[0] = ekip.NgayPhauThuatThuThuat;
                if (ekip.PhuongPhapPhauThuatThuThuat != null)
                {
                    row[1] = ekip.PhuongPhapPhauThuatThuThuat;

                }
                else if (ekip.PhuongPhapVoCam != null)
                {
                    row[1] = ekip.PhuongPhapVoCam;
                }
                if (ekip.BacSyPhauThuatHoVaTen != null)
                {
                    row[2] = ekip.BacSyPhauThuatHoVaTen;
                }
                if (ekip.BacSyGayMeHoVaTen != null)
                {
                    row[3] = ekip.BacSyGayMeHoVaTen;
                }
                dt.Rows.Add(row);
            }

            ds.Merge(dt);

            return ds;
        }
        public static BenhAnSanKhoa Select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            #region
            string sql =
                      @"select * 
                        from BenhAnSanKhoa a
                        where MaQuanLy = :MaQuanLy";
            #endregion
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            var value = new BenhAnSanKhoa();
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
                value.KinhCuoiCungTuNgay = DataReader.GetDate("KinhCuoiCungTuNgay");
                value.KinhCuoiCungDenNgay = DataReader.GetDate("KinhCuoiCungDenNgay");
                value.KhongNhoNgayKinhCuoi = DataReader["KhongNhoNgayKinhCuoi"].ToString().Equals("1") ? true : false;
                value.KinhKhacThuong = DataReader["KinhKhacThuong"].ToString();
                value.TuoiThai = DataReader.GetInt("TuoiThai");
                value.NgayThai = DataReader.GetInt("NgayThai");
                value.KhamThaiTai = DataReader["KhamThaiTai"].ToString();
                value.TiemPhongUonVan = DataReader["TiemPhongUonVan"].ToString() == "1" ? true : false;
                value.Phu = DataReader["Phu"].ToString() == "1" ? true : false;
                value.DuocTiem = DataReader.GetInt("DuocTiem");
                value.BatDauChuyenDaTu = DataReader["BatDauChuyenDaTu"] != DBNull.Value ? (DateTime?) DataReader.GetDate("BatDauChuyenDaTu") : null;
                value.DauHieuLucDau = DataReader["DauHieuLucDau"].ToString();
                value.BienChuyen = DataReader["BienChuyen"].ToString();
                value.BatDauThayKinhNam = DataReader.GetInt("BatDauThayKinhNam");
                value.TuoiThayKinh = DataReader.GetInt("TuoiThayKinh");
                value.TinhChatKinhNguyet = DataReader["TinhChatKinhNguyet"].ToString();
                value.ChuKy = DataReader["ChuKy"].ToString();
                value.SoNgayThayKinh = DataReader.GetInt("SoNgayThayKinh");
                value.LuongKinh = DataReader["LuongKinh"].ToString();
                value.KinhLanCuoiNgay = DataReader.GetInt("KinhLanCuoiNgay");
                value.DauBung = DataReader["DauBung"].ToString() == "1" ? true : false;
                value.LayChongNam = DataReader.GetInt("LayChongNam");
                value.TuoiLayChong = DataReader.GetInt("TuoiLayChong");
                value.HetKinhNam = DataReader.GetInt("HetKinhNam");
                value.TuoiHetKinh = DataReader.GetInt("TuoiHetKinh");
                value.Truoc = DataReader["Truoc"].ToString() == "1" ? true : false;
                value.Sau = DataReader["Sau"].ToString() == "1" ? true : false;
                value.Trong = DataReader["Trong"].ToString() == "1" ? true : false;
                value.NhungBenhPhuKhoaDaDieuTri = DataReader["NhungBenhPhuKhoaDaDieuTri"].ToString();
                value.ToanTrang = DataReader["ToanTrang"].ToString();
                value.ToanTrang_Phu = DataReader["ToanTrang_Phu"].ToString() == "1" ? true : false;
                value.BungCoSeoPhauThuatCu = DataReader["BungCoSeoPhauThuatCu"].ToString() == "1" ? true : false;
                value.HinhDangTuCung = DataReader["HinhDangTuCung"].ToString();
                value.TuThe = DataReader["TuThe"].ToString();
                value.ChieuCaoTC = (double)DataReader.GetDecimal("ChieuCaoTC");
                value.VongBung = DataReader.GetInt("VongBung");
                value.ConCoTC = DataReader["ConCoTC"].ToString();
                value.TimThai = DataReader.GetInt("TimThai");
                value.Vu = DataReader["Vu"].ToString();
                value.ChanDoanKhiVaoKhoa = DataReader["ChanDoanKhiVaoKhoa"].ToString();
                value.ChiSoBishop = DataReader.GetInt("ChiSoBishop");
                value.AmHo = DataReader["AmHo"].ToString();
                value.AmDao = DataReader["AmDao"].ToString();
                value.TangSinhMon = DataReader["TangSinhMon"].ToString();
                value.CoTuCung = DataReader["CoTuCung"].ToString();
                value.PhanPhu = DataReader["PhanPhu"].ToString();
                value.TinhTrangOiID = DataReader["TinhTrangOiID"].ToString() == "" ? 0 : DataReader.GetInt("TinhTrangOiID");
                value.OiVoLuc = DataReader["OiVoLuc"] != DBNull.Value ? (DateTime?) DataReader.GetDate("OiVoLuc") : null;
                value.iOiVoID = DataReader.GetInt("OiVoID");
                value.MauSacNuocOi = DataReader["MauSacNuocOi"].ToString();
                value.NuocOiNhieuHayIt = DataReader["NuocOiNhieuHayIt"].ToString();
                value.Ngoi = DataReader["Ngoi"].ToString();
                value.The_KhamTrong = DataReader["The_KhamTrong"].ToString();
                value.KieuThe = DataReader["KieuThe"].ToString();
                value.DoLotID = DataReader.GetInt("DoLotID");
                value.DuongKinhNhoHaVe = DataReader["DuongKinhNhoHaVe"].ToString();
                value.KhiVaoKhoa = DataReader["KhiVaoKhoa"].ToString();
                value.PhuongPhapChinh = DataReader["PhuongPhapChinh"].ToString();
                value.ThoiGianVaoBuongDe = DataReader["ThoiGianVaoBuongDe"] != DBNull.Value ? (DateTime?)DataReader.GetDate("ThoiGianVaoBuongDe") : null;
                value.ThoiGianDe = DataReader["ThoiGianDe"] != DBNull.Value ? (DateTime?)DataReader.GetDate("ThoiGianDe") : null;
                value.TenNguoiTheoDoi = DataReader["TenNguoiTheoDoi"].ToString();
                value.ChucDanh = DataReader["ChucDanh"].ToString();
                value.Apgar_1 = DataReader["Apgar_1"].ToString();
                value.Apgar_5 = DataReader["Apgar_5"].ToString();
                value.Apgar_10 = DataReader["Apgar_10"].ToString();
                value.CanNang = (double)DataReader.GetDecimal("CanNang");
                value.CanNangRau = DataReader.GetInt("CanNangRau");
                value.Cao = DataReader.GetInt("Cao");
                value.VongDau = DataReader.GetInt("VongDau");
                value.iDonThai = DataReader.GetInt("DonThai");
                value.iDaThai = DataReader.GetInt("DaThai");
                value.TatBamSinh = DataReader["TatBamSinh"].ToString() == "1" ? true : false;
                value.CoHauMon = DataReader["CoHauMon"].ToString() == "1" ? true : false;
                value.CuTheDiTatBamSinh = DataReader["CuTheDiTatBamSinh"].ToString();
                value.TinhTrangSoSinhSauKhiDe = DataReader["TinhTrangSoSinhSauKhiDe"].ToString();
                value.XuLyVaKetQua = DataReader["XuLyVaKetQua"].ToString();
                value.iRau = DataReader.GetInt("Rau");
                value.RauCuonCo = DataReader["RauCuonCo"].ToString() == "1" ? true : false;
                value.ThoiGianRauSo = DataReader["ThoiGianRauSo"] != DBNull.Value ? (DateTime?)DataReader.GetDate("ThoiGianRauSo") : null;
                value.CachSoRau = DataReader["CachSoRau"].ToString();
                value.MatMang = DataReader["MatMang"].ToString();
                value.MatMui = DataReader["MatMui"].ToString();
                value.BanhRau = DataReader["BanhRau"].ToString();
                value.CanNangSoRau = DataReader.GetInt("CanNangSoRau");
                value.RauCuonDai = DataReader.GetInt("RauCuonDai");
                value.CoChayMauSauSo = DataReader.GetInt("CoChayMauSauSo");
                value.LuongMauMat = DataReader.GetInt("LuongMauMat");
                value.KiemSoatTuCung = DataReader["KiemSoatTuCung"].ToString() == "1" ? true : false;
                value.XuLyVaKetQuaSoRau = DataReader["XuLyVaKetQuaSoRau"].ToString();
                value.DaNiemMac = DataReader["DaNiemMac"].ToString();
                value.PhuongPhapDeID = DataReader.GetInt("PhuongPhapDeID");
                value.LyDoCanThiep = DataReader["LyDoCanThiep"].ToString();
                value.TangSinhMonID = DataReader.GetInt("TangSinhMonID");
                value.PhuongPhapKhauChi = DataReader["PhuongPhapKhauChi"].ToString();
                value.ChuanDoanTruocPhauThuat = DataReader["ChuanDoanTruocPhauThuat"].ToString();
                value.ChuanDoanSauPhauThuat = DataReader["ChuanDoanSauPhauThuat"].ToString();
                value.CoTuCungID = DataReader.GetInt("CoTuCungID");
                value.TaiBienPhauThuat = DataReader["TaiBienPhauThuat"].ToString() == "1" ? true : false;
                value.BienChung = DataReader["BienChung"].ToString() == "1" ? true : false;
                value.LyDoBienChung = DataReader.GetInt("LyDoBienChung");
                value.SoMuiKhau = DataReader.GetInt("SoMuiKhau");
                value.Mach = DataReader["Mach"].ToString();
                value.NhietDo = DataReader["NhietDo"].ToString();
                value.HuyetAp = DataReader["HuyetAp"].ToString();
                value.NhipTho = DataReader["NhipTho"].ToString();
                value.MaSoKyTen = DataReader["masokyten"].ToString();
                value.MaSoKyTen_KB = DataReader["masokyten_kb"].ToString();
                value.MaSoKyTen_TK = DataReader["masokyten_tk"].ToString();
                value.TinhHinhPT = DataReader["TinhHinhPT"].ToString() == "" ? 0 : DataReader.GetInt("TinhHinhPT");
            }
            return value;
        }

        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, BenhAnSanKhoa BenhAnSanKhoa)
        {
            string sql =
                      @"select MaQuanLy 
                        from BenhAnSanKhoa
                        where MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnSanKhoa.MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            int rowCount = 0;
            while (DataReader.Read()) rowCount++;
            if (rowCount == 1) return Update(MyConnection, BenhAnSanKhoa);
            sql = @"
                   INSERT INTO BenhAnSanKhoa (MaQuanLy, LyDoVaoVien, VaoNgayThu, QuaTrinhBenhLy, TienSuBenhBanThan, TienSuBenhGiaDinh, ToanThan, TuanHoan, HoHap, TieuHoa, ThanTietNieuSinhDuc, ThanKinh, CoXuongKhop, TaiMuiHong, RangHamMat, Mat, Khac_CacCoQuan, CacXetNghiemCanLamSangCanLam, TomTatBenhAn, BenhChinh, BenhKemTheo, PhanBiet, TienLuong, HuongDieuTri, NgayKhamBenh, BacSyLamBenhAn, QuaTrinhBenhLyVaDienBien, TomTatKetQuaXetNghiem, PhuongPhapDieuTri, TinhTrangNguoiBenhRaVien, HuongDieuTriVaCacCheDoTiepTheo, NguoiNhanHoSo, NguoiGiaoHoSo, NgayTongKet, BacSyDieuTri, DiUng, DiUng_Text, MaTuy, MaTuy_Text, RuouBia, RuouBia_Text, ThuocLa, ThuocLa_Text, ThuocLao, ThuocLao_Text, Khac_DacDiemLienQuanBenh, Khac_DacDiemLienQuanBenh_Text, KinhCuoiCungTuNgay, KinhCuoiCungDenNgay, KhongNhoNgayKinhCuoi, KinhKhacThuong, TuoiThai, KhamThaiTai, TiemPhongUonVan, Phu, DuocTiem, BatDauChuyenDaTu, DauHieuLucDau, BienChuyen, BatDauThayKinhNam, TuoiThayKinh, TinhChatKinhNguyet, ChuKy, SoNgayThayKinh, LuongKinh, KinhLanCuoiNgay, DauBung, LayChongNam, TuoiLayChong, HetKinhNam, TuoiHetKinh, Truoc, Sau, Trong, NhungBenhPhuKhoaDaDieuTri, ToanTrang, ToanTrang_Phu, BungCoSeoPhauThuatCu, HinhDangTuCung, TuThe, ChieuCaoTC, VongBung, ConCoTC, TimThai, Vu, ChanDoanKhiVaoKhoa, ChiSoBishop, AmHo, AmDao, TangSinhMon, CoTuCung, PhanPhu, TinhTrangOiID, OiVoLuc, OiVoID, MauSacNuocOi, NuocOiNhieuHayIt, Ngoi, The_KhamTrong, KieuThe, DoLotID, DuongKinhNhoHaVe, KhiVaoKhoa, PhuongPhapChinh, ThoiGianVaoBuongDe, ThoiGianDe, TenNguoiTheoDoi, ChucDanh, Apgar_1, Apgar_5, Apgar_10, CanNang,CanNangRau, Cao, VongDau, DonThai, DaThai, TatBamSinh, CoHauMon, CuTheDiTatBamSinh, TinhTrangSoSinhSauKhiDe, XuLyVaKetQua, Rau, RauCuonCo, ThoiGianRauSo, CachSoRau, MatMang, MatMui, BanhRau, CanNangSoRau, RauCuonDai, CoChayMauSauSo, LuongMauMat, KiemSoatTuCung, XuLyVaKetQuaSoRau, DaNiemMac, PhuongPhapDeID, LyDoCanThiep, TangSinhMonID, PhuongPhapKhauChi, ChuanDoanTruocPhauThuat, ChuanDoanSauPhauThuat, CoTuCungID, TaiBienPhauThuat, BienChung, LyDoBienChung, Mach, NhietDo, HuyetAp, NhipTho, SoMuiKhau, NgayThai,TinhHinhPT)
                   VALUES(:MaQuanLy, :LyDoVaoVien, :VaoNgayThu, :QuaTrinhBenhLy, :TienSuBenhBanThan, :TienSuBenhGiaDinh, :ToanThan, :TuanHoan, :HoHap, :TieuHoa, :ThanTietNieuSinhDuc, :ThanKinh, :CoXuongKhop, :TaiMuiHong, :RangHamMat, :Mat, :Khac_CacCoQuan, :CacXetNghiemCanLamSangCanLam, :TomTatBenhAn, :BenhChinh, :BenhKemTheo, :PhanBiet, :TienLuong, :HuongDieuTri, :NgayKhamBenh, :BacSyLamBenhAn, :QuaTrinhBenhLyVaDienBien, :TomTatKetQuaXetNghiem, :PhuongPhapDieuTri, :TinhTrangNguoiBenhRaVien, :HuongDieuTriVaCacCheDoTiepTheo, :NguoiNhanHoSo, :NguoiGiaoHoSo, :NgayTongKet, :BacSyDieuTri, :DiUng, :DiUng_Text, :MaTuy, :MaTuy_Text, :RuouBia, :RuouBia_Text, :ThuocLa, :ThuocLa_Text, :ThuocLao, :ThuocLao_Text, :Khac_DacDiemLienQuanBenh, :Khac_DacDiemLienQuanBenh_Text, :KinhCuoiCungTuNgay, :KinhCuoiCungDenNgay, :KhongNhoNgayKinhCuoi, :KinhKhacThuong, :TuoiThai, :KhamThaiTai, :TiemPhongUonVan, :Phu, :DuocTiem, :BatDauChuyenDaTu, :DauHieuLucDau, :BienChuyen, :BatDauThayKinhNam, :TuoiThayKinh, :TinhChatKinhNguyet, :ChuKy, :SoNgayThayKinh, :LuongKinh, :KinhLanCuoiNgay, :DauBung, :LayChongNam, :TuoiLayChong, :HetKinhNam, :TuoiHetKinh, :Truoc, :Sau, :Trong, :NhungBenhPhuKhoaDaDieuTri, :ToanTrang, :ToanTrang_Phu, :BungCoSeoPhauThuatCu, :HinhDangTuCung, :TuThe, :ChieuCaoTC, :VongBung, :ConCoTC, :TimThai, :Vu, :ChanDoanKhiVaoKhoa, :ChiSoBishop, :AmHo, :AmDao, :TangSinhMon, :CoTuCung, :PhanPhu, :TinhTrangOiID, :OiVoLuc, :OiVoID, :MauSacNuocOi, :NuocOiNhieuHayIt, :Ngoi, :The_KhamTrong, :KieuThe, :DoLotID, :DuongKinhNhoHaVe, :KhiVaoKhoa, :PhuongPhapChinh, :ThoiGianVaoBuongDe, :ThoiGianDe, :TenNguoiTheoDoi, :ChucDanh, :Apgar_1, :Apgar_5, :Apgar_10, :CanNang,:CanNangRau, :Cao, :VongDau, :DonThai, :DaThai, :TatBamSinh, :CoHauMon, :CuTheDiTatBamSinh, :TinhTrangSoSinhSauKhiDe, :XuLyVaKetQua, :Rau, :RauCuonCo, :ThoiGianRauSo, :CachSoRau, :MatMang, :MatMui, :BanhRau, :CanNangSoRau, :RauCuonDai, :CoChayMauSauSo, :LuongMauMat, :KiemSoatTuCung, :XuLyVaKetQuaSoRau, :DaNiemMac, :PhuongPhapDeID, :LyDoCanThiep, :TangSinhMonID, :PhuongPhapKhauChi, :ChuanDoanTruocPhauThuat, :ChuanDoanSauPhauThuat, :CoTuCungID, :TaiBienPhauThuat, :BienChung, :LyDoBienChung, :Mach, :NhietDo, :HuyetAp, :NhipTho, :SoMuiKhau,:NgayThai,:TinhHinhPT)
                   ";
            Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnSanKhoa.MaQuanLy));
            Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnSanKhoa.LyDoVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("VaoNgayThu", BenhAnSanKhoa.VaoNgayThu));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnSanKhoa.QuaTrinhBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhBanThan", BenhAnSanKhoa.TienSuBenhBanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhGiaDinh", BenhAnSanKhoa.TienSuBenhGiaDinh));
            Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnSanKhoa.ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoan", BenhAnSanKhoa.TuanHoan));
            Command.Parameters.Add(new MDB.MDBParameter("HoHap", BenhAnSanKhoa.HoHap));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoa", BenhAnSanKhoa.TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieuSinhDuc", BenhAnSanKhoa.ThanTietNieuSinhDuc));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinh", BenhAnSanKhoa.ThanKinh));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop", BenhAnSanKhoa.CoXuongKhop));
            Command.Parameters.Add(new MDB.MDBParameter("TaiMuiHong", BenhAnSanKhoa.TaiMuiHong));
            Command.Parameters.Add(new MDB.MDBParameter("RangHamMat", BenhAnSanKhoa.RangHamMat));
            Command.Parameters.Add(new MDB.MDBParameter("Mat", BenhAnSanKhoa.Mat));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_CacCoQuan", BenhAnSanKhoa.Khac_CacCoQuan));
            Command.Parameters.Add(new MDB.MDBParameter("CacXetNghiemCanLamSangCanLam", BenhAnSanKhoa.CacXetNghiemCanLamSangCanLam));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatBenhAn", BenhAnSanKhoa.TomTatBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnSanKhoa.BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnSanKhoa.BenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("PhanBiet", BenhAnSanKhoa.PhanBiet));
            Command.Parameters.Add(new MDB.MDBParameter("TienLuong", BenhAnSanKhoa.TienLuong));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnSanKhoa.HuongDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("NgayKhamBenh", BenhAnSanKhoa.NgayKhamBenh));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyLamBenhAn", BenhAnSanKhoa.BacSyLamBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLyVaDienBien", BenhAnSanKhoa.QuaTrinhBenhLyVaDienBien));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQuaXetNghiem", BenhAnSanKhoa.TomTatKetQuaXetNghiem));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnSanKhoa.PhuongPhapDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangNguoiBenhRaVien", BenhAnSanKhoa.TinhTrangNguoiBenhRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriVaCacCheDoTiepTheo", BenhAnSanKhoa.HuongDieuTriVaCacCheDoTiepTheo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnSanKhoa.NguoiNhanHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnSanKhoa.NguoiGiaoHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnSanKhoa.NgayTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnSanKhoa.BacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng", BenhAnSanKhoa.DacDiemLienQuanBenh.DiUng == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng_Text", BenhAnSanKhoa.DacDiemLienQuanBenh.DiUng_Text));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy", BenhAnSanKhoa.DacDiemLienQuanBenh.MaTuy == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy_Text", BenhAnSanKhoa.DacDiemLienQuanBenh.MaTuy_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia", BenhAnSanKhoa.DacDiemLienQuanBenh.RuouBia == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia_Text", BenhAnSanKhoa.DacDiemLienQuanBenh.RuouBia_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa", BenhAnSanKhoa.DacDiemLienQuanBenh.ThuocLa == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa_Text", BenhAnSanKhoa.DacDiemLienQuanBenh.ThuocLa_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao", BenhAnSanKhoa.DacDiemLienQuanBenh.ThuocLao == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao_Text", BenhAnSanKhoa.DacDiemLienQuanBenh.ThuocLao_Text));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh", BenhAnSanKhoa.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh_Text", BenhAnSanKhoa.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh_Text));
            Command.Parameters.Add(new MDB.MDBParameter("KinhCuoiCungTuNgay", BenhAnSanKhoa.KinhCuoiCungTuNgay));
            Command.Parameters.Add(new MDB.MDBParameter("KinhCuoiCungDenNgay", BenhAnSanKhoa.KinhCuoiCungDenNgay));
            Command.Parameters.Add(new MDB.MDBParameter("KinhKhacThuong", BenhAnSanKhoa.KinhKhacThuong));
            Command.Parameters.Add(new MDB.MDBParameter("TuoiThai", BenhAnSanKhoa.TuoiThai));
            Command.Parameters.Add(new MDB.MDBParameter("KhamThaiTai", BenhAnSanKhoa.KhamThaiTai));
            Command.Parameters.Add(new MDB.MDBParameter("TiemPhongUonVan", BenhAnSanKhoa.TiemPhongUonVan == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Phu", BenhAnSanKhoa.Phu == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DuocTiem", BenhAnSanKhoa.DuocTiem));
            Command.Parameters.Add(new MDB.MDBParameter("BatDauChuyenDaTu", BenhAnSanKhoa.BatDauChuyenDaTu));
            Command.Parameters.Add(new MDB.MDBParameter("DauHieuLucDau", BenhAnSanKhoa.DauHieuLucDau));
            Command.Parameters.Add(new MDB.MDBParameter("KhongNhoNgayKinhCuoi", BenhAnSanKhoa.KhongNhoNgayKinhCuoi == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BienChuyen", BenhAnSanKhoa.BienChuyen));
            Command.Parameters.Add(new MDB.MDBParameter("BatDauThayKinhNam", BenhAnSanKhoa.BatDauThayKinhNam));
            Command.Parameters.Add(new MDB.MDBParameter("TuoiThayKinh", BenhAnSanKhoa.TuoiThayKinh));
            Command.Parameters.Add(new MDB.MDBParameter("TinhChatKinhNguyet", BenhAnSanKhoa.TinhChatKinhNguyet));
            Command.Parameters.Add(new MDB.MDBParameter("ChuKy", BenhAnSanKhoa.ChuKy));
            Command.Parameters.Add(new MDB.MDBParameter("SoNgayThayKinh", BenhAnSanKhoa.SoNgayThayKinh));
            Command.Parameters.Add(new MDB.MDBParameter("LuongKinh", BenhAnSanKhoa.LuongKinh));
            Command.Parameters.Add(new MDB.MDBParameter("KinhLanCuoiNgay", BenhAnSanKhoa.KinhLanCuoiNgay));
            Command.Parameters.Add(new MDB.MDBParameter("DauBung", BenhAnSanKhoa.DauBung == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("LayChongNam", BenhAnSanKhoa.LayChongNam));
            Command.Parameters.Add(new MDB.MDBParameter("TuoiLayChong", BenhAnSanKhoa.TuoiLayChong));
            Command.Parameters.Add(new MDB.MDBParameter("HetKinhNam", BenhAnSanKhoa.HetKinhNam));
            Command.Parameters.Add(new MDB.MDBParameter("TuoiHetKinh", BenhAnSanKhoa.TuoiHetKinh));
            Command.Parameters.Add(new MDB.MDBParameter("Truoc", BenhAnSanKhoa.Truoc == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Sau", BenhAnSanKhoa.Sau == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Trong", BenhAnSanKhoa.Trong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("NhungBenhPhuKhoaDaDieuTri", BenhAnSanKhoa.NhungBenhPhuKhoaDaDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("ToanTrang", BenhAnSanKhoa.ToanTrang));
            Command.Parameters.Add(new MDB.MDBParameter("ToanTrang_Phu", BenhAnSanKhoa.ToanTrang_Phu == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BungCoSeoPhauThuatCu", BenhAnSanKhoa.BungCoSeoPhauThuatCu == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HinhDangTuCung", BenhAnSanKhoa.HinhDangTuCung));
            Command.Parameters.Add(new MDB.MDBParameter("TuThe", BenhAnSanKhoa.TuThe));
            Command.Parameters.Add(new MDB.MDBParameter("ChieuCaoTC", BenhAnSanKhoa.ChieuCaoTC));
            Command.Parameters.Add(new MDB.MDBParameter("VongBung", BenhAnSanKhoa.VongBung));
            Command.Parameters.Add(new MDB.MDBParameter("ConCoTC", BenhAnSanKhoa.ConCoTC));
            Command.Parameters.Add(new MDB.MDBParameter("TimThai", BenhAnSanKhoa.TimThai));
            Command.Parameters.Add(new MDB.MDBParameter("Vu", BenhAnSanKhoa.Vu));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanKhiVaoKhoa", BenhAnSanKhoa.ChanDoanKhiVaoKhoa));
            Command.Parameters.Add(new MDB.MDBParameter("ChiSoBishop", BenhAnSanKhoa.ChiSoBishop));
            Command.Parameters.Add(new MDB.MDBParameter("AmHo", BenhAnSanKhoa.AmHo));
            Command.Parameters.Add(new MDB.MDBParameter("AmDao", BenhAnSanKhoa.AmDao));
            Command.Parameters.Add(new MDB.MDBParameter("TangSinhMon", BenhAnSanKhoa.TangSinhMon));
            Command.Parameters.Add(new MDB.MDBParameter("CoTuCung", BenhAnSanKhoa.CoTuCung));
            Command.Parameters.Add(new MDB.MDBParameter("PhanPhu", BenhAnSanKhoa.PhanPhu));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangOiID", BenhAnSanKhoa.TinhTrangOiID));
            Command.Parameters.Add(new MDB.MDBParameter("OiVoLuc", BenhAnSanKhoa.OiVoLuc));
            Command.Parameters.Add(new MDB.MDBParameter("OiVoID", BenhAnSanKhoa.iOiVoID));
            Command.Parameters.Add(new MDB.MDBParameter("MauSacNuocOi", BenhAnSanKhoa.MauSacNuocOi));
            Command.Parameters.Add(new MDB.MDBParameter("NuocOiNhieuHayIt", BenhAnSanKhoa.NuocOiNhieuHayIt));
            Command.Parameters.Add(new MDB.MDBParameter("Ngoi", BenhAnSanKhoa.Ngoi));
            Command.Parameters.Add(new MDB.MDBParameter("The_KhamTrong", BenhAnSanKhoa.The_KhamTrong));
            Command.Parameters.Add(new MDB.MDBParameter("KieuThe", BenhAnSanKhoa.KieuThe));
            Command.Parameters.Add(new MDB.MDBParameter("DoLotID", BenhAnSanKhoa.DoLotID));
            Command.Parameters.Add(new MDB.MDBParameter("DuongKinhNhoHaVe", BenhAnSanKhoa.DuongKinhNhoHaVe));
            Command.Parameters.Add(new MDB.MDBParameter("KhiVaoKhoa", BenhAnSanKhoa.KhiVaoKhoa));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapChinh", BenhAnSanKhoa.PhuongPhapChinh));
            Command.Parameters.Add(new MDB.MDBParameter("ThoiGianVaoBuongDe", BenhAnSanKhoa.ThoiGianVaoBuongDe));
            Command.Parameters.Add(new MDB.MDBParameter("ThoiGianDe", BenhAnSanKhoa.ThoiGianDe));
            Command.Parameters.Add(new MDB.MDBParameter("TenNguoiTheoDoi", BenhAnSanKhoa.TenNguoiTheoDoi));
            Command.Parameters.Add(new MDB.MDBParameter("ChucDanh", BenhAnSanKhoa.ChucDanh));
            Command.Parameters.Add(new MDB.MDBParameter("Apgar_1", BenhAnSanKhoa.Apgar_1));
            Command.Parameters.Add(new MDB.MDBParameter("Apgar_5", BenhAnSanKhoa.Apgar_5));
            Command.Parameters.Add(new MDB.MDBParameter("Apgar_10", BenhAnSanKhoa.Apgar_10));
            Command.Parameters.Add(new MDB.MDBParameter("CanNang", BenhAnSanKhoa.CanNang));
            Command.Parameters.Add(new MDB.MDBParameter("CanNangRau", BenhAnSanKhoa.CanNangRau));
            Command.Parameters.Add(new MDB.MDBParameter("Cao", BenhAnSanKhoa.Cao));
            Command.Parameters.Add(new MDB.MDBParameter("VongDau", BenhAnSanKhoa.VongDau));
            Command.Parameters.Add(new MDB.MDBParameter("DonThai", BenhAnSanKhoa.iDonThai));
            Command.Parameters.Add(new MDB.MDBParameter("DaThai", BenhAnSanKhoa.iDaThai));
            Command.Parameters.Add(new MDB.MDBParameter("TatBamSinh", BenhAnSanKhoa.TatBamSinh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CoHauMon", BenhAnSanKhoa.CoHauMon == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CuTheDiTatBamSinh", BenhAnSanKhoa.CuTheDiTatBamSinh));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangSoSinhSauKhiDe", BenhAnSanKhoa.TinhTrangSoSinhSauKhiDe));
            Command.Parameters.Add(new MDB.MDBParameter("XuLyVaKetQua", BenhAnSanKhoa.XuLyVaKetQua));
            Command.Parameters.Add(new MDB.MDBParameter("Rau", BenhAnSanKhoa.iRau));
            Command.Parameters.Add(new MDB.MDBParameter("RauCuonCo", BenhAnSanKhoa.RauCuonCo == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThoiGianRauSo", BenhAnSanKhoa.ThoiGianRauSo));
            Command.Parameters.Add(new MDB.MDBParameter("CachSoRau", BenhAnSanKhoa.CachSoRau));
            Command.Parameters.Add(new MDB.MDBParameter("MatMang", BenhAnSanKhoa.MatMang));
            Command.Parameters.Add(new MDB.MDBParameter("MatMui", BenhAnSanKhoa.MatMui));
            Command.Parameters.Add(new MDB.MDBParameter("BanhRau", BenhAnSanKhoa.BanhRau));
            Command.Parameters.Add(new MDB.MDBParameter("CanNangSoRau", BenhAnSanKhoa.CanNangSoRau));
            Command.Parameters.Add(new MDB.MDBParameter("RauCuonDai", BenhAnSanKhoa.RauCuonDai));
            Command.Parameters.Add(new MDB.MDBParameter("CoChayMauSauSo", BenhAnSanKhoa.CoChayMauSauSo));
            Command.Parameters.Add(new MDB.MDBParameter("LuongMauMat", BenhAnSanKhoa.LuongMauMat));
            Command.Parameters.Add(new MDB.MDBParameter("KiemSoatTuCung", BenhAnSanKhoa.KiemSoatTuCung == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("XuLyVaKetQuaSoRau", BenhAnSanKhoa.XuLyVaKetQuaSoRau));
            Command.Parameters.Add(new MDB.MDBParameter("DaNiemMac", BenhAnSanKhoa.DaNiemMac));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDeID", BenhAnSanKhoa.PhuongPhapDeID));
            Command.Parameters.Add(new MDB.MDBParameter("LyDoCanThiep", BenhAnSanKhoa.LyDoCanThiep));
            Command.Parameters.Add(new MDB.MDBParameter("TangSinhMonID", BenhAnSanKhoa.TangSinhMonID));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapKhauChi", BenhAnSanKhoa.PhuongPhapKhauChi));
            Command.Parameters.Add(new MDB.MDBParameter("ChuanDoanTruocPhauThuat", BenhAnSanKhoa.ChuanDoanTruocPhauThuat));
            Command.Parameters.Add(new MDB.MDBParameter("ChuanDoanSauPhauThuat", BenhAnSanKhoa.ChuanDoanSauPhauThuat));
            Command.Parameters.Add(new MDB.MDBParameter("CoTuCungID", BenhAnSanKhoa.CoTuCungID));
            Command.Parameters.Add(new MDB.MDBParameter("TaiBienPhauThuat", BenhAnSanKhoa.TaiBienPhauThuat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BienChung", BenhAnSanKhoa.BienChung == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("LyDoBienChung", BenhAnSanKhoa.LyDoBienChung));
            Command.Parameters.Add(new MDB.MDBParameter("Mach", BenhAnSanKhoa.Mach));
            Command.Parameters.Add(new MDB.MDBParameter("NhietDo", BenhAnSanKhoa.NhietDo));
            Command.Parameters.Add(new MDB.MDBParameter("HuyetAp", BenhAnSanKhoa.HuyetAp));
            Command.Parameters.Add(new MDB.MDBParameter("NhipTho", BenhAnSanKhoa.NhipTho));
            Command.Parameters.Add(new MDB.MDBParameter("SoMuiKhau", BenhAnSanKhoa.SoMuiKhau));
            Command.Parameters.Add(new MDB.MDBParameter("NgayThai", BenhAnSanKhoa.NgayThai));
            Command.Parameters.Add(new MDB.MDBParameter("TinhHinhPT", BenhAnSanKhoa.TinhHinhPT));

            Command.BindByName = true;

            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool Update(MDB.MDBConnection MyConnection, BenhAnSanKhoa BenhAnSanKhoa)
        {
            string sql = @"UPDATE BenhAnSanKhoa SET 
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
                        KinhCuoiCungTuNgay = :KinhCuoiCungTuNgay,
                        KinhCuoiCungDenNgay = :KinhCuoiCungDenNgay,
                        KhongNhoNgayKinhCuoi = :KhongNhoNgayKinhCuoi,
                        KinhKhacThuong = :KinhKhacThuong,
                        TuoiThai = :TuoiThai,
                        KhamThaiTai = :KhamThaiTai,
                        TiemPhongUonVan = :TiemPhongUonVan,
                        Phu = :Phu,
                        DuocTiem = :DuocTiem,
                        BatDauChuyenDaTu = :BatDauChuyenDaTu,
                        DauHieuLucDau = :DauHieuLucDau,
                        BienChuyen = :BienChuyen,
                        BatDauThayKinhNam = :BatDauThayKinhNam,
                        TuoiThayKinh = :TuoiThayKinh,
                        TinhChatKinhNguyet = :TinhChatKinhNguyet,
                        ChuKy = :ChuKy,
                        SoNgayThayKinh = :SoNgayThayKinh,
                        LuongKinh = :LuongKinh,
                        KinhLanCuoiNgay = :KinhLanCuoiNgay,
                        DauBung = :DauBung,
                        LayChongNam = :LayChongNam,
                        TuoiLayChong = :TuoiLayChong,
                        HetKinhNam = :HetKinhNam,
                        TuoiHetKinh = :TuoiHetKinh,
                        Truoc = :Truoc,
                        Sau = :Sau,
                        Trong = :Trong,
                        NhungBenhPhuKhoaDaDieuTri = :NhungBenhPhuKhoaDaDieuTri,
                        ToanTrang = :ToanTrang,
                        ToanTrang_Phu = :ToanTrang_Phu,
                        BungCoSeoPhauThuatCu = :BungCoSeoPhauThuatCu,
                        HinhDangTuCung = :HinhDangTuCung,
                        TuThe = :TuThe,
                        ChieuCaoTC = :ChieuCaoTC,
                        VongBung = :VongBung,
                        ConCoTC = :ConCoTC,
                        TimThai = :TimThai,
                        Vu = :Vu,
                        ChanDoanKhiVaoKhoa = :ChanDoanKhiVaoKhoa,
                        ChiSoBishop = :ChiSoBishop,
                        AmHo = :AmHo,
                        AmDao = :AmDao,
                        TangSinhMon = :TangSinhMon,
                        CoTuCung = :CoTuCung,
                        PhanPhu = :PhanPhu,
                        TinhTrangOiID = :TinhTrangOiID,
                        OiVoLuc = :OiVoLuc,
                        OiVoID = :OiVoID,
                        MauSacNuocOi = :MauSacNuocOi,
                        NuocOiNhieuHayIt = :NuocOiNhieuHayIt,
                        Ngoi = :Ngoi,
                        The_KhamTrong = :The_KhamTrong,
                        KieuThe = :KieuThe,
                        DoLotID = :DoLotID,
                        DuongKinhNhoHaVe = :DuongKinhNhoHaVe,
                        KhiVaoKhoa = :KhiVaoKhoa,
                        PhuongPhapChinh = :PhuongPhapChinh,
                        ThoiGianVaoBuongDe = :ThoiGianVaoBuongDe,
                        ThoiGianDe = :ThoiGianDe,
                        TenNguoiTheoDoi = :TenNguoiTheoDoi,
                        ChucDanh = :ChucDanh,
                        Apgar_1 = :Apgar_1,
                        Apgar_5 = :Apgar_5,
                        Apgar_10 = :Apgar_10,
                        CanNang = :CanNang,
                        CanNangRau = :CanNangRau,
                        Cao = :Cao,
                        VongDau = :VongDau,
                        DonThai = :DonThai,
                        DaThai = :DaThai,
                        TatBamSinh = :TatBamSinh,
                        CoHauMon = :CoHauMon,
                        CuTheDiTatBamSinh = :CuTheDiTatBamSinh,
                        TinhTrangSoSinhSauKhiDe = :TinhTrangSoSinhSauKhiDe,
                        XuLyVaKetQua = :XuLyVaKetQua,
                        Rau = :Rau,
                        RauCuonCo = :RauCuonCo,
                        ThoiGianRauSo = :ThoiGianRauSo,
                        CachSoRau = :CachSoRau,
                        MatMang = :MatMang,
                        MatMui = :MatMui,
                        BanhRau = :BanhRau,
                        CanNangSoRau = :CanNangSoRau,
                        RauCuonDai = :RauCuonDai,
                        CoChayMauSauSo = :CoChayMauSauSo,
                        LuongMauMat = :LuongMauMat,
                        KiemSoatTuCung = :KiemSoatTuCung,
                        XuLyVaKetQuaSoRau = :XuLyVaKetQuaSoRau,
                        DaNiemMac = :DaNiemMac,
                        PhuongPhapDeID = :PhuongPhapDeID,
                        LyDoCanThiep = :LyDoCanThiep,
                        TangSinhMonID = :TangSinhMonID,
                        PhuongPhapKhauChi = :PhuongPhapKhauChi,
                        ChuanDoanTruocPhauThuat = :ChuanDoanTruocPhauThuat,
                        ChuanDoanSauPhauThuat = :ChuanDoanSauPhauThuat,
                        CoTuCungID = :CoTuCungID,
                        TaiBienPhauThuat = :TaiBienPhauThuat,
                        BienChung = :BienChung,
                        LyDoBienChung = :LyDoBienChung,
                        Mach = :Mach,
                        NhietDo = :NhietDo,
                        HuyetAp = :HuyetAp,
                        NhipTho = :NhipTho,
                        SoMuiKhau = :SoMuiKhau,
                        NgayThai= :NgayThai,
                        TinhHinhPT =:TinhHinhPT 
                        WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnSanKhoa.LyDoVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("VaoNgayThu", BenhAnSanKhoa.VaoNgayThu));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnSanKhoa.QuaTrinhBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhBanThan", BenhAnSanKhoa.TienSuBenhBanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhGiaDinh", BenhAnSanKhoa.TienSuBenhGiaDinh));
            Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnSanKhoa.ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoan", BenhAnSanKhoa.TuanHoan));
            Command.Parameters.Add(new MDB.MDBParameter("HoHap", BenhAnSanKhoa.HoHap));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoa", BenhAnSanKhoa.TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieuSinhDuc", BenhAnSanKhoa.ThanTietNieuSinhDuc));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinh", BenhAnSanKhoa.ThanKinh));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop", BenhAnSanKhoa.CoXuongKhop));
            Command.Parameters.Add(new MDB.MDBParameter("TaiMuiHong", BenhAnSanKhoa.TaiMuiHong));
            Command.Parameters.Add(new MDB.MDBParameter("RangHamMat", BenhAnSanKhoa.RangHamMat));
            Command.Parameters.Add(new MDB.MDBParameter("Mat", BenhAnSanKhoa.Mat));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_CacCoQuan", BenhAnSanKhoa.Khac_CacCoQuan));
            Command.Parameters.Add(new MDB.MDBParameter("CacXetNghiemCanLamSangCanLam", BenhAnSanKhoa.CacXetNghiemCanLamSangCanLam));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatBenhAn", BenhAnSanKhoa.TomTatBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnSanKhoa.BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnSanKhoa.BenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("PhanBiet", BenhAnSanKhoa.PhanBiet));
            Command.Parameters.Add(new MDB.MDBParameter("TienLuong", BenhAnSanKhoa.TienLuong));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnSanKhoa.HuongDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("NgayKhamBenh", BenhAnSanKhoa.NgayKhamBenh));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyLamBenhAn", BenhAnSanKhoa.BacSyLamBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLyVaDienBien", BenhAnSanKhoa.QuaTrinhBenhLyVaDienBien));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQuaXetNghiem", BenhAnSanKhoa.TomTatKetQuaXetNghiem));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnSanKhoa.PhuongPhapDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangNguoiBenhRaVien", BenhAnSanKhoa.TinhTrangNguoiBenhRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriVaCacCheDoTiepTheo", BenhAnSanKhoa.HuongDieuTriVaCacCheDoTiepTheo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnSanKhoa.NguoiNhanHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnSanKhoa.NguoiGiaoHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnSanKhoa.NgayTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnSanKhoa.BacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng", BenhAnSanKhoa.DacDiemLienQuanBenh.DiUng == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng_Text", BenhAnSanKhoa.DacDiemLienQuanBenh.DiUng_Text));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy", BenhAnSanKhoa.DacDiemLienQuanBenh.MaTuy == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy_Text", BenhAnSanKhoa.DacDiemLienQuanBenh.MaTuy_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia", BenhAnSanKhoa.DacDiemLienQuanBenh.RuouBia == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia_Text", BenhAnSanKhoa.DacDiemLienQuanBenh.RuouBia_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa", BenhAnSanKhoa.DacDiemLienQuanBenh.ThuocLa == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa_Text", BenhAnSanKhoa.DacDiemLienQuanBenh.ThuocLa_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao", BenhAnSanKhoa.DacDiemLienQuanBenh.ThuocLao == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao_Text", BenhAnSanKhoa.DacDiemLienQuanBenh.ThuocLao_Text));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh", BenhAnSanKhoa.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh_Text", BenhAnSanKhoa.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh_Text));
            Command.Parameters.Add(new MDB.MDBParameter("KinhCuoiCungTuNgay", BenhAnSanKhoa.KinhCuoiCungTuNgay));
            Command.Parameters.Add(new MDB.MDBParameter("KinhCuoiCungDenNgay", BenhAnSanKhoa.KinhCuoiCungDenNgay));
            Command.Parameters.Add(new MDB.MDBParameter("KhongNhoNgayKinhCuoi", BenhAnSanKhoa.KhongNhoNgayKinhCuoi ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("KinhKhacThuong", BenhAnSanKhoa.KinhKhacThuong));
            Command.Parameters.Add(new MDB.MDBParameter("TuoiThai", BenhAnSanKhoa.TuoiThai));
            Command.Parameters.Add(new MDB.MDBParameter("KhamThaiTai", BenhAnSanKhoa.KhamThaiTai));
            Command.Parameters.Add(new MDB.MDBParameter("TiemPhongUonVan", BenhAnSanKhoa.TiemPhongUonVan == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Phu", BenhAnSanKhoa.Phu == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DuocTiem", BenhAnSanKhoa.DuocTiem));
            Command.Parameters.Add(new MDB.MDBParameter("BatDauChuyenDaTu", BenhAnSanKhoa.BatDauChuyenDaTu));
            Command.Parameters.Add(new MDB.MDBParameter("DauHieuLucDau", BenhAnSanKhoa.DauHieuLucDau));
            Command.Parameters.Add(new MDB.MDBParameter("BienChuyen", BenhAnSanKhoa.BienChuyen));
            Command.Parameters.Add(new MDB.MDBParameter("BatDauThayKinhNam", BenhAnSanKhoa.BatDauThayKinhNam));
            Command.Parameters.Add(new MDB.MDBParameter("TuoiThayKinh", BenhAnSanKhoa.TuoiThayKinh));
            Command.Parameters.Add(new MDB.MDBParameter("TinhChatKinhNguyet", BenhAnSanKhoa.TinhChatKinhNguyet));
            Command.Parameters.Add(new MDB.MDBParameter("ChuKy", BenhAnSanKhoa.ChuKy));
            Command.Parameters.Add(new MDB.MDBParameter("SoNgayThayKinh", BenhAnSanKhoa.SoNgayThayKinh));
            Command.Parameters.Add(new MDB.MDBParameter("LuongKinh", BenhAnSanKhoa.LuongKinh));
            Command.Parameters.Add(new MDB.MDBParameter("KinhLanCuoiNgay", BenhAnSanKhoa.KinhLanCuoiNgay));
            Command.Parameters.Add(new MDB.MDBParameter("DauBung", BenhAnSanKhoa.DauBung == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("LayChongNam", BenhAnSanKhoa.LayChongNam));
            Command.Parameters.Add(new MDB.MDBParameter("TuoiLayChong", BenhAnSanKhoa.TuoiLayChong));
            Command.Parameters.Add(new MDB.MDBParameter("HetKinhNam", BenhAnSanKhoa.HetKinhNam));
            Command.Parameters.Add(new MDB.MDBParameter("TuoiHetKinh", BenhAnSanKhoa.TuoiHetKinh));
            Command.Parameters.Add(new MDB.MDBParameter("Truoc", BenhAnSanKhoa.Truoc == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Sau", BenhAnSanKhoa.Sau == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Trong", BenhAnSanKhoa.Trong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("NhungBenhPhuKhoaDaDieuTri", BenhAnSanKhoa.NhungBenhPhuKhoaDaDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("ToanTrang", BenhAnSanKhoa.ToanTrang));
            Command.Parameters.Add(new MDB.MDBParameter("ToanTrang_Phu", BenhAnSanKhoa.ToanTrang_Phu == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BungCoSeoPhauThuatCu", BenhAnSanKhoa.BungCoSeoPhauThuatCu == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HinhDangTuCung", BenhAnSanKhoa.HinhDangTuCung));
            Command.Parameters.Add(new MDB.MDBParameter("TuThe", BenhAnSanKhoa.TuThe));
            Command.Parameters.Add(new MDB.MDBParameter("ChieuCaoTC", BenhAnSanKhoa.ChieuCaoTC));
            Command.Parameters.Add(new MDB.MDBParameter("VongBung", BenhAnSanKhoa.VongBung));
            Command.Parameters.Add(new MDB.MDBParameter("ConCoTC", BenhAnSanKhoa.ConCoTC));
            Command.Parameters.Add(new MDB.MDBParameter("TimThai", BenhAnSanKhoa.TimThai));
            Command.Parameters.Add(new MDB.MDBParameter("Vu", BenhAnSanKhoa.Vu));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanKhiVaoKhoa", BenhAnSanKhoa.ChanDoanKhiVaoKhoa));
            Command.Parameters.Add(new MDB.MDBParameter("ChiSoBishop", BenhAnSanKhoa.ChiSoBishop));
            Command.Parameters.Add(new MDB.MDBParameter("AmHo", BenhAnSanKhoa.AmHo));
            Command.Parameters.Add(new MDB.MDBParameter("AmDao", BenhAnSanKhoa.AmDao));
            Command.Parameters.Add(new MDB.MDBParameter("TangSinhMon", BenhAnSanKhoa.TangSinhMon));
            Command.Parameters.Add(new MDB.MDBParameter("CoTuCung", BenhAnSanKhoa.CoTuCung));
            Command.Parameters.Add(new MDB.MDBParameter("PhanPhu", BenhAnSanKhoa.PhanPhu));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangOiID", BenhAnSanKhoa.TinhTrangOiID));
            Command.Parameters.Add(new MDB.MDBParameter("OiVoLuc", BenhAnSanKhoa.OiVoLuc));
            Command.Parameters.Add(new MDB.MDBParameter("OiVoID", BenhAnSanKhoa.iOiVoID));
            Command.Parameters.Add(new MDB.MDBParameter("MauSacNuocOi", BenhAnSanKhoa.MauSacNuocOi));
            Command.Parameters.Add(new MDB.MDBParameter("NuocOiNhieuHayIt", BenhAnSanKhoa.NuocOiNhieuHayIt));
            Command.Parameters.Add(new MDB.MDBParameter("Ngoi", BenhAnSanKhoa.Ngoi));
            Command.Parameters.Add(new MDB.MDBParameter("The_KhamTrong", BenhAnSanKhoa.The_KhamTrong));
            Command.Parameters.Add(new MDB.MDBParameter("KieuThe", BenhAnSanKhoa.KieuThe));
            Command.Parameters.Add(new MDB.MDBParameter("DoLotID", BenhAnSanKhoa.DoLotID));
            Command.Parameters.Add(new MDB.MDBParameter("DuongKinhNhoHaVe", BenhAnSanKhoa.DuongKinhNhoHaVe));
            Command.Parameters.Add(new MDB.MDBParameter("KhiVaoKhoa", BenhAnSanKhoa.KhiVaoKhoa));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapChinh", BenhAnSanKhoa.PhuongPhapChinh));
            Command.Parameters.Add(new MDB.MDBParameter("ThoiGianVaoBuongDe", BenhAnSanKhoa.ThoiGianVaoBuongDe));
            Command.Parameters.Add(new MDB.MDBParameter("ThoiGianDe", BenhAnSanKhoa.ThoiGianDe));
            Command.Parameters.Add(new MDB.MDBParameter("TenNguoiTheoDoi", BenhAnSanKhoa.TenNguoiTheoDoi));
            Command.Parameters.Add(new MDB.MDBParameter("ChucDanh", BenhAnSanKhoa.ChucDanh));
            Command.Parameters.Add(new MDB.MDBParameter("Apgar_1", BenhAnSanKhoa.Apgar_1));
            Command.Parameters.Add(new MDB.MDBParameter("Apgar_5", BenhAnSanKhoa.Apgar_5));
            Command.Parameters.Add(new MDB.MDBParameter("Apgar_10", BenhAnSanKhoa.Apgar_10));
            Command.Parameters.Add(new MDB.MDBParameter("CanNang", BenhAnSanKhoa.CanNang));
            Command.Parameters.Add(new MDB.MDBParameter("CanNangRau", BenhAnSanKhoa.CanNangRau));
            Command.Parameters.Add(new MDB.MDBParameter("Cao", BenhAnSanKhoa.Cao));
            Command.Parameters.Add(new MDB.MDBParameter("VongDau", BenhAnSanKhoa.VongDau));
            Command.Parameters.Add(new MDB.MDBParameter("DonThai", BenhAnSanKhoa.iDonThai));
            Command.Parameters.Add(new MDB.MDBParameter("DaThai", BenhAnSanKhoa.iDaThai));
            Command.Parameters.Add(new MDB.MDBParameter("TatBamSinh", BenhAnSanKhoa.TatBamSinh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CoHauMon", BenhAnSanKhoa.CoHauMon == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CuTheDiTatBamSinh", BenhAnSanKhoa.CuTheDiTatBamSinh));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangSoSinhSauKhiDe", BenhAnSanKhoa.TinhTrangSoSinhSauKhiDe));
            Command.Parameters.Add(new MDB.MDBParameter("XuLyVaKetQua", BenhAnSanKhoa.XuLyVaKetQua));
            Command.Parameters.Add(new MDB.MDBParameter("Rau", BenhAnSanKhoa.iRau));
            Command.Parameters.Add(new MDB.MDBParameter("RauCuonCo", BenhAnSanKhoa.RauCuonCo == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThoiGianRauSo", BenhAnSanKhoa.ThoiGianRauSo));
            Command.Parameters.Add(new MDB.MDBParameter("CachSoRau", BenhAnSanKhoa.CachSoRau));
            Command.Parameters.Add(new MDB.MDBParameter("MatMang", BenhAnSanKhoa.MatMang));
            Command.Parameters.Add(new MDB.MDBParameter("MatMui", BenhAnSanKhoa.MatMui));
            Command.Parameters.Add(new MDB.MDBParameter("BanhRau", BenhAnSanKhoa.BanhRau));
            Command.Parameters.Add(new MDB.MDBParameter("CanNangSoRau", BenhAnSanKhoa.CanNangSoRau));
            Command.Parameters.Add(new MDB.MDBParameter("RauCuonDai", BenhAnSanKhoa.RauCuonDai));
            Command.Parameters.Add(new MDB.MDBParameter("CoChayMauSauSo", BenhAnSanKhoa.CoChayMauSauSo));
            Command.Parameters.Add(new MDB.MDBParameter("LuongMauMat", BenhAnSanKhoa.LuongMauMat));
            Command.Parameters.Add(new MDB.MDBParameter("KiemSoatTuCung", BenhAnSanKhoa.KiemSoatTuCung == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("XuLyVaKetQuaSoRau", BenhAnSanKhoa.XuLyVaKetQuaSoRau));
            Command.Parameters.Add(new MDB.MDBParameter("DaNiemMac", BenhAnSanKhoa.DaNiemMac));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDeID", BenhAnSanKhoa.PhuongPhapDeID));
            Command.Parameters.Add(new MDB.MDBParameter("LyDoCanThiep", BenhAnSanKhoa.LyDoCanThiep));
            Command.Parameters.Add(new MDB.MDBParameter("TangSinhMonID", BenhAnSanKhoa.TangSinhMonID));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapKhauChi", BenhAnSanKhoa.PhuongPhapKhauChi));
            Command.Parameters.Add(new MDB.MDBParameter("ChuanDoanTruocPhauThuat", BenhAnSanKhoa.ChuanDoanTruocPhauThuat));
            Command.Parameters.Add(new MDB.MDBParameter("ChuanDoanSauPhauThuat", BenhAnSanKhoa.ChuanDoanSauPhauThuat));
            Command.Parameters.Add(new MDB.MDBParameter("CoTuCungID", BenhAnSanKhoa.CoTuCungID));
            Command.Parameters.Add(new MDB.MDBParameter("TaiBienPhauThuat", BenhAnSanKhoa.TaiBienPhauThuat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BienChung", BenhAnSanKhoa.BienChung == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("LyDoBienChung", BenhAnSanKhoa.LyDoBienChung));
            Command.Parameters.Add(new MDB.MDBParameter("Mach", BenhAnSanKhoa.Mach));
            Command.Parameters.Add(new MDB.MDBParameter("NhietDo", BenhAnSanKhoa.NhietDo));
            Command.Parameters.Add(new MDB.MDBParameter("HuyetAp", BenhAnSanKhoa.HuyetAp));
            Command.Parameters.Add(new MDB.MDBParameter("NhipTho", BenhAnSanKhoa.NhipTho));
            Command.Parameters.Add(new MDB.MDBParameter("SoMuiKhau", BenhAnSanKhoa.SoMuiKhau));
            Command.Parameters.Add(new MDB.MDBParameter("NgayThai", BenhAnSanKhoa.NgayThai));
            Command.Parameters.Add(new MDB.MDBParameter("TinhHinhPT", BenhAnSanKhoa.TinhHinhPT));
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnSanKhoa.MaQuanLy));
            Command.BindByName = true;
            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool Delete(MDB.MDBConnection MyConnection, BenhAnSanKhoa BenhAnSanKhoa)
        {
            string sql = @"DELETE FROM BenhAnSanKhoa 
                           WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnSanKhoa.MaQuanLy));

            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
    }
}
