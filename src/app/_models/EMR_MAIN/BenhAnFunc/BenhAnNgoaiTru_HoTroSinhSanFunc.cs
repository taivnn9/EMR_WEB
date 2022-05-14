using EMR_MAIN.DATABASE.BenhAn;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMR_MAIN.DATABASE.BenhAnFunc
{
    public class BenhAnNgoaiTru_HoTroSinhSanFunc
    {
        public static void WriteXml(MDB.MDBConnection MyConnection)
        {
            string sql =
                   @"
                  select  a.*,  CTScanner HoSo_CTScanner, SieuAm HoSo_SieuAm, XetNghiem HoSo_XetNghiem,  Khac HoSo_Khac,  Khac_Text HoSo_Khac_Text,  ToanBoHoSo HoSo_ToanBoHoSo, Mach DauSinhTon_Mach,  NhietDo DauSinhTon_NhietDo,  HuyetAp DauSinhTon_HuyetAp,  NhipTho DauSinhTon_NhipTho,  CanNang DauSinhTon_CanNang  
                  from BenhAnNgoaiTru_HTSS a inner join thongtindieutri b on a.maquanly = b.maquanly
                  where rownum = 1
                    ";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            var DataTable = new DataTable { TableName = "BenhAnNgoaiTru_HTSS" };
            DataTable.Load(DataReader as IDataReader);
            DataTable.WriteXml("rptBenhAnNgoaiTru_HTSS.xml");
        }
        public static DataSet SelectDataSet(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql =
                   @"
                  select  a.*, f.hovaten GiamDocBenhVienHoVaTen, d.hovaten BacSyKhamBenhHoVaTen 
                        from BenhAnNgoaiTru_HTSS a  
                  left join nhanvien f on a.GiamDocBenhVien = f.manhanvien
                  left join nhanvien d on a.BacSyKhamBenh = d.manhanvien where a.maquanly = " + MaQuanLy.ToString(System.Globalization.CultureInfo.InvariantCulture);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(sql, MyConnection);
            var ds = new DataSet();
            adt.Fill(ds, "Table");
            ObservableCollection<TienSuSanKhoaVo> TienSuSanKhoaVo = JsonConvert.DeserializeObject<ObservableCollection<TienSuSanKhoaVo>>(ds.Tables[0].Rows[0]["TienSuSanKhoaVo"].ToString());
            ObservableCollection<PhieuTheoDoiNangNoan> PhieuTheoDoiNangNoan = JsonConvert.DeserializeObject<ObservableCollection<PhieuTheoDoiNangNoan>>(ds.Tables[0].Rows[0]["PhieuTheoDoiNangNoan"].ToString());
            ObservableCollection<PhieuTheoDoiNoiMac> PhieuTheoDoiNoiMac = JsonConvert.DeserializeObject<ObservableCollection<PhieuTheoDoiNoiMac>>(ds.Tables[0].Rows[0]["PhieuTheoDoiNoiMac"].ToString());

            ds.Tables.Add(Common.ListToDataTable(TienSuSanKhoaVo.ToList(), "TS"));
            ds.Tables.Add(Common.ListToDataTable(PhieuTheoDoiNangNoan.ToList(), "NN"));
            ds.Tables.Add(Common.ListToDataTable(PhieuTheoDoiNoiMac.ToList(), "NM"));


            return ds;
        }
        public static BenhAnNgoaiTru_HoTroSinhSan Select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            var obj = new BenhAnNgoaiTru_HoTroSinhSan();
            try
            {
                #region
                string sql =
                          @"select * 
                        from BenhAnNgoaiTru_HTSS
                        where MaQuanLy = :MaQuanLy";
                #endregion
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    // Phần chung Hành chính
                    obj.MaQuanLy = DataReader.GetDecimal("MaQuanLy");

                    obj.ToanThan = DataReader["ToanThan"].ToString();
                    obj.TuanHoan = DataReader["TuanHoan"].ToString();
                    obj.HoHap = DataReader["HoHap"].ToString();
                    obj.TieuHoa = DataReader["TieuHoa"].ToString();
                    obj.ThanKinh = DataReader["ThanKinh"].ToString();
                    obj.CoXuongKhop = DataReader["CoXuongKhop"].ToString();
                    obj.ThanTietNieuSinhDuc = DataReader["ThanTietNieuSinhDuc"].ToString();
                    obj.Khac_CacCoQuan = DataReader["Khac_CacCoQuan"].ToString();
                    obj.TomTatKetQuaXetNghiem = DataReader["TomTatKetQuaXetNghiem"].ToString();
                    obj.BacSyKhamBenh = DataReader["BacSyKhamBenh"].ToString();

                    obj.HoVaTenChong = DataReader["HoVaTenChong"].ToString();
                    obj.NgaySinhChong = DataReader["NgaySinhChong"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgaySinhChong"].ToString()): null;
                    obj.TuoiChong = DataReader["TuoiChong"].ToString();
                    obj.TrinhDoHocVanChong = DataReader["TrinhDoHocVanChong"].ToString();
                    obj.NgheNghiepChong = DataReader["NgheNghiepChong"].ToString();
                    obj.MaNgheNghiepChong = DataReader["MaNgheNghiepChong"].ToString();
                    obj.DanTocChong = DataReader["DanTocChong"].ToString();
                    obj.MaDanhTocChong = DataReader["MaDanhTocChong"].ToString();
                    obj.NgoaiKieuChong = DataReader["NgoaiKieuChong"].ToString();
                    obj.MaNgoaiKieuChong = DataReader["MaNgoaiKieuChong"].ToString();
                    obj.SDTVo = DataReader["SDTVo"].ToString();
                    obj.SDTChong = DataReader["SDTChong"].ToString();
                    obj.MongCon = DataReader["MongCon"].ToString();
                    obj.TienSuSanKhoaVo = JsonConvert.DeserializeObject<ObservableCollection<TienSuSanKhoaVo>>(DataReader["TienSuSanKhoaVo"].ToString());
                    obj.BatDauThayKinh_Nam = DataReader["BatDauThayKinh_Nam"].ToString();
                    obj.BatDauThayKinh_Tuoi = DataReader["BatDauThayKinh_Tuoi"].ToString();
                    obj.TinhChatKinhNguyet = DataReader["TinhChatKinhNguyet"].ToString();
                    obj.ChuKy = DataReader["ChuKy"].ToString();
                    obj.SoNgayThayKinh = DataReader["SoNgayThayKinh"].ToString();
                    obj.LuongKinh = DataReader["LuongKinh"].ToString();
                    obj.KinhLanCuoiNgay = DataReader["KinhLanCuoiNgay"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["KinhLanCuoiNgay"].ToString()): null;
                    obj.DauBung = DataReader["DauBung"].ToString().Equals("1") ? true: false;
                    obj.ThoiGian = DataReader["ThoiGian"].ToString();
                    obj.LayChongNam = DataReader["LayChongNam"].ToString();
                    obj.LayChongTuoi = DataReader["LayChongTuoi"].ToString();
                    obj.HetKinhNam = DataReader["HetKinhNam"].ToString();
                    obj.HetKinhTuoi = DataReader["HetKinhTuoi"].ToString();
                    obj.NhungBenhPhuKhoaDaDieuTri = DataReader["NhungBenhPhuKhoaDaDieuTri"].ToString();
                    obj.KHHGD = DataReader.GetInt("KHHGD");
                    obj.PhuongPhap = DataReader["PhuongPhap"].ToString();
                    obj.BenhLyNoiKhoa = DataReader.GetInt("BenhLyNoiKhoa");
                    obj.BenhLyNoiKhoa_Text = DataReader["BenhLyNoiKhoa_Text"].ToString();
                    obj.TienSuHiemMuon = DataReader["TienSuHiemMuon"].ToString();
                    obj.DaTungCoCon = DataReader["DaTungCoCon"].ToString();
                    obj.HDTD_SongChungThuongXuyen = DataReader.GetInt("HDTD_SongChungThuongXuyen");
                    obj.HDTD_SoLanGiaoHop = DataReader["HDTD_SoLanGiaoHop"].ToString();
                    obj.ThoiQuen_HutThuoc = DataReader["ThoiQuen_HutThuoc"].ToString();
                    obj.ThoiQuen_Ruou = DataReader["ThoiQuen_Ruou"].ToString();
                    obj.BenhLyKhac_QuaiBi = DataReader.GetInt("BenhLyKhac_QuaiBi");
                    obj.BenhLyKhac_NhiemTrungTNSD = DataReader["BenhLyKhac_NhiemTrungTNSD"].ToString();
                    obj.BenhLyKhac_Khac = DataReader["BenhLyKhac_Khac"].ToString();
                    obj.DaDieuTriHiemMuon = DataReader.GetInt("DaDieuTriHiemMuon");
                    obj.DieuTri = DataReader["DieuTri"].ToString();
                    obj.Hach = DataReader["Hach"].ToString();
                    obj.Vu = DataReader["Vu"].ToString();
                    obj.CacDauHieuSinhDucThuPhat = DataReader["CacDauHieuSinhDucThuPhat"].ToString();
                    obj.MoiLon = DataReader["MoiLon"].ToString();
                    obj.MoiBe = DataReader["MoiBe"].ToString();
                    obj.AmVat = DataReader["AmVat"].ToString();
                    obj.AmHo = DataReader["AmHo"].ToString();
                    obj.MangTrinh = DataReader["MangTrinh"].ToString();
                    obj.TangSinhMon = DataReader["TangSinhMon"].ToString();
                    obj.AmDao = DataReader["AmDao"].ToString();
                    obj.CoTuCung = DataReader["CoTuCung"].ToString();
                    obj.ThanTuCung = DataReader["ThanTuCung"].ToString();
                    obj.PhanPhu = DataReader["PhanPhu"].ToString();
                    obj.CacTuiCung = DataReader["CacTuiCung"].ToString();
                    obj.TheTrang = DataReader.GetInt("TheTrang");
                    obj.TinhTrangLong = DataReader.GetInt("TinhTrangLong");
                    obj.TimPhoi = DataReader.GetInt("TimPhoi");
                    obj.TinhHoan = DataReader["TinhHoan"].ToString();
                    obj.Biu = DataReader["Biu"].ToString();
                    obj.MaoTinh = DataReader["MaoTinh"].ToString();
                    obj.ThungTinh = DataReader["ThungTinh"].ToString();
                    obj.DuongVat = DataReader["DuongVat"].ToString();
                    obj.ChanDoanBanDau = DataReader["ChanDoanBanDau"].ToString();
                    obj.DaXuLy = DataReader["DaXuLy"].ToString();
                    obj.PhacDo = DataReader["PhacDo"].ToString();
                    obj.LieuThuoc = DataReader["LieuThuoc"].ToString();
                    obj.ChanDoanKhiRaVien = DataReader["ChanDoanKhiRaVien"].ToString();
                    obj.DieuTri_Tu = DataReader["DieuTri_Tu"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["DieuTri_Tu"].ToString()): null;
                    obj.DieuTri_Den = DataReader["DieuTri_Den"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["DieuTri_Den"].ToString()) : null;
                    obj.NgayTao = DataReader["NgayTao"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayTao"].ToString()) : null;
                    obj.GiamDocBenhVien = DataReader["GiamDocBenhVien"].ToString();
                    obj.ChanDoan = DataReader["ChanDoan"].ToString();
                    obj.PhacDoDieuTri = DataReader["PhacDoDieuTri"].ToString();
                    obj.PhieuTheoDoiNangNoan = JsonConvert.DeserializeObject <ObservableCollection<PhieuTheoDoiNangNoan>>(DataReader["PhieuTheoDoiNangNoan"].ToString());
                    obj.PhieuTheoDoiNoiMac = JsonConvert.DeserializeObject<ObservableCollection<PhieuTheoDoiNoiMac>>(DataReader["PhieuTheoDoiNoiMac"].ToString());
                    obj.Col_1 = DataReader["Col_1"].ToString();
                    obj.Col_2 = DataReader["Col_2"].ToString();
                    obj.Col_3 = DataReader["Col_3"].ToString();
                    obj.Col_4 = DataReader["Col_4"].ToString();
                    obj.NgayRaPhoi = DataReader["NgayRaPhoi"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayRaPhoi"].ToString()) : null;
                    obj.GhiChu_P4 = DataReader["GhiChu_P4"].ToString();
                    obj.GhiChu_Text = DataReader["GhiChu_Text"].ToString();
                    obj.PhoiChuyen = DataReader["PhoiChuyen"].ToString();
                    obj.EmbryoGlue = DataReader["EmbryoGlue"].ToString().Equals("1") ? true : false;
                    obj.Tractocil = DataReader["Tractocil"].ToString().Equals("1") ? true : false;
                    obj.PRP = DataReader["PRP"].ToString().Equals("1") ? true : false;
                    obj.Aspirin = DataReader["Aspirin"].ToString();
                    obj.Lovenox = DataReader["Lovenox"].ToString();
                    obj.Progesteron = DataReader["Progesteron"].ToString();
                    obj.KetQuaLABO = DataReader["KetQuaLABO"].ToString();
                    obj.KetQuaDieuTri = DataReader["KetQuaDieuTri"].ToString();
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.LogError(ex);
            }

            return obj;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, BenhAnNgoaiTru_HoTroSinhSan BenhAnNgoaiTru_HoTroSinhSan)
        {
            string sql =
                      @"select MaQuanLy 
                        from BenhAnNgoaiTru_HTSS
                        where MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnNgoaiTru_HoTroSinhSan.MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            int rowCount = 0;
            while (DataReader.Read()) rowCount++;
            if (rowCount == 1) return Update(MyConnection, BenhAnNgoaiTru_HoTroSinhSan);
            sql = @"
                   INSERT INTO BenhAnNgoaiTru_HTSS 
                    (
                        MaQuanLy,
                        ToanThan,
                        TuanHoan,
                        HoHap,
                        TieuHoa,
                        ThanKinh,
                        CoXuongKhop,
                        ThanTietNieuSinhDuc,
                        Khac_CacCoQuan,
                        TomTatKetQuaXetNghiem,
                        BacSyKhamBenh,
                        HoVaTenChong,
                        NgaySinhChong,
                        TuoiChong,
                        TrinhDoHocVanChong,
                        NgheNghiepChong,
                        MaNgheNghiepChong,
                        DanTocChong,
                        MaDanhTocChong,
                        NgoaiKieuChong,
                        MaNgoaiKieuChong,
                        SDTVo,
                        SDTChong,
                        MongCon,
                        TienSuSanKhoaVo,
                        BatDauThayKinh_Nam,
                        BatDauThayKinh_Tuoi,
                        TinhChatKinhNguyet,
                        ChuKy,
                        SoNgayThayKinh,
                        LuongKinh,
                        KinhLanCuoiNgay,
                        DauBung,
                        ThoiGian,
                        LayChongNam,
                        LayChongTuoi,
                        HetKinhNam,
                        HetKinhTuoi,
                        NhungBenhPhuKhoaDaDieuTri,
                        KHHGD,
                        PhuongPhap,
                        BenhLyNoiKhoa,
                        BenhLyNoiKhoa_Text,
                        TienSuHiemMuon,
                        DaTungCoCon,
                        HDTD_SongChungThuongXuyen,
                        HDTD_SoLanGiaoHop,
                        ThoiQuen_HutThuoc,
                        ThoiQuen_Ruou,
                        BenhLyKhac_QuaiBi,
                        BenhLyKhac_NhiemTrungTNSD,
                        BenhLyKhac_Khac,
                        DaDieuTriHiemMuon,
                        DieuTri,
                        Hach,
                        Vu,
                        CacDauHieuSinhDucThuPhat,
                        MoiLon,
                        MoiBe,
                        AmVat,
                        AmHo,
                        MangTrinh,
                        TangSinhMon,
                        AmDao,
                        CoTuCung,
                        ThanTuCung,
                        PhanPhu,
                        CacTuiCung,
                        TheTrang,
                        TinhTrangLong,
                        TimPhoi,
                        TinhHoan,
                        Biu,
                        MaoTinh,
                        ThungTinh,
                        DuongVat,
                        ChanDoanBanDau,
                        DaXuLy,
                        PhacDo,
                        LieuThuoc,
                        ChanDoanKhiRaVien,
                        DieuTri_Tu,
                        DieuTri_Den,
                        NgayTao,
                        GiamDocBenhVien,
                        ChanDoan,
                        PhacDoDieuTri,
                        PhieuTheoDoiNangNoan,
                        PhieuTheoDoiNoiMac,
                        Col_1,
                        Col_2,
                        Col_3,
                        Col_4,
                        NgayRaPhoi,
                        GhiChu_P4,
                        GhiChu_Text,
                        PhoiChuyen,
                        EmbryoGlue,
                        Tractocil,
                        PRP,
                        Aspirin,
                        Lovenox,
                        Progesteron,
                        KetQuaLABO,
                        KetQuaDieuTri
                    )                 
                    VALUES
                    (
                        :MaQuanLy,
                        :ToanThan,
                        :TuanHoan,
                        :HoHap,
                        :TieuHoa,
                        :ThanKinh,
                        :CoXuongKhop,
                        :ThanTietNieuSinhDuc,
                        :Khac_CacCoQuan,
                        :TomTatKetQuaXetNghiem,
                        :BacSyKhamBenh,
                        :HoVaTenChong,
                        :NgaySinhChong,
                        :TuoiChong,
                        :TrinhDoHocVanChong,
                        :NgheNghiepChong,
                        :MaNgheNghiepChong,
                        :DanTocChong,
                        :MaDanhTocChong,
                        :NgoaiKieuChong,
                        :MaNgoaiKieuChong,
                        :SDTVo,
                        :SDTChong,
                        :MongCon,
                        :TienSuSanKhoaVo,
                        :BatDauThayKinh_Nam,
                        :BatDauThayKinh_Tuoi,
                        :TinhChatKinhNguyet,
                        :ChuKy,
                        :SoNgayThayKinh,
                        :LuongKinh,
                        :KinhLanCuoiNgay,
                        :DauBung,
                        :ThoiGian,
                        :LayChongNam,
                        :LayChongTuoi,
                        :HetKinhNam,
                        :HetKinhTuoi,
                        :NhungBenhPhuKhoaDaDieuTri,
                        :KHHGD,
                        :PhuongPhap,
                        :BenhLyNoiKhoa,
                        :BenhLyNoiKhoa_Text,
                        :TienSuHiemMuon,
                        :DaTungCoCon,
                        :HDTD_SongChungThuongXuyen,
                        :HDTD_SoLanGiaoHop,
                        :ThoiQuen_HutThuoc,
                        :ThoiQuen_Ruou,
                        :BenhLyKhac_QuaiBi,
                        :BenhLyKhac_NhiemTrungTNSD,
                        :BenhLyKhac_Khac,
                        :DaDieuTriHiemMuon,
                        :DieuTri,
                        :Hach,
                        :Vu,
                        :CacDauHieuSinhDucThuPhat,
                        :MoiLon,
                        :MoiBe,
                        :AmVat,
                        :AmHo,
                        :MangTrinh,
                        :TangSinhMon,
                        :AmDao,
                        :CoTuCung,
                        :ThanTuCung,
                        :PhanPhu,
                        :CacTuiCung,
                        :TheTrang,
                        :TinhTrangLong,
                        :TimPhoi,
                        :TinhHoan,
                        :Biu,
                        :MaoTinh,
                        :ThungTinh,
                        :DuongVat,
                        :ChanDoanBanDau,
                        :DaXuLy,
                        :PhacDo,
                        :LieuThuoc,
                        :ChanDoanKhiRaVien,
                        :DieuTri_Tu,
                        :DieuTri_Den,
                        :NgayTao,
                        :GiamDocBenhVien,
                        :ChanDoan,
                        :PhacDoDieuTri,
                        :PhieuTheoDoiNangNoan,
                        :PhieuTheoDoiNoiMac,
                        :Col_1,
                        :Col_2,
                        :Col_3,
                        :Col_4,
                        :NgayRaPhoi,
                        :GhiChu_P4,
                        :GhiChu_Text,
                        :PhoiChuyen,
                        :EmbryoGlue,
                        :Tractocil,
                        :PRP,
                        :Aspirin,
                        :Lovenox,
                        :Progesteron,
                        :KetQuaLABO,
                        :KetQuaDieuTri
                    )
                   ";
            Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnNgoaiTru_HoTroSinhSan.MaQuanLy));
            Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnNgoaiTru_HoTroSinhSan.ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoan", BenhAnNgoaiTru_HoTroSinhSan.TuanHoan));
            Command.Parameters.Add(new MDB.MDBParameter("HoHap", BenhAnNgoaiTru_HoTroSinhSan.HoHap));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoa", BenhAnNgoaiTru_HoTroSinhSan.TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinh", BenhAnNgoaiTru_HoTroSinhSan.ThanKinh));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop", BenhAnNgoaiTru_HoTroSinhSan.CoXuongKhop));
            Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieuSinhDuc", BenhAnNgoaiTru_HoTroSinhSan.ThanTietNieuSinhDuc));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_CacCoQuan", BenhAnNgoaiTru_HoTroSinhSan.Khac_CacCoQuan));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQuaXetNghiem", BenhAnNgoaiTru_HoTroSinhSan.TomTatKetQuaXetNghiem));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyKhamBenh", BenhAnNgoaiTru_HoTroSinhSan.BacSyKhamBenh));
            Command.Parameters.Add(new MDB.MDBParameter("HoVaTenChong", BenhAnNgoaiTru_HoTroSinhSan.HoVaTenChong));
            Command.Parameters.Add(new MDB.MDBParameter("NgaySinhChong", BenhAnNgoaiTru_HoTroSinhSan.NgaySinhChong));
            Command.Parameters.Add(new MDB.MDBParameter("TuoiChong", BenhAnNgoaiTru_HoTroSinhSan.TuoiChong));
            Command.Parameters.Add(new MDB.MDBParameter("TrinhDoHocVanChong", BenhAnNgoaiTru_HoTroSinhSan.TrinhDoHocVanChong));
            Command.Parameters.Add(new MDB.MDBParameter("NgheNghiepChong", BenhAnNgoaiTru_HoTroSinhSan.NgheNghiepChong));
            Command.Parameters.Add(new MDB.MDBParameter("MaNgheNghiepChong", BenhAnNgoaiTru_HoTroSinhSan.MaNgheNghiepChong));
            Command.Parameters.Add(new MDB.MDBParameter("DanTocChong", BenhAnNgoaiTru_HoTroSinhSan.DanTocChong));
            Command.Parameters.Add(new MDB.MDBParameter("MaDanhTocChong", BenhAnNgoaiTru_HoTroSinhSan.MaDanhTocChong));
            Command.Parameters.Add(new MDB.MDBParameter("NgoaiKieuChong", BenhAnNgoaiTru_HoTroSinhSan.NgoaiKieuChong));
            Command.Parameters.Add(new MDB.MDBParameter("MaNgoaiKieuChong", BenhAnNgoaiTru_HoTroSinhSan.MaNgoaiKieuChong));
            Command.Parameters.Add(new MDB.MDBParameter("SDTVo", BenhAnNgoaiTru_HoTroSinhSan.SDTVo));
            Command.Parameters.Add(new MDB.MDBParameter("SDTChong", BenhAnNgoaiTru_HoTroSinhSan.SDTChong));
            Command.Parameters.Add(new MDB.MDBParameter("MongCon", BenhAnNgoaiTru_HoTroSinhSan.MongCon));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuSanKhoaVo",JsonConvert.SerializeObject(BenhAnNgoaiTru_HoTroSinhSan.TienSuSanKhoaVo)));
            Command.Parameters.Add(new MDB.MDBParameter("BatDauThayKinh_Nam", BenhAnNgoaiTru_HoTroSinhSan.BatDauThayKinh_Nam));
            Command.Parameters.Add(new MDB.MDBParameter("BatDauThayKinh_Tuoi", BenhAnNgoaiTru_HoTroSinhSan.BatDauThayKinh_Tuoi));
            Command.Parameters.Add(new MDB.MDBParameter("TinhChatKinhNguyet", BenhAnNgoaiTru_HoTroSinhSan.TinhChatKinhNguyet));
            Command.Parameters.Add(new MDB.MDBParameter("ChuKy", BenhAnNgoaiTru_HoTroSinhSan.ChuKy));
            Command.Parameters.Add(new MDB.MDBParameter("SoNgayThayKinh", BenhAnNgoaiTru_HoTroSinhSan.SoNgayThayKinh));
            Command.Parameters.Add(new MDB.MDBParameter("LuongKinh", BenhAnNgoaiTru_HoTroSinhSan.LuongKinh));
            Command.Parameters.Add(new MDB.MDBParameter("KinhLanCuoiNgay", BenhAnNgoaiTru_HoTroSinhSan.KinhLanCuoiNgay));
            Command.Parameters.Add(new MDB.MDBParameter("DauBung", BenhAnNgoaiTru_HoTroSinhSan.DauBung ? 1:0));
            Command.Parameters.Add(new MDB.MDBParameter("ThoiGian", BenhAnNgoaiTru_HoTroSinhSan.ThoiGian));
            Command.Parameters.Add(new MDB.MDBParameter("LayChongNam", BenhAnNgoaiTru_HoTroSinhSan.LayChongNam));
            Command.Parameters.Add(new MDB.MDBParameter("LayChongTuoi", BenhAnNgoaiTru_HoTroSinhSan.LayChongTuoi));
            Command.Parameters.Add(new MDB.MDBParameter("HetKinhNam", BenhAnNgoaiTru_HoTroSinhSan.HetKinhNam));
            Command.Parameters.Add(new MDB.MDBParameter("HetKinhTuoi", BenhAnNgoaiTru_HoTroSinhSan.HetKinhTuoi));
            Command.Parameters.Add(new MDB.MDBParameter("NhungBenhPhuKhoaDaDieuTri", BenhAnNgoaiTru_HoTroSinhSan.NhungBenhPhuKhoaDaDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("KHHGD", BenhAnNgoaiTru_HoTroSinhSan.KHHGD));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhap", BenhAnNgoaiTru_HoTroSinhSan.PhuongPhap));
            Command.Parameters.Add(new MDB.MDBParameter("BenhLyNoiKhoa", BenhAnNgoaiTru_HoTroSinhSan.BenhLyNoiKhoa));
            Command.Parameters.Add(new MDB.MDBParameter("BenhLyNoiKhoa_Text", BenhAnNgoaiTru_HoTroSinhSan.BenhLyNoiKhoa_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuHiemMuon", BenhAnNgoaiTru_HoTroSinhSan.TienSuHiemMuon));
            Command.Parameters.Add(new MDB.MDBParameter("DaTungCoCon", BenhAnNgoaiTru_HoTroSinhSan.DaTungCoCon));
            Command.Parameters.Add(new MDB.MDBParameter("HDTD_SongChungThuongXuyen", BenhAnNgoaiTru_HoTroSinhSan.HDTD_SongChungThuongXuyen));
            Command.Parameters.Add(new MDB.MDBParameter("HDTD_SoLanGiaoHop", BenhAnNgoaiTru_HoTroSinhSan.HDTD_SoLanGiaoHop));
            Command.Parameters.Add(new MDB.MDBParameter("ThoiQuen_HutThuoc", BenhAnNgoaiTru_HoTroSinhSan.ThoiQuen_HutThuoc));
            Command.Parameters.Add(new MDB.MDBParameter("ThoiQuen_Ruou", BenhAnNgoaiTru_HoTroSinhSan.ThoiQuen_Ruou));
            Command.Parameters.Add(new MDB.MDBParameter("BenhLyKhac_QuaiBi", BenhAnNgoaiTru_HoTroSinhSan.BenhLyKhac_QuaiBi));
            Command.Parameters.Add(new MDB.MDBParameter("BenhLyKhac_NhiemTrungTNSD", BenhAnNgoaiTru_HoTroSinhSan.BenhLyKhac_NhiemTrungTNSD));
            Command.Parameters.Add(new MDB.MDBParameter("BenhLyKhac_Khac", BenhAnNgoaiTru_HoTroSinhSan.BenhLyKhac_Khac));
            Command.Parameters.Add(new MDB.MDBParameter("DaDieuTriHiemMuon", BenhAnNgoaiTru_HoTroSinhSan.DaDieuTriHiemMuon));
            Command.Parameters.Add(new MDB.MDBParameter("DieuTri", BenhAnNgoaiTru_HoTroSinhSan.DieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("Hach", BenhAnNgoaiTru_HoTroSinhSan.Hach));
            Command.Parameters.Add(new MDB.MDBParameter("Vu", BenhAnNgoaiTru_HoTroSinhSan.Vu));
            Command.Parameters.Add(new MDB.MDBParameter("CacDauHieuSinhDucThuPhat", BenhAnNgoaiTru_HoTroSinhSan.CacDauHieuSinhDucThuPhat));
            Command.Parameters.Add(new MDB.MDBParameter("MoiLon", BenhAnNgoaiTru_HoTroSinhSan.MoiLon));
            Command.Parameters.Add(new MDB.MDBParameter("MoiBe", BenhAnNgoaiTru_HoTroSinhSan.MoiBe));
            Command.Parameters.Add(new MDB.MDBParameter("AmVat", BenhAnNgoaiTru_HoTroSinhSan.AmVat));
            Command.Parameters.Add(new MDB.MDBParameter("AmHo", BenhAnNgoaiTru_HoTroSinhSan.AmHo));
            Command.Parameters.Add(new MDB.MDBParameter("MangTrinh", BenhAnNgoaiTru_HoTroSinhSan.MangTrinh));
            Command.Parameters.Add(new MDB.MDBParameter("TangSinhMon", BenhAnNgoaiTru_HoTroSinhSan.TangSinhMon));
            Command.Parameters.Add(new MDB.MDBParameter("AmDao", BenhAnNgoaiTru_HoTroSinhSan.AmDao));
            Command.Parameters.Add(new MDB.MDBParameter("CoTuCung", BenhAnNgoaiTru_HoTroSinhSan.CoTuCung));
            Command.Parameters.Add(new MDB.MDBParameter("ThanTuCung", BenhAnNgoaiTru_HoTroSinhSan.ThanTuCung));
            Command.Parameters.Add(new MDB.MDBParameter("PhanPhu", BenhAnNgoaiTru_HoTroSinhSan.PhanPhu));
            Command.Parameters.Add(new MDB.MDBParameter("CacTuiCung", BenhAnNgoaiTru_HoTroSinhSan.CacTuiCung));
            Command.Parameters.Add(new MDB.MDBParameter("TheTrang", BenhAnNgoaiTru_HoTroSinhSan.TheTrang));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangLong", BenhAnNgoaiTru_HoTroSinhSan.TinhTrangLong));
            Command.Parameters.Add(new MDB.MDBParameter("TimPhoi", BenhAnNgoaiTru_HoTroSinhSan.TimPhoi));
            Command.Parameters.Add(new MDB.MDBParameter("TinhHoan", BenhAnNgoaiTru_HoTroSinhSan.TinhHoan));
            Command.Parameters.Add(new MDB.MDBParameter("Biu", BenhAnNgoaiTru_HoTroSinhSan.Biu));
            Command.Parameters.Add(new MDB.MDBParameter("MaoTinh", BenhAnNgoaiTru_HoTroSinhSan.MaoTinh));
            Command.Parameters.Add(new MDB.MDBParameter("ThungTinh", BenhAnNgoaiTru_HoTroSinhSan.ThungTinh));
            Command.Parameters.Add(new MDB.MDBParameter("DuongVat", BenhAnNgoaiTru_HoTroSinhSan.DuongVat));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanBanDau", BenhAnNgoaiTru_HoTroSinhSan.ChanDoanBanDau));
            Command.Parameters.Add(new MDB.MDBParameter("DaXuLy", BenhAnNgoaiTru_HoTroSinhSan.DaXuLy));
            Command.Parameters.Add(new MDB.MDBParameter("PhacDo", BenhAnNgoaiTru_HoTroSinhSan.PhacDo));
            Command.Parameters.Add(new MDB.MDBParameter("LieuThuoc", BenhAnNgoaiTru_HoTroSinhSan.LieuThuoc));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanKhiRaVien", BenhAnNgoaiTru_HoTroSinhSan.ChanDoanKhiRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("DieuTri_Tu", BenhAnNgoaiTru_HoTroSinhSan.DieuTri_Tu));
            Command.Parameters.Add(new MDB.MDBParameter("DieuTri_Den", BenhAnNgoaiTru_HoTroSinhSan.DieuTri_Den));
            Command.Parameters.Add(new MDB.MDBParameter("NgayTao", BenhAnNgoaiTru_HoTroSinhSan.NgayTao));
            Command.Parameters.Add(new MDB.MDBParameter("GiamDocBenhVien", BenhAnNgoaiTru_HoTroSinhSan.GiamDocBenhVien));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", BenhAnNgoaiTru_HoTroSinhSan.ChanDoan));
            Command.Parameters.Add(new MDB.MDBParameter("PhacDoDieuTri", BenhAnNgoaiTru_HoTroSinhSan.PhacDoDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("PhieuTheoDoiNangNoan",JsonConvert.SerializeObject(BenhAnNgoaiTru_HoTroSinhSan.PhieuTheoDoiNangNoan)));
            Command.Parameters.Add(new MDB.MDBParameter("PhieuTheoDoiNoiMac", JsonConvert.SerializeObject(BenhAnNgoaiTru_HoTroSinhSan.PhieuTheoDoiNoiMac)));
            Command.Parameters.Add(new MDB.MDBParameter("Col_1", BenhAnNgoaiTru_HoTroSinhSan.Col_1));
            Command.Parameters.Add(new MDB.MDBParameter("Col_2", BenhAnNgoaiTru_HoTroSinhSan.Col_2));
            Command.Parameters.Add(new MDB.MDBParameter("Col_3", BenhAnNgoaiTru_HoTroSinhSan.Col_3));
            Command.Parameters.Add(new MDB.MDBParameter("Col_4", BenhAnNgoaiTru_HoTroSinhSan.Col_4));
            Command.Parameters.Add(new MDB.MDBParameter("NgayRaPhoi", BenhAnNgoaiTru_HoTroSinhSan.NgayRaPhoi));
            Command.Parameters.Add(new MDB.MDBParameter("GhiChu_P4", BenhAnNgoaiTru_HoTroSinhSan.GhiChu_P4));
            Command.Parameters.Add(new MDB.MDBParameter("GhiChu_Text", BenhAnNgoaiTru_HoTroSinhSan.GhiChu_Text));
            Command.Parameters.Add(new MDB.MDBParameter("PhoiChuyen", BenhAnNgoaiTru_HoTroSinhSan.PhoiChuyen));
            Command.Parameters.Add(new MDB.MDBParameter("EmbryoGlue", BenhAnNgoaiTru_HoTroSinhSan.EmbryoGlue ? 1:0));
            Command.Parameters.Add(new MDB.MDBParameter("Tractocil", BenhAnNgoaiTru_HoTroSinhSan.Tractocil? 1:0));
            Command.Parameters.Add(new MDB.MDBParameter("PRP", BenhAnNgoaiTru_HoTroSinhSan.PRP ? 1:0));
            Command.Parameters.Add(new MDB.MDBParameter("Aspirin", BenhAnNgoaiTru_HoTroSinhSan.Aspirin));
            Command.Parameters.Add(new MDB.MDBParameter("Lovenox", BenhAnNgoaiTru_HoTroSinhSan.Lovenox));
            Command.Parameters.Add(new MDB.MDBParameter("Progesteron", BenhAnNgoaiTru_HoTroSinhSan.Progesteron));
            Command.Parameters.Add(new MDB.MDBParameter("KetQuaLABO", BenhAnNgoaiTru_HoTroSinhSan.KetQuaLABO));
            Command.Parameters.Add(new MDB.MDBParameter("KetQuaDieuTri", BenhAnNgoaiTru_HoTroSinhSan.KetQuaDieuTri));
            Command.BindByName = true;
            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool Update(MDB.MDBConnection MyConnection, BenhAnNgoaiTru_HoTroSinhSan BenhAnNgoaiTru_HoTroSinhSan)
        {
            string sql = @"UPDATE BenhAnNgoaiTru_HTSS SET 
                        ToanThan=:ToanThan,
                        TuanHoan=:TuanHoan,
                        HoHap=:HoHap,
                        TieuHoa=:TieuHoa,
                        ThanKinh=:ThanKinh,
                        CoXuongKhop=:CoXuongKhop,
                        ThanTietNieuSinhDuc=:ThanTietNieuSinhDuc,
                        Khac_CacCoQuan=:Khac_CacCoQuan,
                        TomTatKetQuaXetNghiem=:TomTatKetQuaXetNghiem,
                        BacSyKhamBenh=:BacSyKhamBenh,
                        HoVaTenChong=:HoVaTenChong,
                        NgaySinhChong=:NgaySinhChong,
                        TuoiChong=:TuoiChong,
                        TrinhDoHocVanChong=:TrinhDoHocVanChong,
                        NgheNghiepChong=:NgheNghiepChong,
                        MaNgheNghiepChong=:MaNgheNghiepChong,
                        DanTocChong=:DanTocChong,
                        MaDanhTocChong=:MaDanhTocChong,
                        NgoaiKieuChong=:NgoaiKieuChong,
                        MaNgoaiKieuChong=:MaNgoaiKieuChong,
                        SDTVo=:SDTVo,
                        SDTChong=:SDTChong,
                        MongCon=:MongCon,
                        TienSuSanKhoaVo=:TienSuSanKhoaVo,
                        BatDauThayKinh_Nam=:BatDauThayKinh_Nam,
                        BatDauThayKinh_Tuoi=:BatDauThayKinh_Tuoi,
                        TinhChatKinhNguyet=:TinhChatKinhNguyet,
                        ChuKy=:ChuKy,
                        SoNgayThayKinh=:SoNgayThayKinh,
                        LuongKinh=:LuongKinh,
                        KinhLanCuoiNgay=:KinhLanCuoiNgay,
                        DauBung=:DauBung,
                        ThoiGian=:ThoiGian,
                        LayChongNam=:LayChongNam,
                        LayChongTuoi=:LayChongTuoi,
                        HetKinhNam=:HetKinhNam,
                        HetKinhTuoi=:HetKinhTuoi,
                        NhungBenhPhuKhoaDaDieuTri=:NhungBenhPhuKhoaDaDieuTri,
                        KHHGD=:KHHGD,
                        PhuongPhap=:PhuongPhap,
                        BenhLyNoiKhoa=:BenhLyNoiKhoa,
                        BenhLyNoiKhoa_Text=:BenhLyNoiKhoa_Text,
                        TienSuHiemMuon=:TienSuHiemMuon,
                        DaTungCoCon=:DaTungCoCon,
                        HDTD_SongChungThuongXuyen=:HDTD_SongChungThuongXuyen,
                        HDTD_SoLanGiaoHop=:HDTD_SoLanGiaoHop,
                        ThoiQuen_HutThuoc=:ThoiQuen_HutThuoc,
                        ThoiQuen_Ruou=:ThoiQuen_Ruou,
                        BenhLyKhac_QuaiBi=:BenhLyKhac_QuaiBi,
                        BenhLyKhac_NhiemTrungTNSD=:BenhLyKhac_NhiemTrungTNSD,
                        BenhLyKhac_Khac=:BenhLyKhac_Khac,
                        DaDieuTriHiemMuon=:DaDieuTriHiemMuon,
                        DieuTri=:DieuTri,
                        Hach=:Hach,
                        Vu=:Vu,
                        CacDauHieuSinhDucThuPhat=:CacDauHieuSinhDucThuPhat,
                        MoiLon=:MoiLon,
                        MoiBe=:MoiBe,
                        AmVat=:AmVat,
                        AmHo=:AmHo,
                        MangTrinh=:MangTrinh,
                        TangSinhMon=:TangSinhMon,
                        AmDao=:AmDao,
                        CoTuCung=:CoTuCung,
                        ThanTuCung=:ThanTuCung,
                        PhanPhu=:PhanPhu,
                        CacTuiCung=:CacTuiCung,
                        TheTrang=:TheTrang,
                        TinhTrangLong=:TinhTrangLong,
                        TimPhoi=:TimPhoi,
                        TinhHoan=:TinhHoan,
                        Biu=:Biu,
                        MaoTinh=:MaoTinh,
                        ThungTinh=:ThungTinh,
                        DuongVat=:DuongVat,
                        ChanDoanBanDau=:ChanDoanBanDau,
                        DaXuLy=:DaXuLy,
                        PhacDo=:PhacDo,
                        LieuThuoc=:LieuThuoc,
                        ChanDoanKhiRaVien=:ChanDoanKhiRaVien,
                        DieuTri_Tu=:DieuTri_Tu,
                        DieuTri_Den=:DieuTri_Den,
                        NgayTao=:NgayTao,
                        GiamDocBenhVien=:GiamDocBenhVien,
                        ChanDoan=:ChanDoan,
                        PhacDoDieuTri=:PhacDoDieuTri,
                        PhieuTheoDoiNangNoan=:PhieuTheoDoiNangNoan,
                        PhieuTheoDoiNoiMac=:PhieuTheoDoiNoiMac,
                        Col_1=:Col_1,
                        Col_2=:Col_2,
                        Col_3=:Col_3,
                        Col_4=:Col_4,
                        NgayRaPhoi=:NgayRaPhoi,
                        GhiChu_P4=:GhiChu_P4,
                        GhiChu_Text=:GhiChu_Text,
                        PhoiChuyen=:PhoiChuyen,
                        EmbryoGlue=:EmbryoGlue,
                        Tractocil=:Tractocil,
                        PRP=:PRP,
                        Aspirin=:Aspirin,
                        Lovenox=:Lovenox,
                        Progesteron=:Progesteron,
                        KetQuaLABO=:KetQuaLABO,
                        KetQuaDieuTri=:KetQuaDieuTri
                        WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("ToanThan", BenhAnNgoaiTru_HoTroSinhSan.ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoan", BenhAnNgoaiTru_HoTroSinhSan.TuanHoan));
            Command.Parameters.Add(new MDB.MDBParameter("HoHap", BenhAnNgoaiTru_HoTroSinhSan.HoHap));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoa", BenhAnNgoaiTru_HoTroSinhSan.TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinh", BenhAnNgoaiTru_HoTroSinhSan.ThanKinh));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop", BenhAnNgoaiTru_HoTroSinhSan.CoXuongKhop));
            Command.Parameters.Add(new MDB.MDBParameter("ThanTietNieuSinhDuc", BenhAnNgoaiTru_HoTroSinhSan.ThanTietNieuSinhDuc));
            Command.Parameters.Add(new MDB.MDBParameter("Khac_CacCoQuan", BenhAnNgoaiTru_HoTroSinhSan.Khac_CacCoQuan));
            Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQuaXetNghiem", BenhAnNgoaiTru_HoTroSinhSan.TomTatKetQuaXetNghiem));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyKhamBenh", BenhAnNgoaiTru_HoTroSinhSan.BacSyKhamBenh));
            Command.Parameters.Add(new MDB.MDBParameter("HoVaTenChong", BenhAnNgoaiTru_HoTroSinhSan.HoVaTenChong));
            Command.Parameters.Add(new MDB.MDBParameter("NgaySinhChong", BenhAnNgoaiTru_HoTroSinhSan.NgaySinhChong));
            Command.Parameters.Add(new MDB.MDBParameter("TuoiChong", BenhAnNgoaiTru_HoTroSinhSan.TuoiChong));
            Command.Parameters.Add(new MDB.MDBParameter("TrinhDoHocVanChong", BenhAnNgoaiTru_HoTroSinhSan.TrinhDoHocVanChong));
            Command.Parameters.Add(new MDB.MDBParameter("NgheNghiepChong", BenhAnNgoaiTru_HoTroSinhSan.NgheNghiepChong));
            Command.Parameters.Add(new MDB.MDBParameter("MaNgheNghiepChong", BenhAnNgoaiTru_HoTroSinhSan.MaNgheNghiepChong));
            Command.Parameters.Add(new MDB.MDBParameter("DanTocChong", BenhAnNgoaiTru_HoTroSinhSan.DanTocChong));
            Command.Parameters.Add(new MDB.MDBParameter("MaDanhTocChong", BenhAnNgoaiTru_HoTroSinhSan.MaDanhTocChong));
            Command.Parameters.Add(new MDB.MDBParameter("NgoaiKieuChong", BenhAnNgoaiTru_HoTroSinhSan.NgoaiKieuChong));
            Command.Parameters.Add(new MDB.MDBParameter("MaNgoaiKieuChong", BenhAnNgoaiTru_HoTroSinhSan.MaNgoaiKieuChong));
            Command.Parameters.Add(new MDB.MDBParameter("SDTVo", BenhAnNgoaiTru_HoTroSinhSan.SDTVo));
            Command.Parameters.Add(new MDB.MDBParameter("SDTChong", BenhAnNgoaiTru_HoTroSinhSan.SDTChong));
            Command.Parameters.Add(new MDB.MDBParameter("MongCon", BenhAnNgoaiTru_HoTroSinhSan.MongCon));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuSanKhoaVo", JsonConvert.SerializeObject(BenhAnNgoaiTru_HoTroSinhSan.TienSuSanKhoaVo)));
            Command.Parameters.Add(new MDB.MDBParameter("BatDauThayKinh_Nam", BenhAnNgoaiTru_HoTroSinhSan.BatDauThayKinh_Nam));
            Command.Parameters.Add(new MDB.MDBParameter("BatDauThayKinh_Tuoi", BenhAnNgoaiTru_HoTroSinhSan.BatDauThayKinh_Tuoi));
            Command.Parameters.Add(new MDB.MDBParameter("TinhChatKinhNguyet", BenhAnNgoaiTru_HoTroSinhSan.TinhChatKinhNguyet));
            Command.Parameters.Add(new MDB.MDBParameter("ChuKy", BenhAnNgoaiTru_HoTroSinhSan.ChuKy));
            Command.Parameters.Add(new MDB.MDBParameter("SoNgayThayKinh", BenhAnNgoaiTru_HoTroSinhSan.SoNgayThayKinh));
            Command.Parameters.Add(new MDB.MDBParameter("LuongKinh", BenhAnNgoaiTru_HoTroSinhSan.LuongKinh));
            Command.Parameters.Add(new MDB.MDBParameter("KinhLanCuoiNgay", BenhAnNgoaiTru_HoTroSinhSan.KinhLanCuoiNgay));
            Command.Parameters.Add(new MDB.MDBParameter("DauBung", BenhAnNgoaiTru_HoTroSinhSan.DauBung ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("ThoiGian", BenhAnNgoaiTru_HoTroSinhSan.ThoiGian));
            Command.Parameters.Add(new MDB.MDBParameter("LayChongNam", BenhAnNgoaiTru_HoTroSinhSan.LayChongNam));
            Command.Parameters.Add(new MDB.MDBParameter("LayChongTuoi", BenhAnNgoaiTru_HoTroSinhSan.LayChongTuoi));
            Command.Parameters.Add(new MDB.MDBParameter("HetKinhNam", BenhAnNgoaiTru_HoTroSinhSan.HetKinhNam));
            Command.Parameters.Add(new MDB.MDBParameter("HetKinhTuoi", BenhAnNgoaiTru_HoTroSinhSan.HetKinhTuoi));
            Command.Parameters.Add(new MDB.MDBParameter("NhungBenhPhuKhoaDaDieuTri", BenhAnNgoaiTru_HoTroSinhSan.NhungBenhPhuKhoaDaDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("KHHGD", BenhAnNgoaiTru_HoTroSinhSan.KHHGD));
            Command.Parameters.Add(new MDB.MDBParameter("PhuongPhap", BenhAnNgoaiTru_HoTroSinhSan.PhuongPhap));
            Command.Parameters.Add(new MDB.MDBParameter("BenhLyNoiKhoa", BenhAnNgoaiTru_HoTroSinhSan.BenhLyNoiKhoa));
            Command.Parameters.Add(new MDB.MDBParameter("BenhLyNoiKhoa_Text", BenhAnNgoaiTru_HoTroSinhSan.BenhLyNoiKhoa_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuHiemMuon", BenhAnNgoaiTru_HoTroSinhSan.TienSuHiemMuon));
            Command.Parameters.Add(new MDB.MDBParameter("DaTungCoCon", BenhAnNgoaiTru_HoTroSinhSan.DaTungCoCon));
            Command.Parameters.Add(new MDB.MDBParameter("HDTD_SongChungThuongXuyen", BenhAnNgoaiTru_HoTroSinhSan.HDTD_SongChungThuongXuyen));
            Command.Parameters.Add(new MDB.MDBParameter("HDTD_SoLanGiaoHop", BenhAnNgoaiTru_HoTroSinhSan.HDTD_SoLanGiaoHop));
            Command.Parameters.Add(new MDB.MDBParameter("ThoiQuen_HutThuoc", BenhAnNgoaiTru_HoTroSinhSan.ThoiQuen_HutThuoc));
            Command.Parameters.Add(new MDB.MDBParameter("ThoiQuen_Ruou", BenhAnNgoaiTru_HoTroSinhSan.ThoiQuen_Ruou));
            Command.Parameters.Add(new MDB.MDBParameter("BenhLyKhac_QuaiBi", BenhAnNgoaiTru_HoTroSinhSan.BenhLyKhac_QuaiBi));
            Command.Parameters.Add(new MDB.MDBParameter("BenhLyKhac_NhiemTrungTNSD", BenhAnNgoaiTru_HoTroSinhSan.BenhLyKhac_NhiemTrungTNSD));
            Command.Parameters.Add(new MDB.MDBParameter("BenhLyKhac_Khac", BenhAnNgoaiTru_HoTroSinhSan.BenhLyKhac_Khac));
            Command.Parameters.Add(new MDB.MDBParameter("DaDieuTriHiemMuon", BenhAnNgoaiTru_HoTroSinhSan.DaDieuTriHiemMuon));
            Command.Parameters.Add(new MDB.MDBParameter("DieuTri", BenhAnNgoaiTru_HoTroSinhSan.DieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("Hach", BenhAnNgoaiTru_HoTroSinhSan.Hach));
            Command.Parameters.Add(new MDB.MDBParameter("Vu", BenhAnNgoaiTru_HoTroSinhSan.Vu));
            Command.Parameters.Add(new MDB.MDBParameter("CacDauHieuSinhDucThuPhat", BenhAnNgoaiTru_HoTroSinhSan.CacDauHieuSinhDucThuPhat));
            Command.Parameters.Add(new MDB.MDBParameter("MoiLon", BenhAnNgoaiTru_HoTroSinhSan.MoiLon));
            Command.Parameters.Add(new MDB.MDBParameter("MoiBe", BenhAnNgoaiTru_HoTroSinhSan.MoiBe));
            Command.Parameters.Add(new MDB.MDBParameter("AmVat", BenhAnNgoaiTru_HoTroSinhSan.AmVat));
            Command.Parameters.Add(new MDB.MDBParameter("AmHo", BenhAnNgoaiTru_HoTroSinhSan.AmHo));
            Command.Parameters.Add(new MDB.MDBParameter("MangTrinh", BenhAnNgoaiTru_HoTroSinhSan.MangTrinh));
            Command.Parameters.Add(new MDB.MDBParameter("TangSinhMon", BenhAnNgoaiTru_HoTroSinhSan.TangSinhMon));
            Command.Parameters.Add(new MDB.MDBParameter("AmDao", BenhAnNgoaiTru_HoTroSinhSan.AmDao));
            Command.Parameters.Add(new MDB.MDBParameter("CoTuCung", BenhAnNgoaiTru_HoTroSinhSan.CoTuCung));
            Command.Parameters.Add(new MDB.MDBParameter("ThanTuCung", BenhAnNgoaiTru_HoTroSinhSan.ThanTuCung));
            Command.Parameters.Add(new MDB.MDBParameter("PhanPhu", BenhAnNgoaiTru_HoTroSinhSan.PhanPhu));
            Command.Parameters.Add(new MDB.MDBParameter("CacTuiCung", BenhAnNgoaiTru_HoTroSinhSan.CacTuiCung));
            Command.Parameters.Add(new MDB.MDBParameter("TheTrang", BenhAnNgoaiTru_HoTroSinhSan.TheTrang));
            Command.Parameters.Add(new MDB.MDBParameter("TinhTrangLong", BenhAnNgoaiTru_HoTroSinhSan.TinhTrangLong));
            Command.Parameters.Add(new MDB.MDBParameter("TimPhoi", BenhAnNgoaiTru_HoTroSinhSan.TimPhoi));
            Command.Parameters.Add(new MDB.MDBParameter("TinhHoan", BenhAnNgoaiTru_HoTroSinhSan.TinhHoan));
            Command.Parameters.Add(new MDB.MDBParameter("Biu", BenhAnNgoaiTru_HoTroSinhSan.Biu));
            Command.Parameters.Add(new MDB.MDBParameter("MaoTinh", BenhAnNgoaiTru_HoTroSinhSan.MaoTinh));
            Command.Parameters.Add(new MDB.MDBParameter("ThungTinh", BenhAnNgoaiTru_HoTroSinhSan.ThungTinh));
            Command.Parameters.Add(new MDB.MDBParameter("DuongVat", BenhAnNgoaiTru_HoTroSinhSan.DuongVat));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanBanDau", BenhAnNgoaiTru_HoTroSinhSan.ChanDoanBanDau));
            Command.Parameters.Add(new MDB.MDBParameter("DaXuLy", BenhAnNgoaiTru_HoTroSinhSan.DaXuLy));
            Command.Parameters.Add(new MDB.MDBParameter("PhacDo", BenhAnNgoaiTru_HoTroSinhSan.PhacDo));
            Command.Parameters.Add(new MDB.MDBParameter("LieuThuoc", BenhAnNgoaiTru_HoTroSinhSan.LieuThuoc));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanKhiRaVien", BenhAnNgoaiTru_HoTroSinhSan.ChanDoanKhiRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("DieuTri_Tu", BenhAnNgoaiTru_HoTroSinhSan.DieuTri_Tu));
            Command.Parameters.Add(new MDB.MDBParameter("DieuTri_Den", BenhAnNgoaiTru_HoTroSinhSan.DieuTri_Den));
            Command.Parameters.Add(new MDB.MDBParameter("NgayTao", BenhAnNgoaiTru_HoTroSinhSan.NgayTao));
            Command.Parameters.Add(new MDB.MDBParameter("GiamDocBenhVien", BenhAnNgoaiTru_HoTroSinhSan.GiamDocBenhVien));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", BenhAnNgoaiTru_HoTroSinhSan.ChanDoan));
            Command.Parameters.Add(new MDB.MDBParameter("PhacDoDieuTri", BenhAnNgoaiTru_HoTroSinhSan.PhacDoDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("PhieuTheoDoiNangNoan", JsonConvert.SerializeObject(BenhAnNgoaiTru_HoTroSinhSan.PhieuTheoDoiNangNoan)));
            Command.Parameters.Add(new MDB.MDBParameter("PhieuTheoDoiNoiMac", JsonConvert.SerializeObject(BenhAnNgoaiTru_HoTroSinhSan.PhieuTheoDoiNoiMac)));
            Command.Parameters.Add(new MDB.MDBParameter("Col_1", BenhAnNgoaiTru_HoTroSinhSan.Col_1));
            Command.Parameters.Add(new MDB.MDBParameter("Col_2", BenhAnNgoaiTru_HoTroSinhSan.Col_2));
            Command.Parameters.Add(new MDB.MDBParameter("Col_3", BenhAnNgoaiTru_HoTroSinhSan.Col_3));
            Command.Parameters.Add(new MDB.MDBParameter("Col_4", BenhAnNgoaiTru_HoTroSinhSan.Col_4));
            Command.Parameters.Add(new MDB.MDBParameter("NgayRaPhoi", BenhAnNgoaiTru_HoTroSinhSan.NgayRaPhoi));
            Command.Parameters.Add(new MDB.MDBParameter("GhiChu_P4", BenhAnNgoaiTru_HoTroSinhSan.GhiChu_P4));
            Command.Parameters.Add(new MDB.MDBParameter("GhiChu_Text", BenhAnNgoaiTru_HoTroSinhSan.GhiChu_Text));
            Command.Parameters.Add(new MDB.MDBParameter("PhoiChuyen", BenhAnNgoaiTru_HoTroSinhSan.PhoiChuyen));
            Command.Parameters.Add(new MDB.MDBParameter("EmbryoGlue", BenhAnNgoaiTru_HoTroSinhSan.EmbryoGlue ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("Tractocil", BenhAnNgoaiTru_HoTroSinhSan.Tractocil ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("PRP", BenhAnNgoaiTru_HoTroSinhSan.PRP ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("Aspirin", BenhAnNgoaiTru_HoTroSinhSan.Aspirin));
            Command.Parameters.Add(new MDB.MDBParameter("Lovenox", BenhAnNgoaiTru_HoTroSinhSan.Lovenox));
            Command.Parameters.Add(new MDB.MDBParameter("Progesteron", BenhAnNgoaiTru_HoTroSinhSan.Progesteron));
            Command.Parameters.Add(new MDB.MDBParameter("KetQuaLABO", BenhAnNgoaiTru_HoTroSinhSan.KetQuaLABO));
            Command.Parameters.Add(new MDB.MDBParameter("KetQuaDieuTri", BenhAnNgoaiTru_HoTroSinhSan.KetQuaDieuTri));

            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnNgoaiTru_HoTroSinhSan.MaQuanLy));
            Command.BindByName = true;
            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
    }
}
