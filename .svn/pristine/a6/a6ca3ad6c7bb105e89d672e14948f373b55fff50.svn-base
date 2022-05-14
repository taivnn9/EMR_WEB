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
    public class PhieuLuongGiaHDCNVaSTG : ThongTinKy
    {
        public PhieuLuongGiaHDCNVaSTG()
        {
            TableName = "PhieuLuongGiaHDCNVaSTG";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PLGHDCN;
            TenMauPhieu = DanhMucPhieu.PLGHDCN.Description();
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
        [MoTaDuLieu("Buồng")]
		public string Buong { get; set; }
        [MoTaDuLieu("Giường")]
		public string Giuong { get; set; }
        public string VanDongDiChuyen { get; set; }
        public string ChucNangSinhHoa { get; set; }
        public string NhanThucGiaoTiep { get; set; }
        public string ChucNangKhac { get; set; }
        public string SuThamGia { get; set; }
        public string YeuToMoiTruong { get; set; }
        public string YeuToCaNhan { get; set; }
        [MoTaDuLieu("Người thực hiện")]
		public string NguoiThucHien { get; set; }
        [MoTaDuLieu("Mã người thực hiện")]
		public string MaNguoiThucHien { get; set; }
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
    public class PhieuLuongGiaHDCNVaSTGFunc
    {
        public const string TableName = "PhieuLuongGiaHDCNVaSTG";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuLuongGiaHDCNVaSTG> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuLuongGiaHDCNVaSTG> list = new List<PhieuLuongGiaHDCNVaSTG>();
            try
            {
                string sql = @"SELECT * FROM PhieuLuongGiaHDCNVaSTG where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuLuongGiaHDCNVaSTG data = new PhieuLuongGiaHDCNVaSTG();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.HoTenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.Khoa = DataReader["Khoa"].ToString();
                    data.MaKhoa = DataReader["MaKhoa"].ToString();
                    data.Buong = DataReader["Buong"].ToString();
                    data.Giuong = DataReader["Giuong"].ToString();
                    data.VanDongDiChuyen = DataReader["VanDongDiChuyen"].ToString();
                    data.ChucNangSinhHoa = DataReader["ChucNangSinhHoa"].ToString();
                    data.NhanThucGiaoTiep = DataReader["NhanThucGiaoTiep"].ToString();
                    data.SuThamGia = DataReader["SuThamGia"].ToString();
                    data.ChucNangKhac = DataReader["ChucNangKhac"].ToString();
                    data.YeuToMoiTruong = DataReader["YeuToMoiTruong"].ToString();
                    data.YeuToCaNhan = DataReader["YeuToCaNhan"].ToString();

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuLuongGiaHDCNVaSTG ketQua)
        {
            try
            {
                string sql = @"INSERT INTO PhieuLuongGiaHDCNVaSTG
                (
                    MAQUANLY,
                    MaBenhNhan,
                    Khoa,
                    MaKhoa,
                    Buong,
                    Giuong,
                    VanDongDiChuyen,
                    ChucNangSinhHoa,
                    NhanThucGiaoTiep,
                    ChucNangKhac,
                    SuThamGia,
                    YeuToMoiTruong,
                    YeuToCaNhan,
                    NguoiThucHien,
                    MaNguoiThucHien,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :Khoa,
                    :MaKhoa,
                    :Buong,
                    :Giuong,
                    :VanDongDiChuyen,
                    :ChucNangSinhHoa,
                    :NhanThucGiaoTiep,
                    :ChucNangKhac,
                    :SuThamGia,
                    :YeuToMoiTruong,
                    :YeuToCaNhan,
                    :NguoiThucHien,
                    :MaNguoiThucHien,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE PhieuLuongGiaHDCNVaSTG SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    Khoa = :Khoa,
                    MaKhoa = :MaKhoa,
                    Buong = :Buong,
                    Giuong = :Giuong,
                    VanDongDiChuyen = :VanDongDiChuyen,
                    ChucNangSinhHoa = :ChucNangSinhHoa,
                    NhanThucGiaoTiep = :NhanThucGiaoTiep,
                    ChucNangKhac = :ChucNangKhac,
                    SuThamGia = :SuThamGia,
                    YeuToMoiTruong = :YeuToMoiTruong,
                    YeuToCaNhan = :YeuToCaNhan,
                    NguoiThucHien = :NguoiThucHien,
                    MaNguoiThucHien = :MaNguoiThucHien,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ketQua.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa", ketQua.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaKhoa", ketQua.MaKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("Buong", ketQua.Buong));
                Command.Parameters.Add(new MDB.MDBParameter("Giuong", ketQua.Giuong));
                Command.Parameters.Add(new MDB.MDBParameter("VanDongDiChuyen", ketQua.VanDongDiChuyen));
                Command.Parameters.Add(new MDB.MDBParameter("ChucNangSinhHoa", ketQua.ChucNangSinhHoa));
                Command.Parameters.Add(new MDB.MDBParameter("NhanThucGiaoTiep", ketQua.NhanThucGiaoTiep));
                Command.Parameters.Add(new MDB.MDBParameter("ChucNangKhac", ketQua.ChucNangKhac));
                Command.Parameters.Add(new MDB.MDBParameter("SuThamGia", ketQua.SuThamGia));
                Command.Parameters.Add(new MDB.MDBParameter("YeuToMoiTruong", ketQua.YeuToMoiTruong));
                Command.Parameters.Add(new MDB.MDBParameter("YeuToCaNhan", ketQua.YeuToCaNhan));
                Command.Parameters.Add(new MDB.MDBParameter("YeuToCaNhan", ketQua.YeuToCaNhan));
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
                string sql = "DELETE FROM PhieuLuongGiaHDCNVaSTG WHERE ID = :ID";
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
                PhieuLuongGiaHDCNVaSTG P
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "KQ");

            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(string));
            ds.Tables[0].AddColumn("SOYTE", typeof(string));
            ds.Tables[0].AddColumn("BENHVIEN", typeof(string));
            ds.Tables[0].AddColumn("MS", typeof(string));
            ds.Tables[0].AddColumn("SoVaoVien", typeof(string));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            ds.Tables[0].Rows[0]["SOYTE"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["MS"] = XemBenhAn._ThongTinDieuTri.MaBenhAn;
            ds.Tables[0].Rows[0]["SoVaoVien"] = XemBenhAn._ThongTinDieuTri.SoNhapVien;

            return ds;
        }
    }

}
