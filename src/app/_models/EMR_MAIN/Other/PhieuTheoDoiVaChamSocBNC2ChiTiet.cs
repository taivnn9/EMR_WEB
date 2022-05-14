using DevExpress.XtraReports.UI;
using EMR_MAIN.InBenhAn;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using EMR.KyDienTu;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuTheoDoiVaChamSocBNC2ChiTiet
    {
        [MoTaDuLieu("Mã định danh")]
		public decimal ID { get; set; }
        [MoTaDuLieu("Mã định danh phiếu")]
		public decimal IDPhieu { get; set; }
        public DateTime NgayGio { get; set; }
        public string NhanDinhTinhTrangNB { get; set; }
        public string MucTieuChamSoc { get; set; }
        public string HanhDongDieuDuong { get; set; }
        public string LuongGia { get; set; }
        public string MaNguoiTheoDoi { get; set; }
        public string TenNguoiTheoDoi { get; set; }
    }
    public class PhieuTheoDoiVaChamSocBNC2ChiTietFunc
    {
        public const string TableName = "PhieuTDCSBNC2ChiTiet";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuTheoDoiVaChamSocBNC2ChiTiet> GetAll(MDB.MDBConnection MyConnection, decimal IDPhieu)
        {
            List<PhieuTheoDoiVaChamSocBNC2ChiTiet> listResult = new List<PhieuTheoDoiVaChamSocBNC2ChiTiet>();
            try
            {
                string sql = @"SELECT *
                                FROM PhieuTDCSBNC2ChiTiet
                                WHERE IDPhieu = :IDPhieu ORDER BY NGAYGIO";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter(":IDPhieu", IDPhieu));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    try
                    {
                        var data = new PhieuTheoDoiVaChamSocBNC2ChiTiet();
                        data.ID = Common.ConDB_Decimal(DataReader["ID"]);
                        data.IDPhieu = Common.ConDB_Decimal(DataReader["IDPhieu"]);
                        data.NgayGio = Common.ConDB_DateTime(DataReader["NgayGio"]);
                        data.NhanDinhTinhTrangNB = Common.ConDBNull(DataReader["NhanDinhTinhTrangNB"]);
                        data.MucTieuChamSoc = Common.ConDBNull(DataReader["MucTieuChamSoc"]);
                        data.HanhDongDieuDuong = Common.ConDBNull(DataReader["HanhDongDieuDuong"]);
                        data.LuongGia = Common.ConDBNull(DataReader["LuongGia"]);
                        data.MaNguoiTheoDoi = Common.ConDBNull(DataReader["MaNguoiTheoDoi"]);
                        data.TenNguoiTheoDoi = Common.ConDBNull(DataReader["TenNguoiTheoDoi"]);
                        listResult.Add(data);
                    }
                    catch { }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return listResult;
        }
        public static bool Insert(MDB.MDBConnection MyConnection, PhieuTheoDoiVaChamSocBNC2ChiTiet data)
        {
            try
            {
                string sql = @"INSERT INTO PhieuTDCSBNC2ChiTiet(
                ID, IDPhieu, NgayGio, NhanDinhTinhTrangNB, MucTieuChamSoc, HanhDongDieuDuong, LuongGia, MaNguoiTheoDoi, TenNguoiTheoDoi) 
                VALUES (
                :ID, :IDPhieu, :NgayGio, :NhanDinhTinhTrangNB, :MucTieuChamSoc, :HanhDongDieuDuong, :LuongGia, :MaNguoiTheoDoi, :TenNguoiTheoDoi) 
                RETURNING ID INTO :ID";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter(":ID", data.ID));
                Command.Parameters.Add(new MDB.MDBParameter(":IDPhieu", data.IDPhieu));
                Command.Parameters.Add(new MDB.MDBParameter(":NgayGio", data.NgayGio));
                Command.Parameters.Add(new MDB.MDBParameter(":NhanDinhTinhTrangNB", data.NhanDinhTinhTrangNB));
                Command.Parameters.Add(new MDB.MDBParameter(":MucTieuChamSoc", data.MucTieuChamSoc));
                Command.Parameters.Add(new MDB.MDBParameter(":HanhDongDieuDuong", data.HanhDongDieuDuong));
                Command.Parameters.Add(new MDB.MDBParameter(":LuongGia", data.LuongGia));
                Command.Parameters.Add(new MDB.MDBParameter(":MaNguoiTheoDoi", data.MaNguoiTheoDoi));
                Command.Parameters.Add(new MDB.MDBParameter(":TenNguoiTheoDoi", data.TenNguoiTheoDoi));
                return Command.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
                return false;
            }
        }
        public static bool InsertAll(MDB.MDBConnection MyConnection, List<PhieuTheoDoiVaChamSocBNC2ChiTiet> list)
        {
            try
            {
                string sql = @"INSERT INTO PhieuTDCSBNC2ChiTiet(
                ID, IDPhieu, NgayGio, NhanDinhTinhTrangNB, MucTieuChamSoc, HanhDongDieuDuong, LuongGia, MaNguoiTheoDoi, TenNguoiTheoDoi) 
                VALUES (
                :ID, :IDPhieu, :NgayGio, :NhanDinhTinhTrangNB, :MucTieuChamSoc, :HanhDongDieuDuong, :LuongGia, :MaNguoiTheoDoi, :TenNguoiTheoDoi) 
                RETURNING ID INTO :ID";
                int count = 0;
                list.ForEach(data =>
                {
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter(":ID", data.ID));
                    Command.Parameters.Add(new MDB.MDBParameter(":IDPhieu", data.IDPhieu));
                    Command.Parameters.Add(new MDB.MDBParameter(":NgayGio", data.NgayGio));
                    Command.Parameters.Add(new MDB.MDBParameter(":NhanDinhTinhTrangNB", data.NhanDinhTinhTrangNB));
                    Command.Parameters.Add(new MDB.MDBParameter(":MucTieuChamSoc", data.MucTieuChamSoc));
                    Command.Parameters.Add(new MDB.MDBParameter(":HanhDongDieuDuong", data.HanhDongDieuDuong));
                    Command.Parameters.Add(new MDB.MDBParameter(":LuongGia", data.LuongGia));
                    Command.Parameters.Add(new MDB.MDBParameter(":MaNguoiTheoDoi", data.MaNguoiTheoDoi));
                    Command.Parameters.Add(new MDB.MDBParameter(":TenNguoiTheoDoi", data.TenNguoiTheoDoi));
                    count += Command.ExecuteNonQuery();
                });
                return list.Count == count;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
                return false;
            }
        }
        public static bool Delete(MDB.MDBConnection MyConnection, decimal ID)
        {
            try
            {
                if (ID != 0)
                {
                    string sql = @"DELETE FROM PhieuTDCSBNC2ChiTiet WHERE ID = :ID";
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter(":ID", ID));
                    return Command.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool DeleteAll(MDB.MDBConnection MyConnection, decimal IDPhieu)
        {
            try
            {
                if (IDPhieu != 0)
                {
                    string sql = @"DELETE FROM PhieuTDCSBNC2ChiTiet WHERE IDPhieu = :IDPhieu";
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter(":IDPhieu", IDPhieu));
                    return Command.ExecuteNonQuery() > 0;
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