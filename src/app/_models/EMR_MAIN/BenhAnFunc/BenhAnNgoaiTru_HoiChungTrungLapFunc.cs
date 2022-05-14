using EMR_MAIN.DATABASE.BenhAn;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.BenhAnFunc
{
    public class BenhAnNgoaiTru_HoiChungTrungLapFunc
    {
        public static void WriteXml(MDB.MDBConnection MyConnection)
        {
            string sql =
                   @"
                  select  a.*,  CTScanner HoSo_CTScanner, SieuAm HoSo_SieuAm, XetNghiem HoSo_XetNghiem,  Khac HoSo_Khac,  Khac_Text HoSo_Khac_Text,  ToanBoHoSo HoSo_ToanBoHoSo, Mach DauSinhTon_Mach,  NhietDo DauSinhTon_NhietDo,  HuyetAp DauSinhTon_HuyetAp,  NhipTho DauSinhTon_NhipTho,  CanNang DauSinhTon_CanNang  
                  from BenhAnHoiChungTrungLap a inner join thongtindieutri b on a.maquanly = b.maquanly
                  where rownum = 1
                    ";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            var DataTable = new DataTable { TableName = "BenhAnHoiChungTrungLap" };
            DataTable.Load(DataReader as IDataReader);
            DataTable.WriteXml("rptBenhAnHoiChungTrungLap.xml");
        }
        public static DataSet SelectDataSet(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql =
                   @"
                  select  a.*, f.hovaten BacSiKhamBenhHoVaTen, g.hovaten TK_BacSiKhamBenhHoVaTen, h.hovaten TongKet_BacSyDieuTriHoVaTen, d.hovaten NguoiGiaoHoSoHoVaTen,e.hovaten NguoiNhanHoSoHoVaTen, b.XQuang HoSo_XQuang, b.CTScanner HoSo_CTScanner, b.SieuAm HoSo_SieuAm, b.XetNghiem HoSo_XetNghiem,  b.Khac HoSo_Khac,  b.Khac_Text HoSo_Khac_Text,  b.ToanBoHoSo HoSo_ToanBoHoSo, b.Mach DauSinhTon_Mach, b.NhietDo DauSinhTon_NhietDo,  b.HuyetAp DauSinhTon_HuyetAp,  b.NhipTho DauSinhTon_NhipTho,  b.CanNang DauSinhTon_CanNang  , b.ChieuCao DauSinhTon_ChieuCao, b.BMI DauSinhTon_BMI, b.NgayRaVien 
                        from BenhAnHoiChungTrungLap a  
                  left join thongtindieutri b on a.maquanly = b.maquanly 
                  left join nhanvien f on a.BacSiKhamBenh = f.manhanvien
                  left join nhanvien g on a.TK_BacSiKhamBenh = g.manhanvien
                  left join nhanvien h on a.TongKet_BacSyDieuTri = h.manhanvien
                  left join nhanvien d on a.NguoiGiaoHoSo = d.manhanvien
                  left join nhanvien e on a.NguoiNhanHoSo = e.manhanvien where a.maquanly = " + MaQuanLy.ToString(System.Globalization.CultureInfo.InvariantCulture);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(sql, MyConnection);
            var ds = new DataSet();
            adt.Fill(ds, "Table");
            
            return ds;

        }
        public static BenhAnNgoaiTru_HoiChungTrungLap Select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            var obj = new BenhAnNgoaiTru_HoiChungTrungLap();
            try
            {
                #region
                string sql =
                          @"select * 
                        from BenhAnHoiChungTrungLap 
                        where MaQuanLy = :MaQuanLy";
                #endregion
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    // Phần chung Hành chính
                    obj.MaQuanLy = DataReader.GetDecimal("MaQuanLy");
                    obj.DieuTriNgoaiTruTu = DataReader["DieuTriNgoaiTruTu"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["DieuTriNgoaiTruTu"]) : null;
                    obj.DieuTriNgoaiTruDen = DataReader["DieuTriNgoaiTruDen"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["DieuTriNgoaiTruDen"]) : null;
                    obj.SoCMND = DataReader["SoCMND"].ToString();
                    obj.BaoHiem = DataReader["BaoHiem"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["BaoHiem"]) : null;
                    obj.ChanDoan_TuyenTruoc = DataReader["ChanDoan_TuyenTruoc"].ToString();
                    obj.ChanDoanBanDau = DataReader["ChanDoanBanDau"].ToString();
                    obj.ChanDoanTaiKham1 = DataReader["ChanDoanTaiKham1"].ToString();
                    obj.ChanDoanTaiKham2 = DataReader["ChanDoanTaiKham2"].ToString();
                    obj.ChanDoanTaiKham3 = DataReader["ChanDoanTaiKham3"].ToString();
                    obj.ChanDoanTaiKham4 = DataReader["ChanDoanTaiKham4"].ToString();
                    obj.BenhPhu = DataReader["BenhPhu"].ToString();
                    obj.KetQuaDieuTri = DataReader.GetInt("KetQuaDieuTri");
                    obj.BienChung_Text = DataReader["BienChung_Text"].ToString();
                    obj.GDPhongKeHoach = DataReader["GDPhongKeHoach"].ToString();
                    obj.GDPhongKhamBenh = DataReader["GDPhongKhamBenh"].ToString();

                    // hỏi bệnh, tái khám
                    obj.TuoiKhoiPhat = DataReader["TuoiKhoiPhat"].ToString();
                    obj.ThoiGianKhoiPhatBenh = DataReader["ThoiGianKhoiPhatBenh"].ToString();
                    obj.TrieuChungDauTien = DataReader["TrieuChungDauTien"].ToString();
                    obj.TienSuCoBenhTuMien = DataReader.GetInt("TienSuCoBenhTuMien");
                    obj.TienSuCoBenhTuMien_Text = DataReader["TienSuCoBenhTuMien_Text"].ToString();
                    obj.TSCNBiCacBenhKhac = DataReader.GetInt("TSCNBiCacBenhKhac");
                    obj.TSCNBiCacBenhKhac_Text = DataReader["TSCNBiCacBenhKhac_Text"].ToString();
                    obj.TSGDBenhTuMien = DataReader.GetInt("TSGDBenhTuMien");
                    obj.TSGDBenhTuMien_Text = DataReader["TSGDBenhTuMien_Text"].ToString();
                    obj.BenhSu = DataReader["BenhSu"].ToString();
                    obj.ChuaDieuTri = DataReader.GetInt("ChuaDieuTri");
                    obj.NhomThuoc = DataReader["NhomThuoc"].ToString();
                    obj.DungTrongBaoLau = DataReader["DungTrongBaoLau"].ToString();
                    obj.TacDungPhuCuaThuoc = DataReader.GetInt("TacDungPhuCuaThuoc");
                    obj.TacDungPhuCuaThuoc_Text = DataReader["TacDungPhuCuaThuoc_Text"].ToString();
                    obj.Sot = DataReader.GetInt("Sot");
                    obj.Sot_Text = DataReader["Sot_Text"].ToString();
                    obj.MetMoi = DataReader.GetInt("MetMoi");
                    obj.Mach = DataReader["Mach"].ToString();
                    obj.HuyetAp = DataReader["HuyetAp"].ToString();
                    obj.HachTo = DataReader.GetInt("HachTo");
                    obj.HachTo_Vitri = DataReader["HachTo_Vitri"].ToString();
                    obj.BanCanhBuom = DataReader.GetInt("BanCanhBuom");
                    obj.NhayCamAnhSang = DataReader.GetInt("NhayCamAnhSang");
                    obj.LoetMieng = DataReader.GetInt("LoetMieng");
                    obj.HienTuongRaynaud = DataReader.GetInt("HienTuongRaynaud");
                    obj.MatPhuNe = DataReader.GetInt("MatPhuNe");
                    obj.BanHeliotrope = DataReader.GetInt("BanHeliotrope");
                    obj.GottronSign = DataReader.GetInt("GottronSign");
                    obj.GottronPapules = DataReader.GetInt("GottronPapules");
                    obj.MichanicHand = DataReader.GetInt("MichanicHand");
                    obj.XoCungDaDauNgon = DataReader.GetInt("XoCungDaDauNgon");
                    obj.XoCungDa = DataReader.GetInt("XoCungDa");
                    obj.TrieuChungKhac = DataReader["TrieuChungKhac"].ToString();
                    obj.DauCo = DataReader.GetInt("DauCo");
                    obj.DauCo_ViTri = DataReader["DauCo_ViTri"].ToString();
                    obj.BopCo = DataReader.GetInt("BopCo");
                    obj.BopCo_ViTri = DataReader["BopCo_ViTri"].ToString();
                    obj.TeoCo = DataReader.GetInt("TeoCo");
                    obj.TeoCo_ViTri = DataReader["TeoCo_ViTri"].ToString();
                    obj.TrieuChungKhop = DataReader.GetInt("TrieuChungKhop");
                    obj.TrieuChungKhop_Dau = DataReader.GetInt("TrieuChungKhop_Dau");
                    obj.TrieuChungKhop_Sung = DataReader.GetInt("TrieuChungKhop_Sung");
                    obj.TrieuChungKhop_BienDang = DataReader.GetInt("TrieuChungKhop_BienDang");
                    obj.TrieuChungKhop_Text = DataReader["TrieuChungKhop_Text"].ToString();
                    obj.Phoi = DataReader.GetInt("Phoi");
                    obj.Phoi_Text = DataReader["Phoi_Text"].ToString();
                    obj.Tim = DataReader.GetInt("Tim");
                    obj.Tim_Text = DataReader["Tim_Text"].ToString();
                    obj.DuongTieuHoa = DataReader.GetInt("DuongTieuHoa");
                    obj.DuongTieuHoa_Text = DataReader["DuongTieuHoa_Text"].ToString();
                    obj.Phu = DataReader.GetInt("Phu");
                    obj.TieuIt = DataReader.GetInt("TieuIt");
                    obj.TieuHong = DataReader.GetInt("TieuHong");
                    obj.ThanTietNieu_Khac = DataReader["ThanTietNieu_Khac"].ToString();
                    obj.CongThucMau = DataReader["CongThucMau"].ToString();
                    obj.MauLang_1h = DataReader["MauLang_1h"].ToString();
                    obj.MauLang_2h = DataReader["MauLang_2h"].ToString();
                    obj.SinhHoa = DataReader["SinhHoa"].ToString();
                    obj.NuocTieu = DataReader["NuocTieu"].ToString();
                    obj.CNHH_NgayLam = DataReader["CNHH_NgayLam"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["CNHH_NgayLam"]) : null;
                    obj.CNHH_FVC = DataReader["CNHH_FVC"].ToString();
                    obj.CNHH_FEV1 = DataReader["CNHH_FEV1"].ToString();
                    obj.CNHH_DLco = DataReader["CNHH_DLco"].ToString();
                    obj.CNHH_DuDoanFVC = DataReader["CNHH_DuDoanFVC"].ToString();
                    obj.CNHH_FEV1_FVC = DataReader["CNHH_FEV1_FVC"].ToString();
                    obj.CNHH_DuDoanDLco = DataReader["CNHH_DuDoanDLco"].ToString();
                    obj.XQtp = DataReader["XQtp"].ToString();
                    obj.HRCT_NgayLam = DataReader["HRCT_NgayLam"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["HRCT_NgayLam"]) : null;
                    obj.HRCT_Text = DataReader["HRCT_Text"].ToString();
                    obj.SAOBung = DataReader["SAOBung"].ToString();
                    obj.Ana = DataReader["Ana"].ToString();
                    obj.CacTheTuKhangKhac = DataReader["CacTheTuKhangKhac"].ToString();
                    obj.KhamMat_NgayLam = DataReader["KhamMat_NgayLam"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["KhamMat_NgayLam"]) : null;
                    obj.KhamMat_Text = DataReader["KhamMat_Text"].ToString();
                    obj.DienCoKim = DataReader["DienCoKim"].ToString();
                    obj.SinhThietCo_NgayLam = DataReader["SinhThietCo_NgayLam"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["SinhThietCo_NgayLam"]) : null;
                    obj.SinhThietCo_Text = DataReader["SinhThietCo_Text"].ToString();
                    obj.BenhMoLienKet = DataReader.GetInt("BenhMoLienKet");
                    obj.TieuChuanBatBuoc = DataReader.GetInt("TieuChuanBatBuoc");
                    obj.PhuBanTay = DataReader.GetInt("PhuBanTay");
                    obj.ViemDaMang = DataReader.GetInt("ViemDaMang");
                    obj.ViemCo = DataReader.GetInt("ViemCo");
                    obj.TCLS_HienTuongRaynaud = DataReader.GetInt("TCLS_HienTuongRaynaud");
                    obj.XoCungDauChi = DataReader.GetInt("XoCungDauChi");
                    obj.HoiChungEnzyme = DataReader.GetInt("HoiChungEnzyme");
                    obj.AntiARSDuongTinh = DataReader.GetInt("AntiARSDuongTinh");
                    obj.BenhLyPhoiKe = DataReader.GetInt("BenhLyPhoiKe");
                    obj.ViemDaCoViemBiCo = DataReader.GetInt("ViemDaCoViemBiCo");
                    obj.ViemKhop = DataReader.GetInt("ViemKhop");
                    obj.TCP_HienTuongRaynaud = DataReader.GetInt("TCP_HienTuongRaynaud");
                    obj.TCP_BanTayThoCoKhi = DataReader.GetInt("TCP_BanTayThoCoKhi");
                    obj.XoCungBiHeThong = DataReader.GetInt("XoCungBiHeThong");
                    obj.ThuongTonDaVungNgonTay = DataReader.GetInt("ThuongTonDaVungNgonTay");
                    obj.DayDaNgonTay_1 = DataReader.GetInt("DayDaNgonTay_1");
                    obj.DayDaNgonTay_2 = DataReader.GetInt("DayDaNgonTay_2");
                    obj.ThuongTonDauNgon_1 = DataReader.GetInt("ThuongTonDauNgon_1");
                    obj.ThuongTonDauNgon_2 = DataReader.GetInt("ThuongTonDauNgon_2");
                    obj.GianMach = DataReader.GetInt("GianMach");
                    obj.BatThuongMaoMach = DataReader.GetInt("BatThuongMaoMach");
                    obj.TangApLucDongMach_1 = DataReader.GetInt("TangApLucDongMach_1");
                    obj.TangApLucDongMach_2 = DataReader.GetInt("TangApLucDongMach_2");
                    obj.HienTuongRaynauds = DataReader.GetInt("HienTuongRaynauds");
                    obj.Anti_Centromere = DataReader.GetInt("Anti_Centromere");
                    obj.Anti_TopoisomeraseI = DataReader.GetInt("Anti_TopoisomeraseI");
                    obj.Anti_RNApolymeraseIII = DataReader.GetInt("Anti_RNApolymeraseIII");
                    obj.BieuHienTaiKhop = DataReader.GetInt("BieuHienTaiKhop");
                    obj.HuyetThanh = DataReader.GetInt("HuyetThanh");
                    obj.CacYeuToPhanUng = DataReader.GetInt("CacYeuToPhanUng");
                    obj.ThoiGianBieuHien = DataReader.GetInt("ThoiGianBieuHien");
                    obj.TANIMOTO_1 = DataReader.GetInt("TANIMOTO_1");
                    obj.TANIMOTO_2 = DataReader.GetInt("TANIMOTO_2");
                    obj.TANIMOTO_3 = DataReader.GetInt("TANIMOTO_3");
                    obj.TANIMOTO_4 = DataReader.GetInt("TANIMOTO_4");
                    obj.TANIMOTO_5 = DataReader.GetInt("TANIMOTO_5");
                    obj.TANIMOTO_6 = DataReader.GetInt("TANIMOTO_6");
                    obj.TANIMOTO_7 = DataReader.GetInt("TANIMOTO_7");
                    obj.TANIMOTO_8 = DataReader.GetInt("TANIMOTO_8");
                    obj.TANIMOTO_9 = DataReader.GetInt("TANIMOTO_9");
                    obj.ViemBiCo_1 = DataReader.GetInt("ViemBiCo_1");
                    obj.ViemBiCo_2 = DataReader.GetInt("ViemBiCo_2");
                    obj.ChuY = DataReader["ChuY"].ToString();
                    obj.DieuTri_TaiCho = DataReader["DieuTri_TaiCho"].ToString();
                    obj.DieuTri_ToanThan = DataReader["DieuTri_ToanThan"].ToString();
                    obj.HenKham = DataReader["HenKham"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["HenKham"]) : null;
                    obj.BacSiKhamBenh = DataReader["BacSiKhamBenh"].ToString();
                    obj.TK_SoBenhAnDienTu = DataReader["TK_SoBenhAnDienTu"].ToString();
                    obj.TK_SoLuuTru = DataReader["TK_SoLuuTru"].ToString();
                    obj.TK_Sot = DataReader.GetInt("TK_Sot");
                    obj.TK_Sot_Text = DataReader["TK_Sot_Text"].ToString();
                    obj.TK_MetMoi = DataReader.GetInt("TK_MetMoi");
                    obj.TK_Mach = DataReader["TK_Mach"].ToString();
                    obj.TK_HuyetAp = DataReader["TK_HuyetAp"].ToString();
                    obj.TK_HachTo = DataReader.GetInt("TK_HachTo");
                    obj.TK_HachTo_Vitri = DataReader["TK_HachTo_Vitri"].ToString();
                    obj.TK_TienSu = DataReader["TK_TienSu"].ToString();
                    obj.TK_NTTDDLupusBanDoHT = DataReader["TK_NTTDDLupusBanDoHT"].ToString();
                    obj.TK_NTTDDBenhXoCungBi = DataReader["TK_NTTDDBenhXoCungBi"].ToString();
                    obj.TK_NTTDDBenhViemDaCo = DataReader["TK_NTTDDBenhViemDaCo"].ToString();
                    obj.TK_TonThuongDaKhac = DataReader["TK_TonThuongDaKhac"].ToString();
                    obj.TK_DauCo = DataReader.GetInt("TK_DauCo");
                    obj.TK_DauCo_ViTri = DataReader["TK_DauCo_ViTri"].ToString();
                    obj.TK_BopCo = DataReader.GetInt("TK_BopCo");
                    obj.TK_BopCo_ViTri = DataReader["TK_BopCo_ViTri"].ToString();
                    obj.TK_TeoCo = DataReader.GetInt("TK_TeoCo");
                    obj.TK_TeoCo_ViTri = DataReader["TK_TeoCo_ViTri"].ToString();
                    obj.TK_TrieuChungCo_Khac = DataReader["TK_TrieuChungCo_Khac"].ToString();
                    obj.TK_DauKhop = DataReader.GetInt("TK_DauKhop");
                    obj.TK_SungKhop = DataReader.GetInt("TK_SungKhop");
                    obj.TK_BienDangKhop = DataReader.GetInt("TK_BienDangKhop");
                    obj.TK_Phoi = DataReader.GetInt("TK_Phoi");
                    obj.TK_Phoi_SoVoiLanTruoc = DataReader.GetInt("TK_Phoi_SoVoiLanTruoc");
                    obj.TK_Phoi_Text = DataReader["TK_Phoi_Text"].ToString();
                    obj.TK_Tim = DataReader.GetInt("TK_Tim");
                    obj.TK_Tim_SoVoiLanTruoc = DataReader.GetInt("TK_Tim_SoVoiLanTruoc");
                    obj.TK_Tim_Text = DataReader["TK_Tim_Text"].ToString();
                    obj.TK_DTH = DataReader.GetInt("TK_DTH");
                    obj.TK_DTH_SoVoiLanTruoc = DataReader.GetInt("TK_DTH_SoVoiLanTruoc");
                    obj.TK_DTH_Text = DataReader["TK_DTH_Text"].ToString();
                    obj.TK_CongThucMau = DataReader["TK_CongThucMau"].ToString();
                    obj.TK_MauLang = DataReader["TK_MauLang"].ToString();
                    obj.TK_SinhHoa = DataReader["TK_SinhHoa"].ToString();
                    obj.TK_NuocTieu = DataReader["TK_NuocTieu"].ToString();
                    obj.TK_CacTuKhangThe_LamLaiSau = DataReader["TK_CacTuKhangThe_LamLaiSau"].ToString();
                    obj.TK_CacTuKhangThe_KetQua = DataReader["TK_CacTuKhangThe_KetQua"].ToString();
                    obj.TK_ChuY = DataReader["TK_ChuY"].ToString();
                    obj.TK_DieuTri_TaiCho = DataReader["TK_DieuTri_TaiCho"].ToString();
                    obj.TK_DieuTri_ToanThan = DataReader["TK_DieuTri_ToanThan"].ToString();
                    obj.TK_TacDungPhuCuaThuoc = DataReader["TK_TacDungPhuCuaThuoc"].ToString();
                    obj.TK_HenKham = DataReader["TK_HenKham"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["TK_HenKham"]) : null;
                    obj.TK_BacSiKhamBenh = DataReader["TK_BacSiKhamBenh"].ToString();

                    // phần tổng kết
                    obj.QuaTrinhBenhLy = DataReader["QuaTrinhBenhLy"].ToString();
                    obj.TomTatKetQua = DataReader["TomTatKetQua"].ToString();
                    obj.BenhChinh = DataReader["BenhChinh"].ToString();
                    obj.MaBenhChinh = DataReader["MaBenhChinh"].ToString();
                    obj.BenhKemTheo = DataReader["BenhKemTheo"].ToString();
                    obj.MaBenhKemTheo = DataReader["MaBenhKemTheo"].ToString();
                    obj.PhuongPhapDieuTri = DataReader["PhuongPhapDieuTri"].ToString();
                    obj.TinhTrangRaVien = DataReader["TinhTrangRaVien"].ToString();
                    obj.HuongDieuTri = DataReader["HuongDieuTri"].ToString();
                    obj.NguoiNhanHoSo = DataReader["NguoiNhanHoSo"].ToString();
                    obj.NguoiGiaoHoSo = DataReader["NguoiGiaoHoSo"].ToString();
                    obj.NgayTongKet = DataReader["NgayTongKet"] != DBNull.Value ? Convert.ToDateTime(DataReader["NgayTongKet"]) : DateTime.Now;
                    obj.TongKet_BacSyDieuTri = DataReader["TongKet_BacSyDieuTri"].ToString();
                    obj.TongKet_MaBacSyDieuTri = DataReader["TongKet_MaBacSyDieuTri"].ToString();
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return obj;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, BenhAnNgoaiTru_HoiChungTrungLap BenhAnHoiChungTrungLap)
        {
            try
            {
                string sql =
                          @"select MaQuanLy 
                            from BenhAnHoiChungTrungLap
                            where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnHoiChungTrungLap.MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                int rowCount = 0;
                while (DataReader.Read()) rowCount++;
                if (rowCount == 1) return Update(MyConnection, BenhAnHoiChungTrungLap);
                sql = @"
                       INSERT INTO BenhAnHoiChungTrungLap 
                        (
                            MaQuanLy,
                            DieuTriNgoaiTruTu,
                            DieuTriNgoaiTruDen,
                            SoCMND,
                            BaoHiem,
                            ChanDoan_TuyenTruoc,
                            ChanDoanBanDau,
                            ChanDoanTaiKham1,
                            ChanDoanTaiKham2,
                            ChanDoanTaiKham3,
                            ChanDoanTaiKham4,
                            BenhPhu,
                            KetQuaDieuTri,
                            BienChung_Text,
                            GDPhongKeHoach,
                            GDPhongKhamBenh,
                            TuoiKhoiPhat,
                            ThoiGianKhoiPhatBenh,
                            TrieuChungDauTien,
                            TienSuCoBenhTuMien,
                            TienSuCoBenhTuMien_Text,
                            TSCNBiCacBenhKhac,
                            TSCNBiCacBenhKhac_Text,
                            TSGDBenhTuMien,
                            TSGDBenhTuMien_Text,
                            BenhSu,
                            ChuaDieuTri,
                            NhomThuoc,
                            DungTrongBaoLau,
                            TacDungPhuCuaThuoc,
                            TacDungPhuCuaThuoc_Text,
                            Sot,
                            Sot_Text,
                            MetMoi,
                            Mach,
                            HuyetAp,
                            HachTo,
                            HachTo_Vitri,
                            BanCanhBuom,
                            NhayCamAnhSang,
                            LoetMieng,
                            HienTuongRaynaud,
                            MatPhuNe,
                            BanHeliotrope,
                            GottronSign,
                            GottronPapules,
                            MichanicHand,
                            XoCungDaDauNgon,
                            XoCungDa,
                            TrieuChungKhac,
                            DauCo,
                            DauCo_ViTri,
                            BopCo,
                            BopCo_ViTri,
                            TeoCo,
                            TeoCo_ViTri,
                            TrieuChungKhop,
                            TrieuChungKhop_Dau,
                            TrieuChungKhop_Sung,
                            TrieuChungKhop_BienDang,
                            TrieuChungKhop_Text,
                            Phoi,
                            Phoi_Text,
                            Tim,
                            Tim_Text,
                            DuongTieuHoa,
                            DuongTieuHoa_Text,
                            Phu,
                            TieuIt,
                            TieuHong,
                            ThanTietNieu_Khac,
                            CongThucMau,
                            MauLang_1h,
                            MauLang_2h,
                            SinhHoa,
                            NuocTieu,
                            CNHH_NgayLam,
                            CNHH_FVC,
                            CNHH_FEV1,
                            CNHH_DLco,
                            CNHH_DuDoanFVC,
                            CNHH_FEV1_FVC,
                            CNHH_DuDoanDLco,
                            XQtp,
                            HRCT_NgayLam,
                            HRCT_Text,
                            SAOBung,
                            Ana,
                            CacTheTuKhangKhac,
                            KhamMat_NgayLam,
                            KhamMat_Text,
                            DienCoKim,
                            SinhThietCo_NgayLam,
                            SinhThietCo_Text,
                            BenhMoLienKet,
                            TieuChuanBatBuoc,
                            PhuBanTay,
                            ViemDaMang,
                            ViemCo,
                            TCLS_HienTuongRaynaud,
                            XoCungDauChi,
                            HoiChungEnzyme,
                            AntiARSDuongTinh,
                            BenhLyPhoiKe,
                            ViemDaCoViemBiCo,
                            ViemKhop,
                            TCP_HienTuongRaynaud,
                            TCP_BanTayThoCoKhi,
                            XoCungBiHeThong,
                            ThuongTonDaVungNgonTay,
                            DayDaNgonTay_1,
                            DayDaNgonTay_2,
                            ThuongTonDauNgon_1,
                            ThuongTonDauNgon_2,
                            GianMach,
                            BatThuongMaoMach,
                            TangApLucDongMach_1,
                            TangApLucDongMach_2,
                            HienTuongRaynauds,
                            Anti_Centromere,
                            Anti_TopoisomeraseI,
                            Anti_RNApolymeraseIII,
                            BieuHienTaiKhop,
                            HuyetThanh,
                            CacYeuToPhanUng,
                            ThoiGianBieuHien,
                            TANIMOTO_1,
                            TANIMOTO_2,
                            TANIMOTO_3,
                            TANIMOTO_4,
                            TANIMOTO_5,
                            TANIMOTO_6,
                            TANIMOTO_7,
                            TANIMOTO_8,
                            TANIMOTO_9,
                            ViemBiCo_1,
                            ViemBiCo_2,
                            ChuY,
                            DieuTri_TaiCho,
                            DieuTri_ToanThan,
                            HenKham,
                            BacSiKhamBenh,
                            TK_SoBenhAnDienTu,
                            TK_SoLuuTru,
                            TK_Sot,
                            TK_Sot_Text,
                            TK_MetMoi,
                            TK_Mach,
                            TK_HuyetAp,
                            TK_HachTo,
                            TK_HachTo_Vitri,
                            TK_TienSu,
                            TK_NTTDDLupusBanDoHT,
                            TK_NTTDDBenhXoCungBi,
                            TK_NTTDDBenhViemDaCo,
                            TK_TonThuongDaKhac,
                            TK_DauCo,
                            TK_DauCo_ViTri,
                            TK_BopCo,
                            TK_BopCo_ViTri,
                            TK_TeoCo,
                            TK_TeoCo_ViTri,
                            TK_TrieuChungCo_Khac,
                            TK_DauKhop,
                            TK_SungKhop,
                            TK_BienDangKhop,
                            TK_Phoi,
                            TK_Phoi_SoVoiLanTruoc,
                            TK_Phoi_Text,
                            TK_Tim,
                            TK_Tim_SoVoiLanTruoc,
                            TK_Tim_Text,
                            TK_DTH,
                            TK_DTH_SoVoiLanTruoc,
                            TK_DTH_Text,
                            TK_CongThucMau,
                            TK_MauLang,
                            TK_SinhHoa,
                            TK_NuocTieu,
                            TK_CacTuKhangThe_LamLaiSau,
                            TK_CacTuKhangThe_KetQua,
                            TK_ChuY,
                            TK_DieuTri_TaiCho,
                            TK_DieuTri_ToanThan,
                            TK_TacDungPhuCuaThuoc,
                            TK_HenKham,
                            TK_BacSiKhamBenh,
                            QuaTrinhBenhLy,
                            TomTatKetQua,
                            BenhChinh,
                            MaBenhChinh,
                            BenhKemTheo,
                            MaBenhKemTheo,
                            PhuongPhapDieuTri,
                            TinhTrangRaVien,
                            HuongDieuTri,
                            NguoiNhanHoSo,
                            NguoiGiaoHoSo,
                            NgayTongKet,
                            TongKet_BacSyDieuTri,
                            TongKet_MaBacSyDieuTri
                        )                 
                        VALUES
                        (
                            :MaQuanLy,
                            :DieuTriNgoaiTruTu,
                            :DieuTriNgoaiTruDen,
                            :SoCMND,
                            :BaoHiem,
                            :ChanDoan_TuyenTruoc,
                            :ChanDoanBanDau,
                            :ChanDoanTaiKham1,
                            :ChanDoanTaiKham2,
                            :ChanDoanTaiKham3,
                            :ChanDoanTaiKham4,
                            :BenhPhu,
                            :KetQuaDieuTri,
                            :BienChung_Text,
                            :GDPhongKeHoach,
                            :GDPhongKhamBenh,
                            :TuoiKhoiPhat,
                            :ThoiGianKhoiPhatBenh,
                            :TrieuChungDauTien,
                            :TienSuCoBenhTuMien,
                            :TienSuCoBenhTuMien_Text,
                            :TSCNBiCacBenhKhac,
                            :TSCNBiCacBenhKhac_Text,
                            :TSGDBenhTuMien,
                            :TSGDBenhTuMien_Text,
                            :BenhSu,
                            :ChuaDieuTri,
                            :NhomThuoc,
                            :DungTrongBaoLau,
                            :TacDungPhuCuaThuoc,
                            :TacDungPhuCuaThuoc_Text,
                            :Sot,
                            :Sot_Text,
                            :MetMoi,
                            :Mach,
                            :HuyetAp,
                            :HachTo,
                            :HachTo_Vitri,
                            :BanCanhBuom,
                            :NhayCamAnhSang,
                            :LoetMieng,
                            :HienTuongRaynaud,
                            :MatPhuNe,
                            :BanHeliotrope,
                            :GottronSign,
                            :GottronPapules,
                            :MichanicHand,
                            :XoCungDaDauNgon,
                            :XoCungDa,
                            :TrieuChungKhac,
                            :DauCo,
                            :DauCo_ViTri,
                            :BopCo,
                            :BopCo_ViTri,
                            :TeoCo,
                            :TeoCo_ViTri,
                            :TrieuChungKhop,
                            :TrieuChungKhop_Dau,
                            :TrieuChungKhop_Sung,
                            :TrieuChungKhop_BienDang,
                            :TrieuChungKhop_Text,
                            :Phoi,
                            :Phoi_Text,
                            :Tim,
                            :Tim_Text,
                            :DuongTieuHoa,
                            :DuongTieuHoa_Text,
                            :Phu,
                            :TieuIt,
                            :TieuHong,
                            :ThanTietNieu_Khac,
                            :CongThucMau,
                            :MauLang_1h,
                            :MauLang_2h,
                            :SinhHoa,
                            :NuocTieu,
                            :CNHH_NgayLam,
                            :CNHH_FVC,
                            :CNHH_FEV1,
                            :CNHH_DLco,
                            :CNHH_DuDoanFVC,
                            :CNHH_FEV1_FVC,
                            :CNHH_DuDoanDLco,
                            :XQtp,
                            :HRCT_NgayLam,
                            :HRCT_Text,
                            :SAOBung,
                            :Ana,
                            :CacTheTuKhangKhac,
                            :KhamMat_NgayLam,
                            :KhamMat_Text,
                            :DienCoKim,
                            :SinhThietCo_NgayLam,
                            :SinhThietCo_Text,
                            :BenhMoLienKet,
                            :TieuChuanBatBuoc,
                            :PhuBanTay,
                            :ViemDaMang,
                            :ViemCo,
                            :TCLS_HienTuongRaynaud,
                            :XoCungDauChi,
                            :HoiChungEnzyme,
                            :AntiARSDuongTinh,
                            :BenhLyPhoiKe,
                            :ViemDaCoViemBiCo,
                            :ViemKhop,
                            :TCP_HienTuongRaynaud,
                            :TCP_BanTayThoCoKhi,
                            :XoCungBiHeThong,
                            :ThuongTonDaVungNgonTay,
                            :DayDaNgonTay_1,
                            :DayDaNgonTay_2,
                            :ThuongTonDauNgon_1,
                            :ThuongTonDauNgon_2,
                            :GianMach,
                            :BatThuongMaoMach,
                            :TangApLucDongMach_1,
                            :TangApLucDongMach_2,
                            :HienTuongRaynauds,
                            :Anti_Centromere,
                            :Anti_TopoisomeraseI,
                            :Anti_RNApolymeraseIII,
                            :BieuHienTaiKhop,
                            :HuyetThanh,
                            :CacYeuToPhanUng,
                            :ThoiGianBieuHien,
                            :TANIMOTO_1,
                            :TANIMOTO_2,
                            :TANIMOTO_3,
                            :TANIMOTO_4,
                            :TANIMOTO_5,
                            :TANIMOTO_6,
                            :TANIMOTO_7,
                            :TANIMOTO_8,
                            :TANIMOTO_9,
                            :ViemBiCo_1,
                            :ViemBiCo_2,
                            :ChuY,
                            :DieuTri_TaiCho,
                            :DieuTri_ToanThan,
                            :HenKham,
                            :BacSiKhamBenh,
                            :TK_SoBenhAnDienTu,
                            :TK_SoLuuTru,
                            :TK_Sot,
                            :TK_Sot_Text,
                            :TK_MetMoi,
                            :TK_Mach,
                            :TK_HuyetAp,
                            :TK_HachTo,
                            :TK_HachTo_Vitri,
                            :TK_TienSu,
                            :TK_NTTDDLupusBanDoHT,
                            :TK_NTTDDBenhXoCungBi,
                            :TK_NTTDDBenhViemDaCo,
                            :TK_TonThuongDaKhac,
                            :TK_DauCo,
                            :TK_DauCo_ViTri,
                            :TK_BopCo,
                            :TK_BopCo_ViTri,
                            :TK_TeoCo,
                            :TK_TeoCo_ViTri,
                            :TK_TrieuChungCo_Khac,
                            :TK_DauKhop,
                            :TK_SungKhop,
                            :TK_BienDangKhop,
                            :TK_Phoi,
                            :TK_Phoi_SoVoiLanTruoc,
                            :TK_Phoi_Text,
                            :TK_Tim,
                            :TK_Tim_SoVoiLanTruoc,
                            :TK_Tim_Text,
                            :TK_DTH,
                            :TK_DTH_SoVoiLanTruoc,
                            :TK_DTH_Text,
                            :TK_CongThucMau,
                            :TK_MauLang,
                            :TK_SinhHoa,
                            :TK_NuocTieu,
                            :TK_CacTuKhangThe_LamLaiSau,
                            :TK_CacTuKhangThe_KetQua,
                            :TK_ChuY,
                            :TK_DieuTri_TaiCho,
                            :TK_DieuTri_ToanThan,
                            :TK_TacDungPhuCuaThuoc,
                            :TK_HenKham,
                            :TK_BacSiKhamBenh,
                            :QuaTrinhBenhLy,
                            :TomTatKetQua,
                            :BenhChinh,
                            :MaBenhChinh,
                            :BenhKemTheo,
                            :MaBenhKemTheo,
                            :PhuongPhapDieuTri,
                            :TinhTrangRaVien,
                            :HuongDieuTri,
                            :NguoiNhanHoSo,
                            :NguoiGiaoHoSo,
                            :NgayTongKet,
                            :TongKet_BacSyDieuTri,
                            :TongKet_MaBacSyDieuTri                          
                        )";
                Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnHoiChungTrungLap.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriNgoaiTruTu", BenhAnHoiChungTrungLap.DieuTriNgoaiTruTu));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriNgoaiTruDen", BenhAnHoiChungTrungLap.DieuTriNgoaiTruDen));
                Command.Parameters.Add(new MDB.MDBParameter("SoCMND", BenhAnHoiChungTrungLap.SoCMND));
                Command.Parameters.Add(new MDB.MDBParameter("BaoHiem", BenhAnHoiChungTrungLap.BaoHiem));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan_TuyenTruoc", BenhAnHoiChungTrungLap.ChanDoan_TuyenTruoc));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanBanDau", BenhAnHoiChungTrungLap.ChanDoanBanDau));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham1", BenhAnHoiChungTrungLap.ChanDoanTaiKham1));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham2", BenhAnHoiChungTrungLap.ChanDoanTaiKham2));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham3", BenhAnHoiChungTrungLap.ChanDoanTaiKham3));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham4", BenhAnHoiChungTrungLap.ChanDoanTaiKham4));
                Command.Parameters.Add(new MDB.MDBParameter("BenhPhu", BenhAnHoiChungTrungLap.BenhPhu));
                Command.Parameters.Add(new MDB.MDBParameter("KetQuaDieuTri", BenhAnHoiChungTrungLap.KetQuaDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("BienChung_Text", BenhAnHoiChungTrungLap.BienChung_Text));
                Command.Parameters.Add(new MDB.MDBParameter("GDPhongKeHoach", BenhAnHoiChungTrungLap.GDPhongKeHoach));
                Command.Parameters.Add(new MDB.MDBParameter("GDPhongKhamBenh", BenhAnHoiChungTrungLap.GDPhongKhamBenh));
                // Hỏi bênh, khám bệnh
                Command.Parameters.Add(new MDB.MDBParameter("TuoiKhoiPhat", BenhAnHoiChungTrungLap.TuoiKhoiPhat));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianKhoiPhatBenh", BenhAnHoiChungTrungLap.ThoiGianKhoiPhatBenh));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungDauTien", BenhAnHoiChungTrungLap.TrieuChungDauTien));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuCoBenhTuMien", BenhAnHoiChungTrungLap.TienSuCoBenhTuMien));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuCoBenhTuMien_Text", BenhAnHoiChungTrungLap.TienSuCoBenhTuMien_Text));
                Command.Parameters.Add(new MDB.MDBParameter("TSCNBiCacBenhKhac", BenhAnHoiChungTrungLap.TSCNBiCacBenhKhac));
                Command.Parameters.Add(new MDB.MDBParameter("TSCNBiCacBenhKhac_Text", BenhAnHoiChungTrungLap.TSCNBiCacBenhKhac_Text));
                Command.Parameters.Add(new MDB.MDBParameter("TSGDBenhTuMien", BenhAnHoiChungTrungLap.TSGDBenhTuMien));
                Command.Parameters.Add(new MDB.MDBParameter("TSGDBenhTuMien_Text", BenhAnHoiChungTrungLap.TSGDBenhTuMien_Text));
                Command.Parameters.Add(new MDB.MDBParameter("BenhSu", BenhAnHoiChungTrungLap.BenhSu));
                Command.Parameters.Add(new MDB.MDBParameter("ChuaDieuTri", BenhAnHoiChungTrungLap.ChuaDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("NhomThuoc", BenhAnHoiChungTrungLap.NhomThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("DungTrongBaoLau", BenhAnHoiChungTrungLap.DungTrongBaoLau));
                Command.Parameters.Add(new MDB.MDBParameter("TacDungPhuCuaThuoc", BenhAnHoiChungTrungLap.TacDungPhuCuaThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("TacDungPhuCuaThuoc_Text", BenhAnHoiChungTrungLap.TacDungPhuCuaThuoc_Text));
                Command.Parameters.Add(new MDB.MDBParameter("Sot", BenhAnHoiChungTrungLap.Sot));
                Command.Parameters.Add(new MDB.MDBParameter("Sot_Text", BenhAnHoiChungTrungLap.Sot_Text));
                Command.Parameters.Add(new MDB.MDBParameter("MetMoi", BenhAnHoiChungTrungLap.MetMoi));
                Command.Parameters.Add(new MDB.MDBParameter("Mach", BenhAnHoiChungTrungLap.Mach));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetAp", BenhAnHoiChungTrungLap.HuyetAp));
                Command.Parameters.Add(new MDB.MDBParameter("HachTo", BenhAnHoiChungTrungLap.HachTo));
                Command.Parameters.Add(new MDB.MDBParameter("HachTo_Vitri", BenhAnHoiChungTrungLap.HachTo_Vitri));
                Command.Parameters.Add(new MDB.MDBParameter("BanCanhBuom", BenhAnHoiChungTrungLap.BanCanhBuom));
                Command.Parameters.Add(new MDB.MDBParameter("NhayCamAnhSang", BenhAnHoiChungTrungLap.NhayCamAnhSang));
                Command.Parameters.Add(new MDB.MDBParameter("LoetMieng", BenhAnHoiChungTrungLap.LoetMieng));
                Command.Parameters.Add(new MDB.MDBParameter("HienTuongRaynaud", BenhAnHoiChungTrungLap.HienTuongRaynaud));
                Command.Parameters.Add(new MDB.MDBParameter("MatPhuNe", BenhAnHoiChungTrungLap.MatPhuNe));
                Command.Parameters.Add(new MDB.MDBParameter("BanHeliotrope", BenhAnHoiChungTrungLap.BanHeliotrope));
                Command.Parameters.Add(new MDB.MDBParameter("GottronSign", BenhAnHoiChungTrungLap.GottronSign));
                Command.Parameters.Add(new MDB.MDBParameter("GottronPapules", BenhAnHoiChungTrungLap.GottronPapules));
                Command.Parameters.Add(new MDB.MDBParameter("MichanicHand", BenhAnHoiChungTrungLap.MichanicHand));
                Command.Parameters.Add(new MDB.MDBParameter("XoCungDaDauNgon", BenhAnHoiChungTrungLap.XoCungDaDauNgon));
                Command.Parameters.Add(new MDB.MDBParameter("XoCungDa", BenhAnHoiChungTrungLap.XoCungDa));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungKhac", BenhAnHoiChungTrungLap.TrieuChungKhac));
                Command.Parameters.Add(new MDB.MDBParameter("DauCo", BenhAnHoiChungTrungLap.DauCo));
                Command.Parameters.Add(new MDB.MDBParameter("DauCo_ViTri", BenhAnHoiChungTrungLap.DauCo_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("BopCo", BenhAnHoiChungTrungLap.BopCo));
                Command.Parameters.Add(new MDB.MDBParameter("BopCo_ViTri", BenhAnHoiChungTrungLap.BopCo_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("TeoCo", BenhAnHoiChungTrungLap.TeoCo));
                Command.Parameters.Add(new MDB.MDBParameter("TeoCo_ViTri", BenhAnHoiChungTrungLap.TeoCo_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungKhop", BenhAnHoiChungTrungLap.TrieuChungKhop));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungKhop_Dau", BenhAnHoiChungTrungLap.TrieuChungKhop_Dau));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungKhop_Sung", BenhAnHoiChungTrungLap.TrieuChungKhop_Sung));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungKhop_BienDang", BenhAnHoiChungTrungLap.TrieuChungKhop_BienDang));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungKhop_Text", BenhAnHoiChungTrungLap.TrieuChungKhop_Text));
                Command.Parameters.Add(new MDB.MDBParameter("Phoi", BenhAnHoiChungTrungLap.Phoi));
                Command.Parameters.Add(new MDB.MDBParameter("Phoi_Text", BenhAnHoiChungTrungLap.Phoi_Text));
                Command.Parameters.Add(new MDB.MDBParameter("Tim", BenhAnHoiChungTrungLap.Tim));
                Command.Parameters.Add(new MDB.MDBParameter("Tim_Text", BenhAnHoiChungTrungLap.Tim_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DuongTieuHoa", BenhAnHoiChungTrungLap.DuongTieuHoa));
                Command.Parameters.Add(new MDB.MDBParameter("DuongTieuHoa_Text", BenhAnHoiChungTrungLap.DuongTieuHoa_Text));
                Command.Parameters.Add(new MDB.MDBParameter("Phu", BenhAnHoiChungTrungLap.Phu));
                Command.Parameters.Add(new MDB.MDBParameter("TieuIt", BenhAnHoiChungTrungLap.TieuIt));
                Command.Parameters.Add(new MDB.MDBParameter("TieuHong", BenhAnHoiChungTrungLap.TieuHong));
                Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieu_Khac", BenhAnHoiChungTrungLap.ThanTietNieu_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("CongThucMau", BenhAnHoiChungTrungLap.CongThucMau));
                Command.Parameters.Add(new MDB.MDBParameter("MauLang_1h", BenhAnHoiChungTrungLap.MauLang_1h));
                Command.Parameters.Add(new MDB.MDBParameter("MauLang_2h", BenhAnHoiChungTrungLap.MauLang_2h));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoa", BenhAnHoiChungTrungLap.SinhHoa));
                Command.Parameters.Add(new MDB.MDBParameter("NuocTieu", BenhAnHoiChungTrungLap.NuocTieu));
                Command.Parameters.Add(new MDB.MDBParameter("CNHH_NgayLam", BenhAnHoiChungTrungLap.CNHH_NgayLam));
                Command.Parameters.Add(new MDB.MDBParameter("CNHH_FVC", BenhAnHoiChungTrungLap.CNHH_FVC));
                Command.Parameters.Add(new MDB.MDBParameter("CNHH_FEV1", BenhAnHoiChungTrungLap.CNHH_FEV1));
                Command.Parameters.Add(new MDB.MDBParameter("CNHH_DLco", BenhAnHoiChungTrungLap.CNHH_DLco));
                Command.Parameters.Add(new MDB.MDBParameter("CNHH_DuDoanFVC", BenhAnHoiChungTrungLap.CNHH_DuDoanFVC));
                Command.Parameters.Add(new MDB.MDBParameter("CNHH_FEV1_FVC", BenhAnHoiChungTrungLap.CNHH_FEV1_FVC));
                Command.Parameters.Add(new MDB.MDBParameter("CNHH_DuDoanDLco", BenhAnHoiChungTrungLap.CNHH_DuDoanDLco));
                Command.Parameters.Add(new MDB.MDBParameter("XQtp", BenhAnHoiChungTrungLap.XQtp));
                Command.Parameters.Add(new MDB.MDBParameter("HRCT_NgayLam", BenhAnHoiChungTrungLap.HRCT_NgayLam));
                Command.Parameters.Add(new MDB.MDBParameter("HRCT_Text", BenhAnHoiChungTrungLap.HRCT_Text));
                Command.Parameters.Add(new MDB.MDBParameter("SAOBung", BenhAnHoiChungTrungLap.SAOBung));
                Command.Parameters.Add(new MDB.MDBParameter("Ana", BenhAnHoiChungTrungLap.Ana));
                Command.Parameters.Add(new MDB.MDBParameter("CacTheTuKhangKhac", BenhAnHoiChungTrungLap.CacTheTuKhangKhac));
                Command.Parameters.Add(new MDB.MDBParameter("KhamMat_NgayLam", BenhAnHoiChungTrungLap.KhamMat_NgayLam));
                Command.Parameters.Add(new MDB.MDBParameter("KhamMat_Text", BenhAnHoiChungTrungLap.KhamMat_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DienCoKim", BenhAnHoiChungTrungLap.DienCoKim));
                Command.Parameters.Add(new MDB.MDBParameter("SinhThietCo_NgayLam", BenhAnHoiChungTrungLap.SinhThietCo_NgayLam));
                Command.Parameters.Add(new MDB.MDBParameter("SinhThietCo_Text", BenhAnHoiChungTrungLap.SinhThietCo_Text));
                Command.Parameters.Add(new MDB.MDBParameter("BenhMoLienKet", BenhAnHoiChungTrungLap.BenhMoLienKet));
                Command.Parameters.Add(new MDB.MDBParameter("TieuChuanBatBuoc", BenhAnHoiChungTrungLap.TieuChuanBatBuoc));
                Command.Parameters.Add(new MDB.MDBParameter("PhuBanTay", BenhAnHoiChungTrungLap.PhuBanTay));
                Command.Parameters.Add(new MDB.MDBParameter("ViemDaMang", BenhAnHoiChungTrungLap.ViemDaMang));
                Command.Parameters.Add(new MDB.MDBParameter("ViemCo", BenhAnHoiChungTrungLap.ViemCo));
                Command.Parameters.Add(new MDB.MDBParameter("TCLS_HienTuongRaynaud", BenhAnHoiChungTrungLap.TCLS_HienTuongRaynaud));
                Command.Parameters.Add(new MDB.MDBParameter("XoCungDauChi", BenhAnHoiChungTrungLap.XoCungDauChi));
                Command.Parameters.Add(new MDB.MDBParameter("HoiChungEnzyme", BenhAnHoiChungTrungLap.HoiChungEnzyme));
                Command.Parameters.Add(new MDB.MDBParameter("AntiARSDuongTinh", BenhAnHoiChungTrungLap.AntiARSDuongTinh));
                Command.Parameters.Add(new MDB.MDBParameter("BenhLyPhoiKe", BenhAnHoiChungTrungLap.BenhLyPhoiKe));
                Command.Parameters.Add(new MDB.MDBParameter("ViemDaCoViemBiCo", BenhAnHoiChungTrungLap.ViemDaCoViemBiCo));
                Command.Parameters.Add(new MDB.MDBParameter("ViemKhop", BenhAnHoiChungTrungLap.ViemKhop));
                Command.Parameters.Add(new MDB.MDBParameter("TCP_HienTuongRaynaud", BenhAnHoiChungTrungLap.TCP_HienTuongRaynaud));
                Command.Parameters.Add(new MDB.MDBParameter("TCP_BanTayThoCoKhi", BenhAnHoiChungTrungLap.TCP_BanTayThoCoKhi));
                Command.Parameters.Add(new MDB.MDBParameter("XoCungBiHeThong", BenhAnHoiChungTrungLap.XoCungBiHeThong));
                Command.Parameters.Add(new MDB.MDBParameter("ThuongTonDaVungNgonTay", BenhAnHoiChungTrungLap.ThuongTonDaVungNgonTay));
                Command.Parameters.Add(new MDB.MDBParameter("DayDaNgonTay_1", BenhAnHoiChungTrungLap.DayDaNgonTay_1));
                Command.Parameters.Add(new MDB.MDBParameter("DayDaNgonTay_2", BenhAnHoiChungTrungLap.DayDaNgonTay_2));
                Command.Parameters.Add(new MDB.MDBParameter("ThuongTonDauNgon_1", BenhAnHoiChungTrungLap.ThuongTonDauNgon_1));
                Command.Parameters.Add(new MDB.MDBParameter("ThuongTonDauNgon_2", BenhAnHoiChungTrungLap.ThuongTonDauNgon_2));
                Command.Parameters.Add(new MDB.MDBParameter("GianMach", BenhAnHoiChungTrungLap.GianMach));
                Command.Parameters.Add(new MDB.MDBParameter("BatThuongMaoMach", BenhAnHoiChungTrungLap.BatThuongMaoMach));
                Command.Parameters.Add(new MDB.MDBParameter("TangApLucDongMach_1", BenhAnHoiChungTrungLap.TangApLucDongMach_1));
                Command.Parameters.Add(new MDB.MDBParameter("TangApLucDongMach_2", BenhAnHoiChungTrungLap.TangApLucDongMach_2));
                Command.Parameters.Add(new MDB.MDBParameter("HienTuongRaynauds", BenhAnHoiChungTrungLap.HienTuongRaynauds));
                Command.Parameters.Add(new MDB.MDBParameter("Anti_Centromere", BenhAnHoiChungTrungLap.Anti_Centromere));
                Command.Parameters.Add(new MDB.MDBParameter("Anti_TopoisomeraseI", BenhAnHoiChungTrungLap.Anti_TopoisomeraseI));
                Command.Parameters.Add(new MDB.MDBParameter("Anti_RNApolymeraseIII", BenhAnHoiChungTrungLap.Anti_RNApolymeraseIII));
                Command.Parameters.Add(new MDB.MDBParameter("BieuHienTaiKhop", BenhAnHoiChungTrungLap.BieuHienTaiKhop));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetThanh", BenhAnHoiChungTrungLap.HuyetThanh));
                Command.Parameters.Add(new MDB.MDBParameter("CacYeuToPhanUng", BenhAnHoiChungTrungLap.CacYeuToPhanUng));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianBieuHien", BenhAnHoiChungTrungLap.ThoiGianBieuHien));
                Command.Parameters.Add(new MDB.MDBParameter("TANIMOTO_1", BenhAnHoiChungTrungLap.TANIMOTO_1));
                Command.Parameters.Add(new MDB.MDBParameter("TANIMOTO_2", BenhAnHoiChungTrungLap.TANIMOTO_2));
                Command.Parameters.Add(new MDB.MDBParameter("TANIMOTO_3", BenhAnHoiChungTrungLap.TANIMOTO_3));
                Command.Parameters.Add(new MDB.MDBParameter("TANIMOTO_4", BenhAnHoiChungTrungLap.TANIMOTO_4));
                Command.Parameters.Add(new MDB.MDBParameter("TANIMOTO_5", BenhAnHoiChungTrungLap.TANIMOTO_5));
                Command.Parameters.Add(new MDB.MDBParameter("TANIMOTO_6", BenhAnHoiChungTrungLap.TANIMOTO_6));
                Command.Parameters.Add(new MDB.MDBParameter("TANIMOTO_7", BenhAnHoiChungTrungLap.TANIMOTO_7));
                Command.Parameters.Add(new MDB.MDBParameter("TANIMOTO_8", BenhAnHoiChungTrungLap.TANIMOTO_8));
                Command.Parameters.Add(new MDB.MDBParameter("TANIMOTO_9", BenhAnHoiChungTrungLap.TANIMOTO_9));
                Command.Parameters.Add(new MDB.MDBParameter("ViemBiCo_1", BenhAnHoiChungTrungLap.ViemBiCo_1));
                Command.Parameters.Add(new MDB.MDBParameter("ViemBiCo_2", BenhAnHoiChungTrungLap.ViemBiCo_2));
                Command.Parameters.Add(new MDB.MDBParameter("ChuY", BenhAnHoiChungTrungLap.ChuY));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_TaiCho", BenhAnHoiChungTrungLap.DieuTri_TaiCho));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_ToanThan", BenhAnHoiChungTrungLap.DieuTri_ToanThan));
                Command.Parameters.Add(new MDB.MDBParameter("HenKham", BenhAnHoiChungTrungLap.HenKham));
                Command.Parameters.Add(new MDB.MDBParameter("BacSiKhamBenh", BenhAnHoiChungTrungLap.BacSiKhamBenh));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SoBenhAnDienTu", BenhAnHoiChungTrungLap.TK_SoBenhAnDienTu));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SoLuuTru", BenhAnHoiChungTrungLap.TK_SoLuuTru));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Sot", BenhAnHoiChungTrungLap.TK_Sot));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Sot_Text", BenhAnHoiChungTrungLap.TK_Sot_Text));
                Command.Parameters.Add(new MDB.MDBParameter("TK_MetMoi", BenhAnHoiChungTrungLap.TK_MetMoi));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Mach", BenhAnHoiChungTrungLap.TK_Mach));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HuyetAp", BenhAnHoiChungTrungLap.TK_HuyetAp));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HachTo", BenhAnHoiChungTrungLap.TK_HachTo));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HachTo_Vitri", BenhAnHoiChungTrungLap.TK_HachTo_Vitri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TienSu", BenhAnHoiChungTrungLap.TK_TienSu));
                Command.Parameters.Add(new MDB.MDBParameter("TK_NTTDDLupusBanDoHT", BenhAnHoiChungTrungLap.TK_NTTDDLupusBanDoHT));
                Command.Parameters.Add(new MDB.MDBParameter("TK_NTTDDBenhXoCungBi", BenhAnHoiChungTrungLap.TK_NTTDDBenhXoCungBi));
                Command.Parameters.Add(new MDB.MDBParameter("TK_NTTDDBenhViemDaCo", BenhAnHoiChungTrungLap.TK_NTTDDBenhViemDaCo));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TonThuongDaKhac", BenhAnHoiChungTrungLap.TK_TonThuongDaKhac));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DauCo", BenhAnHoiChungTrungLap.TK_DauCo));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DauCo_ViTri", BenhAnHoiChungTrungLap.TK_DauCo_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_BopCo", BenhAnHoiChungTrungLap.TK_BopCo));
                Command.Parameters.Add(new MDB.MDBParameter("TK_BopCo_ViTri", BenhAnHoiChungTrungLap.TK_BopCo_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TeoCo", BenhAnHoiChungTrungLap.TK_TeoCo));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TeoCo_ViTri", BenhAnHoiChungTrungLap.TK_TeoCo_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TrieuChungCo_Khac", BenhAnHoiChungTrungLap.TK_TrieuChungCo_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DauKhop", BenhAnHoiChungTrungLap.TK_DauKhop));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SungKhop", BenhAnHoiChungTrungLap.TK_SungKhop));
                Command.Parameters.Add(new MDB.MDBParameter("TK_BienDangKhop", BenhAnHoiChungTrungLap.TK_BienDangKhop));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Phoi", BenhAnHoiChungTrungLap.TK_Phoi));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Phoi_SoVoiLanTruoc", BenhAnHoiChungTrungLap.TK_Phoi_SoVoiLanTruoc));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Phoi_Text", BenhAnHoiChungTrungLap.TK_Phoi_Text));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Tim", BenhAnHoiChungTrungLap.TK_Tim));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Tim_SoVoiLanTruoc", BenhAnHoiChungTrungLap.TK_Tim_SoVoiLanTruoc));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Tim_Text", BenhAnHoiChungTrungLap.TK_Tim_Text));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DTH", BenhAnHoiChungTrungLap.TK_DTH));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DTH_SoVoiLanTruoc", BenhAnHoiChungTrungLap.TK_DTH_SoVoiLanTruoc));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DTH_Text", BenhAnHoiChungTrungLap.TK_DTH_Text));
                Command.Parameters.Add(new MDB.MDBParameter("TK_CongThucMau", BenhAnHoiChungTrungLap.TK_CongThucMau));
                Command.Parameters.Add(new MDB.MDBParameter("TK_MauLang", BenhAnHoiChungTrungLap.TK_MauLang));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa", BenhAnHoiChungTrungLap.TK_SinhHoa));
                Command.Parameters.Add(new MDB.MDBParameter("TK_NuocTieu", BenhAnHoiChungTrungLap.TK_NuocTieu));
                Command.Parameters.Add(new MDB.MDBParameter("TK_CacTuKhangThe_LamLaiSau", BenhAnHoiChungTrungLap.TK_CacTuKhangThe_LamLaiSau));
                Command.Parameters.Add(new MDB.MDBParameter("TK_CacTuKhangThe_KetQua", BenhAnHoiChungTrungLap.TK_CacTuKhangThe_KetQua));
                Command.Parameters.Add(new MDB.MDBParameter("TK_ChuY", BenhAnHoiChungTrungLap.TK_ChuY));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DieuTri_TaiCho", BenhAnHoiChungTrungLap.TK_DieuTri_TaiCho));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DieuTri_ToanThan", BenhAnHoiChungTrungLap.TK_DieuTri_ToanThan));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TacDungPhuCuaThuoc", BenhAnHoiChungTrungLap.TK_TacDungPhuCuaThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HenKham", BenhAnHoiChungTrungLap.TK_HenKham));
                Command.Parameters.Add(new MDB.MDBParameter("TK_BacSiKhamBenh", BenhAnHoiChungTrungLap.TK_BacSiKhamBenh));



                // Tổng kết
                Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnHoiChungTrungLap.QuaTrinhBenhLy));
                Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQua", BenhAnHoiChungTrungLap.TomTatKetQua));
                Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnHoiChungTrungLap.BenhChinh));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhChinh", BenhAnHoiChungTrungLap.MaBenhChinh));
                Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnHoiChungTrungLap.BenhKemTheo));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhKemTheo", BenhAnHoiChungTrungLap.MaBenhKemTheo));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnHoiChungTrungLap.PhuongPhapDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangRaVien", BenhAnHoiChungTrungLap.TinhTrangRaVien));
                Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnHoiChungTrungLap.HuongDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnHoiChungTrungLap.NguoiNhanHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnHoiChungTrungLap.NguoiGiaoHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnHoiChungTrungLap.NgayTongKet));
                Command.Parameters.Add(new MDB.MDBParameter("TongKet_BacSyDieuTri", BenhAnHoiChungTrungLap.TongKet_BacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TongKet_MaBacSyDieuTri", BenhAnHoiChungTrungLap.TongKet_MaBacSyDieuTri));


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
        public static bool Update(MDB.MDBConnection MyConnection, BenhAnNgoaiTru_HoiChungTrungLap BenhAnHoiChungTrungLap)
        {
            try
            {
                string sql = @"UPDATE BenhAnHoiChungTrungLap SET 
                            DieuTriNgoaiTruTu=:DieuTriNgoaiTruTu,
                            DieuTriNgoaiTruDen=:DieuTriNgoaiTruDen,
                            SoCMND=:SoCMND,
                            BaoHiem=:BaoHiem,
                            ChanDoan_TuyenTruoc=:ChanDoan_TuyenTruoc,
                            ChanDoanBanDau=:ChanDoanBanDau,
                            ChanDoanTaiKham1=:ChanDoanTaiKham1,
                            ChanDoanTaiKham2=:ChanDoanTaiKham2,
                            ChanDoanTaiKham3=:ChanDoanTaiKham3,
                            ChanDoanTaiKham4=:ChanDoanTaiKham4,
                            BenhPhu=:BenhPhu,
                            KetQuaDieuTri=:KetQuaDieuTri,
                            BienChung_Text=:BienChung_Text,
                            GDPhongKeHoach=:GDPhongKeHoach,
                            GDPhongKhamBenh=:GDPhongKhamBenh,
                            TuoiKhoiPhat=:TuoiKhoiPhat,
                            ThoiGianKhoiPhatBenh=:ThoiGianKhoiPhatBenh,
                            TrieuChungDauTien=:TrieuChungDauTien,
                            TienSuCoBenhTuMien=:TienSuCoBenhTuMien,
                            TienSuCoBenhTuMien_Text=:TienSuCoBenhTuMien_Text,
                            TSCNBiCacBenhKhac=:TSCNBiCacBenhKhac,
                            TSCNBiCacBenhKhac_Text=:TSCNBiCacBenhKhac_Text,
                            TSGDBenhTuMien=:TSGDBenhTuMien,
                            TSGDBenhTuMien_Text=:TSGDBenhTuMien_Text,
                            BenhSu=:BenhSu,
                            ChuaDieuTri=:ChuaDieuTri,
                            NhomThuoc=:NhomThuoc,
                            DungTrongBaoLau=:DungTrongBaoLau,
                            TacDungPhuCuaThuoc=:TacDungPhuCuaThuoc,
                            TacDungPhuCuaThuoc_Text=:TacDungPhuCuaThuoc_Text,
                            Sot=:Sot,
                            Sot_Text=:Sot_Text,
                            MetMoi=:MetMoi,
                            Mach=:Mach,
                            HuyetAp=:HuyetAp,
                            HachTo=:HachTo,
                            HachTo_Vitri=:HachTo_Vitri,
                            BanCanhBuom=:BanCanhBuom,
                            NhayCamAnhSang=:NhayCamAnhSang,
                            LoetMieng=:LoetMieng,
                            HienTuongRaynaud=:HienTuongRaynaud,
                            MatPhuNe=:MatPhuNe,
                            BanHeliotrope=:BanHeliotrope,
                            GottronSign=:GottronSign,
                            GottronPapules=:GottronPapules,
                            MichanicHand=:MichanicHand,
                            XoCungDaDauNgon=:XoCungDaDauNgon,
                            XoCungDa=:XoCungDa,
                            TrieuChungKhac=:TrieuChungKhac,
                            DauCo=:DauCo,
                            DauCo_ViTri=:DauCo_ViTri,
                            BopCo=:BopCo,
                            BopCo_ViTri=:BopCo_ViTri,
                            TeoCo=:TeoCo,
                            TeoCo_ViTri=:TeoCo_ViTri,
                            TrieuChungKhop=:TrieuChungKhop,
                            TrieuChungKhop_Dau=:TrieuChungKhop_Dau,
                            TrieuChungKhop_Sung=:TrieuChungKhop_Sung,
                            TrieuChungKhop_BienDang=:TrieuChungKhop_BienDang,
                            TrieuChungKhop_Text=:TrieuChungKhop_Text,
                            Phoi=:Phoi,
                            Phoi_Text=:Phoi_Text,
                            Tim=:Tim,
                            Tim_Text=:Tim_Text,
                            DuongTieuHoa=:DuongTieuHoa,
                            DuongTieuHoa_Text=:DuongTieuHoa_Text,
                            Phu=:Phu,
                            TieuIt=:TieuIt,
                            TieuHong=:TieuHong,
                            ThanTietNieu_Khac=:ThanTietNieu_Khac,
                            CongThucMau=:CongThucMau,
                            MauLang_1h=:MauLang_1h,
                            MauLang_2h=:MauLang_2h,
                            SinhHoa=:SinhHoa,
                            NuocTieu=:NuocTieu,
                            CNHH_NgayLam=:CNHH_NgayLam,
                            CNHH_FVC=:CNHH_FVC,
                            CNHH_FEV1=:CNHH_FEV1,
                            CNHH_DLco=:CNHH_DLco,
                            CNHH_DuDoanFVC=:CNHH_DuDoanFVC,
                            CNHH_FEV1_FVC=:CNHH_FEV1_FVC,
                            CNHH_DuDoanDLco=:CNHH_DuDoanDLco,
                            XQtp=:XQtp,
                            HRCT_NgayLam=:HRCT_NgayLam,
                            HRCT_Text=:HRCT_Text,
                            SAOBung=:SAOBung,
                            Ana=:Ana,
                            CacTheTuKhangKhac=:CacTheTuKhangKhac,
                            KhamMat_NgayLam=:KhamMat_NgayLam,
                            KhamMat_Text=:KhamMat_Text,
                            DienCoKim=:DienCoKim,
                            SinhThietCo_NgayLam=:SinhThietCo_NgayLam,
                            SinhThietCo_Text=:SinhThietCo_Text,
                            BenhMoLienKet=:BenhMoLienKet,
                            TieuChuanBatBuoc=:TieuChuanBatBuoc,
                            PhuBanTay=:PhuBanTay,
                            ViemDaMang=:ViemDaMang,
                            ViemCo=:ViemCo,
                            TCLS_HienTuongRaynaud=:TCLS_HienTuongRaynaud,
                            XoCungDauChi=:XoCungDauChi,
                            HoiChungEnzyme=:HoiChungEnzyme,
                            AntiARSDuongTinh=:AntiARSDuongTinh,
                            BenhLyPhoiKe=:BenhLyPhoiKe,
                            ViemDaCoViemBiCo=:ViemDaCoViemBiCo,
                            ViemKhop=:ViemKhop,
                            TCP_HienTuongRaynaud=:TCP_HienTuongRaynaud,
                            TCP_BanTayThoCoKhi=:TCP_BanTayThoCoKhi,
                            XoCungBiHeThong=:XoCungBiHeThong,
                            ThuongTonDaVungNgonTay=:ThuongTonDaVungNgonTay,
                            DayDaNgonTay_1=:DayDaNgonTay_1,
                            DayDaNgonTay_2=:DayDaNgonTay_2,
                            ThuongTonDauNgon_1=:ThuongTonDauNgon_1,
                            ThuongTonDauNgon_2=:ThuongTonDauNgon_2,
                            GianMach=:GianMach,
                            BatThuongMaoMach=:BatThuongMaoMach,
                            TangApLucDongMach_1=:TangApLucDongMach_1,
                            TangApLucDongMach_2=:TangApLucDongMach_2,
                            HienTuongRaynauds=:HienTuongRaynauds,
                            Anti_Centromere=:Anti_Centromere,
                            Anti_TopoisomeraseI=:Anti_TopoisomeraseI,
                            Anti_RNApolymeraseIII=:Anti_RNApolymeraseIII,
                            BieuHienTaiKhop=:BieuHienTaiKhop,
                            HuyetThanh=:HuyetThanh,
                            CacYeuToPhanUng=:CacYeuToPhanUng,
                            ThoiGianBieuHien=:ThoiGianBieuHien,
                            TANIMOTO_1=:TANIMOTO_1,
                            TANIMOTO_2=:TANIMOTO_2,
                            TANIMOTO_3=:TANIMOTO_3,
                            TANIMOTO_4=:TANIMOTO_4,
                            TANIMOTO_5=:TANIMOTO_5,
                            TANIMOTO_6=:TANIMOTO_6,
                            TANIMOTO_7=:TANIMOTO_7,
                            TANIMOTO_8=:TANIMOTO_8,
                            TANIMOTO_9=:TANIMOTO_9,
                            ViemBiCo_1=:ViemBiCo_1,
                            ViemBiCo_2=:ViemBiCo_2,
                            ChuY=:ChuY,
                            DieuTri_TaiCho=:DieuTri_TaiCho,
                            DieuTri_ToanThan=:DieuTri_ToanThan,
                            HenKham=:HenKham,
                            BacSiKhamBenh=:BacSiKhamBenh,
                            TK_SoBenhAnDienTu=:TK_SoBenhAnDienTu,
                            TK_SoLuuTru=:TK_SoLuuTru,
                            TK_Sot=:TK_Sot,
                            TK_Sot_Text=:TK_Sot_Text,
                            TK_MetMoi=:TK_MetMoi,
                            TK_Mach=:TK_Mach,
                            TK_HuyetAp=:TK_HuyetAp,
                            TK_HachTo=:TK_HachTo,
                            TK_HachTo_Vitri=:TK_HachTo_Vitri,
                            TK_TienSu=:TK_TienSu,
                            TK_NTTDDLupusBanDoHT=:TK_NTTDDLupusBanDoHT,
                            TK_NTTDDBenhXoCungBi=:TK_NTTDDBenhXoCungBi,
                            TK_NTTDDBenhViemDaCo=:TK_NTTDDBenhViemDaCo,
                            TK_TonThuongDaKhac=:TK_TonThuongDaKhac,
                            TK_DauCo=:TK_DauCo,
                            TK_DauCo_ViTri=:TK_DauCo_ViTri,
                            TK_BopCo=:TK_BopCo,
                            TK_BopCo_ViTri=:TK_BopCo_ViTri,
                            TK_TeoCo=:TK_TeoCo,
                            TK_TeoCo_ViTri=:TK_TeoCo_ViTri,
                            TK_TrieuChungCo_Khac=:TK_TrieuChungCo_Khac,
                            TK_DauKhop=:TK_DauKhop,
                            TK_SungKhop=:TK_SungKhop,
                            TK_BienDangKhop=:TK_BienDangKhop,
                            TK_Phoi=:TK_Phoi,
                            TK_Phoi_SoVoiLanTruoc=:TK_Phoi_SoVoiLanTruoc,
                            TK_Phoi_Text=:TK_Phoi_Text,
                            TK_Tim=:TK_Tim,
                            TK_Tim_SoVoiLanTruoc=:TK_Tim_SoVoiLanTruoc,
                            TK_Tim_Text=:TK_Tim_Text,
                            TK_DTH=:TK_DTH,
                            TK_DTH_SoVoiLanTruoc=:TK_DTH_SoVoiLanTruoc,
                            TK_DTH_Text=:TK_DTH_Text,
                            TK_CongThucMau=:TK_CongThucMau,
                            TK_MauLang=:TK_MauLang,
                            TK_SinhHoa=:TK_SinhHoa,
                            TK_NuocTieu=:TK_NuocTieu,
                            TK_CacTuKhangThe_LamLaiSau=:TK_CacTuKhangThe_LamLaiSau,
                            TK_CacTuKhangThe_KetQua=:TK_CacTuKhangThe_KetQua,
                            TK_ChuY=:TK_ChuY,
                            TK_DieuTri_TaiCho=:TK_DieuTri_TaiCho,
                            TK_DieuTri_ToanThan=:TK_DieuTri_ToanThan,
                            TK_TacDungPhuCuaThuoc=:TK_TacDungPhuCuaThuoc,
                            TK_HenKham=:TK_HenKham,
                            TK_BacSiKhamBenh=:TK_BacSiKhamBenh,
                            QuaTrinhBenhLy=:QuaTrinhBenhLy,
                            TomTatKetQua=:TomTatKetQua,
                            BenhChinh=:BenhChinh,
                            MaBenhChinh=:MaBenhChinh,
                            BenhKemTheo=:BenhKemTheo,
                            MaBenhKemTheo=:MaBenhKemTheo,
                            PhuongPhapDieuTri=:PhuongPhapDieuTri,
                            TinhTrangRaVien=:TinhTrangRaVien,
                            HuongDieuTri=:HuongDieuTri,
                            NguoiNhanHoSo=:NguoiNhanHoSo,
                            NguoiGiaoHoSo=:NguoiGiaoHoSo,
                            NgayTongKet=:NgayTongKet,
                            TongKet_BacSyDieuTri=:TongKet_BacSyDieuTri,
                            TongKet_MaBacSyDieuTri=:TongKet_MaBacSyDieuTri 
                            WHERE MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriNgoaiTruTu", BenhAnHoiChungTrungLap.DieuTriNgoaiTruTu));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriNgoaiTruDen", BenhAnHoiChungTrungLap.DieuTriNgoaiTruDen));
                Command.Parameters.Add(new MDB.MDBParameter("SoCMND", BenhAnHoiChungTrungLap.SoCMND));
                Command.Parameters.Add(new MDB.MDBParameter("BaoHiem", BenhAnHoiChungTrungLap.BaoHiem));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan_TuyenTruoc", BenhAnHoiChungTrungLap.ChanDoan_TuyenTruoc));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanBanDau", BenhAnHoiChungTrungLap.ChanDoanBanDau));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham1", BenhAnHoiChungTrungLap.ChanDoanTaiKham1));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham2", BenhAnHoiChungTrungLap.ChanDoanTaiKham2));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham3", BenhAnHoiChungTrungLap.ChanDoanTaiKham3));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham4", BenhAnHoiChungTrungLap.ChanDoanTaiKham4));
                Command.Parameters.Add(new MDB.MDBParameter("BenhPhu", BenhAnHoiChungTrungLap.BenhPhu));
                Command.Parameters.Add(new MDB.MDBParameter("KetQuaDieuTri", BenhAnHoiChungTrungLap.KetQuaDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("BienChung_Text", BenhAnHoiChungTrungLap.BienChung_Text));
                Command.Parameters.Add(new MDB.MDBParameter("GDPhongKeHoach", BenhAnHoiChungTrungLap.GDPhongKeHoach));
                Command.Parameters.Add(new MDB.MDBParameter("GDPhongKhamBenh", BenhAnHoiChungTrungLap.GDPhongKhamBenh));
                // hỏi bệnh, khám bệnh
                Command.Parameters.Add(new MDB.MDBParameter("TuoiKhoiPhat", BenhAnHoiChungTrungLap.TuoiKhoiPhat));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianKhoiPhatBenh", BenhAnHoiChungTrungLap.ThoiGianKhoiPhatBenh));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungDauTien", BenhAnHoiChungTrungLap.TrieuChungDauTien));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuCoBenhTuMien", BenhAnHoiChungTrungLap.TienSuCoBenhTuMien));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuCoBenhTuMien_Text", BenhAnHoiChungTrungLap.TienSuCoBenhTuMien_Text));
                Command.Parameters.Add(new MDB.MDBParameter("TSCNBiCacBenhKhac", BenhAnHoiChungTrungLap.TSCNBiCacBenhKhac));
                Command.Parameters.Add(new MDB.MDBParameter("TSCNBiCacBenhKhac_Text", BenhAnHoiChungTrungLap.TSCNBiCacBenhKhac_Text));
                Command.Parameters.Add(new MDB.MDBParameter("TSGDBenhTuMien", BenhAnHoiChungTrungLap.TSGDBenhTuMien));
                Command.Parameters.Add(new MDB.MDBParameter("TSGDBenhTuMien_Text", BenhAnHoiChungTrungLap.TSGDBenhTuMien_Text));
                Command.Parameters.Add(new MDB.MDBParameter("BenhSu", BenhAnHoiChungTrungLap.BenhSu));
                Command.Parameters.Add(new MDB.MDBParameter("ChuaDieuTri", BenhAnHoiChungTrungLap.ChuaDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("NhomThuoc", BenhAnHoiChungTrungLap.NhomThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("DungTrongBaoLau", BenhAnHoiChungTrungLap.DungTrongBaoLau));
                Command.Parameters.Add(new MDB.MDBParameter("TacDungPhuCuaThuoc", BenhAnHoiChungTrungLap.TacDungPhuCuaThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("TacDungPhuCuaThuoc_Text", BenhAnHoiChungTrungLap.TacDungPhuCuaThuoc_Text));
                Command.Parameters.Add(new MDB.MDBParameter("Sot", BenhAnHoiChungTrungLap.Sot));
                Command.Parameters.Add(new MDB.MDBParameter("Sot_Text", BenhAnHoiChungTrungLap.Sot_Text));
                Command.Parameters.Add(new MDB.MDBParameter("MetMoi", BenhAnHoiChungTrungLap.MetMoi));
                Command.Parameters.Add(new MDB.MDBParameter("Mach", BenhAnHoiChungTrungLap.Mach));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetAp", BenhAnHoiChungTrungLap.HuyetAp));
                Command.Parameters.Add(new MDB.MDBParameter("HachTo", BenhAnHoiChungTrungLap.HachTo));
                Command.Parameters.Add(new MDB.MDBParameter("HachTo_Vitri", BenhAnHoiChungTrungLap.HachTo_Vitri));
                Command.Parameters.Add(new MDB.MDBParameter("BanCanhBuom", BenhAnHoiChungTrungLap.BanCanhBuom));
                Command.Parameters.Add(new MDB.MDBParameter("NhayCamAnhSang", BenhAnHoiChungTrungLap.NhayCamAnhSang));
                Command.Parameters.Add(new MDB.MDBParameter("LoetMieng", BenhAnHoiChungTrungLap.LoetMieng));
                Command.Parameters.Add(new MDB.MDBParameter("HienTuongRaynaud", BenhAnHoiChungTrungLap.HienTuongRaynaud));
                Command.Parameters.Add(new MDB.MDBParameter("MatPhuNe", BenhAnHoiChungTrungLap.MatPhuNe));
                Command.Parameters.Add(new MDB.MDBParameter("BanHeliotrope", BenhAnHoiChungTrungLap.BanHeliotrope));
                Command.Parameters.Add(new MDB.MDBParameter("GottronSign", BenhAnHoiChungTrungLap.GottronSign));
                Command.Parameters.Add(new MDB.MDBParameter("GottronPapules", BenhAnHoiChungTrungLap.GottronPapules));
                Command.Parameters.Add(new MDB.MDBParameter("MichanicHand", BenhAnHoiChungTrungLap.MichanicHand));
                Command.Parameters.Add(new MDB.MDBParameter("XoCungDaDauNgon", BenhAnHoiChungTrungLap.XoCungDaDauNgon));
                Command.Parameters.Add(new MDB.MDBParameter("XoCungDa", BenhAnHoiChungTrungLap.XoCungDa));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungKhac", BenhAnHoiChungTrungLap.TrieuChungKhac));
                Command.Parameters.Add(new MDB.MDBParameter("DauCo", BenhAnHoiChungTrungLap.DauCo));
                Command.Parameters.Add(new MDB.MDBParameter("DauCo_ViTri", BenhAnHoiChungTrungLap.DauCo_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("BopCo", BenhAnHoiChungTrungLap.BopCo));
                Command.Parameters.Add(new MDB.MDBParameter("BopCo_ViTri", BenhAnHoiChungTrungLap.BopCo_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("TeoCo", BenhAnHoiChungTrungLap.TeoCo));
                Command.Parameters.Add(new MDB.MDBParameter("TeoCo_ViTri", BenhAnHoiChungTrungLap.TeoCo_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungKhop", BenhAnHoiChungTrungLap.TrieuChungKhop));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungKhop_Dau", BenhAnHoiChungTrungLap.TrieuChungKhop_Dau));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungKhop_Sung", BenhAnHoiChungTrungLap.TrieuChungKhop_Sung));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungKhop_BienDang", BenhAnHoiChungTrungLap.TrieuChungKhop_BienDang));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungKhop_Text", BenhAnHoiChungTrungLap.TrieuChungKhop_Text));
                Command.Parameters.Add(new MDB.MDBParameter("Phoi", BenhAnHoiChungTrungLap.Phoi));
                Command.Parameters.Add(new MDB.MDBParameter("Phoi_Text", BenhAnHoiChungTrungLap.Phoi_Text));
                Command.Parameters.Add(new MDB.MDBParameter("Tim", BenhAnHoiChungTrungLap.Tim));
                Command.Parameters.Add(new MDB.MDBParameter("Tim_Text", BenhAnHoiChungTrungLap.Tim_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DuongTieuHoa", BenhAnHoiChungTrungLap.DuongTieuHoa));
                Command.Parameters.Add(new MDB.MDBParameter("DuongTieuHoa_Text", BenhAnHoiChungTrungLap.DuongTieuHoa_Text));
                Command.Parameters.Add(new MDB.MDBParameter("Phu", BenhAnHoiChungTrungLap.Phu));
                Command.Parameters.Add(new MDB.MDBParameter("TieuIt", BenhAnHoiChungTrungLap.TieuIt));
                Command.Parameters.Add(new MDB.MDBParameter("TieuHong", BenhAnHoiChungTrungLap.TieuHong));
                Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieu_Khac", BenhAnHoiChungTrungLap.ThanTietNieu_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("CongThucMau", BenhAnHoiChungTrungLap.CongThucMau));
                Command.Parameters.Add(new MDB.MDBParameter("MauLang_1h", BenhAnHoiChungTrungLap.MauLang_1h));
                Command.Parameters.Add(new MDB.MDBParameter("MauLang_2h", BenhAnHoiChungTrungLap.MauLang_2h));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoa", BenhAnHoiChungTrungLap.SinhHoa));
                Command.Parameters.Add(new MDB.MDBParameter("NuocTieu", BenhAnHoiChungTrungLap.NuocTieu));
                Command.Parameters.Add(new MDB.MDBParameter("CNHH_NgayLam", BenhAnHoiChungTrungLap.CNHH_NgayLam));
                Command.Parameters.Add(new MDB.MDBParameter("CNHH_FVC", BenhAnHoiChungTrungLap.CNHH_FVC));
                Command.Parameters.Add(new MDB.MDBParameter("CNHH_FEV1", BenhAnHoiChungTrungLap.CNHH_FEV1));
                Command.Parameters.Add(new MDB.MDBParameter("CNHH_DLco", BenhAnHoiChungTrungLap.CNHH_DLco));
                Command.Parameters.Add(new MDB.MDBParameter("CNHH_DuDoanFVC", BenhAnHoiChungTrungLap.CNHH_DuDoanFVC));
                Command.Parameters.Add(new MDB.MDBParameter("CNHH_FEV1_FVC", BenhAnHoiChungTrungLap.CNHH_FEV1_FVC));
                Command.Parameters.Add(new MDB.MDBParameter("CNHH_DuDoanDLco", BenhAnHoiChungTrungLap.CNHH_DuDoanDLco));
                Command.Parameters.Add(new MDB.MDBParameter("XQtp", BenhAnHoiChungTrungLap.XQtp));
                Command.Parameters.Add(new MDB.MDBParameter("HRCT_NgayLam", BenhAnHoiChungTrungLap.HRCT_NgayLam));
                Command.Parameters.Add(new MDB.MDBParameter("HRCT_Text", BenhAnHoiChungTrungLap.HRCT_Text));
                Command.Parameters.Add(new MDB.MDBParameter("SAOBung", BenhAnHoiChungTrungLap.SAOBung));
                Command.Parameters.Add(new MDB.MDBParameter("Ana", BenhAnHoiChungTrungLap.Ana));
                Command.Parameters.Add(new MDB.MDBParameter("CacTheTuKhangKhac", BenhAnHoiChungTrungLap.CacTheTuKhangKhac));
                Command.Parameters.Add(new MDB.MDBParameter("KhamMat_NgayLam", BenhAnHoiChungTrungLap.KhamMat_NgayLam));
                Command.Parameters.Add(new MDB.MDBParameter("KhamMat_Text", BenhAnHoiChungTrungLap.KhamMat_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DienCoKim", BenhAnHoiChungTrungLap.DienCoKim));
                Command.Parameters.Add(new MDB.MDBParameter("SinhThietCo_NgayLam", BenhAnHoiChungTrungLap.SinhThietCo_NgayLam));
                Command.Parameters.Add(new MDB.MDBParameter("SinhThietCo_Text", BenhAnHoiChungTrungLap.SinhThietCo_Text));
                Command.Parameters.Add(new MDB.MDBParameter("BenhMoLienKet", BenhAnHoiChungTrungLap.BenhMoLienKet));
                Command.Parameters.Add(new MDB.MDBParameter("TieuChuanBatBuoc", BenhAnHoiChungTrungLap.TieuChuanBatBuoc));
                Command.Parameters.Add(new MDB.MDBParameter("PhuBanTay", BenhAnHoiChungTrungLap.PhuBanTay));
                Command.Parameters.Add(new MDB.MDBParameter("ViemDaMang", BenhAnHoiChungTrungLap.ViemDaMang));
                Command.Parameters.Add(new MDB.MDBParameter("ViemCo", BenhAnHoiChungTrungLap.ViemCo));
                Command.Parameters.Add(new MDB.MDBParameter("TCLS_HienTuongRaynaud", BenhAnHoiChungTrungLap.TCLS_HienTuongRaynaud));
                Command.Parameters.Add(new MDB.MDBParameter("XoCungDauChi", BenhAnHoiChungTrungLap.XoCungDauChi));
                Command.Parameters.Add(new MDB.MDBParameter("HoiChungEnzyme", BenhAnHoiChungTrungLap.HoiChungEnzyme));
                Command.Parameters.Add(new MDB.MDBParameter("AntiARSDuongTinh", BenhAnHoiChungTrungLap.AntiARSDuongTinh));
                Command.Parameters.Add(new MDB.MDBParameter("BenhLyPhoiKe", BenhAnHoiChungTrungLap.BenhLyPhoiKe));
                Command.Parameters.Add(new MDB.MDBParameter("ViemDaCoViemBiCo", BenhAnHoiChungTrungLap.ViemDaCoViemBiCo));
                Command.Parameters.Add(new MDB.MDBParameter("ViemKhop", BenhAnHoiChungTrungLap.ViemKhop));
                Command.Parameters.Add(new MDB.MDBParameter("TCP_HienTuongRaynaud", BenhAnHoiChungTrungLap.TCP_HienTuongRaynaud));
                Command.Parameters.Add(new MDB.MDBParameter("TCP_BanTayThoCoKhi", BenhAnHoiChungTrungLap.TCP_BanTayThoCoKhi));
                Command.Parameters.Add(new MDB.MDBParameter("XoCungBiHeThong", BenhAnHoiChungTrungLap.XoCungBiHeThong));
                Command.Parameters.Add(new MDB.MDBParameter("ThuongTonDaVungNgonTay", BenhAnHoiChungTrungLap.ThuongTonDaVungNgonTay));
                Command.Parameters.Add(new MDB.MDBParameter("DayDaNgonTay_1", BenhAnHoiChungTrungLap.DayDaNgonTay_1));
                Command.Parameters.Add(new MDB.MDBParameter("DayDaNgonTay_2", BenhAnHoiChungTrungLap.DayDaNgonTay_2));
                Command.Parameters.Add(new MDB.MDBParameter("ThuongTonDauNgon_1", BenhAnHoiChungTrungLap.ThuongTonDauNgon_1));
                Command.Parameters.Add(new MDB.MDBParameter("ThuongTonDauNgon_2", BenhAnHoiChungTrungLap.ThuongTonDauNgon_2));
                Command.Parameters.Add(new MDB.MDBParameter("GianMach", BenhAnHoiChungTrungLap.GianMach));
                Command.Parameters.Add(new MDB.MDBParameter("BatThuongMaoMach", BenhAnHoiChungTrungLap.BatThuongMaoMach));
                Command.Parameters.Add(new MDB.MDBParameter("TangApLucDongMach_1", BenhAnHoiChungTrungLap.TangApLucDongMach_1));
                Command.Parameters.Add(new MDB.MDBParameter("TangApLucDongMach_2", BenhAnHoiChungTrungLap.TangApLucDongMach_2));
                Command.Parameters.Add(new MDB.MDBParameter("HienTuongRaynauds", BenhAnHoiChungTrungLap.HienTuongRaynauds));
                Command.Parameters.Add(new MDB.MDBParameter("Anti_Centromere", BenhAnHoiChungTrungLap.Anti_Centromere));
                Command.Parameters.Add(new MDB.MDBParameter("Anti_TopoisomeraseI", BenhAnHoiChungTrungLap.Anti_TopoisomeraseI));
                Command.Parameters.Add(new MDB.MDBParameter("Anti_RNApolymeraseIII", BenhAnHoiChungTrungLap.Anti_RNApolymeraseIII));
                Command.Parameters.Add(new MDB.MDBParameter("BieuHienTaiKhop", BenhAnHoiChungTrungLap.BieuHienTaiKhop));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetThanh", BenhAnHoiChungTrungLap.HuyetThanh));
                Command.Parameters.Add(new MDB.MDBParameter("CacYeuToPhanUng", BenhAnHoiChungTrungLap.CacYeuToPhanUng));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianBieuHien", BenhAnHoiChungTrungLap.ThoiGianBieuHien));
                Command.Parameters.Add(new MDB.MDBParameter("TANIMOTO_1", BenhAnHoiChungTrungLap.TANIMOTO_1));
                Command.Parameters.Add(new MDB.MDBParameter("TANIMOTO_2", BenhAnHoiChungTrungLap.TANIMOTO_2));
                Command.Parameters.Add(new MDB.MDBParameter("TANIMOTO_3", BenhAnHoiChungTrungLap.TANIMOTO_3));
                Command.Parameters.Add(new MDB.MDBParameter("TANIMOTO_4", BenhAnHoiChungTrungLap.TANIMOTO_4));
                Command.Parameters.Add(new MDB.MDBParameter("TANIMOTO_5", BenhAnHoiChungTrungLap.TANIMOTO_5));
                Command.Parameters.Add(new MDB.MDBParameter("TANIMOTO_6", BenhAnHoiChungTrungLap.TANIMOTO_6));
                Command.Parameters.Add(new MDB.MDBParameter("TANIMOTO_7", BenhAnHoiChungTrungLap.TANIMOTO_7));
                Command.Parameters.Add(new MDB.MDBParameter("TANIMOTO_8", BenhAnHoiChungTrungLap.TANIMOTO_8));
                Command.Parameters.Add(new MDB.MDBParameter("TANIMOTO_9", BenhAnHoiChungTrungLap.TANIMOTO_9));
                Command.Parameters.Add(new MDB.MDBParameter("ViemBiCo_1", BenhAnHoiChungTrungLap.ViemBiCo_1));
                Command.Parameters.Add(new MDB.MDBParameter("ViemBiCo_2", BenhAnHoiChungTrungLap.ViemBiCo_2));
                Command.Parameters.Add(new MDB.MDBParameter("ChuY", BenhAnHoiChungTrungLap.ChuY));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_TaiCho", BenhAnHoiChungTrungLap.DieuTri_TaiCho));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_ToanThan", BenhAnHoiChungTrungLap.DieuTri_ToanThan));
                Command.Parameters.Add(new MDB.MDBParameter("HenKham", BenhAnHoiChungTrungLap.HenKham));
                Command.Parameters.Add(new MDB.MDBParameter("BacSiKhamBenh", BenhAnHoiChungTrungLap.BacSiKhamBenh));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SoBenhAnDienTu", BenhAnHoiChungTrungLap.TK_SoBenhAnDienTu));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SoLuuTru", BenhAnHoiChungTrungLap.TK_SoLuuTru));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Sot", BenhAnHoiChungTrungLap.TK_Sot));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Sot_Text", BenhAnHoiChungTrungLap.TK_Sot_Text));
                Command.Parameters.Add(new MDB.MDBParameter("TK_MetMoi", BenhAnHoiChungTrungLap.TK_MetMoi));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Mach", BenhAnHoiChungTrungLap.TK_Mach));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HuyetAp", BenhAnHoiChungTrungLap.TK_HuyetAp));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HachTo", BenhAnHoiChungTrungLap.TK_HachTo));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HachTo_Vitri", BenhAnHoiChungTrungLap.TK_HachTo_Vitri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TienSu", BenhAnHoiChungTrungLap.TK_TienSu));
                Command.Parameters.Add(new MDB.MDBParameter("TK_NTTDDLupusBanDoHT", BenhAnHoiChungTrungLap.TK_NTTDDLupusBanDoHT));
                Command.Parameters.Add(new MDB.MDBParameter("TK_NTTDDBenhXoCungBi", BenhAnHoiChungTrungLap.TK_NTTDDBenhXoCungBi));
                Command.Parameters.Add(new MDB.MDBParameter("TK_NTTDDBenhViemDaCo", BenhAnHoiChungTrungLap.TK_NTTDDBenhViemDaCo));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TonThuongDaKhac", BenhAnHoiChungTrungLap.TK_TonThuongDaKhac));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DauCo", BenhAnHoiChungTrungLap.TK_DauCo));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DauCo_ViTri", BenhAnHoiChungTrungLap.TK_DauCo_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_BopCo", BenhAnHoiChungTrungLap.TK_BopCo));
                Command.Parameters.Add(new MDB.MDBParameter("TK_BopCo_ViTri", BenhAnHoiChungTrungLap.TK_BopCo_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TeoCo", BenhAnHoiChungTrungLap.TK_TeoCo));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TeoCo_ViTri", BenhAnHoiChungTrungLap.TK_TeoCo_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TrieuChungCo_Khac", BenhAnHoiChungTrungLap.TK_TrieuChungCo_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DauKhop", BenhAnHoiChungTrungLap.TK_DauKhop));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SungKhop", BenhAnHoiChungTrungLap.TK_SungKhop));
                Command.Parameters.Add(new MDB.MDBParameter("TK_BienDangKhop", BenhAnHoiChungTrungLap.TK_BienDangKhop));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Phoi", BenhAnHoiChungTrungLap.TK_Phoi));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Phoi_SoVoiLanTruoc", BenhAnHoiChungTrungLap.TK_Phoi_SoVoiLanTruoc));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Phoi_Text", BenhAnHoiChungTrungLap.TK_Phoi_Text));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Tim", BenhAnHoiChungTrungLap.TK_Tim));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Tim_SoVoiLanTruoc", BenhAnHoiChungTrungLap.TK_Tim_SoVoiLanTruoc));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Tim_Text", BenhAnHoiChungTrungLap.TK_Tim_Text));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DTH", BenhAnHoiChungTrungLap.TK_DTH));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DTH_SoVoiLanTruoc", BenhAnHoiChungTrungLap.TK_DTH_SoVoiLanTruoc));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DTH_Text", BenhAnHoiChungTrungLap.TK_DTH_Text));
                Command.Parameters.Add(new MDB.MDBParameter("TK_CongThucMau", BenhAnHoiChungTrungLap.TK_CongThucMau));
                Command.Parameters.Add(new MDB.MDBParameter("TK_MauLang", BenhAnHoiChungTrungLap.TK_MauLang));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa", BenhAnHoiChungTrungLap.TK_SinhHoa));
                Command.Parameters.Add(new MDB.MDBParameter("TK_NuocTieu", BenhAnHoiChungTrungLap.TK_NuocTieu));
                Command.Parameters.Add(new MDB.MDBParameter("TK_CacTuKhangThe_LamLaiSau", BenhAnHoiChungTrungLap.TK_CacTuKhangThe_LamLaiSau));
                Command.Parameters.Add(new MDB.MDBParameter("TK_CacTuKhangThe_KetQua", BenhAnHoiChungTrungLap.TK_CacTuKhangThe_KetQua));
                Command.Parameters.Add(new MDB.MDBParameter("TK_ChuY", BenhAnHoiChungTrungLap.TK_ChuY));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DieuTri_TaiCho", BenhAnHoiChungTrungLap.TK_DieuTri_TaiCho));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DieuTri_ToanThan", BenhAnHoiChungTrungLap.TK_DieuTri_ToanThan));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TacDungPhuCuaThuoc", BenhAnHoiChungTrungLap.TK_TacDungPhuCuaThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HenKham", BenhAnHoiChungTrungLap.TK_HenKham));
                Command.Parameters.Add(new MDB.MDBParameter("TK_BacSiKhamBenh", BenhAnHoiChungTrungLap.TK_BacSiKhamBenh));


                // Tổng kết    
                Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnHoiChungTrungLap.QuaTrinhBenhLy));
                Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQua", BenhAnHoiChungTrungLap.TomTatKetQua));
                Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnHoiChungTrungLap.BenhChinh));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhChinh", BenhAnHoiChungTrungLap.MaBenhChinh));
                Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnHoiChungTrungLap.BenhKemTheo));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhKemTheo", BenhAnHoiChungTrungLap.MaBenhKemTheo));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnHoiChungTrungLap.PhuongPhapDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangRaVien", BenhAnHoiChungTrungLap.TinhTrangRaVien));
                Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnHoiChungTrungLap.HuongDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnHoiChungTrungLap.NguoiNhanHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnHoiChungTrungLap.NguoiGiaoHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnHoiChungTrungLap.NgayTongKet));
                Command.Parameters.Add(new MDB.MDBParameter("TongKet_BacSyDieuTri", BenhAnHoiChungTrungLap.TongKet_BacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TongKet_MaBacSyDieuTri", BenhAnHoiChungTrungLap.TongKet_MaBacSyDieuTri));

                Command.BindByName = true;

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnHoiChungTrungLap.MaQuanLy));
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
