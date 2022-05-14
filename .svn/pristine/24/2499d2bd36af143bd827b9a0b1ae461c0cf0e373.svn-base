using EMR_MAIN.DATABASE.BenhAn;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EMR_MAIN.DATABASE.BenhAnFunc
{
    public class DoiBenhAn
    {
        public decimal MaQuanLy { get; set; }
        public int IDLoaiBenhAn { get; set; }
        public string TenLoaiBenhAn { get; set; }
        //public int IDLoaiBenhAnMoi { get; set; }
    }
    public class DoiBenhAnFunc
    {
        public static List<DoiBenhAn> GetData()
        {
            List<DoiBenhAn> tbRecordType = new List<DoiBenhAn>();
            try
            {
                var listIDLoaiBenhAn = EMR_MAIN.Converter.EnumHelper<EMR_MAIN.LoaiBenhAnEMR>.GetEnumValues();//HIS.Utility.GetEnumValues<EMR_MAIN.LoaiBenhAnEMR>();
                if (listIDLoaiBenhAn != null && listIDLoaiBenhAn.Count() > 0)
                {
                    foreach (var id in listIDLoaiBenhAn)
                    {
                        DoiBenhAn RecordType = new DoiBenhAn();
                        RecordType.IDLoaiBenhAn = (int)id;
                        RecordType.TenLoaiBenhAn = id.Description();//HIS.Utility.Description(id);
                        tbRecordType.Add(RecordType);
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return tbRecordType;
        }
        public static bool UpdateLoaiBenhAnThongTinDieuTri(DoiBenhAn doiBenhAn, MDB.MDBConnection conn)
        {
            bool result = false;
            try
            {
                string sql = "SELECT MAQUANLY FROM THONGTINDIEUTRI WHERE MAQUANLY = :MAQUANLY";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, conn);
                command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", XemBenhAn._ThongTinDieuTri.MaQuanLy));
                MDB.MDBDataReader dataReader = command.ExecuteReader();
                int rowCount = 0;
                while (dataReader.Read()) rowCount++;
                if (rowCount == 1)
                    sql = "UPDATE THONGTINDIEUTRI SET IDLOAIBENHAN = :IDLOAIBENHAN WHERE MAQUANLY = :MAQUANLY";
                command = new MDB.MDBCommand(sql, conn);
                command.Parameters.Add(new MDB.MDBParameter("IDLOAIBENHAN", doiBenhAn.IDLoaiBenhAn));
                command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", XemBenhAn._ThongTinDieuTri.MaQuanLy));
                int executeNonQuery = command.ExecuteNonQuery();
                if (executeNonQuery >= 1)
                    result = true;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return result;
        }
        public static bool DeleteReCord(LoaiBenhAnEMR loaiBenhAnEMR, MDB.MDBConnection conn)
        {
            try
            {
                string sql = "";
                if (loaiBenhAnEMR == LoaiBenhAnEMR.Bong)
                    sql = "DELETE FROM BenhAnBong WHERE MAQUANLY = '" + XemBenhAn._ThongTinDieuTri.MaQuanLy + "'";

                else if (loaiBenhAnEMR == LoaiBenhAnEMR.DaLieu)
                    sql = "DELETE FROM BenhDaLieu WHERE MAQUANLY = '" + XemBenhAn._ThongTinDieuTri.MaQuanLy + "'";

                else if (loaiBenhAnEMR == LoaiBenhAnEMR.DieuTriBanNgay)
                    sql = "DELETE FROM BenhAnDieuTriBanNgay WHERE MAQUANLY = '" + XemBenhAn._ThongTinDieuTri.MaQuanLy + "'";

                else if (loaiBenhAnEMR == LoaiBenhAnEMR.HuyetHocTruyenMau)
                    sql = "DELETE FROM BenhAnHuyetHocTruyenMau WHERE MAQUANLY = '" + XemBenhAn._ThongTinDieuTri.MaQuanLy + "'";

                else if (loaiBenhAnEMR == LoaiBenhAnEMR.Mat)
                    sql = "DELETE FROM BenhAnMat WHERE MAQUANLY = '" + XemBenhAn._ThongTinDieuTri.MaQuanLy + "'";

                else if (loaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTruMat)
                    sql = "DELETE FROM BenhAnNgoaiTruMat WHERE MAQUANLY = '" + XemBenhAn._ThongTinDieuTri.MaQuanLy + "'";

                else if (loaiBenhAnEMR == LoaiBenhAnEMR.NgoaiKhoa)
                    sql = "DELETE FROM BenhAnNgoaiKhoa WHERE MAQUANLY = '" + XemBenhAn._ThongTinDieuTri.MaQuanLy + "'";

                else if (loaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTruRangHamMat)
                    sql = "DELETE FROM BenhAnNgoaiTruRangHamMat WHERE MAQUANLY = '" + XemBenhAn._ThongTinDieuTri.MaQuanLy + "'";

                else if (loaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTruTaiMuiHong)
                    sql = "DELETE FROM BenhAnNgoaiTruTaiMuiHong WHERE MAQUANLY = '" + XemBenhAn._ThongTinDieuTri.MaQuanLy + "'";

                else if (loaiBenhAnEMR == LoaiBenhAnEMR.PhaThaiI)
                    sql = "DELETE FROM BenhAnPhaThaiI WHERE MAQUANLY = '" + XemBenhAn._ThongTinDieuTri.MaQuanLy + "'";

                else if (loaiBenhAnEMR == LoaiBenhAnEMR.PhaThaiII)
                    sql = "DELETE FROM BenhAnPhaThaiII WHERE MAQUANLY = '" + XemBenhAn._ThongTinDieuTri.MaQuanLy + "'";

                else if (loaiBenhAnEMR == LoaiBenhAnEMR.PhucHoiChucNang)
                    sql = "DELETE FROM BenhAnPhucHoiChucNang WHERE MAQUANLY = '" + XemBenhAn._ThongTinDieuTri.MaQuanLy + "'";

                else if (loaiBenhAnEMR == LoaiBenhAnEMR.PhuKhoa)
                    sql = "DELETE FROM BenhAnPhuKhoa WHERE MAQUANLY = '" + XemBenhAn._ThongTinDieuTri.MaQuanLy + "'";

                else if (loaiBenhAnEMR == LoaiBenhAnEMR.SoSinh)
                    sql = "DELETE FROM BenhAnSoSinh WHERE MAQUANLY = '" + XemBenhAn._ThongTinDieuTri.MaQuanLy + "'";

                else if (loaiBenhAnEMR == LoaiBenhAnEMR.TaiMuiHong)
                    sql = "DELETE FROM BenhAnTaiMuiHong WHERE MAQUANLY = '" + XemBenhAn._ThongTinDieuTri.MaQuanLy + "'";

                else if (loaiBenhAnEMR == LoaiBenhAnEMR.TamThan)
                    sql = "DELETE FROM BenhAnTamThan WHERE MAQUANLY = '" + XemBenhAn._ThongTinDieuTri.MaQuanLy + "'";

                else if (loaiBenhAnEMR == LoaiBenhAnEMR.ThanNhanTao)
                    sql = "DELETE FROM BenhAnThanNhanTao WHERE MAQUANLY = '" + XemBenhAn._ThongTinDieuTri.MaQuanLy + "'";

                else if (loaiBenhAnEMR == LoaiBenhAnEMR.MatBanPhanTruoc)
                    sql = "DELETE FROM BenhAnMatBanPhanTruoc WHERE MAQUANLY = '" + XemBenhAn._ThongTinDieuTri.MaQuanLy + "'";

                else if (loaiBenhAnEMR == LoaiBenhAnEMR.MatChanThuong)
                    sql = "DELETE FROM BenhAnMatChanThuong WHERE MAQUANLY = '" + XemBenhAn._ThongTinDieuTri.MaQuanLy + "'";

                else if (loaiBenhAnEMR == LoaiBenhAnEMR.MatGloCom)
                    sql = "DELETE FROM BenhAnMatGlocom WHERE MAQUANLY = '" + XemBenhAn._ThongTinDieuTri.MaQuanLy + "'";

                else if (loaiBenhAnEMR == LoaiBenhAnEMR.MatDayMat)
                    sql = "DELETE FROM BenhAnMatDayMat WHERE MAQUANLY = '" + XemBenhAn._ThongTinDieuTri.MaQuanLy + "'";

                else if (loaiBenhAnEMR == LoaiBenhAnEMR.MatLac)
                    sql = "DELETE FROM BenhAnMatLac WHERE MAQUANLY = '" + XemBenhAn._ThongTinDieuTri.MaQuanLy + "'";

                else if (loaiBenhAnEMR == LoaiBenhAnEMR.MatTreEm)
                    sql = "DELETE FROM BenhAnMatTreEm WHERE MAQUANLY = '" + XemBenhAn._ThongTinDieuTri.MaQuanLy + "'";

                else if (loaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTru)
                    sql = "DELETE FROM BenhAnNgoaiTru WHERE MAQUANLY = '" + XemBenhAn._ThongTinDieuTri.MaQuanLy + "'";

                else if (loaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTruYHCT)
                    sql = "DELETE FROM BenhAnNgoaiTruYHCT WHERE MAQUANLY = '" + XemBenhAn._ThongTinDieuTri.MaQuanLy + "'";

                else if (loaiBenhAnEMR == LoaiBenhAnEMR.NhiKhoa)
                    sql = "DELETE FROM BenhAnNhiKhoa WHERE MAQUANLY = '" + XemBenhAn._ThongTinDieuTri.MaQuanLy + "'";

                else if (loaiBenhAnEMR == LoaiBenhAnEMR.NoiKhoa)
                    sql = "DELETE FROM BenhAnNoiKhoa WHERE MAQUANLY = '" + XemBenhAn._ThongTinDieuTri.MaQuanLy + "'";

                else if (loaiBenhAnEMR == LoaiBenhAnEMR.NoiTruYHCT)
                    sql = "DELETE FROM BenhAnNoiTruYHCT WHERE MAQUANLY = '" + XemBenhAn._ThongTinDieuTri.MaQuanLy + "'";

                else if (loaiBenhAnEMR == LoaiBenhAnEMR.PhaThaiIII)
                    sql = "DELETE FROM BenhAnPhaThaiIII WHERE MAQUANLY = '" + XemBenhAn._ThongTinDieuTri.MaQuanLy + "'";

                else if (loaiBenhAnEMR == LoaiBenhAnEMR.RangHamMat)
                    sql = "DELETE FROM BenhAnRangHamMat WHERE MAQUANLY = '" + XemBenhAn._ThongTinDieuTri.MaQuanLy + "'";

                else if (loaiBenhAnEMR == LoaiBenhAnEMR.SanKhoa)
                    sql = "DELETE FROM BenhAnSanKhoa WHERE MAQUANLY = '" + XemBenhAn._ThongTinDieuTri.MaQuanLy + "'";

                else if (loaiBenhAnEMR == LoaiBenhAnEMR.TruyenNhiem)
                    sql = "DELETE FROM BenhAnTruyenNhiem WHERE MAQUANLY = '" + XemBenhAn._ThongTinDieuTri.MaQuanLy + "'";

                else if (loaiBenhAnEMR == LoaiBenhAnEMR.TruyenNhiemII)
                    sql = "DELETE FROM BenhAnTruyenNhiemII WHERE MAQUANLY = '" + XemBenhAn._ThongTinDieuTri.MaQuanLy + "'";

                else if (loaiBenhAnEMR == LoaiBenhAnEMR.UngBuou)
                    sql = "DELETE FROM BenhAnUngBuou WHERE MAQUANLY = '" + XemBenhAn._ThongTinDieuTri.MaQuanLy + "'";

                else if (loaiBenhAnEMR == LoaiBenhAnEMR.XaPhuong)
                    sql = "DELETE FROM BenhAnXaPhuong WHERE MAQUANLY = '" + XemBenhAn._ThongTinDieuTri.MaQuanLy + "'";

                else if (loaiBenhAnEMR == LoaiBenhAnEMR.Tim)
                    sql = "DELETE FROM BenhAnTim WHERE MAQUANLY = '" + XemBenhAn._ThongTinDieuTri.MaQuanLy + "'";

                else if (loaiBenhAnEMR == LoaiBenhAnEMR.PhucHoiChucNangYHCT)
                    sql = "DELETE FROM BenhAnPhucHoiChucNangYHCT WHERE MAQUANLY = '" + XemBenhAn._ThongTinDieuTri.MaQuanLy + "'";

                else if (loaiBenhAnEMR == LoaiBenhAnEMR.LuuCapCuu)
                    sql = "DELETE FROM BenhAnLuuCapCuu WHERE MAQUANLY = '" + XemBenhAn._ThongTinDieuTri.MaQuanLy + "'";

                else if (loaiBenhAnEMR == LoaiBenhAnEMR.TayChanMieng)
                    sql = "DELETE FROM BenhAnTayChanMieng WHERE MAQUANLY = '" + XemBenhAn._ThongTinDieuTri.MaQuanLy + "'";

                else if (loaiBenhAnEMR == LoaiBenhAnEMR.CMU)
                    sql = "DELETE FROM BenhAnCMU WHERE MAQUANLY = '" + XemBenhAn._ThongTinDieuTri.MaQuanLy + "'";

                else if (loaiBenhAnEMR == LoaiBenhAnEMR.BANgoaTruPK)
                    sql = "DELETE FROM BenhAnNgoaiTruPK WHERE MAQUANLY = '" + XemBenhAn._ThongTinDieuTri.MaQuanLy + "'";

                else if (loaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTruMat)
                    sql = "DELETE FROM BenhAnNgoaiTruMat WHERE MAQUANLY = '" + XemBenhAn._ThongTinDieuTri.MaQuanLy + "'";

                else if (loaiBenhAnEMR == LoaiBenhAnEMR.NgoaiTruPhucHoiChucNang)
                    sql = "DELETE FROM BenhAnNgoaiTruPHCN WHERE MAQUANLY = '" + XemBenhAn._ThongTinDieuTri.MaQuanLy + "'";

                else if (loaiBenhAnEMR == LoaiBenhAnEMR.PhucHoiChucNangNhi)
                    sql = "DELETE FROM BenhAnPHCNNhi WHERE MAQUANLY = '" + XemBenhAn._ThongTinDieuTri.MaQuanLy + "'";

                else if (loaiBenhAnEMR == LoaiBenhAnEMR.PHCNII)
                    sql = "DELETE FROM BenhAnPHCNII WHERE MAQUANLY = '" + XemBenhAn._ThongTinDieuTri.MaQuanLy + "'";

                else if (loaiBenhAnEMR == LoaiBenhAnEMR.DaLieuTW)
                    sql = "DELETE FROM BenhAnDaLieuTW WHERE MAQUANLY = '" + XemBenhAn._ThongTinDieuTri.MaQuanLy + "'";
                else
                    sql = string.Format("DELETE FROM {0} WHERE MAQUANLY = '{1}'", loaiBenhAnEMR.TableName(), XemBenhAn._ThongTinDieuTri.MaQuanLy);

                MDB.MDBCommand command = new MDB.MDBCommand(sql, conn);
                int executeNonQuery = command.ExecuteNonQuery();
                return executeNonQuery > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool CopyProperty(LoaiBenhAnEMR loaiBenhAnEMRMoi, object BenhAn, ref object BenhAnMoi)
        {
            try
            {
                if (loaiBenhAnEMRMoi == LoaiBenhAnEMR.Bong)
                    BenhAnMoi = new BenhAnBong();

                else if (loaiBenhAnEMRMoi == LoaiBenhAnEMR.DaLieu)
                    BenhAnMoi = new BenhAnDaLieu();

                else if (loaiBenhAnEMRMoi == LoaiBenhAnEMR.HuyetHocTruyenMau)
                    BenhAnMoi = new BenhAnHuyetHocTruyenMau();

                else if (loaiBenhAnEMRMoi == LoaiBenhAnEMR.MatBanPhanTruoc)
                    BenhAnMoi = new BenhAnMatBanPhanTruoc();

                else if (loaiBenhAnEMRMoi == LoaiBenhAnEMR.MatChanThuong)
                    BenhAnMoi = new BenhAnMatChanThuong();

                else if (loaiBenhAnEMRMoi == LoaiBenhAnEMR.MatGloCom)
                    BenhAnMoi = new BenhAnMatGlocom();

                else if (loaiBenhAnEMRMoi == LoaiBenhAnEMR.MatDayMat)
                    BenhAnMoi = new BenhAnMatDayMat();

                else if (loaiBenhAnEMRMoi == LoaiBenhAnEMR.MatLac)
                    BenhAnMoi = new BenhAnMatLac();

                else if (loaiBenhAnEMRMoi == LoaiBenhAnEMR.MatTreEm)
                    BenhAnMoi = new BenhAnMatTreEm();

                else if (loaiBenhAnEMRMoi == LoaiBenhAnEMR.NgoaiKhoa)
                    BenhAnMoi = new BenhAnNgoaiKhoa();

                else if (loaiBenhAnEMRMoi == LoaiBenhAnEMR.NgoaiTru)
                    BenhAnMoi = new BenhAnNgoaiTru();

                else if (loaiBenhAnEMRMoi == LoaiBenhAnEMR.NgoaiTruRangHamMat)
                    BenhAnMoi = new BenhAnNgoaiTruRangHamMat();

                else if (loaiBenhAnEMRMoi == LoaiBenhAnEMR.NgoaiTruTaiMuiHong)
                    BenhAnMoi = new BenhAnNgoaiTruTaiMuiHong();

                else if (loaiBenhAnEMRMoi == LoaiBenhAnEMR.NgoaiTruYHCT)
                    BenhAnMoi = new BenhAnNgoaiTruYHCT();

                else if (loaiBenhAnEMRMoi == LoaiBenhAnEMR.NhiKhoa)
                    BenhAnMoi = new BenhAnNhiKhoa();

                else if (loaiBenhAnEMRMoi == LoaiBenhAnEMR.NoiKhoa)
                    BenhAnMoi = new BenhAnNoiKhoa();

                else if (loaiBenhAnEMRMoi == LoaiBenhAnEMR.NoiTruYHCT)
                    BenhAnMoi = new BenhAnNoiTruYHCT();

                else if (loaiBenhAnEMRMoi == LoaiBenhAnEMR.PhaThaiI)
                    BenhAnMoi = new BenhAnPhaThaiI();

                else if (loaiBenhAnEMRMoi == LoaiBenhAnEMR.PhaThaiII)
                    BenhAnMoi = new BenhAnPhaThaiII();

                else if (loaiBenhAnEMRMoi == LoaiBenhAnEMR.PhucHoiChucNang)
                    BenhAnMoi = new BenhAnPhucHoiChucNang();

                else if (loaiBenhAnEMRMoi == LoaiBenhAnEMR.PhuKhoa)
                    BenhAnMoi = new BenhAnPhuKhoa();

                else if (loaiBenhAnEMRMoi == LoaiBenhAnEMR.RangHamMat)
                    BenhAnMoi = new BenhAnRangHamMat();

                else if (loaiBenhAnEMRMoi == LoaiBenhAnEMR.SanKhoa)
                    BenhAnMoi = new BenhAnSanKhoa();

                else if (loaiBenhAnEMRMoi == LoaiBenhAnEMR.SoSinh)
                    BenhAnMoi = new BenhAnSoSinh();

                else if (loaiBenhAnEMRMoi == LoaiBenhAnEMR.TaiMuiHong)
                    BenhAnMoi = new BenhAnTaiMuiHong();

                else if (loaiBenhAnEMRMoi == LoaiBenhAnEMR.TamThan)
                    BenhAnMoi = new BenhAnTamThan();

                else if (loaiBenhAnEMRMoi == LoaiBenhAnEMR.TruyenNhiem)
                    BenhAnMoi = new BenhAnTruyenNhiem();

                else if (loaiBenhAnEMRMoi == LoaiBenhAnEMR.UngBuou)
                    BenhAnMoi = new BenhAnUngBuou();

                else if (loaiBenhAnEMRMoi == LoaiBenhAnEMR.XaPhuong)
                    BenhAnMoi = new BenhAnXaPhuong();
                else if (loaiBenhAnEMRMoi == LoaiBenhAnEMR.Tim)
                    BenhAnMoi = new BenhAnTim();
                else if (loaiBenhAnEMRMoi == LoaiBenhAnEMR.PhucHoiChucNangYHCT)
                    BenhAnMoi = new BenhAnPhucHoiChucNangYHCT();
                else if (loaiBenhAnEMRMoi == LoaiBenhAnEMR.LuuCapCuu)
                    BenhAnMoi = new BenhAnLuuCapCuu();
                else if (loaiBenhAnEMRMoi == LoaiBenhAnEMR.CMU)
                    BenhAnMoi = new BenhAnCMU();
                else if (loaiBenhAnEMRMoi == LoaiBenhAnEMR.BANgoaTruPK)
                    BenhAnMoi = new BANgoaiTruPK();
                else if (loaiBenhAnEMRMoi == LoaiBenhAnEMR.TayChanMieng)
                    BenhAnMoi = new BenhAnTayChanMieng();
                else if (loaiBenhAnEMRMoi == LoaiBenhAnEMR.NgoaiTruPhucHoiChucNang)
                    BenhAnMoi = new BenhAnNgoaiTruPHCN();
                else if (loaiBenhAnEMRMoi == LoaiBenhAnEMR.PhucHoiChucNangNhi)
                    BenhAnMoi = new BenhAnPHCNNhi();
                else if (loaiBenhAnEMRMoi == LoaiBenhAnEMR.DaLieuTW)
                    BenhAnMoi = new BenhAnDaLieuTW();
                else if (loaiBenhAnEMRMoi == LoaiBenhAnEMR.PHCNII)
                    BenhAnMoi = new BenhAnPHCNII();
                else if (loaiBenhAnEMRMoi == LoaiBenhAnEMR.NgoaiTru_VayNenThuongThuong)
                    BenhAnMoi = new BenhAnNgoaiTru_BenhVayNenThongThuong();
                else if (loaiBenhAnEMRMoi == LoaiBenhAnEMR.NgoaiTru_AVayNen)
                    BenhAnMoi = new BenhAnNgoaiTruAVayNen();
                else if (loaiBenhAnEMRMoi == LoaiBenhAnEMR.NgoaiTru_HoTroSinhSan)
                {
                    BenhAnMoi = new BenhAnNgoaiTru_HoTroSinhSan();
                    (BenhAnMoi as BenhAnNgoaiTru_HoTroSinhSan).TienSuSanKhoaVo = new ObservableCollection<TienSuSanKhoaVo>();
                    (BenhAnMoi as BenhAnNgoaiTru_HoTroSinhSan).PhieuTheoDoiNangNoan = new ObservableCollection<PhieuTheoDoiNangNoan>();
                    (BenhAnMoi as BenhAnNgoaiTru_HoTroSinhSan).PhieuTheoDoiNoiMac = new ObservableCollection<PhieuTheoDoiNoiMac>();
                }
                else if (loaiBenhAnEMRMoi == LoaiBenhAnEMR.NgoaiTru_BenhAnViemBiCo)
                {
                    BenhAnMoi = new BenhAnNgoaiTru_ViemBiCo();

                    if((BenhAnMoi as BenhAnNgoaiTru_ViemBiCo).CoGapCanhTay == null)
                        (BenhAnMoi as BenhAnNgoaiTru_ViemBiCo).CoGapCanhTay = new TrieuChungCo();
                    if ((BenhAnMoi as BenhAnNgoaiTru_ViemBiCo).CoDuoiCanhTay == null)
                        (BenhAnMoi as BenhAnNgoaiTru_ViemBiCo).CoDuoiCanhTay = new TrieuChungCo();
                    if ((BenhAnMoi as BenhAnNgoaiTru_ViemBiCo).CoGapDui == null)
                        (BenhAnMoi as BenhAnNgoaiTru_ViemBiCo).CoGapDui = new TrieuChungCo();
                    if ((BenhAnMoi as BenhAnNgoaiTru_ViemBiCo).CoDuoiDui == null)
                        (BenhAnMoi as BenhAnNgoaiTru_ViemBiCo).CoDuoiDui = new TrieuChungCo();

                    if ((BenhAnMoi as BenhAnNgoaiTru_ViemBiCo).TK_CoGapCanhTay == null)
                        (BenhAnMoi as BenhAnNgoaiTru_ViemBiCo).TK_CoGapCanhTay = new TrieuChungCo();
                    if ((BenhAnMoi as BenhAnNgoaiTru_ViemBiCo).TK_CoDuoiCanhTay == null)
                        (BenhAnMoi as BenhAnNgoaiTru_ViemBiCo).TK_CoDuoiCanhTay = new TrieuChungCo();
                    if ((BenhAnMoi as BenhAnNgoaiTru_ViemBiCo).TK_CoGapDui == null)
                        (BenhAnMoi as BenhAnNgoaiTru_ViemBiCo).TK_CoGapDui = new TrieuChungCo();
                    if ((BenhAnMoi as BenhAnNgoaiTru_ViemBiCo).TK_CoDuoiDui == null)
                        (BenhAnMoi as BenhAnNgoaiTru_ViemBiCo).TK_CoDuoiDui = new TrieuChungCo();

                    if ((BenhAnMoi as BenhAnNgoaiTru_ViemBiCo).TS_Corticosteroid == null)
                        (BenhAnMoi as BenhAnNgoaiTru_ViemBiCo).TS_Corticosteroid = new TienSuDieuTri();
                    if ((BenhAnMoi as BenhAnNgoaiTru_ViemBiCo).TS_CyclophosphamidLieuCao == null)
                        (BenhAnMoi as BenhAnNgoaiTru_ViemBiCo).TS_CyclophosphamidLieuCao = new TienSuDieuTri();
                    if ((BenhAnMoi as BenhAnNgoaiTru_ViemBiCo).TS_Azathioprine == null)
                        (BenhAnMoi as BenhAnNgoaiTru_ViemBiCo).TS_Azathioprine = new TienSuDieuTri();
                    if ((BenhAnMoi as BenhAnNgoaiTru_ViemBiCo).TS_Methotrexate == null)
                        (BenhAnMoi as BenhAnNgoaiTru_ViemBiCo).TS_Methotrexate = new TienSuDieuTri();
                    if ((BenhAnMoi as BenhAnNgoaiTru_ViemBiCo).TS_CyclosporineA == null)
                        (BenhAnMoi as BenhAnNgoaiTru_ViemBiCo).TS_CyclosporineA = new TienSuDieuTri();
                }
                else if (loaiBenhAnEMRMoi == LoaiBenhAnEMR.NgoaiTru_BenhAnLupusBanDoHeThong)
                {
                    BenhAnMoi = new BenhAnNgoaiTru_LupusBanDoHeThong();

                    if ((BenhAnMoi as BenhAnNgoaiTru_LupusBanDoHeThong).Corticosteroid == null)
                        (BenhAnMoi as BenhAnNgoaiTru_LupusBanDoHeThong).Corticosteroid = new ThuocToanThan();
                    if ((BenhAnMoi as BenhAnNgoaiTru_LupusBanDoHeThong).KhangSotRet == null)
                        (BenhAnMoi as BenhAnNgoaiTru_LupusBanDoHeThong).KhangSotRet = new ThuocToanThan();
                    if ((BenhAnMoi as BenhAnNgoaiTru_LupusBanDoHeThong).Cyclophosphamide == null)
                        (BenhAnMoi as BenhAnNgoaiTru_LupusBanDoHeThong).Cyclophosphamide = new ThuocToanThan();
                    if ((BenhAnMoi as BenhAnNgoaiTru_LupusBanDoHeThong).CyclophosphamideLieuCao == null)
                        (BenhAnMoi as BenhAnNgoaiTru_LupusBanDoHeThong).CyclophosphamideLieuCao = new ThuocToanThan();
                    if ((BenhAnMoi as BenhAnNgoaiTru_LupusBanDoHeThong).Azathioprine == null)
                        (BenhAnMoi as BenhAnNgoaiTru_LupusBanDoHeThong).Azathioprine = new ThuocToanThan();
                    if ((BenhAnMoi as BenhAnNgoaiTru_LupusBanDoHeThong).Methotrexate == null)
                        (BenhAnMoi as BenhAnNgoaiTru_LupusBanDoHeThong).Methotrexate = new ThuocToanThan();
                    if ((BenhAnMoi as BenhAnNgoaiTru_LupusBanDoHeThong).CyclosporineA == null)
                        (BenhAnMoi as BenhAnNgoaiTru_LupusBanDoHeThong).CyclosporineA = new ThuocToanThan();
                    if ((BenhAnMoi as BenhAnNgoaiTru_LupusBanDoHeThong).ThuocKhac == null)
                        (BenhAnMoi as BenhAnNgoaiTru_LupusBanDoHeThong).ThuocKhac = new ThuocToanThan();

                }
                else if (loaiBenhAnEMRMoi == LoaiBenhAnEMR.NgoaiTru_VayNenTheMu)
                {
                    BenhAnMoi = new BenhAnNgoaiTru_BenhVayNenTheMu();

                    if ((BenhAnMoi as BenhAnNgoaiTru_BenhVayNenTheMu).DauMatCo == null)
                        (BenhAnMoi as BenhAnNgoaiTru_BenhVayNenTheMu).DauMatCo = new ViTriTonThuong();
                    if ((BenhAnMoi as BenhAnNgoaiTru_BenhVayNenTheMu).ChiTren == null)
                        (BenhAnMoi as BenhAnNgoaiTru_BenhVayNenTheMu).ChiTren = new ViTriTonThuong();
                    if ((BenhAnMoi as BenhAnNgoaiTru_BenhVayNenTheMu).ThanTruoc == null)
                        (BenhAnMoi as BenhAnNgoaiTru_BenhVayNenTheMu).ThanTruoc = new ViTriTonThuong();
                    if ((BenhAnMoi as BenhAnNgoaiTru_BenhVayNenTheMu).ThanSau == null)
                        (BenhAnMoi as BenhAnNgoaiTru_BenhVayNenTheMu).ThanSau = new ViTriTonThuong();
                    if ((BenhAnMoi as BenhAnNgoaiTru_BenhVayNenTheMu).ChiDuoi == null)
                        (BenhAnMoi as BenhAnNgoaiTru_BenhVayNenTheMu).ChiDuoi = new ViTriTonThuong();
                    if ((BenhAnMoi as BenhAnNgoaiTru_BenhVayNenTheMu).BoPhanSD == null)
                        (BenhAnMoi as BenhAnNgoaiTru_BenhVayNenTheMu).BoPhanSD = new ViTriTonThuong();
                   
                }
                else if (loaiBenhAnEMRMoi == LoaiBenhAnEMR.NgoaiTru_DuhringBrocq)
                {
                    BenhAnMoi = new BenhAnNgoaiTruDuhringBrocq();
                }
                else if (loaiBenhAnEMRMoi == LoaiBenhAnEMR.DaiThaoDuong)
                {
                    BenhAnMoi = new BenhAnDaiThaoDuong();
                }
                else if (loaiBenhAnEMRMoi == LoaiBenhAnEMR.NgoaiTru_UngThuDaHacTo)
                {
                    BenhAnMoi = new BenhAnUngThuHacTo();
                    if ((BenhAnMoi as BenhAnUngThuHacTo).TheoDoiDieuTris == null)
                    {
                        (BenhAnMoi as BenhAnUngThuHacTo).TheoDoiDieuTris = new ObservableCollection<TheoDoiDieuTri_BAUngThuDaHacTo>();
                        (BenhAnMoi as BenhAnUngThuHacTo).TheoDoiDieuTris.Add(new TheoDoiDieuTri_BAUngThuDaHacTo { ThoiGian = "3 tháng" });
                        (BenhAnMoi as BenhAnUngThuHacTo).TheoDoiDieuTris.Add(new TheoDoiDieuTri_BAUngThuDaHacTo { ThoiGian = "6 tháng" });
                        (BenhAnMoi as BenhAnUngThuHacTo).TheoDoiDieuTris.Add(new TheoDoiDieuTri_BAUngThuDaHacTo { ThoiGian = "9 tháng" });
                        (BenhAnMoi as BenhAnUngThuHacTo).TheoDoiDieuTris.Add(new TheoDoiDieuTri_BAUngThuDaHacTo { ThoiGian = "12 tháng" });
                        (BenhAnMoi as BenhAnUngThuHacTo).TheoDoiDieuTris.Add(new TheoDoiDieuTri_BAUngThuDaHacTo { ThoiGian = "18 tháng" });
                        (BenhAnMoi as BenhAnUngThuHacTo).TheoDoiDieuTris.Add(new TheoDoiDieuTri_BAUngThuDaHacTo { ThoiGian = "24 tháng" });
                        (BenhAnMoi as BenhAnUngThuHacTo).TheoDoiDieuTris.Add(new TheoDoiDieuTri_BAUngThuDaHacTo { ThoiGian = "30 tháng" });
                        (BenhAnMoi as BenhAnUngThuHacTo).TheoDoiDieuTris.Add(new TheoDoiDieuTri_BAUngThuDaHacTo { ThoiGian = "36 tháng" });
                        (BenhAnMoi as BenhAnUngThuHacTo).TheoDoiDieuTris.Add(new TheoDoiDieuTri_BAUngThuDaHacTo { ThoiGian = "4 Năm" });
                        (BenhAnMoi as BenhAnUngThuHacTo).TheoDoiDieuTris.Add(new TheoDoiDieuTri_BAUngThuDaHacTo { ThoiGian = "5 Năm" });
                    }
                }
                else if (loaiBenhAnEMRMoi == LoaiBenhAnEMR.NgoaiTru_UngThuDaKhongHacTo)
                {
                    BenhAnMoi = new BenhAnUngThuKhongHacTo();
                    if ((BenhAnMoi as BenhAnUngThuKhongHacTo).TheoDoiDieuTris == null)
                    {
                        (BenhAnMoi as BenhAnUngThuKhongHacTo).TheoDoiDieuTris = new ObservableCollection<TheoDoiDieuTri_BAUngThuDaHacTo>();
                        (BenhAnMoi as BenhAnUngThuKhongHacTo).TheoDoiDieuTris.Add(new TheoDoiDieuTri_BAUngThuDaHacTo { ThoiGian = "3 tháng" });
                        (BenhAnMoi as BenhAnUngThuKhongHacTo).TheoDoiDieuTris.Add(new TheoDoiDieuTri_BAUngThuDaHacTo { ThoiGian = "6 tháng" });
                        (BenhAnMoi as BenhAnUngThuKhongHacTo).TheoDoiDieuTris.Add(new TheoDoiDieuTri_BAUngThuDaHacTo { ThoiGian = "9 tháng" });
                        (BenhAnMoi as BenhAnUngThuKhongHacTo).TheoDoiDieuTris.Add(new TheoDoiDieuTri_BAUngThuDaHacTo { ThoiGian = "12 tháng" });
                        (BenhAnMoi as BenhAnUngThuKhongHacTo).TheoDoiDieuTris.Add(new TheoDoiDieuTri_BAUngThuDaHacTo { ThoiGian = "18 tháng" });
                        (BenhAnMoi as BenhAnUngThuKhongHacTo).TheoDoiDieuTris.Add(new TheoDoiDieuTri_BAUngThuDaHacTo { ThoiGian = "24 tháng" });
                        (BenhAnMoi as BenhAnUngThuKhongHacTo).TheoDoiDieuTris.Add(new TheoDoiDieuTri_BAUngThuDaHacTo { ThoiGian = "30 tháng" });
                        (BenhAnMoi as BenhAnUngThuKhongHacTo).TheoDoiDieuTris.Add(new TheoDoiDieuTri_BAUngThuDaHacTo { ThoiGian = "36 tháng" });
                        (BenhAnMoi as BenhAnUngThuKhongHacTo).TheoDoiDieuTris.Add(new TheoDoiDieuTri_BAUngThuDaHacTo { ThoiGian = "4 Năm" });
                        (BenhAnMoi as BenhAnUngThuKhongHacTo).TheoDoiDieuTris.Add(new TheoDoiDieuTri_BAUngThuDaHacTo { ThoiGian = "5 Năm" });
                    }
                }
                else if (loaiBenhAnEMRMoi == LoaiBenhAnEMR.NgoaiTru_Pemphigus)
                {
                    BenhAnMoi = new BenhAnNgoaiTruPemphigus();
                }
                else if (loaiBenhAnEMRMoi == LoaiBenhAnEMR.NgoaiTru_VayNenTheKhop)
                {
                    BenhAnMoi = new BenhAnVayNenTheKhop();
                }
                else if (loaiBenhAnEMRMoi == LoaiBenhAnEMR.NgoaiTru_HoiChungTrungLap)
                {
                    BenhAnMoi = new BenhAnNgoaiTru_HoiChungTrungLap();
                }
                else if (loaiBenhAnEMRMoi == LoaiBenhAnEMR.StentDongMachVanh)
                {
                    BenhAnMoi = new BenhAnStentDongMachVanh();
                }
                else if (loaiBenhAnEMRMoi == LoaiBenhAnEMR.ThieuMauCoTimCucBo)
                {
                    BenhAnMoi = new BenhAnThieuMauCoTimCucBo();
                }
                else if (loaiBenhAnEMRMoi == LoaiBenhAnEMR.NgoaiTru_BenhBasedow)
                {
                    BenhAnMoi = new BenhAnBenhBaseDow();
                }
                else if (loaiBenhAnEMRMoi == LoaiBenhAnEMR.ViemGanBManTinh)
                {
                    BenhAnMoi = new BenhAnViemGanBManTinh();
                }
                else if (loaiBenhAnEMRMoi == LoaiBenhAnEMR.PhoiTacNghenManTinh)
                {
                    BenhAnMoi = new BenhAnPhoiTacNghenManTinh();
                    (BenhAnMoi as BenhAnPhoiTacNghenManTinh).DoPheDungs = new ObservableCollection<DoPheDung>();
                    (BenhAnMoi as BenhAnPhoiTacNghenManTinh).DoChucNangHoHaps = new ObservableCollection<DoChucNangHoHap>();
                }
                else if (loaiBenhAnEMRMoi == LoaiBenhAnEMR.BenhTangHuyetAp)
                {
                    BenhAnMoi = new BenhAnTangHuyetAp();
                }
                EMR_MAIN.Converter.PropertyCopier<object, object>.CopyProperty(BenhAn, BenhAnMoi);
                return true;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
    }
}
