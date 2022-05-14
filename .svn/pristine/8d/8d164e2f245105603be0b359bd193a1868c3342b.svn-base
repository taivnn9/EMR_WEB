
using System;
using System.Data;

namespace EMR_MAIN
{
    public class BenhAnPhuKhoaFunc
    {
        public static void WriteXml(MDB.MDBConnection MyConnection)
        {
            string sql =
                   @"
                  select  a.*,  CTScanner HoSo_CTScanner, SieuAm HoSo_SieuAm, XetNghiem HoSo_XetNghiem,  Khac HoSo_Khac,  Khac_Text HoSo_Khac_Text,  ToanBoHoSo HoSo_ToanBoHoSo, Mach DauSinhTon_Mach,  NhietDo DauSinhTon_NhietDo,  HuyetAp DauSinhTon_HuyetAp,  NhipTho DauSinhTon_NhipTho,  CanNang DauSinhTon_CanNang  
                  from BenhAnPhuKhoa a inner join thongtindieutri b on a.maquanly = b.maquanly
                  where rownum = 1
                    ";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            var DataTable = new DataTable { TableName = "BenhAnPhuKhoa" };
            DataTable.Load(DataReader as IDataReader);
            DataTable.WriteXml("rptBenhAnPhuKhoa.xml");
        }
        public static DataSet SelectDataSet(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql =
                  @"
                   select  a.*,f.hovaten BacSyLamBenhAnHoVaTen ,c.hovaten BacSyDieuTriHoVaTen,d.hovaten NguoiGiaoHoSoHoVaTen,e.hovaten NguoiNhanHoSoHoVaTen, b.XQuang HoSo_XQuang,   b.CTScanner HoSo_CTScanner, b.SieuAm HoSo_SieuAm, b.XetNghiem HoSo_XetNghiem,  b.Khac HoSo_Khac,  b.Khac_Text HoSo_Khac_Text,  b.ToanBoHoSo HoSo_ToanBoHoSo, b.Mach DauSinhTon_Mach, b.NhietDo DauSinhTon_NhietDo,  b.HuyetAp DauSinhTon_HuyetAp,  b.NhipTho DauSinhTon_NhipTho,  b.CanNang DauSinhTon_CanNang  , b.ChieuCao DauSinhTon_ChieuCao, b.BMI DauSinhTon_BMI, b.NgayRaVien 
                 from BenhAnPhuKhoa a 
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
        public static BenhAnPhuKhoa Select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            #region
            string sql =
                      @"select * 
                        from BenhAnPhuKhoa a
                        where MaQuanLy = :MaQuanLy";
            #endregion
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            var value = new BenhAnPhuKhoa();
            value.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
            value.TienSuSanPhuKhoa = new TienSuSanPhuKhoa();
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
                value.TienThaiPara = DataReader.GetInt("TienThaiPara");
                value.Hach = DataReader["Hach"].ToString();
                value.Vu = DataReader["Vu"].ToString();
                value.CacDauHieuSinhDucThuPhat = DataReader["CacDauHieuSinhDucThuPhat"].ToString();
                value.MoiLon = DataReader["MoiLon"].ToString();
                value.MoiBe = DataReader["MoiBe"].ToString();
                value.AmVat = DataReader["AmVat"].ToString();
                value.AmHo = DataReader["AmHo"].ToString();
                value.MangTrinh = DataReader["MangTrinh"].ToString();
                value.TangSinhMon = DataReader["TangSinhMon"].ToString();
                value.AmDao = DataReader["AmDao"].ToString();
                value.CoTuCung = DataReader["CoTuCung"].ToString();
                value.ThanTuCung = DataReader["ThanTuCung"].ToString();
                value.PhanPhu = DataReader["PhanPhu"].ToString();
                value.CacTuiCung = DataReader["CacTuiCung"].ToString();
                value.TienSuSanPhuKhoa.BatDauThayKinhNam = DataReader.GetInt("BatDauThayKinhNam");
                value.TienSuSanPhuKhoa.TuoiThayKinh = DataReader.GetInt("TuoiThayKinh");
                value.TienSuSanPhuKhoa.TinhChatKinhNguyet = DataReader["TinhChatKinhNguyet"].ToString();
                value.TienSuSanPhuKhoa.ChuKy = DataReader.GetInt("ChuKy");
                value.TienSuSanPhuKhoa.SoNgayThayKinh = DataReader.GetInt("SoNgayThayKinh");
                value.TienSuSanPhuKhoa.LuongKinh = DataReader["LuongKinh"].ToString();
                value.TienSuSanPhuKhoa.KinhLanCuoiNgay = DataReader.GetInt("KinhLanCuoiNgay");
                value.TienSuSanPhuKhoa.DauBung = DataReader["DauBung"].ToString() == "1" ? true : false;
                value.TienSuSanPhuKhoa.LayChongNam = DataReader.GetInt("LayChongNam");
                value.TienSuSanPhuKhoa.TuoiLayChong = DataReader.GetInt("TuoiLayChong");
                value.TienSuSanPhuKhoa.HetKinhNam = DataReader.GetInt("HetKinhNam");
                value.TienSuSanPhuKhoa.TuoiHetKinh = DataReader.GetInt("TuoiHetKinh");
                value.TienSuSanPhuKhoa.Truoc = DataReader["Truoc"].ToString() == "1" ? true : false;
                value.TienSuSanPhuKhoa.Sau = DataReader["Sau"].ToString() == "1" ? true : false;
                value.TienSuSanPhuKhoa.Trong = DataReader["Trong"].ToString() == "1" ? true : false;
                value.TienSuSanPhuKhoa.NhungBenhPhuKhoaDaDieuTri = DataReader["NhungBenhPhuKhoaDaDieuTri"].ToString();
                value.ThuThuat = DataReader["ThuThuat"].ToString() == "1" ? true : false;
                value.PhauThuat = DataReader["PhauThuat"].ToString() == "1" ? true : false;
                value.ChiSoPara1 = DataReader["ChiSoPara1"].ToString();
                value.ChiSoPara2 = DataReader["ChiSoPara2"].ToString();
                value.ChiSoPara3 = DataReader["ChiSoPara3"].ToString();
                value.ChiSoPara4 = DataReader["ChiSoPara4"].ToString();
                value.MaSoKyTen = DataReader["masokyten"].ToString();
                value.MaSoKyTen_KB = DataReader["masokyten_kb"].ToString();
                value.MaSoKyTen_TK = DataReader["masokyten_tk"].ToString();
            }
            return value;
        }

        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, BenhAnPhuKhoa BenhAnPhuKhoa)
        {
            try
            {
                string sql =
                      @"select MaQuanLy 
                        from BenhAnPhuKhoa
                        where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnPhuKhoa.MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                int rowCount = 0;
                while (DataReader.Read()) rowCount++;
                if (rowCount == 1) return Update(MyConnection, BenhAnPhuKhoa);
                sql = @"
                   INSERT INTO BenhAnPhuKhoa (MaQuanLy, LyDoVaoVien, VaoNgayThu, QuaTrinhBenhLy, TienSuBenhBanThan, TienSuBenhGiaDinh, ToanThan, TuanHoan, HoHap, TieuHoa, ThanTietNieuSinhDuc, ThanKinh, CoXuongKhop, TaiMuiHong, RangHamMat, Mat, Khac_CacCoQuan, CacXetNghiemCanLamSangCanLam, TomTatBenhAn, BenhChinh, BenhKemTheo, PhanBiet, TienLuong, HuongDieuTri, NgayKhamBenh, BacSyLamBenhAn, QuaTrinhBenhLyVaDienBien, TomTatKetQuaXetNghiem, PhuongPhapDieuTri, TinhTrangNguoiBenhRaVien, HuongDieuTriVaCacCheDoTiepTheo, NguoiNhanHoSo, NguoiGiaoHoSo, NgayTongKet, BacSyDieuTri, DiUng, DiUng_Text, MaTuy, MaTuy_Text, RuouBia, RuouBia_Text, ThuocLa, ThuocLa_Text, ThuocLao, ThuocLao_Text, Khac_DacDiemLienQuanBenh, Khac_DacDiemLienQuanBenh_Text, TienThaiPara, Hach, Vu, CacDauHieuSinhDucThuPhat, MoiLon, MoiBe, AmVat, AmHo, MangTrinh, TangSinhMon, AmDao, CoTuCung, ThanTuCung, PhanPhu, CacTuiCung, BatDauThayKinhNam, TuoiThayKinh, TinhChatKinhNguyet, ChuKy, SoNgayThayKinh, LuongKinh, KinhLanCuoiNgay, DauBung, LayChongNam, TuoiLayChong, HetKinhNam, TuoiHetKinh, Truoc, Sau, Trong, NhungBenhPhuKhoaDaDieuTri,ThuThuat, PhauThuat, ChiSoPara1, ChiSoPara2, ChiSoPara3, ChiSoPara4)
                   VALUES(:MaQuanLy, :LyDoVaoVien, :VaoNgayThu, :QuaTrinhBenhLy, :TienSuBenhBanThan, :TienSuBenhGiaDinh, :ToanThan, :TuanHoan, :HoHap, :TieuHoa, :ThanTietNieuSinhDuc, :ThanKinh, :CoXuongKhop, :TaiMuiHong, :RangHamMat, :Mat, :Khac_CacCoQuan, :CacXetNghiemCanLamSangCanLam, :TomTatBenhAn, :BenhChinh, :BenhKemTheo, :PhanBiet, :TienLuong, :HuongDieuTri, :NgayKhamBenh, :BacSyLamBenhAn, :QuaTrinhBenhLyVaDienBien, :TomTatKetQuaXetNghiem, :PhuongPhapDieuTri, :TinhTrangNguoiBenhRaVien, :HuongDieuTriVaCacCheDoTiepTheo, :NguoiNhanHoSo, :NguoiGiaoHoSo, :NgayTongKet, :BacSyDieuTri, :DiUng, :DiUng_Text, :MaTuy, :MaTuy_Text, :RuouBia, :RuouBia_Text, :ThuocLa, :ThuocLa_Text, :ThuocLao, :ThuocLao_Text, :Khac_DacDiemLienQuanBenh, :Khac_DacDiemLienQuanBenh_Text, :TienThaiPara, :Hach, :Vu, :CacDauHieuSinhDucThuPhat, :MoiLon, :MoiBe, :AmVat, :AmHo, :MangTrinh, :TangSinhMon, :AmDao, :CoTuCung, :ThanTuCung, :PhanPhu, :CacTuiCung, :BatDauThayKinhNam, :TuoiThayKinh, :TinhChatKinhNguyet, :ChuKy, :SoNgayThayKinh, :LuongKinh, :KinhLanCuoiNgay, :DauBung, :LayChongNam, :TuoiLayChong, :HetKinhNam, :TuoiHetKinh, :Truoc, :Sau, :Trong, :NhungBenhPhuKhoaDaDieuTri,:ThuThuat, :PhauThuat, :ChiSoPara1, :ChiSoPara2, :ChiSoPara3, :ChiSoPara4)
                   ";
                Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnPhuKhoa.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnPhuKhoa.LyDoVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("VaoNgayThu", BenhAnPhuKhoa.VaoNgayThu));
                Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnPhuKhoa.QuaTrinhBenhLy));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhBanThan", BenhAnPhuKhoa.TienSuBenhBanThan));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhGiaDinh", BenhAnPhuKhoa.TienSuBenhGiaDinh));
                Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnPhuKhoa.ToanThan));
                Command.Parameters.Add(new MDB.MDBParameter("TuanHoan", BenhAnPhuKhoa.TuanHoan));
                Command.Parameters.Add(new MDB.MDBParameter("HoHap", BenhAnPhuKhoa.HoHap));
                Command.Parameters.Add(new MDB.MDBParameter("TieuHoa", BenhAnPhuKhoa.TieuHoa));
                Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieuSinhDuc", BenhAnPhuKhoa.ThanTietNieuSinhDuc));
                Command.Parameters.Add(new MDB.MDBParameter("ThanKinh", BenhAnPhuKhoa.ThanKinh));
                Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop", BenhAnPhuKhoa.CoXuongKhop));
                Command.Parameters.Add(new MDB.MDBParameter("TaiMuiHong", BenhAnPhuKhoa.TaiMuiHong));
                Command.Parameters.Add(new MDB.MDBParameter("RangHamMat", BenhAnPhuKhoa.RangHamMat));
                Command.Parameters.Add(new MDB.MDBParameter("Mat", BenhAnPhuKhoa.Mat));
                Command.Parameters.Add(new MDB.MDBParameter("Khac_CacCoQuan", BenhAnPhuKhoa.Khac_CacCoQuan));
                Command.Parameters.Add(new MDB.MDBParameter("CacXetNghiemCanLamSangCanLam", BenhAnPhuKhoa.CacXetNghiemCanLamSangCanLam));
                Command.Parameters.Add(new MDB.MDBParameter("TomTatBenhAn", BenhAnPhuKhoa.TomTatBenhAn));
                Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnPhuKhoa.BenhChinh));
                Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnPhuKhoa.BenhKemTheo));
                Command.Parameters.Add(new MDB.MDBParameter("PhanBiet", BenhAnPhuKhoa.PhanBiet));
                Command.Parameters.Add(new MDB.MDBParameter("TienLuong", BenhAnPhuKhoa.TienLuong));
                Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnPhuKhoa.HuongDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("NgayKhamBenh", BenhAnPhuKhoa.NgayKhamBenh));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyLamBenhAn", BenhAnPhuKhoa.BacSyLamBenhAn));
                Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLyVaDienBien", BenhAnPhuKhoa.QuaTrinhBenhLyVaDienBien));
                Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQuaXetNghiem", BenhAnPhuKhoa.TomTatKetQuaXetNghiem));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnPhuKhoa.PhuongPhapDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangNguoiBenhRaVien", BenhAnPhuKhoa.TinhTrangNguoiBenhRaVien));
                Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriVaCacCheDoTiepTheo", BenhAnPhuKhoa.HuongDieuTriVaCacCheDoTiepTheo));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnPhuKhoa.NguoiNhanHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnPhuKhoa.NguoiGiaoHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnPhuKhoa.NgayTongKet));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnPhuKhoa.BacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("DiUng", BenhAnPhuKhoa.DacDiemLienQuanBenh.DiUng == true ? "1" : "0"));
                Command.Parameters.Add(new MDB.MDBParameter("DiUng_Text", BenhAnPhuKhoa.DacDiemLienQuanBenh.DiUng_Text));
                Command.Parameters.Add(new MDB.MDBParameter("MaTuy", BenhAnPhuKhoa.DacDiemLienQuanBenh.MaTuy == true ? "1" : "0"));
                Command.Parameters.Add(new MDB.MDBParameter("MaTuy_Text", BenhAnPhuKhoa.DacDiemLienQuanBenh.MaTuy_Text));
                Command.Parameters.Add(new MDB.MDBParameter("RuouBia", BenhAnPhuKhoa.DacDiemLienQuanBenh.RuouBia == true ? "1" : "0"));
                Command.Parameters.Add(new MDB.MDBParameter("RuouBia_Text", BenhAnPhuKhoa.DacDiemLienQuanBenh.RuouBia_Text));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocLa", BenhAnPhuKhoa.DacDiemLienQuanBenh.ThuocLa == true ? "1" : "0"));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocLa_Text", BenhAnPhuKhoa.DacDiemLienQuanBenh.ThuocLa_Text));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocLao", BenhAnPhuKhoa.DacDiemLienQuanBenh.ThuocLao == true ? "1" : "0"));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocLao_Text", BenhAnPhuKhoa.DacDiemLienQuanBenh.ThuocLao_Text));
                Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh", BenhAnPhuKhoa.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh == true ? "1" : "0"));
                Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh_Text", BenhAnPhuKhoa.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh_Text));
                Command.Parameters.Add(new MDB.MDBParameter("TienThaiPara", BenhAnPhuKhoa.TienThaiPara));
                Command.Parameters.Add(new MDB.MDBParameter("Hach", BenhAnPhuKhoa.Hach));
                Command.Parameters.Add(new MDB.MDBParameter("Vu", BenhAnPhuKhoa.Vu));
                Command.Parameters.Add(new MDB.MDBParameter("CacDauHieuSinhDucThuPhat", BenhAnPhuKhoa.CacDauHieuSinhDucThuPhat));
                Command.Parameters.Add(new MDB.MDBParameter("MoiLon", BenhAnPhuKhoa.MoiLon));
                Command.Parameters.Add(new MDB.MDBParameter("MoiBe", BenhAnPhuKhoa.MoiBe));
                Command.Parameters.Add(new MDB.MDBParameter("AmVat", BenhAnPhuKhoa.AmVat));
                Command.Parameters.Add(new MDB.MDBParameter("AmHo", BenhAnPhuKhoa.AmHo));
                Command.Parameters.Add(new MDB.MDBParameter("MangTrinh", BenhAnPhuKhoa.MangTrinh));
                Command.Parameters.Add(new MDB.MDBParameter("TangSinhMon", BenhAnPhuKhoa.TangSinhMon));
                Command.Parameters.Add(new MDB.MDBParameter("AmDao", BenhAnPhuKhoa.AmDao));
                Command.Parameters.Add(new MDB.MDBParameter("CoTuCung", BenhAnPhuKhoa.CoTuCung));
                Command.Parameters.Add(new MDB.MDBParameter("ThanTuCung", BenhAnPhuKhoa.ThanTuCung));
                Command.Parameters.Add(new MDB.MDBParameter("PhanPhu", BenhAnPhuKhoa.PhanPhu));
                Command.Parameters.Add(new MDB.MDBParameter("CacTuiCung", BenhAnPhuKhoa.CacTuiCung));
                if (BenhAnPhuKhoa.TienSuSanPhuKhoa == null) BenhAnPhuKhoa.TienSuSanPhuKhoa = new TienSuSanPhuKhoa();
                Command.Parameters.Add(new MDB.MDBParameter("BatDauThayKinhNam", BenhAnPhuKhoa.TienSuSanPhuKhoa.BatDauThayKinhNam));
                Command.Parameters.Add(new MDB.MDBParameter("TuoiThayKinh", BenhAnPhuKhoa.TienSuSanPhuKhoa.TuoiThayKinh));
                Command.Parameters.Add(new MDB.MDBParameter("TinhChatKinhNguyet", BenhAnPhuKhoa.TienSuSanPhuKhoa.TinhChatKinhNguyet));
                Command.Parameters.Add(new MDB.MDBParameter("ChuKy", BenhAnPhuKhoa.TienSuSanPhuKhoa.ChuKy));
                Command.Parameters.Add(new MDB.MDBParameter("SoNgayThayKinh", BenhAnPhuKhoa.TienSuSanPhuKhoa.SoNgayThayKinh));
                Command.Parameters.Add(new MDB.MDBParameter("LuongKinh", BenhAnPhuKhoa.TienSuSanPhuKhoa.LuongKinh));
                Command.Parameters.Add(new MDB.MDBParameter("KinhLanCuoiNgay", BenhAnPhuKhoa.TienSuSanPhuKhoa.KinhLanCuoiNgay));
                Command.Parameters.Add(new MDB.MDBParameter("DauBung", BenhAnPhuKhoa.TienSuSanPhuKhoa.DauBung == true ? "1" : "0"));
                Command.Parameters.Add(new MDB.MDBParameter("LayChongNam", BenhAnPhuKhoa.TienSuSanPhuKhoa.LayChongNam));
                Command.Parameters.Add(new MDB.MDBParameter("TuoiLayChong", BenhAnPhuKhoa.TienSuSanPhuKhoa.TuoiLayChong));
                Command.Parameters.Add(new MDB.MDBParameter("HetKinhNam", BenhAnPhuKhoa.TienSuSanPhuKhoa.HetKinhNam));
                Command.Parameters.Add(new MDB.MDBParameter("TuoiHetKinh", BenhAnPhuKhoa.TienSuSanPhuKhoa.TuoiHetKinh));
                Command.Parameters.Add(new MDB.MDBParameter("Truoc", BenhAnPhuKhoa.TienSuSanPhuKhoa.Truoc == true ? "1" : "0"));
                Command.Parameters.Add(new MDB.MDBParameter("Sau", BenhAnPhuKhoa.TienSuSanPhuKhoa.Sau == true ? "1" : "0"));
                Command.Parameters.Add(new MDB.MDBParameter("Trong", BenhAnPhuKhoa.TienSuSanPhuKhoa.Trong == true ? "1" : "0"));
                Command.Parameters.Add(new MDB.MDBParameter("NhungBenhPhuKhoaDaDieuTri", BenhAnPhuKhoa.TienSuSanPhuKhoa.NhungBenhPhuKhoaDaDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("ThuThuat", BenhAnPhuKhoa.ThuThuat == true ? "1" : "0"));
                Command.Parameters.Add(new MDB.MDBParameter("PhauThuat", BenhAnPhuKhoa.PhauThuat == true ? "1" : "0"));
                Command.Parameters.Add(new MDB.MDBParameter("ChiSoPara1", BenhAnPhuKhoa.ChiSoPara1));
                Command.Parameters.Add(new MDB.MDBParameter("ChiSoPara2", BenhAnPhuKhoa.ChiSoPara2));
                Command.Parameters.Add(new MDB.MDBParameter("ChiSoPara3", BenhAnPhuKhoa.ChiSoPara3));
                Command.Parameters.Add(new MDB.MDBParameter("ChiSoPara4", BenhAnPhuKhoa.ChiSoPara4));

                int n = Command.ExecuteNonQuery(); // C#
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
                return false;
            }

        }
        public static bool Update(MDB.MDBConnection MyConnection, BenhAnPhuKhoa BenhAnPhuKhoa)
        {
            string sql = @"UPDATE BenhAnPhuKhoa SET 
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
TienThaiPara = :TienThaiPara,
Hach = :Hach,
Vu = :Vu,
CacDauHieuSinhDucThuPhat = :CacDauHieuSinhDucThuPhat,
MoiLon = :MoiLon,
MoiBe = :MoiBe,
AmVat = :AmVat,
AmHo = :AmHo,
MangTrinh = :MangTrinh,
TangSinhMon = :TangSinhMon,
AmDao = :AmDao,
CoTuCung = :CoTuCung,
ThanTuCung = :ThanTuCung,
PhanPhu = :PhanPhu,
CacTuiCung = :CacTuiCung,
BatDauThayKinhNam = :BatDauThayKinhNam,
TuoiThayKinh = :TuoiThayKinh,
TinhChatKinhNguyet = :TinhChatKinhNguyet,
ChuKy = :ChuKy,
SoNgayThayKinh = :SoNgayThayKinh,
LuongKinh = :LuongKinh,
KinhLanCuoiNgay = :KinhLanCuoiNgay,
DauBung = :DauBung,
LayChongNam = :LayChongNam,
TuoiLayChong = :TuoiLayChong,
HetKinhNam = :HetKinhNam,
TuoiHetKinh = :TuoiHetKinh,
Truoc = :Truoc,
Sau = :Sau,
Trong = :Trong,
NhungBenhPhuKhoaDaDieuTri = :NhungBenhPhuKhoaDaDieuTri,
ThuThuat = :ThuThuat,
PhauThuat = :PhauThuat,
ChiSoPara1 = :ChiSoPara1,
ChiSoPara2 = :ChiSoPara2,
ChiSoPara3 = :ChiSoPara3,
ChiSoPara4 = :ChiSoPara4
                        WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnPhuKhoa.LyDoVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("VaoNgayThu", BenhAnPhuKhoa.VaoNgayThu));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnPhuKhoa.QuaTrinhBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhBanThan", BenhAnPhuKhoa.TienSuBenhBanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhGiaDinh", BenhAnPhuKhoa.TienSuBenhGiaDinh));
            Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnPhuKhoa.ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoan", BenhAnPhuKhoa.TuanHoan));
            Command.Parameters.Add(new MDB.MDBParameter("HoHap", BenhAnPhuKhoa.HoHap));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoa", BenhAnPhuKhoa.TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieuSinhDuc", BenhAnPhuKhoa.ThanTietNieuSinhDuc));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinh", BenhAnPhuKhoa.ThanKinh));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop", BenhAnPhuKhoa.CoXuongKhop));
            Command.Parameters.Add(new MDB.MDBParameter("TaiMuiHong", BenhAnPhuKhoa.TaiMuiHong));
            Command.Parameters.Add(new MDB.MDBParameter("RangHamMat", BenhAnPhuKhoa.RangHamMat));
            Command.Parameters.Add(new MDB.MDBParameter("Mat", BenhAnPhuKhoa.Mat));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_CacCoQuan", BenhAnPhuKhoa.Khac_CacCoQuan));
            Command.Parameters.Add(new MDB.MDBParameter("CacXetNghiemCanLamSangCanLam", BenhAnPhuKhoa.CacXetNghiemCanLamSangCanLam));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatBenhAn", BenhAnPhuKhoa.TomTatBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnPhuKhoa.BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnPhuKhoa.BenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("PhanBiet", BenhAnPhuKhoa.PhanBiet));
            Command.Parameters.Add(new MDB.MDBParameter("TienLuong", BenhAnPhuKhoa.TienLuong));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnPhuKhoa.HuongDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("NgayKhamBenh", BenhAnPhuKhoa.NgayKhamBenh));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyLamBenhAn", BenhAnPhuKhoa.BacSyLamBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLyVaDienBien", BenhAnPhuKhoa.QuaTrinhBenhLyVaDienBien));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQuaXetNghiem", BenhAnPhuKhoa.TomTatKetQuaXetNghiem));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnPhuKhoa.PhuongPhapDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangNguoiBenhRaVien", BenhAnPhuKhoa.TinhTrangNguoiBenhRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriVaCacCheDoTiepTheo", BenhAnPhuKhoa.HuongDieuTriVaCacCheDoTiepTheo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnPhuKhoa.NguoiNhanHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnPhuKhoa.NguoiGiaoHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnPhuKhoa.NgayTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnPhuKhoa.BacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng", BenhAnPhuKhoa.DacDiemLienQuanBenh.DiUng == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng_Text", BenhAnPhuKhoa.DacDiemLienQuanBenh.DiUng_Text));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy", BenhAnPhuKhoa.DacDiemLienQuanBenh.MaTuy == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("MaTuy_Text", BenhAnPhuKhoa.DacDiemLienQuanBenh.MaTuy_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia", BenhAnPhuKhoa.DacDiemLienQuanBenh.RuouBia == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("RuouBia_Text", BenhAnPhuKhoa.DacDiemLienQuanBenh.RuouBia_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa", BenhAnPhuKhoa.DacDiemLienQuanBenh.ThuocLa == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLa_Text", BenhAnPhuKhoa.DacDiemLienQuanBenh.ThuocLa_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao", BenhAnPhuKhoa.DacDiemLienQuanBenh.ThuocLao == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocLao_Text", BenhAnPhuKhoa.DacDiemLienQuanBenh.ThuocLao_Text));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh", BenhAnPhuKhoa.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh_Text", BenhAnPhuKhoa.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TienThaiPara", BenhAnPhuKhoa.TienThaiPara));
            Command.Parameters.Add(new MDB.MDBParameter("Hach", BenhAnPhuKhoa.Hach));
            Command.Parameters.Add(new MDB.MDBParameter("Vu", BenhAnPhuKhoa.Vu));
            Command.Parameters.Add(new MDB.MDBParameter("CacDauHieuSinhDucThuPhat", BenhAnPhuKhoa.CacDauHieuSinhDucThuPhat));
            Command.Parameters.Add(new MDB.MDBParameter("MoiLon", BenhAnPhuKhoa.MoiLon));
            Command.Parameters.Add(new MDB.MDBParameter("MoiBe", BenhAnPhuKhoa.MoiBe));
            Command.Parameters.Add(new MDB.MDBParameter("AmVat", BenhAnPhuKhoa.AmVat));
            Command.Parameters.Add(new MDB.MDBParameter("AmHo", BenhAnPhuKhoa.AmHo));
            Command.Parameters.Add(new MDB.MDBParameter("MangTrinh", BenhAnPhuKhoa.MangTrinh));
            Command.Parameters.Add(new MDB.MDBParameter("TangSinhMon", BenhAnPhuKhoa.TangSinhMon));
            Command.Parameters.Add(new MDB.MDBParameter("AmDao", BenhAnPhuKhoa.AmDao));
            Command.Parameters.Add(new MDB.MDBParameter("CoTuCung", BenhAnPhuKhoa.CoTuCung));
            Command.Parameters.Add(new MDB.MDBParameter("ThanTuCung", BenhAnPhuKhoa.ThanTuCung));
            Command.Parameters.Add(new MDB.MDBParameter("PhanPhu", BenhAnPhuKhoa.PhanPhu));
            Command.Parameters.Add(new MDB.MDBParameter("CacTuiCung", BenhAnPhuKhoa.CacTuiCung));
            if (BenhAnPhuKhoa.TienSuSanPhuKhoa == null) BenhAnPhuKhoa.TienSuSanPhuKhoa = new TienSuSanPhuKhoa();
            Command.Parameters.Add(new MDB.MDBParameter("BatDauThayKinhNam", BenhAnPhuKhoa.TienSuSanPhuKhoa.BatDauThayKinhNam));
            Command.Parameters.Add(new MDB.MDBParameter("TuoiThayKinh", BenhAnPhuKhoa.TienSuSanPhuKhoa.TuoiThayKinh));
            Command.Parameters.Add(new MDB.MDBParameter("TinhChatKinhNguyet", BenhAnPhuKhoa.TienSuSanPhuKhoa.TinhChatKinhNguyet));
            Command.Parameters.Add(new MDB.MDBParameter("ChuKy", BenhAnPhuKhoa.TienSuSanPhuKhoa.ChuKy));
            Command.Parameters.Add(new MDB.MDBParameter("SoNgayThayKinh", BenhAnPhuKhoa.TienSuSanPhuKhoa.SoNgayThayKinh));
            Command.Parameters.Add(new MDB.MDBParameter("LuongKinh", BenhAnPhuKhoa.TienSuSanPhuKhoa.LuongKinh));
            Command.Parameters.Add(new MDB.MDBParameter("KinhLanCuoiNgay", BenhAnPhuKhoa.TienSuSanPhuKhoa.KinhLanCuoiNgay));
            Command.Parameters.Add(new MDB.MDBParameter("DauBung", BenhAnPhuKhoa.TienSuSanPhuKhoa.DauBung == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("LayChongNam", BenhAnPhuKhoa.TienSuSanPhuKhoa.LayChongNam));
            Command.Parameters.Add(new MDB.MDBParameter("TuoiLayChong", BenhAnPhuKhoa.TienSuSanPhuKhoa.TuoiLayChong));
            Command.Parameters.Add(new MDB.MDBParameter("HetKinhNam", BenhAnPhuKhoa.TienSuSanPhuKhoa.HetKinhNam));
            Command.Parameters.Add(new MDB.MDBParameter("TuoiHetKinh", BenhAnPhuKhoa.TienSuSanPhuKhoa.TuoiHetKinh));
            Command.Parameters.Add(new MDB.MDBParameter("Truoc", BenhAnPhuKhoa.TienSuSanPhuKhoa.Truoc == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Sau", BenhAnPhuKhoa.TienSuSanPhuKhoa.Sau == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("Trong", BenhAnPhuKhoa.TienSuSanPhuKhoa.Trong == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("NhungBenhPhuKhoaDaDieuTri", BenhAnPhuKhoa.TienSuSanPhuKhoa.NhungBenhPhuKhoaDaDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("ThuThuat", BenhAnPhuKhoa.ThuThuat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("PhauThuat", BenhAnPhuKhoa.PhauThuat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ChiSoPara1", BenhAnPhuKhoa.ChiSoPara1));
            Command.Parameters.Add(new MDB.MDBParameter("ChiSoPara2", BenhAnPhuKhoa.ChiSoPara2));
            Command.Parameters.Add(new MDB.MDBParameter("ChiSoPara3", BenhAnPhuKhoa.ChiSoPara3));
            Command.Parameters.Add(new MDB.MDBParameter("ChiSoPara4", BenhAnPhuKhoa.ChiSoPara4));
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnPhuKhoa.MaQuanLy));
            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool Delete(MDB.MDBConnection MyConnection, BenhAnPhuKhoa BenhAnPhuKhoa)
        {
            string sql = @"DELETE FROM BenhAnPhuKhoa 
                           WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnPhuKhoa.MaQuanLy));

            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
    }
}
