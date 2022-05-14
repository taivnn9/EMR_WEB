using EMR.KyDienTu;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.Access; 

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuTomTatBenhAnNoiTru : ThongTinKy
    {
        public PhieuTomTatBenhAnNoiTru()
        {
            TableName = "PhieuTomTatBenhAnNoiTru";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.TLBA;
            TenMauPhieu = DanhMucPhieu.TLBA.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        public string SoYTe
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.SoYTe;
            }
        }
        public string BenhVien
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.BenhVien;
            }
        }
        public string Khoa
        {
            get
            {
                return XemBenhAn._ThongTinDieuTri.Khoa;
            }
        }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan
        {
            get
            {
                return XemBenhAn._ThongTinDieuTri.MaBenhNhan;
            }
        }
        public string SoVaoVien
        {
            get
            {
                return XemBenhAn._ThongTinDieuTri.SoNhapVien;
            }
        }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            }
        }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.Tuoi;
            }
        }
        public string NamSinh
        {
            get
            {
                DateTime? NgaySinh = XemBenhAn._HanhChinhBenhNhan.NgaySinh;
                if (NgaySinh == null)
                {
                    return "";
                }
                return NgaySinh.Value.Year + "";
            }
        }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.GioiTinh.ToString();
            }
        }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi
        {
            get
            {
                return Common.GetDiaChi();
            }
        }
        public string QuocTich
        {
            get
            {
                string NgoaiKieu = XemBenhAn._HanhChinhBenhNhan.NgoaiKieu;
                if (string.IsNullOrEmpty(NgoaiKieu))
                {
                    return "Việt Nam";
                }
                return NgoaiKieu;
            }
        }
        public string Buong
        {
            get
            {
                return XemBenhAn._ThongTinDieuTri.Buong;
            }
        }
        public string Giuong
        {
            get
            {
                return XemBenhAn._ThongTinDieuTri.Giuong;
            }
        }
        public string NgheNghiep
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.NgheNghiep;
            }
        }
        public string DanToc
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.DanToc;
            }
        }
        public string HoTenDiaChiNguoiNha
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.HoTenDiaChiNguoiNha;
            }
        }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        public DateTime ThoiGian { get; set; }
        public DateTime NgayNhapVien { get; set; }
        public DateTime NgayRaVien { get; set; }
        public string LyDoVaoVien { get; set; }
        public string BenhSu { get; set; }
        public string TienSu { get; set; }
        public string KhamLamSang { get; set; }
        public string CanLamSang { get; set; }
        [MoTaDuLieu("Chẩn đoán hình ảnh")]
		public string ChanDoanHinhAnh { get; set; }
        public string XetNghiem { get; set; }
        public string BenhChinh { get; set; }
        public string BenhKemTheo { get; set; }
        public string PhuongPhapDieuTri { get; set; }
        public string HuongDieuTriTiepTheo { get; set; }
        public string MaLanhDao { get; set; }
        public string LanhDao { get; set; }
        public string MaCanBo { get; set; }
        public string CanBo { get; set; }
        [MoTaDuLieu("Mã bác sỹ")]
		public string MaBacSi { get; set; }
        [MoTaDuLieu("Họ tên bác sỹ")]
		public string BacSi { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
    }
    public class PhieuTomTatBenhAnNoiTruFunc
    {
        public const string TableName = "PhieuTomTatBenhAnNoiTru";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuTomTatBenhAnNoiTru> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuTomTatBenhAnNoiTru> list = new List<PhieuTomTatBenhAnNoiTru>();
            try
            {
                string sql = @"SELECT * FROM PhieuTomTatBenhAnNoiTru where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuTomTatBenhAnNoiTru data = new PhieuTomTatBenhAnNoiTru();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.ThoiGian = Convert.ToDateTime(DataReader["ThoiGian"] == DBNull.Value ? DateTime.Now : DataReader["ThoiGian"]);
                    data.NgayNhapVien = Convert.ToDateTime(DataReader["NgayNhapVien"] == DBNull.Value ? DateTime.Now : DataReader["NgayNhapVien"]);
                    data.NgayRaVien = Convert.ToDateTime(DataReader["NgayRaVien"] == DBNull.Value ? DateTime.Now : DataReader["NgayRaVien"]);
                    data.LyDoVaoVien = DataReader["LyDoVaoVien"].ToString();
                    data.BenhSu = DataReader["BenhSu"].ToString();
                    data.TienSu = DataReader["TienSu"].ToString();
                    data.KhamLamSang = DataReader["KhamLamSang"].ToString();
                    data.CanLamSang = DataReader["CanLamSang"].ToString();
                    data.ChanDoanHinhAnh = DataReader["ChanDoanHinhAnh"].ToString();
                    data.XetNghiem = DataReader["XetNghiem"].ToString();
                    data.BenhChinh = DataReader["BenhChinh"].ToString();
                    data.BenhKemTheo = DataReader["BenhKemTheo"].ToString();
                    data.PhuongPhapDieuTri = DataReader["PhuongPhapDieuTri"].ToString();
                    data.HuongDieuTriTiepTheo = DataReader["HuongDieuTriTiepTheo"].ToString();
                    data.MaLanhDao = DataReader["MaLanhDao"].ToString();
                    data.LanhDao = DataReader["LanhDao"].ToString();
                    data.MaCanBo = DataReader["MaCanBo"].ToString();
                    data.CanBo = DataReader["CanBo"].ToString();
                    data.MaBacSi = DataReader["MaBacSi"].ToString();
                    data.BacSi = DataReader["BacSi"].ToString();

                    data.NguoiTao = DataReader["NguoiTao"].ToString();
                    data.NguoiSua = DataReader["NguoiSua"].ToString();
                    data.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                    data.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);
                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy);
                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuTomTatBenhAnNoiTru data)
        {
            try
            {
                string sql = @"INSERT INTO PhieuTomTatBenhAnNoiTru
                (
                    MaQuanLy,
                    ThoiGian,
                    NgayNhapVien,
                    NgayRaVien,
                    LyDoVaoVien,
                    BenhSu,
                    TienSu,
                    KhamLamSang,
                    CanLamSang,
                    ChanDoanHinhAnh,
                    XetNghiem,
                    BenhChinh,
                    BenhKemTheo,
                    PhuongPhapDieuTri,
                    HuongDieuTriTiepTheo,
                    MaLanhDao,
                    LanhDao,
                    MaCanBo,
                    CanBo,
                    MaBacSi,
                    BacSi,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
                    :ThoiGian,
                    :NgayNhapVien,
                    :NgayRaVien,
                    :LyDoVaoVien,
                    :BenhSu,
                    :TienSu,
                    :KhamLamSang,
                    :CanLamSang,
                    :ChanDoanHinhAnh,
                    :XetNghiem,
                    :BenhChinh,
                    :BenhKemTheo,
                    :PhuongPhapDieuTri,
                    :HuongDieuTriTiepTheo,
                    :MaLanhDao,
                    :LanhDao,
                    :MaCanBo,
                    :CanBo,
                    :MaBacSi,
                    :BacSi,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (data.ID != 0)
                {
                    sql = @"UPDATE PhieuTomTatBenhAnNoiTru SET 
                    MaQuanLy=:MaQuanLy,
                    ThoiGian=:ThoiGian,
                    NgayNhapVien=:NgayNhapVien,
                    NgayRaVien=:NgayRaVien,
                    LyDoVaoVien=:LyDoVaoVien,
                    BenhSu=:BenhSu,
                    TienSu=:TienSu,
                    KhamLamSang=:KhamLamSang,
                    CanLamSang=:CanLamSang,
                    ChanDoanHinhAnh=:ChanDoanHinhAnh,
                    XetNghiem=:XetNghiem,
                    BenhChinh=:BenhChinh,
                    BenhKemTheo=:BenhKemTheo,
                    PhuongPhapDieuTri=:PhuongPhapDieuTri,
                    HuongDieuTriTiepTheo=:HuongDieuTriTiepTheo,
                    MaLanhDao=:MaLanhDao,
                    LanhDao=:LanhDao,
                    MaCanBo=:MaCanBo,
                    CanBo=:CanBo,
                    MaBacSi=:MaBacSi,
                    BacSi=:BacSi,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + data.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", data.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGian", data.ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("NgayNhapVien", data.NgayNhapVien));
                Command.Parameters.Add(new MDB.MDBParameter("NgayRaVien", data.NgayRaVien));
                Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", data.LyDoVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("BenhSu", data.BenhSu));
                Command.Parameters.Add(new MDB.MDBParameter("TienSu", data.TienSu));
                Command.Parameters.Add(new MDB.MDBParameter("KhamLamSang", data.KhamLamSang));
                Command.Parameters.Add(new MDB.MDBParameter("CanLamSang", data.CanLamSang));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanHinhAnh", data.ChanDoanHinhAnh));
                Command.Parameters.Add(new MDB.MDBParameter("XetNghiem", data.XetNghiem));
                Command.Parameters.Add(new MDB.MDBParameter("BenhChinh", data.BenhChinh));
                Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", data.BenhKemTheo));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", data.PhuongPhapDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTriTiepTheo", data.HuongDieuTriTiepTheo));
                Command.Parameters.Add(new MDB.MDBParameter("MaLanhDao", data.MaLanhDao));
                Command.Parameters.Add(new MDB.MDBParameter("LanhDao", data.LanhDao));
                Command.Parameters.Add(new MDB.MDBParameter("MaCanBo", data.MaCanBo));
                Command.Parameters.Add(new MDB.MDBParameter("CanBo", data.CanBo));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSi", data.MaBacSi));
                Command.Parameters.Add(new MDB.MDBParameter("BacSi", data.BacSi));
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
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    data.ID = nextval;
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
                string sql = "DELETE FROM PhieuTomTatBenhAnNoiTru WHERE ID = :ID";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                command.Parameters.Add(new MDB.MDBParameter("ID", id));
                command.BindByName = true;
                return command.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, long id)
        {
            string sql = @"SELECT * FROM PhieuTomTatBenhAnNoiTru WHERE ID = " + id;
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            PhieuTomTatBenhAnNoiTru data = new PhieuTomTatBenhAnNoiTru();
            adt.Fill(ds, "DS");
            if (ds != null && ds.Tables[0] != null)
            {
                ds.Tables[0].Columns.Add("SoYTe");
                ds.Tables[0].Columns.Add("BenhVien");
                ds.Tables[0].Columns.Add("Khoa");
                ds.Tables[0].Columns.Add("MaBenhNhan");
                ds.Tables[0].Columns.Add("SoVaoVien");
                ds.Tables[0].Columns.Add("TenBenhNhan");
                ds.Tables[0].Columns.Add("Tuoi");
                ds.Tables[0].Columns.Add("NamSinh");
                ds.Tables[0].Columns.Add("GioiTinh");
                ds.Tables[0].Columns.Add("DiaChi");
                ds.Tables[0].Columns.Add("Buong");
                ds.Tables[0].Columns.Add("Giuong");
                ds.Tables[0].Columns.Add("NgheNghiep");
                ds.Tables[0].Columns.Add("DanToc");
                ds.Tables[0].Columns.Add("HoTenDiaChiNguoiNha");
                ds.Tables[0].Columns.Add("QuocTichT");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    ds.Tables[0].Rows[0]["SoYTe"] = data.SoYTe;
                    ds.Tables[0].Rows[0]["BenhVien"] = data.BenhVien;
                    ds.Tables[0].Rows[0]["Khoa"] = data.Khoa;
                    ds.Tables[0].Rows[0]["MaBenhNhan"] = data.MaBenhNhan;
                    ds.Tables[0].Rows[0]["SoVaoVien"] = data.SoVaoVien;
                    ds.Tables[0].Rows[0]["TenBenhNhan"] = data.TenBenhNhan;
                    ds.Tables[0].Rows[0]["Tuoi"] = data.Tuoi;
                    ds.Tables[0].Rows[0]["NamSinh"] = data.NamSinh;
                    ds.Tables[0].Rows[0]["GioiTinh"] = data.GioiTinh;
                    ds.Tables[0].Rows[0]["DiaChi"] = data.DiaChi;
                    ds.Tables[0].Rows[0]["Buong"] = data.Buong;
                    ds.Tables[0].Rows[0]["Giuong"] = data.Giuong;
                    ds.Tables[0].Rows[0]["NgheNghiep"] = data.NgheNghiep;
                    ds.Tables[0].Rows[0]["DanToc"] = data.DanToc;
                    ds.Tables[0].Rows[0]["HoTenDiaChiNguoiNha"] = data.HoTenDiaChiNguoiNha;
                    ds.Tables[0].Rows[0]["QuocTichT"] = data.QuocTich;
                }
            }
            return ds;
        }
    }
}
