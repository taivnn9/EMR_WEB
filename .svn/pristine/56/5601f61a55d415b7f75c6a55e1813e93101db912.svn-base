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
    public class KetQuaNghiemPhapAtropin : ThongTinKy
    {
        public KetQuaNghiemPhapAtropin()
        {
            TableName = "KetQuaNghiemPhapAtropin";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.KQNPA;
            TenMauPhieu = DanhMucPhieu.KQNPA.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        public string HoTenBenhNhan { get; set; }
        [MoTaDuLieu("Năm sinh")]
		public string NamSinh { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public ObservableCollection<KetQuaNghiemPhapAtropin_ChiTiet> KetQuas { get; set; }
        public string KetLuan { get; set; }
        public string BacSyChiDinh { get; set; }
        public string MaBacSyChiDinh { get; set; }
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
    public class KetQuaNghiemPhapAtropin_ChiTiet
    {
        public string ThoiGian { get; set; }
        public string TTAtropin { get; set; }
        public string STLan1 { get; set; }
        public string ST2Phut { get; set; }
        public string STLan2 { get; set; }
        public string ST3Phut { get; set; }
        public string ST5Phut { get; set; }
        public string ST10Phut { get; set; }
        public string ST15Phut { get; set; }
        public string ST20Phut { get; set; }
        public string ST25Phut { get; set; }
        public string ST30Phut { get; set; }
        public KetQuaNghiemPhapAtropin_ChiTiet Clone(KetQuaNghiemPhapAtropin_ChiTiet obj)
        {
            KetQuaNghiemPhapAtropin_ChiTiet other = (KetQuaNghiemPhapAtropin_ChiTiet)obj.MemberwiseClone();
            return other;
        }
    }
    public class KetQuaNghiemPhapAtropinFunc
    {
        public const string TableName = "KetQuaNghiemPhapAtropin";
        public const string TablePrimaryKeyName = "ID";
        public static List<KetQuaNghiemPhapAtropin> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<KetQuaNghiemPhapAtropin> list = new List<KetQuaNghiemPhapAtropin>();
            try
            {
                string sql = @"SELECT * FROM KetQuaNghiemPhapAtropin where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    KetQuaNghiemPhapAtropin data = new KetQuaNghiemPhapAtropin();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.HoTenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.NamSinh = DataReader["NamSinh"].ToString();
                    data.DiaChi = DataReader["DiaChi"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.KetQuas = JsonConvert.DeserializeObject<ObservableCollection<KetQuaNghiemPhapAtropin_ChiTiet>>(DataReader["KetQuas"].ToString());
                    data.KetLuan = DataReader["KetLuan"].ToString();

                    data.BacSyChiDinh = DataReader["BacSyChiDinh"].ToString();
                    data.MaBacSyChiDinh = DataReader["MaBacSyChiDinh"].ToString();

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref KetQuaNghiemPhapAtropin ketQua)
        {
            try
            {
                string sql = @"INSERT INTO KetQuaNghiemPhapAtropin
                (
                    MAQUANLY,
                    MaBenhNhan,
                    NamSinh,
                    DiaChi,
                    ChanDoan,
                    KetQuas,
                    KetLuan,
                    BacSyChiDinh,
                    MaBacSyChiDinh,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :NamSinh,
                    :DiaChi,
                    :ChanDoan,
                    :KetQuas,
                    :KetLuan,
                    :BacSyChiDinh,
                    :MaBacSyChiDinh,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE KetQuaNghiemPhapAtropin SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    NamSinh = :NamSinh,
                    DiaChi = :DiaChi,
                    ChanDoan = :ChanDoan,
                    KetQuas = :KetQuas,
                    KetLuan = :KetLuan,
                    BacSyChiDinh = :BacSyChiDinh,
                    MaBacSyChiDinh = :MaBacSyChiDinh,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ketQua.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("NamSinh", ketQua.NamSinh));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", ketQua.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", ketQua.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("KetQuas", JsonConvert.SerializeObject(ketQua.KetQuas)));
                Command.Parameters.Add(new MDB.MDBParameter("KetLuan", ketQua.KetLuan));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyChiDinh", ketQua.BacSyChiDinh));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSyChiDinh", ketQua.MaBacSyChiDinh));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));
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
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool delete(MDB.MDBConnection MyConnection, long id)
        {
            try
            {
                string sql = "DELETE FROM KetQuaNghiemPhapAtropin WHERE ID = :ID";
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
                P.* 
            FROM
                KetQuaNghiemPhapAtropin P
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "BK");

            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("SOYTE", typeof(string));
            ds.Tables[0].AddColumn("BENHVIEN", typeof(string));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["SOYTE"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;

            string bangKeJson = ds.Tables[0].Rows[0]["KetQuas"].ToString();
            ObservableCollection<KetQuaNghiemPhapAtropin_ChiTiet> ketQuaSaves = JsonConvert.DeserializeObject<ObservableCollection<KetQuaNghiemPhapAtropin_ChiTiet>>(bangKeJson);

            DataTable ChiTiet = new DataTable("KQ");
            ChiTiet.Columns.Add("ThoiGian");
            ChiTiet.Columns.Add("TTAtropin");
            ChiTiet.Columns.Add("STLan1");
            ChiTiet.Columns.Add("ST2Phut");
            ChiTiet.Columns.Add("STLan2");
            ChiTiet.Columns.Add("ST3Phut");
            ChiTiet.Columns.Add("ST5Phut");
            ChiTiet.Columns.Add("ST10Phut");
            ChiTiet.Columns.Add("ST15Phut");
            ChiTiet.Columns.Add("ST20Phut");
            ChiTiet.Columns.Add("ST25Phut");
            ChiTiet.Columns.Add("ST30Phut");
            foreach (KetQuaNghiemPhapAtropin_ChiTiet chiTiet in ketQuaSaves)
            {
                ChiTiet.Rows.Add(
                    chiTiet.ThoiGian,
                    chiTiet.TTAtropin,
                    chiTiet.STLan1,
                    chiTiet.ST2Phut,
                    chiTiet.STLan2,
                    chiTiet.ST3Phut,
                    chiTiet.ST5Phut,
                    chiTiet.ST10Phut,
                    chiTiet.ST15Phut,
                    chiTiet.ST20Phut,
                    chiTiet.ST25Phut,
                    chiTiet.ST30Phut);
            }

            ds.Tables.Add(ChiTiet);
            return ds;
        }

    }
}
