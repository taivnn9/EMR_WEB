using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuXetNghiemXpertXpress : ThongTinKy
    {
        public PhieuXetNghiemXpertXpress()
        {
            TableName = "PhieuXetNghiemXpertXpress";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PXNXXS;
            TenMauPhieu = DanhMucPhieu.PXNXXS.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        public string HoVaTenNguoiBenh { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        public bool[] BenhPhamArray { get; } = new bool[] { false, false, false };
        public string BenhPham
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < BenhPhamArray.Length; i++)
                    temp += (BenhPhamArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        BenhPhamArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string BenhPham_Khac { get; set; }
        public string Thon { get; set; }
        public string XaPhuong { get; set; }
        public string QuanHuyen { get; set; }
        public string Tinh { get; set; }
        public string DienThoai { get; set; }
        [MoTaDuLieu("Bệnh viện")]
		public string BenhVien { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }
        public DateTime? NgayLayMau { get; set; }
        public string NguoiLayMau { get; set; }
        public string MaNguoiLayMau { get; set; }
        public int? LanThucHienThu { get; set; }
        public bool[] PhanLoaiA_Array { get; } = new bool[] { false, false, false, false };
        public string PhanLoaiA
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < PhanLoaiA_Array.Length; i++)
                    temp += (PhanLoaiA_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        PhanLoaiA_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string PhanLoaiA_Khac { get; set; }
        public bool[] PhanLoaiB_Array { get; } = new bool[] { false, false, false };
        public string PhanLoaiB
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < PhanLoaiB_Array.Length; i++)
                    temp += (PhanLoaiB_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        PhanLoaiB_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string PhanLoaiB_Khac { get; set; }
        public string BacSyKhamBenh { get; set; }
        public string MaBacSyKhamBenh { get; set; }
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
    public class PhieuXetNghiemXpertXpressFunc
    {
        public const string TableName = "PhieuXetNghiemXpertXpress";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuXetNghiemXpertXpress> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuXetNghiemXpertXpress> list = new List<PhieuXetNghiemXpertXpress>();
            try
            {
                string sql = @"SELECT * FROM PhieuXetNghiemXpertXpress where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuXetNghiemXpertXpress data = new PhieuXetNghiemXpertXpress();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.HoVaTenNguoiBenh = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.BenhPham_Khac = DataReader["BenhPham_Khac"].ToString();
                    data.Thon = DataReader["Thon"].ToString();
                    data.XaPhuong = DataReader["XaPhuong"].ToString();
                    data.QuanHuyen = DataReader["QuanHuyen"].ToString();
                    data.Tinh = DataReader["Tinh"].ToString();
                    data.DienThoai = DataReader["DienThoai"].ToString();
                    data.BenhPham = DataReader["BenhPham"].ToString();
                    data.BenhVien = DataReader["BenhVien"].ToString();
                    data.Khoa = DataReader["Khoa"].ToString();
                    data.MaKhoa = DataReader["MaKhoa"].ToString();
                    DateTime tempNgay;
                    data.NgayLayMau = DateTime.TryParse(DataReader["NgayLayMau"].ToString(), out tempNgay) ? (DateTime?) tempNgay: null;
                    data.NguoiLayMau = DataReader["NguoiLayMau"].ToString();
                    data.MaNguoiLayMau = DataReader["MaNguoiLayMau"].ToString();

                    int tempInt = 0;
                    data.LanThucHienThu = int.TryParse(DataReader["LanThucHienThu"].ToString(), out tempInt) ? (int?)tempInt : null;

                    data.PhanLoaiA =DataReader["PhanLoaiA"].ToString();
                    data.PhanLoaiA_Khac = DataReader["PhanLoaiA_Khac"].ToString();

                    data.PhanLoaiB =DataReader["PhanLoaiB"].ToString();
                    data.PhanLoaiB_Khac = DataReader["PhanLoaiB_Khac"].ToString();

                    data.BacSyKhamBenh = DataReader["BacSyKhamBenh"].ToString();
                    data.MaBacSyKhamBenh = DataReader["MaBacSyKhamBenh"].ToString();

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuXetNghiemXpertXpress ketQua)
        {
            try
            {
                string sql = @"INSERT INTO PhieuXetNghiemXpertXpress
                (
                    MAQUANLY,
                    MaBenhNhan,
                    BenhPham_Khac,
                    Thon,
                    XaPhuong,
                    QuanHuyen,
                    Tinh,
                    DienThoai,
                    BenhPham,
                    BenhVien,
                    Khoa,
                    MaKhoa,
                    NgayLayMau,
                    NguoiLayMau,
                    MaNguoiLayMau,
                    LanThucHienThu,
                    PhanLoaiA,
                    PhanLoaiA_Khac,
                    PhanLoaiB,
                    PhanLoaiB_Khac,
                    BacSyKhamBenh,
                    MaBacSyKhamBenh,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :BenhPham_Khac,
                    :Thon,
                    :XaPhuong,
                    :QuanHuyen,
                    :Tinh,
                    :DienThoai,
                    :BenhPham,
                    :BenhVien,
                    :Khoa,
                    :MaKhoa,
                    :NgayLayMau,
                    :NguoiLayMau,
                    :MaNguoiLayMau,
                    :LanThucHienThu,
                    :PhanLoaiA,
                    :PhanLoaiA_Khac,
                    :PhanLoaiB,
                    :PhanLoaiB_Khac,
                    :BacSyKhamBenh,
                    :MaBacSyKhamBenh,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE PhieuXetNghiemXpertXpress SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    BenhPham_Khac = :BenhPham_Khac,
                    Thon = :Thon,
                    XaPhuong = :XaPhuong,
                    QuanHuyen = :QuanHuyen,
                    Tinh = :Tinh,
                    DienThoai = :DienThoai,
                    BenhPham = :BenhPham,
                    BenhVien = :BenhVien,
                    Khoa = :Khoa,
                    MaKhoa = :MaKhoa,
                    NgayLayMau = :NgayLayMau,
                    NguoiLayMau = :NguoiLayMau,
                    MaNguoiLayMau = :MaNguoiLayMau,
                    LanThucHienThu = :LanThucHienThu,
                    PhanLoaiA = :PhanLoaiA,
                    PhanLoaiA_Khac = :PhanLoaiA_Khac,
                    PhanLoaiB = :PhanLoaiB,
                    PhanLoaiB_Khac = :PhanLoaiB_Khac,
                    BacSyKhamBenh = :BacSyKhamBenh,
                    MaBacSyKhamBenh = :MaBacSyKhamBenh,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ketQua.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("BenhPham_Khac", ketQua.BenhPham_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("Thon", ketQua.Thon));
                Command.Parameters.Add(new MDB.MDBParameter("XaPhuong", ketQua.XaPhuong));
                Command.Parameters.Add(new MDB.MDBParameter("QuanHuyen", ketQua.QuanHuyen));
                Command.Parameters.Add(new MDB.MDBParameter("Tinh", ketQua.Tinh));
                Command.Parameters.Add(new MDB.MDBParameter("DienThoai", ketQua.DienThoai));
                Command.Parameters.Add(new MDB.MDBParameter("BenhPham", ketQua.BenhPham));
                Command.Parameters.Add(new MDB.MDBParameter("BenhVien", ketQua.BenhVien));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa", ketQua.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaKhoa", ketQua.MaKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("NgayLayMau", ketQua.NgayLayMau));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiLayMau", ketQua.NguoiLayMau));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiLayMau", ketQua.MaNguoiLayMau));
                Command.Parameters.Add(new MDB.MDBParameter("LanThucHienThu", ketQua.LanThucHienThu));
                Command.Parameters.Add(new MDB.MDBParameter("PhanLoaiA", ketQua.PhanLoaiA));
                Command.Parameters.Add(new MDB.MDBParameter("PhanLoaiA_Khac", ketQua.PhanLoaiA_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("PhanLoaiB", ketQua.PhanLoaiB));
                Command.Parameters.Add(new MDB.MDBParameter("PhanLoaiB_Khac", ketQua.PhanLoaiB_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyKhamBenh", ketQua.BacSyKhamBenh));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSyKhamBenh", ketQua.MaBacSyKhamBenh));
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
        public static bool delete(MDB.MDBConnection MyConnection, long id)
        {
            try
            {
                string sql = "DELETE FROM PhieuXetNghiemXpertXpress WHERE ID = :ID";
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
                PhieuXetNghiemXpertXpress P
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "KQ");

            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));
            ds.Tables[0].AddColumn("NamSinh", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(int));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["NamSinh"] = XemBenhAn._HanhChinhBenhNhan.NgaySinh.HasValue ? XemBenhAn._HanhChinhBenhNhan.NgaySinh.Value.Year + "" : "";
            ds.Tables[0].Rows[0]["GioiTinh"] = (int)XemBenhAn._HanhChinhBenhNhan.GioiTinh;

            return ds;
        }
    }
}
