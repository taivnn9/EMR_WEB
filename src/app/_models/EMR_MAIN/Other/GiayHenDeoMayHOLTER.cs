
using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class GiayHenDeoMayHOLTER : ThongTinKy
    {
        public GiayHenDeoMayHOLTER()
        {
            TableName = "GiayHenDeoMayHOLTER";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.GHDMHOLTER;
            TenMauPhieu = DanhMucPhieu.GHDMHOLTER.Description();
        }

        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        public string SdtBenhVien { get; set; }
        public string HolterName { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public DateTime? ThoiGian { get; set; }
        public DateTime? ThoiGian_Gio { get; set; }
        public string SoTienCuoc { get; set; }
        public string BacSyChiDinh { get; set; }
        public string MaNVBacSyChiDinh { get; set; }

        public string MaNVNguoiVietPhieu { get; set; }
        public string NguoiVietPhieu { get; set; }

        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        //public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
    }
    public class GiayHenDeoMayHOLTERFunc
    {
        public const string TableName = "GiayHenDeoMayHOLTER";
        public const string TablePrimaryKeyName = "ID";

        public static List<GiayHenDeoMayHOLTER> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<GiayHenDeoMayHOLTER> list = new List<GiayHenDeoMayHOLTER>();
            try
            {
                string sql = @"SELECT * FROM GiayHenDeoMayHOLTER where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    GiayHenDeoMayHOLTER data = new GiayHenDeoMayHOLTER();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = XemBenhAn._HanhChinhBenhNhan.MaBenhNhan;

                    data.TenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    //data.SdtBenhVien = "0243.9427796";

                    data.HolterName = DataReader["HolterName"].ToString();
                    data.DiaChi = DataReader["DiaChi"].ToString();
                    data.DienThoai = DataReader["DienThoai"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.ThoiGian = Convert.ToDateTime(DataReader["ThoiGian"] == DBNull.Value ? DateTime.Now : DataReader["ThoiGian"]);
                    data.ThoiGian_Gio = data.ThoiGian;

                    data.SoTienCuoc = DataReader["SoTienCuoc"].ToString();
                    data.MaNVBacSyChiDinh = DataReader["MaNVBacSyChiDinh"].ToString();
                    data.BacSyChiDinh = DataReader["BacSyChiDinh"].ToString();
                    data.MaNVNguoiVietPhieu = DataReader["MaNVNguoiVietPhieu"].ToString();
                    data.NguoiVietPhieu = DataReader["NguoiVietPhieu"].ToString();

                    data.NgayTao = Convert.ToDateTime(DataReader["NGAYTAO"] == DBNull.Value ? DateTime.Now : DataReader["NGAYTAO"]);
                    data.NguoiTao = DataReader["NGUOITAO"].ToString();
                    data.NgaySua = Convert.ToDateTime(DataReader["NGAYSUA"] == DBNull.Value ? DateTime.Now : DataReader["NGAYSUA"]);
                    data.NguoiSua = DataReader["NGUOISUA"].ToString();

                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;
                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool DeleteByIDPhieu(MDB.MDBConnection oracleConnection, decimal IDBienBan)
        {
            try
            {
                string sql = "";
                MDB.MDBCommand oracleCommand;
                sql = @"DELETE FROM GiayHenDeoMayHOLTER WHERE ID =" + IDBienBan;
                using (oracleCommand = new MDB.MDBCommand(sql, oracleConnection))
                {
                    oracleCommand.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                XuLyLoi.LogError(ex);
            }
            return false;
        }
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, long IDBienBan)
        {
            string sql = @"SELECT P.*, T.SoNhapVien, T.Khoa , T.NgayVaoVien ,  T.MaKhoa, T.MaBenhAn,     
				H.TUOI, H.SoYTe, H.BENHVIEN, H.TenBenhNhan, H.maBenhNhan
			  FROM GiayHenDeoMayHOLTER P 
				Left JOIN THONGTINDIEUTRI T ON P.MAQUANLY = T.MAQUANLY
				Left JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
			  where ID = :IDPhieu";
            MDB.MDBCommand Command;
            MDB.MDBDataAdapter adt;
            using (Command = new MDB.MDBCommand(sql, MyConnection))
            {
                Command.Parameters.Add(new MDB.MDBParameter("IDPhieu", IDBienBan));
                adt = new MDB.MDBDataAdapter(Command);
            }
            var ds = new DataSet();
            adt.Fill(ds, "TBL");

            ds.Tables[0].AddColumn("GioiTinh", typeof(string));
            ds.Tables[0].AddColumn("ThongTinNgayThang", typeof(string));
            //ds.Tables[0].AddColumn("SdtBenhVien", typeof(string));
            ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            ds.Tables[0].Rows[0]["ThongTinNgayThang"] = "Ngày " + DateTime.Now.Day + " tháng " + DateTime.Now.Month + " năm " + DateTime.Now.Year;
            //ds.Tables[0].Rows[0]["SdtBenhVien"] = "0243.9427796";
            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref GiayHenDeoMayHOLTER ketQua)
        {
            try
            {
                string sql = @"INSERT INTO GiayHenDeoMayHOLTER
                (
                    MAQUANLY,
                    MaBenhNhan,
                    HolterName,
                    DiaChi,
                    DienThoai,
                    ChanDoan,
                    ThoiGian,
                    SoTienCuoc,
                    MaNVBacSyChiDinh,
                    BacSyChiDinh,
                    MaNVNguoiVietPhieu,
                    NguoiVietPhieu,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
                    :MaBenhNhan,
                    :HolterName,
                    :DiaChi,
                    :DienThoai,
                    :ChanDoan,
                    :ThoiGian,
                    :SoTienCuoc,
                    :MaNVBacSyChiDinh,
                    :BacSyChiDinh,
                    :MaNVNguoiVietPhieu,
                    :NguoiVietPhieu,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE GiayHenDeoMayHOLTER SET 
                    MAQUANLY = :MaQuanLy,
                    MaBenhNhan = :MaBenhNhan,
                    HolterName = :HolterName,
                    DiaChi = :DiaChi,
                    DienThoai = :DienThoai,
                    ChanDoan = :ChanDoan,
                    ThoiGian = :ThoiGian,
                    SoTienCuoc = :SoTienCuoc,
                    MaNVBacSyChiDinh = :MaNVBacSyChiDinh,
                    BacSyChiDinh = :BacSyChiDinh,
                    MaNVNguoiVietPhieu = :MaNVNguoiVietPhieu,
                    NguoiVietPhieu = :NguoiVietPhieu,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ketQua.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("HolterName", ketQua.HolterName));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", ketQua.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("DienThoai", ketQua.DienThoai));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", ketQua.ChanDoan));

                DateTime? ThoiGian = ketQua.ThoiGian.HasValue ? ketQua.ThoiGian.Value.Date : (DateTime?)null;
                var ThoiGianFull = ThoiGian;
                if (ThoiGian != null)
                {
                    var ThoiGian_Gio = ketQua.ThoiGian_Gio.HasValue ? ketQua.ThoiGian_Gio.Value.TimeOfDay : new TimeSpan(0, 0, 0);
                    ThoiGianFull = ThoiGian + ThoiGian_Gio;
                }
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGian", ThoiGianFull));
                Command.Parameters.Add(new MDB.MDBParameter("SoTienCuoc", ketQua.SoTienCuoc));
                Command.Parameters.Add(new MDB.MDBParameter("MaNVBacSyChiDinh", ketQua.MaNVBacSyChiDinh));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyChiDinh", ketQua.BacSyChiDinh));
                Command.Parameters.Add(new MDB.MDBParameter("MaNVNguoiVietPhieu", ketQua.MaNVNguoiVietPhieu));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiVietPhieu", ketQua.NguoiVietPhieu));

                if (ketQua.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", ketQua.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", ketQua.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", ketQua.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (ketQua.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    ketQua.ID = nextval;
                }
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.LogError(ex);
            }
            return false;
        }
       
        public static string ConDBNull(object dbVal)
        {
            string ret = "";
            if (dbVal == null)
            {
                return ret;
            }
            ret = dbVal.ToString();
            return ret;
        }
        public static decimal ConDB_Decimal(object dbVal, decimal valDefault = 0)
        {
            decimal ret = valDefault;
            if (dbVal == null)
            {
                return ret;
            }
            bool isSuccess = decimal.TryParse(dbVal.ToString(), out ret);
            if (!isSuccess)
            {
                return valDefault;
            }
            return ret;
        }
        public static int ConDB_Int(object dbVal, int valDefault = 0)
        {
            int ret = valDefault;
            if (dbVal == null)
            {
                return ret;
            }
            bool isSuccess = int.TryParse(dbVal.ToString(), out ret);
            if (!isSuccess)
            {
                return valDefault;
            }
            return ret;
        }
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
    }
}
