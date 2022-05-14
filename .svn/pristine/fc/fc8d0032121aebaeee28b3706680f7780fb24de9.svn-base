using EMR_MAIN.DATABASE.BenhAn;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.BenhAnFunc
{
    public class BenhAnVayNenTheKhopFunc
    {
        public static void WriteXml(MDB.MDBConnection MyConnection)
        {
            string sql =
                   @"
                  select  a.*,  CTScanner HoSo_CTScanner, SieuAm HoSo_SieuAm, XetNghiem HoSo_XetNghiem,  Khac HoSo_Khac,  Khac_Text HoSo_Khac_Text,  ToanBoHoSo HoSo_ToanBoHoSo, Mach DauSinhTon_Mach,  NhietDo DauSinhTon_NhietDo,  HuyetAp DauSinhTon_HuyetAp,  NhipTho DauSinhTon_NhipTho,  CanNang DauSinhTon_CanNang  
                  from BenhAnVayNenTheKhop a inner join thongtindieutri b on a.maquanly = b.maquanly
                  where rownum = 1
                    ";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            var DataTable = new DataTable { TableName = "BenhAnVayNenTheKhop" };
            DataTable.Load(DataReader as IDataReader);
            DataTable.WriteXml("rptBenhAnVayNenTheKhop.xml");
        }
        public static DataSet SelectDataSet(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql =
                   @"
                  select  a.*, f.hovaten BacSiKhamBenhHoVaTen, g.hovaten TK_BacSiKhamBenhHoVaTen, h.hovaten TongKet_BacSyDieuTriHoVaTen, d.hovaten NguoiGiaoHoSoHoVaTen,e.hovaten NguoiNhanHoSoHoVaTen, b.XQuang HoSo_XQuang, b.CTScanner HoSo_CTScanner, b.SieuAm HoSo_SieuAm, b.XetNghiem HoSo_XetNghiem,  b.Khac HoSo_Khac,  b.Khac_Text HoSo_Khac_Text,  b.ToanBoHoSo HoSo_ToanBoHoSo, b.Mach DauSinhTon_Mach, b.NhietDo DauSinhTon_NhietDo,  b.HuyetAp DauSinhTon_HuyetAp,  b.NhipTho DauSinhTon_NhipTho,  b.CanNang DauSinhTon_CanNang  , b.ChieuCao DauSinhTon_ChieuCao, b.BMI DauSinhTon_BMI, b.NgayRaVien 
                        from BenhAnVayNenTheKhop a  
                  left join thongtindieutri b on a.maquanly = b.maquanly 
                  left join nhanvien f on a.BacSiKhamBenh = f.manhanvien
                  left join nhanvien g on a.TK_BacSiKhamBenh = g.manhanvien
                  left join nhanvien h on a.TongKet_BacSyDieuTri = h.manhanvien
                  left join nhanvien d on a.NguoiGiaoHoSo = d.manhanvien
                  left join nhanvien e on a.NguoiNhanHoSo = e.manhanvien where a.maquanly = " + MaQuanLy.ToString(System.Globalization.CultureInfo.InvariantCulture);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(sql, MyConnection);
            var ds = new DataSet();
            adt.Fill(ds, "Table");
            
            return ds;

        }
        public static BenhAnVayNenTheKhop Select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            var obj = new BenhAnVayNenTheKhop();
            try
            {
                #region
                string sql =
                          @"select * 
                        from BenhAnVayNenTheKhop 
                        where MaQuanLy = :MaQuanLy";
                #endregion
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    // Phần chung Hành chính
                    obj.MaQuanLy = DataReader.GetDecimal("MaQuanLy");
                    obj.DieuTriNgoaiTruTu = DataReader["DieuTriNgoaiTruTu"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["DieuTriNgoaiTruTu"]) : null;
                    obj.DieuTriNgoaiTruDen = DataReader["DieuTriNgoaiTruDen"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["DieuTriNgoaiTruDen"]) : null;
                    obj.SoCMND = DataReader["SoCMND"].ToString();
                    obj.BaoHiem = DataReader["BaoHiem"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["BaoHiem"]) : null;
                    obj.ChanDoan_TuyenTruoc = DataReader["ChanDoan_TuyenTruoc"].ToString();
                    obj.ChanDoanBanDau = DataReader["ChanDoanBanDau"].ToString();
                    obj.ChanDoanTaiKham1 = DataReader["ChanDoanTaiKham1"].ToString();
                    obj.ChanDoanTaiKham2 = DataReader["ChanDoanTaiKham2"].ToString();
                    obj.ChanDoanTaiKham3 = DataReader["ChanDoanTaiKham3"].ToString();
                    obj.ChanDoanTaiKham4 = DataReader["ChanDoanTaiKham4"].ToString();
                    obj.BenhPhu = DataReader["BenhPhu"].ToString();
                    obj.KetQuaDieuTri = DataReader.GetInt("KetQuaDieuTri");
                    obj.BienChung_Text = DataReader["BienChung_Text"].ToString();
                    obj.GDPhongKeHoach = DataReader["GDPhongKeHoach"].ToString();
                    obj.GDPhongKhamBenh = DataReader["GDPhongKhamBenh"].ToString();

                    // hỏi bệnh, tái khám
                    obj.ThoiGianKhoiPhat = DataReader["ThoiGianKhoiPhat"].ToString();
                    obj.ViTriKhoiPhat = DataReader["ViTriKhoiPhat"].ToString();
                    obj.TrieuChungDauTien = DataReader["TrieuChungDauTien"].ToString();
                    obj.NhapVienLan = DataReader["NhapVienLan"].ToString();
                    obj.BenhVayNen_Xuan = DataReader.GetInt("BenhVayNen_Xuan");
                    obj.BenhVayNen_Ha = DataReader.GetInt("BenhVayNen_Ha");
                    obj.BenhVayNen_Thu = DataReader.GetInt("BenhVayNen_Thu");
                    obj.BenhVayNen_Dong = DataReader.GetInt("BenhVayNen_Dong");
                    obj.QuaTrinhDieuTri = DataReader["QuaTrinhDieuTri"].ToString();
                    obj.BenhKhac = DataReader["BenhKhac"].ToString();
                    obj.ThoiQuenCaNhan = DataReader["ThoiQuenCaNhan"].ToString();
                    obj.YeuToTinhThan = DataReader["YeuToTinhThan"].ToString();
                    obj.TienSuGiaDinhMacVN = DataReader.GetInt("TienSuGiaDinhMacVN");
                    obj.TienSuGiaDinhMacVN_Co = DataReader["TienSuGiaDinhMacVN_Co"].ToString();
                    obj.TienSuGiaDinh_Xuan = DataReader.GetInt("TienSuGiaDinh_Xuan");
                    obj.TienSuGiaDinh_Ha = DataReader.GetInt("TienSuGiaDinh_Ha");
                    obj.TienSuGiaDinh_Thu = DataReader.GetInt("TienSuGiaDinh_Thu");
                    obj.TienSuGiaDinh_Dong = DataReader.GetInt("TienSuGiaDinh_Dong");
                    obj.PEST_1 = DataReader.GetInt("PEST_1");
                    obj.PEST_2 = DataReader.GetInt("PEST_2");
                    obj.PEST_3 = DataReader.GetInt("PEST_3");
                    obj.PEST_4 = DataReader.GetInt("PEST_4");
                    obj.PEST_5 = DataReader.GetInt("PEST_5");
                    obj.NguyCoMacBenhDongMac = DataReader.GetInt("NguyCoMacBenhDongMac");
                    obj.NhietDo = DataReader["NhietDo"].ToString();
                    obj.Mach = DataReader["Mach"].ToString();
                    obj.HA = DataReader["HA"].ToString();
                    obj.Can = DataReader["Can"].ToString();
                    obj.Cao = DataReader["Cao"].ToString();
                    obj.TrieuChungCoNang = DataReader["TrieuChungCoNang"].ToString();
                    obj.TonThuongDa = DataReader.GetInt("TonThuongDa");
                    obj.TonThuongDa_BieuHien = DataReader["TonThuongDa_BieuHien"].ToString();
                    obj.TonThuongDa_TongDiemPASI = DataReader["TonThuongDa_TongDiemPASI"].ToString();
                    obj.BieuHienMong = DataReader.GetInt("BieuHienMong");
                    obj.BieuHienMong_BieuHien = DataReader["BieuHienMong_BieuHien"].ToString();
                    obj.BieuHienMong_TongDiemPASI = DataReader["BieuHienMong_TongDiemPASI"].ToString();
                    obj.SoKhopDau = DataReader["SoKhopDau"].ToString();
                    obj.SoKhopSung = DataReader["SoKhopSung"].ToString();
                    obj.DAS28 = DataReader["DAS28"].ToString();
                    obj.ViemMotKhop = DataReader.GetInt("ViemMotKhop");
                    obj.ViemKhopCotSong = DataReader.GetInt("ViemKhopCotSong");
                    obj.ViemDaKhopLoaiBienDang = DataReader.GetInt("ViemDaKhopLoaiBienDang");
                    obj.BienDangKhop = DataReader.GetInt("BienDangKhop");
                    obj.LoaiBienDang = DataReader["LoaiBienDang"].ToString();
                    obj.BieuHienNiemMac = DataReader.GetInt("BieuHienNiemMac");
                    obj.BieuHienNiemMac_ViTri = DataReader["BieuHienNiemMac_ViTri"].ToString();
                    obj.TimMach = DataReader["TimMach"].ToString();
                    obj.HoHap = DataReader["HoHap"].ToString();
                    obj.TieuHoa = DataReader["TieuHoa"].ToString();
                    obj.TamThan = DataReader["TamThan"].ToString();
                    obj.DiemDLQI = DataReader["DiemDLQI"].ToString();
                    obj.GhiChu = DataReader["GhiChu"].ToString();
                    obj.Diem_HAQ = DataReader["Diem_HAQ"].ToString();
                    obj.ChucNangKhop = DataReader.GetInt("ChucNangKhop");
                    obj.MucDoTrieuChung = DataReader.GetInt("MucDoTrieuChung");
                    obj.TieuChuanViemKhop_Diem = DataReader["TieuChuanViemKhop_Diem"].ToString();
                    obj.DieuTri_CuThe = DataReader["DieuTri_CuThe"].ToString();
                    obj.HenKhamLai = DataReader["HenKhamLai"] != DBNull.Value ? (DateTime?) Convert.ToDateTime(DataReader["HenKhamLai"]) : null;
                    obj.BacSiKhamBenh = DataReader["BacSiKhamBenh"].ToString();
                    obj.TK_HoTen = DataReader["TK_HoTen"].ToString();
                    obj.TK_SoBenhAnDienTu = DataReader["TK_SoBenhAnDienTu"].ToString();
                    obj.TK_Ngay = DataReader["TK_Ngay"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["TK_Ngay"]) : null;
                    obj.TK_SoLuuTru = DataReader["TK_SoLuuTru"].ToString();
                    obj.TK_NhietDo = DataReader["TK_NhietDo"].ToString();
                    obj.TK_Mach = DataReader["TK_Mach"].ToString();
                    obj.TK_HA = DataReader["TK_HA"].ToString();
                    obj.TK_Can = DataReader["TK_Can"].ToString();
                    obj.TK_Cao = DataReader["TK_Cao"].ToString();
                    obj.TK_TrieuChungCoNang = DataReader["TK_TrieuChungCoNang"].ToString();
                    obj.TK_TienSu = DataReader["TK_TienSu"].ToString();
                    obj.TK_TonThuongDa = DataReader["TK_TonThuongDa"].ToString();
                    obj.TK_TongDiemPASI = DataReader["TK_TongDiemPASI"].ToString();
                    obj.TK_TonThuongMong = DataReader["TK_TonThuongMong"].ToString();
                    obj.TK_SoKhopDau = DataReader["TK_SoKhopDau"].ToString();
                    obj.TK_SoKhopSung = DataReader["TK_SoKhopSung"].ToString();
                    obj.TK_DAS28 = DataReader["TK_DAS28"].ToString();
                    obj.TK_ViemMotKhop = DataReader.GetInt("TK_ViemMotKhop");
                    obj.TK_ViemKhopCotSong = DataReader.GetInt("TK_ViemKhopCotSong");
                    obj.TK_ViemDaKhopLoaiBienDang = DataReader.GetInt("TK_ViemDaKhopLoaiBienDang");
                    obj.TK_BienDangKhop = DataReader.GetInt("TK_BienDangKhop");
                    obj.TK_LoaiBienDang = DataReader["TK_LoaiBienDang"].ToString();
                    obj.TK_ChucNangKhop = DataReader.GetInt("TK_ChucNangKhop");
                    obj.TK_MucDoTrieuChung = DataReader.GetInt("TK_MucDoTrieuChung");
                    obj.TK_BieuHienNiemMac = DataReader.GetInt("TK_BieuHienNiemMac");
                    obj.TK_BieuHienNiemMac_ViTri = DataReader["TK_BieuHienNiemMac_ViTri"].ToString();
                    obj.TK_TimMach = DataReader["TK_TimMach"].ToString();
                    obj.TK_HoHap = DataReader["TK_HoHap"].ToString();
                    obj.TK_TieuHoa = DataReader["TK_TieuHoa"].ToString();
                    obj.TK_TamThan = DataReader["TK_TamThan"].ToString();
                    obj.TK_LamSangKhac = DataReader["TK_LamSangKhac"].ToString();
                    obj.TK_TacDungPhuCuaThuoc = DataReader["TK_TacDungPhuCuaThuoc"].ToString();
                    obj.TK_GhiChu = DataReader["TK_GhiChu"].ToString();
                    obj.TK_DieuTri = DataReader["TK_DieuTri"].ToString();
                    obj.TK_HenKhamLai = DataReader["TK_HenKhamLai"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["TK_HenKhamLai"]) : null;
                    obj.TK_BacSiKhamBenh = DataReader["TK_BacSiKhamBenh"].ToString();

                    // phần tổng kết
                    obj.QuaTrinhBenhLy = DataReader["QuaTrinhBenhLy"].ToString();
                    obj.TomTatKetQua = DataReader["TomTatKetQua"].ToString();
                    obj.BenhChinh = DataReader["BenhChinh"].ToString();
                    obj.MaBenhChinh = DataReader["MaBenhChinh"].ToString();
                    obj.BenhKemTheo = DataReader["BenhKemTheo"].ToString();
                    obj.MaBenhKemTheo = DataReader["MaBenhKemTheo"].ToString();
                    obj.PhuongPhapDieuTri = DataReader["PhuongPhapDieuTri"].ToString();
                    obj.TinhTrangRaVien = DataReader["TinhTrangRaVien"].ToString();
                    obj.HuongDieuTri = DataReader["HuongDieuTri"].ToString();
                    obj.NguoiNhanHoSo = DataReader["NguoiNhanHoSo"].ToString();
                    obj.NguoiGiaoHoSo = DataReader["NguoiGiaoHoSo"].ToString();
                    obj.NgayTongKet = DataReader["NgayTongKet"] != DBNull.Value ? Convert.ToDateTime(DataReader["NgayTongKet"]) : DateTime.Now;
                    obj.TongKet_BacSyDieuTri = DataReader["TongKet_BacSyDieuTri"].ToString();
                    obj.TongKet_MaBacSyDieuTri = DataReader["TongKet_MaBacSyDieuTri"].ToString();
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return obj;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, BenhAnVayNenTheKhop BenhAnVayNenTheKhop)
        {
            try
            {
                string sql =
                          @"select MaQuanLy 
                            from BenhAnVayNenTheKhop
                            where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnVayNenTheKhop.MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                int rowCount = 0;
                while (DataReader.Read()) rowCount++;
                if (rowCount == 1) return Update(MyConnection, BenhAnVayNenTheKhop);
                sql = @"
                       INSERT INTO BenhAnVayNenTheKhop 
                        (
                            MaQuanLy,
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
                            ThoiGianKhoiPhat,
                            ViTriKhoiPhat,
                            TrieuChungDauTien,
                            NhapVienLan,
                            BenhVayNen_Xuan,
                            BenhVayNen_Ha,
                            BenhVayNen_Thu,
                            BenhVayNen_Dong,
                            QuaTrinhDieuTri,
                            BenhKhac,
                            ThoiQuenCaNhan,
                            YeuToTinhThan,
                            TienSuGiaDinhMacVN,
                            TienSuGiaDinhMacVN_Co,
                            TienSuGiaDinh_Xuan,
                            TienSuGiaDinh_Ha,
                            TienSuGiaDinh_Thu,
                            TienSuGiaDinh_Dong,
                            PEST_1,
                            PEST_2,
                            PEST_3,
                            PEST_4,
                            PEST_5,
                            NguyCoMacBenhDongMac,
                            NhietDo,
                            Mach,
                            HA,
                            Can,
                            Cao,
                            TrieuChungCoNang,
                            TonThuongDa,
                            TonThuongDa_BieuHien,
                            TonThuongDa_TongDiemPASI,
                            BieuHienMong,
                            BieuHienMong_BieuHien,
                            BieuHienMong_TongDiemPASI,
                            SoKhopDau,
                            SoKhopSung,
                            DAS28,
                            ViemMotKhop,
                            ViemKhopCotSong,
                            ViemDaKhopLoaiBienDang,
                            BienDangKhop,
                            LoaiBienDang,
                            BieuHienNiemMac,
                            BieuHienNiemMac_ViTri,
                            TimMach,
                            HoHap,
                            TieuHoa,
                            TamThan,
                            DiemDLQI,
                            GhiChu,
                            Diem_HAQ,
                            ChucNangKhop,
                            MucDoTrieuChung,
                            TieuChuanViemKhop_Diem,
                            DieuTri_CuThe,
                            HenKhamLai,
                            BacSiKhamBenh,
                            TK_HoTen,
                            TK_SoBenhAnDienTu,
                            TK_Ngay,
                            TK_SoLuuTru,
                            TK_NhietDo,
                            TK_Mach,
                            TK_HA,
                            TK_Can,
                            TK_Cao,
                            TK_TrieuChungCoNang,
                            TK_TienSu,
                            TK_TonThuongDa,
                            TK_TongDiemPASI,
                            TK_TonThuongMong,
                            TK_SoKhopDau,
                            TK_SoKhopSung,
                            TK_DAS28,
                            TK_ViemMotKhop,
                            TK_ViemKhopCotSong,
                            TK_ViemDaKhopLoaiBienDang,
                            TK_BienDangKhop,
                            TK_LoaiBienDang,
                            TK_ChucNangKhop,
                            TK_MucDoTrieuChung,
                            TK_BieuHienNiemMac,
                            TK_BieuHienNiemMac_ViTri,
                            TK_TimMach,
                            TK_HoHap,
                            TK_TieuHoa,
                            TK_TamThan,
                            TK_LamSangKhac,
                            TK_TacDungPhuCuaThuoc,
                            TK_GhiChu,
                            TK_DieuTri,
                            TK_HenKhamLai,
                            TK_BacSiKhamBenh,
                            QuaTrinhBenhLy,
                            TomTatKetQua,
                            BenhChinh,
                            MaBenhChinh,
                            BenhKemTheo,
                            MaBenhKemTheo,
                            PhuongPhapDieuTri,
                            TinhTrangRaVien,
                            HuongDieuTri,
                            NguoiNhanHoSo,
                            NguoiGiaoHoSo,
                            NgayTongKet,
                            TongKet_BacSyDieuTri,
                            TongKet_MaBacSyDieuTri
                        )                 
                        VALUES
                        (
                            :MaQuanLy,
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
                            :ThoiGianKhoiPhat,
                            :ViTriKhoiPhat,
                            :TrieuChungDauTien,
                            :NhapVienLan,
                            :BenhVayNen_Xuan,
                            :BenhVayNen_Ha,
                            :BenhVayNen_Thu,
                            :BenhVayNen_Dong,
                            :QuaTrinhDieuTri,
                            :BenhKhac,
                            :ThoiQuenCaNhan,
                            :YeuToTinhThan,
                            :TienSuGiaDinhMacVN,
                            :TienSuGiaDinhMacVN_Co,
                            :TienSuGiaDinh_Xuan,
                            :TienSuGiaDinh_Ha,
                            :TienSuGiaDinh_Thu,
                            :TienSuGiaDinh_Dong,
                            :PEST_1,
                            :PEST_2,
                            :PEST_3,
                            :PEST_4,
                            :PEST_5,
                            :NguyCoMacBenhDongMac,
                            :NhietDo,
                            :Mach,
                            :HA,
                            :Can,
                            :Cao,
                            :TrieuChungCoNang,
                            :TonThuongDa,
                            :TonThuongDa_BieuHien,
                            :TonThuongDa_TongDiemPASI,
                            :BieuHienMong,
                            :BieuHienMong_BieuHien,
                            :BieuHienMong_TongDiemPASI,
                            :SoKhopDau,
                            :SoKhopSung,
                            :DAS28,
                            :ViemMotKhop,
                            :ViemKhopCotSong,
                            :ViemDaKhopLoaiBienDang,
                            :BienDangKhop,
                            :LoaiBienDang,
                            :BieuHienNiemMac,
                            :BieuHienNiemMac_ViTri,
                            :TimMach,
                            :HoHap,
                            :TieuHoa,
                            :TamThan,
                            :DiemDLQI,
                            :GhiChu,
                            :Diem_HAQ,
                            :ChucNangKhop,
                            :MucDoTrieuChung,
                            :TieuChuanViemKhop_Diem,
                            :DieuTri_CuThe,
                            :HenKhamLai,
                            :BacSiKhamBenh,
                            :TK_HoTen,
                            :TK_SoBenhAnDienTu,
                            :TK_Ngay,
                            :TK_SoLuuTru,
                            :TK_NhietDo,
                            :TK_Mach,
                            :TK_HA,
                            :TK_Can,
                            :TK_Cao,
                            :TK_TrieuChungCoNang,
                            :TK_TienSu,
                            :TK_TonThuongDa,
                            :TK_TongDiemPASI,
                            :TK_TonThuongMong,
                            :TK_SoKhopDau,
                            :TK_SoKhopSung,
                            :TK_DAS28,
                            :TK_ViemMotKhop,
                            :TK_ViemKhopCotSong,
                            :TK_ViemDaKhopLoaiBienDang,
                            :TK_BienDangKhop,
                            :TK_LoaiBienDang,
                            :TK_ChucNangKhop,
                            :TK_MucDoTrieuChung,
                            :TK_BieuHienNiemMac,
                            :TK_BieuHienNiemMac_ViTri,
                            :TK_TimMach,
                            :TK_HoHap,
                            :TK_TieuHoa,
                            :TK_TamThan,
                            :TK_LamSangKhac,
                            :TK_TacDungPhuCuaThuoc,
                            :TK_GhiChu,
                            :TK_DieuTri,
                            :TK_HenKhamLai,
                            :TK_BacSiKhamBenh,
                            :QuaTrinhBenhLy,
                            :TomTatKetQua,
                            :BenhChinh,
                            :MaBenhChinh,
                            :BenhKemTheo,
                            :MaBenhKemTheo,
                            :PhuongPhapDieuTri,
                            :TinhTrangRaVien,
                            :HuongDieuTri,
                            :NguoiNhanHoSo,
                            :NguoiGiaoHoSo,
                            :NgayTongKet,
                            :TongKet_BacSyDieuTri,
                            :TongKet_MaBacSyDieuTri                          
                        )";
                Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnVayNenTheKhop.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriNgoaiTruTu", BenhAnVayNenTheKhop.DieuTriNgoaiTruTu));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriNgoaiTruDen", BenhAnVayNenTheKhop.DieuTriNgoaiTruDen));
                Command.Parameters.Add(new MDB.MDBParameter("SoCMND", BenhAnVayNenTheKhop.SoCMND));
                Command.Parameters.Add(new MDB.MDBParameter("BaoHiem", BenhAnVayNenTheKhop.BaoHiem));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan_TuyenTruoc", BenhAnVayNenTheKhop.ChanDoan_TuyenTruoc));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanBanDau", BenhAnVayNenTheKhop.ChanDoanBanDau));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham1", BenhAnVayNenTheKhop.ChanDoanTaiKham1));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham2", BenhAnVayNenTheKhop.ChanDoanTaiKham2));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham3", BenhAnVayNenTheKhop.ChanDoanTaiKham3));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham4", BenhAnVayNenTheKhop.ChanDoanTaiKham4));
                Command.Parameters.Add(new MDB.MDBParameter("BenhPhu", BenhAnVayNenTheKhop.BenhPhu));
                Command.Parameters.Add(new MDB.MDBParameter("KetQuaDieuTri", BenhAnVayNenTheKhop.KetQuaDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("BienChung_Text", BenhAnVayNenTheKhop.BienChung_Text));
                Command.Parameters.Add(new MDB.MDBParameter("GDPhongKeHoach", BenhAnVayNenTheKhop.GDPhongKeHoach));
                Command.Parameters.Add(new MDB.MDBParameter("GDPhongKhamBenh", BenhAnVayNenTheKhop.GDPhongKhamBenh));

                // hỏi bệnh, khám bệnh
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianKhoiPhat", BenhAnVayNenTheKhop.ThoiGianKhoiPhat));
                Command.Parameters.Add(new MDB.MDBParameter("ViTriKhoiPhat", BenhAnVayNenTheKhop.ViTriKhoiPhat));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungDauTien", BenhAnVayNenTheKhop.TrieuChungDauTien));
                Command.Parameters.Add(new MDB.MDBParameter("NhapVienLan", BenhAnVayNenTheKhop.NhapVienLan));
                Command.Parameters.Add(new MDB.MDBParameter("BenhVayNen_Xuan", BenhAnVayNenTheKhop.BenhVayNen_Xuan));
                Command.Parameters.Add(new MDB.MDBParameter("BenhVayNen_Ha", BenhAnVayNenTheKhop.BenhVayNen_Ha));
                Command.Parameters.Add(new MDB.MDBParameter("BenhVayNen_Thu", BenhAnVayNenTheKhop.BenhVayNen_Thu));
                Command.Parameters.Add(new MDB.MDBParameter("BenhVayNen_Dong", BenhAnVayNenTheKhop.BenhVayNen_Dong));
                Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhDieuTri", BenhAnVayNenTheKhop.QuaTrinhDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("BenhKhac", BenhAnVayNenTheKhop.BenhKhac));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiQuenCaNhan", BenhAnVayNenTheKhop.ThoiQuenCaNhan));
                Command.Parameters.Add(new MDB.MDBParameter("YeuToTinhThan", BenhAnVayNenTheKhop.YeuToTinhThan));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuGiaDinhMacVN", BenhAnVayNenTheKhop.TienSuGiaDinhMacVN));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuGiaDinhMacVN_Co", BenhAnVayNenTheKhop.TienSuGiaDinhMacVN_Co));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuGiaDinh_Xuan", BenhAnVayNenTheKhop.TienSuGiaDinh_Xuan));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuGiaDinh_Ha", BenhAnVayNenTheKhop.TienSuGiaDinh_Ha));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuGiaDinh_Thu", BenhAnVayNenTheKhop.TienSuGiaDinh_Thu));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuGiaDinh_Dong", BenhAnVayNenTheKhop.TienSuGiaDinh_Dong));
                Command.Parameters.Add(new MDB.MDBParameter("PEST_1", BenhAnVayNenTheKhop.PEST_1));
                Command.Parameters.Add(new MDB.MDBParameter("PEST_2", BenhAnVayNenTheKhop.PEST_2));
                Command.Parameters.Add(new MDB.MDBParameter("PEST_3", BenhAnVayNenTheKhop.PEST_3));
                Command.Parameters.Add(new MDB.MDBParameter("PEST_4", BenhAnVayNenTheKhop.PEST_4));
                Command.Parameters.Add(new MDB.MDBParameter("PEST_5", BenhAnVayNenTheKhop.PEST_5));
                Command.Parameters.Add(new MDB.MDBParameter("NguyCoMacBenhDongMac", BenhAnVayNenTheKhop.NguyCoMacBenhDongMac));
                Command.Parameters.Add(new MDB.MDBParameter("NhietDo", BenhAnVayNenTheKhop.NhietDo));
                Command.Parameters.Add(new MDB.MDBParameter("Mach", BenhAnVayNenTheKhop.Mach));
                Command.Parameters.Add(new MDB.MDBParameter("HA", BenhAnVayNenTheKhop.HA));
                Command.Parameters.Add(new MDB.MDBParameter("Can", BenhAnVayNenTheKhop.Can));
                Command.Parameters.Add(new MDB.MDBParameter("Cao", BenhAnVayNenTheKhop.Cao));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungCoNang", BenhAnVayNenTheKhop.TrieuChungCoNang));
                Command.Parameters.Add(new MDB.MDBParameter("TonThuongDa", BenhAnVayNenTheKhop.TonThuongDa));
                Command.Parameters.Add(new MDB.MDBParameter("TonThuongDa_BieuHien", BenhAnVayNenTheKhop.TonThuongDa_BieuHien));
                Command.Parameters.Add(new MDB.MDBParameter("TonThuongDa_TongDiemPASI", BenhAnVayNenTheKhop.TonThuongDa_TongDiemPASI));
                Command.Parameters.Add(new MDB.MDBParameter("BieuHienMong", BenhAnVayNenTheKhop.BieuHienMong));
                Command.Parameters.Add(new MDB.MDBParameter("BieuHienMong_BieuHien", BenhAnVayNenTheKhop.BieuHienMong_BieuHien));
                Command.Parameters.Add(new MDB.MDBParameter("BieuHienMong_TongDiemPASI", BenhAnVayNenTheKhop.BieuHienMong_TongDiemPASI));
                Command.Parameters.Add(new MDB.MDBParameter("SoKhopDau", BenhAnVayNenTheKhop.SoKhopDau));
                Command.Parameters.Add(new MDB.MDBParameter("SoKhopSung", BenhAnVayNenTheKhop.SoKhopSung));
                Command.Parameters.Add(new MDB.MDBParameter("DAS28", BenhAnVayNenTheKhop.DAS28));
                Command.Parameters.Add(new MDB.MDBParameter("ViemMotKhop", BenhAnVayNenTheKhop.ViemMotKhop));
                Command.Parameters.Add(new MDB.MDBParameter("ViemKhopCotSong", BenhAnVayNenTheKhop.ViemKhopCotSong));
                Command.Parameters.Add(new MDB.MDBParameter("ViemDaKhopLoaiBienDang", BenhAnVayNenTheKhop.ViemDaKhopLoaiBienDang));
                Command.Parameters.Add(new MDB.MDBParameter("BienDangKhop", BenhAnVayNenTheKhop.BienDangKhop));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiBienDang", BenhAnVayNenTheKhop.LoaiBienDang));
                Command.Parameters.Add(new MDB.MDBParameter("BieuHienNiemMac", BenhAnVayNenTheKhop.BieuHienNiemMac));
                Command.Parameters.Add(new MDB.MDBParameter("BieuHienNiemMac_ViTri", BenhAnVayNenTheKhop.BieuHienNiemMac_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("TimMach", BenhAnVayNenTheKhop.TimMach));
                Command.Parameters.Add(new MDB.MDBParameter("HoHap", BenhAnVayNenTheKhop.HoHap));
                Command.Parameters.Add(new MDB.MDBParameter("TieuHoa", BenhAnVayNenTheKhop.TieuHoa));
                Command.Parameters.Add(new MDB.MDBParameter("TamThan", BenhAnVayNenTheKhop.TamThan));
                Command.Parameters.Add(new MDB.MDBParameter("DiemDLQI", BenhAnVayNenTheKhop.DiemDLQI));
                Command.Parameters.Add(new MDB.MDBParameter("GhiChu", BenhAnVayNenTheKhop.GhiChu));
                Command.Parameters.Add(new MDB.MDBParameter("Diem_HAQ", BenhAnVayNenTheKhop.Diem_HAQ));
                Command.Parameters.Add(new MDB.MDBParameter("ChucNangKhop", BenhAnVayNenTheKhop.ChucNangKhop));
                Command.Parameters.Add(new MDB.MDBParameter("MucDoTrieuChung", BenhAnVayNenTheKhop.MucDoTrieuChung));
                Command.Parameters.Add(new MDB.MDBParameter("TieuChuanViemKhop_Diem", BenhAnVayNenTheKhop.TieuChuanViemKhop_Diem));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_CuThe", BenhAnVayNenTheKhop.DieuTri_CuThe));
                Command.Parameters.Add(new MDB.MDBParameter("HenKhamLai", BenhAnVayNenTheKhop.HenKhamLai));
                Command.Parameters.Add(new MDB.MDBParameter("BacSiKhamBenh", BenhAnVayNenTheKhop.BacSiKhamBenh));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HoTen", BenhAnVayNenTheKhop.TK_HoTen));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SoBenhAnDienTu", BenhAnVayNenTheKhop.TK_SoBenhAnDienTu));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Ngay", BenhAnVayNenTheKhop.TK_Ngay));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SoLuuTru", BenhAnVayNenTheKhop.TK_SoLuuTru));
                Command.Parameters.Add(new MDB.MDBParameter("TK_NhietDo", BenhAnVayNenTheKhop.TK_NhietDo));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Mach", BenhAnVayNenTheKhop.TK_Mach));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HA", BenhAnVayNenTheKhop.TK_HA));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Can", BenhAnVayNenTheKhop.TK_Can));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Cao", BenhAnVayNenTheKhop.TK_Cao));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TrieuChungCoNang", BenhAnVayNenTheKhop.TK_TrieuChungCoNang));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TienSu", BenhAnVayNenTheKhop.TK_TienSu));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TonThuongDa", BenhAnVayNenTheKhop.TK_TonThuongDa));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TongDiemPASI", BenhAnVayNenTheKhop.TK_TongDiemPASI));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TonThuongMong", BenhAnVayNenTheKhop.TK_TonThuongMong));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SoKhopDau", BenhAnVayNenTheKhop.TK_SoKhopDau));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SoKhopSung", BenhAnVayNenTheKhop.TK_SoKhopSung));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DAS28", BenhAnVayNenTheKhop.TK_DAS28));
                Command.Parameters.Add(new MDB.MDBParameter("TK_ViemMotKhop", BenhAnVayNenTheKhop.TK_ViemMotKhop));
                Command.Parameters.Add(new MDB.MDBParameter("TK_ViemKhopCotSong", BenhAnVayNenTheKhop.TK_ViemKhopCotSong));
                Command.Parameters.Add(new MDB.MDBParameter("TK_ViemDaKhopLoaiBienDang", BenhAnVayNenTheKhop.TK_ViemDaKhopLoaiBienDang));
                Command.Parameters.Add(new MDB.MDBParameter("TK_BienDangKhop", BenhAnVayNenTheKhop.TK_BienDangKhop));
                Command.Parameters.Add(new MDB.MDBParameter("TK_LoaiBienDang", BenhAnVayNenTheKhop.TK_LoaiBienDang));
                Command.Parameters.Add(new MDB.MDBParameter("TK_ChucNangKhop", BenhAnVayNenTheKhop.TK_ChucNangKhop));
                Command.Parameters.Add(new MDB.MDBParameter("TK_MucDoTrieuChung", BenhAnVayNenTheKhop.TK_MucDoTrieuChung));
                Command.Parameters.Add(new MDB.MDBParameter("TK_BieuHienNiemMac", BenhAnVayNenTheKhop.TK_BieuHienNiemMac));
                Command.Parameters.Add(new MDB.MDBParameter("TK_BieuHienNiemMac_ViTri", BenhAnVayNenTheKhop.TK_BieuHienNiemMac_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TimMach", BenhAnVayNenTheKhop.TK_TimMach));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HoHap", BenhAnVayNenTheKhop.TK_HoHap));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TieuHoa", BenhAnVayNenTheKhop.TK_TieuHoa));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TamThan", BenhAnVayNenTheKhop.TK_TamThan));
                Command.Parameters.Add(new MDB.MDBParameter("TK_LamSangKhac", BenhAnVayNenTheKhop.TK_LamSangKhac));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TacDungPhuCuaThuoc", BenhAnVayNenTheKhop.TK_TacDungPhuCuaThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("TK_GhiChu", BenhAnVayNenTheKhop.TK_GhiChu));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DieuTri", BenhAnVayNenTheKhop.TK_DieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HenKhamLai", BenhAnVayNenTheKhop.TK_HenKhamLai));
                Command.Parameters.Add(new MDB.MDBParameter("TK_BacSiKhamBenh", BenhAnVayNenTheKhop.TK_BacSiKhamBenh));

                
                // Tổng kết
                Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnVayNenTheKhop.QuaTrinhBenhLy));
                Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQua", BenhAnVayNenTheKhop.TomTatKetQua));
                Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnVayNenTheKhop.BenhChinh));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhChinh", BenhAnVayNenTheKhop.MaBenhChinh));
                Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnVayNenTheKhop.BenhKemTheo));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhKemTheo", BenhAnVayNenTheKhop.MaBenhKemTheo));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnVayNenTheKhop.PhuongPhapDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangRaVien", BenhAnVayNenTheKhop.TinhTrangRaVien));
                Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnVayNenTheKhop.HuongDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnVayNenTheKhop.NguoiNhanHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnVayNenTheKhop.NguoiGiaoHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnVayNenTheKhop.NgayTongKet));
                Command.Parameters.Add(new MDB.MDBParameter("TongKet_BacSyDieuTri", BenhAnVayNenTheKhop.TongKet_BacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TongKet_MaBacSyDieuTri", BenhAnVayNenTheKhop.TongKet_MaBacSyDieuTri));


                Command.BindByName = true;
                int n = Command.ExecuteNonQuery(); // C#
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool Update(MDB.MDBConnection MyConnection, BenhAnVayNenTheKhop BenhAnVayNenTheKhop)
        {
            try
            {
                string sql = @"UPDATE BenhAnVayNenTheKhop SET 
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
                            ThoiGianKhoiPhat=:ThoiGianKhoiPhat,
                            ViTriKhoiPhat=:ViTriKhoiPhat,
                            TrieuChungDauTien=:TrieuChungDauTien,
                            NhapVienLan=:NhapVienLan,
                            BenhVayNen_Xuan=:BenhVayNen_Xuan,
                            BenhVayNen_Ha=:BenhVayNen_Ha,
                            BenhVayNen_Thu=:BenhVayNen_Thu,
                            BenhVayNen_Dong=:BenhVayNen_Dong,
                            QuaTrinhDieuTri=:QuaTrinhDieuTri,
                            BenhKhac=:BenhKhac,
                            ThoiQuenCaNhan=:ThoiQuenCaNhan,
                            YeuToTinhThan=:YeuToTinhThan,
                            TienSuGiaDinhMacVN=:TienSuGiaDinhMacVN,
                            TienSuGiaDinhMacVN_Co=:TienSuGiaDinhMacVN_Co,
                            TienSuGiaDinh_Xuan=:TienSuGiaDinh_Xuan,
                            TienSuGiaDinh_Ha=:TienSuGiaDinh_Ha,
                            TienSuGiaDinh_Thu=:TienSuGiaDinh_Thu,
                            TienSuGiaDinh_Dong=:TienSuGiaDinh_Dong,
                            PEST_1=:PEST_1,
                            PEST_2=:PEST_2,
                            PEST_3=:PEST_3,
                            PEST_4=:PEST_4,
                            PEST_5=:PEST_5,
                            NguyCoMacBenhDongMac=:NguyCoMacBenhDongMac,
                            NhietDo=:NhietDo,
                            Mach=:Mach,
                            HA=:HA,
                            Can=:Can,
                            Cao=:Cao,
                            TrieuChungCoNang=:TrieuChungCoNang,
                            TonThuongDa=:TonThuongDa,
                            TonThuongDa_BieuHien=:TonThuongDa_BieuHien,
                            TonThuongDa_TongDiemPASI=:TonThuongDa_TongDiemPASI,
                            BieuHienMong=:BieuHienMong,
                            BieuHienMong_BieuHien=:BieuHienMong_BieuHien,
                            BieuHienMong_TongDiemPASI=:BieuHienMong_TongDiemPASI,
                            SoKhopDau=:SoKhopDau,
                            SoKhopSung=:SoKhopSung,
                            DAS28=:DAS28,
                            ViemMotKhop=:ViemMotKhop,
                            ViemKhopCotSong=:ViemKhopCotSong,
                            ViemDaKhopLoaiBienDang=:ViemDaKhopLoaiBienDang,
                            BienDangKhop=:BienDangKhop,
                            LoaiBienDang=:LoaiBienDang,
                            BieuHienNiemMac=:BieuHienNiemMac,
                            BieuHienNiemMac_ViTri=:BieuHienNiemMac_ViTri,
                            TimMach=:TimMach,
                            HoHap=:HoHap,
                            TieuHoa=:TieuHoa,
                            TamThan=:TamThan,
                            DiemDLQI=:DiemDLQI,
                            GhiChu=:GhiChu,
                            Diem_HAQ=:Diem_HAQ,
                            ChucNangKhop=:ChucNangKhop,
                            MucDoTrieuChung=:MucDoTrieuChung,
                            TieuChuanViemKhop_Diem=:TieuChuanViemKhop_Diem,
                            DieuTri_CuThe=:DieuTri_CuThe,
                            HenKhamLai=:HenKhamLai,
                            BacSiKhamBenh=:BacSiKhamBenh,
                            TK_HoTen=:TK_HoTen,
                            TK_SoBenhAnDienTu=:TK_SoBenhAnDienTu,
                            TK_Ngay=:TK_Ngay,
                            TK_SoLuuTru=:TK_SoLuuTru,
                            TK_NhietDo=:TK_NhietDo,
                            TK_Mach=:TK_Mach,
                            TK_HA=:TK_HA,
                            TK_Can=:TK_Can,
                            TK_Cao=:TK_Cao,
                            TK_TrieuChungCoNang=:TK_TrieuChungCoNang,
                            TK_TienSu=:TK_TienSu,
                            TK_TonThuongDa=:TK_TonThuongDa,
                            TK_TongDiemPASI=:TK_TongDiemPASI,
                            TK_TonThuongMong=:TK_TonThuongMong,
                            TK_SoKhopDau=:TK_SoKhopDau,
                            TK_SoKhopSung=:TK_SoKhopSung,
                            TK_DAS28=:TK_DAS28,
                            TK_ViemMotKhop=:TK_ViemMotKhop,
                            TK_ViemKhopCotSong=:TK_ViemKhopCotSong,
                            TK_ViemDaKhopLoaiBienDang=:TK_ViemDaKhopLoaiBienDang,
                            TK_BienDangKhop=:TK_BienDangKhop,
                            TK_LoaiBienDang=:TK_LoaiBienDang,
                            TK_ChucNangKhop=:TK_ChucNangKhop,
                            TK_MucDoTrieuChung=:TK_MucDoTrieuChung,
                            TK_BieuHienNiemMac=:TK_BieuHienNiemMac,
                            TK_BieuHienNiemMac_ViTri=:TK_BieuHienNiemMac_ViTri,
                            TK_TimMach=:TK_TimMach,
                            TK_HoHap=:TK_HoHap,
                            TK_TieuHoa=:TK_TieuHoa,
                            TK_TamThan=:TK_TamThan,
                            TK_LamSangKhac=:TK_LamSangKhac,
                            TK_TacDungPhuCuaThuoc=:TK_TacDungPhuCuaThuoc,
                            TK_GhiChu=:TK_GhiChu,
                            TK_DieuTri=:TK_DieuTri,
                            TK_HenKhamLai=:TK_HenKhamLai,
                            TK_BacSiKhamBenh=:TK_BacSiKhamBenh,
                            QuaTrinhBenhLy=:QuaTrinhBenhLy,
                            TomTatKetQua=:TomTatKetQua,
                            BenhChinh=:BenhChinh,
                            MaBenhChinh=:MaBenhChinh,
                            BenhKemTheo=:BenhKemTheo,
                            MaBenhKemTheo=:MaBenhKemTheo,
                            PhuongPhapDieuTri=:PhuongPhapDieuTri,
                            TinhTrangRaVien=:TinhTrangRaVien,
                            HuongDieuTri=:HuongDieuTri,
                            NguoiNhanHoSo=:NguoiNhanHoSo,
                            NguoiGiaoHoSo=:NguoiGiaoHoSo,
                            NgayTongKet=:NgayTongKet,
                            TongKet_BacSyDieuTri=:TongKet_BacSyDieuTri,
                            TongKet_MaBacSyDieuTri=:TongKet_MaBacSyDieuTri 
                            WHERE MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriNgoaiTruTu", BenhAnVayNenTheKhop.DieuTriNgoaiTruTu));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriNgoaiTruDen", BenhAnVayNenTheKhop.DieuTriNgoaiTruDen));
                Command.Parameters.Add(new MDB.MDBParameter("SoCMND", BenhAnVayNenTheKhop.SoCMND));
                Command.Parameters.Add(new MDB.MDBParameter("BaoHiem", BenhAnVayNenTheKhop.BaoHiem));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan_TuyenTruoc", BenhAnVayNenTheKhop.ChanDoan_TuyenTruoc));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanBanDau", BenhAnVayNenTheKhop.ChanDoanBanDau));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham1", BenhAnVayNenTheKhop.ChanDoanTaiKham1));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham2", BenhAnVayNenTheKhop.ChanDoanTaiKham2));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham3", BenhAnVayNenTheKhop.ChanDoanTaiKham3));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham4", BenhAnVayNenTheKhop.ChanDoanTaiKham4));
                Command.Parameters.Add(new MDB.MDBParameter("BenhPhu", BenhAnVayNenTheKhop.BenhPhu));
                Command.Parameters.Add(new MDB.MDBParameter("KetQuaDieuTri", BenhAnVayNenTheKhop.KetQuaDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("BienChung_Text", BenhAnVayNenTheKhop.BienChung_Text));
                Command.Parameters.Add(new MDB.MDBParameter("GDPhongKeHoach", BenhAnVayNenTheKhop.GDPhongKeHoach));
                Command.Parameters.Add(new MDB.MDBParameter("GDPhongKhamBenh", BenhAnVayNenTheKhop.GDPhongKhamBenh));
                // hỏi bệnh, khám bệnh
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianKhoiPhat", BenhAnVayNenTheKhop.ThoiGianKhoiPhat));
                Command.Parameters.Add(new MDB.MDBParameter("ViTriKhoiPhat", BenhAnVayNenTheKhop.ViTriKhoiPhat));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungDauTien", BenhAnVayNenTheKhop.TrieuChungDauTien));
                Command.Parameters.Add(new MDB.MDBParameter("NhapVienLan", BenhAnVayNenTheKhop.NhapVienLan));
                Command.Parameters.Add(new MDB.MDBParameter("BenhVayNen_Xuan", BenhAnVayNenTheKhop.BenhVayNen_Xuan));
                Command.Parameters.Add(new MDB.MDBParameter("BenhVayNen_Ha", BenhAnVayNenTheKhop.BenhVayNen_Ha));
                Command.Parameters.Add(new MDB.MDBParameter("BenhVayNen_Thu", BenhAnVayNenTheKhop.BenhVayNen_Thu));
                Command.Parameters.Add(new MDB.MDBParameter("BenhVayNen_Dong", BenhAnVayNenTheKhop.BenhVayNen_Dong));
                Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhDieuTri", BenhAnVayNenTheKhop.QuaTrinhDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("BenhKhac", BenhAnVayNenTheKhop.BenhKhac));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiQuenCaNhan", BenhAnVayNenTheKhop.ThoiQuenCaNhan));
                Command.Parameters.Add(new MDB.MDBParameter("YeuToTinhThan", BenhAnVayNenTheKhop.YeuToTinhThan));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuGiaDinhMacVN", BenhAnVayNenTheKhop.TienSuGiaDinhMacVN));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuGiaDinhMacVN_Co", BenhAnVayNenTheKhop.TienSuGiaDinhMacVN_Co));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuGiaDinh_Xuan", BenhAnVayNenTheKhop.TienSuGiaDinh_Xuan));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuGiaDinh_Ha", BenhAnVayNenTheKhop.TienSuGiaDinh_Ha));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuGiaDinh_Thu", BenhAnVayNenTheKhop.TienSuGiaDinh_Thu));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuGiaDinh_Dong", BenhAnVayNenTheKhop.TienSuGiaDinh_Dong));
                Command.Parameters.Add(new MDB.MDBParameter("PEST_1", BenhAnVayNenTheKhop.PEST_1));
                Command.Parameters.Add(new MDB.MDBParameter("PEST_2", BenhAnVayNenTheKhop.PEST_2));
                Command.Parameters.Add(new MDB.MDBParameter("PEST_3", BenhAnVayNenTheKhop.PEST_3));
                Command.Parameters.Add(new MDB.MDBParameter("PEST_4", BenhAnVayNenTheKhop.PEST_4));
                Command.Parameters.Add(new MDB.MDBParameter("PEST_5", BenhAnVayNenTheKhop.PEST_5));
                Command.Parameters.Add(new MDB.MDBParameter("NguyCoMacBenhDongMac", BenhAnVayNenTheKhop.NguyCoMacBenhDongMac));
                Command.Parameters.Add(new MDB.MDBParameter("NhietDo", BenhAnVayNenTheKhop.NhietDo));
                Command.Parameters.Add(new MDB.MDBParameter("Mach", BenhAnVayNenTheKhop.Mach));
                Command.Parameters.Add(new MDB.MDBParameter("HA", BenhAnVayNenTheKhop.HA));
                Command.Parameters.Add(new MDB.MDBParameter("Can", BenhAnVayNenTheKhop.Can));
                Command.Parameters.Add(new MDB.MDBParameter("Cao", BenhAnVayNenTheKhop.Cao));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungCoNang", BenhAnVayNenTheKhop.TrieuChungCoNang));
                Command.Parameters.Add(new MDB.MDBParameter("TonThuongDa", BenhAnVayNenTheKhop.TonThuongDa));
                Command.Parameters.Add(new MDB.MDBParameter("TonThuongDa_BieuHien", BenhAnVayNenTheKhop.TonThuongDa_BieuHien));
                Command.Parameters.Add(new MDB.MDBParameter("TonThuongDa_TongDiemPASI", BenhAnVayNenTheKhop.TonThuongDa_TongDiemPASI));
                Command.Parameters.Add(new MDB.MDBParameter("BieuHienMong", BenhAnVayNenTheKhop.BieuHienMong));
                Command.Parameters.Add(new MDB.MDBParameter("BieuHienMong_BieuHien", BenhAnVayNenTheKhop.BieuHienMong_BieuHien));
                Command.Parameters.Add(new MDB.MDBParameter("BieuHienMong_TongDiemPASI", BenhAnVayNenTheKhop.BieuHienMong_TongDiemPASI));
                Command.Parameters.Add(new MDB.MDBParameter("SoKhopDau", BenhAnVayNenTheKhop.SoKhopDau));
                Command.Parameters.Add(new MDB.MDBParameter("SoKhopSung", BenhAnVayNenTheKhop.SoKhopSung));
                Command.Parameters.Add(new MDB.MDBParameter("DAS28", BenhAnVayNenTheKhop.DAS28));
                Command.Parameters.Add(new MDB.MDBParameter("ViemMotKhop", BenhAnVayNenTheKhop.ViemMotKhop));
                Command.Parameters.Add(new MDB.MDBParameter("ViemKhopCotSong", BenhAnVayNenTheKhop.ViemKhopCotSong));
                Command.Parameters.Add(new MDB.MDBParameter("ViemDaKhopLoaiBienDang", BenhAnVayNenTheKhop.ViemDaKhopLoaiBienDang));
                Command.Parameters.Add(new MDB.MDBParameter("BienDangKhop", BenhAnVayNenTheKhop.BienDangKhop));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiBienDang", BenhAnVayNenTheKhop.LoaiBienDang));
                Command.Parameters.Add(new MDB.MDBParameter("BieuHienNiemMac", BenhAnVayNenTheKhop.BieuHienNiemMac));
                Command.Parameters.Add(new MDB.MDBParameter("BieuHienNiemMac_ViTri", BenhAnVayNenTheKhop.BieuHienNiemMac_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("TimMach", BenhAnVayNenTheKhop.TimMach));
                Command.Parameters.Add(new MDB.MDBParameter("HoHap", BenhAnVayNenTheKhop.HoHap));
                Command.Parameters.Add(new MDB.MDBParameter("TieuHoa", BenhAnVayNenTheKhop.TieuHoa));
                Command.Parameters.Add(new MDB.MDBParameter("TamThan", BenhAnVayNenTheKhop.TamThan));
                Command.Parameters.Add(new MDB.MDBParameter("DiemDLQI", BenhAnVayNenTheKhop.DiemDLQI));
                Command.Parameters.Add(new MDB.MDBParameter("GhiChu", BenhAnVayNenTheKhop.GhiChu));
                Command.Parameters.Add(new MDB.MDBParameter("Diem_HAQ", BenhAnVayNenTheKhop.Diem_HAQ));
                Command.Parameters.Add(new MDB.MDBParameter("ChucNangKhop", BenhAnVayNenTheKhop.ChucNangKhop));
                Command.Parameters.Add(new MDB.MDBParameter("MucDoTrieuChung", BenhAnVayNenTheKhop.MucDoTrieuChung));
                Command.Parameters.Add(new MDB.MDBParameter("TieuChuanViemKhop_Diem", BenhAnVayNenTheKhop.TieuChuanViemKhop_Diem));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_CuThe", BenhAnVayNenTheKhop.DieuTri_CuThe));
                Command.Parameters.Add(new MDB.MDBParameter("HenKhamLai", BenhAnVayNenTheKhop.HenKhamLai));
                Command.Parameters.Add(new MDB.MDBParameter("BacSiKhamBenh", BenhAnVayNenTheKhop.BacSiKhamBenh));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HoTen", BenhAnVayNenTheKhop.TK_HoTen));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SoBenhAnDienTu", BenhAnVayNenTheKhop.TK_SoBenhAnDienTu));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Ngay", BenhAnVayNenTheKhop.TK_Ngay));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SoLuuTru", BenhAnVayNenTheKhop.TK_SoLuuTru));
                Command.Parameters.Add(new MDB.MDBParameter("TK_NhietDo", BenhAnVayNenTheKhop.TK_NhietDo));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Mach", BenhAnVayNenTheKhop.TK_Mach));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HA", BenhAnVayNenTheKhop.TK_HA));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Can", BenhAnVayNenTheKhop.TK_Can));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Cao", BenhAnVayNenTheKhop.TK_Cao));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TrieuChungCoNang", BenhAnVayNenTheKhop.TK_TrieuChungCoNang));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TienSu", BenhAnVayNenTheKhop.TK_TienSu));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TonThuongDa", BenhAnVayNenTheKhop.TK_TonThuongDa));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TongDiemPASI", BenhAnVayNenTheKhop.TK_TongDiemPASI));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TonThuongMong", BenhAnVayNenTheKhop.TK_TonThuongMong));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SoKhopDau", BenhAnVayNenTheKhop.TK_SoKhopDau));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SoKhopSung", BenhAnVayNenTheKhop.TK_SoKhopSung));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DAS28", BenhAnVayNenTheKhop.TK_DAS28));
                Command.Parameters.Add(new MDB.MDBParameter("TK_ViemMotKhop", BenhAnVayNenTheKhop.TK_ViemMotKhop));
                Command.Parameters.Add(new MDB.MDBParameter("TK_ViemKhopCotSong", BenhAnVayNenTheKhop.TK_ViemKhopCotSong));
                Command.Parameters.Add(new MDB.MDBParameter("TK_ViemDaKhopLoaiBienDang", BenhAnVayNenTheKhop.TK_ViemDaKhopLoaiBienDang));
                Command.Parameters.Add(new MDB.MDBParameter("TK_BienDangKhop", BenhAnVayNenTheKhop.TK_BienDangKhop));
                Command.Parameters.Add(new MDB.MDBParameter("TK_LoaiBienDang", BenhAnVayNenTheKhop.TK_LoaiBienDang));
                Command.Parameters.Add(new MDB.MDBParameter("TK_ChucNangKhop", BenhAnVayNenTheKhop.TK_ChucNangKhop));
                Command.Parameters.Add(new MDB.MDBParameter("TK_MucDoTrieuChung", BenhAnVayNenTheKhop.TK_MucDoTrieuChung));
                Command.Parameters.Add(new MDB.MDBParameter("TK_BieuHienNiemMac", BenhAnVayNenTheKhop.TK_BieuHienNiemMac));
                Command.Parameters.Add(new MDB.MDBParameter("TK_BieuHienNiemMac_ViTri", BenhAnVayNenTheKhop.TK_BieuHienNiemMac_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TimMach", BenhAnVayNenTheKhop.TK_TimMach));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HoHap", BenhAnVayNenTheKhop.TK_HoHap));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TieuHoa", BenhAnVayNenTheKhop.TK_TieuHoa));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TamThan", BenhAnVayNenTheKhop.TK_TamThan));
                Command.Parameters.Add(new MDB.MDBParameter("TK_LamSangKhac", BenhAnVayNenTheKhop.TK_LamSangKhac));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TacDungPhuCuaThuoc", BenhAnVayNenTheKhop.TK_TacDungPhuCuaThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("TK_GhiChu", BenhAnVayNenTheKhop.TK_GhiChu));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DieuTri", BenhAnVayNenTheKhop.TK_DieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HenKhamLai", BenhAnVayNenTheKhop.TK_HenKhamLai));
                Command.Parameters.Add(new MDB.MDBParameter("TK_BacSiKhamBenh", BenhAnVayNenTheKhop.TK_BacSiKhamBenh));

                // Tổng kết    
                Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnVayNenTheKhop.QuaTrinhBenhLy));
                Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQua", BenhAnVayNenTheKhop.TomTatKetQua));
                Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnVayNenTheKhop.BenhChinh));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhChinh", BenhAnVayNenTheKhop.MaBenhChinh));
                Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnVayNenTheKhop.BenhKemTheo));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhKemTheo", BenhAnVayNenTheKhop.MaBenhKemTheo));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnVayNenTheKhop.PhuongPhapDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangRaVien", BenhAnVayNenTheKhop.TinhTrangRaVien));
                Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnVayNenTheKhop.HuongDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnVayNenTheKhop.NguoiNhanHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnVayNenTheKhop.NguoiGiaoHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnVayNenTheKhop.NgayTongKet));
                Command.Parameters.Add(new MDB.MDBParameter("TongKet_BacSyDieuTri", BenhAnVayNenTheKhop.TongKet_BacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TongKet_MaBacSyDieuTri", BenhAnVayNenTheKhop.TongKet_MaBacSyDieuTri));

                Command.BindByName = true;

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnVayNenTheKhop.MaQuanLy));
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery(); // C#
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
    }
}
