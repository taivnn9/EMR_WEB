
using EMR.KyDienTu;
using Newtonsoft.Json;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuTDBNTruyenILOMEDIN : ThongTinKy
    {
        public PhieuTDBNTruyenILOMEDIN()
        {
            TableName = "PhieuTDBNTruyenILOMEDIN";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PTDBNTI;
            TenMauPhieu = DanhMucPhieu.PTDBNTI.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
		[MoTaDuLieu("Sở Y Tế")]
		public string SoYTe { get; set; }
        [MoTaDuLieu("Bệnh viện")]
		public string BenhVien { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Cân nặng")]
		public string CanNang { get; set; }
        public string Lieu { get; set; }
        public DateTime? NgayTruyen { get; set; }
      
        public string MaNguoiTheoDoi { get; set; }
        public string NguoiTheoDoi { get; set; }
        public ObservableCollection<TheoDoiTruyenILOMEDIN> ListTheoDoi { get; set; }

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

    public class TheoDoiTruyenILOMEDIN
    {
        public string STT { get; set; }
        public string Gio { get; set; }
        public string Lieu { get; set; }
        public string TocDo { get; set; }
        [MoTaDuLieu("Mạch")]
		public string Mach { get; set; }
        [MoTaDuLieu("Huyết áp")]
		public string HuyetAp { get; set; }
        public string TacDungPhu { get; set; }

    }
    public class PhieuTDBNTruyenILOMEDINFunc
    {
        public const string TableName = "PhieuTDBNTruyenILOMEDIN";
        public const string TablePrimaryKeyName = "ID";

        public static List<PhieuTDBNTruyenILOMEDIN> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuTDBNTruyenILOMEDIN> list = new List<PhieuTDBNTruyenILOMEDIN>();
            try
            {
                string sql = @"SELECT * FROM PhieuTDBNTruyenILOMEDIN where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuTDBNTruyenILOMEDIN data = new PhieuTDBNTruyenILOMEDIN();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;

                    data.MaBenhNhan = XemBenhAn._HanhChinhBenhNhan.MaBenhNhan;
                    data.TenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.SoYTe = XemBenhAn._HanhChinhBenhNhan.SoYTe;
                    data.BenhVien = XemBenhAn._HanhChinhBenhNhan.BenhVien;

                    data.CanNang = DataReader["CanNang"].ToString();
                    data.Lieu = DataReader["Lieu"].ToString();
                    data.NguoiTheoDoi = DataReader["NguoiTheoDoi"].ToString();
                    data.MaNguoiTheoDoi = DataReader["MaNguoiTheoDoi"].ToString();
                    
                    data.NgayTruyen = Convert.ToDateTime(DataReader["NgayTruyen"] == DBNull.Value ? DateTime.Now : DataReader["NgayTruyen"]);
                    data.ListTheoDoi = JsonConvert.DeserializeObject<ObservableCollection<TheoDoiTruyenILOMEDIN>>(DataReader["ListTheoDoi"].ToString());

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
                sql = @"DELETE FROM PhieuTDBNTruyenILOMEDIN WHERE ID =" + IDBienBan;
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
                PhieuTDBNTruyenILOMEDIN P
            WHERE
                ID = " + IDBienBan;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "TB");

            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ObservableCollection<TheoDoiTruyenILOMEDIN> ListTheoDoi = JsonConvert.DeserializeObject<ObservableCollection<TheoDoiTruyenILOMEDIN>>(ds.Tables[0].Rows[0]["ListTheoDoi"].ToString());
            DataTable TD = Common.ListToDataTable(ListTheoDoi, "TD");
            ds.Tables.Add(TD);

            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuTDBNTruyenILOMEDIN ketQua)
        {
            try
            {
                string sql = @"INSERT INTO PhieuTDBNTruyenILOMEDIN
                (
                    MaQuanLy,
                    CanNang,
                    Lieu,
                    NgayTruyen,
                    ListTheoDoi,
                    NguoiTheoDoi,
                    MaNguoiTheoDoi,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
                    :CanNang,
                    :Lieu,
                    :NgayTruyen,
                    :ListTheoDoi,
                    :NguoiTheoDoi,
                    :MaNguoiTheoDoi,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE PhieuTDBNTruyenILOMEDIN SET 
                    MaQuanLy = :MaQuanLy,
                    CanNang = :CanNang,
                    Lieu = :Lieu,
                    NgayTruyen = :NgayTruyen,
                    ListTheoDoi = :ListTheoDoi,
                    NguoiTheoDoi = :NguoiTheoDoi,
                    MaNguoiTheoDoi = :MaNguoiTheoDoi,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", ketQua.MaQuanLy));

                Command.Parameters.Add(new MDB.MDBParameter("CanNang", ketQua.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("Lieu", ketQua.Lieu));
                Command.Parameters.Add(new MDB.MDBParameter("NgayTruyen", ketQua.NgayTruyen));
                Command.Parameters.Add(new MDB.MDBParameter("ListTheoDoi", JsonConvert.SerializeObject(ketQua.ListTheoDoi)));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiTheoDoi", ketQua.NguoiTheoDoi));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiTheoDoi", ketQua.MaNguoiTheoDoi));

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
