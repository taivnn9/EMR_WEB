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
    public class PhieuKhamGayMeTruocPTTT : ThongTinKy
    {
        public PhieuKhamGayMeTruocPTTT()
        {
            TableName = "PhieuKhamGayMeTruocPTTT";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PKGMTPTTT;
            TenMauPhieu = DanhMucPhieu.PKGMTPTTT.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        public DateTime? NgayKham { get; set; }
        [MoTaDuLieu("Mã bác sỹ")]
		public string MaBacSi { get; set; }
        [MoTaDuLieu("Họ tên bác sỹ")]
		public string BacSi { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Nhóm máu")]
		public string NhomMau { get; set; }
        [MoTaDuLieu("Cân nặng")]
		public string CanNang { get; set; }
        [MoTaDuLieu("Chiều cao")]
		public string ChieuCao { get; set; }
        public string ASA { get; set; }
        public string Mallampati { get; set; }
        public string KcCamGiap { get; set; }
        // tien su benh nhan
        public string HaMieng { get; set; }
        public bool[] RangGiaArray { get; } = new bool[] { false, false, false };
        public string RangGia
        {
            get
            {
                string temp = "";
                for (int i = 0; i < RangGiaArray.Length; i++)
                    temp += (RangGiaArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        RangGiaArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string GioAn { get; set; }
        public bool[] LoaiMoArray { get; } = new bool[] { false, false };
        public string LoaiMo
        {
            get
            {
                string temp = "";
                for (int i = 0; i < LoaiMoArray.Length; i++)
                    temp += (LoaiMoArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        LoaiMoArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public string HuongXuTri { get; set; }
        public string TienSuNoiKhoa { get; set; }
        public string TienSuNgoaiKhoa { get; set; }
        public string TienSuGayMe { get; set; }
        public string DiUng { get; set; }
        public bool[] NghienArray { get; } = new bool[] { false, false, false };
        public string Nghien
        {
            get
            {
                string temp = "";
                for (int i = 0; i < NghienArray.Length; i++)
                    temp += (NghienArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NghienArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string BenhLayNhiem { get; set; }
        public string ThuocDangDieuTri { get; set; }
        public string KhamLamSang { get; set; }
        public string TuanHoan { get; set; }
        [MoTaDuLieu("Mạch")]
		public string Mach { get; set; }
        [MoTaDuLieu("Huyết áp")]
		public string HA { get; set; }
        public string HoHap { get; set; }
        public string ThanKinh { get; set; }
        public string CotSong { get; set; }
        public string XetNghiemBatThuong { get; set; }
        public string YeuCauBoSung { get; set; }
        public string DuKienCachThuc { get; set; }
        public string DuKienGiamDau { get; set; }
        public string YLenhTruocMo { get; set; }
        public string TienThuocMe { get; set; }
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
    public class PhieuKhamGayMeTruocPTTTFunc
    {
        public const string TableName = "PhieuKhamGayMeTruocPTTT";
        public const string TablePrimaryKeyName = "ID";
        public const string MaPhieu = "PKTGM";
        public static List<PhieuKhamGayMeTruocPTTT> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuKhamGayMeTruocPTTT> list = new List<PhieuKhamGayMeTruocPTTT>();
            try
            {
                string sql = @"SELECT * FROM PhieuKhamGayMeTruocPTTT where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuKhamGayMeTruocPTTT data = new PhieuKhamGayMeTruocPTTT();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.NgayKham = DataReader["NgayKham"] == DBNull.Value ? (DateTime?) null : DataReader.GetDate("NgayKham");
                    data.MaBacSi = DataReader["MaBacSi"].ToString();
                    data.BacSi = DataReader["BacSi"].ToString();
                    data.TenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.NhomMau = DataReader["NhomMau"].ToString();
                    data.CanNang = DataReader["CanNang"].ToString();
                    data.ChieuCao = DataReader["ChieuCao"].ToString();
                    data.ASA = DataReader["ASA"].ToString();
                    data.Mallampati = DataReader["Mallampati"].ToString();
                    data.KcCamGiap = DataReader["KcCamGiap"].ToString();
                    data.HaMieng = DataReader["HaMieng"].ToString();
                    data.RangGia = DataReader["RangGia"].ToString();
                    data.GioAn = DataReader["GioAn"].ToString();
                    data.LoaiMo = DataReader["LoaiMo"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.HuongXuTri = DataReader["HuongXuTri"].ToString();
                    data.TienSuNoiKhoa = DataReader["TienSuNoiKhoa"].ToString();
                    data.TienSuNgoaiKhoa = DataReader["TienSuNgoaiKhoa"].ToString();
                    data.TienSuGayMe = DataReader["TienSuGayMe"].ToString();
                    data.DiUng = DataReader["DiUng"].ToString();
                    data.Nghien = DataReader["Nghien"].ToString();
                    data.BenhLayNhiem = DataReader["BenhLayNhiem"].ToString();
                    data.ThuocDangDieuTri = DataReader["ThuocDangDieuTri"].ToString();
                    data.KhamLamSang = DataReader["KhamLamSang"].ToString();
                    data.TuanHoan = DataReader["TuanHoan"].ToString();
                    data.Mach = DataReader["Mach"].ToString();
                    data.HA = DataReader["HA"].ToString();
                    data.HoHap = DataReader["HoHap"].ToString();
                    data.ThanKinh = DataReader["ThanKinh"].ToString();
                    data.CotSong = DataReader["CotSong"].ToString();
                    data.XetNghiemBatThuong = DataReader["XetNghiemBatThuong"].ToString();
                    data.YeuCauBoSung = DataReader["YeuCauBoSung"].ToString();
                    data.DuKienCachThuc = DataReader["DuKienCachThuc"].ToString();
                    data.DuKienGiamDau = DataReader["DuKienGiamDau"].ToString();
                    data.YLenhTruocMo = DataReader["YLenhTruocMo"].ToString();
                    data.TienThuocMe = DataReader["TienThuocMe"].ToString();

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuKhamGayMeTruocPTTT bangKiem)
        {
            try
            {
                string sql = @"INSERT INTO PhieuKhamGayMeTruocPTTT
                (
                    MAQUANLY,
                    MaBenhNhan,
                    NgayKham,
                    MaBacSi,
                    BacSi,
                    NhomMau,
                    CanNang,
                    ChieuCao,
                    ASA,
                    Mallampati,
                    KcCamGiap,
                    HaMieng,
                    RangGia,
                    GioAn,
                    LoaiMo,
                    ChanDoan,
                    HuongXuTri,
                    TienSuNoiKhoa,
                    TienSuNgoaiKhoa,
                    TienSuGayMe,
                    DiUng,
                    Nghien,
                    BenhLayNhiem,
                    ThuocDangDieuTri,
                    KhamLamSang,
                    TuanHoan,
                    Mach,
                    HA,
                    HoHap,
                    ThanKinh,
                    CotSong,
                    XetNghiemBatThuong,
                    YeuCauBoSung,
                    DuKienCachThuc,
                    DuKienGiamDau,
                    YLenhTruocMo,
                    TienThuocMe,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :NgayKham,
                    :MaBacSi,
                    :BacSi,
                    :NhomMau,
                    :CanNang,
                    :ChieuCao,
                    :ASA,
                    :Mallampati,
                    :KcCamGiap,
                    :HaMieng,
                    :RangGia,
                    :GioAn,
                    :LoaiMo,
                    :ChanDoan,
                    :HuongXuTri,
                    :TienSuNoiKhoa,
                    :TienSuNgoaiKhoa,
                    :TienSuGayMe,
                    :DiUng,
                    :Nghien,
                    :BenhLayNhiem,
                    :ThuocDangDieuTri,
                    :KhamLamSang,
                    :TuanHoan,
                    :Mach,
                    :HA,
                    :HoHap,
                    :ThanKinh,
                    :CotSong,
                    :XetNghiemBatThuong,
                    :YeuCauBoSung,
                    :DuKienCachThuc,
                    :DuKienGiamDau,
                    :YLenhTruocMo,
                    :TienThuocMe,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (bangKiem.ID != 0)
                {
                    sql = @"UPDATE PhieuKhamGayMeTruocPTTT SET 
                    MAQUANLY = :MAQUANLY,
					MaBenhNhan = :MaBenhNhan,
                    NgayKham = :NgayKham,
                    MaBacSi = :MaBacSi,
                    BacSi = :BacSi,
                    NhomMau = :NhomMau,
                    CanNang = :CanNang,
                    ChieuCao = :ChieuCao,
                    ASA = :ASA,
                    Mallampati = :Mallampati,
                    KcCamGiap = :KcCamGiap,
                    HaMieng = :HaMieng,
                    RangGia = :RangGia,
                    GioAn = :GioAn,
                    LoaiMo = :LoaiMo,
                    ChanDoan = :ChanDoan,
                    HuongXuTri = :HuongXuTri,
                    TienSuNoiKhoa = :TienSuNoiKhoa,
                    TienSuNgoaiKhoa = :TienSuNgoaiKhoa,
                    TienSuGayMe = :TienSuGayMe,
                    DiUng = :DiUng,
                    Nghien = :Nghien,
                    BenhLayNhiem = :BenhLayNhiem,
                    ThuocDangDieuTri = :ThuocDangDieuTri,
                    KhamLamSang = :KhamLamSang,
                    TuanHoan = :TuanHoan,
                    Mach = :Mach,
                    HA = :HA,
                    HoHap = :HoHap,
                    ThanKinh = :ThanKinh,
                    CotSong = :CotSong,
                    XetNghiemBatThuong = :XetNghiemBatThuong,
                    YeuCauBoSung = :YeuCauBoSung,
                    DuKienCachThuc = :DuKienCachThuc,
                    DuKienGiamDau = :DuKienGiamDau,
                    YLenhTruocMo = :YLenhTruocMo,
                    TienThuocMe = :TienThuocMe,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + bangKiem.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangKiem.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", bangKiem.MaBenhNhan));

                Command.Parameters.Add(new MDB.MDBParameter("NgayKham", bangKiem.NgayKham));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSi", bangKiem.MaBacSi));
                Command.Parameters.Add(new MDB.MDBParameter("BacSi", bangKiem.BacSi));
                Command.Parameters.Add(new MDB.MDBParameter("NhomMau", bangKiem.NhomMau));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang", bangKiem.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("ChieuCao", bangKiem.ChieuCao));
                Command.Parameters.Add(new MDB.MDBParameter("ASA", bangKiem.ASA));
                Command.Parameters.Add(new MDB.MDBParameter("Mallampati", bangKiem.Mallampati));
                Command.Parameters.Add(new MDB.MDBParameter("KcCamGiap", bangKiem.KcCamGiap));
                Command.Parameters.Add(new MDB.MDBParameter("HaMieng", bangKiem.HaMieng));
                Command.Parameters.Add(new MDB.MDBParameter("RangGia", bangKiem.RangGia));
                Command.Parameters.Add(new MDB.MDBParameter("GioAn", bangKiem.GioAn));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiMo", bangKiem.LoaiMo));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", bangKiem.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("HuongXuTri", bangKiem.HuongXuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuNoiKhoa", bangKiem.TienSuNoiKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuNgoaiKhoa", bangKiem.TienSuNgoaiKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuGayMe", bangKiem.TienSuGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("DiUng", bangKiem.DiUng));
                Command.Parameters.Add(new MDB.MDBParameter("Nghien", bangKiem.Nghien));
                Command.Parameters.Add(new MDB.MDBParameter("BenhLayNhiem", bangKiem.BenhLayNhiem));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocDangDieuTri", bangKiem.ThuocDangDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("KhamLamSang", bangKiem.KhamLamSang));
                Command.Parameters.Add(new MDB.MDBParameter("TuanHoan", bangKiem.TuanHoan));
                Command.Parameters.Add(new MDB.MDBParameter("Mach", bangKiem.Mach));
                Command.Parameters.Add(new MDB.MDBParameter("HA", bangKiem.HA));
                Command.Parameters.Add(new MDB.MDBParameter("HoHap", bangKiem.HoHap));
                Command.Parameters.Add(new MDB.MDBParameter("ThanKinh", bangKiem.ThanKinh));
                Command.Parameters.Add(new MDB.MDBParameter("CotSong", bangKiem.CotSong));
                Command.Parameters.Add(new MDB.MDBParameter("XetNghiemBatThuong", bangKiem.XetNghiemBatThuong));
                Command.Parameters.Add(new MDB.MDBParameter("YeuCauBoSung", bangKiem.YeuCauBoSung));
                Command.Parameters.Add(new MDB.MDBParameter("DuKienCachThuc", bangKiem.DuKienCachThuc));
                Command.Parameters.Add(new MDB.MDBParameter("DuKienGiamDau", bangKiem.DuKienGiamDau));
                Command.Parameters.Add(new MDB.MDBParameter("YLenhTruocMo", bangKiem.YLenhTruocMo));
                Command.Parameters.Add(new MDB.MDBParameter("TienThuocMe", bangKiem.TienThuocMe));

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
                string sql = "DELETE FROM PhieuKhamGayMeTruocPTTT WHERE ID = :ID";
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
                PhieuKhamGayMeTruocPTTT B
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);

            var ds = new DataSet();

            adt.Fill(ds, "TB");
            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(string));
            ds.Tables[0].AddColumn("Khoa", typeof(string));
            ds.Tables[0].AddColumn("BenhVien", typeof(string));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            ds.Tables[0].Rows[0]["Khoa"] = XemBenhAn._ThongTinDieuTri.Khoa;
            ds.Tables[0].Rows[0]["BenhVien"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;

            return ds;
        }
    }
}
