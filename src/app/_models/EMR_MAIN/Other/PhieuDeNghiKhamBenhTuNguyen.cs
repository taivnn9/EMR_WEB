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
    public class PhieuDeNghiKhamBenhTuNguyen : ThongTinKy
    {
        public PhieuDeNghiKhamBenhTuNguyen()
        {
            TableName = "PHIEUKHAMBENHTUNGUYEN";
            TablePrimaryKeyName = "IDPHIEUKHAMBENHTUNGUYEN";
            IDMauPhieu = (int)DanhMucPhieu.DKKBTN;
            TenMauPhieu = DanhMucPhieu.DKKBTN.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long IdPhieuDeNghiKhamBenhTuNguyen { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        public GioiTinh GioiTinh { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }
        public string KhamBenh { get; set; }
        public string XetNghiem { get; set; }
        public string VatTuYTe { get; set; }
        public string KyThuat { get; set; }
        public string Thuoc { get; set; }
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
    }
    public class PhieuDeNghiKhamBenhTuNguyenFunc
    {
        public const string TableName = "PHIEUKHAMBENHTUNGUYEN";
        public const string TablePrimaryKeyName = "IDPHIEUKHAMBENHTUNGUYEN";
        public static List<PhieuDeNghiKhamBenhTuNguyen> GetData(decimal maQuanLy, MDB.MDBConnection _OracleConnection)
        {
            List<PhieuDeNghiKhamBenhTuNguyen> lstData = new List<PhieuDeNghiKhamBenhTuNguyen>();
            try
            {
                string sql = @"SELECT * FROM PHIEUKHAMBENHTUNGUYEN where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maQuanLy));
                Command.BindByName = true;
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                if (XemBenhAn._HanhChinhBenhNhan == null) XemBenhAn._HanhChinhBenhNhan = new HanhChinhBenhNhan();
                while (DataReader.Read())
                {
                    PhieuDeNghiKhamBenhTuNguyen data = new PhieuDeNghiKhamBenhTuNguyen();
                    data.IdPhieuDeNghiKhamBenhTuNguyen = Convert.ToInt64(DataReader.GetLong("IDPhieuKhamBenhTuNguyen").ToString());
                    data.MaQuanLy = maQuanLy;
                    data.MaBenhNhan = XemBenhAn._HanhChinhBenhNhan.MaBenhNhan;
                    data.TenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh;
                    data.DiaChi = Common.GetDiaChi();
                    data.Khoa = DataReader["Khoa"].ToString();
                    data.MaKhoa = DataReader["MaKhoa"].ToString();
                    data.KhamBenh = DataReader["KhamBenh"].ToString();
                    data.XetNghiem = DataReader["XetNghiem"].ToString();
                    data.VatTuYTe = DataReader["VatTuYTe"].ToString();
                    data.KyThuat = DataReader["KyThuat"].ToString();
                    data.Thuoc = DataReader["Thuoc"].ToString();

                    data.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                    data.NguoiTao = DataReader["NguoiTao"].ToString();
                    data.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);
                    data.NguoiSua = DataReader["NguoiSua"].ToString();
                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;
                    lstData.Add(data);
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return lstData;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuDeNghiKhamBenhTuNguyen phieu)
        {
            string sql = @"INSERT INTO PHIEUKHAMBENHTUNGUYEN
                (
                    MAQUANLY,
                    MABENHNHAN,
                    KHOA,
                    MAKHOA,
                    KHAMBENH,
                    XETNGHIEM,
                    VATTUYTE,
                    KYTHUAT,
                    THUOC,
                    NGUOITAO,
                    NGAYTAO,
                    NGUOISUA,
                    NGAYSUA)  VALUES
                 (
                    :MAQUANLY,
                    :MABENHNHAN,
                    :KHOA,
                    :MAKHOA,
                    :KHAMBENH,
                    :XETNGHIEM,
                    :VATTUYTE,
                    :KYTHUAT,
                    :THUOC,
                    :NGUOITAO,
                    :NGAYTAO,
                    :NGUOISUA,
                    :NGAYSUA
                )  RETURNING IDPHIEUKHAMBENHTUNGUYEN INTO :IDPHIEUKHAMBENHTUNGUYEN";
            if (phieu.IdPhieuDeNghiKhamBenhTuNguyen != 0)
            {
                sql = @"UPDATE PHIEUKHAMBENHTUNGUYEN SET 
                    MAQUANLY = :MAQUANLY, 
                    MABENHNHAN = :MABENHNHAN, 
                    KHOA = :KHOA,
                    MAKHOA = :MAKHOA,
                    KHAMBENH = :KHAMBENH,
                    XETNGHIEM = :XETNGHIEM,
                    VATTUYTE = :VATTUYTE,
                    KYTHUAT = :KYTHUAT,
                    THUOC = :THUOC,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE IDPHIEUKHAMBENHTUNGUYEN = " + phieu.IdPhieuDeNghiKhamBenhTuNguyen;
            }
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", phieu.MaQuanLy));
            Command.Parameters.Add(new MDB.MDBParameter("MABENHNHAN", phieu.MaBenhNhan));
            Command.Parameters.Add(new MDB.MDBParameter("KHOA", phieu.Khoa));
            Command.Parameters.Add(new MDB.MDBParameter("MAKHOA", phieu.MaKhoa));
            Command.Parameters.Add(new MDB.MDBParameter("KHAMBENH", phieu.KhamBenh));
            Command.Parameters.Add(new MDB.MDBParameter("XETNGHIEM", phieu.XetNghiem));
            Command.Parameters.Add(new MDB.MDBParameter("VATTUYTE", phieu.VatTuYTe));
            Command.Parameters.Add(new MDB.MDBParameter("KYTHUAT", phieu.KyThuat));
            Command.Parameters.Add(new MDB.MDBParameter("THUOC", phieu.Thuoc));
            Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", phieu.NguoiSua));
            Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", phieu.NgaySua));
            if (phieu.IdPhieuDeNghiKhamBenhTuNguyen == 0)
            {
                Command.Parameters.Add(new MDB.MDBParameter("IDPHIEUKHAMBENHTUNGUYEN", phieu.IdPhieuDeNghiKhamBenhTuNguyen));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", phieu.NguoiTao));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", phieu.NgayTao));
            }
            Command.BindByName = true;
            int n = Command.ExecuteNonQuery(); // C#
            if (phieu.IdPhieuDeNghiKhamBenhTuNguyen == 0)
            {
                long nextval = Convert.ToInt64((Command.Parameters["IDPHIEUKHAMBENHTUNGUYEN"] as MDB.MDBParameter).Value);
                phieu.IdPhieuDeNghiKhamBenhTuNguyen = nextval;
            }

            return n > 0 ? true : false;
        }
        public static bool delete(MDB.MDBConnection MyConnection, decimal IdPhieuDeNghiKhamBenhTuNguyen)
        {
            try
            {
                string sql = "DELETE FROM PHIEUKHAMBENHTUNGUYEN WHERE IDPHIEUKHAMBENHTUNGUYEN = :IDPHIEUKHAMBENHTUNGUYEN";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                command.Parameters.Add(new MDB.MDBParameter("IDPHIEUKHAMBENHTUNGUYEN", IdPhieuDeNghiKhamBenhTuNguyen));
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
        public static DataSet getDataSet(MDB.MDBConnection MyConnection, decimal IdPhieuDeNghiKhamBenhTuNguyen)
        {
            string sql = @"SELECT
                P.*,
                H.TENBENHNHAN,
	            H.TUOI,
	            H.GIOITINH,
                (H.SONHA ||  ',' || H.THONPHO || ',' || H.XAPHUONG || ',' || H.HUYENQUAN) as DIACHI
            FROM
                PHIEUKHAMBENHTUNGUYEN P LEFT JOIN  HANHCHINHBENHNHAN H ON P.MABENHNHAN = H.MABENHNHAN
            WHERE
                IDPHIEUKHAMBENHTUNGUYEN = " + IdPhieuDeNghiKhamBenhTuNguyen;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            adt.Fill(ds, "PHIEU");
            DataTable thongTinVien = new DataTable("HEADER");

            thongTinVien.Columns.Add("BENHVIEN");
            thongTinVien.Columns.Add("KHOA");
            thongTinVien.Rows.Add(XemBenhAn._HanhChinhBenhNhan.BenhVien, XemBenhAn._ThongTinDieuTri.Khoa);
            ds.Tables.Add(thongTinVien);

            return ds;
        }
    }
}
