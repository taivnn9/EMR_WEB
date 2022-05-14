using EMR.KyDienTu;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using PMS.Access; 

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuTheoDoiBenhNhanNangCls : ThongTinKy
    {
        public PhieuTheoDoiBenhNhanNangCls()
        {
            TableName = "PhieuTheoDoiBenhNhanNang";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PTDBNN;
            TenMauPhieu = DanhMucPhieu.PTDBNN.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public decimal IDPhieu { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        public DateTime? ThoiGianPT { get; set; }
        public string PTV { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public List<PhieuTheoDoiBenhNhanNangChiTiet> ChiTiet { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        //public string MaSoKyTen { get; set; }
    }

    public class PhieuTheoDoiBenhNhanNangFunc
    {
        public const string TableName = "PhieuTheoDoiBenhNhanNang";
        public const string TablePrimaryKeyName = "IDPhieu";
        public static DateTime ConDB_DateTime(object dbVal)
        {
            DateTime ret = DateTime.MinValue;
            if (dbVal == null)
            {
                return ret;
            }
            bool isSuccess = DateTime.TryParse(dbVal.ToString(), out ret);
            return ret;
        }
        public static List<PhieuTheoDoiBenhNhanNangCls> Select(MDB.MDBConnection _OracleConnection, decimal MaQuanLy)
        {
            List<PhieuTheoDoiBenhNhanNangCls> listResult = new List<PhieuTheoDoiBenhNhanNangCls>();
            try
            {
                string sql = @"SELECT * 
                                FROM PhieuTheoDoiBenhNhanNang
                                WHERE MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    var res = new PhieuTheoDoiBenhNhanNangCls();
                    res.IDPhieu = (decimal)DataReader["IDPhieu"];
                    res.ThoiGianPT = ConDB_DateTime(DataReader["ThoiGianPT"]);
                    res.MaQuanLy = (decimal)DataReader["MaQuanLy"];
                    res.ChanDoan = DataReader["ChanDoan"].ToString();
                    res.PTV = DataReader["PTV"].ToString();
                    res.NguoiTao = Common.ConDBNull(DataReader["NguoiTao"]);
                    res.NguoiSua = Common.ConDBNull(DataReader["NguoiSua"]);
                    res.NgayTao = Common.ConDB_DateTime(DataReader["NgayTao"]);
                    res.NgaySua = Common.ConDB_DateTime(DataReader["NgaySua"]);
                    res.ChiTiet = JsonConvert.DeserializeObject<List<PhieuTheoDoiBenhNhanNangChiTiet>>(DataReader["ChiTiet"].ToString());
                    listResult.Add(res);
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return listResult;
        }

        public static DataSet SelectByID(MDB.MDBConnection MyConnection, decimal IDPhieu)
        {
            var ds = new DataSet();
            try
            {
                string sql = @"SELECT P.*, T.SoNhapVien, T.Khoa , T.NgayVaoVien ,  T.MaKhoa,            
                                H.TUOI,H.SoYTe, H.BENHVIEN,
	                             H.GIOITINH,  H.TenBenhNhan, H.maBenhNhan
                              FROM PhieuTheoDoiBenhNhanNang P 
                                Left JOIN THONGTINDIEUTRI T ON P.MAQUANLY = T.MAQUANLY
                                Left JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
                              where IDPhieu = :IDPhieu";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("IDPhieu", IDPhieu));
                MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
                ;
                adt.Fill(ds, "TBL");

                return ds;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return ds;
        }

        public static bool Insert(MDB.MDBConnection _OracleConnection, PhieuTheoDoiBenhNhanNangCls data)
        {
            try
            {
                string sql = @"INSERT INTO PhieuTheoDoiBenhNhanNang(
                IDPhieu, MaQuanLy, ChanDoan, ChiTiet, ThoiGianPT, PTV, NguoiTao, NguoiSua, NgayTao, NgaySua ) 
                VALUES (
                :IDPhieu, :MaQuanLy, :ChanDoan, :ChiTiet, :ThoiGianPT, :PTV, :NguoiTao, :NguoiSua, :NgayTao, :NgaySua )
                RETURNING IDPhieu INTO :IDPhieu";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter(":IDPhieu", data.IDPhieu));
                Command.Parameters.Add(new MDB.MDBParameter(":MaQuanLy", data.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter(":ChanDoan", data.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter(":ChiTiet", JsonConvert.SerializeObject(data.ChiTiet)));
                Command.Parameters.Add(new MDB.MDBParameter(":ThoiGianPT", data.ThoiGianPT));
                Command.Parameters.Add(new MDB.MDBParameter(":PTV", data.PTV));
                Command.Parameters.Add(new MDB.MDBParameter(":NguoiTao", data.NguoiTao));
                Command.Parameters.Add(new MDB.MDBParameter(":NguoiSua", data.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter(":NgayTao", data.NgayTao));
                Command.Parameters.Add(new MDB.MDBParameter(":NgaySua", data.NgaySua));
                int n = Command.ExecuteNonQuery();
                return n > 0;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
                return false;
            }
        }
        public static bool Update(MDB.MDBConnection _OracleConnection, PhieuTheoDoiBenhNhanNangCls data)
        {
            try
            {
                string sql = @"UPDATE PhieuTheoDoiBenhNhanNang SET 
                MaQuanLy = :MaQuanLy, 
                ChanDoan = :ChanDoan, 
                ChiTiet = :ChiTiet,
                ThoiGianPT= :ThoiGianPT,
                PTV= :PTV,
                NguoiTao= :NguoiTao,
                NguoiSua= :NguoiSua,
                NgayTao= :NgayTao,
                NgaySua= :NgaySua
                WHERE IDPhieu = " + data.IDPhieu;
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter(":MaQuanLy", data.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter(":ChanDoan", data.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter(":ChiTiet", JsonConvert.SerializeObject(data.ChiTiet)));
                Command.Parameters.Add(new MDB.MDBParameter(":ThoiGianPT", data.ThoiGianPT));
                Command.Parameters.Add(new MDB.MDBParameter(":PTV", data.PTV));
                Command.Parameters.Add(new MDB.MDBParameter(":NguoiTao", data.NguoiTao));
                Command.Parameters.Add(new MDB.MDBParameter(":NguoiSua", data.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter(":NgayTao", data.NgayTao));
                Command.Parameters.Add(new MDB.MDBParameter(":NgaySua", data.NgaySua));
                int n = Command.ExecuteNonQuery();
                return n > 0;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool Delete(MDB.MDBConnection _OracleConnection, decimal IDPhieu)
        {
            try
            {
                if (IDPhieu != 0)
                {
                    string sql = @"DELETE FROM PhieuTheoDoiBenhNhanNang WHERE IDPhieu = :IDPhieu";
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                    Command.Parameters.Add(new MDB.MDBParameter(":IDPhieu", IDPhieu));
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

    public class PhieuTheoDoiBenhNhanNangChiTiet
    {
        public DateTime NgayGioThucHien { get; set; }
        [MoTaDuLieu("Mạch")]
		public string Mach { get; set; }
        public string Nhiet { get; set; }
        [MoTaDuLieu("Huyết áp")]
		public string HuyetAp { get; set; }
        [MoTaDuLieu("Nhịp thở")]
		public string NhipTho { get; set; }
        [MoTaDuLieu("Nước tiểu")]
		public string NuocTieu { get; set; }
        public string Phan { get; set; }
        public string Non { get; set; }
        public string DLuu { get; set; }
        public string Truyen { get; set; }
        public string An { get; set; }
        public string Uong { get; set; }
        public string TrangThaiChung { get; set; }
        public string MaNguoiTheoDoi { get; set; }
    }
}