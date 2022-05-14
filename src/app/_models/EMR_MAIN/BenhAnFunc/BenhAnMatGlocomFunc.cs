
using MDB;
using Newtonsoft.Json;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;

namespace EMR_MAIN
{
    public class BenhAnMatGlocomFunc
    {
        public static void WriteXml(MDB.MDBConnection MyConnection)
        {
            string sql =
                   @"
                  select  a.*,  CTScanner HoSo_CTScanner, SieuAm HoSo_SieuAm, XetNghiem HoSo_XetNghiem,  Khac HoSo_Khac,  Khac_Text HoSo_Khac_Text,  ToanBoHoSo HoSo_ToanBoHoSo, Mach DauSinhTon_Mach,  NhietDo DauSinhTon_NhietDo,  HuyetAp DauSinhTon_HuyetAp,  NhipTho DauSinhTon_NhipTho,  CanNang DauSinhTon_CanNang  
                  from BenhAnMatGlocom a inner join thongtindieutri b on a.maquanly = b.maquanly
                  where rownum = 1
                    ";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            var DataTable = new DataTable { TableName = "BenhAnMatGlocom" };
            DataTable.Load(DataReader as IDataReader);
            DataTable.WriteXml("rptBenhAnMatGlocom.xml");
        }
        public static DataSet SelectDataSet(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql =
                   @"
                   select  a.*,f.hovaten BacSyLamBenhAnHoVaTen ,c.hovaten BacSyDieuTriHoVaTen,d.hovaten NguoiGiaoHoSoHoVaTen,e.hovaten NguoiNhanHoSoHoVaTen, b.XQuang HoSo_XQuang,   b.CTScanner HoSo_CTScanner, b.SieuAm HoSo_SieuAm, b.XetNghiem HoSo_XetNghiem,  b.Khac HoSo_Khac,  b.Khac_Text HoSo_Khac_Text,  b.ToanBoHoSo HoSo_ToanBoHoSo, b.Mach DauSinhTon_Mach, b.NhietDo DauSinhTon_NhietDo,  b.HuyetAp DauSinhTon_HuyetAp,  b.NhipTho DauSinhTon_NhipTho,  b.CanNang DauSinhTon_CanNang  , b.ChieuCao DauSinhTon_ChieuCao, b.BMI DauSinhTon_BMI, b.NgayRaVien 
                 from BenhAnMatGlocom a 
                 left join thongtindieutri b on a.maquanly = b.maquanly 
                  left join nhanvien c on a.bacsydieutri = c.manhanvien
                  left join nhanvien d on a.nguoigiaohoso = d.manhanvien
                  left join nhanvien e on a.nguoinhanhoso = e.manhanvien
                  left join nhanvien f on a.BacSyLamBenhAn = f.manhanvien
                  where a.maquanly = " + MaQuanLy.ToString(CultureInfo.InvariantCulture);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(sql, MyConnection);
            var ds = new DataSet();
            adt.Fill(ds, "Table");

            string sql2 =
                @"   select a.*,c.hovaten BacSyPhauThuatHoVaTen, d.hovaten BacSyGayMeHoVaTen
                  from PhauThuatThuThuat a
                  left join nhanvien c on a.bacsyphauthuat  = c.manhanvien
                  left join nhanvien d on a.bacsygayme= d.manhanvien
                  where a.maquanly = " + MaQuanLy.ToString(CultureInfo.InvariantCulture);
            adt = new MDB.MDBDataAdapter(sql2, MyConnection);
            adt.Fill(ds, "Table2");

            if (ds != null && ds.Tables.Count > 0)
            {
                DataTable dt = ds.Tables[0];
                if (dt != null && dt.Rows.Count > 0)
                {
                    var danhSachThuoc = dt.Rows[0]["ThuocHaNhanApDaDung"].ToString();
                    if (danhSachThuoc != "null" && danhSachThuoc != "[]")
                    {
                        DataTable dtThuoc = Converter.ListToDatatable.ToDataTable(JsonConvert.DeserializeObject<List<ThuocHaNhanApDaDungs>>(dt.Rows[0]["ThuocHaNhanApDaDung"].ToString()));
                        ds.Tables.Add(dtThuoc);
                    }
                }
            }
            return ds;
        }
        public static BenhAnMatGlocom Select(MDB.MDBConnection MyConnection, decimal MaQuanLy, ThongTinDieuTri ba)
        {
            try
            {
                #region
                string sql = @"select * from BENHANMATGLOCOM WHERE MaQuanLy = :MaQuanLy";
                #endregion
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                var value = new BenhAnMatGlocom();
                value.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
                value.HoSo = new HoSo();
                value.DauSinhTon = new DauSinhTon();
                while (DataReader.Read())
                {
                    value.MaQuanLy = DataReader.GetDecimal("MaQuanLy");
                    value.LyDoVaoVien = DataReader["LyDoVaoVien"].ToString();
                    value.VaoNgayThu = DataReader.GetInt("VaoNgayThu");
                    value.QuaTrinhBenhLy = DataReader["QuaTrinhBenhLy"].ToString();
                    value.TienSuBenhBanThan = DataReader["TienSuBenhBanThan"].ToString();
                    value.TienSuBenhGiaDinh = DataReader["TienSuBenhGiaDinh"].ToString();
                    value.DauSinhTon.Mach = ba.DauSinhTon.Mach;
                    value.DauSinhTon.NhietDo = ba.DauSinhTon.Mach;
                    value.DauSinhTon.HuyetAp = ba.DauSinhTon.HuyetAp;
                    value.DauSinhTon.NhipTho = ba.DauSinhTon.NhipTho;
                    value.DauSinhTon.ChieuCao = ba.DauSinhTon.ChieuCao;
                    value.DauSinhTon.CanNang = ba.DauSinhTon.CanNang;
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
                    if (DataReader["NgayKhamBenh"] != null && DataReader["NgayKhamBenh"].ToString() != "")
                        value.NgayKhamBenh = DataReader.GetDate("NgayKhamBenh");
                    value.BacSyLamBenhAn = DataReader["BacSyLamBenhAn"].ToString();
                    int CTScanner = 0;
                    try
                    {
                        CTScanner = DataReader.GetInt("CTScanner");
                    }
                    catch { }
                    int XQuang = 0;
                    try
                    {
                        XQuang = DataReader.GetInt("XQuang");
                    }
                    catch { }
                    int SieuAm = 0;
                    try
                    {
                        SieuAm = DataReader.GetInt("SieuAm");
                    }
                    catch { }
                    int XetNghiem = 0;
                    try
                    {
                        XetNghiem = DataReader.GetInt("XetNghiem");
                    }
                    catch { }
                    int Khac = 0;
                    try
                    {
                        Khac = DataReader.GetInt("Khac");
                    }
                    catch { }
                    int ToanBoHoSo = 0;
                    try
                    {
                        ToanBoHoSo = DataReader.GetInt("ToanBoHoSo");
                    }
                    catch { }
                    value.HoSo.CTScanner = CTScanner;
                    value.HoSo.XQuang = XQuang;
                    value.HoSo.SieuAm = SieuAm;
                    value.HoSo.XetNghiem = XetNghiem;
                    value.HoSo.Khac = Khac;
                    value.HoSo.ToanBoHoSo = ToanBoHoSo;
                    value.QuaTrinhBenhLyVaDienBien = DataReader["QuaTrinhBenhLyVaDienBien"].ToString();
                    value.TomTatKetQuaXetNghiem = DataReader["TomTatKetQuaXetNghiem"].ToString();
                    value.PhuongPhapDieuTri = DataReader["PhuongPhapDieuTri"].ToString();
                    value.TinhTrangNguoiBenhRaVien = DataReader["TinhTrangNguoiBenhRaVien"].ToString();
                    value.HuongDieuTriVaCacCheDoTiepTheo = DataReader["HuongDieuTriVaCacCheDoTiepTheo"].ToString();
                    value.NguoiNhanHoSo = DataReader["NguoiNhanHoSo"].ToString();
                    value.NguoiGiaoHoSo = DataReader["NguoiGiaoHoSo"].ToString();
                    if (DataReader["NgayTongKet"] != null && DataReader["NgayTongKet"].ToString() != "")
                        value.NgayTongKet = DataReader.GetDate("NgayTongKet");
                    value.BacSyDieuTri = DataReader["BacSyDieuTri"].ToString();
                    value.DacDiemLienQuanBenh.DiUng = DataReader["DiUng"].ToString().Equals("1") ? true : false;
                    value.DacDiemLienQuanBenh.DiUng_Text = DataReader["DiUng_Text"].ToString();
                    value.DacDiemLienQuanBenh.MaTuy = DataReader["MaTuy"].ToString().Equals("1") ? true : false;
                    value.DacDiemLienQuanBenh.MaTuy_Text = DataReader["MaTuy_Text"].ToString();
                    value.DacDiemLienQuanBenh.RuouBia = DataReader["RuouBia"].ToString().Equals("1") ? true : false;
                    value.DacDiemLienQuanBenh.RuouBia_Text = DataReader["RuouBia_Text"].ToString();
                    value.DacDiemLienQuanBenh.ThuocLa = DataReader["ThuocLa"].ToString().Equals("1") ? true : false;
                    value.DacDiemLienQuanBenh.ThuocLa_Text = DataReader["ThuocLa_Text"].ToString();
                    value.DacDiemLienQuanBenh.ThuocLao = DataReader["ThuocLao"].ToString().Equals("1") ? true : false;
                    value.DacDiemLienQuanBenh.ThuocLao_Text = DataReader["ThuocLao_Text"].ToString();
                    value.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh = DataReader["Khac_DacDiemLienQuanBenh"].ToString().Equals("1") ? true : false;
                    value.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh_Text = DataReader["Khac_DacDiemLienQuanBenh_Text"].ToString();
                    value.LyDoDiKham_MP = DataReader["LyDoDiKham_MP"].ToString().Equals("1") ? true : false;
                    value.LyDoDiKham_MT = DataReader["LyDoDiKham_MT"].ToString().Equals("1") ? true : false;
                    value.LyDoDiKham_2Mat = DataReader["LyDoDiKham_2Mat"].ToString().Equals("1") ? true : false;
                    value.NhucMat_DuDoi = DataReader["NhucMat_DuDoi"].ToString().Equals("1") ? true : false;
                    value.NhucMat_Vua = DataReader["NhucMat_Vua"].ToString().Equals("1") ? true : false;
                    value.NhucMat_Nhe = DataReader["NhucMat_Nhe"].ToString().Equals("1") ? true : false;
                    value.NhucMat_Khong = DataReader["NhucMat_Khong"].ToString().Equals("1") ? true : false;
                    value.Nhin_MoDotNgot = DataReader["Nhin_MoDotNgot"].ToString().Equals("1") ? true : false;
                    value.Nhin_MoTungLuc = DataReader["Nhin_MoTungLuc"].ToString().Equals("1") ? true : false;
                    value.Nhin_SuongMu = DataReader["Nhin_SuongMu"].ToString().Equals("1") ? true : false;
                    value.Nhin_KhongMo = DataReader["Nhin_KhongMo"].ToString().Equals("1") ? true : false;
                    value.Nhin_MoTangDan = DataReader["Nhin_MoTangDan"].ToString().Equals("1") ? true : false;
                    value.Nhin_NhinThuHep = DataReader["Nhin_NhinThuHep"].ToString().Equals("1") ? true : false;
                    value.Nhin_QuanTanSac = DataReader["Nhin_QuanTanSac"].ToString().Equals("1") ? true : false;
                    value.SoAnhSangChayNuocMat_Co = DataReader["SoAnhSangChayNuocMat_Co"].ToString().Equals("1") ? true : false;
                    value.SoAnhSangChayNuocMat_Khong = DataReader["SoAnhSangChayNuocMat_Khong"].ToString().Equals("1") ? true : false;
                    value.DoMat_Co = DataReader["DoMat_Co"].ToString().Equals("1") ? true : false;
                    value.DoMat_Khong = DataReader["DoMat_Khong"].ToString().Equals("1") ? true : false;
                    value.ToanThan_DauDau = DataReader["ToanThan_DauDau"].ToString().Equals("1") ? true : false;
                    value.ToanThan_Non = DataReader["ToanThan_Non"].ToString().Equals("1") ? true : false;
                    value.ToanThan_BuonNon = DataReader["ToanThan_BuonNon"].ToString().Equals("1") ? true : false;
                    value.ToanThan_Khong = DataReader["ToanThan_Khong"].ToString().Equals("1") ? true : false;
                    value.CacTrieuChungKhac = DataReader["CacTrieuChungKhac"].ToString();
                    value.ThoiGianXuatHienBenh = DataReader["ThoiGianXuatHienBenh"].ToString();
                    value.DaKhamChuaBenh_Huyen = DataReader["DaKhamChuaBenh_Huyen"].ToString().Equals("1") ? true : false;
                    value.DaKhamChuaBenh_Tinh = DataReader["DaKhamChuaBenh_Tinh"].ToString().Equals("1") ? true : false;
                    value.DaKhamChuaBenh_TrungUong = DataReader["DaKhamChuaBenh_TrungUong"].ToString().Equals("1") ? true : false;
                    value.DaKhamChuaBenh_Khac = DataReader["DaKhamChuaBenh_Khac"].ToString().Equals("1") ? true : false;
                    value.PhuongPhapDieuTri_PhauThuat = DataReader["PhuongPhapDieuTri_PhauThuat"].ToString().Equals("1") ? true : false;
                    value.PhuongPhapDieuTri_Thuoc = DataReader["PhuongPhapDieuTri_Thuoc"].ToString().Equals("1") ? true : false;
                    value.PhuongPhapDieuTri_Laser = DataReader["PhuongPhapDieuTri_Laser"].ToString().Equals("1") ? true : false;
                    value.PTTTMP_Loai1 = DataReader["PTTTMP_Loai1"].ToString();
                    value.PTTTMP_Loai2 = DataReader["PTTTMP_Loai2"].ToString();
                    value.PTTTMP_Loai3 = DataReader["PTTTMP_Loai3"].ToString();
                    value.PTTTMP_Loai4 = DataReader["PTTTMP_Loai4"].ToString();
                    value.PTTTMT_Loai1 = DataReader["PTTTMT_Loai1"].ToString();
                    value.PTTTMT_Loai2 = DataReader["PTTTMT_Loai2"].ToString();
                    value.PTTTMT_Loai3 = DataReader["PTTTMT_Loai3"].ToString();
                    value.PTTTMT_Loai4 = DataReader["PTTTMT_Loai4"].ToString();
                    value.PTTTMP_ThoiDiem1 = DataReader["PTTTMP_ThoiDiem1"].ToString();
                    value.PTTTMP_ThoiDiem2 = DataReader["PTTTMP_ThoiDiem2"].ToString();
                    value.PTTTMP_ThoiDiem3 = DataReader["PTTTMP_ThoiDiem3"].ToString();
                    value.PTTTMP_ThoiDiem4 = DataReader["PTTTMP_ThoiDiem4"].ToString();
                    value.PTTTMT_ThoiDiem1 = DataReader["PTTTMT_ThoiDiem1"].ToString();
                    value.PTTTMT_ThoiDiem2 = DataReader["PTTTMT_ThoiDiem2"].ToString();
                    value.PTTTMT_ThoiDiem3 = DataReader["PTTTMT_ThoiDiem3"].ToString();
                    value.PTTTMT_ThoiDiem4 = DataReader["PTTTMT_ThoiDiem4"].ToString();
                    value.PTTTMP_Noi1 = DataReader["PTTTMP_Noi1"].ToString();
                    value.PTTTMP_Noi2 = DataReader["PTTTMP_Noi2"].ToString();
                    value.PTTTMP_Noi3 = DataReader["PTTTMP_Noi3"].ToString();
                    value.PTTTMP_Noi4 = DataReader["PTTTMP_Noi4"].ToString();
                    value.PTTTMT_Noi1 = DataReader["PTTTMT_Noi1"].ToString();
                    value.PTTTMT_Noi2 = DataReader["PTTTMT_Noi2"].ToString();
                    value.PTTTMT_Noi3 = DataReader["PTTTMT_Noi3"].ToString();
                    value.PTTTMT_Noi4 = DataReader["PTTTMT_Noi4"].ToString();
                    value.ThuocHaNhanAp_Uong = DataReader["ThuocHaNhanAp_Uong"].ToString().Equals("1") ? true : false;
                    value.ThuocHaNhanAp_TraMat = DataReader["ThuocHaNhanAp_TraMat"].ToString().Equals("1") ? true : false;
                    value.ThuocHaNhanAp_Tiem = DataReader["ThuocHaNhanAp_Tiem"].ToString().Equals("1") ? true : false;
                    value.ThuocHaNhanAp_1Thuoc = DataReader["ThuocHaNhanAp_1Thuoc"].ToString().Equals("1") ? true : false;
                    value.ThuocHaNhanAp_2Thuoc = DataReader["ThuocHaNhanAp_2Thuoc"].ToString().Equals("1") ? true : false;
                    value.ThuocHaNhanAp_3Thuoc = DataReader["ThuocHaNhanAp_3Thuoc"].ToString().Equals("1") ? true : false;
                    value.ThuocHaNhanAp_4Thuoc = DataReader["ThuocHaNhanAp_4Thuoc"].ToString().Equals("1") ? true : false;
                    var x = DataReader["ThuocHaNhanApDaDung"].ToString();
                    if (x.IsNotNullOrEmpty())
                    {
                        value.ThuocHaNhanApDaDung = JsonConvert.DeserializeObject<List<ThuocHaNhanApDaDungs>>(DataReader["ThuocHaNhanApDaDung"].ToString());
                    }
                    value.CacThuocKhac = DataReader["CacThuocKhac"].ToString();
                    value.TienTrinhDieuTri = DataReader["TienTrinhDieuTri"].ToString();
                    value.TienSuKhac = DataReader.GetInt("TienSuKhac");
                    value.TienSuKhac_CanThi = DataReader["TienSuKhac_CanThi"].ToString().Equals("1") ? true : false;
                    value.TienSuKhac_VienThi = DataReader["TienSuKhac_VienThi"].ToString().Equals("1") ? true : false;
                    value.TienSuKhac_TranThuong = DataReader["TienSuKhac_TranThuong"].ToString().Equals("1") ? true : false;
                    value.TienSuKhac_VienMangBoDao = DataReader["TienSuKhac_VienMangBoDao"].ToString().Equals("1") ? true : false;
                    value.TienSuKhac_VienPhanTruocNhaCau = DataReader["TienSuKhac_VienPhanTruocNhaCau"].ToString().Equals("1") ? true : false;
                    value.TienSuKhac_TacTMTTVM = DataReader["TienSuKhac_TacTMTTVM"].ToString().Equals("1") ? true : false;
                    value.TienSuKhac_DaPTMat = DataReader["TienSuKhac_DaPTMat"].ToString().Equals("1") ? true : false;
                    value.TienSuKhac_BenhKhac = DataReader["TienSuKhac_BenhKhac"].ToString().Equals("1") ? true : false;
                    value.TienSuKhac_Corticosteroid = DataReader["TienSuKhac_Corticosteroid"].ToString();
                    value.ThoiGianSuDung_Corticosteroid = DataReader["ThoiGianSuDung_Corticosteroid"].ToString();
                    value.Corticosteroid_TraMat = DataReader["Corticosteroid_TraMat"].ToString().Equals("1") ? true : false;
                    value.Corticosteroid_TiemMat = DataReader["Corticosteroid_TiemMat"].ToString().Equals("1") ? true : false;
                    value.Corticosteroid_ToanThan = DataReader["Corticosteroid_ToanThan"].ToString().Equals("1") ? true : false;
                    value.Corticosteroid_TheoCDCuaBacSi = DataReader["Corticosteroid_TheoCDCuaBacSi"].ToString().Equals("1") ? true : false;
                    value.Corticosteroid_BNTuDungThuoc = DataReader["Corticosteroid_BNTuDungThuoc"].ToString().Equals("1") ? true : false;
                    value.TienSuToanThan_TimMach = DataReader["TienSuToanThan_TimMach"].ToString().Equals("1") ? true : false;
                    value.TienSuToanThan_HuyetAp = DataReader["TienSuToanThan_HuyetAp"].ToString().Equals("1") ? true : false;
                    value.TienSuToanThan_DaiDuong = DataReader["TienSuToanThan_DaiDuong"].ToString().Equals("1") ? true : false;
                    value.TienSuToanThan_RoDongMachCanh = DataReader["TienSuToanThan_RoDongMachCanh"].ToString().Equals("1") ? true : false;
                    value.TienSuToanThan_BenhKhac = DataReader["TienSuToanThan_BenhKhac"].ToString().Equals("1") ? true : false;
                    value.TienSuGlocomGiaDinh_OngBa = DataReader["TienSuGlocomGiaDinh_OngBa"].ToString().Equals("1") ? true : false;
                    value.TienSuGlocomGiaDinh_BoMe = DataReader["TienSuGlocomGiaDinh_BoMe"].ToString().Equals("1") ? true : false;
                    value.TienSuGlocomGiaDinh_AnhChiEm = DataReader["TienSuGlocomGiaDinh_AnhChiEm"].ToString().Equals("1") ? true : false;
                    value.TienSuGlocomGiaDinh_CoDiChuBac = DataReader["TienSuGlocomGiaDinh_CoDiChuBac"].ToString().Equals("1") ? true : false;
                    value.ThiLucVaoVienMP_KhongKinh = DataReader["ThiLucVaoVienMP_KhongKinh"].ToString();
                    value.ThiLucVaoVienMT_KhongKinh = DataReader["ThiLucVaoVienMT_KhongKinh"].ToString();
                    value.ThiLucVaoVienMP_CoKinh = DataReader["ThiLucVaoVienMP_CoKinh"].ToString();
                    value.ThiLucVaoVienMT_CoKinh = DataReader["ThiLucVaoVienMT_CoKinh"].ToString();
                    value.NhaApMP = DataReader["NhaApMP"].ToString();
                    value.NhaApMT = DataReader["NhaApMT"].ToString();
                    value.MiMatSungNeMP_Khong = DataReader["MiMatSungNeMP_Khong"].ToString().Equals("1") ? true : false;
                    value.MiMatSungNeMP_Co = DataReader["MiMatSungNeMP_Co"].ToString().Equals("1") ? true : false;
                    value.MiMatSungNeMT_Khong = DataReader["MiMatSungNeMT_Khong"].ToString().Equals("1") ? true : false;
                    value.MiMatSungNeMT_Co = DataReader["MiMatSungNeMT_Co"].ToString().Equals("1") ? true : false;
                    value.NhanApMP_Khac = DataReader["NhanApMP_Khac"].ToString();
                    value.NhanApMT_Khac = DataReader["NhanApMT_Khac"].ToString();
                    value.KetMacCuongTuMP_Khong = DataReader["KetMacCuongTuMP_Khong"].ToString().Equals("1") ? true : false;
                    value.KetMacCuongTuMP_Co = DataReader["KetMacCuongTuMP_Co"].ToString().Equals("1") ? true : false;
                    value.KetMacCuongTuMT_Khong = DataReader["KetMacCuongTuMT_Khong"].ToString().Equals("1") ? true : false;
                    value.KetMacCuongTuMT_Co = DataReader["KetMacCuongTuMT_Co"].ToString().Equals("1") ? true : false;
                    value.KetMacSeoMoCuMP_Khong = DataReader["KetMacSeoMoCuMP_Khong"].ToString().Equals("1") ? true : false;
                    value.KetMacSeoMoCuMP_Co = DataReader["KetMacSeoMoCuMP_Co"].ToString().Equals("1") ? true : false;
                    value.KetMacSeoMoCuMT_Khong = DataReader["KetMacSeoMoCuMT_Khong"].ToString().Equals("1") ? true : false;
                    value.KetMacSeoMoCuMT_Co = DataReader["KetMacSeoMoCuMT_Co"].ToString().Equals("1") ? true : false;
                    value.KetMacBonDoMP_Tot = DataReader["KetMacBonDoMP_Tot"].ToString().Equals("1") ? true : false;
                    value.KetMacBonDoMP_Dep = DataReader["KetMacBonDoMP_Dep"].ToString().Equals("1") ? true : false;
                    value.KetMacBonDoMP_Xo = DataReader["KetMacBonDoMP_Xo"].ToString().Equals("1") ? true : false;
                    value.KetMacBonDoMP_Mong = DataReader["KetMacBonDoMP_Mong"].ToString().Equals("1") ? true : false;
                    value.KetMacBonDoMP_QuaPhat = DataReader["KetMacBonDoMP_QuaPhat"].ToString().Equals("1") ? true : false;
                    value.KetMacBonDoMT_Tot = DataReader["KetMacBonDoMT_Tot"].ToString().Equals("1") ? true : false;
                    value.KetMacBonDoMT_Dep = DataReader["KetMacBonDoMT_Dep"].ToString().Equals("1") ? true : false;
                    value.KetMacBonDoMT_Xo = DataReader["KetMacBonDoMT_Xo"].ToString().Equals("1") ? true : false;
                    value.KetMacBonDoMT_Mong = DataReader["KetMacBonDoMT_Mong"].ToString().Equals("1") ? true : false;
                    value.KetMacBonDoMT_QuaPhat = DataReader["KetMacBonDoMT_QuaPhat"].ToString().Equals("1") ? true : false;
                    value.GiacMacTrongSuatMP_Trong = DataReader["GiacMacTrongSuatMP_Trong"].ToString().Equals("1") ? true : false;
                    value.GiacMacTrongSuatMP_Seo = DataReader["GiacMacTrongSuatMP_Seo"].ToString().Equals("1") ? true : false;
                    value.GiacMacTrongSuatMP_LoanDuong = DataReader["GiacMacTrongSuatMP_LoanDuong"].ToString().Equals("1") ? true : false;
                    value.GiacMacPhuNeMP_Khong = DataReader["GiacMacPhuNeMP_Khong"].ToString().Equals("1") ? true : false;
                    value.GiacMacPhuNeMP_Co = DataReader["GiacMacPhuNeMP_Co"].ToString().Equals("1") ? true : false;
                    value.GiacMacTrongSuatMT_Trong = DataReader["GiacMacTrongSuatMT_Trong"].ToString().Equals("1") ? true : false;
                    value.GiacMacTrongSuatMT_Seo = DataReader["GiacMacTrongSuatMT_Seo"].ToString().Equals("1") ? true : false;
                    value.GiacMacTrongSuatMT_LoanDuong = DataReader["GiacMacTrongSuatMT_LoanDuong"].ToString().Equals("1") ? true : false;
                    value.GiacMacPhuNeMT_Khong = DataReader["GiacMacPhuNeMT_Khong"].ToString().Equals("1") ? true : false;
                    value.GiacMacPhuNeMT_Co = DataReader["GiacMacPhuNeMT_Co"].ToString().Equals("1") ? true : false;
                    value.GiacMacDoDayGiacMacMP = DataReader["GiacMacDoDayGiacMacMP"].ToString();
                    value.GiacMacDoDayGiacMacMT = DataReader["GiacMacDoDayGiacMacMT"].ToString();
                    value.GiacMacTuMP = DataReader["GiacMacTuMP"].ToString();
                    value.GiacMacTuMT = DataReader["GiacMacTuMT"].ToString();
                    value.GiacMacDuongKinhGiacMacMP = DataReader["GiacMacDuongKinhGiacMacMP"].ToString();
                    value.GiacMacDuongKinhGiacMacMT = DataReader["GiacMacDuongKinhGiacMacMT"].ToString();
                    value.CungMacDanLoiMP_Khong = DataReader["CungMacDanLoiMP_Khong"].ToString().Equals("1") ? true : false;
                    value.CungMacDanLoiMP_Co = DataReader["CungMacDanLoiMP_Co"].ToString().Equals("1") ? true : false;
                    value.CungMacDanLoiMT_Khong = DataReader["CungMacDanLoiMT_Khong"].ToString().Equals("1") ? true : false;
                    value.CungMacDanLoiMT_Co = DataReader["CungMacDanLoiMT_Co"].ToString().Equals("1") ? true : false;
                    value.CungMaSeoMoMP_Khong = DataReader["CungMaSeoMoMP_Khong"].ToString().Equals("1") ? true : false;
                    value.CungMaSeoMoMP_Co = DataReader["CungMaSeoMoMP_Co"].ToString().Equals("1") ? true : false;
                    value.CungMaSeoMoMT_Khong = DataReader["CungMaSeoMoMT_Khong"].ToString().Equals("1") ? true : false;
                    value.CungMaSeoMoMT_Co = DataReader["CungMaSeoMoMT_Co"].ToString().Equals("1") ? true : false;
                    value.TienPhongDoSauMP = DataReader["TienPhongDoSauMP"].ToString();
                    value.TienPhongDoSauMT = DataReader["TienPhongDoSauMT"].ToString();
                    value.GocTienPhongDauHieuKhacMP = DataReader["GocTienPhongDauHieuKhacMP"].ToString();
                    value.GocTienPhongDauHieuKhacMT = DataReader["GocTienPhongDauHieuKhacMT"].ToString();
                    value.MongMatMauSacMP = DataReader["MongMatMauSacMP"].ToString();
                    value.MongMatMauSacMT = DataReader["MongMatMauSacMT"].ToString();
                    value.MongMatThaiHoaMP_Khong = DataReader["MongMatThaiHoaMP_Khong"].ToString().Equals("1") ? true : false;
                    value.MongMatThaiHoaMP_Co = DataReader["MongMatThaiHoaMP_Co"].ToString().Equals("1") ? true : false;
                    value.MongMatThaiHoaMT_Khong = DataReader["MongMatThaiHoaMT_Khong"].ToString().Equals("1") ? true : false;
                    value.MongMatThaiHoaMT_Co = DataReader["MongMatThaiHoaMT_Co"].ToString().Equals("1") ? true : false;
                    value.MongMatTanMachMP_Khong = DataReader["MongMatTanMachMP_Khong"].ToString().Equals("1") ? true : false;
                    value.MongMatTanMachMP_Co = DataReader["MongMatTanMachMP_Co"].ToString().Equals("1") ? true : false;
                    value.MongMatTanMachMT_Khong = DataReader["MongMatTanMachMT_Khong"].ToString().Equals("1") ? true : false;
                    value.MongMatTanMachMT_Co = DataReader["MongMatTanMachMT_Co"].ToString().Equals("1") ? true : false;
                    value.DongTuMP_Tron = DataReader["DongTuMP_Tron"].ToString().Equals("1") ? true : false;
                    value.DongTuMP_Meo = DataReader["DongTuMP_Meo"].ToString().Equals("1") ? true : false;
                    value.DongTuMT_Tron = DataReader["DongTuMT_Tron"].ToString().Equals("1") ? true : false;
                    value.DongTuMT_Meo = DataReader["DongTuMT_Meo"].ToString().Equals("1") ? true : false;
                    value.DongTuDuongKinhMP = DataReader["DongTuDuongKinhMP"].ToString();
                    value.DongTuDuongKinhMT = DataReader["DongTuDuongKinhMT"].ToString();
                    value.DongTuVienSacToMP = DataReader["DongTuVienSacToMP"].ToString();
                    value.DongTuVienSacToMT = DataReader["DongTuVienSacToMT"].ToString();
                    value.DongTuPhanXaMP_BinhThuong = DataReader["DongTuPhanXaMP_BinhThuong"].ToString().Equals("1") ? true : false;
                    value.DongTuPhanXaMP_Giam = DataReader["DongTuPhanXaMP_Giam"].ToString().Equals("1") ? true : false;
                    value.DongTuPhanXaMP_Mat = DataReader["DongTuPhanXaMP_Mat"].ToString().Equals("1") ? true : false;
                    value.DongTuPhanXaMT_BinhThuong = DataReader["DongTuPhanXaMT_BinhThuong"].ToString().Equals("1") ? true : false;
                    value.DongTuPhanXaMT_Giam = DataReader["DongTuPhanXaMT_Giam"].ToString().Equals("1") ? true : false;
                    value.DongTuPhanXaMT_Mat = DataReader["DongTuPhanXaMT_Mat"].ToString().Equals("1") ? true : false;
                    value.TheThuyTinhMP_Trong = DataReader["TheThuyTinhMP_Trong"].ToString().Equals("1") ? true : false;
                    value.TheThuyTinhMP_Duc = DataReader["TheThuyTinhMP_Duc"].ToString().Equals("1") ? true : false;
                    value.TheThuyTinhMT_Trong = DataReader["TheThuyTinhMT_Trong"].ToString().Equals("1") ? true : false;
                    value.TheThuyTinhMT_Duc = DataReader["TheThuyTinhMT_Duc"].ToString().Equals("1") ? true : false;
                    value.DichMP = DataReader["DichMP"].ToString();
                    value.DichMT = DataReader["DichMT"].ToString();
                    value.DayMatVongMacMP = DataReader["DayMatVongMacMP"].ToString();
                    value.DayMatVongMacMT = DataReader["DayMatVongMacMT"].ToString();
                    value.DayMatHoangDiemMP = DataReader["DayMatHoangDiemMP"].ToString();
                    value.DayMatHoangDiemMT = DataReader["DayMatHoangDiemMT"].ToString();
                    value.DayMatTanMachMP_Khong = DataReader["DayMatTanMachMP_Khong"].ToString().Equals("1") ? true : false;
                    value.DayMatTanMachMP_Co = DataReader["DayMatTanMachMP_Co"].ToString().Equals("1") ? true : false;
                    value.DayMatTanMachMT_Khong = DataReader["DayMatTanMachMT_Khong"].ToString().Equals("1") ? true : false;
                    value.DayMatTanMachMT_Co = DataReader["DayMatTanMachMT_Co"].ToString().Equals("1") ? true : false;
                    value.DayMatXuatHuyetMP_Khong = DataReader["DayMatXuatHuyetMP_Khong"].ToString().Equals("1") ? true : false;
                    value.DayMatXuatHuyetMP_Co = DataReader["DayMatXuatHuyetMP_Co"].ToString().Equals("1") ? true : false;
                    value.DayMatXuatHuyetMT_Khong = DataReader["DayMatXuatHuyetMT_Khong"].ToString().Equals("1") ? true : false;
                    value.DayMatXuatHuyetMT_Co = DataReader["DayMatXuatHuyetMT_Co"].ToString().Equals("1") ? true : false;
                    value.DayMatVienThanKinhMP_Khong = DataReader["DayMatVienThanKinhMP_Khong"].ToString().Equals("1") ? true : false;
                    value.DayMatVienThanKinhMP_Co = DataReader["DayMatVienThanKinhMP_Co"].ToString().Equals("1") ? true : false;
                    value.DayMatVienThanKinhMT_Khong = DataReader["DayMatVienThanKinhMT_Khong"].ToString().Equals("1") ? true : false;
                    value.DayMatVienThanKinhMT_Co = DataReader["DayMatVienThanKinhMT_Co"].ToString().Equals("1") ? true : false;
                    value.DiaThiGiaVienThanKinhMP_Duoi = DataReader["DiaThiGiaVienThanKinhMP_Duoi"].ToString().Equals("1") ? true : false;
                    value.DiaThiGiaVienThanKinhMP_Tren = DataReader["DiaThiGiaVienThanKinhMP_Tren"].ToString().Equals("1") ? true : false;
                    value.DiaThiGiaVienThanKinhMP_Mui = DataReader["DiaThiGiaVienThanKinhMP_Mui"].ToString().Equals("1") ? true : false;
                    value.DiaThiGiaVienThanKinhMP_TDuong = DataReader["DiaThiGiaVienThanKinhMP_TDuong"].ToString().Equals("1") ? true : false;
                    value.DiaThiGiaVienThanKinhMT_Duoi = DataReader["DiaThiGiaVienThanKinhMT_Duoi"].ToString().Equals("1") ? true : false;
                    value.DiaThiGiaVienThanKinhMT_Tren = DataReader["DiaThiGiaVienThanKinhMT_Tren"].ToString().Equals("1") ? true : false;
                    value.DiaThiGiaVienThanKinhMT_Mui = DataReader["DiaThiGiaVienThanKinhMT_Mui"].ToString().Equals("1") ? true : false;
                    value.DiaThiGiaVienThanKinhMT_TDuong = DataReader["DiaThiGiaVienThanKinhMT_TDuong"].ToString().Equals("1") ? true : false;
                    value.DiaThiGiacMauSacMP = DataReader["DiaThiGiacMauSacMP"].ToString();
                    value.DiaThiGiacMauSacMT = DataReader["DiaThiGiacMauSacMT"].ToString();
                    value.DiaThiGiacCDMP = DataReader["DiaThiGiacCDMP"].ToString();
                    value.DiaThiGiacCDMT = DataReader["DiaThiGiacCDMT"].ToString();
                    value.DiaThiGiacMachMauMP_BinhThuong = DataReader["DiaThiGiacMachMauMP_BinhThuong"].ToString().Equals("1") ? true : false;
                    value.DiaThiGiacMachMauMP_ChHuong = DataReader["DiaThiGiacMachMauMP_ChHuong"].ToString().Equals("1") ? true : false;
                    value.DiaThiGiacMachMauMP_GapGoc = DataReader["DiaThiGiacMachMauMP_GapGoc"].ToString().Equals("1") ? true : false;
                    value.DiaThiGiacMachMauMT_BinhThuong = DataReader["DiaThiGiacMachMauMT_BinhThuong"].ToString().Equals("1") ? true : false;
                    value.DiaThiGiacMachMauMT_ChHuong = DataReader["DiaThiGiacMachMauMT_ChHuong"].ToString().Equals("1") ? true : false;
                    value.DiaThiGiacMachMauMT_GapGoc = DataReader["DiaThiGiacMachMauMT_GapGoc"].ToString().Equals("1") ? true : false;
                    value.DiaThiGiacXuatHuetMP_Khong = DataReader["DiaThiGiacXuatHuetMP_Khong"].ToString().Equals("1") ? true : false;
                    value.DiaThiGiacXuatHuetMP_Co = DataReader["DiaThiGiacXuatHuetMP_Co"].ToString().Equals("1") ? true : false;
                    value.DiaThiGiacXuatHuetMT_Khong = DataReader["DiaThiGiacXuatHuetMT_Khong"].ToString().Equals("1") ? true : false;
                    value.DiaThiGiacXuatHuetMT_Co = DataReader["DiaThiGiacXuatHuetMT_Co"].ToString().Equals("1") ? true : false;
                    value.DiaThiGiacTeoCanhGaiMP_Khong = DataReader["DiaThiGiacTeoCanhGaiMP_Khong"].ToString().Equals("1") ? true : false;
                    value.DiaThiGiacTeoCanhGaiMP_Co = DataReader["DiaThiGiacTeoCanhGaiMP_Co"].ToString().Equals("1") ? true : false;
                    value.DiaThiGiacTeoCanhGaiMT_Khong = DataReader["DiaThiGiacTeoCanhGaiMT_Khong"].ToString().Equals("1") ? true : false;
                    value.DiaThiGiacTeoCanhGaiMT_Co = DataReader["DiaThiGiacTeoCanhGaiMT_Co"].ToString().Equals("1") ? true : false;
                    value.VanNhanMP = DataReader["VanNhanMP"].ToString();
                    value.VanNhanMT = DataReader["VanNhanMT"].ToString();
                    value.NhanCauMP_BinhThuong = DataReader["NhanCauMP_BinhThuong"].ToString().Equals("1") ? true : false;
                    value.NhanCauMP_DanNoi = DataReader["NhanCauMP_DanNoi"].ToString().Equals("1") ? true : false;
                    value.NhanCauMP_To = DataReader["NhanCauMP_To"].ToString().Equals("1") ? true : false;
                    value.NhanCauMP_Nho = DataReader["NhanCauMP_Nho"].ToString().Equals("1") ? true : false;
                    value.NhanCauMT_BinhThuong = DataReader["NhanCauMT_BinhThuong"].ToString().Equals("1") ? true : false;
                    value.NhanCauMT_DanNoi = DataReader["NhanCauMT_DanNoi"].ToString().Equals("1") ? true : false;
                    value.NhanCauMT_To = DataReader["NhanCauMT_To"].ToString().Equals("1") ? true : false;
                    value.NhanCauMT_Nho = DataReader["NhanCauMT_Nho"].ToString().Equals("1") ? true : false;
                    value.HocMatMP = DataReader["HocMatMP"].ToString();
                    value.HocMatMT = DataReader["HocMatMT"].ToString();
                    value.ToanThanHuyetAp = DataReader["ToanThanHuyetAp"].ToString();
                    value.ToanThanNhietDo = DataReader["ToanThanNhietDo"].ToString();
                    value.ToanThanMach = DataReader["ToanThanMach"].ToString();
                    value.NoiTiet_BinhThuong = DataReader["NoiTiet_BinhThuong"].ToString().Equals("1") ? true : false;
                    value.NoiTiet_CoBenh = DataReader["NoiTiet_CoBenh"].ToString().Equals("1") ? true : false;
                    value.ThanKinh_BinhThuong = DataReader["ThanKinh_BinhThuong"].ToString().Equals("1") ? true : false;
                    value.ThanKinh_CoBenh = DataReader["ThanKinh_CoBenh"].ToString().Equals("1") ? true : false;
                    value.TuanHoan_BinhThuong = DataReader["TuanHoan_BinhThuong"].ToString().Equals("1") ? true : false;
                    value.TuanHoan_CoBenh = DataReader["TuanHoan_CoBenh"].ToString().Equals("1") ? true : false;
                    value.HoHap_BinhThuong = DataReader["HoHap_BinhThuong"].ToString().Equals("1") ? true : false;
                    value.HoHap_CoBenh = DataReader["HoHap_CoBenh"].ToString().Equals("1") ? true : false;
                    value.TieuHoa_BinhThuong = DataReader["TieuHoa_BinhThuong"].ToString().Equals("1") ? true : false;
                    value.TieuHoa_CoBenh = DataReader["TieuHoa_CoBenh"].ToString().Equals("1") ? true : false;
                    value.CoXuongKhop_BinhThuong = DataReader["CoXuongKhop_BinhThuong"].ToString().Equals("1") ? true : false;
                    value.CoXuongKhop_CoBenh = DataReader["CoXuongKhop_CoBenh"].ToString().Equals("1") ? true : false;
                    value.TietNieuSinhDuc_BinhThuong = DataReader["TietNieuSinhDuc_BinhThuong"].ToString().Equals("1") ? true : false;
                    value.TietNieuSinhDuc_CoBenh = DataReader["TietNieuSinhDuc_CoBenh"].ToString().Equals("1") ? true : false;
                    value.BenhChinhMP = DataReader["BenhChinhMP"].ToString();
                    value.BenhChinhMT = DataReader["BenhChinhMT"].ToString();
                    value.BenhKemTheoMP = DataReader["BenhKemTheoMP"].ToString();
                    value.BenhKemTheoMT = DataReader["BenhKemTheoMT"].ToString();
                    value.BenhToanThan = DataReader["BenhToanThan"].ToString();
                    value.ChiDinhDieuTri = DataReader["ChiDinhDieuTri"].ToString();
                    value.TienSuKhac_Cor = DataReader["TienSuKhac_Cor"].ToString().Equals("1") ? true : false;
                    value.TienSuKhac_DaPTMat_Text = DataReader["TienSuKhac_DaPTMat_Text"].ToString();
                    value.TienSuBenhToanThan_BenhKhac = DataReader["TienSuBenhToanThan_BenhKhac"].ToString();
                    value.KetMacSeoMoCuMP = DataReader["KetMacSeoMoCuMP"].ToString();
                    value.KetMacSeoMoCuMT = DataReader["KetMacSeoMoCuMT"].ToString();
                    value.GiacMacPhuNeMP = DataReader["GiacMacPhuNeMP"].ToString();
                    value.GiacMacPhuNeMT = DataReader["GiacMacPhuNeMT"].ToString();
                    value.MongMatThaiHoaMP = DataReader["MongMatThaiHoaMP"].ToString();
                    value.MongMatThaiHoaMT = DataReader["MongMatThaiHoaMT"].ToString();
                    value.NoiTiet = DataReader["NoiTiet"].ToString();
                    value.CungMaSeoMoMP = DataReader["CungMaSeoMoMP"].ToString();
                    value.CungMaSeoMoMT = DataReader["CungMaSeoMoMT"].ToString();
                    value.TheThuyTinhMP_Nhan = DataReader["TheThuyTinhMP_Nhan"].ToString().Equals("1") ? true : false;
                    value.TheThuyTinhMP_Vo = DataReader["TheThuyTinhMP_Vo"].ToString().Equals("1") ? true : false;
                    value.TheThuyTinhMP_DuoiBao = DataReader["TheThuyTinhMP_DuoiBao"].ToString().Equals("1") ? true : false;
                    value.TheThuyTinhMP_ToanBo = DataReader["TheThuyTinhMP_ToanBo"].ToString().Equals("1") ? true : false;
                    value.TheThuyTinhMT_Nhan = DataReader["TheThuyTinhMT_Nhan"].ToString().Equals("1") ? true : false;
                    value.TheThuyTinhMT_Vo = DataReader["TheThuyTinhMT_Vo"].ToString().Equals("1") ? true : false;
                    value.TheThuyTinhMT_DuoiBao = DataReader["TheThuyTinhMT_DuoiBao"].ToString().Equals("1") ? true : false;
                    value.TheThuyTinhMT_ToanBo = DataReader["TheThuyTinhMT_ToanBo"].ToString().Equals("1") ? true : false;
                    value.TienSuKhac_BenhKhac_Text = DataReader["TienSuKhac_BenhKhac_Text"].ToString();
                    value.ChanDoanRaVien_MatPhai = DataReader["ChanDoanRaVien_MatPhai"].ToString();
                    value.MaChanDoanRaVien_MatPhai = DataReader["MaChanDoanRaVien_MatPhai"].ToString();
                    value.ChanDoanRaVien_MatTrai = DataReader["ChanDoanRaVien_MatTrai"].ToString();
                    value.MaChanDoanRaVien_MatTrai = DataReader["MaChanDoanRaVien_MatTrai"].ToString();
                    value.PPDT_PhauThuat = DataReader["PPDT_PhauThuat"].ToString().Equals("1") ? true : false;
                    value.PPDT_PhauThuatText = DataReader["PPDT_PhauThuatText"].ToString();
                    value.PPDT_Thuoc = DataReader["PPDT_Thuoc"].ToString().Equals("1") ? true : false;
                    value.PPDT_ThuocText = DataReader["PPDT_ThuocText"].ToString();
                    value.PPDT_Laser = DataReader["PPDT_Laser"].ToString().Equals("1") ? true : false;
                    value.PPDT_LaserText = DataReader["PPDT_LaserText"].ToString();
                    value.TinhTrangRaVien_MatPhai = DataReader["TinhTrangRaVien_MatPhai"].ToString();
                    value.TinhTrangRaVien_MatTrai = DataReader["TinhTrangRaVien_MatTrai"].ToString();
                    value.RaVienMP_KhongKinh = DataReader["RaVienMP_KhongKinh"].ToString();
                    value.RaVienMT_KhongKinh = DataReader["RaVienMT_KhongKinh"].ToString();
                    value.RaVienMP_CoKinh = DataReader["RaVienMP_CoKinh"].ToString();
                    value.RaVienMT_CoKinh = DataReader["RaVienMT_CoKinh"].ToString();
                    value.RaVienNhanApMP = DataReader["RaVienNhanApMP"].ToString();
                    value.RaVienNhanApMT = DataReader["RaVienNhanApMT"].ToString();
                    value.HuongDieuTri_TheoDoi = DataReader["HuongDieuTri_TheoDoi"].ToString().Equals("1") ? true : false;
                    value.HuongDieuTri_TheoDoiText = DataReader["HuongDieuTri_TheoDoiText"].ToString();
                    value.HuongDieuTri_PhauThuat = DataReader["HuongDieuTri_PhauThuat"].ToString().Equals("1") ? true : false;
                    value.HuongDieuTri_PhauThuatText = DataReader["HuongDieuTri_PhauThuatText"].ToString();
                    value.HuongDieuTri_Laser = DataReader["HuongDieuTri_Laser"].ToString().Equals("1") ? true : false;
                    value.HuongDieuTri_LaserText = DataReader["HuongDieuTri_LaserText"].ToString();
                    value.HuongDieuTri_Thuoc = DataReader["HuongDieuTri_Thuoc"].ToString().Equals("1") ? true : false;
                    value.HuongDieuTri_ThuocText = DataReader["HuongDieuTri_ThuocText"].ToString();
                    value.MaSoKyTen = DataReader["masokyten"].ToString();
                    value.MaSoKyTen_KB = DataReader["masokyten_kb"].ToString();
                    value.MaSoKyTen_TK = DataReader["masokyten_tk"].ToString();

                    value.ChuaThayBenhLy = DataReader["ChuaThayBenhLy"].ToString().Equals("1") ? true : false;
                    value.BenhLy = DataReader["BenhLy"].ToString().Equals("1") ? true : false;
                    value.BenhLy_Text = DataReader["BenhLy_Text"].ToString();
                    value.PhauThuat = DataReader["PhauThuat"].ToString() == "1" ? true : false;
                    value.ThuThuat = DataReader["ThuThuat"].ToString() == "1" ? true : false;
                    value.ThiLucKhiRaVien_KhongKinh_MP = DataReader["ThiLucKhiRaVien_KhongKinh_MP"].ToString();
                    value.ThiLucKhiRaVien_KhongKinh_MT = DataReader["ThiLucKhiRaVien_KhongKinh_MT"].ToString();
                    value.ThiLucKhiRaVien_CoKinh_MP = DataReader["ThiLucKhiRaVien_CoKinh_MP"].ToString();
                    value.ThiLucKhiRaVien_CoKinh_MT = DataReader["ThiLucKhiRaVien_CoKinh_MT"].ToString();
                    value.NhanApRaVien_MP = DataReader["NhanApRaVien_MP"].ToString();
                    value.NhanApRaVien_MT = DataReader["NhanApRaVien_MT"].ToString();
                    int tempInt = 0;
                    value.NoiTietCheck = int.TryParse(DataReader["NoiTietCheck"].ToString(), out tempInt) ? tempInt : 0;
                    value.NoiTiet_Text = DataReader["NoiTiet_Text"].ToString();

                    tempInt = 0;
                    value.ThanKinhCheck = int.TryParse(DataReader["ThanKinhCheck"].ToString(), out tempInt) ? tempInt : 0;
                    value.ThanKinh_Text = DataReader["ThanKinh_Text"].ToString();

                    tempInt = 0;
                    value.TuanHoanCheck = int.TryParse(DataReader["TuanHoanCheck"].ToString(), out tempInt) ? tempInt : 0;
                    value.TuanHoan_Text = DataReader["TuanHoan_Text"].ToString();

                    tempInt = 0;
                    value.HoHapCheck = int.TryParse(DataReader["HoHapCheck"].ToString(), out tempInt) ? tempInt : 0;
                    value.HoHap_Text = DataReader["HoHap_Text"].ToString();

                    tempInt = 0;
                    value.TieuHoaCheck = int.TryParse(DataReader["TieuHoaCheck"].ToString(), out tempInt) ? tempInt : 0;
                    value.TieuHoa_Text = DataReader["TieuHoa_Text"].ToString();

                    tempInt = 0;
                    value.CoXuongKhopCheck = int.TryParse(DataReader["CoXuongKhopCheck"].ToString(), out tempInt) ? tempInt : 0;
                    value.CoXuongKhop_Text = DataReader["CoXuongKhop_Text"].ToString();

                    tempInt = 0;
                    value.TietNieuSinhDucCheck = int.TryParse(DataReader["TietNieuSinhDucCheck"].ToString(), out tempInt) ? tempInt : 0;
                    value.TietNieuSinhDuc_Text = DataReader["TietNieuSinhDuc_Text"].ToString();

                    value.KhamBenhToanThan_Khac = DataReader["KhamBenhToanThan_Khac"].ToString();
                    value.ChanDoanRaVien = DataReader["KhamBenhToanThan_Khac"].ToString();
                }
                return value;
            }
            catch (Exception ex) {
                ex.LogError();
            }
            return null;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, BenhAnMatGlocom BenhAnMatGlocom)
        {
            string sql = @"select MaQuanLy from BenhAnMatGlocom where MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnMatGlocom.MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            int rowCount = 0;
            while (DataReader.Read()) rowCount++;
            if (rowCount == 1)
                sql = @"UPDATE BenhAnMatGlocom SET LYDOVAOVIEN = :LYDOVAOVIEN,
  VAONGAYTHU = :VAONGAYTHU,
  QUATRINHBENHLY = :QUATRINHBENHLY,
  TIENSUBENHBANTHAN = :TIENSUBENHBANTHAN,
  TIENSUBENHGIADINH = :TIENSUBENHGIADINH,
  MACH = :MACH,
  NHIETDO = :NHIETDO,
  HUYETAP = :HUYETAP,
  NHIPTHO = :NHIPTHO,
  CANNANG = :CANNANG,
  CHIEUCAO = :CHIEUCAO,
  TOANTHAN = :TOANTHAN,
  TUANHOAN = :TUANHOAN,
  HOHAP = :HOHAP,
  TIEUHOA = :TIEUHOA,
  THANTIETNIEUSINHDUC = :THANTIETNIEUSINHDUC,
  THANKINH = :THANKINH,
  COXUONGKHOP = :COXUONGKHOP,
  TAIMUIHONG = :TAIMUIHONG,
  RANGHAMMAT = :RANGHAMMAT,
  MAT = :MAT,
  KHAC_CACCOQUAN = :KHAC_CACCOQUAN,
  CACXETNGHIEMCANLAMSANGCANLAM = :CACXETNGHIEMCANLAMSANGCANLAM,
  TOMTATBENHAN = :TOMTATBENHAN,
  BENHCHINH = :BENHCHINH,
  BENHKEMTHEO = :BENHKEMTHEO,
  PHANBIET = :PHANBIET,
  TIENLUONG = :TIENLUONG,
  HUONGDIEUTRI = :HUONGDIEUTRI,
  NGAYKHAMBENH = :NGAYKHAMBENH,
  BACSYLAMBENHAN = :BACSYLAMBENHAN,
  XQUANG = :XQUANG,
  CTSCANNER = :CTSCANNER,
  SIEUAM = :SIEUAM,
  XETNGHIEM = :XETNGHIEM,
  KHAC = :KHAC,
  KHAC_TEXT = :KHAC_TEXT,
  TOANBOHOSO = :TOANBOHOSO,
  QUATRINHBENHLYVADIENBIEN = :QUATRINHBENHLYVADIENBIEN,
  TOMTATKETQUAXETNGHIEM = :TOMTATKETQUAXETNGHIEM,
  PHUONGPHAPDIEUTRI = :PHUONGPHAPDIEUTRI,
  TINHTRANGNGUOIBENHRAVIEN = :TINHTRANGNGUOIBENHRAVIEN,
  HUONGDIEUTRIVACACCHEDOTIEPTHEO = :HUONGDIEUTRIVACACCHEDOTIEPTHEO,
  NGUOINHANHOSO = :NGUOINHANHOSO,
  NGUOIGIAOHOSO = :NGUOIGIAOHOSO,
  NGAYTONGKET = :NGAYTONGKET,
  BACSYDIEUTRI = :BACSYDIEUTRI,
  DIUNG = :DIUNG,
  DIUNG_TEXT = :DIUNG_TEXT,
  MATUY = :MATUY,
  MATUY_TEXT = :MATUY_TEXT,
  RUOUBIA = :RUOUBIA,
  RUOUBIA_TEXT = :RUOUBIA_TEXT,
  THUOCLA = :THUOCLA,
  THUOCLA_TEXT = :THUOCLA_TEXT,
  THUOCLAO = :THUOCLAO,
  THUOCLAO_TEXT = :THUOCLAO_TEXT,
  KHAC_DACDIEMLIENQUANBENH = :KHAC_DACDIEMLIENQUANBENH,
  KHAC_DACDIEMLIENQUANBENH_TEXT = :KHAC_DACDIEMLIENQUANBENH_TEXT,
  LYDODIKHAM_MP = :LYDODIKHAM_MP,
  LYDODIKHAM_MT = :LYDODIKHAM_MT,
  LYDODIKHAM_2MAT = :LYDODIKHAM_2MAT,
  NHUCMAT_DUDOI = :NHUCMAT_DUDOI,
  NHUCMAT_VUA = :NHUCMAT_VUA,
  NHUCMAT_NHE = :NHUCMAT_NHE,
  NHUCMAT_KHONG = :NHUCMAT_KHONG,
  NHIN_MODOTNGOT = :NHIN_MODOTNGOT,
  NHIN_MOTUNGLUC = :NHIN_MOTUNGLUC,
  NHIN_SUONGMU = :NHIN_SUONGMU,
  NHIN_KHONGMO = :NHIN_KHONGMO,
  NHIN_MOTANGDAN = :NHIN_MOTANGDAN,
  NHIN_NHINTHUHEP = :NHIN_NHINTHUHEP,
  NHIN_QUANTANSAC = :NHIN_QUANTANSAC,
  SOANHSANGCHAYNUOCMAT_CO = :SOANHSANGCHAYNUOCMAT_CO,
  SOANHSANGCHAYNUOCMAT_KHONG = :SOANHSANGCHAYNUOCMAT_KHONG,
  DOMAT_CO = :DOMAT_CO,
  DOMAT_KHONG = :DOMAT_KHONG,
  TOANTHAN_DAUDAU = :TOANTHAN_DAUDAU,
  TOANTHAN_NON = :TOANTHAN_NON,
  TOANTHAN_BUONNON = :TOANTHAN_BUONNON,
  TOANTHAN_KHONG = :TOANTHAN_KHONG,
  CACTRIEUCHUNGKHAC = :CACTRIEUCHUNGKHAC,
  THOIGIANXUATHIENBENH = :THOIGIANXUATHIENBENH,
  DAKHAMCHUABENH_HUYEN = :DAKHAMCHUABENH_HUYEN,
  DAKHAMCHUABENH_TINH = :DAKHAMCHUABENH_TINH,
  DAKHAMCHUABENH_TRUNGUONG = :DAKHAMCHUABENH_TRUNGUONG,
  DAKHAMCHUABENH_KHAC = :DAKHAMCHUABENH_KHAC,
  PHUONGPHAPDIEUTRI_PHAUTHUAT = :PHUONGPHAPDIEUTRI_PHAUTHUAT,
  PHUONGPHAPDIEUTRI_THUOC = :PHUONGPHAPDIEUTRI_THUOC,
  PHUONGPHAPDIEUTRI_LASER = :PHUONGPHAPDIEUTRI_LASER,
  PTTTMP_LOAI1 = :PTTTMP_LOAI1,
  PTTTMP_LOAI2 = :PTTTMP_LOAI2,
  PTTTMP_LOAI3 = :PTTTMP_LOAI3,
  PTTTMP_LOAI4 = :PTTTMP_LOAI4,
  PTTTMT_LOAI1 = :PTTTMT_LOAI1,
  PTTTMT_LOAI2 = :PTTTMT_LOAI2,
  PTTTMT_LOAI3 = :PTTTMT_LOAI3,
  PTTTMT_LOAI4 = :PTTTMT_LOAI4,
  PTTTMP_THOIDIEM1 = :PTTTMP_THOIDIEM1,
  PTTTMP_THOIDIEM2 = :PTTTMP_THOIDIEM2,
  PTTTMP_THOIDIEM3 = :PTTTMP_THOIDIEM3,
  PTTTMP_THOIDIEM4 = :PTTTMP_THOIDIEM4,
  PTTTMT_THOIDIEM1 = :PTTTMT_THOIDIEM1,
  PTTTMT_THOIDIEM2 = :PTTTMT_THOIDIEM2,
  PTTTMT_THOIDIEM3 = :PTTTMT_THOIDIEM3,
  PTTTMT_THOIDIEM4 = :PTTTMT_THOIDIEM4,
  PTTTMP_NOI1 = :PTTTMP_NOI1,
  PTTTMP_NOI2 = :PTTTMP_NOI2,
  PTTTMP_NOI3 = :PTTTMP_NOI3,
  PTTTMP_NOI4 = :PTTTMP_NOI4,
  PTTTMT_NOI1 = :PTTTMT_NOI1,
  PTTTMT_NOI2 = :PTTTMT_NOI2,
  PTTTMT_NOI3 = :PTTTMT_NOI3,
  PTTTMT_NOI4 = :PTTTMT_NOI4,
  THUOCHANHANAP_UONG = :THUOCHANHANAP_UONG,
  THUOCHANHANAP_TRAMAT = :THUOCHANHANAP_TRAMAT,
  THUOCHANHANAP_TIEM = :THUOCHANHANAP_TIEM,
  THUOCHANHANAP_1THUOC = :THUOCHANHANAP_1THUOC,
  THUOCHANHANAP_2THUOC = :THUOCHANHANAP_2THUOC,
  THUOCHANHANAP_3THUOC = :THUOCHANHANAP_3THUOC,
  THUOCHANHANAP_4THUOC = :THUOCHANHANAP_4THUOC,
  THUOCHANHANAPDADUNG = :THUOCHANHANAPDADUNG,
  CACTHUOCKHAC = :CACTHUOCKHAC,
  TIENTRINHDIEUTRI = :TIENTRINHDIEUTRI,
  TIENSUKHAC_CANTHI = :TIENSUKHAC_CANTHI,
  TIENSUKHAC_VIENTHI = :TIENSUKHAC_VIENTHI,
  TIENSUKHAC_TRANTHUONG = :TIENSUKHAC_TRANTHUONG,
  TIENSUKHAC_VIENMANGBODAO = :TIENSUKHAC_VIENMANGBODAO,
  TIENSUKHAC_VIENPHANTRUOCNHACAU = :TIENSUKHAC_VIENPHANTRUOCNHACAU,
  TIENSUKHAC_TACTMTTVM = :TIENSUKHAC_TACTMTTVM,
  TIENSUKHAC_DAPTMAT = :TIENSUKHAC_DAPTMAT,
  TIENSUKHAC_BENHKHAC = :TIENSUKHAC_BENHKHAC,
  TIENSUKHAC_CORTICOSTEROID = :TIENSUKHAC_CORTICOSTEROID,
  THOIGIANSUDUNG_CORTICOSTEROID = :THOIGIANSUDUNG_CORTICOSTEROID,
  CORTICOSTEROID_TRAMAT = :CORTICOSTEROID_TRAMAT,
  CORTICOSTEROID_TIEMMAT = :CORTICOSTEROID_TIEMMAT,
  CORTICOSTEROID_TOANTHAN = :CORTICOSTEROID_TOANTHAN,
  CORTICOSTEROID_THEOCDCUABACSI = :CORTICOSTEROID_THEOCDCUABACSI,
  CORTICOSTEROID_BNTUDUNGTHUOC = :CORTICOSTEROID_BNTUDUNGTHUOC,
  TIENSUTOANTHAN_TIMMACH = :TIENSUTOANTHAN_TIMMACH,
  TIENSUTOANTHAN_HUYETAP = :TIENSUTOANTHAN_HUYETAP,
  TIENSUTOANTHAN_DAIDUONG = :TIENSUTOANTHAN_DAIDUONG,
  TIENSUTOANTHAN_RODONGMACHCANH = :TIENSUTOANTHAN_RODONGMACHCANH,
  TIENSUTOANTHAN_BENHKHAC = :TIENSUTOANTHAN_BENHKHAC,
  TIENSUGLOCOMGIADINH_ONGBA = :TIENSUGLOCOMGIADINH_ONGBA,
  TIENSUGLOCOMGIADINH_BOME = :TIENSUGLOCOMGIADINH_BOME,
  TIENSUGLOCOMGIADINH_ANHCHIEM = :TIENSUGLOCOMGIADINH_ANHCHIEM,
  TIENSUGLOCOMGIADINH_CODICHUBAC = :TIENSUGLOCOMGIADINH_CODICHUBAC,
  THILUCVAOVIENMP_KHONGKINH = :THILUCVAOVIENMP_KHONGKINH,
  THILUCVAOVIENMT_KHONGKINH = :THILUCVAOVIENMT_KHONGKINH,
  THILUCVAOVIENMP_COKINH = :THILUCVAOVIENMP_COKINH,
  THILUCVAOVIENMT_COKINH = :THILUCVAOVIENMT_COKINH,
  NHAAPMP = :NHAAPMP,
  NHAAPMT = :NHAAPMT,
  MIMATSUNGNEMP_KHONG = :MIMATSUNGNEMP_KHONG,
  MIMATSUNGNEMP_CO = :MIMATSUNGNEMP_CO,
  MIMATSUNGNEMT_KHONG = :MIMATSUNGNEMT_KHONG,
  MIMATSUNGNEMT_CO = :MIMATSUNGNEMT_CO,
  NHANAPMP_KHAC = :NHANAPMP_KHAC,
  NHANAPMT_KHAC = :NHANAPMT_KHAC,
  KETMACCUONGTUMP_KHONG = :KETMACCUONGTUMP_KHONG,
  KETMACCUONGTUMP_CO = :KETMACCUONGTUMP_CO,
  KETMACCUONGTUMT_KHONG = :KETMACCUONGTUMT_KHONG,
  KETMACCUONGTUMT_CO = :KETMACCUONGTUMT_CO,
  KETMACSEOMOCUMP_KHONG = :KETMACSEOMOCUMP_KHONG,
  KETMACSEOMOCUMP_CO = :KETMACSEOMOCUMP_CO,
  KETMACSEOMOCUMT_KHONG = :KETMACSEOMOCUMT_KHONG,
  KETMACSEOMOCUMT_CO = :KETMACSEOMOCUMT_CO,
  KETMACBONDOMP_TOT = :KETMACBONDOMP_TOT,
  KETMACBONDOMP_DEP = :KETMACBONDOMP_DEP,
  KETMACBONDOMP_XO = :KETMACBONDOMP_XO,
  KETMACBONDOMP_MONG = :KETMACBONDOMP_MONG,
  KETMACBONDOMP_QUAPHAT = :KETMACBONDOMP_QUAPHAT,
  KETMACBONDOMT_TOT = :KETMACBONDOMT_TOT,
  KETMACBONDOMT_DEP = :KETMACBONDOMT_DEP,
  KETMACBONDOMT_XO = :KETMACBONDOMT_XO,
  KETMACBONDOMT_MONG = :KETMACBONDOMT_MONG,
  KETMACBONDOMT_QUAPHAT = :KETMACBONDOMT_QUAPHAT,
  GIACMACTRONGSUATMP_TRONG = :GIACMACTRONGSUATMP_TRONG,
  GIACMACTRONGSUATMP_SEO = :GIACMACTRONGSUATMP_SEO,
  GIACMACTRONGSUATMP_LOANDUONG = :GIACMACTRONGSUATMP_LOANDUONG,
  GIACMACPHUNEMP_KHONG = :GIACMACPHUNEMP_KHONG,
  GIACMACPHUNEMP_CO = :GIACMACPHUNEMP_CO,
  GIACMACTRONGSUATMT_TRONG = :GIACMACTRONGSUATMT_TRONG,
  GIACMACTRONGSUATMT_SEO = :GIACMACTRONGSUATMT_SEO,
  GIACMACTRONGSUATMT_LOANDUONG = :GIACMACTRONGSUATMT_LOANDUONG,
  GIACMACPHUNEMT_KHONG = :GIACMACPHUNEMT_KHONG,
  GIACMACPHUNEMT_CO = :GIACMACPHUNEMT_CO,
  GIACMACDODAYGIACMACMP = :GIACMACDODAYGIACMACMP,
  GIACMACDODAYGIACMACMT = :GIACMACDODAYGIACMACMT,
  GIACMACTUMP = :GIACMACTUMP,
  GIACMACTUMT = :GIACMACTUMT,
  GIACMACDUONGKINHGIACMACMP = :GIACMACDUONGKINHGIACMACMP,
  GIACMACDUONGKINHGIACMACMT = :GIACMACDUONGKINHGIACMACMT,
  CUNGMACDANLOIMP_KHONG = :CUNGMACDANLOIMP_KHONG,
  CUNGMACDANLOIMP_CO = :CUNGMACDANLOIMP_CO,
  CUNGMACDANLOIMT_KHONG = :CUNGMACDANLOIMT_KHONG,
  CUNGMACDANLOIMT_CO = :CUNGMACDANLOIMT_CO,
  CUNGMASEOMOMP_KHONG = :CUNGMASEOMOMP_KHONG,
  CUNGMASEOMOMP_CO = :CUNGMASEOMOMP_CO,
  CUNGMASEOMOMT_KHONG = :CUNGMASEOMOMT_KHONG,
  CUNGMASEOMOMT_CO = :CUNGMASEOMOMT_CO,
  TIENPHONGDOSAUMP = :TIENPHONGDOSAUMP,
  TIENPHONGDOSAUMT = :TIENPHONGDOSAUMT,
  GOCTIENPHONGDAUHIEUKHACMP = :GOCTIENPHONGDAUHIEUKHACMP,
  GOCTIENPHONGDAUHIEUKHACMT = :GOCTIENPHONGDAUHIEUKHACMT,
  MONGMATMAUSACMP = :MONGMATMAUSACMP,
  MONGMATMAUSACMT = :MONGMATMAUSACMT,
  MONGMATTHAIHOAMP_KHONG = :MONGMATTHAIHOAMP_KHONG,
  MONGMATTHAIHOAMP_CO = :MONGMATTHAIHOAMP_CO,
  MONGMATTHAIHOAMT_KHONG = :MONGMATTHAIHOAMT_KHONG,
  MONGMATTHAIHOAMT_CO = :MONGMATTHAIHOAMT_CO,
  MONGMATTANMACHMP_KHONG = :MONGMATTANMACHMP_KHONG,
  MONGMATTANMACHMP_CO = :MONGMATTANMACHMP_CO,
  MONGMATTANMACHMT_KHONG = :MONGMATTANMACHMT_KHONG,
  MONGMATTANMACHMT_CO = :MONGMATTANMACHMT_CO,
  DONGTUMP_TRON = :DONGTUMP_TRON,
  DONGTUMP_MEO = :DONGTUMP_MEO,
  DONGTUMT_TRON = :DONGTUMT_TRON,
  DONGTUMT_MEO = :DONGTUMT_MEO,
  DONGTUDUONGKINHMP = :DONGTUDUONGKINHMP,
  DONGTUDUONGKINHMT = :DONGTUDUONGKINHMT,
  DONGTUVIENSACTOMP = :DONGTUVIENSACTOMP,
  DONGTUVIENSACTOMT = :DONGTUVIENSACTOMT,
  DONGTUPHANXAMP_BINHTHUONG = :DONGTUPHANXAMP_BINHTHUONG,
  DONGTUPHANXAMP_GIAM = :DONGTUPHANXAMP_GIAM,
  DONGTUPHANXAMP_MAT = :DONGTUPHANXAMP_MAT,
  DONGTUPHANXAMT_BINHTHUONG = :DONGTUPHANXAMT_BINHTHUONG,
  DONGTUPHANXAMT_GIAM = :DONGTUPHANXAMT_GIAM,
  DONGTUPHANXAMT_MAT = :DONGTUPHANXAMT_MAT,
  THETHUYTINHMP_TRONG = :THETHUYTINHMP_TRONG,
  THETHUYTINHMP_DUC = :THETHUYTINHMP_DUC,
  THETHUYTINHMT_TRONG = :THETHUYTINHMT_TRONG,
  THETHUYTINHMT_DUC = :THETHUYTINHMT_DUC,
  DICHMP = :DICHMP,
  DICHMT = :DICHMT,
  DAYMATVONGMACMP = :DAYMATVONGMACMP,
  DAYMATVONGMACMT = :DAYMATVONGMACMT,
  DAYMATHOANGDIEMMP = :DAYMATHOANGDIEMMP,
  DAYMATHOANGDIEMMT = :DAYMATHOANGDIEMMT,
  DAYMATTANMACHMP_KHONG = :DAYMATTANMACHMP_KHONG,
  DAYMATTANMACHMP_CO = :DAYMATTANMACHMP_CO,
  DAYMATTANMACHMT_KHONG = :DAYMATTANMACHMT_KHONG,
  DAYMATTANMACHMT_CO = :DAYMATTANMACHMT_CO,
  DAYMATXUATHUYETMP_KHONG = :DAYMATXUATHUYETMP_KHONG,
  DAYMATXUATHUYETMP_CO = :DAYMATXUATHUYETMP_CO,
  DAYMATXUATHUYETMT_KHONG = :DAYMATXUATHUYETMT_KHONG,
  DAYMATXUATHUYETMT_CO = :DAYMATXUATHUYETMT_CO,
  DAYMATVIENTHANKINHMP_KHONG = :DAYMATVIENTHANKINHMP_KHONG,
  DAYMATVIENTHANKINHMP_CO = :DAYMATVIENTHANKINHMP_CO,
  DAYMATVIENTHANKINHMT_KHONG = :DAYMATVIENTHANKINHMT_KHONG,
  DAYMATVIENTHANKINHMT_CO = :DAYMATVIENTHANKINHMT_CO,
  DIATHIGIAVIENTHANKINHMP_DUOI = :DIATHIGIAVIENTHANKINHMP_DUOI,
  DIATHIGIAVIENTHANKINHMP_TREN = :DIATHIGIAVIENTHANKINHMP_TREN,
  DIATHIGIAVIENTHANKINHMP_MUI = :DIATHIGIAVIENTHANKINHMP_MUI,
  DIATHIGIAVIENTHANKINHMP_TDUONG = :DIATHIGIAVIENTHANKINHMP_TDUONG,
  DIATHIGIAVIENTHANKINHMT_DUOI = :DIATHIGIAVIENTHANKINHMT_DUOI,
  DIATHIGIAVIENTHANKINHMT_TREN = :DIATHIGIAVIENTHANKINHMT_TREN,
  DIATHIGIAVIENTHANKINHMT_MUI = :DIATHIGIAVIENTHANKINHMT_MUI,
  DIATHIGIAVIENTHANKINHMT_TDUONG = :DIATHIGIAVIENTHANKINHMT_TDUONG,
  DIATHIGIACMAUSACMP = :DIATHIGIACMAUSACMP,
  DIATHIGIACMAUSACMT = :DIATHIGIACMAUSACMT,
  DIATHIGIACCDMP = :DIATHIGIACCDMP,
  DIATHIGIACCDMT = :DIATHIGIACCDMT,
  DIATHIGIACMACHMAUMP_BINHTHUONG = :DIATHIGIACMACHMAUMP_BINHTHUONG,
  DIATHIGIACMACHMAUMP_CHHUONG = :DIATHIGIACMACHMAUMP_CHHUONG,
  DIATHIGIACMACHMAUMP_GAPGOC = :DIATHIGIACMACHMAUMP_GAPGOC,
  DIATHIGIACMACHMAUMT_BINHTHUONG = :DIATHIGIACMACHMAUMT_BINHTHUONG,
  DIATHIGIACMACHMAUMT_CHHUONG = :DIATHIGIACMACHMAUMT_CHHUONG,
  DIATHIGIACMACHMAUMT_GAPGOC = :DIATHIGIACMACHMAUMT_GAPGOC,
  DIATHIGIACXUATHUETMP_KHONG = :DIATHIGIACXUATHUETMP_KHONG,
  DIATHIGIACXUATHUETMP_CO = :DIATHIGIACXUATHUETMP_CO,
  DIATHIGIACXUATHUETMT_KHONG = :DIATHIGIACXUATHUETMT_KHONG,
  DIATHIGIACXUATHUETMT_CO = :DIATHIGIACXUATHUETMT_CO,
  DIATHIGIACTEOCANHGAIMP_KHONG = :DIATHIGIACTEOCANHGAIMP_KHONG,
  DIATHIGIACTEOCANHGAIMP_CO = :DIATHIGIACTEOCANHGAIMP_CO,
  DIATHIGIACTEOCANHGAIMT_KHONG = :DIATHIGIACTEOCANHGAIMT_KHONG,
  DIATHIGIACTEOCANHGAIMT_CO = :DIATHIGIACTEOCANHGAIMT_CO,
  VANNHANMP = :VANNHANMP,
  VANNHANMT = :VANNHANMT,
  NHANCAUMP_BINHTHUONG = :NHANCAUMP_BINHTHUONG,
  NHANCAUMP_DANNOI = :NHANCAUMP_DANNOI,
  NHANCAUMP_TO = :NHANCAUMP_TO,
  NHANCAUMP_NHO = :NHANCAUMP_NHO,
  NHANCAUMT_BINHTHUONG = :NHANCAUMT_BINHTHUONG,
  NHANCAUMT_DANNOI = :NHANCAUMT_DANNOI,
  NHANCAUMT_TO = :NHANCAUMT_TO,
  NHANCAUMT_NHO = :NHANCAUMT_NHO,
  HOCMATMP = :HOCMATMP,
  HOCMATMT = :HOCMATMT,
  TOANTHANHUYETAP = :TOANTHANHUYETAP,
  TOANTHANNHIETDO = :TOANTHANNHIETDO,
  TOANTHANMACH = :TOANTHANMACH,
  NOITIET_BINHTHUONG = :NOITIET_BINHTHUONG,
  NOITIET_COBENH = :NOITIET_COBENH,
  THANKINH_BINHTHUONG = :THANKINH_BINHTHUONG,
  THANKINH_COBENH = :THANKINH_COBENH,
  TUANHOAN_BINHTHUONG = :TUANHOAN_BINHTHUONG,
  TUANHOAN_COBENH = :TUANHOAN_COBENH,
  HOHAP_BINHTHUONG = :HOHAP_BINHTHUONG,
  HOHAP_COBENH = :HOHAP_COBENH,
  TIEUHOA_BINHTHUONG = :TIEUHOA_BINHTHUONG,
  TIEUHOA_COBENH = :TIEUHOA_COBENH,
  COXUONGKHOP_BINHTHUONG = :COXUONGKHOP_BINHTHUONG,
  COXUONGKHOP_COBENH = :COXUONGKHOP_COBENH,
  TIETNIEUSINHDUC_BINHTHUONG = :TIETNIEUSINHDUC_BINHTHUONG,
  TIETNIEUSINHDUC_COBENH = :TIETNIEUSINHDUC_COBENH,
  BENHCHINHMP = :BENHCHINHMP,
  BENHCHINHMT = :BENHCHINHMT,
  BENHKEMTHEOMP = :BENHKEMTHEOMP,
  BENHKEMTHEOMT = :BENHKEMTHEOMT,
  BENHTOANTHAN = :BENHTOANTHAN,
  CHIDINHDIEUTRI = :CHIDINHDIEUTRI,
  TIENSUKHAC_COR = :TIENSUKHAC_COR,
  TIENSUKHAC_DAPTMAT_TEXT = :TIENSUKHAC_DAPTMAT_TEXT,
  TIENSUBENHTOANTHAN_BENHKHAC = :TIENSUBENHTOANTHAN_BENHKHAC,
  KETMACSEOMOCUMP = :KETMACSEOMOCUMP,
  KETMACSEOMOCUMT = :KETMACSEOMOCUMT,
  GIACMACPHUNEMP = :GIACMACPHUNEMP,
  GIACMACPHUNEMT = :GIACMACPHUNEMT,
  MONGMATTHAIHOAMP = :MONGMATTHAIHOAMP,
  MONGMATTHAIHOAMT = :MONGMATTHAIHOAMT,
  NOITIET = :NOITIET,
  CUNGMASEOMOMP = :CUNGMASEOMOMP,
  CUNGMASEOMOMT = :CUNGMASEOMOMT,
  THETHUYTINHMP_NHAN = :THETHUYTINHMP_NHAN,
  THETHUYTINHMP_VO = :THETHUYTINHMP_VO,
  THETHUYTINHMP_DUOIBAO = :THETHUYTINHMP_DUOIBAO,
  THETHUYTINHMP_TOANBO = :THETHUYTINHMP_TOANBO,
  THETHUYTINHMT_NHAN = :THETHUYTINHMT_NHAN,
  THETHUYTINHMT_VO = :THETHUYTINHMT_VO,
  THETHUYTINHMT_DUOIBAO = :THETHUYTINHMT_DUOIBAO,
  THETHUYTINHMT_TOANBO = :THETHUYTINHMT_TOANBO,
  TIENSUKHAC_BENHKHAC_TEXT = :TIENSUKHAC_BENHKHAC_TEXT,
  CHANDOANRAVIEN_MATPHAI = :CHANDOANRAVIEN_MATPHAI,
  MACHANDOANRAVIEN_MATPHAI = :MACHANDOANRAVIEN_MATPHAI,
  CHANDOANRAVIEN_MATTRAI = :CHANDOANRAVIEN_MATTRAI,
  MACHANDOANRAVIEN_MATTRAI = :MACHANDOANRAVIEN_MATTRAI,
  PPDT_PHAUTHUAT = :PPDT_PHAUTHUAT,
  PPDT_PHAUTHUATTEXT = :PPDT_PHAUTHUATTEXT,
  PPDT_THUOC = :PPDT_THUOC,
  PPDT_THUOCTEXT = :PPDT_THUOCTEXT,
  PPDT_LASER = :PPDT_LASER,
  PPDT_LASERTEXT = :PPDT_LASERTEXT,
  TINHTRANGRAVIEN_MATPHAI = :TINHTRANGRAVIEN_MATPHAI,
  TINHTRANGRAVIEN_MATTRAI = :TINHTRANGRAVIEN_MATTRAI,
  RAVIENMP_KHONGKINH = :RAVIENMP_KHONGKINH,
  RAVIENMT_KHONGKINH = :RAVIENMT_KHONGKINH,
  RAVIENMP_COKINH = :RAVIENMP_COKINH,
  RAVIENMT_COKINH = :RAVIENMT_COKINH,
  RAVIENNHANAPMP = :RAVIENNHANAPMP,
  RAVIENNHANAPMT = :RAVIENNHANAPMT,
  HUONGDIEUTRI_THEODOI = :HUONGDIEUTRI_THEODOI,
  HUONGDIEUTRI_THEODOITEXT = :HUONGDIEUTRI_THEODOITEXT,
  HUONGDIEUTRI_PHAUTHUAT = :HUONGDIEUTRI_PHAUTHUAT,
  HUONGDIEUTRI_PHAUTHUATTEXT = :HUONGDIEUTRI_PHAUTHUATTEXT,
  HUONGDIEUTRI_LASER = :HUONGDIEUTRI_LASER,
  HUONGDIEUTRI_LASERTEXT = :HUONGDIEUTRI_LASERTEXT,
  HUONGDIEUTRI_THUOC = :HUONGDIEUTRI_THUOC,
  HUONGDIEUTRI_THUOCTEXT = :HUONGDIEUTRI_THUOCTEXT,
  BenhLy_Text = :BenhLy_Text,
  BenhLy = :BenhLy,
  ChuaThayBenhLy = :ChuaThayBenhLy,
  PhauThuat = :PhauThuat,
  ThuThuat = :ThuThuat,
  ThiLucKhiRaVien_KhongKinh_MP = :ThiLucKhiRaVien_KhongKinh_MP,
  ThiLucKhiRaVien_KhongKinh_MT = :ThiLucKhiRaVien_KhongKinh_MT,
  ThiLucKhiRaVien_CoKinh_MP = :ThiLucKhiRaVien_CoKinh_MP,
  ThiLucKhiRaVien_CoKinh_MT = :ThiLucKhiRaVien_CoKinh_MT,
  NhanApRaVien_MP = :NhanApRaVien_MP,
  NhanApRaVien_MT = :NhanApRaVien_MT,
  TienSuKhac = :TienSuKhac,
NoiTietCheck = :NoiTietCheck, 
NoiTiet_Text = :NoiTiet_Text,
ThanKinhCheck = :ThanKinhCheck, 
ThanKinh_Text = :ThanKinh_Text,
TuanHoanCheck = :TuanHoanCheck, 
TuanHoan_Text = :TuanHoan_Text,
HoHapCheck = :HoHapCheck, 
HoHap_Text = :HoHap_Text,
TieuHoaCheck = :TieuHoaCheck, 
TieuHoa_Text = :TieuHoa_Text,
CoXuongKhopCheck = :CoXuongKhopCheck, 
CoXuongKhop_Text = :CoXuongKhop_Text,
TietNieuSinhDucCheck = :TietNieuSinhDucCheck, 
TietNieuSinhDuc_Text = :TietNieuSinhDuc_Text,
KhamBenhToanThan_Khac = :KhamBenhToanThan_Khac,
ChanDoanRaVien = :ChanDoanRaVien WHERE  MAQUANLY = :MAQUANLY";
            else
                sql = @"INSERT INTO BenhAnMatGlocom (LYDOVAOVIEN,
 VAONGAYTHU,
 QUATRINHBENHLY,
 TIENSUBENHBANTHAN,
 TIENSUBENHGIADINH,
 MACH,
 NHIETDO,
 HUYETAP,
 NHIPTHO,
 CANNANG,
 CHIEUCAO,
 TOANTHAN,
 TUANHOAN,
 HOHAP,
 TIEUHOA,
 THANTIETNIEUSINHDUC,
 THANKINH,
 COXUONGKHOP,
 TAIMUIHONG,
 RANGHAMMAT,
 MAT,
 KHAC_CACCOQUAN,
 CACXETNGHIEMCANLAMSANGCANLAM,
 TOMTATBENHAN,
 BENHCHINH,
 BENHKEMTHEO,
 PHANBIET,
 TIENLUONG,
 HUONGDIEUTRI,
 NGAYKHAMBENH,
 BACSYLAMBENHAN,
 XQUANG,
 CTSCANNER,
 SIEUAM,
 XETNGHIEM,
 KHAC,
 KHAC_TEXT,
 TOANBOHOSO,
 QUATRINHBENHLYVADIENBIEN,
 TOMTATKETQUAXETNGHIEM,
 PHUONGPHAPDIEUTRI,
 TINHTRANGNGUOIBENHRAVIEN,
 HUONGDIEUTRIVACACCHEDOTIEPTHEO,
 NGUOINHANHOSO,
 NGUOIGIAOHOSO,
 NGAYTONGKET,
 BACSYDIEUTRI,
 DIUNG,
 DIUNG_TEXT,
 MATUY,
 MATUY_TEXT,
 RUOUBIA,
 RUOUBIA_TEXT,
 THUOCLA,
 THUOCLA_TEXT,
 THUOCLAO,
 THUOCLAO_TEXT,
 KHAC_DACDIEMLIENQUANBENH,
 KHAC_DACDIEMLIENQUANBENH_TEXT,
 LYDODIKHAM_MP,
 LYDODIKHAM_MT,
 LYDODIKHAM_2MAT,
 NHUCMAT_DUDOI,
 NHUCMAT_VUA,
 NHUCMAT_NHE,
 NHUCMAT_KHONG,
 NHIN_MODOTNGOT,
 NHIN_MOTUNGLUC,
 NHIN_SUONGMU,
 NHIN_KHONGMO,
 NHIN_MOTANGDAN,
 NHIN_NHINTHUHEP,
 NHIN_QUANTANSAC,
 SOANHSANGCHAYNUOCMAT_CO,
 SOANHSANGCHAYNUOCMAT_KHONG,
 DOMAT_CO,
 DOMAT_KHONG,
 TOANTHAN_DAUDAU,
 TOANTHAN_NON,
 TOANTHAN_BUONNON,
 TOANTHAN_KHONG,
 CACTRIEUCHUNGKHAC,
 THOIGIANXUATHIENBENH,
 DAKHAMCHUABENH_HUYEN,
 DAKHAMCHUABENH_TINH,
 DAKHAMCHUABENH_TRUNGUONG,
 DAKHAMCHUABENH_KHAC,
 PHUONGPHAPDIEUTRI_PHAUTHUAT,
 PHUONGPHAPDIEUTRI_THUOC,
 PHUONGPHAPDIEUTRI_LASER,
 PTTTMP_LOAI1,
 PTTTMP_LOAI2,
 PTTTMP_LOAI3,
 PTTTMP_LOAI4,
 PTTTMT_LOAI1,
 PTTTMT_LOAI2,
 PTTTMT_LOAI3,
 PTTTMT_LOAI4,
 PTTTMP_THOIDIEM1,
 PTTTMP_THOIDIEM2,
 PTTTMP_THOIDIEM3,
 PTTTMP_THOIDIEM4,
 PTTTMT_THOIDIEM1,
 PTTTMT_THOIDIEM2,
 PTTTMT_THOIDIEM3,
 PTTTMT_THOIDIEM4,
 PTTTMP_NOI1,
 PTTTMP_NOI2,
 PTTTMP_NOI3,
 PTTTMP_NOI4,
 PTTTMT_NOI1,
 PTTTMT_NOI2,
 PTTTMT_NOI3,
 PTTTMT_NOI4,
 THUOCHANHANAP_UONG,
 THUOCHANHANAP_TRAMAT,
 THUOCHANHANAP_TIEM,
 THUOCHANHANAP_1THUOC,
 THUOCHANHANAP_2THUOC,
 THUOCHANHANAP_3THUOC,
 THUOCHANHANAP_4THUOC,
 THUOCHANHANAPDADUNG,
 CACTHUOCKHAC,
 TIENTRINHDIEUTRI,
 TIENSUKHAC_CANTHI,
 TIENSUKHAC_VIENTHI,
 TIENSUKHAC_TRANTHUONG,
 TIENSUKHAC_VIENMANGBODAO,
 TIENSUKHAC_VIENPHANTRUOCNHACAU,
 TIENSUKHAC_TACTMTTVM,
 TIENSUKHAC_DAPTMAT,
 TIENSUKHAC_BENHKHAC,
 TIENSUKHAC_CORTICOSTEROID,
 THOIGIANSUDUNG_CORTICOSTEROID,
 CORTICOSTEROID_TRAMAT,
 CORTICOSTEROID_TIEMMAT,
 CORTICOSTEROID_TOANTHAN,
 CORTICOSTEROID_THEOCDCUABACSI,
 CORTICOSTEROID_BNTUDUNGTHUOC,
 TIENSUTOANTHAN_TIMMACH,
 TIENSUTOANTHAN_HUYETAP,
 TIENSUTOANTHAN_DAIDUONG,
 TIENSUTOANTHAN_RODONGMACHCANH,
 TIENSUTOANTHAN_BENHKHAC,
 TIENSUGLOCOMGIADINH_ONGBA,
 TIENSUGLOCOMGIADINH_BOME,
 TIENSUGLOCOMGIADINH_ANHCHIEM,
 TIENSUGLOCOMGIADINH_CODICHUBAC,
 THILUCVAOVIENMP_KHONGKINH,
 THILUCVAOVIENMT_KHONGKINH,
 THILUCVAOVIENMP_COKINH,
 THILUCVAOVIENMT_COKINH,
 NHAAPMP,
 NHAAPMT,
 MIMATSUNGNEMP_KHONG,
 MIMATSUNGNEMP_CO,
 MIMATSUNGNEMT_KHONG,
 MIMATSUNGNEMT_CO,
 NHANAPMP_KHAC,
 NHANAPMT_KHAC,
 KETMACCUONGTUMP_KHONG,
 KETMACCUONGTUMP_CO,
 KETMACCUONGTUMT_KHONG,
 KETMACCUONGTUMT_CO,
 KETMACSEOMOCUMP_KHONG,
 KETMACSEOMOCUMP_CO,
 KETMACSEOMOCUMT_KHONG,
 KETMACSEOMOCUMT_CO,
 KETMACBONDOMP_TOT,
 KETMACBONDOMP_DEP,
 KETMACBONDOMP_XO,
 KETMACBONDOMP_MONG,
 KETMACBONDOMP_QUAPHAT,
 KETMACBONDOMT_TOT,
 KETMACBONDOMT_DEP,
 KETMACBONDOMT_XO,
 KETMACBONDOMT_MONG,
 KETMACBONDOMT_QUAPHAT,
 GIACMACTRONGSUATMP_TRONG,
 GIACMACTRONGSUATMP_SEO,
 GIACMACTRONGSUATMP_LOANDUONG,
 GIACMACPHUNEMP_KHONG,
 GIACMACPHUNEMP_CO,
 GIACMACTRONGSUATMT_TRONG,
 GIACMACTRONGSUATMT_SEO,
 GIACMACTRONGSUATMT_LOANDUONG,
 GIACMACPHUNEMT_KHONG,
 GIACMACPHUNEMT_CO,
 GIACMACDODAYGIACMACMP,
 GIACMACDODAYGIACMACMT,
 GIACMACTUMP,
 GIACMACTUMT,
 GIACMACDUONGKINHGIACMACMP,
 GIACMACDUONGKINHGIACMACMT,
 CUNGMACDANLOIMP_KHONG,
 CUNGMACDANLOIMP_CO,
 CUNGMACDANLOIMT_KHONG,
 CUNGMACDANLOIMT_CO,
 CUNGMASEOMOMP_KHONG,
 CUNGMASEOMOMP_CO,
 CUNGMASEOMOMT_KHONG,
 CUNGMASEOMOMT_CO,
 TIENPHONGDOSAUMP,
 TIENPHONGDOSAUMT,
 GOCTIENPHONGDAUHIEUKHACMP,
 GOCTIENPHONGDAUHIEUKHACMT,
 MONGMATMAUSACMP,
 MONGMATMAUSACMT,
 MONGMATTHAIHOAMP_KHONG,
 MONGMATTHAIHOAMP_CO,
 MONGMATTHAIHOAMT_KHONG,
 MONGMATTHAIHOAMT_CO,
 MONGMATTANMACHMP_KHONG,
 MONGMATTANMACHMP_CO,
 MONGMATTANMACHMT_KHONG,
 MONGMATTANMACHMT_CO,
 DONGTUMP_TRON,
 DONGTUMP_MEO,
 DONGTUMT_TRON,
 DONGTUMT_MEO,
 DONGTUDUONGKINHMP,
 DONGTUDUONGKINHMT,
 DONGTUVIENSACTOMP,
 DONGTUVIENSACTOMT,
 DONGTUPHANXAMP_BINHTHUONG,
 DONGTUPHANXAMP_GIAM,
 DONGTUPHANXAMP_MAT,
 DONGTUPHANXAMT_BINHTHUONG,
 DONGTUPHANXAMT_GIAM,
 DONGTUPHANXAMT_MAT,
 THETHUYTINHMP_TRONG,
 THETHUYTINHMP_DUC,
 THETHUYTINHMT_TRONG,
 THETHUYTINHMT_DUC,
 DICHMP,
 DICHMT,
 DAYMATVONGMACMP,
 DAYMATVONGMACMT,
 DAYMATHOANGDIEMMP,
 DAYMATHOANGDIEMMT,
 DAYMATTANMACHMP_KHONG,
 DAYMATTANMACHMP_CO,
 DAYMATTANMACHMT_KHONG,
 DAYMATTANMACHMT_CO,
 DAYMATXUATHUYETMP_KHONG,
 DAYMATXUATHUYETMP_CO,
 DAYMATXUATHUYETMT_KHONG,
 DAYMATXUATHUYETMT_CO,
 DAYMATVIENTHANKINHMP_KHONG,
 DAYMATVIENTHANKINHMP_CO,
 DAYMATVIENTHANKINHMT_KHONG,
 DAYMATVIENTHANKINHMT_CO,
 DIATHIGIAVIENTHANKINHMP_DUOI,
 DIATHIGIAVIENTHANKINHMP_TREN,
 DIATHIGIAVIENTHANKINHMP_MUI,
 DIATHIGIAVIENTHANKINHMP_TDUONG,
 DIATHIGIAVIENTHANKINHMT_DUOI,
 DIATHIGIAVIENTHANKINHMT_TREN,
 DIATHIGIAVIENTHANKINHMT_MUI,
 DIATHIGIAVIENTHANKINHMT_TDUONG,
 DIATHIGIACMAUSACMP,
 DIATHIGIACMAUSACMT,
 DIATHIGIACCDMP,
 DIATHIGIACCDMT,
 DIATHIGIACMACHMAUMP_BINHTHUONG,
 DIATHIGIACMACHMAUMP_CHHUONG,
 DIATHIGIACMACHMAUMP_GAPGOC,
 DIATHIGIACMACHMAUMT_BINHTHUONG,
 DIATHIGIACMACHMAUMT_CHHUONG,
 DIATHIGIACMACHMAUMT_GAPGOC,
 DIATHIGIACXUATHUETMP_KHONG,
 DIATHIGIACXUATHUETMP_CO,
 DIATHIGIACXUATHUETMT_KHONG,
 DIATHIGIACXUATHUETMT_CO,
 DIATHIGIACTEOCANHGAIMP_KHONG,
 DIATHIGIACTEOCANHGAIMP_CO,
 DIATHIGIACTEOCANHGAIMT_KHONG,
 DIATHIGIACTEOCANHGAIMT_CO,
 VANNHANMP,
 VANNHANMT,
 NHANCAUMP_BINHTHUONG,
 NHANCAUMP_DANNOI,
 NHANCAUMP_TO,
 NHANCAUMP_NHO,
 NHANCAUMT_BINHTHUONG,
 NHANCAUMT_DANNOI,
 NHANCAUMT_TO,
 NHANCAUMT_NHO,
 HOCMATMP,
 HOCMATMT,
 TOANTHANHUYETAP,
 TOANTHANNHIETDO,
 TOANTHANMACH,
 NOITIET_BINHTHUONG,
 NOITIET_COBENH,
 THANKINH_BINHTHUONG,
 THANKINH_COBENH,
 TUANHOAN_BINHTHUONG,
 TUANHOAN_COBENH,
 HOHAP_BINHTHUONG,
 HOHAP_COBENH,
 TIEUHOA_BINHTHUONG,
 TIEUHOA_COBENH,
 COXUONGKHOP_BINHTHUONG,
 COXUONGKHOP_COBENH,
 TIETNIEUSINHDUC_BINHTHUONG,
 TIETNIEUSINHDUC_COBENH,
 BENHCHINHMP,
 BENHCHINHMT,
 BENHKEMTHEOMP,
 BENHKEMTHEOMT,
 BENHTOANTHAN,
 CHIDINHDIEUTRI,
 TIENSUKHAC_COR,
 TIENSUKHAC_DAPTMAT_TEXT,
 TIENSUBENHTOANTHAN_BENHKHAC,
 KETMACSEOMOCUMP,
 KETMACSEOMOCUMT,
 GIACMACPHUNEMP,
 GIACMACPHUNEMT,
 MONGMATTHAIHOAMP,
 MONGMATTHAIHOAMT,
 NOITIET,
 CUNGMASEOMOMP,
 CUNGMASEOMOMT,
 THETHUYTINHMP_NHAN,
 THETHUYTINHMP_VO,
 THETHUYTINHMP_DUOIBAO,
 THETHUYTINHMP_TOANBO,
 THETHUYTINHMT_NHAN,
 THETHUYTINHMT_VO,
 THETHUYTINHMT_DUOIBAO,
 THETHUYTINHMT_TOANBO,
 TIENSUKHAC_BENHKHAC_TEXT,
 CHANDOANRAVIEN_MATPHAI,
 MACHANDOANRAVIEN_MATPHAI,
 CHANDOANRAVIEN_MATTRAI,
 MACHANDOANRAVIEN_MATTRAI,
 PPDT_PHAUTHUAT,
 PPDT_PHAUTHUATTEXT,
 PPDT_THUOC,
 PPDT_THUOCTEXT,
 PPDT_LASER,
 PPDT_LASERTEXT,
 TINHTRANGRAVIEN_MATPHAI,
 TINHTRANGRAVIEN_MATTRAI,
 RAVIENMP_KHONGKINH,
 RAVIENMT_KHONGKINH,
 RAVIENMP_COKINH,
 RAVIENMT_COKINH,
 RAVIENNHANAPMP,
 RAVIENNHANAPMT,
 HUONGDIEUTRI_THEODOI,
 HUONGDIEUTRI_THEODOITEXT,
 HUONGDIEUTRI_PHAUTHUAT,
 HUONGDIEUTRI_PHAUTHUATTEXT,
 HUONGDIEUTRI_LASER,
 HUONGDIEUTRI_LASERTEXT,
 HUONGDIEUTRI_THUOC,
 HUONGDIEUTRI_THUOCTEXT,
 MAQUANLY,
 ChuaThayBenhLy,
 BenhLy,
 BenhLy_Text,
 PhauThuat,
 ThuThuat,
 ThiLucKhiRaVien_KhongKinh_MP,
 ThiLucKhiRaVien_KhongKinh_MT,
 ThiLucKhiRaVien_CoKinh_MP,
 ThiLucKhiRaVien_CoKinh_MT,
 NhanApRaVien_MP,
 NhanApRaVien_MT,
 TienSuKhac,
 NoiTietCheck,
NoiTiet_Text,
ThanKinhCheck,
ThanKinh_Text,
TuanHoanCheck,
TuanHoan_Text,
HoHapCheck,
HoHap_Text,
TieuHoaCheck,
TieuHoa_Text,
CoXuongKhopCheck,
CoXuongKhop_Text,
TietNieuSinhDucCheck,
TietNieuSinhDuc_Text,
KhamBenhToanThan_Khac,
ChanDoanRaVien) 
 VALUES
 (:LYDOVAOVIEN,
 :VAONGAYTHU,
 :QUATRINHBENHLY,
 :TIENSUBENHBANTHAN,
 :TIENSUBENHGIADINH,
 :MACH,
 :NHIETDO,
 :HUYETAP,
 :NHIPTHO,
 :CANNANG,
 :CHIEUCAO,
 :TOANTHAN,
 :TUANHOAN,
 :HOHAP,
 :TIEUHOA,
 :THANTIETNIEUSINHDUC,
 :THANKINH,
 :COXUONGKHOP,
 :TAIMUIHONG,
 :RANGHAMMAT,
 :MAT,
 :KHAC_CACCOQUAN,
 :CACXETNGHIEMCANLAMSANGCANLAM,
 :TOMTATBENHAN,
 :BENHCHINH,
 :BENHKEMTHEO,
 :PHANBIET,
 :TIENLUONG,
 :HUONGDIEUTRI,
 :NGAYKHAMBENH,
 :BACSYLAMBENHAN,
 :XQUANG,
 :CTSCANNER,
 :SIEUAM,
 :XETNGHIEM,
 :KHAC,
 :KHAC_TEXT,
 :TOANBOHOSO,
 :QUATRINHBENHLYVADIENBIEN,
 :TOMTATKETQUAXETNGHIEM,
 :PHUONGPHAPDIEUTRI,
 :TINHTRANGNGUOIBENHRAVIEN,
 :HUONGDIEUTRIVACACCHEDOTIEPTHEO,
 :NGUOINHANHOSO,
 :NGUOIGIAOHOSO,
 :NGAYTONGKET,
 :BACSYDIEUTRI,
 :DIUNG,
 :DIUNG_TEXT,
 :MATUY,
 :MATUY_TEXT,
 :RUOUBIA,
 :RUOUBIA_TEXT,
 :THUOCLA,
 :THUOCLA_TEXT,
 :THUOCLAO,
 :THUOCLAO_TEXT,
 :KHAC_DACDIEMLIENQUANBENH,
 :KHAC_DACDIEMLIENQUANBENH_TEXT,
 :LYDODIKHAM_MP,
 :LYDODIKHAM_MT,
 :LYDODIKHAM_2MAT,
 :NHUCMAT_DUDOI,
 :NHUCMAT_VUA,
 :NHUCMAT_NHE,
 :NHUCMAT_KHONG,
 :NHIN_MODOTNGOT,
 :NHIN_MOTUNGLUC,
 :NHIN_SUONGMU,
 :NHIN_KHONGMO,
 :NHIN_MOTANGDAN,
 :NHIN_NHINTHUHEP,
 :NHIN_QUANTANSAC,
 :SOANHSANGCHAYNUOCMAT_CO,
 :SOANHSANGCHAYNUOCMAT_KHONG,
 :DOMAT_CO,
 :DOMAT_KHONG,
 :TOANTHAN_DAUDAU,
 :TOANTHAN_NON,
 :TOANTHAN_BUONNON,
 :TOANTHAN_KHONG,
 :CACTRIEUCHUNGKHAC,
 :THOIGIANXUATHIENBENH,
 :DAKHAMCHUABENH_HUYEN,
 :DAKHAMCHUABENH_TINH,
 :DAKHAMCHUABENH_TRUNGUONG,
 :DAKHAMCHUABENH_KHAC,
 :PHUONGPHAPDIEUTRI_PHAUTHUAT,
 :PHUONGPHAPDIEUTRI_THUOC,
 :PHUONGPHAPDIEUTRI_LASER,
 :PTTTMP_LOAI1,
 :PTTTMP_LOAI2,
 :PTTTMP_LOAI3,
 :PTTTMP_LOAI4,
 :PTTTMT_LOAI1,
 :PTTTMT_LOAI2,
 :PTTTMT_LOAI3,
 :PTTTMT_LOAI4,
 :PTTTMP_THOIDIEM1,
 :PTTTMP_THOIDIEM2,
 :PTTTMP_THOIDIEM3,
 :PTTTMP_THOIDIEM4,
 :PTTTMT_THOIDIEM1,
 :PTTTMT_THOIDIEM2,
 :PTTTMT_THOIDIEM3,
 :PTTTMT_THOIDIEM4,
 :PTTTMP_NOI1,
 :PTTTMP_NOI2,
 :PTTTMP_NOI3,
 :PTTTMP_NOI4,
 :PTTTMT_NOI1,
 :PTTTMT_NOI2,
 :PTTTMT_NOI3,
 :PTTTMT_NOI4,
 :THUOCHANHANAP_UONG,
 :THUOCHANHANAP_TRAMAT,
 :THUOCHANHANAP_TIEM,
 :THUOCHANHANAP_1THUOC,
 :THUOCHANHANAP_2THUOC,
 :THUOCHANHANAP_3THUOC,
 :THUOCHANHANAP_4THUOC,
 :THUOCHANHANAPDADUNG,
 :CACTHUOCKHAC,
 :TIENTRINHDIEUTRI,
 :TIENSUKHAC_CANTHI,
 :TIENSUKHAC_VIENTHI,
 :TIENSUKHAC_TRANTHUONG,
 :TIENSUKHAC_VIENMANGBODAO,
 :TIENSUKHAC_VIENPHANTRUOCNHACAU,
 :TIENSUKHAC_TACTMTTVM,
 :TIENSUKHAC_DAPTMAT,
 :TIENSUKHAC_BENHKHAC,
 :TIENSUKHAC_CORTICOSTEROID,
 :THOIGIANSUDUNG_CORTICOSTEROID,
 :CORTICOSTEROID_TRAMAT,
 :CORTICOSTEROID_TIEMMAT,
 :CORTICOSTEROID_TOANTHAN,
 :CORTICOSTEROID_THEOCDCUABACSI,
 :CORTICOSTEROID_BNTUDUNGTHUOC,
 :TIENSUTOANTHAN_TIMMACH,
 :TIENSUTOANTHAN_HUYETAP,
 :TIENSUTOANTHAN_DAIDUONG,
 :TIENSUTOANTHAN_RODONGMACHCANH,
 :TIENSUTOANTHAN_BENHKHAC,
 :TIENSUGLOCOMGIADINH_ONGBA,
 :TIENSUGLOCOMGIADINH_BOME,
 :TIENSUGLOCOMGIADINH_ANHCHIEM,
 :TIENSUGLOCOMGIADINH_CODICHUBAC,
 :THILUCVAOVIENMP_KHONGKINH,
 :THILUCVAOVIENMT_KHONGKINH,
 :THILUCVAOVIENMP_COKINH,
 :THILUCVAOVIENMT_COKINH,
 :NHAAPMP,
 :NHAAPMT,
 :MIMATSUNGNEMP_KHONG,
 :MIMATSUNGNEMP_CO,
 :MIMATSUNGNEMT_KHONG,
 :MIMATSUNGNEMT_CO,
 :NHANAPMP_KHAC,
 :NHANAPMT_KHAC,
 :KETMACCUONGTUMP_KHONG,
 :KETMACCUONGTUMP_CO,
 :KETMACCUONGTUMT_KHONG,
 :KETMACCUONGTUMT_CO,
 :KETMACSEOMOCUMP_KHONG,
 :KETMACSEOMOCUMP_CO,
 :KETMACSEOMOCUMT_KHONG,
 :KETMACSEOMOCUMT_CO,
 :KETMACBONDOMP_TOT,
 :KETMACBONDOMP_DEP,
 :KETMACBONDOMP_XO,
 :KETMACBONDOMP_MONG,
 :KETMACBONDOMP_QUAPHAT,
 :KETMACBONDOMT_TOT,
 :KETMACBONDOMT_DEP,
 :KETMACBONDOMT_XO,
 :KETMACBONDOMT_MONG,
 :KETMACBONDOMT_QUAPHAT,
 :GIACMACTRONGSUATMP_TRONG,
 :GIACMACTRONGSUATMP_SEO,
 :GIACMACTRONGSUATMP_LOANDUONG,
 :GIACMACPHUNEMP_KHONG,
 :GIACMACPHUNEMP_CO,
 :GIACMACTRONGSUATMT_TRONG,
 :GIACMACTRONGSUATMT_SEO,
 :GIACMACTRONGSUATMT_LOANDUONG,
 :GIACMACPHUNEMT_KHONG,
 :GIACMACPHUNEMT_CO,
 :GIACMACDODAYGIACMACMP,
 :GIACMACDODAYGIACMACMT,
 :GIACMACTUMP,
 :GIACMACTUMT,
 :GIACMACDUONGKINHGIACMACMP,
 :GIACMACDUONGKINHGIACMACMT,
 :CUNGMACDANLOIMP_KHONG,
 :CUNGMACDANLOIMP_CO,
 :CUNGMACDANLOIMT_KHONG,
 :CUNGMACDANLOIMT_CO,
 :CUNGMASEOMOMP_KHONG,
 :CUNGMASEOMOMP_CO,
 :CUNGMASEOMOMT_KHONG,
 :CUNGMASEOMOMT_CO,
 :TIENPHONGDOSAUMP,
 :TIENPHONGDOSAUMT,
 :GOCTIENPHONGDAUHIEUKHACMP,
 :GOCTIENPHONGDAUHIEUKHACMT,
 :MONGMATMAUSACMP,
 :MONGMATMAUSACMT,
 :MONGMATTHAIHOAMP_KHONG,
 :MONGMATTHAIHOAMP_CO,
 :MONGMATTHAIHOAMT_KHONG,
 :MONGMATTHAIHOAMT_CO,
 :MONGMATTANMACHMP_KHONG,
 :MONGMATTANMACHMP_CO,
 :MONGMATTANMACHMT_KHONG,
 :MONGMATTANMACHMT_CO,
 :DONGTUMP_TRON,
 :DONGTUMP_MEO,
 :DONGTUMT_TRON,
 :DONGTUMT_MEO,
 :DONGTUDUONGKINHMP,
 :DONGTUDUONGKINHMT,
 :DONGTUVIENSACTOMP,
 :DONGTUVIENSACTOMT,
 :DONGTUPHANXAMP_BINHTHUONG,
 :DONGTUPHANXAMP_GIAM,
 :DONGTUPHANXAMP_MAT,
 :DONGTUPHANXAMT_BINHTHUONG,
 :DONGTUPHANXAMT_GIAM,
 :DONGTUPHANXAMT_MAT,
 :THETHUYTINHMP_TRONG,
 :THETHUYTINHMP_DUC,
 :THETHUYTINHMT_TRONG,
 :THETHUYTINHMT_DUC,
 :DICHMP,
 :DICHMT,
 :DAYMATVONGMACMP,
 :DAYMATVONGMACMT,
 :DAYMATHOANGDIEMMP,
 :DAYMATHOANGDIEMMT,
 :DAYMATTANMACHMP_KHONG,
 :DAYMATTANMACHMP_CO,
 :DAYMATTANMACHMT_KHONG,
 :DAYMATTANMACHMT_CO,
 :DAYMATXUATHUYETMP_KHONG,
 :DAYMATXUATHUYETMP_CO,
 :DAYMATXUATHUYETMT_KHONG,
 :DAYMATXUATHUYETMT_CO,
 :DAYMATVIENTHANKINHMP_KHONG,
 :DAYMATVIENTHANKINHMP_CO,
 :DAYMATVIENTHANKINHMT_KHONG,
 :DAYMATVIENTHANKINHMT_CO,
 :DIATHIGIAVIENTHANKINHMP_DUOI,
 :DIATHIGIAVIENTHANKINHMP_TREN,
 :DIATHIGIAVIENTHANKINHMP_MUI,
 :DIATHIGIAVIENTHANKINHMP_TDUONG,
 :DIATHIGIAVIENTHANKINHMT_DUOI,
 :DIATHIGIAVIENTHANKINHMT_TREN,
 :DIATHIGIAVIENTHANKINHMT_MUI,
 :DIATHIGIAVIENTHANKINHMT_TDUONG,
 :DIATHIGIACMAUSACMP,
 :DIATHIGIACMAUSACMT,
 :DIATHIGIACCDMP,
 :DIATHIGIACCDMT,
 :DIATHIGIACMACHMAUMP_BINHTHUONG,
 :DIATHIGIACMACHMAUMP_CHHUONG,
 :DIATHIGIACMACHMAUMP_GAPGOC,
 :DIATHIGIACMACHMAUMT_BINHTHUONG,
 :DIATHIGIACMACHMAUMT_CHHUONG,
 :DIATHIGIACMACHMAUMT_GAPGOC,
 :DIATHIGIACXUATHUETMP_KHONG,
 :DIATHIGIACXUATHUETMP_CO,
 :DIATHIGIACXUATHUETMT_KHONG,
 :DIATHIGIACXUATHUETMT_CO,
 :DIATHIGIACTEOCANHGAIMP_KHONG,
 :DIATHIGIACTEOCANHGAIMP_CO,
 :DIATHIGIACTEOCANHGAIMT_KHONG,
 :DIATHIGIACTEOCANHGAIMT_CO,
 :VANNHANMP,
 :VANNHANMT,
 :NHANCAUMP_BINHTHUONG,
 :NHANCAUMP_DANNOI,
 :NHANCAUMP_TO,
 :NHANCAUMP_NHO,
 :NHANCAUMT_BINHTHUONG,
 :NHANCAUMT_DANNOI,
 :NHANCAUMT_TO,
 :NHANCAUMT_NHO,
 :HOCMATMP,
 :HOCMATMT,
 :TOANTHANHUYETAP,
 :TOANTHANNHIETDO,
 :TOANTHANMACH,
 :NOITIET_BINHTHUONG,
 :NOITIET_COBENH,
 :THANKINH_BINHTHUONG,
 :THANKINH_COBENH,
 :TUANHOAN_BINHTHUONG,
 :TUANHOAN_COBENH,
 :HOHAP_BINHTHUONG,
 :HOHAP_COBENH,
 :TIEUHOA_BINHTHUONG,
 :TIEUHOA_COBENH,
 :COXUONGKHOP_BINHTHUONG,
 :COXUONGKHOP_COBENH,
 :TIETNIEUSINHDUC_BINHTHUONG,
 :TIETNIEUSINHDUC_COBENH,
 :BENHCHINHMP,
 :BENHCHINHMT,
 :BENHKEMTHEOMP,
 :BENHKEMTHEOMT,
 :BENHTOANTHAN,
 :CHIDINHDIEUTRI,
 :TIENSUKHAC_COR,
 :TIENSUKHAC_DAPTMAT_TEXT,
 :TIENSUBENHTOANTHAN_BENHKHAC,
 :KETMACSEOMOCUMP,
 :KETMACSEOMOCUMT,
 :GIACMACPHUNEMP,
 :GIACMACPHUNEMT,
 :MONGMATTHAIHOAMP,
 :MONGMATTHAIHOAMT,
 :NOITIET,
 :CUNGMASEOMOMP,
 :CUNGMASEOMOMT,
 :THETHUYTINHMP_NHAN,
 :THETHUYTINHMP_VO,
 :THETHUYTINHMP_DUOIBAO,
 :THETHUYTINHMP_TOANBO,
 :THETHUYTINHMT_NHAN,
 :THETHUYTINHMT_VO,
 :THETHUYTINHMT_DUOIBAO,
 :THETHUYTINHMT_TOANBO,
 :TIENSUKHAC_BENHKHAC_TEXT,
 :CHANDOANRAVIEN_MATPHAI,
 :MACHANDOANRAVIEN_MATPHAI,
 :CHANDOANRAVIEN_MATTRAI,
 :MACHANDOANRAVIEN_MATTRAI,
 :PPDT_PHAUTHUAT,
 :PPDT_PHAUTHUATTEXT,
 :PPDT_THUOC,
 :PPDT_THUOCTEXT,
 :PPDT_LASER,
 :PPDT_LASERTEXT,
 :TINHTRANGRAVIEN_MATPHAI,
 :TINHTRANGRAVIEN_MATTRAI,
 :RAVIENMP_KHONGKINH,
 :RAVIENMT_KHONGKINH,
 :RAVIENMP_COKINH,
 :RAVIENMT_COKINH,
 :RAVIENNHANAPMP,
 :RAVIENNHANAPMT,
 :HUONGDIEUTRI_THEODOI,
 :HUONGDIEUTRI_THEODOITEXT,
 :HUONGDIEUTRI_PHAUTHUAT,
 :HUONGDIEUTRI_PHAUTHUATTEXT,
 :HUONGDIEUTRI_LASER,
 :HUONGDIEUTRI_LASERTEXT,
 :HUONGDIEUTRI_THUOC,
 :HUONGDIEUTRI_THUOCTEXT,
 :MAQUANLY,
 :ChuaThayBenhLy,
 :BenhLy,
 :BenhLy_Text,
 :PhauThuat,
 :ThuThuat,
 :ThiLucKhiRaVien_KhongKinh_MP,
 :ThiLucKhiRaVien_KhongKinh_MT,
 :ThiLucKhiRaVien_CoKinh_MP,
 :ThiLucKhiRaVien_CoKinh_MT,
 :NhanApRaVien_MP,
 :NhanApRaVien_MT,
 :TienSuKhac,
:NoiTietCheck,
:NoiTiet_Text,
:ThanKinhCheck,
:ThanKinh_Text,
:TuanHoanCheck,
:TuanHoan_Text,
:HoHapCheck,
:HoHap_Text,
:TieuHoaCheck,
:TieuHoa_Text,
:CoXuongKhopCheck,
:CoXuongKhop_Text,
:TietNieuSinhDucCheck,
:TietNieuSinhDuc_Text,
:KhamBenhToanThan_Khac,
:ChanDoanRaVien)";
            BenhAnMatGlocom.ThuocHaNhanApDaDung = HoiBenh_MatGlocomUserControl.listThuocs;
            Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("LYDOVAOVIEN", BenhAnMatGlocom.LyDoVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("VAONGAYTHU", BenhAnMatGlocom.VaoNgayThu));
            Command.Parameters.Add(new MDB.MDBParameter("QUATRINHBENHLY", BenhAnMatGlocom.QuaTrinhBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("TIENSUBENHBANTHAN", BenhAnMatGlocom.TienSuBenhBanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TIENSUBENHGIADINH", BenhAnMatGlocom.TienSuBenhGiaDinh));
            Command.Parameters.Add(new MDB.MDBParameter("MACH", BenhAnMatGlocom.DauSinhTon.Mach));
            Command.Parameters.Add(new MDB.MDBParameter("NHIETDO", BenhAnMatGlocom.DauSinhTon.NhietDo));
            Command.Parameters.Add(new MDB.MDBParameter("HUYETAP", BenhAnMatGlocom.DauSinhTon.HuyetAp));
            Command.Parameters.Add(new MDB.MDBParameter("NHIPTHO", BenhAnMatGlocom.DauSinhTon.NhipTho));
            Command.Parameters.Add(new MDB.MDBParameter("CANNANG", BenhAnMatGlocom.DauSinhTon.CanNang));
            Command.Parameters.Add(new MDB.MDBParameter("CHIEUCAO", BenhAnMatGlocom.DauSinhTon.ChieuCao));
            Command.Parameters.Add(new MDB.MDBParameter("TOANTHAN", BenhAnMatGlocom.ToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TUANHOAN", BenhAnMatGlocom.TuanHoan));
            Command.Parameters.Add(new MDB.MDBParameter("HOHAP", BenhAnMatGlocom.HoHap));
            Command.Parameters.Add(new MDB.MDBParameter("TIEUHOA", BenhAnMatGlocom.TieuHoa));
            Command.Parameters.Add(new MDB.MDBParameter("THANTIETNIEUSINHDUC", BenhAnMatGlocom.ThanTietNieuSinhDuc));
            Command.Parameters.Add(new MDB.MDBParameter("THANKINH", BenhAnMatGlocom.ThanKinh));
            Command.Parameters.Add(new MDB.MDBParameter("COXUONGKHOP", BenhAnMatGlocom.CoXuongKhop));
            Command.Parameters.Add(new MDB.MDBParameter("TAIMUIHONG", BenhAnMatGlocom.TaiMuiHong));
            Command.Parameters.Add(new MDB.MDBParameter("RANGHAMMAT", BenhAnMatGlocom.RangHamMat));
            Command.Parameters.Add(new MDB.MDBParameter("MAT", BenhAnMatGlocom.Mat));
            Command.Parameters.Add(new MDB.MDBParameter("KHAC_CACCOQUAN", BenhAnMatGlocom.Khac_CacCoQuan));
            Command.Parameters.Add(new MDB.MDBParameter("CACXETNGHIEMCANLAMSANGCANLAM", BenhAnMatGlocom.CacXetNghiemCanLamSangCanLam));
            Command.Parameters.Add(new MDB.MDBParameter("TOMTATBENHAN", BenhAnMatGlocom.TomTatBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("BENHCHINH", BenhAnMatGlocom.BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("BENHKEMTHEO", BenhAnMatGlocom.BenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("PHANBIET", BenhAnMatGlocom.PhanBiet));
            Command.Parameters.Add(new MDB.MDBParameter("TIENLUONG", BenhAnMatGlocom.TienLuong));
            Command.Parameters.Add(new MDB.MDBParameter("HUONGDIEUTRI", BenhAnMatGlocom.HuongDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("NGAYKHAMBENH", BenhAnMatGlocom.NgayKhamBenh));
            Command.Parameters.Add(new MDB.MDBParameter("BACSYLAMBENHAN", BenhAnMatGlocom.BacSyLamBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("XQUANG", BenhAnMatGlocom.HoSo.XQuang));
            Command.Parameters.Add(new MDB.MDBParameter("CTSCANNER", BenhAnMatGlocom.HoSo.CTScanner));
            Command.Parameters.Add(new MDB.MDBParameter("SIEUAM", BenhAnMatGlocom.HoSo.SieuAm));
            Command.Parameters.Add(new MDB.MDBParameter("XETNGHIEM", BenhAnMatGlocom.HoSo.XetNghiem));
            Command.Parameters.Add(new MDB.MDBParameter("KHAC", BenhAnMatGlocom.HoSo.Khac));
            Command.Parameters.Add(new MDB.MDBParameter("KHAC_TEXT", BenhAnMatGlocom.HoSo.Khac_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TOANBOHOSO", BenhAnMatGlocom.HoSo.ToanBoHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("QUATRINHBENHLYVADIENBIEN", BenhAnMatGlocom.QuaTrinhBenhLyVaDienBien));
            Command.Parameters.Add(new MDB.MDBParameter("TOMTATKETQUAXETNGHIEM", BenhAnMatGlocom.TomTatKetQuaXetNghiem));
            Command.Parameters.Add(new MDB.MDBParameter("PHUONGPHAPDIEUTRI", BenhAnMatGlocom.PhuongPhapDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("TINHTRANGNGUOIBENHRAVIEN", BenhAnMatGlocom.TinhTrangNguoiBenhRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("HUONGDIEUTRIVACACCHEDOTIEPTHEO", BenhAnMatGlocom.HuongDieuTriVaCacCheDoTiepTheo));
            Command.Parameters.Add(new MDB.MDBParameter("NGUOINHANHOSO", BenhAnMatGlocom.NguoiNhanHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NGUOIGIAOHOSO", BenhAnMatGlocom.NguoiGiaoHoSo));
            Command.Parameters.Add(new MDB.MDBParameter("NGAYTONGKET", BenhAnMatGlocom.NgayTongKet));
            Command.Parameters.Add(new MDB.MDBParameter("BACSYDIEUTRI", BenhAnMatGlocom.BacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("DIUNG", BenhAnMatGlocom.DacDiemLienQuanBenh.DiUng == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("DIUNG_TEXT", BenhAnMatGlocom.DacDiemLienQuanBenh.DiUng_Text));
            Command.Parameters.Add(new MDB.MDBParameter("MATUY", BenhAnMatGlocom.DacDiemLienQuanBenh.MaTuy == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("MATUY_TEXT", BenhAnMatGlocom.DacDiemLienQuanBenh.MaTuy_Text));
            Command.Parameters.Add(new MDB.MDBParameter("RUOUBIA", BenhAnMatGlocom.DacDiemLienQuanBenh.RuouBia == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("RUOUBIA_TEXT", BenhAnMatGlocom.DacDiemLienQuanBenh.RuouBia_Text));
            Command.Parameters.Add(new MDB.MDBParameter("THUOCLA", BenhAnMatGlocom.DacDiemLienQuanBenh.ThuocLa == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("THUOCLA_TEXT", BenhAnMatGlocom.DacDiemLienQuanBenh.ThuocLa_Text));
            Command.Parameters.Add(new MDB.MDBParameter("THUOCLAO", BenhAnMatGlocom.DacDiemLienQuanBenh.ThuocLao == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("THUOCLAO_TEXT", BenhAnMatGlocom.DacDiemLienQuanBenh.ThuocLao_Text));
            Command.Parameters.Add(new MDB.MDBParameter("KHAC_DACDIEMLIENQUANBENH", BenhAnMatGlocom.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("KHAC_DACDIEMLIENQUANBENH_TEXT", BenhAnMatGlocom.DacDiemLienQuanBenh.Khac_DacDiemLienQuanBenh_Text));
            Command.Parameters.Add(new MDB.MDBParameter("LYDODIKHAM_MP", BenhAnMatGlocom.LyDoDiKham_MP == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("LYDODIKHAM_MT", BenhAnMatGlocom.LyDoDiKham_MT == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("LYDODIKHAM_2MAT", BenhAnMatGlocom.LyDoDiKham_2Mat == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("NHUCMAT_DUDOI", BenhAnMatGlocom.NhucMat_DuDoi == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("NHUCMAT_VUA", BenhAnMatGlocom.NhucMat_Vua == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("NHUCMAT_NHE", BenhAnMatGlocom.NhucMat_Nhe == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("NHUCMAT_KHONG", BenhAnMatGlocom.NhucMat_Khong == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("NHIN_MODOTNGOT", BenhAnMatGlocom.Nhin_MoDotNgot == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("NHIN_MOTUNGLUC", BenhAnMatGlocom.Nhin_MoTungLuc == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("NHIN_SUONGMU", BenhAnMatGlocom.Nhin_SuongMu == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("NHIN_KHONGMO", BenhAnMatGlocom.Nhin_KhongMo == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("NHIN_MOTANGDAN", BenhAnMatGlocom.Nhin_MoTangDan == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("NHIN_NHINTHUHEP", BenhAnMatGlocom.Nhin_NhinThuHep == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("NHIN_QUANTANSAC", BenhAnMatGlocom.Nhin_QuanTanSac == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("SOANHSANGCHAYNUOCMAT_CO", BenhAnMatGlocom.SoAnhSangChayNuocMat_Co == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("SOANHSANGCHAYNUOCMAT_KHONG", BenhAnMatGlocom.SoAnhSangChayNuocMat_Khong == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("DOMAT_CO", BenhAnMatGlocom.DoMat_Co == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("DOMAT_KHONG", BenhAnMatGlocom.DoMat_Khong == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("TOANTHAN_DAUDAU", BenhAnMatGlocom.ToanThan_DauDau == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("TOANTHAN_NON", BenhAnMatGlocom.ToanThan_Non == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("TOANTHAN_BUONNON", BenhAnMatGlocom.ToanThan_BuonNon == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("TOANTHAN_KHONG", BenhAnMatGlocom.ToanThan_Khong == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("CACTRIEUCHUNGKHAC", BenhAnMatGlocom.CacTrieuChungKhac));
            Command.Parameters.Add(new MDB.MDBParameter("THOIGIANXUATHIENBENH", BenhAnMatGlocom.ThoiGianXuatHienBenh));
            Command.Parameters.Add(new MDB.MDBParameter("DAKHAMCHUABENH_HUYEN", BenhAnMatGlocom.DaKhamChuaBenh_Huyen == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("DAKHAMCHUABENH_TINH", BenhAnMatGlocom.DaKhamChuaBenh_Tinh == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("DAKHAMCHUABENH_TRUNGUONG", BenhAnMatGlocom.DaKhamChuaBenh_TrungUong == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("DAKHAMCHUABENH_KHAC", BenhAnMatGlocom.DaKhamChuaBenh_Khac == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("PHUONGPHAPDIEUTRI_PHAUTHUAT", BenhAnMatGlocom.PhuongPhapDieuTri_PhauThuat == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("PHUONGPHAPDIEUTRI_THUOC", BenhAnMatGlocom.PhuongPhapDieuTri_Thuoc == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("PHUONGPHAPDIEUTRI_LASER", BenhAnMatGlocom.PhuongPhapDieuTri_Laser == true ? 1 : 0));
            #region
            //Command.Parameters.Add(new MDB.MDBParameter("TIENSUBENHBANTHAN_BINHTHUONG", BenhAnMatGlocom.TienSuBenhBanThan_BinhThuong == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("TIENSUBENHBANTHAN_BENHLY", BenhAnMatGlocom.TienSuBenhBanThan_BenhLy == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("TIENSUBENHGIADINH_KHONG", BenhAnMatGlocom.TienSuBenhGiaDinh_Khong == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("TIENSUBENHGIADINH_CO", BenhAnMatGlocom.TienSuBenhGiaDinh_Co == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("THILUCKHIVAOVIEN_KHONGKINH_MP", BenhAnMatGlocom.ThiLucKhiVaoVien_KhongKinh_MP));
            //Command.Parameters.Add(new MDB.MDBParameter("THILUCKHIVAOVIEN_KHONGKINH_MT", BenhAnMatGlocom.ThiLucKhiVaoVien_KhongKinh_MT));
            //Command.Parameters.Add(new MDB.MDBParameter("THILUCKHIVAOVIEN_COKINH_MP", BenhAnMatGlocom.ThiLucKhiVaoVien_CoKinh_MP));
            //Command.Parameters.Add(new MDB.MDBParameter("THILUCKHIVAOVIEN_COKINH_MT", BenhAnMatGlocom.ThiLucKhiVaoVien_CoKinh_MT));
            //Command.Parameters.Add(new MDB.MDBParameter("NHANAPVAOVIEN_MT", BenhAnMatGlocom.NhanApVaoVien_MT));
            //Command.Parameters.Add(new MDB.MDBParameter("NHANAPVAOVIEN_MP", BenhAnMatGlocom.NhanApVaoVien_MP));
            //Command.Parameters.Add(new MDB.MDBParameter("THITRUONG_MP", BenhAnMatGlocom.ThiTruong_MP));
            //Command.Parameters.Add(new MDB.MDBParameter("THITRUONG_MT", BenhAnMatGlocom.ThiTruong_MT));
            //Command.Parameters.Add(new MDB.MDBParameter("VANNHANNOITAIMP_BINHTHUONG", BenhAnMatGlocom.VanNhanNoiTaiMP_BinhThuong == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("VANNHANNOITAIMP_BENHLY", BenhAnMatGlocom.VanNhanNoiTaiMP_BenhLy == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("VANNHANNOITAIMP", BenhAnMatGlocom.VanNhanNoiTaiMP));
            //Command.Parameters.Add(new MDB.MDBParameter("VANNHANNOITAIMT_BINHTHUONG", BenhAnMatGlocom.VanNhanNoiTaiMT_BinhThuong == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("VANNHANNOITAIMT_BENHLY", BenhAnMatGlocom.VanNhanNoiTaiMT_BenhLy == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("VANNHANNOITAIMT", BenhAnMatGlocom.VanNhanNoiTaiMT));
            //Command.Parameters.Add(new MDB.MDBParameter("DIEMCANQUYTU_BINHTHUONG", BenhAnMatGlocom.DiemCanQuyTu_BinhThuong == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("DIEMCANQUYTU_BENHLY", BenhAnMatGlocom.DiemCanQuyTu_BenhLy == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("DIEMCANQUYTU", BenhAnMatGlocom.DiemCanQuyTu));
            //Command.Parameters.Add(new MDB.MDBParameter("RUNGGIATNHANCAU_KHONG", BenhAnMatGlocom.RungGiatNhanCau_Khong == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("RUNGGIATNHANCAU_CO", BenhAnMatGlocom.RungGiatNhanCau_Co == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("RUNGGIATNHANCAU", BenhAnMatGlocom.RungGiatNhanCau));
            //Command.Parameters.Add(new MDB.MDBParameter("KIEURGNC", BenhAnMatGlocom.KieuRGNC));
            //Command.Parameters.Add(new MDB.MDBParameter("GOCHAM_KHONG", BenhAnMatGlocom.GocHam_Khong == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("GOCHAM_CO", BenhAnMatGlocom.GocHam_Co == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("THINGHIEMCHEMAT_TRATRONGRA", BenhAnMatGlocom.ThiNghiemCheMat_TraTrongRa == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("THINGHIEMCHEMAT_TRANGOAIVAO", BenhAnMatGlocom.ThiNghiemCheMat_TraNgoaiVao == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("THINGHIEMCHEMAT_TRATREO", BenhAnMatGlocom.ThiNghiemCheMat_TraTreo == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("HINHTHAIVATINHCHATLAC", BenhAnMatGlocom.HinhThaiVaTinhChatLac));
            //Command.Parameters.Add(new MDB.MDBParameter("HIRSCHBERG_TRUOC_ATROPINE", BenhAnMatGlocom.Hirschberg_Truoc_atropine));
            //Command.Parameters.Add(new MDB.MDBParameter("HIRSCHBERG_SAU_ATROPINE", BenhAnMatGlocom.Hirschberg_Sau_atropine));
            //Command.Parameters.Add(new MDB.MDBParameter("LANGKINH_TRUOC_ATROPINE", BenhAnMatGlocom.LangKinh_Truoc_atropine));
            //Command.Parameters.Add(new MDB.MDBParameter("LANGKINH_SAU_ATROPINE", BenhAnMatGlocom.LangKinh_Sau_atropine));
            //Command.Parameters.Add(new MDB.MDBParameter("NHINGAN", BenhAnMatGlocom.NhinGan));
            //Command.Parameters.Add(new MDB.MDBParameter("NHINXA", BenhAnMatGlocom.NhinXa));
            //Command.Parameters.Add(new MDB.MDBParameter("NHINLEN", BenhAnMatGlocom.NhinLen));
            //Command.Parameters.Add(new MDB.MDBParameter("NHINXUONG", BenhAnMatGlocom.NhinXuong));
            //Command.Parameters.Add(new MDB.MDBParameter("HOICHUNG", BenhAnMatGlocom.HoiChung));
            //Command.Parameters.Add(new MDB.MDBParameter("SYNOPTOPHORE_KHACQUAN", BenhAnMatGlocom.Synoptophore_KhacQuan));
            //Command.Parameters.Add(new MDB.MDBParameter("SYNOPTOPHORE_CHUQUAN", BenhAnMatGlocom.Synoptophore_ChuQuan));
            //Command.Parameters.Add(new MDB.MDBParameter("TINHTRANGTHIGIACHAIMAT_DONGTHI", BenhAnMatGlocom.TinhTrangThiGiacHaiMat_DongThi == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("TINHTRANGTHIGIACHAIMAT_HOPTHI", BenhAnMatGlocom.TinhTrangThiGiacHaiMat_HopThi == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("TINHTRANGTHIGIACHAIMAT_PHUTHI", BenhAnMatGlocom.TinhTrangThiGiacHaiMat_PhuThi == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("TINHTRANGTHIGIACHAIMAT", BenhAnMatGlocom.TinhTrangThiGiacHaiMat));
            //Command.Parameters.Add(new MDB.MDBParameter("BIENDOHOPTHI", BenhAnMatGlocom.BienDoHopThi));
            //Command.Parameters.Add(new MDB.MDBParameter("TUONGUNGVONGMAC_BINHTHUONG", BenhAnMatGlocom.TuongUngVongMac_BinhThuong == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("TUONGUNGVONGMAC_BATBINHTHUONG", BenhAnMatGlocom.TuongUngVongMac_BatBinhThuong == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("SONGTHI_KHONG", BenhAnMatGlocom.SongThi_Khong == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("SONGTHI_CO", BenhAnMatGlocom.SongThi_Co == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("SONGTHI", BenhAnMatGlocom.SongThi));
            //Command.Parameters.Add(new MDB.MDBParameter("TUTHEBUTRU_KHONG", BenhAnMatGlocom.TuTheBuTru_Khong == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("TUTHEBUTRU_CO", BenhAnMatGlocom.TuTheBuTru_Co == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("TUTHEBUTRU", BenhAnMatGlocom.TuTheBuTru));
            //Command.Parameters.Add(new MDB.MDBParameter("MIMATMP_BINHTHUONG", BenhAnMatGlocom.MiMatMP_BinhThuong == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("MIMATMP_BENHLY", BenhAnMatGlocom.MiMatMP_BenhLy == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("SUPMIMP", BenhAnMatGlocom.SupMiMP == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("SUPMIMP_DO1", BenhAnMatGlocom.SupMiMP_Do1 == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("SUPMIMP_DO2", BenhAnMatGlocom.SupMiMP_Do2 == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("SUPMIMP_DO3", BenhAnMatGlocom.SupMiMP_Do3 == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("EPICANTHUSMP_CO", BenhAnMatGlocom.EpicanthusMP_Co == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("EPICANTHUSMP_KHONG", BenhAnMatGlocom.EpicanthusMP_Khong == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("CONANGMIMP_TOT", BenhAnMatGlocom.CoNangMiMP_Tot == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("CONANGMIMP_TRUNGBINH", BenhAnMatGlocom.CoNangMiMP_TrungBinh == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("CONANGMIMP_KEM", BenhAnMatGlocom.CoNangMiMP_Kem == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("MARCUSGUNNMP_CO", BenhAnMatGlocom.MarcusgunnMP_Co == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("MARCUSGUNNMP_KHONG", BenhAnMatGlocom.MarcusgunnMP_Khong == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("BELLMP_CO", BenhAnMatGlocom.BellMP_Co == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("BELLMP_KHONG", BenhAnMatGlocom.BellMP_Khong == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("KHACMIMATMP", BenhAnMatGlocom.KhacMiMatMP));
            //Command.Parameters.Add(new MDB.MDBParameter("KETMACMP_BINHTHUONG", BenhAnMatGlocom.KetMacMP_BinhThuong == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("KETMACMP_BENHLY", BenhAnMatGlocom.KetMacMP_BenhLy == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("KETMACMP", BenhAnMatGlocom.KetMacMP));
            //Command.Parameters.Add(new MDB.MDBParameter("PHANNHANCAUTRUOCMP_BINHTHUONG", BenhAnMatGlocom.PhanNhanCauTruocMP_BinhThuong == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("PHANNHANCAUTRUOCMP_BENHLY", BenhAnMatGlocom.PhanNhanCauTruocMP_BenhLy == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("PHANNHANCAUTRUOCMP", BenhAnMatGlocom.PhanNhanCauTruocMP));
            //Command.Parameters.Add(new MDB.MDBParameter("PHANNHANCAUSAUMP_BINHTHUONG", BenhAnMatGlocom.PhanNhanCauSauMP_BinhThuong == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("PHANNHANCAUSAUMP_BENHLY", BenhAnMatGlocom.PhanNhanCauSauMP_BenhLy == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("PHANNHANCAUSAUMP", BenhAnMatGlocom.PhanNhanCauSauMP));
            //Command.Parameters.Add(new MDB.MDBParameter("DINHTHIMP_TRUNGTAM", BenhAnMatGlocom.DinhThiMP_TrungTam == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("DINHTHIMP_CANHTAM", BenhAnMatGlocom.DinhThiMP_CanhTam == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("DINHTHIMP_NGOAITAM", BenhAnMatGlocom.DinhThiMP_NgoaiTam == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("MIMATMT_BINHTHUONG", BenhAnMatGlocom.MiMatMT_BinhThuong == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("MIMATMT_BENHLY", BenhAnMatGlocom.MiMatMT_BenhLy == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("SUPMIMT", BenhAnMatGlocom.SupMiMT == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("SUPMIMT_DO1", BenhAnMatGlocom.SupMiMT_Do1 == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("SUPMIMT_DO2", BenhAnMatGlocom.SupMiMT_Do2 == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("SUPMIMT_DO3", BenhAnMatGlocom.SupMiMT_Do3 == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("EPICANTHUSMT_CO", BenhAnMatGlocom.EpicanthusMT_Co == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("EPICANTHUSMT_KHONG", BenhAnMatGlocom.EpicanthusMT_Khong == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("CONANGMIMT_TOT", BenhAnMatGlocom.CoNangMiMT_Tot == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("CONANGMIMT_TRUNGBINH", BenhAnMatGlocom.CoNangMiMT_TrungBinh == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("CONANGMIMT_KEM", BenhAnMatGlocom.CoNangMiMT_Kem == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("MARCUSGUNNMT_CO", BenhAnMatGlocom.MarcusgunnMT_Co == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("MARCUSGUNNMT_KHONG", BenhAnMatGlocom.MarcusgunnMT_Khong == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("BELLMT_CO", BenhAnMatGlocom.BellMT_Co == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("BELLMT_KHONG", BenhAnMatGlocom.BellMT_Khong == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("KHACMIMATMT", BenhAnMatGlocom.KhacMiMatMT));
            //Command.Parameters.Add(new MDB.MDBParameter("KETMACMT_BINHTHUONG", BenhAnMatGlocom.KetMacMT_BinhThuong == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("KETMACMT_BENHLY", BenhAnMatGlocom.KetMacMT_BenhLy == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("KETMACMT", BenhAnMatGlocom.KetMacMT));
            //Command.Parameters.Add(new MDB.MDBParameter("PHANNHANCAUTRUOCMT_BINHTHUONG", BenhAnMatGlocom.PhanNhanCauTruocMT_BinhThuong == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("PHANNHANCAUTRUOCMT_BENHLY", BenhAnMatGlocom.PhanNhanCauTruocMT_BenhLy == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("PHANNHANCAUTRUOCMT", BenhAnMatGlocom.PhanNhanCauTruocMT));
            //Command.Parameters.Add(new MDB.MDBParameter("PHANNHANCAUSAUMT_BINHTHUONG", BenhAnMatGlocom.PhanNhanCauSauMT_BinhThuong == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("PHANNHANCAUSAUMT_BENHLY", BenhAnMatGlocom.PhanNhanCauSauMT_BenhLy == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("PHANNHANCAUSAUMT", BenhAnMatGlocom.PhanNhanCauSauMT));
            //Command.Parameters.Add(new MDB.MDBParameter("DINHTHIMT_TRUNGTAM", BenhAnMatGlocom.DinhThiMT_TrungTam == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("DINHTHIMT_CANHTAM", BenhAnMatGlocom.DinhThiMT_CanhTam == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("DINHTHIMT_NGOAITAM", BenhAnMatGlocom.DinhThiMT_NgoaiTam == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("HUYETAP_TOANTHAN", BenhAnMatGlocom.HuyetAp_ToanThan));
            //Command.Parameters.Add(new MDB.MDBParameter("NHIETDO_TOANTHAN", BenhAnMatGlocom.NhietDo_ToanThan));
            //Command.Parameters.Add(new MDB.MDBParameter("MACH_TOANTHAN", BenhAnMatGlocom.Mach_ToanThan));
            //Command.Parameters.Add(new MDB.MDBParameter("NOITIET_BINHTHUONG", BenhAnMatGlocom.NoiTiet_BinhThuong == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("NOITIET_COBENH", BenhAnMatGlocom.NoiTiet_CoBenh == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("NOITIET", BenhAnMatGlocom.NoiTiet));
            //Command.Parameters.Add(new MDB.MDBParameter("THANKINH_BINHTHUONG", BenhAnMatGlocom.ThanKinh_BinhThuong == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("THANKINH_COBENH", BenhAnMatGlocom.ThanKinh_CoBenh == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("TUANHOAN_BINHTHUONG", BenhAnMatGlocom.TuanHoan_BinhThuong == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("TUANHOAN_COBENH", BenhAnMatGlocom.TuanHoan_CoBenh == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("HOHAP_BINHTHUONG", BenhAnMatGlocom.HoHap_BinhThuong == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("HOHAP_COBENH", BenhAnMatGlocom.HoHap_CoBenh == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("TIEUHOA_BINHTHUONG", BenhAnMatGlocom.TieuHoa_BinhThuong == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("TIEUHOA_COBENH", BenhAnMatGlocom.TieuHoa_CoBenh == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("COXUONGKHOP_BINHTHUONG", BenhAnMatGlocom.CoXuongKhop_BinhThuong == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("COXUONGKHOP_COBENH", BenhAnMatGlocom.CoXuongKhop_CoBenh == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("THANTIETNIEU_BINHTHUONG", BenhAnMatGlocom.ThanTietNieu_BinhThuong == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("THANTIETNIEU_COBENH", BenhAnMatGlocom.ThanTietNieu_CoBenh == true ? 1 : 0));
            //Command.Parameters.Add(new MDB.MDBParameter("PHUONGPHAPCHINH", BenhAnMatGlocom.PhuongPhapChinh));
            //Command.Parameters.Add(new MDB.MDBParameter("CHEDOANUONG", BenhAnMatGlocom.CheDoAnUong));
            //Command.Parameters.Add(new MDB.MDBParameter("CHEDOCHAMSOC", BenhAnMatGlocom.CheDoChamSoc));
            #endregion
            Command.Parameters.Add(new MDB.MDBParameter("PTTTMP_LOAI1", BenhAnMatGlocom.PTTTMP_Loai1));
            Command.Parameters.Add(new MDB.MDBParameter("PTTTMP_LOAI2", BenhAnMatGlocom.PTTTMP_Loai2));
            Command.Parameters.Add(new MDB.MDBParameter("PTTTMP_LOAI3", BenhAnMatGlocom.PTTTMP_Loai3));
            Command.Parameters.Add(new MDB.MDBParameter("PTTTMP_LOAI4", BenhAnMatGlocom.PTTTMP_Loai4));
            Command.Parameters.Add(new MDB.MDBParameter("PTTTMT_LOAI1", BenhAnMatGlocom.PTTTMT_Loai1));
            Command.Parameters.Add(new MDB.MDBParameter("PTTTMT_LOAI2", BenhAnMatGlocom.PTTTMT_Loai2));
            Command.Parameters.Add(new MDB.MDBParameter("PTTTMT_LOAI3", BenhAnMatGlocom.PTTTMT_Loai3));
            Command.Parameters.Add(new MDB.MDBParameter("PTTTMT_LOAI4", BenhAnMatGlocom.PTTTMT_Loai4));
            Command.Parameters.Add(new MDB.MDBParameter("PTTTMP_THOIDIEM1", BenhAnMatGlocom.PTTTMP_ThoiDiem1));
            Command.Parameters.Add(new MDB.MDBParameter("PTTTMP_THOIDIEM2", BenhAnMatGlocom.PTTTMP_ThoiDiem2));
            Command.Parameters.Add(new MDB.MDBParameter("PTTTMP_THOIDIEM3", BenhAnMatGlocom.PTTTMP_ThoiDiem3));
            Command.Parameters.Add(new MDB.MDBParameter("PTTTMP_THOIDIEM4", BenhAnMatGlocom.PTTTMP_ThoiDiem4));
            Command.Parameters.Add(new MDB.MDBParameter("PTTTMT_THOIDIEM1", BenhAnMatGlocom.PTTTMT_ThoiDiem1));
            Command.Parameters.Add(new MDB.MDBParameter("PTTTMT_THOIDIEM2", BenhAnMatGlocom.PTTTMT_ThoiDiem2));
            Command.Parameters.Add(new MDB.MDBParameter("PTTTMT_THOIDIEM3", BenhAnMatGlocom.PTTTMT_ThoiDiem3));
            Command.Parameters.Add(new MDB.MDBParameter("PTTTMT_THOIDIEM4", BenhAnMatGlocom.PTTTMT_ThoiDiem4));
            Command.Parameters.Add(new MDB.MDBParameter("PTTTMP_NOI1", BenhAnMatGlocom.PTTTMP_Noi1));
            Command.Parameters.Add(new MDB.MDBParameter("PTTTMP_NOI2", BenhAnMatGlocom.PTTTMP_Noi2));
            Command.Parameters.Add(new MDB.MDBParameter("PTTTMP_NOI3", BenhAnMatGlocom.PTTTMP_Noi3));
            Command.Parameters.Add(new MDB.MDBParameter("PTTTMP_NOI4", BenhAnMatGlocom.PTTTMP_Noi4));
            Command.Parameters.Add(new MDB.MDBParameter("PTTTMT_NOI1", BenhAnMatGlocom.PTTTMT_Noi1));
            Command.Parameters.Add(new MDB.MDBParameter("PTTTMT_NOI2", BenhAnMatGlocom.PTTTMT_Noi2));
            Command.Parameters.Add(new MDB.MDBParameter("PTTTMT_NOI3", BenhAnMatGlocom.PTTTMT_Noi3));
            Command.Parameters.Add(new MDB.MDBParameter("PTTTMT_NOI4", BenhAnMatGlocom.PTTTMT_Noi4));
            Command.Parameters.Add(new MDB.MDBParameter("THUOCHANHANAP_UONG", BenhAnMatGlocom.ThuocHaNhanAp_Uong == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("THUOCHANHANAP_TRAMAT", BenhAnMatGlocom.ThuocHaNhanAp_TraMat == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("THUOCHANHANAP_TIEM", BenhAnMatGlocom.ThuocHaNhanAp_Tiem == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("THUOCHANHANAP_1THUOC", BenhAnMatGlocom.ThuocHaNhanAp_1Thuoc == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("THUOCHANHANAP_2THUOC", BenhAnMatGlocom.ThuocHaNhanAp_2Thuoc == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("THUOCHANHANAP_3THUOC", BenhAnMatGlocom.ThuocHaNhanAp_3Thuoc == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("THUOCHANHANAP_4THUOC", BenhAnMatGlocom.ThuocHaNhanAp_4Thuoc == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("THUOCHANHANAPDADUNG", JsonConvert.SerializeObject(BenhAnMatGlocom.ThuocHaNhanApDaDung)));
            Command.Parameters.Add(new MDB.MDBParameter("CACTHUOCKHAC", BenhAnMatGlocom.CacThuocKhac));
            Command.Parameters.Add(new MDB.MDBParameter("TIENTRINHDIEUTRI", BenhAnMatGlocom.TienTrinhDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("TIENSUKHAC_CANTHI", BenhAnMatGlocom.TienSuKhac_CanThi == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("TIENSUKHAC_VIENTHI", BenhAnMatGlocom.TienSuKhac_VienThi == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("TIENSUKHAC_TRANTHUONG", BenhAnMatGlocom.TienSuKhac_TranThuong == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("TIENSUKHAC_VIENMANGBODAO", BenhAnMatGlocom.TienSuKhac_VienMangBoDao == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("TIENSUKHAC_VIENPHANTRUOCNHACAU", BenhAnMatGlocom.TienSuKhac_VienPhanTruocNhaCau == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("TIENSUKHAC_TACTMTTVM", BenhAnMatGlocom.TienSuKhac_TacTMTTVM == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("TIENSUKHAC_DAPTMAT", BenhAnMatGlocom.TienSuKhac_DaPTMat == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("TIENSUKHAC_BENHKHAC", BenhAnMatGlocom.TienSuKhac_BenhKhac == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("TIENSUKHAC_CORTICOSTEROID", BenhAnMatGlocom.TienSuKhac_Corticosteroid));
            Command.Parameters.Add(new MDB.MDBParameter("THOIGIANSUDUNG_CORTICOSTEROID", BenhAnMatGlocom.ThoiGianSuDung_Corticosteroid));
            Command.Parameters.Add(new MDB.MDBParameter("CORTICOSTEROID_TRAMAT", BenhAnMatGlocom.Corticosteroid_TraMat == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("CORTICOSTEROID_TIEMMAT", BenhAnMatGlocom.Corticosteroid_TiemMat == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("CORTICOSTEROID_TOANTHAN", BenhAnMatGlocom.Corticosteroid_ToanThan == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("CORTICOSTEROID_THEOCDCUABACSI", BenhAnMatGlocom.Corticosteroid_TheoCDCuaBacSi == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("CORTICOSTEROID_BNTUDUNGTHUOC", BenhAnMatGlocom.Corticosteroid_BNTuDungThuoc == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("TIENSUTOANTHAN_TIMMACH", BenhAnMatGlocom.TienSuToanThan_TimMach == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("TIENSUTOANTHAN_HUYETAP", BenhAnMatGlocom.TienSuToanThan_HuyetAp == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("TIENSUTOANTHAN_DAIDUONG", BenhAnMatGlocom.TienSuToanThan_DaiDuong == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("TIENSUTOANTHAN_RODONGMACHCANH", BenhAnMatGlocom.TienSuToanThan_RoDongMachCanh == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("TIENSUTOANTHAN_BENHKHAC", BenhAnMatGlocom.TienSuToanThan_BenhKhac == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("TIENSUGLOCOMGIADINH_ONGBA", BenhAnMatGlocom.TienSuGlocomGiaDinh_OngBa == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("TIENSUGLOCOMGIADINH_BOME", BenhAnMatGlocom.TienSuGlocomGiaDinh_BoMe == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("TIENSUGLOCOMGIADINH_ANHCHIEM", BenhAnMatGlocom.TienSuGlocomGiaDinh_AnhChiEm == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("TIENSUGLOCOMGIADINH_CODICHUBAC", BenhAnMatGlocom.TienSuGlocomGiaDinh_CoDiChuBac == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("THILUCVAOVIENMP_KHONGKINH", BenhAnMatGlocom.ThiLucVaoVienMP_KhongKinh));
            Command.Parameters.Add(new MDB.MDBParameter("THILUCVAOVIENMT_KHONGKINH", BenhAnMatGlocom.ThiLucVaoVienMT_KhongKinh));
            Command.Parameters.Add(new MDB.MDBParameter("THILUCVAOVIENMP_COKINH", BenhAnMatGlocom.ThiLucVaoVienMP_CoKinh));
            Command.Parameters.Add(new MDB.MDBParameter("THILUCVAOVIENMT_COKINH", BenhAnMatGlocom.ThiLucVaoVienMT_CoKinh));
            Command.Parameters.Add(new MDB.MDBParameter("NHAAPMP", BenhAnMatGlocom.NhaApMP));
            Command.Parameters.Add(new MDB.MDBParameter("NHAAPMT", BenhAnMatGlocom.NhaApMT));
            Command.Parameters.Add(new MDB.MDBParameter("MIMATSUNGNEMP_KHONG", BenhAnMatGlocom.MiMatSungNeMP_Khong == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("MIMATSUNGNEMP_CO", BenhAnMatGlocom.MiMatSungNeMP_Co == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("MIMATSUNGNEMT_KHONG", BenhAnMatGlocom.MiMatSungNeMT_Khong == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("MIMATSUNGNEMT_CO", BenhAnMatGlocom.MiMatSungNeMT_Co == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("NHANAPMP_KHAC", BenhAnMatGlocom.NhanApMP_Khac));
            Command.Parameters.Add(new MDB.MDBParameter("NHANAPMT_KHAC", BenhAnMatGlocom.NhanApMT_Khac));
            Command.Parameters.Add(new MDB.MDBParameter("KETMACCUONGTUMP_KHONG", BenhAnMatGlocom.KetMacCuongTuMP_Khong == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("KETMACCUONGTUMP_CO", BenhAnMatGlocom.KetMacCuongTuMP_Co == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("KETMACCUONGTUMT_KHONG", BenhAnMatGlocom.KetMacCuongTuMT_Khong == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("KETMACCUONGTUMT_CO", BenhAnMatGlocom.KetMacCuongTuMT_Co == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("KETMACSEOMOCUMP_KHONG", BenhAnMatGlocom.KetMacSeoMoCuMP_Khong == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("KETMACSEOMOCUMP_CO", BenhAnMatGlocom.KetMacSeoMoCuMP_Co == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("KETMACSEOMOCUMT_KHONG", BenhAnMatGlocom.KetMacSeoMoCuMT_Khong == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("KETMACSEOMOCUMT_CO", BenhAnMatGlocom.KetMacSeoMoCuMT_Co == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("KETMACBONDOMP_TOT", BenhAnMatGlocom.KetMacBonDoMP_Tot == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("KETMACBONDOMP_DEP", BenhAnMatGlocom.KetMacBonDoMP_Dep == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("KETMACBONDOMP_XO", BenhAnMatGlocom.KetMacBonDoMP_Xo == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("KETMACBONDOMP_MONG", BenhAnMatGlocom.KetMacBonDoMP_Mong == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("KETMACBONDOMP_QUAPHAT", BenhAnMatGlocom.KetMacBonDoMP_QuaPhat == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("KETMACBONDOMT_TOT", BenhAnMatGlocom.KetMacBonDoMT_Tot == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("KETMACBONDOMT_DEP", BenhAnMatGlocom.KetMacBonDoMT_Dep == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("KETMACBONDOMT_XO", BenhAnMatGlocom.KetMacBonDoMT_Xo == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("KETMACBONDOMT_MONG", BenhAnMatGlocom.KetMacBonDoMT_Mong == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("KETMACBONDOMT_QUAPHAT", BenhAnMatGlocom.KetMacBonDoMT_QuaPhat == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("GIACMACTRONGSUATMP_TRONG", BenhAnMatGlocom.GiacMacTrongSuatMP_Trong == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("GIACMACTRONGSUATMP_SEO", BenhAnMatGlocom.GiacMacTrongSuatMP_Seo == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("GIACMACTRONGSUATMP_LOANDUONG", BenhAnMatGlocom.GiacMacTrongSuatMP_LoanDuong == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("GIACMACPHUNEMP_KHONG", BenhAnMatGlocom.GiacMacPhuNeMP_Khong == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("GIACMACPHUNEMP_CO", BenhAnMatGlocom.GiacMacPhuNeMP_Co == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("GIACMACTRONGSUATMT_TRONG", BenhAnMatGlocom.GiacMacTrongSuatMT_Trong == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("GIACMACTRONGSUATMT_SEO", BenhAnMatGlocom.GiacMacTrongSuatMT_Seo == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("GIACMACTRONGSUATMT_LOANDUONG", BenhAnMatGlocom.GiacMacTrongSuatMT_LoanDuong == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("GIACMACPHUNEMT_KHONG", BenhAnMatGlocom.GiacMacPhuNeMT_Khong == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("GIACMACPHUNEMT_CO", BenhAnMatGlocom.GiacMacPhuNeMT_Co == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("GIACMACDODAYGIACMACMP", BenhAnMatGlocom.GiacMacDoDayGiacMacMP));
            Command.Parameters.Add(new MDB.MDBParameter("GIACMACDODAYGIACMACMT", BenhAnMatGlocom.GiacMacDoDayGiacMacMT));
            Command.Parameters.Add(new MDB.MDBParameter("GIACMACTUMP", BenhAnMatGlocom.GiacMacTuMP));
            Command.Parameters.Add(new MDB.MDBParameter("GIACMACTUMT", BenhAnMatGlocom.GiacMacTuMT));
            Command.Parameters.Add(new MDB.MDBParameter("GIACMACDUONGKINHGIACMACMP", BenhAnMatGlocom.GiacMacDuongKinhGiacMacMP));
            Command.Parameters.Add(new MDB.MDBParameter("GIACMACDUONGKINHGIACMACMT", BenhAnMatGlocom.GiacMacDuongKinhGiacMacMT));
            Command.Parameters.Add(new MDB.MDBParameter("CUNGMACDANLOIMP_KHONG", BenhAnMatGlocom.CungMacDanLoiMP_Khong == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("CUNGMACDANLOIMP_CO", BenhAnMatGlocom.CungMacDanLoiMP_Co == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("CUNGMACDANLOIMT_KHONG", BenhAnMatGlocom.CungMacDanLoiMT_Khong == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("CUNGMACDANLOIMT_CO", BenhAnMatGlocom.CungMacDanLoiMT_Co == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("CUNGMASEOMOMP_KHONG", BenhAnMatGlocom.CungMaSeoMoMP_Khong == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("CUNGMASEOMOMP_CO", BenhAnMatGlocom.CungMaSeoMoMP_Co == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("CUNGMASEOMOMT_KHONG", BenhAnMatGlocom.CungMaSeoMoMT_Khong == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("CUNGMASEOMOMT_CO", BenhAnMatGlocom.CungMaSeoMoMT_Co == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("TIENPHONGDOSAUMP", BenhAnMatGlocom.TienPhongDoSauMP));
            Command.Parameters.Add(new MDB.MDBParameter("TIENPHONGDOSAUMT", BenhAnMatGlocom.TienPhongDoSauMT));
            Command.Parameters.Add(new MDB.MDBParameter("GOCTIENPHONGDAUHIEUKHACMP", BenhAnMatGlocom.GocTienPhongDauHieuKhacMP));
            Command.Parameters.Add(new MDB.MDBParameter("GOCTIENPHONGDAUHIEUKHACMT", BenhAnMatGlocom.GocTienPhongDauHieuKhacMT));
            Command.Parameters.Add(new MDB.MDBParameter("MONGMATMAUSACMP", BenhAnMatGlocom.MongMatMauSacMP));
            Command.Parameters.Add(new MDB.MDBParameter("MONGMATMAUSACMT", BenhAnMatGlocom.MongMatMauSacMT));
            Command.Parameters.Add(new MDB.MDBParameter("MONGMATTHAIHOAMP_KHONG", BenhAnMatGlocom.MongMatThaiHoaMP_Khong == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("MONGMATTHAIHOAMP_CO", BenhAnMatGlocom.MongMatThaiHoaMP_Co == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("MONGMATTHAIHOAMT_KHONG", BenhAnMatGlocom.MongMatThaiHoaMT_Khong == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("MONGMATTHAIHOAMT_CO", BenhAnMatGlocom.MongMatThaiHoaMT_Co == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("MONGMATTANMACHMP_KHONG", BenhAnMatGlocom.MongMatTanMachMP_Khong == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("MONGMATTANMACHMP_CO", BenhAnMatGlocom.MongMatTanMachMP_Co == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("MONGMATTANMACHMT_KHONG", BenhAnMatGlocom.MongMatTanMachMT_Khong == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("MONGMATTANMACHMT_CO", BenhAnMatGlocom.MongMatTanMachMT_Co == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("DONGTUMP_TRON", BenhAnMatGlocom.DongTuMP_Tron == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("DONGTUMP_MEO", BenhAnMatGlocom.DongTuMP_Meo == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("DONGTUMT_TRON", BenhAnMatGlocom.DongTuMT_Tron == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("DONGTUMT_MEO", BenhAnMatGlocom.DongTuMT_Meo == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("DONGTUDUONGKINHMP", BenhAnMatGlocom.DongTuDuongKinhMP));
            Command.Parameters.Add(new MDB.MDBParameter("DONGTUDUONGKINHMT", BenhAnMatGlocom.DongTuDuongKinhMT));
            Command.Parameters.Add(new MDB.MDBParameter("DONGTUVIENSACTOMP", BenhAnMatGlocom.DongTuVienSacToMP));
            Command.Parameters.Add(new MDB.MDBParameter("DONGTUVIENSACTOMT", BenhAnMatGlocom.DongTuVienSacToMT));
            Command.Parameters.Add(new MDB.MDBParameter("DONGTUPHANXAMP_BINHTHUONG", BenhAnMatGlocom.DongTuPhanXaMP_BinhThuong == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("DONGTUPHANXAMP_GIAM", BenhAnMatGlocom.DongTuPhanXaMP_Giam == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("DONGTUPHANXAMP_MAT", BenhAnMatGlocom.DongTuPhanXaMP_Mat == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("DONGTUPHANXAMT_BINHTHUONG", BenhAnMatGlocom.DongTuPhanXaMT_BinhThuong == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("DONGTUPHANXAMT_GIAM", BenhAnMatGlocom.DongTuPhanXaMT_Giam == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("DONGTUPHANXAMT_MAT", BenhAnMatGlocom.DongTuPhanXaMT_Mat == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("THETHUYTINHMP_TRONG", BenhAnMatGlocom.TheThuyTinhMP_Trong == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("THETHUYTINHMP_DUC", BenhAnMatGlocom.TheThuyTinhMP_Duc == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("THETHUYTINHMT_TRONG", BenhAnMatGlocom.TheThuyTinhMT_Trong == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("THETHUYTINHMT_DUC", BenhAnMatGlocom.TheThuyTinhMT_Duc == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("DICHMP", BenhAnMatGlocom.DichMP));
            Command.Parameters.Add(new MDB.MDBParameter("DICHMT", BenhAnMatGlocom.DichMT));
            Command.Parameters.Add(new MDB.MDBParameter("DAYMATVONGMACMP", BenhAnMatGlocom.DayMatVongMacMP));
            Command.Parameters.Add(new MDB.MDBParameter("DAYMATVONGMACMT", BenhAnMatGlocom.DayMatVongMacMT));
            Command.Parameters.Add(new MDB.MDBParameter("DAYMATHOANGDIEMMP", BenhAnMatGlocom.DayMatHoangDiemMP));
            Command.Parameters.Add(new MDB.MDBParameter("DAYMATHOANGDIEMMT", BenhAnMatGlocom.DayMatHoangDiemMT));
            Command.Parameters.Add(new MDB.MDBParameter("DAYMATTANMACHMP_KHONG", BenhAnMatGlocom.DayMatTanMachMP_Khong == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("DAYMATTANMACHMP_CO", BenhAnMatGlocom.DayMatTanMachMP_Co == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("DAYMATTANMACHMT_KHONG", BenhAnMatGlocom.DayMatTanMachMT_Khong == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("DAYMATTANMACHMT_CO", BenhAnMatGlocom.DayMatTanMachMT_Co == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("DAYMATXUATHUYETMP_KHONG", BenhAnMatGlocom.DayMatXuatHuyetMP_Khong == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("DAYMATXUATHUYETMP_CO", BenhAnMatGlocom.DayMatXuatHuyetMP_Co == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("DAYMATXUATHUYETMT_KHONG", BenhAnMatGlocom.DayMatXuatHuyetMT_Khong == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("DAYMATXUATHUYETMT_CO", BenhAnMatGlocom.DayMatXuatHuyetMT_Co == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("DAYMATVIENTHANKINHMP_KHONG", BenhAnMatGlocom.DayMatVienThanKinhMP_Khong == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("DAYMATVIENTHANKINHMP_CO", BenhAnMatGlocom.DayMatVienThanKinhMP_Co == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("DAYMATVIENTHANKINHMT_KHONG", BenhAnMatGlocom.DayMatVienThanKinhMT_Khong == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("DAYMATVIENTHANKINHMT_CO", BenhAnMatGlocom.DayMatVienThanKinhMT_Co == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("DIATHIGIAVIENTHANKINHMP_DUOI", BenhAnMatGlocom.DiaThiGiaVienThanKinhMP_Duoi == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("DIATHIGIAVIENTHANKINHMP_TREN", BenhAnMatGlocom.DiaThiGiaVienThanKinhMP_Tren == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("DIATHIGIAVIENTHANKINHMP_MUI", BenhAnMatGlocom.DiaThiGiaVienThanKinhMP_Mui == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("DIATHIGIAVIENTHANKINHMP_TDUONG", BenhAnMatGlocom.DiaThiGiaVienThanKinhMP_TDuong == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("DIATHIGIAVIENTHANKINHMT_DUOI", BenhAnMatGlocom.DiaThiGiaVienThanKinhMT_Duoi == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("DIATHIGIAVIENTHANKINHMT_TREN", BenhAnMatGlocom.DiaThiGiaVienThanKinhMT_Tren == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("DIATHIGIAVIENTHANKINHMT_MUI", BenhAnMatGlocom.DiaThiGiaVienThanKinhMT_Mui == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("DIATHIGIAVIENTHANKINHMT_TDUONG", BenhAnMatGlocom.DiaThiGiaVienThanKinhMT_TDuong == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("DIATHIGIACMAUSACMP", BenhAnMatGlocom.DiaThiGiacMauSacMP));
            Command.Parameters.Add(new MDB.MDBParameter("DIATHIGIACMAUSACMT", BenhAnMatGlocom.DiaThiGiacMauSacMT));
            Command.Parameters.Add(new MDB.MDBParameter("DIATHIGIACCDMP", BenhAnMatGlocom.DiaThiGiacCDMP));
            Command.Parameters.Add(new MDB.MDBParameter("DIATHIGIACCDMT", BenhAnMatGlocom.DiaThiGiacCDMT));
            Command.Parameters.Add(new MDB.MDBParameter("DIATHIGIACMACHMAUMP_BINHTHUONG", BenhAnMatGlocom.DiaThiGiacMachMauMP_BinhThuong == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("DIATHIGIACMACHMAUMP_CHHUONG", BenhAnMatGlocom.DiaThiGiacMachMauMP_ChHuong == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("DIATHIGIACMACHMAUMP_GAPGOC", BenhAnMatGlocom.DiaThiGiacMachMauMP_GapGoc == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("DIATHIGIACMACHMAUMT_BINHTHUONG", BenhAnMatGlocom.DiaThiGiacMachMauMT_BinhThuong == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("DIATHIGIACMACHMAUMT_CHHUONG", BenhAnMatGlocom.DiaThiGiacMachMauMT_ChHuong == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("DIATHIGIACMACHMAUMT_GAPGOC", BenhAnMatGlocom.DiaThiGiacMachMauMT_GapGoc == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("DIATHIGIACXUATHUETMP_KHONG", BenhAnMatGlocom.DiaThiGiacXuatHuetMP_Khong == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("DIATHIGIACXUATHUETMP_CO", BenhAnMatGlocom.DiaThiGiacXuatHuetMP_Co == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("DIATHIGIACXUATHUETMT_KHONG", BenhAnMatGlocom.DiaThiGiacXuatHuetMT_Khong == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("DIATHIGIACXUATHUETMT_CO", BenhAnMatGlocom.DiaThiGiacXuatHuetMT_Co == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("DIATHIGIACTEOCANHGAIMP_KHONG", BenhAnMatGlocom.DiaThiGiacTeoCanhGaiMP_Khong == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("DIATHIGIACTEOCANHGAIMP_CO", BenhAnMatGlocom.DiaThiGiacTeoCanhGaiMP_Co == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("DIATHIGIACTEOCANHGAIMT_KHONG", BenhAnMatGlocom.DiaThiGiacTeoCanhGaiMT_Khong == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("DIATHIGIACTEOCANHGAIMT_CO", BenhAnMatGlocom.DiaThiGiacTeoCanhGaiMT_Co == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("VANNHANMP", BenhAnMatGlocom.VanNhanMP));
            Command.Parameters.Add(new MDB.MDBParameter("VANNHANMT", BenhAnMatGlocom.VanNhanMT));
            Command.Parameters.Add(new MDB.MDBParameter("NHANCAUMP_BINHTHUONG", BenhAnMatGlocom.NhanCauMP_BinhThuong == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("NHANCAUMP_DANNOI", BenhAnMatGlocom.NhanCauMP_DanNoi == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("NHANCAUMP_TO", BenhAnMatGlocom.NhanCauMP_To == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("NHANCAUMP_NHO", BenhAnMatGlocom.NhanCauMP_Nho == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("NHANCAUMT_BINHTHUONG", BenhAnMatGlocom.NhanCauMT_BinhThuong == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("NHANCAUMT_DANNOI", BenhAnMatGlocom.NhanCauMT_DanNoi == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("NHANCAUMT_TO", BenhAnMatGlocom.NhanCauMT_To == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("NHANCAUMT_NHO", BenhAnMatGlocom.NhanCauMT_Nho == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("HOCMATMP", BenhAnMatGlocom.HocMatMP));
            Command.Parameters.Add(new MDB.MDBParameter("HOCMATMT", BenhAnMatGlocom.HocMatMT));
            Command.Parameters.Add(new MDB.MDBParameter("TOANTHANHUYETAP", BenhAnMatGlocom.ToanThanHuyetAp));
            Command.Parameters.Add(new MDB.MDBParameter("TOANTHANNHIETDO", BenhAnMatGlocom.ToanThanNhietDo));
            Command.Parameters.Add(new MDB.MDBParameter("TOANTHANMACH", BenhAnMatGlocom.ToanThanMach));
            Command.Parameters.Add(new MDB.MDBParameter("NOITIET_BINHTHUONG", BenhAnMatGlocom.NoiTiet_BinhThuong == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("NOITIET_COBENH", BenhAnMatGlocom.NoiTiet_CoBenh == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("THANKINH_BINHTHUONG", BenhAnMatGlocom.ThanKinh_BinhThuong == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("THANKINH_COBENH", BenhAnMatGlocom.ThanKinh_CoBenh == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("TUANHOAN_BINHTHUONG", BenhAnMatGlocom.TuanHoan_BinhThuong == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("TUANHOAN_COBENH", BenhAnMatGlocom.TuanHoan_CoBenh == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("HOHAP_BINHTHUONG", BenhAnMatGlocom.HoHap_BinhThuong == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("HOHAP_COBENH", BenhAnMatGlocom.HoHap_CoBenh == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("TIEUHOA_BINHTHUONG", BenhAnMatGlocom.TieuHoa_BinhThuong == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("TIEUHOA_COBENH", BenhAnMatGlocom.TieuHoa_CoBenh == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("COXUONGKHOP_BINHTHUONG", BenhAnMatGlocom.CoXuongKhop_BinhThuong == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("COXUONGKHOP_COBENH", BenhAnMatGlocom.CoXuongKhop_CoBenh == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("TIETNIEUSINHDUC_BINHTHUONG", BenhAnMatGlocom.TietNieuSinhDuc_BinhThuong == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("TIETNIEUSINHDUC_COBENH", BenhAnMatGlocom.TietNieuSinhDuc_CoBenh == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("BENHCHINHMP", BenhAnMatGlocom.BenhChinhMP));
            Command.Parameters.Add(new MDB.MDBParameter("BENHCHINHMT", BenhAnMatGlocom.BenhChinhMT));
            Command.Parameters.Add(new MDB.MDBParameter("BENHKEMTHEOMP", BenhAnMatGlocom.BenhKemTheoMP));
            Command.Parameters.Add(new MDB.MDBParameter("BENHKEMTHEOMT", BenhAnMatGlocom.BenhKemTheoMT));
            Command.Parameters.Add(new MDB.MDBParameter("BENHTOANTHAN", BenhAnMatGlocom.BenhToanThan));
            Command.Parameters.Add(new MDB.MDBParameter("CHIDINHDIEUTRI", BenhAnMatGlocom.ChiDinhDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("TIENSUKHAC_COR", BenhAnMatGlocom.TienSuKhac_Cor == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("TIENSUKHAC_DAPTMAT_TEXT", BenhAnMatGlocom.TienSuKhac_DaPTMat_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TIENSUBENHTOANTHAN_BENHKHAC", BenhAnMatGlocom.TienSuBenhToanThan_BenhKhac));
            Command.Parameters.Add(new MDB.MDBParameter("KETMACSEOMOCUMP", BenhAnMatGlocom.KetMacSeoMoCuMP));
            Command.Parameters.Add(new MDB.MDBParameter("KETMACSEOMOCUMT", BenhAnMatGlocom.KetMacSeoMoCuMT));
            Command.Parameters.Add(new MDB.MDBParameter("GIACMACPHUNEMP", BenhAnMatGlocom.GiacMacPhuNeMP));
            Command.Parameters.Add(new MDB.MDBParameter("GIACMACPHUNEMT", BenhAnMatGlocom.GiacMacPhuNeMT));
            Command.Parameters.Add(new MDB.MDBParameter("MONGMATTHAIHOAMP", BenhAnMatGlocom.MongMatThaiHoaMP));
            Command.Parameters.Add(new MDB.MDBParameter("MONGMATTHAIHOAMT", BenhAnMatGlocom.MongMatThaiHoaMT));
            Command.Parameters.Add(new MDB.MDBParameter("NOITIET", BenhAnMatGlocom.NoiTiet));
            Command.Parameters.Add(new MDB.MDBParameter("CUNGMASEOMOMP", BenhAnMatGlocom.CungMaSeoMoMP));
            Command.Parameters.Add(new MDB.MDBParameter("CUNGMASEOMOMT", BenhAnMatGlocom.CungMaSeoMoMT));
            Command.Parameters.Add(new MDB.MDBParameter("THETHUYTINHMP_NHAN", BenhAnMatGlocom.TheThuyTinhMP_Nhan == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("THETHUYTINHMP_VO", BenhAnMatGlocom.TheThuyTinhMP_Vo == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("THETHUYTINHMP_DUOIBAO", BenhAnMatGlocom.TheThuyTinhMP_DuoiBao == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("THETHUYTINHMP_TOANBO", BenhAnMatGlocom.TheThuyTinhMP_ToanBo == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("THETHUYTINHMT_NHAN", BenhAnMatGlocom.TheThuyTinhMT_Nhan == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("THETHUYTINHMT_VO", BenhAnMatGlocom.TheThuyTinhMT_Vo == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("THETHUYTINHMT_DUOIBAO", BenhAnMatGlocom.TheThuyTinhMT_DuoiBao == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("THETHUYTINHMT_TOANBO", BenhAnMatGlocom.TheThuyTinhMT_ToanBo == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("TIENSUKHAC_BENHKHAC_TEXT", BenhAnMatGlocom.TienSuKhac_BenhKhac_Text));
            Command.Parameters.Add(new MDB.MDBParameter("CHANDOANRAVIEN_MATPHAI", BenhAnMatGlocom.ChanDoanRaVien_MatPhai));
            Command.Parameters.Add(new MDB.MDBParameter("MACHANDOANRAVIEN_MATPHAI", BenhAnMatGlocom.MaChanDoanRaVien_MatPhai));
            Command.Parameters.Add(new MDB.MDBParameter("CHANDOANRAVIEN_MATTRAI", BenhAnMatGlocom.ChanDoanRaVien_MatTrai));
            Command.Parameters.Add(new MDB.MDBParameter("MACHANDOANRAVIEN_MATTRAI", BenhAnMatGlocom.MaChanDoanRaVien_MatTrai));
            Command.Parameters.Add(new MDB.MDBParameter("PPDT_PHAUTHUAT", BenhAnMatGlocom.PPDT_PhauThuat == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("PPDT_PHAUTHUATTEXT", BenhAnMatGlocom.PPDT_PhauThuatText));
            Command.Parameters.Add(new MDB.MDBParameter("PPDT_THUOC", BenhAnMatGlocom.PPDT_Thuoc == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("PPDT_THUOCTEXT", BenhAnMatGlocom.PPDT_ThuocText));
            Command.Parameters.Add(new MDB.MDBParameter("PPDT_LASER", BenhAnMatGlocom.PPDT_Laser == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("PPDT_LASERTEXT", BenhAnMatGlocom.PPDT_LaserText));
            Command.Parameters.Add(new MDB.MDBParameter("TINHTRANGRAVIEN_MATPHAI", BenhAnMatGlocom.TinhTrangRaVien_MatPhai));
            Command.Parameters.Add(new MDB.MDBParameter("TINHTRANGRAVIEN_MATTRAI", BenhAnMatGlocom.TinhTrangRaVien_MatTrai));
            Command.Parameters.Add(new MDB.MDBParameter("RAVIENMP_KHONGKINH", BenhAnMatGlocom.RaVienMP_KhongKinh));
            Command.Parameters.Add(new MDB.MDBParameter("RAVIENMT_KHONGKINH", BenhAnMatGlocom.RaVienMT_KhongKinh));
            Command.Parameters.Add(new MDB.MDBParameter("RAVIENMP_COKINH", BenhAnMatGlocom.RaVienMP_CoKinh));
            Command.Parameters.Add(new MDB.MDBParameter("RAVIENMT_COKINH", BenhAnMatGlocom.RaVienMT_CoKinh));
            Command.Parameters.Add(new MDB.MDBParameter("RAVIENNHANAPMP", BenhAnMatGlocom.RaVienNhanApMP));
            Command.Parameters.Add(new MDB.MDBParameter("RAVIENNHANAPMT", BenhAnMatGlocom.RaVienNhanApMT));
            Command.Parameters.Add(new MDB.MDBParameter("HUONGDIEUTRI_THEODOI", BenhAnMatGlocom.HuongDieuTri_TheoDoi == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("HUONGDIEUTRI_THEODOITEXT", BenhAnMatGlocom.HuongDieuTri_TheoDoiText));
            Command.Parameters.Add(new MDB.MDBParameter("HUONGDIEUTRI_PHAUTHUAT", BenhAnMatGlocom.HuongDieuTri_PhauThuat == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("HUONGDIEUTRI_PHAUTHUATTEXT", BenhAnMatGlocom.HuongDieuTri_PhauThuatText));
            Command.Parameters.Add(new MDB.MDBParameter("HUONGDIEUTRI_LASER", BenhAnMatGlocom.HuongDieuTri_Laser == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("HUONGDIEUTRI_LASERTEXT", BenhAnMatGlocom.HuongDieuTri_LaserText));
            Command.Parameters.Add(new MDB.MDBParameter("HUONGDIEUTRI_THUOC", BenhAnMatGlocom.HuongDieuTri_Thuoc == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("HUONGDIEUTRI_THUOCTEXT", BenhAnMatGlocom.HuongDieuTri_ThuocText));
            Command.Parameters.Add(new MDB.MDBParameter("ChuaThayBenhLy", BenhAnMatGlocom.ChuaThayBenhLy ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("BenhLy", BenhAnMatGlocom.BenhLy ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("BenhLy_Text", BenhAnMatGlocom.BenhLy_Text));
            Command.Parameters.Add(new MDB.MDBParameter("PhauThuat", BenhAnMatGlocom.PhauThuat == true ? "1" : "0"));
            Command.Parameters.Add(new MDB.MDBParameter("ThuThuat", BenhAnMatGlocom.ThuThuat == true ? "1" : "0"));

            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiRaVien_KhongKinh_MP", BenhAnMatGlocom.ThiLucKhiRaVien_KhongKinh_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiRaVien_KhongKinh_MT", BenhAnMatGlocom.ThiLucKhiRaVien_KhongKinh_MT));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiRaVien_CoKinh_MP", BenhAnMatGlocom.ThiLucKhiRaVien_CoKinh_MP));
            Command.Parameters.Add(new MDB.MDBParameter("ThiLucKhiRaVien_CoKinh_MT", BenhAnMatGlocom.ThiLucKhiRaVien_CoKinh_MT));
            Command.Parameters.Add(new MDB.MDBParameter("NhanApRaVien_MT", BenhAnMatGlocom.NhanApRaVien_MT));
            Command.Parameters.Add(new MDB.MDBParameter("NhanApRaVien_MP", BenhAnMatGlocom.NhanApRaVien_MP));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuKhac", BenhAnMatGlocom.TienSuKhac));
            Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", BenhAnMatGlocom.MaQuanLy));

            Command.Parameters.Add(new MDB.MDBParameter("NoiTietCheck", BenhAnMatGlocom.NoiTietCheck));
            Command.Parameters.Add(new MDB.MDBParameter("NoiTiet_Text", BenhAnMatGlocom.NoiTiet_Text));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinhCheck", BenhAnMatGlocom.ThanKinhCheck));
            Command.Parameters.Add(new MDB.MDBParameter("ThanKinh_Text", BenhAnMatGlocom.ThanKinh_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoanCheck", BenhAnMatGlocom.TuanHoanCheck));
            Command.Parameters.Add(new MDB.MDBParameter("TuanHoan_Text", BenhAnMatGlocom.TuanHoan_Text));
            Command.Parameters.Add(new MDB.MDBParameter("HoHapCheck", BenhAnMatGlocom.HoHapCheck));
            Command.Parameters.Add(new MDB.MDBParameter("HoHap_Text", BenhAnMatGlocom.HoHap_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoaCheck", BenhAnMatGlocom.TieuHoaCheck));
            Command.Parameters.Add(new MDB.MDBParameter("TieuHoa_Text", BenhAnMatGlocom.TieuHoa_Text));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhopCheck", BenhAnMatGlocom.CoXuongKhopCheck));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop_Text", BenhAnMatGlocom.CoXuongKhop_Text));
            Command.Parameters.Add(new MDB.MDBParameter("TietNieuSinhDucCheck", BenhAnMatGlocom.TietNieuSinhDucCheck));
            Command.Parameters.Add(new MDB.MDBParameter("TietNieuSinhDuc_Text", BenhAnMatGlocom.TietNieuSinhDuc_Text));
            Command.Parameters.Add(new MDB.MDBParameter("KhamBenhToanThan_Khac", BenhAnMatGlocom.KhamBenhToanThan_Khac));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoanRaVien", BenhAnMatGlocom.ChanDoanRaVien));

            Command.BindByName = true;

            int n = Command.ExecuteNonQuery();
            return n > 0 ? true : false;
        }
        public static bool Delete(MDB.MDBConnection MyConnection, BenhAnMatGlocom BenhAnMatGlocom)
        {
            string sql = @"DELETE FROM BenhAnMatGlocom 
                           WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnMatGlocom.MaQuanLy));

            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
    }
}
