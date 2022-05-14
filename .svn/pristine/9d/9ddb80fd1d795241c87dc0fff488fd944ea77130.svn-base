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
    public class BangKiemTruocKhiTiemDoiVoiTreSoSinh : ThongTinKy
    {
        public BangKiemTruocKhiTiemDoiVoiTreSoSinh()
        {
            TableName = "BangKiemTTCDVTSS";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BKTTCDVTSS;
            TenMauPhieu = DanhMucPhieu.BKTTCDVTSS.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt tiêm khác","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Giới tính trẻ")]
        public string GioiTinh { get; set; }
        [MoTaDuLieu("Họ tên trẻ")]
        public string HoVaTenTre { get; set; }
        [MoTaDuLieu("Ngày sinh trẻ")]
        public DateTime NgaySinhTre { get; set; }
        [MoTaDuLieu("Họ tên bố và mẹ của trẻ")]
        public string HoVaTenBoMe { get; set; }
        [MoTaDuLieu("Địa chỉ bệnh nhân")]
        public string DiaChi { get; set; }
        [MoTaDuLieu("Loại vacxin tiêm cho trẻ")]
        public string LoaiVacXin { get; set; }
        [MoTaDuLieu("Ngày lập phiếu")]
        public DateTime NgayLapPhieu { get; set; }
        [MoTaDuLieu("Ngày tiêm")]
        public DateTime NgayTiem { get; set; }
        public DateTime ThoiGianSauTiem { get; set; }
        [MoTaDuLieu("Bác sỹ điều trị")]
		public string NguoiThucHien { get; set; }
        public string MaNguoiThucHien { get; set; }
        [MoTaDuLieu("Bác sỹ điều trị")]
        public string NguoiTiem { get; set; }
        public string MaNguoiTiem { get; set; }
        [MoTaDuLieu("Bác sỹ điều trị")]
        public string NguoiTheoDoi { get; set; }
        public string MaNguoiTheoDoi { get; set; }
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
        public bool[] SocArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("")]
        public int Soc
        {
            get
            {
                return Array.IndexOf(SocArray, true);
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == value) SocArray[i] = true;
                    else SocArray[i] = false;
                }
            }
        }

        public bool[] BenhCapTinhArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("")]
        public int BenhCapTinh
        {
            get
            {
                return Array.IndexOf(BenhCapTinhArray, true);
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == value) BenhCapTinhArray[i] = true;
                    else BenhCapTinhArray[i] = false;
                }
            }
        }
        public bool[] DangDieuTriArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("")]
        public int DangDieuTri
        {
            get
            {
                return Array.IndexOf(DangDieuTriArray, true);
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == value) DangDieuTriArray[i] = true;
                    else DangDieuTriArray[i] = false;
                }
            }
        }
        public bool[] ThanNhietPTArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("")]
        public int ThanNhiet
        {
            get
            {
                return Array.IndexOf(ThanNhietPTArray, true);
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == value) ThanNhietPTArray[i] = true;
                    else ThanNhietPTArray[i] = false;
                }
            }
        }
        public bool[] NgheTimPTArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("")]
        public int NgheTim
        {
            get
            {
                return Array.IndexOf(NgheTimPTArray, true);
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == value) NgheTimPTArray[i] = true;
                    else NgheTimPTArray[i] = false;
                }
            }
        }
        public bool[] NghePhoiPTArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("")]
        public int NghePhoi
        {
            get
            {
                return Array.IndexOf(NghePhoiPTArray, true);
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == value) NghePhoiPTArray[i] = true;
                    else NghePhoiPTArray[i] = false;
                }
            }
        }
        public bool[] TriGiacPTArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("")]
        public int TriGiac
        {
            get
            {
                return Array.IndexOf(TriGiacPTArray, true);
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == value) TriGiacPTArray[i] = true;
                    else TriGiacPTArray[i] = false;
                }
            }
        }
        public bool[] CanNangPTArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("")]
        public int CanNang
        {
            get
            {
                return Array.IndexOf(CanNangPTArray, true);
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == value) CanNangPTArray[i] = true;
                    else CanNangPTArray[i] = false;
                }
            }
        }
        public bool[] ChongTriDinhPTArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("")]
        public int ChongTriDinh
        {
            get
            {
                return Array.IndexOf(ChongTriDinhPTArray, true);
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == value) ChongTriDinhPTArray[i] = true;
                    else ChongTriDinhPTArray[i] = false;
                }
            }
        }
        [MoTaDuLieu("")]
        public string GhiChuChiDinh { get; set; }
        public bool[] SangLocArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("")]
        public int SangLoc
        {
            get
            {
                return Array.IndexOf(SangLocArray, true);
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == value) SangLocArray[i] = true;
                    else SangLocArray[i] = false;
                }
            }
        }
        [MoTaDuLieu("")]
        public string GhiChuChuyenKhoa { get; set; }
        [MoTaDuLieu("")]
        public string LiDo { get; set; }
        [MoTaDuLieu("")]
        public double? SoCanNang { get; set; }
        [MoTaDuLieu("")]
        public double? SoThanNhiet { get; set; }

        [MoTaDuLieu("")]
        public string KetQua { get; set; }
        [MoTaDuLieu("")]
        public string KetLuan { get; set; }
        [MoTaDuLieu("")]
        public int DuDieuKienTiem { get; set; }

        [MoTaDuLieu("")]
        public bool ChongChiDinh { get; set; }
        [MoTaDuLieu("")]
        public int TamHoanTiemChung { get; set; }
    }

    public class BangKiemTruocKhiTiemDoiVoiTreSoSinhFunc
    {
        public const string TableName = "BangKiemTTCDVTSS";
        public const string TablePrimaryKeyName = "ID";
        public static List<BangKiemTruocKhiTiemDoiVoiTreSoSinh> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BangKiemTruocKhiTiemDoiVoiTreSoSinh> list = new List<BangKiemTruocKhiTiemDoiVoiTreSoSinh>();
            try
            {
                string sql = @"SELECT * FROM BangKiemTTCDVTSS where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    BangKiemTruocKhiTiemDoiVoiTreSoSinh data = new BangKiemTruocKhiTiemDoiVoiTreSoSinh();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.HoVaTenTre = Common.ConDBNull(DataReader["HoVaTenTre"]);
                    data.GioiTinh = Common.ConDBNull(DataReader["GioiTinh"]);
                    data.NgaySinhTre = Common.ConDB_DateTime(DataReader["NgaySinhTre"]);
                    data.DiaChi = Common.ConDBNull(DataReader["DiaChi"]);
                    data.HoVaTenBoMe = Common.ConDBNull(DataReader["HoVaTenBoMe"]);
                    data.LoaiVacXin = Common.ConDBNull(DataReader["LoaiVacXin"]);
                    data.ThanNhiet = Common.ConDB_Int(DataReader["ThanNhiet"]);
                    data.NgheTim = Common.ConDB_Int(DataReader["NgheTim"]);
                    data.NghePhoi = Common.ConDB_Int(DataReader["NghePhoi"]);
                    data.TriGiac = Common.ConDB_Int(DataReader["TriGiac"]);
                    data.CanNang = Common.ConDB_Int(DataReader["CanNang"]);
                    data.ChongTriDinh = Common.ConDB_Int(DataReader["ChongTriDinh"]);
                    data.DuDieuKienTiem = Common.ConDB_Int(DataReader["DuDieuKienTiem"]);
                    data.TamHoanTiemChung = Common.ConDB_Int(DataReader["TamHoanTiemChung"]);
                    data.NgayLapPhieu = Common.ConDB_DateTime(DataReader["NgayLapPhieu"]);
                    data.NgayTiem = Common.ConDB_DateTime(DataReader["NgayTiem"]);
                    data.ThoiGianSauTiem = Common.ConDB_DateTime(DataReader["ThoiGianSauTiem"]);
                    data.NguoiThucHien = Common.ConDBNull(DataReader["NguoiThucHien"]);
                    data.MaNguoiThucHien = Common.ConDBNull(DataReader["MaNguoiThucHien"]);
                    data.NguoiTiem = Common.ConDBNull(DataReader["NguoiTiem"]);
                    data.NguoiTiem = Common.ConDBNull(DataReader["NguoiTiem"]);
                    data.NguoiTheoDoi = Common.ConDBNull(DataReader["NguoiTheoDoi"]);
                    data.MaNguoiTheoDoi = Common.ConDBNull(DataReader["MaNguoiTheoDoi"]);
                    data.NgayTao = Common.ConDB_DateTime(DataReader["NgayTao"]);
                    data.NguoiTao = DataReader["NguoiTao"].ToString();
                    data.NgaySua = Common.ConDB_DateTime(DataReader["NgaySua"]);
                    data.NguoiSua = DataReader["NguoiSua"].ToString();

                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy);
                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BangKiemTruocKhiTiemDoiVoiTreSoSinh data)
        {
            try
            {
                string sql = @"INSERT INTO BangKiemTTCDVTSS
                (
                    MaQuanLy,
                    MaBenhNhan,
                    HoVaTenTre,
                    GioiTinh,
                    NgaySinhTre,
                    DiaChi,
                    HoVaTenBoMe,
                    LoaiVacXin,
                    ThanNhiet,
                    NgheTim,
                    NghePhoi,
                    TriGiac,
                    CanNang,
                    ChongTriDinh,
                    DuDieuKienTiem,
                    TamHoanTiemChung,
                    NgayLapPhieu,
                    NgayTiem,
                    ThoiGianSauTiem,
                    NguoiThucHien,
                    MaNguoiThucHien,
                    NguoiTiem,
                    MaNguoiTiem,
                    NguoiTheoDoi,
                    MaNguoiTheoDoi,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
                    :MaQuanLy,
                    :MaBenhNhan,
                    :HoVaTenTre,
                    :GioiTinh,
                    :NgaySinhTre,
                    :DiaChi,
                    :HoVaTenBoMe,
                    :LoaiVacXin,
                    :ThanNhiet,
                    :NgheTim,
                    :NghePhoi,
                    :TriGiac,
                    :CanNang,
                    :ChongTriDinh,
                    :DuDieuKienTiem,
                    :TamHoanTiemChung,
                    :NgayLapPhieu,
                    :NgayTiem,
                    :ThoiGianSauTiem,
                    :NguoiThucHien,
                    :MaNguoiThucHien,
                    :NguoiTiem,
                    :MaNguoiTiem,
                    :NguoiTheoDoi,
                    :MaNguoiTheoDoi,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (data.ID != 0)
                {
                    sql = @"UPDATE BangKiemTTCDVTSS SET 
                    MaQuanLy=:MaQuanLy,
                    MaBenhNhan=:MaBenhNhan,
                    HoVaTenTre=:HoVaTenTre,
                    GioiTinh=:GioiTinh,
                    NgaySinhTre=:NgaySinhTre,
                    DiaChi=:DiaChi,
                    HoVaTenBoMe=:HoVaTenBoMe,
                    LoaiVacXin=:LoaiVacXin,
                    ThanNhiet=:ThanNhiet,
                    NgheTim=:NgheTim,
                    NghePhoi=:NghePhoi,
                    TriGiac=:TriGiac,
                    CanNang=:CanNang,
                    ChongTriDinh=:ChongTriDinh,
                    DuDieuKienTiem=:DuDieuKienTiem,
                    TamHoanTiemChung=:TamHoanTiemChung,
                    NgayLapPhieu=:NgayLapPhieu,
                    NgayTiem=:NgayTiem,
                    ThoiGianSauTiem=:ThoiGianSauTiem,
                    NguoiThucHien=:NguoiThucHien,
                    MaNguoiThucHien=:MaNguoiThucHien,
                    NguoiTiem=:NguoiTiem,
                    MaNguoiTiem=:MaNguoiTiem,
                    NguoiTheoDoi=:NguoiTheoDoi,
                    MaNguoiTheoDoi=:MaNguoiTheoDoi,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + data.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", data.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", data.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("HoVaTenTre", data.HoVaTenTre));
                Command.Parameters.Add(new MDB.MDBParameter("GioiTinh", data.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("NgaySinhTre", data.NgaySinhTre));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", data.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("HoVaTenBoMe", data.HoVaTenBoMe));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiVacXin", data.LoaiVacXin));
                Command.Parameters.Add(new MDB.MDBParameter("ThanNhiet", data.ThanNhiet));
                Command.Parameters.Add(new MDB.MDBParameter("NgheTim", data.NgheTim));
                Command.Parameters.Add(new MDB.MDBParameter("NghePhoi", data.NghePhoi));
                Command.Parameters.Add(new MDB.MDBParameter("TriGiac", data.TriGiac));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang", data.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("ChongTriDinh", data.ChongTriDinh));
                Command.Parameters.Add(new MDB.MDBParameter("DuDieuKienTiem", data.DuDieuKienTiem));
                Command.Parameters.Add(new MDB.MDBParameter("TamHoanTiemChung", data.TamHoanTiemChung));
                Command.Parameters.Add(new MDB.MDBParameter("NgayLapPhieu", data.NgayLapPhieu));
                Command.Parameters.Add(new MDB.MDBParameter("NgayTiem", data.NgayTiem));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianSauTiem", data.ThoiGianSauTiem));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiThucHien", data.NguoiThucHien));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiThucHien", data.MaNguoiThucHien));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiTiem", data.NguoiTiem));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiTiem", data.MaNguoiTiem));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiTheoDoi", data.NguoiTheoDoi));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiTheoDoi", data.MaNguoiTheoDoi));
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
                    data.ID = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
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
                string sql = "DELETE FROM BangKiemTTCDVTSS WHERE ID = :ID";
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
        public static DataSet getDataSet(MDB.MDBConnection MyConnection, long id)
        {
            string sql = @"SELECT
                P.*,
                H.GIOITINH,
	            H.TENBENHNHAN,
                H.TUOI,
                H.SOYTE,
                H.BENHVIEN,
                (H.SONHA || ',' || H.THONPHO || ',' ||  H.XAPHUONG || ',' ||  H.HUYENQUAN || ',' ||  H.TINHTHANHPHO) AS DIACHI 
            FROM
                BangKiemTTCDVTSS P
                LEFT JOIN THONGTINDIEUTRI T ON P.MAQUANLY = T.MAQUANLY
                LEFT JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            adt.Fill(ds, "Table");
            return ds;
        }
    }
}
