using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class GiayCamKetThayDoiTTHSBA : ThongTinKy
    {
        // bắt buộc tạo contructor
        public GiayCamKetThayDoiTTHSBA()
        {
            TableName = "GiayCamKetThayDoiTTHSBA";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.GCKTDTTHSBA;
            TenMauPhieu = DanhMucPhieu.GCKTDTTHSBA.Description();
        }
        // bắt buộc phải có trường, ID, MaQuanLy, MaBenhNhan
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        public string HoTenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public int Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Số CMND/căn cước")]
		public string CMTNhanDanCCCD { get; set; }
        [MoTaDuLieu("Điện thoại")]
		public string DienThoai { get; set; }
        [MoTaDuLieu("Địa chỉ")]
        public string DiaChi { get; set; }
        [MoTaDuLieu("Tên đại diện người bệnh")]
        public string TenDaiDienNguoiBenh { get; set; }
        [MoTaDuLieu("Mối quan hệ với người bệnh")]
        public string MoiQuanHe { get; set; }
        [MoTaDuLieu("Thông tin thay đổi")]
        public string ThongTinThayDoi { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
        public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Người tạo")]
        public string NguoiTao { get; set; }
        public bool Chon { get; set; }
        public string Khoa { get; set; }
    }
    public class GiayCamKetThayDoiTTHSBAFunc
    {
        public const string TableName = "GiayCamKetThayDoiTTHSBA";
        public const string TablePrimaryKeyName = "ID";
        public static List<GiayCamKetThayDoiTTHSBA> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<GiayCamKetThayDoiTTHSBA> list = new List<GiayCamKetThayDoiTTHSBA>();
            try
            {
                string sql = @"SELECT * FROM GiayCamKetThayDoiTTHSBA where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    GiayCamKetThayDoiTTHSBA data = new GiayCamKetThayDoiTTHSBA();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.HoTenBenhNhan = DataReader["HoTenBenhNhan"].ToString();
                    data.Tuoi = Convert.ToInt32(DataReader["Tuoi"].ToString());
                    data.GioiTinh = DataReader["GioiTinh"].ToString();
                    data.CMTNhanDanCCCD = DataReader["CMTNhanDanCCCD"].ToString();
                    data.DienThoai = DataReader["DienThoai"].ToString();
                    data.DiaChi = DataReader["DiaChi"].ToString();
                    data.TenDaiDienNguoiBenh = DataReader["TenDaiDienNguoiBenh"].ToString();
                    data.MoiQuanHe = DataReader["MoiQuanHe"].ToString();
                    data.ThongTinThayDoi = DataReader["ThongTinThayDoi"].ToString();
                    data.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, GiayCamKetThayDoiTTHSBA ketQua)
        {
            try
            {
                string sql = @"INSERT INTO GiayCamKetThayDoiTTHSBA
                (
                    MAQUANLY,
                    MaBenhNhan,
                    HoTenBenhNhan,
                    Tuoi,
                    GioiTinh,
                    CMTNhanDanCCCD,
                    DienThoai,
                    DiaChi,
                    TenDaiDienNguoiBenh,
                    MoiQuanHe,
                    ThongTinThayDoi,
                    NgayTao 
                    )  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :HoTenBenhNhan ,
                    :Tuoi,
                    :GioiTinh,
                    :CMTNhanDanCCCD,
                    :DienThoai,
                    :DiaChi,
                    :TenDaiDienNguoiBenh,
                    :MoiQuanHe,
                    :ThongTinThayDoi,
                    :NgayTao 
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE GiayCamKetThayDoiTTHSBA SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    HoTenBenhNhan =:HoTenBenhNhan ,
                    Tuoi =:Tuoi ,
                    GioiTinh =:GioiTinh ,
                    CMTNhanDanCCCD =:CMTNhanDanCCCD ,
                    DienThoai =:DienThoai ,
                    DiaChi =:DiaChi ,
                    TenDaiDienNguoiBenh =:TenDaiDienNguoiBenh ,
                    MoiQuanHe =:MoiQuanHe ,
                    ThongTinThayDoi =:ThongTinThayDoi ,
                    NgayTao =:NgayTao 
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ketQua.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("HoTenBenhNhan", ketQua.HoTenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("Tuoi", ketQua.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("GioiTinh", ketQua.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("CMTNhanDanCCCD", ketQua.CMTNhanDanCCCD));
                Command.Parameters.Add(new MDB.MDBParameter("DienThoai", ketQua.DienThoai));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", ketQua.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("TenDaiDienNguoiBenh", ketQua.TenDaiDienNguoiBenh));
                Command.Parameters.Add(new MDB.MDBParameter("MoiQuanHe", ketQua.MoiQuanHe));
                Command.Parameters.Add(new MDB.MDBParameter("ThongTinThayDoi", ketQua.ThongTinThayDoi));
                Command.Parameters.Add(new MDB.MDBParameter("NgayTao", ketQua.NgayTao));
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
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool Delete(MDB.MDBConnection MyConnection, long id)
        {
            try
            {
                string sql = "DELETE FROM GiayCamKetThayDoiTTHSBA WHERE ID = :ID";
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
        public static DataSet getDataSet(MDB.MDBConnection MyConnection, string id)
        {
            string sql = @"SELECT
                P.* 
            FROM
                GiayCamKetThayDoiTTHSBA P
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "KQ");

            DateTime NgayTao = Convert.ToDateTime(ds.Tables[0].Rows[0]["NgayTao"]);

            ds.Tables[0].AddColumn("NgayTaoFormat", typeof(string));
            ds.Tables[0].Rows[0]["NgayTaoFormat"] = $"Ngày {NgayTao.Day} tháng {NgayTao.Month} năm {NgayTao.Year}";
            //ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            //ds.Tables[0].AddColumn("Tuoi", typeof(string));
            //ds.Tables[0].AddColumn("NamSinh", typeof(string));
            //ds.Tables[0].AddColumn("GioiTinh", typeof(int));
            ds.Tables[0].AddColumn("SOYTE", typeof(string));
            ds.Tables[0].AddColumn("BENHVIEN", typeof(string));
            ds.Tables[0].AddColumn("KHOA", typeof(string));

            //ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            //ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            //ds.Tables[0].Rows[0]["NamSinh"] = XemBenhAn._HanhChinhBenhNhan.NgaySinh.HasValue ? XemBenhAn._HanhChinhBenhNhan.NgaySinh.Value.Year + "": "";
            //ds.Tables[0].Rows[0]["GioiTinh"] = (int)XemBenhAn._HanhChinhBenhNhan.GioiTinh;
            ds.Tables[0].Rows[0]["SOYTE"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["KHOA"] = XemBenhAn._ThongTinDieuTri.Khoa;

            return ds;
        }
    }
}
