using EMR.KyDienTu;
using Newtonsoft.Json;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuTrichBienBanHoiChan : ThongTinKy
    {
        public PhieuTrichBienBanHoiChan()
        {
            TableName = "PhieuTrichBienBanHoiChan";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PTBBHC;
            TenMauPhieu = DanhMucPhieu.PTBBHC.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        public string SoYTe
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.SoYTe;
            }
        }
        public string BenhVien
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.BenhVien;
            }
        }
        public string Khoa
        {
            get
            {
                return XemBenhAn._ThongTinDieuTri.Khoa;
            }
        }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan
        {
            get
            {
                return XemBenhAn._ThongTinDieuTri.MaBenhNhan;
            }
        }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan{ get;set; }
        public string SoVaoVien
        {
            get
            {
                return XemBenhAn._ThongTinDieuTri.SoNhapVien;
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
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.Tuoi;
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
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi
        {
            get
            {
                return Common.GetDiaChi();
            }
        }
        public string Buong{ get; set; }
        [MoTaDuLieu("Giường")]
		public string Giuong { get; set; }
      
        public string NgheNghiep
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.NgheNghiep;
            }
        }
        public string DanToc
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.DanToc;
            }
        }
        public string HoTenDiaChiNguoiNha
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.HoTenDiaChiNguoiNha;
            }
        }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        public string TenPhieu { get; set; }
        public DateTime DieuTriTuNgay { get; set; }
        public DateTime DieuTriDenNgay { get; set; }
        public DateTime HoiChanLuc { get; set; }
        public DateTime? HoiChanLuc_Gio { get; set; }
        public DateTime ThoiGian { get; set; }
        public string ThanhVien { get; set; }
        public string TomTat { get; set; }
        public string KetLuan { get; set; }
        public string HuongDieuTri { get; set; }
        public string MaThuKy { get; set; }
        public string ThuKy { get; set; }
        public string MaChuToa { get; set; }
        public string ChuToa { get; set; }

        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
    }
    public class PhieuTrichBienBanHoiChanFunc
    {
        public const string TableName = "PhieuTrichBienBanHoiChan";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuTrichBienBanHoiChan> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuTrichBienBanHoiChan> list = new List<PhieuTrichBienBanHoiChan>();
            try
            {
                string sql = @"SELECT * FROM PhieuTrichBienBanHoiChan where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuTrichBienBanHoiChan data = new PhieuTrichBienBanHoiChan();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.TenPhieu = DataReader["TenPhieu"].ToString();
                    data.DieuTriTuNgay = Convert.ToDateTime(DataReader["DieuTriTuNgay"] == DBNull.Value ? DateTime.Now : DataReader["DieuTriTuNgay"]);
                    data.DieuTriDenNgay = Convert.ToDateTime(DataReader["DieuTriDenNgay"] == DBNull.Value ? DateTime.Now : DataReader["DieuTriDenNgay"]);
                    data.HoiChanLuc = Convert.ToDateTime(DataReader["HoiChanLuc"] == DBNull.Value ? DateTime.Now : DataReader["HoiChanLuc"]);
                    data.HoiChanLuc_Gio = data.HoiChanLuc;
                    data.ThoiGian = Convert.ToDateTime(DataReader["ThoiGian"] == DBNull.Value ? DateTime.Now : DataReader["ThoiGian"]);
                    data.ThanhVien = DataReader["ThanhVien"].ToString();
                    data.TomTat = DataReader["TomTat"].ToString();
                    data.KetLuan = DataReader["KetLuan"].ToString();
                    data.HuongDieuTri = DataReader["HuongDieuTri"].ToString();
                    data.MaThuKy = DataReader["MaThuKy"].ToString();
                    data.ThuKy = DataReader["ThuKy"].ToString();
                    data.MaChuToa = DataReader["MaChuToa"].ToString();
                    data.ChuToa = DataReader["ChuToa"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.Buong = DataReader["Buong"].ToString();
                    data.Giuong = DataReader["Giuong"].ToString();

                    data.NguoiTao = DataReader["NguoiTao"].ToString();
                    data.NguoiSua = DataReader["NguoiSua"].ToString();
                    data.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                    data.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);
                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy);
                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuTrichBienBanHoiChan data)
        {
            try
            {
                string sql = @"INSERT INTO PhieuTrichBienBanHoiChan
                (
                    MaQuanLy,
                    TenPhieu,
                    DieuTriTuNgay,
                    DieuTriDenNgay,
                    HoiChanLuc,
                    ThoiGian,
                    ThanhVien,
                    TomTat,
                    KetLuan,
                    HuongDieuTri,
                    MaThuKy,
                    ThuKy,
                    MaChuToa,
                    ChuToa,
                    ChanDoan,
                    Buong,
                    Giuong,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
                    :TenPhieu,
                    :DieuTriTuNgay,
                    :DieuTriDenNgay,
                    :HoiChanLuc,
                    :ThoiGian,
                    :ThanhVien,
                    :TomTat,
                    :KetLuan,
                    :HuongDieuTri,
                    :MaThuKy,
                    :ThuKy,
                    :MaChuToa,
                    :ChuToa,
                    :ChanDoan,
                    :Buong,
                    :Giuong,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (data.ID != 0)
                {
                    sql = @"UPDATE PhieuTrichBienBanHoiChan SET 
                    MaQuanLy=:MaQuanLy,
                    TenPhieu=:TenPhieu,
                    DieuTriTuNgay=:DieuTriTuNgay,
                    DieuTriDenNgay=:DieuTriDenNgay,
                    HoiChanLuc=:HoiChanLuc,
                    ThoiGian=:ThoiGian,
                    ThanhVien=:ThanhVien,
                    TomTat=:TomTat,
                    KetLuan=:KetLuan,
                    HuongDieuTri=:HuongDieuTri,
                    MaThuKy=:MaThuKy,
                    ThuKy=:ThuKy,
                    MaChuToa=:MaChuToa,
                    ChuToa=:ChuToa,
                    ChanDoan = :ChanDoan,
                    Buong = :Buong,
                    Giuong = :Giuong,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + data.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", data.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("TenPhieu", data.TenPhieu));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriTuNgay", data.DieuTriTuNgay));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriDenNgay", data.DieuTriDenNgay));
                var Ngay = data.HoiChanLuc.Date.Add(new TimeSpan(0, 0, 0));
                var Gio = data.HoiChanLuc_Gio.HasValue ? data.HoiChanLuc_Gio.Value.TimeOfDay : new TimeSpan(0, 0, 0);
                var HoiChanLuc = Ngay + Gio;
                Command.Parameters.Add(new MDB.MDBParameter("HoiChanLuc", HoiChanLuc));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGian", data.ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("ThanhVien", data.ThanhVien));
                Command.Parameters.Add(new MDB.MDBParameter("TomTat", data.TomTat));
                Command.Parameters.Add(new MDB.MDBParameter("KetLuan", data.KetLuan));
                Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", data.HuongDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("MaThuKy", data.MaThuKy));
                Command.Parameters.Add(new MDB.MDBParameter("ThuKy", data.ThuKy));
                Command.Parameters.Add(new MDB.MDBParameter("MaChuToa", data.MaChuToa));
                Command.Parameters.Add(new MDB.MDBParameter("ChuToa", data.ChuToa));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", data.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("Buong", data.Buong));
                Command.Parameters.Add(new MDB.MDBParameter("Giuong", data.Giuong));

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
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    data.ID = nextval;
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
                string sql = "DELETE FROM PhieuTrichBienBanHoiChan WHERE ID = :ID";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                command.Parameters.Add(new MDB.MDBParameter("ID", id));
                command.BindByName = true;
                return command.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, long id)
        {
            string sql = @"SELECT * FROM PhieuTrichBienBanHoiChan WHERE ID = " + id;
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            PhieuTrichBienBanHoiChan data = new PhieuTrichBienBanHoiChan();
            adt.Fill(ds, "DS");
            if (ds != null && ds.Tables[0] != null)
            {
                ds.Tables[0].Columns.Add("SoYTe");
                ds.Tables[0].Columns.Add("BenhVien");
                ds.Tables[0].Columns.Add("Khoa");
                ds.Tables[0].Columns.Add("MaBenhNhan");
                ds.Tables[0].Columns.Add("MaBenhAn");
                ds.Tables[0].Columns.Add("SoVaoVien");
                ds.Tables[0].Columns.Add("TenBenhNhan");
                ds.Tables[0].Columns.Add("Tuoi");
                ds.Tables[0].Columns.Add("GioiTinh");
                ds.Tables[0].Columns.Add("DiaChi");
                ds.Tables[0].Columns.Add("NgheNghiep");
                ds.Tables[0].Columns.Add("DanToc");
                ds.Tables[0].Columns.Add("HoTenDiaChiNguoiNha");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    ds.Tables[0].Rows[0]["SoYTe"] = data.SoYTe;
                    ds.Tables[0].Rows[0]["BenhVien"] = data.BenhVien;
                    ds.Tables[0].Rows[0]["Khoa"] = data.Khoa;
                    ds.Tables[0].Rows[0]["MaBenhNhan"] = data.MaBenhNhan;
                    ds.Tables[0].Rows[0]["MaBenhAn"] = XemBenhAn._ThongTinDieuTri.MaBenhAn;
                    ds.Tables[0].Rows[0]["SoVaoVien"] = data.SoVaoVien;
                    ds.Tables[0].Rows[0]["TenBenhNhan"] = data.TenBenhNhan;
                    ds.Tables[0].Rows[0]["Tuoi"] = data.Tuoi;
                    ds.Tables[0].Rows[0]["GioiTinh"] = data.GioiTinh;
                    ds.Tables[0].Rows[0]["DiaChi"] = data.DiaChi;
                    ds.Tables[0].Rows[0]["NgheNghiep"] = data.NgheNghiep;
                    ds.Tables[0].Rows[0]["DanToc"] = data.DanToc;
                    ds.Tables[0].Rows[0]["HoTenDiaChiNguoiNha"] = data.HoTenDiaChiNguoiNha;
                }
            }
            return ds;
        }
    }
}
