using EMR_MAIN.DATABASE.BenhAn;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;

namespace EMR_MAIN.DATABASE.BenhAnFunc
{
    public class BenhAnPhoiTacNghenManTinhFunc
    {
        public static void WriteXml(MDB.MDBConnection MyConnection)
        {
            string sql =
                   @"
                  select  a.*,  CTScanner HoSo_CTScanner, SieuAm HoSo_SieuAm, XetNghiem HoSo_XetNghiem,  Khac HoSo_Khac,  Khac_Text HoSo_Khac_Text,  ToanBoHoSo HoSo_ToanBoHoSo, Mach DauSinhTon_Mach,  NhietDo DauSinhTon_NhietDo,  HuyetAp DauSinhTon_HuyetAp,  NhipTho DauSinhTon_NhipTho,  CanNang DauSinhTon_CanNang  
                  from BenhAnPhoiTacNghenManTinh a inner join thongtindieutri b on a.maquanly = b.maquanly
                  where rownum = 1
                    ";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            var DataTable = new DataTable { TableName = "BenhAnPhoiTacNghenManTinh" };
            DataTable.Load(DataReader as IDataReader);
            DataTable.WriteXml("rptBenhAnPhoiTacNghenManTinh.xml");
        }
        public static DataSet SelectDataSet(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql =
                   @"
                  select  a.*, b.Mach DauSinhTon_Mach,  b.NhietDo DauSinhTon_NhietDo,  b.HuyetAp DauSinhTon_HuyetAp,  b.NhipTho DauSinhTon_NhipTho, b.CanNang DauSinhTon_CanNang   
                        from BenhAnPhoiTacNghenManTinh a  
                  left join thongtindieutri b on a.maquanly = b.maquanly  
                  where a.maquanly = " + MaQuanLy;
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(sql, MyConnection);
            var ds = new DataSet();
            adt.Fill(ds, "Table");
            ObservableCollection<DoPheDung> DoPheDungs = JsonConvert.DeserializeObject<ObservableCollection<DoPheDung>>(ds.Tables[0].Rows[0]["DoPheDungs"].ToString());
            ObservableCollection<DoChucNangHoHap> DoChucNangHoHaps = JsonConvert.DeserializeObject<ObservableCollection<DoChucNangHoHap>>(ds.Tables[0].Rows[0]["DoChucNangHoHaps"].ToString());

            ds.Tables.Add(Common.ListToDataTable(DoPheDungs.ToList(), "DoPheDungs"));
            ds.Tables.Add(Common.ListToDataTable(DoChucNangHoHaps.ToList(), "DoChucNangHoHaps"));

            return ds;
        }
        public static BenhAnPhoiTacNghenManTinh Select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            var obj = new BenhAnPhoiTacNghenManTinh();
            try
            {
                #region
                string sql =
                          @"select * 
                        from BenhAnPhoiTacNghenManTinh 
                        where MaQuanLy = :MaQuanLy";
                #endregion
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    // Phần chung Hành chính
                    obj.MaQuanLy = DataReader.GetDecimal("MaQuanLy");
                    obj.SHS = DataReader["SHS"].ToString();
                    obj.NgayLapHoSo = DataReader["NgayLapHoSo"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayLapHoSo"].ToString()) : null;
                    obj.DienThoaiNhaRieng = DataReader["DienThoaiNhaRieng"].ToString();
                    obj.BacSyPhuTrach = DataReader["BacSyPhuTrach"].ToString();
                    obj.Ho = DataReader.GetInt("Ho");
                    obj.KhoKhe = DataReader.GetInt("KhoKhe");
                    obj.NangNguc = DataReader.GetInt("NangNguc");
                    obj.KhoTho = DataReader.GetInt("KhoTho");
                    obj.KhacDom = DataReader.GetInt("KhacDom");
                    obj.TrieuChungKhac = DataReader.GetInt("TrieuChungKhac");
                    obj.TrieuChungKhac_Text = DataReader["TrieuChungKhac_Text"].ToString();
                    obj.ThoiGianKhoiPhat = DataReader["ThoiGianKhoiPhat"].ToString();
                    obj.BNBietChanDoanCopd = DataReader.GetInt("BNBietChanDoanCopd");
                    obj.BNDuocBSCK = DataReader.GetInt("BNDuocBSCK");
                    obj.BNDuocBSCK_TrongBaoLau = DataReader["BNDuocBSCK_TrongBaoLau"].ToString();
                    obj.SoLanMacTrongNam = DataReader["SoLanMacTrongNam"].ToString();
                    obj.DaNhapVienViCopd = DataReader.GetInt("DaNhapVienViCopd");
                    obj.NhapVienBaoLan = DataReader["NhapVienBaoLan"].ToString();
                    obj.CoThoMay = DataReader["CoThoMay"].ToString();
                    obj.SABA_CoSuDung = DataReader["SABA_CoSuDung"].ToString();
                    obj.SABA_CachDung = DataReader["SABA_CachDung"].ToString();
                    obj.LABA_CoSuDung = DataReader["LABA_CoSuDung"].ToString();
                    obj.LABA_CachDung = DataReader["LABA_CachDung"].ToString();
                    obj.Corticoid_CoSuDung = DataReader["Corticoid_CoSuDung"].ToString();
                    obj.Corticoid_CachDung = DataReader["Corticoid_CachDung"].ToString();
                    obj.Corticoid_LABA_CoSuDung = DataReader["Corticoid_LABA_CoSuDung"].ToString();
                    obj.Corticoid_LABA_CachDung = DataReader["Corticoid_LABA_CachDung"].ToString();
                    obj.Xanthine_CoSuDung = DataReader["Xanthine_CoSuDung"].ToString();
                    obj.Xanthine_CachDung = DataReader["Xanthine_CachDung"].ToString();
                    obj.Khac_CoSuDung = DataReader["Khac_CoSuDung"].ToString();
                    obj.Khac_CachDung = DataReader["Khac_CachDung"].ToString();
                    obj.YeuToLienQuanDenDotCap = DataReader.GetInt("YeuToLienQuanDenDotCap");
                    obj.ThayDoiThoiTiet_Co = DataReader["ThayDoiThoiTiet_Co"].ToString();
                    obj.ThayDoiThoiTiet_Khong = DataReader["ThayDoiThoiTiet_Khong"].ToString();
                    obj.KhongTuanThuDieuTri_Co = DataReader["KhongTuanThuDieuTri_Co"].ToString();
                    obj.KhongTuanThuDieuTri_Khong = DataReader["KhongTuanThuDieuTri_Khong"].ToString();
                    obj.ViemHoHap_Co = DataReader["ViemHoHap_Co"].ToString();
                    obj.ViemHoHap_Khong = DataReader["ViemHoHap_Khong"].ToString();
                    obj.BenhPhoiHop_Co = DataReader["BenhPhoiHop_Co"].ToString();
                    obj.BenhPhoiHop_Khong = DataReader["BenhPhoiHop_Khong"].ToString();
                    obj.KhoiThuoc_Co = DataReader["KhoiThuoc_Co"].ToString();
                    obj.KhoiThuoc_Khong = DataReader["KhoiThuoc_Khong"].ToString();
                    obj.Bui_Co = DataReader["Bui_Co"].ToString();
                    obj.Bui_Khong = DataReader["Bui_Khong"].ToString();
                    obj.HoaChat_Co = DataReader["HoaChat_Co"].ToString();
                    obj.HoaChat_Khong = DataReader["HoaChat_Khong"].ToString();
                    obj.Thuoc_Co = DataReader["Thuoc_Co"].ToString();
                    obj.Thuoc_Khong = DataReader["Thuoc_Khong"].ToString();
                    obj.ThucAn_Co = DataReader["ThucAn_Co"].ToString();
                    obj.ThucAn_Khong = DataReader["ThucAn_Khong"].ToString();
                    obj.GangSuc_Co = DataReader["GangSuc_Co"].ToString();
                    obj.GangSuc_Khong = DataReader["GangSuc_Khong"].ToString();
                    obj.Khac_Co = DataReader["Khac_Co"].ToString();
                    obj.Khac_Khong = DataReader["Khac_Khong"].ToString();
                    obj.TrieuChungBenh_Ho = DataReader.GetInt("TrieuChungBenh_Ho");
                    obj.TrieuChungBenh_KhacDom = DataReader.GetInt("TrieuChungBenh_KhacDom");
                    obj.TrieuChungBenh_DomMau = DataReader["TrieuChungBenh_DomMau"].ToString();
                    obj.TrieuChungBenh_KhoKhe = DataReader.GetInt("TrieuChungBenh_KhoKhe");
                    obj.TrieuChungBenh_KhoTho = DataReader.GetInt("TrieuChungBenh_KhoTho");
                    obj.TrieuChungBenh_NangNguc = DataReader.GetInt("TrieuChungBenh_NangNguc");
                    obj.MucDoKhoTho = DataReader.GetInt("MucDoKhoTho");
                    obj.HutThuoc = DataReader.GetInt("HutThuoc");
                    obj.HutThuocThuDong_Nam = DataReader["HutThuocThuDong_Nam"].ToString();
                    obj.HutThuocBaoTrenNam = DataReader["HutThuocBaoTrenNam"].ToString();
                    obj.HutThuoc_GhiChu = DataReader["HutThuoc_GhiChu"].ToString();
                    obj.ViemMuiDiUng_Co = DataReader["ViemMuiDiUng_Co"].ToString();
                    obj.ViemMuiDiUng_Khong = DataReader["ViemMuiDiUng_Khong"].ToString();
                    obj.MeDay_Co = DataReader["MeDay_Co"].ToString();
                    obj.MeDay_Khong = DataReader["MeDay_Khong"].ToString();
                    obj.Cham_Co = DataReader["Cham_Co"].ToString();
                    obj.Cham_Khong = DataReader["Cham_Khong"].ToString();
                    obj.CoDiaDiUng_Khac_Co = DataReader["CoDiaDiUng_Khac_Co"].ToString();
                    obj.CoDiaDiUng_Khac_Khong = DataReader["CoDiaDiUng_Khac_Khong"].ToString();
                    obj.DiNguyen = DataReader["DiNguyen"].ToString();
                    obj.BenhDongMachVanh = DataReader.GetInt("BenhDongMachVanh");
                    obj.NhoiMauCoTim = DataReader.GetInt("NhoiMauCoTim");
                    obj.LoanNhipTim = DataReader.GetInt("LoanNhipTim");
                    obj.XuyTimXungHuyet = DataReader.GetInt("XuyTimXungHuyet");
                    obj.TangHuyetAp = DataReader.GetInt("TangHuyetAp");
                    obj.TaiBienMachMaoNao = DataReader.GetInt("TaiBienMachMaoNao");
                    obj.HoiChungCushing = DataReader.GetInt("HoiChungCushing");
                    obj.SuyThuongThan = DataReader.GetInt("SuyThuongThan");
                    obj.CuomMat = DataReader.GetInt("CuomMat");
                    obj.TangNhanAp = DataReader.GetInt("TangNhanAp");
                    obj.TangCholesteronMau = DataReader.GetInt("TangCholesteronMau");
                    obj.DaiThaoDuong = DataReader.GetInt("DaiThaoDuong");
                    obj.LoangXuong = DataReader.GetInt("LoangXuong");
                    obj.ViemPhoi = DataReader.GetInt("ViemPhoi");
                    obj.GiaDinh_KhongCoBenh = DataReader.GetInt("GiaDinh_KhongCoBenh");
                    obj.GiaDinh_Hen = DataReader.GetInt("GiaDinh_Hen");
                    obj.GiaDinh_ViemMuiDiUng = DataReader.GetInt("GiaDinh_ViemMuiDiUng");
                    obj.GiaDinh_MeDay = DataReader.GetInt("GiaDinh_MeDay");
                    obj.GiaDinh_Cham = DataReader.GetInt("GiaDinh_Cham");
                    obj.GiaDinh_Khac = DataReader.GetInt("GiaDinh_Khac");
                    obj.GiaDinh_Khac_CuThe = DataReader["GiaDinh_Khac_CuThe"].ToString();
                    obj.AiMacBenh = DataReader["AiMacBenh"].ToString();
                    obj.Phoi_BinhThuong = DataReader.GetInt("Phoi_BinhThuong");
                    obj.Phoi_RRFNGiam = DataReader.GetInt("Phoi_RRFNGiam");
                    obj.Phoi_RanRitRanNgay = DataReader.GetInt("Phoi_RanRitRanNgay");
                    obj.Phoi_RanNoAm = DataReader.GetInt("Phoi_RanNoAm");
                    obj.Phoi_Khac = DataReader.GetInt("Phoi_Khac");
                    obj.Phoi_Khac_CuThe = DataReader["Phoi_Khac_CuThe"].ToString();
                    obj.CoQuanKhac = DataReader["CoQuanKhac"].ToString();
                    obj.DoPheDungs = JsonConvert.DeserializeObject<ObservableCollection<DoPheDung>>(DataReader["DoPheDungs"].ToString());
                    obj.DoChucNangHoHaps = JsonConvert.DeserializeObject<ObservableCollection<DoChucNangHoHap>>(DataReader["DoChucNangHoHaps"].ToString());
                    obj.XQuangPhoi = DataReader["XQuangPhoi"].ToString();
                    obj.DTD_SAT = DataReader["DTD_SAT"].ToString();
                    obj.XetNghiemKhac = DataReader["XetNghiemKhac"].ToString();
                    obj.ChanDoan_COPD_1 = DataReader.GetInt("ChanDoan_COPD_1");
                    obj.ChanDoan_COPD_2 = DataReader.GetInt("ChanDoan_COPD_2");
                    obj.ChanDoan_COPD_3 = DataReader.GetInt("ChanDoan_COPD_3");
                    obj.ChanDoan_COPD_4 = DataReader.GetInt("ChanDoan_COPD_4");
                    obj.BenhPhoiHop = DataReader["BenhPhoiHop"].ToString();
                    obj.DieuTri = DataReader["DieuTri"].ToString();

                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return obj;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, BenhAnPhoiTacNghenManTinh BenhAnPhoiTacNghenManTinh)
        {
            try
            {
                string sql =
                          @"select MaQuanLy 
                            from BenhAnPhoiTacNghenManTinh
                            where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnPhoiTacNghenManTinh.MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                int rowCount = 0;
                while (DataReader.Read()) rowCount++;
                if (rowCount == 1) return Update(MyConnection, BenhAnPhoiTacNghenManTinh);
                sql = @"
                       INSERT INTO BenhAnPhoiTacNghenManTinh 
                        (
                            MaQuanLy,
                            SHS,
                            NgayLapHoSo,
                            DienThoaiNhaRieng,
                            BacSyPhuTrach,
                            Ho,
                            KhoKhe,
                            NangNguc,
                            KhoTho,
                            KhacDom,
                            TrieuChungKhac,
                            TrieuChungKhac_Text,
                            ThoiGianKhoiPhat,
                            BNBietChanDoanCopd,
                            BNDuocBSCK,
                            BNDuocBSCK_TrongBaoLau,
                            SoLanMacTrongNam,
                            DaNhapVienViCopd,
                            NhapVienBaoLan,
                            CoThoMay,
                            SABA_CoSuDung,
                            SABA_CachDung,
                            LABA_CoSuDung,
                            LABA_CachDung,
                            Corticoid_CoSuDung,
                            Corticoid_CachDung,
                            Corticoid_LABA_CoSuDung,
                            Corticoid_LABA_CachDung,
                            Xanthine_CoSuDung,
                            Xanthine_CachDung,
                            Khac_CoSuDung,
                            Khac_CachDung,
                            YeuToLienQuanDenDotCap,
                            ThayDoiThoiTiet_Co,
                            ThayDoiThoiTiet_Khong,
                            KhongTuanThuDieuTri_Co,
                            KhongTuanThuDieuTri_Khong,
                            ViemHoHap_Co,
                            ViemHoHap_Khong,
                            BenhPhoiHop_Co,
                            BenhPhoiHop_Khong,
                            KhoiThuoc_Co,
                            KhoiThuoc_Khong,
                            Bui_Co,
                            Bui_Khong,
                            HoaChat_Co,
                            HoaChat_Khong,
                            Thuoc_Co,
                            Thuoc_Khong,
                            ThucAn_Co,
                            ThucAn_Khong,
                            GangSuc_Co,
                            GangSuc_Khong,
                            Khac_Co,
                            Khac_Khong,
                            TrieuChungBenh_Ho,
                            TrieuChungBenh_KhacDom,
                            TrieuChungBenh_DomMau,
                            TrieuChungBenh_KhoKhe,
                            TrieuChungBenh_KhoTho,
                            TrieuChungBenh_NangNguc,
                            MucDoKhoTho,
                            HutThuoc,
                            HutThuocThuDong_Nam,
                            HutThuocBaoTrenNam,
                            HutThuoc_GhiChu,
                            ViemMuiDiUng_Co,
                            ViemMuiDiUng_Khong,
                            MeDay_Co,
                            MeDay_Khong,
                            Cham_Co,
                            Cham_Khong,
                            CoDiaDiUng_Khac_Co,
                            CoDiaDiUng_Khac_Khong,
                            DiNguyen,
                            BenhDongMachVanh,
                            NhoiMauCoTim,
                            LoanNhipTim,
                            XuyTimXungHuyet,
                            TangHuyetAp,
                            TaiBienMachMaoNao,
                            HoiChungCushing,
                            SuyThuongThan,
                            CuomMat,
                            TangNhanAp,
                            TangCholesteronMau,
                            DaiThaoDuong,
                            LoangXuong,
                            ViemPhoi,
                            GiaDinh_KhongCoBenh,
                            GiaDinh_Hen,
                            GiaDinh_ViemMuiDiUng,
                            GiaDinh_MeDay,
                            GiaDinh_Cham,
                            GiaDinh_Khac,
                            GiaDinh_Khac_CuThe,
                            AiMacBenh,
                            Phoi_BinhThuong,
                            Phoi_RRFNGiam,
                            Phoi_RanRitRanNgay,
                            Phoi_RanNoAm,
                            Phoi_Khac,
                            Phoi_Khac_CuThe,
                            CoQuanKhac,
                            DoPheDungs,
                            DoChucNangHoHaps,
                            XQuangPhoi,
                            DTD_SAT,
                            XetNghiemKhac,
                            ChanDoan_COPD_1,
                            ChanDoan_COPD_2,
                            ChanDoan_COPD_3,
                            ChanDoan_COPD_4,
                            BenhPhoiHop,
                            DieuTri
                        )                 
                        VALUES
                        (
                            :MaQuanLy,
                            :SHS,
                            :NgayLapHoSo,
                            :DienThoaiNhaRieng,
                            :BacSyPhuTrach,
                            :Ho,
                            :KhoKhe,
                            :NangNguc,
                            :KhoTho,
                            :KhacDom,
                            :TrieuChungKhac,
                            :TrieuChungKhac_Text,
                            :ThoiGianKhoiPhat,
                            :BNBietChanDoanCopd,
                            :BNDuocBSCK,
                            :BNDuocBSCK_TrongBaoLau,
                            :SoLanMacTrongNam,
                            :DaNhapVienViCopd,
                            :NhapVienBaoLan,
                            :CoThoMay,
                            :SABA_CoSuDung,
                            :SABA_CachDung,
                            :LABA_CoSuDung,
                            :LABA_CachDung,
                            :Corticoid_CoSuDung,
                            :Corticoid_CachDung,
                            :Corticoid_LABA_CoSuDung,
                            :Corticoid_LABA_CachDung,
                            :Xanthine_CoSuDung,
                            :Xanthine_CachDung,
                            :Khac_CoSuDung,
                            :Khac_CachDung,
                            :YeuToLienQuanDenDotCap,
                            :ThayDoiThoiTiet_Co,
                            :ThayDoiThoiTiet_Khong,
                            :KhongTuanThuDieuTri_Co,
                            :KhongTuanThuDieuTri_Khong,
                            :ViemHoHap_Co,
                            :ViemHoHap_Khong,
                            :BenhPhoiHop_Co,
                            :BenhPhoiHop_Khong,
                            :KhoiThuoc_Co,
                            :KhoiThuoc_Khong,
                            :Bui_Co,
                            :Bui_Khong,
                            :HoaChat_Co,
                            :HoaChat_Khong,
                            :Thuoc_Co,
                            :Thuoc_Khong,
                            :ThucAn_Co,
                            :ThucAn_Khong,
                            :GangSuc_Co,
                            :GangSuc_Khong,
                            :Khac_Co,
                            :Khac_Khong,
                            :TrieuChungBenh_Ho,
                            :TrieuChungBenh_KhacDom,
                            :TrieuChungBenh_DomMau,
                            :TrieuChungBenh_KhoKhe,
                            :TrieuChungBenh_KhoTho,
                            :TrieuChungBenh_NangNguc,
                            :MucDoKhoTho,
                            :HutThuoc,
                            :HutThuocThuDong_Nam,
                            :HutThuocBaoTrenNam,
                            :HutThuoc_GhiChu,
                            :ViemMuiDiUng_Co,
                            :ViemMuiDiUng_Khong,
                            :MeDay_Co,
                            :MeDay_Khong,
                            :Cham_Co,
                            :Cham_Khong,
                            :CoDiaDiUng_Khac_Co,
                            :CoDiaDiUng_Khac_Khong,
                            :DiNguyen,
                            :BenhDongMachVanh,
                            :NhoiMauCoTim,
                            :LoanNhipTim,
                            :XuyTimXungHuyet,
                            :TangHuyetAp,
                            :TaiBienMachMaoNao,
                            :HoiChungCushing,
                            :SuyThuongThan,
                            :CuomMat,
                            :TangNhanAp,
                            :TangCholesteronMau,
                            :DaiThaoDuong,
                            :LoangXuong,
                            :ViemPhoi,
                            :GiaDinh_KhongCoBenh,
                            :GiaDinh_Hen,
                            :GiaDinh_ViemMuiDiUng,
                            :GiaDinh_MeDay,
                            :GiaDinh_Cham,
                            :GiaDinh_Khac,
                            :GiaDinh_Khac_CuThe,
                            :AiMacBenh,
                            :Phoi_BinhThuong,
                            :Phoi_RRFNGiam,
                            :Phoi_RanRitRanNgay,
                            :Phoi_RanNoAm,
                            :Phoi_Khac,
                            :Phoi_Khac_CuThe,
                            :CoQuanKhac,
                            :DoPheDungs,
                            :DoChucNangHoHaps,
                            :XQuangPhoi,
                            :DTD_SAT,
                            :XetNghiemKhac,
                            :ChanDoan_COPD_1,
                            :ChanDoan_COPD_2,
                            :ChanDoan_COPD_3,
                            :ChanDoan_COPD_4,
                            :BenhPhoiHop,
                            :DieuTri
                        )";
                Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnPhoiTacNghenManTinh.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("SHS", BenhAnPhoiTacNghenManTinh.SHS));
                Command.Parameters.Add(new MDB.MDBParameter("NgayLapHoSo", BenhAnPhoiTacNghenManTinh.NgayLapHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("DienThoaiNhaRieng", BenhAnPhoiTacNghenManTinh.DienThoaiNhaRieng));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyPhuTrach", BenhAnPhoiTacNghenManTinh.BacSyPhuTrach));
                Command.Parameters.Add(new MDB.MDBParameter("Ho", BenhAnPhoiTacNghenManTinh.Ho));
                Command.Parameters.Add(new MDB.MDBParameter("KhoKhe", BenhAnPhoiTacNghenManTinh.KhoKhe));
                Command.Parameters.Add(new MDB.MDBParameter("NangNguc", BenhAnPhoiTacNghenManTinh.NangNguc));
                Command.Parameters.Add(new MDB.MDBParameter("KhoTho", BenhAnPhoiTacNghenManTinh.KhoTho));
                Command.Parameters.Add(new MDB.MDBParameter("KhacDom", BenhAnPhoiTacNghenManTinh.KhacDom));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungKhac", BenhAnPhoiTacNghenManTinh.TrieuChungKhac));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungKhac_Text", BenhAnPhoiTacNghenManTinh.TrieuChungKhac_Text));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianKhoiPhat", BenhAnPhoiTacNghenManTinh.ThoiGianKhoiPhat));
                Command.Parameters.Add(new MDB.MDBParameter("BNBietChanDoanCopd", BenhAnPhoiTacNghenManTinh.BNBietChanDoanCopd));
                Command.Parameters.Add(new MDB.MDBParameter("BNDuocBSCK", BenhAnPhoiTacNghenManTinh.BNDuocBSCK));
                Command.Parameters.Add(new MDB.MDBParameter("BNDuocBSCK_TrongBaoLau", BenhAnPhoiTacNghenManTinh.BNDuocBSCK_TrongBaoLau));
                Command.Parameters.Add(new MDB.MDBParameter("SoLanMacTrongNam", BenhAnPhoiTacNghenManTinh.SoLanMacTrongNam));
                Command.Parameters.Add(new MDB.MDBParameter("DaNhapVienViCopd", BenhAnPhoiTacNghenManTinh.DaNhapVienViCopd));
                Command.Parameters.Add(new MDB.MDBParameter("NhapVienBaoLan", BenhAnPhoiTacNghenManTinh.NhapVienBaoLan));
                Command.Parameters.Add(new MDB.MDBParameter("CoThoMay", BenhAnPhoiTacNghenManTinh.CoThoMay));
                Command.Parameters.Add(new MDB.MDBParameter("SABA_CoSuDung", BenhAnPhoiTacNghenManTinh.SABA_CoSuDung));
                Command.Parameters.Add(new MDB.MDBParameter("SABA_CachDung", BenhAnPhoiTacNghenManTinh.SABA_CachDung));
                Command.Parameters.Add(new MDB.MDBParameter("LABA_CoSuDung", BenhAnPhoiTacNghenManTinh.LABA_CoSuDung));
                Command.Parameters.Add(new MDB.MDBParameter("LABA_CachDung", BenhAnPhoiTacNghenManTinh.LABA_CachDung));
                Command.Parameters.Add(new MDB.MDBParameter("Corticoid_CoSuDung", BenhAnPhoiTacNghenManTinh.Corticoid_CoSuDung));
                Command.Parameters.Add(new MDB.MDBParameter("Corticoid_CachDung", BenhAnPhoiTacNghenManTinh.Corticoid_CachDung));
                Command.Parameters.Add(new MDB.MDBParameter("Corticoid_LABA_CoSuDung", BenhAnPhoiTacNghenManTinh.Corticoid_LABA_CoSuDung));
                Command.Parameters.Add(new MDB.MDBParameter("Corticoid_LABA_CachDung", BenhAnPhoiTacNghenManTinh.Corticoid_LABA_CachDung));
                Command.Parameters.Add(new MDB.MDBParameter("Xanthine_CoSuDung", BenhAnPhoiTacNghenManTinh.Xanthine_CoSuDung));
                Command.Parameters.Add(new MDB.MDBParameter("Xanthine_CachDung", BenhAnPhoiTacNghenManTinh.Xanthine_CachDung));
                Command.Parameters.Add(new MDB.MDBParameter("Khac_CoSuDung", BenhAnPhoiTacNghenManTinh.Khac_CoSuDung));
                Command.Parameters.Add(new MDB.MDBParameter("Khac_CachDung", BenhAnPhoiTacNghenManTinh.Khac_CachDung));
                Command.Parameters.Add(new MDB.MDBParameter("YeuToLienQuanDenDotCap", BenhAnPhoiTacNghenManTinh.YeuToLienQuanDenDotCap));
                Command.Parameters.Add(new MDB.MDBParameter("ThayDoiThoiTiet_Co", BenhAnPhoiTacNghenManTinh.ThayDoiThoiTiet_Co));
                Command.Parameters.Add(new MDB.MDBParameter("ThayDoiThoiTiet_Khong", BenhAnPhoiTacNghenManTinh.ThayDoiThoiTiet_Khong));
                Command.Parameters.Add(new MDB.MDBParameter("KhongTuanThuDieuTri_Co", BenhAnPhoiTacNghenManTinh.KhongTuanThuDieuTri_Co));
                Command.Parameters.Add(new MDB.MDBParameter("KhongTuanThuDieuTri_Khong", BenhAnPhoiTacNghenManTinh.KhongTuanThuDieuTri_Khong));
                Command.Parameters.Add(new MDB.MDBParameter("ViemHoHap_Co", BenhAnPhoiTacNghenManTinh.ViemHoHap_Co));
                Command.Parameters.Add(new MDB.MDBParameter("ViemHoHap_Khong", BenhAnPhoiTacNghenManTinh.ViemHoHap_Khong));
                Command.Parameters.Add(new MDB.MDBParameter("BenhPhoiHop_Co", BenhAnPhoiTacNghenManTinh.BenhPhoiHop_Co));
                Command.Parameters.Add(new MDB.MDBParameter("BenhPhoiHop_Khong", BenhAnPhoiTacNghenManTinh.BenhPhoiHop_Khong));
                Command.Parameters.Add(new MDB.MDBParameter("KhoiThuoc_Co", BenhAnPhoiTacNghenManTinh.KhoiThuoc_Co));
                Command.Parameters.Add(new MDB.MDBParameter("KhoiThuoc_Khong", BenhAnPhoiTacNghenManTinh.KhoiThuoc_Khong));
                Command.Parameters.Add(new MDB.MDBParameter("Bui_Co", BenhAnPhoiTacNghenManTinh.Bui_Co));
                Command.Parameters.Add(new MDB.MDBParameter("Bui_Khong", BenhAnPhoiTacNghenManTinh.Bui_Khong));
                Command.Parameters.Add(new MDB.MDBParameter("HoaChat_Co", BenhAnPhoiTacNghenManTinh.HoaChat_Co));
                Command.Parameters.Add(new MDB.MDBParameter("HoaChat_Khong", BenhAnPhoiTacNghenManTinh.HoaChat_Khong));
                Command.Parameters.Add(new MDB.MDBParameter("Thuoc_Co", BenhAnPhoiTacNghenManTinh.Thuoc_Co));
                Command.Parameters.Add(new MDB.MDBParameter("Thuoc_Khong", BenhAnPhoiTacNghenManTinh.Thuoc_Khong));
                Command.Parameters.Add(new MDB.MDBParameter("ThucAn_Co", BenhAnPhoiTacNghenManTinh.ThucAn_Co));
                Command.Parameters.Add(new MDB.MDBParameter("ThucAn_Khong", BenhAnPhoiTacNghenManTinh.ThucAn_Khong));
                Command.Parameters.Add(new MDB.MDBParameter("GangSuc_Co", BenhAnPhoiTacNghenManTinh.GangSuc_Co));
                Command.Parameters.Add(new MDB.MDBParameter("GangSuc_Khong", BenhAnPhoiTacNghenManTinh.GangSuc_Khong));
                Command.Parameters.Add(new MDB.MDBParameter("Khac_Co", BenhAnPhoiTacNghenManTinh.Khac_Co));
                Command.Parameters.Add(new MDB.MDBParameter("Khac_Khong", BenhAnPhoiTacNghenManTinh.Khac_Khong));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungBenh_Ho", BenhAnPhoiTacNghenManTinh.TrieuChungBenh_Ho));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungBenh_KhacDom", BenhAnPhoiTacNghenManTinh.TrieuChungBenh_KhacDom));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungBenh_DomMau", BenhAnPhoiTacNghenManTinh.TrieuChungBenh_DomMau));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungBenh_KhoKhe", BenhAnPhoiTacNghenManTinh.TrieuChungBenh_KhoKhe));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungBenh_KhoTho", BenhAnPhoiTacNghenManTinh.TrieuChungBenh_KhoTho));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungBenh_NangNguc", BenhAnPhoiTacNghenManTinh.TrieuChungBenh_NangNguc));
                Command.Parameters.Add(new MDB.MDBParameter("MucDoKhoTho", BenhAnPhoiTacNghenManTinh.MucDoKhoTho));
                Command.Parameters.Add(new MDB.MDBParameter("HutThuoc", BenhAnPhoiTacNghenManTinh.HutThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("HutThuocThuDong_Nam", BenhAnPhoiTacNghenManTinh.HutThuocThuDong_Nam));
                Command.Parameters.Add(new MDB.MDBParameter("HutThuocBaoTrenNam", BenhAnPhoiTacNghenManTinh.HutThuocBaoTrenNam));
                Command.Parameters.Add(new MDB.MDBParameter("HutThuoc_GhiChu", BenhAnPhoiTacNghenManTinh.HutThuoc_GhiChu));
                Command.Parameters.Add(new MDB.MDBParameter("ViemMuiDiUng_Co", BenhAnPhoiTacNghenManTinh.ViemMuiDiUng_Co));
                Command.Parameters.Add(new MDB.MDBParameter("ViemMuiDiUng_Khong", BenhAnPhoiTacNghenManTinh.ViemMuiDiUng_Khong));
                Command.Parameters.Add(new MDB.MDBParameter("MeDay_Co", BenhAnPhoiTacNghenManTinh.MeDay_Co));
                Command.Parameters.Add(new MDB.MDBParameter("MeDay_Khong", BenhAnPhoiTacNghenManTinh.MeDay_Khong));
                Command.Parameters.Add(new MDB.MDBParameter("Cham_Co", BenhAnPhoiTacNghenManTinh.Cham_Co));
                Command.Parameters.Add(new MDB.MDBParameter("Cham_Khong", BenhAnPhoiTacNghenManTinh.Cham_Khong));
                Command.Parameters.Add(new MDB.MDBParameter("CoDiaDiUng_Khac_Co", BenhAnPhoiTacNghenManTinh.CoDiaDiUng_Khac_Co));
                Command.Parameters.Add(new MDB.MDBParameter("CoDiaDiUng_Khac_Khong", BenhAnPhoiTacNghenManTinh.CoDiaDiUng_Khac_Khong));
                Command.Parameters.Add(new MDB.MDBParameter("DiNguyen", BenhAnPhoiTacNghenManTinh.DiNguyen));
                Command.Parameters.Add(new MDB.MDBParameter("BenhDongMachVanh", BenhAnPhoiTacNghenManTinh.BenhDongMachVanh));
                Command.Parameters.Add(new MDB.MDBParameter("NhoiMauCoTim", BenhAnPhoiTacNghenManTinh.NhoiMauCoTim));
                Command.Parameters.Add(new MDB.MDBParameter("LoanNhipTim", BenhAnPhoiTacNghenManTinh.LoanNhipTim));
                Command.Parameters.Add(new MDB.MDBParameter("XuyTimXungHuyet", BenhAnPhoiTacNghenManTinh.XuyTimXungHuyet));
                Command.Parameters.Add(new MDB.MDBParameter("TangHuyetAp", BenhAnPhoiTacNghenManTinh.TangHuyetAp));
                Command.Parameters.Add(new MDB.MDBParameter("TaiBienMachMaoNao", BenhAnPhoiTacNghenManTinh.TaiBienMachMaoNao));
                Command.Parameters.Add(new MDB.MDBParameter("HoiChungCushing", BenhAnPhoiTacNghenManTinh.HoiChungCushing));
                Command.Parameters.Add(new MDB.MDBParameter("SuyThuongThan", BenhAnPhoiTacNghenManTinh.SuyThuongThan));
                Command.Parameters.Add(new MDB.MDBParameter("CuomMat", BenhAnPhoiTacNghenManTinh.CuomMat));
                Command.Parameters.Add(new MDB.MDBParameter("TangNhanAp", BenhAnPhoiTacNghenManTinh.TangNhanAp));
                Command.Parameters.Add(new MDB.MDBParameter("TangCholesteronMau", BenhAnPhoiTacNghenManTinh.TangCholesteronMau));
                Command.Parameters.Add(new MDB.MDBParameter("DaiThaoDuong", BenhAnPhoiTacNghenManTinh.DaiThaoDuong));
                Command.Parameters.Add(new MDB.MDBParameter("LoangXuong", BenhAnPhoiTacNghenManTinh.LoangXuong));
                Command.Parameters.Add(new MDB.MDBParameter("ViemPhoi", BenhAnPhoiTacNghenManTinh.ViemPhoi));
                Command.Parameters.Add(new MDB.MDBParameter("GiaDinh_KhongCoBenh", BenhAnPhoiTacNghenManTinh.GiaDinh_KhongCoBenh));
                Command.Parameters.Add(new MDB.MDBParameter("GiaDinh_Hen", BenhAnPhoiTacNghenManTinh.GiaDinh_Hen));
                Command.Parameters.Add(new MDB.MDBParameter("GiaDinh_ViemMuiDiUng", BenhAnPhoiTacNghenManTinh.GiaDinh_ViemMuiDiUng));
                Command.Parameters.Add(new MDB.MDBParameter("GiaDinh_MeDay", BenhAnPhoiTacNghenManTinh.GiaDinh_MeDay));
                Command.Parameters.Add(new MDB.MDBParameter("GiaDinh_Cham", BenhAnPhoiTacNghenManTinh.GiaDinh_Cham));
                Command.Parameters.Add(new MDB.MDBParameter("GiaDinh_Khac", BenhAnPhoiTacNghenManTinh.GiaDinh_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("GiaDinh_Khac_CuThe", BenhAnPhoiTacNghenManTinh.GiaDinh_Khac_CuThe));
                Command.Parameters.Add(new MDB.MDBParameter("AiMacBenh", BenhAnPhoiTacNghenManTinh.AiMacBenh));
                Command.Parameters.Add(new MDB.MDBParameter("Phoi_BinhThuong", BenhAnPhoiTacNghenManTinh.Phoi_BinhThuong));
                Command.Parameters.Add(new MDB.MDBParameter("Phoi_RRFNGiam", BenhAnPhoiTacNghenManTinh.Phoi_RRFNGiam));
                Command.Parameters.Add(new MDB.MDBParameter("Phoi_RanRitRanNgay", BenhAnPhoiTacNghenManTinh.Phoi_RanRitRanNgay));
                Command.Parameters.Add(new MDB.MDBParameter("Phoi_RanNoAm", BenhAnPhoiTacNghenManTinh.Phoi_RanNoAm));
                Command.Parameters.Add(new MDB.MDBParameter("Phoi_Khac", BenhAnPhoiTacNghenManTinh.Phoi_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("Phoi_Khac_CuThe", BenhAnPhoiTacNghenManTinh.Phoi_Khac_CuThe));
                Command.Parameters.Add(new MDB.MDBParameter("CoQuanKhac", BenhAnPhoiTacNghenManTinh.CoQuanKhac));
                Command.Parameters.Add(new MDB.MDBParameter("DoPheDungs", JsonConvert.SerializeObject(BenhAnPhoiTacNghenManTinh.DoPheDungs)));
                Command.Parameters.Add(new MDB.MDBParameter("DoChucNangHoHaps", JsonConvert.SerializeObject(BenhAnPhoiTacNghenManTinh.DoChucNangHoHaps)));
                Command.Parameters.Add(new MDB.MDBParameter("XQuangPhoi", BenhAnPhoiTacNghenManTinh.XQuangPhoi));
                Command.Parameters.Add(new MDB.MDBParameter("DTD_SAT", BenhAnPhoiTacNghenManTinh.DTD_SAT));
                Command.Parameters.Add(new MDB.MDBParameter("XetNghiemKhac", BenhAnPhoiTacNghenManTinh.XetNghiemKhac));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan_COPD_1", BenhAnPhoiTacNghenManTinh.ChanDoan_COPD_1));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan_COPD_2", BenhAnPhoiTacNghenManTinh.ChanDoan_COPD_2));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan_COPD_3", BenhAnPhoiTacNghenManTinh.ChanDoan_COPD_3));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan_COPD_4", BenhAnPhoiTacNghenManTinh.ChanDoan_COPD_4));
                Command.Parameters.Add(new MDB.MDBParameter("BenhPhoiHop", BenhAnPhoiTacNghenManTinh.BenhPhoiHop));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri", BenhAnPhoiTacNghenManTinh.DieuTri));



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
        public static bool Update(MDB.MDBConnection MyConnection, BenhAnPhoiTacNghenManTinh BenhAnPhoiTacNghenManTinh)
        {
            try
            {
                string sql = @"UPDATE BenhAnPhoiTacNghenManTinh SET 
                            SHS=:SHS,
                            NgayLapHoSo=:NgayLapHoSo,
                            DienThoaiNhaRieng=:DienThoaiNhaRieng,
                            BacSyPhuTrach=:BacSyPhuTrach,
                            Ho=:Ho,
                            KhoKhe=:KhoKhe,
                            NangNguc=:NangNguc,
                            KhoTho=:KhoTho,
                            KhacDom=:KhacDom,
                            TrieuChungKhac=:TrieuChungKhac,
                            TrieuChungKhac_Text=:TrieuChungKhac_Text,
                            ThoiGianKhoiPhat=:ThoiGianKhoiPhat,
                            BNBietChanDoanCopd=:BNBietChanDoanCopd,
                            BNDuocBSCK=:BNDuocBSCK,
                            BNDuocBSCK_TrongBaoLau=:BNDuocBSCK_TrongBaoLau,
                            SoLanMacTrongNam=:SoLanMacTrongNam,
                            DaNhapVienViCopd=:DaNhapVienViCopd,
                            NhapVienBaoLan=:NhapVienBaoLan,
                            CoThoMay=:CoThoMay,
                            SABA_CoSuDung=:SABA_CoSuDung,
                            SABA_CachDung=:SABA_CachDung,
                            LABA_CoSuDung=:LABA_CoSuDung,
                            LABA_CachDung=:LABA_CachDung,
                            Corticoid_CoSuDung=:Corticoid_CoSuDung,
                            Corticoid_CachDung=:Corticoid_CachDung,
                            Corticoid_LABA_CoSuDung=:Corticoid_LABA_CoSuDung,
                            Corticoid_LABA_CachDung=:Corticoid_LABA_CachDung,
                            Xanthine_CoSuDung=:Xanthine_CoSuDung,
                            Xanthine_CachDung=:Xanthine_CachDung,
                            Khac_CoSuDung=:Khac_CoSuDung,
                            Khac_CachDung=:Khac_CachDung,
                            YeuToLienQuanDenDotCap=:YeuToLienQuanDenDotCap,
                            ThayDoiThoiTiet_Co=:ThayDoiThoiTiet_Co,
                            ThayDoiThoiTiet_Khong=:ThayDoiThoiTiet_Khong,
                            KhongTuanThuDieuTri_Co=:KhongTuanThuDieuTri_Co,
                            KhongTuanThuDieuTri_Khong=:KhongTuanThuDieuTri_Khong,
                            ViemHoHap_Co=:ViemHoHap_Co,
                            ViemHoHap_Khong=:ViemHoHap_Khong,
                            BenhPhoiHop_Co=:BenhPhoiHop_Co,
                            BenhPhoiHop_Khong=:BenhPhoiHop_Khong,
                            KhoiThuoc_Co=:KhoiThuoc_Co,
                            KhoiThuoc_Khong=:KhoiThuoc_Khong,
                            Bui_Co=:Bui_Co,
                            Bui_Khong=:Bui_Khong,
                            HoaChat_Co=:HoaChat_Co,
                            HoaChat_Khong=:HoaChat_Khong,
                            Thuoc_Co=:Thuoc_Co,
                            Thuoc_Khong=:Thuoc_Khong,
                            ThucAn_Co=:ThucAn_Co,
                            ThucAn_Khong=:ThucAn_Khong,
                            GangSuc_Co=:GangSuc_Co,
                            GangSuc_Khong=:GangSuc_Khong,
                            Khac_Co=:Khac_Co,
                            Khac_Khong=:Khac_Khong,
                            TrieuChungBenh_Ho=:TrieuChungBenh_Ho,
                            TrieuChungBenh_KhacDom=:TrieuChungBenh_KhacDom,
                            TrieuChungBenh_DomMau=:TrieuChungBenh_DomMau,
                            TrieuChungBenh_KhoKhe=:TrieuChungBenh_KhoKhe,
                            TrieuChungBenh_KhoTho=:TrieuChungBenh_KhoTho,
                            TrieuChungBenh_NangNguc=:TrieuChungBenh_NangNguc,
                            MucDoKhoTho=:MucDoKhoTho,
                            HutThuoc=:HutThuoc,
                            HutThuocThuDong_Nam=:HutThuocThuDong_Nam,
                            HutThuocBaoTrenNam=:HutThuocBaoTrenNam,
                            HutThuoc_GhiChu=:HutThuoc_GhiChu,
                            ViemMuiDiUng_Co=:ViemMuiDiUng_Co,
                            ViemMuiDiUng_Khong=:ViemMuiDiUng_Khong,
                            MeDay_Co=:MeDay_Co,
                            MeDay_Khong=:MeDay_Khong,
                            Cham_Co=:Cham_Co,
                            Cham_Khong=:Cham_Khong,
                            CoDiaDiUng_Khac_Co=:CoDiaDiUng_Khac_Co,
                            CoDiaDiUng_Khac_Khong=:CoDiaDiUng_Khac_Khong,
                            DiNguyen=:DiNguyen,
                            BenhDongMachVanh=:BenhDongMachVanh,
                            NhoiMauCoTim=:NhoiMauCoTim,
                            LoanNhipTim=:LoanNhipTim,
                            XuyTimXungHuyet=:XuyTimXungHuyet,
                            TangHuyetAp=:TangHuyetAp,
                            TaiBienMachMaoNao=:TaiBienMachMaoNao,
                            HoiChungCushing=:HoiChungCushing,
                            SuyThuongThan=:SuyThuongThan,
                            CuomMat=:CuomMat,
                            TangNhanAp=:TangNhanAp,
                            TangCholesteronMau=:TangCholesteronMau,
                            DaiThaoDuong=:DaiThaoDuong,
                            LoangXuong=:LoangXuong,
                            ViemPhoi=:ViemPhoi,
                            GiaDinh_KhongCoBenh=:GiaDinh_KhongCoBenh,
                            GiaDinh_Hen=:GiaDinh_Hen,
                            GiaDinh_ViemMuiDiUng=:GiaDinh_ViemMuiDiUng,
                            GiaDinh_MeDay=:GiaDinh_MeDay,
                            GiaDinh_Cham=:GiaDinh_Cham,
                            GiaDinh_Khac=:GiaDinh_Khac,
                            GiaDinh_Khac_CuThe=:GiaDinh_Khac_CuThe,
                            AiMacBenh=:AiMacBenh,
                            Phoi_BinhThuong=:Phoi_BinhThuong,
                            Phoi_RRFNGiam=:Phoi_RRFNGiam,
                            Phoi_RanRitRanNgay=:Phoi_RanRitRanNgay,
                            Phoi_RanNoAm=:Phoi_RanNoAm,
                            Phoi_Khac=:Phoi_Khac,
                            Phoi_Khac_CuThe=:Phoi_Khac_CuThe,
                            CoQuanKhac=:CoQuanKhac,
                            DoPheDungs=:DoPheDungs,
                            DoChucNangHoHaps=:DoChucNangHoHaps,
                            XQuangPhoi=:XQuangPhoi,
                            DTD_SAT=:DTD_SAT,
                            XetNghiemKhac=:XetNghiemKhac,
                            ChanDoan_COPD_1=:ChanDoan_COPD_1,
                            ChanDoan_COPD_2=:ChanDoan_COPD_2,
                            ChanDoan_COPD_3=:ChanDoan_COPD_3,
                            ChanDoan_COPD_4=:ChanDoan_COPD_4,
                            BenhPhoiHop=:BenhPhoiHop,
                            DieuTri=:DieuTri
                            WHERE MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("SHS", BenhAnPhoiTacNghenManTinh.SHS));
                Command.Parameters.Add(new MDB.MDBParameter("NgayLapHoSo", BenhAnPhoiTacNghenManTinh.NgayLapHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("DienThoaiNhaRieng", BenhAnPhoiTacNghenManTinh.DienThoaiNhaRieng));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyPhuTrach", BenhAnPhoiTacNghenManTinh.BacSyPhuTrach));
                Command.Parameters.Add(new MDB.MDBParameter("Ho", BenhAnPhoiTacNghenManTinh.Ho));
                Command.Parameters.Add(new MDB.MDBParameter("KhoKhe", BenhAnPhoiTacNghenManTinh.KhoKhe));
                Command.Parameters.Add(new MDB.MDBParameter("NangNguc", BenhAnPhoiTacNghenManTinh.NangNguc));
                Command.Parameters.Add(new MDB.MDBParameter("KhoTho", BenhAnPhoiTacNghenManTinh.KhoTho));
                Command.Parameters.Add(new MDB.MDBParameter("KhacDom", BenhAnPhoiTacNghenManTinh.KhacDom));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungKhac", BenhAnPhoiTacNghenManTinh.TrieuChungKhac));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungKhac_Text", BenhAnPhoiTacNghenManTinh.TrieuChungKhac_Text));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianKhoiPhat", BenhAnPhoiTacNghenManTinh.ThoiGianKhoiPhat));
                Command.Parameters.Add(new MDB.MDBParameter("BNBietChanDoanCopd", BenhAnPhoiTacNghenManTinh.BNBietChanDoanCopd));
                Command.Parameters.Add(new MDB.MDBParameter("BNDuocBSCK", BenhAnPhoiTacNghenManTinh.BNDuocBSCK));
                Command.Parameters.Add(new MDB.MDBParameter("BNDuocBSCK_TrongBaoLau", BenhAnPhoiTacNghenManTinh.BNDuocBSCK_TrongBaoLau));
                Command.Parameters.Add(new MDB.MDBParameter("SoLanMacTrongNam", BenhAnPhoiTacNghenManTinh.SoLanMacTrongNam));
                Command.Parameters.Add(new MDB.MDBParameter("DaNhapVienViCopd", BenhAnPhoiTacNghenManTinh.DaNhapVienViCopd));
                Command.Parameters.Add(new MDB.MDBParameter("NhapVienBaoLan", BenhAnPhoiTacNghenManTinh.NhapVienBaoLan));
                Command.Parameters.Add(new MDB.MDBParameter("CoThoMay", BenhAnPhoiTacNghenManTinh.CoThoMay));
                Command.Parameters.Add(new MDB.MDBParameter("SABA_CoSuDung", BenhAnPhoiTacNghenManTinh.SABA_CoSuDung));
                Command.Parameters.Add(new MDB.MDBParameter("SABA_CachDung", BenhAnPhoiTacNghenManTinh.SABA_CachDung));
                Command.Parameters.Add(new MDB.MDBParameter("LABA_CoSuDung", BenhAnPhoiTacNghenManTinh.LABA_CoSuDung));
                Command.Parameters.Add(new MDB.MDBParameter("LABA_CachDung", BenhAnPhoiTacNghenManTinh.LABA_CachDung));
                Command.Parameters.Add(new MDB.MDBParameter("Corticoid_CoSuDung", BenhAnPhoiTacNghenManTinh.Corticoid_CoSuDung));
                Command.Parameters.Add(new MDB.MDBParameter("Corticoid_CachDung", BenhAnPhoiTacNghenManTinh.Corticoid_CachDung));
                Command.Parameters.Add(new MDB.MDBParameter("Corticoid_LABA_CoSuDung", BenhAnPhoiTacNghenManTinh.Corticoid_LABA_CoSuDung));
                Command.Parameters.Add(new MDB.MDBParameter("Corticoid_LABA_CachDung", BenhAnPhoiTacNghenManTinh.Corticoid_LABA_CachDung));
                Command.Parameters.Add(new MDB.MDBParameter("Xanthine_CoSuDung", BenhAnPhoiTacNghenManTinh.Xanthine_CoSuDung));
                Command.Parameters.Add(new MDB.MDBParameter("Xanthine_CachDung", BenhAnPhoiTacNghenManTinh.Xanthine_CachDung));
                Command.Parameters.Add(new MDB.MDBParameter("Khac_CoSuDung", BenhAnPhoiTacNghenManTinh.Khac_CoSuDung));
                Command.Parameters.Add(new MDB.MDBParameter("Khac_CachDung", BenhAnPhoiTacNghenManTinh.Khac_CachDung));
                Command.Parameters.Add(new MDB.MDBParameter("YeuToLienQuanDenDotCap", BenhAnPhoiTacNghenManTinh.YeuToLienQuanDenDotCap));
                Command.Parameters.Add(new MDB.MDBParameter("ThayDoiThoiTiet_Co", BenhAnPhoiTacNghenManTinh.ThayDoiThoiTiet_Co));
                Command.Parameters.Add(new MDB.MDBParameter("ThayDoiThoiTiet_Khong", BenhAnPhoiTacNghenManTinh.ThayDoiThoiTiet_Khong));
                Command.Parameters.Add(new MDB.MDBParameter("KhongTuanThuDieuTri_Co", BenhAnPhoiTacNghenManTinh.KhongTuanThuDieuTri_Co));
                Command.Parameters.Add(new MDB.MDBParameter("KhongTuanThuDieuTri_Khong", BenhAnPhoiTacNghenManTinh.KhongTuanThuDieuTri_Khong));
                Command.Parameters.Add(new MDB.MDBParameter("ViemHoHap_Co", BenhAnPhoiTacNghenManTinh.ViemHoHap_Co));
                Command.Parameters.Add(new MDB.MDBParameter("ViemHoHap_Khong", BenhAnPhoiTacNghenManTinh.ViemHoHap_Khong));
                Command.Parameters.Add(new MDB.MDBParameter("BenhPhoiHop_Co", BenhAnPhoiTacNghenManTinh.BenhPhoiHop_Co));
                Command.Parameters.Add(new MDB.MDBParameter("BenhPhoiHop_Khong", BenhAnPhoiTacNghenManTinh.BenhPhoiHop_Khong));
                Command.Parameters.Add(new MDB.MDBParameter("KhoiThuoc_Co", BenhAnPhoiTacNghenManTinh.KhoiThuoc_Co));
                Command.Parameters.Add(new MDB.MDBParameter("KhoiThuoc_Khong", BenhAnPhoiTacNghenManTinh.KhoiThuoc_Khong));
                Command.Parameters.Add(new MDB.MDBParameter("Bui_Co", BenhAnPhoiTacNghenManTinh.Bui_Co));
                Command.Parameters.Add(new MDB.MDBParameter("Bui_Khong", BenhAnPhoiTacNghenManTinh.Bui_Khong));
                Command.Parameters.Add(new MDB.MDBParameter("HoaChat_Co", BenhAnPhoiTacNghenManTinh.HoaChat_Co));
                Command.Parameters.Add(new MDB.MDBParameter("HoaChat_Khong", BenhAnPhoiTacNghenManTinh.HoaChat_Khong));
                Command.Parameters.Add(new MDB.MDBParameter("Thuoc_Co", BenhAnPhoiTacNghenManTinh.Thuoc_Co));
                Command.Parameters.Add(new MDB.MDBParameter("Thuoc_Khong", BenhAnPhoiTacNghenManTinh.Thuoc_Khong));
                Command.Parameters.Add(new MDB.MDBParameter("ThucAn_Co", BenhAnPhoiTacNghenManTinh.ThucAn_Co));
                Command.Parameters.Add(new MDB.MDBParameter("ThucAn_Khong", BenhAnPhoiTacNghenManTinh.ThucAn_Khong));
                Command.Parameters.Add(new MDB.MDBParameter("GangSuc_Co", BenhAnPhoiTacNghenManTinh.GangSuc_Co));
                Command.Parameters.Add(new MDB.MDBParameter("GangSuc_Khong", BenhAnPhoiTacNghenManTinh.GangSuc_Khong));
                Command.Parameters.Add(new MDB.MDBParameter("Khac_Co", BenhAnPhoiTacNghenManTinh.Khac_Co));
                Command.Parameters.Add(new MDB.MDBParameter("Khac_Khong", BenhAnPhoiTacNghenManTinh.Khac_Khong));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungBenh_Ho", BenhAnPhoiTacNghenManTinh.TrieuChungBenh_Ho));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungBenh_KhacDom", BenhAnPhoiTacNghenManTinh.TrieuChungBenh_KhacDom));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungBenh_DomMau", BenhAnPhoiTacNghenManTinh.TrieuChungBenh_DomMau));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungBenh_KhoKhe", BenhAnPhoiTacNghenManTinh.TrieuChungBenh_KhoKhe));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungBenh_KhoTho", BenhAnPhoiTacNghenManTinh.TrieuChungBenh_KhoTho));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungBenh_NangNguc", BenhAnPhoiTacNghenManTinh.TrieuChungBenh_NangNguc));
                Command.Parameters.Add(new MDB.MDBParameter("MucDoKhoTho", BenhAnPhoiTacNghenManTinh.MucDoKhoTho));
                Command.Parameters.Add(new MDB.MDBParameter("HutThuoc", BenhAnPhoiTacNghenManTinh.HutThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("HutThuocThuDong_Nam", BenhAnPhoiTacNghenManTinh.HutThuocThuDong_Nam));
                Command.Parameters.Add(new MDB.MDBParameter("HutThuocBaoTrenNam", BenhAnPhoiTacNghenManTinh.HutThuocBaoTrenNam));
                Command.Parameters.Add(new MDB.MDBParameter("HutThuoc_GhiChu", BenhAnPhoiTacNghenManTinh.HutThuoc_GhiChu));
                Command.Parameters.Add(new MDB.MDBParameter("ViemMuiDiUng_Co", BenhAnPhoiTacNghenManTinh.ViemMuiDiUng_Co));
                Command.Parameters.Add(new MDB.MDBParameter("ViemMuiDiUng_Khong", BenhAnPhoiTacNghenManTinh.ViemMuiDiUng_Khong));
                Command.Parameters.Add(new MDB.MDBParameter("MeDay_Co", BenhAnPhoiTacNghenManTinh.MeDay_Co));
                Command.Parameters.Add(new MDB.MDBParameter("MeDay_Khong", BenhAnPhoiTacNghenManTinh.MeDay_Khong));
                Command.Parameters.Add(new MDB.MDBParameter("Cham_Co", BenhAnPhoiTacNghenManTinh.Cham_Co));
                Command.Parameters.Add(new MDB.MDBParameter("Cham_Khong", BenhAnPhoiTacNghenManTinh.Cham_Khong));
                Command.Parameters.Add(new MDB.MDBParameter("CoDiaDiUng_Khac_Co", BenhAnPhoiTacNghenManTinh.CoDiaDiUng_Khac_Co));
                Command.Parameters.Add(new MDB.MDBParameter("CoDiaDiUng_Khac_Khong", BenhAnPhoiTacNghenManTinh.CoDiaDiUng_Khac_Khong));
                Command.Parameters.Add(new MDB.MDBParameter("DiNguyen", BenhAnPhoiTacNghenManTinh.DiNguyen));
                Command.Parameters.Add(new MDB.MDBParameter("BenhDongMachVanh", BenhAnPhoiTacNghenManTinh.BenhDongMachVanh));
                Command.Parameters.Add(new MDB.MDBParameter("NhoiMauCoTim", BenhAnPhoiTacNghenManTinh.NhoiMauCoTim));
                Command.Parameters.Add(new MDB.MDBParameter("LoanNhipTim", BenhAnPhoiTacNghenManTinh.LoanNhipTim));
                Command.Parameters.Add(new MDB.MDBParameter("XuyTimXungHuyet", BenhAnPhoiTacNghenManTinh.XuyTimXungHuyet));
                Command.Parameters.Add(new MDB.MDBParameter("TangHuyetAp", BenhAnPhoiTacNghenManTinh.TangHuyetAp));
                Command.Parameters.Add(new MDB.MDBParameter("TaiBienMachMaoNao", BenhAnPhoiTacNghenManTinh.TaiBienMachMaoNao));
                Command.Parameters.Add(new MDB.MDBParameter("HoiChungCushing", BenhAnPhoiTacNghenManTinh.HoiChungCushing));
                Command.Parameters.Add(new MDB.MDBParameter("SuyThuongThan", BenhAnPhoiTacNghenManTinh.SuyThuongThan));
                Command.Parameters.Add(new MDB.MDBParameter("CuomMat", BenhAnPhoiTacNghenManTinh.CuomMat));
                Command.Parameters.Add(new MDB.MDBParameter("TangNhanAp", BenhAnPhoiTacNghenManTinh.TangNhanAp));
                Command.Parameters.Add(new MDB.MDBParameter("TangCholesteronMau", BenhAnPhoiTacNghenManTinh.TangCholesteronMau));
                Command.Parameters.Add(new MDB.MDBParameter("DaiThaoDuong", BenhAnPhoiTacNghenManTinh.DaiThaoDuong));
                Command.Parameters.Add(new MDB.MDBParameter("LoangXuong", BenhAnPhoiTacNghenManTinh.LoangXuong));
                Command.Parameters.Add(new MDB.MDBParameter("ViemPhoi", BenhAnPhoiTacNghenManTinh.ViemPhoi));
                Command.Parameters.Add(new MDB.MDBParameter("GiaDinh_KhongCoBenh", BenhAnPhoiTacNghenManTinh.GiaDinh_KhongCoBenh));
                Command.Parameters.Add(new MDB.MDBParameter("GiaDinh_Hen", BenhAnPhoiTacNghenManTinh.GiaDinh_Hen));
                Command.Parameters.Add(new MDB.MDBParameter("GiaDinh_ViemMuiDiUng", BenhAnPhoiTacNghenManTinh.GiaDinh_ViemMuiDiUng));
                Command.Parameters.Add(new MDB.MDBParameter("GiaDinh_MeDay", BenhAnPhoiTacNghenManTinh.GiaDinh_MeDay));
                Command.Parameters.Add(new MDB.MDBParameter("GiaDinh_Cham", BenhAnPhoiTacNghenManTinh.GiaDinh_Cham));
                Command.Parameters.Add(new MDB.MDBParameter("GiaDinh_Khac", BenhAnPhoiTacNghenManTinh.GiaDinh_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("GiaDinh_Khac_CuThe", BenhAnPhoiTacNghenManTinh.GiaDinh_Khac_CuThe));
                Command.Parameters.Add(new MDB.MDBParameter("AiMacBenh", BenhAnPhoiTacNghenManTinh.AiMacBenh));
                Command.Parameters.Add(new MDB.MDBParameter("Phoi_BinhThuong", BenhAnPhoiTacNghenManTinh.Phoi_BinhThuong));
                Command.Parameters.Add(new MDB.MDBParameter("Phoi_RRFNGiam", BenhAnPhoiTacNghenManTinh.Phoi_RRFNGiam));
                Command.Parameters.Add(new MDB.MDBParameter("Phoi_RanRitRanNgay", BenhAnPhoiTacNghenManTinh.Phoi_RanRitRanNgay));
                Command.Parameters.Add(new MDB.MDBParameter("Phoi_RanNoAm", BenhAnPhoiTacNghenManTinh.Phoi_RanNoAm));
                Command.Parameters.Add(new MDB.MDBParameter("Phoi_Khac", BenhAnPhoiTacNghenManTinh.Phoi_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("Phoi_Khac_CuThe", BenhAnPhoiTacNghenManTinh.Phoi_Khac_CuThe));
                Command.Parameters.Add(new MDB.MDBParameter("CoQuanKhac", BenhAnPhoiTacNghenManTinh.CoQuanKhac));
                Command.Parameters.Add(new MDB.MDBParameter("DoPheDungs", JsonConvert.SerializeObject(BenhAnPhoiTacNghenManTinh.DoPheDungs)));
                Command.Parameters.Add(new MDB.MDBParameter("DoChucNangHoHaps", JsonConvert.SerializeObject(BenhAnPhoiTacNghenManTinh.DoChucNangHoHaps)));
                Command.Parameters.Add(new MDB.MDBParameter("XQuangPhoi", BenhAnPhoiTacNghenManTinh.XQuangPhoi));
                Command.Parameters.Add(new MDB.MDBParameter("DTD_SAT", BenhAnPhoiTacNghenManTinh.DTD_SAT));
                Command.Parameters.Add(new MDB.MDBParameter("XetNghiemKhac", BenhAnPhoiTacNghenManTinh.XetNghiemKhac));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan_COPD_1", BenhAnPhoiTacNghenManTinh.ChanDoan_COPD_1));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan_COPD_2", BenhAnPhoiTacNghenManTinh.ChanDoan_COPD_2));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan_COPD_3", BenhAnPhoiTacNghenManTinh.ChanDoan_COPD_3));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan_COPD_4", BenhAnPhoiTacNghenManTinh.ChanDoan_COPD_4));
                Command.Parameters.Add(new MDB.MDBParameter("BenhPhoiHop", BenhAnPhoiTacNghenManTinh.BenhPhoiHop));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri", BenhAnPhoiTacNghenManTinh.DieuTri));

                Command.BindByName = true;

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnPhoiTacNghenManTinh.MaQuanLy));
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
