using EMR_MAIN.DATABASE.BenhAn;
using Newtonsoft.Json;
using System;
using System.Data;

namespace EMR_MAIN.DATABASE.BenhAnFunc
{
    public class BenhAnTimFunc
    {
        public static void WriteXml(MDB.MDBConnection MyConnection)
        {
            string sql =
                   @"
                  select  a.*,  CTScanner HoSo_CTScanner, SieuAm HoSo_SieuAm, XetNghiem HoSo_XetNghiem,  Khac HoSo_Khac,  Khac_Text HoSo_Khac_Text,  ToanBoHoSo HoSo_ToanBoHoSo, Mach DauSinhTon_Mach,  NhietDo DauSinhTon_NhietDo,  HuyetAp DauSinhTon_HuyetAp,  NhipTho DauSinhTon_NhipTho,  CanNang DauSinhTon_CanNang  
                  from BenhAnTim a inner join thongtindieutri b on a.maquanly = b.maquanly
                  where rownum = 1
                    ";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            var DataTable = new DataTable { TableName = "BenhAnTim" };
            DataTable.Load(DataReader as IDataReader);
            DataTable.WriteXml("rptBenhAnTim.xml");
        }
        public static DataSet SelectDataSet(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql =
                   @"
                   select  a.*,f.hovaten BacSyLamBenhAnHoVaTen ,c.hovaten BacSyDieuTriHoVaTen,d.hovaten NguoiGiaoHoSoHoVaTen,e.hovaten NguoiNhanHoSoHoVaTen, b.XQuang HoSo_XQuang,   b.CTScanner HoSo_CTScanner, b.SieuAm HoSo_SieuAm, b.XetNghiem HoSo_XetNghiem,  b.Khac HoSo_Khac,  b.Khac_Text HoSo_Khac_Text,  b.ToanBoHoSo HoSo_ToanBoHoSo, b.Mach DauSinhTon_Mach, b.NhietDo DauSinhTon_NhietDo,  b.HuyetAp DauSinhTon_HuyetAp,  b.NhipTho DauSinhTon_NhipTho,  b.CanNang DauSinhTon_CanNang  , b.ChieuCao DauSinhTon_ChieuCao, b.BMI DauSinhTon_BMI, b.NgayRaVien 
                 from BenhAnTim a 
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

            string sql3 =
                  @"
                   select  BenhNoiKhoa, YeuToNguyCoMachVanh, TrieuChungCoNang
                   from BenhAnTim 
                   where maquanly = " + MaQuanLy.ToString(System.Globalization.CultureInfo.InvariantCulture);
            MDB.MDBCommand Command = new MDB.MDBCommand(sql3, MyConnection);
            Command.BindByName = true;
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            DataTable tableBenhNoiKhoa = new DataTable("BENHNOIKHOA");
            tableBenhNoiKhoa.Columns.Add("VIENLOATDADAY");
            tableBenhNoiKhoa.Columns.Add("HENPHEQUAN");
            tableBenhNoiKhoa.Columns.Add("THAPTIM");
            tableBenhNoiKhoa.Columns.Add("BENHPHOIMAN");
            tableBenhNoiKhoa.Columns.Add("BENHKHAC");

            DataTable tableNguyCoMachVanh = new DataTable("NGUYCOMACHVANH");
            tableNguyCoMachVanh.Columns.Add("NAMTREN50TUOI");
            tableNguyCoMachVanh.Columns.Add("HUTTHUOCLA");
            tableNguyCoMachVanh.Columns.Add("DAITHAODUONG");
            tableNguyCoMachVanh.Columns.Add("CAOHUYETAP");
            tableNguyCoMachVanh.Columns.Add("ROILOANMOMAU");
            tableNguyCoMachVanh.Columns.Add("YEUTOGIADINH");
            tableNguyCoMachVanh.Columns.Add("NUMANKINH");

            DataTable tableTrieuChungCoNang = new DataTable("TRIEUCHUNGCONANG");
            tableTrieuChungCoNang.Columns.Add("KHOTHONYHA");
            tableTrieuChungCoNang.Columns.Add("HORAMAU");
            tableTrieuChungCoNang.Columns.Add("DAUNGUC");
            tableTrieuChungCoNang.Columns.Add("TIM");
            tableTrieuChungCoNang.Columns.Add("NGOIXOM");
            tableTrieuChungCoNang.Columns.Add("NGAT");
            tableTrieuChungCoNang.Columns.Add("HOIHOP");
            tableTrieuChungCoNang.Columns.Add("CACDAUHIEUKHAC");
            while (DataReader.Read())
            {
                BenhNoiKhoa benhNoiKhoa = JsonConvert.DeserializeObject<BenhNoiKhoa>(DataReader["BenhNoiKhoa"].ToString());
                tableBenhNoiKhoa.Rows.Add(
                    benhNoiKhoa.ViemLoetDaDayHT2 ? 1: 0,
                    benhNoiKhoa.HenFQ ? 1:0,
                    benhNoiKhoa.ThapTim ? 1: 0,
                    benhNoiKhoa.BenhPhoiMan ? 1: 0,
                    benhNoiKhoa.BenhKhac
                    );
                NguyCoMachVanh nguyCoMachVanh = JsonConvert.DeserializeObject<NguyCoMachVanh>(DataReader["YeuToNguyCoMachVanh"].ToString());
                tableNguyCoMachVanh.Rows.Add(
                    nguyCoMachVanh.NamTren5Tuoi ? 1 : 0,
                    nguyCoMachVanh.HutThuocLa ? 1 : 0,
                    nguyCoMachVanh.DaiThaoDuong ? 1 : 0,
                    nguyCoMachVanh.CaoHuyetAp ? 1 : 0,
                    nguyCoMachVanh.RoiLoanMoMau ? 1: 0,
                    nguyCoMachVanh.YeuToGiaDinh ? 1: 0,
                    nguyCoMachVanh.NuManKinh ? 1: 0
                    );
                TrieuChungCoNang trieuChungCoNang = JsonConvert.DeserializeObject<TrieuChungCoNang>(DataReader["TrieuChungCoNang"].ToString());
                tableTrieuChungCoNang.Rows.Add(
                    trieuChungCoNang.KhoThoNYHA ? 1: 0,
                    trieuChungCoNang.HoRaMau ? 1 : 0,
                    trieuChungCoNang.DauNguc ? 1 : 0,
                    trieuChungCoNang.Tim ? 1 : 0,
                    trieuChungCoNang.NgoiXom ? 1 : 0,
                    trieuChungCoNang.Ngat ? 1 : 0,
                    trieuChungCoNang.HoiHop ? 1 : 0,
                    trieuChungCoNang.CacDauHieuKhac
                    );
            }
            ds.Tables.Add(tableBenhNoiKhoa);
            ds.Tables.Add(tableNguyCoMachVanh);
            ds.Tables.Add(tableTrieuChungCoNang);

            return ds;
        }
        public static BenhAnTim Select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            #region
            string sql =
                      @"select * 
                        from BenhAnTim a
                        where MaQuanLy = :MaQuanLy";
            #endregion
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            var value = new BenhAnTim();
            value.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
            while (DataReader.Read())
            {
                value.MaQuanLy =  DataReader.GetDecimal("MaQuanLy");
                value.LyDoVaoVien = DataReader["LyDoVaoVien"]?.ToString();
                value.VaoNgayThu = DataReader.GetInt("VaoNgayThu");
                value.QuaTrinhBenhLy = DataReader["QuaTrinhBenhLy"]?.ToString();
                value.TienSuBenhBanThan = DataReader["TienSuBenhBanThan"]?.ToString();
                value.TienSuBenhGiaDinh = DataReader["TienSuBenhGiaDinh"]?.ToString();
                value.ToanThan = DataReader["ToanThan"]?.ToString();
                value.TuanHoan = DataReader["TuanHoan"]?.ToString();
                value.HoHap = DataReader["HoHap"]?.ToString();
                value.TieuHoa = DataReader["TieuHoa"]?.ToString();
                value.ThanTietNieuSinhDuc = DataReader["ThanTietNieuSinhDuc"]?.ToString();
                value.ThanKinh = DataReader["ThanKinh"]?.ToString();
                value.CoXuongKhop = DataReader["CoXuongKhop"]?.ToString();
                value.TaiMuiHong = DataReader["TaiMuiHong"]?.ToString();
                value.RangHamMat = DataReader["RangHamMat"]?.ToString();
                value.Mat = DataReader["Mat"]?.ToString();
                value.Khac_CacCoQuan = DataReader["Khac_CacCoQuan"]?.ToString();
                value.CacXetNghiemCanLamSangCanLam = DataReader["CacXetNghiemCanLamSangCanLam"]?.ToString();
                value.TomTatBenhAn = DataReader["TomTatBenhAn"]?.ToString();
                value.BenhChinh = DataReader["BenhChinh"]?.ToString();
                value.BenhKemTheo = DataReader["BenhKemTheo"]?.ToString();
                value.PhanBiet = DataReader["PhanBiet"]?.ToString();
                value.TienLuong = DataReader["TienLuong"]?.ToString();
                value.HuongDieuTri = DataReader["HuongDieuTri"]?.ToString();
                value.NgayKhamBenh = DataReader.GetDate("NgayKhamBenh");
                value.BacSyLamBenhAn = DataReader["BacSyLamBenhAn"]?.ToString();
                value.QuaTrinhBenhLyVaDienBien = DataReader["QuaTrinhBenhLyVaDienBien"]?.ToString();
                value.TomTatKetQuaXetNghiem = DataReader["TomTatKetQuaXetNghiem"]?.ToString();
                value.PhuongPhapDieuTri = DataReader["PhuongPhapDieuTri"]?.ToString();
                value.TinhTrangNguoiBenhRaVien = DataReader["TinhTrangNguoiBenhRaVien"]?.ToString();
                value.HuongDieuTriVaCacCheDoTiepTheo = DataReader["HuongDieuTriVaCacCheDoTiepTheo"]?.ToString();
                value.NguoiNhanHoSo = DataReader["NguoiNhanHoSo"]?.ToString();
                value.NguoiGiaoHoSo = DataReader["NguoiGiaoHoSo"]?.ToString();
                value.NgayTongKet = DataReader.GetDate("NgayTongKet");
                value.BacSyDieuTri = DataReader["BacSyDieuTri"]?.ToString();
                value.DacDiemLienQuanBenh.DiUng = DataReader["DiUng"]?.ToString() == "1" ? true : false;
                value.DacDiemLienQuanBenh.DiUng_Text = DataReader["DiUng_Text"]?.ToString();
                value.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh = DataReader["Khac_DacDiemLienQuanBenh"]?.ToString() == "1" ? true : false;
                value.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh_Text = DataReader["Khac_DacDiemLienQuanBenh_Text"]?.ToString();
                value.DacDiemLienQuanBenh.MaTuy = DataReader["MaTuy"]?.ToString() == "1" ? true : false;
                value.DacDiemLienQuanBenh.MaTuy_Text = DataReader["MaTuy_Text"]?.ToString();
                value.DacDiemLienQuanBenh.RuouBia = DataReader["RuouBia"]?.ToString() == "1" ? true : false;
                value.DacDiemLienQuanBenh.RuouBia_Text = DataReader["RuouBia_Text"]?.ToString();
                value.DacDiemLienQuanBenh.ThuocLa = DataReader["ThuocLa"]?.ToString() == "1" ? true : false;
                value.DacDiemLienQuanBenh.ThuocLa_Text = DataReader["ThuocLa_Text"]?.ToString();
                value.DacDiemLienQuanBenh.ThuocLao = DataReader["ThuocLao"]?.ToString() == "1" ? true : false;
                value.DacDiemLienQuanBenh.ThuocLao_Text = DataReader["ThuocLao_Text"]?.ToString();
                value.DauSinhTon = new DauSinhTon();

                value.CacThuocDangDung = DataReader["CacThuocDangDung"]?.ToString();
                int temp = 0;
                int.TryParse(DataReader["TienSuPKhiSinh"]?.ToString(), out temp);
                value.TienSuPKhiSinh = temp;
                value.BenhLyMeTrongThaiky = DataReader["BenhLyMeTrongThaiky"]?.ToString();
                value.SuDungThuocMeTrongThaiKy = DataReader["SuDungThuocMeTrongThaiKy"]?.ToString();
                value.YeuToNguyCoMachVanh = JsonConvert.DeserializeObject<NguyCoMachVanh>(DataReader["YeuToNguyCoMachVanh"]?.ToString());
                value.BenhNoiKhoa = JsonConvert.DeserializeObject<BenhNoiKhoa>(DataReader["BenhNoiKhoa"]?.ToString());
                value.DaNiemMac = DataReader["DaNiemMac"]?.ToString();
                value.Phu = DataReader["Phu"]?.ToString();
                value.NgonTayChanDuiTrong = DataReader["NgonTayChanDuiTrong"]?.ToString();
                value.HachNgoaiBienTuyenGiap = DataReader["HachNgoaiBienTuyenGiap"]?.ToString();
                value.TrieuChungCoNang = JsonConvert.DeserializeObject<TrieuChungCoNang>(DataReader["TrieuChungCoNang"]?.ToString());
                value.LongNguc = DataReader["LongNguc"]?.ToString();
                value.ViTriMomTim = DataReader["ViTriMomTim"]?.ToString();
                value.TiengTim = DataReader["TiengTim"]?.ToString();
                value.TiengThoiMachCanh = DataReader["TiengThoiMachCanh"]?.ToString();
                value.TiengThoiTaiTim = DataReader["TiengThoiTaiTim"]?.ToString();
                value.TiengThoiTaiViTriKhac = DataReader["TiengThoiTaiViTriKhac"]?.ToString();
                value.Bung = DataReader["Bung"]?.ToString();
                value.CacCoQuanKhac = DataReader["CacCoQuanKhac"]?.ToString();
                value.ChanDoanSoBo = DataReader["ChanDoanSoBo"]?.ToString();
                value.KetQuaXetNghiem = DataReader["KetQuaXetNghiem"]?.ToString();
                value.ChanDoanXacDinh = DataReader["ChanDoanXacDinh"]?.ToString();
                value.BoXungBenhAn = DataReader["BoXungBenhAn"]?.ToString();
                value.MaSoKyTen = DataReader["masokyten"].ToString();
                value.MaSoKyTen_KB = DataReader["masokyten_kb"].ToString();
                value.MaSoKyTen_TK = DataReader["masokyten_tk"].ToString();
            }
            return value;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, BenhAnTim BenhAnTim)
        {
            try
            {
                string sql =
                          @"select MaQuanLy 
                        from BenhAnTim
                        where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnTim.MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                int rowCount = 0;
                while (DataReader.Read()) rowCount++;
                if (rowCount == 1) return Update(MyConnection, BenhAnTim);
                sql = @"
                   INSERT INTO BenhAnTim (
					MaQuanLy,
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
                    CacThuocDangDung,
                    TienSuPKhiSinh,
                    BenhLyMeTrongThaiky,
                    SuDungThuocMeTrongThaiKy,
                    YeuToNguyCoMachVanh,
                    BenhNoiKhoa,
                    DaNiemMac,
                    Phu,
                    NgonTayChanDuiTrong,
                    HachNgoaiBienTuyenGiap,
                    TrieuChungCoNang,
                    LongNguc,
                    ViTriMomTim,
                    TiengTim,
                    TiengThoiMachCanh,
                    TiengThoiTaiTim,
                    TiengThoiTaiViTriKhac,
                    Bung,
                    CacCoQuanKhac,
                    ChanDoanSoBo,
                    KetQuaXetNghiem,
                    ChanDoanXacDinh,
                    BoXungBenhAn)
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
                    :CacThuocDangDung,
                    :TienSuPKhiSinh,
                    :BenhLyMeTrongThaiky,
                    :SuDungThuocMeTrongThaiKy,
                    :YeuToNguyCoMachVanh,
                    :BenhNoiKhoa,
                    :DaNiemMac,
                    :Phu,
                    :NgonTayChanDuiTrong,
                    :HachNgoaiBienTuyenGiap,
                    :TrieuChungCoNang,
                    :LongNguc,
                    :ViTriMomTim,
                    :TiengTim,
                    :TiengThoiMachCanh,
                    :TiengThoiTaiTim,
                    :TiengThoiTaiViTriKhac,
                    :Bung,
                    :CacCoQuanKhac,
                    :ChanDoanSoBo,
                    :KetQuaXetNghiem,
                    :ChanDoanXacDinh,
                    :BoXungBenhAn)
                   ";
                Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnTim.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnTim.LyDoVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("VaoNgayThu", BenhAnTim.VaoNgayThu));
                Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnTim.QuaTrinhBenhLy));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhBanThan", BenhAnTim.TienSuBenhBanThan));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhGiaDinh", BenhAnTim.TienSuBenhGiaDinh));
                Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnTim.ToanThan));
                Command.Parameters.Add(new MDB.MDBParameter("TuanHoan", BenhAnTim.TuanHoan));
                Command.Parameters.Add(new MDB.MDBParameter("HoHap", BenhAnTim.HoHap));
                Command.Parameters.Add(new MDB.MDBParameter("TieuHoa", BenhAnTim.TieuHoa));
                Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieuSinhDuc", BenhAnTim.ThanTietNieuSinhDuc));
                Command.Parameters.Add(new MDB.MDBParameter("ThanKinh", BenhAnTim.ThanKinh));
                Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop", BenhAnTim.CoXuongKhop));
                Command.Parameters.Add(new MDB.MDBParameter("TaiMuiHong", BenhAnTim.TaiMuiHong));
                Command.Parameters.Add(new MDB.MDBParameter("RangHamMat", BenhAnTim.RangHamMat));
                Command.Parameters.Add(new MDB.MDBParameter("Mat", BenhAnTim.Mat));
                Command.Parameters.Add(new MDB.MDBParameter("Khac_CacCoQuan", BenhAnTim.Khac_CacCoQuan));
                Command.Parameters.Add(new MDB.MDBParameter("CacXetNghiemCanLamSangCanLam", BenhAnTim.CacXetNghiemCanLamSangCanLam));
                Command.Parameters.Add(new MDB.MDBParameter("TomTatBenhAn", BenhAnTim.TomTatBenhAn));
                Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnTim.BenhChinh));
                Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnTim.BenhKemTheo));
                Command.Parameters.Add(new MDB.MDBParameter("PhanBiet", BenhAnTim.PhanBiet));
                Command.Parameters.Add(new MDB.MDBParameter("TienLuong", BenhAnTim.TienLuong));
                Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnTim.HuongDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("NgayKhamBenh", BenhAnTim.NgayKhamBenh));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyLamBenhAn", BenhAnTim.BacSyLamBenhAn));
                Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLyVaDienBien", BenhAnTim.QuaTrinhBenhLyVaDienBien));
                Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQuaXetNghiem", BenhAnTim.TomTatKetQuaXetNghiem));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnTim.PhuongPhapDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangNguoiBenhRaVien", BenhAnTim.TinhTrangNguoiBenhRaVien));
                Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriVaCacCheDoTiepTheo", BenhAnTim.HuongDieuTriVaCacCheDoTiepTheo));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnTim.NguoiNhanHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnTim.NguoiGiaoHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnTim.NgayTongKet));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnTim.BacSyDieuTri));
                if (BenhAnTim.DacDiemLienQuanBenh != null)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("DiUng", BenhAnTim.DacDiemLienQuanBenh.DiUng == true ? "1" : "0"));
                    Command.Parameters.Add(new MDB.MDBParameter("DiUng_Text", BenhAnTim.DacDiemLienQuanBenh.DiUng_Text));
                    Command.Parameters.Add(new MDB.MDBParameter("MaTuy", BenhAnTim.DacDiemLienQuanBenh.MaTuy == true ? "1" : "0"));
                    Command.Parameters.Add(new MDB.MDBParameter("MaTuy_Text", BenhAnTim.DacDiemLienQuanBenh.MaTuy_Text));
                    Command.Parameters.Add(new MDB.MDBParameter("RuouBia", BenhAnTim.DacDiemLienQuanBenh.RuouBia == true ? "1" : "0"));
                    Command.Parameters.Add(new MDB.MDBParameter("RuouBia_Text", BenhAnTim.DacDiemLienQuanBenh.RuouBia_Text));
                    Command.Parameters.Add(new MDB.MDBParameter("ThuocLa", BenhAnTim.DacDiemLienQuanBenh.ThuocLa == true ? "1" : "0"));
                    Command.Parameters.Add(new MDB.MDBParameter("ThuocLa_Text", BenhAnTim.DacDiemLienQuanBenh.ThuocLa_Text));
                    Command.Parameters.Add(new MDB.MDBParameter("ThuocLao", BenhAnTim.DacDiemLienQuanBenh.ThuocLao == true ? "1" : "0"));
                    Command.Parameters.Add(new MDB.MDBParameter("ThuocLao_Text", BenhAnTim.DacDiemLienQuanBenh.ThuocLao_Text));
                    Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh", BenhAnTim.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh == true ? "1" : "0"));
                    Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh_Text", BenhAnTim.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh_Text));
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
                }
                Command.Parameters.Add(new MDB.MDBParameter("CacThuocDangDung", BenhAnTim.CacThuocDangDung));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuPKhiSinh", BenhAnTim.TienSuPKhiSinh));
                Command.Parameters.Add(new MDB.MDBParameter("BenhLyMeTrongThaiky", BenhAnTim.BenhLyMeTrongThaiky));
                Command.Parameters.Add(new MDB.MDBParameter("SuDungThuocMeTrongThaiKy", BenhAnTim.SuDungThuocMeTrongThaiKy));
                Command.Parameters.Add(new MDB.MDBParameter("BenhLyMeTrongThaiky", BenhAnTim.BenhLyMeTrongThaiky));
                Command.Parameters.Add(new MDB.MDBParameter("YeuToNguyCoMachVanh", JsonConvert.SerializeObject(BenhAnTim.YeuToNguyCoMachVanh)));
                Command.Parameters.Add(new MDB.MDBParameter("BenhNoiKhoa", JsonConvert.SerializeObject(BenhAnTim.BenhNoiKhoa)));
                Command.Parameters.Add(new MDB.MDBParameter("DaNiemMac",BenhAnTim.DaNiemMac));
                Command.Parameters.Add(new MDB.MDBParameter("Phu", BenhAnTim.Phu));
                Command.Parameters.Add(new MDB.MDBParameter("NgonTayChanDuiTrong", BenhAnTim.NgonTayChanDuiTrong));
                Command.Parameters.Add(new MDB.MDBParameter("HachNgoaiBienTuyenGiap", BenhAnTim.HachNgoaiBienTuyenGiap));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungCoNang", JsonConvert.SerializeObject(BenhAnTim.TrieuChungCoNang)));
                Command.Parameters.Add(new MDB.MDBParameter("LongNguc", BenhAnTim.LongNguc));
                Command.Parameters.Add(new MDB.MDBParameter("ViTriMomTim", BenhAnTim.ViTriMomTim));
                Command.Parameters.Add(new MDB.MDBParameter("TiengTim", BenhAnTim.TiengTim));
                Command.Parameters.Add(new MDB.MDBParameter("TiengThoiMachCanh", BenhAnTim.TiengThoiMachCanh));
                Command.Parameters.Add(new MDB.MDBParameter("TiengThoiTaiTim", BenhAnTim.TiengThoiTaiTim));
                Command.Parameters.Add(new MDB.MDBParameter("TiengThoiTaiViTriKhac", BenhAnTim.TiengThoiTaiViTriKhac));
                Command.Parameters.Add(new MDB.MDBParameter("Bung", BenhAnTim.Bung));
                Command.Parameters.Add(new MDB.MDBParameter("CacCoQuanKhac", BenhAnTim.CacCoQuanKhac));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanSoBo", BenhAnTim.ChanDoanSoBo));
                Command.Parameters.Add(new MDB.MDBParameter("KetQuaXetNghiem", BenhAnTim.KetQuaXetNghiem));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanXacDinh", BenhAnTim.ChanDoanXacDinh));
                Command.Parameters.Add(new MDB.MDBParameter("BoXungBenhAn", BenhAnTim.BoXungBenhAn));
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery(); // C#
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
                return false;
            }
        }
        public static bool Update(MDB.MDBConnection MyConnection, BenhAnTim BenhAnTim)
        {
            try
            {
                string sql = @"UPDATE BenhAnTim SET 
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
                        CacThuocDangDung = :CacThuocDangDung,
                        TienSuPKhiSinh = :TienSuPKhiSinh,
                        BenhLyMeTrongThaiky = :BenhLyMeTrongThaiky,
                        SuDungThuocMeTrongThaiKy = :SuDungThuocMeTrongThaiKy,
                        YeuToNguyCoMachVanh = :YeuToNguyCoMachVanh,
                        BenhNoiKhoa = :BenhNoiKhoa,
                        DaNiemMac = :DaNiemMac,
                        Phu = :Phu,
                        NgonTayChanDuiTrong = :NgonTayChanDuiTrong,
                        HachNgoaiBienTuyenGiap = :HachNgoaiBienTuyenGiap,
                        TrieuChungCoNang = :TrieuChungCoNang,
                        LongNguc = :LongNguc,
                        ViTriMomTim = :ViTriMomTim,
                        TiengTim = :TiengTim,
                        TiengThoiMachCanh = :TiengThoiMachCanh,
                        TiengThoiTaiTim = :TiengThoiTaiTim,
                        TiengThoiTaiViTriKhac = :TiengThoiTaiViTriKhac,
                        Bung = :Bung,
                        CacCoQuanKhac = :CacCoQuanKhac,
                        ChanDoanSoBo = :ChanDoanSoBo,
                        KetQuaXetNghiem = :KetQuaXetNghiem,
                        ChanDoanXacDinh = :ChanDoanXacDinh,
                        BoXungBenhAn = :BoXungBenhAn 
                        WHERE MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnTim.LyDoVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("VaoNgayThu", BenhAnTim.VaoNgayThu));
                Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnTim.QuaTrinhBenhLy));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhBanThan", BenhAnTim.TienSuBenhBanThan));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhGiaDinh", BenhAnTim.TienSuBenhGiaDinh));
                Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnTim.ToanThan));
                Command.Parameters.Add(new MDB.MDBParameter("TuanHoan", BenhAnTim.TuanHoan));
                Command.Parameters.Add(new MDB.MDBParameter("HoHap", BenhAnTim.HoHap));
                Command.Parameters.Add(new MDB.MDBParameter("TieuHoa", BenhAnTim.TieuHoa));
                Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieuSinhDuc", BenhAnTim.ThanTietNieuSinhDuc));
                Command.Parameters.Add(new MDB.MDBParameter("ThanKinh", BenhAnTim.ThanKinh));
                Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop", BenhAnTim.CoXuongKhop));
                Command.Parameters.Add(new MDB.MDBParameter("TaiMuiHong", BenhAnTim.TaiMuiHong));
                Command.Parameters.Add(new MDB.MDBParameter("RangHamMat", BenhAnTim.RangHamMat));
                Command.Parameters.Add(new MDB.MDBParameter("Mat", BenhAnTim.Mat));
                Command.Parameters.Add(new MDB.MDBParameter("Khac_CacCoQuan", BenhAnTim.Khac_CacCoQuan));
                Command.Parameters.Add(new MDB.MDBParameter("CacXetNghiemCanLamSangCanLam", BenhAnTim.CacXetNghiemCanLamSangCanLam));
                Command.Parameters.Add(new MDB.MDBParameter("TomTatBenhAn", BenhAnTim.TomTatBenhAn));
                Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnTim.BenhChinh));
                Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnTim.BenhKemTheo));
                Command.Parameters.Add(new MDB.MDBParameter("PhanBiet", BenhAnTim.PhanBiet));
                Command.Parameters.Add(new MDB.MDBParameter("TienLuong", BenhAnTim.TienLuong));
                Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnTim.HuongDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("NgayKhamBenh", BenhAnTim.NgayKhamBenh));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyLamBenhAn", BenhAnTim.BacSyLamBenhAn));
                Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLyVaDienBien", BenhAnTim.QuaTrinhBenhLyVaDienBien));
                Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQuaXetNghiem", BenhAnTim.TomTatKetQuaXetNghiem));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnTim.PhuongPhapDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangNguoiBenhRaVien", BenhAnTim.TinhTrangNguoiBenhRaVien));
                Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriVaCacCheDoTiepTheo", BenhAnTim.HuongDieuTriVaCacCheDoTiepTheo));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnTim.NguoiNhanHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnTim.NguoiGiaoHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnTim.NgayTongKet));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", BenhAnTim.BacSyDieuTri));
                if (BenhAnTim.DacDiemLienQuanBenh != null)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("DiUng", BenhAnTim.DacDiemLienQuanBenh.DiUng == true ? "1" : "0"));
                    Command.Parameters.Add(new MDB.MDBParameter("DiUng_Text", BenhAnTim.DacDiemLienQuanBenh.DiUng_Text));
                    Command.Parameters.Add(new MDB.MDBParameter("MaTuy", BenhAnTim.DacDiemLienQuanBenh.MaTuy == true ? "1" : "0"));
                    Command.Parameters.Add(new MDB.MDBParameter("MaTuy_Text", BenhAnTim.DacDiemLienQuanBenh.MaTuy_Text));
                    Command.Parameters.Add(new MDB.MDBParameter("RuouBia", BenhAnTim.DacDiemLienQuanBenh.RuouBia == true ? "1" : "0"));
                    Command.Parameters.Add(new MDB.MDBParameter("RuouBia_Text", BenhAnTim.DacDiemLienQuanBenh.RuouBia_Text));
                    Command.Parameters.Add(new MDB.MDBParameter("ThuocLa", BenhAnTim.DacDiemLienQuanBenh.ThuocLa == true ? "1" : "0"));
                    Command.Parameters.Add(new MDB.MDBParameter("ThuocLa_Text", BenhAnTim.DacDiemLienQuanBenh.ThuocLa_Text));
                    Command.Parameters.Add(new MDB.MDBParameter("ThuocLao", BenhAnTim.DacDiemLienQuanBenh.ThuocLao == true ? "1" : "0"));
                    Command.Parameters.Add(new MDB.MDBParameter("ThuocLao_Text", BenhAnTim.DacDiemLienQuanBenh.ThuocLao_Text));
                    Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh", BenhAnTim.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh == true ? "1" : "0"));
                    Command.Parameters.Add(new MDB.MDBParameter("Khac_DacDiemLienQuanBenh_Text", BenhAnTim.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh_Text));
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
                }
                Command.Parameters.Add(new MDB.MDBParameter("CacThuocDangDung", BenhAnTim.CacThuocDangDung));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuPKhiSinh", BenhAnTim.TienSuPKhiSinh));
                Command.Parameters.Add(new MDB.MDBParameter("BenhLyMeTrongThaiky", BenhAnTim.BenhLyMeTrongThaiky));
                Command.Parameters.Add(new MDB.MDBParameter("SuDungThuocMeTrongThaiKy", BenhAnTim.SuDungThuocMeTrongThaiKy));
                Command.Parameters.Add(new MDB.MDBParameter("BenhLyMeTrongThaiky", BenhAnTim.BenhLyMeTrongThaiky));
                Command.Parameters.Add(new MDB.MDBParameter("YeuToNguyCoMachVanh", JsonConvert.SerializeObject(BenhAnTim.YeuToNguyCoMachVanh)));
                Command.Parameters.Add(new MDB.MDBParameter("BenhNoiKhoa", JsonConvert.SerializeObject(BenhAnTim.BenhNoiKhoa)));
                Command.Parameters.Add(new MDB.MDBParameter("DaNiemMac", BenhAnTim.DaNiemMac));
                Command.Parameters.Add(new MDB.MDBParameter("Phu", BenhAnTim.Phu));
                Command.Parameters.Add(new MDB.MDBParameter("NgonTayChanDuiTrong", BenhAnTim.NgonTayChanDuiTrong));
                Command.Parameters.Add(new MDB.MDBParameter("HachNgoaiBienTuyenGiap", BenhAnTim.HachNgoaiBienTuyenGiap));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungCoNang", JsonConvert.SerializeObject(BenhAnTim.TrieuChungCoNang)));
                Command.Parameters.Add(new MDB.MDBParameter("LongNguc", BenhAnTim.LongNguc));
                Command.Parameters.Add(new MDB.MDBParameter("ViTriMomTim", BenhAnTim.ViTriMomTim));
                Command.Parameters.Add(new MDB.MDBParameter("TiengTim", BenhAnTim.TiengTim));
                Command.Parameters.Add(new MDB.MDBParameter("TiengThoiMachCanh", BenhAnTim.TiengThoiMachCanh));
                Command.Parameters.Add(new MDB.MDBParameter("TiengThoiTaiTim", BenhAnTim.TiengThoiTaiTim));
                Command.Parameters.Add(new MDB.MDBParameter("TiengThoiTaiViTriKhac", BenhAnTim.TiengThoiTaiViTriKhac));
                Command.Parameters.Add(new MDB.MDBParameter("Bung", BenhAnTim.Bung));
                Command.Parameters.Add(new MDB.MDBParameter("CacCoQuanKhac", BenhAnTim.CacCoQuanKhac));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanSoBo", BenhAnTim.ChanDoanSoBo));
                Command.Parameters.Add(new MDB.MDBParameter("KetQuaXetNghiem", BenhAnTim.KetQuaXetNghiem));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanXacDinh", BenhAnTim.ChanDoanXacDinh));
                Command.Parameters.Add(new MDB.MDBParameter("BoXungBenhAn", BenhAnTim.BoXungBenhAn));

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnTim.MaQuanLy));
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery(); // C#
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
                return false;
            }

        }
        public static bool Delete(MDB.MDBConnection MyConnection, BenhAnTim BenhAnTim)
        {
            string sql = @"DELETE FROM BenhAnTim 
                           WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnTim.MaQuanLy));

            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
    }
}

