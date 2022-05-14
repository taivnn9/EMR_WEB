using System;
using System.Collections.Generic;
using System.Data;
using EMR.KyDienTu;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class GiayXacNhanBanGiaoTre : ThongTinKy
    {
        public GiayXacNhanBanGiaoTre()
        {
            TableName = "GiayXacNhanBanGiaoTre";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.GXNBGT;
            TenMauPhieu = DanhMucPhieu.GXNBGT.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long Id { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }
        public string SoDayMeCon { get; set; }
        public string NguoiNhanTre { get; set; }
        public string MoiQuanHe { get; set; }
        public DateTime NgaySinhTre { get; set; }
        public DateTime GioSinhTre { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinhTre { get; set; }
        public string CanNangTre { get; set; }
        public bool[] TinhTrangArray { get; } = new bool[] { false, false, false };
        public string TinhTrang
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TinhTrangArray.Length; i++)
                    temp += (TinhTrangArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TinhTrangArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string NguoiGhiPhieu { get; set; }
        public string MaNguoiGhiPhieu { get; set; }
        public string NguoiBanGiaoTre { get; set; }
        public string MaNguoiBanGiaoTre { get; set; }
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
    public class GiayXacNhanBanGiaoTreFunc
    {

        public const string TableName = "GiayXacNhanBanGiaoTre";
        public const string TablePrimaryKeyName = "ID";
        public static List<GiayXacNhanBanGiaoTre> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<GiayXacNhanBanGiaoTre> list = new List<GiayXacNhanBanGiaoTre>();
            try
            {
                string sql = @"SELECT * FROM GiayXacNhanBanGiaoTre where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    GiayXacNhanBanGiaoTre data = new GiayXacNhanBanGiaoTre();
                    data.Id = DataReader.GetLong("Id");
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.Khoa = DataReader["Khoa"].ToString();
                    data.MaKhoa = DataReader["MaKhoa"].ToString();
                    data.SoDayMeCon = DataReader["SoDayMeCon"].ToString();
                    data.NguoiNhanTre = DataReader["NguoiNhanTre"].ToString();
                    data.MoiQuanHe = DataReader["MoiQuanHe"].ToString();
                    data.NgaySinhTre = Convert.ToDateTime(DataReader["NgaySinhTre"] == DBNull.Value ? DateTime.Now : DataReader["NgaySinhTre"]);
                    data.GioiTinhTre = DataReader["GioiTinhTre"].ToString();
                    data.CanNangTre = DataReader["CanNangTre"].ToString();
                    data.TinhTrang = DataReader["TinhTrang"].ToString();
                    data.NguoiGhiPhieu = DataReader["NguoiGhiPhieu"].ToString();
                    data.MaNguoiGhiPhieu = DataReader["MaNguoiGhiPhieu"].ToString();
                    data.NguoiBanGiaoTre = DataReader["NguoiBanGiaoTre"].ToString();
                    data.MaNguoiBanGiaoTre = DataReader["MaNguoiBanGiaoTre"].ToString();

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref GiayXacNhanBanGiaoTre giayBanGiao)
        {
            try
            {
                string sql = @"INSERT INTO GiayXacNhanBanGiaoTre
                (
                    MAQUANLY,
                    MaBenhNhan,
                    Khoa,
                    MaKhoa,
                    SoDayMeCon,
                    NguoiNhanTre,
                    MoiQuanHe,
                    NgaySinhTre,
                    GioiTinhTre,
                    CanNangTre,
                    TinhTrang,
                    NguoiGhiPhieu,
                    MaNguoiGhiPhieu,
                    NguoiBanGiaoTre,
                    MaNguoiBanGiaoTre,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :Khoa,
                    :MaKhoa,
                    :SoDayMeCon,
                    :NguoiNhanTre,
                    :MoiQuanHe,
                    :NgaySinhTre,
                    :GioiTinhTre,
                    :CanNangTre,
                    :TinhTrang,
                    :NguoiGhiPhieu,
                    :MaNguoiGhiPhieu,
                    :NguoiBanGiaoTre,
                    :MaNguoiBanGiaoTre,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (giayBanGiao.Id != 0)
                {
                    sql = @"UPDATE GiayXacNhanBanGiaoTre SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    Khoa = :Khoa,
                    MaKhoa = :MaKhoa,
                    SoDayMeCon = :SoDayMeCon,
                    NguoiNhanTre = :NguoiNhanTre,
                    MoiQuanHe = :MoiQuanHe,
                    NgaySinhTre = :NgaySinhTre,
                    GioiTinhTre = :GioiTinhTre,
                    CanNangTre = :CanNangTre,
                    TinhTrang = :TinhTrang,
                    NguoiGhiPhieu = :NguoiGhiPhieu,
                    MaNguoiGhiPhieu = :MaNguoiGhiPhieu,
                    NguoiBanGiaoTre = :NguoiBanGiaoTre,
                    MaNguoiBanGiaoTre = :MaNguoiBanGiaoTre,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + giayBanGiao.Id;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", giayBanGiao.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", giayBanGiao.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa", giayBanGiao.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaKhoa", giayBanGiao.MaKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("SoDayMeCon", giayBanGiao.SoDayMeCon));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanTre", giayBanGiao.NguoiNhanTre));
                Command.Parameters.Add(new MDB.MDBParameter("MoiQuanHe", giayBanGiao.MoiQuanHe));
                var Ngay = giayBanGiao.NgaySinhTre.Date.Add(new TimeSpan(0, 0, 0));
                var Gio = giayBanGiao.GioSinhTre != null ? giayBanGiao.GioSinhTre.TimeOfDay : DateTime.Now.TimeOfDay;
                var NgaySinhTre = Ngay + Gio;
                Command.Parameters.Add(new MDB.MDBParameter("NgaySinhTre", NgaySinhTre));
                Command.Parameters.Add(new MDB.MDBParameter("GioiTinhTre", giayBanGiao.GioiTinhTre));
                Command.Parameters.Add(new MDB.MDBParameter("CanNangTre", giayBanGiao.CanNangTre));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrang", giayBanGiao.TinhTrang));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiGhiPhieu", giayBanGiao.NguoiGhiPhieu));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiGhiPhieu", giayBanGiao.MaNguoiGhiPhieu));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiBanGiaoTre", giayBanGiao.NguoiBanGiaoTre));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiBanGiaoTre", giayBanGiao.MaNguoiBanGiaoTre));

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", giayBanGiao.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", giayBanGiao.NgaySua));
                if (giayBanGiao.Id == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", giayBanGiao.Id));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", giayBanGiao.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", giayBanGiao.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (giayBanGiao.Id == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    giayBanGiao.Id = nextval;
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
                string sql = "DELETE FROM GiayXacNhanBanGiaoTre WHERE ID = :ID";
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
                T.KHOA,
                T.MABENHAN,
                H.NGAYSINH,
	            H.TENBENHNHAN,
                H.BENHVIEN,
                (H.SONHA || ',' || H.THONPHO || ',' ||  H.XAPHUONG || ',' ||  H.HUYENQUAN || ',' ||  H.TINHTHANHPHO) AS DIACHI 
            FROM
                GiayXacNhanBanGiaoTre B
                LEFT JOIN THONGTINDIEUTRI T ON B.MAQUANLY = T.MAQUANLY
                LEFT JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
            WHERE
                B.ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            adt.Fill(ds, "BM");

            return ds;
        }
    }
}
