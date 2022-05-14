using EMR.KyDienTu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.Access;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class BangCauHoiSangLocVeRuou : ThongTinKy
    {
        public BangCauHoiSangLocVeRuou()
        {
            TableName = "BangCauHoiSangLocVeRuou";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BCHSLVR;
            TenMauPhieu = DanhMucPhieu.BCHSLVR.Description();
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
        public int DiemCau_1 { get; set; }
        public int DiemCau_2 { get; set; }
        public int DiemCau_3 { get; set; }
        public int DiemCau_4 { get; set; }
        public int DiemCau_5 { get; set; }
        public int DiemCau_6 { get; set; }
        public int DiemCau_7 { get; set; }
        public int DiemCau_8 { get; set; }
        public int DiemCau_9 { get; set; }
        public int DiemCau_10 { get; set; }
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
    public class BangCauHoiSangLocVeRuouFunc
    {
        public const string TableName = "BangCauHoiSangLocVeRuou";
        public const string TablePrimaryKeyName = "ID";
        public static List<BangCauHoiSangLocVeRuou> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BangCauHoiSangLocVeRuou> list = new List<BangCauHoiSangLocVeRuou>();
            try
            {
                string sql = @"SELECT * FROM BangCauHoiSangLocVeRuou where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    BangCauHoiSangLocVeRuou data = new BangCauHoiSangLocVeRuou();
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
                    data.NgayChiDinh = DataReader["NgayChiDinh"] != DBNull.Value ? (DateTime?) Convert.ToDateTime(DataReader["NgayChiDinh"]) : null;
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.BacSyChiDinh = DataReader["BacSyChiDinh"].ToString();
                    data.MaBacSyChiDinh = DataReader["MaBacSyChiDinh"].ToString();
                    data.DiemCau_1 = DataReader.GetInt("DiemCau_1");
                    data.DiemCau_2 = DataReader.GetInt("DiemCau_2");
                    data.DiemCau_3 = DataReader.GetInt("DiemCau_3");
                    data.DiemCau_4 = DataReader.GetInt("DiemCau_4");
                    data.DiemCau_5 = DataReader.GetInt("DiemCau_5");
                    data.DiemCau_6 = DataReader.GetInt("DiemCau_6");
                    data.DiemCau_7 = DataReader.GetInt("DiemCau_7");
                    data.DiemCau_8 = DataReader.GetInt("DiemCau_8");
                    data.DiemCau_9 = DataReader.GetInt("DiemCau_9");
                    data.DiemCau_10 = DataReader.GetInt("DiemCau_10");
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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BangCauHoiSangLocVeRuou ketQua)
        {
            try
            {
                string sql = @"INSERT INTO BangCauHoiSangLocVeRuou
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
                    DiemCau_1,
                    DiemCau_2,
                    DiemCau_3,
                    DiemCau_4,
                    DiemCau_5,
                    DiemCau_6,
                    DiemCau_7,
                    DiemCau_8,
                    DiemCau_9,
                    DiemCau_10,
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
                    :DiemCau_1,
                    :DiemCau_2,
                    :DiemCau_3,
                    :DiemCau_4,
                    :DiemCau_5,
                    :DiemCau_6,
                    :DiemCau_7,
                    :DiemCau_8,
                    :DiemCau_9,
                    :DiemCau_10,
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
                    sql = @"UPDATE BangCauHoiSangLocVeRuou SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    DiaChi=:DiaChi,
                    NgheNghiep=:NgheNghiep,
                    Khoa=:Khoa,
                    NgayChiDinh=:NgayChiDinh,
                    ChanDoan=:ChanDoan,
                    BacSyChiDinh=:BacSyChiDinh,
                    MaBacSyChiDinh=:MaBacSyChiDinh,
                    DiemCau_1=:DiemCau_1,
                    DiemCau_2=:DiemCau_2,
                    DiemCau_3=:DiemCau_3,
                    DiemCau_4=:DiemCau_4,
                    DiemCau_5=:DiemCau_5,
                    DiemCau_6=:DiemCau_6,
                    DiemCau_7=:DiemCau_7,
                    DiemCau_8=:DiemCau_8,
                    DiemCau_9=:DiemCau_9,
                    DiemCau_10=:DiemCau_10,
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
                Command.Parameters.Add(new MDB.MDBParameter("DiemCau_1", ketQua.DiemCau_1));
                Command.Parameters.Add(new MDB.MDBParameter("DiemCau_2", ketQua.DiemCau_2));
                Command.Parameters.Add(new MDB.MDBParameter("DiemCau_3", ketQua.DiemCau_3));
                Command.Parameters.Add(new MDB.MDBParameter("DiemCau_4", ketQua.DiemCau_4));
                Command.Parameters.Add(new MDB.MDBParameter("DiemCau_5", ketQua.DiemCau_5));
                Command.Parameters.Add(new MDB.MDBParameter("DiemCau_6", ketQua.DiemCau_6));
                Command.Parameters.Add(new MDB.MDBParameter("DiemCau_7", ketQua.DiemCau_7));
                Command.Parameters.Add(new MDB.MDBParameter("DiemCau_8", ketQua.DiemCau_8));
                Command.Parameters.Add(new MDB.MDBParameter("DiemCau_9", ketQua.DiemCau_9));
                Command.Parameters.Add(new MDB.MDBParameter("DiemCau_10", ketQua.DiemCau_10));
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
                string sql = "DELETE FROM BangCauHoiSangLocVeRuou WHERE ID = :ID";
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
                BangCauHoiSangLocVeRuou P
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
