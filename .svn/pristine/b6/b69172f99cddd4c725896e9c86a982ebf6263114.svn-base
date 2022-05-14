using EMR.KyDienTu;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.Access; 

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuLocMauCapCuu : ThongTinKy
    {
        public PhieuLocMauCapCuu()
        {
            TableName = "PhieuLocMauCapCuu";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PLMCC;
            TenMauPhieu = DanhMucPhieu.PLMCC.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        public DateTime NgayLocMau { get; set; }
        public string Cas { get; set; }
        public string NhaLocMau { get; set; }
        public string CanKho { get; set; }
        public string DuongVaoMachMau { get; set; }
        public double TocDoMau { get; set; }
        public double UF { get; set; }
        public string ChongDong { get; set; }
        public DateTime ThoiGianLocMau { get; set; }
        public string QuaLoc { get; set; }
        public int LanDung { get; set; }
        public string DichLoc { get; set; }
        public double TocDoLoc { get; set; }
        public string MayThan { get; set; }
        public string HuyetApTruocLoc { get; set; }
        public string HuyetApSauLoc { get; set; }
        public string CanNangTruocLoc { get; set; }
        public string CanNangSauLoc { get; set; }
        public string ThuocDung { get; set; }
        public string CacDung { get; set; }
        public string DienBien { get; set; }
        public int TongSoLanLocMau { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuong { get; set; }
        [MoTaDuLieu("Mã điều dưỡng")]
		public string MaDieuDuong { get; set; }
        [MoTaDuLieu("Bác sỹ điều trị")]
		public string BacSyDieuTri { get; set; }
        [MoTaDuLieu("Mã bác sỹ điều trị")]
		public string MaBacSyDieuTri { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
    }
    public class PhieuLocMauCapCuuFunc
    {
        public const string TableName = "PhieuLocMauCapCuu";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuLocMauCapCuu> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuLocMauCapCuu> list = new List<PhieuLocMauCapCuu>();
            try
            {
                string sql = @"SELECT * FROM PhieuLocMauCapCuu where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuLocMauCapCuu data = new PhieuLocMauCapCuu();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.NgayLocMau = Convert.ToDateTime(DataReader["NgayLocMau"] == DBNull.Value ? DateTime.Now : DataReader["NgayLocMau"]);
                    data.Cas = DataReader["Cas"].ToString();
                    data.NhaLocMau = DataReader["NhaLocMau"].ToString();
                    data.CanKho = DataReader["CanKho"].ToString();
                    data.DuongVaoMachMau = DataReader["DuongVaoMachMau"].ToString();

                    double tempDouble = 0;
                    double.TryParse(DataReader["TocDoMau"].ToString(), out tempDouble);
                    data.TocDoMau = tempDouble;

                    tempDouble = 0;
                    double.TryParse(DataReader["UF"].ToString(), out tempDouble);
                    data.UF = tempDouble;

                    data.ChongDong = DataReader["ChongDong"].ToString();
                    data.ThoiGianLocMau = Convert.ToDateTime(DataReader["ThoiGianLocMau"] == DBNull.Value ? DateTime.Now : DataReader["ThoiGianLocMau"]);
                    data.QuaLoc = DataReader["QuaLoc"].ToString();

                    int tempInt = -1;
                    int.TryParse(DataReader["LanDung"].ToString(), out tempInt);
                    data.LanDung = tempInt;

                    data.DichLoc = DataReader["DichLoc"].ToString();

                    tempDouble = 0;
                    double.TryParse(DataReader["TocDoLoc"].ToString(), out tempDouble);
                    data.TocDoLoc = tempDouble;
                    data.MayThan = DataReader["MayThan"].ToString();
                    data.HuyetApTruocLoc = DataReader["HuyetApTruocLoc"].ToString();
                    data.HuyetApSauLoc = DataReader["HuyetApSauLoc"].ToString();
                    data.CanNangTruocLoc = DataReader["CanNangTruocLoc"].ToString();
                    data.CanNangSauLoc = DataReader["CanNangSauLoc"].ToString();
                    data.ThuocDung = DataReader["ThuocDung"].ToString();
                    data.CacDung = DataReader["CacDung"].ToString();
                    data.DienBien = DataReader["DienBien"].ToString();

                    tempInt = -1;
                    int.TryParse(DataReader["TongSoLanLocMau"].ToString(), out tempInt);
                    data.TongSoLanLocMau = tempInt;

                    data.DieuDuong = DataReader["DieuDuong"].ToString();
                    data.MaDieuDuong = DataReader["MaDieuDuong"].ToString();
                    data.BacSyDieuTri = DataReader["BacSyDieuTri"].ToString();
                    data.MaBacSyDieuTri = DataReader["MaBacSyDieuTri"].ToString();

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuLocMauCapCuu phieuLocMau)
        {
            try
            {
                string sql = @"INSERT INTO PhieuLocMauCapCuu
                (
                    MAQUANLY,
                    MaBenhNhan,
                    NgayLocMau,
	                Cas,
	                NhaLocMau,
	                CanKho,
	                DuongVaoMachMau,
	                TocDoMau,
	                UF,
	                ChongDong,
	                ThoiGianLocMau,
	                QuaLoc,
	                LanDung,
	                DichLoc,
	                TocDoLoc,
	                MayThan,
	                HuyetApTruocLoc,
	                HuyetApSauLoc,
	                CanNangTruocLoc,
	                CanNangSauLoc,
	                ThuocDung,
	                CacDung,
	                DienBien,
	                TongSoLanLocMau,
	                DieuDuong,
	                MaDieuDuong,
	                BacSyDieuTri,
	                MaBacSyDieuTri,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :NgayLocMau,
	                :Cas,
	                :NhaLocMau,
	                :CanKho,
	                :DuongVaoMachMau,
	                :TocDoMau,
	                :UF,
	                :ChongDong,
	                :ThoiGianLocMau,
	                :QuaLoc,
	                :LanDung,
	                :DichLoc,
	                :TocDoLoc,
	                :MayThan,
	                :HuyetApTruocLoc,
	                :HuyetApSauLoc,
	                :CanNangTruocLoc,
	                :CanNangSauLoc,
	                :ThuocDung,
	                :CacDung,
	                :DienBien,
	                :TongSoLanLocMau,
	                :DieuDuong,
	                :MaDieuDuong,
	                :BacSyDieuTri,
	                :MaBacSyDieuTri,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (phieuLocMau.ID != 0)
                {
                    sql = @"UPDATE PhieuLocMauCapCuu SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    NgayLocMau = :NgayLocMau,
	                Cas = :Cas,
	                NhaLocMau = :NhaLocMau,
	                CanKho = :CanKho,
	                DuongVaoMachMau = :DuongVaoMachMau,
	                TocDoMau = :TocDoMau,
	                UF = :UF,
	                ChongDong = :ChongDong,
	                ThoiGianLocMau = :ThoiGianLocMau,
	                QuaLoc = :QuaLoc,
	                LanDung = :LanDung,
	                DichLoc = :DichLoc,
	                TocDoLoc = :TocDoLoc,
	                MayThan = :MayThan,
	                HuyetApTruocLoc = :HuyetApTruocLoc,
	                HuyetApSauLoc = :HuyetApSauLoc,
	                CanNangTruocLoc = :CanNangTruocLoc,
	                CanNangSauLoc = :CanNangSauLoc,
	                ThuocDung = :ThuocDung,
	                CacDung = :CacDung,
	                DienBien = :DienBien,
	                TongSoLanLocMau = :TongSoLanLocMau,
	                DieuDuong = :DieuDuong,
	                MaDieuDuong = :MaDieuDuong,
	                BacSyDieuTri = :BacSyDieuTri,
	                MaBacSyDieuTri = :MaBacSyDieuTri,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + phieuLocMau.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", phieuLocMau.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", phieuLocMau.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("NgayLocMau", phieuLocMau.NgayLocMau));
                Command.Parameters.Add(new MDB.MDBParameter("Cas", phieuLocMau.Cas));
                Command.Parameters.Add(new MDB.MDBParameter("NhaLocMau", phieuLocMau.NhaLocMau));
                Command.Parameters.Add(new MDB.MDBParameter("CanKho", phieuLocMau.CanKho));
                Command.Parameters.Add(new MDB.MDBParameter("DuongVaoMachMau", phieuLocMau.DuongVaoMachMau));
                Command.Parameters.Add(new MDB.MDBParameter("TocDoMau", phieuLocMau.TocDoMau));
                Command.Parameters.Add(new MDB.MDBParameter("UF", phieuLocMau.UF));
                Command.Parameters.Add(new MDB.MDBParameter("ChongDong", phieuLocMau.ChongDong));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianLocMau", phieuLocMau.ThoiGianLocMau));
                Command.Parameters.Add(new MDB.MDBParameter("QuaLoc", phieuLocMau.QuaLoc));
                Command.Parameters.Add(new MDB.MDBParameter("LanDung", phieuLocMau.LanDung));
                Command.Parameters.Add(new MDB.MDBParameter("DichLoc", phieuLocMau.DichLoc));
                Command.Parameters.Add(new MDB.MDBParameter("TocDoLoc", phieuLocMau.TocDoLoc));
                Command.Parameters.Add(new MDB.MDBParameter("MayThan", phieuLocMau.MayThan));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetApTruocLoc", phieuLocMau.HuyetApTruocLoc));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetApSauLoc", phieuLocMau.HuyetApSauLoc));
                Command.Parameters.Add(new MDB.MDBParameter("CanNangTruocLoc", phieuLocMau.CanNangTruocLoc));
                Command.Parameters.Add(new MDB.MDBParameter("CanNangSauLoc", phieuLocMau.CanNangSauLoc));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocDung", phieuLocMau.ThuocDung));
                Command.Parameters.Add(new MDB.MDBParameter("CacDung", phieuLocMau.CacDung));
                Command.Parameters.Add(new MDB.MDBParameter("DienBien", phieuLocMau.DienBien));
                Command.Parameters.Add(new MDB.MDBParameter("TongSoLanLocMau", phieuLocMau.TongSoLanLocMau));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuong", phieuLocMau.DieuDuong));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuong", phieuLocMau.MaDieuDuong));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", phieuLocMau.BacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSyDieuTri", phieuLocMau.MaBacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", phieuLocMau.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", phieuLocMau.NgaySua));
                if (phieuLocMau.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", phieuLocMau.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", phieuLocMau.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", phieuLocMau.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (phieuLocMau.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    phieuLocMau.ID = nextval;
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
                string sql = "DELETE FROM PhieuLocMauCapCuu WHERE ID = :ID";
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
                P.*,
                T.MABENHAN,
                H.GIOITINH,
	            H.TENBENHNHAN,
                H.TUOI,
                H.SOYTE,
                H.BENHVIEN,
                (H.SONHA || ',' || H.THONPHO || ',' ||  H.XAPHUONG || ',' ||  H.HUYENQUAN || ',' ||  H.TINHTHANHPHO) AS DIACHI 
            FROM
                PhieuLocMauCapCuu P
                LEFT JOIN THONGTINDIEUTRI T ON P.MAQUANLY = T.MAQUANLY
                LEFT JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "PL");
            return ds;
        }
    }
}
