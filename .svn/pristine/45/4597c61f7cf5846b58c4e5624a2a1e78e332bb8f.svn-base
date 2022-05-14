using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections.ObjectModel;
using EMR_MAIN.DATABASE.BenhAn;
using MedilinkHL7.SDK;
using Newtonsoft.Json;
using EMR_MAIN.DATABASE.Other;
using System.Globalization;

namespace EMR_MAIN.DATABASE.BenhAnFunc
{
    public class BANgoaiTruPKFunc
    {
        public static void WriteXml(MDB.MDBConnection MyConnection)
        {
            string sql =
                   @"
                  select  a.*,  CTScanner HoSo_CTScanner, SieuAm HoSo_SieuAm, XetNghiem HoSo_XetNghiem,  Khac HoSo_Khac,  Khac_Text HoSo_Khac_Text,  ToanBoHoSo HoSo_ToanBoHoSo, Mach DauSinhTon_Mach,  NhietDo DauSinhTon_NhietDo,  HuyetAp DauSinhTon_HuyetAp,  NhipTho DauSinhTon_NhipTho,  CanNang DauSinhTon_CanNang  
                  from BenhAnNgoaiTruPK a inner join thongtindieutri b on a.maquanly = b.maquanly
                  where rownum = 1
                    ";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            var DataTable = new DataTable { TableName = "BenhAnNgoaiTruPK" };
            DataTable.Load(DataReader as IDataReader);
            DataTable.WriteXml("rptBenhAnNgoaiTruPK.xml");
        }
        public static DataSet SelectDataSet(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql =
                   @"
                   select  a.* from BenhAnNgoaiTruPK a  where a.maquanly = " + MaQuanLy.ToString(CultureInfo.InvariantCulture);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(sql, MyConnection);
            var ds = new DataSet();
            adt.Fill(ds, "Table");
            sql = @"select AA.*, CONCAT(CONCAT(to_char(NgayKham,'DD/MM/YYYY'), '-'), to_char(NgayKhamLai,'DD/MM/YYYY')) as NgayKham_NgayKhamLai, CONCAT(CONCAT(CanNang, '/'), ChieuCao) as CanNang_ChieuCao  from BenhAnNgoaiTruPK_TheoDoi AA where IDMaPhieu = " + MaQuanLy+ " ORDER BY IDMaPhieuChiTiet";
            MDB.MDBDataAdapter adt1 = new MDB.MDBDataAdapter(sql, MyConnection);
            adt1.Fill(ds, "ThongTinCT");

            return ds;
        }
        public static BANgoaiTruPK Select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            var obj = new BANgoaiTruPK();
            try
            {
                #region
                string sql =
                          @"select * 
                        from BenhAnNgoaiTruPK a
                        where MaQuanLy = :MaQuanLy";
                #endregion
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    obj.MaQuanLy = DataReader.GetDecimal("MaQuanLy");
                    obj.ChieuCao = Common.ConDBNull_float(DataReader["ChieuCao"]);
                    obj.CanNang = Common.ConDBNull_float(DataReader["CanNang"]);
                    obj.NhietDo = Common.ConDBNull_float(DataReader["NhietDo"]);
                    obj.BenhCoHoiKemTheo = Common.ConDBNull(DataReader["BenhCoHoiKemTheo"]);
                    obj.GDLamSangHIV = Common.ConDB_Int(DataReader["GDLamSangHIV"]);
                    obj.CD4 = Common.ConDBNull(DataReader["CD4"]);
                    obj.Hb = Common.ConDBNull(DataReader["Hb"]);
                    obj.ALT = Common.ConDBNull(DataReader["ALT"]);
                    obj.HBsAg = Common.ConDBNull(DataReader["HBsAg"]);
                    obj.AntiHCV = Common.ConDBNull(DataReader["AntiHCV"]);
                    obj.Creatinine = Common.ConDBNull(DataReader["Creatinine"]);
                    obj.XetNghiemKhac = Common.ConDBNull(DataReader["XetNghiemKhac"]);
                    obj.NgayLayMau1 = Common.ConDB_DateTimeNull(DataReader["NgayLayMau1"]);
                    obj.KetQua1 = Common.ConDBNull(DataReader["KetQua1"]);
                    obj.NgayLayMau2 = Common.ConDB_DateTimeNull(DataReader["NgayLayMau2"]);
                    obj.KetQua2 = Common.ConDBNull(DataReader["KetQua2"]);
                    obj.XuTru1 = Common.ConDB_Int(DataReader["XuTru1"]);
                    obj.XuTru2 = Common.ConDB_Int(DataReader["XuTru2"]);
                    obj.XuTru3 = Common.ConDB_Int(DataReader["XuTru3"]);
                    obj.NDXuTru3 = Common.ConDBNull(DataReader["NDXuTru3"]);
                    obj.XuTru4 = Common.ConDB_Int(DataReader["XuTru4"]);
                    obj.NDXuTru4 = Common.ConDBNull(DataReader["NDXuTru4"]);
                    obj.XuTru5 = Common.ConDB_Int(DataReader["XuTru5"]);
                    obj.XuTru6 = Common.ConDB_Int(DataReader["XuTru6"]);
                    obj.XuTru7 = Common.ConDB_Int(DataReader["XuTru7"]);
                    obj.NDXuTru7 = Common.ConDBNull(DataReader["NDXuTru7"]);
                    obj.TTKhiDK1 = Common.ConDB_Int(DataReader["TTKhiDK1"]);
                    obj.TTKhiDK2 = Common.ConDB_Int(DataReader["TTKhiDK2"]);
                    obj.TTKhiDK3 = Common.ConDB_Int(DataReader["TTKhiDK3"]);
                    obj.NDTTKhiDK3 = Common.ConDBNull(DataReader["NDTTKhiDK3"]);
                    obj.TTKhiDK4 = Common.ConDB_Int(DataReader["TTKhiDK4"]);
                    obj.NDTTKhiDK4 = Common.ConDBNull(DataReader["NDTTKhiDK4"]);
                    obj.TTKhiDK5 = Common.ConDB_Int(DataReader["TTKhiDK5"]);
                    obj.TTKhiDK6 = Common.ConDB_Int(DataReader["TTKhiDK6"]);
                    obj.TTKhiDK7 = Common.ConDB_Int(DataReader["TTKhiDK7"]);
                    obj.TSDungThuocARV1 = Common.ConDB_Int(DataReader["TSDungThuocARV1"]);
                    obj.TSDungThuocARV2 = Common.ConDB_Int(DataReader["TSDungThuocARV2"]);
                    obj.TSDungThuocARV3 = Common.ConDBNull(DataReader["TSDungThuocARV3"]);
                    obj.TSBenhBanThan = Common.ConDBNull(DataReader["TSBenhBanThan"]);
                    obj.TienSuDUT = Common.ConDBNull(DataReader["TienSuDUT"]);
                    obj.TienSuNuoiDuong = Common.ConDBNull(DataReader["TienSuNuoiDuong"]);
                    obj.KQXNPCRL1 = Common.ConDBNull(DataReader["KQXNPCRL1"]);
                    obj.KQXNPCRL2 = Common.ConDBNull(DataReader["KQXNPCRL2"]);
                    obj.NamSinh1 = Common.ConDBNull(DataReader["NamSinh1"]);
                    obj.TTHIV1 = Common.ConDB_Int(DataReader["TTHIV1"]);
                    obj.NoiDT1 = Common.ConDBNull(DataReader["NoiDT1"]);
                    obj.DangDTARV1 = Common.ConDBNull(DataReader["DangDTARV1"]);
                    obj.NamSinh2 = Common.ConDBNull(DataReader["NamSinh2"]);
                    obj.TTHIV2 = Common.ConDB_Int(DataReader["TTHIV2"]);
                    obj.NoiDT2 = Common.ConDBNull(DataReader["NoiDT2"]);
                    obj.DangDTARV2 = Common.ConDBNull(DataReader["DangDTARV2"]);
                    obj.NamSinh3 = Common.ConDBNull(DataReader["NamSinh3"]);
                    obj.TTHIV3 = Common.ConDB_Int(DataReader["TTHIV3"]);
                    obj.NoiDT3 = Common.ConDBNull(DataReader["NoiDT3"]);
                    obj.DangDTARV3 = Common.ConDBNull(DataReader["DangDTARV3"]);
                    obj.NamSinh4 = Common.ConDBNull(DataReader["NamSinh4"]);
                    obj.TTHIV4 = Common.ConDB_Int(DataReader["TTHIV4"]);
                    obj.NoiDT4 = Common.ConDBNull(DataReader["NoiDT4"]);
                    obj.DangDTARV4 = Common.ConDBNull(DataReader["DangDTARV4"]);
                    obj.NamSinh5 = Common.ConDBNull(DataReader["NamSinh5"]);
                    obj.TTHIV5 = Common.ConDB_Int(DataReader["TTHIV5"]);
                    obj.NoiDT5 = Common.ConDBNull(DataReader["NoiDT5"]);
                    obj.NamSinh6 = Common.ConDBNull(DataReader["NamSinh6"]);
                    obj.TTHIV6 = Common.ConDB_Int(DataReader["TTHIV6"]);
                    obj.NoiDT6 = Common.ConDBNull(DataReader["NoiDT6"]);
                    obj.DangDTARV6 = Common.ConDBNull(DataReader["DangDTARV6"]);
                    obj.MQHKhac = Common.ConDBNull(DataReader["MQHKhac"]);
                    obj.NamSinh7 = Common.ConDBNull(DataReader["NamSinh7"]);
                    obj.TTHIV7 = Common.ConDB_Int(DataReader["TTHIV7"]);
                    obj.NoiDT7 = Common.ConDBNull(DataReader["NoiDT7"]);
                    obj.DangDTARV17 = Common.ConDBNull(DataReader["DangDTARV17"]);
                    obj.TenThuoc1 = Common.ConDBNull(DataReader["TenThuoc1"]);
                    obj.TSDU1 = Common.ConDB_Int(DataReader["TSDU1"]);
                    obj.SoLan1 = Common.ConDBNull(DataReader["SoLan1"]);
                    obj.BHLS1 = Common.ConDBNull(DataReader["BHLS1"]);
                    obj.TenThuoc2 = Common.ConDBNull(DataReader["TenThuoc2"]);
                    obj.TSDU2 = Common.ConDB_Int(DataReader["TSDU2"]);
                    obj.SoLan2 = Common.ConDBNull(DataReader["SoLan2"]);
                    obj.BHLS2 = Common.ConDBNull(DataReader["BHLS2"]);
                    obj.TenThuoc3 = Common.ConDBNull(DataReader["TenThuoc3"]);
                    obj.TSDU3 = Common.ConDB_Int(DataReader["TSDU3"]);
                    obj.SoLan3 = Common.ConDBNull(DataReader["SoLan3"]);
                    obj.BHLS3 = Common.ConDBNull(DataReader["BHLS3"]);
                    obj.TenThuoc4 = Common.ConDBNull(DataReader["TenThuoc4"]);
                    obj.TSDU4 = Common.ConDB_Int(DataReader["TSDU4"]);
                    obj.SoLan4 = Common.ConDBNull(DataReader["SoLan4"]);
                    obj.BHLS4 = Common.ConDBNull(DataReader["BHLS4"]);
                    obj.TenThuoc5 = Common.ConDBNull(DataReader["TenThuoc5"]);
                    obj.TSDU5 = Common.ConDB_Int(DataReader["TSDU5"]);
                    obj.SoLan5 = Common.ConDBNull(DataReader["SoLan5"]);
                    obj.BHLS5 = Common.ConDBNull(DataReader["BHLS5"]);
                    obj.TenThuoc6 = Common.ConDBNull(DataReader["TenThuoc6"]);
                    obj.TSDU6 = Common.ConDB_Int(DataReader["TSDU6"]);
                    obj.SoLan6 = Common.ConDBNull(DataReader["SoLan6"]);
                    obj.BHLS6 = Common.ConDBNull(DataReader["BHLS6"]);
                    obj.Khoa = Common.ConDBNull(DataReader["Khoa"]);
                    obj.MaKhoa = Common.ConDBNull(DataReader["MaKhoa"]);
                    obj.TTKhiDK8 = Common.ConDB_Int(DataReader["TTKhiDK8"]);
                    obj.CMTND = Common.ConDBNull(DataReader["CMTND"]);
                    obj.DiaChiThuongTru = Common.ConDBNull(DataReader["DiaChiThuongTru"]);
                    obj.MoiQuanHeNguoiNha = Common.ConDBNull(DataReader["MoiQuanHeNguoiNha"]);
                    obj.NgheNghiepNguoiNha = Common.ConDBNull(DataReader["NgheNghiepNguoiNha"]);
                    obj.TenThuongGoi = Common.ConDBNull(DataReader["TenThuongGoi"]);
                    obj.MaBacSyDieuTri = Common.ConDBNull(DataReader["MaBacSyDieuTri"]);
                    obj.BacSyDieuTri = Common.ConDBNull(DataReader["BacSyDieuTri"]);
                    obj.MaSoKyTen = DataReader["masokyten"].ToString();
                    obj.MaSoKyTen_KB = DataReader["masokyten_kb"].ToString();
                    obj.MaSoKyTen_TK = DataReader["masokyten_tk"].ToString();
                    obj.LstTTChiTiet = GetData_PhieuChiTiet(MyConnection, MaQuanLy);
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.LogError(ex);
            }
            
            return obj;
        }
        public static List<TheoDoiDieuTriHIV_ChiTietTbl> GetData_PhieuChiTiet(MDB.MDBConnection MyConnection, decimal IDMaPhieu)
        {
            List<TheoDoiDieuTriHIV_ChiTietTbl> lstData = new List<TheoDoiDieuTriHIV_ChiTietTbl>();
            string sql = @"select * from BenhAnNgoaiTruPK_TheoDoi WHERE IDMaPhieu = :IDMaPhieu ";
            if (IDMaPhieu != -1)
            {
                sql += " and IDMaPhieu = " + IDMaPhieu + "";
            }
            MDB.MDBCommand Command;
            using (Command = new MDB.MDBCommand(sql, MyConnection))
            {
                Command.Parameters.Add(new MDB.MDBParameter("IDMaPhieu", IDMaPhieu));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    lstData.Add(new TheoDoiDieuTriHIV_ChiTietTbl
                    {
                        IDMaPhieu = decimal.Parse(DataReader["IDMaPhieu"].ToString()),
                        IDMaPhieuChiTiet = decimal.Parse(DataReader["IDMaPhieuChiTiet"].ToString()),
                        NgayKham = Common.ConDB_DateTimeNull(DataReader["NgayKham"]),
                        NgayKhamLai = Common.ConDB_DateTimeNull(DataReader["NgayKhamLai"]),
                        CanNang = Common.ConDBNull(DataReader["CanNang"]),
                        ChieuCao = Common.ConDBNull(DataReader["ChieuCao"].ToString()),
                        DienBienBenh = Common.ConDBNull(DataReader["DienBienBenh"]),
                        GDLS = Common.ConDBNull(DataReader["GDLS"]),
                        DieuTri = Common.ConDBNull(DataReader["DieuTri"]),
                        TenNguoiDieuTri = Common.ConDBNull(DataReader["TenNguoiDieuTri"]),
                        GhiChu = Common.ConDBNull(DataReader["GhiChu"])
                    });
                }
            }
            return lstData;
        }
        public static bool InsertOrUpdate_Chittiet(MDB.MDBConnection oracleConnection, TheoDoiDieuTriHIV_ChiTietTbl obj)
        {
            try
            {
                string sql = @"SELECT COUNT(*) RECNUM FROM BenhAnNgoaiTruPK_TheoDoi WHERE IDMaPhieuChiTiet = :IDMaPhieuChiTiet and IDMaPhieu = :IDMaPhieu";
                MDB.MDBCommand oracleCommand;
                int rowCount = 0;
                int nRecord = 0;
                decimal sequence_nextval = 0;
                using (oracleCommand = new MDB.MDBCommand(sql, oracleConnection))
                {
                    oracleCommand.Parameters.Add("IDMaPhieuChiTiet", obj.IDMaPhieuChiTiet);
                    oracleCommand.Parameters.Add("IDMaPhieu", obj.IDMaPhieu);
                    MDB.MDBDataReader oracleDataReader = oracleCommand.ExecuteReader();
                    while (oracleDataReader.Read())
                    {
                        rowCount = int.Parse(oracleDataReader["RECNUM"].ToString());
                    }
                }
                if (rowCount > 0)
                {
                    sequence_nextval = obj.IDMaPhieu;
                    sql = "update BenhAnNgoaiTruPK_TheoDoi set NgayKham = :NgayKham,NgayKhamLai = :NgayKhamLai,CanNang = :CanNang,ChieuCao = :ChieuCao,DienBienBenh = :DienBienBenh,GDLS = :GDLS,DieuTri = :DieuTri,TenNguoiDieuTri = :TenNguoiDieuTri,GhiChu = :GhiChu";
                    sql = sql + " WHERE IDMaPhieuChiTiet = " + obj.IDMaPhieuChiTiet.ToString() + " and IDMaPhieu = " + obj.IDMaPhieu.ToString();
                }
                else
                {
                    sql = @"select NVL(MAX(IDMaPhieuChiTiet),0) AS sequence_nextval from BenhAnNgoaiTruPK_TheoDoi where IDMaPhieu = " + obj.IDMaPhieu.ToString();
                    using (oracleCommand = new MDB.MDBCommand(sql, oracleConnection))
                    {
                        MDB.MDBDataReader oracleDataReader = oracleCommand.ExecuteReader();
                        while (oracleDataReader.Read())
                        {
                            sequence_nextval = decimal.Parse(oracleDataReader["sequence_nextval"].ToString()) + 1;
                        }
                    }
                    sql = @"insert into BenhAnNgoaiTruPK_TheoDoi(IDMaPhieu,IDMaPhieuChiTiet,NgayKham,NgayKhamLai,CanNang,ChieuCao,DienBienBenh,GDLS,DieuTri,TenNguoiDieuTri,GhiChu)";
                    sql = sql + @"Values( :IDMaPhieu, :IDMaPhieuChiTiet, :NgayKham, :NgayKhamLai, :CanNang, :ChieuCao, :DienBienBenh, :GDLS, :DieuTri, :TenNguoiDieuTri, :GhiChu)";
                }
                using (oracleCommand = new MDB.MDBCommand(sql, oracleConnection))
                {
                    if (rowCount <= 0)
                    {
                        oracleCommand.Parameters.Add(new MDB.MDBParameter("IDMaPhieu", obj.IDMaPhieu));
                        oracleCommand.Parameters.Add(new MDB.MDBParameter("IDMaPhieuChiTiet", sequence_nextval));
                    }

                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayKham", obj.NgayKham));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayKhamLai", obj.NgayKhamLai));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CanNang", obj.CanNang));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ChieuCao", obj.ChieuCao));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DienBienBenh", obj.DienBienBenh));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("GDLS", obj.GDLS));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DieuTri", obj.DieuTri));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TenNguoiDieuTri", obj.TenNguoiDieuTri));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("GhiChu", obj.GhiChu));
                    nRecord = oracleCommand.ExecuteNonQuery();
                }
                if (nRecord > 0)
                {
                    obj.IDMaPhieu = sequence_nextval;
                }
                return nRecord > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.LogError(ex);
            }
            return false;
        }

        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, BANgoaiTruPK obj)
        {
            try
            {
                string sql =
                          @"select MaQuanLy 
                        from BenhAnNgoaiTruPK
                        where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, MyConnection);
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaQuanLy", obj.MaQuanLy));
                MDB.MDBDataReader DataReader = oracleCommand.ExecuteReader();
                int rowCount = 0;
                while (DataReader.Read()) rowCount++;
                if (rowCount >= 1)
                {
                    sql = @"UPDATE BenhAnNgoaiTruPK SET 
                        MaQuanLy = :MaQuanLy,
                        ChieuCao=:ChieuCao,
                        CanNang=:CanNang,
                        NhietDo=:NhietDo,
                        BenhCoHoiKemTheo=:BenhCoHoiKemTheo,
                        GDLamSangHIV=:GDLamSangHIV,
                        CD4=:CD4,
                        Hb=:Hb,
                        ALT=:ALT,
                        HBsAg=:HBsAg,
                        AntiHCV=:AntiHCV,
                        Creatinine=:Creatinine,
                        XetNghiemKhac=:XetNghiemKhac,
                        NgayLayMau1=:NgayLayMau1,
                        KetQua1=:KetQua1,
                        NgayLayMau2=:NgayLayMau2,
                        KetQua2=:KetQua2,
                        XuTru1=:XuTru1,
                        XuTru2=:XuTru2,
                        XuTru3=:XuTru3,
                        NDXuTru3=:NDXuTru3,
                        XuTru4=:XuTru4,
                        NDXuTru4=:NDXuTru4,
                        XuTru5=:XuTru5,
                        XuTru6=:XuTru6,
                        XuTru7=:XuTru7,
                        NDXuTru7=:NDXuTru7,
                        TTKhiDK1=:TTKhiDK1,
                        TTKhiDK2=:TTKhiDK2,
                        TTKhiDK3=:TTKhiDK3,
                        NDTTKhiDK3=:NDTTKhiDK3,
                        TTKhiDK4=:TTKhiDK4,
                        NDTTKhiDK4=:NDTTKhiDK4,
                        TTKhiDK5=:TTKhiDK5,
                        TTKhiDK6=:TTKhiDK6,
                        TTKhiDK7=:TTKhiDK7,
                        TSDungThuocARV1=:TSDungThuocARV1,
                        TSDungThuocARV2=:TSDungThuocARV2,
                        TSDungThuocARV3=:TSDungThuocARV3,
                        TSBenhBanThan=:TSBenhBanThan,
                        TienSuDUT=:TienSuDUT,
                        TienSuNuoiDuong=:TienSuNuoiDuong,
                        KQXNPCRL1=:KQXNPCRL1,
                        KQXNPCRL2=:KQXNPCRL2,
                        NamSinh1=:NamSinh1,
                        TTHIV1=:TTHIV1,
                        NoiDT1=:NoiDT1,
                        DangDTARV1=:DangDTARV1,
                        NamSinh2=:NamSinh2,
                        TTHIV2=:TTHIV2,
                        NoiDT2=:NoiDT2,
                        DangDTARV2=:DangDTARV2,
                        NamSinh3=:NamSinh3,
                        TTHIV3=:TTHIV3,
                        NoiDT3=:NoiDT3,
                        DangDTARV3=:DangDTARV3,
                        NamSinh4=:NamSinh4,
                        TTHIV4=:TTHIV4,
                        NoiDT4=:NoiDT4,
                        DangDTARV4=:DangDTARV4,
                        NamSinh5=:NamSinh5,
                        TTHIV5=:TTHIV5,
                        NoiDT5=:NoiDT5,
                        NamSinh6=:NamSinh6,
                        TTHIV6=:TTHIV6,
                        NoiDT6=:NoiDT6,
                        DangDTARV6=:DangDTARV6,
                        MQHKhac=:MQHKhac,
                        NamSinh7=:NamSinh7,
                        TTHIV7=:TTHIV7,
                        NoiDT7=:NoiDT7,
                        DangDTARV17=:DangDTARV17,
                        TenThuoc1=:TenThuoc1,
                        TSDU1=:TSDU1,
                        SoLan1=:SoLan1,
                        BHLS1=:BHLS1,
                        TenThuoc2=:TenThuoc2,
                        TSDU2=:TSDU2,
                        SoLan2=:SoLan2,
                        BHLS2=:BHLS2,
                        TenThuoc3=:TenThuoc3,
                        TSDU3=:TSDU3,
                        SoLan3=:SoLan3,
                        BHLS3=:BHLS3,
                        TenThuoc4=:TenThuoc4,
                        TSDU4=:TSDU4,
                        SoLan4=:SoLan4,
                        BHLS4=:BHLS4,
                        TenThuoc5=:TenThuoc5,
                        TSDU5=:TSDU5,
                        SoLan5=:SoLan5,
                        BHLS5=:BHLS5,
                        TenThuoc6=:TenThuoc6,
                        TSDU6=:TSDU6,
                        SoLan6=:SoLan6,
                        BHLS6=:BHLS6,
                        Khoa=:Khoa,
                        MaKhoa=:MaKhoa,
                        TTKhiDK8=:TTKhiDK8,
                        CMTND=:CMTND,
                        DiaChiThuongTru=:DiaChiThuongTru,
                        MoiQuanHeNguoiNha=:MoiQuanHeNguoiNha,
                        NgheNghiepNguoiNha=:NgheNghiepNguoiNha,
                        TenThuongGoi=:TenThuongGoi,
                        MaBacSyDieuTri=:MaBacSyDieuTri,
                        BacSyDieuTri=:BacSyDieuTri
                        WHERE MaQuanLy = :MaQuanLy";
                }
                else
                {
                    sql = @"
                   INSERT INTO BenhAnNgoaiTruPK (
					MaQuanLy,
                    ChieuCao,
                    CanNang,
                    NhietDo,
                    BenhCoHoiKemTheo,
                    GDLamSangHIV,
                    CD4,
                    Hb,
                    ALT,
                    HBsAg,
                    AntiHCV,
                    Creatinine,
                    XetNghiemKhac,
                    NgayLayMau1,
                    KetQua1,
                    NgayLayMau2,
                    KetQua2,
                    XuTru1,
                    XuTru2,
                    XuTru3,
                    NDXuTru3,
                    XuTru4,
                    NDXuTru4,
                    XuTru5,
                    XuTru6,
                    XuTru7,
                    NDXuTru7,
                    TTKhiDK1,
                    TTKhiDK2,
                    TTKhiDK3,
                    NDTTKhiDK3,
                    TTKhiDK4,
                    NDTTKhiDK4,
                    TTKhiDK5,
                    TTKhiDK6,
                    TTKhiDK7,
                    TSDungThuocARV1,
                    TSDungThuocARV2,
                    TSDungThuocARV3,
                    TSBenhBanThan,
                    TienSuDUT,
                    TienSuNuoiDuong,
                    KQXNPCRL1,
                    KQXNPCRL2,
                    NamSinh1,
                    TTHIV1,
                    NoiDT1,
                    DangDTARV1,
                    NamSinh2,
                    TTHIV2,
                    NoiDT2,
                    DangDTARV2,
                    NamSinh3,
                    TTHIV3,
                    NoiDT3,
                    DangDTARV3,
                    NamSinh4,
                    TTHIV4,
                    NoiDT4,
                    DangDTARV4,
                    NamSinh5,
                    TTHIV5,
                    NoiDT5,
                    NamSinh6,
                    TTHIV6,
                    NoiDT6,
                    DangDTARV6,
                    MQHKhac,
                    NamSinh7,
                    TTHIV7,
                    NoiDT7,
                    DangDTARV17,
                    TenThuoc1,
                    TSDU1,
                    SoLan1,
                    BHLS1,
                    TenThuoc2,
                    TSDU2,
                    SoLan2,
                    BHLS2,
                    TenThuoc3,
                    TSDU3,
                    SoLan3,
                    BHLS3,
                    TenThuoc4,
                    TSDU4,
                    SoLan4,
                    BHLS4,
                    TenThuoc5,
                    TSDU5,
                    SoLan5,
                    BHLS5,
                    TenThuoc6,
                    TSDU6,
                    SoLan6,
                    BHLS6,
                    Khoa,
                    MaKhoa,
                    TTKhiDK8,
                    CMTND,
                    DiaChiThuongTru,
                    MoiQuanHeNguoiNha,
                    NgheNghiepNguoiNha,
                    TenThuongGoi,
                    MaBacSyDieuTri,
                    BacSyDieuTri)
                    VALUES(
                    :MaQuanLy,
                    :ChieuCao,
                    :CanNang,
                    :NhietDo,
                    :BenhCoHoiKemTheo,
                    :GDLamSangHIV,
                    :CD4,
                    :Hb,
                    :ALT,
                    :HBsAg,
                    :AntiHCV,
                    :Creatinine,
                    :XetNghiemKhac,
                    :NgayLayMau1,
                    :KetQua1,
                    :NgayLayMau2,
                    :KetQua2,
                    :XuTru1,
                    :XuTru2,
                    :XuTru3,
                    :NDXuTru3,
                    :XuTru4,
                    :NDXuTru4,
                    :XuTru5,
                    :XuTru6,
                    :XuTru7,
                    :NDXuTru7,
                    :TTKhiDK1,
                    :TTKhiDK2,
                    :TTKhiDK3,
                    :NDTTKhiDK3,
                    :TTKhiDK4,
                    :NDTTKhiDK4,
                    :TTKhiDK5,
                    :TTKhiDK6,
                    :TTKhiDK7,
                    :TSDungThuocARV1,
                    :TSDungThuocARV2,
                    :TSDungThuocARV3,
                    :TSBenhBanThan,
                    :TienSuDUT,
                    :TienSuNuoiDuong,
                    :KQXNPCRL1,
                    :KQXNPCRL2,
                    :NamSinh1,
                    :TTHIV1,
                    :NoiDT1,
                    :DangDTARV1,
                    :NamSinh2,
                    :TTHIV2,
                    :NoiDT2,
                    :DangDTARV2,
                    :NamSinh3,
                    :TTHIV3,
                    :NoiDT3,
                    :DangDTARV3,
                    :NamSinh4,
                    :TTHIV4,
                    :NoiDT4,
                    :DangDTARV4,
                    :NamSinh5,
                    :TTHIV5,
                    :NoiDT5,
                    :NamSinh6,
                    :TTHIV6,
                    :NoiDT6,
                    :DangDTARV6,
                    :MQHKhac,
                    :NamSinh7,
                    :TTHIV7,
                    :NoiDT7,
                    :DangDTARV17,
                    :TenThuoc1,
                    :TSDU1,
                    :SoLan1,
                    :BHLS1,
                    :TenThuoc2,
                    :TSDU2,
                    :SoLan2,
                    :BHLS2,
                    :TenThuoc3,
                    :TSDU3,
                    :SoLan3,
                    :BHLS3,
                    :TenThuoc4,
                    :TSDU4,
                    :SoLan4,
                    :BHLS4,
                    :TenThuoc5,
                    :TSDU5,
                    :SoLan5,
                    :BHLS5,
                    :TenThuoc6,
                    :TSDU6,
                    :SoLan6,
                    :BHLS6,
                    :Khoa,
                    :MaKhoa,
                    :TTKhiDK8,
                    :CMTND,
                    :DiaChiThuongTru,
                    :MoiQuanHeNguoiNha,
                    :NgheNghiepNguoiNha,
                    :TenThuongGoi,
                    :MaBacSyDieuTri,
                    :BacSyDieuTri
                    )
                   ";
                }
                oracleCommand = new MDB.MDBCommand(sql, MyConnection);
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaQuanLy", obj.MaQuanLy));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ChieuCao", obj.ChieuCao));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CanNang", obj.CanNang));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NhietDo", obj.NhietDo));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("BenhCoHoiKemTheo", obj.BenhCoHoiKemTheo));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("GDLamSangHIV", obj.GDLamSangHIV));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CD4", obj.CD4));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Hb", obj.Hb));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ALT", obj.ALT));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("HBsAg", obj.HBsAg));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("AntiHCV", obj.AntiHCV));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Creatinine", obj.Creatinine));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("XetNghiemKhac", obj.XetNghiemKhac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayLayMau1", obj.NgayLayMau1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KetQua1", obj.KetQua1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayLayMau2", obj.NgayLayMau2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KetQua2", obj.KetQua2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("XuTru1", obj.XuTru1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("XuTru2", obj.XuTru2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("XuTru3", obj.XuTru3));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDXuTru3", obj.NDXuTru3));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("XuTru4", obj.XuTru4));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDXuTru4", obj.NDXuTru4));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("XuTru5", obj.XuTru5));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("XuTru6", obj.XuTru6));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("XuTru7", obj.XuTru7));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDXuTru7", obj.NDXuTru7));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TTKhiDK1", obj.TTKhiDK1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TTKhiDK2", obj.TTKhiDK2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TTKhiDK3", obj.TTKhiDK3));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDTTKhiDK3", obj.NDTTKhiDK3));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TTKhiDK4", obj.TTKhiDK4));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDTTKhiDK4", obj.NDTTKhiDK4));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TTKhiDK5", obj.TTKhiDK5));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TTKhiDK6", obj.TTKhiDK6));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TTKhiDK7", obj.TTKhiDK7));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TSDungThuocARV1", obj.TSDungThuocARV1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TSDungThuocARV2", obj.TSDungThuocARV2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TSDungThuocARV3", obj.TSDungThuocARV3));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TSBenhBanThan", obj.TSBenhBanThan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TienSuDUT", obj.TienSuDUT));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TienSuNuoiDuong", obj.TienSuNuoiDuong));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KQXNPCRL1", obj.KQXNPCRL1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KQXNPCRL2", obj.KQXNPCRL2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NamSinh1", obj.NamSinh1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TTHIV1", obj.TTHIV1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NoiDT1", obj.NoiDT1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DangDTARV1", obj.DangDTARV1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NamSinh2", obj.NamSinh2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TTHIV2", obj.TTHIV2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NoiDT2", obj.NoiDT2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DangDTARV2", obj.DangDTARV2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NamSinh3", obj.NamSinh3));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TTHIV3", obj.TTHIV3));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NoiDT3", obj.NoiDT3));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DangDTARV3", obj.DangDTARV3));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NamSinh4", obj.NamSinh4));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TTHIV4", obj.TTHIV4));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NoiDT4", obj.NoiDT4));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DangDTARV4", obj.DangDTARV4));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NamSinh5", obj.NamSinh5));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TTHIV5", obj.TTHIV5));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NoiDT5", obj.NoiDT5));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NamSinh6", obj.NamSinh6));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TTHIV6", obj.TTHIV6));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NoiDT6", obj.NoiDT6));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DangDTARV6", obj.DangDTARV6));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MQHKhac", obj.MQHKhac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NamSinh7", obj.NamSinh7));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TTHIV7", obj.TTHIV7));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NoiDT7", obj.NoiDT7));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DangDTARV17", obj.DangDTARV17));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenThuoc1", obj.TenThuoc1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TSDU1", obj.TSDU1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("SoLan1", obj.SoLan1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("BHLS1", obj.BHLS1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenThuoc2", obj.TenThuoc2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TSDU2", obj.TSDU2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("SoLan2", obj.SoLan2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("BHLS2", obj.BHLS2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenThuoc3", obj.TenThuoc3));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TSDU3", obj.TSDU3));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("SoLan3", obj.SoLan3));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("BHLS3", obj.BHLS3));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenThuoc4", obj.TenThuoc4));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TSDU4", obj.TSDU4));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("SoLan4", obj.SoLan4));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("BHLS4", obj.BHLS4));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenThuoc5", obj.TenThuoc5));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TSDU5", obj.TSDU5));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("SoLan5", obj.SoLan5));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("BHLS5", obj.BHLS5));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenThuoc6", obj.TenThuoc6));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TSDU6", obj.TSDU6));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("SoLan6", obj.SoLan6));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("BHLS6", obj.BHLS6));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Khoa", obj.Khoa));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaKhoa", obj.MaKhoa));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TTKhiDK8", obj.TTKhiDK8));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CMTND", obj.CMTND));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DiaChiThuongTru", obj.DiaChiThuongTru));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MoiQuanHeNguoiNha", obj.MoiQuanHeNguoiNha));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgheNghiepNguoiNha", obj.NgheNghiepNguoiNha));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenThuongGoi", obj.TenThuongGoi));
                if (!string.IsNullOrEmpty(obj.MaBacSyDieuTri))
                {
                    NhanVien nv = NhanVienFunc.ListNhanVien.Find(x => x.MaNhanVien.Equals(obj.MaBacSyDieuTri));
                    if (nv != null)
                    {
                        obj.BacSyDieuTri = nv.HoVaTen;
                    }
                }
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBacSyDieuTri", obj.MaBacSyDieuTri));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", obj.BacSyDieuTri));
                oracleCommand.BindByName = true;
                int n = oracleCommand.ExecuteNonQuery(); // C#
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
                return false;
            }
        }
        public static bool Delete(MDB.MDBConnection MyConnection, BANgoaiTruPK BenhAnNgoaiTruPK)
        {
            string sql = @"DELETE FROM BenhAnNgoaiTruPK 
                           WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnNgoaiTruPK.MaQuanLy));

            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
    }
}
