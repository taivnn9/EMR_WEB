using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using EMR_MAIN.DATABASE.BenhAn;
using System.Globalization;

namespace EMR_MAIN.DATABASE.BenhAnFunc
{
    public class BenhAnDaiThaoDuongFunc
    {
        public static void WriteXml(MDB.MDBConnection MyConnection)
        {
            string sql =
                   @"
                  select  a.*,  CTScanner HoSo_CTScanner, SieuAm HoSo_SieuAm, XetNghiem HoSo_XetNghiem,  Khac HoSo_Khac,  Khac_Text HoSo_Khac_Text,  ToanBoHoSo HoSo_ToanBoHoSo, Mach DauSinhTon_Mach,  NhietDo DauSinhTon_NhietDo,  HuyetAp DauSinhTon_HuyetAp,  NhipTho DauSinhTon_NhipTho,  CanNang DauSinhTon_CanNang  
                  from BenhAnDaiThaoDuong a inner join thongtindieutri b on a.maquanly = b.maquanly
                  where rownum = 1
                    ";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            var DataTable = new DataTable { TableName = "BenhAnDaiThaoDuong" };
            DataTable.Load(DataReader as IDataReader);
            DataTable.WriteXml("rptBenhAnDaiThaoDuong.xml");
        }
        public static DataSet SelectDataSet(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql =
                  @"
                 select  a.*,c.hovaten BacSyDieuTriHoVaTen 
                 from BenhAnDaiThaoDuong a 
                 left join nhanvien c on a.bacsydieutri = c.manhanvien 
                 where a.maquanly = " + MaQuanLy.ToString(CultureInfo.InvariantCulture);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(sql, MyConnection);
            var ds = new DataSet();
            adt.Fill(ds, "Table");

            return ds;
        }
        public static BenhAnDaiThaoDuong Select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            #region
            string sql =
                      @"select * 
                        from BenhAnDaiThaoDuong a
                        where MaQuanLy = :MaQuanLy";
            #endregion
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            var value = new BenhAnDaiThaoDuong();
            while (DataReader.Read())
            {
                value.MaQuanLy = DataReader.GetDecimal("MaQuanLy");
                value.LyDoNhanVaoChuongTrinh = DataReader["LyDoNhanVaoChuongTrinh"].ToString();
                value.HutThuoc = DataReader.GetInt("HutThuoc");
                value.HutThuoc_DieuNgay = DataReader["HutThuoc_DieuNgay"].ToString();
                value.HutThuoc_BaoNam = DataReader["HutThuoc_BaoNam"].ToString();
                value.HutThuoc_Bo = DataReader.GetInt("HutThuoc_Bo");
                value.UongRuou = DataReader.GetInt("UongRuou");
                value.UongRuou_MlNgay = DataReader["UongRuou_MlNgay"].ToString();
                value.UongRuou_Bo = DataReader.GetInt("UongRuou_Bo");
                value.TangHuyetAp = DataReader.GetInt("TangHuyetAp");
                value.RoiLoanMoMau = DataReader.GetInt("RoiLoanMoMau");
                value.BenhGoutte = DataReader.GetInt("BenhGoutte");
                value.BenhThan = DataReader.GetInt("BenhThan");
                value.BenhThan_GhiRo = DataReader["BenhThan_GhiRo"].ToString();
                value.BenhLyKhac = DataReader.GetInt("BenhLyKhac");
                value.BenhLyKhac_GhiRo = DataReader["BenhLyKhac_GhiRo"].ToString();
                value.ThoiDiemPhatHienDTD = DataReader["ThoiDiemPhatHienDTD"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["ThoiDiemPhatHienDTD"]) : null;
                value.TriSoDuongHuyetCaoNhat = DataReader["TriSoDuongHuyetCaoNhat"].ToString();
                value.CoTrieuChung = DataReader.GetInt("CoTrieuChung");
                value.KhamSKDinhKy = DataReader.GetInt("KhamSKDinhKy");
                value.TinhCo = DataReader.GetInt("TinhCo");
                value.CDTTXHK = DataReader["CDTTXHK"].ToString();
                value.ThucHienCheDoAnUong = DataReader.GetInt("ThucHienCheDoAnUong");
                value.Sulffonylyra = DataReader.GetInt("Sulffonylyra");
                value.Biguanid = DataReader.GetInt("Biguanid");
                value.Acrbose = DataReader.GetInt("Acrbose");
                value.ThuocUong_Khac = DataReader.GetInt("ThuocUong_Khac");
                value.Insulin = DataReader.GetInt("Insulin");
                value.SayThai = DataReader.GetInt("SayThai");
                value.SayThai_MayLan = DataReader["SayThai_MayLan"].ToString();
                value.DeCon4Kg = DataReader.GetInt("DeCon4Kg");
                value.DeCon4Kg_MayLan = DataReader["DeCon4Kg_MayLan"].ToString();
                value.DeCon25kg = DataReader.GetInt("DeCon25kg");
                value.DeCon25kg_MayLan = DataReader["DeCon25kg_MayLan"].ToString();
                value.TienSuDTDThaiNghen = DataReader.GetInt("TienSuDTDThaiNghen");
                value.RLDNG = DataReader.GetInt("RLDNG");
                value.GDCoBiDTD = DataReader.GetInt("GDCoBiDTD");
                value.GDCoBiDTD_Text = DataReader["GDCoBiDTD_Text"].ToString();
                value.GDCoBiTimMachSom = DataReader.GetInt("GDCoBiTimMachSom");
                value.GDCoBiTimMachSom_Text = DataReader["GDCoBiTimMachSom_Text"].ToString();
                value.TienSuBenhTatKhac = DataReader.GetInt("TienSuBenhTatKhac");
                value.TienSuBenhTatKhac_GhiRo = DataReader["TienSuBenhTatKhac_GhiRo"].ToString();
                value.BenhSu = DataReader["BenhSu"].ToString();
                value.ChieuCao = DataReader["ChieuCao"].ToString();
                value.CanNang = DataReader["CanNang"].ToString();
                value.BMT = DataReader["BMT"].ToString();
                value.VongEo = DataReader["VongEo"].ToString();
                value.VongHong = DataReader["VongHong"].ToString();
                value.ChiSoEoHong = DataReader["ChiSoEoHong"].ToString();
                value.KhatUongNhieu = DataReader.GetInt("KhatUongNhieu");
                value.KhatUongNhieu_SL = DataReader["KhatUongNhieu_SL"].ToString();
                value.TieuNhieu = DataReader.GetInt("TieuNhieu");
                value.TieuNhieu_SL = DataReader["TieuNhieu_SL"].ToString();
                value.MetMoi = DataReader.GetInt("MetMoi");
                value.SutCan = DataReader.GetInt("SutCan");
                value.DauNguc = DataReader.GetInt("DauNguc");
                value.DauCanhHoi = DataReader.GetInt("DauCanhHoi");
                value.TeBiChanTay = DataReader.GetInt("TeBiChanTay");
                value.MatNhinMo = DataReader.GetInt("MatNhinMo");
                value.TrieuChungKhac = DataReader["TrieuChungKhac"].ToString();
                value.ThiLuc_MP = DataReader["ThiLuc_MP"].ToString();
                value.ThiLuc_MT = DataReader["ThiLuc_MT"].ToString();
                value.TonThuong_MP = DataReader["TonThuong_MP"].ToString();
                value.TonThuong_MT = DataReader["TonThuong_MT"].ToString();
                value.DaNiemMac = DataReader["DaNiemMac"].ToString();
                value.Phu = DataReader.GetInt("Phu");
                value.Phu_ViTri = DataReader["Phu_ViTri"].ToString();
                value.TinhTrangRangLoi = DataReader["TinhTrangRangLoi"].ToString();
                value.NhipTim_TuTheNam = DataReader["NhipTim_TuTheNam"].ToString();
                value.HA_TuTheNam = DataReader["HA_TuTheNam"].ToString();
                value.NhipTim_TuTheDung = DataReader["NhipTim_TuTheDung"].ToString();
                value.HA_TuTheDung = DataReader["HA_TuTheDung"].ToString();
                value.MachNgoaiBien = DataReader.GetInt("MachNgoaiBien");
                value.MachNgoaiBien_ViTri = DataReader["MachNgoaiBien_ViTri"].ToString();
                value.TiengPhoiDM = DataReader.GetInt("TiengPhoiDM");
                value.TiengPhoiDM_ViTri = DataReader["TiengPhoiDM_ViTri"].ToString();
                value.BLTK_VanDong = DataReader.GetInt("BLTK_VanDong");
                value.BLTK_VanDong_GhiRo = DataReader["BLTK_VanDong_GhiRo"].ToString();
                value.BLTK_CamGiac = DataReader.GetInt("BLTK_CamGiac");
                value.BLTK_CamGiac_GhiRo = DataReader["BLTK_CamGiac_GhiRo"].ToString();
                value.BLTK_TuChu = DataReader.GetInt("BLTK_TuChu");
                value.BLTK_TuChu_GhiRo = DataReader["BLTK_TuChu_GhiRo"].ToString();
                value.CacBoPhanKhac = DataReader["CacBoPhanKhac"].ToString();
                value.DuongMau_Doi = DataReader["DuongMau_Doi"].ToString();
                value.DuongMau_SauAn = DataReader["DuongMau_SauAn"].ToString();
                value.HbAlc = DataReader["HbAlc"].ToString();
                value.Mau_Insulin = DataReader["Mau_Insulin"].ToString();
                value.Creatimin = DataReader["Creatimin"].ToString();
                value.Acrid_Uric = DataReader["Acrid_Uric"].ToString();
                value.Lipid_CT = DataReader["Lipid_CT"].ToString();
                value.Lipid_TG = DataReader["Lipid_TG"].ToString();
                value.Lipid_HDL = DataReader["Lipid_HDL"].ToString();
                value.Lipid_LDL = DataReader["Lipid_LDL"].ToString();
                value.GOT = DataReader["GOT"].ToString();
                value.GPT = DataReader["GPT"].ToString();
                value.Protein = DataReader["Protein"].ToString();
                value.Albumin = DataReader["Albumin"].ToString();
                value.CTM_HC = DataReader["CTM_HC"].ToString();
                value.CTM_Hb = DataReader["CTM_Hb"].ToString();
                value.CTM_Ht = DataReader["CTM_Ht"].ToString();
                value.CTM_BC = DataReader["CTM_BC"].ToString();
                value.CTM_TC = DataReader["CTM_TC"].ToString();
                value.NuocTieu_Protein = DataReader["NuocTieu_Protein"].ToString();
                value.NuocTieu_Duong = DataReader["NuocTieu_Duong"].ToString();
                value.NuocTieu_Cetol = DataReader["NuocTieu_Cetol"].ToString();
                value.DienTamDo = DataReader["DienTamDo"].ToString();
                value.SieuAmTim = DataReader["SieuAmTim"].ToString();
                value.SADopplerMach = DataReader["SADopplerMach"].ToString();
                value.XqTimPhoi = DataReader["XqTimPhoi"].ToString();
                value.ChanDoan = DataReader["ChanDoan"].ToString();
                value.TheDTD = DataReader.GetInt("TheDTD");
                value.Type1_Text = DataReader["Type1_Text"].ToString();
                value.Type2_Text = DataReader["Type2_Text"].ToString();
                value.Type_Khac = DataReader["Type_Khac"].ToString();
                value.BienChung = DataReader["BienChung"].ToString();
                value.BenhPhoiHop = DataReader["BenhPhoiHop"].ToString();
                value.DieuTri = DataReader["DieuTri"].ToString();
                value.LyDoThemThayThuoc = DataReader["LyDoThemThayThuoc"].ToString();
                value.HenKhamLai = DataReader["HenKhamLai"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["HenKhamLai"]) : null;
                value.HenXNLai = DataReader["HenXNLai"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["HenXNLai"]) : null;
                value.BacSyDieuTri = DataReader["BacSyDieuTri"].ToString();
                value.MaSoKyTen = DataReader["masokyten"].ToString();
                value.MaSoKyTen_KB = DataReader["masokyten_kb"].ToString();
                value.MaSoKyTen_TK = DataReader["masokyten_tk"].ToString();
            }
            try
            {
                DataReader.Close();
            }
            catch { }
            return value;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, BenhAnDaiThaoDuong BenhAnDaiThaoDuong)
        {
            try
            {
                string sql =
                          @"select MaQuanLy 
                            from BenhAnDaiThaoDuong
                            where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnDaiThaoDuong.MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                int rowCount = 0;
                while (DataReader.Read()) rowCount++;
                if (rowCount == 1) return Update(MyConnection, BenhAnDaiThaoDuong);
                sql = @"
                       INSERT INTO BenhAnDaiThaoDuong 
                        (
                            MaQuanLy,
                            LyDoNhanVaoChuongTrinh,
                            HutThuoc,
                            HutThuoc_DieuNgay,
                            HutThuoc_BaoNam,
                            HutThuoc_Bo,
                            UongRuou,
                            UongRuou_MlNgay,
                            UongRuou_Bo,
                            TangHuyetAp,
                            RoiLoanMoMau,
                            BenhGoutte,
                            BenhThan,
                            BenhThan_GhiRo,
                            BenhLyKhac,
                            BenhLyKhac_GhiRo,
                            ThoiDiemPhatHienDTD,
                            TriSoDuongHuyetCaoNhat,
                            CoTrieuChung,
                            KhamSKDinhKy,
                            TinhCo,
                            CDTTXHK,
                            ThucHienCheDoAnUong,
                            Sulffonylyra,
                            Biguanid,
                            Acrbose,
                            ThuocUong_Khac,
                            Insulin,
                            SayThai,
                            SayThai_MayLan,
                            DeCon4Kg,
                            DeCon4Kg_MayLan,
                            DeCon25kg,
                            DeCon25kg_MayLan,
                            TienSuDTDThaiNghen,
                            RLDNG,
                            GDCoBiDTD,
                            GDCoBiDTD_Text,
                            GDCoBiTimMachSom,
                            GDCoBiTimMachSom_Text,
                            TienSuBenhTatKhac,
                            TienSuBenhTatKhac_GhiRo,
                            BenhSu,
                            ChieuCao,
                            CanNang,
                            BMT,
                            VongEo,
                            VongHong,
                            ChiSoEoHong,
                            KhatUongNhieu,
                            KhatUongNhieu_SL,
                            TieuNhieu,
                            TieuNhieu_SL,
                            MetMoi,
                            SutCan,
                            DauNguc,
                            DauCanhHoi,
                            TeBiChanTay,
                            MatNhinMo,
                            TrieuChungKhac,
                            ThiLuc_MP,
                            ThiLuc_MT,
                            TonThuong_MP,
                            TonThuong_MT,
                            DaNiemMac,
                            Phu,
                            Phu_ViTri,
                            TinhTrangRangLoi,
                            NhipTim_TuTheNam,
                            HA_TuTheNam,
                            NhipTim_TuTheDung,
                            HA_TuTheDung,
                            MachNgoaiBien,
                            MachNgoaiBien_ViTri,
                            TiengPhoiDM,
                            TiengPhoiDM_ViTri,
                            BLTK_VanDong,
                            BLTK_VanDong_GhiRo,
                            BLTK_CamGiac,
                            BLTK_CamGiac_GhiRo,
                            BLTK_TuChu,
                            BLTK_TuChu_GhiRo,
                            CacBoPhanKhac,
                            DuongMau_Doi,
                            DuongMau_SauAn,
                            HbAlc,
                            Mau_Insulin,
                            Creatimin,
                            Acrid_Uric,
                            Lipid_CT,
                            Lipid_TG,
                            Lipid_HDL,
                            Lipid_LDL,
                            GOT,
                            GPT,
                            Protein,
                            Albumin,
                            CTM_HC,
                            CTM_Hb,
                            CTM_Ht,
                            CTM_BC,
                            CTM_TC,
                            NuocTieu_Protein,
                            NuocTieu_Duong,
                            NuocTieu_Cetol,
                            DienTamDo,
                            SieuAmTim,
                            SADopplerMach,
                            XqTimPhoi,
                            ChanDoan,
                            TheDTD,
                            Type1_Text,
                            Type2_Text,
                            Type_Khac,
                            BienChung,
                            BenhPhoiHop,
                            DieuTri,
                            LyDoThemThayThuoc,
                            HenKhamLai,
                            HenXNLai,
                            BacSyDieuTri
                        )                 
                        VALUES
                        (
                            :MaQuanLy,
                            :LyDoNhanVaoChuongTrinh,
                            :HutThuoc,
                            :HutThuoc_DieuNgay,
                            :HutThuoc_BaoNam,
                            :HutThuoc_Bo,
                            :UongRuou,
                            :UongRuou_MlNgay,
                            :UongRuou_Bo,
                            :TangHuyetAp,
                            :RoiLoanMoMau,
                            :BenhGoutte,
                            :BenhThan,
                            :BenhThan_GhiRo,
                            :BenhLyKhac,
                            :BenhLyKhac_GhiRo,
                            :ThoiDiemPhatHienDTD,
                            :TriSoDuongHuyetCaoNhat,
                            :CoTrieuChung,
                            :KhamSKDinhKy,
                            :TinhCo,
                            :CDTTXHK,
                            :ThucHienCheDoAnUong,
                            :Sulffonylyra,
                            :Biguanid,
                            :Acrbose,
                            :ThuocUong_Khac,
                            :Insulin,
                            :SayThai,
                            :SayThai_MayLan,
                            :DeCon4Kg,
                            :DeCon4Kg_MayLan,
                            :DeCon25kg,
                            :DeCon25kg_MayLan,
                            :TienSuDTDThaiNghen,
                            :RLDNG,
                            :GDCoBiDTD,
                            :GDCoBiDTD_Text,
                            :GDCoBiTimMachSom,
                            :GDCoBiTimMachSom_Text,
                            :TienSuBenhTatKhac,
                            :TienSuBenhTatKhac_GhiRo,
                            :BenhSu,
                            :ChieuCao,
                            :CanNang,
                            :BMT,
                            :VongEo,
                            :VongHong,
                            :ChiSoEoHong,
                            :KhatUongNhieu,
                            :KhatUongNhieu_SL,
                            :TieuNhieu,
                            :TieuNhieu_SL,
                            :MetMoi,
                            :SutCan,
                            :DauNguc,
                            :DauCanhHoi,
                            :TeBiChanTay,
                            :MatNhinMo,
                            :TrieuChungKhac,
                            :ThiLuc_MP,
                            :ThiLuc_MT,
                            :TonThuong_MP,
                            :TonThuong_MT,
                            :DaNiemMac,
                            :Phu,
                            :Phu_ViTri,
                            :TinhTrangRangLoi,
                            :NhipTim_TuTheNam,
                            :HA_TuTheNam,
                            :NhipTim_TuTheDung,
                            :HA_TuTheDung,
                            :MachNgoaiBien,
                            :MachNgoaiBien_ViTri,
                            :TiengPhoiDM,
                            :TiengPhoiDM_ViTri,
                            :BLTK_VanDong,
                            :BLTK_VanDong_GhiRo,
                            :BLTK_CamGiac,
                            :BLTK_CamGiac_GhiRo,
                            :BLTK_TuChu,
                            :BLTK_TuChu_GhiRo,
                            :CacBoPhanKhac,
                            :DuongMau_Doi,
                            :DuongMau_SauAn,
                            :HbAlc,
                            :Mau_Insulin,
                            :Creatimin,
                            :Acrid_Uric,
                            :Lipid_CT,
                            :Lipid_TG,
                            :Lipid_HDL,
                            :Lipid_LDL,
                            :GOT,
                            :GPT,
                            :Protein,
                            :Albumin,
                            :CTM_HC,
                            :CTM_Hb,
                            :CTM_Ht,
                            :CTM_BC,
                            :CTM_TC,
                            :NuocTieu_Protein,
                            :NuocTieu_Duong,
                            :NuocTieu_Cetol,
                            :DienTamDo,
                            :SieuAmTim,
                            :SADopplerMach,
                            :XqTimPhoi,
                            :ChanDoan,
                            :TheDTD,
                            :Type1_Text,
                            :Type2_Text,
                            :Type_Khac,
                            :BienChung,
                            :BenhPhoiHop,
                            :DieuTri,
                            :LyDoThemThayThuoc,
                            :HenKhamLai,
                            :HenXNLai,
                            :BacSyDieuTri
                        )";
                Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnDaiThaoDuong.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("LyDoNhanVaoChuongTrinh", BenhAnDaiThaoDuong.LyDoNhanVaoChuongTrinh));
                Command.Parameters.Add(new MDB.MDBParameter("HutThuoc", BenhAnDaiThaoDuong.HutThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("HutThuoc_DieuNgay", BenhAnDaiThaoDuong.HutThuoc_DieuNgay));
                Command.Parameters.Add(new MDB.MDBParameter("HutThuoc_BaoNam", BenhAnDaiThaoDuong.HutThuoc_BaoNam));
                Command.Parameters.Add(new MDB.MDBParameter("HutThuoc_Bo", BenhAnDaiThaoDuong.HutThuoc_Bo));
                Command.Parameters.Add(new MDB.MDBParameter("UongRuou", BenhAnDaiThaoDuong.UongRuou));
                Command.Parameters.Add(new MDB.MDBParameter("UongRuou_MlNgay", BenhAnDaiThaoDuong.UongRuou_MlNgay));
                Command.Parameters.Add(new MDB.MDBParameter("UongRuou_Bo", BenhAnDaiThaoDuong.UongRuou_Bo));
                Command.Parameters.Add(new MDB.MDBParameter("TangHuyetAp", BenhAnDaiThaoDuong.TangHuyetAp));
                Command.Parameters.Add(new MDB.MDBParameter("RoiLoanMoMau", BenhAnDaiThaoDuong.RoiLoanMoMau));
                Command.Parameters.Add(new MDB.MDBParameter("BenhGoutte", BenhAnDaiThaoDuong.BenhGoutte));
                Command.Parameters.Add(new MDB.MDBParameter("BenhThan", BenhAnDaiThaoDuong.BenhThan));
                Command.Parameters.Add(new MDB.MDBParameter("BenhThan_GhiRo", BenhAnDaiThaoDuong.BenhThan_GhiRo));
                Command.Parameters.Add(new MDB.MDBParameter("BenhLyKhac", BenhAnDaiThaoDuong.BenhLyKhac));
                Command.Parameters.Add(new MDB.MDBParameter("BenhLyKhac_GhiRo", BenhAnDaiThaoDuong.BenhLyKhac_GhiRo));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiDiemPhatHienDTD", BenhAnDaiThaoDuong.ThoiDiemPhatHienDTD));
                Command.Parameters.Add(new MDB.MDBParameter("TriSoDuongHuyetCaoNhat", BenhAnDaiThaoDuong.TriSoDuongHuyetCaoNhat));
                Command.Parameters.Add(new MDB.MDBParameter("CoTrieuChung", BenhAnDaiThaoDuong.CoTrieuChung));
                Command.Parameters.Add(new MDB.MDBParameter("KhamSKDinhKy", BenhAnDaiThaoDuong.KhamSKDinhKy));
                Command.Parameters.Add(new MDB.MDBParameter("TinhCo", BenhAnDaiThaoDuong.TinhCo));
                Command.Parameters.Add(new MDB.MDBParameter("CDTTXHK", BenhAnDaiThaoDuong.CDTTXHK));
                Command.Parameters.Add(new MDB.MDBParameter("ThucHienCheDoAnUong", BenhAnDaiThaoDuong.ThucHienCheDoAnUong));
                Command.Parameters.Add(new MDB.MDBParameter("Sulffonylyra", BenhAnDaiThaoDuong.Sulffonylyra));
                Command.Parameters.Add(new MDB.MDBParameter("Biguanid", BenhAnDaiThaoDuong.Biguanid));
                Command.Parameters.Add(new MDB.MDBParameter("Acrbose", BenhAnDaiThaoDuong.Acrbose));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocUong_Khac", BenhAnDaiThaoDuong.ThuocUong_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("Insulin", BenhAnDaiThaoDuong.Insulin));
                Command.Parameters.Add(new MDB.MDBParameter("SayThai", BenhAnDaiThaoDuong.SayThai));
                Command.Parameters.Add(new MDB.MDBParameter("SayThai_MayLan", BenhAnDaiThaoDuong.SayThai_MayLan));
                Command.Parameters.Add(new MDB.MDBParameter("DeCon4Kg", BenhAnDaiThaoDuong.DeCon4Kg));
                Command.Parameters.Add(new MDB.MDBParameter("DeCon4Kg_MayLan", BenhAnDaiThaoDuong.DeCon4Kg_MayLan));
                Command.Parameters.Add(new MDB.MDBParameter("DeCon25kg", BenhAnDaiThaoDuong.DeCon25kg));
                Command.Parameters.Add(new MDB.MDBParameter("DeCon25kg_MayLan", BenhAnDaiThaoDuong.DeCon25kg_MayLan));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuDTDThaiNghen", BenhAnDaiThaoDuong.TienSuDTDThaiNghen));
                Command.Parameters.Add(new MDB.MDBParameter("RLDNG", BenhAnDaiThaoDuong.RLDNG));
                Command.Parameters.Add(new MDB.MDBParameter("GDCoBiDTD", BenhAnDaiThaoDuong.GDCoBiDTD));
                Command.Parameters.Add(new MDB.MDBParameter("GDCoBiDTD_Text", BenhAnDaiThaoDuong.GDCoBiDTD_Text));
                Command.Parameters.Add(new MDB.MDBParameter("GDCoBiTimMachSom", BenhAnDaiThaoDuong.GDCoBiTimMachSom));
                Command.Parameters.Add(new MDB.MDBParameter("GDCoBiTimMachSom_Text", BenhAnDaiThaoDuong.GDCoBiTimMachSom_Text));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhTatKhac", BenhAnDaiThaoDuong.TienSuBenhTatKhac));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhTatKhac_GhiRo", BenhAnDaiThaoDuong.TienSuBenhTatKhac_GhiRo));
                Command.Parameters.Add(new MDB.MDBParameter("BenhSu", BenhAnDaiThaoDuong.BenhSu));
                Command.Parameters.Add(new MDB.MDBParameter("ChieuCao", BenhAnDaiThaoDuong.ChieuCao));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang", BenhAnDaiThaoDuong.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("BMT", BenhAnDaiThaoDuong.BMT));
                Command.Parameters.Add(new MDB.MDBParameter("VongEo", BenhAnDaiThaoDuong.VongEo));
                Command.Parameters.Add(new MDB.MDBParameter("VongHong", BenhAnDaiThaoDuong.VongHong));
                Command.Parameters.Add(new MDB.MDBParameter("ChiSoEoHong", BenhAnDaiThaoDuong.ChiSoEoHong));
                Command.Parameters.Add(new MDB.MDBParameter("KhatUongNhieu", BenhAnDaiThaoDuong.KhatUongNhieu));
                Command.Parameters.Add(new MDB.MDBParameter("KhatUongNhieu_SL", BenhAnDaiThaoDuong.KhatUongNhieu_SL));
                Command.Parameters.Add(new MDB.MDBParameter("TieuNhieu", BenhAnDaiThaoDuong.TieuNhieu));
                Command.Parameters.Add(new MDB.MDBParameter("TieuNhieu_SL", BenhAnDaiThaoDuong.TieuNhieu_SL));
                Command.Parameters.Add(new MDB.MDBParameter("MetMoi", BenhAnDaiThaoDuong.MetMoi));
                Command.Parameters.Add(new MDB.MDBParameter("SutCan", BenhAnDaiThaoDuong.SutCan));
                Command.Parameters.Add(new MDB.MDBParameter("DauNguc", BenhAnDaiThaoDuong.DauNguc));
                Command.Parameters.Add(new MDB.MDBParameter("DauCanhHoi", BenhAnDaiThaoDuong.DauCanhHoi));
                Command.Parameters.Add(new MDB.MDBParameter("TeBiChanTay", BenhAnDaiThaoDuong.TeBiChanTay));
                Command.Parameters.Add(new MDB.MDBParameter("MatNhinMo", BenhAnDaiThaoDuong.MatNhinMo));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungKhac", BenhAnDaiThaoDuong.TrieuChungKhac));
                Command.Parameters.Add(new MDB.MDBParameter("ThiLuc_MP", BenhAnDaiThaoDuong.ThiLuc_MP));
                Command.Parameters.Add(new MDB.MDBParameter("ThiLuc_MT", BenhAnDaiThaoDuong.ThiLuc_MT));
                Command.Parameters.Add(new MDB.MDBParameter("TonThuong_MP", BenhAnDaiThaoDuong.TonThuong_MP));
                Command.Parameters.Add(new MDB.MDBParameter("TonThuong_MT", BenhAnDaiThaoDuong.TonThuong_MT));
                Command.Parameters.Add(new MDB.MDBParameter("DaNiemMac", BenhAnDaiThaoDuong.DaNiemMac));
                Command.Parameters.Add(new MDB.MDBParameter("Phu", BenhAnDaiThaoDuong.Phu));
                Command.Parameters.Add(new MDB.MDBParameter("Phu_ViTri", BenhAnDaiThaoDuong.Phu_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangRangLoi", BenhAnDaiThaoDuong.TinhTrangRangLoi));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTim_TuTheNam", BenhAnDaiThaoDuong.NhipTim_TuTheNam));
                Command.Parameters.Add(new MDB.MDBParameter("HA_TuTheNam", BenhAnDaiThaoDuong.HA_TuTheNam));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTim_TuTheDung", BenhAnDaiThaoDuong.NhipTim_TuTheDung));
                Command.Parameters.Add(new MDB.MDBParameter("HA_TuTheDung", BenhAnDaiThaoDuong.HA_TuTheDung));
                Command.Parameters.Add(new MDB.MDBParameter("MachNgoaiBien", BenhAnDaiThaoDuong.MachNgoaiBien));
                Command.Parameters.Add(new MDB.MDBParameter("MachNgoaiBien_ViTri", BenhAnDaiThaoDuong.MachNgoaiBien_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("TiengPhoiDM", BenhAnDaiThaoDuong.TiengPhoiDM));
                Command.Parameters.Add(new MDB.MDBParameter("TiengPhoiDM_ViTri", BenhAnDaiThaoDuong.TiengPhoiDM_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("BLTK_VanDong", BenhAnDaiThaoDuong.BLTK_VanDong));
                Command.Parameters.Add(new MDB.MDBParameter("BLTK_VanDong_GhiRo", BenhAnDaiThaoDuong.BLTK_VanDong_GhiRo));
                Command.Parameters.Add(new MDB.MDBParameter("BLTK_CamGiac", BenhAnDaiThaoDuong.BLTK_CamGiac));
                Command.Parameters.Add(new MDB.MDBParameter("BLTK_CamGiac_GhiRo", BenhAnDaiThaoDuong.BLTK_CamGiac_GhiRo));
                Command.Parameters.Add(new MDB.MDBParameter("BLTK_TuChu", BenhAnDaiThaoDuong.BLTK_TuChu));
                Command.Parameters.Add(new MDB.MDBParameter("BLTK_TuChu_GhiRo", BenhAnDaiThaoDuong.BLTK_TuChu_GhiRo));
                Command.Parameters.Add(new MDB.MDBParameter("CacBoPhanKhac", BenhAnDaiThaoDuong.CacBoPhanKhac));
                Command.Parameters.Add(new MDB.MDBParameter("DuongMau_Doi", BenhAnDaiThaoDuong.DuongMau_Doi));
                Command.Parameters.Add(new MDB.MDBParameter("DuongMau_SauAn", BenhAnDaiThaoDuong.DuongMau_SauAn));
                Command.Parameters.Add(new MDB.MDBParameter("HbAlc", BenhAnDaiThaoDuong.HbAlc));
                Command.Parameters.Add(new MDB.MDBParameter("Mau_Insulin", BenhAnDaiThaoDuong.Mau_Insulin));
                Command.Parameters.Add(new MDB.MDBParameter("Creatimin", BenhAnDaiThaoDuong.Creatimin));
                Command.Parameters.Add(new MDB.MDBParameter("Acrid_Uric", BenhAnDaiThaoDuong.Acrid_Uric));
                Command.Parameters.Add(new MDB.MDBParameter("Lipid_CT", BenhAnDaiThaoDuong.Lipid_CT));
                Command.Parameters.Add(new MDB.MDBParameter("Lipid_TG", BenhAnDaiThaoDuong.Lipid_TG));
                Command.Parameters.Add(new MDB.MDBParameter("Lipid_HDL", BenhAnDaiThaoDuong.Lipid_HDL));
                Command.Parameters.Add(new MDB.MDBParameter("Lipid_LDL", BenhAnDaiThaoDuong.Lipid_LDL));
                Command.Parameters.Add(new MDB.MDBParameter("GOT", BenhAnDaiThaoDuong.GOT));
                Command.Parameters.Add(new MDB.MDBParameter("GPT", BenhAnDaiThaoDuong.GPT));
                Command.Parameters.Add(new MDB.MDBParameter("Protein", BenhAnDaiThaoDuong.Protein));
                Command.Parameters.Add(new MDB.MDBParameter("Albumin", BenhAnDaiThaoDuong.Albumin));
                Command.Parameters.Add(new MDB.MDBParameter("CTM_HC", BenhAnDaiThaoDuong.CTM_HC));
                Command.Parameters.Add(new MDB.MDBParameter("CTM_Hb", BenhAnDaiThaoDuong.CTM_Hb));
                Command.Parameters.Add(new MDB.MDBParameter("CTM_Ht", BenhAnDaiThaoDuong.CTM_Ht));
                Command.Parameters.Add(new MDB.MDBParameter("CTM_BC", BenhAnDaiThaoDuong.CTM_BC));
                Command.Parameters.Add(new MDB.MDBParameter("CTM_TC", BenhAnDaiThaoDuong.CTM_TC));
                Command.Parameters.Add(new MDB.MDBParameter("NuocTieu_Protein", BenhAnDaiThaoDuong.NuocTieu_Protein));
                Command.Parameters.Add(new MDB.MDBParameter("NuocTieu_Duong", BenhAnDaiThaoDuong.NuocTieu_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("NuocTieu_Cetol", BenhAnDaiThaoDuong.NuocTieu_Cetol));
                Command.Parameters.Add(new MDB.MDBParameter("DienTamDo", BenhAnDaiThaoDuong.DienTamDo));
                Command.Parameters.Add(new MDB.MDBParameter("SieuAmTim", BenhAnDaiThaoDuong.SieuAmTim));
                Command.Parameters.Add(new MDB.MDBParameter("SADopplerMach", BenhAnDaiThaoDuong.SADopplerMach));
                Command.Parameters.Add(new MDB.MDBParameter("XqTimPhoi", BenhAnDaiThaoDuong.XqTimPhoi));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", BenhAnDaiThaoDuong.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("TheDTD", BenhAnDaiThaoDuong.TheDTD));
                Command.Parameters.Add(new MDB.MDBParameter("Type1_Text", BenhAnDaiThaoDuong.Type1_Text));
                Command.Parameters.Add(new MDB.MDBParameter("Type2_Text", BenhAnDaiThaoDuong.Type2_Text));
                Command.Parameters.Add(new MDB.MDBParameter("Type_Khac", BenhAnDaiThaoDuong.Type_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("BienChung", BenhAnDaiThaoDuong.BienChung));
                Command.Parameters.Add(new MDB.MDBParameter("BenhPhoiHop", BenhAnDaiThaoDuong.BenhPhoiHop));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri", BenhAnDaiThaoDuong.DieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("LyDoThemThayThuoc", BenhAnDaiThaoDuong.LyDoThemThayThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("HenKhamLai", BenhAnDaiThaoDuong.HenKhamLai));
                Command.Parameters.Add(new MDB.MDBParameter("HenXNLai", BenhAnDaiThaoDuong.HenXNLai));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnDaiThaoDuong.BacSyDieuTri));

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
        public static bool Update(MDB.MDBConnection MyConnection, BenhAnDaiThaoDuong BenhAnDaiThaoDuong)
        {
            try
            {
                string sql = @"UPDATE BenhAnDaiThaoDuong SET 
                            LyDoNhanVaoChuongTrinh=:LyDoNhanVaoChuongTrinh,
                            HutThuoc=:HutThuoc,
                            HutThuoc_DieuNgay=:HutThuoc_DieuNgay,
                            HutThuoc_BaoNam=:HutThuoc_BaoNam,
                            HutThuoc_Bo=:HutThuoc_Bo,
                            UongRuou=:UongRuou,
                            UongRuou_MlNgay=:UongRuou_MlNgay,
                            UongRuou_Bo=:UongRuou_Bo,
                            TangHuyetAp=:TangHuyetAp,
                            RoiLoanMoMau=:RoiLoanMoMau,
                            BenhGoutte=:BenhGoutte,
                            BenhThan=:BenhThan,
                            BenhThan_GhiRo=:BenhThan_GhiRo,
                            BenhLyKhac=:BenhLyKhac,
                            BenhLyKhac_GhiRo=:BenhLyKhac_GhiRo,
                            ThoiDiemPhatHienDTD=:ThoiDiemPhatHienDTD,
                            TriSoDuongHuyetCaoNhat=:TriSoDuongHuyetCaoNhat,
                            CoTrieuChung=:CoTrieuChung,
                            KhamSKDinhKy=:KhamSKDinhKy,
                            TinhCo=:TinhCo,
                            CDTTXHK=:CDTTXHK,
                            ThucHienCheDoAnUong=:ThucHienCheDoAnUong,
                            Sulffonylyra=:Sulffonylyra,
                            Biguanid=:Biguanid,
                            Acrbose=:Acrbose,
                            ThuocUong_Khac=:ThuocUong_Khac,
                            Insulin=:Insulin,
                            SayThai=:SayThai,
                            SayThai_MayLan=:SayThai_MayLan,
                            DeCon4Kg=:DeCon4Kg,
                            DeCon4Kg_MayLan=:DeCon4Kg_MayLan,
                            DeCon25kg=:DeCon25kg,
                            DeCon25kg_MayLan=:DeCon25kg_MayLan,
                            TienSuDTDThaiNghen=:TienSuDTDThaiNghen,
                            RLDNG=:RLDNG,
                            GDCoBiDTD=:GDCoBiDTD,
                            GDCoBiDTD_Text=:GDCoBiDTD_Text,
                            GDCoBiTimMachSom=:GDCoBiTimMachSom,
                            GDCoBiTimMachSom_Text=:GDCoBiTimMachSom_Text,
                            TienSuBenhTatKhac=:TienSuBenhTatKhac,
                            TienSuBenhTatKhac_GhiRo=:TienSuBenhTatKhac_GhiRo,
                            BenhSu=:BenhSu,
                            ChieuCao=:ChieuCao,
                            CanNang=:CanNang,
                            BMT=:BMT,
                            VongEo=:VongEo,
                            VongHong=:VongHong,
                            ChiSoEoHong=:ChiSoEoHong,
                            KhatUongNhieu=:KhatUongNhieu,
                            KhatUongNhieu_SL=:KhatUongNhieu_SL,
                            TieuNhieu=:TieuNhieu,
                            TieuNhieu_SL=:TieuNhieu_SL,
                            MetMoi=:MetMoi,
                            SutCan=:SutCan,
                            DauNguc=:DauNguc,
                            DauCanhHoi=:DauCanhHoi,
                            TeBiChanTay=:TeBiChanTay,
                            MatNhinMo=:MatNhinMo,
                            TrieuChungKhac=:TrieuChungKhac,
                            ThiLuc_MP=:ThiLuc_MP,
                            ThiLuc_MT=:ThiLuc_MT,
                            TonThuong_MP=:TonThuong_MP,
                            TonThuong_MT=:TonThuong_MT,
                            DaNiemMac=:DaNiemMac,
                            Phu=:Phu,
                            Phu_ViTri=:Phu_ViTri,
                            TinhTrangRangLoi=:TinhTrangRangLoi,
                            NhipTim_TuTheNam=:NhipTim_TuTheNam,
                            HA_TuTheNam=:HA_TuTheNam,
                            NhipTim_TuTheDung=:NhipTim_TuTheDung,
                            HA_TuTheDung=:HA_TuTheDung,
                            MachNgoaiBien=:MachNgoaiBien,
                            MachNgoaiBien_ViTri=:MachNgoaiBien_ViTri,
                            TiengPhoiDM=:TiengPhoiDM,
                            TiengPhoiDM_ViTri=:TiengPhoiDM_ViTri,
                            BLTK_VanDong=:BLTK_VanDong,
                            BLTK_VanDong_GhiRo=:BLTK_VanDong_GhiRo,
                            BLTK_CamGiac=:BLTK_CamGiac,
                            BLTK_CamGiac_GhiRo=:BLTK_CamGiac_GhiRo,
                            BLTK_TuChu=:BLTK_TuChu,
                            BLTK_TuChu_GhiRo=:BLTK_TuChu_GhiRo,
                            CacBoPhanKhac=:CacBoPhanKhac,
                            DuongMau_Doi=:DuongMau_Doi,
                            DuongMau_SauAn=:DuongMau_SauAn,
                            HbAlc=:HbAlc,
                            Mau_Insulin=:Mau_Insulin,
                            Creatimin=:Creatimin,
                            Acrid_Uric=:Acrid_Uric,
                            Lipid_CT=:Lipid_CT,
                            Lipid_TG=:Lipid_TG,
                            Lipid_HDL=:Lipid_HDL,
                            Lipid_LDL=:Lipid_LDL,
                            GOT=:GOT,
                            GPT=:GPT,
                            Protein=:Protein,
                            Albumin=:Albumin,
                            CTM_HC=:CTM_HC,
                            CTM_Hb=:CTM_Hb,
                            CTM_Ht=:CTM_Ht,
                            CTM_BC=:CTM_BC,
                            CTM_TC=:CTM_TC,
                            NuocTieu_Protein=:NuocTieu_Protein,
                            NuocTieu_Duong=:NuocTieu_Duong,
                            NuocTieu_Cetol=:NuocTieu_Cetol,
                            DienTamDo=:DienTamDo,
                            SieuAmTim=:SieuAmTim,
                            SADopplerMach=:SADopplerMach,
                            XqTimPhoi=:XqTimPhoi,
                            ChanDoan=:ChanDoan,
                            TheDTD=:TheDTD,
                            Type1_Text=:Type1_Text,
                            Type2_Text=:Type2_Text,
                            Type_Khac=:Type_Khac,
                            BienChung=:BienChung,
                            BenhPhoiHop=:BenhPhoiHop,
                            DieuTri=:DieuTri,
                            LyDoThemThayThuoc=:LyDoThemThayThuoc,
                            HenKhamLai=:HenKhamLai,
                            HenXNLai=:HenXNLai,
                            BacSyDieuTri = :BacSyDieuTri 
                            WHERE MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("LyDoNhanVaoChuongTrinh", BenhAnDaiThaoDuong.LyDoNhanVaoChuongTrinh));
                Command.Parameters.Add(new MDB.MDBParameter("HutThuoc", BenhAnDaiThaoDuong.HutThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("HutThuoc_DieuNgay", BenhAnDaiThaoDuong.HutThuoc_DieuNgay));
                Command.Parameters.Add(new MDB.MDBParameter("HutThuoc_BaoNam", BenhAnDaiThaoDuong.HutThuoc_BaoNam));
                Command.Parameters.Add(new MDB.MDBParameter("HutThuoc_Bo", BenhAnDaiThaoDuong.HutThuoc_Bo));
                Command.Parameters.Add(new MDB.MDBParameter("UongRuou", BenhAnDaiThaoDuong.UongRuou));
                Command.Parameters.Add(new MDB.MDBParameter("UongRuou_MlNgay", BenhAnDaiThaoDuong.UongRuou_MlNgay));
                Command.Parameters.Add(new MDB.MDBParameter("UongRuou_Bo", BenhAnDaiThaoDuong.UongRuou_Bo));
                Command.Parameters.Add(new MDB.MDBParameter("TangHuyetAp", BenhAnDaiThaoDuong.TangHuyetAp));
                Command.Parameters.Add(new MDB.MDBParameter("RoiLoanMoMau", BenhAnDaiThaoDuong.RoiLoanMoMau));
                Command.Parameters.Add(new MDB.MDBParameter("BenhGoutte", BenhAnDaiThaoDuong.BenhGoutte));
                Command.Parameters.Add(new MDB.MDBParameter("BenhThan", BenhAnDaiThaoDuong.BenhThan));
                Command.Parameters.Add(new MDB.MDBParameter("BenhThan_GhiRo", BenhAnDaiThaoDuong.BenhThan_GhiRo));
                Command.Parameters.Add(new MDB.MDBParameter("BenhLyKhac", BenhAnDaiThaoDuong.BenhLyKhac));
                Command.Parameters.Add(new MDB.MDBParameter("BenhLyKhac_GhiRo", BenhAnDaiThaoDuong.BenhLyKhac_GhiRo));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiDiemPhatHienDTD", BenhAnDaiThaoDuong.ThoiDiemPhatHienDTD));
                Command.Parameters.Add(new MDB.MDBParameter("TriSoDuongHuyetCaoNhat", BenhAnDaiThaoDuong.TriSoDuongHuyetCaoNhat));
                Command.Parameters.Add(new MDB.MDBParameter("CoTrieuChung", BenhAnDaiThaoDuong.CoTrieuChung));
                Command.Parameters.Add(new MDB.MDBParameter("KhamSKDinhKy", BenhAnDaiThaoDuong.KhamSKDinhKy));
                Command.Parameters.Add(new MDB.MDBParameter("TinhCo", BenhAnDaiThaoDuong.TinhCo));
                Command.Parameters.Add(new MDB.MDBParameter("CDTTXHK", BenhAnDaiThaoDuong.CDTTXHK));
                Command.Parameters.Add(new MDB.MDBParameter("ThucHienCheDoAnUong", BenhAnDaiThaoDuong.ThucHienCheDoAnUong));
                Command.Parameters.Add(new MDB.MDBParameter("Sulffonylyra", BenhAnDaiThaoDuong.Sulffonylyra));
                Command.Parameters.Add(new MDB.MDBParameter("Biguanid", BenhAnDaiThaoDuong.Biguanid));
                Command.Parameters.Add(new MDB.MDBParameter("Acrbose", BenhAnDaiThaoDuong.Acrbose));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocUong_Khac", BenhAnDaiThaoDuong.ThuocUong_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("Insulin", BenhAnDaiThaoDuong.Insulin));
                Command.Parameters.Add(new MDB.MDBParameter("SayThai", BenhAnDaiThaoDuong.SayThai));
                Command.Parameters.Add(new MDB.MDBParameter("SayThai_MayLan", BenhAnDaiThaoDuong.SayThai_MayLan));
                Command.Parameters.Add(new MDB.MDBParameter("DeCon4Kg", BenhAnDaiThaoDuong.DeCon4Kg));
                Command.Parameters.Add(new MDB.MDBParameter("DeCon4Kg_MayLan", BenhAnDaiThaoDuong.DeCon4Kg_MayLan));
                Command.Parameters.Add(new MDB.MDBParameter("DeCon25kg", BenhAnDaiThaoDuong.DeCon25kg));
                Command.Parameters.Add(new MDB.MDBParameter("DeCon25kg_MayLan", BenhAnDaiThaoDuong.DeCon25kg_MayLan));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuDTDThaiNghen", BenhAnDaiThaoDuong.TienSuDTDThaiNghen));
                Command.Parameters.Add(new MDB.MDBParameter("RLDNG", BenhAnDaiThaoDuong.RLDNG));
                Command.Parameters.Add(new MDB.MDBParameter("GDCoBiDTD", BenhAnDaiThaoDuong.GDCoBiDTD));
                Command.Parameters.Add(new MDB.MDBParameter("GDCoBiDTD_Text", BenhAnDaiThaoDuong.GDCoBiDTD_Text));
                Command.Parameters.Add(new MDB.MDBParameter("GDCoBiTimMachSom", BenhAnDaiThaoDuong.GDCoBiTimMachSom));
                Command.Parameters.Add(new MDB.MDBParameter("GDCoBiTimMachSom_Text", BenhAnDaiThaoDuong.GDCoBiTimMachSom_Text));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhTatKhac", BenhAnDaiThaoDuong.TienSuBenhTatKhac));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhTatKhac_GhiRo", BenhAnDaiThaoDuong.TienSuBenhTatKhac_GhiRo));
                Command.Parameters.Add(new MDB.MDBParameter("BenhSu", BenhAnDaiThaoDuong.BenhSu));
                Command.Parameters.Add(new MDB.MDBParameter("ChieuCao", BenhAnDaiThaoDuong.ChieuCao));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang", BenhAnDaiThaoDuong.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("BMT", BenhAnDaiThaoDuong.BMT));
                Command.Parameters.Add(new MDB.MDBParameter("VongEo", BenhAnDaiThaoDuong.VongEo));
                Command.Parameters.Add(new MDB.MDBParameter("VongHong", BenhAnDaiThaoDuong.VongHong));
                Command.Parameters.Add(new MDB.MDBParameter("ChiSoEoHong", BenhAnDaiThaoDuong.ChiSoEoHong));
                Command.Parameters.Add(new MDB.MDBParameter("KhatUongNhieu", BenhAnDaiThaoDuong.KhatUongNhieu));
                Command.Parameters.Add(new MDB.MDBParameter("KhatUongNhieu_SL", BenhAnDaiThaoDuong.KhatUongNhieu_SL));
                Command.Parameters.Add(new MDB.MDBParameter("TieuNhieu", BenhAnDaiThaoDuong.TieuNhieu));
                Command.Parameters.Add(new MDB.MDBParameter("TieuNhieu_SL", BenhAnDaiThaoDuong.TieuNhieu_SL));
                Command.Parameters.Add(new MDB.MDBParameter("MetMoi", BenhAnDaiThaoDuong.MetMoi));
                Command.Parameters.Add(new MDB.MDBParameter("SutCan", BenhAnDaiThaoDuong.SutCan));
                Command.Parameters.Add(new MDB.MDBParameter("DauNguc", BenhAnDaiThaoDuong.DauNguc));
                Command.Parameters.Add(new MDB.MDBParameter("DauCanhHoi", BenhAnDaiThaoDuong.DauCanhHoi));
                Command.Parameters.Add(new MDB.MDBParameter("TeBiChanTay", BenhAnDaiThaoDuong.TeBiChanTay));
                Command.Parameters.Add(new MDB.MDBParameter("MatNhinMo", BenhAnDaiThaoDuong.MatNhinMo));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungKhac", BenhAnDaiThaoDuong.TrieuChungKhac));
                Command.Parameters.Add(new MDB.MDBParameter("ThiLuc_MP", BenhAnDaiThaoDuong.ThiLuc_MP));
                Command.Parameters.Add(new MDB.MDBParameter("ThiLuc_MT", BenhAnDaiThaoDuong.ThiLuc_MT));
                Command.Parameters.Add(new MDB.MDBParameter("TonThuong_MP", BenhAnDaiThaoDuong.TonThuong_MP));
                Command.Parameters.Add(new MDB.MDBParameter("TonThuong_MT", BenhAnDaiThaoDuong.TonThuong_MT));
                Command.Parameters.Add(new MDB.MDBParameter("DaNiemMac", BenhAnDaiThaoDuong.DaNiemMac));
                Command.Parameters.Add(new MDB.MDBParameter("Phu", BenhAnDaiThaoDuong.Phu));
                Command.Parameters.Add(new MDB.MDBParameter("Phu_ViTri", BenhAnDaiThaoDuong.Phu_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangRangLoi", BenhAnDaiThaoDuong.TinhTrangRangLoi));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTim_TuTheNam", BenhAnDaiThaoDuong.NhipTim_TuTheNam));
                Command.Parameters.Add(new MDB.MDBParameter("HA_TuTheNam", BenhAnDaiThaoDuong.HA_TuTheNam));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTim_TuTheDung", BenhAnDaiThaoDuong.NhipTim_TuTheDung));
                Command.Parameters.Add(new MDB.MDBParameter("HA_TuTheDung", BenhAnDaiThaoDuong.HA_TuTheDung));
                Command.Parameters.Add(new MDB.MDBParameter("MachNgoaiBien", BenhAnDaiThaoDuong.MachNgoaiBien));
                Command.Parameters.Add(new MDB.MDBParameter("MachNgoaiBien_ViTri", BenhAnDaiThaoDuong.MachNgoaiBien_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("TiengPhoiDM", BenhAnDaiThaoDuong.TiengPhoiDM));
                Command.Parameters.Add(new MDB.MDBParameter("TiengPhoiDM_ViTri", BenhAnDaiThaoDuong.TiengPhoiDM_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("BLTK_VanDong", BenhAnDaiThaoDuong.BLTK_VanDong));
                Command.Parameters.Add(new MDB.MDBParameter("BLTK_VanDong_GhiRo", BenhAnDaiThaoDuong.BLTK_VanDong_GhiRo));
                Command.Parameters.Add(new MDB.MDBParameter("BLTK_CamGiac", BenhAnDaiThaoDuong.BLTK_CamGiac));
                Command.Parameters.Add(new MDB.MDBParameter("BLTK_CamGiac_GhiRo", BenhAnDaiThaoDuong.BLTK_CamGiac_GhiRo));
                Command.Parameters.Add(new MDB.MDBParameter("BLTK_TuChu", BenhAnDaiThaoDuong.BLTK_TuChu));
                Command.Parameters.Add(new MDB.MDBParameter("BLTK_TuChu_GhiRo", BenhAnDaiThaoDuong.BLTK_TuChu_GhiRo));
                Command.Parameters.Add(new MDB.MDBParameter("CacBoPhanKhac", BenhAnDaiThaoDuong.CacBoPhanKhac));
                Command.Parameters.Add(new MDB.MDBParameter("DuongMau_Doi", BenhAnDaiThaoDuong.DuongMau_Doi));
                Command.Parameters.Add(new MDB.MDBParameter("DuongMau_SauAn", BenhAnDaiThaoDuong.DuongMau_SauAn));
                Command.Parameters.Add(new MDB.MDBParameter("HbAlc", BenhAnDaiThaoDuong.HbAlc));
                Command.Parameters.Add(new MDB.MDBParameter("Mau_Insulin", BenhAnDaiThaoDuong.Mau_Insulin));
                Command.Parameters.Add(new MDB.MDBParameter("Creatimin", BenhAnDaiThaoDuong.Creatimin));
                Command.Parameters.Add(new MDB.MDBParameter("Acrid_Uric", BenhAnDaiThaoDuong.Acrid_Uric));
                Command.Parameters.Add(new MDB.MDBParameter("Lipid_CT", BenhAnDaiThaoDuong.Lipid_CT));
                Command.Parameters.Add(new MDB.MDBParameter("Lipid_TG", BenhAnDaiThaoDuong.Lipid_TG));
                Command.Parameters.Add(new MDB.MDBParameter("Lipid_HDL", BenhAnDaiThaoDuong.Lipid_HDL));
                Command.Parameters.Add(new MDB.MDBParameter("Lipid_LDL", BenhAnDaiThaoDuong.Lipid_LDL));
                Command.Parameters.Add(new MDB.MDBParameter("GOT", BenhAnDaiThaoDuong.GOT));
                Command.Parameters.Add(new MDB.MDBParameter("GPT", BenhAnDaiThaoDuong.GPT));
                Command.Parameters.Add(new MDB.MDBParameter("Protein", BenhAnDaiThaoDuong.Protein));
                Command.Parameters.Add(new MDB.MDBParameter("Albumin", BenhAnDaiThaoDuong.Albumin));
                Command.Parameters.Add(new MDB.MDBParameter("CTM_HC", BenhAnDaiThaoDuong.CTM_HC));
                Command.Parameters.Add(new MDB.MDBParameter("CTM_Hb", BenhAnDaiThaoDuong.CTM_Hb));
                Command.Parameters.Add(new MDB.MDBParameter("CTM_Ht", BenhAnDaiThaoDuong.CTM_Ht));
                Command.Parameters.Add(new MDB.MDBParameter("CTM_BC", BenhAnDaiThaoDuong.CTM_BC));
                Command.Parameters.Add(new MDB.MDBParameter("CTM_TC", BenhAnDaiThaoDuong.CTM_TC));
                Command.Parameters.Add(new MDB.MDBParameter("NuocTieu_Protein", BenhAnDaiThaoDuong.NuocTieu_Protein));
                Command.Parameters.Add(new MDB.MDBParameter("NuocTieu_Duong", BenhAnDaiThaoDuong.NuocTieu_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("NuocTieu_Cetol", BenhAnDaiThaoDuong.NuocTieu_Cetol));
                Command.Parameters.Add(new MDB.MDBParameter("DienTamDo", BenhAnDaiThaoDuong.DienTamDo));
                Command.Parameters.Add(new MDB.MDBParameter("SieuAmTim", BenhAnDaiThaoDuong.SieuAmTim));
                Command.Parameters.Add(new MDB.MDBParameter("SADopplerMach", BenhAnDaiThaoDuong.SADopplerMach));
                Command.Parameters.Add(new MDB.MDBParameter("XqTimPhoi", BenhAnDaiThaoDuong.XqTimPhoi));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", BenhAnDaiThaoDuong.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("TheDTD", BenhAnDaiThaoDuong.TheDTD));
                Command.Parameters.Add(new MDB.MDBParameter("Type1_Text", BenhAnDaiThaoDuong.Type1_Text));
                Command.Parameters.Add(new MDB.MDBParameter("Type2_Text", BenhAnDaiThaoDuong.Type2_Text));
                Command.Parameters.Add(new MDB.MDBParameter("Type_Khac", BenhAnDaiThaoDuong.Type_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("BienChung", BenhAnDaiThaoDuong.BienChung));
                Command.Parameters.Add(new MDB.MDBParameter("BenhPhoiHop", BenhAnDaiThaoDuong.BenhPhoiHop));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri", BenhAnDaiThaoDuong.DieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("LyDoThemThayThuoc", BenhAnDaiThaoDuong.LyDoThemThayThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("HenKhamLai", BenhAnDaiThaoDuong.HenKhamLai));
                Command.Parameters.Add(new MDB.MDBParameter("HenXNLai", BenhAnDaiThaoDuong.HenXNLai));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnDaiThaoDuong.BacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnDaiThaoDuong.MaQuanLy));
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
