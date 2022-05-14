using EMR_MAIN.DATABASE.BenhAn;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;


namespace EMR_MAIN.DATABASE.BenhAnFunc
{
    public class BenhAnBenhBaseDowFunc
    {
        public static void WriteXml(MDB.MDBConnection MyConnection)
        {
            string sql =
                   @"
                  select  a.*,  CTScanner HoSo_CTScanner, SieuAm HoSo_SieuAm, XetNghiem HoSo_XetNghiem,  Khac HoSo_Khac,  Khac_Text HoSo_Khac_Text,  ToanBoHoSo HoSo_ToanBoHoSo, Mach DauSinhTon_Mach,  NhietDo DauSinhTon_NhietDo,  HuyetAp DauSinhTon_HuyetAp,  NhipTho DauSinhTon_NhipTho,  CanNang DauSinhTon_CanNang  
                  from BenhAnBenhBaseDow a inner join thongtindieutri b on a.maquanly = b.maquanly
                  where rownum = 1
                    ";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            var DataTable = new DataTable { TableName = "BenhAnBenhBaseDow" };
            DataTable.Load(DataReader as IDataReader);
            DataTable.WriteXml("rptBenhAnBenhBaseDow.xml");
        }
        public static DataSet SelectDataSet(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql =
                   @"
                  select  a.*, f.hovaten BacSyHoVaTen, b.ChanDoan_NoiChuyenDen, b.Mach DauSinhTon_Mach,  b.NhietDo DauSinhTon_NhietDo,  b.HuyetAp DauSinhTon_HuyetAp,  b.NhipTho DauSinhTon_NhipTho, b.CanNang DauSinhTon_CanNang   
                        from BenhAnBenhBaseDow a  
                  left join nhanvien f on a.BacSyDieuTri = f.manhanvien
                  left join thongtindieutri b on a.maquanly = b.maquanly  
                  where a.maquanly = " + MaQuanLy;
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(sql, MyConnection);
            var ds = new DataSet();
            adt.Fill(ds, "Table");

            return ds;
        }
        public static BenhAnBenhBaseDow Select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            var obj = new BenhAnBenhBaseDow();
            try
            {
                #region
                string sql =
                          @"select * 
                        from BenhAnBenhBaseDow 
                        where MaQuanLy = :MaQuanLy";
                #endregion
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    // Phần chung Hành chính
                    obj.MaQuanLy = DataReader.GetDecimal("MaQuanLy");
                    obj.MetMoi = DataReader.GetInt("MetMoi");
                    obj.GaySutCan = DataReader.GetInt("GaySutCan");
                    obj.RunChanTay = DataReader.GetInt("RunChanTay");
                    obj.CoTo = DataReader.GetInt("CoTo");
                    obj.LoiMat = DataReader.GetInt("LoiMat");
                    obj.HoiHopTucNguc = DataReader.GetInt("HoiHopTucNguc");
                    obj.LyDoKhac = DataReader.GetInt("LyDoKhac");
                    obj.HenPheQuan = DataReader.GetInt("HenPheQuan");
                    obj.BenhLyDaDay = DataReader.GetInt("BenhLyDaDay");
                    obj.KinhNguyet = DataReader.GetInt("KinhNguyet");
                    obj.Basedow = DataReader.GetInt("Basedow");
                    obj.BuouCo = DataReader.GetInt("BuouCo");
                    obj.BenhKhac = DataReader.GetInt("BenhKhac");
                    obj.QuaTrinhBenhLy = DataReader["QuaTrinhBenhLy"].ToString();
                    obj.DienBienBenh = DataReader["DienBienBenh"].ToString();
                    obj.ChanDoanBenh_Nam = DataReader["ChanDoanBenh_Nam"].ToString();
                    obj.NoiChanDoan = DataReader["NoiChanDoan"].ToString();
                    obj.BenhSu_DieuTri = DataReader.GetInt("BenhSu_DieuTri");
                    obj.ThuocDangDieuTri = DataReader["ThuocDangDieuTri"].ToString();
                    obj.DieuTriI131 = DataReader.GetInt("DieuTriI131");
                    obj.DieuTriBangPhauThuat = DataReader.GetInt("DieuTriBangPhauThuat");
                    obj.HienTai_MetMoi = DataReader.GetInt("HienTai_MetMoi");
                    obj.HienTai_GaySutCan = DataReader.GetInt("HienTai_GaySutCan");
                    obj.HienTai_RunTayChan = DataReader.GetInt("HienTai_RunTayChan");
                    obj.HienTai_CoTo = DataReader.GetInt("HienTai_CoTo");
                    obj.HienTai_MatLoi = DataReader.GetInt("HienTai_MatLoi");
                    obj.HienTai_NguoiNongBuc = DataReader.GetInt("HienTai_NguoiNongBuc");
                    obj.HienTai_RoiLoanTieuHoa = DataReader.GetInt("HienTai_RoiLoanTieuHoa");
                    obj.HienTai_Khac = DataReader.GetInt("HienTai_Khac");
                    obj.NgayKham = DataReader["NgayKham"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayKham"]) : null;
                    obj.CanNang = DataReader["CanNang"].ToString();
                    obj.ToanThan_Tinh = DataReader.GetInt("ToanThan_Tinh");
                    obj.ToanThan_DaNongAm = DataReader.GetInt("ToanThan_DaNongAm");
                    obj.ToanThan_DaNiemMacMatVang = DataReader.GetInt("ToanThan_DaNiemMacMatVang");
                    obj.ToanThan_RunTay = DataReader.GetInt("ToanThan_RunTay");
                    obj.ToanThan_Khac = DataReader.GetInt("ToanThan_Khac");
                    obj.NhipTim = DataReader["NhipTim"].ToString();
                    obj.NhipTim_Deu = DataReader.GetInt("NhipTim_Deu");
                    obj.TiengTim = DataReader["TiengTim"].ToString();
                    obj.HA = DataReader["HA"].ToString();
                    obj.TuyenGiap = DataReader.GetInt("TuyenGiap");
                    obj.MatDo_Mem = DataReader.GetInt("MatDo_Mem");
                    obj.MatDo_Chac = DataReader.GetInt("MatDo_Chac");
                    obj.BuouLanToa = DataReader.GetInt("BuouLanToa");
                    obj.NhanThuyPhai = DataReader.GetInt("NhanThuyPhai");
                    obj.NhanThuyTrai = DataReader.GetInt("NhanThuyTrai");
                    obj.Nhan2Thuy = DataReader.GetInt("Nhan2Thuy");
                    obj.TTTT_ThuyPhai = DataReader.GetInt("TTTT_ThuyPhai");
                    obj.TTTT_ThuyTrai = DataReader.GetInt("TTTT_ThuyTrai");
                    obj.TTTT_KhongCo = DataReader.GetInt("TTTT_KhongCo");
                    obj.TTLT_ThuyPhai = DataReader.GetInt("TTLT_ThuyPhai");
                    obj.TTLT_ThuyTrai = DataReader.GetInt("TTLT_ThuyTrai");
                    obj.TTLT_KhongCo = DataReader.GetInt("TTLT_KhongCo");
                    obj.MatPhaiNOSPECSDo = DataReader["MatPhaiNOSPECSDo"].ToString();
                    obj.MatTraiNOSPECSDo = DataReader["MatTraiNOSPECSDo"].ToString();
                    obj.HoHap = DataReader["HoHap"].ToString();
                    obj.ThanKinh = DataReader["ThanKinh"].ToString();
                    obj.Bung = DataReader["Bung"].ToString();
                    obj.BoPhanKhac = DataReader["BoPhanKhac"].ToString();
                    obj.Ure = DataReader["Ure"].ToString();
                    obj.Glucose = DataReader["Glucose"].ToString();
                    obj.Creatinin = DataReader["Creatinin"].ToString();
                    obj.Cholesterol_TP = DataReader["Cholesterol_TP"].ToString();
                    obj.TG = DataReader["TG"].ToString();
                    obj.HDL_C = DataReader["HDL_C"].ToString();
                    obj.LDL_C = DataReader["LDL_C"].ToString();
                    obj.Acid = DataReader["Acid"].ToString();
                    obj.SGOT = DataReader["SGOT"].ToString();
                    obj.SGPT = DataReader["SGPT"].ToString();
                    obj.Protein = DataReader["Protein"].ToString();
                    obj.Albumin = DataReader["Albumin"].ToString();
                    obj.Na = DataReader["Na"].ToString();
                    obj.K = DataReader["K"].ToString();
                    obj.Cl = DataReader["Cl"].ToString();
                    obj.Ca = DataReader["Ca"].ToString();
                    obj.HC = DataReader["HC"].ToString();
                    obj.Hb = DataReader["Hb"].ToString();
                    obj.HCT = DataReader["HCT"].ToString();
                    obj.BC = DataReader["BC"].ToString();
                    obj.TT = DataReader["TT"].ToString();
                    obj.lympho = DataReader["lympho"].ToString();
                    obj.TC = DataReader["TC"].ToString();
                    obj.T3 = DataReader["T3"].ToString();
                    obj.FT3 = DataReader["FT3"].ToString();
                    obj.FT4 = DataReader["FT4"].ToString();
                    obj.TSH = DataReader["TSH"].ToString();
                    obj.Anti_TPO = DataReader["Anti_TPO"].ToString();
                    obj.TRAb = DataReader["TRAb"].ToString();
                    obj.SieuAmTuyenGiap = DataReader["SieuAmTuyenGiap"].ToString();
                    obj.DoTapTrungI131 = DataReader["DoTapTrungI131"].ToString();
                    obj.XaHinhTuyenGiap = DataReader["XaHinhTuyenGiap"].ToString();
                    obj.DienTim = DataReader["DienTim"].ToString();
                    obj.SieuAmDopple = DataReader["SieuAmDopple"].ToString();
                    obj.XQTimPhoi = DataReader["XQTimPhoi"].ToString();
                    obj.ChanDoan_Benh = DataReader["ChanDoan_Benh"].ToString();
                    obj.ChanDoan_BienChung = DataReader["ChanDoan_BienChung"].ToString();
                    obj.ChanDoan_BenhPhoiHop = DataReader["ChanDoan_BenhPhoiHop"].ToString();
                    obj.DieuTri = DataReader["DieuTri"].ToString();
                    obj.LyDoThemThayThuoc = DataReader["LyDoThemThayThuoc"].ToString();
                    obj.HenKhamLaiNgay = DataReader["HenKhamLaiNgay"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["HenKhamLaiNgay"]) : null;
                    obj.HenXNLaiNgay = DataReader["HenXNLaiNgay"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["HenXNLaiNgay"]) : null;
                    obj.BacSyDieuTri = DataReader["BacSyDieuTri"].ToString();
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return obj;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, BenhAnBenhBaseDow BenhAnBenhBaseDow)
        {
            try
            {
                string sql =
                          @"select MaQuanLy 
                            from BenhAnBenhBaseDow
                            where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnBenhBaseDow.MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                int rowCount = 0;
                while (DataReader.Read()) rowCount++;
                if (rowCount == 1) return Update(MyConnection, BenhAnBenhBaseDow);
                sql = @"
                       INSERT INTO BenhAnBenhBaseDow 
                        (
                            MaQuanLy,
                            MetMoi,
                            GaySutCan,
                            RunChanTay,
                            CoTo,
                            LoiMat,
                            HoiHopTucNguc,
                            LyDoKhac,
                            HenPheQuan,
                            BenhLyDaDay,
                            KinhNguyet,
                            Basedow,
                            BuouCo,
                            BenhKhac,
                            QuaTrinhBenhLy,
                            DienBienBenh,
                            ChanDoanBenh_Nam,
                            NoiChanDoan,
                            BenhSu_DieuTri,
                            ThuocDangDieuTri,
                            DieuTriI131,
                            DieuTriBangPhauThuat,
                            HienTai_MetMoi,
                            HienTai_GaySutCan,
                            HienTai_RunTayChan,
                            HienTai_CoTo,
                            HienTai_MatLoi,
                            HienTai_NguoiNongBuc,
                            HienTai_RoiLoanTieuHoa,
                            HienTai_Khac,
                            NgayKham,
                            CanNang,
                            ToanThan_Tinh,
                            ToanThan_DaNongAm,
                            ToanThan_DaNiemMacMatVang,
                            ToanThan_RunTay,
                            ToanThan_Khac,
                            NhipTim,
                            NhipTim_Deu,
                            TiengTim,
                            HA,
                            TuyenGiap,
                            MatDo_Mem,
                            MatDo_Chac,
                            BuouLanToa,
                            NhanThuyPhai,
                            NhanThuyTrai,
                            Nhan2Thuy,
                            TTTT_ThuyPhai,
                            TTTT_ThuyTrai,
                            TTTT_KhongCo,
                            TTLT_ThuyPhai,
                            TTLT_ThuyTrai,
                            TTLT_KhongCo,
                            MatPhaiNOSPECSDo,
                            MatTraiNOSPECSDo,
                            HoHap,
                            ThanKinh,
                            Bung,
                            BoPhanKhac,
                            Ure,
                            Glucose,
                            Creatinin,
                            Cholesterol_TP,
                            TG,
                            HDL_C,
                            LDL_C,
                            Acid,
                            SGOT,
                            SGPT,
                            Protein,
                            Albumin,
                            Na,
                            K,
                            Cl,
                            Ca,
                            HC,
                            Hb,
                            HCT,
                            BC,
                            TT,
                            lympho,
                            TC,
                            T3,
                            FT3,
                            FT4,
                            TSH,
                            Anti_TPO,
                            TRAb,
                            SieuAmTuyenGiap,
                            DoTapTrungI131,
                            XaHinhTuyenGiap,
                            DienTim,
                            SieuAmDopple,
                            XQTimPhoi,
                            ChanDoan_Benh,
                            ChanDoan_BienChung,
                            ChanDoan_BenhPhoiHop,
                            DieuTri,
                            LyDoThemThayThuoc,
                            HenKhamLaiNgay,
                            HenXNLaiNgay,
                            BacSyDieuTri
                        )                 
                        VALUES
                        (
                            :MaQuanLy,
                            :MetMoi,
                            :GaySutCan,
                            :RunChanTay,
                            :CoTo,
                            :LoiMat,
                            :HoiHopTucNguc,
                            :LyDoKhac,
                            :HenPheQuan,
                            :BenhLyDaDay,
                            :KinhNguyet,
                            :Basedow,
                            :BuouCo,
                            :BenhKhac,
                            :QuaTrinhBenhLy,
                            :DienBienBenh,
                            :ChanDoanBenh_Nam,
                            :NoiChanDoan,
                            :BenhSu_DieuTri,
                            :ThuocDangDieuTri,
                            :DieuTriI131,
                            :DieuTriBangPhauThuat,
                            :HienTai_MetMoi,
                            :HienTai_GaySutCan,
                            :HienTai_RunTayChan,
                            :HienTai_CoTo,
                            :HienTai_MatLoi,
                            :HienTai_NguoiNongBuc,
                            :HienTai_RoiLoanTieuHoa,
                            :HienTai_Khac,
                            :NgayKham,
                            :CanNang,
                            :ToanThan_Tinh,
                            :ToanThan_DaNongAm,
                            :ToanThan_DaNiemMacMatVang,
                            :ToanThan_RunTay,
                            :ToanThan_Khac,
                            :NhipTim,
                            :NhipTim_Deu,
                            :TiengTim,
                            :HA,
                            :TuyenGiap,
                            :MatDo_Mem,
                            :MatDo_Chac,
                            :BuouLanToa,
                            :NhanThuyPhai,
                            :NhanThuyTrai,
                            :Nhan2Thuy,
                            :TTTT_ThuyPhai,
                            :TTTT_ThuyTrai,
                            :TTTT_KhongCo,
                            :TTLT_ThuyPhai,
                            :TTLT_ThuyTrai,
                            :TTLT_KhongCo,
                            :MatPhaiNOSPECSDo,
                            :MatTraiNOSPECSDo,
                            :HoHap,
                            :ThanKinh,
                            :Bung,
                            :BoPhanKhac,
                            :Ure,
                            :Glucose,
                            :Creatinin,
                            :Cholesterol_TP,
                            :TG,
                            :HDL_C,
                            :LDL_C,
                            :Acid,
                            :SGOT,
                            :SGPT,
                            :Protein,
                            :Albumin,
                            :Na,
                            :K,
                            :Cl,
                            :Ca,
                            :HC,
                            :Hb,
                            :HCT,
                            :BC,
                            :TT,
                            :lympho,
                            :TC,
                            :T3,
                            :FT3,
                            :FT4,
                            :TSH,
                            :Anti_TPO,
                            :TRAb,
                            :SieuAmTuyenGiap,
                            :DoTapTrungI131,
                            :XaHinhTuyenGiap,
                            :DienTim,
                            :SieuAmDopple,
                            :XQTimPhoi,
                            :ChanDoan_Benh,
                            :ChanDoan_BienChung,
                            :ChanDoan_BenhPhoiHop,
                            :DieuTri,
                            :LyDoThemThayThuoc,
                            :HenKhamLaiNgay,
                            :HenXNLaiNgay,
                            :BacSyDieuTri     
                        )";
                Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnBenhBaseDow.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MetMoi", BenhAnBenhBaseDow.MetMoi));
                Command.Parameters.Add(new MDB.MDBParameter("GaySutCan", BenhAnBenhBaseDow.GaySutCan));
                Command.Parameters.Add(new MDB.MDBParameter("RunChanTay", BenhAnBenhBaseDow.RunChanTay));
                Command.Parameters.Add(new MDB.MDBParameter("CoTo", BenhAnBenhBaseDow.CoTo));
                Command.Parameters.Add(new MDB.MDBParameter("LoiMat", BenhAnBenhBaseDow.LoiMat));
                Command.Parameters.Add(new MDB.MDBParameter("HoiHopTucNguc", BenhAnBenhBaseDow.HoiHopTucNguc));
                Command.Parameters.Add(new MDB.MDBParameter("LyDoKhac", BenhAnBenhBaseDow.LyDoKhac));
                Command.Parameters.Add(new MDB.MDBParameter("HenPheQuan", BenhAnBenhBaseDow.HenPheQuan));
                Command.Parameters.Add(new MDB.MDBParameter("BenhLyDaDay", BenhAnBenhBaseDow.BenhLyDaDay));
                Command.Parameters.Add(new MDB.MDBParameter("KinhNguyet", BenhAnBenhBaseDow.KinhNguyet));
                Command.Parameters.Add(new MDB.MDBParameter("Basedow", BenhAnBenhBaseDow.Basedow));
                Command.Parameters.Add(new MDB.MDBParameter("BuouCo", BenhAnBenhBaseDow.BuouCo));
                Command.Parameters.Add(new MDB.MDBParameter("BenhKhac", BenhAnBenhBaseDow.BenhKhac));
                Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnBenhBaseDow.QuaTrinhBenhLy));
                Command.Parameters.Add(new MDB.MDBParameter("DienBienBenh", BenhAnBenhBaseDow.DienBienBenh));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanBenh_Nam", BenhAnBenhBaseDow.ChanDoanBenh_Nam));
                Command.Parameters.Add(new MDB.MDBParameter("NoiChanDoan", BenhAnBenhBaseDow.NoiChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("BenhSu_DieuTri", BenhAnBenhBaseDow.BenhSu_DieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocDangDieuTri", BenhAnBenhBaseDow.ThuocDangDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriI131", BenhAnBenhBaseDow.DieuTriI131));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriBangPhauThuat", BenhAnBenhBaseDow.DieuTriBangPhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("HienTai_MetMoi", BenhAnBenhBaseDow.HienTai_MetMoi));
                Command.Parameters.Add(new MDB.MDBParameter("HienTai_GaySutCan", BenhAnBenhBaseDow.HienTai_GaySutCan));
                Command.Parameters.Add(new MDB.MDBParameter("HienTai_RunTayChan", BenhAnBenhBaseDow.HienTai_RunTayChan));
                Command.Parameters.Add(new MDB.MDBParameter("HienTai_CoTo", BenhAnBenhBaseDow.HienTai_CoTo));
                Command.Parameters.Add(new MDB.MDBParameter("HienTai_MatLoi", BenhAnBenhBaseDow.HienTai_MatLoi));
                Command.Parameters.Add(new MDB.MDBParameter("HienTai_NguoiNongBuc", BenhAnBenhBaseDow.HienTai_NguoiNongBuc));
                Command.Parameters.Add(new MDB.MDBParameter("HienTai_RoiLoanTieuHoa", BenhAnBenhBaseDow.HienTai_RoiLoanTieuHoa));
                Command.Parameters.Add(new MDB.MDBParameter("HienTai_Khac", BenhAnBenhBaseDow.HienTai_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("NgayKham", BenhAnBenhBaseDow.NgayKham));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang", BenhAnBenhBaseDow.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("ToanThan_Tinh", BenhAnBenhBaseDow.ToanThan_Tinh));
                Command.Parameters.Add(new MDB.MDBParameter("ToanThan_DaNongAm", BenhAnBenhBaseDow.ToanThan_DaNongAm));
                Command.Parameters.Add(new MDB.MDBParameter("ToanThan_DaNiemMacMatVang", BenhAnBenhBaseDow.ToanThan_DaNiemMacMatVang));
                Command.Parameters.Add(new MDB.MDBParameter("ToanThan_RunTay", BenhAnBenhBaseDow.ToanThan_RunTay));
                Command.Parameters.Add(new MDB.MDBParameter("ToanThan_Khac", BenhAnBenhBaseDow.ToanThan_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTim", BenhAnBenhBaseDow.NhipTim));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTim_Deu", BenhAnBenhBaseDow.NhipTim_Deu));
                Command.Parameters.Add(new MDB.MDBParameter("TiengTim", BenhAnBenhBaseDow.TiengTim));
                Command.Parameters.Add(new MDB.MDBParameter("HA", BenhAnBenhBaseDow.HA));
                Command.Parameters.Add(new MDB.MDBParameter("TuyenGiap", BenhAnBenhBaseDow.TuyenGiap));
                Command.Parameters.Add(new MDB.MDBParameter("MatDo_Mem", BenhAnBenhBaseDow.MatDo_Mem));
                Command.Parameters.Add(new MDB.MDBParameter("MatDo_Chac", BenhAnBenhBaseDow.MatDo_Chac));
                Command.Parameters.Add(new MDB.MDBParameter("BuouLanToa", BenhAnBenhBaseDow.BuouLanToa));
                Command.Parameters.Add(new MDB.MDBParameter("NhanThuyPhai", BenhAnBenhBaseDow.NhanThuyPhai));
                Command.Parameters.Add(new MDB.MDBParameter("NhanThuyTrai", BenhAnBenhBaseDow.NhanThuyTrai));
                Command.Parameters.Add(new MDB.MDBParameter("Nhan2Thuy", BenhAnBenhBaseDow.Nhan2Thuy));
                Command.Parameters.Add(new MDB.MDBParameter("TTTT_ThuyPhai", BenhAnBenhBaseDow.TTTT_ThuyPhai));
                Command.Parameters.Add(new MDB.MDBParameter("TTTT_ThuyTrai", BenhAnBenhBaseDow.TTTT_ThuyTrai));
                Command.Parameters.Add(new MDB.MDBParameter("TTTT_KhongCo", BenhAnBenhBaseDow.TTTT_KhongCo));
                Command.Parameters.Add(new MDB.MDBParameter("TTLT_ThuyPhai", BenhAnBenhBaseDow.TTLT_ThuyPhai));
                Command.Parameters.Add(new MDB.MDBParameter("TTLT_ThuyTrai", BenhAnBenhBaseDow.TTLT_ThuyTrai));
                Command.Parameters.Add(new MDB.MDBParameter("TTLT_KhongCo", BenhAnBenhBaseDow.TTLT_KhongCo));
                Command.Parameters.Add(new MDB.MDBParameter("MatPhaiNOSPECSDo", BenhAnBenhBaseDow.MatPhaiNOSPECSDo));
                Command.Parameters.Add(new MDB.MDBParameter("MatTraiNOSPECSDo", BenhAnBenhBaseDow.MatTraiNOSPECSDo));
                Command.Parameters.Add(new MDB.MDBParameter("HoHap", BenhAnBenhBaseDow.HoHap));
                Command.Parameters.Add(new MDB.MDBParameter("ThanKinh", BenhAnBenhBaseDow.ThanKinh));
                Command.Parameters.Add(new MDB.MDBParameter("Bung", BenhAnBenhBaseDow.Bung));
                Command.Parameters.Add(new MDB.MDBParameter("BoPhanKhac", BenhAnBenhBaseDow.BoPhanKhac));
                Command.Parameters.Add(new MDB.MDBParameter("Ure", BenhAnBenhBaseDow.Ure));
                Command.Parameters.Add(new MDB.MDBParameter("Glucose", BenhAnBenhBaseDow.Glucose));
                Command.Parameters.Add(new MDB.MDBParameter("Creatinin", BenhAnBenhBaseDow.Creatinin));
                Command.Parameters.Add(new MDB.MDBParameter("Cholesterol_TP", BenhAnBenhBaseDow.Cholesterol_TP));
                Command.Parameters.Add(new MDB.MDBParameter("TG", BenhAnBenhBaseDow.TG));
                Command.Parameters.Add(new MDB.MDBParameter("HDL_C", BenhAnBenhBaseDow.HDL_C));
                Command.Parameters.Add(new MDB.MDBParameter("LDL_C", BenhAnBenhBaseDow.LDL_C));
                Command.Parameters.Add(new MDB.MDBParameter("Acid", BenhAnBenhBaseDow.Acid));
                Command.Parameters.Add(new MDB.MDBParameter("SGOT", BenhAnBenhBaseDow.SGOT));
                Command.Parameters.Add(new MDB.MDBParameter("SGPT", BenhAnBenhBaseDow.SGPT));
                Command.Parameters.Add(new MDB.MDBParameter("Protein", BenhAnBenhBaseDow.Protein));
                Command.Parameters.Add(new MDB.MDBParameter("Albumin", BenhAnBenhBaseDow.Albumin));
                Command.Parameters.Add(new MDB.MDBParameter("Na", BenhAnBenhBaseDow.Na));
                Command.Parameters.Add(new MDB.MDBParameter("K", BenhAnBenhBaseDow.K));
                Command.Parameters.Add(new MDB.MDBParameter("Cl", BenhAnBenhBaseDow.Cl));
                Command.Parameters.Add(new MDB.MDBParameter("Ca", BenhAnBenhBaseDow.Ca));
                Command.Parameters.Add(new MDB.MDBParameter("HC", BenhAnBenhBaseDow.HC));
                Command.Parameters.Add(new MDB.MDBParameter("Hb", BenhAnBenhBaseDow.Hb));
                Command.Parameters.Add(new MDB.MDBParameter("HCT", BenhAnBenhBaseDow.HCT));
                Command.Parameters.Add(new MDB.MDBParameter("BC", BenhAnBenhBaseDow.BC));
                Command.Parameters.Add(new MDB.MDBParameter("TT", BenhAnBenhBaseDow.TT));
                Command.Parameters.Add(new MDB.MDBParameter("lympho", BenhAnBenhBaseDow.lympho));
                Command.Parameters.Add(new MDB.MDBParameter("TC", BenhAnBenhBaseDow.TC));
                Command.Parameters.Add(new MDB.MDBParameter("T3", BenhAnBenhBaseDow.T3));
                Command.Parameters.Add(new MDB.MDBParameter("FT3", BenhAnBenhBaseDow.FT3));
                Command.Parameters.Add(new MDB.MDBParameter("FT4", BenhAnBenhBaseDow.FT4));
                Command.Parameters.Add(new MDB.MDBParameter("TSH", BenhAnBenhBaseDow.TSH));
                Command.Parameters.Add(new MDB.MDBParameter("Anti_TPO", BenhAnBenhBaseDow.Anti_TPO));
                Command.Parameters.Add(new MDB.MDBParameter("TRAb", BenhAnBenhBaseDow.TRAb));
                Command.Parameters.Add(new MDB.MDBParameter("SieuAmTuyenGiap", BenhAnBenhBaseDow.SieuAmTuyenGiap));
                Command.Parameters.Add(new MDB.MDBParameter("DoTapTrungI131", BenhAnBenhBaseDow.DoTapTrungI131));
                Command.Parameters.Add(new MDB.MDBParameter("XaHinhTuyenGiap", BenhAnBenhBaseDow.XaHinhTuyenGiap));
                Command.Parameters.Add(new MDB.MDBParameter("DienTim", BenhAnBenhBaseDow.DienTim));
                Command.Parameters.Add(new MDB.MDBParameter("SieuAmDopple", BenhAnBenhBaseDow.SieuAmDopple));
                Command.Parameters.Add(new MDB.MDBParameter("XQTimPhoi", BenhAnBenhBaseDow.XQTimPhoi));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan_Benh", BenhAnBenhBaseDow.ChanDoan_Benh));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan_BienChung", BenhAnBenhBaseDow.ChanDoan_BienChung));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan_BenhPhoiHop", BenhAnBenhBaseDow.ChanDoan_BenhPhoiHop));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri", BenhAnBenhBaseDow.DieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("LyDoThemThayThuoc", BenhAnBenhBaseDow.LyDoThemThayThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("HenKhamLaiNgay", BenhAnBenhBaseDow.HenKhamLaiNgay));
                Command.Parameters.Add(new MDB.MDBParameter("HenXNLaiNgay", BenhAnBenhBaseDow.HenXNLaiNgay));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnBenhBaseDow.BacSyDieuTri));


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
        public static bool Update(MDB.MDBConnection MyConnection, BenhAnBenhBaseDow BenhAnBenhBaseDow)
        {
            try
            {
                string sql = @"UPDATE BenhAnBenhBaseDow SET 
                            MetMoi=:MetMoi,
                            GaySutCan=:GaySutCan,
                            RunChanTay=:RunChanTay,
                            CoTo=:CoTo,
                            LoiMat=:LoiMat,
                            HoiHopTucNguc=:HoiHopTucNguc,
                            LyDoKhac=:LyDoKhac,
                            HenPheQuan=:HenPheQuan,
                            BenhLyDaDay=:BenhLyDaDay,
                            KinhNguyet=:KinhNguyet,
                            Basedow=:Basedow,
                            BuouCo=:BuouCo,
                            BenhKhac=:BenhKhac,
                            QuaTrinhBenhLy=:QuaTrinhBenhLy,
                            DienBienBenh=:DienBienBenh,
                            ChanDoanBenh_Nam=:ChanDoanBenh_Nam,
                            NoiChanDoan=:NoiChanDoan,
                            BenhSu_DieuTri=:BenhSu_DieuTri,
                            ThuocDangDieuTri=:ThuocDangDieuTri,
                            DieuTriI131=:DieuTriI131,
                            DieuTriBangPhauThuat=:DieuTriBangPhauThuat,
                            HienTai_MetMoi=:HienTai_MetMoi,
                            HienTai_GaySutCan=:HienTai_GaySutCan,
                            HienTai_RunTayChan=:HienTai_RunTayChan,
                            HienTai_CoTo=:HienTai_CoTo,
                            HienTai_MatLoi=:HienTai_MatLoi,
                            HienTai_NguoiNongBuc=:HienTai_NguoiNongBuc,
                            HienTai_RoiLoanTieuHoa=:HienTai_RoiLoanTieuHoa,
                            HienTai_Khac=:HienTai_Khac,
                            NgayKham=:NgayKham,
                            CanNang=:CanNang,
                            ToanThan_Tinh=:ToanThan_Tinh,
                            ToanThan_DaNongAm=:ToanThan_DaNongAm,
                            ToanThan_DaNiemMacMatVang=:ToanThan_DaNiemMacMatVang,
                            ToanThan_RunTay=:ToanThan_RunTay,
                            ToanThan_Khac=:ToanThan_Khac,
                            NhipTim=:NhipTim,
                            NhipTim_Deu=:NhipTim_Deu,
                            TiengTim=:TiengTim,
                            HA=:HA,
                            TuyenGiap=:TuyenGiap,
                            MatDo_Mem=:MatDo_Mem,
                            MatDo_Chac=:MatDo_Chac,
                            BuouLanToa=:BuouLanToa,
                            NhanThuyPhai=:NhanThuyPhai,
                            NhanThuyTrai=:NhanThuyTrai,
                            Nhan2Thuy=:Nhan2Thuy,
                            TTTT_ThuyPhai=:TTTT_ThuyPhai,
                            TTTT_ThuyTrai=:TTTT_ThuyTrai,
                            TTTT_KhongCo=:TTTT_KhongCo,
                            TTLT_ThuyPhai=:TTLT_ThuyPhai,
                            TTLT_ThuyTrai=:TTLT_ThuyTrai,
                            TTLT_KhongCo=:TTLT_KhongCo,
                            MatPhaiNOSPECSDo=:MatPhaiNOSPECSDo,
                            MatTraiNOSPECSDo=:MatTraiNOSPECSDo,
                            HoHap=:HoHap,
                            ThanKinh=:ThanKinh,
                            Bung=:Bung,
                            BoPhanKhac=:BoPhanKhac,
                            Ure=:Ure,
                            Glucose=:Glucose,
                            Creatinin=:Creatinin,
                            Cholesterol_TP=:Cholesterol_TP,
                            TG=:TG,
                            HDL_C=:HDL_C,
                            LDL_C=:LDL_C,
                            Acid=:Acid,
                            SGOT=:SGOT,
                            SGPT=:SGPT,
                            Protein=:Protein,
                            Albumin=:Albumin,
                            Na=:Na,
                            K=:K,
                            Cl=:Cl,
                            Ca=:Ca,
                            HC=:HC,
                            Hb=:Hb,
                            HCT=:HCT,
                            BC=:BC,
                            TT=:TT,
                            lympho=:lympho,
                            TC=:TC,
                            T3=:T3,
                            FT3=:FT3,
                            FT4=:FT4,
                            TSH=:TSH,
                            Anti_TPO=:Anti_TPO,
                            TRAb=:TRAb,
                            SieuAmTuyenGiap=:SieuAmTuyenGiap,
                            DoTapTrungI131=:DoTapTrungI131,
                            XaHinhTuyenGiap=:XaHinhTuyenGiap,
                            DienTim=:DienTim,
                            SieuAmDopple=:SieuAmDopple,
                            XQTimPhoi=:XQTimPhoi,
                            ChanDoan_Benh=:ChanDoan_Benh,
                            ChanDoan_BienChung=:ChanDoan_BienChung,
                            ChanDoan_BenhPhoiHop=:ChanDoan_BenhPhoiHop,
                            DieuTri=:DieuTri,
                            LyDoThemThayThuoc=:LyDoThemThayThuoc,
                            HenKhamLaiNgay=:HenKhamLaiNgay,
                            HenXNLaiNgay=:HenXNLaiNgay,
                            BacSyDieuTri=:BacSyDieuTri
                            WHERE MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MetMoi", BenhAnBenhBaseDow.MetMoi));
                Command.Parameters.Add(new MDB.MDBParameter("GaySutCan", BenhAnBenhBaseDow.GaySutCan));
                Command.Parameters.Add(new MDB.MDBParameter("RunChanTay", BenhAnBenhBaseDow.RunChanTay));
                Command.Parameters.Add(new MDB.MDBParameter("CoTo", BenhAnBenhBaseDow.CoTo));
                Command.Parameters.Add(new MDB.MDBParameter("LoiMat", BenhAnBenhBaseDow.LoiMat));
                Command.Parameters.Add(new MDB.MDBParameter("HoiHopTucNguc", BenhAnBenhBaseDow.HoiHopTucNguc));
                Command.Parameters.Add(new MDB.MDBParameter("LyDoKhac", BenhAnBenhBaseDow.LyDoKhac));
                Command.Parameters.Add(new MDB.MDBParameter("HenPheQuan", BenhAnBenhBaseDow.HenPheQuan));
                Command.Parameters.Add(new MDB.MDBParameter("BenhLyDaDay", BenhAnBenhBaseDow.BenhLyDaDay));
                Command.Parameters.Add(new MDB.MDBParameter("KinhNguyet", BenhAnBenhBaseDow.KinhNguyet));
                Command.Parameters.Add(new MDB.MDBParameter("Basedow", BenhAnBenhBaseDow.Basedow));
                Command.Parameters.Add(new MDB.MDBParameter("BuouCo", BenhAnBenhBaseDow.BuouCo));
                Command.Parameters.Add(new MDB.MDBParameter("BenhKhac", BenhAnBenhBaseDow.BenhKhac));
                Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnBenhBaseDow.QuaTrinhBenhLy));
                Command.Parameters.Add(new MDB.MDBParameter("DienBienBenh", BenhAnBenhBaseDow.DienBienBenh));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanBenh_Nam", BenhAnBenhBaseDow.ChanDoanBenh_Nam));
                Command.Parameters.Add(new MDB.MDBParameter("NoiChanDoan", BenhAnBenhBaseDow.NoiChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("BenhSu_DieuTri", BenhAnBenhBaseDow.BenhSu_DieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocDangDieuTri", BenhAnBenhBaseDow.ThuocDangDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriI131", BenhAnBenhBaseDow.DieuTriI131));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriBangPhauThuat", BenhAnBenhBaseDow.DieuTriBangPhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("HienTai_MetMoi", BenhAnBenhBaseDow.HienTai_MetMoi));
                Command.Parameters.Add(new MDB.MDBParameter("HienTai_GaySutCan", BenhAnBenhBaseDow.HienTai_GaySutCan));
                Command.Parameters.Add(new MDB.MDBParameter("HienTai_RunTayChan", BenhAnBenhBaseDow.HienTai_RunTayChan));
                Command.Parameters.Add(new MDB.MDBParameter("HienTai_CoTo", BenhAnBenhBaseDow.HienTai_CoTo));
                Command.Parameters.Add(new MDB.MDBParameter("HienTai_MatLoi", BenhAnBenhBaseDow.HienTai_MatLoi));
                Command.Parameters.Add(new MDB.MDBParameter("HienTai_NguoiNongBuc", BenhAnBenhBaseDow.HienTai_NguoiNongBuc));
                Command.Parameters.Add(new MDB.MDBParameter("HienTai_RoiLoanTieuHoa", BenhAnBenhBaseDow.HienTai_RoiLoanTieuHoa));
                Command.Parameters.Add(new MDB.MDBParameter("HienTai_Khac", BenhAnBenhBaseDow.HienTai_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("NgayKham", BenhAnBenhBaseDow.NgayKham));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang", BenhAnBenhBaseDow.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("ToanThan_Tinh", BenhAnBenhBaseDow.ToanThan_Tinh));
                Command.Parameters.Add(new MDB.MDBParameter("ToanThan_DaNongAm", BenhAnBenhBaseDow.ToanThan_DaNongAm));
                Command.Parameters.Add(new MDB.MDBParameter("ToanThan_DaNiemMacMatVang", BenhAnBenhBaseDow.ToanThan_DaNiemMacMatVang));
                Command.Parameters.Add(new MDB.MDBParameter("ToanThan_RunTay", BenhAnBenhBaseDow.ToanThan_RunTay));
                Command.Parameters.Add(new MDB.MDBParameter("ToanThan_Khac", BenhAnBenhBaseDow.ToanThan_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTim", BenhAnBenhBaseDow.NhipTim));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTim_Deu", BenhAnBenhBaseDow.NhipTim_Deu));
                Command.Parameters.Add(new MDB.MDBParameter("TiengTim", BenhAnBenhBaseDow.TiengTim));
                Command.Parameters.Add(new MDB.MDBParameter("HA", BenhAnBenhBaseDow.HA));
                Command.Parameters.Add(new MDB.MDBParameter("TuyenGiap", BenhAnBenhBaseDow.TuyenGiap));
                Command.Parameters.Add(new MDB.MDBParameter("MatDo_Mem", BenhAnBenhBaseDow.MatDo_Mem));
                Command.Parameters.Add(new MDB.MDBParameter("MatDo_Chac", BenhAnBenhBaseDow.MatDo_Chac));
                Command.Parameters.Add(new MDB.MDBParameter("BuouLanToa", BenhAnBenhBaseDow.BuouLanToa));
                Command.Parameters.Add(new MDB.MDBParameter("NhanThuyPhai", BenhAnBenhBaseDow.NhanThuyPhai));
                Command.Parameters.Add(new MDB.MDBParameter("NhanThuyTrai", BenhAnBenhBaseDow.NhanThuyTrai));
                Command.Parameters.Add(new MDB.MDBParameter("Nhan2Thuy", BenhAnBenhBaseDow.Nhan2Thuy));
                Command.Parameters.Add(new MDB.MDBParameter("TTTT_ThuyPhai", BenhAnBenhBaseDow.TTTT_ThuyPhai));
                Command.Parameters.Add(new MDB.MDBParameter("TTTT_ThuyTrai", BenhAnBenhBaseDow.TTTT_ThuyTrai));
                Command.Parameters.Add(new MDB.MDBParameter("TTTT_KhongCo", BenhAnBenhBaseDow.TTTT_KhongCo));
                Command.Parameters.Add(new MDB.MDBParameter("TTLT_ThuyPhai", BenhAnBenhBaseDow.TTLT_ThuyPhai));
                Command.Parameters.Add(new MDB.MDBParameter("TTLT_ThuyTrai", BenhAnBenhBaseDow.TTLT_ThuyTrai));
                Command.Parameters.Add(new MDB.MDBParameter("TTLT_KhongCo", BenhAnBenhBaseDow.TTLT_KhongCo));
                Command.Parameters.Add(new MDB.MDBParameter("MatPhaiNOSPECSDo", BenhAnBenhBaseDow.MatPhaiNOSPECSDo));
                Command.Parameters.Add(new MDB.MDBParameter("MatTraiNOSPECSDo", BenhAnBenhBaseDow.MatTraiNOSPECSDo));
                Command.Parameters.Add(new MDB.MDBParameter("HoHap", BenhAnBenhBaseDow.HoHap));
                Command.Parameters.Add(new MDB.MDBParameter("ThanKinh", BenhAnBenhBaseDow.ThanKinh));
                Command.Parameters.Add(new MDB.MDBParameter("Bung", BenhAnBenhBaseDow.Bung));
                Command.Parameters.Add(new MDB.MDBParameter("BoPhanKhac", BenhAnBenhBaseDow.BoPhanKhac));
                Command.Parameters.Add(new MDB.MDBParameter("Ure", BenhAnBenhBaseDow.Ure));
                Command.Parameters.Add(new MDB.MDBParameter("Glucose", BenhAnBenhBaseDow.Glucose));
                Command.Parameters.Add(new MDB.MDBParameter("Creatinin", BenhAnBenhBaseDow.Creatinin));
                Command.Parameters.Add(new MDB.MDBParameter("Cholesterol_TP", BenhAnBenhBaseDow.Cholesterol_TP));
                Command.Parameters.Add(new MDB.MDBParameter("TG", BenhAnBenhBaseDow.TG));
                Command.Parameters.Add(new MDB.MDBParameter("HDL_C", BenhAnBenhBaseDow.HDL_C));
                Command.Parameters.Add(new MDB.MDBParameter("LDL_C", BenhAnBenhBaseDow.LDL_C));
                Command.Parameters.Add(new MDB.MDBParameter("Acid", BenhAnBenhBaseDow.Acid));
                Command.Parameters.Add(new MDB.MDBParameter("SGOT", BenhAnBenhBaseDow.SGOT));
                Command.Parameters.Add(new MDB.MDBParameter("SGPT", BenhAnBenhBaseDow.SGPT));
                Command.Parameters.Add(new MDB.MDBParameter("Protein", BenhAnBenhBaseDow.Protein));
                Command.Parameters.Add(new MDB.MDBParameter("Albumin", BenhAnBenhBaseDow.Albumin));
                Command.Parameters.Add(new MDB.MDBParameter("Na", BenhAnBenhBaseDow.Na));
                Command.Parameters.Add(new MDB.MDBParameter("K", BenhAnBenhBaseDow.K));
                Command.Parameters.Add(new MDB.MDBParameter("Cl", BenhAnBenhBaseDow.Cl));
                Command.Parameters.Add(new MDB.MDBParameter("Ca", BenhAnBenhBaseDow.Ca));
                Command.Parameters.Add(new MDB.MDBParameter("HC", BenhAnBenhBaseDow.HC));
                Command.Parameters.Add(new MDB.MDBParameter("Hb", BenhAnBenhBaseDow.Hb));
                Command.Parameters.Add(new MDB.MDBParameter("HCT", BenhAnBenhBaseDow.HCT));
                Command.Parameters.Add(new MDB.MDBParameter("BC", BenhAnBenhBaseDow.BC));
                Command.Parameters.Add(new MDB.MDBParameter("TT", BenhAnBenhBaseDow.TT));
                Command.Parameters.Add(new MDB.MDBParameter("lympho", BenhAnBenhBaseDow.lympho));
                Command.Parameters.Add(new MDB.MDBParameter("TC", BenhAnBenhBaseDow.TC));
                Command.Parameters.Add(new MDB.MDBParameter("T3", BenhAnBenhBaseDow.T3));
                Command.Parameters.Add(new MDB.MDBParameter("FT3", BenhAnBenhBaseDow.FT3));
                Command.Parameters.Add(new MDB.MDBParameter("FT4", BenhAnBenhBaseDow.FT4));
                Command.Parameters.Add(new MDB.MDBParameter("TSH", BenhAnBenhBaseDow.TSH));
                Command.Parameters.Add(new MDB.MDBParameter("Anti_TPO", BenhAnBenhBaseDow.Anti_TPO));
                Command.Parameters.Add(new MDB.MDBParameter("TRAb", BenhAnBenhBaseDow.TRAb));
                Command.Parameters.Add(new MDB.MDBParameter("SieuAmTuyenGiap", BenhAnBenhBaseDow.SieuAmTuyenGiap));
                Command.Parameters.Add(new MDB.MDBParameter("DoTapTrungI131", BenhAnBenhBaseDow.DoTapTrungI131));
                Command.Parameters.Add(new MDB.MDBParameter("XaHinhTuyenGiap", BenhAnBenhBaseDow.XaHinhTuyenGiap));
                Command.Parameters.Add(new MDB.MDBParameter("DienTim", BenhAnBenhBaseDow.DienTim));
                Command.Parameters.Add(new MDB.MDBParameter("SieuAmDopple", BenhAnBenhBaseDow.SieuAmDopple));
                Command.Parameters.Add(new MDB.MDBParameter("XQTimPhoi", BenhAnBenhBaseDow.XQTimPhoi));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan_Benh", BenhAnBenhBaseDow.ChanDoan_Benh));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan_BienChung", BenhAnBenhBaseDow.ChanDoan_BienChung));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan_BenhPhoiHop", BenhAnBenhBaseDow.ChanDoan_BenhPhoiHop));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri", BenhAnBenhBaseDow.DieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("LyDoThemThayThuoc", BenhAnBenhBaseDow.LyDoThemThayThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("HenKhamLaiNgay", BenhAnBenhBaseDow.HenKhamLaiNgay));
                Command.Parameters.Add(new MDB.MDBParameter("HenXNLaiNgay", BenhAnBenhBaseDow.HenXNLaiNgay));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnBenhBaseDow.BacSyDieuTri));

                Command.BindByName = true;

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnBenhBaseDow.MaQuanLy));
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
