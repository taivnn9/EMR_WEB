using EMR.KyDienTu;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhaThaiHutChanKhong : ThongTinKy
    {
        public PhaThaiHutChanKhong()
        {
            TableName = "ToPhaThaiHutChanKhong";
            TablePrimaryKeyName = "IDToPhaThaiHutChanKhong";
            IDMauPhieu = (int)DanhMucPhieu.PTHCK;
            TenMauPhieu = DanhMucPhieu.PTHCK.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long IDToPhaThaiHutChanKhong { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Năm sinh")]
		public string NamSinh { get; set; }
        public DateTime ThoiDiemThucHien { get; set; }
        public DateTime? ThoiDiemThucHien_Gio { get; set; }
        public DateTime ThoiDiemKetThuc { get; set; }
        public DateTime? ThoiDiemKetThuc_Gio { get; set; }
        public string GayTe_Text { get; set; }
        public bool GayTe { get; set; }
        public string GayMe_Text { get; set; }
        public bool GayMe { get; set; }
        public bool[] PhuongPhapPhaThaiArray { get; } = new bool[] { false, false, false };
        public int PhuongPhapPhaThai
        {
            get
            {
                return Array.IndexOf(PhuongPhapPhaThaiArray, true);
            }
            set
            {
                for (int i = 0; i < 3; i++)
                {
                    if (i == value) PhuongPhapPhaThaiArray[i] = true;
                    else PhuongPhapPhaThaiArray[i] = false;
                }
            }
        }
        public double SoLuongChatHut { get; set; }
        public bool[] MangOiArray { get; } = new bool[] { false, false };
        public int MangOi
        {
            get
            {
                return Array.IndexOf(MangOiArray, true);
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == value) MangOiArray[i] = true;
                    else MangOiArray[i] = false;
                }
            }
        }
        public bool[] RauThaiArray { get; } = new bool[] { false, false };
        public int RauThai
        {
            get
            {
                return Array.IndexOf(RauThaiArray, true);
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == value) RauThaiArray[i] = true;
                    else RauThaiArray[i] = false;
                }
            }
        }
        public bool[] MoThaiArray { get; } = new bool[] { false, false };
        public int MoThai
        {
            get
            {
                return Array.IndexOf(MoThaiArray, true);
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == value) MoThaiArray[i] = true;
                    else MoThaiArray[i] = false;
                }
            }
        }
        public bool[] TuongXungTuoiThaiArray { get; } = new bool[] { false, false };
        public int TuongXungTuoiThai
        {
            get
            {
                return Array.IndexOf(TuongXungTuoiThaiArray, true);
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == value) TuongXungTuoiThaiArray[i] = true;
                    else TuongXungTuoiThaiArray[i] = false;
                }
            }
        }
        public bool ThaiKhacThuong { get; set; }
        public string ChatHut_Text { get; set; }
        public string ThuocSuDung { get; set; }
        public string TaiBien { get; set; }
        public string ToanTrangNgaySau { get; set; }
        public int MachNgaySau { get; set; }
        public string HuyetApNgaySau { get; set; }
        public bool[] MauAmDaoNgaySauArray { get; } = new bool[] { false, false };
        public int MauAmDaoNgaySau
        {
            get
            {
                return Array.IndexOf(MauAmDaoNgaySauArray, true);
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == value) MauAmDaoNgaySauArray[i] = true;
                    else MauAmDaoNgaySauArray[i] = false;
                }
            }
        }
        public string ToanTrangSau30 { get; set; }
        public int MachSau30 { get; set; }
        public string HuyetApSau30 { get; set; }
        public bool[] MauAmDaoSau30Array { get; } = new bool[] { false, false };
        public int MauAmDaoSau30
        {
            get
            {
                return Array.IndexOf(MauAmDaoSau30Array, true);
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == value) MauAmDaoSau30Array[i] = true;
                    else MauAmDaoSau30Array[i] = false;
                }
            }
        }
        public string DanhGiaketQua { get; set; }
        public bool[] BienPhapTranhThaiArray { get; } = new bool[] { false, false, false, false, false, false, false, false };
        public string BienPhapTranhThai
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < BienPhapTranhThaiArray.Length; i++)
                    temp += (BienPhapTranhThaiArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        BienPhapTranhThaiArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string NguoiLamThuThuat { get; set; }
        public string MaNguoiLamThuThuat { get; set; }
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
    }
    public class PhaThaiHutChanKhongFunc
    {
        public static List<PhaThaiHutChanKhong> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhaThaiHutChanKhong> list = new List<PhaThaiHutChanKhong>();
            try
            {
                string sql = @"SELECT * FROM ToPhaThaiHutChanKhong where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
				if (XemBenhAn._HanhChinhBenhNhan == null) XemBenhAn._HanhChinhBenhNhan = new HanhChinhBenhNhan();
                while (DataReader.Read())
                {
                    PhaThaiHutChanKhong data = new PhaThaiHutChanKhong();
                    data.IDToPhaThaiHutChanKhong = Convert.ToInt64(DataReader.GetLong("IDToPhaThaiHutChanKhong").ToString());
                    data.TenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = XemBenhAn._HanhChinhBenhNhan.MaBenhNhan;
                    data.NamSinh = XemBenhAn._HanhChinhBenhNhan.NgaySinh.HasValue ? XemBenhAn._HanhChinhBenhNhan.NgaySinh.Value.Year.ToString() : "";

                    data.ThoiDiemThucHien = Convert.ToDateTime(DataReader["ThoiDiemThucHien"] == DBNull.Value ? DateTime.Now : DataReader["ThoiDiemThucHien"]);
                    data.ThoiDiemKetThuc = Convert.ToDateTime(DataReader["ThoiDiemKetThuc"] == DBNull.Value ? DateTime.Now : DataReader["ThoiDiemKetThuc"]);
                    data.GayTe_Text = DataReader["GayTe_Text"].ToString();
                    data.GayTe = DataReader["GayTe"].ToString().Equals("1") ? true : false;
                    data.GayMe_Text = DataReader["GayMe_Text"].ToString();
                    data.GayMe = DataReader["GayMe"].ToString().Equals("1") ? true : false;
                    int tempInt = -1;
                    int.TryParse(DataReader["PhuongPhapPhaThai"].ToString(), out tempInt);
                    data.PhuongPhapPhaThai = tempInt;
                    double tempDouble = 0;
                    double.TryParse(DataReader["SoLuongChatHut"].ToString(), out tempDouble);
                    data.SoLuongChatHut = tempDouble;

                    tempInt = -1;
                    int.TryParse(DataReader["MangOi"].ToString(), out tempInt);
                    data.MangOi = tempInt;

                    tempInt = -1;
                    int.TryParse(DataReader["RauThai"].ToString(), out tempInt);
                    data.RauThai = tempInt;

                    tempInt = -1;
                    int.TryParse(DataReader["MoThai"].ToString(), out tempInt);
                    data.MoThai = tempInt;

                    tempInt = -1;
                    int.TryParse(DataReader["TuongXungTuoiThai"].ToString(), out tempInt);
                    data.TuongXungTuoiThai = tempInt;
                    data.ThaiKhacThuong = DataReader["ThaiKhacThuong"].ToString().Equals("1") ? true : false;
                    data.ChatHut_Text = DataReader["ChatHut_Text"].ToString();
                    data.ThuocSuDung = DataReader["ThuocSuDung"].ToString();
                    data.TaiBien = DataReader["TaiBien"].ToString();

                    data.ToanTrangNgaySau = DataReader["ToanTrangNgaySau"].ToString();
                    tempInt = -1;
                    int.TryParse(DataReader["MachNgaySau"].ToString(), out tempInt);
                    data.MachNgaySau = tempInt;
                    data.HuyetApNgaySau = DataReader["HuyetApNgaySau"].ToString();
                    tempInt = -1;
                    int.TryParse(DataReader["MauAmDaoNgaySau"].ToString(), out tempInt);
                    data.MauAmDaoNgaySau = tempInt;

                    data.ToanTrangSau30 = DataReader["ToanTrangSau30"].ToString();
                    tempInt = -1;
                    int.TryParse(DataReader["MachSau30"].ToString(), out tempInt);
                    data.MachSau30 = tempInt;
                    data.HuyetApSau30 = DataReader["HuyetApSau30"].ToString();
                    tempInt = -1;
                    int.TryParse(DataReader["MauAmDaoSau30"].ToString(), out tempInt);
                    data.MauAmDaoSau30 = tempInt;

                    data.DanhGiaketQua = DataReader["DanhGiaketQua"].ToString();

                    data.BienPhapTranhThai = DataReader["BienPhapTranhThai"].ToString();

                    data.NguoiLamThuThuat = DataReader["NguoiLamThuThuat"].ToString();
                    data.MaNguoiLamThuThuat = DataReader["MaNguoiLamThuThuat"].ToString();

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhaThaiHutChanKhong phaThaiHutChanKhong)
        {
            try
            {
                string sql = @"INSERT INTO ToPhaThaiHutChanKhong
                (
                    MAQUANLY,
                    MaBenhNhan,
                    ThoiDiemThucHien,
                    ThoiDiemKetThuc,
                    GayTe_Text,
                    GayTe,
                    GayMe_Text,
                    GayMe,
                    PhuongPhapPhaThai,
                    SoLuongChatHut,
                    MangOi,
                    RauThai,
                    MoThai,
                    TuongXungTuoiThai,
                    ThaiKhacThuong,
                    ChatHut_Text,
                    ThuocSuDung,
                    TaiBien,
                    ToanTrangNgaySau,
                    MachNgaySau,
                    HuyetApNgaySau,
                    MauAmDaoNgaySau,
                    ToanTrangSau30,
                    MachSau30,
                    HuyetApSau30,
                    MauAmDaoSau30,
                    DanhGiaketQua,
                    BienPhapTranhThai,
                    NguoiLamThuThuat,
                    MaNguoiLamThuThuat,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :ThoiDiemThucHien,
                    :ThoiDiemKetThuc,
                    :GayTe_Text,
                    :GayTe,
                    :GayMe_Text,
                    :GayMe,
                    :PhuongPhapPhaThai,
                    :SoLuongChatHut,
                    :MangOi,
                    :RauThai,
                    :MoThai,
                    :TuongXungTuoiThai,
                    :ThaiKhacThuong,
                    :ChatHut_Text,
                    :ThuocSuDung,
                    :TaiBien,
                    :ToanTrangNgaySau,
                    :MachNgaySau,
                    :HuyetApNgaySau,
                    :MauAmDaoNgaySau,
                    :ToanTrangSau30,
                    :MachSau30,
                    :HuyetApSau30,
                    :MauAmDaoSau30,
                    :DanhGiaketQua,
                    :BienPhapTranhThai,
                    :NguoiLamThuThuat,
                    :MaNguoiLamThuThuat,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING IDToPhaThaiHutChanKhong INTO :IDToPhaThaiHutChanKhong";
                if (phaThaiHutChanKhong.IDToPhaThaiHutChanKhong != 0)
                {
                    sql = @"UPDATE ToPhaThaiHutChanKhong SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    ThoiDiemThucHien = :ThoiDiemThucHien,
                    ThoiDiemKetThuc = :ThoiDiemKetThuc,
                    GayTe_Text = :GayTe_Text,
                    GayTe = :GayTe,
                    GayMe_Text = :GayMe_Text,
                    GayMe = :GayMe,
                    PhuongPhapPhaThai = :PhuongPhapPhaThai,
                    SoLuongChatHut = :SoLuongChatHut,
                    MangOi = :MangOi,
                    RauThai = :RauThai,
                    MoThai = :MoThai,
                    TuongXungTuoiThai = :TuongXungTuoiThai,
                    ThaiKhacThuong = :ThaiKhacThuong,
                    ChatHut_Text = :ChatHut_Text,
                    ThuocSuDung = :ThuocSuDung,
                    TaiBien = :TaiBien,
                    ToanTrangNgaySau = :ToanTrangNgaySau,
                    MachNgaySau = :MachNgaySau,
                    HuyetApNgaySau = :HuyetApNgaySau,
                    MauAmDaoNgaySau = :MauAmDaoNgaySau,
                    ToanTrangSau30 = :ToanTrangSau30,
					MachSau30 =  :MachSau30,
                    HuyetApSau30 = :HuyetApSau30,
                    MauAmDaoSau30 = :MauAmDaoSau30,
                    DanhGiaketQua = :DanhGiaketQua,
                    BienPhapTranhThai = :BienPhapTranhThai,
                    NguoiLamThuThuat = :NguoiLamThuThuat,
                    MaNguoiLamThuThuat = :MaNguoiLamThuThuat,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE IDToPhaThaiHutChanKhong = " + phaThaiHutChanKhong.IDToPhaThaiHutChanKhong;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", phaThaiHutChanKhong.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", phaThaiHutChanKhong.MaBenhNhan));

                var Ngay = phaThaiHutChanKhong.ThoiDiemThucHien.Date.Add(new TimeSpan(0, 0, 0));
                var Gio = phaThaiHutChanKhong.ThoiDiemThucHien_Gio != null ? phaThaiHutChanKhong.ThoiDiemThucHien_Gio.Value.TimeOfDay : DateTime.Now.TimeOfDay;
                var ngayThucHien = Ngay + Gio;
                Command.Parameters.Add(new MDB.MDBParameter("ThoiDiemThucHien", ngayThucHien));

                Ngay = phaThaiHutChanKhong.ThoiDiemKetThuc.Date.Add(new TimeSpan(0, 0, 0));
                Gio = phaThaiHutChanKhong.ThoiDiemKetThuc_Gio != null ? phaThaiHutChanKhong.ThoiDiemKetThuc_Gio.Value.TimeOfDay : DateTime.Now.TimeOfDay;
                ngayThucHien = Ngay + Gio;
                Command.Parameters.Add(new MDB.MDBParameter("ThoiDiemKetThuc", ngayThucHien));

                Command.Parameters.Add(new MDB.MDBParameter("GayTe_Text", phaThaiHutChanKhong.GayTe_Text));
                Command.Parameters.Add(new MDB.MDBParameter("GayTe", phaThaiHutChanKhong.GayTe ? 1: 0));
                Command.Parameters.Add(new MDB.MDBParameter("GayMe_Text", phaThaiHutChanKhong.GayMe_Text));
                Command.Parameters.Add(new MDB.MDBParameter("GayMe", phaThaiHutChanKhong.GayMe ? 1:0));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapPhaThai", phaThaiHutChanKhong.PhuongPhapPhaThai));
                Command.Parameters.Add(new MDB.MDBParameter("SoLuongChatHut", phaThaiHutChanKhong.SoLuongChatHut));
                Command.Parameters.Add(new MDB.MDBParameter("MangOi", phaThaiHutChanKhong.MangOi));
                Command.Parameters.Add(new MDB.MDBParameter("RauThai", phaThaiHutChanKhong.RauThai));
                Command.Parameters.Add(new MDB.MDBParameter("MoThai", phaThaiHutChanKhong.MoThai));
                Command.Parameters.Add(new MDB.MDBParameter("TuongXungTuoiThai", phaThaiHutChanKhong.TuongXungTuoiThai));
                Command.Parameters.Add(new MDB.MDBParameter("ThaiKhacThuong", phaThaiHutChanKhong.ThaiKhacThuong ? 1: 0));
                Command.Parameters.Add(new MDB.MDBParameter("ChatHut_Text", phaThaiHutChanKhong.ChatHut_Text));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocSuDung", phaThaiHutChanKhong.ThuocSuDung));
                Command.Parameters.Add(new MDB.MDBParameter("TaiBien", phaThaiHutChanKhong.TaiBien));
                Command.Parameters.Add(new MDB.MDBParameter("ToanTrangNgaySau", phaThaiHutChanKhong.ToanTrangNgaySau));
                Command.Parameters.Add(new MDB.MDBParameter("MachNgaySau", phaThaiHutChanKhong.MachNgaySau));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetApNgaySau", phaThaiHutChanKhong.HuyetApNgaySau));
                Command.Parameters.Add(new MDB.MDBParameter("MauAmDaoNgaySau", phaThaiHutChanKhong.MauAmDaoNgaySau));
                Command.Parameters.Add(new MDB.MDBParameter("ToanTrangSau30", phaThaiHutChanKhong.ToanTrangSau30));
                Command.Parameters.Add(new MDB.MDBParameter("MachSau30", phaThaiHutChanKhong.MachSau30));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetApSau30", phaThaiHutChanKhong.HuyetApSau30));
                Command.Parameters.Add(new MDB.MDBParameter("MauAmDaoSau30", phaThaiHutChanKhong.MauAmDaoSau30));
                Command.Parameters.Add(new MDB.MDBParameter("DanhGiaketQua", phaThaiHutChanKhong.DanhGiaketQua));
                Command.Parameters.Add(new MDB.MDBParameter("BienPhapTranhThai", phaThaiHutChanKhong.BienPhapTranhThai));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiLamThuThuat", phaThaiHutChanKhong.NguoiLamThuThuat));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiLamThuThuat", phaThaiHutChanKhong.MaNguoiLamThuThuat));
   
                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", phaThaiHutChanKhong.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", phaThaiHutChanKhong.NgaySua));
                if (phaThaiHutChanKhong.IDToPhaThaiHutChanKhong == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("IDToPhaThaiHutChanKhong", phaThaiHutChanKhong.IDToPhaThaiHutChanKhong));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", phaThaiHutChanKhong.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", phaThaiHutChanKhong.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (phaThaiHutChanKhong.IDToPhaThaiHutChanKhong == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["IDToPhaThaiHutChanKhong"] as MDB.MDBParameter).Value);
                    phaThaiHutChanKhong.IDToPhaThaiHutChanKhong = nextval;
                }
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool delete(MDB.MDBConnection MyConnection, long IDToPhaThaiHutChanKhong)
        {
            try
            {
                string sql = "DELETE FROM ToPhaThaiHutChanKhong WHERE IDToPhaThaiHutChanKhong = :IDToPhaThaiHutChanKhong";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                command.Parameters.Add(new MDB.MDBParameter("IDToPhaThaiHutChanKhong", IDToPhaThaiHutChanKhong));
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
        public static DataSet getDataSet(MDB.MDBConnection MyConnection, long IDToPhaThaiHutChanKhong)
        {
            string sql = @"SELECT
                T.*,
                H.TENBENHNHAN,
	            H.NGAYSINH AS NAMSINH
            FROM
                ToPhaThaiHutChanKhong T  LEFT JOIN  HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
            WHERE
                IDToPhaThaiHutChanKhong = " + IDToPhaThaiHutChanKhong;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            adt.Fill(ds);

            return ds;
        }
    }
}
