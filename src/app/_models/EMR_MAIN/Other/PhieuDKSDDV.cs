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
    public class PhieuDKSDDV : ThongTinKy
    {
        public PhieuDKSDDV()
        {
            TableName = "PhieuDKSDDV";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PDKSDDV;
            TenMauPhieu = DanhMucPhieu.PDKSDDV.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Tên bệnh nhân")]
        public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
        public string Tuoi { get; set; }
        [MoTaDuLieu("Năm sinh bệnh nhân")]
        public string NamSinh { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string Khoa { get; set; }
        public string MaKhoa { get; set; }
        public string MaDieuTri { get; set; }
        [MoTaDuLieu("Thông tin người đăng ký")]
        public int NguoiDangKy { get; set; }
        public string MoiQuanHe { get; set; }
        public string HoTenNDK { get; set; }
        public string CMNDNDK { get; set; }
        public DateTime NgayCap { get; set; }
        public string DiaChiDK { get; set; }
        public string SDT { get; set; }
        [MoTaDuLieu("Điểu khoản đăng ký sử dụng dịch vụ khám chữa bệnh")]
        public string TenDichVu { get; set; }
        public string NDDichVu { get; set; }
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

    public class PhieuDKSDDVFunc
    {
        public const string TableName = "PhieuDKSDDV";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuDKSDDV> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuDKSDDV> list = new List<PhieuDKSDDV>();
            try
            {
                string sql = @"SELECT * FROM PhieuDKSDDV where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuDKSDDV data = new PhieuDKSDDV();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.TenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.NamSinh = XemBenhAn._HanhChinhBenhNhan.NgaySinh.ToString();
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.DiaChi = Common.ConDBNull(DataReader["DiaChi"]);
                    data.Khoa = Common.ConDBNull(DataReader["Khoa"]);
                    data.MaKhoa = Common.ConDBNull(DataReader["MaKhoa"]);
                    data.MaDieuTri = Common.ConDBNull(DataReader["MaDieuTri"]);
                    data.NguoiDangKy = Common.ConDB_Int(DataReader["NguoiDangKy"]);
                    data.MoiQuanHe = Common.ConDBNull(DataReader["MoiQuanHe"]);
                    data.HoTenNDK = Common.ConDBNull(DataReader["HoTenNDK"]);
                    data.CMNDNDK = Common.ConDBNull(DataReader["CMNDNDK"]);
                    data.NgayCap = Common.ConDB_DateTime(DataReader["NgayCap"]);
                    data.DiaChiDK = Common.ConDBNull(DataReader["DiaChiDK"]);
                    data.SDT = Common.ConDBNull(DataReader["SDT"]);
                    data.TenDichVu = Common.ConDBNull(DataReader["TenDichVu"]);
                    data.NDDichVu = Common.ConDBNull(DataReader["NDDichVu"]);
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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuDKSDDV data)
        {
            try
            {
                string sql = @"INSERT INTO PhieuDKSDDV
                (
                    MaQuanLy,
                    MaBenhNhan,
                    Tuoi,
                    NamSinh,
                    GioiTinh,
                    DiaChi,
                    Khoa,
                    MaKhoa,
                    MaDieuTri,
                    NguoiDangKy,
                    MoiQuanHe,
                    HoTenNDK,
                    CMNDNDK,
                    NgayCap,
                    DiaChiDK,
                    SDT,
                    TenDichVu,
                    NDDichVu,  
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
                    :MaQuanLy,
                    :MaBenhNhan,
                    :Tuoi,
                    :NamSinh,
                    :GioiTinh,
                    :DiaChi,
                    :Khoa,
                    :MaKhoa,
                    :MaDieuTri,
                    :NguoiDangKy,
                    :MoiQuanHe,
                    :HoTenNDK,
                    :CMNDNDK,
                    :NgayCap,
                    :DiaChiDK,
                    :SDT,
                    :TenDichVu,
                    :NDDichVu,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (data.ID != 0)
                {
                    sql = @"UPDATE PhieuDKSDDV SET 
                    MaQuanLy=:MaQuanLy,
                    MaBenhNhan=:MaBenhNhan,
                    Tuoi=:Tuoi,
                    NamSinh=:NamSinh,
                    GioiTinh=:GioiTinh,
                    DiaChi=:DiaChi,
                    Khoa=:Khoa,
                    MaKhoa=:MaKhoa,
                    MaDieuTri=:MaDieuTri,
                    NguoiDangKy=:NguoiDangKy,
                    MoiQuanHe=:MoiQuanHe,
                    HoTenNDK=:HoTenNDK,
                    CMNDNDK=:CMNDNDK,
                    NgayCap=:NgayCap,
                    DiaChiDK=:DiaChiDK,
                    SDT=:SDT,
                    TenDichVu=:TenDichVu,
                    NDDichVu=:NDDichVu,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + data.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", data.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", data.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("Tuoi", data.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("NamSinh", data.NamSinh));
                Command.Parameters.Add(new MDB.MDBParameter("GioiTinh", data.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", data.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa", data.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaKhoa", data.MaKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuTri", data.MaDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiDangKy", data.NguoiDangKy));
                Command.Parameters.Add(new MDB.MDBParameter("MoiQuanHe", data.MoiQuanHe));
                Command.Parameters.Add(new MDB.MDBParameter("HoTenNDK", data.HoTenNDK));
                Command.Parameters.Add(new MDB.MDBParameter("CMNDNDK", data.CMNDNDK));
                Command.Parameters.Add(new MDB.MDBParameter("NgayCap", data.NgayCap));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChiDK", data.DiaChiDK));
                Command.Parameters.Add(new MDB.MDBParameter("SDT", data.SDT));
                Command.Parameters.Add(new MDB.MDBParameter("TenDichVu", data.TenDichVu));
                Command.Parameters.Add(new MDB.MDBParameter("NDDichVu", data.NDDichVu));
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
                string sql = "DELETE FROM PhieuDKSDDV WHERE ID = :ID";
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
                PhieuDKSDDV P
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
