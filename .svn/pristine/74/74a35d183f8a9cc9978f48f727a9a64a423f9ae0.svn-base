
using EMR_MAIN.DATABASE.BenhAn;
using System;
using System.Data;

namespace EMR_MAIN
{
    public class BenhAnPHCNNhiFunc
    {
        public static void WriteXml(MDB.MDBConnection MyConnection)
        {
            string sql =
                   @"
                  select  a.*,  CTScanner HoSo_CTScanner, SieuAm HoSo_SieuAm, XetNghiem HoSo_XetNghiem,  Khac HoSo_Khac,  Khac_Text HoSo_Khac_Text,  ToanBoHoSo HoSo_ToanBoHoSo, Mach DauSinhTon_Mach,  NhietDo DauSinhTon_NhietDo,  HuyetAp DauSinhTon_HuyetAp,  NhipTho DauSinhTon_NhipTho,  CanNang DauSinhTon_CanNang  
                  from BenhAnPHCNNhi a inner join thongtindieutri b on a.maquanly = b.maquanly
                  where rownum = 1
                    ";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            var DataTable = new DataTable { TableName = "BenhAnPHCNNhi" };
            DataTable.Load(DataReader as IDataReader);
            DataTable.WriteXml("rptBenhAnPHCNNhi.xml");
        }
        public static DataSet SelectDataSet(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql =
                   @"
                   select  a.*,f.hovaten BacSyLamBenhAnHoVaTen ,c.hovaten BacSyDieuTriHoVaTen,d.hovaten NguoiGiaoHoSoHoVaTen,e.hovaten NguoiNhanHoSoHoVaTen, b.XQuang HoSo_XQuang,   b.CTScanner HoSo_CTScanner, b.SieuAm HoSo_SieuAm, b.XetNghiem HoSo_XetNghiem,  b.Khac HoSo_Khac,  b.Khac_Text HoSo_Khac_Text,  b.ToanBoHoSo HoSo_ToanBoHoSo, b.Mach DauSinhTon_Mach, b.NhietDo DauSinhTon_NhietDo,  b.HuyetAp DauSinhTon_HuyetAp,  b.NhipTho DauSinhTon_NhipTho,  b.CanNang DauSinhTon_CanNang  , b.ChieuCao DauSinhTon_ChieuCao, b.BMI DauSinhTon_BMI, b.BMI DauSinhTon_BMI, b.NgayRaVien 
                 from BenhAnPHCNNhi a 
                 left join thongtindieutri b on a.maquanly = b.maquanly 
                  left join nhanvien c on a.bacsydieutri = c.manhanvien
                  left join nhanvien d on a.nguoigiaohoso = d.manhanvien
                  left join nhanvien e on a.nguoinhanhoso = e.manhanvien
                  left join nhanvien f on a.BacSyLamBenhAn = f.manhanvien
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
        public static BenhAnPHCNNhi Select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            #region
            string sql =
                      @"select * 
                        from BenhAnPHCNNhi a
                        where MaQuanLy = :MaQuanLy";
            #endregion
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            var value = new BenhAnPHCNNhi();
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
                value.MaSoKyTen = DataReader["masokyten"].ToString();
                value.MaSoKyTen_KB = DataReader["masokyten_kb"].ToString();
                value.MaSoKyTen_TK = DataReader["masokyten_tk"].ToString();
                value.DauSinhTon = new DauSinhTon();
                // banh an PHCN nhi
                value.LoaiDieuTri = DataReader["LoaiDieuTri"].ToString();
                value.TienSuSanKhoa_Me = DataReader["TienSuSanKhoa_Me"].ToString();
                value.TuoiMeKhiSinhTre = DataReader["TuoiMeKhiSinhTre"].ToString();
                value.TinhTranMeMangThai = DataReader["TinhTranMeMangThai"].ToString();
                value.ConThu = DataReader["ConThu"].ToString();
                value.TuoiThai = DataReader["TuoiThai"].ToString();
                value.TuoiThaiCheck = DataReader["TuoiThaiCheck"].ToString();
                value.CanNangKhiSinh = DataReader["CanNangKhiSinh"].ToString();
                value.CanNangKhiSinhCheck = DataReader["CanNangKhiSinhCheck"].ToString();
                value.TinhTrangKhiSinh = DataReader["TinhTrangKhiSinh"].ToString();
                value.TinhTrangSauSinh = DataReader["TinhTrangSauSinh"].ToString();
                value.TiemPhongVacxin = DataReader["TiemPhongVacxin"].ToString();
                value.SoConTrongGiaDinh = DataReader["SoConTrongGiaDinh"].ToString();
                value.SoTreCoBatThuong = DataReader["SoTreCoBatThuong"].ToString();
                value.GiaDinhCoNhiemCDDC = DataReader["GiaDinhCoNhiemCDDC"].ToString();
                value.VongDau = DataReader["VongDau"].ToString();
                value.ChiDinhDieuTri = DataReader["ChiDinhDieuTri"].ToString();
                value.DieuTriBenhLy = DataReader["DieuTriBenhLy"].ToString();
                value.CheDoChamSoc = DataReader["CheDoChamSoc"].ToString();
                value.HoiNhapXaHoi = DataReader["HoiNhapXaHoi"].ToString();
                value.TinhTrang_VanDong = DataReader["TinhTrang_VanDong"].ToString();
                value.TinhTrang_ChucNang = DataReader["TinhTrang_ChucNang"].ToString();
                value.TinhTrang_NhanThuc = DataReader["TinhTrang_NhanThuc"].ToString();
                value.TinhTrang_ChucNangKhac = DataReader["TinhTrang_ChucNangKhac"].ToString();
                value.TinhTrang_SuThamGia = DataReader["TinhTrang_SuThamGia"].ToString();
                value.TinhTrang_YeuToMoiTruong = DataReader["TinhTrang_YeuToMoiTruong"].ToString();

            }
            return value;
        }

        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, BenhAnPHCNNhi BenhAnPHCNNhi)
        {
            try
            {
                string sql =
                          @"select MaQuanLy 
                        from BenhAnPHCNNhi
                        where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnPHCNNhi.MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                int rowCount = 0;
                while (DataReader.Read()) rowCount++;
                if (rowCount == 1) return Update(MyConnection, BenhAnPHCNNhi);
                sql = @"
                  INSERT INTO BenhAnPHCNNhi (MaQuanLy,
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
LoaiDieuTri,
TienSuSanKhoa_Me,
TuoiMeKhiSinhTre,
TinhTranMeMangThai,
ConThu,
TuoiThai,
TuoiThaiCheck,
CanNangKhiSinh,
CanNangKhiSinhCheck,
TinhTrangKhiSinh,
TinhTrangSauSinh,
TiemPhongVacxin,
SoConTrongGiaDinh,
SoTreCoBatThuong,
GiaDinhCoNhiemCDDC,
VongDau,
ChiDinhDieuTri,
DieuTriBenhLy,
CheDoChamSoc,
HoiNhapXaHoi,
TinhTrang_VanDong,
TinhTrang_ChucNang,
TinhTrang_NhanThuc,
TinhTrang_ChucNangKhac,
TinhTrang_SuThamGia,
TinhTrang_YeuToMoiTruong)
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
:LoaiDieuTri,
:TienSuSanKhoa_Me,
:TuoiMeKhiSinhTre,
:TinhTranMeMangThai,
:ConThu,
:TuoiThai,
:TuoiThaiCheck,
:CanNangKhiSinh,
:CanNangKhiSinhCheck,
:TinhTrangKhiSinh,
:TinhTrangSauSinh,
:TiemPhongVacxin,
:SoConTrongGiaDinh,
:SoTreCoBatThuong,
:GiaDinhCoNhiemCDDC,
:VongDau,
:ChiDinhDieuTri,
:DieuTriBenhLy,
:CheDoChamSoc,
:HoiNhapXaHoi,
:TinhTrang_VanDong,
:TinhTrang_ChucNang,
:TinhTrang_NhanThuc,
:TinhTrang_ChucNangKhac,
:TinhTrang_SuThamGia,
:TinhTrang_YeuToMoiTruong)";
                Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnPHCNNhi.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnPHCNNhi.LyDoVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("VaoNgayThu", BenhAnPHCNNhi.VaoNgayThu));
                Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnPHCNNhi.QuaTrinhBenhLy));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhBanThan", BenhAnPHCNNhi.TienSuBenhBanThan));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhGiaDinh", BenhAnPHCNNhi.TienSuBenhGiaDinh));
                Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnPHCNNhi.ToanThan));
                Command.Parameters.Add(new MDB.MDBParameter("TuanHoan", BenhAnPHCNNhi.TuanHoan));
                Command.Parameters.Add(new MDB.MDBParameter("HoHap", BenhAnPHCNNhi.HoHap));
                Command.Parameters.Add(new MDB.MDBParameter("TieuHoa", BenhAnPHCNNhi.TieuHoa));
                Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieuSinhDuc", BenhAnPHCNNhi.ThanTietNieuSinhDuc));
                Command.Parameters.Add(new MDB.MDBParameter("ThanKinh", BenhAnPHCNNhi.ThanKinh));
                Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop", BenhAnPHCNNhi.CoXuongKhop));
                Command.Parameters.Add(new MDB.MDBParameter("TaiMuiHong", BenhAnPHCNNhi.TaiMuiHong));
                Command.Parameters.Add(new MDB.MDBParameter("RangHamMat", BenhAnPHCNNhi.RangHamMat));
                Command.Parameters.Add(new MDB.MDBParameter("Mat", BenhAnPHCNNhi.Mat));
                Command.Parameters.Add(new MDB.MDBParameter("Khac_CacCoQuan", BenhAnPHCNNhi.Khac_CacCoQuan));
                Command.Parameters.Add(new MDB.MDBParameter("CacXetNghiemCanLamSangCanLam", BenhAnPHCNNhi.CacXetNghiemCanLamSangCanLam));
                Command.Parameters.Add(new MDB.MDBParameter("TomTatBenhAn", BenhAnPHCNNhi.TomTatBenhAn));
                Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnPHCNNhi.BenhChinh));
                Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnPHCNNhi.BenhKemTheo));
                Command.Parameters.Add(new MDB.MDBParameter("PhanBiet", BenhAnPHCNNhi.PhanBiet));
                Command.Parameters.Add(new MDB.MDBParameter("TienLuong", BenhAnPHCNNhi.TienLuong));
                Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnPHCNNhi.HuongDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("NgayKhamBenh", BenhAnPHCNNhi.NgayKhamBenh));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyLamBenhAn", BenhAnPHCNNhi.BacSyLamBenhAn));
                Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLyVaDienBien", BenhAnPHCNNhi.QuaTrinhBenhLyVaDienBien));
                Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQuaXetNghiem", BenhAnPHCNNhi.TomTatKetQuaXetNghiem));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnPHCNNhi.PhuongPhapDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangNguoiBenhRaVien", BenhAnPHCNNhi.TinhTrangNguoiBenhRaVien));
                Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriVaCacCheDoTiepTheo", BenhAnPHCNNhi.HuongDieuTriVaCacCheDoTiepTheo));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnPHCNNhi.NguoiNhanHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnPHCNNhi.NguoiGiaoHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnPHCNNhi.NgayTongKet));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnPHCNNhi.BacSyDieuTri));
                

                Command.Parameters.Add(new MDB.MDBParameter("LoaiDieuTri", BenhAnPHCNNhi.LoaiDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuSanKhoa_Me", BenhAnPHCNNhi.TienSuSanKhoa_Me));
                Command.Parameters.Add(new MDB.MDBParameter("TuoiMeKhiSinhTre", BenhAnPHCNNhi.TuoiMeKhiSinhTre));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTranMeMangThai",BenhAnPHCNNhi.TinhTranMeMangThai));
                Command.Parameters.Add(new MDB.MDBParameter("ConThu",BenhAnPHCNNhi.ConThu));
                Command.Parameters.Add(new MDB.MDBParameter("TuoiThai",BenhAnPHCNNhi.TuoiThai));
                Command.Parameters.Add(new MDB.MDBParameter("TuoiThaiCheck",BenhAnPHCNNhi.TuoiThaiCheck));
                Command.Parameters.Add(new MDB.MDBParameter("CanNangKhiSinh",BenhAnPHCNNhi.CanNangKhiSinh));
                Command.Parameters.Add(new MDB.MDBParameter("CanNangKhiSinhCheck",BenhAnPHCNNhi.CanNangKhiSinhCheck));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangKhiSinh",BenhAnPHCNNhi.TinhTrangKhiSinh));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangSauSinh",BenhAnPHCNNhi.TinhTrangSauSinh));
                Command.Parameters.Add(new MDB.MDBParameter("TiemPhongVacxin",BenhAnPHCNNhi.TiemPhongVacxin));
                Command.Parameters.Add(new MDB.MDBParameter("SoConTrongGiaDinh",BenhAnPHCNNhi.SoConTrongGiaDinh));
                Command.Parameters.Add(new MDB.MDBParameter("SoTreCoBatThuong",BenhAnPHCNNhi.SoTreCoBatThuong));
                Command.Parameters.Add(new MDB.MDBParameter("GiaDinhCoNhiemCDDC",BenhAnPHCNNhi.GiaDinhCoNhiemCDDC));
                Command.Parameters.Add(new MDB.MDBParameter("VongDau",BenhAnPHCNNhi.VongDau));
                Command.Parameters.Add(new MDB.MDBParameter("ChiDinhDieuTri",BenhAnPHCNNhi.ChiDinhDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriBenhLy",BenhAnPHCNNhi.DieuTriBenhLy));
                Command.Parameters.Add(new MDB.MDBParameter("CheDoChamSoc",BenhAnPHCNNhi.CheDoChamSoc));
                Command.Parameters.Add(new MDB.MDBParameter("HoiNhapXaHoi",BenhAnPHCNNhi.HoiNhapXaHoi));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrang_VanDong",BenhAnPHCNNhi.TinhTrang_VanDong));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrang_ChucNang",BenhAnPHCNNhi.TinhTrang_ChucNang));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrang_NhanThuc",BenhAnPHCNNhi.TinhTrang_NhanThuc));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrang_ChucNangKhac",BenhAnPHCNNhi.TinhTrang_ChucNangKhac));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrang_SuThamGia",BenhAnPHCNNhi.TinhTrang_SuThamGia));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrang_YeuToMoiTruong",BenhAnPHCNNhi.TinhTrang_YeuToMoiTruong));


                int n = Command.ExecuteNonQuery(); // C#
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
                return false;
            }
        }
        public static bool Update(MDB.MDBConnection MyConnection, BenhAnPHCNNhi BenhAnPHCNNhi)
        {
            try
            {
                string sql = @"UPDATE BenhAnPHCNNhi SET 
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
                        LoaiDieuTri=:LoaiDieuTri,
                        TienSuSanKhoa_Me = :TienSuSanKhoa_Me,
                        TuoiMeKhiSinhTre = :TuoiMeKhiSinhTre,
                        TinhTranMeMangThai = :TinhTranMeMangThai,
                        ConThu = :ConThu,
                        TuoiThai = :TuoiThai,
                        TuoiThaiCheck = :TuoiThaiCheck,
                        CanNangKhiSinh = :CanNangKhiSinh,
                        CanNangKhiSinhCheck = :CanNangKhiSinhCheck,
                        TinhTrangKhiSinh = :TinhTrangKhiSinh,
                        TinhTrangSauSinh = :TinhTrangSauSinh,
                        TiemPhongVacxin = :TiemPhongVacxin,
                        SoConTrongGiaDinh = :SoConTrongGiaDinh,
                        SoTreCoBatThuong = :SoTreCoBatThuong,
                        GiaDinhCoNhiemCDDC = :GiaDinhCoNhiemCDDC,
                        VongDau = :VongDau,
                        ChiDinhDieuTri = :ChiDinhDieuTri,
                        DieuTriBenhLy = :DieuTriBenhLy,
                        CheDoChamSoc = :CheDoChamSoc,
                        HoiNhapXaHoi = :HoiNhapXaHoi,
                        TinhTrang_VanDong = :TinhTrang_VanDong,
                        TinhTrang_ChucNang = :TinhTrang_ChucNang,
                        TinhTrang_NhanThuc = :TinhTrang_NhanThuc,
                        TinhTrang_ChucNangKhac = :TinhTrang_ChucNangKhac,
                        TinhTrang_SuThamGia = :TinhTrang_SuThamGia,
                        TinhTrang_YeuToMoiTruong = :TinhTrang_YeuToMoiTruong
                        WHERE MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnPHCNNhi.LyDoVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("VaoNgayThu", BenhAnPHCNNhi.VaoNgayThu));
                Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnPHCNNhi.QuaTrinhBenhLy));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhBanThan", BenhAnPHCNNhi.TienSuBenhBanThan));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhGiaDinh", BenhAnPHCNNhi.TienSuBenhGiaDinh));
                Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnPHCNNhi.ToanThan));
                Command.Parameters.Add(new MDB.MDBParameter("TuanHoan", BenhAnPHCNNhi.TuanHoan));
                Command.Parameters.Add(new MDB.MDBParameter("HoHap", BenhAnPHCNNhi.HoHap));
                Command.Parameters.Add(new MDB.MDBParameter("TieuHoa", BenhAnPHCNNhi.TieuHoa));
                Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieuSinhDuc", BenhAnPHCNNhi.ThanTietNieuSinhDuc));
                Command.Parameters.Add(new MDB.MDBParameter("ThanKinh", BenhAnPHCNNhi.ThanKinh));
                Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop", BenhAnPHCNNhi.CoXuongKhop));
                Command.Parameters.Add(new MDB.MDBParameter("TaiMuiHong", BenhAnPHCNNhi.TaiMuiHong));
                Command.Parameters.Add(new MDB.MDBParameter("RangHamMat", BenhAnPHCNNhi.RangHamMat));
                Command.Parameters.Add(new MDB.MDBParameter("Mat", BenhAnPHCNNhi.Mat));
                Command.Parameters.Add(new MDB.MDBParameter("Khac_CacCoQuan", BenhAnPHCNNhi.Khac_CacCoQuan));
                Command.Parameters.Add(new MDB.MDBParameter("CacXetNghiemCanLamSangCanLam", BenhAnPHCNNhi.CacXetNghiemCanLamSangCanLam));
                Command.Parameters.Add(new MDB.MDBParameter("TomTatBenhAn", BenhAnPHCNNhi.TomTatBenhAn));
                Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnPHCNNhi.BenhChinh));
                Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnPHCNNhi.BenhKemTheo));
                Command.Parameters.Add(new MDB.MDBParameter("PhanBiet", BenhAnPHCNNhi.PhanBiet));
                Command.Parameters.Add(new MDB.MDBParameter("TienLuong", BenhAnPHCNNhi.TienLuong));
                Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnPHCNNhi.HuongDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("NgayKhamBenh", BenhAnPHCNNhi.NgayKhamBenh));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyLamBenhAn", BenhAnPHCNNhi.BacSyLamBenhAn));
                Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLyVaDienBien", BenhAnPHCNNhi.QuaTrinhBenhLyVaDienBien));
                Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQuaXetNghiem", BenhAnPHCNNhi.TomTatKetQuaXetNghiem));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnPHCNNhi.PhuongPhapDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangNguoiBenhRaVien", BenhAnPHCNNhi.TinhTrangNguoiBenhRaVien));
                Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriVaCacCheDoTiepTheo", BenhAnPHCNNhi.HuongDieuTriVaCacCheDoTiepTheo));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnPHCNNhi.NguoiNhanHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnPHCNNhi.NguoiGiaoHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnPHCNNhi.NgayTongKet));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnPHCNNhi.BacSyDieuTri));
                
                Command.Parameters.Add(new MDB.MDBParameter("LoaiDieuTri", BenhAnPHCNNhi.LoaiDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuSanKhoa_Me", BenhAnPHCNNhi.TienSuSanKhoa_Me));
                Command.Parameters.Add(new MDB.MDBParameter("TuoiMeKhiSinhTre", BenhAnPHCNNhi.TuoiMeKhiSinhTre));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTranMeMangThai", BenhAnPHCNNhi.TinhTranMeMangThai));
                Command.Parameters.Add(new MDB.MDBParameter("ConThu", BenhAnPHCNNhi.ConThu));
                Command.Parameters.Add(new MDB.MDBParameter("TuoiThai", BenhAnPHCNNhi.TuoiThai));
                Command.Parameters.Add(new MDB.MDBParameter("TuoiThaiCheck", BenhAnPHCNNhi.TuoiThaiCheck));
                Command.Parameters.Add(new MDB.MDBParameter("CanNangKhiSinh", BenhAnPHCNNhi.CanNangKhiSinh));
                Command.Parameters.Add(new MDB.MDBParameter("CanNangKhiSinhCheck", BenhAnPHCNNhi.CanNangKhiSinhCheck));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangKhiSinh", BenhAnPHCNNhi.TinhTrangKhiSinh));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangSauSinh", BenhAnPHCNNhi.TinhTrangSauSinh));
                Command.Parameters.Add(new MDB.MDBParameter("TiemPhongVacxin", BenhAnPHCNNhi.TiemPhongVacxin));
                Command.Parameters.Add(new MDB.MDBParameter("SoConTrongGiaDinh", BenhAnPHCNNhi.SoConTrongGiaDinh));
                Command.Parameters.Add(new MDB.MDBParameter("SoTreCoBatThuong", BenhAnPHCNNhi.SoTreCoBatThuong));
                Command.Parameters.Add(new MDB.MDBParameter("GiaDinhCoNhiemCDDC", BenhAnPHCNNhi.GiaDinhCoNhiemCDDC));
                Command.Parameters.Add(new MDB.MDBParameter("VongDau", BenhAnPHCNNhi.VongDau));
                Command.Parameters.Add(new MDB.MDBParameter("ChiDinhDieuTri", BenhAnPHCNNhi.ChiDinhDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriBenhLy", BenhAnPHCNNhi.DieuTriBenhLy));
                Command.Parameters.Add(new MDB.MDBParameter("CheDoChamSoc", BenhAnPHCNNhi.CheDoChamSoc));
                Command.Parameters.Add(new MDB.MDBParameter("HoiNhapXaHoi", BenhAnPHCNNhi.HoiNhapXaHoi));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrang_VanDong", BenhAnPHCNNhi.TinhTrang_VanDong));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrang_ChucNang", BenhAnPHCNNhi.TinhTrang_ChucNang));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrang_NhanThuc", BenhAnPHCNNhi.TinhTrang_NhanThuc));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrang_ChucNangKhac", BenhAnPHCNNhi.TinhTrang_ChucNangKhac));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrang_SuThamGia", BenhAnPHCNNhi.TinhTrang_SuThamGia));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrang_YeuToMoiTruong", BenhAnPHCNNhi.TinhTrang_YeuToMoiTruong));

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnPHCNNhi.MaQuanLy));
                int n = Command.ExecuteNonQuery(); // C#
                return n > 0 ? true : false;
            } catch(Exception ex)
            {
                XuLyLoi.Handle(ex);
                return false;
            }
           
        }
        public static bool Delete(MDB.MDBConnection MyConnection, BenhAnPHCNNhi BenhAnPHCNNhi)
        {
            string sql = @"DELETE FROM BenhAnPHCNNhi 
                           WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnPHCNNhi.MaQuanLy));

            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
    }
}
