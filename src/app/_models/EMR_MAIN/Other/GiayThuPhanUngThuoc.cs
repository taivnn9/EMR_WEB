using EMR.KyDienTu;
using Newtonsoft.Json;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMR_MAIN.DATABASE.Other
{
    public class GiayThuPhanUngThuoc : ThongTinKy
    {
        public GiayThuPhanUngThuoc()
        {
            TableName = "GiayThuPhanUngThuoc";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.GTPUT;
            TenMauPhieu = DanhMucPhieu.GTPUT.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        public string HoTenNguoiBenh { get; set; }
        public string MaSo { get; set; }
        public string SoVaoVien { get; set; }
        public string MaDieuTri { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
        public string Tuoi { get; set; }
        [MoTaDuLieu("Địa chỉ bệnh nhân")]
        public string DiaChi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        public string Khoa { get; set; }
        public string MaKhoa { get; set; }
        public string Buong { get; set; }
        public string Giuong { get; set; }
        public string ChanDoan { get; set; }
        public DateTime GioThu { get; set; }
        public string TenThuoc { get; set; }
		public string PhuongPhapThu { get; set; }
        [MoTaDuLieu("Bác sỹ chỉ định")]
        public string MaBacSyChiDinh { get; set; }
        public string BacSyChiDinh { get; set; }
        [MoTaDuLieu("Người thử")]
		public string MaNguoiThu { get; set; }
        public string NguoiThu { get; set; }
        [MoTaDuLieu("Bác sỹ đọc và kiểm tra")]
        public string MaBacSyDKT { get; set; }
        public string BacSyDKT { get; set; }
        [MoTaDuLieu("Giờ phút đọc, kiểm tra")]
        public DateTime GioDocKQ { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
    }

    public class GiayThuPhanUngThuocFunc
    {
        public const string TableName = "GiayThuPhanUngThuoc";
        public const string TablePrimaryKeyName = "ID";
        public static List<GiayThuPhanUngThuoc> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<GiayThuPhanUngThuoc> list = new List<GiayThuPhanUngThuoc>();
            try
            {
                string sql = @"SELECT * FROM GiayThuPhanUngThuoc where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    GiayThuPhanUngThuoc data = new GiayThuPhanUngThuoc();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.HoTenNguoiBenh = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.MaSo = Common.ConDBNull(DataReader["MaSo"]);
                    data.SoVaoVien = Common.ConDBNull(DataReader["SoVaoVien"]);
                    data.MaDieuTri = Common.ConDBNull(DataReader["MaDieuTri"]);
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.DiaChi = Common.ConDBNull(DataReader["DiaChi"]);
                    data.Khoa = Common.ConDBNull(DataReader["Khoa"]);
                    data.MaKhoa = Common.ConDBNull(DataReader["MaKhoa"]);
                    data.Buong = Common.ConDBNull(DataReader["Buong"]);
                    data.Giuong = Common.ConDBNull(DataReader["Giuong"]);
                    data.ChanDoan = Common.ConDBNull(DataReader["ChanDoan"]);
                    //data.ChanDoan = XemBenhAn._ThongTinDieuTri.ChanDoan_SoBo;
                    data.GioThu = Common.ConDB_DateTime(DataReader["GioThu"]);
                    data.TenThuoc = Common.ConDBNull(DataReader["TenThuoc"]);
                    data.PhuongPhapThu = Common.ConDBNull(DataReader["PhuongPhapThu"]);
                    data.MaBacSyChiDinh = Common.ConDBNull(DataReader["MaBacSyChiDinh"]);
                    data.BacSyChiDinh = Common.ConDBNull(DataReader["BacSyChiDinh"]);
                    data.MaNguoiThu = Common.ConDBNull(DataReader["MaNguoiThu"]);
                    data.NguoiThu = Common.ConDBNull(DataReader["NguoiThu"]);
                    data.MaBacSyDKT = Common.ConDBNull(DataReader["MaBacSyDKT"]);
                    data.BacSyDKT = Common.ConDBNull(DataReader["BacSyDKT"]);
                    data.GioDocKQ = Common.ConDB_DateTime(DataReader["GioDocKQ"]);
                    data.NgayTao = Common.ConDB_DateTime(DataReader["NgayTao"]);
                    data.NguoiTao = DataReader["NguoiTao"].ToString();
                    data.NgaySua = Common.ConDB_DateTime(DataReader["NgaySua"]);
                    data.NguoiSua = DataReader["NguoiSua"].ToString();

                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy);
                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref GiayThuPhanUngThuoc data)
        {
            try
            {
                string sql = @"INSERT INTO GiayThuPhanUngThuoc
                (
                    MaQuanLy,
                    MaBenhNhan,
                    MaSo,
                    SoVaoVien,
                    MaDieuTri,
                    Tuoi,
                    GioiTinh,
                    DiaChi,
                    Khoa,
                    MaKhoa,
                    Buong,
                    Giuong,
                    ChanDoan,
                    GioThu,
                    TenThuoc,
                    PhuongPhapThu,
                    MaBacSyChiDinh,
                    BacSyChiDinh,
                    MaNguoiThu,
                    NguoiThu,
                    MaBacSyDKT,
                    BacSyDKT,
                    GioDocKQ,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
                    :MaQuanLy,
                    :MaBenhNhan,
                    :MaSo,
                    :SoVaoVien,
                    :MaDieuTri,
                    :Tuoi,
                    :GioiTinh,
                    :DiaChi,
                    :Khoa,
                    :MaKhoa,
                    :Buong,
                    :Giuong,
                    :ChanDoan,
                    :GioThu,
                    :TenThuoc,
                    :PhuongPhapThu,
                    :MaBacSyChiDinh,
                    :BacSyChiDinh,
                    :MaNguoiThu,
                    :NguoiThu,
                    :MaBacSyDKT,
                    :BacSyDKT,
                    :GioDocKQ,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (data.ID != 0)
                {
                    sql = @"UPDATE GiayThuPhanUngThuoc SET 
                    MaQuanLy=:MaQuanLy,
                    MaBenhNhan=:MaBenhNhan,
                    MaSo=:MaSo,
                    SoVaoVien=:SoVaoVien,
                    MaDieuTri=:MaDieuTri,
                    Tuoi=:Tuoi,
                    GioiTinh=:GioiTinh,
                    DiaChi=:DiaChi,
                    Khoa=:Khoa,
                    MaKhoa=:MaKhoa,
                    Buong=:Buong,
                    Giuong=:Giuong,
                    ChanDoan=:ChanDoan,
                    GioThu=:GioThu,
                    TenThuoc=:TenThuoc,
                    PhuongPhapThu=:PhuongPhapThu,
                    MaBacSyChiDinh=:MaBacSyChiDinh,
                    BacSyChiDinh=:BacSyChiDinh,
                    MaNguoiThu=:MaNguoiThu,
                    NguoiThu=:NguoiThu,
                    MaBacSyDKT=:MaBacSyDKT,
                    BacSyDKT=:BacSyDKT,
                    GioDocKQ=:GioDocKQ,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + data.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", data.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", data.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("MaSo", data.MaSo));
                Command.Parameters.Add(new MDB.MDBParameter("SoVaoVien", data.SoVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuTri", data.MaDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("Tuoi", data.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("GioiTinh", data.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", data.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa", data.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaKhoa", data.MaKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("Buong", data.Buong));
                Command.Parameters.Add(new MDB.MDBParameter("Giuong", data.Giuong));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", data.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("GioThu", data.GioThu));
                Command.Parameters.Add(new MDB.MDBParameter("TenThuoc", data.TenThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapThu", data.PhuongPhapThu));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSyChiDinh", data.MaBacSyChiDinh));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyChiDinh", data.BacSyChiDinh));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiThu", data.MaNguoiThu));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiThu", data.NguoiThu));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSyDKT", data.MaBacSyDKT));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyDKT", data.BacSyDKT));
                Command.Parameters.Add(new MDB.MDBParameter("GioDocKQ", data.GioDocKQ));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", data.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", data.NgaySua));
                if (data.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", data.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", data.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", data.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (data.ID == 0)
                {
                    data.ID = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                }
                return n > 0;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool Delete(MDB.MDBConnection MyConnection, long id)
        {
            try
            {
                string sql = "DELETE FROM GiayThuPhanUngThuoc WHERE ID = :ID";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                command.Parameters.Add(new MDB.MDBParameter("ID", id));
                command.BindByName = true;
                int n = command.ExecuteNonQuery();
                return n > 0;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static DataSet getDataSet(MDB.MDBConnection MyConnection, long id)
        {
            string sql = @"SELECT
                P.*,
                H.GIOITINH,
	            H.TENBENHNHAN,
                H.TUOI,
                H.SOYTE,
                H.BENHVIEN,
                (H.SONHA || ',' || H.THONPHO || ',' ||  H.XAPHUONG || ',' ||  H.HUYENQUAN || ',' ||  H.TINHTHANHPHO) AS DIACHI 
            FROM
                GiayThuPhanUngThuoc P
                LEFT JOIN THONGTINDIEUTRI T ON P.MAQUANLY = T.MAQUANLY
                LEFT JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            adt.Fill(ds, "Table");
            return ds;
        }
    }
}
