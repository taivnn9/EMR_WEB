
using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class GiayCamKetDongTien : ThongTinKy
    {
        public GiayCamKetDongTien()
        {
            TableName = "GiayCamKetDongTien";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.GCKDTTMCT;
            TenMauPhieu = DanhMucPhieu.GCKDTTMCT.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Mã bệnh án")]
		public string MaBenhAn { get; set; }
        [MoTaDuLieu("Sở Y Tế")]
		public string SoYTe { get; set; }
        [MoTaDuLieu("Bệnh viện")]
		public string BenhVien { get; set; }
        public string MaSo { get; set; }
        public string SoVaoVien { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        public string La { get; set; }
        public string BenhNhan { get; set; }
        public string SoTien { get; set; }
        public string SoTienBangChu { get; set; }
        public string SoTienCanThiep { get; set; }
        public DateTime ThoiGian { get; set; }
        public string ThoiGianHen_Text { get; set; }
        public DateTime ThoiGianKy { get; set; }
        public string MaNVNguoiVietPhieu { get; set; }
        public string NguoiVietPhieu { get; set; }

        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        //public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
    }
    public class GiayCamKetDongTienFunc
    {
        public const string TableName = "GiayCamKetDongTien";
        public const string TablePrimaryKeyName = "ID";

        public static List<GiayCamKetDongTien> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<GiayCamKetDongTien> list = new List<GiayCamKetDongTien>();
            try
            {
                string sql = @"SELECT * FROM GiayCamKetDongTien where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    GiayCamKetDongTien data = new GiayCamKetDongTien();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;

                    data.MaBenhNhan = XemBenhAn._HanhChinhBenhNhan.MaBenhNhan;
                    data.MaBenhAn = XemBenhAn._ThongTinDieuTri.MaBenhAn;
                    data.TenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();

                    data.DiaChi = Common.ConDBNull(DataReader["DiaChi"]);
                    data.La = Common.ConDBNull(DataReader["La"]);
                    data.BenhNhan = Common.ConDBNull(DataReader["BenhNhan"]);
                    data.SoTien = Common.ConDBNull(DataReader["SoTien"]);
                    data.SoTienBangChu = Common.ConDBNull(DataReader["SoTienBangChu"]);
                    data.SoTienCanThiep = Common.ConDBNull(DataReader["SoTienCanThiep"]);
                    data.ThoiGian = Common.ConDB_DateTime(DataReader["ThoiGian"]);
                    data.ThoiGianHen_Text = Common.ConDBNull(DataReader["ThoiGianHen_Text"]);
                    data.ThoiGianKy = Common.ConDB_DateTime(DataReader["ThoiGianKy"]);
                    data.MaNVNguoiVietPhieu = DataReader["MaNVNguoiVietPhieu"].ToString();
                    data.NguoiVietPhieu = DataReader["NguoiVietPhieu"].ToString();

                    data.NgayTao = Convert.ToDateTime(DataReader["NGAYTAO"] == DBNull.Value ? DateTime.Now : DataReader["NGAYTAO"]);
                    data.NguoiTao = DataReader["NGUOITAO"].ToString();
                    data.NgaySua = Convert.ToDateTime(DataReader["NGAYSUA"] == DBNull.Value ? DateTime.Now : DataReader["NGAYSUA"]);
                    data.NguoiSua = DataReader["NGUOISUA"].ToString();

                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;
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
                sql = @"DELETE FROM GiayCamKetDongTien WHERE ID =" + IDBienBan;
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
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, long IDBienBan)
        {
            string sql = @"SELECT P.*, T.SoNhapVien, T.Khoa , T.NgayVaoVien ,  T.MaKhoa, T.MaBenhAn,     
				H.TUOI,H.SoYTe, H.BENHVIEN, 
				 H.GIOITINH,  H.TenBenhNhan, H.maBenhNhan
			  FROM GiayCamKetDongTien P 
				Left JOIN THONGTINDIEUTRI T ON P.MAQUANLY = T.MAQUANLY
				Left JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
			  where ID = :IDPhieu";
            MDB.MDBCommand Command;
            MDB.MDBDataAdapter adt;
            using (Command = new MDB.MDBCommand(sql, MyConnection))
            {
                Command.Parameters.Add(new MDB.MDBParameter("IDPhieu", IDBienBan));
                adt = new MDB.MDBDataAdapter(Command);
            }
            var ds = new DataSet();
            adt.Fill(ds, "TBL");
            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref GiayCamKetDongTien ketQua)
        {
            try
            {
                string sql = @"INSERT INTO GiayCamKetDongTien
                (
                    MaQuanLy,
                    DiaChi,
                    La,
                    BenhNhan,
                    SoTien,
                    SoTienBangChu,
                    SoTienCanThiep,
                    ThoiGian,
                    ThoiGianHen_Text,
                    ThoiGianKy,
                    MaNVNguoiVietPhieu,
                    NguoiVietPhieu,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
                    :DiaChi,
                    :La,
                    :BenhNhan,
                    :SoTien,
                    :SoTienBangChu,
                    :SoTienCanThiep,
                    :ThoiGian,
                    :ThoiGianHen_Text,
                    :ThoiGianKy,
                    :MaNVNguoiVietPhieu,
                    :NguoiVietPhieu,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE GiayCamKetDongTien SET 
                    MaQuanLy = :MaQuanLy,
                    DiaChi = :DiaChi,
                    La = :La,
                    BenhNhan = :BenhNhan,
                    SoTien = :SoTien,
                    SoTienBangChu = :SoTienBangChu,
                    SoTienCanThiep = :SoTienCanThiep,
                    ThoiGian = :ThoiGian,
                    ThoiGianHen_Text = :ThoiGianHen_Text,
                    ThoiGianKy = :ThoiGianKy,
                    MaNVNguoiVietPhieu = :MaNVNguoiVietPhieu,
                    NguoiVietPhieu = :NguoiVietPhieu,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", ketQua.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("La", ketQua.La));
                Command.Parameters.Add(new MDB.MDBParameter("BenhNhan", ketQua.BenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("SoTien", ketQua.SoTien));
                Command.Parameters.Add(new MDB.MDBParameter("SoTienBangChu", ketQua.SoTienBangChu));
                Command.Parameters.Add(new MDB.MDBParameter("SoTienCanThiep", ketQua.SoTienCanThiep));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGian", ketQua.ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianHen_Text", ketQua.ThoiGianHen_Text));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianKy", ketQua.ThoiGianKy));
                Command.Parameters.Add(new MDB.MDBParameter("MaNVNguoiVietPhieu", ketQua.MaNVNguoiVietPhieu));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiVietPhieu", ketQua.NguoiVietPhieu));

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
                XuLyLoi.LogError(ex);
            }
            return false;
        }
    }
}
