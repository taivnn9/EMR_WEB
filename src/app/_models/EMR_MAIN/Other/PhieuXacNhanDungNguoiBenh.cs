using EMR.KyDienTu;
using Newtonsoft.Json;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuXacNhanDungNguoiBenh : ThongTinKy
    {
        public PhieuXacNhanDungNguoiBenh()
        {
            TableName = "PhieuXacNhanDungNguoiBenh";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PXNDNB;
            TenMauPhieu = DanhMucPhieu.PXNDNB.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        public string TruocDVKT { get; set; }
        public string KetQua { get; set; }
        public string TraKQDVKT { get; set; }
        public string MaNVTruocDVKT { get; set; }
        public string NVTruocDVKT { get; set; }
        public string MaNVKetQua { get; set; }
        public string NVKetQua { get; set; }
        public string MaNVTraKQDVKT { get; set; }
        public string NVTraKQDVKT { get; set; }
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
    public class PhieuXacNhanDungNguoiBenhFunc
    {
        public const string TableName = "PhieuXacNhanDungNguoiBenh";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuXacNhanDungNguoiBenh> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuXacNhanDungNguoiBenh> list = new List<PhieuXacNhanDungNguoiBenh>();
            try
            {
                string sql = @"SELECT * FROM PhieuXacNhanDungNguoiBenh where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuXacNhanDungNguoiBenh data = new PhieuXacNhanDungNguoiBenh();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.TruocDVKT = DataReader["TruocDVKT"].ToString();
                    data.KetQua = DataReader["KetQua"].ToString();
                    data.TraKQDVKT = DataReader["TraKQDVKT"].ToString();
                    data.MaNVTruocDVKT = DataReader["MaNVTruocDVKT"].ToString();
                    data.NVTruocDVKT = DataReader["NVTruocDVKT"].ToString();
                    data.MaNVKetQua = DataReader["MaNVKetQua"].ToString();
                    data.NVKetQua = DataReader["NVKetQua"].ToString();
                    data.MaNVTraKQDVKT = DataReader["MaNVTraKQDVKT"].ToString();
                    data.NVTraKQDVKT = DataReader["NVTraKQDVKT"].ToString();
                   
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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuXacNhanDungNguoiBenh bangKe)
        {
            try
            {
                string sql = @"INSERT INTO PhieuXacNhanDungNguoiBenh
                (
                    MAQUANLY,
                    TruocDVKT,
                    KetQua,
                    TraKQDVKT,
                    MaNVTruocDVKT,
                    NVTruocDVKT,
                    MaNVKetQua,
                    NVKetQua,
                    MaNVTraKQDVKT,
                    NVTraKQDVKT,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :TruocDVKT,
                    :KetQua,
                    :TraKQDVKT,
                    :MaNVTruocDVKT,
                    :NVTruocDVKT,
                    :MaNVKetQua,
                    :NVKetQua,
                    :MaNVTraKQDVKT,
                    :NVTraKQDVKT,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (bangKe.ID != 0)
                {
                    sql = @"UPDATE PhieuXacNhanDungNguoiBenh SET 
                    MAQUANLY = :MAQUANLY,
                    TruocDVKT = :TruocDVKT,
                    KetQua = :KetQua,
                    TraKQDVKT = :TraKQDVKT,
                    MaNVTruocDVKT = :MaNVTruocDVKT,
                    NVTruocDVKT = :NVTruocDVKT,
                    MaNVKetQua = :MaNVKetQua,
                    NVKetQua = :NVKetQua,
                    MaNVTraKQDVKT = :MaNVTraKQDVKT,
                    NVTraKQDVKT = :NVTraKQDVKT,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + bangKe.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangKe.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("TruocDVKT", bangKe.TruocDVKT));
                Command.Parameters.Add(new MDB.MDBParameter("KetQua", bangKe.KetQua));
                Command.Parameters.Add(new MDB.MDBParameter("TraKQDVKT", bangKe.TraKQDVKT));
                Command.Parameters.Add(new MDB.MDBParameter("MaNVTruocDVKT", bangKe.MaNVTruocDVKT));
                Command.Parameters.Add(new MDB.MDBParameter("NVTruocDVKT", bangKe.NVTruocDVKT));
                Command.Parameters.Add(new MDB.MDBParameter("MaNVKetQua", bangKe.MaNVKetQua));
                Command.Parameters.Add(new MDB.MDBParameter("NVKetQua", bangKe.NVKetQua));
                Command.Parameters.Add(new MDB.MDBParameter("MaNVTraKQDVKT", bangKe.MaNVTraKQDVKT));
                Command.Parameters.Add(new MDB.MDBParameter("NVTraKQDVKT", bangKe.NVTraKQDVKT));

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", bangKe.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", bangKe.NgaySua));
                if (bangKe.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", bangKe.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", bangKe.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", bangKe.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (bangKe.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    bangKe.ID = nextval;
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
                string sql = "DELETE FROM PhieuXacNhanDungNguoiBenh WHERE ID = :ID";
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
                *
            FROM
                PhieuXacNhanDungNguoiBenh B
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);

            var ds = new DataSet();

            adt.Fill(ds, "TB");

            return ds;

        }
    }
}
