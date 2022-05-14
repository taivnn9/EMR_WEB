using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuChuanBiTruocKhiMo : ThongTinKy
    {
        public PhieuChuanBiTruocKhiMo()
        {
            TableName = "PhieuChuanBiTruocKhiMo";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PCBTKMCYT;
            TenMauPhieu = DanhMucPhieu.PCBTKMCYT.Description();
        }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
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
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            }
        }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan
        {
            get
            {
                return XemBenhAn._ThongTinDieuTri.ChanDoan_KhiVaoKhoaDieuTri;
            }
        }
        public string Khoa
        {
            get
            {
                return XemBenhAn._ThongTinDieuTri.Khoa;
            }
        }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        public DateTime ThoiGian { get; set; }
        public string DiUngVoiThuoc { get; set; }
        public int VeSinh { get; set; }
        public int SonMongTay { get; set; }
        public int CatMongTay { get; set; }
        public int DoTrangSuc { get; set; }
        public int ThaoRangGia { get; set; }
        public int CuonDrap { get; set; }
        public int VeSinhRon { get; set; }
        public int VeSinhCo { get; set; }
        public int PhieuCamDoanMo { get; set; }
        public int PhieuXNNhomMau { get; set; }
        public int PhimChupPhoi { get; set; }
        public int CacLoaiPhimKhac { get; set; }
        public int SieuAm { get; set; }
        public int DienTim { get; set; }
        [MoTaDuLieu("Mạch")]
		public string Mach { get; set; }
        [MoTaDuLieu("Nhiệt độ")]
		public string NhietDo { get; set; }
        [MoTaDuLieu("Huyết áp")]
		public string HuyetAp { get; set; }
        [MoTaDuLieu("Nhịp thở")]
		public string NhipTho { get; set; }
        [MoTaDuLieu("Chiều cao")]
		public string ChieuCao { get; set; }
        [MoTaDuLieu("Cân nặng")]
		public string CanNang { get; set; }
        [MoTaDuLieu("Nhóm máu")]
		public string NhomMau { get; set; }
        [MoTaDuLieu("HIV")]
		public string HIV { get; set; }
        public string HBS { get; set; }
        public string TestKS { get; set; }
        public string SoLuongPhimChupPhoi { get; set; }
        public string SoLuongCacLoaiPhimKhac { get; set; }
        public string ThuocTienMe { get; set; }
        public DateTime ThoiGianDiMo { get; set; }
        public DateTime ThoiGianGayMe { get; set; }
        public string YKien { get; set; }
        public string YTaChuanBi { get; set; }
        public string MaYTaChuanBi { get; set; }
        public string YTaDua { get; set; }
        public string MaYTaDua { get; set; }
        public string YTaNhan { get; set; }
        public string MaYTaNhan { get; set; }
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

    }
    public class PhieuChuanBiTruocKhiMoFunc
    {
        public const string TableName = "PhieuChuanBiTruocKhiMo";
        public const string TablePrimaryKeyName = "ID";
        public static PhieuChuanBiTruocKhiMo GetListData_Phieu(MDB.MDBConnection _OracleConnection, long ID)
        {
            PhieuChuanBiTruocKhiMo data = new PhieuChuanBiTruocKhiMo();
            try
            {
                string sql = @"SELECT * FROM PhieuChuanBiTruocKhiMo where ID = :ID";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID", ID));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = DataReader.GetDecimal("MaQuanLy");
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.ThoiGian = Convert.ToDateTime(DataReader["ThoiGian"] == DBNull.Value ? DateTime.Now : DataReader["ThoiGian"]);
                    data.DiUngVoiThuoc = DataReader["DiUngVoiThuoc"].ToString();
                    data.VeSinh = ConDB_Int(DataReader["VeSinh"]);
                    data.SonMongTay = ConDB_Int(DataReader["SonMongTay"]);
                    data.CatMongTay = ConDB_Int(DataReader["CatMongTay"]);
                    data.DoTrangSuc = ConDB_Int(DataReader["DoTrangSuc"]);
                    data.ThaoRangGia = ConDB_Int(DataReader["ThaoRangGia"]);
                    data.CuonDrap = ConDB_Int(DataReader["CuonDrap"]);
                    data.VeSinhRon = ConDB_Int(DataReader["VeSinhRon"]);
                    data.VeSinhCo = ConDB_Int(DataReader["VeSinhCo"]);
                    data.PhieuCamDoanMo = ConDB_Int(DataReader["PhieuCamDoanMo"]);
                    data.PhieuXNNhomMau = ConDB_Int(DataReader["PhieuXNNhomMau"]);
                    data.PhimChupPhoi = ConDB_Int(DataReader["PhimChupPhoi"]);
                    data.CacLoaiPhimKhac = ConDB_Int(DataReader["CacLoaiPhimKhac"]);
                    data.SieuAm = ConDB_Int(DataReader["SieuAm"]);
                    data.DienTim = ConDB_Int(DataReader["DienTim"]);
                    data.Mach = DataReader["Mach"].ToString();
                    data.NhietDo = DataReader["NhietDo"].ToString();
                    data.HuyetAp = DataReader["HuyetAp"].ToString();
                    data.NhipTho = DataReader["NhipTho"].ToString();
                    data.ChieuCao = DataReader["ChieuCao"].ToString();
                    data.CanNang = DataReader["CanNang"].ToString();
                    data.NhomMau = DataReader["NhomMau"].ToString();
                    data.HIV = DataReader["HIV"].ToString();
                    data.HBS = DataReader["HBS"].ToString();
                    data.TestKS = DataReader["TestKS"].ToString();
                    data.SoLuongPhimChupPhoi = DataReader["SoLuongPhimChupPhoi"].ToString();
                    data.SoLuongCacLoaiPhimKhac = DataReader["SoLuongCacLoaiPhimKhac"].ToString();
                    data.ThuocTienMe = DataReader["ThuocTienMe"].ToString();
                    data.ThoiGianDiMo = Convert.ToDateTime(DataReader["ThoiGianDiMo"] == DBNull.Value ? DateTime.Now : DataReader["ThoiGianDiMo"]);
                    data.ThoiGianGayMe = Convert.ToDateTime(DataReader["ThoiGianGayMe"] == DBNull.Value ? DateTime.Now : DataReader["ThoiGianGayMe"]);
                    data.YKien = DataReader["YKien"].ToString();
                    data.YTaChuanBi = DataReader["YTaChuanBi"].ToString();
                    data.MaYTaChuanBi = DataReader["MaYTaChuanBi"].ToString();
                    data.YTaDua = DataReader["YTaDua"].ToString();
                    data.MaYTaDua = DataReader["MaYTaDua"].ToString();
                    data.YTaNhan = DataReader["YTaNhan"].ToString();
                    data.MaYTaNhan = DataReader["MaYTaNhan"].ToString();

                    data.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                    data.NguoiTao = DataReader["NguoiTao"].ToString();
                    data.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);
                    data.NguoiSua = DataReader["NguoiSua"].ToString();
                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return data;
        }
        public static List<PhieuChuanBiTruocKhiMo> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuChuanBiTruocKhiMo> list = new List<PhieuChuanBiTruocKhiMo>();
            try
            {
                string sql = @"SELECT * FROM PhieuChuanBiTruocKhiMo where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuChuanBiTruocKhiMo data = new PhieuChuanBiTruocKhiMo();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.ThoiGian = Convert.ToDateTime(DataReader["ThoiGian"] == DBNull.Value ? DateTime.Now : DataReader["ThoiGian"]);
                    data.DiUngVoiThuoc = DataReader["DiUngVoiThuoc"].ToString();
                    data.VeSinh = ConDB_Int(DataReader["VeSinh"]);
                    data.SonMongTay = ConDB_Int(DataReader["SonMongTay"]);
                    data.CatMongTay = ConDB_Int(DataReader["CatMongTay"]);
                    data.DoTrangSuc = ConDB_Int(DataReader["DoTrangSuc"]);
                    data.ThaoRangGia = ConDB_Int(DataReader["ThaoRangGia"]);
                    data.CuonDrap = ConDB_Int(DataReader["CuonDrap"]);
                    data.VeSinhRon = ConDB_Int(DataReader["VeSinhRon"]);
                    data.VeSinhCo = ConDB_Int(DataReader["VeSinhCo"]);
                    data.PhieuCamDoanMo = ConDB_Int(DataReader["PhieuCamDoanMo"]);
                    data.PhieuXNNhomMau = ConDB_Int(DataReader["PhieuXNNhomMau"]);
                    data.PhimChupPhoi = ConDB_Int(DataReader["PhimChupPhoi"]);
                    data.CacLoaiPhimKhac = ConDB_Int(DataReader["CacLoaiPhimKhac"]);
                    data.SieuAm = ConDB_Int(DataReader["SieuAm"]);
                    data.DienTim = ConDB_Int(DataReader["DienTim"]);
                    data.Mach = DataReader["Mach"].ToString();
                    data.NhietDo = DataReader["NhietDo"].ToString();
                    data.HuyetAp = DataReader["HuyetAp"].ToString();
                    data.NhipTho = DataReader["NhipTho"].ToString();
                    data.ChieuCao = DataReader["ChieuCao"].ToString();
                    data.CanNang = DataReader["CanNang"].ToString();
                    data.NhomMau = DataReader["NhomMau"].ToString();
                    data.HIV = DataReader["HIV"].ToString();
                    data.HBS = DataReader["HBS"].ToString();
                    data.TestKS = DataReader["TestKS"].ToString();
                    data.SoLuongPhimChupPhoi = DataReader["SoLuongPhimChupPhoi"].ToString();
                    data.SoLuongCacLoaiPhimKhac = DataReader["SoLuongCacLoaiPhimKhac"].ToString();
                    data.ThuocTienMe = DataReader["ThuocTienMe"].ToString();
                    data.ThoiGianDiMo = Convert.ToDateTime(DataReader["ThoiGianDiMo"] == DBNull.Value ? DateTime.Now : DataReader["ThoiGianDiMo"]);
                    data.ThoiGianGayMe = Convert.ToDateTime(DataReader["ThoiGianGayMe"] == DBNull.Value ? DateTime.Now : DataReader["ThoiGianGayMe"]);
                    data.YKien = DataReader["YKien"].ToString();
                    data.YTaChuanBi = DataReader["YTaChuanBi"].ToString();
                    data.MaYTaChuanBi = DataReader["MaYTaChuanBi"].ToString();
                    data.YTaDua = DataReader["YTaDua"].ToString();
                    data.MaYTaDua = DataReader["MaYTaDua"].ToString();
                    data.YTaNhan = DataReader["YTaNhan"].ToString();
                    data.MaYTaNhan = DataReader["MaYTaNhan"].ToString();

                    data.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                    data.NguoiTao = DataReader["NguoiTao"].ToString();
                    data.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);
                    data.NguoiSua = DataReader["NguoiSua"].ToString();
                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy);
                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuChuanBiTruocKhiMo data)
        {
            try
            {
                string sql = @"INSERT INTO PhieuChuanBiTruocKhiMo
                (
                    MaQuanLy,
                    MaBenhNhan,
                    ThoiGian,
                    DiUngVoiThuoc,
                    VeSinh,
                    SonMongTay,
                    CatMongTay,
                    DoTrangSuc,
                    ThaoRangGia,
                    CuonDrap,
                    VeSinhRon,
                    VeSinhCo,
                    PhieuCamDoanMo,
                    PhieuXNNhomMau,
                    PhimChupPhoi,
                    CacLoaiPhimKhac,
                    SieuAm,
                    DienTim,
                    Mach,
                    NhietDo,
                    HuyetAp,
                    NhipTho,
                    ChieuCao,
                    CanNang,
                    NhomMau,
                    HIV,
                    HBS,
                    TestKS,
                    SoLuongPhimChupPhoi,
                    SoLuongCacLoaiPhimKhac,
                    ThuocTienMe,
                    ThoiGianDiMo,
                    ThoiGianGayMe,
                    YKien,
                    YTaChuanBi,
                    MaYTaChuanBi,
                    YTaDua,
                    MaYTaDua,
                    YTaNhan,
                    MaYTaNhan,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
                    :MaBenhNhan,
                    :ThoiGian,
                    :DiUngVoiThuoc,
                    :VeSinh,
                    :SonMongTay,
                    :CatMongTay,
                    :DoTrangSuc,
                    :ThaoRangGia,
                    :CuonDrap,
                    :VeSinhRon,
                    :VeSinhCo,
                    :PhieuCamDoanMo,
                    :PhieuXNNhomMau,
                    :PhimChupPhoi,
                    :CacLoaiPhimKhac,
                    :SieuAm,
                    :DienTim,
                    :Mach,
                    :NhietDo,
                    :HuyetAp,
                    :NhipTho,
                    :ChieuCao,
                    :CanNang,
                    :NhomMau,
                    :HIV,
                    :HBS,
                    :TestKS,
                    :SoLuongPhimChupPhoi,
                    :SoLuongCacLoaiPhimKhac,
                    :ThuocTienMe,
                    :ThoiGianDiMo,
                    :ThoiGianGayMe,
                    :YKien,
                    :YTaChuanBi,
                    :MaYTaChuanBi,
                    :YTaDua,
                    :MaYTaDua,
                    :YTaNhan,
                    :MaYTaNhan,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (data.ID != 0)
                {
                    sql = @"UPDATE PhieuChuanBiTruocKhiMo SET 
                    MaQuanLy=:MaQuanLy,
                    MaBenhNhan=:MaBenhNhan,
                    ThoiGian=:ThoiGian,
                    DiUngVoiThuoc=:DiUngVoiThuoc,
                    VeSinh=:VeSinh,
                    SonMongTay=:SonMongTay,
                    CatMongTay=:CatMongTay,
                    DoTrangSuc=:DoTrangSuc,
                    ThaoRangGia=:ThaoRangGia,
                    CuonDrap=:CuonDrap,
                    VeSinhRon=:VeSinhRon,
                    VeSinhCo=:VeSinhCo,
                    PhieuCamDoanMo=:PhieuCamDoanMo,
                    PhieuXNNhomMau=:PhieuXNNhomMau,
                    PhimChupPhoi=:PhimChupPhoi,
                    CacLoaiPhimKhac=:CacLoaiPhimKhac,
                    SieuAm=:SieuAm,
                    DienTim=:DienTim,
                    Mach=:Mach,
                    NhietDo=:NhietDo,
                    HuyetAp=:HuyetAp,
                    NhipTho=:NhipTho,
                    ChieuCao=:ChieuCao,
                    CanNang=:CanNang,
                    NhomMau=:NhomMau,
                    HIV=:HIV,
                    HBS=:HBS,
                    TestKS=:TestKS,
                    SoLuongPhimChupPhoi=:SoLuongPhimChupPhoi,
                    SoLuongCacLoaiPhimKhac=:SoLuongCacLoaiPhimKhac,
                    ThuocTienMe=:ThuocTienMe,
                    ThoiGianDiMo=:ThoiGianDiMo,
                    ThoiGianGayMe=:ThoiGianGayMe,
                    YKien=:YKien,
                    YTaChuanBi=:YTaChuanBi,
                    MaYTaChuanBi=:MaYTaChuanBi,
                    YTaDua=:YTaDua,
                    MaYTaDua=:MaYTaDua,
                    YTaNhan=:YTaNhan,
                    MaYTaNhan=:MaYTaNhan,
                    NGUOISUA= :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + data.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", data.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", data.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGian", data.ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("DiUngVoiThuoc", data.DiUngVoiThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("VeSinh", data.VeSinh));
                Command.Parameters.Add(new MDB.MDBParameter("SonMongTay", data.SonMongTay));
                Command.Parameters.Add(new MDB.MDBParameter("CatMongTay", data.CatMongTay));
                Command.Parameters.Add(new MDB.MDBParameter("DoTrangSuc", data.DoTrangSuc));
                Command.Parameters.Add(new MDB.MDBParameter("ThaoRangGia", data.ThaoRangGia));
                Command.Parameters.Add(new MDB.MDBParameter("CuonDrap", data.CuonDrap));
                Command.Parameters.Add(new MDB.MDBParameter("VeSinhRon", data.VeSinhRon));
                Command.Parameters.Add(new MDB.MDBParameter("VeSinhCo", data.VeSinhCo));
                Command.Parameters.Add(new MDB.MDBParameter("PhieuCamDoanMo", data.PhieuCamDoanMo));
                Command.Parameters.Add(new MDB.MDBParameter("PhieuXNNhomMau", data.PhieuXNNhomMau));
                Command.Parameters.Add(new MDB.MDBParameter("PhimChupPhoi", data.PhimChupPhoi));
                Command.Parameters.Add(new MDB.MDBParameter("CacLoaiPhimKhac", data.CacLoaiPhimKhac));
                Command.Parameters.Add(new MDB.MDBParameter("SieuAm", data.SieuAm));
                Command.Parameters.Add(new MDB.MDBParameter("DienTim", data.DienTim));
                Command.Parameters.Add(new MDB.MDBParameter("Mach", data.Mach));
                Command.Parameters.Add(new MDB.MDBParameter("NhietDo", data.NhietDo));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetAp", data.HuyetAp));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTho", data.NhipTho));
                Command.Parameters.Add(new MDB.MDBParameter("ChieuCao", data.ChieuCao));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang", data.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("NhomMau", data.NhomMau));
                Command.Parameters.Add(new MDB.MDBParameter("HIV", data.HIV));
                Command.Parameters.Add(new MDB.MDBParameter("HBS", data.HBS));
                Command.Parameters.Add(new MDB.MDBParameter("TestKS", data.TestKS));
                Command.Parameters.Add(new MDB.MDBParameter("SoLuongPhimChupPhoi", data.SoLuongPhimChupPhoi));
                Command.Parameters.Add(new MDB.MDBParameter("SoLuongCacLoaiPhimKhac", data.SoLuongCacLoaiPhimKhac));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocTienMe", data.ThuocTienMe));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianDiMo", data.ThoiGianDiMo));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianGayMe", data.ThoiGianGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("YKien", data.YKien));
                Command.Parameters.Add(new MDB.MDBParameter("YTaChuanBi", data.YTaChuanBi));
                Command.Parameters.Add(new MDB.MDBParameter("MaYTaChuanBi", data.MaYTaChuanBi));
                Command.Parameters.Add(new MDB.MDBParameter("YTaDua", data.YTaDua));
                Command.Parameters.Add(new MDB.MDBParameter("MaYTaDua", data.MaYTaDua));
                Command.Parameters.Add(new MDB.MDBParameter("YTaNhan", data.YTaNhan));
                Command.Parameters.Add(new MDB.MDBParameter("MaYTaNhan", data.MaYTaNhan));
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
                string sql = "DELETE FROM PhieuChuanBiTruocKhiMo WHERE ID = :ID";
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
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, long id)
        {
            string sql = @"SELECT
                B.*,
                '' MABENHAN,
	            '' TENBENHNHAN,
                '' TUOI
            FROM
                PhieuChuanBiTruocKhiMo B
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "BK");
            if (ds != null || ds.Tables[0].Rows.Count > 0)
            {
                ds.Tables[0].Rows[0]["MaBenhAn"] = XemBenhAn._ThongTinDieuTri.MaBenhAn;
                ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                ds.Tables[0].Rows[0]["TUOI"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            }
            /*DataTable thongTinVien = new DataTable("HEADER");

            thongTinVien.Columns.Add("BENHVIEN");
            thongTinVien.Columns.Add("KHOA");
            thongTinVien.Rows.Add(XemBenhAn._HanhChinhBenhNhan.BenhVien, XemBenhAn._ThongTinDieuTri.Khoa);
            ds.Tables.Add(thongTinVien);*/

            return ds;
        }
        public static int ConDB_Int(object dbVal, int valDefault = 0)
        {
            int ret = valDefault;
            if (dbVal == null)
            {
                return ret;
            }
            bool isSuccess = int.TryParse(dbVal.ToString(), out ret);
            if (!isSuccess)
            {
                return valDefault;
            }
            return ret;
        }
    }

}
