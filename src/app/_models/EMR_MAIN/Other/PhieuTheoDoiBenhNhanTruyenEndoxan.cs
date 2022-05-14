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
    public class PhieuTheoDoiBenhNhanTruyenEndoxanChiTiet
    {
        public string TocDoTruyen { get; set; }
        public string ThoiGian { get; set; }
        public string MachCT { get; set; }
        public string HuyetApCT { get; set; }
        public string TacDungPhu { get; set; }
    }

    public class PhieuTheoDoiBenhNhanTruyenEndoxan : ThongTinKy
    {
        public PhieuTheoDoiBenhNhanTruyenEndoxan()
        {
            TableName = "PTDBNTruyenEndoxan";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PTDBNTE;
            TenMauPhieu = DanhMucPhieu.PTDBNTE.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        public string HoTenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Giường")]
		public string Giuong { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Cân nặng")]
		public string CanNang { get; set; }
        [MoTaDuLieu("Mạch")]
		public string Mach { get; set; }
        [MoTaDuLieu("Huyết áp")]
		public string HuyetAp { get; set; }
        [MoTaDuLieu("Nhiệt độ")]
		public string NhietDo { get; set; }
        [MoTaDuLieu("Nhịp thở")]
		public string NhipTho { get; set; }
        public DateTime BatDauTruyenHoi { get; set; }
        public DateTime NgungTruyenHoi { get; set; }
        public List<PhieuTheoDoiBenhNhanTruyenEndoxanChiTiet> BangTheoDois { get; set; }
        [MoTaDuLieu("Bác sỹ")]
		public string BacSy { get; set; }
        [MoTaDuLieu("Mã bác sỹ")]
		public string MaBacSy { get; set; }
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
    public class PhieuTheoDoiBenhNhanTruyenEndoxanFunc
    {
        public const string TableName = "PTDBNTruyenEndoxan";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuTheoDoiBenhNhanTruyenEndoxan> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuTheoDoiBenhNhanTruyenEndoxan> list = new List<PhieuTheoDoiBenhNhanTruyenEndoxan>();
            try
            {
                string sql = @"SELECT * FROM PTDBNTruyenEndoxan where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuTheoDoiBenhNhanTruyenEndoxan data = new PhieuTheoDoiBenhNhanTruyenEndoxan();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.HoTenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.Khoa = XemBenhAn._ThongTinDieuTri.Khoa;
                    data.Giuong = Common.ConDBNull(DataReader["Giuong"]);
                    data.ChanDoan = Common.ConDBNull(DataReader["ChanDoan"]);
                    data.CanNang = Common.ConDBNull(DataReader["CanNang"]);
                    data.Mach = Common.ConDBNull(DataReader["Mach"]);
                    data.HuyetAp = Common.ConDBNull(DataReader["HuyetAp"]);
                    data.NhietDo = Common.ConDBNull(DataReader["NhietDo"]);
                    data.NhipTho = Common.ConDBNull(DataReader["NhipTho"]);
                    data.BatDauTruyenHoi = Common.ConDB_DateTime(DataReader["BatDauTruyenHoi"]);
                    data.NgungTruyenHoi = Common.ConDB_DateTime(DataReader["NgungTruyenHoi"]);

                    string bangTheoDoiJson = DataReader["BangTheoDois_1"].ToString();
                    if (DataReader["BangTheoDois_2"] != DBNull.Value)
                        bangTheoDoiJson += DataReader["BangTheoDois_2"].ToString();
                    if (DataReader["BangTheoDois_3"] != DBNull.Value)
                        bangTheoDoiJson += DataReader["BangTheoDois_3"].ToString();
                    data.BangTheoDois = JsonConvert.DeserializeObject<List<PhieuTheoDoiBenhNhanTruyenEndoxanChiTiet>>(bangTheoDoiJson);
                    data.BacSy = Common.ConDBNull(DataReader["BacSy"]);
                    data.MaBacSy = Common.ConDBNull(DataReader["MaBacSy"]);
                    data.NguoiTheoDoi = Common.ConDBNull(DataReader["NguoiTheoDoi"]);
                    data.MaNguoiTheoDoi = Common.ConDBNull(DataReader["MaNguoiTheoDoi"]);


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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuTheoDoiBenhNhanTruyenEndoxan data)
        {
            try
            {
                string sql = @"INSERT INTO PTDBNTruyenEndoxan
                (
                    MAQUANLY,
                    MaBenhNhan,
                    Giuong,
                    ChanDoan,
                    CanNang,
                    Mach,
                    HuyetAp,
                    NhietDo,
                    NhipTho,
                    BatDauTruyenHoi,
                    NgungTruyenHoi,
                    BangTheoDois_1,
                    BangTheoDois_2,
                    BangTheoDois_3,
                    BacSy,
                    MaBacSy,
                    NguoiTheoDoi,
                    MaNguoiTheoDoi,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :Giuong,
                    :ChanDoan,
                    :CanNang,
                    :Mach,
                    :HuyetAp,
                    :NhietDo,
                    :NhipTho,
                    :BatDauTruyenHoi,
                    :NgungTruyenHoi,
                    :BangTheoDois_1,
                    :BangTheoDois_2,
                    :BangTheoDois_3,
                    :BacSy,
                    :MaBacSy,
                    :NguoiTheoDoi,
                    :MaNguoiTheoDoi,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (data.ID != 0)
                {
                    sql = @"UPDATE PTDBNTruyenEndoxan SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan=:MaBenhNhan,
                    Giuong=:Giuong,
                    ChanDoan=:ChanDoan,
                    CanNang=:CanNang,
                    Mach=:Mach,
                    HuyetAp=:HuyetAp,
                    NhietDo=:NhietDo,
                    NhipTho=:NhipTho,
                    BatDauTruyenHoi=:BatDauTruyenHoi,
                    NgungTruyenHoi=:NgungTruyenHoi,
                    BangTheoDois_1=:BangTheoDois_1,
                    BangTheoDois_2=:BangTheoDois_2,
                    BangTheoDois_3=:BangTheoDois_3,
                    BacSy=:BacSy,
                    MaBacSy=:MaBacSy,
                    NguoiTheoDoi=:NguoiTheoDoi,
                    MaNguoiTheoDoi=:MaNguoiTheoDoi,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + data.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", data.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", data.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("Giuong", data.Giuong));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", data.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang", data.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("Mach", data.Mach));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetAp", data.HuyetAp));
                Command.Parameters.Add(new MDB.MDBParameter("NhietDo", data.NhietDo));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTho", data.NhipTho));
                Command.Parameters.Add(new MDB.MDBParameter("BatDauTruyenHoi", data.BatDauTruyenHoi));
                Command.Parameters.Add(new MDB.MDBParameter("NgungTruyenHoi", data.NgungTruyenHoi));

                string jsonBangKes = JsonConvert.SerializeObject(data.BangTheoDois);
                List<string> listJson = new List<string>();
                for (int i = 0; i < jsonBangKes.Length; i += 3999)
                {
                    if ((i + 3999) < jsonBangKes.Length)
                        listJson.Add(jsonBangKes.Substring(i, 3999));
                    else
                        listJson.Add(jsonBangKes.Substring(i));
                }
                Command.Parameters.Add(new MDB.MDBParameter("BangTheoDois_1", listJson[0]));
                Command.Parameters.Add(new MDB.MDBParameter("BangTheoDois_2", listJson.Count > 1 ? listJson[1] : null));
                Command.Parameters.Add(new MDB.MDBParameter("BangTheoDois_3", listJson.Count > 2 ? listJson[2] : null));
                Command.Parameters.Add(new MDB.MDBParameter("BacSy", data.BacSy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSy", data.MaBacSy));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiTheoDoi", data.NguoiTheoDoi));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiTheoDoi", data.MaNguoiTheoDoi));

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
                string sql = "DELETE FROM PTDBNTruyenEndoxan WHERE ID = :ID";
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
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, long id)
        {
            string sql = @"SELECT
                B.*
            FROM
                PTDBNTruyenEndoxan B
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

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            ds.Tables[0].Rows[0]["SOYTE"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["KHOA"] = XemBenhAn._ThongTinDieuTri.Khoa;

            sql = @"SELECT
               B.BangTheoDois_1, B.BangTheoDois_2, B.BangTheoDois_3
            FROM
                PTDBNTruyenEndoxan B
                
            WHERE
                ID = " + id;

            Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            List<PhieuTheoDoiBenhNhanTruyenEndoxanChiTiet> saveDatas = new List<PhieuTheoDoiBenhNhanTruyenEndoxanChiTiet>();
            while (DataReader.Read())
            {
                string bangKeJson = DataReader["BangTheoDois_1"].ToString();
                if (DataReader["BangTheoDois_2"] != DBNull.Value)
                    bangKeJson += DataReader["BangTheoDois_2"].ToString();
                if (DataReader["BangTheoDois_3"] != DBNull.Value)
                    bangKeJson += DataReader["BangTheoDois_3"].ToString();
                saveDatas = JsonConvert.DeserializeObject<List<PhieuTheoDoiBenhNhanTruyenEndoxanChiTiet>>(bangKeJson).ToList();
                break;
            }
            DataTable ChiTiet = Common.ListToDataTable(saveDatas, "CT");
            ds.Tables.Add(ChiTiet);
            return ds;

        }
    }
}