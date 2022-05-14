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
    public class GiayCamDoanLSATQTQ : ThongTinKy
    {
        public GiayCamDoanLSATQTQ()
        {
            TableName = "GiayCamDoanLSATQTQ";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.GCDLSATQTQ;
            TenMauPhieu = DanhMucPhieu.GCDLSATQTQ.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }

        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }

        public string TenToiLa { get; set; }

        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }

        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string HoVaTen { get; set; }
        
        public DateTime? NgayVietDon { get; set; }
      
        public string TinhOrHuyen { get; set; }
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
    
    public class GiayCamDoanLSATQTQFunc
    {
        public const string TableName = "GiayCamDoanLSATQTQ";
        public const string TablePrimaryKeyName = "ID";
        public const string MaPhieu = "GCDLSATQTQ";

        public static List<GiayCamDoanLSATQTQ> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<GiayCamDoanLSATQTQ> list = new List<GiayCamDoanLSATQTQ>();
            try
            {
                string sql = @"SELECT * FROM GiayCamDoanLSATQTQ where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    GiayCamDoanLSATQTQ data = new GiayCamDoanLSATQTQ();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;

                    data.TenToiLa = DataReader["TenToiLa"].ToString();
                    data.NgayVietDon = DataReader["NgayVietDon"] == DBNull.Value ? (DateTime?)null : DataReader.GetDate("NgayVietDon");
                    data.DiaChi = DataReader["DiaChi"].ToString();
                    data.DienThoai = DataReader["DienThoai"].ToString();
                    data.Tuoi = DataReader["Tuoi"].ToString();
                    data.TinhOrHuyen = DataReader["TinhOrHuyen"].ToString();
                    data.HoVaTen = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.GioiTinh = DataReader["GioiTinh"].ToString(); 
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

        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref GiayCamDoanLSATQTQ bangKiem)
        {
            try
            {
                string sql = @"INSERT INTO GiayCamDoanLSATQTQ
                (
                    MAQUANLY,
                    TenToiLa,
                    Tuoi,
                    GioiTinh,
                    DiaChi,
                    DienThoai,
                    TinhOrHuyen,
                    NgayVietDon,
                    NgayTao,
                    NguoiTao,
                    NguoiSua,
                    NgaySua)  VALUES
                 (
				    :MAQUANLY,
                    :TenToiLa,
                    :Tuoi,
                    :GioiTinh,
                    :DiaChi,
                    :DienThoai,
                    :TinhOrHuyen,
                    :NgayVietDon,
                    :NgayTao,
                    :NguoiTao,
                    :NguoiSua,
                    :NgaySua
                 )  RETURNING ID INTO :ID";
                if (bangKiem.ID != 0)
                {
                    sql = @"UPDATE GiayCamDoanLSATQTQ SET 
                    MAQUANLY = :MAQUANLY,
					TenToiLa = :TenToiLa,
                    Tuoi = :Tuoi,
                    GioiTinh = :GioiTinh,
                    DiaChi = :DiaChi,
                    DienThoai = :DienThoai,
                    TinhOrHuyen = :TinhOrHuyen,
                    NgayVietDon = :NgayVietDon,
                    NguoiSua = :NguoiSua,
                    NgaySua = :NgaySua
                    WHERE ID = " + bangKiem.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangKiem.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("TenToiLa", bangKiem.TenToiLa));
                Command.Parameters.Add(new MDB.MDBParameter("Tuoi", bangKiem.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("GioiTinh", bangKiem.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", bangKiem.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("DienThoai", bangKiem.DienThoai));
                Command.Parameters.Add(new MDB.MDBParameter("TinhOrHuyen", bangKiem.TinhOrHuyen));
                Command.Parameters.Add(new MDB.MDBParameter("NgayVietDon", bangKiem.NgayVietDon));

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
                string sql = "DELETE FROM GiayCamDoanLSATQTQ WHERE ID = :ID";
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
                GiayCamDoanLSATQTQ B
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);

            var ds = new DataSet();

            adt.Fill(ds, "TB");
            ds.Tables[0].AddColumn("HoVaTen", typeof(string));

            ds.Tables[0].AddColumn("SOYTE", typeof(string));
            ds.Tables[0].AddColumn("BENHVIEN", typeof(string));


            ds.Tables[0].Rows[0]["HoVaTen"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;

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
