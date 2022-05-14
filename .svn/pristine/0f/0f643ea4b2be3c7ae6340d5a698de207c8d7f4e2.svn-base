using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class GCNPT : ThongTinKy
    {
        public GCNPT()
        {
            TableName = "GCNPT";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.H2_GCNPT;
            TenMauPhieu = DanhMucPhieu.H2_GCNPT.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public decimal ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        public string CachPT { get; set; }
        public string GayMe { get; set; }
        public DateTime? NgayVaoVien { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        public DateTime? NgayRaVien { get; set; }
        public DateTime? NgayPhauThuat { get; set; }
        public string PTV { get; set; }
        public string MaPTV { get; set; }
        public string GiamDoc { get; set; }
        public string MaGiamDoc { get; set; }
        [MoTaDuLieu("Nhóm máu")]
		public string NhomMau { get; set; }
        public string YeuToRh { get; set; }
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
    public class GCNPTFunc
    {
        public const string TableName = "GCNPT";
        public const string TablePrimaryKeyName = "ID";
        public static List<GCNPT> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<GCNPT> list = new List<GCNPT>();
            try
            {
                string sql = @"SELECT * FROM GCNPT where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    GCNPT obj = new GCNPT();
                    obj.ID = Common.ConDB_Decimal(DataReader["ID"]);
                    obj.MaQuanLy = Common.ConDB_Decimal(DataReader["MaQuanLy"]);
                    obj.MaBenhNhan = Common.ConDBNull(DataReader["MaBenhNhan"]);
                    obj.CachPT = Common.ConDBNull(DataReader["CachPT"]);
                    obj.GayMe = Common.ConDBNull(DataReader["GayMe"]);
                    obj.Khoa = Common.ConDBNull(DataReader["Khoa"]);
                    obj.NgayVaoVien = Common.ConDB_DateTimeNull(DataReader["NgayVaoVien"]);
                    obj.NgayRaVien = Common.ConDB_DateTimeNull(DataReader["NgayRaVien"]);
                    obj.NgayPhauThuat = Common.ConDB_DateTimeNull(DataReader["NgayPhauThuat"]);
                    obj.PTV = Common.ConDBNull(DataReader["PTV"]);
                    obj.MaPTV = Common.ConDBNull(DataReader["MaPTV"]);
                    obj.GiamDoc = Common.ConDBNull(DataReader["GiamDoc"]);
                    obj.MaGiamDoc = Common.ConDBNull(DataReader["MaGiamDoc"]);
                    obj.NhomMau = Common.ConDBNull(DataReader["NhomMau"]);
                    obj.YeuToRh = Common.ConDBNull(DataReader["YeuToRh"]);
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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref GCNPT obj)
        {
            try
            {
                string sql = @"INSERT INTO GCNPT
                (
                    MaQuanLy,
                    MaBenhNhan,
                    CachPT,
                    GayMe,
                    Khoa,NgayVaoVien,
                    NgayRaVien,
                    MaKhoa,NgayPhauThuat,PTV,MaPTV,GiamDoc,MaGiamDoc,NhomMau,YeuToRh, 
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
                    :CachPT,
                    :GayMe,
                    :Khoa, :NgayVaoVien,
                    :NgayRaVien,
                    :MaKhoa,:NgayPhauThuat,:PTV,:MaPTV,:GiamDoc,:MaGiamDoc, :NhomMau, :YeuToRh, 
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
                    sql = @"UPDATE GCNPT SET 
                    MaQuanLy=:MaQuanLy,
                    MaBenhNhan=:MaBenhNhan,
                    CachPT=:CachPT,
                    GayMe=:GayMe,
                    Khoa=:Khoa,NgayVaoVien=:NgayVaoVien,
                    NgayRaVien=:NgayRaVien,
                    MaKhoa=:MaKhoa,NgayPhauThuat =: NgayPhauThuat,PTV =:PTV,MaPTV =:MaPTV,GiamDoc =:GiamDoc,MaGiamDoc =:MaGiamDoc,NhomMau =:NhomMau, YeuToRh =:YeuToRh,
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
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CachPT", obj.CachPT));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("GayMe", obj.GayMe));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Khoa", obj.Khoa));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayVaoVien", obj.NgayVaoVien));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayRaVien", obj.NgayRaVien));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaKhoa", obj.MaKhoa));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayPhauThuat", obj.NgayPhauThuat));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("PTV", obj.PTV));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaPTV", obj.MaPTV));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("GiamDoc", obj.GiamDoc));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaGiamDoc", obj.MaGiamDoc));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NhomMau", obj.NhomMau));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("YeuToRh", obj.YeuToRh));
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
                string sql = "DELETE FROM GCNPT WHERE ID = :ID";
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
            string sql2 = @"SELECT D.*, '' SoYTe, '' SoLuuTru, '' BenhVien , '' NamSinh, '' TenBenhNhan
                            , '' GioiTinh
            FROM
                GCNPT D
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
                ds.Tables[0].Rows[0]["SoLuuTru"] = XemBenhAn._ThongTinDieuTri.SoLuuTru;
                ds.Tables[0].Rows[0]["BenhVien"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
                ds.Tables[0].Rows[0]["NamSinh"] = (XemBenhAn._HanhChinhBenhNhan.NgaySinh.HasValue ? XemBenhAn._HanhChinhBenhNhan.NgaySinh.Value.ToString("dd/MM/yyyy") : "");
                ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            }
            return ds;
        }
    }
}
