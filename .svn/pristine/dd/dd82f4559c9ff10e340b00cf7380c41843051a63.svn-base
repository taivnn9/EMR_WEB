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
    public class BenhAnNgoaiTru_LupusBanDoHeThongFunc
    {
        public static void WriteXml(MDB.MDBConnection MyConnection)
        {
            string sql =
                   @"
                  select  a.*,  CTScanner HoSo_CTScanner, SieuAm HoSo_SieuAm, XetNghiem HoSo_XetNghiem,  Khac HoSo_Khac,  Khac_Text HoSo_Khac_Text,  ToanBoHoSo HoSo_ToanBoHoSo, Mach DauSinhTon_Mach,  NhietDo DauSinhTon_NhietDo,  HuyetAp DauSinhTon_HuyetAp,  NhipTho DauSinhTon_NhipTho,  CanNang DauSinhTon_CanNang  
                  from BenhAnLupusBanDoHeThong a inner join thongtindieutri b on a.maquanly = b.maquanly
                  where rownum = 1
                    ";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            var DataTable = new DataTable { TableName = "BenhAnLupusBanDoHeThong" };
            DataTable.Load(DataReader as IDataReader);
            DataTable.WriteXml("rptBenhAnLupusBanDoHeThong.xml");
        }
        public static DataSet SelectDataSet(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql =
                   @"
                  select  a.*, f.hovaten BacSyDieuTriHoVaTen, g.hovaten TK_BacSyDieuTriHoVaTen, d.hovaten NguoiGiaoHoSoHoVaTen,e.hovaten NguoiNhanHoSoHoVaTen, b.XQuang HoSo_XQuang, b.CTScanner HoSo_CTScanner, b.SieuAm HoSo_SieuAm, b.XetNghiem HoSo_XetNghiem,  b.Khac HoSo_Khac,  b.Khac_Text HoSo_Khac_Text,  b.ToanBoHoSo HoSo_ToanBoHoSo
                        from BenhAnLupusBanDoHeThong a  
                  left join thongtindieutri b on a.maquanly = b.maquanly 
                  left join nhanvien f on a.BacSiDieuTri = f.manhanvien
                  left join nhanvien g on a.TK_BacSiDieuTri = g.manhanvien
                  left join nhanvien d on a.NguoiGiaoHoSo = d.manhanvien
                  left join nhanvien e on a.NguoiNhanHoSo = e.manhanvien where a.maquanly = " + MaQuanLy.ToString(System.Globalization.CultureInfo.InvariantCulture);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(sql, MyConnection);
            var ds = new DataSet();
            adt.Fill(ds, "Table");
            List<ThuocToanThan> Corticosteroid = new List<ThuocToanThan>();
            List<ThuocToanThan> KhangSotRet = new List<ThuocToanThan>();
            List<ThuocToanThan> Cyclophosphamide = new List<ThuocToanThan>();
            List<ThuocToanThan> CyclophosphamideLieuCao = new List<ThuocToanThan>();
            List<ThuocToanThan> Azathioprine = new List<ThuocToanThan>();
            List<ThuocToanThan> Methotrexate = new List<ThuocToanThan>();
            List<ThuocToanThan> CyclosporineA = new List<ThuocToanThan>();
            List<ThuocToanThan> ThuocKhac = new List<ThuocToanThan>();


            Corticosteroid.Add(JsonConvert.DeserializeObject<ThuocToanThan>(ds.Tables["Table"].Rows[0]["Corticosteroid"].ToString()));
            KhangSotRet.Add(JsonConvert.DeserializeObject<ThuocToanThan>(ds.Tables["Table"].Rows[0]["KhangSotRet"].ToString()));
            Cyclophosphamide.Add(JsonConvert.DeserializeObject<ThuocToanThan>(ds.Tables["Table"].Rows[0]["Cyclophosphamide"].ToString()));
            CyclophosphamideLieuCao.Add(JsonConvert.DeserializeObject<ThuocToanThan>(ds.Tables["Table"].Rows[0]["CyclophosphamideLieuCao"].ToString()));
            Azathioprine.Add(JsonConvert.DeserializeObject<ThuocToanThan>(ds.Tables["Table"].Rows[0]["Azathioprine"].ToString()));
            Methotrexate.Add(JsonConvert.DeserializeObject<ThuocToanThan>(ds.Tables["Table"].Rows[0]["Methotrexate"].ToString()));
            CyclosporineA.Add(JsonConvert.DeserializeObject<ThuocToanThan>(ds.Tables["Table"].Rows[0]["CyclosporineA"].ToString()));
            ThuocKhac.Add(JsonConvert.DeserializeObject<ThuocToanThan>(ds.Tables["Table"].Rows[0]["ThuocKhac"].ToString()));
            

            ds.Tables.Add(Common.ListToDataTable(Corticosteroid, "Corticosteroid"));
            ds.Tables.Add(Common.ListToDataTable(KhangSotRet, "KhangSotRet"));
            ds.Tables.Add(Common.ListToDataTable(Cyclophosphamide, "Cyclophosphamide"));
            ds.Tables.Add(Common.ListToDataTable(CyclophosphamideLieuCao, "CyclophosphamideLieuCao"));
            ds.Tables.Add(Common.ListToDataTable(Azathioprine, "Azathioprine"));
            ds.Tables.Add(Common.ListToDataTable(Methotrexate, "Methotrexate"));
            ds.Tables.Add(Common.ListToDataTable(CyclosporineA, "CyclosporineA"));
            ds.Tables.Add(Common.ListToDataTable(ThuocKhac, "ThuocKhac"));


            return ds;

        }
        public static BenhAnNgoaiTru_LupusBanDoHeThong Select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            var obj = new BenhAnNgoaiTru_LupusBanDoHeThong();
            try
            {
                #region
                string sql =
                          @"select * 
                        from BenhAnLupusBanDoHeThong 
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
                    obj.Can = DataReader["Can"].ToString();
                    obj.Cao = DataReader["Cao"].ToString();
                    obj.ThoiGianTuKhiKhoiPhat = DataReader["ThoiGianTuKhiKhoiPhat"].ToString();
                    obj.TrieuChungDauTien = DataReader["TrieuChungDauTien"].ToString();
                    obj.TienSuCoBenhTuMienKhac = DataReader.GetInt("TienSuCoBenhTuMienKhac");
                    obj.CoBenhCollagen = DataReader.GetInt("CoBenhCollagen");
                    obj.XoCungBi = DataReader.GetInt("XoCungBi");
                    obj.ViemDaCo = DataReader.GetInt("ViemDaCo");
                    obj.HoiChungSjogren = DataReader.GetInt("HoiChungSjogren");
                    obj.XoGanMatTienPhat = DataReader.GetInt("XoGanMatTienPhat");
                    obj.ViemTuyenGiap = DataReader.GetInt("ViemTuyenGiap");
                    obj.HoiChungKhangPhospholipid = DataReader.GetInt("HoiChungKhangPhospholipid");
                    obj.TienSuCoBenh_Khac = DataReader["TienSuCoBenh_Khac"].ToString();
                    obj.TienSuCaNhan = DataReader.GetInt("TienSuCaNhan");
                    obj.TienSuCaNhan_Co = DataReader["TienSuCaNhan_Co"].ToString();
                    obj.TienSuGiaDinh = DataReader.GetInt("TienSuGiaDinh");
                    obj.TienSuGiaDinh_Co = DataReader["TienSuGiaDinh_Co"].ToString();
                    obj.TienSuGiaDinh_NeuCo = DataReader["TienSuGiaDinh_NeuCo"].ToString();
                    obj.Sot = DataReader.GetInt("Sot");
                    obj.HachTo = DataReader.GetInt("HachTo");
                    obj.MetMoi = DataReader.GetInt("MetMoi");
                    obj.LachTo = DataReader.GetInt("LachTo");
                    obj.HA = DataReader["HA"].ToString();
                    obj.LamSangDaNiemMac = DataReader["LamSangDaNiemMac"].ToString();
                    obj.TonThuongKhac = DataReader["TonThuongKhac"].ToString();
                    obj.YeuCoGoc = DataReader.GetInt("YeuCoGoc");
                    obj.TangCpk = DataReader.GetInt("TangCpk");
                    obj.TangCpk_Co = DataReader["TangCpk_Co"].ToString();
                    obj.DienCoBatThuong = DataReader.GetInt("DienCoBatThuong");
                    obj.SinhThietCoBatThuong = DataReader.GetInt("SinhThietCoBatThuong");
                    obj.DauKhop = DataReader.GetInt("DauKhop");
                    obj.DauKhop_ViTri = DataReader["DauKhop_ViTri"].ToString();
                    obj.DauKhop_SoLuong = DataReader["DauKhop_SoLuong"].ToString();
                    obj.SungKhop = DataReader.GetInt("SungKhop");
                    obj.SungKhop_ViTri = DataReader["SungKhop_ViTri"].ToString();
                    obj.SungKhop_SoLuong = DataReader["SungKhop_SoLuong"].ToString();
                    obj.CungKhop = DataReader.GetInt("CungKhop");
                    obj.CungKhop_ViTri = DataReader["CungKhop_ViTri"].ToString();
                    obj.CungKhop_SoLuong = DataReader["CungKhop_SoLuong"].ToString();
                    obj.DauDauNuaDau = DataReader.GetInt("DauDauNuaDau");
                    obj.ViemMangNaoVoKhuan = DataReader.GetInt("ViemMangNaoVoKhuan");
                    obj.BenhMachNao = DataReader.GetInt("BenhMachNao");
                    obj.MuaGiat = DataReader.GetInt("MuaGiat");
                    obj.DongKinh = DataReader.GetInt("DongKinh");
                    obj.TrangThaiLuLanCapTinh = DataReader.GetInt("TrangThaiLuLanCapTinh");
                    obj.RoiLoanLoAu = DataReader.GetInt("RoiLoanLoAu");
                    obj.RoiLoanChucNangNhanThuc = DataReader.GetInt("RoiLoanChucNangNhanThuc");
                    obj.TramCam = DataReader.GetInt("TramCam");
                    obj.AoTuongAoGiac = DataReader.GetInt("AoTuongAoGiac");
                    obj.HoiChungGuillainBarre = DataReader.GetInt("HoiChungGuillainBarre");
                    obj.RoiLoanThanKinhTuDong = DataReader.GetInt("RoiLoanThanKinhTuDong");
                    obj.NhuocCoNang = DataReader.GetInt("NhuocCoNang");
                    obj.ViemDonDayThanKinh = DataReader.GetInt("ViemDonDayThanKinh");
                    obj.ViemDaDayThanKinh = DataReader.GetInt("ViemDaDayThanKinh");
                    obj.ViemMangTim = DataReader.GetInt("ViemMangTim");
                    obj.TranDichMangNgoaiTim = DataReader.GetInt("TranDichMangNgoaiTim");
                    obj.DauHieuSuyTim = DataReader.GetInt("DauHieuSuyTim");
                    obj.BenhCoTim = DataReader.GetInt("BenhCoTim");
                    obj.BenhVanTim = DataReader.GetInt("BenhVanTim");
                    obj.BenhVanTim_NeuCo = DataReader["BenhVanTim_NeuCo"].ToString();
                    obj.ViemMangPhoi = DataReader.GetInt("ViemMangPhoi");
                    obj.TranDichMangPhoi = DataReader.GetInt("TranDichMangPhoi");
                    obj.ViemPhoiCapTinh = DataReader.GetInt("ViemPhoiCapTinh");
                    obj.ViemPhoiKe = DataReader.GetInt("ViemPhoiKe");
                    obj.ViemPheQuanTacNghen = DataReader.GetInt("ViemPheQuanTacNghen");
                    obj.NhoiMauPhoi = DataReader.GetInt("NhoiMauPhoi");
                    obj.KhoiUAcTinhTaiPhoi = DataReader.GetInt("KhoiUAcTinhTaiPhoi");
                    obj.Non = DataReader.GetInt("Non");
                    obj.DauHoiKhoTieu = DataReader.GetInt("DauHoiKhoTieu");
                    obj.TieuChay = DataReader.GetInt("TieuChay");
                    obj.DauBung = DataReader.GetInt("DauBung");
                    obj.BieuHienTieuHoa_Khac = DataReader["BieuHienTieuHoa_Khac"].ToString();
                    obj.CongThucMau_BachCau = DataReader["CongThucMau_BachCau"].ToString();
                    obj.CongThucMau_Lympho = DataReader["CongThucMau_Lympho"].ToString();
                    obj.CongThucMau_Hc = DataReader["CongThucMau_Hc"].ToString();
                    obj.CongThucMau_Hb = DataReader["CongThucMau_Hb"].ToString();
                    obj.CongThucMau_TieuCau = DataReader["CongThucMau_TieuCau"].ToString();
                    obj.TestCoombTrucTiep = DataReader["TestCoombTrucTiep"].ToString();
                    obj.MauLang_1h = DataReader["MauLang_1h"].ToString();
                    obj.MauLang_2h = DataReader["MauLang_2h"].ToString();
                    obj.SinhHoa_Creatinin = DataReader["SinhHoa_Creatinin"].ToString();
                    obj.SinhHoa_Ure = DataReader["SinhHoa_Ure"].ToString();
                    obj.SinhHoa_ProteinToanPhan = DataReader["SinhHoa_ProteinToanPhan"].ToString();
                    obj.SinhHoa_Alb = DataReader["SinhHoa_Alb"].ToString();
                    obj.SinhHoa_Cholesterol = DataReader["SinhHoa_Cholesterol"].ToString();
                    obj.SinhHoa_Tri = DataReader["SinhHoa_Tri"].ToString();
                    obj.SinhHoa_GOT = DataReader["SinhHoa_GOT"].ToString();
                    obj.SinhHoa_GPT = DataReader["SinhHoa_GPT"].ToString();
                    obj.NuocTieu_ProteinNieu = DataReader.GetInt("NuocTieu_ProteinNieu");
                    obj.NuocTieu_TruNieu = DataReader.GetInt("NuocTieu_TruNieu");
                    obj.NuocTieu_HCNieu = DataReader.GetInt("NuocTieu_HCNieu");
                    obj.NuocTieu_BCNieu = DataReader.GetInt("NuocTieu_BCNieu");
                    obj.NuocTieu_ProteinNieu24h = DataReader["NuocTieu_ProteinNieu24h"].ToString();
                    obj.TeBaoHargaves = DataReader.GetInt("TeBaoHargaves");
                    obj.YeuToDangThapCARF = DataReader["YeuToDangThapCARF"].ToString();
                    obj.Ana = DataReader.GetInt("Ana");
                    obj.Ana_Co = DataReader["Ana_Co"].ToString();
                    obj.AntidsDNA = DataReader.GetInt("AntidsDNA");
                    obj.AntidsDNA_Co = DataReader["AntidsDNA_Co"].ToString();
                    obj.AntiPhospholipid = DataReader.GetInt("AntiPhospholipid");
                    obj.AntiPhospholipid_Co = DataReader["AntiPhospholipid_Co"].ToString();
                    obj.AntiSm = DataReader.GetInt("AntiSm");
                    obj.AntiSm_Co = DataReader["AntiSm_Co"].ToString();
                    obj.AntiCardiolipin = DataReader.GetInt("AntiCardiolipin");
                    obj.AntiCardiolipin_Co = DataReader["AntiCardiolipin_Co"].ToString();
                    obj.AntiSSA = DataReader.GetInt("AntiSSA");
                    obj.AntiSSA_Co = DataReader["AntiSSA_Co"].ToString();
                    obj.KhangDongLupus = DataReader.GetInt("KhangDongLupus");
                    obj.KhangDongLupus_Co = DataReader["KhangDongLupus_Co"].ToString();
                    obj.AntiSSB = DataReader.GetInt("AntiSSB");
                    obj.AntiSSB_Co = DataReader["AntiSSB_Co"].ToString();
                    obj.AntiB2Glycoptotein = DataReader.GetInt("AntiB2Glycoptotein");
                    obj.AntiB2Glycoptotein_Co = DataReader["AntiB2Glycoptotein_Co"].ToString();
                    obj.AntiU1 = DataReader.GetInt("AntiU1");
                    obj.AntiU1_Co = DataReader["AntiU1_Co"].ToString();
                    obj.AntiHistone = DataReader.GetInt("AntiHistone");
                    obj.AntiHistone_Co = DataReader["AntiHistone_Co"].ToString();
                    obj.KTKhac = DataReader["KTKhac"].ToString();
                    obj.TuKhangTheNeuCo = DataReader["TuKhangTheNeuCo"].ToString();
                    obj.TotalIgG = DataReader["TotalIgG"].ToString();
                    obj.C3_Text = DataReader["C3_Text"].ToString();
                    obj.C3 = DataReader.GetInt("C3");
                    obj.C4_Text = DataReader["C4_Text"].ToString();
                    obj.C4 = DataReader.GetInt("C4");
                    obj.SinhThietDa = DataReader.GetInt("SinhThietDa");
                    obj.SinhThietDa_NeuCo = DataReader.GetInt("SinhThietDa_NeuCo");
                    obj.LupusBandTest = DataReader.GetInt("LupusBandTest");
                    obj.LupusBandTest_NeuCo = DataReader.GetInt("LupusBandTest_NeuCo");
                    obj.LupusBandTest_DuongTinh = DataReader["LupusBandTest_DuongTinh"].ToString();
                    obj.SinhThietThan = DataReader["SinhThietThan"].ToString();
                    obj.KhamMat_NgayKham = DataReader["KhamMat_NgayKham"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["KhamMat_NgayKham"]) : null;
                    obj.KhamMat_KetQua = DataReader["KhamMat_KetQua"].ToString();
                    obj.BanDoHinhCanhBuom = DataReader.GetInt("BanDoHinhCanhBuom");
                    obj.BanDoHinhDia = DataReader.GetInt("BanDoHinhDia");
                    obj.NhayCamAnhSang = DataReader.GetInt("NhayCamAnhSang");
                    obj.LoetMieng = DataReader.GetInt("LoetMieng");
                    obj.ViemKhop = DataReader.GetInt("ViemKhop");
                    obj.ViemTranDichThanhMac = DataReader.GetInt("ViemTranDichThanhMac");
                    obj.RoiLoanChucNangThan = DataReader.GetInt("RoiLoanChucNangThan");
                    obj.RoiLoanThanKinhTamThan = DataReader.GetInt("RoiLoanThanKinhTamThan");
                    obj.RoiLoanVeMau = DataReader.GetInt("RoiLoanVeMau");
                    obj.RoiLoanMienDich = DataReader.GetInt("RoiLoanMienDich");
                    obj.AnaDuongTinh = DataReader.GetInt("AnaDuongTinh");
                    obj.Tong11TieuChuan = DataReader["Tong11TieuChuan"].ToString();
                    obj.TieuChuanLamSang = DataReader["TieuChuanLamSang"].ToString();
                    obj.TieuChuanCanLamSang = DataReader["TieuChuanCanLamSang"].ToString();
                    obj.Tong17TieuChuan = DataReader["Tong17TieuChuan"].ToString();
                    obj.DiemSLEDAI_1 = DataReader.GetInt("DiemSLEDAI_1");
                    obj.DiemSLEDAI_2 = DataReader.GetInt("DiemSLEDAI_2");
                    obj.DiemSLEDAI_3 = DataReader.GetInt("DiemSLEDAI_3");
                    obj.DiemSLEDAI_4 = DataReader.GetInt("DiemSLEDAI_4");
                    obj.DiemSLEDAI_5 = DataReader.GetInt("DiemSLEDAI_5");
                    obj.DiemSLEDAI_6 = DataReader.GetInt("DiemSLEDAI_6");
                    obj.DiemSLEDAI_7 = DataReader.GetInt("DiemSLEDAI_7");
                    obj.DiemSLEDAI_8 = DataReader.GetInt("DiemSLEDAI_8");
                    obj.DiemSLEDAI_9 = DataReader.GetInt("DiemSLEDAI_9");
                    obj.DiemSLEDAI_10 = DataReader.GetInt("DiemSLEDAI_10");
                    obj.DiemSLEDAI_11 = DataReader.GetInt("DiemSLEDAI_11");
                    obj.DiemSLEDAI_12 = DataReader.GetInt("DiemSLEDAI_12");
                    obj.DiemSLEDAI_13 = DataReader.GetInt("DiemSLEDAI_13");
                    obj.DiemSLEDAI_14 = DataReader.GetInt("DiemSLEDAI_14");
                    obj.DiemSLEDAI_15 = DataReader.GetInt("DiemSLEDAI_15");
                    obj.DiemSLEDAI_16 = DataReader.GetInt("DiemSLEDAI_16");
                    obj.DiemSLEDAI_17 = DataReader.GetInt("DiemSLEDAI_17");
                    obj.DiemSLEDAI_18 = DataReader.GetInt("DiemSLEDAI_18");
                    obj.DiemSLEDAI_19 = DataReader.GetInt("DiemSLEDAI_19");
                    obj.DiemSLEDAI_20 = DataReader.GetInt("DiemSLEDAI_20");
                    obj.DiemSLEDAI_21 = DataReader.GetInt("DiemSLEDAI_21");
                    obj.DiemSLEDAI_22 = DataReader.GetInt("DiemSLEDAI_22");
                    obj.DiemSLEDAI_23 = DataReader.GetInt("DiemSLEDAI_23");
                    obj.DiemSLEDAI_24 = DataReader.GetInt("DiemSLEDAI_24");
                    obj.DiemSLEDAI_TongDiem = DataReader["DiemSLEDAI_TongDiem"].ToString();
                    obj.DiemSLEQOL_1 = DataReader.GetInt("DiemSLEQOL_1");
                    obj.DiemSLEQOL_2 = DataReader.GetInt("DiemSLEQOL_2");
                    obj.DiemSLEQOL_3 = DataReader.GetInt("DiemSLEQOL_3");
                    obj.DiemSLEQOL_4 = DataReader.GetInt("DiemSLEQOL_4");
                    obj.DiemSLEQOL_5 = DataReader.GetInt("DiemSLEQOL_5");
                    obj.DiemSLEQOL_6 = DataReader.GetInt("DiemSLEQOL_6");
                    obj.DiemSLEQOL_7 = DataReader.GetInt("DiemSLEQOL_7");
                    obj.DiemSLEQOL_8 = DataReader.GetInt("DiemSLEQOL_8");
                    obj.DiemSLEQOL_9 = DataReader.GetInt("DiemSLEQOL_9");
                    obj.DiemSLEQOL_10 = DataReader.GetInt("DiemSLEQOL_10");
                    obj.DiemSLEQOL_11 = DataReader.GetInt("DiemSLEQOL_11");
                    obj.DiemSLEQOL_12 = DataReader.GetInt("DiemSLEQOL_12");
                    obj.DiemSLEQOL_13 = DataReader.GetInt("DiemSLEQOL_13");
                    obj.DiemSLEQOL_14 = DataReader.GetInt("DiemSLEQOL_14");
                    obj.DiemSLEQOL_15 = DataReader.GetInt("DiemSLEQOL_15");
                    obj.DiemSLEQOL_16 = DataReader.GetInt("DiemSLEQOL_16");
                    obj.DiemSLEQOL_17 = DataReader.GetInt("DiemSLEQOL_17");
                    obj.DiemSLEQOL_18 = DataReader.GetInt("DiemSLEQOL_18");
                    obj.DiemSLEQOL_19 = DataReader.GetInt("DiemSLEQOL_19");
                    obj.DiemSLEQOL_20 = DataReader.GetInt("DiemSLEQOL_20");
                    obj.DiemSLEQOL_21 = DataReader.GetInt("DiemSLEQOL_21");
                    obj.DiemSLEQOL_22 = DataReader.GetInt("DiemSLEQOL_22");
                    obj.DiemSLEQOL_23 = DataReader.GetInt("DiemSLEQOL_23");
                    obj.DiemSLEQOL_24 = DataReader.GetInt("DiemSLEQOL_24");
                    obj.DiemSLEQOL_25 = DataReader.GetInt("DiemSLEQOL_25");
                    obj.DiemSLEQOL_26 = DataReader.GetInt("DiemSLEQOL_26");
                    obj.DiemSLEQOL_27 = DataReader.GetInt("DiemSLEQOL_27");
                    obj.DiemSLEQOL_28 = DataReader.GetInt("DiemSLEQOL_28");
                    obj.DiemSLEQOL_29 = DataReader.GetInt("DiemSLEQOL_29");
                    obj.DiemSLEQOL_30 = DataReader.GetInt("DiemSLEQOL_30");
                    obj.DiemSLEQOL_31 = DataReader.GetInt("DiemSLEQOL_31");
                    obj.DiemSLEQOL_32 = DataReader.GetInt("DiemSLEQOL_32");
                    obj.DiemSLEQOL_33 = DataReader.GetInt("DiemSLEQOL_33");
                    obj.DiemSLEQOL_34 = DataReader.GetInt("DiemSLEQOL_34");
                    obj.DiemSLEQOL_35 = DataReader.GetInt("DiemSLEQOL_35");
                    obj.DiemSLEQOL_36 = DataReader.GetInt("DiemSLEQOL_36");
                    obj.DiemSLEQOL_37 = DataReader.GetInt("DiemSLEQOL_37");
                    obj.DiemSLEQOL_38 = DataReader.GetInt("DiemSLEQOL_38");
                    obj.DiemSLEQOL_39 = DataReader.GetInt("DiemSLEQOL_39");
                    obj.DiemSLEQOL_40 = DataReader.GetInt("DiemSLEQOL_40");
                    obj.DiemSLEQOL_1_Text = DataReader["DiemSLEQOL_1_Text"].ToString();
                    obj.DiemSLEQOL_2_Text = DataReader["DiemSLEQOL_2_Text"].ToString();
                    obj.DiemSLEQOL_3_Text = DataReader["DiemSLEQOL_3_Text"].ToString();
                    obj.DiemSLEQOL_4_Text = DataReader["DiemSLEQOL_4_Text"].ToString();
                    obj.DiemSLEQOL_5_Text = DataReader["DiemSLEQOL_5_Text"].ToString();
                    obj.DiemSLEQOL_6_Text = DataReader["DiemSLEQOL_6_Text"].ToString();
                    obj.DiemSLEQOL_7_Text = DataReader["DiemSLEQOL_7_Text"].ToString();
                    obj.DiemSLEQOL_8_Text = DataReader["DiemSLEQOL_8_Text"].ToString();
                    obj.DiemSLEQOL_9_Text = DataReader["DiemSLEQOL_9_Text"].ToString();
                    obj.DiemSLEQOL_10_Text = DataReader["DiemSLEQOL_10_Text"].ToString();
                    obj.DiemSLEQOL_11_Text = DataReader["DiemSLEQOL_11_Text"].ToString();
                    obj.DiemSLEQOL_12_Text = DataReader["DiemSLEQOL_12_Text"].ToString();
                    obj.DiemSLEQOL_13_Text = DataReader["DiemSLEQOL_13_Text"].ToString();
                    obj.DiemSLEQOL_14_Text = DataReader["DiemSLEQOL_14_Text"].ToString();
                    obj.DiemSLEQOL_15_Text = DataReader["DiemSLEQOL_15_Text"].ToString();
                    obj.DiemSLEQOL_16_Text = DataReader["DiemSLEQOL_16_Text"].ToString();
                    obj.DiemSLEQOL_17_Text = DataReader["DiemSLEQOL_17_Text"].ToString();
                    obj.DiemSLEQOL_18_Text = DataReader["DiemSLEQOL_18_Text"].ToString();
                    obj.DiemSLEQOL_19_Text = DataReader["DiemSLEQOL_19_Text"].ToString();
                    obj.DiemSLEQOL_20_Text = DataReader["DiemSLEQOL_20_Text"].ToString();
                    obj.DiemSLEQOL_21_Text = DataReader["DiemSLEQOL_21_Text"].ToString();
                    obj.DiemSLEQOL_22_Text = DataReader["DiemSLEQOL_22_Text"].ToString();
                    obj.DiemSLEQOL_23_Text = DataReader["DiemSLEQOL_23_Text"].ToString();
                    obj.DiemSLEQOL_24_Text = DataReader["DiemSLEQOL_24_Text"].ToString();
                    obj.DiemSLEQOL_25_Text = DataReader["DiemSLEQOL_25_Text"].ToString();
                    obj.DiemSLEQOL_26_Text = DataReader["DiemSLEQOL_26_Text"].ToString();
                    obj.DiemSLEQOL_27_Text = DataReader["DiemSLEQOL_27_Text"].ToString();
                    obj.DiemSLEQOL_28_Text = DataReader["DiemSLEQOL_28_Text"].ToString();
                    obj.DiemSLEQOL_29_Text = DataReader["DiemSLEQOL_29_Text"].ToString();
                    obj.DiemSLEQOL_30_Text = DataReader["DiemSLEQOL_30_Text"].ToString();
                    obj.DiemSLEQOL_31_Text = DataReader["DiemSLEQOL_31_Text"].ToString();
                    obj.DiemSLEQOL_32_Text = DataReader["DiemSLEQOL_32_Text"].ToString();
                    obj.DiemSLEQOL_33_Text = DataReader["DiemSLEQOL_33_Text"].ToString();
                    obj.DiemSLEQOL_34_Text = DataReader["DiemSLEQOL_34_Text"].ToString();
                    obj.DiemSLEQOL_35_Text = DataReader["DiemSLEQOL_35_Text"].ToString();
                    obj.DiemSLEQOL_36_Text = DataReader["DiemSLEQOL_36_Text"].ToString();
                    obj.DiemSLEQOL_37_Text = DataReader["DiemSLEQOL_37_Text"].ToString();
                    obj.DiemSLEQOL_38_Text = DataReader["DiemSLEQOL_38_Text"].ToString();
                    obj.DiemSLEQOL_39_Text = DataReader["DiemSLEQOL_39_Text"].ToString();
                    obj.DiemSLEQOL_40_Text = DataReader["DiemSLEQOL_40_Text"].ToString();
                    obj.DiemSLEQOL_TongDiem = DataReader["DiemSLEQOL_TongDiem"].ToString();
                    obj.Corticosteroid = JsonConvert.DeserializeObject <ThuocToanThan>(DataReader["Corticosteroid"].ToString());
                    obj.KhangSotRet = JsonConvert.DeserializeObject<ThuocToanThan>(DataReader["KhangSotRet"].ToString());
                    obj.Cyclophosphamide = JsonConvert.DeserializeObject<ThuocToanThan>(DataReader["Cyclophosphamide"].ToString());
                    obj.CyclophosphamideLieuCao = JsonConvert.DeserializeObject<ThuocToanThan>(DataReader["CyclophosphamideLieuCao"].ToString());
                    obj.Azathioprine = JsonConvert.DeserializeObject<ThuocToanThan>(DataReader["Azathioprine"].ToString());
                    obj.Methotrexate = JsonConvert.DeserializeObject<ThuocToanThan>(DataReader["Methotrexate"].ToString());
                    obj.CyclosporineA = JsonConvert.DeserializeObject<ThuocToanThan>(DataReader["CyclosporineA"].ToString());
                    obj.ThuocKhac = JsonConvert.DeserializeObject<ThuocToanThan>(DataReader["ThuocKhac"].ToString());
                    obj.DieuTriHienTai = DataReader["DieuTriHienTai"].ToString();
                    obj.HenKham = DataReader["HenKham"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["HenKham"]) : null;
                    obj.BacSiDieuTri = DataReader["BacSiDieuTri"].ToString();
                    obj.TK_SoBenhAnDienTu = DataReader["TK_SoBenhAnDienTu"].ToString();
                    obj.TK_SoLuuTru = DataReader["TK_SoLuuTru"].ToString();
                    obj.NgayKham = DataReader["NgayKham"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayKham"]) : null;
                    obj.NgayLuuHuyetThanh = DataReader["NgayLuuHuyetThanh"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayLuuHuyetThanh"]) : null;
                    obj.BacSiKham = DataReader["BacSiKham"].ToString();
                    obj.MaBacSiKham = DataReader["MaBacSiKham"].ToString();
                    obj.TK_Sot = DataReader.GetInt("TK_Sot");
                    obj.TK_HachTo = DataReader.GetInt("TK_HachTo");
                    obj.TK_MetMoi = DataReader.GetInt("TK_MetMoi");
                    obj.TK_LachTo = DataReader.GetInt("TK_LachTo");
                    obj.TK_HA = DataReader["TK_HA"].ToString();
                    obj.TK_TienSu_BenhThem = DataReader["TK_TienSu_BenhThem"].ToString();
                    obj.TK_Da = DataReader["TK_Da"].ToString();
                    obj.TK_Co = DataReader["TK_Co"].ToString();
                    obj.TK_Khop = DataReader["TK_Khop"].ToString();
                    obj.TK_ThanKinh = DataReader["TK_ThanKinh"].ToString();
                    obj.TK_TimMach = DataReader["TK_TimMach"].ToString();
                    obj.TK_HoHap = DataReader["TK_HoHap"].ToString();
                    obj.TK_TieuHoa = DataReader["TK_TieuHoa"].ToString();
                    obj.TK_TrieuChungKhac = DataReader["TK_TrieuChungKhac"].ToString();
                    obj.TK_CongThucMau_BachCau = DataReader["TK_CongThucMau_BachCau"].ToString();
                    obj.TK_CongThucMau_Lympho = DataReader["TK_CongThucMau_Lympho"].ToString();
                    obj.TK_CongThucMau_Hc = DataReader["TK_CongThucMau_Hc"].ToString();
                    obj.TK_CongThucMau_Hb = DataReader["TK_CongThucMau_Hb"].ToString();
                    obj.TK_CongThucMau_TieuCau = DataReader["TK_CongThucMau_TieuCau"].ToString();
                    obj.TK_TestCoombTrucTiep = DataReader["TK_TestCoombTrucTiep"].ToString();
                    obj.TK_MauLang_1h = DataReader["TK_MauLang_1h"].ToString();
                    obj.TK_MauLang_2h = DataReader["TK_MauLang_2h"].ToString();
                    obj.TK_SinhHoa_Creatinin = DataReader["TK_SinhHoa_Creatinin"].ToString();
                    obj.TK_SinhHoa_Ure = DataReader["TK_SinhHoa_Ure"].ToString();
                    obj.TK_SinhHoa_ProteinToanPhan = DataReader["TK_SinhHoa_ProteinToanPhan"].ToString();
                    obj.TK_SinhHoa_Alb = DataReader["TK_SinhHoa_Alb"].ToString();
                    obj.TK_SinhHoa_Cholesterol = DataReader["TK_SinhHoa_Cholesterol"].ToString();
                    obj.TK_SinhHoa_Tri = DataReader["TK_SinhHoa_Tri"].ToString();
                    obj.TK_SinhHoa_GOT = DataReader["TK_SinhHoa_GOT"].ToString();
                    obj.TK_SinhHoa_GPT = DataReader["TK_SinhHoa_GPT"].ToString();
                    obj.TK_NuocTieu_ProteinNieu = DataReader.GetInt("TK_NuocTieu_ProteinNieu");
                    obj.TK_NuocTieu_TruNieu = DataReader.GetInt("TK_NuocTieu_TruNieu");
                    obj.TK_NuocTieu_HCNieu = DataReader.GetInt("TK_NuocTieu_HCNieu");
                    obj.TK_NuocTieu_BCNieu = DataReader.GetInt("TK_NuocTieu_BCNieu");
                    obj.TK_NuocTieu_ProteinNieu24h = DataReader["TK_NuocTieu_ProteinNieu24h"].ToString();
                    obj.TK_YeuToDangThap_Text = DataReader["TK_YeuToDangThap_Text"].ToString();
                    obj.TK_YeuToDangThap_Khong = DataReader.GetInt("TK_YeuToDangThap_Khong");
                    obj.XuatHienTuKhangThe = DataReader["XuatHienTuKhangThe"].ToString();
                    obj.TK_KhamMat = DataReader["TK_KhamMat"] != DBNull.Value ? (DateTime?) Convert.ToDateTime(DataReader["TK_KhamMat"]) : null;
                    obj.TK_KhamMat_KetQua = DataReader["TK_KhamMat_KetQua"].ToString();
                    obj.TK_XetNghiemKhac = DataReader["TK_XetNghiemKhac"].ToString();
                    obj.TK_DiemSLEQOL_TongDiem = DataReader["TK_DiemSLEQOL_TongDiem"].ToString();
                    obj.TK_ChuY = DataReader["TK_ChuY"].ToString();
                    obj.TK_DieuTri = DataReader["TK_DieuTri"].ToString();


                    obj.TK_HenKham = DataReader["TK_HenKham"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["TK_HenKham"]) : null;
                    obj.TK_BacSiDieuTri = DataReader["TK_BacSiDieuTri"].ToString();
                    obj.TK_MaBacSiDieuTri = DataReader["TK_MaBacSiDieuTri"].ToString();
                    
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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, BenhAnNgoaiTru_LupusBanDoHeThong BenhAnNgoaiTru_LupusBanDoHeThong)
        {
            try
            {
                string sql =
                          @"select MaQuanLy 
                            from BenhAnLupusBanDoHeThong
                            where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnNgoaiTru_LupusBanDoHeThong.MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                int rowCount = 0;
                while (DataReader.Read()) rowCount++;
                if (rowCount == 1) return Update(MyConnection, BenhAnNgoaiTru_LupusBanDoHeThong);
                sql = @"
                       INSERT INTO BenhAnLupusBanDoHeThong 
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
                            Can,
                            Cao,
                            ThoiGianTuKhiKhoiPhat,
                            TrieuChungDauTien,
                            TienSuCoBenhTuMienKhac,
                            CoBenhCollagen,
                            XoCungBi,
                            ViemDaCo,
                            HoiChungSjogren,
                            XoGanMatTienPhat,
                            ViemTuyenGiap,
                            HoiChungKhangPhospholipid,
                            TienSuCoBenh_Khac,
                            TienSuCaNhan,
                            TienSuCaNhan_Co,
                            TienSuGiaDinh,
                            TienSuGiaDinh_Co,
                            TienSuGiaDinh_NeuCo,
                            Sot,
                            HachTo,
                            MetMoi,
                            LachTo,
                            HA,
                            LamSangDaNiemMac,
                            TonThuongKhac,
                            YeuCoGoc,
                            TangCpk,
                            TangCpk_Co,
                            DienCoBatThuong,
                            SinhThietCoBatThuong,
                            DauKhop,
                            DauKhop_ViTri,
                            DauKhop_SoLuong,
                            SungKhop,
                            SungKhop_ViTri,
                            SungKhop_SoLuong,
                            CungKhop,
                            CungKhop_ViTri,
                            CungKhop_SoLuong,
                            DauDauNuaDau,
                            ViemMangNaoVoKhuan,
                            BenhMachNao,
                            MuaGiat,
                            DongKinh,
                            TrangThaiLuLanCapTinh,
                            RoiLoanLoAu,
                            RoiLoanChucNangNhanThuc,
                            TramCam,
                            AoTuongAoGiac,
                            HoiChungGuillainBarre,
                            RoiLoanThanKinhTuDong,
                            NhuocCoNang,
                            ViemDonDayThanKinh,
                            ViemDaDayThanKinh,
                            ViemMangTim,
                            TranDichMangNgoaiTim,
                            DauHieuSuyTim,
                            BenhCoTim,
                            BenhVanTim,
                            BenhVanTim_NeuCo,
                            ViemMangPhoi,
                            TranDichMangPhoi,
                            ViemPhoiCapTinh,
                            ViemPhoiKe,
                            ViemPheQuanTacNghen,
                            NhoiMauPhoi,
                            KhoiUAcTinhTaiPhoi,
                            Non,
                            DauHoiKhoTieu,
                            TieuChay,
                            DauBung,
                            BieuHienTieuHoa_Khac,
                            CongThucMau_BachCau,
                            CongThucMau_Lympho,
                            CongThucMau_Hc,
                            CongThucMau_Hb,
                            CongThucMau_TieuCau,
                            TestCoombTrucTiep,
                            MauLang_1h,
                            MauLang_2h,
                            SinhHoa_Creatinin,
                            SinhHoa_Ure,
                            SinhHoa_ProteinToanPhan,
                            SinhHoa_Alb,
                            SinhHoa_Cholesterol,
                            SinhHoa_Tri,
                            SinhHoa_GOT,
                            SinhHoa_GPT,
                            NuocTieu_ProteinNieu,
                            NuocTieu_TruNieu,
                            NuocTieu_HCNieu,
                            NuocTieu_BCNieu,
                            NuocTieu_ProteinNieu24h,
                            TeBaoHargaves,
                            YeuToDangThapCARF,
                            Ana,
                            Ana_Co,
                            AntidsDNA,
                            AntidsDNA_Co,
                            AntiPhospholipid,
                            AntiPhospholipid_Co,
                            AntiSm,
                            AntiSm_Co,
                            AntiCardiolipin,
                            AntiCardiolipin_Co,
                            AntiSSA,
                            AntiSSA_Co,
                            KhangDongLupus,
                            KhangDongLupus_Co,
                            AntiSSB,
                            AntiSSB_Co,
                            AntiB2Glycoptotein,
                            AntiB2Glycoptotein_Co,
                            AntiU1,
                            AntiU1_Co,
                            AntiHistone,
                            AntiHistone_Co,
                            KTKhac,
                            TuKhangTheNeuCo,
                            TotalIgG,
                            C3_Text,
                            C3,
                            C4_Text,
                            C4,
                            SinhThietDa,
                            SinhThietDa_NeuCo,
                            LupusBandTest,
                            LupusBandTest_NeuCo,
                            LupusBandTest_DuongTinh,
                            SinhThietThan,
                            KhamMat_NgayKham,
                            KhamMat_KetQua,
                            BanDoHinhCanhBuom,
                            BanDoHinhDia,
                            NhayCamAnhSang,
                            LoetMieng,
                            ViemKhop,
                            ViemTranDichThanhMac,
                            RoiLoanChucNangThan,
                            RoiLoanThanKinhTamThan,
                            RoiLoanVeMau,
                            RoiLoanMienDich,
                            AnaDuongTinh,
                            Tong11TieuChuan,
                            TieuChuanLamSang,
                            TieuChuanCanLamSang,
                            Tong17TieuChuan,
                            DiemSLEDAI_1,
                            DiemSLEDAI_2,
                            DiemSLEDAI_3,
                            DiemSLEDAI_4,
                            DiemSLEDAI_5,
                            DiemSLEDAI_6,
                            DiemSLEDAI_7,
                            DiemSLEDAI_8,
                            DiemSLEDAI_9,
                            DiemSLEDAI_10,
                            DiemSLEDAI_11,
                            DiemSLEDAI_12,
                            DiemSLEDAI_13,
                            DiemSLEDAI_14,
                            DiemSLEDAI_15,
                            DiemSLEDAI_16,
                            DiemSLEDAI_17,
                            DiemSLEDAI_18,
                            DiemSLEDAI_19,
                            DiemSLEDAI_20,
                            DiemSLEDAI_21,
                            DiemSLEDAI_22,
                            DiemSLEDAI_23,
                            DiemSLEDAI_24,
                            DiemSLEDAI_TongDiem,
                            DiemSLEQOL_1,
                            DiemSLEQOL_2,
                            DiemSLEQOL_3,
                            DiemSLEQOL_4,
                            DiemSLEQOL_5,
                            DiemSLEQOL_6,
                            DiemSLEQOL_7,
                            DiemSLEQOL_8,
                            DiemSLEQOL_9,
                            DiemSLEQOL_10,
                            DiemSLEQOL_11,
                            DiemSLEQOL_12,
                            DiemSLEQOL_13,
                            DiemSLEQOL_14,
                            DiemSLEQOL_15,
                            DiemSLEQOL_16,
                            DiemSLEQOL_17,
                            DiemSLEQOL_18,
                            DiemSLEQOL_19,
                            DiemSLEQOL_20,
                            DiemSLEQOL_21,
                            DiemSLEQOL_22,
                            DiemSLEQOL_23,
                            DiemSLEQOL_24,
                            DiemSLEQOL_25,
                            DiemSLEQOL_26,
                            DiemSLEQOL_27,
                            DiemSLEQOL_28,
                            DiemSLEQOL_29,
                            DiemSLEQOL_30,
                            DiemSLEQOL_31,
                            DiemSLEQOL_32,
                            DiemSLEQOL_33,
                            DiemSLEQOL_34,
                            DiemSLEQOL_35,
                            DiemSLEQOL_36,
                            DiemSLEQOL_37,
                            DiemSLEQOL_38,
                            DiemSLEQOL_39,
                            DiemSLEQOL_40,
                            DiemSLEQOL_1_Text,
                            DiemSLEQOL_2_Text,
                            DiemSLEQOL_3_Text,
                            DiemSLEQOL_4_Text,
                            DiemSLEQOL_5_Text,
                            DiemSLEQOL_6_Text,
                            DiemSLEQOL_7_Text,
                            DiemSLEQOL_8_Text,
                            DiemSLEQOL_9_Text,
                            DiemSLEQOL_10_Text,
                            DiemSLEQOL_11_Text,
                            DiemSLEQOL_12_Text,
                            DiemSLEQOL_13_Text,
                            DiemSLEQOL_14_Text,
                            DiemSLEQOL_15_Text,
                            DiemSLEQOL_16_Text,
                            DiemSLEQOL_17_Text,
                            DiemSLEQOL_18_Text,
                            DiemSLEQOL_19_Text,
                            DiemSLEQOL_20_Text,
                            DiemSLEQOL_21_Text,
                            DiemSLEQOL_22_Text,
                            DiemSLEQOL_23_Text,
                            DiemSLEQOL_24_Text,
                            DiemSLEQOL_25_Text,
                            DiemSLEQOL_26_Text,
                            DiemSLEQOL_27_Text,
                            DiemSLEQOL_28_Text,
                            DiemSLEQOL_29_Text,
                            DiemSLEQOL_30_Text,
                            DiemSLEQOL_31_Text,
                            DiemSLEQOL_32_Text,
                            DiemSLEQOL_33_Text,
                            DiemSLEQOL_34_Text,
                            DiemSLEQOL_35_Text,
                            DiemSLEQOL_36_Text,
                            DiemSLEQOL_37_Text,
                            DiemSLEQOL_38_Text,
                            DiemSLEQOL_39_Text,
                            DiemSLEQOL_40_Text,
                            DiemSLEQOL_TongDiem,
                            Corticosteroid,
                            KhangSotRet,
                            Cyclophosphamide,
                            CyclophosphamideLieuCao,
                            Azathioprine,
                            Methotrexate,
                            CyclosporineA,
                            ThuocKhac,
                            DieuTriHienTai,
                            HenKham,
                            BacSiDieuTri,
                            TK_SoBenhAnDienTu,
                            TK_SoLuuTru,
                            NgayKham,
                            NgayLuuHuyetThanh,
                            BacSiKham,
                            MaBacSiKham,
                            TK_Sot,
                            TK_HachTo,
                            TK_MetMoi,
                            TK_LachTo,
                            TK_HA,
                            TK_TienSu_BenhThem,
                            TK_Da,
                            TK_Co,
                            TK_Khop,
                            TK_ThanKinh,
                            TK_TimMach,
                            TK_HoHap,
                            TK_TieuHoa,
                            TK_TrieuChungKhac,
                            TK_CongThucMau_BachCau,
                            TK_CongThucMau_Lympho,
                            TK_CongThucMau_Hc,
                            TK_CongThucMau_Hb,
                            TK_CongThucMau_TieuCau,
                            TK_TestCoombTrucTiep,
                            TK_MauLang_1h,
                            TK_MauLang_2h,
                            TK_SinhHoa_Creatinin,
                            TK_SinhHoa_Ure,
                            TK_SinhHoa_ProteinToanPhan,
                            TK_SinhHoa_Alb,
                            TK_SinhHoa_Cholesterol,
                            TK_SinhHoa_Tri,
                            TK_SinhHoa_GOT,
                            TK_SinhHoa_GPT,
                            TK_NuocTieu_ProteinNieu,
                            TK_NuocTieu_TruNieu,
                            TK_NuocTieu_HCNieu,
                            TK_NuocTieu_BCNieu,
                            TK_NuocTieu_ProteinNieu24h,
                            TK_YeuToDangThap_Text,
                            TK_YeuToDangThap_Khong,
                            XuatHienTuKhangThe,
                            TK_KhamMat,
                            TK_KhamMat_KetQua,
                            TK_XetNghiemKhac,
                            TK_DiemSLEQOL_TongDiem,
                            TK_ChuY,
                            TK_DieuTri,
                            TK_HenKham,
                            TK_BacSiDieuTri,
                            TK_MaBacSiDieuTri,
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
                            :Can,
                            :Cao,
                            :ThoiGianTuKhiKhoiPhat,
                            :TrieuChungDauTien,
                            :TienSuCoBenhTuMienKhac,
                            :CoBenhCollagen,
                            :XoCungBi,
                            :ViemDaCo,
                            :HoiChungSjogren,
                            :XoGanMatTienPhat,
                            :ViemTuyenGiap,
                            :HoiChungKhangPhospholipid,
                            :TienSuCoBenh_Khac,
                            :TienSuCaNhan,
                            :TienSuCaNhan_Co,
                            :TienSuGiaDinh,
                            :TienSuGiaDinh_Co,
                            :TienSuGiaDinh_NeuCo,
                            :Sot,
                            :HachTo,
                            :MetMoi,
                            :LachTo,
                            :HA,
                            :LamSangDaNiemMac,
                            :TonThuongKhac,
                            :YeuCoGoc,
                            :TangCpk,
                            :TangCpk_Co,
                            :DienCoBatThuong,
                            :SinhThietCoBatThuong,
                            :DauKhop,
                            :DauKhop_ViTri,
                            :DauKhop_SoLuong,
                            :SungKhop,
                            :SungKhop_ViTri,
                            :SungKhop_SoLuong,
                            :CungKhop,
                            :CungKhop_ViTri,
                            :CungKhop_SoLuong,
                            :DauDauNuaDau,
                            :ViemMangNaoVoKhuan,
                            :BenhMachNao,
                            :MuaGiat,
                            :DongKinh,
                            :TrangThaiLuLanCapTinh,
                            :RoiLoanLoAu,
                            :RoiLoanChucNangNhanThuc,
                            :TramCam,
                            :AoTuongAoGiac,
                            :HoiChungGuillainBarre,
                            :RoiLoanThanKinhTuDong,
                            :NhuocCoNang,
                            :ViemDonDayThanKinh,
                            :ViemDaDayThanKinh,
                            :ViemMangTim,
                            :TranDichMangNgoaiTim,
                            :DauHieuSuyTim,
                            :BenhCoTim,
                            :BenhVanTim,
                            :BenhVanTim_NeuCo,
                            :ViemMangPhoi,
                            :TranDichMangPhoi,
                            :ViemPhoiCapTinh,
                            :ViemPhoiKe,
                            :ViemPheQuanTacNghen,
                            :NhoiMauPhoi,
                            :KhoiUAcTinhTaiPhoi,
                            :Non,
                            :DauHoiKhoTieu,
                            :TieuChay,
                            :DauBung,
                            :BieuHienTieuHoa_Khac,
                            :CongThucMau_BachCau,
                            :CongThucMau_Lympho,
                            :CongThucMau_Hc,
                            :CongThucMau_Hb,
                            :CongThucMau_TieuCau,
                            :TestCoombTrucTiep,
                            :MauLang_1h,
                            :MauLang_2h,
                            :SinhHoa_Creatinin,
                            :SinhHoa_Ure,
                            :SinhHoa_ProteinToanPhan,
                            :SinhHoa_Alb,
                            :SinhHoa_Cholesterol,
                            :SinhHoa_Tri,
                            :SinhHoa_GOT,
                            :SinhHoa_GPT,
                            :NuocTieu_ProteinNieu,
                            :NuocTieu_TruNieu,
                            :NuocTieu_HCNieu,
                            :NuocTieu_BCNieu,
                            :NuocTieu_ProteinNieu24h,
                            :TeBaoHargaves,
                            :YeuToDangThapCARF,
                            :Ana,
                            :Ana_Co,
                            :AntidsDNA,
                            :AntidsDNA_Co,
                            :AntiPhospholipid,
                            :AntiPhospholipid_Co,
                            :AntiSm,
                            :AntiSm_Co,
                            :AntiCardiolipin,
                            :AntiCardiolipin_Co,
                            :AntiSSA,
                            :AntiSSA_Co,
                            :KhangDongLupus,
                            :KhangDongLupus_Co,
                            :AntiSSB,
                            :AntiSSB_Co,
                            :AntiB2Glycoptotein,
                            :AntiB2Glycoptotein_Co,
                            :AntiU1,
                            :AntiU1_Co,
                            :AntiHistone,
                            :AntiHistone_Co,
                            :KTKhac,
                            :TuKhangTheNeuCo,
                            :TotalIgG,
                            :C3_Text,
                            :C3,
                            :C4_Text,
                            :C4,
                            :SinhThietDa,
                            :SinhThietDa_NeuCo,
                            :LupusBandTest,
                            :LupusBandTest_NeuCo,
                            :LupusBandTest_DuongTinh,
                            :SinhThietThan,
                            :KhamMat_NgayKham,
                            :KhamMat_KetQua,
                            :BanDoHinhCanhBuom,
                            :BanDoHinhDia,
                            :NhayCamAnhSang,
                            :LoetMieng,
                            :ViemKhop,
                            :ViemTranDichThanhMac,
                            :RoiLoanChucNangThan,
                            :RoiLoanThanKinhTamThan,
                            :RoiLoanVeMau,
                            :RoiLoanMienDich,
                            :AnaDuongTinh,
                            :Tong11TieuChuan,
                            :TieuChuanLamSang,
                            :TieuChuanCanLamSang,
                            :Tong17TieuChuan,
                            :DiemSLEDAI_1,
                            :DiemSLEDAI_2,
                            :DiemSLEDAI_3,
                            :DiemSLEDAI_4,
                            :DiemSLEDAI_5,
                            :DiemSLEDAI_6,
                            :DiemSLEDAI_7,
                            :DiemSLEDAI_8,
                            :DiemSLEDAI_9,
                            :DiemSLEDAI_10,
                            :DiemSLEDAI_11,
                            :DiemSLEDAI_12,
                            :DiemSLEDAI_13,
                            :DiemSLEDAI_14,
                            :DiemSLEDAI_15,
                            :DiemSLEDAI_16,
                            :DiemSLEDAI_17,
                            :DiemSLEDAI_18,
                            :DiemSLEDAI_19,
                            :DiemSLEDAI_20,
                            :DiemSLEDAI_21,
                            :DiemSLEDAI_22,
                            :DiemSLEDAI_23,
                            :DiemSLEDAI_24,
                            :DiemSLEDAI_TongDiem,
                            :DiemSLEQOL_1,
                            :DiemSLEQOL_2,
                            :DiemSLEQOL_3,
                            :DiemSLEQOL_4,
                            :DiemSLEQOL_5,
                            :DiemSLEQOL_6,
                            :DiemSLEQOL_7,
                            :DiemSLEQOL_8,
                            :DiemSLEQOL_9,
                            :DiemSLEQOL_10,
                            :DiemSLEQOL_11,
                            :DiemSLEQOL_12,
                            :DiemSLEQOL_13,
                            :DiemSLEQOL_14,
                            :DiemSLEQOL_15,
                            :DiemSLEQOL_16,
                            :DiemSLEQOL_17,
                            :DiemSLEQOL_18,
                            :DiemSLEQOL_19,
                            :DiemSLEQOL_20,
                            :DiemSLEQOL_21,
                            :DiemSLEQOL_22,
                            :DiemSLEQOL_23,
                            :DiemSLEQOL_24,
                            :DiemSLEQOL_25,
                            :DiemSLEQOL_26,
                            :DiemSLEQOL_27,
                            :DiemSLEQOL_28,
                            :DiemSLEQOL_29,
                            :DiemSLEQOL_30,
                            :DiemSLEQOL_31,
                            :DiemSLEQOL_32,
                            :DiemSLEQOL_33,
                            :DiemSLEQOL_34,
                            :DiemSLEQOL_35,
                            :DiemSLEQOL_36,
                            :DiemSLEQOL_37,
                            :DiemSLEQOL_38,
                            :DiemSLEQOL_39,
                            :DiemSLEQOL_40,
                            :DiemSLEQOL_1_Text,
                            :DiemSLEQOL_2_Text,
                            :DiemSLEQOL_3_Text,
                            :DiemSLEQOL_4_Text,
                            :DiemSLEQOL_5_Text,
                            :DiemSLEQOL_6_Text,
                            :DiemSLEQOL_7_Text,
                            :DiemSLEQOL_8_Text,
                            :DiemSLEQOL_9_Text,
                            :DiemSLEQOL_10_Text,
                            :DiemSLEQOL_11_Text,
                            :DiemSLEQOL_12_Text,
                            :DiemSLEQOL_13_Text,
                            :DiemSLEQOL_14_Text,
                            :DiemSLEQOL_15_Text,
                            :DiemSLEQOL_16_Text,
                            :DiemSLEQOL_17_Text,
                            :DiemSLEQOL_18_Text,
                            :DiemSLEQOL_19_Text,
                            :DiemSLEQOL_20_Text,
                            :DiemSLEQOL_21_Text,
                            :DiemSLEQOL_22_Text,
                            :DiemSLEQOL_23_Text,
                            :DiemSLEQOL_24_Text,
                            :DiemSLEQOL_25_Text,
                            :DiemSLEQOL_26_Text,
                            :DiemSLEQOL_27_Text,
                            :DiemSLEQOL_28_Text,
                            :DiemSLEQOL_29_Text,
                            :DiemSLEQOL_30_Text,
                            :DiemSLEQOL_31_Text,
                            :DiemSLEQOL_32_Text,
                            :DiemSLEQOL_33_Text,
                            :DiemSLEQOL_34_Text,
                            :DiemSLEQOL_35_Text,
                            :DiemSLEQOL_36_Text,
                            :DiemSLEQOL_37_Text,
                            :DiemSLEQOL_38_Text,
                            :DiemSLEQOL_39_Text,
                            :DiemSLEQOL_40_Text,
                            :DiemSLEQOL_TongDiem,
                            :Corticosteroid,
                            :KhangSotRet,
                            :Cyclophosphamide,
                            :CyclophosphamideLieuCao,
                            :Azathioprine,
                            :Methotrexate,
                            :CyclosporineA,
                            :ThuocKhac,
                            :DieuTriHienTai,
                            :HenKham,
                            :BacSiDieuTri,
                            :TK_SoBenhAnDienTu,
                            :TK_SoLuuTru,
                            :NgayKham,
                            :NgayLuuHuyetThanh,
                            :BacSiKham,
                            :MaBacSiKham,
                            :TK_Sot,
                            :TK_HachTo,
                            :TK_MetMoi,
                            :TK_LachTo,
                            :TK_HA,
                            :TK_TienSu_BenhThem,
                            :TK_Da,
                            :TK_Co,
                            :TK_Khop,
                            :TK_ThanKinh,
                            :TK_TimMach,
                            :TK_HoHap,
                            :TK_TieuHoa,
                            :TK_TrieuChungKhac,
                            :TK_CongThucMau_BachCau,
                            :TK_CongThucMau_Lympho,
                            :TK_CongThucMau_Hc,
                            :TK_CongThucMau_Hb,
                            :TK_CongThucMau_TieuCau,
                            :TK_TestCoombTrucTiep,
                            :TK_MauLang_1h,
                            :TK_MauLang_2h,
                            :TK_SinhHoa_Creatinin,
                            :TK_SinhHoa_Ure,
                            :TK_SinhHoa_ProteinToanPhan,
                            :TK_SinhHoa_Alb,
                            :TK_SinhHoa_Cholesterol,
                            :TK_SinhHoa_Tri,
                            :TK_SinhHoa_GOT,
                            :TK_SinhHoa_GPT,
                            :TK_NuocTieu_ProteinNieu,
                            :TK_NuocTieu_TruNieu,
                            :TK_NuocTieu_HCNieu,
                            :TK_NuocTieu_BCNieu,
                            :TK_NuocTieu_ProteinNieu24h,
                            :TK_YeuToDangThap_Text,
                            :TK_YeuToDangThap_Khong,
                            :XuatHienTuKhangThe,
                            :TK_KhamMat,
                            :TK_KhamMat_KetQua,
                            :TK_XetNghiemKhac,
                            :TK_DiemSLEQOL_TongDiem,
                            :TK_ChuY,
                            :TK_DieuTri,
                            :TK_HenKham,
                            :TK_BacSiDieuTri,
                            :TK_MaBacSiDieuTri,
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
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnNgoaiTru_LupusBanDoHeThong.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriNgoaiTruTu", BenhAnNgoaiTru_LupusBanDoHeThong.DieuTriNgoaiTruTu));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriNgoaiTruDen", BenhAnNgoaiTru_LupusBanDoHeThong.DieuTriNgoaiTruDen));
                Command.Parameters.Add(new MDB.MDBParameter("SoCMND", BenhAnNgoaiTru_LupusBanDoHeThong.SoCMND));
                Command.Parameters.Add(new MDB.MDBParameter("BaoHiem", BenhAnNgoaiTru_LupusBanDoHeThong.BaoHiem));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan_TuyenTruoc", BenhAnNgoaiTru_LupusBanDoHeThong.ChanDoan_TuyenTruoc));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanBanDau", BenhAnNgoaiTru_LupusBanDoHeThong.ChanDoanBanDau));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham1", BenhAnNgoaiTru_LupusBanDoHeThong.ChanDoanTaiKham1));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham2", BenhAnNgoaiTru_LupusBanDoHeThong.ChanDoanTaiKham2));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham3", BenhAnNgoaiTru_LupusBanDoHeThong.ChanDoanTaiKham3));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham4", BenhAnNgoaiTru_LupusBanDoHeThong.ChanDoanTaiKham4));
                Command.Parameters.Add(new MDB.MDBParameter("BenhPhu", BenhAnNgoaiTru_LupusBanDoHeThong.BenhPhu));
                Command.Parameters.Add(new MDB.MDBParameter("KetQuaDieuTri", BenhAnNgoaiTru_LupusBanDoHeThong.KetQuaDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("BienChung_Text", BenhAnNgoaiTru_LupusBanDoHeThong.BienChung_Text));
                Command.Parameters.Add(new MDB.MDBParameter("GDPhongKeHoach", BenhAnNgoaiTru_LupusBanDoHeThong.GDPhongKeHoach));
                Command.Parameters.Add(new MDB.MDBParameter("GDPhongKhamBenh", BenhAnNgoaiTru_LupusBanDoHeThong.GDPhongKhamBenh));

                // hỏi bệnh, khám bệnh
                Command.Parameters.Add(new MDB.MDBParameter("Can", BenhAnNgoaiTru_LupusBanDoHeThong.Can));
                Command.Parameters.Add(new MDB.MDBParameter("Cao", BenhAnNgoaiTru_LupusBanDoHeThong.Cao));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianTuKhiKhoiPhat", BenhAnNgoaiTru_LupusBanDoHeThong.ThoiGianTuKhiKhoiPhat));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungDauTien", BenhAnNgoaiTru_LupusBanDoHeThong.TrieuChungDauTien));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuCoBenhTuMienKhac", BenhAnNgoaiTru_LupusBanDoHeThong.TienSuCoBenhTuMienKhac));
                Command.Parameters.Add(new MDB.MDBParameter("CoBenhCollagen", BenhAnNgoaiTru_LupusBanDoHeThong.CoBenhCollagen));
                Command.Parameters.Add(new MDB.MDBParameter("XoCungBi", BenhAnNgoaiTru_LupusBanDoHeThong.XoCungBi));
                Command.Parameters.Add(new MDB.MDBParameter("ViemDaCo", BenhAnNgoaiTru_LupusBanDoHeThong.ViemDaCo));
                Command.Parameters.Add(new MDB.MDBParameter("HoiChungSjogren", BenhAnNgoaiTru_LupusBanDoHeThong.HoiChungSjogren));
                Command.Parameters.Add(new MDB.MDBParameter("XoGanMatTienPhat", BenhAnNgoaiTru_LupusBanDoHeThong.XoGanMatTienPhat));
                Command.Parameters.Add(new MDB.MDBParameter("ViemTuyenGiap", BenhAnNgoaiTru_LupusBanDoHeThong.ViemTuyenGiap));
                Command.Parameters.Add(new MDB.MDBParameter("HoiChungKhangPhospholipid", BenhAnNgoaiTru_LupusBanDoHeThong.HoiChungKhangPhospholipid));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuCoBenh_Khac", BenhAnNgoaiTru_LupusBanDoHeThong.TienSuCoBenh_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuCaNhan", BenhAnNgoaiTru_LupusBanDoHeThong.TienSuCaNhan));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuCaNhan_Co", BenhAnNgoaiTru_LupusBanDoHeThong.TienSuCaNhan_Co));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuGiaDinh", BenhAnNgoaiTru_LupusBanDoHeThong.TienSuGiaDinh));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuGiaDinh_Co", BenhAnNgoaiTru_LupusBanDoHeThong.TienSuGiaDinh_Co));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuGiaDinh_NeuCo", BenhAnNgoaiTru_LupusBanDoHeThong.TienSuGiaDinh_NeuCo));
                Command.Parameters.Add(new MDB.MDBParameter("Sot", BenhAnNgoaiTru_LupusBanDoHeThong.Sot));
                Command.Parameters.Add(new MDB.MDBParameter("HachTo", BenhAnNgoaiTru_LupusBanDoHeThong.HachTo));
                Command.Parameters.Add(new MDB.MDBParameter("MetMoi", BenhAnNgoaiTru_LupusBanDoHeThong.MetMoi));
                Command.Parameters.Add(new MDB.MDBParameter("LachTo", BenhAnNgoaiTru_LupusBanDoHeThong.LachTo));
                Command.Parameters.Add(new MDB.MDBParameter("HA", BenhAnNgoaiTru_LupusBanDoHeThong.HA));
                Command.Parameters.Add(new MDB.MDBParameter("LamSangDaNiemMac", BenhAnNgoaiTru_LupusBanDoHeThong.LamSangDaNiemMac));
                Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac", BenhAnNgoaiTru_LupusBanDoHeThong.TonThuongKhac));
                Command.Parameters.Add(new MDB.MDBParameter("YeuCoGoc", BenhAnNgoaiTru_LupusBanDoHeThong.YeuCoGoc));
                Command.Parameters.Add(new MDB.MDBParameter("TangCpk", BenhAnNgoaiTru_LupusBanDoHeThong.TangCpk));
                Command.Parameters.Add(new MDB.MDBParameter("TangCpk_Co", BenhAnNgoaiTru_LupusBanDoHeThong.TangCpk_Co));
                Command.Parameters.Add(new MDB.MDBParameter("DienCoBatThuong", BenhAnNgoaiTru_LupusBanDoHeThong.DienCoBatThuong));
                Command.Parameters.Add(new MDB.MDBParameter("SinhThietCoBatThuong", BenhAnNgoaiTru_LupusBanDoHeThong.SinhThietCoBatThuong));
                Command.Parameters.Add(new MDB.MDBParameter("DauKhop", BenhAnNgoaiTru_LupusBanDoHeThong.DauKhop));
                Command.Parameters.Add(new MDB.MDBParameter("DauKhop_ViTri", BenhAnNgoaiTru_LupusBanDoHeThong.DauKhop_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("DauKhop_SoLuong", BenhAnNgoaiTru_LupusBanDoHeThong.DauKhop_SoLuong));
                Command.Parameters.Add(new MDB.MDBParameter("SungKhop", BenhAnNgoaiTru_LupusBanDoHeThong.SungKhop));
                Command.Parameters.Add(new MDB.MDBParameter("SungKhop_ViTri", BenhAnNgoaiTru_LupusBanDoHeThong.SungKhop_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("SungKhop_SoLuong", BenhAnNgoaiTru_LupusBanDoHeThong.SungKhop_SoLuong));
                Command.Parameters.Add(new MDB.MDBParameter("CungKhop", BenhAnNgoaiTru_LupusBanDoHeThong.CungKhop));
                Command.Parameters.Add(new MDB.MDBParameter("CungKhop_ViTri", BenhAnNgoaiTru_LupusBanDoHeThong.CungKhop_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("CungKhop_SoLuong", BenhAnNgoaiTru_LupusBanDoHeThong.CungKhop_SoLuong));
                Command.Parameters.Add(new MDB.MDBParameter("DauDauNuaDau", BenhAnNgoaiTru_LupusBanDoHeThong.DauDauNuaDau));
                Command.Parameters.Add(new MDB.MDBParameter("ViemMangNaoVoKhuan", BenhAnNgoaiTru_LupusBanDoHeThong.ViemMangNaoVoKhuan));
                Command.Parameters.Add(new MDB.MDBParameter("BenhMachNao", BenhAnNgoaiTru_LupusBanDoHeThong.BenhMachNao));
                Command.Parameters.Add(new MDB.MDBParameter("MuaGiat", BenhAnNgoaiTru_LupusBanDoHeThong.MuaGiat));
                Command.Parameters.Add(new MDB.MDBParameter("DongKinh", BenhAnNgoaiTru_LupusBanDoHeThong.DongKinh));
                Command.Parameters.Add(new MDB.MDBParameter("TrangThaiLuLanCapTinh", BenhAnNgoaiTru_LupusBanDoHeThong.TrangThaiLuLanCapTinh));
                Command.Parameters.Add(new MDB.MDBParameter("RoiLoanLoAu", BenhAnNgoaiTru_LupusBanDoHeThong.RoiLoanLoAu));
                Command.Parameters.Add(new MDB.MDBParameter("RoiLoanChucNangNhanThuc", BenhAnNgoaiTru_LupusBanDoHeThong.RoiLoanChucNangNhanThuc));
                Command.Parameters.Add(new MDB.MDBParameter("TramCam", BenhAnNgoaiTru_LupusBanDoHeThong.TramCam));
                Command.Parameters.Add(new MDB.MDBParameter("AoTuongAoGiac", BenhAnNgoaiTru_LupusBanDoHeThong.AoTuongAoGiac));
                Command.Parameters.Add(new MDB.MDBParameter("HoiChungGuillainBarre", BenhAnNgoaiTru_LupusBanDoHeThong.HoiChungGuillainBarre));
                Command.Parameters.Add(new MDB.MDBParameter("RoiLoanThanKinhTuDong", BenhAnNgoaiTru_LupusBanDoHeThong.RoiLoanThanKinhTuDong));
                Command.Parameters.Add(new MDB.MDBParameter("NhuocCoNang", BenhAnNgoaiTru_LupusBanDoHeThong.NhuocCoNang));
                Command.Parameters.Add(new MDB.MDBParameter("ViemDonDayThanKinh", BenhAnNgoaiTru_LupusBanDoHeThong.ViemDonDayThanKinh));
                Command.Parameters.Add(new MDB.MDBParameter("ViemDaDayThanKinh", BenhAnNgoaiTru_LupusBanDoHeThong.ViemDaDayThanKinh));
                Command.Parameters.Add(new MDB.MDBParameter("ViemMangTim", BenhAnNgoaiTru_LupusBanDoHeThong.ViemMangTim));
                Command.Parameters.Add(new MDB.MDBParameter("TranDichMangNgoaiTim", BenhAnNgoaiTru_LupusBanDoHeThong.TranDichMangNgoaiTim));
                Command.Parameters.Add(new MDB.MDBParameter("DauHieuSuyTim", BenhAnNgoaiTru_LupusBanDoHeThong.DauHieuSuyTim));
                Command.Parameters.Add(new MDB.MDBParameter("BenhCoTim", BenhAnNgoaiTru_LupusBanDoHeThong.BenhCoTim));
                Command.Parameters.Add(new MDB.MDBParameter("BenhVanTim", BenhAnNgoaiTru_LupusBanDoHeThong.BenhVanTim));
                Command.Parameters.Add(new MDB.MDBParameter("BenhVanTim_NeuCo", BenhAnNgoaiTru_LupusBanDoHeThong.BenhVanTim_NeuCo));
                Command.Parameters.Add(new MDB.MDBParameter("ViemMangPhoi", BenhAnNgoaiTru_LupusBanDoHeThong.ViemMangPhoi));
                Command.Parameters.Add(new MDB.MDBParameter("TranDichMangPhoi", BenhAnNgoaiTru_LupusBanDoHeThong.TranDichMangPhoi));
                Command.Parameters.Add(new MDB.MDBParameter("ViemPhoiCapTinh", BenhAnNgoaiTru_LupusBanDoHeThong.ViemPhoiCapTinh));
                Command.Parameters.Add(new MDB.MDBParameter("ViemPhoiKe", BenhAnNgoaiTru_LupusBanDoHeThong.ViemPhoiKe));
                Command.Parameters.Add(new MDB.MDBParameter("ViemPheQuanTacNghen", BenhAnNgoaiTru_LupusBanDoHeThong.ViemPheQuanTacNghen));
                Command.Parameters.Add(new MDB.MDBParameter("NhoiMauPhoi", BenhAnNgoaiTru_LupusBanDoHeThong.NhoiMauPhoi));
                Command.Parameters.Add(new MDB.MDBParameter("KhoiUAcTinhTaiPhoi", BenhAnNgoaiTru_LupusBanDoHeThong.KhoiUAcTinhTaiPhoi));
                Command.Parameters.Add(new MDB.MDBParameter("Non", BenhAnNgoaiTru_LupusBanDoHeThong.Non));
                Command.Parameters.Add(new MDB.MDBParameter("DauHoiKhoTieu", BenhAnNgoaiTru_LupusBanDoHeThong.DauHoiKhoTieu));
                Command.Parameters.Add(new MDB.MDBParameter("TieuChay", BenhAnNgoaiTru_LupusBanDoHeThong.TieuChay));
                Command.Parameters.Add(new MDB.MDBParameter("DauBung", BenhAnNgoaiTru_LupusBanDoHeThong.DauBung));
                Command.Parameters.Add(new MDB.MDBParameter("BieuHienTieuHoa_Khac", BenhAnNgoaiTru_LupusBanDoHeThong.BieuHienTieuHoa_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("CongThucMau_BachCau", BenhAnNgoaiTru_LupusBanDoHeThong.CongThucMau_BachCau));
                Command.Parameters.Add(new MDB.MDBParameter("CongThucMau_Lympho", BenhAnNgoaiTru_LupusBanDoHeThong.CongThucMau_Lympho));
                Command.Parameters.Add(new MDB.MDBParameter("CongThucMau_Hc", BenhAnNgoaiTru_LupusBanDoHeThong.CongThucMau_Hc));
                Command.Parameters.Add(new MDB.MDBParameter("CongThucMau_Hb", BenhAnNgoaiTru_LupusBanDoHeThong.CongThucMau_Hb));
                Command.Parameters.Add(new MDB.MDBParameter("CongThucMau_TieuCau", BenhAnNgoaiTru_LupusBanDoHeThong.CongThucMau_TieuCau));
                Command.Parameters.Add(new MDB.MDBParameter("TestCoombTrucTiep", BenhAnNgoaiTru_LupusBanDoHeThong.TestCoombTrucTiep));
                Command.Parameters.Add(new MDB.MDBParameter("MauLang_1h", BenhAnNgoaiTru_LupusBanDoHeThong.MauLang_1h));
                Command.Parameters.Add(new MDB.MDBParameter("MauLang_2h", BenhAnNgoaiTru_LupusBanDoHeThong.MauLang_2h));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_Creatinin", BenhAnNgoaiTru_LupusBanDoHeThong.SinhHoa_Creatinin));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_Ure", BenhAnNgoaiTru_LupusBanDoHeThong.SinhHoa_Ure));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_ProteinToanPhan", BenhAnNgoaiTru_LupusBanDoHeThong.SinhHoa_ProteinToanPhan));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_Alb", BenhAnNgoaiTru_LupusBanDoHeThong.SinhHoa_Alb));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_Cholesterol", BenhAnNgoaiTru_LupusBanDoHeThong.SinhHoa_Cholesterol));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_Tri", BenhAnNgoaiTru_LupusBanDoHeThong.SinhHoa_Tri));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_GOT", BenhAnNgoaiTru_LupusBanDoHeThong.SinhHoa_GOT));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_GPT", BenhAnNgoaiTru_LupusBanDoHeThong.SinhHoa_GPT));
                Command.Parameters.Add(new MDB.MDBParameter("NuocTieu_ProteinNieu", BenhAnNgoaiTru_LupusBanDoHeThong.NuocTieu_ProteinNieu));
                Command.Parameters.Add(new MDB.MDBParameter("NuocTieu_TruNieu", BenhAnNgoaiTru_LupusBanDoHeThong.NuocTieu_TruNieu));
                Command.Parameters.Add(new MDB.MDBParameter("NuocTieu_HCNieu", BenhAnNgoaiTru_LupusBanDoHeThong.NuocTieu_HCNieu));
                Command.Parameters.Add(new MDB.MDBParameter("NuocTieu_BCNieu", BenhAnNgoaiTru_LupusBanDoHeThong.NuocTieu_BCNieu));
                Command.Parameters.Add(new MDB.MDBParameter("NuocTieu_ProteinNieu24h", BenhAnNgoaiTru_LupusBanDoHeThong.NuocTieu_ProteinNieu24h));
                Command.Parameters.Add(new MDB.MDBParameter("TeBaoHargaves", BenhAnNgoaiTru_LupusBanDoHeThong.TeBaoHargaves));
                Command.Parameters.Add(new MDB.MDBParameter("YeuToDangThapCARF", BenhAnNgoaiTru_LupusBanDoHeThong.YeuToDangThapCARF));
                Command.Parameters.Add(new MDB.MDBParameter("Ana", BenhAnNgoaiTru_LupusBanDoHeThong.Ana));
                Command.Parameters.Add(new MDB.MDBParameter("Ana_Co", BenhAnNgoaiTru_LupusBanDoHeThong.Ana_Co));
                Command.Parameters.Add(new MDB.MDBParameter("AntidsDNA", BenhAnNgoaiTru_LupusBanDoHeThong.AntidsDNA));
                Command.Parameters.Add(new MDB.MDBParameter("AntidsDNA_Co", BenhAnNgoaiTru_LupusBanDoHeThong.AntidsDNA_Co));
                Command.Parameters.Add(new MDB.MDBParameter("AntiPhospholipid", BenhAnNgoaiTru_LupusBanDoHeThong.AntiPhospholipid));
                Command.Parameters.Add(new MDB.MDBParameter("AntiPhospholipid_Co", BenhAnNgoaiTru_LupusBanDoHeThong.AntiPhospholipid_Co));
                Command.Parameters.Add(new MDB.MDBParameter("AntiSm", BenhAnNgoaiTru_LupusBanDoHeThong.AntiSm));
                Command.Parameters.Add(new MDB.MDBParameter("AntiSm_Co", BenhAnNgoaiTru_LupusBanDoHeThong.AntiSm_Co));
                Command.Parameters.Add(new MDB.MDBParameter("AntiCardiolipin", BenhAnNgoaiTru_LupusBanDoHeThong.AntiCardiolipin));
                Command.Parameters.Add(new MDB.MDBParameter("AntiCardiolipin_Co", BenhAnNgoaiTru_LupusBanDoHeThong.AntiCardiolipin_Co));
                Command.Parameters.Add(new MDB.MDBParameter("AntiSSA", BenhAnNgoaiTru_LupusBanDoHeThong.AntiSSA));
                Command.Parameters.Add(new MDB.MDBParameter("AntiSSA_Co", BenhAnNgoaiTru_LupusBanDoHeThong.AntiSSA_Co));
                Command.Parameters.Add(new MDB.MDBParameter("KhangDongLupus", BenhAnNgoaiTru_LupusBanDoHeThong.KhangDongLupus));
                Command.Parameters.Add(new MDB.MDBParameter("KhangDongLupus_Co", BenhAnNgoaiTru_LupusBanDoHeThong.KhangDongLupus_Co));
                Command.Parameters.Add(new MDB.MDBParameter("AntiSSB", BenhAnNgoaiTru_LupusBanDoHeThong.AntiSSB));
                Command.Parameters.Add(new MDB.MDBParameter("AntiSSB_Co", BenhAnNgoaiTru_LupusBanDoHeThong.AntiSSB_Co));
                Command.Parameters.Add(new MDB.MDBParameter("AntiB2Glycoptotein", BenhAnNgoaiTru_LupusBanDoHeThong.AntiB2Glycoptotein));
                Command.Parameters.Add(new MDB.MDBParameter("AntiB2Glycoptotein_Co", BenhAnNgoaiTru_LupusBanDoHeThong.AntiB2Glycoptotein_Co));
                Command.Parameters.Add(new MDB.MDBParameter("AntiU1", BenhAnNgoaiTru_LupusBanDoHeThong.AntiU1));
                Command.Parameters.Add(new MDB.MDBParameter("AntiU1_Co", BenhAnNgoaiTru_LupusBanDoHeThong.AntiU1_Co));
                Command.Parameters.Add(new MDB.MDBParameter("AntiHistone", BenhAnNgoaiTru_LupusBanDoHeThong.AntiHistone));
                Command.Parameters.Add(new MDB.MDBParameter("AntiHistone_Co", BenhAnNgoaiTru_LupusBanDoHeThong.AntiHistone_Co));
                Command.Parameters.Add(new MDB.MDBParameter("KTKhac", BenhAnNgoaiTru_LupusBanDoHeThong.KTKhac));
                Command.Parameters.Add(new MDB.MDBParameter("TuKhangTheNeuCo", BenhAnNgoaiTru_LupusBanDoHeThong.TuKhangTheNeuCo));
                Command.Parameters.Add(new MDB.MDBParameter("TotalIgG", BenhAnNgoaiTru_LupusBanDoHeThong.TotalIgG));
                Command.Parameters.Add(new MDB.MDBParameter("C3_Text", BenhAnNgoaiTru_LupusBanDoHeThong.C3_Text));
                Command.Parameters.Add(new MDB.MDBParameter("C3", BenhAnNgoaiTru_LupusBanDoHeThong.C3));
                Command.Parameters.Add(new MDB.MDBParameter("C4_Text", BenhAnNgoaiTru_LupusBanDoHeThong.C4_Text));
                Command.Parameters.Add(new MDB.MDBParameter("C4", BenhAnNgoaiTru_LupusBanDoHeThong.C4));
                Command.Parameters.Add(new MDB.MDBParameter("SinhThietDa", BenhAnNgoaiTru_LupusBanDoHeThong.SinhThietDa));
                Command.Parameters.Add(new MDB.MDBParameter("SinhThietDa_NeuCo", BenhAnNgoaiTru_LupusBanDoHeThong.SinhThietDa_NeuCo));
                Command.Parameters.Add(new MDB.MDBParameter("LupusBandTest", BenhAnNgoaiTru_LupusBanDoHeThong.LupusBandTest));
                Command.Parameters.Add(new MDB.MDBParameter("LupusBandTest_NeuCo", BenhAnNgoaiTru_LupusBanDoHeThong.LupusBandTest_NeuCo));
                Command.Parameters.Add(new MDB.MDBParameter("LupusBandTest_DuongTinh", BenhAnNgoaiTru_LupusBanDoHeThong.LupusBandTest_DuongTinh));
                Command.Parameters.Add(new MDB.MDBParameter("SinhThietThan", BenhAnNgoaiTru_LupusBanDoHeThong.SinhThietThan));
                Command.Parameters.Add(new MDB.MDBParameter("KhamMat_NgayKham", BenhAnNgoaiTru_LupusBanDoHeThong.KhamMat_NgayKham));
                Command.Parameters.Add(new MDB.MDBParameter("KhamMat_KetQua", BenhAnNgoaiTru_LupusBanDoHeThong.KhamMat_KetQua));
                Command.Parameters.Add(new MDB.MDBParameter("BanDoHinhCanhBuom", BenhAnNgoaiTru_LupusBanDoHeThong.BanDoHinhCanhBuom));
                Command.Parameters.Add(new MDB.MDBParameter("BanDoHinhDia", BenhAnNgoaiTru_LupusBanDoHeThong.BanDoHinhDia));
                Command.Parameters.Add(new MDB.MDBParameter("NhayCamAnhSang", BenhAnNgoaiTru_LupusBanDoHeThong.NhayCamAnhSang));
                Command.Parameters.Add(new MDB.MDBParameter("LoetMieng", BenhAnNgoaiTru_LupusBanDoHeThong.LoetMieng));
                Command.Parameters.Add(new MDB.MDBParameter("ViemKhop", BenhAnNgoaiTru_LupusBanDoHeThong.ViemKhop));
                Command.Parameters.Add(new MDB.MDBParameter("ViemTranDichThanhMac", BenhAnNgoaiTru_LupusBanDoHeThong.ViemTranDichThanhMac));
                Command.Parameters.Add(new MDB.MDBParameter("RoiLoanChucNangThan", BenhAnNgoaiTru_LupusBanDoHeThong.RoiLoanChucNangThan));
                Command.Parameters.Add(new MDB.MDBParameter("RoiLoanThanKinhTamThan", BenhAnNgoaiTru_LupusBanDoHeThong.RoiLoanThanKinhTamThan));
                Command.Parameters.Add(new MDB.MDBParameter("RoiLoanVeMau", BenhAnNgoaiTru_LupusBanDoHeThong.RoiLoanVeMau));
                Command.Parameters.Add(new MDB.MDBParameter("RoiLoanMienDich", BenhAnNgoaiTru_LupusBanDoHeThong.RoiLoanMienDich));
                Command.Parameters.Add(new MDB.MDBParameter("AnaDuongTinh", BenhAnNgoaiTru_LupusBanDoHeThong.AnaDuongTinh));
                Command.Parameters.Add(new MDB.MDBParameter("Tong11TieuChuan", BenhAnNgoaiTru_LupusBanDoHeThong.Tong11TieuChuan));
                Command.Parameters.Add(new MDB.MDBParameter("TieuChuanLamSang", BenhAnNgoaiTru_LupusBanDoHeThong.TieuChuanLamSang));
                Command.Parameters.Add(new MDB.MDBParameter("TieuChuanCanLamSang", BenhAnNgoaiTru_LupusBanDoHeThong.TieuChuanCanLamSang));
                Command.Parameters.Add(new MDB.MDBParameter("Tong17TieuChuan", BenhAnNgoaiTru_LupusBanDoHeThong.Tong17TieuChuan));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEDAI_1", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEDAI_1));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEDAI_2", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEDAI_2));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEDAI_3", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEDAI_3));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEDAI_4", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEDAI_4));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEDAI_5", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEDAI_5));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEDAI_6", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEDAI_6));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEDAI_7", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEDAI_7));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEDAI_8", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEDAI_8));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEDAI_9", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEDAI_9));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEDAI_10", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEDAI_10));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEDAI_11", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEDAI_11));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEDAI_12", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEDAI_12));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEDAI_13", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEDAI_13));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEDAI_14", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEDAI_14));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEDAI_15", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEDAI_15));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEDAI_16", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEDAI_16));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEDAI_17", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEDAI_17));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEDAI_18", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEDAI_18));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEDAI_19", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEDAI_19));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEDAI_20", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEDAI_20));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEDAI_21", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEDAI_21));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEDAI_22", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEDAI_22));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEDAI_23", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEDAI_23));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEDAI_24", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEDAI_24));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEDAI_TongDiem", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEDAI_TongDiem));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_1", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_1));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_2", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_2));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_3", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_3));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_4", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_4));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_5", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_5));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_6", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_6));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_7", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_7));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_8", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_8));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_9", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_9));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_10", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_10));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_11", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_11));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_12", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_12));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_13", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_13));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_14", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_14));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_15", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_15));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_16", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_16));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_17", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_17));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_18", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_18));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_19", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_19));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_20", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_20));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_21", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_21));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_22", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_22));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_23", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_23));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_24", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_24));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_25", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_25));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_26", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_26));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_27", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_27));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_28", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_28));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_29", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_29));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_30", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_30));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_31", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_31));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_32", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_32));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_33", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_33));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_34", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_34));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_35", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_35));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_36", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_36));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_37", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_37));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_38", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_38));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_39", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_39));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_40", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_40));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_1_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_1_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_2_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_2_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_3_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_3_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_4_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_4_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_5_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_5_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_6_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_6_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_7_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_7_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_8_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_8_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_9_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_9_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_10_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_10_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_11_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_11_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_12_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_12_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_13_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_13_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_14_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_14_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_15_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_15_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_16_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_16_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_17_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_17_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_18_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_18_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_19_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_19_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_20_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_20_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_21_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_21_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_22_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_22_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_23_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_23_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_24_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_24_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_25_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_25_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_26_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_26_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_27_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_27_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_28_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_28_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_29_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_29_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_30_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_30_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_31_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_31_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_32_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_32_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_33_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_33_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_34_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_34_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_35_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_35_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_36_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_36_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_37_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_37_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_38_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_38_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_39_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_39_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_40_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_40_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_TongDiem", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_TongDiem));
                Command.Parameters.Add(new MDB.MDBParameter("Corticosteroid", JsonConvert.SerializeObject(BenhAnNgoaiTru_LupusBanDoHeThong.Corticosteroid)));
                Command.Parameters.Add(new MDB.MDBParameter("KhangSotRet", JsonConvert.SerializeObject(BenhAnNgoaiTru_LupusBanDoHeThong.KhangSotRet)));
                Command.Parameters.Add(new MDB.MDBParameter("Cyclophosphamide", JsonConvert.SerializeObject(BenhAnNgoaiTru_LupusBanDoHeThong.Cyclophosphamide)));
                Command.Parameters.Add(new MDB.MDBParameter("CyclophosphamideLieuCao", JsonConvert.SerializeObject(BenhAnNgoaiTru_LupusBanDoHeThong.CyclophosphamideLieuCao)));
                Command.Parameters.Add(new MDB.MDBParameter("Azathioprine", JsonConvert.SerializeObject(BenhAnNgoaiTru_LupusBanDoHeThong.Azathioprine)));
                Command.Parameters.Add(new MDB.MDBParameter("Methotrexate", JsonConvert.SerializeObject(BenhAnNgoaiTru_LupusBanDoHeThong.Methotrexate)));
                Command.Parameters.Add(new MDB.MDBParameter("CyclosporineA", JsonConvert.SerializeObject(BenhAnNgoaiTru_LupusBanDoHeThong.CyclosporineA)));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocKhac", JsonConvert.SerializeObject(BenhAnNgoaiTru_LupusBanDoHeThong.ThuocKhac)));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriHienTai", BenhAnNgoaiTru_LupusBanDoHeThong.DieuTriHienTai));
                Command.Parameters.Add(new MDB.MDBParameter("HenKham", BenhAnNgoaiTru_LupusBanDoHeThong.HenKham));
                Command.Parameters.Add(new MDB.MDBParameter("BacSiDieuTri", BenhAnNgoaiTru_LupusBanDoHeThong.BacSiDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SoBenhAnDienTu", BenhAnNgoaiTru_LupusBanDoHeThong.TK_SoBenhAnDienTu));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SoLuuTru", BenhAnNgoaiTru_LupusBanDoHeThong.TK_SoLuuTru));
                Command.Parameters.Add(new MDB.MDBParameter("NgayKham", BenhAnNgoaiTru_LupusBanDoHeThong.NgayKham));
                Command.Parameters.Add(new MDB.MDBParameter("NgayLuuHuyetThanh", BenhAnNgoaiTru_LupusBanDoHeThong.NgayLuuHuyetThanh));
                Command.Parameters.Add(new MDB.MDBParameter("BacSiKham", BenhAnNgoaiTru_LupusBanDoHeThong.BacSiKham));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSiKham", BenhAnNgoaiTru_LupusBanDoHeThong.MaBacSiKham));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Sot", BenhAnNgoaiTru_LupusBanDoHeThong.TK_Sot));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HachTo", BenhAnNgoaiTru_LupusBanDoHeThong.TK_HachTo));
                Command.Parameters.Add(new MDB.MDBParameter("TK_MetMoi", BenhAnNgoaiTru_LupusBanDoHeThong.TK_MetMoi));
                Command.Parameters.Add(new MDB.MDBParameter("TK_LachTo", BenhAnNgoaiTru_LupusBanDoHeThong.TK_LachTo));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HA", BenhAnNgoaiTru_LupusBanDoHeThong.TK_HA));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TienSu_BenhThem", BenhAnNgoaiTru_LupusBanDoHeThong.TK_TienSu_BenhThem));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Da", BenhAnNgoaiTru_LupusBanDoHeThong.TK_Da));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Co", BenhAnNgoaiTru_LupusBanDoHeThong.TK_Co));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Khop", BenhAnNgoaiTru_LupusBanDoHeThong.TK_Khop));
                Command.Parameters.Add(new MDB.MDBParameter("TK_ThanKinh", BenhAnNgoaiTru_LupusBanDoHeThong.TK_ThanKinh));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TimMach", BenhAnNgoaiTru_LupusBanDoHeThong.TK_TimMach));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HoHap", BenhAnNgoaiTru_LupusBanDoHeThong.TK_HoHap));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TieuHoa", BenhAnNgoaiTru_LupusBanDoHeThong.TK_TieuHoa));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TrieuChungKhac", BenhAnNgoaiTru_LupusBanDoHeThong.TK_TrieuChungKhac));
                Command.Parameters.Add(new MDB.MDBParameter("TK_CongThucMau_BachCau", BenhAnNgoaiTru_LupusBanDoHeThong.TK_CongThucMau_BachCau));
                Command.Parameters.Add(new MDB.MDBParameter("TK_CongThucMau_Lympho", BenhAnNgoaiTru_LupusBanDoHeThong.TK_CongThucMau_Lympho));
                Command.Parameters.Add(new MDB.MDBParameter("TK_CongThucMau_Hc", BenhAnNgoaiTru_LupusBanDoHeThong.TK_CongThucMau_Hc));
                Command.Parameters.Add(new MDB.MDBParameter("TK_CongThucMau_Hb", BenhAnNgoaiTru_LupusBanDoHeThong.TK_CongThucMau_Hb));
                Command.Parameters.Add(new MDB.MDBParameter("TK_CongThucMau_TieuCau", BenhAnNgoaiTru_LupusBanDoHeThong.TK_CongThucMau_TieuCau));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TestCoombTrucTiep", BenhAnNgoaiTru_LupusBanDoHeThong.TK_TestCoombTrucTiep));
                Command.Parameters.Add(new MDB.MDBParameter("TK_MauLang_1h", BenhAnNgoaiTru_LupusBanDoHeThong.TK_MauLang_1h));
                Command.Parameters.Add(new MDB.MDBParameter("TK_MauLang_2h", BenhAnNgoaiTru_LupusBanDoHeThong.TK_MauLang_2h));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_Creatinin", BenhAnNgoaiTru_LupusBanDoHeThong.TK_SinhHoa_Creatinin));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_Ure", BenhAnNgoaiTru_LupusBanDoHeThong.TK_SinhHoa_Ure));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_ProteinToanPhan", BenhAnNgoaiTru_LupusBanDoHeThong.TK_SinhHoa_ProteinToanPhan));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_Alb", BenhAnNgoaiTru_LupusBanDoHeThong.TK_SinhHoa_Alb));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_Cholesterol", BenhAnNgoaiTru_LupusBanDoHeThong.TK_SinhHoa_Cholesterol));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_Tri", BenhAnNgoaiTru_LupusBanDoHeThong.TK_SinhHoa_Tri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_GOT", BenhAnNgoaiTru_LupusBanDoHeThong.TK_SinhHoa_GOT));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_GPT", BenhAnNgoaiTru_LupusBanDoHeThong.TK_SinhHoa_GPT));
                Command.Parameters.Add(new MDB.MDBParameter("TK_NuocTieu_ProteinNieu", BenhAnNgoaiTru_LupusBanDoHeThong.TK_NuocTieu_ProteinNieu));
                Command.Parameters.Add(new MDB.MDBParameter("TK_NuocTieu_TruNieu", BenhAnNgoaiTru_LupusBanDoHeThong.TK_NuocTieu_TruNieu));
                Command.Parameters.Add(new MDB.MDBParameter("TK_NuocTieu_HCNieu", BenhAnNgoaiTru_LupusBanDoHeThong.TK_NuocTieu_HCNieu));
                Command.Parameters.Add(new MDB.MDBParameter("TK_NuocTieu_BCNieu", BenhAnNgoaiTru_LupusBanDoHeThong.TK_NuocTieu_BCNieu));
                Command.Parameters.Add(new MDB.MDBParameter("TK_NuocTieu_ProteinNieu24h", BenhAnNgoaiTru_LupusBanDoHeThong.TK_NuocTieu_ProteinNieu24h));
                Command.Parameters.Add(new MDB.MDBParameter("TK_YeuToDangThap_Text", BenhAnNgoaiTru_LupusBanDoHeThong.TK_YeuToDangThap_Text));
                Command.Parameters.Add(new MDB.MDBParameter("TK_YeuToDangThap_Khong", BenhAnNgoaiTru_LupusBanDoHeThong.TK_YeuToDangThap_Khong));
                Command.Parameters.Add(new MDB.MDBParameter("XuatHienTuKhangThe", BenhAnNgoaiTru_LupusBanDoHeThong.XuatHienTuKhangThe));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhamMat", BenhAnNgoaiTru_LupusBanDoHeThong.TK_KhamMat));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhamMat_KetQua", BenhAnNgoaiTru_LupusBanDoHeThong.TK_KhamMat_KetQua));
                Command.Parameters.Add(new MDB.MDBParameter("TK_XetNghiemKhac", BenhAnNgoaiTru_LupusBanDoHeThong.TK_XetNghiemKhac));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DiemSLEQOL_TongDiem", BenhAnNgoaiTru_LupusBanDoHeThong.TK_DiemSLEQOL_TongDiem));
                Command.Parameters.Add(new MDB.MDBParameter("TK_ChuY", BenhAnNgoaiTru_LupusBanDoHeThong.TK_ChuY));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DieuTri", BenhAnNgoaiTru_LupusBanDoHeThong.TK_DieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HenKham", BenhAnNgoaiTru_LupusBanDoHeThong.TK_HenKham));
                Command.Parameters.Add(new MDB.MDBParameter("TK_BacSiDieuTri", BenhAnNgoaiTru_LupusBanDoHeThong.TK_BacSiDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_MaBacSiDieuTri", BenhAnNgoaiTru_LupusBanDoHeThong.TK_MaBacSiDieuTri));
                
                // tổng kết
                Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnNgoaiTru_LupusBanDoHeThong.QuaTrinhBenhLy));
                Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQua", BenhAnNgoaiTru_LupusBanDoHeThong.TomTatKetQua));
                Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnNgoaiTru_LupusBanDoHeThong.BenhChinh));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhChinh", BenhAnNgoaiTru_LupusBanDoHeThong.MaBenhChinh));
                Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnNgoaiTru_LupusBanDoHeThong.BenhKemTheo));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhKemTheo", BenhAnNgoaiTru_LupusBanDoHeThong.MaBenhKemTheo));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnNgoaiTru_LupusBanDoHeThong.PhuongPhapDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangRaVien", BenhAnNgoaiTru_LupusBanDoHeThong.TinhTrangRaVien));
                Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnNgoaiTru_LupusBanDoHeThong.HuongDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnNgoaiTru_LupusBanDoHeThong.NguoiNhanHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnNgoaiTru_LupusBanDoHeThong.NguoiGiaoHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnNgoaiTru_LupusBanDoHeThong.NgayTongKet));
                Command.Parameters.Add(new MDB.MDBParameter("TongKet_BacSyDieuTri", BenhAnNgoaiTru_LupusBanDoHeThong.TongKet_BacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TongKet_MaBacSyDieuTri", BenhAnNgoaiTru_LupusBanDoHeThong.TongKet_MaBacSyDieuTri));

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
        public static bool Update(MDB.MDBConnection MyConnection, BenhAnNgoaiTru_LupusBanDoHeThong BenhAnNgoaiTru_LupusBanDoHeThong)
        {
            try
            {
                string sql = @"UPDATE BenhAnLupusBanDoHeThong SET 
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
                            Can=:Can,
                            Cao=:Cao,
                            ThoiGianTuKhiKhoiPhat=:ThoiGianTuKhiKhoiPhat,
                            TrieuChungDauTien=:TrieuChungDauTien,
                            TienSuCoBenhTuMienKhac=:TienSuCoBenhTuMienKhac,
                            CoBenhCollagen=:CoBenhCollagen,
                            XoCungBi=:XoCungBi,
                            ViemDaCo=:ViemDaCo,
                            HoiChungSjogren=:HoiChungSjogren,
                            XoGanMatTienPhat=:XoGanMatTienPhat,
                            ViemTuyenGiap=:ViemTuyenGiap,
                            HoiChungKhangPhospholipid=:HoiChungKhangPhospholipid,
                            TienSuCoBenh_Khac=:TienSuCoBenh_Khac,
                            TienSuCaNhan=:TienSuCaNhan,
                            TienSuCaNhan_Co=:TienSuCaNhan_Co,
                            TienSuGiaDinh=:TienSuGiaDinh,
                            TienSuGiaDinh_Co=:TienSuGiaDinh_Co,
                            TienSuGiaDinh_NeuCo=:TienSuGiaDinh_NeuCo,
                            Sot=:Sot,
                            HachTo=:HachTo,
                            MetMoi=:MetMoi,
                            LachTo=:LachTo,
                            HA=:HA,
                            LamSangDaNiemMac=:LamSangDaNiemMac,
                            TonThuongKhac=:TonThuongKhac,
                            YeuCoGoc=:YeuCoGoc,
                            TangCpk=:TangCpk,
                            TangCpk_Co=:TangCpk_Co,
                            DienCoBatThuong=:DienCoBatThuong,
                            SinhThietCoBatThuong=:SinhThietCoBatThuong,
                            DauKhop=:DauKhop,
                            DauKhop_ViTri=:DauKhop_ViTri,
                            DauKhop_SoLuong=:DauKhop_SoLuong,
                            SungKhop=:SungKhop,
                            SungKhop_ViTri=:SungKhop_ViTri,
                            SungKhop_SoLuong=:SungKhop_SoLuong,
                            CungKhop=:CungKhop,
                            CungKhop_ViTri=:CungKhop_ViTri,
                            CungKhop_SoLuong=:CungKhop_SoLuong,
                            DauDauNuaDau=:DauDauNuaDau,
                            ViemMangNaoVoKhuan=:ViemMangNaoVoKhuan,
                            BenhMachNao=:BenhMachNao,
                            MuaGiat=:MuaGiat,
                            DongKinh=:DongKinh,
                            TrangThaiLuLanCapTinh=:TrangThaiLuLanCapTinh,
                            RoiLoanLoAu=:RoiLoanLoAu,
                            RoiLoanChucNangNhanThuc=:RoiLoanChucNangNhanThuc,
                            TramCam=:TramCam,
                            AoTuongAoGiac=:AoTuongAoGiac,
                            HoiChungGuillainBarre=:HoiChungGuillainBarre,
                            RoiLoanThanKinhTuDong=:RoiLoanThanKinhTuDong,
                            NhuocCoNang=:NhuocCoNang,
                            ViemDonDayThanKinh=:ViemDonDayThanKinh,
                            ViemDaDayThanKinh=:ViemDaDayThanKinh,
                            ViemMangTim=:ViemMangTim,
                            TranDichMangNgoaiTim=:TranDichMangNgoaiTim,
                            DauHieuSuyTim=:DauHieuSuyTim,
                            BenhCoTim=:BenhCoTim,
                            BenhVanTim=:BenhVanTim,
                            BenhVanTim_NeuCo=:BenhVanTim_NeuCo,
                            ViemMangPhoi=:ViemMangPhoi,
                            TranDichMangPhoi=:TranDichMangPhoi,
                            ViemPhoiCapTinh=:ViemPhoiCapTinh,
                            ViemPhoiKe=:ViemPhoiKe,
                            ViemPheQuanTacNghen=:ViemPheQuanTacNghen,
                            NhoiMauPhoi=:NhoiMauPhoi,
                            KhoiUAcTinhTaiPhoi=:KhoiUAcTinhTaiPhoi,
                            Non=:Non,
                            DauHoiKhoTieu=:DauHoiKhoTieu,
                            TieuChay=:TieuChay,
                            DauBung=:DauBung,
                            BieuHienTieuHoa_Khac=:BieuHienTieuHoa_Khac,
                            CongThucMau_BachCau=:CongThucMau_BachCau,
                            CongThucMau_Lympho=:CongThucMau_Lympho,
                            CongThucMau_Hc=:CongThucMau_Hc,
                            CongThucMau_Hb=:CongThucMau_Hb,
                            CongThucMau_TieuCau=:CongThucMau_TieuCau,
                            TestCoombTrucTiep=:TestCoombTrucTiep,
                            MauLang_1h=:MauLang_1h,
                            MauLang_2h=:MauLang_2h,
                            SinhHoa_Creatinin=:SinhHoa_Creatinin,
                            SinhHoa_Ure=:SinhHoa_Ure,
                            SinhHoa_ProteinToanPhan=:SinhHoa_ProteinToanPhan,
                            SinhHoa_Alb=:SinhHoa_Alb,
                            SinhHoa_Cholesterol=:SinhHoa_Cholesterol,
                            SinhHoa_Tri=:SinhHoa_Tri,
                            SinhHoa_GOT=:SinhHoa_GOT,
                            SinhHoa_GPT=:SinhHoa_GPT,
                            NuocTieu_ProteinNieu=:NuocTieu_ProteinNieu,
                            NuocTieu_TruNieu=:NuocTieu_TruNieu,
                            NuocTieu_HCNieu=:NuocTieu_HCNieu,
                            NuocTieu_BCNieu=:NuocTieu_BCNieu,
                            NuocTieu_ProteinNieu24h=:NuocTieu_ProteinNieu24h,
                            TeBaoHargaves=:TeBaoHargaves,
                            YeuToDangThapCARF=:YeuToDangThapCARF,
                            Ana=:Ana,
                            Ana_Co=:Ana_Co,
                            AntidsDNA=:AntidsDNA,
                            AntidsDNA_Co=:AntidsDNA_Co,
                            AntiPhospholipid=:AntiPhospholipid,
                            AntiPhospholipid_Co=:AntiPhospholipid_Co,
                            AntiSm=:AntiSm,
                            AntiSm_Co=:AntiSm_Co,
                            AntiCardiolipin=:AntiCardiolipin,
                            AntiCardiolipin_Co=:AntiCardiolipin_Co,
                            AntiSSA=:AntiSSA,
                            AntiSSA_Co=:AntiSSA_Co,
                            KhangDongLupus=:KhangDongLupus,
                            KhangDongLupus_Co=:KhangDongLupus_Co,
                            AntiSSB=:AntiSSB,
                            AntiSSB_Co=:AntiSSB_Co,
                            AntiB2Glycoptotein=:AntiB2Glycoptotein,
                            AntiB2Glycoptotein_Co=:AntiB2Glycoptotein_Co,
                            AntiU1=:AntiU1,
                            AntiU1_Co=:AntiU1_Co,
                            AntiHistone=:AntiHistone,
                            AntiHistone_Co=:AntiHistone_Co,
                            KTKhac=:KTKhac,
                            TuKhangTheNeuCo=:TuKhangTheNeuCo,
                            TotalIgG=:TotalIgG,
                            C3_Text=:C3_Text,
                            C3=:C3,
                            C4_Text=:C4_Text,
                            C4=:C4,
                            SinhThietDa=:SinhThietDa,
                            SinhThietDa_NeuCo=:SinhThietDa_NeuCo,
                            LupusBandTest=:LupusBandTest,
                            LupusBandTest_NeuCo=:LupusBandTest_NeuCo,
                            LupusBandTest_DuongTinh=:LupusBandTest_DuongTinh,
                            SinhThietThan=:SinhThietThan,
                            KhamMat_NgayKham=:KhamMat_NgayKham,
                            KhamMat_KetQua=:KhamMat_KetQua,
                            BanDoHinhCanhBuom=:BanDoHinhCanhBuom,
                            BanDoHinhDia=:BanDoHinhDia,
                            NhayCamAnhSang=:NhayCamAnhSang,
                            LoetMieng=:LoetMieng,
                            ViemKhop=:ViemKhop,
                            ViemTranDichThanhMac=:ViemTranDichThanhMac,
                            RoiLoanChucNangThan=:RoiLoanChucNangThan,
                            RoiLoanThanKinhTamThan=:RoiLoanThanKinhTamThan,
                            RoiLoanVeMau=:RoiLoanVeMau,
                            RoiLoanMienDich=:RoiLoanMienDich,
                            AnaDuongTinh=:AnaDuongTinh,
                            Tong11TieuChuan=:Tong11TieuChuan,
                            TieuChuanLamSang=:TieuChuanLamSang,
                            TieuChuanCanLamSang=:TieuChuanCanLamSang,
                            Tong17TieuChuan=:Tong17TieuChuan,
                            DiemSLEDAI_1=:DiemSLEDAI_1,
                            DiemSLEDAI_2=:DiemSLEDAI_2,
                            DiemSLEDAI_3=:DiemSLEDAI_3,
                            DiemSLEDAI_4=:DiemSLEDAI_4,
                            DiemSLEDAI_5=:DiemSLEDAI_5,
                            DiemSLEDAI_6=:DiemSLEDAI_6,
                            DiemSLEDAI_7=:DiemSLEDAI_7,
                            DiemSLEDAI_8=:DiemSLEDAI_8,
                            DiemSLEDAI_9=:DiemSLEDAI_9,
                            DiemSLEDAI_10=:DiemSLEDAI_10,
                            DiemSLEDAI_11=:DiemSLEDAI_11,
                            DiemSLEDAI_12=:DiemSLEDAI_12,
                            DiemSLEDAI_13=:DiemSLEDAI_13,
                            DiemSLEDAI_14=:DiemSLEDAI_14,
                            DiemSLEDAI_15=:DiemSLEDAI_15,
                            DiemSLEDAI_16=:DiemSLEDAI_16,
                            DiemSLEDAI_17=:DiemSLEDAI_17,
                            DiemSLEDAI_18=:DiemSLEDAI_18,
                            DiemSLEDAI_19=:DiemSLEDAI_19,
                            DiemSLEDAI_20=:DiemSLEDAI_20,
                            DiemSLEDAI_21=:DiemSLEDAI_21,
                            DiemSLEDAI_22=:DiemSLEDAI_22,
                            DiemSLEDAI_23=:DiemSLEDAI_23,
                            DiemSLEDAI_24=:DiemSLEDAI_24,
                            DiemSLEDAI_TongDiem=:DiemSLEDAI_TongDiem,
                            DiemSLEQOL_1=:DiemSLEQOL_1,
                            DiemSLEQOL_2=:DiemSLEQOL_2,
                            DiemSLEQOL_3=:DiemSLEQOL_3,
                            DiemSLEQOL_4=:DiemSLEQOL_4,
                            DiemSLEQOL_5=:DiemSLEQOL_5,
                            DiemSLEQOL_6=:DiemSLEQOL_6,
                            DiemSLEQOL_7=:DiemSLEQOL_7,
                            DiemSLEQOL_8=:DiemSLEQOL_8,
                            DiemSLEQOL_9=:DiemSLEQOL_9,
                            DiemSLEQOL_10=:DiemSLEQOL_10,
                            DiemSLEQOL_11=:DiemSLEQOL_11,
                            DiemSLEQOL_12=:DiemSLEQOL_12,
                            DiemSLEQOL_13=:DiemSLEQOL_13,
                            DiemSLEQOL_14=:DiemSLEQOL_14,
                            DiemSLEQOL_15=:DiemSLEQOL_15,
                            DiemSLEQOL_16=:DiemSLEQOL_16,
                            DiemSLEQOL_17=:DiemSLEQOL_17,
                            DiemSLEQOL_18=:DiemSLEQOL_18,
                            DiemSLEQOL_19=:DiemSLEQOL_19,
                            DiemSLEQOL_20=:DiemSLEQOL_20,
                            DiemSLEQOL_21=:DiemSLEQOL_21,
                            DiemSLEQOL_22=:DiemSLEQOL_22,
                            DiemSLEQOL_23=:DiemSLEQOL_23,
                            DiemSLEQOL_24=:DiemSLEQOL_24,
                            DiemSLEQOL_25=:DiemSLEQOL_25,
                            DiemSLEQOL_26=:DiemSLEQOL_26,
                            DiemSLEQOL_27=:DiemSLEQOL_27,
                            DiemSLEQOL_28=:DiemSLEQOL_28,
                            DiemSLEQOL_29=:DiemSLEQOL_29,
                            DiemSLEQOL_30=:DiemSLEQOL_30,
                            DiemSLEQOL_31=:DiemSLEQOL_31,
                            DiemSLEQOL_32=:DiemSLEQOL_32,
                            DiemSLEQOL_33=:DiemSLEQOL_33,
                            DiemSLEQOL_34=:DiemSLEQOL_34,
                            DiemSLEQOL_35=:DiemSLEQOL_35,
                            DiemSLEQOL_36=:DiemSLEQOL_36,
                            DiemSLEQOL_37=:DiemSLEQOL_37,
                            DiemSLEQOL_38=:DiemSLEQOL_38,
                            DiemSLEQOL_39=:DiemSLEQOL_39,
                            DiemSLEQOL_40=:DiemSLEQOL_40,
                            DiemSLEQOL_1_Text=:DiemSLEQOL_1_Text,
                            DiemSLEQOL_2_Text=:DiemSLEQOL_2_Text,
                            DiemSLEQOL_3_Text=:DiemSLEQOL_3_Text,
                            DiemSLEQOL_4_Text=:DiemSLEQOL_4_Text,
                            DiemSLEQOL_5_Text=:DiemSLEQOL_5_Text,
                            DiemSLEQOL_6_Text=:DiemSLEQOL_6_Text,
                            DiemSLEQOL_7_Text=:DiemSLEQOL_7_Text,
                            DiemSLEQOL_8_Text=:DiemSLEQOL_8_Text,
                            DiemSLEQOL_9_Text=:DiemSLEQOL_9_Text,
                            DiemSLEQOL_10_Text=:DiemSLEQOL_10_Text,
                            DiemSLEQOL_11_Text=:DiemSLEQOL_11_Text,
                            DiemSLEQOL_12_Text=:DiemSLEQOL_12_Text,
                            DiemSLEQOL_13_Text=:DiemSLEQOL_13_Text,
                            DiemSLEQOL_14_Text=:DiemSLEQOL_14_Text,
                            DiemSLEQOL_15_Text=:DiemSLEQOL_15_Text,
                            DiemSLEQOL_16_Text=:DiemSLEQOL_16_Text,
                            DiemSLEQOL_17_Text=:DiemSLEQOL_17_Text,
                            DiemSLEQOL_18_Text=:DiemSLEQOL_18_Text,
                            DiemSLEQOL_19_Text=:DiemSLEQOL_19_Text,
                            DiemSLEQOL_20_Text=:DiemSLEQOL_20_Text,
                            DiemSLEQOL_21_Text=:DiemSLEQOL_21_Text,
                            DiemSLEQOL_22_Text=:DiemSLEQOL_22_Text,
                            DiemSLEQOL_23_Text=:DiemSLEQOL_23_Text,
                            DiemSLEQOL_24_Text=:DiemSLEQOL_24_Text,
                            DiemSLEQOL_25_Text=:DiemSLEQOL_25_Text,
                            DiemSLEQOL_26_Text=:DiemSLEQOL_26_Text,
                            DiemSLEQOL_27_Text=:DiemSLEQOL_27_Text,
                            DiemSLEQOL_28_Text=:DiemSLEQOL_28_Text,
                            DiemSLEQOL_29_Text=:DiemSLEQOL_29_Text,
                            DiemSLEQOL_30_Text=:DiemSLEQOL_30_Text,
                            DiemSLEQOL_31_Text=:DiemSLEQOL_31_Text,
                            DiemSLEQOL_32_Text=:DiemSLEQOL_32_Text,
                            DiemSLEQOL_33_Text=:DiemSLEQOL_33_Text,
                            DiemSLEQOL_34_Text=:DiemSLEQOL_34_Text,
                            DiemSLEQOL_35_Text=:DiemSLEQOL_35_Text,
                            DiemSLEQOL_36_Text=:DiemSLEQOL_36_Text,
                            DiemSLEQOL_37_Text=:DiemSLEQOL_37_Text,
                            DiemSLEQOL_38_Text=:DiemSLEQOL_38_Text,
                            DiemSLEQOL_39_Text=:DiemSLEQOL_39_Text,
                            DiemSLEQOL_40_Text=:DiemSLEQOL_40_Text,
                            DiemSLEQOL_TongDiem=:DiemSLEQOL_TongDiem,
                            Corticosteroid=:Corticosteroid,
                            KhangSotRet=:KhangSotRet,
                            Cyclophosphamide=:Cyclophosphamide,
                            CyclophosphamideLieuCao=:CyclophosphamideLieuCao,
                            Azathioprine=:Azathioprine,
                            Methotrexate=:Methotrexate,
                            CyclosporineA=:CyclosporineA,
                            ThuocKhac=:ThuocKhac,
                            DieuTriHienTai=:DieuTriHienTai,
                            HenKham=:HenKham,
                            BacSiDieuTri=:BacSiDieuTri,
                            TK_SoBenhAnDienTu=:TK_SoBenhAnDienTu,
                            TK_SoLuuTru=:TK_SoLuuTru,
                            NgayKham=:NgayKham,
                            NgayLuuHuyetThanh=:NgayLuuHuyetThanh,
                            BacSiKham=:BacSiKham,
                            MaBacSiKham=:MaBacSiKham,
                            TK_Sot=:TK_Sot,
                            TK_HachTo=:TK_HachTo,
                            TK_MetMoi=:TK_MetMoi,
                            TK_LachTo=:TK_LachTo,
                            TK_HA=:TK_HA,
                            TK_TienSu_BenhThem=:TK_TienSu_BenhThem,
                            TK_Da=:TK_Da,
                            TK_Co=:TK_Co,
                            TK_Khop=:TK_Khop,
                            TK_ThanKinh=:TK_ThanKinh,
                            TK_TimMach=:TK_TimMach,
                            TK_HoHap=:TK_HoHap,
                            TK_TieuHoa=:TK_TieuHoa,
                            TK_TrieuChungKhac=:TK_TrieuChungKhac,
                            TK_CongThucMau_BachCau=:TK_CongThucMau_BachCau,
                            TK_CongThucMau_Lympho=:TK_CongThucMau_Lympho,
                            TK_CongThucMau_Hc=:TK_CongThucMau_Hc,
                            TK_CongThucMau_Hb=:TK_CongThucMau_Hb,
                            TK_CongThucMau_TieuCau=:TK_CongThucMau_TieuCau,
                            TK_TestCoombTrucTiep=:TK_TestCoombTrucTiep,
                            TK_MauLang_1h=:TK_MauLang_1h,
                            TK_MauLang_2h=:TK_MauLang_2h,
                            TK_SinhHoa_Creatinin=:TK_SinhHoa_Creatinin,
                            TK_SinhHoa_Ure=:TK_SinhHoa_Ure,
                            TK_SinhHoa_ProteinToanPhan=:TK_SinhHoa_ProteinToanPhan,
                            TK_SinhHoa_Alb=:TK_SinhHoa_Alb,
                            TK_SinhHoa_Cholesterol=:TK_SinhHoa_Cholesterol,
                            TK_SinhHoa_Tri=:TK_SinhHoa_Tri,
                            TK_SinhHoa_GOT=:TK_SinhHoa_GOT,
                            TK_SinhHoa_GPT=:TK_SinhHoa_GPT,
                            TK_NuocTieu_ProteinNieu=:TK_NuocTieu_ProteinNieu,
                            TK_NuocTieu_TruNieu=:TK_NuocTieu_TruNieu,
                            TK_NuocTieu_HCNieu=:TK_NuocTieu_HCNieu,
                            TK_NuocTieu_BCNieu=:TK_NuocTieu_BCNieu,
                            TK_NuocTieu_ProteinNieu24h=:TK_NuocTieu_ProteinNieu24h,
                            TK_YeuToDangThap_Text=:TK_YeuToDangThap_Text,
                            TK_YeuToDangThap_Khong=:TK_YeuToDangThap_Khong,
                            XuatHienTuKhangThe=:XuatHienTuKhangThe,
                            TK_KhamMat=:TK_KhamMat,
                            TK_KhamMat_KetQua=:TK_KhamMat_KetQua,
                            TK_XetNghiemKhac=:TK_XetNghiemKhac,
                            TK_DiemSLEQOL_TongDiem=:TK_DiemSLEQOL_TongDiem,
                            TK_ChuY=:TK_ChuY,
                            TK_DieuTri=:TK_DieuTri,
                            TK_HenKham=:TK_HenKham,
                            TK_BacSiDieuTri=:TK_BacSiDieuTri,
                            TK_MaBacSiDieuTri=:TK_MaBacSiDieuTri,
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
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriNgoaiTruTu", BenhAnNgoaiTru_LupusBanDoHeThong.DieuTriNgoaiTruTu));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriNgoaiTruDen", BenhAnNgoaiTru_LupusBanDoHeThong.DieuTriNgoaiTruDen));
                Command.Parameters.Add(new MDB.MDBParameter("SoCMND", BenhAnNgoaiTru_LupusBanDoHeThong.SoCMND));
                Command.Parameters.Add(new MDB.MDBParameter("BaoHiem", BenhAnNgoaiTru_LupusBanDoHeThong.BaoHiem));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan_TuyenTruoc", BenhAnNgoaiTru_LupusBanDoHeThong.ChanDoan_TuyenTruoc));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanBanDau", BenhAnNgoaiTru_LupusBanDoHeThong.ChanDoanBanDau));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham1", BenhAnNgoaiTru_LupusBanDoHeThong.ChanDoanTaiKham1));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham2", BenhAnNgoaiTru_LupusBanDoHeThong.ChanDoanTaiKham2));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham3", BenhAnNgoaiTru_LupusBanDoHeThong.ChanDoanTaiKham3));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham4", BenhAnNgoaiTru_LupusBanDoHeThong.ChanDoanTaiKham4));
                Command.Parameters.Add(new MDB.MDBParameter("BenhPhu", BenhAnNgoaiTru_LupusBanDoHeThong.BenhPhu));
                Command.Parameters.Add(new MDB.MDBParameter("KetQuaDieuTri", BenhAnNgoaiTru_LupusBanDoHeThong.KetQuaDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("BienChung_Text", BenhAnNgoaiTru_LupusBanDoHeThong.BienChung_Text));
                Command.Parameters.Add(new MDB.MDBParameter("GDPhongKeHoach", BenhAnNgoaiTru_LupusBanDoHeThong.GDPhongKeHoach));
                Command.Parameters.Add(new MDB.MDBParameter("GDPhongKhamBenh", BenhAnNgoaiTru_LupusBanDoHeThong.GDPhongKhamBenh));
                // hỏi bệnh, khám bệnh
                Command.Parameters.Add(new MDB.MDBParameter("Can", BenhAnNgoaiTru_LupusBanDoHeThong.Can));
                Command.Parameters.Add(new MDB.MDBParameter("Cao", BenhAnNgoaiTru_LupusBanDoHeThong.Cao));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianTuKhiKhoiPhat", BenhAnNgoaiTru_LupusBanDoHeThong.ThoiGianTuKhiKhoiPhat));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungDauTien", BenhAnNgoaiTru_LupusBanDoHeThong.TrieuChungDauTien));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuCoBenhTuMienKhac", BenhAnNgoaiTru_LupusBanDoHeThong.TienSuCoBenhTuMienKhac));
                Command.Parameters.Add(new MDB.MDBParameter("CoBenhCollagen", BenhAnNgoaiTru_LupusBanDoHeThong.CoBenhCollagen));
                Command.Parameters.Add(new MDB.MDBParameter("XoCungBi", BenhAnNgoaiTru_LupusBanDoHeThong.XoCungBi));
                Command.Parameters.Add(new MDB.MDBParameter("ViemDaCo", BenhAnNgoaiTru_LupusBanDoHeThong.ViemDaCo));
                Command.Parameters.Add(new MDB.MDBParameter("HoiChungSjogren", BenhAnNgoaiTru_LupusBanDoHeThong.HoiChungSjogren));
                Command.Parameters.Add(new MDB.MDBParameter("XoGanMatTienPhat", BenhAnNgoaiTru_LupusBanDoHeThong.XoGanMatTienPhat));
                Command.Parameters.Add(new MDB.MDBParameter("ViemTuyenGiap", BenhAnNgoaiTru_LupusBanDoHeThong.ViemTuyenGiap));
                Command.Parameters.Add(new MDB.MDBParameter("HoiChungKhangPhospholipid", BenhAnNgoaiTru_LupusBanDoHeThong.HoiChungKhangPhospholipid));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuCoBenh_Khac", BenhAnNgoaiTru_LupusBanDoHeThong.TienSuCoBenh_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuCaNhan", BenhAnNgoaiTru_LupusBanDoHeThong.TienSuCaNhan));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuCaNhan_Co", BenhAnNgoaiTru_LupusBanDoHeThong.TienSuCaNhan_Co));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuGiaDinh", BenhAnNgoaiTru_LupusBanDoHeThong.TienSuGiaDinh));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuGiaDinh_Co", BenhAnNgoaiTru_LupusBanDoHeThong.TienSuGiaDinh_Co));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuGiaDinh_NeuCo", BenhAnNgoaiTru_LupusBanDoHeThong.TienSuGiaDinh_NeuCo));
                Command.Parameters.Add(new MDB.MDBParameter("Sot", BenhAnNgoaiTru_LupusBanDoHeThong.Sot));
                Command.Parameters.Add(new MDB.MDBParameter("HachTo", BenhAnNgoaiTru_LupusBanDoHeThong.HachTo));
                Command.Parameters.Add(new MDB.MDBParameter("MetMoi", BenhAnNgoaiTru_LupusBanDoHeThong.MetMoi));
                Command.Parameters.Add(new MDB.MDBParameter("LachTo", BenhAnNgoaiTru_LupusBanDoHeThong.LachTo));
                Command.Parameters.Add(new MDB.MDBParameter("HA", BenhAnNgoaiTru_LupusBanDoHeThong.HA));
                Command.Parameters.Add(new MDB.MDBParameter("LamSangDaNiemMac", BenhAnNgoaiTru_LupusBanDoHeThong.LamSangDaNiemMac));
                Command.Parameters.Add(new MDB.MDBParameter("TonThuongKhac", BenhAnNgoaiTru_LupusBanDoHeThong.TonThuongKhac));
                Command.Parameters.Add(new MDB.MDBParameter("YeuCoGoc", BenhAnNgoaiTru_LupusBanDoHeThong.YeuCoGoc));
                Command.Parameters.Add(new MDB.MDBParameter("TangCpk", BenhAnNgoaiTru_LupusBanDoHeThong.TangCpk));
                Command.Parameters.Add(new MDB.MDBParameter("TangCpk_Co", BenhAnNgoaiTru_LupusBanDoHeThong.TangCpk_Co));
                Command.Parameters.Add(new MDB.MDBParameter("DienCoBatThuong", BenhAnNgoaiTru_LupusBanDoHeThong.DienCoBatThuong));
                Command.Parameters.Add(new MDB.MDBParameter("SinhThietCoBatThuong", BenhAnNgoaiTru_LupusBanDoHeThong.SinhThietCoBatThuong));
                Command.Parameters.Add(new MDB.MDBParameter("DauKhop", BenhAnNgoaiTru_LupusBanDoHeThong.DauKhop));
                Command.Parameters.Add(new MDB.MDBParameter("DauKhop_ViTri", BenhAnNgoaiTru_LupusBanDoHeThong.DauKhop_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("DauKhop_SoLuong", BenhAnNgoaiTru_LupusBanDoHeThong.DauKhop_SoLuong));
                Command.Parameters.Add(new MDB.MDBParameter("SungKhop", BenhAnNgoaiTru_LupusBanDoHeThong.SungKhop));
                Command.Parameters.Add(new MDB.MDBParameter("SungKhop_ViTri", BenhAnNgoaiTru_LupusBanDoHeThong.SungKhop_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("SungKhop_SoLuong", BenhAnNgoaiTru_LupusBanDoHeThong.SungKhop_SoLuong));
                Command.Parameters.Add(new MDB.MDBParameter("CungKhop", BenhAnNgoaiTru_LupusBanDoHeThong.CungKhop));
                Command.Parameters.Add(new MDB.MDBParameter("CungKhop_ViTri", BenhAnNgoaiTru_LupusBanDoHeThong.CungKhop_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("CungKhop_SoLuong", BenhAnNgoaiTru_LupusBanDoHeThong.CungKhop_SoLuong));
                Command.Parameters.Add(new MDB.MDBParameter("DauDauNuaDau", BenhAnNgoaiTru_LupusBanDoHeThong.DauDauNuaDau));
                Command.Parameters.Add(new MDB.MDBParameter("ViemMangNaoVoKhuan", BenhAnNgoaiTru_LupusBanDoHeThong.ViemMangNaoVoKhuan));
                Command.Parameters.Add(new MDB.MDBParameter("BenhMachNao", BenhAnNgoaiTru_LupusBanDoHeThong.BenhMachNao));
                Command.Parameters.Add(new MDB.MDBParameter("MuaGiat", BenhAnNgoaiTru_LupusBanDoHeThong.MuaGiat));
                Command.Parameters.Add(new MDB.MDBParameter("DongKinh", BenhAnNgoaiTru_LupusBanDoHeThong.DongKinh));
                Command.Parameters.Add(new MDB.MDBParameter("TrangThaiLuLanCapTinh", BenhAnNgoaiTru_LupusBanDoHeThong.TrangThaiLuLanCapTinh));
                Command.Parameters.Add(new MDB.MDBParameter("RoiLoanLoAu", BenhAnNgoaiTru_LupusBanDoHeThong.RoiLoanLoAu));
                Command.Parameters.Add(new MDB.MDBParameter("RoiLoanChucNangNhanThuc", BenhAnNgoaiTru_LupusBanDoHeThong.RoiLoanChucNangNhanThuc));
                Command.Parameters.Add(new MDB.MDBParameter("TramCam", BenhAnNgoaiTru_LupusBanDoHeThong.TramCam));
                Command.Parameters.Add(new MDB.MDBParameter("AoTuongAoGiac", BenhAnNgoaiTru_LupusBanDoHeThong.AoTuongAoGiac));
                Command.Parameters.Add(new MDB.MDBParameter("HoiChungGuillainBarre", BenhAnNgoaiTru_LupusBanDoHeThong.HoiChungGuillainBarre));
                Command.Parameters.Add(new MDB.MDBParameter("RoiLoanThanKinhTuDong", BenhAnNgoaiTru_LupusBanDoHeThong.RoiLoanThanKinhTuDong));
                Command.Parameters.Add(new MDB.MDBParameter("NhuocCoNang", BenhAnNgoaiTru_LupusBanDoHeThong.NhuocCoNang));
                Command.Parameters.Add(new MDB.MDBParameter("ViemDonDayThanKinh", BenhAnNgoaiTru_LupusBanDoHeThong.ViemDonDayThanKinh));
                Command.Parameters.Add(new MDB.MDBParameter("ViemDaDayThanKinh", BenhAnNgoaiTru_LupusBanDoHeThong.ViemDaDayThanKinh));
                Command.Parameters.Add(new MDB.MDBParameter("ViemMangTim", BenhAnNgoaiTru_LupusBanDoHeThong.ViemMangTim));
                Command.Parameters.Add(new MDB.MDBParameter("TranDichMangNgoaiTim", BenhAnNgoaiTru_LupusBanDoHeThong.TranDichMangNgoaiTim));
                Command.Parameters.Add(new MDB.MDBParameter("DauHieuSuyTim", BenhAnNgoaiTru_LupusBanDoHeThong.DauHieuSuyTim));
                Command.Parameters.Add(new MDB.MDBParameter("BenhCoTim", BenhAnNgoaiTru_LupusBanDoHeThong.BenhCoTim));
                Command.Parameters.Add(new MDB.MDBParameter("BenhVanTim", BenhAnNgoaiTru_LupusBanDoHeThong.BenhVanTim));
                Command.Parameters.Add(new MDB.MDBParameter("BenhVanTim_NeuCo", BenhAnNgoaiTru_LupusBanDoHeThong.BenhVanTim_NeuCo));
                Command.Parameters.Add(new MDB.MDBParameter("ViemMangPhoi", BenhAnNgoaiTru_LupusBanDoHeThong.ViemMangPhoi));
                Command.Parameters.Add(new MDB.MDBParameter("TranDichMangPhoi", BenhAnNgoaiTru_LupusBanDoHeThong.TranDichMangPhoi));
                Command.Parameters.Add(new MDB.MDBParameter("ViemPhoiCapTinh", BenhAnNgoaiTru_LupusBanDoHeThong.ViemPhoiCapTinh));
                Command.Parameters.Add(new MDB.MDBParameter("ViemPhoiKe", BenhAnNgoaiTru_LupusBanDoHeThong.ViemPhoiKe));
                Command.Parameters.Add(new MDB.MDBParameter("ViemPheQuanTacNghen", BenhAnNgoaiTru_LupusBanDoHeThong.ViemPheQuanTacNghen));
                Command.Parameters.Add(new MDB.MDBParameter("NhoiMauPhoi", BenhAnNgoaiTru_LupusBanDoHeThong.NhoiMauPhoi));
                Command.Parameters.Add(new MDB.MDBParameter("KhoiUAcTinhTaiPhoi", BenhAnNgoaiTru_LupusBanDoHeThong.KhoiUAcTinhTaiPhoi));
                Command.Parameters.Add(new MDB.MDBParameter("Non", BenhAnNgoaiTru_LupusBanDoHeThong.Non));
                Command.Parameters.Add(new MDB.MDBParameter("DauHoiKhoTieu", BenhAnNgoaiTru_LupusBanDoHeThong.DauHoiKhoTieu));
                Command.Parameters.Add(new MDB.MDBParameter("TieuChay", BenhAnNgoaiTru_LupusBanDoHeThong.TieuChay));
                Command.Parameters.Add(new MDB.MDBParameter("DauBung", BenhAnNgoaiTru_LupusBanDoHeThong.DauBung));
                Command.Parameters.Add(new MDB.MDBParameter("BieuHienTieuHoa_Khac", BenhAnNgoaiTru_LupusBanDoHeThong.BieuHienTieuHoa_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("CongThucMau_BachCau", BenhAnNgoaiTru_LupusBanDoHeThong.CongThucMau_BachCau));
                Command.Parameters.Add(new MDB.MDBParameter("CongThucMau_Lympho", BenhAnNgoaiTru_LupusBanDoHeThong.CongThucMau_Lympho));
                Command.Parameters.Add(new MDB.MDBParameter("CongThucMau_Hc", BenhAnNgoaiTru_LupusBanDoHeThong.CongThucMau_Hc));
                Command.Parameters.Add(new MDB.MDBParameter("CongThucMau_Hb", BenhAnNgoaiTru_LupusBanDoHeThong.CongThucMau_Hb));
                Command.Parameters.Add(new MDB.MDBParameter("CongThucMau_TieuCau", BenhAnNgoaiTru_LupusBanDoHeThong.CongThucMau_TieuCau));
                Command.Parameters.Add(new MDB.MDBParameter("TestCoombTrucTiep", BenhAnNgoaiTru_LupusBanDoHeThong.TestCoombTrucTiep));
                Command.Parameters.Add(new MDB.MDBParameter("MauLang_1h", BenhAnNgoaiTru_LupusBanDoHeThong.MauLang_1h));
                Command.Parameters.Add(new MDB.MDBParameter("MauLang_2h", BenhAnNgoaiTru_LupusBanDoHeThong.MauLang_2h));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_Creatinin", BenhAnNgoaiTru_LupusBanDoHeThong.SinhHoa_Creatinin));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_Ure", BenhAnNgoaiTru_LupusBanDoHeThong.SinhHoa_Ure));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_ProteinToanPhan", BenhAnNgoaiTru_LupusBanDoHeThong.SinhHoa_ProteinToanPhan));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_Alb", BenhAnNgoaiTru_LupusBanDoHeThong.SinhHoa_Alb));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_Cholesterol", BenhAnNgoaiTru_LupusBanDoHeThong.SinhHoa_Cholesterol));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_Tri", BenhAnNgoaiTru_LupusBanDoHeThong.SinhHoa_Tri));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_GOT", BenhAnNgoaiTru_LupusBanDoHeThong.SinhHoa_GOT));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_GPT", BenhAnNgoaiTru_LupusBanDoHeThong.SinhHoa_GPT));
                Command.Parameters.Add(new MDB.MDBParameter("NuocTieu_ProteinNieu", BenhAnNgoaiTru_LupusBanDoHeThong.NuocTieu_ProteinNieu));
                Command.Parameters.Add(new MDB.MDBParameter("NuocTieu_TruNieu", BenhAnNgoaiTru_LupusBanDoHeThong.NuocTieu_TruNieu));
                Command.Parameters.Add(new MDB.MDBParameter("NuocTieu_HCNieu", BenhAnNgoaiTru_LupusBanDoHeThong.NuocTieu_HCNieu));
                Command.Parameters.Add(new MDB.MDBParameter("NuocTieu_BCNieu", BenhAnNgoaiTru_LupusBanDoHeThong.NuocTieu_BCNieu));
                Command.Parameters.Add(new MDB.MDBParameter("NuocTieu_ProteinNieu24h", BenhAnNgoaiTru_LupusBanDoHeThong.NuocTieu_ProteinNieu24h));
                Command.Parameters.Add(new MDB.MDBParameter("TeBaoHargaves", BenhAnNgoaiTru_LupusBanDoHeThong.TeBaoHargaves));
                Command.Parameters.Add(new MDB.MDBParameter("YeuToDangThapCARF", BenhAnNgoaiTru_LupusBanDoHeThong.YeuToDangThapCARF));
                Command.Parameters.Add(new MDB.MDBParameter("Ana", BenhAnNgoaiTru_LupusBanDoHeThong.Ana));
                Command.Parameters.Add(new MDB.MDBParameter("Ana_Co", BenhAnNgoaiTru_LupusBanDoHeThong.Ana_Co));
                Command.Parameters.Add(new MDB.MDBParameter("AntidsDNA", BenhAnNgoaiTru_LupusBanDoHeThong.AntidsDNA));
                Command.Parameters.Add(new MDB.MDBParameter("AntidsDNA_Co", BenhAnNgoaiTru_LupusBanDoHeThong.AntidsDNA_Co));
                Command.Parameters.Add(new MDB.MDBParameter("AntiPhospholipid", BenhAnNgoaiTru_LupusBanDoHeThong.AntiPhospholipid));
                Command.Parameters.Add(new MDB.MDBParameter("AntiPhospholipid_Co", BenhAnNgoaiTru_LupusBanDoHeThong.AntiPhospholipid_Co));
                Command.Parameters.Add(new MDB.MDBParameter("AntiSm", BenhAnNgoaiTru_LupusBanDoHeThong.AntiSm));
                Command.Parameters.Add(new MDB.MDBParameter("AntiSm_Co", BenhAnNgoaiTru_LupusBanDoHeThong.AntiSm_Co));
                Command.Parameters.Add(new MDB.MDBParameter("AntiCardiolipin", BenhAnNgoaiTru_LupusBanDoHeThong.AntiCardiolipin));
                Command.Parameters.Add(new MDB.MDBParameter("AntiCardiolipin_Co", BenhAnNgoaiTru_LupusBanDoHeThong.AntiCardiolipin_Co));
                Command.Parameters.Add(new MDB.MDBParameter("AntiSSA", BenhAnNgoaiTru_LupusBanDoHeThong.AntiSSA));
                Command.Parameters.Add(new MDB.MDBParameter("AntiSSA_Co", BenhAnNgoaiTru_LupusBanDoHeThong.AntiSSA_Co));
                Command.Parameters.Add(new MDB.MDBParameter("KhangDongLupus", BenhAnNgoaiTru_LupusBanDoHeThong.KhangDongLupus));
                Command.Parameters.Add(new MDB.MDBParameter("KhangDongLupus_Co", BenhAnNgoaiTru_LupusBanDoHeThong.KhangDongLupus_Co));
                Command.Parameters.Add(new MDB.MDBParameter("AntiSSB", BenhAnNgoaiTru_LupusBanDoHeThong.AntiSSB));
                Command.Parameters.Add(new MDB.MDBParameter("AntiSSB_Co", BenhAnNgoaiTru_LupusBanDoHeThong.AntiSSB_Co));
                Command.Parameters.Add(new MDB.MDBParameter("AntiB2Glycoptotein", BenhAnNgoaiTru_LupusBanDoHeThong.AntiB2Glycoptotein));
                Command.Parameters.Add(new MDB.MDBParameter("AntiB2Glycoptotein_Co", BenhAnNgoaiTru_LupusBanDoHeThong.AntiB2Glycoptotein_Co));
                Command.Parameters.Add(new MDB.MDBParameter("AntiU1", BenhAnNgoaiTru_LupusBanDoHeThong.AntiU1));
                Command.Parameters.Add(new MDB.MDBParameter("AntiU1_Co", BenhAnNgoaiTru_LupusBanDoHeThong.AntiU1_Co));
                Command.Parameters.Add(new MDB.MDBParameter("AntiHistone", BenhAnNgoaiTru_LupusBanDoHeThong.AntiHistone));
                Command.Parameters.Add(new MDB.MDBParameter("AntiHistone_Co", BenhAnNgoaiTru_LupusBanDoHeThong.AntiHistone_Co));
                Command.Parameters.Add(new MDB.MDBParameter("KTKhac", BenhAnNgoaiTru_LupusBanDoHeThong.KTKhac));
                Command.Parameters.Add(new MDB.MDBParameter("TuKhangTheNeuCo", BenhAnNgoaiTru_LupusBanDoHeThong.TuKhangTheNeuCo));
                Command.Parameters.Add(new MDB.MDBParameter("TotalIgG", BenhAnNgoaiTru_LupusBanDoHeThong.TotalIgG));
                Command.Parameters.Add(new MDB.MDBParameter("C3_Text", BenhAnNgoaiTru_LupusBanDoHeThong.C3_Text));
                Command.Parameters.Add(new MDB.MDBParameter("C3", BenhAnNgoaiTru_LupusBanDoHeThong.C3));
                Command.Parameters.Add(new MDB.MDBParameter("C4_Text", BenhAnNgoaiTru_LupusBanDoHeThong.C4_Text));
                Command.Parameters.Add(new MDB.MDBParameter("C4", BenhAnNgoaiTru_LupusBanDoHeThong.C4));
                Command.Parameters.Add(new MDB.MDBParameter("SinhThietDa", BenhAnNgoaiTru_LupusBanDoHeThong.SinhThietDa));
                Command.Parameters.Add(new MDB.MDBParameter("SinhThietDa_NeuCo", BenhAnNgoaiTru_LupusBanDoHeThong.SinhThietDa_NeuCo));
                Command.Parameters.Add(new MDB.MDBParameter("LupusBandTest", BenhAnNgoaiTru_LupusBanDoHeThong.LupusBandTest));
                Command.Parameters.Add(new MDB.MDBParameter("LupusBandTest_NeuCo", BenhAnNgoaiTru_LupusBanDoHeThong.LupusBandTest_NeuCo));
                Command.Parameters.Add(new MDB.MDBParameter("LupusBandTest_DuongTinh", BenhAnNgoaiTru_LupusBanDoHeThong.LupusBandTest_DuongTinh));
                Command.Parameters.Add(new MDB.MDBParameter("SinhThietThan", BenhAnNgoaiTru_LupusBanDoHeThong.SinhThietThan));
                Command.Parameters.Add(new MDB.MDBParameter("KhamMat_NgayKham", BenhAnNgoaiTru_LupusBanDoHeThong.KhamMat_NgayKham));
                Command.Parameters.Add(new MDB.MDBParameter("KhamMat_KetQua", BenhAnNgoaiTru_LupusBanDoHeThong.KhamMat_KetQua));
                Command.Parameters.Add(new MDB.MDBParameter("BanDoHinhCanhBuom", BenhAnNgoaiTru_LupusBanDoHeThong.BanDoHinhCanhBuom));
                Command.Parameters.Add(new MDB.MDBParameter("BanDoHinhDia", BenhAnNgoaiTru_LupusBanDoHeThong.BanDoHinhDia));
                Command.Parameters.Add(new MDB.MDBParameter("NhayCamAnhSang", BenhAnNgoaiTru_LupusBanDoHeThong.NhayCamAnhSang));
                Command.Parameters.Add(new MDB.MDBParameter("LoetMieng", BenhAnNgoaiTru_LupusBanDoHeThong.LoetMieng));
                Command.Parameters.Add(new MDB.MDBParameter("ViemKhop", BenhAnNgoaiTru_LupusBanDoHeThong.ViemKhop));
                Command.Parameters.Add(new MDB.MDBParameter("ViemTranDichThanhMac", BenhAnNgoaiTru_LupusBanDoHeThong.ViemTranDichThanhMac));
                Command.Parameters.Add(new MDB.MDBParameter("RoiLoanChucNangThan", BenhAnNgoaiTru_LupusBanDoHeThong.RoiLoanChucNangThan));
                Command.Parameters.Add(new MDB.MDBParameter("RoiLoanThanKinhTamThan", BenhAnNgoaiTru_LupusBanDoHeThong.RoiLoanThanKinhTamThan));
                Command.Parameters.Add(new MDB.MDBParameter("RoiLoanVeMau", BenhAnNgoaiTru_LupusBanDoHeThong.RoiLoanVeMau));
                Command.Parameters.Add(new MDB.MDBParameter("RoiLoanMienDich", BenhAnNgoaiTru_LupusBanDoHeThong.RoiLoanMienDich));
                Command.Parameters.Add(new MDB.MDBParameter("AnaDuongTinh", BenhAnNgoaiTru_LupusBanDoHeThong.AnaDuongTinh));
                Command.Parameters.Add(new MDB.MDBParameter("Tong11TieuChuan", BenhAnNgoaiTru_LupusBanDoHeThong.Tong11TieuChuan));
                Command.Parameters.Add(new MDB.MDBParameter("TieuChuanLamSang", BenhAnNgoaiTru_LupusBanDoHeThong.TieuChuanLamSang));
                Command.Parameters.Add(new MDB.MDBParameter("TieuChuanCanLamSang", BenhAnNgoaiTru_LupusBanDoHeThong.TieuChuanCanLamSang));
                Command.Parameters.Add(new MDB.MDBParameter("Tong17TieuChuan", BenhAnNgoaiTru_LupusBanDoHeThong.Tong17TieuChuan));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEDAI_1", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEDAI_1));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEDAI_2", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEDAI_2));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEDAI_3", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEDAI_3));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEDAI_4", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEDAI_4));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEDAI_5", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEDAI_5));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEDAI_6", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEDAI_6));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEDAI_7", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEDAI_7));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEDAI_8", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEDAI_8));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEDAI_9", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEDAI_9));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEDAI_10", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEDAI_10));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEDAI_11", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEDAI_11));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEDAI_12", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEDAI_12));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEDAI_13", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEDAI_13));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEDAI_14", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEDAI_14));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEDAI_15", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEDAI_15));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEDAI_16", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEDAI_16));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEDAI_17", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEDAI_17));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEDAI_18", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEDAI_18));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEDAI_19", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEDAI_19));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEDAI_20", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEDAI_20));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEDAI_21", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEDAI_21));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEDAI_22", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEDAI_22));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEDAI_23", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEDAI_23));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEDAI_24", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEDAI_24));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEDAI_TongDiem", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEDAI_TongDiem));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_1", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_1));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_2", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_2));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_3", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_3));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_4", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_4));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_5", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_5));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_6", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_6));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_7", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_7));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_8", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_8));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_9", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_9));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_10", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_10));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_11", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_11));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_12", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_12));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_13", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_13));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_14", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_14));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_15", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_15));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_16", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_16));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_17", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_17));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_18", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_18));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_19", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_19));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_20", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_20));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_21", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_21));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_22", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_22));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_23", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_23));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_24", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_24));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_25", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_25));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_26", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_26));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_27", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_27));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_28", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_28));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_29", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_29));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_30", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_30));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_31", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_31));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_32", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_32));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_33", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_33));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_34", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_34));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_35", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_35));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_36", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_36));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_37", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_37));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_38", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_38));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_39", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_39));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_40", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_40));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_1_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_1_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_2_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_2_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_3_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_3_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_4_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_4_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_5_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_5_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_6_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_6_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_7_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_7_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_8_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_8_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_9_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_9_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_10_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_10_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_11_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_11_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_12_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_12_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_13_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_13_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_14_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_14_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_15_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_15_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_16_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_16_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_17_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_17_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_18_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_18_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_19_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_19_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_20_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_20_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_21_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_21_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_22_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_22_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_23_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_23_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_24_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_24_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_25_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_25_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_26_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_26_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_27_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_27_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_28_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_28_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_29_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_29_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_30_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_30_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_31_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_31_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_32_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_32_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_33_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_33_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_34_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_34_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_35_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_35_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_36_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_36_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_37_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_37_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_38_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_38_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_39_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_39_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_40_Text", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_40_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiemSLEQOL_TongDiem", BenhAnNgoaiTru_LupusBanDoHeThong.DiemSLEQOL_TongDiem));
                Command.Parameters.Add(new MDB.MDBParameter("Corticosteroid", JsonConvert.SerializeObject(BenhAnNgoaiTru_LupusBanDoHeThong.Corticosteroid)));
                Command.Parameters.Add(new MDB.MDBParameter("KhangSotRet", JsonConvert.SerializeObject(BenhAnNgoaiTru_LupusBanDoHeThong.KhangSotRet)));
                Command.Parameters.Add(new MDB.MDBParameter("Cyclophosphamide", JsonConvert.SerializeObject(BenhAnNgoaiTru_LupusBanDoHeThong.Cyclophosphamide)));
                Command.Parameters.Add(new MDB.MDBParameter("CyclophosphamideLieuCao", JsonConvert.SerializeObject(BenhAnNgoaiTru_LupusBanDoHeThong.CyclophosphamideLieuCao)));
                Command.Parameters.Add(new MDB.MDBParameter("Azathioprine", JsonConvert.SerializeObject(BenhAnNgoaiTru_LupusBanDoHeThong.Azathioprine)));
                Command.Parameters.Add(new MDB.MDBParameter("Methotrexate", JsonConvert.SerializeObject(BenhAnNgoaiTru_LupusBanDoHeThong.Methotrexate)));
                Command.Parameters.Add(new MDB.MDBParameter("CyclosporineA", JsonConvert.SerializeObject(BenhAnNgoaiTru_LupusBanDoHeThong.CyclosporineA)));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocKhac", JsonConvert.SerializeObject(BenhAnNgoaiTru_LupusBanDoHeThong.ThuocKhac)));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriHienTai", BenhAnNgoaiTru_LupusBanDoHeThong.DieuTriHienTai));
                Command.Parameters.Add(new MDB.MDBParameter("HenKham", BenhAnNgoaiTru_LupusBanDoHeThong.HenKham));
                Command.Parameters.Add(new MDB.MDBParameter("BacSiDieuTri", BenhAnNgoaiTru_LupusBanDoHeThong.BacSiDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SoBenhAnDienTu", BenhAnNgoaiTru_LupusBanDoHeThong.TK_SoBenhAnDienTu));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SoLuuTru", BenhAnNgoaiTru_LupusBanDoHeThong.TK_SoLuuTru));
                Command.Parameters.Add(new MDB.MDBParameter("NgayKham", BenhAnNgoaiTru_LupusBanDoHeThong.NgayKham));
                Command.Parameters.Add(new MDB.MDBParameter("NgayLuuHuyetThanh", BenhAnNgoaiTru_LupusBanDoHeThong.NgayLuuHuyetThanh));
                Command.Parameters.Add(new MDB.MDBParameter("BacSiKham", BenhAnNgoaiTru_LupusBanDoHeThong.BacSiKham));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSiKham", BenhAnNgoaiTru_LupusBanDoHeThong.MaBacSiKham));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Sot", BenhAnNgoaiTru_LupusBanDoHeThong.TK_Sot));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HachTo", BenhAnNgoaiTru_LupusBanDoHeThong.TK_HachTo));
                Command.Parameters.Add(new MDB.MDBParameter("TK_MetMoi", BenhAnNgoaiTru_LupusBanDoHeThong.TK_MetMoi));
                Command.Parameters.Add(new MDB.MDBParameter("TK_LachTo", BenhAnNgoaiTru_LupusBanDoHeThong.TK_LachTo));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HA", BenhAnNgoaiTru_LupusBanDoHeThong.TK_HA));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TienSu_BenhThem", BenhAnNgoaiTru_LupusBanDoHeThong.TK_TienSu_BenhThem));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Da", BenhAnNgoaiTru_LupusBanDoHeThong.TK_Da));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Co", BenhAnNgoaiTru_LupusBanDoHeThong.TK_Co));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Khop", BenhAnNgoaiTru_LupusBanDoHeThong.TK_Khop));
                Command.Parameters.Add(new MDB.MDBParameter("TK_ThanKinh", BenhAnNgoaiTru_LupusBanDoHeThong.TK_ThanKinh));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TimMach", BenhAnNgoaiTru_LupusBanDoHeThong.TK_TimMach));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HoHap", BenhAnNgoaiTru_LupusBanDoHeThong.TK_HoHap));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TieuHoa", BenhAnNgoaiTru_LupusBanDoHeThong.TK_TieuHoa));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TrieuChungKhac", BenhAnNgoaiTru_LupusBanDoHeThong.TK_TrieuChungKhac));
                Command.Parameters.Add(new MDB.MDBParameter("TK_CongThucMau_BachCau", BenhAnNgoaiTru_LupusBanDoHeThong.TK_CongThucMau_BachCau));
                Command.Parameters.Add(new MDB.MDBParameter("TK_CongThucMau_Lympho", BenhAnNgoaiTru_LupusBanDoHeThong.TK_CongThucMau_Lympho));
                Command.Parameters.Add(new MDB.MDBParameter("TK_CongThucMau_Hc", BenhAnNgoaiTru_LupusBanDoHeThong.TK_CongThucMau_Hc));
                Command.Parameters.Add(new MDB.MDBParameter("TK_CongThucMau_Hb", BenhAnNgoaiTru_LupusBanDoHeThong.TK_CongThucMau_Hb));
                Command.Parameters.Add(new MDB.MDBParameter("TK_CongThucMau_TieuCau", BenhAnNgoaiTru_LupusBanDoHeThong.TK_CongThucMau_TieuCau));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TestCoombTrucTiep", BenhAnNgoaiTru_LupusBanDoHeThong.TK_TestCoombTrucTiep));
                Command.Parameters.Add(new MDB.MDBParameter("TK_MauLang_1h", BenhAnNgoaiTru_LupusBanDoHeThong.TK_MauLang_1h));
                Command.Parameters.Add(new MDB.MDBParameter("TK_MauLang_2h", BenhAnNgoaiTru_LupusBanDoHeThong.TK_MauLang_2h));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_Creatinin", BenhAnNgoaiTru_LupusBanDoHeThong.TK_SinhHoa_Creatinin));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_Ure", BenhAnNgoaiTru_LupusBanDoHeThong.TK_SinhHoa_Ure));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_ProteinToanPhan", BenhAnNgoaiTru_LupusBanDoHeThong.TK_SinhHoa_ProteinToanPhan));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_Alb", BenhAnNgoaiTru_LupusBanDoHeThong.TK_SinhHoa_Alb));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_Cholesterol", BenhAnNgoaiTru_LupusBanDoHeThong.TK_SinhHoa_Cholesterol));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_Tri", BenhAnNgoaiTru_LupusBanDoHeThong.TK_SinhHoa_Tri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_GOT", BenhAnNgoaiTru_LupusBanDoHeThong.TK_SinhHoa_GOT));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_GPT", BenhAnNgoaiTru_LupusBanDoHeThong.TK_SinhHoa_GPT));
                Command.Parameters.Add(new MDB.MDBParameter("TK_NuocTieu_ProteinNieu", BenhAnNgoaiTru_LupusBanDoHeThong.TK_NuocTieu_ProteinNieu));
                Command.Parameters.Add(new MDB.MDBParameter("TK_NuocTieu_TruNieu", BenhAnNgoaiTru_LupusBanDoHeThong.TK_NuocTieu_TruNieu));
                Command.Parameters.Add(new MDB.MDBParameter("TK_NuocTieu_HCNieu", BenhAnNgoaiTru_LupusBanDoHeThong.TK_NuocTieu_HCNieu));
                Command.Parameters.Add(new MDB.MDBParameter("TK_NuocTieu_BCNieu", BenhAnNgoaiTru_LupusBanDoHeThong.TK_NuocTieu_BCNieu));
                Command.Parameters.Add(new MDB.MDBParameter("TK_NuocTieu_ProteinNieu24h", BenhAnNgoaiTru_LupusBanDoHeThong.TK_NuocTieu_ProteinNieu24h));
                Command.Parameters.Add(new MDB.MDBParameter("TK_YeuToDangThap_Text", BenhAnNgoaiTru_LupusBanDoHeThong.TK_YeuToDangThap_Text));
                Command.Parameters.Add(new MDB.MDBParameter("TK_YeuToDangThap_Khong", BenhAnNgoaiTru_LupusBanDoHeThong.TK_YeuToDangThap_Khong));
                Command.Parameters.Add(new MDB.MDBParameter("XuatHienTuKhangThe", BenhAnNgoaiTru_LupusBanDoHeThong.XuatHienTuKhangThe));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhamMat", BenhAnNgoaiTru_LupusBanDoHeThong.TK_KhamMat));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhamMat_KetQua", BenhAnNgoaiTru_LupusBanDoHeThong.TK_KhamMat_KetQua));
                Command.Parameters.Add(new MDB.MDBParameter("TK_XetNghiemKhac", BenhAnNgoaiTru_LupusBanDoHeThong.TK_XetNghiemKhac));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DiemSLEQOL_TongDiem", BenhAnNgoaiTru_LupusBanDoHeThong.TK_DiemSLEQOL_TongDiem));
                Command.Parameters.Add(new MDB.MDBParameter("TK_ChuY", BenhAnNgoaiTru_LupusBanDoHeThong.TK_ChuY));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DieuTri", BenhAnNgoaiTru_LupusBanDoHeThong.TK_DieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HenKham", BenhAnNgoaiTru_LupusBanDoHeThong.TK_HenKham));
                Command.Parameters.Add(new MDB.MDBParameter("TK_BacSiDieuTri", BenhAnNgoaiTru_LupusBanDoHeThong.TK_BacSiDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_MaBacSiDieuTri", BenhAnNgoaiTru_LupusBanDoHeThong.TK_MaBacSiDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnNgoaiTru_LupusBanDoHeThong.QuaTrinhBenhLy));
                Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQua", BenhAnNgoaiTru_LupusBanDoHeThong.TomTatKetQua));
                Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnNgoaiTru_LupusBanDoHeThong.BenhChinh));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhChinh", BenhAnNgoaiTru_LupusBanDoHeThong.MaBenhChinh));
                Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnNgoaiTru_LupusBanDoHeThong.BenhKemTheo));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhKemTheo", BenhAnNgoaiTru_LupusBanDoHeThong.MaBenhKemTheo));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnNgoaiTru_LupusBanDoHeThong.PhuongPhapDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangRaVien", BenhAnNgoaiTru_LupusBanDoHeThong.TinhTrangRaVien));
                Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnNgoaiTru_LupusBanDoHeThong.HuongDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnNgoaiTru_LupusBanDoHeThong.NguoiNhanHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnNgoaiTru_LupusBanDoHeThong.NguoiGiaoHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnNgoaiTru_LupusBanDoHeThong.NgayTongKet));
                Command.Parameters.Add(new MDB.MDBParameter("TongKet_BacSyDieuTri", BenhAnNgoaiTru_LupusBanDoHeThong.TongKet_BacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TongKet_MaBacSyDieuTri", BenhAnNgoaiTru_LupusBanDoHeThong.TongKet_MaBacSyDieuTri));

                Command.BindByName = true;

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnNgoaiTru_LupusBanDoHeThong.MaQuanLy));
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
