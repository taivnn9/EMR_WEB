using System;
using System.Data;

namespace EMR_MAIN
{
    public class BenhAnNgoaiTruAVayNenFunc
    {
        public static void WriteXml(MDB.MDBConnection MyConnection)
        {
            string sql =
                   @"
                  select  a.*,  CTScanner HoSo_CTScanner, SieuAm HoSo_SieuAm, XetNghiem HoSo_XetNghiem,  Khac HoSo_Khac,  Khac_Text HoSo_Khac_Text,  ToanBoHoSo HoSo_ToanBoHoSo, Mach DauSinhTon_Mach,  NhietDo DauSinhTon_NhietDo,  HuyetAp DauSinhTon_HuyetAp,  NhipTho DauSinhTon_NhipTho,  CanNang DauSinhTon_CanNang  
                  from BENHANNTAVAYNEN a inner join thongtindieutri b on a.maquanly = b.maquanly
                  where rownum = 1
                    ";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            var DataTable = new DataTable { TableName = "BENHANNTAVAYNEN" };
            DataTable.Load(DataReader as IDataReader);
            DataTable.WriteXml("rptBenhAnNgoaiTruAVayNen.xml");
        }
        public static DataSet SelectDataSet(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql =
                   @"
                   select  a.*,f.hovaten BacSyLamBenhAnHoVaTen ,c.hovaten BacSyDieuTriHoVaTen,d.hovaten NguoiGiaoHoSoHoVaTen,e.hovaten NguoiNhanHoSoHoVaTen, b.XQuang HoSo_XQuang,   b.CTScanner HoSo_CTScanner, b.SieuAm HoSo_SieuAm, b.XetNghiem HoSo_XetNghiem,  b.Khac HoSo_Khac,  b.Khac_Text HoSo_Khac_Text,  b.ToanBoHoSo HoSo_ToanBoHoSo, b.Mach DauSinhTon_Mach, b.NhietDo DauSinhTon_NhietDo,  b.HuyetAp DauSinhTon_HuyetAp,  b.NhipTho DauSinhTon_NhipTho,  b.CanNang DauSinhTon_CanNang  , b.ChieuCao DauSinhTon_ChieuCao, b.BMI DauSinhTon_BMI, b.NgayRaVien 
                 from BENHANNTAVAYNEN a 
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
        public static BenhAnNgoaiTruAVayNen Select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            #region
            string sql =
                      @"select * 
                        from BENHANNTAVAYNEN a
                        where MaQuanLy = :MaQuanLy";
            #endregion
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            var value = new BenhAnNgoaiTruAVayNen();
            value.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
            while (DataReader.Read())
            {
                value.MaQuanLy = DataReader.GetDecimal("MaQuanLy");
                value.LyDoVaoVien = DataReader["LyDoVaoVien"].ToString();
                value.VaoNgayThu = DataReader.GetInt("VaoNgayThu");
                value.HB_TGPhatBenh = DataReader.GetInt("HB_TGPhatBenh");
                value.HB_TrieuTrungDauTien = DataReader["HB_TrieuTrungDauTien"].ToString();
                value.HB_TGBiDayDa = DataReader.GetInt("HB_TGBiDayDa");
                value.HB_QuaTrinhBenhLy = DataReader["HB_QuaTrinhBenhLy"].ToString();
                value.HB_DieuTriTruocDay = DataReader["HB_DieuTriTruocDay"].ToString();
                value.HB_TSBT_TGMacBenh = DataReader["HB_TSBT_TGMacBenh"].ToString();
                value.HB_TSBT_BenhDaKhac = DataReader["HB_TSBT_BenhDaKhac"].ToString();
                value.HB_TSBT_BenhNoiKhoaKhac = DataReader["HB_TSBT_BenhNoiKhoaKhac"].ToString();
                value.HB_TienSuGiaDinh = DataReader["HB_TienSuGiaDinh"].ToString();
                value.HB_TrieuCoNang = DataReader["HB_TrieuCoNang"].ToString();
                value.HB_LS_Mach = DataReader["HB_LS_Mach"].ToString();
                value.HB_LS_HuyetAp = DataReader["HB_LS_HuyetAp"].ToString();
                value.HB_LS_NhietDo = DataReader["HB_LS_NhietDo"].ToString();
                value.HB_LS_NhipTho = DataReader["HB_LS_NhipTho"].ToString();
                value.HB_LS_TimMach = DataReader["HB_LS_TimMach"].ToString();
                value.HB_LS_HoHap = DataReader["HB_LS_HoHap"].ToString();
                value.HB_LS_TieuHoa = DataReader["HB_LS_TieuHoa"].ToString();
                value.HB_LS_ThanTietNieu = DataReader["HB_LS_ThanTietNieu"].ToString();
                value.HB_LS_CoXuongKhop = DataReader["HB_LS_CoXuongKhop"].ToString();
                value.HB_LS_BoPhanKhac = DataReader["HB_LS_BoPhanKhac"].ToString();
                value.HB_LS_TTDaKichThuoc = DataReader["HB_LS_TTDaKichThuoc"].ToString();
                value.DatDo_KichThuoc = DataReader.GetInt("DatDo_KichThuoc");
                value.DatDo_HinhDang = DataReader.GetInt("DatDo_HinhDang");
                value.DatDo_RanhGioi = DataReader.GetInt("DatDo_RanhGioi");
                value.DatDo_MauSac = DataReader.GetInt("DatDo_MauSac");
                value.VayDa = DataReader.GetInt("VayDa");
                value.DatDo_HinhDang_Khac = DataReader["DatDo_HinhDang_Khac"].ToString();
                value.DatDo_MauSac_Khac = DataReader["DatDo_MauSac_Khac"].ToString();
                value.ViTri_Khac = DataReader["ViTri_Khac"].ToString();
                value.ViTri = DataReader.GetInt("ViTri");
                value.PhanBo = DataReader.GetInt("PhanBo");
                value.PhanBo_Khac = DataReader["PhanBo_Khac"].ToString();
                value.PoKi = DataReader.GetInt("PoKi");
                value.DHGanXi = DataReader.GetInt("DHGanXi");
                value.CTM1 = DataReader["CTM1"].ToString();
                value.CTM2 = DataReader["CTM2"].ToString();
                value.CTM3 = DataReader["CTM3"].ToString();
                value.CTM4 = DataReader["CTM4"].ToString();
                value.CTM5 = DataReader["CTM5"].ToString();
                value.MauLang1 = DataReader["MauLang1"].ToString();
                value.MauLang2 = DataReader["MauLang2"].ToString();
                value.SHM1 = DataReader["SHM1"].ToString();
                value.SHM2 = DataReader["SHM2"].ToString();
                value.SHM3 = DataReader["SHM3"].ToString();
                value.SHM4 = DataReader["SHM4"].ToString();
                value.SHM5 = DataReader["SHM5"].ToString();
                value.SHM6 = DataReader["SHM6"].ToString();
                value.SHM7 = DataReader["SHM7"].ToString();
                value.SHM8 = DataReader["SHM8"].ToString();
                value.SHM9 = DataReader["SHM9"].ToString();
                value.SHM10 = DataReader["SHM10"].ToString();
                value.SHM11 = DataReader["SHM11"].ToString();
                value.SHM12 = DataReader["SHM12"].ToString();
                value.SHM13 = DataReader["SHM13"].ToString();
                value.SHM14 = DataReader["SHM14"].ToString();
                value.ST_TB = DataReader.GetInt("ST_TB");
                value.ST_TB_LoaiTeBao = DataReader["ST_TB_LoaiTeBao"].ToString();
                value.ST_TrungBi = DataReader.GetInt("ST_TrungBi");
                value.HoaMoMienDich = DataReader.GetInt("HoaMoMienDich");
                value.NuocTieu_Protein = DataReader["NuocTieu_Protein"].ToString();
                value.NuocTieu_Duong = DataReader["NuocTieu_Duong"].ToString();
                value.NuocTieu_HC = DataReader["NuocTieu_HC"].ToString();
                value.NuocTieu_BC = DataReader["NuocTieu_BC"].ToString();
                value.NuocTieu_NIT = DataReader["NuocTieu_NIT"].ToString();
                value.NuocTieu_TBTru = DataReader["NuocTieu_TBTru"].ToString();
                value.HIV = DataReader["HIV"].ToString();
                value.HB_CacXetNghiemKhac = DataReader["HB_CacXetNghiemKhac"].ToString();
                value.ChanDoan = DataReader.GetInt("ChanDoan");
                value.HB_DieuTri = DataReader["HB_DieuTri"].ToString();
                value.NgayTaiKham = DataReader.GetDate("NgayTaiKham");
                value.KB_Mach = DataReader["KB_Mach"].ToString();
                value.KB_NhipTho = DataReader["KB_NhipTho"].ToString();
                value.KB_HuyetAp = DataReader["KB_HuyetAp"].ToString();
                value.BoPhan_ThuongTonDa = DataReader["BoPhan_ThuongTonDa"].ToString();
                value.KB_TimMach = DataReader["KB_TimMach"].ToString();
                value.KB_HoHap = DataReader["KB_HoHap"].ToString();
                value.KB_TieuHoa = DataReader["KB_TieuHoa"].ToString();
                value.KB_ThanTietNieu = DataReader["KB_ThanTietNieu"].ToString();
                value.KB_CoXuongKhop = DataReader["KB_CoXuongKhop"].ToString();
                value.KB_BoPhanKhac = DataReader["KB_BoPhanKhac"].ToString();
                value.KB_CTM1 = DataReader["KB_CTM1"].ToString();
                value.KB_CTM2 = DataReader["KB_CTM2"].ToString();
                value.KB_CTM3 = DataReader["KB_CTM3"].ToString();
                value.KB_CTM4 = DataReader["KB_CTM4"].ToString();
                value.KB_CTM5 = DataReader["KB_CTM5"].ToString();
                value.KB_MauLang1 = DataReader["KB_MauLang1"].ToString();
                value.KB_MauLang2 = DataReader["KB_MauLang2"].ToString();
                value.KB_SHM1 = DataReader["KB_SHM1"].ToString();
                value.KB_SHM2 = DataReader["KB_SHM2"].ToString();
                value.KB_SHM3 = DataReader["KB_SHM3"].ToString();
                value.KB_SHM4 = DataReader["KB_SHM4"].ToString();
                value.KB_SHM5 = DataReader["KB_SHM5"].ToString();
                value.KB_SHM6 = DataReader["KB_SHM6"].ToString();
                value.KB_SHM7 = DataReader["KB_SHM7"].ToString();
                value.KB_SHM8 = DataReader["KB_SHM8"].ToString();
                value.KB_SHM9 = DataReader["KB_SHM9"].ToString();
                value.KB_SHM10 = DataReader["KB_SHM10"].ToString();
                value.KB_SHM11 = DataReader["KB_SHM11"].ToString();
                value.KB_SHM12 = DataReader["KB_SHM12"].ToString();
                value.KB_SHM13 = DataReader["KB_SHM13"].ToString();
                value.KB_SHM14 = DataReader["KB_SHM14"].ToString();
                value.KB_NuocTieu_Protein = DataReader["KB_NuocTieu_Protein"].ToString();
                value.KB_NuocTieu_Duong = DataReader["KB_NuocTieu_Duong"].ToString();
                value.KB_NuocTieu_HC = DataReader["KB_NuocTieu_HC"].ToString();
                value.KB_NuocTieu_BC = DataReader["KB_NuocTieu_BC"].ToString();
                value.KB_NuocTieu_NIT = DataReader["KB_NuocTieu_NIT"].ToString();
                value.KB_NuocTieu_TBTru = DataReader["KB_NuocTieu_TBTru"].ToString();
                value.KB_ST_TB = DataReader.GetInt("KB_ST_TB");
                value.KB_ST_TB_LoaiTeBao = DataReader["KB_ST_TB_LoaiTeBao"].ToString();
                value.KB_ST_TrungBi = DataReader.GetInt("KB_ST_TrungBi");
                value.KB_CacXetNghiemKhac = DataReader["KB_CacXetNghiemKhac"].ToString();
                value.KB_DieuTri = DataReader["KB_DieuTri"].ToString();
                value.ChanDoan_BenhKemTheo = DataReader["ChanDoan_BenhKemTheo"].ToString();
                value.ChanDoan_BenhChinh = DataReader["ChanDoan_BenhChinh"].ToString();
                value.KB_NgayTaiKham = DataReader.GetDate("KB_NgayTaiKham");
                value.MaSoKyTen = DataReader["MaSoKyTen"].ToString();
                value.MaSoKyTen_KB = DataReader["MaSoKyTen_KB"].ToString();
                value.MaSoKyTen_TK = DataReader["MaSoKyTen_TK"].ToString();
            }
            return value;
        }

        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, BenhAnNgoaiTruAVayNen BenhAnNgoaiTruAVayNen)
        {
            string sql =
                      @"select MaQuanLy 
                        from BENHANNTAVAYNEN
                        where MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnNgoaiTruAVayNen.MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            int rowCount = 0;
            while (DataReader.Read()) rowCount++;
            if (rowCount == 1) return Update(MyConnection, BenhAnNgoaiTruAVayNen);
            sql = @"
                   INSERT INTO BENHANNTAVAYNEN (
                            maquanly,
                            lydovaovien,
                            vaongaythu,
                            hb_tgphatbenh,
                            hb_trieutrungdautien,
                            hb_tgbidayda,
                            hb_quatrinhbenhly,
                            hb_dieutritruocday,
                            hb_tsbt_tgmacbenh,
                            hb_tsbt_benhdakhac,
                            hb_tsbt_benhnoikhoakhac,
                            hb_tiensugiadinh,
                            hb_trieuconang,
                            hb_ls_mach,
                            hb_ls_huyetap,
                            hb_ls_nhietdo,
                            hb_ls_nhiptho,
                            hb_ls_timmach,
                            hb_ls_hohap,
                            hb_ls_tieuhoa,
                            hb_ls_thantietnieu,
                            hb_ls_coxuongkhop,
                            hb_ls_bophankhac,
                            hb_ls_ttdakichthuoc,
                            datdo_kichthuoc,
                            datdo_hinhdang,
                            datdo_ranhgioi,
                            datdo_mausac,
                            vayda,
                            datdo_hinhdang_khac,
                            datdo_mausac_khac,
                            vitri_khac,
                            vitri,
                            phanbo,
                            phanbo_khac,
                            poki,
                            dhganxi,
                            ctm1,
                            ctm2,
                            ctm3,
                            ctm4,
                            ctm5,
                            maulang1,
                            maulang2,
                            shm1,
                            shm2,
                            shm3,
                            shm4,
                            shm5,
                            shm6,
                            shm7,
                            shm8,
                            shm9,
                            shm10,
                            shm11,
                            shm12,
                            shm13,
                            shm14,
                            st_tb,
                            st_tb_loaitebao,
                            st_trungbi,
                            hoamomiendich,
                            nuoctieu_protein,
                            nuoctieu_duong,
                            nuoctieu_hc,
                            nuoctieu_bc,
                            nuoctieu_nit,
                            nuoctieu_tbtru,
                            hiv,
                            hb_cacxetnghiemkhac,
                            chandoan,
                            hb_dieutri,
                            ngaytaikham,
                            kb_mach,
                            kb_nhiptho,
                            kb_huyetap,
                            bophan_thuongtonda,
                            kb_timmach,
                            kb_hohap,
                            kb_tieuhoa,
                            kb_thantietnieu,
                            kb_coxuongkhop,
                            kb_bophankhac,
                            kb_ctm1,
                            kb_ctm2,
                            kb_ctm3,
                            kb_ctm4,
                            kb_ctm5,
                            kb_maulang1,
                            kb_maulang2,
                            kb_shm1,
                            kb_shm2,
                            kb_shm3,
                            kb_shm4,
                            kb_shm5,
                            kb_shm6,
                            kb_shm7,
                            kb_shm8,
                            kb_shm9,
                            kb_shm10,
                            kb_shm11,
                            kb_shm12,
                            kb_shm13,
                            kb_shm14,
                            kb_nuoctieu_protein,
                            kb_nuoctieu_duong,
                            kb_nuoctieu_hc,
                            kb_nuoctieu_bc,
                            kb_nuoctieu_nit,
                            kb_nuoctieu_tbtru,
                            kb_st_tb,
                            kb_st_tb_loaitebao,
                            kb_st_trungbi,
                            kb_cacxetnghiemkhac,
                            kb_dieutri,
                            chandoan_benhkemtheo,
                            chandoan_benhchinh,
                            kb_ngaytaikham 
                    )
                   VALUES(
                            :maquanly,
                            :lydovaovien,
                            :vaongaythu,
                            :hb_tgphatbenh,
                            :hb_trieutrungdautien,
                            :hb_tgbidayda,
                            :hb_quatrinhbenhly,
                            :hb_dieutritruocday,
                            :hb_tsbt_tgmacbenh,
                            :hb_tsbt_benhdakhac,
                            :hb_tsbt_benhnoikhoakhac,
                            :hb_tiensugiadinh,
                            :hb_trieuconang,
                            :hb_ls_mach,
                            :hb_ls_huyetap,
                            :hb_ls_nhietdo,
                            :hb_ls_nhiptho,
                            :hb_ls_timmach,
                            :hb_ls_hohap,
                            :hb_ls_tieuhoa,
                            :hb_ls_thantietnieu,
                            :hb_ls_coxuongkhop,
                            :hb_ls_bophankhac,
                            :hb_ls_ttdakichthuoc,
                            :datdo_kichthuoc,
                            :datdo_hinhdang,
                            :datdo_ranhgioi,
                            :datdo_mausac,
                            :vayda,
                            :datdo_hinhdang_khac,
                            :datdo_mausac_khac,
                            :vitri_khac,
                            :vitri,
                            :phanbo,
                            :phanbo_khac,
                            :poki,
                            :dhganxi,
                            :ctm1,
                            :ctm2,
                            :ctm3,
                            :ctm4,
                            :ctm5,
                            :maulang1,
                            :maulang2,
                            :shm1,
                            :shm2,
                            :shm3,
                            :shm4,
                            :shm5,
                            :shm6,
                            :shm7,
                            :shm8,
                            :shm9,
                            :shm10,
                            :shm11,
                            :shm12,
                            :shm13,
                            :shm14,
                            :st_tb,
                            :st_tb_loaitebao,
                            :st_trungbi,
                            :hoamomiendich,
                            :nuoctieu_protein,
                            :nuoctieu_duong,
                            :nuoctieu_hc,
                            :nuoctieu_bc,
                            :nuoctieu_nit,
                            :nuoctieu_tbtru,
                            :hiv,
                            :hb_cacxetnghiemkhac,
                            :chandoan,
                            :hb_dieutri,
                            :ngaytaikham,
                            :kb_mach,
                            :kb_nhiptho,
                            :kb_huyetap,
                            :bophan_thuongtonda,
                            :kb_timmach,
                            :kb_hohap,
                            :kb_tieuhoa,
                            :kb_thantietnieu,
                            :kb_coxuongkhop,
                            :kb_bophankhac,
                            :kb_ctm1,
                            :kb_ctm2,
                            :kb_ctm3,
                            :kb_ctm4,
                            :kb_ctm5,
                            :kb_maulang1,
                            :kb_maulang2,
                            :kb_shm1,
                            :kb_shm2,
                            :kb_shm3,
                            :kb_shm4,
                            :kb_shm5,
                            :kb_shm6,
                            :kb_shm7,
                            :kb_shm8,
                            :kb_shm9,
                            :kb_shm10,
                            :kb_shm11,
                            :kb_shm12,
                            :kb_shm13,
                            :kb_shm14,
                            :kb_nuoctieu_protein,
                            :kb_nuoctieu_duong,
                            :kb_nuoctieu_hc,
                            :kb_nuoctieu_bc,
                            :kb_nuoctieu_nit,
                            :kb_nuoctieu_tbtru,
                            :kb_st_tb,
                            :kb_st_tb_loaitebao,
                            :kb_st_trungbi,
                            :kb_cacxetnghiemkhac,
                            :kb_dieutri,
                            :chandoan_benhkemtheo,
                            :chandoan_benhchinh,
                            :kb_ngaytaikham  

                    )
                   ";
            Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnNgoaiTruAVayNen.MaQuanLy));
            Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnNgoaiTruAVayNen.LyDoVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("VaoNgayThu", BenhAnNgoaiTruAVayNen.VaoNgayThu));
            Command.Parameters.Add(new MDB.MDBParameter("HB_TGPhatBenh", BenhAnNgoaiTruAVayNen.HB_TGPhatBenh));
            Command.Parameters.Add(new MDB.MDBParameter("HB_TrieuTrungDauTien", BenhAnNgoaiTruAVayNen.HB_TrieuTrungDauTien));
            Command.Parameters.Add(new MDB.MDBParameter("HB_TGBiDayDa", BenhAnNgoaiTruAVayNen.HB_TGBiDayDa));
            Command.Parameters.Add(new MDB.MDBParameter("HB_QuaTrinhBenhLy", BenhAnNgoaiTruAVayNen.HB_QuaTrinhBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("HB_DieuTriTruocDay", BenhAnNgoaiTruAVayNen.HB_DieuTriTruocDay));
            Command.Parameters.Add(new MDB.MDBParameter("HB_TSBT_TGMacBenh", BenhAnNgoaiTruAVayNen.HB_TSBT_TGMacBenh));
            Command.Parameters.Add(new MDB.MDBParameter("HB_TSBT_BenhDaKhac", BenhAnNgoaiTruAVayNen.HB_TSBT_BenhDaKhac));
            Command.Parameters.Add(new MDB.MDBParameter("HB_TSBT_BenhNoiKhoaKhac", BenhAnNgoaiTruAVayNen.HB_TSBT_BenhNoiKhoaKhac));
            Command.Parameters.Add(new MDB.MDBParameter("HB_TienSuGiaDinh", BenhAnNgoaiTruAVayNen.HB_TienSuGiaDinh));
            Command.Parameters.Add(new MDB.MDBParameter("HB_TrieuCoNang", BenhAnNgoaiTruAVayNen.HB_TrieuCoNang));
            Command.Parameters.Add(new MDB.MDBParameter("HB_LS_Mach", BenhAnNgoaiTruAVayNen.HB_LS_Mach));
            Command.Parameters.Add(new MDB.MDBParameter("HB_LS_HuyetAp", BenhAnNgoaiTruAVayNen.HB_LS_HuyetAp));
            Command.Parameters.Add(new MDB.MDBParameter("HB_LS_NhietDo", BenhAnNgoaiTruAVayNen.HB_LS_NhietDo));
            Command.Parameters.Add(new MDB.MDBParameter("HB_LS_NhipTho", BenhAnNgoaiTruAVayNen.HB_LS_NhipTho));
            Command.Parameters.Add(new MDB.MDBParameter("HB_LS_TimMach", BenhAnNgoaiTruAVayNen.HB_LS_TimMach));
            Command.Parameters.Add(new MDB.MDBParameter("HB_LS_HoHap", BenhAnNgoaiTruAVayNen.HB_LS_HoHap));
            Command.Parameters.Add(new MDB.MDBParameter("HB_LS_TieuHoa", BenhAnNgoaiTruAVayNen.HB_LS_TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("HB_LS_ThanTietNieu", BenhAnNgoaiTruAVayNen.HB_LS_ThanTietNieu));
            Command.Parameters.Add(new MDB.MDBParameter("HB_LS_CoXuongKhop", BenhAnNgoaiTruAVayNen.HB_LS_CoXuongKhop));
            Command.Parameters.Add(new MDB.MDBParameter("HB_LS_BoPhanKhac", BenhAnNgoaiTruAVayNen.HB_LS_BoPhanKhac));
            Command.Parameters.Add(new MDB.MDBParameter("HB_LS_TTDaKichThuoc", BenhAnNgoaiTruAVayNen.HB_LS_TTDaKichThuoc));
            Command.Parameters.Add(new MDB.MDBParameter("DatDo_KichThuoc", BenhAnNgoaiTruAVayNen.DatDo_KichThuoc));
            Command.Parameters.Add(new MDB.MDBParameter("DatDo_HinhDang", BenhAnNgoaiTruAVayNen.DatDo_HinhDang));
            Command.Parameters.Add(new MDB.MDBParameter("DatDo_RanhGioi", BenhAnNgoaiTruAVayNen.DatDo_RanhGioi));
            Command.Parameters.Add(new MDB.MDBParameter("DatDo_MauSac", BenhAnNgoaiTruAVayNen.DatDo_MauSac));
            Command.Parameters.Add(new MDB.MDBParameter("VayDa", BenhAnNgoaiTruAVayNen.VayDa));
            Command.Parameters.Add(new MDB.MDBParameter("DatDo_HinhDang_Khac", BenhAnNgoaiTruAVayNen.DatDo_HinhDang_Khac));
            Command.Parameters.Add(new MDB.MDBParameter("DatDo_MauSac_Khac", BenhAnNgoaiTruAVayNen.DatDo_MauSac_Khac));
            Command.Parameters.Add(new MDB.MDBParameter("ViTri_Khac", BenhAnNgoaiTruAVayNen.ViTri_Khac));
            Command.Parameters.Add(new MDB.MDBParameter("ViTri", BenhAnNgoaiTruAVayNen.ViTri));
            Command.Parameters.Add(new MDB.MDBParameter("PhanBo", BenhAnNgoaiTruAVayNen.PhanBo));
            Command.Parameters.Add(new MDB.MDBParameter("PhanBo_Khac", BenhAnNgoaiTruAVayNen.PhanBo_Khac));
            Command.Parameters.Add(new MDB.MDBParameter("PoKi", BenhAnNgoaiTruAVayNen.PoKi));
            Command.Parameters.Add(new MDB.MDBParameter("DHGanXi", BenhAnNgoaiTruAVayNen.DHGanXi));
            Command.Parameters.Add(new MDB.MDBParameter("CTM1", BenhAnNgoaiTruAVayNen.CTM1));
            Command.Parameters.Add(new MDB.MDBParameter("CTM2", BenhAnNgoaiTruAVayNen.CTM2));
            Command.Parameters.Add(new MDB.MDBParameter("CTM3", BenhAnNgoaiTruAVayNen.CTM3));
            Command.Parameters.Add(new MDB.MDBParameter("CTM4", BenhAnNgoaiTruAVayNen.CTM4));
            Command.Parameters.Add(new MDB.MDBParameter("CTM5", BenhAnNgoaiTruAVayNen.CTM5));
            Command.Parameters.Add(new MDB.MDBParameter("MauLang1", BenhAnNgoaiTruAVayNen.MauLang1));
            Command.Parameters.Add(new MDB.MDBParameter("MauLang2", BenhAnNgoaiTruAVayNen.MauLang2));
            Command.Parameters.Add(new MDB.MDBParameter("SHM1", BenhAnNgoaiTruAVayNen.SHM1));
            Command.Parameters.Add(new MDB.MDBParameter("SHM2", BenhAnNgoaiTruAVayNen.SHM2));
            Command.Parameters.Add(new MDB.MDBParameter("SHM3", BenhAnNgoaiTruAVayNen.SHM3));
            Command.Parameters.Add(new MDB.MDBParameter("SHM4", BenhAnNgoaiTruAVayNen.SHM4));
            Command.Parameters.Add(new MDB.MDBParameter("SHM5", BenhAnNgoaiTruAVayNen.SHM5));
            Command.Parameters.Add(new MDB.MDBParameter("SHM6", BenhAnNgoaiTruAVayNen.SHM6));
            Command.Parameters.Add(new MDB.MDBParameter("SHM7", BenhAnNgoaiTruAVayNen.SHM7));
            Command.Parameters.Add(new MDB.MDBParameter("SHM8", BenhAnNgoaiTruAVayNen.SHM8));
            Command.Parameters.Add(new MDB.MDBParameter("SHM9", BenhAnNgoaiTruAVayNen.SHM9));
            Command.Parameters.Add(new MDB.MDBParameter("SHM10", BenhAnNgoaiTruAVayNen.SHM10));
            Command.Parameters.Add(new MDB.MDBParameter("SHM11", BenhAnNgoaiTruAVayNen.SHM11));
            Command.Parameters.Add(new MDB.MDBParameter("SHM12", BenhAnNgoaiTruAVayNen.SHM12));
            Command.Parameters.Add(new MDB.MDBParameter("SHM13", BenhAnNgoaiTruAVayNen.SHM13));
            Command.Parameters.Add(new MDB.MDBParameter("SHM14", BenhAnNgoaiTruAVayNen.SHM14));
            Command.Parameters.Add(new MDB.MDBParameter("ST_TB", BenhAnNgoaiTruAVayNen.ST_TB));
            Command.Parameters.Add(new MDB.MDBParameter("ST_TB_LoaiTeBao", BenhAnNgoaiTruAVayNen.ST_TB_LoaiTeBao));
            Command.Parameters.Add(new MDB.MDBParameter("ST_TrungBi", BenhAnNgoaiTruAVayNen.ST_TrungBi));
            Command.Parameters.Add(new MDB.MDBParameter("HoaMoMienDich", BenhAnNgoaiTruAVayNen.HoaMoMienDich));
            Command.Parameters.Add(new MDB.MDBParameter("NuocTieu_Protein", BenhAnNgoaiTruAVayNen.NuocTieu_Protein));
            Command.Parameters.Add(new MDB.MDBParameter("NuocTieu_Duong", BenhAnNgoaiTruAVayNen.NuocTieu_Duong));
            Command.Parameters.Add(new MDB.MDBParameter("NuocTieu_HC", BenhAnNgoaiTruAVayNen.NuocTieu_HC));
            Command.Parameters.Add(new MDB.MDBParameter("NuocTieu_BC", BenhAnNgoaiTruAVayNen.NuocTieu_BC));
            Command.Parameters.Add(new MDB.MDBParameter("NuocTieu_NIT", BenhAnNgoaiTruAVayNen.NuocTieu_NIT));
            Command.Parameters.Add(new MDB.MDBParameter("NuocTieu_TBTru", BenhAnNgoaiTruAVayNen.NuocTieu_TBTru));
            Command.Parameters.Add(new MDB.MDBParameter("HIV", BenhAnNgoaiTruAVayNen.HIV));
            Command.Parameters.Add(new MDB.MDBParameter("HB_CacXetNghiemKhac", BenhAnNgoaiTruAVayNen.HB_CacXetNghiemKhac));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", BenhAnNgoaiTruAVayNen.ChanDoan));
            Command.Parameters.Add(new MDB.MDBParameter("HB_DieuTri", BenhAnNgoaiTruAVayNen.HB_DieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("NgayTaiKham", BenhAnNgoaiTruAVayNen.NgayTaiKham));
            Command.Parameters.Add(new MDB.MDBParameter("KB_Mach", BenhAnNgoaiTruAVayNen.KB_Mach));
            Command.Parameters.Add(new MDB.MDBParameter("KB_NhipTho", BenhAnNgoaiTruAVayNen.KB_NhipTho));
            Command.Parameters.Add(new MDB.MDBParameter("KB_HuyetAp", BenhAnNgoaiTruAVayNen.KB_HuyetAp));
            Command.Parameters.Add(new MDB.MDBParameter("BoPhan_ThuongTonDa", BenhAnNgoaiTruAVayNen.BoPhan_ThuongTonDa));
            Command.Parameters.Add(new MDB.MDBParameter("KB_TimMach", BenhAnNgoaiTruAVayNen.KB_TimMach));
            Command.Parameters.Add(new MDB.MDBParameter("KB_HoHap", BenhAnNgoaiTruAVayNen.KB_HoHap));
            Command.Parameters.Add(new MDB.MDBParameter("KB_TieuHoa", BenhAnNgoaiTruAVayNen.KB_TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("KB_ThanTietNieu", BenhAnNgoaiTruAVayNen.KB_ThanTietNieu));
            Command.Parameters.Add(new MDB.MDBParameter("KB_CoXuongKhop", BenhAnNgoaiTruAVayNen.KB_CoXuongKhop));
            Command.Parameters.Add(new MDB.MDBParameter("KB_BoPhanKhac", BenhAnNgoaiTruAVayNen.KB_BoPhanKhac));
            Command.Parameters.Add(new MDB.MDBParameter("KB_CTM1", BenhAnNgoaiTruAVayNen.KB_CTM1));
            Command.Parameters.Add(new MDB.MDBParameter("KB_CTM2", BenhAnNgoaiTruAVayNen.KB_CTM2));
            Command.Parameters.Add(new MDB.MDBParameter("KB_CTM3", BenhAnNgoaiTruAVayNen.KB_CTM3));
            Command.Parameters.Add(new MDB.MDBParameter("KB_CTM4", BenhAnNgoaiTruAVayNen.KB_CTM4));
            Command.Parameters.Add(new MDB.MDBParameter("KB_CTM5", BenhAnNgoaiTruAVayNen.KB_CTM5));
            Command.Parameters.Add(new MDB.MDBParameter("KB_MauLang1", BenhAnNgoaiTruAVayNen.KB_MauLang1));
            Command.Parameters.Add(new MDB.MDBParameter("KB_MauLang2", BenhAnNgoaiTruAVayNen.KB_MauLang2));
            Command.Parameters.Add(new MDB.MDBParameter("KB_SHM1", BenhAnNgoaiTruAVayNen.KB_SHM1));
            Command.Parameters.Add(new MDB.MDBParameter("KB_SHM2", BenhAnNgoaiTruAVayNen.KB_SHM2));
            Command.Parameters.Add(new MDB.MDBParameter("KB_SHM3", BenhAnNgoaiTruAVayNen.KB_SHM3));
            Command.Parameters.Add(new MDB.MDBParameter("KB_SHM4", BenhAnNgoaiTruAVayNen.KB_SHM4));
            Command.Parameters.Add(new MDB.MDBParameter("KB_SHM5", BenhAnNgoaiTruAVayNen.KB_SHM5));
            Command.Parameters.Add(new MDB.MDBParameter("KB_SHM6", BenhAnNgoaiTruAVayNen.KB_SHM6));
            Command.Parameters.Add(new MDB.MDBParameter("KB_SHM7", BenhAnNgoaiTruAVayNen.KB_SHM7));
            Command.Parameters.Add(new MDB.MDBParameter("KB_SHM8", BenhAnNgoaiTruAVayNen.KB_SHM8));
            Command.Parameters.Add(new MDB.MDBParameter("KB_SHM9", BenhAnNgoaiTruAVayNen.KB_SHM9));
            Command.Parameters.Add(new MDB.MDBParameter("KB_SHM10", BenhAnNgoaiTruAVayNen.KB_SHM10));
            Command.Parameters.Add(new MDB.MDBParameter("KB_SHM11", BenhAnNgoaiTruAVayNen.KB_SHM11));
            Command.Parameters.Add(new MDB.MDBParameter("KB_SHM12", BenhAnNgoaiTruAVayNen.KB_SHM12));
            Command.Parameters.Add(new MDB.MDBParameter("KB_SHM13", BenhAnNgoaiTruAVayNen.KB_SHM13));
            Command.Parameters.Add(new MDB.MDBParameter("KB_SHM14", BenhAnNgoaiTruAVayNen.KB_SHM14));
            Command.Parameters.Add(new MDB.MDBParameter("KB_NuocTieu_Protein", BenhAnNgoaiTruAVayNen.KB_NuocTieu_Protein));
            Command.Parameters.Add(new MDB.MDBParameter("KB_NuocTieu_Duong", BenhAnNgoaiTruAVayNen.KB_NuocTieu_Duong));
            Command.Parameters.Add(new MDB.MDBParameter("KB_NuocTieu_HC", BenhAnNgoaiTruAVayNen.KB_NuocTieu_HC));
            Command.Parameters.Add(new MDB.MDBParameter("KB_NuocTieu_BC", BenhAnNgoaiTruAVayNen.KB_NuocTieu_BC));
            Command.Parameters.Add(new MDB.MDBParameter("KB_NuocTieu_NIT", BenhAnNgoaiTruAVayNen.KB_NuocTieu_NIT));
            Command.Parameters.Add(new MDB.MDBParameter("KB_NuocTieu_TBTru", BenhAnNgoaiTruAVayNen.KB_NuocTieu_TBTru));
            Command.Parameters.Add(new MDB.MDBParameter("KB_ST_TB", BenhAnNgoaiTruAVayNen.KB_ST_TB));
            Command.Parameters.Add(new MDB.MDBParameter("KB_ST_TB_LoaiTeBao", BenhAnNgoaiTruAVayNen.KB_ST_TB_LoaiTeBao));
            Command.Parameters.Add(new MDB.MDBParameter("KB_ST_TrungBi", BenhAnNgoaiTruAVayNen.KB_ST_TrungBi));
            Command.Parameters.Add(new MDB.MDBParameter("KB_CacXetNghiemKhac", BenhAnNgoaiTruAVayNen.KB_CacXetNghiemKhac));
            Command.Parameters.Add(new MDB.MDBParameter("KB_DieuTri", BenhAnNgoaiTruAVayNen.KB_DieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoan_BenhKemTheo", BenhAnNgoaiTruAVayNen.ChanDoan_BenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoan_BenhChinh", BenhAnNgoaiTruAVayNen.ChanDoan_BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("KB_NgayTaiKham", BenhAnNgoaiTruAVayNen.KB_NgayTaiKham));




            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool Update(MDB.MDBConnection MyConnection, BenhAnNgoaiTruAVayNen BenhAnNgoaiTruAVayNen)
        {
            string sql = @"UPDATE BENHANNTAVAYNEN SET 
                        LyDoVaoVien =: LyDoVaoVien,
                        VaoNgayThu =: VaoNgayThu,
                        HB_TGPhatBenh =: HB_TGPhatBenh,
                        HB_TrieuTrungDauTien =: HB_TrieuTrungDauTien,
                        HB_TGBiDayDa =: HB_TGBiDayDa,
                        HB_QuaTrinhBenhLy =: HB_QuaTrinhBenhLy,
                        HB_DieuTriTruocDay =: HB_DieuTriTruocDay,
                        HB_TSBT_TGMacBenh =: HB_TSBT_TGMacBenh,
                        HB_TSBT_BenhDaKhac =: HB_TSBT_BenhDaKhac,
                        HB_TSBT_BenhNoiKhoaKhac =: HB_TSBT_BenhNoiKhoaKhac,
                        HB_TienSuGiaDinh =: HB_TienSuGiaDinh,
                        HB_TrieuCoNang =: HB_TrieuCoNang,
                        HB_LS_Mach =: HB_LS_Mach,
                        HB_LS_HuyetAp =: HB_LS_HuyetAp,
                        HB_LS_NhietDo =: HB_LS_NhietDo,
                        HB_LS_NhipTho =: HB_LS_NhipTho,
                        HB_LS_TimMach =: HB_LS_TimMach,
                        HB_LS_HoHap =: HB_LS_HoHap,
                        HB_LS_TieuHoa =: HB_LS_TieuHoa,
                        HB_LS_ThanTietNieu =: HB_LS_ThanTietNieu,
                        HB_LS_CoXuongKhop =: HB_LS_CoXuongKhop,
                        HB_LS_BoPhanKhac =: HB_LS_BoPhanKhac,
                        HB_LS_TTDaKichThuoc =: HB_LS_TTDaKichThuoc,
                        DatDo_KichThuoc =: DatDo_KichThuoc,
                        DatDo_HinhDang =: DatDo_HinhDang,
                        DatDo_RanhGioi =: DatDo_RanhGioi,
                        DatDo_MauSac =: DatDo_MauSac,
                        VayDa =: VayDa,
                        DatDo_HinhDang_Khac =: DatDo_HinhDang_Khac,
                        DatDo_MauSac_Khac =: DatDo_MauSac_Khac,
                        ViTri_Khac =: ViTri_Khac,
                        ViTri =: ViTri,
                        PhanBo =: PhanBo,
                        PhanBo_Khac =: PhanBo_Khac,
                        PoKi =: PoKi,
                        DHGanXi =: DHGanXi,
                        CTM1 =: CTM1,
                        CTM2 =: CTM2,
                        CTM3 =: CTM3,
                        CTM4 =: CTM4,
                        CTM5 =: CTM5,
                        MauLang1 =: MauLang1,
                        MauLang2 =: MauLang2,
                        SHM1 =: SHM1,
                        SHM2 =: SHM2,
                        SHM3 =: SHM3,
                        SHM4 =: SHM4,
                        SHM5 =: SHM5,
                        SHM6 =: SHM6,
                        SHM7 =: SHM7,
                        SHM8 =: SHM8,
                        SHM9 =: SHM9,
                        SHM10 =: SHM10,
                        SHM11 =: SHM11,
                        SHM12 =: SHM12,
                        SHM13 =: SHM13,
                        SHM14 =: SHM14,
                        ST_TB =: ST_TB,
                        ST_TB_LoaiTeBao =: ST_TB_LoaiTeBao,
                        ST_TrungBi =: ST_TrungBi,
                        HoaMoMienDich =: HoaMoMienDich,
                        NuocTieu_Protein =: NuocTieu_Protein,
                        NuocTieu_Duong =: NuocTieu_Duong,
                        NuocTieu_HC =: NuocTieu_HC,
                        NuocTieu_BC =: NuocTieu_BC,
                        NuocTieu_NIT =: NuocTieu_NIT,
                        NuocTieu_TBTru =: NuocTieu_TBTru,
                        HIV =: HIV,
                        HB_CacXetNghiemKhac =: HB_CacXetNghiemKhac,
                        ChanDoan =: ChanDoan,
                        HB_DieuTri =: HB_DieuTri,
                        NgayTaiKham =: NgayTaiKham,
                        KB_Mach =: KB_Mach,
                        KB_NhipTho =: KB_NhipTho,
                        KB_HuyetAp =: KB_HuyetAp,
                        BoPhan_ThuongTonDa =: BoPhan_ThuongTonDa,
                        KB_TimMach =: KB_TimMach,
                        KB_HoHap =: KB_HoHap,
                        KB_TieuHoa =: KB_TieuHoa,
                        KB_ThanTietNieu =: KB_ThanTietNieu,
                        KB_CoXuongKhop =: KB_CoXuongKhop,
                        KB_BoPhanKhac =: KB_BoPhanKhac,
                        KB_CTM1 =: KB_CTM1,
                        KB_CTM2 =: KB_CTM2,
                        KB_CTM3 =: KB_CTM3,
                        KB_CTM4 =: KB_CTM4,
                        KB_CTM5 =: KB_CTM5,
                        KB_MauLang1 =: KB_MauLang1,
                        KB_MauLang2 =: KB_MauLang2,
                        KB_SHM1 =: KB_SHM1,
                        KB_SHM2 =: KB_SHM2,
                        KB_SHM3 =: KB_SHM3,
                        KB_SHM4 =: KB_SHM4,
                        KB_SHM5 =: KB_SHM5,
                        KB_SHM6 =: KB_SHM6,
                        KB_SHM7 =: KB_SHM7,
                        KB_SHM8 =: KB_SHM8,
                        KB_SHM9 =: KB_SHM9,
                        KB_SHM10 =: KB_SHM10,
                        KB_SHM11 =: KB_SHM11,
                        KB_SHM12 =: KB_SHM12,
                        KB_SHM13 =: KB_SHM13,
                        KB_SHM14 =: KB_SHM14,
                        KB_NuocTieu_Protein =: KB_NuocTieu_Protein,
                        KB_NuocTieu_Duong =: KB_NuocTieu_Duong,
                        KB_NuocTieu_HC =: KB_NuocTieu_HC,
                        KB_NuocTieu_BC =: KB_NuocTieu_BC,
                        KB_NuocTieu_NIT =: KB_NuocTieu_NIT,
                        KB_NuocTieu_TBTru =: KB_NuocTieu_TBTru,
                        KB_ST_TB =: KB_ST_TB,
                        KB_ST_TB_LoaiTeBao =: KB_ST_TB_LoaiTeBao,
                        KB_ST_TrungBi =: KB_ST_TrungBi,
                        KB_CacXetNghiemKhac =: KB_CacXetNghiemKhac,
                        KB_DieuTri =: KB_DieuTri,
                        ChanDoan_BenhKemTheo =: ChanDoan_BenhKemTheo,
                        ChanDoan_BenhChinh =: ChanDoan_BenhChinh,
                        KB_NgayTaiKham =: KB_NgayTaiKham 


                        WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnNgoaiTruAVayNen.LyDoVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("VaoNgayThu", BenhAnNgoaiTruAVayNen.VaoNgayThu));
            Command.Parameters.Add(new MDB.MDBParameter("HB_TGPhatBenh", BenhAnNgoaiTruAVayNen.HB_TGPhatBenh));
            Command.Parameters.Add(new MDB.MDBParameter("HB_TrieuTrungDauTien", BenhAnNgoaiTruAVayNen.HB_TrieuTrungDauTien));
            Command.Parameters.Add(new MDB.MDBParameter("HB_TGBiDayDa", BenhAnNgoaiTruAVayNen.HB_TGBiDayDa));
            Command.Parameters.Add(new MDB.MDBParameter("HB_QuaTrinhBenhLy", BenhAnNgoaiTruAVayNen.HB_QuaTrinhBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("HB_DieuTriTruocDay", BenhAnNgoaiTruAVayNen.HB_DieuTriTruocDay));
            Command.Parameters.Add(new MDB.MDBParameter("HB_TSBT_TGMacBenh", BenhAnNgoaiTruAVayNen.HB_TSBT_TGMacBenh));
            Command.Parameters.Add(new MDB.MDBParameter("HB_TSBT_BenhDaKhac", BenhAnNgoaiTruAVayNen.HB_TSBT_BenhDaKhac));
            Command.Parameters.Add(new MDB.MDBParameter("HB_TSBT_BenhNoiKhoaKhac", BenhAnNgoaiTruAVayNen.HB_TSBT_BenhNoiKhoaKhac));
            Command.Parameters.Add(new MDB.MDBParameter("HB_TienSuGiaDinh", BenhAnNgoaiTruAVayNen.HB_TienSuGiaDinh));
            Command.Parameters.Add(new MDB.MDBParameter("HB_TrieuCoNang", BenhAnNgoaiTruAVayNen.HB_TrieuCoNang));
            Command.Parameters.Add(new MDB.MDBParameter("HB_LS_Mach", BenhAnNgoaiTruAVayNen.HB_LS_Mach));
            Command.Parameters.Add(new MDB.MDBParameter("HB_LS_HuyetAp", BenhAnNgoaiTruAVayNen.HB_LS_HuyetAp));
            Command.Parameters.Add(new MDB.MDBParameter("HB_LS_NhietDo", BenhAnNgoaiTruAVayNen.HB_LS_NhietDo));
            Command.Parameters.Add(new MDB.MDBParameter("HB_LS_NhipTho", BenhAnNgoaiTruAVayNen.HB_LS_NhipTho));
            Command.Parameters.Add(new MDB.MDBParameter("HB_LS_TimMach", BenhAnNgoaiTruAVayNen.HB_LS_TimMach));
            Command.Parameters.Add(new MDB.MDBParameter("HB_LS_HoHap", BenhAnNgoaiTruAVayNen.HB_LS_HoHap));
            Command.Parameters.Add(new MDB.MDBParameter("HB_LS_TieuHoa", BenhAnNgoaiTruAVayNen.HB_LS_TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("HB_LS_ThanTietNieu", BenhAnNgoaiTruAVayNen.HB_LS_ThanTietNieu));
            Command.Parameters.Add(new MDB.MDBParameter("HB_LS_CoXuongKhop", BenhAnNgoaiTruAVayNen.HB_LS_CoXuongKhop));
            Command.Parameters.Add(new MDB.MDBParameter("HB_LS_BoPhanKhac", BenhAnNgoaiTruAVayNen.HB_LS_BoPhanKhac));
            Command.Parameters.Add(new MDB.MDBParameter("HB_LS_TTDaKichThuoc", BenhAnNgoaiTruAVayNen.HB_LS_TTDaKichThuoc));
            Command.Parameters.Add(new MDB.MDBParameter("DatDo_KichThuoc", BenhAnNgoaiTruAVayNen.DatDo_KichThuoc));
            Command.Parameters.Add(new MDB.MDBParameter("DatDo_HinhDang", BenhAnNgoaiTruAVayNen.DatDo_HinhDang));
            Command.Parameters.Add(new MDB.MDBParameter("DatDo_RanhGioi", BenhAnNgoaiTruAVayNen.DatDo_RanhGioi));
            Command.Parameters.Add(new MDB.MDBParameter("DatDo_MauSac", BenhAnNgoaiTruAVayNen.DatDo_MauSac));
            Command.Parameters.Add(new MDB.MDBParameter("VayDa", BenhAnNgoaiTruAVayNen.VayDa));
            Command.Parameters.Add(new MDB.MDBParameter("DatDo_HinhDang_Khac", BenhAnNgoaiTruAVayNen.DatDo_HinhDang_Khac));
            Command.Parameters.Add(new MDB.MDBParameter("DatDo_MauSac_Khac", BenhAnNgoaiTruAVayNen.DatDo_MauSac_Khac));
            Command.Parameters.Add(new MDB.MDBParameter("ViTri_Khac", BenhAnNgoaiTruAVayNen.ViTri_Khac));
            Command.Parameters.Add(new MDB.MDBParameter("ViTri", BenhAnNgoaiTruAVayNen.ViTri));
            Command.Parameters.Add(new MDB.MDBParameter("PhanBo", BenhAnNgoaiTruAVayNen.PhanBo));
            Command.Parameters.Add(new MDB.MDBParameter("PhanBo_Khac", BenhAnNgoaiTruAVayNen.PhanBo_Khac));
            Command.Parameters.Add(new MDB.MDBParameter("PoKi", BenhAnNgoaiTruAVayNen.PoKi));
            Command.Parameters.Add(new MDB.MDBParameter("DHGanXi", BenhAnNgoaiTruAVayNen.DHGanXi));
            Command.Parameters.Add(new MDB.MDBParameter("CTM1", BenhAnNgoaiTruAVayNen.CTM1));
            Command.Parameters.Add(new MDB.MDBParameter("CTM2", BenhAnNgoaiTruAVayNen.CTM2));
            Command.Parameters.Add(new MDB.MDBParameter("CTM3", BenhAnNgoaiTruAVayNen.CTM3));
            Command.Parameters.Add(new MDB.MDBParameter("CTM4", BenhAnNgoaiTruAVayNen.CTM4));
            Command.Parameters.Add(new MDB.MDBParameter("CTM5", BenhAnNgoaiTruAVayNen.CTM5));
            Command.Parameters.Add(new MDB.MDBParameter("MauLang1", BenhAnNgoaiTruAVayNen.MauLang1));
            Command.Parameters.Add(new MDB.MDBParameter("MauLang2", BenhAnNgoaiTruAVayNen.MauLang2));
            Command.Parameters.Add(new MDB.MDBParameter("SHM1", BenhAnNgoaiTruAVayNen.SHM1));
            Command.Parameters.Add(new MDB.MDBParameter("SHM2", BenhAnNgoaiTruAVayNen.SHM2));
            Command.Parameters.Add(new MDB.MDBParameter("SHM3", BenhAnNgoaiTruAVayNen.SHM3));
            Command.Parameters.Add(new MDB.MDBParameter("SHM4", BenhAnNgoaiTruAVayNen.SHM4));
            Command.Parameters.Add(new MDB.MDBParameter("SHM5", BenhAnNgoaiTruAVayNen.SHM5));
            Command.Parameters.Add(new MDB.MDBParameter("SHM6", BenhAnNgoaiTruAVayNen.SHM6));
            Command.Parameters.Add(new MDB.MDBParameter("SHM7", BenhAnNgoaiTruAVayNen.SHM7));
            Command.Parameters.Add(new MDB.MDBParameter("SHM8", BenhAnNgoaiTruAVayNen.SHM8));
            Command.Parameters.Add(new MDB.MDBParameter("SHM9", BenhAnNgoaiTruAVayNen.SHM9));
            Command.Parameters.Add(new MDB.MDBParameter("SHM10", BenhAnNgoaiTruAVayNen.SHM10));
            Command.Parameters.Add(new MDB.MDBParameter("SHM11", BenhAnNgoaiTruAVayNen.SHM11));
            Command.Parameters.Add(new MDB.MDBParameter("SHM12", BenhAnNgoaiTruAVayNen.SHM12));
            Command.Parameters.Add(new MDB.MDBParameter("SHM13", BenhAnNgoaiTruAVayNen.SHM13));
            Command.Parameters.Add(new MDB.MDBParameter("SHM14", BenhAnNgoaiTruAVayNen.SHM14));
            Command.Parameters.Add(new MDB.MDBParameter("ST_TB", BenhAnNgoaiTruAVayNen.ST_TB));
            Command.Parameters.Add(new MDB.MDBParameter("ST_TB_LoaiTeBao", BenhAnNgoaiTruAVayNen.ST_TB_LoaiTeBao));
            Command.Parameters.Add(new MDB.MDBParameter("ST_TrungBi", BenhAnNgoaiTruAVayNen.ST_TrungBi));
            Command.Parameters.Add(new MDB.MDBParameter("HoaMoMienDich", BenhAnNgoaiTruAVayNen.HoaMoMienDich));
            Command.Parameters.Add(new MDB.MDBParameter("NuocTieu_Protein", BenhAnNgoaiTruAVayNen.NuocTieu_Protein));
            Command.Parameters.Add(new MDB.MDBParameter("NuocTieu_Duong", BenhAnNgoaiTruAVayNen.NuocTieu_Duong));
            Command.Parameters.Add(new MDB.MDBParameter("NuocTieu_HC", BenhAnNgoaiTruAVayNen.NuocTieu_HC));
            Command.Parameters.Add(new MDB.MDBParameter("NuocTieu_BC", BenhAnNgoaiTruAVayNen.NuocTieu_BC));
            Command.Parameters.Add(new MDB.MDBParameter("NuocTieu_NIT", BenhAnNgoaiTruAVayNen.NuocTieu_NIT));
            Command.Parameters.Add(new MDB.MDBParameter("NuocTieu_TBTru", BenhAnNgoaiTruAVayNen.NuocTieu_TBTru));
            Command.Parameters.Add(new MDB.MDBParameter("HIV", BenhAnNgoaiTruAVayNen.HIV));
            Command.Parameters.Add(new MDB.MDBParameter("HB_CacXetNghiemKhac", BenhAnNgoaiTruAVayNen.HB_CacXetNghiemKhac));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", BenhAnNgoaiTruAVayNen.ChanDoan));
            Command.Parameters.Add(new MDB.MDBParameter("HB_DieuTri", BenhAnNgoaiTruAVayNen.HB_DieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("NgayTaiKham", BenhAnNgoaiTruAVayNen.NgayTaiKham));
            Command.Parameters.Add(new MDB.MDBParameter("KB_Mach", BenhAnNgoaiTruAVayNen.KB_Mach));
            Command.Parameters.Add(new MDB.MDBParameter("KB_NhipTho", BenhAnNgoaiTruAVayNen.KB_NhipTho));
            Command.Parameters.Add(new MDB.MDBParameter("KB_HuyetAp", BenhAnNgoaiTruAVayNen.KB_HuyetAp));
            Command.Parameters.Add(new MDB.MDBParameter("BoPhan_ThuongTonDa", BenhAnNgoaiTruAVayNen.BoPhan_ThuongTonDa));
            Command.Parameters.Add(new MDB.MDBParameter("KB_TimMach", BenhAnNgoaiTruAVayNen.KB_TimMach));
            Command.Parameters.Add(new MDB.MDBParameter("KB_HoHap", BenhAnNgoaiTruAVayNen.KB_HoHap));
            Command.Parameters.Add(new MDB.MDBParameter("KB_TieuHoa", BenhAnNgoaiTruAVayNen.KB_TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("KB_ThanTietNieu", BenhAnNgoaiTruAVayNen.KB_ThanTietNieu));
            Command.Parameters.Add(new MDB.MDBParameter("KB_CoXuongKhop", BenhAnNgoaiTruAVayNen.KB_CoXuongKhop));
            Command.Parameters.Add(new MDB.MDBParameter("KB_BoPhanKhac", BenhAnNgoaiTruAVayNen.KB_BoPhanKhac));
            Command.Parameters.Add(new MDB.MDBParameter("KB_CTM1", BenhAnNgoaiTruAVayNen.KB_CTM1));
            Command.Parameters.Add(new MDB.MDBParameter("KB_CTM2", BenhAnNgoaiTruAVayNen.KB_CTM2));
            Command.Parameters.Add(new MDB.MDBParameter("KB_CTM3", BenhAnNgoaiTruAVayNen.KB_CTM3));
            Command.Parameters.Add(new MDB.MDBParameter("KB_CTM4", BenhAnNgoaiTruAVayNen.KB_CTM4));
            Command.Parameters.Add(new MDB.MDBParameter("KB_CTM5", BenhAnNgoaiTruAVayNen.KB_CTM5));
            Command.Parameters.Add(new MDB.MDBParameter("KB_MauLang1", BenhAnNgoaiTruAVayNen.KB_MauLang1));
            Command.Parameters.Add(new MDB.MDBParameter("KB_MauLang2", BenhAnNgoaiTruAVayNen.KB_MauLang2));
            Command.Parameters.Add(new MDB.MDBParameter("KB_SHM1", BenhAnNgoaiTruAVayNen.KB_SHM1));
            Command.Parameters.Add(new MDB.MDBParameter("KB_SHM2", BenhAnNgoaiTruAVayNen.KB_SHM2));
            Command.Parameters.Add(new MDB.MDBParameter("KB_SHM3", BenhAnNgoaiTruAVayNen.KB_SHM3));
            Command.Parameters.Add(new MDB.MDBParameter("KB_SHM4", BenhAnNgoaiTruAVayNen.KB_SHM4));
            Command.Parameters.Add(new MDB.MDBParameter("KB_SHM5", BenhAnNgoaiTruAVayNen.KB_SHM5));
            Command.Parameters.Add(new MDB.MDBParameter("KB_SHM6", BenhAnNgoaiTruAVayNen.KB_SHM6));
            Command.Parameters.Add(new MDB.MDBParameter("KB_SHM7", BenhAnNgoaiTruAVayNen.KB_SHM7));
            Command.Parameters.Add(new MDB.MDBParameter("KB_SHM8", BenhAnNgoaiTruAVayNen.KB_SHM8));
            Command.Parameters.Add(new MDB.MDBParameter("KB_SHM9", BenhAnNgoaiTruAVayNen.KB_SHM9));
            Command.Parameters.Add(new MDB.MDBParameter("KB_SHM10", BenhAnNgoaiTruAVayNen.KB_SHM10));
            Command.Parameters.Add(new MDB.MDBParameter("KB_SHM11", BenhAnNgoaiTruAVayNen.KB_SHM11));
            Command.Parameters.Add(new MDB.MDBParameter("KB_SHM12", BenhAnNgoaiTruAVayNen.KB_SHM12));
            Command.Parameters.Add(new MDB.MDBParameter("KB_SHM13", BenhAnNgoaiTruAVayNen.KB_SHM13));
            Command.Parameters.Add(new MDB.MDBParameter("KB_SHM14", BenhAnNgoaiTruAVayNen.KB_SHM14));
            Command.Parameters.Add(new MDB.MDBParameter("KB_NuocTieu_Protein", BenhAnNgoaiTruAVayNen.KB_NuocTieu_Protein));
            Command.Parameters.Add(new MDB.MDBParameter("KB_NuocTieu_Duong", BenhAnNgoaiTruAVayNen.KB_NuocTieu_Duong));
            Command.Parameters.Add(new MDB.MDBParameter("KB_NuocTieu_HC", BenhAnNgoaiTruAVayNen.KB_NuocTieu_HC));
            Command.Parameters.Add(new MDB.MDBParameter("KB_NuocTieu_BC", BenhAnNgoaiTruAVayNen.KB_NuocTieu_BC));
            Command.Parameters.Add(new MDB.MDBParameter("KB_NuocTieu_NIT", BenhAnNgoaiTruAVayNen.KB_NuocTieu_NIT));
            Command.Parameters.Add(new MDB.MDBParameter("KB_NuocTieu_TBTru", BenhAnNgoaiTruAVayNen.KB_NuocTieu_TBTru));
            Command.Parameters.Add(new MDB.MDBParameter("KB_ST_TB", BenhAnNgoaiTruAVayNen.KB_ST_TB));
            Command.Parameters.Add(new MDB.MDBParameter("KB_ST_TB_LoaiTeBao", BenhAnNgoaiTruAVayNen.KB_ST_TB_LoaiTeBao));
            Command.Parameters.Add(new MDB.MDBParameter("KB_ST_TrungBi", BenhAnNgoaiTruAVayNen.KB_ST_TrungBi));
            Command.Parameters.Add(new MDB.MDBParameter("KB_CacXetNghiemKhac", BenhAnNgoaiTruAVayNen.KB_CacXetNghiemKhac));
            Command.Parameters.Add(new MDB.MDBParameter("KB_DieuTri", BenhAnNgoaiTruAVayNen.KB_DieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoan_BenhKemTheo", BenhAnNgoaiTruAVayNen.ChanDoan_BenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoan_BenhChinh", BenhAnNgoaiTruAVayNen.ChanDoan_BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("KB_NgayTaiKham", BenhAnNgoaiTruAVayNen.KB_NgayTaiKham));

            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnNgoaiTruAVayNen.MaQuanLy));
            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool Delete(MDB.MDBConnection MyConnection, BenhAnNgoaiTruAVayNen BenhAnNgoaiTruAVayNen)
        {
            string sql = @"DELETE FROM BENHANNTAVAYNEN 
                           WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnNgoaiTruAVayNen.MaQuanLy));

            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
    }
}
