using EMR_MAIN.DATABASE.BenhAn;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMR_MAIN.DATABASE.BenhAnFunc
{
    public class BenhAnNgoaiTru_LuPusBanDoManTinhFunc
    {
        public static void WriteXml(MDB.MDBConnection MyConnection)
        {
            string sql =
                   @"
                  select  a.*,  CTScanner HoSo_CTScanner, SieuAm HoSo_SieuAm, XetNghiem HoSo_XetNghiem,  Khac HoSo_Khac,  Khac_Text HoSo_Khac_Text,  ToanBoHoSo HoSo_ToanBoHoSo, Mach DauSinhTon_Mach,  NhietDo DauSinhTon_NhietDo,  HuyetAp DauSinhTon_HuyetAp,  NhipTho DauSinhTon_NhipTho,  CanNang DauSinhTon_CanNang  
                  from BENHANDTNTLUPUSMANTINH a inner join thongtindieutri b on a.maquanly = b.maquanly
                  where rownum = 1
                    ";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            var DataTable = new DataTable { TableName = "BENHANDTNTLUPUSMANTINH" };
            DataTable.Load(DataReader as IDataReader);
            DataTable.WriteXml("rptBENHANDTNTLUPUSMANTINH.xml");
        }
        public static DataSet SelectDataSet(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql =
                   @"
                  select  a.*, f.hovaten BacSyDieuTriHoVaTen, d.hovaten NguoiGiaoHoSoHoVaTen,e.hovaten NguoiNhanHoSoHoVaTen, b.XQuang HoSo_XQuang, b.CTScanner HoSo_CTScanner, b.SieuAm HoSo_SieuAm, b.XetNghiem HoSo_XetNghiem,  b.Khac HoSo_Khac,  b.Khac_Text HoSo_Khac_Text,  b.ToanBoHoSo HoSo_ToanBoHoSo
                        from BENHANDTNTLUPUSMANTINH a  
                  left join thongtindieutri b on a.maquanly = b.maquanly 
                  left join nhanvien f on a.BacSyDieuTri = f.manhanvien
                  left join nhanvien d on a.NguoiGiaoHoSo = d.manhanvien
                  left join nhanvien e on a.NguoiNhanHoSo = e.manhanvien where a.maquanly = " + MaQuanLy.ToString(System.Globalization.CultureInfo.InvariantCulture);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(sql, MyConnection);
            var ds = new DataSet();
            adt.Fill(ds, "Table");
            return ds;

        }
        public static BenhAnNgoaiTru_LuPusBanDoManTinh Select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            var obj = new BenhAnNgoaiTru_LuPusBanDoManTinh();
            try
            {
                #region
                string sql =
                          @"select * 
                        from   BENHANDTNTLUPUSMANTINH 
                        where MaQuanLy = :MaQuanLy";
                #endregion
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    // Phần chung Hành chính
                    obj.MaQuanLy = DataReader.GetDecimal("MaQuanLy");
                    obj.DieuTriNgoaiTruTu = DataReader["DieuTriNgoaiTruTu"] != DBNull.Value ? (DateTime?) Convert.ToDateTime(DataReader["DieuTriNgoaiTruTu"]) : null;
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
                    // hoibenh
                    // 1. Bệnh sử - tiền sử
                    obj.HB_CanNang = DataReader["HB_CanNang"].ToString();
                    obj.HB_ChieuCao = DataReader["HB_ChieuCao"].ToString();
                    obj.TG_KhoiPhatBenh = DataReader["TG_KhoiPhatBenh"].ToString();
                    obj.TrieuChungDauTien = DataReader["TrieuChungDauTien"].ToString();
                    obj.TSCN_BenhTuMienKhac = DataReader.GetInt("TSCN_BenhTuMienKhac");
                    obj.TSCN_SoNguoiBenhTuMien = DataReader.GetInt("TSCN_SoNguoiBenhTuMien"); 
                    obj.CollagenOrTuMien = DataReader.GetInt("CollagenOrTuMien");
                    obj.XoCungBi = DataReader.GetInt("XoCungBi");
                    obj.ViemDaCoViemBiCo = DataReader.GetInt("ViemDaCoViemBiCo");
                    obj.HoiChungSjogren = DataReader.GetInt("HoiChungSjogren");
                    obj.XoGanMatTienPhat = DataReader.GetInt("XoGanMatTienPhat");
                    obj.ViemTuyenGiapHashimoto = DataReader.GetInt("ViemTuyenGiapHashimoto");
                    obj.HoiChungPhospholipid = DataReader.GetInt("HoiChungPhospholipid");
                    obj.TSCN_NoiDungKhac = DataReader["TSCN_NoiDungKhac"].ToString();
                    obj.TSCN_CacBenhKhac_Check = DataReader.GetInt("TSCN_CacBenhKhac_Check");
                    obj.TSCN_CacBenhKhac = DataReader["TSCN_CacBenhKhac"].ToString();
                    obj.TSGD_BenhTuMien = DataReader.GetInt("TSGD_BenhTuMien");
                    obj.TSGD_NoiDungBenhTuMien = DataReader["TSGD_NoiDungBenhTuMien"].ToString();
                    obj.TSGD_NoiDungKhac = DataReader["TSGD_NoiDungKhac"].ToString();
                    // 2. Toàn trạng
                    obj.ToanTrangCoNang = DataReader["ToanTrangCoNang"].ToString();
                    obj.TTCN_HuyetAp = DataReader["TTCN_HuyetAp"].ToString();
                    obj.TTCN_NoiDungKhac = DataReader["TTCN_NoiDungKhac"].ToString();
                    // 3. Lâm sàng da
                    obj.TonThuongDaNiemMac = DataReader["TonThuongDaNiemMac"].ToString();
                    obj.TonThuongKhac = DataReader["TonThuongKhac"].ToString();
                    obj.ViTriTonThuong = DataReader["ViTriTonThuong"].ToString();
                    obj.ViTriKhac = DataReader["ViTriKhac"].ToString();
                    obj.DiemHoatDong = DataReader["DiemHoatDong"].ToString();
                    obj.DiemThietHai = DataReader["DiemThietHai"].ToString();
                    // 4. Kham co quan khac
                    obj.KCQKTimMach = DataReader["KCQKTimMach"].ToString();
                    obj.KCQKThanTietNieu = DataReader["KCQKThanTietNieu"].ToString();
                    obj.KCQKHoHap = DataReader["KCQKHoHap"].ToString();
                    obj.KCQK_CXK = DataReader["KCQK_CXK"].ToString();
                    obj.KCQKTieuHoa = DataReader["KCQKTieuHoa"].ToString();
                    obj.KCQK_TKTT = DataReader["KCQK_TKTT"].ToString();
                    obj.KCQKCacBoPhanKhac = DataReader["KCQKCacBoPhanKhac"].ToString();
                    //5. Xet nghiem
                    obj.CTM_BachCau = DataReader["CTM_BachCau"].ToString();
                    obj.CTM_LymPho = DataReader["CTM_LymPho"].ToString();
                    obj.CTM_HC = DataReader["CTM_HC"].ToString();
                    obj.CTM_HB = DataReader["CTM_HB"].ToString();
                    obj.CTM_TieuCau = DataReader["CTM_TieuCau"].ToString();
                    obj.MauLang1 = DataReader["MauLang1"].ToString();
                    obj.MauLang2 = DataReader["MauLang2"].ToString();
                    obj.SH_Creatimin = DataReader["SH_Creatimin"].ToString();
                    obj.SH_Ure = DataReader["SH_Ure"].ToString();
                    obj.SH_CRPhs = DataReader["SH_CRPhs"].ToString();
                    obj.SH_Protein = DataReader["SH_Protein"].ToString();
                    obj.SH_ALB = DataReader["SH_ALB"].ToString();
                    obj.SH_Cholesterol = DataReader["SH_Cholesterol"].ToString();
                    obj.SH_Tri = DataReader["SH_Tri"].ToString();
                    obj.SH_GOT = DataReader["SH_GOT"].ToString();
                    obj.SH_GPT = DataReader["SH_GPT"].ToString();
                    obj.ProteinNieu = DataReader.GetInt("ProteinNieu");
                    obj.TruNieu = DataReader.GetInt("ProteinNieu");
                    obj.HCNieu = DataReader.GetInt("HCNieu");
                    obj.BCNieu = DataReader.GetInt("BCNieu");
                    obj.NuocTieu24H = DataReader["NuocTieu24H"].ToString();
                    obj.MienDich_ANA = DataReader.GetInt("MienDich_ANA");
                    obj.TXTMienDich_ANA = DataReader["TXTMienDich_ANA"].ToString();
                    obj.MienDich_AntiDNA = DataReader.GetInt("MienDich_AntiDNA");
                    obj.TXTMienDich_AntiDNA = DataReader["TXTMienDich_AntiDNA"].ToString();
                    obj.MienDich_PhosphoLiPid = DataReader.GetInt("MienDich_PhosphoLiPid");
                    obj.TXTMienDich_PhosphoLiPid = DataReader["TXTMienDich_PhosphoLiPid"].ToString();
                    obj.MienDich_AntiSM = DataReader.GetInt("MienDich_AntiSM");
                    obj.TXTMienDich_AntiSM = DataReader["TXTMienDich_AntiSM"].ToString();
                    obj.MienDich_Cardiolipin = DataReader.GetInt("MienDich_Cardiolipin");
                    obj.TXTMienDich_Cardiolipin = DataReader["TXTMienDich_Cardiolipin"].ToString();
                    obj.MienDich_AntiSSA = DataReader.GetInt("MienDich_AntiSSA");
                    obj.TXTMienDich_AntiSSA = DataReader["TXTMienDich_AntiSSA"].ToString();
                    obj.MienDich_AntiSSB = DataReader.GetInt("MienDich_AntiSSB");
                    obj.TXTMienDich_AntiSSB = DataReader["TXTMienDich_AntiSSB"].ToString();
                    obj.MienDich_KhangDongLuPus = DataReader.GetInt("MienDich_KhangDongLuPus");
                    obj.TXTMienDich_KhangDongLuPus = DataReader["TXTMienDich_KhangDongLuPus"].ToString();
                    obj.MienDich_Glycoptotein = DataReader.GetInt("MienDich_Glycoptotein");
                    obj.TXTMienDich_Glycoptotein = DataReader["TXTMienDich_Glycoptotein"].ToString();
                    obj.MienDich_U1 = DataReader.GetInt("MienDich_U1");
                    obj.TXTMienDich_U1 = DataReader["TXTMienDich_U1"].ToString();
                    obj.MienDich_Histone = DataReader.GetInt("MienDich_Histone");
                    obj.TXTMienDich_Histone = DataReader["TXTMienDich_Histone"].ToString();
                    obj.TXTMienDich_KTKhac = DataReader["TXTMienDich_KTKhac"].ToString();
                    obj.BT_C3 = DataReader["BT_C3"].ToString();
                    obj.BTC3 = DataReader.GetInt("BTC3");
                    obj.BT_C4 = DataReader["BT_C4"].ToString();
                    obj.BTC4 = DataReader.GetInt("BTC4");
                    obj.SinhThiet_Check = DataReader.GetInt("SinhThiet_Check");
                    obj.SinhThiet_NgayLam = DataReader["SinhThiet_NgayLam"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["SinhThiet_NgayLam"]) : null;
                    obj.SinhThietDa_KQ = DataReader["SinhThietDa_KQ"].ToString();
                    obj.SinhThietDa_Khac = DataReader["SinhThietDa_Khac"].ToString();
                    obj.LupusTest = DataReader.GetInt("LupusTest");
                    obj.Lupus_NeuCo = DataReader.GetInt("Lupus_NeuCo");
                    obj.LupusMoTaDuongtinh = DataReader["LupusMoTaDuongtinh"].ToString();
                    obj.SinhThiet_NgayLam = DataReader["SinhThiet_NgayLam"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["SinhThiet_NgayLam"]) : null; 
                    obj.KQKhamMat = DataReader["KQKhamMat"].ToString();
                    obj.CacXetNghiemKhac = DataReader["CacXetNghiemKhac"].ToString();
                    obj.ChanDoan = DataReader["ChanDoan"].ToString();
                    obj.ChanDoanKhac = DataReader["ChanDoanKhac"].ToString();
                    obj.DieuTri = DataReader["DieuTri"].ToString(); 
                    obj.HB_HenKhamLai = DataReader["HB_HenKhamLai"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["HB_HenKhamLai"]) : null;
                    obj.MaBacSyKhamBenh = DataReader["MaBacSyKhambenh"].ToString();
                    obj.BacSyKhamBenh = DataReader["BacSyKhamBenh"].ToString(); 
                    // Phần tái khám
                    obj.TK_SoBADienTu = DataReader["TK_SoBADienTu"].ToString();
                    obj.TK_SoLuuTru = DataReader["TK_SoLuuTru"].ToString();
                    obj.TK_NgayLuuTru = DataReader["TK_NgayLuuTru"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["TK_NgayLuuTru"]) : null;
                    obj.TK_NgayLuuTru = DataReader["TK_NgayLuuHuyetThanh"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["TK_NgayLuuHuyetThanh"]) : null; 
                    obj.TK_BacSiKham_LuuTru = DataReader["TK_BacSiKham_LuuTru"].ToString();
                    obj.TK_TienSu = DataReader["TK_TienSu"].ToString();
                    obj.TK_Mach = DataReader["TK_Mach"].ToString();
                    obj.TK_HuyetAp = DataReader["TK_HuyetAp"].ToString();
                    obj.TK_NhietDo = DataReader["TK_NhietDo"].ToString();
                    obj.TK_NhipTho = DataReader["TK_NhipTho"].ToString();
                    obj.TK_LamSangKhac = DataReader["TK_LamSangKhac"].ToString();
                    obj.TK_TonThuongDaNiemMac = DataReader["TK_TonThuongDaNiemMac"].ToString();
                    obj.TK_DiemHoatDong = DataReader["TK_DiemHoatDong"].ToString();
                    obj.TK_DiemThietHai = DataReader["TK_DiemThietHai"].ToString();
                    obj.TK_TimMach = DataReader["TK_TimMach"].ToString();
                    obj.TK_ThanTietNieu = DataReader["TK_ThanTietNieu"].ToString();
                    obj.TK_HoHap = DataReader["TK_HoHap"].ToString();
                    obj.TK_CXK = DataReader["TK_CXK"].ToString();
                    obj.TK_TKTT = DataReader["TK_TKTT"].ToString();
                    obj.TK_CacBoPhanKhac = DataReader["TK_CacBoPhanKhac"].ToString();
                    obj.TK_BachCau = DataReader["TK_BachCau"].ToString();
                    obj.TK_LymPho = DataReader["TK_LymPho"].ToString();
                    obj.TK_HC = DataReader["TK_HC"].ToString();
                    obj.TK_HB = DataReader["TK_HB"].ToString();
                    obj.TK_TieuCau = DataReader["TK_TieuCau"].ToString();
                    obj.TK_MauLang1 = DataReader["TK_MauLang1"].ToString();
                    obj.TK_MauLang2 = DataReader["TK_MauLang2"].ToString();
                    obj.TK_Creatimin = DataReader["TK_Creatimin"].ToString();
                    obj.TK_Ure = DataReader["TK_Ure"].ToString();
                    obj.TK_CRPhs = DataReader["TK_CRPhs"].ToString();
                    obj.TK_Protein = DataReader["TK_Protein"].ToString();
                    obj.TK_ALB = DataReader["TK_ALB"].ToString();
                    obj.TK_Cholesterol = DataReader["TK_Cholesterol"].ToString();
                    obj.TK_Tri = DataReader["TK_Tri"].ToString();
                    obj.TK_GOT = DataReader["TK_GOT"].ToString();
                    obj.TK_GPT = DataReader["TK_GPT"].ToString();
                    obj.TK_ProteinNieu = DataReader.GetInt("TK_ProteinNieu");
                    obj.TK_TruNieu = DataReader.GetInt("TK_TruNieu");
                    obj.TK_HCNieu = DataReader.GetInt("TK_HCNieu");
                    obj.TK_BCNieu = DataReader.GetInt("TK_BCNieu");
                    obj.TK_NuocTieu24H = DataReader["TK_NuocTieu24H"].ToString();
                    obj.TKMienDich_ANA = DataReader.GetInt("TKMienDich_ANA");
                    obj.TK_TXTMienDich_ANA = DataReader["TK_TXTMienDich_ANA"].ToString();
                    obj.TKMienDich_AntiDNA = DataReader.GetInt("TKMienDich_AntiDNA");
                    obj.TK_TXTMienDich_AntiDNA = DataReader["TK_TXTMienDich_AntiDNA"].ToString();
                    obj.TKMienDich_PhosphoLiPid = DataReader.GetInt("TKMienDich_PhosphoLiPid");
                    obj.TK_TXTMienDich_PhosphoLiPid = DataReader["TK_TXTMienDich_PhosphoLiPid"].ToString();
                    obj.TKMienDich_AntiSM = DataReader.GetInt("TKMienDich_AntiSM");
                    obj.TK_TXTMienDich_AntiSM = DataReader["TK_TXTMienDich_AntiSM"].ToString();
                    obj.TKMienDich_Cardiolipin = DataReader.GetInt("TKMienDich_Cardiolipin");
                    obj.TK_TXTMienDich_Cardiolipin = DataReader["TK_TXTMienDich_Cardiolipin"].ToString();
                    obj.TKMienDich_AntiSSA = DataReader.GetInt("TKMienDich_AntiSSA");
                    obj.TK_TXTMienDich_AntiSSA = DataReader["TK_TXTMienDich_AntiSSA"].ToString();
                    obj.TKMienDich_KhangDongLuPus = DataReader.GetInt("TKMienDich_KhangDongLuPus");
                    obj.TK_TXTMienDich_KhangDongLuPus = DataReader["TK_TXTMienDich_KhangDongLuPus"].ToString();
                    obj.TKMienDich_AntiSSB = DataReader.GetInt("TKMienDich_AntiSSB");
                    obj.TK_TXTMienDich_AntiSSB = DataReader["TK_TXTMienDich_AntiSSB"].ToString();
                    obj.TKMienDich_Glycoptotein = DataReader.GetInt("TKMienDich_Glycoptotein");
                    obj.TK_TXTMienDich_Glycoptotein = DataReader["TK_TXTMienDich_Glycoptotein"].ToString();
                    obj.TKMienDich_U1 = DataReader.GetInt("TKMienDich_U1");
                    obj.TK_TXTMienDich_U1 = DataReader["TK_TXTMienDich_U1"].ToString();
                    obj.TKMienDich_Histone = DataReader.GetInt("TKMienDich_Histone");
                    obj.TK_TXTMienDich_Histone = DataReader["TK_TXTMienDich_Histone"].ToString();
                    obj.TK_TXTMienDich_KTKhac = DataReader["TK_TXTMienDich_KTKhac"].ToString();
                    obj.TKKhamMat_Ngay = DataReader["TKKhamMat_Ngay"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["TKKhamMat_Ngay"]) : null;
                    obj.TK_KhamMat = DataReader["TK_KhamMat"].ToString();
                    obj.TK_CacXetNghiemKhac = DataReader["TK_CacXetNghiemKhac"].ToString();
                    obj.TK_ChuY = DataReader["TK_ChuY"].ToString();
                    obj.TK_DieuTri = DataReader["TK_DieuTri"].ToString(); 
                    obj.TK_HenKhamLai = DataReader["TK_HenKhamLai"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["TK_HenKhamLai"]) : null;
                    obj.TK_MaBacSyDieuTri = DataReader["TK_MaBacSyDieuTri"].ToString();
                    obj.TK_BacSyDieuTri = DataReader["TK_BacSyDieuTri"].ToString();
                    // Tổng kết bệnh án
                    obj.TK_QuaTrinhBenhLy = DataReader["TK_QuaTrinhBenhLy"].ToString();
                    obj.TK_TomTatKetQua = DataReader["TK_TomTatKetQua"].ToString();
                    obj.TK_BenhChinh = DataReader["TK_BenhChinh"].ToString();
                    obj.TK_MaBenhChinh = DataReader["TK_MaBenhChinh"].ToString();
                    obj.TK_BenhKemTheo = DataReader["TK_BenhKemTheo"].ToString();
                    obj.TK_MaBenhKemTheo = DataReader["TK_MaBenhKemTheo"].ToString();
                    obj.TK_PhuongPhapDieuTri = DataReader["TK_PhuongPhapDieuTri"].ToString();
                    obj.TK_TinhTrangRaVien = DataReader["TK_TinhTrangRaVien"].ToString();
                    obj.TK_HuongDieuTri = DataReader["TK_HuongDieuTri"].ToString();
                    obj.NguoiNhanHoSo = DataReader["NguoiNhanHoSo"].ToString();
                    obj.NguoiGiaoHoSo = DataReader["NguoiGiaoHoSo"].ToString();
                    obj.NgayTongKet = DataReader["NgayTongKet"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayTongKet"]) : null;
                    obj.BacSyDieuTri = DataReader["BacSyDieuTri"].ToString();
                }

            }
            catch (Exception ex)
            {
                XuLyLoi.LogError(ex);
            }

            return obj;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, BenhAnNgoaiTru_LuPusBanDoManTinh obj)
        {
            string sql =
                      @"select MaQuanLy 
                        from BENHANDTNTLUPUSMANTINH
                        where MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", obj.MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            int rowCount = 0;
            while (DataReader.Read()) rowCount++;
            if (rowCount == 1) return Update(MyConnection, obj);
            sql = @"
                   INSERT INTO BENHANDTNTLUPUSMANTINH 
                    (
                        maquanly,
                        dieutringoaitrutu,
                        dieutringoaitruden,
                        socmnd,
                        baohiem,
                        chandoan_tuyentruoc,
                        chandoanbandau,
                        chandoantaikham1,
                        chandoantaikham2,
                        chandoantaikham3,
                        chandoantaikham4,
                        benhphu,
                        ketquadieutri,
                        bienchung_text,
                        gdphongkehoach,
                        gdphongkhambenh,
                        hb_cannang,
                        hb_chieucao,
                        tg_khoiphatbenh,
                        trieuchungdautien,
                        tscn_benhkhac,
                        collagenortumien,
                        xocungbi,
                        viemdacoviembico,
                        hoichungsjogren,
                        xoganmattienphat,
                        viemtuyengiaphashimoto,
                        hoichungphospholipid,
                        tscn_benhtumienkhac,
                        tscn_songuoibenhtumien,
                        tscn_noidungkhac,
                        tscn_cacbenhkhac,
                        tscn_cacbenhkhac_check,
                        tsgd_benhtumien,
                        tsgd_noidungbenhtumien,
                        tsgd_noidungkhac,
                        toantrangconang,
                        ttcn_huyetap,
                        ttcn_noidungkhac,
                        tonthuongdaniemmac,
                        tonthuongkhac,
                        vitritonthuong,
                        vitrikhac,
                        diemhoatdong,
                        diemthiethai,
                        kcqktimmach,
                        kcqkthantietnieu,
                        kcqkhohap,
                        kcqk_cxk,
                        kcqktieuhoa,
                        kcqk_tktt,
                        kcqkcacbophankhac,
                        ctm_bachcau,
                        ctm_lympho,
                        ctm_hc,
                        ctm_hb,
                        ctm_tieucau,
                        maulang1,
                        maulang2,
                        sh_creatimin,
                        sh_ure,
                        sh_crphs,
                        sh_protein,
                        sh_alb,
                        sh_cholesterol,
                        sh_tri,
                        sh_got,
                        sh_gpt,
                        proteinnieu,
                        trunieu,
                        hcnieu,
                        nuoctieu24h,
                        bcnieu,
                        miendich_ana,
                        txtmiendich_ana,
                        miendich_antidna,
                        txtmiendich_antidna,
                        miendich_phospholipid,
                        txtmiendich_phospholipid,
                        miendich_antism,
                        txtmiendich_antism,
                        miendich_cardiolipin,
                        txtmiendich_cardiolipin,
                        miendich_antissa,
                        txtmiendich_antissa,
                        miendich_khangdonglupus,
                        txtmiendich_khangdonglupus,
                        miendich_antissb,
                        txtmiendich_antissb,
                        miendich_glycoptotein,
                        txtmiendich_glycoptotein,
                        miendich_u1,
                        txtmiendich_u1,
                        miendich_histone,
                        txtmiendich_histone,
                        txtmiendich_ktkhac,
                        bt_c3,
                        bt_c4,
                        btc4,
                        btc3,
                        sinhthiet_check,
                        sinhthiet_ngaylam,
                        sinhthietda_kq,
                        sinhthietda_khac,
                        lupustest,
                        lupus_neuco,
                        lupusmotaduongtinh,
                        kqkhammat_ngay,
                        kqkhammat,
                        cacxetnghiemkhac,
                        chandoan,
                        chandoankhac,
                        dieutri,
                        hb_henkhamlai,
                        mabacsykhambenh,
                        bacsykhambenh,
                        tk_sobadientu,
                        tk_soluutru,
                        tk_bacsikham_luutru,
                        tk_ngayluutru,
                        tk_ngayluuhuyetthanh,
                        tk_tiensu,
                        tk_mach,
                        tk_huyetap,
                        tk_nhietdo,
                        tk_nhiptho,
                        tk_lamsangkhac,
                        tk_tonthuongdaniemmac,
                        tk_diemhoatdong,
                        tk_diemthiethai,
                        tk_timmach,
                        tk_thantietnieu,
                        tk_hohap,
                        tk_cxk,
                        tk_tieuhoa,
                        tk_tktt,
                        tk_cacbophankhac,
                        tk_bachcau,
                        tk_lympho,
                        tk_hc,
                        tk_hb,
                        tk_tieucau,
                        tk_maulang1,
                        tk_maulang2,
                        tk_creatimin,
                        tk_ure,
                        tk_crphs,
                        tk_protein,
                        tk_alb,
                        tk_cholesterol,
                        tk_tri,
                        tk_got,
                        tk_gpt,
                        tk_proteinnieu,
                        tk_trunieu,
                        tk_hcnieu,
                        tk_bcnieu,
                        tk_nuoctieu24h,
                        tkmiendich_ana,
                        tk_txtmiendich_ana,
                        tkmiendich_antidna,
                        tk_txtmiendich_antidna,
                        tkmiendich_phospholipid,
                        tk_txtmiendich_phospholipid,
                        tkmiendich_antism,
                        tk_txtmiendich_antism,
                        tkmiendich_cardiolipin,
                        tk_txtmiendich_cardiolipin,
                        tkmiendich_antissa,
                        tk_txtmiendich_antissa,
                        tkmiendich_khangdonglupus,
                        tk_txtmiendich_khangdonglupus,
                        tkmiendich_antissb,
                        tk_txtmiendich_antissb,
                        tkmiendich_glycoptotein,
                        tk_txtmiendich_glycoptotein,
                        tkmiendich_u1,
                        tk_txtmiendich_u1,
                        tkmiendich_histone,
                        tk_txtmiendich_histone,
                        tk_txtmiendich_ktkhac,
                        tkkhammat_ngay,
                        tk_khammat,
                        tk_cacxetnghiemkhac,
                        tk_chuy,
                        tk_dieutri,
                        tk_henkhamlai,
                        tk_mabacsydieutri,
                        tk_bacsydieutri,
                        tk_quatrinhbenhly,
                        tk_tomtatketqua,
                        tk_benhchinh,
                        tk_mabenhchinh,
                        tk_benhkemtheo,
                        tk_mabenhkemtheo,
                        tk_phuongphapdieutri,
                        tk_tinhtrangravien,
                        tk_huongdieutri,
                        nguoinhanhoso,
                        nguoigiaohoso,
                        ngaytongket,
                        bacsydieutri
                    )                 
                    VALUES
                    (
                        :maquanly,
                        :dieutringoaitrutu,
                        :dieutringoaitruden,
                        :socmnd,
                        :baohiem,
                        :chandoan_tuyentruoc,
                        :chandoanbandau,
                        :chandoantaikham1,
                        :chandoantaikham2,
                        :chandoantaikham3,
                        :chandoantaikham4,
                        :benhphu,
                        :ketquadieutri,
                        :bienchung_text,
                        :gdphongkehoach,
                        :gdphongkhambenh,
                        :hb_cannang,
                        :hb_chieucao,
                        :tg_khoiphatbenh,
                        :trieuchungdautien,
                        :tscn_benhkhac,
                        :collagenortumien,
                        :xocungbi,
                        :viemdacoviembico,
                        :hoichungsjogren,
                        :xoganmattienphat,
                        :viemtuyengiaphashimoto,
                        :hoichungphospholipid,
                        :tscn_benhtumienkhac,
                        :tscn_songuoibenhtumien,
                        :tscn_noidungkhac,
                        :tscn_cacbenhkhac,
                        :tscn_cacbenhkhac_check,
                        :tsgd_benhtumien,
                        :tsgd_noidungbenhtumien,
                        :tsgd_noidungkhac,
                        :toantrangconang,
                        :ttcn_huyetap,
                        :ttcn_noidungkhac,
                        :tonthuongdaniemmac,
                        :tonthuongkhac,
                        :vitritonthuong,
                        :vitrikhac,
                        :diemhoatdong,
                        :diemthiethai,
                        :kcqktimmach,
                        :kcqkthantietnieu,
                        :kcqkhohap,
                        :kcqk_cxk,
                        :kcqktieuhoa,
                        :kcqk_tktt,
                        :kcqkcacbophankhac,
                        :ctm_bachcau,
                        :ctm_lympho,
                        :ctm_hc,
                        :ctm_hb,
                        :ctm_tieucau,
                        :maulang1,
                        :maulang2,
                        :sh_creatimin,
                        :sh_ure,
                        :sh_crphs,
                        :sh_protein,
                        :sh_alb,
                        :sh_cholesterol,
                        :sh_tri,
                        :sh_got,
                        :sh_gpt,
                        :proteinnieu,
                        :trunieu,
                        :hcnieu,
                        :nuoctieu24h,
                        :bcnieu,
                        :miendich_ana,
                        :txtmiendich_ana,
                        :miendich_antidna,
                        :txtmiendich_antidna,
                        :miendich_phospholipid,
                        :txtmiendich_phospholipid,
                        :miendich_antism,
                        :txtmiendich_antism,
                        :miendich_cardiolipin,
                        :txtmiendich_cardiolipin,
                        :miendich_antissa,
                        :txtmiendich_antissa,
                        :miendich_khangdonglupus,
                        :txtmiendich_khangdonglupus,
                        :miendich_antissb,
                        :txtmiendich_antissb,
                        :miendich_glycoptotein,
                        :txtmiendich_glycoptotein,
                        :miendich_u1,
                        :txtmiendich_u1,
                        :miendich_histone,
                        :txtmiendich_histone,
                        :txtmiendich_ktkhac,
                        :bt_c3,
                        :bt_c4,
                        :btc4,
                        :btc3,
                        :sinhthiet_check,
                        :sinhthiet_ngaylam,
                        :sinhthietda_kq,
                        :sinhthietda_khac,
                        :lupustest,
                        :lupus_neuco,
                        :lupusmotaduongtinh,
                        :kqkhammat_ngay,
                        :kqkhammat,
                        :cacxetnghiemkhac,
                        :chandoan,
                        :chandoankhac,
                        :dieutri,
                        :hb_henkhamlai,
                        :mabacsykhambenh,
                        :bacsykhambenh,
                        :tk_sobadientu,
                        :tk_soluutru,
                        :tk_bacsikham_luutru,
                        :tk_ngayluutru,
                        :tk_ngayluuhuyetthanh,
                        :tk_tiensu,
                        :tk_mach,
                        :tk_huyetap,
                        :tk_nhietdo,
                        :tk_nhiptho,
                        :tk_lamsangkhac,
                        :tk_tonthuongdaniemmac,
                        :tk_diemhoatdong,
                        :tk_diemthiethai,
                        :tk_timmach,
                        :tk_thantietnieu,
                        :tk_hohap,
                        :tk_cxk,
                        :tk_tieuhoa,
                        :tk_tktt,
                        :tk_cacbophankhac,
                        :tk_bachcau,
                        :tk_lympho,
                        :tk_hc,
                        :tk_hb,
                        :tk_tieucau,
                        :tk_maulang1,
                        :tk_maulang2,
                        :tk_creatimin,
                        :tk_ure,
                        :tk_crphs,
                        :tk_protein,
                        :tk_alb,
                        :tk_cholesterol,
                        :tk_tri,
                        :tk_got,
                        :tk_gpt,
                        :tk_proteinnieu,
                        :tk_trunieu,
                        :tk_hcnieu,
                        :tk_bcnieu,
                        :tk_nuoctieu24h,
                        :tkmiendich_ana,
                        :tk_txtmiendich_ana,
                        :tkmiendich_antidna,
                        :tk_txtmiendich_antidna,
                        :tkmiendich_phospholipid,
                        :tk_txtmiendich_phospholipid,
                        :tkmiendich_antism,
                        :tk_txtmiendich_antism,
                        :tkmiendich_cardiolipin,
                        :tk_txtmiendich_cardiolipin,
                        :tkmiendich_antissa,
                        :tk_txtmiendich_antissa,
                        :tkmiendich_khangdonglupus,
                        :tk_txtmiendich_khangdonglupus,
                        :tkmiendich_antissb,
                        :tk_txtmiendich_antissb,
                        :tkmiendich_glycoptotein,
                        :tk_txtmiendich_glycoptotein,
                        :tkmiendich_u1,
                        :tk_txtmiendich_u1,
                        :tkmiendich_histone,
                        :tk_txtmiendich_histone,
                        :tk_txtmiendich_ktkhac,
                        :tkkhammat_ngay,
                        :tk_khammat,
                        :tk_cacxetnghiemkhac,
                        :tk_chuy,
                        :tk_dieutri,
                        :tk_henkhamlai,
                        :tk_mabacsydieutri,
                        :tk_bacsydieutri,
                        :tk_quatrinhbenhly,
                        :tk_tomtatketqua,
                        :tk_benhchinh,
                        :tk_mabenhchinh,
                        :tk_benhkemtheo,
                        :tk_mabenhkemtheo,
                        :tk_phuongphapdieutri,
                        :tk_tinhtrangravien,
                        :tk_huongdieutri,
                        :nguoinhanhoso,
                        :nguoigiaohoso,
                        :ngaytongket,
                        :bacsydieutri 
                    )
                   ";
            Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("maquanly", obj.MaQuanLy));
            Command.Parameters.Add(new MDB.MDBParameter("dieutringoaitrutu", obj.DieuTriNgoaiTruTu));
            Command.Parameters.Add(new MDB.MDBParameter("dieutringoaitruden", obj.DieuTriNgoaiTruDen));
            Command.Parameters.Add(new MDB.MDBParameter("socmnd", obj.SoCMND));
            Command.Parameters.Add(new MDB.MDBParameter("baohiem", obj.BaoHiem));
            Command.Parameters.Add(new MDB.MDBParameter("chandoan_tuyentruoc", obj.ChanDoan_TuyenTruoc));
            Command.Parameters.Add(new MDB.MDBParameter("chandoanbandau", obj.ChanDoanBanDau));
            Command.Parameters.Add(new MDB.MDBParameter("chandoantaikham1", obj.ChanDoanTaiKham1));
            Command.Parameters.Add(new MDB.MDBParameter("chandoantaikham2", obj.ChanDoanTaiKham2));
            Command.Parameters.Add(new MDB.MDBParameter("chandoantaikham3", obj.ChanDoanTaiKham3));
            Command.Parameters.Add(new MDB.MDBParameter("chandoantaikham4", obj.ChanDoanTaiKham4));
            Command.Parameters.Add(new MDB.MDBParameter("benhphu", obj.BenhPhu));
            Command.Parameters.Add(new MDB.MDBParameter("ketquadieutri", obj.KetQuaDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("bienchung_text", obj.BienChung_Text));
            Command.Parameters.Add(new MDB.MDBParameter("gdphongkehoach", obj.GDPhongKeHoach));
            Command.Parameters.Add(new MDB.MDBParameter("gdphongkhambenh", obj.GDPhongKhamBenh));
            Command.Parameters.Add(new MDB.MDBParameter("hb_cannang", obj.HB_CanNang));
            Command.Parameters.Add(new MDB.MDBParameter("hb_chieucao", obj.HB_ChieuCao));
            Command.Parameters.Add(new MDB.MDBParameter("tg_khoiphatbenh", obj.TG_KhoiPhatBenh));
            Command.Parameters.Add(new MDB.MDBParameter("trieuchungdautien", obj.TrieuChungDauTien));
            Command.Parameters.Add(new MDB.MDBParameter("tscn_benhkhac", obj.TSCN_BenhKhac));
            Command.Parameters.Add(new MDB.MDBParameter("collagenortumien", obj.CollagenOrTuMien));
            Command.Parameters.Add(new MDB.MDBParameter("xocungbi", obj.XoCungBi));
            Command.Parameters.Add(new MDB.MDBParameter("viemdacoviembico", obj.ViemDaCoViemBiCo));
            Command.Parameters.Add(new MDB.MDBParameter("hoichungsjogren", obj.HoiChungSjogren));
            Command.Parameters.Add(new MDB.MDBParameter("xoganmattienphat", obj.XoGanMatTienPhat));
            Command.Parameters.Add(new MDB.MDBParameter("viemtuyengiaphashimoto", obj.ViemTuyenGiapHashimoto));
            Command.Parameters.Add(new MDB.MDBParameter("hoichungphospholipid", obj.HoiChungPhospholipid));
            Command.Parameters.Add(new MDB.MDBParameter("tscn_benhtumienkhac", obj.TSCN_BenhTuMienKhac));
            Command.Parameters.Add(new MDB.MDBParameter("tscn_songuoibenhtumien", obj.TSCN_SoNguoiBenhTuMien));
            Command.Parameters.Add(new MDB.MDBParameter("tscn_noidungkhac", obj.TSCN_NoiDungKhac));
            Command.Parameters.Add(new MDB.MDBParameter("tscn_cacbenhkhac", obj.TSCN_CacBenhKhac));
            Command.Parameters.Add(new MDB.MDBParameter("tscn_cacbenhkhac_check", obj.TSCN_CacBenhKhac_Check));
            Command.Parameters.Add(new MDB.MDBParameter("tsgd_benhtumien", obj.TSGD_BenhTuMien));
            Command.Parameters.Add(new MDB.MDBParameter("tsgd_noidungbenhtumien", obj.TSGD_NoiDungBenhTuMien));
            Command.Parameters.Add(new MDB.MDBParameter("tsgd_noidungkhac", obj.TSGD_NoiDungKhac));
            Command.Parameters.Add(new MDB.MDBParameter("toantrangconang", obj.ToanTrangCoNang));
            Command.Parameters.Add(new MDB.MDBParameter("ttcn_huyetap", obj.TTCN_HuyetAp));
            Command.Parameters.Add(new MDB.MDBParameter("ttcn_noidungkhac", obj.TTCN_NoiDungKhac));
            Command.Parameters.Add(new MDB.MDBParameter("tonthuongdaniemmac", obj.TonThuongDaNiemMac));
            Command.Parameters.Add(new MDB.MDBParameter("tonthuongkhac", obj.TonThuongKhac));
            Command.Parameters.Add(new MDB.MDBParameter("vitritonthuong", obj.ViTriTonThuong));
            Command.Parameters.Add(new MDB.MDBParameter("vitrikhac", obj.ViTriKhac));
            Command.Parameters.Add(new MDB.MDBParameter("diemhoatdong", obj.DiemHoatDong));
            Command.Parameters.Add(new MDB.MDBParameter("diemthiethai", obj.DiemThietHai));
            Command.Parameters.Add(new MDB.MDBParameter("kcqktimmach", obj.KCQKTimMach));
            Command.Parameters.Add(new MDB.MDBParameter("kcqkthantietnieu", obj.KCQKThanTietNieu));
            Command.Parameters.Add(new MDB.MDBParameter("kcqkhohap", obj.KCQKHoHap));
            Command.Parameters.Add(new MDB.MDBParameter("kcqk_cxk", obj.KCQK_CXK));
            Command.Parameters.Add(new MDB.MDBParameter("kcqktieuhoa", obj.KCQKTieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("kcqk_tktt", obj.KCQK_TKTT));
            Command.Parameters.Add(new MDB.MDBParameter("kcqkcacbophankhac", obj.KCQKCacBoPhanKhac));
            Command.Parameters.Add(new MDB.MDBParameter("ctm_bachcau", obj.CTM_BachCau));
            Command.Parameters.Add(new MDB.MDBParameter("ctm_lympho", obj.CTM_LymPho));
            Command.Parameters.Add(new MDB.MDBParameter("ctm_hc", obj.CTM_HC));
            Command.Parameters.Add(new MDB.MDBParameter("ctm_hb", obj.CTM_HB));
            Command.Parameters.Add(new MDB.MDBParameter("ctm_tieucau", obj.CTM_TieuCau));
            Command.Parameters.Add(new MDB.MDBParameter("maulang1", obj.MauLang1));
            Command.Parameters.Add(new MDB.MDBParameter("maulang2", obj.MauLang2));
            Command.Parameters.Add(new MDB.MDBParameter("sh_creatimin", obj.SH_Creatimin));
            Command.Parameters.Add(new MDB.MDBParameter("sh_ure", obj.SH_Ure));
            Command.Parameters.Add(new MDB.MDBParameter("sh_crphs", obj.SH_CRPhs));
            Command.Parameters.Add(new MDB.MDBParameter("sh_protein", obj.SH_Protein));
            Command.Parameters.Add(new MDB.MDBParameter("sh_alb", obj.SH_ALB));
            Command.Parameters.Add(new MDB.MDBParameter("sh_cholesterol", obj.SH_Cholesterol));
            Command.Parameters.Add(new MDB.MDBParameter("sh_tri", obj.SH_Tri));
            Command.Parameters.Add(new MDB.MDBParameter("sh_got", obj.SH_GOT));
            Command.Parameters.Add(new MDB.MDBParameter("sh_gpt", obj.SH_GPT));
            Command.Parameters.Add(new MDB.MDBParameter("proteinnieu", obj.ProteinNieu));
            Command.Parameters.Add(new MDB.MDBParameter("trunieu", obj.TruNieu));
            Command.Parameters.Add(new MDB.MDBParameter("hcnieu", obj.HCNieu));
            Command.Parameters.Add(new MDB.MDBParameter("nuoctieu24h", obj.NuocTieu24H));
            Command.Parameters.Add(new MDB.MDBParameter("bcnieu", obj.BCNieu));
            Command.Parameters.Add(new MDB.MDBParameter("miendich_ana", obj.MienDich_ANA));
            Command.Parameters.Add(new MDB.MDBParameter("txtmiendich_ana", obj.TXTMienDich_ANA));
            Command.Parameters.Add(new MDB.MDBParameter("miendich_antidna", obj.MienDich_AntiDNA));
            Command.Parameters.Add(new MDB.MDBParameter("txtmiendich_antidna", obj.TXTMienDich_AntiDNA));
            Command.Parameters.Add(new MDB.MDBParameter("miendich_phospholipid", obj.MienDich_PhosphoLiPid));
            Command.Parameters.Add(new MDB.MDBParameter("txtmiendich_phospholipid", obj.TXTMienDich_PhosphoLiPid));
            Command.Parameters.Add(new MDB.MDBParameter("miendich_antism", obj.MienDich_AntiSM));
            Command.Parameters.Add(new MDB.MDBParameter("txtmiendich_antism", obj.TK_TXTMienDich_AntiSM));
            Command.Parameters.Add(new MDB.MDBParameter("miendich_cardiolipin", obj.MienDich_Cardiolipin));
            Command.Parameters.Add(new MDB.MDBParameter("txtmiendich_cardiolipin", obj.TXTMienDich_Cardiolipin));
            Command.Parameters.Add(new MDB.MDBParameter("miendich_antissa", obj.MienDich_AntiSSA));
            Command.Parameters.Add(new MDB.MDBParameter("txtmiendich_antissa", obj.TXTMienDich_AntiSSA));
            Command.Parameters.Add(new MDB.MDBParameter("miendich_khangdonglupus", obj.MienDich_KhangDongLuPus));
            Command.Parameters.Add(new MDB.MDBParameter("txtmiendich_khangdonglupus", obj.TXTMienDich_KhangDongLuPus));
            Command.Parameters.Add(new MDB.MDBParameter("miendich_antissb", obj.MienDich_AntiSSB));
            Command.Parameters.Add(new MDB.MDBParameter("txtmiendich_antissb", obj.TXTMienDich_AntiSSB));
            Command.Parameters.Add(new MDB.MDBParameter("miendich_glycoptotein", obj.MienDich_Glycoptotein));
            Command.Parameters.Add(new MDB.MDBParameter("txtmiendich_glycoptotein", obj.TXTMienDich_Glycoptotein));
            Command.Parameters.Add(new MDB.MDBParameter("miendich_u1", obj.MienDich_U1));
            Command.Parameters.Add(new MDB.MDBParameter("txtmiendich_u1", obj.TXTMienDich_U1));
            Command.Parameters.Add(new MDB.MDBParameter("miendich_histone", obj.MienDich_Histone));
            Command.Parameters.Add(new MDB.MDBParameter("txtmiendich_histone", obj.TXTMienDich_Histone));
            Command.Parameters.Add(new MDB.MDBParameter("txtmiendich_ktkhac", obj.TXTMienDich_KTKhac));
            Command.Parameters.Add(new MDB.MDBParameter("bt_c3", obj.BT_C3));
            Command.Parameters.Add(new MDB.MDBParameter("bt_c4", obj.BT_C4));
            Command.Parameters.Add(new MDB.MDBParameter("btc4", obj.BTC3));
            Command.Parameters.Add(new MDB.MDBParameter("btc3", obj.BTC4));
            Command.Parameters.Add(new MDB.MDBParameter("sinhthiet_check", obj.SinhThiet_Check));
            Command.Parameters.Add(new MDB.MDBParameter("sinhthiet_ngaylam", obj.SinhThiet_NgayLam));
            Command.Parameters.Add(new MDB.MDBParameter("sinhthietda_kq", obj.SinhThietDa_KQ));
            Command.Parameters.Add(new MDB.MDBParameter("sinhthietda_khac", obj.SinhThietDa_Khac));
            Command.Parameters.Add(new MDB.MDBParameter("lupustest", obj.LupusTest));
            Command.Parameters.Add(new MDB.MDBParameter("lupus_neuco", obj.Lupus_NeuCo));
            Command.Parameters.Add(new MDB.MDBParameter("lupusmotaduongtinh", obj.LupusMoTaDuongtinh));
            Command.Parameters.Add(new MDB.MDBParameter("kqkhammat_ngay", obj.KQKhamMat_Ngay));
            Command.Parameters.Add(new MDB.MDBParameter("kqkhammat", obj.KQKhamMat));
            Command.Parameters.Add(new MDB.MDBParameter("cacxetnghiemkhac", obj.CacXetNghiemKhac));
            Command.Parameters.Add(new MDB.MDBParameter("chandoan", obj.ChanDoan));
            Command.Parameters.Add(new MDB.MDBParameter("chandoankhac", obj.ChanDoanKhac));
            Command.Parameters.Add(new MDB.MDBParameter("dieutri", obj.DieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("hb_henkhamlai", obj.HB_HenKhamLai));
            Command.Parameters.Add(new MDB.MDBParameter("mabacsykhambenh", obj.MaBacSyKhamBenh));
            Command.Parameters.Add(new MDB.MDBParameter("bacsykhambenh", obj.BacSyKhamBenh));
            Command.Parameters.Add(new MDB.MDBParameter("tk_sobadientu", obj.TK_SoBADienTu));
            Command.Parameters.Add(new MDB.MDBParameter("tk_soluutru", obj.TK_SoLuuTru));
            Command.Parameters.Add(new MDB.MDBParameter("tk_bacsikham_luutru", obj.TK_BacSiKham_LuuTru));
            Command.Parameters.Add(new MDB.MDBParameter("tk_ngayluutru", obj.TK_NgayLuuTru));
            Command.Parameters.Add(new MDB.MDBParameter("tk_ngayluuhuyetthanh", obj.TK_NgayLuuHuyetThanh)); 
            Command.Parameters.Add(new MDB.MDBParameter("tk_tiensu", obj.TK_TienSu));
            Command.Parameters.Add(new MDB.MDBParameter("tk_mach", obj.TK_Mach));
            Command.Parameters.Add(new MDB.MDBParameter("tk_huyetap", obj.TK_HuyetAp));
            Command.Parameters.Add(new MDB.MDBParameter("tk_nhietdo", obj.TK_NhietDo));
            Command.Parameters.Add(new MDB.MDBParameter("tk_nhiptho", obj.TK_NhipTho));
            Command.Parameters.Add(new MDB.MDBParameter("tk_lamsangkhac", obj.TK_LamSangKhac));
            Command.Parameters.Add(new MDB.MDBParameter("tk_tonthuongdaniemmac", obj.TK_TonThuongDaNiemMac));
            Command.Parameters.Add(new MDB.MDBParameter("tk_diemhoatdong", obj.TK_DiemHoatDong));
            Command.Parameters.Add(new MDB.MDBParameter("tk_diemthiethai", obj.TK_DiemThietHai));
            Command.Parameters.Add(new MDB.MDBParameter("tk_timmach", obj.TK_TimMach));
            Command.Parameters.Add(new MDB.MDBParameter("tk_thantietnieu", obj.TK_ThanTietNieu));
            Command.Parameters.Add(new MDB.MDBParameter("tk_hohap", obj.TK_HoHap));
            Command.Parameters.Add(new MDB.MDBParameter("tk_cxk", obj.TK_CXK));
            Command.Parameters.Add(new MDB.MDBParameter("tk_tieuhoa", obj.TK_TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("tk_tktt", obj.TK_TKTT));
            Command.Parameters.Add(new MDB.MDBParameter("tk_cacbophankhac", obj.TK_CacBoPhanKhac));
            Command.Parameters.Add(new MDB.MDBParameter("tk_bachcau", obj.TK_BachCau));
            Command.Parameters.Add(new MDB.MDBParameter("tk_lympho", obj.TK_LymPho));
            Command.Parameters.Add(new MDB.MDBParameter("tk_hc", obj.TK_HC));
            Command.Parameters.Add(new MDB.MDBParameter("tk_hb", obj.TK_HB));
            Command.Parameters.Add(new MDB.MDBParameter("tk_tieucau", obj.TK_TieuCau));
            Command.Parameters.Add(new MDB.MDBParameter("tk_maulang1", obj.TK_MauLang1));
            Command.Parameters.Add(new MDB.MDBParameter("tk_maulang2", obj.TK_MauLang2));
            Command.Parameters.Add(new MDB.MDBParameter("tk_creatimin", obj.TK_Creatimin));
            Command.Parameters.Add(new MDB.MDBParameter("tk_ure", obj.TK_Ure));
            Command.Parameters.Add(new MDB.MDBParameter("tk_crphs", obj.TK_CRPhs));
            Command.Parameters.Add(new MDB.MDBParameter("tk_protein", obj.TK_Protein));
            Command.Parameters.Add(new MDB.MDBParameter("tk_alb", obj.TK_ALB));
            Command.Parameters.Add(new MDB.MDBParameter("tk_cholesterol", obj.TK_Cholesterol));
            Command.Parameters.Add(new MDB.MDBParameter("tk_tri", obj.TK_Tri));
            Command.Parameters.Add(new MDB.MDBParameter("tk_got", obj.TK_GOT));
            Command.Parameters.Add(new MDB.MDBParameter("tk_gpt", obj.TK_GPT));
            Command.Parameters.Add(new MDB.MDBParameter("tk_proteinnieu", obj.TK_ProteinNieu));
            Command.Parameters.Add(new MDB.MDBParameter("tk_trunieu", obj.TK_TruNieu));
            Command.Parameters.Add(new MDB.MDBParameter("tk_hcnieu", obj.TK_HCNieu));
            Command.Parameters.Add(new MDB.MDBParameter("tk_bcnieu", obj.TK_BCNieu));
            Command.Parameters.Add(new MDB.MDBParameter("tk_nuoctieu24h", obj.TK_NuocTieu24H));
            Command.Parameters.Add(new MDB.MDBParameter("tkmiendich_ana", obj.TKMienDich_ANA));
            Command.Parameters.Add(new MDB.MDBParameter("tk_txtmiendich_ana", obj.TK_TXTMienDich_ANA));
            Command.Parameters.Add(new MDB.MDBParameter("tkmiendich_antidna", obj.TKMienDich_AntiDNA));
            Command.Parameters.Add(new MDB.MDBParameter("tk_txtmiendich_antidna", obj.TK_TXTMienDich_AntiDNA));
            Command.Parameters.Add(new MDB.MDBParameter("tkmiendich_phospholipid", obj.TK_TXTMienDich_PhosphoLiPid));
            Command.Parameters.Add(new MDB.MDBParameter("tk_txtmiendich_phospholipid", obj.TK_TXTMienDich_PhosphoLiPid));
            Command.Parameters.Add(new MDB.MDBParameter("tkmiendich_antism", obj.TKMienDich_AntiSM));
            Command.Parameters.Add(new MDB.MDBParameter("tk_txtmiendich_antism", obj.TK_TXTMienDich_AntiSM));
            Command.Parameters.Add(new MDB.MDBParameter("tkmiendich_cardiolipin", obj.TKMienDich_Cardiolipin));
            Command.Parameters.Add(new MDB.MDBParameter("tk_txtmiendich_cardiolipin", obj.TK_TXTMienDich_Cardiolipin));
            Command.Parameters.Add(new MDB.MDBParameter("tkmiendich_antissa", obj.TKMienDich_AntiSSA));
            Command.Parameters.Add(new MDB.MDBParameter("tk_txtmiendich_antissa", obj.TK_TXTMienDich_AntiSSA));
            Command.Parameters.Add(new MDB.MDBParameter("tkmiendich_khangdonglupus", obj.TKMienDich_KhangDongLuPus));
            Command.Parameters.Add(new MDB.MDBParameter("tk_txtmiendich_khangdonglupus", obj.TK_TXTMienDich_KhangDongLuPus));
            Command.Parameters.Add(new MDB.MDBParameter("tkmiendich_antissb", obj.TKMienDich_AntiSSB));
            Command.Parameters.Add(new MDB.MDBParameter("tk_txtmiendich_antissb", obj.TK_TXTMienDich_AntiSSB));
            Command.Parameters.Add(new MDB.MDBParameter("tkmiendich_glycoptotein", obj.TKMienDich_Glycoptotein));
            Command.Parameters.Add(new MDB.MDBParameter("tk_txtmiendich_glycoptotein", obj.TK_TXTMienDich_Glycoptotein));
            Command.Parameters.Add(new MDB.MDBParameter("tkmiendich_u1", obj.TKMienDich_U1));
            Command.Parameters.Add(new MDB.MDBParameter("tk_txtmiendich_u1", obj.TK_TXTMienDich_U1));
            Command.Parameters.Add(new MDB.MDBParameter("tkmiendich_histone", obj.TKMienDich_Histone));
            Command.Parameters.Add(new MDB.MDBParameter("tk_txtmiendich_histone", obj.TK_TXTMienDich_Histone));
            Command.Parameters.Add(new MDB.MDBParameter("tk_txtmiendich_ktkhac", obj.TK_TXTMienDich_KTKhac));
            Command.Parameters.Add(new MDB.MDBParameter("tkkhammat_ngay", obj.TKKhamMat_Ngay));
            Command.Parameters.Add(new MDB.MDBParameter("tk_khammat", obj.TK_KhamMat));
            Command.Parameters.Add(new MDB.MDBParameter("tk_cacxetnghiemkhac", obj.TK_CacXetNghiemKhac));
            Command.Parameters.Add(new MDB.MDBParameter("tk_chuy", obj.TK_ChuY));
            Command.Parameters.Add(new MDB.MDBParameter("tk_dieutri", obj.TK_DieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("tk_henkhamlai", obj.TK_HenKhamLai));
            Command.Parameters.Add(new MDB.MDBParameter("tk_mabacsydieutri", obj.TK_MaBacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("tk_bacsydieutri", obj.TK_BacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("tk_quatrinhbenhly", obj.TK_QuaTrinhBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("tk_tomtatketqua", obj.TK_TomTatKetQua));
            Command.Parameters.Add(new MDB.MDBParameter("tk_benhchinh", obj.TK_BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("tk_mabenhchinh", obj.TK_MaBenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("tk_benhkemtheo", obj.TK_BenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("tk_mabenhkemtheo", obj.TK_MaBenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("tk_phuongphapdieutri", obj.TK_PhuongPhapDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("tk_tinhtrangravien", obj.TK_TinhTrangRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("tk_huongdieutri", obj.TK_HuongDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("nguoinhanhoso", obj.NguoiNhanHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("nguoigiaohoso", obj.NguoiGiaoHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("ngaytongket", obj.NgayTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("bacsydieutri", obj.BacSyDieuTri));
            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool Update(MDB.MDBConnection MyConnection, BenhAnNgoaiTru_LuPusBanDoManTinh obj)
        {
            string sql = @"UPDATE BENHANDTNTLUPUSMANTINH SET 
                            dieutringoaitrutu=:dieutringoaitrutu,
                            dieutringoaitruden=:dieutringoaitruden,
                            socmnd=:socmnd,
                            baohiem=:baohiem,
                            chandoan_tuyentruoc=:chandoan_tuyentruoc,
                            chandoanbandau=:chandoanbandau,
                            chandoantaikham1=:chandoantaikham1,
                            chandoantaikham2=:chandoantaikham2,
                            chandoantaikham3=:chandoantaikham3,
                            chandoantaikham4=:chandoantaikham4,
                            benhphu=:benhphu,
                            ketquadieutri=:ketquadieutri,
                            bienchung_text=:bienchung_text,
                            gdphongkehoach=:gdphongkehoach,
                            gdphongkhambenh=:gdphongkhambenh,
                            hb_cannang=:hb_cannang,
                            hb_chieucao=:hb_chieucao,
                            tg_khoiphatbenh=:tg_khoiphatbenh,
                            trieuchungdautien=:trieuchungdautien,
                            tscn_benhkhac=:tscn_benhkhac,
                            collagenortumien=:collagenortumien,
                            xocungbi=:xocungbi,
                            viemdacoviembico=:viemdacoviembico,
                            hoichungsjogren=:hoichungsjogren,
                            xoganmattienphat=:xoganmattienphat,
                            viemtuyengiaphashimoto=:viemtuyengiaphashimoto,
                            hoichungphospholipid=:hoichungphospholipid,
                            tscn_benhtumienkhac=:tscn_benhtumienkhac,
                            tscn_songuoibenhtumien=:tscn_songuoibenhtumien,
                            tscn_noidungkhac=:tscn_noidungkhac,
                            tscn_cacbenhkhac=:tscn_cacbenhkhac,
                            tscn_cacbenhkhac_check=:tscn_cacbenhkhac_check,
                            tsgd_benhtumien=:tsgd_benhtumien,
                            tsgd_noidungbenhtumien=:tsgd_noidungbenhtumien,
                            tsgd_noidungkhac=:tsgd_noidungkhac,
                            toantrangconang=:toantrangconang,
                            ttcn_huyetap=:ttcn_huyetap,
                            ttcn_noidungkhac=:ttcn_noidungkhac,
                            tonthuongdaniemmac=:tonthuongdaniemmac,
                            tonthuongkhac=:tonthuongkhac,
                            vitritonthuong=:vitritonthuong,
                            vitrikhac=:vitrikhac,
                            diemhoatdong=:diemhoatdong,
                            diemthiethai=:diemthiethai,
                            kcqktimmach=:kcqktimmach,
                            kcqkthantietnieu=:kcqkthantietnieu,
                            kcqkhohap=:kcqkhohap,
                            kcqk_cxk=:kcqk_cxk,
                            kcqktieuhoa=:kcqktieuhoa,
                            kcqk_tktt=:kcqk_tktt,
                            kcqkcacbophankhac=:kcqkcacbophankhac,
                            ctm_bachcau=:ctm_bachcau,
                            ctm_lympho=:ctm_lympho,
                            ctm_hc=:ctm_hc,
                            ctm_hb=:ctm_hb,
                            ctm_tieucau=:ctm_tieucau,
                            maulang1=:maulang1,
                            maulang2=:maulang2,
                            sh_creatimin=:sh_creatimin,
                            sh_ure=:sh_ure,
                            sh_crphs=:sh_crphs,
                            sh_protein=:sh_protein,
                            sh_alb=:sh_alb,
                            sh_cholesterol=:sh_cholesterol,
                            sh_tri=:sh_tri,
                            sh_got=:sh_got,
                            sh_gpt=:sh_gpt,
                            proteinnieu=:proteinnieu,
                            trunieu=:trunieu,
                            hcnieu=:hcnieu,
                            nuoctieu24h=:nuoctieu24h,
                            bcnieu=:bcnieu,
                            miendich_ana=:miendich_ana,
                            txtmiendich_ana=:txtmiendich_ana,
                            miendich_antidna=:miendich_antidna,
                            txtmiendich_antidna=:txtmiendich_antidna,
                            miendich_phospholipid=:miendich_phospholipid,
                            txtmiendich_phospholipid=:txtmiendich_phospholipid,
                            miendich_antism=:miendich_antism,
                            txtmiendich_antism=:txtmiendich_antism,
                            miendich_cardiolipin=:miendich_cardiolipin,
                            txtmiendich_cardiolipin=:txtmiendich_cardiolipin,
                            miendich_antissa=:miendich_antissa,
                            txtmiendich_antissa=:txtmiendich_antissa,
                            miendich_khangdonglupus=:miendich_khangdonglupus,
                            txtmiendich_khangdonglupus=:txtmiendich_khangdonglupus,
                            miendich_antissb=:miendich_antissb,
                            txtmiendich_antissb=:txtmiendich_antissb,
                            miendich_glycoptotein=:miendich_glycoptotein,
                            txtmiendich_glycoptotein=:txtmiendich_glycoptotein,
                            miendich_u1=:miendich_u1,
                            txtmiendich_u1=:txtmiendich_u1,
                            miendich_histone=:miendich_histone,
                            txtmiendich_histone=:txtmiendich_histone,
                            txtmiendich_ktkhac=:txtmiendich_ktkhac,
                            bt_c3=:bt_c3,
                            bt_c4=:bt_c4,
                            btc4=:btc4,
                            btc3=:btc3,
                            sinhthiet_check=:sinhthiet_check,
                            sinhthiet_ngaylam=:sinhthiet_ngaylam,
                            sinhthietda_kq=:sinhthietda_kq,
                            sinhthietda_khac=:sinhthietda_khac,
                            lupustest=:lupustest,
                            lupus_neuco=:lupus_neuco,
                            lupusmotaduongtinh=:lupusmotaduongtinh,
                            kqkhammat_ngay=:kqkhammat_ngay,
                            kqkhammat=:kqkhammat,
                            cacxetnghiemkhac=:cacxetnghiemkhac,
                            chandoan=:chandoan,
                            chandoankhac=:chandoankhac,
                            dieutri=:dieutri,
                            hb_henkhamlai=:hb_henkhamlai,
                            mabacsykhambenh=:mabacsykhambenh,
                            bacsykhambenh=:bacsykhambenh,
                            tk_sobadientu=:tk_sobadientu,
                            tk_soluutru=:tk_soluutru,
                            tk_bacsikham_luutru=:tk_bacsikham_luutru,
                            tk_ngayluutru=:tk_ngayluutru,
                            tk_ngayluuhuyetthanh=:tk_ngayluuhuyetthanh,
                            tk_tiensu=:tk_tiensu,
                            tk_mach=:tk_mach,
                            tk_huyetap=:tk_huyetap,
                            tk_nhietdo=:tk_nhietdo,
                            tk_nhiptho=:tk_nhiptho,
                            tk_lamsangkhac=:tk_lamsangkhac,
                            tk_tonthuongdaniemmac=:tk_tonthuongdaniemmac,
                            tk_diemhoatdong=:tk_diemhoatdong,
                            tk_diemthiethai=:tk_diemthiethai,
                            tk_timmach=:tk_timmach,
                            tk_thantietnieu=:tk_thantietnieu,
                            tk_hohap=:tk_hohap,
                            tk_cxk=:tk_cxk,
                            tk_tieuhoa=:tk_tieuhoa,
                            tk_tktt=:tk_tktt,
                            tk_cacbophankhac=:tk_cacbophankhac,
                            tk_bachcau=:tk_bachcau,
                            tk_lympho=:tk_lympho,
                            tk_hc=:tk_hc,
                            tk_hb=:tk_hb,
                            tk_tieucau=:tk_tieucau,
                            tk_maulang1=:tk_maulang1,
                            tk_maulang2=:tk_maulang2,
                            tk_creatimin=:tk_creatimin,
                            tk_ure=:tk_ure,
                            tk_crphs=:tk_crphs,
                            tk_protein=:tk_protein,
                            tk_alb=:tk_alb,
                            tk_cholesterol=:tk_cholesterol,
                            tk_tri=:tk_tri,
                            tk_got=:tk_got,
                            tk_gpt=:tk_gpt,
                            tk_proteinnieu=:tk_proteinnieu,
                            tk_trunieu=:tk_trunieu,
                            tk_hcnieu=:tk_hcnieu,
                            tk_bcnieu=:tk_bcnieu,
                            tk_nuoctieu24h=:tk_nuoctieu24h,
                            tkmiendich_ana=:tkmiendich_ana,
                            tk_txtmiendich_ana=:tk_txtmiendich_ana,
                            tkmiendich_antidna=:tkmiendich_antidna,
                            tk_txtmiendich_antidna=:tk_txtmiendich_antidna,
                            tkmiendich_phospholipid=:tkmiendich_phospholipid,
                            tk_txtmiendich_phospholipid=:tk_txtmiendich_phospholipid,
                            tkmiendich_antism=:tkmiendich_antism,
                            tk_txtmiendich_antism=:tk_txtmiendich_antism,
                            tkmiendich_cardiolipin=:tkmiendich_cardiolipin,
                            tk_txtmiendich_cardiolipin=:tk_txtmiendich_cardiolipin,
                            tkmiendich_antissa=:tkmiendich_antissa,
                            tk_txtmiendich_antissa=:tk_txtmiendich_antissa,
                            tkmiendich_khangdonglupus=:tkmiendich_khangdonglupus,
                            tk_txtmiendich_khangdonglupus=:tk_txtmiendich_khangdonglupus,
                            tkmiendich_antissb=:tkmiendich_antissb,
                            tk_txtmiendich_antissb=:tk_txtmiendich_antissb,
                            tkmiendich_glycoptotein=:tkmiendich_glycoptotein,
                            tk_txtmiendich_glycoptotein=:tk_txtmiendich_glycoptotein,
                            tkmiendich_u1=:tkmiendich_u1,
                            tk_txtmiendich_u1=:tk_txtmiendich_u1,
                            tkmiendich_histone=:tkmiendich_histone,
                            tk_txtmiendich_histone=:tk_txtmiendich_histone,
                            tk_txtmiendich_ktkhac=:tk_txtmiendich_ktkhac,
                            tkkhammat_ngay=:tkkhammat_ngay,
                            tk_khammat=:tk_khammat,
                            tk_cacxetnghiemkhac=:tk_cacxetnghiemkhac,
                            tk_chuy=:tk_chuy,
                            tk_dieutri=:tk_dieutri,
                            tk_henkhamlai=:tk_henkhamlai,
                            tk_mabacsydieutri=:tk_mabacsydieutri,
                            tk_bacsydieutri=:tk_bacsydieutri,
                            tk_quatrinhbenhly=:tk_quatrinhbenhly,
                            tk_tomtatketqua=:tk_tomtatketqua,
                            tk_benhchinh=:tk_benhchinh,
                            tk_mabenhchinh=:tk_mabenhchinh,
                            tk_benhkemtheo=:tk_benhkemtheo,
                            tk_mabenhkemtheo=:tk_mabenhkemtheo,
                            tk_phuongphapdieutri=:tk_phuongphapdieutri,
                            tk_tinhtrangravien=:tk_tinhtrangravien,
                            tk_huongdieutri=:tk_huongdieutri,
                            nguoinhanhoso=:nguoinhanhoso,
                            nguoigiaohoso=:nguoigiaohoso,
                            ngaytongket=:ngaytongket,
                            bacsydieutri=:bacsydieutri  
                        WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("dieutringoaitrutu", obj.DieuTriNgoaiTruTu));
            Command.Parameters.Add(new MDB.MDBParameter("dieutringoaitruden", obj.DieuTriNgoaiTruDen));
            Command.Parameters.Add(new MDB.MDBParameter("socmnd", obj.SoCMND));
            Command.Parameters.Add(new MDB.MDBParameter("baohiem", obj.BaoHiem));
            Command.Parameters.Add(new MDB.MDBParameter("chandoan_tuyentruoc", obj.ChanDoan_TuyenTruoc));
            Command.Parameters.Add(new MDB.MDBParameter("chandoanbandau", obj.ChanDoanBanDau));
            Command.Parameters.Add(new MDB.MDBParameter("chandoantaikham1", obj.ChanDoanTaiKham1));
            Command.Parameters.Add(new MDB.MDBParameter("chandoantaikham2", obj.ChanDoanTaiKham2));
            Command.Parameters.Add(new MDB.MDBParameter("chandoantaikham3", obj.ChanDoanTaiKham3));
            Command.Parameters.Add(new MDB.MDBParameter("chandoantaikham4", obj.ChanDoanTaiKham4));
            Command.Parameters.Add(new MDB.MDBParameter("benhphu", obj.BenhPhu));
            Command.Parameters.Add(new MDB.MDBParameter("ketquadieutri", obj.KetQuaDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("bienchung_text", obj.BienChung_Text));
            Command.Parameters.Add(new MDB.MDBParameter("gdphongkehoach", obj.GDPhongKeHoach));
            Command.Parameters.Add(new MDB.MDBParameter("gdphongkhambenh", obj.GDPhongKhamBenh));
            Command.Parameters.Add(new MDB.MDBParameter("hb_cannang", obj.HB_CanNang));
            Command.Parameters.Add(new MDB.MDBParameter("hb_chieucao", obj.HB_ChieuCao));
            Command.Parameters.Add(new MDB.MDBParameter("tg_khoiphatbenh", obj.TG_KhoiPhatBenh));
            Command.Parameters.Add(new MDB.MDBParameter("trieuchungdautien", obj.TrieuChungDauTien));
            Command.Parameters.Add(new MDB.MDBParameter("tscn_benhkhac", obj.TSCN_BenhKhac));
            Command.Parameters.Add(new MDB.MDBParameter("collagenortumien", obj.CollagenOrTuMien));
            Command.Parameters.Add(new MDB.MDBParameter("xocungbi", obj.XoCungBi));
            Command.Parameters.Add(new MDB.MDBParameter("viemdacoviembico", obj.ViemDaCoViemBiCo));
            Command.Parameters.Add(new MDB.MDBParameter("hoichungsjogren", obj.HoiChungSjogren));
            Command.Parameters.Add(new MDB.MDBParameter("xoganmattienphat", obj.XoGanMatTienPhat));
            Command.Parameters.Add(new MDB.MDBParameter("viemtuyengiaphashimoto", obj.ViemTuyenGiapHashimoto));
            Command.Parameters.Add(new MDB.MDBParameter("hoichungphospholipid", obj.HoiChungPhospholipid));
            Command.Parameters.Add(new MDB.MDBParameter("tscn_benhtumienkhac", obj.TSCN_BenhTuMienKhac));
            Command.Parameters.Add(new MDB.MDBParameter("tscn_songuoibenhtumien", obj.TSCN_SoNguoiBenhTuMien)); 
            Command.Parameters.Add(new MDB.MDBParameter("tscn_noidungkhac", obj.TSCN_NoiDungKhac));
            Command.Parameters.Add(new MDB.MDBParameter("tscn_cacbenhkhac", obj.TSCN_CacBenhKhac));
            Command.Parameters.Add(new MDB.MDBParameter("tscn_cacbenhkhac_check", obj.TSCN_CacBenhKhac_Check));
            Command.Parameters.Add(new MDB.MDBParameter("tsgd_benhtumien", obj.TSGD_BenhTuMien));
            Command.Parameters.Add(new MDB.MDBParameter("tsgd_noidungbenhtumien", obj.TSGD_NoiDungBenhTuMien));
            Command.Parameters.Add(new MDB.MDBParameter("tsgd_noidungkhac", obj.TSGD_NoiDungKhac));
            Command.Parameters.Add(new MDB.MDBParameter("toantrangconang", obj.ToanTrangCoNang));
            Command.Parameters.Add(new MDB.MDBParameter("ttcn_huyetap", obj.TTCN_HuyetAp));
            Command.Parameters.Add(new MDB.MDBParameter("ttcn_noidungkhac", obj.TTCN_NoiDungKhac));
            Command.Parameters.Add(new MDB.MDBParameter("tonthuongdaniemmac", obj.TonThuongDaNiemMac));
            Command.Parameters.Add(new MDB.MDBParameter("tonthuongkhac", obj.TonThuongKhac));
            Command.Parameters.Add(new MDB.MDBParameter("vitritonthuong", obj.ViTriTonThuong));
            Command.Parameters.Add(new MDB.MDBParameter("vitrikhac", obj.ViTriKhac));
            Command.Parameters.Add(new MDB.MDBParameter("diemhoatdong", obj.DiemHoatDong));
            Command.Parameters.Add(new MDB.MDBParameter("diemthiethai", obj.DiemThietHai));
            Command.Parameters.Add(new MDB.MDBParameter("kcqktimmach", obj.KCQKTimMach));
            Command.Parameters.Add(new MDB.MDBParameter("kcqkthantietnieu", obj.KCQKThanTietNieu));
            Command.Parameters.Add(new MDB.MDBParameter("kcqkhohap", obj.KCQKHoHap));
            Command.Parameters.Add(new MDB.MDBParameter("kcqk_cxk", obj.KCQK_CXK));
            Command.Parameters.Add(new MDB.MDBParameter("kcqktieuhoa", obj.KCQKTieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("kcqk_tktt", obj.KCQK_TKTT));
            Command.Parameters.Add(new MDB.MDBParameter("kcqkcacbophankhac", obj.KCQKCacBoPhanKhac));
            Command.Parameters.Add(new MDB.MDBParameter("ctm_bachcau", obj.CTM_BachCau));
            Command.Parameters.Add(new MDB.MDBParameter("ctm_lympho", obj.CTM_LymPho));
            Command.Parameters.Add(new MDB.MDBParameter("ctm_hc", obj.CTM_HC));
            Command.Parameters.Add(new MDB.MDBParameter("ctm_hb", obj.CTM_HB));
            Command.Parameters.Add(new MDB.MDBParameter("ctm_tieucau", obj.CTM_TieuCau));
            Command.Parameters.Add(new MDB.MDBParameter("maulang1", obj.MauLang1));
            Command.Parameters.Add(new MDB.MDBParameter("maulang2", obj.MauLang2));
            Command.Parameters.Add(new MDB.MDBParameter("sh_creatimin", obj.SH_Creatimin));
            Command.Parameters.Add(new MDB.MDBParameter("sh_ure", obj.SH_Ure));
            Command.Parameters.Add(new MDB.MDBParameter("sh_crphs", obj.SH_CRPhs));
            Command.Parameters.Add(new MDB.MDBParameter("sh_protein", obj.SH_Protein));
            Command.Parameters.Add(new MDB.MDBParameter("sh_alb", obj.SH_ALB));
            Command.Parameters.Add(new MDB.MDBParameter("sh_cholesterol", obj.SH_Cholesterol));
            Command.Parameters.Add(new MDB.MDBParameter("sh_tri", obj.SH_Tri));
            Command.Parameters.Add(new MDB.MDBParameter("sh_got", obj.SH_GOT));
            Command.Parameters.Add(new MDB.MDBParameter("sh_gpt", obj.SH_GPT));
            Command.Parameters.Add(new MDB.MDBParameter("proteinnieu", obj.ProteinNieu));
            Command.Parameters.Add(new MDB.MDBParameter("trunieu", obj.TruNieu));
            Command.Parameters.Add(new MDB.MDBParameter("hcnieu", obj.HCNieu));
            Command.Parameters.Add(new MDB.MDBParameter("nuoctieu24h", obj.NuocTieu24H));
            Command.Parameters.Add(new MDB.MDBParameter("bcnieu", obj.BCNieu));
            Command.Parameters.Add(new MDB.MDBParameter("miendich_ana", obj.MienDich_ANA));
            Command.Parameters.Add(new MDB.MDBParameter("txtmiendich_ana", obj.TXTMienDich_ANA));
            Command.Parameters.Add(new MDB.MDBParameter("miendich_antidna", obj.MienDich_AntiDNA));
            Command.Parameters.Add(new MDB.MDBParameter("txtmiendich_antidna", obj.TXTMienDich_AntiDNA));
            Command.Parameters.Add(new MDB.MDBParameter("miendich_phospholipid", obj.MienDich_PhosphoLiPid));
            Command.Parameters.Add(new MDB.MDBParameter("txtmiendich_phospholipid", obj.TXTMienDich_PhosphoLiPid));
            Command.Parameters.Add(new MDB.MDBParameter("miendich_antism", obj.MienDich_AntiSM));
            Command.Parameters.Add(new MDB.MDBParameter("txtmiendich_antism", obj.TK_TXTMienDich_AntiSM));
            Command.Parameters.Add(new MDB.MDBParameter("miendich_cardiolipin", obj.MienDich_Cardiolipin));
            Command.Parameters.Add(new MDB.MDBParameter("txtmiendich_cardiolipin", obj.TXTMienDich_Cardiolipin));
            Command.Parameters.Add(new MDB.MDBParameter("miendich_antissa", obj.MienDich_AntiSSA));
            Command.Parameters.Add(new MDB.MDBParameter("txtmiendich_antissa", obj.TXTMienDich_AntiSSA));
            Command.Parameters.Add(new MDB.MDBParameter("miendich_khangdonglupus", obj.MienDich_KhangDongLuPus));
            Command.Parameters.Add(new MDB.MDBParameter("txtmiendich_khangdonglupus", obj.TXTMienDich_KhangDongLuPus));
            Command.Parameters.Add(new MDB.MDBParameter("miendich_antissb", obj.MienDich_AntiSSB));
            Command.Parameters.Add(new MDB.MDBParameter("txtmiendich_antissb", obj.TXTMienDich_AntiSSB));
            Command.Parameters.Add(new MDB.MDBParameter("miendich_glycoptotein", obj.MienDich_Glycoptotein));
            Command.Parameters.Add(new MDB.MDBParameter("txtmiendich_glycoptotein", obj.TXTMienDich_Glycoptotein));
            Command.Parameters.Add(new MDB.MDBParameter("miendich_u1", obj.MienDich_U1));
            Command.Parameters.Add(new MDB.MDBParameter("txtmiendich_u1", obj.TXTMienDich_U1));
            Command.Parameters.Add(new MDB.MDBParameter("miendich_histone", obj.MienDich_Histone));
            Command.Parameters.Add(new MDB.MDBParameter("txtmiendich_histone", obj.TXTMienDich_Histone));
            Command.Parameters.Add(new MDB.MDBParameter("txtmiendich_ktkhac", obj.TXTMienDich_KTKhac));
            Command.Parameters.Add(new MDB.MDBParameter("bt_c3", obj.BT_C3));
            Command.Parameters.Add(new MDB.MDBParameter("bt_c4", obj.BT_C4));
            Command.Parameters.Add(new MDB.MDBParameter("btc4", obj.BTC3));
            Command.Parameters.Add(new MDB.MDBParameter("btc3", obj.BTC4));
            Command.Parameters.Add(new MDB.MDBParameter("sinhthiet_check", obj.SinhThiet_Check));
            Command.Parameters.Add(new MDB.MDBParameter("sinhthiet_ngaylam", obj.SinhThiet_NgayLam));
            Command.Parameters.Add(new MDB.MDBParameter("sinhthietda_kq", obj.SinhThietDa_KQ));
            Command.Parameters.Add(new MDB.MDBParameter("sinhthietda_khac", obj.SinhThietDa_Khac));
            Command.Parameters.Add(new MDB.MDBParameter("lupustest", obj.LupusTest));
            Command.Parameters.Add(new MDB.MDBParameter("lupus_neuco", obj.Lupus_NeuCo));
            Command.Parameters.Add(new MDB.MDBParameter("lupusmotaduongtinh", obj.LupusMoTaDuongtinh));
            Command.Parameters.Add(new MDB.MDBParameter("kqkhammat_ngay", obj.KQKhamMat_Ngay));
            Command.Parameters.Add(new MDB.MDBParameter("kqkhammat", obj.KQKhamMat));
            Command.Parameters.Add(new MDB.MDBParameter("cacxetnghiemkhac", obj.CacXetNghiemKhac));
            Command.Parameters.Add(new MDB.MDBParameter("chandoan", obj.ChanDoan));
            Command.Parameters.Add(new MDB.MDBParameter("chandoankhac", obj.ChanDoanKhac));
            Command.Parameters.Add(new MDB.MDBParameter("dieutri", obj.DieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("hb_henkhamlai", obj.HB_HenKhamLai));
            Command.Parameters.Add(new MDB.MDBParameter("mabacsykhambenh", obj.MaBacSyKhamBenh));
            Command.Parameters.Add(new MDB.MDBParameter("bacsykhambenh", obj.BacSyKhamBenh));
            Command.Parameters.Add(new MDB.MDBParameter("tk_sobadientu", obj.TK_SoBADienTu));
            Command.Parameters.Add(new MDB.MDBParameter("tk_soluutru", obj.TK_SoLuuTru));
            Command.Parameters.Add(new MDB.MDBParameter("tk_bacsikham_luutru", obj.TK_BacSiKham_LuuTru));
            Command.Parameters.Add(new MDB.MDBParameter("tk_ngayluutru", obj.TK_NgayLuuTru));
            Command.Parameters.Add(new MDB.MDBParameter("tk_ngayluuhuyetthanh", obj.TK_NgayLuuHuyetThanh)); 
            Command.Parameters.Add(new MDB.MDBParameter("tk_tiensu", obj.TK_TienSu));
            Command.Parameters.Add(new MDB.MDBParameter("tk_mach", obj.TK_Mach));
            Command.Parameters.Add(new MDB.MDBParameter("tk_huyetap", obj.TK_HuyetAp));
            Command.Parameters.Add(new MDB.MDBParameter("tk_nhietdo", obj.TK_NhietDo));
            Command.Parameters.Add(new MDB.MDBParameter("tk_nhiptho", obj.TK_NhipTho));
            Command.Parameters.Add(new MDB.MDBParameter("tk_lamsangkhac", obj.TK_LamSangKhac));
            Command.Parameters.Add(new MDB.MDBParameter("tk_tonthuongdaniemmac", obj.TK_TonThuongDaNiemMac));
            Command.Parameters.Add(new MDB.MDBParameter("tk_diemhoatdong", obj.TK_DiemHoatDong));
            Command.Parameters.Add(new MDB.MDBParameter("tk_diemthiethai", obj.TK_DiemThietHai));
            Command.Parameters.Add(new MDB.MDBParameter("tk_timmach", obj.TK_TimMach));
            Command.Parameters.Add(new MDB.MDBParameter("tk_thantietnieu", obj.TK_ThanTietNieu));
            Command.Parameters.Add(new MDB.MDBParameter("tk_hohap", obj.TK_HoHap));
            Command.Parameters.Add(new MDB.MDBParameter("tk_cxk", obj.TK_CXK));
            Command.Parameters.Add(new MDB.MDBParameter("tk_tieuhoa", obj.TK_TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("tk_tktt", obj.TK_TKTT));
            Command.Parameters.Add(new MDB.MDBParameter("tk_cacbophankhac", obj.TK_CacBoPhanKhac));
            Command.Parameters.Add(new MDB.MDBParameter("tk_bachcau", obj.TK_BachCau));
            Command.Parameters.Add(new MDB.MDBParameter("tk_lympho", obj.TK_LymPho));
            Command.Parameters.Add(new MDB.MDBParameter("tk_hc", obj.TK_HC));
            Command.Parameters.Add(new MDB.MDBParameter("tk_hb", obj.TK_HB));
            Command.Parameters.Add(new MDB.MDBParameter("tk_tieucau", obj.TK_TieuCau));
            Command.Parameters.Add(new MDB.MDBParameter("tk_maulang1", obj.TK_MauLang1));
            Command.Parameters.Add(new MDB.MDBParameter("tk_maulang2", obj.TK_MauLang2));
            Command.Parameters.Add(new MDB.MDBParameter("tk_creatimin", obj.TK_Creatimin));
            Command.Parameters.Add(new MDB.MDBParameter("tk_ure", obj.TK_Ure));
            Command.Parameters.Add(new MDB.MDBParameter("tk_crphs", obj.TK_CRPhs));
            Command.Parameters.Add(new MDB.MDBParameter("tk_protein", obj.TK_Protein));
            Command.Parameters.Add(new MDB.MDBParameter("tk_alb", obj.TK_ALB));
            Command.Parameters.Add(new MDB.MDBParameter("tk_cholesterol", obj.TK_Cholesterol));
            Command.Parameters.Add(new MDB.MDBParameter("tk_tri", obj.TK_Tri));
            Command.Parameters.Add(new MDB.MDBParameter("tk_got", obj.TK_GOT));
            Command.Parameters.Add(new MDB.MDBParameter("tk_gpt", obj.TK_GPT));
            Command.Parameters.Add(new MDB.MDBParameter("tk_proteinnieu", obj.TK_ProteinNieu));
            Command.Parameters.Add(new MDB.MDBParameter("tk_trunieu", obj.TK_TruNieu));
            Command.Parameters.Add(new MDB.MDBParameter("tk_hcnieu", obj.TK_HCNieu));
            Command.Parameters.Add(new MDB.MDBParameter("tk_bcnieu", obj.TK_BCNieu));
            Command.Parameters.Add(new MDB.MDBParameter("tk_nuoctieu24h", obj.TK_NuocTieu24H));
            Command.Parameters.Add(new MDB.MDBParameter("tkmiendich_ana", obj.TKMienDich_ANA));
            Command.Parameters.Add(new MDB.MDBParameter("tk_txtmiendich_ana", obj.TK_TXTMienDich_ANA));
            Command.Parameters.Add(new MDB.MDBParameter("tkmiendich_antidna", obj.TKMienDich_AntiDNA));
            Command.Parameters.Add(new MDB.MDBParameter("tk_txtmiendich_antidna", obj.TK_TXTMienDich_AntiDNA));
            Command.Parameters.Add(new MDB.MDBParameter("tkmiendich_phospholipid", obj.TK_TXTMienDich_PhosphoLiPid));
            Command.Parameters.Add(new MDB.MDBParameter("tk_txtmiendich_phospholipid", obj.TK_TXTMienDich_PhosphoLiPid));
            Command.Parameters.Add(new MDB.MDBParameter("tkmiendich_antism", obj.TKMienDich_AntiSM));
            Command.Parameters.Add(new MDB.MDBParameter("tk_txtmiendich_antism", obj.TK_TXTMienDich_AntiSM));
            Command.Parameters.Add(new MDB.MDBParameter("tkmiendich_cardiolipin", obj.TKMienDich_Cardiolipin));
            Command.Parameters.Add(new MDB.MDBParameter("tk_txtmiendich_cardiolipin", obj.TK_TXTMienDich_Cardiolipin));
            Command.Parameters.Add(new MDB.MDBParameter("tkmiendich_antissa", obj.TKMienDich_AntiSSA));
            Command.Parameters.Add(new MDB.MDBParameter("tk_txtmiendich_antissa", obj.TK_TXTMienDich_AntiSSA));
            Command.Parameters.Add(new MDB.MDBParameter("tkmiendich_khangdonglupus", obj.TKMienDich_KhangDongLuPus));
            Command.Parameters.Add(new MDB.MDBParameter("tk_txtmiendich_khangdonglupus", obj.TK_TXTMienDich_KhangDongLuPus));
            Command.Parameters.Add(new MDB.MDBParameter("tkmiendich_antissb", obj.TKMienDich_AntiSSB));
            Command.Parameters.Add(new MDB.MDBParameter("tk_txtmiendich_antissb", obj.TK_TXTMienDich_AntiSSB));
            Command.Parameters.Add(new MDB.MDBParameter("tkmiendich_glycoptotein", obj.TKMienDich_Glycoptotein));
            Command.Parameters.Add(new MDB.MDBParameter("tk_txtmiendich_glycoptotein", obj.TK_TXTMienDich_Glycoptotein));
            Command.Parameters.Add(new MDB.MDBParameter("tkmiendich_u1", obj.TKMienDich_U1));
            Command.Parameters.Add(new MDB.MDBParameter("tk_txtmiendich_u1", obj.TK_TXTMienDich_U1));
            Command.Parameters.Add(new MDB.MDBParameter("tkmiendich_histone", obj.TKMienDich_Histone));
            Command.Parameters.Add(new MDB.MDBParameter("tk_txtmiendich_histone", obj.TK_TXTMienDich_Histone));
            Command.Parameters.Add(new MDB.MDBParameter("tk_txtmiendich_ktkhac", obj.TK_TXTMienDich_KTKhac));
            Command.Parameters.Add(new MDB.MDBParameter("tkkhammat_ngay", obj.TKKhamMat_Ngay));
            Command.Parameters.Add(new MDB.MDBParameter("tk_khammat", obj.TK_KhamMat));
            Command.Parameters.Add(new MDB.MDBParameter("tk_cacxetnghiemkhac", obj.TK_CacXetNghiemKhac));
            Command.Parameters.Add(new MDB.MDBParameter("tk_chuy", obj.TK_ChuY));
            Command.Parameters.Add(new MDB.MDBParameter("tk_dieutri", obj.TK_DieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("tk_henkhamlai", obj.TK_HenKhamLai));
            Command.Parameters.Add(new MDB.MDBParameter("tk_mabacsydieutri", obj.TK_MaBacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("tk_bacsydieutri", obj.TK_BacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("tk_quatrinhbenhly", obj.TK_QuaTrinhBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("tk_tomtatketqua", obj.TK_TomTatKetQua));
            Command.Parameters.Add(new MDB.MDBParameter("tk_benhchinh", obj.TK_BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("tk_mabenhchinh", obj.TK_MaBenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("tk_benhkemtheo", obj.TK_BenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("tk_mabenhkemtheo", obj.TK_MaBenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("tk_phuongphapdieutri", obj.TK_PhuongPhapDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("tk_tinhtrangravien", obj.TK_TinhTrangRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("tk_huongdieutri", obj.TK_HuongDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("nguoinhanhoso", obj.NguoiNhanHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("nguoigiaohoso", obj.NguoiGiaoHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("ngaytongket", obj.NgayTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("bacsydieutri", obj.BacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", obj.MaQuanLy));
            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
    }
}
