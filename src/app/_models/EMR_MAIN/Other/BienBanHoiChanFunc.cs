using EMR.KyDienTu;
using System;
using System.Collections.Generic;
using System.Data;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class BienBanHoiChan : ThongTinKy
    {
        public BienBanHoiChan()
        {
            TableName = "BIENBANHOICHAN";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BBHC;
            TenMauPhieu = DanhMucPhieu.BBHC.Description();
        }

        [MoTaDuLieu("Mã định danh biên bản hội chẩn")]
		public decimal IDBienBanHoiChan { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Thời gian chỉ định")]
        public DateTime NgayChiDinh { get; set; }
        [MoTaDuLieu("Giờ chỉ định")]
        public DateTime? NgayChiDinh_Gio { get; set; }
        [MoTaDuLieu("Ngày hội chẩn")]
        public DateTime NgayHoiChan { get; set; }
        [MoTaDuLieu("Giờ hội chẩn")]
        public DateTime? NgayHoiChan_Gio { get; set; }
        [MoTaDuLieu("Trích biên bản hội chẩn")]
        public string TrichBienBanHoiChan { get; set; }
        [MoTaDuLieu("Họ tên chủ toạ")]
        public string ChuToa { get; set; }
        [MoTaDuLieu("Mã chủ toạ")]
        public string MaChuToa { get; set; }
        [MoTaDuLieu("Họ tên thư ký")]
        public string ThuKy { get; set; }
        [MoTaDuLieu("Mã thư ký")]
        public string MaThuKy { get; set; }
        [MoTaDuLieu("Thành viên tham gia")]
        public string ThanhVienThamGia { get; set; }
        [MoTaDuLieu("Mã thành viên tham gia")]
        public string DanhSachThanhVienThamGia { get; set; }
        [MoTaDuLieu("Tóm tắt quá trình")]
        public string TomTatQuaTrinh { get; set; }
        [MoTaDuLieu("Kết luận")]
        public string KetLuan { get; set; }
        [MoTaDuLieu("Hướng điều trị tiếp theo")]
        public string HuongDieuTriTiepTheo { get; set; }
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
    public class BienBanHoiChanFunc
    {
        public static List<BienBanHoiChan> getData(decimal maQuanLy, MDB.MDBConnection _OracleConnection)
        {
            List<BienBanHoiChan> lstData = new List<BienBanHoiChan>();
            try
            {
                string sql = @"SELECT * FROM BIENBANHOICHAN where MaQuanLy = :MaQuanLy and XOA = 0";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maQuanLy));
                Command.BindByName = true;
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    BienBanHoiChan data = new BienBanHoiChan();
                    data.IDBienBanHoiChan = Convert.ToInt64(DataReader.GetLong("IDBienBanHoiChan").ToString());
                    data.MaQuanLy = maQuanLy;
                    data.NgayChiDinh = Convert.ToDateTime(DataReader["NgayChiDinh"] == DBNull.Value ? DateTime.Now : DataReader["NgayChiDinh"]);
                    data.NgayHoiChan = Convert.ToDateTime(DataReader["NgayHoiChan"] == DBNull.Value ? DateTime.Now : DataReader["NgayHoiChan"]);
                    data.TrichBienBanHoiChan = DataReader["TrichBienBanHoiChan"].ToString();
                    data.ChuToa = DataReader["ChuToa"].ToString();
                    data.MaChuToa = DataReader["MaChuToa"].ToString();
                    data.ThuKy = DataReader["ThuKy"].ToString();
                    data.MaThuKy = DataReader["MaThuKy"].ToString();
                    data.ThanhVienThamGia = DataReader["ThanhVienThamGia"].ToString();
                    data.TomTatQuaTrinh = DataReader["TomTatQuaTrinh"].ToString();
                    data.KetLuan = DataReader["KetLuan"].ToString();
                    data.HuongDieuTriTiepTheo = DataReader["HuongDieuTriTiepTheo"].ToString();
                    data.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                    data.NguoiTao = DataReader["NguoiTao"].ToString();
                    data.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);
                    data.NguoiSua = DataReader["NguoiSua"].ToString();
                    data.DanhSachThanhVienThamGia = DataReader["DanhSachThanhVienThamGia"].ToString();

                    lstData.Add(data);
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return lstData;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BienBanHoiChan bienBanHoiChan)
        {
            string sql = @"INSERT INTO BIENBANHOICHAN
                (
                    MAQUANLY,
                    NGAYCHIDINH,
                    NGAYHOICHAN,
                    TRICHBIENBANHOICHAN,
                    CHUTOA,
                    MACHUTOA,
                    THUKY,
                    MATHUKY,
                    THANHVIENTHAMGIA,
                    DANHSACHTHANHVIENTHAMGIA,
                    TOMTATQUATRINH,
                    KETLUAN,
                    HUONGDIEUTRITIEPTHEO,
                    XOA,
                    NGUOITAO,
                    NGAYTAO,
                    NGUOISUA,
                    NGAYSUA)  VALUES
                 (
                    :MAQUANLY,
                    :NGAYCHIDINH,
                    :NGAYHOICHAN,
                    :TRICHBIENBANHOICHAN,
                    :CHUTOA,
                    :MACHUTOA,
                    :THUKY,
                    :MATHUKY,
                    :THANHVIENTHAMGIA,
                    :DANHSACHTHANHVIENTHAMGIA,
                    :TOMTATQUATRINH,
                    :KETLUAN,
                    :HUONGDIEUTRITIEPTHEO,
                    0,
                    :NGUOITAO,
                    :NGAYTAO,
                    :NGUOISUA,
                    :NGAYSUA
                )  RETURNING IDBIENBANHOICHAN INTO :IDBIENBANHOICHAN";
            if (bienBanHoiChan.IDBienBanHoiChan != Decimal.Zero)
            {
                sql = @"UPDATE BIENBANHOICHAN SET 
                    MAQUANLY = :MAQUANLY, 
                    NGAYCHIDINH = :NGAYCHIDINH, 
                    NGAYHOICHAN = :NGAYHOICHAN,
                    TRICHBIENBANHOICHAN = :TRICHBIENBANHOICHAN,
                    CHUTOA = :CHUTOA,
                    MACHUTOA = :MACHUTOA,
                    THUKY = :THUKY,
                    MATHUKY = :MATHUKY,
                    THANHVIENTHAMGIA = :THANHVIENTHAMGIA,
                    DANHSACHTHANHVIENTHAMGIA = :DANHSACHTHANHVIENTHAMGIA,
                    TOMTATQUATRINH = :TOMTATQUATRINH,
                    KETLUAN = :KETLUAN,
                    HUONGDIEUTRITIEPTHEO = :HUONGDIEUTRITIEPTHEO,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE IDBIENBANHOICHAN = " + bienBanHoiChan.IDBienBanHoiChan;
            }
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bienBanHoiChan.MaQuanLy));

            var Ngay = bienBanHoiChan.NgayChiDinh.Date.Add(new TimeSpan(0, 0, 0));
            var Gio = bienBanHoiChan.NgayChiDinh_Gio != null ? bienBanHoiChan.NgayChiDinh_Gio.Value.TimeOfDay : DateTime.Now.TimeOfDay;
            var ngayChiDinh = Ngay + Gio;
            Command.Parameters.Add(new MDB.MDBParameter("NGAYCHIDINH", ngayChiDinh));

            Ngay = bienBanHoiChan.NgayHoiChan.Date.Add(new TimeSpan(0, 0, 0));
            Gio = bienBanHoiChan.NgayHoiChan_Gio != null ? bienBanHoiChan.NgayHoiChan_Gio.Value.TimeOfDay : DateTime.Now.TimeOfDay;
            var ngayHoiChan = Ngay + Gio;
            Command.Parameters.Add(new MDB.MDBParameter("NGAYHOICHAN", ngayHoiChan));

            Command.Parameters.Add(new MDB.MDBParameter("TRICHBIENBANHOICHAN", bienBanHoiChan.TrichBienBanHoiChan));
            Command.Parameters.Add(new MDB.MDBParameter("CHUTOA", bienBanHoiChan.ChuToa));
            Command.Parameters.Add(new MDB.MDBParameter("MACHUTOA", bienBanHoiChan.MaChuToa));
            Command.Parameters.Add(new MDB.MDBParameter("THUKY", bienBanHoiChan.ThuKy));
            Command.Parameters.Add(new MDB.MDBParameter("MATHUKY", bienBanHoiChan.MaThuKy));
            Command.Parameters.Add(new MDB.MDBParameter("THANHVIENTHAMGIA", bienBanHoiChan.ThanhVienThamGia));
            Command.Parameters.Add(new MDB.MDBParameter("DANHSACHTHANHVIENTHAMGIA", bienBanHoiChan.DanhSachThanhVienThamGia));
            Command.Parameters.Add(new MDB.MDBParameter("TOMTATQUATRINH", bienBanHoiChan.TomTatQuaTrinh));
            Command.Parameters.Add(new MDB.MDBParameter("KETLUAN", bienBanHoiChan.KetLuan));
            Command.Parameters.Add(new MDB.MDBParameter("HUONGDIEUTRITIEPTHEO", bienBanHoiChan.HuongDieuTriTiepTheo));
            Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", bienBanHoiChan.NguoiSua));
            Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", bienBanHoiChan.NgaySua));
            if (bienBanHoiChan.IDBienBanHoiChan.Equals(Decimal.Zero))
            {
                Command.Parameters.Add(new MDB.MDBParameter("IDBIENBANHOICHAN", bienBanHoiChan.IDBienBanHoiChan));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", bienBanHoiChan.NguoiTao));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", bienBanHoiChan.NgayTao));
            }
            Command.BindByName = true;
            int n = Command.ExecuteNonQuery(); // C#
            if (bienBanHoiChan.IDBienBanHoiChan.Equals(Decimal.Zero))
            {
                decimal nextval = Convert.ToInt64((Command.Parameters["IDBIENBANHOICHAN"] as MDB.MDBParameter).Value);
                bienBanHoiChan.IDBienBanHoiChan = nextval;
            }

            return n > 0 ? true : false;
        }
        public static bool delete(MDB.MDBConnection MyConnection, decimal idBienBanhoiChan)
        {
            string sql = @"UPDATE BIENBANHOICHAN SET 
                    XOA = 1 
                    WHERE IDBIENBANHOICHAN = " + idBienBanhoiChan;
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static DataSet getDataSet(MDB.MDBConnection MyConnection, decimal idBienBanHoiChan)
        {
            //var ds = new DataSet();
            // implement code here
            string sql = @"SELECT
                B.MAQUANLY,
				B.NGAYCHIDINH,
				B.NGAYHOICHAN,
				B.TRICHBIENBANHOICHAN,
				B.CHUTOA,
                B.MACHUTOA,
				B.THUKY,
                B.MATHUKY,
				B.THANHVIENTHAMGIA,
                B.DANHSACHTHANHVIENTHAMGIA,
				B.TOMTATQUATRINH,
				B.KETLUAN,
				B.HUONGDIEUTRITIEPTHEO,
	            T.SONHAPVIEN,
                T.SOLUUTRU,
	            T.NGAYVAOVIEN,
                T.NGAYRAVIEN,
                T.KHOA,
                T.CHANDOAN_KHIVAOKHOADIEUTRI,
	            H.TENBENHNHAN,
	            H.TUOI,
	            H.GIOITINH 
            FROM
                BIENBANHOICHAN B
                JOIN THONGTINDIEUTRI T ON B.MAQUANLY = T.MAQUANLY
                JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
            WHERE
                IDBienBanHoiChan = " + idBienBanHoiChan;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            adt.Fill(ds, "BBHC");

            DataTable thongTinVien = new DataTable("HEADER");
            thongTinVien.Columns.Add("SOYTE");
            thongTinVien.Columns.Add("BENHVIEN");
            thongTinVien.Columns.Add("KHOA");
            if (XemBenhAn._HanhChinhBenhNhan == null) XemBenhAn._HanhChinhBenhNhan = new HanhChinhBenhNhan();
            if (XemBenhAn._ThongTinDieuTri == null) XemBenhAn._ThongTinDieuTri = new ThongTinDieuTri();
            thongTinVien.Rows.Add(XemBenhAn._HanhChinhBenhNhan.SoYTe, XemBenhAn._HanhChinhBenhNhan.BenhVien, XemBenhAn._ThongTinDieuTri.Khoa);
            ds.Tables.Add(thongTinVien);

            return ds;
        }
    }
}
