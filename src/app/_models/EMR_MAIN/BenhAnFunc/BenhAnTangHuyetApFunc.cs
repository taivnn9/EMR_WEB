using EMR_MAIN.DATABASE.BenhAn;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.BenhAnFunc
{
    public class BenhAnTangHuyetApFunc
    {
        public static void WriteXml(MDB.MDBConnection MyConnection)
        {
            string sql =
                   @"
                  select  a.*,  CTScanner HoSo_CTScanner, SieuAm HoSo_SieuAm, XetNghiem HoSo_XetNghiem,  Khac HoSo_Khac,  Khac_Text HoSo_Khac_Text,  ToanBoHoSo HoSo_ToanBoHoSo, Mach DauSinhTon_Mach,  NhietDo DauSinhTon_NhietDo,  HuyetAp DauSinhTon_HuyetAp,  NhipTho DauSinhTon_NhipTho,  CanNang DauSinhTon_CanNang  
                  from BenhAnTangHuyetAp a inner join thongtindieutri b on a.maquanly = b.maquanly
                  where rownum = 1
                    ";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            var DataTable = new DataTable { TableName = "BenhAnTangHuyetAp" };
            DataTable.Load(DataReader as IDataReader);
            DataTable.WriteXml("rptBenhAnTangHuyetAp.xml");
        }
        public static DataSet SelectDataSet(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql =
                   @"
                  select  a.*, f.hovaten BacSyHoVaTen 
                        from BenhAnTangHuyetAp a  
                  left join nhanvien f on a.BacSy = f.manhanvien
                  where a.maquanly = " + MaQuanLy;
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(sql, MyConnection);
            var ds = new DataSet();
            adt.Fill(ds, "Table");

            return ds;
        }
        public static BenhAnTangHuyetAp Select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            var obj = new BenhAnTangHuyetAp();
            try
            {
                #region
                string sql =
                          @"select * 
                        from BenhAnTangHuyetAp 
                        where MaQuanLy = :MaQuanLy";
                #endregion
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    // Phần chung Hành chính
                    obj.MaQuanLy = DataReader.GetDecimal("MaQuanLy");
                    obj.SoLuu = DataReader["SoLuu"].ToString();
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
                   
                    obj.PhuHaiChan = DataReader.GetInt("PhuHaiChan");
                    obj.MeoMom = DataReader.GetInt("MeoMom");
                   
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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, BenhAnTangHuyetAp BenhAnTangHuyetAp)
        {
            try
            {
                string sql =
                          @"select MaQuanLy 
                            from BenhAnTangHuyetAp
                            where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnTangHuyetAp.MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                int rowCount = 0;
                while (DataReader.Read()) rowCount++;
                if (rowCount == 1) return Update(MyConnection, BenhAnTangHuyetAp);
                sql = @"
                       INSERT INTO BenhAnTangHuyetAp 
                        (
                            MaQuanLy,
                            SoLuu,
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
                            PhuHaiChan,
                            MeoMom,
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
                            :SoLuu,
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
                            :PhuHaiChan,
                            :MeoMom,
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
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnTangHuyetAp.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("SoLuu", BenhAnTangHuyetAp.SoLuu));
                Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnTangHuyetAp.LyDoVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("BenhSu", BenhAnTangHuyetAp.BenhSu));
                Command.Parameters.Add(new MDB.MDBParameter("TienSu", BenhAnTangHuyetAp.TienSu));
                Command.Parameters.Add(new MDB.MDBParameter("LanKhamDauTien_Ngay", BenhAnTangHuyetAp.LanKhamDauTien_Ngay));
                Command.Parameters.Add(new MDB.MDBParameter("ChiSoHA", BenhAnTangHuyetAp.ChiSoHA));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang", BenhAnTangHuyetAp.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("ChieuCao", BenhAnTangHuyetAp.ChieuCao));
                Command.Parameters.Add(new MDB.MDBParameter("VongBung", BenhAnTangHuyetAp.VongBung));
                Command.Parameters.Add(new MDB.MDBParameter("DauDau", BenhAnTangHuyetAp.DauDau));
                Command.Parameters.Add(new MDB.MDBParameter("HoKhan", BenhAnTangHuyetAp.HoKhan));
                Command.Parameters.Add(new MDB.MDBParameter("KhoThoKhiGangSuc", BenhAnTangHuyetAp.KhoThoKhiGangSuc));
                Command.Parameters.Add(new MDB.MDBParameter("HoiHopDanhTrongNguc", BenhAnTangHuyetAp.HoiHopDanhTrongNguc));
                Command.Parameters.Add(new MDB.MDBParameter("PhuHaiChan", BenhAnTangHuyetAp.PhuHaiChan));
                Command.Parameters.Add(new MDB.MDBParameter("MeoMom", BenhAnTangHuyetAp.MeoMom));
                Command.Parameters.Add(new MDB.MDBParameter("TuanThuDieuTri", BenhAnTangHuyetAp.TuanThuDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("ThucHienCheDo", BenhAnTangHuyetAp.ThucHienCheDo));
                Command.Parameters.Add(new MDB.MDBParameter("HutThuoc", BenhAnTangHuyetAp.HutThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("HutThuoc_Dieu", BenhAnTangHuyetAp.HutThuoc_Dieu));
                Command.Parameters.Add(new MDB.MDBParameter("UongRuou", BenhAnTangHuyetAp.UongRuou));
                Command.Parameters.Add(new MDB.MDBParameter("UongRuou_Ml", BenhAnTangHuyetAp.UongRuou_Ml));
                Command.Parameters.Add(new MDB.MDBParameter("CacTrieuChungKhac", BenhAnTangHuyetAp.CacTrieuChungKhac));
                Command.Parameters.Add(new MDB.MDBParameter("Cholesterol_TP", BenhAnTangHuyetAp.Cholesterol_TP));
                Command.Parameters.Add(new MDB.MDBParameter("TG", BenhAnTangHuyetAp.TG));
                Command.Parameters.Add(new MDB.MDBParameter("HDL", BenhAnTangHuyetAp.HDL));
                Command.Parameters.Add(new MDB.MDBParameter("LDL", BenhAnTangHuyetAp.LDL));
                Command.Parameters.Add(new MDB.MDBParameter("GlucoseMau", BenhAnTangHuyetAp.GlucoseMau));
                Command.Parameters.Add(new MDB.MDBParameter("DamNiem", BenhAnTangHuyetAp.DamNiem));
                Command.Parameters.Add(new MDB.MDBParameter("CreatininMau", BenhAnTangHuyetAp.CreatininMau));
                Command.Parameters.Add(new MDB.MDBParameter("SieuAmTim", BenhAnTangHuyetAp.SieuAmTim));
                Command.Parameters.Add(new MDB.MDBParameter("SAT_DayThatTrai", BenhAnTangHuyetAp.SAT_DayThatTrai));
                Command.Parameters.Add(new MDB.MDBParameter("DienTamDo", BenhAnTangHuyetAp.DienTamDo));
                Command.Parameters.Add(new MDB.MDBParameter("TrucDienTim", BenhAnTangHuyetAp.TrucDienTim));
                Command.Parameters.Add(new MDB.MDBParameter("DTD_DayThatTrai", BenhAnTangHuyetAp.DTD_DayThatTrai));
                Command.Parameters.Add(new MDB.MDBParameter("XQuangTimPhoi", BenhAnTangHuyetAp.XQuangTimPhoi));
                Command.Parameters.Add(new MDB.MDBParameter("MucDoTangHA", BenhAnTangHuyetAp.MucDoTangHA));
                Command.Parameters.Add(new MDB.MDBParameter("GiaiDoanTangHA", BenhAnTangHuyetAp.GiaiDoanTangHA));
                Command.Parameters.Add(new MDB.MDBParameter("CacBenhPhoiHop", BenhAnTangHuyetAp.CacBenhPhoiHop));
                Command.Parameters.Add(new MDB.MDBParameter("THCDTDLS", BenhAnTangHuyetAp.THCDTDLS));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocDieuTri", BenhAnTangHuyetAp.ThuocDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("HenTaiKham", BenhAnTangHuyetAp.HenTaiKham));
                Command.Parameters.Add(new MDB.MDBParameter("BacSy", BenhAnTangHuyetAp.BacSy));

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
        public static bool Update(MDB.MDBConnection MyConnection, BenhAnTangHuyetAp BenhAnTangHuyetAp)
        {
            try
            {
                string sql = @"UPDATE BenhAnTangHuyetAp SET 
                            SoLuu = :SoLuu,
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
                            PhuHaiChan=:PhuHaiChan,
                            MeoMom=:MeoMom,
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
                Command.Parameters.Add(new MDB.MDBParameter("SoLuu", BenhAnTangHuyetAp.SoLuu));
                Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", BenhAnTangHuyetAp.LyDoVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("BenhSu", BenhAnTangHuyetAp.BenhSu));
                Command.Parameters.Add(new MDB.MDBParameter("TienSu", BenhAnTangHuyetAp.TienSu));
                Command.Parameters.Add(new MDB.MDBParameter("LanKhamDauTien_Ngay", BenhAnTangHuyetAp.LanKhamDauTien_Ngay));
                Command.Parameters.Add(new MDB.MDBParameter("ChiSoHA", BenhAnTangHuyetAp.ChiSoHA));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang", BenhAnTangHuyetAp.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("ChieuCao", BenhAnTangHuyetAp.ChieuCao));
                Command.Parameters.Add(new MDB.MDBParameter("VongBung", BenhAnTangHuyetAp.VongBung));
                Command.Parameters.Add(new MDB.MDBParameter("DauDau", BenhAnTangHuyetAp.DauDau));
                Command.Parameters.Add(new MDB.MDBParameter("HoKhan", BenhAnTangHuyetAp.HoKhan));
                Command.Parameters.Add(new MDB.MDBParameter("KhoThoKhiGangSuc", BenhAnTangHuyetAp.KhoThoKhiGangSuc));
                Command.Parameters.Add(new MDB.MDBParameter("HoiHopDanhTrongNguc", BenhAnTangHuyetAp.HoiHopDanhTrongNguc));
                Command.Parameters.Add(new MDB.MDBParameter("PhuHaiChan", BenhAnTangHuyetAp.PhuHaiChan));
                Command.Parameters.Add(new MDB.MDBParameter("MeoMom", BenhAnTangHuyetAp.MeoMom));
                Command.Parameters.Add(new MDB.MDBParameter("TuanThuDieuTri", BenhAnTangHuyetAp.TuanThuDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("ThucHienCheDo", BenhAnTangHuyetAp.ThucHienCheDo));
                Command.Parameters.Add(new MDB.MDBParameter("HutThuoc", BenhAnTangHuyetAp.HutThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("HutThuoc_Dieu", BenhAnTangHuyetAp.HutThuoc_Dieu));
                Command.Parameters.Add(new MDB.MDBParameter("UongRuou", BenhAnTangHuyetAp.UongRuou));
                Command.Parameters.Add(new MDB.MDBParameter("UongRuou_Ml", BenhAnTangHuyetAp.UongRuou_Ml));
                Command.Parameters.Add(new MDB.MDBParameter("CacTrieuChungKhac", BenhAnTangHuyetAp.CacTrieuChungKhac));
                Command.Parameters.Add(new MDB.MDBParameter("Cholesterol_TP", BenhAnTangHuyetAp.Cholesterol_TP));
                Command.Parameters.Add(new MDB.MDBParameter("TG", BenhAnTangHuyetAp.TG));
                Command.Parameters.Add(new MDB.MDBParameter("HDL", BenhAnTangHuyetAp.HDL));
                Command.Parameters.Add(new MDB.MDBParameter("LDL", BenhAnTangHuyetAp.LDL));
                Command.Parameters.Add(new MDB.MDBParameter("GlucoseMau", BenhAnTangHuyetAp.GlucoseMau));
                Command.Parameters.Add(new MDB.MDBParameter("DamNiem", BenhAnTangHuyetAp.DamNiem));
                Command.Parameters.Add(new MDB.MDBParameter("CreatininMau", BenhAnTangHuyetAp.CreatininMau));
                Command.Parameters.Add(new MDB.MDBParameter("SieuAmTim", BenhAnTangHuyetAp.SieuAmTim));
                Command.Parameters.Add(new MDB.MDBParameter("SAT_DayThatTrai", BenhAnTangHuyetAp.SAT_DayThatTrai));
                Command.Parameters.Add(new MDB.MDBParameter("DienTamDo", BenhAnTangHuyetAp.DienTamDo));
                Command.Parameters.Add(new MDB.MDBParameter("TrucDienTim", BenhAnTangHuyetAp.TrucDienTim));
                Command.Parameters.Add(new MDB.MDBParameter("DTD_DayThatTrai", BenhAnTangHuyetAp.DTD_DayThatTrai));
                Command.Parameters.Add(new MDB.MDBParameter("XQuangTimPhoi", BenhAnTangHuyetAp.XQuangTimPhoi));
                Command.Parameters.Add(new MDB.MDBParameter("MucDoTangHA", BenhAnTangHuyetAp.MucDoTangHA));
                Command.Parameters.Add(new MDB.MDBParameter("GiaiDoanTangHA", BenhAnTangHuyetAp.GiaiDoanTangHA));
                Command.Parameters.Add(new MDB.MDBParameter("CacBenhPhoiHop", BenhAnTangHuyetAp.CacBenhPhoiHop));
                Command.Parameters.Add(new MDB.MDBParameter("THCDTDLS", BenhAnTangHuyetAp.THCDTDLS));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocDieuTri", BenhAnTangHuyetAp.ThuocDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("HenTaiKham", BenhAnTangHuyetAp.HenTaiKham));
                Command.Parameters.Add(new MDB.MDBParameter("BacSy", BenhAnTangHuyetAp.BacSy));

                Command.BindByName = true;

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnTangHuyetAp.MaQuanLy));
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
