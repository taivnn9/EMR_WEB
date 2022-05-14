using HIS;
using System.Data;
using System.Globalization;

namespace EMR_MAIN
{
    public class BenhAnMatTreEmFunc
    {
        public static void WriteXml(MDB.MDBConnection MyConnection)
        {
            string sql =
                   @"
                  select  a.*,  CTScanner HoSo_CTScanner, SieuAm HoSo_SieuAm, XetNghiem HoSo_XetNghiem,  Khac HoSo_Khac,  Khac_Text HoSo_Khac_Text,  ToanBoHoSo HoSo_ToanBoHoSo, Mach DauSinhTon_Mach,  NhietDo DauSinhTon_NhietDo,  HuyetAp DauSinhTon_HuyetAp,  NhipTho DauSinhTon_NhipTho,  CanNang DauSinhTon_CanNang  
                  from BenhAnMatTreEm a inner join thongtindieutri b on a.maquanly = b.maquanly
                  where rownum = 1
                    ";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            var DataTable = new DataTable { TableName = "BenhAnMatTreEm" };
            DataTable.Load(DataReader as IDataReader);
            DataTable.WriteXml("rptBenhAnMatTreEm.xml");
        }
        public static DataSet SelectDataSet(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql =
                   @"
                 select  a.*,f.hovaten BacSyLamBenhAnHoVaTen ,c.hovaten BacSyDieuTriHoVaTen,d.hovaten NguoiGiaoHoSoHoVaTen,e.hovaten NguoiNhanHoSoHoVaTen, b.XQuang HoSo_XQuang,   b.CTScanner HoSo_CTScanner, b.SieuAm HoSo_SieuAm, b.XetNghiem HoSo_XetNghiem,  b.Khac HoSo_Khac,  b.Khac_Text HoSo_Khac_Text,  b.ToanBoHoSo HoSo_ToanBoHoSo, b.Mach DauSinhTon_Mach, b.NhietDo DauSinhTon_NhietDo,  b.HuyetAp DauSinhTon_HuyetAp,  b.NhipTho DauSinhTon_NhipTho,  b.CanNang DauSinhTon_CanNang  , b.ChieuCao DauSinhTon_ChieuCao, b.BMI DauSinhTon_BMI, b.NgayRaVien 
                 from BenhAnMatTreEm a 
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
                  where a.maquanly = " + MaQuanLy.ToString(CultureInfo.InvariantCulture);
            adt = new MDB.MDBDataAdapter(sql2, MyConnection);
            adt.Fill(ds, "Table2");
            return ds;
        }
        public static BenhAnMatTreEm Select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            #region
            string sql =
                      @"select * 
                        from BenhAnMatTreEm a
                        where MaQuanLy = :MaQuanLy";
            #endregion
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            var value = new BenhAnMatTreEm();
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
                value.NguyenNhan_BamSinh = DataReader["NguyenNhan_BamSinh"].ToString() == "1" ? true : false;
                value.NguyenNhan_TuBaoGio = DataReader["NguyenNhan_TuBaoGio"].ToString();
                value.TrieuChung_NhinMo = DataReader["TrieuChung_NhinMo"].ToString() == "1" ? true : false;
                value.TrieuChung_DauNhuc = DataReader["TrieuChung_DauNhuc"].ToString() == "1" ? true : false;
                value.TrieuChung_DoMat = DataReader["TrieuChung_DoMat"].ToString() == "1" ? true : false;
                value.TrieuChung_ChoiMat = DataReader["TrieuChung_ChoiMat"].ToString() == "1" ? true : false;
                value.TienSuBenhBanThan_Tick = DataReader["TienSuBenhBanThan_Tick"].ToString() == "1" ? true : false;
                value.TienSuBenhGiaDinh_Tick = DataReader["TienSuBenhGiaDinh_Tick"].ToString() == "1" ? true : false;
                value.TienSuThaiNghenBenhLy = DataReader["TienSuThaiNghenBenhLy"].ToString() == "1" ? true : false;
                value.TienSuThaiNghenBenhLy_Text = DataReader["TienSuThaiNghenBenhLy_Text"].ToString();
                value.PhatTrienTriTue = DataReader["PhatTrienTriTue"].ToString() == "1" ? true : false;
                value.PhatTrienTriTue_BenhLyText = DataReader["PhatTrienTriTue_BenhLyText"].ToString();
                value.ThiLucKhiVaoVien_KhongKinh_MP = DataReader["ThiLucKhiVaoVien_KhongKinh_MP"].ToString();
                value.ThiLucKhiVaoVien_KhongKinh_MT = DataReader["ThiLucKhiVaoVien_KhongKinh_MT"].ToString();
                value.ThiLucKhiVaoVien_CoKinh_MP = DataReader["ThiLucKhiVaoVien_CoKinh_MP"].ToString();
                value.ThiLucKhiVaoVien_CoKinh_MT = DataReader["ThiLucKhiVaoVien_CoKinh_MT"].ToString();
                value.NhanApVaoVien_MT = DataReader["NhanApVaoVien_MT"].ToString();
                value.NhanApVaoVien_MP = DataReader["NhanApVaoVien_MP"].ToString();
                value.ThiTruong_MP = DataReader["ThiTruong_MP"].ToString();
                value.ThiTruong_MT = DataReader["ThiTruong_MT"].ToString();
                value.VanNhanNoiTai_MP = DataReader["VanNhanNoiTai_MP"].ToString() == "1" ? true : false;
                value.VanNhanNoiTai_Text_MP = DataReader["VanNhanNoiTai_Text_MP"].ToString();
                value.VanNhanNoiTai_MT = DataReader["VanNhanNoiTai_MT"].ToString() == "1" ? true : false;
                value.VanNhanNoiTai_Text_MT = DataReader["VanNhanNoiTai_Text_MT"].ToString();
                value.VanNhanNgoaiLai_MP = DataReader["VanNhanNgoaiLai_MP"].ToString() == "1" ? true : false;
                value.VanNhanNgoaiLai_Text_MP = DataReader["VanNhanNgoaiLai_Text_MP"].ToString();
                value.VanNhanNgoaiLai_MT = DataReader["VanNhanNgoaiLai_MT"].ToString() == "1" ? true : false;
                value.VanNhanNgoaiLai_Text_MT = DataReader["VanNhanNgoaiLai_Text_MT"].ToString();
                value.RungGiatNhanCau = DataReader["RungGiatNhanCau"].ToString() == "1" ? true : false;
                value.RungGiatNhanCau_Text = DataReader["RungGiatNhanCau_Text"].ToString();
                value.MiMat_Quam_MP = DataReader["MiMat_Quam_MP"].ToString() == "1" ? true : false;
                value.MIMat_Epicanthus = DataReader["MIMat_Epicanthus"].ToString() == "1" ? true : false;
                value.MiMat_SupMi_MP = DataReader["MiMat_SupMi_MP"].ToString() == "1" ? true : false;
                value.MiMat_U_MP = DataReader["MiMat_U_MP"].ToString() == "1" ? true : false;
                value.MiMat_Khac_MP = DataReader["MiMat_Khac_MP"].ToString();
                value.LeDao_MP = DataReader["LeDao_MP"].ToString();
                value.KetMac_CuongTu_MP = DataReader["KetMac_CuongTu_MP"].ToString() == "1" ? true : false;
                value.KetMac_XuatHuyet_MP = DataReader["KetMac_XuatHuyet_MP"].ToString() == "1" ? true : false;
                value.KetMac_XuatTiet_MP = DataReader["KetMac_XuatTiet_MP"].ToString() == "1" ? true : false;
                value.KetMac_U_MP = DataReader["KetMac_U_MP"].ToString() == "1" ? true : false;
                value.KetMac_Khac_MP = DataReader["KetMac_Khac_MP"].ToString();
                value.GiacMac_Trong_MP = DataReader["GiacMac_Trong_MP"].ToString() == "1" ? true : false;
                value.GiacMac_Trong_Text_MP = DataReader["GiacMac_Trong_Text_MP"].ToString();
                value.GiacMac_LoaiDuong_MP = DataReader["GiacMac_LoaiDuong_MP"].ToString() == "1" ? true : false;
                value.GiacMac_LoanDuong_Text_MP = DataReader["GiacMac_LoanDuong_Text_MP"].ToString();
                value.GiacMac_ThoaiHoa_MP = DataReader["GiacMac_ThoaiHoa_MP"].ToString() == "1" ? true : false;
                value.GiacMac_ThoaiHoa_Text_MP = DataReader["GiacMac_ThoaiHoa_Text_MP"].ToString();
                value.GiacMac_PhuNe_MP = DataReader["GiacMac_PhuNe_MP"].ToString();
                value.GiacMac_U_MP = DataReader["GiacMac_U_MP"].ToString();
                value.GiacMac_Tua_MP = DataReader["GiacMac_Tua_MP"].ToString();
                value.GiacMac_Loet_MP = DataReader["GiacMac_Loet_MP"].ToString();
                value.GiacMac_DiTat_MP = DataReader["GiacMac_DiTat_MP"].ToString();
                value.GiacMac_DuongKinhGM_MP = DataReader["GiacMac_DuongKinhGM_MP"].ToString();
                value.GiacMac_VungRia_MP = DataReader["GiacMac_VungRia_MP"].ToString();
                value.GiacMac_Khac_MP = DataReader["GiacMac_Khac_MP"].ToString();
                value.CungMac_GianLoi_MP = DataReader["CungMac_GianLoi_MP"].ToString() == "1" ? true : false;
                value.CungMac_SeoMo_MP = DataReader["CungMac_SeoMo_MP"].ToString() == "1" ? true : false;
                value.CungMac_CuongTu_MP = DataReader["CungMac_CuongTu_MP"].ToString();
                value.CungMac_Viem_MP = DataReader["CungMac_Viem_MP"].ToString();
                value.CungMac_Khac_MP = DataReader["CungMac_Khac_MP"].ToString();
                value.TienPhong_DoSau_MP = DataReader["TienPhong_DoSau_MP"].ToString();
                value.TienPhong_Tydall_MP = DataReader["TienPhong_Tydall_MP"].ToString() == "1" ? true : false;
                value.TienPhong_Mu_MP = DataReader["TienPhong_Mu_MP"].ToString() == "1" ? true : false;
                value.TienPhong_Mau_MP = DataReader["TienPhong_Mau_MP"].ToString();
                value.TienPhong_GocTienPhong_MP = DataReader["TienPhong_GocTienPhong_MP"].ToString();
                value.MongMat_MP = DataReader["MongMat_MP"].ToString();
                value.MongMat_MauSac_MP = DataReader["MongMat_MauSac_MP"].ToString();
                value.MongMat_TinhTrang_MP = DataReader["MongMat_TinhTrang_MP"].ToString() == "1" ? true : false;
                value.MongMat_TanMach_MP = DataReader["MongMat_TanMach_MP"].ToString() == "1" ? true : false;
                value.MongMat_CamGiac_MP = DataReader["MongMat_CamGiac_MP"].ToString() == "1" ? true : false;
                value.MongMat_U_MP = DataReader["MongMat_U_MP"].ToString();
                value.MongMat_DiDang_MP = DataReader["MongMat_DiDang_MP"].ToString();
                value.DongTu_Trong_MP = Convert.ToInt32(DataReader["DongTu_Trong_MP"].ToString());
                value.DongTu_DuongKinh_MP = DataReader["DongTu_DuongKinh_MP"].ToString();
                value.DongTu_VienSacTo_MP = DataReader["DongTu_VienSacTo_MP"].ToString();
                value.DongTu_PhanXa_MP = DataReader.GetInt("DongTu_PhanXa_MP");
                value.DongTu_DiDang_MP = DataReader["DongTu_DiDang_MP"].ToString();
                value.TheThuyTinh_MP = DataReader.GetInt("TheThuyTinh_MP");
                value.DichKinh_MP = DataReader["DichKinh_MP"].ToString() == "1" ? true : false;
                value.DichKinh_Text_MP = DataReader["DichKinh_Text_MP"].ToString();
                value.DayMat_VongMac_MP = DataReader["DayMat_VongMac_MP"].ToString();
                value.DayMat_HoangDiem_MP = DataReader["DayMat_HoangDiem_MP"].ToString();
                value.DayMat_MachMau_MP = DataReader["DayMat_MachMau_MP"].ToString();
                value.DayMat_DiaThi_MP = DataReader["DayMat_DiaThi_MP"].ToString();
                value.DayMat_U_MP = DataReader["DayMat_U_MP"].ToString();
                value.NhanCau_Mem_MP = DataReader["NhanCau_Mem_MP"].ToString() == "1" ? true : false;
                value.NhanCau_To_MP = DataReader.GetInt("NhanCau_To_MP");
                value.MiMat_Quam_MT = DataReader["MiMat_Quam_MT"].ToString() == "1" ? true : false;
                value.MIMat_EpicanthusMT = DataReader["MIMat_EpicanthusMT"].ToString() == "1" ? true : false;
                value.MiMat_SupMi_MT = DataReader["MiMat_SupMi_MT"].ToString() == "1" ? true : false;
                value.MiMat_U_MT = DataReader["MiMat_U_MT"].ToString() == "1" ? true : false;
                value.MiMat_Khac_MT = DataReader["MiMat_Khac_MT"].ToString();
                value.LeDao_MT = DataReader["LeDao_MT"].ToString();
                value.KetMac_CuongTu_MT = DataReader["KetMac_CuongTu_MT"].ToString() == "1" ? true : false;
                value.KetMac_XuatHuyet_MT = DataReader["KetMac_XuatHuyet_MT"].ToString() == "1" ? true : false;
                value.KetMac_XuatTiet_MT = DataReader["KetMac_XuatTiet_MT"].ToString() == "1" ? true : false;
                value.KetMac_U_MT = DataReader["KetMac_U_MT"].ToString() == "1" ? true : false;
                value.KetMac_Khac_MT = DataReader["KetMac_Khac_MT"].ToString();
                value.GiacMac_Trong_MT = DataReader["GiacMac_Trong_MT"].ToString() == "1" ? true : false;
                value.GiacMac_Trong_Text_MT = DataReader["GiacMac_Trong_Text_MT"].ToString();
                value.GiacMac_LoaiDuong_MT = DataReader["GiacMac_LoaiDuong_MT"].ToString() == "1" ? true : false;
                value.GiacMac_LoanDuong_Text_MT = DataReader["GiacMac_LoanDuong_Text_MT"].ToString();
                value.GiacMac_ThoaiHoa_MT = DataReader["GiacMac_ThoaiHoa_MT"].ToString() == "1" ? true : false;
                value.GiacMac_ThoaiHoa_Text_MT = DataReader["GiacMac_ThoaiHoa_Text_MT"].ToString();
                value.GiacMac_PhuNe_MT = DataReader["GiacMac_PhuNe_MT"].ToString();
                value.GiacMac_U_MT = DataReader["GiacMac_U_MT"].ToString();
                value.GiacMac_Tua_MT = DataReader["GiacMac_Tua_MT"].ToString();
                value.GiacMac_Loet_MT = DataReader["GiacMac_Loet_MT"].ToString();
                value.GiacMac_DiTat_MT = DataReader["GiacMac_DiTat_MT"].ToString();
                value.GiacMac_DuongKinhGM_MT = DataReader["GiacMac_DuongKinhGM_MT"].ToString();
                value.GiacMac_VungRia_MT = DataReader["GiacMac_VungRia_MT"].ToString();
                value.GiacMac_Khac_MT = DataReader["GiacMac_Khac_MT"].ToString();
                value.CungMac_GianLoi_MT = DataReader["CungMac_GianLoi_MT"].ToString() == "1" ? true : false;
                value.CungMac_SeoMo_MT = DataReader["CungMac_SeoMo_MT"].ToString() == "1" ? true : false;
                value.CungMac_CuongTu_MT = DataReader["CungMac_CuongTu_MT"].ToString();
                value.CungMac_Viem_MT = DataReader["CungMac_Viem_MT"].ToString();
                value.CungMac_Khac_MT = DataReader["CungMac_Khac_MT"].ToString();
                value.TienPhong_DoSau_MT = DataReader["TienPhong_DoSau_MT"].ToString();
                value.TienPhong_Tydall_MT = DataReader["TienPhong_Tydall_MT"].ToString() == "1" ? true : false;
                value.TienPhong_Mu_MT = DataReader["TienPhong_Mu_MT"].ToString() == "1" ? true : false;
                value.TienPhong_Mau_MT = DataReader["TienPhong_Mau_MT"].ToString();
                value.TienPhong_GocTienPhong_MT = DataReader["TienPhong_GocTienPhong_MT"].ToString();
                value.MongMat_MT = DataReader["MongMat_MT"].ToString();
                value.MongMat_MauSac_MT = DataReader["MongMat_MauSac_MT"].ToString();
                value.MongMat_TinhTrang_MT = DataReader["MongMat_TinhTrang_MT"].ToString() == "1" ? true : false;
                value.MongMat_TanMach_MT = DataReader["MongMat_TanMach_MT"].ToString() == "1" ? true : false;
                value.MongMat_CamGiac_MT = DataReader["MongMat_CamGiac_MT"].ToString() == "1" ? true : false;
                value.MongMat_U_MT = DataReader["MongMat_U_MT"].ToString();
                value.MongMat_DiDang_MT = DataReader["MongMat_DiDang_MT"].ToString();
                value.DongTu_Trong_MT = Convert.ToInt32(DataReader["DongTu_Trong_MT"].ToString());
                value.DongTu_DuongKinh_MT = DataReader["DongTu_DuongKinh_MT"].ToString();
                value.DongTu_VienSacTo_MT = DataReader["DongTu_VienSacTo_MT"].ToString();
                value.DongTu_PhanXa_MT = DataReader.GetInt("DongTu_PhanXa_MT");
                value.DongTu_DiDang_MT = DataReader["DongTu_DiDang_MT"].ToString();
                value.TheThuyTinh_MT = DataReader.GetInt("TheThuyTinh_MT");
                value.DichKinh_MT = DataReader["DichKinh_MT"].ToString() == "1" ? true : false;
                value.DichKinh_Text_MT = DataReader["DichKinh_Text_MT"].ToString();
                value.DayMat_VongMac_MT = DataReader["DayMat_VongMac_MT"].ToString();
                value.DayMat_HoangDiem_MT = DataReader["DayMat_HoangDiem_MT"].ToString();
                value.DayMat_MachMau_MT = DataReader["DayMat_MachMau_MT"].ToString();
                value.DayMat_DiaThi_MT = DataReader["DayMat_DiaThi_MT"].ToString();
                value.DayMat_U_MT = DataReader["DayMat_U_MT"].ToString();
                value.NhanCau_Mem_MT = DataReader["NhanCau_Mem_MT"].ToString() == "1" ? true : false;
                value.NhanCau_To_MT = DataReader.GetInt("NhanCau_To_MT");
                value.HuyetAp_ToanThan = DataReader["HuyetAp_ToanThan"].ToString();
                value.NhietDo_ToanThan = DataReader["NhietDo_ToanThan"].ToString();
                value.Mach_ToanThan = DataReader["Mach_ToanThan"].ToString();
                value.NoiTiet_Tick = DataReader["NoiTiet_Tick"].ToString() == "1" ? true : false;
                value.NoiTiet = DataReader["NoiTiet"].ToString();
                value.ThanKinh_Tick = DataReader["ThanKinh_Tick"].ToString() == "1" ? true : false;
                value.TuanHoan_Tick = DataReader["TuanHoan_Tick"].ToString() == "1" ? true : false;
                value.HoHap_Tick = DataReader["HoHap_Tick"].ToString() == "1" ? true : false;
                value.TieuHoa_Tick = DataReader["TieuHoa_Tick"].ToString() == "1" ? true : false;
                value.CoXuongKhop_Tick = DataReader["CoXuongKhop_Tick"].ToString() == "1" ? true : false;
                value.ThanTietNieu_Tick = DataReader["ThanTietNieu_Tick"].ToString() == "1" ? true : false;
                value.BenhChinh_MatPhai = DataReader["BenhChinh_MatPhai"].ToString();
                value.BenhChinh_MatTrai = DataReader["BenhChinh_MatTrai"].ToString();
                value.PhuongPhapChinh = DataReader["PhuongPhapChinh"].ToString();
                value.CheDoAnUong = DataReader["CheDoAnUong"].ToString();
                value.CheDoChamSoc = DataReader["CheDoChamSoc"].ToString();
                value.ChanDoanBenhChinh_LamSang = DataReader["ChanDoanBenhChinh_LamSang"].ToString();
                value.ChanDoanBenhChinh_NguyenNhan = DataReader["ChanDoanBenhChinh_NguyenNhan"].ToString();
                value.QuaTrinhDieuTri_NoiKhoa = DataReader["QuaTrinhDieuTri_NoiKhoa"].ToString();
                value.QuaTrinhDieuTri_KetQua = DataReader["QuaTrinhDieuTri_KetQua"].ToString();
                value.QuaTrinhDieuTri_BienChung = DataReader["QuaTrinhDieuTri_BienChung"].ToString();
                value.HuongDieuTriTiep = DataReader["HuongDieuTriTiep"].ToString();
                value.DaDieuTri_NoiKhoa = DataReader["DaDieuTri_NoiKhoa"].ToString() == "1" ? true : false;
                value.DaDieuTri_PhauThuat = DataReader["DaDieuTri_PhauThuat"].ToString();
                value.MaSoKyTen = DataReader["masokyten"].ToString();
                value.MaSoKyTen_KB = DataReader["masokyten_kb"].ToString();
                value.MaSoKyTen_TK = DataReader["masokyten_tk"].ToString();
                value.ChuaThayBenhLy = DataReader["ChuaThayBenhLy"].ToString().Equals("1") ? true : false;
                value.BenhLy = DataReader["BenhLy"].ToString().Equals("1") ? true : false;
                value.BenhLy_Text = DataReader["BenhLy_Text"].ToString();
                value.PhauThuat = DataReader["PhauThuat"].ToString() == "1" ? true : false;
                value.ThuThuat = DataReader["ThuThuat"].ToString() == "1" ? true : false;
                value.ThiLucKhiRaVien_KhongKinh_MP = DataReader["ThiLucKhiRaVien_KhongKinh_MP"].ToString();
                value.ThiLucKhiRaVien_KhongKinh_MT = DataReader["ThiLucKhiRaVien_KhongKinh_MT"].ToString();
                value.ThiLucKhiRaVien_CoKinh_MP = DataReader["ThiLucKhiRaVien_CoKinh_MP"].ToString();
                value.ThiLucKhiRaVien_CoKinh_MT = DataReader["ThiLucKhiRaVien_CoKinh_MT"].ToString();
                value.NhanApRaVien_MP = DataReader["NhanApRaVien_MP"].ToString();
                value.NhanApRaVien_MT = DataReader["NhanApRaVien_MT"].ToString();

                int tempInt = 0;
                value.NoiTietCheck = int.TryParse(DataReader["NoiTietCheck"].ToString(), out tempInt) ? tempInt : 0;
                value.NoiTiet_Text = DataReader["NoiTiet_Text"].ToString();

                tempInt = 0;
                value.ThanKinhCheck = int.TryParse(DataReader["ThanKinhCheck"].ToString(), out tempInt) ? tempInt : 0;
                value.ThanKinh_Text = DataReader["ThanKinh_Text"].ToString();

                tempInt = 0;
                value.TuanHoanCheck = int.TryParse(DataReader["TuanHoanCheck"].ToString(), out tempInt) ? tempInt : 0;
                value.TuanHoan_Text = DataReader["TuanHoan_Text"].ToString();

                tempInt = 0;
                value.HoHapCheck = int.TryParse(DataReader["HoHapCheck"].ToString(), out tempInt) ? tempInt : 0;
                value.HoHap_Text = DataReader["HoHap_Text"].ToString();

                tempInt = 0;
                value.TieuHoaCheck = int.TryParse(DataReader["TieuHoaCheck"].ToString(), out tempInt) ? tempInt : 0;
                value.TieuHoa_Text = DataReader["TieuHoa_Text"].ToString();

                tempInt = 0;
                value.CoXuongKhopCheck = int.TryParse(DataReader["CoXuongKhopCheck"].ToString(), out tempInt) ? tempInt : 0;
                value.CoXuongKhop_Text = DataReader["CoXuongKhop_Text"].ToString();

                tempInt = 0;
                value.TietNieuSinhDucCheck = int.TryParse(DataReader["TietNieuSinhDucCheck"].ToString(), out tempInt) ? tempInt : 0;
                value.TietNieuSinhDuc_Text = DataReader["TietNieuSinhDuc_Text"].ToString();

                value.KhamBenhToanThan_Khac = DataReader["KhamBenhToanThan_Khac"].ToString();
            }
            return value;
        }

        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, BenhAnMatTreEm BenhAnMatTreEm)
        {
            string sql =
                      @"select MaQuanLy 
                        from BenhAnMatTreEm
                        where MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnMatTreEm.MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            int rowCount = 0;
            while (DataReader.Read()) rowCount++;
            if (rowCount == 1) return Update(MyConnection, BenhAnMatTreEm);
            sql = @"
                   INSERT INTO BenhAnMatTreEm (MaQuanLy, 
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
                            NguyenNhan_BamSinh, 
                            NguyenNhan_TuBaoGio, 
                            TrieuChung_NhinMo, 
                            TrieuChung_DauNhuc, 
                            TrieuChung_DoMat, 
                            TrieuChung_ChoiMat, 
                            TienSuBenhBanThan_Tick, 
                            TienSuBenhGiaDinh_Tick, 
                            TienSuThaiNghenBenhLy, 
                            TienSuThaiNghenBenhLy_Text, 
                            PhatTrienTriTue, 
                            PhatTrienTriTue_BenhLyText, 
                            ThiLucKhiVaoVien_KhongKinh_MP, 
                            ThiLucKhiVaoVien_KhongKinh_MT, 
                            ThiLucKhiVaoVien_CoKinh_MP, 
                            ThiLucKhiVaoVien_CoKinh_MT, 
                            NhanApVaoVien_MT, 
                            NhanApVaoVien_MP, 
                            ThiTruong_MP, 
                            ThiTruong_MT, 
                            VanNhanNoiTai_MP, 
                            VanNhanNoiTai_Text_MP, 
                            VanNhanNoiTai_MT, 
                            VanNhanNoiTai_Text_MT, 
                            VanNhanNgoaiLai_MP, 
                            VanNhanNgoaiLai_Text_MP, 
                            VanNhanNgoaiLai_MT, 
                            VanNhanNgoaiLai_Text_MT, 
                            RungGiatNhanCau, 
                            RungGiatNhanCau_Text, 
                            MiMat_Quam_MP, 
                            MIMat_Epicanthus, 
                            MiMat_SupMi_MP, 
                            MiMat_U_MP, 
                            MiMat_Khac_MP, 
                            LeDao_MP, 
                            KetMac_CuongTu_MP, 
                            KetMac_XuatHuyet_MP, 
                            KetMac_XuatTiet_MP, 
                            KetMac_U_MP, 
                            KetMac_Khac_MP, 
                            GiacMac_Trong_MP, 
                            GiacMac_Trong_Text_MP, 
                            GiacMac_LoaiDuong_MP, 
                            GiacMac_LoanDuong_Text_MP, 
                            GiacMac_ThoaiHoa_MP, 
                            GiacMac_ThoaiHoa_Text_MP, 
                            GiacMac_PhuNe_MP, 
                            GiacMac_U_MP, 
                            GiacMac_Tua_MP, 
                            GiacMac_Loet_MP, 
                            GiacMac_DiTat_MP, 
                            GiacMac_DuongKinhGM_MP, 
                            GiacMac_VungRia_MP, 
                            GiacMac_Khac_MP, 
                            CungMac_GianLoi_MP, 
                            CungMac_SeoMo_MP, 
                            CungMac_CuongTu_MP, 
                            CungMac_Viem_MP, 
                            CungMac_Khac_MP, 
                            TienPhong_DoSau_MP, 
                            TienPhong_Tydall_MP, 
                            TienPhong_Mu_MP, 
                            TienPhong_Mau_MP, 
                            TienPhong_GocTienPhong_MP, 
                            MongMat_MP, 
                            MongMat_MauSac_MP, 
                            MongMat_TinhTrang_MP, 
                            MongMat_TanMach_MP, 
                            MongMat_CamGiac_MP, 
                            MongMat_U_MP, 
                            MongMat_DiDang_MP, 
                            DongTu_Trong_MP, 
                            DongTu_DuongKinh_MP, 
                            DongTu_VienSacTo_MP, 
                            DongTu_PhanXa_MP, 
                            DongTu_DiDang_MP, 
                            TheThuyTinh_MP, 
                            DichKinh_MP, 
                            DichKinh_Text_MP, 
                            DayMat_VongMac_MP, 
                            DayMat_HoangDiem_MP, 
                            DayMat_MachMau_MP, 
                            DayMat_DiaThi_MP, 
                            DayMat_U_MP, 
                            NhanCau_Mem_MP, 
                            NhanCau_To_MP, 
                            MiMat_Quam_MT, 
                            MIMat_EpicanthusMT, 
                            MiMat_SupMi_MT, 
                            MiMat_U_MT, 
                            MiMat_Khac_MT, 
                            LeDao_MT, 
                            KetMac_CuongTu_MT, 
                            KetMac_XuatHuyet_MT, 
                            KetMac_XuatTiet_MT, 
                            KetMac_U_MT, 
                            KetMac_Khac_MT, 
                            GiacMac_Trong_MT, 
                            GiacMac_Trong_Text_MT, 
                            GiacMac_LoaiDuong_MT, 
                            GiacMac_LoanDuong_Text_MT, 
                            GiacMac_ThoaiHoa_MT, 
                            GiacMac_ThoaiHoa_Text_MT, 
                            GiacMac_PhuNe_MT, 
                            GiacMac_U_MT, 
                            GiacMac_Tua_MT, 
                            GiacMac_Loet_MT, 
                            GiacMac_DiTat_MT, 
                            GiacMac_DuongKinhGM_MT, 
                            GiacMac_VungRia_MT, 
                            GiacMac_Khac_MT, 
                            CungMac_GianLoi_MT, 
                            CungMac_SeoMo_MT, 
                            CungMac_CuongTu_MT, 
                            CungMac_Viem_MT, 
                            CungMac_Khac_MT, 
                            TienPhong_DoSau_MT, 
                            TienPhong_Tydall_MT, 
                            TienPhong_Mu_MT, 
                            TienPhong_Mau_MT, 
                            TienPhong_GocTienPhong_MT, 
                            MongMat_MT, 
                            MongMat_MauSac_MT, 
                            MongMat_TinhTrang_MT, 
                            MongMat_TanMach_MT, 
                            MongMat_CamGiac_MT, 
                            MongMat_U_MT, 
                            MongMat_DiDang_MT, 
                            DongTu_Trong_MT, 
                            DongTu_DuongKinh_MT, 
                            DongTu_VienSacTo_MT, 
                            DongTu_PhanXa_MT, 
                            DongTu_DiDang_MT, 
                            TheThuyTinh_MT, 
                            DichKinh_MT, 
                            DichKinh_Text_MT, 
                            DayMat_VongMac_MT, 
                            DayMat_HoangDiem_MT, 
                            DayMat_MachMau_MT, 
                            DayMat_DiaThi_MT, 
                            DayMat_U_MT, 
                            NhanCau_Mem_MT, 
                            NhanCau_To_MT, 
                            HuyetAp_ToanThan, 
                            NhietDo_ToanThan, 
                            Mach_ToanThan, 
                            NoiTiet_Tick, 
                            NoiTiet, 
                            ThanKinh_Tick, 
                            TuanHoan_Tick, 
                            HoHap_Tick, 
                            TieuHoa_Tick, 
                            CoXuongKhop_Tick, 
                            ThanTietNieu_Tick, 
                            BenhChinh_MatPhai, 
                            BenhChinh_MatTrai, 
                            PhuongPhapChinh, 
                            CheDoAnUong, 
                            CheDoChamSoc, 
                            ChanDoanBenhChinh_LamSang, 
                            ChanDoanBenhChinh_NguyenNhan, 
                            QuaTrinhDieuTri_NoiKhoa, 
                            QuaTrinhDieuTri_KetQua, 
                            QuaTrinhDieuTri_BienChung, 
                            HuongDieuTriTiep, 
                            DaDieuTri_NoiKhoa, 
                            DaDieuTri_PhauThuat, 
                            ChuaThayBenhLy, 
                            BenhLy, 
                            BenhLy_Text,
                            PhauThuat, 
                            ThuThuat, 
                            ThiLucKhiRaVien_KhongKinh_MP, 
                            ThiLucKhiRaVien_KhongKinh_MT, 
                            ThiLucKhiRaVien_CoKinh_MP, 
                            ThiLucKhiRaVien_CoKinh_MT, 
                            NhanApRaVien_MP, 
                            NhanApRaVien_MT,
                            NoiTietCheck,
                            NoiTiet_Text,
                            ThanKinhCheck,
                            ThanKinh_Text,
                            TuanHoanCheck,
                            TuanHoan_Text,
                            HoHapCheck,
                            HoHap_Text,
                            TieuHoaCheck,
                            TieuHoa_Text,
                            CoXuongKhopCheck,
                            CoXuongKhop_Text,
                            TietNieuSinhDucCheck,
                            TietNieuSinhDuc_Text,
                            KhamBenhToanThan_Khac
                            )
                        VALUES (:MaQuanLy, 
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
                            :NguyenNhan_BamSinh, 
                            :NguyenNhan_TuBaoGio, 
                            :TrieuChung_NhinMo, 
                            :TrieuChung_DauNhuc, 
                            :TrieuChung_DoMat, 
                            :TrieuChung_ChoiMat, 
                            :TienSuBenhBanThan_Tick, 
                            :TienSuBenhGiaDinh_Tick, 
                            :TienSuThaiNghenBenhLy, 
                            :TienSuThaiNghenBenhLy_Text, 
                            :PhatTrienTriTue, 
                            :PhatTrienTriTue_BenhLyText, 
                            :ThiLucKhiVaoVien_KhongKinh_MP, 
                            :ThiLucKhiVaoVien_KhongKinh_MT, 
                            :ThiLucKhiVaoVien_CoKinh_MP, 
                            :ThiLucKhiVaoVien_CoKinh_MT, 
                            :NhanApVaoVien_MT, 
                            :NhanApVaoVien_MP, 
                            :ThiTruong_MP, 
                            :ThiTruong_MT, 
                            :VanNhanNoiTai_MP, 
                            :VanNhanNoiTai_Text_MP, 
                            :VanNhanNoiTai_MT, 
                            :VanNhanNoiTai_Text_MT, 
                            :VanNhanNgoaiLai_MP, 
                            :VanNhanNgoaiLai_Text_MP, 
                            :VanNhanNgoaiLai_MT, 
                            :VanNhanNgoaiLai_Text_MT, 
                            :RungGiatNhanCau, 
                            :RungGiatNhanCau_Text, 
                            :MiMat_Quam_MP, 
                            :MIMat_Epicanthus, 
                            :MiMat_SupMi_MP, 
                            :MiMat_U_MP, 
                            :MiMat_Khac_MP, 
                            :LeDao_MP, 
                            :KetMac_CuongTu_MP, 
                            :KetMac_XuatHuyet_MP, 
                            :KetMac_XuatTiet_MP, 
                            :KetMac_U_MP, 
                            :KetMac_Khac_MP, 
                            :GiacMac_Trong_MP, 
                            :GiacMac_Trong_Text_MP, 
                            :GiacMac_LoaiDuong_MP, 
                            :GiacMac_LoanDuong_Text_MP, 
                            :GiacMac_ThoaiHoa_MP, 
                            :GiacMac_ThoaiHoa_Text_MP, 
                            :GiacMac_PhuNe_MP, 
                            :GiacMac_U_MP, 
                            :GiacMac_Tua_MP, 
                            :GiacMac_Loet_MP, 
                            :GiacMac_DiTat_MP, 
                            :GiacMac_DuongKinhGM_MP, 
                            :GiacMac_VungRia_MP, 
                            :GiacMac_Khac_MP, 
                            :CungMac_GianLoi_MP, 
                            :CungMac_SeoMo_MP, 
                            :CungMac_CuongTu_MP, 
                            :CungMac_Viem_MP, 
                            :CungMac_Khac_MP, 
                            :TienPhong_DoSau_MP, 
                            :TienPhong_Tydall_MP, 
                            :TienPhong_Mu_MP, 
                            :TienPhong_Mau_MP, 
                            :TienPhong_GocTienPhong_MP, 
                            :MongMat_MP, 
                            :MongMat_MauSac_MP, 
                            :MongMat_TinhTrang_MP, 
                            :MongMat_TanMach_MP, 
                            :MongMat_CamGiac_MP, 
                            :MongMat_U_MP, 
                            :MongMat_DiDang_MP, 
                            :DongTu_Trong_MP, 
                            :DongTu_DuongKinh_MP, 
                            :DongTu_VienSacTo_MP, 
                            :DongTu_PhanXa_MP, 
                            :DongTu_DiDang_MP, 
                            :TheThuyTinh_MP, 
                            :DichKinh_MP, 
                            :DichKinh_Text_MP, 
                            :DayMat_VongMac_MP, 
                            :DayMat_HoangDiem_MP, 
                            :DayMat_MachMau_MP, 
                            :DayMat_DiaThi_MP, 
                            :DayMat_U_MP, 
                            :NhanCau_Mem_MP, 
                            :NhanCau_To_MP, 
                            :MiMat_Quam_MT, 
                            :MIMat_EpicanthusMT, 
                            :MiMat_SupMi_MT, 
                            :MiMat_U_MT, 
                            :MiMat_Khac_MT, 
                            :LeDao_MT, 
                            :KetMac_CuongTu_MT, 
                            :KetMac_XuatHuyet_MT, 
                            :KetMac_XuatTiet_MT, 
                            :KetMac_U_MT, 
                            :KetMac_Khac_MT, 
                            :GiacMac_Trong_MT, 
                            :GiacMac_Trong_Text_MT, 
                            :GiacMac_LoaiDuong_MT, 
                            :GiacMac_LoanDuong_Text_MT, 
                            :GiacMac_ThoaiHoa_MT, 
                            :GiacMac_ThoaiHoa_Text_MT, 
                            :GiacMac_PhuNe_MT, 
                            :GiacMac_U_MT, 
                            :GiacMac_Tua_MT, 
                            :GiacMac_Loet_MT, 
                            :GiacMac_DiTat_MT, 
                            :GiacMac_DuongKinhGM_MT, 
                            :GiacMac_VungRia_MT, 
                            :GiacMac_Khac_MT, 
                            :CungMac_GianLoi_MT, 
                            :CungMac_SeoMo_MT, 
                            :CungMac_CuongTu_MT, 
                            :CungMac_Viem_MT, 
                            :CungMac_Khac_MT, 
                            :TienPhong_DoSau_MT, 
                            :TienPhong_Tydall_MT, 
                            :TienPhong_Mu_MT, 
                            :TienPhong_Mau_MT, 
                            :TienPhong_GocTienPhong_MT, 
                            :MongMat_MT, 
                            :MongMat_MauSac_MT, 
                            :MongMat_TinhTrang_MT, 
                            :MongMat_TanMach_MT, 
                            :MongMat_CamGiac_MT, 
                            :MongMat_U_MT, 
                            :MongMat_DiDang_MT, 
                            :DongTu_Trong_MT, 
                            :DongTu_DuongKinh_MT, 
                            :DongTu_VienSacTo_MT, 
                            :DongTu_PhanXa_MT, 
                            :DongTu_DiDang_MT, 
                            :TheThuyTinh_MT, 
                            :DichKinh_MT, 
                            :DichKinh_Text_MT, 
                            :DayMat_VongMac_MT, 
                            :DayMat_HoangDiem_MT, 
                            :DayMat_MachMau_MT, 
                            :DayMat_DiaThi_MT, 
                            :DayMat_U_MT, 
                            :NhanCau_Mem_MT, 
                            :NhanCau_To_MT, 
                            :HuyetAp_ToanThan, 
                            :NhietDo_ToanThan, 
                            :Mach_ToanThan, 
                            :NoiTiet_Tick, 
                            :NoiTiet, 
                            :ThanKinh_Tick, 
                            :TuanHoan_Tick, 
                            :HoHap_Tick, 
                            :TieuHoa_Tick, 
                            :CoXuongKhop_Tick, 
                            :ThanTietNieu_Tick, 
                            :BenhChinh_MatPhai, 
                            :BenhChinh_MatTrai, 
                            :PhuongPhapChinh, 
                            :CheDoAnUong, 
                            :CheDoChamSoc, 
                            :ChanDoanBenhChinh_LamSang, 
                            :ChanDoanBenhChinh_NguyenNhan, 
                            :QuaTrinhDieuTri_NoiKhoa, 
                            :QuaTrinhDieuTri_KetQua, 
                            :QuaTrinhDieuTri_BienChung, 
                            :HuongDieuTriTiep, 
                            :DaDieuTri_NoiKhoa, 
                            :DaDieuTri_PhauThuat, 
                            :ChuaThayBenhLy, 
                            :BenhLy, 
                            :BenhLy_Text,
                            :PhauThuat, 
                            :ThuThuat, 
                            :ThiLucKhiRaVien_KhongKinh_MP, 
                            :ThiLucKhiRaVien_KhongKinh_MT, 
                            :ThiLucKhiRaVien_CoKinh_MP, 
                            :ThiLucKhiRaVien_CoKinh_MT, 
                            :NhanApRaVien_MP, 
                            :NhanApRaVien_MT,
                            :NoiTietCheck,
                            :NoiTiet_Text,
                            :ThanKinhCheck,
                            :ThanKinh_Text,
                            :TuanHoanCheck,
                            :TuanHoan_Text,
                            :HoHapCheck,
                            :HoHap_Text,
                            :TieuHoaCheck,
                            :TieuHoa_Text,
                            :CoXuongKhopCheck,
                            :CoXuongKhop_Text,
                            :TietNieuSinhDucCheck,
                            :TietNieuSinhDuc_Text,
                            :KhamBenhToanThan_Khac)
                            ";
            Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnMatTreEm.MaQuanLy));
            Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnMatTreEm.LyDoVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("VaoNgayThu", BenhAnMatTreEm.VaoNgayThu));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnMatTreEm.QuaTrinhBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhBanThan", BenhAnMatTreEm.TienSuBenhBanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhGiaDinh", BenhAnMatTreEm.TienSuBenhGiaDinh));
            Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnMatTreEm.ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoan", BenhAnMatTreEm.TuanHoan));
            Command.Parameters.Add(new MDB.MDBParameter("HoHap", BenhAnMatTreEm.HoHap));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoa", BenhAnMatTreEm.TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieuSinhDuc", BenhAnMatTreEm.ThanTietNieuSinhDuc));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinh", BenhAnMatTreEm.ThanKinh));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop", BenhAnMatTreEm.CoXuongKhop));
            Command.Parameters.Add(new MDB.MDBParameter("TaiMuiHong", BenhAnMatTreEm.TaiMuiHong));
            Command.Parameters.Add(new MDB.MDBParameter("RangHamMat", BenhAnMatTreEm.RangHamMat));
            Command.Parameters.Add(new MDB.MDBParameter("Mat", BenhAnMatTreEm.Mat));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_CacCoQuan", BenhAnMatTreEm.Khac_CacCoQuan));
            Command.Parameters.Add(new MDB.MDBParameter("CacXetNghiemCanLamSangCanLam", BenhAnMatTreEm.CacXetNghiemCanLamSangCanLam));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatBenhAn", BenhAnMatTreEm.TomTatBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnMatTreEm.BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnMatTreEm.BenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("PhanBiet", BenhAnMatTreEm.PhanBiet));
            Command.Parameters.Add(new MDB.MDBParameter("TienLuong", BenhAnMatTreEm.TienLuong));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnMatTreEm.HuongDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("NgayKhamBenh", BenhAnMatTreEm.NgayKhamBenh));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyLamBenhAn", BenhAnMatTreEm.BacSyLamBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLyVaDienBien", BenhAnMatTreEm.QuaTrinhBenhLyVaDienBien));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQuaXetNghiem", BenhAnMatTreEm.TomTatKetQuaXetNghiem));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnMatTreEm.PhuongPhapDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangNguoiBenhRaVien", BenhAnMatTreEm.TinhTrangNguoiBenhRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriVaCacCheDoTiepTheo", BenhAnMatTreEm.HuongDieuTriVaCacCheDoTiepTheo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnMatTreEm.NguoiNhanHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnMatTreEm.NguoiGiaoHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnMatTreEm.NgayTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnMatTreEm.BacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng", BenhAnMatTreEm.DacDiemLienQuanBenh.DiUng == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng_Text", BenhAnMatTreEm.DacDiemLienQuanBenh.DiUng_Text));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy", BenhAnMatTreEm.DacDiemLienQuanBenh.MaTuy == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy_Text", BenhAnMatTreEm.DacDiemLienQuanBenh.MaTuy_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia", BenhAnMatTreEm.DacDiemLienQuanBenh.RuouBia == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia_Text", BenhAnMatTreEm.DacDiemLienQuanBenh.RuouBia_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa", BenhAnMatTreEm.DacDiemLienQuanBenh.ThuocLa == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa_Text", BenhAnMatTreEm.DacDiemLienQuanBenh.ThuocLa_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao", BenhAnMatTreEm.DacDiemLienQuanBenh.ThuocLao == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao_Text", BenhAnMatTreEm.DacDiemLienQuanBenh.ThuocLao_Text));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh", BenhAnMatTreEm.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh_Text", BenhAnMatTreEm.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh_Text));
            Command.Parameters.Add(new MDB.MDBParameter("NguyenNhan_BamSinh", BenhAnMatTreEm.NguyenNhan_BamSinh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("NguyenNhan_TuBaoGio", BenhAnMatTreEm.NguyenNhan_TuBaoGio));
            Command.Parameters.Add(new MDB.MDBParameter("TrieuChung_NhinMo", BenhAnMatTreEm.TrieuChung_NhinMo == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TrieuChung_DauNhuc", BenhAnMatTreEm.TrieuChung_DauNhuc == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TrieuChung_DoMat", BenhAnMatTreEm.TrieuChung_DoMat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TrieuChung_ChoiMat", BenhAnMatTreEm.TrieuChung_ChoiMat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhBanThan_Tick", BenhAnMatTreEm.TienSuBenhBanThan_Tick == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhGiaDinh_Tick", BenhAnMatTreEm.TienSuBenhGiaDinh_Tick == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuThaiNghenBenhLy", BenhAnMatTreEm.TienSuThaiNghenBenhLy == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuThaiNghenBenhLy_Text", BenhAnMatTreEm.TienSuThaiNghenBenhLy_Text));
            Command.Parameters.Add(new MDB.MDBParameter("PhatTrienTriTue", BenhAnMatTreEm.PhatTrienTriTue == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("PhatTrienTriTue_BenhLyText", BenhAnMatTreEm.PhatTrienTriTue_BenhLyText));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiVaoVien_KhongKinh_MP", BenhAnMatTreEm.ThiLucKhiVaoVien_KhongKinh_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiVaoVien_KhongKinh_MT", BenhAnMatTreEm.ThiLucKhiVaoVien_KhongKinh_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiVaoVien_CoKinh_MP", BenhAnMatTreEm.ThiLucKhiVaoVien_CoKinh_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiVaoVien_CoKinh_MT", BenhAnMatTreEm.ThiLucKhiVaoVien_CoKinh_MT));
            Command.Parameters.Add(new MDB.MDBParameter("NhanApVaoVien_MT", BenhAnMatTreEm.NhanApVaoVien_MT));
            Command.Parameters.Add(new MDB.MDBParameter("NhanApVaoVien_MP", BenhAnMatTreEm.NhanApVaoVien_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThiTruong_MP", BenhAnMatTreEm.ThiTruong_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThiTruong_MT", BenhAnMatTreEm.ThiTruong_MT));
            Command.Parameters.Add(new MDB.MDBParameter("VanNhanNoiTai_MP", BenhAnMatTreEm.VanNhanNoiTai_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("VanNhanNoiTai_Text_MP", BenhAnMatTreEm.VanNhanNoiTai_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("VanNhanNoiTai_MT", BenhAnMatTreEm.VanNhanNoiTai_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("VanNhanNoiTai_Text_MT", BenhAnMatTreEm.VanNhanNoiTai_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("VanNhanNgoaiLai_MP", BenhAnMatTreEm.VanNhanNgoaiLai_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("VanNhanNgoaiLai_Text_MP", BenhAnMatTreEm.VanNhanNgoaiLai_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("VanNhanNgoaiLai_MT", BenhAnMatTreEm.VanNhanNgoaiLai_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("VanNhanNgoaiLai_Text_MT", BenhAnMatTreEm.VanNhanNgoaiLai_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("RungGiatNhanCau", BenhAnMatTreEm.RungGiatNhanCau == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RungGiatNhanCau_Text", BenhAnMatTreEm.RungGiatNhanCau_Text));
            Command.Parameters.Add(new MDB.MDBParameter("MiMat_Quam_MP", BenhAnMatTreEm.MiMat_Quam_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MIMat_Epicanthus", BenhAnMatTreEm.MIMat_Epicanthus == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MiMat_SupMi_MP", BenhAnMatTreEm.MiMat_SupMi_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MiMat_U_MP", BenhAnMatTreEm.MiMat_U_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MiMat_Khac_MP", BenhAnMatTreEm.MiMat_Khac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("LeDao_MP", BenhAnMatTreEm.LeDao_MP));
            Command.Parameters.Add(new MDB.MDBParameter("KetMac_CuongTu_MP", BenhAnMatTreEm.KetMac_CuongTu_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KetMac_XuatHuyet_MP", BenhAnMatTreEm.KetMac_XuatHuyet_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KetMac_XuatTiet_MP", BenhAnMatTreEm.KetMac_XuatTiet_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KetMac_U_MP", BenhAnMatTreEm.KetMac_U_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KetMac_Khac_MP", BenhAnMatTreEm.KetMac_Khac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_Trong_MP", BenhAnMatTreEm.GiacMac_Trong_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_Trong_Text_MP", BenhAnMatTreEm.GiacMac_Trong_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_LoaiDuong_MP", BenhAnMatTreEm.GiacMac_LoaiDuong_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_LoanDuong_Text_MP", BenhAnMatTreEm.GiacMac_LoanDuong_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_ThoaiHoa_MP", BenhAnMatTreEm.GiacMac_ThoaiHoa_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_ThoaiHoa_Text_MP", BenhAnMatTreEm.GiacMac_ThoaiHoa_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_PhuNe_MP", BenhAnMatTreEm.GiacMac_PhuNe_MP));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_U_MP", BenhAnMatTreEm.GiacMac_U_MP));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_Tua_MP", BenhAnMatTreEm.GiacMac_Tua_MP));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_Loet_MP", BenhAnMatTreEm.GiacMac_Loet_MP));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_DiTat_MP", BenhAnMatTreEm.GiacMac_DiTat_MP));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_DuongKinhGM_MP", BenhAnMatTreEm.GiacMac_DuongKinhGM_MP));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_VungRia_MP", BenhAnMatTreEm.GiacMac_VungRia_MP));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_Khac_MP", BenhAnMatTreEm.GiacMac_Khac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("CungMac_GianLoi_MP", BenhAnMatTreEm.CungMac_GianLoi_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CungMac_SeoMo_MP", BenhAnMatTreEm.CungMac_SeoMo_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CungMac_CuongTu_MP", BenhAnMatTreEm.CungMac_CuongTu_MP));
            Command.Parameters.Add(new MDB.MDBParameter("CungMac_Viem_MP", BenhAnMatTreEm.CungMac_Viem_MP));
            Command.Parameters.Add(new MDB.MDBParameter("CungMac_Khac_MP", BenhAnMatTreEm.CungMac_Khac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TienPhong_DoSau_MP", BenhAnMatTreEm.TienPhong_DoSau_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TienPhong_Tydall_MP", BenhAnMatTreEm.TienPhong_Tydall_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TienPhong_Mu_MP", BenhAnMatTreEm.TienPhong_Mu_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TienPhong_Mau_MP", BenhAnMatTreEm.TienPhong_Mau_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TienPhong_GocTienPhong_MP", BenhAnMatTreEm.TienPhong_GocTienPhong_MP));
            Command.Parameters.Add(new MDB.MDBParameter("MongMat_MP", BenhAnMatTreEm.MongMat_MP));
            Command.Parameters.Add(new MDB.MDBParameter("MongMat_MauSac_MP", BenhAnMatTreEm.MongMat_MauSac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("MongMat_TinhTrang_MP", BenhAnMatTreEm.MongMat_TinhTrang_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MongMat_TanMach_MP", BenhAnMatTreEm.MongMat_TanMach_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MongMat_CamGiac_MP", BenhAnMatTreEm.MongMat_CamGiac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MongMat_U_MP", BenhAnMatTreEm.MongMat_U_MP));
            Command.Parameters.Add(new MDB.MDBParameter("MongMat_DiDang_MP", BenhAnMatTreEm.MongMat_DiDang_MP));
            Command.Parameters.Add(new MDB.MDBParameter("DongTu_Trong_MP", BenhAnMatTreEm.DongTu_Trong_MP));
            Command.Parameters.Add(new MDB.MDBParameter("DongTu_DuongKinh_MP", BenhAnMatTreEm.DongTu_DuongKinh_MP));
            Command.Parameters.Add(new MDB.MDBParameter("DongTu_VienSacTo_MP", BenhAnMatTreEm.DongTu_VienSacTo_MP));
            Command.Parameters.Add(new MDB.MDBParameter("DongTu_PhanXa_MP", BenhAnMatTreEm.DongTu_PhanXa_MP));
            Command.Parameters.Add(new MDB.MDBParameter("DongTu_DiDang_MP", BenhAnMatTreEm.DongTu_DiDang_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TheThuyTinh_MP", BenhAnMatTreEm.TheThuyTinh_MP));
            Command.Parameters.Add(new MDB.MDBParameter("DichKinh_MP", BenhAnMatTreEm.DichKinh_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DichKinh_Text_MP", BenhAnMatTreEm.DichKinh_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("DayMat_VongMac_MP", BenhAnMatTreEm.DayMat_VongMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("DayMat_HoangDiem_MP", BenhAnMatTreEm.DayMat_HoangDiem_MP));
            Command.Parameters.Add(new MDB.MDBParameter("DayMat_MachMau_MP", BenhAnMatTreEm.DayMat_MachMau_MP));
            Command.Parameters.Add(new MDB.MDBParameter("DayMat_DiaThi_MP", BenhAnMatTreEm.DayMat_DiaThi_MP));
            Command.Parameters.Add(new MDB.MDBParameter("DayMat_U_MP", BenhAnMatTreEm.DayMat_U_MP));
            Command.Parameters.Add(new MDB.MDBParameter("NhanCau_Mem_MP", BenhAnMatTreEm.NhanCau_Mem_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("NhanCau_To_MP", BenhAnMatTreEm.NhanCau_To_MP));
            Command.Parameters.Add(new MDB.MDBParameter("MiMat_Quam_MT", BenhAnMatTreEm.MiMat_Quam_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MIMat_EpicanthusMT", BenhAnMatTreEm.MIMat_EpicanthusMT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MiMat_SupMi_MT", BenhAnMatTreEm.MiMat_SupMi_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MiMat_U_MT", BenhAnMatTreEm.MiMat_U_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MiMat_Khac_MT", BenhAnMatTreEm.MiMat_Khac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("LeDao_MT", BenhAnMatTreEm.LeDao_MT));
            Command.Parameters.Add(new MDB.MDBParameter("KetMac_CuongTu_MT", BenhAnMatTreEm.KetMac_CuongTu_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KetMac_XuatHuyet_MT", BenhAnMatTreEm.KetMac_XuatHuyet_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KetMac_XuatTiet_MT", BenhAnMatTreEm.KetMac_XuatTiet_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KetMac_U_MT", BenhAnMatTreEm.KetMac_U_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KetMac_Khac_MT", BenhAnMatTreEm.KetMac_Khac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_Trong_MT", BenhAnMatTreEm.GiacMac_Trong_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_Trong_Text_MT", BenhAnMatTreEm.GiacMac_Trong_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_LoaiDuong_MT", BenhAnMatTreEm.GiacMac_LoaiDuong_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_LoanDuong_Text_MT", BenhAnMatTreEm.GiacMac_LoanDuong_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_ThoaiHoa_MT", BenhAnMatTreEm.GiacMac_ThoaiHoa_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_ThoaiHoa_Text_MT", BenhAnMatTreEm.GiacMac_ThoaiHoa_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_PhuNe_MT", BenhAnMatTreEm.GiacMac_PhuNe_MT));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_U_MT", BenhAnMatTreEm.GiacMac_U_MT));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_Tua_MT", BenhAnMatTreEm.GiacMac_Tua_MT));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_Loet_MT", BenhAnMatTreEm.GiacMac_Loet_MT));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_DiTat_MT", BenhAnMatTreEm.GiacMac_DiTat_MT));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_DuongKinhGM_MT", BenhAnMatTreEm.GiacMac_DuongKinhGM_MT));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_VungRia_MT", BenhAnMatTreEm.GiacMac_VungRia_MT));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_Khac_MT", BenhAnMatTreEm.GiacMac_Khac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("CungMac_GianLoi_MT", BenhAnMatTreEm.CungMac_GianLoi_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CungMac_SeoMo_MT", BenhAnMatTreEm.CungMac_SeoMo_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CungMac_CuongTu_MT", BenhAnMatTreEm.CungMac_CuongTu_MT));
            Command.Parameters.Add(new MDB.MDBParameter("CungMac_Viem_MT", BenhAnMatTreEm.CungMac_Viem_MT));
            Command.Parameters.Add(new MDB.MDBParameter("CungMac_Khac_MT", BenhAnMatTreEm.CungMac_Khac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TienPhong_DoSau_MT", BenhAnMatTreEm.TienPhong_DoSau_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TienPhong_Tydall_MT", BenhAnMatTreEm.TienPhong_Tydall_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TienPhong_Mu_MT", BenhAnMatTreEm.TienPhong_Mu_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TienPhong_Mau_MT", BenhAnMatTreEm.TienPhong_Mau_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TienPhong_GocTienPhong_MT", BenhAnMatTreEm.TienPhong_GocTienPhong_MT));
            Command.Parameters.Add(new MDB.MDBParameter("MongMat_MT", BenhAnMatTreEm.MongMat_MT));
            Command.Parameters.Add(new MDB.MDBParameter("MongMat_MauSac_MT", BenhAnMatTreEm.MongMat_MauSac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("MongMat_TinhTrang_MT", BenhAnMatTreEm.MongMat_TinhTrang_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MongMat_TanMach_MT", BenhAnMatTreEm.MongMat_TanMach_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MongMat_CamGiac_MT", BenhAnMatTreEm.MongMat_CamGiac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MongMat_U_MT", BenhAnMatTreEm.MongMat_U_MT));
            Command.Parameters.Add(new MDB.MDBParameter("MongMat_DiDang_MT", BenhAnMatTreEm.MongMat_DiDang_MT));
            Command.Parameters.Add(new MDB.MDBParameter("DongTu_Trong_MT", BenhAnMatTreEm.DongTu_Trong_MT));
            Command.Parameters.Add(new MDB.MDBParameter("DongTu_DuongKinh_MT", BenhAnMatTreEm.DongTu_DuongKinh_MT));
            Command.Parameters.Add(new MDB.MDBParameter("DongTu_VienSacTo_MT", BenhAnMatTreEm.DongTu_VienSacTo_MT));
            Command.Parameters.Add(new MDB.MDBParameter("DongTu_PhanXa_MT", BenhAnMatTreEm.DongTu_PhanXa_MT));
            Command.Parameters.Add(new MDB.MDBParameter("DongTu_DiDang_MT", BenhAnMatTreEm.DongTu_DiDang_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TheThuyTinh_MT", BenhAnMatTreEm.TheThuyTinh_MT));
            Command.Parameters.Add(new MDB.MDBParameter("DichKinh_MT", BenhAnMatTreEm.DichKinh_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DichKinh_Text_MT", BenhAnMatTreEm.DichKinh_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("DayMat_VongMac_MT", BenhAnMatTreEm.DayMat_VongMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("DayMat_HoangDiem_MT", BenhAnMatTreEm.DayMat_HoangDiem_MT));
            Command.Parameters.Add(new MDB.MDBParameter("DayMat_MachMau_MT", BenhAnMatTreEm.DayMat_MachMau_MT));
            Command.Parameters.Add(new MDB.MDBParameter("DayMat_DiaThi_MT", BenhAnMatTreEm.DayMat_DiaThi_MT));
            Command.Parameters.Add(new MDB.MDBParameter("DayMat_U_MT", BenhAnMatTreEm.DayMat_U_MT));
            Command.Parameters.Add(new MDB.MDBParameter("NhanCau_Mem_MT", BenhAnMatTreEm.NhanCau_Mem_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("NhanCau_To_MT", BenhAnMatTreEm.NhanCau_To_MT));
            Command.Parameters.Add(new MDB.MDBParameter("HuyetAp_ToanThan", BenhAnMatTreEm.HuyetAp_ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("NhietDo_ToanThan", BenhAnMatTreEm.NhietDo_ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("Mach_ToanThan", BenhAnMatTreEm.Mach_ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("NoiTiet_Tick", BenhAnMatTreEm.NoiTiet_Tick == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("NoiTiet", BenhAnMatTreEm.NoiTiet));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinh_Tick", BenhAnMatTreEm.ThanKinh_Tick == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoan_Tick", BenhAnMatTreEm.TuanHoan_Tick == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HoHap_Tick", BenhAnMatTreEm.HoHap_Tick == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoa_Tick", BenhAnMatTreEm.TieuHoa_Tick == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop_Tick", BenhAnMatTreEm.CoXuongKhop_Tick == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieu_Tick", BenhAnMatTreEm.ThanTietNieu_Tick == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinh_MatPhai", BenhAnMatTreEm.BenhChinh_MatPhai));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinh_MatTrai", BenhAnMatTreEm.BenhChinh_MatTrai));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapChinh", BenhAnMatTreEm.PhuongPhapChinh));
            Command.Parameters.Add(new MDB.MDBParameter("CheDoAnUong", BenhAnMatTreEm.CheDoAnUong));
            Command.Parameters.Add(new MDB.MDBParameter("CheDoChamSoc", BenhAnMatTreEm.CheDoChamSoc));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanBenhChinh_LamSang", BenhAnMatTreEm.ChanDoanBenhChinh_LamSang));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanBenhChinh_NguyenNhan", BenhAnMatTreEm.ChanDoanBenhChinh_NguyenNhan));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhDieuTri_NoiKhoa", BenhAnMatTreEm.QuaTrinhDieuTri_NoiKhoa));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhDieuTri_KetQua", BenhAnMatTreEm.QuaTrinhDieuTri_KetQua));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhDieuTri_BienChung", BenhAnMatTreEm.QuaTrinhDieuTri_BienChung));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriTiep", BenhAnMatTreEm.HuongDieuTriTiep));
            Command.Parameters.Add(new MDB.MDBParameter("DaDieuTri_NoiKhoa", BenhAnMatTreEm.DaDieuTri_NoiKhoa == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DaDieuTri_PhauThuat", BenhAnMatTreEm.DaDieuTri_PhauThuat));
            Command.Parameters.Add(new MDB.MDBParameter("ChuaThayBenhLy", BenhAnMatTreEm.ChuaThayBenhLy ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BenhLy", BenhAnMatTreEm.BenhLy ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BenhLy_Text", BenhAnMatTreEm.BenhLy_Text));
            Command.Parameters.Add(new MDB.MDBParameter("PhauThuat", BenhAnMatTreEm.PhauThuat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuThuat", BenhAnMatTreEm.ThuThuat == true ? "1" : "0"));

            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiRaVien_KhongKinh_MP", BenhAnMatTreEm.ThiLucKhiRaVien_KhongKinh_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiRaVien_KhongKinh_MT", BenhAnMatTreEm.ThiLucKhiRaVien_KhongKinh_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiRaVien_CoKinh_MP", BenhAnMatTreEm.ThiLucKhiRaVien_CoKinh_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiRaVien_CoKinh_MT", BenhAnMatTreEm.ThiLucKhiRaVien_CoKinh_MT));
            Command.Parameters.Add(new MDB.MDBParameter("NhanApRaVien_MT", BenhAnMatTreEm.NhanApRaVien_MT));
            Command.Parameters.Add(new MDB.MDBParameter("NhanApRaVien_MP", BenhAnMatTreEm.NhanApRaVien_MP));

            Command.Parameters.Add(new MDB.MDBParameter("NoiTietCheck", BenhAnMatTreEm.NoiTietCheck));
            Command.Parameters.Add(new MDB.MDBParameter("NoiTiet_Text", BenhAnMatTreEm.NoiTiet_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinhCheck", BenhAnMatTreEm.ThanKinhCheck));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinh_Text", BenhAnMatTreEm.ThanKinh_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoanCheck", BenhAnMatTreEm.TuanHoanCheck));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoan_Text", BenhAnMatTreEm.TuanHoan_Text));
            Command.Parameters.Add(new MDB.MDBParameter("HoHapCheck", BenhAnMatTreEm.HoHapCheck));
            Command.Parameters.Add(new MDB.MDBParameter("HoHap_Text", BenhAnMatTreEm.HoHap_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoaCheck", BenhAnMatTreEm.TieuHoaCheck));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoa_Text", BenhAnMatTreEm.TieuHoa_Text));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhopCheck", BenhAnMatTreEm.CoXuongKhopCheck));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop_Text", BenhAnMatTreEm.CoXuongKhop_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TietNieuSinhDucCheck", BenhAnMatTreEm.TietNieuSinhDucCheck));
            Command.Parameters.Add(new MDB.MDBParameter("TietNieuSinhDuc_Text", BenhAnMatTreEm.TietNieuSinhDuc_Text));
            Command.Parameters.Add(new MDB.MDBParameter("KhamBenhToanThan_Khac", BenhAnMatTreEm.KhamBenhToanThan_Khac));

            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool Update(MDB.MDBConnection MyConnection, BenhAnMatTreEm BenhAnMatTreEm)
        {
            string sql = @"UPDATE BenhAnMatTreEm SET 
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
NguyenNhan_BamSinh = :NguyenNhan_BamSinh,
NguyenNhan_TuBaoGio = :NguyenNhan_TuBaoGio,
TrieuChung_NhinMo = :TrieuChung_NhinMo,
TrieuChung_DauNhuc = :TrieuChung_DauNhuc,
TrieuChung_DoMat = :TrieuChung_DoMat,
TrieuChung_ChoiMat = :TrieuChung_ChoiMat,
TienSuBenhBanThan_Tick = :TienSuBenhBanThan_Tick,
TienSuBenhGiaDinh_Tick = :TienSuBenhGiaDinh_Tick,
TienSuThaiNghenBenhLy = :TienSuThaiNghenBenhLy,
TienSuThaiNghenBenhLy_Text = :TienSuThaiNghenBenhLy_Text,
PhatTrienTriTue = :PhatTrienTriTue,
PhatTrienTriTue_BenhLyText = :PhatTrienTriTue_BenhLyText,
ThiLucKhiVaoVien_KhongKinh_MP = :ThiLucKhiVaoVien_KhongKinh_MP,
ThiLucKhiVaoVien_KhongKinh_MT = :ThiLucKhiVaoVien_KhongKinh_MT,
ThiLucKhiVaoVien_CoKinh_MP = :ThiLucKhiVaoVien_CoKinh_MP,
ThiLucKhiVaoVien_CoKinh_MT = :ThiLucKhiVaoVien_CoKinh_MT,
NhanApVaoVien_MT = :NhanApVaoVien_MT,
NhanApVaoVien_MP = :NhanApVaoVien_MP,
ThiTruong_MP = :ThiTruong_MP,
ThiTruong_MT = :ThiTruong_MT,
VanNhanNoiTai_MP = :VanNhanNoiTai_MP,
VanNhanNoiTai_Text_MP = :VanNhanNoiTai_Text_MP,
VanNhanNoiTai_MT = :VanNhanNoiTai_MT,
VanNhanNoiTai_Text_MT = :VanNhanNoiTai_Text_MT,
VanNhanNgoaiLai_MP = :VanNhanNgoaiLai_MP,
VanNhanNgoaiLai_Text_MP = :VanNhanNgoaiLai_Text_MP,
VanNhanNgoaiLai_MT = :VanNhanNgoaiLai_MT,
VanNhanNgoaiLai_Text_MT = :VanNhanNgoaiLai_Text_MT,
RungGiatNhanCau = :RungGiatNhanCau,
RungGiatNhanCau_Text = :RungGiatNhanCau_Text,
MiMat_Quam_MP = :MiMat_Quam_MP,
MIMat_Epicanthus = :MIMat_Epicanthus,
MiMat_SupMi_MP = :MiMat_SupMi_MP,
MiMat_U_MP = :MiMat_U_MP,
MiMat_Khac_MP = :MiMat_Khac_MP,
LeDao_MP = :LeDao_MP,
KetMac_CuongTu_MP = :KetMac_CuongTu_MP,
KetMac_XuatHuyet_MP = :KetMac_XuatHuyet_MP,
KetMac_XuatTiet_MP = :KetMac_XuatTiet_MP,
KetMac_U_MP = :KetMac_U_MP,
KetMac_Khac_MP = :KetMac_Khac_MP,
GiacMac_Trong_MP = :GiacMac_Trong_MP,
GiacMac_Trong_Text_MP = :GiacMac_Trong_Text_MP,
GiacMac_LoaiDuong_MP = :GiacMac_LoaiDuong_MP,
GiacMac_LoanDuong_Text_MP = :GiacMac_LoanDuong_Text_MP,
GiacMac_ThoaiHoa_MP = :GiacMac_ThoaiHoa_MP,
GiacMac_ThoaiHoa_Text_MP = :GiacMac_ThoaiHoa_Text_MP,
GiacMac_PhuNe_MP = :GiacMac_PhuNe_MP,
GiacMac_U_MP = :GiacMac_U_MP,
GiacMac_Tua_MP = :GiacMac_Tua_MP,
GiacMac_Loet_MP = :GiacMac_Loet_MP,
GiacMac_DiTat_MP = :GiacMac_DiTat_MP,
GiacMac_DuongKinhGM_MP = :GiacMac_DuongKinhGM_MP,
GiacMac_VungRia_MP = :GiacMac_VungRia_MP,
GiacMac_Khac_MP = :GiacMac_Khac_MP,
CungMac_GianLoi_MP = :CungMac_GianLoi_MP,
CungMac_SeoMo_MP = :CungMac_SeoMo_MP,
CungMac_CuongTu_MP = :CungMac_CuongTu_MP,
CungMac_Viem_MP = :CungMac_Viem_MP,
CungMac_Khac_MP = :CungMac_Khac_MP,
TienPhong_DoSau_MP = :TienPhong_DoSau_MP,
TienPhong_Tydall_MP = :TienPhong_Tydall_MP,
TienPhong_Mu_MP = :TienPhong_Mu_MP,
TienPhong_Mau_MP = :TienPhong_Mau_MP,
TienPhong_GocTienPhong_MP = :TienPhong_GocTienPhong_MP,
MongMat_MP = :MongMat_MP,
MongMat_MauSac_MP = :MongMat_MauSac_MP,
MongMat_TinhTrang_MP = :MongMat_TinhTrang_MP,
MongMat_TanMach_MP = :MongMat_TanMach_MP,
MongMat_CamGiac_MP = :MongMat_CamGiac_MP,
MongMat_U_MP = :MongMat_U_MP,
MongMat_DiDang_MP = :MongMat_DiDang_MP,
DongTu_Trong_MP = :DongTu_Trong_MP,
DongTu_DuongKinh_MP = :DongTu_DuongKinh_MP,
DongTu_VienSacTo_MP = :DongTu_VienSacTo_MP,
DongTu_PhanXa_MP = :DongTu_PhanXa_MP,
DongTu_DiDang_MP = :DongTu_DiDang_MP,
TheThuyTinh_MP = :TheThuyTinh_MP,
DichKinh_MP = :DichKinh_MP,
DichKinh_Text_MP = :DichKinh_Text_MP,
DayMat_VongMac_MP = :DayMat_VongMac_MP,
DayMat_HoangDiem_MP = :DayMat_HoangDiem_MP,
DayMat_MachMau_MP = :DayMat_MachMau_MP,
DayMat_DiaThi_MP = :DayMat_DiaThi_MP,
DayMat_U_MP = :DayMat_U_MP,
NhanCau_Mem_MP = :NhanCau_Mem_MP,
NhanCau_To_MP = :NhanCau_To_MP,
MiMat_Quam_MT = :MiMat_Quam_MT,
MIMat_EpicanthusMT = :MIMat_EpicanthusMT,
MiMat_SupMi_MT = :MiMat_SupMi_MT,
MiMat_U_MT = :MiMat_U_MT,
MiMat_Khac_MT = :MiMat_Khac_MT,
LeDao_MT = :LeDao_MT,
KetMac_CuongTu_MT = :KetMac_CuongTu_MT,
KetMac_XuatHuyet_MT = :KetMac_XuatHuyet_MT,
KetMac_XuatTiet_MT = :KetMac_XuatTiet_MT,
KetMac_U_MT = :KetMac_U_MT,
KetMac_Khac_MT = :KetMac_Khac_MT,
GiacMac_Trong_MT = :GiacMac_Trong_MT,
GiacMac_Trong_Text_MT = :GiacMac_Trong_Text_MT,
GiacMac_LoaiDuong_MT = :GiacMac_LoaiDuong_MT,
GiacMac_LoanDuong_Text_MT = :GiacMac_LoanDuong_Text_MT,
GiacMac_ThoaiHoa_MT = :GiacMac_ThoaiHoa_MT,
GiacMac_ThoaiHoa_Text_MT = :GiacMac_ThoaiHoa_Text_MT,
GiacMac_PhuNe_MT = :GiacMac_PhuNe_MT,
GiacMac_U_MT = :GiacMac_U_MT,
GiacMac_Tua_MT = :GiacMac_Tua_MT,
GiacMac_Loet_MT = :GiacMac_Loet_MT,
GiacMac_DiTat_MT = :GiacMac_DiTat_MT,
GiacMac_DuongKinhGM_MT = :GiacMac_DuongKinhGM_MT,
GiacMac_VungRia_MT = :GiacMac_VungRia_MT,
GiacMac_Khac_MT = :GiacMac_Khac_MT,
CungMac_GianLoi_MT = :CungMac_GianLoi_MT,
CungMac_SeoMo_MT = :CungMac_SeoMo_MT,
CungMac_CuongTu_MT = :CungMac_CuongTu_MT,
CungMac_Viem_MT = :CungMac_Viem_MT,
CungMac_Khac_MT = :CungMac_Khac_MT,
TienPhong_DoSau_MT = :TienPhong_DoSau_MT,
TienPhong_Tydall_MT = :TienPhong_Tydall_MT,
TienPhong_Mu_MT = :TienPhong_Mu_MT,
TienPhong_Mau_MT = :TienPhong_Mau_MT,
TienPhong_GocTienPhong_MT = :TienPhong_GocTienPhong_MT,
MongMat_MT = :MongMat_MT,
MongMat_MauSac_MT = :MongMat_MauSac_MT,
MongMat_TinhTrang_MT = :MongMat_TinhTrang_MT,
MongMat_TanMach_MT = :MongMat_TanMach_MT,
MongMat_CamGiac_MT = :MongMat_CamGiac_MT,
MongMat_U_MT = :MongMat_U_MT,
MongMat_DiDang_MT = :MongMat_DiDang_MT,
DongTu_Trong_MT = :DongTu_Trong_MT,
DongTu_DuongKinh_MT = :DongTu_DuongKinh_MT,
DongTu_VienSacTo_MT = :DongTu_VienSacTo_MT,
DongTu_PhanXa_MT = :DongTu_PhanXa_MT,
DongTu_DiDang_MT = :DongTu_DiDang_MT,
TheThuyTinh_MT = :TheThuyTinh_MT,
DichKinh_MT = :DichKinh_MT,
DichKinh_Text_MT = :DichKinh_Text_MT,
DayMat_VongMac_MT = :DayMat_VongMac_MT,
DayMat_HoangDiem_MT = :DayMat_HoangDiem_MT,
DayMat_MachMau_MT = :DayMat_MachMau_MT,
DayMat_DiaThi_MT = :DayMat_DiaThi_MT,
DayMat_U_MT = :DayMat_U_MT,
NhanCau_Mem_MT = :NhanCau_Mem_MT,
NhanCau_To_MT = :NhanCau_To_MT,
HuyetAp_ToanThan = :HuyetAp_ToanThan,
NhietDo_ToanThan = :NhietDo_ToanThan,
Mach_ToanThan = :Mach_ToanThan,
NoiTiet_Tick = :NoiTiet_Tick,
NoiTiet = :NoiTiet,
ThanKinh_Tick = :ThanKinh_Tick,
TuanHoan_Tick = :TuanHoan_Tick,
HoHap_Tick = :HoHap_Tick,
TieuHoa_Tick = :TieuHoa_Tick,
CoXuongKhop_Tick = :CoXuongKhop_Tick,
ThanTietNieu_Tick = :ThanTietNieu_Tick,
BenhChinh_MatPhai = :BenhChinh_MatPhai,
BenhChinh_MatTrai = :BenhChinh_MatTrai,
PhuongPhapChinh = :PhuongPhapChinh,
CheDoAnUong = :CheDoAnUong,
CheDoChamSoc = :CheDoChamSoc,
ChanDoanBenhChinh_LamSang = :ChanDoanBenhChinh_LamSang,
ChanDoanBenhChinh_NguyenNhan = :ChanDoanBenhChinh_NguyenNhan,
QuaTrinhDieuTri_NoiKhoa = :QuaTrinhDieuTri_NoiKhoa,
QuaTrinhDieuTri_KetQua = :QuaTrinhDieuTri_KetQua,
QuaTrinhDieuTri_BienChung = :QuaTrinhDieuTri_BienChung,
HuongDieuTriTiep = :HuongDieuTriTiep,
DaDieuTri_NoiKhoa = :DaDieuTri_NoiKhoa,
DaDieuTri_PhauThuat = :DaDieuTri_PhauThuat,
ChuaThayBenhLy = :ChuaThayBenhLy,
BenhLy = :BenhLy,
BenhLy_Text = :BenhLy_Text,
PhauThuat = :PhauThuat, 
ThuThuat = :ThuThuat, 
ThiLucKhiRaVien_KhongKinh_MP = :ThiLucKhiRaVien_KhongKinh_MP, 
ThiLucKhiRaVien_KhongKinh_MT = :ThiLucKhiRaVien_KhongKinh_MT, 
ThiLucKhiRaVien_CoKinh_MP = :ThiLucKhiRaVien_CoKinh_MP, 
ThiLucKhiRaVien_CoKinh_MT = :ThiLucKhiRaVien_CoKinh_MT, 
NhanApRaVien_MP = :NhanApRaVien_MP, 
NhanApRaVien_MT = :NhanApRaVien_MT,
NoiTietCheck = :NoiTietCheck, 
NoiTiet_Text = :NoiTiet_Text,
ThanKinhCheck = :ThanKinhCheck, 
ThanKinh_Text = :ThanKinh_Text,
TuanHoanCheck = :TuanHoanCheck, 
TuanHoan_Text = :TuanHoan_Text,
HoHapCheck = :HoHapCheck, 
HoHap_Text = :HoHap_Text,
TieuHoaCheck = :TieuHoaCheck, 
TieuHoa_Text = :TieuHoa_Text,
CoXuongKhopCheck = :CoXuongKhopCheck, 
CoXuongKhop_Text = :CoXuongKhop_Text,
TietNieuSinhDucCheck = :TietNieuSinhDucCheck, 
TietNieuSinhDuc_Text = :TietNieuSinhDuc_Text,
KhamBenhToanThan_Khac = :KhamBenhToanThan_Khac 

                        WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnMatTreEm.LyDoVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("VaoNgayThu", BenhAnMatTreEm.VaoNgayThu));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnMatTreEm.QuaTrinhBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhBanThan", BenhAnMatTreEm.TienSuBenhBanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhGiaDinh", BenhAnMatTreEm.TienSuBenhGiaDinh));
            Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnMatTreEm.ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoan", BenhAnMatTreEm.TuanHoan));
            Command.Parameters.Add(new MDB.MDBParameter("HoHap", BenhAnMatTreEm.HoHap));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoa", BenhAnMatTreEm.TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieuSinhDuc", BenhAnMatTreEm.ThanTietNieuSinhDuc));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinh", BenhAnMatTreEm.ThanKinh));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop", BenhAnMatTreEm.CoXuongKhop));
            Command.Parameters.Add(new MDB.MDBParameter("TaiMuiHong", BenhAnMatTreEm.TaiMuiHong));
            Command.Parameters.Add(new MDB.MDBParameter("RangHamMat", BenhAnMatTreEm.RangHamMat));
            Command.Parameters.Add(new MDB.MDBParameter("Mat", BenhAnMatTreEm.Mat));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_CacCoQuan", BenhAnMatTreEm.Khac_CacCoQuan));
            Command.Parameters.Add(new MDB.MDBParameter("CacXetNghiemCanLamSangCanLam", BenhAnMatTreEm.CacXetNghiemCanLamSangCanLam));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatBenhAn", BenhAnMatTreEm.TomTatBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnMatTreEm.BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnMatTreEm.BenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("PhanBiet", BenhAnMatTreEm.PhanBiet));
            Command.Parameters.Add(new MDB.MDBParameter("TienLuong", BenhAnMatTreEm.TienLuong));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnMatTreEm.HuongDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("NgayKhamBenh", BenhAnMatTreEm.NgayKhamBenh));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyLamBenhAn", BenhAnMatTreEm.BacSyLamBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLyVaDienBien", BenhAnMatTreEm.QuaTrinhBenhLyVaDienBien));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQuaXetNghiem", BenhAnMatTreEm.TomTatKetQuaXetNghiem));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnMatTreEm.PhuongPhapDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangNguoiBenhRaVien", BenhAnMatTreEm.TinhTrangNguoiBenhRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriVaCacCheDoTiepTheo", BenhAnMatTreEm.HuongDieuTriVaCacCheDoTiepTheo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnMatTreEm.NguoiNhanHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnMatTreEm.NguoiGiaoHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnMatTreEm.NgayTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnMatTreEm.BacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng", BenhAnMatTreEm.DacDiemLienQuanBenh.DiUng == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng_Text", BenhAnMatTreEm.DacDiemLienQuanBenh.DiUng_Text));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy", BenhAnMatTreEm.DacDiemLienQuanBenh.MaTuy == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy_Text", BenhAnMatTreEm.DacDiemLienQuanBenh.MaTuy_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia", BenhAnMatTreEm.DacDiemLienQuanBenh.RuouBia == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia_Text", BenhAnMatTreEm.DacDiemLienQuanBenh.RuouBia_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa", BenhAnMatTreEm.DacDiemLienQuanBenh.ThuocLa == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa_Text", BenhAnMatTreEm.DacDiemLienQuanBenh.ThuocLa_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao", BenhAnMatTreEm.DacDiemLienQuanBenh.ThuocLao == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao_Text", BenhAnMatTreEm.DacDiemLienQuanBenh.ThuocLao_Text));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh", BenhAnMatTreEm.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh_Text", BenhAnMatTreEm.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh_Text));
            Command.Parameters.Add(new MDB.MDBParameter("NguyenNhan_BamSinh", BenhAnMatTreEm.NguyenNhan_BamSinh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("NguyenNhan_TuBaoGio", BenhAnMatTreEm.NguyenNhan_TuBaoGio));
            Command.Parameters.Add(new MDB.MDBParameter("TrieuChung_NhinMo", BenhAnMatTreEm.TrieuChung_NhinMo == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TrieuChung_DauNhuc", BenhAnMatTreEm.TrieuChung_DauNhuc == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TrieuChung_DoMat", BenhAnMatTreEm.TrieuChung_DoMat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TrieuChung_ChoiMat", BenhAnMatTreEm.TrieuChung_ChoiMat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhBanThan_Tick", BenhAnMatTreEm.TienSuBenhBanThan_Tick == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhGiaDinh_Tick", BenhAnMatTreEm.TienSuBenhGiaDinh_Tick == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuThaiNghenBenhLy", BenhAnMatTreEm.TienSuThaiNghenBenhLy == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuThaiNghenBenhLy_Text", BenhAnMatTreEm.TienSuThaiNghenBenhLy_Text));
            Command.Parameters.Add(new MDB.MDBParameter("PhatTrienTriTue", BenhAnMatTreEm.PhatTrienTriTue == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("PhatTrienTriTue_BenhLyText", BenhAnMatTreEm.PhatTrienTriTue_BenhLyText));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiVaoVien_KhongKinh_MP", BenhAnMatTreEm.ThiLucKhiVaoVien_KhongKinh_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiVaoVien_KhongKinh_MT", BenhAnMatTreEm.ThiLucKhiVaoVien_KhongKinh_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiVaoVien_CoKinh_MP", BenhAnMatTreEm.ThiLucKhiVaoVien_CoKinh_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiVaoVien_CoKinh_MT", BenhAnMatTreEm.ThiLucKhiVaoVien_CoKinh_MT));
            Command.Parameters.Add(new MDB.MDBParameter("NhanApVaoVien_MT", BenhAnMatTreEm.NhanApVaoVien_MT));
            Command.Parameters.Add(new MDB.MDBParameter("NhanApVaoVien_MP", BenhAnMatTreEm.NhanApVaoVien_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThiTruong_MP", BenhAnMatTreEm.ThiTruong_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThiTruong_MT", BenhAnMatTreEm.ThiTruong_MT));
            Command.Parameters.Add(new MDB.MDBParameter("VanNhanNoiTai_MP", BenhAnMatTreEm.VanNhanNoiTai_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("VanNhanNoiTai_Text_MP", BenhAnMatTreEm.VanNhanNoiTai_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("VanNhanNoiTai_MT", BenhAnMatTreEm.VanNhanNoiTai_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("VanNhanNoiTai_Text_MT", BenhAnMatTreEm.VanNhanNoiTai_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("VanNhanNgoaiLai_MP", BenhAnMatTreEm.VanNhanNgoaiLai_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("VanNhanNgoaiLai_Text_MP", BenhAnMatTreEm.VanNhanNgoaiLai_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("VanNhanNgoaiLai_MT", BenhAnMatTreEm.VanNhanNgoaiLai_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("VanNhanNgoaiLai_Text_MT", BenhAnMatTreEm.VanNhanNgoaiLai_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("RungGiatNhanCau", BenhAnMatTreEm.RungGiatNhanCau == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RungGiatNhanCau_Text", BenhAnMatTreEm.RungGiatNhanCau_Text));
            Command.Parameters.Add(new MDB.MDBParameter("MiMat_Quam_MP", BenhAnMatTreEm.MiMat_Quam_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MIMat_Epicanthus", BenhAnMatTreEm.MIMat_Epicanthus == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MiMat_SupMi_MP", BenhAnMatTreEm.MiMat_SupMi_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MiMat_U_MP", BenhAnMatTreEm.MiMat_U_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MiMat_Khac_MP", BenhAnMatTreEm.MiMat_Khac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("LeDao_MP", BenhAnMatTreEm.LeDao_MP));
            Command.Parameters.Add(new MDB.MDBParameter("KetMac_CuongTu_MP", BenhAnMatTreEm.KetMac_CuongTu_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KetMac_XuatHuyet_MP", BenhAnMatTreEm.KetMac_XuatHuyet_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KetMac_XuatTiet_MP", BenhAnMatTreEm.KetMac_XuatTiet_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KetMac_U_MP", BenhAnMatTreEm.KetMac_U_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KetMac_Khac_MP", BenhAnMatTreEm.KetMac_Khac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_Trong_MP", BenhAnMatTreEm.GiacMac_Trong_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_Trong_Text_MP", BenhAnMatTreEm.GiacMac_Trong_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_LoaiDuong_MP", BenhAnMatTreEm.GiacMac_LoaiDuong_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_LoanDuong_Text_MP", BenhAnMatTreEm.GiacMac_LoanDuong_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_ThoaiHoa_MP", BenhAnMatTreEm.GiacMac_ThoaiHoa_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_ThoaiHoa_Text_MP", BenhAnMatTreEm.GiacMac_ThoaiHoa_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_PhuNe_MP", BenhAnMatTreEm.GiacMac_PhuNe_MP));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_U_MP", BenhAnMatTreEm.GiacMac_U_MP));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_Tua_MP", BenhAnMatTreEm.GiacMac_Tua_MP));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_Loet_MP", BenhAnMatTreEm.GiacMac_Loet_MP));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_DiTat_MP", BenhAnMatTreEm.GiacMac_DiTat_MP));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_DuongKinhGM_MP", BenhAnMatTreEm.GiacMac_DuongKinhGM_MP));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_VungRia_MP", BenhAnMatTreEm.GiacMac_VungRia_MP));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_Khac_MP", BenhAnMatTreEm.GiacMac_Khac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("CungMac_GianLoi_MP", BenhAnMatTreEm.CungMac_GianLoi_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CungMac_SeoMo_MP", BenhAnMatTreEm.CungMac_SeoMo_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CungMac_CuongTu_MP", BenhAnMatTreEm.CungMac_CuongTu_MP));
            Command.Parameters.Add(new MDB.MDBParameter("CungMac_Viem_MP", BenhAnMatTreEm.CungMac_Viem_MP));
            Command.Parameters.Add(new MDB.MDBParameter("CungMac_Khac_MP", BenhAnMatTreEm.CungMac_Khac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TienPhong_DoSau_MP", BenhAnMatTreEm.TienPhong_DoSau_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TienPhong_Tydall_MP", BenhAnMatTreEm.TienPhong_Tydall_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TienPhong_Mu_MP", BenhAnMatTreEm.TienPhong_Mu_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TienPhong_Mau_MP", BenhAnMatTreEm.TienPhong_Mau_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TienPhong_GocTienPhong_MP", BenhAnMatTreEm.TienPhong_GocTienPhong_MP));
            Command.Parameters.Add(new MDB.MDBParameter("MongMat_MP", BenhAnMatTreEm.MongMat_MP));
            Command.Parameters.Add(new MDB.MDBParameter("MongMat_MauSac_MP", BenhAnMatTreEm.MongMat_MauSac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("MongMat_TinhTrang_MP", BenhAnMatTreEm.MongMat_TinhTrang_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MongMat_TanMach_MP", BenhAnMatTreEm.MongMat_TanMach_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MongMat_CamGiac_MP", BenhAnMatTreEm.MongMat_CamGiac_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MongMat_U_MP", BenhAnMatTreEm.MongMat_U_MP));
            Command.Parameters.Add(new MDB.MDBParameter("MongMat_DiDang_MP", BenhAnMatTreEm.MongMat_DiDang_MP));
            Command.Parameters.Add(new MDB.MDBParameter("DongTu_Trong_MP", BenhAnMatTreEm.DongTu_Trong_MP));
            Command.Parameters.Add(new MDB.MDBParameter("DongTu_DuongKinh_MP", BenhAnMatTreEm.DongTu_DuongKinh_MP));
            Command.Parameters.Add(new MDB.MDBParameter("DongTu_VienSacTo_MP", BenhAnMatTreEm.DongTu_VienSacTo_MP));
            Command.Parameters.Add(new MDB.MDBParameter("DongTu_PhanXa_MP", BenhAnMatTreEm.DongTu_PhanXa_MP));
            Command.Parameters.Add(new MDB.MDBParameter("DongTu_DiDang_MP", BenhAnMatTreEm.DongTu_DiDang_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TheThuyTinh_MP", BenhAnMatTreEm.TheThuyTinh_MP));
            Command.Parameters.Add(new MDB.MDBParameter("DichKinh_MP", BenhAnMatTreEm.DichKinh_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DichKinh_Text_MP", BenhAnMatTreEm.DichKinh_Text_MP));
            Command.Parameters.Add(new MDB.MDBParameter("DayMat_VongMac_MP", BenhAnMatTreEm.DayMat_VongMac_MP));
            Command.Parameters.Add(new MDB.MDBParameter("DayMat_HoangDiem_MP", BenhAnMatTreEm.DayMat_HoangDiem_MP));
            Command.Parameters.Add(new MDB.MDBParameter("DayMat_MachMau_MP", BenhAnMatTreEm.DayMat_MachMau_MP));
            Command.Parameters.Add(new MDB.MDBParameter("DayMat_DiaThi_MP", BenhAnMatTreEm.DayMat_DiaThi_MP));
            Command.Parameters.Add(new MDB.MDBParameter("DayMat_U_MP", BenhAnMatTreEm.DayMat_U_MP));
            Command.Parameters.Add(new MDB.MDBParameter("NhanCau_Mem_MP", BenhAnMatTreEm.NhanCau_Mem_MP == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("NhanCau_To_MP", BenhAnMatTreEm.NhanCau_To_MP));
            Command.Parameters.Add(new MDB.MDBParameter("MiMat_Quam_MT", BenhAnMatTreEm.MiMat_Quam_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MIMat_EpicanthusMT", BenhAnMatTreEm.MIMat_EpicanthusMT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MiMat_SupMi_MT", BenhAnMatTreEm.MiMat_SupMi_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MiMat_U_MT", BenhAnMatTreEm.MiMat_U_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MiMat_Khac_MT", BenhAnMatTreEm.MiMat_Khac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("LeDao_MT", BenhAnMatTreEm.LeDao_MT));
            Command.Parameters.Add(new MDB.MDBParameter("KetMac_CuongTu_MT", BenhAnMatTreEm.KetMac_CuongTu_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KetMac_XuatHuyet_MT", BenhAnMatTreEm.KetMac_XuatHuyet_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KetMac_XuatTiet_MT", BenhAnMatTreEm.KetMac_XuatTiet_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KetMac_U_MT", BenhAnMatTreEm.KetMac_U_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("KetMac_Khac_MT", BenhAnMatTreEm.KetMac_Khac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_Trong_MT", BenhAnMatTreEm.GiacMac_Trong_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_Trong_Text_MT", BenhAnMatTreEm.GiacMac_Trong_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_LoaiDuong_MT", BenhAnMatTreEm.GiacMac_LoaiDuong_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_LoanDuong_Text_MT", BenhAnMatTreEm.GiacMac_LoanDuong_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_ThoaiHoa_MT", BenhAnMatTreEm.GiacMac_ThoaiHoa_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_ThoaiHoa_Text_MT", BenhAnMatTreEm.GiacMac_ThoaiHoa_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_PhuNe_MT", BenhAnMatTreEm.GiacMac_PhuNe_MT));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_U_MT", BenhAnMatTreEm.GiacMac_U_MT));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_Tua_MT", BenhAnMatTreEm.GiacMac_Tua_MT));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_Loet_MT", BenhAnMatTreEm.GiacMac_Loet_MT));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_DiTat_MT", BenhAnMatTreEm.GiacMac_DiTat_MT));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_DuongKinhGM_MT", BenhAnMatTreEm.GiacMac_DuongKinhGM_MT));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_VungRia_MT", BenhAnMatTreEm.GiacMac_VungRia_MT));
            Command.Parameters.Add(new MDB.MDBParameter("GiacMac_Khac_MT", BenhAnMatTreEm.GiacMac_Khac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("CungMac_GianLoi_MT", BenhAnMatTreEm.CungMac_GianLoi_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CungMac_SeoMo_MT", BenhAnMatTreEm.CungMac_SeoMo_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CungMac_CuongTu_MT", BenhAnMatTreEm.CungMac_CuongTu_MT));
            Command.Parameters.Add(new MDB.MDBParameter("CungMac_Viem_MT", BenhAnMatTreEm.CungMac_Viem_MT));
            Command.Parameters.Add(new MDB.MDBParameter("CungMac_Khac_MT", BenhAnMatTreEm.CungMac_Khac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TienPhong_DoSau_MT", BenhAnMatTreEm.TienPhong_DoSau_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TienPhong_Tydall_MT", BenhAnMatTreEm.TienPhong_Tydall_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TienPhong_Mu_MT", BenhAnMatTreEm.TienPhong_Mu_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TienPhong_Mau_MT", BenhAnMatTreEm.TienPhong_Mau_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TienPhong_GocTienPhong_MT", BenhAnMatTreEm.TienPhong_GocTienPhong_MT));
            Command.Parameters.Add(new MDB.MDBParameter("MongMat_MT", BenhAnMatTreEm.MongMat_MT));
            Command.Parameters.Add(new MDB.MDBParameter("MongMat_MauSac_MT", BenhAnMatTreEm.MongMat_MauSac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("MongMat_TinhTrang_MT", BenhAnMatTreEm.MongMat_TinhTrang_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MongMat_TanMach_MT", BenhAnMatTreEm.MongMat_TanMach_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MongMat_CamGiac_MT", BenhAnMatTreEm.MongMat_CamGiac_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MongMat_U_MT", BenhAnMatTreEm.MongMat_U_MT));
            Command.Parameters.Add(new MDB.MDBParameter("MongMat_DiDang_MT", BenhAnMatTreEm.MongMat_DiDang_MT));
            Command.Parameters.Add(new MDB.MDBParameter("DongTu_Trong_MT", BenhAnMatTreEm.DongTu_Trong_MT));
            Command.Parameters.Add(new MDB.MDBParameter("DongTu_DuongKinh_MT", BenhAnMatTreEm.DongTu_DuongKinh_MT));
            Command.Parameters.Add(new MDB.MDBParameter("DongTu_VienSacTo_MT", BenhAnMatTreEm.DongTu_VienSacTo_MT));
            Command.Parameters.Add(new MDB.MDBParameter("DongTu_PhanXa_MT", BenhAnMatTreEm.DongTu_PhanXa_MT));
            Command.Parameters.Add(new MDB.MDBParameter("DongTu_DiDang_MT", BenhAnMatTreEm.DongTu_DiDang_MT));
            Command.Parameters.Add(new MDB.MDBParameter("TheThuyTinh_MT", BenhAnMatTreEm.TheThuyTinh_MT));
            Command.Parameters.Add(new MDB.MDBParameter("DichKinh_MT", BenhAnMatTreEm.DichKinh_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DichKinh_Text_MT", BenhAnMatTreEm.DichKinh_Text_MT));
            Command.Parameters.Add(new MDB.MDBParameter("DayMat_VongMac_MT", BenhAnMatTreEm.DayMat_VongMac_MT));
            Command.Parameters.Add(new MDB.MDBParameter("DayMat_HoangDiem_MT", BenhAnMatTreEm.DayMat_HoangDiem_MT));
            Command.Parameters.Add(new MDB.MDBParameter("DayMat_MachMau_MT", BenhAnMatTreEm.DayMat_MachMau_MT));
            Command.Parameters.Add(new MDB.MDBParameter("DayMat_DiaThi_MT", BenhAnMatTreEm.DayMat_DiaThi_MT));
            Command.Parameters.Add(new MDB.MDBParameter("DayMat_U_MT", BenhAnMatTreEm.DayMat_U_MT));
            Command.Parameters.Add(new MDB.MDBParameter("NhanCau_Mem_MT", BenhAnMatTreEm.NhanCau_Mem_MT == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("NhanCau_To_MT", BenhAnMatTreEm.NhanCau_To_MT));
            Command.Parameters.Add(new MDB.MDBParameter("HuyetAp_ToanThan", BenhAnMatTreEm.HuyetAp_ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("NhietDo_ToanThan", BenhAnMatTreEm.NhietDo_ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("Mach_ToanThan", BenhAnMatTreEm.Mach_ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("NoiTiet_Tick", BenhAnMatTreEm.NoiTiet_Tick == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("NoiTiet", BenhAnMatTreEm.NoiTiet));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinh_Tick", BenhAnMatTreEm.ThanKinh_Tick == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoan_Tick", BenhAnMatTreEm.TuanHoan_Tick == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("HoHap_Tick", BenhAnMatTreEm.HoHap_Tick == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoa_Tick", BenhAnMatTreEm.TieuHoa_Tick == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop_Tick", BenhAnMatTreEm.CoXuongKhop_Tick == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieu_Tick", BenhAnMatTreEm.ThanTietNieu_Tick == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinh_MatPhai", BenhAnMatTreEm.BenhChinh_MatPhai));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinh_MatTrai", BenhAnMatTreEm.BenhChinh_MatTrai));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapChinh", BenhAnMatTreEm.PhuongPhapChinh));
            Command.Parameters.Add(new MDB.MDBParameter("CheDoAnUong", BenhAnMatTreEm.CheDoAnUong));
            Command.Parameters.Add(new MDB.MDBParameter("CheDoChamSoc", BenhAnMatTreEm.CheDoChamSoc));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanBenhChinh_LamSang", BenhAnMatTreEm.ChanDoanBenhChinh_LamSang));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanBenhChinh_NguyenNhan", BenhAnMatTreEm.ChanDoanBenhChinh_NguyenNhan));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhDieuTri_NoiKhoa", BenhAnMatTreEm.QuaTrinhDieuTri_NoiKhoa));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhDieuTri_KetQua", BenhAnMatTreEm.QuaTrinhDieuTri_KetQua));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhDieuTri_BienChung", BenhAnMatTreEm.QuaTrinhDieuTri_BienChung));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriTiep", BenhAnMatTreEm.HuongDieuTriTiep));
            Command.Parameters.Add(new MDB.MDBParameter("DaDieuTri_NoiKhoa", BenhAnMatTreEm.DaDieuTri_NoiKhoa == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DaDieuTri_PhauThuat", BenhAnMatTreEm.DaDieuTri_PhauThuat));
            Command.Parameters.Add(new MDB.MDBParameter("ChuaThayBenhLy", BenhAnMatTreEm.ChuaThayBenhLy ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BenhLy", BenhAnMatTreEm.BenhLy ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("BenhLy_Text", BenhAnMatTreEm.BenhLy_Text));
            Command.Parameters.Add(new MDB.MDBParameter("PhauThuat", BenhAnMatTreEm.PhauThuat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuThuat", BenhAnMatTreEm.ThuThuat == true ? "1" : "0"));

            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiRaVien_KhongKinh_MP", BenhAnMatTreEm.ThiLucKhiRaVien_KhongKinh_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiRaVien_KhongKinh_MT", BenhAnMatTreEm.ThiLucKhiRaVien_KhongKinh_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiRaVien_CoKinh_MP", BenhAnMatTreEm.ThiLucKhiRaVien_CoKinh_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiRaVien_CoKinh_MT", BenhAnMatTreEm.ThiLucKhiRaVien_CoKinh_MT));
            Command.Parameters.Add(new MDB.MDBParameter("NhanApRaVien_MT", BenhAnMatTreEm.NhanApRaVien_MT));
            Command.Parameters.Add(new MDB.MDBParameter("NhanApRaVien_MP", BenhAnMatTreEm.NhanApRaVien_MP));

            Command.Parameters.Add(new MDB.MDBParameter("NoiTietCheck", BenhAnMatTreEm.NoiTietCheck));
            Command.Parameters.Add(new MDB.MDBParameter("NoiTiet_Text", BenhAnMatTreEm.NoiTiet_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinhCheck", BenhAnMatTreEm.ThanKinhCheck));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinh_Text", BenhAnMatTreEm.ThanKinh_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoanCheck", BenhAnMatTreEm.TuanHoanCheck));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoan_Text", BenhAnMatTreEm.TuanHoan_Text));
            Command.Parameters.Add(new MDB.MDBParameter("HoHapCheck", BenhAnMatTreEm.HoHapCheck));
            Command.Parameters.Add(new MDB.MDBParameter("HoHap_Text", BenhAnMatTreEm.HoHap_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoaCheck", BenhAnMatTreEm.TieuHoaCheck));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoa_Text", BenhAnMatTreEm.TieuHoa_Text));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhopCheck", BenhAnMatTreEm.CoXuongKhopCheck));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop_Text", BenhAnMatTreEm.CoXuongKhop_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TietNieuSinhDucCheck", BenhAnMatTreEm.TietNieuSinhDucCheck));
            Command.Parameters.Add(new MDB.MDBParameter("TietNieuSinhDuc_Text", BenhAnMatTreEm.TietNieuSinhDuc_Text));
            Command.Parameters.Add(new MDB.MDBParameter("KhamBenhToanThan_Khac", BenhAnMatTreEm.KhamBenhToanThan_Khac));

            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnMatTreEm.MaQuanLy));
            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool Delete(MDB.MDBConnection MyConnection, BenhAnMatTreEm BenhAnMatTreEm)
        {
            string sql = @"DELETE FROM BenhAnMatTreEm 
                           WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnMatTreEm.MaQuanLy));

            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
    }
}
