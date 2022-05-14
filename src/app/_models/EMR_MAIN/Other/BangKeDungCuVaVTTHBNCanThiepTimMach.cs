using EMR.KyDienTu;
using MDB;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class BangKeDungCuVaVTTHBNCanThiepTimMach : ThongTinKy
    {
        public BangKeDungCuVaVTTHBNCanThiepTimMach()
        {
            TableName = "BANGKEDCVAVTTHBNCTTIMMACH";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BKDCVTTHBNCTTM;
            TenMauPhieu = DanhMucPhieu.BKDCVTTHBNCTTM.Description();
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
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Thủ thuật")]
        public string ThuThuat { get; set; }
        [MoTaDuLieu("Ngày làm thủ thuật")]
        public DateTime NgayLamThuThuat { get; set; }
        
        public ObservableCollection<ThuocVatTu> ThuocVatTus { get; set; }
        [MoTaDuLieu("Mã bác sĩ làm thủ thuật")]
        public string MaNVBacSyLamThuThuat { get; set; }
        [MoTaDuLieu("Họ tên bác sĩ làm thủ thuật")]
        public string BacSyLamThuThuat { get; set; }
        [MoTaDuLieu("Mã nhân viên thống kê")]
        public string MaNVThongKe { get; set; }
        [MoTaDuLieu("Họ tên người tạo thống kê")]
        public string NguoiThongKe { get; set; }

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
    public class BangKeDungCuVaVTTHBNCanThiepTimMachFunc
    {
        public const string TableName = "BANGKEDCVAVTTHBNCTTIMMACH";
        public const string TablePrimaryKeyName = "ID";
        public static List<BangKeDungCuVaVTTHBNCanThiepTimMach> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BangKeDungCuVaVTTHBNCanThiepTimMach> list = new List<BangKeDungCuVaVTTHBNCanThiepTimMach>();
            try
            {

                string sql = @"SELECT * FROM BANGKEDCVAVTTHBNCTTIMMACH where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    try
                    {
                        BangKeDungCuVaVTTHBNCanThiepTimMach data = new BangKeDungCuVaVTTHBNCanThiepTimMach();
                        data.ID = DataReader.GetLong("ID");
                        data.MaQuanLy = Convert.ToDecimal(DataReader["MaQuanLy"].ToString());
                        data.MaBenhNhan = DataReader["MABENHNHAN"] != DBNull.Value ? DataReader["MABENHNHAN"].ToString():"";
                        data.TenBenhNhan = DataReader["TenBenhNhan"] != DBNull.Value ? DataReader["TenBenhNhan"].ToString() : ""; 
                        data.Tuoi = DataReader["Tuoi"] != DBNull.Value ? DataReader["Tuoi"].ToString() : "";
                        data.GioiTinh = DataReader["GioiTinh"] != DBNull.Value ? DataReader["GioiTinh"].ToString() : "";
                        data.ChanDoan = DataReader["ChanDoan"] != DBNull.Value ? DataReader["ChanDoan"].ToString() : "";
                        data.ThuThuat = DataReader["ThuThuat"] != DBNull.Value ? DataReader["ThuThuat"].ToString() : "";
                        data.NgayLamThuThuat = ConDB_DateTime(DataReader["NgayLamThuThuat"]);

                        string bangKeJson = DataReader["ThuocVatTus_1"].ToString();
                        if (DataReader["ThuocVatTus_2"] != DBNull.Value)
                            bangKeJson += DataReader["BangKe_2"].ToString();
                        data.ThuocVatTus = JsonConvert.DeserializeObject<ObservableCollection<ThuocVatTu>>(bangKeJson);


                        data.MaNVBacSyLamThuThuat = DataReader["MaNVBacSyLamThuThuat"] != DBNull.Value ? DataReader["MaNVBacSyLamThuThuat"].ToString() : "";
                        data.BacSyLamThuThuat = DataReader.GetString("BacSyLamThuThuat");
                        data.MaNVThongKe = DataReader["MaNVThongKe"] != DBNull.Value ? DataReader["MaNVThongKe"].ToString() : "";
                        data.NguoiThongKe = DataReader.GetString("NguoiThongKe");

                        data.NguoiTao = DataReader.GetString("NguoiTao");
                        data.NguoiSua = DataReader.GetString("NguoiSua");
                        data.NgayTao = ConDB_DateTime(DataReader["NgayTao"]);
                        data.NgaySua = ConDB_DateTime(DataReader["NgaySua"]);
                        data.MaSoKy = DataReader.GetString("masokyten");
                        data.NgayKy = DataReader.GetDate("ngayky");
                        data.TenFileKy = DataReader.GetString("tenfileky");
                        data.UserNameKy = DataReader.GetString("usernameky");
                        data.ComputerKyTen = DataReader.GetString("COMPUTERKYTEN");

                        list.Add(data);
                    }
                    catch (Exception ex)
                    {
                        MDB.ExceptionExtend.LogError(ex);
                    }
                }
                DataReader.Close();
                DataReader = null;
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BangKeDungCuVaVTTHBNCanThiepTimMach objData)
        {
            string sql;
            int n = 0;
            if (objData.ID == 0)
            {
                sql = @"INSERT INTO bangkedcvavtthbncttimmach (
                                    maquanly,
                                    mabenhnhan,
                                    tenbenhnhan,
                                    tuoi,
                                    GioiTinh,
                                    ChanDoan,
                                    ThuThuat,
                                    NgayLamThuThuat,
                                    ThuocVatTus_1,
                                    ThuocVatTus_2,
                                    MaNVBacSyLamThuThuat,
                                    BacSyLamThuThuat,
                                    MaNVThongKe,
                                    NguoiThongKe,
                                    nguoitao,
                                    ngaytao
                                ) VALUES (
                                    :maquanly,
                                    :mabenhnhan,
                                    :tenbenhnhan,
                                    :tuoi,
                                    :GioiTinh,
                                    :ChanDoan,
                                    :ThuThuat,
                                    :NgayLamThuThuat,
                                    :ThuocVatTus_1,
                                    :ThuocVatTus_2,
                                    :MaNVBacSyLamThuThuat,
                                    :BacSyLamThuThuat,
                                    :MaNVThongKe,
                                    :NguoiThongKe,
                                    :nguoitao,
                                    :ngaytao
                                ) RETURNING ID INTO :ID";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("maquanly", objData.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("mabenhnhan", objData.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("tenbenhnhan", objData.TenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("tuoi", objData.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("GioiTinh", objData.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", objData.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("ThuThuat", objData.ThuThuat));
                Command.Parameters.Add(new MDB.MDBParameter("NgayLamThuThuat", objData.NgayLamThuThuat));
                string jsonBangKes = JsonConvert.SerializeObject(objData.ThuocVatTus);
                List<string> listJson = new List<string>();
                for (int i = 0; i < jsonBangKes.Length; i += 3999)
                {
                    if ((i + 3999) < jsonBangKes.Length)
                        listJson.Add(jsonBangKes.Substring(i, 3999));
                    else
                        listJson.Add(jsonBangKes.Substring(i));
                }
                Command.Parameters.Add(new MDB.MDBParameter("ThuocVatTus_1", listJson[0]));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocVatTus_2", listJson.Count > 1 ? listJson[1] : null));
                Command.Parameters.Add(new MDB.MDBParameter("MaNVBacSyLamThuThuat", objData.MaNVBacSyLamThuThuat));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyLamThuThuat", objData.BacSyLamThuThuat));
                Command.Parameters.Add(new MDB.MDBParameter("MaNVThongKe", objData.MaNVThongKe));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiThongKe", objData.NguoiThongKe));
                Command.Parameters.Add(new MDB.MDBParameter("ID", objData.ID));
                Command.Parameters.Add(new MDB.MDBParameter("nguoitao", objData.NguoiTao));
                Command.Parameters.Add(new MDB.MDBParameter("ngaytao", objData.NgayTao));

                Command.BindByName = true;
                n = Command.ExecuteNonQuery();

                if (n > 0)
                {
                    if (objData.ID == 0)
                    {
                        long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                        objData.ID = nextval;
                    }
                }
            }

            else
            {
                sql = @"UPDATE bangkedcvavtthbncttimmach SET  
                                         maquanly = :maquanly,
                                         mabenhnhan = :mabenhnhan,
                                         tenbenhnhan = :tenbenhnhan,
                                         tuoi = :tuoi,
                                         GioiTinh = :GioiTinh,
                                         ChanDoan = :ChanDoan,
                                         ThuThuat = :ThuThuat,
                                         NgayLamThuThuat = :NgayLamThuThuat,
                                         ThuocVatTus_1 = :ThuocVatTus_1,
                                         ThuocVatTus_2 = :ThuocVatTus_2,
                                         MaNVBacSyLamThuThuat = :MaNVBacSyLamThuThuat,
                                         BacSyLamThuThuat = :BacSyLamThuThuat,
                                         MaNVThongKe = :MaNVThongKe,
                                         NguoiThongKe = :NguoiThongKe,
                                         nguoisua = :nguoisua,
                                         ngaysua = :ngaysua 
                                        WHERE ID = :IDPhieu";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("maquanly", objData.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("mabenhnhan", objData.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("tenbenhnhan", objData.TenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("tuoi", objData.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("GioiTinh", objData.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", objData.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("ThuThuat", objData.ThuThuat));
                Command.Parameters.Add(new MDB.MDBParameter("NgayLamThuThuat", objData.NgayLamThuThuat));
                string jsonBangKes = JsonConvert.SerializeObject(objData.ThuocVatTus);
                List<string> listJson = new List<string>();
                for (int i = 0; i < jsonBangKes.Length; i += 3999)
                {
                    if ((i + 3999) < jsonBangKes.Length)
                        listJson.Add(jsonBangKes.Substring(i, 3999));
                    else
                        listJson.Add(jsonBangKes.Substring(i));
                }
                Command.Parameters.Add(new MDB.MDBParameter("ThuocVatTus_1", listJson[0]));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocVatTus_2", listJson.Count > 1 ? listJson[1] : null));
                Command.Parameters.Add(new MDB.MDBParameter("MaNVBacSyLamThuThuat", objData.MaNVBacSyLamThuThuat));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyLamThuThuat", objData.BacSyLamThuThuat));
                Command.Parameters.Add(new MDB.MDBParameter("MaNVThongKe", objData.MaNVThongKe));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiThongKe", objData.NguoiThongKe));
                Command.Parameters.Add(new MDB.MDBParameter("nguoisua", objData.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("ngaysua", objData.NgaySua));
                Command.Parameters.Add(new MDB.MDBParameter("IDPhieu", objData.ID));
                Command.BindByName = true;
                n = Command.ExecuteNonQuery();

            }


            return n > 0 ? true : false;
        }

        public static bool Delete(MDB.MDBConnection MyConnection, decimal idPhieu)
        {
            string sql = "DELETE FROM bangkedcvavtthbncttimmach WHERE ID = :idPhieu";
            MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
            command.Parameters.Add(new MDB.MDBParameter("idPhieu", idPhieu));
            command.BindByName = true;
            int n = command.ExecuteNonQuery();
            return n > 0 ? true : false;
        }
        public static BangKeDungCuVaVTTHBNCanThiepTimMach GetData(MDB.MDBConnection _OracleConnection, decimal id)
        {
            try
            {
                string sql = @"SELECT * FROM bangkedcvavtthbncttimmach where ID = :ID";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID", id));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    try
                    {
                        BangKeDungCuVaVTTHBNCanThiepTimMach data = new BangKeDungCuVaVTTHBNCanThiepTimMach();
                        data.ID = DataReader.GetLong("ID");
                        data.MaQuanLy = Convert.ToDecimal(DataReader["MaQuanLy"].ToString());
                        data.MaBenhNhan = DataReader["MABENHNHAN"] != DBNull.Value ? DataReader["MABENHNHAN"].ToString() : "";
                        data.TenBenhNhan = DataReader["TenBenhNhan"] != DBNull.Value ? DataReader["TenBenhNhan"].ToString() : "";
                        data.Tuoi = DataReader["Tuoi"] != DBNull.Value ? DataReader["Tuoi"].ToString() : "";
                        data.GioiTinh = DataReader["GioiTinh"] != DBNull.Value ? DataReader["GioiTinh"].ToString() : "";
                        data.ChanDoan = DataReader["ChanDoan"] != DBNull.Value ? DataReader["ChanDoan"].ToString() : "";
                        data.ThuThuat = DataReader["ThuThuat"] != DBNull.Value ? DataReader["ThuThuat"].ToString() : "";
                        data.NgayLamThuThuat = ConDB_DateTime(DataReader["NgayLamThuThuat"]);

                        string bangKeJson = DataReader["ThuocVatTus_1"].ToString();
                        if (DataReader["ThuocVatTus_2"] != DBNull.Value)
                            bangKeJson += DataReader["BangKe_2"].ToString();
                        data.ThuocVatTus = JsonConvert.DeserializeObject<ObservableCollection<ThuocVatTu>>(bangKeJson);

                        data.MaNVBacSyLamThuThuat = DataReader["MaNVBacSyLamThuThuat"] != DBNull.Value ? DataReader["MaNVBacSyLamThuThuat"].ToString() : "";
                        data.BacSyLamThuThuat = DataReader.GetString("BacSyLamThuThuat");
                        data.MaNVThongKe = DataReader["MaNVThongKe"] != DBNull.Value ? DataReader["MaNVThongKe"].ToString() : "";
                        data.NguoiThongKe = DataReader.GetString("NguoiThongKe");

                        data.NguoiTao = DataReader.GetString("NguoiTao");
                        data.NguoiSua = DataReader.GetString("NguoiSua");
                        data.NgayTao = ConDB_DateTime(DataReader["NgayTao"]);
                        data.NgaySua = ConDB_DateTime(DataReader["NgaySua"]);
                        data.MaSoKy = DataReader.GetString("masokyten");
                        data.NgayKy = DataReader.GetDate("ngayky");
                        data.TenFileKy = DataReader.GetString("tenfileky");
                        data.UserNameKy = DataReader.GetString("usernameky");
                        data.ComputerKyTen = DataReader.GetString("COMPUTERKYTEN");

                        return data;
                    }
                    catch (Exception ex)
                    {
                        MDB.ExceptionExtend.LogError(ex);
                    }
                }
                DataReader.Close();
                DataReader = null;
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return null;
        }
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, decimal idPhieu)
        {
            string sql2 = @"SELECT
                D.ChanDoan,
                D.ThuThuat,
                D.NgayLamThuThuat,
                D.MaNVBacSyLamThuThuat,
                D.BacSyLamThuThuat,
                D.MaNVThongKe,
                D.NguoiThongKe,
                D.nguoitao,
                D.NgayTao,
                D.NguoiSua,
                D.NgaySua,
	            T.MABENHNHAN,
                T.MaBenhAn,
	            T.KHOA,
	            T.GIUONG,
                T.BUONG,
	            T.NGAYVAOVIEN,
	            H.SOYTE,
	            H.BENHVIEN,
	            H.MABENHNHAN,
	            H.TENBENHNHAN,
	            H.TUOI,
	            H.GIOITINH
            FROM
                bangkedcvavtthbncttimmach D
                LEFT JOIN THONGTINDIEUTRI T ON D.MAQUANLY = T.MAQUANLY
                LEFT JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
            WHERE
                ID = :ID";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql2, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("ID", idPhieu));

            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            adt.Fill(ds,"BK");

            string sql = @"SELECT
               D.ThuocVatTus_1,
               D.ThuocVatTus_2
            FROM
                bangkedcvavtthbncttimmach D
            WHERE
                ID = :ID";
            Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("ID", idPhieu));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            ObservableCollection<ThuocVatTu> lstThuocVatTu = new ObservableCollection<ThuocVatTu>(); 
            while (DataReader.Read())
            {
                try
                {
                    string bangKeJson = DataReader["ThuocVatTus_1"].ToString();
                    if (DataReader["ThuocVatTus_2"] != DBNull.Value)
                        bangKeJson += DataReader["BangKe_2"].ToString();
                    lstThuocVatTu = JsonConvert.DeserializeObject<ObservableCollection<ThuocVatTu>>(bangKeJson);
                    break;
                }
                catch (Exception ex)
                {
                    MDB.ExceptionExtend.LogError(ex);
                }
            }
            DataTable ChiTiet = new DataTable("TVT");
            ChiTiet.Columns.Add("TenThuocVatTu");
            ChiTiet.Columns.Add("DonVi");
            ChiTiet.Columns.Add("SoLuong");
            ChiTiet.Columns.Add("HangSanXuat");
            ChiTiet.Columns.Add("GhiChu");


            foreach (ThuocVatTu thuocVatTu in lstThuocVatTu)
            {
                ChiTiet.Rows.Add(thuocVatTu.TenThuocVatTu, thuocVatTu.DonVi, thuocVatTu.SoLuong, thuocVatTu.HangSanXuat, thuocVatTu.GhiChu);
            }
            ds.Tables.Add(ChiTiet);
            return ds;
        }
    }
}
