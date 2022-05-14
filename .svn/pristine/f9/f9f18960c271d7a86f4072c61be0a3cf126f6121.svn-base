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
    public class CamKetTiemChatTuongPhan : ThongTinKy
    {
        public CamKetTiemChatTuongPhan()
        {
            TableName = "CamKetTiemChatTuongPhan";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.CKTCTP;
            TenMauPhieu = DanhMucPhieu.CKTCTP.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Tên người đại diện")]
        public string TenNguoiDaiDien { get; set; }
        [MoTaDuLieu("Năm sinh")]
		public string NamSinh { get; set; }
        [MoTaDuLieu("Giới tính")]
        public string Gioitinh { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        [MoTaDuLieu("Điện thoại")]
        public string DienThoai { get; set; }
        public bool[] QuanHeNguoiBenhArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Quan hệ với người bệnh")]
        public int QuanHeNguoiBenh
        {
            get
            {
                return Array.IndexOf(QuanHeNguoiBenhArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) QuanHeNguoiBenhArray[i] = true;
                    else QuanHeNguoiBenhArray[i] = false;
                }
            }
        }
        [MoTaDuLieu("Quan hệ với người bệnh: khác")]
        public string QuanHe_Text { get; set; }
        [MoTaDuLieu("Tình trạng bệnh của")]
        public string TinhTrangBenhCua { get; set; }
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
    public class CamKetTiemChatTuongPhanFunc
    {
        public const string TableName = "CamKetTiemChatTuongPhan";
        public const string TablePrimaryKeyName = "ID";
        public static List<CamKetTiemChatTuongPhan> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<CamKetTiemChatTuongPhan> list = new List<CamKetTiemChatTuongPhan>();
            try
            {
                string sql = @"SELECT * FROM CamKetTiemChatTuongPhan where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    CamKetTiemChatTuongPhan data = new CamKetTiemChatTuongPhan();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.TenNguoiDaiDien = DataReader["TenNguoiDaiDien"].ToString();
                    data.NamSinh = DataReader["NamSinh"].ToString();
                    data.Gioitinh = DataReader["Gioitinh"].ToString();
                    data.DiaChi = DataReader["DiaChi"].ToString();
                    data.DienThoai = DataReader["DienThoai"].ToString();
                   
                    int tempInt = -1;
                    int.TryParse(DataReader["QuanHeNguoiBenh"].ToString(), out tempInt);
                    data.QuanHeNguoiBenh = tempInt;

                    data.QuanHe_Text = DataReader["QuanHe_Text"].ToString();
                    data.TinhTrangBenhCua = DataReader["TinhTrangBenhCua"].ToString();


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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref CamKetTiemChatTuongPhan bangDieuTri)
        {
            try
            {
                string sql = @"INSERT INTO CamKetTiemChatTuongPhan
                (
                    MAQUANLY,
                    MaBenhNhan,
                    TenNguoiDaiDien,
                    NamSinh,
                    Gioitinh,
                    DiaChi,
                    DienThoai,
                    QuanHeNguoiBenh,
                    QuanHe_Text,
                    TinhTrangBenhCua,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :TenNguoiDaiDien,
                    :NamSinh,
                    :Gioitinh,
                    :DiaChi,
                    :DienThoai,
                    :QuanHeNguoiBenh,
                    :QuanHe_Text,
                    :TinhTrangBenhCua,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (bangDieuTri.ID != 0)
                {
                    sql = @"UPDATE CamKetTiemChatTuongPhan SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    TenNguoiDaiDien = :TenNguoiDaiDien,
                    NamSinh = :NamSinh,
                    Gioitinh = :Gioitinh,
                    DiaChi = :DiaChi,
                    DienThoai = :DienThoai,
                    QuanHeNguoiBenh = :QuanHeNguoiBenh,
                    QuanHe_Text = :QuanHe_Text,
                    TinhTrangBenhCua = :TinhTrangBenhCua,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + bangDieuTri.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangDieuTri.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", bangDieuTri.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("TenNguoiDaiDien", bangDieuTri.TenNguoiDaiDien));
                Command.Parameters.Add(new MDB.MDBParameter("NamSinh", bangDieuTri.NamSinh));
                Command.Parameters.Add(new MDB.MDBParameter("Gioitinh", bangDieuTri.Gioitinh));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", bangDieuTri.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("DienThoai", bangDieuTri.DienThoai));
                Command.Parameters.Add(new MDB.MDBParameter("QuanHeNguoiBenh", bangDieuTri.QuanHeNguoiBenh));
                Command.Parameters.Add(new MDB.MDBParameter("QuanHe_Text", bangDieuTri.QuanHe_Text));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangBenhCua", bangDieuTri.TinhTrangBenhCua));
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
                string sql = "DELETE FROM CamKetTiemChatTuongPhan WHERE ID = :ID";
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
                CamKetTiemChatTuongPhan B
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
