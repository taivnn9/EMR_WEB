using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMR.KyDienTu;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class GiayDeNghiTHCLPCDCovid : ThongTinKy
    {
        public GiayDeNghiTHCLPCDCovid()
        {
            TableName = "GiayDeNghiTHCLPCDCovid";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.GDNTHCLPCDCOVID;
            TenMauPhieu = DanhMucPhieu.GDNTHCLPCDCOVID.Description();
        }
        [MoTaDuLieu("Mã định danh")]
        public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau", "", 1)]
        public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
        public string MaBenhNhan { get; set; }
        public string TenBenhNhan { get; set; }
        public string BenhNhanSo { get; set; }
        public string GioiTinh { get; set; }
        public string QuocTich { get; set; }
        public string SinhNam { get; set; }
        public string SDT { get; set; }
        public string DiaChiTamTru { get; set; }
        public string ThuongTru { get; set; }
        public string NoiCuTruSauRaVien { get; set; }
        public string XacDinhVirusTai { get; set; }
        public string ChuyenBenhVien { get; set; }
        public DateTime? DieuTri_Tu { get; set; }
        public DateTime? DieuTri_Den { get; set; }
        public string HienTai { get; set; }
        public string NoiNhan { get; set; }
        public string GiamDoc { get; set; }
        public string MaGiamDoc { get; set; }
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
    public class GiayDeNghiTHCLPCDCovidFunc
    {
        public const string TableName = "GiayDeNghiTHCLPCDCovid";
        public const string TablePrimaryKeyName = "ID";
        public static List<GiayDeNghiTHCLPCDCovid> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<GiayDeNghiTHCLPCDCovid> list = new List<GiayDeNghiTHCLPCDCovid>();
            try
            {
                string sql = @"SELECT * FROM GiayDeNghiTHCLPCDCovid where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    GiayDeNghiTHCLPCDCovid data = new GiayDeNghiTHCLPCDCovid();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.TenBenhNhan = DataReader["TenBenhNhan"].ToString();
                    data.BenhNhanSo = DataReader["BenhNhanSo"].ToString();
                    data.GioiTinh = DataReader["GioiTinh"].ToString();
                    data.QuocTich = DataReader["QuocTich"].ToString();
                    data.SinhNam = DataReader["SinhNam"].ToString();
                    data.SDT = DataReader["SDT"].ToString();
                    data.DiaChiTamTru = DataReader["DiaChiTamTru"].ToString();
                    data.ThuongTru = DataReader["ThuongTru"].ToString();
                    data.NoiCuTruSauRaVien = DataReader["NoiCuTruSauRaVien"].ToString();
                    data.XacDinhVirusTai = DataReader["XacDinhVirusTai"].ToString();
                    data.ChuyenBenhVien = DataReader["ChuyenBenhVien"].ToString();
                    data.DieuTri_Tu = DataReader["DieuTri_Tu"] != DBNull.Value ? (DateTime?) Convert.ToDateTime(DataReader["DieuTri_Tu"].ToString()): null;
                    data.DieuTri_Den = DataReader["DieuTri_Den"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["DieuTri_Den"].ToString()) : null;
                    data.HienTai = DataReader["HienTai"].ToString();
                    data.NoiNhan = DataReader["NoiNhan"].ToString();
                    data.GiamDoc = DataReader["GiamDoc"].ToString();
                    data.MaGiamDoc = DataReader["MaGiamDoc"].ToString();

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref GiayDeNghiTHCLPCDCovid ketQua)
        {
            try
            {
                string sql = @"INSERT INTO GiayDeNghiTHCLPCDCovid
                (
                    MAQUANLY,
                    MaBenhNhan,
                    TenBenhNhan,
                    BenhNhanSo,
                    GioiTinh,
                    QuocTich,
                    SinhNam,
                    SDT,
                    DiaChiTamTru,
                    ThuongTru,
                    NoiCuTruSauRaVien,
                    XacDinhVirusTai,
                    ChuyenBenhVien,
                    DieuTri_Tu,
                    DieuTri_Den,
                    HienTai,
                    NoiNhan,
                    GiamDoc,
                    MaGiamDoc,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :TenBenhNhan,
                    :BenhNhanSo,
                    :GioiTinh,
                    :QuocTich,
                    :SinhNam,
                    :SDT,
                    :DiaChiTamTru,
                    :ThuongTru,
                    :NoiCuTruSauRaVien,
                    :XacDinhVirusTai,
                    :ChuyenBenhVien,
                    :DieuTri_Tu,
                    :DieuTri_Den,
                    :HienTai,
                    :NoiNhan,
                    :GiamDoc,
                    :MaGiamDoc,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE GiayDeNghiTHCLPCDCovid SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    TenBenhNhan=:TenBenhNhan,
                    BenhNhanSo=:BenhNhanSo,
                    GioiTinh=:GioiTinh,
                    QuocTich=:QuocTich,
                    SinhNam=:SinhNam,
                    SDT=:SDT,
                    DiaChiTamTru=:DiaChiTamTru,
                    ThuongTru=:ThuongTru,
                    NoiCuTruSauRaVien=:NoiCuTruSauRaVien,
                    XacDinhVirusTai=:XacDinhVirusTai,
                    ChuyenBenhVien = :ChuyenBenhVien,
                    DieuTri_Tu=:DieuTri_Tu,
                    DieuTri_Den=:DieuTri_Den,
                    HienTai=:HienTai,
                    NoiNhan=:NoiNhan,
                    GiamDoc=:GiamDoc,
                    MaGiamDoc=:MaGiamDoc,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ketQua.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("TenBenhNhan", ketQua.TenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("BenhNhanSo", ketQua.BenhNhanSo));
                Command.Parameters.Add(new MDB.MDBParameter("GioiTinh", ketQua.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("QuocTich", ketQua.QuocTich));
                Command.Parameters.Add(new MDB.MDBParameter("SinhNam", ketQua.SinhNam));
                Command.Parameters.Add(new MDB.MDBParameter("SDT", ketQua.SDT));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChiTamTru", ketQua.DiaChiTamTru));
                Command.Parameters.Add(new MDB.MDBParameter("ThuongTru", ketQua.ThuongTru));
                Command.Parameters.Add(new MDB.MDBParameter("NoiCuTruSauRaVien", ketQua.NoiCuTruSauRaVien));
                Command.Parameters.Add(new MDB.MDBParameter("XacDinhVirusTai", ketQua.XacDinhVirusTai));
                Command.Parameters.Add(new MDB.MDBParameter("ChuyenBenhVien", ketQua.ChuyenBenhVien));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_Tu", ketQua.DieuTri_Tu));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri_Den", ketQua.DieuTri_Den));
                Command.Parameters.Add(new MDB.MDBParameter("HienTai", ketQua.HienTai));
                Command.Parameters.Add(new MDB.MDBParameter("NoiNhan", ketQua.NoiNhan));
                Command.Parameters.Add(new MDB.MDBParameter("GiamDoc", ketQua.GiamDoc));
                Command.Parameters.Add(new MDB.MDBParameter("MaGiamDoc", ketQua.MaGiamDoc)); 
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
                string sql = "DELETE FROM GiayDeNghiTHCLPCDCovid WHERE ID = :ID";
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
                GiayDeNghiTHCLPCDCovid P
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "KQ");

            ds.Tables[0].AddColumn("SOYTE", typeof(string));
            ds.Tables[0].AddColumn("BENHVIEN", typeof(string));

            ds.Tables[0].Rows[0]["SOYTE"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;

            return ds;
        }
    }
}
