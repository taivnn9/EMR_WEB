using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using System.Data;

namespace EMR_MAIN
{
    public class BenhAnLuuCapCuuFunc
    {
        public static void WriteXml(MDB.MDBConnection MyConnection)
        {
            string sql =
                   @"
                  select  a.*,  CTScanner HoSo_CTScanner, SieuAm HoSo_SieuAm, XetNghiem HoSo_XetNghiem,  Khac HoSo_Khac,  Khac_Text HoSo_Khac_Text,  ToanBoHoSo HoSo_ToanBoHoSo, Mach DauSinhTon_Mach,  NhietDo DauSinhTon_NhietDo,  HuyetAp DauSinhTon_HuyetAp,  NhipTho DauSinhTon_NhipTho,  CanNang DauSinhTon_CanNang  
                  from BenhAnLuuCapCuu a inner join thongtindieutri b on a.maquanly = b.maquanly
                  where rownum = 1
                    ";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            var DataTable = new DataTable { TableName = "BenhAnLuuCapCuu" };
            DataTable.Load(DataReader as IDataReader);
            DataTable.WriteXml("rptBenhAnLuuCapCuu.xml");
        }
        public static DataSet SelectDataSet(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql =
                   @"
                  select  a.*, g.hovaten GiamDocBenhVienHoVaTen, f.hovaten BacSyLamBenhAnHoVaTen, b.XQuang HoSo_XQuang,   b.CTScanner HoSo_CTScanner, b.SieuAm HoSo_SieuAm, b.XetNghiem HoSo_XetNghiem,  b.Khac HoSo_Khac,  b.Khac_Text HoSo_Khac_Text,  b.ToanBoHoSo HoSo_ToanBoHoSo, b.Mach DauSinhTon_Mach, b.NhietDo DauSinhTon_NhietDo,  b.HuyetAp DauSinhTon_HuyetAp,  b.NhipTho DauSinhTon_NhipTho,  b.CanNang DauSinhTon_CanNang  , b.ChieuCao DauSinhTon_ChieuCao, b.BMI DauSinhTon_BMI, b.NgayRaVien 
                  from BenhAnLuuCapCuu a 
                  left join thongtindieutri b on a.maquanly = b.maquanly 
                  left join nhanvien f on a.BacSyLamBenhAn = f.manhanvien
                  left join nhanvien g on b.MaGiamDocBenhVien = g.manhanvien
                  where a.maquanly = " + MaQuanLy.ToString(System.Globalization.CultureInfo.InvariantCulture);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(sql, MyConnection);
            var ds = new DataSet();
            adt.Fill(ds, "Table");


            string sql2 = @"select a.ThongTinYLenhs
                  from BenhAnLuuCapCuu a
                  where a.maquanly = " + MaQuanLy.ToString(System.Globalization.CultureInfo.InvariantCulture);
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            ObservableCollection<ThongTinYLenh> thongTinYLenhs = new ObservableCollection<ThongTinYLenh>();
            while (DataReader.Read())
            {
                thongTinYLenhs = JsonConvert.DeserializeObject<ObservableCollection<ThongTinYLenh>>(DataReader["ThongTinYLenhs"].ToString());
            }
            if (thongTinYLenhs != null)
            {
                DataTable table2 = new DataTable("Table2");
                table2.Columns.Add("NgayGio");
                table2.Columns.Add("DienBienBenh");
                table2.Columns.Add("YLenh");
                foreach (ThongTinYLenh thongTin in thongTinYLenhs)
                {
                    table2.Rows.Add(thongTin.NgayGio, thongTin.DienBienBenh, thongTin.YLenh);
                }
                ds.Tables.Add(table2);
            }
            
            return ds;
        }
        public static BenhAnLuuCapCuu Select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            #region
            string sql =
                      @"select * 
                        from BenhAnLuuCapCuu a
                        where MaQuanLy = :MaQuanLy";
            #endregion
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            var value = new BenhAnLuuCapCuu();
            value.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
            while (DataReader.Read())
            {
                value.MaQuanLy =  DataReader.GetDecimal("MaQuanLy");
                value.LyDoVaoVien = DataReader["LyDoVaoVien"].ToString();
                value.VaoNgayThu = DataReader.GetInt("VaoNgayThu");
                value.QuaTrinhBenhLy = DataReader["QuaTrinhBenhLy"].ToString();
                value.TienSuBenhBanThan = DataReader["TienSuBenhBanThan"].ToString();
                value.TienSuBenhGiaDinh = DataReader["TienSuBenhGiaDinh"].ToString();
                value.ToanThan = DataReader["ToanThan"].ToString();
                value.CacBoPhan = DataReader["CacBoPhan"].ToString();
                value.TomTatKetQuaCanLamSang = DataReader["TomTatKetQuaCanLamSang"].ToString();
                value.ChanDoanBanDau = DataReader["ChanDoanBanDau"].ToString();
                value.DaXuLy = DataReader["DaXuLy"].ToString();
                value.ChanDoanKhiRaVien = DataReader["ChanDoanKhiRaVien"].ToString();
                value.RaVienLuc = HIS.Convert.ToDateTime(DataReader["RaVienLuc"] == DBNull.Value ? DateTime.Now : DataReader["RaVienLuc"]);
                value.KeToa = DataReader["KeToa"].ToString().Equals("1") ? true : false;
                value.Khoi = DataReader["Khoi"].ToString().Equals("1") ? true : false;
                value.TronVien = DataReader["TronVien"].ToString().Equals("1")? true : false;
                value.ThongTinYLenhs = JsonConvert.DeserializeObject<ObservableCollection<ThongTinYLenh>>(DataReader["ThongTinYLenhs"].ToString());
                value.MAIDC_ChanDoanKhiRaVien = DataReader["MAIDC_ChanDoanKhiRaVien"].ToString();
                value.BacSyLamBenhAn = DataReader["BacSyLamBenhAn"].ToString();
                value.MaSoKyTen = DataReader["masokyten"].ToString();
                value.MaSoKyTen_KB = DataReader["masokyten_kb"].ToString();
                value.MaSoKyTen_TK = DataReader["masokyten_tk"].ToString();
            }
            return value;
        }

        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, BenhAnLuuCapCuu BenhAnLuuCapCuu)
        {
            string sql =
                      @"select MaQuanLy 
                        from BenhAnLuuCapCuu
                        where MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnLuuCapCuu.MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            int rowCount = 0;
            while (DataReader.Read()) rowCount++;
            if (rowCount == 1) return Update(MyConnection, BenhAnLuuCapCuu);
            sql = @"
                   INSERT INTO BenhAnLuuCapCuu 
                    (
MaQuanLy, 
LyDoVaoVien, 
VaoNgayThu, 
QuaTrinhBenhLy, 
TienSuBenhBanThan, 
TienSuBenhGiaDinh, 
ToanThan, 
CacBoPhan, 
TomTatKetQuaCanLamSang, 
ChanDoanBanDau, 
DaXuLy, 
ChanDoanKhiRaVien, 
RaVienLuc, 
KeToa,
Khoi, 
TronVien, 
ThongTinYLenhs, 
MAIDC_ChanDoanKhiRaVien,
BacSyLamBenhAn
)
                   VALUES(
:MaQuanLy, 
:LyDoVaoVien, 
:VaoNgayThu, 
:QuaTrinhBenhLy, 
:TienSuBenhBanThan, 
:TienSuBenhGiaDinh, 
:ToanThan, 
:CacBoPhan, 
:TomTatKetQuaCanLamSang, 
:ChanDoanBanDau, 
:DaXuLy, 
:ChanDoanKhiRaVien, 
:RaVienLuc, 
:KeToa,
:Khoi, 
:TronVien, 
:ThongTinYLenhs, 
:MAIDC_ChanDoanKhiRaVien,
:BacSyLamBenhAn
)
                   ";
            Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnLuuCapCuu.MaQuanLy));
            Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnLuuCapCuu.LyDoVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("VaoNgayThu", BenhAnLuuCapCuu.VaoNgayThu));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnLuuCapCuu.QuaTrinhBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhBanThan", BenhAnLuuCapCuu.TienSuBenhBanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhGiaDinh", BenhAnLuuCapCuu.TienSuBenhGiaDinh));
            Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnLuuCapCuu.ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("CacBoPhan", BenhAnLuuCapCuu.CacBoPhan));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQuaCanLamSang", BenhAnLuuCapCuu.TomTatKetQuaCanLamSang));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanBanDau", BenhAnLuuCapCuu.ChanDoanBanDau));
            Command.Parameters.Add(new MDB.MDBParameter("DaXuLy", BenhAnLuuCapCuu.DaXuLy));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanKhiRaVien", BenhAnLuuCapCuu.ChanDoanKhiRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("RaVienLuc", BenhAnLuuCapCuu.RaVienLuc));
            Command.Parameters.Add(new MDB.MDBParameter("KeToa", BenhAnLuuCapCuu.KeToa ? 1:0));
            Command.Parameters.Add(new MDB.MDBParameter("Khoi", BenhAnLuuCapCuu.Khoi?1:0));
            Command.Parameters.Add(new MDB.MDBParameter("TronVien", BenhAnLuuCapCuu.TronVien ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("ThongTinYLenhs", JsonConvert.SerializeObject(BenhAnLuuCapCuu.ThongTinYLenhs)));
            Command.Parameters.Add(new MDB.MDBParameter("MAIDC_ChanDoanKhiRaVien", BenhAnLuuCapCuu.MAIDC_ChanDoanKhiRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyLamBenhAn", BenhAnLuuCapCuu.BacSyLamBenhAn));
            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool Update(MDB.MDBConnection MyConnection, BenhAnLuuCapCuu BenhAnLuuCapCuu)
        {
            string sql = @"UPDATE BenhAnLuuCapCuu SET 
                        LyDoVaoVien = :LyDoVaoVien, 
                        VaoNgayThu = :VaoNgayThu, 
                        QuaTrinhBenhLy = :QuaTrinhBenhLy, 
                        TienSuBenhBanThan = :TienSuBenhBanThan, 
                        TienSuBenhGiaDinh = :TienSuBenhGiaDinh, 
                        ToanThan = :ToanThan, 
                        CacBoPhan = :CacBoPhan, 
                        TomTatKetQuaCanLamSang = :TomTatKetQuaCanLamSang, 
                        ChanDoanBanDau = :ChanDoanBanDau, 
                        DaXuLy = :DaXuLy, 
                        ChanDoanKhiRaVien = :ChanDoanKhiRaVien, 
                        RaVienLuc = :RaVienLuc, 
                        KeToa = :KeToa,
                        Khoi = :Khoi, 
                        TronVien = :TronVien, 
                        ThongTinYLenhs = :ThongTinYLenhs, 
                        MAIDC_ChanDoanKhiRaVien = :MAIDC_ChanDoanKhiRaVien,
                        BacSyLamBenhAn = :BacSyLamBenhAn
                        WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnLuuCapCuu.LyDoVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("VaoNgayThu", BenhAnLuuCapCuu.VaoNgayThu));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnLuuCapCuu.QuaTrinhBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhBanThan", BenhAnLuuCapCuu.TienSuBenhBanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhGiaDinh", BenhAnLuuCapCuu.TienSuBenhGiaDinh));
            Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnLuuCapCuu.ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("CacBoPhan", BenhAnLuuCapCuu.CacBoPhan));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQuaCanLamSang", BenhAnLuuCapCuu.TomTatKetQuaCanLamSang));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanBanDau", BenhAnLuuCapCuu.ChanDoanBanDau));
            Command.Parameters.Add(new MDB.MDBParameter("DaXuLy", BenhAnLuuCapCuu.DaXuLy));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanKhiRaVien", BenhAnLuuCapCuu.ChanDoanKhiRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("RaVienLuc", BenhAnLuuCapCuu.RaVienLuc));
            Command.Parameters.Add(new MDB.MDBParameter("KeToa", BenhAnLuuCapCuu.KeToa ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("Khoi", BenhAnLuuCapCuu.Khoi ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("TronVien", BenhAnLuuCapCuu.TronVien ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("ThongTinYLenhs", JsonConvert.SerializeObject(BenhAnLuuCapCuu.ThongTinYLenhs)));
            Command.Parameters.Add(new MDB.MDBParameter("MAIDC_ChanDoanKhiRaVien", BenhAnLuuCapCuu.MAIDC_ChanDoanKhiRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyLamBenhAn", BenhAnLuuCapCuu.BacSyLamBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnLuuCapCuu.MaQuanLy));
            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool Delete(MDB.MDBConnection MyConnection, BenhAnLuuCapCuu BenhAnLuuCapCuu)
        {
            string sql = @"DELETE FROM BenhAnLuuCapCuu 
                           WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnLuuCapCuu.MaQuanLy));

            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
    }
}
