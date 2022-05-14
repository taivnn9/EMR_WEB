using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMR_MAIN.DATABASE.BenhAn;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.BenhAnFunc
{
    public class BenhAnNgoaiTru_BenhVayNenTheMuFunc
    {
        public static void WriteXml(MDB.MDBConnection MyConnection)
        {
            string sql =
                   @"
                  select  a.*,  CTScanner HoSo_CTScanner, SieuAm HoSo_SieuAm, XetNghiem HoSo_XetNghiem,  Khac HoSo_Khac,  Khac_Text HoSo_Khac_Text,  ToanBoHoSo HoSo_ToanBoHoSo, Mach DauSinhTon_Mach,  NhietDo DauSinhTon_NhietDo,  HuyetAp DauSinhTon_HuyetAp,  NhipTho DauSinhTon_NhipTho,  CanNang DauSinhTon_CanNang  
                  from BenhAnVayNenTheMu a inner join thongtindieutri b on a.maquanly = b.maquanly
                  where rownum = 1
                    ";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            var DataTable = new DataTable { TableName = "BenhAnVayNenTheMu" };
            DataTable.Load(DataReader as IDataReader);
            DataTable.WriteXml("rptBenhAnVayNenTheMu.xml");
        }
        public static DataSet SelectDataSet(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql =
                   @"
                  select  a.*, f.hovaten BacSyDieuTriHoVaTen, g.hovaten TK_BacSyDieuTriHoVaTen, j.hovaten TongKet_BacSyDieuTriHoVaTen, d.hovaten NguoiGiaoHoSoHoVaTen,e.hovaten NguoiNhanHoSoHoVaTen, b.XQuang HoSo_XQuang, b.CTScanner HoSo_CTScanner, b.SieuAm HoSo_SieuAm, b.XetNghiem HoSo_XetNghiem,  b.Khac HoSo_Khac,  b.Khac_Text HoSo_Khac_Text,  b.ToanBoHoSo HoSo_ToanBoHoSo, b.Khoa, h.SoYTe, h.BenhVien  
                        from BenhAnVayNenTheMu a  
                  left join thongtindieutri b on a.maquanly = b.maquanly 
                  left join HanhChinhBenhNhan h on b.MaBenhNhan = h.MaBenhNhan 
                  left join nhanvien f on a.BacSiDieuTri = f.manhanvien
                  left join nhanvien g on a.TK_BacSiKhamBenh = g.manhanvien
                  left join nhanvien j on a.TongKet_BacSyDieuTri = j.manhanvien
                  left join nhanvien d on a.NguoiGiaoHoSo = d.manhanvien
                  left join nhanvien e on a.NguoiNhanHoSo = e.manhanvien where a.maquanly = " + MaQuanLy.ToString(System.Globalization.CultureInfo.InvariantCulture);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(sql, MyConnection);
            var ds = new DataSet();
            adt.Fill(ds, "Table");
            List<ViTriTonThuong> DauMatCo = new List<ViTriTonThuong>();
            List<ViTriTonThuong> ChiTren = new List<ViTriTonThuong>();
            List<ViTriTonThuong> ThanTruoc = new List<ViTriTonThuong>();
            List<ViTriTonThuong> ThanSau = new List<ViTriTonThuong>();
            List<ViTriTonThuong> ChiDuoi = new List<ViTriTonThuong>();
            List<ViTriTonThuong> BoPhanSD = new List<ViTriTonThuong>();


            DauMatCo.Add(JsonConvert.DeserializeObject<ViTriTonThuong>(ds.Tables["Table"].Rows[0]["DauMatCo"].ToString()));
            ChiTren.Add(JsonConvert.DeserializeObject<ViTriTonThuong>(ds.Tables["Table"].Rows[0]["ChiTren"].ToString()));
            ThanTruoc.Add(JsonConvert.DeserializeObject<ViTriTonThuong>(ds.Tables["Table"].Rows[0]["ThanTruoc"].ToString()));
            ThanSau.Add(JsonConvert.DeserializeObject<ViTriTonThuong>(ds.Tables["Table"].Rows[0]["ThanSau"].ToString()));
            ChiDuoi.Add(JsonConvert.DeserializeObject<ViTriTonThuong>(ds.Tables["Table"].Rows[0]["ChiDuoi"].ToString()));
            BoPhanSD.Add(JsonConvert.DeserializeObject<ViTriTonThuong>(ds.Tables["Table"].Rows[0]["BoPhanSD"].ToString()));
           

            ds.Tables.Add(Common.ListToDataTable(DauMatCo, "DauMatCo"));
            ds.Tables.Add(Common.ListToDataTable(ChiTren, "ChiTren"));
            ds.Tables.Add(Common.ListToDataTable(ThanTruoc, "ThanTruoc"));
            ds.Tables.Add(Common.ListToDataTable(ThanSau, "ThanSau"));
            ds.Tables.Add(Common.ListToDataTable(ChiDuoi, "ChiDuoi"));
            ds.Tables.Add(Common.ListToDataTable(BoPhanSD, "BoPhanSD"));

            return ds;

        }
        public static BenhAnNgoaiTru_BenhVayNenTheMu Select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            var obj = new BenhAnNgoaiTru_BenhVayNenTheMu();
            try
            {
                #region
                string sql =
                          @"select * 
                        from BenhAnVayNenTheMu 
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
                    obj.QuaTrinhDieuTri = DataReader["QuaTrinhDieuTri"].ToString();
                    obj.BenhKhac = DataReader["BenhKhac"].ToString();
                    obj.ThoiQuenCaNhan = DataReader["ThoiQuenCaNhan"].ToString();
                    obj.YeuToTinhThan = DataReader["YeuToTinhThan"].ToString();
                    obj.TienSuGiaDinh = DataReader.GetInt("TienSuGiaDinh");
                    obj.TienSuGiaDinh_Co = DataReader["TienSuGiaDinh_Co"].ToString();
                    obj.NguyCoCao = DataReader.GetInt("NguyCoCao");
                    obj.CoYeuToNguyCoCao = DataReader.GetInt("CoYeuToNguyCoCao");
                    obj.NhietDo = DataReader["NhietDo"].ToString();
                    obj.Mach = DataReader["Mach"].ToString();
                    obj.HA = DataReader["HA"].ToString();
                    obj.Can = DataReader["Can"].ToString();
                    obj.Cao = DataReader["Cao"].ToString();
                    obj.TrieuChungCoNang = DataReader["TrieuChungCoNang"].ToString();
                    obj.TonThuongCoBan = DataReader["TonThuongCoBan"].ToString();
                    obj.DatDo = DataReader["DatDo"].ToString();
                    obj.MunMu_KichThuoc = DataReader.GetInt("MunMu_KichThuoc");
                    obj.MunMu_TinhChat = DataReader.GetInt("MunMu_TinhChat");
                    obj.MunMu_MauSac = DataReader.GetInt("MunMu_MauSac");
                    obj.MunMu_MatDo = DataReader.GetInt("MunMu_MatDo");
                    obj.Vay = DataReader["Vay"].ToString();
                    obj.DauMatCo = JsonConvert.DeserializeObject<ViTriTonThuong>(DataReader["DauMatCo"].ToString());
                    obj.ChiTren = JsonConvert.DeserializeObject<ViTriTonThuong>(DataReader["ChiTren"].ToString());
                    obj.ThanTruoc = JsonConvert.DeserializeObject<ViTriTonThuong>(DataReader["ThanTruoc"].ToString());
                    obj.ThanSau = JsonConvert.DeserializeObject<ViTriTonThuong>(DataReader["ThanSau"].ToString());
                    obj.ChiDuoi = JsonConvert.DeserializeObject<ViTriTonThuong>(DataReader["ChiDuoi"].ToString());
                    obj.BoPhanSD = JsonConvert.DeserializeObject<ViTriTonThuong>(DataReader["BoPhanSD"].ToString());
                    obj.TongDiem = DataReader["TongDiem"].ToString();
                    obj.MucDo = DataReader["MucDo"].ToString();
                    obj.MucDoJDA = DataReader.GetInt("MucDoJDA");
                    obj.DiemPASI = DataReader["DiemPASI"].ToString();
                    obj.BieuHienMong = DataReader.GetInt("BieuHienMong");
                    obj.BieuHienMong_Text = DataReader["BieuHienMong_Text"].ToString();
                    obj.TongDiemNAPSI = DataReader["TongDiemNAPSI"].ToString();
                    obj.BieuHienKhop = DataReader.GetInt("BieuHienKhop");
                    obj.SoKhopDau = DataReader["SoKhopDau"].ToString();
                    obj.SoKhopSung = DataReader["SoKhopSung"].ToString();
                    obj.BieuHienKhop_Text = DataReader["BieuHienKhop_Text"].ToString();
                    obj.BieuHienNiemMac = DataReader.GetInt("BieuHienNiemMac");
                    obj.BieuHienNiemMac_ViTri = DataReader["BieuHienNiemMac_ViTri"].ToString();
                    obj.TimMach = DataReader["TimMach"].ToString();
                    obj.HoHap = DataReader["HoHap"].ToString();
                    obj.TieuHoa = DataReader["TieuHoa"].ToString();
                    obj.TamThan = DataReader["TamThan"].ToString();
                    obj.DiemDLQI = DataReader["DiemDLQI"].ToString();
                    obj.GhiChu = DataReader["GhiChu"].ToString();
                    obj.ChanDoanTheoGGP = DataReader["ChanDoanTheoGGP"].ToString();
                    obj.ChanDoanVayNen = DataReader["ChanDoanVayNen"].ToString();
                    obj.ChanDoanVayNen_NeuCo = DataReader["ChanDoanVayNen_NeuCo"].ToString();
                    obj.ChanDoanVayNen_Khac = DataReader["ChanDoanVayNen_Khac"].ToString();
                    obj.DieuTri_CuThe = DataReader["DieuTri_CuThe"].ToString();
                    obj.HenTaiKham = DataReader["HenTaiKham"] != DBNull.Value ? (DateTime?) Convert.ToDateTime(DataReader["HenTaiKham"].ToString()): null;
                    obj.BacSiDieuTri = DataReader["BacSiDieuTri"].ToString();
                    obj.TK_HoTen = DataReader["TK_HoTen"].ToString();
                    obj.TK_SoBADienTu = DataReader["TK_SoBADienTu"].ToString();
                    obj.TK_Ngay = DataReader["TK_Ngay"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["TK_Ngay"].ToString()) : null;
                    obj.TK_SoLuuTru = DataReader["TK_SoLuuTru"].ToString();
                    obj.TK_NhietDo = DataReader["TK_NhietDo"].ToString();
                    obj.TK_Mach = DataReader["TK_Mach"].ToString();
                    obj.TK_HA = DataReader["TK_HA"].ToString();
                    obj.TK_Can = DataReader["TK_Can"].ToString();
                    obj.TK_Cao = DataReader["TK_Cao"].ToString();
                    obj.TK_TrieuChungCoNang = DataReader["TK_TrieuChungCoNang"].ToString();
                    obj.TK_TienSu = DataReader["TK_TienSu"].ToString();
                    obj.TK_DatDo = DataReader.GetInt("TK_DatDo");
                    obj.TK_MunMu = DataReader.GetInt("TK_MunMu");
                    obj.TK_Vay = DataReader.GetInt("TK_Vay");
                    obj.TK_BieuHienMong = DataReader.GetInt("TK_BieuHienMong");
                    obj.TK_BieuHienMong_ViTri = DataReader["TK_BieuHienMong_ViTri"].ToString();
                    obj.TK_TongDiemNAPSI = DataReader["TK_TongDiemNAPSI"].ToString();
                    obj.TK_BieuHienKhop = DataReader.GetInt("TK_BieuHienKhop");
                    obj.TK_BieuHienKhop_ViTri = DataReader["TK_BieuHienKhop_ViTri"].ToString();
                    obj.TK_BieuHienNiemMac = DataReader.GetInt("TK_BieuHienNiemMac");
                    obj.TK_BieuHienNiemMac_ViTri = DataReader["TK_BieuHienNiemMac_ViTri"].ToString();
                    obj.TK_TimMach = DataReader["TK_TimMach"].ToString();
                    obj.TK_HoHap = DataReader["TK_HoHap"].ToString();
                    obj.TK_TieuHoa = DataReader["TK_TieuHoa"].ToString();
                    obj.TK_TamThan = DataReader["TK_TamThan"].ToString();
                    obj.TK_TacDungPhuCuaThuoc = DataReader["TK_TacDungPhuCuaThuoc"].ToString();
                    obj.TK_JDAScore = DataReader["TK_JDAScore"].ToString();
                    obj.TK_PASIChoGpp = DataReader["TK_PASIChoGpp"].ToString();
                    obj.TK_ChuY = DataReader["TK_ChuY"].ToString();
                    obj.TK_DieuTri = DataReader["TK_DieuTri"].ToString();
                    obj.TK_HenTaiKham = DataReader["TK_HenTaiKham"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["TK_HenTaiKham"].ToString()) : null;
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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, BenhAnNgoaiTru_BenhVayNenTheMu BenhAnNgoaiTru_BenhVayNenTheMu)
        {
            try
            {
                string sql =
                          @"select MaQuanLy 
                            from BenhAnVayNenTheMu
                            where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnNgoaiTru_BenhVayNenTheMu.MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                int rowCount = 0;
                while (DataReader.Read()) rowCount++;
                if (rowCount == 1) return Update(MyConnection, BenhAnNgoaiTru_BenhVayNenTheMu);
                sql = @"
                       INSERT INTO BenhAnVayNenTheMu 
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
                            QuaTrinhDieuTri,
                            BenhKhac,
                            ThoiQuenCaNhan,
                            YeuToTinhThan,
                            TienSuGiaDinh,
                            TienSuGiaDinh_Co,
                            NguyCoCao,
                            CoYeuToNguyCoCao,
                            NhietDo,
                            Mach,
                            HA,
                            Can,
                            Cao,
                            TrieuChungCoNang,
                            TonThuongCoBan,
                            DatDo,
                            MunMu_KichThuoc,
                            MunMu_TinhChat,
                            MunMu_MauSac,
                            MunMu_MatDo,
                            Vay,
                            DauMatCo,
                            ChiTren,
                            ThanTruoc,
                            ThanSau,
                            ChiDuoi,
                            BoPhanSD,
                            TongDiem,
                            MucDo,
                            MucDoJDA,
                            DiemPASI,
                            BieuHienMong,
                            BieuHienMong_Text,
                            TongDiemNAPSI,
                            BieuHienKhop,
                            SoKhopDau,
                            SoKhopSung,
                            BieuHienKhop_Text,
                            BieuHienNiemMac,
                            BieuHienNiemMac_ViTri,
                            TimMach,
                            HoHap,
                            TieuHoa,
                            TamThan,
                            DiemDLQI,
                            GhiChu,
                            ChanDoanTheoGGP,
                            ChanDoanVayNen,
                            ChanDoanVayNen_NeuCo,
                            ChanDoanVayNen_Khac,
                            DieuTri_CuThe,
                            HenTaiKham,
                            BacSiDieuTri,
                            TK_HoTen,
                            TK_SoBADienTu,
                            TK_Ngay,
                            TK_SoLuuTru,
                            TK_NhietDo,
                            TK_Mach,
                            TK_HA,
                            TK_Can,
                            TK_Cao,
                            TK_TrieuChungCoNang,
                            TK_TienSu,
                            TK_DatDo,
                            TK_MunMu,
                            TK_Vay,
                            TK_BieuHienMong,
                            TK_BieuHienMong_ViTri,
                            TK_TongDiemNAPSI,
                            TK_BieuHienKhop,
                            TK_BieuHienKhop_ViTri,
                            TK_BieuHienNiemMac,
                            TK_BieuHienNiemMac_ViTri,
                            TK_TimMach,
                            TK_HoHap,
                            TK_TieuHoa,
                            TK_TamThan,
                            TK_TacDungPhuCuaThuoc,
                            TK_JDAScore,
                            TK_PASIChoGpp,
                            TK_ChuY,
                            TK_DieuTri,
                            TK_HenTaiKham,
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
                            :QuaTrinhDieuTri,
                            :BenhKhac,
                            :ThoiQuenCaNhan,
                            :YeuToTinhThan,
                            :TienSuGiaDinh,
                            :TienSuGiaDinh_Co,
                            :NguyCoCao,
                            :CoYeuToNguyCoCao,
                            :NhietDo,
                            :Mach,
                            :HA,
                            :Can,
                            :Cao,
                            :TrieuChungCoNang,
                            :TonThuongCoBan,
                            :DatDo,
                            :MunMu_KichThuoc,
                            :MunMu_TinhChat,
                            :MunMu_MauSac,
                            :MunMu_MatDo,
                            :Vay,
                            :DauMatCo,
                            :ChiTren,
                            :ThanTruoc,
                            :ThanSau,
                            :ChiDuoi,
                            :BoPhanSD,
                            :TongDiem,
                            :MucDo,
                            :MucDoJDA,
                            :DiemPASI,
                            :BieuHienMong,
                            :BieuHienMong_Text,
                            :TongDiemNAPSI,
                            :BieuHienKhop,
                            :SoKhopDau,
                            :SoKhopSung,
                            :BieuHienKhop_Text,
                            :BieuHienNiemMac,
                            :BieuHienNiemMac_ViTri,
                            :TimMach,
                            :HoHap,
                            :TieuHoa,
                            :TamThan,
                            :DiemDLQI,
                            :GhiChu,
                            :ChanDoanTheoGGP,
                            :ChanDoanVayNen,
                            :ChanDoanVayNen_NeuCo,
                            :ChanDoanVayNen_Khac,
                            :DieuTri_CuThe,
                            :HenTaiKham,
                            :BacSiDieuTri,
                            :TK_HoTen,
                            :TK_SoBADienTu,
                            :TK_Ngay,
                            :TK_SoLuuTru,
                            :TK_NhietDo,
                            :TK_Mach,
                            :TK_HA,
                            :TK_Can,
                            :TK_Cao,
                            :TK_TrieuChungCoNang,
                            :TK_TienSu,
                            :TK_DatDo,
                            :TK_MunMu,
                            :TK_Vay,
                            :TK_BieuHienMong,
                            :TK_BieuHienMong_ViTri,
                            :TK_TongDiemNAPSI,
                            :TK_BieuHienKhop,
                            :TK_BieuHienKhop_ViTri,
                            :TK_BieuHienNiemMac,
                            :TK_BieuHienNiemMac_ViTri,
                            :TK_TimMach,
                            :TK_HoHap,
                            :TK_TieuHoa,
                            :TK_TamThan,
                            :TK_TacDungPhuCuaThuoc,
                            :TK_JDAScore,
                            :TK_PASIChoGpp,
                            :TK_ChuY,
                            :TK_DieuTri,
                            :TK_HenTaiKham,
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
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnNgoaiTru_BenhVayNenTheMu.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriNgoaiTruTu", BenhAnNgoaiTru_BenhVayNenTheMu.DieuTriNgoaiTruTu));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriNgoaiTruDen", BenhAnNgoaiTru_BenhVayNenTheMu.DieuTriNgoaiTruDen));
                Command.Parameters.Add(new MDB.MDBParameter("SoCMND", BenhAnNgoaiTru_BenhVayNenTheMu.SoCMND));
                Command.Parameters.Add(new MDB.MDBParameter("BaoHiem", BenhAnNgoaiTru_BenhVayNenTheMu.BaoHiem));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan_TuyenTruoc", BenhAnNgoaiTru_BenhVayNenTheMu.ChanDoan_TuyenTruoc));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanBanDau", BenhAnNgoaiTru_BenhVayNenTheMu.ChanDoanBanDau));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham1", BenhAnNgoaiTru_BenhVayNenTheMu.ChanDoanTaiKham1));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham2", BenhAnNgoaiTru_BenhVayNenTheMu.ChanDoanTaiKham2));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham3", BenhAnNgoaiTru_BenhVayNenTheMu.ChanDoanTaiKham3));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham4", BenhAnNgoaiTru_BenhVayNenTheMu.ChanDoanTaiKham4));
                Command.Parameters.Add(new MDB.MDBParameter("BenhPhu", BenhAnNgoaiTru_BenhVayNenTheMu.BenhPhu));
                Command.Parameters.Add(new MDB.MDBParameter("KetQuaDieuTri", BenhAnNgoaiTru_BenhVayNenTheMu.KetQuaDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("BienChung_Text", BenhAnNgoaiTru_BenhVayNenTheMu.BienChung_Text));
                Command.Parameters.Add(new MDB.MDBParameter("GDPhongKeHoach", BenhAnNgoaiTru_BenhVayNenTheMu.GDPhongKeHoach));
                Command.Parameters.Add(new MDB.MDBParameter("GDPhongKhamBenh", BenhAnNgoaiTru_BenhVayNenTheMu.GDPhongKhamBenh));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianKhoiPhat", BenhAnNgoaiTru_BenhVayNenTheMu.ThoiGianKhoiPhat));
                Command.Parameters.Add(new MDB.MDBParameter("ViTriKhoiPhat", BenhAnNgoaiTru_BenhVayNenTheMu.ViTriKhoiPhat));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungDauTien", BenhAnNgoaiTru_BenhVayNenTheMu.TrieuChungDauTien));
                Command.Parameters.Add(new MDB.MDBParameter("NhapVienLan", BenhAnNgoaiTru_BenhVayNenTheMu.NhapVienLan));
                Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhDieuTri", BenhAnNgoaiTru_BenhVayNenTheMu.QuaTrinhDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("BenhKhac", BenhAnNgoaiTru_BenhVayNenTheMu.BenhKhac));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiQuenCaNhan", BenhAnNgoaiTru_BenhVayNenTheMu.ThoiQuenCaNhan));
                Command.Parameters.Add(new MDB.MDBParameter("YeuToTinhThan", BenhAnNgoaiTru_BenhVayNenTheMu.YeuToTinhThan));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuGiaDinh", BenhAnNgoaiTru_BenhVayNenTheMu.TienSuGiaDinh));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuGiaDinh_Co", BenhAnNgoaiTru_BenhVayNenTheMu.TienSuGiaDinh_Co));
                Command.Parameters.Add(new MDB.MDBParameter("NguyCoCao", BenhAnNgoaiTru_BenhVayNenTheMu.NguyCoCao));
                Command.Parameters.Add(new MDB.MDBParameter("CoYeuToNguyCoCao", BenhAnNgoaiTru_BenhVayNenTheMu.CoYeuToNguyCoCao));
                Command.Parameters.Add(new MDB.MDBParameter("NhietDo", BenhAnNgoaiTru_BenhVayNenTheMu.NhietDo));
                Command.Parameters.Add(new MDB.MDBParameter("Mach", BenhAnNgoaiTru_BenhVayNenTheMu.Mach));
                Command.Parameters.Add(new MDB.MDBParameter("HA", BenhAnNgoaiTru_BenhVayNenTheMu.HA));
                Command.Parameters.Add(new MDB.MDBParameter("Can", BenhAnNgoaiTru_BenhVayNenTheMu.Can));
                Command.Parameters.Add(new MDB.MDBParameter("Cao", BenhAnNgoaiTru_BenhVayNenTheMu.Cao));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungCoNang", BenhAnNgoaiTru_BenhVayNenTheMu.TrieuChungCoNang));
                Command.Parameters.Add(new MDB.MDBParameter("TonThuongCoBan", BenhAnNgoaiTru_BenhVayNenTheMu.TonThuongCoBan));
                Command.Parameters.Add(new MDB.MDBParameter("DatDo", BenhAnNgoaiTru_BenhVayNenTheMu.DatDo));
                Command.Parameters.Add(new MDB.MDBParameter("MunMu_KichThuoc", BenhAnNgoaiTru_BenhVayNenTheMu.MunMu_KichThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("MunMu_TinhChat", BenhAnNgoaiTru_BenhVayNenTheMu.MunMu_TinhChat));
                Command.Parameters.Add(new MDB.MDBParameter("MunMu_MauSac", BenhAnNgoaiTru_BenhVayNenTheMu.MunMu_MauSac));
                Command.Parameters.Add(new MDB.MDBParameter("MunMu_MatDo", BenhAnNgoaiTru_BenhVayNenTheMu.MunMu_MatDo));
                Command.Parameters.Add(new MDB.MDBParameter("Vay", BenhAnNgoaiTru_BenhVayNenTheMu.Vay));
                Command.Parameters.Add(new MDB.MDBParameter("DauMatCo", JsonConvert.SerializeObject(BenhAnNgoaiTru_BenhVayNenTheMu.DauMatCo)));
                Command.Parameters.Add(new MDB.MDBParameter("ChiTren", JsonConvert.SerializeObject(BenhAnNgoaiTru_BenhVayNenTheMu.ChiTren)));
                Command.Parameters.Add(new MDB.MDBParameter("ThanTruoc", JsonConvert.SerializeObject(BenhAnNgoaiTru_BenhVayNenTheMu.ThanTruoc)));
                Command.Parameters.Add(new MDB.MDBParameter("ThanSau", JsonConvert.SerializeObject(BenhAnNgoaiTru_BenhVayNenTheMu.ThanSau)));
                Command.Parameters.Add(new MDB.MDBParameter("ChiDuoi", JsonConvert.SerializeObject(BenhAnNgoaiTru_BenhVayNenTheMu.ChiDuoi)));
                Command.Parameters.Add(new MDB.MDBParameter("BoPhanSD", JsonConvert.SerializeObject(BenhAnNgoaiTru_BenhVayNenTheMu.BoPhanSD)));
                Command.Parameters.Add(new MDB.MDBParameter("TongDiem", BenhAnNgoaiTru_BenhVayNenTheMu.TongDiem));
                Command.Parameters.Add(new MDB.MDBParameter("MucDo", BenhAnNgoaiTru_BenhVayNenTheMu.MucDo));
                Command.Parameters.Add(new MDB.MDBParameter("MucDoJDA", BenhAnNgoaiTru_BenhVayNenTheMu.MucDoJDA));
                Command.Parameters.Add(new MDB.MDBParameter("DiemPASI", BenhAnNgoaiTru_BenhVayNenTheMu.DiemPASI));
                Command.Parameters.Add(new MDB.MDBParameter("BieuHienMong", BenhAnNgoaiTru_BenhVayNenTheMu.BieuHienMong));
                Command.Parameters.Add(new MDB.MDBParameter("BieuHienMong_Text", BenhAnNgoaiTru_BenhVayNenTheMu.BieuHienMong_Text));
                Command.Parameters.Add(new MDB.MDBParameter("TongDiemNAPSI", BenhAnNgoaiTru_BenhVayNenTheMu.TongDiemNAPSI));
                Command.Parameters.Add(new MDB.MDBParameter("BieuHienKhop", BenhAnNgoaiTru_BenhVayNenTheMu.BieuHienKhop));
                Command.Parameters.Add(new MDB.MDBParameter("SoKhopDau", BenhAnNgoaiTru_BenhVayNenTheMu.SoKhopDau));
                Command.Parameters.Add(new MDB.MDBParameter("SoKhopSung", BenhAnNgoaiTru_BenhVayNenTheMu.SoKhopSung));
                Command.Parameters.Add(new MDB.MDBParameter("BieuHienKhop_Text", BenhAnNgoaiTru_BenhVayNenTheMu.BieuHienKhop_Text));
                Command.Parameters.Add(new MDB.MDBParameter("BieuHienNiemMac", BenhAnNgoaiTru_BenhVayNenTheMu.BieuHienNiemMac));
                Command.Parameters.Add(new MDB.MDBParameter("BieuHienNiemMac_ViTri", BenhAnNgoaiTru_BenhVayNenTheMu.BieuHienNiemMac_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("TimMach", BenhAnNgoaiTru_BenhVayNenTheMu.TimMach));
                Command.Parameters.Add(new MDB.MDBParameter("HoHap", BenhAnNgoaiTru_BenhVayNenTheMu.HoHap));
                Command.Parameters.Add(new MDB.MDBParameter("TieuHoa", BenhAnNgoaiTru_BenhVayNenTheMu.TieuHoa));
                Command.Parameters.Add(new MDB.MDBParameter("TamThan", BenhAnNgoaiTru_BenhVayNenTheMu.TamThan));
                Command.Parameters.Add(new MDB.MDBParameter("DiemDLQI", BenhAnNgoaiTru_BenhVayNenTheMu.DiemDLQI));
                Command.Parameters.Add(new MDB.MDBParameter("GhiChu", BenhAnNgoaiTru_BenhVayNenTheMu.GhiChu));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTheoGGP", BenhAnNgoaiTru_BenhVayNenTheMu.ChanDoanTheoGGP));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanVayNen", BenhAnNgoaiTru_BenhVayNenTheMu.ChanDoanVayNen));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanVayNen_NeuCo", BenhAnNgoaiTru_BenhVayNenTheMu.ChanDoanVayNen_NeuCo));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanVayNen_Khac", BenhAnNgoaiTru_BenhVayNenTheMu.ChanDoanVayNen_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_CuThe", BenhAnNgoaiTru_BenhVayNenTheMu.DieuTri_CuThe));
                Command.Parameters.Add(new MDB.MDBParameter("HenTaiKham", BenhAnNgoaiTru_BenhVayNenTheMu.HenTaiKham));
                Command.Parameters.Add(new MDB.MDBParameter("BacSiDieuTri", BenhAnNgoaiTru_BenhVayNenTheMu.BacSiDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HoTen", BenhAnNgoaiTru_BenhVayNenTheMu.TK_HoTen));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SoBADienTu", BenhAnNgoaiTru_BenhVayNenTheMu.TK_SoBADienTu));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Ngay", BenhAnNgoaiTru_BenhVayNenTheMu.TK_Ngay));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SoLuuTru", BenhAnNgoaiTru_BenhVayNenTheMu.TK_SoLuuTru));
                Command.Parameters.Add(new MDB.MDBParameter("TK_NhietDo", BenhAnNgoaiTru_BenhVayNenTheMu.TK_NhietDo));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Mach", BenhAnNgoaiTru_BenhVayNenTheMu.TK_Mach));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HA", BenhAnNgoaiTru_BenhVayNenTheMu.TK_HA));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Can", BenhAnNgoaiTru_BenhVayNenTheMu.TK_Can));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Cao", BenhAnNgoaiTru_BenhVayNenTheMu.TK_Cao));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TrieuChungCoNang", BenhAnNgoaiTru_BenhVayNenTheMu.TK_TrieuChungCoNang));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TienSu", BenhAnNgoaiTru_BenhVayNenTheMu.TK_TienSu));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DatDo", BenhAnNgoaiTru_BenhVayNenTheMu.TK_DatDo));
                Command.Parameters.Add(new MDB.MDBParameter("TK_MunMu", BenhAnNgoaiTru_BenhVayNenTheMu.TK_MunMu));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Vay", BenhAnNgoaiTru_BenhVayNenTheMu.TK_Vay));
                Command.Parameters.Add(new MDB.MDBParameter("TK_BieuHienMong", BenhAnNgoaiTru_BenhVayNenTheMu.TK_BieuHienMong));
                Command.Parameters.Add(new MDB.MDBParameter("TK_BieuHienMong_ViTri", BenhAnNgoaiTru_BenhVayNenTheMu.TK_BieuHienMong_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TongDiemNAPSI", BenhAnNgoaiTru_BenhVayNenTheMu.TK_TongDiemNAPSI));
                Command.Parameters.Add(new MDB.MDBParameter("TK_BieuHienKhop", BenhAnNgoaiTru_BenhVayNenTheMu.TK_BieuHienKhop));
                Command.Parameters.Add(new MDB.MDBParameter("TK_BieuHienKhop_ViTri", BenhAnNgoaiTru_BenhVayNenTheMu.TK_BieuHienKhop_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_BieuHienNiemMac", BenhAnNgoaiTru_BenhVayNenTheMu.TK_BieuHienNiemMac));
                Command.Parameters.Add(new MDB.MDBParameter("TK_BieuHienNiemMac_ViTri", BenhAnNgoaiTru_BenhVayNenTheMu.TK_BieuHienNiemMac_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TimMach", BenhAnNgoaiTru_BenhVayNenTheMu.TK_TimMach));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HoHap", BenhAnNgoaiTru_BenhVayNenTheMu.TK_HoHap));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TieuHoa", BenhAnNgoaiTru_BenhVayNenTheMu.TK_TieuHoa));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TamThan", BenhAnNgoaiTru_BenhVayNenTheMu.TK_TamThan));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TacDungPhuCuaThuoc", BenhAnNgoaiTru_BenhVayNenTheMu.TK_TacDungPhuCuaThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("TK_JDAScore", BenhAnNgoaiTru_BenhVayNenTheMu.TK_JDAScore));
                Command.Parameters.Add(new MDB.MDBParameter("TK_PASIChoGpp", BenhAnNgoaiTru_BenhVayNenTheMu.TK_PASIChoGpp));
                Command.Parameters.Add(new MDB.MDBParameter("TK_ChuY", BenhAnNgoaiTru_BenhVayNenTheMu.TK_ChuY));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DieuTri", BenhAnNgoaiTru_BenhVayNenTheMu.TK_DieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HenTaiKham", BenhAnNgoaiTru_BenhVayNenTheMu.TK_HenTaiKham));
                Command.Parameters.Add(new MDB.MDBParameter("TK_BacSiKhamBenh", BenhAnNgoaiTru_BenhVayNenTheMu.TK_BacSiKhamBenh));
                Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnNgoaiTru_BenhVayNenTheMu.QuaTrinhBenhLy));
                Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQua", BenhAnNgoaiTru_BenhVayNenTheMu.TomTatKetQua));
                Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnNgoaiTru_BenhVayNenTheMu.BenhChinh));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhChinh", BenhAnNgoaiTru_BenhVayNenTheMu.MaBenhChinh));
                Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnNgoaiTru_BenhVayNenTheMu.BenhKemTheo));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhKemTheo", BenhAnNgoaiTru_BenhVayNenTheMu.MaBenhKemTheo));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnNgoaiTru_BenhVayNenTheMu.PhuongPhapDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangRaVien", BenhAnNgoaiTru_BenhVayNenTheMu.TinhTrangRaVien));
                Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnNgoaiTru_BenhVayNenTheMu.HuongDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnNgoaiTru_BenhVayNenTheMu.NguoiNhanHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnNgoaiTru_BenhVayNenTheMu.NguoiGiaoHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnNgoaiTru_BenhVayNenTheMu.NgayTongKet));
                Command.Parameters.Add(new MDB.MDBParameter("TongKet_BacSyDieuTri", BenhAnNgoaiTru_BenhVayNenTheMu.TongKet_BacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TongKet_MaBacSyDieuTri", BenhAnNgoaiTru_BenhVayNenTheMu.TongKet_MaBacSyDieuTri));

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
        public static bool Update(MDB.MDBConnection MyConnection, BenhAnNgoaiTru_BenhVayNenTheMu BenhAnNgoaiTru_BenhVayNenTheMu)
        {
            try
            {
                string sql = @"UPDATE BenhAnVayNenTheMu SET 
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
                            QuaTrinhDieuTri=:QuaTrinhDieuTri,
                            BenhKhac=:BenhKhac,
                            ThoiQuenCaNhan=:ThoiQuenCaNhan,
                            YeuToTinhThan=:YeuToTinhThan,
                            TienSuGiaDinh=:TienSuGiaDinh,
                            TienSuGiaDinh_Co=:TienSuGiaDinh_Co,
                            NguyCoCao=:NguyCoCao,
                            CoYeuToNguyCoCao=:CoYeuToNguyCoCao,
                            NhietDo=:NhietDo,
                            Mach=:Mach,
                            HA=:HA,
                            Can=:Can,
                            Cao=:Cao,
                            TrieuChungCoNang=:TrieuChungCoNang,
                            TonThuongCoBan=:TonThuongCoBan,
                            DatDo=:DatDo,
                            MunMu_KichThuoc=:MunMu_KichThuoc,
                            MunMu_TinhChat=:MunMu_TinhChat,
                            MunMu_MauSac=:MunMu_MauSac,
                            MunMu_MatDo=:MunMu_MatDo,
                            Vay=:Vay,
                            DauMatCo=:DauMatCo,
                            ChiTren=:ChiTren,
                            ThanTruoc=:ThanTruoc,
                            ThanSau=:ThanSau,
                            ChiDuoi=:ChiDuoi,
                            BoPhanSD=:BoPhanSD,
                            TongDiem=:TongDiem,
                            MucDo=:MucDo,
                            MucDoJDA=:MucDoJDA,
                            DiemPASI=:DiemPASI,
                            BieuHienMong=:BieuHienMong,
                            BieuHienMong_Text=:BieuHienMong_Text,
                            TongDiemNAPSI=:TongDiemNAPSI,
                            BieuHienKhop=:BieuHienKhop,
                            SoKhopDau=:SoKhopDau,
                            SoKhopSung=:SoKhopSung,
                            BieuHienKhop_Text=:BieuHienKhop_Text,
                            BieuHienNiemMac=:BieuHienNiemMac,
                            BieuHienNiemMac_ViTri=:BieuHienNiemMac_ViTri,
                            TimMach=:TimMach,
                            HoHap=:HoHap,
                            TieuHoa=:TieuHoa,
                            TamThan=:TamThan,
                            DiemDLQI=:DiemDLQI,
                            GhiChu=:GhiChu,
                            ChanDoanTheoGGP=:ChanDoanTheoGGP,
                            ChanDoanVayNen=:ChanDoanVayNen,
                            ChanDoanVayNen_NeuCo=:ChanDoanVayNen_NeuCo,
                            ChanDoanVayNen_Khac=:ChanDoanVayNen_Khac,
                            DieuTri_CuThe=:DieuTri_CuThe,
                            HenTaiKham=:HenTaiKham,
                            BacSiDieuTri=:BacSiDieuTri,
                            TK_HoTen=:TK_HoTen,
                            TK_SoBADienTu=:TK_SoBADienTu,
                            TK_Ngay=:TK_Ngay,
                            TK_SoLuuTru=:TK_SoLuuTru,
                            TK_NhietDo=:TK_NhietDo,
                            TK_Mach=:TK_Mach,
                            TK_HA=:TK_HA,
                            TK_Can=:TK_Can,
                            TK_Cao=:TK_Cao,
                            TK_TrieuChungCoNang=:TK_TrieuChungCoNang,
                            TK_TienSu=:TK_TienSu,
                            TK_DatDo=:TK_DatDo,
                            TK_MunMu=:TK_MunMu,
                            TK_Vay=:TK_Vay,
                            TK_BieuHienMong=:TK_BieuHienMong,
                            TK_BieuHienMong_ViTri=:TK_BieuHienMong_ViTri,
                            TK_TongDiemNAPSI=:TK_TongDiemNAPSI,
                            TK_BieuHienKhop=:TK_BieuHienKhop,
                            TK_BieuHienKhop_ViTri=:TK_BieuHienKhop_ViTri,
                            TK_BieuHienNiemMac=:TK_BieuHienNiemMac,
                            TK_BieuHienNiemMac_ViTri=:TK_BieuHienNiemMac_ViTri,
                            TK_TimMach=:TK_TimMach,
                            TK_HoHap=:TK_HoHap,
                            TK_TieuHoa=:TK_TieuHoa,
                            TK_TamThan=:TK_TamThan,
                            TK_TacDungPhuCuaThuoc=:TK_TacDungPhuCuaThuoc,
                            TK_JDAScore=:TK_JDAScore,
                            TK_PASIChoGpp=:TK_PASIChoGpp,
                            TK_ChuY=:TK_ChuY,
                            TK_DieuTri=:TK_DieuTri,
                            TK_HenTaiKham=:TK_HenTaiKham,
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
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriNgoaiTruTu", BenhAnNgoaiTru_BenhVayNenTheMu.DieuTriNgoaiTruTu));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriNgoaiTruDen", BenhAnNgoaiTru_BenhVayNenTheMu.DieuTriNgoaiTruDen));
                Command.Parameters.Add(new MDB.MDBParameter("SoCMND", BenhAnNgoaiTru_BenhVayNenTheMu.SoCMND));
                Command.Parameters.Add(new MDB.MDBParameter("BaoHiem", BenhAnNgoaiTru_BenhVayNenTheMu.BaoHiem));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan_TuyenTruoc", BenhAnNgoaiTru_BenhVayNenTheMu.ChanDoan_TuyenTruoc));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanBanDau", BenhAnNgoaiTru_BenhVayNenTheMu.ChanDoanBanDau));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham1", BenhAnNgoaiTru_BenhVayNenTheMu.ChanDoanTaiKham1));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham2", BenhAnNgoaiTru_BenhVayNenTheMu.ChanDoanTaiKham2));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham3", BenhAnNgoaiTru_BenhVayNenTheMu.ChanDoanTaiKham3));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKham4", BenhAnNgoaiTru_BenhVayNenTheMu.ChanDoanTaiKham4));
                Command.Parameters.Add(new MDB.MDBParameter("BenhPhu", BenhAnNgoaiTru_BenhVayNenTheMu.BenhPhu));
                Command.Parameters.Add(new MDB.MDBParameter("KetQuaDieuTri", BenhAnNgoaiTru_BenhVayNenTheMu.KetQuaDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("BienChung_Text", BenhAnNgoaiTru_BenhVayNenTheMu.BienChung_Text));
                Command.Parameters.Add(new MDB.MDBParameter("GDPhongKeHoach", BenhAnNgoaiTru_BenhVayNenTheMu.GDPhongKeHoach));
                Command.Parameters.Add(new MDB.MDBParameter("GDPhongKhamBenh", BenhAnNgoaiTru_BenhVayNenTheMu.GDPhongKhamBenh));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianKhoiPhat", BenhAnNgoaiTru_BenhVayNenTheMu.ThoiGianKhoiPhat));
                Command.Parameters.Add(new MDB.MDBParameter("ViTriKhoiPhat", BenhAnNgoaiTru_BenhVayNenTheMu.ViTriKhoiPhat));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungDauTien", BenhAnNgoaiTru_BenhVayNenTheMu.TrieuChungDauTien));
                Command.Parameters.Add(new MDB.MDBParameter("NhapVienLan", BenhAnNgoaiTru_BenhVayNenTheMu.NhapVienLan));
                Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhDieuTri", BenhAnNgoaiTru_BenhVayNenTheMu.QuaTrinhDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("BenhKhac", BenhAnNgoaiTru_BenhVayNenTheMu.BenhKhac));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiQuenCaNhan", BenhAnNgoaiTru_BenhVayNenTheMu.ThoiQuenCaNhan));
                Command.Parameters.Add(new MDB.MDBParameter("YeuToTinhThan", BenhAnNgoaiTru_BenhVayNenTheMu.YeuToTinhThan));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuGiaDinh", BenhAnNgoaiTru_BenhVayNenTheMu.TienSuGiaDinh));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuGiaDinh_Co", BenhAnNgoaiTru_BenhVayNenTheMu.TienSuGiaDinh_Co));
                Command.Parameters.Add(new MDB.MDBParameter("NguyCoCao", BenhAnNgoaiTru_BenhVayNenTheMu.NguyCoCao));
                Command.Parameters.Add(new MDB.MDBParameter("CoYeuToNguyCoCao", BenhAnNgoaiTru_BenhVayNenTheMu.CoYeuToNguyCoCao));
                Command.Parameters.Add(new MDB.MDBParameter("NhietDo", BenhAnNgoaiTru_BenhVayNenTheMu.NhietDo));
                Command.Parameters.Add(new MDB.MDBParameter("Mach", BenhAnNgoaiTru_BenhVayNenTheMu.Mach));
                Command.Parameters.Add(new MDB.MDBParameter("HA", BenhAnNgoaiTru_BenhVayNenTheMu.HA));
                Command.Parameters.Add(new MDB.MDBParameter("Can", BenhAnNgoaiTru_BenhVayNenTheMu.Can));
                Command.Parameters.Add(new MDB.MDBParameter("Cao", BenhAnNgoaiTru_BenhVayNenTheMu.Cao));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungCoNang", BenhAnNgoaiTru_BenhVayNenTheMu.TrieuChungCoNang));
                Command.Parameters.Add(new MDB.MDBParameter("TonThuongCoBan", BenhAnNgoaiTru_BenhVayNenTheMu.TonThuongCoBan));
                Command.Parameters.Add(new MDB.MDBParameter("DatDo", BenhAnNgoaiTru_BenhVayNenTheMu.DatDo));
                Command.Parameters.Add(new MDB.MDBParameter("MunMu_KichThuoc", BenhAnNgoaiTru_BenhVayNenTheMu.MunMu_KichThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("MunMu_TinhChat", BenhAnNgoaiTru_BenhVayNenTheMu.MunMu_TinhChat));
                Command.Parameters.Add(new MDB.MDBParameter("MunMu_MauSac", BenhAnNgoaiTru_BenhVayNenTheMu.MunMu_MauSac));
                Command.Parameters.Add(new MDB.MDBParameter("MunMu_MatDo", BenhAnNgoaiTru_BenhVayNenTheMu.MunMu_MatDo));
                Command.Parameters.Add(new MDB.MDBParameter("Vay", BenhAnNgoaiTru_BenhVayNenTheMu.Vay));
                Command.Parameters.Add(new MDB.MDBParameter("DauMatCo", JsonConvert.SerializeObject(BenhAnNgoaiTru_BenhVayNenTheMu.DauMatCo)));
                Command.Parameters.Add(new MDB.MDBParameter("ChiTren", JsonConvert.SerializeObject(BenhAnNgoaiTru_BenhVayNenTheMu.ChiTren)));
                Command.Parameters.Add(new MDB.MDBParameter("ThanTruoc", JsonConvert.SerializeObject(BenhAnNgoaiTru_BenhVayNenTheMu.ThanTruoc)));
                Command.Parameters.Add(new MDB.MDBParameter("ThanSau", JsonConvert.SerializeObject(BenhAnNgoaiTru_BenhVayNenTheMu.ThanSau)));
                Command.Parameters.Add(new MDB.MDBParameter("ChiDuoi", JsonConvert.SerializeObject(BenhAnNgoaiTru_BenhVayNenTheMu.ChiDuoi)));
                Command.Parameters.Add(new MDB.MDBParameter("BoPhanSD", JsonConvert.SerializeObject(BenhAnNgoaiTru_BenhVayNenTheMu.BoPhanSD)));
                Command.Parameters.Add(new MDB.MDBParameter("TongDiem", BenhAnNgoaiTru_BenhVayNenTheMu.TongDiem));
                Command.Parameters.Add(new MDB.MDBParameter("MucDo", BenhAnNgoaiTru_BenhVayNenTheMu.MucDo));
                Command.Parameters.Add(new MDB.MDBParameter("MucDoJDA", BenhAnNgoaiTru_BenhVayNenTheMu.MucDoJDA));
                Command.Parameters.Add(new MDB.MDBParameter("DiemPASI", BenhAnNgoaiTru_BenhVayNenTheMu.DiemPASI));
                Command.Parameters.Add(new MDB.MDBParameter("BieuHienMong", BenhAnNgoaiTru_BenhVayNenTheMu.BieuHienMong));
                Command.Parameters.Add(new MDB.MDBParameter("BieuHienMong_Text", BenhAnNgoaiTru_BenhVayNenTheMu.BieuHienMong_Text));
                Command.Parameters.Add(new MDB.MDBParameter("TongDiemNAPSI", BenhAnNgoaiTru_BenhVayNenTheMu.TongDiemNAPSI));
                Command.Parameters.Add(new MDB.MDBParameter("BieuHienKhop", BenhAnNgoaiTru_BenhVayNenTheMu.BieuHienKhop));
                Command.Parameters.Add(new MDB.MDBParameter("SoKhopDau", BenhAnNgoaiTru_BenhVayNenTheMu.SoKhopDau));
                Command.Parameters.Add(new MDB.MDBParameter("SoKhopSung", BenhAnNgoaiTru_BenhVayNenTheMu.SoKhopSung));
                Command.Parameters.Add(new MDB.MDBParameter("BieuHienKhop_Text", BenhAnNgoaiTru_BenhVayNenTheMu.BieuHienKhop_Text));
                Command.Parameters.Add(new MDB.MDBParameter("BieuHienNiemMac", BenhAnNgoaiTru_BenhVayNenTheMu.BieuHienNiemMac));
                Command.Parameters.Add(new MDB.MDBParameter("BieuHienNiemMac_ViTri", BenhAnNgoaiTru_BenhVayNenTheMu.BieuHienNiemMac_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("TimMach", BenhAnNgoaiTru_BenhVayNenTheMu.TimMach));
                Command.Parameters.Add(new MDB.MDBParameter("HoHap", BenhAnNgoaiTru_BenhVayNenTheMu.HoHap));
                Command.Parameters.Add(new MDB.MDBParameter("TieuHoa", BenhAnNgoaiTru_BenhVayNenTheMu.TieuHoa));
                Command.Parameters.Add(new MDB.MDBParameter("TamThan", BenhAnNgoaiTru_BenhVayNenTheMu.TamThan));
                Command.Parameters.Add(new MDB.MDBParameter("DiemDLQI", BenhAnNgoaiTru_BenhVayNenTheMu.DiemDLQI));
                Command.Parameters.Add(new MDB.MDBParameter("GhiChu", BenhAnNgoaiTru_BenhVayNenTheMu.GhiChu));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTheoGGP", BenhAnNgoaiTru_BenhVayNenTheMu.ChanDoanTheoGGP));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanVayNen", BenhAnNgoaiTru_BenhVayNenTheMu.ChanDoanVayNen));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanVayNen_NeuCo", BenhAnNgoaiTru_BenhVayNenTheMu.ChanDoanVayNen_NeuCo));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanVayNen_Khac", BenhAnNgoaiTru_BenhVayNenTheMu.ChanDoanVayNen_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_CuThe", BenhAnNgoaiTru_BenhVayNenTheMu.DieuTri_CuThe));
                Command.Parameters.Add(new MDB.MDBParameter("HenTaiKham", BenhAnNgoaiTru_BenhVayNenTheMu.HenTaiKham));
                Command.Parameters.Add(new MDB.MDBParameter("BacSiDieuTri", BenhAnNgoaiTru_BenhVayNenTheMu.BacSiDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HoTen", BenhAnNgoaiTru_BenhVayNenTheMu.TK_HoTen));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SoBADienTu", BenhAnNgoaiTru_BenhVayNenTheMu.TK_SoBADienTu));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Ngay", BenhAnNgoaiTru_BenhVayNenTheMu.TK_Ngay));
                Command.Parameters.Add(new MDB.MDBParameter("TK_SoLuuTru", BenhAnNgoaiTru_BenhVayNenTheMu.TK_SoLuuTru));
                Command.Parameters.Add(new MDB.MDBParameter("TK_NhietDo", BenhAnNgoaiTru_BenhVayNenTheMu.TK_NhietDo));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Mach", BenhAnNgoaiTru_BenhVayNenTheMu.TK_Mach));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HA", BenhAnNgoaiTru_BenhVayNenTheMu.TK_HA));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Can", BenhAnNgoaiTru_BenhVayNenTheMu.TK_Can));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Cao", BenhAnNgoaiTru_BenhVayNenTheMu.TK_Cao));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TrieuChungCoNang", BenhAnNgoaiTru_BenhVayNenTheMu.TK_TrieuChungCoNang));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TienSu", BenhAnNgoaiTru_BenhVayNenTheMu.TK_TienSu));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DatDo", BenhAnNgoaiTru_BenhVayNenTheMu.TK_DatDo));
                Command.Parameters.Add(new MDB.MDBParameter("TK_MunMu", BenhAnNgoaiTru_BenhVayNenTheMu.TK_MunMu));
                Command.Parameters.Add(new MDB.MDBParameter("TK_Vay", BenhAnNgoaiTru_BenhVayNenTheMu.TK_Vay));
                Command.Parameters.Add(new MDB.MDBParameter("TK_BieuHienMong", BenhAnNgoaiTru_BenhVayNenTheMu.TK_BieuHienMong));
                Command.Parameters.Add(new MDB.MDBParameter("TK_BieuHienMong_ViTri", BenhAnNgoaiTru_BenhVayNenTheMu.TK_BieuHienMong_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TongDiemNAPSI", BenhAnNgoaiTru_BenhVayNenTheMu.TK_TongDiemNAPSI));
                Command.Parameters.Add(new MDB.MDBParameter("TK_BieuHienKhop", BenhAnNgoaiTru_BenhVayNenTheMu.TK_BieuHienKhop));
                Command.Parameters.Add(new MDB.MDBParameter("TK_BieuHienKhop_ViTri", BenhAnNgoaiTru_BenhVayNenTheMu.TK_BieuHienKhop_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_BieuHienNiemMac", BenhAnNgoaiTru_BenhVayNenTheMu.TK_BieuHienNiemMac));
                Command.Parameters.Add(new MDB.MDBParameter("TK_BieuHienNiemMac_ViTri", BenhAnNgoaiTru_BenhVayNenTheMu.TK_BieuHienNiemMac_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TimMach", BenhAnNgoaiTru_BenhVayNenTheMu.TK_TimMach));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HoHap", BenhAnNgoaiTru_BenhVayNenTheMu.TK_HoHap));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TieuHoa", BenhAnNgoaiTru_BenhVayNenTheMu.TK_TieuHoa));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TamThan", BenhAnNgoaiTru_BenhVayNenTheMu.TK_TamThan));
                Command.Parameters.Add(new MDB.MDBParameter("TK_TacDungPhuCuaThuoc", BenhAnNgoaiTru_BenhVayNenTheMu.TK_TacDungPhuCuaThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("TK_JDAScore", BenhAnNgoaiTru_BenhVayNenTheMu.TK_JDAScore));
                Command.Parameters.Add(new MDB.MDBParameter("TK_PASIChoGpp", BenhAnNgoaiTru_BenhVayNenTheMu.TK_PASIChoGpp));
                Command.Parameters.Add(new MDB.MDBParameter("TK_ChuY", BenhAnNgoaiTru_BenhVayNenTheMu.TK_ChuY));
                Command.Parameters.Add(new MDB.MDBParameter("TK_DieuTri", BenhAnNgoaiTru_BenhVayNenTheMu.TK_DieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TK_HenTaiKham", BenhAnNgoaiTru_BenhVayNenTheMu.TK_HenTaiKham));
                Command.Parameters.Add(new MDB.MDBParameter("TK_BacSiKhamBenh", BenhAnNgoaiTru_BenhVayNenTheMu.TK_BacSiKhamBenh));
                Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", BenhAnNgoaiTru_BenhVayNenTheMu.QuaTrinhBenhLy));
                Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQua", BenhAnNgoaiTru_BenhVayNenTheMu.TomTatKetQua));
                Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", BenhAnNgoaiTru_BenhVayNenTheMu.BenhChinh));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhChinh", BenhAnNgoaiTru_BenhVayNenTheMu.MaBenhChinh));
                Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", BenhAnNgoaiTru_BenhVayNenTheMu.BenhKemTheo));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhKemTheo", BenhAnNgoaiTru_BenhVayNenTheMu.MaBenhKemTheo));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", BenhAnNgoaiTru_BenhVayNenTheMu.PhuongPhapDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangRaVien", BenhAnNgoaiTru_BenhVayNenTheMu.TinhTrangRaVien));
                Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", BenhAnNgoaiTru_BenhVayNenTheMu.HuongDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanHoSo", BenhAnNgoaiTru_BenhVayNenTheMu.NguoiNhanHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoHoSo", BenhAnNgoaiTru_BenhVayNenTheMu.NguoiGiaoHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("NgayTongKet", BenhAnNgoaiTru_BenhVayNenTheMu.NgayTongKet));
                Command.Parameters.Add(new MDB.MDBParameter("TongKet_BacSyDieuTri", BenhAnNgoaiTru_BenhVayNenTheMu.TongKet_BacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TongKet_MaBacSyDieuTri", BenhAnNgoaiTru_BenhVayNenTheMu.TongKet_MaBacSyDieuTri));

                Command.BindByName = true;

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnNgoaiTru_BenhVayNenTheMu.MaQuanLy));
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
