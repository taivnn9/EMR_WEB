using Newtonsoft.Json;
using PMS.Access;
using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Globalization;
using System.Linq;

namespace EMR_MAIN
{
    public class HanhChinhBenhNhanFunc
    {
        public static void WriteXml(MDB.MDBConnection MyConnection)
        {
            string sql =
                   @"
                   select * from hanhchinhbenhnhan a inner  join thongtindieutri b on a.mabenhnhan = b.mabenhnhan
                   where rownum = 1
                    ";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            var DataTable = new DataTable { TableName = "ThongTinHanhChinh" };
            DataTable.Load(DataReader as IDataReader);
            DataTable.WriteXml("ThongTinHanhChinh.xml");
        }
        public static DataSet SelectDataSet(MDB.MDBConnection MyConnection, string MaBenhNhan)
        {
            //string sql =
            //       @"
            //      select * from hanhchinhbenhnhan a inner  join thongtindieutri b on a.mabenhnhan = b.mabenhnhan
            //      where a.MaBenhNhan = '" + MaBenhNhan + "'";
            string sql =
                   @"
                  select a.*, b.*, c.hovaten GiamDocBenhVien, d.hovaten TruongKhoa,  e.hovaten ThayThuocKhamBenh, f.hovaten TruongPhongKHTH , g.hovaten ThayThuocDieuTri from hanhchinhbenhnhan a 
                  left  join thongtindieutri b on a.mabenhnhan = b.mabenhnhan
                  left join nhanvien c on b.MaGiamDocBenhVien = c.manhanvien
                  left join nhanvien d on b.MaTruongKhoa = d.manhanvien
                  left join nhanvien e on b.MaThayThuocKhamBenh = e.manhanvien
                  left join nhanvien f on b.MaTruongPhongKHTH = f.manhanvien
                  left join nhanvien g on b.MaThayThuocDieuTri = g.manhanvien
                  where a.MaBenhNhan = '" + MaBenhNhan + "'";
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(sql, MyConnection);
            var ds = new DataSet();
            adt.Fill(ds);
            return ds;
        }

        public static DataSet SelectDataSetWithMaQuanLy(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql = @"select a.* , b.* , c.hovaten GiamDocBenhVien, d.hovaten TruongKhoa,  e.hovaten ThayThuocKhamBenh, f.hovaten TruongPhongKHTH , g.hovaten ThayThuocDieuTri ";
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.NoiTruYHCT)
            {
                sql = sql + ", h.ChanDoan_NoiChuyenDen_YHCT, h.MaICD_NoiChuyenDen_YHCT, h.ChanDoan_KKB_CapCuu_YHCT, h.MaICD_KKB_CapCuu_YHCT, h.BenhChinh_YHCT, h.MaICD_BenhChinh_YHCT, h.BenhKemTheo_YHCT, h.MaICD_BenhKemTheo_YHCT, h.ThuThuat_YHCT, h.PhauThuat_YHCT, h.BenhChinh_RV_YHCT, h.MaICD_BenhChinh_RV_YHCT, h.BenhKemTheo_RV_YHCT, h.MaICD_BenhKemTheo_RV_YHCT, h.TaiBien_YHCT, h.BienChung_YHCT, h.MaICD_BenhKemTheo_YHHD ";
            }
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTruYHCT)
            {
                sql = sql + " , h.MaICD_BenhKemTheo_RV_YHCT,h.MaICD_NoiChuyenDen_YHCT,h.ChanDoan_KKB_CapCuu_YHCT,h.MaICD_KKB_CapCuu_YHCT,h.MaICD_BenhChinh_YHCT,h.BenhKemTheo_YHCT,h.MaICD_BenhKemTheo_YHCT,h.MaICD_BenhChinh_RV_YHCT,h.BenhKemTheo_RV_YHCT,h.MaICD_BenhKemTheo_YHHD,h.TaiBien_YHCT,h.BienChung_YHCT,h.ThuThuat_YHCT,h.BietDanh,h.BatCuong,h.TangPhuKinhLac,h.KinhMach,h.NguyenNhan,h.ChanDoanRaVienTheoYHCT ";
            }
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.Bong)
            {
                sql = sql + ", h.ThoiGianBiBong ";
            }

            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.ThanNhanTao)
            {
                sql = sql + ", h.QuaTrinhBenhLy,h.TienSuBenhBanThan,h.TienSuBenhGiaDinh ";
            }
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.SanKhoa)
            {
                sql = sql + ", h.KinhCuoiCungTuNgay, h.KinhCuoiCungDenNgay, h.KhongNhoNgayKinhCuoi, h.KinhKhacThuong, h.TuoiThai, h.NgayThai, h.KhamThaiTai, h.TiemPhongUonVan, h.Phu, h.DuocTiem, h.SoMuiKhau, h.BatDauChuyenDaTu, h.DauHieuLucDau, h.BienChuyen, h.BatDauThayKinhNam, h.TuoiThayKinh, h.TinhChatKinhNguyet, h.ChuKy, h.SoNgayThayKinh, h.LuongKinh, h.KinhLanCuoiNgay, h.DauBung, h.LayChongNam, h.TuoiLayChong, h.HetKinhNam, h.TuoiHetKinh, h.Truoc, h.Sau, h.Trong, h.NhungBenhPhuKhoaDaDieuTri, h.ToanTrang, h.ToanTrang_Phu, h.BungCoSeoPhauThuatCu, h.HinhDangTuCung, h.TuThe, h.ChieuCaoTC, h.VongBung, h.ConCoTC, h.TimThai, h.Vu, h.ChanDoanKhiVaoKhoa, h.ChiSoBishop, h.AmHo, h.AmDao, h.TangSinhMon, h.CoTuCung, h.PhanPhu, h.TinhTrangOiID, h.OiVoLuc, h.OiVoID, h.MauSacNuocOi, h.NuocOiNhieuHayIt, h.Ngoi, h.The_KhamTrong, h.KieuThe, h.DoLotID, h.DuongKinhNhoHaVe, h.KhiVaoKhoa, h.PhuongPhapChinh, h.ThoiGianVaoBuongDe, h.ThoiGianDe, h.TenNguoiTheoDoi, h.ChucDanh, h.Apgar_1, h.Apgar_5, h.Apgar_10, h.CanNang, h.CanNangRau, h.Cao, h.VongDau, h.DonThai, h.DaThai, h.TatBamSinh, h.CoHauMon, h.CuTheDiTatBamSinh, h.TinhTrangSoSinhSauKhiDe, h.XuLyVaKetQua, h.Rau, h.RauCuonCo, h.ThoiGianRauSo, h.CachSoRau, h.MatMang, h.MatMui, h.BanhRau, h.CanNangSoRau, h.RauCuonDai, h.CoChayMauSauSo, h.LuongMauMat, h.KiemSoatTuCung, h.XuLyVaKetQuaSoRau, h.DaNiemMac, h.PhuongPhapDeID, h.LyDoCanThiep, h.TangSinhMonID, h.PhuongPhapKhauChi, h.ChuanDoanTruocPhauThuat, h.ChuanDoanSauPhauThuat, h.CoTuCungID, h.TaiBienPhauThuat, h.BienChung, h.LyDoBienChung, h.Mach, h.NhietDo, h.HuyetAp, h.NhipTho ";
            }
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTru)
            {
                sql = sql + ", h.*, ff.hovaten BacSyLamBenhAnHoVaTen ,cc.hovaten BacSyDieuTriHoVaTen,dd.hovaten NguoiGiaoHoSoHoVaTen,ee.hovaten NguoiNhanHoSoHoVaTen ";
            }
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.LuuCapCuu)
            {
                sql = sql + ", h.*, ff.hovaten BacSyLamBenhAnHoVaTen ";
            }
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTruRangHamMat)
            {
                sql = sql + ", h.*, ff.hovaten BacSyLamBenhAnHoVaTen ";
            }
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.CMU)
            {
                sql = sql + ", h.DienThoaiDiDong,h.NgheNghiepDiLamLauNhat,h.NgayLaphoSo ";
            }
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.BANgoaTruPK)
            {
                sql = sql + " ,h.*";
            }
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.PhaThaiIII)
            {
                sql = sql + ", h.TuoiThai,h.PhuongPhapPhaThai ";
            }
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTruPhucHoiChucNang)
            {
                sql = sql + ", h.*, gg.hovaten GIAMDOCBENHVIENHOVATEN, ff.hovaten BacSyLamBenhAnHoVaTen ,cc.hovaten BacSyDieuTriHoVaTen,dd.hovaten NguoiGiaoHoSoHoVaTen,ee.hovaten NguoiNhanHoSoHoVaTen ";
            }
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.PhucHoiChucNangNhi)
            {
                sql = sql + ", h.LoaiDieuTri ";
            }
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.PHCNII)
            {
                sql = sql + ", h.LoaiDieuTri ";
            }
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTru_VayNenThuongThuong)
            {
                sql = sql + ", h.DieuTriNgoaiTruTu,  h.DieuTriNgoaiTruDen, h.SoCMND, h.BaoHiem, h.ChanDoan_TuyenTruoc, h.ChanDoanBanDau, h.ChanDoanTaiKham1, h.ChanDoanTaiKham2, h.ChanDoanTaiKham3, h.ChanDoanTaiKham4, h.BenhPhu, h.KetQuaDieuTri KetQuaDieuTriNgoaiTru, h.BienChung_Text, ff.HoVaTen GDPhongKeHoach, gg.HoVaTen GDPhongKhamBenh ";
            }
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTru_AVayNen)
            {
                sql = sql + ", h.*, ff.HoVaTen GDPhongKeHoach, gg.HoVaTen GDPhongKhamBenh ";
            }
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTru_HoTroSinhSan)
            {
                sql = sql + ", h.* ";
            }
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTru_BenhAnViemBiCo)
            {
                sql = sql + ", h.DieuTriNgoaiTruTu,  h.DieuTriNgoaiTruDen, h.SoCMND, h.BaoHiem, h.ChanDoan_TuyenTruoc, h.ChanDoanBanDau, h.ChanDoanTaiKham1, h.ChanDoanTaiKham2, h.ChanDoanTaiKham3, h.ChanDoanTaiKham4, h.BenhPhu, h.KetQuaDieuTri KetQuaDieuTriNgoaiTru, h.BienChung_Text, ff.HoVaTen GDPhongKeHoach, gg.HoVaTen GDPhongKhamBenh ";
            }
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTru_BenhAnLupusBanDoHeThong)
            {
                sql = sql + ", h.DieuTriNgoaiTruTu,  h.DieuTriNgoaiTruDen, h.SoCMND, h.BaoHiem, h.ChanDoan_TuyenTruoc, h.ChanDoanBanDau, h.ChanDoanTaiKham1, h.ChanDoanTaiKham2, h.ChanDoanTaiKham3, h.ChanDoanTaiKham4, h.BenhPhu, h.KetQuaDieuTri KetQuaDieuTriNgoaiTru, h.BienChung_Text, ff.HoVaTen GDPhongKeHoach, gg.HoVaTen GDPhongKhamBenh ";
            }
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTru_PEMPHIGOID)
            {
                sql = sql + ", h.DieuTriNgoaiTruTu,  h.DieuTriNgoaiTruDen, h.SoCMND, h.BaoHiem, h.ChanDoan_TuyenTruoc, h.ChanDoanBanDau, h.ChanDoanTaiKham1, h.ChanDoanTaiKham2, h.ChanDoanTaiKham3, h.ChanDoanTaiKham4, h.BenhPhu, h.KetQuaDieuTri KetQuaDieuTriNgoaiTru, h.BienChung_Text, ff.HoVaTen GDPhongKeHoach, gg.HoVaTen GDPhongKhamBenh ";
            }
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.DaLieuTW)
            {
                sql = sql + ", ff.HoVaTen BacSyChuyenVaoVienHoTen, gg.HoVaTen BacSyNhapChanDoanHoTen ";
            }
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTru_VayPhanDoNangLong)
            {
                sql = sql + ", h.DieuTriNgoaiTruTu,  h.DieuTriNgoaiTruDen, h.SoCMND, h.BaoHiem, h.ChanDoan_TuyenTruoc, h.ChanDoanBanDau, h.ChanDoanTaiKham1, h.ChanDoanTaiKham2, h.ChanDoanTaiKham3, h.ChanDoanTaiKham4, h.BenhPhu, h.KetQuaDieuTri KetQuaDieuTriNgoaiTru, h.BienChung_Text, ff.HoVaTen GDPhongKeHoach, gg.HoVaTen GDPhongKhamBenh ";
            }
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTru_LuPusBanDoManTinh)
            {
                sql = sql + ", h.DieuTriNgoaiTruTu,  h.DieuTriNgoaiTruDen, h.SoCMND, h.BaoHiem, h.ChanDoan_TuyenTruoc, h.ChanDoanBanDau, h.ChanDoanTaiKham1, h.ChanDoanTaiKham2, h.ChanDoanTaiKham3, h.ChanDoanTaiKham4, h.BenhPhu, h.KetQuaDieuTri KetQuaDieuTriNgoaiTru, h.BienChung_Text, ff.HoVaTen GDPhongKeHoach, gg.HoVaTen GDPhongKhamBenh ";
            }
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTru_VayNenTheMu)
            {
                sql = sql + ", h.DieuTriNgoaiTruTu,  h.DieuTriNgoaiTruDen, h.SoCMND, h.BaoHiem, h.ChanDoan_TuyenTruoc, h.ChanDoanBanDau, h.ChanDoanTaiKham1, h.ChanDoanTaiKham2, h.ChanDoanTaiKham3, h.ChanDoanTaiKham4, h.BenhPhu, h.KetQuaDieuTri KetQuaDieuTriNgoaiTru, h.BienChung_Text, ff.HoVaTen GDPhongKeHoach, gg.HoVaTen GDPhongKhamBenh ";
            }
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTru_DuhringBrocq)
            {
                sql = sql + ", h.DieuTriNgoaiTruTu,  h.DieuTriNgoaiTruDen, h.SoCMND, h.BaoHiem, h.ChanDoan_TuyenTruoc, h.ChanDoanBanDau, h.ChanDoanTaiKham1, h.ChanDoanTaiKham2, h.ChanDoanTaiKham3, h.ChanDoanTaiKham4, h.BenhPhu, h.KetQuaDieuTri KetQuaDieuTriNgoaiTru, h.BienChung_Text, ff.HoVaTen GDPhongKeHoach, gg.HoVaTen GDPhongKhamBenh ";
            }
            if(XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.DaiThaoDuong)
            {
                sql = sql + ", h.LyDoNhanVaoChuongTrinh ";
            }
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTru_UngThuDaHacTo)
            {
                sql = sql + ", h.DieuTriNgoaiTruTu,  h.DieuTriNgoaiTruDen, h.SoCMND, h.BaoHiem, h.ChanDoan_TuyenTruoc, h.ChanDoanBanDau, h.ChanDoanTaiKham1, h.ChanDoanTaiKham2, h.ChanDoanTaiKham3, h.ChanDoanTaiKham4, h.BenhPhu, h.KetQuaDieuTri KetQuaDieuTriNgoaiTru, h.BienChung_Text, ff.HoVaTen GDPhongKeHoach, gg.HoVaTen GDPhongKhamBenh ";
            }
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTru_UngThuDaKhongHacTo)
            {
                sql = sql + ", h.DieuTriNgoaiTruTu,  h.DieuTriNgoaiTruDen, h.SoCMND, h.BaoHiem, h.ChanDoan_TuyenTruoc, h.ChanDoanBanDau, h.ChanDoanTaiKham1, h.ChanDoanTaiKham2, h.ChanDoanTaiKham3, h.ChanDoanTaiKham4, h.BenhPhu, h.KetQuaDieuTri KetQuaDieuTriNgoaiTru, h.BienChung_Text, ff.HoVaTen GDPhongKeHoach, gg.HoVaTen GDPhongKhamBenh ";
            }
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTru_Pemphigus)
            {
                sql = sql + ", h.DieuTriNgoaiTruTu,  h.DieuTriNgoaiTruDen, h.SoCMND, h.BaoHiem, h.ChanDoan_TuyenTruoc, h.ChanDoanBanDau, h.ChanDoanTaiKham1, h.ChanDoanTaiKham2, h.ChanDoanTaiKham3, h.ChanDoanTaiKham4, h.BenhPhu, h.KetQuaDieuTri KetQuaDieuTriNgoaiTru, h.BienChung_Text, ff.HoVaTen GDPhongKeHoach, gg.HoVaTen GDPhongKhamBenh ";
            }
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTru_VayNenTheKhop)
            {
                sql = sql + ", h.DieuTriNgoaiTruTu,  h.DieuTriNgoaiTruDen, h.SoCMND, h.BaoHiem, h.ChanDoan_TuyenTruoc, h.ChanDoanBanDau, h.ChanDoanTaiKham1, h.ChanDoanTaiKham2, h.ChanDoanTaiKham3, h.ChanDoanTaiKham4, h.BenhPhu, h.KetQuaDieuTri KetQuaDieuTriNgoaiTru, h.BienChung_Text, ff.HoVaTen GDPhongKeHoach, gg.HoVaTen GDPhongKhamBenh ";
            }
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTru_HoiChungTrungLap)
            {
                sql = sql + ", h.DieuTriNgoaiTruTu,  h.DieuTriNgoaiTruDen, h.SoCMND, h.BaoHiem, h.ChanDoan_TuyenTruoc, h.ChanDoanBanDau, h.ChanDoanTaiKham1, h.ChanDoanTaiKham2, h.ChanDoanTaiKham3, h.ChanDoanTaiKham4, h.BenhPhu, h.KetQuaDieuTri KetQuaDieuTriNgoaiTru, h.BienChung_Text, ff.HoVaTen GDPhongKeHoach, gg.HoVaTen GDPhongKhamBenh ";
            }
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.PhoiTacNghenManTinh)
            {
                sql = sql + ", h.SHS,  h.NgayLapHoSo, h.DienThoaiNhaRieng, ff.hovaten BacSyPhuTrachHoVaTen ";
            }
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.BenhTangHuyetAp)
            {
                sql = sql + ", h.SoLuu ";
            }
            sql = sql + "from hanhchinhbenhnhan a "
             + "inner join thongtindieutri b on a.mabenhnhan = b.mabenhnhan "
             + "left join nhanvien c on b.MaGiamDocBenhVien = c.manhanvien "
             + "left join nhanvien d on b.MaTruongKhoa = d.manhanvien "
             + "left join nhanvien e on b.MaThayThuocKhamBenh = e.manhanvien "
             + "left join nhanvien f on b.MaTruongPhongKHTH = f.manhanvien "
             + "left join nhanvien g on b.MaThayThuocDieuTri = g.manhanvien ";
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTru)
            {
                sql = sql + "left join BenhAnNgoaiTru h " +
                    "left join nhanvien cc on h.bacsydieutri = cc.manhanvien " +
                    "left join nhanvien dd on h.nguoigiaohoso = dd.manhanvien " +
                    "left join nhanvien ee on h.nguoinhanhoso = ee.manhanvien " +
                    "left join nhanvien ff on h.BacSyLamBenhAn = ff.manhanvien " +
                    " on b.MaQuanLy = h.MaQuanLy ";
            }
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.LuuCapCuu)
            {
                sql = sql + "left join BenhAnLuuCapCuu h on b.MaQuanLy = h.MaQuanLy " +
                    "left join nhanvien ff on h.BacSyLamBenhAn = ff.manhanvien ";
            }
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.NoiTruYHCT)
            {
                sql = sql + "left join benhannoitruyhct h on b.MaQuanLy = h.MaQuanLy ";
            }
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTruYHCT)
            {
                sql = sql + "left join BenhAnNgoaiTruYHCT h on b.MaQuanLy = h.MaQuanLy ";
            }
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.Bong)
            {
                sql = sql + "left join BenhAnBong h on b.MaQuanLy = h.MaQuanLy ";
            }
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.ThanNhanTao)
            {
                sql = sql + "left join BenhAnThanNhanTao h on b.MaQuanLy = h.MaQuanLy ";
            }
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.SanKhoa)
            {
                sql = sql + "left join BenhAnSanKhoa h on b.MaQuanLy = h.MaQuanLy ";
            }
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTruRangHamMat)
            {
                sql = sql + "left join BenhAnNgoaiTruRangHamMat h on b.MaQuanLy = h.MaQuanLy " +
                  "left join nhanvien ff on h.BacSyLamBenhAn = ff.manhanvien ";
            }
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.CMU)
            {
                sql = sql + "left join BenhAnCMU h on b.MaQuanLy = h.MaQuanLy ";
            }
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.BANgoaTruPK)
            {
                sql = sql + " left join BenhAnNgoaiTruPK h on b.MaQuanLy = h.MaQuanLy ";
            }
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.PhaThaiIII)
            {
                sql = sql + "left join BenhAnPhaThaiIII h on b.MaQuanLy = h.MaQuanLy ";
            }
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTruPhucHoiChucNang)
            {
                sql = sql + "left join BenhAnNgoaiTruPHCN h " +
                     "left join nhanvien gg on h.IDGiamDoc = gg.manhanvien " +
                     "left join nhanvien cc on h.bacsydieutri = cc.manhanvien " +
                     "left join nhanvien dd on h.nguoigiaohoso = dd.manhanvien " +
                     "left join nhanvien ee on h.nguoinhanhoso = ee.manhanvien " +
                     "left join nhanvien ff on h.BacSyLamBenhAn = ff.manhanvien " +
                     " on b.MaQuanLy = h.MaQuanLy ";
            }
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.PhucHoiChucNangNhi)
            {
                sql = sql + "left join BenhAnPHCNNhi h " +
                     " on b.MaQuanLy = h.MaQuanLy ";
            }
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.PHCNII)
            {
                sql = sql + "left join BenhAnPHCNII h " +
                     " on b.MaQuanLy = h.MaQuanLy ";
            }
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTru_VayNenThuongThuong)
            {
                sql = sql + "left join BenhAnVayNenThongThuong h " +
                     "left join nhanvien ff on h.GDPhongKeHoach = ff.manhanvien " +
                     "left join nhanvien gg on h.GDPhongKhamBenh = gg.manhanvien " +
                     " on b.MaQuanLy = h.MaQuanLy ";
            }
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTru_AVayNen)
            {
                sql = sql + "left join BENHANNTAVAYNEN h " +
                     "left join nhanvien ff on h.GDPhongKeHoach = ff.manhanvien " +
                     "left join nhanvien gg on h.GDPhongKhamBenh = gg.manhanvien " +
                     " on b.MaQuanLy = h.MaQuanLy ";
            }
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTru_HoTroSinhSan)
            {
                sql = sql+ " left join BenhAnNgoaiTru_HTSS h " +
                     " on b.MaQuanLy = h.MaQuanLy ";
            }
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTru_BenhAnViemBiCo)
            {
                sql = sql + "left join BenhAnViemBiCo h " +
                     "left join nhanvien ff on h.GDPhongKeHoach = ff.manhanvien " +
                     "left join nhanvien gg on h.GDPhongKhamBenh = gg.manhanvien " +
                     " on b.MaQuanLy = h.MaQuanLy ";
            }
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTru_BenhAnLupusBanDoHeThong)
            {
                sql = sql + "left join BenhAnLupusBanDoHeThong h " +
                     "left join nhanvien ff on h.GDPhongKeHoach = ff.manhanvien " +
                     "left join nhanvien gg on h.GDPhongKhamBenh = gg.manhanvien " +
                     " on b.MaQuanLy = h.MaQuanLy ";
            }
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.DaLieuTW)
            {
                sql = sql + "left join BenhAnDaLieuTW h " +
                     "left join nhanvien ff on h.BacSyChuyenVaoVien = ff.manhanvien " +
                     "left join nhanvien gg on h.BacSyNhapChanDoan = gg.manhanvien " +
                     " on b.MaQuanLy = h.MaQuanLy ";
            }
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTru_PEMPHIGOID)
            {
                sql = sql + " left join BENHANNTPEMPHIGOID h " +
                     "left join nhanvien ff on h.GDPhongKeHoach = ff.manhanvien " +
                     "left join nhanvien gg on h.GDPhongKhamBenh = gg.manhanvien " +
                     " on b.MaQuanLy = h.MaQuanLy ";
            }
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTru_VayPhanDoNangLong)
            {
                sql = sql + "left join BenhAnVayPhanDoNangLong h " +
                     "left join nhanvien ff on h.GDPhongKeHoach = ff.manhanvien " +
                     "left join nhanvien gg on h.GDPhongKhamBenh = gg.manhanvien " +
                     " on b.MaQuanLy = h.MaQuanLy ";
            }
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTru_LuPusBanDoManTinh)
            {
                sql = sql + "left join BENHANDTNTLUPUSMANTINH h " +
                     "left join nhanvien ff on h.GDPhongKeHoach = ff.manhanvien " +
                     "left join nhanvien gg on h.GDPhongKhamBenh = gg.manhanvien " +
                     " on b.MaQuanLy = h.MaQuanLy ";
            }
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTru_VayNenTheMu)
            {
                sql = sql + "left join BenhAnVayNenTheMu h " +
                     "left join nhanvien ff on h.GDPhongKeHoach = ff.manhanvien " +
                     "left join nhanvien gg on h.GDPhongKhamBenh = gg.manhanvien " +
                     " on b.MaQuanLy = h.MaQuanLy ";
            }
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTru_DuhringBrocq)
            {
                sql = sql + "left join BenhAnNgoaiTruDuhringBrocq h " +
                     "left join nhanvien ff on h.GDPhongKeHoach = ff.manhanvien " +
                     "left join nhanvien gg on h.GDPhongKhamBenh = gg.manhanvien " +
                     " on b.MaQuanLy = h.MaQuanLy ";
            }
            if(XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.DaiThaoDuong)
            {
                sql = sql + "left join BenhAnDaiThaoDuong h " + 
                   " on b.MaQuanLy = h.MaQuanLy ";
            }
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTru_UngThuDaHacTo)
            {
                sql = sql + "left join BenhAnUngThuHacTo h " +
                    "left join nhanvien ff on h.GDPhongKeHoach = ff.manhanvien " +
                    "left join nhanvien gg on h.GDPhongKhamBenh = gg.manhanvien " +
                    " on b.MaQuanLy = h.MaQuanLy ";
            }
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTru_UngThuDaKhongHacTo)
            {
                sql = sql + "left join BenhAnUngThuKhongHacTo h " +
                    "left join nhanvien ff on h.GDPhongKeHoach = ff.manhanvien " +
                    "left join nhanvien gg on h.GDPhongKhamBenh = gg.manhanvien " +
                    " on b.MaQuanLy = h.MaQuanLy ";
            }
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTru_Pemphigus)
            {
                sql = sql + "left join BenhAnNgoaiTruPemphigus h " +
                    "left join nhanvien ff on h.GDPhongKeHoach = ff.manhanvien " +
                    "left join nhanvien gg on h.GDPhongKhamBenh = gg.manhanvien " +
                    " on b.MaQuanLy = h.MaQuanLy ";
            }
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTru_VayNenTheKhop)
            {
                sql = sql + "left join BenhAnVayNenTheKhop h " +
                    "left join nhanvien ff on h.GDPhongKeHoach = ff.manhanvien " +
                    "left join nhanvien gg on h.GDPhongKhamBenh = gg.manhanvien " +
                    " on b.MaQuanLy = h.MaQuanLy ";
            }
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTru_HoiChungTrungLap)
            {
                sql = sql + "left join BenhAnHoiChungTrungLap h " +
                    "left join nhanvien ff on h.GDPhongKeHoach = ff.manhanvien " +
                    "left join nhanvien gg on h.GDPhongKhamBenh = gg.manhanvien " +
                    " on b.MaQuanLy = h.MaQuanLy ";
            }
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.PhoiTacNghenManTinh)
            {
                sql = sql + "left join BenhAnPhoiTacNghenManTinh h " +
                 "left join nhanvien ff on h.BacSyPhuTrach = ff.manhanvien " +
                 " on b.MaQuanLy = h.MaQuanLy ";
            }
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.BenhTangHuyetAp)
            {
                sql = sql + "left join BenhAnTangHuyetAp h " +
                " on b.MaQuanLy = h.MaQuanLy ";
            }
            sql = sql + "where b.MaQuanLy = " + MaQuanLy.ToString(CultureInfo.InvariantCulture);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(sql, MyConnection);
            var ds = new DataSet();
            adt.Fill(ds);

            //http://redmine.vietsens.vn:8080/redmine/issues/38165
            try
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    DataRow row = ds.Tables[0].Rows[0];
                    string dantoc = row["MaDanhToc"].ToString();
                    string maDanToc = row["MaDanhToc"].ToString();
                    if ("KINH".Equals(dantoc.ToUpper().Trim()) || "01".Equals(maDanToc) || "1".Equals(maDanToc))
                    {
                        ds.Tables[0].Rows[0]["MaDanhToc"] = "25";
                    }
                    if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.BANgoaTruPK)
                    {
                        ds.Tables[0].Columns.Add("DiaChi");
                        ds.Tables[0].Rows[0]["DiaChi"] = Common.GetDiaChi();
                    }
                }
            }
            catch (Exception ex) { }
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.LuuCapCuu)
            {
                string sql2 = @"select a.ThongTinYLenhs
                  from BenhAnLuuCapCuu a
                  where a.maquanly = " + MaQuanLy.ToString(CultureInfo.InvariantCulture);
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                ObservableCollection<ThongTinYLenh> thongTinYLenhs = new ObservableCollection<ThongTinYLenh>();
                while (DataReader.Read())
                {
                    thongTinYLenhs = JsonConvert.DeserializeObject<ObservableCollection<ThongTinYLenh>>(DataReader["ThongTinYLenhs"].ToString());
                }
                if (thongTinYLenhs != null)
                {
                    DataTable table2 = new DataTable("Table2");
                    table2.Columns.Add("NgayGio");
                    table2.Columns.Add("DienBienBenh");
                    table2.Columns.Add("YLenh");
                    foreach (ThongTinYLenh thongTin in thongTinYLenhs)
                    {
                        table2.Rows.Add(thongTin.NgayGio.ToString("HH:mm dd/MM/yyyy"), thongTin.DienBienBenh, thongTin.YLenh);
                    }
                    ds.Tables.Add(table2);
                }
            }
            if(XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTruRangHamMat)
            {
                if (ds.Tables["Table"] != null && ds.Tables["Table"].Rows.Count > 0 && ERMDatabase.FTPImageString != null)
                {
                    ds.Tables["Table"].Rows[0]["Phai_HinhVe"] = ds.Tables["Table"].Rows[0]["Phai_HinhVe"].ToString().Contains("PaintLibrary") ? ds.Tables["Table"].Rows[0]["Phai_HinhVe"] : ERMDatabase.FTPImageString + ds.Tables["Table"].Rows[0]["Phai_HinhVe"];
                    ds.Tables["Table"].Rows[0]["Thang_HinhVe"] = ds.Tables["Table"].Rows[0]["Thang_HinhVe"].ToString().Contains("PaintLibrary") ? ds.Tables["Table"].Rows[0]["Thang_HinhVe"] : ERMDatabase.FTPImageString + ds.Tables["Table"].Rows[0]["Thang_HinhVe"];
                    ds.Tables["Table"].Rows[0]["Trai_HinhVe"] = ds.Tables["Table"].Rows[0]["Trai_HinhVe"].ToString().Contains("PaintLibrary") ? ds.Tables["Table"].Rows[0]["Trai_HinhVe"] : ERMDatabase.FTPImageString + ds.Tables["Table"].Rows[0]["Trai_HinhVe"];
                    ds.Tables["Table"].Rows[0]["HamTrenVaHong_HinhVe"] = ds.Tables["Table"].Rows[0]["HamTrenVaHong_HinhVe"].ToString().Contains("PaintLibrary") ? ds.Tables["Table"].Rows[0]["HamTrenVaHong_HinhVe"] : ERMDatabase.FTPImageString + ds.Tables["Table"].Rows[0]["HamTrenVaHong_HinhVe"];
                    ds.Tables["Table"].Rows[0]["HamDuoi_HinhVe"] = ds.Tables["Table"].Rows[0]["HamDuoi_HinhVe"].ToString().Contains("PaintLibrary") ? ds.Tables["Table"].Rows[0]["HamDuoi_HinhVe"] : ERMDatabase.FTPImageString + ds.Tables["Table"].Rows[0]["HamDuoi_HinhVe"];
                    ds.Tables["Table"].Rows[0]["PhanLoai_HinhVe"] = ds.Tables["Table"].Rows[0]["PhanLoai_HinhVe"].ToString().Contains("PaintLibrary") ? ds.Tables["Table"].Rows[0]["PhanLoai_HinhVe"] : ERMDatabase.FTPImageString + ds.Tables["Table"].Rows[0]["PhanLoai_HinhVe"];
                }
            }
            if (XemBenhAn._LoaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTru_HoTroSinhSan)
            {
                ObservableCollection<EMR_MAIN.DATABASE.BenhAn.TienSuSanKhoaVo> TienSuSanKhoaVo 
                    = JsonConvert.DeserializeObject<ObservableCollection<EMR_MAIN.DATABASE.BenhAn.TienSuSanKhoaVo>>(ds.Tables["Table"].Rows[0]["TienSuSanKhoaVo"].ToString());
         
                ds.Tables.Add(Common.ListToDataTable(TienSuSanKhoaVo.ToList(), "TS"));
            }
            //
            CauHinhVoBenhAnEMR cauHinhVoBenhAnEMR = CauHinhVoBenhAnEMRFunc.GetData(MyConnection);
            if (cauHinhVoBenhAnEMR.CheckChuyenVienRaVien == 1)
            {
                if (ds.Tables["Table"].Rows[0]["ChuyenVien"] != DBNull.Value && ds.Tables["Table"].Rows[0]["TinhTrangRaVien"] != DBNull.Value)
                {
                    ds.Tables["Table"].Rows[0]["TinhTrangRaVien"] = DBNull.Value;
                }
            }
            return ds;
        }

        public static HanhChinhBenhNhan Select(MDB.MDBConnection MyConnection, string MaBenhNhan)
        {
            #region
            string sql =
                      @"select * 
                        from HanhChinhBenhNhan a
                        where MaBenhNhan = :MaBenhNhan";
            #endregion
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add("MaBenhNhan", MaBenhNhan);
            MDB.MDBDataReader rd = Command.ExecuteReader();
            HanhChinhBenhNhan hc = null;

            try
            {
                while (rd.Read())
                {
                    hc = new HanhChinhBenhNhan()
                    {
                        HoVaTenBo = rd["HoVaTenBo"]?.ToString(),
                        HoVaTenMe = rd["HoVaTenMe"]?.ToString(),
                        NgheNghiepBo = rd["NgheNghiepBo"]?.ToString(),
                        NgheNghiepMe = rd["NgheNghiepMe"]?.ToString(),
                        TrinhDoVanHoaBo = rd["TrinhDoVanHoaBo"]?.ToString(),
                        TrinhDoVanHoaMe = rd["TrinhDoVanHoaMe"]?.ToString(),
                        NgaySinhBo = rd["NgaySinhBo"] != DBNull.Value ? (DateTime?)rd.GetDate("NgaySinhBo") : null,
                        NgaySinhMe = rd["NgaySinhMe"] != DBNull.Value ? (DateTime?)rd.GetDate("NgaySinhMe") : null,
                        DonVi = rd["DonVi"]?.ToString(),

                        //linh thêm, dùng trong sanbox
                        MaBenhNhan = rd["mabenhnhan"]?.ToString(),
                        TenBenhNhan = rd["tenbenhnhan"]?.ToString(),
                        NgaySinh = rd["NgaySinh"] != DBNull.Value ? (DateTime?)rd.GetDate("NgaySinh") : null,
                        GioiTinh = (GioiTinh)rd["GioiTinh"].ToInt32(),
                        BenhVien = rd["BenhVien"]?.ToString(),
                        CardCode = rd["CardCode"]?.ToString(),
                        CMND = rd["CMND"]?.ToString(),
                        DanToc = rd["DanToc"]?.ToString(),
                        DienThoaiLienLac = rd["DienThoaiLienLac"]?.ToString(),
                        HoTenDiaChiNguoiNha = rd["HoTenDiaChiNguoiNha"]?.ToString(),
                        HuyenQuan = rd["HuyenQuan"]?.ToString(),
                        MaDanhToc = rd["MaDanhToc"]?.ToString(),
                        MaHuyenQuan = rd["MaHuyenQuan"]?.ToString(),
                        MaNgheNghiep = rd["MaNgheNghiep"]?.ToString(),
                        MaNgheNghiepBo = rd["MaNgheNghiepBo"]?.ToString(),
                        MaNgheNghiepMe = rd["MaNgheNghiepMe"]?.ToString(),
                        MaNgoaiKieu = rd["MaNgoaiKieu"]?.ToString(),
                        MaTinhThanhPho = rd["MaTinhThanhPho"]?.ToString(),
                        MaNoiDangKyBHYT = rd["MaNoiDangKyBHYT"]?.ToString(),
                        MaXaPhuong = rd["MaXaPhuong"]?.ToString(),
                        MaYTe = rd["MaYTe"]?.ToString(),
                        NgheNghiep = rd["NgheNghiep"]?.ToString(),
                        NgoaiKieu = rd["NgoaiKieu"]?.ToString(),
                        NhomMauMe = rd["NhomMauMe"]?.ToString(),
                        NoiLamViec = rd["NoiLamViec"]?.ToString(),
                        SoDienThoaiNguoiNha = rd["SoDienThoaiNguoiNha"]?.ToString(),
                        SoNha = rd["SoNha"]?.ToString(),
                        SoTheBHYT = rd["SoTheBHYT"]?.ToString(),
                        SoYTe = rd["SoYTe"]?.ToString(),
                        ThonPho = rd["ThonPho"]?.ToString(),
                        TienThaiPara = rd["TienThaiPara"]?.ToString(),
                        TinhThanhPho = rd["TinhThanhPho"]?.ToString(),
                        Tuoi = rd["Tuoi"]?.ToString(),
                        XaPhuong = rd["XaPhuong"]?.ToString(),
                    };
                }
                return hc;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                rd.Close();
            }
        }
        public static bool checkHanhChinhBenhNhan(MDB.MDBConnection MyConnection, string mabenhNhan)
        {
            #region
            string sql =
                      @"select MaBenhNhan 
                        from HanhChinhBenhNhan
                        where MaBenhNhan = :MaBenhNhan";
            #endregion
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add("MaBenhNhan", mabenhNhan);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            int rowCount = 0;
            while (DataReader.Read()) rowCount++;
            DataReader.Close();
            return (rowCount == 1);
        }
        public static bool InsertOrUpdateHanhChinhBenhNhan(MDB.MDBConnection MyConnection, HanhChinhBenhNhan HanhChinhBenhNhan)
        {
            #region
            string sql =
                      @"select MaBenhNhan 
                        from HanhChinhBenhNhan
                        where MaBenhNhan = :MaBenhNhan";
            #endregion
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add("MaBenhNhan", HanhChinhBenhNhan.MaBenhNhan);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            int rowCount = 0;
            while (DataReader.Read()) rowCount++;
            DataReader.Close();
            if (rowCount == 1) return UpdateHanhChinhBenhNhan(MyConnection, HanhChinhBenhNhan);

            sql = @"
            INSERT INTO HanhChinhBenhNhan (SoYTe, BenhVien, MaYTe, MaBenhNhan, TenBenhNhan, NgaySinh, Tuoi, GioiTinh, NgheNghiep, MaNgheNghiep,MaNgheNghiepBo, MaNgheNghiepMe, DanToc, MaDanhToc, NgoaiKieu, MaNgoaiKieu, SoNha, ThonPho, XaPhuong, HuyenQuan, MaHuyenQuan, TinhThanhPho, MaTinhThanhPho, NoiLamViec, DoiTuong, NgayHetHanBHYT, SoTheBHYT, NgayDangKyBHYT, TenNoiDangKyBHYT, MaNoiDangKyBHYT, NgayDuocHuong5Nam, HoTenDiaChiNguoiNha, SoDienThoaiNguoiNha, HoVaTenBo, HoVaTenMe, NgheNghiepBo, NgheNghiepMe, TrinhDoVanHoaBo, TrinhDoVanHoaMe, NgaySinhMe, NgaySinhBo, DeLanMay, TienThaiPara, TienThaiParaID, NhomMauMe, TrinhDoVanHoa, DienThoaiLienLac, MaXaPhuong, CapBac, DonVi, CNKhuyetTat, DangKhuyetTat, MucDoKT, CMND, NoiCap_CMND, NgayCap_CMND)
            VALUES(:SoYTe, :BenhVien, :MaYTe, :MaBenhNhan, :TenBenhNhan, :NgaySinh, :Tuoi, :GioiTinh, :NgheNghiep, :MaNgheNghiep, :MaNgheNghiepBo, :MaNgheNghiepMe, :DanToc, :MaDanhToc, :NgoaiKieu, :MaNgoaiKieu, :SoNha, :ThonPho, :XaPhuong, :HuyenQuan, :MaHuyenQuan, :TinhThanhPho, :MaTinhThanhPho, :NoiLamViec, :DoiTuong, :NgayHetHanBHYT, :SoTheBHYT, :NgayDangKyBHYT, :TenNoiDangKyBHYT, :MaNoiDangKyBHYT, :NgayDuocHuong5Nam, :HoTenDiaChiNguoiNha, :SoDienThoaiNguoiNha, :HoVaTenBo, :HoVaTenMe, :NgheNghiepBo, :NgheNghiepMe, :TrinhDoVanHoaBo, :TrinhDoVanHoaMe, :NgaySinhMe, :NgaySinhBo, :DeLanMay, :TienThaiPara, :TienThaiParaID, :NhomMauMe, :TrinhDoVanHoa, :DienThoaiLienLac, :MaXaPhuong, :CapBac, :DonVi, :CNKhuyetTat, :DangKhuyetTat, :MucDoKT, :CMND, :NoiCap_CMND, :NgayCap_CMND)
            ";
            Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add("SoYTe", HanhChinhBenhNhan.SoYTe);
            Command.Parameters.Add("BenhVien", HanhChinhBenhNhan.BenhVien);
            Command.Parameters.Add("MaYTe", HanhChinhBenhNhan.MaYTe);
            Command.Parameters.Add("MaBenhNhan", HanhChinhBenhNhan.MaBenhNhan);
            Command.Parameters.Add("TenBenhNhan", HanhChinhBenhNhan.TenBenhNhan);
            Command.Parameters.Add("NgaySinh", HanhChinhBenhNhan.NgaySinh);
            Command.Parameters.Add("Tuoi", HanhChinhBenhNhan.Tuoi);
            Command.Parameters.Add("GioiTinh", (int)HanhChinhBenhNhan.GioiTinh);
            Command.Parameters.Add("NgheNghiep", HanhChinhBenhNhan.NgheNghiep);
            Command.Parameters.Add("MaNgheNghiep", HanhChinhBenhNhan.MaNgheNghiep);
            Command.Parameters.Add("MaNgheNghiepBo", HanhChinhBenhNhan.MaNgheNghiepBo);
            Command.Parameters.Add("MaNgheNghiepMe", HanhChinhBenhNhan.MaNgheNghiepMe);
            Command.Parameters.Add("DanToc", HanhChinhBenhNhan.DanToc);
            Command.Parameters.Add("MaDanhToc", HanhChinhBenhNhan.MaDanhToc);
            Command.Parameters.Add("NgoaiKieu", HanhChinhBenhNhan.NgoaiKieu);
            Command.Parameters.Add("MaNgoaiKieu", HanhChinhBenhNhan.MaNgoaiKieu);
            Command.Parameters.Add("SoNha", HanhChinhBenhNhan.SoNha);
            Command.Parameters.Add("ThonPho", HanhChinhBenhNhan.ThonPho);
            Command.Parameters.Add("XaPhuong", HanhChinhBenhNhan.XaPhuong);
            Command.Parameters.Add("HuyenQuan", HanhChinhBenhNhan.HuyenQuan);
            Command.Parameters.Add("MaHuyenQuan", HanhChinhBenhNhan.MaHuyenQuan);
            Command.Parameters.Add("TinhThanhPho", HanhChinhBenhNhan.TinhThanhPho);
            Command.Parameters.Add("MaTinhThanhPho", HanhChinhBenhNhan.MaTinhThanhPho);
            Command.Parameters.Add("NoiLamViec", HanhChinhBenhNhan.NoiLamViec);
            Command.Parameters.Add("DoiTuong", (int)HanhChinhBenhNhan.DoiTuong);
            Command.Parameters.Add("NgayHetHanBHYT", HanhChinhBenhNhan.NgayHetHanBHYT);
            Command.Parameters.Add("SoTheBHYT", HanhChinhBenhNhan.SoTheBHYT);
            Command.Parameters.Add("NgayDangKyBHYT", HanhChinhBenhNhan.NgayDangKyBHYT);
            Command.Parameters.Add("TenNoiDangKyBHYT", HanhChinhBenhNhan.TenNoiDangKyBHYT);
            Command.Parameters.Add("MaNoiDangKyBHYT", HanhChinhBenhNhan.MaNoiDangKyBHYT);
            Command.Parameters.Add("NgayDuocHuong5Nam", HanhChinhBenhNhan.NgayDuocHuong5Nam);
            Command.Parameters.Add("HoTenDiaChiNguoiNha", HanhChinhBenhNhan.HoTenDiaChiNguoiNha);
            Command.Parameters.Add("SoDienThoaiNguoiNha", HanhChinhBenhNhan.SoDienThoaiNguoiNha);
            Command.Parameters.Add("HoVaTenBo", HanhChinhBenhNhan.HoVaTenBo);
            Command.Parameters.Add("HoVaTenMe", HanhChinhBenhNhan.HoVaTenMe);
            Command.Parameters.Add("NgheNghiepBo", HanhChinhBenhNhan.NgheNghiepBo);
            Command.Parameters.Add("NgheNghiepMe", HanhChinhBenhNhan.NgheNghiepMe);
            Command.Parameters.Add("TrinhDoVanHoaBo", HanhChinhBenhNhan.TrinhDoVanHoaBo);
            Command.Parameters.Add("TrinhDoVanHoaMe", HanhChinhBenhNhan.TrinhDoVanHoaMe);
            Command.Parameters.Add("NgaySinhMe", HanhChinhBenhNhan.NgaySinhMe);
            Command.Parameters.Add("NgaySinhBo", HanhChinhBenhNhan.NgaySinhBo);
            Command.Parameters.Add("DeLanMay", HanhChinhBenhNhan.DeLanMay);
            Command.Parameters.Add("TienThaiPara", HanhChinhBenhNhan.TienThaiPara);
            Command.Parameters.Add("TienThaiParaID", HanhChinhBenhNhan.TienThaiParaID);
            Command.Parameters.Add("NhomMauMe", HanhChinhBenhNhan.NhomMauMe);
            Command.Parameters.Add("TrinhDoVanHoa", HanhChinhBenhNhan.TrinhDoVanHoa);
            Command.Parameters.Add("DienThoaiLienLac", HanhChinhBenhNhan.DienThoaiLienLac);
            Command.Parameters.Add("MaXaPhuong", HanhChinhBenhNhan.MaXaPhuong);
            Command.Parameters.Add("CapBac", HanhChinhBenhNhan.CapBac);
            Command.Parameters.Add("DonVi", HanhChinhBenhNhan.DonVi);
            Command.Parameters.Add("CNKhuyetTat", HanhChinhBenhNhan.CNKhuyetTat);
            Command.Parameters.Add("DangKhuyetTat", HanhChinhBenhNhan.DangKhuyetTat);
            Command.Parameters.Add("MucDoKT", HanhChinhBenhNhan.MucDoKT);
            Command.Parameters.Add("CMND", HanhChinhBenhNhan.CMND);
            Command.Parameters.Add("NoiCap_CMND", HanhChinhBenhNhan.NoiCap_CMND);
            Command.Parameters.Add("NgayCap_CMND", HanhChinhBenhNhan.NgayCap_CMND);
            int n = Command.ExecuteNonQuery(); // C#
            //XuLyLoi.LogDebug("dangtung - InsertOrUpdateHanhChinhBenhNhan return : " + n);
            return n > 0 ? true : false;
        }
        public static bool UpdateHanhChinhBenhNhan(MDB.MDBConnection MyConnection, HanhChinhBenhNhan HanhChinhBenhNhan)
        {
            string sql = @"UPDATE HanhChinhBenhNhan SET 
                        SoYTe = :SoYTe,
                        BenhVien = :BenhVien,
                        MaYTe = :MaYTe,
                        TenBenhNhan = :TenBenhNhan,
                        NgaySinh = :NgaySinh,
                        Tuoi = :Tuoi,
                        GioiTinh = :GioiTinh,
                        NgheNghiep = :NgheNghiep,
                        MaNgheNghiep = :MaNgheNghiep,
                        MaNgheNghiepBo = :MaNgheNghiepBo,
                        MaNgheNghiepMe = :MaNgheNghiepMe,
                        DanToc = :DanToc,
                        MaDanhToc = :MaDanhToc,
                        NgoaiKieu = :NgoaiKieu,
                        MaNgoaiKieu = :MaNgoaiKieu,
                        SoNha = :SoNha,
                        ThonPho = :ThonPho,
                        XaPhuong = :XaPhuong,
                        HuyenQuan = :HuyenQuan,
                        MaHuyenQuan = :MaHuyenQuan,
                        TinhThanhPho = :TinhThanhPho,
                        MaTinhThanhPho = :MaTinhThanhPho,
                        NoiLamViec = :NoiLamViec,
                        DoiTuong = :DoiTuong,
                        NgayHetHanBHYT = :NgayHetHanBHYT,
                        SoTheBHYT = :SoTheBHYT,
                        NgayDangKyBHYT = :NgayDangKyBHYT,
                        TenNoiDangKyBHYT = :TenNoiDangKyBHYT,
                        MaNoiDangKyBHYT = :MaNoiDangKyBHYT,
                        NgayDuocHuong5Nam = :NgayDuocHuong5Nam,
                        HoTenDiaChiNguoiNha = :HoTenDiaChiNguoiNha,
                        SoDienThoaiNguoiNha = :SoDienThoaiNguoiNha,
                        HoVaTenBo = :HoVaTenBo,
                        HoVaTenMe = :HoVaTenMe,
                        NgheNghiepBo = :NgheNghiepBo,
                        NgheNghiepMe = :NgheNghiepMe,
                        TrinhDoVanHoaBo = :TrinhDoVanHoaBo,
                        TrinhDoVanHoaMe = :TrinhDoVanHoaMe,
                        NgaySinhMe = :NgaySinhMe,
                        NgaySinhBo = :NgaySinhBo,
                        DeLanMay = :DeLanMay,
                        TienThaiPara = :TienThaiPara,
                        TienThaiParaID = :TienThaiParaID,
                        NhomMauMe = :NhomMauMe,
                        TrinhDoVanHoa = :TrinhDoVanHoa,
                        DienThoaiLienLac = :DienThoaiLienLac,
                        MaXaPhuong = :MaXaPhuong,
                        CapBac = :CapBac,
                        DonVi = :DonVi,
                        CNKhuyetTat = :CNKhuyetTat,
                        DangKhuyetTat = :DangKhuyetTat,
                        MucDoKT = :MucDoKT,
                        CMND = :CMND,
                        NoiCap_CMND = :NoiCap_CMND,
                        NgayCap_CMND = :NgayCap_CMND 
                        WHERE MaBenhNhan = :MaBenhNhan";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add("SoYTe", HanhChinhBenhNhan.SoYTe);
            Command.Parameters.Add("BenhVien", HanhChinhBenhNhan.BenhVien);
            Command.Parameters.Add("MaYTe", HanhChinhBenhNhan.MaYTe);
            Command.Parameters.Add("TenBenhNhan", HanhChinhBenhNhan.TenBenhNhan);
            Command.Parameters.Add("NgaySinh", HanhChinhBenhNhan.NgaySinh);
            Command.Parameters.Add("Tuoi", HanhChinhBenhNhan.Tuoi);
            Command.Parameters.Add("GioiTinh", (int)HanhChinhBenhNhan.GioiTinh);
            Command.Parameters.Add("NgheNghiep", HanhChinhBenhNhan.NgheNghiep);
            Command.Parameters.Add("MaNgheNghiep", HanhChinhBenhNhan.MaNgheNghiep);
            Command.Parameters.Add("MaNgheNghiepBo", HanhChinhBenhNhan.MaNgheNghiepBo);
            Command.Parameters.Add("MaNgheNghiepMe", HanhChinhBenhNhan.MaNgheNghiepMe);
            Command.Parameters.Add("DanToc", HanhChinhBenhNhan.DanToc);
            Command.Parameters.Add("MaDanhToc", HanhChinhBenhNhan.MaDanhToc);
            Command.Parameters.Add("NgoaiKieu", HanhChinhBenhNhan.NgoaiKieu);
            Command.Parameters.Add("MaNgoaiKieu", HanhChinhBenhNhan.MaNgoaiKieu);
            Command.Parameters.Add("SoNha", HanhChinhBenhNhan.SoNha);
            Command.Parameters.Add("ThonPho", HanhChinhBenhNhan.ThonPho);
            Command.Parameters.Add("XaPhuong", HanhChinhBenhNhan.XaPhuong);
            Command.Parameters.Add("HuyenQuan", HanhChinhBenhNhan.HuyenQuan);
            Command.Parameters.Add("MaHuyenQuan", HanhChinhBenhNhan.MaHuyenQuan);
            Command.Parameters.Add("TinhThanhPho", HanhChinhBenhNhan.TinhThanhPho);
            Command.Parameters.Add("MaTinhThanhPho", HanhChinhBenhNhan.MaTinhThanhPho);
            Command.Parameters.Add("NoiLamViec", HanhChinhBenhNhan.NoiLamViec);
            Command.Parameters.Add("DoiTuong", (int)HanhChinhBenhNhan.DoiTuong);
            Command.Parameters.Add("NgayHetHanBHYT", HanhChinhBenhNhan.NgayHetHanBHYT);
            Command.Parameters.Add("SoTheBHYT", HanhChinhBenhNhan.SoTheBHYT);
            Command.Parameters.Add("NgayDangKyBHYT", HanhChinhBenhNhan.NgayDangKyBHYT);
            Command.Parameters.Add("TenNoiDangKyBHYT", HanhChinhBenhNhan.TenNoiDangKyBHYT);
            Command.Parameters.Add("MaNoiDangKyBHYT", HanhChinhBenhNhan.MaNoiDangKyBHYT);
            Command.Parameters.Add("NgayDuocHuong5Nam", HanhChinhBenhNhan.NgayDuocHuong5Nam);
            Command.Parameters.Add("HoTenDiaChiNguoiNha", HanhChinhBenhNhan.HoTenDiaChiNguoiNha);
            Command.Parameters.Add("SoDienThoaiNguoiNha", HanhChinhBenhNhan.SoDienThoaiNguoiNha);
            Command.Parameters.Add("HoVaTenBo", HanhChinhBenhNhan.HoVaTenBo);
            Command.Parameters.Add("HoVaTenMe", HanhChinhBenhNhan.HoVaTenMe);
            Command.Parameters.Add("NgheNghiepBo", HanhChinhBenhNhan.NgheNghiepBo);
            Command.Parameters.Add("NgheNghiepMe", HanhChinhBenhNhan.NgheNghiepMe);
            Command.Parameters.Add("TrinhDoVanHoaBo", HanhChinhBenhNhan.TrinhDoVanHoaBo);
            Command.Parameters.Add("TrinhDoVanHoaMe", HanhChinhBenhNhan.TrinhDoVanHoaMe);
            Command.Parameters.Add("NgaySinhMe", HanhChinhBenhNhan.NgaySinhMe);
            Command.Parameters.Add("NgaySinhBo", HanhChinhBenhNhan.NgaySinhBo);
            Command.Parameters.Add("DeLanMay", HanhChinhBenhNhan.DeLanMay);
            Command.Parameters.Add("TienThaiPara", HanhChinhBenhNhan.TienThaiPara);
            Command.Parameters.Add("TienThaiParaID", HanhChinhBenhNhan.TienThaiParaID);
            Command.Parameters.Add("NhomMauMe", HanhChinhBenhNhan.NhomMauMe);
            Command.Parameters.Add("TrinhDoVanHoa", HanhChinhBenhNhan.TrinhDoVanHoa);
            Command.Parameters.Add("DienThoaiLienLac", HanhChinhBenhNhan.DienThoaiLienLac);
            Command.Parameters.Add("MaXaPhuong", HanhChinhBenhNhan.MaXaPhuong);
            Command.Parameters.Add("CapBac", HanhChinhBenhNhan.CapBac);
            Command.Parameters.Add("DonVi", HanhChinhBenhNhan.DonVi);
            Command.Parameters.Add("CNKhuyetTat", HanhChinhBenhNhan.CNKhuyetTat);
            Command.Parameters.Add("DangKhuyetTat", HanhChinhBenhNhan.DangKhuyetTat);
            Command.Parameters.Add("MucDoKT", HanhChinhBenhNhan.MucDoKT);
            Command.Parameters.Add("CMND", HanhChinhBenhNhan.CMND);
            Command.Parameters.Add("NoiCap_CMND", HanhChinhBenhNhan.NoiCap_CMND);
            Command.Parameters.Add("NgayCap_CMND", HanhChinhBenhNhan.NgayCap_CMND);

            Command.Parameters.Add("MaBenhNhan", HanhChinhBenhNhan.MaBenhNhan);
            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool DeleteHanhChinhBenhNhan(MDB.MDBConnection MyConnection, HanhChinhBenhNhan HanhChinhBenhNhan)
        {
            string sql = @"DELETE FROM HanhChinhBenhNhan 
                           WHERE MaBenhNhan = :MaBenhNhan";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add("MaBenhNhan", HanhChinhBenhNhan.MaBenhNhan);

            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static string GetGiamDocBenhVien(MDB.MDBConnection MyConnection, decimal maquanly)
        {
            string kq = string.Empty;
            try
            {
                string sql = $@"select magiamdocbenhvien from ThongTinDieuTri where maquanly = :maquanly";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add("maquanly", maquanly);
                MDB.MDBDataReader reader = Command.ExecuteReader();
                while (reader.Read())
                {
                    kq = reader["magiamdocbenhvien"].ToString();
                    break;
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return kq;
        }

        public static string GetTruongKhoa(MDB.MDBConnection MyConnection, decimal maquanly)
        {
            string kq = string.Empty;
            try
            {
                string sql = $@"select matruongkhoa from ThongTinDieuTri where maquanly = :maquanly";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add("maquanly", maquanly);
                MDB.MDBDataReader reader = Command.ExecuteReader();
                while (reader.Read())
                {
                    kq = reader["matruongkhoa"].ToString();
                    break;
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return kq;
        }
    }
}
