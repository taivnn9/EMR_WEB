using DevExpress.CodeParser;
using EMR.KyDienTu;
using Newtonsoft.Json;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuChamSocNguoiBenhCap23_ChiTiet
    {
        [MoTaDuLieu("Mã định danh")]
		public long ID;
        [MoTaDuLieu("Mã định danh")]
		public long ID_Phieu { get; set; }
        public DateTime NgayChamSoc { get; set; }
        public DateTime GioChamSoc { get; set; }
        public int? Mach { get; set; }
        public float? NhietDo { get; set; }
        public float? HAMax { get; set; }
        public float? HAMin { get; set; }
        public float? NhipTho { get; set; }
        public float? CanNang { get; set; }
        public int? DHST { get; set; }
        public int? ThayBang { get; set; }
        public int? AnQuaOngThong { get; set; }
        public string HutDam { get; set; }
        public string VeSinhCaNhan { get; set; }
        public string XoayTro { get; set; }
        public string CheDoAn { get; set; }
        public string CheDoHoatDong { get; set; }
        public string Khac { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuong { get; set; }
        [MoTaDuLieu("Mã điều dưỡng")]
		public string MaDieuDuong { get; set; }
        public PhieuChamSocNguoiBenhCap23_ChiTiet Clone(PhieuChamSocNguoiBenhCap23_ChiTiet obj)
        {
            PhieuChamSocNguoiBenhCap23_ChiTiet other = (PhieuChamSocNguoiBenhCap23_ChiTiet)obj.MemberwiseClone();
            return other;
        }
        public bool checkUpDate  { get; set; }

}
    public class GhiChu
    {
        public DateTime Ngay { get; set; }
        public DateTime Gio { get; set; }
        public string NoiDung { get; set; }
        public GhiChu Clone(GhiChu obj)
        {
            return (GhiChu)obj.MemberwiseClone();
        }
    }
    public class ThongTinTDCLS
    {
        public string Ten { get; set; }
        public List<GhiChu> GhiChus { get; set; }
        public ThongTinTDCLS Clone(ThongTinTDCLS obj)
        {
            ThongTinTDCLS other = (ThongTinTDCLS)obj.MemberwiseClone();
            other.GhiChus = new List<GhiChu>();
            foreach(GhiChu item in this.GhiChus)
            {
                other.GhiChus.Add(item.Clone(item));
            }
            return other;

        }
    }
    public class PhieuChamSocNguoiBenhCap23 : ThongTinKy
    {
        public PhieuChamSocNguoiBenhCap23()
        {
            TableName = "PhieuTDCSNguoiBenhCap23";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PTDCN23;
            TenMauPhieu = DanhMucPhieu.PTDCN23.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Số nhập viện")]
		public string SoNhapVien { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Năm sinh")]
		public string NamSinh { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Số bệnh án")]
		public string SoBenhAn { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }
        [MoTaDuLieu("Buồng")]
		public string Buong { get; set; }
        [MoTaDuLieu("Giường")]
		public string Giuong { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public List<PhieuChamSocNguoiBenhCap23_ChiTiet> ThongTinChiTiet { get; set; }
        public List<ThongTinTDCLS> TheoDoi { get; set; }
        public List<ThongTinTDCLS> CLS { get; set; }

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
        public PhieuChamSocNguoiBenhCap23 Clone()
        {
            PhieuChamSocNguoiBenhCap23 other = (PhieuChamSocNguoiBenhCap23)this.MemberwiseClone();
            other.TheoDoi = new List<ThongTinTDCLS>();
            foreach (ThongTinTDCLS item in this.TheoDoi)
            {
                other.TheoDoi.Add(item.Clone(item));
            }
            other.CLS = new List<ThongTinTDCLS>();
            foreach (ThongTinTDCLS item in this.CLS)
            {
                other.CLS.Add(item.Clone(item));
            }
            other.ThongTinChiTiet = new List<PhieuChamSocNguoiBenhCap23_ChiTiet>();
            foreach (PhieuChamSocNguoiBenhCap23_ChiTiet item in this.ThongTinChiTiet)
            {
                other.ThongTinChiTiet.Add(item.Clone(item));
            }
            return other;
        }
    }
    public class PhieuChamSocNguoiBenhCap23Func
    {
        public const string TableName = "PhieuTDCSNguoiBenhCap23";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuChamSocNguoiBenhCap23> GetListData_Phieu(MDB.MDBConnection _OracleConnection, decimal maquanly, Decimal ID = -1)
        {
            List<PhieuChamSocNguoiBenhCap23> list = new List<PhieuChamSocNguoiBenhCap23>();
            try
            {
                string sql = @"SELECT * FROM PhieuTDCSNguoiBenhCap23 where MaQuanLy = :MaQuanLy";
                if(ID> -1)
                {
                    sql = sql + @"  and ID = " + ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuChamSocNguoiBenhCap23 data = new PhieuChamSocNguoiBenhCap23();
                    data.TenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.NamSinh = XemBenhAn._HanhChinhBenhNhan.NgaySinh.HasValue? XemBenhAn._HanhChinhBenhNhan.NgaySinh.Value.Year.ToString() : XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.SoBenhAn = XemBenhAn._ThongTinDieuTri.MaBenhAn;
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.Khoa = DataReader["Khoa"].ToString();
                    data.MaKhoa = DataReader["MaKhoa"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.Giuong = DataReader["Giuong"].ToString();
                    data.Buong = DataReader["Buong"].ToString();
                    data.TheoDoi = JsonConvert.DeserializeObject<List<ThongTinTDCLS>>(DataReader["TheoDoi"].ToString());
                    data.CLS = JsonConvert.DeserializeObject<List<ThongTinTDCLS>>(DataReader["CLS"].ToString());
                    data.ThongTinChiTiet = GetListData_ChiTiet(_OracleConnection, data.ID);

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
        public static List<PhieuChamSocNguoiBenhCap23_ChiTiet> GetListData_ChiTiet(MDB.MDBConnection _OracleConnection, decimal ID_Phieu)
        {
            List<PhieuChamSocNguoiBenhCap23_ChiTiet> list = new List<PhieuChamSocNguoiBenhCap23_ChiTiet>();
            try
            {
                string sql = @"SELECT * FROM PhieuTDCSNguoiBenhCap23_CT where ID_Phieu = :ID_Phieu order by NgayGio asc";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID_Phieu", ID_Phieu));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuChamSocNguoiBenhCap23_ChiTiet data = new PhieuChamSocNguoiBenhCap23_ChiTiet();
                    data.NgayChamSoc = Convert.ToDateTime(DataReader["NgayGio"] == DBNull.Value ? DateTime.Now : DataReader["NgayGio"]);
                    data.ID = DataReader.GetLong("ID");
                    data.ID_Phieu =DataReader.GetLong("ID_Phieu");
                    data.GioChamSoc = data.NgayChamSoc;
                    data.Mach = DataReader.GetInt("Mach");
                    data.NhietDo = Common.ConDBNull_float(DataReader["NhietDo"]);
                    data.HAMax = Common.ConDBNull_float(DataReader["HAMax"]);
                    data.HAMin = Common.ConDBNull_float(DataReader["HAMin"]);
                    data.NhipTho = Common.ConDBNull_float(DataReader["NhipTho"]);
                    data.CanNang = Common.ConDBNull_float(DataReader["CanNang"]);
                    data.DHST = DataReader.GetInt("DHST");
                    data.ThayBang = DataReader.GetInt("ThayBang");
                    data.AnQuaOngThong = DataReader.GetInt("AnQuaOngThong");
                    data.HutDam = DataReader["HutDam"].ToString();
                    data.VeSinhCaNhan = DataReader["VeSinhCaNhan"].ToString();
                    data.XoayTro = DataReader["XoayTro"].ToString();
                    data.CheDoAn = DataReader["CheDoAn"].ToString();
                    data.CheDoHoatDong = DataReader["CheDoHoatDong"].ToString();
                    data.Khac = DataReader["Khac"].ToString();
                    data.DieuDuong = DataReader["DieuDuong"].ToString();
                    data.MaDieuDuong = DataReader["MaDieuDuong"].ToString();

                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool InsertOrUpdate_Phieu(MDB.MDBConnection MyConnection, ref PhieuChamSocNguoiBenhCap23 phieuTheoDoi)
        {
            try
            {
                string sql = @"INSERT INTO PhieuTDCSNguoiBenhCap23
                (
                    MAQUANLY,
                    MaBenhNhan,
                    Khoa,
	                MaKhoa,
                    ChanDoan,
                    Giuong,
                    Buong,
                    TheoDoi,
                    CLS,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :Khoa,
	                :MaKhoa,
                    :ChanDoan,
                    :Giuong,
                    :Buong,
                    :TheoDoi,
                    :CLS,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (phieuTheoDoi.ID != 0)
                {
                    sql = @"UPDATE PhieuTDCSNguoiBenhCap23 SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    Khoa = :Khoa,
	                MaKhoa = :MaKhoa,
                    Giuong = :Giuong,
                    Buong = :Buong,
                    ChanDoan = :ChanDoan,
                    TheoDoi = :TheoDoi,
                    CLS = :CLS,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + phieuTheoDoi.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", phieuTheoDoi.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", phieuTheoDoi.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa", phieuTheoDoi.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaKhoa", phieuTheoDoi.MaKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", phieuTheoDoi.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("Giuong", phieuTheoDoi.Giuong));
                Command.Parameters.Add(new MDB.MDBParameter("Buong", phieuTheoDoi.Buong));
                Command.Parameters.Add(new MDB.MDBParameter("TheoDoi", JsonConvert.SerializeObject(phieuTheoDoi.TheoDoi)));
                Command.Parameters.Add(new MDB.MDBParameter("CLS", JsonConvert.SerializeObject(phieuTheoDoi.CLS)));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", phieuTheoDoi.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", phieuTheoDoi.NgaySua));
                if (phieuTheoDoi.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", phieuTheoDoi.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", phieuTheoDoi.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", phieuTheoDoi.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (phieuTheoDoi.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    phieuTheoDoi.ID = nextval;
                }
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool InsertOrUpdate_ChiTiet(MDB.MDBConnection MyConnection, PhieuChamSocNguoiBenhCap23_ChiTiet phieuChiTiet)
        {
            try
            {
                string sql = @"INSERT INTO PhieuTDCSNguoiBenhCap23_CT
                (
                    ID_Phieu,
                    NgayGio,
                    Mach,
                    NhietDo,
                    HAMax,
                    HAMin,
                    NhipTho,
                    CanNang,
                    DHST,
                    ThayBang,
                    AnQuaOngThong,
                    HutDam,
                    VeSinhCaNhan,
                    XoayTro,
                    CheDoAn,
                    CheDoHoatDong,
                    Khac,
                    DieuDuong,
                    MaDieuDuong) 
                VALUES
                 (
				    :ID_Phieu,
                    :NgayGio,
                    :Mach,
                    :NhietDo,
                    :HAMax,
                    :HAMin,
                    :NhipTho,
                    :CanNang,
                    :DHST,
                    :ThayBang,
                    :AnQuaOngThong,
                    :HutDam,
                    :VeSinhCaNhan,
                    :XoayTro,
                    :CheDoAn,
                    :CheDoHoatDong,
                    :Khac,
                    :DieuDuong,
                    :MaDieuDuong
                 )";
                if (phieuChiTiet.ID != 0)
                {
                    sql = @"UPDATE PhieuTDCSNguoiBenhCap23_CT SET 
                    ID_Phieu = :ID_Phieu,
                    NgayGio = :NgayGio,
                    Mach = :Mach,
                    NhietDo = :NhietDo,
                    HAMax = :HAMax,
                    HAMin = :HAMin,
                    NhipTho = :NhipTho,
                    CanNang = :CanNang,
                    DHST = :DHST,
                    ThayBang = :ThayBang,
                    AnQuaOngThong = :AnQuaOngThong,
                    HutDam = :HutDam,
                    VeSinhCaNhan = :VeSinhCaNhan,
                    XoayTro = :XoayTro,
                    CheDoAn = :CheDoAn,
                    CheDoHoatDong = :CheDoHoatDong,
                    Khac = :Khac,
                    DieuDuong = :DieuDuong,
                    MaDieuDuong = :MaDieuDuong
                    WHERE ID = " + phieuChiTiet.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID_Phieu", phieuChiTiet.ID_Phieu));
                var Ngay = phieuChiTiet.NgayChamSoc.Date.Add(new TimeSpan(0, 0, 0));
                var Gio = phieuChiTiet.GioChamSoc != null ? phieuChiTiet.GioChamSoc.TimeOfDay : DateTime.Now.TimeOfDay;
                var NgayGioChamSoc = Ngay + Gio;
                Command.Parameters.Add(new MDB.MDBParameter("NgayGio", NgayGioChamSoc));
                Command.Parameters.Add(new MDB.MDBParameter("Mach", phieuChiTiet.Mach));
                Command.Parameters.Add(new MDB.MDBParameter("NhietDo", phieuChiTiet.NhietDo));
                Command.Parameters.Add(new MDB.MDBParameter("HAMax", phieuChiTiet.HAMax));
                Command.Parameters.Add(new MDB.MDBParameter("HAMin", phieuChiTiet.HAMin));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTho", phieuChiTiet.NhipTho));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang", phieuChiTiet.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("DHST", phieuChiTiet.DHST));
                Command.Parameters.Add(new MDB.MDBParameter("ThayBang", phieuChiTiet.ThayBang));
                Command.Parameters.Add(new MDB.MDBParameter("AnQuaOngThong", phieuChiTiet.AnQuaOngThong));
                Command.Parameters.Add(new MDB.MDBParameter("HutDam", phieuChiTiet.HutDam));
                Command.Parameters.Add(new MDB.MDBParameter("VeSinhCaNhan", phieuChiTiet.VeSinhCaNhan));
                Command.Parameters.Add(new MDB.MDBParameter("XoayTro", phieuChiTiet.XoayTro));
                Command.Parameters.Add(new MDB.MDBParameter("CheDoAn", phieuChiTiet.CheDoAn));
                Command.Parameters.Add(new MDB.MDBParameter("CheDoHoatDong", phieuChiTiet.CheDoHoatDong));
                Command.Parameters.Add(new MDB.MDBParameter("Khac", phieuChiTiet.Khac));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuong", phieuChiTiet.DieuDuong));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuong", phieuChiTiet.MaDieuDuong));
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
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
                string sql = "DELETE FROM PhieuTDCSNguoiBenhCap23 WHERE ID = :ID";
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
        public static bool Delete_ChiTiet(MDB.MDBConnection MyConnection, long id)
        {
            try
            {
                string sql = "DELETE FROM PhieuTDCSNguoiBenhCap23_CT WHERE ID = :ID";
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
    }
}
