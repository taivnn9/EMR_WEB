using EMR.KyDienTu;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using PMS.Access; 

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuTheoDoiDieuTriHuyetApChiHuy: ThongTinKy
    {
        public PhieuTheoDoiDieuTriHuyetApChiHuy()
        {
            TableName = "PhieuTheoDoiDieuTriHACH";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PTDDTHACH;
            TenMauPhieu = DanhMucPhieu.PTDDTHACH.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public decimal IDPhieuTheoDoiDieuTriHACH { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public List<PhieuTheoDoiDieuTriHuyetApChiHuyChiTiet> ChiTiet { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        //public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
    }
    public class PhieuTheoDoiDieuTriHuyetApChiHuyFunc
    {
        public const string TableName = "PhieuTheoDoiDieuTriHACH";
        public const string TablePrimaryKeyName = "IDPhieuTheoDoiDieuTriHACH";
        public static List<PhieuTheoDoiDieuTriHuyetApChiHuy> Select(MDB.MDBConnection MyConnection,decimal MaQuanLy)
        {
            List<PhieuTheoDoiDieuTriHuyetApChiHuy> listResult = new List<PhieuTheoDoiDieuTriHuyetApChiHuy>();
            try
            {
                string sql = @"SELECT *
                                FROM PhieuTheoDoiDieuTriHACH
                                WHERE MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    var res = new PhieuTheoDoiDieuTriHuyetApChiHuy();
                    res.IDPhieuTheoDoiDieuTriHACH = (decimal)DataReader["IDPhieuTheoDoiDieuTriHACH"];
                    res.MaQuanLy = (decimal)DataReader["MaQuanLy"];
                    res.ChanDoan = DataReader["ChanDoan"].ToString();
                    res.ChiTiet = JsonConvert.DeserializeObject<List<PhieuTheoDoiDieuTriHuyetApChiHuyChiTiet>>(DataReader["ChiTiet"].ToString());
                    listResult.Add(res);
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return listResult;
        }

        public static DataSet SelectByID(MDB.MDBConnection MyConnection,decimal IDPhieuTheoDoiDieuTriHACH)
        {
            var ds = new DataSet();
            try
            {
                string sql = @"SELECT *
                                 FROM PhieuTheoDoiDieuTriHACH where IDPhieuTheoDoiDieuTriHACH = :IDPhieuTheoDoiDieuTriHACH";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("IDPhieuTheoDoiDieuTriHACH", IDPhieuTheoDoiDieuTriHACH));
                MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
                
                adt.Fill(ds, "TBL");

                return ds; 
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return ds;
        }

        public static bool Insert(MDB.MDBConnection MyConnection,PhieuTheoDoiDieuTriHuyetApChiHuy data)
        {
            try
            {
                string sql = @"INSERT INTO PhieuTheoDoiDieuTriHACH(
                IDPhieuTheoDoiDieuTriHACH, MaQuanLy, ChanDoan, ChiTiet) 
                VALUES (
                :IDPhieuTheoDoiDieuTriHACH, :MaQuanLy, :ChanDoan, :ChiTiet)
                RETURNING IDPhieuTheoDoiDieuTriHACH INTO :IDPhieuTheoDoiDieuTriHACH";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter(":IDPhieuTheoDoiDieuTriHACH", data.IDPhieuTheoDoiDieuTriHACH));
                Command.Parameters.Add(new MDB.MDBParameter(":MaQuanLy", data.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter(":ChanDoan", data.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter(":ChiTiet", JsonConvert.SerializeObject(data.ChiTiet)));
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
        public static bool Update(MDB.MDBConnection MyConnection,PhieuTheoDoiDieuTriHuyetApChiHuy data)
        {
            try
            {
                string sql = @"UPDATE PhieuTheoDoiDieuTriHACH SET 
                MaQuanLy = :MaQuanLy, 
                ChanDoan = :ChanDoan, 
                ChiTiet = :ChiTiet               
                WHERE IDPhieuTheoDoiDieuTriHACH = " + data.IDPhieuTheoDoiDieuTriHACH;
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter(":MaQuanLy", data.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter(":ChanDoan", data.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter(":ChiTiet", JsonConvert.SerializeObject(data.ChiTiet)));
                int n = Command.ExecuteNonQuery();
                return n > 0;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool Delete(MDB.MDBConnection MyConnection,decimal IDPhieuTheoDoiDieuTriHACH)
        {
            try
            {
                if (IDPhieuTheoDoiDieuTriHACH != 0)
                {
                    string sql = @"DELETE FROM PhieuTheoDoiDieuTriHACH WHERE IDPhieuTheoDoiDieuTriHACH = :IDPhieuTheoDoiDieuTriHACH";
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter(":IDPhieuTheoDoiDieuTriHACH", IDPhieuTheoDoiDieuTriHACH));
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

    public class PhieuTheoDoiDieuTriHuyetApChiHuyChiTiet
    {
        public DateTime GioDungThuoc { get; set; }
        public DateTime GioThucTe { get; set; }
        [MoTaDuLieu("Mạch")]
		public string Mach { get; set; }
        [MoTaDuLieu("Huyết áp")]
		public string HuyetAp { get; set; }
        [MoTaDuLieu("Xử trí")]
        public string XuTriChinh { get; set; }
        public string MaNguoiTheoDoi { get; set; }
        public string TenNguoiTheoDoi { get; set; }
    }
}