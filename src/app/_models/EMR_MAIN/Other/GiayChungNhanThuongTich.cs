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
    public class GiayChungNhanThuongTich : ThongTinKy
    {
        public GiayChungNhanThuongTich()
        {
            TableName = "GiayChungNhanThuongTich";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.GCNTT;
            TenMauPhieu = DanhMucPhieu.GCNTT.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }

        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }

        public string ChungNhan { get; set; }
        public string GiamDoc { get; set; }
        public string MaGiamDoc { get; set; }
        [MoTaDuLieu("Trưởng khoa")]
		public string TruongKhoa { get; set; }
        [MoTaDuLieu("Mã trưởng khoa")]
		public string MaTruongKhoa { get; set; }
        [MoTaDuLieu("Họ tên bác sỹ")]
		public string BacSi { get; set; }
        [MoTaDuLieu("Mã bác sỹ")]
		public string MaBacSi { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        public DateTime? NgaySinh { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Nghề nghiệp")]
		public string NgheNghiep { get; set; }
        public string NoiLamViec { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        [MoTaDuLieu("Số chứng minh nhân dân")]
		public string CMND { get; set; }
        [MoTaDuLieu("Nơi cấp chứng minh nhân dân")]
		public string NoiCap { get; set; }
        public DateTime? NgayCap { get; set; }
        public DateTime? NgayVaoVien { get; set; }
        public DateTime? NgayVaoVien_Gio { get; set; }
        public DateTime? NgayRaVien { get; set; }
        public DateTime? NgayRaVien_Gio { get; set; }
        public string LyDoVaoVien { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public string DieuTri { get; set; }
        public string ThuongTichVaoVien { get; set; }
        public string ThuongTichRaVien { get; set; }
        public DateTime? NgayTao { get; set; }

        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        public DateTime? NgaySua { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }

        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
    }
    
    public class GiayChungNhanThuongTichFunc
    {
        public const string TableName = "GiayChungNhanThuongTich";
        public const string TablePrimaryKeyName = "ID";
        public static List<GiayChungNhanThuongTich> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<GiayChungNhanThuongTich> list = new List<GiayChungNhanThuongTich>();
            try
            {
                string sql = @"SELECT * FROM GiayChungNhanThuongTich where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    GiayChungNhanThuongTich data = new GiayChungNhanThuongTich();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.ChungNhan = DataReader["ChungNhan"].ToString();
                    data.GiamDoc = DataReader["GiamDoc"].ToString();
                    data.MaGiamDoc = DataReader["MaGiamDoc"].ToString();
                    data.TruongKhoa = DataReader["TruongKhoa"].ToString();
                    data.MaTruongKhoa = DataReader["MaTruongKhoa"].ToString();
                    data.BacSi = DataReader["BacSi"].ToString();
                    data.MaBacSi = DataReader["MaBacSi"].ToString();
                    data.TenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.NgaySinh = XemBenhAn._HanhChinhBenhNhan.NgaySinh;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.NgheNghiep = DataReader["NgheNghiep"].ToString();
                    data.NoiLamViec = DataReader["NoiLamViec"].ToString();
                    data.DiaChi = DataReader["DiaChi"].ToString();
                    data.CMND = DataReader["CMND"].ToString();
                    data.NoiCap = DataReader["NoiCap"].ToString();
                    data.NgayCap = DataReader["NgayCap"] == DBNull.Value ? (DateTime?)null : DataReader.GetDate("NgayCap");
                    data.NgayVaoVien = DataReader["NgayVaoVien"] == DBNull.Value ? (DateTime?)null : DataReader.GetDate("NgayVaoVien");
                    data.NgayVaoVien_Gio = data.NgayVaoVien;
                    data.NgayRaVien = DataReader["NgayRaVien"] == DBNull.Value ? (DateTime?)null : DataReader.GetDate("NgayRaVien");
                    data.NgayRaVien_Gio = data.NgayRaVien;

                    data.LyDoVaoVien = DataReader["LyDoVaoVien"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.DieuTri = DataReader["DieuTri"].ToString();
                    data.ThuongTichVaoVien = DataReader["ThuongTichVaoVien"].ToString();
                    data.ThuongTichRaVien = DataReader["ThuongTichRaVien"].ToString();

                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;

                    data.NgayTao = DataReader["NgayTao"] == DBNull.Value ? (DateTime?)null : DataReader.GetDate("NgayTao");
                    data.NguoiTao = DataReader["NguoiTao"].ToString();
                    data.NguoiSua = DataReader["NguoiSua"].ToString();
                    data.NgaySua = DataReader["NgaySua"] == DBNull.Value ? (DateTime?)null : DataReader.GetDate("NgaySua");


                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref GiayChungNhanThuongTich bangKiem)
        {
            try
            {
                string sql = @"INSERT INTO GiayChungNhanThuongTich
                (
                    MAQUANLY,
                    ChungNhan,
                    GiamDoc,
                    MaGiamDoc,
                    TruongKhoa,
                    MaTruongKhoa,
                    BacSi,
                    MaBacSi,
                    NgheNghiep,
                    NoiLamViec,
                    DiaChi,
                    CMND,
                    NgayCap,
                    NoiCap,
                    NgayVaoVien,
                    NgayRaVien,
                    LyDoVaoVien,
                    ChanDoan,
                    DieuTri,
                    ThuongTichVaoVien,
                    ThuongTichRaVien,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :ChungNhan,
                    :GiamDoc,
                    :MaGiamDoc,
                    :TruongKhoa,
                    :MaTruongKhoa,
                    :BacSi,
                    :MaBacSi,
                    :NgheNghiep,
                    :NoiLamViec,
                    :DiaChi,
                    :CMND,
                    :NgayCap,
                    :NoiCap,
                    :NgayVaoVien,
                    :NgayRaVien,
                    :LyDoVaoVien,
                    :ChanDoan,
                    :DieuTri,
                    :ThuongTichVaoVien,
                    :ThuongTichRaVien,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (bangKiem.ID != 0)
                {
                    sql = @"UPDATE GiayChungNhanThuongTich SET 
                    MAQUANLY = :MAQUANLY,
                    ChungNhan = :ChungNhan,
                    GiamDoc = :GiamDoc,
                    MaGiamDoc = :MaGiamDoc,
                    TruongKhoa = :TruongKhoa,
                    MaTruongKhoa = :MaTruongKhoa,
                    BacSi = :BacSi,
                    MaBacSi = :MaBacSi,
                    NgheNghiep = :NgheNghiep,
                    NoiLamViec = :NoiLamViec,
                    DiaChi = :DiaChi,
                    CMND = :CMND,
                    NgayCap = :NgayCap,
                    NoiCap = :NoiCap,
                    NgayVaoVien = :NgayVaoVien,
                    NgayRaVien = :NgayRaVien,
                    LyDoVaoVien = :LyDoVaoVien,
                    ChanDoan = :ChanDoan,
                    DieuTri = :DieuTri,
                    ThuongTichVaoVien = :ThuongTichVaoVien,
                    ThuongTichRaVien = :ThuongTichRaVien,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + bangKiem.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangKiem.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("ChungNhan", bangKiem.ChungNhan));
                Command.Parameters.Add(new MDB.MDBParameter("GiamDoc", bangKiem.GiamDoc));
                Command.Parameters.Add(new MDB.MDBParameter("MaGiamDoc", bangKiem.MaGiamDoc));
                Command.Parameters.Add(new MDB.MDBParameter("TruongKhoa", bangKiem.TruongKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaTruongKhoa", bangKiem.MaTruongKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("BacSi", bangKiem.BacSi));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSi", bangKiem.MaBacSi));
                Command.Parameters.Add(new MDB.MDBParameter("NgheNghiep", bangKiem.NgheNghiep));
                Command.Parameters.Add(new MDB.MDBParameter("NoiLamViec", bangKiem.NoiLamViec));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", bangKiem.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("CMND", bangKiem.CMND));
                Command.Parameters.Add(new MDB.MDBParameter("NgayCap", bangKiem.NgayCap));
                Command.Parameters.Add(new MDB.MDBParameter("NoiCap", bangKiem.NoiCap));

                DateTime? NgayVaoVien = bangKiem.NgayVaoVien.HasValue ? bangKiem.NgayVaoVien.Value.Date : (DateTime?)null;
                var NgayVaoVienFull = NgayVaoVien;
                if (NgayVaoVien != null)
                {
                    var NgayVaoVien_Gio = bangKiem.NgayVaoVien_Gio.HasValue ? bangKiem.NgayVaoVien_Gio.Value.TimeOfDay : new TimeSpan(0, 0, 0);
                    NgayVaoVienFull = NgayVaoVien + NgayVaoVien_Gio;
                }

                Command.Parameters.Add(new MDB.MDBParameter("NgayVaoVien", NgayVaoVienFull));

                DateTime? NgayRaVien = bangKiem.NgayRaVien.HasValue ? bangKiem.NgayRaVien.Value.Date : (DateTime?)null;
                var NgayRaVienFull = NgayRaVien;
                if (NgayRaVien != null)
                {
                    var NgayRaVien_Gio = bangKiem.NgayRaVien_Gio.HasValue ? bangKiem.NgayRaVien_Gio.Value.TimeOfDay : new TimeSpan(0, 0, 0);
                    NgayRaVienFull = NgayRaVien + NgayRaVien_Gio;
                }

                Command.Parameters.Add(new MDB.MDBParameter("NgayRaVien", NgayRaVienFull));

                Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", bangKiem.LyDoVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", bangKiem.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri", bangKiem.DieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("ThuongTichVaoVien", bangKiem.ThuongTichVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("ThuongTichRaVien", bangKiem.ThuongTichRaVien));

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
                string sql = "DELETE FROM GiayChungNhanThuongTich WHERE ID = :ID";
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
                *
            FROM
                GiayChungNhanThuongTich B
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);

            var ds = new DataSet();

            adt.Fill(ds, "TB");
            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("NgaySinh", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(string));
            ds.Tables[0].AddColumn("Khoa", typeof(string));
            ds.Tables[0].AddColumn("SoYTe", typeof(string));
            ds.Tables[0].AddColumn("BenhVien", typeof(string));
            ds.Tables[0].AddColumn("SoVaoVien", typeof(string));
            ds.Tables[0].AddColumn("ThoiGian", typeof(DateTime));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["SoVaoVien"] = XemBenhAn._ThongTinDieuTri.SoNhapVien;
            ds.Tables[0].Rows[0]["Khoa"] = XemBenhAn._ThongTinDieuTri.Khoa;
            ds.Tables[0].Rows[0]["NgaySinh"] = XemBenhAn._HanhChinhBenhNhan.NgaySinh.HasValue ? XemBenhAn._HanhChinhBenhNhan.NgaySinh.Value.ToString("dd/MM/yyyy"):"";
            ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            ds.Tables[0].Rows[0]["SoYTe"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BenhVien"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["ThoiGian"] = DateTime.Now;

            return ds;
        }
    }
}
