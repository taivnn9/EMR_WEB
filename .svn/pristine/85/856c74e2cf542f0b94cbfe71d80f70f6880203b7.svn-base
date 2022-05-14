using EMR.KyDienTu;
using EMR_MAIN.ViewModel;
using Newtonsoft.Json;
using PMS.Access;
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
    public class KetQuarDongMachVanh
    {
        public string ViTriCanThiep { get; set; }
        public string TenThuThuat { get; set; }
        public string TenThietBi { get; set; }
        public string SoLanBomBong { get; set; }
        public double? KetQuaTruoc { get; set; }
        public double? KetQuaSau { get; set; }
        [MoTaDuLieu("Ghi chú")]
		public string GhiChu { get; set; }

    }
    public class PhieuTraKetQuaDTCanThiepDongMachVanh : ThongTinKy
    {
        public PhieuTraKetQuaDTCanThiepDongMachVanh()
        {
            TableName = "PhieuTraKetQuaDTCTDMV";
            TablePrimaryKeyName = "ID";
        }
        [MoTaDuLieu("Mã định danh")]
		public long IDPhieu { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        [MoTaDuLieu("Chẩn đoán lâm sàng")]
		public string ChanDoanLamSang { get; set; }
        [MoTaDuLieu("Mã bác sỹ điều trị")]
		public string MaBacSyDieuTri { get; set; }
        public string TenBacSyDieuTri { get; set; }
        public ObservableCollection<NhanVien> BacSyLamThuThuats { get; set; }
        public DateTime? NgayThucHienTT { get; set; }
        public bool NongDMV { get; set; }
        public string VitriNongDMV { get; set; }
        public bool DatGiaDoDMV { get; set; }
        public string VitriDatGiaDoDMV { get; set; }
        public bool[] LydoCanThiepAray { get; } = new bool[] { false, false, false };
        public int LydoCanThiep
        {
            get
            {
                return Array.IndexOf(LydoCanThiepAray, true) + 1;
            }
            set
            {
                for (int i = 0; i < LydoCanThiepAray.Length; i++)
                {
                    if (i == (value - 1)) LydoCanThiepAray[i] = true;
                    else LydoCanThiepAray[i] = false;
                }
            }
        }
        // Dụng cụ dùng 
        public string Introducer { get; set; }
        public string DCCatheter { get; set; }
        public string DC_JR { get; set; }
        public string DC_EBU { get; set; }
        public string DCWidewire { get; set; }
        public string DCSizingBallon { get; set; }
        public string DC_Stent { get; set; }
        public string DC_ThuocCanQuang { get; set; }

        // Tóm tắt quy trình
        public string TTQTDuongVao { get; set; }
        public string TTQTTienTrinh { get; set; }
        public string TTQTAnhMaTaPath { get; set; }
        public ObservableCollection<KetQuarDongMachVanh> KetQuas { get; set; }
        public string CacThuThuatKhac { get; set; }
        public string BienChungVaXuLy { get; set; }
        public string NhanXetKhac { get; set; }
        public string KetLuan { get; set; }

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
    }
    public class PhieuTraKetQuaDTCanThiepDongMachVanhFunc
    {
        public const string TableName = "PhieuTraKetQuaDTCTDMV";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuTraKetQuaDTCanThiepDongMachVanh> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuTraKetQuaDTCanThiepDongMachVanh> list = new List<PhieuTraKetQuaDTCanThiepDongMachVanh>();
            try
            {
                string sql = @"SELECT * FROM PhieuTraKetQuaDTCTDMV where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuTraKetQuaDTCanThiepDongMachVanh data = new PhieuTraKetQuaDTCanThiepDongMachVanh();
                    data.IDPhieu = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.TenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.DiaChi = DataReader["DiaChi"].ToString();
                    data.ChanDoanLamSang = DataReader["ChanDoanLamSang"].ToString();
                    data.MaBacSyDieuTri = DataReader["MaBacSyDieuTri"].ToString();
                    data.TenBacSyDieuTri = DataReader["TenBacSyDieuTri"].ToString();
                    data.BacSyLamThuThuats = JsonConvert.DeserializeObject <ObservableCollection<NhanVien>>(DataReader["BacSyLamThuThuats"].ToString());
                    data.NgayThucHienTT = DataReader["NgayThucHienTT"] == DBNull.Value ? (DateTime?)null : DataReader.GetDate("NgayThucHienTT");
                    data.NongDMV = DataReader["NongDMV"].ToString().Equals("1") ? true : false;
                    data.VitriNongDMV = DataReader["VitriNongDMV"].ToString();
                    data.DatGiaDoDMV = DataReader["DatGiaDoDMV"].ToString().Equals("1") ? true : false;
                    data.VitriDatGiaDoDMV = DataReader["VitriDatGiaDoDMV"].ToString();
                    data.LydoCanThiep = DataReader.GetInt("LydoCanThiep");
                    data.Introducer = DataReader["Introducer"].ToString();
                    data.DCCatheter = DataReader["DCCatheter"].ToString();
                    data.DCWidewire = DataReader["DCWidewire"].ToString();
                    data.DC_JR = DataReader["DC_JR"].ToString();
                    data.DC_EBU = DataReader["DC_EBU"].ToString();
                    data.DCSizingBallon = DataReader["DCSizingBallon"].ToString();
                    data.DC_Stent = DataReader["DC_Stent"].ToString();
                    data.DC_ThuocCanQuang = DataReader["DC_ThuocCanQuang"].ToString();
                    data.TTQTDuongVao = DataReader["TTQTDuongVao"].ToString();
                    data.TTQTTienTrinh = DataReader["TTQTTienTrinh"].ToString();
                    data.KetQuas = JsonConvert.DeserializeObject<ObservableCollection<KetQuarDongMachVanh>>(DataReader["KetQuas"].ToString());
                    data.CacThuThuatKhac = DataReader["CacThuThuatKhac"].ToString();
                    data.BienChungVaXuLy = DataReader["BienChungVaXuLy"].ToString();
                    data.NhanXetKhac = DataReader["NhanXetKhac"].ToString();
                    data.KetLuan = DataReader["KetLuan"].ToString();

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuTraKetQuaDTCanThiepDongMachVanh phieuTraKetQua)
        {
            try
            {
                string sql = @"INSERT INTO PhieuTraKetQuaDTCTDMV
                (
                    MAQUANLY,
                    MaBenhNhan,
                    DiaChi,
	                ChanDoanLamSang,
	                MaBacSyDieuTri,
	                TenBacSyDieuTri,
	                BacSyLamThuThuats,
	                NgayThucHienTT,
	                NongDMV,
	                VitriNongDMV,
	                DatGiaDoDMV,
	                VitriDatGiaDoDMV,
	                LydoCanThiep,
	                Introducer,
	                DCCatheter,
	                DCWidewire,
	                DC_JR,
	                DC_EBU,
	                DCSizingBallon,
	                DC_Stent,
	                DC_ThuocCanQuang,
	                TTQTDuongVao,
	                TTQTTienTrinh,
	                KetQuas,
	                CacThuThuatKhac,
	                BienChungVaXuLy,
	                NhanXetKhac,
	                KetLuan,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :DiaChi,
                    :ChanDoanLamSang,
                    :MaBacSyDieuTri,
                    :TenBacSyDieuTri,
                    :BacSyLamThuThuats,
                    :NgayThucHienTT,
                    :NongDMV,
                    :VitriNongDMV,
                    :DatGiaDoDMV,
                    :VitriDatGiaDoDMV,
                    :LydoCanThiep,
                    :Introducer,
                    :DCCatheter,
                    :DCWidewire,
                    :DC_JR,
                    :DC_EBU,
                    :DCSizingBallon,
                    :DC_Stent,
                    :DC_ThuocCanQuang,
                    :TTQTDuongVao,
                    :TTQTTienTrinh,
                    :KetQuas,
                    :CacThuThuatKhac,
                    :BienChungVaXuLy,
                    :NhanXetKhac,
                    :KetLuan,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (phieuTraKetQua.IDPhieu != 0)
                {
                    sql = @"UPDATE PhieuTraKetQuaDTCTDMV SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    DiaChi = :DiaChi,
                    ChanDoanLamSang = :ChanDoanLamSang,
                    MaBacSyDieuTri = :MaBacSyDieuTri,
                    TenBacSyDieuTri = :TenBacSyDieuTri,
                    BacSyLamThuThuats = :BacSyLamThuThuats,
                    NgayThucHienTT = :NgayThucHienTT,
                    NongDMV = :NongDMV,
                    VitriNongDMV = :VitriNongDMV,
                    DatGiaDoDMV = :DatGiaDoDMV,
                    VitriDatGiaDoDMV = :VitriDatGiaDoDMV,
                    LydoCanThiep = :LydoCanThiep,
                    Introducer = :Introducer,
                    DCCatheter = :DCCatheter,
                    DCWidewire = :DCWidewire,
                    DC_JR = :DC_JR,
                    DC_EBU = :DC_EBU,
                    DCSizingBallon = :DCSizingBallon,
                    DC_Stent = :DC_Stent,
                    DC_ThuocCanQuang = :DC_ThuocCanQuang,
                    TTQTDuongVao = :TTQTDuongVao,
                    TTQTTienTrinh = :TTQTTienTrinh,
                    KetQuas = :KetQuas,
                    CacThuThuatKhac = :CacThuThuatKhac,
                    BienChungVaXuLy = :BienChungVaXuLy,
                    NhanXetKhac = :NhanXetKhac,
                    KetLuan = :KetLuan,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + phieuTraKetQua.IDPhieu;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", phieuTraKetQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", phieuTraKetQua.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", phieuTraKetQua.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanLamSang", phieuTraKetQua.ChanDoanLamSang));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSyDieuTri", phieuTraKetQua.MaBacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TenBacSyDieuTri", phieuTraKetQua.TenBacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyLamThuThuats", JsonConvert.SerializeObject(phieuTraKetQua.BacSyLamThuThuats)));
                Command.Parameters.Add(new MDB.MDBParameter("NgayThucHienTT", phieuTraKetQua.NgayThucHienTT));
                Command.Parameters.Add(new MDB.MDBParameter("NongDMV", phieuTraKetQua.NongDMV ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("VitriNongDMV", phieuTraKetQua.VitriNongDMV));
                Command.Parameters.Add(new MDB.MDBParameter("DatGiaDoDMV", phieuTraKetQua.DatGiaDoDMV ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("VitriDatGiaDoDMV", phieuTraKetQua.VitriDatGiaDoDMV));
                Command.Parameters.Add(new MDB.MDBParameter("LydoCanThiep", phieuTraKetQua.LydoCanThiep));
                Command.Parameters.Add(new MDB.MDBParameter("Introducer", phieuTraKetQua.Introducer));
                Command.Parameters.Add(new MDB.MDBParameter("DCCatheter", phieuTraKetQua.DCCatheter));
                Command.Parameters.Add(new MDB.MDBParameter("DCWidewire", phieuTraKetQua.DCWidewire));
                Command.Parameters.Add(new MDB.MDBParameter("DC_JR", phieuTraKetQua.DC_JR));
                Command.Parameters.Add(new MDB.MDBParameter("DC_EBU", phieuTraKetQua.DC_EBU));
                Command.Parameters.Add(new MDB.MDBParameter("DCSizingBallon", phieuTraKetQua.DCSizingBallon));
                Command.Parameters.Add(new MDB.MDBParameter("DC_Stent", phieuTraKetQua.DC_Stent));
                Command.Parameters.Add(new MDB.MDBParameter("DC_ThuocCanQuang", phieuTraKetQua.DC_ThuocCanQuang));
                Command.Parameters.Add(new MDB.MDBParameter("TTQTDuongVao", phieuTraKetQua.TTQTDuongVao));
                Command.Parameters.Add(new MDB.MDBParameter("TTQTTienTrinh", phieuTraKetQua.TTQTTienTrinh));
                Command.Parameters.Add(new MDB.MDBParameter("KetQuas", JsonConvert.SerializeObject(phieuTraKetQua.KetQuas)));
                Command.Parameters.Add(new MDB.MDBParameter("CacThuThuatKhac", phieuTraKetQua.CacThuThuatKhac));
                Command.Parameters.Add(new MDB.MDBParameter("BienChungVaXuLy", phieuTraKetQua.BienChungVaXuLy));
                Command.Parameters.Add(new MDB.MDBParameter("NhanXetKhac", phieuTraKetQua.NhanXetKhac));
                Command.Parameters.Add(new MDB.MDBParameter("KetLuan", phieuTraKetQua.KetLuan));

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", phieuTraKetQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", phieuTraKetQua.NgaySua));
                if (phieuTraKetQua.IDPhieu == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", phieuTraKetQua.IDPhieu));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", phieuTraKetQua.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", phieuTraKetQua.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (phieuTraKetQua.IDPhieu == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    phieuTraKetQua.IDPhieu = nextval;
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
                string sql = "DELETE FROM PhieuTraKetQuaDTCTDMV WHERE ID = :ID";
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
                string FileHinhAnh = @"\PTKQDTDMV\" + maQuanLy;
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
                T.KHOA,
                H.SOYTE,
                H.BENHVIEN,
                H.GIOITINH,
                H.TENBENHNHAN,
                H.TUOI
            FROM
                PhieuTraKetQuaDTCTDMV B
                LEFT JOIN THONGTINDIEUTRI T ON B.MAQUANLY = T.MAQUANLY
                LEFT JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "PKQ");

            DataRow rowTable = ds.Tables[0].Rows[0];
            ObservableCollection<NhanVien> BacSyLamThuThuats = JsonConvert.DeserializeObject<ObservableCollection<NhanVien>>(rowTable["BacSyLamThuThuats"].ToString());
            string BacSyThuThuat = "";
            string MaBacSyThuThuat = "";
            string BacSyThuThuat_Ky = "";
            if (BacSyLamThuThuats != null && BacSyLamThuThuats.Count > 0)
            {
                foreach (NhanVien nv in BacSyLamThuThuats)
                {
                    if (BacSyThuThuat.IsNullOrEmpty())
                    {
                        BacSyThuThuat += nv.HoVaTen;
                        MaBacSyThuThuat = nv.MaNhanVien;
                        BacSyThuThuat_Ky = nv.HoVaTen;
                    }
                    else
                        BacSyThuThuat += " - " + nv.HoVaTen;
                }
            }
            ds.Tables[0].AddColumn("MaBacSyThuThuat", typeof(string));
            ds.Tables[0].AddColumn("BacSyThuThuat", typeof(string));
            ds.Tables[0].AddColumn("BacSyThuThuat_Ky", typeof(string));

            ds.Tables[0].Rows[0]["MaBacSyThuThuat"] = MaBacSyThuThuat;
            ds.Tables[0].Rows[0]["BacSyThuThuat"] = BacSyThuThuat;
            ds.Tables[0].Rows[0]["BacSyThuThuat_Ky"] = BacSyThuThuat_Ky;

            DataTable ThongSoChinh = new DataTable("BKQ");
            ThongSoChinh.Columns.Add("ViTriCanThiep");
            ThongSoChinh.Columns.Add("TenThuThuat");
            ThongSoChinh.Columns.Add("TenThietBi");
            ThongSoChinh.Columns.Add("SoLanBomBong");
            ThongSoChinh.Columns.Add("KetQuaTruoc");
            ThongSoChinh.Columns.Add("KetQuaSau");
            ThongSoChinh.Columns.Add("GhiChu");

            ObservableCollection<KetQuarDongMachVanh> KetQuas = JsonConvert.DeserializeObject<ObservableCollection<KetQuarDongMachVanh>>(rowTable["KetQuas"].ToString());
            foreach (KetQuarDongMachVanh ketQua in KetQuas)
            {
                ThongSoChinh.Rows.Add(ketQua.ViTriCanThiep, ketQua.TenThuThuat, ketQua.TenThietBi, ketQua.SoLanBomBong, ketQua.KetQuaTruoc, ketQua.KetQuaSau, ketQua.GhiChu);
            }

            
            ds.Tables.Add(ThongSoChinh);

            return ds;
        }
    }
}
