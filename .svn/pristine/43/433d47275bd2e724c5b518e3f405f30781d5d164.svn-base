using EMR.KyDienTu;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuCongKhaiCheDoAn : ThongTinKy
    {
        public PhieuCongKhaiCheDoAn()
        {
            TableName = "PhieuCongKhaiCheDoAn";
            TablePrimaryKeyName = "ID";
            TTChiTiet = new ObservableCollection<ThongTinChiTiet>();
            IDMauPhieu = (int)DanhMucPhieu.PCKCDA;
            TenMauPhieu = DanhMucPhieu.PCKCDA.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        [MoTaDuLieu("Buồng")]
		public string Buong { get; set; }
        [MoTaDuLieu("Giường")]
		public string Giuong { get; set; }
        [MoTaDuLieu("Bệnh viện")]
		public string BenhVien { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        public string SoYte { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh vào viện")]
		public string ChanDoanVaoVien { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh ra viện")]
		public string ChanDoanRaVien { get; set; }
        public DateTime? NgayNhapVien { get; set; }
        public DateTime? NgayRaVien { get; set; }
        public string ListNgayCheDoAn { get; set; }
        public int CheDoAn_Thang { get; set; }
        public ObservableCollection<ThongTinChiTiet> TTChiTiet { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
    }
    public class ThongTinChiTiet : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        public string MaCheDoAn { get; set; }
        private int _count = 0;
        private int[] _templist;
        public int[] NgayCheDoAnArray { get { UpdateTongSo(_templist); return _templist; } set { _templist = value;} }
        public int TongSo { get { return _count; } }
        public string DonGia { set; get; }
        public string ThanhTien { set; get; }
        public ThongTinChiTiet()
        {
            NgayCheDoAnArray = new int[31];
        }
        private void UpdateTongSo(int[] _temp)
        {
            _count = 0;
            if (_temp!=null && _temp.Length > 0)
            {
                for(int i = 0; i < _temp.Length; i++)
                {
                    if(_temp[i]==1)
                    _count++;
                }
            }
            OnPropertyChanged("TongSo");
        }
    }
    public class PhieuCongKhaiCheDoAnFunc
    {
        public const string TableName = "PhieuCongKhaiCheDoAn";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuCongKhaiCheDoAn> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly, decimal id = -1)
        {
            List<PhieuCongKhaiCheDoAn> list = new List<PhieuCongKhaiCheDoAn>();
            try
            {
                string sql = @"SELECT * FROM PhieuCongKhaiCheDoAn where MaQuanLy = :MaQuanLy";
                if(id != -1)
                {
                    sql = sql + " And id = " + id.ToString();
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuCongKhaiCheDoAn data = new PhieuCongKhaiCheDoAn();
                    data.ID = DataReader.GetLong("ID");
                    data.MaQuanLy = Convert.ToDecimal(DataReader["MaQuanLy"].ToString());
                    data.MaBenhNhan = DataReader["MaBenhNhan"] != DBNull.Value ? DataReader["MaBenhNhan"].ToString() : "";
                    data.TenBenhNhan = DataReader.GetString("TenBenhNhan");
                    data.Tuoi = DataReader.GetString("Tuoi");
                    data.GioiTinh = DataReader.GetString("GioiTinh");

                    data.DiaChi = DataReader.GetString("DiaChi");
                    data.Buong = DataReader.GetString("Buong");
                    data.Giuong = DataReader.GetString("Giuong");
                    data.ChanDoanVaoVien = DataReader.GetString("ChanDoanVaoVien");
                    data.NgayNhapVien = Common.ConDB_DateTimeNull(DataReader["NgayNhapVien"]);
                    data.NgayRaVien = Common.ConDB_DateTimeNull(DataReader["NgayRaVien"]);
                    data.ChanDoanRaVien = DataReader.GetString("ChanDoanRaVien");
                    data.ListNgayCheDoAn = DataReader.GetString("ListNgayCheDoAn");
                    data.TTChiTiet = JsonConvert.DeserializeObject<ObservableCollection<ThongTinChiTiet>>(DataReader.GetString("ThongTinChiTiet"));
                    data.CheDoAn_Thang = DataReader.GetInt("CheDoAn_Thang");

                    data.NgayTao = ConDB_DateTime(DataReader["NgayTao"]);
                    data.NgaySua = ConDB_DateTime(DataReader["NgaySua"]);
                    data.MaSoKy = DataReader.GetString("masokyten");
                    data.NgayKy = DataReader.GetDate("ngayky");
                    data.TenFileKy = DataReader.GetString("tenfileky");
                    data.UserNameKy = DataReader.GetString("usernameky");
                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuCongKhaiCheDoAn objData)
        {
            try
            {
                string sql = @"INSERT INTO PhieuCongKhaiCheDoAn
                (
                    maquanly,
                    mabenhnhan,
                    tenbenhnhan,
                    tuoi,
                    gioitinh,
                    diachi,
                    buong,
                    giuong,
                    chandoanvaovien,
                    NgayNhapVien,
                    NgayRaVien,
                    chandoanravien,
                    listngaychedoan,
                    thongtinchitiet,
                    chedoan_thang,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
	                :MaBenhNhan,
	                :tenbenhnhan,
	                :tuoi,
	                :gioitinh,
	                :diachi,
	                :buong,
	                :giuong,
	                :chandoanvaovien,
                    :NgayNhapVien,
                    :NgayRaVien,
	                :chandoanravien,
	                :listngaychedoan,
	                :thongtinchitiet,
                    :chedoan_thang,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (objData.ID != 0)
                {
                    sql = @"UPDATE PhieuCongKhaiCheDoAn SET 
                    maquanly=:maquanly,
                    mabenhnhan=:mabenhnhan,
                    tenbenhnhan=:tenbenhnhan,
                    tuoi=:tuoi,
                    gioitinh=:gioitinh,
                    diachi=:diachi,
                    buong=:buong,
                    giuong=:giuong,
                    chandoanvaovien=:chandoanvaovien,
                    NgayNhapVien=:NgayNhapVien,
                    NgayRaVien=:NgayRaVien,
                    chandoanravien=:chandoanravien,
                    listngaychedoan=:listngaychedoan,
                    thongtinchitiet=:thongtinchitiet,
                    chedoan_thang=:chedoan_thang,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = :IDPhieu ";
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("maquanly", objData.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("mabenhnhan", objData.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("tenbenhnhan", objData.TenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("tuoi", objData.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("gioitinh", objData.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("diachi", objData.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("buong", objData.Buong));
                Command.Parameters.Add(new MDB.MDBParameter("giuong", objData.Giuong));
                Command.Parameters.Add(new MDB.MDBParameter("chandoanvaovien", objData.ChanDoanVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("NgayNhapVien", objData.NgayNhapVien));
                Command.Parameters.Add(new MDB.MDBParameter("NgayRaVien", objData.NgayRaVien));
                Command.Parameters.Add(new MDB.MDBParameter("chandoanravien", objData.ChanDoanRaVien));
                Command.Parameters.Add(new MDB.MDBParameter("listngaychedoan", objData.ListNgayCheDoAn));
                Command.Parameters.Add(new MDB.MDBParameter("thongtinchitiet", JsonConvert.SerializeObject(objData.TTChiTiet)));
                Command.Parameters.Add(new MDB.MDBParameter("chedoan_thang", objData.CheDoAn_Thang));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", objData.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", objData.NgaySua));
                if (objData.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", objData.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", objData.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", objData.NgayTao));
                }
                else
                {
                    Command.Parameters.Add(new MDB.MDBParameter("IDPhieu", objData.ID));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (objData.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    objData.ID = nextval;
                }
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool delete(MDB.MDBConnection oracleConnection, List<decimal> lstIDbienBan)
        {
            try
            {
                string sql = "";
                string strWhere = "";
                MDB.MDBCommand oracleCommand;
                strWhere = " ID In(";
                if (lstIDbienBan.Count > 0)
                {
                    for (int i = 0; i < lstIDbienBan.Count; i++)
                    {
                        strWhere = strWhere + lstIDbienBan[i].ToString();
                        if (i == (lstIDbienBan.Count - 1))
                        {
                            strWhere = strWhere + ")";
                        }
                        else
                        {
                            strWhere = strWhere + ",";
                        }
                    }
                }
                sql = @"DELETE FROM PhieuCongKhaiCheDoAn WHERE  " + strWhere;
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
        public static DataSet getDataSet(MDB.MDBConnection MyConnection, long id)
        {
            string sql = @"SELECT
                B.*,
                H.NGAYSINH,
                T.KHOA, H.SoYTe
            FROM
                PhieuCongKhaiCheDoAn B
                LEFT JOIN THONGTINDIEUTRI T ON B.MAQUANLY = T.MAQUANLY
                LEFT JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
            WHERE
                ID = :ID";

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("ID", id));
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "BK");

            //sql = @"SELECT
            //    B.ThongTinChiTiet
            //FROM
            //    PhieuCongKhaiCheDoAn B
                
            //WHERE
            //    ID = :ID";

            //Command = new MDB.MDBCommand(sql, MyConnection);
            //Command.Parameters.Add(new MDB.MDBParameter("ID", id));
            //MDB.MDBDataReader DataReader = Command.ExecuteReader();
            //ObservableCollection<ThongTinChiTiet> ttchitiet = new ObservableCollection<ThongTinChiTiet>();
            //while (DataReader.Read())
            //{
            //    ttchitiet = JsonConvert.DeserializeObject<ObservableCollection<ThongTinChiTiet>>(DataReader["ThongTinChiTiet"].ToString());
            //    break;
            //}
            //DataTable BK2 = new DataTable("BK2");
            //BK2.Columns.Add("ThongTinChiTiet");
            //BK2.Rows.Add(ttchitiet);

            //ds.Tables.Add(BK2);

            return ds;
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
