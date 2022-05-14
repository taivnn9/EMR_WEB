
using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;
namespace EMR_MAIN.DATABASE.Other
{
    public class ThangDGTTCTCLSCTTCR : ThongTinKy
    {
        public ThangDGTTCTCLSCTTCR()
        {
            TableName = "ThangDGTTCTCLSCTTCR";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.TDGTTCR;
            TenMauPhieu = DanhMucPhieu.TDGTTCR.Description();
        }
        [MoTaDuLieu("Mã định danh")]
        public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau", "", 1)]
        public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
        public string MaBenhNhan { get; set; }
        public string HoTenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
        public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string NgheNghiep { get; set; }
        public string Khoa { get; set; }
        public DateTime? NgayChiDinh { get; set; }
        public string ChanDoan { get; set; }
        public string BacSyChiDinh { get; set; }
        public string MaBacSyChiDinh { get; set; }
        public int DiemPhan_A { get; set; }
        public int DiemPhan_B { get; set; }
        public int DiemPhan_C { get; set; }
        public int DiemPhan_D { get; set; }
        public int DiemPhan_E { get; set; }
        public int DiemPhan_F { get; set; }
        public int DiemPhan_G { get; set; }
        public int DiemPhan_H { get; set; }
        public int DiemPhan_I { get; set; }
        public int DiemPhan_J { get; set; }
        public string DiemTong { get; set; }
        public string KetLuan { get; set; }
        public string NguoiLamTracNghiem { get; set; }
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
    public class ThangDGTTCTCLSCTTCRFunc
    {
        public const string TableName = "ThangDGTTCTCLSCTTCR";
        public const string TablePrimaryKeyName = "ID";
        public static List<ThangDGTTCTCLSCTTCR> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<ThangDGTTCTCLSCTTCR> list = new List<ThangDGTTCTCLSCTTCR>();
            try
            {
                string sql = @"SELECT * FROM ThangDGTTCTCLSCTTCR where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    ThangDGTTCTCLSCTTCR data = new ThangDGTTCTCLSCTTCR();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.HoTenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();

                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.DiaChi = DataReader["DiaChi"].ToString();
                    data.NgheNghiep = DataReader["NgheNghiep"].ToString();
                    data.DiaChi = DataReader["DiaChi"].ToString();
                    data.NgheNghiep = DataReader["NgheNghiep"].ToString();
                    data.Khoa = DataReader["Khoa"].ToString();
                    data.NgayChiDinh = DataReader["NgayChiDinh"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayChiDinh"]) : null;
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.BacSyChiDinh = DataReader["BacSyChiDinh"].ToString();
                    data.MaBacSyChiDinh = DataReader["MaBacSyChiDinh"].ToString();

                    data.DiemPhan_A = DataReader.GetInt("DiemPhan_A");
                    data.DiemPhan_B = DataReader.GetInt("DiemPhan_B");
                    data.DiemPhan_C = DataReader.GetInt("DiemPhan_C");
                    data.DiemPhan_D = DataReader.GetInt("DiemPhan_D");
                    data.DiemPhan_E = DataReader.GetInt("DiemPhan_E");
                    data.DiemPhan_F = DataReader.GetInt("DiemPhan_F");
                    data.DiemPhan_G = DataReader.GetInt("DiemPhan_G");
                    data.DiemPhan_H = DataReader.GetInt("DiemPhan_H");
                    data.DiemPhan_I = DataReader.GetInt("DiemPhan_I");
                    data.DiemPhan_J = DataReader.GetInt("DiemPhan_J");

                    data.DiemTong = DataReader["DiemTong"].ToString();
                    data.KetLuan = DataReader["KetLuan"].ToString();
                    data.NguoiLamTracNghiem = DataReader["NguoiLamTracNghiem"].ToString();
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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref ThangDGTTCTCLSCTTCR ketQua)
        {
            try
            {
                string sql = @"INSERT INTO ThangDGTTCTCLSCTTCR
                (
                    MAQUANLY,
                    MaBenhNhan,
                    DiaChi,
                    NgheNghiep,
                    Khoa,
                    NgayChiDinh,
                    ChanDoan,
                    BacSyChiDinh,
                    MaBacSyChiDinh,
                   DiemPhan_A,
                    DiemPhan_B,
                    DiemPhan_C,
                    DiemPhan_D,
                    DiemPhan_E,
                    DiemPhan_F,
                    DiemPhan_G,
                    DiemPhan_H,
                    DiemPhan_I,
                    DiemPhan_J,
                    DiemTong,
                    KetLuan,
                    NguoiLamTracNghiem,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :DiaChi,
                    :NgheNghiep,
                    :Khoa,
                    :NgayChiDinh,
                    :ChanDoan,
                    :BacSyChiDinh,
                    :MaBacSyChiDinh,
                    :DiemPhan_A,
                    :DiemPhan_B,
                    :DiemPhan_C,
                    :DiemPhan_D,
                    :DiemPhan_E,
                    :DiemPhan_F,
                    :DiemPhan_G,
                    :DiemPhan_H,
                    :DiemPhan_I,
                    :DiemPhan_J,
                    :DiemTong,
                    :KetLuan,
                    :NguoiLamTracNghiem,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE ThangDGTTCTCLSCTTCR SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    DiaChi=:DiaChi,
                    NgheNghiep=:NgheNghiep,
                    Khoa=:Khoa,
                    NgayChiDinh=:NgayChiDinh,
                    ChanDoan=:ChanDoan,
                    BacSyChiDinh=:BacSyChiDinh,
                    MaBacSyChiDinh=:MaBacSyChiDinh,
                    DiemPhan_A=:DiemPhan_A,
                    DiemPhan_B=:DiemPhan_B,
                    DiemPhan_C=:DiemPhan_C,
                    DiemPhan_D=:DiemPhan_D,
                    DiemPhan_E=:DiemPhan_E,
                    DiemPhan_F=:DiemPhan_F,
                    DiemPhan_G=:DiemPhan_G,
                    DiemPhan_H=:DiemPhan_H,
                    DiemPhan_I=:DiemPhan_I,
                    DiemPhan_J=:DiemPhan_J,
                    DiemTong=:DiemTong,
                    KetLuan=:KetLuan,
                    NguoiLamTracNghiem=:NguoiLamTracNghiem,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ketQua.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", ketQua.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("NgheNghiep", ketQua.NgheNghiep));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa", ketQua.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("NgayChiDinh", ketQua.NgayChiDinh));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", ketQua.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyChiDinh", ketQua.BacSyChiDinh));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSyChiDinh", ketQua.MaBacSyChiDinh));

                Command.Parameters.Add(new MDB.MDBParameter("DiemPhan_A", ketQua.DiemPhan_A));
                Command.Parameters.Add(new MDB.MDBParameter("DiemPhan_B", ketQua.DiemPhan_B));
                Command.Parameters.Add(new MDB.MDBParameter("DiemPhan_C", ketQua.DiemPhan_C));
                Command.Parameters.Add(new MDB.MDBParameter("DiemPhan_D", ketQua.DiemPhan_D));
                Command.Parameters.Add(new MDB.MDBParameter("DiemPhan_E", ketQua.DiemPhan_E));
                Command.Parameters.Add(new MDB.MDBParameter("DiemPhan_F", ketQua.DiemPhan_F));
                Command.Parameters.Add(new MDB.MDBParameter("DiemPhan_G", ketQua.DiemPhan_G));
                Command.Parameters.Add(new MDB.MDBParameter("DiemPhan_H", ketQua.DiemPhan_H));
                Command.Parameters.Add(new MDB.MDBParameter("DiemPhan_I", ketQua.DiemPhan_I));
                Command.Parameters.Add(new MDB.MDBParameter("DiemPhan_J", ketQua.DiemPhan_J));

                Command.Parameters.Add(new MDB.MDBParameter("DiemTong", ketQua.DiemTong));
                Command.Parameters.Add(new MDB.MDBParameter("KetLuan", ketQua.KetLuan));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiLamTracNghiem", ketQua.NguoiLamTracNghiem));
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
                string sql = "DELETE FROM ThangDGTTCTCLSCTTCR WHERE ID = :ID";
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
                ThangDGTTCTCLSCTTCR P
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
