using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMR.KyDienTu;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Collections.ObjectModel;
using PMS.Access;
using Newtonsoft.Json;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuXetNghiemDuongMauMaoMach : ThongTinKy
    {
        public PhieuXetNghiemDuongMauMaoMach()
        {
            TableName = "PhieuXNMauMaoMach";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PXNMMM;
            TenMauPhieu = DanhMucPhieu.PXNMMM.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        public string So { get;set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        public string HoTenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Buồng")]
		public string Buong { get; set; }
        [MoTaDuLieu("Giường")]
		public string Giuong { get; set; }
        public DateTime? NgayVaoVien { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public string ThoiDiem1 { get; set; }
        public string ThoiDiem2 { get; set; }
        public string ThoiDiem3 { get; set; }
        public string ThoiDiem4 { get; set; }
        public ObservableCollection<DataXetNghiem> DataXetNghiem { get; set; }
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
    public class DataXetNghiem
    {
        public DateTime? Ngay { get; set; }
        public string KQ1 { get; set; }
        public string NTH1 { get; set; }
        public string KQ2 { get; set; }
        public string NTH2 { get; set; }
        public string KQ3 { get; set; }
        public string NTH3 { get; set; }
        public string KQ4 { get; set; }
        public string NTH4 { get; set; }
    }
    public class PhieuXetNghiemDuongMauMaoMachFunc
    {
        public const string TableName = "PhieuXNMauMaoMach";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuXetNghiemDuongMauMaoMach> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuXetNghiemDuongMauMaoMach> list = new List<PhieuXetNghiemDuongMauMaoMach>();
            try
            {
                string sql = @"SELECT * FROM PhieuXNMauMaoMach where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuXetNghiemDuongMauMaoMach data = new PhieuXetNghiemDuongMauMaoMach();
                    data.ID = DataReader.GetLong("ID");
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.So = DataReader["So"].ToString();
                    data.HoTenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.NgayVaoVien = DataReader["NgayVaoVien"] != DBNull.Value ? (DateTime?) Convert.ToDateTime(DataReader["NgayTao"]):null;
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.Buong = DataReader["Buong"].ToString();
                    data.Giuong = DataReader["Giuong"].ToString();
                    data.ThoiDiem1 = DataReader["ThoiDiem1"].ToString();
                    data.ThoiDiem2 = DataReader["ThoiDiem2"].ToString();
                    data.ThoiDiem3 = DataReader["ThoiDiem3"].ToString();
                    data.ThoiDiem4 = DataReader["ThoiDiem4"].ToString();
                    string phieuJson = DataReader["DataXetNghiem_1"].ToString();
                    if (DataReader["DataXetNghiem_2"] != DBNull.Value)
                        phieuJson += DataReader["DataXetNghiem_2"].ToString();
                    data.DataXetNghiem = JsonConvert.DeserializeObject<ObservableCollection<DataXetNghiem>>(phieuJson);

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuXetNghiemDuongMauMaoMach phieu)
        {
            try
            {
                string sql = @"INSERT INTO PhieuXNMauMaoMach
                (
                    MAQUANLY,
                    MaBenhNhan,
                    NgayVaoVien,
                    So,
                    Buong,
                    Giuong,
                    ChanDoan,
                    ThoiDiem1,
                    ThoiDiem2,
                    ThoiDiem3,
                    ThoiDiem4,
                    DataXetNghiem_1,
                    DataXetNghiem_2,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :NgayVaoVien,
                    :So,
                    :Buong,
                    :Giuong,
                    :ChanDoan,
                    :ThoiDiem1,
                    :ThoiDiem2,
                    :ThoiDiem3,
                    :ThoiDiem4,
                    :DataXetNghiem_1,
                    :DataXetNghiem_2,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (phieu.ID != 0)
                {
                    sql = @"UPDATE PhieuXNMauMaoMach SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    NgayVaoVien = :NgayVaoVien,
                    So = :So,
                    Buong = :Buong,
                    Giuong = :Giuong,
                    ChanDoan = :ChanDoan,
                    ThoiDiem1 = :ThoiDiem1,
                    ThoiDiem2 = :ThoiDiem2,
                    ThoiDiem3 = :ThoiDiem3,
                    ThoiDiem4 = :ThoiDiem4,
                    DataXetNghiem_1 = :DataXetNghiem_1,
                    DataXetNghiem_2 = :DataXetNghiem_2,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + phieu.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", phieu.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", phieu.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("NgayVaoVien", phieu.NgayVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("So", phieu.So));
                Command.Parameters.Add(new MDB.MDBParameter("Buong", phieu.Buong));
                Command.Parameters.Add(new MDB.MDBParameter("Giuong", phieu.Giuong));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", phieu.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiDiem1", phieu.ThoiDiem1));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiDiem2", phieu.ThoiDiem2));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiDiem3", phieu.ThoiDiem3));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiDiem4", phieu.ThoiDiem4));

                string jsonphieus = JsonConvert.SerializeObject(phieu.DataXetNghiem);
                List<string> listJson = new List<string>();
                for (int i = 0; i < jsonphieus.Length; i += 3999)
                {
                    if ((i + 3999) < jsonphieus.Length)
                        listJson.Add(jsonphieus.Substring(i, 3999));
                    else
                        listJson.Add(jsonphieus.Substring(i));
                }
                Command.Parameters.Add(new MDB.MDBParameter("DataXetNghiem_1", listJson[0]));
                Command.Parameters.Add(new MDB.MDBParameter("DataXetNghiem_2", listJson.Count > 1 ? listJson[1] : null));

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", phieu.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", phieu.NgaySua));
                if (phieu.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", phieu.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", phieu.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", phieu.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (phieu.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    phieu.ID = nextval;
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
                string sql = "DELETE FROM PhieuXNMauMaoMach WHERE ID = :ID";
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
                B.So,
                B.NgayVaoVien,
                B.ChanDoan,
                B.Buong,
                B.Giuong,
                B.ThoiDiem1,
                B.ThoiDiem2,
                B.ThoiDiem3,
                B.ThoiDiem4
            FROM
                PhieuXNMauMaoMach B
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "BK");

            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(string));
            ds.Tables[0].AddColumn("SOYTE", typeof(string));
            ds.Tables[0].AddColumn("BENHVIEN", typeof(string));
            ds.Tables[0].AddColumn("KHOA", typeof(string));
            ds.Tables[0].AddColumn("MaBenhAn", typeof(string));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            ds.Tables[0].Rows[0]["SOYTE"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["KHOA"] = XemBenhAn._ThongTinDieuTri.Khoa;
            ds.Tables[0].Rows[0]["MaBenhAn"] = XemBenhAn._ThongTinDieuTri.MaBenhAn;

            sql = @"SELECT
               B.DataXetNghiem_1, B.DataXetNghiem_2
            FROM
                PhieuXNMauMaoMach B
                
            WHERE
                ID = " + id;

            Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            List<DataXetNghiem> saveDatas = new List<DataXetNghiem>();
            while (DataReader.Read())
            {
                string bangKeJson = DataReader["DataXetNghiem_1"].ToString();
                if (DataReader["DataXetNghiem_2"] != DBNull.Value)
                    bangKeJson += DataReader["DataXetNghiem_2"].ToString();
                saveDatas = JsonConvert.DeserializeObject<List<DataXetNghiem>>(bangKeJson).ToList();
                break;
            }

            DataTable ChiTiet = new DataTable("KQ");
            ChiTiet.Columns.Add("Ngay", typeof(string));
            ChiTiet.Columns.Add("KQ1", typeof(string));
            ChiTiet.Columns.Add("NTH1", typeof(string));
            ChiTiet.Columns.Add("KQ2", typeof(string));
            ChiTiet.Columns.Add("NTH2", typeof(string));
            ChiTiet.Columns.Add("KQ3", typeof(string));
            ChiTiet.Columns.Add("NTH3", typeof(string));
            ChiTiet.Columns.Add("KQ4", typeof(string));
            ChiTiet.Columns.Add("NTH4", typeof(string));
            foreach (DataXetNghiem chiTiet in saveDatas)
            {
                ChiTiet.Rows.Add
                (
                    chiTiet.Ngay.HasValue ? chiTiet.Ngay.Value.ToString("dd/MM/yyyy") : null,
                    chiTiet.KQ1,
                    chiTiet.NTH1,
                    chiTiet.KQ2,
                    chiTiet.NTH2,
                    chiTiet.KQ3,
                    chiTiet.NTH3,
                    chiTiet.KQ4,
                    chiTiet.NTH4
                ); ;
               
            }
            ds.Tables.Add(ChiTiet);
            return ds;

        }
    }
}
