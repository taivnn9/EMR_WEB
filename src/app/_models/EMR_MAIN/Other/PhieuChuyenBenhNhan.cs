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
    public class PhieuChuyenBenhNhan : ThongTinKy
    {
        public PhieuChuyenBenhNhan()
        {
            TableName = "PhieuChuyenBenhNhan";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PCBNDTTDT;
            TenMauPhieu = DanhMucPhieu.PCBNDTTDT.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        public string Tinh { get; set; }
        public string Huyen { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        public string Gioi { get; set; }
        public string SoDKDT { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChiBenhNhan { get; set; }
        public string SdtBenhNhan { get; set; }

        public string HoTenNguoiThan { get; set; }
        public string SdtNguoiThan { get; set; }

        public int VaoSoSKDTBenhLao { get; set; }
        public string CoSoChuyenDi { get; set; }
        public string SdtCoSoChuyenDi { get; set; }
        public string CoSoTiepNhan { get; set; }
        public string SdtCoSoTiepNhan { get; set; }
        
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public string KetQuaXN { get; set; }
        public string CongThucDieuTri { get; set; }
        public DateTime? NgayBatDauDieuTri { get; set; }
        public string ThoiGianDaDieuTri { get; set; }
        public string ThoiGianDieuTriTiep { get; set; }
        public DateTime NgayChuyenDi { get; set; }

        public string LanhDaoDonVi { get; set; }
        [MoTaDuLieu("Bác sỹ điều trị")]
		public string BacSiDieuTri { get; set; }

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
    public class PhieuChuyenBenhNhanFunc
    {
        public const string TableName = "PhieuChuyenBenhNhan";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuChuyenBenhNhan> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuChuyenBenhNhan> list = new List<PhieuChuyenBenhNhan>();
            try
            {
                string sql = @"SELECT * FROM PhieuChuyenBenhNhan where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuChuyenBenhNhan data = new PhieuChuyenBenhNhan();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.TenBenhNhan = DataReader["TenBenhNhan"].ToString();

                    data.Tinh = DataReader["Tinh"].ToString();
                    data.Huyen = DataReader["Huyen"].ToString();

                    data.Tuoi = DataReader["Tuoi"].ToString();
                    data.Gioi = DataReader["Gioi"].ToString();
                    data.SoDKDT = DataReader["SoDKDT"].ToString();
                    data.DiaChiBenhNhan = DataReader["DiaChiBenhNhan"].ToString();
                    data.SdtBenhNhan = DataReader["SdtBenhNhan"].ToString();
                    data.HoTenNguoiThan = DataReader["HoTenNguoiThan"].ToString();
                    data.SdtNguoiThan = DataReader["SdtNguoiThan"].ToString();

                    data.VaoSoSKDTBenhLao = int.Parse(DataReader["VaoSoSKDTBenhLao"].ToString());
                    data.CoSoChuyenDi = DataReader["CoSoChuyenDi"].ToString();
                    data.SdtCoSoChuyenDi = DataReader["SdtCoSoChuyenDi"].ToString();
                    data.CoSoTiepNhan = DataReader["CoSoTiepNhan"].ToString();
                    data.SdtCoSoTiepNhan = DataReader["SdtCoSoTiepNhan"].ToString();

                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.KetQuaXN = DataReader["KetQuaXN"].ToString();
                    data.CongThucDieuTri = DataReader["CongThucDieuTri"].ToString();

                    if (DataReader["NgayBatDauDieuTri"] != DBNull.Value)
                        data.NgayBatDauDieuTri = Convert.ToDateTime(DataReader["NgayBatDauDieuTri"]);
                    data.ThoiGianDaDieuTri = DataReader["ThoiGianDaDieuTri"].ToString();
                    data.ThoiGianDieuTriTiep = DataReader["ThoiGianDieuTriTiep"].ToString();
                    data.NgayChuyenDi = Convert.ToDateTime(DataReader["NgayChuyenDi"] == DBNull.Value ? DateTime.Now : DataReader["NgayChuyenDi"]);

                    data.LanhDaoDonVi = DataReader["LanhDaoDonVi"].ToString();
                    data.BacSiDieuTri = DataReader["BacSiDieuTri"].ToString();


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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuChuyenBenhNhan bangDieuTri)
        {
            try
            {
                string sql = @"INSERT INTO PhieuChuyenBenhNhan
                (
                    MAQUANLY,
                    MaBenhNhan,
                    Tinh,
                    Huyen,
                    TenBenhNhan,
                    Tuoi,
                    Gioi,
                    SoDKDT,
                    DiaChiBenhNhan,
                    SdtBenhNhan,
                    HoTenNguoiThan,
                    SdtNguoiThan,
                    VaoSoSKDTBenhLao,
                    CoSoChuyenDi,
                    SdtCoSoChuyenDi,
                    CoSoTiepNhan,
                    SdtCoSoTiepNhan,
                    ChanDoan,
                    KetQuaXN,
                    CongThucDieuTri,
                    NgayBatDauDieuTri,
                    ThoiGianDaDieuTri,
                    ThoiGianDieuTriTiep,
                    NgayChuyenDi,
                    LanhDaoDonVi,
                    BacSiDieuTri,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :Tinh,
                    :Huyen,
                    :TenBenhNhan,
                    :Tuoi,
                    :Gioi,
                    :SoDKDT,
                    :DiaChiBenhNhan,
                    :SdtBenhNhan,
                    :HoTenNguoiThan,
                    :SdtNguoiThan,
                    :VaoSoSKDTBenhLao,
                    :CoSoChuyenDi,
                    :SdtCoSoChuyenDi,
                    :CoSoTiepNhan,
                    :SdtCoSoTiepNhan,
                    :ChanDoan,
                    :KetQuaXN,
                    :CongThucDieuTri,
                    :NgayBatDauDieuTri,
                    :ThoiGianDaDieuTri,
                    :ThoiGianDieuTriTiep,
                    :NgayChuyenDi,
                    :LanhDaoDonVi,
                    :BacSiDieuTri,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (bangDieuTri.ID != 0)
                {
                    sql = @"UPDATE PhieuChuyenBenhNhan SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    Tinh = :Tinh,
                    Huyen = :Huyen,
                    TenBenhNhan = :TenBenhNhan,
                    Tuoi = :Tuoi,
                    Gioi = :Gioi,
                    SoDKDT = :SoDKDT,
                    DiaChiBenhNhan = :DiaChiBenhNhan,
                    SdtBenhNhan = :SdtBenhNhan,
                    HoTenNguoiThan = :HoTenNguoiThan,
                    SdtNguoiThan = :SdtNguoiThan,
                    VaoSoSKDTBenhLao = :VaoSoSKDTBenhLao,
                    CoSoChuyenDi = :CoSoChuyenDi,
                    SdtCoSoChuyenDi = :SdtCoSoChuyenDi,
                    CoSoTiepNhan = :CoSoTiepNhan,
                    SdtCoSoTiepNhan = :SdtCoSoTiepNhan,
                    ChanDoan = :ChanDoan,
                    KetQuaXN = :KetQuaXN,
                    CongThucDieuTri = :CongThucDieuTri,
                    NgayBatDauDieuTri = :NgayBatDauDieuTri,
                    ThoiGianDaDieuTri = :ThoiGianDaDieuTri,
                    ThoiGianDieuTriTiep = :ThoiGianDieuTriTiep,
                    NgayChuyenDi = :NgayChuyenDi,
                    LanhDaoDonVi = :LanhDaoDonVi,
                    BacSiDieuTri = :BacSiDieuTri,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + bangDieuTri.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangDieuTri.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", bangDieuTri.MaBenhNhan));

                Command.Parameters.Add(new MDB.MDBParameter("Tinh", bangDieuTri.Tinh));
                Command.Parameters.Add(new MDB.MDBParameter("Huyen", bangDieuTri.Huyen));

                Command.Parameters.Add(new MDB.MDBParameter("TenBenhNhan", bangDieuTri.TenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("Tuoi", bangDieuTri.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("Gioi", bangDieuTri.Gioi));
                Command.Parameters.Add(new MDB.MDBParameter("SoDKDT", bangDieuTri.SoDKDT));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChiBenhNhan", bangDieuTri.DiaChiBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("SdtBenhNhan", bangDieuTri.SdtBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("HoTenNguoiThan", bangDieuTri.HoTenNguoiThan));
                Command.Parameters.Add(new MDB.MDBParameter("SdtNguoiThan", bangDieuTri.SdtNguoiThan));
                Command.Parameters.Add(new MDB.MDBParameter("VaoSoSKDTBenhLao", bangDieuTri.VaoSoSKDTBenhLao));
                Command.Parameters.Add(new MDB.MDBParameter("CoSoChuyenDi", bangDieuTri.CoSoChuyenDi));
                Command.Parameters.Add(new MDB.MDBParameter("SdtCoSoChuyenDi", bangDieuTri.SdtCoSoChuyenDi));
                Command.Parameters.Add(new MDB.MDBParameter("CoSoTiepNhan", bangDieuTri.CoSoTiepNhan));
                Command.Parameters.Add(new MDB.MDBParameter("SdtCoSoTiepNhan", bangDieuTri.SdtCoSoTiepNhan));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", bangDieuTri.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("KetQuaXN", bangDieuTri.KetQuaXN));
                Command.Parameters.Add(new MDB.MDBParameter("CongThucDieuTri", bangDieuTri.CongThucDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("NgayBatDauDieuTri", bangDieuTri.NgayBatDauDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianDaDieuTri", bangDieuTri.ThoiGianDaDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianDieuTriTiep", bangDieuTri.ThoiGianDieuTriTiep));
                Command.Parameters.Add(new MDB.MDBParameter("NgayChuyenDi", bangDieuTri.NgayChuyenDi));
                Command.Parameters.Add(new MDB.MDBParameter("LanhDaoDonVi", bangDieuTri.LanhDaoDonVi));
                Command.Parameters.Add(new MDB.MDBParameter("BacSiDieuTri", bangDieuTri.BacSiDieuTri));

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
                string sql = "DELETE FROM PhieuChuyenBenhNhan WHERE ID = :ID";
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
                PhieuChuyenBenhNhan B
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