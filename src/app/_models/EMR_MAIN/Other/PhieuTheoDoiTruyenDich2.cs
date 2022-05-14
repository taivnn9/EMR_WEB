using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuChiTietTruyenDich2 : ThongTinKy
    {
        public PhieuChiTietTruyenDich2()
        {
            TableName = "PhieuChiTietTruyenDich2";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PTDTD;
            TenMauPhieu = DanhMucPhieu.PTDTD.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }
        public string SoVaoVien { get; set; }
        public string HoTenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Giường")]
		public string Giuong { get; set; }
        [MoTaDuLieu("Buồng")]
		public string Buong { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public ObservableCollection<PhieuChiTietTruyenDich2_ChiTiet> ChiTiets { get; set; }
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
    public class PhieuChiTietTruyenDich2_ChiTiet : ThongTinKy
    {
        public PhieuChiTietTruyenDich2_ChiTiet()
        {
            TableName = "PhieuTDTD2_CT";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PTDTD;
            TenMauPhieu = DanhMucPhieu.PTDTD.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã định danh")]
		public long ID_Phieu { get; set; }
        [MoTaDuLieu("Ngày tháng")]
		public DateTime NgayThang { get; set; }
        public string TenDichTruyen { get; set; }
        public string SoLuong { get; set; }
        public string LoSanXuat { get; set; }
        public string TocDo { get; set; }
        public string DonVi { get; set; }
        public string TiLeQuyDoi { get; set; }
        public DateTime? ThoiGianBatDau { get; set; }
        public DateTime? ThoiGianKetThuc { get; set; }
        public string TenThuocPha { get; set; }
        public string LoThuocPha { get; set; }
        public string GhiChu { get; set; }
        public string BacSyChiDinh { get; set; }
        public string MaBacSyChiDinh { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuong { get; set; }
        [MoTaDuLieu("Mã điều dưỡng")]
		public string MaDieuDuong { get; set; }
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
    }
    public class PhieuChiTietTruyenDich2Func
    {
        public const string TableName = "PhieuChiTietTruyenDich2";
        public const string TablePrimaryKeyName = "ID";
        public const string TableName_CT = "PhieuTDTD2_CT";
        public const string TablePrimaryKeyName_CT = "ID";
        public static ObservableCollection<PhieuChiTietTruyenDich2_ChiTiet> GetData_ChiTiet(MDB.MDBConnection MyConnection, long ID_Phieu)
        {
            ObservableCollection<PhieuChiTietTruyenDich2_ChiTiet> lstData = new ObservableCollection<PhieuChiTietTruyenDich2_ChiTiet>();
            try
            { 
                string sql = @"select * from PhieuTDTD2_CT WHERE  ID_Phieu = :ID_Phieu ORDER BY NgayThang asc";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID_Phieu", ID_Phieu));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                
                    PhieuChiTietTruyenDich2_ChiTiet data = new PhieuChiTietTruyenDich2_ChiTiet();

                    data.ID = DataReader.GetLong("ID");
                    data.ID_Phieu = ID_Phieu;
                    data.NgayThang = Convert.ToDateTime(DataReader["NgayThang"] == DBNull.Value ? DateTime.Now : DataReader["NgayThang"]);
                    data.TenDichTruyen = DataReader["TenDichTruyen"].ToString();
                    data.SoLuong = DataReader["SoLuong"].ToString();
                    data.LoSanXuat = DataReader["LoSanXuat"].ToString();
                    data.TocDo = DataReader["TocDo"].ToString();
                    data.DonVi = DataReader["DonVi"].ToString();
                    data.TiLeQuyDoi = DataReader["TiLeQuyDoi"].ToString();
                    data.ThoiGianBatDau = DataReader["ThoiGianBatDau"] != DBNull.Value ? (DateTime?) Convert.ToDateTime(DataReader["ThoiGianBatDau"].ToString()) : null;
                    data.ThoiGianKetThuc = DataReader["ThoiGianKetThuc"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["ThoiGianKetThuc"].ToString()) : null;
                    data.TenThuocPha = DataReader["TenThuocPha"].ToString();
                    data.LoThuocPha = DataReader["LoThuocPha"].ToString();
                    data.GhiChu = DataReader["GhiChu"].ToString();
                    data.BacSyChiDinh = DataReader["BacSyChiDinh"].ToString();
                    data.MaBacSyChiDinh = DataReader["MaBacSyChiDinh"].ToString();
                    data.DieuDuong = DataReader["DieuDuong"].ToString();
                    data.MaDieuDuong = DataReader["MaDieuDuong"].ToString();
                    data.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                    data.NguoiTao = DataReader["NguoiTao"].ToString();
                    data.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);
                    data.NguoiSua = DataReader["NguoiSua"].ToString();

                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;
                    lstData.Add(data);
                }
            }
            catch (Exception ex)
            {
                MDB.ExceptionExtend.LogError(ex);
            }
            return lstData;
        }
        public static bool InsertOrUpdate_ChiTiet(MDB.MDBConnection MyConnection, ref PhieuChiTietTruyenDich2_ChiTiet ketQua)
        {
            try
            {
                string sql = @"INSERT INTO PhieuTDTD2_CT
                (
                    ID_Phieu,
                    NgayThang,
                    TenDichTruyen,
                    SoLuong,
                    LoSanXuat,
                    TocDo,
                    DonVi,
                    TiLeQuyDoi,
                    ThoiGianBatDau,
                    ThoiGianKetThuc,
                    TenThuocPha,
                    LoThuocPha,
                    GhiChu,
                    BacSyChiDinh,
                    MaBacSyChiDinh,
                    DieuDuong,
                    MaDieuDuong,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA
                )  VALUES
                (
				    :ID_Phieu,
                    :NgayThang,
                    :TenDichTruyen,
                    :SoLuong,
                    :LoSanXuat,
                    :TocDo,
                    :DonVi,
                    :TiLeQuyDoi,
                    :ThoiGianBatDau,
                    :ThoiGianKetThuc,
                    :TenThuocPha,
                    :LoThuocPha,
                    :GhiChu,
                    :BacSyChiDinh,
                    :MaBacSyChiDinh,
                    :DieuDuong,
                    :MaDieuDuong,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 ) RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE PhieuTDTD2_CT SET 
                    ID_Phieu = :ID_Phieu,
                    NgayThang = :NgayThang,
                    TenDichTruyen = :TenDichTruyen,
                    SoLuong = :SoLuong, 
                    LoSanXuat = :LoSanXuat,
                    TocDo = :TocDo,
                    DonVi = :DonVi,
                    TiLeQuyDoi = :TiLeQuyDoi,
                    ThoiGianBatDau = :ThoiGianBatDau,
                    ThoiGianKetThuc = :ThoiGianKetThuc,
                    TenThuocPha = :TenThuocPha,
                    LoThuocPha = :LoThuocPha,
                    GhiChu = :GhiChu,
                    BacSyChiDinh = :BacSyChiDinh,
                    MaBacSyChiDinh = :MaBacSyChiDinh,
                    DieuDuong = :DieuDuong,
                    MaDieuDuong = :MaDieuDuong,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID_Phieu", ketQua.ID_Phieu));
                Command.Parameters.Add(new MDB.MDBParameter("NgayThang", ketQua.NgayThang));
                Command.Parameters.Add(new MDB.MDBParameter("TenDichTruyen", ketQua.TenDichTruyen));
                Command.Parameters.Add(new MDB.MDBParameter("SoLuong", ketQua.SoLuong));
                Command.Parameters.Add(new MDB.MDBParameter("LoSanXuat", ketQua.LoSanXuat));
                Command.Parameters.Add(new MDB.MDBParameter("TocDo", ketQua.TocDo));
                Command.Parameters.Add(new MDB.MDBParameter("DonVi", ketQua.DonVi));
                Command.Parameters.Add(new MDB.MDBParameter("TiLeQuyDoi", ketQua.TiLeQuyDoi));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianBatDau", ketQua.ThoiGianBatDau));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianKetThuc", ketQua.ThoiGianKetThuc));
                Command.Parameters.Add(new MDB.MDBParameter("TenThuocPha", ketQua.TenThuocPha));
                Command.Parameters.Add(new MDB.MDBParameter("LoThuocPha", ketQua.LoThuocPha));
                Command.Parameters.Add(new MDB.MDBParameter("GhiChu", ketQua.GhiChu));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyChiDinh", ketQua.BacSyChiDinh));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSyChiDinh", ketQua.MaBacSyChiDinh));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuong", ketQua.DieuDuong));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuong", ketQua.MaDieuDuong));

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));
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
        public static List<PhieuChiTietTruyenDich2> GetData(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            List<PhieuChiTietTruyenDich2> lstData = new List<PhieuChiTietTruyenDich2>();
            string sql = @"select * from PhieuChiTietTruyenDich2 WHERE  MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            while (DataReader.Read())
            {
                try
                {
                    PhieuChiTietTruyenDich2 data = new PhieuChiTietTruyenDich2();
                    data.ID = DataReader.GetLong("ID");
                    data.MaQuanLy = MaQuanLy;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.HoTenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.Khoa = DataReader["Khoa"].ToString();
                    data.MaKhoa = DataReader["MaKhoa"].ToString();
                    data.Giuong = DataReader["Giuong"].ToString();
                    data.Buong = DataReader["Buong"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.ChiTiets = GetData_ChiTiet(MyConnection, data.ID);

                    data.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                    data.NguoiTao = DataReader["NguoiTao"].ToString();
                    data.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);
                    data.NguoiSua = DataReader["NguoiSua"].ToString();

                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;
                    lstData.Add(data);
                }
                catch (Exception ex)
                {
                    MDB.ExceptionExtend.LogError(ex);
                }
            }
            return lstData;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuChiTietTruyenDich2 bangKe)
        {
            try
            {
                string sql = @"INSERT INTO PhieuChiTietTruyenDich2
                (
                    MAQUANLY,
                    MaBenhNhan,
                    Khoa,
                    MaKhoa,
                    Giuong,
                    Buong,
                    ChanDoan,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :Khoa,
                    :MaKhoa,
                    :Giuong,
                    :Buong,
                    :ChanDoan,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (bangKe.ID != 0)
                {
                    sql = @"UPDATE PhieuChiTietTruyenDich2 SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    Khoa = :Khoa,
                    MaKhoa = :MaKhoa,
                    Giuong = :Giuong,
                    Buong = :Buong,
                    ChanDoan = :ChanDoan,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + bangKe.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangKe.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", bangKe.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa", bangKe.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaKhoa", bangKe.MaKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("Giuong", bangKe.Giuong));
                Command.Parameters.Add(new MDB.MDBParameter("Buong", bangKe.Buong));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", bangKe.ChanDoan));

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", bangKe.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", bangKe.NgaySua));
                if (bangKe.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", bangKe.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", bangKe.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", bangKe.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (bangKe.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    bangKe.ID = nextval;
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
                string sql = "DELETE FROM PhieuChiTietTruyenDich2 WHERE ID = :ID";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                command.Parameters.Add(new MDB.MDBParameter("ID", id));
                command.BindByName = true;
                int n = command.ExecuteNonQuery();

                sql = "DELETE FROM PhieuTDTD2_CT WHERE ID_Phieu = :ID_Phieu";
                command = new MDB.MDBCommand(sql, MyConnection);
                command.Parameters.Add(new MDB.MDBParameter("ID_Phieu", id));
                command.BindByName = true;
                n = command.ExecuteNonQuery();

                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool Delete_Phieu(MDB.MDBConnection MyConnection, long id)
        {
            try
            {
                string sql = "DELETE FROM PhieuTDTD2_CT WHERE ID = :ID";
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
                P.* 
            FROM
                PhieuChiTietTruyenDich2 P
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "KQ");

            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(string));
            ds.Tables[0].AddColumn("SoVaoVien", typeof(string));
            ds.Tables[0].AddColumn("SOYTE", typeof(string));
            ds.Tables[0].AddColumn("BENHVIEN", typeof(string));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            ds.Tables[0].Rows[0]["SoVaoVien"] = XemBenhAn._ThongTinDieuTri.SoNhapVien;
            ds.Tables[0].Rows[0]["SOYTE"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            List<PhieuChiTietTruyenDich2_ChiTiet> chiTiets = GetData_ChiTiet(MyConnection, id).ToList();
            DataTable CT = Common.ListToDataTable(chiTiets, "CT");
            ds.Tables.Add(CT);
            return ds;
        }
        public static ObservableCollection<PhieuChiTietTruyenDich2_ChiTiet> GetData_ChiTietByID(MDB.MDBConnection MyConnection, long ID)
        {
            ObservableCollection<PhieuChiTietTruyenDich2_ChiTiet> lstData = new ObservableCollection<PhieuChiTietTruyenDich2_ChiTiet>();
            try
            {
                string sql = @"select * from PhieuTDTD2_CT WHERE  ID = :ID";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID", ID));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {

                    PhieuChiTietTruyenDich2_ChiTiet data = new PhieuChiTietTruyenDich2_ChiTiet();

                    data.ID = DataReader.GetLong("ID");
                    data.ID_Phieu = DataReader.GetLong("ID_Phieu");
                    data.NgayThang = Convert.ToDateTime(DataReader["NgayThang"] == DBNull.Value ? DateTime.Now : DataReader["NgayThang"]);
                    data.TenDichTruyen = DataReader["TenDichTruyen"].ToString();
                    data.SoLuong = DataReader["SoLuong"].ToString();
                    data.LoSanXuat = DataReader["LoSanXuat"].ToString();
                    data.TocDo = DataReader["TocDo"].ToString();
                    data.DonVi = DataReader["DonVi"].ToString();
                    data.TiLeQuyDoi = DataReader["TiLeQuyDoi"].ToString();
                    data.ThoiGianBatDau = DataReader["ThoiGianBatDau"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["ThoiGianBatDau"].ToString()) : null;
                    data.ThoiGianKetThuc = DataReader["ThoiGianKetThuc"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["ThoiGianKetThuc"].ToString()) : null;
                    data.TenThuocPha = DataReader["TenThuocPha"].ToString();
                    data.LoThuocPha = DataReader["LoThuocPha"].ToString();
                    data.GhiChu = DataReader["GhiChu"].ToString();
                    data.BacSyChiDinh = DataReader["BacSyChiDinh"].ToString();
                    data.MaBacSyChiDinh = DataReader["MaBacSyChiDinh"].ToString();
                    data.DieuDuong = DataReader["DieuDuong"].ToString();
                    data.MaDieuDuong = DataReader["MaDieuDuong"].ToString();
                    data.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                    data.NguoiTao = DataReader["NguoiTao"].ToString();
                    data.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);
                    data.NguoiSua = DataReader["NguoiSua"].ToString();

                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;
                    lstData.Add(data);
                }
            }
            catch (Exception ex)
            {
                MDB.ExceptionExtend.LogError(ex);
            }
            return lstData;
        }
        public static DataSet getDataSet_CT(MDB.MDBConnection MyConnection, long id_phieu, long id)
        {
            string sql = @"SELECT
                P.* 
            FROM
                PhieuChiTietTruyenDich2 P
            WHERE
                ID = " + id_phieu;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "KQ");

            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(string));
            ds.Tables[0].AddColumn("SoVaoVien", typeof(string));
            ds.Tables[0].AddColumn("SOYTE", typeof(string));
            ds.Tables[0].AddColumn("BENHVIEN", typeof(string));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            ds.Tables[0].Rows[0]["SoVaoVien"] = XemBenhAn._ThongTinDieuTri.SoNhapVien;
            ds.Tables[0].Rows[0]["SOYTE"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            List<PhieuChiTietTruyenDich2_ChiTiet> chiTiets = GetData_ChiTietByID(MyConnection, id).ToList();
            DataTable CT = Common.ListToDataTable(chiTiets, "CT");
            ds.Tables.Add(CT);
            return ds;
        }
    }    
}
