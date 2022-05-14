using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class DonXinXacNhanNamVien : ThongTinKy
    {
        public DonXinXacNhanNamVien()
        {
            TableName = "DonXinXacNhanNamVien";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.DXXNNV;
            TenMauPhieu = DanhMucPhieu.DXXNNV.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }

        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }

        [MoTaDuLieu("Trưởng khoa")]
		public string TruongKhoa { get; set; }
        [MoTaDuLieu("Mã trưởng khoa")]
		public string MaTruongKhoa { get; set; }
        public string GiamDoc { get; set; }
        public string MaGiamDoc { get; set; }
        public string So { get; set; }
        public string TinhOrHuyen { get; set; }
        public DateTime? NgayVietDon { get; set; }
        public string TrungTam { get; set; }
        public string TenNguoiVietDon { get; set; }
        public string NamSinhNguoiVietDon { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChiNguoiVietDon { get; set; }
        public string CmndNguoiVietDon { get; set; }
        public DateTime? NgayCapNguoiVietDon { get; set; }
        public string NoiCapNguoiVietDon { get; set; }
        public string HoVaTen { get; set; }
        public DateTime? NamSinh { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChiThuongTru { get; set; }
        public string DonViCongTac { get; set; }
        public DateTime? NgayVaoVien_Gio { get; set; }
        public DateTime? NgayVaoVien { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public string NoiTruTai { get; set; }
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
    
    public class DanhSachThanhViens
    {
        public string TenThanhVien { get; set; }
        public string ChucDanh { get; set; }
    }
    public class DonXinXacNhanNamVienFunc
    {
        public const string TableName = "DonXinXacNhanNamVien";
        public const string TablePrimaryKeyName = "ID";
        public const string MaPhieu = "DXXNNV";

        public static List<DonXinXacNhanNamVien> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<DonXinXacNhanNamVien> list = new List<DonXinXacNhanNamVien>();
            try
            {
                string sql = @"SELECT * FROM DonXinXacNhanNamVien where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    DonXinXacNhanNamVien data = new DonXinXacNhanNamVien();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.TrungTam = DataReader["TrungTam"].ToString();
                    data.TenNguoiVietDon = DataReader["TenNguoiVietDon"].ToString();
                    data.NamSinhNguoiVietDon = DataReader["NamSinhNguoiVietDon"].ToString();
                    data.DiaChiNguoiVietDon = DataReader["DiaChiNguoiVietDon"].ToString();
                    data.CmndNguoiVietDon = DataReader["CmndNguoiVietDon"].ToString();
                    data.NgayCapNguoiVietDon = DataReader["NgayCapNguoiVietDon"] == DBNull.Value ? (DateTime?)null : DataReader.GetDate("NgayCapNguoiVietDon");
                    data.NoiCapNguoiVietDon = DataReader["NoiCapNguoiVietDon"].ToString();
                    data.HoVaTen = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.NamSinh = XemBenhAn._HanhChinhBenhNhan.NgaySinh;
                    data.DiaChiThuongTru = DataReader["DiaChiThuongTru"].ToString();
                    data.DonViCongTac = DataReader["DonViCongTac"].ToString();
                    data.NgayVaoVien = DataReader["NgayVaoVien"] == DBNull.Value ? (DateTime?)null : DataReader.GetDate("NgayVaoVien");
                    data.NgayVaoVien_Gio = data.NgayVaoVien; 
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.NoiTruTai = XemBenhAn._ThongTinDieuTri.Khoa;
                    data.So = DataReader["So"].ToString();
                    data.TinhOrHuyen = DataReader["TinhOrHuyen"].ToString();
                    data.NgayVietDon = DataReader["NgayVietDon"] == DBNull.Value ? (DateTime?)null : DataReader.GetDate("NgayVietDon");
                    data.TruongKhoa = DataReader["TruongKhoa"].ToString();
                    data.GiamDoc = DataReader["GiamDoc"].ToString();
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

        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref DonXinXacNhanNamVien bangKiem)
        {
            try
            {
                string sql = @"INSERT INTO DonXinXacNhanNamVien
                (
                    MAQUANLY,
                    TrungTam,
                    TenNguoiVietDon,
                    NamSinhNguoiVietDon,
                    DiaChiNguoiVietDon,
                    CmndNguoiVietDon,
                    NgayCapNguoiVietDon,
                    NoiCapNguoiVietDon,
                    DiaChiThuongTru,
                    DonViCongTac,
                    NgayVaoVien,
                    ChanDoan,
                    So,
                    TinhOrHuyen,
                    NgayVietDon,
                    MaTruongKhoa,
                    TruongKhoa,
                    MaGiamDoc,
                    GiamDoc,
                    NgayTao,
                    NguoiTao,
                    NguoiSua,
                    NgaySua)  VALUES
                 (
				    :MAQUANLY,
                    :TrungTam,
                    :TenNguoiVietDon,
                    :NamSinhNguoiVietDon,
                    :DiaChiNguoiVietDon,
                    :CmndNguoiVietDon,
                    :NgayCapNguoiVietDon,
                    :NoiCapNguoiVietDon,
                    :DiaChiThuongTru,
                    :DonViCongTac,
                    :NgayVaoVien,
                    :ChanDoan,
                    :So,
                    :TinhOrHuyen,
                    :NgayVietDon,
                    :MaTruongKhoa,
                    :TruongKhoa,
                    :MaGiamDoc,
                    :GiamDoc,
                    :NgayTao,
                    :NguoiTao,
                    :NguoiSua,
                    :NgaySua
                 )  RETURNING ID INTO :ID";
                if (bangKiem.ID != 0)
                {
                    sql = @"UPDATE DonXinXacNhanNamVien SET 
                    MAQUANLY = :MAQUANLY,
					TrungTam = :TrungTam,
                    TenNguoiVietDon = :TenNguoiVietDon,
                    NamSinhNguoiVietDon = :NamSinhNguoiVietDon,
                    DiaChiNguoiVietDon = :DiaChiNguoiVietDon,
                    CmndNguoiVietDon = :CmndNguoiVietDon,
                    NgayCapNguoiVietDon = :NgayCapNguoiVietDon,
                    NoiCapNguoiVietDon = :NoiCapNguoiVietDon,
                    DiaChiThuongTru = :DiaChiThuongTru,
                    DonViCongTac = :DonViCongTac,
                    NgayVaoVien = :NgayVaoVien,
                    ChanDoan = :ChanDoan,
                    So = :So,
                    TinhOrHuyen = :TinhOrHuyen,
                    NgayVietDon = :NgayVietDon,
                    MaTruongKhoa = :MaTruongKhoa,
                    TruongKhoa = :TruongKhoa,
                    MaGiamDoc = :MaGiamDoc,
                    GiamDoc = :GiamDoc,
                    NguoiSua = :NguoiSua,
                    NgaySua = :NgaySua
                    WHERE ID = " + bangKiem.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangKiem.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("TrungTam", bangKiem.TrungTam));
                Command.Parameters.Add(new MDB.MDBParameter("TenNguoiVietDon", bangKiem.TenNguoiVietDon));
                Command.Parameters.Add(new MDB.MDBParameter("NamSinhNguoiVietDon", bangKiem.NamSinhNguoiVietDon));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChiNguoiVietDon", bangKiem.DiaChiNguoiVietDon));
                Command.Parameters.Add(new MDB.MDBParameter("CmndNguoiVietDon", bangKiem.CmndNguoiVietDon));
                Command.Parameters.Add(new MDB.MDBParameter("NgayCapNguoiVietDon", bangKiem.NgayCapNguoiVietDon));
                Command.Parameters.Add(new MDB.MDBParameter("NoiCapNguoiVietDon", bangKiem.NoiCapNguoiVietDon));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChiThuongTru", bangKiem.DiaChiThuongTru));
                Command.Parameters.Add(new MDB.MDBParameter("DonViCongTac", bangKiem.DonViCongTac));
      
                /*
                DateTime? ThoiGian = bangKiem.ThoiGian.HasValue ? bangKiem.ThoiGian.Value.Date : (DateTime?)null;
                var ThoiGianFull = ThoiGian;
                if (ThoiGian != null)
                {
                    var ThoiGian_Gio = bangKiem.ThoiGian_Gio.HasValue ? bangKiem.ThoiGian_Gio.Value.TimeOfDay : new TimeSpan(0, 0, 0);
                    ThoiGianFull = ThoiGian + ThoiGian_Gio;
                }

                Command.Parameters.Add(new MDB.MDBParameter("ThoiGian", ThoiGianFull));
                */

                DateTime? NgayVaoVien = bangKiem.NgayVaoVien.HasValue ? bangKiem.NgayVaoVien.Value.Date : (DateTime?)null;
                var NgayVaoVienFull = NgayVaoVien;
                if (NgayVaoVien != null)
                {
                    var NgayVaoVien_Gio = bangKiem.NgayVaoVien_Gio.HasValue ? bangKiem.NgayVaoVien_Gio.Value.TimeOfDay : new TimeSpan(0, 0, 0);
                    NgayVaoVienFull = NgayVaoVien + NgayVaoVien_Gio;
                }

                Command.Parameters.Add(new MDB.MDBParameter("NgayVaoVien", NgayVaoVienFull));


                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", bangKiem.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("So", bangKiem.So));
                Command.Parameters.Add(new MDB.MDBParameter("TinhOrHuyen", bangKiem.TinhOrHuyen));
                
                Command.Parameters.Add(new MDB.MDBParameter("MaTruongKhoa", bangKiem.MaTruongKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("TruongKhoa", bangKiem.TruongKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaGiamDoc", bangKiem.MaGiamDoc));
                Command.Parameters.Add(new MDB.MDBParameter("GiamDoc", bangKiem.GiamDoc));
                Command.Parameters.Add(new MDB.MDBParameter("NgayVietDon", bangKiem.NgayVietDon));

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
                string sql = "DELETE FROM DonXinXacNhanNamVien WHERE ID = :ID";
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
                DonXinXacNhanNamVien B
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);

            var ds = new DataSet();

            adt.Fill(ds, "TB");
            ds.Tables[0].AddColumn("HoVaTen", typeof(string));
            ds.Tables[0].AddColumn("NamSinh", typeof(string));
            ds.Tables[0].AddColumn("NoiTruTai", typeof(string));

            ds.Tables[0].AddColumn("SOYTE", typeof(string));
            ds.Tables[0].AddColumn("BENHVIEN", typeof(string));


            ds.Tables[0].Rows[0]["HoVaTen"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["NamSinh"] = XemBenhAn._HanhChinhBenhNhan.NgaySinh;
            ds.Tables[0].Rows[0]["NoiTruTai"] = XemBenhAn._ThongTinDieuTri.Khoa;
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
