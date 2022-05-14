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
    public class GiayHenSieuAmTimQTQ : ThongTinKy
    {
        public GiayHenSieuAmTimQTQ()
        {
            TableName = "GiayHenSieuAmTimQTQ";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.GHSATQTQ;
            TenMauPhieu = DanhMucPhieu.GHSATQTQ.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }

        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }

        [MoTaDuLieu("Họ tên bác sỹ")]
		public string BacSi { get; set; }
        [MoTaDuLieu("Mã bác sỹ")]
		public string MaBacSi { get; set; }
        public string HoVaTenNB { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        public DateTime? NgayVietDon { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public DateTime? ThoiGian_Gio { get; set; }
        public DateTime? ThoiGian { get; set; }
        public string KhongAnTu { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        public DateTime? NgayTao { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        public DateTime? NgaySua { get; set; }

    }
    
    public class GiayHenSieuAmTimQTQFunc
    {
        public const string TableName = "GiayHenSieuAmTimQTQ";
        public const string TablePrimaryKeyName = "ID";
        public const string MaPhieu = "GHSATQTQ";

        public static List<GiayHenSieuAmTimQTQ> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<GiayHenSieuAmTimQTQ> list = new List<GiayHenSieuAmTimQTQ>();
            try
            {
                string sql = @"SELECT * FROM GiayHenSieuAmTimQTQ where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    GiayHenSieuAmTimQTQ data = new GiayHenSieuAmTimQTQ();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.BacSi = DataReader["BacSi"].ToString();
                    data.NgayVietDon = DataReader["NgayVietDon"] == DBNull.Value ? (DateTime?)null : DataReader.GetDate("NgayVietDon");
                    data.DiaChi = DataReader["DiaChi"].ToString();
                    data.DienThoai = DataReader["DienThoai"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.HoVaTenNB = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.KhongAnTu = DataReader["KhongAnTu"].ToString();
                    data.ThoiGian = DataReader["ThoiGian"] == DBNull.Value ? (DateTime?)null : DataReader.GetDate("ThoiGian");
                    data.ThoiGian_Gio = data.ThoiGian; 
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;
                    data.NgayTao = DataReader["NgayTao"] == DBNull.Value ? (DateTime?)null : DataReader.GetDate("NgayTao");
                    data.NguoiTao = DataReader["NguoiTao"].ToString();
                    data.NguoiSua = DataReader["NguoiSua"].ToString();
                    data.NgaySua = DataReader["NgaySua"] == DBNull.Value ? (DateTime?)null : DataReader.GetDate("NgaySua");


                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }

        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref GiayHenSieuAmTimQTQ bangKiem)
        {
            try
            {
                string sql = @"INSERT INTO GiayHenSieuAmTimQTQ
                (
                    MAQUANLY,
                    MaBacSi,
                    BacSi,
                    NgayVietDon,
                    DiaChi,
                    DienThoai,
                    ChanDoan,
                    ThoiGian,
                    ThoiGian_Gio,
                    KhongAnTu,
                    NgayTao,
                    NguoiTao,
                    NguoiSua,
                    NgaySua)  VALUES
                 (
				    :MAQUANLY,
                    :MaBacSi,
                    :BacSi,
                    :NgayVietDon,
                    :DiaChi,
                    :DienThoai,
                    :ChanDoan,
                    :ThoiGian,
                    :ThoiGian_Gio,
                    :KhongAnTu,
                    :NgayTao,
                    :NguoiTao,
                    :NguoiSua,
                    :NgaySua
                 )  RETURNING ID INTO :ID";
                if (bangKiem.ID != 0)
                {
                    sql = @"UPDATE GiayHenSieuAmTimQTQ SET 
                    MAQUANLY = :MAQUANLY,
					MaBacSi = :MaBacSi,
                    BacSi = :BacSi,
                    NgayVietDon = :NgayVietDon,
                    DiaChi = :DiaChi,
                    DienThoai = :DienThoai,
                    ChanDoan = :ChanDoan,
                    ThoiGian = :ThoiGian,
                    ThoiGian_Gio = : ThoiGian_Gio,
                    KhongAnTu = :KhongAnTu,
                    NguoiSua = :NguoiSua,
                    NgaySua = :NgaySua
                    WHERE ID = " + bangKiem.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangKiem.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSi", bangKiem.MaBacSi));
                Command.Parameters.Add(new MDB.MDBParameter("BacSi", bangKiem.BacSi));
                Command.Parameters.Add(new MDB.MDBParameter("NgayVietDon", bangKiem.NgayVietDon));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", bangKiem.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("DienThoai", bangKiem.DienThoai));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", bangKiem.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGian", bangKiem.ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGian_Gio", bangKiem.ThoiGian_Gio));

                /*
                DateTime? ThoiGian = bangKiem.ThoiGian.HasValue ? bangKiem.ThoiGian.Value.Date : (DateTime?)null;
                var ThoiGianFull = ThoiGian;
                if (ThoiGian != null)
                {
                    var ThoiGian_Gio = bangKiem.ThoiGian_Gio.HasValue ? bangKiem.ThoiGian_Gio.Value.TimeOfDay : new TimeSpan(0, 0, 0);
                    ThoiGianFull = ThoiGian + ThoiGian_Gio;
                }

                Command.Parameters.Add(new MDB.MDBParameter("ThoiGian", ThoiGianFull));*/

                /*
                DateTime? NgayVaoVien = bangKiem.NgayVaoVien.HasValue ? bangKiem.NgayVaoVien.Value.Date : (DateTime?)null;
                var NgayVaoVienFull = NgayVaoVien;
                if (NgayVaoVien != null)
                {
                    var NgayVaoVien_Gio = bangKiem.NgayVaoVien_Gio.HasValue ? bangKiem.NgayVaoVien_Gio.Value.TimeOfDay : new TimeSpan(0, 0, 0);
                    NgayVaoVienFull = NgayVaoVien + NgayVaoVien_Gio;
                }
                
                Command.Parameters.Add(new MDB.MDBParameter("NgayVaoVien", NgayVaoVienFull));

                */
                Command.Parameters.Add(new MDB.MDBParameter("KhongAnTu", bangKiem.KhongAnTu));

                Command.Parameters.Add(new MDB.MDBParameter("NguoiSua", bangKiem.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NgaySua", bangKiem.NgaySua));
                if (bangKiem.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", bangKiem.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NguoiTao", bangKiem.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NgayTao", bangKiem.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (bangKiem.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    bangKiem.ID = nextval;
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
                string sql = "DELETE FROM GiayHenSieuAmTimQTQ WHERE ID = :ID";
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
                GiayHenSieuAmTimQTQ B
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);

            var ds = new DataSet();

            adt.Fill(ds, "TB");
            ds.Tables[0].AddColumn("HoVaTenNB", typeof(string));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));

            ds.Tables[0].AddColumn("GioiTinh", typeof(string));

            ds.Tables[0].AddColumn("SOYTE", typeof(string));
            ds.Tables[0].AddColumn("BENHVIEN", typeof(string));


            ds.Tables[0].Rows[0]["HoVaTenNB"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();

            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["SOYTE"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;


            /*
            ObservableCollection<DanhSachThanhVien> ListThanhVien = JsonConvert.DeserializeObject<ObservableCollection<DanhSachThanhVien>>(ds.Tables[0].Rows[0]["ListThanhVien"].ToString());
            string CacThanhVien = "";

            foreach (DanhSachThanhVien tv in ListThanhVien)
            {
                NhanVien nv = NhanVienFunc.ListNhanVien.Where(x => x.MaNhanVien.Equals(tv.TenThanhVien)).FirstOrDefault();
                CacThanhVien += nv.HoVaTen + "\r\n";
                tv.TenThanhVien = nv.HoVaTen;
            }

            ds.Tables[0].Rows[0]["CacThanhVien"] = CacThanhVien;
            

            DataTable TV = Common.ListToDataTable(ListThanhVien, "TV"); 
            ds.Tables.Add(TV); */

            return ds;
        }
    }
}
