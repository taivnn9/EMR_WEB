using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class CamDoanSDTTDT : ThongTinKy
    {
        public CamDoanSDTTDT()
        {
            TableName = "CamDoanSDTTDT";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.GCDCNSDTTDT;
            TenMauPhieu = DanhMucPhieu.GCDCNSDTTDT.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public decimal ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")] 
        public string HoTenBenhNhan { get; set; }
        [MoTaDuLieu("Ngoại kiều")]
        public string NgoaiKieu { get; set; }
        [MoTaDuLieu("Nơi làm việc")]
        public string NoiLamViec { get; set; }
        [MoTaDuLieu("Xác nhận")]
        public int XacNhan { get; set; }
        [MoTaDuLieu("Dân tộc")]
		public string DanToc { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        [MoTaDuLieu("Họ tên người bệnh/đại diện gia đình người bệnh/người giám hộ")]
        public string HoTenNguoiLQ { get; set; }
        [MoTaDuLieu("Nghề nghiệp")]
		public string NgheNghiep { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }
        [MoTaDuLieu("Ngày thực hiện")]
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
    public class CamDoanSDTTDTFunc
    {
        public const string TableName = "CamDoanSDTTDT";
        public const string TablePrimaryKeyName = "ID";
        public static List<CamDoanSDTTDT> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<CamDoanSDTTDT> list = new List<CamDoanSDTTDT>();
            try
            {
                string sql = @"SELECT * FROM CamDoanSDTTDT where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    CamDoanSDTTDT obj = new CamDoanSDTTDT();
                    obj.ID = Common.ConDB_Decimal(DataReader["ID"]);
                    obj.MaQuanLy = Common.ConDB_Decimal(DataReader["MaQuanLy"]);
                    obj.MaBenhNhan = Common.ConDBNull(DataReader["MaBenhNhan"]);
                    obj.HoTenBenhNhan = Common.ConDBNull(DataReader["HoTenBenhNhan"]);
                    obj.NgoaiKieu = Common.ConDBNull(DataReader["NgoaiKieu"]);
                    obj.DanToc = Common.ConDBNull(DataReader["DanToc"]);
                    obj.XacNhan = Common.ConDB_Int(DataReader["XacNhan"]);
                    obj.NoiLamViec = Common.ConDBNull(DataReader["NoiLamViec"]);
                    obj.GioiTinh = Common.ConDBNull(DataReader["GioiTinh"]);
                    obj.Tuoi = Common.ConDBNull(DataReader["Tuoi"]);
                    obj.DiaChi = Common.ConDBNull(DataReader["DiaChi"]);
                    obj.HoTenNguoiLQ = Common.ConDBNull(DataReader["HoTenNguoiLQ"]);
                    obj.NgheNghiep = Common.ConDBNull(DataReader["NgheNghiep"]);
                    obj.Khoa = Common.ConDBNull(DataReader["Khoa"]);
                    obj.MaKhoa = Common.ConDBNull(DataReader["MaKhoa"]);
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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref CamDoanSDTTDT obj)
        {
            try
            {
                string sql = @"INSERT INTO CamDoanSDTTDT
                (
                    MaQuanLy,
                    MaBenhNhan,
                    HoTenBenhNhan,
                    NgoaiKieu,
                    DanToc,XacNhan,NoiLamViec,
                    GioiTinh,
                    Tuoi,
                    DiaChi,
                    HoTenNguoiLQ,
                    NgheNghiep,
                    Khoa,
                    MaKhoa,
                    NgayThucHien,
                    NgayTao,
                    NguoiTao,
                    NgaySua,
                    NguoiSua)  VALUES
                    (
                    :MaQuanLy,
                    :MaBenhNhan,
                    :HoTenBenhNhan,
                    :NgoaiKieu,
                    :DanToc, :XacNhan,:NoiLamViec,
                    :GioiTinh,
                    :Tuoi,
                    :DiaChi,
                    :HoTenNguoiLQ,
                    :NgheNghiep,
                    :Khoa,
                    :MaKhoa,
                    :NgayThucHien,
                    :NgayTao,
                    :NguoiTao,
                    :NgaySua,
                    :NguoiSua
                 )  RETURNING ID INTO :ID";
                if (obj.ID != 0)
                {
                    sql = @"UPDATE CamDoanSDTTDT SET 
                    MaQuanLy=:MaQuanLy,
                    MaBenhNhan=:MaBenhNhan,
                    HoTenBenhNhan=:HoTenBenhNhan,
                    NgoaiKieu=:NgoaiKieu,
                    DanToc=:DanToc,XacNhan=:XacNhan, NoiLamViec=:NoiLamViec,
                    GioiTinh=:GioiTinh,
                    Tuoi=:Tuoi,
                    DiaChi=:DiaChi,
                    HoTenNguoiLQ=:HoTenNguoiLQ,
                    NgheNghiep=:NgheNghiep,
                    Khoa=:Khoa,
                    MaKhoa=:MaKhoa,
                    NgayThucHien=:NgayThucHien,
                    NgaySua=:NgaySua,
                    NguoiSua=:NguoiSua
                    WHERE ID = " + obj.ID;
                }
                MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, MyConnection);
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaQuanLy", obj.MaQuanLy));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", obj.MaBenhNhan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("HoTenBenhNhan", obj.HoTenBenhNhan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgoaiKieu", obj.NgoaiKieu));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DanToc", obj.DanToc));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("XacNhan", obj.XacNhan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NoiLamViec", obj.NoiLamViec));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("GioiTinh", obj.GioiTinh));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Tuoi", obj.Tuoi));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DiaChi", obj.DiaChi));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("HoTenNguoiLQ", obj.HoTenNguoiLQ));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgheNghiep", obj.NgheNghiep));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Khoa", obj.Khoa));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaKhoa", obj.MaKhoa));
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
                string sql = "DELETE FROM CamDoanSDTTDT WHERE ID = :ID";
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
                CamDoanSDTTDT P
                LEFT JOIN HANHCHINHBENHNHAN H ON P.MABENHNHAN = H.MABENHNHAN
                LEFT JOIN THONGTINDIEUTRI T ON P.MAQUANLY = T.MAQUANLY
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "KQ");

            return ds;
        }
    }
}
