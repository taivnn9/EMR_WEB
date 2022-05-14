using EMR.KyDienTu;
using System;
using System.Collections.Generic;
using System.Data;
using PMS.Access;
namespace EMR_MAIN.DATABASE.Other
{
    public class BangKiemTranhNhamLanBenhNhan : ThongTinKy
    {
        public BangKiemTranhNhamLanBenhNhan()
        {
            TableName = "BangKiemTranhNhamLanBN";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BKTNLBN;
            TenMauPhieu = DanhMucPhieu.BKTNLBN.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        public string Ten1 { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi1 { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh1 { get; set; }
        public string Ten2 { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi2 { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh2 { get; set; }
        public string Ten3 { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi3 { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh3 { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }
        [MoTaDuLieu("Số bệnh án")]
		public string SoBenhAn { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuong { get; set; }
        [MoTaDuLieu("Mã điều dưỡng")]
		public string MaDieuDuong { get; set; }
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
    public class BangKiemTranhNhamLanBenhNhanFunc
    {
        public const string TableName = "BangKiemTranhNhamLanBN";
        public const string TablePrimaryKeyName = "ID";
        public static List<BangKiemTranhNhamLanBenhNhan> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BangKiemTranhNhamLanBenhNhan> list = new List<BangKiemTranhNhamLanBenhNhan>();
            try
            {
                string sql = @"SELECT * FROM BangKiemTranhNhamLanBN where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    BangKiemTranhNhamLanBenhNhan data = new BangKiemTranhNhamLanBenhNhan();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.Ten1 = DataReader["Ten1"].ToString();
                    data.Tuoi1 = DataReader["Tuoi1"].ToString();
                    data.GioiTinh1 = DataReader["GioiTinh1"].ToString();

                    data.Ten1 = DataReader["Ten1"].ToString();
                    data.Tuoi1 = DataReader["Tuoi1"].ToString();
                    data.GioiTinh1 = DataReader["GioiTinh1"].ToString();
                    data.Ten2 = DataReader["Ten2"].ToString();
                    data.Tuoi2 = DataReader["Tuoi2"].ToString();
                    data.GioiTinh2 = DataReader["GioiTinh2"].ToString();
                    data.Ten3 = DataReader["Ten3"].ToString();
                    data.Tuoi3 = DataReader["Tuoi3"].ToString();
                    data.GioiTinh3 = DataReader["GioiTinh3"].ToString();

                    data.Khoa = DataReader["Khoa"].ToString();
                    data.MaKhoa = DataReader["MaKhoa"].ToString();
                    data.SoBenhAn = DataReader["SoBenhAn"].ToString();
                    data.DiaChi = DataReader["DiaChi"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.DieuDuong = DataReader["DieuDuong"].ToString();
                    data.MaDieuDuong = DataReader["MaDieuDuong"].ToString();

                    data.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                    data.NguoiTao = DataReader["NguoiTao"].ToString();
                    data.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);
                    data.NguoiSua = DataReader["NguoiSua"].ToString();

                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;
                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BangKiemTranhNhamLanBenhNhan bangKiem)
        {
            try
            {
                string sql = @"INSERT INTO BangKiemTranhNhamLanBN
                (
                    MAQUANLY,
                    MaBenhNhan,
                    Ten1,
                    Tuoi1,
                    GioiTinh1,
                    Ten2,
                    Tuoi2,
                    GioiTinh2,
                    Ten3,
                    Tuoi3,
                    GioiTinh3,
                    Khoa,
                    MaKhoa,
                    SoBenhAn,
                    DiaChi,
                    ChanDoan,
                    DieuDuong,
                    MaDieuDuong,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :Ten1,
                    :Tuoi1,
                    :GioiTinh1,
                    :Ten2,
                    :Tuoi2,
                    :GioiTinh2,
                    :Ten3,
                    :Tuoi3,
                    :GioiTinh3,
                    :Khoa,
                    :MaKhoa,
                    :SoBenhAn,
                    :DiaChi,
                    :ChanDoan,
                    :DieuDuong,
                    :MaDieuDuong,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (bangKiem.ID != 0)
                {
                    sql = @"UPDATE BangKiemTranhNhamLanBenhNhan SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    Ten1 = :Ten1,
                    Tuoi1 = Tuoi1,
                    GioiTinh1 = :GioiTinh1,
                    Ten2 = :Ten2,
                    Tuoi2 = :Tuoi2,
                    GioiTinh2 = :GioiTinh2,
                    Ten3 = Ten3,
                    Tuoi3 = :Tuoi3,
                    GioiTinh3 = :GioiTinh3,
                    Khoa = :Khoa,
                    MaKhoa = :MaKhoa,
                    SoBenhAn = :SoBenhAn,
                    DiaChi = :DiaChi,
                    ChanDoan = :ChanDoan,
                    DieuDuong = :DieuDuong,
                    MaDieuDuong = :MaDieuDuong,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + bangKiem.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangKiem.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", bangKiem.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("Ten1", bangKiem.Ten1));
                Command.Parameters.Add(new MDB.MDBParameter("Tuoi1", bangKiem.Tuoi1));
                Command.Parameters.Add(new MDB.MDBParameter("GioiTinh1", bangKiem.GioiTinh1));
                Command.Parameters.Add(new MDB.MDBParameter("Ten2", bangKiem.Ten2));
                Command.Parameters.Add(new MDB.MDBParameter("Tuoi2", bangKiem.Tuoi2));
                Command.Parameters.Add(new MDB.MDBParameter("GioiTinh2", bangKiem.GioiTinh2));
                Command.Parameters.Add(new MDB.MDBParameter("Ten3", bangKiem.Ten3));
                Command.Parameters.Add(new MDB.MDBParameter("Tuoi3", bangKiem.Tuoi3));
                Command.Parameters.Add(new MDB.MDBParameter("GioiTinh3", bangKiem.GioiTinh3));

                Command.Parameters.Add(new MDB.MDBParameter("Khoa", bangKiem.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaKhoa", bangKiem.MaKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("SoBenhAn", bangKiem.SoBenhAn));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", bangKiem.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", bangKiem.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuong", bangKiem.DieuDuong));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuong", bangKiem.MaDieuDuong));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", bangKiem.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", bangKiem.NgaySua));
                if (bangKiem.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", bangKiem.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", bangKiem.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", bangKiem.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (bangKiem.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    bangKiem.ID = nextval;
                }
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool delete(MDB.MDBConnection MyConnection, long id)
        {
            try
            {
                string sql = "DELETE FROM BangKiemTranhNhamLanBN WHERE ID = :ID";
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
        public static DataSet getDataSet(MDB.MDBConnection MyConnection, long id)
        {
            string sql = @"SELECT
                B.*,
                H.SOYTE,
                H.BENHVIEN
            FROM
                BangKiemTranhNhamLanBN B
                LEFT JOIN HANHCHINHBENHNHAN H ON B.MABENHNHAN = H.MABENHNHAN
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            adt.Fill(ds, "BK");

            return ds;
        }
    }
}
