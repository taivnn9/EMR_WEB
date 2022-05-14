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
    public class PhieuLocMau2ChiTiet
    {
        public DateTime ThoiGian { get; set; }
        public string HATL { get; set; }
        public string SL { get; set; }
        [MoTaDuLieu("Cân nặng")]
		public string CanNang { get; set; }
        public string UF { get; set; }
        [MoTaDuLieu("Mạch")]
		public string Mach { get; set; }
        [MoTaDuLieu("Y lệnh")]
		public string YLenh { get; set; }
        [MoTaDuLieu("Thực hiện y lệnh")]
		public string ThucHienYLenh { get; set; }
        public string BS { get; set; }
        public string DD { get; set; }
    }
    public class PhieuLocMau2 : ThongTinKy
    {
        public PhieuLocMau2()
        {
            TableName = "PhieuLocMau2";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PLM2;
            TenMauPhieu = DanhMucPhieu.PLM2.Description();
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
                return XemBenhAn._HanhChinhBenhNhan.GioiTinh.ToString();
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
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        public string Cas { get; set; }
        public DateTime NgayLocMau { get; set; }
        public DateTime TuNgay { get; set; }
        public DateTime DenNgay { get; set; }
        public DateTime ThoiGianLocMau { get; set; }
        public string CanKho { get; set; }
        public string TocDoLocMau { get; set; }
        public int DuongVaoMachMau { get; set; }
        public string LieuChongDong { get; set; }
        public string ChiDinhThuoc { get; set; }
        public List<PhieuLocMau2ChiTiet> ChiTiet { get; set; }
        public string TongSoLanLocMau { get; set; }
        public string ThuocEry { get; set; }
        public string Khac { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuong { get; set; }
        [MoTaDuLieu("Mã điều dưỡng")]
		public string MaDieuDuong { get; set; }
        [MoTaDuLieu("Họ tên bác sỹ")]
		public string BacSi { get; set; }
        [MoTaDuLieu("Mã bác sỹ")]
		public string MaBacSi { get; set; }
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
    public class PhieuLocMau2Func
    {
        public const string TableName = "PhieuLocMau2";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuLocMau2> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuLocMau2> list = new List<PhieuLocMau2>();
            try
            {
                string sql = @"SELECT * FROM PhieuLocMau2 where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuLocMau2 data = new PhieuLocMau2();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.Cas = DataReader["Cas"].ToString();
                    data.NgayLocMau = Convert.ToDateTime(DataReader["NgayLocMau"] == DBNull.Value ? DateTime.Now : DataReader["NgayLocMau"]);
                    data.TuNgay = Convert.ToDateTime(DataReader["TuNgay"] == DBNull.Value ? DateTime.Now : DataReader["TuNgay"]);
                    data.DenNgay = Convert.ToDateTime(DataReader["DenNgay"] == DBNull.Value ? DateTime.Now : DataReader["DenNgay"]);
                    data.ThoiGianLocMau = Convert.ToDateTime(DataReader["ThoiGianLocMau"] == DBNull.Value ? DateTime.Now : DataReader["ThoiGianLocMau"]);
                    data.CanKho = DataReader["CanKho"].ToString();
                    data.TocDoLocMau = DataReader["TocDoLocMau"].ToString();
                    int tempInt = -1;
                    int.TryParse(DataReader["DuongVaoMachMau"].ToString(), out tempInt);
                    data.DuongVaoMachMau = tempInt;
                    data.LieuChongDong = DataReader["LieuChongDong"].ToString();
                    data.ChiDinhThuoc = DataReader["ChiDinhThuoc"].ToString();
                    data.ChiTiet = JsonConvert.DeserializeObject<List<PhieuLocMau2ChiTiet>>(DataReader["ChiTiet"].ToString());
                    data.TongSoLanLocMau = DataReader["TongSoLanLocMau"].ToString();
                    data.ThuocEry = DataReader["ThuocEry"].ToString();
                    data.Khac = DataReader["Khac"].ToString();
                    data.DieuDuong = DataReader["DieuDuong"].ToString();
                    data.MaDieuDuong = DataReader["MaDieuDuong"].ToString();
                    data.BacSi = DataReader["BacSi"].ToString();
                    data.MaBacSi = DataReader["MaBacSi"].ToString();

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuLocMau2 data)
        {
            try
            {
                string sql = @"INSERT INTO PhieuLocMau2
                (
                    MAQUANLY,
                    Cas,
                    NgayLocMau,
                    TuNgay,
                    DenNgay,
                    ThoiGianLocMau,
                    CanKho,
                    TocDoLocMau,
                    DuongVaoMachMau,
                    LieuChongDong,
                    ChiDinhThuoc,
                    ChiTiet,
                    TongSoLanLocMau,
                    ThuocEry,
                    Khac,
                    DieuDuong,
                    MaDieuDuong,
                    BacSi,
                    MaBacSi,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :Cas,
                    :NgayLocMau,
                    :TuNgay,
                    :DenNgay,
                    :ThoiGianLocMau,
                    :CanKho,
                    :TocDoLocMau,
                    :DuongVaoMachMau,
                    :LieuChongDong,
                    :ChiDinhThuoc,
                    :ChiTiet,
                    :TongSoLanLocMau,
                    :ThuocEry,
                    :Khac,
                    :DieuDuong,
                    :MaDieuDuong,
                    :BacSi,
                    :MaBacSi,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (data.ID != 0)
                {
                    sql = @"UPDATE PhieuLocMau2 SET 
                    MAQUANLY = :MAQUANLY,
                    Cas=:Cas,
                    NgayLocMau=:NgayLocMau,
                    TuNgay=:TuNgay,
                    DenNgay=:DenNgay,
                    ThoiGianLocMau=:ThoiGianLocMau,
                    CanKho=:CanKho,
                    TocDoLocMau=:TocDoLocMau,
                    DuongVaoMachMau=:DuongVaoMachMau,
                    LieuChongDong=:LieuChongDong,
                    ChiDinhThuoc=:ChiDinhThuoc,
                    ChiTiet=:ChiTiet,
                    TongSoLanLocMau=:TongSoLanLocMau,
                    ThuocEry=:ThuocEry,
                    Khac=:Khac,
                    DieuDuong=:DieuDuong,
                    MaDieuDuong=:MaDieuDuong,
                    BacSi=:BacSi,
                    MaBacSi=:MaBacSi,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + data.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", data.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("Cas", data.Cas));
                Command.Parameters.Add(new MDB.MDBParameter("NgayLocMau", data.NgayLocMau));
                Command.Parameters.Add(new MDB.MDBParameter("TuNgay", data.TuNgay));
                Command.Parameters.Add(new MDB.MDBParameter("DenNgay", data.DenNgay));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianLocMau", data.ThoiGianLocMau));
                Command.Parameters.Add(new MDB.MDBParameter("CanKho", data.CanKho));
                Command.Parameters.Add(new MDB.MDBParameter("TocDoLocMau", data.TocDoLocMau));
                Command.Parameters.Add(new MDB.MDBParameter("DuongVaoMachMau", data.DuongVaoMachMau));
                Command.Parameters.Add(new MDB.MDBParameter("LieuChongDong", data.LieuChongDong));
                Command.Parameters.Add(new MDB.MDBParameter("ChiDinhThuoc", data.ChiDinhThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("ChiTiet", JsonConvert.SerializeObject(data.ChiTiet)));
                Command.Parameters.Add(new MDB.MDBParameter("TongSoLanLocMau", data.TongSoLanLocMau));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocEry", data.ThuocEry));
                Command.Parameters.Add(new MDB.MDBParameter("Khac", data.Khac));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuong", data.DieuDuong));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuong", data.MaDieuDuong));
                Command.Parameters.Add(new MDB.MDBParameter("BacSi", data.BacSi));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSi", data.MaBacSi));
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
                string sql = "DELETE FROM PhieuLocMau2 WHERE ID = :ID";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                command.Parameters.Add(new MDB.MDBParameter("ID", id));
                command.BindByName = true;
                int n = command.ExecuteNonQuery();
                return n > 0;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, long id)
        {
            string sql = @"SELECT
                P.*,
                '' MABENHAN,
                '' GIOITINH,
	            '' TENBENHNHAN,
                '' TUOI,
                '' SOYTE,
                '' BENHVIEN,
                '' DIACHI 
            FROM
                PhieuLocMau2 P
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            adt.Fill(ds, "DS");
            if (ds != null || ds.Tables[0].Rows.Count > 0)
            {
                ds.Tables[0].Rows[0]["MaBenhAn"] = XemBenhAn._ThongTinDieuTri.MaBenhAn;
                ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                ds.Tables[0].Rows[0]["TUOI"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                ds.Tables[0].Rows[0]["SoYTe"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
                ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
                ds.Tables[0].Rows[0]["DIACHI"] = Common.GetDiaChi();
            }
            return ds;
        }
    }
}
