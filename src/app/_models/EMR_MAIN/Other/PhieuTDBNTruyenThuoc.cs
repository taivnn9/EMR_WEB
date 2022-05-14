using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMR.KyDienTu;
using PMS.Access;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuTDBNTruyenThuoc : ThongTinKy
    {
        public PhieuTDBNTruyenThuoc()
        {
            TableName = "PhieuTDBNTruyenThuoc";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PTDBNTT;
            TenMauPhieu = DanhMucPhieu.PTDBNTT.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        public string HoTenBenhNhan { get; set; }
        [MoTaDuLieu("Mã bệnh án")]
		public string MaBenhAn { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        public string TenThuoc { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Giường")]
		public string Giuong { get; set; }
        public string Phong { get; set; }
        [MoTaDuLieu("Cân nặng")]
		public string CanNang { get; set; }
        public DateTime? NgayTruyen { get; set; }
        public ObservableCollection<TheoDoiTruyenThuocChiTiet> ChiTiets { get; set; }
        public string NguoiTheoDoi { get; set; }
        public string MaNguoiTheoDoi { get; set; }
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
    public class TheoDoiTruyenThuocChiTiet
    {
        public int STT { get; set; }
        public string G { get; set; }
        public string L { get; set; }
        public string T { get; set; }
        public string M { get; set; }
        public string H { get; set; }
        public string TDP { get; set; }
    }
    public class PhieuTDBNTruyenThuocFunc
    {
        public const string TableName = "PhieuTDBNTruyenThuoc";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuTDBNTruyenThuoc> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuTDBNTruyenThuoc> list = new List<PhieuTDBNTruyenThuoc>();
            try
            {
                string sql = @"SELECT * FROM PhieuTDBNTruyenThuoc where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuTDBNTruyenThuoc data = new PhieuTDBNTruyenThuoc();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.HoTenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.TenThuoc = DataReader["TenThuoc"].ToString();
                    data.MaBenhAn = DataReader["MaBenhAn"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.Giuong = DataReader["Giuong"].ToString();
                    data.Phong = DataReader["Phong"].ToString();
                    data.CanNang = DataReader["CanNang"].ToString();
                    data.NgayTruyen = DataReader["NgayTruyen"] != DBNull.Value ? (DateTime?) Convert.ToDateTime(DataReader["NgayTruyen"]): null;

                    string bangKeJson = DataReader["ChiTiet_1"].ToString();
                    if (DataReader["ChiTiet_2"] != DBNull.Value)
                        bangKeJson += DataReader["ChiTiet_2"].ToString();
                    data.ChiTiets = JsonConvert.DeserializeObject<ObservableCollection<TheoDoiTruyenThuocChiTiet>>(bangKeJson);

                    data.NguoiTheoDoi = DataReader["NguoiTheoDoi"].ToString();
                    data.MaNguoiTheoDoi = DataReader["MaNguoiTheoDoi"].ToString();

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuTDBNTruyenThuoc bangKe)
        {
            try
            {
                string sql = @"INSERT INTO PhieuTDBNTruyenThuoc
                (
                    MAQUANLY,
                    MaBenhNhan,
                    MaBenhAn,
                    TenThuoc,
                    ChanDoan,
                    Giuong,
                    Phong,
                    CanNang,
                    NgayTruyen,
                    ChiTiet_1,
                    ChiTiet_2,
                    NguoiTheoDoi,
                    MaNguoiTheoDoi,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :MaBenhAn,
                    :TenThuoc,
                    :ChanDoan,
                    :Giuong,
                    :Phong,
                    :CanNang,
                    :NgayTruyen,
                    :ChiTiet_1,
                    :ChiTiet_2,
                    :NguoiTheoDoi,
                    :MaNguoiTheoDoi,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (bangKe.ID != 0)
                {
                    sql = @"UPDATE PhieuTDBNTruyenThuoc SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    MaBenhAn = :MaBenhAn,
                    TenThuoc = :TenThuoc,
                    ChanDoan = :ChanDoan,
                    Giuong = :Giuong,
                    Phong = :Phong,
                    CanNang = :CanNang,
                    NgayTruyen = :NgayTruyen,
                    ChiTiet_1 = :ChiTiet_1,
                    ChiTiet_2 = :ChiTiet_2,
                    NguoiTheoDoi = :NguoiTheoDoi,
                    MaNguoiTheoDoi = :MaNguoiTheoDoi,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + bangKe.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangKe.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", bangKe.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhAn", bangKe.MaBenhAn));
                Command.Parameters.Add(new MDB.MDBParameter("TenThuoc", bangKe.TenThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", bangKe.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("Giuong", bangKe.Giuong));
                Command.Parameters.Add(new MDB.MDBParameter("Phong", bangKe.Phong));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang", bangKe.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("NgayTruyen", bangKe.NgayTruyen));
                string jsonBangKes = JsonConvert.SerializeObject(bangKe.ChiTiets);
                List<string> listJson = new List<string>();
                for (int i = 0; i < jsonBangKes.Length; i += 3999)
                {
                    if ((i + 3999) < jsonBangKes.Length)
                        listJson.Add(jsonBangKes.Substring(i, 3999));
                    else
                        listJson.Add(jsonBangKes.Substring(i));
                }
                Command.Parameters.Add(new MDB.MDBParameter("ChiTiet_1", listJson[0]));
                Command.Parameters.Add(new MDB.MDBParameter("ChiTiet_2", listJson.Count > 1 ? listJson[1] : null));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiTheoDoi", bangKe.NguoiTheoDoi));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiTheoDoi", bangKe.MaNguoiTheoDoi));
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
                string sql = "DELETE FROM PhieuTDBNTruyenThuoc WHERE ID = :ID";
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
                B.MAQUANLY,
                B.MaBenhNhan,
                B.MaBenhAn,
                B.TenThuoc,
                B.ChanDoan,
                B.Giuong,
                B.Phong,
                B.CanNang,
                B.NgayTruyen,
                B.NguoiTheoDoi,
                B.MaNguoiTheoDoi 
            FROM
                PhieuTDBNTruyenThuoc B
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "BK");
            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(int));
            ds.Tables[0].AddColumn("SOYTE", typeof(string));
            ds.Tables[0].AddColumn("BENHVIEN", typeof(string));
            ds.Tables[0].AddColumn("KHOA", typeof(string));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["GioiTinh"] = (int)XemBenhAn._HanhChinhBenhNhan.GioiTinh;
            ds.Tables[0].Rows[0]["SOYTE"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["KHOA"] = XemBenhAn._ThongTinDieuTri.Khoa;

            sql = @"SELECT
               B.ChiTiet_1, B.ChiTiet_2
            FROM
                PhieuTDBNTruyenThuoc B
                
            WHERE
                ID = " + id;

            Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            ObservableCollection<TheoDoiTruyenThuocChiTiet> saveDatas = new ObservableCollection<TheoDoiTruyenThuocChiTiet>();
            while (DataReader.Read())
            {
                string bangKeJson = DataReader["ChiTiet_1"].ToString();
                if (DataReader["ChiTiet_2"] != DBNull.Value)
                    bangKeJson += DataReader["ChiTiet_2"].ToString();
                saveDatas = JsonConvert.DeserializeObject<ObservableCollection<TheoDoiTruyenThuocChiTiet>>(bangKeJson);
                break;
            }

            DataTable ChiTiet = new DataTable("CT");
            ChiTiet.Columns.Add("STT", typeof(int));
            ChiTiet.Columns.Add("G", typeof(string));
            ChiTiet.Columns.Add("L", typeof(string));
            ChiTiet.Columns.Add("T", typeof(string));
            ChiTiet.Columns.Add("M", typeof(string));
            ChiTiet.Columns.Add("H", typeof(string));
            ChiTiet.Columns.Add("TDP", typeof(string));
            foreach (TheoDoiTruyenThuocChiTiet chiTiet in saveDatas)
            {
                ChiTiet.Rows.Add(
                    chiTiet.STT,
                    chiTiet.G,
                    chiTiet.L,
                    chiTiet.T,
                    chiTiet.M,
                    chiTiet.H,
                    chiTiet.TDP);
            }

            ds.Tables.Add(ChiTiet);

            return ds;

        }
    }

}
