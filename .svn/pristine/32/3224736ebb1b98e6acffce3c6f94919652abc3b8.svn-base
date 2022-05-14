using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMR_MAIN.DATABASE.BenhAn;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.BenhAnFunc
{
    public class BenhAnNgoaiTru_ViemBiCoFunc
    {
        public static void WriteXml(MDB.MDBConnection MyConnection)
        {
            string sql =
                   @"
                  select  a.*,  CTScanner HoSo_CTScanner, SieuAm HoSo_SieuAm, XetNghiem HoSo_XetNghiem,  Khac HoSo_Khac,  Khac_Text HoSo_Khac_Text,  ToanBoHoSo HoSo_ToanBoHoSo, Mach DauSinhTon_Mach,  NhietDo DauSinhTon_NhietDo,  HuyetAp DauSinhTon_HuyetAp,  NhipTho DauSinhTon_NhipTho,  CanNang DauSinhTon_CanNang  
                  from BenhAnViemBiCo a inner join thongtindieutri b on a.maquanly = b.maquanly
                  where rownum = 1
                    ";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            var DataTable = new DataTable { TableName = "BenhAnViemBiCo" };
            DataTable.Load(DataReader as IDataReader);
            DataTable.WriteXml("rptBenhAnViemBiCo.xml");
        }
        public static DataSet SelectDataSet(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql =
                   @"
                  select  a.*, f.hovaten BacSyDieuTriHoVaTen, g.hovaten TK_BacSyDieuTriHoVaTen, d.hovaten NguoiGiaoHoSoHoVaTen,e.hovaten NguoiNhanHoSoHoVaTen, b.XQuang HoSo_XQuang, b.CTScanner HoSo_CTScanner, b.SieuAm HoSo_SieuAm, b.XetNghiem HoSo_XetNghiem,  b.Khac HoSo_Khac,  b.Khac_Text HoSo_Khac_Text,  b.ToanBoHoSo HoSo_ToanBoHoSo
                        from BenhAnViemBiCo a  
                  left join thongtindieutri b on a.maquanly = b.maquanly 
                  left join nhanvien f on a.BacSyDieuTri = f.manhanvien
                  left join nhanvien g on a.TK_MaBacSiDieuTri = g.manhanvien
                  left join nhanvien d on a.NguoiGiaoHoSo = d.manhanvien
                  left join nhanvien e on a.NguoiNhanHoSo = e.manhanvien where a.maquanly = " + MaQuanLy.ToString(System.Globalization.CultureInfo.InvariantCulture);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(sql, MyConnection);
            var ds = new DataSet();
            adt.Fill(ds, "Table");
            List<TrieuChungCo> CoGapCanhTay = new List<TrieuChungCo>();
            List<TrieuChungCo> CoDuoiCanhTay = new List<TrieuChungCo>();
            List<TrieuChungCo> CoGapDui = new List<TrieuChungCo>();
            List<TrieuChungCo> CoDuoiDui = new List<TrieuChungCo>();
            List<TrieuChungCo> TK_CoGapCanhTay = new List<TrieuChungCo>();
            List<TrieuChungCo> TK_CoDuoiCanhTay = new List<TrieuChungCo>();
            List<TrieuChungCo> TK_CoGapDui = new List<TrieuChungCo>();
            List<TrieuChungCo> TK_CoDuoiDui = new List<TrieuChungCo>();
            List<TienSuDieuTri> TS_Corticosteroid = new List<TienSuDieuTri>();
            List<TienSuDieuTri>TS_CyclophosphamidLieuCao = new List<TienSuDieuTri>();
            List<TienSuDieuTri>TS_Azathioprine = new List<TienSuDieuTri>();
            List<TienSuDieuTri>TS_Methotrexate = new List<TienSuDieuTri>();
            List<TienSuDieuTri>TS_CyclosporineA = new List<TienSuDieuTri>();

            CoGapCanhTay.Add(JsonConvert.DeserializeObject<TrieuChungCo>(ds.Tables["Table"].Rows[0]["CoGapCanhTay"].ToString()));
            CoDuoiCanhTay.Add(JsonConvert.DeserializeObject<TrieuChungCo>(ds.Tables["Table"].Rows[0]["CoDuoiCanhTay"].ToString()));
            CoGapDui.Add(JsonConvert.DeserializeObject<TrieuChungCo>(ds.Tables["Table"].Rows[0]["CoGapDui"].ToString()));
            CoDuoiDui.Add(JsonConvert.DeserializeObject<TrieuChungCo>(ds.Tables["Table"].Rows[0]["CoDuoiDui"].ToString()));
            TK_CoGapCanhTay.Add(JsonConvert.DeserializeObject<TrieuChungCo>(ds.Tables["Table"].Rows[0]["TK_CoGapCanhTay"].ToString()));
            TK_CoDuoiCanhTay.Add(JsonConvert.DeserializeObject<TrieuChungCo>(ds.Tables["Table"].Rows[0]["TK_CoDuoiCanhTay"].ToString()));
            TK_CoGapDui.Add(JsonConvert.DeserializeObject<TrieuChungCo>(ds.Tables["Table"].Rows[0]["TK_CoGapDui"].ToString()));
            TK_CoDuoiDui.Add(JsonConvert.DeserializeObject<TrieuChungCo>(ds.Tables["Table"].Rows[0]["TK_CoDuoiDui"].ToString()));
            TS_Corticosteroid.Add(JsonConvert.DeserializeObject<TienSuDieuTri>(ds.Tables["Table"].Rows[0]["TS_Corticosteroid"].ToString()));
            TS_CyclophosphamidLieuCao.Add(JsonConvert.DeserializeObject<TienSuDieuTri>(ds.Tables["Table"].Rows[0]["TS_CyclophosphamidLieuCao"].ToString()));
            TS_Azathioprine.Add(JsonConvert.DeserializeObject<TienSuDieuTri>(ds.Tables["Table"].Rows[0]["TS_Azathioprine"].ToString()));
            TS_Methotrexate.Add(JsonConvert.DeserializeObject<TienSuDieuTri>(ds.Tables["Table"].Rows[0]["TS_Methotrexate"].ToString()));
            TS_CyclosporineA.Add(JsonConvert.DeserializeObject<TienSuDieuTri>(ds.Tables["Table"].Rows[0]["TS_CyclosporineA"].ToString()));

            ds.Tables.Add(Common.ListToDataTable(CoGapCanhTay, "CoGapCanhTay"));
            ds.Tables.Add(Common.ListToDataTable(CoDuoiCanhTay, "CoDuoiCanhTay"));
            ds.Tables.Add(Common.ListToDataTable(CoGapDui, "CoGapDui"));
            ds.Tables.Add(Common.ListToDataTable(CoDuoiDui, "CoDuoiDui"));
            ds.Tables.Add(Common.ListToDataTable(TK_CoGapCanhTay, "TK_CoGapCanhTay"));
            ds.Tables.Add(Common.ListToDataTable(TK_CoDuoiCanhTay, "TK_CoDuoiCanhTay"));
            ds.Tables.Add(Common.ListToDataTable(TK_CoGapDui, "TK_CoGapDui"));
            ds.Tables.Add(Common.ListToDataTable(TK_CoDuoiDui, "TK_CoDuoiDui"));
            ds.Tables.Add(Common.ListToDataTable(TS_Corticosteroid, "TS_Corticosteroid"));
            ds.Tables.Add(Common.ListToDataTable(TS_CyclophosphamidLieuCao, "TS_CyclophosphamidLieuCao"));
            ds.Tables.Add(Common.ListToDataTable(TS_Azathioprine, "TS_Azathioprine"));
            ds.Tables.Add(Common.ListToDataTable(TS_Methotrexate, "TS_Methotrexate"));
            ds.Tables.Add(Common.ListToDataTable(TS_CyclosporineA, "TS_CyclosporineA"));

            return ds;

        }
        public static BenhAnNgoaiTru_ViemBiCo Select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            var obj = new BenhAnNgoaiTru_ViemBiCo();
            try
            {
                #region
                string sql =
                          @"select * 
                        from BenhAnViemBiCo 
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
                    obj.GaySut_Kg = DataReader["GaySut_Kg"].ToString();
                    obj.GaySut_Thang = DataReader["GaySut_Thang"].ToString();
                    obj.GaySut_PhanTram = DataReader["GaySut_PhanTram"].ToString();
                    obj.Cao = DataReader["Cao"].ToString();
                    obj.TuoiKhoiPhat = DataReader["TuoiKhoiPhat"].ToString();
                    obj.TGTKKPB = DataReader["TGTKKPB"].ToString();
                    obj.TrieuChungDauTien = DataReader["TrieuChungDauTien"].ToString();
                    obj.LupusBanDo = DataReader.GetInt("LupusBanDo");
                    obj.XoCungBi = DataReader.GetInt("XoCungBi");
                    obj.ViemKhopDangThap = DataReader.GetInt("ViemKhopDangThap");
                    obj.HoiChungSjogren = DataReader.GetInt("HoiChungSjogren");
                    obj.ViemBiCo = DataReader.GetInt("ViemBiCo");
                    obj.TienSuBenhTuMien_Khac = DataReader["TienSuBenhTuMien_Khac"].ToString();
                    obj.TSCNBCBK_Text = DataReader["TSCNBCBK_Text"].ToString();
                    obj.TSCNBCBK = DataReader.GetInt("TSCNBCBK");
                    obj.TSGDCNBBTM = DataReader.GetInt("TSGDCNBBTM");
                    obj.TSGDCNBBTM_NeuCo = DataReader["TSGDCNBBTM_NeuCo"].ToString();
                    obj.BenhSu = DataReader["BenhSu"].ToString();
                    obj.ChuaDieuTri = DataReader.GetInt("ChuaDieuTri");
                    obj.Dpenicillamine = DataReader.GetInt("Dpenicillamine");
                    obj.Dpenicillamine_CachDung = DataReader["Dpenicillamine_CachDung"].ToString();
                    obj.Corticosteroid = DataReader.GetInt("Corticosteroid");
                    obj.Corticosteroid_CachDung = DataReader["Corticosteroid_CachDung"].ToString();
                    obj.Cyclophosphamide = DataReader.GetInt("Cyclophosphamide");
                    obj.Cyclophosphamide_CachDung = DataReader["Cyclophosphamide_CachDung"].ToString();
                    obj.Azathioprine = DataReader.GetInt("Azathioprine");
                    obj.Azathioprine_CachDung = DataReader["Azathioprine_CachDung"].ToString();
                    obj.Methotrexate = DataReader.GetInt("Methotrexate");
                    obj.Methotrexate_CachDung = DataReader["Methotrexate_CachDung"].ToString();
                    obj.ThuocKha = DataReader.GetInt("ThuocKha");
                    obj.ThuocKhac_CachDung = DataReader["ThuocKhac_CachDung"].ToString();
                    obj.TacDungPhuThuoc = DataReader.GetInt("TacDungPhuThuoc");
                    obj.TacDungPhuThuoc_Co = DataReader["TacDungPhuThuoc_Co"].ToString();
                    obj.Sot = DataReader.GetInt("Sot");
                    obj.Sot_Do = DataReader["Sot_Do"].ToString();
                    obj.MetMoi = DataReader.GetInt("MetMoi");
                    obj.Mach = DataReader["Mach"].ToString();
                    obj.HuyetAp = DataReader["HuyetAp"].ToString();
                    obj.HachTo = DataReader.GetInt("HachTo");
                    obj.HachTo_ViTri = DataReader["HachTo_ViTri"].ToString();
                    obj.DatDo = DataReader.GetInt("DatDo");
                    obj.DatDo_ViTri = DataReader["DatDo_ViTri"].ToString();
                    obj.MauSac_ViTri = DataReader["MauSac_ViTri"].ToString();
                    obj.RuouVang = DataReader.GetInt("RuouVang");
                    obj.DoTuoi = DataReader.GetInt("DoTuoi");
                    obj.DoTham = DataReader.GetInt("DoTham");
                    obj.MatPhuNe = DataReader.GetInt("MatPhuNe");
                    obj.BanHeliotrope = DataReader.GetInt("BanHeliotrope");
                    obj.VSign = DataReader.GetInt("VSign");
                    obj.HoslterSign = DataReader.GetInt("HoslterSign");
                    obj.ShawlSign = DataReader.GetInt("ShawlSign");
                    obj.LangDongCanxiODa = DataReader.GetInt("LangDongCanxiODa");
                    obj.GottronSign_BanTay = DataReader.GetInt("GottronSign_BanTay");
                    obj.GottronSign_KhuyuTay = DataReader.GetInt("GottronSign_KhuyuTay");
                    obj.GottronSign_DauGoi = DataReader.GetInt("GottronSign_DauGoi");
                    obj.GottronPapules_BanTay = DataReader.GetInt("GottronPapules_BanTay");
                    obj.GottronPapules_KhuyuTay = DataReader.GetInt("GottronPapules_KhuyuTay");
                    obj.GottronPapules_DauGoi = DataReader.GetInt("GottronPapules_DauGoi");
                    obj.GianMachQuanhMong = DataReader.GetInt("GianMachQuanhMong");
                    obj.XuatHuyetQuanhMong = DataReader.GetInt("XuatHuyetQuanhMong");
                    obj.NutNeQuanhMong = DataReader.GetInt("NutNeQuanhMong");
                    obj.MichanicHand = DataReader.GetInt("MichanicHand");
                    obj.RamLongTrenNenDatDo = DataReader.GetInt("RamLongTrenNenDatDo");
                    obj.RamLongTrenNenDatDo_ViTri = DataReader["RamLongTrenNenDatDo_ViTri"].ToString();
                    obj.HienTuongRaynaud = DataReader.GetInt("HienTuongRaynaud");
                    obj.DauHieuPoikiloderma = DataReader.GetInt("DauHieuPoikiloderma");
                    obj.DauHieuPoikiloderma_ViTri = DataReader["DauHieuPoikiloderma_ViTri"].ToString();
                    obj.VetLoetTrenDa = DataReader.GetInt("VetLoetTrenDa");
                    obj.VetLoetTrenDa_ViTri = DataReader["VetLoetTrenDa_ViTri"].ToString();
                    obj.LamSangDa_Khac = DataReader["LamSangDa_Khac"].ToString();
                    obj.DauCo = DataReader.GetInt("DauCo");
                    obj.DauCo_Diem = DataReader["DauCo_Diem"].ToString();
                    obj.DauCo_ViTri = DataReader["DauCo_ViTri"].ToString();
                    obj.BopCo = DataReader.GetInt("BopCo");
                    obj.BopCo_ViTri = DataReader["BopCo_ViTri"].ToString();
                    obj.YeuCo = DataReader.GetInt("YeuCo");
                    obj.TeoCo = DataReader.GetInt("TeoCo");
                    obj.CoGapCanhTay = JsonConvert.DeserializeObject<TrieuChungCo>(DataReader["CoGapCanhTay"].ToString());
                    obj.CoDuoiCanhTay = JsonConvert.DeserializeObject<TrieuChungCo>(DataReader["CoDuoiCanhTay"].ToString());
                    obj.CoGapDui = JsonConvert.DeserializeObject<TrieuChungCo>(DataReader["CoGapDui"].ToString());
                    obj.CoDuoiDui = JsonConvert.DeserializeObject<TrieuChungCo>(DataReader["CoDuoiDui"].ToString());
                    obj.DauKhop = DataReader.GetInt("DauKhop");
                    obj.DauKhop_SoLuong = DataReader["DauKhop_SoLuong"].ToString();
                    obj.DauKhop_ViTri = DataReader["DauKhop_ViTri"].ToString();
                    obj.SungKhop = DataReader.GetInt("SungKhop");
                    obj.SungKhop_SoLuong = DataReader["SungKhop_SoLuong"].ToString();
                    obj.SungKhop_ViTri = DataReader["SungKhop_ViTri"].ToString();
                    obj.BienDangKhop = DataReader.GetInt("BienDangKhop");
                    obj.BienDangKhop_SoLuong = DataReader["BienDangKhop_SoLuong"].ToString();
                    obj.BienDangKhop_ViTri = DataReader["BienDangKhop_ViTri"].ToString();
                    obj.KhoThoKhiGangSuc = DataReader["KhoThoKhiGangSuc"].ToString();
                    obj.KhoThoKhiNghiNgoi = DataReader.GetInt("KhoThoKhiNghiNgoi");
                    obj.HoKhanKeoDai = DataReader.GetInt("HoKhanKeoDai");
                    obj.RanPhoiDoiXung = DataReader.GetInt("RanPhoiDoiXung");
                    obj.Phoi_Khac = DataReader["Phoi_Khac"].ToString();
                    obj.DanhTrongNguc = DataReader.GetInt("DanhTrongNguc");
                    obj.NhipTim = DataReader.GetInt("NhipTim");
                    obj.NhipTim_Khac = DataReader["NhipTim_Khac"].ToString();
                    obj.DauHieuSuyTim = DataReader.GetInt("DauHieuSuyTim");
                    obj.DauHieuSuyTim_Co = DataReader["DauHieuSuyTim_Co"].ToString();
                    obj.Tim_Khac = DataReader["Tim_Khac"].ToString();
                    obj.NuotKhoNghenThucAnRan = DataReader.GetInt("NuotKhoNghenThucAnRan");
                    obj.NuotKhoThucAnLongNuoc = DataReader.GetInt("NuotKhoThucAnLongNuoc");
                    obj.ONong = DataReader.GetInt("ONong");
                    obj.ONongDauNguc = DataReader.GetInt("ONongDauNguc");
                    obj.DangChuaMieng = DataReader.GetInt("DangChuaMieng");
                    obj.NoiKhanDauViemHong = DataReader.GetInt("NoiKhanDauViemHong");
                    obj.HoKhiAn = DataReader.GetInt("HoKhiAn");
                    obj.TaoBon = DataReader.GetInt("TaoBon");
                    obj.TaoLongXenKe = DataReader.GetInt("TaoLongXenKe");
                    obj.DuongTieuHoa_Khac = DataReader["DuongTieuHoa_Khac"].ToString();
                    obj.Phu = DataReader.GetInt("Phu");
                    obj.TieuIt = DataReader.GetInt("TieuIt");
                    obj.TieuMau = DataReader.GetInt("TieuMau");
                    obj.ThanTietNieu_Khac = DataReader["ThanTietNieu_Khac"].ToString();
                    obj.CongThucMau_Bc = DataReader["CongThucMau_Bc"].ToString();
                    obj.CongThucMau_Tt = DataReader["CongThucMau_Tt"].ToString();
                    obj.CongThucMau_Lym = DataReader["CongThucMau_Lym"].ToString();
                    obj.CongThucMau_At = DataReader["CongThucMau_At"].ToString();
                    obj.CongThucMau_Hc = DataReader["CongThucMau_Hc"].ToString();
                    obj.CongThucMau_Hct = DataReader["CongThucMau_Hct"].ToString();
                    obj.CongThucMau_Hb = DataReader["CongThucMau_Hb"].ToString();
                    obj.CongThucMau_Tc = DataReader["CongThucMau_Tc"].ToString();
                    obj.MauLang_1h = DataReader["MauLang_1h"].ToString();
                    obj.MauLang_2h = DataReader["MauLang_2h"].ToString();
                    obj.SinhHoa_Ure = DataReader["SinhHoa_Ure"].ToString();
                    obj.SinhHoa_Choles = DataReader["SinhHoa_Choles"].ToString();
                    obj.SinhHoa_Na = DataReader["SinhHoa_Na"].ToString();
                    obj.SinhHoa_Creatinin = DataReader["SinhHoa_Creatinin"].ToString();
                    obj.SinhHoa_Trigly = DataReader["SinhHoa_Trigly"].ToString();
                    obj.SinhHoa_K = DataReader["SinhHoa_K"].ToString();
                    obj.SinhHoa_Glucose = DataReader["SinhHoa_Glucose"].ToString();
                    obj.SinhHoa_Ldl = DataReader["SinhHoa_Ldl"].ToString();
                    obj.SinhHoa_Cl = DataReader["SinhHoa_Cl"].ToString();
                    obj.SinhHoa_Uric = DataReader["SinhHoa_Uric"].ToString();
                    obj.SinhHoa_Hdl = DataReader["SinhHoa_Hdl"].ToString();
                    obj.SinhHoa_Ast = DataReader["SinhHoa_Ast"].ToString();
                    obj.SinhHoa_BiltP = DataReader["SinhHoa_BiltP"].ToString();
                    obj.SinhHoa_Pro = DataReader["SinhHoa_Pro"].ToString();
                    obj.SinhHoa_ALT = DataReader["SinhHoa_ALT"].ToString();
                    obj.SinhHoa_BiltT = DataReader["SinhHoa_BiltT"].ToString();
                    obj.SinhHoa_Alb = DataReader["SinhHoa_Alb"].ToString();
                    obj.SinhHoa_Ck = DataReader["SinhHoa_Ck"].ToString();
                    obj.SinhHoa_CrpHs = DataReader["SinhHoa_CrpHs"].ToString();
                    obj.SinhHoa_CkMb = DataReader["SinhHoa_CkMb"].ToString();
                    obj.SinhHoa_Khac = DataReader["SinhHoa_Khac"].ToString();
                    obj.NuocTieu_Protein = DataReader.GetInt("NuocTieu_Protein");
                    obj.NuocTieu_ProteinNieu24h = DataReader["NuocTieu_ProteinNieu24h"].ToString();
                    obj.NuocTieu_Hc = DataReader.GetInt("NuocTieu_Hc");
                    obj.NuocTieu_Bc = DataReader.GetInt("NuocTieu_Bc");
                    obj.NuocTieu_Khac = DataReader["NuocTieu_Khac"].ToString();
                    obj.CNHH_FVC = DataReader["CNHH_FVC"].ToString();
                    obj.CNHH_FEV1 = DataReader["CNHH_FEV1"].ToString();
                    obj.CNHH_DuDoanFVC = DataReader["CNHH_DuDoanFVC"].ToString();
                    obj.CNHH_FEV1FVC = DataReader["CNHH_FEV1FVC"].ToString();
                    obj.CNHH_DlCo = DataReader["CNHH_DlCo"].ToString();
                    obj.CNHH_DuDoanDlCo = DataReader["CNHH_DuDoanDlCo"].ToString();
                    obj.XqTp = DataReader["XqTp"].ToString();
                    obj.HrCt = DataReader["HrCt"].ToString();
                    obj.SaOBung = DataReader["SaOBung"].ToString();
                    obj.DienTim_TanSo = DataReader["DienTim_TanSo"].ToString();
                    obj.DienTim_Nhip = DataReader["DienTim_Nhip"].ToString();
                    obj.DienTim_Truc = DataReader["DienTim_Truc"].ToString();
                    obj.DiemTim_Khac = DataReader["DiemTim_Khac"].ToString();
                    obj.SaTimEF = DataReader["SaTimEF"].ToString();
                    obj.SaTimPdmp = DataReader["SaTimPdmp"].ToString();
                    obj.SaTim_Khac = DataReader["SaTim_Khac"].ToString();
                    obj.KhangThe_Ana = DataReader.GetInt("KhangThe_Ana");
                    obj.KhangThe_Ana_Duong = DataReader["KhangThe_Ana_Duong"].ToString();
                    obj.KhangThe_Ana_Am = DataReader["KhangThe_Ana_Am"].ToString();
                    obj.KhangThe_Anti155140 = DataReader.GetInt("KhangThe_Anti155140");
                    obj.KhangThe_Anti155140_Duong = DataReader["KhangThe_Anti155140_Duong"].ToString();
                    obj.KhangThe_Anti155140_Am = DataReader["KhangThe_Anti155140_Am"].ToString();
                    obj.KhangThe_AntiPMScl = DataReader.GetInt("KhangThe_AntiPMScl");
                    obj.KhangThe_AntiPMScl_Duong = DataReader["KhangThe_AntiPMScl_Duong"].ToString();
                    obj.KhangThe_AntiPMScl_Am = DataReader["KhangThe_AntiPMScl_Am"].ToString();
                    obj.KhangThe_AntiARS = DataReader.GetInt("KhangThe_AntiARS");
                    obj.KhangThe_AntiARS_Duong = DataReader["KhangThe_AntiARS_Duong"].ToString();
                    obj.KhangThe_AntiARS_Am = DataReader["KhangThe_AntiARS_Am"].ToString();
                    obj.KhangThe_AntiCadm = DataReader.GetInt("KhangThe_AntiCadm");
                    obj.KhangThe_AntiCadm_Duong = DataReader["KhangThe_AntiCadm_Duong"].ToString();
                    obj.KhangThe_AntiCadm_Am = DataReader["KhangThe_AntiCadm_Am"].ToString();
                    obj.KhangThe_Ku = DataReader.GetInt("KhangThe_Ku");
                    obj.KhangThe_Ku_Duong = DataReader["KhangThe_Ku_Duong"].ToString();
                    obj.KhangThe_Ku_Am = DataReader["KhangThe_Ku_Am"].ToString();
                    obj.KhangThe_dsDNA = DataReader.GetInt("KhangThe_dsDNA");
                    obj.KhangThe_dsDNA_Duong = DataReader["KhangThe_dsDNA_Duong"].ToString();
                    obj.KhangThe_dsDNA_Am = DataReader["KhangThe_dsDNA_Am"].ToString();
                    obj.KhangThe_AntiU1RNP = DataReader.GetInt("KhangThe_AntiU1RNP");
                    obj.KhangThe_AntiU1RNP_Duong = DataReader["KhangThe_AntiU1RNP_Duong"].ToString();
                    obj.KhangThe_AntiU1RNP_Am = DataReader["KhangThe_AntiU1RNP_Am"].ToString();
                    obj.KhangThe_TIF1 = DataReader.GetInt("KhangThe_TIF1");
                    obj.KhangThe_TIF1_Duong = DataReader["KhangThe_TIF1_Duong"].ToString();
                    obj.KhangThe_TIF1_Am = DataReader["KhangThe_TIF1_Am"].ToString();
                    obj.KhangThe_AntiJ01 = DataReader.GetInt("KhangThe_AntiJ01");
                    obj.KhangThe_AntiJ01_Duong = DataReader["KhangThe_AntiJ01_Duong"].ToString();
                    obj.KhangThe_AntiJ01_Am = DataReader["KhangThe_AntiJ01_Am"].ToString();
                    obj.KhangThe_AntiSRP = DataReader.GetInt("KhangThe_AntiSRP");
                    obj.KhangThe_AntiSRP_Duong = DataReader["KhangThe_AntiSRP_Duong"].ToString();
                    obj.KhangThe_AntiSRP_Am = DataReader["KhangThe_AntiSRP_Am"].ToString();
                    obj.KhangThe_antiNXP2 = DataReader.GetInt("KhangThe_antiNXP2");
                    obj.KhangThe_antiNXP2_Duong = DataReader["KhangThe_antiNXP2_Duong"].ToString();
                    obj.KhangThe_antiNXP2_Am = DataReader["KhangThe_antiNXP2_Am"].ToString();
                    obj.KhangThe_AntiMi2 = DataReader.GetInt("KhangThe_AntiMi2");
                    obj.KhangThe_AntiMi2_Duong = DataReader["KhangThe_AntiMi2_Duong"].ToString();
                    obj.KhangThe_AntiMi2_Am = DataReader["KhangThe_AntiMi2_Am"].ToString();
                    obj.KhangThe_AntiMDA5 = DataReader.GetInt("KhangThe_AntiMDA5");
                    obj.KhangThe_AntiMDA5_Duong = DataReader["KhangThe_AntiMDA5_Duong"].ToString();
                    obj.KhangThe_AntiMDA5_Am = DataReader["KhangThe_AntiMDA5_Am"].ToString();
                    obj.KhangThe_antiSAE = DataReader.GetInt("KhangThe_antiSAE");
                    obj.KhangThe_antiSAE_Duong = DataReader["KhangThe_antiSAE_Duong"].ToString();
                    obj.KhangThe_antiSAE_Am = DataReader["KhangThe_antiSAE_Am"].ToString();
                    obj.KhangThe_Khac = DataReader["KhangThe_Khac"].ToString();
                    obj.KhamMat = DataReader["KhamMat"].ToString();
                    obj.DienCoKim = DataReader["DienCoKim"].ToString();
                    obj.SinhThietCo = DataReader["SinhThietCo"].ToString();
                    obj.BohanPeter = DataReader["BohanPeter"].ToString();
                    obj.Tanimoto = DataReader["Tanimoto"].ToString();
                    obj.MotSoThe = DataReader["MotSoThe"].ToString();
                    obj.MotSoThe_Khac = DataReader["MotSoThe_Khac"].ToString();
                    obj.TS_Corticosteroid = JsonConvert.DeserializeObject<TienSuDieuTri>(DataReader["TS_Corticosteroid"].ToString());
                    obj.TS_Cyclophosphamid = JsonConvert.DeserializeObject<TienSuDieuTri>(DataReader["TS_Cyclophosphamid"].ToString());
                    obj.TS_CyclophosphamidLieuCao = JsonConvert.DeserializeObject<TienSuDieuTri>(DataReader["TS_CyclophosphamidLieuCao"].ToString());
                    obj.TS_Azathioprine = JsonConvert.DeserializeObject<TienSuDieuTri>(DataReader["TS_Azathioprine"].ToString());
                    obj.TS_Methotrexate = JsonConvert.DeserializeObject<TienSuDieuTri>(DataReader["TS_Methotrexate"].ToString());
                    obj.TS_CyclosporineA = JsonConvert.DeserializeObject<TienSuDieuTri>(DataReader["TS_CyclosporineA"].ToString());
                    obj.ThuocKhac = DataReader["ThuocKhac"].ToString();
                    obj.DieuTriHienTai = DataReader["DieuTriHienTai"].ToString();
                    obj.HenKham = DataReader["HenKham"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["HenKham"]) : null;
                    obj.BacSyDieuTri = DataReader["BacSyDieuTri"].ToString();
                    obj.MaBacSyDieuTri = DataReader["MaBacSyDieuTri"].ToString();
                    obj.TK_SoBenhAnDienTu = DataReader["TK_SoBenhAnDienTu"].ToString();
                    obj.TK_SoLuuTru = DataReader["TK_SoLuuTru"].ToString();
                    obj.NgayKham = DataReader["NgayKham"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayKham"]) : null;
                    obj.NgayLuuHuyetThanh = DataReader["NgayLuuHuyetThanh"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayLuuHuyetThanh"]) : null;
                    obj.BacSiKham = DataReader["BacSiKham"].ToString();
                    obj.MaBacSiKham = DataReader["MaBacSiKham"].ToString();
                    obj.TK_Sot = DataReader.GetInt("TK_Sot");
                    obj.TK_Sot_Do = DataReader["TK_Sot_Do"].ToString();
                    obj.TK_MetMoi = DataReader.GetInt("TK_MetMoi");
                    obj.TK_Mach = DataReader["TK_Mach"].ToString();
                    obj.TK_HuyetAp = DataReader["TK_HuyetAp"].ToString();
                    obj.TK_HachTo = DataReader.GetInt("TK_HachTo");
                    obj.TK_HachTo_ViTri = DataReader["TK_HachTo_ViTri"].ToString();
                    obj.TK_CoThemBenhGi = DataReader["TK_CoThemBenhGi"].ToString();
                    obj.TK_DatDo = DataReader.GetInt("TK_DatDo");
                    obj.TK_DatDo_ViTri = DataReader["TK_DatDo_ViTri"].ToString();
                    obj.TK_MauSac_ViTri = DataReader["TK_MauSac_ViTri"].ToString();
                    obj.TK_RuouVang = DataReader.GetInt("TK_RuouVang");
                    obj.TK_DoTuoi = DataReader.GetInt("TK_DoTuoi");
                    obj.TK_DoTham = DataReader.GetInt("TK_DoTham");
                    obj.TK_MatPhuNe = DataReader.GetInt("TK_MatPhuNe");
                    obj.TK_BanHeliotrope = DataReader.GetInt("TK_BanHeliotrope");
                    obj.TK_VSign = DataReader.GetInt("TK_VSign");
                    obj.TK_HoslterSign = DataReader.GetInt("TK_HoslterSign");
                    obj.TK_ShawlSign = DataReader.GetInt("TK_ShawlSign");
                    obj.TK_LangDongCanxiODa = DataReader.GetInt("TK_LangDongCanxiODa");
                    obj.TK_GottronSign_BanTay = DataReader.GetInt("TK_GottronSign_BanTay");
                    obj.TK_GottronSign_KhuyuTay = DataReader.GetInt("TK_GottronSign_KhuyuTay");
                    obj.TK_GottronSign_DauGoi = DataReader.GetInt("TK_GottronSign_DauGoi");
                    obj.TK_GottronPapules_BanTay = DataReader.GetInt("TK_GottronPapules_BanTay");
                    obj.TK_GottronPapules_KhuyuTay = DataReader.GetInt("TK_GottronPapules_KhuyuTay");
                    obj.TK_GottronPapules_DauGoi = DataReader.GetInt("TK_GottronPapules_DauGoi");
                    obj.TK_GianMachQuanhMong = DataReader.GetInt("TK_GianMachQuanhMong");
                    obj.TK_XuatHuyetQuanhMong = DataReader.GetInt("TK_XuatHuyetQuanhMong");
                    obj.TK_NutNeQuanhMong = DataReader.GetInt("TK_NutNeQuanhMong");
                    obj.TK_MichanicHand = DataReader.GetInt("TK_MichanicHand");
                    obj.TK_RamLongTrenNenDatDo = DataReader.GetInt("TK_RamLongTrenNenDatDo");
                    obj.TK_RamLongTrenNenDatDo_ViTri = DataReader["TK_RamLongTrenNenDatDo_ViTri"].ToString();
                    obj.TK_HienTuongRaynaud = DataReader.GetInt("TK_HienTuongRaynaud");
                    obj.TK_DauHieuPoikiloderma = DataReader.GetInt("TK_DauHieuPoikiloderma");
                    obj.TK_DauHieuPoikiloderma_ViTri = DataReader["TK_DauHieuPoikiloderma_ViTri"].ToString();
                    obj.TK_VetLoetTrenDa = DataReader.GetInt("TK_VetLoetTrenDa");
                    obj.TK_VetLoetTrenDa_ViTri = DataReader["TK_VetLoetTrenDa_ViTri"].ToString();
                    obj.TK_DauCo = DataReader.GetInt("TK_DauCo");
                    obj.TK_DauCo_Diem = DataReader["TK_DauCo_Diem"].ToString();
                    obj.TK_DauCo_ViTri = DataReader["TK_DauCo_ViTri"].ToString();
                    obj.TK_BopCo = DataReader.GetInt("TK_BopCo");
                    obj.TK_BopCo_ViTri = DataReader["TK_BopCo_ViTri"].ToString();
                    obj.TK_YeuCo = DataReader.GetInt("TK_YeuCo");
                    obj.TK_TeoCo = DataReader.GetInt("TK_TeoCo");
                    obj.TK_CoGapCanhTay = JsonConvert.DeserializeObject<TrieuChungCo>(DataReader["TK_CoGapCanhTay"].ToString());
                    obj.TK_CoDuoiCanhTay = JsonConvert.DeserializeObject<TrieuChungCo>(DataReader["TK_CoDuoiCanhTay"].ToString());
                    obj.TK_CoGapDui = JsonConvert.DeserializeObject<TrieuChungCo>(DataReader["TK_CoGapDui"].ToString());
                    obj.TK_CoDuoiDui = JsonConvert.DeserializeObject<TrieuChungCo>(DataReader["TK_CoDuoiDui"].ToString());
                    obj.TK_DauKhop = DataReader.GetInt("TK_DauKhop");
                    obj.TK_DauKhop_SoLuong = DataReader["TK_DauKhop_SoLuong"].ToString();
                    obj.TK_DauKhop_ViTri = DataReader["TK_DauKhop_ViTri"].ToString();
                    obj.TK_SungKhop = DataReader.GetInt("TK_SungKhop");
                    obj.TK_SungKhop_SoLuong = DataReader["TK_SungKhop_SoLuong"].ToString();
                    obj.TK_SungKhop_ViTri = DataReader["TK_SungKhop_ViTri"].ToString();
                    obj.TK_BienDangKhop = DataReader.GetInt("TK_BienDangKhop");
                    obj.TK_BienDangKhop_SoLuong = DataReader["TK_BienDangKhop_SoLuong"].ToString();
                    obj.TK_BienDangKhop_ViTri = DataReader["TK_BienDangKhop_ViTri"].ToString();
                    obj.TK_KhoThoKhiGangSuc = DataReader["TK_KhoThoKhiGangSuc"].ToString();
                    obj.TK_KhoThoKhiNghiNgoi = DataReader.GetInt("TK_KhoThoKhiNghiNgoi");
                    obj.TK_HoKhanKeoDai = DataReader.GetInt("TK_HoKhanKeoDai");
                    obj.TK_RanPhoiDoiXung = DataReader.GetInt("TK_RanPhoiDoiXung");
                    obj.TK_Phoi_Khac = DataReader["TK_Phoi_Khac"].ToString();
                    obj.TK_DanhTrongNguc = DataReader.GetInt("TK_DanhTrongNguc");
                    obj.TK_NhipTim = DataReader.GetInt("TK_NhipTim");
                    obj.TK_NhipTim_Khac = DataReader["TK_NhipTim_Khac"].ToString();
                    obj.TK_DauHieuSuyTim = DataReader.GetInt("TK_DauHieuSuyTim");
                    obj.TK_DauHieuSuyTim_Co = DataReader["TK_DauHieuSuyTim_Co"].ToString();
                    obj.TK_Tim_Khac = DataReader["TK_Tim_Khac"].ToString();
                    obj.TK_NuotKhoNghenThucAnRan = DataReader.GetInt("TK_NuotKhoNghenThucAnRan");
                    obj.TK_NuotKhoThucAnLongNuoc = DataReader.GetInt("TK_NuotKhoThucAnLongNuoc");
                    obj.TK_ONong = DataReader.GetInt("TK_ONong");
                    obj.TK_ONongDauNguc = DataReader.GetInt("TK_ONongDauNguc");
                    obj.TK_DangChuaMieng = DataReader.GetInt("TK_DangChuaMieng");
                    obj.TK_NoiKhanDauViemHong = DataReader.GetInt("TK_NoiKhanDauViemHong");
                    obj.TK_HoKhiAn = DataReader.GetInt("TK_HoKhiAn");
                    obj.TK_TaoBon = DataReader.GetInt("TK_TaoBon");
                    obj.TK_TaoLongXenKe = DataReader.GetInt("TK_TaoLongXenKe");
                    obj.TK_DuongTieuHoa_Khac = DataReader["TK_DuongTieuHoa_Khac"].ToString();
                    obj.TK_CongThucMau_Bc = DataReader["TK_CongThucMau_Bc"].ToString();
                    obj.TK_CongThucMau_Tt = DataReader["TK_CongThucMau_Tt"].ToString();
                    obj.TK_CongThucMau_Lym = DataReader["TK_CongThucMau_Lym"].ToString();
                    obj.TK_CongThucMau_At = DataReader["TK_CongThucMau_At"].ToString();
                    obj.TK_CongThucMau_Hc = DataReader["TK_CongThucMau_Hc"].ToString();
                    obj.TK_CongThucMau_Hct = DataReader["TK_CongThucMau_Hct"].ToString();
                    obj.TK_CongThucMau_Hb = DataReader["TK_CongThucMau_Hb"].ToString();
                    obj.TK_CongThucMau_Tc = DataReader["TK_CongThucMau_Tc"].ToString();
                    obj.TK_MauLang_1h = DataReader["TK_MauLang_1h"].ToString();
                    obj.TK_MauLang_2h = DataReader["TK_MauLang_2h"].ToString();
                    obj.TK_SinhHoa_Ure = DataReader["TK_SinhHoa_Ure"].ToString();
                    obj.TK_SinhHoa_Choles = DataReader["TK_SinhHoa_Choles"].ToString();
                    obj.TK_SinhHoa_Na = DataReader["TK_SinhHoa_Na"].ToString();
                    obj.TK_SinhHoa_Creatinin = DataReader["TK_SinhHoa_Creatinin"].ToString();
                    obj.TK_SinhHoa_Trigly = DataReader["TK_SinhHoa_Trigly"].ToString();
                    obj.TK_SinhHoa_K = DataReader["TK_SinhHoa_K"].ToString();
                    obj.TK_SinhHoa_Glucose = DataReader["TK_SinhHoa_Glucose"].ToString();
                    obj.TK_SinhHoa_Ldl = DataReader["TK_SinhHoa_Ldl"].ToString();
                    obj.TK_SinhHoa_Cl = DataReader["TK_SinhHoa_Cl"].ToString();
                    obj.TK_SinhHoa_Uric = DataReader["TK_SinhHoa_Uric"].ToString();
                    obj.TK_SinhHoa_Hdl = DataReader["TK_SinhHoa_Hdl"].ToString();
                    obj.TK_SinhHoa_Ast = DataReader["TK_SinhHoa_Ast"].ToString();
                    obj.TK_SinhHoa_BiltP = DataReader["TK_SinhHoa_BiltP"].ToString();
                    obj.TK_SinhHoa_Pro = DataReader["TK_SinhHoa_Pro"].ToString();
                    obj.TK_SinhHoa_ALT = DataReader["TK_SinhHoa_ALT"].ToString();
                    obj.TK_SinhHoa_BiltT = DataReader["TK_SinhHoa_BiltT"].ToString();
                    obj.TK_SinhHoa_Alb = DataReader["TK_SinhHoa_Alb"].ToString();
                    obj.TK_SinhHoa_Ck = DataReader["TK_SinhHoa_Ck"].ToString();
                    obj.TK_SinhHoa_CrpHs = DataReader["TK_SinhHoa_CrpHs"].ToString();
                    obj.TK_SinhHoa_CkMb = DataReader["TK_SinhHoa_CkMb"].ToString();
                    obj.TK_SinhHoa_Khac = DataReader["TK_SinhHoa_Khac"].ToString();
                    obj.TK_NuocTieu_Protein = DataReader.GetInt("TK_NuocTieu_Protein");
                    obj.TK_NuocTieu_ProteinNieu24h = DataReader["TK_NuocTieu_ProteinNieu24h"].ToString();
                    obj.TK_NuocTieu_Hc = DataReader.GetInt("TK_NuocTieu_Hc");
                    obj.TK_NuocTieu_Bc = DataReader.GetInt("TK_NuocTieu_Bc");
                    obj.TK_NuocTieu_Khac = DataReader["TK_NuocTieu_Khac"].ToString();
                    obj.TK_CNHH_FVC = DataReader["TK_CNHH_FVC"].ToString();
                    obj.TK_CNHH_FEV1 = DataReader["TK_CNHH_FEV1"].ToString();
                    obj.TK_CNHH_DuDoanFVC = DataReader["TK_CNHH_DuDoanFVC"].ToString();
                    obj.TK_CNHH_FEV1FVC = DataReader["TK_CNHH_FEV1FVC"].ToString();
                    obj.TK_CNHH_DlCo = DataReader["TK_CNHH_DlCo"].ToString();
                    obj.TK_CNHH_DuDoanDlCo = DataReader["TK_CNHH_DuDoanDlCo"].ToString();
                    obj.TK_XqTp = DataReader["TK_XqTp"].ToString();
                    obj.TK_HrCt = DataReader["TK_HrCt"].ToString();
                    obj.TK_SaOBung = DataReader["TK_SaOBung"].ToString();
                    obj.TK_DienTim_TanSo = DataReader["TK_DienTim_TanSo"].ToString();
                    obj.TK_DienTim_Nhip = DataReader["TK_DienTim_Nhip"].ToString();
                    obj.TK_DienTim_Truc = DataReader["TK_DienTim_Truc"].ToString();
                    obj.TK_DiemTim_Khac = DataReader["TK_DiemTim_Khac"].ToString();
                    obj.TK_SaTimEF = DataReader["TK_SaTimEF"].ToString();
                    obj.TK_SaTimPdmp = DataReader["TK_SaTimPdmp"].ToString();
                    obj.TK_SaTim_Khac = DataReader["TK_SaTim_Khac"].ToString();
                    obj.TK_KhangThe_Ana = DataReader.GetInt("TK_KhangThe_Ana");
                    obj.TK_KhangThe_Ana_Duong = DataReader["TK_KhangThe_Ana_Duong"].ToString();
                    obj.TK_KhangThe_Ana_Am = DataReader["TK_KhangThe_Ana_Am"].ToString();
                    obj.TK_KhangThe_Anti155140 = DataReader.GetInt("TK_KhangThe_Anti155140");
                    obj.TK_KhangThe_Anti155140_Duong = DataReader["TK_KhangThe_Anti155140_Duong"].ToString();
                    obj.TK_KhangThe_Anti155140_Am = DataReader["TK_KhangThe_Anti155140_Am"].ToString();
                    obj.TK_KhangThe_AntiPMScl = DataReader.GetInt("TK_KhangThe_AntiPMScl");
                    obj.TK_KhangThe_AntiPMScl_Duong = DataReader["TK_KhangThe_AntiPMScl_Duong"].ToString();
                    obj.TK_KhangThe_AntiPMScl_Am = DataReader["TK_KhangThe_AntiPMScl_Am"].ToString();
                    obj.TK_KhangThe_AntiARS = DataReader.GetInt("TK_KhangThe_AntiARS");
                    obj.TK_KhangThe_AntiARS_Duong = DataReader["TK_KhangThe_AntiARS_Duong"].ToString();
                    obj.TK_KhangThe_AntiARS_Am = DataReader["TK_KhangThe_AntiARS_Am"].ToString();
                    obj.TK_KhangThe_AntiCadm = DataReader.GetInt("TK_KhangThe_AntiCadm");
                    obj.TK_KhangThe_AntiCadm_Duong = DataReader["TK_KhangThe_AntiCadm_Duong"].ToString();
                    obj.TK_KhangThe_AntiCadm_Am = DataReader["TK_KhangThe_AntiCadm_Am"].ToString();
                    obj.TK_KhangThe_Ku = DataReader.GetInt("TK_KhangThe_Ku");
                    obj.TK_KhangThe_Ku_Duong = DataReader["TK_KhangThe_Ku_Duong"].ToString();
                    obj.TK_KhangThe_Ku_Am = DataReader["TK_KhangThe_Ku_Am"].ToString();
                    obj.TK_KhangThe_dsDNA = DataReader.GetInt("TK_KhangThe_dsDNA");
                    obj.TK_KhangThe_dsDNA_Duong = DataReader["TK_KhangThe_dsDNA_Duong"].ToString();
                    obj.TK_KhangThe_dsDNA_Am = DataReader["TK_KhangThe_dsDNA_Am"].ToString();
                    obj.TK_KhangThe_AntiU1RNP = DataReader.GetInt("TK_KhangThe_AntiU1RNP");
                    obj.TK_KhangThe_AntiU1RNP_Duong = DataReader["TK_KhangThe_AntiU1RNP_Duong"].ToString();
                    obj.TK_KhangThe_AntiU1RNP_Am = DataReader["TK_KhangThe_AntiU1RNP_Am"].ToString();
                    obj.TK_KhangThe_TIF1 = DataReader.GetInt("TK_KhangThe_TIF1");
                    obj.TK_KhangThe_TIF1_Duong = DataReader["TK_KhangThe_TIF1_Duong"].ToString();
                    obj.TK_KhangThe_TIF1_Am = DataReader["TK_KhangThe_TIF1_Am"].ToString();
                    obj.TK_KhangThe_AntiJ01 = DataReader.GetInt("TK_KhangThe_AntiJ01");
                    obj.TK_KhangThe_AntiJ01_Duong = DataReader["TK_KhangThe_AntiJ01_Duong"].ToString();
                    obj.TK_KhangThe_AntiJ01_Am = DataReader["TK_KhangThe_AntiJ01_Am"].ToString();
                    obj.TK_KhangThe_AntiSRP = DataReader.GetInt("TK_KhangThe_AntiSRP");
                    obj.TK_KhangThe_AntiSRP_Duong = DataReader["TK_KhangThe_AntiSRP_Duong"].ToString();
                    obj.TK_KhangThe_AntiSRP_Am = DataReader["TK_KhangThe_AntiSRP_Am"].ToString();
                    obj.TK_KhangThe_antiNXP2 = DataReader.GetInt("TK_KhangThe_antiNXP2");
                    obj.TK_KhangThe_antiNXP2_Duong = DataReader["TK_KhangThe_antiNXP2_Duong"].ToString();
                    obj.TK_KhangThe_antiNXP2_Am = DataReader["TK_KhangThe_antiNXP2_Am"].ToString();
                    obj.TK_KhangThe_AntiMi2 = DataReader.GetInt("TK_KhangThe_AntiMi2");
                    obj.TK_KhangThe_AntiMi2_Duong = DataReader["TK_KhangThe_AntiMi2_Duong"].ToString();
                    obj.TK_KhangThe_AntiMi2_Am = DataReader["TK_KhangThe_AntiMi2_Am"].ToString();
                    obj.TK_KhangThe_AntiMDA5 = DataReader.GetInt("TK_KhangThe_AntiMDA5");
                    obj.TK_KhangThe_AntiMDA5_Duong = DataReader["TK_KhangThe_AntiMDA5_Duong"].ToString();
                    obj.TK_KhangThe_AntiMDA5_Am = DataReader["TK_KhangThe_AntiMDA5_Am"].ToString();
                    obj.TK_KhangThe_antiSAE = DataReader.GetInt("TK_KhangThe_antiSAE");
                    obj.TK_KhangThe_antiSAE_Duong = DataReader["TK_KhangThe_antiSAE_Duong"].ToString();
                    obj.TK_KhangThe_antiSAE_Am = DataReader["TK_KhangThe_antiSAE_Am"].ToString();
                    obj.TK_KhangThe_Khac = DataReader["TK_KhangThe_Khac"].ToString();
                    obj.TK_KhamMat = DataReader["TK_KhamMat"].ToString();
                    obj.TK_ChuY = DataReader["TK_ChuY"].ToString();
                    obj.TK_DieuTri = DataReader["TK_DieuTri"].ToString();
                    obj.TK_TacDungPhuCuaThuoc = DataReader["TK_TacDungPhuCuaThuoc"].ToString();
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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, BenhAnNgoaiTru_ViemBiCo BenhAnNgoaiTru_ViemBiCo)
        {
            try { 
                string sql =
                          @"select MaQuanLy 
                            from BenhAnViemBiCo
                            where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnNgoaiTru_ViemBiCo.MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                int rowCount = 0;
                while (DataReader.Read()) rowCount++;
                if (rowCount == 1) return Update(MyConnection, BenhAnNgoaiTru_ViemBiCo);
                sql = @"
                       INSERT INTO BenhAnViemBiCo 
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
                            GaySut_Kg,
                            GaySut_Thang,
                            GaySut_PhanTram,
                            Cao,
                            TuoiKhoiPhat,
                            TGTKKPB,
                            TrieuChungDauTien,
                            LupusBanDo,
                            XoCungBi,
                            ViemKhopDangThap,
                            HoiChungSjogren,
                            ViemBiCo,
                            TienSuBenhTuMien_Khac,
                            TSCNBCBK_Text,
                            TSCNBCBK,
                            TSGDCNBBTM,
                            TSGDCNBBTM_NeuCo,
                            BenhSu,
                            ChuaDieuTri,
                            Dpenicillamine,
                            Dpenicillamine_CachDung,
                            Corticosteroid,
                            Corticosteroid_CachDung,
                            Cyclophosphamide,
                            Cyclophosphamide_CachDung,
                            Azathioprine,
                            Azathioprine_CachDung,
                            Methotrexate,
                            Methotrexate_CachDung,
                            ThuocKha,
                            ThuocKhac_CachDung,
                            TacDungPhuThuoc,
                            TacDungPhuThuoc_Co,
                            Sot,
                            Sot_Do,
                            MetMoi,
                            Mach,
                            HuyetAp,
                            HachTo,
                            HachTo_ViTri,
                            DatDo,
                            DatDo_ViTri,
                            MauSac_ViTri,
                            RuouVang,
                            DoTuoi,
                            DoTham,
                            MatPhuNe,
                            BanHeliotrope,
                            VSign,
                            HoslterSign,
                            ShawlSign,
                            LangDongCanxiODa,
                            GottronSign_BanTay,
                            GottronSign_KhuyuTay,
                            GottronSign_DauGoi,
                            GottronPapules_BanTay,
                            GottronPapules_KhuyuTay,
                            GottronPapules_DauGoi,
                            GianMachQuanhMong,
                            XuatHuyetQuanhMong,
                            NutNeQuanhMong,
                            MichanicHand,
                            RamLongTrenNenDatDo,
                            RamLongTrenNenDatDo_ViTri,
                            HienTuongRaynaud,
                            DauHieuPoikiloderma,
                            DauHieuPoikiloderma_ViTri,
                            VetLoetTrenDa,
                            VetLoetTrenDa_ViTri,
                            LamSangDa_Khac,
                            DauCo,
                            DauCo_Diem,
                            DauCo_ViTri,
                            BopCo,
                            BopCo_ViTri,
                            YeuCo,
                            TeoCo,
                            CoGapCanhTay,
                            CoDuoiCanhTay,
                            CoGapDui,
                            CoDuoiDui,
                            DauKhop,
                            DauKhop_SoLuong,
                            DauKhop_ViTri,
                            SungKhop,
                            SungKhop_SoLuong,
                            SungKhop_ViTri,
                            BienDangKhop,
                            BienDangKhop_SoLuong,
                            BienDangKhop_ViTri,
                            KhoThoKhiGangSuc,
                            KhoThoKhiNghiNgoi,
                            HoKhanKeoDai,
                            RanPhoiDoiXung,
                            Phoi_Khac,
                            DanhTrongNguc,
                            NhipTim,
                            NhipTim_Khac,
                            DauHieuSuyTim,
                            DauHieuSuyTim_Co,
                            Tim_Khac,
                            NuotKhoNghenThucAnRan,
                            NuotKhoThucAnLongNuoc,
                            ONong,
                            ONongDauNguc,
                            DangChuaMieng,
                            NoiKhanDauViemHong,
                            HoKhiAn,
                            TaoBon,
                            TaoLongXenKe,
                            DuongTieuHoa_Khac,
                            Phu,
                            TieuIt,
                            TieuMau,
                            ThanTietNieu_Khac,
                            CongThucMau_Bc,
                            CongThucMau_Tt,
                            CongThucMau_Lym,
                            CongThucMau_At,
                            CongThucMau_Hc,
                            CongThucMau_Hct,
                            CongThucMau_Hb,
                            CongThucMau_Tc,
                            MauLang_1h,
                            MauLang_2h,
                            SinhHoa_Ure,
                            SinhHoa_Choles,
                            SinhHoa_Na,
                            SinhHoa_Creatinin,
                            SinhHoa_Trigly,
                            SinhHoa_K,
                            SinhHoa_Glucose,
                            SinhHoa_Ldl,
                            SinhHoa_Cl,
                            SinhHoa_Uric,
                            SinhHoa_Hdl,
                            SinhHoa_Ast,
                            SinhHoa_BiltP,
                            SinhHoa_Pro,
                            SinhHoa_ALT,
                            SinhHoa_BiltT,
                            SinhHoa_Alb,
                            SinhHoa_Ck,
                            SinhHoa_CrpHs,
                            SinhHoa_CkMb,
                            SinhHoa_Khac,
                            NuocTieu_Protein,
                            NuocTieu_ProteinNieu24h,
                            NuocTieu_Hc,
                            NuocTieu_Bc,
                            NuocTieu_Khac,
                            CNHH_FVC,
                            CNHH_FEV1,
                            CNHH_DuDoanFVC,
                            CNHH_FEV1FVC,
                            CNHH_DlCo,
                            CNHH_DuDoanDlCo,
                            XqTp,
                            HrCt,
                            SaOBung,
                            DienTim_TanSo,
                            DienTim_Nhip,
                            DienTim_Truc,
                            DiemTim_Khac,
                            SaTimEF,
                            SaTimPdmp,
                            SaTim_Khac,
                            KhangThe_Ana,
                            KhangThe_Ana_Duong,
                            KhangThe_Ana_Am,
                            KhangThe_Anti155140,
                            KhangThe_Anti155140_Duong,
                            KhangThe_Anti155140_Am,
                            KhangThe_AntiPMScl,
                            KhangThe_AntiPMScl_Duong,
                            KhangThe_AntiPMScl_Am,
                            KhangThe_AntiARS,
                            KhangThe_AntiARS_Duong,
                            KhangThe_AntiARS_Am,
                            KhangThe_AntiCadm,
                            KhangThe_AntiCadm_Duong,
                            KhangThe_AntiCadm_Am,
                            KhangThe_Ku,
                            KhangThe_Ku_Duong,
                            KhangThe_Ku_Am,
                            KhangThe_dsDNA,
                            KhangThe_dsDNA_Duong,
                            KhangThe_dsDNA_Am,
                            KhangThe_AntiU1RNP,
                            KhangThe_AntiU1RNP_Duong,
                            KhangThe_AntiU1RNP_Am,
                            KhangThe_TIF1,
                            KhangThe_TIF1_Duong,
                            KhangThe_TIF1_Am,
                            KhangThe_AntiJ01,
                            KhangThe_AntiJ01_Duong,
                            KhangThe_AntiJ01_Am,
                            KhangThe_AntiSRP,
                            KhangThe_AntiSRP_Duong,
                            KhangThe_AntiSRP_Am,
                            KhangThe_antiNXP2,
                            KhangThe_antiNXP2_Duong,
                            KhangThe_antiNXP2_Am,
                            KhangThe_AntiMi2,
                            KhangThe_AntiMi2_Duong,
                            KhangThe_AntiMi2_Am,
                            KhangThe_AntiMDA5,
                            KhangThe_AntiMDA5_Duong,
                            KhangThe_AntiMDA5_Am,
                            KhangThe_antiSAE,
                            KhangThe_antiSAE_Duong,
                            KhangThe_antiSAE_Am,
                            KhangThe_Khac,
                            KhamMat,
                            DienCoKim,
                            SinhThietCo,
                            BohanPeter,
                            Tanimoto,
                            MotSoThe,
                            MotSoThe_Khac,
                            TS_Corticosteroid,
                            TS_Cyclophosphamid,
                            TS_CyclophosphamidLieuCao,
                            TS_Azathioprine,
                            TS_Methotrexate,
                            TS_CyclosporineA,
                            ThuocKhac,
                            DieuTriHienTai,
                            HenKham,
                            BacSyDieuTri,
                            MaBacSyDieuTri,
                            TK_SoBenhAnDienTu,
                            TK_SoLuuTru,
                            NgayKham,
                            NgayLuuHuyetThanh,
                            BacSiKham,
                            MaBacSiKham,
                            TK_Sot,
                            TK_Sot_Do,
                            TK_MetMoi,
                            TK_Mach,
                            TK_HuyetAp,
                            TK_HachTo,
                            TK_HachTo_ViTri,
                            TK_CoThemBenhGi,
                            TK_DatDo,
                            TK_DatDo_ViTri,
                            TK_MauSac_ViTri,
                            TK_RuouVang,
                            TK_DoTuoi,
                            TK_DoTham,
                            TK_MatPhuNe,
                            TK_BanHeliotrope,
                            TK_VSign,
                            TK_HoslterSign,
                            TK_ShawlSign,
                            TK_LangDongCanxiODa,
                            TK_GottronSign_BanTay,
                            TK_GottronSign_KhuyuTay,
                            TK_GottronSign_DauGoi,
                            TK_GottronPapules_BanTay,
                            TK_GottronPapules_KhuyuTay,
                            TK_GottronPapules_DauGoi,
                            TK_GianMachQuanhMong,
                            TK_XuatHuyetQuanhMong,
                            TK_NutNeQuanhMong,
                            TK_MichanicHand,
                            TK_RamLongTrenNenDatDo,
                            TK_RamLongTrenNenDatDo_ViTri,
                            TK_HienTuongRaynaud,
                            TK_DauHieuPoikiloderma,
                            TK_DauHieuPoikiloderma_ViTri,
                            TK_VetLoetTrenDa,
                            TK_VetLoetTrenDa_ViTri,
                            TK_DauCo,
                            TK_DauCo_Diem,
                            TK_DauCo_ViTri,
                            TK_BopCo,
                            TK_BopCo_ViTri,
                            TK_YeuCo,
                            TK_TeoCo,
                            TK_CoGapCanhTay,
                            TK_CoDuoiCanhTay,
                            TK_CoGapDui,
                            TK_CoDuoiDui,
                            TK_DauKhop,
                            TK_DauKhop_SoLuong,
                            TK_DauKhop_ViTri,
                            TK_SungKhop,
                            TK_SungKhop_SoLuong,
                            TK_SungKhop_ViTri,
                            TK_BienDangKhop,
                            TK_BienDangKhop_SoLuong,
                            TK_BienDangKhop_ViTri,
                            TK_KhoThoKhiGangSuc,
                            TK_KhoThoKhiNghiNgoi,
                            TK_HoKhanKeoDai,
                            TK_RanPhoiDoiXung,
                            TK_Phoi_Khac,
                            TK_DanhTrongNguc,
                            TK_NhipTim,
                            TK_NhipTim_Khac,
                            TK_DauHieuSuyTim,
                            TK_DauHieuSuyTim_Co,
                            TK_Tim_Khac,
                            TK_NuotKhoNghenThucAnRan,
                            TK_NuotKhoThucAnLongNuoc,
                            TK_ONong,
                            TK_ONongDauNguc,
                            TK_DangChuaMieng,
                            TK_NoiKhanDauViemHong,
                            TK_HoKhiAn,
                            TK_TaoBon,
                            TK_TaoLongXenKe,
                            TK_DuongTieuHoa_Khac,
                            TK_CongThucMau_Bc,
                            TK_CongThucMau_Tt,
                            TK_CongThucMau_Lym,
                            TK_CongThucMau_At,
                            TK_CongThucMau_Hc,
                            TK_CongThucMau_Hct,
                            TK_CongThucMau_Hb,
                            TK_CongThucMau_Tc,
                            TK_MauLang_1h,
                            TK_MauLang_2h,
                            TK_SinhHoa_Ure,
                            TK_SinhHoa_Choles,
                            TK_SinhHoa_Na,
                            TK_SinhHoa_Creatinin,
                            TK_SinhHoa_Trigly,
                            TK_SinhHoa_K,
                            TK_SinhHoa_Glucose,
                            TK_SinhHoa_Ldl,
                            TK_SinhHoa_Cl,
                            TK_SinhHoa_Uric,
                            TK_SinhHoa_Hdl,
                            TK_SinhHoa_Ast,
                            TK_SinhHoa_BiltP,
                            TK_SinhHoa_Pro,
                            TK_SinhHoa_ALT,
                            TK_SinhHoa_BiltT,
                            TK_SinhHoa_Alb,
                            TK_SinhHoa_Ck,
                            TK_SinhHoa_CrpHs,
                            TK_SinhHoa_CkMb,
                            TK_SinhHoa_Khac,
                            TK_NuocTieu_Protein,
                            TK_NuocTieu_ProteinNieu24h,
                            TK_NuocTieu_Hc,
                            TK_NuocTieu_Bc,
                            TK_NuocTieu_Khac,
                            TK_CNHH_FVC,
                            TK_CNHH_FEV1,
                            TK_CNHH_DuDoanFVC,
                            TK_CNHH_FEV1FVC,
                            TK_CNHH_DlCo,
                            TK_CNHH_DuDoanDlCo,
                            TK_XqTp,
                            TK_HrCt,
                            TK_SaOBung,
                            TK_DienTim_TanSo,
                            TK_DienTim_Nhip,
                            TK_DienTim_Truc,
                            TK_DiemTim_Khac,
                            TK_SaTimEF,
                            TK_SaTimPdmp,
                            TK_SaTim_Khac,
                            TK_KhangThe_Ana,
                            TK_KhangThe_Ana_Duong,
                            TK_KhangThe_Ana_Am,
                            TK_KhangThe_Anti155140,
                            TK_KhangThe_Anti155140_Duong,
                            TK_KhangThe_Anti155140_Am,
                            TK_KhangThe_AntiPMScl,
                            TK_KhangThe_AntiPMScl_Duong,
                            TK_KhangThe_AntiPMScl_Am,
                            TK_KhangThe_AntiARS,
                            TK_KhangThe_AntiARS_Duong,
                            TK_KhangThe_AntiARS_Am,
                            TK_KhangThe_AntiCadm,
                            TK_KhangThe_AntiCadm_Duong,
                            TK_KhangThe_AntiCadm_Am,
                            TK_KhangThe_Ku,
                            TK_KhangThe_Ku_Duong,
                            TK_KhangThe_Ku_Am,
                            TK_KhangThe_dsDNA,
                            TK_KhangThe_dsDNA_Duong,
                            TK_KhangThe_dsDNA_Am,
                            TK_KhangThe_AntiU1RNP,
                            TK_KhangThe_AntiU1RNP_Duong,
                            TK_KhangThe_AntiU1RNP_Am,
                            TK_KhangThe_TIF1,
                            TK_KhangThe_TIF1_Duong,
                            TK_KhangThe_TIF1_Am,
                            TK_KhangThe_AntiJ01,
                            TK_KhangThe_AntiJ01_Duong,
                            TK_KhangThe_AntiJ01_Am,
                            TK_KhangThe_AntiSRP,
                            TK_KhangThe_AntiSRP_Duong,
                            TK_KhangThe_AntiSRP_Am,
                            TK_KhangThe_antiNXP2,
                            TK_KhangThe_antiNXP2_Duong,
                            TK_KhangThe_antiNXP2_Am,
                            TK_KhangThe_AntiMi2,
                            TK_KhangThe_AntiMi2_Duong,
                            TK_KhangThe_AntiMi2_Am,
                            TK_KhangThe_AntiMDA5,
                            TK_KhangThe_AntiMDA5_Duong,
                            TK_KhangThe_AntiMDA5_Am,
                            TK_KhangThe_antiSAE,
                            TK_KhangThe_antiSAE_Duong,
                            TK_KhangThe_antiSAE_Am,
                            TK_KhangThe_Khac,
                            TK_KhamMat,
                            TK_ChuY,
                            TK_DieuTri,
                            TK_TacDungPhuCuaThuoc,
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
                            :GaySut_Kg,
                            :GaySut_Thang,
                            :GaySut_PhanTram,
                            :Cao,
                            :TuoiKhoiPhat,
                            :TGTKKPB,
                            :TrieuChungDauTien,
                            :LupusBanDo,
                            :XoCungBi,
                            :ViemKhopDangThap,
                            :HoiChungSjogren,
                            :ViemBiCo,
                            :TienSuBenhTuMien_Khac,
                            :TSCNBCBK_Text,
                            :TSCNBCBK,
                            :TSGDCNBBTM,
                            :TSGDCNBBTM_NeuCo,
                            :BenhSu,
                            :ChuaDieuTri,
                            :Dpenicillamine,
                            :Dpenicillamine_CachDung,
                            :Corticosteroid,
                            :Corticosteroid_CachDung,
                            :Cyclophosphamide,
                            :Cyclophosphamide_CachDung,
                            :Azathioprine,
                            :Azathioprine_CachDung,
                            :Methotrexate,
                            :Methotrexate_CachDung,
                            :ThuocKha,
                            :ThuocKhac_CachDung,
                            :TacDungPhuThuoc,
                            :TacDungPhuThuoc_Co,
                            :Sot,
                            :Sot_Do,
                            :MetMoi,
                            :Mach,
                            :HuyetAp,
                            :HachTo,
                            :HachTo_ViTri,
                            :DatDo,
                            :DatDo_ViTri,
                            :MauSac_ViTri,
                            :RuouVang,
                            :DoTuoi,
                            :DoTham,
                            :MatPhuNe,
                            :BanHeliotrope,
                            :VSign,
                            :HoslterSign,
                            :ShawlSign,
                            :LangDongCanxiODa,
                            :GottronSign_BanTay,
                            :GottronSign_KhuyuTay,
                            :GottronSign_DauGoi,
                            :GottronPapules_BanTay,
                            :GottronPapules_KhuyuTay,
                            :GottronPapules_DauGoi,
                            :GianMachQuanhMong,
                            :XuatHuyetQuanhMong,
                            :NutNeQuanhMong,
                            :MichanicHand,
                            :RamLongTrenNenDatDo,
                            :RamLongTrenNenDatDo_ViTri,
                            :HienTuongRaynaud,
                            :DauHieuPoikiloderma,
                            :DauHieuPoikiloderma_ViTri,
                            :VetLoetTrenDa,
                            :VetLoetTrenDa_ViTri,
                            :LamSangDa_Khac,
                            :DauCo,
                            :DauCo_Diem,
                            :DauCo_ViTri,
                            :BopCo,
                            :BopCo_ViTri,
                            :YeuCo,
                            :TeoCo,
                            :CoGapCanhTay,
                            :CoDuoiCanhTay,
                            :CoGapDui,
                            :CoDuoiDui,
                            :DauKhop,
                            :DauKhop_SoLuong,
                            :DauKhop_ViTri,
                            :SungKhop,
                            :SungKhop_SoLuong,
                            :SungKhop_ViTri,
                            :BienDangKhop,
                            :BienDangKhop_SoLuong,
                            :BienDangKhop_ViTri,
                            :KhoThoKhiGangSuc,
                            :KhoThoKhiNghiNgoi,
                            :HoKhanKeoDai,
                            :RanPhoiDoiXung,
                            :Phoi_Khac,
                            :DanhTrongNguc,
                            :NhipTim,
                            :NhipTim_Khac,
                            :DauHieuSuyTim,
                            :DauHieuSuyTim_Co,
                            :Tim_Khac,
                            :NuotKhoNghenThucAnRan,
                            :NuotKhoThucAnLongNuoc,
                            :ONong,
                            :ONongDauNguc,
                            :DangChuaMieng,
                            :NoiKhanDauViemHong,
                            :HoKhiAn,
                            :TaoBon,
                            :TaoLongXenKe,
                            :DuongTieuHoa_Khac,
                            :Phu,
                            :TieuIt,
                            :TieuMau,
                            :ThanTietNieu_Khac,
                            :CongThucMau_Bc,
                            :CongThucMau_Tt,
                            :CongThucMau_Lym,
                            :CongThucMau_At,
                            :CongThucMau_Hc,
                            :CongThucMau_Hct,
                            :CongThucMau_Hb,
                            :CongThucMau_Tc,
                            :MauLang_1h,
                            :MauLang_2h,
                            :SinhHoa_Ure,
                            :SinhHoa_Choles,
                            :SinhHoa_Na,
                            :SinhHoa_Creatinin,
                            :SinhHoa_Trigly,
                            :SinhHoa_K,
                            :SinhHoa_Glucose,
                            :SinhHoa_Ldl,
                            :SinhHoa_Cl,
                            :SinhHoa_Uric,
                            :SinhHoa_Hdl,
                            :SinhHoa_Ast,
                            :SinhHoa_BiltP,
                            :SinhHoa_Pro,
                            :SinhHoa_ALT,
                            :SinhHoa_BiltT,
                            :SinhHoa_Alb,
                            :SinhHoa_Ck,
                            :SinhHoa_CrpHs,
                            :SinhHoa_CkMb,
                            :SinhHoa_Khac,
                            :NuocTieu_Protein,
                            :NuocTieu_ProteinNieu24h,
                            :NuocTieu_Hc,
                            :NuocTieu_Bc,
                            :NuocTieu_Khac,
                            :CNHH_FVC,
                            :CNHH_FEV1,
                            :CNHH_DuDoanFVC,
                            :CNHH_FEV1FVC,
                            :CNHH_DlCo,
                            :CNHH_DuDoanDlCo,
                            :XqTp,
                            :HrCt,
                            :SaOBung,
                            :DienTim_TanSo,
                            :DienTim_Nhip,
                            :DienTim_Truc,
                            :DiemTim_Khac,
                            :SaTimEF,
                            :SaTimPdmp,
                            :SaTim_Khac,
                            :KhangThe_Ana,
                            :KhangThe_Ana_Duong,
                            :KhangThe_Ana_Am,
                            :KhangThe_Anti155140,
                            :KhangThe_Anti155140_Duong,
                            :KhangThe_Anti155140_Am,
                            :KhangThe_AntiPMScl,
                            :KhangThe_AntiPMScl_Duong,
                            :KhangThe_AntiPMScl_Am,
                            :KhangThe_AntiARS,
                            :KhangThe_AntiARS_Duong,
                            :KhangThe_AntiARS_Am,
                            :KhangThe_AntiCadm,
                            :KhangThe_AntiCadm_Duong,
                            :KhangThe_AntiCadm_Am,
                            :KhangThe_Ku,
                            :KhangThe_Ku_Duong,
                            :KhangThe_Ku_Am,
                            :KhangThe_dsDNA,
                            :KhangThe_dsDNA_Duong,
                            :KhangThe_dsDNA_Am,
                            :KhangThe_AntiU1RNP,
                            :KhangThe_AntiU1RNP_Duong,
                            :KhangThe_AntiU1RNP_Am,
                            :KhangThe_TIF1,
                            :KhangThe_TIF1_Duong,
                            :KhangThe_TIF1_Am,
                            :KhangThe_AntiJ01,
                            :KhangThe_AntiJ01_Duong,
                            :KhangThe_AntiJ01_Am,
                            :KhangThe_AntiSRP,
                            :KhangThe_AntiSRP_Duong,
                            :KhangThe_AntiSRP_Am,
                            :KhangThe_antiNXP2,
                            :KhangThe_antiNXP2_Duong,
                            :KhangThe_antiNXP2_Am,
                            :KhangThe_AntiMi2,
                            :KhangThe_AntiMi2_Duong,
                            :KhangThe_AntiMi2_Am,
                            :KhangThe_AntiMDA5,
                            :KhangThe_AntiMDA5_Duong,
                            :KhangThe_AntiMDA5_Am,
                            :KhangThe_antiSAE,
                            :KhangThe_antiSAE_Duong,
                            :KhangThe_antiSAE_Am,
                            :KhangThe_Khac,
                            :KhamMat,
                            :DienCoKim,
                            :SinhThietCo,
                            :BohanPeter,
                            :Tanimoto,
                            :MotSoThe,
                            :MotSoThe_Khac,
                            :TS_Corticosteroid,
                            :TS_Cyclophosphamid,
                            :TS_CyclophosphamidLieuCao,
                            :TS_Azathioprine,
                            :TS_Methotrexate,
                            :TS_CyclosporineA,
                            :ThuocKhac,
                            :DieuTriHienTai,
                            :HenKham,
                            :BacSyDieuTri,
                            :MaBacSyDieuTri,
                            :TK_SoBenhAnDienTu,
                            :TK_SoLuuTru,
                            :NgayKham,
                            :NgayLuuHuyetThanh,
                            :BacSiKham,
                            :MaBacSiKham,
                            :TK_Sot,
                            :TK_Sot_Do,
                            :TK_MetMoi,
                            :TK_Mach,
                            :TK_HuyetAp,
                            :TK_HachTo,
                            :TK_HachTo_ViTri,
                            :TK_CoThemBenhGi,
                            :TK_DatDo,
                            :TK_DatDo_ViTri,
                            :TK_MauSac_ViTri,
                            :TK_RuouVang,
                            :TK_DoTuoi,
                            :TK_DoTham,
                            :TK_MatPhuNe,
                            :TK_BanHeliotrope,
                            :TK_VSign,
                            :TK_HoslterSign,
                            :TK_ShawlSign,
                            :TK_LangDongCanxiODa,
                            :TK_GottronSign_BanTay,
                            :TK_GottronSign_KhuyuTay,
                            :TK_GottronSign_DauGoi,
                            :TK_GottronPapules_BanTay,
                            :TK_GottronPapules_KhuyuTay,
                            :TK_GottronPapules_DauGoi,
                            :TK_GianMachQuanhMong,
                            :TK_XuatHuyetQuanhMong,
                            :TK_NutNeQuanhMong,
                            :TK_MichanicHand,
                            :TK_RamLongTrenNenDatDo,
                            :TK_RamLongTrenNenDatDo_ViTri,
                            :TK_HienTuongRaynaud,
                            :TK_DauHieuPoikiloderma,
                            :TK_DauHieuPoikiloderma_ViTri,
                            :TK_VetLoetTrenDa,
                            :TK_VetLoetTrenDa_ViTri,
                            :TK_DauCo,
                            :TK_DauCo_Diem,
                            :TK_DauCo_ViTri,
                            :TK_BopCo,
                            :TK_BopCo_ViTri,
                            :TK_YeuCo,
                            :TK_TeoCo,
                            :TK_CoGapCanhTay,
                            :TK_CoDuoiCanhTay,
                            :TK_CoGapDui,
                            :TK_CoDuoiDui,
                            :TK_DauKhop,
                            :TK_DauKhop_SoLuong,
                            :TK_DauKhop_ViTri,
                            :TK_SungKhop,
                            :TK_SungKhop_SoLuong,
                            :TK_SungKhop_ViTri,
                            :TK_BienDangKhop,
                            :TK_BienDangKhop_SoLuong,
                            :TK_BienDangKhop_ViTri,
                            :TK_KhoThoKhiGangSuc,
                            :TK_KhoThoKhiNghiNgoi,
                            :TK_HoKhanKeoDai,
                            :TK_RanPhoiDoiXung,
                            :TK_Phoi_Khac,
                            :TK_DanhTrongNguc,
                            :TK_NhipTim,
                            :TK_NhipTim_Khac,
                            :TK_DauHieuSuyTim,
                            :TK_DauHieuSuyTim_Co,
                            :TK_Tim_Khac,
                            :TK_NuotKhoNghenThucAnRan,
                            :TK_NuotKhoThucAnLongNuoc,
                            :TK_ONong,
                            :TK_ONongDauNguc,
                            :TK_DangChuaMieng,
                            :TK_NoiKhanDauViemHong,
                            :TK_HoKhiAn,
                            :TK_TaoBon,
                            :TK_TaoLongXenKe,
                            :TK_DuongTieuHoa_Khac,
                            :TK_CongThucMau_Bc,
                            :TK_CongThucMau_Tt,
                            :TK_CongThucMau_Lym,
                            :TK_CongThucMau_At,
                            :TK_CongThucMau_Hc,
                            :TK_CongThucMau_Hct,
                            :TK_CongThucMau_Hb,
                            :TK_CongThucMau_Tc,
                            :TK_MauLang_1h,
                            :TK_MauLang_2h,
                            :TK_SinhHoa_Ure,
                            :TK_SinhHoa_Choles,
                            :TK_SinhHoa_Na,
                            :TK_SinhHoa_Creatinin,
                            :TK_SinhHoa_Trigly,
                            :TK_SinhHoa_K,
                            :TK_SinhHoa_Glucose,
                            :TK_SinhHoa_Ldl,
                            :TK_SinhHoa_Cl,
                            :TK_SinhHoa_Uric,
                            :TK_SinhHoa_Hdl,
                            :TK_SinhHoa_Ast,
                            :TK_SinhHoa_BiltP,
                            :TK_SinhHoa_Pro,
                            :TK_SinhHoa_ALT,
                            :TK_SinhHoa_BiltT,
                            :TK_SinhHoa_Alb,
                            :TK_SinhHoa_Ck,
                            :TK_SinhHoa_CrpHs,
                            :TK_SinhHoa_CkMb,
                            :TK_SinhHoa_Khac,
                            :TK_NuocTieu_Protein,
                            :TK_NuocTieu_ProteinNieu24h,
                            :TK_NuocTieu_Hc,
                            :TK_NuocTieu_Bc,
                            :TK_NuocTieu_Khac,
                            :TK_CNHH_FVC,
                            :TK_CNHH_FEV1,
                            :TK_CNHH_DuDoanFVC,
                            :TK_CNHH_FEV1FVC,
                            :TK_CNHH_DlCo,
                            :TK_CNHH_DuDoanDlCo,
                            :TK_XqTp,
                            :TK_HrCt,
                            :TK_SaOBung,
                            :TK_DienTim_TanSo,
                            :TK_DienTim_Nhip,
                            :TK_DienTim_Truc,
                            :TK_DiemTim_Khac,
                            :TK_SaTimEF,
                            :TK_SaTimPdmp,
                            :TK_SaTim_Khac,
                            :TK_KhangThe_Ana,
                            :TK_KhangThe_Ana_Duong,
                            :TK_KhangThe_Ana_Am,
                            :TK_KhangThe_Anti155140,
                            :TK_KhangThe_Anti155140_Duong,
                            :TK_KhangThe_Anti155140_Am,
                            :TK_KhangThe_AntiPMScl,
                            :TK_KhangThe_AntiPMScl_Duong,
                            :TK_KhangThe_AntiPMScl_Am,
                            :TK_KhangThe_AntiARS,
                            :TK_KhangThe_AntiARS_Duong,
                            :TK_KhangThe_AntiARS_Am,
                            :TK_KhangThe_AntiCadm,
                            :TK_KhangThe_AntiCadm_Duong,
                            :TK_KhangThe_AntiCadm_Am,
                            :TK_KhangThe_Ku,
                            :TK_KhangThe_Ku_Duong,
                            :TK_KhangThe_Ku_Am,
                            :TK_KhangThe_dsDNA,
                            :TK_KhangThe_dsDNA_Duong,
                            :TK_KhangThe_dsDNA_Am,
                            :TK_KhangThe_AntiU1RNP,
                            :TK_KhangThe_AntiU1RNP_Duong,
                            :TK_KhangThe_AntiU1RNP_Am,
                            :TK_KhangThe_TIF1,
                            :TK_KhangThe_TIF1_Duong,
                            :TK_KhangThe_TIF1_Am,
                            :TK_KhangThe_AntiJ01,
                            :TK_KhangThe_AntiJ01_Duong,
                            :TK_KhangThe_AntiJ01_Am,
                            :TK_KhangThe_AntiSRP,
                            :TK_KhangThe_AntiSRP_Duong,
                            :TK_KhangThe_AntiSRP_Am,
                            :TK_KhangThe_antiNXP2,
                            :TK_KhangThe_antiNXP2_Duong,
                            :TK_KhangThe_antiNXP2_Am,
                            :TK_KhangThe_AntiMi2,
                            :TK_KhangThe_AntiMi2_Duong,
                            :TK_KhangThe_AntiMi2_Am,
                            :TK_KhangThe_AntiMDA5,
                            :TK_KhangThe_AntiMDA5_Duong,
                            :TK_KhangThe_AntiMDA5_Am,
                            :TK_KhangThe_antiSAE,
                            :TK_KhangThe_antiSAE_Duong,
                            :TK_KhangThe_antiSAE_Am,
                            :TK_KhangThe_Khac,
                            :TK_KhamMat,
                            :TK_ChuY,
                            :TK_DieuTri,
                            :TK_TacDungPhuCuaThuoc,
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
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnNgoaiTru_ViemBiCo.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriNgoaiTruTu", BenhAnNgoaiTru_ViemBiCo.DieuTriNgoaiTruTu));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriNgoaiTruDen", BenhAnNgoaiTru_ViemBiCo.DieuTriNgoaiTruDen));
                Command.Parameters.Add(new MDB.MDBParameter("SoCMND", BenhAnNgoaiTru_ViemBiCo.SoCMND));
                Command.Parameters.Add(new MDB.MDBParameter("BaoHiem", BenhAnNgoaiTru_ViemBiCo.BaoHiem));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan_TuyenTruoc", BenhAnNgoaiTru_ViemBiCo.ChanDoan_TuyenTruoc));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanBanDau", BenhAnNgoaiTru_ViemBiCo.ChanDoanBanDau));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham1", BenhAnNgoaiTru_ViemBiCo.ChanDoanTaiKham1));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham2", BenhAnNgoaiTru_ViemBiCo.ChanDoanTaiKham2));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham3", BenhAnNgoaiTru_ViemBiCo.ChanDoanTaiKham3));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham4", BenhAnNgoaiTru_ViemBiCo.ChanDoanTaiKham4));
                Command.Parameters.Add(new MDB.MDBParameter("BenhPhu", BenhAnNgoaiTru_ViemBiCo.BenhPhu));
                Command.Parameters.Add(new MDB.MDBParameter("KetQuaDieuTri", BenhAnNgoaiTru_ViemBiCo.KetQuaDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("BienChung_Text", BenhAnNgoaiTru_ViemBiCo.BienChung_Text));
                Command.Parameters.Add(new MDB.MDBParameter("GDPhongKeHoach", BenhAnNgoaiTru_ViemBiCo.GDPhongKeHoach));
                Command.Parameters.Add(new MDB.MDBParameter("GDPhongKhamBenh", BenhAnNgoaiTru_ViemBiCo.GDPhongKhamBenh));
                Command.Parameters.Add(new MDB.MDBParameter("Can", BenhAnNgoaiTru_ViemBiCo.Can));
                Command.Parameters.Add(new MDB.MDBParameter("GaySut_Kg", BenhAnNgoaiTru_ViemBiCo.GaySut_Kg));
                Command.Parameters.Add(new MDB.MDBParameter("GaySut_Thang", BenhAnNgoaiTru_ViemBiCo.GaySut_Thang));
                Command.Parameters.Add(new MDB.MDBParameter("GaySut_PhanTram", BenhAnNgoaiTru_ViemBiCo.GaySut_PhanTram));
                Command.Parameters.Add(new MDB.MDBParameter("Cao", BenhAnNgoaiTru_ViemBiCo.Cao));
                Command.Parameters.Add(new MDB.MDBParameter("TuoiKhoiPhat", BenhAnNgoaiTru_ViemBiCo.TuoiKhoiPhat));
                Command.Parameters.Add(new MDB.MDBParameter("TGTKKPB", BenhAnNgoaiTru_ViemBiCo.TGTKKPB));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungDauTien", BenhAnNgoaiTru_ViemBiCo.TrieuChungDauTien));
                Command.Parameters.Add(new MDB.MDBParameter("LupusBanDo", BenhAnNgoaiTru_ViemBiCo.LupusBanDo));
                Command.Parameters.Add(new MDB.MDBParameter("XoCungBi", BenhAnNgoaiTru_ViemBiCo.XoCungBi));
                Command.Parameters.Add(new MDB.MDBParameter("ViemKhopDangThap", BenhAnNgoaiTru_ViemBiCo.ViemKhopDangThap));
                Command.Parameters.Add(new MDB.MDBParameter("HoiChungSjogren", BenhAnNgoaiTru_ViemBiCo.HoiChungSjogren));
                Command.Parameters.Add(new MDB.MDBParameter("ViemBiCo", BenhAnNgoaiTru_ViemBiCo.ViemBiCo));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhTuMien_Khac", BenhAnNgoaiTru_ViemBiCo.TienSuBenhTuMien_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("TSCNBCBK_Text", BenhAnNgoaiTru_ViemBiCo.TSCNBCBK_Text));
                Command.Parameters.Add(new MDB.MDBParameter("TSCNBCBK", BenhAnNgoaiTru_ViemBiCo.TSCNBCBK));
                Command.Parameters.Add(new MDB.MDBParameter("TSGDCNBBTM", BenhAnNgoaiTru_ViemBiCo.TSGDCNBBTM));
                Command.Parameters.Add(new MDB.MDBParameter("TSGDCNBBTM_NeuCo", BenhAnNgoaiTru_ViemBiCo.TSGDCNBBTM_NeuCo));
                Command.Parameters.Add(new MDB.MDBParameter("BenhSu", BenhAnNgoaiTru_ViemBiCo.BenhSu));
                Command.Parameters.Add(new MDB.MDBParameter("ChuaDieuTri", BenhAnNgoaiTru_ViemBiCo.ChuaDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("Dpenicillamine", BenhAnNgoaiTru_ViemBiCo.Dpenicillamine));
                Command.Parameters.Add(new MDB.MDBParameter("Dpenicillamine_CachDung", BenhAnNgoaiTru_ViemBiCo.Dpenicillamine_CachDung));
                Command.Parameters.Add(new MDB.MDBParameter("Corticosteroid", BenhAnNgoaiTru_ViemBiCo.Corticosteroid));
                Command.Parameters.Add(new MDB.MDBParameter("Corticosteroid_CachDung", BenhAnNgoaiTru_ViemBiCo.Corticosteroid_CachDung));
                Command.Parameters.Add(new MDB.MDBParameter("Cyclophosphamide", BenhAnNgoaiTru_ViemBiCo.Cyclophosphamide));
                Command.Parameters.Add(new MDB.MDBParameter("Cyclophosphamide_CachDung", BenhAnNgoaiTru_ViemBiCo.Cyclophosphamide_CachDung));
                Command.Parameters.Add(new MDB.MDBParameter("Azathioprine", BenhAnNgoaiTru_ViemBiCo.Azathioprine));
                Command.Parameters.Add(new MDB.MDBParameter("Azathioprine_CachDung", BenhAnNgoaiTru_ViemBiCo.Azathioprine_CachDung));
                Command.Parameters.Add(new MDB.MDBParameter("Methotrexate", BenhAnNgoaiTru_ViemBiCo.Methotrexate));
                Command.Parameters.Add(new MDB.MDBParameter("Methotrexate_CachDung", BenhAnNgoaiTru_ViemBiCo.Methotrexate_CachDung));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocKha", BenhAnNgoaiTru_ViemBiCo.ThuocKha));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocKhac_CachDung", BenhAnNgoaiTru_ViemBiCo.ThuocKhac_CachDung));
                Command.Parameters.Add(new MDB.MDBParameter("TacDungPhuThuoc", BenhAnNgoaiTru_ViemBiCo.TacDungPhuThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("TacDungPhuThuoc_Co", BenhAnNgoaiTru_ViemBiCo.TacDungPhuThuoc_Co));
                Command.Parameters.Add(new MDB.MDBParameter("Sot", BenhAnNgoaiTru_ViemBiCo.Sot));
                Command.Parameters.Add(new MDB.MDBParameter("Sot_Do", BenhAnNgoaiTru_ViemBiCo.Sot_Do));
                Command.Parameters.Add(new MDB.MDBParameter("MetMoi", BenhAnNgoaiTru_ViemBiCo.MetMoi));
                Command.Parameters.Add(new MDB.MDBParameter("Mach", BenhAnNgoaiTru_ViemBiCo.Mach));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetAp", BenhAnNgoaiTru_ViemBiCo.HuyetAp));
                Command.Parameters.Add(new MDB.MDBParameter("HachTo", BenhAnNgoaiTru_ViemBiCo.HachTo));
                Command.Parameters.Add(new MDB.MDBParameter("HachTo_ViTri", BenhAnNgoaiTru_ViemBiCo.HachTo_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("DatDo", BenhAnNgoaiTru_ViemBiCo.DatDo));
                Command.Parameters.Add(new MDB.MDBParameter("DatDo_ViTri", BenhAnNgoaiTru_ViemBiCo.DatDo_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("MauSac_ViTri", BenhAnNgoaiTru_ViemBiCo.MauSac_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("RuouVang", BenhAnNgoaiTru_ViemBiCo.RuouVang));
                Command.Parameters.Add(new MDB.MDBParameter("DoTuoi", BenhAnNgoaiTru_ViemBiCo.DoTuoi));
                Command.Parameters.Add(new MDB.MDBParameter("DoTham", BenhAnNgoaiTru_ViemBiCo.DoTham));
                Command.Parameters.Add(new MDB.MDBParameter("MatPhuNe", BenhAnNgoaiTru_ViemBiCo.MatPhuNe));
                Command.Parameters.Add(new MDB.MDBParameter("BanHeliotrope", BenhAnNgoaiTru_ViemBiCo.BanHeliotrope));
                Command.Parameters.Add(new MDB.MDBParameter("VSign", BenhAnNgoaiTru_ViemBiCo.VSign));
                Command.Parameters.Add(new MDB.MDBParameter("HoslterSign", BenhAnNgoaiTru_ViemBiCo.HoslterSign));
                Command.Parameters.Add(new MDB.MDBParameter("ShawlSign", BenhAnNgoaiTru_ViemBiCo.ShawlSign));
                Command.Parameters.Add(new MDB.MDBParameter("LangDongCanxiODa", BenhAnNgoaiTru_ViemBiCo.LangDongCanxiODa));
                Command.Parameters.Add(new MDB.MDBParameter("GottronSign_BanTay", BenhAnNgoaiTru_ViemBiCo.GottronSign_BanTay));
                Command.Parameters.Add(new MDB.MDBParameter("GottronSign_KhuyuTay", BenhAnNgoaiTru_ViemBiCo.GottronSign_KhuyuTay));
                Command.Parameters.Add(new MDB.MDBParameter("GottronSign_DauGoi", BenhAnNgoaiTru_ViemBiCo.GottronSign_DauGoi));
                Command.Parameters.Add(new MDB.MDBParameter("GottronPapules_BanTay", BenhAnNgoaiTru_ViemBiCo.GottronPapules_BanTay));
                Command.Parameters.Add(new MDB.MDBParameter("GottronPapules_KhuyuTay", BenhAnNgoaiTru_ViemBiCo.GottronPapules_KhuyuTay));
                Command.Parameters.Add(new MDB.MDBParameter("GottronPapules_DauGoi", BenhAnNgoaiTru_ViemBiCo.GottronPapules_DauGoi));
                Command.Parameters.Add(new MDB.MDBParameter("GianMachQuanhMong", BenhAnNgoaiTru_ViemBiCo.GianMachQuanhMong));
                Command.Parameters.Add(new MDB.MDBParameter("XuatHuyetQuanhMong", BenhAnNgoaiTru_ViemBiCo.XuatHuyetQuanhMong));
                Command.Parameters.Add(new MDB.MDBParameter("NutNeQuanhMong", BenhAnNgoaiTru_ViemBiCo.NutNeQuanhMong));
                Command.Parameters.Add(new MDB.MDBParameter("MichanicHand", BenhAnNgoaiTru_ViemBiCo.MichanicHand));
                Command.Parameters.Add(new MDB.MDBParameter("RamLongTrenNenDatDo", BenhAnNgoaiTru_ViemBiCo.RamLongTrenNenDatDo));
                Command.Parameters.Add(new MDB.MDBParameter("RamLongTrenNenDatDo_ViTri", BenhAnNgoaiTru_ViemBiCo.RamLongTrenNenDatDo_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("HienTuongRaynaud", BenhAnNgoaiTru_ViemBiCo.HienTuongRaynaud));
                Command.Parameters.Add(new MDB.MDBParameter("DauHieuPoikiloderma", BenhAnNgoaiTru_ViemBiCo.DauHieuPoikiloderma));
                Command.Parameters.Add(new MDB.MDBParameter("DauHieuPoikiloderma_ViTri", BenhAnNgoaiTru_ViemBiCo.DauHieuPoikiloderma_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("VetLoetTrenDa", BenhAnNgoaiTru_ViemBiCo.VetLoetTrenDa));
                Command.Parameters.Add(new MDB.MDBParameter("VetLoetTrenDa_ViTri", BenhAnNgoaiTru_ViemBiCo.VetLoetTrenDa_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("LamSangDa_Khac", BenhAnNgoaiTru_ViemBiCo.LamSangDa_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("DauCo", BenhAnNgoaiTru_ViemBiCo.DauCo));
                Command.Parameters.Add(new MDB.MDBParameter("DauCo_Diem", BenhAnNgoaiTru_ViemBiCo.DauCo_Diem));
                Command.Parameters.Add(new MDB.MDBParameter("DauCo_ViTri", BenhAnNgoaiTru_ViemBiCo.DauCo_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("BopCo", BenhAnNgoaiTru_ViemBiCo.BopCo));
                Command.Parameters.Add(new MDB.MDBParameter("BopCo_ViTri", BenhAnNgoaiTru_ViemBiCo.BopCo_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("YeuCo", BenhAnNgoaiTru_ViemBiCo.YeuCo));
                Command.Parameters.Add(new MDB.MDBParameter("TeoCo", BenhAnNgoaiTru_ViemBiCo.TeoCo));
                Command.Parameters.Add(new MDB.MDBParameter("CoGapCanhTay", JsonConvert.SerializeObject(BenhAnNgoaiTru_ViemBiCo.CoGapCanhTay)));
                Command.Parameters.Add(new MDB.MDBParameter("CoDuoiCanhTay", JsonConvert.SerializeObject(BenhAnNgoaiTru_ViemBiCo.CoDuoiCanhTay)));
                Command.Parameters.Add(new MDB.MDBParameter("CoGapDui", JsonConvert.SerializeObject(BenhAnNgoaiTru_ViemBiCo.CoGapDui)));
                Command.Parameters.Add(new MDB.MDBParameter("CoDuoiDui", JsonConvert.SerializeObject(BenhAnNgoaiTru_ViemBiCo.CoDuoiDui)));
                Command.Parameters.Add(new MDB.MDBParameter("DauKhop", BenhAnNgoaiTru_ViemBiCo.DauKhop));
                Command.Parameters.Add(new MDB.MDBParameter("DauKhop_SoLuong", BenhAnNgoaiTru_ViemBiCo.DauKhop_SoLuong));
                Command.Parameters.Add(new MDB.MDBParameter("DauKhop_ViTri", BenhAnNgoaiTru_ViemBiCo.DauKhop_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("SungKhop", BenhAnNgoaiTru_ViemBiCo.SungKhop));
                Command.Parameters.Add(new MDB.MDBParameter("SungKhop_SoLuong", BenhAnNgoaiTru_ViemBiCo.SungKhop_SoLuong));
                Command.Parameters.Add(new MDB.MDBParameter("SungKhop_ViTri", BenhAnNgoaiTru_ViemBiCo.SungKhop_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("BienDangKhop", BenhAnNgoaiTru_ViemBiCo.BienDangKhop));
                Command.Parameters.Add(new MDB.MDBParameter("BienDangKhop_SoLuong", BenhAnNgoaiTru_ViemBiCo.BienDangKhop_SoLuong));
                Command.Parameters.Add(new MDB.MDBParameter("BienDangKhop_ViTri", BenhAnNgoaiTru_ViemBiCo.BienDangKhop_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("KhoThoKhiGangSuc", BenhAnNgoaiTru_ViemBiCo.KhoThoKhiGangSuc));
                Command.Parameters.Add(new MDB.MDBParameter("KhoThoKhiNghiNgoi", BenhAnNgoaiTru_ViemBiCo.KhoThoKhiNghiNgoi));
                Command.Parameters.Add(new MDB.MDBParameter("HoKhanKeoDai", BenhAnNgoaiTru_ViemBiCo.HoKhanKeoDai));
                Command.Parameters.Add(new MDB.MDBParameter("RanPhoiDoiXung", BenhAnNgoaiTru_ViemBiCo.RanPhoiDoiXung));
                Command.Parameters.Add(new MDB.MDBParameter("Phoi_Khac", BenhAnNgoaiTru_ViemBiCo.Phoi_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("DanhTrongNguc", BenhAnNgoaiTru_ViemBiCo.DanhTrongNguc));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTim", BenhAnNgoaiTru_ViemBiCo.NhipTim));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTim_Khac", BenhAnNgoaiTru_ViemBiCo.NhipTim_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("DauHieuSuyTim", BenhAnNgoaiTru_ViemBiCo.DauHieuSuyTim));
                Command.Parameters.Add(new MDB.MDBParameter("DauHieuSuyTim_Co", BenhAnNgoaiTru_ViemBiCo.DauHieuSuyTim_Co));
                Command.Parameters.Add(new MDB.MDBParameter("Tim_Khac", BenhAnNgoaiTru_ViemBiCo.Tim_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("NuotKhoNghenThucAnRan", BenhAnNgoaiTru_ViemBiCo.NuotKhoNghenThucAnRan));
                Command.Parameters.Add(new MDB.MDBParameter("NuotKhoThucAnLongNuoc", BenhAnNgoaiTru_ViemBiCo.NuotKhoThucAnLongNuoc));
                Command.Parameters.Add(new MDB.MDBParameter("ONong", BenhAnNgoaiTru_ViemBiCo.ONong));
                Command.Parameters.Add(new MDB.MDBParameter("ONongDauNguc", BenhAnNgoaiTru_ViemBiCo.ONongDauNguc));
                Command.Parameters.Add(new MDB.MDBParameter("DangChuaMieng", BenhAnNgoaiTru_ViemBiCo.DangChuaMieng));
                Command.Parameters.Add(new MDB.MDBParameter("NoiKhanDauViemHong", BenhAnNgoaiTru_ViemBiCo.NoiKhanDauViemHong));
                Command.Parameters.Add(new MDB.MDBParameter("HoKhiAn", BenhAnNgoaiTru_ViemBiCo.HoKhiAn));
                Command.Parameters.Add(new MDB.MDBParameter("TaoBon", BenhAnNgoaiTru_ViemBiCo.TaoBon));
                Command.Parameters.Add(new MDB.MDBParameter("TaoLongXenKe", BenhAnNgoaiTru_ViemBiCo.TaoLongXenKe));
                Command.Parameters.Add(new MDB.MDBParameter("DuongTieuHoa_Khac", BenhAnNgoaiTru_ViemBiCo.DuongTieuHoa_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("Phu", BenhAnNgoaiTru_ViemBiCo.Phu));
                Command.Parameters.Add(new MDB.MDBParameter("TieuIt", BenhAnNgoaiTru_ViemBiCo.TieuIt));
                Command.Parameters.Add(new MDB.MDBParameter("TieuMau", BenhAnNgoaiTru_ViemBiCo.TieuMau));
                Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieu_Khac", BenhAnNgoaiTru_ViemBiCo.ThanTietNieu_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("CongThucMau_Bc", BenhAnNgoaiTru_ViemBiCo.CongThucMau_Bc));
                Command.Parameters.Add(new MDB.MDBParameter("CongThucMau_Tt", BenhAnNgoaiTru_ViemBiCo.CongThucMau_Tt));
                Command.Parameters.Add(new MDB.MDBParameter("CongThucMau_Lym", BenhAnNgoaiTru_ViemBiCo.CongThucMau_Lym));
                Command.Parameters.Add(new MDB.MDBParameter("CongThucMau_At", BenhAnNgoaiTru_ViemBiCo.CongThucMau_At));
                Command.Parameters.Add(new MDB.MDBParameter("CongThucMau_Hc", BenhAnNgoaiTru_ViemBiCo.CongThucMau_Hc));
                Command.Parameters.Add(new MDB.MDBParameter("CongThucMau_Hct", BenhAnNgoaiTru_ViemBiCo.CongThucMau_Hct));
                Command.Parameters.Add(new MDB.MDBParameter("CongThucMau_Hb", BenhAnNgoaiTru_ViemBiCo.CongThucMau_Hb));
                Command.Parameters.Add(new MDB.MDBParameter("CongThucMau_Tc", BenhAnNgoaiTru_ViemBiCo.CongThucMau_Tc));
                Command.Parameters.Add(new MDB.MDBParameter("MauLang_1h", BenhAnNgoaiTru_ViemBiCo.MauLang_1h));
                Command.Parameters.Add(new MDB.MDBParameter("MauLang_2h", BenhAnNgoaiTru_ViemBiCo.MauLang_2h));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_Ure", BenhAnNgoaiTru_ViemBiCo.SinhHoa_Ure));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_Choles", BenhAnNgoaiTru_ViemBiCo.SinhHoa_Choles));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_Na", BenhAnNgoaiTru_ViemBiCo.SinhHoa_Na));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_Creatinin", BenhAnNgoaiTru_ViemBiCo.SinhHoa_Creatinin));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_Trigly", BenhAnNgoaiTru_ViemBiCo.SinhHoa_Trigly));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_K", BenhAnNgoaiTru_ViemBiCo.SinhHoa_K));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_Glucose", BenhAnNgoaiTru_ViemBiCo.SinhHoa_Glucose));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_Ldl", BenhAnNgoaiTru_ViemBiCo.SinhHoa_Ldl));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_Cl", BenhAnNgoaiTru_ViemBiCo.SinhHoa_Cl));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_Uric", BenhAnNgoaiTru_ViemBiCo.SinhHoa_Uric));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_Hdl", BenhAnNgoaiTru_ViemBiCo.SinhHoa_Hdl));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_Ast", BenhAnNgoaiTru_ViemBiCo.SinhHoa_Ast));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_BiltP", BenhAnNgoaiTru_ViemBiCo.SinhHoa_BiltP));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_Pro", BenhAnNgoaiTru_ViemBiCo.SinhHoa_Pro));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_ALT", BenhAnNgoaiTru_ViemBiCo.SinhHoa_ALT));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_BiltT", BenhAnNgoaiTru_ViemBiCo.SinhHoa_BiltT));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_Alb", BenhAnNgoaiTru_ViemBiCo.SinhHoa_Alb));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_Ck", BenhAnNgoaiTru_ViemBiCo.SinhHoa_Ck));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_CrpHs", BenhAnNgoaiTru_ViemBiCo.SinhHoa_CrpHs));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_CkMb", BenhAnNgoaiTru_ViemBiCo.SinhHoa_CkMb));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_Khac", BenhAnNgoaiTru_ViemBiCo.SinhHoa_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("NuocTieu_Protein", BenhAnNgoaiTru_ViemBiCo.NuocTieu_Protein));
                Command.Parameters.Add(new MDB.MDBParameter("NuocTieu_ProteinNieu24h", BenhAnNgoaiTru_ViemBiCo.NuocTieu_ProteinNieu24h));
                Command.Parameters.Add(new MDB.MDBParameter("NuocTieu_Hc", BenhAnNgoaiTru_ViemBiCo.NuocTieu_Hc));
                Command.Parameters.Add(new MDB.MDBParameter("NuocTieu_Bc", BenhAnNgoaiTru_ViemBiCo.NuocTieu_Bc));
                Command.Parameters.Add(new MDB.MDBParameter("NuocTieu_Khac", BenhAnNgoaiTru_ViemBiCo.NuocTieu_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("CNHH_FVC", BenhAnNgoaiTru_ViemBiCo.CNHH_FVC));
                Command.Parameters.Add(new MDB.MDBParameter("CNHH_FEV1", BenhAnNgoaiTru_ViemBiCo.CNHH_FEV1));
                Command.Parameters.Add(new MDB.MDBParameter("CNHH_DuDoanFVC", BenhAnNgoaiTru_ViemBiCo.CNHH_DuDoanFVC));
                Command.Parameters.Add(new MDB.MDBParameter("CNHH_FEV1FVC", BenhAnNgoaiTru_ViemBiCo.CNHH_FEV1FVC));
                Command.Parameters.Add(new MDB.MDBParameter("CNHH_DlCo", BenhAnNgoaiTru_ViemBiCo.CNHH_DlCo));
                Command.Parameters.Add(new MDB.MDBParameter("CNHH_DuDoanDlCo", BenhAnNgoaiTru_ViemBiCo.CNHH_DuDoanDlCo));
                Command.Parameters.Add(new MDB.MDBParameter("XqTp", BenhAnNgoaiTru_ViemBiCo.XqTp));
                Command.Parameters.Add(new MDB.MDBParameter("HrCt", BenhAnNgoaiTru_ViemBiCo.HrCt));
                Command.Parameters.Add(new MDB.MDBParameter("SaOBung", BenhAnNgoaiTru_ViemBiCo.SaOBung));
                Command.Parameters.Add(new MDB.MDBParameter("DienTim_TanSo", BenhAnNgoaiTru_ViemBiCo.DienTim_TanSo));
                Command.Parameters.Add(new MDB.MDBParameter("DienTim_Nhip", BenhAnNgoaiTru_ViemBiCo.DienTim_Nhip));
                Command.Parameters.Add(new MDB.MDBParameter("DienTim_Truc", BenhAnNgoaiTru_ViemBiCo.DienTim_Truc));
                Command.Parameters.Add(new MDB.MDBParameter("DiemTim_Khac", BenhAnNgoaiTru_ViemBiCo.DiemTim_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("SaTimEF", BenhAnNgoaiTru_ViemBiCo.SaTimEF));
                Command.Parameters.Add(new MDB.MDBParameter("SaTimPdmp", BenhAnNgoaiTru_ViemBiCo.SaTimPdmp));
                Command.Parameters.Add(new MDB.MDBParameter("SaTim_Khac", BenhAnNgoaiTru_ViemBiCo.SaTim_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_Ana", BenhAnNgoaiTru_ViemBiCo.KhangThe_Ana));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_Ana_Duong", BenhAnNgoaiTru_ViemBiCo.KhangThe_Ana_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_Ana_Am", BenhAnNgoaiTru_ViemBiCo.KhangThe_Ana_Am));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_Anti155140", BenhAnNgoaiTru_ViemBiCo.KhangThe_Anti155140));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_Anti155140_Duong", BenhAnNgoaiTru_ViemBiCo.KhangThe_Anti155140_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_Anti155140_Am", BenhAnNgoaiTru_ViemBiCo.KhangThe_Anti155140_Am));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_AntiPMScl", BenhAnNgoaiTru_ViemBiCo.KhangThe_AntiPMScl));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_AntiPMScl_Duong", BenhAnNgoaiTru_ViemBiCo.KhangThe_AntiPMScl_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_AntiPMScl_Am", BenhAnNgoaiTru_ViemBiCo.KhangThe_AntiPMScl_Am));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_AntiARS", BenhAnNgoaiTru_ViemBiCo.KhangThe_AntiARS));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_AntiARS_Duong", BenhAnNgoaiTru_ViemBiCo.KhangThe_AntiARS_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_AntiARS_Am", BenhAnNgoaiTru_ViemBiCo.KhangThe_AntiARS_Am));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_AntiCadm", BenhAnNgoaiTru_ViemBiCo.KhangThe_AntiCadm));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_AntiCadm_Duong", BenhAnNgoaiTru_ViemBiCo.KhangThe_AntiCadm_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_AntiCadm_Am", BenhAnNgoaiTru_ViemBiCo.KhangThe_AntiCadm_Am));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_Ku", BenhAnNgoaiTru_ViemBiCo.KhangThe_Ku));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_Ku_Duong", BenhAnNgoaiTru_ViemBiCo.KhangThe_Ku_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_Ku_Am", BenhAnNgoaiTru_ViemBiCo.KhangThe_Ku_Am));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_dsDNA", BenhAnNgoaiTru_ViemBiCo.KhangThe_dsDNA));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_dsDNA_Duong", BenhAnNgoaiTru_ViemBiCo.KhangThe_dsDNA_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_dsDNA_Am", BenhAnNgoaiTru_ViemBiCo.KhangThe_dsDNA_Am));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_AntiU1RNP", BenhAnNgoaiTru_ViemBiCo.KhangThe_AntiU1RNP));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_AntiU1RNP_Duong", BenhAnNgoaiTru_ViemBiCo.KhangThe_AntiU1RNP_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_AntiU1RNP_Am", BenhAnNgoaiTru_ViemBiCo.KhangThe_AntiU1RNP_Am));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_TIF1", BenhAnNgoaiTru_ViemBiCo.KhangThe_TIF1));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_TIF1_Duong", BenhAnNgoaiTru_ViemBiCo.KhangThe_TIF1_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_TIF1_Am", BenhAnNgoaiTru_ViemBiCo.KhangThe_TIF1_Am));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_AntiJ01", BenhAnNgoaiTru_ViemBiCo.KhangThe_AntiJ01));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_AntiJ01_Duong", BenhAnNgoaiTru_ViemBiCo.KhangThe_AntiJ01_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_AntiJ01_Am", BenhAnNgoaiTru_ViemBiCo.KhangThe_AntiJ01_Am));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_AntiSRP", BenhAnNgoaiTru_ViemBiCo.KhangThe_AntiSRP));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_AntiSRP_Duong", BenhAnNgoaiTru_ViemBiCo.KhangThe_AntiSRP_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_AntiSRP_Am", BenhAnNgoaiTru_ViemBiCo.KhangThe_AntiSRP_Am));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_antiNXP2", BenhAnNgoaiTru_ViemBiCo.KhangThe_antiNXP2));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_antiNXP2_Duong", BenhAnNgoaiTru_ViemBiCo.KhangThe_antiNXP2_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_antiNXP2_Am", BenhAnNgoaiTru_ViemBiCo.KhangThe_antiNXP2_Am));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_AntiMi2", BenhAnNgoaiTru_ViemBiCo.KhangThe_AntiMi2));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_AntiMi2_Duong", BenhAnNgoaiTru_ViemBiCo.KhangThe_AntiMi2_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_AntiMi2_Am", BenhAnNgoaiTru_ViemBiCo.KhangThe_AntiMi2_Am));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_AntiMDA5", BenhAnNgoaiTru_ViemBiCo.KhangThe_AntiMDA5));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_AntiMDA5_Duong", BenhAnNgoaiTru_ViemBiCo.KhangThe_AntiMDA5_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_AntiMDA5_Am", BenhAnNgoaiTru_ViemBiCo.KhangThe_AntiMDA5_Am));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_antiSAE", BenhAnNgoaiTru_ViemBiCo.KhangThe_antiSAE));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_antiSAE_Duong", BenhAnNgoaiTru_ViemBiCo.KhangThe_antiSAE_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_antiSAE_Am", BenhAnNgoaiTru_ViemBiCo.KhangThe_antiSAE_Am));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_Khac", BenhAnNgoaiTru_ViemBiCo.KhangThe_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("KhamMat", BenhAnNgoaiTru_ViemBiCo.KhamMat));
                Command.Parameters.Add(new MDB.MDBParameter("DienCoKim", BenhAnNgoaiTru_ViemBiCo.DienCoKim));
                Command.Parameters.Add(new MDB.MDBParameter("SinhThietCo", BenhAnNgoaiTru_ViemBiCo.SinhThietCo));
                Command.Parameters.Add(new MDB.MDBParameter("BohanPeter", BenhAnNgoaiTru_ViemBiCo.BohanPeter));
                Command.Parameters.Add(new MDB.MDBParameter("Tanimoto", BenhAnNgoaiTru_ViemBiCo.Tanimoto));
                Command.Parameters.Add(new MDB.MDBParameter("MotSoThe", BenhAnNgoaiTru_ViemBiCo.MotSoThe));
                Command.Parameters.Add(new MDB.MDBParameter("MotSoThe_Khac", BenhAnNgoaiTru_ViemBiCo.MotSoThe_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("TS_Corticosteroid", JsonConvert.SerializeObject(BenhAnNgoaiTru_ViemBiCo.TS_Corticosteroid)));
                Command.Parameters.Add(new MDB.MDBParameter("TS_Cyclophosphamid", JsonConvert.SerializeObject(BenhAnNgoaiTru_ViemBiCo.TS_Cyclophosphamid)));
                Command.Parameters.Add(new MDB.MDBParameter("TS_CyclophosphamidLieuCao", JsonConvert.SerializeObject(BenhAnNgoaiTru_ViemBiCo.TS_CyclophosphamidLieuCao)));
                Command.Parameters.Add(new MDB.MDBParameter("TS_Azathioprine", JsonConvert.SerializeObject(BenhAnNgoaiTru_ViemBiCo.TS_Azathioprine)));
                Command.Parameters.Add(new MDB.MDBParameter("TS_Methotrexate", JsonConvert.SerializeObject(BenhAnNgoaiTru_ViemBiCo.TS_Methotrexate)));
                Command.Parameters.Add(new MDB.MDBParameter("TS_CyclosporineA", JsonConvert.SerializeObject(BenhAnNgoaiTru_ViemBiCo.TS_CyclosporineA)));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocKhac", BenhAnNgoaiTru_ViemBiCo.ThuocKhac));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriHienTai", BenhAnNgoaiTru_ViemBiCo.DieuTriHienTai));
                Command.Parameters.Add(new MDB.MDBParameter("HenKham", BenhAnNgoaiTru_ViemBiCo.HenKham));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnNgoaiTru_ViemBiCo.BacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSyDieuTri", BenhAnNgoaiTru_ViemBiCo.MaBacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SoBenhAnDienTu", BenhAnNgoaiTru_ViemBiCo.TK_SoBenhAnDienTu));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SoLuuTru", BenhAnNgoaiTru_ViemBiCo.TK_SoLuuTru));
                Command.Parameters.Add(new MDB.MDBParameter("NgayKham", BenhAnNgoaiTru_ViemBiCo.NgayKham));
                Command.Parameters.Add(new MDB.MDBParameter("NgayLuuHuyetThanh", BenhAnNgoaiTru_ViemBiCo.NgayLuuHuyetThanh));
                Command.Parameters.Add(new MDB.MDBParameter("BacSiKham", BenhAnNgoaiTru_ViemBiCo.BacSiKham));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSiKham", BenhAnNgoaiTru_ViemBiCo.MaBacSiKham));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Sot", BenhAnNgoaiTru_ViemBiCo.TK_Sot));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Sot_Do", BenhAnNgoaiTru_ViemBiCo.TK_Sot_Do));
                Command.Parameters.Add(new MDB.MDBParameter("TK_MetMoi", BenhAnNgoaiTru_ViemBiCo.TK_MetMoi));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Mach", BenhAnNgoaiTru_ViemBiCo.TK_Mach));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HuyetAp", BenhAnNgoaiTru_ViemBiCo.TK_HuyetAp));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HachTo", BenhAnNgoaiTru_ViemBiCo.TK_HachTo));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HachTo_ViTri", BenhAnNgoaiTru_ViemBiCo.TK_HachTo_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_CoThemBenhGi", BenhAnNgoaiTru_ViemBiCo.TK_CoThemBenhGi));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DatDo", BenhAnNgoaiTru_ViemBiCo.TK_DatDo));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DatDo_ViTri", BenhAnNgoaiTru_ViemBiCo.TK_DatDo_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_MauSac_ViTri", BenhAnNgoaiTru_ViemBiCo.TK_MauSac_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_RuouVang", BenhAnNgoaiTru_ViemBiCo.TK_RuouVang));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DoTuoi", BenhAnNgoaiTru_ViemBiCo.TK_DoTuoi));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DoTham", BenhAnNgoaiTru_ViemBiCo.TK_DoTham));
                Command.Parameters.Add(new MDB.MDBParameter("TK_MatPhuNe", BenhAnNgoaiTru_ViemBiCo.TK_MatPhuNe));
                Command.Parameters.Add(new MDB.MDBParameter("TK_BanHeliotrope", BenhAnNgoaiTru_ViemBiCo.TK_BanHeliotrope));
                Command.Parameters.Add(new MDB.MDBParameter("TK_VSign", BenhAnNgoaiTru_ViemBiCo.TK_VSign));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HoslterSign", BenhAnNgoaiTru_ViemBiCo.TK_HoslterSign));
                Command.Parameters.Add(new MDB.MDBParameter("TK_ShawlSign", BenhAnNgoaiTru_ViemBiCo.TK_ShawlSign));
                Command.Parameters.Add(new MDB.MDBParameter("TK_LangDongCanxiODa", BenhAnNgoaiTru_ViemBiCo.TK_LangDongCanxiODa));
                Command.Parameters.Add(new MDB.MDBParameter("TK_GottronSign_BanTay", BenhAnNgoaiTru_ViemBiCo.TK_GottronSign_BanTay));
                Command.Parameters.Add(new MDB.MDBParameter("TK_GottronSign_KhuyuTay", BenhAnNgoaiTru_ViemBiCo.TK_GottronSign_KhuyuTay));
                Command.Parameters.Add(new MDB.MDBParameter("TK_GottronSign_DauGoi", BenhAnNgoaiTru_ViemBiCo.TK_GottronSign_DauGoi));
                Command.Parameters.Add(new MDB.MDBParameter("TK_GottronPapules_BanTay", BenhAnNgoaiTru_ViemBiCo.TK_GottronPapules_BanTay));
                Command.Parameters.Add(new MDB.MDBParameter("TK_GottronPapules_KhuyuTay", BenhAnNgoaiTru_ViemBiCo.TK_GottronPapules_KhuyuTay));
                Command.Parameters.Add(new MDB.MDBParameter("TK_GottronPapules_DauGoi", BenhAnNgoaiTru_ViemBiCo.TK_GottronPapules_DauGoi));
                Command.Parameters.Add(new MDB.MDBParameter("TK_GianMachQuanhMong", BenhAnNgoaiTru_ViemBiCo.TK_GianMachQuanhMong));
                Command.Parameters.Add(new MDB.MDBParameter("TK_XuatHuyetQuanhMong", BenhAnNgoaiTru_ViemBiCo.TK_XuatHuyetQuanhMong));
                Command.Parameters.Add(new MDB.MDBParameter("TK_NutNeQuanhMong", BenhAnNgoaiTru_ViemBiCo.TK_NutNeQuanhMong));
                Command.Parameters.Add(new MDB.MDBParameter("TK_MichanicHand", BenhAnNgoaiTru_ViemBiCo.TK_MichanicHand));
                Command.Parameters.Add(new MDB.MDBParameter("TK_RamLongTrenNenDatDo", BenhAnNgoaiTru_ViemBiCo.TK_RamLongTrenNenDatDo));
                Command.Parameters.Add(new MDB.MDBParameter("TK_RamLongTrenNenDatDo_ViTri", BenhAnNgoaiTru_ViemBiCo.TK_RamLongTrenNenDatDo_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HienTuongRaynaud", BenhAnNgoaiTru_ViemBiCo.TK_HienTuongRaynaud));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DauHieuPoikiloderma", BenhAnNgoaiTru_ViemBiCo.TK_DauHieuPoikiloderma));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DauHieuPoikiloderma_ViTri", BenhAnNgoaiTru_ViemBiCo.TK_DauHieuPoikiloderma_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_VetLoetTrenDa", BenhAnNgoaiTru_ViemBiCo.TK_VetLoetTrenDa));
                Command.Parameters.Add(new MDB.MDBParameter("TK_VetLoetTrenDa_ViTri", BenhAnNgoaiTru_ViemBiCo.TK_VetLoetTrenDa_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DauCo", BenhAnNgoaiTru_ViemBiCo.TK_DauCo));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DauCo_Diem", BenhAnNgoaiTru_ViemBiCo.TK_DauCo_Diem));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DauCo_ViTri", BenhAnNgoaiTru_ViemBiCo.TK_DauCo_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_BopCo", BenhAnNgoaiTru_ViemBiCo.TK_BopCo));
                Command.Parameters.Add(new MDB.MDBParameter("TK_BopCo_ViTri", BenhAnNgoaiTru_ViemBiCo.TK_BopCo_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_YeuCo", BenhAnNgoaiTru_ViemBiCo.TK_YeuCo));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TeoCo", BenhAnNgoaiTru_ViemBiCo.TK_TeoCo));
                Command.Parameters.Add(new MDB.MDBParameter("TK_CoGapCanhTay", JsonConvert.SerializeObject(BenhAnNgoaiTru_ViemBiCo.TK_CoGapCanhTay)));
                Command.Parameters.Add(new MDB.MDBParameter("TK_CoDuoiCanhTay", JsonConvert.SerializeObject(BenhAnNgoaiTru_ViemBiCo.TK_CoDuoiCanhTay)));
                Command.Parameters.Add(new MDB.MDBParameter("TK_CoGapDui", JsonConvert.SerializeObject(BenhAnNgoaiTru_ViemBiCo.TK_CoGapDui)));
                Command.Parameters.Add(new MDB.MDBParameter("TK_CoDuoiDui", JsonConvert.SerializeObject(BenhAnNgoaiTru_ViemBiCo.TK_CoDuoiDui)));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DauKhop", BenhAnNgoaiTru_ViemBiCo.TK_DauKhop));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DauKhop_SoLuong", BenhAnNgoaiTru_ViemBiCo.TK_DauKhop_SoLuong));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DauKhop_ViTri", BenhAnNgoaiTru_ViemBiCo.TK_DauKhop_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SungKhop", BenhAnNgoaiTru_ViemBiCo.TK_SungKhop));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SungKhop_SoLuong", BenhAnNgoaiTru_ViemBiCo.TK_SungKhop_SoLuong));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SungKhop_ViTri", BenhAnNgoaiTru_ViemBiCo.TK_SungKhop_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_BienDangKhop", BenhAnNgoaiTru_ViemBiCo.TK_BienDangKhop));
                Command.Parameters.Add(new MDB.MDBParameter("TK_BienDangKhop_SoLuong", BenhAnNgoaiTru_ViemBiCo.TK_BienDangKhop_SoLuong));
                Command.Parameters.Add(new MDB.MDBParameter("TK_BienDangKhop_ViTri", BenhAnNgoaiTru_ViemBiCo.TK_BienDangKhop_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhoThoKhiGangSuc", BenhAnNgoaiTru_ViemBiCo.TK_KhoThoKhiGangSuc));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhoThoKhiNghiNgoi", BenhAnNgoaiTru_ViemBiCo.TK_KhoThoKhiNghiNgoi));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HoKhanKeoDai", BenhAnNgoaiTru_ViemBiCo.TK_HoKhanKeoDai));
                Command.Parameters.Add(new MDB.MDBParameter("TK_RanPhoiDoiXung", BenhAnNgoaiTru_ViemBiCo.TK_RanPhoiDoiXung));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Phoi_Khac", BenhAnNgoaiTru_ViemBiCo.TK_Phoi_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DanhTrongNguc", BenhAnNgoaiTru_ViemBiCo.TK_DanhTrongNguc));
                Command.Parameters.Add(new MDB.MDBParameter("TK_NhipTim", BenhAnNgoaiTru_ViemBiCo.TK_NhipTim));
                Command.Parameters.Add(new MDB.MDBParameter("TK_NhipTim_Khac", BenhAnNgoaiTru_ViemBiCo.TK_NhipTim_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DauHieuSuyTim", BenhAnNgoaiTru_ViemBiCo.TK_DauHieuSuyTim));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DauHieuSuyTim_Co", BenhAnNgoaiTru_ViemBiCo.TK_DauHieuSuyTim_Co));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Tim_Khac", BenhAnNgoaiTru_ViemBiCo.TK_Tim_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("TK_NuotKhoNghenThucAnRan", BenhAnNgoaiTru_ViemBiCo.TK_NuotKhoNghenThucAnRan));
                Command.Parameters.Add(new MDB.MDBParameter("TK_NuotKhoThucAnLongNuoc", BenhAnNgoaiTru_ViemBiCo.TK_NuotKhoThucAnLongNuoc));
                Command.Parameters.Add(new MDB.MDBParameter("TK_ONong", BenhAnNgoaiTru_ViemBiCo.TK_ONong));
                Command.Parameters.Add(new MDB.MDBParameter("TK_ONongDauNguc", BenhAnNgoaiTru_ViemBiCo.TK_ONongDauNguc));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DangChuaMieng", BenhAnNgoaiTru_ViemBiCo.TK_DangChuaMieng));
                Command.Parameters.Add(new MDB.MDBParameter("TK_NoiKhanDauViemHong", BenhAnNgoaiTru_ViemBiCo.TK_NoiKhanDauViemHong));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HoKhiAn", BenhAnNgoaiTru_ViemBiCo.TK_HoKhiAn));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TaoBon", BenhAnNgoaiTru_ViemBiCo.TK_TaoBon));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TaoLongXenKe", BenhAnNgoaiTru_ViemBiCo.TK_TaoLongXenKe));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DuongTieuHoa_Khac", BenhAnNgoaiTru_ViemBiCo.TK_DuongTieuHoa_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("TK_CongThucMau_Bc", BenhAnNgoaiTru_ViemBiCo.TK_CongThucMau_Bc));
                Command.Parameters.Add(new MDB.MDBParameter("TK_CongThucMau_Tt", BenhAnNgoaiTru_ViemBiCo.TK_CongThucMau_Tt));
                Command.Parameters.Add(new MDB.MDBParameter("TK_CongThucMau_Lym", BenhAnNgoaiTru_ViemBiCo.TK_CongThucMau_Lym));
                Command.Parameters.Add(new MDB.MDBParameter("TK_CongThucMau_At", BenhAnNgoaiTru_ViemBiCo.TK_CongThucMau_At));
                Command.Parameters.Add(new MDB.MDBParameter("TK_CongThucMau_Hc", BenhAnNgoaiTru_ViemBiCo.TK_CongThucMau_Hc));
                Command.Parameters.Add(new MDB.MDBParameter("TK_CongThucMau_Hct", BenhAnNgoaiTru_ViemBiCo.TK_CongThucMau_Hct));
                Command.Parameters.Add(new MDB.MDBParameter("TK_CongThucMau_Hb", BenhAnNgoaiTru_ViemBiCo.TK_CongThucMau_Hb));
                Command.Parameters.Add(new MDB.MDBParameter("TK_CongThucMau_Tc", BenhAnNgoaiTru_ViemBiCo.TK_CongThucMau_Tc));
                Command.Parameters.Add(new MDB.MDBParameter("TK_MauLang_1h", BenhAnNgoaiTru_ViemBiCo.TK_MauLang_1h));
                Command.Parameters.Add(new MDB.MDBParameter("TK_MauLang_2h", BenhAnNgoaiTru_ViemBiCo.TK_MauLang_2h));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_Ure", BenhAnNgoaiTru_ViemBiCo.TK_SinhHoa_Ure));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_Choles", BenhAnNgoaiTru_ViemBiCo.TK_SinhHoa_Choles));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_Na", BenhAnNgoaiTru_ViemBiCo.TK_SinhHoa_Na));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_Creatinin", BenhAnNgoaiTru_ViemBiCo.TK_SinhHoa_Creatinin));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_Trigly", BenhAnNgoaiTru_ViemBiCo.TK_SinhHoa_Trigly));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_K", BenhAnNgoaiTru_ViemBiCo.TK_SinhHoa_K));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_Glucose", BenhAnNgoaiTru_ViemBiCo.TK_SinhHoa_Glucose));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_Ldl", BenhAnNgoaiTru_ViemBiCo.TK_SinhHoa_Ldl));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_Cl", BenhAnNgoaiTru_ViemBiCo.TK_SinhHoa_Cl));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_Uric", BenhAnNgoaiTru_ViemBiCo.TK_SinhHoa_Uric));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_Hdl", BenhAnNgoaiTru_ViemBiCo.TK_SinhHoa_Hdl));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_Ast", BenhAnNgoaiTru_ViemBiCo.TK_SinhHoa_Ast));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_BiltP", BenhAnNgoaiTru_ViemBiCo.TK_SinhHoa_BiltP));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_Pro", BenhAnNgoaiTru_ViemBiCo.TK_SinhHoa_Pro));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_ALT", BenhAnNgoaiTru_ViemBiCo.TK_SinhHoa_ALT));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_BiltT", BenhAnNgoaiTru_ViemBiCo.TK_SinhHoa_BiltT));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_Alb", BenhAnNgoaiTru_ViemBiCo.TK_SinhHoa_Alb));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_Ck", BenhAnNgoaiTru_ViemBiCo.TK_SinhHoa_Ck));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_CrpHs", BenhAnNgoaiTru_ViemBiCo.TK_SinhHoa_CrpHs));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_CkMb", BenhAnNgoaiTru_ViemBiCo.TK_SinhHoa_CkMb));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_Khac", BenhAnNgoaiTru_ViemBiCo.TK_SinhHoa_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("TK_NuocTieu_Protein", BenhAnNgoaiTru_ViemBiCo.TK_NuocTieu_Protein));
                Command.Parameters.Add(new MDB.MDBParameter("TK_NuocTieu_ProteinNieu24h", BenhAnNgoaiTru_ViemBiCo.TK_NuocTieu_ProteinNieu24h));
                Command.Parameters.Add(new MDB.MDBParameter("TK_NuocTieu_Hc", BenhAnNgoaiTru_ViemBiCo.TK_NuocTieu_Hc));
                Command.Parameters.Add(new MDB.MDBParameter("TK_NuocTieu_Bc", BenhAnNgoaiTru_ViemBiCo.TK_NuocTieu_Bc));
                Command.Parameters.Add(new MDB.MDBParameter("TK_NuocTieu_Khac", BenhAnNgoaiTru_ViemBiCo.TK_NuocTieu_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("TK_CNHH_FVC", BenhAnNgoaiTru_ViemBiCo.TK_CNHH_FVC));
                Command.Parameters.Add(new MDB.MDBParameter("TK_CNHH_FEV1", BenhAnNgoaiTru_ViemBiCo.TK_CNHH_FEV1));
                Command.Parameters.Add(new MDB.MDBParameter("TK_CNHH_DuDoanFVC", BenhAnNgoaiTru_ViemBiCo.TK_CNHH_DuDoanFVC));
                Command.Parameters.Add(new MDB.MDBParameter("TK_CNHH_FEV1FVC", BenhAnNgoaiTru_ViemBiCo.TK_CNHH_FEV1FVC));
                Command.Parameters.Add(new MDB.MDBParameter("TK_CNHH_DlCo", BenhAnNgoaiTru_ViemBiCo.TK_CNHH_DlCo));
                Command.Parameters.Add(new MDB.MDBParameter("TK_CNHH_DuDoanDlCo", BenhAnNgoaiTru_ViemBiCo.TK_CNHH_DuDoanDlCo));
                Command.Parameters.Add(new MDB.MDBParameter("TK_XqTp", BenhAnNgoaiTru_ViemBiCo.TK_XqTp));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HrCt", BenhAnNgoaiTru_ViemBiCo.TK_HrCt));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SaOBung", BenhAnNgoaiTru_ViemBiCo.TK_SaOBung));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DienTim_TanSo", BenhAnNgoaiTru_ViemBiCo.TK_DienTim_TanSo));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DienTim_Nhip", BenhAnNgoaiTru_ViemBiCo.TK_DienTim_Nhip));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DienTim_Truc", BenhAnNgoaiTru_ViemBiCo.TK_DienTim_Truc));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DiemTim_Khac", BenhAnNgoaiTru_ViemBiCo.TK_DiemTim_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SaTimEF", BenhAnNgoaiTru_ViemBiCo.TK_SaTimEF));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SaTimPdmp", BenhAnNgoaiTru_ViemBiCo.TK_SaTimPdmp));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SaTim_Khac", BenhAnNgoaiTru_ViemBiCo.TK_SaTim_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_Ana", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_Ana));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_Ana_Duong", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_Ana_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_Ana_Am", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_Ana_Am));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_Anti155140", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_Anti155140));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_Anti155140_Duong", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_Anti155140_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_Anti155140_Am", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_Anti155140_Am));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_AntiPMScl", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_AntiPMScl));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_AntiPMScl_Duong", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_AntiPMScl_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_AntiPMScl_Am", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_AntiPMScl_Am));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_AntiARS", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_AntiARS));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_AntiARS_Duong", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_AntiARS_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_AntiARS_Am", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_AntiARS_Am));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_AntiCadm", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_AntiCadm));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_AntiCadm_Duong", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_AntiCadm_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_AntiCadm_Am", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_AntiCadm_Am));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_Ku", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_Ku));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_Ku_Duong", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_Ku_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_Ku_Am", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_Ku_Am));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_dsDNA", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_dsDNA));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_dsDNA_Duong", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_dsDNA_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_dsDNA_Am", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_dsDNA_Am));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_AntiU1RNP", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_AntiU1RNP));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_AntiU1RNP_Duong", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_AntiU1RNP_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_AntiU1RNP_Am", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_AntiU1RNP_Am));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_TIF1", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_TIF1));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_TIF1_Duong", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_TIF1_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_TIF1_Am", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_TIF1_Am));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_AntiJ01", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_AntiJ01));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_AntiJ01_Duong", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_AntiJ01_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_AntiJ01_Am", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_AntiJ01_Am));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_AntiSRP", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_AntiSRP));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_AntiSRP_Duong", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_AntiSRP_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_AntiSRP_Am", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_AntiSRP_Am));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_antiNXP2", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_antiNXP2));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_antiNXP2_Duong", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_antiNXP2_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_antiNXP2_Am", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_antiNXP2_Am));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_AntiMi2", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_AntiMi2));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_AntiMi2_Duong", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_AntiMi2_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_AntiMi2_Am", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_AntiMi2_Am));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_AntiMDA5", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_AntiMDA5));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_AntiMDA5_Duong", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_AntiMDA5_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_AntiMDA5_Am", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_AntiMDA5_Am));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_antiSAE", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_antiSAE));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_antiSAE_Duong", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_antiSAE_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_antiSAE_Am", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_antiSAE_Am));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_Khac", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhamMat", BenhAnNgoaiTru_ViemBiCo.TK_KhamMat));
                Command.Parameters.Add(new MDB.MDBParameter("TK_ChuY", BenhAnNgoaiTru_ViemBiCo.TK_ChuY));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DieuTri", BenhAnNgoaiTru_ViemBiCo.TK_DieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TacDungPhuCuaThuoc", BenhAnNgoaiTru_ViemBiCo.TK_TacDungPhuCuaThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HenKham", BenhAnNgoaiTru_ViemBiCo.TK_HenKham));
                Command.Parameters.Add(new MDB.MDBParameter("TK_BacSiDieuTri", BenhAnNgoaiTru_ViemBiCo.TK_BacSiDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_MaBacSiDieuTri", BenhAnNgoaiTru_ViemBiCo.TK_MaBacSiDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnNgoaiTru_ViemBiCo.QuaTrinhBenhLy));
                Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQua", BenhAnNgoaiTru_ViemBiCo.TomTatKetQua));
                Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnNgoaiTru_ViemBiCo.BenhChinh));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhChinh", BenhAnNgoaiTru_ViemBiCo.MaBenhChinh));
                Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnNgoaiTru_ViemBiCo.BenhKemTheo));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhKemTheo", BenhAnNgoaiTru_ViemBiCo.MaBenhKemTheo));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnNgoaiTru_ViemBiCo.PhuongPhapDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangRaVien", BenhAnNgoaiTru_ViemBiCo.TinhTrangRaVien));
                Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnNgoaiTru_ViemBiCo.HuongDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnNgoaiTru_ViemBiCo.NguoiNhanHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnNgoaiTru_ViemBiCo.NguoiGiaoHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnNgoaiTru_ViemBiCo.NgayTongKet));
                Command.Parameters.Add(new MDB.MDBParameter("TongKet_BacSyDieuTri", BenhAnNgoaiTru_ViemBiCo.TongKet_BacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TongKet_MaBacSyDieuTri", BenhAnNgoaiTru_ViemBiCo.TongKet_MaBacSyDieuTri));

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
        public static bool Update(MDB.MDBConnection MyConnection, BenhAnNgoaiTru_ViemBiCo BenhAnNgoaiTru_ViemBiCo)
        {
            try { 
                string sql = @"UPDATE BenhAnViemBiCo SET 
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
                            GaySut_Kg=:GaySut_Kg,
                            GaySut_Thang=:GaySut_Thang,
                            GaySut_PhanTram=:GaySut_PhanTram,
                            Cao=:Cao,
                            TuoiKhoiPhat=:TuoiKhoiPhat,
                            TGTKKPB=:TGTKKPB,
                            TrieuChungDauTien=:TrieuChungDauTien,
                            LupusBanDo=:LupusBanDo,
                            XoCungBi=:XoCungBi,
                            ViemKhopDangThap=:ViemKhopDangThap,
                            HoiChungSjogren=:HoiChungSjogren,
                            ViemBiCo=:ViemBiCo,
                            TienSuBenhTuMien_Khac=:TienSuBenhTuMien_Khac,
                            TSCNBCBK_Text=:TSCNBCBK_Text,
                            TSCNBCBK=:TSCNBCBK,
                            TSGDCNBBTM=:TSGDCNBBTM,
                            TSGDCNBBTM_NeuCo=:TSGDCNBBTM_NeuCo,
                            BenhSu=:BenhSu,
                            ChuaDieuTri=:ChuaDieuTri,
                            Dpenicillamine=:Dpenicillamine,
                            Dpenicillamine_CachDung=:Dpenicillamine_CachDung,
                            Corticosteroid=:Corticosteroid,
                            Corticosteroid_CachDung=:Corticosteroid_CachDung,
                            Cyclophosphamide=:Cyclophosphamide,
                            Cyclophosphamide_CachDung=:Cyclophosphamide_CachDung,
                            Azathioprine=:Azathioprine,
                            Azathioprine_CachDung=:Azathioprine_CachDung,
                            Methotrexate=:Methotrexate,
                            Methotrexate_CachDung=:Methotrexate_CachDung,
                            ThuocKha=:ThuocKha,
                            ThuocKhac_CachDung=:ThuocKhac_CachDung,
                            TacDungPhuThuoc=:TacDungPhuThuoc,
                            TacDungPhuThuoc_Co=:TacDungPhuThuoc_Co,
                            Sot=:Sot,
                            Sot_Do=:Sot_Do,
                            MetMoi=:MetMoi,
                            Mach=:Mach,
                            HuyetAp=:HuyetAp,
                            HachTo=:HachTo,
                            HachTo_ViTri=:HachTo_ViTri,
                            DatDo=:DatDo,
                            DatDo_ViTri=:DatDo_ViTri,
                            MauSac_ViTri=:MauSac_ViTri,
                            RuouVang=:RuouVang,
                            DoTuoi=:DoTuoi,
                            DoTham=:DoTham,
                            MatPhuNe=:MatPhuNe,
                            BanHeliotrope=:BanHeliotrope,
                            VSign=:VSign,
                            HoslterSign=:HoslterSign,
                            ShawlSign=:ShawlSign,
                            LangDongCanxiODa=:LangDongCanxiODa,
                            GottronSign_BanTay=:GottronSign_BanTay,
                            GottronSign_KhuyuTay=:GottronSign_KhuyuTay,
                            GottronSign_DauGoi=:GottronSign_DauGoi,
                            GottronPapules_BanTay=:GottronPapules_BanTay,
                            GottronPapules_KhuyuTay=:GottronPapules_KhuyuTay,
                            GottronPapules_DauGoi=:GottronPapules_DauGoi,
                            GianMachQuanhMong=:GianMachQuanhMong,
                            XuatHuyetQuanhMong=:XuatHuyetQuanhMong,
                            NutNeQuanhMong=:NutNeQuanhMong,
                            MichanicHand=:MichanicHand,
                            RamLongTrenNenDatDo=:RamLongTrenNenDatDo,
                            RamLongTrenNenDatDo_ViTri=:RamLongTrenNenDatDo_ViTri,
                            HienTuongRaynaud=:HienTuongRaynaud,
                            DauHieuPoikiloderma=:DauHieuPoikiloderma,
                            DauHieuPoikiloderma_ViTri=:DauHieuPoikiloderma_ViTri,
                            VetLoetTrenDa=:VetLoetTrenDa,
                            VetLoetTrenDa_ViTri=:VetLoetTrenDa_ViTri,
                            LamSangDa_Khac=:LamSangDa_Khac,
                            DauCo=:DauCo,
                            DauCo_Diem=:DauCo_Diem,
                            DauCo_ViTri=:DauCo_ViTri,
                            BopCo=:BopCo,
                            BopCo_ViTri=:BopCo_ViTri,
                            YeuCo=:YeuCo,
                            TeoCo=:TeoCo,
                            CoGapCanhTay=:CoGapCanhTay,
                            CoDuoiCanhTay=:CoDuoiCanhTay,
                            CoGapDui=:CoGapDui,
                            CoDuoiDui=:CoDuoiDui,
                            DauKhop=:DauKhop,
                            DauKhop_SoLuong=:DauKhop_SoLuong,
                            DauKhop_ViTri=:DauKhop_ViTri,
                            SungKhop=:SungKhop,
                            SungKhop_SoLuong=:SungKhop_SoLuong,
                            SungKhop_ViTri=:SungKhop_ViTri,
                            BienDangKhop=:BienDangKhop,
                            BienDangKhop_SoLuong=:BienDangKhop_SoLuong,
                            BienDangKhop_ViTri=:BienDangKhop_ViTri,
                            KhoThoKhiGangSuc=:KhoThoKhiGangSuc,
                            KhoThoKhiNghiNgoi=:KhoThoKhiNghiNgoi,
                            HoKhanKeoDai=:HoKhanKeoDai,
                            RanPhoiDoiXung=:RanPhoiDoiXung,
                            Phoi_Khac=:Phoi_Khac,
                            DanhTrongNguc=:DanhTrongNguc,
                            NhipTim=:NhipTim,
                            NhipTim_Khac=:NhipTim_Khac,
                            DauHieuSuyTim=:DauHieuSuyTim,
                            DauHieuSuyTim_Co=:DauHieuSuyTim_Co,
                            Tim_Khac=:Tim_Khac,
                            NuotKhoNghenThucAnRan=:NuotKhoNghenThucAnRan,
                            NuotKhoThucAnLongNuoc=:NuotKhoThucAnLongNuoc,
                            ONong=:ONong,
                            ONongDauNguc=:ONongDauNguc,
                            DangChuaMieng=:DangChuaMieng,
                            NoiKhanDauViemHong=:NoiKhanDauViemHong,
                            HoKhiAn=:HoKhiAn,
                            TaoBon=:TaoBon,
                            TaoLongXenKe=:TaoLongXenKe,
                            DuongTieuHoa_Khac=:DuongTieuHoa_Khac,
                            Phu=:Phu,
                            TieuIt=:TieuIt,
                            TieuMau=:TieuMau,
                            ThanTietNieu_Khac=:ThanTietNieu_Khac,
                            CongThucMau_Bc=:CongThucMau_Bc,
                            CongThucMau_Tt=:CongThucMau_Tt,
                            CongThucMau_Lym=:CongThucMau_Lym,
                            CongThucMau_At=:CongThucMau_At,
                            CongThucMau_Hc=:CongThucMau_Hc,
                            CongThucMau_Hct=:CongThucMau_Hct,
                            CongThucMau_Hb=:CongThucMau_Hb,
                            CongThucMau_Tc=:CongThucMau_Tc,
                            MauLang_1h=:MauLang_1h,
                            MauLang_2h=:MauLang_2h,
                            SinhHoa_Ure=:SinhHoa_Ure,
                            SinhHoa_Choles=:SinhHoa_Choles,
                            SinhHoa_Na=:SinhHoa_Na,
                            SinhHoa_Creatinin=:SinhHoa_Creatinin,
                            SinhHoa_Trigly=:SinhHoa_Trigly,
                            SinhHoa_K=:SinhHoa_K,
                            SinhHoa_Glucose=:SinhHoa_Glucose,
                            SinhHoa_Ldl=:SinhHoa_Ldl,
                            SinhHoa_Cl=:SinhHoa_Cl,
                            SinhHoa_Uric=:SinhHoa_Uric,
                            SinhHoa_Hdl=:SinhHoa_Hdl,
                            SinhHoa_Ast=:SinhHoa_Ast,
                            SinhHoa_BiltP=:SinhHoa_BiltP,
                            SinhHoa_Pro=:SinhHoa_Pro,
                            SinhHoa_ALT=:SinhHoa_ALT,
                            SinhHoa_BiltT=:SinhHoa_BiltT,
                            SinhHoa_Alb=:SinhHoa_Alb,
                            SinhHoa_Ck=:SinhHoa_Ck,
                            SinhHoa_CrpHs=:SinhHoa_CrpHs,
                            SinhHoa_CkMb=:SinhHoa_CkMb,
                            SinhHoa_Khac=:SinhHoa_Khac,
                            NuocTieu_Protein=:NuocTieu_Protein,
                            NuocTieu_ProteinNieu24h=:NuocTieu_ProteinNieu24h,
                            NuocTieu_Hc=:NuocTieu_Hc,
                            NuocTieu_Bc=:NuocTieu_Bc,
                            NuocTieu_Khac=:NuocTieu_Khac,
                            CNHH_FVC=:CNHH_FVC,
                            CNHH_FEV1=:CNHH_FEV1,
                            CNHH_DuDoanFVC=:CNHH_DuDoanFVC,
                            CNHH_FEV1FVC=:CNHH_FEV1FVC,
                            CNHH_DlCo=:CNHH_DlCo,
                            CNHH_DuDoanDlCo=:CNHH_DuDoanDlCo,
                            XqTp=:XqTp,
                            HrCt=:HrCt,
                            SaOBung=:SaOBung,
                            DienTim_TanSo=:DienTim_TanSo,
                            DienTim_Nhip=:DienTim_Nhip,
                            DienTim_Truc=:DienTim_Truc,
                            DiemTim_Khac=:DiemTim_Khac,
                            SaTimEF=:SaTimEF,
                            SaTimPdmp=:SaTimPdmp,
                            SaTim_Khac=:SaTim_Khac,
                            KhangThe_Ana=:KhangThe_Ana,
                            KhangThe_Ana_Duong=:KhangThe_Ana_Duong,
                            KhangThe_Ana_Am=:KhangThe_Ana_Am,
                            KhangThe_Anti155140=:KhangThe_Anti155140,
                            KhangThe_Anti155140_Duong=:KhangThe_Anti155140_Duong,
                            KhangThe_Anti155140_Am=:KhangThe_Anti155140_Am,
                            KhangThe_AntiPMScl=:KhangThe_AntiPMScl,
                            KhangThe_AntiPMScl_Duong=:KhangThe_AntiPMScl_Duong,
                            KhangThe_AntiPMScl_Am=:KhangThe_AntiPMScl_Am,
                            KhangThe_AntiARS=:KhangThe_AntiARS,
                            KhangThe_AntiARS_Duong=:KhangThe_AntiARS_Duong,
                            KhangThe_AntiARS_Am=:KhangThe_AntiARS_Am,
                            KhangThe_AntiCadm=:KhangThe_AntiCadm,
                            KhangThe_AntiCadm_Duong=:KhangThe_AntiCadm_Duong,
                            KhangThe_AntiCadm_Am=:KhangThe_AntiCadm_Am,
                            KhangThe_Ku=:KhangThe_Ku,
                            KhangThe_Ku_Duong=:KhangThe_Ku_Duong,
                            KhangThe_Ku_Am=:KhangThe_Ku_Am,
                            KhangThe_dsDNA=:KhangThe_dsDNA,
                            KhangThe_dsDNA_Duong=:KhangThe_dsDNA_Duong,
                            KhangThe_dsDNA_Am=:KhangThe_dsDNA_Am,
                            KhangThe_AntiU1RNP=:KhangThe_AntiU1RNP,
                            KhangThe_AntiU1RNP_Duong=:KhangThe_AntiU1RNP_Duong,
                            KhangThe_AntiU1RNP_Am=:KhangThe_AntiU1RNP_Am,
                            KhangThe_TIF1=:KhangThe_TIF1,
                            KhangThe_TIF1_Duong=:KhangThe_TIF1_Duong,
                            KhangThe_TIF1_Am=:KhangThe_TIF1_Am,
                            KhangThe_AntiJ01=:KhangThe_AntiJ01,
                            KhangThe_AntiJ01_Duong=:KhangThe_AntiJ01_Duong,
                            KhangThe_AntiJ01_Am=:KhangThe_AntiJ01_Am,
                            KhangThe_AntiSRP=:KhangThe_AntiSRP,
                            KhangThe_AntiSRP_Duong=:KhangThe_AntiSRP_Duong,
                            KhangThe_AntiSRP_Am=:KhangThe_AntiSRP_Am,
                            KhangThe_antiNXP2=:KhangThe_antiNXP2,
                            KhangThe_antiNXP2_Duong=:KhangThe_antiNXP2_Duong,
                            KhangThe_antiNXP2_Am=:KhangThe_antiNXP2_Am,
                            KhangThe_AntiMi2=:KhangThe_AntiMi2,
                            KhangThe_AntiMi2_Duong=:KhangThe_AntiMi2_Duong,
                            KhangThe_AntiMi2_Am=:KhangThe_AntiMi2_Am,
                            KhangThe_AntiMDA5=:KhangThe_AntiMDA5,
                            KhangThe_AntiMDA5_Duong=:KhangThe_AntiMDA5_Duong,
                            KhangThe_AntiMDA5_Am=:KhangThe_AntiMDA5_Am,
                            KhangThe_antiSAE=:KhangThe_antiSAE,
                            KhangThe_antiSAE_Duong=:KhangThe_antiSAE_Duong,
                            KhangThe_antiSAE_Am=:KhangThe_antiSAE_Am,
                            KhangThe_Khac=:KhangThe_Khac,
                            KhamMat=:KhamMat,
                            DienCoKim=:DienCoKim,
                            SinhThietCo=:SinhThietCo,
                            BohanPeter=:BohanPeter,
                            Tanimoto=:Tanimoto,
                            MotSoThe=:MotSoThe,
                            MotSoThe_Khac=:MotSoThe_Khac,
                            TS_Corticosteroid=:TS_Corticosteroid,
                            TS_Cyclophosphamid=:TS_Cyclophosphamid,
                            TS_CyclophosphamidLieuCao=:TS_CyclophosphamidLieuCao,
                            TS_Azathioprine=:TS_Azathioprine,
                            TS_Methotrexate=:TS_Methotrexate,
                            TS_CyclosporineA=:TS_CyclosporineA,
                            ThuocKhac=:ThuocKhac,
                            DieuTriHienTai=:DieuTriHienTai,
                            HenKham=:HenKham,
                            BacSyDieuTri=:BacSyDieuTri,
                            MaBacSyDieuTri=:MaBacSyDieuTri,
                            TK_SoBenhAnDienTu=:TK_SoBenhAnDienTu,
                            TK_SoLuuTru=:TK_SoLuuTru,
                            NgayKham=:NgayKham,
                            NgayLuuHuyetThanh=:NgayLuuHuyetThanh,
                            BacSiKham=:BacSiKham,
                            MaBacSiKham=:MaBacSiKham,
                            TK_Sot=:TK_Sot,
                            TK_Sot_Do=:TK_Sot_Do,
                            TK_MetMoi=:TK_MetMoi,
                            TK_Mach=:TK_Mach,
                            TK_HuyetAp=:TK_HuyetAp,
                            TK_HachTo=:TK_HachTo,
                            TK_HachTo_ViTri=:TK_HachTo_ViTri,
                            TK_CoThemBenhGi=:TK_CoThemBenhGi,
                            TK_DatDo=:TK_DatDo,
                            TK_DatDo_ViTri=:TK_DatDo_ViTri,
                            TK_MauSac_ViTri=:TK_MauSac_ViTri,
                            TK_RuouVang=:TK_RuouVang,
                            TK_DoTuoi=:TK_DoTuoi,
                            TK_DoTham=:TK_DoTham,
                            TK_MatPhuNe=:TK_MatPhuNe,
                            TK_BanHeliotrope=:TK_BanHeliotrope,
                            TK_VSign=:TK_VSign,
                            TK_HoslterSign=:TK_HoslterSign,
                            TK_ShawlSign=:TK_ShawlSign,
                            TK_LangDongCanxiODa=:TK_LangDongCanxiODa,
                            TK_GottronSign_BanTay=:TK_GottronSign_BanTay,
                            TK_GottronSign_KhuyuTay=:TK_GottronSign_KhuyuTay,
                            TK_GottronSign_DauGoi=:TK_GottronSign_DauGoi,
                            TK_GottronPapules_BanTay=:TK_GottronPapules_BanTay,
                            TK_GottronPapules_KhuyuTay=:TK_GottronPapules_KhuyuTay,
                            TK_GottronPapules_DauGoi=:TK_GottronPapules_DauGoi,
                            TK_GianMachQuanhMong=:TK_GianMachQuanhMong,
                            TK_XuatHuyetQuanhMong=:TK_XuatHuyetQuanhMong,
                            TK_NutNeQuanhMong=:TK_NutNeQuanhMong,
                            TK_MichanicHand=:TK_MichanicHand,
                            TK_RamLongTrenNenDatDo=:TK_RamLongTrenNenDatDo,
                            TK_RamLongTrenNenDatDo_ViTri=:TK_RamLongTrenNenDatDo_ViTri,
                            TK_HienTuongRaynaud=:TK_HienTuongRaynaud,
                            TK_DauHieuPoikiloderma=:TK_DauHieuPoikiloderma,
                            TK_DauHieuPoikiloderma_ViTri=:TK_DauHieuPoikiloderma_ViTri,
                            TK_VetLoetTrenDa=:TK_VetLoetTrenDa,
                            TK_VetLoetTrenDa_ViTri=:TK_VetLoetTrenDa_ViTri,
                            TK_DauCo=:TK_DauCo,
                            TK_DauCo_Diem=:TK_DauCo_Diem,
                            TK_DauCo_ViTri=:TK_DauCo_ViTri,
                            TK_BopCo=:TK_BopCo,
                            TK_BopCo_ViTri=:TK_BopCo_ViTri,
                            TK_YeuCo=:TK_YeuCo,
                            TK_TeoCo=:TK_TeoCo,
                            TK_CoGapCanhTay=:TK_CoGapCanhTay,
                            TK_CoDuoiCanhTay=:TK_CoDuoiCanhTay,
                            TK_CoGapDui=:TK_CoGapDui,
                            TK_CoDuoiDui=:TK_CoDuoiDui,
                            TK_DauKhop=:TK_DauKhop,
                            TK_DauKhop_SoLuong=:TK_DauKhop_SoLuong,
                            TK_DauKhop_ViTri=:TK_DauKhop_ViTri,
                            TK_SungKhop=:TK_SungKhop,
                            TK_SungKhop_SoLuong=:TK_SungKhop_SoLuong,
                            TK_SungKhop_ViTri=:TK_SungKhop_ViTri,
                            TK_BienDangKhop=:TK_BienDangKhop,
                            TK_BienDangKhop_SoLuong=:TK_BienDangKhop_SoLuong,
                            TK_BienDangKhop_ViTri=:TK_BienDangKhop_ViTri,
                            TK_KhoThoKhiGangSuc=:TK_KhoThoKhiGangSuc,
                            TK_KhoThoKhiNghiNgoi=:TK_KhoThoKhiNghiNgoi,
                            TK_HoKhanKeoDai=:TK_HoKhanKeoDai,
                            TK_RanPhoiDoiXung=:TK_RanPhoiDoiXung,
                            TK_Phoi_Khac=:TK_Phoi_Khac,
                            TK_DanhTrongNguc=:TK_DanhTrongNguc,
                            TK_NhipTim=:TK_NhipTim,
                            TK_NhipTim_Khac=:TK_NhipTim_Khac,
                            TK_DauHieuSuyTim=:TK_DauHieuSuyTim,
                            TK_DauHieuSuyTim_Co=:TK_DauHieuSuyTim_Co,
                            TK_Tim_Khac=:TK_Tim_Khac,
                            TK_NuotKhoNghenThucAnRan=:TK_NuotKhoNghenThucAnRan,
                            TK_NuotKhoThucAnLongNuoc=:TK_NuotKhoThucAnLongNuoc,
                            TK_ONong=:TK_ONong,
                            TK_ONongDauNguc=:TK_ONongDauNguc,
                            TK_DangChuaMieng=:TK_DangChuaMieng,
                            TK_NoiKhanDauViemHong=:TK_NoiKhanDauViemHong,
                            TK_HoKhiAn=:TK_HoKhiAn,
                            TK_TaoBon=:TK_TaoBon,
                            TK_TaoLongXenKe=:TK_TaoLongXenKe,
                            TK_DuongTieuHoa_Khac=:TK_DuongTieuHoa_Khac,
                            TK_CongThucMau_Bc=:TK_CongThucMau_Bc,
                            TK_CongThucMau_Tt=:TK_CongThucMau_Tt,
                            TK_CongThucMau_Lym=:TK_CongThucMau_Lym,
                            TK_CongThucMau_At=:TK_CongThucMau_At,
                            TK_CongThucMau_Hc=:TK_CongThucMau_Hc,
                            TK_CongThucMau_Hct=:TK_CongThucMau_Hct,
                            TK_CongThucMau_Hb=:TK_CongThucMau_Hb,
                            TK_CongThucMau_Tc=:TK_CongThucMau_Tc,
                            TK_MauLang_1h=:TK_MauLang_1h,
                            TK_MauLang_2h=:TK_MauLang_2h,
                            TK_SinhHoa_Ure=:TK_SinhHoa_Ure,
                            TK_SinhHoa_Choles=:TK_SinhHoa_Choles,
                            TK_SinhHoa_Na=:TK_SinhHoa_Na,
                            TK_SinhHoa_Creatinin=:TK_SinhHoa_Creatinin,
                            TK_SinhHoa_Trigly=:TK_SinhHoa_Trigly,
                            TK_SinhHoa_K=:TK_SinhHoa_K,
                            TK_SinhHoa_Glucose=:TK_SinhHoa_Glucose,
                            TK_SinhHoa_Ldl=:TK_SinhHoa_Ldl,
                            TK_SinhHoa_Cl=:TK_SinhHoa_Cl,
                            TK_SinhHoa_Uric=:TK_SinhHoa_Uric,
                            TK_SinhHoa_Hdl=:TK_SinhHoa_Hdl,
                            TK_SinhHoa_Ast=:TK_SinhHoa_Ast,
                            TK_SinhHoa_BiltP=:TK_SinhHoa_BiltP,
                            TK_SinhHoa_Pro=:TK_SinhHoa_Pro,
                            TK_SinhHoa_ALT=:TK_SinhHoa_ALT,
                            TK_SinhHoa_BiltT=:TK_SinhHoa_BiltT,
                            TK_SinhHoa_Alb=:TK_SinhHoa_Alb,
                            TK_SinhHoa_Ck=:TK_SinhHoa_Ck,
                            TK_SinhHoa_CrpHs=:TK_SinhHoa_CrpHs,
                            TK_SinhHoa_CkMb=:TK_SinhHoa_CkMb,
                            TK_SinhHoa_Khac=:TK_SinhHoa_Khac,
                            TK_NuocTieu_Protein=:TK_NuocTieu_Protein,
                            TK_NuocTieu_ProteinNieu24h=:TK_NuocTieu_ProteinNieu24h,
                            TK_NuocTieu_Hc=:TK_NuocTieu_Hc,
                            TK_NuocTieu_Bc=:TK_NuocTieu_Bc,
                            TK_NuocTieu_Khac=:TK_NuocTieu_Khac,
                            TK_CNHH_FVC=:TK_CNHH_FVC,
                            TK_CNHH_FEV1=:TK_CNHH_FEV1,
                            TK_CNHH_DuDoanFVC=:TK_CNHH_DuDoanFVC,
                            TK_CNHH_FEV1FVC=:TK_CNHH_FEV1FVC,
                            TK_CNHH_DlCo=:TK_CNHH_DlCo,
                            TK_CNHH_DuDoanDlCo=:TK_CNHH_DuDoanDlCo,
                            TK_XqTp=:TK_XqTp,
                            TK_HrCt=:TK_HrCt,
                            TK_SaOBung=:TK_SaOBung,
                            TK_DienTim_TanSo=:TK_DienTim_TanSo,
                            TK_DienTim_Nhip=:TK_DienTim_Nhip,
                            TK_DienTim_Truc=:TK_DienTim_Truc,
                            TK_DiemTim_Khac=:TK_DiemTim_Khac,
                            TK_SaTimEF=:TK_SaTimEF,
                            TK_SaTimPdmp=:TK_SaTimPdmp,
                            TK_SaTim_Khac=:TK_SaTim_Khac,
                            TK_KhangThe_Ana=:TK_KhangThe_Ana,
                            TK_KhangThe_Ana_Duong=:TK_KhangThe_Ana_Duong,
                            TK_KhangThe_Ana_Am=:TK_KhangThe_Ana_Am,
                            TK_KhangThe_Anti155140=:TK_KhangThe_Anti155140,
                            TK_KhangThe_Anti155140_Duong=:TK_KhangThe_Anti155140_Duong,
                            TK_KhangThe_Anti155140_Am=:TK_KhangThe_Anti155140_Am,
                            TK_KhangThe_AntiPMScl=:TK_KhangThe_AntiPMScl,
                            TK_KhangThe_AntiPMScl_Duong=:TK_KhangThe_AntiPMScl_Duong,
                            TK_KhangThe_AntiPMScl_Am=:TK_KhangThe_AntiPMScl_Am,
                            TK_KhangThe_AntiARS=:TK_KhangThe_AntiARS,
                            TK_KhangThe_AntiARS_Duong=:TK_KhangThe_AntiARS_Duong,
                            TK_KhangThe_AntiARS_Am=:TK_KhangThe_AntiARS_Am,
                            TK_KhangThe_AntiCadm=:TK_KhangThe_AntiCadm,
                            TK_KhangThe_AntiCadm_Duong=:TK_KhangThe_AntiCadm_Duong,
                            TK_KhangThe_AntiCadm_Am=:TK_KhangThe_AntiCadm_Am,
                            TK_KhangThe_Ku=:TK_KhangThe_Ku,
                            TK_KhangThe_Ku_Duong=:TK_KhangThe_Ku_Duong,
                            TK_KhangThe_Ku_Am=:TK_KhangThe_Ku_Am,
                            TK_KhangThe_dsDNA=:TK_KhangThe_dsDNA,
                            TK_KhangThe_dsDNA_Duong=:TK_KhangThe_dsDNA_Duong,
                            TK_KhangThe_dsDNA_Am=:TK_KhangThe_dsDNA_Am,
                            TK_KhangThe_AntiU1RNP=:TK_KhangThe_AntiU1RNP,
                            TK_KhangThe_AntiU1RNP_Duong=:TK_KhangThe_AntiU1RNP_Duong,
                            TK_KhangThe_AntiU1RNP_Am=:TK_KhangThe_AntiU1RNP_Am,
                            TK_KhangThe_TIF1=:TK_KhangThe_TIF1,
                            TK_KhangThe_TIF1_Duong=:TK_KhangThe_TIF1_Duong,
                            TK_KhangThe_TIF1_Am=:TK_KhangThe_TIF1_Am,
                            TK_KhangThe_AntiJ01=:TK_KhangThe_AntiJ01,
                            TK_KhangThe_AntiJ01_Duong=:TK_KhangThe_AntiJ01_Duong,
                            TK_KhangThe_AntiJ01_Am=:TK_KhangThe_AntiJ01_Am,
                            TK_KhangThe_AntiSRP=:TK_KhangThe_AntiSRP,
                            TK_KhangThe_AntiSRP_Duong=:TK_KhangThe_AntiSRP_Duong,
                            TK_KhangThe_AntiSRP_Am=:TK_KhangThe_AntiSRP_Am,
                            TK_KhangThe_antiNXP2=:TK_KhangThe_antiNXP2,
                            TK_KhangThe_antiNXP2_Duong=:TK_KhangThe_antiNXP2_Duong,
                            TK_KhangThe_antiNXP2_Am=:TK_KhangThe_antiNXP2_Am,
                            TK_KhangThe_AntiMi2=:TK_KhangThe_AntiMi2,
                            TK_KhangThe_AntiMi2_Duong=:TK_KhangThe_AntiMi2_Duong,
                            TK_KhangThe_AntiMi2_Am=:TK_KhangThe_AntiMi2_Am,
                            TK_KhangThe_AntiMDA5=:TK_KhangThe_AntiMDA5,
                            TK_KhangThe_AntiMDA5_Duong=:TK_KhangThe_AntiMDA5_Duong,
                            TK_KhangThe_AntiMDA5_Am=:TK_KhangThe_AntiMDA5_Am,
                            TK_KhangThe_antiSAE=:TK_KhangThe_antiSAE,
                            TK_KhangThe_antiSAE_Duong=:TK_KhangThe_antiSAE_Duong,
                            TK_KhangThe_antiSAE_Am=:TK_KhangThe_antiSAE_Am,
                            TK_KhangThe_Khac=:TK_KhangThe_Khac,
                            TK_KhamMat=:TK_KhamMat,
                            TK_ChuY=:TK_ChuY,
                            TK_DieuTri=:TK_DieuTri,
                            TK_TacDungPhuCuaThuoc=:TK_TacDungPhuCuaThuoc,
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
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriNgoaiTruTu", BenhAnNgoaiTru_ViemBiCo.DieuTriNgoaiTruTu));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriNgoaiTruDen", BenhAnNgoaiTru_ViemBiCo.DieuTriNgoaiTruDen));
                Command.Parameters.Add(new MDB.MDBParameter("SoCMND", BenhAnNgoaiTru_ViemBiCo.SoCMND));
                Command.Parameters.Add(new MDB.MDBParameter("BaoHiem", BenhAnNgoaiTru_ViemBiCo.BaoHiem));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan_TuyenTruoc", BenhAnNgoaiTru_ViemBiCo.ChanDoan_TuyenTruoc));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanBanDau", BenhAnNgoaiTru_ViemBiCo.ChanDoanBanDau));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham1", BenhAnNgoaiTru_ViemBiCo.ChanDoanTaiKham1));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham2", BenhAnNgoaiTru_ViemBiCo.ChanDoanTaiKham2));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham3", BenhAnNgoaiTru_ViemBiCo.ChanDoanTaiKham3));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham4", BenhAnNgoaiTru_ViemBiCo.ChanDoanTaiKham4));
                Command.Parameters.Add(new MDB.MDBParameter("BenhPhu", BenhAnNgoaiTru_ViemBiCo.BenhPhu));
                Command.Parameters.Add(new MDB.MDBParameter("KetQuaDieuTri", BenhAnNgoaiTru_ViemBiCo.KetQuaDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("BienChung_Text", BenhAnNgoaiTru_ViemBiCo.BienChung_Text));
                Command.Parameters.Add(new MDB.MDBParameter("GDPhongKeHoach", BenhAnNgoaiTru_ViemBiCo.GDPhongKeHoach));
                Command.Parameters.Add(new MDB.MDBParameter("GDPhongKhamBenh", BenhAnNgoaiTru_ViemBiCo.GDPhongKhamBenh));
                Command.Parameters.Add(new MDB.MDBParameter("Can", BenhAnNgoaiTru_ViemBiCo.Can));
                Command.Parameters.Add(new MDB.MDBParameter("GaySut_Kg", BenhAnNgoaiTru_ViemBiCo.GaySut_Kg));
                Command.Parameters.Add(new MDB.MDBParameter("GaySut_Thang", BenhAnNgoaiTru_ViemBiCo.GaySut_Thang));
                Command.Parameters.Add(new MDB.MDBParameter("GaySut_PhanTram", BenhAnNgoaiTru_ViemBiCo.GaySut_PhanTram));
                Command.Parameters.Add(new MDB.MDBParameter("Cao", BenhAnNgoaiTru_ViemBiCo.Cao));
                Command.Parameters.Add(new MDB.MDBParameter("TuoiKhoiPhat", BenhAnNgoaiTru_ViemBiCo.TuoiKhoiPhat));
                Command.Parameters.Add(new MDB.MDBParameter("TGTKKPB", BenhAnNgoaiTru_ViemBiCo.TGTKKPB));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungDauTien", BenhAnNgoaiTru_ViemBiCo.TrieuChungDauTien));
                Command.Parameters.Add(new MDB.MDBParameter("LupusBanDo", BenhAnNgoaiTru_ViemBiCo.LupusBanDo));
                Command.Parameters.Add(new MDB.MDBParameter("XoCungBi", BenhAnNgoaiTru_ViemBiCo.XoCungBi));
                Command.Parameters.Add(new MDB.MDBParameter("ViemKhopDangThap", BenhAnNgoaiTru_ViemBiCo.ViemKhopDangThap));
                Command.Parameters.Add(new MDB.MDBParameter("HoiChungSjogren", BenhAnNgoaiTru_ViemBiCo.HoiChungSjogren));
                Command.Parameters.Add(new MDB.MDBParameter("ViemBiCo", BenhAnNgoaiTru_ViemBiCo.ViemBiCo));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhTuMien_Khac", BenhAnNgoaiTru_ViemBiCo.TienSuBenhTuMien_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("TSCNBCBK_Text", BenhAnNgoaiTru_ViemBiCo.TSCNBCBK_Text));
                Command.Parameters.Add(new MDB.MDBParameter("TSCNBCBK", BenhAnNgoaiTru_ViemBiCo.TSCNBCBK));
                Command.Parameters.Add(new MDB.MDBParameter("TSGDCNBBTM", BenhAnNgoaiTru_ViemBiCo.TSGDCNBBTM));
                Command.Parameters.Add(new MDB.MDBParameter("TSGDCNBBTM_NeuCo", BenhAnNgoaiTru_ViemBiCo.TSGDCNBBTM_NeuCo));
                Command.Parameters.Add(new MDB.MDBParameter("BenhSu", BenhAnNgoaiTru_ViemBiCo.BenhSu));
                Command.Parameters.Add(new MDB.MDBParameter("ChuaDieuTri", BenhAnNgoaiTru_ViemBiCo.ChuaDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("Dpenicillamine", BenhAnNgoaiTru_ViemBiCo.Dpenicillamine));
                Command.Parameters.Add(new MDB.MDBParameter("Dpenicillamine_CachDung", BenhAnNgoaiTru_ViemBiCo.Dpenicillamine_CachDung));
                Command.Parameters.Add(new MDB.MDBParameter("Corticosteroid", BenhAnNgoaiTru_ViemBiCo.Corticosteroid));
                Command.Parameters.Add(new MDB.MDBParameter("Corticosteroid_CachDung", BenhAnNgoaiTru_ViemBiCo.Corticosteroid_CachDung));
                Command.Parameters.Add(new MDB.MDBParameter("Cyclophosphamide", BenhAnNgoaiTru_ViemBiCo.Cyclophosphamide));
                Command.Parameters.Add(new MDB.MDBParameter("Cyclophosphamide_CachDung", BenhAnNgoaiTru_ViemBiCo.Cyclophosphamide_CachDung));
                Command.Parameters.Add(new MDB.MDBParameter("Azathioprine", BenhAnNgoaiTru_ViemBiCo.Azathioprine));
                Command.Parameters.Add(new MDB.MDBParameter("Azathioprine_CachDung", BenhAnNgoaiTru_ViemBiCo.Azathioprine_CachDung));
                Command.Parameters.Add(new MDB.MDBParameter("Methotrexate", BenhAnNgoaiTru_ViemBiCo.Methotrexate));
                Command.Parameters.Add(new MDB.MDBParameter("Methotrexate_CachDung", BenhAnNgoaiTru_ViemBiCo.Methotrexate_CachDung));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocKha", BenhAnNgoaiTru_ViemBiCo.ThuocKha));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocKhac_CachDung", BenhAnNgoaiTru_ViemBiCo.ThuocKhac_CachDung));
                Command.Parameters.Add(new MDB.MDBParameter("TacDungPhuThuoc", BenhAnNgoaiTru_ViemBiCo.TacDungPhuThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("TacDungPhuThuoc_Co", BenhAnNgoaiTru_ViemBiCo.TacDungPhuThuoc_Co));
                Command.Parameters.Add(new MDB.MDBParameter("Sot", BenhAnNgoaiTru_ViemBiCo.Sot));
                Command.Parameters.Add(new MDB.MDBParameter("Sot_Do", BenhAnNgoaiTru_ViemBiCo.Sot_Do));
                Command.Parameters.Add(new MDB.MDBParameter("MetMoi", BenhAnNgoaiTru_ViemBiCo.MetMoi));
                Command.Parameters.Add(new MDB.MDBParameter("Mach", BenhAnNgoaiTru_ViemBiCo.Mach));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetAp", BenhAnNgoaiTru_ViemBiCo.HuyetAp));
                Command.Parameters.Add(new MDB.MDBParameter("HachTo", BenhAnNgoaiTru_ViemBiCo.HachTo));
                Command.Parameters.Add(new MDB.MDBParameter("HachTo_ViTri", BenhAnNgoaiTru_ViemBiCo.HachTo_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("DatDo", BenhAnNgoaiTru_ViemBiCo.DatDo));
                Command.Parameters.Add(new MDB.MDBParameter("DatDo_ViTri", BenhAnNgoaiTru_ViemBiCo.DatDo_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("MauSac_ViTri", BenhAnNgoaiTru_ViemBiCo.MauSac_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("RuouVang", BenhAnNgoaiTru_ViemBiCo.RuouVang));
                Command.Parameters.Add(new MDB.MDBParameter("DoTuoi", BenhAnNgoaiTru_ViemBiCo.DoTuoi));
                Command.Parameters.Add(new MDB.MDBParameter("DoTham", BenhAnNgoaiTru_ViemBiCo.DoTham));
                Command.Parameters.Add(new MDB.MDBParameter("MatPhuNe", BenhAnNgoaiTru_ViemBiCo.MatPhuNe));
                Command.Parameters.Add(new MDB.MDBParameter("BanHeliotrope", BenhAnNgoaiTru_ViemBiCo.BanHeliotrope));
                Command.Parameters.Add(new MDB.MDBParameter("VSign", BenhAnNgoaiTru_ViemBiCo.VSign));
                Command.Parameters.Add(new MDB.MDBParameter("HoslterSign", BenhAnNgoaiTru_ViemBiCo.HoslterSign));
                Command.Parameters.Add(new MDB.MDBParameter("ShawlSign", BenhAnNgoaiTru_ViemBiCo.ShawlSign));
                Command.Parameters.Add(new MDB.MDBParameter("LangDongCanxiODa", BenhAnNgoaiTru_ViemBiCo.LangDongCanxiODa));
                Command.Parameters.Add(new MDB.MDBParameter("GottronSign_BanTay", BenhAnNgoaiTru_ViemBiCo.GottronSign_BanTay));
                Command.Parameters.Add(new MDB.MDBParameter("GottronSign_KhuyuTay", BenhAnNgoaiTru_ViemBiCo.GottronSign_KhuyuTay));
                Command.Parameters.Add(new MDB.MDBParameter("GottronSign_DauGoi", BenhAnNgoaiTru_ViemBiCo.GottronSign_DauGoi));
                Command.Parameters.Add(new MDB.MDBParameter("GottronPapules_BanTay", BenhAnNgoaiTru_ViemBiCo.GottronPapules_BanTay));
                Command.Parameters.Add(new MDB.MDBParameter("GottronPapules_KhuyuTay", BenhAnNgoaiTru_ViemBiCo.GottronPapules_KhuyuTay));
                Command.Parameters.Add(new MDB.MDBParameter("GottronPapules_DauGoi", BenhAnNgoaiTru_ViemBiCo.GottronPapules_DauGoi));
                Command.Parameters.Add(new MDB.MDBParameter("GianMachQuanhMong", BenhAnNgoaiTru_ViemBiCo.GianMachQuanhMong));
                Command.Parameters.Add(new MDB.MDBParameter("XuatHuyetQuanhMong", BenhAnNgoaiTru_ViemBiCo.XuatHuyetQuanhMong));
                Command.Parameters.Add(new MDB.MDBParameter("NutNeQuanhMong", BenhAnNgoaiTru_ViemBiCo.NutNeQuanhMong));
                Command.Parameters.Add(new MDB.MDBParameter("MichanicHand", BenhAnNgoaiTru_ViemBiCo.MichanicHand));
                Command.Parameters.Add(new MDB.MDBParameter("RamLongTrenNenDatDo", BenhAnNgoaiTru_ViemBiCo.RamLongTrenNenDatDo));
                Command.Parameters.Add(new MDB.MDBParameter("RamLongTrenNenDatDo_ViTri", BenhAnNgoaiTru_ViemBiCo.RamLongTrenNenDatDo_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("HienTuongRaynaud", BenhAnNgoaiTru_ViemBiCo.HienTuongRaynaud));
                Command.Parameters.Add(new MDB.MDBParameter("DauHieuPoikiloderma", BenhAnNgoaiTru_ViemBiCo.DauHieuPoikiloderma));
                Command.Parameters.Add(new MDB.MDBParameter("DauHieuPoikiloderma_ViTri", BenhAnNgoaiTru_ViemBiCo.DauHieuPoikiloderma_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("VetLoetTrenDa", BenhAnNgoaiTru_ViemBiCo.VetLoetTrenDa));
                Command.Parameters.Add(new MDB.MDBParameter("VetLoetTrenDa_ViTri", BenhAnNgoaiTru_ViemBiCo.VetLoetTrenDa_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("LamSangDa_Khac", BenhAnNgoaiTru_ViemBiCo.LamSangDa_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("DauCo", BenhAnNgoaiTru_ViemBiCo.DauCo));
                Command.Parameters.Add(new MDB.MDBParameter("DauCo_Diem", BenhAnNgoaiTru_ViemBiCo.DauCo_Diem));
                Command.Parameters.Add(new MDB.MDBParameter("DauCo_ViTri", BenhAnNgoaiTru_ViemBiCo.DauCo_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("BopCo", BenhAnNgoaiTru_ViemBiCo.BopCo));
                Command.Parameters.Add(new MDB.MDBParameter("BopCo_ViTri", BenhAnNgoaiTru_ViemBiCo.BopCo_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("YeuCo", BenhAnNgoaiTru_ViemBiCo.YeuCo));
                Command.Parameters.Add(new MDB.MDBParameter("TeoCo", BenhAnNgoaiTru_ViemBiCo.TeoCo));
                Command.Parameters.Add(new MDB.MDBParameter("CoGapCanhTay", JsonConvert.SerializeObject(BenhAnNgoaiTru_ViemBiCo.CoGapCanhTay)));
                Command.Parameters.Add(new MDB.MDBParameter("CoDuoiCanhTay", JsonConvert.SerializeObject(BenhAnNgoaiTru_ViemBiCo.CoDuoiCanhTay)));
                Command.Parameters.Add(new MDB.MDBParameter("CoGapDui", JsonConvert.SerializeObject(BenhAnNgoaiTru_ViemBiCo.CoGapDui)));
                Command.Parameters.Add(new MDB.MDBParameter("CoDuoiDui", JsonConvert.SerializeObject(BenhAnNgoaiTru_ViemBiCo.CoDuoiDui)));
                Command.Parameters.Add(new MDB.MDBParameter("DauKhop", BenhAnNgoaiTru_ViemBiCo.DauKhop));
                Command.Parameters.Add(new MDB.MDBParameter("DauKhop_SoLuong", BenhAnNgoaiTru_ViemBiCo.DauKhop_SoLuong));
                Command.Parameters.Add(new MDB.MDBParameter("DauKhop_ViTri", BenhAnNgoaiTru_ViemBiCo.DauKhop_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("SungKhop", BenhAnNgoaiTru_ViemBiCo.SungKhop));
                Command.Parameters.Add(new MDB.MDBParameter("SungKhop_SoLuong", BenhAnNgoaiTru_ViemBiCo.SungKhop_SoLuong));
                Command.Parameters.Add(new MDB.MDBParameter("SungKhop_ViTri", BenhAnNgoaiTru_ViemBiCo.SungKhop_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("BienDangKhop", BenhAnNgoaiTru_ViemBiCo.BienDangKhop));
                Command.Parameters.Add(new MDB.MDBParameter("BienDangKhop_SoLuong", BenhAnNgoaiTru_ViemBiCo.BienDangKhop_SoLuong));
                Command.Parameters.Add(new MDB.MDBParameter("BienDangKhop_ViTri", BenhAnNgoaiTru_ViemBiCo.BienDangKhop_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("KhoThoKhiGangSuc", BenhAnNgoaiTru_ViemBiCo.KhoThoKhiGangSuc));
                Command.Parameters.Add(new MDB.MDBParameter("KhoThoKhiNghiNgoi", BenhAnNgoaiTru_ViemBiCo.KhoThoKhiNghiNgoi));
                Command.Parameters.Add(new MDB.MDBParameter("HoKhanKeoDai", BenhAnNgoaiTru_ViemBiCo.HoKhanKeoDai));
                Command.Parameters.Add(new MDB.MDBParameter("RanPhoiDoiXung", BenhAnNgoaiTru_ViemBiCo.RanPhoiDoiXung));
                Command.Parameters.Add(new MDB.MDBParameter("Phoi_Khac", BenhAnNgoaiTru_ViemBiCo.Phoi_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("DanhTrongNguc", BenhAnNgoaiTru_ViemBiCo.DanhTrongNguc));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTim", BenhAnNgoaiTru_ViemBiCo.NhipTim));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTim_Khac", BenhAnNgoaiTru_ViemBiCo.NhipTim_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("DauHieuSuyTim", BenhAnNgoaiTru_ViemBiCo.DauHieuSuyTim));
                Command.Parameters.Add(new MDB.MDBParameter("DauHieuSuyTim_Co", BenhAnNgoaiTru_ViemBiCo.DauHieuSuyTim_Co));
                Command.Parameters.Add(new MDB.MDBParameter("Tim_Khac", BenhAnNgoaiTru_ViemBiCo.Tim_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("NuotKhoNghenThucAnRan", BenhAnNgoaiTru_ViemBiCo.NuotKhoNghenThucAnRan));
                Command.Parameters.Add(new MDB.MDBParameter("NuotKhoThucAnLongNuoc", BenhAnNgoaiTru_ViemBiCo.NuotKhoThucAnLongNuoc));
                Command.Parameters.Add(new MDB.MDBParameter("ONong", BenhAnNgoaiTru_ViemBiCo.ONong));
                Command.Parameters.Add(new MDB.MDBParameter("ONongDauNguc", BenhAnNgoaiTru_ViemBiCo.ONongDauNguc));
                Command.Parameters.Add(new MDB.MDBParameter("DangChuaMieng", BenhAnNgoaiTru_ViemBiCo.DangChuaMieng));
                Command.Parameters.Add(new MDB.MDBParameter("NoiKhanDauViemHong", BenhAnNgoaiTru_ViemBiCo.NoiKhanDauViemHong));
                Command.Parameters.Add(new MDB.MDBParameter("HoKhiAn", BenhAnNgoaiTru_ViemBiCo.HoKhiAn));
                Command.Parameters.Add(new MDB.MDBParameter("TaoBon", BenhAnNgoaiTru_ViemBiCo.TaoBon));
                Command.Parameters.Add(new MDB.MDBParameter("TaoLongXenKe", BenhAnNgoaiTru_ViemBiCo.TaoLongXenKe));
                Command.Parameters.Add(new MDB.MDBParameter("DuongTieuHoa_Khac", BenhAnNgoaiTru_ViemBiCo.DuongTieuHoa_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("Phu", BenhAnNgoaiTru_ViemBiCo.Phu));
                Command.Parameters.Add(new MDB.MDBParameter("TieuIt", BenhAnNgoaiTru_ViemBiCo.TieuIt));
                Command.Parameters.Add(new MDB.MDBParameter("TieuMau", BenhAnNgoaiTru_ViemBiCo.TieuMau));
                Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieu_Khac", BenhAnNgoaiTru_ViemBiCo.ThanTietNieu_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("CongThucMau_Bc", BenhAnNgoaiTru_ViemBiCo.CongThucMau_Bc));
                Command.Parameters.Add(new MDB.MDBParameter("CongThucMau_Tt", BenhAnNgoaiTru_ViemBiCo.CongThucMau_Tt));
                Command.Parameters.Add(new MDB.MDBParameter("CongThucMau_Lym", BenhAnNgoaiTru_ViemBiCo.CongThucMau_Lym));
                Command.Parameters.Add(new MDB.MDBParameter("CongThucMau_At", BenhAnNgoaiTru_ViemBiCo.CongThucMau_At));
                Command.Parameters.Add(new MDB.MDBParameter("CongThucMau_Hc", BenhAnNgoaiTru_ViemBiCo.CongThucMau_Hc));
                Command.Parameters.Add(new MDB.MDBParameter("CongThucMau_Hct", BenhAnNgoaiTru_ViemBiCo.CongThucMau_Hct));
                Command.Parameters.Add(new MDB.MDBParameter("CongThucMau_Hb", BenhAnNgoaiTru_ViemBiCo.CongThucMau_Hb));
                Command.Parameters.Add(new MDB.MDBParameter("CongThucMau_Tc", BenhAnNgoaiTru_ViemBiCo.CongThucMau_Tc));
                Command.Parameters.Add(new MDB.MDBParameter("MauLang_1h", BenhAnNgoaiTru_ViemBiCo.MauLang_1h));
                Command.Parameters.Add(new MDB.MDBParameter("MauLang_2h", BenhAnNgoaiTru_ViemBiCo.MauLang_2h));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_Ure", BenhAnNgoaiTru_ViemBiCo.SinhHoa_Ure));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_Choles", BenhAnNgoaiTru_ViemBiCo.SinhHoa_Choles));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_Na", BenhAnNgoaiTru_ViemBiCo.SinhHoa_Na));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_Creatinin", BenhAnNgoaiTru_ViemBiCo.SinhHoa_Creatinin));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_Trigly", BenhAnNgoaiTru_ViemBiCo.SinhHoa_Trigly));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_K", BenhAnNgoaiTru_ViemBiCo.SinhHoa_K));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_Glucose", BenhAnNgoaiTru_ViemBiCo.SinhHoa_Glucose));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_Ldl", BenhAnNgoaiTru_ViemBiCo.SinhHoa_Ldl));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_Cl", BenhAnNgoaiTru_ViemBiCo.SinhHoa_Cl));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_Uric", BenhAnNgoaiTru_ViemBiCo.SinhHoa_Uric));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_Hdl", BenhAnNgoaiTru_ViemBiCo.SinhHoa_Hdl));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_Ast", BenhAnNgoaiTru_ViemBiCo.SinhHoa_Ast));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_BiltP", BenhAnNgoaiTru_ViemBiCo.SinhHoa_BiltP));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_Pro", BenhAnNgoaiTru_ViemBiCo.SinhHoa_Pro));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_ALT", BenhAnNgoaiTru_ViemBiCo.SinhHoa_ALT));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_BiltT", BenhAnNgoaiTru_ViemBiCo.SinhHoa_BiltT));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_Alb", BenhAnNgoaiTru_ViemBiCo.SinhHoa_Alb));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_Ck", BenhAnNgoaiTru_ViemBiCo.SinhHoa_Ck));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_CrpHs", BenhAnNgoaiTru_ViemBiCo.SinhHoa_CrpHs));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_CkMb", BenhAnNgoaiTru_ViemBiCo.SinhHoa_CkMb));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_Khac", BenhAnNgoaiTru_ViemBiCo.SinhHoa_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("NuocTieu_Protein", BenhAnNgoaiTru_ViemBiCo.NuocTieu_Protein));
                Command.Parameters.Add(new MDB.MDBParameter("NuocTieu_ProteinNieu24h", BenhAnNgoaiTru_ViemBiCo.NuocTieu_ProteinNieu24h));
                Command.Parameters.Add(new MDB.MDBParameter("NuocTieu_Hc", BenhAnNgoaiTru_ViemBiCo.NuocTieu_Hc));
                Command.Parameters.Add(new MDB.MDBParameter("NuocTieu_Bc", BenhAnNgoaiTru_ViemBiCo.NuocTieu_Bc));
                Command.Parameters.Add(new MDB.MDBParameter("NuocTieu_Khac", BenhAnNgoaiTru_ViemBiCo.NuocTieu_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("CNHH_FVC", BenhAnNgoaiTru_ViemBiCo.CNHH_FVC));
                Command.Parameters.Add(new MDB.MDBParameter("CNHH_FEV1", BenhAnNgoaiTru_ViemBiCo.CNHH_FEV1));
                Command.Parameters.Add(new MDB.MDBParameter("CNHH_DuDoanFVC", BenhAnNgoaiTru_ViemBiCo.CNHH_DuDoanFVC));
                Command.Parameters.Add(new MDB.MDBParameter("CNHH_FEV1FVC", BenhAnNgoaiTru_ViemBiCo.CNHH_FEV1FVC));
                Command.Parameters.Add(new MDB.MDBParameter("CNHH_DlCo", BenhAnNgoaiTru_ViemBiCo.CNHH_DlCo));
                Command.Parameters.Add(new MDB.MDBParameter("CNHH_DuDoanDlCo", BenhAnNgoaiTru_ViemBiCo.CNHH_DuDoanDlCo));
                Command.Parameters.Add(new MDB.MDBParameter("XqTp", BenhAnNgoaiTru_ViemBiCo.XqTp));
                Command.Parameters.Add(new MDB.MDBParameter("HrCt", BenhAnNgoaiTru_ViemBiCo.HrCt));
                Command.Parameters.Add(new MDB.MDBParameter("SaOBung", BenhAnNgoaiTru_ViemBiCo.SaOBung));
                Command.Parameters.Add(new MDB.MDBParameter("DienTim_TanSo", BenhAnNgoaiTru_ViemBiCo.DienTim_TanSo));
                Command.Parameters.Add(new MDB.MDBParameter("DienTim_Nhip", BenhAnNgoaiTru_ViemBiCo.DienTim_Nhip));
                Command.Parameters.Add(new MDB.MDBParameter("DienTim_Truc", BenhAnNgoaiTru_ViemBiCo.DienTim_Truc));
                Command.Parameters.Add(new MDB.MDBParameter("DiemTim_Khac", BenhAnNgoaiTru_ViemBiCo.DiemTim_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("SaTimEF", BenhAnNgoaiTru_ViemBiCo.SaTimEF));
                Command.Parameters.Add(new MDB.MDBParameter("SaTimPdmp", BenhAnNgoaiTru_ViemBiCo.SaTimPdmp));
                Command.Parameters.Add(new MDB.MDBParameter("SaTim_Khac", BenhAnNgoaiTru_ViemBiCo.SaTim_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_Ana", BenhAnNgoaiTru_ViemBiCo.KhangThe_Ana));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_Ana_Duong", BenhAnNgoaiTru_ViemBiCo.KhangThe_Ana_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_Ana_Am", BenhAnNgoaiTru_ViemBiCo.KhangThe_Ana_Am));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_Anti155140", BenhAnNgoaiTru_ViemBiCo.KhangThe_Anti155140));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_Anti155140_Duong", BenhAnNgoaiTru_ViemBiCo.KhangThe_Anti155140_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_Anti155140_Am", BenhAnNgoaiTru_ViemBiCo.KhangThe_Anti155140_Am));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_AntiPMScl", BenhAnNgoaiTru_ViemBiCo.KhangThe_AntiPMScl));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_AntiPMScl_Duong", BenhAnNgoaiTru_ViemBiCo.KhangThe_AntiPMScl_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_AntiPMScl_Am", BenhAnNgoaiTru_ViemBiCo.KhangThe_AntiPMScl_Am));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_AntiARS", BenhAnNgoaiTru_ViemBiCo.KhangThe_AntiARS));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_AntiARS_Duong", BenhAnNgoaiTru_ViemBiCo.KhangThe_AntiARS_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_AntiARS_Am", BenhAnNgoaiTru_ViemBiCo.KhangThe_AntiARS_Am));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_AntiCadm", BenhAnNgoaiTru_ViemBiCo.KhangThe_AntiCadm));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_AntiCadm_Duong", BenhAnNgoaiTru_ViemBiCo.KhangThe_AntiCadm_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_AntiCadm_Am", BenhAnNgoaiTru_ViemBiCo.KhangThe_AntiCadm_Am));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_Ku", BenhAnNgoaiTru_ViemBiCo.KhangThe_Ku));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_Ku_Duong", BenhAnNgoaiTru_ViemBiCo.KhangThe_Ku_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_Ku_Am", BenhAnNgoaiTru_ViemBiCo.KhangThe_Ku_Am));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_dsDNA", BenhAnNgoaiTru_ViemBiCo.KhangThe_dsDNA));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_dsDNA_Duong", BenhAnNgoaiTru_ViemBiCo.KhangThe_dsDNA_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_dsDNA_Am", BenhAnNgoaiTru_ViemBiCo.KhangThe_dsDNA_Am));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_AntiU1RNP", BenhAnNgoaiTru_ViemBiCo.KhangThe_AntiU1RNP));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_AntiU1RNP_Duong", BenhAnNgoaiTru_ViemBiCo.KhangThe_AntiU1RNP_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_AntiU1RNP_Am", BenhAnNgoaiTru_ViemBiCo.KhangThe_AntiU1RNP_Am));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_TIF1", BenhAnNgoaiTru_ViemBiCo.KhangThe_TIF1));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_TIF1_Duong", BenhAnNgoaiTru_ViemBiCo.KhangThe_TIF1_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_TIF1_Am", BenhAnNgoaiTru_ViemBiCo.KhangThe_TIF1_Am));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_AntiJ01", BenhAnNgoaiTru_ViemBiCo.KhangThe_AntiJ01));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_AntiJ01_Duong", BenhAnNgoaiTru_ViemBiCo.KhangThe_AntiJ01_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_AntiJ01_Am", BenhAnNgoaiTru_ViemBiCo.KhangThe_AntiJ01_Am));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_AntiSRP", BenhAnNgoaiTru_ViemBiCo.KhangThe_AntiSRP));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_AntiSRP_Duong", BenhAnNgoaiTru_ViemBiCo.KhangThe_AntiSRP_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_AntiSRP_Am", BenhAnNgoaiTru_ViemBiCo.KhangThe_AntiSRP_Am));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_antiNXP2", BenhAnNgoaiTru_ViemBiCo.KhangThe_antiNXP2));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_antiNXP2_Duong", BenhAnNgoaiTru_ViemBiCo.KhangThe_antiNXP2_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_antiNXP2_Am", BenhAnNgoaiTru_ViemBiCo.KhangThe_antiNXP2_Am));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_AntiMi2", BenhAnNgoaiTru_ViemBiCo.KhangThe_AntiMi2));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_AntiMi2_Duong", BenhAnNgoaiTru_ViemBiCo.KhangThe_AntiMi2_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_AntiMi2_Am", BenhAnNgoaiTru_ViemBiCo.KhangThe_AntiMi2_Am));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_AntiMDA5", BenhAnNgoaiTru_ViemBiCo.KhangThe_AntiMDA5));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_AntiMDA5_Duong", BenhAnNgoaiTru_ViemBiCo.KhangThe_AntiMDA5_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_AntiMDA5_Am", BenhAnNgoaiTru_ViemBiCo.KhangThe_AntiMDA5_Am));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_antiSAE", BenhAnNgoaiTru_ViemBiCo.KhangThe_antiSAE));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_antiSAE_Duong", BenhAnNgoaiTru_ViemBiCo.KhangThe_antiSAE_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_antiSAE_Am", BenhAnNgoaiTru_ViemBiCo.KhangThe_antiSAE_Am));
                Command.Parameters.Add(new MDB.MDBParameter("KhangThe_Khac", BenhAnNgoaiTru_ViemBiCo.KhangThe_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("KhamMat", BenhAnNgoaiTru_ViemBiCo.KhamMat));
                Command.Parameters.Add(new MDB.MDBParameter("DienCoKim", BenhAnNgoaiTru_ViemBiCo.DienCoKim));
                Command.Parameters.Add(new MDB.MDBParameter("SinhThietCo", BenhAnNgoaiTru_ViemBiCo.SinhThietCo));
                Command.Parameters.Add(new MDB.MDBParameter("BohanPeter", BenhAnNgoaiTru_ViemBiCo.BohanPeter));
                Command.Parameters.Add(new MDB.MDBParameter("Tanimoto", BenhAnNgoaiTru_ViemBiCo.Tanimoto));
                Command.Parameters.Add(new MDB.MDBParameter("MotSoThe", BenhAnNgoaiTru_ViemBiCo.MotSoThe));
                Command.Parameters.Add(new MDB.MDBParameter("MotSoThe_Khac", BenhAnNgoaiTru_ViemBiCo.MotSoThe_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("TS_Corticosteroid", JsonConvert.SerializeObject(BenhAnNgoaiTru_ViemBiCo.TS_Corticosteroid)));
                Command.Parameters.Add(new MDB.MDBParameter("TS_Cyclophosphamid", JsonConvert.SerializeObject(BenhAnNgoaiTru_ViemBiCo.TS_Cyclophosphamid)));
                Command.Parameters.Add(new MDB.MDBParameter("TS_CyclophosphamidLieuCao", JsonConvert.SerializeObject(BenhAnNgoaiTru_ViemBiCo.TS_CyclophosphamidLieuCao)));
                Command.Parameters.Add(new MDB.MDBParameter("TS_Azathioprine", JsonConvert.SerializeObject(BenhAnNgoaiTru_ViemBiCo.TS_Azathioprine)));
                Command.Parameters.Add(new MDB.MDBParameter("TS_Methotrexate", JsonConvert.SerializeObject(BenhAnNgoaiTru_ViemBiCo.TS_Methotrexate)));
                Command.Parameters.Add(new MDB.MDBParameter("TS_CyclosporineA", JsonConvert.SerializeObject(BenhAnNgoaiTru_ViemBiCo.TS_CyclosporineA)));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocKhac", BenhAnNgoaiTru_ViemBiCo.ThuocKhac));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriHienTai", BenhAnNgoaiTru_ViemBiCo.DieuTriHienTai));
                Command.Parameters.Add(new MDB.MDBParameter("HenKham", BenhAnNgoaiTru_ViemBiCo.HenKham));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnNgoaiTru_ViemBiCo.BacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSyDieuTri", BenhAnNgoaiTru_ViemBiCo.MaBacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SoBenhAnDienTu", BenhAnNgoaiTru_ViemBiCo.TK_SoBenhAnDienTu));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SoLuuTru", BenhAnNgoaiTru_ViemBiCo.TK_SoLuuTru));
                Command.Parameters.Add(new MDB.MDBParameter("NgayKham", BenhAnNgoaiTru_ViemBiCo.NgayKham));
                Command.Parameters.Add(new MDB.MDBParameter("NgayLuuHuyetThanh", BenhAnNgoaiTru_ViemBiCo.NgayLuuHuyetThanh));
                Command.Parameters.Add(new MDB.MDBParameter("BacSiKham", BenhAnNgoaiTru_ViemBiCo.BacSiKham));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSiKham", BenhAnNgoaiTru_ViemBiCo.MaBacSiKham));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Sot", BenhAnNgoaiTru_ViemBiCo.TK_Sot));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Sot_Do", BenhAnNgoaiTru_ViemBiCo.TK_Sot_Do));
                Command.Parameters.Add(new MDB.MDBParameter("TK_MetMoi", BenhAnNgoaiTru_ViemBiCo.TK_MetMoi));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Mach", BenhAnNgoaiTru_ViemBiCo.TK_Mach));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HuyetAp", BenhAnNgoaiTru_ViemBiCo.TK_HuyetAp));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HachTo", BenhAnNgoaiTru_ViemBiCo.TK_HachTo));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HachTo_ViTri", BenhAnNgoaiTru_ViemBiCo.TK_HachTo_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_CoThemBenhGi", BenhAnNgoaiTru_ViemBiCo.TK_CoThemBenhGi));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DatDo", BenhAnNgoaiTru_ViemBiCo.TK_DatDo));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DatDo_ViTri", BenhAnNgoaiTru_ViemBiCo.TK_DatDo_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_MauSac_ViTri", BenhAnNgoaiTru_ViemBiCo.TK_MauSac_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_RuouVang", BenhAnNgoaiTru_ViemBiCo.TK_RuouVang));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DoTuoi", BenhAnNgoaiTru_ViemBiCo.TK_DoTuoi));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DoTham", BenhAnNgoaiTru_ViemBiCo.TK_DoTham));
                Command.Parameters.Add(new MDB.MDBParameter("TK_MatPhuNe", BenhAnNgoaiTru_ViemBiCo.TK_MatPhuNe));
                Command.Parameters.Add(new MDB.MDBParameter("TK_BanHeliotrope", BenhAnNgoaiTru_ViemBiCo.TK_BanHeliotrope));
                Command.Parameters.Add(new MDB.MDBParameter("TK_VSign", BenhAnNgoaiTru_ViemBiCo.TK_VSign));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HoslterSign", BenhAnNgoaiTru_ViemBiCo.TK_HoslterSign));
                Command.Parameters.Add(new MDB.MDBParameter("TK_ShawlSign", BenhAnNgoaiTru_ViemBiCo.TK_ShawlSign));
                Command.Parameters.Add(new MDB.MDBParameter("TK_LangDongCanxiODa", BenhAnNgoaiTru_ViemBiCo.TK_LangDongCanxiODa));
                Command.Parameters.Add(new MDB.MDBParameter("TK_GottronSign_BanTay", BenhAnNgoaiTru_ViemBiCo.TK_GottronSign_BanTay));
                Command.Parameters.Add(new MDB.MDBParameter("TK_GottronSign_KhuyuTay", BenhAnNgoaiTru_ViemBiCo.TK_GottronSign_KhuyuTay));
                Command.Parameters.Add(new MDB.MDBParameter("TK_GottronSign_DauGoi", BenhAnNgoaiTru_ViemBiCo.TK_GottronSign_DauGoi));
                Command.Parameters.Add(new MDB.MDBParameter("TK_GottronPapules_BanTay", BenhAnNgoaiTru_ViemBiCo.TK_GottronPapules_BanTay));
                Command.Parameters.Add(new MDB.MDBParameter("TK_GottronPapules_KhuyuTay", BenhAnNgoaiTru_ViemBiCo.TK_GottronPapules_KhuyuTay));
                Command.Parameters.Add(new MDB.MDBParameter("TK_GottronPapules_DauGoi", BenhAnNgoaiTru_ViemBiCo.TK_GottronPapules_DauGoi));
                Command.Parameters.Add(new MDB.MDBParameter("TK_GianMachQuanhMong", BenhAnNgoaiTru_ViemBiCo.TK_GianMachQuanhMong));
                Command.Parameters.Add(new MDB.MDBParameter("TK_XuatHuyetQuanhMong", BenhAnNgoaiTru_ViemBiCo.TK_XuatHuyetQuanhMong));
                Command.Parameters.Add(new MDB.MDBParameter("TK_NutNeQuanhMong", BenhAnNgoaiTru_ViemBiCo.TK_NutNeQuanhMong));
                Command.Parameters.Add(new MDB.MDBParameter("TK_MichanicHand", BenhAnNgoaiTru_ViemBiCo.TK_MichanicHand));
                Command.Parameters.Add(new MDB.MDBParameter("TK_RamLongTrenNenDatDo", BenhAnNgoaiTru_ViemBiCo.TK_RamLongTrenNenDatDo));
                Command.Parameters.Add(new MDB.MDBParameter("TK_RamLongTrenNenDatDo_ViTri", BenhAnNgoaiTru_ViemBiCo.TK_RamLongTrenNenDatDo_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HienTuongRaynaud", BenhAnNgoaiTru_ViemBiCo.TK_HienTuongRaynaud));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DauHieuPoikiloderma", BenhAnNgoaiTru_ViemBiCo.TK_DauHieuPoikiloderma));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DauHieuPoikiloderma_ViTri", BenhAnNgoaiTru_ViemBiCo.TK_DauHieuPoikiloderma_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_VetLoetTrenDa", BenhAnNgoaiTru_ViemBiCo.TK_VetLoetTrenDa));
                Command.Parameters.Add(new MDB.MDBParameter("TK_VetLoetTrenDa_ViTri", BenhAnNgoaiTru_ViemBiCo.TK_VetLoetTrenDa_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DauCo", BenhAnNgoaiTru_ViemBiCo.TK_DauCo));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DauCo_Diem", BenhAnNgoaiTru_ViemBiCo.TK_DauCo_Diem));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DauCo_ViTri", BenhAnNgoaiTru_ViemBiCo.TK_DauCo_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_BopCo", BenhAnNgoaiTru_ViemBiCo.TK_BopCo));
                Command.Parameters.Add(new MDB.MDBParameter("TK_BopCo_ViTri", BenhAnNgoaiTru_ViemBiCo.TK_BopCo_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_YeuCo", BenhAnNgoaiTru_ViemBiCo.TK_YeuCo));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TeoCo", BenhAnNgoaiTru_ViemBiCo.TK_TeoCo));
                Command.Parameters.Add(new MDB.MDBParameter("TK_CoGapCanhTay", JsonConvert.SerializeObject(BenhAnNgoaiTru_ViemBiCo.TK_CoGapCanhTay)));
                Command.Parameters.Add(new MDB.MDBParameter("TK_CoDuoiCanhTay", JsonConvert.SerializeObject(BenhAnNgoaiTru_ViemBiCo.TK_CoDuoiCanhTay)));
                Command.Parameters.Add(new MDB.MDBParameter("TK_CoGapDui", JsonConvert.SerializeObject(BenhAnNgoaiTru_ViemBiCo.TK_CoGapDui)));
                Command.Parameters.Add(new MDB.MDBParameter("TK_CoDuoiDui", JsonConvert.SerializeObject(BenhAnNgoaiTru_ViemBiCo.TK_CoDuoiDui)));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DauKhop", BenhAnNgoaiTru_ViemBiCo.TK_DauKhop));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DauKhop_SoLuong", BenhAnNgoaiTru_ViemBiCo.TK_DauKhop_SoLuong));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DauKhop_ViTri", BenhAnNgoaiTru_ViemBiCo.TK_DauKhop_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SungKhop", BenhAnNgoaiTru_ViemBiCo.TK_SungKhop));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SungKhop_SoLuong", BenhAnNgoaiTru_ViemBiCo.TK_SungKhop_SoLuong));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SungKhop_ViTri", BenhAnNgoaiTru_ViemBiCo.TK_SungKhop_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_BienDangKhop", BenhAnNgoaiTru_ViemBiCo.TK_BienDangKhop));
                Command.Parameters.Add(new MDB.MDBParameter("TK_BienDangKhop_SoLuong", BenhAnNgoaiTru_ViemBiCo.TK_BienDangKhop_SoLuong));
                Command.Parameters.Add(new MDB.MDBParameter("TK_BienDangKhop_ViTri", BenhAnNgoaiTru_ViemBiCo.TK_BienDangKhop_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhoThoKhiGangSuc", BenhAnNgoaiTru_ViemBiCo.TK_KhoThoKhiGangSuc));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhoThoKhiNghiNgoi", BenhAnNgoaiTru_ViemBiCo.TK_KhoThoKhiNghiNgoi));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HoKhanKeoDai", BenhAnNgoaiTru_ViemBiCo.TK_HoKhanKeoDai));
                Command.Parameters.Add(new MDB.MDBParameter("TK_RanPhoiDoiXung", BenhAnNgoaiTru_ViemBiCo.TK_RanPhoiDoiXung));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Phoi_Khac", BenhAnNgoaiTru_ViemBiCo.TK_Phoi_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DanhTrongNguc", BenhAnNgoaiTru_ViemBiCo.TK_DanhTrongNguc));
                Command.Parameters.Add(new MDB.MDBParameter("TK_NhipTim", BenhAnNgoaiTru_ViemBiCo.TK_NhipTim));
                Command.Parameters.Add(new MDB.MDBParameter("TK_NhipTim_Khac", BenhAnNgoaiTru_ViemBiCo.TK_NhipTim_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DauHieuSuyTim", BenhAnNgoaiTru_ViemBiCo.TK_DauHieuSuyTim));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DauHieuSuyTim_Co", BenhAnNgoaiTru_ViemBiCo.TK_DauHieuSuyTim_Co));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Tim_Khac", BenhAnNgoaiTru_ViemBiCo.TK_Tim_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("TK_NuotKhoNghenThucAnRan", BenhAnNgoaiTru_ViemBiCo.TK_NuotKhoNghenThucAnRan));
                Command.Parameters.Add(new MDB.MDBParameter("TK_NuotKhoThucAnLongNuoc", BenhAnNgoaiTru_ViemBiCo.TK_NuotKhoThucAnLongNuoc));
                Command.Parameters.Add(new MDB.MDBParameter("TK_ONong", BenhAnNgoaiTru_ViemBiCo.TK_ONong));
                Command.Parameters.Add(new MDB.MDBParameter("TK_ONongDauNguc", BenhAnNgoaiTru_ViemBiCo.TK_ONongDauNguc));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DangChuaMieng", BenhAnNgoaiTru_ViemBiCo.TK_DangChuaMieng));
                Command.Parameters.Add(new MDB.MDBParameter("TK_NoiKhanDauViemHong", BenhAnNgoaiTru_ViemBiCo.TK_NoiKhanDauViemHong));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HoKhiAn", BenhAnNgoaiTru_ViemBiCo.TK_HoKhiAn));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TaoBon", BenhAnNgoaiTru_ViemBiCo.TK_TaoBon));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TaoLongXenKe", BenhAnNgoaiTru_ViemBiCo.TK_TaoLongXenKe));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DuongTieuHoa_Khac", BenhAnNgoaiTru_ViemBiCo.TK_DuongTieuHoa_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("TK_CongThucMau_Bc", BenhAnNgoaiTru_ViemBiCo.TK_CongThucMau_Bc));
                Command.Parameters.Add(new MDB.MDBParameter("TK_CongThucMau_Tt", BenhAnNgoaiTru_ViemBiCo.TK_CongThucMau_Tt));
                Command.Parameters.Add(new MDB.MDBParameter("TK_CongThucMau_Lym", BenhAnNgoaiTru_ViemBiCo.TK_CongThucMau_Lym));
                Command.Parameters.Add(new MDB.MDBParameter("TK_CongThucMau_At", BenhAnNgoaiTru_ViemBiCo.TK_CongThucMau_At));
                Command.Parameters.Add(new MDB.MDBParameter("TK_CongThucMau_Hc", BenhAnNgoaiTru_ViemBiCo.TK_CongThucMau_Hc));
                Command.Parameters.Add(new MDB.MDBParameter("TK_CongThucMau_Hct", BenhAnNgoaiTru_ViemBiCo.TK_CongThucMau_Hct));
                Command.Parameters.Add(new MDB.MDBParameter("TK_CongThucMau_Hb", BenhAnNgoaiTru_ViemBiCo.TK_CongThucMau_Hb));
                Command.Parameters.Add(new MDB.MDBParameter("TK_CongThucMau_Tc", BenhAnNgoaiTru_ViemBiCo.TK_CongThucMau_Tc));
                Command.Parameters.Add(new MDB.MDBParameter("TK_MauLang_1h", BenhAnNgoaiTru_ViemBiCo.TK_MauLang_1h));
                Command.Parameters.Add(new MDB.MDBParameter("TK_MauLang_2h", BenhAnNgoaiTru_ViemBiCo.TK_MauLang_2h));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_Ure", BenhAnNgoaiTru_ViemBiCo.TK_SinhHoa_Ure));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_Choles", BenhAnNgoaiTru_ViemBiCo.TK_SinhHoa_Choles));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_Na", BenhAnNgoaiTru_ViemBiCo.TK_SinhHoa_Na));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_Creatinin", BenhAnNgoaiTru_ViemBiCo.TK_SinhHoa_Creatinin));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_Trigly", BenhAnNgoaiTru_ViemBiCo.TK_SinhHoa_Trigly));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_K", BenhAnNgoaiTru_ViemBiCo.TK_SinhHoa_K));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_Glucose", BenhAnNgoaiTru_ViemBiCo.TK_SinhHoa_Glucose));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_Ldl", BenhAnNgoaiTru_ViemBiCo.TK_SinhHoa_Ldl));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_Cl", BenhAnNgoaiTru_ViemBiCo.TK_SinhHoa_Cl));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_Uric", BenhAnNgoaiTru_ViemBiCo.TK_SinhHoa_Uric));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_Hdl", BenhAnNgoaiTru_ViemBiCo.TK_SinhHoa_Hdl));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_Ast", BenhAnNgoaiTru_ViemBiCo.TK_SinhHoa_Ast));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_BiltP", BenhAnNgoaiTru_ViemBiCo.TK_SinhHoa_BiltP));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_Pro", BenhAnNgoaiTru_ViemBiCo.TK_SinhHoa_Pro));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_ALT", BenhAnNgoaiTru_ViemBiCo.TK_SinhHoa_ALT));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_BiltT", BenhAnNgoaiTru_ViemBiCo.TK_SinhHoa_BiltT));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_Alb", BenhAnNgoaiTru_ViemBiCo.TK_SinhHoa_Alb));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_Ck", BenhAnNgoaiTru_ViemBiCo.TK_SinhHoa_Ck));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_CrpHs", BenhAnNgoaiTru_ViemBiCo.TK_SinhHoa_CrpHs));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_CkMb", BenhAnNgoaiTru_ViemBiCo.TK_SinhHoa_CkMb));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_Khac", BenhAnNgoaiTru_ViemBiCo.TK_SinhHoa_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("TK_NuocTieu_Protein", BenhAnNgoaiTru_ViemBiCo.TK_NuocTieu_Protein));
                Command.Parameters.Add(new MDB.MDBParameter("TK_NuocTieu_ProteinNieu24h", BenhAnNgoaiTru_ViemBiCo.TK_NuocTieu_ProteinNieu24h));
                Command.Parameters.Add(new MDB.MDBParameter("TK_NuocTieu_Hc", BenhAnNgoaiTru_ViemBiCo.TK_NuocTieu_Hc));
                Command.Parameters.Add(new MDB.MDBParameter("TK_NuocTieu_Bc", BenhAnNgoaiTru_ViemBiCo.TK_NuocTieu_Bc));
                Command.Parameters.Add(new MDB.MDBParameter("TK_NuocTieu_Khac", BenhAnNgoaiTru_ViemBiCo.TK_NuocTieu_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("TK_CNHH_FVC", BenhAnNgoaiTru_ViemBiCo.TK_CNHH_FVC));
                Command.Parameters.Add(new MDB.MDBParameter("TK_CNHH_FEV1", BenhAnNgoaiTru_ViemBiCo.TK_CNHH_FEV1));
                Command.Parameters.Add(new MDB.MDBParameter("TK_CNHH_DuDoanFVC", BenhAnNgoaiTru_ViemBiCo.TK_CNHH_DuDoanFVC));
                Command.Parameters.Add(new MDB.MDBParameter("TK_CNHH_FEV1FVC", BenhAnNgoaiTru_ViemBiCo.TK_CNHH_FEV1FVC));
                Command.Parameters.Add(new MDB.MDBParameter("TK_CNHH_DlCo", BenhAnNgoaiTru_ViemBiCo.TK_CNHH_DlCo));
                Command.Parameters.Add(new MDB.MDBParameter("TK_CNHH_DuDoanDlCo", BenhAnNgoaiTru_ViemBiCo.TK_CNHH_DuDoanDlCo));
                Command.Parameters.Add(new MDB.MDBParameter("TK_XqTp", BenhAnNgoaiTru_ViemBiCo.TK_XqTp));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HrCt", BenhAnNgoaiTru_ViemBiCo.TK_HrCt));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SaOBung", BenhAnNgoaiTru_ViemBiCo.TK_SaOBung));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DienTim_TanSo", BenhAnNgoaiTru_ViemBiCo.TK_DienTim_TanSo));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DienTim_Nhip", BenhAnNgoaiTru_ViemBiCo.TK_DienTim_Nhip));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DienTim_Truc", BenhAnNgoaiTru_ViemBiCo.TK_DienTim_Truc));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DiemTim_Khac", BenhAnNgoaiTru_ViemBiCo.TK_DiemTim_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SaTimEF", BenhAnNgoaiTru_ViemBiCo.TK_SaTimEF));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SaTimPdmp", BenhAnNgoaiTru_ViemBiCo.TK_SaTimPdmp));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SaTim_Khac", BenhAnNgoaiTru_ViemBiCo.TK_SaTim_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_Ana", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_Ana));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_Ana_Duong", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_Ana_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_Ana_Am", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_Ana_Am));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_Anti155140", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_Anti155140));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_Anti155140_Duong", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_Anti155140_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_Anti155140_Am", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_Anti155140_Am));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_AntiPMScl", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_AntiPMScl));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_AntiPMScl_Duong", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_AntiPMScl_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_AntiPMScl_Am", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_AntiPMScl_Am));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_AntiARS", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_AntiARS));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_AntiARS_Duong", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_AntiARS_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_AntiARS_Am", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_AntiARS_Am));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_AntiCadm", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_AntiCadm));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_AntiCadm_Duong", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_AntiCadm_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_AntiCadm_Am", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_AntiCadm_Am));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_Ku", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_Ku));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_Ku_Duong", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_Ku_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_Ku_Am", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_Ku_Am));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_dsDNA", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_dsDNA));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_dsDNA_Duong", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_dsDNA_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_dsDNA_Am", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_dsDNA_Am));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_AntiU1RNP", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_AntiU1RNP));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_AntiU1RNP_Duong", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_AntiU1RNP_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_AntiU1RNP_Am", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_AntiU1RNP_Am));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_TIF1", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_TIF1));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_TIF1_Duong", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_TIF1_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_TIF1_Am", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_TIF1_Am));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_AntiJ01", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_AntiJ01));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_AntiJ01_Duong", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_AntiJ01_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_AntiJ01_Am", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_AntiJ01_Am));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_AntiSRP", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_AntiSRP));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_AntiSRP_Duong", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_AntiSRP_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_AntiSRP_Am", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_AntiSRP_Am));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_antiNXP2", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_antiNXP2));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_antiNXP2_Duong", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_antiNXP2_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_antiNXP2_Am", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_antiNXP2_Am));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_AntiMi2", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_AntiMi2));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_AntiMi2_Duong", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_AntiMi2_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_AntiMi2_Am", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_AntiMi2_Am));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_AntiMDA5", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_AntiMDA5));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_AntiMDA5_Duong", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_AntiMDA5_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_AntiMDA5_Am", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_AntiMDA5_Am));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_antiSAE", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_antiSAE));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_antiSAE_Duong", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_antiSAE_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_antiSAE_Am", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_antiSAE_Am));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhangThe_Khac", BenhAnNgoaiTru_ViemBiCo.TK_KhangThe_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("TK_KhamMat", BenhAnNgoaiTru_ViemBiCo.TK_KhamMat));
                Command.Parameters.Add(new MDB.MDBParameter("TK_ChuY", BenhAnNgoaiTru_ViemBiCo.TK_ChuY));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DieuTri", BenhAnNgoaiTru_ViemBiCo.TK_DieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TacDungPhuCuaThuoc", BenhAnNgoaiTru_ViemBiCo.TK_TacDungPhuCuaThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HenKham", BenhAnNgoaiTru_ViemBiCo.TK_HenKham));
                Command.Parameters.Add(new MDB.MDBParameter("TK_BacSiDieuTri", BenhAnNgoaiTru_ViemBiCo.TK_BacSiDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_MaBacSiDieuTri", BenhAnNgoaiTru_ViemBiCo.TK_MaBacSiDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnNgoaiTru_ViemBiCo.QuaTrinhBenhLy));
                Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQua", BenhAnNgoaiTru_ViemBiCo.TomTatKetQua));
                Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnNgoaiTru_ViemBiCo.BenhChinh));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhChinh", BenhAnNgoaiTru_ViemBiCo.MaBenhChinh));
                Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnNgoaiTru_ViemBiCo.BenhKemTheo));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhKemTheo", BenhAnNgoaiTru_ViemBiCo.MaBenhKemTheo));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnNgoaiTru_ViemBiCo.PhuongPhapDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangRaVien", BenhAnNgoaiTru_ViemBiCo.TinhTrangRaVien));
                Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnNgoaiTru_ViemBiCo.HuongDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnNgoaiTru_ViemBiCo.NguoiNhanHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnNgoaiTru_ViemBiCo.NguoiGiaoHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnNgoaiTru_ViemBiCo.NgayTongKet));
                Command.Parameters.Add(new MDB.MDBParameter("TongKet_BacSyDieuTri", BenhAnNgoaiTru_ViemBiCo.TongKet_BacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TongKet_MaBacSyDieuTri", BenhAnNgoaiTru_ViemBiCo.TongKet_MaBacSyDieuTri));

                Command.BindByName = true;

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnNgoaiTru_ViemBiCo.MaQuanLy));
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
