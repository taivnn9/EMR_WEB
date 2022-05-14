using EMR_MAIN.DATABASE.BenhAn;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.BenhAnFunc
{
    public class BenhAnThieuMauCoTimCucBoFunc
    {
        public static void WriteXml(MDB.MDBConnection MyConnection)
        {
            string sql =
                   @"
                  select  a.*,  CTScanner HoSo_CTScanner, SieuAm HoSo_SieuAm, XetNghiem HoSo_XetNghiem,  Khac HoSo_Khac,  Khac_Text HoSo_Khac_Text,  ToanBoHoSo HoSo_ToanBoHoSo, Mach DauSinhTon_Mach,  NhietDo DauSinhTon_NhietDo,  HuyetAp DauSinhTon_HuyetAp,  NhipTho DauSinhTon_NhipTho,  CanNang DauSinhTon_CanNang  
                  from BenhAnThieuMauCoTimCucBo a inner join thongtindieutri b on a.maquanly = b.maquanly
                  where rownum = 1
                    ";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            var DataTable = new DataTable { TableName = "BenhAnThieuMauCoTimCucBo" };
            DataTable.Load(DataReader as IDataReader);
            DataTable.WriteXml("rptBenhAnThieuMauCoTimCucBo.xml");
        }
        public static DataSet SelectDataSet(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql =
                   @"
                  select  a.*, f.hovaten BacSyHoVaTen 
                        from BenhAnThieuMauCoTimCucBo a  
                  left join nhanvien f on a.BacSy = f.manhanvien
                  where a.maquanly = " + MaQuanLy;
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(sql, MyConnection);
            var ds = new DataSet();
            adt.Fill(ds, "Table");

            return ds;
        }
        public static BenhAnThieuMauCoTimCucBo Select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            var obj = new BenhAnThieuMauCoTimCucBo();
            try
            {
                #region
                string sql =
                          @"select * 
                        from BenhAnThieuMauCoTimCucBo 
                        where MaQuanLy = :MaQuanLy";
                #endregion
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    // Phần chung Hành chính
                    obj.MaQuanLy = DataReader.GetDecimal("MaQuanLy");
                    obj.LyDoVaoVien = DataReader["LyDoVaoVien"].ToString();
                    obj.BenhSu = DataReader["BenhSu"].ToString();
                    obj.TienSu = DataReader["TienSu"].ToString();
                    obj.LanKhamDauTien_Ngay = DataReader["LanKhamDauTien_Ngay"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["LanKhamDauTien_Ngay"]) : null;
                    obj.ChiSoHA = DataReader["ChiSoHA"].ToString();
                    obj.CanNang = DataReader["CanNang"].ToString();
                    obj.ChieuCao = DataReader["ChieuCao"].ToString();
                    obj.VongBung = DataReader["VongBung"].ToString();
                    obj.DauDau = DataReader.GetInt("DauDau");
                    obj.HoKhan = DataReader.GetInt("HoKhan");
                    obj.KhoThoKhiGangSuc = DataReader.GetInt("KhoThoKhiGangSuc");
                    obj.HoiHopDanhTrongNguc = DataReader.GetInt("HoiHopDanhTrongNguc");
                    obj.UTai = DataReader.GetInt("UTai");
                    obj.NoiGiong = DataReader.GetInt("NoiGiong");
                    obj.DauNguc = DataReader.GetInt("DauNguc");
                    obj.MatNgu = DataReader.GetInt("MatNgu");
                    obj.PhuHaiChan = DataReader.GetInt("PhuHaiChan");
                    obj.MeoMom = DataReader.GetInt("MeoMom");
                    obj.LietNuaNguoi = DataReader.GetInt("LietNuaNguoi");
                    obj.GayCung = DataReader.GetInt("GayCung");
                    obj.TuanThuDieuTri = DataReader.GetInt("TuanThuDieuTri");
                    obj.ThucHienCheDo = DataReader.GetInt("ThucHienCheDo");
                    obj.HutThuoc = DataReader.GetInt("HutThuoc");
                    obj.HutThuoc_Dieu = DataReader["HutThuoc_Dieu"].ToString();
                    obj.UongRuou = DataReader.GetInt("UongRuou");
                    obj.UongRuou_Ml = DataReader["UongRuou_Ml"].ToString();
                    obj.CacTrieuChungKhac = DataReader["CacTrieuChungKhac"].ToString();
                    obj.Cholesterol_TP = DataReader["Cholesterol_TP"].ToString();
                    obj.TG = DataReader["TG"].ToString();
                    obj.HDL = DataReader["HDL"].ToString();
                    obj.LDL = DataReader["LDL"].ToString();
                    obj.GlucoseMau = DataReader["GlucoseMau"].ToString();
                    obj.DamNiem = DataReader["DamNiem"].ToString();
                    obj.CreatininMau = DataReader["CreatininMau"].ToString();
                    obj.SieuAmTim = DataReader["SieuAmTim"].ToString();
                    obj.SAT_DayThatTrai = DataReader["SAT_DayThatTrai"].ToString();
                    obj.DienTamDo = DataReader["DienTamDo"].ToString();
                    obj.TrucDienTim = DataReader["TrucDienTim"].ToString();
                    obj.DTD_DayThatTrai = DataReader["DTD_DayThatTrai"].ToString();
                    obj.XQuangTimPhoi = DataReader["XQuangTimPhoi"].ToString();
                    obj.MucDoTangHA = DataReader["MucDoTangHA"].ToString();
                    obj.GiaiDoanTangHA = DataReader["GiaiDoanTangHA"].ToString();
                    obj.CacBenhPhoiHop = DataReader["CacBenhPhoiHop"].ToString();
                    obj.THCDTDLS = DataReader["THCDTDLS"].ToString();
                    obj.ThuocDieuTri = DataReader["ThuocDieuTri"].ToString();
                    obj.HenTaiKham = DataReader["HenTaiKham"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["HenTaiKham"]) : null;
                    obj.BacSy = DataReader["BacSy"].ToString();
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return obj;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, BenhAnThieuMauCoTimCucBo BenhAnThieuMauCoTimCucBo)
        {
            try
            {
                string sql =
                          @"select MaQuanLy 
                            from BenhAnThieuMauCoTimCucBo
                            where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnThieuMauCoTimCucBo.MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                int rowCount = 0;
                while (DataReader.Read()) rowCount++;
                if (rowCount == 1) return Update(MyConnection, BenhAnThieuMauCoTimCucBo);
                sql = @"
                       INSERT INTO BenhAnThieuMauCoTimCucBo 
                        (
                            MaQuanLy,
                            LyDoVaoVien,
                            BenhSu,
                            TienSu,
                            LanKhamDauTien_Ngay,
                            ChiSoHA,
                            CanNang,
                            ChieuCao,
                            VongBung,
                            DauDau,
                            HoKhan,
                            KhoThoKhiGangSuc,
                            HoiHopDanhTrongNguc,
                            UTai,
                            NoiGiong,
                            DauNguc,
                            MatNgu,
                            PhuHaiChan,
                            MeoMom,
                            LietNuaNguoi,
                            GayCung,
                            TuanThuDieuTri,
                            ThucHienCheDo,
                            HutThuoc,
                            HutThuoc_Dieu,
                            UongRuou,
                            UongRuou_Ml,
                            CacTrieuChungKhac,
                            Cholesterol_TP,
                            TG,
                            HDL,
                            LDL,
                            GlucoseMau,
                            DamNiem,
                            CreatininMau,
                            SieuAmTim,
                            SAT_DayThatTrai,
                            DienTamDo,
                            TrucDienTim,
                            DTD_DayThatTrai,
                            XQuangTimPhoi,
                            MucDoTangHA,
                            GiaiDoanTangHA,
                            CacBenhPhoiHop,
                            THCDTDLS,
                            ThuocDieuTri,
                            HenTaiKham,
                            BacSy
                        )                 
                        VALUES
                        (
                            :MaQuanLy,
                            :LyDoVaoVien,
                            :BenhSu,
                            :TienSu,
                            :LanKhamDauTien_Ngay,
                            :ChiSoHA,
                            :CanNang,
                            :ChieuCao,
                            :VongBung,
                            :DauDau,
                            :HoKhan,
                            :KhoThoKhiGangSuc,
                            :HoiHopDanhTrongNguc,
                            :UTai,
                            :NoiGiong,
                            :DauNguc,
                            :MatNgu,
                            :PhuHaiChan,
                            :MeoMom,
                            :LietNuaNguoi,
                            :GayCung,
                            :TuanThuDieuTri,
                            :ThucHienCheDo,
                            :HutThuoc,
                            :HutThuoc_Dieu,
                            :UongRuou,
                            :UongRuou_Ml,
                            :CacTrieuChungKhac,
                            :Cholesterol_TP,
                            :TG,
                            :HDL,
                            :LDL,
                            :GlucoseMau,
                            :DamNiem,
                            :CreatininMau,
                            :SieuAmTim,
                            :SAT_DayThatTrai,
                            :DienTamDo,
                            :TrucDienTim,
                            :DTD_DayThatTrai,
                            :XQuangTimPhoi,
                            :MucDoTangHA,
                            :GiaiDoanTangHA,
                            :CacBenhPhoiHop,
                            :THCDTDLS,
                            :ThuocDieuTri,
                            :HenTaiKham,
                            :BacSy                     
                        )";
                Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnThieuMauCoTimCucBo.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnThieuMauCoTimCucBo.LyDoVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("BenhSu", BenhAnThieuMauCoTimCucBo.BenhSu));
                Command.Parameters.Add(new MDB.MDBParameter("TienSu", BenhAnThieuMauCoTimCucBo.TienSu));
                Command.Parameters.Add(new MDB.MDBParameter("LanKhamDauTien_Ngay", BenhAnThieuMauCoTimCucBo.LanKhamDauTien_Ngay));
                Command.Parameters.Add(new MDB.MDBParameter("ChiSoHA", BenhAnThieuMauCoTimCucBo.ChiSoHA));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang", BenhAnThieuMauCoTimCucBo.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("ChieuCao", BenhAnThieuMauCoTimCucBo.ChieuCao));
                Command.Parameters.Add(new MDB.MDBParameter("VongBung", BenhAnThieuMauCoTimCucBo.VongBung));
                Command.Parameters.Add(new MDB.MDBParameter("DauDau", BenhAnThieuMauCoTimCucBo.DauDau));
                Command.Parameters.Add(new MDB.MDBParameter("HoKhan", BenhAnThieuMauCoTimCucBo.HoKhan));
                Command.Parameters.Add(new MDB.MDBParameter("KhoThoKhiGangSuc", BenhAnThieuMauCoTimCucBo.KhoThoKhiGangSuc));
                Command.Parameters.Add(new MDB.MDBParameter("HoiHopDanhTrongNguc", BenhAnThieuMauCoTimCucBo.HoiHopDanhTrongNguc));
                Command.Parameters.Add(new MDB.MDBParameter("UTai", BenhAnThieuMauCoTimCucBo.UTai));
                Command.Parameters.Add(new MDB.MDBParameter("NoiGiong", BenhAnThieuMauCoTimCucBo.NoiGiong));
                Command.Parameters.Add(new MDB.MDBParameter("DauNguc", BenhAnThieuMauCoTimCucBo.DauNguc));
                Command.Parameters.Add(new MDB.MDBParameter("MatNgu", BenhAnThieuMauCoTimCucBo.MatNgu));
                Command.Parameters.Add(new MDB.MDBParameter("PhuHaiChan", BenhAnThieuMauCoTimCucBo.PhuHaiChan));
                Command.Parameters.Add(new MDB.MDBParameter("MeoMom", BenhAnThieuMauCoTimCucBo.MeoMom));
                Command.Parameters.Add(new MDB.MDBParameter("LietNuaNguoi", BenhAnThieuMauCoTimCucBo.LietNuaNguoi));
                Command.Parameters.Add(new MDB.MDBParameter("GayCung", BenhAnThieuMauCoTimCucBo.GayCung));
                Command.Parameters.Add(new MDB.MDBParameter("TuanThuDieuTri", BenhAnThieuMauCoTimCucBo.TuanThuDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("ThucHienCheDo", BenhAnThieuMauCoTimCucBo.ThucHienCheDo));
                Command.Parameters.Add(new MDB.MDBParameter("HutThuoc", BenhAnThieuMauCoTimCucBo.HutThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("HutThuoc_Dieu", BenhAnThieuMauCoTimCucBo.HutThuoc_Dieu));
                Command.Parameters.Add(new MDB.MDBParameter("UongRuou", BenhAnThieuMauCoTimCucBo.UongRuou));
                Command.Parameters.Add(new MDB.MDBParameter("UongRuou_Ml", BenhAnThieuMauCoTimCucBo.UongRuou_Ml));
                Command.Parameters.Add(new MDB.MDBParameter("CacTrieuChungKhac", BenhAnThieuMauCoTimCucBo.CacTrieuChungKhac));
                Command.Parameters.Add(new MDB.MDBParameter("Cholesterol_TP", BenhAnThieuMauCoTimCucBo.Cholesterol_TP));
                Command.Parameters.Add(new MDB.MDBParameter("TG", BenhAnThieuMauCoTimCucBo.TG));
                Command.Parameters.Add(new MDB.MDBParameter("HDL", BenhAnThieuMauCoTimCucBo.HDL));
                Command.Parameters.Add(new MDB.MDBParameter("LDL", BenhAnThieuMauCoTimCucBo.LDL));
                Command.Parameters.Add(new MDB.MDBParameter("GlucoseMau", BenhAnThieuMauCoTimCucBo.GlucoseMau));
                Command.Parameters.Add(new MDB.MDBParameter("DamNiem", BenhAnThieuMauCoTimCucBo.DamNiem));
                Command.Parameters.Add(new MDB.MDBParameter("CreatininMau", BenhAnThieuMauCoTimCucBo.CreatininMau));
                Command.Parameters.Add(new MDB.MDBParameter("SieuAmTim", BenhAnThieuMauCoTimCucBo.SieuAmTim));
                Command.Parameters.Add(new MDB.MDBParameter("SAT_DayThatTrai", BenhAnThieuMauCoTimCucBo.SAT_DayThatTrai));
                Command.Parameters.Add(new MDB.MDBParameter("DienTamDo", BenhAnThieuMauCoTimCucBo.DienTamDo));
                Command.Parameters.Add(new MDB.MDBParameter("TrucDienTim", BenhAnThieuMauCoTimCucBo.TrucDienTim));
                Command.Parameters.Add(new MDB.MDBParameter("DTD_DayThatTrai", BenhAnThieuMauCoTimCucBo.DTD_DayThatTrai));
                Command.Parameters.Add(new MDB.MDBParameter("XQuangTimPhoi", BenhAnThieuMauCoTimCucBo.XQuangTimPhoi));
                Command.Parameters.Add(new MDB.MDBParameter("MucDoTangHA", BenhAnThieuMauCoTimCucBo.MucDoTangHA));
                Command.Parameters.Add(new MDB.MDBParameter("GiaiDoanTangHA", BenhAnThieuMauCoTimCucBo.GiaiDoanTangHA));
                Command.Parameters.Add(new MDB.MDBParameter("CacBenhPhoiHop", BenhAnThieuMauCoTimCucBo.CacBenhPhoiHop));
                Command.Parameters.Add(new MDB.MDBParameter("THCDTDLS", BenhAnThieuMauCoTimCucBo.THCDTDLS));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocDieuTri", BenhAnThieuMauCoTimCucBo.ThuocDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("HenTaiKham", BenhAnThieuMauCoTimCucBo.HenTaiKham));
                Command.Parameters.Add(new MDB.MDBParameter("BacSy", BenhAnThieuMauCoTimCucBo.BacSy));

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
        public static bool Update(MDB.MDBConnection MyConnection, BenhAnThieuMauCoTimCucBo BenhAnThieuMauCoTimCucBo)
        {
            try
            {
                string sql = @"UPDATE BenhAnThieuMauCoTimCucBo SET 
                            LyDoVaoVien=:LyDoVaoVien,
                            BenhSu=:BenhSu,
                            TienSu=:TienSu,
                            LanKhamDauTien_Ngay=:LanKhamDauTien_Ngay,
                            ChiSoHA=:ChiSoHA,
                            CanNang=:CanNang,
                            ChieuCao=:ChieuCao,
                            VongBung=:VongBung,
                            DauDau=:DauDau,
                            HoKhan=:HoKhan,
                            KhoThoKhiGangSuc=:KhoThoKhiGangSuc,
                            HoiHopDanhTrongNguc=:HoiHopDanhTrongNguc,
                            UTai=:UTai,
                            NoiGiong=:NoiGiong,
                            DauNguc=:DauNguc,
                            MatNgu=:MatNgu,
                            PhuHaiChan=:PhuHaiChan,
                            MeoMom=:MeoMom,
                            LietNuaNguoi=:LietNuaNguoi,
                            GayCung=:GayCung,
                            TuanThuDieuTri=:TuanThuDieuTri,
                            ThucHienCheDo=:ThucHienCheDo,
                            HutThuoc=:HutThuoc,
                            HutThuoc_Dieu=:HutThuoc_Dieu,
                            UongRuou=:UongRuou,
                            UongRuou_Ml=:UongRuou_Ml,
                            CacTrieuChungKhac=:CacTrieuChungKhac,
                            Cholesterol_TP=:Cholesterol_TP,
                            TG=:TG,
                            HDL=:HDL,
                            LDL=:LDL,
                            GlucoseMau=:GlucoseMau,
                            DamNiem=:DamNiem,
                            CreatininMau=:CreatininMau,
                            SieuAmTim=:SieuAmTim,
                            SAT_DayThatTrai=:SAT_DayThatTrai,
                            DienTamDo=:DienTamDo,
                            TrucDienTim=:TrucDienTim,
                            DTD_DayThatTrai=:DTD_DayThatTrai,
                            XQuangTimPhoi=:XQuangTimPhoi,
                            MucDoTangHA=:MucDoTangHA,
                            GiaiDoanTangHA=:GiaiDoanTangHA,
                            CacBenhPhoiHop=:CacBenhPhoiHop,
                            THCDTDLS=:THCDTDLS,
                            ThuocDieuTri=:ThuocDieuTri,
                            HenTaiKham=:HenTaiKham,
                            BacSy=:BacSy
                            WHERE MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnThieuMauCoTimCucBo.LyDoVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("BenhSu", BenhAnThieuMauCoTimCucBo.BenhSu));
                Command.Parameters.Add(new MDB.MDBParameter("TienSu", BenhAnThieuMauCoTimCucBo.TienSu));
                Command.Parameters.Add(new MDB.MDBParameter("LanKhamDauTien_Ngay", BenhAnThieuMauCoTimCucBo.LanKhamDauTien_Ngay));
                Command.Parameters.Add(new MDB.MDBParameter("ChiSoHA", BenhAnThieuMauCoTimCucBo.ChiSoHA));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang", BenhAnThieuMauCoTimCucBo.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("ChieuCao", BenhAnThieuMauCoTimCucBo.ChieuCao));
                Command.Parameters.Add(new MDB.MDBParameter("VongBung", BenhAnThieuMauCoTimCucBo.VongBung));
                Command.Parameters.Add(new MDB.MDBParameter("DauDau", BenhAnThieuMauCoTimCucBo.DauDau));
                Command.Parameters.Add(new MDB.MDBParameter("HoKhan", BenhAnThieuMauCoTimCucBo.HoKhan));
                Command.Parameters.Add(new MDB.MDBParameter("KhoThoKhiGangSuc", BenhAnThieuMauCoTimCucBo.KhoThoKhiGangSuc));
                Command.Parameters.Add(new MDB.MDBParameter("HoiHopDanhTrongNguc", BenhAnThieuMauCoTimCucBo.HoiHopDanhTrongNguc));
                Command.Parameters.Add(new MDB.MDBParameter("UTai", BenhAnThieuMauCoTimCucBo.UTai));
                Command.Parameters.Add(new MDB.MDBParameter("NoiGiong", BenhAnThieuMauCoTimCucBo.NoiGiong));
                Command.Parameters.Add(new MDB.MDBParameter("DauNguc", BenhAnThieuMauCoTimCucBo.DauNguc));
                Command.Parameters.Add(new MDB.MDBParameter("MatNgu", BenhAnThieuMauCoTimCucBo.MatNgu));
                Command.Parameters.Add(new MDB.MDBParameter("PhuHaiChan", BenhAnThieuMauCoTimCucBo.PhuHaiChan));
                Command.Parameters.Add(new MDB.MDBParameter("MeoMom", BenhAnThieuMauCoTimCucBo.MeoMom));
                Command.Parameters.Add(new MDB.MDBParameter("LietNuaNguoi", BenhAnThieuMauCoTimCucBo.LietNuaNguoi));
                Command.Parameters.Add(new MDB.MDBParameter("GayCung", BenhAnThieuMauCoTimCucBo.GayCung));
                Command.Parameters.Add(new MDB.MDBParameter("TuanThuDieuTri", BenhAnThieuMauCoTimCucBo.TuanThuDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("ThucHienCheDo", BenhAnThieuMauCoTimCucBo.ThucHienCheDo));
                Command.Parameters.Add(new MDB.MDBParameter("HutThuoc", BenhAnThieuMauCoTimCucBo.HutThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("HutThuoc_Dieu", BenhAnThieuMauCoTimCucBo.HutThuoc_Dieu));
                Command.Parameters.Add(new MDB.MDBParameter("UongRuou", BenhAnThieuMauCoTimCucBo.UongRuou));
                Command.Parameters.Add(new MDB.MDBParameter("UongRuou_Ml", BenhAnThieuMauCoTimCucBo.UongRuou_Ml));
                Command.Parameters.Add(new MDB.MDBParameter("CacTrieuChungKhac", BenhAnThieuMauCoTimCucBo.CacTrieuChungKhac));
                Command.Parameters.Add(new MDB.MDBParameter("Cholesterol_TP", BenhAnThieuMauCoTimCucBo.Cholesterol_TP));
                Command.Parameters.Add(new MDB.MDBParameter("TG", BenhAnThieuMauCoTimCucBo.TG));
                Command.Parameters.Add(new MDB.MDBParameter("HDL", BenhAnThieuMauCoTimCucBo.HDL));
                Command.Parameters.Add(new MDB.MDBParameter("LDL", BenhAnThieuMauCoTimCucBo.LDL));
                Command.Parameters.Add(new MDB.MDBParameter("GlucoseMau", BenhAnThieuMauCoTimCucBo.GlucoseMau));
                Command.Parameters.Add(new MDB.MDBParameter("DamNiem", BenhAnThieuMauCoTimCucBo.DamNiem));
                Command.Parameters.Add(new MDB.MDBParameter("CreatininMau", BenhAnThieuMauCoTimCucBo.CreatininMau));
                Command.Parameters.Add(new MDB.MDBParameter("SieuAmTim", BenhAnThieuMauCoTimCucBo.SieuAmTim));
                Command.Parameters.Add(new MDB.MDBParameter("SAT_DayThatTrai", BenhAnThieuMauCoTimCucBo.SAT_DayThatTrai));
                Command.Parameters.Add(new MDB.MDBParameter("DienTamDo", BenhAnThieuMauCoTimCucBo.DienTamDo));
                Command.Parameters.Add(new MDB.MDBParameter("TrucDienTim", BenhAnThieuMauCoTimCucBo.TrucDienTim));
                Command.Parameters.Add(new MDB.MDBParameter("DTD_DayThatTrai", BenhAnThieuMauCoTimCucBo.DTD_DayThatTrai));
                Command.Parameters.Add(new MDB.MDBParameter("XQuangTimPhoi", BenhAnThieuMauCoTimCucBo.XQuangTimPhoi));
                Command.Parameters.Add(new MDB.MDBParameter("MucDoTangHA", BenhAnThieuMauCoTimCucBo.MucDoTangHA));
                Command.Parameters.Add(new MDB.MDBParameter("GiaiDoanTangHA", BenhAnThieuMauCoTimCucBo.GiaiDoanTangHA));
                Command.Parameters.Add(new MDB.MDBParameter("CacBenhPhoiHop", BenhAnThieuMauCoTimCucBo.CacBenhPhoiHop));
                Command.Parameters.Add(new MDB.MDBParameter("THCDTDLS", BenhAnThieuMauCoTimCucBo.THCDTDLS));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocDieuTri", BenhAnThieuMauCoTimCucBo.ThuocDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("HenTaiKham", BenhAnThieuMauCoTimCucBo.HenTaiKham));
                Command.Parameters.Add(new MDB.MDBParameter("BacSy", BenhAnThieuMauCoTimCucBo.BacSy));

                Command.BindByName = true;

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnThieuMauCoTimCucBo.MaQuanLy));
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
