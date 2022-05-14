using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuXNXNHIV : ThongTinKy
    {
        public PhieuXNXNHIV()
        {
            TableName = "PhieuXNXNHIV";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PXNXNHIV;
            TenMauPhieu = DanhMucPhieu.PXNXNHIV.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public decimal ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        public string HoTenBenhNhan { get; set; }
        [MoTaDuLieu("Số chứng minh nhân dân")]
		public string CMND { get; set; }
        public string SDT { get; set; }
        [MoTaDuLieu("Dân tộc")]
		public string DanToc { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Năm sinh")]
		public string NamSinh { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChiHienTai { get; set; }
        [MoTaDuLieu("Nghề nghiệp")]
		public string NgheNghiep { get; set; }
        public string DoiTuong { get; set; }
        public string NguyCo { get; set; }
        public string NguoiTuVan { get; set; }
        public string MaNguoiTuVan { get; set; }
        public DateTime NgayThucHien { get; set; }
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
    public class PhieuXNXNHIVFunc
    {
        public const string TableName = "PhieuXNXNHIV";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuXNXNHIV> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuXNXNHIV> list = new List<PhieuXNXNHIV>();
            try
            {
                string sql = @"SELECT * FROM PhieuXNXNHIV where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuXNXNHIV obj = new PhieuXNXNHIV();
                    obj.ID = Common.ConDB_Decimal(DataReader["ID"]);
                    obj.MaQuanLy = Common.ConDB_Decimal(DataReader["MaQuanLy"]);
                    obj.MaBenhNhan = Common.ConDBNull(DataReader["MaBenhNhan"]);
                    obj.HoTenBenhNhan = Common.ConDBNull(DataReader["HoTenBenhNhan"]);
                    obj.CMND = Common.ConDBNull(DataReader["CMND"]);
                    obj.DanToc = Common.ConDBNull(DataReader["DanToc"]);
                    obj.SDT = Common.ConDBNull(DataReader["SDT"]);
                    obj.GioiTinh = Common.ConDBNull(DataReader["GioiTinh"]);
                    obj.NamSinh = Common.ConDBNull(DataReader["NamSinh"]);
                    obj.DiaChi = Common.ConDBNull(DataReader["DiaChi"]);
                    obj.DiaChiHienTai = Common.ConDBNull(DataReader["DiaChiHienTai"]);
                    obj.NgheNghiep = Common.ConDBNull(DataReader["NgheNghiep"]);
                    obj.DoiTuong = Common.ConDBNull(DataReader["DoiTuong"]);
                    obj.NguyCo = Common.ConDBNull(DataReader["NguyCo"]);
                    obj.NguoiTuVan = Common.ConDBNull(DataReader["NguoiTuVan"]);
                    obj.MaNguoiTuVan = Common.ConDBNull(DataReader["MaNguoiTuVan"]);
                    obj.NgayThucHien = Common.ConDB_DateTime(DataReader["NgayThucHien"]);
                    obj.NgayTao = Common.ConDB_DateTime(DataReader["NgayTao"]);
                    obj.NguoiTao = Common.ConDBNull(DataReader["NguoiTao"]);
                    obj.NgaySua = Common.ConDB_DateTime(DataReader["NgaySua"]);
                    obj.NguoiSua = Common.ConDBNull(DataReader["NguoiSua"]);
                    obj.MaSoKy = DataReader["masokyten"].ToString();
                    obj.DaKy = !string.IsNullOrEmpty(obj.MaSoKy) ? true : false;
                    list.Add(obj);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuXNXNHIV obj)
        {
            try
            {
                string sql = @"INSERT INTO PhieuXNXNHIV
                (
                    MaQuanLy,
                    MaBenhNhan,
                    HoTenBenhNhan,
                    CMND,
                    DanToc,SDT,
                    GioiTinh,
                    NamSinh,
                    DiaChi,
                    DiaChiHienTai,
                    NgheNghiep,
                    DoiTuong,
                    NguyCo,
                    NguoiTuVan,
                    MaNguoiTuVan,
                    NgayThucHien,
                    NgayTao,
                    NguoiTao,
                    NgaySua,
                    NguoiSua)  VALUES
                    (
                    :MaQuanLy,
                    :MaBenhNhan,
                    :HoTenBenhNhan,
                    :CMND,
                    :DanToc, :SDT,
                    :GioiTinh,
                    :NamSinh,
                    :DiaChi,
                    :DiaChiHienTai,
                    :NgheNghiep,
                    :DoiTuong,
                    :NguyCo,
                    :NguoiTuVan,
                    :MaNguoiTuVan,
                    :NgayThucHien,
                    :NgayTao,
                    :NguoiTao,
                    :NgaySua,
                    :NguoiSua
                 )  RETURNING ID INTO :ID";
                if (obj.ID != 0)
                {
                    sql = @"UPDATE PhieuXNXNHIV SET 
                    MaQuanLy=:MaQuanLy,
                    MaBenhNhan=:MaBenhNhan,
                    HoTenBenhNhan=:HoTenBenhNhan,
                    CMND=:CMND,
                    DanToc=:DanToc,SDT=:SDT,
                    GioiTinh=:GioiTinh,
                    NamSinh=:NamSinh,
                    DiaChi=:DiaChi,
                    DiaChiHienTai=:DiaChiHienTai,
                    NgheNghiep=:NgheNghiep,
                    DoiTuong=:DoiTuong,
                    NguyCo=:NguyCo,
                    NguoiTuVan=:NguoiTuVan,
                    MaNguoiTuVan=:MaNguoiTuVan,
                    NgayThucHien=:NgayThucHien,
                    NgaySua=:NgaySua,
                    NguoiSua=:NguoiSua
                    WHERE ID = " + obj.ID;
                }
                MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, MyConnection);
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaQuanLy", obj.MaQuanLy));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", obj.MaBenhNhan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("HoTenBenhNhan", obj.HoTenBenhNhan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CMND", obj.CMND));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DanToc", obj.DanToc));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("SDT", obj.SDT));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("GioiTinh", obj.GioiTinh));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NamSinh", obj.NamSinh));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DiaChi", obj.DiaChi));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DiaChiHienTai", obj.DiaChiHienTai));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgheNghiep", obj.NgheNghiep));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DoiTuong", obj.DoiTuong));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NguyCo", obj.NguyCo));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiTuVan", obj.NguoiTuVan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaNguoiTuVan", obj.MaNguoiTuVan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayThucHien", obj.NgayThucHien));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgaySua", DateTime.Now));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiSua", Common.getUserLogin()));
                if (obj.ID == 0)
                {
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayTao", DateTime.Now));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiTao", Common.getUserLogin()));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ID", obj.ID));
                }
                oracleCommand.BindByName = true;
                int n = oracleCommand.ExecuteNonQuery();
                if (obj.ID == 0)
                {
                    long nextval = Convert.ToInt64((oracleCommand.Parameters["ID"] as MDB.MDBParameter).Value);
                    obj.ID = nextval;
                }
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool delete(MDB.MDBConnection MyConnection, decimal id)
        {
            try
            {
                string sql = "DELETE FROM PhieuXNXNHIV WHERE ID = :ID";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                command.Parameters.Add(new MDB.MDBParameter("ID", id));
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
        public static DataSet getDataSet(MDB.MDBConnection MyConnection, decimal id)
        {
            string sql = @"SELECT
                P.*,
                H.SOYTE,
                H.BENHVIEN,
                T.KHOA,
                T.MaBenhAn 
            FROM
                PhieuXNXNHIV P 
                LEFT JOIN HANHCHINHBENHNHAN H ON P.MABENHNHAN = H.MABENHNHAN
                LEFT JOIN THONGTINDIEUTRI T ON P.MAQUANLY = T.MAQUANLY
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            adt.Fill(ds);
            return ds;
        }
    }
}
