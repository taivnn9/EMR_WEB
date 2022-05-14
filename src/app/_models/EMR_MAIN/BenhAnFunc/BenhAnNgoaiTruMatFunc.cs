using EMR_MAIN.DATABASE.BenhAn;
using System.Data;

namespace EMR_MAIN.DATABASE.BenhAnFunc
{
    public class BenhAnNgoaiTruMatFunc
    {
        public static void WriteXml(MDB.MDBConnection MyConnection)
        {
            string sql =
                   @"
                  select  a.*,  CTScanner HoSo_CTScanner, SieuAm HoSo_SieuAm, XetNghiem HoSo_XetNghiem,  Khac HoSo_Khac,  Khac_Text HoSo_Khac_Text,  ToanBoHoSo HoSo_ToanBoHoSo, Mach DauSinhTon_Mach,  NhietDo DauSinhTon_NhietDo,  HuyetAp DauSinhTon_HuyetAp,  NhipTho DauSinhTon_NhipTho,  CanNang DauSinhTon_CanNang  
                  from BenhAnNgoaiTruMat a inner join thongtindieutri b on a.maquanly = b.maquanly
                  where rownum = 1
                    ";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            var DataTable = new DataTable { TableName = "BenhAnNgoaiTruMat" };
            DataTable.Load(DataReader as IDataReader);
            DataTable.WriteXml("rptBenhAnNgoaiTruMat.xml");
        }
        public static DataSet SelectDataSet(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql =
                  @"
                 select  a.*,f.hovaten BacSyLamBenhAnHoVaTen ,c.hovaten BacSyDieuTriHoVaTen, d.hovaten NguoiGiaoHoSoHoVaTen,e.hovaten NguoiNhanHoSoHoVaTen, b.XQuang HoSo_XQuang,   b.CTScanner HoSo_CTScanner, b.SieuAm HoSo_SieuAm, b.XetNghiem HoSo_XetNghiem,  b.Khac HoSo_Khac,  b.Khac_Text HoSo_Khac_Text,  b.ToanBoHoSo HoSo_ToanBoHoSo, b.Mach DauSinhTon_Mach, b.NhietDo DauSinhTon_NhietDo,  b.HuyetAp DauSinhTon_HuyetAp,  b.NhipTho DauSinhTon_NhipTho,  b.CanNang DauSinhTon_CanNang  , b.ChieuCao DauSinhTon_ChieuCao, b.BMI DauSinhTon_BMI, b.NgayRaVien 
                 from BenhAnNgoaiTruMat a 
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
        public static BenhAnNgoaiTruMat Select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            #region
            string sql =
                      @"select * 
                        from BenhAnNgoaiTruMat a
                        where MaQuanLy = :MaQuanLy";
            #endregion
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            var value = new BenhAnNgoaiTruMat();
            value.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
            while (DataReader.Read())
            {
                value.MaQuanLy = DataReader.GetDecimal("MaQuanLy");
                value.LyDoVaoVien = DataReader["LyDoVaoVien"].ToString();
                value.VaoNgayThu = DataReader.GetInt("VaoNgayThu");
                value.QuaTrinhBenhLy = DataReader["QuaTrinhBenhLy"].ToString();
                value.TienSuBenhBanThan = DataReader["TienSuBenhBanThan"].ToString();
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
                value.TienSuBenhGiaDinh = DataReader["TienSuBenhGiaDinh"].ToString();
                value.BenhChuyenKhoa = DataReader["BenhChuyenKhoa"].ToString();
                value.ThiLucKhiVaoVien_KhongKinh_MP = DataReader["ThiLucKhiVaoVien_KhongKinh_MP"].ToString();
                value.ThiLucKhiVaoVien_KhongKinh_MT = DataReader["ThiLucKhiVaoVien_KhongKinh_MT"].ToString();
                value.ThiLucKhiVaoVien_CoKinh_MP = DataReader["ThiLucKhiVaoVien_CoKinh_MP"].ToString();
                value.ThiLucKhiVaoVien_CoKinh_MT = DataReader["ThiLucKhiVaoVien_CoKinh_MT"].ToString();
                value.NhanApVaoVien_MT = DataReader["NhanApVaoVien_MT"].ToString();
                value.NhanApVaoVien_MP = DataReader["NhanApVaoVien_MP"].ToString();
                value.ThiTruong_MT = DataReader["BenhChuyenKhoa"].ToString();
                value.ThiTruong_MP = DataReader["BenhChuyenKhoa"].ToString();
                value.LeDao_MT = DataReader["LeDao_MT"].ToString();
                value.LeDao_MP = DataReader["LeDao_MP"].ToString();
                value.MiMat_MT = DataReader["MiMat_MT"].ToString();
                value.MiMat_MP = DataReader["MiMat_MP"].ToString();
                value.KetMac_MP = DataReader["KetMac_MP"].ToString();
                value.KetMac_MT = DataReader["KetMac_MT"].ToString();
                value.TinhHinhMatHot_MP = DataReader["TinhHinhMatHot_MP"].ToString();
                value.TinhHinhMatHot_MT = DataReader["TinhHinhMatHot_MT"].ToString();
                value.GiacMac_MP = DataReader["GiacMac_MP"].ToString();
                value.GiacMac_MT = DataReader["GiacMac_MT"].ToString();
                value.CungMac_MP = DataReader["CungMac_MP"].ToString();
                value.CungMac_MT = DataReader["CungMac_MT"].ToString();
                value.TienPhong_MP = DataReader["TienPhong_MP"].ToString();
                value.TienPhong_MT = DataReader["TienPhong_MT"].ToString();
                value.MongMat_MP = DataReader["MongMat_MP"].ToString();
                value.MongMat_MT = DataReader["MongMat_MT"].ToString();
                value.DongTuPhanXa_MP = DataReader["DongTuPhanXa_MP"].ToString();
                value.DongTuPhanXa_MT = DataReader["DongTuPhanXa_MT"].ToString();
                value.ThuyTinhThe_MP = DataReader["ThuyTinhThe_MP"].ToString();
                value.ThuyTinhThe_MT = DataReader["ThuyTinhThe_MT"].ToString();
                value.ThuyTinhDich_MP = DataReader["ThuyTinhDich_MP"].ToString();
                value.ThuyTinhDich_MT = DataReader["ThuyTinhDich_MT"].ToString();
                value.SoiAnhDongTu_MP = DataReader["SoiAnhDongTu_MP"].ToString();
                value.SoiAnhDongTu_MT = DataReader["SoiAnhDongTu_MT"].ToString();
                value.TinhHinhNhanCau_MP = DataReader["TinhHinhNhanCau_MP"].ToString();
                value.TinhHinhNhanCau_MT = DataReader["TinhHinhNhanCau_MT"].ToString();
                value.HocMat_MP = DataReader["HocMat_MP"].ToString();
                value.HocMat_MT = DataReader["HocMat_MT"].ToString();
                value.DayMat_MP = DataReader["DayMat_MP"].ToString();
                value.DayMat_MT = DataReader["DayMat_MT"].ToString();
                value.ToanThan = DataReader["ToanThan"].ToString();
                value.NoiTiet = DataReader["NoiTiet"].ToString();
                value.ThanKinh = DataReader["ThanKinh"].ToString();
                value.TuanHoan = DataReader["TuanHoan"].ToString();
                value.HoHap = DataReader["HoHap"].ToString();
                value.TieuHoa = DataReader["TieuHoa"].ToString();
                value.CoXuongKhop = DataReader["CoXuongKhop"].ToString();
                value.ThanTietNieuSinhDuc = DataReader["ThanTietNieuSinhDuc"].ToString();
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
                value.ThiLucKhiRaVien_KhongKinh_MP = DataReader["ThiLucKhiRaVien_KhongKinh_MP"].ToString();
                value.ThiLucKhiRaVien_KhongKinh_MT = DataReader["ThiLucKhiRaVien_KhongKinh_MT"].ToString();
                value.ThiLucKhiRaVien_CoKinh_MP = DataReader["ThiLucKhiRaVien_CoKinh_MP"].ToString();
                value.ThiLucKhiRaVien_CoKinh_MT = DataReader["ThiLucKhiRaVien_CoKinh_MT"].ToString();
                value.NhanApRaVien_MP = DataReader["NhanApRaVien_MP"].ToString();
                value.NhanApRaVien_MT = DataReader["NhanApRaVien_MT"].ToString();
                value.HuongDieuTriVaCacCheDoTiepTheo = DataReader["HuongDieuTriVaCacCheDoTiepTheo"].ToString();
                value.NguoiNhanHoSo = DataReader["NguoiNhanHoSo"].ToString();
                value.NguoiGiaoHoSo = DataReader["NguoiGiaoHoSo"].ToString();
                value.NgayTongKet = DataReader.GetDate("NgayTongKet");
                value.BacSyDieuTri = DataReader["BacSyDieuTri"].ToString();
                value.PhauThuat = DataReader["PhauThuat"].ToString() == "1" ? true : false;
                value.ThuThuat = DataReader["ThuThuat"].ToString() == "1" ? true : false;
                value.ChanDoanBenhChinh_LamSang = DataReader["ChanDoanBenhChinh_LamSang"].ToString();
                value.ChanDoanBenhChinh_NguyenNhan = DataReader["ChanDoanBenhChinh_NguyenNhan"].ToString();
                value.QuaTrinhDieuTri_NoiKhoa = DataReader["QuaTrinhDieuTri_NoiKhoa"].ToString();
                value.MaSoKyTen = DataReader["masokyten"].ToString();
                value.MaSoKyTen_KB = DataReader["masokyten_kb"].ToString();
                value.MaSoKyTen_TK = DataReader["masokyten_tk"].ToString();
            }

            return value;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, BenhAnNgoaiTruMat BenhAnNgoaiTruMat)
        {
            string sql =
                      @"select MaQuanLy 
                        from BenhAnNgoaiTruMat
                        where MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnNgoaiTruMat.MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            int rowCount = 0;
            while (DataReader.Read()) rowCount++;
            if (rowCount > 0) return Update(MyConnection, BenhAnNgoaiTruMat);
            sql = @"INSERT INTO BenhAnNgoaiTruMat (MaQuanLy,
LyDoVaoVien,
VaoNgayThu,
QuaTrinhBenhLy,
TienSuBenhBanThan,
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
TienSuBenhGiaDinh,
BenhChuyenKhoa,
ThiLucKhiVaoVien_KhongKinh_MP,
ThiLucKhiVaoVien_KhongKinh_MT,
ThiLucKhiVaoVien_CoKinh_MP,
ThiLucKhiVaoVien_CoKinh_MT,
NhanApVaoVien_MT,
NhanApVaoVien_MP,
ThiTruong_MP,
ThiTruong_MT,
LeDao_MP,
LeDao_MT,
MiMat_MP,
MiMat_MT,
KetMac_MP,
KetMac_MT,
TinhHinhMatHot_MP,
TinhHinhMatHot_MT,
GiacMac_MP,
GiacMac_MT,
CungMac_MT,
CungMac_MP,
TienPhong_MP,
TienPhong_MT,
MongMat_MT,
MongMat_MP,
DongTuPhanXa_MP,
DongTuPhanXa_MT,
ThuyTinhThe_MT,
ThuyTinhThe_MP,
ThuyTinhDich_MT,
ThuyTinhDich_MP,
SoiAnhDongTu_MP,
SoiAnhDongTu_MT,
TinhHinhNhanCau_MT,
TinhHinhNhanCau_MP,
HocMat_MP,
HocMat_MT,
DayMat_MT,
DayMat_MP,
ToanThan,
NoiTiet,
ThanKinh,
TuanHoan,
HoHap,
TieuHoa,
CoXuongKhop,
ThanTietNieuSinhDuc,
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
ThiLucKhiRaVien_KhongKinh_MP,
 ThiLucKhiRaVien_KhongKinh_MT,
 ThiLucKhiRaVien_CoKinh_MP,
 ThiLucKhiRaVien_CoKinh_MT,
 NhanApRaVien_MT,
 NhanApRaVien_MP,
HuongDieuTriVaCacCheDoTiepTheo,
NguoiNhanHoSo,
NguoiGiaoHoSo,
NgayTongKet,
BacSyDieuTri,
 PhauThuat,
 ThuThuat,
ChanDoanBenhChinh_LamSang,
ChanDoanBenhChinh_NguyenNhan,
QuaTrinhDieuTri_NoiKhoa)
VALUES (
:MaQuanLy,
:LyDoVaoVien,
:VaoNgayThu,
:QuaTrinhBenhLy,
:TienSuBenhBanThan,
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
:TienSuBenhGiaDinh,
:BenhChuyenKhoa,
:ThiLucKhiVaoVien_KhongKinh_MP,
:ThiLucKhiVaoVien_KhongKinh_MT,
:ThiLucKhiVaoVien_CoKinh_MP,
:ThiLucKhiVaoVien_CoKinh_MT,
:NhanApVaoVien_MT,
:NhanApVaoVien_MP,
:ThiTruong_MP,
:ThiTruong_MT,
:LeDao_MP,
:LeDao_MT,
:MiMat_MP,
:MiMat_MT,
:KetMac_MP,
:KetMac_MT,
:TinhHinhMatHot_MP,
:TinhHinhMatHot_MT,
:GiacMac_MP,
:GiacMac_MT,
:CungMac_MT,
:CungMac_MP,
:TienPhong_MP,
:TienPhong_MT,
:MongMat_MT,
:MongMat_MP,
:DongTuPhanXa_MP,
:DongTuPhanXa_MT,
:ThuyTinhThe_MT,
:ThuyTinhThe_MP,
:ThuyTinhDich_MT,
:ThuyTinhDich_MP,
:SoiAnhDongTu_MP,
:SoiAnhDongTu_MT,
:TinhHinhNhanCau_MT,
:TinhHinhNhanCau_MP,
:HocMat_MP,
:HocMat_MT,
:DayMat_MT,
:DayMat_MP,
:ToanThan,
:NoiTiet,
:ThanKinh,
:TuanHoan,
:HoHap,
:TieuHoa,
:CoXuongKhop,
:ThanTietNieuSinhDuc,
:Khac_CacCoQuan,
:CacXetNghiemCanLamSangCanLam,
:TomTatBenhAn,
:BenhChinh,
:BenhKemTheo,
:PhanBiet,
:TienLuong,
:HuongDieuTri,
to_date(:NgayKhamBenh,
'yyyyMMddHH24mi'),
:BacSyLamBenhAn,
:QuaTrinhBenhLyVaDienBien,
:TomTatKetQuaXetNghiem,
:PhuongPhapDieuTri,
:TinhTrangNguoiBenhRaVien,
:ThiLucKhiRaVien_KhongKinh_MP,
:ThiLucKhiRaVien_KhongKinh_MT,
:ThiLucKhiRaVien_CoKinh_MP,
:ThiLucKhiRaVien_CoKinh_MT,
:NhanApRaVien_MT,
:NhanApRaVien_MP,
:HuongDieuTriVaCacCheDoTiepTheo,
:NguoiNhanHoSo,
:NguoiGiaoHoSo,
to_date(:NgayTongKet,
'yyyyMMddHH24mi'),
:BacSyDieuTri,
:PhauThuat,
:ThuThuat,
:ChanDoanBenhChinh_LamSang,
:ChanDoanBenhChinh_NguyenNhan,
:QuaTrinhDieuTri_NoiKhoa)";
            Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnNgoaiTruMat.MaQuanLy));
            Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnNgoaiTruMat.LyDoVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("VaoNgayThu", BenhAnNgoaiTruMat.VaoNgayThu));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnNgoaiTruMat.QuaTrinhBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhBanThan", BenhAnNgoaiTruMat.TienSuBenhBanThan));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng", BenhAnNgoaiTruMat.DacDiemLienQuanBenh.DiUng == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng_Text", BenhAnNgoaiTruMat.DacDiemLienQuanBenh.DiUng_Text));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy", BenhAnNgoaiTruMat.DacDiemLienQuanBenh.MaTuy == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy_Text", BenhAnNgoaiTruMat.DacDiemLienQuanBenh.MaTuy_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia", BenhAnNgoaiTruMat.DacDiemLienQuanBenh.RuouBia == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia_Text", BenhAnNgoaiTruMat.DacDiemLienQuanBenh.RuouBia_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa", BenhAnNgoaiTruMat.DacDiemLienQuanBenh.ThuocLa == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa_Text", BenhAnNgoaiTruMat.DacDiemLienQuanBenh.ThuocLa_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao", BenhAnNgoaiTruMat.DacDiemLienQuanBenh.ThuocLao == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao_Text", BenhAnNgoaiTruMat.DacDiemLienQuanBenh.ThuocLao_Text));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh", BenhAnNgoaiTruMat.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh_Text", BenhAnNgoaiTruMat.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhGiaDinh", BenhAnNgoaiTruMat.TienSuBenhGiaDinh));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChuyenKhoa", BenhAnNgoaiTruMat.BenhChuyenKhoa));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiVaoVien_KhongKinh_MP", BenhAnNgoaiTruMat.ThiLucKhiVaoVien_KhongKinh_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiVaoVien_KhongKinh_MT", BenhAnNgoaiTruMat.ThiLucKhiVaoVien_KhongKinh_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiVaoVien_CoKinh_MP", BenhAnNgoaiTruMat.ThiLucKhiVaoVien_CoKinh_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiVaoVien_CoKinh_MT", BenhAnNgoaiTruMat.ThiLucKhiVaoVien_CoKinh_MT));
            Command.Parameters.Add(new MDB.MDBParameter("NhanApVaoVien_MT", BenhAnNgoaiTruMat.NhanApVaoVien_MT));
            Command.Parameters.Add(new MDB.MDBParameter("NhanApVaoVien_MP", BenhAnNgoaiTruMat.NhanApVaoVien_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThiTruong_MP", BenhAnNgoaiTruMat.ThiTruong_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThiTruong_MT", BenhAnNgoaiTruMat.ThiTruong_MT));
            Command.Parameters.Add(new MDB.MDBParameter("LeDao_MP", BenhAnNgoaiTruMat.LeDao_MP));
            Command.Parameters.Add(new MDB.MDBParameter("LeDao_MT", BenhAnNgoaiTruMat.LeDao_MT));
            Command.Parameters.Add(new MDB.MDBParameter("MiMat_MP", BenhAnNgoaiTruMat.MiMat_MP));
            Command.Parameters.Add(new MDB.MDBParameter("MiMat_MT", BenhAnNgoaiTruMat.MiMat_MT));
            Command.Parameters.Add(new MDB.MDBParameter("KetMac_MP", BenhAnNgoaiTruMat.KetMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("KetMac_MT", BenhAnNgoaiTruMat.KetMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TinhHinhMatHot_MP", BenhAnNgoaiTruMat.TinhHinhMatHot_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TinhHinhMatHot_MT", BenhAnNgoaiTruMat.TinhHinhMatHot_MT));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_MP", BenhAnNgoaiTruMat.GiacMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_MT", BenhAnNgoaiTruMat.GiacMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("CungMac_MT", BenhAnNgoaiTruMat.CungMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("CungMac_MP", BenhAnNgoaiTruMat.CungMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TienPhong_MP", BenhAnNgoaiTruMat.TienPhong_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TienPhong_MT", BenhAnNgoaiTruMat.TienPhong_MT));
            Command.Parameters.Add(new MDB.MDBParameter("MongMat_MT", BenhAnNgoaiTruMat.MongMat_MT));
            Command.Parameters.Add(new MDB.MDBParameter("MongMat_MP", BenhAnNgoaiTruMat.MongMat_MP));
            Command.Parameters.Add(new MDB.MDBParameter("DongTuPhanXa_MP", BenhAnNgoaiTruMat.DongTuPhanXa_MP));
            Command.Parameters.Add(new MDB.MDBParameter("DongTuPhanXa_MT", BenhAnNgoaiTruMat.DongTuPhanXa_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ThuyTinhThe_MT", BenhAnNgoaiTruMat.ThuyTinhThe_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ThuyTinhThe_MP", BenhAnNgoaiTruMat.ThuyTinhThe_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThuyTinhDich_MT", BenhAnNgoaiTruMat.ThuyTinhDich_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ThuyTinhDich_MP", BenhAnNgoaiTruMat.ThuyTinhDich_MP));
            Command.Parameters.Add(new MDB.MDBParameter("SoiAnhDongTu_MP", BenhAnNgoaiTruMat.SoiAnhDongTu_MP));
            Command.Parameters.Add(new MDB.MDBParameter("SoiAnhDongTu_MT", BenhAnNgoaiTruMat.SoiAnhDongTu_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TinhHinhNhanCau_MT", BenhAnNgoaiTruMat.TinhHinhNhanCau_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TinhHinhNhanCau_MP", BenhAnNgoaiTruMat.TinhHinhNhanCau_MP));
            Command.Parameters.Add(new MDB.MDBParameter("HocMat_MP", BenhAnNgoaiTruMat.HocMat_MP));
            Command.Parameters.Add(new MDB.MDBParameter("HocMat_MT", BenhAnNgoaiTruMat.HocMat_MT));
            Command.Parameters.Add(new MDB.MDBParameter("DayMat_MT", BenhAnNgoaiTruMat.DayMat_MT));
            Command.Parameters.Add(new MDB.MDBParameter("DayMat_MP", BenhAnNgoaiTruMat.DayMat_MP));
            //Command.Parameters.Add(new MDB.MDBParameter("Mach", BenhAnNgoaiTruMat.DauSinhTon.Mach));
            //Command.Parameters.Add(new MDB.MDBParameter("NhietDo", BenhAnNgoaiTruMat.DauSinhTon.NhietDo));
            //Command.Parameters.Add(new MDB.MDBParameter("HuyetAp", BenhAnNgoaiTruMat.DauSinhTon.HuyetAp));
            //Command.Parameters.Add(new MDB.MDBParameter("NhipTho", BenhAnNgoaiTruMat.DauSinhTon.NhipTho));
            //Command.Parameters.Add(new MDB.MDBParameter("CanNang", BenhAnNgoaiTruMat.DauSinhTon.CanNang));
            Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnNgoaiTruMat.ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("NoiTiet", BenhAnNgoaiTruMat.NoiTiet));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinh", BenhAnNgoaiTruMat.ThanKinh));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoan", BenhAnNgoaiTruMat.TuanHoan));
            Command.Parameters.Add(new MDB.MDBParameter("HoHap", BenhAnNgoaiTruMat.HoHap));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoa", BenhAnNgoaiTruMat.TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop", BenhAnNgoaiTruMat.CoXuongKhop));
            Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieuSinhDuc", BenhAnNgoaiTruMat.ThanTietNieuSinhDuc));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_CacCoQuan", BenhAnNgoaiTruMat.Khac_CacCoQuan));
            Command.Parameters.Add(new MDB.MDBParameter("CacXetNghiemCanLamSangCanLam", BenhAnNgoaiTruMat.CacXetNghiemCanLamSangCanLam));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatBenhAn", BenhAnNgoaiTruMat.TomTatBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnNgoaiTruMat.BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnNgoaiTruMat.BenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("PhanBiet", BenhAnNgoaiTruMat.PhanBiet));
            Command.Parameters.Add(new MDB.MDBParameter("TienLuong", BenhAnNgoaiTruMat.TienLuong));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnNgoaiTruMat.HuongDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("NgayKhamBenh", BenhAnNgoaiTruMat.NgayKhamBenh.ToString("yyyyMMddHHmm")));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyLamBenhAn", BenhAnNgoaiTruMat.BacSyLamBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLyVaDienBien", BenhAnNgoaiTruMat.QuaTrinhBenhLyVaDienBien));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQuaXetNghiem", BenhAnNgoaiTruMat.TomTatKetQuaXetNghiem));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnNgoaiTruMat.PhuongPhapDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangNguoiBenhRaVien", BenhAnNgoaiTruMat.TinhTrangNguoiBenhRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiRaVien_KhongKinh_MP", BenhAnNgoaiTruMat.ThiLucKhiRaVien_KhongKinh_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiRaVien_KhongKinh_MT", BenhAnNgoaiTruMat.ThiLucKhiRaVien_KhongKinh_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiRaVien_CoKinh_MP", BenhAnNgoaiTruMat.ThiLucKhiRaVien_CoKinh_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiRaVien_CoKinh_MT", BenhAnNgoaiTruMat.ThiLucKhiRaVien_CoKinh_MT));
            Command.Parameters.Add(new MDB.MDBParameter("NhanApRaVien_MT", BenhAnNgoaiTruMat.NhanApRaVien_MT));
            Command.Parameters.Add(new MDB.MDBParameter("NhanApRaVien_MP", BenhAnNgoaiTruMat.NhanApRaVien_MP));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriVaCacCheDoTiepTheo", BenhAnNgoaiTruMat.HuongDieuTriVaCacCheDoTiepTheo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnNgoaiTruMat.NguoiNhanHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnNgoaiTruMat.NguoiGiaoHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnNgoaiTruMat.NgayTongKet.ToString("yyyyMMddHHmm")));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnNgoaiTruMat.BacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("PhauThuat", BenhAnNgoaiTruMat.PhauThuat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuThuat", BenhAnNgoaiTruMat.ThuThuat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanBenhChinh_LamSang", BenhAnNgoaiTruMat.ChanDoanBenhChinh_LamSang));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanBenhChinh_NguyenNhan", BenhAnNgoaiTruMat.ChanDoanBenhChinh_NguyenNhan));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhDieuTri_NoiKhoa", BenhAnNgoaiTruMat.QuaTrinhDieuTri_NoiKhoa));

            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool Update(MDB.MDBConnection MyConnection, BenhAnNgoaiTruMat BenhAnNgoaiTruMat)
        {
            string sql = @"UPDATE BenhAnNgoaiTruMat set LyDoVaoVien= :LyDoVaoVien ,
VaoNgayThu= :VaoNgayThu ,
QuaTrinhBenhLy= :QuaTrinhBenhLy ,
TienSuBenhBanThan= :TienSuBenhBanThan ,
DiUng= :DiUng ,
DiUng_Text= :DiUng_Text ,
MaTuy= :MaTuy ,
MaTuy_Text= :MaTuy_Text ,
RuouBia= :RuouBia ,
RuouBia_Text= :RuouBia_Text ,
ThuocLa= :ThuocLa ,
ThuocLa_Text= :ThuocLa_Text ,
ThuocLao= :ThuocLao ,
ThuocLao_Text= :ThuocLao_Text ,
Khac_DacDiemLienQuanBenh= :Khac_DacDiemLienQuanBenh ,
Khac_DacDiemLienQuanBenh_Text= :Khac_DacDiemLienQuanBenh_Text ,
TienSuBenhGiaDinh= :TienSuBenhGiaDinh ,
BenhChuyenKhoa= :BenhChuyenKhoa ,
ThiLucKhiVaoVien_KhongKinh_MP= :ThiLucKhiVaoVien_KhongKinh_MP ,
ThiLucKhiVaoVien_KhongKinh_MT= :ThiLucKhiVaoVien_KhongKinh_MT ,
ThiLucKhiVaoVien_CoKinh_MP= :ThiLucKhiVaoVien_CoKinh_MP ,
ThiLucKhiVaoVien_CoKinh_MT= :ThiLucKhiVaoVien_CoKinh_MT ,
NhanApVaoVien_MT= :NhanApVaoVien_MT ,
NhanApVaoVien_MP= :NhanApVaoVien_MP ,
ThiTruong_MP= :ThiTruong_MP ,
ThiTruong_MT= :ThiTruong_MT ,
LeDao_MP= :LeDao_MP ,
LeDao_MT= :LeDao_MT ,
MiMat_MP= :MiMat_MP ,
MiMat_MT= :MiMat_MT ,
KetMac_MP= :KetMac_MP ,
KetMac_MT= :KetMac_MT ,
TinhHinhMatHot_MP= :TinhHinhMatHot_MP ,
TinhHinhMatHot_MT= :TinhHinhMatHot_MT ,
GiacMac_MP= :GiacMac_MP ,
GiacMac_MT= :GiacMac_MT ,
CungMac_MT= :CungMac_MT ,
CungMac_MP= :CungMac_MP ,
TienPhong_MP= :TienPhong_MP ,
TienPhong_MT= :TienPhong_MT ,
MongMat_MT= :MongMat_MT ,
MongMat_MP= :MongMat_MP ,
DongTuPhanXa_MP= :DongTuPhanXa_MP ,
DongTuPhanXa_MT= :DongTuPhanXa_MT ,
ThuyTinhThe_MT= :ThuyTinhThe_MT ,
ThuyTinhThe_MP= :ThuyTinhThe_MP ,
ThuyTinhDich_MT= :ThuyTinhDich_MT ,
ThuyTinhDich_MP= : ThuyTinhDich_MP,SoiAnhDongTu_MP= :SoiAnhDongTu_MP ,
SoiAnhDongTu_MT= :SoiAnhDongTu_MT ,
TinhHinhNhanCau_MT= :TinhHinhNhanCau_MT ,
TinhHinhNhanCau_MP= :TinhHinhNhanCau_MP ,
HocMat_MP= :HocMat_MP ,
HocMat_MT= :HocMat_MT ,
DayMat_MT= :DayMat_MT ,
DayMat_MP= :DayMat_MP ,
ToanThan= :ToanThan ,
NoiTiet= :NoiTiet ,
ThanKinh= :ThanKinh ,
TuanHoan= :TuanHoan ,
HoHap= :HoHap ,
TieuHoa= :TieuHoa ,
CoXuongKhop= :CoXuongKhop ,
ThanTietNieuSinhDuc= :ThanTietNieuSinhDuc ,
Khac_CacCoQuan= :Khac_CacCoQuan ,
CacXetNghiemCanLamSangCanLam= :CacXetNghiemCanLamSangCanLam ,
TomTatBenhAn= :TomTatBenhAn ,
BenhChinh= :BenhChinh ,
BenhKemTheo= :BenhKemTheo ,
PhanBiet= :PhanBiet ,
TienLuong= :TienLuong ,
HuongDieuTri= :HuongDieuTri ,
NgayKhamBenh = to_date(:NgayKhamBenh,'yyyyMMddHH24mi') ,
BacSyLamBenhAn= :BacSyLamBenhAn ,
QuaTrinhBenhLyVaDienBien= :QuaTrinhBenhLyVaDienBien ,
TomTatKetQuaXetNghiem= :TomTatKetQuaXetNghiem ,
PhuongPhapDieuTri= :PhuongPhapDieuTri ,
TinhTrangNguoiBenhRaVien= :TinhTrangNguoiBenhRaVien ,
ThiLucKhiRaVien_KhongKinh_MP= :ThiLucKhiRaVien_KhongKinh_MP ,
 ThiLucKhiRaVien_KhongKinh_MT= :ThiLucKhiRaVien_KhongKinh_MT ,
 ThiLucKhiRaVien_CoKinh_MP= :ThiLucKhiRaVien_CoKinh_MP ,
 ThiLucKhiRaVien_CoKinh_MT= :ThiLucKhiRaVien_CoKinh_MT ,
 NhanApRaVien_MT= :NhanApRaVien_MT ,
 NhanApRaVien_MP= :NhanApRaVien_MP ,
HuongDieuTriVaCacCheDoTiepTheo= :HuongDieuTriVaCacCheDoTiepTheo ,
NguoiNhanHoSo= :NguoiNhanHoSo ,
NguoiGiaoHoSo= :NguoiGiaoHoSo ,
NgayTongKet= to_date(:NgayTongKet,'yyyyMMddHH24mi') ,
BacSyDieuTri =:BacSyDieuTri, PhauThuat =:PhauThuat, ThuThuat =:ThuThuat,
ChanDoanBenhChinh_LamSang = :ChanDoanBenhChinh_LamSang,
ChanDoanBenhChinh_NguyenNhan = :ChanDoanBenhChinh_NguyenNhan,
QuaTrinhDieuTri_NoiKhoa = :QuaTrinhDieuTri_NoiKhoa 
WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnNgoaiTruMat.LyDoVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("VaoNgayThu", BenhAnNgoaiTruMat.VaoNgayThu));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnNgoaiTruMat.QuaTrinhBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhBanThan", BenhAnNgoaiTruMat.TienSuBenhBanThan));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng", BenhAnNgoaiTruMat.DacDiemLienQuanBenh.DiUng == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng_Text", BenhAnNgoaiTruMat.DacDiemLienQuanBenh.DiUng_Text));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy", BenhAnNgoaiTruMat.DacDiemLienQuanBenh.MaTuy == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy_Text", BenhAnNgoaiTruMat.DacDiemLienQuanBenh.MaTuy_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia", BenhAnNgoaiTruMat.DacDiemLienQuanBenh.RuouBia == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia_Text", BenhAnNgoaiTruMat.DacDiemLienQuanBenh.RuouBia_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa", BenhAnNgoaiTruMat.DacDiemLienQuanBenh.ThuocLa == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa_Text", BenhAnNgoaiTruMat.DacDiemLienQuanBenh.ThuocLa_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao", BenhAnNgoaiTruMat.DacDiemLienQuanBenh.ThuocLao == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao_Text", BenhAnNgoaiTruMat.DacDiemLienQuanBenh.ThuocLao_Text));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh", BenhAnNgoaiTruMat.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh_Text", BenhAnNgoaiTruMat.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhGiaDinh", BenhAnNgoaiTruMat.TienSuBenhGiaDinh));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChuyenKhoa", BenhAnNgoaiTruMat.BenhChuyenKhoa));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiVaoVien_KhongKinh_MP", BenhAnNgoaiTruMat.ThiLucKhiVaoVien_KhongKinh_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiVaoVien_KhongKinh_MT", BenhAnNgoaiTruMat.ThiLucKhiVaoVien_KhongKinh_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiVaoVien_CoKinh_MP", BenhAnNgoaiTruMat.ThiLucKhiVaoVien_CoKinh_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiVaoVien_CoKinh_MT", BenhAnNgoaiTruMat.ThiLucKhiVaoVien_CoKinh_MT));
            Command.Parameters.Add(new MDB.MDBParameter("NhanApVaoVien_MT", BenhAnNgoaiTruMat.NhanApVaoVien_MT));
            Command.Parameters.Add(new MDB.MDBParameter("NhanApVaoVien_MP", BenhAnNgoaiTruMat.NhanApVaoVien_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThiTruong_MP", BenhAnNgoaiTruMat.ThiTruong_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThiTruong_MT", BenhAnNgoaiTruMat.ThiTruong_MT));
            Command.Parameters.Add(new MDB.MDBParameter("LeDao_MP", BenhAnNgoaiTruMat.LeDao_MP));
            Command.Parameters.Add(new MDB.MDBParameter("LeDao_MT", BenhAnNgoaiTruMat.LeDao_MT));
            Command.Parameters.Add(new MDB.MDBParameter("MiMat_MP", BenhAnNgoaiTruMat.MiMat_MP));
            Command.Parameters.Add(new MDB.MDBParameter("MiMat_MT", BenhAnNgoaiTruMat.MiMat_MT));
            Command.Parameters.Add(new MDB.MDBParameter("KetMac_MP", BenhAnNgoaiTruMat.KetMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("KetMac_MT", BenhAnNgoaiTruMat.KetMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TinhHinhMatHot_MP", BenhAnNgoaiTruMat.TinhHinhMatHot_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TinhHinhMatHot_MT", BenhAnNgoaiTruMat.TinhHinhMatHot_MT));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_MP", BenhAnNgoaiTruMat.GiacMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_MT", BenhAnNgoaiTruMat.GiacMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("CungMac_MT", BenhAnNgoaiTruMat.CungMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("CungMac_MP", BenhAnNgoaiTruMat.CungMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TienPhong_MP", BenhAnNgoaiTruMat.TienPhong_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TienPhong_MT", BenhAnNgoaiTruMat.TienPhong_MT));
            Command.Parameters.Add(new MDB.MDBParameter("MongMat_MT", BenhAnNgoaiTruMat.MongMat_MT));
            Command.Parameters.Add(new MDB.MDBParameter("MongMat_MP", BenhAnNgoaiTruMat.MongMat_MP));
            Command.Parameters.Add(new MDB.MDBParameter("DongTuPhanXa_MP", BenhAnNgoaiTruMat.DongTuPhanXa_MP));
            Command.Parameters.Add(new MDB.MDBParameter("DongTuPhanXa_MT", BenhAnNgoaiTruMat.DongTuPhanXa_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ThuyTinhThe_MT", BenhAnNgoaiTruMat.ThuyTinhThe_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ThuyTinhThe_MP", BenhAnNgoaiTruMat.ThuyTinhThe_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThuyTinhDich_MT", BenhAnNgoaiTruMat.ThuyTinhDich_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ThuyTinhDich_MP", BenhAnNgoaiTruMat.ThuyTinhDich_MP));
            Command.Parameters.Add(new MDB.MDBParameter("SoiAnhDongTu_MP", BenhAnNgoaiTruMat.SoiAnhDongTu_MP));
            Command.Parameters.Add(new MDB.MDBParameter("SoiAnhDongTu_MT", BenhAnNgoaiTruMat.SoiAnhDongTu_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TinhHinhNhanCau_MT", BenhAnNgoaiTruMat.TinhHinhNhanCau_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TinhHinhNhanCau_MP", BenhAnNgoaiTruMat.TinhHinhNhanCau_MP));
            Command.Parameters.Add(new MDB.MDBParameter("HocMat_MP", BenhAnNgoaiTruMat.HocMat_MP));
            Command.Parameters.Add(new MDB.MDBParameter("HocMat_MT", BenhAnNgoaiTruMat.HocMat_MT));
            Command.Parameters.Add(new MDB.MDBParameter("DayMat_MT", BenhAnNgoaiTruMat.DayMat_MT));
            Command.Parameters.Add(new MDB.MDBParameter("DayMat_MP", BenhAnNgoaiTruMat.DayMat_MP));
            //Command.Parameters.Add(new MDB.MDBParameter("Mach", BenhAnNgoaiTruMat.DauSinhTon.Mach));
            //Command.Parameters.Add(new MDB.MDBParameter("NhietDo", BenhAnNgoaiTruMat.DauSinhTon.NhietDo));
            //Command.Parameters.Add(new MDB.MDBParameter("HuyetAp", BenhAnNgoaiTruMat.DauSinhTon.HuyetAp));
            //Command.Parameters.Add(new MDB.MDBParameter("NhipTho", BenhAnNgoaiTruMat.DauSinhTon.NhipTho));
            //Command.Parameters.Add(new MDB.MDBParameter("CanNang", BenhAnNgoaiTruMat.DauSinhTon.CanNang));
            Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnNgoaiTruMat.ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("NoiTiet", BenhAnNgoaiTruMat.NoiTiet));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinh", BenhAnNgoaiTruMat.ThanKinh));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoan", BenhAnNgoaiTruMat.TuanHoan));
            Command.Parameters.Add(new MDB.MDBParameter("HoHap", BenhAnNgoaiTruMat.HoHap));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoa", BenhAnNgoaiTruMat.TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop", BenhAnNgoaiTruMat.CoXuongKhop));
            Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieuSinhDuc", BenhAnNgoaiTruMat.ThanTietNieuSinhDuc));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_CacCoQuan", BenhAnNgoaiTruMat.Khac_CacCoQuan));
            Command.Parameters.Add(new MDB.MDBParameter("CacXetNghiemCanLamSangCanLam", BenhAnNgoaiTruMat.CacXetNghiemCanLamSangCanLam));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatBenhAn", BenhAnNgoaiTruMat.TomTatBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnNgoaiTruMat.BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnNgoaiTruMat.BenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("PhanBiet", BenhAnNgoaiTruMat.PhanBiet));
            Command.Parameters.Add(new MDB.MDBParameter("TienLuong", BenhAnNgoaiTruMat.TienLuong));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnNgoaiTruMat.HuongDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("NgayKhamBenh", BenhAnNgoaiTruMat.NgayKhamBenh.ToString("yyyyMMddHHmm")));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyLamBenhAn", BenhAnNgoaiTruMat.BacSyLamBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLyVaDienBien", BenhAnNgoaiTruMat.QuaTrinhBenhLyVaDienBien));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQuaXetNghiem", BenhAnNgoaiTruMat.TomTatKetQuaXetNghiem));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnNgoaiTruMat.PhuongPhapDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangNguoiBenhRaVien", BenhAnNgoaiTruMat.TinhTrangNguoiBenhRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiRaVien_KhongKinh_MP", BenhAnNgoaiTruMat.ThiLucKhiRaVien_KhongKinh_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiRaVien_KhongKinh_MT", BenhAnNgoaiTruMat.ThiLucKhiRaVien_KhongKinh_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiRaVien_CoKinh_MP", BenhAnNgoaiTruMat.ThiLucKhiRaVien_CoKinh_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiRaVien_CoKinh_MT", BenhAnNgoaiTruMat.ThiLucKhiRaVien_CoKinh_MT));
            Command.Parameters.Add(new MDB.MDBParameter("NhanApRaVien_MT", BenhAnNgoaiTruMat.NhanApRaVien_MT));
            Command.Parameters.Add(new MDB.MDBParameter("NhanApRaVien_MP", BenhAnNgoaiTruMat.NhanApRaVien_MP));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriVaCacCheDoTiepTheo", BenhAnNgoaiTruMat.HuongDieuTriVaCacCheDoTiepTheo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnNgoaiTruMat.NguoiNhanHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnNgoaiTruMat.NguoiGiaoHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnNgoaiTruMat.NgayTongKet.ToString("yyyyMMddHHmm")));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnNgoaiTruMat.BacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("PhauThuat", BenhAnNgoaiTruMat.PhauThuat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuThuat", BenhAnNgoaiTruMat.ThuThuat == true ? "1" : "0"));

            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanBenhChinh_LamSang", BenhAnNgoaiTruMat.ChanDoanBenhChinh_LamSang));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanBenhChinh_NguyenNhan", BenhAnNgoaiTruMat.ChanDoanBenhChinh_NguyenNhan));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhDieuTri_NoiKhoa", BenhAnNgoaiTruMat.QuaTrinhDieuTri_NoiKhoa));

            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnNgoaiTruMat.MaQuanLy));
            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool Delete(MDB.MDBConnection MyConnection, BenhAnNgoaiTruMat BenhAnNgoaiTruMat)
        {
            string sql = @"DELETE FROM BenhAnNgoaiTruMat
                           WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnNgoaiTruMat.MaQuanLy));

            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
    }
}
