
using EMR_MAIN.DATABASE.BenhAn;
using System;
using System.Data;
using System.Reflection;

namespace EMR_MAIN
{
    public class BenhAnPhaThaiIIIFunc
    {
        public static void WriteXml(MDB.MDBConnection MyConnection)
        {
            string sql =
                   @"
                  select  a.*,  CTScanner HoSo_CTScanner, SieuAm HoSo_SieuAm, XetNghiem HoSo_XetNghiem,  Khac HoSo_Khac,  Khac_Text HoSo_Khac_Text,  ToanBoHoSo HoSo_ToanBoHoSo, Mach DauSinhTon_Mach,  NhietDo DauSinhTon_NhietDo,  HuyetAp DauSinhTon_HuyetAp,  NhipTho DauSinhTon_NhipTho,  CanNang DauSinhTon_CanNang  
                  from BenhAnPhaThaiIII  a inner join thongtindieutri b on a.maquanly = b.maquanly
                  where rownum = 1
                    ";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            var DataTable = new DataTable { TableName = "BenhAnPhaThaiIII" };
            DataTable.Load(DataReader as IDataReader);
            DataTable.WriteXml("rptBenhAnPhaThaiIII.xml");
        }
        public static DataSet SelectDataSet(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql =
                  @"
                   select  a.*,l.hovaten NguoiTongKetHoVaTen, h.hovaten LanhDaoDonViHoVaTen,f.hovaten BacSyLamBenhAnHoVaTen,d.hovaten NguoiGiaoHoSoHoVaTen,e.hovaten NguoiNhanHoSoHoVaTen, b.XQuang HoSo_XQuang,   b.CTScanner HoSo_CTScanner, b.SieuAm HoSo_SieuAm, b.XetNghiem HoSo_XetNghiem,  b.Khac HoSo_Khac,  b.Khac_Text HoSo_Khac_Text,  b.ToanBoHoSo HoSo_ToanBoHoSo, b.Mach DauSinhTon_Mach, b.NhietDo DauSinhTon_NhietDo,  b.HuyetAp DauSinhTon_HuyetAp,  b.NhipTho DauSinhTon_NhipTho,  b.CanNang DauSinhTon_CanNang  , b.ChieuCao DauSinhTon_ChieuCao, b.BMI DauSinhTon_BMI, b.NgayRaVien 
                 from BenhAnPhaThaiIII a 
                 left join thongtindieutri b on a.maquanly = b.maquanly 
                  left join nhanvien d on a.nguoigiaohoso = d.manhanvien
                  left join nhanvien e on a.nguoinhanhoso = e.manhanvien
                  left join nhanvien f on a.BacSyLamBenhAn = f.manhanvien
                  left join nhanvien h on a.LanhDaoDonVi = h.manhanvien
                  left join nhanvien l on a.NguoiTongKet = l.manhanvien
                  where a.maquanly = " + MaQuanLy.ToString(System.Globalization.CultureInfo.InvariantCulture);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(sql, MyConnection);
            var ds = new DataSet();
            adt.Fill(ds, "Table");
            return ds;
        }
        public static BenhAnPhaThaiIII Select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            #region
            string sql =
                      @"select * 
                        from BenhAnPhaThaiIII a
                        where MaQuanLy = :MaQuanLy";
            #endregion
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            var value = new BenhAnPhaThaiIII();
            while (DataReader.Read())
            {
                value.MaQuanLy = DataReader.GetDecimal("MaQuanLy");
                value.LyDoPhaThai = DataReader["LyDoPhaThai"].ToString();
                value.TienSuSanPhuKhoa = DataReader["TienSuSanPhuKhoa"].ToString();
                int intTemp = 0;
                value.SoConHienCo = int.TryParse(DataReader["SoConHienCo"].ToString(), out intTemp) ? (int?)intTemp : null;
                value.SoConTrai = int.TryParse(DataReader["SoConTrai"].ToString(), out intTemp) ? (int?)intTemp : null;
                value.SoConGai = int.TryParse(DataReader["SoConGai"].ToString(), out intTemp) ? (int?)intTemp : null;
                value.SoLanPhauThuatLayThai = int.TryParse(DataReader["SoLanPhauThuatLayThai"].ToString(), out intTemp) ? (int?)intTemp : null;
                value.NamPhauThuatLayThaiCuoi = DataReader["NamPhauThuatLayThaiCuoi"].ToString();
                value.CacPhauThuatTCKhac = DataReader["CacPhauThuatTCKhac"].ToString();
                value.CacPhauThuatTCKhac_Nam = DataReader["CacPhauThuatTCKhac_Nam"].ToString();
                value.SoLanPhaThai = int.TryParse(DataReader["SoLanPhaThai"].ToString(), out intTemp) ? (int?)intTemp : null;
                value.NgayPhaThaiGanNhat = DataReader["NgayPhaThaiGanNhat"] == DBNull.Value ? null : (DateTime?)DataReader.GetDate("NgayPhaThaiGanNhat");
                value.BienPhapTTDangSuDung = DataReader["BienPhapTTDangSuDung"].ToString();
                value.TieuSuBenh = DataReader["TieuSuBenh"].ToString();
                value.TinhTrangHonNhan = DataReader.GetInt("TinhTrangHonNhan");
                value.DUThuoc_Ten = DataReader["DUThuoc_Ten"].ToString();
                value.DUThuoc_CoSoLan = DataReader["DUThuoc_CoSoLan"].ToString();
                value.DUThuoc_Khong = DataReader["DUThuoc_Khong"].ToString().Equals("1") ? true:false;
                value.DUThuoc_BieuHien = DataReader["DUThuoc_BieuHien"].ToString();

                value.DUConTrung_Ten = DataReader["DUConTrung_Ten"].ToString();
                value.DUConTrung_CoSoLan = DataReader["DUConTrung_CoSoLan"].ToString();
                value.DUConTrung_Khong = DataReader["DUConTrung_Khong"].ToString().Equals("1") ? true : false;
                value.DUConTrung_BieuHien = DataReader["DUConTrung_BieuHien"].ToString();

                value.DUThucPham_Ten = DataReader["DUThucPham_Ten"].ToString();
                value.DUThucPham_CoSoLan = DataReader["DUThucPham_CoSoLan"].ToString();
                value.DUThucPham_Khong = DataReader["DUThucPham_Khong"].ToString().Equals("1") ? true : false;
                value.DUThucPham_BieuHien = DataReader["DUThucPham_BieuHien"].ToString();

                value.DUTacNhanKhac_Ten = DataReader["DUTacNhanKhac_Ten"].ToString();
                value.DUTacNhanKhac_CoSoLan = DataReader["DUTacNhanKhac_CoSoLan"].ToString();
                value.DUTacNhanKhac_Khong = DataReader["DUTacNhanKhac_Khong"].ToString().Equals("1") ? true : false;
                value.DUTacNhanKhac_BieuHien = DataReader["DUTacNhanKhac_BieuHien"].ToString();

                value.DUCaNhanKhac_Ten = DataReader["DUCaNhanKhac_Ten"].ToString();
                value.DUCaNhanKhac_CoSoLan = DataReader["DUCaNhanKhac_CoSoLan"].ToString();
                value.DUCaNhanKhac_Khong = DataReader["DUCaNhanKhac_Khong"].ToString().Equals("1") ? true : false;
                value.DUCaNhanKhac_BieuHien = DataReader["DUCaNhanKhac_BieuHien"].ToString();

                value.DUDiTruyen_Ten = DataReader["DUDiTruyen_Ten"].ToString();
                value.DUDiTruyen_CoSoLan = DataReader["DUDiTruyen_CoSoLan"].ToString();
                value.DUDiTruyen_Khong = DataReader["DUDiTruyen_Khong"].ToString().Equals("1") ? true : false;
                value.DUDiTruyen_BieuHien = DataReader["DUDiTruyen_BieuHien"].ToString();

                value.CacBoPhan = DataReader["CacBoPhan"].ToString();
                value.NgayDauKyKinhCuoi = DataReader["NgayDauKyKinhCuoi"] == DBNull.Value ? null : (DateTime?)DataReader.GetDate("NgayDauKyKinhCuoi");
                value.TuoiThai = int.TryParse(DataReader["TuoiThai"].ToString(), out intTemp) ? (int?)intTemp : null;
                value.AmHo = DataReader["AmHo"].ToString();
                value.AmDao = DataReader["AmDao"].ToString();
                value.CoTuCung = DataReader["CoTuCung"].ToString();
                value.TuCungChiTiet = DataReader["TuCungChiTiet"].ToString();
                value.PhanPhuPhai = DataReader["PhanPhuPhai"].ToString();
                value.PhanPhuTrai = DataReader["PhanPhuTrai"].ToString();
                value.CacXetNghiemCanLam = DataReader["CacXetNghiemCanLam"].ToString();
                value.ChanDoanTuoiThai = int.TryParse(DataReader["ChanDoanTuoiThai"].ToString(), out intTemp) ? (int?)intTemp : null;
                value.PhuongPhapPhaThai = DataReader["PhuongPhapPhaThai"].ToString();
                value.NgayKhamBenh = DataReader["NgayKhamBenh"] == DBNull.Value ? DateTime.Now : DataReader.GetDate("NgayKhamBenh");
                value.BacSyLamBenhAn = DataReader["BacSyLamBenhAn"].ToString();
                value.ChanDoanTuanThaiTongKet = DataReader["ChanDoanTuanThaiTongKet"].ToString();
                value.PhuongPhapPhaThaiTongKet = DataReader.GetInt("PhuongPhapPhaThaiTongKet");
                value.TinhTrangSauKhiPhaThai = DataReader.GetInt("PhuongPhapPhaThaiTongKet");
                value.TaiBien = DataReader.GetInt("TaiBien");
                double doubleTemp = 0;
                value.TongSoGio = double.TryParse(DataReader["TongSoGio"].ToString(), out doubleTemp) ? (double?)doubleTemp : null;
                value.RaVe = DataReader.GetInt("RaVe");
                value.ChuyenTuyenLuc = DataReader["ChuyenTuyenLuc"] == DBNull.Value ? null : (DateTime?)DataReader.GetDate("ChuyenTuyenLuc");
                value.LyDoNhapVien = DataReader["LyDoNhapVien"].ToString();
                value.LyDoChuyenTuyen = DataReader["LyDoChuyenTuyen"].ToString();
                value.BienPhapTranhThaiSauPhaThaiTK = DataReader["BienPhapTranhThaiSauPhaThaiTK"].ToString();
                value.KhamLaiBatThuong = DataReader["KhamLaiBatThuong"].ToString();
                value.KhamLaiTheoHen = DataReader["KhamLaiTheoHen"].ToString();
                value.KetLuan = DataReader["KetLuan"].ToString();
                value.LanhDaoDonVi = DataReader["LanhDaoDonVi"].ToString();
                value.NguoiTongKet = DataReader["NguoiTongKet"].ToString();
                value.NgayTongKet = DataReader["NgayTongKet"] == DBNull.Value ? DateTime.Now : DataReader.GetDate("NgayTongKet");
                value.NguoiNhanHoSo = DataReader["NguoiNhanHoSo"].ToString();
                value.NguoiGiaoHoSo = DataReader["NguoiGiaoHoSo"].ToString();

                
                value.MaSoKyTen = DataReader["masokyten"].ToString();
                value.MaSoKyTen_KB = DataReader["masokyten_kb"].ToString();
                value.MaSoKyTen_TK = DataReader["masokyten_tk"].ToString();
            }
            return value;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, BenhAnPhaThaiIII benhAnPhaThaiIII)
        {
            try
            {
                string sql =
                          @"select MaQuanLy 
                        from BenhAnPhaThaiIII
                        where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", benhAnPhaThaiIII.MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                int rowCount = 0;
                while (DataReader.Read()) rowCount++;
                if (rowCount == 1) return Update(MyConnection, benhAnPhaThaiIII);
                sql = @"
                   INSERT INTO BenhAnPhaThaiIII (
					MaQuanLy,
                    LyDoPhaThai,
                    TienSuSanPhuKhoa,
                    SoConHienCo,
                    SoConTrai,
                    SoConGai,
                    SoLanPhauThuatLayThai,
                    NamPhauThuatLayThaiCuoi,
                    CacPhauThuatTCKhac,
                    CacPhauThuatTCKhac_Nam,
                    SoLanPhaThai,
                    NgayPhaThaiGanNhat,
                    BienPhapTTDangSuDung,
                    TieuSuBenh,
                    TinhTrangHonNhan,
                    DUThuoc_Ten,
                    DUThuoc_CoSoLan,
                    DUThuoc_Khong,
                    DUThuoc_BieuHien,
                    DUConTrung_Ten,
                    DUConTrung_CoSoLan,
                    DUConTrung_Khong,
                    DUConTrung_BieuHien,
                    DUThucPham_Ten,
                    DUThucPham_CoSoLan,
                    DUThucPham_Khong,
                    DUThucPham_BieuHien,
                    DUTacNhanKhac_Ten,
                    DUTacNhanKhac_CoSoLan,
                    DUTacNhanKhac_Khong,
                    DUTacNhanKhac_BieuHien,
                    DUCaNhanKhac_Ten,
                    DUCaNhanKhac_CoSoLan,
                    DUCaNhanKhac_Khong,
                    DUCaNhanKhac_BieuHien,
                    DUDiTruyen_Ten,
                    DUDiTruyen_CoSoLan,
                    DUDiTruyen_Khong,
                    DUDiTruyen_BieuHien,
                    CacBoPhan,
                    NgayDauKyKinhCuoi,
                    TuoiThai,
                    AmHo,
                    AmDao,
                    CoTuCung,
                    TuCungChiTiet,
                    PhanPhuPhai,
                    PhanPhuTrai,
                    CacXetNghiemCanLam,
                    ChanDoanTuoiThai,
                    PhuongPhapPhaThai,
                    NgayKhamBenh,
                    BacSyLamBenhAn,
                    ChanDoanTuanThaiTongKet,
                    PhuongPhapPhaThaiTongKet,
                    TinhTrangSauKhiPhaThai,
                    TaiBien,
                    TongSoGio,
                    RaVe,
                    ChuyenTuyenLuc,
                    LyDoNhapVien,
                    LyDoChuyenTuyen,
                    BienPhapTranhThaiSauPhaThaiTK,
                    KhamLaiBatThuong,
                    KhamLaiTheoHen,
                    KetLuan,
                    LanhDaoDonVi,
                    NguoiTongKet,
                    NgayTongKet,
                    NguoiNhanHoSo,
                    NguoiGiaoHoSo)
                   VALUES(
                    :MaQuanLy,
                    :LyDoPhaThai,
                    :TienSuSanPhuKhoa,
                    :SoConHienCo,
                    :SoConTrai,
                    :SoConGai,
                    :SoLanPhauThuatLayThai,
                    :NamPhauThuatLayThaiCuoi,
                    :CacPhauThuatTCKhac,
                    :CacPhauThuatTCKhac_Nam,
                    :SoLanPhaThai,
                    :NgayPhaThaiGanNhat,
                    :BienPhapTTDangSuDung,
                    :TieuSuBenh,
                    :TinhTrangHonNhan,
                    :DUThuoc_Ten,
                    :DUThuoc_CoSoLan,
                    :DUThuoc_Khong,
                    :DUThuoc_BieuHien,
                    :DUConTrung_Ten,
                    :DUConTrung_CoSoLan,
                    :DUConTrung_Khong,
                    :DUConTrung_BieuHien,
                    :DUThucPham_Ten,
                    :DUThucPham_CoSoLan,
                    :DUThucPham_Khong,
                    :DUThucPham_BieuHien,
                    :DUTacNhanKhac_Ten,
                    :DUTacNhanKhac_CoSoLan,
                    :DUTacNhanKhac_Khong,
                    :DUTacNhanKhac_BieuHien,
                    :DUCaNhanKhac_Ten,
                    :DUCaNhanKhac_CoSoLan,
                    :DUCaNhanKhac_Khong,
                    :DUCaNhanKhac_BieuHien,
                    :DUDiTruyen_Ten,
                    :DUDiTruyen_CoSoLan,
                    :DUDiTruyen_Khong,
                    :DUDiTruyen_BieuHien,
                    :CacBoPhan,
                    :NgayDauKyKinhCuoi,
                    :TuoiThai,
                    :AmHo,
                    :AmDao,
                    :CoTuCung,
                    :TuCungChiTiet,
                    :PhanPhuPhai,
                    :PhanPhuTrai,
                    :CacXetNghiemCanLam,
                    :ChanDoanTuoiThai,
                    :PhuongPhapPhaThai,
                    :NgayKhamBenh,
                    :BacSyLamBenhAn,
                    :ChanDoanTuanThaiTongKet,
                    :PhuongPhapPhaThaiTongKet,
                    :TinhTrangSauKhiPhaThai,
                    :TaiBien,
                    :TongSoGio,
                    :RaVe,
                    :ChuyenTuyenLuc,
                    :LyDoNhapVien,
                    :LyDoChuyenTuyen,
                    :BienPhapTranhThaiSauPhaThaiTK,
                    :KhamLaiBatThuong,
                    :KhamLaiTheoHen,
                    :KetLuan,
                    :LanhDaoDonVi,
                    :NguoiTongKet,
                    :NgayTongKet,
                    :NguoiNhanHoSo,
                    :NguoiGiaoHoSo)";
                Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", benhAnPhaThaiIII.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("LyDoPhaThai", benhAnPhaThaiIII.LyDoPhaThai));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuSanPhuKhoa", benhAnPhaThaiIII.TienSuSanPhuKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("SoConHienCo", benhAnPhaThaiIII.SoConHienCo));
                Command.Parameters.Add(new MDB.MDBParameter("SoConTrai", benhAnPhaThaiIII.SoConTrai));
                Command.Parameters.Add(new MDB.MDBParameter("SoConGai", benhAnPhaThaiIII.SoConGai));
                Command.Parameters.Add(new MDB.MDBParameter("SoLanPhauThuatLayThai", benhAnPhaThaiIII.SoLanPhauThuatLayThai));
                Command.Parameters.Add(new MDB.MDBParameter("NamPhauThuatLayThaiCuoi", benhAnPhaThaiIII.NamPhauThuatLayThaiCuoi));
                Command.Parameters.Add(new MDB.MDBParameter("CacPhauThuatTCKhac", benhAnPhaThaiIII.CacPhauThuatTCKhac));
                Command.Parameters.Add(new MDB.MDBParameter("CacPhauThuatTCKhac_Nam", benhAnPhaThaiIII.CacPhauThuatTCKhac_Nam));
                Command.Parameters.Add(new MDB.MDBParameter("SoLanPhaThai", benhAnPhaThaiIII.SoLanPhaThai));
                Command.Parameters.Add(new MDB.MDBParameter("NgayPhaThaiGanNhat", benhAnPhaThaiIII.NgayPhaThaiGanNhat));
                Command.Parameters.Add(new MDB.MDBParameter("BienPhapTTDangSuDung", benhAnPhaThaiIII.BienPhapTTDangSuDung));
                Command.Parameters.Add(new MDB.MDBParameter("TieuSuBenh", benhAnPhaThaiIII.TieuSuBenh));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangHonNhan", benhAnPhaThaiIII.TinhTrangHonNhan));

                Command.Parameters.Add(new MDB.MDBParameter("DUThuoc_Ten", benhAnPhaThaiIII.DUThuoc_Ten));
                Command.Parameters.Add(new MDB.MDBParameter("DUThuoc_CoSoLan", benhAnPhaThaiIII.DUThuoc_CoSoLan));
                Command.Parameters.Add(new MDB.MDBParameter("DUThuoc_Khong", benhAnPhaThaiIII.DUThuoc_Khong ? 1:0));
                Command.Parameters.Add(new MDB.MDBParameter("DUThuoc_BieuHien", benhAnPhaThaiIII.DUThuoc_BieuHien));

                Command.Parameters.Add(new MDB.MDBParameter("DUConTrung_Ten", benhAnPhaThaiIII.DUConTrung_Ten));
                Command.Parameters.Add(new MDB.MDBParameter("DUConTrung_CoSoLan", benhAnPhaThaiIII.DUConTrung_CoSoLan));
                Command.Parameters.Add(new MDB.MDBParameter("DUConTrung_Khong", benhAnPhaThaiIII.DUConTrung_Khong ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("DUConTrung_BieuHien", benhAnPhaThaiIII.DUConTrung_BieuHien));

                Command.Parameters.Add(new MDB.MDBParameter("DUThucPham_Ten", benhAnPhaThaiIII.DUThucPham_Ten));
                Command.Parameters.Add(new MDB.MDBParameter("DUThucPham_CoSoLan", benhAnPhaThaiIII.DUThucPham_CoSoLan));
                Command.Parameters.Add(new MDB.MDBParameter("DUThucPham_Khong", benhAnPhaThaiIII.DUThucPham_Khong ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("DUThucPham_BieuHien", benhAnPhaThaiIII.DUThucPham_BieuHien));

                Command.Parameters.Add(new MDB.MDBParameter("DUTacNhanKhac_Ten", benhAnPhaThaiIII.DUTacNhanKhac_Ten));
                Command.Parameters.Add(new MDB.MDBParameter("DUTacNhanKhac_CoSoLan", benhAnPhaThaiIII.DUTacNhanKhac_CoSoLan));
                Command.Parameters.Add(new MDB.MDBParameter("DUTacNhanKhac_Khong", benhAnPhaThaiIII.DUTacNhanKhac_Khong ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("DUTacNhanKhac_BieuHien", benhAnPhaThaiIII.DUTacNhanKhac_BieuHien));

                Command.Parameters.Add(new MDB.MDBParameter("DUCaNhanKhac_Ten", benhAnPhaThaiIII.DUCaNhanKhac_Ten));
                Command.Parameters.Add(new MDB.MDBParameter("DUCaNhanKhac_CoSoLan", benhAnPhaThaiIII.DUCaNhanKhac_CoSoLan));
                Command.Parameters.Add(new MDB.MDBParameter("DUCaNhanKhac_Khong", benhAnPhaThaiIII.DUCaNhanKhac_Khong ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("DUCaNhanKhac_BieuHien", benhAnPhaThaiIII.DUCaNhanKhac_BieuHien));

                Command.Parameters.Add(new MDB.MDBParameter("DUDiTruyen_Ten", benhAnPhaThaiIII.DUDiTruyen_Ten));
                Command.Parameters.Add(new MDB.MDBParameter("DUDiTruyen_CoSoLan", benhAnPhaThaiIII.DUDiTruyen_CoSoLan));
                Command.Parameters.Add(new MDB.MDBParameter("DUDiTruyen_Khong", benhAnPhaThaiIII.DUDiTruyen_Khong ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("DUDiTruyen_BieuHien", benhAnPhaThaiIII.DUDiTruyen_BieuHien));

                Command.Parameters.Add(new MDB.MDBParameter("CacBoPhan", benhAnPhaThaiIII.CacBoPhan));
                Command.Parameters.Add(new MDB.MDBParameter("NgayDauKyKinhCuoi", benhAnPhaThaiIII.NgayDauKyKinhCuoi));
                Command.Parameters.Add(new MDB.MDBParameter("TuoiThai", benhAnPhaThaiIII.TuoiThai));
                Command.Parameters.Add(new MDB.MDBParameter("AmHo", benhAnPhaThaiIII.AmHo));
                Command.Parameters.Add(new MDB.MDBParameter("AmDao", benhAnPhaThaiIII.AmDao));
                Command.Parameters.Add(new MDB.MDBParameter("CoTuCung", benhAnPhaThaiIII.CoTuCung));
                Command.Parameters.Add(new MDB.MDBParameter("TuCungChiTiet", benhAnPhaThaiIII.TuCungChiTiet));
                Command.Parameters.Add(new MDB.MDBParameter("PhanPhuPhai", benhAnPhaThaiIII.PhanPhuPhai));
                Command.Parameters.Add(new MDB.MDBParameter("PhanPhuTrai", benhAnPhaThaiIII.PhanPhuTrai));
                Command.Parameters.Add(new MDB.MDBParameter("CacXetNghiemCanLam", benhAnPhaThaiIII.CacXetNghiemCanLam));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTuoiThai", benhAnPhaThaiIII.ChanDoanTuoiThai));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapPhaThai", benhAnPhaThaiIII.PhuongPhapPhaThai));
                Command.Parameters.Add(new MDB.MDBParameter("NgayKhamBenh", benhAnPhaThaiIII.NgayKhamBenh));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyLamBenhAn", benhAnPhaThaiIII.BacSyLamBenhAn));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTuanThaiTongKet", benhAnPhaThaiIII.ChanDoanTuanThaiTongKet));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapPhaThaiTongKet", benhAnPhaThaiIII.PhuongPhapPhaThaiTongKet));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangSauKhiPhaThai", benhAnPhaThaiIII.TinhTrangSauKhiPhaThai));
                Command.Parameters.Add(new MDB.MDBParameter("TongSoGio", benhAnPhaThaiIII.TongSoGio));
                Command.Parameters.Add(new MDB.MDBParameter("RaVe", benhAnPhaThaiIII.RaVe));
                Command.Parameters.Add(new MDB.MDBParameter("TaiBien", benhAnPhaThaiIII.TaiBien));
                Command.Parameters.Add(new MDB.MDBParameter("ChuyenTuyenLuc", benhAnPhaThaiIII.ChuyenTuyenLuc));
                Command.Parameters.Add(new MDB.MDBParameter("LyDoNhapVien", benhAnPhaThaiIII.LyDoNhapVien));
                Command.Parameters.Add(new MDB.MDBParameter("LyDoChuyenTuyen", benhAnPhaThaiIII.LyDoChuyenTuyen));
                Command.Parameters.Add(new MDB.MDBParameter("BienPhapTranhThaiSauPhaThaiTK", benhAnPhaThaiIII.BienPhapTranhThaiSauPhaThaiTK));
                Command.Parameters.Add(new MDB.MDBParameter("KhamLaiBatThuong", benhAnPhaThaiIII.KhamLaiBatThuong));
                Command.Parameters.Add(new MDB.MDBParameter("KhamLaiTheoHen", benhAnPhaThaiIII.KhamLaiTheoHen));
                Command.Parameters.Add(new MDB.MDBParameter("KetLuan", benhAnPhaThaiIII.KetLuan));
                Command.Parameters.Add(new MDB.MDBParameter("LanhDaoDonVi", benhAnPhaThaiIII.LanhDaoDonVi));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiTongKet", benhAnPhaThaiIII.NguoiTongKet));
                Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", benhAnPhaThaiIII.NgayTongKet));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", benhAnPhaThaiIII.NguoiNhanHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", benhAnPhaThaiIII.NguoiGiaoHoSo));
                
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
        public static bool Update(MDB.MDBConnection MyConnection, BenhAnPhaThaiIII benhAnPhaThaiIII)
        {
            try
            {
                string sql = @"UPDATE BenhAnPhaThaiIII SET 
                        MaQuanLy = :MaQuanLy,
                        LyDoPhaThai = :LyDoPhaThai,
                        TienSuSanPhuKhoa = :TienSuSanPhuKhoa,
                        SoConHienCo = :SoConHienCo,
                        SoConTrai = :SoConTrai,
                        SoConGai = :SoConGai,
                        SoLanPhauThuatLayThai = :SoLanPhauThuatLayThai,
                        NamPhauThuatLayThaiCuoi = :NamPhauThuatLayThaiCuoi,
                        CacPhauThuatTCKhac = :CacPhauThuatTCKhac,
                        CacPhauThuatTCKhac_Nam = :CacPhauThuatTCKhac_Nam,
                        SoLanPhaThai = :SoLanPhaThai,
                        NgayPhaThaiGanNhat = :NgayPhaThaiGanNhat,
                        BienPhapTTDangSuDung = :BienPhapTTDangSuDung,
                        TieuSuBenh = :TieuSuBenh,
                        TinhTrangHonNhan = :TinhTrangHonNhan,
                        DUThuoc_Ten = :DUThuoc_Ten,
                        DUThuoc_CoSoLan = :DUThuoc_CoSoLan,
                        DUThuoc_Khong = :DUThuoc_Khong,
                        DUThuoc_BieuHien = :DUThuoc_BieuHien,
                        DUConTrung_Ten = :DUConTrung_Ten,
                        DUConTrung_CoSoLan = :DUConTrung_CoSoLan,
                        DUConTrung_Khong = :DUConTrung_Khong,
                        DUConTrung_BieuHien = :DUConTrung_BieuHien,
                        DUThucPham_Ten = :DUThucPham_Ten,
                        DUThucPham_CoSoLan = :DUThucPham_CoSoLan,
                        DUThucPham_Khong = :DUThucPham_Khong,
                        DUThucPham_BieuHien = :DUThucPham_BieuHien,
                        DUTacNhanKhac_Ten = :DUTacNhanKhac_Ten,
                        DUTacNhanKhac_CoSoLan = :DUTacNhanKhac_CoSoLan,
                        DUTacNhanKhac_Khong = :DUTacNhanKhac_Khong,
                        DUTacNhanKhac_BieuHien = :DUTacNhanKhac_BieuHien,
                        DUCaNhanKhac_Ten = :DUCaNhanKhac_Ten,
                        DUCaNhanKhac_CoSoLan = :DUCaNhanKhac_CoSoLan,
                        DUCaNhanKhac_Khong = :DUCaNhanKhac_Khong,
                        DUCaNhanKhac_BieuHien = :DUCaNhanKhac_BieuHien,
                        DUDiTruyen_Ten = :DUDiTruyen_Ten,
                        DUDiTruyen_CoSoLan = :DUDiTruyen_CoSoLan,
                        DUDiTruyen_Khong = :DUDiTruyen_Khong,
                        DUDiTruyen_BieuHien = :DUDiTruyen_BieuHien,
                        CacBoPhan = :CacBoPhan,
                        NgayDauKyKinhCuoi = :NgayDauKyKinhCuoi,
                        TuoiThai = :TuoiThai,
                        AmHo = :AmHo,
                        AmDao = :AmDao,
                        CoTuCung = :CoTuCung,
                        TuCungChiTiet = :TuCungChiTiet,
                        PhanPhuPhai = :PhanPhuPhai,
                        PhanPhuTrai = :PhanPhuTrai,
                        CacXetNghiemCanLam = :CacXetNghiemCanLam,
                        ChanDoanTuoiThai = :ChanDoanTuoiThai,
                        PhuongPhapPhaThai = :PhuongPhapPhaThai,
                        NgayKhamBenh = :NgayKhamBenh,
                        BacSyLamBenhAn = :BacSyLamBenhAn,
                        ChanDoanTuanThaiTongKet = :ChanDoanTuanThaiTongKet,
                        PhuongPhapPhaThaiTongKet = :PhuongPhapPhaThaiTongKet,
                        TinhTrangSauKhiPhaThai = :TinhTrangSauKhiPhaThai,
                        TaiBien = :TaiBien,
                        TongSoGio = :TongSoGio,
                        RaVe = :RaVe,
                        ChuyenTuyenLuc = :ChuyenTuyenLuc,
                        LyDoNhapVien = :LyDoNhapVien,
                        LyDoChuyenTuyen = :LyDoChuyenTuyen,
                        BienPhapTranhThaiSauPhaThaiTK = :BienPhapTranhThaiSauPhaThaiTK,
                        KhamLaiBatThuong = :KhamLaiBatThuong,
                        KhamLaiTheoHen = :KhamLaiTheoHen,
                        KetLuan = :KetLuan,
                        LanhDaoDonVi = :LanhDaoDonVi,
                        NguoiTongKet = :NguoiTongKet,
                        NgayTongKet = :NgayTongKet,
                        NguoiNhanHoSo = :NguoiNhanHoSo,
                        NguoiGiaoHoSo = :NguoiGiaoHoSo 
                        WHERE MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", benhAnPhaThaiIII.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("LyDoPhaThai", benhAnPhaThaiIII.LyDoPhaThai));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuSanPhuKhoa", benhAnPhaThaiIII.TienSuSanPhuKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("SoConHienCo", benhAnPhaThaiIII.SoConHienCo));
                Command.Parameters.Add(new MDB.MDBParameter("SoConTrai", benhAnPhaThaiIII.SoConTrai));
                Command.Parameters.Add(new MDB.MDBParameter("SoConGai", benhAnPhaThaiIII.SoConGai));
                Command.Parameters.Add(new MDB.MDBParameter("SoLanPhauThuatLayThai", benhAnPhaThaiIII.SoLanPhauThuatLayThai));
                Command.Parameters.Add(new MDB.MDBParameter("NamPhauThuatLayThaiCuoi", benhAnPhaThaiIII.NamPhauThuatLayThaiCuoi));
                Command.Parameters.Add(new MDB.MDBParameter("CacPhauThuatTCKhac", benhAnPhaThaiIII.CacPhauThuatTCKhac));
                Command.Parameters.Add(new MDB.MDBParameter("CacPhauThuatTCKhac_Nam", benhAnPhaThaiIII.CacPhauThuatTCKhac_Nam));
                Command.Parameters.Add(new MDB.MDBParameter("SoLanPhaThai", benhAnPhaThaiIII.SoLanPhaThai));
                Command.Parameters.Add(new MDB.MDBParameter("NgayPhaThaiGanNhat", benhAnPhaThaiIII.NgayPhaThaiGanNhat));
                Command.Parameters.Add(new MDB.MDBParameter("BienPhapTTDangSuDung", benhAnPhaThaiIII.BienPhapTTDangSuDung));
                Command.Parameters.Add(new MDB.MDBParameter("TieuSuBenh", benhAnPhaThaiIII.TieuSuBenh));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangHonNhan", benhAnPhaThaiIII.TinhTrangHonNhan));

                Command.Parameters.Add(new MDB.MDBParameter("DUThuoc_Ten", benhAnPhaThaiIII.DUThuoc_Ten));
                Command.Parameters.Add(new MDB.MDBParameter("DUThuoc_CoSoLan", benhAnPhaThaiIII.DUThuoc_CoSoLan));
                Command.Parameters.Add(new MDB.MDBParameter("DUThuoc_Khong", benhAnPhaThaiIII.DUThuoc_Khong ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("DUThuoc_BieuHien", benhAnPhaThaiIII.DUThuoc_BieuHien));

                Command.Parameters.Add(new MDB.MDBParameter("DUConTrung_Ten", benhAnPhaThaiIII.DUConTrung_Ten));
                Command.Parameters.Add(new MDB.MDBParameter("DUConTrung_CoSoLan", benhAnPhaThaiIII.DUConTrung_CoSoLan));
                Command.Parameters.Add(new MDB.MDBParameter("DUConTrung_Khong", benhAnPhaThaiIII.DUConTrung_Khong ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("DUConTrung_BieuHien", benhAnPhaThaiIII.DUConTrung_BieuHien));

                Command.Parameters.Add(new MDB.MDBParameter("DUThucPham_Ten", benhAnPhaThaiIII.DUThucPham_Ten));
                Command.Parameters.Add(new MDB.MDBParameter("DUThucPham_CoSoLan", benhAnPhaThaiIII.DUThucPham_CoSoLan));
                Command.Parameters.Add(new MDB.MDBParameter("DUThucPham_Khong", benhAnPhaThaiIII.DUThucPham_Khong ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("DUThucPham_BieuHien", benhAnPhaThaiIII.DUThucPham_BieuHien));

                Command.Parameters.Add(new MDB.MDBParameter("DUTacNhanKhac_Ten", benhAnPhaThaiIII.DUTacNhanKhac_Ten));
                Command.Parameters.Add(new MDB.MDBParameter("DUTacNhanKhac_CoSoLan", benhAnPhaThaiIII.DUTacNhanKhac_CoSoLan));
                Command.Parameters.Add(new MDB.MDBParameter("DUTacNhanKhac_Khong", benhAnPhaThaiIII.DUTacNhanKhac_Khong ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("DUTacNhanKhac_BieuHien", benhAnPhaThaiIII.DUTacNhanKhac_BieuHien));

                Command.Parameters.Add(new MDB.MDBParameter("DUCaNhanKhac_Ten", benhAnPhaThaiIII.DUCaNhanKhac_Ten));
                Command.Parameters.Add(new MDB.MDBParameter("DUCaNhanKhac_CoSoLan", benhAnPhaThaiIII.DUCaNhanKhac_CoSoLan));
                Command.Parameters.Add(new MDB.MDBParameter("DUCaNhanKhac_Khong", benhAnPhaThaiIII.DUCaNhanKhac_Khong ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("DUCaNhanKhac_BieuHien", benhAnPhaThaiIII.DUCaNhanKhac_BieuHien));

                Command.Parameters.Add(new MDB.MDBParameter("DUDiTruyen_Ten", benhAnPhaThaiIII.DUDiTruyen_Ten));
                Command.Parameters.Add(new MDB.MDBParameter("DUDiTruyen_CoSoLan", benhAnPhaThaiIII.DUDiTruyen_CoSoLan));
                Command.Parameters.Add(new MDB.MDBParameter("DUDiTruyen_Khong", benhAnPhaThaiIII.DUDiTruyen_Khong ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("DUDiTruyen_BieuHien", benhAnPhaThaiIII.DUDiTruyen_BieuHien));

                Command.Parameters.Add(new MDB.MDBParameter("CacBoPhan", benhAnPhaThaiIII.CacBoPhan));
                Command.Parameters.Add(new MDB.MDBParameter("NgayDauKyKinhCuoi", benhAnPhaThaiIII.NgayDauKyKinhCuoi));
                Command.Parameters.Add(new MDB.MDBParameter("TuoiThai", benhAnPhaThaiIII.TuoiThai));
                Command.Parameters.Add(new MDB.MDBParameter("AmHo", benhAnPhaThaiIII.AmHo));
                Command.Parameters.Add(new MDB.MDBParameter("AmDao", benhAnPhaThaiIII.AmDao));
                Command.Parameters.Add(new MDB.MDBParameter("CoTuCung", benhAnPhaThaiIII.CoTuCung));
                Command.Parameters.Add(new MDB.MDBParameter("TuCungChiTiet", benhAnPhaThaiIII.TuCungChiTiet));
                Command.Parameters.Add(new MDB.MDBParameter("PhanPhuPhai", benhAnPhaThaiIII.PhanPhuPhai));
                Command.Parameters.Add(new MDB.MDBParameter("PhanPhuTrai", benhAnPhaThaiIII.PhanPhuTrai));
                Command.Parameters.Add(new MDB.MDBParameter("CacXetNghiemCanLam", benhAnPhaThaiIII.CacXetNghiemCanLam));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTuoiThai", benhAnPhaThaiIII.ChanDoanTuoiThai));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapPhaThai", benhAnPhaThaiIII.PhuongPhapPhaThai));
                Command.Parameters.Add(new MDB.MDBParameter("NgayKhamBenh", benhAnPhaThaiIII.NgayKhamBenh));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyLamBenhAn", benhAnPhaThaiIII.BacSyLamBenhAn));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTuanThaiTongKet", benhAnPhaThaiIII.ChanDoanTuanThaiTongKet));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapPhaThaiTongKet", benhAnPhaThaiIII.PhuongPhapPhaThaiTongKet));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangSauKhiPhaThai", benhAnPhaThaiIII.TinhTrangSauKhiPhaThai));
                Command.Parameters.Add(new MDB.MDBParameter("TongSoGio", benhAnPhaThaiIII.TongSoGio));
                Command.Parameters.Add(new MDB.MDBParameter("TaiBien", benhAnPhaThaiIII.TaiBien));
                Command.Parameters.Add(new MDB.MDBParameter("RaVe", benhAnPhaThaiIII.RaVe));
                Command.Parameters.Add(new MDB.MDBParameter("ChuyenTuyenLuc", benhAnPhaThaiIII.ChuyenTuyenLuc));
                Command.Parameters.Add(new MDB.MDBParameter("LyDoNhapVien", benhAnPhaThaiIII.LyDoNhapVien));
                Command.Parameters.Add(new MDB.MDBParameter("LyDoChuyenTuyen", benhAnPhaThaiIII.LyDoChuyenTuyen));
                Command.Parameters.Add(new MDB.MDBParameter("BienPhapTranhThaiSauPhaThaiTK", benhAnPhaThaiIII.BienPhapTranhThaiSauPhaThaiTK));
                Command.Parameters.Add(new MDB.MDBParameter("KhamLaiBatThuong", benhAnPhaThaiIII.KhamLaiBatThuong));
                Command.Parameters.Add(new MDB.MDBParameter("KhamLaiTheoHen", benhAnPhaThaiIII.KhamLaiTheoHen));
                Command.Parameters.Add(new MDB.MDBParameter("KetLuan", benhAnPhaThaiIII.KetLuan));
                Command.Parameters.Add(new MDB.MDBParameter("LanhDaoDonVi", benhAnPhaThaiIII.LanhDaoDonVi));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiTongKet", benhAnPhaThaiIII.NguoiTongKet));
                Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", benhAnPhaThaiIII.NgayTongKet));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", benhAnPhaThaiIII.NguoiNhanHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", benhAnPhaThaiIII.NguoiGiaoHoSo));
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
        public static bool Delete(MDB.MDBConnection MyConnection, BenhAnPhaThaiIII BenhAnPhaThaiIII)
        {
            string sql = @"DELETE FROM BenhAnPhaThaiIII 
                           WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnPhaThaiIII.MaQuanLy));

            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
    }
}
