using EMR.KyDienTu;
using Newtonsoft.Json;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuTheoDoiDieuTriAlteplaseDuongTinhMach : ThongTinKy
    {
        public PhieuTheoDoiDieuTriAlteplaseDuongTinhMach()
        {
            TableName = "PhieuTDDTAlteplase";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PTDDTADTM;
            TenMauPhieu = DanhMucPhieu.PTDDTADTM.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public decimal IDPhieuTDDTAlteplase { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public List<PhieuTheoDoiDieuTriAlteplaseDuongTinhMachChiTiet> ChiTiet { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        //public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
        public DateTime GioBatDauBolus { get; set; }
    }
    public class PhieuTheoDoiDieuTriAlteplaseDuongTinhMachFunc
    {
        public const string TableName = "PhieuTDDTAlteplase";
        public const string TablePrimaryKeyName = "IDPhieuTDDTAlteplase";
        public static List<PhieuTheoDoiDieuTriAlteplaseDuongTinhMach> Select(decimal MaQuanLy, MDB.MDBConnection MyConnection)
        {
            List<PhieuTheoDoiDieuTriAlteplaseDuongTinhMach> listResult = new List<PhieuTheoDoiDieuTriAlteplaseDuongTinhMach>();
            try
            {
                string sql = @"SELECT *
                                FROM PhieuTDDTAlteplase
                                WHERE MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    var res = new PhieuTheoDoiDieuTriAlteplaseDuongTinhMach();
                    res.IDPhieuTDDTAlteplase = (decimal)DataReader["IDPhieuTDDTAlteplase"];
                    res.MaQuanLy = (decimal)DataReader["MaQuanLy"];
                    res.ChanDoan = DataReader["ChanDoan"].ToString();
                    res.GioBatDauBolus = DataReader["GioBatDauBolus"].ToDateTime();
                    res.ChiTiet = JsonConvert.DeserializeObject<List<PhieuTheoDoiDieuTriAlteplaseDuongTinhMachChiTiet>>(DataReader["ChiTiet"].ToString());
                    listResult.Add(res);
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return listResult;
        }

        public static DataSet SelectByID(MDB.MDBConnection MyConnection, decimal IDPhieuTDDTAlteplase)
        {
            var ds = new DataSet();
            try
            {
                string sql = @"SELECT *
                                 FROM PhieuTDDTAlteplase where IDPhieuTDDTAlteplase = :IDPhieuTDDTAlteplase";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("IDPhieuTDDTAlteplase", IDPhieuTDDTAlteplase));
                MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);

                adt.Fill(ds, "TBL");
                //DateTime.ParseExact(ds.Tables["TBL"].Rows[0].["GioBatDauBolus"], '');

                return ds;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return ds;
        }

        public static bool Insert(PhieuTheoDoiDieuTriAlteplaseDuongTinhMach data, MDB.MDBConnection MyConnection)
        {
            try
            {
                string sql = @"INSERT INTO PhieuTDDTAlteplase(
                IDPhieuTDDTAlteplase, MaQuanLy, ChanDoan, ChiTiet, GioBatDauBolus) 
                VALUES (
                :IDPhieuTDDTAlteplase, :MaQuanLy, :ChanDoan, :ChiTiet, :GioBatDauBolus)
                RETURNING IDPhieuTDDTAlteplase INTO :IDPhieuTDDTAlteplase";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter(":IDPhieuTDDTAlteplase", data.IDPhieuTDDTAlteplase));
                Command.Parameters.Add(new MDB.MDBParameter(":MaQuanLy", data.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter(":ChanDoan", data.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter(":ChiTiet", JsonConvert.SerializeObject(data.ChiTiet)));
                Command.Parameters.Add(new MDB.MDBParameter(":GioBatDauBolus", data.GioBatDauBolus));
                int n = Command.ExecuteNonQuery();
                return n > 0;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
                return false;
            }
            return false;
        }
        public static bool Update(PhieuTheoDoiDieuTriAlteplaseDuongTinhMach data, MDB.MDBConnection MyConnection)
        {
            try
            {
                string sql = @"UPDATE PhieuTDDTAlteplase SET 
                MaQuanLy = :MaQuanLy, 
                ChanDoan = :ChanDoan, 
                ChiTiet = :ChiTiet,
                GioBatDauBolus = :GioBatDauBolus
                WHERE IDPhieuTDDTAlteplase = " + data.IDPhieuTDDTAlteplase;
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter(":MaQuanLy", data.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter(":ChanDoan", data.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter(":ChiTiet", JsonConvert.SerializeObject(data.ChiTiet)));
                Command.Parameters.Add(new MDB.MDBParameter(":GioBatDauBolus", data.GioBatDauBolus));
                int n = Command.ExecuteNonQuery();
                return n > 0;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool Delete(decimal IDPhieuTDDTAlteplase, MDB.MDBConnection MyConnection)
        {
            try
            {
                if (IDPhieuTDDTAlteplase != 0)
                {
                    string sql = @"DELETE FROM PhieuTDDTAlteplase WHERE IDPhieuTDDTAlteplase = :IDPhieuTDDTAlteplase";
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter(":IDPhieuTDDTAlteplase", IDPhieuTDDTAlteplase));
                    int n = Command.ExecuteNonQuery();
                    return n > 0 ? true : false;
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
    }

    public class PhieuTheoDoiDieuTriAlteplaseDuongTinhMachChiTiet
    {
        public DateTime GioDungThuoc { get; set; }
        public DateTime GioThucTe { get; set; }
        [MoTaDuLieu("Mạch")]
		public string Mach { get; set; }
        [MoTaDuLieu("Huyết áp")]
		public string HuyetAp { get; set; }
        public string YThuc { get; set; }
        public string DauDauBuonNonNonOi { get; set; }
        [MoTaDuLieu("Xử trí")]
        public string XuTriChinh { get; set; }
        [MoTaDuLieu("Mã điều dưỡng")]
		public string MaDieuDuongTheoDoi { get; set; }
        public string TenDieuDuongTheoDoi { get; set; }
        public string MaBacSiTheoDoi { get; set; }
        public string TenBacSiTheoDoi { get; set; }
    }
}