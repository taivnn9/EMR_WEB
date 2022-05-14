using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuKhaiThacTienSuDiUng : ThongTinKy
    {
        public PhieuKhaiThacTienSuDiUng()
        {
            TableName = "PhieuKhaiThacTienSuDiUng";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PKTTSDU;
            TenMauPhieu = DanhMucPhieu.PKTTSDU.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Bệnh viện")]
		public string BenhVien { get; set; }
        public string KhoaPhong { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        public string MaSo { get; set; }
        [MoTaDuLieu("Ngày vào bệnh viện")]
		public DateTime NgayVaoVien { get; set; }
        public string HoTen { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        public String GioiTinh { get; set; }
        public string SoGiuong { get; set; }
        public string SoBuong { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public string DUThuoc_Ten { get; set; }
        public string DUThuoc_CoSoLan { get; set; }
        public int? DUThuoc_Khong { get; set; }
        public string DUThuoc_BieuHien { get; set; }
        public string DUConTrung_Ten { get; set; }
        public string DUConTrung_CoSoLan { get; set; }
        public int? DUConTrung_Khong { get; set; }
        public string DUConTrung_BieuHien { get; set; }
        public string DUThucPham_Ten { get; set; }
        public string DUThucPham_CoSoLan { get; set; }
        public int? DUThucPham_Khong { get; set; }
        public string DUThucPham_BieuHien { get; set; }
        public string DUTacNhanKhac_Ten { get; set; }
        public string DUTacNhanKhac_CoSoLan { get; set; }
        public int? DUTacNhanKhac_Khong { get; set; }
        public string DUTacNhanKhac_BieuHien { get; set; }
        public string DUCaNhanKhac_Ten { get; set; }
        public string DUCaNhanKhac_CoSoLan { get; set; }
        public int? DUCaNhanKhac_Khong { get; set; }
        public string DUCaNhanKhac_BieuHien { get; set; }
        public string DUDiTruyen_Ten { get; set; }
        public string DUDiTruyen_CoSoLan { get; set; }
        public int? DUDiTruyen_Khong { get; set; }
        public string DUDiTruyen_BieuHien { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Bác sỹ điều trị")]
		public string BacSiDieuTri { get; set; }
        public string MaBacSiDieuTri { get; set; }
        public string NguoiKhaiThacThongTin { get; set; }
        public string MaNguoiKhaiThacThongTin { get; set; }
        [MoTaDuLieu("Ngày ký")]
		public DateTime NgayKi { get; set; }
        //public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
    }
    public class PhieuKhaiThacTienSuDiUngFunc
    {
        public const string TableName = "PhieuKhaiThacTienSuDiUng";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuKhaiThacTienSuDiUng> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuKhaiThacTienSuDiUng> list = new List<PhieuKhaiThacTienSuDiUng>();
            try
            {
                string sql = @"SELECT * FROM PhieuKhaiThacTienSuDiUng where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuKhaiThacTienSuDiUng data = new PhieuKhaiThacTienSuDiUng();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.BenhVien = Common.ConDBNull(DataReader["BenhVien"]);
                    data.KhoaPhong = Common.ConDBNull(DataReader["KhoaPhong"]);
                    data.MaQuanLy = Common.ConDB_Decimal(DataReader["MaQuanLy"]);
                    data.MaSo = Common.ConDBNull(DataReader["MaSo"]);
                    data.NgayVaoVien = Common.ConDB_DateTime(DataReader["NgayVaoVien"]);
                    data.HoTen = Common.ConDBNull(DataReader["HoTen"]);
                    data.Tuoi = Common.ConDBNull(DataReader["Tuoi"]);
                    data.GioiTinh = Common.ConDBNull(DataReader["GioiTinh"]);
                    data.SoGiuong = Common.ConDBNull(DataReader["SoGiuong"]);
                    data.SoBuong = Common.ConDBNull(DataReader["SoBuong"]);
                    data.ChanDoan = Common.ConDBNull(DataReader["ChanDoan"]);
                    data.DUThuoc_Ten = Common.ConDBNull(DataReader["DUThuoc_Ten"]);
                    data.DUThuoc_CoSoLan = Common.ConDBNull(DataReader["DUThuoc_CoSoLan"]);
                    data.DUThuoc_Khong = Common.ConDB_Int(DataReader["DUThuoc_Khong"]);
                    data.DUThuoc_BieuHien = Common.ConDBNull(DataReader["DUThuoc_BieuHien"]);
                    data.DUConTrung_Ten = Common.ConDBNull(DataReader["DUConTrung_Ten"]);
                    data.DUConTrung_CoSoLan = Common.ConDBNull(DataReader["DUConTrung_CoSoLan"]);
                    data.DUConTrung_Khong = Common.ConDB_Int(DataReader["DUConTrung_Khong"]);
                    data.DUConTrung_BieuHien = Common.ConDBNull(DataReader["DUConTrung_BieuHien"]);
                    data.DUThucPham_Ten = Common.ConDBNull(DataReader["DUThucPham_Ten"]);
                    data.DUThucPham_CoSoLan = Common.ConDBNull(DataReader["DUThucPham_CoSoLan"]);
                    data.DUThucPham_Khong = Common.ConDB_Int(DataReader["DUThucPham_Khong"]);
                    data.DUThucPham_BieuHien = Common.ConDBNull(DataReader["DUThucPham_BieuHien"]);
                    data.DUTacNhanKhac_Ten = Common.ConDBNull(DataReader["DUTacNhanKhac_Ten"]);
                    data.DUTacNhanKhac_CoSoLan = Common.ConDBNull(DataReader["DUTacNhanKhac_CoSoLan"]);
                    data.DUTacNhanKhac_Khong = Common.ConDB_Int(DataReader["DUTacNhanKhac_Khong"]);
                    data.DUTacNhanKhac_BieuHien = Common.ConDBNull(DataReader["DUTacNhanKhac_BieuHien"]);
                    data.DUCaNhanKhac_Ten = Common.ConDBNull(DataReader["DUCaNhanKhac_Ten"]);
                    data.DUCaNhanKhac_CoSoLan = Common.ConDBNull(DataReader["DUCaNhanKhac_CoSoLan"]);
                    data.DUCaNhanKhac_Khong = Common.ConDB_Int(DataReader["DUCaNhanKhac_Khong"]);
                    data.DUCaNhanKhac_BieuHien = Common.ConDBNull(DataReader["DUCaNhanKhac_BieuHien"]);
                    data.DUDiTruyen_Ten = Common.ConDBNull(DataReader["DUDiTruyen_Ten"]);
                    data.DUDiTruyen_CoSoLan = Common.ConDBNull(DataReader["DUDiTruyen_CoSoLan"]);
                    data.DUDiTruyen_Khong = Common.ConDB_Int(DataReader["DUDiTruyen_Khong"]);
                    data.DUDiTruyen_BieuHien = Common.ConDBNull(DataReader["DUDiTruyen_BieuHien"]);
                    data.NgayTao = Common.ConDB_DateTime(DataReader["NgayTao"]);
                    data.NgaySua = Common.ConDB_DateTime(DataReader["NgaySua"]);
                    data.BacSiDieuTri = Common.ConDBNull(DataReader["BacSiDieuTri"]);
                    data.MaBacSiDieuTri = Common.ConDBNull(DataReader["MaBacSiDieuTri"]);
                    data.NguoiKhaiThacThongTin = Common.ConDBNull(DataReader["NguoiKhaiThacThongTin"]);
                    data.MaNguoiKhaiThacThongTin = Common.ConDBNull(DataReader["MaNguoiKhaiThacThongTin"]);

                    data.TenFileKy = Common.ConDBNull(DataReader["TenFileKy"]);
                    data.UserNameKy = Common.ConDBNull(DataReader["UserNameKy"]);
                    data.NgayKi = Common.ConDB_DateTime(DataReader["NgayKi"]);
                    data.ComputerKyTen = Common.ConDBNull(DataReader["ComputerKyTen"]);
                    data.MaSoKy = Common.ConDBNull(DataReader["MaSoKyTen"]);
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy);
                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool DeleteByIDPhieu(MDB.MDBConnection oracleConnection, decimal IDBienBan)
        {
            try
            {
                string sql = "";
                MDB.MDBCommand oracleCommand;
                sql = @"DELETE FROM PhieuKhaiThacTienSuDiUng WHERE ID =" + IDBienBan;
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

        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, long id)
        {
            string sql = @"SELECT
                P.* 
            FROM
                PhieuKhaiThacTienSuDiUng P
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "KQ");
            ds.Tables[0].AddColumn("SOYTE", typeof(string));
            ds.Tables[0].AddColumn("MABENHNHAN", typeof(string));
            ds.Tables[0].Rows[0]["SOYTE"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["MABENHNHAN"] = XemBenhAn._HanhChinhBenhNhan.MaBenhNhan;
            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuKhaiThacTienSuDiUng ketQua)
        {
            try
            {
                string sql = @"INSERT INTO PhieuKhaiThacTienSuDiUng
                (
                    BenhVien,
                    KhoaPhong,
                    MaQuanLy,
                    MaSo,
                    NgayVaoVien,
                    HoTen,
                    Tuoi,
                    GioiTinh,
                    SoGiuong,
                    SoBuong,
                    ChanDoan,
                    DUThuoc_Ten,
                    DUThuoc_CoSoLan,
                    DUThuoc_Khong,
                    DUThuoc_BieuHien,
                    DUConTrung_Ten,
                    DUConTrung_CoSoLan,
                    DUConTrung_Khong,
                    DUConTrung_BieuHien,
                    DUThucPham_Ten,
                    DUThucPham_CoSoLan,
                    DUThucPham_Khong,
                    DUThucPham_BieuHien,
                    DUTacNhanKhac_Ten,
                    DUTacNhanKhac_CoSoLan,
                    DUTacNhanKhac_Khong,
                    DUTacNhanKhac_BieuHien,
                    DUCaNhanKhac_Ten,
                    DUCaNhanKhac_CoSoLan,
                    DUCaNhanKhac_Khong,
                    DUCaNhanKhac_BieuHien,
                    DUDiTruyen_Ten,
                    DUDiTruyen_CoSoLan,
                    DUDiTruyen_Khong,
                    DUDiTruyen_BieuHien,
                    BacSiDieuTri,
                    MaBacSiDieuTri,
                    NguoiKhaiThacThongTin,
                    MaNguoiKhaiThacThongTin,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :BenhVien,
                    :KhoaPhong,
                    :MaQuanLy,
                    :MaSo,
                    :NgayVaoVien,
                    :HoTen,
                    :Tuoi,
                    :GioiTinh,
                    :SoGiuong,
                    :SoBuong,
                    :ChanDoan,
                    :DUThuoc_Ten,
                    :DUThuoc_CoSoLan,
                    :DUThuoc_Khong,
                    :DUThuoc_BieuHien,
                    :DUConTrung_Ten,
                    :DUConTrung_CoSoLan,
                    :DUConTrung_Khong,
                    :DUConTrung_BieuHien,
                    :DUThucPham_Ten,
                    :DUThucPham_CoSoLan,
                    :DUThucPham_Khong,
                    :DUThucPham_BieuHien,
                    :DUTacNhanKhac_Ten,
                    :DUTacNhanKhac_CoSoLan,
                    :DUTacNhanKhac_Khong,
                    :DUTacNhanKhac_BieuHien,
                    :DUCaNhanKhac_Ten,
                    :DUCaNhanKhac_CoSoLan,
                    :DUCaNhanKhac_Khong,
                    :DUCaNhanKhac_BieuHien,
                    :DUDiTruyen_Ten,
                    :DUDiTruyen_CoSoLan,
                    :DUDiTruyen_Khong,
                    :DUDiTruyen_BieuHien,
                    :BacSiDieuTri,
                    :MaBacSiDieuTri,
                    :NguoiKhaiThacThongTin,
                    :MaNguoiKhaiThacThongTin,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE PhieuKhaiThacTienSuDiUng SET 
                   BenhVien = :BenhVien,
                   KhoaPhong = :KhoaPhong,
                   MaQuanLy = :MaQuanLy,
                   MaSo = :MaSo,
                   NgayVaoVien = :NgayVaoVien,
                   HoTen = :HoTen,
                   Tuoi = :Tuoi,
                   GioiTinh = :GioiTinh,
                   SoGiuong = :SoGiuong,
                   SoBuong = :SoBuong,
                   ChanDoan = :ChanDoan,
                   DUThuoc_Ten = :DUThuoc_Ten,
                   DUThuoc_CoSoLan = :DUThuoc_CoSoLan,
                   DUThuoc_Khong = :DUThuoc_Khong,
                   DUThuoc_BieuHien = :DUThuoc_BieuHien,
                   DUConTrung_Ten = :DUConTrung_Ten,
                   DUConTrung_CoSoLan = :DUConTrung_CoSoLan,
                   DUConTrung_Khong = :DUConTrung_Khong,
                   DUConTrung_BieuHien = :DUConTrung_BieuHien,
                   DUThucPham_Ten = :DUThucPham_Ten,
                   DUThucPham_CoSoLan = :DUThucPham_CoSoLan,
                   DUThucPham_Khong = :DUThucPham_Khong,
                   DUThucPham_BieuHien = :DUThucPham_BieuHien,
                   DUTacNhanKhac_Ten = :DUTacNhanKhac_Ten,
                   DUTacNhanKhac_CoSoLan = :DUTacNhanKhac_CoSoLan,
                   DUTacNhanKhac_Khong = :DUTacNhanKhac_Khong,
                   DUTacNhanKhac_BieuHien = :DUTacNhanKhac_BieuHien,
                   DUCaNhanKhac_Ten = :DUCaNhanKhac_Ten,
                   DUCaNhanKhac_CoSoLan = :DUCaNhanKhac_CoSoLan,
                   DUCaNhanKhac_Khong = :DUCaNhanKhac_Khong,
                   DUCaNhanKhac_BieuHien = :DUCaNhanKhac_BieuHien,
                   DUDiTruyen_Ten = :DUDiTruyen_Ten,
                   DUDiTruyen_CoSoLan = :DUDiTruyen_CoSoLan,
                   DUDiTruyen_Khong = :DUDiTruyen_Khong,
                   DUDiTruyen_BieuHien = :DUDiTruyen_BieuHien,
                   BacSiDieuTri = :BacSiDieuTri,
                   MaBacSiDieuTri =:MaBacSiDieuTri,
                   NguoiKhaiThacThongTin = :NguoiKhaiThacThongTin,
                   MaNguoiKhaiThacThongTin = :MaNguoiKhaiThacThongTin,
                   NGUOISUA = :NGUOISUA,
                   NGAYSUA = :NGAYSUA
                   WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("BenhVien", ketQua.BenhVien));
                Command.Parameters.Add(new MDB.MDBParameter("KhoaPhong", ketQua.KhoaPhong));
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaSo", ketQua.MaSo));
                Command.Parameters.Add(new MDB.MDBParameter("NgayVaoVien", ketQua.NgayVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("HoTen", ketQua.HoTen));
                Command.Parameters.Add(new MDB.MDBParameter("Tuoi", ketQua.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("GioiTinh", ketQua.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("SoGiuong", ketQua.SoGiuong));
                Command.Parameters.Add(new MDB.MDBParameter("SoBuong", ketQua.SoBuong));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", ketQua.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("DUThuoc_Ten", ketQua.DUThuoc_Ten));
                Command.Parameters.Add(new MDB.MDBParameter("DUThuoc_CoSoLan", ketQua.DUThuoc_CoSoLan));
                Command.Parameters.Add(new MDB.MDBParameter("DUThuoc_Khong", ketQua.DUThuoc_Khong));
                Command.Parameters.Add(new MDB.MDBParameter("DUThuoc_BieuHien", ketQua.DUThuoc_BieuHien));
                Command.Parameters.Add(new MDB.MDBParameter("DUConTrung_Ten", ketQua.DUConTrung_Ten));
                Command.Parameters.Add(new MDB.MDBParameter("DUConTrung_CoSoLan", ketQua.DUConTrung_CoSoLan));
                Command.Parameters.Add(new MDB.MDBParameter("DUConTrung_Khong", ketQua.DUConTrung_Khong));
                Command.Parameters.Add(new MDB.MDBParameter("DUConTrung_BieuHien", ketQua.DUConTrung_BieuHien));
                Command.Parameters.Add(new MDB.MDBParameter("DUThucPham_Ten", ketQua.DUThucPham_Ten));
                Command.Parameters.Add(new MDB.MDBParameter("DUThucPham_CoSoLan", ketQua.DUThucPham_CoSoLan));
                Command.Parameters.Add(new MDB.MDBParameter("DUThucPham_Khong", ketQua.DUThucPham_Khong));
                Command.Parameters.Add(new MDB.MDBParameter("DUThucPham_BieuHien", ketQua.DUThucPham_BieuHien));
                Command.Parameters.Add(new MDB.MDBParameter("DUTacNhanKhac_Ten", ketQua.DUTacNhanKhac_Ten));
                Command.Parameters.Add(new MDB.MDBParameter("DUTacNhanKhac_CoSoLan", ketQua.DUTacNhanKhac_CoSoLan));
                Command.Parameters.Add(new MDB.MDBParameter("DUTacNhanKhac_Khong", ketQua.DUTacNhanKhac_Khong));
                Command.Parameters.Add(new MDB.MDBParameter("DUTacNhanKhac_BieuHien", ketQua.DUTacNhanKhac_BieuHien));
                Command.Parameters.Add(new MDB.MDBParameter("DUCaNhanKhac_Ten", ketQua.DUCaNhanKhac_Ten));
                Command.Parameters.Add(new MDB.MDBParameter("DUCaNhanKhac_CoSoLan", ketQua.DUCaNhanKhac_CoSoLan));
                Command.Parameters.Add(new MDB.MDBParameter("DUCaNhanKhac_Khong", ketQua.DUCaNhanKhac_Khong));
                Command.Parameters.Add(new MDB.MDBParameter("DUCaNhanKhac_BieuHien", ketQua.DUCaNhanKhac_BieuHien));
                Command.Parameters.Add(new MDB.MDBParameter("DUDiTruyen_Ten", ketQua.DUDiTruyen_Ten));
                Command.Parameters.Add(new MDB.MDBParameter("DUDiTruyen_CoSoLan", ketQua.DUDiTruyen_CoSoLan));
                Command.Parameters.Add(new MDB.MDBParameter("DUDiTruyen_Khong", ketQua.DUDiTruyen_Khong));
                Command.Parameters.Add(new MDB.MDBParameter("DUDiTruyen_BieuHien", ketQua.DUDiTruyen_BieuHien));
                Command.Parameters.Add(new MDB.MDBParameter("BacSiDieuTri", ketQua.BacSiDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSiDieuTri", ketQua.MaBacSiDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiKhaiThacThongTin", ketQua.NguoiKhaiThacThongTin));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiKhaiThacThongTin", ketQua.MaNguoiKhaiThacThongTin));

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));
                if (ketQua.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", ketQua.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", ketQua.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", ketQua.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (ketQua.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    ketQua.ID = nextval;
                }
                return n > 0;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }

    }
}
