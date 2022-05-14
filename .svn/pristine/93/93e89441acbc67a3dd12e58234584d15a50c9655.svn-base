using EMR.KyDienTu;
using EMR_MAIN.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace EMR_MAIN.DATABASE.Other
{
    public class ThongSoThamDo
    {
        public string ThongSo { get; set; }
        public string Truoc_CoBan { get; set; }
        public string Truoc_Atropin { get; set; }
        public string Sau_CoBan { get; set; }
        public string Sau_Atropin { get; set; }
    }
    public class PhieuTraKetQuaDTRF : ThongTinKy
    {
        public PhieuTraKetQuaDTRF()
        {
            TableName = "PhieuTraKetQuaDTRF";
            TablePrimaryKeyName = "ID";
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }
        [MoTaDuLieu("Buồng")]
		public string Buong { get; set; }
        [MoTaDuLieu("Giường")]
		public string Giuong { get; set; }
        [MoTaDuLieu("Mã giường")]
		public string MaGiuong { get; set; }
        [MoTaDuLieu("Mã bác sỹ điều trị")]
		public string MaBacSyDieuTri { get; set; }
        public string TenBacSyDieuTri { get; set; }
        public string MaBacSyThuThuat { get; set; }
        public string TenBacSyThuThuat { get; set; }
        public double ThoiGianThuThuat { get; set; }
        public DateTime NgayThucHienTT { get; set; }
        public double ThoiGianChieuTia { get; set; }
        public bool[] DienSinhLyArray { get; } = new bool[] { false, false };
        public int DienSinhLy
        {
            get
            {
                return Array.IndexOf(DienSinhLyArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) DienSinhLyArray[i] = true;
                    else DienSinhLyArray[i] = false;
                }
            }
        }
        public bool[] TanSoRadioArray { get; } = new bool[] { false, false };
        public int TanSoRadio
        {
            get
            {
                return Array.IndexOf(TanSoRadioArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) TanSoRadioArray[i] = true;
                    else TanSoRadioArray[i] = false;
                }
            }
        }
        public string BoDungCuDuongVao { get; set; }
        public string DienCucThamDo { get; set; }
        public string CapThamDo { get; set; }
        public string DienCucDot { get; set; }
        public string LoaiKhac { get; set; }
        public string DienCucNhi { get; set; }
        public string DienCucXoang { get; set; }
        public string DienCucMapping { get; set; }
        public string GayRLNT { get; set; }
        public string KhongGayRLNT { get; set; }
        public string LoaiRLNT { get; set; }
        public string ViTriTrietDot { get; set; }
        public double ThoiGian { get; set; }
        public string NhanXetKhac { get; set; }
        public string BienChung { get; set; }
        public string KetLuan { get; set; }
        // 3. Thong So tham do dien tim
        public ObservableCollection<ThongSoThamDo> ThongSoChinh { get; set; }
        public ObservableCollection<ThongSoThamDo> ChieuXuoi { get; set; }
        public ObservableCollection<ThongSoThamDo> ChieuNguoc { get; set; }
        public ObservableCollection<ThongSoThamDo> ConNhipNhanh { get; set; }
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
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        public string HinhAnhMoTa { get; set; }

    }
    public class PhieuTraKetQuaDTRFFunc
    {
        public const string TableName = "PhieuTraKetQuaDTRF";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuTraKetQuaDTRF> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuTraKetQuaDTRF> list = new List<PhieuTraKetQuaDTRF>();
            try
            {
                string sql = @"SELECT * FROM PhieuTraKetQuaDTRF where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuTraKetQuaDTRF data = new PhieuTraKetQuaDTRF();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.TenBenhNhan = DataReader["TenBenhNhan"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.Khoa = DataReader["Khoa"].ToString();
                    data.MaKhoa = DataReader["MaKhoa"].ToString();
                    data.Buong = DataReader["Buong"].ToString();
                    data.Giuong = DataReader["Giuong"].ToString();
                    data.MaGiuong = DataReader["MaGiuong"].ToString();
                    data.MaBacSyDieuTri = DataReader["MaBacSyDieuTri"].ToString();
                    data.TenBacSyDieuTri = DataReader["TenBacSyDieuTri"].ToString();
                    data.MaBacSyThuThuat = DataReader["MaBacSyThuThuat"].ToString();
                    data.TenBacSyThuThuat = DataReader["TenBacSyThuThuat"].ToString();
                    data.NgayThucHienTT = Common.ConDB_DateTime(DataReader["NgayThucHienTT"]);

                    double tempDouble = 0;
                    double.TryParse(DataReader["ThoiGianThuThuat"].ToString(), out tempDouble);
                    data.ThoiGianThuThuat = tempDouble;

                    tempDouble = 0;
                    double.TryParse(DataReader["ThoiGianChieuTia"].ToString(), out tempDouble);
                    data.ThoiGianChieuTia = tempDouble;

                    int tempInt = 0;
                    int.TryParse(DataReader["DienSinhLy"].ToString(), out tempInt);
                    data.DienSinhLy = tempInt;

                    tempInt = 0;
                    int.TryParse(DataReader["TanSoRadio"].ToString(), out tempInt);
                    data.TanSoRadio = tempInt;


                    data.BoDungCuDuongVao = DataReader["BoDungCuDuongVao"].ToString();
                    data.DienCucThamDo = DataReader["DienCucThamDo"].ToString();
                    data.CapThamDo = DataReader["CapThamDo"].ToString();
                    data.DienCucDot = DataReader["DienCucDot"].ToString();

                    data.LoaiKhac = DataReader["LoaiKhac"].ToString();
                    data.DienCucNhi = DataReader["DienCucNhi"].ToString();
                    data.DienCucXoang = DataReader["DienCucXoang"].ToString();
                    data.DienCucMapping = DataReader["DienCucMapping"].ToString();
                    data.GayRLNT = DataReader["GayRLNT"].ToString();
                    data.KhongGayRLNT = DataReader["KhongGayRLNT"].ToString();
                    data.LoaiRLNT = DataReader["LoaiRLNT"].ToString();
                    data.ViTriTrietDot = DataReader["ViTriTrietDot"].ToString();

                    tempDouble = 0;
                    double.TryParse(DataReader["ThoiGian"].ToString(), out tempDouble);
                    data.ThoiGian = tempDouble;

                    data.NhanXetKhac = DataReader["NhanXetKhac"].ToString();
                    data.BienChung = DataReader["BienChung"].ToString();
                    data.KetLuan = DataReader["KetLuan"].ToString();
                    data.ThongSoChinh = JsonConvert.DeserializeObject<ObservableCollection<ThongSoThamDo>>(DataReader["ThongSoChinh"].ToString());
                    data.ChieuXuoi = JsonConvert.DeserializeObject<ObservableCollection<ThongSoThamDo>>(DataReader["ChieuXuoi"].ToString());
                    data.ChieuNguoc = JsonConvert.DeserializeObject<ObservableCollection<ThongSoThamDo>>(DataReader["ChieuNguoc"].ToString());
                    data.ConNhipNhanh = JsonConvert.DeserializeObject<ObservableCollection<ThongSoThamDo>>(DataReader["ConNhipNhanh"].ToString());

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuTraKetQuaDTRF phieuTraKetQua)
        {
            try
            {
                string sql = @"INSERT INTO PhieuTraKetQuaDTRF
                (
                    MAQUANLY,
                    MaBenhNhan,
                    TenBenhNhan,
	                ChanDoan,
	                Khoa,
	                MaKhoa,
	                Buong,
	                Giuong,
	                MaGiuong,
	                MaBacSyDieuTri,
	                TenBacSyDieuTri,
	                MaBacSyThuThuat,
	                TenBacSyThuThuat,
	                ThoiGianThuThuat,
                    NgayThucHienTT,
	                ThoiGianChieuTia,
	                DienSinhLy,
	                TanSoRadio,
	                BoDungCuDuongVao, 
	                DienCucThamDo,
	                CapThamDo,
	                DienCucDot,
	                LoaiKhac,
	                DienCucNhi, 
	                DienCucXoang, 
	                DienCucMapping, 
	                GayRLNT,
	                KhongGayRLNT,
	                LoaiRLNT,
	                ViTriTrietDot,
	                ThoiGian,
	                NhanXetKhac, 
	                BienChung,
	                KetLuan,
	                ThongSoChinh,
	                ChieuXuoi,
	                ChieuNguoc,
	                ConNhipNhanh,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :TenBenhNhan,
	                :ChanDoan,
	                :Khoa,
	                :MaKhoa,
	                :Buong,
	                :Giuong,
	                :MaGiuong,
	                :MaBacSyDieuTri,
	                :TenBacSyDieuTri,
	                :MaBacSyThuThuat,
	                :TenBacSyThuThuat,
	                :ThoiGianThuThuat,
                    :NgayThucHienTT,
	                :ThoiGianChieuTia,
	                :DienSinhLy,
	                :TanSoRadio,
	                :BoDungCuDuongVao, 
	                :DienCucThamDo,
	                :CapThamDo,
	                :DienCucDot,
	                :LoaiKhac,
	                :DienCucNhi, 
	                :DienCucXoang, 
	                :DienCucMapping, 
	                :GayRLNT,
	                :KhongGayRLNT,
	                :LoaiRLNT,
	                :ViTriTrietDot,
	                :ThoiGian,
	                :NhanXetKhac, 
	                :BienChung,
	                :KetLuan,
	                :ThongSoChinh,
	                :ChieuXuoi,
	                :ChieuNguoc,
	                :ConNhipNhanh,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (phieuTraKetQua.ID != 0)
                {
                    sql = @"UPDATE PhieuTraKetQuaDTRF SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    TenBenhNhan = :TenBenhNhan,
	                ChanDoan = :ChanDoan,
	                Khoa = :Khoa,
	                MaKhoa = :MaKhoa,
	                Buong = :Buong,
	                Giuong = :Giuong,
	                MaGiuong = :MaGiuong,
	                MaBacSyDieuTri = :MaBacSyDieuTri,
	                TenBacSyDieuTri = :TenBacSyDieuTri,
	                MaBacSyThuThuat = :MaBacSyThuThuat,
	                TenBacSyThuThuat = :TenBacSyThuThuat,
	                ThoiGianThuThuat = :ThoiGianThuThuat,
                    NgayThucHienTT = :NgayThucHienTT,
	                ThoiGianChieuTia = :ThoiGianChieuTia,
	                DienSinhLy = :DienSinhLy,
	                TanSoRadio = :TanSoRadio,
	                BoDungCuDuongVao = :BoDungCuDuongVao, 
	                DienCucThamDo = :DienCucThamDo,
	                CapThamDo = :CapThamDo,
	                DienCucDot = :DienCucDot,
	                LoaiKhac = :LoaiKhac,
	                DienCucNhi = :DienCucNhi, 
	                DienCucXoang = :DienCucXoang, 
	                DienCucMapping = :DienCucMapping, 
	                GayRLNT = :GayRLNT,
	                KhongGayRLNT = :KhongGayRLNT,
	                LoaiRLNT = :LoaiRLNT,
	                ViTriTrietDot = :ViTriTrietDot,
	                ThoiGian = :ThoiGian,
	                NhanXetKhac = :NhanXetKhac, 
	                BienChung = :BienChung,
	                KetLuan = :KetLuan,
	                ThongSoChinh = :ThongSoChinh,
	                ChieuXuoi = :ChieuXuoi,
	                ChieuNguoc = :ChieuNguoc,
	                ConNhipNhanh = :ConNhipNhanh,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + phieuTraKetQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", phieuTraKetQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", phieuTraKetQua.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("TenBenhNhan", phieuTraKetQua.TenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", phieuTraKetQua.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa", phieuTraKetQua.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaKhoa", phieuTraKetQua.MaKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("Buong", phieuTraKetQua.Buong));
                Command.Parameters.Add(new MDB.MDBParameter("Giuong", phieuTraKetQua.Giuong));
                Command.Parameters.Add(new MDB.MDBParameter("MaGiuong", phieuTraKetQua.MaGiuong));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSyDieuTri", phieuTraKetQua.MaBacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TenBacSyDieuTri", phieuTraKetQua.TenBacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSyThuThuat", phieuTraKetQua.MaBacSyThuThuat));
                Command.Parameters.Add(new MDB.MDBParameter("TenBacSyThuThuat", phieuTraKetQua.TenBacSyThuThuat));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianThuThuat", phieuTraKetQua.ThoiGianThuThuat));
                Command.Parameters.Add(new MDB.MDBParameter("NgayThucHienTT", phieuTraKetQua.NgayThucHienTT));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianChieuTia", phieuTraKetQua.ThoiGianChieuTia));
                Command.Parameters.Add(new MDB.MDBParameter("DienSinhLy", phieuTraKetQua.DienSinhLy));
                Command.Parameters.Add(new MDB.MDBParameter("TanSoRadio", phieuTraKetQua.TanSoRadio));
                Command.Parameters.Add(new MDB.MDBParameter("BoDungCuDuongVao", phieuTraKetQua.BoDungCuDuongVao));
                Command.Parameters.Add(new MDB.MDBParameter("DienCucThamDo", phieuTraKetQua.DienCucThamDo));
                Command.Parameters.Add(new MDB.MDBParameter("CapThamDo", phieuTraKetQua.CapThamDo));
                Command.Parameters.Add(new MDB.MDBParameter("DienCucDot", phieuTraKetQua.DienCucDot));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiKhac", phieuTraKetQua.LoaiKhac));
                Command.Parameters.Add(new MDB.MDBParameter("DienCucNhi", phieuTraKetQua.DienCucNhi));
                Command.Parameters.Add(new MDB.MDBParameter("DienCucXoang", phieuTraKetQua.DienCucXoang));
                Command.Parameters.Add(new MDB.MDBParameter("DienCucMapping", phieuTraKetQua.DienCucMapping));
                Command.Parameters.Add(new MDB.MDBParameter("GayRLNT", phieuTraKetQua.GayRLNT));
                Command.Parameters.Add(new MDB.MDBParameter("KhongGayRLNT", phieuTraKetQua.KhongGayRLNT));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiRLNT", phieuTraKetQua.LoaiRLNT));
                Command.Parameters.Add(new MDB.MDBParameter("ViTriTrietDot", phieuTraKetQua.ViTriTrietDot));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGian", phieuTraKetQua.ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("NhanXetKhac", phieuTraKetQua.NhanXetKhac));
                Command.Parameters.Add(new MDB.MDBParameter("BienChung", phieuTraKetQua.BienChung));
                Command.Parameters.Add(new MDB.MDBParameter("KetLuan", phieuTraKetQua.KetLuan));
                Command.Parameters.Add(new MDB.MDBParameter("KetLuan", phieuTraKetQua.KetLuan));
                Command.Parameters.Add(new MDB.MDBParameter("ThongSoChinh", JsonConvert.SerializeObject(phieuTraKetQua.ThongSoChinh)));
                Command.Parameters.Add(new MDB.MDBParameter("ChieuXuoi", JsonConvert.SerializeObject(phieuTraKetQua.ChieuXuoi)));
                Command.Parameters.Add(new MDB.MDBParameter("ChieuNguoc", JsonConvert.SerializeObject(phieuTraKetQua.ChieuNguoc)));
                Command.Parameters.Add(new MDB.MDBParameter("ConNhipNhanh", JsonConvert.SerializeObject(phieuTraKetQua.ConNhipNhanh)));

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", phieuTraKetQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", phieuTraKetQua.NgaySua));
                if (phieuTraKetQua.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", phieuTraKetQua.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", phieuTraKetQua.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", phieuTraKetQua.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (phieuTraKetQua.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    phieuTraKetQua.ID = nextval;
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
                string sql = "DELETE FROM PhieuTraKetQuaDTRF WHERE ID = :ID";
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
        public static string downloadAnhMoTa(long ID, decimal maQuanLy)
        {
            string fullPath = "";
            try
            {
                string FileHinhAnh = @"\PTKQDTRF\" + maQuanLy;
                if (ID != 0)
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
                            string fileName = FileHinhAnh.Trim('\\') + "\\" + ID + ".png";
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
                                            fileHinhAnh = fullPath.Trim('\\') + "\\COPY_" + lstFile.FileName;
                                            File.WriteAllBytes(fileHinhAnh, lstFile.ArrayBytes);
                                        }
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
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return fullPath;
        }
        public static DataSet getDataSet(MDB.MDBConnection MyConnection, long id)
        {
            string sql = @"SELECT
                B.*,
                T.MABENHAN,
                H.SOYTE,
                H.BENHVIEN,
                H.GIOITINH,
                H.TUOI,
                (H.SONHA || ',' || H.THONPHO || ',' ||  H.XAPHUONG || ',' ||  H.HUYENQUAN || ',' ||  H.TINHTHANHPHO) AS DIACHI 
            FROM
                PhieuTraKetQuaDTRF B
                LEFT JOIN THONGTINDIEUTRI T ON B.MAQUANLY = T.MAQUANLY
                LEFT JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "PKQ");

            DataRow rowTable = ds.Tables[0].Rows[0];
            ObservableCollection<ThongSoThamDo> ThongSoChinhs = JsonConvert.DeserializeObject<ObservableCollection<ThongSoThamDo>>(rowTable["ThongSoChinh"].ToString());
            ObservableCollection<ThongSoThamDo> ChieuXuois = JsonConvert.DeserializeObject<ObservableCollection<ThongSoThamDo>>(rowTable["ChieuXuoi"].ToString());
            ObservableCollection<ThongSoThamDo> ChieuNguocs = JsonConvert.DeserializeObject<ObservableCollection<ThongSoThamDo>>(rowTable["ChieuNguoc"].ToString());
            ObservableCollection<ThongSoThamDo> ConNhipNhanhs = JsonConvert.DeserializeObject<ObservableCollection<ThongSoThamDo>>(rowTable["ConNhipNhanh"].ToString());

            DataTable ThongSoChinh = new DataTable("ThongSoChinh");
            ThongSoChinh.Columns.Add("ThongSo");
            ThongSoChinh.Columns.Add("Truoc_CoBan");
            ThongSoChinh.Columns.Add("Truoc_Atropin");
            ThongSoChinh.Columns.Add("Sau_CoBan");
            ThongSoChinh.Columns.Add("Sau_Atropin");
            foreach (ThongSoThamDo thongSo in ThongSoChinhs)
            {
                ThongSoChinh.Rows.Add(thongSo.ThongSo, thongSo.Truoc_CoBan, thongSo.Truoc_Atropin, thongSo.Sau_CoBan, thongSo.Sau_Atropin);
            }

            DataTable ChieuXuoi = new DataTable("ChieuXuoi");
            ChieuXuoi.Columns.Add("ThongSo");
            ChieuXuoi.Columns.Add("Truoc_CoBan");
            ChieuXuoi.Columns.Add("Truoc_Atropin");
            ChieuXuoi.Columns.Add("Sau_CoBan");
            ChieuXuoi.Columns.Add("Sau_Atropin");
            foreach (ThongSoThamDo thongSo in ChieuXuois)
            {
                ChieuXuoi.Rows.Add(thongSo.ThongSo, thongSo.Truoc_CoBan, thongSo.Truoc_Atropin, thongSo.Sau_CoBan, thongSo.Sau_Atropin);
            }

            DataTable ChieuNguoc = new DataTable("ChieuNguoc");
            ChieuNguoc.Columns.Add("ThongSo");
            ChieuNguoc.Columns.Add("Truoc_CoBan");
            ChieuNguoc.Columns.Add("Truoc_Atropin");
            ChieuNguoc.Columns.Add("Sau_CoBan");
            ChieuNguoc.Columns.Add("Sau_Atropin");
            foreach (ThongSoThamDo thongSo in ChieuNguocs)
            {
                ChieuNguoc.Rows.Add(thongSo.ThongSo, thongSo.Truoc_CoBan, thongSo.Truoc_Atropin, thongSo.Sau_CoBan, thongSo.Sau_Atropin);
            }
            DataTable ConNhipNhanh = new DataTable("ConNhipNhanh");
            ConNhipNhanh.Columns.Add("ThongSo");
            ConNhipNhanh.Columns.Add("Truoc_CoBan");
            ConNhipNhanh.Columns.Add("Truoc_Atropin");
            ConNhipNhanh.Columns.Add("Sau_CoBan");
            ConNhipNhanh.Columns.Add("Sau_Atropin");
            foreach (ThongSoThamDo thongSo in ConNhipNhanhs)
            {
                ConNhipNhanh.Rows.Add(thongSo.ThongSo, thongSo.Truoc_CoBan, thongSo.Truoc_Atropin, thongSo.Sau_CoBan, thongSo.Sau_Atropin);
            }

            DataTable thongTinVien = new DataTable("HEADER");

            thongTinVien.Columns.Add("BENHVIEN");
            thongTinVien.Columns.Add("KHOA");
            thongTinVien.Columns.Add("SOYTE");
            if (XemBenhAn._HanhChinhBenhNhan == null) XemBenhAn._HanhChinhBenhNhan = new HanhChinhBenhNhan();
            if (XemBenhAn._ThongTinDieuTri == null) XemBenhAn._ThongTinDieuTri = new ThongTinDieuTri();

            thongTinVien.Rows.Add(XemBenhAn._HanhChinhBenhNhan.BenhVien, XemBenhAn._ThongTinDieuTri.Khoa, XemBenhAn._HanhChinhBenhNhan.SoYTe);
            ds.Tables.Add(thongTinVien);

            ds.Tables.Add(ThongSoChinh);
            ds.Tables.Add(ChieuXuoi);
            ds.Tables.Add(ChieuNguoc);
            ds.Tables.Add(ConNhipNhanh);

            return ds;
        }
    }
}
