using EMR.KyDienTu;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
   
    public class GiayCamKetDongYChiTraKhoanChenhLech : ThongTinKy
    {
        public GiayCamKetDongYChiTraKhoanChenhLech()
        {
            TableName = "GiayCamKetDYCTKCL";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.GCKDYCTKCL;
            TenMauPhieu = DanhMucPhieu.GCKDYCTKCL.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        public string HoTenThanNhan { get; set; }
        public string QuanHeThanNhan { get; set; }
        public DateTime ThoiGian { get; set; }
        public string MaNguoiKy { get; set; }
        public string NguoiKy { get; set; }
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
   
    public class GiayCamKetDongYChiTraKhoanChenhLechFunc
    {
        public const string TableName = "GiayCamKetDYCTKCL";
        public const string TablePrimaryKeyName = "ID";
        public static List<GiayCamKetDongYChiTraKhoanChenhLech> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<GiayCamKetDongYChiTraKhoanChenhLech> list = new List<GiayCamKetDongYChiTraKhoanChenhLech>();
            try
            {
                string sql = @"SELECT * FROM GiayCamKetDYCTKCL where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    GiayCamKetDongYChiTraKhoanChenhLech data = new GiayCamKetDongYChiTraKhoanChenhLech();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.HoTenThanNhan = DataReader["HoTenThanNhan"].ToString();
                    data.QuanHeThanNhan = DataReader["QuanHeThanNhan"].ToString();
                    data.ThoiGian = Convert.ToDateTime(DataReader["ThoiGian"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);
                    data.MaNguoiKy = DataReader["MaNguoiKy"].ToString();
                    data.NguoiKy = DataReader["NguoiKy"].ToString();
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
        
        //using CLOUD DB
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref GiayCamKetDongYChiTraKhoanChenhLech giayCamKet)
        {
            try
            {
                string sql = @"INSERT INTO GiayCamKetDYCTKCL
                (
                    MAQUANLY,
                    MaBenhNhan,
                    HoTenThanNhan,
                    QuanHeThanNhan,
                    ThoiGian,
                    MaNguoiKy,
                    NguoiKy,
                    NguoiTao,
                    NguoiSua,
                    NgayTao,
                    NgaySua)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :HoTenThanNhan,
                    :QuanHeThanNhan,
                    :ThoiGian,
                    :MaNguoiKy,
                    :NguoiKy,
                    :NguoiTao,
                    :NguoiSua,
                    :NgayTao,
                    :NgaySua
                 )  RETURNING ID INTO :ID";
                if (giayCamKet.ID != 0)
                {
                    sql = @"UPDATE GiayCamKetDYCTKCL SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    HoTenThanNhan = :HoTenThanNhan,
                    QuanHeThanNhan = :QuanHeThanNhan,
                    ThoiGian = :ThoiGian,
                    MaNguoiKy = :MaNguoiKy,
                    NguoiKy = :NguoiKy,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + giayCamKet.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", giayCamKet.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", giayCamKet.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("HoTenThanNhan", giayCamKet.HoTenThanNhan));
                Command.Parameters.Add(new MDB.MDBParameter("QuanHeThanNhan", giayCamKet.QuanHeThanNhan));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGian", giayCamKet.ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiKy", giayCamKet.MaNguoiKy));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiKy", giayCamKet.NguoiKy));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiSua", giayCamKet.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NgaySua", giayCamKet.NgaySua));
                if (giayCamKet.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", giayCamKet.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", giayCamKet.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", giayCamKet.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (giayCamKet.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    giayCamKet.ID = nextval;
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
                string sql = "DELETE FROM GiayCamKetDYCTKCL WHERE ID = :ID";
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
                T.MABENHAN,
                H.GIOITINH,
	            H.TENBENHNHAN,
                H.Tuoi,
                H.SOYTE,
                H.BENHVIEN,
                (H.SONHA || '' || H.THONPHO || '' ||  H.XAPHUONG || ',' ||  H.HUYENQUAN || ',' ||  H.TINHTHANHPHO) AS DIACHI
            FROM
                GiayCamKetDYCTKCL B
                LEFT JOIN THONGTINDIEUTRI T ON B.MAQUANLY = T.MAQUANLY
                LEFT JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "GCK");
            return ds;
        }

    }
}
