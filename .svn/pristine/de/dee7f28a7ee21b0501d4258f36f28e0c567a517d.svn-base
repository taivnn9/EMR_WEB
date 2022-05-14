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
    public class ChiTietLocMau3
    {
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã phiếu")]
		public long ID_Phieu { get; set; }
        [MoTaDuLieu("Giờ")]
        public string Gio { get; set; }
        [MoTaDuLieu("Huyết áp")]
		public string HuyetAp { get; set; }
        [MoTaDuLieu("Blood")]
        public string Blood { get; set; }
        [MoTaDuLieu("Replacement")]
        public string Replacement { get; set; }
        [MoTaDuLieu("Dialyat")]
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
    public class BangTheoDoiLocMau3 : ThongTinKy
    {
        public BangTheoDoiLocMau3()
        {
            TableName = "BangTheoDoiLocMau3";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BTDLM3;
            TenMauPhieu = DanhMucPhieu.BTDLM3.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")] 
        public string HoTenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Vị trí đặt KT")]
        public string ViTriDatKT { get; set; }
        [MoTaDuLieu("Ngày làm thử thuật")]
        public DateTime? NgayThuThuat { get; set; }
        [MoTaDuLieu("Ngày theo dõi")]
        public DateTime? NgayTheoDoi { get; set; }
        public bool[] KiThuatArray { get; } = new bool[] { false, false,false, false };
        [MoTaDuLieu("Kĩ thuật")]
        public string KiThuat
        {
            get
            {
                string temp = "";
                for (int i = 0; i < KiThuatArray.Length; i++)
                    temp += (KiThuatArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        KiThuatArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Bảng kê chi tiết lọc máu")]
        public ObservableCollection<ChiTietLocMau3> BangKe { get; set; }
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
    public class BangTheoDoiLocMau3Func
    {
        public const string TableName = "BangTheoDoiLocMau3";
        public const string TablePrimaryKeyName = "ID";
        public static List<BangTheoDoiLocMau3> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BangTheoDoiLocMau3> list = new List<BangTheoDoiLocMau3>();
            try
            {
                string sql = @"SELECT * FROM BangTheoDoiLocMau3 where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    BangTheoDoiLocMau3 data = new BangTheoDoiLocMau3();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.HoTenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.KiThuat = DataReader["KiThuat"].ToString();
                    data.ViTriDatKT = DataReader["ViTriDatKT"].ToString();
                    data.NgayThuThuat = Convert.ToDateTime(DataReader["NgayThuThuat"] == DBNull.Value ? DateTime.Now : DataReader["NgayThuThuat"]);
                    data.NgayTheoDoi = Convert.ToDateTime(DataReader["NgayTheoDoi"] == DBNull.Value ? DateTime.Now : DataReader["NgayTheoDoi"]);

                    data.BangKe = GetChiTietLocMau(_OracleConnection, data.ID);

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BangTheoDoiLocMau3 bangKe)
        {
            try
            {
                string sql = @"INSERT INTO BangTheoDoiLocMau3
                (
                    MAQUANLY,
                    ChanDoan,
                    NgayThuThuat,
                    ViTriDatKT,
                    KiThuat,
                    NgayTheoDoi,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :ChanDoan,
                    :NgayThuThuat,
                    :ViTriDatKT,
                    :KiThuat,
                    :NgayTheoDoi,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (bangKe.ID != 0)
                {
                    sql = @"UPDATE BangTheoDoiLocMau3 SET 
                    MAQUANLY = :MAQUANLY,
                    ChanDoan = :ChanDoan,
                    NgayThuThuat = :NgayThuThuat,
                    ViTriDatKT = :ViTriDatKT,
                    KiThuat = :KiThuat,
                    NgayTheoDoi = :NgayTheoDoi,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + bangKe.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangKe.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", bangKe.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("NgayThuThuat", bangKe.NgayThuThuat));
                Command.Parameters.Add(new MDB.MDBParameter("ViTriDatKT", bangKe.ViTriDatKT));
                Command.Parameters.Add(new MDB.MDBParameter("KiThuat", bangKe.KiThuat));
                Command.Parameters.Add(new MDB.MDBParameter("NgayTheoDoi", bangKe.NgayTheoDoi));

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
                string sql = "DELETE FROM BangTheoDoiLocMau3 WHERE ID = :ID";
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
                BangTheoDoiLocMau3 B
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);

            var ds = new DataSet();

            adt.Fill(ds, "TB");
            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(string));
            ds.Tables[0].AddColumn("BENHVIEN", typeof(string));
            ds.Tables[0].AddColumn("KHOA", typeof(string));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["KHOA"] = XemBenhAn._ThongTinDieuTri.Khoa;

            ObservableCollection<ChiTietLocMau3> BangKe = GetChiTietLocMau(MyConnection, id);


            DataTable BK = Common.ListToDataTable(BangKe, "BK");
            ds.Tables.Add(BK);

            return ds;

        }

        public static bool InsertOrUpdateChiTietLocMau(MDB.MDBConnection MyConnection, ChiTietLocMau3 _ChiTietLocMau3)
        {
            try
            {
                string sql = @"INSERT INTO ChiTietLocMau3
                (
                    ID_Phieu,
                    Gio,
                    HuyetAp,
                    Blood,
                    Replacement,
                    Dialyat,
                    UF,
                    Heparin,
                    Access1,
                    Filter,
                    TMP,
                    Return1)  VALUES
                 (
				    :ID_Phieu,
                    :Gio,
                    :HuyetAp,
                    :Blood,
                    :Replacement,
                    :Dialyat,
                    :UF,
                    :Heparin,
                    :Access1,
                    :Filter,
                    :TMP,
                    :Return1
                 )";
                if (_ChiTietLocMau3.ID != 0)
                {
                    sql = @"UPDATE ChiTietLocMau3 SET 
                    ID_Phieu = :ID_Phieu,
                    Gio = :Gio,
                    HuyetAp = :HuyetAp,
                    Blood = :Blood,
                    Replacement = :Replacement,
                    Dialyat = :Dialyat,
                    UF = :UF,
                    Heparin = :Heparin,
                    Access1 = :Access1,
                    Filter = :Filter,
                    TMP = :TMP,
                    Return1 = :Return1
                    WHERE ID = " + _ChiTietLocMau3.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID_Phieu", _ChiTietLocMau3.ID_Phieu));
                Command.Parameters.Add(new MDB.MDBParameter("Gio", _ChiTietLocMau3.Gio));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetAp", _ChiTietLocMau3.HuyetAp));
                Command.Parameters.Add(new MDB.MDBParameter("Blood", _ChiTietLocMau3.Blood));
                Command.Parameters.Add(new MDB.MDBParameter("Replacement", _ChiTietLocMau3.Replacement));
                Command.Parameters.Add(new MDB.MDBParameter("Dialyat", _ChiTietLocMau3.Dialyat));
                Command.Parameters.Add(new MDB.MDBParameter("UF", _ChiTietLocMau3.UF));
                Command.Parameters.Add(new MDB.MDBParameter("Heparin", _ChiTietLocMau3.Heparin));
                Command.Parameters.Add(new MDB.MDBParameter("Access1", _ChiTietLocMau3.Access));
                Command.Parameters.Add(new MDB.MDBParameter("Filter", _ChiTietLocMau3.Filter));
                Command.Parameters.Add(new MDB.MDBParameter("TMP", _ChiTietLocMau3.TMP));
                Command.Parameters.Add(new MDB.MDBParameter("Return1", _ChiTietLocMau3.Return));

                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }

        public static ObservableCollection<ChiTietLocMau3> GetChiTietLocMau(MDB.MDBConnection _OracleConnection, long idPhieu)
        {
            ObservableCollection<ChiTietLocMau3> ChiTietLocMau3s = new ObservableCollection<ChiTietLocMau3>();
            try
            {
                string sql = @"SELECT * FROM ChiTietLocMau3 where ID_Phieu = :ID_Phieu ORDER BY ID asc";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID_Phieu", idPhieu));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    ChiTietLocMau3 data = new ChiTietLocMau3();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.ID_Phieu = idPhieu;

                    data.Gio = DataReader["Gio"].ToString();
                    data.HuyetAp = DataReader["HuyetAp"].ToString();
                    data.Blood = DataReader["Blood"].ToString();
                    data.Replacement = DataReader["Replacement"].ToString();
                    data.Dialyat = DataReader["Dialyat"].ToString();
                    data.UF = DataReader["UF"].ToString();
                    data.Heparin = DataReader["Heparin"].ToString();
                    data.Access = DataReader["Access1"].ToString();
                    data.Filter = DataReader["Filter"].ToString();
                    data.TMP = DataReader["TMP"].ToString();
                    data.Return = DataReader["Return1"].ToString();

                    ChiTietLocMau3s.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return ChiTietLocMau3s;
        }
        public static bool DeleteChiTietLocMau(MDB.MDBConnection MyConnection, long id)
        {
            try
            {
                string sql = "DELETE FROM ChiTietLocMau3 WHERE ID = :ID";
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
    }
}
