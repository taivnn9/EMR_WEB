
using EMR.KyDienTu;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuGuiMauXetNghiemHIV : ThongTinKy
    {
        public PhieuGuiMauXetNghiemHIV()
        {
            TableName = "PhieuGuiMauXetNghiemHIV";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PGMXNHIV;
            TenMauPhieu = DanhMucPhieu.PGMXNHIV.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        public DateTime? NgayGiaoMau { get; set; }
        public DateTime? NgayNhanMau { get; set; }
      
        public string MaNguoiGiaoMau { get; set; }
        public string MaNguoiNhanMau { get; set; }
        public string NguoiGiaoMau { get; set; }
        public string NguoiNhanMau { get; set; }
        public string KinhGui { get; set; }

        public ObservableCollection<MauXetNghiemHIV> ListKetQua { get; set; }

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

    public class MauXetNghiemHIV
    {
        public string STT { get; set; }
        public string HoTen { get; set; }
        public string NamSinh_Nam { get; set; }
        public string NamSinh_Nu { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        public string DoiTuong { get; set; }
        public string NgayLamMau { get; set; }
        public string KetQuaXN { get; set; }
        public string ChatLuongMau { get; set; }
        public string MaSoPXN { get; set; }
        [MoTaDuLieu("Ghi chú")]
		public string GhiChu { get; set; }

    }
    public class PhieuGuiMauXetNghiemHIVFunc
    {
        public const string TableName = "PhieuGuiMauXetNghiemHIV";
        public const string TablePrimaryKeyName = "ID";

        public static List<PhieuGuiMauXetNghiemHIV> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuGuiMauXetNghiemHIV> list = new List<PhieuGuiMauXetNghiemHIV>();
            try
            {
                string sql = @"SELECT * FROM PhieuGuiMauXetNghiemHIV where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuGuiMauXetNghiemHIV data = new PhieuGuiMauXetNghiemHIV();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;

                    data.MaBenhNhan = XemBenhAn._HanhChinhBenhNhan.MaBenhNhan;
                    data.NguoiGiaoMau = DataReader["NguoiGiaoMau"].ToString();
                    data.NguoiNhanMau = DataReader["NguoiNhanMau"].ToString();
                    data.MaNguoiGiaoMau = DataReader["MaNguoiGiaoMau"].ToString();
                    data.MaNguoiNhanMau = DataReader["MaNguoiNhanMau"].ToString();
                    data.KinhGui = DataReader["KinhGui"].ToString();
                    
                    data.NgayGiaoMau = Convert.ToDateTime(DataReader["NgayGiaoMau"] == DBNull.Value ? DateTime.Now : DataReader["NgayGiaoMau"]);
                    data.NgayNhanMau = Convert.ToDateTime(DataReader["NgayNhanMau"] == DBNull.Value ? DateTime.Now : DataReader["NgayNhanMau"]);
                    data.ListKetQua = JsonConvert.DeserializeObject<ObservableCollection<MauXetNghiemHIV>>(DataReader["ListKetQua"].ToString());

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
                sql = @"DELETE FROM PhieuGuiMauXetNghiemHIV WHERE ID =" + IDBienBan;
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
                PhieuGuiMauXetNghiemHIV P
            WHERE
                ID = " + IDBienBan;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "TB");
            ObservableCollection<MauXetNghiemHIV> ListKetQua = JsonConvert.DeserializeObject<ObservableCollection<MauXetNghiemHIV>>(ds.Tables[0].Rows[0]["ListKetQua"].ToString());

            DataTable KS = Common.ListToDataTable(ListKetQua, "KQ");
            
            ds.Tables.Add(KS);

            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuGuiMauXetNghiemHIV ketQua)
        {
            try
            {
                string sql = @"INSERT INTO PhieuGuiMauXetNghiemHIV
                (
                    MaQuanLy,
                    KinhGui,
                    NgayGiaoMau,
                    NgayNhanMau,
                    ListKetQua,
                    NguoiGiaoMau,
                    NguoiNhanMau,
                    MaNguoiGiaoMau,
                    MaNguoiNhanMau,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
                    :KinhGui,
                    :NgayGiaoMau,
                    :NgayNhanMau,
                    :ListKetQua,
                    :NguoiGiaoMau,
                    :NguoiNhanMau,
                    :MaNguoiGiaoMau,
                    :MaNguoiNhanMau,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE PhieuGuiMauXetNghiemHIV SET 
                    MaQuanLy = :MaQuanLy,
                    KinhGui = :KinhGui,
                    NgayGiaoMau = :NgayGiaoMau,
                    NgayNhanMau = :NgayNhanMau,
                    ListKetQua = :ListKetQua,
                    NguoiGiaoMau = :NguoiGiaoMau,
                    NguoiNhanMau = :NguoiNhanMau,
                    MaNguoiGiaoMau = :MaNguoiGiaoMau,
                    MaNguoiNhanMau = :MaNguoiNhanMau,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", ketQua.MaQuanLy));

                Command.Parameters.Add(new MDB.MDBParameter("KinhGui", ketQua.KinhGui));
                Command.Parameters.Add(new MDB.MDBParameter("NgayGiaoMau", ketQua.NgayGiaoMau));
                Command.Parameters.Add(new MDB.MDBParameter("NgayNhanMau", ketQua.NgayNhanMau));
                Command.Parameters.Add(new MDB.MDBParameter("ListKetQua", JsonConvert.SerializeObject(ketQua.ListKetQua)));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiGiaoMau", ketQua.NguoiGiaoMau));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiGiaoMau", ketQua.MaNguoiGiaoMau));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanMau", ketQua.NguoiNhanMau));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiNhanMau", ketQua.MaNguoiNhanMau));

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
