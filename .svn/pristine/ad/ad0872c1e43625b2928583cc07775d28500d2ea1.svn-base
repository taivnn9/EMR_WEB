using EMR.KyDienTu;
using Newtonsoft.Json;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMR_MAIN.DATABASE.Other
{
    public class GiayCamDoanCNSDDVTYC : ThongTinKy
    {
        public GiayCamDoanCNSDDVTYC()
        {
            TableName = "GiayCamDoanCNSDDVTYC";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.GCDCNSDDVTYC;
            TenMauPhieu = DanhMucPhieu.GCDCNSDDVTYC.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Nghề nghiệp")]
		public string NgheNghiep { get; set; }
        [MoTaDuLieu("Dân tộc")]
		public string DanToc { get; set; }
        [MoTaDuLieu("Quốc tịch")]
		public string QuocTich { get; set; }
        [MoTaDuLieu("Số chứng minh nhân dân")]
		public string CMND { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        public string SDT { get; set; }
        [MoTaDuLieu("Họ tên người thân")]
		public string NguoiThan { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Giường")]
		public string Giuong { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public int Thuoc { get; set; }
        public int VatTuYTe { get; set; }
        public int DichVuKiThuat { get; set; }
        public int GiuongTuNguyen { get; set; }
        public int MoSom { get; set; }
        public int ChonBacSi { get; set; }
        public int GayMe { get; set; }
        public int ChamSocDacBiet { get; set; }
        public int Khac { get; set; }
        public string TenThuoc { get; set; }
        public string TenVatTuYTe { get; set; }
        public string TenDichVuKiThuat { get; set; }
        public string TenGiuongTuNguyen { get; set; }
        public string TenMoSom { get; set; }
        public string TenChonBacSi { get; set; }
        public string TenGayMe { get; set; }
        public string TenChamSocDacBiet { get; set; }
        public string TenKhac { get; set; }
        public string ChuKi1 { get; set; }
        public string ChuKi2 { get; set; }
        public string ChuKi3 { get; set; }
        public string ChuKi4 { get; set; }
        public string ChuKi5 { get; set; }
        public string ChuKi6 { get; set; }
        public string ChuKi7 { get; set; }
        public string ChuKi8 { get; set; }
        public string ChuKi9 { get; set; }
        public DateTime NgayLamGiay { get; set; }

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
    public class GiayCamDoanCNSDDVTYCFunc
    {
        public const string TableName = "GiayCamDoanCNSDDVTYC";
        public const string TablePrimaryKeyName = "ID";
        public static List<GiayCamDoanCNSDDVTYC> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<GiayCamDoanCNSDDVTYC> list = new List<GiayCamDoanCNSDDVTYC>();
            try
            {
                string sql = @"SELECT * FROM GiayCamDoanCNSDDVTYC where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    GiayCamDoanCNSDDVTYC data = new GiayCamDoanCNSDDVTYC();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.TenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.NgheNghiep = DataReader["NgheNghiep"].ToString();
                    data.DanToc = DataReader["DanToc"].ToString();
                    data.NgayLamGiay = Convert.ToDateTime(DataReader["NgayLamGiay"] == DBNull.Value ? DateTime.Now : DataReader["NgayLamGiay"]);

                    data.QuocTich = DataReader["QuocTich"].ToString();
                    data.CMND = DataReader["CMND"].ToString();
                    data.DiaChi = DataReader["DiaChi"].ToString();
                    data.SDT = DataReader["SDT"].ToString();
                    data.NguoiThan = DataReader["NguoiThan"].ToString();
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.Khoa = DataReader["Khoa"].ToString();
                    data.Giuong = DataReader["Giuong"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.Thuoc = DataReader.GetInt("Thuoc");
                    data.VatTuYTe = DataReader.GetInt("VatTuYTe");
                    data.DichVuKiThuat = DataReader.GetInt("DichVuKiThuat");
                    data.GiuongTuNguyen = DataReader.GetInt("GiuongTuNguyen");
                    data.MoSom = DataReader.GetInt("MoSom");
                    data.ChonBacSi = DataReader.GetInt("ChonBacSi");
                    data.GayMe = DataReader.GetInt("GayMe");
                    data.ChamSocDacBiet = DataReader.GetInt("ChamSocDacBiet");
                    data.Khac = DataReader.GetInt("Khac");

                    data.TenThuoc = DataReader["TenThuoc"].ToString();
                    data.TenVatTuYTe = DataReader["TenVatTuYTe"].ToString();
                    data.TenDichVuKiThuat = DataReader["TenDichVuKiThuat"].ToString();
                    data.TenGiuongTuNguyen = DataReader["TenGiuongTuNguyen"].ToString();
                    data.TenMoSom = DataReader["TenMoSom"].ToString();
                    data.TenChonBacSi = DataReader["TenChonBacSi"].ToString();
                    data.TenGayMe = DataReader["TenGayMe"].ToString();
                    data.TenChamSocDacBiet = DataReader["TenChamSocDacBiet"].ToString();
                    data.TenKhac = DataReader["TenKhac"].ToString();

                    data.ChuKi1 = DataReader["ChuKi1"].ToString();
                    data.ChuKi2 = DataReader["ChuKi2"].ToString();
                    data.ChuKi3 = DataReader["ChuKi3"].ToString();
                    data.ChuKi4 = DataReader["ChuKi4"].ToString();
                    data.ChuKi5 = DataReader["ChuKi5"].ToString();
                    data.ChuKi6 = DataReader["ChuKi6"].ToString();
                    data.ChuKi7 = DataReader["ChuKi7"].ToString();
                    data.ChuKi8 = DataReader["ChuKi8"].ToString();
                    data.ChuKi9 = DataReader["ChuKi9"].ToString();

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref GiayCamDoanCNSDDVTYC bangKe)
        {
            try
            {
                string sql = @"INSERT INTO GiayCamDoanCNSDDVTYC
                (
                    MAQUANLY,
                    NgheNghiep,
                    DanToc,
                    NgayLamGiay,
                    QuocTich,
                    CMND,
                    DiaChi,
                    SDT,
                    NguoiThan,
                    MaBenhNhan,
                    Khoa,
                    Giuong,
                    ChanDoan,
                    Thuoc,
                    VatTuYTe,
                    DichVuKiThuat,
                    GiuongTuNguyen,
                    MoSom,
                    ChonBacSi,
                    GayMe,
                    ChamSocDacBiet,
                    Khac,
                    TenThuoc,
                    TenVatTuYTe,
                    TenDichVuKiThuat,
                    TenGiuongTuNguyen,
                    TenMoSom,
                    TenChonBacSi,
                    TenGayMe,
                    TenChamSocDacBiet,
                    TenKhac,
                    ChuKi1,
                    ChuKi2,
                    ChuKi3,
                    ChuKi4,
                    ChuKi5,
                    ChuKi6,
                    ChuKi7,
                    ChuKi8,
                    ChuKi9,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :NgheNghiep,
                    :DanToc,
                    :NgayLamGiay,
                    :QuocTich,
                    :CMND,
                    :DiaChi,
                    :SDT,
                    :NguoiThan,
                    :MaBenhNhan,
                    :Khoa,
                    :Giuong,
                    :ChanDoan,
                    :Thuoc,
                    :VatTuYTe,
                    :DichVuKiThuat,
                    :GiuongTuNguyen,
                    :MoSom,
                    :ChonBacSi,
                    :GayMe,
                    :ChamSocDacBiet,
                    :Khac,
                    :TenThuoc,
                    :TenVatTuYTe,
                    :TenDichVuKiThuat,
                    :TenGiuongTuNguyen,
                    :TenMoSom,
                    :TenChonBacSi,
                    :TenGayMe,
                    :TenChamSocDacBiet,
                    :TenKhac,
                    :ChuKi1,
                    :ChuKi2,
                    :ChuKi3,
                    :ChuKi4,
                    :ChuKi5,
                    :ChuKi6,
                    :ChuKi7,
                    :ChuKi8,
                    :ChuKi9,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (bangKe.ID != 0)
                {
                    sql = @"UPDATE GiayCamDoanCNSDDVTYC SET 
                    MAQUANLY = :MAQUANLY,
                    NgheNghiep = :NgheNghiep,
                    DanToc = :DanToc,
                    NgayLamGiay = :NgayLamGiay,
                    QuocTich = :QuocTich,
                    CMND = :CMND,
                    DiaChi = :DiaChi,
                    SDT = :SDT,
                    NguoiThan = :NguoiThan,
                    MaBenhNhan = :MaBenhNhan,
                    Khoa = :Khoa,
                    Giuong = :Giuong,
                    ChanDoan = :ChanDoan,
                    Thuoc = :Thuoc,
                    VatTuYTe = :VatTuYTe,
                    DichVuKiThuat= :DichVuKiThuat,
                    GiuongTuNguyen = :GiuongTuNguyen,
                    MoSom = :MoSom,
                    ChonBacSi = :ChonBacSi,
                    GayMe = :GayMe,
                    ChamSocDacBiet = :ChamSocDacBiet,
                    Khac = :Khac,
                    TenThuoc = :TenThuoc,
                    TenVatTuYTe = :TenVatTuYTe,
                    TenDichVuKiThuat = :TenDichVuKiThuat,
                    TenGiuongTuNguyen = :TenGiuongTuNguyen,
                    TenMoSom = :TenMoSom,
                    TenChonBacSi = :TenChonBacSi,
                    TenGayMe = :TenGayMe,
                    TenChamSocDacBiet = :TenChamSocDacBiet,
                    TenKhac = :TenKhac,
                    ChuKi1 = :ChuKi1,
                    ChuKi2 = :ChuKi2,
                    ChuKi3 = :ChuKi3,
                    ChuKi4 = :ChuKi4,
                    ChuKi5 = :ChuKi5,
                    ChuKi6 = :ChuKi6,
                    ChuKi7 = :ChuKi7,
                    ChuKi8 = :ChuKi8,
                    ChuKi9 = :ChuKi9,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + bangKe.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangKe.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("NgheNghiep", bangKe.NgheNghiep));
                Command.Parameters.Add(new MDB.MDBParameter("DanToc", bangKe.DanToc));
                Command.Parameters.Add(new MDB.MDBParameter("NgayLamGiay", bangKe.NgayLamGiay));
                Command.Parameters.Add(new MDB.MDBParameter("QuocTich", bangKe.QuocTich));
                Command.Parameters.Add(new MDB.MDBParameter("CMND", bangKe.CMND));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", bangKe.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("SDT", bangKe.SDT));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiThan", bangKe.NguoiThan));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", bangKe.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa", bangKe.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("Giuong", bangKe.Giuong));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", bangKe.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("Thuoc", bangKe.Thuoc));
                Command.Parameters.Add(new MDB.MDBParameter("VatTuYTe", bangKe.VatTuYTe));
                Command.Parameters.Add(new MDB.MDBParameter("DichVuKiThuat", bangKe.DichVuKiThuat));
                Command.Parameters.Add(new MDB.MDBParameter("GiuongTuNguyen", bangKe.GiuongTuNguyen));
                Command.Parameters.Add(new MDB.MDBParameter("MoSom", bangKe.MoSom));
                Command.Parameters.Add(new MDB.MDBParameter("ChonBacSi", bangKe.ChonBacSi));
                Command.Parameters.Add(new MDB.MDBParameter("GayMe", bangKe.GayMe));
                Command.Parameters.Add(new MDB.MDBParameter("ChamSocDacBiet", bangKe.ChamSocDacBiet));
                Command.Parameters.Add(new MDB.MDBParameter("Khac", bangKe.Khac));
                Command.Parameters.Add(new MDB.MDBParameter("TenThuoc", bangKe.TenThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("TenVatTuYTe", bangKe.TenVatTuYTe));
                Command.Parameters.Add(new MDB.MDBParameter("TenDichVuKiThuat", bangKe.TenDichVuKiThuat));
                Command.Parameters.Add(new MDB.MDBParameter("TenGiuongTuNguyen", bangKe.TenGiuongTuNguyen));
                Command.Parameters.Add(new MDB.MDBParameter("TenMoSom", bangKe.TenMoSom));
                Command.Parameters.Add(new MDB.MDBParameter("TenChonBacSi", bangKe.TenChonBacSi));
                Command.Parameters.Add(new MDB.MDBParameter("TenGayMe", bangKe.TenGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("TenChamSocDacBiet", bangKe.TenChamSocDacBiet));
                Command.Parameters.Add(new MDB.MDBParameter("TenKhac", bangKe.TenKhac));
                Command.Parameters.Add(new MDB.MDBParameter("ChuKi1", bangKe.ChuKi1));
                Command.Parameters.Add(new MDB.MDBParameter("ChuKi2", bangKe.ChuKi2));
                Command.Parameters.Add(new MDB.MDBParameter("ChuKi3", bangKe.ChuKi3));
                Command.Parameters.Add(new MDB.MDBParameter("ChuKi4", bangKe.ChuKi4));
                Command.Parameters.Add(new MDB.MDBParameter("ChuKi5", bangKe.ChuKi5));
                Command.Parameters.Add(new MDB.MDBParameter("ChuKi6", bangKe.ChuKi6));
                Command.Parameters.Add(new MDB.MDBParameter("ChuKi7", bangKe.ChuKi7));
                Command.Parameters.Add(new MDB.MDBParameter("ChuKi8", bangKe.ChuKi8));
                Command.Parameters.Add(new MDB.MDBParameter("ChuKi9", bangKe.ChuKi9));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", bangKe.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", bangKe.NgaySua));
                if (bangKe.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", bangKe.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", bangKe.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", bangKe.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (bangKe.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    bangKe.ID = nextval;
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
                string sql = "DELETE FROM GiayCamDoanCNSDDVTYC WHERE ID = :ID";
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
                GiayCamDoanCNSDDVTYC B
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);

            var ds = new DataSet();

            adt.Fill(ds, "TB");
            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(string));
            ds.Tables[0].AddColumn("BenhVien", typeof(string));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            ds.Tables[0].Rows[0]["BenhVien"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;

            return ds;

        }
    }
}
