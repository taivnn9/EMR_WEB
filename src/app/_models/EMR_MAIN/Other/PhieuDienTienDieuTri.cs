
using EMR.KyDienTu;
using Newtonsoft.Json;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuDienTienDieuTri : ThongTinKy
    {
        public PhieuDienTienDieuTri()
        {
            TableName = "PhieuDienTienDieuTri";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PDTDT;
            TenMauPhieu = DanhMucPhieu.PDTDT.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
		
        public ObservableCollection<DienTien> ListKetQua { get; set; }

        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        //public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
    }

    public class DienTien
    {
        public DateTime? NgayGio { get; set; }
        public string M { get; set; }
        public string HA { get; set; }
        public string CVP { get; set; }
        public string NuocTieu { get; set; }
        public string Khac { get; set; }
        public string DieuTri { get; set; }
    }
    public class PhieuDienTienDieuTriFunc
    {
        public const string TableName = "PhieuDienTienDieuTri";
        public const string TablePrimaryKeyName = "ID";

        public static List<PhieuDienTienDieuTri> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuDienTienDieuTri> list = new List<PhieuDienTienDieuTri>();
            try
            {
                string sql = @"SELECT * FROM PhieuDienTienDieuTri where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuDienTienDieuTri data = new PhieuDienTienDieuTri();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;

                    data.MaBenhNhan = XemBenhAn._HanhChinhBenhNhan.MaBenhNhan;
                    
                    data.ListKetQua = JsonConvert.DeserializeObject<ObservableCollection<DienTien>>(DataReader["ListKetQua"].ToString());

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
        public static bool DeleteByIDPhieu(MDB.MDBConnection oracleConnection, decimal IDBienBan)
        {
            try
            {
                string sql = "";
                MDB.MDBCommand oracleCommand;
                sql = @"DELETE FROM PhieuDienTienDieuTri WHERE ID =" + IDBienBan;
                using (oracleCommand = new MDB.MDBCommand(sql, oracleConnection))
                {
                    oracleCommand.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                XuLyLoi.LogError(ex);
            }
            return false;
        }
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, long IDBienBan)
        {
            string sql = @"SELECT
                P.* 
            FROM
                PhieuDienTienDieuTri P
            WHERE
                ID = " + IDBienBan;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "TB");


            DataTable KS = new DataTable("KQ");
            KS.Columns.Add("NgayGio", typeof(string));

            KS.Columns.Add("M", typeof(string));
            KS.Columns.Add("HA", typeof(string));

            KS.Columns.Add("CVP", typeof(string));
            KS.Columns.Add("NuocTieu", typeof(string));

            KS.Columns.Add("Khac", typeof(string));
            KS.Columns.Add("DieuTri", typeof(string));

            ObservableCollection<DienTien> ListKetQua = JsonConvert.DeserializeObject<ObservableCollection<DienTien>>(ds.Tables[0].Rows[0]["ListKetQua"].ToString());
            if (ListKetQua != null)
            {
                foreach (DienTien KetQua in ListKetQua)
                {
                    KS.Rows.Add(KetQua.NgayGio, KetQua.M, KetQua.HA, KetQua.CVP, KetQua.NuocTieu, KetQua.Khac, KetQua.DieuTri);
                }
            }
            ds.Tables.Add(KS);

            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuDienTienDieuTri ketQua)
        {
            try
            {
                string sql = @"INSERT INTO PhieuDienTienDieuTri
                (
                    MaQuanLy,
                    ListKetQua,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
                    :ListKetQua,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE PhieuDienTienDieuTri SET 
                    MaQuanLy = :MaQuanLy,
                    ListKetQua = :ListKetQua,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", ketQua.MaQuanLy));

                Command.Parameters.Add(new MDB.MDBParameter("ListKetQua", JsonConvert.SerializeObject(ketQua.ListKetQua)));

                if (ketQua.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", ketQua.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", ketQua.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", ketQua.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (ketQua.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    ketQua.ID = nextval;
                }
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.LogError(ex);
            }
            return false;
        }
    }
}
