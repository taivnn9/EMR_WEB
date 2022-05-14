﻿
using System;
using System.Data;
using System.Reflection;

namespace EMR_MAIN
{
    public class BenhAnPhaThaiIFunc
    {
        public static void WriteXml(MDB.MDBConnection MyConnection)
        {
            string sql =
                   @"
                  select  a.*,  CTScanner HoSo_CTScanner, SieuAm HoSo_SieuAm, XetNghiem HoSo_XetNghiem,  Khac HoSo_Khac,  Khac_Text HoSo_Khac_Text,  ToanBoHoSo HoSo_ToanBoHoSo, Mach DauSinhTon_Mach,  NhietDo DauSinhTon_NhietDo,  HuyetAp DauSinhTon_HuyetAp,  NhipTho DauSinhTon_NhipTho,  CanNang DauSinhTon_CanNang  
                  from BenhAnPhaThaiI a inner join thongtindieutri b on a.maquanly = b.maquanly
                  where rownum = 1
                    ";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            var DataTable = new DataTable { TableName = "BenhAnPhaThaiI" };
            DataTable.Load(DataReader as IDataReader);
            DataTable.WriteXml("rptBenhAnPhaThaiI.xml");
        }
        public static DataSet SelectDataSet(MDB.MDBConnection MyConnection, decimal MaQuanLy, string MaBenhNhan)
        {
            string sql =
                  @"
                   select  a.*,l.hovaten NguoiTongKetHoVaTen, h.hovaten LanhDaoDonViHoVaTen,g.hovaten NguoiLamThuThuatHoVaTen,f.hovaten BacSyLamBenhAnHoVaTen ,c.hovaten BacSyDieuTriHoVaTen,d.hovaten NguoiGiaoHoSoHoVaTen,e.hovaten NguoiNhanHoSoHoVaTen, b.XQuang HoSo_XQuang,   b.CTScanner HoSo_CTScanner, b.SieuAm HoSo_SieuAm, b.XetNghiem HoSo_XetNghiem,  b.Khac HoSo_Khac,  b.Khac_Text HoSo_Khac_Text,  b.ToanBoHoSo HoSo_ToanBoHoSo, b.Mach DauSinhTon_Mach, b.NhietDo DauSinhTon_NhietDo,  b.HuyetAp DauSinhTon_HuyetAp,  b.NhipTho DauSinhTon_NhipTho,  b.CanNang DauSinhTon_CanNang  , b.ChieuCao DauSinhTon_ChieuCao, b.BMI DauSinhTon_BMI, b.NgayRaVien 
                 from BenhAnPhaThaiI a 
                 left join thongtindieutri b on a.maquanly = b.maquanly 
                  left join nhanvien c on a.bacsydieutri = c.manhanvien
                  left join nhanvien d on a.nguoigiaohoso = d.manhanvien
                  left join nhanvien e on a.nguoinhanhoso = e.manhanvien
                  left join nhanvien f on a.BacSyLamBenhAn = f.manhanvien
                  left join nhanvien g on a.NguoiLamThuThuat = g.manhanvien
                  left join nhanvien h on a.LanhDaoDonVi = h.manhanvien
                  left join nhanvien l on a.NguoiTongKet = l.manhanvien
                  where a.maquanly = " + MaQuanLy.ToString(System.Globalization.CultureInfo.InvariantCulture);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(sql, MyConnection);
            var ds = new DataSet();
            adt.Fill(ds, "Table");


            string sql2 =
                @"   select a.*,c.hovaten BacSyPhauThuatHoVaTen, d.hovaten BacSyGayMeHoVaTen
                  from PhauThuatThuThuat a
                  left join nhanvien c on a.bacsyphauthuat  = c.manhanvien
                  left join nhanvien d on a.bacsygayme= d.manhanvien
                  where a.maquanly = " + MaQuanLy.ToString(System.Globalization.CultureInfo.InvariantCulture);
            adt = new MDB.MDBDataAdapter(sql2, MyConnection);
            adt.Fill(ds, "Table2");

            string sql3 =
            @"
                  select a.*, b.*, c.hovaten GiamDocBenhVien, d.hovaten TruongKhoa,  e.hovaten ThayThuocKhamBenh, f.hovaten TruongPhongKHTH , g.hovaten ThayThuocDieuTri from hanhchinhbenhnhan a 
                  left  join thongtindieutri b on a.mabenhnhan = b.mabenhnhan
                  left join nhanvien c on b.MaGiamDocBenhVien = c.manhanvien
                  left join nhanvien d on b.MaTruongKhoa = d.manhanvien
                  left join nhanvien e on b.MaThayThuocKhamBenh = e.manhanvien
                  left join nhanvien f on b.MaTruongPhongKHTH = f.manhanvien
                  left join nhanvien g on b.MaThayThuocDieuTri = g.manhanvien
                  where a.MaBenhNhan = '" + MaBenhNhan + "'";
            adt = new MDB.MDBDataAdapter(sql3, XemBenhAn.MyConnection);
            adt.Fill(ds, "HanhChinh");
            return ds;
        }

        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, BenhAnPhaThaiI BenhAnPhaThaiI)
        {
            string sql =
                      @"select MaQuanLy 
                        from BenhAnPhaThaiI
                        where MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnPhaThaiI.MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            int rowCount = 0;
            while (DataReader.Read()) rowCount++;
            if (rowCount == 1) return Update(MyConnection, BenhAnPhaThaiI);
            else return Insert(MyConnection, BenhAnPhaThaiI);
        }

        public static BenhAnPhaThaiI Select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            #region
            string sql =
                      @"select * 
                        from BenhAnPhaThaiI a
                        where MaQuanLy = :MaQuanLy";
            #endregion
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("IDBenhAnPhaThaiI", MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            BenhAnPhaThaiI BenhAnPhaThaiI = new BenhAnPhaThaiI();
            BenhAnPhaThaiI.DacDiemLienQuanBenh = new DacDiemLienQuanBenh();
            BenhAnPhaThaiI.DauSinhTon = new DauSinhTon();
            BenhAnPhaThaiI.HoSo = new HoSo();
            try { 
                while (DataReader.Read())
                {
                    PropertyInfo[] properties = typeof(BenhAnPhaThaiI).GetProperties();
                    foreach (PropertyInfo property in properties)
                    {
                        if (property.Name == "DacDiemLienQuanBenh" || property.Name == "DauSinhTon" || property.Name == "HoSo")
                            continue;
                        else if(DataReader[property.Name] != null && DataReader[property.Name] != DBNull.Value)
                            property.SetValue(BenhAnPhaThaiI, ChangeType(DataReader[property.Name], property.PropertyType));
                    }
                }
            }
            catch(Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return BenhAnPhaThaiI;
        }
        public static object ChangeType(object value, Type conversion)
        {
            var t = conversion;
            if (t.IsGenericType && t.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))
            {
                if (value.ToString() == "")
                    return null;
                else
                    return Convert.ChangeType(value, Nullable.GetUnderlyingType(t));
            }
            return Convert.ChangeType(value, t);
        }
        public static bool Insert(MDB.MDBConnection MyConnection, BenhAnPhaThaiI BenhAnPhaThaiI)
        {
            string sql1 = "INSERT INTO BenhAnPhaThaiI (";
            string sql2 = ") VALUES(";

            PropertyInfo[] properties = typeof(BenhAnPhaThaiI).GetProperties();
            foreach (PropertyInfo property in properties)
                if (property.Name == "IDBenhAnPhaThaiI" ||
                    property.Name == "DacDiemLienQuanBenh" ||
                    property.Name == "DauSinhTon" ||
                    property.Name == "HoSo" ||
                    property.Name == "MaSoKyTen" ||
                    property.Name == "MaSoKyTen_KB" ||
                    property.Name == "MaSoKyTen_TK" ||
                    property.Name == "DaKy" ||
                    property.Name == "DaKy_KB" ||
                    property.Name == "DaKy_TK")
                    continue;
                else
                {
                    sql1 += string.Format("{0},", property.Name);
                    sql2 += string.Format(":{0},", property.Name);
                }
            sql1 = sql1.Remove(sql1.LastIndexOf(","));
            sql2 = sql2.Remove(sql2.LastIndexOf(",")) + ")";

            MDB.MDBCommand Command = new MDB.MDBCommand(sql1 + sql2, XemBenhAn.MyConnection);
            foreach (PropertyInfo property in properties)
            {
                if (property.Name == "IDBenhAnPhaThaiI" ||
                    property.Name == "DacDiemLienQuanBenh" ||
                    property.Name == "DauSinhTon" ||
                    property.Name == "HoSo" ||
                     property.Name == "MaSoKyTen" ||
                    property.Name == "MaSoKyTen_KB" ||
                    property.Name == "MaSoKyTen_TK" ||
                    property.Name == "DaKy" ||
                    property.Name == "DaKy_KB" ||
                    property.Name == "DaKy_TK")
                    continue;
                else
                    Command.Parameters.Add(new MDB.MDBParameter(property.Name, property.GetValue(BenhAnPhaThaiI, null)));
            }

            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool Update(MDB.MDBConnection MyConnection, BenhAnPhaThaiI BenhAnPhaThaiI)
        {
            string sql1 = "UPDATE BenhAnPhaThaiI SET ";
            PropertyInfo[] properties = typeof(BenhAnPhaThaiI).GetProperties();
            foreach (PropertyInfo property in properties)
                if (property.Name == "IDBenhAnPhaThaiI" ||
                    property.Name == "DacDiemLienQuanBenh" ||
                    property.Name == "DauSinhTon" ||
                    property.Name == "HoSo" ||
                    property.Name == "MaSoKyTen" ||
                    property.Name == "MaSoKyTen_KB" ||
                    property.Name == "MaSoKyTen_TK" ||
                    property.Name == "DaKy" ||
                    property.Name == "DaKy_KB" ||
                    property.Name == "DaKy_TK")
                    continue;
                else
                    sql1 += string.Format("{0} = :{1},", property.Name, property.Name);
            sql1 = sql1.Remove(sql1.LastIndexOf(",")) + " WHERE MaQuanLy = :MaQuanLy";

            MDB.MDBCommand Command = new MDB.MDBCommand(sql1, XemBenhAn.MyConnection);
            foreach (PropertyInfo property in properties)
                if (property.Name == "IDBenhAnPhaThaiI" ||
                    property.Name == "DacDiemLienQuanBenh" ||
                    property.Name == "DauSinhTon" ||
                    property.Name == "HoSo" ||
                    property.Name == "MaSoKyTen" ||
                    property.Name == "MaSoKyTen_KB" ||
                    property.Name == "MaSoKyTen_TK" ||
                    property.Name == "DaKy" ||
                    property.Name == "DaKy_KB" ||
                    property.Name == "DaKy_TK")
                    continue;
                else
                    Command.Parameters.Add(new MDB.MDBParameter(property.Name, property.GetValue(BenhAnPhaThaiI, null)));

            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnPhaThaiI.MaQuanLy));
            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static bool DeleteBenhAnPhaThaiI(MDB.MDBConnection MyConnection, BenhAnPhaThaiI BenhAnPhaThaiI)
        {
            string sql = @"DELETE FROM BenhAnPhaThaiI 
                           WHERE MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BenhAnPhaThaiI.MaQuanLy));

            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
    }
}
