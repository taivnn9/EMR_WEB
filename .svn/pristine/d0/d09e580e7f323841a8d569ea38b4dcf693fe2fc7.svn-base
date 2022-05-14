using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMR.KyDienTu;
using Newtonsoft.Json;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class BienBanBGBNCongBoKhoiCovid : ThongTinKy
    {
        public BienBanBGBNCongBoKhoiCovid()
        {
            TableName = "BienBanBGBNCongBoKhoiCovid";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BBBGBNDTKCOVID;
            TenMauPhieu = DanhMucPhieu.BBBGBNDTKCOVID.Description();
        }
        [MoTaDuLieu("Mã định danh")]
        public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau", "", 1)]
        public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
        public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Địa điểm tạo phiếu")]
        public string DiaDiemTai { get; set; }
        [MoTaDuLieu("Đại diện bên giao")]
        public string DaiDienBenGiao { get; set; }
        [MoTaDuLieu("Mã đại diện bên giao")]
        public string MaDaiDienBenGiao { get; set; }
        [MoTaDuLieu("Chức danh đại diện bên giao")]
        public string ChucDanhBenhGiao { get; set; }
        public string DonViCongTacBenhGiao { get; set; }
        [MoTaDuLieu("Đại diện bên nhận")]
        public string DaiDienBenNhan { get; set; }
        [MoTaDuLieu("Địa chỉ bên nhận")]
        public string DiaChiBenNhan { get; set; }
        public string DiaDiemDieuTri { get; set; }
        public DateTime? ThoiGianDieuTri_Tu { get; set; }
        public DateTime? ThoiGianDieuTri_Den { get; set; }
        public string ThongTinBenhNhanSo { get; set; }
        public ObservableCollection<ThongTinBenhNhanCovid> ThongTinBenhNhans { get; set; }
        public string TenBenhNhan { get; set; }
        public string RaVienTai { get; set; }
        public DateTime? NgayKhoiBenh { get; set; }
        public string NguoiTao { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
        public string NguoiSua { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
        public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
        public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
        public bool Chon { get; set; }
        //public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
        public bool DaKy { get; set; }
    }
    public class ThongTinBenhNhanCovid
    {
        public int TT { get; set; }
        public string HoTen { get; set; }
        public string NamSinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
    }
    public class BienBanBGBNCongBoKhoiCovidFunc
    {
        public const string TableName = "BienBanBGBNCongBoKhoiCovid";
        public const string TablePrimaryKeyName = "ID";
        public static List<BienBanBGBNCongBoKhoiCovid> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BienBanBGBNCongBoKhoiCovid> list = new List<BienBanBGBNCongBoKhoiCovid>();
            try
            {
                string sql = @"SELECT * FROM BienBanBGBNCongBoKhoiCovid where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    BienBanBGBNCongBoKhoiCovid data = new BienBanBGBNCongBoKhoiCovid();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.DiaDiemTai = DataReader["DiaDiemTai"].ToString();
                    data.DaiDienBenGiao = DataReader["DaiDienBenGiao"].ToString();
                    data.MaDaiDienBenGiao = DataReader["MaDaiDienBenGiao"].ToString();
                    data.ChucDanhBenhGiao = DataReader["ChucDanhBenhGiao"].ToString();
                    data.DonViCongTacBenhGiao = DataReader["DonViCongTacBenhGiao"].ToString();
                    data.DaiDienBenNhan = DataReader["DaiDienBenNhan"].ToString();
                    data.DiaChiBenNhan = DataReader["DiaChiBenNhan"].ToString();
                    data.DiaDiemDieuTri = DataReader["DiaDiemDieuTri"].ToString();
                    data.ThoiGianDieuTri_Tu = DataReader["ThoiGianDieuTri_Tu"] != DBNull.Value ? (DateTime?) Convert.ToDateTime(DataReader["ThoiGianDieuTri_Tu"].ToString()) : null;
                    data.ThoiGianDieuTri_Den = DataReader["ThoiGianDieuTri_Den"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["ThoiGianDieuTri_Den"].ToString()) : null;
                    data.ThongTinBenhNhanSo = DataReader["ThongTinBenhNhanSo"].ToString();
                    data.ThongTinBenhNhans = JsonConvert.DeserializeObject<ObservableCollection<ThongTinBenhNhanCovid>>(DataReader["ThongTinBenhNhans"].ToString());
                    data.TenBenhNhan = DataReader["TenBenhNhan"].ToString();
                    data.NgayKhoiBenh = DataReader["NgayKhoiBenh"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayKhoiBenh"].ToString()) : null;
                    data.RaVienTai = DataReader["RaVienTai"].ToString();
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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BienBanBGBNCongBoKhoiCovid ketQua)
        {
            try
            {
                string sql = @"INSERT INTO BienBanBGBNCongBoKhoiCovid
                (
                    MAQUANLY,
                    MaBenhNhan,
                    DiaDiemTai,
                    DaiDienBenGiao,
                    MaDaiDienBenGiao,
                    ChucDanhBenhGiao,
                    DonViCongTacBenhGiao,
                    DaiDienBenNhan,
                    DiaChiBenNhan,
                    DiaDiemDieuTri,
                    ThoiGianDieuTri_Tu,
                    ThoiGianDieuTri_Den,
                    ThongTinBenhNhanSo,
                    ThongTinBenhNhans,
                    TenBenhNhan,
                    NgayKhoiBenh,
                    RaVienTai,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :DiaDiemTai,
                    :DaiDienBenGiao,
                    :MaDaiDienBenGiao,
                    :ChucDanhBenhGiao,
                    :DonViCongTacBenhGiao,
                    :DaiDienBenNhan,
                    :DiaChiBenNhan,
                    :DiaDiemDieuTri,
                    :ThoiGianDieuTri_Tu,
                    :ThoiGianDieuTri_Den,
                    :ThongTinBenhNhanSo,
                    :ThongTinBenhNhans,
                    :TenBenhNhan,
                    :NgayKhoiBenh,
                    :RaVienTai,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE BienBanBGBNCongBoKhoiCovid SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    DiaDiemTai=:DiaDiemTai,
                    DaiDienBenGiao=:DaiDienBenGiao,
                    MaDaiDienBenGiao=:MaDaiDienBenGiao,
                    ChucDanhBenhGiao=:ChucDanhBenhGiao,
                    DonViCongTacBenhGiao=:DonViCongTacBenhGiao,
                    DaiDienBenNhan=:DaiDienBenNhan,
                    DiaChiBenNhan=:DiaChiBenNhan,
                    DiaDiemDieuTri=:DiaDiemDieuTri,
                    ThoiGianDieuTri_Tu=:ThoiGianDieuTri_Tu,
                    ThoiGianDieuTri_Den=:ThoiGianDieuTri_Den,
                    ThongTinBenhNhanSo=:ThongTinBenhNhanSo,
                    ThongTinBenhNhans=:ThongTinBenhNhans,
                    TenBenhNhan=:TenBenhNhan,
                    NgayKhoiBenh=:NgayKhoiBenh,
                    RaVienTai = :RaVienTai,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ketQua.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("DiaDiemTai", ketQua.DiaDiemTai));
                Command.Parameters.Add(new MDB.MDBParameter("DaiDienBenGiao", ketQua.DaiDienBenGiao));
                Command.Parameters.Add(new MDB.MDBParameter("MaDaiDienBenGiao", ketQua.MaDaiDienBenGiao));
                Command.Parameters.Add(new MDB.MDBParameter("ChucDanhBenhGiao", ketQua.ChucDanhBenhGiao));
                Command.Parameters.Add(new MDB.MDBParameter("DonViCongTacBenhGiao", ketQua.DonViCongTacBenhGiao));
                Command.Parameters.Add(new MDB.MDBParameter("DaiDienBenNhan", ketQua.DaiDienBenNhan));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChiBenNhan", ketQua.DiaChiBenNhan));
                Command.Parameters.Add(new MDB.MDBParameter("DiaDiemDieuTri", ketQua.DiaDiemDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianDieuTri_Tu", ketQua.ThoiGianDieuTri_Tu));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianDieuTri_Den", ketQua.ThoiGianDieuTri_Den));
                Command.Parameters.Add(new MDB.MDBParameter("ThongTinBenhNhanSo", ketQua.ThongTinBenhNhanSo));
                Command.Parameters.Add(new MDB.MDBParameter("ThongTinBenhNhans", JsonConvert.SerializeObject(ketQua.ThongTinBenhNhans)));
                Command.Parameters.Add(new MDB.MDBParameter("TenBenhNhan", ketQua.TenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("NgayKhoiBenh", ketQua.NgayKhoiBenh));
                Command.Parameters.Add(new MDB.MDBParameter("RaVienTai", ketQua.RaVienTai));
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
                string sql = "DELETE FROM BienBanBGBNCongBoKhoiCovid WHERE ID = :ID";
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
                BienBanBGBNCongBoKhoiCovid P
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "KQ");

            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(string));
            ds.Tables[0].AddColumn("SOYTE", typeof(string));
            ds.Tables[0].AddColumn("BENHVIEN", typeof(string));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            ds.Tables[0].Rows[0]["SOYTE"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;


            ObservableCollection<ThongTinBenhNhanCovid> ThongTinBenhNhans = JsonConvert.DeserializeObject<ObservableCollection<ThongTinBenhNhanCovid>>(ds.Tables[0].Rows[0]["ThongTinBenhNhans"].ToString());
            DataTable chiTiet = Common.ListToDataTable(ThongTinBenhNhans.ToList(), "CT");
            ds.Tables.Add(chiTiet);

            return ds;
        }
    }
}
