using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using EMR_MAIN.DATABASE.BenhAn;

namespace EMR_MAIN.DATABASE.BenhAnFunc
{
    public class BenhAnNgoaiTruPHCNFunc
    {
        public static void WriteXml(MDB.MDBConnection MyConnection)
        {
            string sql =
                   @"
                  select  a.*,  CTScanner HoSo_CTScanner, SieuAm HoSo_SieuAm, XetNghiem HoSo_XetNghiem,  Khac HoSo_Khac,  Khac_Text HoSo_Khac_Text,  ToanBoHoSo HoSo_ToanBoHoSo, Mach DauSinhTon_Mach,  NhietDo DauSinhTon_NhietDo,  HuyetAp DauSinhTon_HuyetAp,  NhipTho DauSinhTon_NhipTho,  CanNang DauSinhTon_CanNang  
                  from BenhAnNgoaiTruPHCN a inner join thongtindieutri b on a.maquanly = b.maquanly
                  where rownum = 1
                    ";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            var DataTable = new DataTable { TableName = "BenhAnNgoaiTruPHCN" };
            DataTable.Load(DataReader as IDataReader);
            DataTable.WriteXml("BenhAnNgoaiTruPHCN.xml");
        }
        public static DataSet SelectDataSet(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql =
                   @"
                  select  a.*, g.hovaten GiamDocBenhVienHoVaTen, f.hovaten BacSyLamBenhAnHoVaTen ,c.hovaten BacSyDieuTriHoVaTen,d.hovaten NguoiGiaoHoSoHoVaTen,e.hovaten NguoiNhanHoSoHoVaTen, b.XQuang HoSo_XQuang,   b.CTScanner HoSo_CTScanner, b.SieuAm HoSo_SieuAm, b.XetNghiem HoSo_XetNghiem,  b.Khac HoSo_Khac,  b.Khac_Text HoSo_Khac_Text,  b.ToanBoHoSo HoSo_ToanBoHoSo, b.Mach DauSinhTon_Mach, b.NhietDo DauSinhTon_NhietDo,  b.HuyetAp DauSinhTon_HuyetAp,  b.NhipTho DauSinhTon_NhipTho,  b.CanNang DauSinhTon_CanNang  , b.ChieuCao DauSinhTon_ChieuCao, b.BMI DauSinhTon_BMI, b.NgayRaVien 
                  from BenhAnNgoaiTruPHCN a 
                  left join thongtindieutri b on a.maquanly = b.maquanly 
                  left join nhanvien c on a.bacsydieutri = c.manhanvien
                  left join nhanvien d on a.nguoigiaohoso = d.manhanvien
                  left join nhanvien e on a.nguoinhanhoso = e.manhanvien
                  left join nhanvien f on a.BacSyLamBenhAn = f.manhanvien
                  left join nhanvien g on a.IDGiamDoc = g.manhanvien
                  where a.maquanly = " + MaQuanLy.ToString(System.Globalization.CultureInfo.InvariantCulture);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(sql, MyConnection);
            var ds = new DataSet();
            adt.Fill(ds, "Table");


            string sql2 =
                @"   select a.*,c.hovaten BacSyPhauThuatHoVaTen, d.hovaten BacSyGayMeHoVaTen
                  from PhauThuatThuThuat a
                  left join nhanvien c on a.bacsyphauthuat  = c.manhanvien
                  left join nhanvien d on a.bacsygayme= d.manhanvien
                  where a.maquanly = " + MaQuanLy.ToString(System.Globalization.CultureInfo.InvariantCulture);
            adt = new MDB.MDBDataAdapter(sql2, MyConnection);
            adt.Fill(ds, "Table2");
            return ds;
        }
        public static BenhAnNgoaiTruPHCN Select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            #region
            string sql =
                      @"select * 
                        from BenhAnNgoaiTruPHCN a
                        where MaQuanLy = :MaQuanLy";
            #endregion
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            var value = new BenhAnNgoaiTruPHCN();
            value.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
            while (DataReader.Read())
            {
                value.MaQuanLy = DataReader.GetDecimal("MaQuanLy");
                value.LyDoVaoVien = DataReader["LyDoVaoVien"].ToString();
                value.VaoNgayThu = DataReader.GetInt("VaoNgayThu");
                value.QuaTrinhBenhLy = DataReader["QuaTrinhBenhLy"].ToString();
                value.TienSuBenhBanThan = DataReader["TienSuBenhBanThan"].ToString();
                value.TienSuBenhGiaDinh = DataReader["TienSuBenhGiaDinh"].ToString();
                value.ToanThan = DataReader["ToanThan"].ToString();
                value.TuanHoan = DataReader["TuanHoan"].ToString();
                value.HoHap = DataReader["HoHap"].ToString();
                value.TieuHoa = DataReader["TieuHoa"].ToString();
                value.ThanTietNieuSinhDuc = DataReader["ThanTietNieuSinhDuc"].ToString();
                value.ThanKinh = DataReader["ThanKinh"].ToString();
                value.CoXuongKhop = DataReader["CoXuongKhop"].ToString();
                value.TaiMuiHong = DataReader["TaiMuiHong"].ToString();
                value.RangHamMat = DataReader["RangHamMat"].ToString();
                value.Mat = DataReader["Mat"].ToString();
                value.Khac_CacCoQuan = DataReader["Khac_CacCoQuan"].ToString();
                value.CacXetNghiemCanLamSangCanLam = DataReader["CacXetNghiemCanLamSangCanLam"].ToString();
                value.TomTatBenhAn = DataReader["TomTatBenhAn"].ToString();
                value.BenhChinh = DataReader["BenhChinh"].ToString();
                value.BenhKemTheo = DataReader["BenhKemTheo"].ToString();
                value.PhanBiet = DataReader["PhanBiet"].ToString();
                value.TienLuong = DataReader["TienLuong"].ToString();
                value.HuongDieuTri = DataReader["HuongDieuTri"].ToString();
                value.NgayKhamBenh = DataReader.GetDate("NgayKhamBenh");
                value.BacSyLamBenhAn = DataReader["BacSyLamBenhAn"].ToString();
                value.QuaTrinhBenhLyVaDienBien = DataReader["QuaTrinhBenhLyVaDienBien"].ToString();
                value.TomTatKetQuaXetNghiem = DataReader["TomTatKetQuaXetNghiem"].ToString();
                value.PhuongPhapDieuTri = DataReader["PhuongPhapDieuTri"].ToString();
                value.TinhTrangNguoiBenhRaVien = DataReader["TinhTrangNguoiBenhRaVien"].ToString();
                value.HuongDieuTriVaCacCheDoTiepTheo = DataReader["HuongDieuTriVaCacCheDoTiepTheo"].ToString();
                value.NguoiNhanHoSo = DataReader["NguoiNhanHoSo"].ToString();
                value.NguoiGiaoHoSo = DataReader["NguoiGiaoHoSo"].ToString();
                value.NgayTongKet = DataReader.GetDate("NgayTongKet");
                value.BacSyDieuTri = DataReader["BacSyDieuTri"].ToString();
                value.DacDiemLienQuanBenh.DiUng = DataReader["DiUng"].ToString() == "1" ? true : false;
                value.DacDiemLienQuanBenh.DiUng_Text = DataReader["DiUng_Text"].ToString();
                value.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh = DataReader["Khac_DacDiemLienQuanBenh"].ToString() == "1" ? true : false;
                value.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh_Text = DataReader["Khac_DacDiemLienQuanBenh_Text"].ToString();
                value.DacDiemLienQuanBenh.MaTuy = DataReader["MaTuy"].ToString() == "1" ? true : false;
                value.DacDiemLienQuanBenh.MaTuy_Text = DataReader["MaTuy_Text"].ToString();
                value.DacDiemLienQuanBenh.RuouBia = DataReader["RuouBia"].ToString() == "1" ? true : false;
                value.DacDiemLienQuanBenh.RuouBia_Text = DataReader["RuouBia_Text"].ToString();
                value.DacDiemLienQuanBenh.ThuocLa = DataReader["ThuocLa"].ToString() == "1" ? true : false;
                value.DacDiemLienQuanBenh.ThuocLa_Text = DataReader["ThuocLa_Text"].ToString();
                value.DacDiemLienQuanBenh.ThuocLao = DataReader["ThuocLao"].ToString() == "1" ? true : false;
                value.DacDiemLienQuanBenh.ThuocLao_Text = DataReader["ThuocLao_Text"].ToString();
                value.TenKhoa = DataReader["TenKhoa"].ToString();
                value.CacBoPhan = DataReader["CacBoPhan"].ToString();
                value.TomTatKetQuaCanLamSang = DataReader["TomTatKetQuaCanLamSang"].ToString();
                value.ChanDoanBanDau = DataReader["ChanDoanBanDau"].ToString();
                value.DaXuLy = DataReader["DaXuLy"].ToString();
                value.ChanDoanKhiRaVien = DataReader["ChanDoanKhiRaVien"].ToString();
                value.DieuTriNgoaiTru_TuNgay = DataReader.GetDate("DieuTriNgoaiTru_TuNgay");
                value.DieuTriNgoaiTru_DenNgay = DataReader.GetDate("DieuTriNgoaiTru_DenNgay");
                value.IDGiamDoc = DataReader["IDGiamDoc"].ToString() ;
                value.MaICD_BenhChinh = DataReader["MaICD_BenhChinh"].ToString();
                value.MaICD_BenhKemTheo = DataReader["MaICD_BenhKemTheo"].ToString();
                value.MAIDC_ChanDoanKhiRaVien = DataReader["MAIDC_ChanDoanKhiRaVien"].ToString();
                value.CNKhuyetTat = DataReader.GetInt("CNKhuyetTat");
                value.DangKhuyetTuat = DataReader["DangKhuyetTuat"].ToString();
                value.MucDoKT = DataReader["MucDoKT"].ToString();
                value.TienSuBenhDiUng = DataReader["TienSuBenhDiUng"].ToString();
                value.MaSoKyTen = DataReader["masokyten"].ToString();
                value.MaSoKyTen_KB = DataReader["masokyten_kb"].ToString();
                value.MaSoKyTen_TK = DataReader["masokyten_tk"].ToString();
            }
            return value;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, BenhAnNgoaiTruPHCN BenhAnNgoaiTruPHCN)
        {
            string sql =
                      @"select MaQuanLy 
                        from BenhAnNgoaiTruPHCN
                        where MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnNgoaiTruPHCN.MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            int rowCount = 0;
            while (DataReader.Read()) rowCount++;
            if (rowCount == 1) return Update(MyConnection, BenhAnNgoaiTruPHCN);
            sql = @"
                   INSERT INTO BenhAnNgoaiTruPHCN (MaQuanLy,
                            LyDoVaoVien,
                            VaoNgayThu,
                            QuaTrinhBenhLy,
                            TienSuBenhBanThan,
                            TienSuBenhGiaDinh,
                            ToanThan,
                            TuanHoan,
                            HoHap,
                            TieuHoa,
                            ThanTietNieuSinhDuc,
                            ThanKinh,
                            CoXuongKhop,
                            TaiMuiHong,
                            RangHamMat,
                            Mat,
                            Khac_CacCoQuan,
                            CacXetNghiemCanLamSangCanLam,
                            TomTatBenhAn,
                            BenhChinh,
                            BenhKemTheo,
                            PhanBiet,
                            TienLuong,
                            HuongDieuTri,
                            NgayKhamBenh,
                            BacSyLamBenhAn,
                            QuaTrinhBenhLyVaDienBien,
                            TomTatKetQuaXetNghiem,
                            PhuongPhapDieuTri,
                            TinhTrangNguoiBenhRaVien,
                            HuongDieuTriVaCacCheDoTiepTheo,
                            NguoiNhanHoSo,
                            NguoiGiaoHoSo,
                            NgayTongKet,
                            BacSyDieuTri,
                            DiUng,
                            DiUng_Text,
                            MaTuy,
                            MaTuy_Text,
                            RuouBia,
                            RuouBia_Text,
                            ThuocLa,
                            ThuocLa_Text,
                            ThuocLao,
                            ThuocLao_Text,
                            Khac_DacDiemLienQuanBenh,
                            Khac_DacDiemLienQuanBenh_Text,
                            TenKhoa,
                            CacBoPhan,
                            TomTatKetQuaCanLamSang,
                            ChanDoanBanDau,
                            DaXuLy,
                            ChanDoanKhiRaVien,
                            DieuTriNgoaiTru_TuNgay,
                            DieuTriNgoaiTru_DenNgay,
                            IDGiamDoc,
                            MaICD_BenhChinh,
                            MaICD_BenhKemTheo,
                            MAIDC_ChanDoanKhiRaVien,
                            CNKhuyetTat,
                            DangKhuyetTuat,
                            MucDoKT,
                            TienSuBenhDiUng)
                                               VALUES(:MaQuanLy,
                            :LyDoVaoVien,
                            :VaoNgayThu,
                            :QuaTrinhBenhLy,
                            :TienSuBenhBanThan,
                            :TienSuBenhGiaDinh,
                            :ToanThan,
                            :TuanHoan,
                            :HoHap,
                            :TieuHoa,
                            :ThanTietNieuSinhDuc,
                            :ThanKinh,
                            :CoXuongKhop,
                            :TaiMuiHong,
                            :RangHamMat,
                            :Mat,
                            :Khac_CacCoQuan,
                            :CacXetNghiemCanLamSangCanLam,
                            :TomTatBenhAn,
                            :BenhChinh,
                            :BenhKemTheo,
                            :PhanBiet,
                            :TienLuong,
                            :HuongDieuTri,
                            :NgayKhamBenh,
                            :BacSyLamBenhAn,
                            :QuaTrinhBenhLyVaDienBien,
                            :TomTatKetQuaXetNghiem,
                            :PhuongPhapDieuTri,
                            :TinhTrangNguoiBenhRaVien,
                            :HuongDieuTriVaCacCheDoTiepTheo,
                            :NguoiNhanHoSo,
                            :NguoiGiaoHoSo,
                            :NgayTongKet,
                            :BacSyDieuTri,
                            :DiUng,
                            :DiUng_Text,
                            :MaTuy,
                            :MaTuy_Text,
                            :RuouBia,
                            :RuouBia_Text,
                            :ThuocLa,
                            :ThuocLa_Text,
                            :ThuocLao,
                            :ThuocLao_Text,
                            :Khac_DacDiemLienQuanBenh,
                            :Khac_DacDiemLienQuanBenh_Text,
                            :TenKhoa,
                            :CacBoPhan,
                            :TomTatKetQuaCanLamSang,
                            :ChanDoanBanDau,
                            :DaXuLy,
                            :ChanDoanKhiRaVien,
                            :DieuTriNgoaiTru_TuNgay,
                            :DieuTriNgoaiTru_DenNgay,
                            :IDGiamDoc,
                            :MaICD_BenhChinh,
                            :MaICD_BenhKemTheo,
                            :MAIDC_ChanDoanKhiRaVien,
                            :CNKhuyetTat,
                            :DangKhuyetTuat,
                            :MucDoKT,
                            :TienSuBenhDiUng)";
            Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnNgoaiTruPHCN.MaQuanLy));
            Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnNgoaiTruPHCN.LyDoVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("VaoNgayThu", BenhAnNgoaiTruPHCN.VaoNgayThu));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnNgoaiTruPHCN.QuaTrinhBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhBanThan", BenhAnNgoaiTruPHCN.TienSuBenhBanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhGiaDinh", BenhAnNgoaiTruPHCN.TienSuBenhGiaDinh));
            Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnNgoaiTruPHCN.ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoan", BenhAnNgoaiTruPHCN.TuanHoan));
            Command.Parameters.Add(new MDB.MDBParameter("HoHap", BenhAnNgoaiTruPHCN.HoHap));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoa", BenhAnNgoaiTruPHCN.TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieuSinhDuc", BenhAnNgoaiTruPHCN.ThanTietNieuSinhDuc));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinh", BenhAnNgoaiTruPHCN.ThanKinh));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop", BenhAnNgoaiTruPHCN.CoXuongKhop));
            Command.Parameters.Add(new MDB.MDBParameter("TaiMuiHong", BenhAnNgoaiTruPHCN.TaiMuiHong));
            Command.Parameters.Add(new MDB.MDBParameter("RangHamMat", BenhAnNgoaiTruPHCN.RangHamMat));
            Command.Parameters.Add(new MDB.MDBParameter("Mat", BenhAnNgoaiTruPHCN.Mat));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_CacCoQuan", BenhAnNgoaiTruPHCN.Khac_CacCoQuan));
            Command.Parameters.Add(new MDB.MDBParameter("CacXetNghiemCanLamSangCanLam", BenhAnNgoaiTruPHCN.CacXetNghiemCanLamSangCanLam));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatBenhAn", BenhAnNgoaiTruPHCN.TomTatBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnNgoaiTruPHCN.BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnNgoaiTruPHCN.BenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("PhanBiet", BenhAnNgoaiTruPHCN.PhanBiet));
            Command.Parameters.Add(new MDB.MDBParameter("TienLuong", BenhAnNgoaiTruPHCN.TienLuong));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnNgoaiTruPHCN.HuongDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("NgayKhamBenh", BenhAnNgoaiTruPHCN.NgayKhamBenh));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyLamBenhAn", BenhAnNgoaiTruPHCN.BacSyLamBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLyVaDienBien", BenhAnNgoaiTruPHCN.QuaTrinhBenhLyVaDienBien));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQuaXetNghiem", BenhAnNgoaiTruPHCN.TomTatKetQuaXetNghiem));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnNgoaiTruPHCN.PhuongPhapDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangNguoiBenhRaVien", BenhAnNgoaiTruPHCN.TinhTrangNguoiBenhRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriVaCacCheDoTiepTheo", BenhAnNgoaiTruPHCN.HuongDieuTriVaCacCheDoTiepTheo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnNgoaiTruPHCN.NguoiNhanHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnNgoaiTruPHCN.NguoiGiaoHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnNgoaiTruPHCN.NgayTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnNgoaiTruPHCN.BacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng", BenhAnNgoaiTruPHCN.DacDiemLienQuanBenh.DiUng == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng_Text", BenhAnNgoaiTruPHCN.DacDiemLienQuanBenh.DiUng_Text));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy", BenhAnNgoaiTruPHCN.DacDiemLienQuanBenh.MaTuy == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy_Text", BenhAnNgoaiTruPHCN.DacDiemLienQuanBenh.MaTuy_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia", BenhAnNgoaiTruPHCN.DacDiemLienQuanBenh.RuouBia == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia_Text", BenhAnNgoaiTruPHCN.DacDiemLienQuanBenh.RuouBia_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa", BenhAnNgoaiTruPHCN.DacDiemLienQuanBenh.ThuocLa == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa_Text", BenhAnNgoaiTruPHCN.DacDiemLienQuanBenh.ThuocLa_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao", BenhAnNgoaiTruPHCN.DacDiemLienQuanBenh.ThuocLao == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao_Text", BenhAnNgoaiTruPHCN.DacDiemLienQuanBenh.ThuocLao_Text));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh", BenhAnNgoaiTruPHCN.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh_Text", BenhAnNgoaiTruPHCN.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TenKhoa", BenhAnNgoaiTruPHCN.TenKhoa));
            Command.Parameters.Add(new MDB.MDBParameter("CacBoPhan", BenhAnNgoaiTruPHCN.CacBoPhan));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQuaCanLamSang", BenhAnNgoaiTruPHCN.TomTatKetQuaCanLamSang));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanBanDau", BenhAnNgoaiTruPHCN.ChanDoanBanDau));
            Command.Parameters.Add(new MDB.MDBParameter("DaXuLy", BenhAnNgoaiTruPHCN.DaXuLy));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanKhiRaVien", BenhAnNgoaiTruPHCN.ChanDoanKhiRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("DieuTriNgoaiTru_TuNgay", BenhAnNgoaiTruPHCN.DieuTriNgoaiTru_TuNgay));
            Command.Parameters.Add(new MDB.MDBParameter("DieuTriNgoaiTru_DenNgay", BenhAnNgoaiTruPHCN.DieuTriNgoaiTru_DenNgay));
            Command.Parameters.Add(new MDB.MDBParameter("IDGiamDoc", BenhAnNgoaiTruPHCN.IDGiamDoc));
            Command.Parameters.Add(new MDB.MDBParameter("MaICD_BenhChinh", BenhAnNgoaiTruPHCN.MaICD_BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("MaICD_BenhKemTheo", BenhAnNgoaiTruPHCN.MaICD_BenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("MAIDC_ChanDoanKhiRaVien", BenhAnNgoaiTruPHCN.MAIDC_ChanDoanKhiRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("CNKhuyetTat", BenhAnNgoaiTruPHCN.CNKhuyetTat));
            Command.Parameters.Add(new MDB.MDBParameter("DangKhuyetTuat", BenhAnNgoaiTruPHCN.DangKhuyetTuat));
            Command.Parameters.Add(new MDB.MDBParameter("MucDoKT", BenhAnNgoaiTruPHCN.MucDoKT));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhDiUng", BenhAnNgoaiTruPHCN.TienSuBenhDiUng));
            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool Update(MDB.MDBConnection MyConnection, BenhAnNgoaiTruPHCN BenhAnNgoaiTru)
        {
            string sql = @"UPDATE BenhAnNgoaiTruPHCN SET 
                        LyDoVaoVien = :LyDoVaoVien,
                        VaoNgayThu = :VaoNgayThu,
                        QuaTrinhBenhLy = :QuaTrinhBenhLy,
                        TienSuBenhBanThan = :TienSuBenhBanThan,
                        TienSuBenhGiaDinh = :TienSuBenhGiaDinh,
                        ToanThan = :ToanThan,
                        TuanHoan = :TuanHoan,
                        HoHap = :HoHap,
                        TieuHoa = :TieuHoa,
                        ThanTietNieuSinhDuc = :ThanTietNieuSinhDuc,
                        ThanKinh = :ThanKinh,
                        CoXuongKhop = :CoXuongKhop,
                        TaiMuiHong = :TaiMuiHong,
                        RangHamMat = :RangHamMat,
                        Mat = :Mat,
                        Khac_CacCoQuan = :Khac_CacCoQuan,
                        CacXetNghiemCanLamSangCanLam = :CacXetNghiemCanLamSangCanLam,
                        TomTatBenhAn = :TomTatBenhAn,
                        BenhChinh = :BenhChinh,
                        BenhKemTheo = :BenhKemTheo,
                        PhanBiet = :PhanBiet,
                        TienLuong = :TienLuong,
                        HuongDieuTri = :HuongDieuTri,
                        NgayKhamBenh = :NgayKhamBenh,
                        BacSyLamBenhAn = :BacSyLamBenhAn,
                        QuaTrinhBenhLyVaDienBien = :QuaTrinhBenhLyVaDienBien,
                        TomTatKetQuaXetNghiem = :TomTatKetQuaXetNghiem,
                        PhuongPhapDieuTri = :PhuongPhapDieuTri,
                        TinhTrangNguoiBenhRaVien = :TinhTrangNguoiBenhRaVien,
                        HuongDieuTriVaCacCheDoTiepTheo = :HuongDieuTriVaCacCheDoTiepTheo,
                        NguoiNhanHoSo = :NguoiNhanHoSo,
                        NguoiGiaoHoSo = :NguoiGiaoHoSo,
                        NgayTongKet = :NgayTongKet,
                        BacSyDieuTri = :BacSyDieuTri,
                        DiUng = :DiUng,
                        DiUng_Text = :DiUng_Text,
                        MaTuy = :MaTuy,
                        MaTuy_Text = :MaTuy_Text,
                        RuouBia = :RuouBia,
                        RuouBia_Text = :RuouBia_Text,
                        ThuocLa = :ThuocLa,
                        ThuocLa_Text = :ThuocLa_Text,
                        ThuocLao = :ThuocLao,
                        ThuocLao_Text = :ThuocLao_Text,
                        Khac_DacDiemLienQuanBenh = :Khac_DacDiemLienQuanBenh,
                        Khac_DacDiemLienQuanBenh_Text = :Khac_DacDiemLienQuanBenh_Text,
TenKhoa = :TenKhoa,
CacBoPhan = :CacBoPhan,
TomTatKetQuaCanLamSang = :TomTatKetQuaCanLamSang,
ChanDoanBanDau = :ChanDoanBanDau,
DaXuLy = :DaXuLy,
ChanDoanKhiRaVien = :ChanDoanKhiRaVien,
DieuTriNgoaiTru_TuNgay = :DieuTriNgoaiTru_TuNgay,
DieuTriNgoaiTru_DenNgay = :DieuTriNgoaiTru_DenNgay,
IDGiamDoc = :IDGiamDoc,
MaICD_BenhChinh = :MaICD_BenhChinh,
MaICD_BenhKemTheo = :MaICD_BenhKemTheo,
MAIDC_ChanDoanKhiRaVien = :MAIDC_ChanDoanKhiRaVien,
CNKhuyetTat = :CNKhuyetTat,
DangKhuyetTuat = :DangKhuyetTuat,
MucDoKT = :MucDoKT,
TienSuBenhDiUng = :TienSuBenhDiUng
                        WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnNgoaiTru.LyDoVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("VaoNgayThu", BenhAnNgoaiTru.VaoNgayThu));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnNgoaiTru.QuaTrinhBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhBanThan", BenhAnNgoaiTru.TienSuBenhBanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhGiaDinh", BenhAnNgoaiTru.TienSuBenhGiaDinh));
            Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnNgoaiTru.ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoan", BenhAnNgoaiTru.TuanHoan));
            Command.Parameters.Add(new MDB.MDBParameter("HoHap", BenhAnNgoaiTru.HoHap));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoa", BenhAnNgoaiTru.TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieuSinhDuc", BenhAnNgoaiTru.ThanTietNieuSinhDuc));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinh", BenhAnNgoaiTru.ThanKinh));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop", BenhAnNgoaiTru.CoXuongKhop));
            Command.Parameters.Add(new MDB.MDBParameter("TaiMuiHong", BenhAnNgoaiTru.TaiMuiHong));
            Command.Parameters.Add(new MDB.MDBParameter("RangHamMat", BenhAnNgoaiTru.RangHamMat));
            Command.Parameters.Add(new MDB.MDBParameter("Mat", BenhAnNgoaiTru.Mat));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_CacCoQuan", BenhAnNgoaiTru.Khac_CacCoQuan));
            Command.Parameters.Add(new MDB.MDBParameter("CacXetNghiemCanLamSangCanLam", BenhAnNgoaiTru.CacXetNghiemCanLamSangCanLam));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatBenhAn", BenhAnNgoaiTru.TomTatBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnNgoaiTru.BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnNgoaiTru.BenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("PhanBiet", BenhAnNgoaiTru.PhanBiet));
            Command.Parameters.Add(new MDB.MDBParameter("TienLuong", BenhAnNgoaiTru.TienLuong));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnNgoaiTru.HuongDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("NgayKhamBenh", BenhAnNgoaiTru.NgayKhamBenh));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyLamBenhAn", BenhAnNgoaiTru.BacSyLamBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLyVaDienBien", BenhAnNgoaiTru.QuaTrinhBenhLyVaDienBien));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQuaXetNghiem", BenhAnNgoaiTru.TomTatKetQuaXetNghiem));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnNgoaiTru.PhuongPhapDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangNguoiBenhRaVien", BenhAnNgoaiTru.TinhTrangNguoiBenhRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriVaCacCheDoTiepTheo", BenhAnNgoaiTru.HuongDieuTriVaCacCheDoTiepTheo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnNgoaiTru.NguoiNhanHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnNgoaiTru.NguoiGiaoHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnNgoaiTru.NgayTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnNgoaiTru.BacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng", BenhAnNgoaiTru.DacDiemLienQuanBenh.DiUng == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng_Text", BenhAnNgoaiTru.DacDiemLienQuanBenh.DiUng_Text));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy", BenhAnNgoaiTru.DacDiemLienQuanBenh.MaTuy == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy_Text", BenhAnNgoaiTru.DacDiemLienQuanBenh.MaTuy_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia", BenhAnNgoaiTru.DacDiemLienQuanBenh.RuouBia == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia_Text", BenhAnNgoaiTru.DacDiemLienQuanBenh.RuouBia_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa", BenhAnNgoaiTru.DacDiemLienQuanBenh.ThuocLa == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa_Text", BenhAnNgoaiTru.DacDiemLienQuanBenh.ThuocLa_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao", BenhAnNgoaiTru.DacDiemLienQuanBenh.ThuocLao == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao_Text", BenhAnNgoaiTru.DacDiemLienQuanBenh.ThuocLao_Text));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh", BenhAnNgoaiTru.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh_Text", BenhAnNgoaiTru.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TenKhoa", BenhAnNgoaiTru.TenKhoa));
            Command.Parameters.Add(new MDB.MDBParameter("CacBoPhan", BenhAnNgoaiTru.CacBoPhan));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQuaCanLamSang", BenhAnNgoaiTru.TomTatKetQuaCanLamSang));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanBanDau", BenhAnNgoaiTru.ChanDoanBanDau));
            Command.Parameters.Add(new MDB.MDBParameter("DaXuLy", BenhAnNgoaiTru.DaXuLy));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanKhiRaVien", BenhAnNgoaiTru.ChanDoanKhiRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("DieuTriNgoaiTru_TuNgay", BenhAnNgoaiTru.DieuTriNgoaiTru_TuNgay));
            Command.Parameters.Add(new MDB.MDBParameter("DieuTriNgoaiTru_DenNgay", BenhAnNgoaiTru.DieuTriNgoaiTru_DenNgay));
            Command.Parameters.Add(new MDB.MDBParameter("IDGiamDoc", BenhAnNgoaiTru.IDGiamDoc));
            Command.Parameters.Add(new MDB.MDBParameter("MaICD_BenhChinh", BenhAnNgoaiTru.MaICD_BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("MaICD_BenhKemTheo", BenhAnNgoaiTru.MaICD_BenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("MAIDC_ChanDoanKhiRaVien", BenhAnNgoaiTru.MAIDC_ChanDoanKhiRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("CNKhuyetTat", BenhAnNgoaiTru.CNKhuyetTat));
            Command.Parameters.Add(new MDB.MDBParameter("DangKhuyetTuat", BenhAnNgoaiTru.DangKhuyetTuat));
            Command.Parameters.Add(new MDB.MDBParameter("MucDoKT", BenhAnNgoaiTru.MucDoKT));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhDiUng", BenhAnNgoaiTru.TienSuBenhDiUng));

            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnNgoaiTru.MaQuanLy));

            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
    }
}
