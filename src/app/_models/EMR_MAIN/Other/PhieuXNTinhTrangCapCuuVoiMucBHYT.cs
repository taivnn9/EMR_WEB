using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors.Filtering.Templates;
using EMR.KyDienTu;
using MDB;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuXNTinhTrangCapCuuVoiMucBHYT : ThongTinKy
    {
        public PhieuXNTinhTrangCapCuuVoiMucBHYT()
        {
            TableName = "PhieuXNTinhTrangCapCuuVoiMucBHYT";
            TablePrimaryKeyName = "ID";
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        public string HoTenNguoiNha { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string TuoiBN { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinhBN { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }
        [MoTaDuLieu("Buồng")]
		public string Buong { get; set; }
        [MoTaDuLieu("Giường")]
		public string Giuong { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public bool[] TinhTrangCapCuu_Array { get; } = new bool[] { true, false };
        public int TinhTrangCapCuu { get { return Array.IndexOf(TinhTrangCapCuu_Array, true); } set { for (int i = 0; i < 2; i++) { if (i == value) TinhTrangCapCuu_Array[i] = true; else { TinhTrangCapCuu_Array[i] = false; } } } }
        public string BacSiXacNhan { get; set; }
        public string MaBacSiXacNhan { get; set; }
        public bool[] GiayToChuyenVienArray { get; } = new bool[] { false, false, false, false, false };
        public string GiayToChuyenVien
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < GiayToChuyenVienArray.Length; i++)
                    temp += (GiayToChuyenVienArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        GiayToChuyenVienArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string GiayToKhac { get; set; }
        public bool[] MucHuongBHYT_Array { get; } = new bool[] { true, false };
        public int MucHuongBHYT { get { return Array.IndexOf(MucHuongBHYT_Array, true); } set { for (int i = 0; i < 2; i++) { if (i == value) MucHuongBHYT_Array[i] = true; else { MucHuongBHYT_Array[i] = false; } } } }
        public string BacSiTiepNhan { get; set; }
        public string MaBacSiTiepNhan { get; set; }
        public string BacSiTruongKhoa { get; set; }
        public string MaBacSiTruongKhoa { get; set; }

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
    public class PhieuXNTinhTrangCapCuuVoiMucBHYTFunc
    {
        public const string TableName = "PhieuXNTinhTrangCapCuuVoiMucBHYT";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuXNTinhTrangCapCuuVoiMucBHYT> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuXNTinhTrangCapCuuVoiMucBHYT> list = new List<PhieuXNTinhTrangCapCuuVoiMucBHYT>();
            try
            {

                string sql = @"SELECT * FROM PHIEUXNTTCAPCUUVOIMUCBHYT where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    try
                    {
                        PhieuXNTinhTrangCapCuuVoiMucBHYT data = new PhieuXNTinhTrangCapCuuVoiMucBHYT();
                        data.ID = DataReader.GetLong("ID");
                        data.MaQuanLy = Convert.ToDecimal(DataReader["MaQuanLy"].ToString());
                        data.MaBenhNhan = DataReader["MABENHNHAN"] != DBNull.Value ? DataReader["MABENHNHAN"].ToString() : "";
                        data.HoTenNguoiNha = DataReader["HoTenNguoiNha"] != DBNull.Value ? DataReader["HoTenNguoiNha"].ToString() : "";
                        data.TuoiBN = DataReader["TuoiBN"] != DBNull.Value ? DataReader["TuoiBN"].ToString() : "";
                        data.GioiTinhBN = DataReader["GioiTinhBN"] != DBNull.Value ? DataReader["GioiTinhBN"].ToString() : "";
                        data.ChanDoan = DataReader["ChanDoan"] != DBNull.Value ? DataReader["ChanDoan"].ToString() : "";
                        data.DiaChi = DataReader["DiaChi"] != DBNull.Value ? DataReader["DiaChi"].ToString() : "";
                        data.Khoa = DataReader["Khoa"] != DBNull.Value ? DataReader["Khoa"].ToString() : "";
                        data.MaKhoa = DataReader["MaKhoa"] != DBNull.Value ? DataReader["MaKhoa"].ToString() : "";
                        data.Buong = DataReader["Buong"] != DBNull.Value ? DataReader["Buong"].ToString() : "";
                        data.Giuong = DataReader["Giuong"] != DBNull.Value ? DataReader["Giuong"].ToString() : "";
                        data.TinhTrangCapCuu = DataReader["TTCapCuu"] != DBNull.Value ? int.Parse(DataReader["TTCapCuu"].ToString()) : 0;
                        data.BacSiXacNhan = DataReader["BacSiXacNhan"] != DBNull.Value ? DataReader["BacSiXacNhan"].ToString() : "";
                        data.MaBacSiXacNhan = DataReader["MaBacSiXacNhan"] != DBNull.Value ? DataReader["MaBacSiXacNhan"].ToString() : "";
                        data.GiayToChuyenVien = DataReader["GiayToChuyenVien"] != DBNull.Value ? DataReader["GiayToChuyenVien"].ToString() : "";
                        data.GiayToKhac = DataReader["GiayToKhac"] != DBNull.Value ? DataReader["GiayToKhac"].ToString() : "";
                        data.MucHuongBHYT = DataReader["MucHuongBHYT"] != DBNull.Value ? int.Parse(DataReader["MucHuongBHYT"].ToString()) : 0;
                        data.BacSiTiepNhan = DataReader["BacSiTiepNhan"] != DBNull.Value ? DataReader["BacSiTiepNhan"].ToString() : "";
                        data.MaBacSiTiepNhan = DataReader["MaBacSiTiepNhan"] != DBNull.Value ? DataReader["MaBacSiTiepNhan"].ToString() : "";
                        data.BacSiTruongKhoa = DataReader["BacSiTruongKhoa"] != DBNull.Value ? DataReader["BacSiTruongKhoa"].ToString() : "";
                        data.MaBacSiTruongKhoa = DataReader["MaBacSiTruongKhoa"] != DBNull.Value ? DataReader["MaBacSiTruongKhoa"].ToString() : "";
                        data.NgayTao = ConDB_DateTime(DataReader["NgayTao"]);
                        data.NgaySua = ConDB_DateTime(DataReader["NgaySua"]);
                        data.MaSoKy = DataReader.GetString("masokyten");
                        data.NgayKy = DataReader.GetDate("ngayky");
                        data.TenFileKy = DataReader.GetString("tenfileky");
                        data.UserNameKy = DataReader.GetString("usernameky");
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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuXNTinhTrangCapCuuVoiMucBHYT objData)
        {
            string sql;
            int n = 0;
            if (objData.ID == 0)
            {
                sql = @"INSERT INTO PHIEUXNTTCAPCUUVOIMUCBHYT (
		                                MaQuanLy,
		                                MaBenhNhan,
		                                HoTenNguoiNha,
		                                TuoiBN,
		                                GioiTinhBN,
                                        DiaChi,
		                                Khoa,
                                        MaKhoa,
                                        Buong,
                                        Giuong,
                                        ChanDoan,
                                        TTCapCuu,
                                        BacSiXacNhan ,
                                        MaBacSiXacNhan ,
                                        GiayToChuyenVien ,
                                        GiayToKhac ,
                                        MucHuongBHYT ,
                                        BacSiTiepNhan ,
                                        MaBacSiTiepNhan , 
                                        BacSiTruongKHoa ,
                                        MaBacSiTruongKhoa , 
                                        NgayTao ,
                                        NguoiTao 

                )
                VALUES
	             (
		        :MaQuanLy, :MaBenhNhan, :HoTenNguoiNha,:TuoiBN,:GioiTinhBN, :DiaChi, :Khoa, :MaKhoa,
		        :Buong, :Giuong, :ChanDoan, :TTCapCuu,
		        :BacSiXacNhan, :MaBacSiXacNhan, :GiayToChuyenVien, :GiayToKhac,
		        :MucHuongBHYT, :BacSiTiepNhan, :MaBacSiTiepNhan, :BacSiTruongKHoa, :MaBacSiTruongKhoa, :NgayTao, :NguoiTao
                ) RETURNING ID INTO :ID";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", objData.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", objData.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("HoTenNguoiNha", objData.HoTenNguoiNha));
                Command.Parameters.Add(new MDB.MDBParameter("TuoiBN", objData.TuoiBN));
                Command.Parameters.Add(new MDB.MDBParameter("GioiTinhBN", objData.GioiTinhBN));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", objData.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa", objData.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaKhoa", objData.MaKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("Buong", objData.Buong));
                Command.Parameters.Add(new MDB.MDBParameter("Giuong", objData.Giuong));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", objData.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("TTCapCuu", objData.TinhTrangCapCuu));
                Command.Parameters.Add(new MDB.MDBParameter("BacSiXacNhan", objData.BacSiXacNhan));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSiXacNhan", objData.MaBacSiXacNhan));
                Command.Parameters.Add(new MDB.MDBParameter("GiayToChuyenVien", objData.GiayToChuyenVien));
                Command.Parameters.Add(new MDB.MDBParameter("GiayToKhac", objData.GiayToKhac));
                Command.Parameters.Add(new MDB.MDBParameter("MucHuongBHYT", objData.MucHuongBHYT));
                Command.Parameters.Add(new MDB.MDBParameter("BacSiTiepNhan", objData.BacSiTiepNhan));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSiTiepNhan", objData.MaBacSiTiepNhan));
                Command.Parameters.Add(new MDB.MDBParameter("BacSiTruongKHoa", objData.BacSiTruongKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSiTruongKhoa", objData.MaBacSiTruongKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("ID", objData.ID));
                Command.Parameters.Add(new MDB.MDBParameter("NgayTao", DateTime.Now));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiTao", Common.getUserLogin()));

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
                sql = @"UPDATE PHIEUXNTTCAPCUUVOIMUCBHYT SET 
                                        MaQuanLy=:MaQuanLy,
		                                MaBenhNhan=:MaBenhNhan,
		                                HoTenNguoiNha=:HoTenNguoiNha,
		                                TuoiBN=:TuoiBN,
		                                GioiTinhBN=:GioiTinhBN,
                                        DiaChi=:DiaChi,
		                                Khoa=:Khoa,
                                        MaKhoa=:MaKhoa,
                                        Buong=:Buong,
                                        Giuong=:Giuong,
                                        ChanDoan=:ChanDoan,
                                        TTCapCuu=:TTCapCuu,
                                        BacSiXacNhan=:BacSiXacNhan ,
                                        MaBacSiXacNhan=:MaBacSiXacNhan ,
                                        GiayToChuyenVien=:GiayToChuyenVien ,
                                        GiayToKhac =:GiayToKhac,
                                        MucHuongBHYT =:MucHuongBHYT,
                                        BacSiTiepNhan =:BacSiTiepNhan,
                                        MaBacSiTiepNhan =:MaBacSiTiepNhan, 
                                        BacSiTruongKHoa =:BacSiTruongKHoa,
                                        MaBacSiTruongKhoa =:MaBacSiTruongKhoa, 
                                        NgaySua=:NgaySua ,
                                        NguoiSua=:NguoiSua 
                                        WHERE ID = :IDPhieu";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", objData.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", objData.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("HoTenNguoiNha", objData.HoTenNguoiNha));
                Command.Parameters.Add(new MDB.MDBParameter("TuoiBN", objData.TuoiBN));
                Command.Parameters.Add(new MDB.MDBParameter("GioiTinhBN", objData.GioiTinhBN));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", objData.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa", objData.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaKhoa", objData.MaKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("Buong", objData.Buong));
                Command.Parameters.Add(new MDB.MDBParameter("Giuong", objData.Giuong));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", objData.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("TTCapCuu", objData.TinhTrangCapCuu));
                Command.Parameters.Add(new MDB.MDBParameter("BacSiXacNhan", objData.BacSiXacNhan));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSiXacNhan", objData.MaBacSiXacNhan));
                Command.Parameters.Add(new MDB.MDBParameter("GiayToChuyenVien", objData.GiayToChuyenVien));
                Command.Parameters.Add(new MDB.MDBParameter("GiayToKhac", objData.GiayToKhac));
                Command.Parameters.Add(new MDB.MDBParameter("MucHuongBHYT", objData.MucHuongBHYT));
                Command.Parameters.Add(new MDB.MDBParameter("BacSiTiepNhan", objData.BacSiTiepNhan));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSiTiepNhan", objData.MaBacSiTiepNhan));
                Command.Parameters.Add(new MDB.MDBParameter("BacSiTruongKHoa", objData.BacSiTruongKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSiTruongKhoa", objData.MaBacSiTruongKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("NgaySua", DateTime.Now));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiSua", Common.getUserLogin()));
                Command.Parameters.Add(new MDB.MDBParameter("IDPhieu", objData.ID));
                Command.BindByName = true;
                n = Command.ExecuteNonQuery();

            }


            return n > 0 ? true : false;
        }

        public static bool Delete(MDB.MDBConnection MyConnection, decimal idPhieu)
        {
            string sql = "DELETE FROM PHIEUXNTTCAPCUUVOIMUCBHYT WHERE ID = :idPhieu";
            MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
            command.Parameters.Add(new MDB.MDBParameter("idPhieu", idPhieu));
            command.BindByName = true;
            int n = command.ExecuteNonQuery();
            return n > 0 ? true : false;
        }
        public static PhieuXNTinhTrangCapCuuVoiMucBHYT GetData(MDB.MDBConnection _OracleConnection, decimal id)
        {
            try
            {
                string sql = @"SELECT * FROM PHIEUXNTTCAPCUUVOIMUCBHYT where ID = :ID";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID", id));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    try
                    {
                        PhieuXNTinhTrangCapCuuVoiMucBHYT data = new PhieuXNTinhTrangCapCuuVoiMucBHYT();
                        data.ID = DataReader.GetLong("ID");
                        data.MaQuanLy = Convert.ToDecimal(DataReader["MaQuanLy"].ToString());
                        data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                        data.HoTenNguoiNha = DataReader["HoTenNguoiNha"].ToString();
                        data.TuoiBN = DataReader["TuoiBN"].ToString();
                        data.GioiTinhBN = DataReader["GioiTinhBN"].ToString();
                        data.ChanDoan = DataReader["ChanDoan"].ToString();
                        data.DiaChi = DataReader["DiaChi"].ToString();
                        data.Khoa = DataReader["Khoa"].ToString();
                        data.MaKhoa = DataReader["MaKhoa"].ToString();
                        data.Buong = DataReader["Buong"].ToString();
                        data.Giuong = DataReader["Giuong"].ToString();
                        data.TinhTrangCapCuu = DataReader.GetInt("TTCapCuu");
                        data.BacSiXacNhan = DataReader["BacSiXacNhan"].ToString();
                        data.MaBacSiXacNhan = DataReader["MaBacSiXacNhan "].ToString();
                        data.GiayToChuyenVien = DataReader["GiayToChuyenVien"].ToString();
                        data.GiayToKhac = DataReader["GiayToKhac"].ToString();
                        data.MucHuongBHYT = DataReader.GetInt("MucHuongBHYT");
                        data.BacSiTiepNhan = DataReader["BacSiTiepNhan"].ToString();
                        data.MaBacSiTiepNhan = DataReader["MaBacSiTiepNhan"].ToString();
                        data.BacSiTruongKhoa = DataReader["BacSiTruongKhoa"].ToString();
                        data.MaBacSiTruongKhoa = DataReader["MaBacSiTruongKhoa"].ToString();
                        data.MaSoKy = DataReader.GetString("masokyten");
                        data.NgayKy = DataReader.GetDate("ngayky");
                        data.TenFileKy = DataReader.GetString("tenfileky");
                        data.UserNameKy = DataReader.GetString("usernameky");
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
                D.*,
	            T.MABENHNHAN,
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
                PHIEUXNTTCAPCUUVOIMUCBHYT D
                LEFT JOIN THONGTINDIEUTRI T ON D.MAQUANLY = T.MAQUANLY
                LEFT JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
            WHERE
                ID = :ID";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql2, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("ID", idPhieu));

            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            adt.Fill(ds, "BK");
            return ds;
        }
    }
}
