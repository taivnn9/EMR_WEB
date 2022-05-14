using EMR.KyDienTu;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using PMS.Access; 

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuTheoDoiVaChamSocBNC2 : ThongTinKy
    {
        public PhieuTheoDoiVaChamSocBNC2()
        {
            TableName = "PhieuTheoDoiVaChamSocBNC2";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.TDVCSBNC2;
            TenMauPhieu = DanhMucPhieu.TDVCSBNC2.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public decimal IDPhieuTheoDoiVaChamSocBNC2 { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public List<PhieuTheoDoiVaChamSocBNC2ChiTiet> ChiTiet { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        public bool needUpdateChiTiet { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        //public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
    }
    public class PhieuTheoDoiVaChamSocBNC2Func
    {
        public const string TableName = "PhieuTheoDoiVaChamSocBNC2";
        public const string TablePrimaryKeyName = "IDPhieuTheoDoiVaChamSocBNC2";
        public static List<PhieuTheoDoiVaChamSocBNC2> Select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            List<PhieuTheoDoiVaChamSocBNC2> listResult = new List<PhieuTheoDoiVaChamSocBNC2>();
            try
            {
                string sql = @"SELECT *
                                FROM PhieuTheoDoiVaChamSocBNC2
                                WHERE MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    var res = new PhieuTheoDoiVaChamSocBNC2();
                    res.IDPhieuTheoDoiVaChamSocBNC2 = (decimal)DataReader["IDPhieuTheoDoiVaChamSocBNC2"];
                    res.MaQuanLy = (decimal)DataReader["MaQuanLy"];
                    res.ChanDoan = DataReader["ChanDoan"].ToString();
                    // 1. Lấy ChiTiet ở bảng cũ
                    // 2. Nếu ChiTiet == null thì lấy ở bảng mới (Tránh mất dữ liệu các phiếu nhập trước)
                    // Các phiếu mới không cần làm bước 1
                    // Ở phần update đã ghi đè dữ liệu ở bảng cũ, nên sẽ chuyển sang bảng mới hết
                    try
                    {
                        res.ChiTiet = JsonConvert.DeserializeObject<List<PhieuTheoDoiVaChamSocBNC2ChiTiet>>(DataReader["ChiTiet"].ToString());
                    }
                    catch
                    {
                        res.ChiTiet = null;
                    }
                    if (res.ChiTiet == null || res.ChiTiet.Count == 0)
                    {
                        res.ChiTiet = PhieuTheoDoiVaChamSocBNC2ChiTietFunc.GetAll(MyConnection, res.IDPhieuTheoDoiVaChamSocBNC2);
                    }
                    try
                    {
                        res.NguoiTao = Common.ConDBNull(DataReader["NGUOITAO"]);
                        res.NguoiSua = Common.ConDBNull(DataReader["NGUOISUA"]);
                        res.NgayTao = Common.ConDB_DateTime(DataReader["NGAYTAO"]);
                        res.NgaySua = Common.ConDB_DateTime(DataReader["NGAYSUA"]);
                    }
                    catch { }
                    listResult.Add(res);
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return listResult;
        }

        public static DataSet SelectByID(MDB.MDBConnection MyConnection, decimal IDPhieuTheoDoiVaChamSocBNC2)
        {
            var ds = new DataSet();
            try
            {
                string sql = @"SELECT *
                                 FROM PhieuTheoDoiVaChamSocBNC2 where IDPhieuTheoDoiVaChamSocBNC2 = :IDPhieuTheoDoiVaChamSocBNC2";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("IDPhieuTheoDoiVaChamSocBNC2", IDPhieuTheoDoiVaChamSocBNC2));
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

        public static bool Insert(MDB.MDBConnection MyConnection, PhieuTheoDoiVaChamSocBNC2 data)
        {
            try
            {
                string sql = @"INSERT INTO PhieuTheoDoiVaChamSocBNC2(
                IDPhieuTheoDoiVaChamSocBNC2, MaQuanLy, ChanDoan,
                NguoiTao, NguoiSua, NgayTao, NgaySua) 
                VALUES (
                :IDPhieuTheoDoiVaChamSocBNC2, :MaQuanLy, :ChanDoan,
                :NguoiTao, :NguoiSua, :NgayTao, :NgaySua) 
                RETURNING IDPhieuTheoDoiVaChamSocBNC2 INTO :IDPhieuTheoDoiVaChamSocBNC2";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter(":IDPhieuTheoDoiVaChamSocBNC2", data.IDPhieuTheoDoiVaChamSocBNC2));
                Command.Parameters.Add(new MDB.MDBParameter(":MaQuanLy", data.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter(":ChanDoan", data.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiTao", data.NguoiTao));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiSua", data.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NgayTao", data.NgayTao));
                Command.Parameters.Add(new MDB.MDBParameter("NgaySua", data.NgaySua));
                // Thêm hẳn vào bảng mới, không thêm vào bảng cũ (PhieuTheoDoiVaChamSocBNC2)
                int n = Command.ExecuteNonQuery();
                if (n > 0)
                {
                    //decimal IDPhieu = Command.Parameters[":IDPhieuTheoDoiVaChamSocBNC2"].ToDecimal();
                    decimal IDPhieu = Common.ConDB_Decimal((Command.Parameters[":IDPhieuTheoDoiVaChamSocBNC2"] as MDB.MDBParameter).Value);
                    for (int i = 0; i < data.ChiTiet.Count; i++)
                    {
                        data.ChiTiet[i].IDPhieu = IDPhieu;
                    }
                    return PhieuTheoDoiVaChamSocBNC2ChiTietFunc.InsertAll(MyConnection, data.ChiTiet);
                }
                return false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
                return false;
            }
        }
        public static bool Update(MDB.MDBConnection MyConnection, PhieuTheoDoiVaChamSocBNC2 data)
        {
            try
            {
                string sql = @"UPDATE PhieuTheoDoiVaChamSocBNC2 SET 
                MaQuanLy = :MaQuanLy, 
                ChanDoan = :ChanDoan, 
                ChiTiet = :ChiTiet, 
                NguoiTao = :NguoiTao, NguoiSua = :NguoiSua, NgayTao = :NgayTao, NgaySua = :NgaySua 
                WHERE IDPhieuTheoDoiVaChamSocBNC2 = " + data.IDPhieuTheoDoiVaChamSocBNC2;
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter(":MaQuanLy", data.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter(":ChanDoan", data.ChanDoan));
                // 1. Xóa các ChiTiet ở bảng cũ
                // 2. Lúc load lên sẽ lấy data ở bảng mới
                // Các phiếu mới không cần làm bước 1
                if (data.needUpdateChiTiet)
                {
                    Command.Parameters.Add(new MDB.MDBParameter(":ChiTiet", ""));
                    PhieuTheoDoiVaChamSocBNC2ChiTietFunc.DeleteAll(MyConnection, data.IDPhieuTheoDoiVaChamSocBNC2);
                    PhieuTheoDoiVaChamSocBNC2ChiTietFunc.InsertAll(MyConnection, data.ChiTiet);
                }
                else
                {
                    Command.Parameters.Add(new MDB.MDBParameter(":ChiTiet", JsonConvert.SerializeObject(data.ChiTiet)));
                }
                Command.Parameters.Add(new MDB.MDBParameter("NguoiTao", data.NguoiTao));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiSua", data.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NgayTao", data.NgayTao));
                Command.Parameters.Add(new MDB.MDBParameter("NgaySua", data.NgaySua));
                return Command.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool Delete(MDB.MDBConnection MyConnection, decimal IDPhieuTheoDoiVaChamSocBNC2)
        {
            try
            {
                if (IDPhieuTheoDoiVaChamSocBNC2 != 0)
                {
                    string sql = @"DELETE FROM PhieuTheoDoiVaChamSocBNC2 WHERE IDPhieuTheoDoiVaChamSocBNC2 = :IDPhieuTheoDoiVaChamSocBNC2";
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter(":IDPhieuTheoDoiVaChamSocBNC2", IDPhieuTheoDoiVaChamSocBNC2));
                    int n = Command.ExecuteNonQuery();
                    return n > 0;
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