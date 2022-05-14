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
    public class GiaiPhauBenhSinhThiet : ThongTinKy
    {
        public GiaiPhauBenhSinhThiet()
        {
            TableName = "GiaiPhauBenhSinhThiet";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.GPBST;
            TenMauPhieu = DanhMucPhieu.GPBST.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        public string HoTenNguoiBenh { get; set; }
        public string SoBenhAn { get; set; }
        public string SoPhieu { get; set; }
        public string SoVaoVien { get; set; }
        public int Loai { get; set; }
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
        public string YeuCauXetNghiem { get; set; }
		public string SinhThietDLT { get; set; }
        public string CoDinhDungDich { get; set; }
        public DateTime GioCDDD { get; set; }
        public DateTime NgayCDDD { get; set; }
        public string TomTatDauHieu { get; set; }
        public string QuaTrinhDieuTri { get; set; }
        public string NhanXet { get; set; }
        public string KetQuaLanTruoc { get; set; }
        public string ChuanDoanLamSan { get; set; }
        [MoTaDuLieu("Bác sỹ điều trị")]
		public string BacSiDieuTri { get; set; }
        public string MaBacSiDieuTri { get; set; }
        public DateTime ThoiGian { get; set; }
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

    public class GiaiPhauBenhSinhThietFunc
    {
        public const string TableName = "GiaiPhauBenhSinhThiet";
        public const string TablePrimaryKeyName = "ID";
        public static List<GiaiPhauBenhSinhThiet> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<GiaiPhauBenhSinhThiet> list = new List<GiaiPhauBenhSinhThiet>();
            try
            {
                string sql = @"SELECT * FROM GiaiPhauBenhSinhThiet where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    GiaiPhauBenhSinhThiet data = new GiaiPhauBenhSinhThiet();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.HoTenNguoiBenh = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.SoBenhAn = Common.ConDBNull(DataReader["SoBenhAn"]);
                    data.SoPhieu = Common.ConDBNull(DataReader["SoPhieu"]);
                    data.SoVaoVien = Common.ConDBNull(DataReader["SoVaoVien"]);
                    data.Loai = Common.ConDB_Int(DataReader["Loai"]);
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.DiaChi = Common.ConDBNull(DataReader["DiaChi"]);
                    data.Khoa = Common.ConDBNull(DataReader["Khoa"]);
                    data.MaKhoa = Common.ConDBNull(DataReader["MaKhoa"]);
                    data.Buong = Common.ConDBNull(DataReader["Buong"]);
                    data.Giuong = Common.ConDBNull(DataReader["Giuong"]);
                    data.YeuCauXetNghiem = Common.ConDBNull(DataReader["YeuCauXetNghiem"]);
                    data.SinhThietDLT = Common.ConDBNull(DataReader["SinhThietDLT"]);
                    data.CoDinhDungDich = Common.ConDBNull(DataReader["CoDinhDungDich"]);
                    data.GioCDDD = Common.ConDB_DateTime(DataReader["GioCDDD"]);
                    data.NgayCDDD = Common.ConDB_DateTime(DataReader["NgayCDDD"]);
                    data.TomTatDauHieu = Common.ConDBNull(DataReader["TomTatDauHieu"]);
                    data.QuaTrinhDieuTri = Common.ConDBNull(DataReader["QuaTrinhDieuTri"]);
                    data.NhanXet = Common.ConDBNull(DataReader["NhanXet"]);
                    data.KetQuaLanTruoc = Common.ConDBNull(DataReader["KetQuaLanTruoc"]);
                    data.ChuanDoanLamSan = Common.ConDBNull(DataReader["ChuanDoanLamSan"]);
                    data.BacSiDieuTri = Common.ConDBNull(DataReader["BacSiDieuTri"]);
                    data.MaBacSiDieuTri = Common.ConDBNull(DataReader["MaBacSiDieuTri"]);
                    data.ThoiGian = Common.ConDB_DateTime(DataReader["ThoiGian"]);
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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref GiaiPhauBenhSinhThiet data)
        {
            try
            {
                string sql = @"INSERT INTO GiaiPhauBenhSinhThiet
                (
                    MaQuanLy,
                    MaBenhNhan,
                    SoBenhAn,
                    SoPhieu,
                    SoVaoVien,
                    Loai,
                    Tuoi,
                    GioiTinh,
                    DiaChi,
                    Khoa,
                    MaKhoa,
                    Buong,
                    Giuong,
                    YeuCauXetNghiem,
                    SinhThietDLT,
                    CoDinhDungDich,
                    GioCDDD,
                    NgayCDDD,
                    TomTatDauHieu,
                    QuaTrinhDieuTri,
                    NhanXet,
                    KetQuaLanTruoc,
                    ChuanDoanLamSan,
                    BacSiDieuTri,
                    MaBacSiDieuTri,
                    ThoiGian,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
                    :MaQuanLy,
                    :MaBenhNhan,
                    :SoBenhAn,
                    :SoPhieu,
                    :SoVaoVien,
                    :Loai,
                    :Tuoi,
                    :GioiTinh,
                    :DiaChi,
                    :Khoa,
                    :MaKhoa,
                    :Buong,
                    :Giuong,
                    :YeuCauXetNghiem,
                    :SinhThietDLT,
                    :CoDinhDungDich,
                    :GioCDDD,
                    :NgayCDDD,
                    :TomTatDauHieu,
                    :QuaTrinhDieuTri,
                    :NhanXet,
                    :KetQuaLanTruoc,
                    :ChuanDoanLamSan,
                    :BacSiDieuTri,
                    :MaBacSiDieuTri,
                    :ThoiGian,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (data.ID != 0)
                {
                    sql = @"UPDATE GiaiPhauBenhSinhThiet SET 
                    MaQuanLy=:MaQuanLy,
                    MaBenhNhan=:MaBenhNhan,
                    SoBenhAn=:SoBenhAn,
                    SoPhieu=:SoPhieu,
                    SoVaoVien=:SoVaoVien,
                    Loai=:Loai,
                    Tuoi=:Tuoi,
                    GioiTinh=:GioiTinh,
                    DiaChi=:DiaChi,
                    Khoa=:Khoa,
                    MaKhoa=:MaKhoa,
                    Buong=:Buong,
                    Giuong=:Giuong,
                    YeuCauXetNghiem=:YeuCauXetNghiem,
                    SinhThietDLT=:SinhThietDLT,
                    CoDinhDungDich=:CoDinhDungDich,
                    GioCDDD=:GioCDDD,
                    NgayCDDD=:NgayCDDD,
                    TomTatDauHieu=:TomTatDauHieu,
                    QuaTrinhDieuTri=:QuaTrinhDieuTri,
                    NhanXet=:NhanXet,
                    KetQuaLanTruoc=:KetQuaLanTruoc,
                    ChuanDoanLamSan=:ChuanDoanLamSan,
                    BacSiDieuTri=:BacSiDieuTri,
                    MaBacSiDieuTri=:MaBacSiDieuTri,
                    ThoiGian=:ThoiGian,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + data.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", data.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", data.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("SoBenhAn", data.SoBenhAn));
                Command.Parameters.Add(new MDB.MDBParameter("SoPhieu", data.SoPhieu));
                Command.Parameters.Add(new MDB.MDBParameter("SoVaoVien", data.SoVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("Loai", data.Loai));
                Command.Parameters.Add(new MDB.MDBParameter("Tuoi", data.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("GioiTinh", data.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", data.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa", data.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaKhoa", data.MaKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("Buong", data.Buong));
                Command.Parameters.Add(new MDB.MDBParameter("Giuong", data.Giuong));
                Command.Parameters.Add(new MDB.MDBParameter("YeuCauXetNghiem", data.YeuCauXetNghiem));
                Command.Parameters.Add(new MDB.MDBParameter("SinhThietDLT", data.SinhThietDLT));
                Command.Parameters.Add(new MDB.MDBParameter("CoDinhDungDich", data.CoDinhDungDich));
                Command.Parameters.Add(new MDB.MDBParameter("GioCDDD", data.GioCDDD));
                Command.Parameters.Add(new MDB.MDBParameter("NgayCDDD", data.NgayCDDD));
                Command.Parameters.Add(new MDB.MDBParameter("TomTatDauHieu", data.TomTatDauHieu));
                Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhDieuTri", data.QuaTrinhDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("NhanXet", data.NhanXet));
                Command.Parameters.Add(new MDB.MDBParameter("KetQuaLanTruoc", data.KetQuaLanTruoc));
                Command.Parameters.Add(new MDB.MDBParameter("ChuanDoanLamSan", data.ChuanDoanLamSan));
                Command.Parameters.Add(new MDB.MDBParameter("BacSiDieuTri", data.BacSiDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSiDieuTri", data.MaBacSiDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGian", data.ThoiGian));
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
                string sql = "DELETE FROM GiaiPhauBenhSinhThiet WHERE ID = :ID";
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
                GiaiPhauBenhSinhThiet P
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
