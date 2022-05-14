using EMR.KyDienTu;
using System;
using System.Data;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class BangKiemTruocTiemChungTreSoSinh : ThongTinKy
    {
        public BangKiemTruocTiemChungTreSoSinh()
        {
            TableName = "BangKiemTruocTiemChung";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BKTCTSS;
            TenMauPhieu = DanhMucPhieu.BKTCTSS.Description();
        }
        public decimal IdBangKiem { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("")]
        public string HoVaTenBoMe { get; set; }
        [MoTaDuLieu("")]
        public string DienThoai { get; set; }
        [MoTaDuLieu("")]
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
        public bool DuDieuKienTiem { get; set; }
        [MoTaDuLieu("")]
        public string LoaiVacXin { get; set; }
        [MoTaDuLieu("")]
        public bool ChongChiDinh { get; set; }
        [MoTaDuLieu("")]
        public bool TamHoanTiemChung { get; set; }
        [MoTaDuLieu("")]
        public DateTime NgayLapPhieu { get; set; }
        [MoTaDuLieu("")]
        public DateTime? NgayLapPhieu_Gio { get; set; }
        [MoTaDuLieu("Người thực hiện")]
		public string NguoiThucHien { get; set; }
        [MoTaDuLieu("Mã người thực hiện")]
		public string MaNguoiThucHien { get; set; }
        [MoTaDuLieu("")]
        public string HoVaTenTre { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinhTre { get; set; }
        [MoTaDuLieu("")]
        public DateTime NgaySinhTre { get; set; }

    }
    public class BangKiemTruocTiemChungTreSoSinhFunc
    {
        public static BangKiemTruocTiemChungTreSoSinh GetData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            BangKiemTruocTiemChungTreSoSinh data = new BangKiemTruocTiemChungTreSoSinh();
            try
            {
                string sql = @"SELECT * FROM BangKiemTruocTiemChung where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    data.IdBangKiem = Convert.ToInt64(DataReader.GetLong("IdBangKiem").ToString());
                    data.MaQuanLy = maquanly;
                    data.DiaChi = DataReader["DiaChi"].ToString();
                    data.Tuoi = DataReader["Tuoi"].ToString();
                    data.HoVaTenBoMe = DataReader["HoVaTenBoMe"].ToString();
                    data.DienThoai = DataReader["DienThoai"].ToString();
                    int tempInt = -1;
                    int.TryParse(DataReader["Soc"].ToString(), out tempInt);
                    data.Soc = tempInt;
                     tempInt = -1;
                    int.TryParse(DataReader["BenhCapTinh"].ToString(), out tempInt);
                    data.BenhCapTinh = tempInt;
                     tempInt = -1;
                    int.TryParse(DataReader["DangDieuTri"].ToString(), out tempInt);
                    data.DangDieuTri = tempInt;
                    tempInt = -1;
                    int.TryParse(DataReader["SangLoc"].ToString(), out tempInt);
                    data.SangLoc = tempInt;
                    data.ChongChiDinh = DataReader["ChongChiDinh"].ToString().Equals("1") ? true : false;
                    tempInt = -1;
                    int.TryParse(DataReader["ThanNhiet"].ToString(), out tempInt);
                    data.ThanNhiet = tempInt;
                    tempInt = -1;
                    int.TryParse(DataReader["NgheTim"].ToString(), out tempInt);
                    data.NgheTim = tempInt;
                    tempInt = -1;
                    int.TryParse(DataReader["NghePhoi"].ToString(), out tempInt);
                    data.NghePhoi = tempInt;
                    tempInt = -1;
                    int.TryParse(DataReader["TriGiac"].ToString(), out tempInt);
                    data.TriGiac = tempInt;
                    tempInt = -1;
                    int.TryParse(DataReader["CanNang"].ToString(), out tempInt);
                    data.CanNang = tempInt;
                    tempInt = -1;
                    int.TryParse(DataReader["ChongTriDinh"].ToString(), out tempInt);
                    data.ChongTriDinh = tempInt;
                    data.SoCanNang = Common.ConDBNull_float(DataReader["SoCanNang"].ToString());
                   data.SoThanNhiet = Common.ConDBNull_float(DataReader["SoThanNhiet"].ToString());
                    data.DuDieuKienTiem = DataReader["DuDieuKienTiem"].ToString().Equals("1") ? true : false;
                    data.LoaiVacXin = DataReader["LoaiVacXin"].ToString();
                    data.GhiChuChiDinh = DataReader["GhiChuChiDinh"].ToString();
                    data.LiDo = DataReader["LiDo"].ToString();
                    data.KetQua = DataReader["KetQua"].ToString();
                    data.KetLuan = DataReader["KetLuan"].ToString();
                    data.GhiChuChuyenKhoa = DataReader["GhiChuChuyenKhoa"].ToString();
                    data.TamHoanTiemChung = DataReader["TamHoanTiemChung"].ToString().Equals("1") ? true : false;
                    data.NgayLapPhieu = Convert.ToDateTime(DataReader["NgayLapPhieu"] == DBNull.Value ? DateTime.Now : DataReader["NgayLapPhieu"]);
                    data.NguoiThucHien = DataReader["NguoiThucHien"].ToString();
                    data.MaNguoiThucHien = DataReader["MaNguoiThucHien"].ToString();
                    data.HoVaTenTre = DataReader.GetString("HoVaTenTre");
                    data.GioiTinhTre = DataReader.GetString("GioiTinhTre");
                    try
                    {
                        data.NgaySinhTre = DataReader.GetDate("NgaySinhTre");
                    }
                    catch { }
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return data;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BangKiemTruocTiemChungTreSoSinh bangKiem)
        {
            try
            {
                string sql = @"INSERT INTO BangKiemTruocTiemChung
                (
                    MAQUANLY,
                    DiaChi,Tuoi,
                    HoVaTenBoMe,
                    DienThoai,
                    ThanNhiet,
                    NgheTim,
                    NghePhoi,
                    TriGiac,
                    CanNang,
                    ChongTriDinh,
                    SoCanNang,
                    SoThanNhiet,
                    DuDieuKienTiem,
                    LoaiVacXin,
                    Soc,
                    BenhCapTinh,
                    DangDieuTri,
                    SangLoc,
                    ChongChiDinh,
                    GhiChuChiDinh,
                    LiDo,
                    KetQua,
                    KetLuan,
                    GhiChuChuyenKhoa,
                    TamHoanTiemChung,
                    NgayLapPhieu,
                    NguoiThucHien,
                    MaNguoiThucHien,
                    HoVaTenTre,
                    GioiTinhTre,
                    NgaySinhTre
                 )  VALUES
                 (
				    :MAQUANLY,
                    :DiaChi, :Tuoi,
                    :HoVaTenBoMe,
                    :DienThoai,
                    :ThanNhiet,
                    :NgheTim,
                    :NghePhoi,
                    :TriGiac,
                    :CanNang,
                    :ChongTriDinh,
                    :SoCanNang,
                    :SoThanNhiet,
                    :DuDieuKienTiem,
                    :LoaiVacXin,
                    :Soc,
                    :BenhCapTinh,
                    :DangDieuTri,
                    :SangLoc,
                    :ChongChiDinh,
                    :GhiChuChiDinh,
                    :LiDo,
                    :KetQua,
                    :KetLuan,
                    :GhiChuChuyenKhoa,
                    :TamHoanTiemChung,
                    :NgayLapPhieu,
                    :NguoiThucHien,
                    :MaNguoiThucHien,
                    :HoVaTenTre,
                    :GioiTinhTre,
                    :NgaySinhTre
                 )  RETURNING IdBangKiem INTO :IdBangKiem";
                if (bangKiem.IdBangKiem != Decimal.Zero)
                {
                    sql = @"UPDATE BangKiemTruocTiemChung SET 
                    MAQUANLY = :MAQUANLY,
                    DiaChi = :DiaChi,Tuoi = :Tuoi,
                    HoVaTenBoMe= :HoVaTenBoMe,
                    DienThoai = :DienThoai,
                    ThanNhiet = :ThanNhiet,
                    NgheTim = :NgheTim,
                    NghePhoi = :NghePhoi,
                    TriGiac = :TriGiac,
                    CanNang = :CanNang,
                    ChongTriDinh = :ChongTriDinh,
                    SoCanNang = :SoCanNang,
                    SoThanNhiet = :SoThanNhiet,
                    DuDieuKienTiem = :DuDieuKienTiem,
                    LoaiVacXin = :LoaiVacXin,
                    Soc = :Soc,
                    BenhCapTinh = :BenhCapTinh,
                    DangDieuTri = :DangDieuTri,
                    SangLoc = :SangLoc,
                    ChongChiDinh = :ChongChiDinh,
                    GhiChuChiDinh = :GhiChuChiDinh,
                    LiDo = :LiDo,
                    KetQua = :KetQua,
                    KetLuan = :KetLuan,
                    GhiChuChuyenKhoa = :GhiChuChuyenKhoa,
                    TamHoanTiemChung = :TamHoanTiemChung,
                    NgayLapPhieu = :NgayLapPhieu,
                    NguoiThucHien = :NguoiThucHien,
                    MaNguoiThucHien = :MaNguoiThucHien,
                    HoVaTenTre = :HoVaTenTre,
                    GioiTinhTre = :GioiTinhTre,
                    NgaySinhTre = :NgaySinhTre
                    WHERE IdBangKiem = " + bangKiem.IdBangKiem;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangKiem.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", bangKiem.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("Tuoi", bangKiem.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("HoVaTenBoMe", bangKiem.HoVaTenBoMe));
                Command.Parameters.Add(new MDB.MDBParameter("DienThoai", bangKiem.DienThoai));
                Command.Parameters.Add(new MDB.MDBParameter("ThanNhiet", bangKiem.ThanNhiet));
                Command.Parameters.Add(new MDB.MDBParameter("NgheTim", bangKiem.NgheTim));
                Command.Parameters.Add(new MDB.MDBParameter("NghePhoi", bangKiem.NghePhoi));
                Command.Parameters.Add(new MDB.MDBParameter("TriGiac", bangKiem.TriGiac));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang", bangKiem.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("ChongTriDinh", bangKiem.ChongTriDinh));
                Command.Parameters.Add(new MDB.MDBParameter("SoCanNang", bangKiem.SoCanNang));
                Command.Parameters.Add(new MDB.MDBParameter("SoThanNhiet", bangKiem.SoThanNhiet));
                Command.Parameters.Add(new MDB.MDBParameter("DuDieuKienTiem", bangKiem.DuDieuKienTiem ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiVacXin", bangKiem.LoaiVacXin));
                Command.Parameters.Add(new MDB.MDBParameter("Soc", bangKiem.Soc));
                Command.Parameters.Add(new MDB.MDBParameter("BenhCapTinh", bangKiem.BenhCapTinh));
                Command.Parameters.Add(new MDB.MDBParameter("DangDieuTri", bangKiem.DangDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("SangLoc", bangKiem.SangLoc));
                Command.Parameters.Add(new MDB.MDBParameter("ChongChiDinh", bangKiem.ChongChiDinh ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("GhiChuChiDinh", bangKiem.GhiChuChiDinh));
                Command.Parameters.Add(new MDB.MDBParameter("LiDo", bangKiem.LiDo));
                Command.Parameters.Add(new MDB.MDBParameter("KetQua", bangKiem.KetQua));
                Command.Parameters.Add(new MDB.MDBParameter("KetLuan", bangKiem.KetLuan));
                Command.Parameters.Add(new MDB.MDBParameter("GhiChuChuyenKhoa", bangKiem.GhiChuChuyenKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("TamHoanTiemChung", bangKiem.TamHoanTiemChung ? 1 : 0));
                var Ngay = bangKiem.NgayLapPhieu.Date.Add(new TimeSpan(0, 0, 0));
                var Gio = bangKiem.NgayLapPhieu_Gio != null ? bangKiem.NgayLapPhieu_Gio.Value.TimeOfDay : DateTime.Now.TimeOfDay;
                var ngayLapPhieu = Ngay + Gio;
                Command.Parameters.Add(new MDB.MDBParameter("NgayLapPhieu", ngayLapPhieu));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiThucHien", bangKiem.NguoiThucHien));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiThucHien", bangKiem.MaNguoiThucHien));
                if (bangKiem.IdBangKiem.Equals(Decimal.Zero))
                {
                    Command.Parameters.Add(new MDB.MDBParameter("IdBangKiem", bangKiem.IdBangKiem));
                }
                Command.Parameters.Add(new MDB.MDBParameter("HoVaTenTre", bangKiem.HoVaTenTre));
                Command.Parameters.Add(new MDB.MDBParameter("GioiTinhTre", bangKiem.GioiTinhTre));
                Command.Parameters.Add(new MDB.MDBParameter("NgaySinhTre", bangKiem.NgaySinhTre));
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (bangKiem.IdBangKiem.Equals(Decimal.Zero))
                {
                    decimal nextval = Convert.ToInt64((Command.Parameters["IdBangKiem"] as MDB.MDBParameter).Value);
                    bangKiem.IdBangKiem = nextval;
                }
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool delete(MDB.MDBConnection MyConnection, decimal IdBangKiem)
        {
            try
            {
                string sql = "DELETE FROM BangKiemTruocTiemChung WHERE IdBangKiem = :IdBangKiem";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                command.Parameters.Add(new MDB.MDBParameter("IdBangKiem", IdBangKiem));
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
        public static DataSet getDataSet(MDB.MDBConnection MyConnection, decimal IdBangKiem)
        {
            string sql = @"SELECT
                B.*,
	            T.MAQUANLY,
	            H.TENBENHNHAN,
	            H.GIOITINH,
                H.NGAYSINH
            FROM
                BangKiemTruocTiemChung B
                JOIN THONGTINDIEUTRI T ON B.MAQUANLY = T.MAQUANLY
                JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
            WHERE
                IdBangKiem = " + IdBangKiem;
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "BK");

            DataTable thongTinVien = new DataTable("HEADER");

            thongTinVien.Columns.Add("BENHVIEN");
            thongTinVien.Columns.Add("KHOA");
			if (XemBenhAn._HanhChinhBenhNhan == null) XemBenhAn._HanhChinhBenhNhan = new HanhChinhBenhNhan();
            if (XemBenhAn._ThongTinDieuTri == null) XemBenhAn._ThongTinDieuTri = new ThongTinDieuTri();
            thongTinVien.Rows.Add(XemBenhAn._HanhChinhBenhNhan.BenhVien, XemBenhAn._ThongTinDieuTri.Khoa);
            ds.Tables.Add(thongTinVien);

            return ds;
        }
    }
}
