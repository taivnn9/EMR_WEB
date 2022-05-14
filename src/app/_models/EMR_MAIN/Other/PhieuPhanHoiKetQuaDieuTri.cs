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
    public class PhieuPhanHoiKetQuaDieuTri : ThongTinKy
    {
        public PhieuPhanHoiKetQuaDieuTri()
        {
            TableName = "PhieuPhanHoiKetQuaDieuTri";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PPHKQDTBNCD;
            TenMauPhieu = DanhMucPhieu.PPHKQDTBNCD.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        public string Tinh { get; set; }
        public string Huyen { get; set; }
        public string TenDonViChuyenDi { get; set; }
        public string HoTenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string TuoiBenhNhan { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinhBenhNhan { get; set; }
        public string SoDKDT { get; set; }
        public DateTime NgayTiepNhanDieuTri { get; set; }
        public DateTime NgayKetThucDieuTri { get; set; }
        public string KetQuaDieuTri { get; set; }
        public string ThuTruongDonVi { get; set; }
        public string YBacSi { get; set; }
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
    public class PhieuPhanHoiKetQuaDieuTriFunc
    {
        public const string TableName = "PhieuPhanHoiKetQuaDieuTri";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuPhanHoiKetQuaDieuTri> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuPhanHoiKetQuaDieuTri> list = new List<PhieuPhanHoiKetQuaDieuTri>();
            try
            {
                string sql = @"SELECT * FROM PhieuPhanHoiKetQuaDieuTri where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuPhanHoiKetQuaDieuTri data = new PhieuPhanHoiKetQuaDieuTri();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();

                    data.Tinh = DataReader["Tinh"].ToString();
                    data.Huyen = DataReader["Huyen"].ToString();
                    data.TenDonViChuyenDi = DataReader["TenDonViChuyenDi"].ToString();
                    data.HoTenBenhNhan = DataReader["HoTenBenhNhan"].ToString();
                    
                    data.TuoiBenhNhan = DataReader["TuoiBenhNhan"].ToString();
                    data.GioiTinhBenhNhan = DataReader["GioiTinhBenhNhan"].ToString();

                    data.SoDKDT = DataReader["SoDKDT"].ToString();
                    data.NgayTiepNhanDieuTri = Convert.ToDateTime(DataReader["NgayTiepNhanDieuTri"] == DBNull.Value ? DateTime.Now : DataReader["NgayTiepNhanDieuTri"]);
                    data.NgayKetThucDieuTri = Convert.ToDateTime(DataReader["NgayKetThucDieuTri"] == DBNull.Value ? DateTime.Now : DataReader["NgayKetThucDieuTri"]);
                    data.KetQuaDieuTri = DataReader["KetQuaDieuTri"].ToString();
                    data.ThuTruongDonVi = DataReader["ThuTruongDonVi"].ToString();
                    data.YBacSi = DataReader["YBacSi"].ToString();


                    data.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                    data.NguoiTao = DataReader["NguoiTao"].ToString();
                    data.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);
                    data.NguoiSua = DataReader["NguoiSua"].ToString();

                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;
                    list.Add(data);
                }
            }
            catch (Exception ex) {
                XuLyLoi.Handle(ex);
            }
            return list;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuPhanHoiKetQuaDieuTri bangDieuTri)
        {
            try
            {
                string sql = @"INSERT INTO PhieuPhanHoiKetQuaDieuTri
                (
                    MAQUANLY,
                    MaBenhNhan,
                    Tinh,
                    Huyen,
                    TenDonViChuyenDi,
                    HoTenBenhNhan,
                    TuoiBenhNhan,
                    GioiTinhBenhNhan,
                    SoDKDT,
                    NgayTiepNhanDieuTri,
                    NgayKetThucDieuTri,
                    KetQuaDieuTri,
                    ThuTruongDonVi,
                    YBacSi,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :Tinh,
                    :Huyen,
                    :TenDonViChuyenDi,
                    :HoTenBenhNhan,
                    :TuoiBenhNhan,
                    :GioiTinhBenhNhan,
                    :SoDKDT,
                    :NgayTiepNhanDieuTri,
                    :NgayKetThucDieuTri,
                    :KetQuaDieuTri,
                    :ThuTruongDonVi,
                    :YBacSi,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (bangDieuTri.ID != 0)
                {
                    sql = @"UPDATE PhieuPhanHoiKetQuaDieuTri SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    Tinh = :Tinh,
                    Huyen = :Huyen,
                    TenDonViChuyenDi = :TenDonViChuyenDi,
                    HoTenBenhNhan = :HoTenBenhNhan,
                    TuoiBenhNhan = :TuoiBenhNhan,
                    GioiTinhBenhNhan = :GioiTinhBenhNhan,
                    SoDKDT = :SoDKDT,
                    NgayTiepNhanDieuTri = :NgayTiepNhanDieuTri,
                    NgayKetThucDieuTri = :NgayKetThucDieuTri,
                    KetQuaDieuTri = :KetQuaDieuTri,
                    ThuTruongDonVi = :ThuTruongDonVi,
                    YBacSi = :YBacSi,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + bangDieuTri.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangDieuTri.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", bangDieuTri.MaBenhNhan));

                Command.Parameters.Add(new MDB.MDBParameter("Tinh", bangDieuTri.Tinh));
                Command.Parameters.Add(new MDB.MDBParameter("Huyen", bangDieuTri.Huyen));

                Command.Parameters.Add(new MDB.MDBParameter("TenDonViChuyenDi", bangDieuTri.TenDonViChuyenDi));
                Command.Parameters.Add(new MDB.MDBParameter("HoTenBenhNhan", bangDieuTri.HoTenBenhNhan));

                Command.Parameters.Add(new MDB.MDBParameter("TuoiBenhNhan", bangDieuTri.TuoiBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("GioiTinhBenhNhan", bangDieuTri.GioiTinhBenhNhan));

                Command.Parameters.Add(new MDB.MDBParameter("SoDKDT", bangDieuTri.SoDKDT));
                Command.Parameters.Add(new MDB.MDBParameter("NgayTiepNhanDieuTri", bangDieuTri.NgayTiepNhanDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("NgayKetThucDieuTri", bangDieuTri.NgayKetThucDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("KetQuaDieuTri", bangDieuTri.KetQuaDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("ThuTruongDonVi", bangDieuTri.ThuTruongDonVi));
                Command.Parameters.Add(new MDB.MDBParameter("YBacSi", bangDieuTri.YBacSi));

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", bangDieuTri.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", bangDieuTri.NgaySua));
                if (bangDieuTri.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", bangDieuTri.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", bangDieuTri.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", bangDieuTri.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (bangDieuTri.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    bangDieuTri.ID = nextval;
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
                string sql = "DELETE FROM PhieuPhanHoiKetQuaDieuTri WHERE ID = :ID";
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
                B.*,
	            H.TENBENHNHAN,
                H.BENHVIEN
            FROM
                PhieuPhanHoiKetQuaDieuTri B
                JOIN HANHCHINHBENHNHAN H ON B.MABENHNHAN = H.MABENHNHAN
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "BK");

            DataTable thongTinVien = new DataTable("HEADER");

            thongTinVien.Columns.Add("BENHVIEN");
            thongTinVien.Columns.Add("KHOA");
			if (XemBenhAn._HanhChinhBenhNhan == null) XemBenhAn._HanhChinhBenhNhan = new HanhChinhBenhNhan();
            if (XemBenhAn._ThongTinDieuTri == null) XemBenhAn._ThongTinDieuTri = new ThongTinDieuTri();
            thongTinVien.Rows.Add(XemBenhAn._HanhChinhBenhNhan.BenhVien, XemBenhAn._ThongTinDieuTri.Khoa);
            ds.Tables.Add(thongTinVien);

            return ds;
        }
    }
}
