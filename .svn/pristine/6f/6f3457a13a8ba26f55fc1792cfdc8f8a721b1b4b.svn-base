using System;
using System.Collections.Generic;
using EMR.KyDienTu;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuLocMauChiTiet
    {
        [MoTaDuLieu("Mã định danh chi tiết phiếu")]
		public decimal IDPhieuLocMauChiTiet { get; set; }
        [MoTaDuLieu("Mã định danh phiếu")]
		public decimal IDPhieuLocMau { get; set; }
        public DateTime NgayLocMau { get; set; }
        public string DuongVaoMachMau { get; set; }
        public string ThoiGianLocMau { get; set; }
        public string CanKho { get; set; }
        public string UF { get; set; }
        public string CanTruocLoc { get; set; }
        public string CanSauLoc { get; set; }
        public string TocDoBomMau { get; set; }
        public string ChongDong { get; set; }
        public string TocDoDichLoc { get; set; }
        public string MayThan { get; set; }
        public string QuaLoc { get; set; }
        public string Lan { get; set; }
        public string Thuoc { get; set; }
        public string Erythropoetin { get; set; }
        public string Sat { get; set; }
        public string Dam { get; set; }
        public string TruyenMau { get; set; }
        public string HuyetApTruocLocTren { get; set; }
        public string HuyetApTruocLocDuoi { get; set; }
        public string HuyetApSauLocTren { get; set; }
        public string HuyetApSauLocDuoi { get; set; }
        [MoTaDuLieu("Mạch")]
		public string Mach { get; set; }
        [MoTaDuLieu("Nhiệt độ")]
		public string NhietDo { get; set; }
        public string ChiDinh { get; set; }
        [MoTaDuLieu("Mã bác sỹ điều trị")]
		public string MaBacSyDieuTri { get; set; }
        public string TenMaBacSyDieuTri { get; set; }
        [MoTaDuLieu("Mã điều dưỡng")]
		public string MaDieuDuongThucHien { get; set; }
        public string TenDieuDuongThucHien { get; set; }
    }
    public class PhieuLocMauChiTietFunc
    {

        public static List<PhieuLocMauChiTiet> Select(MDB.MDBConnection _OracleConnection, decimal IDPhieuLocMau)
        {
            List<PhieuLocMauChiTiet> listResult = new List<PhieuLocMauChiTiet>();
            try
            {
                string sql = @"SELECT *
                    FROM PhieuLocMauChiTiet
                    WHERE IDPhieuLocMau = :IDPhieuLocMau
                    ORDER BY NgayLocMau";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("IDPhieuLocMau", IDPhieuLocMau));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    var res = new PhieuLocMauChiTiet();
                    res.IDPhieuLocMauChiTiet = (decimal)DataReader["IDPhieuLocMauChiTiet"];
                    res.IDPhieuLocMau = (decimal)DataReader["IDPhieuLocMau"];
                    res.NgayLocMau = (DateTime)DataReader["NgayLocMau"];
                    res.DuongVaoMachMau = DataReader["DuongVaoMachMau"].ToString();
                    res.ThoiGianLocMau = DataReader["ThoiGianLocMau"].ToString();
                    res.CanKho = DataReader["CanKho"].ToString();
                    res.UF = DataReader["UF"].ToString();
                    res.CanTruocLoc = DataReader["CanTruocLoc"].ToString();
                    res.CanSauLoc = DataReader["CanSauLoc"].ToString();
                    res.TocDoBomMau = DataReader["TocDoBomMau"].ToString();
                    res.ChongDong = DataReader["ChongDong"].ToString();
                    res.TocDoDichLoc = DataReader["TocDoDichLoc"].ToString();
                    res.MayThan = DataReader["MayThan"].ToString();
                    res.QuaLoc = DataReader["QuaLoc"].ToString();
                    res.Lan = DataReader["Lan"].ToString();
                    res.Thuoc = DataReader["Thuoc"].ToString();
                    res.Erythropoetin = DataReader["Erythropoetin"].ToString();
                    res.Sat = DataReader["Sat"].ToString();
                    res.Dam = DataReader["Dam"].ToString();
                    res.TruyenMau = DataReader["TruyenMau"].ToString();
                    res.HuyetApTruocLocTren = DataReader["HuyetApTruocLocTren"].ToString();
                    res.HuyetApTruocLocDuoi = DataReader["HuyetApTruocLocDuoi"].ToString();
                    res.HuyetApSauLocTren = DataReader["HuyetApSauLocTren"].ToString();
                    res.HuyetApSauLocDuoi = DataReader["HuyetApSauLocDuoi"].ToString();
                    res.Mach = DataReader["Mach"].ToString();
                    res.NhietDo = DataReader["NhietDo"].ToString();
                    res.ChiDinh = DataReader["ChiDinh"].ToString();
                    res.MaBacSyDieuTri = DataReader["MaBacSyDieuTri"].ToString();
                    res.TenMaBacSyDieuTri = DataReader["TenMaBacSyDieuTri"].ToString();
                    res.MaDieuDuongThucHien = DataReader["MaDieuDuongThucHien"].ToString();
                    res.TenDieuDuongThucHien = DataReader["TenDieuDuongThucHien"].ToString();
                    listResult.Add(res);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listResult;
        }
        public static bool Insert(MDB.MDBConnection _OracleConnection, PhieuLocMauChiTiet data)
        {
            try
            {
                string sql = @"INSERT INTO PhieuLocMauChiTiet(
                    IDPhieuLocMauChiTiet, IDPhieuLocMau, NgayLocMau, DuongVaoMachMau, ThoiGianLocMau, CanKho, UF, CanTruocLoc, CanSauLoc, TocDoBomMau, ChongDong, TocDoDichLoc, MayThan, QuaLoc, Lan, Thuoc, Erythropoetin, Sat, Dam, TruyenMau, HuyetApTruocLocTren, HuyetApTruocLocDuoi, HuyetApSauLocTren, HuyetApSauLocDuoi, Mach, NhietDo, ChiDinh, MaBacSyDieuTri, TenMaBacSyDieuTri, MaDieuDuongThucHien, TenDieuDuongThucHien) 
                    VALUES (
                    :IDPhieuLocMauChiTiet, :IDPhieuLocMau, :NgayLocMau, :DuongVaoMachMau, :ThoiGianLocMau, :CanKho, :UF, :CanTruocLoc, :CanSauLoc, :TocDoBomMau, :ChongDong, :TocDoDichLoc, :MayThan, :QuaLoc, :Lan, :Thuoc, :Erythropoetin, :Sat, :Dam, :TruyenMau, :HuyetApTruocLocTren, :HuyetApTruocLocDuoi, :HuyetApSauLocTren, :HuyetApSauLocDuoi, :Mach, :NhietDo, :ChiDinh, :MaBacSyDieuTri, :TenMaBacSyDieuTri, :MaDieuDuongThucHien, :TenDieuDuongThucHien)
                    RETURNING IDPhieuLocMauChiTiet INTO :IDPhieuLocMauChiTiet";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter(":IDPhieuLocMauChiTiet", data.IDPhieuLocMauChiTiet));
                Command.Parameters.Add(new MDB.MDBParameter(":IDPhieuLocMau", data.IDPhieuLocMau));
                Command.Parameters.Add(new MDB.MDBParameter(":NgayLocMau", data.NgayLocMau));
                Command.Parameters.Add(new MDB.MDBParameter(":DuongVaoMachMau", data.DuongVaoMachMau));
                Command.Parameters.Add(new MDB.MDBParameter(":ThoiGianLocMau", data.ThoiGianLocMau));
                Command.Parameters.Add(new MDB.MDBParameter(":CanKho", data.CanKho));
                Command.Parameters.Add(new MDB.MDBParameter(":UF", data.UF));
                Command.Parameters.Add(new MDB.MDBParameter(":CanTruocLoc", data.CanTruocLoc));
                Command.Parameters.Add(new MDB.MDBParameter(":CanSauLoc", data.CanSauLoc));
                Command.Parameters.Add(new MDB.MDBParameter(":TocDoBomMau", data.TocDoBomMau));
                Command.Parameters.Add(new MDB.MDBParameter(":ChongDong", data.ChongDong));
                Command.Parameters.Add(new MDB.MDBParameter(":TocDoDichLoc", data.TocDoDichLoc));
                Command.Parameters.Add(new MDB.MDBParameter(":MayThan", data.MayThan));
                Command.Parameters.Add(new MDB.MDBParameter(":QuaLoc", data.QuaLoc));
                Command.Parameters.Add(new MDB.MDBParameter(":Lan", data.Lan));
                Command.Parameters.Add(new MDB.MDBParameter(":Thuoc", data.Thuoc));
                Command.Parameters.Add(new MDB.MDBParameter(":Erythropoetin", data.Erythropoetin));
                Command.Parameters.Add(new MDB.MDBParameter(":Sat", data.Sat));
                Command.Parameters.Add(new MDB.MDBParameter(":Dam", data.Dam));
                Command.Parameters.Add(new MDB.MDBParameter(":TruyenMau", data.TruyenMau));
                Command.Parameters.Add(new MDB.MDBParameter(":HuyetApTruocLocTren", data.HuyetApTruocLocTren));
                Command.Parameters.Add(new MDB.MDBParameter(":HuyetApTruocLocDuoi", data.HuyetApTruocLocDuoi));
                Command.Parameters.Add(new MDB.MDBParameter(":HuyetApSauLocTren", data.HuyetApSauLocTren));
                Command.Parameters.Add(new MDB.MDBParameter(":HuyetApSauLocDuoi", data.HuyetApSauLocDuoi));
                Command.Parameters.Add(new MDB.MDBParameter(":Mach", data.Mach));
                Command.Parameters.Add(new MDB.MDBParameter(":NhietDo", data.NhietDo));
                Command.Parameters.Add(new MDB.MDBParameter(":ChiDinh", data.ChiDinh));
                Command.Parameters.Add(new MDB.MDBParameter(":MaBacSyDieuTri", data.MaBacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter(":TenMaBacSyDieuTri", data.TenMaBacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter(":MaDieuDuongThucHien", data.MaDieuDuongThucHien));
                Command.Parameters.Add(new MDB.MDBParameter(":TenDieuDuongThucHien", data.TenDieuDuongThucHien));
                int n = Command.ExecuteNonQuery();
                return n > 0;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool Update(MDB.MDBConnection _OracleConnection, PhieuLocMauChiTiet data)
        {
            try
            {
                string sql = @"UPDATE PhieuLocMauChiTiet SET 
                        IDPhieuLocMau =:IDPhieuLocMau,
                        NgayLocMau =:NgayLocMau,
                        DuongVaoMachMau =:DuongVaoMachMau,
                        ThoiGianLocMau =:ThoiGianLocMau,
                        CanKho =:CanKho,
                        UF =:UF,
                        CanTruocLoc =:CanTruocLoc,
                        CanSauLoc =:CanSauLoc,
                        TocDoBomMau =:TocDoBomMau,
                        ChongDong =:ChongDong,
                        TocDoDichLoc =:TocDoDichLoc,
                        MayThan =:MayThan,
                        QuaLoc =:QuaLoc,
                        Lan =:Lan,
                        Thuoc =:Thuoc,
                        Erythropoetin =:Erythropoetin,
                        Sat =:Sat,
                        Dam =:Dam,
                        TruyenMau =:TruyenMau,
                        HuyetApTruocLocTren =:HuyetApTruocLocTren,
                        HuyetApTruocLocDuoi =:HuyetApTruocLocDuoi,
                        HuyetApSauLocTren =:HuyetApSauLocTren,
                        HuyetApSauLocDuoi =:HuyetApSauLocDuoi,
                        Mach =:Mach,
                        NhietDo =:NhietDo,
                        ChiDinh =:ChiDinh,
                        MaBacSyDieuTri =:MaBacSyDieuTri,
                        TenMaBacSyDieuTri =:TenMaBacSyDieuTri,
                        MaDieuDuongThucHien =:MaDieuDuongThucHien,
                        TenDieuDuongThucHien =:TenDieuDuongThucHien
                        WHERE IDPhieuLocMauChiTiet =:IDPhieuLocMauChiTiet";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter(":IDPhieuLocMau", data.IDPhieuLocMau));
                Command.Parameters.Add(new MDB.MDBParameter(":NgayLocMau", data.NgayLocMau));
                Command.Parameters.Add(new MDB.MDBParameter(":DuongVaoMachMau", data.DuongVaoMachMau));
                Command.Parameters.Add(new MDB.MDBParameter(":ThoiGianLocMau", data.ThoiGianLocMau));
                Command.Parameters.Add(new MDB.MDBParameter(":CanKho", data.CanKho));
                Command.Parameters.Add(new MDB.MDBParameter(":UF", data.UF));
                Command.Parameters.Add(new MDB.MDBParameter(":CanTruocLoc", data.CanTruocLoc));
                Command.Parameters.Add(new MDB.MDBParameter(":CanSauLoc", data.CanSauLoc));
                Command.Parameters.Add(new MDB.MDBParameter(":TocDoBomMau", data.TocDoBomMau));
                Command.Parameters.Add(new MDB.MDBParameter(":ChongDong", data.ChongDong));
                Command.Parameters.Add(new MDB.MDBParameter(":TocDoDichLoc", data.TocDoDichLoc));
                Command.Parameters.Add(new MDB.MDBParameter(":MayThan", data.MayThan));
                Command.Parameters.Add(new MDB.MDBParameter(":QuaLoc", data.QuaLoc));
                Command.Parameters.Add(new MDB.MDBParameter(":Lan", data.Lan));
                Command.Parameters.Add(new MDB.MDBParameter(":Thuoc", data.Thuoc));
                Command.Parameters.Add(new MDB.MDBParameter(":Erythropoetin", data.Erythropoetin));
                Command.Parameters.Add(new MDB.MDBParameter(":Sat", data.Sat));
                Command.Parameters.Add(new MDB.MDBParameter(":Dam", data.Dam));
                Command.Parameters.Add(new MDB.MDBParameter(":TruyenMau", data.TruyenMau));
                Command.Parameters.Add(new MDB.MDBParameter(":HuyetApTruocLocTren", data.HuyetApTruocLocTren));
                Command.Parameters.Add(new MDB.MDBParameter(":HuyetApTruocLocDuoi", data.HuyetApTruocLocDuoi));
                Command.Parameters.Add(new MDB.MDBParameter(":HuyetApSauLocTren", data.HuyetApSauLocTren));
                Command.Parameters.Add(new MDB.MDBParameter(":HuyetApSauLocDuoi", data.HuyetApSauLocDuoi));
                Command.Parameters.Add(new MDB.MDBParameter(":Mach", data.Mach));
                Command.Parameters.Add(new MDB.MDBParameter(":NhietDo", data.NhietDo));
                Command.Parameters.Add(new MDB.MDBParameter(":ChiDinh", data.ChiDinh));
                Command.Parameters.Add(new MDB.MDBParameter(":MaBacSyDieuTri", data.MaBacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter(":TenMaBacSyDieuTri", data.TenMaBacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter(":MaDieuDuongThucHien", data.MaDieuDuongThucHien));
                Command.Parameters.Add(new MDB.MDBParameter(":TenDieuDuongThucHien", data.TenDieuDuongThucHien));
                Command.Parameters.Add(new MDB.MDBParameter(":IDPhieuLocMauChiTiet", data.IDPhieuLocMauChiTiet));
                int n = Command.ExecuteNonQuery();
                return n > 0;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool Delete(MDB.MDBConnection _OracleConnection, decimal IDPhieuLocMauChiTiet)
        {
            try
            {
                if (IDPhieuLocMauChiTiet != 0)
                {
                    string sql = @"DELETE FROM PhieuLocMauChiTiet WHERE IDPhieuLocMauChiTiet = :IDPhieuLocMauChiTiet";
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                    Command.Parameters.Add(new MDB.MDBParameter(":IDPhieuLocMauChiTiet", IDPhieuLocMauChiTiet));
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
}