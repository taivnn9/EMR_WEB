using EMR.KyDienTu;
using MDB;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class DonXinDamBaoBenhNhanTamThan : ThongTinKy
    {
        public DonXinDamBaoBenhNhanTamThan()
        {
            TableName = "DonXinDamBaoBenhNhanTamThan";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.DXDBBNTT;
            TenMauPhieu = DanhMucPhieu.DXDBBNTT.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        public string TenNguoiBenh { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string TuoiNguoiBenh { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinhNguoiBenh { get; set; }
        public string BiBenh { get; set; }
        public string NhungBieuHienTaiNha { get; set; }
        public DateTime TuNgay { get; set; }

        public string TenNguoiLamDon { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string TuoiNguoiLamDon { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinhNguoiLamDon { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChiNguoiLamDon { get; set; }
        public string QuanHeVoiNguoiBenh { get; set; }

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
    public class DonXinDamBaoBenhNhanTamThanFunc
    {
        public const string TableName = "DonXinDamBaoBenhNhanTamThan";
        public const string TablePrimaryKeyName = "ID";
        public static List<DonXinDamBaoBenhNhanTamThan> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<DonXinDamBaoBenhNhanTamThan> list = new List<DonXinDamBaoBenhNhanTamThan>();
            try
            {

                string sql = @"SELECT * FROM DonXinDamBaoBenhNhanTamThan where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    try
                    {
                        DonXinDamBaoBenhNhanTamThan data = new DonXinDamBaoBenhNhanTamThan();
                        data.ID = DataReader.GetLong("ID");
                        data.MaQuanLy = maquanly;
                        data.MaBenhNhan = XemBenhAn._HanhChinhBenhNhan.MaBenhNhan;
                        data.TenNguoiBenh = DataReader["TenNguoiBenh"] != DBNull.Value ? DataReader["TenNguoiBenh"].ToString() : ""; 
                        data.TuoiNguoiBenh = DataReader["TuoiNguoiBenh"] != DBNull.Value ? DataReader["TuoiNguoiBenh"].ToString() : "";
                        data.GioiTinhNguoiBenh = DataReader["GioiTinhNguoiBenh"] != DBNull.Value ? DataReader["GioiTinhNguoiBenh"].ToString() : "";
                        data.NhungBieuHienTaiNha = DataReader["NhungBieuHienTaiNha"] != DBNull.Value ? DataReader["NhungBieuHienTaiNha"].ToString() : "";
                        data.TuNgay = ConDB_DateTime(DataReader["TuNgay"]);

                        data.TenNguoiLamDon = DataReader["TenNguoiLamDon"] != DBNull.Value ? DataReader["TenNguoiLamDon"].ToString() : "";
                        data.BiBenh = DataReader["BiBenh"] != DBNull.Value ? DataReader["BiBenh"].ToString() : "";
                        data.TuoiNguoiLamDon = DataReader["TuoiNguoiLamDon"] != DBNull.Value ? DataReader["TuoiNguoiLamDon"].ToString() : "";
                        data.GioiTinhNguoiLamDon = DataReader["GioiTinhNguoiLamDon"] != DBNull.Value ? DataReader["GioiTinhNguoiLamDon"].ToString() : "";
                        data.DiaChiNguoiLamDon = DataReader["DiaChiNguoiLamDon"] != DBNull.Value ? DataReader["DiaChiNguoiLamDon"].ToString() : "";
                        data.QuanHeVoiNguoiBenh = DataReader["QuanHeVoiNguoiBenh"] != DBNull.Value ? DataReader["QuanHeVoiNguoiBenh"].ToString() : "";

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref DonXinDamBaoBenhNhanTamThan objData)
        {
            string sql;
            int n = 0;
            if (objData.ID == 0)
            {
                sql = @"INSERT INTO DonXinDamBaoBenhNhanTamThan (
                                    MaQuanLy,
                                    TenNguoiBenh,
                                    TuoiNguoiBenh,
                                    GioiTinhNguoiBenh,
                                    BiBenh,
                                    NhungBieuHienTaiNha,
                                    TuNgay,
                                    TenNguoiLamDon,
                                    TuoiNguoiLamDon,
                                    GioiTinhNguoiLamDon,
                                    DiaChiNguoiLamDon,
                                    QuanHeVoiNguoiBenh,
                                    NgayTao,
                                    NguoiTao,
                                    NgaySua,
                                    NguoiSua
                                ) VALUES (
                                    :MaQuanLy,
                                    :TenNguoiBenh,
                                    :TuoiNguoiBenh,
                                    :GioiTinhNguoiBenh,
                                    :BiBenh,
                                    :NhungBieuHienTaiNha,
                                    :TuNgay,
                                    :TenNguoiLamDon,
                                    :TuoiNguoiLamDon,
                                    :GioiTinhNguoiLamDon,
                                    :DiaChiNguoiLamDon,
                                    :QuanHeVoiNguoiBenh,
                                    :NgayTao,
                                    :NguoiTao,
                                    :NgaySua,
                                    :NguoiSua
                                ) RETURNING ID INTO :ID";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", objData.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("TenNguoiBenh", objData.TenNguoiBenh));
                Command.Parameters.Add(new MDB.MDBParameter("TuoiNguoiBenh", objData.TuoiNguoiBenh));
                Command.Parameters.Add(new MDB.MDBParameter("GioiTinhNguoiBenh", objData.GioiTinhNguoiBenh));
                Command.Parameters.Add(new MDB.MDBParameter("BiBenh", objData.BiBenh));
                Command.Parameters.Add(new MDB.MDBParameter("NhungBieuHienTaiNha", objData.NhungBieuHienTaiNha));
                Command.Parameters.Add(new MDB.MDBParameter("TuNgay", objData.TuNgay));
                Command.Parameters.Add(new MDB.MDBParameter("TenNguoiLamDon", objData.TenNguoiLamDon));
                Command.Parameters.Add(new MDB.MDBParameter("TuoiNguoiLamDon", objData.TuoiNguoiLamDon));
                Command.Parameters.Add(new MDB.MDBParameter("GioiTinhNguoiLamDon", objData.GioiTinhNguoiLamDon));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChiNguoiLamDon", objData.DiaChiNguoiLamDon));
                Command.Parameters.Add(new MDB.MDBParameter("QuanHeVoiNguoiBenh", objData.QuanHeVoiNguoiBenh));
                Command.Parameters.Add(new MDB.MDBParameter("ID", objData.ID));
                Command.Parameters.Add(new MDB.MDBParameter("NgayTao", objData.NgayTao));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiTao", objData.NguoiTao));
                Command.Parameters.Add(new MDB.MDBParameter("NgaySua", objData.NgaySua));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiSua", objData.NguoiSua));

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
                sql = @"UPDATE DonXinDamBaoBenhNhanTamThan SET  
                                    MaQuanLy = :MaQuanLy,
                                    TenNguoiBenh = :TenNguoiBenh,
                                    TuoiNguoiBenh = :TuoiNguoiBenh,
                                    GioiTinhNguoiBenh = :GioiTinhNguoiBenh,
                                    BiBenh = :BiBenh,
                                    NhungBieuHienTaiNha = :NhungBieuHienTaiNha,
                                    TuNgay = :TuNgay,
                                    TenNguoiLamDon = :TenNguoiLamDon,
                                    TuoiNguoiLamDon = :TuoiNguoiLamDon,
                                    GioiTinhNguoiLamDon = :GioiTinhNguoiLamDon,
                                    DiaChiNguoiLamDon = :DiaChiNguoiLamDon,
                                    QuanHeVoiNguoiBenh = :QuanHeVoiNguoiBenh,
                                    NgaySua = :NgaySua,
                                    NguoiSua = :NguoiSua
                                        WHERE ID = :IDPhieu";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", objData.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", objData.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("TenNguoiBenh", objData.TenNguoiBenh));
                Command.Parameters.Add(new MDB.MDBParameter("TuoiNguoiBenh", objData.TuoiNguoiBenh));
                Command.Parameters.Add(new MDB.MDBParameter("GioiTinhNguoiBenh", objData.GioiTinhNguoiBenh));
                Command.Parameters.Add(new MDB.MDBParameter("BiBenh", objData.BiBenh));
                Command.Parameters.Add(new MDB.MDBParameter("NhungBieuHienTaiNha", objData.NhungBieuHienTaiNha));
                Command.Parameters.Add(new MDB.MDBParameter("TuNgay", objData.TuNgay));
                Command.Parameters.Add(new MDB.MDBParameter("TenNguoiLamDon", objData.TenNguoiLamDon));
                Command.Parameters.Add(new MDB.MDBParameter("TuoiNguoiLamDon", objData.TuoiNguoiLamDon));
                Command.Parameters.Add(new MDB.MDBParameter("GioiTinhNguoiLamDon", objData.GioiTinhNguoiLamDon));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChiNguoiLamDon", objData.DiaChiNguoiLamDon));
                Command.Parameters.Add(new MDB.MDBParameter("QuanHeVoiNguoiBenh", objData.QuanHeVoiNguoiBenh));
                Command.Parameters.Add(new MDB.MDBParameter("ID", objData.ID));
                Command.Parameters.Add(new MDB.MDBParameter("NgaySua", objData.NgaySua));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiSua", objData.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("IDPhieu", objData.ID));
                Command.BindByName = true;
                n = Command.ExecuteNonQuery();

            }


            return n > 0 ? true : false;
        }

        public static bool Delete(MDB.MDBConnection MyConnection, decimal idPhieu)
        {
            string sql = "DELETE FROM DonXinDamBaoBenhNhanTamThan WHERE ID = :idPhieu";
            MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
            command.Parameters.Add(new MDB.MDBParameter("idPhieu", idPhieu));
            command.BindByName = true;
            int n = command.ExecuteNonQuery();
            return n > 0 ? true : false;
        }
       
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, decimal idPhieu)
        {
            string sql = @"SELECT
                P.* 
            FROM
                DonXinDamBaoBenhNhanTamThan P
            WHERE
                ID = " + idPhieu;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "KQ");

            ds.Tables[0].AddColumn("BenhVien", typeof(string));
            ds.Tables[0].AddColumn("Ngay", typeof(int));
            ds.Tables[0].AddColumn("Thang", typeof(int));
            ds.Tables[0].AddColumn("Nam", typeof(int));

            ds.Tables[0].Rows[0]["BenhVien"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["Ngay"] = DateTime.Now.Day;
            ds.Tables[0].Rows[0]["Thang"] = DateTime.Now.Month;
            ds.Tables[0].Rows[0]["Nam"] = DateTime.Now.Year;

            return ds;
        }
    }
}
