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
    public class BenhAnNgoaiTru_VayPhanDoNangLongFunc
    {
        public static void WriteXml(MDB.MDBConnection MyConnection)
        {
            string sql =
                   @"
                  select  a.*,  CTScanner HoSo_CTScanner, SieuAm HoSo_SieuAm, XetNghiem HoSo_XetNghiem,  Khac HoSo_Khac,  Khac_Text HoSo_Khac_Text,  ToanBoHoSo HoSo_ToanBoHoSo, Mach DauSinhTon_Mach,  NhietDo DauSinhTon_NhietDo,  HuyetAp DauSinhTon_HuyetAp,  NhipTho DauSinhTon_NhipTho,  CanNang DauSinhTon_CanNang  
                  from BenhAnVayPhanDoNangLong a inner join thongtindieutri b on a.maquanly = b.maquanly
                  where rownum = 1
                    ";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            var DataTable = new DataTable { TableName = "BenhAnVayPhanDoNangLong" };
            DataTable.Load(DataReader as IDataReader);
            DataTable.WriteXml("rptBenhAnVayPhanDoNangLong.xml");
        }
        public static DataSet SelectDataSet(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql =
                   @"
                  select  a.*, f.hovaten BacSyDieuTriHoVaTen, g.hovaten TK_BacSyDieuTriHoVaTen, d.hovaten NguoiGiaoHoSoHoVaTen,e.hovaten NguoiNhanHoSoHoVaTen, b.XQuang HoSo_XQuang, b.CTScanner HoSo_CTScanner, b.SieuAm HoSo_SieuAm, b.XetNghiem HoSo_XetNghiem,  b.Khac HoSo_Khac,  b.Khac_Text HoSo_Khac_Text,  b.ToanBoHoSo HoSo_ToanBoHoSo
                        from BenhAnVayPhanDoNangLong a  
                  left join thongtindieutri b on a.maquanly = b.maquanly 
                  left join nhanvien f on a.BacSiDieuTri = f.manhanvien
                  left join nhanvien g on a.TK_BacSiDieuTri = g.manhanvien
                  left join nhanvien d on a.NguoiGiaoHoSo = d.manhanvien
                  left join nhanvien e on a.NguoiNhanHoSo = e.manhanvien where a.maquanly = " + MaQuanLy.ToString(System.Globalization.CultureInfo.InvariantCulture);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(sql, MyConnection);
            var ds = new DataSet();
            adt.Fill(ds, "Table");
            return ds;
        }
        public static BenhAnNgoaiTru_VayPhanDoNangLong Select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            var obj = new BenhAnNgoaiTru_VayPhanDoNangLong();
            try
            {
                #region
                string sql =
                          @"select * 
                        from BenhAnVayPhanDoNangLong 
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
                    obj.ThoiGianKhoiPhatBenh = DataReader["ThoiGianKhoiPhatBenh"].ToString();
                    obj.TrieuChungDauTien = DataReader["TrieuChungDauTien"].ToString();
                    obj.ThoiGianBiDayDa = DataReader["ThoiGianBiDayDa"].ToString();
                    obj.QuaTrinhBenhLy = DataReader["QuaTrinhBenhLy"].ToString();
                    obj.DieuTriTruocDay = DataReader["DieuTriTruocDay"].ToString();
                    obj.TSBT_DiUngThuoc = DataReader["TSBT_DiUngThuoc"].ToString();
                    obj.TSBT_BenhKhac = DataReader["TSBT_BenhKhac"].ToString();
                    obj.TSGD_Khac = DataReader["TSGD_Khac"].ToString();
                    obj.TSGD_DiUngThuoc = DataReader["TSGD_DiUngThuoc"].ToString();
                    obj.ToanThan = DataReader["ToanThan"].ToString();
                    obj.CacBoPhan = DataReader["CacBoPhan"].ToString();
                    obj.Khop = DataReader["Khop"].ToString();
                    obj.TieuHoa = DataReader["TieuHoa"].ToString();
                    obj.PhoiVaMachMauOPhoi = DataReader["PhoiVaMachMauOPhoi"].ToString();
                    obj.Co = DataReader["Co"].ToString();
                    obj.TimMach = DataReader["TimMach"].ToString();
                    obj.Than = DataReader["Than"].ToString();
                    obj.CacBoPhanKhac = DataReader["CacBoPhanKhac"].ToString();
                    obj.DiemDanhGia = DataReader["DiemDanhGia"].ToString();
                    obj.TrieuChungCoNang = DataReader["TrieuChungCoNang"].ToString();
                    obj.TrieuChungCoNang_Khac = DataReader["TrieuChungCoNang_Khac"].ToString();
                    obj.SanNangLong_ViTri = DataReader["SanNangLong_ViTri"].ToString();
                    obj.SanNangLong_ViTri_Khac = DataReader["SanNangLong_ViTri_Khac"].ToString();
                    obj.SanNangLong_KichThuoc = DataReader["SanNangLong_KichThuoc"].ToString();
                    obj.SanNangLong_KeuTapTrung = DataReader["SanNangLong_KeuTapTrung"].ToString();
                    obj.VayDa = DataReader["VayDa"].ToString();
                    obj.VayDa_Khac = DataReader["VayDa_Khac"].ToString();
                    obj.DoDa = DataReader["DoDa"].ToString();
                    obj.LichenHoa = DataReader.GetInt("LichenHoa");
                    obj.DoDaLanh = DataReader.GetInt("DoDaLanh");
                    obj.RungToc = DataReader.GetInt("RungToc");
                    obj.DaySung_ViTri = DataReader["DaySung_ViTri"].ToString();
                    obj.DaySung = DataReader["DaySung"].ToString();
                    obj.ThuongTonMong = DataReader["ThuongTonMong"].ToString();
                    obj.ChanDoanVaPhanThe = DataReader["ChanDoanVaPhanThe"].ToString();
                    obj.DieuTri = DataReader["DieuTri"].ToString();
                    obj.HenTaiKham = DataReader["HenTaiKham"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["HenTaiKham"]) : null;
                    obj.BacSiDieuTri = DataReader["BacSiDieuTri"].ToString();
                    obj.TK_NgayTaiKham = DataReader["TK_NgayTaiKham"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["TK_NgayTaiKham"]) : null;
                    obj.TK_HoTen = DataReader["TK_HoTen"].ToString();
                    obj.TK_SoBenhAn = DataReader["TK_SoBenhAn"].ToString();
                    obj.TK_SoLuuTru = DataReader["TK_SoLuuTru"].ToString();
                    obj.TK_Mach = DataReader["TK_Mach"].ToString();
                    obj.TK_HA = DataReader["TK_HA"].ToString();
                    obj.TK_NhietDo = DataReader["TK_NhietDo"].ToString();
                    obj.TK_BNTuDanhGia = DataReader["TK_BNTuDanhGia"].ToString();
                    obj.TK_BNTuDanhGia_ChuY = DataReader["TK_BNTuDanhGia_ChuY"].ToString();
                    obj.TK_LamSangDa = DataReader["TK_LamSangDa"].ToString();
                    obj.TK_Khop = DataReader["TK_Khop"].ToString();
                    obj.TK_Than = DataReader["TK_Than"].ToString();
                    obj.TK_TieuHoa = DataReader["TK_TieuHoa"].ToString();
                    obj.TK_Phoi = DataReader["TK_Phoi"].ToString();
                    obj.TK_Co = DataReader["TK_Co"].ToString();
                    obj.TK_Tim = DataReader["TK_Tim"].ToString();
                    obj.TK_LamSangNoiTang_Khac = DataReader["TK_LamSangNoiTang_Khac"].ToString();
                    obj.TK_HAQ = DataReader["TK_HAQ"].ToString();
                    obj.TK_TDPCuaThuoc = DataReader["TK_TDPCuaThuoc"].ToString();
                    obj.TK_HuongDieuTriTiepTheo = DataReader["TK_HuongDieuTriTiepTheo"].ToString();
                    obj.TK_HenTaiKham = DataReader["TK_HenTaiKham"] != DBNull.Value ? (DateTime?) Convert.ToDateTime(DataReader["TK_HenTaiKham"]) : null;
                    obj.TK_BacSiDieuTri = DataReader["TK_BacSiDieuTri"].ToString();

                    // phần tổng kết
                    obj.TongKet_QuaTrinhBenhLy = DataReader["TongKet_QuaTrinhBenhLy"].ToString();
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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, BenhAnNgoaiTru_VayPhanDoNangLong BenhAnNgoaiTru_VayPhanDoNangLong)
        {
            try
            {
                string sql =
                          @"select MaQuanLy 
                            from BenhAnVayPhanDoNangLong
                            where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnNgoaiTru_VayPhanDoNangLong.MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                int rowCount = 0;
                while (DataReader.Read()) rowCount++;
                if (rowCount == 1) return Update(MyConnection, BenhAnNgoaiTru_VayPhanDoNangLong);
                sql = @"
                       INSERT INTO BenhAnVayPhanDoNangLong 
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
                            ThoiGianKhoiPhatBenh,
                            TrieuChungDauTien,
                            ThoiGianBiDayDa,
                            QuaTrinhBenhLy,
                            DieuTriTruocDay,
                            TSBT_DiUngThuoc,
                            TSBT_BenhKhac,
                            TSGD_Khac,
                            TSGD_DiUngThuoc,
                            ToanThan,
                            CacBoPhan,
                            Khop,
                            TieuHoa,
                            PhoiVaMachMauOPhoi,
                            Co,
                            TimMach,
                            Than,
                            CacBoPhanKhac,
                            DiemDanhGia,
                            TrieuChungCoNang,
                            TrieuChungCoNang_Khac,
                            SanNangLong_ViTri,
                            SanNangLong_ViTri_Khac,
                            SanNangLong_KichThuoc,
                            SanNangLong_KeuTapTrung,
                            VayDa,
                            VayDa_Khac,
                            DoDa,
                            LichenHoa,
                            DoDaLanh,
                            RungToc,
                            DaySung_ViTri,
                            DaySung,
                            ThuongTonMong,
                            ChanDoanVaPhanThe,
                            DieuTri,
                            HenTaiKham,
                            BacSiDieuTri,
                            TK_NgayTaiKham,
                            TK_HoTen,
                            TK_SoBenhAn,
                            TK_SoLuuTru,
                            TK_Mach,
                            TK_HA,
                            TK_NhietDo,
                            TK_BNTuDanhGia,
                            TK_BNTuDanhGia_ChuY,
                            TK_LamSangDa,
                            TK_Khop,
                            TK_Than,
                            TK_TieuHoa,
                            TK_Phoi,
                            TK_Co,
                            TK_Tim,
                            TK_LamSangNoiTang_Khac,
                            TK_HAQ,
                            TK_TDPCuaThuoc,
                            TK_HuongDieuTriTiepTheo,
                            TK_HenTaiKham,
                            TK_BacSiDieuTri,
                            TongKet_QuaTrinhBenhLy,
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
                            :ThoiGianKhoiPhatBenh,
                            :TrieuChungDauTien,
                            :ThoiGianBiDayDa,
                            :QuaTrinhBenhLy,
                            :DieuTriTruocDay,
                            :TSBT_DiUngThuoc,
                            :TSBT_BenhKhac,
                            :TSGD_Khac,
                            :TSGD_DiUngThuoc,
                            :ToanThan,
                            :CacBoPhan,
                            :Khop,
                            :TieuHoa,
                            :PhoiVaMachMauOPhoi,
                            :Co,
                            :TimMach,
                            :Than,
                            :CacBoPhanKhac,
                            :DiemDanhGia,
                            :TrieuChungCoNang,
                            :TrieuChungCoNang_Khac,
                            :SanNangLong_ViTri,
                            :SanNangLong_ViTri_Khac,
                            :SanNangLong_KichThuoc,
                            :SanNangLong_KeuTapTrung,
                            :VayDa,
                            :VayDa_Khac,
                            :DoDa,
                            :LichenHoa,
                            :DoDaLanh,
                            :RungToc,
                            :DaySung_ViTri,
                            :DaySung,
                            :ThuongTonMong,
                            :ChanDoanVaPhanThe,
                            :DieuTri,
                            :HenTaiKham,
                            :BacSiDieuTri,
                            :TK_NgayTaiKham,
                            :TK_HoTen,
                            :TK_SoBenhAn,
                            :TK_SoLuuTru,
                            :TK_Mach,
                            :TK_HA,
                            :TK_NhietDo,
                            :TK_BNTuDanhGia,
                            :TK_BNTuDanhGia_ChuY,
                            :TK_LamSangDa,
                            :TK_Khop,
                            :TK_Than,
                            :TK_TieuHoa,
                            :TK_Phoi,
                            :TK_Co,
                            :TK_Tim,
                            :TK_LamSangNoiTang_Khac,
                            :TK_HAQ,
                            :TK_TDPCuaThuoc,
                            :TK_HuongDieuTriTiepTheo,
                            :TK_HenTaiKham,
                            :TK_BacSiDieuTri,
                            :TongKet_QuaTrinhBenhLy,
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
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnNgoaiTru_VayPhanDoNangLong.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriNgoaiTruTu", BenhAnNgoaiTru_VayPhanDoNangLong.DieuTriNgoaiTruTu));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriNgoaiTruDen", BenhAnNgoaiTru_VayPhanDoNangLong.DieuTriNgoaiTruDen));
                Command.Parameters.Add(new MDB.MDBParameter("SoCMND", BenhAnNgoaiTru_VayPhanDoNangLong.SoCMND));
                Command.Parameters.Add(new MDB.MDBParameter("BaoHiem", BenhAnNgoaiTru_VayPhanDoNangLong.BaoHiem));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan_TuyenTruoc", BenhAnNgoaiTru_VayPhanDoNangLong.ChanDoan_TuyenTruoc));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanBanDau", BenhAnNgoaiTru_VayPhanDoNangLong.ChanDoanBanDau));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham1", BenhAnNgoaiTru_VayPhanDoNangLong.ChanDoanTaiKham1));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham2", BenhAnNgoaiTru_VayPhanDoNangLong.ChanDoanTaiKham2));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham3", BenhAnNgoaiTru_VayPhanDoNangLong.ChanDoanTaiKham3));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham4", BenhAnNgoaiTru_VayPhanDoNangLong.ChanDoanTaiKham4));
                Command.Parameters.Add(new MDB.MDBParameter("BenhPhu", BenhAnNgoaiTru_VayPhanDoNangLong.BenhPhu));
                Command.Parameters.Add(new MDB.MDBParameter("KetQuaDieuTri", BenhAnNgoaiTru_VayPhanDoNangLong.KetQuaDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("BienChung_Text", BenhAnNgoaiTru_VayPhanDoNangLong.BienChung_Text));
                Command.Parameters.Add(new MDB.MDBParameter("GDPhongKeHoach", BenhAnNgoaiTru_VayPhanDoNangLong.GDPhongKeHoach));
                Command.Parameters.Add(new MDB.MDBParameter("GDPhongKhamBenh", BenhAnNgoaiTru_VayPhanDoNangLong.GDPhongKhamBenh));

                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianKhoiPhatBenh", BenhAnNgoaiTru_VayPhanDoNangLong.ThoiGianKhoiPhatBenh));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungDauTien", BenhAnNgoaiTru_VayPhanDoNangLong.TrieuChungDauTien));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianBiDayDa", BenhAnNgoaiTru_VayPhanDoNangLong.ThoiGianBiDayDa));
                Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnNgoaiTru_VayPhanDoNangLong.QuaTrinhBenhLy));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriTruocDay", BenhAnNgoaiTru_VayPhanDoNangLong.DieuTriTruocDay));
                Command.Parameters.Add(new MDB.MDBParameter("TSBT_DiUngThuoc", BenhAnNgoaiTru_VayPhanDoNangLong.TSBT_DiUngThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("TSBT_BenhKhac", BenhAnNgoaiTru_VayPhanDoNangLong.TSBT_BenhKhac));
                Command.Parameters.Add(new MDB.MDBParameter("TSGD_Khac", BenhAnNgoaiTru_VayPhanDoNangLong.TSGD_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("TSGD_DiUngThuoc", BenhAnNgoaiTru_VayPhanDoNangLong.TSGD_DiUngThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnNgoaiTru_VayPhanDoNangLong.ToanThan));
                Command.Parameters.Add(new MDB.MDBParameter("CacBoPhan", BenhAnNgoaiTru_VayPhanDoNangLong.CacBoPhan));
                Command.Parameters.Add(new MDB.MDBParameter("Khop", BenhAnNgoaiTru_VayPhanDoNangLong.Khop));
                Command.Parameters.Add(new MDB.MDBParameter("TieuHoa", BenhAnNgoaiTru_VayPhanDoNangLong.TieuHoa));
                Command.Parameters.Add(new MDB.MDBParameter("PhoiVaMachMauOPhoi", BenhAnNgoaiTru_VayPhanDoNangLong.PhoiVaMachMauOPhoi));
                Command.Parameters.Add(new MDB.MDBParameter("Co", BenhAnNgoaiTru_VayPhanDoNangLong.Co));
                Command.Parameters.Add(new MDB.MDBParameter("TimMach", BenhAnNgoaiTru_VayPhanDoNangLong.TimMach));
                Command.Parameters.Add(new MDB.MDBParameter("Than", BenhAnNgoaiTru_VayPhanDoNangLong.Than));
                Command.Parameters.Add(new MDB.MDBParameter("CacBoPhanKhac", BenhAnNgoaiTru_VayPhanDoNangLong.CacBoPhanKhac));
                Command.Parameters.Add(new MDB.MDBParameter("DiemDanhGia", BenhAnNgoaiTru_VayPhanDoNangLong.DiemDanhGia));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungCoNang", BenhAnNgoaiTru_VayPhanDoNangLong.TrieuChungCoNang));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungCoNang_Khac", BenhAnNgoaiTru_VayPhanDoNangLong.TrieuChungCoNang_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("SanNangLong_ViTri", BenhAnNgoaiTru_VayPhanDoNangLong.SanNangLong_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("SanNangLong_ViTri_Khac", BenhAnNgoaiTru_VayPhanDoNangLong.SanNangLong_ViTri_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("SanNangLong_KichThuoc", BenhAnNgoaiTru_VayPhanDoNangLong.SanNangLong_KichThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("SanNangLong_KeuTapTrung", BenhAnNgoaiTru_VayPhanDoNangLong.SanNangLong_KeuTapTrung));
                Command.Parameters.Add(new MDB.MDBParameter("VayDa", BenhAnNgoaiTru_VayPhanDoNangLong.VayDa));
                Command.Parameters.Add(new MDB.MDBParameter("VayDa_Khac", BenhAnNgoaiTru_VayPhanDoNangLong.VayDa_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("DoDa", BenhAnNgoaiTru_VayPhanDoNangLong.DoDa));
                Command.Parameters.Add(new MDB.MDBParameter("LichenHoa", BenhAnNgoaiTru_VayPhanDoNangLong.LichenHoa));
                Command.Parameters.Add(new MDB.MDBParameter("DoDaLanh", BenhAnNgoaiTru_VayPhanDoNangLong.DoDaLanh));
                Command.Parameters.Add(new MDB.MDBParameter("RungToc", BenhAnNgoaiTru_VayPhanDoNangLong.RungToc));
                Command.Parameters.Add(new MDB.MDBParameter("DaySung_ViTri", BenhAnNgoaiTru_VayPhanDoNangLong.DaySung_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("DaySung", BenhAnNgoaiTru_VayPhanDoNangLong.DaySung));
                Command.Parameters.Add(new MDB.MDBParameter("ThuongTonMong", BenhAnNgoaiTru_VayPhanDoNangLong.ThuongTonMong));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanVaPhanThe", BenhAnNgoaiTru_VayPhanDoNangLong.ChanDoanVaPhanThe));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri", BenhAnNgoaiTru_VayPhanDoNangLong.DieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("HenTaiKham", BenhAnNgoaiTru_VayPhanDoNangLong.HenTaiKham));
                Command.Parameters.Add(new MDB.MDBParameter("BacSiDieuTri", BenhAnNgoaiTru_VayPhanDoNangLong.BacSiDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_NgayTaiKham", BenhAnNgoaiTru_VayPhanDoNangLong.TK_NgayTaiKham));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HoTen", BenhAnNgoaiTru_VayPhanDoNangLong.TK_HoTen));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SoBenhAn", BenhAnNgoaiTru_VayPhanDoNangLong.TK_SoBenhAn));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SoLuuTru", BenhAnNgoaiTru_VayPhanDoNangLong.TK_SoLuuTru));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Mach", BenhAnNgoaiTru_VayPhanDoNangLong.TK_Mach));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HA", BenhAnNgoaiTru_VayPhanDoNangLong.TK_HA));
                Command.Parameters.Add(new MDB.MDBParameter("TK_NhietDo", BenhAnNgoaiTru_VayPhanDoNangLong.TK_NhietDo));
                Command.Parameters.Add(new MDB.MDBParameter("TK_BNTuDanhGia", BenhAnNgoaiTru_VayPhanDoNangLong.TK_BNTuDanhGia));
                Command.Parameters.Add(new MDB.MDBParameter("TK_BNTuDanhGia_ChuY", BenhAnNgoaiTru_VayPhanDoNangLong.TK_BNTuDanhGia_ChuY));
                Command.Parameters.Add(new MDB.MDBParameter("TK_LamSangDa", BenhAnNgoaiTru_VayPhanDoNangLong.TK_LamSangDa));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Khop", BenhAnNgoaiTru_VayPhanDoNangLong.TK_Khop));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Than", BenhAnNgoaiTru_VayPhanDoNangLong.TK_Than));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TieuHoa", BenhAnNgoaiTru_VayPhanDoNangLong.TK_TieuHoa));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Phoi", BenhAnNgoaiTru_VayPhanDoNangLong.TK_Phoi));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Co", BenhAnNgoaiTru_VayPhanDoNangLong.TK_Co));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Tim", BenhAnNgoaiTru_VayPhanDoNangLong.TK_Tim));
                Command.Parameters.Add(new MDB.MDBParameter("TK_LamSangNoiTang_Khac", BenhAnNgoaiTru_VayPhanDoNangLong.TK_LamSangNoiTang_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HAQ", BenhAnNgoaiTru_VayPhanDoNangLong.TK_HAQ));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TDPCuaThuoc", BenhAnNgoaiTru_VayPhanDoNangLong.TK_TDPCuaThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HuongDieuTriTiepTheo", BenhAnNgoaiTru_VayPhanDoNangLong.TK_HuongDieuTriTiepTheo));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HenTaiKham", BenhAnNgoaiTru_VayPhanDoNangLong.TK_HenTaiKham));
                Command.Parameters.Add(new MDB.MDBParameter("TK_BacSiDieuTri", BenhAnNgoaiTru_VayPhanDoNangLong.TK_BacSiDieuTri));


                Command.Parameters.Add(new MDB.MDBParameter("TongKet_QuaTrinhBenhLy", BenhAnNgoaiTru_VayPhanDoNangLong.TongKet_QuaTrinhBenhLy));
                Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQua", BenhAnNgoaiTru_VayPhanDoNangLong.TomTatKetQua));
                Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnNgoaiTru_VayPhanDoNangLong.BenhChinh));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhChinh", BenhAnNgoaiTru_VayPhanDoNangLong.MaBenhChinh));
                Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnNgoaiTru_VayPhanDoNangLong.BenhKemTheo));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhKemTheo", BenhAnNgoaiTru_VayPhanDoNangLong.MaBenhKemTheo));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnNgoaiTru_VayPhanDoNangLong.PhuongPhapDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangRaVien", BenhAnNgoaiTru_VayPhanDoNangLong.TinhTrangRaVien));
                Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnNgoaiTru_VayPhanDoNangLong.HuongDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnNgoaiTru_VayPhanDoNangLong.NguoiNhanHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnNgoaiTru_VayPhanDoNangLong.NguoiGiaoHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnNgoaiTru_VayPhanDoNangLong.NgayTongKet));
                Command.Parameters.Add(new MDB.MDBParameter("TongKet_BacSyDieuTri", BenhAnNgoaiTru_VayPhanDoNangLong.TongKet_BacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TongKet_MaBacSyDieuTri", BenhAnNgoaiTru_VayPhanDoNangLong.TongKet_MaBacSyDieuTri));

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
        public static bool Update(MDB.MDBConnection MyConnection, BenhAnNgoaiTru_VayPhanDoNangLong BenhAnNgoaiTru_VayPhanDoNangLong)
        {
            try
            {
                string sql = @"UPDATE BenhAnVayPhanDoNangLong SET 
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
                            ThoiGianKhoiPhatBenh=:ThoiGianKhoiPhatBenh,
                            TrieuChungDauTien=:TrieuChungDauTien,
                            ThoiGianBiDayDa=:ThoiGianBiDayDa,
                            QuaTrinhBenhLy=:QuaTrinhBenhLy,
                            DieuTriTruocDay=:DieuTriTruocDay,
                            TSBT_DiUngThuoc=:TSBT_DiUngThuoc,
                            TSBT_BenhKhac=:TSBT_BenhKhac,
                            TSGD_Khac=:TSGD_Khac,
                            TSGD_DiUngThuoc=:TSGD_DiUngThuoc,
                            ToanThan=:ToanThan,
                            CacBoPhan=:CacBoPhan,
                            Khop=:Khop,
                            TieuHoa=:TieuHoa,
                            PhoiVaMachMauOPhoi=:PhoiVaMachMauOPhoi,
                            Co=:Co,
                            TimMach=:TimMach,
                            Than=:Than,
                            CacBoPhanKhac=:CacBoPhanKhac,
                            DiemDanhGia=:DiemDanhGia,
                            TrieuChungCoNang=:TrieuChungCoNang,
                            TrieuChungCoNang_Khac=:TrieuChungCoNang_Khac,
                            SanNangLong_ViTri=:SanNangLong_ViTri,
                            SanNangLong_ViTri_Khac=:SanNangLong_ViTri_Khac,
                            SanNangLong_KichThuoc=:SanNangLong_KichThuoc,
                            SanNangLong_KeuTapTrung=:SanNangLong_KeuTapTrung,
                            VayDa=:VayDa,
                            VayDa_Khac=:VayDa_Khac,
                            DoDa=:DoDa,
                            LichenHoa=:LichenHoa,
                            DoDaLanh=:DoDaLanh,
                            RungToc=:RungToc,
                            DaySung_ViTri=:DaySung_ViTri,
                            DaySung=:DaySung,
                            ThuongTonMong=:ThuongTonMong,
                            ChanDoanVaPhanThe=:ChanDoanVaPhanThe,
                            DieuTri=:DieuTri,
                            HenTaiKham=:HenTaiKham,
                            BacSiDieuTri=:BacSiDieuTri,
                            TK_NgayTaiKham=:TK_NgayTaiKham,
                            TK_HoTen=:TK_HoTen,
                            TK_SoBenhAn=:TK_SoBenhAn,
                            TK_SoLuuTru=:TK_SoLuuTru,
                            TK_Mach=:TK_Mach,
                            TK_HA=:TK_HA,
                            TK_NhietDo=:TK_NhietDo,
                            TK_BNTuDanhGia=:TK_BNTuDanhGia,
                            TK_BNTuDanhGia_ChuY=:TK_BNTuDanhGia_ChuY,
                            TK_LamSangDa=:TK_LamSangDa,
                            TK_Khop=:TK_Khop,
                            TK_Than=:TK_Than,
                            TK_TieuHoa=:TK_TieuHoa,
                            TK_Phoi=:TK_Phoi,
                            TK_Co=:TK_Co,
                            TK_Tim=:TK_Tim,
                            TK_LamSangNoiTang_Khac=:TK_LamSangNoiTang_Khac,
                            TK_HAQ=:TK_HAQ,
                            TK_TDPCuaThuoc=:TK_TDPCuaThuoc,
                            TK_HuongDieuTriTiepTheo=:TK_HuongDieuTriTiepTheo,
                            TK_HenTaiKham=:TK_HenTaiKham,
                            TK_BacSiDieuTri=:TK_BacSiDieuTri,
                            TongKet_QuaTrinhBenhLy=:TongKet_QuaTrinhBenhLy,
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
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriNgoaiTruTu", BenhAnNgoaiTru_VayPhanDoNangLong.DieuTriNgoaiTruTu));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriNgoaiTruDen", BenhAnNgoaiTru_VayPhanDoNangLong.DieuTriNgoaiTruDen));
                Command.Parameters.Add(new MDB.MDBParameter("SoCMND", BenhAnNgoaiTru_VayPhanDoNangLong.SoCMND));
                Command.Parameters.Add(new MDB.MDBParameter("BaoHiem", BenhAnNgoaiTru_VayPhanDoNangLong.BaoHiem));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan_TuyenTruoc", BenhAnNgoaiTru_VayPhanDoNangLong.ChanDoan_TuyenTruoc));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanBanDau", BenhAnNgoaiTru_VayPhanDoNangLong.ChanDoanBanDau));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham1", BenhAnNgoaiTru_VayPhanDoNangLong.ChanDoanTaiKham1));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham2", BenhAnNgoaiTru_VayPhanDoNangLong.ChanDoanTaiKham2));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham3", BenhAnNgoaiTru_VayPhanDoNangLong.ChanDoanTaiKham3));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham4", BenhAnNgoaiTru_VayPhanDoNangLong.ChanDoanTaiKham4));
                Command.Parameters.Add(new MDB.MDBParameter("BenhPhu", BenhAnNgoaiTru_VayPhanDoNangLong.BenhPhu));
                Command.Parameters.Add(new MDB.MDBParameter("KetQuaDieuTri", BenhAnNgoaiTru_VayPhanDoNangLong.KetQuaDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("BienChung_Text", BenhAnNgoaiTru_VayPhanDoNangLong.BienChung_Text));
                Command.Parameters.Add(new MDB.MDBParameter("GDPhongKeHoach", BenhAnNgoaiTru_VayPhanDoNangLong.GDPhongKeHoach));
                Command.Parameters.Add(new MDB.MDBParameter("GDPhongKhamBenh", BenhAnNgoaiTru_VayPhanDoNangLong.GDPhongKhamBenh));

                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianKhoiPhatBenh", BenhAnNgoaiTru_VayPhanDoNangLong.ThoiGianKhoiPhatBenh));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungDauTien", BenhAnNgoaiTru_VayPhanDoNangLong.TrieuChungDauTien));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianBiDayDa", BenhAnNgoaiTru_VayPhanDoNangLong.ThoiGianBiDayDa));
                Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnNgoaiTru_VayPhanDoNangLong.QuaTrinhBenhLy));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriTruocDay", BenhAnNgoaiTru_VayPhanDoNangLong.DieuTriTruocDay));
                Command.Parameters.Add(new MDB.MDBParameter("TSBT_DiUngThuoc", BenhAnNgoaiTru_VayPhanDoNangLong.TSBT_DiUngThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("TSBT_BenhKhac", BenhAnNgoaiTru_VayPhanDoNangLong.TSBT_BenhKhac));
                Command.Parameters.Add(new MDB.MDBParameter("TSGD_Khac", BenhAnNgoaiTru_VayPhanDoNangLong.TSGD_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("TSGD_DiUngThuoc", BenhAnNgoaiTru_VayPhanDoNangLong.TSGD_DiUngThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnNgoaiTru_VayPhanDoNangLong.ToanThan));
                Command.Parameters.Add(new MDB.MDBParameter("CacBoPhan", BenhAnNgoaiTru_VayPhanDoNangLong.CacBoPhan));
                Command.Parameters.Add(new MDB.MDBParameter("Khop", BenhAnNgoaiTru_VayPhanDoNangLong.Khop));
                Command.Parameters.Add(new MDB.MDBParameter("TieuHoa", BenhAnNgoaiTru_VayPhanDoNangLong.TieuHoa));
                Command.Parameters.Add(new MDB.MDBParameter("PhoiVaMachMauOPhoi", BenhAnNgoaiTru_VayPhanDoNangLong.PhoiVaMachMauOPhoi));
                Command.Parameters.Add(new MDB.MDBParameter("Co", BenhAnNgoaiTru_VayPhanDoNangLong.Co));
                Command.Parameters.Add(new MDB.MDBParameter("TimMach", BenhAnNgoaiTru_VayPhanDoNangLong.TimMach));
                Command.Parameters.Add(new MDB.MDBParameter("Than", BenhAnNgoaiTru_VayPhanDoNangLong.Than));
                Command.Parameters.Add(new MDB.MDBParameter("CacBoPhanKhac", BenhAnNgoaiTru_VayPhanDoNangLong.CacBoPhanKhac));
                Command.Parameters.Add(new MDB.MDBParameter("DiemDanhGia", BenhAnNgoaiTru_VayPhanDoNangLong.DiemDanhGia));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungCoNang", BenhAnNgoaiTru_VayPhanDoNangLong.TrieuChungCoNang));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungCoNang_Khac", BenhAnNgoaiTru_VayPhanDoNangLong.TrieuChungCoNang_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("SanNangLong_ViTri", BenhAnNgoaiTru_VayPhanDoNangLong.SanNangLong_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("SanNangLong_ViTri_Khac", BenhAnNgoaiTru_VayPhanDoNangLong.SanNangLong_ViTri_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("SanNangLong_KichThuoc", BenhAnNgoaiTru_VayPhanDoNangLong.SanNangLong_KichThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("SanNangLong_KeuTapTrung", BenhAnNgoaiTru_VayPhanDoNangLong.SanNangLong_KeuTapTrung));
                Command.Parameters.Add(new MDB.MDBParameter("VayDa", BenhAnNgoaiTru_VayPhanDoNangLong.VayDa));
                Command.Parameters.Add(new MDB.MDBParameter("VayDa_Khac", BenhAnNgoaiTru_VayPhanDoNangLong.VayDa_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("DoDa", BenhAnNgoaiTru_VayPhanDoNangLong.DoDa));
                Command.Parameters.Add(new MDB.MDBParameter("LichenHoa", BenhAnNgoaiTru_VayPhanDoNangLong.LichenHoa));
                Command.Parameters.Add(new MDB.MDBParameter("DoDaLanh", BenhAnNgoaiTru_VayPhanDoNangLong.DoDaLanh));
                Command.Parameters.Add(new MDB.MDBParameter("RungToc", BenhAnNgoaiTru_VayPhanDoNangLong.RungToc));
                Command.Parameters.Add(new MDB.MDBParameter("DaySung_ViTri", BenhAnNgoaiTru_VayPhanDoNangLong.DaySung_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("DaySung", BenhAnNgoaiTru_VayPhanDoNangLong.DaySung));
                Command.Parameters.Add(new MDB.MDBParameter("ThuongTonMong", BenhAnNgoaiTru_VayPhanDoNangLong.ThuongTonMong));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanVaPhanThe", BenhAnNgoaiTru_VayPhanDoNangLong.ChanDoanVaPhanThe));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri", BenhAnNgoaiTru_VayPhanDoNangLong.DieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("HenTaiKham", BenhAnNgoaiTru_VayPhanDoNangLong.HenTaiKham));
                Command.Parameters.Add(new MDB.MDBParameter("BacSiDieuTri", BenhAnNgoaiTru_VayPhanDoNangLong.BacSiDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_NgayTaiKham", BenhAnNgoaiTru_VayPhanDoNangLong.TK_NgayTaiKham));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HoTen", BenhAnNgoaiTru_VayPhanDoNangLong.TK_HoTen));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SoBenhAn", BenhAnNgoaiTru_VayPhanDoNangLong.TK_SoBenhAn));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SoLuuTru", BenhAnNgoaiTru_VayPhanDoNangLong.TK_SoLuuTru));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Mach", BenhAnNgoaiTru_VayPhanDoNangLong.TK_Mach));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HA", BenhAnNgoaiTru_VayPhanDoNangLong.TK_HA));
                Command.Parameters.Add(new MDB.MDBParameter("TK_NhietDo", BenhAnNgoaiTru_VayPhanDoNangLong.TK_NhietDo));
                Command.Parameters.Add(new MDB.MDBParameter("TK_BNTuDanhGia", BenhAnNgoaiTru_VayPhanDoNangLong.TK_BNTuDanhGia));
                Command.Parameters.Add(new MDB.MDBParameter("TK_BNTuDanhGia_ChuY", BenhAnNgoaiTru_VayPhanDoNangLong.TK_BNTuDanhGia_ChuY));
                Command.Parameters.Add(new MDB.MDBParameter("TK_LamSangDa", BenhAnNgoaiTru_VayPhanDoNangLong.TK_LamSangDa));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Khop", BenhAnNgoaiTru_VayPhanDoNangLong.TK_Khop));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Than", BenhAnNgoaiTru_VayPhanDoNangLong.TK_Than));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TieuHoa", BenhAnNgoaiTru_VayPhanDoNangLong.TK_TieuHoa));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Phoi", BenhAnNgoaiTru_VayPhanDoNangLong.TK_Phoi));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Co", BenhAnNgoaiTru_VayPhanDoNangLong.TK_Co));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Tim", BenhAnNgoaiTru_VayPhanDoNangLong.TK_Tim));
                Command.Parameters.Add(new MDB.MDBParameter("TK_LamSangNoiTang_Khac", BenhAnNgoaiTru_VayPhanDoNangLong.TK_LamSangNoiTang_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HAQ", BenhAnNgoaiTru_VayPhanDoNangLong.TK_HAQ));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TDPCuaThuoc", BenhAnNgoaiTru_VayPhanDoNangLong.TK_TDPCuaThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HuongDieuTriTiepTheo", BenhAnNgoaiTru_VayPhanDoNangLong.TK_HuongDieuTriTiepTheo));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HenTaiKham", BenhAnNgoaiTru_VayPhanDoNangLong.TK_HenTaiKham));
                Command.Parameters.Add(new MDB.MDBParameter("TK_BacSiDieuTri", BenhAnNgoaiTru_VayPhanDoNangLong.TK_BacSiDieuTri));

                Command.Parameters.Add(new MDB.MDBParameter("TongKet_QuaTrinhBenhLy", BenhAnNgoaiTru_VayPhanDoNangLong.TongKet_QuaTrinhBenhLy));
                Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQua", BenhAnNgoaiTru_VayPhanDoNangLong.TomTatKetQua));
                Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnNgoaiTru_VayPhanDoNangLong.BenhChinh));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhChinh", BenhAnNgoaiTru_VayPhanDoNangLong.MaBenhChinh));
                Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnNgoaiTru_VayPhanDoNangLong.BenhKemTheo));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhKemTheo", BenhAnNgoaiTru_VayPhanDoNangLong.MaBenhKemTheo));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnNgoaiTru_VayPhanDoNangLong.PhuongPhapDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangRaVien", BenhAnNgoaiTru_VayPhanDoNangLong.TinhTrangRaVien));
                Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnNgoaiTru_VayPhanDoNangLong.HuongDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnNgoaiTru_VayPhanDoNangLong.NguoiNhanHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnNgoaiTru_VayPhanDoNangLong.NguoiGiaoHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnNgoaiTru_VayPhanDoNangLong.NgayTongKet));
                Command.Parameters.Add(new MDB.MDBParameter("TongKet_BacSyDieuTri", BenhAnNgoaiTru_VayPhanDoNangLong.TongKet_BacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TongKet_MaBacSyDieuTri", BenhAnNgoaiTru_VayPhanDoNangLong.TongKet_MaBacSyDieuTri));

                Command.BindByName = true;

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnNgoaiTru_VayPhanDoNangLong.MaQuanLy));
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
