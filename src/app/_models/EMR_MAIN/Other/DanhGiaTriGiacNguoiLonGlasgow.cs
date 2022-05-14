using EMR.KyDienTu;
using System;
using System.Collections.Generic;
using PMS.Access;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class DanhGiaTriGiacNguoiLonGlasgow : ThongTinKy
    {
        public DanhGiaTriGiacNguoiLonGlasgow()
        {
            TableName = "DanhGiaTriGiacNguoiLonGlasgow";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.DGTGNLGG;
            TenMauPhieu = DanhMucPhieu.DGTGNLGG.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        public int SoPhieu { get; set; }
        public string NguoiDanhGia { get; set; }
        public string MaNguoiDanhGia { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
    }
    public class DanhGiaTriGiacNguoiLonGlasgowFunc
    {
        public const string TableName = "DanhGiaTriGiacNguoiLonGlasgow";
        public const string TablePrimaryKeyName = "ID";
        public static List<DanhGiaTriGiacNguoiLonGlasgow> GetData(decimal maQuanLy, MDB.MDBConnection _OracleConnection)
        {
            List<DanhGiaTriGiacNguoiLonGlasgow> lstData = new List<DanhGiaTriGiacNguoiLonGlasgow>();
            try
            {
                string sql = @"SELECT * FROM DanhGiaTriGiacNguoiLonGLASGOW where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maQuanLy));
                Command.BindByName = true;
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
				if (XemBenhAn._HanhChinhBenhNhan == null) XemBenhAn._HanhChinhBenhNhan = new HanhChinhBenhNhan();
                while (DataReader.Read())
                {
                   DanhGiaTriGiacNguoiLonGlasgow data = new DanhGiaTriGiacNguoiLonGlasgow();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maQuanLy;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.TenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    int temp = 0;
                    int.TryParse(DataReader["SoPhieu"].ToString(), out temp);
                    data.SoPhieu = temp;

                    data.NguoiDanhGia = DataReader["NguoiDanhGia"].ToString();
                    data.MaNguoiDanhGia = DataReader["MaNguoiDanhGia"].ToString();
                    data.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                    data.NguoiTao = DataReader["NguoiTao"].ToString();
                    data.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);
                    data.NguoiSua = DataReader["NguoiSua"].ToString();
                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;
                    lstData.Add(data);
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return lstData;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref DanhGiaTriGiacNguoiLonGlasgow phieu)
        {
            string sql = @"INSERT INTO DanhGiaTriGiacNguoiLonGLASGOW
                (
                    MAQUANLY,
                    MaBenhNhan,
                    SoPhieu,
                    NguoiDanhGia,
                    MaNguoiDanhGia,
                    NGUOITAO,
                    NGAYTAO,
                    NGUOISUA,
                    NGAYSUA)  VALUES
                 (
                    :MAQUANLY,
                    :MaBenhNhan,
                    :SoPhieu,
                    :NguoiDanhGia,
                    :MaNguoiDanhGia,
                    :NGUOITAO,
                    :NGAYTAO,
                    :NGUOISUA,
                    :NGAYSUA
                )  RETURNING ID INTO :ID";
            if (phieu.ID != 0)
            {
                sql = @"UPDATE DanhGiaTriGiacNguoiLonGLASGOW SET 
                    MAQUANLY = :MAQUANLY, 
                    MaBenhNhan = :MaBenhNhan, 
                    SoPhieu = :SoPhieu,
                    NguoiDanhGia = :NguoiDanhGia,
                    MaNguoiDanhGia = :MaNguoiDanhGia,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + phieu.ID;
            }
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", phieu.MaQuanLy));
            Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", phieu.MaBenhNhan));
            Command.Parameters.Add(new MDB.MDBParameter("SoPhieu", phieu.SoPhieu));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiDanhGia", phieu.NguoiDanhGia));
            Command.Parameters.Add(new MDB.MDBParameter("MaNguoiDanhGia", phieu.MaNguoiDanhGia));
            Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", phieu.NguoiSua));
            Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", phieu.NgaySua));
            if (phieu.ID == 0)
            {
                Command.Parameters.Add(new MDB.MDBParameter("ID", phieu.ID));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", phieu.NguoiTao));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", phieu.NgayTao));
            }
            Command.BindByName = true;
            int n = Command.ExecuteNonQuery(); // C#
            if (phieu.ID == 0)
            {
                long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                phieu.ID = nextval;
            }

            return n > 0 ? true : false;
        }
        public static bool delete(MDB.MDBConnection MyConnection, long ID)
        {
            try
            {
                string sql = "DELETE FROM DanhGiaTriGiacNguoiLonGLASGOW WHERE ID = :ID";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                command.Parameters.Add(new MDB.MDBParameter("ID", ID));
                command.BindByName = true;
                int n = command.ExecuteNonQuery();
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
    }
    public class DanhGiaTriGiacNguoiLonGlasgow_ChiTiet
    {
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã định danh")]
		public long IDBangDanhGia { get; set; }
        public int SoPhieu { get; set; }
        public DateTime Ngay { get; set; }
        public DateTime Gio { get; set; }
        public bool[] MoMatArray { get; } = new bool[] { false, false, false, false };
        public int MoMat
        {
            get
            {
                return Array.IndexOf(MoMatArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 4; i++)
                {
                    if (i == (value - 1) ) MoMatArray[i] = true;
                    else MoMatArray[i] = false;
                }
            }
        }
        public bool[] DapUngLoiNoiArray { get; } = new bool[] { false, false, false, false, false };
        public int DapUngLoiNoi
        {
            get
            {
                return Array.IndexOf(DapUngLoiNoiArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 5; i++)
                {
                    if (i == (value - 1)) DapUngLoiNoiArray[i] = true;
                    else DapUngLoiNoiArray[i] = false;
                }
            }
        }
        public bool[] DapUngVanDongArray { get; } = new bool[] { false, false, false, false, false, false };
        public int DapUngVanDong
        {
            get
            {
                return Array.IndexOf(DapUngVanDongArray, true) +  1;
            }
            set
            {
                for (int i = 0; i < 6; i++)
                {
                    if (i == (value -1 )) DapUngVanDongArray[i] = true;
                    else DapUngVanDongArray[i] = false;
                }
            }
        }
        public int TongSoDiem { get; set; }
        public string BacSyDieuDuong { get; set; }
        public string MaBacSyDieuDuong { get; set; }
    }
    public class DanhGiaTriGiacNguoiLonGlasgow_ChiTietFunc
    {
        public static List<DanhGiaTriGiacNguoiLonGlasgow_ChiTiet> GetData(long IDBangDanhGia, int SoPhieu, MDB.MDBConnection _OracleConnection)
        {
            List<DanhGiaTriGiacNguoiLonGlasgow_ChiTiet> lstData = new List<DanhGiaTriGiacNguoiLonGlasgow_ChiTiet>();
            try
            {
                string sql = @"SELECT * FROM DGTGNLGLASGOW_ChiTiet where IDBangDanhGia = :IDBangDanhGia and SoPhieu = :SoPhieu";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("IDBangDanhGia", IDBangDanhGia));
                Command.Parameters.Add(new MDB.MDBParameter("SoPhieu", SoPhieu));
                Command.BindByName = true;
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    DanhGiaTriGiacNguoiLonGlasgow_ChiTiet data = new DanhGiaTriGiacNguoiLonGlasgow_ChiTiet();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.IDBangDanhGia = IDBangDanhGia;
                    data.SoPhieu = SoPhieu;
                    DateTime NgayGio = Convert.ToDateTime(DataReader["NgayGio"] == DBNull.Value ? DateTime.Now : DataReader["NgayGio"]);
                    data.Ngay = NgayGio;
                    data.Gio = NgayGio;

                    int temp = 0;
                    int.TryParse(DataReader["MoMat"].ToString(), out temp);
                    data.MoMat = temp;

                    temp = 0;
                    int.TryParse(DataReader["DapUngLoiNoi"].ToString(), out temp);
                    data.DapUngLoiNoi = temp;

                    temp = 0;
                    int.TryParse(DataReader["DapUngVanDong"].ToString(), out temp);
                    data.DapUngVanDong = temp;

                    temp = 0;
                    int.TryParse(DataReader["TongSoDiem"].ToString(), out temp);
                    data.TongSoDiem = temp;

                    data.BacSyDieuDuong = DataReader["BacSyDieuDuong"].ToString();
                    data.MaBacSyDieuDuong = DataReader["MaBacSyDieuDuong"].ToString();
                    lstData.Add(data);
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return lstData;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref DanhGiaTriGiacNguoiLonGlasgow_ChiTiet phieu)
        {
            string sql = @"INSERT INTO DGTGNLGLASGOW_ChiTiet
                (
                    IDBangDanhGia,
                    SoPhieu,
                    NgayGio,
                    MoMat,
                    DapUngLoiNoi,
                    DapUngVanDong,
                    TongSoDiem,
                    BacSyDieuDuong,
                    MaBacSyDieuDuong
                )  VALUES
                 (
                    :IDBangDanhGia,
                    :SoPhieu,
                    :NgayGio,
                    :MoMat,
                    :DapUngLoiNoi,
                    :DapUngVanDong,
                    :TongSoDiem,
                    :BacSyDieuDuong,
                    :MaBacSyDieuDuong
                )  RETURNING ID INTO :ID";
            if (phieu.ID != 0)
            {
                sql = @"UPDATE DGTGNLGLASGOW_ChiTiet SET 
                    IDBangDanhGia = :IDBangDanhGia, 
                    SoPhieu = :SoPhieu, 
                    NgayGio = :NgayGio,
                    MoMat = :MoMat,
                    DapUngLoiNoi = :DapUngLoiNoi,
                    DapUngVanDong = :DapUngVanDong,
                    TongSoDiem = :TongSoDiem,
                    BacSyDieuDuong = :BacSyDieuDuong,
                    MaBacSyDieuDuong = :MaBacSyDieuDuong
                    WHERE ID = " + phieu.ID;
            }
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("IDBangDanhGia", phieu.IDBangDanhGia));
            Command.Parameters.Add(new MDB.MDBParameter("SoPhieu", phieu.SoPhieu));
            var Ngay = phieu.Ngay.Date.Add(new TimeSpan(0, 0, 0));
            var Gio = phieu.Gio != null ? phieu.Gio.TimeOfDay : DateTime.Now.TimeOfDay;
            var NgayGio = Ngay + Gio;
            Command.Parameters.Add(new MDB.MDBParameter("NgayGio", NgayGio));
            Command.Parameters.Add(new MDB.MDBParameter("MoMat", phieu.MoMat));
            Command.Parameters.Add(new MDB.MDBParameter("DapUngLoiNoi", phieu.DapUngLoiNoi));
            Command.Parameters.Add(new MDB.MDBParameter("DapUngVanDong", phieu.DapUngVanDong));
            Command.Parameters.Add(new MDB.MDBParameter("TongSoDiem", phieu.TongSoDiem));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuDuong", phieu.BacSyDieuDuong));
            Command.Parameters.Add(new MDB.MDBParameter("MaBacSyDieuDuong", phieu.MaBacSyDieuDuong));
            if (phieu.ID == 0)
            {
                Command.Parameters.Add(new MDB.MDBParameter("ID", phieu.ID));
            }
            Command.BindByName = true;
            int n = Command.ExecuteNonQuery(); // C#
            if (phieu.ID == 0)
            {
                long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                phieu.ID = nextval;
            }

            return n > 0 ? true : false;
        }
        public static bool delete(MDB.MDBConnection MyConnection, decimal ID)
        {
            try
            {
                string sql = "DELETE FROM DGTGNLGLASGOW_ChiTiet WHERE ID = :ID";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                command.Parameters.Add(new MDB.MDBParameter("ID", ID));
                command.BindByName = true;
                int n = command.ExecuteNonQuery();
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
