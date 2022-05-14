using System.Data;
using System.Globalization;

namespace EMR_MAIN
{
    public class BenhAnDaLieuTWFunc
    {
        public static void WriteXml(MDB.MDBConnection MyConnection)
        {
            string sql =
                   @"
                  select  a.*,  CTScanner HoSo_CTScanner, SieuAm HoSo_SieuAm, XetNghiem HoSo_XetNghiem,  Khac HoSo_Khac,  Khac_Text HoSo_Khac_Text,  ToanBoHoSo HoSo_ToanBoHoSo, Mach DauSinhTon_Mach,  NhietDo DauSinhTon_NhietDo,  HuyetAp DauSinhTon_HuyetAp,  NhipTho DauSinhTon_NhipTho,  CanNang DauSinhTon_CanNang  
                  from BenhAnDaLieuTW a inner join thongtindieutri b on a.maquanly = b.maquanly
                  where rownum = 1
                    ";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            var DataTable = new DataTable { TableName = "BenhAnDaLieuTW" };
            DataTable.Load(DataReader as IDataReader);
            DataTable.WriteXml("rptBenhAnDaLieuTW.xml");
        }
        public static DataSet SelectDataSet(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql =
                    @"
                 select  a.*,f.hovaten BacSyLamBenhAnHoVaTen ,c.hovaten BacSyDieuTriHoVaTen,d.hovaten NguoiGiaoHoSoHoVaTen,e.hovaten NguoiNhanHoSoHoVaTen, b.XQuang HoSo_XQuang,   b.CTScanner HoSo_CTScanner, b.SieuAm HoSo_SieuAm, b.XetNghiem HoSo_XetNghiem,  b.Khac HoSo_Khac,  b.Khac_Text HoSo_Khac_Text,  b.ToanBoHoSo HoSo_ToanBoHoSo, b.Mach DauSinhTon_Mach, b.NhietDo DauSinhTon_NhietDo,  b.HuyetAp DauSinhTon_HuyetAp,  b.NhipTho DauSinhTon_NhipTho,  b.CanNang DauSinhTon_CanNang  , b.ChieuCao DauSinhTon_ChieuCao, b.BMI DauSinhTon_BMI, b.NgayRaVien 
                 from BenhAnDaLieuTW a 
                 left join thongtindieutri b on a.maquanly = b.maquanly 
                  left join nhanvien c on a.bacsydieutri = c.manhanvien
                  left join nhanvien d on a.nguoigiaohoso = d.manhanvien
                  left join nhanvien e on a.nguoinhanhoso = e.manhanvien
                  left join nhanvien f on a.BacSyLamBenhAn = f.manhanvien
                  where a.maquanly = " + MaQuanLy.ToString(CultureInfo.InvariantCulture);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(sql, MyConnection);
            var ds = new DataSet();
            adt.Fill(ds, "Table");
            if (ds.Tables["Table"] != null && ds.Tables["Table"].Rows.Count > 0 && ERMDatabase.FTPImageString != null)
            {
                ds.Tables["Table"].Rows[0]["Phai_HinhVe"] = ds.Tables["Table"].Rows[0]["Phai_HinhVe"].ToString().Contains("PaintLibrary") ? ds.Tables["Table"].Rows[0]["Phai_HinhVe"] : ERMDatabase.FTPImageString + ds.Tables["Table"].Rows[0]["Phai_HinhVe"];
                ds.Tables["Table"].Rows[0]["Trai_HinhVe"] = ds.Tables["Table"].Rows[0]["Trai_HinhVe"].ToString().Contains("PaintLibrary") ? ds.Tables["Table"].Rows[0]["Trai_HinhVe"] : ERMDatabase.FTPImageString + ds.Tables["Table"].Rows[0]["Trai_HinhVe"];
          }

            string sql2 =
                @"   select a.*,c.hovaten BacSyPhauThuatHoVaTen, d.hovaten BacSyGayMeHoVaTen
                  from PhauThuatThuThuat a
                  left join nhanvien c on a.bacsyphauthuat  = c.manhanvien
                  left join nhanvien d on a.bacsygayme= d.manhanvien
                  where a.maquanly = " + MaQuanLy.ToString(CultureInfo.InvariantCulture);
            adt = new MDB.MDBDataAdapter(sql2, MyConnection);
            adt.Fill(ds, "Table2");
            return ds;
        }
        public static BenhAnDaLieuTW Select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            #region
            string sql =
                      @"select * 
                        from BenhAnDaLieuTW
                        where MaQuanLy = :MaQuanLy";
            #endregion
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            var value = new BenhAnDaLieuTW();
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
                value.KhoaDT_KhoaLV = DataReader["KhoaDT_KhoaLV"].ToString();
                value.CMND = DataReader["CMND"].ToString();
                value.Khac_CacCoQuan = DataReader["Khac_CacCoQuan"].ToString();
                value.KhoaDT_NgayVao1 = DataReader["KhoaDT_NgayVao1"].ToString();
                value.KhoaDT_NgayVao2 = DataReader["KhoaDT_NgayVao2"].ToString();
                value.KhoaDT_NgayVao3 = DataReader["KhoaDT_NgayVao3"].ToString();
                value.TinhHinhRV = DataReader["TinhHinhRV"].ToString();
                value.DTSauMo_SoNgay = DataReader["DTSauMo_SoNgay"].ToString();
                value.DTSauMo_SoLan = DataReader["DTSauMo_SoLan"].ToString();
                value.MaCSKCB = DataReader["MaCSKCB"].ToString();
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
                value.Phai_HinhVe = ERMDatabase.FTPImageString + DataReader["Phai_HinhVe"].ToString();
                value.CSKCB = DataReader["CSKCB"].ToString();
                value.Trai_HinhVe = ERMDatabase.FTPImageString + DataReader["Trai_HinhVe"].ToString();
                value.KQDT_TuVong = DataReader["KQDT_TuVong"].ToString();
                value.KQDT_ChuyenVien = DataReader["KQDT_ChuyenVien"].ToString();
                value.KQDT_BienChung =  DataReader["KQDT_BienChung"].ToString();

                value.PhauThuat = DataReader["PhauThuat"].ToString() == "1" ? true : false;
                value.ThuThuat = DataReader["ThuThuat"].ToString() == "1" ? true : false;
                value.TyLe = DataReader["TyLe"].ToString();
                value.KQDTDG = DataReader["KQDTDG"].ToString();
                value.TrieuChungCoBan = DataReader["TrieuChungCoBan"].ToString();
                value.TonThuongCoBan = DataReader["TonThuongCoBan"].ToString();


                value.DUThuoc_Ten = DataReader["DUThuoc_Ten"].ToString();
                value.DUThuoc_CoSoLan = DataReader["DUThuoc_CoSoLan"].ToString();
                value.DUThuoc_Khong = DataReader["DUThuoc_Khong"].ToString().Equals("1") ? true : false;
                value.DUThuoc_BieuHien = DataReader["DUThuoc_BieuHien"].ToString();

                value.DUConTrung_Ten = DataReader["DUConTrung_Ten"].ToString();
                value.DUConTrung_CoSoLan = DataReader["DUConTrung_CoSoLan"].ToString();
                value.DUConTrung_Khong = DataReader["DUConTrung_Khong"].ToString().Equals("1") ? true : false;
                value.DUConTrung_BieuHien = DataReader["DUConTrung_BieuHien"].ToString();

                value.DUThucPham_Ten = DataReader["DUThucPham_Ten"].ToString();
                value.DUThucPham_CoSoLan = DataReader["DUThucPham_CoSoLan"].ToString();
                value.DUThucPham_Khong = DataReader["DUThucPham_Khong"].ToString().Equals("1") ? true : false;
                value.DUThucPham_BieuHien = DataReader["DUThucPham_BieuHien"].ToString();

                value.DUTacNhanKhac_Ten = DataReader["DUTacNhanKhac_Ten"].ToString();
                value.DUTacNhanKhac_CoSoLan = DataReader["DUTacNhanKhac_CoSoLan"].ToString();
                value.DUTacNhanKhac_Khong = DataReader["DUTacNhanKhac_Khong"].ToString().Equals("1") ? true : false;
                value.DUTacNhanKhac_BieuHien = DataReader["DUTacNhanKhac_BieuHien"].ToString();

                value.DUCaNhanKhac_Ten = DataReader["DUCaNhanKhac_Ten"].ToString();
                value.DUCaNhanKhac_CoSoLan = DataReader["DUCaNhanKhac_CoSoLan"].ToString();
                value.DUCaNhanKhac_Khong = DataReader["DUCaNhanKhac_Khong"].ToString().Equals("1") ? true : false;
                value.DUCaNhanKhac_BieuHien = DataReader["DUCaNhanKhac_BieuHien"].ToString();

                value.DUDiTruyen_Ten = DataReader["DUDiTruyen_Ten"].ToString();
                value.DUDiTruyen_CoSoLan = DataReader["DUDiTruyen_CoSoLan"].ToString();
                value.DUDiTruyen_Khong = DataReader["DUDiTruyen_Khong"].ToString().Equals("1") ? true : false;
                value.DUDiTruyen_BieuHien = DataReader["DUDiTruyen_BieuHien"].ToString();

                value.BacSyChuyenVaoVien = DataReader["BacSyChuyenVaoVien"].ToString();
                value.BacSyNhapChanDoan = DataReader["BacSyNhapChanDoan"].ToString();

                value.MaSoKyTen = DataReader["masokyten"].ToString();
                value.MaSoKyTen_KB = DataReader["masokyten_kb"].ToString();
                value.MaSoKyTen_TK = DataReader["masokyten_tk"].ToString();
            }
            return value;
        }

        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, BenhAnDaLieuTW BenhAnDaLieuTW)
        {
            string sql =
                      @"select MaQuanLy 
                        from BenhAnDaLieuTW
                        where MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnDaLieuTW.MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            int rowCount = 0;
            while (DataReader.Read()) rowCount++;
            if (rowCount == 1) return Update(MyConnection, BenhAnDaLieuTW);
            sql = @"
                   INSERT INTO BenhAnDaLieuTW (
                            MaQuanLy,
                            LyDoVaoVien,
                            VaoNgayThu,
                            QuaTrinhBenhLy,
                            TienSuBenhBanThan,
                            TienSuBenhGiaDinh,
                            ToanThan,
                            TuanHoan,
                            HoHap,
                            TieuHoa,
                            ThanTietNieuSinhDuc,
                            ThanKinh,
                            CoXuongKhop,
                            KhoaDT_KhoaLV,
                            CMND,
                            Khac_CacCoQuan,
                            KhoaDT_NgayVao1,
                            KhoaDT_NgayVao2,KhoaDT_NgayVao3,DTSauMo_SoNgay,DTSauMo_SoLan,TinhHinhRV,MaCSKCB,
                            BenhChinh,
                            BenhKemTheo,
                            PhanBiet,
                            TienLuong,
                            HuongDieuTri,
                            NgayKhamBenh,
                            BacSyLamBenhAn,
                            QuaTrinhBenhLyVaDienBien,
                            TomTatKetQuaXetNghiem,
                            PhuongPhapDieuTri,
                            TinhTrangNguoiBenhRaVien,
                            HuongDieuTriVaCacCheDoTiepTheo,
                            NguoiNhanHoSo,
                            NguoiGiaoHoSo,
                            NgayTongKet,
                            BacSyDieuTri,
                            Phai_HinhVe,
                            CSKCB,
                            Trai_HinhVe,
                            KQDT_TuVong,
                            KQDT_ChuyenVien,
                            KQDT_BienChung,
                             PhauThuat,
                            ThuThuat,TyLe,KQDTDG,
                            TrieuChungCoBan,
                            TonThuongCoBan,
                    DUThuoc_Ten,
                    DUThuoc_CoSoLan,
                    DUThuoc_Khong,
                    DUThuoc_BieuHien,
                    DUConTrung_Ten,
                    DUConTrung_CoSoLan,
                    DUConTrung_Khong,
                    DUConTrung_BieuHien,
                    DUThucPham_Ten,
                    DUThucPham_CoSoLan,
                    DUThucPham_Khong,
                    DUThucPham_BieuHien,
                    DUTacNhanKhac_Ten,
                    DUTacNhanKhac_CoSoLan,
                    DUTacNhanKhac_Khong,
                    DUTacNhanKhac_BieuHien,
                    DUCaNhanKhac_Ten,
                    DUCaNhanKhac_CoSoLan,
                    DUCaNhanKhac_Khong,
                    DUCaNhanKhac_BieuHien,
                    DUDiTruyen_Ten,
                    DUDiTruyen_CoSoLan,
                    DUDiTruyen_Khong,
                    DUDiTruyen_BieuHien,
                    BacSyChuyenVaoVien,
                    BacSyNhapChanDoan
)
                   VALUES(
                            :MaQuanLy,
                            :LyDoVaoVien,
                            :VaoNgayThu,
                            :QuaTrinhBenhLy,
                            :TienSuBenhBanThan,
                            :TienSuBenhGiaDinh,
                            :ToanThan,
                            :TuanHoan,
                            :HoHap,
                            :TieuHoa,
                            :ThanTietNieuSinhDuc,
                            :ThanKinh,
                            :CoXuongKhop,
                            :KhoaDT_KhoaLV,
                            :CMND,
                            :Khac_CacCoQuan,
                            :KhoaDT_NgayVao1,
                            :KhoaDT_NgayVao2,:KhoaDT_NgayVao3,:DTSauMo_SoNgay,:DTSauMo_SoLan,:TinhHinhRV,:MaCSKCB,
                            :BenhChinh,
                            :BenhKemTheo,
                            :PhanBiet,
                            :TienLuong,
                            :HuongDieuTri,
                            :NgayKhamBenh,
                            :BacSyLamBenhAn,
                            :QuaTrinhBenhLyVaDienBien,
                            :TomTatKetQuaXetNghiem,
                            :PhuongPhapDieuTri,
                            :TinhTrangNguoiBenhRaVien,
                            :HuongDieuTriVaCacCheDoTiepTheo,
                            :NguoiNhanHoSo,
                            :NguoiGiaoHoSo,
                            :NgayTongKet,
                            :BacSyDieuTri,
                            :Phai_HinhVe,
                            :CSKCB,
                            :Trai_HinhVe,
                            :KQDT_TuVong,
                            :KQDT_ChuyenVien,
                            :KQDT_BienChung,
                            :PhauThuat,
                            :ThuThuat,
                            :TyLe,
                            :KQDTDG,
                            :TrieuChungCoBan,
                            :TonThuongCoBan,
                    :DUThuoc_Ten,
                    :DUThuoc_CoSoLan,
                    :DUThuoc_Khong,
                    :DUThuoc_BieuHien,
                    :DUConTrung_Ten,
                    :DUConTrung_CoSoLan,
                    :DUConTrung_Khong,
                    :DUConTrung_BieuHien,
                    :DUThucPham_Ten,
                    :DUThucPham_CoSoLan,
                    :DUThucPham_Khong,
                    :DUThucPham_BieuHien,
                    :DUTacNhanKhac_Ten,
                    :DUTacNhanKhac_CoSoLan,
                    :DUTacNhanKhac_Khong,
                    :DUTacNhanKhac_BieuHien,
                    :DUCaNhanKhac_Ten,
                    :DUCaNhanKhac_CoSoLan,
                    :DUCaNhanKhac_Khong,
                    :DUCaNhanKhac_BieuHien,
                    :DUDiTruyen_Ten,
                    :DUDiTruyen_CoSoLan,
                    :DUDiTruyen_Khong,
                    :DUDiTruyen_BieuHien,
                    :BacSyChuyenVaoVien,
                    :BacSyNhapChanDoan
)
                   ";
            Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnDaLieuTW.MaQuanLy));
            Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnDaLieuTW.LyDoVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("VaoNgayThu", BenhAnDaLieuTW.VaoNgayThu));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnDaLieuTW.QuaTrinhBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhBanThan", BenhAnDaLieuTW.TienSuBenhBanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhGiaDinh", BenhAnDaLieuTW.TienSuBenhGiaDinh));
            Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnDaLieuTW.ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoan", BenhAnDaLieuTW.TuanHoan));
            Command.Parameters.Add(new MDB.MDBParameter("HoHap", BenhAnDaLieuTW.HoHap));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoa", BenhAnDaLieuTW.TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieuSinhDuc", BenhAnDaLieuTW.ThanTietNieuSinhDuc));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinh", BenhAnDaLieuTW.ThanKinh));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop", BenhAnDaLieuTW.CoXuongKhop));
            Command.Parameters.Add(new MDB.MDBParameter("KhoaDT_KhoaLV", BenhAnDaLieuTW.KhoaDT_KhoaLV));
            Command.Parameters.Add(new MDB.MDBParameter("CMND", BenhAnDaLieuTW.CMND));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_CacCoQuan", BenhAnDaLieuTW.Khac_CacCoQuan));
            Command.Parameters.Add(new MDB.MDBParameter("KhoaDT_NgayVao1", BenhAnDaLieuTW.KhoaDT_NgayVao1));
            Command.Parameters.Add(new MDB.MDBParameter("KhoaDT_NgayVao2", BenhAnDaLieuTW.KhoaDT_NgayVao2));
            Command.Parameters.Add(new MDB.MDBParameter("KhoaDT_NgayVao3", BenhAnDaLieuTW.KhoaDT_NgayVao3));
            Command.Parameters.Add(new MDB.MDBParameter("DTSauMo_SoNgay", BenhAnDaLieuTW.DTSauMo_SoNgay));
            Command.Parameters.Add(new MDB.MDBParameter("DTSauMo_SoLan", BenhAnDaLieuTW.DTSauMo_SoLan));
            Command.Parameters.Add(new MDB.MDBParameter("TinhHinhRV", BenhAnDaLieuTW.TinhHinhRV));
            Command.Parameters.Add(new MDB.MDBParameter("MaCSKCB", BenhAnDaLieuTW.MaCSKCB));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnDaLieuTW.BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnDaLieuTW.BenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("PhanBiet", BenhAnDaLieuTW.PhanBiet));
            Command.Parameters.Add(new MDB.MDBParameter("TienLuong", BenhAnDaLieuTW.TienLuong));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnDaLieuTW.HuongDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("NgayKhamBenh", BenhAnDaLieuTW.NgayKhamBenh));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyLamBenhAn", BenhAnDaLieuTW.BacSyLamBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLyVaDienBien", BenhAnDaLieuTW.QuaTrinhBenhLyVaDienBien));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQuaXetNghiem", BenhAnDaLieuTW.TomTatKetQuaXetNghiem));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnDaLieuTW.PhuongPhapDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangNguoiBenhRaVien", BenhAnDaLieuTW.TinhTrangNguoiBenhRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriVaCacCheDoTiepTheo", BenhAnDaLieuTW.HuongDieuTriVaCacCheDoTiepTheo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnDaLieuTW.NguoiNhanHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnDaLieuTW.NguoiGiaoHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnDaLieuTW.NgayTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnDaLieuTW.BacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("Phai_HinhVe", BenhAnDaLieuTW.Phai_HinhVe != null ? BenhAnDaLieuTW.Phai_HinhVe.Replace(ERMDatabase.FTPImageString, "") : ""));
            Command.Parameters.Add(new MDB.MDBParameter("CSKCB", BenhAnDaLieuTW.CSKCB));
            Command.Parameters.Add(new MDB.MDBParameter("Trai_HinhVe", BenhAnDaLieuTW.Trai_HinhVe != null ? BenhAnDaLieuTW.Trai_HinhVe.Replace(ERMDatabase.FTPImageString, "") : ""));
            Command.Parameters.Add(new MDB.MDBParameter("KQDT_TuVong", BenhAnDaLieuTW.KQDT_TuVong));
            Command.Parameters.Add(new MDB.MDBParameter("KQDT_ChuyenVien", BenhAnDaLieuTW.KQDT_ChuyenVien ));
            Command.Parameters.Add(new MDB.MDBParameter("KQDT_BienChung", BenhAnDaLieuTW.KQDT_BienChung ));
            Command.Parameters.Add(new MDB.MDBParameter("PhauThuat", BenhAnDaLieuTW.PhauThuat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuThuat", BenhAnDaLieuTW.ThuThuat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TyLe", BenhAnDaLieuTW.TyLe));
            Command.Parameters.Add(new MDB.MDBParameter("KQDTDG", BenhAnDaLieuTW.KQDTDG));
            Command.Parameters.Add(new MDB.MDBParameter("TrieuChungCoBan", BenhAnDaLieuTW.TrieuChungCoBan));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongCoBan", BenhAnDaLieuTW.TonThuongCoBan));

            Command.Parameters.Add(new MDB.MDBParameter("DUThuoc_Ten", BenhAnDaLieuTW.DUThuoc_Ten));
            Command.Parameters.Add(new MDB.MDBParameter("DUThuoc_CoSoLan", BenhAnDaLieuTW.DUThuoc_CoSoLan));
            Command.Parameters.Add(new MDB.MDBParameter("DUThuoc_Khong", BenhAnDaLieuTW.DUThuoc_Khong ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("DUThuoc_BieuHien", BenhAnDaLieuTW.DUThuoc_BieuHien));

            Command.Parameters.Add(new MDB.MDBParameter("DUConTrung_Ten", BenhAnDaLieuTW.DUConTrung_Ten));
            Command.Parameters.Add(new MDB.MDBParameter("DUConTrung_CoSoLan", BenhAnDaLieuTW.DUConTrung_CoSoLan));
            Command.Parameters.Add(new MDB.MDBParameter("DUConTrung_Khong", BenhAnDaLieuTW.DUConTrung_Khong ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("DUConTrung_BieuHien", BenhAnDaLieuTW.DUConTrung_BieuHien));

            Command.Parameters.Add(new MDB.MDBParameter("DUThucPham_Ten", BenhAnDaLieuTW.DUThucPham_Ten));
            Command.Parameters.Add(new MDB.MDBParameter("DUThucPham_CoSoLan", BenhAnDaLieuTW.DUThucPham_CoSoLan));
            Command.Parameters.Add(new MDB.MDBParameter("DUThucPham_Khong", BenhAnDaLieuTW.DUThucPham_Khong ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("DUThucPham_BieuHien", BenhAnDaLieuTW.DUThucPham_BieuHien));

            Command.Parameters.Add(new MDB.MDBParameter("DUTacNhanKhac_Ten", BenhAnDaLieuTW.DUTacNhanKhac_Ten));
            Command.Parameters.Add(new MDB.MDBParameter("DUTacNhanKhac_CoSoLan", BenhAnDaLieuTW.DUTacNhanKhac_CoSoLan));
            Command.Parameters.Add(new MDB.MDBParameter("DUTacNhanKhac_Khong", BenhAnDaLieuTW.DUTacNhanKhac_Khong ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("DUTacNhanKhac_BieuHien", BenhAnDaLieuTW.DUTacNhanKhac_BieuHien));

            Command.Parameters.Add(new MDB.MDBParameter("DUCaNhanKhac_Ten", BenhAnDaLieuTW.DUCaNhanKhac_Ten));
            Command.Parameters.Add(new MDB.MDBParameter("DUCaNhanKhac_CoSoLan", BenhAnDaLieuTW.DUCaNhanKhac_CoSoLan));
            Command.Parameters.Add(new MDB.MDBParameter("DUCaNhanKhac_Khong", BenhAnDaLieuTW.DUCaNhanKhac_Khong ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("DUCaNhanKhac_BieuHien", BenhAnDaLieuTW.DUCaNhanKhac_BieuHien));

            Command.Parameters.Add(new MDB.MDBParameter("DUDiTruyen_Ten", BenhAnDaLieuTW.DUDiTruyen_Ten));
            Command.Parameters.Add(new MDB.MDBParameter("DUDiTruyen_CoSoLan", BenhAnDaLieuTW.DUDiTruyen_CoSoLan));
            Command.Parameters.Add(new MDB.MDBParameter("DUDiTruyen_Khong", BenhAnDaLieuTW.DUDiTruyen_Khong ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("DUDiTruyen_BieuHien", BenhAnDaLieuTW.DUDiTruyen_BieuHien));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyChuyenVaoVien", BenhAnDaLieuTW.BacSyChuyenVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyNhapChanDoan", BenhAnDaLieuTW.BacSyNhapChanDoan));


            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool Update(MDB.MDBConnection MyConnection, BenhAnDaLieuTW BenhAnDaLieuTW)
        {
            string sql = @"UPDATE BenhAnDaLieuTW SET 
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
                        KhoaDT_KhoaLV = :KhoaDT_KhoaLV,
                        CMND = :CMND,
                        Khac_CacCoQuan = :Khac_CacCoQuan,
                        KhoaDT_NgayVao1 = :KhoaDT_NgayVao1,
                        KhoaDT_NgayVao2 = :KhoaDT_NgayVao2,KhoaDT_NgayVao3=:KhoaDT_NgayVao3,DTSauMo_SoNgay=:DTSauMo_SoNgay,DTSauMo_SoLan=:DTSauMo_SoLan,TinhHinhRV=:TinhHinhRV,MaCSKCB=:MaCSKCB,
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
                        Phai_HinhVe = :Phai_HinhVe,
                        CSKCB = :CSKCB,
                        Trai_HinhVe = :Trai_HinhVe,
                        KQDT_TuVong = :KQDT_TuVong,
                        KQDT_ChuyenVien = :KQDT_ChuyenVien,
                        KQDT_BienChung = :KQDT_BienChung,
                        PhauThuat = :PhauThuat,
                        ThuThuat = :ThuThuat,
                        TyLe =  :TyLe,
                        KQDTDG = :KQDTDG,
                        TrieuChungCoBan = :TrieuChungCoBan,
                        TonThuongCoBan = :TonThuongCoBan,
                        DUThuoc_Ten = :DUThuoc_Ten,
                        DUThuoc_CoSoLan = :DUThuoc_CoSoLan,
                        DUThuoc_Khong = :DUThuoc_Khong,
                        DUThuoc_BieuHien = :DUThuoc_BieuHien,
                        DUConTrung_Ten = :DUConTrung_Ten,
                        DUConTrung_CoSoLan = :DUConTrung_CoSoLan,
                        DUConTrung_Khong = :DUConTrung_Khong,
                        DUConTrung_BieuHien = :DUConTrung_BieuHien,
                        DUThucPham_Ten = :DUThucPham_Ten,
                        DUThucPham_CoSoLan = :DUThucPham_CoSoLan,
                        DUThucPham_Khong = :DUThucPham_Khong,
                        DUThucPham_BieuHien = :DUThucPham_BieuHien,
                        DUTacNhanKhac_Ten = :DUTacNhanKhac_Ten,
                        DUTacNhanKhac_CoSoLan = :DUTacNhanKhac_CoSoLan,
                        DUTacNhanKhac_Khong = :DUTacNhanKhac_Khong,
                        DUTacNhanKhac_BieuHien = :DUTacNhanKhac_BieuHien,
                        DUCaNhanKhac_Ten = :DUCaNhanKhac_Ten,
                        DUCaNhanKhac_CoSoLan = :DUCaNhanKhac_CoSoLan,
                        DUCaNhanKhac_Khong = :DUCaNhanKhac_Khong,
                        DUCaNhanKhac_BieuHien = :DUCaNhanKhac_BieuHien,
                        DUDiTruyen_Ten = :DUDiTruyen_Ten,
                        DUDiTruyen_CoSoLan = :DUDiTruyen_CoSoLan,
                        DUDiTruyen_Khong = :DUDiTruyen_Khong,
                        DUDiTruyen_BieuHien = :DUDiTruyen_BieuHien,
                        BacSyChuyenVaoVien = :BacSyChuyenVaoVien,
                        BacSyNhapChanDoan = :BacSyNhapChanDoan 
                        WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnDaLieuTW.LyDoVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("VaoNgayThu", BenhAnDaLieuTW.VaoNgayThu));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnDaLieuTW.QuaTrinhBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhBanThan", BenhAnDaLieuTW.TienSuBenhBanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhGiaDinh", BenhAnDaLieuTW.TienSuBenhGiaDinh));
            Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnDaLieuTW.ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoan", BenhAnDaLieuTW.TuanHoan));
            Command.Parameters.Add(new MDB.MDBParameter("HoHap", BenhAnDaLieuTW.HoHap));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoa", BenhAnDaLieuTW.TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieuSinhDuc", BenhAnDaLieuTW.ThanTietNieuSinhDuc));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinh", BenhAnDaLieuTW.ThanKinh));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop", BenhAnDaLieuTW.CoXuongKhop));
            Command.Parameters.Add(new MDB.MDBParameter("KhoaDT_KhoaLV", BenhAnDaLieuTW.KhoaDT_KhoaLV));
            Command.Parameters.Add(new MDB.MDBParameter("CMND", BenhAnDaLieuTW.CMND));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_CacCoQuan", BenhAnDaLieuTW.Khac_CacCoQuan));
            Command.Parameters.Add(new MDB.MDBParameter("KhoaDT_NgayVao1", BenhAnDaLieuTW.KhoaDT_NgayVao1));
            Command.Parameters.Add(new MDB.MDBParameter("KhoaDT_NgayVao2", BenhAnDaLieuTW.KhoaDT_NgayVao2));
            Command.Parameters.Add(new MDB.MDBParameter("KhoaDT_NgayVao3", BenhAnDaLieuTW.KhoaDT_NgayVao3));
            Command.Parameters.Add(new MDB.MDBParameter("DTSauMo_SoNgay", BenhAnDaLieuTW.DTSauMo_SoNgay));
            Command.Parameters.Add(new MDB.MDBParameter("DTSauMo_SoLan", BenhAnDaLieuTW.DTSauMo_SoLan));
            Command.Parameters.Add(new MDB.MDBParameter("TinhHinhRV", BenhAnDaLieuTW.TinhHinhRV));
            Command.Parameters.Add(new MDB.MDBParameter("MaCSKCB", BenhAnDaLieuTW.MaCSKCB));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnDaLieuTW.BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnDaLieuTW.BenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("PhanBiet", BenhAnDaLieuTW.PhanBiet));
            Command.Parameters.Add(new MDB.MDBParameter("TienLuong", BenhAnDaLieuTW.TienLuong));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnDaLieuTW.HuongDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("NgayKhamBenh", BenhAnDaLieuTW.NgayKhamBenh));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyLamBenhAn", BenhAnDaLieuTW.BacSyLamBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLyVaDienBien", BenhAnDaLieuTW.QuaTrinhBenhLyVaDienBien));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQuaXetNghiem", BenhAnDaLieuTW.TomTatKetQuaXetNghiem));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnDaLieuTW.PhuongPhapDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangNguoiBenhRaVien", BenhAnDaLieuTW.TinhTrangNguoiBenhRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriVaCacCheDoTiepTheo", BenhAnDaLieuTW.HuongDieuTriVaCacCheDoTiepTheo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnDaLieuTW.NguoiNhanHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnDaLieuTW.NguoiGiaoHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnDaLieuTW.NgayTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnDaLieuTW.BacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("Phai_HinhVe", BenhAnDaLieuTW.Phai_HinhVe != null ? BenhAnDaLieuTW.Phai_HinhVe.Replace(ERMDatabase.FTPImageString, "") : ""));
            Command.Parameters.Add(new MDB.MDBParameter("CSKCB", BenhAnDaLieuTW.CSKCB ));
            Command.Parameters.Add(new MDB.MDBParameter("Trai_HinhVe", BenhAnDaLieuTW.Trai_HinhVe != null ? BenhAnDaLieuTW.Trai_HinhVe.Replace(ERMDatabase.FTPImageString, "") : ""));
            Command.Parameters.Add(new MDB.MDBParameter("KQDT_TuVong", BenhAnDaLieuTW.KQDT_TuVong  ));
            Command.Parameters.Add(new MDB.MDBParameter("KQDT_ChuyenVien", BenhAnDaLieuTW.KQDT_ChuyenVien  ));
            Command.Parameters.Add(new MDB.MDBParameter("KQDT_BienChung", BenhAnDaLieuTW.KQDT_BienChung ));
            Command.Parameters.Add(new MDB.MDBParameter("PhauThuat", BenhAnDaLieuTW.PhauThuat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuThuat", BenhAnDaLieuTW.ThuThuat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TyLe", BenhAnDaLieuTW.TyLe));
            Command.Parameters.Add(new MDB.MDBParameter("KQDTDG", BenhAnDaLieuTW.KQDTDG));
            Command.Parameters.Add(new MDB.MDBParameter("TrieuChungCoBan", BenhAnDaLieuTW.TrieuChungCoBan));
            Command.Parameters.Add(new MDB.MDBParameter("TonThuongCoBan", BenhAnDaLieuTW.TonThuongCoBan));

            Command.Parameters.Add(new MDB.MDBParameter("DUThuoc_Ten", BenhAnDaLieuTW.DUThuoc_Ten));
            Command.Parameters.Add(new MDB.MDBParameter("DUThuoc_CoSoLan", BenhAnDaLieuTW.DUThuoc_CoSoLan));
            Command.Parameters.Add(new MDB.MDBParameter("DUThuoc_Khong", BenhAnDaLieuTW.DUThuoc_Khong ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("DUThuoc_BieuHien", BenhAnDaLieuTW.DUThuoc_BieuHien));

            Command.Parameters.Add(new MDB.MDBParameter("DUConTrung_Ten", BenhAnDaLieuTW.DUConTrung_Ten));
            Command.Parameters.Add(new MDB.MDBParameter("DUConTrung_CoSoLan", BenhAnDaLieuTW.DUConTrung_CoSoLan));
            Command.Parameters.Add(new MDB.MDBParameter("DUConTrung_Khong", BenhAnDaLieuTW.DUConTrung_Khong ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("DUConTrung_BieuHien", BenhAnDaLieuTW.DUConTrung_BieuHien));

            Command.Parameters.Add(new MDB.MDBParameter("DUThucPham_Ten", BenhAnDaLieuTW.DUThucPham_Ten));
            Command.Parameters.Add(new MDB.MDBParameter("DUThucPham_CoSoLan", BenhAnDaLieuTW.DUThucPham_CoSoLan));
            Command.Parameters.Add(new MDB.MDBParameter("DUThucPham_Khong", BenhAnDaLieuTW.DUThucPham_Khong ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("DUThucPham_BieuHien", BenhAnDaLieuTW.DUThucPham_BieuHien));

            Command.Parameters.Add(new MDB.MDBParameter("DUTacNhanKhac_Ten", BenhAnDaLieuTW.DUTacNhanKhac_Ten));
            Command.Parameters.Add(new MDB.MDBParameter("DUTacNhanKhac_CoSoLan", BenhAnDaLieuTW.DUTacNhanKhac_CoSoLan));
            Command.Parameters.Add(new MDB.MDBParameter("DUTacNhanKhac_Khong", BenhAnDaLieuTW.DUTacNhanKhac_Khong ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("DUTacNhanKhac_BieuHien", BenhAnDaLieuTW.DUTacNhanKhac_BieuHien));

            Command.Parameters.Add(new MDB.MDBParameter("DUCaNhanKhac_Ten", BenhAnDaLieuTW.DUCaNhanKhac_Ten));
            Command.Parameters.Add(new MDB.MDBParameter("DUCaNhanKhac_CoSoLan", BenhAnDaLieuTW.DUCaNhanKhac_CoSoLan));
            Command.Parameters.Add(new MDB.MDBParameter("DUCaNhanKhac_Khong", BenhAnDaLieuTW.DUCaNhanKhac_Khong ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("DUCaNhanKhac_BieuHien", BenhAnDaLieuTW.DUCaNhanKhac_BieuHien));

            Command.Parameters.Add(new MDB.MDBParameter("DUDiTruyen_Ten", BenhAnDaLieuTW.DUDiTruyen_Ten));
            Command.Parameters.Add(new MDB.MDBParameter("DUDiTruyen_CoSoLan", BenhAnDaLieuTW.DUDiTruyen_CoSoLan));
            Command.Parameters.Add(new MDB.MDBParameter("DUDiTruyen_Khong", BenhAnDaLieuTW.DUDiTruyen_Khong ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("DUDiTruyen_BieuHien", BenhAnDaLieuTW.DUDiTruyen_BieuHien));

            Command.Parameters.Add(new MDB.MDBParameter("BacSyChuyenVaoVien", BenhAnDaLieuTW.BacSyChuyenVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyNhapChanDoan", BenhAnDaLieuTW.BacSyNhapChanDoan));

            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnDaLieuTW.MaQuanLy));
            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool Delete(MDB.MDBConnection MyConnection, BenhAnDaLieuTW BenhAnDaLieuTW)
        {
            string sql = @"DELETE FROM BenhAnDaLieuTW 
                           WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnDaLieuTW.MaQuanLy));

            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
    }
}
