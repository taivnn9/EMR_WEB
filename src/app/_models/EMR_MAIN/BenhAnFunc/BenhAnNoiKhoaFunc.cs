
using System;
using System.Data;

namespace EMR_MAIN
{
    public class BenhAnNoiKhoaFunc
    {
        public static void WriteXml(MDB.MDBConnection MyConnection)
        {
            string sql =
                   @"
                  select  a.*,  CTScanner HoSo_CTScanner, SieuAm HoSo_SieuAm, XetNghiem HoSo_XetNghiem,  Khac HoSo_Khac,  Khac_Text HoSo_Khac_Text,  ToanBoHoSo HoSo_ToanBoHoSo, Mach DauSinhTon_Mach,  NhietDo DauSinhTon_NhietDo,  HuyetAp DauSinhTon_HuyetAp,  NhipTho DauSinhTon_NhipTho,  CanNang DauSinhTon_CanNang  
                  from BenhAnNoiKhoa a inner join thongtindieutri b on a.maquanly = b.maquanly
                  where rownum = 1
                    ";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            var DataTable = new DataTable { TableName = "BenhAnNoiKhoa" };
            DataTable.Load(DataReader as IDataReader);
            DataTable.WriteXml("rptBenhAnNoiKhoa.xml");
        }
        public static DataSet SelectDataSet(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql =
                   @"
                   select  a.*,f.hovaten BacSyLamBenhAnHoVaTen ,c.hovaten BacSyDieuTriHoVaTen,d.hovaten NguoiGiaoHoSoHoVaTen,e.hovaten NguoiNhanHoSoHoVaTen, b.XQuang HoSo_XQuang,   b.CTScanner HoSo_CTScanner, b.SieuAm HoSo_SieuAm, b.XetNghiem HoSo_XetNghiem,  b.Khac HoSo_Khac,  b.Khac_Text HoSo_Khac_Text,  b.ToanBoHoSo HoSo_ToanBoHoSo, b.Mach DauSinhTon_Mach, b.NhietDo DauSinhTon_NhietDo,  b.HuyetAp DauSinhTon_HuyetAp,  b.NhipTho DauSinhTon_NhipTho,  b.CanNang DauSinhTon_CanNang  , b.ChieuCao DauSinhTon_ChieuCao, b.BMI DauSinhTon_BMI, b.BMI DauSinhTon_BMI, b.NgayRaVien 
                 from BenhAnNoiKhoa a 
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
        public static BenhAnNoiKhoa Select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            #region
            string sql =
                      @"select * 
                        from BenhAnNoiKhoa a
                        where MaQuanLy = :MaQuanLy";
            #endregion
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            var value = new BenhAnNoiKhoa();
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
                value.MaSoKyTen = DataReader["masokyten"].ToString();
                value.MaSoKyTen_KB = DataReader["masokyten_kb"].ToString();
                value.MaSoKyTen_TK = DataReader["masokyten_tk"].ToString();
                value.DauSinhTon = new DauSinhTon();
            }
            return value;
        }

        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, BenhAnNoiKhoa BenhAnNoiKhoa)
        {
            try
            {
                string sql =
                          @"select MaQuanLy 
                        from BenhAnNoiKhoa
                        where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnNoiKhoa.MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                int rowCount = 0;
                while (DataReader.Read()) rowCount++;
                if (rowCount == 1) return Update(MyConnection, BenhAnNoiKhoa);
                sql = @"
                   INSERT INTO BenhAnNoiKhoa (MaQuanLy, LyDoVaoVien, VaoNgayThu, QuaTrinhBenhLy, TienSuBenhBanThan, TienSuBenhGiaDinh, ToanThan, TuanHoan, HoHap, TieuHoa, ThanTietNieuSinhDuc, ThanKinh, CoXuongKhop, TaiMuiHong, RangHamMat, Mat, Khac_CacCoQuan, CacXetNghiemCanLamSangCanLam, TomTatBenhAn, BenhChinh, BenhKemTheo, PhanBiet, TienLuong, HuongDieuTri, NgayKhamBenh, BacSyLamBenhAn, QuaTrinhBenhLyVaDienBien, TomTatKetQuaXetNghiem, PhuongPhapDieuTri, TinhTrangNguoiBenhRaVien, HuongDieuTriVaCacCheDoTiepTheo, NguoiNhanHoSo, NguoiGiaoHoSo, NgayTongKet, BacSyDieuTri, DiUng, DiUng_Text, MaTuy, MaTuy_Text, RuouBia, RuouBia_Text, ThuocLa, ThuocLa_Text, ThuocLao, ThuocLao_Text, Khac_DacDiemLienQuanBenh, Khac_DacDiemLienQuanBenh_Text, DaiThaoDuong, DaiThaoDuong_Text, CaoHuyetAp, CaoHuyetAp_Text, RoiLoanMoMau, RoiLoanMoMau_Text, YeuToGiaDinh, YeuToGiaDinh_Text)
                   VALUES(:MaQuanLy, :LyDoVaoVien, :VaoNgayThu, :QuaTrinhBenhLy, :TienSuBenhBanThan, :TienSuBenhGiaDinh, :ToanThan, :TuanHoan, :HoHap, :TieuHoa, :ThanTietNieuSinhDuc, :ThanKinh, :CoXuongKhop, :TaiMuiHong, :RangHamMat, :Mat, :Khac_CacCoQuan, :CacXetNghiemCanLamSangCanLam, :TomTatBenhAn, :BenhChinh, :BenhKemTheo, :PhanBiet, :TienLuong, :HuongDieuTri, :NgayKhamBenh, :BacSyLamBenhAn, :QuaTrinhBenhLyVaDienBien, :TomTatKetQuaXetNghiem, :PhuongPhapDieuTri, :TinhTrangNguoiBenhRaVien, :HuongDieuTriVaCacCheDoTiepTheo, :NguoiNhanHoSo, :NguoiGiaoHoSo, :NgayTongKet, :BacSyDieuTri, :DiUng, :DiUng_Text, :MaTuy, :MaTuy_Text, :RuouBia, :RuouBia_Text, :ThuocLa, :ThuocLa_Text, :ThuocLao, :ThuocLao_Text, :Khac_DacDiemLienQuanBenh, :Khac_DacDiemLienQuanBenh_Text, :DaiThaoDuong, :DaiThaoDuong_Text, :CaoHuyetAp, :CaoHuyetAp_Text, :RoiLoanMoMau, :RoiLoanMoMau_Text, :YeuToGiaDinh, :YeuToGiaDinh_Text)
                   ";
                Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnNoiKhoa.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnNoiKhoa.LyDoVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("VaoNgayThu", BenhAnNoiKhoa.VaoNgayThu));
                Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnNoiKhoa.QuaTrinhBenhLy));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhBanThan", BenhAnNoiKhoa.TienSuBenhBanThan));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhGiaDinh", BenhAnNoiKhoa.TienSuBenhGiaDinh));
                Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnNoiKhoa.ToanThan));
                Command.Parameters.Add(new MDB.MDBParameter("TuanHoan", BenhAnNoiKhoa.TuanHoan));
                Command.Parameters.Add(new MDB.MDBParameter("HoHap", BenhAnNoiKhoa.HoHap));
                Command.Parameters.Add(new MDB.MDBParameter("TieuHoa", BenhAnNoiKhoa.TieuHoa));
                Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieuSinhDuc", BenhAnNoiKhoa.ThanTietNieuSinhDuc));
                Command.Parameters.Add(new MDB.MDBParameter("ThanKinh", BenhAnNoiKhoa.ThanKinh));
                Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop", BenhAnNoiKhoa.CoXuongKhop));
                Command.Parameters.Add(new MDB.MDBParameter("TaiMuiHong", BenhAnNoiKhoa.TaiMuiHong));
                Command.Parameters.Add(new MDB.MDBParameter("RangHamMat", BenhAnNoiKhoa.RangHamMat));
                Command.Parameters.Add(new MDB.MDBParameter("Mat", BenhAnNoiKhoa.Mat));
                Command.Parameters.Add(new MDB.MDBParameter("Khac_CacCoQuan", BenhAnNoiKhoa.Khac_CacCoQuan));
                Command.Parameters.Add(new MDB.MDBParameter("CacXetNghiemCanLamSangCanLam", BenhAnNoiKhoa.CacXetNghiemCanLamSangCanLam));
                Command.Parameters.Add(new MDB.MDBParameter("TomTatBenhAn", BenhAnNoiKhoa.TomTatBenhAn));
                Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnNoiKhoa.BenhChinh));
                Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnNoiKhoa.BenhKemTheo));
                Command.Parameters.Add(new MDB.MDBParameter("PhanBiet", BenhAnNoiKhoa.PhanBiet));
                Command.Parameters.Add(new MDB.MDBParameter("TienLuong", BenhAnNoiKhoa.TienLuong));
                Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnNoiKhoa.HuongDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("NgayKhamBenh", BenhAnNoiKhoa.NgayKhamBenh));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyLamBenhAn", BenhAnNoiKhoa.BacSyLamBenhAn));
                Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLyVaDienBien", BenhAnNoiKhoa.QuaTrinhBenhLyVaDienBien));
                Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQuaXetNghiem", BenhAnNoiKhoa.TomTatKetQuaXetNghiem));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnNoiKhoa.PhuongPhapDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangNguoiBenhRaVien", BenhAnNoiKhoa.TinhTrangNguoiBenhRaVien));
                Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriVaCacCheDoTiepTheo", BenhAnNoiKhoa.HuongDieuTriVaCacCheDoTiepTheo));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnNoiKhoa.NguoiNhanHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnNoiKhoa.NguoiGiaoHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnNoiKhoa.NgayTongKet));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnNoiKhoa.BacSyDieuTri));
                if (BenhAnNoiKhoa.DacDiemLienQuanBenh != null)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("DiUng", BenhAnNoiKhoa.DacDiemLienQuanBenh.DiUng == true ? "1" : "0"));
                    Command.Parameters.Add(new MDB.MDBParameter("DiUng_Text", BenhAnNoiKhoa.DacDiemLienQuanBenh.DiUng_Text));
                    Command.Parameters.Add(new MDB.MDBParameter("MaTuy", BenhAnNoiKhoa.DacDiemLienQuanBenh.MaTuy == true ? "1" : "0"));
                    Command.Parameters.Add(new MDB.MDBParameter("MaTuy_Text", BenhAnNoiKhoa.DacDiemLienQuanBenh.MaTuy_Text));
                    Command.Parameters.Add(new MDB.MDBParameter("RuouBia", BenhAnNoiKhoa.DacDiemLienQuanBenh.RuouBia == true ? "1" : "0"));
                    Command.Parameters.Add(new MDB.MDBParameter("RuouBia_Text", BenhAnNoiKhoa.DacDiemLienQuanBenh.RuouBia_Text));
                    Command.Parameters.Add(new MDB.MDBParameter("ThuocLa", BenhAnNoiKhoa.DacDiemLienQuanBenh.ThuocLa == true ? "1" : "0"));
                    Command.Parameters.Add(new MDB.MDBParameter("ThuocLa_Text", BenhAnNoiKhoa.DacDiemLienQuanBenh.ThuocLa_Text));
                    Command.Parameters.Add(new MDB.MDBParameter("ThuocLao", BenhAnNoiKhoa.DacDiemLienQuanBenh.ThuocLao == true ? "1" : "0"));
                    Command.Parameters.Add(new MDB.MDBParameter("ThuocLao_Text", BenhAnNoiKhoa.DacDiemLienQuanBenh.ThuocLao_Text));
                    Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh", BenhAnNoiKhoa.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh == true ? "1" : "0"));
                    Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh_Text", BenhAnNoiKhoa.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh_Text));
                    Command.Parameters.Add(new MDB.MDBParameter("DaiThaoDuong", BenhAnNoiKhoa.DacDiemLienQuanBenh.DaiThaoDuong == true ? "1" : "0"));
                    Command.Parameters.Add(new MDB.MDBParameter("DaiThaoDuong_Text", BenhAnNoiKhoa.DacDiemLienQuanBenh.DaiThaoDuong_Text));
                    Command.Parameters.Add(new MDB.MDBParameter("CaoHuyetAp", BenhAnNoiKhoa.DacDiemLienQuanBenh.CaoHuyetAp == true ? "1" : "0"));
                    Command.Parameters.Add(new MDB.MDBParameter("CaoHuyetAp_Text", BenhAnNoiKhoa.DacDiemLienQuanBenh.CaoHuyetAp_Text));
                    Command.Parameters.Add(new MDB.MDBParameter("RoiLoanMoMau", BenhAnNoiKhoa.DacDiemLienQuanBenh.RoiLoanMoMau == true ? "1" : "0"));
                    Command.Parameters.Add(new MDB.MDBParameter("RoiLoanMoMau_Text", BenhAnNoiKhoa.DacDiemLienQuanBenh.RoiLoanMoMau_Text));
                    Command.Parameters.Add(new MDB.MDBParameter("YeuToGiaDinh", BenhAnNoiKhoa.DacDiemLienQuanBenh.YeuToGiaDinh == true ? "1" : "0"));
                    Command.Parameters.Add(new MDB.MDBParameter("YeuToGiaDinh_Text", BenhAnNoiKhoa.DacDiemLienQuanBenh.YeuToGiaDinh_Text));

                }
                else
                {
                    Command.Parameters.Add(new MDB.MDBParameter("DiUng", "0"));
                    Command.Parameters.Add(new MDB.MDBParameter("DiUng_Text", ""));
                    Command.Parameters.Add(new MDB.MDBParameter("MaTuy", "0"));
                    Command.Parameters.Add(new MDB.MDBParameter("MaTuy_Text", ""));
                    Command.Parameters.Add(new MDB.MDBParameter("RuouBia", "0"));
                    Command.Parameters.Add(new MDB.MDBParameter("RuouBia_Text", ""));
                    Command.Parameters.Add(new MDB.MDBParameter("ThuocLa", "0"));
                    Command.Parameters.Add(new MDB.MDBParameter("ThuocLa_Text", ""));
                    Command.Parameters.Add(new MDB.MDBParameter("ThuocLao", "0"));
                    Command.Parameters.Add(new MDB.MDBParameter("ThuocLao_Text", ""));
                    Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh", "0"));
                    Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh_Text", ""));
                    Command.Parameters.Add(new MDB.MDBParameter("DaiThaoDuong", "0"));
                    Command.Parameters.Add(new MDB.MDBParameter("DaiThaoDuong_Text", ""));
                    Command.Parameters.Add(new MDB.MDBParameter("CaoHuyetAp", "0"));
                    Command.Parameters.Add(new MDB.MDBParameter("CaoHuyetAp_Text", ""));
                    Command.Parameters.Add(new MDB.MDBParameter("RoiLoanMoMau", "0"));
                    Command.Parameters.Add(new MDB.MDBParameter("RoiLoanMoMau_Text", ""));
                    Command.Parameters.Add(new MDB.MDBParameter("YeuToGiaDinh", "0"));
                    Command.Parameters.Add(new MDB.MDBParameter("YeuToGiaDinh_Text", ""));
                }


                int n = Command.ExecuteNonQuery(); // C#
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
                return false;
            }
        }
        public static bool Update(MDB.MDBConnection MyConnection, BenhAnNoiKhoa BenhAnNoiKhoa)
        {
            try
            {
                string sql = @"UPDATE BenhAnNoiKhoa SET 
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
                        DaiThaoDuong = :DaiThaoDuong, 
                        DaiThaoDuong_Text = :DaiThaoDuong_Text,
                        CaoHuyetAp = :CaoHuyetAp,
                        CaoHuyetAp_Text = :CaoHuyetAp_Text,
                        RoiLoanMoMau = :RoiLoanMoMau,
                        RoiLoanMoMau_Text = :RoiLoanMoMau_Text,
                        YeuToGiaDinh = :YeuToGiaDinh,
                        YeuToGiaDinh_Text = :YeuToGiaDinh_Text  
                        WHERE MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnNoiKhoa.LyDoVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("VaoNgayThu", BenhAnNoiKhoa.VaoNgayThu));
                Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnNoiKhoa.QuaTrinhBenhLy));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhBanThan", BenhAnNoiKhoa.TienSuBenhBanThan));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhGiaDinh", BenhAnNoiKhoa.TienSuBenhGiaDinh));
                Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnNoiKhoa.ToanThan));
                Command.Parameters.Add(new MDB.MDBParameter("TuanHoan", BenhAnNoiKhoa.TuanHoan));
                Command.Parameters.Add(new MDB.MDBParameter("HoHap", BenhAnNoiKhoa.HoHap));
                Command.Parameters.Add(new MDB.MDBParameter("TieuHoa", BenhAnNoiKhoa.TieuHoa));
                Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieuSinhDuc", BenhAnNoiKhoa.ThanTietNieuSinhDuc));
                Command.Parameters.Add(new MDB.MDBParameter("ThanKinh", BenhAnNoiKhoa.ThanKinh));
                Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop", BenhAnNoiKhoa.CoXuongKhop));
                Command.Parameters.Add(new MDB.MDBParameter("TaiMuiHong", BenhAnNoiKhoa.TaiMuiHong));
                Command.Parameters.Add(new MDB.MDBParameter("RangHamMat", BenhAnNoiKhoa.RangHamMat));
                Command.Parameters.Add(new MDB.MDBParameter("Mat", BenhAnNoiKhoa.Mat));
                Command.Parameters.Add(new MDB.MDBParameter("Khac_CacCoQuan", BenhAnNoiKhoa.Khac_CacCoQuan));
                Command.Parameters.Add(new MDB.MDBParameter("CacXetNghiemCanLamSangCanLam", BenhAnNoiKhoa.CacXetNghiemCanLamSangCanLam));
                Command.Parameters.Add(new MDB.MDBParameter("TomTatBenhAn", BenhAnNoiKhoa.TomTatBenhAn));
                Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnNoiKhoa.BenhChinh));
                Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnNoiKhoa.BenhKemTheo));
                Command.Parameters.Add(new MDB.MDBParameter("PhanBiet", BenhAnNoiKhoa.PhanBiet));
                Command.Parameters.Add(new MDB.MDBParameter("TienLuong", BenhAnNoiKhoa.TienLuong));
                Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnNoiKhoa.HuongDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("NgayKhamBenh", BenhAnNoiKhoa.NgayKhamBenh));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyLamBenhAn", BenhAnNoiKhoa.BacSyLamBenhAn));
                Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLyVaDienBien", BenhAnNoiKhoa.QuaTrinhBenhLyVaDienBien));
                Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQuaXetNghiem", BenhAnNoiKhoa.TomTatKetQuaXetNghiem));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnNoiKhoa.PhuongPhapDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangNguoiBenhRaVien", BenhAnNoiKhoa.TinhTrangNguoiBenhRaVien));
                Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriVaCacCheDoTiepTheo", BenhAnNoiKhoa.HuongDieuTriVaCacCheDoTiepTheo));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnNoiKhoa.NguoiNhanHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnNoiKhoa.NguoiGiaoHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnNoiKhoa.NgayTongKet));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnNoiKhoa.BacSyDieuTri));
                if (BenhAnNoiKhoa.DacDiemLienQuanBenh != null)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("DiUng",BenhAnNoiKhoa.DacDiemLienQuanBenh.DiUng == true ? "1" : "0"));
                    Command.Parameters.Add(new MDB.MDBParameter("DiUng_Text", BenhAnNoiKhoa.DacDiemLienQuanBenh.DiUng_Text));
                    Command.Parameters.Add(new MDB.MDBParameter("MaTuy", BenhAnNoiKhoa.DacDiemLienQuanBenh.MaTuy == true ? "1" : "0"));
                    Command.Parameters.Add(new MDB.MDBParameter("MaTuy_Text", BenhAnNoiKhoa.DacDiemLienQuanBenh.MaTuy_Text));
                    Command.Parameters.Add(new MDB.MDBParameter("RuouBia", BenhAnNoiKhoa.DacDiemLienQuanBenh.RuouBia == true ? "1" : "0"));
                    Command.Parameters.Add(new MDB.MDBParameter("RuouBia_Text", BenhAnNoiKhoa.DacDiemLienQuanBenh.RuouBia_Text));
                    Command.Parameters.Add(new MDB.MDBParameter("ThuocLa", BenhAnNoiKhoa.DacDiemLienQuanBenh.ThuocLa == true ? "1" : "0"));
                    Command.Parameters.Add(new MDB.MDBParameter("ThuocLa_Text", BenhAnNoiKhoa.DacDiemLienQuanBenh.ThuocLa_Text));
                    Command.Parameters.Add(new MDB.MDBParameter("ThuocLao", BenhAnNoiKhoa.DacDiemLienQuanBenh.ThuocLao == true ? "1" : "0"));
                    Command.Parameters.Add(new MDB.MDBParameter("ThuocLao_Text", BenhAnNoiKhoa.DacDiemLienQuanBenh.ThuocLao_Text));
                    Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh", BenhAnNoiKhoa.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh == true ? "1" : "0"));
                    Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh_Text", BenhAnNoiKhoa.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh_Text));
                    Command.Parameters.Add(new MDB.MDBParameter("DaiThaoDuong", BenhAnNoiKhoa.DacDiemLienQuanBenh.DaiThaoDuong == true ? "1" : "0"));
                    Command.Parameters.Add(new MDB.MDBParameter("DaiThaoDuong_Text", BenhAnNoiKhoa.DacDiemLienQuanBenh.DaiThaoDuong_Text));
                    Command.Parameters.Add(new MDB.MDBParameter("CaoHuyetAp", BenhAnNoiKhoa.DacDiemLienQuanBenh.CaoHuyetAp == true ? "1" : "0"));
                    Command.Parameters.Add(new MDB.MDBParameter("CaoHuyetAp_Text", BenhAnNoiKhoa.DacDiemLienQuanBenh.CaoHuyetAp_Text));
                    Command.Parameters.Add(new MDB.MDBParameter("RoiLoanMoMau", BenhAnNoiKhoa.DacDiemLienQuanBenh.RoiLoanMoMau == true ? "1" : "0"));
                    Command.Parameters.Add(new MDB.MDBParameter("RoiLoanMoMau_Text", BenhAnNoiKhoa.DacDiemLienQuanBenh.RoiLoanMoMau_Text));
                    Command.Parameters.Add(new MDB.MDBParameter("YeuToGiaDinh", BenhAnNoiKhoa.DacDiemLienQuanBenh.YeuToGiaDinh == true ? "1" : "0"));
                    Command.Parameters.Add(new MDB.MDBParameter("YeuToGiaDinh_Text", BenhAnNoiKhoa.DacDiemLienQuanBenh.YeuToGiaDinh_Text));

                }
                else
                {
                    Command.Parameters.Add(new MDB.MDBParameter("DiUng", "0"));
                    Command.Parameters.Add(new MDB.MDBParameter("DiUng_Text", ""));
                    Command.Parameters.Add(new MDB.MDBParameter("MaTuy", "0"));
                    Command.Parameters.Add(new MDB.MDBParameter("MaTuy_Text", ""));
                    Command.Parameters.Add(new MDB.MDBParameter("RuouBia", "0"));
                    Command.Parameters.Add(new MDB.MDBParameter("RuouBia_Text", ""));
                    Command.Parameters.Add(new MDB.MDBParameter("ThuocLa", "0"));
                    Command.Parameters.Add(new MDB.MDBParameter("ThuocLa_Text", ""));
                    Command.Parameters.Add(new MDB.MDBParameter("ThuocLao", "0"));
                    Command.Parameters.Add(new MDB.MDBParameter("ThuocLao_Text", ""));
                    Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh", "0"));
                    Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh_Text", ""));
                    Command.Parameters.Add(new MDB.MDBParameter("DaiThaoDuong", "0"));
                    Command.Parameters.Add(new MDB.MDBParameter("DaiThaoDuong_Text", ""));
                    Command.Parameters.Add(new MDB.MDBParameter("CaoHuyetAp", "0"));
                    Command.Parameters.Add(new MDB.MDBParameter("CaoHuyetAp_Text", ""));
                    Command.Parameters.Add(new MDB.MDBParameter("RoiLoanMoMau", "0"));
                    Command.Parameters.Add(new MDB.MDBParameter("RoiLoanMoMau_Text", ""));
                    Command.Parameters.Add(new MDB.MDBParameter("YeuToGiaDinh", "0"));
                    Command.Parameters.Add(new MDB.MDBParameter("YeuToGiaDinh_Text", ""));
                }

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnNoiKhoa.MaQuanLy));
                int n = Command.ExecuteNonQuery(); // C#
                return n > 0 ? true : false;
            } catch(Exception ex)
            {
                XuLyLoi.Handle(ex);
                return false;
            }
           
        }
        public static bool Delete(MDB.MDBConnection MyConnection, BenhAnNoiKhoa BenhAnNoiKhoa)
        {
            string sql = @"DELETE FROM BenhAnNoiKhoa 
                           WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnNoiKhoa.MaQuanLy));

            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
    }
}
