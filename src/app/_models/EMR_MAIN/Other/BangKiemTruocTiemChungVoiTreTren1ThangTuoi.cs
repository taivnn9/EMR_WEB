using EMR.KyDienTu;
using Newtonsoft.Json;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;


namespace EMR_MAIN.DATABASE.Other
{
    public class BangKiemTruocTiemChungVoiTreTren1ThangTuoi: ThongTinKy
    {
        public BangKiemTruocTiemChungVoiTreTren1ThangTuoi()
        {
            TableName = "BangKiemTTCVoiTreTren1ThangT";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BKTTCDVTT1TT;
            TenMauPhieu = DanhMucPhieu.BKTTCDVTT1TT.Description();
        }
        [MoTaDuLieu("Mã định danh")]
        public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau", "", 1)]
        public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
        public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Họ tên bệnh nhân")]
        public string HoTenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
        public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
        public string GioiTinh { get; set; }
        [MoTaDuLieu("Ngày sinh")]
        public string NgaySinh { get; set; }
        [MoTaDuLieu("Tháng sinh")]
        public string ThangSinh { get; set; }
        [MoTaDuLieu("Năm sinh")]
        public string NamSinh { get; set; }
        [MoTaDuLieu("Địa chỉ")]
        public string DiaChi { get; set; }
        [MoTaDuLieu("Họ tên bố/mẹ")]
        public string HoTenBoMe { get; set; }
        [MoTaDuLieu("Điện thoại")]
        public string DienThoai { get; set; }
        [MoTaDuLieu("Cân nặng")]
        public string CanNang { get; set; }
        [MoTaDuLieu("Thân nhiệt")]
        public string ThanNhiet { get; set; }
        public bool[] SocArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Sốc, phản ứng sau lần tiêm chủng trước")]
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
        [MoTaDuLieu("Đang mắc bệnh cấp tính hoặc mạn tính tiến triển")]
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

        public bool[] DangHoaTriArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Đang điều trị corticoid liều cao, hoá trị, xạ trị")]
        public int DangHoaTri
        {
            get
            {
                return Array.IndexOf(DangHoaTriArray, true);
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == value) DangHoaTriArray[i] = true;
                    else DangHoaTriArray[i] = false;
                }
            }
        }
        public bool[] SotHaThanNhietArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Sốt/hạ thân nhiệt")]
        public int SotHaThanNhiet
        {
            get
            {
                return Array.IndexOf(SotHaThanNhietArray, true);
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == value) SotHaThanNhietArray[i] = true;
                    else SotHaThanNhietArray[i] = false;
                }
            }
        }
        public bool[] NgheTimArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Nghe tim bất thường")]
        public int NgheTim
        {
            get
            {
                return Array.IndexOf(NgheTimArray, true);
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == value) NgheTimArray[i] = true;
                    else NgheTimArray[i] = false;
                }
            }
        }
        public bool[] NghePhoiArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Nghe phổi bất thường")]
        public int NghePhoi
        {
            get
            {
                return Array.IndexOf(NghePhoiArray, true);
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == value) NghePhoiArray[i] = true;
                    else NghePhoiArray[i] = false;
                }
            }
        }

        public bool[] TriGiacArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Tri giác bất thường")]
        public int TriGiac
        {
            get
            {
                return Array.IndexOf(TriGiacArray, true);
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == value) TriGiacArray[i] = true;
                    else TriGiacArray[i] = false;
                }
            }
        }
        public bool[] ChongChiDinhArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Các chống chỉ định khác")]
        public int ChongChiDinh
        {
            get
            {
                return Array.IndexOf(ChongChiDinhArray, true);
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == value) ChongChiDinhArray[i] = true;
                    else ChongChiDinhArray[i] = false;
                }
            }
        }
        [MoTaDuLieu("Ghi chú chống chỉ định")]
        public string GhichuChiDinh { get; set; }
        public bool[] SangLocArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Khám sàng lọc theo chuyên khoa")]
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
        [MoTaDuLieu("Chuyên khoa")]
        public string ChuyenKhoa { get; set; }
        [MoTaDuLieu("Lý do")]
        public string LyDo { get; set; }
        [MoTaDuLieu("Kết quả")]
        public string KetQua { get; set; }
        [MoTaDuLieu("Kết luận")]
        public string KetLuan { get; set; }
        [MoTaDuLieu("Đủ điều kiện tiêm chủng ngay")]
        public bool DuDieuKienTiem { get; set; }
        [MoTaDuLieu("Loại vắcxin")]
        public string LoaiVacXin { get; set; }
        [MoTaDuLieu("Chống chỉ định")]
        public bool ChongChiDinhTiem { get; set; }
        [MoTaDuLieu("Tạm hoãn tiêm")]
        public bool TamHoanTiemChung { get; set; }
        [MoTaDuLieu("")]
        public DateTime NgayLapPhieu { get; set; }
        [MoTaDuLieu("")]
        public DateTime? NgayLapPhieu_Gio { get; set; }
        [MoTaDuLieu("Người thực hiện")]
        public string NguoiThucHien { get; set; }
        [MoTaDuLieu("Mã người thực hiện")]
        public string MaNguoiThucHien { get; set; }


        // bắt buộc
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
    public class BangKiemTruocTiemChungVoiTreTren1ThangTuoiFunc
    {
        public const string TableName = "BangKiemTTCVoiTreTren1ThangT";
        public const string TablePrimaryKeyName = "ID";
        public static List<BangKiemTruocTiemChungVoiTreTren1ThangTuoi> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BangKiemTruocTiemChungVoiTreTren1ThangTuoi> list = new List<BangKiemTruocTiemChungVoiTreTren1ThangTuoi>();
            try
            {
                string sql = @"SELECT * FROM BangKiemTTCVoiTreTren1ThangT where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    BangKiemTruocTiemChungVoiTreTren1ThangTuoi data = new BangKiemTruocTiemChungVoiTreTren1ThangTuoi();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.HoTenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();

                    data.NgaySinh = DataReader["NgaySinh"].ToString(); 
                    data.ThangSinh = DataReader["ThangSinh"].ToString(); 
                    data.NamSinh = DataReader["NamSinh"].ToString(); 
                    data.DiaChi=DataReader["DiaChi"].ToString();
                    data.HoTenBoMe = DataReader["HoTenBoMe"].ToString();
                    data.DienThoai = DataReader["DienThoai"].ToString();
                    data.CanNang = DataReader["CanNang"].ToString();
                    data.ThanNhiet = DataReader["ThanNhiet"].ToString();
                    int tempInt = -1;
                    int.TryParse(DataReader["Soc"].ToString(), out tempInt);
                    data.Soc = tempInt;
                    tempInt = -1;
                    int.TryParse(DataReader["BenhCapTinh"].ToString(), out tempInt);
                    data.BenhCapTinh = tempInt;
                    tempInt = -1;
                    int.TryParse(DataReader["DangHoaTri"].ToString(), out tempInt);
                    data.DangHoaTri = tempInt;

                    tempInt = -1;
                    int.TryParse(DataReader["SotHaThanNhiet"].ToString(), out tempInt);
                    data.SotHaThanNhiet = tempInt;

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
                    int.TryParse(DataReader["ChongChiDinh"].ToString(), out tempInt);
                    data.ChongChiDinh = tempInt;

                    data.GhichuChiDinh = DataReader["GhichuChiDinh"].ToString();

                    tempInt = -1;
                    int.TryParse(DataReader["SangLoc"].ToString(), out tempInt);
                    data.SangLoc = tempInt;

                    tempInt = -1;
                    int.TryParse(DataReader["SangLoc"].ToString(), out tempInt);
                    data.SangLoc = tempInt;

                    data.ChuyenKhoa = DataReader["ChuyenKhoa"].ToString();
                    data.LyDo = DataReader["LyDo"].ToString();
                    data.KetQua = DataReader["KetQua"].ToString();
                    data.KetLuan = DataReader["KetLuan"].ToString();

                    data.DuDieuKienTiem = DataReader["DuDieuKienTiem"].ToString().Equals("1") ? true : false;
                    data.LoaiVacXin = DataReader["LoaiVacXin"].ToString();
                    data.ChongChiDinhTiem = DataReader["ChongChiDinhTiem"].ToString().Equals("1") ? true : false;
                    data.TamHoanTiemChung = DataReader["TamHoanTiemChung"].ToString().Equals("1") ? true : false;
                    data.NgayLapPhieu = Convert.ToDateTime(DataReader["NgayLapPhieu"] == DBNull.Value ? DateTime.Now : DataReader["NgayLapPhieu"]);
                    data.NgayLapPhieu_Gio=Convert.ToDateTime(DataReader["NgayLapPhieu"] == DBNull.Value ? DateTime.Now : DataReader["NgayLapPhieu"]);
                    data.NguoiThucHien = DataReader["NguoiThucHien"].ToString();
                    data.MaNguoiThucHien = DataReader["MaNguoiThucHien"].ToString();

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BangKiemTruocTiemChungVoiTreTren1ThangTuoi ketQua)
        {
            try
            {
                string sql = @"INSERT INTO BangKiemTTCVoiTreTren1ThangT
                (
                    MaQuanLy,
                    MaBenhNhan,
                    NgaySinh,
	                ThangSinh,
	                NamSinh,
	                DiaChi,
	                HoTenBoMe,
	                DienThoai,
	                CanNang,
	                ThanNhiet,
	                Soc,
	                BenhCapTinh,
	                DangHoaTri,
	                SotHaThanNhiet,
	                NgheTim,
	                NghePhoi,
	                TriGiac,
	                ChongChiDinh,
	                GhichuChiDinh,
	                SangLoc,
	                ChuyenKhoa,
	                LyDo,
	                KetQua,
	                KetLuan,
	                DuDieuKienTiem,
	                LoaiVacXin,
	                ChongChiDinhTiem,
	                TamHoanTiemChung,	
	                NgayLapPhieu,                  
	                NguoiThucHien,
	                MaNguoiThucHien,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
                    :MaBenhNhan,
                    :NgaySinh,
	                :ThangSinh,
	                :NamSinh,
	                :DiaChi,
	                :HoTenBoMe,
	                :DienThoai,
	                :CanNang,
	                :ThanNhiet,
	                :Soc,
	                :BenhCapTinh,
	                :DangHoaTri,
	                :SotHaThanNhiet,
	                :NgheTim,
	                :NghePhoi,
	                :TriGiac,
	                :ChongChiDinh,
	                :GhichuChiDinh,
	                :SangLoc,
	                :ChuyenKhoa,
	                :LyDo,
	                :KetQua,
	                :KetLuan,
	                :DuDieuKienTiem,
	                :LoaiVacXin,
	                :ChongChiDinhTiem,
	                :TamHoanTiemChung,	
	                :NgayLapPhieu,                   
	                :NguoiThucHien,
	                :MaNguoiThucHien,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE BangKiemTTCVoiTreTren1ThangT SET 
                    MaQuanLy=:MaQuanLy,
                    MaBenhNhan=:MaBenhNhan,
                    NgaySinh=:NgaySinh,
	                ThangSinh=:ThangSinh,
	                NamSinh=:NamSinh,
	                DiaChi=:DiaChi,
	                HoTenBoMe=:HoTenBoMe,
	                DienThoai=:DienThoai,
	                CanNang=:CanNang,
	                ThanNhiet=:ThanNhiet,
	                Soc=:Soc,
	                BenhCapTinh=:BenhCapTinh,
	                DangHoaTri=:DangHoaTri,
	                SotHaThanNhiet=:SotHaThanNhiet,
	                NgheTim=:NgheTim,
	                NghePhoi=:NghePhoi,
	                TriGiac=:TriGiac,
	                ChongChiDinh=:ChongChiDinh,
	                GhichuChiDinh=:GhichuChiDinh,
	                SangLoc=:SangLoc,
	                ChuyenKhoa=:ChuyenKhoa,
	                LyDo=:LyDo,
	                KetQua=:KetQua,
	                KetLuan=:KetLuan,
	                DuDieuKienTiem=:DuDieuKienTiem,
	                LoaiVacXin=:LoaiVacXin,
	                ChongChiDinhTiem=:ChongChiDinhTiem,
	                TamHoanTiemChung=:TamHoanTiemChung,	
	                NgayLapPhieu=:NgayLapPhieu,
	                NguoiThucHien=:NguoiThucHien,
	                MaNguoiThucHien=:MaNguoiThucHien,                   
                    NGUOISUA=:NGUOISUA,                  
                    NGAYSUA=:NGAYSUA
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ketQua.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("NgaySinh", ketQua.NgaySinh));
                Command.Parameters.Add(new MDB.MDBParameter("ThangSinh", ketQua.ThangSinh));
                Command.Parameters.Add(new MDB.MDBParameter("NamSinh", ketQua.NamSinh));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", ketQua.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("HoTenBoMe", ketQua.HoTenBoMe));
                Command.Parameters.Add(new MDB.MDBParameter("DienThoai", ketQua.DienThoai));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang", ketQua.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("ThanNhiet", ketQua.ThanNhiet));
                Command.Parameters.Add(new MDB.MDBParameter("Soc", ketQua.Soc));
                Command.Parameters.Add(new MDB.MDBParameter("BenhCapTinh", ketQua.BenhCapTinh));
                Command.Parameters.Add(new MDB.MDBParameter("DangHoaTri", ketQua.DangHoaTri));
                Command.Parameters.Add(new MDB.MDBParameter("SotHaThanNhiet", ketQua.SotHaThanNhiet));
                Command.Parameters.Add(new MDB.MDBParameter("NgheTim", ketQua.NgheTim));
                Command.Parameters.Add(new MDB.MDBParameter("NghePhoi", ketQua.NghePhoi));             
                Command.Parameters.Add(new MDB.MDBParameter("TriGiac", ketQua.TriGiac));
                Command.Parameters.Add(new MDB.MDBParameter("ChongChiDinh", ketQua.ChongChiDinh));
                Command.Parameters.Add(new MDB.MDBParameter("GhichuChiDinh", ketQua.GhichuChiDinh));
                Command.Parameters.Add(new MDB.MDBParameter("SangLoc", ketQua.SangLoc));
                Command.Parameters.Add(new MDB.MDBParameter("ChuyenKhoa", ketQua.ChuyenKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("LyDo", ketQua.LyDo));
                Command.Parameters.Add(new MDB.MDBParameter("KetQua", ketQua.KetQua));
                Command.Parameters.Add(new MDB.MDBParameter("KetLuan", ketQua.KetLuan));
                Command.Parameters.Add(new MDB.MDBParameter("DuDieuKienTiem", ketQua.DuDieuKienTiem ? 1:0));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiVacXin", ketQua.LoaiVacXin));
                Command.Parameters.Add(new MDB.MDBParameter("ChongChiDinhTiem", ketQua.ChongChiDinhTiem ? 1:0));
                Command.Parameters.Add(new MDB.MDBParameter("TamHoanTiemChung", ketQua.TamHoanTiemChung ? 1:0));
                Command.Parameters.Add(new MDB.MDBParameter("NgayLapPhieu", ketQua.NgayLapPhieu));            
                Command.Parameters.Add(new MDB.MDBParameter("NguoiThucHien", ketQua.NguoiThucHien));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiThucHien", ketQua.MaNguoiThucHien));
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
                string sql = "DELETE FROM BangKiemTTCVoiTreTren1ThangT WHERE ID = :ID";
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
                BangKiemTTCVoiTreTren1ThangT P
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "KQ");
            ds.Tables[0].AddColumn("LoGoPath", typeof(string));
            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));
            ds.Tables[0].AddColumn("NamSinh", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(string));
            ds.Tables[0].AddColumn("SOYTE", typeof(string));
            ds.Tables[0].AddColumn("BENHVIEN", typeof(string));

            ds.Tables[0].Rows[0]["LoGoPath"] = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\PaintLibrary\HinhAnh\LoGoVien\" + "Logo.png";
            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["NamSinh"] = XemBenhAn._HanhChinhBenhNhan.NgaySinh.HasValue ? XemBenhAn._HanhChinhBenhNhan.NgaySinh.Value.Year + "" : "";
            ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            ds.Tables[0].Rows[0]["SOYTE"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;

            return ds;
        }
    }

}
