using EMR_MAIN.DATABASE.BenhAn;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.BenhAnFunc
{
    public class BenhAnViemGanBManTinhFunc
    {
        public static void WriteXml(MDB.MDBConnection MyConnection)
        {
            string sql =
                   @"
                  select  a.*,  CTScanner HoSo_CTScanner, SieuAm HoSo_SieuAm, XetNghiem HoSo_XetNghiem,  Khac HoSo_Khac,  Khac_Text HoSo_Khac_Text,  ToanBoHoSo HoSo_ToanBoHoSo, Mach DauSinhTon_Mach,  NhietDo DauSinhTon_NhietDo,  HuyetAp DauSinhTon_HuyetAp,  NhipTho DauSinhTon_NhipTho,  CanNang DauSinhTon_CanNang  
                  from BenhAnViemGanBManTinh a inner join thongtindieutri b on a.maquanly = b.maquanly
                  where rownum = 1
                    ";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            var DataTable = new DataTable { TableName = "BenhAnViemGanBManTinh" };
            DataTable.Load(DataReader as IDataReader);
            DataTable.WriteXml("rptBenhAnViemGanBManTinh.xml");
        }
        public static DataSet SelectDataSet(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql =
                   @"
                  select  a.*, f.hovaten BacSyHoVaTen  
                        from BenhAnViemGanBManTinh a  
                  left join nhanvien f on a.BacSyDieuTri = f.manhanvien 
                  where a.maquanly = " + MaQuanLy;
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(sql, MyConnection);
            var ds = new DataSet();
            adt.Fill(ds, "Table");

            return ds;
        }
        public static BenhAnViemGanBManTinh Select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            var obj = new BenhAnViemGanBManTinh();
            try
            {
                #region
                string sql =
                          @"select * 
                        from BenhAnViemGanBManTinh 
                        where MaQuanLy = :MaQuanLy";
                #endregion
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    // Phần chung Hành chính
                    obj.MaQuanLy = DataReader.GetDecimal("MaQuanLy");
                    obj.BacSyDieuTri = DataReader["BacSyDieuTri"].ToString();
                    obj.LyDoNhanVaoNC = DataReader["LyDoNhanVaoNC"].ToString();
                    obj.MeHbAg = DataReader.GetInt("MeHbAg");
                    obj.VoChongBanTinhHb = DataReader.GetInt("VoChongBanTinhHb");
                    obj.TruyenMau = DataReader.GetInt("TruyenMau");
                    obj.TonThuongDoKimDam = DataReader.GetInt("TonThuongDoKimDam");
                    obj.DongNhiemVR = DataReader.GetInt("DongNhiemVR");
                    obj.CoTrieuChung = DataReader.GetInt("CoTrieuChung");
                    obj.KhamSKDinhKy = DataReader.GetInt("KhamSKDinhKy");
                    obj.TinhCo = DataReader.GetInt("TinhCo");
                    obj.TDPHB_HBsAg = DataReader["TDPHB_HBsAg"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["TDPHB_HBsAg"]) : null;
                    obj.VGSVBMan = DataReader["VGSVBMan"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["VGSVBMan"]) : null;
                    obj.DaDieuTriVGSVBMan = DataReader.GetInt("DaDieuTriVGSVBMan");
                    obj.GhiRoThuocDieuTri = DataReader["GhiRoThuocDieuTri"].ToString();
                    obj.TienSuSinhDe = DataReader["TienSuSinhDe"].ToString();
                    obj.ConDaTiemPhong = DataReader.GetInt("ConDaTiemPhong");
                    obj.BanThanDaTiemPhong = DataReader.GetInt("BanThanDaTiemPhong");
                    obj.BanThanDaTiemPhong_Nam = DataReader["BanThanDaTiemPhong_Nam"].ToString();
                    obj.UongRuou = DataReader.GetInt("UongRuou");
                    obj.UongRuou_GhiRo = DataReader["UongRuou_GhiRo"].ToString();
                    obj.BenhKhac = DataReader.GetInt("BenhKhac");
                    obj.BenhKhac_GhiRo = DataReader["BenhKhac_GhiRo"].ToString();
                    obj.CoNguoiBiViemGanB = DataReader.GetInt("CoNguoiBiViemGanB");
                    obj.CoNguoiBiViemGanB_GhiRo = DataReader["CoNguoiBiViemGanB_GhiRo"].ToString();
                    obj.CoNguoiBiKGan = DataReader.GetInt("CoNguoiBiKGan");
                    obj.CoNguoiBiKGan_GhiRo = DataReader["CoNguoiBiKGan_GhiRo"].ToString();
                    obj.BenhSu = DataReader["BenhSu"].ToString();
                    obj.Cao = DataReader["Cao"].ToString();
                    obj.Nang = DataReader["Nang"].ToString();
                    obj.Sot = DataReader.GetInt("Sot");
                    obj.DauHSP = DataReader.GetInt("DauHSP");
                    obj.MetMoi = DataReader.GetInt("MetMoi");
                    obj.ChanAn = DataReader.GetInt("ChanAn");
                    obj.SutCan = DataReader.GetInt("SutCan");
                    obj.TCCN_TrieuChungKhac = DataReader["TCCN_TrieuChungKhac"].ToString();
                    obj.NhipTim = DataReader["NhipTim"].ToString();
                    obj.HA = DataReader["HA"].ToString();
                    obj.VangDa = DataReader.GetInt("VangDa");
                    obj.SaoMach = DataReader.GetInt("SaoMach");
                    obj.XHDD = DataReader.GetInt("XHDD");
                    obj.CoChuong = DataReader.GetInt("CoChuong");
                    obj.Phu = DataReader.GetInt("Phu");
                    obj.GanTo = DataReader.GetInt("GanTo");
                    obj.LachTo = DataReader.GetInt("LachTo");
                    obj.KBP_TrieuChungKhac = DataReader.GetInt("KBP_TrieuChungKhac");
                    obj.CacBoPhanKhac = DataReader["CacBoPhanKhac"].ToString();
                    obj.HBsAg = DataReader["HBsAg"].ToString();
                    obj.AntiHBs = DataReader["AntiHBs"].ToString();
                    obj.HBeAg = DataReader["HBeAg"].ToString();
                    obj.HBVDNA = DataReader["HBVDNA"].ToString();
                    obj.AntiHBeAg = DataReader["AntiHBeAg"].ToString();
                    obj.AntiHVC = DataReader["AntiHVC"].ToString();
                    obj.HIV = DataReader["HIV"].ToString();
                    obj.AST = DataReader["AST"].ToString();
                    obj.ALT = DataReader["ALT"].ToString();
                    obj.Bilirubin_TP = DataReader["Bilirubin_TP"].ToString();
                    obj.Bilirubin_TT = DataReader["Bilirubin_TT"].ToString();
                    obj.GT = DataReader["GT"].ToString();
                    obj.PT = DataReader["PT"].ToString();
                    obj.Albumin = DataReader["Albumin"].ToString();
                    obj.AlphaFP = DataReader["AlphaFP"].ToString();
                    obj.Creatinin = DataReader["Creatinin"].ToString();
                    obj.DuongMau = DataReader["DuongMau"].ToString();
                    obj.CTM_HC = DataReader["CTM_HC"].ToString();
                    obj.CTM_BC = DataReader["CTM_BC"].ToString();
                    obj.CTM_TC = DataReader["CTM_TC"].ToString();
                    obj.CTM_HB = DataReader["CTM_HB"].ToString();
                    obj.SieuAmBung_Gan = DataReader["SieuAmBung_Gan"].ToString();
                    obj.TMC = DataReader["TMC"].ToString();
                    obj.Lach = DataReader["Lach"].ToString();
                    obj.TML = DataReader["TML"].ToString();
                    obj.SoiDaDayThucQuan = DataReader.GetInt("SoiDaDayThucQuan");
                    obj.GianTMTQ = DataReader.GetInt("GianTMTQ");
                    obj.XetNghiemKhac = DataReader["XetNghiemKhac"].ToString();
                    obj.MangHbsAgMan = DataReader.GetInt("MangHbsAgMan");
                    obj.VGSVBManTT = DataReader.GetInt("VGSVBManTT");
                    obj.VGSVBManXoGanConBu = DataReader.GetInt("VGSVBManXoGanConBu");
                    obj.VGSVBManXoGanMatBu = DataReader.GetInt("VGSVBManXoGanMatBu");
                    obj.VGSVBManKGan = DataReader.GetInt("VGSVBManKGan");
                    obj.DieuTri = DataReader["DieuTri"].ToString();
                    obj.HenKhamLai = DataReader["HenKhamLai"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["HenKhamLai"]) : null;
                    obj.HenXetNghiemLai = DataReader["HenXetNghiemLai"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["HenXetNghiemLai"]) : null;
                    obj.BacSyDieuTri = DataReader["BacSyDieuTri"].ToString();

                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return obj;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, BenhAnViemGanBManTinh BenhAnViemGanBManTinh)
        {
            try
            {
                string sql =
                          @"select MaQuanLy 
                            from BenhAnViemGanBManTinh
                            where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnViemGanBManTinh.MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                int rowCount = 0;
                while (DataReader.Read()) rowCount++;
                if (rowCount == 1) return Update(MyConnection, BenhAnViemGanBManTinh);
                sql = @"
                       INSERT INTO BenhAnViemGanBManTinh 
                        (
                            MaQuanLy,
                            LyDoNhanVaoNC,
                            MeHbAg,
                            VoChongBanTinhHb,
                            TruyenMau,
                            TonThuongDoKimDam,
                            DongNhiemVR,
                            CoTrieuChung,
                            KhamSKDinhKy,
                            TinhCo,
                            TDPHB_HBsAg,
                            VGSVBMan,
                            DaDieuTriVGSVBMan,
                            GhiRoThuocDieuTri,
                            TienSuSinhDe,
                            ConDaTiemPhong,
                            BanThanDaTiemPhong,
                            BanThanDaTiemPhong_Nam,
                            UongRuou,
                            UongRuou_GhiRo,
                            BenhKhac,
                            BenhKhac_GhiRo,
                            CoNguoiBiViemGanB,
                            CoNguoiBiViemGanB_GhiRo,
                            CoNguoiBiKGan,
                            CoNguoiBiKGan_GhiRo,
                            BenhSu,
                            Cao,
                            Nang,
                            Sot,
                            DauHSP,
                            MetMoi,
                            ChanAn,
                            SutCan,
                            TCCN_TrieuChungKhac,
                            NhipTim,
                            HA,
                            VangDa,
                            SaoMach,
                            XHDD,
                            CoChuong,
                            Phu,
                            GanTo,
                            LachTo,
                            KBP_TrieuChungKhac,
                            CacBoPhanKhac,
                            HBsAg,
                            AntiHBs,
                            HBeAg,
                            HBVDNA,
                            AntiHBeAg,
                            AntiHVC,
                            HIV,
                            AST,
                            ALT,
                            Bilirubin_TP,
                            Bilirubin_TT,
                            GT,
                            PT,
                            Albumin,
                            AlphaFP,
                            Creatinin,
                            DuongMau,
                            CTM_HC,
                            CTM_BC,
                            CTM_TC,
                            CTM_HB,
                            SieuAmBung_Gan,
                            TMC,
                            Lach,
                            TML,
                            SoiDaDayThucQuan,
                            GianTMTQ,
                            XetNghiemKhac,
                            MangHbsAgMan,
                            VGSVBManTT,
                            VGSVBManXoGanConBu,
                            VGSVBManXoGanMatBu,
                            VGSVBManKGan,
                            DieuTri,
                            HenKhamLai,
                            HenXetNghiemLai,
                            BacSyDieuTri
                        )                 
                        VALUES
                        (
                            :MaQuanLy,
                            :LyDoNhanVaoNC,
                            :MeHbAg,
                            :VoChongBanTinhHb,
                            :TruyenMau,
                            :TonThuongDoKimDam,
                            :DongNhiemVR,
                            :CoTrieuChung,
                            :KhamSKDinhKy,
                            :TinhCo,
                            :TDPHB_HBsAg,
                            :VGSVBMan,
                            :DaDieuTriVGSVBMan,
                            :GhiRoThuocDieuTri,
                            :TienSuSinhDe,
                            :ConDaTiemPhong,
                            :BanThanDaTiemPhong,
                            :BanThanDaTiemPhong_Nam,
                            :UongRuou,
                            :UongRuou_GhiRo,
                            :BenhKhac,
                            :BenhKhac_GhiRo,
                            :CoNguoiBiViemGanB,
                            :CoNguoiBiViemGanB_GhiRo,
                            :CoNguoiBiKGan,
                            :CoNguoiBiKGan_GhiRo,
                            :BenhSu,
                            :Cao,
                            :Nang,
                            :Sot,
                            :DauHSP,
                            :MetMoi,
                            :ChanAn,
                            :SutCan,
                            :TCCN_TrieuChungKhac,
                            :NhipTim,
                            :HA,
                            :VangDa,
                            :SaoMach,
                            :XHDD,
                            :CoChuong,
                            :Phu,
                            :GanTo,
                            :LachTo,
                            :KBP_TrieuChungKhac,
                            :CacBoPhanKhac,
                            :HBsAg,
                            :AntiHBs,
                            :HBeAg,
                            :HBVDNA,
                            :AntiHBeAg,
                            :AntiHVC,
                            :HIV,
                            :AST,
                            :ALT,
                            :Bilirubin_TP,
                            :Bilirubin_TT,
                            :GT,
                            :PT,
                            :Albumin,
                            :AlphaFP,
                            :Creatinin,
                            :DuongMau,
                            :CTM_HC,
                            :CTM_BC,
                            :CTM_TC,
                            :CTM_HB,
                            :SieuAmBung_Gan,
                            :TMC,
                            :Lach,
                            :TML,
                            :SoiDaDayThucQuan,
                            :GianTMTQ,
                            :XetNghiemKhac,
                            :MangHbsAgMan,
                            :VGSVBManTT,
                            :VGSVBManXoGanConBu,
                            :VGSVBManXoGanMatBu,
                            :VGSVBManKGan,
                            :DieuTri,
                            :HenKhamLai,
                            :HenXetNghiemLai,
                            :BacSyDieuTri
                        )";
                Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnViemGanBManTinh.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("LyDoNhanVaoNC", BenhAnViemGanBManTinh.LyDoNhanVaoNC));
                Command.Parameters.Add(new MDB.MDBParameter("MeHbAg", BenhAnViemGanBManTinh.MeHbAg));
                Command.Parameters.Add(new MDB.MDBParameter("VoChongBanTinhHb", BenhAnViemGanBManTinh.VoChongBanTinhHb));
                Command.Parameters.Add(new MDB.MDBParameter("TruyenMau", BenhAnViemGanBManTinh.TruyenMau));
                Command.Parameters.Add(new MDB.MDBParameter("TonThuongDoKimDam", BenhAnViemGanBManTinh.TonThuongDoKimDam));
                Command.Parameters.Add(new MDB.MDBParameter("DongNhiemVR", BenhAnViemGanBManTinh.DongNhiemVR));
                Command.Parameters.Add(new MDB.MDBParameter("CoTrieuChung", BenhAnViemGanBManTinh.CoTrieuChung));
                Command.Parameters.Add(new MDB.MDBParameter("KhamSKDinhKy", BenhAnViemGanBManTinh.KhamSKDinhKy));
                Command.Parameters.Add(new MDB.MDBParameter("TinhCo", BenhAnViemGanBManTinh.TinhCo));
                Command.Parameters.Add(new MDB.MDBParameter("TDPHB_HBsAg", BenhAnViemGanBManTinh.TDPHB_HBsAg));
                Command.Parameters.Add(new MDB.MDBParameter("VGSVBMan", BenhAnViemGanBManTinh.VGSVBMan));
                Command.Parameters.Add(new MDB.MDBParameter("DaDieuTriVGSVBMan", BenhAnViemGanBManTinh.DaDieuTriVGSVBMan));
                Command.Parameters.Add(new MDB.MDBParameter("GhiRoThuocDieuTri", BenhAnViemGanBManTinh.GhiRoThuocDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuSinhDe", BenhAnViemGanBManTinh.TienSuSinhDe));
                Command.Parameters.Add(new MDB.MDBParameter("ConDaTiemPhong", BenhAnViemGanBManTinh.ConDaTiemPhong));
                Command.Parameters.Add(new MDB.MDBParameter("BanThanDaTiemPhong", BenhAnViemGanBManTinh.BanThanDaTiemPhong));
                Command.Parameters.Add(new MDB.MDBParameter("BanThanDaTiemPhong_Nam", BenhAnViemGanBManTinh.BanThanDaTiemPhong_Nam));
                Command.Parameters.Add(new MDB.MDBParameter("UongRuou", BenhAnViemGanBManTinh.UongRuou));
                Command.Parameters.Add(new MDB.MDBParameter("UongRuou_GhiRo", BenhAnViemGanBManTinh.UongRuou_GhiRo));
                Command.Parameters.Add(new MDB.MDBParameter("BenhKhac", BenhAnViemGanBManTinh.BenhKhac));
                Command.Parameters.Add(new MDB.MDBParameter("BenhKhac_GhiRo", BenhAnViemGanBManTinh.BenhKhac_GhiRo));
                Command.Parameters.Add(new MDB.MDBParameter("CoNguoiBiViemGanB", BenhAnViemGanBManTinh.CoNguoiBiViemGanB));
                Command.Parameters.Add(new MDB.MDBParameter("CoNguoiBiViemGanB_GhiRo", BenhAnViemGanBManTinh.CoNguoiBiViemGanB_GhiRo));
                Command.Parameters.Add(new MDB.MDBParameter("CoNguoiBiKGan", BenhAnViemGanBManTinh.CoNguoiBiKGan));
                Command.Parameters.Add(new MDB.MDBParameter("CoNguoiBiKGan_GhiRo", BenhAnViemGanBManTinh.CoNguoiBiKGan_GhiRo));
                Command.Parameters.Add(new MDB.MDBParameter("BenhSu", BenhAnViemGanBManTinh.BenhSu));
                Command.Parameters.Add(new MDB.MDBParameter("Cao", BenhAnViemGanBManTinh.Cao));
                Command.Parameters.Add(new MDB.MDBParameter("Nang", BenhAnViemGanBManTinh.Nang));
                Command.Parameters.Add(new MDB.MDBParameter("Sot", BenhAnViemGanBManTinh.Sot));
                Command.Parameters.Add(new MDB.MDBParameter("DauHSP", BenhAnViemGanBManTinh.DauHSP));
                Command.Parameters.Add(new MDB.MDBParameter("MetMoi", BenhAnViemGanBManTinh.MetMoi));
                Command.Parameters.Add(new MDB.MDBParameter("ChanAn", BenhAnViemGanBManTinh.ChanAn));
                Command.Parameters.Add(new MDB.MDBParameter("SutCan", BenhAnViemGanBManTinh.SutCan));
                Command.Parameters.Add(new MDB.MDBParameter("TCCN_TrieuChungKhac", BenhAnViemGanBManTinh.TCCN_TrieuChungKhac));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTim", BenhAnViemGanBManTinh.NhipTim));
                Command.Parameters.Add(new MDB.MDBParameter("HA", BenhAnViemGanBManTinh.HA));
                Command.Parameters.Add(new MDB.MDBParameter("VangDa", BenhAnViemGanBManTinh.VangDa));
                Command.Parameters.Add(new MDB.MDBParameter("SaoMach", BenhAnViemGanBManTinh.SaoMach));
                Command.Parameters.Add(new MDB.MDBParameter("XHDD", BenhAnViemGanBManTinh.XHDD));
                Command.Parameters.Add(new MDB.MDBParameter("CoChuong", BenhAnViemGanBManTinh.CoChuong));
                Command.Parameters.Add(new MDB.MDBParameter("Phu", BenhAnViemGanBManTinh.Phu));
                Command.Parameters.Add(new MDB.MDBParameter("GanTo", BenhAnViemGanBManTinh.GanTo));
                Command.Parameters.Add(new MDB.MDBParameter("LachTo", BenhAnViemGanBManTinh.LachTo));
                Command.Parameters.Add(new MDB.MDBParameter("KBP_TrieuChungKhac", BenhAnViemGanBManTinh.KBP_TrieuChungKhac));
                Command.Parameters.Add(new MDB.MDBParameter("CacBoPhanKhac", BenhAnViemGanBManTinh.CacBoPhanKhac));
                Command.Parameters.Add(new MDB.MDBParameter("HBsAg", BenhAnViemGanBManTinh.HBsAg));
                Command.Parameters.Add(new MDB.MDBParameter("AntiHBs", BenhAnViemGanBManTinh.AntiHBs));
                Command.Parameters.Add(new MDB.MDBParameter("HBeAg", BenhAnViemGanBManTinh.HBeAg));
                Command.Parameters.Add(new MDB.MDBParameter("HBVDNA", BenhAnViemGanBManTinh.HBVDNA));
                Command.Parameters.Add(new MDB.MDBParameter("AntiHBeAg", BenhAnViemGanBManTinh.AntiHBeAg));
                Command.Parameters.Add(new MDB.MDBParameter("AntiHVC", BenhAnViemGanBManTinh.AntiHVC));
                Command.Parameters.Add(new MDB.MDBParameter("HIV", BenhAnViemGanBManTinh.HIV));
                Command.Parameters.Add(new MDB.MDBParameter("AST", BenhAnViemGanBManTinh.AST));
                Command.Parameters.Add(new MDB.MDBParameter("ALT", BenhAnViemGanBManTinh.ALT));
                Command.Parameters.Add(new MDB.MDBParameter("Bilirubin_TP", BenhAnViemGanBManTinh.Bilirubin_TP));
                Command.Parameters.Add(new MDB.MDBParameter("Bilirubin_TT", BenhAnViemGanBManTinh.Bilirubin_TT));
                Command.Parameters.Add(new MDB.MDBParameter("GT", BenhAnViemGanBManTinh.GT));
                Command.Parameters.Add(new MDB.MDBParameter("PT", BenhAnViemGanBManTinh.PT));
                Command.Parameters.Add(new MDB.MDBParameter("Albumin", BenhAnViemGanBManTinh.Albumin));
                Command.Parameters.Add(new MDB.MDBParameter("AlphaFP", BenhAnViemGanBManTinh.AlphaFP));
                Command.Parameters.Add(new MDB.MDBParameter("Creatinin", BenhAnViemGanBManTinh.Creatinin));
                Command.Parameters.Add(new MDB.MDBParameter("DuongMau", BenhAnViemGanBManTinh.DuongMau));
                Command.Parameters.Add(new MDB.MDBParameter("CTM_HC", BenhAnViemGanBManTinh.CTM_HC));
                Command.Parameters.Add(new MDB.MDBParameter("CTM_BC", BenhAnViemGanBManTinh.CTM_BC));
                Command.Parameters.Add(new MDB.MDBParameter("CTM_TC", BenhAnViemGanBManTinh.CTM_TC));
                Command.Parameters.Add(new MDB.MDBParameter("CTM_HB", BenhAnViemGanBManTinh.CTM_HB));
                Command.Parameters.Add(new MDB.MDBParameter("SieuAmBung_Gan", BenhAnViemGanBManTinh.SieuAmBung_Gan));
                Command.Parameters.Add(new MDB.MDBParameter("TMC", BenhAnViemGanBManTinh.TMC));
                Command.Parameters.Add(new MDB.MDBParameter("Lach", BenhAnViemGanBManTinh.Lach));
                Command.Parameters.Add(new MDB.MDBParameter("TML", BenhAnViemGanBManTinh.TML));
                Command.Parameters.Add(new MDB.MDBParameter("SoiDaDayThucQuan", BenhAnViemGanBManTinh.SoiDaDayThucQuan));
                Command.Parameters.Add(new MDB.MDBParameter("GianTMTQ", BenhAnViemGanBManTinh.GianTMTQ));
                Command.Parameters.Add(new MDB.MDBParameter("XetNghiemKhac", BenhAnViemGanBManTinh.XetNghiemKhac));
                Command.Parameters.Add(new MDB.MDBParameter("MangHbsAgMan", BenhAnViemGanBManTinh.MangHbsAgMan));
                Command.Parameters.Add(new MDB.MDBParameter("VGSVBManTT", BenhAnViemGanBManTinh.VGSVBManTT));
                Command.Parameters.Add(new MDB.MDBParameter("VGSVBManXoGanConBu", BenhAnViemGanBManTinh.VGSVBManXoGanConBu));
                Command.Parameters.Add(new MDB.MDBParameter("VGSVBManXoGanMatBu", BenhAnViemGanBManTinh.VGSVBManXoGanMatBu));
                Command.Parameters.Add(new MDB.MDBParameter("VGSVBManKGan", BenhAnViemGanBManTinh.VGSVBManKGan));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri", BenhAnViemGanBManTinh.DieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("HenKhamLai", BenhAnViemGanBManTinh.HenKhamLai));
                Command.Parameters.Add(new MDB.MDBParameter("HenXetNghiemLai", BenhAnViemGanBManTinh.HenXetNghiemLai));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnViemGanBManTinh.BacSyDieuTri));


                Command.BindByName = true;
                int n = Command.ExecuteNonQuery(); // C#
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool Update(MDB.MDBConnection MyConnection, BenhAnViemGanBManTinh BenhAnViemGanBManTinh)
        {
            try
            {
                string sql = @"UPDATE BenhAnViemGanBManTinh SET 
                            LyDoNhanVaoNC=:LyDoNhanVaoNC,
                            MeHbAg=:MeHbAg,
                            VoChongBanTinhHb=:VoChongBanTinhHb,
                            TruyenMau=:TruyenMau,
                            TonThuongDoKimDam=:TonThuongDoKimDam,
                            DongNhiemVR=:DongNhiemVR,
                            CoTrieuChung=:CoTrieuChung,
                            KhamSKDinhKy=:KhamSKDinhKy,
                            TinhCo=:TinhCo,
                            TDPHB_HBsAg=:TDPHB_HBsAg,
                            VGSVBMan=:VGSVBMan,
                            DaDieuTriVGSVBMan=:DaDieuTriVGSVBMan,
                            GhiRoThuocDieuTri=:GhiRoThuocDieuTri,
                            TienSuSinhDe=:TienSuSinhDe,
                            ConDaTiemPhong=:ConDaTiemPhong,
                            BanThanDaTiemPhong=:BanThanDaTiemPhong,
                            BanThanDaTiemPhong_Nam=:BanThanDaTiemPhong_Nam,
                            UongRuou=:UongRuou,
                            UongRuou_GhiRo=:UongRuou_GhiRo,
                            BenhKhac=:BenhKhac,
                            BenhKhac_GhiRo=:BenhKhac_GhiRo,
                            CoNguoiBiViemGanB=:CoNguoiBiViemGanB,
                            CoNguoiBiViemGanB_GhiRo=:CoNguoiBiViemGanB_GhiRo,
                            CoNguoiBiKGan=:CoNguoiBiKGan,
                            CoNguoiBiKGan_GhiRo=:CoNguoiBiKGan_GhiRo,
                            BenhSu=:BenhSu,
                            Cao=:Cao,
                            Nang=:Nang,
                            Sot=:Sot,
                            DauHSP=:DauHSP,
                            MetMoi=:MetMoi,
                            ChanAn=:ChanAn,
                            SutCan=:SutCan,
                            TCCN_TrieuChungKhac=:TCCN_TrieuChungKhac,
                            NhipTim=:NhipTim,
                            HA=:HA,
                            VangDa=:VangDa,
                            SaoMach=:SaoMach,
                            XHDD=:XHDD,
                            CoChuong=:CoChuong,
                            Phu=:Phu,
                            GanTo=:GanTo,
                            LachTo=:LachTo,
                            KBP_TrieuChungKhac=:KBP_TrieuChungKhac,
                            CacBoPhanKhac=:CacBoPhanKhac,
                            HBsAg=:HBsAg,
                            AntiHBs=:AntiHBs,
                            HBeAg=:HBeAg,
                            HBVDNA=:HBVDNA,
                            AntiHBeAg=:AntiHBeAg,
                            AntiHVC=:AntiHVC,
                            HIV=:HIV,
                            AST=:AST,
                            ALT=:ALT,
                            Bilirubin_TP=:Bilirubin_TP,
                            Bilirubin_TT=:Bilirubin_TT,
                            GT=:GT,
                            PT=:PT,
                            Albumin=:Albumin,
                            AlphaFP=:AlphaFP,
                            Creatinin=:Creatinin,
                            DuongMau=:DuongMau,
                            CTM_HC=:CTM_HC,
                            CTM_BC=:CTM_BC,
                            CTM_TC=:CTM_TC,
                            CTM_HB=:CTM_HB,
                            SieuAmBung_Gan=:SieuAmBung_Gan,
                            TMC=:TMC,
                            Lach=:Lach,
                            TML=:TML,
                            SoiDaDayThucQuan=:SoiDaDayThucQuan,
                            GianTMTQ=:GianTMTQ,
                            XetNghiemKhac=:XetNghiemKhac,
                            MangHbsAgMan=:MangHbsAgMan,
                            VGSVBManTT=:VGSVBManTT,
                            VGSVBManXoGanConBu=:VGSVBManXoGanConBu,
                            VGSVBManXoGanMatBu=:VGSVBManXoGanMatBu,
                            VGSVBManKGan=:VGSVBManKGan,
                            DieuTri=:DieuTri,
                            HenKhamLai=:HenKhamLai,
                            HenXetNghiemLai=:HenXetNghiemLai,
                            BacSyDieuTri=:BacSyDieuTri
                            WHERE MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("LyDoNhanVaoNC", BenhAnViemGanBManTinh.LyDoNhanVaoNC));
                Command.Parameters.Add(new MDB.MDBParameter("MeHbAg", BenhAnViemGanBManTinh.MeHbAg));
                Command.Parameters.Add(new MDB.MDBParameter("VoChongBanTinhHb", BenhAnViemGanBManTinh.VoChongBanTinhHb));
                Command.Parameters.Add(new MDB.MDBParameter("TruyenMau", BenhAnViemGanBManTinh.TruyenMau));
                Command.Parameters.Add(new MDB.MDBParameter("TonThuongDoKimDam", BenhAnViemGanBManTinh.TonThuongDoKimDam));
                Command.Parameters.Add(new MDB.MDBParameter("DongNhiemVR", BenhAnViemGanBManTinh.DongNhiemVR));
                Command.Parameters.Add(new MDB.MDBParameter("CoTrieuChung", BenhAnViemGanBManTinh.CoTrieuChung));
                Command.Parameters.Add(new MDB.MDBParameter("KhamSKDinhKy", BenhAnViemGanBManTinh.KhamSKDinhKy));
                Command.Parameters.Add(new MDB.MDBParameter("TinhCo", BenhAnViemGanBManTinh.TinhCo));
                Command.Parameters.Add(new MDB.MDBParameter("TDPHB_HBsAg", BenhAnViemGanBManTinh.TDPHB_HBsAg));
                Command.Parameters.Add(new MDB.MDBParameter("VGSVBMan", BenhAnViemGanBManTinh.VGSVBMan));
                Command.Parameters.Add(new MDB.MDBParameter("DaDieuTriVGSVBMan", BenhAnViemGanBManTinh.DaDieuTriVGSVBMan));
                Command.Parameters.Add(new MDB.MDBParameter("GhiRoThuocDieuTri", BenhAnViemGanBManTinh.GhiRoThuocDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuSinhDe", BenhAnViemGanBManTinh.TienSuSinhDe));
                Command.Parameters.Add(new MDB.MDBParameter("ConDaTiemPhong", BenhAnViemGanBManTinh.ConDaTiemPhong));
                Command.Parameters.Add(new MDB.MDBParameter("BanThanDaTiemPhong", BenhAnViemGanBManTinh.BanThanDaTiemPhong));
                Command.Parameters.Add(new MDB.MDBParameter("BanThanDaTiemPhong_Nam", BenhAnViemGanBManTinh.BanThanDaTiemPhong_Nam));
                Command.Parameters.Add(new MDB.MDBParameter("UongRuou", BenhAnViemGanBManTinh.UongRuou));
                Command.Parameters.Add(new MDB.MDBParameter("UongRuou_GhiRo", BenhAnViemGanBManTinh.UongRuou_GhiRo));
                Command.Parameters.Add(new MDB.MDBParameter("BenhKhac", BenhAnViemGanBManTinh.BenhKhac));
                Command.Parameters.Add(new MDB.MDBParameter("BenhKhac_GhiRo", BenhAnViemGanBManTinh.BenhKhac_GhiRo));
                Command.Parameters.Add(new MDB.MDBParameter("CoNguoiBiViemGanB", BenhAnViemGanBManTinh.CoNguoiBiViemGanB));
                Command.Parameters.Add(new MDB.MDBParameter("CoNguoiBiViemGanB_GhiRo", BenhAnViemGanBManTinh.CoNguoiBiViemGanB_GhiRo));
                Command.Parameters.Add(new MDB.MDBParameter("CoNguoiBiKGan", BenhAnViemGanBManTinh.CoNguoiBiKGan));
                Command.Parameters.Add(new MDB.MDBParameter("CoNguoiBiKGan_GhiRo", BenhAnViemGanBManTinh.CoNguoiBiKGan_GhiRo));
                Command.Parameters.Add(new MDB.MDBParameter("BenhSu", BenhAnViemGanBManTinh.BenhSu));
                Command.Parameters.Add(new MDB.MDBParameter("Cao", BenhAnViemGanBManTinh.Cao));
                Command.Parameters.Add(new MDB.MDBParameter("Nang", BenhAnViemGanBManTinh.Nang));
                Command.Parameters.Add(new MDB.MDBParameter("Sot", BenhAnViemGanBManTinh.Sot));
                Command.Parameters.Add(new MDB.MDBParameter("DauHSP", BenhAnViemGanBManTinh.DauHSP));
                Command.Parameters.Add(new MDB.MDBParameter("MetMoi", BenhAnViemGanBManTinh.MetMoi));
                Command.Parameters.Add(new MDB.MDBParameter("ChanAn", BenhAnViemGanBManTinh.ChanAn));
                Command.Parameters.Add(new MDB.MDBParameter("SutCan", BenhAnViemGanBManTinh.SutCan));
                Command.Parameters.Add(new MDB.MDBParameter("TCCN_TrieuChungKhac", BenhAnViemGanBManTinh.TCCN_TrieuChungKhac));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTim", BenhAnViemGanBManTinh.NhipTim));
                Command.Parameters.Add(new MDB.MDBParameter("HA", BenhAnViemGanBManTinh.HA));
                Command.Parameters.Add(new MDB.MDBParameter("VangDa", BenhAnViemGanBManTinh.VangDa));
                Command.Parameters.Add(new MDB.MDBParameter("SaoMach", BenhAnViemGanBManTinh.SaoMach));
                Command.Parameters.Add(new MDB.MDBParameter("XHDD", BenhAnViemGanBManTinh.XHDD));
                Command.Parameters.Add(new MDB.MDBParameter("CoChuong", BenhAnViemGanBManTinh.CoChuong));
                Command.Parameters.Add(new MDB.MDBParameter("Phu", BenhAnViemGanBManTinh.Phu));
                Command.Parameters.Add(new MDB.MDBParameter("GanTo", BenhAnViemGanBManTinh.GanTo));
                Command.Parameters.Add(new MDB.MDBParameter("LachTo", BenhAnViemGanBManTinh.LachTo));
                Command.Parameters.Add(new MDB.MDBParameter("KBP_TrieuChungKhac", BenhAnViemGanBManTinh.KBP_TrieuChungKhac));
                Command.Parameters.Add(new MDB.MDBParameter("CacBoPhanKhac", BenhAnViemGanBManTinh.CacBoPhanKhac));
                Command.Parameters.Add(new MDB.MDBParameter("HBsAg", BenhAnViemGanBManTinh.HBsAg));
                Command.Parameters.Add(new MDB.MDBParameter("AntiHBs", BenhAnViemGanBManTinh.AntiHBs));
                Command.Parameters.Add(new MDB.MDBParameter("HBeAg", BenhAnViemGanBManTinh.HBeAg));
                Command.Parameters.Add(new MDB.MDBParameter("HBVDNA", BenhAnViemGanBManTinh.HBVDNA));
                Command.Parameters.Add(new MDB.MDBParameter("AntiHBeAg", BenhAnViemGanBManTinh.AntiHBeAg));
                Command.Parameters.Add(new MDB.MDBParameter("AntiHVC", BenhAnViemGanBManTinh.AntiHVC));
                Command.Parameters.Add(new MDB.MDBParameter("HIV", BenhAnViemGanBManTinh.HIV));
                Command.Parameters.Add(new MDB.MDBParameter("AST", BenhAnViemGanBManTinh.AST));
                Command.Parameters.Add(new MDB.MDBParameter("ALT", BenhAnViemGanBManTinh.ALT));
                Command.Parameters.Add(new MDB.MDBParameter("Bilirubin_TP", BenhAnViemGanBManTinh.Bilirubin_TP));
                Command.Parameters.Add(new MDB.MDBParameter("Bilirubin_TT", BenhAnViemGanBManTinh.Bilirubin_TT));
                Command.Parameters.Add(new MDB.MDBParameter("GT", BenhAnViemGanBManTinh.GT));
                Command.Parameters.Add(new MDB.MDBParameter("PT", BenhAnViemGanBManTinh.PT));
                Command.Parameters.Add(new MDB.MDBParameter("Albumin", BenhAnViemGanBManTinh.Albumin));
                Command.Parameters.Add(new MDB.MDBParameter("AlphaFP", BenhAnViemGanBManTinh.AlphaFP));
                Command.Parameters.Add(new MDB.MDBParameter("Creatinin", BenhAnViemGanBManTinh.Creatinin));
                Command.Parameters.Add(new MDB.MDBParameter("DuongMau", BenhAnViemGanBManTinh.DuongMau));
                Command.Parameters.Add(new MDB.MDBParameter("CTM_HC", BenhAnViemGanBManTinh.CTM_HC));
                Command.Parameters.Add(new MDB.MDBParameter("CTM_BC", BenhAnViemGanBManTinh.CTM_BC));
                Command.Parameters.Add(new MDB.MDBParameter("CTM_TC", BenhAnViemGanBManTinh.CTM_TC));
                Command.Parameters.Add(new MDB.MDBParameter("CTM_HB", BenhAnViemGanBManTinh.CTM_HB));
                Command.Parameters.Add(new MDB.MDBParameter("SieuAmBung_Gan", BenhAnViemGanBManTinh.SieuAmBung_Gan));
                Command.Parameters.Add(new MDB.MDBParameter("TMC", BenhAnViemGanBManTinh.TMC));
                Command.Parameters.Add(new MDB.MDBParameter("Lach", BenhAnViemGanBManTinh.Lach));
                Command.Parameters.Add(new MDB.MDBParameter("TML", BenhAnViemGanBManTinh.TML));
                Command.Parameters.Add(new MDB.MDBParameter("SoiDaDayThucQuan", BenhAnViemGanBManTinh.SoiDaDayThucQuan));
                Command.Parameters.Add(new MDB.MDBParameter("GianTMTQ", BenhAnViemGanBManTinh.GianTMTQ));
                Command.Parameters.Add(new MDB.MDBParameter("XetNghiemKhac", BenhAnViemGanBManTinh.XetNghiemKhac));
                Command.Parameters.Add(new MDB.MDBParameter("MangHbsAgMan", BenhAnViemGanBManTinh.MangHbsAgMan));
                Command.Parameters.Add(new MDB.MDBParameter("VGSVBManTT", BenhAnViemGanBManTinh.VGSVBManTT));
                Command.Parameters.Add(new MDB.MDBParameter("VGSVBManXoGanConBu", BenhAnViemGanBManTinh.VGSVBManXoGanConBu));
                Command.Parameters.Add(new MDB.MDBParameter("VGSVBManXoGanMatBu", BenhAnViemGanBManTinh.VGSVBManXoGanMatBu));
                Command.Parameters.Add(new MDB.MDBParameter("VGSVBManKGan", BenhAnViemGanBManTinh.VGSVBManKGan));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri", BenhAnViemGanBManTinh.DieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("HenKhamLai", BenhAnViemGanBManTinh.HenKhamLai));
                Command.Parameters.Add(new MDB.MDBParameter("HenXetNghiemLai", BenhAnViemGanBManTinh.HenXetNghiemLai));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnViemGanBManTinh.BacSyDieuTri));


                Command.BindByName = true;

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnViemGanBManTinh.MaQuanLy));
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery(); // C#
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }

    }
}
