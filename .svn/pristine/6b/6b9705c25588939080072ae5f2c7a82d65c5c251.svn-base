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
    public class GCDCTCTNT : ThongTinKy
    {
        public GCDCTCTNT()
        {
            TableName = "GCDCTCTNT";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.GCDCTCTNT;
            TenMauPhieu = DanhMucPhieu.GCDCTCTNT.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        public string HoTenTN { get; set; }
        public string SinhNamTN { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinhTN { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChiTN { get; set; }
        public DateTime ThoiGian { get; set; }
        public bool[] CamDoanArray { get; } = new bool[] { false, false };
        public string CamDoan
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < CamDoanArray.Length; i++)
                    temp += (CamDoanArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        CamDoanArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string HoTenBenhNhan { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
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
    public class GCDCTCTNTFunc
    {
        public const string TableName = "GCDCTCTNT";
        public const string TablePrimaryKeyName = "ID";
        public static List<GCDCTCTNT> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<GCDCTCTNT> list = new List<GCDCTCTNT>();
            try
            {
                string sql = @"SELECT * FROM GCDCTCTNT where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    GCDCTCTNT data = new GCDCTCTNT();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.HoTenTN = Common.ConDBNull(DataReader["HoTenTN"]);
                    data.SinhNamTN = Common.ConDBNull(DataReader["SinhNamTN"]);
                    data.GioiTinhTN = Common.ConDBNull(DataReader["GioiTinhTN"]);
                    data.DiaChiTN = Common.ConDBNull(DataReader["DiaChiTN"]);
                    data.ThoiGian = Common.ConDB_DateTime(DataReader["ThoiGian"]);
                    data.CamDoan = Common.ConDBNull(DataReader["CamDoan"]);
                    data.CamDoan = Common.ConDBNull(DataReader["CamDoan"]);

                    data.HoTenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Khoa = XemBenhAn._ThongTinDieuTri.Khoa;
                    try
                    {
                        data.ChanDoan = Common.getChanDoan();
                    }
                    catch { }

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref GCDCTCTNT data)
        {
            try
            {
                string sql = @"INSERT INTO GCDCTCTNT
                (
                    MAQUANLY,
                    HoTenTN,
                    SinhNamTN,
                    GioiTinhTN,
                    DiaChiTN,
                    ThoiGian,
                    CamDoan,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :HoTenTN,
                    :SinhNamTN,
                    :GioiTinhTN,
                    :DiaChiTN,
                    :ThoiGian,
                    :CamDoan,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (data.ID != 0)
                {
                    sql = @"UPDATE GCDCTCTNT SET 
                    MAQUANLY = :MAQUANLY,
                    HoTenTN=:HoTenTN,
                    SinhNamTN=:SinhNamTN,
                    GioiTinhTN=:GioiTinhTN,
                    DiaChiTN=:DiaChiTN,
                    ThoiGian=:ThoiGian,
                    CamDoan=:CamDoan,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + data.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", data.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("HoTenTN", data.HoTenTN));
                Command.Parameters.Add(new MDB.MDBParameter("SinhNamTN", data.SinhNamTN));
                Command.Parameters.Add(new MDB.MDBParameter("GioiTinhTN", data.GioiTinhTN));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChiTN", data.DiaChiTN));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGian", data.ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("CamDoan", data.CamDoan));

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", data.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", data.NgaySua));
                if (data.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", data.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", data.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", data.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (data.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    data.ID = nextval;
                }
                return n > 0;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool Delete(MDB.MDBConnection MyConnection, long id)
        {
            try
            {
                string sql = "DELETE FROM GCDCTCTNT WHERE ID = :ID";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                command.Parameters.Add(new MDB.MDBParameter("ID", id));
                command.BindByName = true;
                int n = command.ExecuteNonQuery();
                return n > 0;
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
                GCDCTCTNT B
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);

            var ds = new DataSet();

            adt.Fill(ds, "TB");
            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("Khoa", typeof(string));
            ds.Tables[0].AddColumn("SoYTe", typeof(string));
            ds.Tables[0].AddColumn("BenhVien", typeof(string));
            ds.Tables[0].AddColumn("ChanDoan", typeof(string));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Khoa"] = XemBenhAn._ThongTinDieuTri.Khoa;
            ds.Tables[0].Rows[0]["SoYTe"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BenhVien"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["ChanDoan"] = Common.getChanDoan();
            return ds;
        }
    }
}
