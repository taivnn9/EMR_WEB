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
    public class ChiTietLocMau1
    {
        [MoTaDuLieu("Giờ")]
        public DateTime? Gio { get; set; }
        [MoTaDuLieu("NaCl 0.9%")]
        public string Nacl { get; set; }
        [MoTaDuLieu("Dịch thay thế")]
        public string DichThayThe { get; set; }
        [MoTaDuLieu("Kali")]
        public string Kali { get; set; }
        [MoTaDuLieu("Heparin")]
        public string Heparin { get; set; }
        [MoTaDuLieu("Thay quả")]
        public string ThayQua { get; set; }
        [MoTaDuLieu("Bác sỹ")]
        public string BS { get; set; }
        [MoTaDuLieu("Tên bác sỹ")]
        public string TenBS { get; set; }
        [MoTaDuLieu("Điều dưỡng")]
        public string DD { get; set; }
        [MoTaDuLieu("Tên điều dưỡng")]
        public string TenDD { get; set; }
    }
    public class ChiTietLocMau2
    {
        [MoTaDuLieu("Ngày/Giờ")]
        public DateTime? Gio { get; set; }
        [MoTaDuLieu("Mạch/SpO2")]
        public string MachSpo2 { get; set; }
        [MoTaDuLieu("Huyết áp")]
		public string HA { get; set; }
        [MoTaDuLieu("Blood")]
        public string Blood { get; set; }
        [MoTaDuLieu("Dịch thay thế")]
        public string DichThayThe { get; set; }
        [MoTaDuLieu("Dialyat %")]
        public string Dialyat { get; set; }
        [MoTaDuLieu("UF")]
        public string UF { get; set; }
        [MoTaDuLieu("Heparin")]
        public string Heparin { get; set; }
        [MoTaDuLieu("Access")]
        public string Access { get; set; }
        [MoTaDuLieu("Filter")]
        public string Filter { get; set; }
        [MoTaDuLieu("TMP")]
        public string TMP { get; set; }
        [MoTaDuLieu("Return")]
        public string Return { get; set; }
    }
    public class BangTheoDoiLocMau2 : ThongTinKy
    {
        public BangTheoDoiLocMau2()
        {
            TableName = "BangTheoDoiLocMau2";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BTDLM2;
            TenMauPhieu = DanhMucPhieu.BTDLM2.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")] 
        public string HoTenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giường")]
		public string Giuong { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public bool[] KiThuatArray { get; } = new bool[] { false, false,false, false };
        [MoTaDuLieu("Kỹ thuật")]
        public int KiThuat
        {
            get
            {
                return Array.IndexOf(KiThuatArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < KiThuatArray.Length; i++)
                {
                    if (i == (value - 1)) KiThuatArray[i] = true;
                    else KiThuatArray[i] = false;
                }
            }
        }
        [MoTaDuLieu("Ngày thực hiện")]
        public DateTime NgayThucHien { get; set; }
        [MoTaDuLieu("Bảng kê chi tiết lọc máu 1")]
        public ObservableCollection<ChiTietLocMau1> BangKe1 { get; set; }
        [MoTaDuLieu("Bảng kê chi tiết lọc máu 2")]
        public ObservableCollection<ChiTietLocMau2> BangKe2 { get; set; }
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
    public class BangTheoDoiLocMau2Func
    {
        public const string TableName = "BangTheoDoiLocMau2";
        public const string TablePrimaryKeyName = "ID";
        public static List<BangTheoDoiLocMau2> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BangTheoDoiLocMau2> list = new List<BangTheoDoiLocMau2>();
            try
            {
                string sql = @"SELECT * FROM BangTheoDoiLocMau2 where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    BangTheoDoiLocMau2 data = new BangTheoDoiLocMau2();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.HoTenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.Giuong = XemBenhAn._ThongTinDieuTri.Giuong;
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.KiThuat = DataReader.GetInt("KiThuat");
                    data.NgayThucHien = Convert.ToDateTime(DataReader["NgayThucHien"] == DBNull.Value ? DateTime.Now : DataReader["NgayThucHien"]);

                    data.BangKe1 = JsonConvert.DeserializeObject<ObservableCollection<ChiTietLocMau1>>(DataReader["BangKe1"].ToString());
                    data.BangKe2 = JsonConvert.DeserializeObject<ObservableCollection<ChiTietLocMau2>>(DataReader["BangKe2"].ToString());

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BangTheoDoiLocMau2 bangKe)
        {
            try
            {
                string sql = @"INSERT INTO BangTheoDoiLocMau2
                (
                    MAQUANLY,
                    ChanDoan,
                    NgayThucHien,
                    KiThuat,
                    BangKe1,
                    BangKe2,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :ChanDoan,
                    :NgayThucHien,
                    :KiThuat,
                    :BangKe1,
                    :BangKe2,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (bangKe.ID != 0)
                {
                    sql = @"UPDATE BangTheoDoiLocMau2 SET 
                    MAQUANLY = :MAQUANLY,
                    ChanDoan = :ChanDoan,
                    NgayThucHien = :NgayThucHien,
                    KiThuat = :KiThuat,
                    BangKe1 = :BangKe1,
                    BangKe2 = :BangKe2,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + bangKe.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangKe.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", bangKe.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("NgayThucHien", bangKe.NgayThucHien));
                Command.Parameters.Add(new MDB.MDBParameter("KiThuat", bangKe.KiThuat));
                Command.Parameters.Add(new MDB.MDBParameter("BangKe1", JsonConvert.SerializeObject(bangKe.BangKe1)));
                Command.Parameters.Add(new MDB.MDBParameter("BangKe2", JsonConvert.SerializeObject(bangKe.BangKe2)));

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
                string sql = "DELETE FROM BangTheoDoiLocMau2 WHERE ID = :ID";
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
                BangTheoDoiLocMau2 B
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);

            var ds = new DataSet();

            adt.Fill(ds, "BK");
            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));
            ds.Tables[0].AddColumn("Giuong", typeof(string));
            ds.Tables[0].AddColumn("SOYTE", typeof(string));
            ds.Tables[0].AddColumn("BENHVIEN", typeof(string));
            ds.Tables[0].AddColumn("KHOA", typeof(string));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["Giuong"] = XemBenhAn._ThongTinDieuTri.Giuong;
            ds.Tables[0].Rows[0]["SOYTE"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["KHOA"] = XemBenhAn._ThongTinDieuTri.Khoa;

            ObservableCollection<ChiTietLocMau1> BangKe1 = JsonConvert.DeserializeObject<ObservableCollection<ChiTietLocMau1>>(ds.Tables[0].Rows[0]["BangKe1"].ToString());
            ObservableCollection<ChiTietLocMau2> BangKe2 = JsonConvert.DeserializeObject<ObservableCollection<ChiTietLocMau2>>(ds.Tables[0].Rows[0]["BangKe2"].ToString());

            foreach (ChiTietLocMau1 chitiet in BangKe1)
            {
                if (!string.IsNullOrEmpty(chitiet.BS))
                    chitiet.TenBS = NhanVienFunc.ListNhanVien.FirstOrDefault(x => x.MaNhanVien.Equals(chitiet.BS)).HoVaTen;
                if (!string.IsNullOrEmpty(chitiet.DD))
                    chitiet.TenDD = NhanVienFunc.ListNhanVien.FirstOrDefault(x => x.MaNhanVien.Equals(chitiet.DD)).HoVaTen;
            }

            DataTable BK1 = Common.ListToDataTable(BangKe1, "BK1");
            DataTable BK2 = Common.ListToDataTable(BangKe2, "BK2");
            ds.Tables.Add(BK1);
            ds.Tables.Add(BK2);

            return ds;

        }
    }
}
