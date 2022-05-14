
using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class BienBanHoiChanDungKS : ThongTinKy
    {
        public BienBanHoiChanDungKS()
        {
            TableName = "BienBanHoiChanDungKS";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BBHCDKS;
            TenMauPhieu = DanhMucPhieu.BBHCDKS.Description();
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
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Bệnh viện")]
		public string BenhVien { get; set; }
        [MoTaDuLieu("Mã số")]
        public string MaSo { get; set; }
        [MoTaDuLieu("Số vào viện")]
        public string SoVaoVien { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Buồng")]
		public string Buong { get; set; }
        [MoTaDuLieu("Giường")]
		public string Giuong { get; set; }
        [MoTaDuLieu("Ngày bắt đàu điều trị")]
        public DateTime? NgayDieuTri { get; set; }
        [MoTaDuLieu("Ngày hội chẩn")]
        public DateTime? NgayHoiChan { get; set; }
        [MoTaDuLieu("Giờ hội chẩn")]
        public DateTime? NgayHoiChan_Gio { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Tóm tắt quá trình diễn biến, quá trình điều trị và chăm sóc người bệnh")]
        public string TomTatQuaTrinh { get; set; }
        [MoTaDuLieu("Kết luận")]
        public string KetLuan { get; set; }
        [MoTaDuLieu("Hướng điều trị")]
        public string HuongDieuTri { get; set; }
        [MoTaDuLieu("Họ tên chủ toạ")]
        public string ChuToa { get; set; }
        [MoTaDuLieu("Mã chủ toạ")]
        public string MaChuToa { get; set; }
        [MoTaDuLieu("Họ tên thư ký")]
        public string ThuKi { get; set; }
        [MoTaDuLieu("Mã thư ký")]
        public string MaThuKi { get; set; }
        [MoTaDuLieu("Thành viên tham gia")]
        public string ThanhVienThamGia { get; set; }
        [MoTaDuLieu("Mã thành viên tham gia")]
        public string MaThanhVienThamGia { get; set; }
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
    public class BienBanHoiChanDungKSFunc
    {
        public const string TableName = "BienBanHoiChanDungKS";
        public const string TablePrimaryKeyName = "ID";

        public static List<BienBanHoiChanDungKS> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BienBanHoiChanDungKS> list = new List<BienBanHoiChanDungKS>();
            try
            {
                string sql = @"SELECT * FROM BienBanHoiChanDungKS where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    BienBanHoiChanDungKS data = new BienBanHoiChanDungKS();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;

                    data.MaBenhNhan = XemBenhAn._HanhChinhBenhNhan.MaBenhNhan;
                    data.MaBenhAn = XemBenhAn._ThongTinDieuTri.MaBenhAn;
                    data.TenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.SoVaoVien = XemBenhAn._ThongTinDieuTri.SoNhapVien;
                    data.Khoa = XemBenhAn._ThongTinDieuTri.Khoa;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.NgayDieuTri = Convert.ToDateTime(DataReader["NgayDieuTri"] == DBNull.Value ? DateTime.Now : DataReader["NgayDieuTri"]);
                    data.NgayHoiChan = Convert.ToDateTime(DataReader["NgayHoiChan"] == DBNull.Value ? DateTime.Now : DataReader["NgayHoiChan"]);
                    data.NgayHoiChan_Gio = data.NgayHoiChan;

                    data.Buong = DataReader["Buong"].ToString();
                    data.Giuong = DataReader["Giuong"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.TomTatQuaTrinh = DataReader["TomTatQuaTrinh"].ToString();
                    data.KetLuan = DataReader["KetLuan"].ToString();
                    data.HuongDieuTri = DataReader["HuongDieuTri"].ToString();
                    data.ChuToa = DataReader["ChuToa"].ToString();
                    data.MaChuToa = DataReader["MaChuToa"].ToString();
                    data.ThuKi = DataReader["ThuKi"].ToString();
                    data.MaThuKi = DataReader["MaThuKi"].ToString();
                    data.ThanhVienThamGia = DataReader["ThanhVienThamGia"].ToString();
                    data.MaThanhVienThamGia = DataReader["MaThanhVienThamGia"].ToString();

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
                MDB.MDBCommand oracleCommand;
                string sql = @"DELETE FROM BienBanHoiChanDungKS WHERE ID =" + IDBienBan;
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
            string sql = @"SELECT P.*, T.SoNhapVien, T.Khoa,  T.MaKhoa, H.BENHVIEN, H.SoYTe,  H.TenBenhNhan, H.Tuoi
			  FROM BienBanHoiChanDungKS P 
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
            adt.Fill(ds, "KQ");

            ds.Tables[0].AddColumn("ThongTinNgayThang", typeof(string));
            ds.Tables[0].Rows[0]["ThongTinNgayThang"] = "Ngày  " + DateTime.Now.Day + " tháng " + DateTime.Now.Month + " năm " + DateTime.Now.Year;
            DateTime NgayHoiChan = Convert.ToDateTime(ds.Tables[0].Rows[0]["NgayHoiChan"]);
            ds.Tables[0].AddColumn("NgayHoiChanFormat", typeof(string));
            ds.Tables[0].Rows[0]["NgayHoiChanFormat"] = NgayHoiChan.Hour + ", " + NgayHoiChan.Minute + " ngày: " +
                NgayHoiChan.Day + "/"+ NgayHoiChan.Month + "/" + NgayHoiChan.Year;
            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BienBanHoiChanDungKS ketQua)
        {
            try
            {
                string sql = @"INSERT INTO BienBanHoiChanDungKS
                (
                    MaQuanLy,
                    Buong,
                    Giuong,
                    NgayDieuTri,
                    ChanDoan,
                    NgayHoiChan,
                    ChuToa,
                    MaChuToa,
                    ThuKi,
                    MaThuKi,
                    MaThanhVienThamGia,
                    ThanhVienThamGia,
                    TomTatQuaTrinh,
                    KetLuan,
                    HuongDieuTri,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
				    :Buong,
                    :Giuong,
                    :NgayDieuTri,
                    :ChanDoan,
                    :NgayHoiChan,
                    :ChuToa,
                    :MaChuToa,
                    :ThuKi,
                    :MaThuKi,
                    :MaThanhVienThamGia,
                    :ThanhVienThamGia,
                    :TomTatQuaTrinh,
                    :KetLuan,
                    :HuongDieuTri,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE BienBanHoiChanDungKS SET 
                    MaQuanLy = :MaQuanLy,
				    Buong = :Buong,
                    Giuong = :Giuong,
                    NgayDieuTri = :NgayDieuTri,
                    ChanDoan = :ChanDoan,
                    NgayHoiChan = :NgayHoiChan,
                    ChuToa = :ChuToa,
                    MaChuToa = :MaChuToa,
                    ThuKi = :ThuKi,
                    MaThuKi = :MaThuKi,
                    MaThanhVienThamGia = :MaThanhVienThamGia,
                    ThanhVienThamGia = :ThanhVienThamGia,
                    TomTatQuaTrinh = :TomTatQuaTrinh,
                    KetLuan = :KetLuan,
                    HuongDieuTri = :HuongDieuTri,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("Buong", ketQua.Buong));
                Command.Parameters.Add(new MDB.MDBParameter("Giuong", ketQua.Giuong));

                DateTime? NgayHoiChan = ketQua.NgayHoiChan.HasValue ? ketQua.NgayHoiChan.Value.Date : (DateTime?)null;
                var ThoiGian = NgayHoiChan;
                if (NgayHoiChan != null)
                {
                    var NgayHoiChanGio = ketQua.NgayHoiChan_Gio.HasValue ? ketQua.NgayHoiChan_Gio.Value.TimeOfDay : new TimeSpan(0, 0, 0);
                    ThoiGian = NgayHoiChan + NgayHoiChanGio;
                }

             
                Command.Parameters.Add(new MDB.MDBParameter("NgayHoiChan", ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("NgayDieuTri", ketQua.NgayDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", ketQua.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("ChuToa", ketQua.ChuToa));
                Command.Parameters.Add(new MDB.MDBParameter("MaChuToa", ketQua.MaChuToa));
                Command.Parameters.Add(new MDB.MDBParameter("ThuKi", ketQua.ThuKi));
                Command.Parameters.Add(new MDB.MDBParameter("MaThuKi", ketQua.MaThuKi));
                Command.Parameters.Add(new MDB.MDBParameter("ThanhVienThamGia", ketQua.ThanhVienThamGia));
                Command.Parameters.Add(new MDB.MDBParameter("MaThanhVienThamGia", ketQua.MaThanhVienThamGia));
                Command.Parameters.Add(new MDB.MDBParameter("TomTatQuaTrinh", ketQua.TomTatQuaTrinh));
                Command.Parameters.Add(new MDB.MDBParameter("KetLuan", ketQua.KetLuan));
                Command.Parameters.Add(new MDB.MDBParameter("HuongDieuTri", ketQua.HuongDieuTri));

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
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.LogError(ex);
            }
            return false;
        }
    }
}
