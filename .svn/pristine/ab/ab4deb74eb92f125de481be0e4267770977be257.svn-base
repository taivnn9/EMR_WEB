
using EMR.KyDienTu;
using Newtonsoft.Json;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class KQTLTracNghiemRaven : ThongTinKy
    {
        public KQTLTracNghiemRaven()
        {
            TableName = "KQTLTracNghiemRaven";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.KQTLTNRV;
            TenMauPhieu = DanhMucPhieu.KQTLTNRV.Description();
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
        [MoTaDuLieu("Năm sinh")]
		public string NamSinh { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        public DateTime? NgayLamTest { get; set; }
      
        public string MaNguoiLamTest { get; set; }
        public string NguoiLamTest { get; set; }
        public string TongDiem { get; set; }
        public string Diem { get; set; }
        public string IQ { get; set; }

        public ObservableCollection<KetQuaTracNghiem> ListKetQua { get; set; }

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

    public class KetQuaTracNghiem
    {
        public string STT { get; set; }
        public string TraLoi_A { get; set; }
        public string TraLoi_B { get; set; }
        public string TraLoi_C { get; set; }
        public string TraLoi_D { get; set; }
        public string TraLoi_E { get; set; }
        public string Diem_A { get; set; }
        public string Diem_B { get; set; }
        public string Diem_C { get; set; }
        public string Diem_D { get; set; }
        public string Diem_E { get; set; }

    }
    public class KQTLTracNghiemRavenFunc
    {
        public const string TableName = "KQTLTracNghiemRaven";
        public const string TablePrimaryKeyName = "ID";

        public static List<KQTLTracNghiemRaven> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<KQTLTracNghiemRaven> list = new List<KQTLTracNghiemRaven>();
            try
            {
                string sql = @"SELECT * FROM KQTLTracNghiemRaven where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    KQTLTracNghiemRaven data = new KQTLTracNghiemRaven();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;

                    data.MaBenhNhan = XemBenhAn._HanhChinhBenhNhan.MaBenhNhan;
                    data.TenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.NamSinh = XemBenhAn._HanhChinhBenhNhan.NgaySinh?.Year.ToString();
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.SoYTe = XemBenhAn._HanhChinhBenhNhan.SoYTe;
                    data.BenhVien = XemBenhAn._HanhChinhBenhNhan.BenhVien;

                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.DiaChi = DataReader["DiaChi"].ToString();
                    data.NguoiLamTest = DataReader["NguoiLamTest"].ToString();
                    data.MaNguoiLamTest = DataReader["MaNguoiLamTest"].ToString();
                    data.TongDiem = DataReader["TongDiem"].ToString();
                    data.Diem = DataReader["Diem"].ToString();
                    data.IQ = DataReader["IQ"].ToString();
                    
                    data.NgayLamTest = Convert.ToDateTime(DataReader["NgayLamTest"] == DBNull.Value ? DateTime.Now : DataReader["NgayLamTest"]);
                    data.ListKetQua = JsonConvert.DeserializeObject<ObservableCollection<KetQuaTracNghiem>>(DataReader["ListKetQua"].ToString());

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
                sql = @"DELETE FROM KQTLTracNghiemRaven WHERE ID =" + IDBienBan;
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
                KQTLTracNghiemRaven P
            WHERE
                ID = " + IDBienBan;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "TB");

            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("NamSinh", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(string));
            ds.Tables[0].AddColumn("SoYTe", typeof(string));
            ds.Tables[0].AddColumn("BenhVien", typeof(string));
            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["NamSinh"] = XemBenhAn._HanhChinhBenhNhan.NgaySinh.HasValue ? XemBenhAn._HanhChinhBenhNhan.NgaySinh.Value.Year + "" : "";
            ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            ds.Tables[0].Rows[0]["SoYTe"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BenhVien"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;

            DataTable KS = new DataTable("KQ");
            KS.Columns.Add("STT", typeof(string));

            KS.Columns.Add("TraLoi_A", typeof(string));
            KS.Columns.Add("Diem_A", typeof(string));

            KS.Columns.Add("TraLoi_B", typeof(string));
            KS.Columns.Add("Diem_B", typeof(string));

            KS.Columns.Add("TraLoi_C", typeof(string));
            KS.Columns.Add("Diem_C", typeof(string));

            KS.Columns.Add("TraLoi_D", typeof(string));
            KS.Columns.Add("Diem_D", typeof(string));

            KS.Columns.Add("TraLoi_E", typeof(string));
            KS.Columns.Add("Diem_E", typeof(string));
           
            ObservableCollection<KetQuaTracNghiem> ListKetQua = JsonConvert.DeserializeObject<ObservableCollection<KetQuaTracNghiem>>(ds.Tables[0].Rows[0]["ListKetQua"].ToString());
            if (ListKetQua != null)
            {
                foreach (KetQuaTracNghiem KetQua in ListKetQua)
                {
                    KS.Rows.Add(KetQua.STT, KetQua.TraLoi_A, KetQua.Diem_A, KetQua.TraLoi_B, KetQua.Diem_B, KetQua.TraLoi_C, KetQua.Diem_C, KetQua.TraLoi_D, KetQua.Diem_D, KetQua.TraLoi_E, KetQua.Diem_E);
                }
            }
            ds.Tables.Add(KS);

            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref KQTLTracNghiemRaven ketQua)
        {
            try
            {
                string sql = @"INSERT INTO KQTLTracNghiemRaven
                (
                    MaQuanLy,
                    ChanDoan,
                    DiaChi,
                    NgayLamTest,
                    ListKetQua,
                    TongDiem,
                    Diem,
                    IQ,
                    NguoiLamTest,
                    MaNguoiLamTest,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
                    :ChanDoan,
                    :DiaChi,
                    :NgayLamTest,
                    :ListKetQua,
                    :TongDiem,
                    :Diem,
                    :IQ,
                    :NguoiLamTest,
                    :MaNguoiLamTest,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE KQTLTracNghiemRaven SET 
                    MaQuanLy = :MaQuanLy,
                    ChanDoan = :ChanDoan,
                    DiaChi = :DiaChi,
                    NgayLamTest = :NgayLamTest,
                    ListKetQua = :ListKetQua,
                    TongDiem = :TongDiem,
                    Diem = :Diem,
                    IQ = :IQ,
                    NguoiLamTest = :NguoiLamTest,
                    MaNguoiLamTest = :MaNguoiLamTest,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", ketQua.MaQuanLy));

                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", ketQua.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", ketQua.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("NgayLamTest", ketQua.NgayLamTest));
                Command.Parameters.Add(new MDB.MDBParameter("ListKetQua", JsonConvert.SerializeObject(ketQua.ListKetQua)));
                Command.Parameters.Add(new MDB.MDBParameter("TongDiem", ketQua.TongDiem));
                Command.Parameters.Add(new MDB.MDBParameter("Diem", ketQua.Diem));
                Command.Parameters.Add(new MDB.MDBParameter("IQ", ketQua.IQ));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiLamTest", ketQua.NguoiLamTest));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiLamTest", ketQua.MaNguoiLamTest));

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
       
        public static string ConDBNull(object dbVal)
        {
            string ret = "";
            if (dbVal == null)
            {
                return ret;
            }
            ret = dbVal.ToString();
            return ret;
        }
        public static decimal ConDB_Decimal(object dbVal, decimal valDefault = 0)
        {
            decimal ret = valDefault;
            if (dbVal == null)
            {
                return ret;
            }
            bool isSuccess = decimal.TryParse(dbVal.ToString(), out ret);
            if (!isSuccess)
            {
                return valDefault;
            }
            return ret;
        }
        public static int ConDB_Int(object dbVal, int valDefault = 0)
        {
            int ret = valDefault;
            if (dbVal == null)
            {
                return ret;
            }
            bool isSuccess = int.TryParse(dbVal.ToString(), out ret);
            if (!isSuccess)
            {
                return valDefault;
            }
            return ret;
        }
        public static DateTime ConDB_DateTime(object dbVal)
        {
            DateTime ret = DateTime.MinValue;
            if (dbVal == null)
            {
                return ret;
            }
            bool isSuccess = DateTime.TryParse(dbVal.ToString(), out ret);
            return ret;
        }
    }
}
