using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections.ObjectModel;
using EMR_MAIN.DATABASE.BenhAn;
using MedilinkHL7.SDK;
using Newtonsoft.Json;
using System.Globalization;

namespace EMR_MAIN.DATABASE.BenhAnFunc
{
    public class BenhAnCMUFunc
    {
        public static void WriteXml(MDB.MDBConnection MyConnection)
        {
            string sql =
                   @"
                  select  a.*,  CTScanner HoSo_CTScanner, SieuAm HoSo_SieuAm, XetNghiem HoSo_XetNghiem,  Khac HoSo_Khac,  Khac_Text HoSo_Khac_Text,  ToanBoHoSo HoSo_ToanBoHoSo, Mach DauSinhTon_Mach,  NhietDo DauSinhTon_NhietDo,  HuyetAp DauSinhTon_HuyetAp,  NhipTho DauSinhTon_NhipTho,  CanNang DauSinhTon_CanNang  
                  from BenhAnCMU a inner join thongtindieutri b on a.maquanly = b.maquanly
                  where rownum = 1
                    ";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            var DataTable = new DataTable { TableName = "BenhAnCMU" };
            DataTable.Load(DataReader as IDataReader);
            DataTable.WriteXml("rptBenhAnCMU.xml");
        }
        public static DataSet SelectDataSet(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql =
                   @"
                   select  a.* from BenhAnCMU a  where a.maquanly = " + MaQuanLy.ToString(CultureInfo.InvariantCulture);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(sql, MyConnection);
            var ds = new DataSet();
            adt.Fill(ds, "Table");

            string sql2 = ds.Tables[0].Rows[0]["XetNghiemCMUs"].ToString();
            ObservableCollection<XetNghiemCMU> XetNghiemCMUs = JsonConvert.DeserializeObject<ObservableCollection<XetNghiemCMU>>(sql2);

            DataTable tableXetNghiem = new DataTable("XN");
            tableXetNghiem.Columns.Add("ThongSo");
            tableXetNghiem.Columns.Add("GiaTri_Truoc");
            tableXetNghiem.Columns.Add("Per_Truoc");
            tableXetNghiem.Columns.Add("GiaTri_Sau");
            tableXetNghiem.Columns.Add("Per_Sau");
            tableXetNghiem.Columns.Add("KetQua");
            if(XetNghiemCMUs != null)
            {
                foreach(XetNghiemCMU xetNghiemCMU in XetNghiemCMUs)
                {
                    tableXetNghiem.Rows.Add(
                                        xetNghiemCMU.ThongSo,
                                        xetNghiemCMU.GiaTri_Truoc,
                                        xetNghiemCMU.Per_Truoc.HasValue ? xetNghiemCMU.Per_Truoc.Value.ToString() : "",
                                        xetNghiemCMU.GiaTri_Sau,
                                        xetNghiemCMU.Per_Sau.HasValue ? xetNghiemCMU.Per_Sau.Value.ToString() : "",
                                        xetNghiemCMU.KetQua
                                        );
                }
            }
            
            ds.Tables.Add(tableXetNghiem);;

            return ds;
        }
        public static BenhAnCMU Select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            #region
            string sql =
                      @"select * 
                        from BenhAnCMU a
                        where MaQuanLy = :MaQuanLy";
            #endregion
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            var value = new BenhAnCMU();
            while (DataReader.Read())
            {
                value.MaQuanLy = DataReader.GetDecimal("MaQuanLy");
                value.DienThoaiDiDong = DataReader["DienThoaiDiDong"].ToString();
                value.NgheNghiepDiLamLauNhat = DataReader["NgheNghiepDiLamLauNhat"].ToString();
                value.NgheNghiepDiLamLauNhat = DataReader["NgheNghiepDiLamLauNhat"].ToString();
                value.NgayLaphoSo = DataReader["NgayLaphoSo"] == DBNull.Value ? null : (DateTime?) DataReader.GetDate("NgayLaphoSo");
                value.NoiGioiThieu = DataReader["NoiGioiThieu"].ToString();
                value.TuDen = DataReader["TuDen"].ToString().Equals("1") ? true : false;
                value.LyDoKhamBenh = DataReader["LyDoKhamBenh"].ToString();
                value.TrieuChungKhac = DataReader["TrieuChungKhac"]?.ToString();
                value.KhongHut = DataReader["KhongHut"].ToString().Equals("1") ? true:false;
                value.hutNhungDaCai = DataReader["hutNhungDaCai"].ToString().Equals("1") ? true:false;
                value.CaiBaoLau = DataReader["CaiBaoLau"].ToString();
                int intTemp = 0;
                value.SoBaoDaHutNam = int.TryParse(DataReader["SoBaoDaHutNam"].ToString(), out intTemp) ? (int?) intTemp: null;
                value.DangHut = DataReader["DangHut"].ToString().Equals("1") ? true:false;
                value.SoBaoHutNam = int.TryParse(DataReader["SoBaoHutNam"].ToString(), out intTemp) ? (int?)intTemp : null;
                value.TienSuBenhh = DataReader["TienSuBenhh"].ToString();
                value.ChuanDoanTu = DataReader["ChuanDoanTu"] == DBNull.Value ? null : (DateTime?)DataReader.GetDate("ChuanDoanTu");
                value.DoCNHH = DataReader.GetInt("DoCNHH");
                value.LaoPhoi = DataReader["LaoPhoi"].Equals("1") ? true : false;
                value.SoLanDieuTriLaoPhoi = int.TryParse(DataReader["SoLanDieuTriLaoPhoi"].ToString(), out intTemp) ? (int?)intTemp : null;
                value.ThoiGianLaoPhoi = DataReader["ThoiGianLaoPhoi"] == DBNull.Value ? null : (DateTime?)DataReader.GetDate("ThoiGianLaoPhoi");
                value.BenhKhac = DataReader["BenhKhac"].ToString();
                value.TienSuGiaDinh = DataReader["TienSuGiaDinh"].ToString();
                value.TienSuBanThan = DataReader["TienSuBanThan"].ToString();
                value.TienSuSoLanVaoBV = int.TryParse(DataReader["TienSuSoLanVaoBV"].ToString(), out intTemp) ? (int?)intTemp : null;
                value.TienSuBV = DataReader["TienSuBV"].ToString();
                value.CoPhaiThuMay = DataReader.GetInt("CoPhaiThuMay");
                value.TrieuChung = DataReader.GetInt("CoPhaiThuMay");
                double doubleTemp = 0;
                value.DiemACT = double.TryParse(DataReader["DiemACT"].ToString(), out doubleTemp) ? (double?) doubleTemp : null;
                value.KS = DataReader.GetInt("KS");
                value.YeuToLienQuan = DataReader.GetInt("YeuToLienQuan");
                value.YeuToNao = DataReader["YeuToNao"].ToString();
                value.YeuToNao = DataReader["YeuToKhac"].ToString();
                value.BenhCoGiam = DataReader.GetInt("BenhCoGiam");
                value.ThoiGianConDauTien = DataReader["ThoiGianConDauTien"] == DBNull.Value ? null : (DateTime?)DataReader.GetDate("ThoiGianConDauTien");
                value.FEV1_Nhe = double.TryParse(DataReader["FEV1_Nhe"].ToString(), out doubleTemp) ? (double?)doubleTemp : null;
                value.FEV1_TrungBinh = double.TryParse(DataReader["FEV1_TrungBinh"].ToString(), out doubleTemp) ? (double?)doubleTemp : null;
                value.FEV1_Nang = double.TryParse(DataReader["FEV1_Nang"].ToString(), out doubleTemp) ? (double?)doubleTemp : null;
                value.FEV1_RatNang = double.TryParse(DataReader["FEV1_RatNang"].ToString(), out doubleTemp) ? (double?)doubleTemp : null;
                value.ThuocDaSuDung = DataReader["ThuocDaSuDung"].ToString();
                value.Thuoc_Khac = DataReader["Thuoc_Khac"].ToString();
                value.DangThuoc = DataReader["DangThuoc"].ToString() ;
                value.CacThuocDuPhong = DataReader["CacThuocDuPhong"].ToString();
                value.CacThuocDuPhong_Khac = DataReader["CacThuocDuPhong_Khac"].ToString();
                value.KyNang = DataReader.GetInt("KyNang");
                value.TuanThu = DataReader.GetInt("TuanThu");
                value.TuanThu = DataReader.GetInt("TuanThu");
                value.Mach = double.TryParse(DataReader["Mach"].ToString(), out doubleTemp) ? (double?)doubleTemp : null;
                value.NhietDo = double.TryParse(DataReader["NhietDo"].ToString(), out doubleTemp) ? (double?)doubleTemp : null;
                value.HuyetAp = DataReader["HuyetAp"].ToString();
                value.NhipTho = double.TryParse(DataReader["NhipTho"].ToString(), out doubleTemp) ? (double?)doubleTemp : null;
                value.HoHapKhamThucThe = DataReader["HoHapKhamThucThe"].ToString();
                value.HoHap_Khac = DataReader["HoHap_Khac"].ToString();
                value.TimMach = DataReader["TimMach"].ToString();
                value.CacBoPhanKhac = DataReader["CacBoPhanKhac"].ToString();
                value.XQuang_Nguc = DataReader["XQuang_Nguc"].ToString();
                value.FCG = DataReader["FCG"].ToString();
                value.NgayDoKhongKhiPhoi = DataReader["NgayDoKhongKhiPhoi"] == DBNull.Value ? null : (DateTime?)DataReader.GetDate("NgayDoKhongKhiPhoi");
                value.Tuoi = DataReader["Tuoi"].ToString();
                value.Gioi = DataReader["Gioi"].ToString();
                value.CanNang = double.TryParse(DataReader["CanNang"].ToString(), out doubleTemp) ? (double?)doubleTemp : null;
                value.ChieuCao = double.TryParse(DataReader["ChieuCao"].ToString(), out doubleTemp) ? (double?)doubleTemp : null;
                value.BMI = double.TryParse(DataReader["BMI"].ToString(), out doubleTemp) ? (double?)doubleTemp : null;
                value.XetNghiemCMUs = JsonConvert.DeserializeObject<ObservableCollection<XetNghiemCMU>>(DataReader["XetNghiemCMUs"].ToString());
                value.PH = DataReader["PH"].ToString();
                value.PaCO2 = DataReader["PaCO2"].ToString();
                value.PO2 = DataReader["PO2"].ToString();
                value.SaO2 = DataReader["SaO2"].ToString();
                value.SpO2 = DataReader["SpO2"].ToString();
                value.XNMau = DataReader["XNMau"].ToString();
                value.Hct = DataReader["Hct"].ToString();
                value.Hgb_dl = DataReader["Hgb_dl"].ToString();
                value.SieuAmTim = DataReader["SieuAmTim"].ToString();
                value.XetNghiemKhac = DataReader["XetNghiemKhac"].ToString();
                value.ChanDoanHen = DataReader["ChanDoanHen"].ToString().Equals("1") ? true:false;
                value.MucKiemSoat = DataReader.GetInt("MucKiemSoat");
                value.ChanDoanCopd = DataReader["ChanDoanCopd"].ToString().Equals("1") ? true : false;
                value.GiaiDoan = DataReader.GetInt("GiaiDoan");
                value.BenhKetHop = DataReader["BenhKetHop"].ToString();
                value.HuongXuTri_TuVan = DataReader["HuongXuTri_TuVan"].ToString();
                value.HuongXuTri_DieuTri = DataReader["HuongXuTri_DieuTri"].ToString();
                value.HuongXuTri_Khac = DataReader["HuongXuTri_Khac"].ToString();
                value.BacSy = DataReader["BacSy"].ToString();
                value.MaBacSy = DataReader["MaBacSy"].ToString();
                value.MaSoKyTen = DataReader["masokyten"].ToString();
                value.MaSoKyTen_KB = DataReader["masokyten_kb"].ToString();
                value.MaSoKyTen_TK = DataReader["masokyten_tk"].ToString();
            }
            return value;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, BenhAnCMU benhAnCMU)
        {
            try
            {
                string sql =
                          @"select MaQuanLy 
                        from BenhAnCMU
                        where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", benhAnCMU.MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                int rowCount = 0;
                while (DataReader.Read()) rowCount++;
                if (rowCount == 1) return Update(MyConnection, benhAnCMU);
                sql = @"
                   INSERT INTO BenhAnCMU (
					MaQuanLy,
                    DienThoaiDiDong,
                    NgheNghiepDiLamLauNhat,
                    NgayLaphoSo,
                    NoiGioiThieu,
                    TuDen,
                    LyDoKhamBenh,
                    TrieuChungKhac,
                    KhongHut,
                    hutNhungDaCai,
                    CaiBaoLau,
                    SoBaoDaHutNam,
                    DangHut,
                    SoBaoHutNam,
                    TienSuBenhh,
                    ChuanDoanTu,
                    DoCNHH,
                    LaoPhoi,
                    SoLanDieuTriLaoPhoi,
                    ThoiGianLaoPhoi,
                    BenhKhac,
                    TienSuGiaDinh,
                    TienSuBanThan,
                    TienSuSoLanVaoBV,
                    TienSuBV,
                    CoPhaiThuMay,
                    TrieuChung,
                    DiemACT,
                    KS,
                    YeuToLienQuan,
                    YeuToNao,
                    YeuToKhac,
                    BenhCoGiam,
                    ThoiGianConDauTien,
                    FEV1_Nhe,
                    FEV1_TrungBinh,
                    FEV1_Nang,
                    FEV1_RatNang,
                    ThuocDaSuDung,
                    Thuoc_Khac,
                    DangThuoc,
                    CacThuocDuPhong,
                    CacThuocDuPhong_Khac,
                    KyNang,
                    TuanThu,
                    Mach,
                    NhietDo,
                    HuyetAp,
                    NhipTho,
                    HoHapKhamThucThe,
                    HoHap_Khac,
                    TimMach,
                    CacBoPhanKhac,
                    XQuang_Nguc,
                    FCG,
                    NgayDoKhongKhiPhoi,
                    Tuoi,
                    Gioi,
                    CanNang,
                    ChieuCao,
                    BMI,
                    XetNghiemCMUs,
                    NgayXNKhiMauDongMach,
                    PH,
                    PaCO2,
                    PO2,
                    SaO2,
                    SpO2,
                    XNMau,
                    Hct,
                    Hgb_dl,
                    SieuAmTim,
                    XetNghiemKhac,
                    ChanDoanHen,
                    MucKiemSoat,
                    ChanDoanCopd,
                    GiaiDoan,
                    BenhKetHop,
                    HuongXuTri_TuVan,
                    HuongXuTri_DieuTri,
                    HuongXuTri_Khac,
                    BacSy,
                    MaBacSy)
                   VALUES(
                    :MaQuanLy,
                    :DienThoaiDiDong,
                    :NgheNghiepDiLamLauNhat,
                    :NgayLaphoSo,
                    :NoiGioiThieu,
                    :TuDen,
                    :LyDoKhamBenh,
                    :TrieuChungKhac,
                    :KhongHut,
                    :hutNhungDaCai,
                    :CaiBaoLau,
                    :SoBaoDaHutNam,
                    :DangHut,
                    :SoBaoHutNam,
                    :TienSuBenhh,
                    :ChuanDoanTu,
                    :DoCNHH,
                    :LaoPhoi,
                    :SoLanDieuTriLaoPhoi,
                    :ThoiGianLaoPhoi,
                    :BenhKhac,
                    :TienSuGiaDinh,
                    :TienSuBanThan,
                    :TienSuSoLanVaoBV,
                    :TienSuBV,
                    :CoPhaiThuMay,
                    :TrieuChung,
                    :DiemACT,
                    :KS,
                    :YeuToLienQuan,
                    :YeuToNao,
                    :YeuToKhac,
                    :BenhCoGiam,
                    :ThoiGianConDauTien,
                    :FEV1_Nhe,
                    :FEV1_TrungBinh,
                    :FEV1_Nang,
                    :FEV1_RatNang,
                    :ThuocDaSuDung,
                    :Thuoc_Khac,
                    :DangThuoc,
                    :CacThuocDuPhong,
                    :CacThuocDuPhong_Khac,
                    :KyNang,
                    :TuanThu,
                    :Mach,
                    :NhietDo,
                    :HuyetAp,
                    :NhipTho,
                    :HoHapKhamThucThe,
                    :HoHap_Khac,
                    :TimMach,
                    :CacBoPhanKhac,
                    :XQuang_Nguc,
                    :FCG,
                    :NgayDoKhongKhiPhoi,
                    :Tuoi,
                    :Gioi,
                    :CanNang,
                    :ChieuCao,
                    :BMI,
                    :XetNghiemCMUs,
                    :NgayXNKhiMauDongMach,
                    :PH,
                    :PaCO2,
                    :PO2,
                    :SaO2,
                    :SpO2,
                    :XNMau,
                    :Hct,
                    :Hgb_dl,
                    :SieuAmTim,
                    :XetNghiemKhac,
                    :ChanDoanHen,
                    :MucKiemSoat,
                    :ChanDoanCopd,
                    :GiaiDoan,
                    :BenhKetHop,
                    :HuongXuTri_TuVan,
                    :HuongXuTri_DieuTri,
                    :HuongXuTri_Khac,
                    :BacSy,
                    :MaBacSy
                    )
                   ";
                Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", benhAnCMU.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("DienThoaiDiDong", benhAnCMU.DienThoaiDiDong));
                Command.Parameters.Add(new MDB.MDBParameter("NgheNghiepDiLamLauNhat", benhAnCMU.NgheNghiepDiLamLauNhat));
                Command.Parameters.Add(new MDB.MDBParameter("NgayLaphoSo", benhAnCMU.NgayLaphoSo));
                Command.Parameters.Add(new MDB.MDBParameter("NoiGioiThieu", benhAnCMU.NoiGioiThieu));
                Command.Parameters.Add(new MDB.MDBParameter("TuDen", benhAnCMU.TuDen ? 1:0));
                Command.Parameters.Add(new MDB.MDBParameter("LyDoKhamBenh", benhAnCMU.LyDoKhamBenh));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungKhac", benhAnCMU.TrieuChungKhac));
                Command.Parameters.Add(new MDB.MDBParameter("KhongHut", benhAnCMU.KhongHut ? 1:0));
                Command.Parameters.Add(new MDB.MDBParameter("hutNhungDaCai", benhAnCMU.hutNhungDaCai ? 1:0));
                Command.Parameters.Add(new MDB.MDBParameter("CaiBaoLau", benhAnCMU.CaiBaoLau));
                Command.Parameters.Add(new MDB.MDBParameter("SoBaoDaHutNam", benhAnCMU.SoBaoDaHutNam));
                Command.Parameters.Add(new MDB.MDBParameter("DangHut", benhAnCMU.DangHut ? 1:0));
                Command.Parameters.Add(new MDB.MDBParameter("SoBaoHutNam", benhAnCMU.SoBaoDaHutNam));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhh", benhAnCMU.TienSuBenhh));
                Command.Parameters.Add(new MDB.MDBParameter("ChuanDoanTu", benhAnCMU.ChuanDoanTu));
                Command.Parameters.Add(new MDB.MDBParameter("DoCNHH", benhAnCMU.DoCNHH));
                Command.Parameters.Add(new MDB.MDBParameter("LaoPhoi", benhAnCMU.LaoPhoi ? 1:0));
                Command.Parameters.Add(new MDB.MDBParameter("SoLanDieuTriLaoPhoi", benhAnCMU.SoLanDieuTriLaoPhoi));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianLaoPhoi", benhAnCMU.ThoiGianLaoPhoi));
                Command.Parameters.Add(new MDB.MDBParameter("BenhKhac", benhAnCMU.BenhKhac));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuGiaDinh", benhAnCMU.TienSuGiaDinh));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuBanThan", benhAnCMU.TienSuBanThan));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuSoLanVaoBV", benhAnCMU.TienSuSoLanVaoBV));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuBV", benhAnCMU.TienSuBV));
                Command.Parameters.Add(new MDB.MDBParameter("CoPhaiThuMay", benhAnCMU.CoPhaiThuMay));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChung", benhAnCMU.TrieuChung));
                Command.Parameters.Add(new MDB.MDBParameter("DiemACT", benhAnCMU.DiemACT));
                Command.Parameters.Add(new MDB.MDBParameter("KS", benhAnCMU.KS));
                Command.Parameters.Add(new MDB.MDBParameter("YeuToLienQuan", benhAnCMU.YeuToLienQuan));
                Command.Parameters.Add(new MDB.MDBParameter("YeuToNao", benhAnCMU.YeuToNao));
                Command.Parameters.Add(new MDB.MDBParameter("YeuToKhac", benhAnCMU.YeuToKhac));
                Command.Parameters.Add(new MDB.MDBParameter("BenhCoGiam", benhAnCMU.BenhCoGiam));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianConDauTien", benhAnCMU.ThoiGianConDauTien));
                Command.Parameters.Add(new MDB.MDBParameter("FEV1_Nhe", benhAnCMU.FEV1_Nhe));
                Command.Parameters.Add(new MDB.MDBParameter("FEV1_TrungBinh", benhAnCMU.FEV1_TrungBinh));
                Command.Parameters.Add(new MDB.MDBParameter("FEV1_Nang", benhAnCMU.FEV1_Nang));
                Command.Parameters.Add(new MDB.MDBParameter("FEV1_RatNang", benhAnCMU.FEV1_RatNang));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocDaSuDung", benhAnCMU.ThuocDaSuDung));
                Command.Parameters.Add(new MDB.MDBParameter("Thuoc_Khac", benhAnCMU.Thuoc_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("DangThuoc", benhAnCMU.DangThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("CacThuocDuPhong", benhAnCMU.CacThuocDuPhong));
                Command.Parameters.Add(new MDB.MDBParameter("CacThuocDuPhong_Khac", benhAnCMU.CacThuocDuPhong_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("KyNang", benhAnCMU.KyNang));
                Command.Parameters.Add(new MDB.MDBParameter("TuanThu", benhAnCMU.TuanThu));
                Command.Parameters.Add(new MDB.MDBParameter("Mach", benhAnCMU.Mach));
                Command.Parameters.Add(new MDB.MDBParameter("NhietDo", benhAnCMU.NhietDo));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetAp", benhAnCMU.HuyetAp));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTho", benhAnCMU.NhipTho));
                Command.Parameters.Add(new MDB.MDBParameter("HoHapKhamThucThe", benhAnCMU.HoHapKhamThucThe));
                Command.Parameters.Add(new MDB.MDBParameter("HoHap_Khac", benhAnCMU.HoHap_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("TimMach", benhAnCMU.TimMach));
                Command.Parameters.Add(new MDB.MDBParameter("CacBoPhanKhac", benhAnCMU.CacBoPhanKhac));
                Command.Parameters.Add(new MDB.MDBParameter("XQuang_Nguc", benhAnCMU.XQuang_Nguc));
                Command.Parameters.Add(new MDB.MDBParameter("FCG", benhAnCMU.FCG));
                Command.Parameters.Add(new MDB.MDBParameter("NgayDoKhongKhiPhoi", benhAnCMU.NgayDoKhongKhiPhoi));
                Command.Parameters.Add(new MDB.MDBParameter("Tuoi", benhAnCMU.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("Gioi", benhAnCMU.Gioi));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang", benhAnCMU.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("ChieuCao", benhAnCMU.ChieuCao));
                Command.Parameters.Add(new MDB.MDBParameter("BMI", benhAnCMU.BMI));
                Command.Parameters.Add(new MDB.MDBParameter("XetNghiemCMUs", JsonConvert.SerializeObject(benhAnCMU.XetNghiemCMUs)));
                Command.Parameters.Add(new MDB.MDBParameter("NgayXNKhiMauDongMach", benhAnCMU.NgayXNKhiMauDongMach));
                Command.Parameters.Add(new MDB.MDBParameter("PH", benhAnCMU.PH));
                Command.Parameters.Add(new MDB.MDBParameter("PaCO2", benhAnCMU.PaCO2));
                Command.Parameters.Add(new MDB.MDBParameter("PO2", benhAnCMU.PO2));
                Command.Parameters.Add(new MDB.MDBParameter("SaO2", benhAnCMU.SaO2));
                Command.Parameters.Add(new MDB.MDBParameter("SpO2", benhAnCMU.SpO2));
                Command.Parameters.Add(new MDB.MDBParameter("XNMau", benhAnCMU.XNMau));
                Command.Parameters.Add(new MDB.MDBParameter("Hct", benhAnCMU.Hct));
                Command.Parameters.Add(new MDB.MDBParameter("Hgb_dl", benhAnCMU.Hgb_dl));
                Command.Parameters.Add(new MDB.MDBParameter("SieuAmTim", benhAnCMU.SieuAmTim));
                Command.Parameters.Add(new MDB.MDBParameter("XetNghiemKhac", benhAnCMU.XetNghiemKhac));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanHen", benhAnCMU.ChanDoanHen ? 1:0));
                Command.Parameters.Add(new MDB.MDBParameter("MucKiemSoat", benhAnCMU.MucKiemSoat));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanCopd", benhAnCMU.ChanDoanCopd ? 1:0));
                Command.Parameters.Add(new MDB.MDBParameter("GiaiDoan", benhAnCMU.GiaiDoan));
                Command.Parameters.Add(new MDB.MDBParameter("BenhKetHop", benhAnCMU.BenhKetHop));
                Command.Parameters.Add(new MDB.MDBParameter("HuongXuTri_TuVan", benhAnCMU.HuongXuTri_TuVan));
                Command.Parameters.Add(new MDB.MDBParameter("HuongXuTri_DieuTri", benhAnCMU.HuongXuTri_DieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("HuongXuTri_Khac", benhAnCMU.HuongXuTri_Khac));
                if (!string.IsNullOrEmpty(benhAnCMU.MaBacSy))
                {
                    NhanVien nv = NhanVienFunc.ListNhanVien.Find(x => x.MaNhanVien.Equals(benhAnCMU.MaBacSy));
                    if (nv != null)
                    {
                        benhAnCMU.BacSy = nv.HoVaTen;
                    }
                }
                Command.Parameters.Add(new MDB.MDBParameter("BacSy", benhAnCMU.BacSy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSy", benhAnCMU.MaBacSy));

                Command.BindByName = true;
                int n = Command.ExecuteNonQuery(); // C#
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
                return false;
            }
        }
        public static bool Update(MDB.MDBConnection MyConnection, BenhAnCMU benhAnCMU)
        {
            try
            {
                string sql = @"UPDATE BenhAnCMU SET 
                        MaQuanLy = :MaQuanLy,
                        DienThoaiDiDong = :DienThoaiDiDong,
                        NgheNghiepDiLamLauNhat = :NgheNghiepDiLamLauNhat,
                        NgayLaphoSo = :NgayLaphoSo,
                        NoiGioiThieu = :NoiGioiThieu,
                        TuDen = :TuDen,
                        LyDoKhamBenh = :LyDoKhamBenh,
                        TrieuChungKhac = :TrieuChungKhac,
                        KhongHut = :KhongHut,
                        hutNhungDaCai = :hutNhungDaCai,
                        CaiBaoLau = :CaiBaoLau,
                        SoBaoDaHutNam = :SoBaoDaHutNam,
                        DangHut = :DangHut,
                        SoBaoHutNam = :SoBaoHutNam,
                        TienSuBenhh = :TienSuBenhh,
                        ChuanDoanTu = :ChuanDoanTu,
                        DoCNHH = :DoCNHH,
                        LaoPhoi = :LaoPhoi,
                        SoLanDieuTriLaoPhoi = :SoLanDieuTriLaoPhoi,
                        ThoiGianLaoPhoi = :ThoiGianLaoPhoi,
                        BenhKhac = :BenhKhac,
                        TienSuGiaDinh = :TienSuGiaDinh,
                        TienSuBanThan = :TienSuBanThan,
                        TienSuSoLanVaoBV = :TienSuSoLanVaoBV,
                        TienSuBV = :TienSuBV,
                        CoPhaiThuMay = :CoPhaiThuMay,
                        TrieuChung = :TrieuChung,
                        DiemACT = :DiemACT,
                        KS = :KS,
                        YeuToLienQuan = :YeuToLienQuan,
                        YeuToNao = :YeuToNao,
                        YeuToKhac = :YeuToKhac,
                        BenhCoGiam = :BenhCoGiam,
                        ThoiGianConDauTien = :ThoiGianConDauTien,
                        FEV1_Nhe = :FEV1_Nhe,
                        FEV1_TrungBinh = :FEV1_TrungBinh,
                        FEV1_Nang = :FEV1_Nang,
                        FEV1_RatNang = :FEV1_RatNang,
                        ThuocDaSuDung = :ThuocDaSuDung,
                        Thuoc_Khac = :Thuoc_Khac,
                        DangThuoc = :DangThuoc,
                        CacThuocDuPhong = :CacThuocDuPhong,
                        CacThuocDuPhong_Khac = :CacThuocDuPhong_Khac,
                        KyNang = :KyNang,
                        TuanThu = :TuanThu,
                        Mach = :Mach,
                        NhietDo = :NhietDo,
                        HuyetAp = :HuyetAp,
                        NhipTho = :NhipTho,
                        HoHapKhamThucThe = :HoHapKhamThucThe,
                        HoHap_Khac = :HoHap_Khac,
                        TimMach = :TimMach,
                        CacBoPhanKhac = :CacBoPhanKhac,
                        XQuang_Nguc = :XQuang_Nguc,
                        FCG = :FCG,
                        NgayDoKhongKhiPhoi = :NgayDoKhongKhiPhoi,
                        Tuoi = :Tuoi,
                        Gioi = :Gioi,
                        CanNang = :CanNang,
                        ChieuCao = :ChieuCao,
                        BMI = :BMI,
                        XetNghiemCMUs = :XetNghiemCMUs,
                        NgayXNKhiMauDongMach = :NgayXNKhiMauDongMach,
                        PH = :PH,
                        PaCO2 = :PaCO2,
                        PO2 = :PO2,
                        SaO2 = :SaO2,
                        SpO2 = :SpO2,
                        XNMau = :XNMau,
                        Hct = :Hct,
                        Hgb_dl = :Hgb_dl,
                        SieuAmTim = :SieuAmTim,
                        XetNghiemKhac = :XetNghiemKhac,
                        ChanDoanHen = :ChanDoanHen,
                        MucKiemSoat = :MucKiemSoat,
                        ChanDoanCopd = :ChanDoanCopd,
                        GiaiDoan = :GiaiDoan,
                        BenhKetHop = :BenhKetHop,
                        HuongXuTri_TuVan = :HuongXuTri_TuVan,
                        HuongXuTri_DieuTri = :HuongXuTri_DieuTri,
                        HuongXuTri_Khac = :HuongXuTri_Khac,
                        BacSy = :BacSy,
                        MaBacSy = :MaBacSy
                        WHERE MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", benhAnCMU.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("DienThoaiDiDong", benhAnCMU.DienThoaiDiDong));
                Command.Parameters.Add(new MDB.MDBParameter("NgheNghiepDiLamLauNhat", benhAnCMU.NgheNghiepDiLamLauNhat));
                Command.Parameters.Add(new MDB.MDBParameter("NgayLaphoSo", benhAnCMU.NgayLaphoSo));
                Command.Parameters.Add(new MDB.MDBParameter("NoiGioiThieu", benhAnCMU.NoiGioiThieu));
                Command.Parameters.Add(new MDB.MDBParameter("TuDen", benhAnCMU.TuDen ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("LyDoKhamBenh", benhAnCMU.LyDoKhamBenh));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungKhac", benhAnCMU.TrieuChungKhac));
                Command.Parameters.Add(new MDB.MDBParameter("KhongHut", benhAnCMU.KhongHut ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("hutNhungDaCai", benhAnCMU.hutNhungDaCai ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("CaiBaoLau", benhAnCMU.CaiBaoLau));
                Command.Parameters.Add(new MDB.MDBParameter("SoBaoDaHutNam", benhAnCMU.SoBaoDaHutNam));
                Command.Parameters.Add(new MDB.MDBParameter("DangHut", benhAnCMU.DangHut ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("SoBaoHutNam", benhAnCMU.SoBaoDaHutNam));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhh", benhAnCMU.TienSuBenhh));
                Command.Parameters.Add(new MDB.MDBParameter("ChuanDoanTu", benhAnCMU.ChuanDoanTu));
                Command.Parameters.Add(new MDB.MDBParameter("DoCNHH", benhAnCMU.DoCNHH));
                Command.Parameters.Add(new MDB.MDBParameter("LaoPhoi", benhAnCMU.LaoPhoi ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("SoLanDieuTriLaoPhoi", benhAnCMU.SoLanDieuTriLaoPhoi));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianLaoPhoi", benhAnCMU.ThoiGianLaoPhoi));
                Command.Parameters.Add(new MDB.MDBParameter("BenhKhac", benhAnCMU.BenhKhac));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuGiaDinh", benhAnCMU.TienSuGiaDinh));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuBanThan", benhAnCMU.TienSuBanThan));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuSoLanVaoBV", benhAnCMU.TienSuSoLanVaoBV));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuBV", benhAnCMU.TienSuBV));
                Command.Parameters.Add(new MDB.MDBParameter("CoPhaiThuMay", benhAnCMU.CoPhaiThuMay));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChung", benhAnCMU.TrieuChung));
                Command.Parameters.Add(new MDB.MDBParameter("DiemACT", benhAnCMU.DiemACT));
                Command.Parameters.Add(new MDB.MDBParameter("KS", benhAnCMU.KS));
                Command.Parameters.Add(new MDB.MDBParameter("YeuToLienQuan", benhAnCMU.YeuToLienQuan));
                Command.Parameters.Add(new MDB.MDBParameter("YeuToNao", benhAnCMU.YeuToNao));
                Command.Parameters.Add(new MDB.MDBParameter("YeuToKhac", benhAnCMU.YeuToKhac));
                Command.Parameters.Add(new MDB.MDBParameter("BenhCoGiam", benhAnCMU.BenhCoGiam));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianConDauTien", benhAnCMU.ThoiGianConDauTien));
                Command.Parameters.Add(new MDB.MDBParameter("FEV1_Nhe", benhAnCMU.FEV1_Nhe));
                Command.Parameters.Add(new MDB.MDBParameter("FEV1_TrungBinh", benhAnCMU.FEV1_TrungBinh));
                Command.Parameters.Add(new MDB.MDBParameter("FEV1_Nang", benhAnCMU.FEV1_Nang));
                Command.Parameters.Add(new MDB.MDBParameter("FEV1_RatNang", benhAnCMU.FEV1_RatNang));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocDaSuDung", benhAnCMU.ThuocDaSuDung));
                Command.Parameters.Add(new MDB.MDBParameter("Thuoc_Khac", benhAnCMU.Thuoc_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("DangThuoc", benhAnCMU.DangThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("CacThuocDuPhong", benhAnCMU.CacThuocDuPhong));
                Command.Parameters.Add(new MDB.MDBParameter("CacThuocDuPhong_Khac", benhAnCMU.CacThuocDuPhong_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("KyNang", benhAnCMU.KyNang));
                Command.Parameters.Add(new MDB.MDBParameter("TuanThu", benhAnCMU.TuanThu));
                Command.Parameters.Add(new MDB.MDBParameter("Mach", benhAnCMU.Mach));
                Command.Parameters.Add(new MDB.MDBParameter("NhietDo", benhAnCMU.NhietDo));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetAp", benhAnCMU.HuyetAp));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTho", benhAnCMU.NhipTho));
                Command.Parameters.Add(new MDB.MDBParameter("HoHapKhamThucThe", benhAnCMU.HoHapKhamThucThe));
                Command.Parameters.Add(new MDB.MDBParameter("HoHap_Khac", benhAnCMU.HoHap_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("TimMach", benhAnCMU.TimMach));
                Command.Parameters.Add(new MDB.MDBParameter("CacBoPhanKhac", benhAnCMU.CacBoPhanKhac));
                Command.Parameters.Add(new MDB.MDBParameter("XQuang_Nguc", benhAnCMU.XQuang_Nguc));
                Command.Parameters.Add(new MDB.MDBParameter("FCG", benhAnCMU.FCG));
                Command.Parameters.Add(new MDB.MDBParameter("NgayDoKhongKhiPhoi", benhAnCMU.NgayDoKhongKhiPhoi));
                Command.Parameters.Add(new MDB.MDBParameter("Tuoi", benhAnCMU.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("Gioi", benhAnCMU.Gioi));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang", benhAnCMU.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("ChieuCao", benhAnCMU.ChieuCao));
                Command.Parameters.Add(new MDB.MDBParameter("BMI", benhAnCMU.BMI));
                Command.Parameters.Add(new MDB.MDBParameter("XetNghiemCMUs", JsonConvert.SerializeObject(benhAnCMU.XetNghiemCMUs)));
                Command.Parameters.Add(new MDB.MDBParameter("NgayXNKhiMauDongMach", benhAnCMU.NgayXNKhiMauDongMach));
                Command.Parameters.Add(new MDB.MDBParameter("PH", benhAnCMU.PH));
                Command.Parameters.Add(new MDB.MDBParameter("PaCO2", benhAnCMU.PaCO2));
                Command.Parameters.Add(new MDB.MDBParameter("PO2", benhAnCMU.PO2));
                Command.Parameters.Add(new MDB.MDBParameter("SaO2", benhAnCMU.SaO2));
                Command.Parameters.Add(new MDB.MDBParameter("SpO2", benhAnCMU.SpO2));
                Command.Parameters.Add(new MDB.MDBParameter("XNMau", benhAnCMU.XNMau));
                Command.Parameters.Add(new MDB.MDBParameter("Hct", benhAnCMU.Hct));
                Command.Parameters.Add(new MDB.MDBParameter("Hgb_dl", benhAnCMU.Hgb_dl));
                Command.Parameters.Add(new MDB.MDBParameter("SieuAmTim", benhAnCMU.SieuAmTim));
                Command.Parameters.Add(new MDB.MDBParameter("XetNghiemKhac", benhAnCMU.XetNghiemKhac));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanHen", benhAnCMU.ChanDoanHen ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("MucKiemSoat", benhAnCMU.MucKiemSoat));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanCopd", benhAnCMU.ChanDoanCopd ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("GiaiDoan", benhAnCMU.GiaiDoan));
                Command.Parameters.Add(new MDB.MDBParameter("BenhKetHop", benhAnCMU.BenhKetHop));
                Command.Parameters.Add(new MDB.MDBParameter("HuongXuTri_TuVan", benhAnCMU.HuongXuTri_TuVan));
                Command.Parameters.Add(new MDB.MDBParameter("HuongXuTri_DieuTri", benhAnCMU.HuongXuTri_DieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("HuongXuTri_Khac", benhAnCMU.HuongXuTri_Khac));
                if (!string.IsNullOrEmpty(benhAnCMU.MaBacSy))
                {
                    NhanVien nv = NhanVienFunc.ListNhanVien.Find(x => x.MaNhanVien.Equals(benhAnCMU.MaBacSy));
                    if (nv != null)
                    {
                        benhAnCMU.BacSy = nv.HoVaTen;
                    }
                }
                Command.Parameters.Add(new MDB.MDBParameter("BacSy", benhAnCMU.BacSy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSy", benhAnCMU.MaBacSy));
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery(); // C#
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
                return false;
            }

        }
        public static bool Delete(MDB.MDBConnection MyConnection, BenhAnCMU BenhAnCMU)
        {
            string sql = @"DELETE FROM BenhAnCMU 
                           WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnCMU.MaQuanLy));

            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
    }
}
