using EMR.KyDienTu;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class TCCPUCH : ThongTinKy
    {
        public TCCPUCH()
        {
            TableName = "TCCPUCH";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.TCCPUCH;
            TenMauPhieu = DanhMucPhieu.TCCPUCH.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public decimal ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        public string MoTaNghiNgo { get; set; }
        [MoTaDuLieu("Số chứng minh nhân dân")]
		public string CMND { get; set; }
        public string MoTaPhanUng { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        public DateTime? NgayCap { get; set; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        [MoTaDuLieu("Trưởng khoa")]
		public string TruongKhoa { get; set; }
        [MoTaDuLieu("Mã trưởng khoa")]
		public string MaTruongKhoa { get; set; }
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
        public string NamSinh
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.NgaySinh.HasValue ? XemBenhAn._HanhChinhBenhNhan.NgaySinh.Value.ToString("dd/MM/yyyy") : "";
            }
        }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            }
        }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            }
        }
    }
    public class TCCPUCHFunc
    {
        public const string TableName = "TCCPUCH";
        public const string TablePrimaryKeyName = "ID";
        public static List<TCCPUCH> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<TCCPUCH> list = new List<TCCPUCH>();
            try
            {
                string sql = @"SELECT * FROM TCCPUCH where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    TCCPUCH obj = new TCCPUCH();
                    obj.ID = Common.ConDB_Decimal(DataReader["ID"]);
                    obj.MaQuanLy = Common.ConDB_Decimal(DataReader["MaQuanLy"]);
                    obj.MaBenhNhan = Common.ConDBNull(DataReader["MaBenhNhan"]);
                    obj.MoTaNghiNgo = Common.ConDBNull(DataReader["MoTaNghiNgo"]);
                    obj.CMND = Common.ConDBNull(DataReader["CMND"]);
                    obj.Khoa = Common.ConDBNull(DataReader["Khoa"]);
                    obj.MoTaPhanUng = Common.ConDBNull(DataReader["MoTaPhanUng"]);
                    obj.NgayCap = Common.ConDB_DateTimeNull(DataReader["NgayCap"]);
                    obj.MaKhoa = Common.ConDBNull(DataReader["MaKhoa"]);
                    obj.DiaChi = Common.ConDBNull(DataReader["DiaChi"]);
                    obj.TruongKhoa = Common.ConDBNull(DataReader["TruongKhoa"]);
                    obj.MaTruongKhoa = Common.ConDBNull(DataReader["MaTruongKhoa"]);
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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref TCCPUCH obj)
        {
            try
            {
                string sql = @"INSERT INTO TCCPUCH
                (
                    MaQuanLy,
                    MaBenhNhan,
                    MoTaNghiNgo,
                    CMND,
                    Khoa,MoTaPhanUng,
                    NgayCap,
                    MaKhoa,
                    DiaChi,
                    TruongKhoa,
                    MaTruongKhoa,
                    NgayTao,
                    NguoiTao,
                    NgaySua,
                    NguoiSua)  VALUES
                    (
                    :MaQuanLy,
                    :MaBenhNhan,
                    :MoTaNghiNgo,
                    :CMND,
                    :Khoa, :MoTaPhanUng,
                    :NgayCap,
                    :MaKhoa,
                    :DiaChi,
                    :TruongKhoa,
                    :MaTruongKhoa,
                    :NgayTao,
                    :NguoiTao,
                    :NgaySua,
                    :NguoiSua
                 )  RETURNING ID INTO :ID";
                if (obj.ID != 0)
                {
                    sql = @"UPDATE TCCPUCH SET 
                    MaQuanLy=:MaQuanLy,
                    MaBenhNhan=:MaBenhNhan,
                    MoTaNghiNgo=:MoTaNghiNgo,
                    CMND=:CMND,
                    Khoa=:Khoa,MoTaPhanUng=:MoTaPhanUng,
                    NgayCap=:NgayCap,
                    MaKhoa=:MaKhoa,
                    DiaChi=:DiaChi,
                    TruongKhoa=:TruongKhoa,
                    MaTruongKhoa=:MaTruongKhoa,
                    NgaySua=:NgaySua,
                    NguoiSua=:NguoiSua
                    WHERE ID = " + obj.ID;
                }
                MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, MyConnection);
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaQuanLy", obj.MaQuanLy));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", obj.MaBenhNhan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MoTaNghiNgo", obj.MoTaNghiNgo));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CMND", obj.CMND));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Khoa", obj.Khoa));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MoTaPhanUng", obj.MoTaPhanUng));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayCap", obj.NgayCap));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaKhoa", obj.MaKhoa));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DiaChi", obj.DiaChi));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TruongKhoa", obj.TruongKhoa));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaTruongKhoa", obj.MaTruongKhoa));
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
                string sql = "DELETE FROM TCCPUCH WHERE ID = :ID";
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
            string sql2 = @"SELECT D.*, '' SoYTe, '' BenhVien , '' NamSinh, '' TenBenhNhan
                            , '' GioiTinh
            FROM
                TCCPUCH D
            WHERE
                ID = :ID";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql2, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("ID", id));

            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            adt.Fill(ds);

            if (ds != null || ds.Tables[0].Rows.Count > 0)
            {
                ds.Tables[0].Rows[0]["SoYTe"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
                ds.Tables[0].Rows[0]["BenhVien"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
                ds.Tables[0].Rows[0]["NamSinh"] = (XemBenhAn._HanhChinhBenhNhan.NgaySinh.HasValue ? XemBenhAn._HanhChinhBenhNhan.NgaySinh.Value.ToString("dd/MM/yyyy") : "");
                ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            }
            return ds;
        }
    }
}
