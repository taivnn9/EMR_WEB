
using EMR_MAIN.DATABASE.BenhAn;
using System;
using System.Data;

namespace EMR_MAIN
{
    public class BenhAnPHCNIIFunc
    {
        public static void WriteXml(MDB.MDBConnection MyConnection)
        {
            string sql =
                   @"
                  select  a.*,  CTScanner HoSo_CTScanner, SieuAm HoSo_SieuAm, XetNghiem HoSo_XetNghiem,  Khac HoSo_Khac,  Khac_Text HoSo_Khac_Text,  ToanBoHoSo HoSo_ToanBoHoSo, Mach DauSinhTon_Mach,  NhietDo DauSinhTon_NhietDo,  HuyetAp DauSinhTon_HuyetAp,  NhipTho DauSinhTon_NhipTho,  CanNang DauSinhTon_CanNang  
                  from BenhAnPHCNII a inner join thongtindieutri b on a.maquanly = b.maquanly
                  where rownum = 1
                    ";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            var DataTable = new DataTable { TableName = "BenhAnPHCNII" };
            DataTable.Load(DataReader as IDataReader);
            DataTable.WriteXml("rptBenhAnPHCNII.xml");
        }
        public static DataSet SelectDataSet(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql =
                   @"
                   select  a.*,f.hovaten BacSyLamBenhAnHoVaTen ,c.hovaten BacSyDieuTriHoVaTen,d.hovaten NguoiGiaoHoSoHoVaTen,e.hovaten NguoiNhanHoSoHoVaTen, b.XQuang HoSo_XQuang,   b.CTScanner HoSo_CTScanner, b.SieuAm HoSo_SieuAm, b.XetNghiem HoSo_XetNghiem,  b.Khac HoSo_Khac,  b.Khac_Text HoSo_Khac_Text,  b.ToanBoHoSo HoSo_ToanBoHoSo, b.Mach DauSinhTon_Mach, b.NhietDo DauSinhTon_NhietDo,  b.HuyetAp DauSinhTon_HuyetAp,  b.NhipTho DauSinhTon_NhipTho,  b.CanNang DauSinhTon_CanNang  , b.ChieuCao DauSinhTon_ChieuCao, b.BMI DauSinhTon_BMI, b.BMI DauSinhTon_BMI, b.NgayRaVien 
                 from BenhAnPHCNII a 
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
        public static BenhAnPHCNII Select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            #region
            string sql =
                      @"select * 
                        from BenhAnPHCNII a
                        where MaQuanLy = :MaQuanLy";
            #endregion
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            var value = new BenhAnPHCNII();
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
                // banh an PHCNII
                value.LoaiDieuTri = DataReader["LoaiDieuTri"].ToString();
                value.TienSuDiUng = DataReader["TienSuDiUng"].ToString();
                value.TinhTrangDau = DataReader["TinhTrangDau"].ToString();
                value.KeHoach_KhoKhan = DataReader["KeHoach_KhoKhan"].ToString();
                value.KeHoach_MucTieu = DataReader["KeHoach_MucTieu"].ToString();
                value.KeHoach_ChuongTrinh = DataReader["KeHoach_ChuongTrinh"].ToString();
                value.KeHoach_DieuTri = DataReader["KeHoach_DieuTri"].ToString();
                value.TinhTrang_VanDong = DataReader["TinhTrang_VanDong"].ToString();
                value.TinhTrang_ChucNang = DataReader["TinhTrang_ChucNang"].ToString();
                value.TinhTrang_NhanThuc = DataReader["TinhTrang_NhanThuc"].ToString();
                value.TinhTrang_ChucNangKhac = DataReader["TinhTrang_ChucNangKhac"].ToString();
                value.TinhTrang_SuThamGia = DataReader["TinhTrang_SuThamGia"].ToString();
                value.TinhTrang_YeuToMoiTruong = DataReader["TinhTrang_YeuToMoiTruong"].ToString();

                value.TinhTrang_VanDong = DataReader["TinhTrang_VanDong"].ToString();
                value.TinhTrang_ChucNang = DataReader["TinhTrang_ChucNang"].ToString();
                value.TinhTrang_NhanThuc = DataReader["TinhTrang_NhanThuc"].ToString();
                value.TinhTrang_ChucNangKhac = DataReader["TinhTrang_ChucNangKhac"].ToString();
                value.TinhTrang_SuThamGia = DataReader["TinhTrang_SuThamGia"].ToString();
                value.TinhTrang_YeuToMoiTruong = DataReader["TinhTrang_YeuToMoiTruong"].ToString();

            }
            return value;
        }

        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, BenhAnPHCNII BenhAnPHCNII)
        {
            try
            {
                string sql =
                          @"select MaQuanLy 
                        from BenhAnPHCNII
                        where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnPHCNII.MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                int rowCount = 0;
                while (DataReader.Read()) rowCount++;
                if (rowCount == 1) return Update(MyConnection, BenhAnPHCNII);
                sql = @"
                  INSERT INTO BenhAnPHCNII (MaQuanLy,
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
TienSuDiUng,
TinhTrangDau,
KeHoach_KhoKhan,
KeHoach_MucTieu,
KeHoach_ChuongTrinh,
KeHoach_DieuTri,
TinhTrang_VanDong,
TinhTrang_ChucNang,
TinhTrang_NhanThuc,
TinhTrang_ChucNangKhac,
TinhTrang_SuThamGia,
TinhTrang_YeuToMoiTruong
)
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
:TienSuDiUng,
:TinhTrangDau,
:KeHoach_KhoKhan,
:KeHoach_MucTieu,
:KeHoach_ChuongTrinh,
:KeHoach_DieuTri,
:TinhTrang_VanDong,
:TinhTrang_ChucNang,
:TinhTrang_NhanThuc,
:TinhTrang_ChucNangKhac,
:TinhTrang_SuThamGia,
:TinhTrang_YeuToMoiTruong
)";
                Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnPHCNII.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnPHCNII.LyDoVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("VaoNgayThu", BenhAnPHCNII.VaoNgayThu));
                Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnPHCNII.QuaTrinhBenhLy));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhBanThan", BenhAnPHCNII.TienSuBenhBanThan));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhGiaDinh", BenhAnPHCNII.TienSuBenhGiaDinh));
                Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnPHCNII.ToanThan));
                Command.Parameters.Add(new MDB.MDBParameter("TuanHoan", BenhAnPHCNII.TuanHoan));
                Command.Parameters.Add(new MDB.MDBParameter("HoHap", BenhAnPHCNII.HoHap));
                Command.Parameters.Add(new MDB.MDBParameter("TieuHoa", BenhAnPHCNII.TieuHoa));
                Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieuSinhDuc", BenhAnPHCNII.ThanTietNieuSinhDuc));
                Command.Parameters.Add(new MDB.MDBParameter("ThanKinh", BenhAnPHCNII.ThanKinh));
                Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop", BenhAnPHCNII.CoXuongKhop));
                Command.Parameters.Add(new MDB.MDBParameter("TaiMuiHong", BenhAnPHCNII.TaiMuiHong));
                Command.Parameters.Add(new MDB.MDBParameter("RangHamMat", BenhAnPHCNII.RangHamMat));
                Command.Parameters.Add(new MDB.MDBParameter("Mat", BenhAnPHCNII.Mat));
                Command.Parameters.Add(new MDB.MDBParameter("Khac_CacCoQuan", BenhAnPHCNII.Khac_CacCoQuan));
                Command.Parameters.Add(new MDB.MDBParameter("CacXetNghiemCanLamSangCanLam", BenhAnPHCNII.CacXetNghiemCanLamSangCanLam));
                Command.Parameters.Add(new MDB.MDBParameter("TomTatBenhAn", BenhAnPHCNII.TomTatBenhAn));
                Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnPHCNII.BenhChinh));
                Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnPHCNII.BenhKemTheo));
                Command.Parameters.Add(new MDB.MDBParameter("PhanBiet", BenhAnPHCNII.PhanBiet));
                Command.Parameters.Add(new MDB.MDBParameter("TienLuong", BenhAnPHCNII.TienLuong));
                Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnPHCNII.HuongDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("NgayKhamBenh", BenhAnPHCNII.NgayKhamBenh));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyLamBenhAn", BenhAnPHCNII.BacSyLamBenhAn));
                Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLyVaDienBien", BenhAnPHCNII.QuaTrinhBenhLyVaDienBien));
                Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQuaXetNghiem", BenhAnPHCNII.TomTatKetQuaXetNghiem));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnPHCNII.PhuongPhapDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangNguoiBenhRaVien", BenhAnPHCNII.TinhTrangNguoiBenhRaVien));
                Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriVaCacCheDoTiepTheo", BenhAnPHCNII.HuongDieuTriVaCacCheDoTiepTheo));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnPHCNII.NguoiNhanHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnPHCNII.NguoiGiaoHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnPHCNII.NgayTongKet));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnPHCNII.BacSyDieuTri));

                Command.Parameters.Add(new MDB.MDBParameter("LoaiDieuTri", BenhAnPHCNII.LoaiDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuDiUng", BenhAnPHCNII.TienSuDiUng));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangDau", BenhAnPHCNII.TinhTrangDau));
                Command.Parameters.Add(new MDB.MDBParameter("KeHoach_KhoKhan", BenhAnPHCNII.KeHoach_KhoKhan));
                Command.Parameters.Add(new MDB.MDBParameter("KeHoach_MucTieu", BenhAnPHCNII.KeHoach_MucTieu));
                Command.Parameters.Add(new MDB.MDBParameter("KeHoach_ChuongTrinh", BenhAnPHCNII.KeHoach_ChuongTrinh));
                Command.Parameters.Add(new MDB.MDBParameter("KeHoach_DieuTri", BenhAnPHCNII.KeHoach_DieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrang_VanDong", BenhAnPHCNII.TinhTrang_VanDong));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrang_ChucNang", BenhAnPHCNII.TinhTrang_ChucNang));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrang_NhanThuc", BenhAnPHCNII.TinhTrang_NhanThuc));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrang_ChucNangKhac", BenhAnPHCNII.TinhTrang_ChucNangKhac));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrang_SuThamGia", BenhAnPHCNII.TinhTrang_SuThamGia));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrang_YeuToMoiTruong", BenhAnPHCNII.TinhTrang_YeuToMoiTruong));

                int n = Command.ExecuteNonQuery(); // C#
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
                return false;
            }
        }
        public static bool Update(MDB.MDBConnection MyConnection, BenhAnPHCNII BenhAnPHCNII)
        {
            try
            {
                string sql = @"UPDATE BenhAnPHCNII SET 
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
                        LoaiDieuTri = :LoaiDieuTri,
                        TienSuDiUng = :TienSuDiUng,
                        TinhTrangDau = :TinhTrangDau,
                        KeHoach_KhoKhan = :KeHoach_KhoKhan,
                        KeHoach_MucTieu = :KeHoach_MucTieu,
                        KeHoach_ChuongTrinh = :KeHoach_ChuongTrinh,
                        KeHoach_DieuTri = :KeHoach_DieuTri,
                        TinhTrang_VanDong = :TinhTrang_VanDong,
                        TinhTrang_ChucNang = :TinhTrang_ChucNang,
                        TinhTrang_NhanThuc = :TinhTrang_NhanThuc,
                        TinhTrang_ChucNangKhac = :TinhTrang_ChucNangKhac,
                        TinhTrang_SuThamGia = :TinhTrang_SuThamGia,
                        TinhTrang_YeuToMoiTruong = :TinhTrang_YeuToMoiTruong 
                        WHERE MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnPHCNII.LyDoVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("VaoNgayThu", BenhAnPHCNII.VaoNgayThu));
                Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnPHCNII.QuaTrinhBenhLy));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhBanThan", BenhAnPHCNII.TienSuBenhBanThan));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhGiaDinh", BenhAnPHCNII.TienSuBenhGiaDinh));
                Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnPHCNII.ToanThan));
                Command.Parameters.Add(new MDB.MDBParameter("TuanHoan", BenhAnPHCNII.TuanHoan));
                Command.Parameters.Add(new MDB.MDBParameter("HoHap", BenhAnPHCNII.HoHap));
                Command.Parameters.Add(new MDB.MDBParameter("TieuHoa", BenhAnPHCNII.TieuHoa));
                Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieuSinhDuc", BenhAnPHCNII.ThanTietNieuSinhDuc));
                Command.Parameters.Add(new MDB.MDBParameter("ThanKinh", BenhAnPHCNII.ThanKinh));
                Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop", BenhAnPHCNII.CoXuongKhop));
                Command.Parameters.Add(new MDB.MDBParameter("TaiMuiHong", BenhAnPHCNII.TaiMuiHong));
                Command.Parameters.Add(new MDB.MDBParameter("RangHamMat", BenhAnPHCNII.RangHamMat));
                Command.Parameters.Add(new MDB.MDBParameter("Mat", BenhAnPHCNII.Mat));
                Command.Parameters.Add(new MDB.MDBParameter("Khac_CacCoQuan", BenhAnPHCNII.Khac_CacCoQuan));
                Command.Parameters.Add(new MDB.MDBParameter("CacXetNghiemCanLamSangCanLam", BenhAnPHCNII.CacXetNghiemCanLamSangCanLam));
                Command.Parameters.Add(new MDB.MDBParameter("TomTatBenhAn", BenhAnPHCNII.TomTatBenhAn));
                Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnPHCNII.BenhChinh));
                Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnPHCNII.BenhKemTheo));
                Command.Parameters.Add(new MDB.MDBParameter("PhanBiet", BenhAnPHCNII.PhanBiet));
                Command.Parameters.Add(new MDB.MDBParameter("TienLuong", BenhAnPHCNII.TienLuong));
                Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnPHCNII.HuongDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("NgayKhamBenh", BenhAnPHCNII.NgayKhamBenh));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyLamBenhAn", BenhAnPHCNII.BacSyLamBenhAn));
                Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLyVaDienBien", BenhAnPHCNII.QuaTrinhBenhLyVaDienBien));
                Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQuaXetNghiem", BenhAnPHCNII.TomTatKetQuaXetNghiem));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnPHCNII.PhuongPhapDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangNguoiBenhRaVien", BenhAnPHCNII.TinhTrangNguoiBenhRaVien));
                Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriVaCacCheDoTiepTheo", BenhAnPHCNII.HuongDieuTriVaCacCheDoTiepTheo));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnPHCNII.NguoiNhanHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnPHCNII.NguoiGiaoHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnPHCNII.NgayTongKet));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnPHCNII.BacSyDieuTri));

                Command.Parameters.Add(new MDB.MDBParameter("LoaiDieuTri", BenhAnPHCNII.LoaiDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuDiUng", BenhAnPHCNII.TienSuDiUng));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangDau", BenhAnPHCNII.TinhTrangDau));
                Command.Parameters.Add(new MDB.MDBParameter("KeHoach_KhoKhan", BenhAnPHCNII.KeHoach_KhoKhan));
                Command.Parameters.Add(new MDB.MDBParameter("KeHoach_MucTieu", BenhAnPHCNII.KeHoach_MucTieu));
                Command.Parameters.Add(new MDB.MDBParameter("KeHoach_ChuongTrinh", BenhAnPHCNII.KeHoach_ChuongTrinh));
                Command.Parameters.Add(new MDB.MDBParameter("KeHoach_DieuTri", BenhAnPHCNII.KeHoach_DieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrang_VanDong", BenhAnPHCNII.TinhTrang_VanDong));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrang_ChucNang", BenhAnPHCNII.TinhTrang_ChucNang));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrang_NhanThuc", BenhAnPHCNII.TinhTrang_NhanThuc));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrang_ChucNangKhac", BenhAnPHCNII.TinhTrang_ChucNangKhac));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrang_SuThamGia", BenhAnPHCNII.TinhTrang_SuThamGia));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrang_YeuToMoiTruong", BenhAnPHCNII.TinhTrang_YeuToMoiTruong));

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnPHCNII.MaQuanLy));
                int n = Command.ExecuteNonQuery(); // C#
                return n > 0 ? true : false;
            } catch(Exception ex)
            {
                XuLyLoi.Handle(ex);
                return false;
            }
           
        }
        public static bool Delete(MDB.MDBConnection MyConnection, BenhAnPHCNII BenhAnPHCNII)
        {
            string sql = @"DELETE FROM BenhAnPHCNII 
                           WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnPHCNII.MaQuanLy));

            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
    }
}
