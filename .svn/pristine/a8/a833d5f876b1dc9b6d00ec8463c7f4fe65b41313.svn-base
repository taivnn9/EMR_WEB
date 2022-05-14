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
    public class BenhAnNgoaiTru_BenhVayNenThongThuongFunc
    {
        public static void WriteXml(MDB.MDBConnection MyConnection)
        {
            string sql =
                   @"
                  select  a.*,  CTScanner HoSo_CTScanner, SieuAm HoSo_SieuAm, XetNghiem HoSo_XetNghiem,  Khac HoSo_Khac,  Khac_Text HoSo_Khac_Text,  ToanBoHoSo HoSo_ToanBoHoSo, Mach DauSinhTon_Mach,  NhietDo DauSinhTon_NhietDo,  HuyetAp DauSinhTon_HuyetAp,  NhipTho DauSinhTon_NhipTho,  CanNang DauSinhTon_CanNang  
                  from BenhAnVayNenThongThuong a inner join thongtindieutri b on a.maquanly = b.maquanly
                  where rownum = 1
                    ";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            var DataTable = new DataTable { TableName = "BenhAnVayNenThongThuong" };
            DataTable.Load(DataReader as IDataReader);
            DataTable.WriteXml("rptBenhAnVayNenThongThuong.xml");
        }
        public static DataSet SelectDataSet(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql =
                   @"
                  select  a.*, f.hovaten BacSyDieuTriHoVaTen, d.hovaten NguoiGiaoHoSoHoVaTen,e.hovaten NguoiNhanHoSoHoVaTen, b.XQuang HoSo_XQuang, b.CTScanner HoSo_CTScanner, b.SieuAm HoSo_SieuAm, b.XetNghiem HoSo_XetNghiem,  b.Khac HoSo_Khac,  b.Khac_Text HoSo_Khac_Text,  b.ToanBoHoSo HoSo_ToanBoHoSo
                        from BenhAnVayNenThongThuong a  
                  left join thongtindieutri b on a.maquanly = b.maquanly 
                  left join nhanvien f on a.BacSyDieuTri = f.manhanvien
                  left join nhanvien d on a.NguoiGiaoHoSo = d.manhanvien
                  left join nhanvien e on a.NguoiNhanHoSo = e.manhanvien where a.maquanly = " + MaQuanLy.ToString(System.Globalization.CultureInfo.InvariantCulture);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(sql, MyConnection);
            var ds = new DataSet();
            adt.Fill(ds, "Table");
            List<ThuocToanThan> Methotrexate = new List<ThuocToanThan>();
            List<ThuocToanThan> VitaminAAcid = new List<ThuocToanThan>();
            List<ThuocToanThan> Cyclosporine = new List<ThuocToanThan>();
            List<ThuocToanThan> Corticosteroid = new List<ThuocToanThan>();
            List<ThuocToanThan> ChePhamSinhHoc1 = new List<ThuocToanThan>();
            List<ThuocToanThan> ChePhamSinhHoc2 = new List<ThuocToanThan>();
            List<ThuocToanThan> ChePhamSinhHoc3 = new List<ThuocToanThan>();
            List<ThuocToanThan> YHocCoTruyen = new List<ThuocToanThan>();
            List<ThuocToanThan> ThuocKhac = new List<ThuocToanThan>();
            List<DiemNAPSI> NAPSI_TayPhai = new List<DiemNAPSI>();
            List<DiemNAPSI> NAPSI_TayTrai = new List<DiemNAPSI>();
            List<DiemNAPSI> NAPSI_ChanPhai = new List<DiemNAPSI>();
            List<DiemNAPSI> NAPSI_ChanTrai = new List<DiemNAPSI>();

            try
            {
                sql = @"SELECT Methotrexate,
                            VitaminAAcid,
                            Cyclosporine,
                            Corticosteroid,
                            ChePhamSinhHoc1,
                            ChePhamSinhHoc2,
                            ChePhamSinhHoc3,
                            YHocCoTruyen,
                            ThuocKhac,
                            NAPSI_TayPhai,
                            NAPSI_TayTrai,
                            NAPSI_ChanPhai,
                            NAPSI_ChanTrai
                            FROM BenhAnVayNenThongThuong where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    Methotrexate.Add(JsonConvert.DeserializeObject<ThuocToanThan>(DataReader["Methotrexate"].ToString()));
                    VitaminAAcid.Add(JsonConvert.DeserializeObject<ThuocToanThan>(DataReader["VitaminAAcid"].ToString()));
                    Cyclosporine.Add(JsonConvert.DeserializeObject<ThuocToanThan>(DataReader["Cyclosporine"].ToString()));
                    Corticosteroid.Add(JsonConvert.DeserializeObject<ThuocToanThan>(DataReader["Corticosteroid"].ToString()));
                    ChePhamSinhHoc1.Add(JsonConvert.DeserializeObject<ThuocToanThan>(DataReader["ChePhamSinhHoc1"].ToString()));
                    ChePhamSinhHoc2.Add(JsonConvert.DeserializeObject<ThuocToanThan>(DataReader["ChePhamSinhHoc2"].ToString()));
                    ChePhamSinhHoc3.Add(JsonConvert.DeserializeObject<ThuocToanThan>(DataReader["ChePhamSinhHoc3"].ToString()));
                    YHocCoTruyen.Add(JsonConvert.DeserializeObject<ThuocToanThan>(DataReader["YHocCoTruyen"].ToString()));
                    ThuocKhac.Add(JsonConvert.DeserializeObject<ThuocToanThan>(DataReader["ThuocKhac"].ToString()));

                    NAPSI_TayPhai.Add(JsonConvert.DeserializeObject<DiemNAPSI>(DataReader["NAPSI_TayPhai"].ToString()));
                    NAPSI_TayTrai.Add(JsonConvert.DeserializeObject<DiemNAPSI>(DataReader["NAPSI_TayTrai"].ToString()));
                    NAPSI_ChanPhai.Add(JsonConvert.DeserializeObject<DiemNAPSI>(DataReader["NAPSI_ChanPhai"].ToString()));
                    NAPSI_ChanTrai.Add(JsonConvert.DeserializeObject<DiemNAPSI>(DataReader["NAPSI_ChanTrai"].ToString()));
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }

            ds.Tables.Add(Common.ListToDataTable(Methotrexate, "Methotrexate"));
            ds.Tables.Add(Common.ListToDataTable(VitaminAAcid, "VitaminAAcid"));
            ds.Tables.Add(Common.ListToDataTable(Cyclosporine, "Cyclosporine"));
            ds.Tables.Add(Common.ListToDataTable(Corticosteroid, "Corticosteroid"));
            ds.Tables.Add(Common.ListToDataTable(ChePhamSinhHoc1, "ChePhamSinhHoc1"));
            ds.Tables.Add(Common.ListToDataTable(ChePhamSinhHoc2, "ChePhamSinhHoc2"));
            ds.Tables.Add(Common.ListToDataTable(ChePhamSinhHoc3, "ChePhamSinhHoc3"));
            ds.Tables.Add(Common.ListToDataTable(YHocCoTruyen, "YHocCoTruyen"));
            ds.Tables.Add(Common.ListToDataTable(ThuocKhac, "ThuocKhac"));
            ds.Tables.Add(Common.ListToDataTable(NAPSI_TayPhai, "NAPSI_TayPhai"));
            ds.Tables.Add(Common.ListToDataTable(NAPSI_TayTrai, "NAPSI_TayTrai"));
            ds.Tables.Add(Common.ListToDataTable(NAPSI_ChanPhai, "NAPSI_ChanPhai"));
            ds.Tables.Add(Common.ListToDataTable(NAPSI_ChanTrai, "NAPSI_ChanTrai"));

            return ds;

        }
        public static BenhAnNgoaiTru_BenhVayNenThongThuong Select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            var obj = new BenhAnNgoaiTru_BenhVayNenThongThuong();
            try
            {
                #region
                string sql =
                          @"select * 
                        from BenhAnVayNenThongThuong 
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
                    obj.KhoiPhatBenh = DataReader["KhoiPhatBenh"].ToString();
                    obj.TrieuChungDauTien = DataReader["TrieuChungDauTien"].ToString();
                    obj.LanNhapVien = DataReader["LanNhapVien"].ToString();
                    obj.TSGD_MacVayNen = DataReader.GetInt("TSGD_MacVayNen");
                    obj.TSGD_MacVayNen_Text = DataReader["TSGD_MacVayNen_Text"].ToString();
                    obj.TSCN_BenhKhac = DataReader.GetInt("TSCN_BenhKhac");
                    obj.TienSuCaNhan = DataReader["TienSuCaNhan"].ToString();
                    obj.TienSuCaNhan_Khac = DataReader["TienSuCaNhan_Khac"].ToString();
                    obj.ThoiQuenCaNhan = DataReader["ThoiQuenCaNhan"].ToString();
                    obj.ThoiQuenCaNhan_Khac = DataReader["ThoiQuenCaNhan_Khac"].ToString();
                    obj.YeuToTinhThan = DataReader.GetInt("YeuToTinhThan");
                    obj.ViTriKhoiPhat = DataReader["ViTriKhoiPhat"].ToString();
                    obj.ViTriKhoiPhat_Khac = DataReader["ViTriKhoiPhat_Khac"].ToString();
                    obj.ThoiQuenCaNhan2 = DataReader["ThoiQuenCaNhan2"].ToString();
                    obj.ThoiQuenCaNhan2_Khac = DataReader["ThoiQuenCaNhan2_Khac"].ToString();
                    obj.YeuToTinhThan2 = DataReader.GetInt("YeuToTinhThan2");
                    obj.ViTriKhoiPhat2 = DataReader["ViTriKhoiPhat2"].ToString();
                    obj.ViTriKhoiPhat2_Khac = DataReader["ViTriKhoiPhat2_Khac"].ToString();
                    obj.MuaNang = DataReader["MuaNang"].ToString();
                    // 3. Toàn trạng
                    obj.Sot = DataReader.GetInt("Sot");
                    obj.Sot_Do = DataReader["Sot_Do"].ToString();
                    obj.Hach = DataReader.GetInt("Hach");
                    obj.MetMoi = DataReader.GetInt("MetMoi");
                    obj.HA = DataReader["HA"].ToString();
                    obj.Mach = DataReader["Mach"].ToString();
                    obj.TrieuChungCoNang = DataReader["TrieuChungCoNang"].ToString();
                    obj.Can = DataReader["Can"].ToString();
                    obj.Cao = DataReader["Cao"].ToString();
                    obj.VongBung = DataReader["VongBung"].ToString();
                    // 4. Lâm sàng da
                    obj.PhanLoaiTheoKT = DataReader["PhanLoaiTheoKT"].ToString();
                    obj.PhanLoaiTheoVT = DataReader["PhanLoaiTheoVT"].ToString();
                    obj.PhanLoaiTheoMD = DataReader["PhanLoaiTheoMD"].ToString();
                    obj.NgayDanhGiaPASI = DataReader["NgayDanhGiaPASI"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayDanhGiaPASI"]) : null;
                    obj.DiemPasi1 = DataReader["DiemPasi1"].ToString();
                    obj.DiemPasi2 = DataReader["DiemPasi2"].ToString();
                    obj.DiemPasi3 = DataReader["DiemPasi3"].ToString();
                    obj.DiemPasi4 = DataReader["DiemPasi4"].ToString();
                    obj.DiemPasi = DataReader["DiemPasi"].ToString();
                    obj.DiemPasi_Text = DataReader["DiemPasi_Text"].ToString();
                    obj.DanhGiaPASI = DataReader["DanhGiaPASI"].ToString();
                    // 5. biểu hiện móng
                    obj.RoMong = DataReader.GetInt("RoMong");
                    obj.RoMong_Text = DataReader["RoMong_Text"].ToString();
                    obj.MongDay_Mun = DataReader.GetInt("MongDay_Mun");
                    obj.DuongVanNgang = DataReader.GetInt("DuongVanNgang");
                    obj.LiemMong = DataReader.GetInt("LiemMong");
                    obj.TachMong = DataReader.GetInt("TachMong");
                    obj.TachMong_Text = DataReader["TachMong_Text"].ToString();
                    obj.DaySung = DataReader.GetInt("DaySung");
                    obj.DauHieuGiotDau = DataReader.GetInt("DauHieuGiotDau");
                    obj.DauHieuGiotDau_Text = DataReader["DauHieuGiotDau_Text"].ToString();
                    obj.XuatHuyet = DataReader.GetInt("XuatHuyet");
                    obj.ViemQuanhMong = DataReader.GetInt("ViemQuanhMong");
                    obj.NAPSI_TayPhai = JsonConvert.DeserializeObject<DiemNAPSI>(DataReader["NAPSI_TayPhai"].ToString());
                    obj.NAPSI_TayTrai = JsonConvert.DeserializeObject<DiemNAPSI>(DataReader["NAPSI_TayTrai"].ToString());
                    obj.NAPSI_ChanPhai = JsonConvert.DeserializeObject<DiemNAPSI>(DataReader["NAPSI_ChanPhai"].ToString());
                    obj.NAPSI_ChanTrai = JsonConvert.DeserializeObject<DiemNAPSI>(DataReader["NAPSI_ChanTrai"].ToString());
                    obj.TongDiemNAPSI = DataReader["TongDiemNAPSI"].ToString();
                    //6. bieu hien khop
                    obj.SoKhopDau = DataReader["SoKhopDau"].ToString();
                    obj.SoKhopSung = DataReader["SoKhopSung"].ToString();
                    obj.DAS28 = DataReader["DAS28"].ToString();
                    obj.ViemKhop = DataReader["ViemKhop"].ToString();
                    obj.BienDangKhop = DataReader.GetInt("BienDangKhop");
                    obj.BienDangKhop_Text = DataReader["BienDangKhop_Text"].ToString();
                    // 7. biểu hiện niêm mạc
                    obj.BieuHienNiemMac = DataReader.GetInt("BieuHienNiemMac");
                    obj.BieuHienNiemMac_ViTri = DataReader["BieuHienNiemMac_ViTri"].ToString();
                    //8. Các biểu hiện lâm sàng khác
                    obj.BieuHienKhac_TimMach = DataReader["BieuHienKhac_TimMach"].ToString();
                    obj.BieuHienKhac_HoHap = DataReader["BieuHienKhac_HoHap"].ToString();
                    obj.BieuHienKhac_TieuHoa = DataReader["BieuHienKhac_TieuHoa"].ToString();
                    obj.BieuHienKhac_TamThan = DataReader["BieuHienKhac_TamThan"].ToString();
                    // 9. ĐIỂM DLQI (Dermatology life Quality index)
                    obj.DiemDLQI_1 = DataReader.GetInt("DiemDLQI_1");
                    obj.DiemDLQI_2 = DataReader.GetInt("DiemDLQI_2");
                    obj.DiemDLQI_3 = DataReader.GetInt("DiemDLQI_3");
                    obj.DiemDLQI_4 = DataReader.GetInt("DiemDLQI_4");
                    obj.DiemDLQI_5 = DataReader.GetInt("DiemDLQI_5");
                    obj.DiemDLQI_6 = DataReader.GetInt("DiemDLQI_6");
                    obj.DiemDLQI_7 = DataReader.GetInt("DiemDLQI_7");
                    obj.DiemDLQI_8 = DataReader.GetInt("DiemDLQI_8");
                    obj.DiemDLQI_9 = DataReader.GetInt("DiemDLQI_9");
                    obj.DiemDLQI_10 = DataReader.GetInt("DiemDLQI_10");
                    obj.TongDiem = DataReader["TongDiem"].ToString();
                    // 10. xét nghiệm
                    obj.CTM_HC = DataReader["CTM_HC"].ToString();
                    obj.CTM_Hb = DataReader["CTM_Hb"].ToString();
                    obj.CTM_HCT = DataReader["CTM_HCT"].ToString();
                    obj.CTM_TieuCau = DataReader["CTM_TieuCau"].ToString();
                    obj.CTM_BachCau = DataReader["CTM_BachCau"].ToString();
                    obj.CTM_Lympho = DataReader["CTM_Lympho"].ToString();
                    obj.CTM_TT = DataReader["CTM_TT"].ToString();
                    obj.CTM_Mono = DataReader["CTM_Mono"].ToString();
                    obj.MauLang_1 = DataReader["MauLang_1"].ToString();
                    obj.MauLang_2 = DataReader["MauLang_2"].ToString();
                    obj.SinhHoa_Ure = DataReader["SinhHoa_Ure"].ToString();
                    obj.SinhHoa_Cre1 = DataReader["SinhHoa_Cre1"].ToString();
                    obj.SinhHoa_Glu = DataReader["SinhHoa_Glu"].ToString();
                    obj.SinhHoa_Cre2 = DataReader["SinhHoa_Cre2"].ToString();
                    obj.SinhHoa_Uric = DataReader["SinhHoa_Uric"].ToString();
                    obj.SinhHoa_TP = DataReader["SinhHoa_TP"].ToString();
                    obj.SinhHoa_TT = DataReader["SinhHoa_TT"].ToString();
                    obj.SinhHoa_GT = DataReader["SinhHoa_GT"].ToString();
                    obj.SinhHoa_ProteinTP = DataReader["SinhHoa_ProteinTP"].ToString();
                    obj.SinhHoa_Alb = DataReader["SinhHoa_Alb"].ToString();
                    obj.SinhHoa_Cholesterol = DataReader["SinhHoa_Cholesterol"].ToString();
                    obj.SinhHoa_Tri = DataReader["SinhHoa_Tri"].ToString();
                    obj.SinhHoa_HDL = DataReader["SinhHoa_HDL"].ToString();
                    obj.SinhHoa_LDL = DataReader["SinhHoa_LDL"].ToString();
                    obj.SinhHoa_GOT = DataReader["SinhHoa_GOT"].ToString();
                    obj.SinhHoa_GPT = DataReader["SinhHoa_GPT"].ToString();
                    obj.SinhHoa_CK = DataReader["SinhHoa_CK"].ToString();
                    obj.SinhHoa_DGD_Na = DataReader["SinhHoa_DGD_Na"].ToString();
                    obj.SinhHoa_DGD_K = DataReader["SinhHoa_DGD_K"].ToString();
                    obj.SinhHoa_DGD_Cl = DataReader["SinhHoa_DGD_Cl"].ToString();
                    obj.SinhHoa_DGD_Ca = DataReader["SinhHoa_DGD_Ca"].ToString();
                    obj.SinhHoa_DGD_CaIonHoa = DataReader["SinhHoa_DGD_CaIonHoa"].ToString();
                    obj.SinhHoa_DGD_HbA1c = DataReader["SinhHoa_DGD_HbA1c"].ToString();
                    obj.ProteinNieu = DataReader.GetInt("ProteinNieu");
                    obj.TruNieu = DataReader.GetInt("TruNieu");
                    obj.HCNieu = DataReader.GetInt("HCNieu");
                    obj.BCNieu = DataReader.GetInt("BCNieu");
                    obj.NuocTieu24H = DataReader.GetInt("NuocTieu24H");
                    obj.XQXuongKhop = DataReader["XQXuongKhop"].ToString();
                    obj.SinhThiet_NgayLam = DataReader["SinhThiet_NgayLam"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["SinhThiet_NgayLam"]) : null;
                    obj.SinhThiet_ViTri = DataReader["SinhThiet_ViTri"].ToString();
                    obj.ThuongBi_ASung = DataReader.GetInt("ThuongBi_ASung");
                    obj.ThuongBi_TangSung = DataReader.GetInt("ThuongBi_TangSung");
                    obj.ThuongBi_GiamLopHat = DataReader.GetInt("ThuongBi_GiamLopHat");
                    obj.ThuongBi_PhiaTrenNhuBi = DataReader.GetInt("ThuongBi_PhiaTrenNhuBi");
                    obj.ThuongBi_ViApsxe = DataReader.GetInt("ThuongBi_ViApsxe");
                    obj.ThuongBi_MunMu = DataReader.GetInt("ThuongBi_MunMu");
                    obj.ThuongBi_QuaSan = DataReader.GetInt("ThuongBi_QuaSan");
                    obj.ThuongBi_GianMachMau = DataReader.GetInt("ThuongBi_GianMachMau");
                    obj.TrungBi_ThamNhiem = DataReader.GetInt("TrungBi_ThamNhiem");
                    obj.TrungBi_Lympho = DataReader.GetInt("TrungBi_Lympho");
                    obj.TrungBi_Khac = DataReader["TrungBi_Khac"].ToString();
                    obj.SinhThietMong = DataReader["SinhThietMong"].ToString();
                    obj.Interleukin_NgayLayMau = DataReader["Interleukin_NgayLayMau"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["Interleukin_NgayLayMau"]) : null;
                    obj.Interleukin_IL17 = DataReader["Interleukin_IL17"].ToString();
                    obj.Interleukin_IL23 = DataReader["Interleukin_IL23"].ToString();
                    obj.XetNghiemKhac = DataReader["XetNghiemKhac"].ToString();
                    // 11. Điều trị 
                    obj.ThuocTieuSung = DataReader.GetInt("ThuocTieuSung");
                    obj.ThuocGiuAm = DataReader.GetInt("ThuocGiuAm");
                    obj.Corticorid = DataReader.GetInt("Corticorid");
                    obj.Calcipotriol = DataReader.GetInt("Calcipotriol");
                    obj.VitaminA = DataReader.GetInt("VitaminA");
                    obj.Tarcrolimus = DataReader.GetInt("Tarcrolimus");
                    obj.ThuocBoi_Khac = DataReader["ThuocBoi_Khac"].ToString();
                    obj.Methotrexate = JsonConvert.DeserializeObject<ThuocToanThan>(DataReader["Methotrexate"].ToString());
                    obj.VitaminAAcid = JsonConvert.DeserializeObject<ThuocToanThan>(DataReader["VitaminAAcid"].ToString());
                    obj.Cyclosporine = JsonConvert.DeserializeObject<ThuocToanThan>(DataReader["Cyclosporine"].ToString());
                    obj.Corticosteroid = JsonConvert.DeserializeObject<ThuocToanThan>(DataReader["Corticosteroid"].ToString());
                    obj.ChePhamSinhHoc1 = JsonConvert.DeserializeObject<ThuocToanThan>(DataReader["ChePhamSinhHoc1"].ToString());
                    obj.ChePhamSinhHoc2 = JsonConvert.DeserializeObject<ThuocToanThan>(DataReader["ChePhamSinhHoc2"].ToString());
                    obj.ChePhamSinhHoc3 = JsonConvert.DeserializeObject<ThuocToanThan>(DataReader["ChePhamSinhHoc3"].ToString());
                    obj.YHocCoTruyen = JsonConvert.DeserializeObject<ThuocToanThan>(DataReader["YHocCoTruyen"].ToString());
                    obj.ThuocKhac = JsonConvert.DeserializeObject<ThuocToanThan>(DataReader["ThuocKhac"].ToString());
                    obj.DieuTriAnhSang = DataReader.GetInt("DieuTriAnhSang");
                    obj.DieuTriAnhSang_Co = DataReader["DieuTriAnhSang_Co"].ToString();
                    //13. Điều trị 
                    obj.PPDieuTri = DataReader["PPDieuTri"].ToString();
                    obj.DieuTri_CuThe = DataReader["DieuTri_CuThe"].ToString();
                    obj.HenKhamLai = DataReader["HenKhamLai"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["HenKhamLai"]) : null;
                    obj.BacSyKhamBenh = DataReader["BacSyKhamBenh"].ToString();
                    obj.MaBacSyKhambenh = DataReader["MaBacSyKhambenh"].ToString();
                    // Phần tái khám
                    obj.TK_HoTen = DataReader["TK_HoTen"].ToString();
                    obj.TK_SoBADienTu = DataReader["TK_SoBADienTu"].ToString();
                    obj.TK_Ngay = DataReader["TK_Ngay"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["TK_Ngay"]) : null;
                    obj.TK_SoLuuTru = DataReader["TK_SoLuuTru"].ToString();
                    obj.TK_Sot = DataReader.GetInt("TK_Sot");
                    obj.TK_Sot_Do = DataReader["TK_Sot_Do"].ToString();
                    obj.TK_Hach = DataReader.GetInt("TK_Hach");
                    obj.TK_MetMoi = DataReader.GetInt("TK_MetMoi");
                    obj.TK_HA = DataReader["TK_HA"].ToString();
                    obj.TK_Mach = DataReader["TK_Mach"].ToString();
                    obj.TK_TrieuChungCoNang = DataReader["TK_TrieuChungCoNang"].ToString();
                    obj.TK_TienSu = DataReader["TK_TienSu"].ToString();
                    obj.TK_DiemPasi1 = DataReader["TK_DiemPasi1"].ToString();
                    obj.TK_DiemPasi2 = DataReader["TK_DiemPasi2"].ToString();
                    obj.TK_DiemPasi3 = DataReader["TK_DiemPasi3"].ToString();
                    obj.TK_DiemPasi4 = DataReader["TK_DiemPasi4"].ToString();
                    obj.TK_DiemPasi = DataReader["TK_DiemPasi"].ToString();
                    obj.TK_DiemPasi_Text = DataReader["TK_DiemPasi_Text"].ToString();
                    obj.TK_TongDiemNAPSI = DataReader["TK_TongDiemNAPSI"].ToString();
                    obj.TK_SoKhopDau = DataReader["TK_SoKhopDau"].ToString();
                    obj.TK_SoKhopSung = DataReader["TK_SoKhopSung"].ToString();
                    obj.TK_DAS28 = DataReader["TK_DAS28"].ToString();
                    obj.TK_ViemKhop = DataReader["TK_ViemKhop"].ToString();
                    obj.TK_BienDangKhop = DataReader.GetInt("TK_BienDangKhop");
                    obj.TK_BienDangKhop_Text = DataReader["TK_BienDangKhop_Text"].ToString();
                    // 7. biểu hiện niêm mạc
                    obj.TK_BieuHienNiemMac = DataReader.GetInt("TK_BieuHienNiemMac");
                    obj.TK_BieuHienNiemMac_ViTri = DataReader["TK_BieuHienNiemMac_ViTri"].ToString();
                    //8. Các biểu hiện lâm sàng khác
                    obj.TK_BieuHienKhac_TimMach = DataReader["TK_BieuHienKhac_TimMach"].ToString();
                    obj.TK_BieuHienKhac_TietNieu = DataReader["TK_BieuHienKhac_TietNieu"].ToString();
                    obj.TK_BieuHienKhac_HoHap = DataReader["TK_BieuHienKhac_HoHap"].ToString();
                    obj.TK_BieuHienKhac_TieuHoa = DataReader["TK_BieuHienKhac_TieuHoa"].ToString();
                    obj.TK_BieuHienKhac_TamThan = DataReader["TK_BieuHienKhac_TamThan"].ToString();
                    obj.TK_BieuHienKhac_CoQuanKhac = DataReader["TK_BieuHienKhac_CoQuanKhac"].ToString();
                    // 9. ĐIỂM DLQI (Dermatology life Quality index)
                    obj.TK_DiemDLQI_1 = DataReader.GetInt("TK_DiemDLQI_1");
                    obj.TK_DiemDLQI_2 = DataReader.GetInt("TK_DiemDLQI_2");
                    obj.TK_DiemDLQI_3 = DataReader.GetInt("TK_DiemDLQI_3");
                    obj.TK_DiemDLQI_4 = DataReader.GetInt("TK_DiemDLQI_4");
                    obj.TK_DiemDLQI_5 = DataReader.GetInt("TK_DiemDLQI_5");
                    obj.TK_DiemDLQI_6 = DataReader.GetInt("TK_DiemDLQI_6");
                    obj.TK_DiemDLQI_7 = DataReader.GetInt("TK_DiemDLQI_7");
                    obj.TK_DiemDLQI_8 = DataReader.GetInt("TK_DiemDLQI_8");
                    obj.TK_DiemDLQI_9 = DataReader.GetInt("TK_DiemDLQI_9");
                    obj.TK_DiemDLQI_10 = DataReader.GetInt("TK_DiemDLQI_10");
                    obj.TK_TongDiem = DataReader["TK_TongDiem"].ToString();
                    obj.TK_CTM_HC = DataReader["TK_CTM_HC"].ToString();
                    obj.TK_CTM_Hb = DataReader["TK_CTM_Hb"].ToString();
                    obj.TK_CTM_HCT = DataReader["TK_CTM_HCT"].ToString();
                    obj.TK_CTM_TieuCau = DataReader["TK_CTM_TieuCau"].ToString();
                    obj.TK_CTM_BachCau = DataReader["TK_CTM_BachCau"].ToString();
                    obj.TK_CTM_Lympho = DataReader["TK_CTM_Lympho"].ToString();
                    obj.TK_CTM_TT = DataReader["TK_CTM_TT"].ToString();
                    obj.TK_CTM_Mono = DataReader["TK_CTM_Mono"].ToString();
                    obj.TK_CTM_Khac = DataReader["TK_CTM_Khac"].ToString();
                    obj.TK_MauLang_1 = DataReader["TK_MauLang_1"].ToString();
                    obj.TK_MauLang_2 = DataReader["TK_MauLang_2"].ToString();
                    obj.TK_SinhHoa_Ure = DataReader["TK_SinhHoa_Ure"].ToString();
                    obj.TK_SinhHoa_Cre = DataReader["TK_SinhHoa_Cre"].ToString();
                    obj.TK_SinhHoa_Glu = DataReader["TK_SinhHoa_Glu"].ToString();
                    obj.TK_SinhHoa_Uric = DataReader["TK_SinhHoa_Uric"].ToString();
                    obj.TK_SinhHoa_TP = DataReader["TK_SinhHoa_TP"].ToString();
                    obj.TK_SinhHoa_TT = DataReader["TK_SinhHoa_TT"].ToString();
                    obj.TK_SinhHoa_GT = DataReader["TK_SinhHoa_GT"].ToString();
                    obj.TK_SinhHoa_Protein = DataReader["TK_SinhHoa_Protein"].ToString();
                    obj.TK_SinhHoa_Alb = DataReader["TK_SinhHoa_Alb"].ToString();
                    obj.TK_SinhHoa_Cholesterol = DataReader["TK_SinhHoa_Cholesterol"].ToString();
                    obj.TK_SinhHoa_Tri = DataReader["TK_SinhHoa_Tri"].ToString();
                    obj.TK_SinhHoa_HDL = DataReader["TK_SinhHoa_HDL"].ToString();
                    obj.TK_SinhHoa_LDL = DataReader["TK_SinhHoa_LDL"].ToString();
                    obj.TK_SinhHoa_GOT = DataReader["TK_SinhHoa_GOT"].ToString();
                    obj.TK_SinhHoa_GPT = DataReader["TK_SinhHoa_GPT"].ToString();
                    obj.TK_SinhHoa_CK = DataReader["TK_SinhHoa_CK"].ToString();
                    obj.TK_SinhHoa_DGD_Na = DataReader["TK_SinhHoa_DGD_Na"].ToString();
                    obj.TK_SinhHoa_DGD_K = DataReader["TK_SinhHoa_DGD_K"].ToString();
                    obj.TK_SinhHoa_DGD_Cl = DataReader["TK_SinhHoa_DGD_Cl"].ToString();
                    obj.TK_SinhHoa_DGD_Ca = DataReader["TK_SinhHoa_DGD_Ca"].ToString();
                    obj.TK_SinhHoa_DGD_CaIonHoa = DataReader["TK_SinhHoa_DGD_CaIonHoa"].ToString();
                    obj.STK_inhHoa_DGD_HbA1c = DataReader["STK_inhHoa_DGD_HbA1c"].ToString();
                    obj.TK_ProteinNieu = DataReader.GetInt("TK_ProteinNieu");
                    obj.TK_TruNieu = DataReader.GetInt("TK_TruNieu");
                    obj.TK_HCNieu = DataReader.GetInt("TK_HCNieu");
                    obj.TK_BCNieu = DataReader.GetInt("TK_BCNieu");
                    obj.TK_XetNghiemKhac = DataReader["TK_XetNghiemKhac"].ToString();
                    obj.TK_TacDungPhu = DataReader.GetInt("TK_TacDungPhu");
                    obj.TK_TenThuoc = DataReader["TK_TenThuoc"].ToString();
                    obj.TK_LietKeTacDungPhu = DataReader["TK_LietKeTacDungPhu"].ToString();
                    obj.TK_ThuocBoi = DataReader["TK_ThuocBoi"].ToString();
                    obj.TK_ThuocToanThan = DataReader["TK_ThuocToanThan"].ToString();
                    obj.TK_HenKhamLai = DataReader["TK_HenKhamLai"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["TK_HenKhamLai"]) : null;
                    obj.TK_BacSyDieuTri = DataReader["TK_BacSyDieuTri"].ToString();
                    obj.TK_MaBacSyDieuTri = DataReader["TK_MaBacSyDieuTri"].ToString();
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
                    obj.NgayTongKet = Convert.ToDateTime(DataReader["NgayTongKet"]);
                    obj.BacSyDieuTri = DataReader["BacSyDieuTri"].ToString();
                }

            }
            catch (Exception ex)
            {
                XuLyLoi.LogError(ex);
            }

            return obj;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, BenhAnNgoaiTru_BenhVayNenThongThuong BenhAnNgoaiTru_BenhVayNenThongThuong)
        {
            string sql =
                      @"select MaQuanLy 
                        from BenhAnVayNenThongThuong
                        where MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnNgoaiTru_BenhVayNenThongThuong.MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            int rowCount = 0;
            while (DataReader.Read()) rowCount++;
            if (rowCount == 1) return Update(MyConnection, BenhAnNgoaiTru_BenhVayNenThongThuong);
            sql = @"
                   INSERT INTO BenhAnVayNenThongThuong 
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
                        KhoiPhatBenh,
                        TrieuChungDauTien,
                        LanNhapVien,
                        TSGD_MacVayNen,
                        TSGD_MacVayNen_Text,
                        TSCN_BenhKhac,
                        TienSuCaNhan,
                        TienSuCaNhan_Khac,
                        ThoiQuenCaNhan,
                        ThoiQuenCaNhan_Khac,
                        YeuToTinhThan,
                        ViTriKhoiPhat,
                        ViTriKhoiPhat_Khac,
                        ThoiQuenCaNhan2,
                        ThoiQuenCaNhan2_Khac,
                        YeuToTinhThan2,
                        ViTriKhoiPhat2,
                        ViTriKhoiPhat2_Khac,
                        MuaNang,
                        Sot,
                        Sot_Do,
                        Hach,
                        MetMoi,
                        HA,
                        Mach,
                        TrieuChungCoNang,
                        Can,
                        Cao,
                        VongBung,
                        PhanLoaiTheoKT,
                        PhanLoaiTheoVT,
                        PhanLoaiTheoMD,
                        NgayDanhGiaPASI,
                        DiemPasi1,
                        DiemPasi2,
                        DiemPasi3,
                        DiemPasi4,
                        DiemPasi,
                        DiemPasi_Text,
                        DanhGiaPASI,
                        RoMong,
                        RoMong_Text,
                        MongDay_Mun,
                        DuongVanNgang,
                        LiemMong,
                        TachMong,
                        TachMong_Text,
                        DaySung,
                        DauHieuGiotDau,
                        DauHieuGiotDau_Text,
                        XuatHuyet,
                        ViemQuanhMong,
                        NAPSI_TayPhai,
                        NAPSI_TayTrai,
                        NAPSI_ChanPhai,
                        NAPSI_ChanTrai,
                        TongDiemNAPSI,
                        SoKhopDau,
                        SoKhopSung,
                        DAS28,
                        ViemKhop,
                        BienDangKhop,
                        BienDangKhop_Text,
                        BieuHienNiemMac,
                        BieuHienNiemMac_ViTri,
                        BieuHienKhac_TimMach,
                        BieuHienKhac_HoHap,
                        BieuHienKhac_TieuHoa,
                        BieuHienKhac_TamThan,
                        DiemDLQI_1,
                        DiemDLQI_2,
                        DiemDLQI_3,
                        DiemDLQI_4,
                        DiemDLQI_5,
                        DiemDLQI_6,
                        DiemDLQI_7,
                        DiemDLQI_8,
                        DiemDLQI_9,
                        DiemDLQI_10,
                        TongDiem,
                        CTM_HC,
                        CTM_Hb,
                        CTM_HCT,
                        CTM_TieuCau,
                        CTM_BachCau,
                        CTM_Lympho,
                        CTM_TT,
                        CTM_Mono,
                        MauLang_1,
                        MauLang_2,
                        SinhHoa_Ure,
                        SinhHoa_Cre1,
                        SinhHoa_Glu,
                        SinhHoa_Cre2,
                        SinhHoa_Uric,
                        SinhHoa_TP,
                        SinhHoa_TT,
                        SinhHoa_GT,
                        SinhHoa_ProteinTP,
                        SinhHoa_Alb,
                        SinhHoa_Cholesterol,
                        SinhHoa_Tri,
                        SinhHoa_HDL,
                        SinhHoa_LDL,
                        SinhHoa_GOT,
                        SinhHoa_GPT,
                        SinhHoa_CK,
                        SinhHoa_DGD_Na,
                        SinhHoa_DGD_K,
                        SinhHoa_DGD_Cl,
                        SinhHoa_DGD_Ca,
                        SinhHoa_DGD_CaIonHoa,
                        SinhHoa_DGD_HbA1c,
                        ProteinNieu,
                        TruNieu,
                        HCNieu,
                        BCNieu,
                        NuocTieu24H,
                        XQXuongKhop,
                        SinhThiet_NgayLam,
                        SinhThiet_ViTri,
                        ThuongBi_ASung,
                        ThuongBi_TangSung,
                        ThuongBi_GiamLopHat,
                        ThuongBi_PhiaTrenNhuBi,
                        ThuongBi_ViApsxe,
                        ThuongBi_MunMu,
                        ThuongBi_QuaSan,
                        ThuongBi_GianMachMau,
                        TrungBi_ThamNhiem,
                        TrungBi_Lympho,
                        TrungBi_Khac,
                        SinhThietMong,
                        Interleukin_NgayLayMau,
                        Interleukin_IL17,
                        Interleukin_IL23,
                        XetNghiemKhac,
                        ThuocTieuSung,
                        ThuocGiuAm,
                        Corticorid,
                        Calcipotriol,
                        VitaminA,
                        Tarcrolimus,
                        ThuocBoi_Khac,
                        Methotrexate,
                        VitaminAAcid,
                        Cyclosporine,
                        Corticosteroid,
                        ChePhamSinhHoc1,
                        ChePhamSinhHoc2,
                        ChePhamSinhHoc3,
                        YHocCoTruyen,
                        ThuocKhac,
                        DieuTriAnhSang,
                        DieuTriAnhSang_Co,
                        PPDieuTri,
                        DieuTri_CuThe,
                        HenKhamLai,
                        BacSyKhamBenh,
                        MaBacSyKhambenh,
                        TK_HoTen,
                        TK_SoBADienTu,
                        TK_Ngay,
                        TK_SoLuuTru,
                        TK_Sot,
                        TK_Sot_Do,
                        TK_Hach,
                        TK_MetMoi,
                        TK_HA,
                        TK_Mach,
                        TK_TrieuChungCoNang,
                        TK_TienSu,
                        TK_DiemPasi1,
                        TK_DiemPasi2,
                        TK_DiemPasi3,
                        TK_DiemPasi4,
                        TK_DiemPasi,
                        TK_DiemPasi_Text,
                        TK_TongDiemNAPSI,
                        TK_SoKhopDau,
                        TK_SoKhopSung,
                        TK_DAS28,
                        TK_ViemKhop,
                        TK_BienDangKhop,
                        TK_BienDangKhop_Text,
                        TK_BieuHienNiemMac,
                        TK_BieuHienNiemMac_ViTri,
                        TK_BieuHienKhac_TimMach,
                        TK_BieuHienKhac_TietNieu,
                        TK_BieuHienKhac_HoHap,
                        TK_BieuHienKhac_TieuHoa,
                        TK_BieuHienKhac_TamThan,
                        TK_BieuHienKhac_CoQuanKhac,
                        TK_DiemDLQI_1,
                        TK_DiemDLQI_2,
                        TK_DiemDLQI_3,
                        TK_DiemDLQI_4,
                        TK_DiemDLQI_5,
                        TK_DiemDLQI_6,
                        TK_DiemDLQI_7,
                        TK_DiemDLQI_8,
                        TK_DiemDLQI_9,
                        TK_DiemDLQI_10,
                        TK_TongDiem,
                        TK_CTM_HC,
                        TK_CTM_Hb,
                        TK_CTM_HCT,
                        TK_CTM_TieuCau,
                        TK_CTM_BachCau,
                        TK_CTM_Lympho,
                        TK_CTM_TT,
                        TK_CTM_Mono,
                        TK_CTM_Khac,
                        TK_MauLang_1,
                        TK_MauLang_2,
                        TK_SinhHoa_Ure,
                        TK_SinhHoa_Cre,
                        TK_SinhHoa_Glu,
                        TK_SinhHoa_Uric,
                        TK_SinhHoa_TP,
                        TK_SinhHoa_TT,
                        TK_SinhHoa_GT,
                        TK_SinhHoa_Protein,
                        TK_SinhHoa_Alb,
                        TK_SinhHoa_Cholesterol,
                        TK_SinhHoa_Tri,
                        TK_SinhHoa_HDL,
                        TK_SinhHoa_LDL,
                        TK_SinhHoa_GOT,
                        TK_SinhHoa_GPT,
                        TK_SinhHoa_CK,
                        TK_SinhHoa_DGD_Na,
                        TK_SinhHoa_DGD_K,
                        TK_SinhHoa_DGD_Cl,
                        TK_SinhHoa_DGD_Ca,
                        TK_SinhHoa_DGD_CaIonHoa,
                        STK_inhHoa_DGD_HbA1c,
                        TK_ProteinNieu,
                        TK_TruNieu,
                        TK_HCNieu,
                        TK_BCNieu,
                        TK_XetNghiemKhac,
                        TK_TacDungPhu,
                        TK_TenThuoc,
                        TK_LietKeTacDungPhu,
                        TK_ThuocBoi,
                        TK_ThuocToanThan,
                        TK_HenKhamLai,
                        TK_BacSyDieuTri,
                        TK_MaBacSyDieuTri,
                        TK_QuaTrinhBenhLy,
                        TK_TomTatKetQua,
                        TK_BenhChinh,
                        TK_MaBenhChinh,
                        TK_BenhKemTheo,
                        TK_MaBenhKemTheo,
                        TK_PhuongPhapDieuTri,
                        TK_TinhTrangRaVien,
                        TK_HuongDieuTri,
                        NguoiNhanHoSo,
                        NguoiGiaoHoSo,
                        NgayTongKet,
                        BacSyDieuTri
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
                        :KhoiPhatBenh,
                        :TrieuChungDauTien,
                        :LanNhapVien,
                        :TSGD_MacVayNen,
                        :TSGD_MacVayNen_Text,
                        :TSCN_BenhKhac,
                        :TienSuCaNhan,
                        :TienSuCaNhan_Khac,
                        :ThoiQuenCaNhan,
                        :ThoiQuenCaNhan_Khac,
                        :YeuToTinhThan,
                        :ViTriKhoiPhat,
                        :ViTriKhoiPhat_Khac,
                        :ThoiQuenCaNhan2,
                        :ThoiQuenCaNhan2_Khac,
                        :YeuToTinhThan2,
                        :ViTriKhoiPhat2,
                        :ViTriKhoiPhat2_Khac,
                        :MuaNang,
                        :Sot,
                        :Sot_Do,
                        :Hach,
                        :MetMoi,
                        :HA,
                        :Mach,
                        :TrieuChungCoNang,
                        :Can,
                        :Cao,
                        :VongBung,
                        :PhanLoaiTheoKT,
                        :PhanLoaiTheoVT,
                        :PhanLoaiTheoMD,
                        :NgayDanhGiaPASI,
                        :DiemPasi1,
                        :DiemPasi2,
                        :DiemPasi3,
                        :DiemPasi4,
                        :DiemPasi,
                        :DiemPasi_Text,
                        :DanhGiaPASI,
                        :RoMong,
                        :RoMong_Text,
                        :MongDay_Mun,
                        :DuongVanNgang,
                        :LiemMong,
                        :TachMong,
                        :TachMong_Text,
                        :DaySung,
                        :DauHieuGiotDau,
                        :DauHieuGiotDau_Text,
                        :XuatHuyet,
                        :ViemQuanhMong,
                        :NAPSI_TayPhai,
                        :NAPSI_TayTrai,
                        :NAPSI_ChanPhai,
                        :NAPSI_ChanTrai,
                        :TongDiemNAPSI,
                        :SoKhopDau,
                        :SoKhopSung,
                        :DAS28,
                        :ViemKhop,
                        :BienDangKhop,
                        :BienDangKhop_Text,
                        :BieuHienNiemMac,
                        :BieuHienNiemMac_ViTri,
                        :BieuHienKhac_TimMach,
                        :BieuHienKhac_HoHap,
                        :BieuHienKhac_TieuHoa,
                        :BieuHienKhac_TamThan,
                        :DiemDLQI_1,
                        :DiemDLQI_2,
                        :DiemDLQI_3,
                        :DiemDLQI_4,
                        :DiemDLQI_5,
                        :DiemDLQI_6,
                        :DiemDLQI_7,
                        :DiemDLQI_8,
                        :DiemDLQI_9,
                        :DiemDLQI_10,
                        :TongDiem,
                        :CTM_HC,
                        :CTM_Hb,
                        :CTM_HCT,
                        :CTM_TieuCau,
                        :CTM_BachCau,
                        :CTM_Lympho,
                        :CTM_TT,
                        :CTM_Mono,
                        :MauLang_1,
                        :MauLang_2,
                        :SinhHoa_Ure,
                        :SinhHoa_Cre1,
                        :SinhHoa_Glu,
                        :SinhHoa_Cre2,
                        :SinhHoa_Uric,
                        :SinhHoa_TP,
                        :SinhHoa_TT,
                        :SinhHoa_GT,
                        :SinhHoa_ProteinTP,
                        :SinhHoa_Alb,
                        :SinhHoa_Cholesterol,
                        :SinhHoa_Tri,
                        :SinhHoa_HDL,
                        :SinhHoa_LDL,
                        :SinhHoa_GOT,
                        :SinhHoa_GPT,
                        :SinhHoa_CK,
                        :SinhHoa_DGD_Na,
                        :SinhHoa_DGD_K,
                        :SinhHoa_DGD_Cl,
                        :SinhHoa_DGD_Ca,
                        :SinhHoa_DGD_CaIonHoa,
                        :SinhHoa_DGD_HbA1c,
                        :ProteinNieu,
                        :TruNieu,
                        :HCNieu,
                        :BCNieu,
                        :NuocTieu24H,
                        :XQXuongKhop,
                        :SinhThiet_NgayLam,
                        :SinhThiet_ViTri,
                        :ThuongBi_ASung,
                        :ThuongBi_TangSung,
                        :ThuongBi_GiamLopHat,
                        :ThuongBi_PhiaTrenNhuBi,
                        :ThuongBi_ViApsxe,
                        :ThuongBi_MunMu,
                        :ThuongBi_QuaSan,
                        :ThuongBi_GianMachMau,
                        :TrungBi_ThamNhiem,
                        :TrungBi_Lympho,
                        :TrungBi_Khac,
                        :SinhThietMong,
                        :Interleukin_NgayLayMau,
                        :Interleukin_IL17,
                        :Interleukin_IL23,
                        :XetNghiemKhac,
                        :ThuocTieuSung,
                        :ThuocGiuAm,
                        :Corticorid,
                        :Calcipotriol,
                        :VitaminA,
                        :Tarcrolimus,
                        :ThuocBoi_Khac,
                        :Methotrexate,
                        :VitaminAAcid,
                        :Cyclosporine,
                        :Corticosteroid,
                        :ChePhamSinhHoc1,
                        :ChePhamSinhHoc2,
                        :ChePhamSinhHoc3,
                        :YHocCoTruyen,
                        :ThuocKhac,
                        :DieuTriAnhSang,
                        :DieuTriAnhSang_Co,
                        :PPDieuTri,
                        :DieuTri_CuThe,
                        :HenKhamLai,
                        :BacSyKhamBenh,
                        :MaBacSyKhambenh,
                        :TK_HoTen,
                        :TK_SoBADienTu,
                        :TK_Ngay,
                        :TK_SoLuuTru,
                        :TK_Sot,
                        :TK_Sot_Do,
                        :TK_Hach,
                        :TK_MetMoi,
                        :TK_HA,
                        :TK_Mach,
                        :TK_TrieuChungCoNang,
                        :TK_TienSu,
                        :TK_DiemPasi1,
                        :TK_DiemPasi2,
                        :TK_DiemPasi3,
                        :TK_DiemPasi4,
                        :TK_DiemPasi,
                        :TK_DiemPasi_Text,
                        :TK_TongDiemNAPSI,
                        :TK_SoKhopDau,
                        :TK_SoKhopSung,
                        :TK_DAS28,
                        :TK_ViemKhop,
                        :TK_BienDangKhop,
                        :TK_BienDangKhop_Text,
                        :TK_BieuHienNiemMac,
                        :TK_BieuHienNiemMac_ViTri,
                        :TK_BieuHienKhac_TimMach,
                        :TK_BieuHienKhac_TietNieu,
                        :TK_BieuHienKhac_HoHap,
                        :TK_BieuHienKhac_TieuHoa,
                        :TK_BieuHienKhac_TamThan,
                        :TK_BieuHienKhac_CoQuanKhac,
                        :TK_DiemDLQI_1,
                        :TK_DiemDLQI_2,
                        :TK_DiemDLQI_3,
                        :TK_DiemDLQI_4,
                        :TK_DiemDLQI_5,
                        :TK_DiemDLQI_6,
                        :TK_DiemDLQI_7,
                        :TK_DiemDLQI_8,
                        :TK_DiemDLQI_9,
                        :TK_DiemDLQI_10,
                        :TK_TongDiem,
                        :TK_CTM_HC,
                        :TK_CTM_Hb,
                        :TK_CTM_HCT,
                        :TK_CTM_TieuCau,
                        :TK_CTM_BachCau,
                        :TK_CTM_Lympho,
                        :TK_CTM_TT,
                        :TK_CTM_Mono,
                        :TK_CTM_Khac,
                        :TK_MauLang_1,
                        :TK_MauLang_2,
                        :TK_SinhHoa_Ure,
                        :TK_SinhHoa_Cre,
                        :TK_SinhHoa_Glu,
                        :TK_SinhHoa_Uric,
                        :TK_SinhHoa_TP,
                        :TK_SinhHoa_TT,
                        :TK_SinhHoa_GT,
                        :TK_SinhHoa_Protein,
                        :TK_SinhHoa_Alb,
                        :TK_SinhHoa_Cholesterol,
                        :TK_SinhHoa_Tri,
                        :TK_SinhHoa_HDL,
                        :TK_SinhHoa_LDL,
                        :TK_SinhHoa_GOT,
                        :TK_SinhHoa_GPT,
                        :TK_SinhHoa_CK,
                        :TK_SinhHoa_DGD_Na,
                        :TK_SinhHoa_DGD_K,
                        :TK_SinhHoa_DGD_Cl,
                        :TK_SinhHoa_DGD_Ca,
                        :TK_SinhHoa_DGD_CaIonHoa,
                        :STK_inhHoa_DGD_HbA1c,
                        :TK_ProteinNieu,
                        :TK_TruNieu,
                        :TK_HCNieu,
                        :TK_BCNieu,
                        :TK_XetNghiemKhac,
                        :TK_TacDungPhu,
                        :TK_TenThuoc,
                        :TK_LietKeTacDungPhu,
                        :TK_ThuocBoi,
                        :TK_ThuocToanThan,
                        :TK_HenKhamLai,
                        :TK_BacSyDieuTri,
                        :TK_MaBacSyDieuTri,
                        :TK_QuaTrinhBenhLy,
                        :TK_TomTatKetQua,
                        :TK_BenhChinh,
                        :TK_MaBenhChinh,
                        :TK_BenhKemTheo,
                        :TK_MaBenhKemTheo,
                        :TK_PhuongPhapDieuTri,
                        :TK_TinhTrangRaVien,
                        :TK_HuongDieuTri,
                        :NguoiNhanHoSo,
                        :NguoiGiaoHoSo,
                        :NgayTongKet,
                        :BacSyDieuTri
                    )
                   ";
            Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnNgoaiTru_BenhVayNenThongThuong.MaQuanLy));
            Command.Parameters.Add(new MDB.MDBParameter("DieuTriNgoaiTruTu", BenhAnNgoaiTru_BenhVayNenThongThuong.DieuTriNgoaiTruTu));
            Command.Parameters.Add(new MDB.MDBParameter("DieuTriNgoaiTruDen", BenhAnNgoaiTru_BenhVayNenThongThuong.DieuTriNgoaiTruDen));
            Command.Parameters.Add(new MDB.MDBParameter("SoCMND", BenhAnNgoaiTru_BenhVayNenThongThuong.SoCMND));
            Command.Parameters.Add(new MDB.MDBParameter("BaoHiem", BenhAnNgoaiTru_BenhVayNenThongThuong.BaoHiem));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoan_TuyenTruoc", BenhAnNgoaiTru_BenhVayNenThongThuong.ChanDoan_TuyenTruoc));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanBanDau", BenhAnNgoaiTru_BenhVayNenThongThuong.ChanDoanBanDau));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham1", BenhAnNgoaiTru_BenhVayNenThongThuong.ChanDoanTaiKham1));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham2", BenhAnNgoaiTru_BenhVayNenThongThuong.ChanDoanTaiKham2));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham3", BenhAnNgoaiTru_BenhVayNenThongThuong.ChanDoanTaiKham3));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham4", BenhAnNgoaiTru_BenhVayNenThongThuong.ChanDoanTaiKham4));
            Command.Parameters.Add(new MDB.MDBParameter("BenhPhu", BenhAnNgoaiTru_BenhVayNenThongThuong.BenhPhu));
            Command.Parameters.Add(new MDB.MDBParameter("KetQuaDieuTri", BenhAnNgoaiTru_BenhVayNenThongThuong.KetQuaDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("BienChung_Text", BenhAnNgoaiTru_BenhVayNenThongThuong.BienChung_Text));
            Command.Parameters.Add(new MDB.MDBParameter("GDPhongKeHoach", BenhAnNgoaiTru_BenhVayNenThongThuong.GDPhongKeHoach));
            Command.Parameters.Add(new MDB.MDBParameter("GDPhongKhamBenh", BenhAnNgoaiTru_BenhVayNenThongThuong.GDPhongKhamBenh));
            Command.Parameters.Add(new MDB.MDBParameter("KhoiPhatBenh", BenhAnNgoaiTru_BenhVayNenThongThuong.KhoiPhatBenh));
            Command.Parameters.Add(new MDB.MDBParameter("TrieuChungDauTien", BenhAnNgoaiTru_BenhVayNenThongThuong.TrieuChungDauTien));
            Command.Parameters.Add(new MDB.MDBParameter("LanNhapVien", BenhAnNgoaiTru_BenhVayNenThongThuong.LanNhapVien));
            Command.Parameters.Add(new MDB.MDBParameter("TSGD_MacVayNen", BenhAnNgoaiTru_BenhVayNenThongThuong.TSGD_MacVayNen));
            Command.Parameters.Add(new MDB.MDBParameter("TSGD_MacVayNen_Text", BenhAnNgoaiTru_BenhVayNenThongThuong.TSGD_MacVayNen_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TSCN_BenhKhac", BenhAnNgoaiTru_BenhVayNenThongThuong.TSCN_BenhKhac));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuCaNhan", BenhAnNgoaiTru_BenhVayNenThongThuong.TienSuCaNhan));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuCaNhan_Khac", BenhAnNgoaiTru_BenhVayNenThongThuong.TienSuCaNhan_Khac));
            Command.Parameters.Add(new MDB.MDBParameter("ThoiQuenCaNhan", BenhAnNgoaiTru_BenhVayNenThongThuong.ThoiQuenCaNhan));
            Command.Parameters.Add(new MDB.MDBParameter("ThoiQuenCaNhan_Khac", BenhAnNgoaiTru_BenhVayNenThongThuong.ThoiQuenCaNhan_Khac));
            Command.Parameters.Add(new MDB.MDBParameter("YeuToTinhThan", BenhAnNgoaiTru_BenhVayNenThongThuong.YeuToTinhThan));
            Command.Parameters.Add(new MDB.MDBParameter("ViTriKhoiPhat", BenhAnNgoaiTru_BenhVayNenThongThuong.ViTriKhoiPhat));
            Command.Parameters.Add(new MDB.MDBParameter("ViTriKhoiPhat_Khac", BenhAnNgoaiTru_BenhVayNenThongThuong.ViTriKhoiPhat_Khac));
            Command.Parameters.Add(new MDB.MDBParameter("ThoiQuenCaNhan2", BenhAnNgoaiTru_BenhVayNenThongThuong.ThoiQuenCaNhan2));
            Command.Parameters.Add(new MDB.MDBParameter("ThoiQuenCaNhan2_Khac", BenhAnNgoaiTru_BenhVayNenThongThuong.ThoiQuenCaNhan2_Khac));
            Command.Parameters.Add(new MDB.MDBParameter("YeuToTinhThan2", BenhAnNgoaiTru_BenhVayNenThongThuong.YeuToTinhThan2));
            Command.Parameters.Add(new MDB.MDBParameter("ViTriKhoiPhat2", BenhAnNgoaiTru_BenhVayNenThongThuong.ViTriKhoiPhat2));
            Command.Parameters.Add(new MDB.MDBParameter("ViTriKhoiPhat2_Khac", BenhAnNgoaiTru_BenhVayNenThongThuong.ViTriKhoiPhat2_Khac));
            Command.Parameters.Add(new MDB.MDBParameter("MuaNang", BenhAnNgoaiTru_BenhVayNenThongThuong.MuaNang));
            Command.Parameters.Add(new MDB.MDBParameter("Sot", BenhAnNgoaiTru_BenhVayNenThongThuong.Sot));
            Command.Parameters.Add(new MDB.MDBParameter("Sot_Do", BenhAnNgoaiTru_BenhVayNenThongThuong.Sot_Do));
            Command.Parameters.Add(new MDB.MDBParameter("Hach", BenhAnNgoaiTru_BenhVayNenThongThuong.Hach));
            Command.Parameters.Add(new MDB.MDBParameter("MetMoi", BenhAnNgoaiTru_BenhVayNenThongThuong.MetMoi));
            Command.Parameters.Add(new MDB.MDBParameter("HA", BenhAnNgoaiTru_BenhVayNenThongThuong.HA));
            Command.Parameters.Add(new MDB.MDBParameter("Mach", BenhAnNgoaiTru_BenhVayNenThongThuong.Mach));
            Command.Parameters.Add(new MDB.MDBParameter("TrieuChungCoNang", BenhAnNgoaiTru_BenhVayNenThongThuong.TrieuChungCoNang));
            Command.Parameters.Add(new MDB.MDBParameter("Can", BenhAnNgoaiTru_BenhVayNenThongThuong.Can));
            Command.Parameters.Add(new MDB.MDBParameter("Cao", BenhAnNgoaiTru_BenhVayNenThongThuong.Cao));
            Command.Parameters.Add(new MDB.MDBParameter("VongBung", BenhAnNgoaiTru_BenhVayNenThongThuong.VongBung));
            Command.Parameters.Add(new MDB.MDBParameter("PhanLoaiTheoKT", BenhAnNgoaiTru_BenhVayNenThongThuong.PhanLoaiTheoKT));
            Command.Parameters.Add(new MDB.MDBParameter("PhanLoaiTheoVT", BenhAnNgoaiTru_BenhVayNenThongThuong.PhanLoaiTheoVT));
            Command.Parameters.Add(new MDB.MDBParameter("PhanLoaiTheoMD", BenhAnNgoaiTru_BenhVayNenThongThuong.PhanLoaiTheoMD));
            Command.Parameters.Add(new MDB.MDBParameter("NgayDanhGiaPASI", BenhAnNgoaiTru_BenhVayNenThongThuong.NgayDanhGiaPASI));
            Command.Parameters.Add(new MDB.MDBParameter("DiemPasi1", BenhAnNgoaiTru_BenhVayNenThongThuong.DiemPasi1));
            Command.Parameters.Add(new MDB.MDBParameter("DiemPasi2", BenhAnNgoaiTru_BenhVayNenThongThuong.DiemPasi2));
            Command.Parameters.Add(new MDB.MDBParameter("DiemPasi3", BenhAnNgoaiTru_BenhVayNenThongThuong.DiemPasi3));
            Command.Parameters.Add(new MDB.MDBParameter("DiemPasi4", BenhAnNgoaiTru_BenhVayNenThongThuong.DiemPasi4));
            Command.Parameters.Add(new MDB.MDBParameter("DiemPasi", BenhAnNgoaiTru_BenhVayNenThongThuong.DiemPasi));
            Command.Parameters.Add(new MDB.MDBParameter("DiemPasi_Text", BenhAnNgoaiTru_BenhVayNenThongThuong.DiemPasi_Text));
            Command.Parameters.Add(new MDB.MDBParameter("DanhGiaPASI", BenhAnNgoaiTru_BenhVayNenThongThuong.DanhGiaPASI));
            Command.Parameters.Add(new MDB.MDBParameter("RoMong", BenhAnNgoaiTru_BenhVayNenThongThuong.RoMong));
            Command.Parameters.Add(new MDB.MDBParameter("RoMong_Text", BenhAnNgoaiTru_BenhVayNenThongThuong.RoMong_Text));
            Command.Parameters.Add(new MDB.MDBParameter("MongDay_Mun", BenhAnNgoaiTru_BenhVayNenThongThuong.MongDay_Mun));
            Command.Parameters.Add(new MDB.MDBParameter("DuongVanNgang", BenhAnNgoaiTru_BenhVayNenThongThuong.DuongVanNgang));
            Command.Parameters.Add(new MDB.MDBParameter("LiemMong", BenhAnNgoaiTru_BenhVayNenThongThuong.LiemMong));
            Command.Parameters.Add(new MDB.MDBParameter("TachMong", BenhAnNgoaiTru_BenhVayNenThongThuong.TachMong));
            Command.Parameters.Add(new MDB.MDBParameter("TachMong_Text", BenhAnNgoaiTru_BenhVayNenThongThuong.TachMong_Text));
            Command.Parameters.Add(new MDB.MDBParameter("DaySung", BenhAnNgoaiTru_BenhVayNenThongThuong.DaySung));
            Command.Parameters.Add(new MDB.MDBParameter("DauHieuGiotDau", BenhAnNgoaiTru_BenhVayNenThongThuong.DauHieuGiotDau));
            Command.Parameters.Add(new MDB.MDBParameter("DauHieuGiotDau_Text", BenhAnNgoaiTru_BenhVayNenThongThuong.DauHieuGiotDau_Text));
            Command.Parameters.Add(new MDB.MDBParameter("XuatHuyet", BenhAnNgoaiTru_BenhVayNenThongThuong.XuatHuyet));
            Command.Parameters.Add(new MDB.MDBParameter("ViemQuanhMong", BenhAnNgoaiTru_BenhVayNenThongThuong.ViemQuanhMong));
            Command.Parameters.Add(new MDB.MDBParameter("NAPSI_TayPhai", JsonConvert.SerializeObject(BenhAnNgoaiTru_BenhVayNenThongThuong.NAPSI_TayPhai)));
            Command.Parameters.Add(new MDB.MDBParameter("NAPSI_TayTrai", JsonConvert.SerializeObject(BenhAnNgoaiTru_BenhVayNenThongThuong.NAPSI_TayTrai)));
            Command.Parameters.Add(new MDB.MDBParameter("NAPSI_ChanPhai", JsonConvert.SerializeObject(BenhAnNgoaiTru_BenhVayNenThongThuong.NAPSI_ChanPhai)));
            Command.Parameters.Add(new MDB.MDBParameter("NAPSI_ChanTrai", JsonConvert.SerializeObject(BenhAnNgoaiTru_BenhVayNenThongThuong.NAPSI_ChanTrai)));
            Command.Parameters.Add(new MDB.MDBParameter("TongDiemNAPSI", BenhAnNgoaiTru_BenhVayNenThongThuong.TongDiemNAPSI));
            Command.Parameters.Add(new MDB.MDBParameter("SoKhopDau", BenhAnNgoaiTru_BenhVayNenThongThuong.SoKhopDau));
            Command.Parameters.Add(new MDB.MDBParameter("SoKhopSung", BenhAnNgoaiTru_BenhVayNenThongThuong.SoKhopSung));
            Command.Parameters.Add(new MDB.MDBParameter("DAS28", BenhAnNgoaiTru_BenhVayNenThongThuong.DAS28));
            Command.Parameters.Add(new MDB.MDBParameter("ViemKhop", BenhAnNgoaiTru_BenhVayNenThongThuong.ViemKhop));
            Command.Parameters.Add(new MDB.MDBParameter("BienDangKhop", BenhAnNgoaiTru_BenhVayNenThongThuong.BienDangKhop));
            Command.Parameters.Add(new MDB.MDBParameter("BienDangKhop_Text", BenhAnNgoaiTru_BenhVayNenThongThuong.BienDangKhop_Text));
            Command.Parameters.Add(new MDB.MDBParameter("BieuHienNiemMac", BenhAnNgoaiTru_BenhVayNenThongThuong.BieuHienNiemMac));
            Command.Parameters.Add(new MDB.MDBParameter("BieuHienNiemMac_ViTri", BenhAnNgoaiTru_BenhVayNenThongThuong.BieuHienNiemMac_ViTri));
            Command.Parameters.Add(new MDB.MDBParameter("BieuHienKhac_TimMach", BenhAnNgoaiTru_BenhVayNenThongThuong.BieuHienKhac_TimMach));
            Command.Parameters.Add(new MDB.MDBParameter("BieuHienKhac_HoHap", BenhAnNgoaiTru_BenhVayNenThongThuong.BieuHienKhac_HoHap));
            Command.Parameters.Add(new MDB.MDBParameter("BieuHienKhac_TieuHoa", BenhAnNgoaiTru_BenhVayNenThongThuong.BieuHienKhac_TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("BieuHienKhac_TamThan", BenhAnNgoaiTru_BenhVayNenThongThuong.BieuHienKhac_TamThan));
            Command.Parameters.Add(new MDB.MDBParameter("DiemDLQI_1", BenhAnNgoaiTru_BenhVayNenThongThuong.DiemDLQI_1));
            Command.Parameters.Add(new MDB.MDBParameter("DiemDLQI_2", BenhAnNgoaiTru_BenhVayNenThongThuong.DiemDLQI_2));
            Command.Parameters.Add(new MDB.MDBParameter("DiemDLQI_3", BenhAnNgoaiTru_BenhVayNenThongThuong.DiemDLQI_3));
            Command.Parameters.Add(new MDB.MDBParameter("DiemDLQI_4", BenhAnNgoaiTru_BenhVayNenThongThuong.DiemDLQI_4));
            Command.Parameters.Add(new MDB.MDBParameter("DiemDLQI_5", BenhAnNgoaiTru_BenhVayNenThongThuong.DiemDLQI_5));
            Command.Parameters.Add(new MDB.MDBParameter("DiemDLQI_6", BenhAnNgoaiTru_BenhVayNenThongThuong.DiemDLQI_6));
            Command.Parameters.Add(new MDB.MDBParameter("DiemDLQI_7", BenhAnNgoaiTru_BenhVayNenThongThuong.DiemDLQI_7));
            Command.Parameters.Add(new MDB.MDBParameter("DiemDLQI_8", BenhAnNgoaiTru_BenhVayNenThongThuong.DiemDLQI_8));
            Command.Parameters.Add(new MDB.MDBParameter("DiemDLQI_9", BenhAnNgoaiTru_BenhVayNenThongThuong.DiemDLQI_9));
            Command.Parameters.Add(new MDB.MDBParameter("DiemDLQI_10", BenhAnNgoaiTru_BenhVayNenThongThuong.DiemDLQI_10));
            Command.Parameters.Add(new MDB.MDBParameter("TongDiem", BenhAnNgoaiTru_BenhVayNenThongThuong.TongDiem));
            Command.Parameters.Add(new MDB.MDBParameter("CTM_HC", BenhAnNgoaiTru_BenhVayNenThongThuong.CTM_HC));
            Command.Parameters.Add(new MDB.MDBParameter("CTM_Hb", BenhAnNgoaiTru_BenhVayNenThongThuong.CTM_Hb));
            Command.Parameters.Add(new MDB.MDBParameter("CTM_HCT", BenhAnNgoaiTru_BenhVayNenThongThuong.CTM_HCT));
            Command.Parameters.Add(new MDB.MDBParameter("CTM_TieuCau", BenhAnNgoaiTru_BenhVayNenThongThuong.CTM_TieuCau));
            Command.Parameters.Add(new MDB.MDBParameter("CTM_BachCau", BenhAnNgoaiTru_BenhVayNenThongThuong.CTM_BachCau));
            Command.Parameters.Add(new MDB.MDBParameter("CTM_Lympho", BenhAnNgoaiTru_BenhVayNenThongThuong.CTM_Lympho));
            Command.Parameters.Add(new MDB.MDBParameter("CTM_TT", BenhAnNgoaiTru_BenhVayNenThongThuong.CTM_TT));
            Command.Parameters.Add(new MDB.MDBParameter("CTM_Mono", BenhAnNgoaiTru_BenhVayNenThongThuong.CTM_Mono));
            Command.Parameters.Add(new MDB.MDBParameter("MauLang_1", BenhAnNgoaiTru_BenhVayNenThongThuong.MauLang_1));
            Command.Parameters.Add(new MDB.MDBParameter("MauLang_2", BenhAnNgoaiTru_BenhVayNenThongThuong.MauLang_2));
            Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_Ure", BenhAnNgoaiTru_BenhVayNenThongThuong.SinhHoa_Ure));
            Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_Cre1", BenhAnNgoaiTru_BenhVayNenThongThuong.SinhHoa_Cre1));
            Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_Glu", BenhAnNgoaiTru_BenhVayNenThongThuong.SinhHoa_Glu));
            Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_Cre2", BenhAnNgoaiTru_BenhVayNenThongThuong.SinhHoa_Cre2));
            Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_Uric", BenhAnNgoaiTru_BenhVayNenThongThuong.SinhHoa_Uric));
            Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_TP", BenhAnNgoaiTru_BenhVayNenThongThuong.SinhHoa_TP));
            Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_TT", BenhAnNgoaiTru_BenhVayNenThongThuong.SinhHoa_TT));
            Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_GT", BenhAnNgoaiTru_BenhVayNenThongThuong.SinhHoa_GT));
            Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_ProteinTP", BenhAnNgoaiTru_BenhVayNenThongThuong.SinhHoa_ProteinTP));
            Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_Alb", BenhAnNgoaiTru_BenhVayNenThongThuong.SinhHoa_Alb));
            Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_Cholesterol", BenhAnNgoaiTru_BenhVayNenThongThuong.SinhHoa_Cholesterol));
            Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_Tri", BenhAnNgoaiTru_BenhVayNenThongThuong.SinhHoa_Tri));
            Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_HDL", BenhAnNgoaiTru_BenhVayNenThongThuong.SinhHoa_HDL));
            Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_LDL", BenhAnNgoaiTru_BenhVayNenThongThuong.SinhHoa_LDL));
            Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_GOT", BenhAnNgoaiTru_BenhVayNenThongThuong.SinhHoa_GOT));
            Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_GPT", BenhAnNgoaiTru_BenhVayNenThongThuong.SinhHoa_GPT));
            Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_CK", BenhAnNgoaiTru_BenhVayNenThongThuong.SinhHoa_CK));
            Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_DGD_Na", BenhAnNgoaiTru_BenhVayNenThongThuong.SinhHoa_DGD_Na));
            Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_DGD_K", BenhAnNgoaiTru_BenhVayNenThongThuong.SinhHoa_DGD_K));
            Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_DGD_Cl", BenhAnNgoaiTru_BenhVayNenThongThuong.SinhHoa_DGD_Cl));
            Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_DGD_Ca", BenhAnNgoaiTru_BenhVayNenThongThuong.SinhHoa_DGD_Ca));
            Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_DGD_CaIonHoa", BenhAnNgoaiTru_BenhVayNenThongThuong.SinhHoa_DGD_CaIonHoa));
            Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_DGD_HbA1c", BenhAnNgoaiTru_BenhVayNenThongThuong.SinhHoa_DGD_HbA1c));
            Command.Parameters.Add(new MDB.MDBParameter("ProteinNieu", BenhAnNgoaiTru_BenhVayNenThongThuong.ProteinNieu));
            Command.Parameters.Add(new MDB.MDBParameter("TruNieu", BenhAnNgoaiTru_BenhVayNenThongThuong.TruNieu));
            Command.Parameters.Add(new MDB.MDBParameter("HCNieu", BenhAnNgoaiTru_BenhVayNenThongThuong.HCNieu));
            Command.Parameters.Add(new MDB.MDBParameter("BCNieu", BenhAnNgoaiTru_BenhVayNenThongThuong.BCNieu));
            Command.Parameters.Add(new MDB.MDBParameter("NuocTieu24H", BenhAnNgoaiTru_BenhVayNenThongThuong.NuocTieu24H));
            Command.Parameters.Add(new MDB.MDBParameter("XQXuongKhop", BenhAnNgoaiTru_BenhVayNenThongThuong.XQXuongKhop));
            Command.Parameters.Add(new MDB.MDBParameter("SinhThiet_NgayLam", BenhAnNgoaiTru_BenhVayNenThongThuong.SinhThiet_NgayLam));
            Command.Parameters.Add(new MDB.MDBParameter("SinhThiet_ViTri", BenhAnNgoaiTru_BenhVayNenThongThuong.SinhThiet_ViTri));
            Command.Parameters.Add(new MDB.MDBParameter("ThuongBi_ASung", BenhAnNgoaiTru_BenhVayNenThongThuong.ThuongBi_ASung));
            Command.Parameters.Add(new MDB.MDBParameter("ThuongBi_TangSung", BenhAnNgoaiTru_BenhVayNenThongThuong.ThuongBi_TangSung));
            Command.Parameters.Add(new MDB.MDBParameter("ThuongBi_GiamLopHat", BenhAnNgoaiTru_BenhVayNenThongThuong.ThuongBi_GiamLopHat));
            Command.Parameters.Add(new MDB.MDBParameter("ThuongBi_PhiaTrenNhuBi", BenhAnNgoaiTru_BenhVayNenThongThuong.ThuongBi_PhiaTrenNhuBi));
            Command.Parameters.Add(new MDB.MDBParameter("ThuongBi_ViApsxe", BenhAnNgoaiTru_BenhVayNenThongThuong.ThuongBi_ViApsxe));
            Command.Parameters.Add(new MDB.MDBParameter("ThuongBi_MunMu", BenhAnNgoaiTru_BenhVayNenThongThuong.ThuongBi_MunMu));
            Command.Parameters.Add(new MDB.MDBParameter("ThuongBi_QuaSan", BenhAnNgoaiTru_BenhVayNenThongThuong.ThuongBi_QuaSan));
            Command.Parameters.Add(new MDB.MDBParameter("ThuongBi_GianMachMau", BenhAnNgoaiTru_BenhVayNenThongThuong.ThuongBi_GianMachMau));
            Command.Parameters.Add(new MDB.MDBParameter("TrungBi_ThamNhiem", BenhAnNgoaiTru_BenhVayNenThongThuong.TrungBi_ThamNhiem));
            Command.Parameters.Add(new MDB.MDBParameter("TrungBi_Lympho", BenhAnNgoaiTru_BenhVayNenThongThuong.TrungBi_Lympho));
            Command.Parameters.Add(new MDB.MDBParameter("TrungBi_Khac", BenhAnNgoaiTru_BenhVayNenThongThuong.TrungBi_Khac));
            Command.Parameters.Add(new MDB.MDBParameter("SinhThietMong", BenhAnNgoaiTru_BenhVayNenThongThuong.SinhThietMong));
            Command.Parameters.Add(new MDB.MDBParameter("Interleukin_NgayLayMau", BenhAnNgoaiTru_BenhVayNenThongThuong.Interleukin_NgayLayMau));
            Command.Parameters.Add(new MDB.MDBParameter("Interleukin_IL17", BenhAnNgoaiTru_BenhVayNenThongThuong.Interleukin_IL17));
            Command.Parameters.Add(new MDB.MDBParameter("Interleukin_IL23", BenhAnNgoaiTru_BenhVayNenThongThuong.Interleukin_IL23));
            Command.Parameters.Add(new MDB.MDBParameter("XetNghiemKhac", BenhAnNgoaiTru_BenhVayNenThongThuong.XetNghiemKhac));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocTieuSung", BenhAnNgoaiTru_BenhVayNenThongThuong.ThuocTieuSung));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocGiuAm", BenhAnNgoaiTru_BenhVayNenThongThuong.ThuocGiuAm));
            Command.Parameters.Add(new MDB.MDBParameter("Corticorid", BenhAnNgoaiTru_BenhVayNenThongThuong.Corticorid));
            Command.Parameters.Add(new MDB.MDBParameter("Calcipotriol", BenhAnNgoaiTru_BenhVayNenThongThuong.Calcipotriol));
            Command.Parameters.Add(new MDB.MDBParameter("VitaminA", BenhAnNgoaiTru_BenhVayNenThongThuong.VitaminA));
            Command.Parameters.Add(new MDB.MDBParameter("Tarcrolimus", BenhAnNgoaiTru_BenhVayNenThongThuong.Tarcrolimus));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocBoi_Khac", BenhAnNgoaiTru_BenhVayNenThongThuong.ThuocBoi_Khac));
            Command.Parameters.Add(new MDB.MDBParameter("Methotrexate", JsonConvert.SerializeObject(BenhAnNgoaiTru_BenhVayNenThongThuong.Methotrexate)));
            Command.Parameters.Add(new MDB.MDBParameter("VitaminAAcid", JsonConvert.SerializeObject(BenhAnNgoaiTru_BenhVayNenThongThuong.VitaminAAcid)));
            Command.Parameters.Add(new MDB.MDBParameter("Cyclosporine", JsonConvert.SerializeObject(BenhAnNgoaiTru_BenhVayNenThongThuong.Cyclosporine)));
            Command.Parameters.Add(new MDB.MDBParameter("Corticosteroid", JsonConvert.SerializeObject(BenhAnNgoaiTru_BenhVayNenThongThuong.Corticosteroid)));
            Command.Parameters.Add(new MDB.MDBParameter("ChePhamSinhHoc1", JsonConvert.SerializeObject(BenhAnNgoaiTru_BenhVayNenThongThuong.ChePhamSinhHoc1)));
            Command.Parameters.Add(new MDB.MDBParameter("ChePhamSinhHoc2", JsonConvert.SerializeObject(BenhAnNgoaiTru_BenhVayNenThongThuong.ChePhamSinhHoc2)));
            Command.Parameters.Add(new MDB.MDBParameter("ChePhamSinhHoc3", JsonConvert.SerializeObject(BenhAnNgoaiTru_BenhVayNenThongThuong.ChePhamSinhHoc3)));
            Command.Parameters.Add(new MDB.MDBParameter("YHocCoTruyen", JsonConvert.SerializeObject(BenhAnNgoaiTru_BenhVayNenThongThuong.YHocCoTruyen)));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocKhac", JsonConvert.SerializeObject(BenhAnNgoaiTru_BenhVayNenThongThuong.ThuocKhac)));
            Command.Parameters.Add(new MDB.MDBParameter("DieuTriAnhSang", BenhAnNgoaiTru_BenhVayNenThongThuong.DieuTriAnhSang));
            Command.Parameters.Add(new MDB.MDBParameter("DieuTriAnhSang_Co", BenhAnNgoaiTru_BenhVayNenThongThuong.DieuTriAnhSang_Co));
            Command.Parameters.Add(new MDB.MDBParameter("PPDieuTri", BenhAnNgoaiTru_BenhVayNenThongThuong.PPDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("DieuTri_CuThe", BenhAnNgoaiTru_BenhVayNenThongThuong.DieuTri_CuThe));
            Command.Parameters.Add(new MDB.MDBParameter("HenKhamLai", BenhAnNgoaiTru_BenhVayNenThongThuong.HenKhamLai));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyKhamBenh", BenhAnNgoaiTru_BenhVayNenThongThuong.BacSyKhamBenh));
            Command.Parameters.Add(new MDB.MDBParameter("MaBacSyKhambenh", BenhAnNgoaiTru_BenhVayNenThongThuong.MaBacSyKhambenh));
            Command.Parameters.Add(new MDB.MDBParameter("TK_HoTen", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_HoTen));
            Command.Parameters.Add(new MDB.MDBParameter("TK_SoBADienTu", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_SoBADienTu));
            Command.Parameters.Add(new MDB.MDBParameter("TK_Ngay", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_Ngay));
            Command.Parameters.Add(new MDB.MDBParameter("TK_SoLuuTru", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_SoLuuTru));
            Command.Parameters.Add(new MDB.MDBParameter("TK_Sot", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_Sot));
            Command.Parameters.Add(new MDB.MDBParameter("TK_Sot_Do", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_Sot_Do));
            Command.Parameters.Add(new MDB.MDBParameter("TK_Hach", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_Hach));
            Command.Parameters.Add(new MDB.MDBParameter("TK_MetMoi", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_MetMoi));
            Command.Parameters.Add(new MDB.MDBParameter("TK_HA", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_HA));
            Command.Parameters.Add(new MDB.MDBParameter("TK_Mach", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_Mach));
            Command.Parameters.Add(new MDB.MDBParameter("TK_TrieuChungCoNang", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_TrieuChungCoNang));
            Command.Parameters.Add(new MDB.MDBParameter("TK_TienSu", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_TienSu));
            Command.Parameters.Add(new MDB.MDBParameter("TK_DiemPasi1", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_DiemPasi1));
            Command.Parameters.Add(new MDB.MDBParameter("TK_DiemPasi2", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_DiemPasi2));
            Command.Parameters.Add(new MDB.MDBParameter("TK_DiemPasi3", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_DiemPasi3));
            Command.Parameters.Add(new MDB.MDBParameter("TK_DiemPasi4", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_DiemPasi4));
            Command.Parameters.Add(new MDB.MDBParameter("TK_DiemPasi", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_DiemPasi));
            Command.Parameters.Add(new MDB.MDBParameter("TK_DiemPasi_Text", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_DiemPasi_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TK_TongDiemNAPSI", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_TongDiemNAPSI));
            Command.Parameters.Add(new MDB.MDBParameter("TK_SoKhopDau", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_SoKhopDau));
            Command.Parameters.Add(new MDB.MDBParameter("TK_SoKhopSung", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_SoKhopSung));
            Command.Parameters.Add(new MDB.MDBParameter("TK_DAS28", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_DAS28));
            Command.Parameters.Add(new MDB.MDBParameter("TK_ViemKhop", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_ViemKhop));
            Command.Parameters.Add(new MDB.MDBParameter("TK_BienDangKhop", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_BienDangKhop));
            Command.Parameters.Add(new MDB.MDBParameter("TK_BienDangKhop_Text", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_BienDangKhop_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TK_BieuHienNiemMac", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_BieuHienNiemMac));
            Command.Parameters.Add(new MDB.MDBParameter("TK_BieuHienNiemMac_ViTri", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_BieuHienNiemMac_ViTri));
            Command.Parameters.Add(new MDB.MDBParameter("TK_BieuHienKhac_TimMach", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_BieuHienKhac_TimMach));
            Command.Parameters.Add(new MDB.MDBParameter("TK_BieuHienKhac_TietNieu", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_BieuHienKhac_TietNieu));
            Command.Parameters.Add(new MDB.MDBParameter("TK_BieuHienKhac_HoHap", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_BieuHienKhac_HoHap));
            Command.Parameters.Add(new MDB.MDBParameter("TK_BieuHienKhac_TieuHoa", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_BieuHienKhac_TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("TK_BieuHienKhac_TamThan", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_BieuHienKhac_TamThan));
            Command.Parameters.Add(new MDB.MDBParameter("TK_BieuHienKhac_CoQuanKhac", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_BieuHienKhac_CoQuanKhac));
            Command.Parameters.Add(new MDB.MDBParameter("TK_DiemDLQI_1", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_DiemDLQI_1));
            Command.Parameters.Add(new MDB.MDBParameter("TK_DiemDLQI_2", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_DiemDLQI_2));
            Command.Parameters.Add(new MDB.MDBParameter("TK_DiemDLQI_3", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_DiemDLQI_3));
            Command.Parameters.Add(new MDB.MDBParameter("TK_DiemDLQI_4", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_DiemDLQI_4));
            Command.Parameters.Add(new MDB.MDBParameter("TK_DiemDLQI_5", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_DiemDLQI_5));
            Command.Parameters.Add(new MDB.MDBParameter("TK_DiemDLQI_6", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_DiemDLQI_6));
            Command.Parameters.Add(new MDB.MDBParameter("TK_DiemDLQI_7", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_DiemDLQI_7));
            Command.Parameters.Add(new MDB.MDBParameter("TK_DiemDLQI_8", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_DiemDLQI_8));
            Command.Parameters.Add(new MDB.MDBParameter("TK_DiemDLQI_9", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_DiemDLQI_9));
            Command.Parameters.Add(new MDB.MDBParameter("TK_DiemDLQI_10", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_DiemDLQI_10));
            Command.Parameters.Add(new MDB.MDBParameter("TK_TongDiem", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_TongDiem));
            Command.Parameters.Add(new MDB.MDBParameter("TK_CTM_HC", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_CTM_HC));
            Command.Parameters.Add(new MDB.MDBParameter("TK_CTM_Hb", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_CTM_Hb));
            Command.Parameters.Add(new MDB.MDBParameter("TK_CTM_HCT", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_CTM_HCT));
            Command.Parameters.Add(new MDB.MDBParameter("TK_CTM_TieuCau", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_CTM_TieuCau));
            Command.Parameters.Add(new MDB.MDBParameter("TK_CTM_BachCau", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_CTM_BachCau));
            Command.Parameters.Add(new MDB.MDBParameter("TK_CTM_Lympho", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_CTM_Lympho));
            Command.Parameters.Add(new MDB.MDBParameter("TK_CTM_TT", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_CTM_TT));
            Command.Parameters.Add(new MDB.MDBParameter("TK_CTM_Mono", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_CTM_Mono));
            Command.Parameters.Add(new MDB.MDBParameter("TK_CTM_Khac", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_CTM_Khac));
            Command.Parameters.Add(new MDB.MDBParameter("TK_MauLang_1", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_MauLang_1));
            Command.Parameters.Add(new MDB.MDBParameter("TK_MauLang_2", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_MauLang_2));
            Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_Ure", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_SinhHoa_Ure));
            Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_Cre", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_SinhHoa_Cre));
            Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_Glu", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_SinhHoa_Glu));
            Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_Uric", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_SinhHoa_Uric));
            Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_TP", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_SinhHoa_TP));
            Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_TT", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_SinhHoa_TT));
            Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_GT", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_SinhHoa_GT));
            Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_Protein", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_SinhHoa_Protein));
            Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_Alb", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_SinhHoa_Alb));
            Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_Cholesterol", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_SinhHoa_Cholesterol));
            Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_Tri", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_SinhHoa_Tri));
            Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_HDL", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_SinhHoa_HDL));
            Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_LDL", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_SinhHoa_LDL));
            Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_GOT", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_SinhHoa_GOT));
            Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_GPT", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_SinhHoa_GPT));
            Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_CK", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_SinhHoa_CK));
            Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_DGD_Na", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_SinhHoa_DGD_Na));
            Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_DGD_K", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_SinhHoa_DGD_K));
            Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_DGD_Cl", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_SinhHoa_DGD_Cl));
            Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_DGD_Ca", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_SinhHoa_DGD_Ca));
            Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_DGD_CaIonHoa", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_SinhHoa_DGD_CaIonHoa));
            Command.Parameters.Add(new MDB.MDBParameter("STK_inhHoa_DGD_HbA1c", BenhAnNgoaiTru_BenhVayNenThongThuong.STK_inhHoa_DGD_HbA1c));
            Command.Parameters.Add(new MDB.MDBParameter("TK_ProteinNieu", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_ProteinNieu));
            Command.Parameters.Add(new MDB.MDBParameter("TK_TruNieu", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_TruNieu));
            Command.Parameters.Add(new MDB.MDBParameter("TK_HCNieu", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_HCNieu));
            Command.Parameters.Add(new MDB.MDBParameter("TK_BCNieu", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_BCNieu));
            Command.Parameters.Add(new MDB.MDBParameter("TK_XetNghiemKhac", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_XetNghiemKhac));
            Command.Parameters.Add(new MDB.MDBParameter("TK_TacDungPhu", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_TacDungPhu));
            Command.Parameters.Add(new MDB.MDBParameter("TK_TenThuoc", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_TenThuoc));
            Command.Parameters.Add(new MDB.MDBParameter("TK_LietKeTacDungPhu", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_LietKeTacDungPhu));
            Command.Parameters.Add(new MDB.MDBParameter("TK_ThuocBoi", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_ThuocBoi));
            Command.Parameters.Add(new MDB.MDBParameter("TK_ThuocToanThan", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_ThuocToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TK_HenKhamLai", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_HenKhamLai));
            Command.Parameters.Add(new MDB.MDBParameter("TK_BacSyDieuTri", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_BacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("TK_MaBacSyDieuTri", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_MaBacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("TK_QuaTrinhBenhLy", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_QuaTrinhBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("TK_TomTatKetQua", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_TomTatKetQua));
            Command.Parameters.Add(new MDB.MDBParameter("TK_BenhChinh", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("TK_MaBenhChinh", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_MaBenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("TK_BenhKemTheo", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_BenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("TK_MaBenhKemTheo", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_MaBenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("TK_PhuongPhapDieuTri", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_PhuongPhapDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("TK_TinhTrangRaVien", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_TinhTrangRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("TK_HuongDieuTri", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_HuongDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnNgoaiTru_BenhVayNenThongThuong.NguoiNhanHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnNgoaiTru_BenhVayNenThongThuong.NguoiGiaoHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnNgoaiTru_BenhVayNenThongThuong.NgayTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnNgoaiTru_BenhVayNenThongThuong.BacSyDieuTri));

            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool Update(MDB.MDBConnection MyConnection, BenhAnNgoaiTru_BenhVayNenThongThuong BenhAnNgoaiTru_BenhVayNenThongThuong)
        {
            string sql = @"UPDATE BenhAnVayNenThongThuong SET 
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
                        KhoiPhatBenh=:KhoiPhatBenh,
                        TrieuChungDauTien=:TrieuChungDauTien,
                        LanNhapVien=:LanNhapVien,
                        TSGD_MacVayNen=:TSGD_MacVayNen,
                        TSGD_MacVayNen_Text=:TSGD_MacVayNen_Text,
                        TSCN_BenhKhac=:TSCN_BenhKhac,
                        TienSuCaNhan=:TienSuCaNhan,
                        TienSuCaNhan_Khac=:TienSuCaNhan_Khac,
                        ThoiQuenCaNhan=:ThoiQuenCaNhan,
                        ThoiQuenCaNhan_Khac=:ThoiQuenCaNhan_Khac,
                        YeuToTinhThan=:YeuToTinhThan,
                        ViTriKhoiPhat=:ViTriKhoiPhat,
                        ViTriKhoiPhat_Khac=:ViTriKhoiPhat_Khac,
                        ThoiQuenCaNhan2=:ThoiQuenCaNhan2,
                        ThoiQuenCaNhan2_Khac=:ThoiQuenCaNhan2_Khac,
                        YeuToTinhThan2=:YeuToTinhThan2,
                        ViTriKhoiPhat2=:ViTriKhoiPhat2,
                        ViTriKhoiPhat2_Khac=:ViTriKhoiPhat2_Khac,
                        MuaNang=:MuaNang,
                        Sot=:Sot,
                        Sot_Do=:Sot_Do,
                        Hach=:Hach,
                        MetMoi=:MetMoi,
                        HA=:HA,
                        Mach=:Mach,
                        TrieuChungCoNang=:TrieuChungCoNang,
                        Can=:Can,
                        Cao=:Cao,
                        VongBung=:VongBung,
                        PhanLoaiTheoKT=:PhanLoaiTheoKT,
                        PhanLoaiTheoVT=:PhanLoaiTheoVT,
                        PhanLoaiTheoMD=:PhanLoaiTheoMD,
                        NgayDanhGiaPASI=:NgayDanhGiaPASI,
                        DiemPasi1=:DiemPasi1,
                        DiemPasi2=:DiemPasi2,
                        DiemPasi3=:DiemPasi3,
                        DiemPasi4=:DiemPasi4,
                        DiemPasi=:DiemPasi,
                        DiemPasi_Text=:DiemPasi_Text,
                        DanhGiaPASI=:DanhGiaPASI,
                        RoMong=:RoMong,
                        RoMong_Text=:RoMong_Text,
                        MongDay_Mun=:MongDay_Mun,
                        DuongVanNgang=:DuongVanNgang,
                        LiemMong=:LiemMong,
                        TachMong=:TachMong,
                        TachMong_Text=:TachMong_Text,
                        DaySung=:DaySung,
                        DauHieuGiotDau=:DauHieuGiotDau,
                        DauHieuGiotDau_Text=:DauHieuGiotDau_Text,
                        XuatHuyet=:XuatHuyet,
                        ViemQuanhMong=:ViemQuanhMong,
                        NAPSI_TayPhai=:NAPSI_TayPhai,
                        NAPSI_TayTrai=:NAPSI_TayTrai,
                        NAPSI_ChanPhai=:NAPSI_ChanPhai,
                        NAPSI_ChanTrai=:NAPSI_ChanTrai,
                        TongDiemNAPSI=:TongDiemNAPSI,
                        SoKhopDau=:SoKhopDau,
                        SoKhopSung=:SoKhopSung,
                        DAS28=:DAS28,
                        ViemKhop=:ViemKhop,
                        BienDangKhop=:BienDangKhop,
                        BienDangKhop_Text=:BienDangKhop_Text,
                        BieuHienNiemMac=:BieuHienNiemMac,
                        BieuHienNiemMac_ViTri=:BieuHienNiemMac_ViTri,
                        BieuHienKhac_TimMach=:BieuHienKhac_TimMach,
                        BieuHienKhac_HoHap=:BieuHienKhac_HoHap,
                        BieuHienKhac_TieuHoa=:BieuHienKhac_TieuHoa,
                        BieuHienKhac_TamThan=:BieuHienKhac_TamThan,
                        DiemDLQI_1=:DiemDLQI_1,
                        DiemDLQI_2=:DiemDLQI_2,
                        DiemDLQI_3=:DiemDLQI_3,
                        DiemDLQI_4=:DiemDLQI_4,
                        DiemDLQI_5=:DiemDLQI_5,
                        DiemDLQI_6=:DiemDLQI_6,
                        DiemDLQI_7=:DiemDLQI_7,
                        DiemDLQI_8=:DiemDLQI_8,
                        DiemDLQI_9=:DiemDLQI_9,
                        DiemDLQI_10=:DiemDLQI_10,
                        TongDiem=:TongDiem,
                        CTM_HC=:CTM_HC,
                        CTM_Hb=:CTM_Hb,
                        CTM_HCT=:CTM_HCT,
                        CTM_TieuCau=:CTM_TieuCau,
                        CTM_BachCau=:CTM_BachCau,
                        CTM_Lympho=:CTM_Lympho,
                        CTM_TT=:CTM_TT,
                        CTM_Mono=:CTM_Mono,
                        MauLang_1=:MauLang_1,
                        MauLang_2=:MauLang_2,
                        SinhHoa_Ure=:SinhHoa_Ure,
                        SinhHoa_Cre1=:SinhHoa_Cre1,
                        SinhHoa_Glu=:SinhHoa_Glu,
                        SinhHoa_Cre2=:SinhHoa_Cre2,
                        SinhHoa_Uric=:SinhHoa_Uric,
                        SinhHoa_TP=:SinhHoa_TP,
                        SinhHoa_TT=:SinhHoa_TT,
                        SinhHoa_GT=:SinhHoa_GT,
                        SinhHoa_ProteinTP=:SinhHoa_ProteinTP,
                        SinhHoa_Alb=:SinhHoa_Alb,
                        SinhHoa_Cholesterol=:SinhHoa_Cholesterol,
                        SinhHoa_Tri=:SinhHoa_Tri,
                        SinhHoa_HDL=:SinhHoa_HDL,
                        SinhHoa_LDL=:SinhHoa_LDL,
                        SinhHoa_GOT=:SinhHoa_GOT,
                        SinhHoa_GPT=:SinhHoa_GPT,
                        SinhHoa_CK=:SinhHoa_CK,
                        SinhHoa_DGD_Na=:SinhHoa_DGD_Na,
                        SinhHoa_DGD_K=:SinhHoa_DGD_K,
                        SinhHoa_DGD_Cl=:SinhHoa_DGD_Cl,
                        SinhHoa_DGD_Ca=:SinhHoa_DGD_Ca,
                        SinhHoa_DGD_CaIonHoa=:SinhHoa_DGD_CaIonHoa,
                        SinhHoa_DGD_HbA1c=:SinhHoa_DGD_HbA1c,
                        ProteinNieu=:ProteinNieu,
                        TruNieu=:TruNieu,
                        HCNieu=:HCNieu,
                        BCNieu=:BCNieu,
                        NuocTieu24H=:NuocTieu24H,
                        XQXuongKhop=:XQXuongKhop,
                        SinhThiet_NgayLam=:SinhThiet_NgayLam,
                        SinhThiet_ViTri=:SinhThiet_ViTri,
                        ThuongBi_ASung=:ThuongBi_ASung,
                        ThuongBi_TangSung=:ThuongBi_TangSung,
                        ThuongBi_GiamLopHat=:ThuongBi_GiamLopHat,
                        ThuongBi_PhiaTrenNhuBi=:ThuongBi_PhiaTrenNhuBi,
                        ThuongBi_ViApsxe=:ThuongBi_ViApsxe,
                        ThuongBi_MunMu=:ThuongBi_MunMu,
                        ThuongBi_QuaSan=:ThuongBi_QuaSan,
                        ThuongBi_GianMachMau=:ThuongBi_GianMachMau,
                        TrungBi_ThamNhiem=:TrungBi_ThamNhiem,
                        TrungBi_Lympho=:TrungBi_Lympho,
                        TrungBi_Khac=:TrungBi_Khac,
                        SinhThietMong=:SinhThietMong,
                        Interleukin_NgayLayMau=:Interleukin_NgayLayMau,
                        Interleukin_IL17=:Interleukin_IL17,
                        Interleukin_IL23=:Interleukin_IL23,
                        XetNghiemKhac=:XetNghiemKhac,
                        ThuocTieuSung=:ThuocTieuSung,
                        ThuocGiuAm=:ThuocGiuAm,
                        Corticorid=:Corticorid,
                        Calcipotriol=:Calcipotriol,
                        VitaminA=:VitaminA,
                        Tarcrolimus=:Tarcrolimus,
                        ThuocBoi_Khac=:ThuocBoi_Khac,
                        Methotrexate=:Methotrexate,
                        VitaminAAcid=:VitaminAAcid,
                        Cyclosporine=:Cyclosporine,
                        Corticosteroid=:Corticosteroid,
                        ChePhamSinhHoc1=:ChePhamSinhHoc1,
                        ChePhamSinhHoc2=:ChePhamSinhHoc2,
                        ChePhamSinhHoc3=:ChePhamSinhHoc3,
                        YHocCoTruyen=:YHocCoTruyen,
                        ThuocKhac=:ThuocKhac,
                        DieuTriAnhSang=:DieuTriAnhSang,
                        DieuTriAnhSang_Co=:DieuTriAnhSang_Co,
                        PPDieuTri=:PPDieuTri,
                        DieuTri_CuThe=:DieuTri_CuThe,
                        HenKhamLai=:HenKhamLai,
                        BacSyKhamBenh=:BacSyKhamBenh,
                        MaBacSyKhambenh=:MaBacSyKhambenh,
                        TK_HoTen=:TK_HoTen,
                        TK_SoBADienTu=:TK_SoBADienTu,
                        TK_Ngay=:TK_Ngay,
                        TK_SoLuuTru=:TK_SoLuuTru,
                        TK_Sot=:TK_Sot,
                        TK_Sot_Do=:TK_Sot_Do,
                        TK_Hach=:TK_Hach,
                        TK_MetMoi=:TK_MetMoi,
                        TK_HA=:TK_HA,
                        TK_Mach=:TK_Mach,
                        TK_TrieuChungCoNang=:TK_TrieuChungCoNang,
                        TK_TienSu=:TK_TienSu,
                        TK_DiemPasi1=:TK_DiemPasi1,
                        TK_DiemPasi2=:TK_DiemPasi2,
                        TK_DiemPasi3=:TK_DiemPasi3,
                        TK_DiemPasi4=:TK_DiemPasi4,
                        TK_DiemPasi=:TK_DiemPasi,
                        TK_DiemPasi_Text=:TK_DiemPasi_Text,
                        TK_TongDiemNAPSI=:TK_TongDiemNAPSI,
                        TK_SoKhopDau=:TK_SoKhopDau,
                        TK_SoKhopSung=:TK_SoKhopSung,
                        TK_DAS28=:TK_DAS28,
                        TK_ViemKhop=:TK_ViemKhop,
                        TK_BienDangKhop=:TK_BienDangKhop,
                        TK_BienDangKhop_Text=:TK_BienDangKhop_Text,
                        TK_BieuHienNiemMac=:TK_BieuHienNiemMac,
                        TK_BieuHienNiemMac_ViTri=:TK_BieuHienNiemMac_ViTri,
                        TK_BieuHienKhac_TimMach=:TK_BieuHienKhac_TimMach,
                        TK_BieuHienKhac_TietNieu=:TK_BieuHienKhac_TietNieu,
                        TK_BieuHienKhac_HoHap=:TK_BieuHienKhac_HoHap,
                        TK_BieuHienKhac_TieuHoa=:TK_BieuHienKhac_TieuHoa,
                        TK_BieuHienKhac_TamThan=:TK_BieuHienKhac_TamThan,
                        TK_BieuHienKhac_CoQuanKhac=:TK_BieuHienKhac_CoQuanKhac,
                        TK_DiemDLQI_1=:TK_DiemDLQI_1,
                        TK_DiemDLQI_2=:TK_DiemDLQI_2,
                        TK_DiemDLQI_3=:TK_DiemDLQI_3,
                        TK_DiemDLQI_4=:TK_DiemDLQI_4,
                        TK_DiemDLQI_5=:TK_DiemDLQI_5,
                        TK_DiemDLQI_6=:TK_DiemDLQI_6,
                        TK_DiemDLQI_7=:TK_DiemDLQI_7,
                        TK_DiemDLQI_8=:TK_DiemDLQI_8,
                        TK_DiemDLQI_9=:TK_DiemDLQI_9,
                        TK_DiemDLQI_10=:TK_DiemDLQI_10,
                        TK_TongDiem=:TK_TongDiem,
                        TK_CTM_HC=:TK_CTM_HC,
                        TK_CTM_Hb=:TK_CTM_Hb,
                        TK_CTM_HCT=:TK_CTM_HCT,
                        TK_CTM_TieuCau=:TK_CTM_TieuCau,
                        TK_CTM_BachCau=:TK_CTM_BachCau,
                        TK_CTM_Lympho=:TK_CTM_Lympho,
                        TK_CTM_TT=:TK_CTM_TT,
                        TK_CTM_Mono=:TK_CTM_Mono,
                        TK_CTM_Khac = :TK_CTM_Khac,
                        TK_MauLang_1=:TK_MauLang_1,
                        TK_MauLang_2=:TK_MauLang_2,
                        TK_SinhHoa_Ure=:TK_SinhHoa_Ure,
                        TK_SinhHoa_Cre=:TK_SinhHoa_Cre,
                        TK_SinhHoa_Glu=:TK_SinhHoa_Glu,
                        TK_SinhHoa_Uric=:TK_SinhHoa_Uric,
                        TK_SinhHoa_TP=:TK_SinhHoa_TP,
                        TK_SinhHoa_TT=:TK_SinhHoa_TT,
                        TK_SinhHoa_GT=:TK_SinhHoa_GT,
                        TK_SinhHoa_Protein=:TK_SinhHoa_Protein,
                        TK_SinhHoa_Alb=:TK_SinhHoa_Alb,
                        TK_SinhHoa_Cholesterol=:TK_SinhHoa_Cholesterol,
                        TK_SinhHoa_Tri=:TK_SinhHoa_Tri,
                        TK_SinhHoa_HDL=:TK_SinhHoa_HDL,
                        TK_SinhHoa_LDL=:TK_SinhHoa_LDL,
                        TK_SinhHoa_GOT=:TK_SinhHoa_GOT,
                        TK_SinhHoa_GPT=:TK_SinhHoa_GPT,
                        TK_SinhHoa_CK=:TK_SinhHoa_CK,
                        TK_SinhHoa_DGD_Na=:TK_SinhHoa_DGD_Na,
                        TK_SinhHoa_DGD_K=:TK_SinhHoa_DGD_K,
                        TK_SinhHoa_DGD_Cl=:TK_SinhHoa_DGD_Cl,
                        TK_SinhHoa_DGD_Ca=:TK_SinhHoa_DGD_Ca,
                        TK_SinhHoa_DGD_CaIonHoa=:TK_SinhHoa_DGD_CaIonHoa,
                        STK_inhHoa_DGD_HbA1c=:STK_inhHoa_DGD_HbA1c,
                        TK_ProteinNieu=:TK_ProteinNieu,
                        TK_TruNieu=:TK_TruNieu,
                        TK_HCNieu=:TK_HCNieu,
                        TK_BCNieu=:TK_BCNieu,
                        TK_XetNghiemKhac=:TK_XetNghiemKhac,
                        TK_TacDungPhu=:TK_TacDungPhu,
                        TK_TenThuoc=:TK_TenThuoc,
                        TK_LietKeTacDungPhu=:TK_LietKeTacDungPhu,
                        TK_ThuocBoi=:TK_ThuocBoi,
                        TK_ThuocToanThan=:TK_ThuocToanThan,
                        TK_HenKhamLai=:TK_HenKhamLai,
                        TK_BacSyDieuTri=:TK_BacSyDieuTri,
                        TK_MaBacSyDieuTri=:TK_MaBacSyDieuTri,
                        TK_QuaTrinhBenhLy=:TK_QuaTrinhBenhLy,
                        TK_TomTatKetQua=:TK_TomTatKetQua,
                        TK_BenhChinh=:TK_BenhChinh,
                        TK_MaBenhChinh=:TK_MaBenhChinh,
                        TK_BenhKemTheo=:TK_BenhKemTheo,
                        TK_MaBenhKemTheo=:TK_MaBenhKemTheo,
                        TK_PhuongPhapDieuTri=:TK_PhuongPhapDieuTri,
                        TK_TinhTrangRaVien=:TK_TinhTrangRaVien,
                        TK_HuongDieuTri=:TK_HuongDieuTri,
                        NguoiNhanHoSo=:NguoiNhanHoSo,
                        NguoiGiaoHoSo=:NguoiGiaoHoSo,
                        NgayTongKet=:NgayTongKet,
                        BacSyDieuTri=:BacSyDieuTri
                        WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("DieuTriNgoaiTruTu", BenhAnNgoaiTru_BenhVayNenThongThuong.DieuTriNgoaiTruTu));
            Command.Parameters.Add(new MDB.MDBParameter("DieuTriNgoaiTruDen", BenhAnNgoaiTru_BenhVayNenThongThuong.DieuTriNgoaiTruDen));
            Command.Parameters.Add(new MDB.MDBParameter("SoCMND", BenhAnNgoaiTru_BenhVayNenThongThuong.SoCMND));
            Command.Parameters.Add(new MDB.MDBParameter("BaoHiem", BenhAnNgoaiTru_BenhVayNenThongThuong.BaoHiem));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoan_TuyenTruoc", BenhAnNgoaiTru_BenhVayNenThongThuong.ChanDoan_TuyenTruoc));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanBanDau", BenhAnNgoaiTru_BenhVayNenThongThuong.ChanDoanBanDau));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham1", BenhAnNgoaiTru_BenhVayNenThongThuong.ChanDoanTaiKham1));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham2", BenhAnNgoaiTru_BenhVayNenThongThuong.ChanDoanTaiKham2));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham3", BenhAnNgoaiTru_BenhVayNenThongThuong.ChanDoanTaiKham3));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham4", BenhAnNgoaiTru_BenhVayNenThongThuong.ChanDoanTaiKham4));
            Command.Parameters.Add(new MDB.MDBParameter("BenhPhu", BenhAnNgoaiTru_BenhVayNenThongThuong.BenhPhu));
            Command.Parameters.Add(new MDB.MDBParameter("KetQuaDieuTri", BenhAnNgoaiTru_BenhVayNenThongThuong.KetQuaDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("BienChung_Text", BenhAnNgoaiTru_BenhVayNenThongThuong.BienChung_Text));
            Command.Parameters.Add(new MDB.MDBParameter("GDPhongKeHoach", BenhAnNgoaiTru_BenhVayNenThongThuong.GDPhongKeHoach));
            Command.Parameters.Add(new MDB.MDBParameter("GDPhongKhamBenh", BenhAnNgoaiTru_BenhVayNenThongThuong.GDPhongKhamBenh));
            Command.Parameters.Add(new MDB.MDBParameter("KhoiPhatBenh", BenhAnNgoaiTru_BenhVayNenThongThuong.KhoiPhatBenh));
            Command.Parameters.Add(new MDB.MDBParameter("TrieuChungDauTien", BenhAnNgoaiTru_BenhVayNenThongThuong.TrieuChungDauTien));
            Command.Parameters.Add(new MDB.MDBParameter("LanNhapVien", BenhAnNgoaiTru_BenhVayNenThongThuong.LanNhapVien));
            Command.Parameters.Add(new MDB.MDBParameter("TSGD_MacVayNen", BenhAnNgoaiTru_BenhVayNenThongThuong.TSGD_MacVayNen));
            Command.Parameters.Add(new MDB.MDBParameter("TSGD_MacVayNen_Text", BenhAnNgoaiTru_BenhVayNenThongThuong.TSGD_MacVayNen_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TSCN_BenhKhac", BenhAnNgoaiTru_BenhVayNenThongThuong.TSCN_BenhKhac));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuCaNhan", BenhAnNgoaiTru_BenhVayNenThongThuong.TienSuCaNhan));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuCaNhan_Khac", BenhAnNgoaiTru_BenhVayNenThongThuong.TienSuCaNhan_Khac));
            Command.Parameters.Add(new MDB.MDBParameter("ThoiQuenCaNhan", BenhAnNgoaiTru_BenhVayNenThongThuong.ThoiQuenCaNhan));
            Command.Parameters.Add(new MDB.MDBParameter("ThoiQuenCaNhan_Khac", BenhAnNgoaiTru_BenhVayNenThongThuong.ThoiQuenCaNhan_Khac));
            Command.Parameters.Add(new MDB.MDBParameter("YeuToTinhThan", BenhAnNgoaiTru_BenhVayNenThongThuong.YeuToTinhThan));
            Command.Parameters.Add(new MDB.MDBParameter("ViTriKhoiPhat", BenhAnNgoaiTru_BenhVayNenThongThuong.ViTriKhoiPhat));
            Command.Parameters.Add(new MDB.MDBParameter("ViTriKhoiPhat_Khac", BenhAnNgoaiTru_BenhVayNenThongThuong.ViTriKhoiPhat_Khac));
            Command.Parameters.Add(new MDB.MDBParameter("ThoiQuenCaNhan2", BenhAnNgoaiTru_BenhVayNenThongThuong.ThoiQuenCaNhan2));
            Command.Parameters.Add(new MDB.MDBParameter("ThoiQuenCaNhan2_Khac", BenhAnNgoaiTru_BenhVayNenThongThuong.ThoiQuenCaNhan2_Khac));
            Command.Parameters.Add(new MDB.MDBParameter("YeuToTinhThan2", BenhAnNgoaiTru_BenhVayNenThongThuong.YeuToTinhThan2));
            Command.Parameters.Add(new MDB.MDBParameter("ViTriKhoiPhat2", BenhAnNgoaiTru_BenhVayNenThongThuong.ViTriKhoiPhat2));
            Command.Parameters.Add(new MDB.MDBParameter("ViTriKhoiPhat2_Khac", BenhAnNgoaiTru_BenhVayNenThongThuong.ViTriKhoiPhat2_Khac));
            Command.Parameters.Add(new MDB.MDBParameter("MuaNang", BenhAnNgoaiTru_BenhVayNenThongThuong.MuaNang));
            Command.Parameters.Add(new MDB.MDBParameter("Sot", BenhAnNgoaiTru_BenhVayNenThongThuong.Sot));
            Command.Parameters.Add(new MDB.MDBParameter("Sot_Do", BenhAnNgoaiTru_BenhVayNenThongThuong.Sot_Do));
            Command.Parameters.Add(new MDB.MDBParameter("Hach", BenhAnNgoaiTru_BenhVayNenThongThuong.Hach));
            Command.Parameters.Add(new MDB.MDBParameter("MetMoi", BenhAnNgoaiTru_BenhVayNenThongThuong.MetMoi));
            Command.Parameters.Add(new MDB.MDBParameter("HA", BenhAnNgoaiTru_BenhVayNenThongThuong.HA));
            Command.Parameters.Add(new MDB.MDBParameter("Mach", BenhAnNgoaiTru_BenhVayNenThongThuong.Mach));
            Command.Parameters.Add(new MDB.MDBParameter("TrieuChungCoNang", BenhAnNgoaiTru_BenhVayNenThongThuong.TrieuChungCoNang));
            Command.Parameters.Add(new MDB.MDBParameter("Can", BenhAnNgoaiTru_BenhVayNenThongThuong.Can));
            Command.Parameters.Add(new MDB.MDBParameter("Cao", BenhAnNgoaiTru_BenhVayNenThongThuong.Cao));
            Command.Parameters.Add(new MDB.MDBParameter("VongBung", BenhAnNgoaiTru_BenhVayNenThongThuong.VongBung));
            Command.Parameters.Add(new MDB.MDBParameter("PhanLoaiTheoKT", BenhAnNgoaiTru_BenhVayNenThongThuong.PhanLoaiTheoKT));
            Command.Parameters.Add(new MDB.MDBParameter("PhanLoaiTheoVT", BenhAnNgoaiTru_BenhVayNenThongThuong.PhanLoaiTheoVT));
            Command.Parameters.Add(new MDB.MDBParameter("PhanLoaiTheoMD", BenhAnNgoaiTru_BenhVayNenThongThuong.PhanLoaiTheoMD));
            Command.Parameters.Add(new MDB.MDBParameter("NgayDanhGiaPASI", BenhAnNgoaiTru_BenhVayNenThongThuong.NgayDanhGiaPASI));
            Command.Parameters.Add(new MDB.MDBParameter("DiemPasi1", BenhAnNgoaiTru_BenhVayNenThongThuong.DiemPasi1));
            Command.Parameters.Add(new MDB.MDBParameter("DiemPasi2", BenhAnNgoaiTru_BenhVayNenThongThuong.DiemPasi2));
            Command.Parameters.Add(new MDB.MDBParameter("DiemPasi3", BenhAnNgoaiTru_BenhVayNenThongThuong.DiemPasi3));
            Command.Parameters.Add(new MDB.MDBParameter("DiemPasi4", BenhAnNgoaiTru_BenhVayNenThongThuong.DiemPasi4));
            Command.Parameters.Add(new MDB.MDBParameter("DiemPasi", BenhAnNgoaiTru_BenhVayNenThongThuong.DiemPasi));
            Command.Parameters.Add(new MDB.MDBParameter("DiemPasi_Text", BenhAnNgoaiTru_BenhVayNenThongThuong.DiemPasi_Text));
            Command.Parameters.Add(new MDB.MDBParameter("DanhGiaPASI", BenhAnNgoaiTru_BenhVayNenThongThuong.DanhGiaPASI));
            Command.Parameters.Add(new MDB.MDBParameter("RoMong", BenhAnNgoaiTru_BenhVayNenThongThuong.RoMong));
            Command.Parameters.Add(new MDB.MDBParameter("RoMong_Text", BenhAnNgoaiTru_BenhVayNenThongThuong.RoMong_Text));
            Command.Parameters.Add(new MDB.MDBParameter("MongDay_Mun", BenhAnNgoaiTru_BenhVayNenThongThuong.MongDay_Mun));
            Command.Parameters.Add(new MDB.MDBParameter("DuongVanNgang", BenhAnNgoaiTru_BenhVayNenThongThuong.DuongVanNgang));
            Command.Parameters.Add(new MDB.MDBParameter("LiemMong", BenhAnNgoaiTru_BenhVayNenThongThuong.LiemMong));
            Command.Parameters.Add(new MDB.MDBParameter("TachMong", BenhAnNgoaiTru_BenhVayNenThongThuong.TachMong));
            Command.Parameters.Add(new MDB.MDBParameter("TachMong_Text", BenhAnNgoaiTru_BenhVayNenThongThuong.TachMong_Text));
            Command.Parameters.Add(new MDB.MDBParameter("DaySung", BenhAnNgoaiTru_BenhVayNenThongThuong.DaySung));
            Command.Parameters.Add(new MDB.MDBParameter("DauHieuGiotDau", BenhAnNgoaiTru_BenhVayNenThongThuong.DauHieuGiotDau));
            Command.Parameters.Add(new MDB.MDBParameter("DauHieuGiotDau_Text", BenhAnNgoaiTru_BenhVayNenThongThuong.DauHieuGiotDau_Text));
            Command.Parameters.Add(new MDB.MDBParameter("XuatHuyet", BenhAnNgoaiTru_BenhVayNenThongThuong.XuatHuyet));
            Command.Parameters.Add(new MDB.MDBParameter("ViemQuanhMong", BenhAnNgoaiTru_BenhVayNenThongThuong.ViemQuanhMong));
            Command.Parameters.Add(new MDB.MDBParameter("NAPSI_TayPhai", JsonConvert.SerializeObject(BenhAnNgoaiTru_BenhVayNenThongThuong.NAPSI_TayPhai)));
            Command.Parameters.Add(new MDB.MDBParameter("NAPSI_TayTrai", JsonConvert.SerializeObject(BenhAnNgoaiTru_BenhVayNenThongThuong.NAPSI_TayTrai)));
            Command.Parameters.Add(new MDB.MDBParameter("NAPSI_ChanPhai", JsonConvert.SerializeObject(BenhAnNgoaiTru_BenhVayNenThongThuong.NAPSI_ChanPhai)));
            Command.Parameters.Add(new MDB.MDBParameter("NAPSI_ChanTrai", JsonConvert.SerializeObject(BenhAnNgoaiTru_BenhVayNenThongThuong.NAPSI_ChanTrai)));
            Command.Parameters.Add(new MDB.MDBParameter("TongDiemNAPSI", BenhAnNgoaiTru_BenhVayNenThongThuong.TongDiemNAPSI));
            Command.Parameters.Add(new MDB.MDBParameter("SoKhopDau", BenhAnNgoaiTru_BenhVayNenThongThuong.SoKhopDau));
            Command.Parameters.Add(new MDB.MDBParameter("SoKhopSung", BenhAnNgoaiTru_BenhVayNenThongThuong.SoKhopSung));
            Command.Parameters.Add(new MDB.MDBParameter("DAS28", BenhAnNgoaiTru_BenhVayNenThongThuong.DAS28));
            Command.Parameters.Add(new MDB.MDBParameter("ViemKhop", BenhAnNgoaiTru_BenhVayNenThongThuong.ViemKhop));
            Command.Parameters.Add(new MDB.MDBParameter("BienDangKhop", BenhAnNgoaiTru_BenhVayNenThongThuong.BienDangKhop));
            Command.Parameters.Add(new MDB.MDBParameter("BienDangKhop_Text", BenhAnNgoaiTru_BenhVayNenThongThuong.BienDangKhop_Text));
            Command.Parameters.Add(new MDB.MDBParameter("BieuHienNiemMac", BenhAnNgoaiTru_BenhVayNenThongThuong.BieuHienNiemMac));
            Command.Parameters.Add(new MDB.MDBParameter("BieuHienNiemMac_ViTri", BenhAnNgoaiTru_BenhVayNenThongThuong.BieuHienNiemMac_ViTri));
            Command.Parameters.Add(new MDB.MDBParameter("BieuHienKhac_TimMach", BenhAnNgoaiTru_BenhVayNenThongThuong.BieuHienKhac_TimMach));
            Command.Parameters.Add(new MDB.MDBParameter("BieuHienKhac_HoHap", BenhAnNgoaiTru_BenhVayNenThongThuong.BieuHienKhac_HoHap));
            Command.Parameters.Add(new MDB.MDBParameter("BieuHienKhac_TieuHoa", BenhAnNgoaiTru_BenhVayNenThongThuong.BieuHienKhac_TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("BieuHienKhac_TamThan", BenhAnNgoaiTru_BenhVayNenThongThuong.BieuHienKhac_TamThan));
            Command.Parameters.Add(new MDB.MDBParameter("DiemDLQI_1", BenhAnNgoaiTru_BenhVayNenThongThuong.DiemDLQI_1));
            Command.Parameters.Add(new MDB.MDBParameter("DiemDLQI_2", BenhAnNgoaiTru_BenhVayNenThongThuong.DiemDLQI_2));
            Command.Parameters.Add(new MDB.MDBParameter("DiemDLQI_3", BenhAnNgoaiTru_BenhVayNenThongThuong.DiemDLQI_3));
            Command.Parameters.Add(new MDB.MDBParameter("DiemDLQI_4", BenhAnNgoaiTru_BenhVayNenThongThuong.DiemDLQI_4));
            Command.Parameters.Add(new MDB.MDBParameter("DiemDLQI_5", BenhAnNgoaiTru_BenhVayNenThongThuong.DiemDLQI_5));
            Command.Parameters.Add(new MDB.MDBParameter("DiemDLQI_6", BenhAnNgoaiTru_BenhVayNenThongThuong.DiemDLQI_6));
            Command.Parameters.Add(new MDB.MDBParameter("DiemDLQI_7", BenhAnNgoaiTru_BenhVayNenThongThuong.DiemDLQI_7));
            Command.Parameters.Add(new MDB.MDBParameter("DiemDLQI_8", BenhAnNgoaiTru_BenhVayNenThongThuong.DiemDLQI_8));
            Command.Parameters.Add(new MDB.MDBParameter("DiemDLQI_9", BenhAnNgoaiTru_BenhVayNenThongThuong.DiemDLQI_9));
            Command.Parameters.Add(new MDB.MDBParameter("DiemDLQI_10", BenhAnNgoaiTru_BenhVayNenThongThuong.DiemDLQI_10));
            Command.Parameters.Add(new MDB.MDBParameter("TongDiem", BenhAnNgoaiTru_BenhVayNenThongThuong.TongDiem));
            Command.Parameters.Add(new MDB.MDBParameter("CTM_HC", BenhAnNgoaiTru_BenhVayNenThongThuong.CTM_HC));
            Command.Parameters.Add(new MDB.MDBParameter("CTM_Hb", BenhAnNgoaiTru_BenhVayNenThongThuong.CTM_Hb));
            Command.Parameters.Add(new MDB.MDBParameter("CTM_HCT", BenhAnNgoaiTru_BenhVayNenThongThuong.CTM_HCT));
            Command.Parameters.Add(new MDB.MDBParameter("CTM_TieuCau", BenhAnNgoaiTru_BenhVayNenThongThuong.CTM_TieuCau));
            Command.Parameters.Add(new MDB.MDBParameter("CTM_BachCau", BenhAnNgoaiTru_BenhVayNenThongThuong.CTM_BachCau));
            Command.Parameters.Add(new MDB.MDBParameter("CTM_Lympho", BenhAnNgoaiTru_BenhVayNenThongThuong.CTM_Lympho));
            Command.Parameters.Add(new MDB.MDBParameter("CTM_TT", BenhAnNgoaiTru_BenhVayNenThongThuong.CTM_TT));
            Command.Parameters.Add(new MDB.MDBParameter("CTM_Mono", BenhAnNgoaiTru_BenhVayNenThongThuong.CTM_Mono));
            Command.Parameters.Add(new MDB.MDBParameter("MauLang_1", BenhAnNgoaiTru_BenhVayNenThongThuong.MauLang_1));
            Command.Parameters.Add(new MDB.MDBParameter("MauLang_2", BenhAnNgoaiTru_BenhVayNenThongThuong.MauLang_2));
            Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_Ure", BenhAnNgoaiTru_BenhVayNenThongThuong.SinhHoa_Ure));
            Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_Cre1", BenhAnNgoaiTru_BenhVayNenThongThuong.SinhHoa_Cre1));
            Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_Glu", BenhAnNgoaiTru_BenhVayNenThongThuong.SinhHoa_Glu));
            Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_Cre2", BenhAnNgoaiTru_BenhVayNenThongThuong.SinhHoa_Cre2));
            Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_Uric", BenhAnNgoaiTru_BenhVayNenThongThuong.SinhHoa_Uric));
            Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_TP", BenhAnNgoaiTru_BenhVayNenThongThuong.SinhHoa_TP));
            Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_TT", BenhAnNgoaiTru_BenhVayNenThongThuong.SinhHoa_TT));
            Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_GT", BenhAnNgoaiTru_BenhVayNenThongThuong.SinhHoa_GT));
            Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_ProteinTP", BenhAnNgoaiTru_BenhVayNenThongThuong.SinhHoa_ProteinTP));
            Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_Alb", BenhAnNgoaiTru_BenhVayNenThongThuong.SinhHoa_Alb));
            Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_Cholesterol", BenhAnNgoaiTru_BenhVayNenThongThuong.SinhHoa_Cholesterol));
            Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_Tri", BenhAnNgoaiTru_BenhVayNenThongThuong.SinhHoa_Tri));
            Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_HDL", BenhAnNgoaiTru_BenhVayNenThongThuong.SinhHoa_HDL));
            Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_LDL", BenhAnNgoaiTru_BenhVayNenThongThuong.SinhHoa_LDL));
            Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_GOT", BenhAnNgoaiTru_BenhVayNenThongThuong.SinhHoa_GOT));
            Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_GPT", BenhAnNgoaiTru_BenhVayNenThongThuong.SinhHoa_GPT));
            Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_CK", BenhAnNgoaiTru_BenhVayNenThongThuong.SinhHoa_CK));
            Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_DGD_Na", BenhAnNgoaiTru_BenhVayNenThongThuong.SinhHoa_DGD_Na));
            Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_DGD_K", BenhAnNgoaiTru_BenhVayNenThongThuong.SinhHoa_DGD_K));
            Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_DGD_Cl", BenhAnNgoaiTru_BenhVayNenThongThuong.SinhHoa_DGD_Cl));
            Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_DGD_Ca", BenhAnNgoaiTru_BenhVayNenThongThuong.SinhHoa_DGD_Ca));
            Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_DGD_CaIonHoa", BenhAnNgoaiTru_BenhVayNenThongThuong.SinhHoa_DGD_CaIonHoa));
            Command.Parameters.Add(new MDB.MDBParameter("SinhHoa_DGD_HbA1c", BenhAnNgoaiTru_BenhVayNenThongThuong.SinhHoa_DGD_HbA1c));
            Command.Parameters.Add(new MDB.MDBParameter("ProteinNieu", BenhAnNgoaiTru_BenhVayNenThongThuong.ProteinNieu));
            Command.Parameters.Add(new MDB.MDBParameter("TruNieu", BenhAnNgoaiTru_BenhVayNenThongThuong.TruNieu));
            Command.Parameters.Add(new MDB.MDBParameter("HCNieu", BenhAnNgoaiTru_BenhVayNenThongThuong.HCNieu));
            Command.Parameters.Add(new MDB.MDBParameter("BCNieu", BenhAnNgoaiTru_BenhVayNenThongThuong.BCNieu));
            Command.Parameters.Add(new MDB.MDBParameter("NuocTieu24H", BenhAnNgoaiTru_BenhVayNenThongThuong.NuocTieu24H));
            Command.Parameters.Add(new MDB.MDBParameter("XQXuongKhop", BenhAnNgoaiTru_BenhVayNenThongThuong.XQXuongKhop));
            Command.Parameters.Add(new MDB.MDBParameter("SinhThiet_NgayLam", BenhAnNgoaiTru_BenhVayNenThongThuong.SinhThiet_NgayLam));
            Command.Parameters.Add(new MDB.MDBParameter("SinhThiet_ViTri", BenhAnNgoaiTru_BenhVayNenThongThuong.SinhThiet_ViTri));
            Command.Parameters.Add(new MDB.MDBParameter("ThuongBi_ASung", BenhAnNgoaiTru_BenhVayNenThongThuong.ThuongBi_ASung));
            Command.Parameters.Add(new MDB.MDBParameter("ThuongBi_TangSung", BenhAnNgoaiTru_BenhVayNenThongThuong.ThuongBi_TangSung));
            Command.Parameters.Add(new MDB.MDBParameter("ThuongBi_GiamLopHat", BenhAnNgoaiTru_BenhVayNenThongThuong.ThuongBi_GiamLopHat));
            Command.Parameters.Add(new MDB.MDBParameter("ThuongBi_PhiaTrenNhuBi", BenhAnNgoaiTru_BenhVayNenThongThuong.ThuongBi_PhiaTrenNhuBi));
            Command.Parameters.Add(new MDB.MDBParameter("ThuongBi_ViApsxe", BenhAnNgoaiTru_BenhVayNenThongThuong.ThuongBi_ViApsxe));
            Command.Parameters.Add(new MDB.MDBParameter("ThuongBi_MunMu", BenhAnNgoaiTru_BenhVayNenThongThuong.ThuongBi_MunMu));
            Command.Parameters.Add(new MDB.MDBParameter("ThuongBi_QuaSan", BenhAnNgoaiTru_BenhVayNenThongThuong.ThuongBi_QuaSan));
            Command.Parameters.Add(new MDB.MDBParameter("ThuongBi_GianMachMau", BenhAnNgoaiTru_BenhVayNenThongThuong.ThuongBi_GianMachMau));
            Command.Parameters.Add(new MDB.MDBParameter("TrungBi_ThamNhiem", BenhAnNgoaiTru_BenhVayNenThongThuong.TrungBi_ThamNhiem));
            Command.Parameters.Add(new MDB.MDBParameter("TrungBi_Lympho", BenhAnNgoaiTru_BenhVayNenThongThuong.TrungBi_Lympho));
            Command.Parameters.Add(new MDB.MDBParameter("TrungBi_Khac", BenhAnNgoaiTru_BenhVayNenThongThuong.TrungBi_Khac));
            Command.Parameters.Add(new MDB.MDBParameter("SinhThietMong", BenhAnNgoaiTru_BenhVayNenThongThuong.SinhThietMong));
            Command.Parameters.Add(new MDB.MDBParameter("Interleukin_NgayLayMau", BenhAnNgoaiTru_BenhVayNenThongThuong.Interleukin_NgayLayMau));
            Command.Parameters.Add(new MDB.MDBParameter("Interleukin_IL17", BenhAnNgoaiTru_BenhVayNenThongThuong.Interleukin_IL17));
            Command.Parameters.Add(new MDB.MDBParameter("Interleukin_IL23", BenhAnNgoaiTru_BenhVayNenThongThuong.Interleukin_IL23));
            Command.Parameters.Add(new MDB.MDBParameter("XetNghiemKhac", BenhAnNgoaiTru_BenhVayNenThongThuong.XetNghiemKhac));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocTieuSung", BenhAnNgoaiTru_BenhVayNenThongThuong.ThuocTieuSung));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocGiuAm", BenhAnNgoaiTru_BenhVayNenThongThuong.ThuocGiuAm));
            Command.Parameters.Add(new MDB.MDBParameter("Corticorid", BenhAnNgoaiTru_BenhVayNenThongThuong.Corticorid));
            Command.Parameters.Add(new MDB.MDBParameter("Calcipotriol", BenhAnNgoaiTru_BenhVayNenThongThuong.Calcipotriol));
            Command.Parameters.Add(new MDB.MDBParameter("VitaminA", BenhAnNgoaiTru_BenhVayNenThongThuong.VitaminA));
            Command.Parameters.Add(new MDB.MDBParameter("Tarcrolimus", BenhAnNgoaiTru_BenhVayNenThongThuong.Tarcrolimus));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocBoi_Khac", BenhAnNgoaiTru_BenhVayNenThongThuong.ThuocBoi_Khac));
            Command.Parameters.Add(new MDB.MDBParameter("Methotrexate", JsonConvert.SerializeObject(BenhAnNgoaiTru_BenhVayNenThongThuong.Methotrexate)));
            Command.Parameters.Add(new MDB.MDBParameter("VitaminAAcid", JsonConvert.SerializeObject(BenhAnNgoaiTru_BenhVayNenThongThuong.VitaminAAcid)));
            Command.Parameters.Add(new MDB.MDBParameter("Cyclosporine", JsonConvert.SerializeObject(BenhAnNgoaiTru_BenhVayNenThongThuong.Cyclosporine)));
            Command.Parameters.Add(new MDB.MDBParameter("Corticosteroid", JsonConvert.SerializeObject(BenhAnNgoaiTru_BenhVayNenThongThuong.Corticosteroid)));
            Command.Parameters.Add(new MDB.MDBParameter("ChePhamSinhHoc1", JsonConvert.SerializeObject(BenhAnNgoaiTru_BenhVayNenThongThuong.ChePhamSinhHoc1)));
            Command.Parameters.Add(new MDB.MDBParameter("ChePhamSinhHoc2", JsonConvert.SerializeObject(BenhAnNgoaiTru_BenhVayNenThongThuong.ChePhamSinhHoc2)));
            Command.Parameters.Add(new MDB.MDBParameter("ChePhamSinhHoc3", JsonConvert.SerializeObject(BenhAnNgoaiTru_BenhVayNenThongThuong.ChePhamSinhHoc3)));
            Command.Parameters.Add(new MDB.MDBParameter("YHocCoTruyen", JsonConvert.SerializeObject(BenhAnNgoaiTru_BenhVayNenThongThuong.YHocCoTruyen)));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocKhac", JsonConvert.SerializeObject(BenhAnNgoaiTru_BenhVayNenThongThuong.ThuocKhac)));
            Command.Parameters.Add(new MDB.MDBParameter("DieuTriAnhSang", BenhAnNgoaiTru_BenhVayNenThongThuong.DieuTriAnhSang));
            Command.Parameters.Add(new MDB.MDBParameter("DieuTriAnhSang_Co", BenhAnNgoaiTru_BenhVayNenThongThuong.DieuTriAnhSang_Co));
            Command.Parameters.Add(new MDB.MDBParameter("PPDieuTri", BenhAnNgoaiTru_BenhVayNenThongThuong.PPDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("DieuTri_CuThe", BenhAnNgoaiTru_BenhVayNenThongThuong.DieuTri_CuThe));
            Command.Parameters.Add(new MDB.MDBParameter("HenKhamLai", BenhAnNgoaiTru_BenhVayNenThongThuong.HenKhamLai));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyKhamBenh", BenhAnNgoaiTru_BenhVayNenThongThuong.BacSyKhamBenh));
            Command.Parameters.Add(new MDB.MDBParameter("MaBacSyKhambenh", BenhAnNgoaiTru_BenhVayNenThongThuong.MaBacSyKhambenh));
            Command.Parameters.Add(new MDB.MDBParameter("TK_HoTen", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_HoTen));
            Command.Parameters.Add(new MDB.MDBParameter("TK_SoBADienTu", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_SoBADienTu));
            Command.Parameters.Add(new MDB.MDBParameter("TK_Ngay", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_Ngay));
            Command.Parameters.Add(new MDB.MDBParameter("TK_SoLuuTru", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_SoLuuTru));
            Command.Parameters.Add(new MDB.MDBParameter("TK_Sot", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_Sot));
            Command.Parameters.Add(new MDB.MDBParameter("TK_Sot_Do", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_Sot_Do));
            Command.Parameters.Add(new MDB.MDBParameter("TK_Hach", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_Hach));
            Command.Parameters.Add(new MDB.MDBParameter("TK_MetMoi", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_MetMoi));
            Command.Parameters.Add(new MDB.MDBParameter("TK_HA", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_HA));
            Command.Parameters.Add(new MDB.MDBParameter("TK_Mach", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_Mach));
            Command.Parameters.Add(new MDB.MDBParameter("TK_TrieuChungCoNang", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_TrieuChungCoNang));
            Command.Parameters.Add(new MDB.MDBParameter("TK_TienSu", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_TienSu));
            Command.Parameters.Add(new MDB.MDBParameter("TK_DiemPasi1", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_DiemPasi1));
            Command.Parameters.Add(new MDB.MDBParameter("TK_DiemPasi2", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_DiemPasi2));
            Command.Parameters.Add(new MDB.MDBParameter("TK_DiemPasi3", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_DiemPasi3));
            Command.Parameters.Add(new MDB.MDBParameter("TK_DiemPasi4", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_DiemPasi4));
            Command.Parameters.Add(new MDB.MDBParameter("TK_DiemPasi", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_DiemPasi));
            Command.Parameters.Add(new MDB.MDBParameter("TK_DiemPasi_Text", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_DiemPasi_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TK_TongDiemNAPSI", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_TongDiemNAPSI));
            Command.Parameters.Add(new MDB.MDBParameter("TK_SoKhopDau", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_SoKhopDau));
            Command.Parameters.Add(new MDB.MDBParameter("TK_SoKhopSung", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_SoKhopSung));
            Command.Parameters.Add(new MDB.MDBParameter("TK_DAS28", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_DAS28));
            Command.Parameters.Add(new MDB.MDBParameter("TK_ViemKhop", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_ViemKhop));
            Command.Parameters.Add(new MDB.MDBParameter("TK_BienDangKhop", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_BienDangKhop));
            Command.Parameters.Add(new MDB.MDBParameter("TK_BienDangKhop_Text", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_BienDangKhop_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TK_BieuHienNiemMac", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_BieuHienNiemMac));
            Command.Parameters.Add(new MDB.MDBParameter("TK_BieuHienNiemMac_ViTri", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_BieuHienNiemMac_ViTri));
            Command.Parameters.Add(new MDB.MDBParameter("TK_BieuHienKhac_TimMach", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_BieuHienKhac_TimMach));
            Command.Parameters.Add(new MDB.MDBParameter("TK_BieuHienKhac_TietNieu", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_BieuHienKhac_TietNieu));
            Command.Parameters.Add(new MDB.MDBParameter("TK_BieuHienKhac_HoHap", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_BieuHienKhac_HoHap));
            Command.Parameters.Add(new MDB.MDBParameter("TK_BieuHienKhac_TieuHoa", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_BieuHienKhac_TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("TK_BieuHienKhac_TamThan", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_BieuHienKhac_TamThan));
            Command.Parameters.Add(new MDB.MDBParameter("TK_BieuHienKhac_CoQuanKhac", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_BieuHienKhac_CoQuanKhac));
            Command.Parameters.Add(new MDB.MDBParameter("TK_DiemDLQI_1", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_DiemDLQI_1));
            Command.Parameters.Add(new MDB.MDBParameter("TK_DiemDLQI_2", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_DiemDLQI_2));
            Command.Parameters.Add(new MDB.MDBParameter("TK_DiemDLQI_3", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_DiemDLQI_3));
            Command.Parameters.Add(new MDB.MDBParameter("TK_DiemDLQI_4", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_DiemDLQI_4));
            Command.Parameters.Add(new MDB.MDBParameter("TK_DiemDLQI_5", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_DiemDLQI_5));
            Command.Parameters.Add(new MDB.MDBParameter("TK_DiemDLQI_6", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_DiemDLQI_6));
            Command.Parameters.Add(new MDB.MDBParameter("TK_DiemDLQI_7", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_DiemDLQI_7));
            Command.Parameters.Add(new MDB.MDBParameter("TK_DiemDLQI_8", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_DiemDLQI_8));
            Command.Parameters.Add(new MDB.MDBParameter("TK_DiemDLQI_9", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_DiemDLQI_9));
            Command.Parameters.Add(new MDB.MDBParameter("TK_DiemDLQI_10", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_DiemDLQI_10));
            Command.Parameters.Add(new MDB.MDBParameter("TK_TongDiem", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_TongDiem));
            Command.Parameters.Add(new MDB.MDBParameter("TK_CTM_HC", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_CTM_HC));
            Command.Parameters.Add(new MDB.MDBParameter("TK_CTM_Hb", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_CTM_Hb));
            Command.Parameters.Add(new MDB.MDBParameter("TK_CTM_HCT", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_CTM_HCT));
            Command.Parameters.Add(new MDB.MDBParameter("TK_CTM_TieuCau", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_CTM_TieuCau));
            Command.Parameters.Add(new MDB.MDBParameter("TK_CTM_BachCau", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_CTM_BachCau));
            Command.Parameters.Add(new MDB.MDBParameter("TK_CTM_Lympho", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_CTM_Lympho));
            Command.Parameters.Add(new MDB.MDBParameter("TK_CTM_TT", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_CTM_TT));
            Command.Parameters.Add(new MDB.MDBParameter("TK_CTM_Mono", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_CTM_Mono));
            Command.Parameters.Add(new MDB.MDBParameter("TK_CTM_Khac", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_CTM_Khac));
            Command.Parameters.Add(new MDB.MDBParameter("TK_MauLang_1", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_MauLang_1));
            Command.Parameters.Add(new MDB.MDBParameter("TK_MauLang_2", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_MauLang_2));
            Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_Ure", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_SinhHoa_Ure));
            Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_Cre", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_SinhHoa_Cre));
            Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_Glu", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_SinhHoa_Glu));
            Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_Uric", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_SinhHoa_Uric));
            Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_TP", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_SinhHoa_TP));
            Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_TT", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_SinhHoa_TT));
            Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_GT", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_SinhHoa_GT));
            Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_Protein", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_SinhHoa_Protein));
            Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_Alb", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_SinhHoa_Alb));
            Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_Cholesterol", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_SinhHoa_Cholesterol));
            Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_Tri", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_SinhHoa_Tri));
            Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_HDL", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_SinhHoa_HDL));
            Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_LDL", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_SinhHoa_LDL));
            Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_GOT", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_SinhHoa_GOT));
            Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_GPT", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_SinhHoa_GPT));
            Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_CK", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_SinhHoa_CK));
            Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_DGD_Na", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_SinhHoa_DGD_Na));
            Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_DGD_K", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_SinhHoa_DGD_K));
            Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_DGD_Cl", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_SinhHoa_DGD_Cl));
            Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_DGD_Ca", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_SinhHoa_DGD_Ca));
            Command.Parameters.Add(new MDB.MDBParameter("TK_SinhHoa_DGD_CaIonHoa", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_SinhHoa_DGD_CaIonHoa));
            Command.Parameters.Add(new MDB.MDBParameter("STK_inhHoa_DGD_HbA1c", BenhAnNgoaiTru_BenhVayNenThongThuong.STK_inhHoa_DGD_HbA1c));
            Command.Parameters.Add(new MDB.MDBParameter("TK_ProteinNieu", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_ProteinNieu));
            Command.Parameters.Add(new MDB.MDBParameter("TK_TruNieu", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_TruNieu));
            Command.Parameters.Add(new MDB.MDBParameter("TK_HCNieu", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_HCNieu));
            Command.Parameters.Add(new MDB.MDBParameter("TK_BCNieu", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_BCNieu));
            Command.Parameters.Add(new MDB.MDBParameter("TK_XetNghiemKhac", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_XetNghiemKhac));
            Command.Parameters.Add(new MDB.MDBParameter("TK_TacDungPhu", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_TacDungPhu));
            Command.Parameters.Add(new MDB.MDBParameter("TK_TenThuoc", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_TenThuoc));
            Command.Parameters.Add(new MDB.MDBParameter("TK_LietKeTacDungPhu", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_LietKeTacDungPhu));
            Command.Parameters.Add(new MDB.MDBParameter("TK_ThuocBoi", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_ThuocBoi));
            Command.Parameters.Add(new MDB.MDBParameter("TK_ThuocToanThan", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_ThuocToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TK_HenKhamLai", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_HenKhamLai));
            Command.Parameters.Add(new MDB.MDBParameter("TK_BacSyDieuTri", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_BacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("TK_MaBacSyDieuTri", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_MaBacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("TK_QuaTrinhBenhLy", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_QuaTrinhBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("TK_TomTatKetQua", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_TomTatKetQua));
            Command.Parameters.Add(new MDB.MDBParameter("TK_BenhChinh", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("TK_MaBenhChinh", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_MaBenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("TK_BenhKemTheo", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_BenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("TK_MaBenhKemTheo", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_MaBenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("TK_PhuongPhapDieuTri", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_PhuongPhapDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("TK_TinhTrangRaVien", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_TinhTrangRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("TK_HuongDieuTri", BenhAnNgoaiTru_BenhVayNenThongThuong.TK_HuongDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnNgoaiTru_BenhVayNenThongThuong.NguoiNhanHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnNgoaiTru_BenhVayNenThongThuong.NguoiGiaoHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnNgoaiTru_BenhVayNenThongThuong.NgayTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnNgoaiTru_BenhVayNenThongThuong.BacSyDieuTri));

            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnNgoaiTru_BenhVayNenThongThuong.MaQuanLy));
            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
    }
}
