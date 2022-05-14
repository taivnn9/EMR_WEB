using EMR.KyDienTu;
using MDB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.Access; 

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuTheoDoiDuongMaoMach : ThongTinKy
    {
        public PhieuTheoDoiDuongMaoMach()
        {
            TableName = "PhieuTheoDoiDuongMaoMach";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PTDMM;
            TenMauPhieu = DanhMucPhieu.PTDMM.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }
        public DateTime NgayTest { get; set; }
        public DateTime GioTest { get; set; }
        public double? KetQua { get; set; }
        public string LoaiInsulin { get; set; }
        public int? Lieu { get; set; }
        public string KTVTest {get;set;}
        public string MaKTVTest { get; set; }
        public string BacSyChiDinh { get; set; }
        public string MaBacSyChiDinh { get; set; }
        public string ThuocDDTDaUong { get; set; }
        public string DaAn { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }

        internal static List<PhieuTheoDoiDuongMaoMach> GetData(MDBConnection myConnection, decimal maQuanLy, string tenKhoa)
        {
            throw new NotImplementedException();
        }
    }
    public class PhieuTheoDoiDuongMaoMachFunc
    {
        public const string TableName = "PhieuTheoDoiDuongMaoMach";
        public const string TablePrimaryKeyName = "ID";
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuTheoDoiDuongMaoMach phieuTheoDoi)
        {
            try
            {
                string sql = @"INSERT INTO PhieuTheoDoiDuongMaoMach
                (
                    MaQuanLy,
                    MaBenhNhan,
                    Khoa,
                    MaKhoa,
                    NgayGioTest,
                    KetQua,
                    LoaiInsulin,
                    Lieu,
                    KTVTest,
                    MaKTVTest,
                    BacSyChiDinh,
                    MaBacSyChiDinh,
                    ThuocDDTDaUong,
                    DaAn)  VALUES
                 (
				    :MaQuanLy,
                    :MaBenhNhan,
                    :Khoa,
                    :MaKhoa,
                    :NgayGioTest,
                    :KetQua,
                    :LoaiInsulin,
                    :Lieu,
                    :KTVTest,
                    :MaKTVTest,
                    :BacSyChiDinh,
                    :MaBacSyChiDinh,
                    :ThuocDDTDaUong,
                    :DaAn
                 )  RETURNING ID INTO :ID";
                if (phieuTheoDoi.ID != 0)
                {
                    sql = @"UPDATE PhieuTheoDoiDuongMaoMach SET 
                    MaQuanLy = :MaQuanLy,
                    MaBenhNhan = :MaBenhNhan,
                    Khoa = :Khoa,
                    MaKhoa = :MaKhoa,
                    NgayGioTest = :NgayGioTest,
                    KetQua = :KetQua,
                    LoaiInsulin = :LoaiInsulin,
                    Lieu = :Lieu,
                    KTVTest = :KTVTest,
                    MaKTVTest = :MaKTVTest,
                    BacSyChiDinh = :BacSyChiDinh,
                    MaBacSyChiDinh = :MaBacSyChiDinh,
                    ThuocDDTDaUong = :ThuocDDTDaUong,
                    DaAn = :DaAn 
                    WHERE ID = " + phieuTheoDoi.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", phieuTheoDoi.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", phieuTheoDoi.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa", phieuTheoDoi.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaKhoa", phieuTheoDoi.MaKhoa));
                var Ngay = phieuTheoDoi.NgayTest.Date.Add(new TimeSpan(0, 0, 0));
                var Gio = phieuTheoDoi.GioTest != null ? phieuTheoDoi.GioTest.TimeOfDay : DateTime.Now.TimeOfDay;
                var NgayGioTest = Ngay + Gio;
                Command.Parameters.Add(new MDB.MDBParameter("NgayGioTest", NgayGioTest));
                Command.Parameters.Add(new MDB.MDBParameter("KetQua", phieuTheoDoi.KetQua));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiInsulin", phieuTheoDoi.LoaiInsulin));
                Command.Parameters.Add(new MDB.MDBParameter("Lieu", phieuTheoDoi.Lieu));
                Command.Parameters.Add(new MDB.MDBParameter("KTVTest", phieuTheoDoi.KTVTest));
                Command.Parameters.Add(new MDB.MDBParameter("MaKTVTest", phieuTheoDoi.MaKTVTest));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyChiDinh", phieuTheoDoi.BacSyChiDinh));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSyChiDinh", phieuTheoDoi.MaBacSyChiDinh));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocDDTDaUong", phieuTheoDoi.ThuocDDTDaUong));
                Command.Parameters.Add(new MDB.MDBParameter("DaAn", phieuTheoDoi.DaAn));
                if (phieuTheoDoi.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", phieuTheoDoi.ID));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (phieuTheoDoi.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    phieuTheoDoi.ID = nextval;
                }
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static List<PhieuTheoDoiDuongMaoMach> GetData(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            List<PhieuTheoDoiDuongMaoMach> lstData = new List<PhieuTheoDoiDuongMaoMach>();
            string sql = @"select * from PhieuTheoDoiDuongMaoMach WHERE  MaQuanLy = :MaQuanLy ORDER BY NgayGioTest asc";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            while (DataReader.Read())
            {
                try
                {
                    PhieuTheoDoiDuongMaoMach data = new PhieuTheoDoiDuongMaoMach();
                    data.ID = DataReader.GetLong("ID");
                    data.MaQuanLy = DataReader.GetDecimal("MaQuanLy");
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.Khoa = DataReader["Khoa"].ToString();
                    data.MaKhoa = DataReader["MaKhoa"].ToString();
                    data.NgayTest = Convert.ToDateTime(DataReader["NgayGioTest"] == DBNull.Value ? DateTime.Now : DataReader["NgayGioTest"]);
                    data.GioTest = Convert.ToDateTime(DataReader["NgayGioTest"] == DBNull.Value ? DateTime.Now : DataReader["NgayGioTest"]);
                    double tempDouble = 0;
                    data.KetQua = double.TryParse(DataReader["KetQua"].ToString(), out tempDouble) ? (double?)tempDouble: null;
                    data.LoaiInsulin = DataReader["LoaiInsulin"].ToString();
                    int tempInt = 0;
                    data.Lieu = int.TryParse(DataReader["Lieu"].ToString(), out tempInt) ? (int?)tempInt : null;
                    data.KTVTest = DataReader["KTVTest"].ToString();
                    data.MaKTVTest = DataReader["MaKTVTest"].ToString();
                    data.BacSyChiDinh = DataReader["BacSyChiDinh"].ToString();
                    data.MaBacSyChiDinh = DataReader["MaBacSyChiDinh"].ToString();
                    data.ThuocDDTDaUong = DataReader["ThuocDDTDaUong"].ToString();
                    data.DaAn = DataReader["DaAn"].ToString();
                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;
                    lstData.Add(data);
                }
                catch (Exception ex)
                {
                    MDB.ExceptionExtend.LogError(ex);
                }
            }
            return lstData;
        }
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, decimal MaQuanLy, string _DateFrom = "", string _DateTo = "")
        {
            var timer = new Stopwatch();
            timer.Start();
			if (XemBenhAn._HanhChinhBenhNhan == null) XemBenhAn._HanhChinhBenhNhan = new HanhChinhBenhNhan();
            if (XemBenhAn._ThongTinDieuTri == null) XemBenhAn._ThongTinDieuTri = new ThongTinDieuTri();
            try
            {
                var ds = new DataSet();

                DataTable thongTinVien = new DataTable("HC");
                thongTinVien.Columns.Add("BENHVIEN");
                thongTinVien.Columns.Add("TENBENHNHAN");
                thongTinVien.Columns.Add("TUOI");
                thongTinVien.Columns.Add("GIOITINH");
                thongTinVien.Columns.Add("GIUONG");
                thongTinVien.Columns.Add("BUONG");
                thongTinVien.Columns.Add("SOHOSO");
                thongTinVien.Columns.Add("NGAYVAOKHOA");
                thongTinVien.Columns.Add("CHANDOAN");
                thongTinVien.Columns.Add("MABENHAN");
                thongTinVien.Rows.Add(XemBenhAn._HanhChinhBenhNhan.BenhVien,
                    XemBenhAn._HanhChinhBenhNhan.TenBenhNhan,
                    XemBenhAn._HanhChinhBenhNhan.Tuoi,
                    XemBenhAn._HanhChinhBenhNhan.GioiTinh,
                    XemBenhAn._ThongTinDieuTri.Giuong,
                    XemBenhAn._ThongTinDieuTri.Buong,
                    XemBenhAn._ThongTinDieuTri.SoLuuTru,
                    XemBenhAn._ThongTinDieuTri.NgayVaoKhoa,
                    XemBenhAn._ThongTinDieuTri.ChanDoan_KhiVaoKhoaDieuTri,
                     XemBenhAn._ThongTinDieuTri.MaBenhAn);

                ds.Tables.Add(thongTinVien);
                string sql = @"select a.* from PhieuTheoDoiDuongMaoMach a WHERE a.MaQuanLy = :MaQuanLy";
                if (!string.IsNullOrEmpty(_DateFrom) && !string.IsNullOrEmpty(_DateTo))
                {
                    try
                    {
                        DateTime dtiTu = PMS.Access.ThuVien.ToDate(_DateFrom);
                        DateTime dtiDen = PMS.Access.ThuVien.ToDate(_DateTo);
                        sql += " and a.NgayGioTest >= to_date('" + dtiTu.ToString("dd/MM/yyyy HH:mm:ss") + "','dd/MM/yyyy hh24:mi:ss') and a.NgayGioTest <= to_date('" + _DateTo + "','dd/MM/yyyy hh24:mi:ss') ";
                    }
                    catch (Exception ex)
                    {
                        MDB.ExceptionExtend.LogError(ex);
                    }
                }
                sql += " ORDER BY a.NgayGioTest asc";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
                MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);

                adt.Fill(ds, "TABLE");

                ds.Tables[0].Columns.Add("Khoa", typeof(string));
                ds.Tables[0].Rows[0]["Khoa"] = string.IsNullOrEmpty(ds.Tables[1].Rows[0]["Khoa"].ToString()) ? XemBenhAn._ThongTinDieuTri.Khoa : ds.Tables[1].Rows[0]["Khoa"].ToString();

               
                return ds;
            }
            catch (Exception ex)
            {
                MDB.ExceptionExtend.LogError(ex);
                return null;
            }
            finally
            {
                timer.Stop();
                MDB.ExceptionExtend.Log(typeof(PhieuTheoDoiDuongMaoMach), "End get data " + MaQuanLy + ". Total " + timer.ElapsedMilliseconds.ToString() + " ms");
            }
        }
        public static DataSet GetDataSetPhieu(MDB.MDBConnection MyConnection, long ID)
        {
            var timer = new Stopwatch();
            timer.Start();
            if (XemBenhAn._HanhChinhBenhNhan == null) XemBenhAn._HanhChinhBenhNhan = new HanhChinhBenhNhan();
            if (XemBenhAn._ThongTinDieuTri == null) XemBenhAn._ThongTinDieuTri = new ThongTinDieuTri();
            try
            {
                var ds = new DataSet();

                DataTable thongTinVien = new DataTable("HC");
                thongTinVien.Columns.Add("BENHVIEN");
                thongTinVien.Columns.Add("KHOA");
                thongTinVien.Columns.Add("TENBENHNHAN");
                thongTinVien.Columns.Add("TUOI");
                thongTinVien.Columns.Add("GIOITINH");
                thongTinVien.Columns.Add("GIUONG");
                thongTinVien.Columns.Add("BUONG");
                thongTinVien.Columns.Add("SOHOSO");
                thongTinVien.Columns.Add("NGAYVAOKHOA");
                thongTinVien.Columns.Add("CHANDOAN");
                thongTinVien.Rows.Add(XemBenhAn._HanhChinhBenhNhan.BenhVien,
                    XemBenhAn._ThongTinDieuTri.Khoa,
                    XemBenhAn._HanhChinhBenhNhan.TenBenhNhan,
                    XemBenhAn._HanhChinhBenhNhan.Tuoi,
                    XemBenhAn._HanhChinhBenhNhan.GioiTinh,
                    XemBenhAn._ThongTinDieuTri.Giuong,
                    XemBenhAn._ThongTinDieuTri.Buong,
                    XemBenhAn._ThongTinDieuTri.SoLuuTru,
                    XemBenhAn._ThongTinDieuTri.NgayVaoKhoa,
                    XemBenhAn._ThongTinDieuTri.ChanDoan_KhiVaoKhoaDieuTri);
                ds.Tables.Add(thongTinVien);

                string sql = @"select a.* from PhieuTheoDoiDuongMaoMach a WHERE a.ID = :ID";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID", ID));
                MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);

                adt.Fill(ds, "TABLE");
                return ds;
            }
            catch (Exception ex)
            {
                MDB.ExceptionExtend.LogError(ex);
                return null;
            }
            finally
            {
                timer.Stop();
                MDB.ExceptionExtend.Log(typeof(PhieuTheoDoiDuongMaoMach), "End get data " + ID + ". Total " + timer.ElapsedMilliseconds.ToString() + " ms");
            }
        }
        public static bool Delete(MDBConnection myConnection, long iD)
        {
            string sql = @"Delete from PhieuTheoDoiDuongMaoMach where ID = :ID";
            MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, myConnection);
            oracleCommand.Parameters.Add("ID", iD);

            int n = oracleCommand.ExecuteNonQuery();
            return n > 0 ? true : false;
        }

        public static System.Data.DataSet GetDataSetByDate(MDB.MDBConnection MyConnection, decimal MaQuanLy, string Khoa, DateTime _DateFrom, DateTime _DateTo)
        {
            if (_DateFrom == Convert.ToDateTime(null) || _DateTo == Convert.ToDateTime(null))
            {
                return GetDataSet(MyConnection, MaQuanLy, "", "");
            }
            else
            {
                return GetDataSet(MyConnection, MaQuanLy, _DateFrom.ToString("dd/MM/yyyy HH:mm:ss"), _DateTo.ToString("dd/MM/yyyy HH:mm:ss"));
            }
        }

    }
}
