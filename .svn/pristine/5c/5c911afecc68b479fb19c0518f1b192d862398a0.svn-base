using EMR_MAIN.DATABASE.BenhAn;
using System.Data;

namespace EMR_MAIN.DATABASE.BenhAnFunc
{
    public class BenhAnThanNhanTaoFunc
    {
        public static void WriteXml(MDB.MDBConnection MyConnection)
        {
            string sql =
                   @"
                  select  a.*,  CTScanner HoSo_CTScanner, SieuAm HoSo_SieuAm, XetNghiem HoSo_XetNghiem,  Khac HoSo_Khac,  Khac_Text HoSo_Khac_Text,  ToanBoHoSo HoSo_ToanBoHoSo, Mach DauSinhTon_Mach,  NhietDo DauSinhTon_NhietDo,  HuyetAp DauSinhTon_HuyetAp,  NhipTho DauSinhTon_NhipTho,  CanNang DauSinhTon_CanNang  
                  from BenhAnThanNhanTao a inner join thongtindieutri b on a.maquanly = b.maquanly
                  where rownum = 1
                    ";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            var DataTable = new DataTable { TableName = "BenhAnThanNhanTao" };
            DataTable.Load(DataReader as IDataReader);
            DataTable.WriteXml("rptBenhAnThanNhanTao.xml");
        }
        public static DataSet SelectDataSet(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql = @"SELECT
                B.*,
	            T.MABENHNHAN,
	            T.TENKHOAVAO,
	            T.NGAYVAOVIEN,
                T.CHANDOAN_NOICHUYENDEN,
                T.NOIGIOITHIEU,
                T.TONGSONGAYDIEUTRI1,
                T.NGAYTHANGNAMTRANGBIA, 
	            H.BENHVIEN,
	            H.TENBENHNHAN,
	            H.TUOI,
	            H.GIOITINH,
				H.DANTOC,
				H.NGHENGHIEP,
				H.HOTENDIACHINGUOINHA,
				H.NOILAMVIEC,
				H.SOTHEBHYT,
				H.NGAYDANGKYBHYT,
				H.NGAYHETHANBHYT
            FROM
                BenhAnThanNhanTao B
                JOIN THONGTINDIEUTRI T ON B.MAQUANLY = T.MAQUANLY
                JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
                
            WHERE
                b.maquanly = " + MaQuanLy.ToString(System.Globalization.CultureInfo.InvariantCulture);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(sql, MyConnection);
            var ds = new DataSet();
            adt.Fill(ds, "Table");
            return ds;
        }
        public static BenhAnThanNhanTao Select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            #region
            string sql =
                      @"select * 
                        from BenhAnThanNhanTao a
                        where MaQuanLy = :MaQuanLy";
            #endregion
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            var value = new BenhAnThanNhanTao();
            while (DataReader.Read())
            {
                value.MaQuanLy = DataReader.GetDecimal("MaQuanLy");
                value.QuaTrinhBenhLy = DataReader["QuaTrinhBenhLy"].ToString();
                value.TienSuBenhBanThan = DataReader["TienSuBenhBanThan"].ToString();
                value.TienSuBenhGiaDinh = DataReader["TienSuBenhGiaDinh"].ToString();
                value.TheTrang = DataReader["TheTrang"].ToString();
                value.YThuc = DataReader["YThuc"].ToString();
                value.DaNiemMac = DataReader["DaNiemMac"].ToString();
                //DauSinhTon dauSinhTon = new DauSinhTon();
                //dauSinhTon.CanNang =(double)DataReader.GetDecimal("CanNang");
                //dauSinhTon.Mach = DataReader.GetInt("Mach");
                //dauSinhTon.NhietDo = (double)DataReader.GetDecimal("NhietDo");
                //dauSinhTon.HuyetAp = DataReader["HuyetAp"].ToString();
                //dauSinhTon.NhipTho = DataReader.GetInt("NhipTho");
                //value.DauSinhTon = dauSinhTon;
                value.Is_DaiMau = DataReader["Is_DaiMau"].ToString() == "1" ? true : false;
                value.Is_DaiDuc = DataReader["Is_DaiDuc"].ToString() == "1" ? true : false;
                value.Is_DaiRaHB = DataReader["Is_DaiRaHB"].ToString() == "1" ? true : false;
                value.Is_DaiRat = DataReader["Is_DaiRat"].ToString() == "1" ? true : false;
                value.Is_DaiBuot = DataReader["Is_DaiBuot"].ToString() == "1" ? true : false;
                value.Is_ConDauQuanThan = DataReader["Is_ConDauQuanThan"].ToString() == "1" ? true : false;
                value.Is_ThanTo = DataReader["Is_ThanTo"].ToString() == "1" ? true : false;
                value.Is_Phu = DataReader["Is_Phu"].ToString() == "1" ? true : false;
                value.Is_TranDichMangBung = DataReader["Is_TranDichMangBung"].ToString() == "1" ? true : false;
                value.Is_TranDichMangPhoi = DataReader["Is_TranDichMangPhoi"].ToString() == "1" ? true : false;
                value.Is_TranDichMangTim = DataReader["Is_TranDichMangTim"].ToString() == "1" ? true : false;
                value.NhipTim = DataReader["NhipTim"].ToString();
                value.LoaiNhipTim = DataReader["LoaiNhipTim"].ToString();
                value.TiengThoi = DataReader["TiengThoi"].ToString();
                value.SuyTim = DataReader["SuyTim"].ToString();
                value.KieuTho = DataReader["KieuTho"].ToString();
                value.RalesOPhoi = DataReader["RalesOPhoi"].ToString();
                value.Is_DauHieuKhoTho = DataReader["Is_DauHieuKhoTho"].ToString() == "1" ? true : false;
                value.Is_DauHieuPhuPhoi = DataReader["Is_DauHieuPhuPhoi"].ToString() == "1" ? true : false;
                value.Is_VangDa = DataReader["Is_VangDa"].ToString() == "1" ? true : false;
                value.Is_GanTo = DataReader["Is_GanTo"].ToString() == "1" ? true : false;
                value.Is_VangMat = DataReader["Is_VangMat"].ToString() == "1" ? true : false;
                value.Is_LachTo = DataReader["Is_LachTo"].ToString() == "1" ? true : false;
                value.Is_NonMau = DataReader["Is_NonMau"].ToString() == "1" ? true : false;
                value.Is_DiNgoaiPhanDen = DataReader["Is_DiNgoaiPhanDen"].ToString() == "1" ? true : false;
                value.Is_XuatHuyetDuoiDaVaNiemMac = DataReader["Is_XuatHuyetDuoiDaVaNiemMac"].ToString() == "1" ? true : false;
                value.Is_RoiLoanVanDong = DataReader["Is_RoiLoanVanDong"].ToString() == "1" ? true : false;
                value.Is_HoiChungMangNao = DataReader["Is_HoiChungMangNao"].ToString() == "1" ? true : false;
                value.Is_RoiLoanCamGiac = DataReader["Is_RoiLoanCamGiac"].ToString() == "1" ? true : false;
                value.Is_HoiChungTienDinhTieuNao = DataReader["Is_HoiChungTienDinhTieuNao"].ToString() == "1" ? true : false;
                value.Is_TamThanPhanLiet = DataReader["Is_TamThanPhanLiet"].ToString() == "1" ? true : false;
                value.Is_HoiChungCacDayTKSoNao = DataReader["Is_HoiChungCacDayTKSoNao"].ToString() == "1" ? true : false;
                value.Is_HoiChungTramCam = DataReader["Is_HoiChungTramCam"].ToString() == "1" ? true : false;
                value.Is_ViemCacDayTKNgoaiVi = DataReader["Is_ViemCacDayTKNgoaiVi"].ToString() == "1" ? true : false;
                value.CoXuongKhop = DataReader["CoXuongKhop"].ToString();
                value.TaiMuiHong = DataReader["TaiMuiHong"].ToString();
                value.Mat = DataReader["Mat"].ToString();
                value.DaLieu = DataReader["DaLieu"].ToString();
                value.UreMau = DataReader["UreMau"].ToString();
                value.CreatinineMau = DataReader["CreatinineMau"].ToString();
                value.Na = DataReader["Na"].ToString();
                value.DuongMau = DataReader["DuongMau"].ToString();
                value.K = DataReader["K"].ToString();
                value.ProtidMau = DataReader["ProtidMau"].ToString();
                value.Ca = DataReader["Ca"].ToString();
                value.AcidUricMau = DataReader["AcidUricMau"].ToString();
                value.Cl = DataReader["Cl"].ToString();
                value.CholesterolTF = DataReader["CholesterolTF"].ToString();
                value.Phospho = DataReader["Phospho"].ToString();
                value.BilirubineTF = DataReader["BilirubineTF"].ToString();
                value.Sat = DataReader["Sat"].ToString();
                value.BilirubineTT = DataReader["BilirubineTT"].ToString();
                value.BilirubineGT = DataReader["BilirubineGT"].ToString();
                value.PhMau = DataReader["PhMau"].ToString();
                value.ApLucThamThauMau = DataReader["ApLucThamThauMau"].ToString();
                value.SGOT = DataReader["SGOT"].ToString();
                value.MucLocCauThan = DataReader["MucLocCauThan"].ToString();
                value.SGPT = DataReader["SGPT"].ToString();
                value.HongCau = DataReader["HongCau"].ToString();
                value.AntiHbC = DataReader["AntiHbC"].ToString();
                value.BachCau = DataReader["BachCau"].ToString();
                value.HbeAg = DataReader["HbeAg"].ToString();
                value.BachCauTrungTinh = DataReader["BachCauTrungTinh"].ToString();
                value.BachCauAiToan = DataReader["BachCauAiToan"].ToString();
                value.BachCauAiKiem = DataReader["BachCauAiKiem"].ToString();
                value.AntiHbeAg = DataReader["AntiHbeAg"].ToString();
                value.HbsAg = DataReader["HbsAg"].ToString();
                value.AntiHbsAg = DataReader["AntiHbsAg"].ToString();
                value.TieuCau = DataReader["TieuCau"].ToString();
                value.AntiHCV = DataReader["AntiHCV"].ToString();
                value.HemoGlobine = DataReader["HemoGlobine"].ToString();
                value.KSTSotRet = DataReader["KSTSotRet"].ToString();
                value.Hematocrite = DataReader["Hematocrite"].ToString();
                value.DocChat = DataReader["DocChat"].ToString();
                value.HIV = DataReader["HIV"].ToString();
                value.ProteineNieu = DataReader["ProteineNieu"].ToString();
                value.UreNieu = DataReader["UreNieu"].ToString();
                value.BachCauNieu = DataReader["BachCauNieu"].ToString();
                value.Creatinine = DataReader["Creatinine"].ToString();
                value.TruNieu = DataReader["TruNieu"].ToString();
                value.NaNieu = DataReader["NaNieu"].ToString();
                value.HemoglobineNieu = DataReader["HemoglobineNieu"].ToString();
                value.GlucoseNieu = DataReader["GlucoseNieu"].ToString();
                value.X_Quang = DataReader["X_Quang"].ToString();
                value.SieuAm = DataReader["SieuAm"].ToString();
                value.SinhThiet = DataReader["SinhThiet"].ToString();
                value.DienTim = DataReader["DienTim"].ToString();
                value.BenhChinh = DataReader["BenhChinh"].ToString();
                value.HuongDieuTri = DataReader["HuongDieuTri"].ToString();
                value.BacSyLamBenhAn = DataReader["BacSyLamBenhAn"].ToString();
                value.MaSoKyTen= DataReader["masokyten"].ToString();
                value.MaSoKyTen_KB = DataReader["masokyten_kb"].ToString();
                value.MaSoKyTen_TK = DataReader["masokyten_tk"].ToString();
            }
            return value;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, BenhAnThanNhanTao benhAnThanNhanTao)
        {
            string sql =
                      @"select MaQuanLy 
                        from BenhAnThanNhanTao
                        where MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", benhAnThanNhanTao.MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            int rowCount = 0;
            while (DataReader.Read()) rowCount++;
            if (rowCount == 1) return Update(MyConnection, benhAnThanNhanTao);
            sql = @"INSERT INTO BenhAnThanNhanTao (
            MaQuanLy,
            QuaTrinhBenhLy,
            TienSuBenhBanThan,
            TienSuBenhGiaDinh,
            TheTrang ,
            YThuc ,
            DaNiemMac ,
            Is_DaiMau ,
            Is_DaiDuc ,
            Is_DaiRaHB ,
            Is_DaiRat ,
            Is_DaiBuot ,
            Is_ConDauQuanThan ,
            Is_ThanTo ,
            Is_Phu ,
            Is_TranDichMangBung ,
            Is_TranDichMangPhoi ,
            Is_TranDichMangTim ,
            NhipTim ,
            LoaiNhipTim ,
            TiengThoi ,
            SuyTim ,
            KieuTho ,
            RalesOPhoi ,
            Is_DauHieuKhoTho ,
            Is_DauHieuPhuPhoi ,
            Is_VangDa ,
            Is_GanTo ,
            Is_VangMat ,
            Is_LachTo ,
            Is_NonMau ,
            Is_DiNgoaiPhanDen ,
            Is_XuatHuyetDuoiDaVaNiemMac ,
            Is_RoiLoanVanDong ,
            Is_HoiChungMangNao ,
            Is_RoiLoanCamGiac ,
            Is_HoiChungTienDinhTieuNao ,
            Is_TamThanPhanLiet ,
            Is_HoiChungCacDayTKSoNao ,
            Is_HoiChungTramCam ,
            Is_ViemCacDayTKNgoaiVi ,
            CoXuongKhop,
            Mat,
            TaiMuiHong,
            DaLieu ,
            UreMau ,
            CreatinineMau ,
            Na ,
            DuongMau ,
            K ,
            ProtidMau ,
            Ca ,
            AcidUricMau ,
            Cl ,
            CholesterolTF ,
            Phospho ,
            BilirubineTF ,
            Sat ,
            BilirubineTT ,
            BilirubineGT ,
            PhMau ,
            ApLucThamThauMau ,
            SGOT ,
            MucLocCauThan ,
            SGPT ,
            HongCau ,
            AntiHbC ,
            BachCau ,
            HbeAg ,
            BachCauTrungTinh ,
            BachCauAiToan ,
            BachCauAiKiem ,
            AntiHbeAg ,
            HbsAg ,
            AntiHbsAg ,
            TieuCau ,
            AntiHCV ,
            HemoGlobine ,
            KSTSotRet ,
            Hematocrite ,
            DocChat ,
            HIV ,
            ProteineNieu ,
            UreNieu ,
            BachCauNieu ,
            Creatinine ,
            TruNieu ,
            NaNieu ,
            HemoglobineNieu ,
            GlucoseNieu ,
            X_Quang ,
            SieuAm ,
            DienTim ,
            SinhThiet ,
BenhChinh,
HuongDieuTri,
BacSyLamBenhAn
)
            VALUES (:MaQuanLy,
:QuaTrinhBenhLy,
:TienSuBenhBanThan,
:TienSuBenhGiaDinh,
:TheTrang ,
:YThuc ,
:DaNiemMac ,
:Is_DaiMau ,
:Is_DaiDuc ,
:Is_DaiRaHB ,
:Is_DaiRat ,
:Is_DaiBuot ,
:Is_ConDauQuanThan ,
:Is_ThanTo ,
:Is_Phu ,
:Is_TranDichMangBung ,
:Is_TranDichMangPhoi ,
:Is_TranDichMangTim ,
:NhipTim ,
:LoaiNhipTim ,
:TiengThoi ,
:SuyTim ,
:KieuTho ,
:RalesOPhoi ,
:Is_DauHieuKhoTho ,
:Is_DauHieuPhuPhoi ,
:Is_VangDa ,
:Is_GanTo ,
:Is_VangMat ,
:Is_LachTo ,
:Is_NonMau ,
:Is_DiNgoaiPhanDen ,
:Is_XuatHuyetDuoiDaVaNiemMac ,
:Is_RoiLoanVanDong ,
:Is_HoiChungMangNao ,
:Is_RoiLoanCamGiac ,
:Is_HoiChungTienDinhTieuNao ,
:Is_TamThanPhanLiet ,
:Is_HoiChungCacDayTKSoNao ,
:Is_HoiChungTramCam ,
:Is_ViemCacDayTKNgoaiVi ,
:CoXuongKhop,
:Mat,
:TaiMuiHong,
:DaLieu ,
:UreMau ,
:CreatinineMau ,
:Na ,
:DuongMau ,
:K ,
:ProtidMau ,
:Ca ,
:AcidUricMau ,
:Cl ,
:CholesterolTF ,
:Phospho ,
:BilirubineTF ,
:Sat ,
:BilirubineTT ,
:BilirubineGT ,
:PhMau ,
:ApLucThamThauMau ,
:SGOT ,
:MucLocCauThan ,
:SGPT ,:HongCau ,:AntiHbC ,:BachCau ,:HbeAg ,:BachCauTrungTinh ,:BachCauAiToan ,:BachCauAiKiem ,:AntiHbeAg ,:HbsAg ,:AntiHbsAg ,:TieuCau ,:AntiHCV ,:HemoGlobine ,:KSTSotRet ,:Hematocrite ,:DocChat ,:HIV ,:ProteineNieu ,:UreNieu ,:BachCauNieu ,:Creatinine ,:TruNieu ,:NaNieu ,:HemoglobineNieu ,:GlucoseNieu ,:X_Quang ,:SieuAm ,:DienTim ,:SinhThiet,:BenhChinh,
:HuongDieuTri,
:BacSyLamBenhAn)";
            Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", benhAnThanNhanTao.MaQuanLy));
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", benhAnThanNhanTao.QuaTrinhBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhBanThan", benhAnThanNhanTao.TienSuBenhBanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhGiaDinh", benhAnThanNhanTao.TienSuBenhGiaDinh));
            Command.Parameters.Add(new MDB.MDBParameter("TheTrang", benhAnThanNhanTao.TheTrang));
            Command.Parameters.Add(new MDB.MDBParameter("YThuc", benhAnThanNhanTao.YThuc));
            Command.Parameters.Add(new MDB.MDBParameter("DaNiemMac", benhAnThanNhanTao.DaNiemMac));
            //Command.Parameters.Add(new MDB.MDBParameter("CanNang", benhAnThanNhanTao.DauSinhTon.CanNang));
            //Command.Parameters.Add(new MDB.MDBParameter("ChieuCao", benhAnThanNhanTao.DauSinhTon.ChieuCao));
            //Command.Parameters.Add(new MDB.MDBParameter("Mach", benhAnThanNhanTao.DauSinhTon.Mach));
            //Command.Parameters.Add(new MDB.MDBParameter("NhietDo", benhAnThanNhanTao.DauSinhTon.NhietDo));
            //Command.Parameters.Add(new MDB.MDBParameter("HuyetAp", benhAnThanNhanTao.DauSinhTon.HuyetAp));
            //Command.Parameters.Add(new MDB.MDBParameter("NhipTho", benhAnThanNhanTao.DauSinhTon.NhipTho));
            Command.Parameters.Add(new MDB.MDBParameter("Is_DaiMau", benhAnThanNhanTao.Is_DaiMau == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("Is_DaiDuc", benhAnThanNhanTao.Is_DaiDuc == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("Is_DaiRaHB", benhAnThanNhanTao.Is_DaiRaHB == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("Is_DaiRat", benhAnThanNhanTao.Is_DaiRat == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("Is_DaiBuot", benhAnThanNhanTao.Is_DaiBuot == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("Is_ConDauQuanThan", benhAnThanNhanTao.Is_ConDauQuanThan == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("Is_ThanTo", benhAnThanNhanTao.Is_ThanTo == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("Is_Phu", benhAnThanNhanTao.Is_Phu == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("Is_TranDichMangBung", benhAnThanNhanTao.Is_TranDichMangBung == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("Is_TranDichMangPhoi", benhAnThanNhanTao.Is_TranDichMangPhoi == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("Is_TranDichMangTim", benhAnThanNhanTao.Is_TranDichMangTim == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("NhipTim", benhAnThanNhanTao.NhipTim));
            Command.Parameters.Add(new MDB.MDBParameter("LoaiNhipTim", benhAnThanNhanTao.LoaiNhipTim));
            Command.Parameters.Add(new MDB.MDBParameter("TiengThoi", benhAnThanNhanTao.TiengThoi));
            Command.Parameters.Add(new MDB.MDBParameter("SuyTim", benhAnThanNhanTao.SuyTim));
            Command.Parameters.Add(new MDB.MDBParameter("KieuTho", benhAnThanNhanTao.KieuTho));
            Command.Parameters.Add(new MDB.MDBParameter("RalesOPhoi", benhAnThanNhanTao.RalesOPhoi));
            Command.Parameters.Add(new MDB.MDBParameter("Is_DauHieuKhoTho", benhAnThanNhanTao.Is_DauHieuKhoTho == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("Is_DauHieuPhuPhoi", benhAnThanNhanTao.Is_DauHieuPhuPhoi == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("Is_VangDa", benhAnThanNhanTao.Is_VangDa == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("Is_GanTo", benhAnThanNhanTao.Is_GanTo == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("Is_VangMat", benhAnThanNhanTao.Is_VangMat == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("Is_LachTo", benhAnThanNhanTao.Is_LachTo == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("Is_NonMau", benhAnThanNhanTao.Is_NonMau == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("Is_DiNgoaiPhanDen", benhAnThanNhanTao.Is_DiNgoaiPhanDen == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("Is_XuatHuyetDuoiDaVaNiemMac", benhAnThanNhanTao.Is_XuatHuyetDuoiDaVaNiemMac == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("Is_RoiLoanVanDong", benhAnThanNhanTao.Is_RoiLoanVanDong == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("Is_HoiChungMangNao", benhAnThanNhanTao.Is_HoiChungMangNao == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("Is_RoiLoanCamGiac", benhAnThanNhanTao.Is_RoiLoanCamGiac == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("Is_HoiChungTienDinhTieuNao", benhAnThanNhanTao.Is_HoiChungTienDinhTieuNao == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("Is_TamThanPhanLiet", benhAnThanNhanTao.Is_TamThanPhanLiet == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("Is_HoiChungCacDayTKSoNao", benhAnThanNhanTao.Is_HoiChungCacDayTKSoNao == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("Is_HoiChungTramCam", benhAnThanNhanTao.Is_HoiChungTramCam == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("Is_ViemCacDayTKNgoaiVi", benhAnThanNhanTao.Is_ViemCacDayTKNgoaiVi == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop", benhAnThanNhanTao.CoXuongKhop));
            Command.Parameters.Add(new MDB.MDBParameter("Mat", benhAnThanNhanTao.Mat));
            Command.Parameters.Add(new MDB.MDBParameter("TaiMuiHong", benhAnThanNhanTao.TaiMuiHong));
            Command.Parameters.Add(new MDB.MDBParameter("DaLieu", benhAnThanNhanTao.DaLieu));
            Command.Parameters.Add(new MDB.MDBParameter("UreMau", benhAnThanNhanTao.UreMau));
            Command.Parameters.Add(new MDB.MDBParameter("CreatinineMau", benhAnThanNhanTao.CreatinineMau));
            Command.Parameters.Add(new MDB.MDBParameter("Na", benhAnThanNhanTao.Na));
            Command.Parameters.Add(new MDB.MDBParameter("DuongMau", benhAnThanNhanTao.DuongMau));
            Command.Parameters.Add(new MDB.MDBParameter("K", benhAnThanNhanTao.K));
            Command.Parameters.Add(new MDB.MDBParameter("ProtidMau", benhAnThanNhanTao.ProtidMau));
            Command.Parameters.Add(new MDB.MDBParameter("Ca", benhAnThanNhanTao.Ca));
            Command.Parameters.Add(new MDB.MDBParameter("AcidUricMau", benhAnThanNhanTao.AcidUricMau));
            Command.Parameters.Add(new MDB.MDBParameter("Cl", benhAnThanNhanTao.Cl));
            Command.Parameters.Add(new MDB.MDBParameter("CholesterolTF", benhAnThanNhanTao.CholesterolTF));
            Command.Parameters.Add(new MDB.MDBParameter("Phospho", benhAnThanNhanTao.Phospho));
            Command.Parameters.Add(new MDB.MDBParameter("BilirubineTF", benhAnThanNhanTao.BilirubineTF));
            Command.Parameters.Add(new MDB.MDBParameter("Sat", benhAnThanNhanTao.Sat));
            Command.Parameters.Add(new MDB.MDBParameter("BilirubineTT", benhAnThanNhanTao.BilirubineTT));
            Command.Parameters.Add(new MDB.MDBParameter("BilirubineGT", benhAnThanNhanTao.BilirubineGT));
            Command.Parameters.Add(new MDB.MDBParameter("PhMau", benhAnThanNhanTao.PhMau));
            Command.Parameters.Add(new MDB.MDBParameter("ApLucThamThauMau", benhAnThanNhanTao.ApLucThamThauMau));
            Command.Parameters.Add(new MDB.MDBParameter("SGOT", benhAnThanNhanTao.SGOT));
            Command.Parameters.Add(new MDB.MDBParameter("SGPT", benhAnThanNhanTao.SGPT));
            Command.Parameters.Add(new MDB.MDBParameter("MucLocCauThan", benhAnThanNhanTao.MucLocCauThan));
            Command.Parameters.Add(new MDB.MDBParameter("HongCau", benhAnThanNhanTao.HongCau));
            Command.Parameters.Add(new MDB.MDBParameter("AntiHbC", benhAnThanNhanTao.AntiHbC));
            Command.Parameters.Add(new MDB.MDBParameter("BachCau", benhAnThanNhanTao.BachCau));
            Command.Parameters.Add(new MDB.MDBParameter("HbeAg", benhAnThanNhanTao.HbeAg));
            Command.Parameters.Add(new MDB.MDBParameter("BachCauTrungTinh", benhAnThanNhanTao.BachCauTrungTinh));
            Command.Parameters.Add(new MDB.MDBParameter("BachCauAiKiem", benhAnThanNhanTao.BachCauAiKiem));
            Command.Parameters.Add(new MDB.MDBParameter("BachCauAiToan", benhAnThanNhanTao.BachCauAiToan));
            Command.Parameters.Add(new MDB.MDBParameter("AntiHbeAg", benhAnThanNhanTao.AntiHbeAg));
            Command.Parameters.Add(new MDB.MDBParameter("HbsAg", benhAnThanNhanTao.HbsAg));
            Command.Parameters.Add(new MDB.MDBParameter("AntiHbsAg", benhAnThanNhanTao.AntiHbsAg));
            Command.Parameters.Add(new MDB.MDBParameter("TieuCau", benhAnThanNhanTao.TieuCau));
            Command.Parameters.Add(new MDB.MDBParameter("AntiHCV", benhAnThanNhanTao.AntiHCV));
            Command.Parameters.Add(new MDB.MDBParameter("HemoGlobine", benhAnThanNhanTao.HemoGlobine));
            Command.Parameters.Add(new MDB.MDBParameter("KSTSotRet", benhAnThanNhanTao.KSTSotRet));
            Command.Parameters.Add(new MDB.MDBParameter("Hematocrite", benhAnThanNhanTao.Hematocrite));
            Command.Parameters.Add(new MDB.MDBParameter("DocChat", benhAnThanNhanTao.DocChat));
            Command.Parameters.Add(new MDB.MDBParameter("HIV", benhAnThanNhanTao.HIV));
            Command.Parameters.Add(new MDB.MDBParameter("ProteineNieu", benhAnThanNhanTao.ProteineNieu));
            Command.Parameters.Add(new MDB.MDBParameter("UreNieu", benhAnThanNhanTao.UreNieu));
            Command.Parameters.Add(new MDB.MDBParameter("BachCauNieu", benhAnThanNhanTao.BachCauNieu));
            Command.Parameters.Add(new MDB.MDBParameter("Creatinine", benhAnThanNhanTao.Creatinine));
            Command.Parameters.Add(new MDB.MDBParameter("TruNieu", benhAnThanNhanTao.TruNieu));
            Command.Parameters.Add(new MDB.MDBParameter("NaNieu", benhAnThanNhanTao.NaNieu));
            Command.Parameters.Add(new MDB.MDBParameter("HemoglobineNieu", benhAnThanNhanTao.HemoglobineNieu));
            Command.Parameters.Add(new MDB.MDBParameter("GlucoseNieu", benhAnThanNhanTao.GlucoseNieu));
            Command.Parameters.Add(new MDB.MDBParameter("X_Quang", benhAnThanNhanTao.X_Quang));
            Command.Parameters.Add(new MDB.MDBParameter("SieuAm", benhAnThanNhanTao.SieuAm));
            Command.Parameters.Add(new MDB.MDBParameter("DienTim", benhAnThanNhanTao.DienTim));
            Command.Parameters.Add(new MDB.MDBParameter("SinhThiet", benhAnThanNhanTao.SinhThiet));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", benhAnThanNhanTao.BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", benhAnThanNhanTao.HuongDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyLamBenhAn", benhAnThanNhanTao.BacSyLamBenhAn));

            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool Update(MDB.MDBConnection MyConnection, BenhAnThanNhanTao benhAnThanNhanTao)
        {
            string sql = @"UPDATE BenhAnThanNhanTao SET 
            QuaTrinhBenhLy= :QuaTrinhBenhLy ,
            TienSuBenhBanThan= :TienSuBenhBanThan ,
            TienSuBenhGiaDinh= :TienSuBenhGiaDinh ,
            TheTrang = :TheTrang ,
            YThuc = :YThuc ,
            DaNiemMac = :DaNiemMac ,
            Is_DaiMau = :Is_DaiMau ,
            Is_DaiDuc = :Is_DaiDuc ,
            Is_DaiRaHB = :Is_DaiRaHB ,
            Is_DaiRat = :Is_DaiRat ,
            Is_DaiBuot = :Is_DaiBuot ,
            Is_ConDauQuanThan = :Is_ConDauQuanThan ,
            Is_ThanTo = :Is_ThanTo ,
            Is_Phu = :Is_Phu ,
            Is_TranDichMangBung = :Is_TranDichMangBung ,
            Is_TranDichMangPhoi = :Is_TranDichMangPhoi ,
            Is_TranDichMangTim = :Is_TranDichMangTim ,
            NhipTim = :NhipTim ,
            LoaiNhipTim = :LoaiNhipTim ,
            TiengThoi = :TiengThoi ,
            SuyTim = :SuyTim ,
            KieuTho = :KieuTho ,
            RalesOPhoi = :RalesOPhoi ,
            Is_DauHieuKhoTho = :Is_DauHieuKhoTho ,
            Is_DauHieuPhuPhoi = :Is_DauHieuPhuPhoi ,
            Is_VangDa = :Is_VangDa ,
            Is_GanTo = :Is_GanTo ,
            Is_VangMat = :Is_VangMat ,
            Is_LachTo = :Is_LachTo ,
            Is_NonMau = :Is_NonMau ,
            Is_DiNgoaiPhanDen = :Is_DiNgoaiPhanDen ,
            Is_XuatHuyetDuoiDaVaNiemMac = :Is_XuatHuyetDuoiDaVaNiemMac ,
            Is_RoiLoanVanDong = :Is_RoiLoanVanDong ,
            Is_HoiChungMangNao = :Is_HoiChungMangNao ,
            Is_RoiLoanCamGiac = :Is_RoiLoanCamGiac ,
            Is_HoiChungTienDinhTieuNao = :Is_HoiChungTienDinhTieuNao ,
            Is_TamThanPhanLiet = :Is_TamThanPhanLiet ,
            Is_HoiChungCacDayTKSoNao = :Is_HoiChungCacDayTKSoNao ,
            Is_HoiChungTramCam = :Is_HoiChungTramCam ,
            Is_ViemCacDayTKNgoaiVi = :Is_ViemCacDayTKNgoaiVi ,
            CoXuongKhop = :CoXuongKhop,
            Mat = :Mat,
            TaiMuiHong = :TaiMuiHong,
            DaLieu = :DaLieu ,
            UreMau = :UreMau ,
            CreatinineMau = :CreatinineMau ,
            Na = :Na ,
            DuongMau = :DuongMau ,
            K = :K ,
            ProtidMau = :ProtidMau ,
            Ca = :Ca ,
            AcidUricMau = :AcidUricMau ,
            Cl = :Cl ,
            CholesterolTF = :CholesterolTF ,
            Phospho = :Phospho ,
            BilirubineTF = :BilirubineTF ,
            Sat = :Sat ,
            BilirubineTT = :BilirubineTT ,
            BilirubineGT = :BilirubineGT ,
            PhMau = :PhMau ,
            ApLucThamThauMau = :ApLucThamThauMau ,
            SGOT = :SGOT ,
            MucLocCauThan = :MucLocCauThan ,
            SGPT = :SGPT ,
            HongCau = :HongCau ,
            AntiHbC = :AntiHbC ,
            BachCau = :BachCau ,
            HbeAg = :HbeAg ,
            BachCauTrungTinh = :BachCauTrungTinh ,
            BachCauAiToan = :BachCauAiToan ,
            BachCauAiKiem = :BachCauAiKiem ,
            AntiHbeAg = :AntiHbeAg ,
            HbsAg = :HbsAg ,
            AntiHbsAg = :AntiHbsAg ,
            TieuCau = :TieuCau ,
            AntiHCV = :AntiHCV ,
            HemoGlobine = :HemoGlobine ,
            KSTSotRet = :KSTSotRet ,
            Hematocrite = :Hematocrite ,
            DocChat = :DocChat ,
            HIV = :HIV ,
            ProteineNieu = :ProteineNieu ,
            UreNieu = :UreNieu ,
            BachCauNieu = :BachCauNieu ,
            Creatinine = :Creatinine ,
            TruNieu = :TruNieu ,
            NaNieu = :NaNieu ,
            HemoglobineNieu = :HemoglobineNieu ,
            GlucoseNieu = :GlucoseNieu ,
            X_Quang = :X_Quang ,
            SieuAm = :SieuAm ,
            DienTim = :DienTim ,
            SinhThiet = :SinhThiet ,
BenhChinh = :BenhChinh, HuongDieuTri = :HuongDieuTri, BacSyLamBenhAn = :BacSyLamBenhAn WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLy", benhAnThanNhanTao.QuaTrinhBenhLy));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhBanThan", benhAnThanNhanTao.TienSuBenhBanThan));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhGiaDinh", benhAnThanNhanTao.TienSuBenhGiaDinh));
            Command.Parameters.Add(new MDB.MDBParameter("TheTrang", benhAnThanNhanTao.TheTrang));
            Command.Parameters.Add(new MDB.MDBParameter("YThuc", benhAnThanNhanTao.YThuc));
            Command.Parameters.Add(new MDB.MDBParameter("DaNiemMac", benhAnThanNhanTao.DaNiemMac));
            //Command.Parameters.Add(new MDB.MDBParameter("CanNang", benhAnThanNhanTao.DauSinhTon.CanNang));
            //Command.Parameters.Add(new MDB.MDBParameter("ChieuCao", benhAnThanNhanTao.DauSinhTon.ChieuCao));
            //Command.Parameters.Add(new MDB.MDBParameter("Mach", benhAnThanNhanTao.DauSinhTon.Mach));
            //Command.Parameters.Add(new MDB.MDBParameter("NhietDo", benhAnThanNhanTao.DauSinhTon.NhietDo));
            //Command.Parameters.Add(new MDB.MDBParameter("HuyetAp", benhAnThanNhanTao.DauSinhTon.HuyetAp));
            //Command.Parameters.Add(new MDB.MDBParameter("NhipTho", benhAnThanNhanTao.DauSinhTon.NhipTho));
            Command.Parameters.Add(new MDB.MDBParameter("Is_DaiMau", benhAnThanNhanTao.Is_DaiMau == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("Is_DaiDuc", benhAnThanNhanTao.Is_DaiDuc == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("Is_DaiRaHB", benhAnThanNhanTao.Is_DaiRaHB == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("Is_DaiRat", benhAnThanNhanTao.Is_DaiRat == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("Is_DaiBuot", benhAnThanNhanTao.Is_DaiBuot == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("Is_ConDauQuanThan", benhAnThanNhanTao.Is_ConDauQuanThan == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("Is_ThanTo", benhAnThanNhanTao.Is_ThanTo == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("Is_Phu", benhAnThanNhanTao.Is_Phu == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("Is_TranDichMangBung", benhAnThanNhanTao.Is_TranDichMangBung == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("Is_TranDichMangPhoi", benhAnThanNhanTao.Is_TranDichMangPhoi == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("Is_TranDichMangTim", benhAnThanNhanTao.Is_TranDichMangTim == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("NhipTim", benhAnThanNhanTao.NhipTim));
            Command.Parameters.Add(new MDB.MDBParameter("LoaiNhipTim", benhAnThanNhanTao.LoaiNhipTim));
            Command.Parameters.Add(new MDB.MDBParameter("TiengThoi", benhAnThanNhanTao.TiengThoi));
            Command.Parameters.Add(new MDB.MDBParameter("SuyTim", benhAnThanNhanTao.SuyTim));
            Command.Parameters.Add(new MDB.MDBParameter("KieuTho", benhAnThanNhanTao.KieuTho));
            Command.Parameters.Add(new MDB.MDBParameter("RalesOPhoi", benhAnThanNhanTao.RalesOPhoi));
            Command.Parameters.Add(new MDB.MDBParameter("Is_DauHieuKhoTho", benhAnThanNhanTao.Is_DauHieuKhoTho == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("Is_DauHieuPhuPhoi", benhAnThanNhanTao.Is_DauHieuPhuPhoi == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("Is_VangDa", benhAnThanNhanTao.Is_VangDa == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("Is_GanTo", benhAnThanNhanTao.Is_GanTo == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("Is_VangMat", benhAnThanNhanTao.Is_VangMat == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("Is_LachTo", benhAnThanNhanTao.Is_LachTo == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("Is_NonMau", benhAnThanNhanTao.Is_NonMau == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("Is_DiNgoaiPhanDen", benhAnThanNhanTao.Is_DiNgoaiPhanDen == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("Is_XuatHuyetDuoiDaVaNiemMac", benhAnThanNhanTao.Is_XuatHuyetDuoiDaVaNiemMac == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("Is_RoiLoanVanDong", benhAnThanNhanTao.Is_RoiLoanVanDong == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("Is_HoiChungMangNao", benhAnThanNhanTao.Is_HoiChungMangNao == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("Is_RoiLoanCamGiac", benhAnThanNhanTao.Is_RoiLoanCamGiac == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("Is_HoiChungTienDinhTieuNao", benhAnThanNhanTao.Is_HoiChungTienDinhTieuNao == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("Is_TamThanPhanLiet", benhAnThanNhanTao.Is_TamThanPhanLiet == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("Is_HoiChungCacDayTKSoNao", benhAnThanNhanTao.Is_HoiChungCacDayTKSoNao == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("Is_HoiChungTramCam", benhAnThanNhanTao.Is_HoiChungTramCam == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("Is_ViemCacDayTKNgoaiVi", benhAnThanNhanTao.Is_ViemCacDayTKNgoaiVi == true ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop", benhAnThanNhanTao.CoXuongKhop));
            Command.Parameters.Add(new MDB.MDBParameter("Mat", benhAnThanNhanTao.Mat));
            Command.Parameters.Add(new MDB.MDBParameter("TaiMuiHong", benhAnThanNhanTao.TaiMuiHong));
            Command.Parameters.Add(new MDB.MDBParameter("DaLieu", benhAnThanNhanTao.DaLieu));
            Command.Parameters.Add(new MDB.MDBParameter("UreMau", benhAnThanNhanTao.UreMau));
            Command.Parameters.Add(new MDB.MDBParameter("CreatinineMau", benhAnThanNhanTao.CreatinineMau));
            Command.Parameters.Add(new MDB.MDBParameter("Na", benhAnThanNhanTao.Na));
            Command.Parameters.Add(new MDB.MDBParameter("DuongMau", benhAnThanNhanTao.DuongMau));
            Command.Parameters.Add(new MDB.MDBParameter("K", benhAnThanNhanTao.K));
            Command.Parameters.Add(new MDB.MDBParameter("ProtidMau", benhAnThanNhanTao.ProtidMau));
            Command.Parameters.Add(new MDB.MDBParameter("Ca", benhAnThanNhanTao.Ca));
            Command.Parameters.Add(new MDB.MDBParameter("AcidUricMau", benhAnThanNhanTao.AcidUricMau));
            Command.Parameters.Add(new MDB.MDBParameter("Cl", benhAnThanNhanTao.Cl));
            Command.Parameters.Add(new MDB.MDBParameter("CholesterolTF", benhAnThanNhanTao.CholesterolTF));
            Command.Parameters.Add(new MDB.MDBParameter("Phospho", benhAnThanNhanTao.Phospho));
            Command.Parameters.Add(new MDB.MDBParameter("BilirubineTF", benhAnThanNhanTao.BilirubineTF));
            Command.Parameters.Add(new MDB.MDBParameter("Sat", benhAnThanNhanTao.Sat));
            Command.Parameters.Add(new MDB.MDBParameter("BilirubineTT", benhAnThanNhanTao.BilirubineTT));
            Command.Parameters.Add(new MDB.MDBParameter("BilirubineGT", benhAnThanNhanTao.BilirubineGT));
            Command.Parameters.Add(new MDB.MDBParameter("PhMau", benhAnThanNhanTao.PhMau));
            Command.Parameters.Add(new MDB.MDBParameter("ApLucThamThauMau", benhAnThanNhanTao.ApLucThamThauMau));
            Command.Parameters.Add(new MDB.MDBParameter("SGOT", benhAnThanNhanTao.SGOT));
            Command.Parameters.Add(new MDB.MDBParameter("SGPT", benhAnThanNhanTao.SGPT));
            Command.Parameters.Add(new MDB.MDBParameter("MucLocCauThan", benhAnThanNhanTao.MucLocCauThan));
            Command.Parameters.Add(new MDB.MDBParameter("HongCau", benhAnThanNhanTao.HongCau));
            Command.Parameters.Add(new MDB.MDBParameter("AntiHbC", benhAnThanNhanTao.AntiHbC));
            Command.Parameters.Add(new MDB.MDBParameter("BachCau", benhAnThanNhanTao.BachCau));
            Command.Parameters.Add(new MDB.MDBParameter("HbeAg", benhAnThanNhanTao.HbeAg));
            Command.Parameters.Add(new MDB.MDBParameter("BachCauTrungTinh", benhAnThanNhanTao.BachCauTrungTinh));
            Command.Parameters.Add(new MDB.MDBParameter("BachCauAiKiem", benhAnThanNhanTao.BachCauAiKiem));
            Command.Parameters.Add(new MDB.MDBParameter("BachCauAiToan", benhAnThanNhanTao.BachCauAiToan));
            Command.Parameters.Add(new MDB.MDBParameter("AntiHbeAg", benhAnThanNhanTao.AntiHbeAg));
            Command.Parameters.Add(new MDB.MDBParameter("HbsAg", benhAnThanNhanTao.HbsAg));
            Command.Parameters.Add(new MDB.MDBParameter("AntiHbsAg", benhAnThanNhanTao.AntiHbsAg));
            Command.Parameters.Add(new MDB.MDBParameter("TieuCau", benhAnThanNhanTao.TieuCau));
            Command.Parameters.Add(new MDB.MDBParameter("AntiHCV", benhAnThanNhanTao.AntiHCV));
            Command.Parameters.Add(new MDB.MDBParameter("HemoGlobine", benhAnThanNhanTao.HemoGlobine));
            Command.Parameters.Add(new MDB.MDBParameter("KSTSotRet", benhAnThanNhanTao.KSTSotRet));
            Command.Parameters.Add(new MDB.MDBParameter("Hematocrite", benhAnThanNhanTao.Hematocrite));
            Command.Parameters.Add(new MDB.MDBParameter("DocChat", benhAnThanNhanTao.DocChat));
            Command.Parameters.Add(new MDB.MDBParameter("HIV", benhAnThanNhanTao.HIV));
            Command.Parameters.Add(new MDB.MDBParameter("ProteineNieu", benhAnThanNhanTao.ProteineNieu));
            Command.Parameters.Add(new MDB.MDBParameter("UreNieu", benhAnThanNhanTao.UreNieu));
            Command.Parameters.Add(new MDB.MDBParameter("BachCauNieu", benhAnThanNhanTao.BachCauNieu));
            Command.Parameters.Add(new MDB.MDBParameter("Creatinine", benhAnThanNhanTao.Creatinine));
            Command.Parameters.Add(new MDB.MDBParameter("TruNieu", benhAnThanNhanTao.TruNieu));
            Command.Parameters.Add(new MDB.MDBParameter("NaNieu", benhAnThanNhanTao.NaNieu));
            Command.Parameters.Add(new MDB.MDBParameter("HemoglobineNieu", benhAnThanNhanTao.HemoglobineNieu));
            Command.Parameters.Add(new MDB.MDBParameter("GlucoseNieu", benhAnThanNhanTao.GlucoseNieu));
            Command.Parameters.Add(new MDB.MDBParameter("X_Quang", benhAnThanNhanTao.X_Quang));
            Command.Parameters.Add(new MDB.MDBParameter("SieuAm", benhAnThanNhanTao.SieuAm));
            Command.Parameters.Add(new MDB.MDBParameter("DienTim", benhAnThanNhanTao.DienTim));
            Command.Parameters.Add(new MDB.MDBParameter("SinhThiet", benhAnThanNhanTao.SinhThiet));
            Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", benhAnThanNhanTao.BenhChinh));
            Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", benhAnThanNhanTao.HuongDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyLamBenhAn", benhAnThanNhanTao.BacSyLamBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", benhAnThanNhanTao.MaQuanLy));
            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool Delete(MDB.MDBConnection MyConnection, BenhAnThanNhanTao benhAnThanNhanTao)
        {
            string sql = @"DELETE FROM BenhAnThanNhanTao 
                           WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", benhAnThanNhanTao.MaQuanLy));

            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
    }
}
