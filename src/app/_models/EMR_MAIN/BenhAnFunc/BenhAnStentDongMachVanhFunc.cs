using EMR_MAIN.DATABASE.BenhAn;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.BenhAnFunc
{
    public class BenhAnStentDongMachVanhFunc
    {
        public static void WriteXml(MDB.MDBConnection MyConnection)
        {
            string sql =
                   @"
                  select  a.*,  CTScanner HoSo_CTScanner, SieuAm HoSo_SieuAm, XetNghiem HoSo_XetNghiem,  Khac HoSo_Khac,  Khac_Text HoSo_Khac_Text,  ToanBoHoSo HoSo_ToanBoHoSo, Mach DauSinhTon_Mach,  NhietDo DauSinhTon_NhietDo,  HuyetAp DauSinhTon_HuyetAp,  NhipTho DauSinhTon_NhipTho,  CanNang DauSinhTon_CanNang  
                  from BenhAnStentDongMachVanh a inner join thongtindieutri b on a.maquanly = b.maquanly
                  where rownum = 1
                    ";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            var DataTable = new DataTable { TableName = "BenhAnStentDongMachVanh" };
            DataTable.Load(DataReader as IDataReader);
            DataTable.WriteXml("rptBenhAnStentDongMachVanh.xml");
        }
        public static DataSet SelectDataSet(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql =
                   @"
                  select  a.*, f.hovaten BacSyHoVaTen 
                        from BenhAnStentDongMachVanh a  
                  left join nhanvien f on a.BacSy = f.manhanvien
                  where a.maquanly = " + MaQuanLy;
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(sql, MyConnection);
            var ds = new DataSet();
            adt.Fill(ds, "Table");

            return ds;
        }
        public static BenhAnStentDongMachVanh Select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            var obj = new BenhAnStentDongMachVanh();
            try
            {
                #region
                string sql =
                          @"select * 
                        from BenhAnStentDongMachVanh 
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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, BenhAnStentDongMachVanh BenhAnStentDongMachVanh)
        {
            try
            {
                string sql =
                          @"select MaQuanLy 
                            from BenhAnStentDongMachVanh
                            where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnStentDongMachVanh.MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                int rowCount = 0;
                while (DataReader.Read()) rowCount++;
                if (rowCount == 1) return Update(MyConnection, BenhAnStentDongMachVanh);
                sql = @"
                       INSERT INTO BenhAnStentDongMachVanh 
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
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnStentDongMachVanh.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnStentDongMachVanh.LyDoVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("BenhSu", BenhAnStentDongMachVanh.BenhSu));
                Command.Parameters.Add(new MDB.MDBParameter("TienSu", BenhAnStentDongMachVanh.TienSu));
                Command.Parameters.Add(new MDB.MDBParameter("LanKhamDauTien_Ngay", BenhAnStentDongMachVanh.LanKhamDauTien_Ngay));
                Command.Parameters.Add(new MDB.MDBParameter("ChiSoHA", BenhAnStentDongMachVanh.ChiSoHA));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang", BenhAnStentDongMachVanh.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("ChieuCao", BenhAnStentDongMachVanh.ChieuCao));
                Command.Parameters.Add(new MDB.MDBParameter("VongBung", BenhAnStentDongMachVanh.VongBung));
                Command.Parameters.Add(new MDB.MDBParameter("DauDau", BenhAnStentDongMachVanh.DauDau));
                Command.Parameters.Add(new MDB.MDBParameter("HoKhan", BenhAnStentDongMachVanh.HoKhan));
                Command.Parameters.Add(new MDB.MDBParameter("KhoThoKhiGangSuc", BenhAnStentDongMachVanh.KhoThoKhiGangSuc));
                Command.Parameters.Add(new MDB.MDBParameter("HoiHopDanhTrongNguc", BenhAnStentDongMachVanh.HoiHopDanhTrongNguc));
                Command.Parameters.Add(new MDB.MDBParameter("UTai", BenhAnStentDongMachVanh.UTai));
                Command.Parameters.Add(new MDB.MDBParameter("NoiGiong", BenhAnStentDongMachVanh.NoiGiong));
                Command.Parameters.Add(new MDB.MDBParameter("DauNguc", BenhAnStentDongMachVanh.DauNguc));
                Command.Parameters.Add(new MDB.MDBParameter("MatNgu", BenhAnStentDongMachVanh.MatNgu));
                Command.Parameters.Add(new MDB.MDBParameter("PhuHaiChan", BenhAnStentDongMachVanh.PhuHaiChan));
                Command.Parameters.Add(new MDB.MDBParameter("MeoMom", BenhAnStentDongMachVanh.MeoMom));
                Command.Parameters.Add(new MDB.MDBParameter("LietNuaNguoi", BenhAnStentDongMachVanh.LietNuaNguoi));
                Command.Parameters.Add(new MDB.MDBParameter("GayCung", BenhAnStentDongMachVanh.GayCung));
                Command.Parameters.Add(new MDB.MDBParameter("TuanThuDieuTri", BenhAnStentDongMachVanh.TuanThuDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("ThucHienCheDo", BenhAnStentDongMachVanh.ThucHienCheDo));
                Command.Parameters.Add(new MDB.MDBParameter("HutThuoc", BenhAnStentDongMachVanh.HutThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("HutThuoc_Dieu", BenhAnStentDongMachVanh.HutThuoc_Dieu));
                Command.Parameters.Add(new MDB.MDBParameter("UongRuou", BenhAnStentDongMachVanh.UongRuou));
                Command.Parameters.Add(new MDB.MDBParameter("UongRuou_Ml", BenhAnStentDongMachVanh.UongRuou_Ml));
                Command.Parameters.Add(new MDB.MDBParameter("CacTrieuChungKhac", BenhAnStentDongMachVanh.CacTrieuChungKhac));
                Command.Parameters.Add(new MDB.MDBParameter("Cholesterol_TP", BenhAnStentDongMachVanh.Cholesterol_TP));
                Command.Parameters.Add(new MDB.MDBParameter("TG", BenhAnStentDongMachVanh.TG));
                Command.Parameters.Add(new MDB.MDBParameter("HDL", BenhAnStentDongMachVanh.HDL));
                Command.Parameters.Add(new MDB.MDBParameter("LDL", BenhAnStentDongMachVanh.LDL));
                Command.Parameters.Add(new MDB.MDBParameter("GlucoseMau", BenhAnStentDongMachVanh.GlucoseMau));
                Command.Parameters.Add(new MDB.MDBParameter("DamNiem", BenhAnStentDongMachVanh.DamNiem));
                Command.Parameters.Add(new MDB.MDBParameter("CreatininMau", BenhAnStentDongMachVanh.CreatininMau));
                Command.Parameters.Add(new MDB.MDBParameter("SieuAmTim", BenhAnStentDongMachVanh.SieuAmTim));
                Command.Parameters.Add(new MDB.MDBParameter("SAT_DayThatTrai", BenhAnStentDongMachVanh.SAT_DayThatTrai));
                Command.Parameters.Add(new MDB.MDBParameter("DienTamDo", BenhAnStentDongMachVanh.DienTamDo));
                Command.Parameters.Add(new MDB.MDBParameter("TrucDienTim", BenhAnStentDongMachVanh.TrucDienTim));
                Command.Parameters.Add(new MDB.MDBParameter("DTD_DayThatTrai", BenhAnStentDongMachVanh.DTD_DayThatTrai));
                Command.Parameters.Add(new MDB.MDBParameter("XQuangTimPhoi", BenhAnStentDongMachVanh.XQuangTimPhoi));
                Command.Parameters.Add(new MDB.MDBParameter("MucDoTangHA", BenhAnStentDongMachVanh.MucDoTangHA));
                Command.Parameters.Add(new MDB.MDBParameter("GiaiDoanTangHA", BenhAnStentDongMachVanh.GiaiDoanTangHA));
                Command.Parameters.Add(new MDB.MDBParameter("CacBenhPhoiHop", BenhAnStentDongMachVanh.CacBenhPhoiHop));
                Command.Parameters.Add(new MDB.MDBParameter("THCDTDLS", BenhAnStentDongMachVanh.THCDTDLS));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocDieuTri", BenhAnStentDongMachVanh.ThuocDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("HenTaiKham", BenhAnStentDongMachVanh.HenTaiKham));
                Command.Parameters.Add(new MDB.MDBParameter("BacSy", BenhAnStentDongMachVanh.BacSy));

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
        public static bool Update(MDB.MDBConnection MyConnection, BenhAnStentDongMachVanh BenhAnStentDongMachVanh)
        {
            try
            {
                string sql = @"UPDATE BenhAnStentDongMachVanh SET 
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
                Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnStentDongMachVanh.LyDoVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("BenhSu", BenhAnStentDongMachVanh.BenhSu));
                Command.Parameters.Add(new MDB.MDBParameter("TienSu", BenhAnStentDongMachVanh.TienSu));
                Command.Parameters.Add(new MDB.MDBParameter("LanKhamDauTien_Ngay", BenhAnStentDongMachVanh.LanKhamDauTien_Ngay));
                Command.Parameters.Add(new MDB.MDBParameter("ChiSoHA", BenhAnStentDongMachVanh.ChiSoHA));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang", BenhAnStentDongMachVanh.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("ChieuCao", BenhAnStentDongMachVanh.ChieuCao));
                Command.Parameters.Add(new MDB.MDBParameter("VongBung", BenhAnStentDongMachVanh.VongBung));
                Command.Parameters.Add(new MDB.MDBParameter("DauDau", BenhAnStentDongMachVanh.DauDau));
                Command.Parameters.Add(new MDB.MDBParameter("HoKhan", BenhAnStentDongMachVanh.HoKhan));
                Command.Parameters.Add(new MDB.MDBParameter("KhoThoKhiGangSuc", BenhAnStentDongMachVanh.KhoThoKhiGangSuc));
                Command.Parameters.Add(new MDB.MDBParameter("HoiHopDanhTrongNguc", BenhAnStentDongMachVanh.HoiHopDanhTrongNguc));
                Command.Parameters.Add(new MDB.MDBParameter("UTai", BenhAnStentDongMachVanh.UTai));
                Command.Parameters.Add(new MDB.MDBParameter("NoiGiong", BenhAnStentDongMachVanh.NoiGiong));
                Command.Parameters.Add(new MDB.MDBParameter("DauNguc", BenhAnStentDongMachVanh.DauNguc));
                Command.Parameters.Add(new MDB.MDBParameter("MatNgu", BenhAnStentDongMachVanh.MatNgu));
                Command.Parameters.Add(new MDB.MDBParameter("PhuHaiChan", BenhAnStentDongMachVanh.PhuHaiChan));
                Command.Parameters.Add(new MDB.MDBParameter("MeoMom", BenhAnStentDongMachVanh.MeoMom));
                Command.Parameters.Add(new MDB.MDBParameter("LietNuaNguoi", BenhAnStentDongMachVanh.LietNuaNguoi));
                Command.Parameters.Add(new MDB.MDBParameter("GayCung", BenhAnStentDongMachVanh.GayCung));
                Command.Parameters.Add(new MDB.MDBParameter("TuanThuDieuTri", BenhAnStentDongMachVanh.TuanThuDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("ThucHienCheDo", BenhAnStentDongMachVanh.ThucHienCheDo));
                Command.Parameters.Add(new MDB.MDBParameter("HutThuoc", BenhAnStentDongMachVanh.HutThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("HutThuoc_Dieu", BenhAnStentDongMachVanh.HutThuoc_Dieu));
                Command.Parameters.Add(new MDB.MDBParameter("UongRuou", BenhAnStentDongMachVanh.UongRuou));
                Command.Parameters.Add(new MDB.MDBParameter("UongRuou_Ml", BenhAnStentDongMachVanh.UongRuou_Ml));
                Command.Parameters.Add(new MDB.MDBParameter("CacTrieuChungKhac", BenhAnStentDongMachVanh.CacTrieuChungKhac));
                Command.Parameters.Add(new MDB.MDBParameter("Cholesterol_TP", BenhAnStentDongMachVanh.Cholesterol_TP));
                Command.Parameters.Add(new MDB.MDBParameter("TG", BenhAnStentDongMachVanh.TG));
                Command.Parameters.Add(new MDB.MDBParameter("HDL", BenhAnStentDongMachVanh.HDL));
                Command.Parameters.Add(new MDB.MDBParameter("LDL", BenhAnStentDongMachVanh.LDL));
                Command.Parameters.Add(new MDB.MDBParameter("GlucoseMau", BenhAnStentDongMachVanh.GlucoseMau));
                Command.Parameters.Add(new MDB.MDBParameter("DamNiem", BenhAnStentDongMachVanh.DamNiem));
                Command.Parameters.Add(new MDB.MDBParameter("CreatininMau", BenhAnStentDongMachVanh.CreatininMau));
                Command.Parameters.Add(new MDB.MDBParameter("SieuAmTim", BenhAnStentDongMachVanh.SieuAmTim));
                Command.Parameters.Add(new MDB.MDBParameter("SAT_DayThatTrai", BenhAnStentDongMachVanh.SAT_DayThatTrai));
                Command.Parameters.Add(new MDB.MDBParameter("DienTamDo", BenhAnStentDongMachVanh.DienTamDo));
                Command.Parameters.Add(new MDB.MDBParameter("TrucDienTim", BenhAnStentDongMachVanh.TrucDienTim));
                Command.Parameters.Add(new MDB.MDBParameter("DTD_DayThatTrai", BenhAnStentDongMachVanh.DTD_DayThatTrai));
                Command.Parameters.Add(new MDB.MDBParameter("XQuangTimPhoi", BenhAnStentDongMachVanh.XQuangTimPhoi));
                Command.Parameters.Add(new MDB.MDBParameter("MucDoTangHA", BenhAnStentDongMachVanh.MucDoTangHA));
                Command.Parameters.Add(new MDB.MDBParameter("GiaiDoanTangHA", BenhAnStentDongMachVanh.GiaiDoanTangHA));
                Command.Parameters.Add(new MDB.MDBParameter("CacBenhPhoiHop", BenhAnStentDongMachVanh.CacBenhPhoiHop));
                Command.Parameters.Add(new MDB.MDBParameter("THCDTDLS", BenhAnStentDongMachVanh.THCDTDLS));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocDieuTri", BenhAnStentDongMachVanh.ThuocDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("HenTaiKham", BenhAnStentDongMachVanh.HenTaiKham));
                Command.Parameters.Add(new MDB.MDBParameter("BacSy", BenhAnStentDongMachVanh.BacSy));

                Command.BindByName = true;

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnStentDongMachVanh.MaQuanLy));
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
