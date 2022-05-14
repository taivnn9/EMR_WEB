using System;
using System.Collections.Generic;
using System.Data;
using PMS.Access;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using EMR.KyDienTu;
using MDB;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuChamSoc : ThongTinKy
    {
        public PhieuChamSoc()
        {
            TableName = "PhieuChamSoc";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PCS;
            TenMauPhieu = DanhMucPhieu.PCS.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh án")]
		public string MaBenhAn { get; set; }
        public string HoTenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        public string SoGiuong { get; set; }
        [MoTaDuLieu("Buồng")]
		public string Buong { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public string ChuanDoanPhu { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        public ObservableCollection<ChuanDoan> ListChanDoan { get; set; }

        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
    }

    public class ChuanDoan
    {
        [MoTaDuLieu("Mã định danh")]
		public long IDChuanDoan { get; set; }
        [MoTaDuLieu("Mã định danh")]
		public long IDPhieuChamSoc { get; set; }
        public DateTime? Ngay { get; set; }
        public DateTime? Gio { get; set; }
        public string TheoDoiDienBien { get; set; }
        [MoTaDuLieu("Thực hiện y lệnh")]
		public string ThucHienYLenh { get; set; }

        public string KiTen { get; set; }


        public static bool InsertOrUpdate(MDB.MDBConnection oracleConnection, ChuanDoan chuanDoan)
        {
            try
            {
                string sql = @"SELECT IDChuanDoan FROM ChuanDoan WHERE IDChuanDoan = :IDChuanDoan";
                MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
                oracleCommand.Parameters.Add("IDPhieuChamSoc", chuanDoan.IDChuanDoan);
                MDB.MDBDataReader oracleDataReader = oracleCommand.ExecuteReader();
                int rowCount = 0;
                while (oracleDataReader.Read()) rowCount++;
                if (rowCount > 0)
                {
                    sql = "update ChuanDoan set IDPhieuChamSoc =:IDPhieuChamSoc, Ngay = :Ngay, Gio = :Gio, TheoDoiDienBien =:TheoDoiDienBien,ThucHienYLenh = :ThucHienYLenh, KiTen = :KiTen "
                           + " where IDChuanDoan = " + chuanDoan.IDChuanDoan + "";
                }
                else
                {
                    sql = @"insert into ChuanDoan(IDPhieuChamSoc,Ngay,Gio, TheoDoiDienBien, ThucHienYLenh, KiTen) values (:IDPhieuChamSoc,:Ngay,:Gio, :TheoDoiDienBien, :ThucHienYLenh, :KiTen)";
                }
                oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
                oracleCommand.Parameters.Add(new MDB.MDBParameter("IDPhieuChamSoc", chuanDoan.IDPhieuChamSoc));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Ngay", chuanDoan.Ngay));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Gio", chuanDoan.Gio));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TheoDoiDienBien", chuanDoan.TheoDoiDienBien));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ThucHienYLenh", chuanDoan.ThucHienYLenh));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KiTen", chuanDoan.KiTen));

                int n = oracleCommand.ExecuteNonQuery();
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.LogError(ex);
            }
            return false;
        }
        public static bool DeleteByID(MDB.MDBConnection oracleConnection, decimal ID)
        {
            try
            {
                string sql = @"delete from ChuanDoan where IDChuanDoan = :IDChuanDoan";
                MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
                oracleCommand.Parameters.Add("IDChuanDoan", ID);
                int n = oracleCommand.ExecuteNonQuery();
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.LogError(ex);
            }
            return false;
        }
        public static bool DeleteByIDPhieuChamSoc(MDB.MDBConnection oracleConnection, decimal IDPhieuChamSoc)
        {
            try
            {
                string sql = @"SELECT IDChuanDoan FROM ChuanDoan WHERE IDPhieuChamSoc = :IDPhieuChamSoc";
                MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
                oracleCommand.Parameters.Add("IDPhieuChamSoc", IDPhieuChamSoc);
                MDB.MDBDataReader oracleDataReader = oracleCommand.ExecuteReader();
                int rowCount = 0;
                while (oracleDataReader.Read()) rowCount++;
                if (rowCount > 0)
                {
                    sql = @"DELETE FROM ChuanDoan WHERE IDPhieuChamSoc = :IDPhieuChamSoc";
                    oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
                    oracleCommand.Parameters.Add("IDPhieuChamSoc", IDPhieuChamSoc);
                    int n = oracleCommand.ExecuteNonQuery();
                    return n > 0;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.LogError(ex);
            }
            return false;
        }

        public static ObservableCollection<ChuanDoan> GetChuanDoanByIDPhieuChamSoc(MDB.MDBConnection _OracleConnection, long IdPhieu)
        {
            ObservableCollection<ChuanDoan> list = new ObservableCollection<ChuanDoan>();
            try
            {
                string sql = @"SELECT * FROM ChuanDoan where IDPhieuChamSoc = :IDPhieuChamSoc";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("IDPhieuChamSoc", IdPhieu));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    ChuanDoan data = new ChuanDoan();
                    data.IDChuanDoan = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.IDPhieuChamSoc = IdPhieu;
                    data.Ngay = Convert.ToDateTime(DataReader["Ngay"] == DBNull.Value ? DateTime.Now : DataReader["Ngay"]).Date;
                    data.Gio = data.Ngay + Convert.ToDateTime(DataReader["Gio"] == DBNull.Value ? DateTime.Now : DataReader["Gio"]).TimeOfDay;
                    data.TheoDoiDienBien = DataReader["TheoDoiDienBien"].ToString();
                    data.ThucHienYLenh = DataReader["ThucHienYLenh"].ToString();
                    data.KiTen = DataReader["KiTen"].ToString();
                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
    }

    public class PhieuChamSocFunc
    {
        public const string TableName = "PhieuChamSoc";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuChamSoc> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuChamSoc> list = new List<PhieuChamSoc>();
            try
            {
                string sql = @"SELECT * FROM PhieuChamSoc where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {

                    ObservableCollection<ChuanDoan> ListChuanDoan = new ObservableCollection<ChuanDoan>();
                    sql = @"SELECT * FROM ChuanDoan where IDPhieuChamSoc = :IDPhieuChamSoc";
                    MDB.MDBCommand OracleCommand1 = new MDB.MDBCommand(sql, _OracleConnection);
                    OracleCommand1.Parameters.Add(new MDB.MDBParameter("IDPhieuChamSoc", DataReader.GetLong("ID")));
                    MDB.MDBDataReader OracleDataReader1 = OracleCommand1.ExecuteReader();
                    while (OracleDataReader1.Read())
                    {
                        long IDChuanDoan = long.Parse(OracleDataReader1["IDChuanDoan"].ToString());
                        long IDPhieuChamSoc = long.Parse(OracleDataReader1["IDPhieuChamSoc"].ToString());
                        DateTime Ngay = Convert.ToDateTime(OracleDataReader1["Ngay"] == DBNull.Value ? DateTime.Now : OracleDataReader1["Ngay"]).Date;
                        DateTime Gio = Ngay + Convert.ToDateTime(OracleDataReader1["Gio"] == DBNull.Value ? DateTime.Now : OracleDataReader1["Gio"]).TimeOfDay;
                        string TheoDoiDienBien = OracleDataReader1["TheoDoiDienBien"].ToString();
                        string ThucHienYLenh = OracleDataReader1["ThucHienYLenh"].ToString();
                        string KiTen = OracleDataReader1["KiTen"].ToString();
                        ListChuanDoan.Add(new ChuanDoan
                        {
                            IDChuanDoan = IDChuanDoan,
                            IDPhieuChamSoc = IDPhieuChamSoc,
                            Ngay = Ngay,
                            Gio = Gio,
                            TheoDoiDienBien = TheoDoiDienBien,
                            ThucHienYLenh = ThucHienYLenh,
                            KiTen = KiTen
                        });
                    }
                    ListChuanDoan = new ObservableCollection<ChuanDoan>(ListChuanDoan.ToList().OrderBy(x => x.Ngay).ThenBy(x => x.Gio));
                    PhieuChamSoc data = new PhieuChamSoc();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhAn = XemBenhAn._ThongTinDieuTri.MaBenhAn;
                    data.HoTenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                   
                    data.SoGiuong = DataReader["SoGiuong"].ToString();
                    data.Buong = DataReader["Buong"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.ChuanDoanPhu = DataReader["ChuanDoanPhu"].ToString();

                    data.ListChanDoan = ListChuanDoan;

                    data.NgayTao = Convert.ToDateTime(DataReader["NGAYTAO"] == DBNull.Value ? DateTime.Now : DataReader["NGAYTAO"]);
                    data.NguoiTao = DataReader["NGUOITAO"].ToString();
                    data.NgaySua = Convert.ToDateTime(DataReader["NGAYSUA"] == DBNull.Value ? DateTime.Now : DataReader["NGAYSUA"]);
                    data.NguoiSua = DataReader["NGUOISUA"].ToString();
                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;

                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuChamSoc ketQua)
        {
            try
            {
                string sql = @"INSERT INTO PhieuChamSoc
                (
                    MaQuanLy,
                    SoGiuong,
                    Buong,
                    ChanDoan,
                    ChuanDoanPhu,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
                    :SoGiuong,
                    :Buong,
                    :ChanDoan,
                    :ChuanDoanPhu,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE PhieuChamSoc SET 
                    MaQuanLy = :MaQuanLy,
                    SoGiuong = :SoGiuong,
                    Buong = :Buong,
                    ChanDoan = :ChanDoan,
                    ChuanDoanPhu = :ChuanDoanPhu,
                    NGAYSUA = :NGAYSUA,
                    NGUOISUA = :NGUOISUA
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", ketQua.MaQuanLy));

                Command.Parameters.Add(new MDB.MDBParameter("SoGiuong", ketQua.SoGiuong));
                Command.Parameters.Add(new MDB.MDBParameter("Buong", ketQua.Buong));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", ketQua.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("ChuanDoanPhu", ketQua.ChuanDoanPhu));

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

                bool IsSuccess = false;
                

                if (n > 0 && ketQua.ListChanDoan != null && ketQua.ListChanDoan.Count > 0)
                {
                    long nextval = 0;
                    if (ketQua.ID == 0)
                    {
                        nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);

                    } else
                    {
                        nextval = ketQua.ID;
                    }


                    foreach (ChuanDoan chuanDoan in ketQua.ListChanDoan)
                    {
                        chuanDoan.IDPhieuChamSoc = nextval;
                        IsSuccess = ChuanDoan.InsertOrUpdate(MyConnection, chuanDoan);
                    }

                    return IsSuccess;
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
                bool deleteChuanDoan = ChuanDoan.DeleteByIDPhieuChamSoc(MyConnection, id);
                if (deleteChuanDoan)
                {
                    string sql = @"DELETE FROM PhieuChamSoc WHERE ID = :ID";
                    MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, MyConnection);
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ID", id));
                    int n = oracleCommand.ExecuteNonQuery();
                    return n > 0;
                }
                return false;
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
                PhieuChamSoc P
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "KH");

            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("MaBenhAn", typeof(string));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));
            ds.Tables[0].AddColumn("NamSinh", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(string));
            ds.Tables[0].AddColumn("SOYTE", typeof(string));
            ds.Tables[0].AddColumn("BENHVIEN", typeof(string));
            ds.Tables[0].AddColumn("KHOA", typeof(string));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["MaBenhAn"] = XemBenhAn._ThongTinDieuTri.MaBenhAn;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["NamSinh"] = XemBenhAn._HanhChinhBenhNhan.NgaySinh.HasValue ? XemBenhAn._HanhChinhBenhNhan.NgaySinh.Value.Year + "" : "";
            ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            ds.Tables[0].Rows[0]["SOYTE"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["KHOA"] = XemBenhAn._ThongTinDieuTri.Khoa;

            

            return ds;
        }
    }

 
}