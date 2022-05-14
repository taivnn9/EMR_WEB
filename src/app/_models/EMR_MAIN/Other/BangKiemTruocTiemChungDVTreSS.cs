
using EMR.KyDienTu;
using System;
using System.Collections.Generic;
using System.Data;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class BangKiemTruocTiemChungDVTreSS : ThongTinKy
    {
        public BangKiemTruocTiemChungDVTreSS()
        {
            TableName = "BangKiemTruocTiemChungDVTreSS";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BKTTCDVTSS2;
            TenMauPhieu = DanhMucPhieu.BKTTCDVTSS2.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        public string HoVaTenTre { get; set; }
        public string GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; }
        public DateTime? NgaySinh_Gio { get; set; }
        public string TuoiThaiKhiSinh { get; set; }
        public string DiaChi { get; set; }
        public string TenBoMe { get; set; }
        public string DienThoai { get; set; }
        public string CanNang { get; set; }
        public string ThanNhiet { get; set; }
        public int HBSAG { get; set; }
        public int KQHBSAG { get; set; }
        public int KhamSangLoc1 { get; set; }
        public int KhamSangLoc2 { get; set; }
        public int KhamSangLoc3 { get; set; }
        public int KhamSangLoc4 { get; set; }
        public int KhamSangLoc5 { get; set; }
        public int KhamSangLoc6 { get; set; }
        public int KhamSangLoc7 { get; set; }
        public int KhamSangLoc8 { get; set; }
        public int KhamSangLoc9 { get; set; }
        public string KhamLamSang9_txt { get; set; }
        public int KhamSLTheoChuyenKhoa { get; set; }
        public string KhamSLTheoCK_txt { get; set; }
        public string LyDo { get; set; }
        public string KetQua { get; set; }
        public string KetLuan { get; set; }
        public int KetLuanDKTiemChung { get; set; }
        public string LoaiVacXinTC { get; set; }
		public int ChongCDTC { get; set; }
        public int TamHoanTC { get; set; }
        public DateTime? NgayKyBB { get; set; }
        public DateTime? NgayKyBB_Gio { get; set; }
        public string MaNguoiTHSL { get; set; }
        public string NguoiTHSL { get; set; }
        public string NguoiTao { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
        public string NguoiSua { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
        public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
        public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
        public bool Chon { get; set; }
        //public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
        public bool DaKy { get; set; }
    }
    public class BangKiemTruocTiemChungDVTreSSFunc
    {
        public const string TableName = "BangKiemTruocTiemChungDVTreSS";
        public const string TablePrimaryKeyName = "ID";

        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BangKiemTruocTiemChungDVTreSS ketQua)
        {
            try
            {
                string sql = @"INSERT INTO BangKiemTruocTiemChungDVTreSS
                (
                    MaQuanLy,
                    HoVaTenTre,
                    GioiTinh,
                    NgaySinh,
                    TuoiThaiKhiSinh,
                    DiaChi,
                    TenBoMe,
                    DienThoai,
                    CanNang,
                    ThanNhiet,
                    HBSAG,
                    KQHBSAG,
                    KhamSangLoc1,
                    KhamSangLoc2,
                    KhamSangLoc3,
                    KhamSangLoc4,
                    KhamSangLoc5,
                    KhamSangLoc6,
                    KhamSangLoc7,
                    KhamSangLoc8,
                    KhamSangLoc9,
                    KhamLamSang9_txt,
                    KhamSLTheoChuyenKhoa,
                    KhamSLTheoCK_txt,
                    LyDo,
                    KetQua,
                    KetLuan,
                    KetLuanDKTiemChung,
                    LoaiVacXinTC,
                    ChongCDTC,
                    TamHoanTC,
                    NgayKyBB,
                    MaNguoiTHSL,
                    NguoiTHSL,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
                    :MaQuanLy,
                    :HoVaTenTre,
                    :GioiTinh,
                    :NgaySinh,
                    :TuoiThaiKhiSinh,
                    :DiaChi,
                    :TenBoMe,
                    :DienThoai,
                    :CanNang,
                    :ThanNhiet,
                    :HBSAG,
                    :KQHBSAG,
                    :KhamSangLoc1,
                    :KhamSangLoc2,
                    :KhamSangLoc3,
                    :KhamSangLoc4,
                    :KhamSangLoc5,
                    :KhamSangLoc6,
                    :KhamSangLoc7,
                    :KhamSangLoc8,
                    :KhamSangLoc9,
                    :KhamLamSang9_txt,
                    :KhamSLTheoChuyenKhoa,
                    :KhamSLTheoCK_txt,
                    :LyDo,
                    :KetQua,
                    :KetLuan,
                    :KetLuanDKTiemChung,
                    :LoaiVacXinTC,
                    :ChongCDTC,
                    :TamHoanTC,
                    :NgayKyBB,
                    :MaNguoiTHSL,
                    :NguoiTHSL,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE BangKiemTruocTiemChungDVTreSS SET  
                    MaQuanLy=:MaQuanLy,
                    HoVaTenTre=:HoVaTenTre,
                    GioiTinh=:GioiTinh,
                    NgaySinh=:NgaySinh,
                    TuoiThaiKhiSinh=:TuoiThaiKhiSinh,
                    DiaChi=:DiaChi,
                    TenBoMe=:TenBoMe,
                    DienThoai=:DienThoai,
                    CanNang=:CanNang,
                    ThanNhiet=:ThanNhiet,
                    HBSAG=:HBSAG,
                    KQHBSAG=:KQHBSAG,
                    KhamSangLoc1=:KhamSangLoc1,
                    KhamSangLoc2=:KhamSangLoc2,
                    KhamSangLoc3=:KhamSangLoc3,
                    KhamSangLoc4=:KhamSangLoc4,
                    KhamSangLoc5=:KhamSangLoc5,
                    KhamSangLoc6=:KhamSangLoc6,
                    KhamSangLoc7=:KhamSangLoc7,
                    KhamSangLoc8=:KhamSangLoc8,
                    KhamSangLoc9=:KhamSangLoc9,
                    KhamLamSang9_txt=:KhamLamSang9_txt,
                    KhamSLTheoChuyenKhoa=:KhamSLTheoChuyenKhoa,
                    KhamSLTheoCK_txt=:KhamSLTheoCK_txt,
                    LyDo=:LyDo,
                    KetQua=:KetQua,
                    KetLuan=:KetLuan,
                    KetLuanDKTiemChung=:KetLuanDKTiemChung,
                    LoaiVacXinTC=:LoaiVacXinTC,
                    ChongCDTC=:ChongCDTC,
                    TamHoanTC=:TamHoanTC,
                    NgayKyBB=:NgayKyBB,
                    MaNguoiTHSL=:MaNguoiTHSL,
                    NguoiTHSL=:NguoiTHSL,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("HoVaTenTre", ketQua.HoVaTenTre));
                Command.Parameters.Add(new MDB.MDBParameter("GioiTinh", ketQua.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("NgaySinh", ketQua.NgaySinh));
                Command.Parameters.Add(new MDB.MDBParameter("TuoiThaiKhiSinh", ketQua.TuoiThaiKhiSinh));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", ketQua.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("TenBoMe", ketQua.TenBoMe));
                Command.Parameters.Add(new MDB.MDBParameter("DienThoai", ketQua.DienThoai));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang", ketQua.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("ThanNhiet", ketQua.ThanNhiet));
                Command.Parameters.Add(new MDB.MDBParameter("HBSAG", ketQua.HBSAG));
                Command.Parameters.Add(new MDB.MDBParameter("KQHBSAG", ketQua.KQHBSAG));
                Command.Parameters.Add(new MDB.MDBParameter("KhamSangLoc1", ketQua.KhamSangLoc1));
                Command.Parameters.Add(new MDB.MDBParameter("KhamSangLoc2", ketQua.KhamSangLoc2));
                Command.Parameters.Add(new MDB.MDBParameter("KhamSangLoc3", ketQua.KhamSangLoc3));
                Command.Parameters.Add(new MDB.MDBParameter("KhamSangLoc4", ketQua.KhamSangLoc4));
                Command.Parameters.Add(new MDB.MDBParameter("KhamSangLoc5", ketQua.KhamSangLoc5));
                Command.Parameters.Add(new MDB.MDBParameter("KhamSangLoc6", ketQua.KhamSangLoc6));
                Command.Parameters.Add(new MDB.MDBParameter("KhamSangLoc7", ketQua.KhamSangLoc7));
                Command.Parameters.Add(new MDB.MDBParameter("KhamSangLoc8", ketQua.KhamSangLoc8));
                Command.Parameters.Add(new MDB.MDBParameter("KhamSangLoc9", ketQua.KhamSangLoc9));
                Command.Parameters.Add(new MDB.MDBParameter("KhamLamSang9_txt", ketQua.KhamLamSang9_txt));
                Command.Parameters.Add(new MDB.MDBParameter("KhamSLTheoChuyenKhoa", ketQua.KhamSLTheoChuyenKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("KhamSLTheoCK_txt", ketQua.KhamSLTheoCK_txt));
                Command.Parameters.Add(new MDB.MDBParameter("LyDo", ketQua.LyDo));
                Command.Parameters.Add(new MDB.MDBParameter("KetQua", ketQua.KetQua));
                Command.Parameters.Add(new MDB.MDBParameter("KetLuan", ketQua.KetLuan));
                Command.Parameters.Add(new MDB.MDBParameter("KetLuanDKTiemChung", ketQua.KetLuanDKTiemChung));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiVacXinTC", ketQua.LoaiVacXinTC));
                Command.Parameters.Add(new MDB.MDBParameter("ChongCDTC", ketQua.ChongCDTC));
                Command.Parameters.Add(new MDB.MDBParameter("TamHoanTC", ketQua.TamHoanTC));
                Command.Parameters.Add(new MDB.MDBParameter("NgayKyBB", ketQua.NgayKyBB));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiTHSL", ketQua.MaNguoiTHSL));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiTHSL", ketQua.NguoiTHSL));
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
        public static List<BangKiemTruocTiemChungDVTreSS> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BangKiemTruocTiemChungDVTreSS> list = new List<BangKiemTruocTiemChungDVTreSS>();
            try
            {
                string sql = @"SELECT * FROM BangKiemTruocTiemChungDVTreSS where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    BangKiemTruocTiemChungDVTreSS obj = new BangKiemTruocTiemChungDVTreSS();
                    obj.ID = DataReader.GetLong("ID");
                    obj.MaQuanLy = DataReader.GetDecimal("MaQuanLy");
                    obj.HoVaTenTre = DataReader["HoVaTenTre"].ToString();
                    obj.GioiTinh = DataReader["GioiTinh"].ToString();
                    obj.NgaySinh = Common.ConDB_DateTime(DataReader["NgaySinh"]);
                    obj.NgaySinh_Gio = obj.NgaySinh;
                    obj.TuoiThaiKhiSinh = DataReader["TuoiThaiKhiSinh"].ToString();
                    obj.DiaChi = DataReader["DiaChi"].ToString();
                    obj.TenBoMe = DataReader["TenBoMe"].ToString();
                    obj.DienThoai = DataReader["DienThoai"].ToString();
                    obj.CanNang = DataReader["CanNang"].ToString();
                    obj.ThanNhiet = DataReader["ThanNhiet"].ToString();
                    obj.HBSAG = DataReader.GetInt("HBSAG");
                    obj.KQHBSAG = DataReader.GetInt("KQHBSAG");
                    obj.KhamSangLoc1 = DataReader.GetInt("KhamSangLoc1");
                    obj.KhamSangLoc2 = DataReader.GetInt("KhamSangLoc2");
                    obj.KhamSangLoc3 = DataReader.GetInt("KhamSangLoc3");
                    obj.KhamSangLoc4 = DataReader.GetInt("KhamSangLoc4");
                    obj.KhamSangLoc5 = DataReader.GetInt("KhamSangLoc5");
                    obj.KhamSangLoc6 = DataReader.GetInt("KhamSangLoc6");
                    obj.KhamSangLoc7 = DataReader.GetInt("KhamSangLoc7");
                    obj.KhamSangLoc8 = DataReader.GetInt("KhamSangLoc8");
                    obj.KhamSangLoc9 = DataReader.GetInt("KhamSangLoc9");
                    obj.KhamLamSang9_txt = DataReader["KhamLamSang9_txt"].ToString();
                    obj.KhamSLTheoChuyenKhoa = DataReader.GetInt("KhamSLTheoChuyenKhoa");
                    obj.KhamSLTheoCK_txt = DataReader["KhamSLTheoCK_txt"].ToString();
                    obj.LyDo = DataReader["LyDo"].ToString();
                    obj.KetQua = DataReader["KetQua"].ToString();
                    obj.KetLuan = DataReader["KetLuan"].ToString();
                    obj.KetLuanDKTiemChung = DataReader.GetInt("KetLuanDKTiemChung");
                    obj.LoaiVacXinTC = DataReader["LoaiVacXinTC"].ToString();
                    obj.ChongCDTC = DataReader.GetInt("ChongCDTC");
                    obj.TamHoanTC = DataReader.GetInt("TamHoanTC");
                    obj.NgayKyBB = Common.ConDB_DateTime(DataReader["NgayKyBB"]);
                    obj.MaNguoiTHSL = DataReader["MaNguoiTHSL"].ToString();
                    obj.NguoiTHSL = DataReader["NguoiTHSL"].ToString();
                    obj.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                    obj.NguoiTao = DataReader["NguoiTao"].ToString();
                    obj.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);
                    obj.NguoiSua = DataReader["NguoiSua"].ToString();
                    obj.MaSoKy = DataReader["masokyten"].ToString();
                    obj.DaKy = !string.IsNullOrEmpty(obj.MaSoKy) ? true : false;
                    list.Add(obj);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool delete(MDB.MDBConnection MyConnection, long id)
        {
            try
            {
                string sql = "DELETE FROM BangKiemTruocTiemChungDVTreSS WHERE ID = :ID";
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
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, long IDBienBan)
        {
            string sql = @"SELECT
                D.*,
	            T.MABENHNHAN,
	            H.SOYTE,
	            H.BENHVIEN
            FROM
                BangKiemTruocTiemChungDVTreSS D
                LEFT JOIN THONGTINDIEUTRI T ON D.MAQUANLY = T.MAQUANLY
                LEFT JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
            WHERE
                ID = " + IDBienBan;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            adt.Fill(ds, "TB");
            return ds;
        }
    }
}
