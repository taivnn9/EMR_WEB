using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Http;
using System.Net.Http.Headers;
using EMR_MAIN.ViewModel;
using Newtonsoft.Json;
using System.IO;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuThuThuat : ThongTinKy
    {
        public PhieuThuThuat()
        {
            TableName = "PhieuThuThuat";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PTT;
            TenMauPhieu = DanhMucPhieu.PTT.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        public string HoTenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }
        public DateTime? NgayVaoVien { get; set; }
        public DateTime? NgayVaoVien_Gio { get; set; }
        public DateTime? NgayThuThuat { get; set; }
        public DateTime? NgayThuThuat_Gio { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public string PhuongPhapThuThuat { get; set; }
        public string LoaiThuThuat { get; set; }
        public string PhuongPhapVoCam { get; set; }
        public string BacSyGayMe { get; set; }
        public string MaBacSyGayMe { get; set; }
        public string ThuocDung { get; set; }
        public string TrinhTuThuThuat { get; set; }
        public string ThuThuatVien { get; set; }
        public string MaThuThuatVien { get; set; }
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
        public string MaPhieu { get; set; }
    }
    public class PhieuThuThuatFunc
    {
        public const string TableName = "PhieuThuThuat";
        public const string TablePrimaryKeyName = "ID";
        public static string PathApp = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"/PaintLibrary/HinhAnh/ThuThuat/";
        public static List<PhieuThuThuat> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuThuThuat> list = new List<PhieuThuThuat>();
            try
            {
                string sql = @"SELECT * FROM PhieuThuThuat where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuThuThuat data = new PhieuThuThuat();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.HoTenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.Khoa = DataReader["Khoa"].ToString();
                    data.MaKhoa = DataReader["MaKhoa"].ToString();
                    data.NgayVaoVien = DataReader["NgayVaoVien"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayVaoVien"]) : null;
                    data.NgayVaoVien_Gio = data.NgayVaoVien;
                    data.NgayThuThuat = DataReader["NgayThuThuat"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayThuThuat"]) : null;
                    data.NgayThuThuat_Gio = data.NgayThuThuat;
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.PhuongPhapThuThuat = DataReader["PhuongPhapThuThuat"].ToString();
                    data.LoaiThuThuat = DataReader["LoaiThuThuat"].ToString();
                    data.PhuongPhapVoCam = DataReader["PhuongPhapVoCam"].ToString();
                    data.BacSyGayMe = DataReader["BacSyGayMe"].ToString();
                    data.MaBacSyGayMe = DataReader["MaBacSyGayMe"].ToString();
                    data.ThuocDung = DataReader["ThuocDung"].ToString();
                    data.TrinhTuThuThuat = DataReader["TrinhTuThuThuat"].ToString();
                    data.ThuThuatVien = DataReader["ThuThuatVien"].ToString();
                    data.MaPhieu = DataReader["MaPhieu"].ToString();

                    data.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                    data.NguoiTao = DataReader["NguoiTao"].ToString();
                    data.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);
                    data.NguoiSua = DataReader["NguoiSua"].ToString();
                    data.NguoiSua = DataReader["NguoiSua"].ToString();

                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;
                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuThuThuat ketQua)
        {
            try
            {
                string sql = @"INSERT INTO PhieuThuThuat
                (
                    MAQUANLY,
                    MaBenhNhan,
                    Khoa,
                    MaKhoa,
                    NgayVaoVien,
                    NgayThuThuat,
                    ChanDoan,
                    PhuongPhapThuThuat,
                    LoaiThuThuat,
                    PhuongPhapVoCam,
                    BacSyGayMe,
                    MaBacSyGayMe,
                    ThuocDung,
                    TrinhTuThuThuat,
                    ThuThuatVien,
                    MaThuThuatVien,
                    MaPhieu,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :Khoa,
                    :MaKhoa,
                    :NgayVaoVien,
                    :NgayThuThuat,
                    :ChanDoan,
                    :PhuongPhapThuThuat,
                    :LoaiThuThuat,
                    :PhuongPhapVoCam,
                    :BacSyGayMe,
                    :MaBacSyGayMe,
                    :ThuocDung,
                    :TrinhTuThuThuat,
                    :ThuThuatVien,
                    :MaThuThuatVien,
                    :MaPhieu,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE PhieuThuThuat SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    Khoa = :Khoa,
                    MaKhoa = :MaKhoa,
                    NgayVaoVien = :NgayVaoVien,
                    NgayThuThuat = :NgayThuThuat,
                    ChanDoan = :ChanDoan,
                    PhuongPhapThuThuat = :PhuongPhapThuThuat,
                    LoaiThuThuat = :LoaiThuThuat,
                    PhuongPhapVoCam = :PhuongPhapVoCam,
                    BacSyGayMe = :BacSyGayMe,
                    MaBacSyGayMe = :MaBacSyGayMe,
                    ThuocDung = :ThuocDung,
                    TrinhTuThuThuat = :TrinhTuThuThuat,
                    ThuThuatVien = :ThuThuatVien,
                    MaThuThuatVien = :MaThuThuatVien,
                    MaPhieu = :MaPhieu,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ketQua.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa", ketQua.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaKhoa", ketQua.MaKhoa));
                var NgayGio = ketQua.NgayVaoVien;
                if (NgayGio != null)
                {
                    var Gio = ketQua.NgayVaoVien_Gio.HasValue ? ketQua.NgayVaoVien_Gio.Value.TimeOfDay : new TimeSpan(0, 0, 0);
                    NgayGio = NgayGio + Gio;
                }
                Command.Parameters.Add(new MDB.MDBParameter("NgayVaoVien", NgayGio));
                NgayGio = ketQua.NgayThuThuat;
                if (NgayGio != null)
                {
                    var Gio = ketQua.NgayThuThuat_Gio.HasValue ? ketQua.NgayThuThuat_Gio.Value.TimeOfDay : new TimeSpan(0, 0, 0);
                    NgayGio = NgayGio + Gio;
                }
                Command.Parameters.Add(new MDB.MDBParameter("NgayThuThuat", NgayGio));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", ketQua.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapThuThuat", ketQua.PhuongPhapThuThuat));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiThuThuat", ketQua.LoaiThuThuat));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapVoCam", ketQua.PhuongPhapVoCam));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyGayMe", ketQua.BacSyGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSyGayMe", ketQua.MaBacSyGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocDung", ketQua.ThuocDung));
                Command.Parameters.Add(new MDB.MDBParameter("TrinhTuThuThuat", ketQua.TrinhTuThuThuat));
                Command.Parameters.Add(new MDB.MDBParameter("ThuThuatVien", ketQua.ThuThuatVien));
                Command.Parameters.Add(new MDB.MDBParameter("MaThuThuatVien", ketQua.MaThuThuatVien));
                Command.Parameters.Add(new MDB.MDBParameter("MaThuThuatVien", ketQua.MaThuThuatVien));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));
                Command.Parameters.Add(new MDB.MDBParameter("MaPhieu", ketQua.MaPhieu));
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
                string sql = "DELETE FROM PhieuThuThuat WHERE ID = :ID";
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
                PhieuThuThuat P
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "KQ");

            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(int));
            ds.Tables[0].AddColumn("SOYTE", typeof(string));
            ds.Tables[0].AddColumn("BENHVIEN", typeof(string));
            ds.Tables[0].AddColumn("SoVaoVien", typeof(string));
            ds.Tables[0].AddColumn("MaBenhAn", typeof(string));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["GioiTinh"] = (int)XemBenhAn._HanhChinhBenhNhan.GioiTinh;
            ds.Tables[0].Rows[0]["SOYTE"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["SoVaoVien"] = XemBenhAn._ThongTinDieuTri.SoNhapVien;
            ds.Tables[0].Rows[0]["MaBenhAn"] = XemBenhAn._ThongTinDieuTri.MaBenhAn;

            return ds;
        }
        public static string DownloadAnhMoTa(int stt, decimal IdThuThuat, decimal maQuanLy, string MaPhieu, bool WSActive)
        {
            string fullPath = "";
            bool checkResult = false;
            try
            {
                string FileHinhAnh = @"\PTT_" + stt + @"\" + maQuanLy;
                if (IdThuThuat != 0M)
                {
                    if (WSActive)
                    {
                        using (var client = new HttpClient())
                        {
                            try
                            {
                                string URL = ERMDatabase.WebServiceEMR;
                                client.BaseAddress = new Uri(URL);
                                client.DefaultRequestHeaders.Accept.Clear();
                                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                                client.Timeout = new TimeSpan(0, 0, 1000);
                                string fileName = FileHinhAnh.Trim('\\') + "\\" + IdThuThuat + ".png";
                                var url = "api/KetXuat/Get1File?PathFile=" + fileName;
                                HttpResponseMessage response = client.GetAsync(url).Result;
                                response.EnsureSuccessStatusCode();
                                if (response.IsSuccessStatusCode)
                                {
                                    string result = response.Content.ReadAsStringAsync().Result;
                                    if (result != "null" && result != "[]")
                                    {
                                        FileCopy lstFile = JsonConvert.DeserializeObject<FileCopy>(result);
                                        if (lstFile != null)
                                        {
                                            string tempPath = System.IO.Path.GetTempPath().Trim('\\');
                                            fullPath = tempPath.Trim('\\') + "\\" + FileHinhAnh.Trim('\\');
                                            if (!System.IO.Directory.Exists(fullPath)) { System.IO.Directory.CreateDirectory(fullPath); }
                                            string fileHinhAnh = fullPath.Trim('\\') + "\\" + lstFile.FileName;
                                            try
                                            {
                                                File.WriteAllBytes(fileHinhAnh, lstFile.ArrayBytes);
                                            }
                                            catch
                                            {
                                            }
                                            checkResult = true;
                                        }
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                XuLyLoi.LogError(ex);
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            if (!checkResult && !string.IsNullOrEmpty(MaPhieu))
            {

                switch (MaPhieu)
                {
                    case "DatCatetherDongMach": //0
                        if (stt == 1)
                            fullPath = PathApp + "Catether_DM_1.png";
                        else if (stt == 2)
                            fullPath = PathApp + "Catether_DM_2.png";
                        break;
                    case "ChocDichMangTim": //2
                        if (stt == 1)
                            fullPath = PathApp + "ChocDichMangTim_1.png";
                        else if (stt == 2)
                            fullPath = PathApp + "ChocDichMangTim_2.png"; ; //null
                        break;
                    case "DatDanLuuMangPhoi": //3
                        if (stt == 1)
                            fullPath = PathApp + "DanLuuMp_1.png";
                        else if (stt == 2)
                            fullPath = PathApp + "DanLuuMp_2.png"; ; //null
                        break;
                    case "ShockDien": //4
                        if (stt == 1)
                            fullPath = PathApp + "SocDien_1.png";
                        break;
                    case "ChocDichNaoTuy": //4
                        if (stt == 1)
                            fullPath = PathApp + "ChocDichNaoTuy_1.png";
                        break;
                }
            }
            return fullPath;
        }
    }
    public class MauPhieuThuThuat
    {
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        public string MaPhieu { get; set; }
        public string PhuongPhapThuThuat { get; set; }
        public string ThuocDung { get; set; }
        public string LoaiThuThuat { get; set; }
        public string PhuongPhapVoCam { get; set; }
        public string pathAnh1 { get; set; }
        public string pathAnh2 { get; set; }
        public string TrinhTuThuThuat { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
    }
    public class MauPhieuThuThuatFunc
    {
        public static List<MauPhieuThuThuat> CreatePhieuMacDinh ()
        {
            List<MauPhieuThuThuat> lstDSPhieuTT = new List<MauPhieuThuThuat>();
            lstDSPhieuTT.Add(new MauPhieuThuThuat()
            {
                MaPhieu = "ChocDichOBung",
                PhuongPhapThuThuat = "Chọc hút dịch ổ bụng dưới hướng dẫn của siêu âm",
                ThuocDung = "Lidocain 2% 2ml",
                TrinhTuThuThuat = "- Xác định vị trí chọc dịch ổ bụng\n" +
"- Sát khuẩn tại vị trí chọc dịch\n" +
"- Gây tê tại chỗ và thăm dò dịch ổ bụng\n" +
"- Chọc hút dịch ổ bụng dưới hướng dẫn của siêu âm\n" +
"- Hút ra 5600  ml dịch màu vàng sậm\n" +
"- Sát khuẩn và băng ép tại vị trí chọc \n" +
"- Trong và sau quá trình làm thủ thuật bệnh nhân ổn định",
                PhuongPhapVoCam = "Gây tê tại chỗ",
                pathAnh1 = "",
                pathAnh2 = "",
            }) ;
            lstDSPhieuTT.Add(new MauPhieuThuThuat()
            {
                MaPhieu = "DatCatetherDongMach",
                PhuongPhapThuThuat = "Đặt catether động mạch",
                TrinhTuThuThuat = "- Sát khuẩn vị trí đặt HA động mạch \n" +
"- Chọc kim vào vị trí động mạch \n" +
"- Luồn guidewire, đặt catether qua guidewire\n" +
"- Cố định catether động mạch, kết nối bộ đo huyết áp liên tục\n" +
"- Thủ thuật an toàn",
                pathAnh1 = "Catether_DM_1.png",
                pathAnh2 = "Catether_DM_2.png",
            });
            lstDSPhieuTT.Add(new MauPhieuThuThuat()
            {
                MaPhieu = "ChocDichMangTim",
                PhuongPhapThuThuat = "Chọc hút dịch màng tim dưới hướng dẫn của siêu âm",
                TrinhTuThuThuat = "- Xác định vị trí chọc dịch màng tim\n" +
"- Sát khuẩn tại vị trí chọc dịch\n" +
"- Thăm dò dịch màng tim dưới hướng dẫn của siêu âm\n" +
"- Chọc hút dịch màng tim bằng catether/pigtail, hút dẫn lưu ra     ml dịch màu \n" +
"- Sát khuẩn và băng ép tại vị trí chọc \n" +
"- Trong và sau quá trình làm thủ thuật bệnh nhân ổn định",
                LoaiThuThuat = "Loại 1",
                pathAnh1 = "ChocDichMangTim_1.png",
                pathAnh2 = "ChocDichMangTim_2.png",
            });
            lstDSPhieuTT.Add(new MauPhieuThuThuat()
            {
                MaPhieu = "DatDanLuuMangPhoi",
                PhuongPhapThuThuat = "Đặt dẫn lưu màng phổi",
                TrinhTuThuThuat = "- Sát khuẩn, gây tê tại chỗ vị trí đặt dẫn lưu\n" +
"- Dùng panh phẫu tích vào khoang màng phổi .\n" +
"- Đặt dẫn lưu màng phổi bằng sheat quat 5f và pig tail 5f.\n" +
"- Cố định dẫn lưu\n" +
"- Kết nối hệ thống hút âm liên tục\n" +
"- Sát khuẩn, băng gạc .\n" +
"- Trong và sau quá trình làm thủ thuật bệnh nhân ổn định.",
                PhuongPhapVoCam ="Gây tê tại chỗ",
                pathAnh1 = "DanLuuMp_1.png",
                pathAnh2 = "DanLuuMp_2.png",
            });
            lstDSPhieuTT.Add(new MauPhieuThuThuat()
            {
                MaPhieu = "ShockDien",
                PhuongPhapThuThuat = "sock điện",
                ThuocDung = "Propofol ",
                TrinhTuThuThuat = "- Thở oxy 100% qua mask \n" +
"- Gây mê tĩnh mạch\n" +
"- Sock điện 150J\n" +
"- Thủ thuật an toàn",
                pathAnh1 = "SocDien_1.png"
            });
            lstDSPhieuTT.Add(new MauPhieuThuThuat()
            {
                MaPhieu = "ChocDichNaoTuy",
                PhuongPhapThuThuat = "chọc dò dịch não tủy",
                TrinhTuThuThuat = "- Xác định vị trí khe liên đốt l5, S1 Sát khuẩn, chải săng\n" +
"- Chọc kim vào khe liên đốt L5, S1 cho tới khi có dịch não tủy chảy ra, kiểm tra áp lực màu sắc, để dịc não tủy chảy tự nhiên ra  ml dịch làm xét nghiệm\n" +
"- Rút kim, sát khuẩn, băng ép",
                PhuongPhapVoCam = "Tê tại chỗ",
                pathAnh1 = "ChocDichNaoTuy_1.png"
            });
            lstDSPhieuTT.Add(new MauPhieuThuThuat()
            {
                MaPhieu = "DatCatherterTinhMachTrungTap",
                PhuongPhapThuThuat = "Đặt catherter tĩnh mạch trung tâm",
                TrinhTuThuThuat = "- Sát khuẩn da vùng đặt catherter\n" +
"- Gây tê tại chỗ và thăm dò tĩnh mạch bằng bơm 5ml\n" +
"- Đặt catherter tĩnh mạch tĩnh mạch dưới đòn (P)\n" +
"- Khâu cố định 15 cm sát mặt da\n" +
"- Thủ thuật an toàn",
                LoaiThuThuat = "1",
                PhuongPhapVoCam = "Gây tê tại chỗ",
                pathAnh1 = "DatCatherterTinhMachTrungTap_1.png"
            });
            lstDSPhieuTT.Add(new MauPhieuThuThuat()
            {
                MaPhieu = "ChocHutDichMangPhoi",
                PhuongPhapThuThuat = "Chọc hút dịch màng phổi dưới hướng dẫn của siêu âm",
                TrinhTuThuThuat = "- Xác định vị trí chọc dịch màng phổi\n" +
"- Sát khuẩn tại vị trí chọc dịch\n" +
"- Gây tê tại chỗ và thăm dò dịch màng phổi \n" +
"- Chọc hút dịch màng phổi dưới hướng dẫn của siêu âm \n" +
"- Dịch màng phổi bên Phải hút ra 500 ml , dịch màu vàng chanh\n" +
"- Sát khuẩn và băng ép tại vị trí chọc \n" +
"- Trong và sau quá trình làm thủ thuật bệnh nhân ổn định\n",
                PhuongPhapVoCam = "Gây tê tại chỗ",
                ThuocDung = "Lidocain 2% 2ml",
                pathAnh1 = "ChocHutDichMangPhoi_1.png",
                pathAnh2 = "ChocHutDichMangPhoi_2.png"
            });
            return lstDSPhieuTT;
        }
        public static List<MauPhieuThuThuat> GetDanhSachPhieu(MDB.MDBConnection MyConnection)
        {
            List<MauPhieuThuThuat> lstDSPhieuTT = new List<MauPhieuThuThuat>();
            try
            {
                string sql = "SELECT * FROM MAUPHIEUTHUTHUAT";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                MDB.MDBDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    MauPhieuThuThuat phieuThuThuat = new MauPhieuThuThuat();
                    phieuThuThuat.ID = dataReader.GetLong("ID");
                    phieuThuThuat.MaPhieu = dataReader["MaPhieu"].ToString();
                    phieuThuThuat.LoaiThuThuat = dataReader["LoaiThuThuat"].ToString();
                    phieuThuThuat.PhuongPhapThuThuat = dataReader["PhuongPhapThuThuat"].ToString();
                    phieuThuThuat.PhuongPhapVoCam = dataReader["PhuongPhapVoCam"].ToString();
                    phieuThuThuat.ThuocDung = dataReader["ThuocDung"].ToString();
                    phieuThuThuat.TrinhTuThuThuat = dataReader["TrinhTuThuThuat"].ToString();
                    phieuThuThuat.NgayTao = Convert.ToDateTime(dataReader["NgayTao"] == DBNull.Value ? DateTime.Now : dataReader["NgayTao"]);
                    phieuThuThuat.NguoiTao = dataReader["NguoiTao"].ToString();
                    phieuThuThuat.NgaySua = Convert.ToDateTime(dataReader["NgaySua"] == DBNull.Value ? DateTime.Now : dataReader["NgaySua"]);
                    phieuThuThuat.NguoiSua = dataReader["NguoiSua"].ToString();
                    
                    lstDSPhieuTT.Add(phieuThuThuat);
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }

            return lstDSPhieuTT;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref MauPhieuThuThuat phieuThuThuat)
        {
            try
            {
                string sql = @"INSERT INTO MAUPHIEUTHUTHUAT
                (
                    PhuongPhapThuThuat,
                    MaPhieu,
                    ThuocDung,
                    LoaiThuThuat,
                    TrinhTuThuThuat,
                    PhuongPhapVoCam,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :PhuongPhapThuThuat,
                    :MaPhieu,
                    :ThuocDung,
                    :LoaiThuThuat,
                    :TrinhTuThuThuat,
                    :PhuongPhapVoCam,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (phieuThuThuat.ID != 0)
                {
                    sql = @"UPDATE MAUPHIEUTHUTHUAT SET 
                    PhuongPhapThuThuat = :PhuongPhapThuThuat,
                    MaPhieu = :MaPhieu,
                    ThuocDung = :ThuocDung,
                    LoaiThuThuat = :LoaiThuThuat,
                    TrinhTuThuThuat = :TrinhTuThuThuat,
                    PhuongPhapVoCam = :PhuongPhapVoCam,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + phieuThuThuat.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapThuThuat", phieuThuThuat.PhuongPhapThuThuat));
                Command.Parameters.Add(new MDB.MDBParameter("MaPhieu", phieuThuThuat.MaPhieu));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocDung", phieuThuThuat.ThuocDung));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiThuThuat", phieuThuThuat.LoaiThuThuat));
                Command.Parameters.Add(new MDB.MDBParameter("TrinhTuThuThuat", phieuThuThuat.TrinhTuThuThuat));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapVoCam", phieuThuThuat.PhuongPhapVoCam));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", phieuThuThuat.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", phieuThuThuat.NgaySua));
                if (phieuThuThuat.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", phieuThuThuat.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", phieuThuThuat.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", phieuThuThuat.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (phieuThuThuat.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    phieuThuThuat.ID = nextval;
                }
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool Delete(MDB.MDBConnection MyConnection, MauPhieuThuThuat phieuThuThuat)
        {
            string sql = "DELETE FROM MAUPHIEUTHUTHUAT WHERE ID = :ID";
            MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
            command.Parameters.Add(new MDB.MDBParameter("ID", phieuThuThuat.ID));
            command.BindByName = true;
            int n = command.ExecuteNonQuery();
            return n > 0 ? true : false;
        }
    }
}

