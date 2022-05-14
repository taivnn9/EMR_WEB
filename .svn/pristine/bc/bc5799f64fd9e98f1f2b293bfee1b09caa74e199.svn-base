using System;
using System.Data;

namespace EMR_MAIN
{
    public class BenhAnNgoaiTruPemphigoidFunc
    {
        public static void WriteXml(MDB.MDBConnection MyConnection)
        {
            string sql =
                   @"
                  select  a.*,  CTScanner HoSo_CTScanner, SieuAm HoSo_SieuAm, XetNghiem HoSo_XetNghiem,  Khac HoSo_Khac,  Khac_Text HoSo_Khac_Text,  ToanBoHoSo HoSo_ToanBoHoSo, Mach DauSinhTon_Mach,  NhietDo DauSinhTon_NhietDo,  HuyetAp DauSinhTon_HuyetAp,  NhipTho DauSinhTon_NhipTho,  CanNang DauSinhTon_CanNang  
                  from BENHANNTPEMPHIGOID a inner join thongtindieutri b on a.maquanly = b.maquanly
                  where rownum = 1
                    ";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            var DataTable = new DataTable { TableName = "BENHANNTPEMPHIGOID" };
            DataTable.Load(DataReader as IDataReader);
            DataTable.WriteXml("rptBenhAnNgoaiTruPemphigoid.xml");
        }
        public static DataSet SelectDataSet(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql =
                   @"
                   select  a.*,f.hovaten BacSyLamBenhAnHoVaTen ,c.hovaten BacSyDieuTriHoVaTen,d.hovaten NguoiGiaoHoSoHoVaTen, k.hovaten BacSyKhamBenhHoVaTen, g.hovaten TK_BacSyDieuTriHoVaTen, e.hovaten NguoiNhanHoSoHoVaTen, b.XQuang HoSo_XQuang,   b.CTScanner HoSo_CTScanner, b.SieuAm HoSo_SieuAm, b.XetNghiem HoSo_XetNghiem,  b.Khac HoSo_Khac,  b.Khac_Text HoSo_Khac_Text,  b.ToanBoHoSo HoSo_ToanBoHoSo, b.Mach DauSinhTon_Mach, b.NhietDo DauSinhTon_NhietDo,  b.HuyetAp DauSinhTon_HuyetAp,  b.NhipTho DauSinhTon_NhipTho,  b.CanNang DauSinhTon_CanNang  , b.ChieuCao DauSinhTon_ChieuCao, b.BMI DauSinhTon_BMI, b.NgayRaVien 
                 from BENHANNTPEMPHIGOID a 
                 left join thongtindieutri b on a.maquanly = b.maquanly 
                  left join nhanvien c on a.bacsydieutri = c.manhanvien
                  left join nhanvien d on a.nguoigiaohoso = d.manhanvien
                  left join nhanvien g on a.TongKet_BacSyDieuTri = g.manhanvien
                  left join nhanvien k on a.BacSyKhamBenh = k.manhanvien
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
        public static BenhAnNgoaiTruPemphigoid Select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            #region
            string sql =
                      @"select * 
                        from BENHANNTPEMPHIGOID a
                        where MaQuanLy = :MaQuanLy";
            #endregion
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            var value = new BenhAnNgoaiTruPemphigoid();
            value.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
            while (DataReader.Read())
            {
                // Phần chung Hành chính
                value.MaQuanLy = DataReader.GetDecimal("MaQuanLy");
                value.DieuTriNgoaiTruTu = DataReader["DieuTriNgoaiTruTu"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["DieuTriNgoaiTruTu"]) : null;
                value.DieuTriNgoaiTruDen = DataReader["DieuTriNgoaiTruDen"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["DieuTriNgoaiTruDen"]) : null;
                value.SoCMND = DataReader["SoCMND"].ToString();
                value.BaoHiem = DataReader["BaoHiem"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["BaoHiem"]) : null;
                value.ChanDoan_TuyenTruoc = DataReader["ChanDoan_TuyenTruoc"].ToString();
                value.ChanDoanBanDau = DataReader["ChanDoanBanDau"].ToString();
                value.ChanDoanTaiKham1 = DataReader["ChanDoanTaiKham1"].ToString();
                value.ChanDoanTaiKham2 = DataReader["ChanDoanTaiKham2"].ToString();
                value.ChanDoanTaiKham3 = DataReader["ChanDoanTaiKham3"].ToString();
                value.ChanDoanTaiKham4 = DataReader["ChanDoanTaiKham4"].ToString();
                value.BenhPhu = DataReader["BenhPhu"].ToString();
                value.KetQuaDieuTri = DataReader.GetInt("KetQuaDieuTri");
                value.BienChung_Text = DataReader["BienChung_Text"].ToString();
                value.GDPhongKeHoach = DataReader["GDPhongKeHoach"].ToString();
                value.GDPhongKhamBenh = DataReader["GDPhongKhamBenh"].ToString();

                value.LyDoVaoVien = DataReader["LyDoVaoVien"].ToString();
                value.VaoNgayThu = DataReader.GetInt("VaoNgayThu");

                value.HB_TGPhatBenh = DataReader["HB_TGPhatBenh"].ToString();
                value.HB_TuoiBiBenh = DataReader["HB_TuoiBiBenh"].ToString();
                value.HB_LanVaoVien = DataReader["HB_LanVaoVien"].ToString();
                value.HB_TrieuChungDauTien = DataReader["HB_TrieuChungDauTien"].ToString();
                value.HB_TrieuChung_Khac = DataReader["HB_TrieuChung_Khac"].ToString();
                value.HB_QuaTrinhBenhLy = DataReader["HB_QuaTrinhBenhLy"].ToString();
                value.HB_DieuTriTruocDay = DataReader["HB_DieuTriTruocDay"].ToString();
                value.HB_TSBT_DiUngThuoc = DataReader["HB_TSBT_DiUngThuoc"].ToString();
                value.HB_TSBT_BenhNoiKhoaKhac = DataReader["HB_TSBT_BenhNoiKhoaKhac"].ToString();
                value.HB_TienSuGiaDinh = DataReader["HB_TienSuGiaDinh"].ToString();
                value.HB_ToanThan = DataReader["HB_ToanThan"].ToString();
                value.HB_CacBoPhan = DataReader["HB_CacBoPhan"].ToString();
                value.HB_LS_Mach = DataReader["HB_LS_Mach"].ToString();
                value.HB_LS_HuyetAp = DataReader["HB_LS_HuyetAp"].ToString();
                value.HB_LS_NhietDo = DataReader["HB_LS_NhietDo"].ToString();
                value.HB_LS_NhipTho = DataReader["HB_LS_NhipTho"].ToString();
                value.HB_LS_CanNang = DataReader["HB_LS_CanNang"].ToString();
                value.HB_LS_ChieuCao = DataReader["HB_LS_ChieuCao"].ToString();
                value.HB_LS_BMI = DataReader["HB_LS_BMI"].ToString();
                value.HB_TrieuChungCoNang_Arr = DataReader.GetInt("HB_TrieuChungCoNang_Arr");
                value.HB_KB_DauHieuKhac = DataReader["HB_KB_DauHieuKhac"].ToString();
                value.TTD_BongNuoc = DataReader.GetInt("TTD_BongNuoc");
                value.TTD_DichBongNuoc = DataReader.GetInt("TTD_DichBongNuoc");
                value.TTD_NDBongNuoc = DataReader.GetInt("TTD_NDBongNuoc");
                value.BongNuoc_KichThuoc = DataReader["BongNuoc_KichThuoc"].ToString();
                value.BongNuoc_SoLuong = DataReader["BongNuoc_SoLuong"].ToString();
                value.TTD_VetTrot = DataReader.GetInt("TTD_VetTrot");
                value.VetTrot_SoLuong = DataReader["VetTrot_SoLuong"].ToString();
                value.TTD_VayTiet = DataReader.GetInt("TTD_VayTiet");
                value.TTD_Sui = DataReader.GetInt("TTD_Sui");
                value.TTD_ViTriTT = DataReader["TTD_ViTriTT"].ToString();
                value.TTD_DauHieu = DataReader["TTD_DauHieu"].ToString();
                value.TTD_DiemPDAI = DataReader["TTD_DiemPDAI"].ToString();
                value.TTD_DiemCLCS = DataReader["TTD_DiemCLCS"].ToString();
                value.HB_CLS_CTM = DataReader.GetInt("HB_CLS_CTM");
                value.HB_CLS_CTM_Text = DataReader["HB_CLS_CTM_Text"].ToString();
                value.HB_CLS_SHM = DataReader.GetInt("HB_CLS_SHM");
                value.HB_CLS_SHM_Text = DataReader["HB_CLS_SHM_Text"].ToString();
                value.HB_CLS_PTNT = DataReader.GetInt("HB_CLS_PTNT");
                value.HB_CLS_PTNT_Text = DataReader["HB_CLS_PTNT_Text"].ToString();
                value.HB_CLS_XQN = DataReader.GetInt("HB_CLS_XQN");
                value.HB_CLS_XQN_Text = DataReader["HB_CLS_XQN_Text"].ToString();
                value.HB_CLS_SAOB = DataReader.GetInt("HB_CLS_SAOB");
                value.HB_CLS_SAOB_Text = DataReader["HB_CLS_SAOB_Text"].ToString();
                value.HB_CLS_STTB = DataReader.GetInt("HB_CLS_STTB");
                value.HB_CLS_XetNghiemTB = DataReader["HB_CLS_XetNghiemTB"].ToString();
                value.HB_CLS_MienDichTT = DataReader["HB_CLS_MienDichTT"].ToString();
                value.HB_CLS_MienDichGT = DataReader["HB_CLS_MienDichGT"].ToString();
                value.HB_CLS_SinhThietDa = DataReader["HB_CLS_SinhThietDa"].ToString();
                value.HB_CacXetNghiemKhac = DataReader["HB_CacXetNghiemKhac"].ToString();
                value.HB_ChanDoan = DataReader["HB_ChanDoan"].ToString();
                value.HB_DieuTri = DataReader["HB_DieuTri"].ToString();
                value.NgayTaiKham = DataReader.GetDate("NgayTaiKham");
                value.KB_Mach = DataReader["KB_Mach"].ToString();
                value.KB_LS_DaNiemMac = DataReader.GetInt("KB_LS_DaNiemMac");
                value.KB_Than = DataReader["KB_Than"].ToString();
                value.KB_Phoi = DataReader["KB_Phoi"].ToString();
                value.KB_TieuHoa = DataReader["KB_TieuHoa"].ToString();
                value.KB_Tim = DataReader["KB_Tim"].ToString();
                value.KB_ThanKinh = DataReader["KB_ThanKinh"].ToString();
                value.KB_CoXuongKhop = DataReader["KB_CoXuongKhop"].ToString();
                value.KB_CoQuanKhac = DataReader["KB_CoQuanKhac"].ToString();
                value.KB_CanLamSang = DataReader["KB_CanLamSang"].ToString();
                value.KB_TacDungPhu = DataReader["KB_TacDungPhu"].ToString();
                value.KB_HuongDieuTri = DataReader["KB_HuongDieuTri"].ToString();
                value.KB_NgayTaiKham = DataReader.GetDate("KB_NgayTaiKham");
                value.MaSoKyTen = DataReader["MaSoKyTen"].ToString();
                value.MaSoKyTen_KB = DataReader["MaSoKyTen_KB"].ToString();
                value.MaSoKyTen_TK = DataReader["MaSoKyTen_TK"].ToString();
                value.BacSyDieuTri = DataReader["BacSyDieuTri"].ToString();
                value.BacSyKhamBenh = DataReader["BacSyKhamBenh"].ToString();


                // Tổng kết
                value.QuaTrinhBenhLy = DataReader["QuaTrinhBenhLy"].ToString();
                value.TomTatKetQua = DataReader["TomTatKetQua"].ToString();
                value.BenhChinh = DataReader["BenhChinh"].ToString();
                value.MaBenhChinh = DataReader["MaBenhChinh"].ToString();
                value.BenhKemTheo = DataReader["BenhKemTheo"].ToString();
                value.MaBenhKemTheo = DataReader["MaBenhKemTheo"].ToString();
                value.PhuongPhapDieuTri = DataReader["PhuongPhapDieuTri"].ToString();
                value.TinhTrangRaVien = DataReader["TinhTrangRaVien"].ToString();
                value.HuongDieuTri = DataReader["HuongDieuTri"].ToString();
                value.NguoiNhanHoSo = DataReader["NguoiNhanHoSo"].ToString();
                value.NguoiGiaoHoSo = DataReader["NguoiGiaoHoSo"].ToString();
                value.NgayTongKet = DataReader["NgayTongKet"] != DBNull.Value ? Convert.ToDateTime(DataReader["NgayTongKet"]) : DateTime.Now;
                value.TongKet_BacSyDieuTri = DataReader["TongKet_BacSyDieuTri"].ToString();
                value.TongKet_MaBacSyDieuTri = DataReader["TongKet_MaBacSyDieuTri"].ToString();
            }
            return value;
        }

        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, BenhAnNgoaiTruPemphigoid BenhAnNgoaiTruPemphigoid)
        {
            string sql =
                      @"select MaQuanLy 
                        from BENHANNTPEMPHIGOID
                        where MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnNgoaiTruPemphigoid.MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            int rowCount = 0;
            while (DataReader.Read()) rowCount++;
            if (rowCount == 1) return Update(MyConnection, BenhAnNgoaiTruPemphigoid);
            sql = @"
                   INSERT INTO BENHANNTPEMPHIGOID (
                            maquanly,
                            lydovaovien,
                            vaongaythu,
                            HB_TGPhatBenh,
                            HB_TuoiBiBenh,
                            HB_LanVaoVien,
                            HB_TrieuChungDauTien,
                            HB_TrieuChung_Khac,
                            HB_QuaTrinhBenhLy,
                            HB_DieuTriTruocDay,
                            HB_TSBT_DiUngThuoc,
                            HB_TSBT_BenhNoiKhoaKhac,
                            HB_TienSuGiaDinh,
                            HB_ToanThan,
                            HB_CacBoPhan,
                            HB_LS_Mach,
                            HB_LS_HuyetAp,
                            HB_LS_NhietDo,
                            HB_LS_NhipTho,
                            HB_LS_CanNang,
                            HB_LS_ChieuCao,
                            HB_LS_BMI,
                            HB_TrieuChungCoNang_Arr,
                            HB_KB_DauHieuKhac,
                            TTD_BongNuoc,
                            TTD_DichBongNuoc,
                            TTD_NDBongNuoc,
                            BongNuoc_KichThuoc,
                            BongNuoc_SoLuong,
                            TTD_VetTrot,
                            VetTrot_SoLuong,
                            TTD_VayTiet,
                            TTD_Sui,
                            TTD_ViTriTT,
                            TTD_DauHieu,
                            TTD_DiemPDAI,
                            TTD_DiemCLCS,
                            HB_CLS_CTM,
                            HB_CLS_CTM_Text,
                            HB_CLS_SHM,
                            HB_CLS_SHM_Text,
                            HB_CLS_PTNT,
                            HB_CLS_PTNT_Text,
                            HB_CLS_XQN,
                            HB_CLS_XQN_Text,
                            HB_CLS_SAOB,
                            HB_CLS_SAOB_Text,
                            HB_CLS_STTB,
                            HB_CLS_XetNghiemTB,
                            HB_CLS_MienDichTT,
                            HB_CLS_MienDichGT,
                            HB_CLS_SinhThietDa,
                            HB_CacXetNghiemKhac,
                            HB_ChanDoan,
                            HB_DieuTri,
                            NgayTaiKham,
                            KB_Mach,
                            KB_LS_DaNiemMac,
                            KB_Than,
                            KB_Phoi,
                            KB_TieuHoa,
                            KB_Tim,
                            KB_ThanKinh,
                            KB_CoXuongKhop,
                            KB_CoQuanKhac,
                            KB_CanLamSang,
                            KB_TacDungPhu,
                            KB_HuongDieuTri,
                            KB_NgayTaiKham,
                            HuongDieuTri,
                            TinhTrangRaVien,
                            PhuongPhapDieuTri,
                            MaBenhKemTheo,
                            BenhKemTheo,
                            BenhChinh,
                            MaBenhChinh,
                            TomTatKetQua,
                            QuaTrinhBenhLy,
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
                            NguoiNhanHoSo,
                            NguoiGiaoHoSo,
                            NgayTongKet,
                            TongKet_BacSyDieuTri,
                            TongKet_MaBacSyDieuTri,
                            BacSyDieuTri,
                            BacSyKhamBenh
                    )
                   VALUES(
                            :maquanly,
                            :lydovaovien,
                            :vaongaythu,
                            :HB_TGPhatBenh,
                            :HB_TuoiBiBenh,
                            :HB_LanVaoVien,
                            :HB_TrieuChungDauTien,
                            :HB_TrieuChung_Khac,
                            :HB_QuaTrinhBenhLy,
                            :HB_DieuTriTruocDay,
                            :HB_TSBT_DiUngThuoc,
                            :HB_TSBT_BenhNoiKhoaKhac,
                            :HB_TienSuGiaDinh,
                            :HB_ToanThan,
                            :HB_CacBoPhan,
                            :HB_LS_Mach,
                            :HB_LS_HuyetAp,
                            :HB_LS_NhietDo,
                            :HB_LS_NhipTho,
                            :HB_LS_CanNang,
                            :HB_LS_ChieuCao,
                            :HB_LS_BMI,
                            :HB_TrieuChungCoNang_Arr,
                            :HB_KB_DauHieuKhac,
                            :TTD_BongNuoc,
                            :TTD_DichBongNuoc,
                            :TTD_NDBongNuoc,
                            :BongNuoc_KichThuoc,
                            :BongNuoc_SoLuong,
                            :TTD_VetTrot,
                            :VetTrot_SoLuong,
                            :TTD_VayTiet,
                            :TTD_Sui,
                            :TTD_ViTriTT,
                            :TTD_DauHieu,
                            :TTD_DiemPDAI,
                            :TTD_DiemCLCS,
                            :HB_CLS_CTM,
                            :HB_CLS_CTM_Text,
                            :HB_CLS_SHM,
                            :HB_CLS_SHM_Text,
                            :HB_CLS_PTNT,
                            :HB_CLS_PTNT_Text,
                            :HB_CLS_XQN,
                            :HB_CLS_XQN_Text,
                            :HB_CLS_SAOB,
                            :HB_CLS_SAOB_Text,
                            :HB_CLS_STTB,
                            :HB_CLS_XetNghiemTB,
                            :HB_CLS_MienDichTT,
                            :HB_CLS_MienDichGT,
                            :HB_CLS_SinhThietDa,
                            :HB_CacXetNghiemKhac,
                            :HB_ChanDoan,
                            :HB_DieuTri,
                            :NgayTaiKham,
                            :KB_Mach,
                            :KB_LS_DaNiemMac,
                            :KB_Than,
                            :KB_Phoi,
                            :KB_TieuHoa,
                            :KB_Tim,
                            :KB_ThanKinh,
                            :KB_CoXuongKhop,
                            :KB_CoQuanKhac,
                            :KB_CanLamSang,
                            :KB_TacDungPhu,
                            :KB_HuongDieuTri,
                            :KB_NgayTaiKham,
                            :HuongDieuTri,
                            :TinhTrangRaVien,
                            :PhuongPhapDieuTri,
                            :MaBenhKemTheo,
                            :BenhKemTheo,
                            :BenhChinh,
                            :MaBenhChinh,
                            :TomTatKetQua,
                            :QuaTrinhBenhLy,
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
                            :NguoiNhanHoSo,
                            :NguoiGiaoHoSo,
                            :NgayTongKet,
                            :TongKet_BacSyDieuTri,
                            :TongKet_MaBacSyDieuTri,
                            :BacSyDieuTri,
                            :BacSyKhamBenh
                    )
                   ";
            Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnNgoaiTruPemphigoid.MaQuanLy));
            Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnNgoaiTruPemphigoid.LyDoVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("VaoNgayThu", BenhAnNgoaiTruPemphigoid.VaoNgayThu));
            Command.Parameters.Add(new MDB.MDBParameter("HB_TGPhatBenh", BenhAnNgoaiTruPemphigoid.HB_TGPhatBenh));
            Command.Parameters.Add(new MDB.MDBParameter("HB_TuoiBiBenh", BenhAnNgoaiTruPemphigoid.HB_TuoiBiBenh));
            Command.Parameters.Add(new MDB.MDBParameter("HB_LanVaoVien", BenhAnNgoaiTruPemphigoid.HB_LanVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("HB_TrieuChungDauTien", BenhAnNgoaiTruPemphigoid.HB_TrieuChungDauTien));
            Command.Parameters.Add(new MDB.MDBParameter("HB_TrieuChung_Khac", BenhAnNgoaiTruPemphigoid.HB_TrieuChung_Khac));
            Command.Parameters.Add(new MDB.MDBParameter("HB_QuaTrinhBenhLy", BenhAnNgoaiTruPemphigoid.HB_QuaTrinhBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("HB_DieuTriTruocDay", BenhAnNgoaiTruPemphigoid.HB_DieuTriTruocDay));
            Command.Parameters.Add(new MDB.MDBParameter("HB_TSBT_DiUngThuoc", BenhAnNgoaiTruPemphigoid.HB_TSBT_DiUngThuoc));
            Command.Parameters.Add(new MDB.MDBParameter("HB_TSBT_BenhNoiKhoaKhac", BenhAnNgoaiTruPemphigoid.HB_TSBT_BenhNoiKhoaKhac));
            Command.Parameters.Add(new MDB.MDBParameter("HB_TienSuGiaDinh", BenhAnNgoaiTruPemphigoid.HB_TienSuGiaDinh));
            Command.Parameters.Add(new MDB.MDBParameter("HB_ToanThan", BenhAnNgoaiTruPemphigoid.HB_ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("HB_CacBoPhan", BenhAnNgoaiTruPemphigoid.HB_CacBoPhan));
            Command.Parameters.Add(new MDB.MDBParameter("HB_LS_Mach", BenhAnNgoaiTruPemphigoid.HB_LS_Mach));
            Command.Parameters.Add(new MDB.MDBParameter("HB_LS_HuyetAp", BenhAnNgoaiTruPemphigoid.HB_LS_HuyetAp));
            Command.Parameters.Add(new MDB.MDBParameter("HB_LS_NhietDo", BenhAnNgoaiTruPemphigoid.HB_LS_NhietDo));
            Command.Parameters.Add(new MDB.MDBParameter("HB_LS_NhipTho", BenhAnNgoaiTruPemphigoid.HB_LS_NhipTho));
            Command.Parameters.Add(new MDB.MDBParameter("HB_LS_CanNang", BenhAnNgoaiTruPemphigoid.HB_LS_CanNang));
            Command.Parameters.Add(new MDB.MDBParameter("HB_LS_ChieuCao", BenhAnNgoaiTruPemphigoid.HB_LS_ChieuCao));
            Command.Parameters.Add(new MDB.MDBParameter("HB_LS_BMI", BenhAnNgoaiTruPemphigoid.HB_LS_BMI));
            Command.Parameters.Add(new MDB.MDBParameter("HB_TrieuChungCoNang_Arr", BenhAnNgoaiTruPemphigoid.HB_TrieuChungCoNang_Arr));
            Command.Parameters.Add(new MDB.MDBParameter("HB_KB_DauHieuKhac", BenhAnNgoaiTruPemphigoid.HB_KB_DauHieuKhac));
            Command.Parameters.Add(new MDB.MDBParameter("TTD_BongNuoc", BenhAnNgoaiTruPemphigoid.TTD_BongNuoc));
            Command.Parameters.Add(new MDB.MDBParameter("TTD_DichBongNuoc", BenhAnNgoaiTruPemphigoid.TTD_DichBongNuoc));
            Command.Parameters.Add(new MDB.MDBParameter("TTD_NDBongNuoc", BenhAnNgoaiTruPemphigoid.TTD_NDBongNuoc));
            Command.Parameters.Add(new MDB.MDBParameter("BongNuoc_KichThuoc", BenhAnNgoaiTruPemphigoid.BongNuoc_KichThuoc));
            Command.Parameters.Add(new MDB.MDBParameter("BongNuoc_SoLuong", BenhAnNgoaiTruPemphigoid.BongNuoc_SoLuong));
            Command.Parameters.Add(new MDB.MDBParameter("TTD_VetTrot", BenhAnNgoaiTruPemphigoid.TTD_VetTrot));
            Command.Parameters.Add(new MDB.MDBParameter("VetTrot_SoLuong", BenhAnNgoaiTruPemphigoid.VetTrot_SoLuong));
            Command.Parameters.Add(new MDB.MDBParameter("TTD_VayTiet", BenhAnNgoaiTruPemphigoid.TTD_VayTiet));
            Command.Parameters.Add(new MDB.MDBParameter("TTD_Sui", BenhAnNgoaiTruPemphigoid.TTD_Sui));
            Command.Parameters.Add(new MDB.MDBParameter("TTD_ViTriTT", BenhAnNgoaiTruPemphigoid.TTD_ViTriTT));
            Command.Parameters.Add(new MDB.MDBParameter("TTD_DauHieu", BenhAnNgoaiTruPemphigoid.TTD_DauHieu));
            Command.Parameters.Add(new MDB.MDBParameter("TTD_DiemPDAI", BenhAnNgoaiTruPemphigoid.TTD_DiemPDAI));
            Command.Parameters.Add(new MDB.MDBParameter("TTD_DiemCLCS", BenhAnNgoaiTruPemphigoid.TTD_DiemCLCS));
            Command.Parameters.Add(new MDB.MDBParameter("HB_CLS_CTM", BenhAnNgoaiTruPemphigoid.HB_CLS_CTM));
            Command.Parameters.Add(new MDB.MDBParameter("HB_CLS_CTM_Text", BenhAnNgoaiTruPemphigoid.HB_CLS_CTM_Text));
            Command.Parameters.Add(new MDB.MDBParameter("HB_CLS_SHM", BenhAnNgoaiTruPemphigoid.HB_CLS_SHM));
            Command.Parameters.Add(new MDB.MDBParameter("HB_CLS_SHM_Text", BenhAnNgoaiTruPemphigoid.HB_CLS_SHM_Text));
            Command.Parameters.Add(new MDB.MDBParameter("HB_CLS_PTNT", BenhAnNgoaiTruPemphigoid.HB_CLS_PTNT));
            Command.Parameters.Add(new MDB.MDBParameter("HB_CLS_PTNT_Text", BenhAnNgoaiTruPemphigoid.HB_CLS_PTNT_Text));
            Command.Parameters.Add(new MDB.MDBParameter("HB_CLS_XQN", BenhAnNgoaiTruPemphigoid.HB_CLS_XQN));
            Command.Parameters.Add(new MDB.MDBParameter("HB_CLS_XQN_Text", BenhAnNgoaiTruPemphigoid.HB_CLS_XQN_Text));
            Command.Parameters.Add(new MDB.MDBParameter("HB_CLS_SAOB", BenhAnNgoaiTruPemphigoid.HB_CLS_SAOB));
            Command.Parameters.Add(new MDB.MDBParameter("HB_CLS_SAOB_Text", BenhAnNgoaiTruPemphigoid.HB_CLS_SAOB_Text));
            Command.Parameters.Add(new MDB.MDBParameter("HB_CLS_STTB", BenhAnNgoaiTruPemphigoid.HB_CLS_STTB));
            Command.Parameters.Add(new MDB.MDBParameter("HB_CLS_XetNghiemTB", BenhAnNgoaiTruPemphigoid.HB_CLS_XetNghiemTB));
            Command.Parameters.Add(new MDB.MDBParameter("HB_CLS_MienDichTT", BenhAnNgoaiTruPemphigoid.HB_CLS_MienDichTT));
            Command.Parameters.Add(new MDB.MDBParameter("HB_CLS_MienDichGT", BenhAnNgoaiTruPemphigoid.HB_CLS_MienDichGT));
            Command.Parameters.Add(new MDB.MDBParameter("HB_CLS_SinhThietDa", BenhAnNgoaiTruPemphigoid.HB_CLS_SinhThietDa));
            Command.Parameters.Add(new MDB.MDBParameter("HB_CacXetNghiemKhac", BenhAnNgoaiTruPemphigoid.HB_CacXetNghiemKhac));
            Command.Parameters.Add(new MDB.MDBParameter("HB_ChanDoan", BenhAnNgoaiTruPemphigoid.HB_ChanDoan));
            Command.Parameters.Add(new MDB.MDBParameter("HB_DieuTri", BenhAnNgoaiTruPemphigoid.HB_DieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("NgayTaiKham", BenhAnNgoaiTruPemphigoid.NgayTaiKham));
            Command.Parameters.Add(new MDB.MDBParameter("KB_Mach", BenhAnNgoaiTruPemphigoid.KB_Mach));
            Command.Parameters.Add(new MDB.MDBParameter("KB_LS_DaNiemMac", BenhAnNgoaiTruPemphigoid.KB_LS_DaNiemMac));
            Command.Parameters.Add(new MDB.MDBParameter("KB_Than", BenhAnNgoaiTruPemphigoid.KB_Than));
            Command.Parameters.Add(new MDB.MDBParameter("KB_Phoi", BenhAnNgoaiTruPemphigoid.KB_Phoi));
            Command.Parameters.Add(new MDB.MDBParameter("KB_TieuHoa", BenhAnNgoaiTruPemphigoid.KB_TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("KB_Tim", BenhAnNgoaiTruPemphigoid.KB_Tim));
            Command.Parameters.Add(new MDB.MDBParameter("KB_ThanKinh", BenhAnNgoaiTruPemphigoid.KB_ThanKinh));
            Command.Parameters.Add(new MDB.MDBParameter("KB_CoXuongKhop", BenhAnNgoaiTruPemphigoid.KB_CoXuongKhop));
            Command.Parameters.Add(new MDB.MDBParameter("KB_CoQuanKhac", BenhAnNgoaiTruPemphigoid.KB_CoQuanKhac));
            Command.Parameters.Add(new MDB.MDBParameter("KB_CanLamSang", BenhAnNgoaiTruPemphigoid.KB_CanLamSang));
            Command.Parameters.Add(new MDB.MDBParameter("KB_TacDungPhu", BenhAnNgoaiTruPemphigoid.KB_TacDungPhu));
            Command.Parameters.Add(new MDB.MDBParameter("KB_HuongDieuTri", BenhAnNgoaiTruPemphigoid.KB_HuongDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("KB_NgayTaiKham", BenhAnNgoaiTruPemphigoid.KB_NgayTaiKham));

            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnNgoaiTruPemphigoid.HuongDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangRaVien", BenhAnNgoaiTruPemphigoid.TinhTrangRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnNgoaiTruPemphigoid.PhuongPhapDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("MaBenhKemTheo", BenhAnNgoaiTruPemphigoid.MaBenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnNgoaiTruPemphigoid.BenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnNgoaiTruPemphigoid.BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("MaBenhChinh", BenhAnNgoaiTruPemphigoid.MaBenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQua", BenhAnNgoaiTruPemphigoid.TomTatKetQua));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnNgoaiTruPemphigoid.QuaTrinhBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("DieuTriNgoaiTruTu", BenhAnNgoaiTruPemphigoid.DieuTriNgoaiTruTu));
            Command.Parameters.Add(new MDB.MDBParameter("DieuTriNgoaiTruDen", BenhAnNgoaiTruPemphigoid.DieuTriNgoaiTruDen));
            Command.Parameters.Add(new MDB.MDBParameter("SoCMND", BenhAnNgoaiTruPemphigoid.SoCMND));
            Command.Parameters.Add(new MDB.MDBParameter("BaoHiem", BenhAnNgoaiTruPemphigoid.BaoHiem));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoan_TuyenTruoc", BenhAnNgoaiTruPemphigoid.ChanDoan_TuyenTruoc));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanBanDau", BenhAnNgoaiTruPemphigoid.ChanDoanBanDau));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham1", BenhAnNgoaiTruPemphigoid.ChanDoanTaiKham1));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham2", BenhAnNgoaiTruPemphigoid.ChanDoanTaiKham2));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham3", BenhAnNgoaiTruPemphigoid.ChanDoanTaiKham3));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham4", BenhAnNgoaiTruPemphigoid.ChanDoanTaiKham4));
            Command.Parameters.Add(new MDB.MDBParameter("BenhPhu", BenhAnNgoaiTruPemphigoid.BenhPhu));
            Command.Parameters.Add(new MDB.MDBParameter("KetQuaDieuTri", BenhAnNgoaiTruPemphigoid.KetQuaDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("BienChung_Text", BenhAnNgoaiTruPemphigoid.BienChung_Text));
            Command.Parameters.Add(new MDB.MDBParameter("GDPhongKeHoach", BenhAnNgoaiTruPemphigoid.GDPhongKeHoach));
            Command.Parameters.Add(new MDB.MDBParameter("GDPhongKhamBenh", BenhAnNgoaiTruPemphigoid.GDPhongKhamBenh));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnNgoaiTruPemphigoid.NguoiNhanHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnNgoaiTruPemphigoid.NguoiGiaoHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnNgoaiTruPemphigoid.NgayTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("TongKet_BacSyDieuTri", BenhAnNgoaiTruPemphigoid.TongKet_BacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("TongKet_MaBacSyDieuTri", BenhAnNgoaiTruPemphigoid.TongKet_MaBacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnNgoaiTruPemphigoid.BacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyKhamBenh", BenhAnNgoaiTruPemphigoid.BacSyKhamBenh));

            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool Update(MDB.MDBConnection MyConnection, BenhAnNgoaiTruPemphigoid BenhAnNgoaiTruPemphigoid)
        {
            string sql = @"UPDATE BENHANNTPEMPHIGOID SET 
                        LyDoVaoVien =: LyDoVaoVien,
                        VaoNgayThu =: VaoNgayThu,
                        HB_TGPhatBenh = :HB_TGPhatBenh,
                        HB_TuoiBiBenh = :HB_TuoiBiBenh,
                        HB_LanVaoVien = :HB_LanVaoVien,
                        HB_TrieuChungDauTien = :HB_TrieuChungDauTien,
                        HB_TrieuChung_Khac = :HB_TrieuChung_Khac,
                        HB_QuaTrinhBenhLy = :HB_QuaTrinhBenhLy,
                        HB_DieuTriTruocDay = :HB_DieuTriTruocDay,
                        HB_TSBT_DiUngThuoc = :HB_TSBT_DiUngThuoc,
                        HB_TSBT_BenhNoiKhoaKhac = :HB_TSBT_BenhNoiKhoaKhac,
                        HB_TienSuGiaDinh = :HB_TienSuGiaDinh,
                        HB_ToanThan = :HB_ToanThan,
                        HB_CacBoPhan = :HB_CacBoPhan,
                        HB_LS_Mach = :HB_LS_Mach,
                        HB_LS_HuyetAp = :HB_LS_HuyetAp,
                        HB_LS_NhietDo = :HB_LS_NhietDo,
                        HB_LS_NhipTho = :HB_LS_NhipTho,
                        HB_LS_CanNang = :HB_LS_CanNang,
                        HB_LS_ChieuCao = :HB_LS_ChieuCao,
                        HB_LS_BMI = :HB_LS_BMI,
                        HB_TrieuChungCoNang_Arr = :HB_TrieuChungCoNang_Arr,
                        HB_KB_DauHieuKhac = :HB_KB_DauHieuKhac,
                        TTD_BongNuoc = :TTD_BongNuoc,
                        TTD_DichBongNuoc = :TTD_DichBongNuoc,
                        TTD_NDBongNuoc = :TTD_NDBongNuoc,
                        BongNuoc_KichThuoc = :BongNuoc_KichThuoc,
                        BongNuoc_SoLuong = :BongNuoc_SoLuong,
                        TTD_VetTrot = :TTD_VetTrot,
                        VetTrot_SoLuong = :VetTrot_SoLuong,
                        TTD_VayTiet = :TTD_VayTiet,
                        TTD_Sui = :TTD_Sui,
                        TTD_ViTriTT = :TTD_ViTriTT,
                        TTD_DauHieu = :TTD_DauHieu,
                        TTD_DiemPDAI = :TTD_DiemPDAI,
                        TTD_DiemCLCS = :TTD_DiemCLCS,
                        HB_CLS_CTM = :HB_CLS_CTM,
                        HB_CLS_CTM_Text = :HB_CLS_CTM_Text,
                        HB_CLS_SHM = :HB_CLS_SHM,
                        HB_CLS_SHM_Text = :HB_CLS_SHM_Text,
                        HB_CLS_PTNT = :HB_CLS_PTNT,
                        HB_CLS_PTNT_Text = :HB_CLS_PTNT_Text,
                        HB_CLS_XQN = :HB_CLS_XQN,
                        HB_CLS_XQN_Text = :HB_CLS_XQN_Text,
                        HB_CLS_SAOB = :HB_CLS_SAOB,
                        HB_CLS_SAOB_Text = :HB_CLS_SAOB_Text,
                        HB_CLS_STTB = :HB_CLS_STTB,
                        HB_CLS_XetNghiemTB = :HB_CLS_XetNghiemTB,
                        HB_CLS_MienDichTT = :HB_CLS_MienDichTT,
                        HB_CLS_MienDichGT = :HB_CLS_MienDichGT,
                        HB_CLS_SinhThietDa = :HB_CLS_SinhThietDa,
                        HB_CacXetNghiemKhac = :HB_CacXetNghiemKhac,
                        HB_ChanDoan = :HB_ChanDoan,
                        HB_DieuTri = :HB_DieuTri,
                        NgayTaiKham = :NgayTaiKham,
                        KB_Mach = :KB_Mach,
                        KB_LS_DaNiemMac = :KB_LS_DaNiemMac,
                        KB_Than = :KB_Than,
                        KB_Phoi = :KB_Phoi,
                        KB_TieuHoa = :KB_TieuHoa,
                        KB_Tim = :KB_Tim,
                        KB_ThanKinh = :KB_ThanKinh,
                        KB_CoXuongKhop = :KB_CoXuongKhop,
                        KB_CoQuanKhac = :KB_CoQuanKhac,
                        KB_CanLamSang = :KB_CanLamSang,
                        KB_TacDungPhu = :KB_TacDungPhu,
                        KB_HuongDieuTri = :KB_HuongDieuTri,
                        KB_NgayTaiKham = :KB_NgayTaiKham,
                        HuongDieuTri=:HuongDieuTri,
                        TinhTrangRaVien=:TinhTrangRaVien,
                        PhuongPhapDieuTri=:PhuongPhapDieuTri,
                        MaBenhKemTheo=:MaBenhKemTheo,
                        BenhKemTheo=:BenhKemTheo,
                        BenhChinh=:BenhChinh,
                        MaBenhChinh=:MaBenhChinh,
                        TomTatKetQua=:TomTatKetQua,
                        QuaTrinhBenhLy=:QuaTrinhBenhLy,
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
                        NguoiNhanHoSo=:NguoiNhanHoSo,
                        NguoiGiaoHoSo=:NguoiGiaoHoSo,
                        NgayTongKet=:NgayTongKet,
                        TongKet_BacSyDieuTri=:TongKet_BacSyDieuTri,
                        TongKet_MaBacSyDieuTri=:TongKet_MaBacSyDieuTri,
                        BacSyDieuTri = :BacSyDieuTri,
                        BacSyKhamBenh = :BacSyKhamBenh 

                        WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnNgoaiTruPemphigoid.LyDoVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("VaoNgayThu", BenhAnNgoaiTruPemphigoid.VaoNgayThu));
            Command.Parameters.Add(new MDB.MDBParameter("HB_TGPhatBenh", BenhAnNgoaiTruPemphigoid.HB_TGPhatBenh));
            Command.Parameters.Add(new MDB.MDBParameter("HB_TuoiBiBenh", BenhAnNgoaiTruPemphigoid.HB_TuoiBiBenh));
            Command.Parameters.Add(new MDB.MDBParameter("HB_LanVaoVien", BenhAnNgoaiTruPemphigoid.HB_LanVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("HB_TrieuChungDauTien", BenhAnNgoaiTruPemphigoid.HB_TrieuChungDauTien));
            Command.Parameters.Add(new MDB.MDBParameter("HB_TrieuChung_Khac", BenhAnNgoaiTruPemphigoid.HB_TrieuChung_Khac));
            Command.Parameters.Add(new MDB.MDBParameter("HB_QuaTrinhBenhLy", BenhAnNgoaiTruPemphigoid.HB_QuaTrinhBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("HB_DieuTriTruocDay", BenhAnNgoaiTruPemphigoid.HB_DieuTriTruocDay));
            Command.Parameters.Add(new MDB.MDBParameter("HB_TSBT_DiUngThuoc", BenhAnNgoaiTruPemphigoid.HB_TSBT_DiUngThuoc));
            Command.Parameters.Add(new MDB.MDBParameter("HB_TSBT_BenhNoiKhoaKhac", BenhAnNgoaiTruPemphigoid.HB_TSBT_BenhNoiKhoaKhac));
            Command.Parameters.Add(new MDB.MDBParameter("HB_TienSuGiaDinh", BenhAnNgoaiTruPemphigoid.HB_TienSuGiaDinh));
            Command.Parameters.Add(new MDB.MDBParameter("HB_ToanThan", BenhAnNgoaiTruPemphigoid.HB_ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("HB_CacBoPhan", BenhAnNgoaiTruPemphigoid.HB_CacBoPhan));
            Command.Parameters.Add(new MDB.MDBParameter("HB_LS_Mach", BenhAnNgoaiTruPemphigoid.HB_LS_Mach));
            Command.Parameters.Add(new MDB.MDBParameter("HB_LS_HuyetAp", BenhAnNgoaiTruPemphigoid.HB_LS_HuyetAp));
            Command.Parameters.Add(new MDB.MDBParameter("HB_LS_NhietDo", BenhAnNgoaiTruPemphigoid.HB_LS_NhietDo));
            Command.Parameters.Add(new MDB.MDBParameter("HB_LS_NhipTho", BenhAnNgoaiTruPemphigoid.HB_LS_NhipTho));
            Command.Parameters.Add(new MDB.MDBParameter("HB_LS_CanNang", BenhAnNgoaiTruPemphigoid.HB_LS_CanNang));
            Command.Parameters.Add(new MDB.MDBParameter("HB_LS_ChieuCao", BenhAnNgoaiTruPemphigoid.HB_LS_ChieuCao));
            Command.Parameters.Add(new MDB.MDBParameter("HB_LS_BMI", BenhAnNgoaiTruPemphigoid.HB_LS_BMI));
            Command.Parameters.Add(new MDB.MDBParameter("HB_TrieuChungCoNang_Arr", BenhAnNgoaiTruPemphigoid.HB_TrieuChungCoNang_Arr));
            Command.Parameters.Add(new MDB.MDBParameter("HB_KB_DauHieuKhac", BenhAnNgoaiTruPemphigoid.HB_KB_DauHieuKhac));
            Command.Parameters.Add(new MDB.MDBParameter("TTD_BongNuoc", BenhAnNgoaiTruPemphigoid.TTD_BongNuoc));
            Command.Parameters.Add(new MDB.MDBParameter("TTD_DichBongNuoc", BenhAnNgoaiTruPemphigoid.TTD_DichBongNuoc));
            Command.Parameters.Add(new MDB.MDBParameter("TTD_NDBongNuoc", BenhAnNgoaiTruPemphigoid.TTD_NDBongNuoc));
            Command.Parameters.Add(new MDB.MDBParameter("BongNuoc_KichThuoc", BenhAnNgoaiTruPemphigoid.BongNuoc_KichThuoc));
            Command.Parameters.Add(new MDB.MDBParameter("BongNuoc_SoLuong", BenhAnNgoaiTruPemphigoid.BongNuoc_SoLuong));
            Command.Parameters.Add(new MDB.MDBParameter("TTD_VetTrot", BenhAnNgoaiTruPemphigoid.TTD_VetTrot));
            Command.Parameters.Add(new MDB.MDBParameter("VetTrot_SoLuong", BenhAnNgoaiTruPemphigoid.VetTrot_SoLuong));
            Command.Parameters.Add(new MDB.MDBParameter("TTD_VayTiet", BenhAnNgoaiTruPemphigoid.TTD_VayTiet));
            Command.Parameters.Add(new MDB.MDBParameter("TTD_Sui", BenhAnNgoaiTruPemphigoid.TTD_Sui));
            Command.Parameters.Add(new MDB.MDBParameter("TTD_ViTriTT", BenhAnNgoaiTruPemphigoid.TTD_ViTriTT));
            Command.Parameters.Add(new MDB.MDBParameter("TTD_DauHieu", BenhAnNgoaiTruPemphigoid.TTD_DauHieu));
            Command.Parameters.Add(new MDB.MDBParameter("TTD_DiemPDAI", BenhAnNgoaiTruPemphigoid.TTD_DiemPDAI));
            Command.Parameters.Add(new MDB.MDBParameter("TTD_DiemCLCS", BenhAnNgoaiTruPemphigoid.TTD_DiemCLCS));
            Command.Parameters.Add(new MDB.MDBParameter("HB_CLS_CTM", BenhAnNgoaiTruPemphigoid.HB_CLS_CTM));
            Command.Parameters.Add(new MDB.MDBParameter("HB_CLS_CTM_Text", BenhAnNgoaiTruPemphigoid.HB_CLS_CTM_Text));
            Command.Parameters.Add(new MDB.MDBParameter("HB_CLS_SHM", BenhAnNgoaiTruPemphigoid.HB_CLS_SHM));
            Command.Parameters.Add(new MDB.MDBParameter("HB_CLS_SHM_Text", BenhAnNgoaiTruPemphigoid.HB_CLS_SHM_Text));
            Command.Parameters.Add(new MDB.MDBParameter("HB_CLS_PTNT", BenhAnNgoaiTruPemphigoid.HB_CLS_PTNT));
            Command.Parameters.Add(new MDB.MDBParameter("HB_CLS_PTNT_Text", BenhAnNgoaiTruPemphigoid.HB_CLS_PTNT_Text));
            Command.Parameters.Add(new MDB.MDBParameter("HB_CLS_XQN", BenhAnNgoaiTruPemphigoid.HB_CLS_XQN));
            Command.Parameters.Add(new MDB.MDBParameter("HB_CLS_XQN_Text", BenhAnNgoaiTruPemphigoid.HB_CLS_XQN_Text));
            Command.Parameters.Add(new MDB.MDBParameter("HB_CLS_SAOB", BenhAnNgoaiTruPemphigoid.HB_CLS_SAOB));
            Command.Parameters.Add(new MDB.MDBParameter("HB_CLS_SAOB_Text", BenhAnNgoaiTruPemphigoid.HB_CLS_SAOB_Text));
            Command.Parameters.Add(new MDB.MDBParameter("HB_CLS_STTB", BenhAnNgoaiTruPemphigoid.HB_CLS_STTB));
            Command.Parameters.Add(new MDB.MDBParameter("HB_CLS_XetNghiemTB", BenhAnNgoaiTruPemphigoid.HB_CLS_XetNghiemTB));
            Command.Parameters.Add(new MDB.MDBParameter("HB_CLS_MienDichTT", BenhAnNgoaiTruPemphigoid.HB_CLS_MienDichTT));
            Command.Parameters.Add(new MDB.MDBParameter("HB_CLS_MienDichGT", BenhAnNgoaiTruPemphigoid.HB_CLS_MienDichGT));
            Command.Parameters.Add(new MDB.MDBParameter("HB_CLS_SinhThietDa", BenhAnNgoaiTruPemphigoid.HB_CLS_SinhThietDa));
            Command.Parameters.Add(new MDB.MDBParameter("HB_CacXetNghiemKhac", BenhAnNgoaiTruPemphigoid.HB_CacXetNghiemKhac));
            Command.Parameters.Add(new MDB.MDBParameter("HB_ChanDoan", BenhAnNgoaiTruPemphigoid.HB_ChanDoan));
            Command.Parameters.Add(new MDB.MDBParameter("HB_DieuTri", BenhAnNgoaiTruPemphigoid.HB_DieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("NgayTaiKham", BenhAnNgoaiTruPemphigoid.NgayTaiKham));
            Command.Parameters.Add(new MDB.MDBParameter("KB_Mach", BenhAnNgoaiTruPemphigoid.KB_Mach));
            Command.Parameters.Add(new MDB.MDBParameter("KB_LS_DaNiemMac", BenhAnNgoaiTruPemphigoid.KB_LS_DaNiemMac));
            Command.Parameters.Add(new MDB.MDBParameter("KB_Than", BenhAnNgoaiTruPemphigoid.KB_Than));
            Command.Parameters.Add(new MDB.MDBParameter("KB_Phoi", BenhAnNgoaiTruPemphigoid.KB_Phoi));
            Command.Parameters.Add(new MDB.MDBParameter("KB_TieuHoa", BenhAnNgoaiTruPemphigoid.KB_TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("KB_Tim", BenhAnNgoaiTruPemphigoid.KB_Tim));
            Command.Parameters.Add(new MDB.MDBParameter("KB_ThanKinh", BenhAnNgoaiTruPemphigoid.KB_ThanKinh));
            Command.Parameters.Add(new MDB.MDBParameter("KB_CoXuongKhop", BenhAnNgoaiTruPemphigoid.KB_CoXuongKhop));
            Command.Parameters.Add(new MDB.MDBParameter("KB_CoQuanKhac", BenhAnNgoaiTruPemphigoid.KB_CoQuanKhac));
            Command.Parameters.Add(new MDB.MDBParameter("KB_CanLamSang", BenhAnNgoaiTruPemphigoid.KB_CanLamSang));
            Command.Parameters.Add(new MDB.MDBParameter("KB_TacDungPhu", BenhAnNgoaiTruPemphigoid.KB_TacDungPhu));
            Command.Parameters.Add(new MDB.MDBParameter("KB_HuongDieuTri", BenhAnNgoaiTruPemphigoid.KB_HuongDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("KB_NgayTaiKham", BenhAnNgoaiTruPemphigoid.KB_NgayTaiKham));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnNgoaiTruPemphigoid.HuongDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangRaVien", BenhAnNgoaiTruPemphigoid.TinhTrangRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnNgoaiTruPemphigoid.PhuongPhapDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("MaBenhKemTheo", BenhAnNgoaiTruPemphigoid.MaBenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnNgoaiTruPemphigoid.BenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnNgoaiTruPemphigoid.BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("MaBenhChinh", BenhAnNgoaiTruPemphigoid.MaBenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQua", BenhAnNgoaiTruPemphigoid.TomTatKetQua));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnNgoaiTruPemphigoid.QuaTrinhBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("DieuTriNgoaiTruTu", BenhAnNgoaiTruPemphigoid.DieuTriNgoaiTruTu));
            Command.Parameters.Add(new MDB.MDBParameter("DieuTriNgoaiTruDen", BenhAnNgoaiTruPemphigoid.DieuTriNgoaiTruDen));
            Command.Parameters.Add(new MDB.MDBParameter("SoCMND", BenhAnNgoaiTruPemphigoid.SoCMND));
            Command.Parameters.Add(new MDB.MDBParameter("BaoHiem", BenhAnNgoaiTruPemphigoid.BaoHiem));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoan_TuyenTruoc", BenhAnNgoaiTruPemphigoid.ChanDoan_TuyenTruoc));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanBanDau", BenhAnNgoaiTruPemphigoid.ChanDoanBanDau));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham1", BenhAnNgoaiTruPemphigoid.ChanDoanTaiKham1));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham2", BenhAnNgoaiTruPemphigoid.ChanDoanTaiKham2));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham3", BenhAnNgoaiTruPemphigoid.ChanDoanTaiKham3));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham4", BenhAnNgoaiTruPemphigoid.ChanDoanTaiKham4));
            Command.Parameters.Add(new MDB.MDBParameter("BenhPhu", BenhAnNgoaiTruPemphigoid.BenhPhu));
            Command.Parameters.Add(new MDB.MDBParameter("KetQuaDieuTri", BenhAnNgoaiTruPemphigoid.KetQuaDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("BienChung_Text", BenhAnNgoaiTruPemphigoid.BienChung_Text));
            Command.Parameters.Add(new MDB.MDBParameter("GDPhongKeHoach", BenhAnNgoaiTruPemphigoid.GDPhongKeHoach));
            Command.Parameters.Add(new MDB.MDBParameter("GDPhongKhamBenh", BenhAnNgoaiTruPemphigoid.GDPhongKhamBenh));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnNgoaiTruPemphigoid.NguoiNhanHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnNgoaiTruPemphigoid.NguoiGiaoHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnNgoaiTruPemphigoid.NgayTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("TongKet_BacSyDieuTri", BenhAnNgoaiTruPemphigoid.TongKet_BacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("TongKet_MaBacSyDieuTri", BenhAnNgoaiTruPemphigoid.TongKet_MaBacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnNgoaiTruPemphigoid.BacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyKhamBenh", BenhAnNgoaiTruPemphigoid.BacSyKhamBenh));

            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnNgoaiTruPemphigoid.MaQuanLy));
            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool Delete(MDB.MDBConnection MyConnection, BenhAnNgoaiTruPemphigoid BenhAnNgoaiTruPemphigoid)
        {
            string sql = @"DELETE FROM BENHANNTPEMPHIGOID 
                           WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnNgoaiTruPemphigoid.MaQuanLy));

            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
    }
}
