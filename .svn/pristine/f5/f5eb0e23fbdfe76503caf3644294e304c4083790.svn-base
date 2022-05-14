using EMR.KyDienTu;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.Access; 

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuTheoDoiTimThaiConCoTuCung : ThongTinKy
    {
        public PhieuTheoDoiTimThaiConCoTuCung()
        {
            TableName = "PhieuTDTimThaiCCTC";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.TDTTCCCTC;
            TenMauPhieu = DanhMucPhieu.TDTTCCCTC.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public string YeuCauKiemTra { get; set; }
        public DateTime NgayBacSyDieuTri { get; set; }
        [MoTaDuLieu("Bác sỹ điều trị")]
		public string BacSyDieuTri { get; set; }
        [MoTaDuLieu("Mã bác sỹ điều trị")]
		public string MaBacSyDieuTri { get; set; }
        public string TimThai { get; set; }
        public string ConCoTuCung { get; set; }
        public string CuDongThaiNhi { get; set; }
        public string KetLuan { get; set; }
        public string LoiDanBacSy { get; set; }
        public DateTime NgayBacSyChuyenKhoa { get; set; }
        public string BacSyChuyenKhoa { get; set; }
        public string MaBacSyChuyenKhoa { get; set; }
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
    public class PhieuTheoDoiTimThaiConCoTuCungFunc
    {
        public const string TableName = "PhieuTDTimThaiCCTC";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuTheoDoiTimThaiConCoTuCung> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuTheoDoiTimThaiConCoTuCung> list = new List<PhieuTheoDoiTimThaiConCoTuCung>();
            try
            {
                string sql = @"SELECT * FROM PhieuTDTimThaiCCTC where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuTheoDoiTimThaiConCoTuCung data = new PhieuTheoDoiTimThaiConCoTuCung();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.Khoa = DataReader["Khoa"].ToString();
                    data.MaKhoa = DataReader["MaKhoa"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.YeuCauKiemTra = DataReader["YeuCauKiemTra"].ToString();
                    data.NgayBacSyDieuTri = Convert.ToDateTime(DataReader["NgayBacSyDieuTri"] == DBNull.Value ? DateTime.Now : DataReader["NgayBacSyDieuTri"]);
                    data.BacSyDieuTri = DataReader["BacSyDieuTri"].ToString();
                    data.MaBacSyDieuTri = DataReader["MaBacSyDieuTri"].ToString();

                    data.TimThai = DataReader["TimThai"].ToString();
                    data.ConCoTuCung = DataReader["ConCoTuCung"].ToString();
                    
                    data.CuDongThaiNhi = DataReader["CuDongThaiNhi"].ToString();
                    data.KetLuan = DataReader["KetLuan"].ToString();
                    data.LoiDanBacSy = DataReader["LoiDanBacSy"].ToString();
                  
                    data.NgayBacSyChuyenKhoa = Convert.ToDateTime(DataReader["NgayBacSyChuyenKhoa"] == DBNull.Value ? DateTime.Now : DataReader["NgayBacSyChuyenKhoa"]);
                    
                    data.BacSyChuyenKhoa = DataReader["BacSyChuyenKhoa"].ToString();
                    data.MaBacSyChuyenKhoa = DataReader["MaBacSyChuyenKhoa"].ToString();
                   
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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuTheoDoiTimThaiConCoTuCung bangDieuTri)
        {
            try
            {
                string sql = @"INSERT INTO PhieuTDTimThaiCCTC
                (
                    MAQUANLY,
                    MaBenhNhan,
                    Khoa,
                    MaKhoa,
                    ChanDoan,
                    YeuCauKiemTra,
                    NgayBacSyDieuTri,
                    BacSyDieuTri,
                    MaBacSyDieuTri,
                    TimThai,
                    ConCoTuCung,
                    CuDongThaiNhi,
                    KetLuan,
                    LoiDanBacSy,
                    NgayBacSyChuyenKhoa,
                    BacSyChuyenKhoa,
                    MaBacSyChuyenKhoa,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :Khoa,
                    :MaKhoa,
                    :ChanDoan,
                    :YeuCauKiemTra,
                    :NgayBacSyDieuTri,
                    :BacSyDieuTri,
                    :MaBacSyDieuTri,
                    :TimThai,
                    :ConCoTuCung,
                    :CuDongThaiNhi,
                    :KetLuan,
                    :LoiDanBacSy,
                    :NgayBacSyChuyenKhoa,
                    :BacSyChuyenKhoa,
                    :MaBacSyChuyenKhoa,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (bangDieuTri.ID != 0)
                {
                    sql = @"UPDATE PhieuTDTimThaiCCTC SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    Khoa = :Khoa,
                    MaKhoa = :MaKhoa,
                    ChanDoan = :ChanDoan,
                    YeuCauKiemTra = :YeuCauKiemTra,
                    NgayBacSyDieuTri = :NgayBacSyDieuTri,
                    BacSyDieuTri = :BacSyDieuTri,
                    MaBacSyDieuTri = :MaBacSyDieuTri,
                    TimThai = :TimThai,
                    ConCoTuCung = :ConCoTuCung,
                    CuDongThaiNhi = :CuDongThaiNhi,
                    KetLuan = :KetLuan,
                    LoiDanBacSy = :LoiDanBacSy,
                    NgayBacSyChuyenKhoa = :NgayBacSyChuyenKhoa,
                    BacSyChuyenKhoa = :BacSyChuyenKhoa,
                    MaBacSyChuyenKhoa = :MaBacSyChuyenKhoa,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + bangDieuTri.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangDieuTri.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", bangDieuTri.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa", bangDieuTri.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaKhoa", bangDieuTri.MaKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", bangDieuTri.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("YeuCauKiemTra", bangDieuTri.YeuCauKiemTra));
                Command.Parameters.Add(new MDB.MDBParameter("NgayBacSyDieuTri", bangDieuTri.NgayBacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", bangDieuTri.BacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSyDieuTri", bangDieuTri.MaBacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TimThai", bangDieuTri.TimThai));
                Command.Parameters.Add(new MDB.MDBParameter("ConCoTuCung", bangDieuTri.ConCoTuCung));
                Command.Parameters.Add(new MDB.MDBParameter("CuDongThaiNhi", bangDieuTri.CuDongThaiNhi));
                Command.Parameters.Add(new MDB.MDBParameter("KetLuan", bangDieuTri.KetLuan));
                Command.Parameters.Add(new MDB.MDBParameter("LoiDanBacSy", bangDieuTri.LoiDanBacSy));
                Command.Parameters.Add(new MDB.MDBParameter("NgayBacSyChuyenKhoa", bangDieuTri.NgayBacSyChuyenKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyChuyenKhoa", bangDieuTri.BacSyChuyenKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSyChuyenKhoa", bangDieuTri.MaBacSyChuyenKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", bangDieuTri.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", bangDieuTri.NgaySua));
                if (bangDieuTri.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", bangDieuTri.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", bangDieuTri.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", bangDieuTri.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (bangDieuTri.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    bangDieuTri.ID = nextval;
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
                string sql = "DELETE FROM PhieuTDTimThaiCCTC WHERE ID = :ID";
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
                P.*,
                T.MABENHAN,
                T.SONHAPVIEN,
                T.KHOA,
                T.BUONG,
                T.GIUONG,
                T.CHANDOAN_KHIVAOKHOADIEUTRI CHANDOAN,
                H.SOYTE,
                H.BENHVIEN,
                H.GIOITINH,
	            H.TENBENHNHAN,
                H.SOTHEBHYT,
                H.TUOI,
                (H.SONHA || ',' || H.THONPHO || ',' ||  H.XAPHUONG || ',' ||  H.HUYENQUAN || ',' ||  H.TINHTHANHPHO) AS DIACHI 
            FROM
                PhieuTDTimThaiCCTC P
                LEFT JOIN THONGTINDIEUTRI T ON P.MAQUANLY = T.MAQUANLY
                LEFT JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "TD");
            return ds;
        }
    }
}
