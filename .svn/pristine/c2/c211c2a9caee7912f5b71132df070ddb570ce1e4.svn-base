using PMS.Access;
using System;

namespace EMR_MAIN
{
    public class ThongTinDieuTriFunc
    {
        public static ThongTinDieuTri Select(MDB.MDBConnection MyConnection, decimal MaQuanLy,string MaCSKCB=null)
        {
            try
            {
                #region
                string sql =
                          @"select * 
                        from ThongTinDieuTri a
                        where MaQuanLy = :MaQuanLy";
                if (MaCSKCB.IsNotNullOrEmpty())
                {
                    sql += " and macskcb='" + MaCSKCB + "'";
                }
                #endregion
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add("MaQuanLy", MaQuanLy);
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                ThongTinDieuTri ThongTinDieuTri = new ThongTinDieuTri();
                while (DataReader.Read())
                {
                    ThongTinDieuTri.KhoaRaVien = DataReader["KhoaRaVien"].ToString();
                    ThongTinDieuTri.GiuongRaVien = DataReader["GiuongRaVien"].ToString();
                    ThongTinDieuTri.SoLuuTru = DataReader["SoLuuTru"].ToString();
                    ThongTinDieuTri.SoNgoaiTru = DataReader["SoNgoaiTru"].ToString();
                    ThongTinDieuTri.Khoa = DataReader["Khoa"].ToString();
                    ThongTinDieuTri.MaQuanLy = DataReader.GetDecimal("MaQuanLy");
                    ThongTinDieuTri.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    ThongTinDieuTri.NgayVaoVien = DataReader.GetDate("NgayVaoVien");
                    ThongTinDieuTri.TrucTiepVao = (TrucTiepVao)DataReader.GetInt("TrucTiepVao");
                    ThongTinDieuTri.NoiGioiThieu = (NoiGioiThieu)DataReader.GetInt("NoiGioiThieu");
                    ThongTinDieuTri.VaoVienDoBenhNayLanThu = DataReader.GetInt("VaoVienDoBenhNayLanThu");
                    ThongTinDieuTri.IDLoaiBenhAn = DataReader.GetInt("IDLoaiBenhAn");
                    ThongTinDieuTri.TenKhoaVao = DataReader["TenKhoaVao"].ToString();
                    if (DataReader["NgayVaoKhoa"] != DBNull.Value)
                        ThongTinDieuTri.NgayVaoKhoa = DataReader.GetDate("NgayVaoKhoa");
                    if (DataReader["SoNgayDieuTriTaiKhoa"] != DBNull.Value)
                        ThongTinDieuTri.SoNgayDieuTriTaiKhoa = DataReader.GetInt("SoNgayDieuTriTaiKhoa");
                    ThongTinDieuTri.ChuyenKhoa1 = DataReader["ChuyenKhoa1"].ToString();
                    if (DataReader["NgayChuyenKhoa1"] != DBNull.Value)
                        ThongTinDieuTri.NgayChuyenKhoa1 = DataReader.GetDate("NgayChuyenKhoa1");
                    if (DataReader["SoNgayDieuTriKhoa1"] != DBNull.Value)
                        ThongTinDieuTri.SoNgayDieuTriKhoa1 = DataReader.GetInt("SoNgayDieuTriKhoa1");
                    ThongTinDieuTri.ChuyenKhoa2 = DataReader["ChuyenKhoa2"].ToString();
                    if (DataReader["NgayChuyenKhoa2"] != DBNull.Value)
                        ThongTinDieuTri.NgayChuyenKhoa2 = DataReader.GetDate("NgayChuyenKhoa2");
                    if (DataReader["SoNgayDieuTriKhoa2"] != DBNull.Value)
                        ThongTinDieuTri.SoNgayDieuTriKhoa2 = DataReader.GetInt("SoNgayDieuTriKhoa2");
                    ThongTinDieuTri.ChuyenKhoa3 = DataReader["ChuyenKhoa3"].ToString();
                    if (DataReader["NgayChuyenKhoa3"] != DBNull.Value)
                        ThongTinDieuTri.NgayChuyenKhoa3 = DataReader.GetDate("NgayChuyenKhoa3");
                    if (DataReader["SoNgayDieuTriKhoa3"] != DBNull.Value)
                        ThongTinDieuTri.SoNgayDieuTriKhoa3 = DataReader.GetInt("SoNgayDieuTriKhoa3");
                    if (DataReader["ChuyenVien"] != DBNull.Value)
                        ThongTinDieuTri.ChuyenVien = (ChuyenVien)DataReader.GetInt("ChuyenVien");
                    ThongTinDieuTri.TenVienChuyenBenhNhanDen = DataReader["TenVienChuyenBenhNhanDen"].ToString();
                    ThongTinDieuTri.MaVienChuyenBenhNhanDen = DataReader["MaVienChuyenBenhNhanDen"].ToString();
                    if (DataReader["NgayRaVien"] != DBNull.Value)
                        ThongTinDieuTri.NgayRaVien = DataReader.GetDate("NgayRaVien");
                    if (DataReader["TinhTrangRaVien"] != DBNull.Value)
                        ThongTinDieuTri.TinhTrangRaVien = (TinhTrangRaVien)DataReader.GetInt("TinhTrangRaVien");
                    ThongTinDieuTri.TongSoNgayDieuTri1 = DataReader["TongSoNgayDieuTri1"].ToString();
                    ThongTinDieuTri.TongSoNgayDieuTri2 = DataReader["TongSoNgayDieuTri2"].ToString();
                    ThongTinDieuTri.ChanDoan_NoiChuyenDen = DataReader["ChanDoan_NoiChuyenDen"].ToString();
                    ThongTinDieuTri.ChanDoan_YHCT = DataReader["ChanDoan_YHCT"].ToString();
                    ThongTinDieuTri.MaICD_NoiChuyenDen = DataReader["MaICD_NoiChuyenDen"].ToString();
                    ThongTinDieuTri.ChanDoan_KKB_CapCuu = DataReader["ChanDoan_KKB_CapCuu"].ToString();
                    ThongTinDieuTri.MaICD_KKB_CapCuu = DataReader["MaICD_KKB_CapCuu"].ToString();
                    ThongTinDieuTri.ChanDoan_KhiVaoKhoaDieuTri = DataReader["ChanDoan_KhiVaoKhoaDieuTri"].ToString();
                    ThongTinDieuTri.MaICD_KhiVaoKhoaDieuTri = DataReader["MaICD_KhiVaoKhoaDieuTri"].ToString();
                    ThongTinDieuTri.BenhChinh_RaVien = DataReader["BenhChinh_RaVien"].ToString();
                    ThongTinDieuTri.MaICD_BenhChinh_RaVien = DataReader["MaICD_BenhChinh_RaVien"].ToString();
                    ThongTinDieuTri.BenhKemTheo_RaVien = DataReader["BenhKemTheo_RaVien"].ToString();
                    ThongTinDieuTri.MaICD_BenhKemTheo_RaVien = DataReader["MaICD_BenhKemTheo_RaVien"].ToString();
                    ThongTinDieuTri.BenhKemTheo_RaVien1 = DataReader["BenhKemTheo_RaVien1"].ToString();
                    ThongTinDieuTri.MaICD_BenhKemTheo_RaVien1 = DataReader["MaICD_BenhKemTheo_RaVien1"].ToString();
                    ThongTinDieuTri.BenhKemTheo_RaVien2 = DataReader["BenhKemTheo_RaVien2"].ToString();
                    ThongTinDieuTri.MaICD_BenhKemTheo_RaVien2 = DataReader["MaICD_BenhKemTheo_RaVien2"].ToString();
                    ThongTinDieuTri.ThuThuat = DataReader["ThuThuat"].ToString() == "1" ? true : false;
                    ThongTinDieuTri.PhauThuat = DataReader["PhauThuat"].ToString() == "1" ? true : false;
                    ThongTinDieuTri.TaiBien = DataReader["TaiBien"].ToString() == "1" ? true : false;
                    ThongTinDieuTri.BienChung = DataReader["BienChung"].ToString() == "1" ? true : false;
                    if (DataReader["KetQuaDieuTri"] != DBNull.Value)
                        ThongTinDieuTri.KetQuaDieuTri = (KetQuaDieuTri)DataReader.GetInt("KetQuaDieuTri");
                    if (DataReader["GiaiPhauBenh"] != DBNull.Value)
                        ThongTinDieuTri.GiaiPhauBenh = (GiaiPhauBenh)DataReader.GetInt("GiaiPhauBenh");
                    if (DataReader["NgayTuVong"] != DBNull.Value)
                        ThongTinDieuTri.NgayTuVong = DataReader.GetDate("NgayTuVong");
                    if (DataReader["LyDoTuVong"] != DBNull.Value)
                        ThongTinDieuTri.LyDoTuVong = (LyDoTuVong)DataReader.GetInt("LyDoTuVong");
                    if (DataReader["ThoiGianTuVong"] != DBNull.Value)
                        ThongTinDieuTri.ThoiGianTuVong = (ThoiGianTuVong)DataReader.GetInt("ThoiGianTuVong");
                    ThongTinDieuTri.NguyenNhanChinhTuVong = DataReader["NguyenNhanChinhTuVong"].ToString();
                    ThongTinDieuTri.MaICD_NguyenNhanChinhTuVong = DataReader["MaICD_NguyenNhanChinhTuVong"].ToString();
                    ThongTinDieuTri.KhamNghiemTuThi = DataReader["KhamNghiemTuThi"].ToString() == "1" ? true : false;
                    ThongTinDieuTri.ChanDoanGiaiPhauTuThi = DataReader["ChanDoanGiaiPhauTuThi"].ToString();
                    ThongTinDieuTri.MaICD_ChanDoanGiaiPhauTuThi = DataReader["MaICD_ChanDoanGiaiPhauTuThi"].ToString();
                    ThongTinDieuTri.MaGiamDocBenhVien = DataReader["MaGiamDocBenhVien"].ToString();
                    if (DataReader["NgayThangNamTrangBia"] != DBNull.Value)
                        ThongTinDieuTri.NgayThangNamTrangBia = DataReader.GetDate("NgayThangNamTrangBia");
                    ThongTinDieuTri.MaTruongKhoa = DataReader["MaTruongKhoa"].ToString();
                    ThongTinDieuTri.ChanDoanCuaNoiGioiThieu = DataReader["ChanDoanCuaNoiGioiThieu"].ToString();
                    ThongTinDieuTri.MaBenhAn = DataReader["MaBenhAn"].ToString();
                    ThongTinDieuTri.MaKhoa = DataReader["MaKhoa"].ToString();
                    ThongTinDieuTri.Giuong = DataReader["Giuong"].ToString();
                    ThongTinDieuTri.TenGiuong = DataReader["TenGiuong"].ToString();
                    ThongTinDieuTri.HoSo = new HoSo
                    {
                        CTScanner = DataReader.GetInt("CTScanner"),
                        SieuAm = DataReader.GetInt("SieuAm"),
                        XetNghiem = DataReader.GetInt("XetNghiem"),
                        Khac = DataReader.GetInt("Khac"),
                        Khac_Text = DataReader["Khac_Text"].ToString(),
                        ToanBoHoSo = DataReader.GetInt("ToanBoHoSo"),
                        XQuang = DataReader.GetInt("XQuang"),
                    };
                    int tempInt = 0;
                    double tempDouble;
                    ThongTinDieuTri.DauSinhTon = new DauSinhTon
                    {
                        Mach = int.TryParse(DataReader["Mach"].ToString(), out tempInt) ? (int?)tempInt : null,
                        NhietDo = double.TryParse(DataReader["NhietDo"].ToString(), out tempDouble) ? (double?)tempDouble : null,
                        HuyetAp = DataReader["HuyetAp"].ToString(),
                        NhipTho = int.TryParse(DataReader["NhipTho"].ToString(), out tempInt) ? (int?)tempInt : null,
                        CanNang = double.TryParse(DataReader["CanNang"].ToString(), out tempDouble) ? (double?)tempDouble : null,
                        ChieuCao = double.TryParse(DataReader["ChieuCao"].ToString(), out tempDouble) ? (double?)tempDouble : null,
                        BMI = double.TryParse(DataReader["BMI"].ToString(), out tempDouble) ? (double?)tempDouble : null,
                    };
                    if (DataReader["YHCT_KetQuaDieutTriID"] != DBNull.Value)
                        ThongTinDieuTri.YHCT_KetQuaDieutTriID = DataReader.GetInt("YHCT_KetQuaDieutTriID");
                    ThongTinDieuTri.YHCT_ChuanDoanaRaVien = DataReader["YHCT_ChuanDoanaRaVien"].ToString();
                    ThongTinDieuTri.YHCT_NguyenNhan = DataReader["YHCT_NguyenNhan"].ToString();
                    ThongTinDieuTri.YHCT_TangPhu = DataReader["YHCT_TangPhu"].ToString();
                    ThongTinDieuTri.YHCT_BatCuong = DataReader["YHCT_BatCuong"].ToString();
                    ThongTinDieuTri.YHCT_KinhMach = DataReader["YHCT_KinhMach"].ToString();
                    ThongTinDieuTri.YHCT_BenhDanh = DataReader["YHCT_BenhDanh"].ToString();
                    ThongTinDieuTri.YHCT_NoiDieuTri = DataReader["YHCT_NoiDieuTri"].ToString();
                    ThongTinDieuTri.YHHD_NoiDieuTri = DataReader["YHHD_NoiDieuTri"].ToString();
                    ThongTinDieuTri.YHHD_BenhChinh = DataReader["YHHD_BenhChinh"].ToString();
                    ThongTinDieuTri.YHHD_BenhKemTheo = DataReader["YHHD_BenhKemTheo"].ToString();
                    ThongTinDieuTri.ChanDoanKKBYHCT = DataReader["ChanDoanKKBYHCT"].ToString();
                    ThongTinDieuTri.ChanDoanKKBYHHD = DataReader["ChanDoanKKBYHHD"].ToString();
                    ThongTinDieuTri.ChanDoanNoiGioiThieu = DataReader["ChanDoanNoiGioiThieu"].ToString();
                    if (DataReader["TongSoNgayDieuTriSauPT"] != DBNull.Value)
                        ThongTinDieuTri.TongSoNgayDieuTriSauPT = DataReader.GetInt("TongSoNgayDieuTriSauPT");
                    if (DataReader["TongSoLanPhauThuat"] != DBNull.Value)
                        ThongTinDieuTri.TongSoLanPhauThuat = DataReader.GetInt("TongSoLanPhauThuat");
                    ThongTinDieuTri.NguyenNhan_BenhChinh_RaVien = DataReader["NguyenNhan_BenhChinh_RaVien"].ToString();
                    ThongTinDieuTri.MaICD_NguyenNhan_BenhChinh_RV = DataReader["MaICD_NguyenNhan_BenhChinh_RV"].ToString();
                    ThongTinDieuTri.ChanDoanTruocPhauThuat = DataReader["ChanDoanTruocPhauThuat"].ToString();
                    ThongTinDieuTri.ChanDoanSauPhauThuat = DataReader["ChanDoanSauPhauThuat"].ToString();
                    ThongTinDieuTri.MaICD_ChanDoanTruocPhauThuat = DataReader["MaICD_ChanDoanTruocPhauThuat"].ToString();
                    ThongTinDieuTri.MaICD_ChanDoanSauPhauThuat = DataReader["MaICD_ChanDoanSauPhauThuat"].ToString();
                    ThongTinDieuTri.LucVaoDe = DataReader["LucVaoDe"].ToString();
                    if (DataReader["NgayDe"] != DBNull.Value)
                        ThongTinDieuTri.NgayDe = DataReader.GetDate("NgayDe");
                    ThongTinDieuTri.NgoiThai = DataReader["NgoiThai"].ToString();
                    ThongTinDieuTri.CachThucDe = DataReader["CachThucDe"].ToString();
                    ThongTinDieuTri.KiemSoatTuCung = DataReader["KiemSoatTuCung"].ToString() == "1" ? true : false;
                    ThongTinDieuTri.KiemSoatTuCung_Text = DataReader["KiemSoatTuCung_Text"].ToString();
                    ThongTinDieuTri.PhuongPhapPhauThuat = DataReader["PhuongPhapPhauThuat"].ToString();
                    if (DataReader["LyDoTaiBienBienChung"] != DBNull.Value)
                        ThongTinDieuTri.LyDoTaiBienBienChung = DataReader.GetInt("LyDoTaiBienBienChung");
                    ThongTinDieuTri.TinhHinhPhauThuat = DataReader["TinhHinhPhauThuat"].ToString() == "1" ? true : false;
                    ThongTinDieuTri.TreSoSinh_LoaiThai = DataReader.GetInt("TreSoSinh_LoaiThai");
                    ThongTinDieuTri.TreSoSinh_GioiTinh = DataReader.GetInt("TreSoSinh_GioiTinh");
                    ThongTinDieuTri.TreSoSinh_DiTat = DataReader.GetInt("TreSoSinh_DiTat");
                    ThongTinDieuTri.TreSoSinh_DiTat_Text = DataReader["TreSoSinh_DiTat_Text"].ToString();
                    if (DataReader["TreSoSinh_CanNang"] != DBNull.Value)
                        ThongTinDieuTri.TreSoSinh_CanNang = DataReader.GetInt("TreSoSinh_CanNang");
                    ThongTinDieuTri.TreSoSinh_SongChet = DataReader.GetInt("TreSoSinh_SongChet");
                    ThongTinDieuTri.sYHCT_TangPhuID = DataReader["YHCT_TangPhuID"].ToString();
                    ThongTinDieuTri.sYHCT_BatCuongID = DataReader["YHCT_BatCuongID"].ToString();
                    ThongTinDieuTri.sYHCT_KinhMachID = DataReader["YHCT_KinhMachID"].ToString();
                    ThongTinDieuTri.sYHCT_DinhViBenhID = DataReader["YHCT_DinhViBenhID"].ToString();
                    ThongTinDieuTri.sYHCT_NguyenNhanID = DataReader["YHCT_NguyenNhanID"].ToString();
                    ThongTinDieuTri.LyDoVaoVien = DataReader["LyDoVaoVien"].ToString();
                    ThongTinDieuTri.MaCSKCB = DataReader["MaCSKCB"].ToString();
                    ThongTinDieuTri.TenGiamDocBenhVien = DataReader["TenGiamDocBenhVien"].ToString();
                    ThongTinDieuTri.TenTruongKhoa = DataReader["TenTruongKhoa"].ToString();
                }

                return ThongTinDieuTri;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return null;
        }

        public static bool checkExistThongTinDieuTri(MDB.MDBConnection MyConnection, decimal maQuanLy)
        {
            #region
            string sql =
                      @"select MaQuanLy
                        from ThongTinDieuTri a
                        where MaQuanLy = :MaQuanLy";
            #endregion
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add("MaQuanLy", maQuanLy);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            int rowCount = 0;
            while (DataReader.Read()) rowCount++;
            return (rowCount == 1);
        }


        public static bool InsertOrUpdateThongTinDieuTri(MDB.MDBConnection MyConnection, ThongTinDieuTri thongTinDieuTri)
        {
            // XuLyLoi.LogDebug("dangtung - Start InsertOrUpdateThongTinDieuTri");
            //  log("dangtung - MaQuanLy : " + thongTinDieuTri.MaQuanLy);
            if (thongTinDieuTri == null)
            {
                MDB.ExceptionExtend.LogError(new Exception("thongTinDieuTri is null"));
                return false;
            }
            if (MyConnection == null || MyConnection.State != System.Data.ConnectionState.Open)
            {
                MDB.ExceptionExtend.LogError(new Exception("MDB.MDBConnection not open"));
                return false;
            }
            //#region
            //string sql =
            //          @"select MaQuanLy 
            //            from thongTinDieuTri
            //            where MaQuanLy = :MaQuanLy";
            //#endregion
            //MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            //Command.Parameters.Add("MaQuanLy", thongTinDieuTri.MaQuanLy);
            //MDB.MDBDataReader DataReader = Command.ExecuteReader();
            //int rowCount = 0;
            //while (DataReader.Read()) rowCount++;
            //if (rowCount == 1) return UpdateThongTinDieuTri(MyConnection, thongTinDieuTri);
            string sql = @"UPDATE ThongTinDieuTri SET 
                        KhoaRaVien = :KhoaRaVien,
                        GiuongRaVien = :GiuongRaVien,
                        SoLuuTru = :SoLuuTru,
                        SoNgoaiTru= :SoNgoaiTru,
                        Khoa= :Khoa,
                        MaBenhNhan = :MaBenhNhan,
                        NgayVaoVien = :NgayVaoVien,
                        TrucTiepVao = :TrucTiepVao,
                        NoiGioiThieu = :NoiGioiThieu,
                        VaoVienDoBenhNayLanThu = :VaoVienDoBenhNayLanThu,
                        IDLoaiBenhAn = :IDLoaiBenhAn,
                        TenKhoaVao = :TenKhoaVao,
                        NgayVaoKhoa = :NgayVaoKhoa,
                        SoNgayDieuTriTaiKhoa = :SoNgayDieuTriTaiKhoa,
                        ChuyenKhoa1 = :ChuyenKhoa1,
                        NgayChuyenKhoa1 = :NgayChuyenKhoa1,
                        SoNgayDieuTriKhoa1 = :SoNgayDieuTriKhoa1,
                        ChuyenKhoa2 = :ChuyenKhoa2,
                        NgayChuyenKhoa2 = :NgayChuyenKhoa2,
                        SoNgayDieuTriKhoa2 = :SoNgayDieuTriKhoa2,
                        ChuyenKhoa3 = :ChuyenKhoa3,
                        NgayChuyenKhoa3 = :NgayChuyenKhoa3,
                        SoNgayDieuTriKhoa3 = :SoNgayDieuTriKhoa3,
                        ChuyenVien = :ChuyenVien,
                        TenVienChuyenBenhNhanDen = :TenVienChuyenBenhNhanDen,
                        MaVienChuyenBenhNhanDen = :MaVienChuyenBenhNhanDen,
                        NgayRaVien = :NgayRaVien,
                        TinhTrangRaVien = :TinhTrangRaVien,
                        TongSoNgayDieuTri1 = :TongSoNgayDieuTri1,
                        TongSoNgayDieuTri2 = :TongSoNgayDieuTri2,
                        ChanDoan_NoiChuyenDen = :ChanDoan_NoiChuyenDen,
                        ChanDoan_YHCT = :ChanDoan_YHCT,
                        MaICD_NoiChuyenDen = :MaICD_NoiChuyenDen,
                        ChanDoan_KKB_CapCuu = :ChanDoan_KKB_CapCuu,
                        MaICD_KKB_CapCuu = :MaICD_KKB_CapCuu,
                        ChanDoan_KhiVaoKhoaDieuTri = :ChanDoan_KhiVaoKhoaDieuTri,
                        MaICD_KhiVaoKhoaDieuTri = :MaICD_KhiVaoKhoaDieuTri,
                        BenhChinh_RaVien = :BenhChinh_RaVien,
                        MaICD_BenhChinh_RaVien = :MaICD_BenhChinh_RaVien,
                        BenhKemTheo_RaVien = :BenhKemTheo_RaVien,
                        MaICD_BenhKemTheo_RaVien = :MaICD_BenhKemTheo_RaVien,
                        BenhKemTheo_RaVien1 = :BenhKemTheo_RaVien1,
                        MaICD_BenhKemTheo_RaVien1 = :MaICD_BenhKemTheo_RaVien1,
                        BenhKemTheo_RaVien2 = :BenhKemTheo_RaVien2,
                        MaICD_BenhKemTheo_RaVien2 = :MaICD_BenhKemTheo_RaVien2,
                        ThuThuat = :ThuThuat,
                        PhauThuat = :PhauThuat,
                        TaiBien = :TaiBien,
                        BienChung = :BienChung,
                        KetQuaDieuTri = :KetQuaDieuTri,
                        GiaiPhauBenh = :GiaiPhauBenh,
                        NgayTuVong = :NgayTuVong,
                        LyDoTuVong = :LyDoTuVong,
                        ThoiGianTuVong = :ThoiGianTuVong,
                        NguyenNhanChinhTuVong = :NguyenNhanChinhTuVong,
                        MaICD_NguyenNhanChinhTuVong = :MaICD_NguyenNhanChinhTuVong,
                        KhamNghiemTuThi = :KhamNghiemTuThi,
                        ChanDoanGiaiPhauTuThi = :ChanDoanGiaiPhauTuThi,
                        MaICD_ChanDoanGiaiPhauTuThi = :MaICD_ChanDoanGiaiPhauTuThi,
                        MaGiamDocBenhVien = :MaGiamDocBenhVien,
                        NgayThangNamTrangBia = :NgayThangNamTrangBia,
                        MaTruongKhoa = :MaTruongKhoa,
                        XQuang = :XQuang,
                        CTScanner = :CTScanner,
                        SieuAm = :SieuAm,
                        XetNghiem = :XetNghiem,
                        Khac = :Khac,
                        Khac_Text = :Khac_Text,
                        ToanBoHoSo = :ToanBoHoSo,
                        Mach = :Mach,
                        NhietDo = :NhietDo,
                        HuyetAp = :HuyetAp,
                        NhipTho = :NhipTho,
                        CanNang = :CanNang,
                        ChieuCao= :ChieuCao,
                        BMI = :BMI,
                        ChanDoanCuaNoiGioiThieu = :ChanDoanCuaNoiGioiThieu,
                        YHCT_KetQuaDieutTriID = :YHCT_KetQuaDieutTriID,
                        YHCT_ChuanDoanaRaVien = :YHCT_ChuanDoanaRaVien,
                        YHCT_NguyenNhan = :YHCT_NguyenNhan,
                        YHCT_TangPhu = :YHCT_TangPhu,
                        YHCT_BatCuong = :YHCT_BatCuong,
                        YHCT_KinhMach = :YHCT_KinhMach,
                        YHCT_BenhDanh = :YHCT_BenhDanh,
                        YHCT_NoiDieuTri = :YHCT_NoiDieuTri,
                        YHHD_NoiDieuTri = :YHHD_NoiDieuTri,
                        YHHD_BenhChinh = :YHHD_BenhChinh,
                        YHHD_BenhKemTheo = :YHHD_BenhKemTheo,
                        ChanDoanKKBYHCT = :ChanDoanKKBYHCT,
                        ChanDoanKKBYHHD = :ChanDoanKKBYHHD,
                        ChanDoanNoiGioiThieu = :ChanDoanNoiGioiThieu,
                        Buong = :Buong,
                        SoNhapVien = :SoNhapVien,
                        MaSoBenhTat = :MaSoBenhTat,
                        MaTruongPhongKHTH = :MaTruongPhongKHTH,
                        MaThayThuocDieuTri = :MaThayThuocDieuTri,
                        MaThayThuocKhamBenh = :MaThayThuocKhamBenh,
                        TongSoNgayDieuTriSauPT = :TongSoNgayDieuTriSauPT,
                        TongSoLanPhauThuat = :TongSoLanPhauThuat,
                        NguyenNhan_BenhChinh_RaVien = :NguyenNhan_BenhChinh_RaVien,
                        MaICD_NguyenNhan_BenhChinh_RV = :MaICD_NguyenNhan_BenhChinh_RV,
                        ChanDoanTruocPhauThuat = :ChanDoanTruocPhauThuat,
                        ChanDoanSauPhauThuat = :ChanDoanSauPhauThuat,
                        MaICD_ChanDoanTruocPhauThuat = :MaICD_ChanDoanTruocPhauThuat,
                        MaICD_ChanDoanSauPhauThuat = :MaICD_ChanDoanSauPhauThuat,
                        LucVaoDe = :LucVaoDe,
                        NgayDe = :NgayDe,
                        NgoiThai = :NgoiThai,
                        CachThucDe = :CachThucDe,
                        KiemSoatTuCung = :KiemSoatTuCung,
                        KiemSoatTuCung_Text = :KiemSoatTuCung_Text,
                        PhuongPhapPhauThuat = :PhuongPhapPhauThuat,
                        LyDoTaiBienBienChung = :LyDoTaiBienBienChung,
                        TinhHinhPhauThuat = :TinhHinhPhauThuat,
                        TreSoSinh_LoaiThai = :TreSoSinh_LoaiThai,
                        TreSoSinh_GioiTinh = :TreSoSinh_GioiTinh,
                        TreSoSinh_DiTat = :TreSoSinh_DiTat,
                        TreSoSinh_DiTat_Text = :TreSoSinh_DiTat_Text,
                        TreSoSinh_CanNang = :TreSoSinh_CanNang,
                        TreSoSinh_SongChet = :TreSoSinh_SongChet,
                        YHCT_BatCuongID = :YHCT_BatCuongID,
                        YHCT_TangPhuID = :YHCT_TangPhuID,
                        YHCT_KinhMachID = :YHCT_KinhMachID,
                        YHCT_DinhViBenhID = :YHCT_DinhViBenhID,
                        YHCT_NguyenNhanID = :YHCT_NguyenNhanID,
                        MaBenhAn = :MaBenhAn,
                        MaKhoa = :MaKhoa,
                        Giuong = :Giuong,
                        TenGiuong = :TenGiuong,
                        LyDoVaoVien = :LyDoVaoVien,
                        MaCSKCB = :MaCSKCB,
                        TenGiamDocBenhVien = :TenGiamDocBenhVien,
                        TenTruongKhoa = :TenTruongKhoa 
                        WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add("KhoaRaVien", thongTinDieuTri.KhoaRaVien);
            Command.Parameters.Add("GiuongRaVien", thongTinDieuTri.GiuongRaVien);
            Command.Parameters.Add("SoLuuTru", thongTinDieuTri.SoLuuTru);
            Command.Parameters.Add("SoNgoaiTru", thongTinDieuTri.SoNgoaiTru);
            Command.Parameters.Add("Khoa", thongTinDieuTri.Khoa);
            Command.Parameters.Add("MaBenhNhan", thongTinDieuTri.MaBenhNhan);
            Command.Parameters.Add("NgayVaoVien", thongTinDieuTri.NgayVaoVien);
            Command.Parameters.Add("TrucTiepVao", (int)thongTinDieuTri.TrucTiepVao);
            Command.Parameters.Add("NoiGioiThieu", (int)thongTinDieuTri.NoiGioiThieu);
            Command.Parameters.Add("VaoVienDoBenhNayLanThu", thongTinDieuTri.VaoVienDoBenhNayLanThu);
            Command.Parameters.Add("IDLoaiBenhAn", thongTinDieuTri.IDLoaiBenhAn);
            Command.Parameters.Add("TenKhoaVao", thongTinDieuTri.TenKhoaVao);
            Command.Parameters.Add("NgayVaoKhoa", thongTinDieuTri.NgayVaoKhoa);
            Command.Parameters.Add("SoNgayDieuTriTaiKhoa", thongTinDieuTri.SoNgayDieuTriTaiKhoa);
            Command.Parameters.Add("ChuyenKhoa1", thongTinDieuTri.ChuyenKhoa1);
            Command.Parameters.Add("NgayChuyenKhoa1", thongTinDieuTri.NgayChuyenKhoa1);
            Command.Parameters.Add("SoNgayDieuTriKhoa1", thongTinDieuTri.SoNgayDieuTriKhoa1);
            Command.Parameters.Add("ChuyenKhoa2", thongTinDieuTri.ChuyenKhoa2);
            Command.Parameters.Add("NgayChuyenKhoa2", thongTinDieuTri.NgayChuyenKhoa2);
            Command.Parameters.Add("SoNgayDieuTriKhoa2", thongTinDieuTri.SoNgayDieuTriKhoa2);
            Command.Parameters.Add("ChuyenKhoa3", thongTinDieuTri.ChuyenKhoa3);
            Command.Parameters.Add("NgayChuyenKhoa3", thongTinDieuTri.NgayChuyenKhoa3);
            Command.Parameters.Add("SoNgayDieuTriKhoa3", thongTinDieuTri.SoNgayDieuTriKhoa3);
            Command.Parameters.Add("ChuyenVien", (int?)thongTinDieuTri.ChuyenVien);
            Command.Parameters.Add("TenVienChuyenBenhNhanDen", thongTinDieuTri.TenVienChuyenBenhNhanDen);
            Command.Parameters.Add("MaVienChuyenBenhNhanDen", thongTinDieuTri.MaVienChuyenBenhNhanDen);
            Command.Parameters.Add("NgayRaVien", thongTinDieuTri.NgayRaVien);
            Command.Parameters.Add("TinhTrangRaVien", (int?)thongTinDieuTri.TinhTrangRaVien);
            Command.Parameters.Add("TongSoNgayDieuTri1", thongTinDieuTri.TongSoNgayDieuTri1);
            Command.Parameters.Add("TongSoNgayDieuTri2", thongTinDieuTri.TongSoNgayDieuTri2);
            Command.Parameters.Add("ChanDoan_NoiChuyenDen", thongTinDieuTri.ChanDoan_NoiChuyenDen);
            Command.Parameters.Add("ChanDoan_YHCT", thongTinDieuTri.ChanDoan_YHCT);
            Command.Parameters.Add("MaICD_NoiChuyenDen", thongTinDieuTri.MaICD_NoiChuyenDen);
            Command.Parameters.Add("ChanDoan_KKB_CapCuu", thongTinDieuTri.ChanDoan_KKB_CapCuu);
            Command.Parameters.Add("MaICD_KKB_CapCuu", thongTinDieuTri.MaICD_KKB_CapCuu);
            Command.Parameters.Add("ChanDoan_KhiVaoKhoaDieuTri", thongTinDieuTri.ChanDoan_KhiVaoKhoaDieuTri);
            Command.Parameters.Add("MaICD_KhiVaoKhoaDieuTri", thongTinDieuTri.MaICD_KhiVaoKhoaDieuTri);
            Command.Parameters.Add("BenhChinh_RaVien", thongTinDieuTri.BenhChinh_RaVien);
            Command.Parameters.Add("MaICD_BenhChinh_RaVien", thongTinDieuTri.MaICD_BenhChinh_RaVien);
            Command.Parameters.Add("BenhKemTheo_RaVien", thongTinDieuTri.BenhKemTheo_RaVien);
            Command.Parameters.Add("MaICD_BenhKemTheo_RaVien", thongTinDieuTri.MaICD_BenhKemTheo_RaVien);
            Command.Parameters.Add("BenhKemTheo_RaVien1", thongTinDieuTri.BenhKemTheo_RaVien1);
            Command.Parameters.Add("MaICD_BenhKemTheo_RaVien1", thongTinDieuTri.MaICD_BenhKemTheo_RaVien1);
            Command.Parameters.Add("BenhKemTheo_RaVien2", thongTinDieuTri.BenhKemTheo_RaVien2);
            Command.Parameters.Add("MaICD_BenhKemTheo_RaVien2", thongTinDieuTri.MaICD_BenhKemTheo_RaVien2);
            Command.Parameters.Add("ThuThuat", thongTinDieuTri.ThuThuat == true ? "1" : "0");
            Command.Parameters.Add("PhauThuat", thongTinDieuTri.PhauThuat == true ? "1" : "0");
            Command.Parameters.Add("TaiBien", thongTinDieuTri.TaiBien == true ? "1" : "0");
            Command.Parameters.Add("BienChung", thongTinDieuTri.BienChung == true ? "1" : "0");
            Command.Parameters.Add("KetQuaDieuTri", (int?)thongTinDieuTri.KetQuaDieuTri);
            Command.Parameters.Add("GiaiPhauBenh", (int?)thongTinDieuTri.GiaiPhauBenh);
            Command.Parameters.Add("NgayTuVong", thongTinDieuTri.NgayTuVong);
            Command.Parameters.Add("LyDoTuVong", (int?)thongTinDieuTri.LyDoTuVong);
            Command.Parameters.Add("ThoiGianTuVong", (int?)thongTinDieuTri.ThoiGianTuVong);
            Command.Parameters.Add("NguyenNhanChinhTuVong", thongTinDieuTri.NguyenNhanChinhTuVong);
            Command.Parameters.Add("MaICD_NguyenNhanChinhTuVong", thongTinDieuTri.MaICD_NguyenNhanChinhTuVong);
            Command.Parameters.Add("KhamNghiemTuThi", thongTinDieuTri.KhamNghiemTuThi == true ? "1" : "0");
            Command.Parameters.Add("ChanDoanGiaiPhauTuThi", thongTinDieuTri.ChanDoanGiaiPhauTuThi);
            Command.Parameters.Add("MaICD_ChanDoanGiaiPhauTuThi", thongTinDieuTri.MaICD_ChanDoanGiaiPhauTuThi);
            Command.Parameters.Add("MaGiamDocBenhVien", thongTinDieuTri.MaGiamDocBenhVien);
            Command.Parameters.Add("NgayThangNamTrangBia", thongTinDieuTri.NgayThangNamTrangBia);
            Command.Parameters.Add("MaTruongKhoa", thongTinDieuTri.MaTruongKhoa);
            if (thongTinDieuTri.HoSo == null)
            {
                thongTinDieuTri.HoSo = new HoSo();
            }
            Command.Parameters.Add("XQuang", thongTinDieuTri.HoSo.XQuang);
            Command.Parameters.Add("CTScanner", thongTinDieuTri.HoSo.CTScanner);
            Command.Parameters.Add("SieuAm", thongTinDieuTri.HoSo.SieuAm);
            Command.Parameters.Add("XetNghiem", thongTinDieuTri.HoSo.XetNghiem);
            Command.Parameters.Add("Khac", thongTinDieuTri.HoSo.Khac);
            Command.Parameters.Add("Khac_Text", thongTinDieuTri.HoSo.Khac_Text);
            Command.Parameters.Add("ToanBoHoSo", thongTinDieuTri.HoSo.ToanBoHoSo);
            if (thongTinDieuTri.DauSinhTon == null)
            {
                thongTinDieuTri.DauSinhTon = new DauSinhTon();
            }
            Command.Parameters.Add("Mach", thongTinDieuTri.DauSinhTon.Mach);
            Command.Parameters.Add("NhietDo", thongTinDieuTri.DauSinhTon.NhietDo);
            Command.Parameters.Add("HuyetAp", thongTinDieuTri.DauSinhTon.HuyetAp);
            Command.Parameters.Add("NhipTho", thongTinDieuTri.DauSinhTon.NhipTho);
            Command.Parameters.Add("CanNang", thongTinDieuTri.DauSinhTon.CanNang);
            Command.Parameters.Add("ChieuCao", thongTinDieuTri.DauSinhTon.ChieuCao);
            Command.Parameters.Add("BMI", thongTinDieuTri.DauSinhTon.BMI);
            Command.Parameters.Add("ChanDoanCuaNoiGioiThieu", thongTinDieuTri.ChanDoanCuaNoiGioiThieu);
            Command.Parameters.Add("YHCT_KetQuaDieutTriID", thongTinDieuTri.YHCT_KetQuaDieutTriID);
            Command.Parameters.Add("YHCT_ChuanDoanaRaVien", thongTinDieuTri.YHCT_ChuanDoanaRaVien);
            Command.Parameters.Add("YHCT_NguyenNhan", thongTinDieuTri.YHCT_NguyenNhan);
            Command.Parameters.Add("YHCT_TangPhu", thongTinDieuTri.YHCT_TangPhu);
            Command.Parameters.Add("YHCT_BatCuong", thongTinDieuTri.YHCT_BatCuong);
            Command.Parameters.Add("YHCT_KinhMach", thongTinDieuTri.YHCT_KinhMach);
            Command.Parameters.Add("YHCT_BenhDanh", thongTinDieuTri.YHCT_BenhDanh);
            Command.Parameters.Add("YHCT_NoiDieuTri", thongTinDieuTri.YHCT_NoiDieuTri);
            Command.Parameters.Add("YHHD_NoiDieuTri", thongTinDieuTri.YHHD_NoiDieuTri);
            Command.Parameters.Add("YHHD_BenhChinh", thongTinDieuTri.YHHD_BenhChinh);
            Command.Parameters.Add("YHHD_BenhKemTheo", thongTinDieuTri.YHHD_BenhKemTheo);
            Command.Parameters.Add("ChanDoanKKBYHCT", thongTinDieuTri.ChanDoanKKBYHCT);
            Command.Parameters.Add("ChanDoanKKBYHHD", thongTinDieuTri.ChanDoanKKBYHHD);
            Command.Parameters.Add("ChanDoanNoiGioiThieu", thongTinDieuTri.ChanDoanNoiGioiThieu);
            Command.Parameters.Add("Buong", thongTinDieuTri.Buong);
            Command.Parameters.Add("SoNhapVien", thongTinDieuTri.SoNhapVien);
            Command.Parameters.Add("MaSoBenhTat", thongTinDieuTri.MaSoBenhTat);
            Command.Parameters.Add("MaTruongPhongKHTH", thongTinDieuTri.MaTruongPhongKHTH);
            Command.Parameters.Add("MaThayThuocDieuTri", thongTinDieuTri.MaThayThuocDieuTri);
            Command.Parameters.Add("MaThayThuocKhamBenh", thongTinDieuTri.MaThayThuocKhamBenh);
            Command.Parameters.Add("TongSoNgayDieuTriSauPT", thongTinDieuTri.TongSoNgayDieuTriSauPT);
            Command.Parameters.Add("TongSoLanPhauThuat", thongTinDieuTri.TongSoLanPhauThuat);
            Command.Parameters.Add("NguyenNhan_BenhChinh_RaVien", thongTinDieuTri.NguyenNhan_BenhChinh_RaVien);
            Command.Parameters.Add("MaICD_NguyenNhan_BenhChinh_RV", thongTinDieuTri.MaICD_NguyenNhan_BenhChinh_RV);
            Command.Parameters.Add("ChanDoanTruocPhauThuat", thongTinDieuTri.ChanDoanTruocPhauThuat);
            Command.Parameters.Add("ChanDoanSauPhauThuat", thongTinDieuTri.ChanDoanSauPhauThuat);
            Command.Parameters.Add("MaICD_ChanDoanTruocPhauThuat", thongTinDieuTri.MaICD_ChanDoanTruocPhauThuat);
            Command.Parameters.Add("MaICD_ChanDoanSauPhauThuat", thongTinDieuTri.MaICD_ChanDoanSauPhauThuat);
            Command.Parameters.Add("LucVaoDe", thongTinDieuTri.LucVaoDe);
            Command.Parameters.Add("NgayDe", thongTinDieuTri.NgayDe);
            Command.Parameters.Add("NgoiThai", thongTinDieuTri.NgoiThai);
            Command.Parameters.Add("CachThucDe", thongTinDieuTri.CachThucDe);
            Command.Parameters.Add("KiemSoatTuCung", thongTinDieuTri.KiemSoatTuCung == true ? "1" : "0");
            Command.Parameters.Add("KiemSoatTuCung_Text", thongTinDieuTri.KiemSoatTuCung_Text);
            Command.Parameters.Add("PhuongPhapPhauThuat", thongTinDieuTri.PhuongPhapPhauThuat);
            Command.Parameters.Add("LyDoTaiBienBienChung", thongTinDieuTri.LyDoTaiBienBienChung);
            Command.Parameters.Add("TinhHinhPhauThuat", thongTinDieuTri.TinhHinhPhauThuat == true ? "1" : "0");
            Command.Parameters.Add("TreSoSinh_LoaiThai", thongTinDieuTri.TreSoSinh_LoaiThai);
            Command.Parameters.Add("TreSoSinh_GioiTinh", thongTinDieuTri.TreSoSinh_GioiTinh);
            Command.Parameters.Add("TreSoSinh_DiTat", thongTinDieuTri.TreSoSinh_DiTat);
            Command.Parameters.Add("TreSoSinh_DiTat_Text", thongTinDieuTri.TreSoSinh_DiTat_Text);
            Command.Parameters.Add("TreSoSinh_CanNang", thongTinDieuTri.TreSoSinh_CanNang);
            Command.Parameters.Add("TreSoSinh_SongChet", thongTinDieuTri.TreSoSinh_SongChet);
            Command.Parameters.Add("YHCT_BatCuongID", thongTinDieuTri.sYHCT_BatCuongID);
            Command.Parameters.Add("YHCT_TangPhuID", thongTinDieuTri.sYHCT_TangPhuID);
            Command.Parameters.Add("YHCT_KinhMachID", thongTinDieuTri.sYHCT_KinhMachID);
            Command.Parameters.Add("YHCT_DinhViBenhID", thongTinDieuTri.sYHCT_DinhViBenhID);
            Command.Parameters.Add("YHCT_NguyenNhanID", thongTinDieuTri.sYHCT_NguyenNhanID);
            Command.Parameters.Add("MaBenhAn", thongTinDieuTri.MaBenhAn);
            Command.Parameters.Add("MaKhoa", thongTinDieuTri.MaKhoa);
            Command.Parameters.Add("Giuong", thongTinDieuTri.Giuong);
            Command.Parameters.Add("TenGiuong", thongTinDieuTri.TenGiuong);
            Command.Parameters.Add("LyDoVaoVien", thongTinDieuTri.LyDoVaoVien);
            Command.Parameters.Add("MaCSKCB", thongTinDieuTri.MaCSKCB);
            Command.Parameters.Add("TenGiamDocBenhVien", thongTinDieuTri.TenGiamDocBenhVien);
            Command.Parameters.Add("TenTruongKhoa", thongTinDieuTri.TenTruongKhoa);
            Command.Parameters.Add("MaQuanLy", thongTinDieuTri.MaQuanLy);
            try
            {
                int n = Command.ExecuteNonQuery();
                XuLyLoi.LogDebug("dangtung - Update ThongTinDieuTri return : " + n);
                if (n == 0)
                {
                    sql = @"
                INSERT INTO ThongTinDieuTri (KhoaRaVien, GiuongRaVien, SoLuuTru, SoNgoaiTru, Khoa, MaQuanLy, MaBenhNhan, NgayVaoVien, TrucTiepVao, NoiGioiThieu, VaoVienDoBenhNayLanThu, IDLoaiBenhAn, TenKhoaVao, NgayVaoKhoa, SoNgayDieuTriTaiKhoa, ChuyenKhoa1, NgayChuyenKhoa1, SoNgayDieuTriKhoa1, ChuyenKhoa2, NgayChuyenKhoa2, SoNgayDieuTriKhoa2, ChuyenKhoa3, NgayChuyenKhoa3, SoNgayDieuTriKhoa3, ChuyenVien, TenVienChuyenBenhNhanDen, MaVienChuyenBenhNhanDen, NgayRaVien, TinhTrangRaVien, TongSoNgayDieuTri1, TongSoNgayDieuTri2, ChanDoan_NoiChuyenDen, ChanDoan_YHCT, MaICD_NoiChuyenDen, ChanDoan_KKB_CapCuu, MaICD_KKB_CapCuu, ChanDoan_KhiVaoKhoaDieuTri, MaICD_KhiVaoKhoaDieuTri, BenhChinh_RaVien, MaICD_BenhChinh_RaVien, BenhKemTheo_RaVien, MaICD_BenhKemTheo_RaVien, BenhKemTheo_RaVien1, MaICD_BenhKemTheo_RaVien1, BenhKemTheo_RaVien2, MaICD_BenhKemTheo_RaVien2, ThuThuat, PhauThuat, TaiBien, BienChung, KetQuaDieuTri, GiaiPhauBenh, NgayTuVong, LyDoTuVong, ThoiGianTuVong, NguyenNhanChinhTuVong, MaICD_NguyenNhanChinhTuVong, KhamNghiemTuThi, ChanDoanGiaiPhauTuThi, MaICD_ChanDoanGiaiPhauTuThi, MaGiamDocBenhVien, NgayThangNamTrangBia, MaTruongKhoa, XQuang, CTScanner, SieuAm, XetNghiem, Khac, Khac_Text, ToanBoHoSo, Mach, NhietDo, HuyetAp, NhipTho, CanNang, ChieuCao,BMI, ChanDoanCuaNoiGioiThieu, YHCT_KetQuaDieutTriID, YHCT_ChuanDoanaRaVien, YHCT_NguyenNhan, YHCT_TangPhu, YHCT_BatCuong, YHCT_KinhMach, YHCT_BenhDanh, YHCT_NoiDieuTri, YHHD_NoiDieuTri, YHHD_BenhChinh, YHHD_BenhKemTheo, ChanDoanKKBYHCT, ChanDoanKKBYHHD, ChanDoanNoiGioiThieu, Buong, SoNhapVien, MaSoBenhTat, MaTruongPhongKHTH, MaThayThuocDieuTri, MaThayThuocKhamBenh, TongSoNgayDieuTriSauPT, TongSoLanPhauThuat, NguyenNhan_BenhChinh_RaVien, MaICD_NguyenNhan_BenhChinh_RV, ChanDoanTruocPhauThuat, ChanDoanSauPhauThuat, MaICD_ChanDoanTruocPhauThuat, MaICD_ChanDoanSauPhauThuat, LucVaoDe, NgayDe, NgoiThai, CachThucDe, KiemSoatTuCung, KiemSoatTuCung_Text, PhuongPhapPhauThuat, LyDoTaiBienBienChung, TinhHinhPhauThuat, TreSoSinh_LoaiThai, TreSoSinh_GioiTinh, TreSoSinh_DiTat, TreSoSinh_DiTat_Text, TreSoSinh_CanNang, TreSoSinh_SongChet, YHCT_BatCuongID, YHCT_TangPhuID, YHCT_KinhMachID, YHCT_DinhViBenhID, YHCT_NguyenNhanID, MaBenhAn, MaKhoa, Giuong, TenGiuong, LyDoVaoVien, MaCSKCB, TenGiamDocBenhVien, TenTruongKhoa)
                VALUES(:KhoaRaVien, :GiuongRaVien, :SoLuuTru, :SoNgoaiTru, :Khoa, :MaQuanLy, :MaBenhNhan, :NgayVaoVien, :TrucTiepVao, :NoiGioiThieu, :VaoVienDoBenhNayLanThu, :IDLoaiBenhAn, :TenKhoaVao, :NgayVaoKhoa, :SoNgayDieuTriTaiKhoa, :ChuyenKhoa1, :NgayChuyenKhoa1, :SoNgayDieuTriKhoa1, :ChuyenKhoa2, :NgayChuyenKhoa2, :SoNgayDieuTriKhoa2, :ChuyenKhoa3, :NgayChuyenKhoa3, :SoNgayDieuTriKhoa3, :ChuyenVien, :TenVienChuyenBenhNhanDen, :MaVienChuyenBenhNhanDen, :NgayRaVien, :TinhTrangRaVien, :TongSoNgayDieuTri1, :TongSoNgayDieuTri2, :ChanDoan_NoiChuyenDen, :ChanDoan_YHCT, :MaICD_NoiChuyenDen, :ChanDoan_KKB_CapCuu, :MaICD_KKB_CapCuu, :ChanDoan_KhiVaoKhoaDieuTri, :MaICD_KhiVaoKhoaDieuTri, :BenhChinh_RaVien, :MaICD_BenhChinh_RaVien, :BenhKemTheo_RaVien, :MaICD_BenhKemTheo_RaVien, :BenhKemTheo_RaVien1, :MaICD_BenhKemTheo_RaVien1, :BenhKemTheo_RaVien2, :MaICD_BenhKemTheo_RaVien2, :ThuThuat, :PhauThuat, :TaiBien, :BienChung, :KetQuaDieuTri, :GiaiPhauBenh, :NgayTuVong, :LyDoTuVong, :ThoiGianTuVong, :NguyenNhanChinhTuVong, :MaICD_NguyenNhanChinhTuVong, :KhamNghiemTuThi, :ChanDoanGiaiPhauTuThi, :MaICD_ChanDoanGiaiPhauTuThi, :MaGiamDocBenhVien, :NgayThangNamTrangBia, :MaTruongKhoa, :XQuang, :CTScanner, :SieuAm, :XetNghiem, :Khac, :Khac_Text, :ToanBoHoSo, :Mach, :NhietDo, :HuyetAp, :NhipTho, :CanNang, :ChieuCao,:BMI, :ChanDoanCuaNoiGioiThieu, :YHCT_KetQuaDieutTriID, :YHCT_ChuanDoanaRaVien, :YHCT_NguyenNhan, :YHCT_TangPhu, :YHCT_BatCuong,:YHCT_KinhMach, :YHCT_BenhDanh, :YHCT_NoiDieuTri, :YHHD_NoiDieuTri, :YHHD_BenhChinh, :YHHD_BenhKemTheo, :ChanDoanKKBYHCT, :ChanDoanKKBYHHD, :ChanDoanNoiGioiThieu, :Buong, :SoNhapVien, :MaSoBenhTat, :MaTruongPhongKHTH, :MaThayThuocDieuTri, :MaThayThuocKhamBenh, :TongSoNgayDieuTriSauPT, :TongSoLanPhauThuat, :NguyenNhan_BenhChinh_RaVien, :MaICD_NguyenNhan_BenhChinh_RV, :ChanDoanTruocPhauThuat, :ChanDoanSauPhauThuat, :MaICD_ChanDoanTruocPhauThuat, :MaICD_ChanDoanSauPhauThuat, :LucVaoDe, :NgayDe, :NgoiThai, :CachThucDe, :KiemSoatTuCung, :KiemSoatTuCung_Text, :PhuongPhapPhauThuat, :LyDoTaiBienBienChung, :TinhHinhPhauThuat, :TreSoSinh_LoaiThai, :TreSoSinh_GioiTinh, :TreSoSinh_DiTat, :TreSoSinh_DiTat_Text, :TreSoSinh_CanNang, :TreSoSinh_SongChet, :YHCT_BatCuongID, :YHCT_TangPhuID, :YHCT_KinhMachID, :YHCT_DinhViBenhID, :YHCT_NguyenNhanID, :MaBenhAn, :MaKhoa, :Giuong, :TenGiuong, :LyDoVaoVien, :MaCSKCB, :TenGiamDocBenhVien, :TenTruongKhoa)
            ";
                    Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add("KhoaRaVien", thongTinDieuTri.KhoaRaVien);
                    Command.Parameters.Add("GiuongRaVien", thongTinDieuTri.GiuongRaVien);
                    Command.Parameters.Add("SoLuuTru", thongTinDieuTri.SoLuuTru);
                    Command.Parameters.Add("SoNgoaiTru", thongTinDieuTri.SoNgoaiTru);
                    Command.Parameters.Add("Khoa", thongTinDieuTri.Khoa);
                    Command.Parameters.Add("MaQuanLy", thongTinDieuTri.MaQuanLy);
                    Command.Parameters.Add("MaBenhNhan", thongTinDieuTri.MaBenhNhan);
                    Command.Parameters.Add("NgayVaoVien", thongTinDieuTri.NgayVaoVien);
                    Command.Parameters.Add("TrucTiepVao", (int)thongTinDieuTri.TrucTiepVao);
                    Command.Parameters.Add("NoiGioiThieu", (int)thongTinDieuTri.NoiGioiThieu);
                    Command.Parameters.Add("VaoVienDoBenhNayLanThu", thongTinDieuTri.VaoVienDoBenhNayLanThu);
                    Command.Parameters.Add("IDLoaiBenhAn", thongTinDieuTri.IDLoaiBenhAn);
                    Command.Parameters.Add("TenKhoaVao", thongTinDieuTri.TenKhoaVao);
                    Command.Parameters.Add("NgayVaoKhoa", thongTinDieuTri.NgayVaoKhoa);
                    Command.Parameters.Add("SoNgayDieuTriTaiKhoa", thongTinDieuTri.SoNgayDieuTriTaiKhoa);
                    Command.Parameters.Add("ChuyenKhoa1", thongTinDieuTri.ChuyenKhoa1);
                    Command.Parameters.Add("NgayChuyenKhoa1", thongTinDieuTri.NgayChuyenKhoa1);
                    Command.Parameters.Add("SoNgayDieuTriKhoa1", thongTinDieuTri.SoNgayDieuTriKhoa1);
                    Command.Parameters.Add("ChuyenKhoa2", thongTinDieuTri.ChuyenKhoa2);
                    Command.Parameters.Add("NgayChuyenKhoa2", thongTinDieuTri.NgayChuyenKhoa2);
                    Command.Parameters.Add("SoNgayDieuTriKhoa2", thongTinDieuTri.SoNgayDieuTriKhoa2);
                    Command.Parameters.Add("ChuyenKhoa3", thongTinDieuTri.ChuyenKhoa3);
                    Command.Parameters.Add("NgayChuyenKhoa3", thongTinDieuTri.NgayChuyenKhoa3);
                    Command.Parameters.Add("SoNgayDieuTriKhoa3", thongTinDieuTri.SoNgayDieuTriKhoa3);
                    Command.Parameters.Add("ChuyenVien", (int?)thongTinDieuTri.ChuyenVien);
                    Command.Parameters.Add("TenVienChuyenBenhNhanDen", thongTinDieuTri.TenVienChuyenBenhNhanDen);
                    Command.Parameters.Add("MaVienChuyenBenhNhanDen", thongTinDieuTri.MaVienChuyenBenhNhanDen);
                    Command.Parameters.Add("NgayRaVien", thongTinDieuTri.NgayRaVien);
                    Command.Parameters.Add("TinhTrangRaVien", (int?)thongTinDieuTri.TinhTrangRaVien);
                    Command.Parameters.Add("TongSoNgayDieuTri1", thongTinDieuTri.TongSoNgayDieuTri1);
                    Command.Parameters.Add("TongSoNgayDieuTri2", thongTinDieuTri.TongSoNgayDieuTri2);
                    Command.Parameters.Add("ChanDoan_NoiChuyenDen", thongTinDieuTri.ChanDoan_NoiChuyenDen);
                    Command.Parameters.Add("ChanDoan_YHCT", thongTinDieuTri.ChanDoan_YHCT);
                    Command.Parameters.Add("MaICD_NoiChuyenDen", thongTinDieuTri.MaICD_NoiChuyenDen);
                    Command.Parameters.Add("ChanDoan_KKB_CapCuu", thongTinDieuTri.ChanDoan_KKB_CapCuu);
                    Command.Parameters.Add("MaICD_KKB_CapCuu", thongTinDieuTri.MaICD_KKB_CapCuu);
                    Command.Parameters.Add("ChanDoan_KhiVaoKhoaDieuTri", thongTinDieuTri.ChanDoan_KhiVaoKhoaDieuTri);
                    Command.Parameters.Add("MaICD_KhiVaoKhoaDieuTri", thongTinDieuTri.MaICD_KhiVaoKhoaDieuTri);
                    Command.Parameters.Add("BenhChinh_RaVien", thongTinDieuTri.BenhChinh_RaVien);
                    Command.Parameters.Add("MaICD_BenhChinh_RaVien", thongTinDieuTri.MaICD_BenhChinh_RaVien);
                    Command.Parameters.Add("BenhKemTheo_RaVien", thongTinDieuTri.BenhKemTheo_RaVien);
                    Command.Parameters.Add("MaICD_BenhKemTheo_RaVien", thongTinDieuTri.MaICD_BenhKemTheo_RaVien);
                    Command.Parameters.Add("BenhKemTheo_RaVien1", thongTinDieuTri.BenhKemTheo_RaVien1);
                    Command.Parameters.Add("MaICD_BenhKemTheo_RaVien1", thongTinDieuTri.MaICD_BenhKemTheo_RaVien1);
                    Command.Parameters.Add("BenhKemTheo_RaVien2", thongTinDieuTri.BenhKemTheo_RaVien2);
                    Command.Parameters.Add("MaICD_BenhKemTheo_RaVien2", thongTinDieuTri.MaICD_BenhKemTheo_RaVien2);
                    Command.Parameters.Add("ThuThuat", thongTinDieuTri.ThuThuat == true ? "1" : "0");
                    Command.Parameters.Add("PhauThuat", thongTinDieuTri.PhauThuat == true ? "1" : "0");
                    Command.Parameters.Add("TaiBien", thongTinDieuTri.TaiBien == true ? "1" : "0");
                    Command.Parameters.Add("BienChung", thongTinDieuTri.BienChung == true ? "1" : "0");
                    Command.Parameters.Add("KetQuaDieuTri", (int?)thongTinDieuTri.KetQuaDieuTri);
                    Command.Parameters.Add("GiaiPhauBenh", (int?)thongTinDieuTri.GiaiPhauBenh);
                    Command.Parameters.Add("NgayTuVong", thongTinDieuTri.NgayTuVong);
                    Command.Parameters.Add("LyDoTuVong", (int?)thongTinDieuTri.LyDoTuVong);
                    Command.Parameters.Add("ThoiGianTuVong", (int?)thongTinDieuTri.ThoiGianTuVong);
                    Command.Parameters.Add("NguyenNhanChinhTuVong", thongTinDieuTri.NguyenNhanChinhTuVong);
                    Command.Parameters.Add("MaICD_NguyenNhanChinhTuVong", thongTinDieuTri.MaICD_NguyenNhanChinhTuVong);
                    Command.Parameters.Add("KhamNghiemTuThi", thongTinDieuTri.KhamNghiemTuThi == true ? "1" : "0");
                    Command.Parameters.Add("ChanDoanGiaiPhauTuThi", thongTinDieuTri.ChanDoanGiaiPhauTuThi);
                    Command.Parameters.Add("MaICD_ChanDoanGiaiPhauTuThi", thongTinDieuTri.MaICD_ChanDoanGiaiPhauTuThi);
                    Command.Parameters.Add("MaGiamDocBenhVien", thongTinDieuTri.MaGiamDocBenhVien);
                    Command.Parameters.Add("NgayThangNamTrangBia", thongTinDieuTri.NgayThangNamTrangBia);
                    Command.Parameters.Add("MaTruongKhoa", thongTinDieuTri.MaTruongKhoa);
                    Command.Parameters.Add("XQuang", thongTinDieuTri.HoSo.XQuang);
                    Command.Parameters.Add("CTScanner", thongTinDieuTri.HoSo.CTScanner);
                    Command.Parameters.Add("SieuAm", thongTinDieuTri.HoSo.SieuAm);
                    Command.Parameters.Add("XetNghiem", thongTinDieuTri.HoSo.XetNghiem);
                    Command.Parameters.Add("Khac", thongTinDieuTri.HoSo.Khac);
                    Command.Parameters.Add("Khac_Text", thongTinDieuTri.HoSo.Khac_Text);
                    Command.Parameters.Add("ToanBoHoSo", thongTinDieuTri.HoSo.ToanBoHoSo);
                    Command.Parameters.Add("Mach", thongTinDieuTri.DauSinhTon.Mach);
                    Command.Parameters.Add("NhietDo", thongTinDieuTri.DauSinhTon.NhietDo);
                    Command.Parameters.Add("HuyetAp", thongTinDieuTri.DauSinhTon.HuyetAp);
                    Command.Parameters.Add("NhipTho", thongTinDieuTri.DauSinhTon.NhipTho);
                    Command.Parameters.Add("CanNang", thongTinDieuTri.DauSinhTon.CanNang);
                    Command.Parameters.Add("ChieuCao", thongTinDieuTri.DauSinhTon.ChieuCao);
                    Command.Parameters.Add("BMI", thongTinDieuTri.DauSinhTon.BMI);
                    Command.Parameters.Add("ChanDoanCuaNoiGioiThieu", thongTinDieuTri.ChanDoanCuaNoiGioiThieu);
                    Command.Parameters.Add("YHCT_KetQuaDieutTriID", thongTinDieuTri.YHCT_KetQuaDieutTriID);
                    Command.Parameters.Add("YHCT_ChuanDoanaRaVien", thongTinDieuTri.YHCT_ChuanDoanaRaVien);
                    Command.Parameters.Add("YHCT_NguyenNhan", thongTinDieuTri.YHCT_NguyenNhan);
                    Command.Parameters.Add("YHCT_TangPhu", thongTinDieuTri.YHCT_TangPhu);
                    Command.Parameters.Add("YHCT_BatCuong", thongTinDieuTri.YHCT_BatCuong);
                    Command.Parameters.Add("YHCT_KinhMach", thongTinDieuTri.YHCT_KinhMach);
                    Command.Parameters.Add("YHCT_BenhDanh", thongTinDieuTri.YHCT_BenhDanh);
                    Command.Parameters.Add("YHCT_NoiDieuTri", thongTinDieuTri.YHCT_NoiDieuTri);
                    Command.Parameters.Add("YHHD_NoiDieuTri", thongTinDieuTri.YHHD_NoiDieuTri);
                    Command.Parameters.Add("YHHD_BenhChinh", thongTinDieuTri.YHHD_BenhChinh);
                    Command.Parameters.Add("YHHD_BenhKemTheo", thongTinDieuTri.YHHD_BenhKemTheo);
                    Command.Parameters.Add("ChanDoanKKBYHCT", thongTinDieuTri.ChanDoanKKBYHCT);
                    Command.Parameters.Add("ChanDoanKKBYHHD", thongTinDieuTri.ChanDoanKKBYHHD);
                    Command.Parameters.Add("ChanDoanNoiGioiThieu", thongTinDieuTri.ChanDoanNoiGioiThieu);
                    Command.Parameters.Add("Buong", thongTinDieuTri.Buong);
                    Command.Parameters.Add("SoNhapVien", thongTinDieuTri.SoNhapVien);
                    Command.Parameters.Add("MaSoBenhTat", thongTinDieuTri.MaSoBenhTat);
                    Command.Parameters.Add("MaTruongPhongKHTH", thongTinDieuTri.MaTruongPhongKHTH);
                    Command.Parameters.Add("MaThayThuocDieuTri", thongTinDieuTri.MaThayThuocDieuTri);
                    Command.Parameters.Add("MaThayThuocKhamBenh", thongTinDieuTri.MaThayThuocKhamBenh);
                    Command.Parameters.Add("TongSoNgayDieuTriSauPT", thongTinDieuTri.TongSoNgayDieuTriSauPT);
                    Command.Parameters.Add("TongSoLanPhauThuat", thongTinDieuTri.TongSoLanPhauThuat);
                    Command.Parameters.Add("NguyenNhan_BenhChinh_RaVien", thongTinDieuTri.NguyenNhan_BenhChinh_RaVien);
                    Command.Parameters.Add("MaICD_NguyenNhan_BenhChinh_RV", thongTinDieuTri.MaICD_NguyenNhan_BenhChinh_RV);
                    Command.Parameters.Add("ChanDoanTruocPhauThuat", thongTinDieuTri.ChanDoanTruocPhauThuat);
                    Command.Parameters.Add("ChanDoanSauPhauThuat", thongTinDieuTri.ChanDoanSauPhauThuat);
                    Command.Parameters.Add("MaICD_ChanDoanTruocPhauThuat", thongTinDieuTri.MaICD_ChanDoanTruocPhauThuat);
                    Command.Parameters.Add("MaICD_ChanDoanSauPhauThuat", thongTinDieuTri.MaICD_ChanDoanSauPhauThuat);
                    Command.Parameters.Add("LucVaoDe", thongTinDieuTri.LucVaoDe);
                    Command.Parameters.Add("NgayDe", thongTinDieuTri.NgayDe);
                    Command.Parameters.Add("NgoiThai", thongTinDieuTri.NgoiThai);
                    Command.Parameters.Add("CachThucDe", thongTinDieuTri.CachThucDe);
                    Command.Parameters.Add("KiemSoatTuCung", thongTinDieuTri.KiemSoatTuCung == true ? "1" : "0");
                    Command.Parameters.Add("KiemSoatTuCung_Text", thongTinDieuTri.KiemSoatTuCung_Text);
                    Command.Parameters.Add("PhuongPhapPhauThuat", thongTinDieuTri.PhuongPhapPhauThuat);
                    Command.Parameters.Add("LyDoTaiBienBienChung", thongTinDieuTri.LyDoTaiBienBienChung);
                    Command.Parameters.Add("TinhHinhPhauThuat", thongTinDieuTri.TinhHinhPhauThuat == true ? "1" : "0");
                    Command.Parameters.Add("TreSoSinh_LoaiThai", thongTinDieuTri.TreSoSinh_LoaiThai);
                    Command.Parameters.Add("TreSoSinh_GioiTinh", thongTinDieuTri.TreSoSinh_GioiTinh);
                    Command.Parameters.Add("TreSoSinh_DiTat", thongTinDieuTri.TreSoSinh_DiTat);
                    Command.Parameters.Add("TreSoSinh_DiTat_Text", thongTinDieuTri.TreSoSinh_DiTat_Text);
                    Command.Parameters.Add("TreSoSinh_CanNang", thongTinDieuTri.TreSoSinh_CanNang);
                    Command.Parameters.Add("TreSoSinh_SongChet", thongTinDieuTri.TreSoSinh_SongChet);
                    Command.Parameters.Add("YHCT_BatCuongID", thongTinDieuTri.sYHCT_BatCuongID);
                    Command.Parameters.Add("YHCT_TangPhuID", thongTinDieuTri.sYHCT_TangPhuID);
                    Command.Parameters.Add("YHCT_KinhMachID", thongTinDieuTri.sYHCT_KinhMachID);
                    Command.Parameters.Add("YHCT_DinhViBenhID", thongTinDieuTri.sYHCT_DinhViBenhID);
                    Command.Parameters.Add("YHCT_NguyenNhanID", thongTinDieuTri.sYHCT_NguyenNhanID);
                    Command.Parameters.Add("MaBenhAn", thongTinDieuTri.MaBenhAn);
                    Command.Parameters.Add("MaKhoa", thongTinDieuTri.MaKhoa);
                    Command.Parameters.Add("Giuong", thongTinDieuTri.Giuong);
                    Command.Parameters.Add("TenGiuong", thongTinDieuTri.TenGiuong);
                    Command.Parameters.Add("LyDoVaoVien", thongTinDieuTri.LyDoVaoVien);
                    Command.Parameters.Add("MaCSKCB", thongTinDieuTri.MaCSKCB);
                    Command.Parameters.Add("TenGiamDocBenhVien", thongTinDieuTri.TenGiamDocBenhVien);
                    Command.Parameters.Add("TenTruongKhoa", thongTinDieuTri.TenTruongKhoa);
                    n = Command.ExecuteNonQuery(); // C#
                    XuLyLoi.LogDebug("dangtung - Insert ThongTinDieuTri return : " + n);
                    XuLyLoi.LogDebug("dangtung - End InsertOrUpdateThongTinDieuTri");
                    return n > 0 ? true : false;
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
                MDB.ExceptionExtend.LogError(ex);
                XuLyLoi.LogError("dangtung -" + ex.Message);
                XuLyLoi.LogError("dangtung -" + ex.StackTrace);
                return false;
            }
            return true;
        }
        public static bool UpdateThongTinDieuTri(MDB.MDBConnection MyConnection, ThongTinDieuTri ThongTinDieuTri)
        {
            string sql = @"UPDATE ThongTinDieuTri SET 
                        KhoaRaVien = :KhoaRaVien,
                        GiuongRaVien = :GiuongRaVien,
                        SoLuuTru = :SoLuuTru,
                        SoNgoaiTru= :SoNgoaiTru,
                        Khoa= :Khoa,
                        MaBenhNhan = :MaBenhNhan,
                        NgayVaoVien = :NgayVaoVien,
                        TrucTiepVao = :TrucTiepVao,
                        NoiGioiThieu = :NoiGioiThieu,
                        VaoVienDoBenhNayLanThu = :VaoVienDoBenhNayLanThu,
                        IDLoaiBenhAn = :IDLoaiBenhAn,
                        TenKhoaVao = :TenKhoaVao,
                        NgayVaoKhoa = :NgayVaoKhoa,
                        SoNgayDieuTriTaiKhoa = :SoNgayDieuTriTaiKhoa,
                        ChuyenKhoa1 = :ChuyenKhoa1,
                        NgayChuyenKhoa1 = :NgayChuyenKhoa1,
                        SoNgayDieuTriKhoa1 = :SoNgayDieuTriKhoa1,
                        ChuyenKhoa2 = :ChuyenKhoa2,
                        NgayChuyenKhoa2 = :NgayChuyenKhoa2,
                        SoNgayDieuTriKhoa2 = :SoNgayDieuTriKhoa2,
                        ChuyenKhoa3 = :ChuyenKhoa3,
                        NgayChuyenKhoa3 = :NgayChuyenKhoa3,
                        SoNgayDieuTriKhoa3 = :SoNgayDieuTriKhoa3,
                        ChuyenVien = :ChuyenVien,
                        TenVienChuyenBenhNhanDen = :TenVienChuyenBenhNhanDen,
                        MaVienChuyenBenhNhanDen = :MaVienChuyenBenhNhanDen,
                        NgayRaVien = :NgayRaVien,
                        TinhTrangRaVien = :TinhTrangRaVien,
                        TongSoNgayDieuTri1 = :TongSoNgayDieuTri1,
                        TongSoNgayDieuTri2 = :TongSoNgayDieuTri2,
                        ChanDoan_NoiChuyenDen = :ChanDoan_NoiChuyenDen,
                        ChanDoan_YHCT = :ChanDoan_YHCT,
                        MaICD_NoiChuyenDen = :MaICD_NoiChuyenDen,
                        ChanDoan_KKB_CapCuu = :ChanDoan_KKB_CapCuu,
                        MaICD_KKB_CapCuu = :MaICD_KKB_CapCuu,
                        ChanDoan_KhiVaoKhoaDieuTri = :ChanDoan_KhiVaoKhoaDieuTri,
                        MaICD_KhiVaoKhoaDieuTri = :MaICD_KhiVaoKhoaDieuTri,
                        BenhChinh_RaVien = :BenhChinh_RaVien,
                        MaICD_BenhChinh_RaVien = :MaICD_BenhChinh_RaVien,
                        BenhKemTheo_RaVien = :BenhKemTheo_RaVien,
                        MaICD_BenhKemTheo_RaVien = :MaICD_BenhKemTheo_RaVien,
                        MaICD_BenhKemTheo_RaVien1 = :MaICD_BenhKemTheo_RaVien1,
                        MaICD_BenhKemTheo_RaVien2 = :MaICD_BenhKemTheo_RaVien2,
                        ThuThuat = :ThuThuat,
                        PhauThuat = :PhauThuat,
                        TaiBien = :TaiBien,
                        BienChung = :BienChung,
                        KetQuaDieuTri = :KetQuaDieuTri,
                        GiaiPhauBenh = :GiaiPhauBenh,
                        NgayTuVong = :NgayTuVong,
                        LyDoTuVong = :LyDoTuVong,
                        ThoiGianTuVong = :ThoiGianTuVong,
                        NguyenNhanChinhTuVong = :NguyenNhanChinhTuVong,
                        MaICD_NguyenNhanChinhTuVong = :MaICD_NguyenNhanChinhTuVong,
                        KhamNghiemTuThi = :KhamNghiemTuThi,
                        ChanDoanGiaiPhauTuThi = :ChanDoanGiaiPhauTuThi,
                        MaICD_ChanDoanGiaiPhauTuThi = :MaICD_ChanDoanGiaiPhauTuThi,
                        MaGiamDocBenhVien = :MaGiamDocBenhVien,
                        NgayThangNamTrangBia = :NgayThangNamTrangBia,
                        MaTruongKhoa = :MaTruongKhoa,
                        XQuang = :XQuang,
                        CTScanner = :CTScanner,
                        SieuAm = :SieuAm,
                        XetNghiem = :XetNghiem,
                        Khac = :Khac,
                        Khac_Text = :Khac_Text,
                        ToanBoHoSo = :ToanBoHoSo,
                        Mach = :Mach,
                        NhietDo = :NhietDo,
                        HuyetAp = :HuyetAp,
                        NhipTho = :NhipTho,
                        CanNang = :CanNang,
                        ChieuCao= :ChieuCao,
                        BMI = :BMI,
                        ChanDoanCuaNoiGioiThieu = :ChanDoanCuaNoiGioiThieu,
YHCT_KetQuaDieutTriID = :YHCT_KetQuaDieutTriID,
YHCT_ChuanDoanaRaVien = :YHCT_ChuanDoanaRaVien,
YHCT_NguyenNhan = :YHCT_NguyenNhan,
YHCT_TangPhu = :YHCT_TangPhu,
YHCT_BatCuong = :YHCT_BatCuong,
YHCT_KinhMach = :YHCT_KinhMach,
YHCT_BenhDanh = :YHCT_BenhDanh,
YHCT_NoiDieuTri = :YHCT_NoiDieuTri,
YHHD_NoiDieuTri = :YHHD_NoiDieuTri,
YHHD_BenhChinh = :YHHD_BenhChinh,
YHHD_BenhKemTheo = :YHHD_BenhKemTheo,
ChanDoanKKBYHCT = :ChanDoanKKBYHCT,
ChanDoanKKBYHHD = :ChanDoanKKBYHHD,
ChanDoanNoiGioiThieu = :ChanDoanNoiGioiThieu,
Buong = :Buong,
SoNhapVien = :SoNhapVien,
MaSoBenhTat = :MaSoBenhTat,
MaTruongPhongKHTH = :MaTruongPhongKHTH,
MaThayThuocDieuTri = :MaThayThuocDieuTri,
MaThayThuocKhamBenh = :MaThayThuocKhamBenh,
TongSoNgayDieuTriSauPT = :TongSoNgayDieuTriSauPT,
TongSoLanPhauThuat = :TongSoLanPhauThuat,
NguyenNhan_BenhChinh_RaVien = :NguyenNhan_BenhChinh_RaVien,
MaICD_NguyenNhan_BenhChinh_RV = :MaICD_NguyenNhan_BenhChinh_RV,
ChanDoanTruocPhauThuat = :ChanDoanTruocPhauThuat,
ChanDoanSauPhauThuat = :ChanDoanSauPhauThuat,
MaICD_ChanDoanTruocPhauThuat = :MaICD_ChanDoanTruocPhauThuat,
MaICD_ChanDoanSauPhauThuat = :MaICD_ChanDoanSauPhauThuat,
LucVaoDe = :LucVaoDe,
NgayDe = :NgayDe,
NgoiThai = :NgoiThai,
CachThucDe = :CachThucDe,
KiemSoatTuCung = :KiemSoatTuCung,
KiemSoatTuCung_Text = :KiemSoatTuCung_Text,
PhuongPhapPhauThuat = :PhuongPhapPhauThuat,
LyDoTaiBienBienChung = :LyDoTaiBienBienChung,
TinhHinhPhauThuat = :TinhHinhPhauThuat,
TreSoSinh_LoaiThai = :TreSoSinh_LoaiThai,
TreSoSinh_GioiTinh = :TreSoSinh_GioiTinh,
TreSoSinh_DiTat = :TreSoSinh_DiTat,
TreSoSinh_DiTat_Text = :TreSoSinh_DiTat_Text,
TreSoSinh_CanNang = :TreSoSinh_CanNang,
TreSoSinh_SongChet = :TreSoSinh_SongChet,
YHCT_BatCuongID = :YHCT_BatCuongID,
YHCT_TangPhuID = :YHCT_TangPhuID,
YHCT_KinhMachID = :YHCT_KinhMachID,
YHCT_DinhViBenhID = :YHCT_DinhViBenhID,
YHCT_NguyenNhanID = :YHCT_NguyenNhanID,
MaBenhAn = :MaBenhAn,
MaKhoa = :MaKhoa,
Giuong = :Giuong,
TenGiuong = :TenGiuong
                        WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add("KhoaRaVien", ThongTinDieuTri.KhoaRaVien);
            Command.Parameters.Add("GiuongRaVien", ThongTinDieuTri.GiuongRaVien);
            Command.Parameters.Add("SoLuuTru", ThongTinDieuTri.SoLuuTru);
            Command.Parameters.Add("SoNgoaiTru", ThongTinDieuTri.SoNgoaiTru);
            Command.Parameters.Add("Khoa", ThongTinDieuTri.Khoa);
            Command.Parameters.Add("MaBenhNhan", ThongTinDieuTri.MaBenhNhan);
            Command.Parameters.Add("NgayVaoVien", ThongTinDieuTri.NgayVaoVien);
            Command.Parameters.Add("TrucTiepVao", (int)ThongTinDieuTri.TrucTiepVao);
            Command.Parameters.Add("NoiGioiThieu", (int)ThongTinDieuTri.NoiGioiThieu);
            Command.Parameters.Add("VaoVienDoBenhNayLanThu", ThongTinDieuTri.VaoVienDoBenhNayLanThu);
            Command.Parameters.Add("IDLoaiBenhAn", ThongTinDieuTri.IDLoaiBenhAn);
            Command.Parameters.Add("TenKhoaVao", ThongTinDieuTri.TenKhoaVao);
            Command.Parameters.Add("NgayVaoKhoa", ThongTinDieuTri.NgayVaoKhoa);
            Command.Parameters.Add("SoNgayDieuTriTaiKhoa", ThongTinDieuTri.SoNgayDieuTriTaiKhoa);
            Command.Parameters.Add("ChuyenKhoa1", ThongTinDieuTri.ChuyenKhoa1);
            Command.Parameters.Add("NgayChuyenKhoa1", ThongTinDieuTri.NgayChuyenKhoa1);
            Command.Parameters.Add("SoNgayDieuTriKhoa1", ThongTinDieuTri.SoNgayDieuTriKhoa1);
            Command.Parameters.Add("ChuyenKhoa2", ThongTinDieuTri.ChuyenKhoa2);
            Command.Parameters.Add("NgayChuyenKhoa2", ThongTinDieuTri.NgayChuyenKhoa2);
            Command.Parameters.Add("SoNgayDieuTriKhoa2", ThongTinDieuTri.SoNgayDieuTriKhoa2);
            Command.Parameters.Add("ChuyenKhoa3", ThongTinDieuTri.ChuyenKhoa3);
            Command.Parameters.Add("NgayChuyenKhoa3", ThongTinDieuTri.NgayChuyenKhoa3);
            Command.Parameters.Add("SoNgayDieuTriKhoa3", ThongTinDieuTri.SoNgayDieuTriKhoa3);
            Command.Parameters.Add("ChuyenVien", (int?)ThongTinDieuTri.ChuyenVien);
            Command.Parameters.Add("TenVienChuyenBenhNhanDen", ThongTinDieuTri.TenVienChuyenBenhNhanDen);
            Command.Parameters.Add("MaVienChuyenBenhNhanDen", ThongTinDieuTri.MaVienChuyenBenhNhanDen);
            Command.Parameters.Add("NgayRaVien", ThongTinDieuTri.NgayRaVien);
            Command.Parameters.Add("TinhTrangRaVien", (int?)ThongTinDieuTri.TinhTrangRaVien);
            Command.Parameters.Add("TongSoNgayDieuTri1", ThongTinDieuTri.TongSoNgayDieuTri1);
            Command.Parameters.Add("TongSoNgayDieuTri2", ThongTinDieuTri.TongSoNgayDieuTri2);
            Command.Parameters.Add("ChanDoan_NoiChuyenDen", ThongTinDieuTri.ChanDoan_NoiChuyenDen);
            Command.Parameters.Add("ChanDoan_YHCT", ThongTinDieuTri.ChanDoan_YHCT);
            Command.Parameters.Add("MaICD_NoiChuyenDen", ThongTinDieuTri.MaICD_NoiChuyenDen);
            Command.Parameters.Add("ChanDoan_KKB_CapCuu", ThongTinDieuTri.ChanDoan_KKB_CapCuu);
            Command.Parameters.Add("MaICD_KKB_CapCuu", ThongTinDieuTri.MaICD_KKB_CapCuu);
            Command.Parameters.Add("ChanDoan_KhiVaoKhoaDieuTri", ThongTinDieuTri.ChanDoan_KhiVaoKhoaDieuTri);
            Command.Parameters.Add("MaICD_KhiVaoKhoaDieuTri", ThongTinDieuTri.MaICD_KhiVaoKhoaDieuTri);
            Command.Parameters.Add("BenhChinh_RaVien", ThongTinDieuTri.BenhChinh_RaVien);
            Command.Parameters.Add("MaICD_BenhChinh_RaVien", ThongTinDieuTri.MaICD_BenhChinh_RaVien);
            Command.Parameters.Add("BenhKemTheo_RaVien", ThongTinDieuTri.BenhKemTheo_RaVien);
            Command.Parameters.Add("MaICD_BenhKemTheo_RaVien", ThongTinDieuTri.MaICD_BenhKemTheo_RaVien);
            Command.Parameters.Add("BenhKemTheo_RaVien1", ThongTinDieuTri.BenhKemTheo_RaVien1);
            Command.Parameters.Add("MaICD_BenhKemTheo_RaVien1", ThongTinDieuTri.MaICD_BenhKemTheo_RaVien1);
            Command.Parameters.Add("BenhKemTheo_RaVien2", ThongTinDieuTri.BenhKemTheo_RaVien2);
            Command.Parameters.Add("MaICD_BenhKemTheo_RaVien2", ThongTinDieuTri.MaICD_BenhKemTheo_RaVien2);
            Command.Parameters.Add("ThuThuat", ThongTinDieuTri.ThuThuat == true ? "1" : "0");
            Command.Parameters.Add("PhauThuat", ThongTinDieuTri.PhauThuat == true ? "1" : "0");
            Command.Parameters.Add("TaiBien", ThongTinDieuTri.TaiBien == true ? "1" : "0");
            Command.Parameters.Add("BienChung", ThongTinDieuTri.BienChung == true ? "1" : "0");
            Command.Parameters.Add("KetQuaDieuTri", (int?)ThongTinDieuTri.KetQuaDieuTri);
            Command.Parameters.Add("GiaiPhauBenh", (int?)ThongTinDieuTri.GiaiPhauBenh);
            Command.Parameters.Add("NgayTuVong", ThongTinDieuTri.NgayTuVong);
            Command.Parameters.Add("LyDoTuVong", (int?)ThongTinDieuTri.LyDoTuVong);
            Command.Parameters.Add("ThoiGianTuVong", (int?)ThongTinDieuTri.ThoiGianTuVong);
            Command.Parameters.Add("NguyenNhanChinhTuVong", ThongTinDieuTri.NguyenNhanChinhTuVong);
            Command.Parameters.Add("MaICD_NguyenNhanChinhTuVong", ThongTinDieuTri.MaICD_NguyenNhanChinhTuVong);
            Command.Parameters.Add("KhamNghiemTuThi", ThongTinDieuTri.KhamNghiemTuThi == true ? "1" : "0");
            Command.Parameters.Add("ChanDoanGiaiPhauTuThi", ThongTinDieuTri.ChanDoanGiaiPhauTuThi);
            Command.Parameters.Add("MaICD_ChanDoanGiaiPhauTuThi", ThongTinDieuTri.MaICD_ChanDoanGiaiPhauTuThi);
            Command.Parameters.Add("MaGiamDocBenhVien", ThongTinDieuTri.MaGiamDocBenhVien);
            Command.Parameters.Add("NgayThangNamTrangBia", ThongTinDieuTri.NgayThangNamTrangBia);
            Command.Parameters.Add("MaTruongKhoa", ThongTinDieuTri.MaTruongKhoa);
            if (ThongTinDieuTri.HoSo == null)
            {
                ThongTinDieuTri.HoSo = new HoSo();
            }
            Command.Parameters.Add("XQuang", ThongTinDieuTri.HoSo.XQuang);
            Command.Parameters.Add("CTScanner", ThongTinDieuTri.HoSo.CTScanner);
            Command.Parameters.Add("SieuAm", ThongTinDieuTri.HoSo.SieuAm);
            Command.Parameters.Add("XetNghiem", ThongTinDieuTri.HoSo.XetNghiem);
            Command.Parameters.Add("Khac", ThongTinDieuTri.HoSo.Khac);
            Command.Parameters.Add("Khac_Text", ThongTinDieuTri.HoSo.Khac_Text);
            Command.Parameters.Add("ToanBoHoSo", ThongTinDieuTri.HoSo.ToanBoHoSo);
            if (ThongTinDieuTri.DauSinhTon == null)
            {
                ThongTinDieuTri.DauSinhTon = new DauSinhTon();
            }
            Command.Parameters.Add("Mach", ThongTinDieuTri.DauSinhTon.Mach);
            Command.Parameters.Add("NhietDo", ThongTinDieuTri.DauSinhTon.NhietDo);
            Command.Parameters.Add("HuyetAp", ThongTinDieuTri.DauSinhTon.HuyetAp);
            Command.Parameters.Add("NhipTho", ThongTinDieuTri.DauSinhTon.NhipTho);
            Command.Parameters.Add("CanNang", ThongTinDieuTri.DauSinhTon.CanNang);
            Command.Parameters.Add("ChieuCao", ThongTinDieuTri.DauSinhTon.ChieuCao);
            Command.Parameters.Add("BMI", ThongTinDieuTri.DauSinhTon.BMI);
            Command.Parameters.Add("ChanDoanCuaNoiGioiThieu", ThongTinDieuTri.ChanDoanCuaNoiGioiThieu);
            Command.Parameters.Add("YHCT_KetQuaDieutTriID", ThongTinDieuTri.YHCT_KetQuaDieutTriID);
            Command.Parameters.Add("YHCT_ChuanDoanaRaVien", ThongTinDieuTri.YHCT_ChuanDoanaRaVien);
            Command.Parameters.Add("YHCT_NguyenNhan", ThongTinDieuTri.YHCT_NguyenNhan);
            Command.Parameters.Add("YHCT_TangPhu", ThongTinDieuTri.YHCT_TangPhu);
            Command.Parameters.Add("YHCT_BatCuong", ThongTinDieuTri.YHCT_BatCuong);
            Command.Parameters.Add("YHCT_KinhMach", ThongTinDieuTri.YHCT_KinhMach);
            Command.Parameters.Add("YHCT_BenhDanh", ThongTinDieuTri.YHCT_BenhDanh);
            Command.Parameters.Add("YHCT_NoiDieuTri", ThongTinDieuTri.YHCT_NoiDieuTri);
            Command.Parameters.Add("YHHD_NoiDieuTri", ThongTinDieuTri.YHHD_NoiDieuTri);
            Command.Parameters.Add("YHHD_BenhChinh", ThongTinDieuTri.YHHD_BenhChinh);
            Command.Parameters.Add("YHHD_BenhKemTheo", ThongTinDieuTri.YHHD_BenhKemTheo);
            Command.Parameters.Add("ChanDoanKKBYHCT", ThongTinDieuTri.ChanDoanKKBYHCT);
            Command.Parameters.Add("ChanDoanKKBYHHD", ThongTinDieuTri.ChanDoanKKBYHHD);
            Command.Parameters.Add("ChanDoanNoiGioiThieu", ThongTinDieuTri.ChanDoanNoiGioiThieu);
            Command.Parameters.Add("Buong", ThongTinDieuTri.Buong);
            Command.Parameters.Add("SoNhapVien", ThongTinDieuTri.SoNhapVien);
            Command.Parameters.Add("MaSoBenhTat", ThongTinDieuTri.MaSoBenhTat);
            Command.Parameters.Add("MaTruongPhongKHTH", ThongTinDieuTri.MaTruongPhongKHTH);
            Command.Parameters.Add("MaThayThuocDieuTri", ThongTinDieuTri.MaThayThuocDieuTri);
            Command.Parameters.Add("MaThayThuocKhamBenh", ThongTinDieuTri.MaThayThuocKhamBenh);
            Command.Parameters.Add("TongSoNgayDieuTriSauPT", ThongTinDieuTri.TongSoNgayDieuTriSauPT);
            Command.Parameters.Add("TongSoLanPhauThuat", ThongTinDieuTri.TongSoLanPhauThuat);
            Command.Parameters.Add("NguyenNhan_BenhChinh_RaVien", ThongTinDieuTri.NguyenNhan_BenhChinh_RaVien);
            Command.Parameters.Add("MaICD_NguyenNhan_BenhChinh_RV", ThongTinDieuTri.MaICD_NguyenNhan_BenhChinh_RV);
            Command.Parameters.Add("ChanDoanTruocPhauThuat", ThongTinDieuTri.ChanDoanTruocPhauThuat);
            Command.Parameters.Add("ChanDoanSauPhauThuat", ThongTinDieuTri.ChanDoanSauPhauThuat);
            Command.Parameters.Add("MaICD_ChanDoanTruocPhauThuat", ThongTinDieuTri.MaICD_ChanDoanTruocPhauThuat);
            Command.Parameters.Add("MaICD_ChanDoanSauPhauThuat", ThongTinDieuTri.MaICD_ChanDoanSauPhauThuat);
            Command.Parameters.Add("LucVaoDe", ThongTinDieuTri.LucVaoDe);
            Command.Parameters.Add("NgayDe", ThongTinDieuTri.NgayDe);
            Command.Parameters.Add("NgoiThai", ThongTinDieuTri.NgoiThai);
            Command.Parameters.Add("CachThucDe", ThongTinDieuTri.CachThucDe);
            Command.Parameters.Add("KiemSoatTuCung", ThongTinDieuTri.KiemSoatTuCung == true ? "1" : "0");
            Command.Parameters.Add("KiemSoatTuCung_Text", ThongTinDieuTri.KiemSoatTuCung_Text);
            Command.Parameters.Add("PhuongPhapPhauThuat", ThongTinDieuTri.PhuongPhapPhauThuat);
            Command.Parameters.Add("LyDoTaiBienBienChung", ThongTinDieuTri.LyDoTaiBienBienChung);
            Command.Parameters.Add("TinhHinhPhauThuat", ThongTinDieuTri.TinhHinhPhauThuat == true ? "1" : "0");
            Command.Parameters.Add("TreSoSinh_LoaiThai", ThongTinDieuTri.TreSoSinh_LoaiThai);
            Command.Parameters.Add("TreSoSinh_GioiTinh", ThongTinDieuTri.TreSoSinh_GioiTinh);
            Command.Parameters.Add("TreSoSinh_DiTat", ThongTinDieuTri.TreSoSinh_DiTat);
            Command.Parameters.Add("TreSoSinh_DiTat_Text", ThongTinDieuTri.TreSoSinh_DiTat_Text);
            Command.Parameters.Add("TreSoSinh_CanNang", ThongTinDieuTri.TreSoSinh_CanNang);
            Command.Parameters.Add("TreSoSinh_SongChet", ThongTinDieuTri.TreSoSinh_SongChet);
            Command.Parameters.Add("YHCT_BatCuongID", ThongTinDieuTri.YHCT_BatCuongID);
            Command.Parameters.Add("YHCT_TangPhuID", ThongTinDieuTri.YHCT_TangPhuID);
            Command.Parameters.Add("YHCT_KinhMachID", ThongTinDieuTri.YHCT_KinhMachID);
            Command.Parameters.Add("YHCT_DinhViBenhID", ThongTinDieuTri.YHCT_DinhViBenhID);
            Command.Parameters.Add("YHCT_NguyenNhanID", ThongTinDieuTri.YHCT_NguyenNhanID);
            Command.Parameters.Add("MaBenhAn", ThongTinDieuTri.MaBenhAn);
            Command.Parameters.Add("MaKhoa", ThongTinDieuTri.MaKhoa);
            Command.Parameters.Add("Giuong", ThongTinDieuTri.Giuong);
            Command.Parameters.Add("TenGiuong", ThongTinDieuTri.TenGiuong);

            Command.Parameters.Add("MaQuanLy", ThongTinDieuTri.MaQuanLy);
            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool DeleteThongTinDieuTri(MDB.MDBConnection MyConnection, ThongTinDieuTri ThongTinDieuTri)
        {
            string sql = @"DELETE FROM ThongTinDieuTri 
                           WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add("MaQuanLy", ThongTinDieuTri.MaQuanLy);

            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
    }
}
