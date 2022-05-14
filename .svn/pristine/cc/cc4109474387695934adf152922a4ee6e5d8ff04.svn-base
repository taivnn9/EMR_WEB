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
    public class KhamNghiemTuThi : ThongTinKy
    {
        public KhamNghiemTuThi()
        {
            TableName = "KhamNghiemTuThi";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PKNTT;
            TenMauPhieu = DanhMucPhieu.PKNTT.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        public string DonViYeuCau { get; set; }
        public string HoVaTenNguoiBenh { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        public int Loai { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        public DateTime TuVongLuc { get; set; }
        public string TaiKhoa { get; set; }
        public string NguoiChungKien { get; set; }
        public string MaNguoiChungKien { get; set; }
        public string TomTat { get; set; }
        public string KhoaKhamBenh { get; set; }
        public string KhoaDieuTri { get; set; }
        public string TruocPhauThuat { get; set; }
        public string NguyenNhanTuVong { get; set; }
        public string BenhChinh { get; set; }
        public string BenhKemTheo { get; set; }
        public string BienChung { get; set; }
        public string NguyenNhanTuVong2 { get; set; }
        public string KhamNghiemTongQuat { get; set; }
        public string NoiTiet { get; set; }
        public string ThanKinh { get; set; }
        public string Mat { get; set; }
        public string TaiMuiHong { get; set; }
        public string RangHamMat { get; set; }
        public string TuanHoan { get; set; }
        public string HoHap { get; set; }
        public string TieuHoa { get; set; }
        public string Da { get; set; }
        public string CoXuongKhop { get; set; }
        public string TietNieu { get; set; }
        public string Khac { get; set; }
        public string ChiTietBenhLy { get; set; }
        public string NguoiPha { get; set; }
        public string MaNguoiNguoiPha { get; set; }
        public DateTime NgayPha { get; set; }
        public string SoManh { get; set; }
        public string NguoiLamTieuBan { get; set; }
        public string MaNguoiLamTieuBan { get; set; }
        public string TieuBan { get; set; }
        public string NhuomDacBiet { get; set; }
        public string MoTaDaiThe { get; set; }
        public string KetLuan { get; set; }
        public string XetNghiemViKhuan { get; set; }
        public string XetNghiemDocChat { get; set; }
        public int ChanDoanPhuHop { get; set; }
        public string KetLuanChung { get; set; }
        public string BacSiDocKetQua { get; set; }
        public string MaBacSiDocKetQua { get; set; }
        [MoTaDuLieu("Bác sỹ điều trị")]
		public string BacSiDieuTri { get; set; }
        public string MaBacSiDieuTri { get; set; }
        public DateTime ThoiGian { get; set; }

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

    public class KhamNghiemTuThiFunc
    {
        public const string TableName = "KhamNghiemTuThi";
        public const string TablePrimaryKeyName = "ID";
        public static List<KhamNghiemTuThi> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<KhamNghiemTuThi> list = new List<KhamNghiemTuThi>();
            try
            {
                string sql = @"SELECT * FROM KhamNghiemTuThi where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    KhamNghiemTuThi data = new KhamNghiemTuThi();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.HoVaTenNguoiBenh = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.DiaChi = Common.GetGioiTinh();

                    data.Loai = Common.ConDB_Int(DataReader["Loai"]);
                    data.DiaChi = Common.ConDBNull(DataReader["DiaChi"]);
                    data.TuVongLuc = Common.ConDB_DateTime(DataReader["TuVongLuc"]);
                    data.TaiKhoa = Common.ConDBNull(DataReader["TaiKhoa"]);
                    data.NguoiChungKien = Common.ConDBNull(DataReader["NguoiChungKien"]);
                    data.MaNguoiChungKien = Common.ConDBNull(DataReader["MaNguoiChungKien"]);
                    data.TomTat = Common.ConDBNull(DataReader["TomTat"]);
                    data.KhoaKhamBenh = Common.ConDBNull(DataReader["KhoaKhamBenh"]);
                    data.KhoaDieuTri = Common.ConDBNull(DataReader["KhoaDieuTri"]);
                    data.TruocPhauThuat = Common.ConDBNull(DataReader["TruocPhauThuat"]);
                    data.NguyenNhanTuVong = Common.ConDBNull(DataReader["NguyenNhanTuVong"]);
                    data.BenhChinh = Common.ConDBNull(DataReader["BenhChinh"]);
                    data.BenhKemTheo = Common.ConDBNull(DataReader["BenhKemTheo"]);
                    data.BienChung = Common.ConDBNull(DataReader["BienChung"]);
                    data.NguyenNhanTuVong2 = Common.ConDBNull(DataReader["NguyenNhanTuVong2"]);
                    data.KhamNghiemTongQuat = Common.ConDBNull(DataReader["KhamNghiemTongQuat"]);
                    data.NoiTiet = Common.ConDBNull(DataReader["NoiTiet"]);
                    data.ThanKinh = Common.ConDBNull(DataReader["ThanKinh"]);
                    data.Mat = Common.ConDBNull(DataReader["Mat"]);
                    data.TaiMuiHong = Common.ConDBNull(DataReader["TaiMuiHong"]);
                    data.RangHamMat = Common.ConDBNull(DataReader["RangHamMat"]);
                    data.TuanHoan = Common.ConDBNull(DataReader["TuanHoan"]);
                    data.HoHap = Common.ConDBNull(DataReader["HoHap"]);
                    data.TieuHoa = Common.ConDBNull(DataReader["TieuHoa"]);
                    data.Da = Common.ConDBNull(DataReader["Da"]);
                    data.CoXuongKhop = Common.ConDBNull(DataReader["CoXuongKhop"]);
                    data.TietNieu = Common.ConDBNull(DataReader["TietNieu"]);
                    data.Khac = Common.ConDBNull(DataReader["Khac"]);
                    data.ChiTietBenhLy = Common.ConDBNull(DataReader["ChiTietBenhLy"]);
                    data.NguoiPha = Common.ConDBNull(DataReader["NguoiPha"]);
                    data.MaNguoiNguoiPha = Common.ConDBNull(DataReader["MaNguoiNguoiPha"]);
                    data.NgayPha = Common.ConDB_DateTime(DataReader["NgayPha"]);
                    data.SoManh = Common.ConDBNull(DataReader["SoManh"]);
                    data.NguoiLamTieuBan = Common.ConDBNull(DataReader["NguoiLamTieuBan"]);
                    data.MaNguoiLamTieuBan = Common.ConDBNull(DataReader["MaNguoiLamTieuBan"]);
                    data.TieuBan = Common.ConDBNull(DataReader["TieuBan"]);
                    data.NhuomDacBiet = Common.ConDBNull(DataReader["NhuomDacBiet"]);
                    data.MoTaDaiThe = Common.ConDBNull(DataReader["MoTaDaiThe"]);
                    data.KetLuan = Common.ConDBNull(DataReader["KetLuan"]);
                    data.XetNghiemViKhuan = Common.ConDBNull(DataReader["XetNghiemViKhuan"]);
                    data.XetNghiemDocChat = Common.ConDBNull(DataReader["XetNghiemDocChat"]);
                    data.ChanDoanPhuHop = Common.ConDB_Int(DataReader["ChanDoanPhuHop"]);
                    data.KetLuanChung = Common.ConDBNull(DataReader["KetLuanChung"]);
                    data.BacSiDocKetQua = Common.ConDBNull(DataReader["BacSiDocKetQua"]);
                    data.MaBacSiDocKetQua = Common.ConDBNull(DataReader["MaBacSiDocKetQua"]);
                    data.BacSiDieuTri = Common.ConDBNull(DataReader["BacSiDieuTri"]);
                    data.MaBacSiDieuTri = Common.ConDBNull(DataReader["MaBacSiDieuTri"]);
                    data.ThoiGian = Common.ConDB_DateTime(DataReader["ThoiGian"]);

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref KhamNghiemTuThi data)
        {
            try
            {
                string sql = @"INSERT INTO KhamNghiemTuThi
                (
                    MaQuanLy,
                    MaBenhNhan,
                    Loai,
                    DiaChi,
                    TuVongLuc,
                    TaiKhoa,
                    NguoiChungKien,
                    MaNguoiChungKien,
                    TomTat,
                    KhoaKhamBenh,
                    KhoaDieuTri,
                    TruocPhauThuat,
                    NguyenNhanTuVong,
                    BenhChinh,
                    BenhKemTheo,
                    BienChung,
                    NguyenNhanTuVong2,
                    KhamNghiemTongQuat,
                    NoiTiet,
                    ThanKinh,
                    Mat,
                    TaiMuiHong,
                    RangHamMat,
                    TuanHoan,
                    HoHap,
                    TieuHoa,
                    Da,
                    CoXuongKhop,
                    TietNieu,
                    Khac,
                    ChiTietBenhLy,
                    NguoiPha,
                    MaNguoiNguoiPha,
                    NgayPha,
                    SoManh,
                    NguoiLamTieuBan,
                    MaNguoiLamTieuBan,
                    TieuBan,
                    NhuomDacBiet,
                    MoTaDaiThe,
                    KetLuan,
                    XetNghiemViKhuan,
                    XetNghiemDocChat,
                    ChanDoanPhuHop,
                    KetLuanChung,
                    BacSiDocKetQua,
                    MaBacSiDocKetQua,
                    BacSiDieuTri,
                    MaBacSiDieuTri,
                    ThoiGian,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
                    :MaQuanLy,
                    :MaBenhNhan,
                    :Loai,
                    :DiaChi,
                    :TuVongLuc,
                    :TaiKhoa,
                    :NguoiChungKien,
                    :MaNguoiChungKien,
                    :TomTat,
                    :KhoaKhamBenh,
                    :KhoaDieuTri,
                    :TruocPhauThuat,
                    :NguyenNhanTuVong,
                    :BenhChinh,
                    :BenhKemTheo,
                    :BienChung,
                    :NguyenNhanTuVong2,
                    :KhamNghiemTongQuat,
                    :NoiTiet,
                    :ThanKinh,
                    :Mat,
                    :TaiMuiHong,
                    :RangHamMat,
                    :TuanHoan,
                    :HoHap,
                    :TieuHoa,
                    :Da,
                    :CoXuongKhop,
                    :TietNieu,
                    :Khac,
                    :ChiTietBenhLy,
                    :NguoiPha,
                    :MaNguoiNguoiPha,
                    :NgayPha,
                    :SoManh,
                    :NguoiLamTieuBan,
                    :MaNguoiLamTieuBan,
                    :TieuBan,
                    :NhuomDacBiet,
                    :MoTaDaiThe,
                    :KetLuan,
                    :XetNghiemViKhuan,
                    :XetNghiemDocChat,
                    :ChanDoanPhuHop,
                    :KetLuanChung,
                    :BacSiDocKetQua,
                    :MaBacSiDocKetQua,
                    :BacSiDieuTri,
                    :MaBacSiDieuTri,
                    :ThoiGian,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (data.ID != 0)
                {
                    sql = @"UPDATE KhamNghiemTuThi SET 
                    MaQuanLy=:MaQuanLy,
                    MaBenhNhan=:MaBenhNhan,
                    Loai=:Loai,
                    DiaChi=:DiaChi,
                    TuVongLuc=:TuVongLuc,
                    TaiKhoa=:TaiKhoa,
                    NguoiChungKien=:NguoiChungKien,
                    MaNguoiChungKien=:MaNguoiChungKien,
                    TomTat=:TomTat,
                    KhoaKhamBenh=:KhoaKhamBenh,
                    KhoaDieuTri=:KhoaDieuTri,
                    TruocPhauThuat=:TruocPhauThuat,
                    NguyenNhanTuVong=:NguyenNhanTuVong,
                    BenhChinh=:BenhChinh,
                    BenhKemTheo=:BenhKemTheo,
                    BienChung=:BienChung,
                    NguyenNhanTuVong2=:NguyenNhanTuVong2,
                    KhamNghiemTongQuat=:KhamNghiemTongQuat,
                    NoiTiet=:NoiTiet,
                    ThanKinh=:ThanKinh,
                    Mat=:Mat,
                    TaiMuiHong=:TaiMuiHong,
                    RangHamMat=:RangHamMat,
                    TuanHoan=:TuanHoan,
                    HoHap=:HoHap,
                    TieuHoa=:TieuHoa,
                    Da=:Da,
                    CoXuongKhop=:CoXuongKhop,
                    TietNieu=:TietNieu,
                    Khac=:Khac,
                    ChiTietBenhLy=:ChiTietBenhLy,
                    NguoiPha=:NguoiPha,
                    MaNguoiNguoiPha=:MaNguoiNguoiPha,
                    NgayPha=:NgayPha,
                    SoManh=:SoManh,
                    NguoiLamTieuBan=:NguoiLamTieuBan,
                    MaNguoiLamTieuBan=:MaNguoiLamTieuBan,
                    TieuBan=:TieuBan,
                    NhuomDacBiet=:NhuomDacBiet,
                    MoTaDaiThe=:MoTaDaiThe,
                    KetLuan=:KetLuan,
                    XetNghiemViKhuan=:XetNghiemViKhuan,
                    XetNghiemDocChat=:XetNghiemDocChat,
                    ChanDoanPhuHop=:ChanDoanPhuHop,
                    KetLuanChung=:KetLuanChung,
                    BacSiDocKetQua=:BacSiDocKetQua,
                    MaBacSiDocKetQua=:MaBacSiDocKetQua,
                    BacSiDieuTri=:BacSiDieuTri,
                    MaBacSiDieuTri=:MaBacSiDieuTri,
                    ThoiGian=:ThoiGian,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + data.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", data.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", data.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("Loai", data.Loai));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", data.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("TuVongLuc", data.TuVongLuc));
                Command.Parameters.Add(new MDB.MDBParameter("TaiKhoa", data.TaiKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiChungKien", data.NguoiChungKien));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiChungKien", data.MaNguoiChungKien));
                Command.Parameters.Add(new MDB.MDBParameter("TomTat", data.TomTat));
                Command.Parameters.Add(new MDB.MDBParameter("KhoaKhamBenh", data.KhoaKhamBenh));
                Command.Parameters.Add(new MDB.MDBParameter("KhoaDieuTri", data.KhoaDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TruocPhauThuat", data.TruocPhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("NguyenNhanTuVong", data.NguyenNhanTuVong));
                Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", data.BenhChinh));
                Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", data.BenhKemTheo));
                Command.Parameters.Add(new MDB.MDBParameter("BienChung", data.BienChung));
                Command.Parameters.Add(new MDB.MDBParameter("NguyenNhanTuVong2", data.NguyenNhanTuVong2));
                Command.Parameters.Add(new MDB.MDBParameter("KhamNghiemTongQuat", data.KhamNghiemTongQuat));
                Command.Parameters.Add(new MDB.MDBParameter("NoiTiet", data.NoiTiet));
                Command.Parameters.Add(new MDB.MDBParameter("ThanKinh", data.ThanKinh));
                Command.Parameters.Add(new MDB.MDBParameter("Mat", data.Mat));
                Command.Parameters.Add(new MDB.MDBParameter("TaiMuiHong", data.TaiMuiHong));
                Command.Parameters.Add(new MDB.MDBParameter("RangHamMat", data.RangHamMat));
                Command.Parameters.Add(new MDB.MDBParameter("TuanHoan", data.TuanHoan));
                Command.Parameters.Add(new MDB.MDBParameter("HoHap", data.HoHap));
                Command.Parameters.Add(new MDB.MDBParameter("TieuHoa", data.TieuHoa));
                Command.Parameters.Add(new MDB.MDBParameter("Da", data.Da));
                Command.Parameters.Add(new MDB.MDBParameter("CoXuongKhop", data.CoXuongKhop));
                Command.Parameters.Add(new MDB.MDBParameter("TietNieu", data.TietNieu));
                Command.Parameters.Add(new MDB.MDBParameter("Khac", data.Khac));
                Command.Parameters.Add(new MDB.MDBParameter("ChiTietBenhLy", data.ChiTietBenhLy));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiPha", data.NguoiPha));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiNguoiPha", data.MaNguoiNguoiPha));
                Command.Parameters.Add(new MDB.MDBParameter("NgayPha", data.NgayPha));
                Command.Parameters.Add(new MDB.MDBParameter("SoManh", data.SoManh));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiLamTieuBan", data.NguoiLamTieuBan));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiLamTieuBan", data.MaNguoiLamTieuBan));
                Command.Parameters.Add(new MDB.MDBParameter("TieuBan", data.TieuBan));
                Command.Parameters.Add(new MDB.MDBParameter("NhuomDacBiet", data.NhuomDacBiet));
                Command.Parameters.Add(new MDB.MDBParameter("MoTaDaiThe", data.MoTaDaiThe));
                Command.Parameters.Add(new MDB.MDBParameter("KetLuan", data.KetLuan));
                Command.Parameters.Add(new MDB.MDBParameter("XetNghiemViKhuan", data.XetNghiemViKhuan));
                Command.Parameters.Add(new MDB.MDBParameter("XetNghiemDocChat", data.XetNghiemDocChat));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanPhuHop", data.ChanDoanPhuHop));
                Command.Parameters.Add(new MDB.MDBParameter("KetLuanChung", data.KetLuanChung));
                Command.Parameters.Add(new MDB.MDBParameter("BacSiDocKetQua", data.BacSiDocKetQua));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSiDocKetQua", data.MaBacSiDocKetQua));
                Command.Parameters.Add(new MDB.MDBParameter("BacSiDieuTri", data.BacSiDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSiDieuTri", data.MaBacSiDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGian", data.ThoiGian));
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
                string sql = "DELETE FROM KhamNghiemTuThi WHERE ID = :ID";
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
                KhamNghiemTuThi P
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
