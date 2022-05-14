
using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class CamKetDieuTriTruyenMauInterface : ThongTinKy
    {
        public CamKetDieuTriTruyenMauInterface()
        {
            TableName = "CAMKETDIEUTRITRUYENMAU";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.CKDTTM;
            TenMauPhieu = DanhMucPhieu.CKDTTM.Description();
        }
        public bool? Include { get; set; } = false;
        [MoTaDuLieu("Mã định danh")]
		public long Id { get; set; }
        [MoTaDuLieu("Tên người yêu cầu")]
        public string NycTen { get; set; }
        [MoTaDuLieu("Giới tính người yêu cầu")]
        public string NycGioiTinh { get; set; }
        [MoTaDuLieu("CMND người yêu cầu")]
        public string NycCmtnd { get; set; }
        [MoTaDuLieu("Ngày cấp CMND người yêu cầu")]
        public DateTime? NycCapNgay { get; set; }
        [MoTaDuLieu("Nơi cấp CMND")]
        public string NycNoiCap { get; set; }
        [MoTaDuLieu("Xóm")]
        public string NycXom { get; set; }
        [MoTaDuLieu("Xã")]
        public string NycXa { get; set; }
        [MoTaDuLieu("Huyện")]
        public string NycHuyen { get; set; }
        [MoTaDuLieu("Tỉnh")]
        public string NycTinh { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Ngày sinh")]
        public DateTime? NgaySinh { get; set; }
        [MoTaDuLieu("Tên khoa")]
		public string TenKhoa { get; set; }
        [MoTaDuLieu("Bác sỹ")]
		public string BacSy { get; set; }
        [MoTaDuLieu("Hành động")]
        public string HanhDong { get; set; }
        [MoTaDuLieu("Ngày tạo")]
        public DateTime? NgayTao { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Ngày sửa")]
        public DateTime? NgaySua { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
    }

    public class CamKetDieuTriTruyenMauStored
    {
        public const string TableName = "CAMKETDIEUTRITRUYENMAU";
        public const string TablePrimaryKeyName = "ID";
        public const string MaPhieu = "CKDTTM";
        public static List<CamKetDieuTriTruyenMauInterface> GetList(decimal MaQuanLy, MDB.MDBConnection MyConnection)
        {
            List<CamKetDieuTriTruyenMauInterface> lstData = new List<CamKetDieuTriTruyenMauInterface>();
            try
            {
                string sql = @"select id, MAQUANLY, nyc_ten, nyc_gioi_tinh, nyc_cmtnd, nyc_cap_ngay, nyc_noi_cap, nyc_xom, nyc_xa, nyc_huyen, nyc_tinh, ma_benh_nhan, ten_benh_nhan, ngay_sinh, ten_khoa, bac_sy, hanh_dong, ngay_tao, nguoi_tao, ngay_sua, nguoi_sua, masokyten from CAMKETDIEUTRITRUYENMAU where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
                MDB.MDBDataReader reader = Command.ExecuteReader();
                while (reader.Read())
                {
                    CamKetDieuTriTruyenMauInterface row = new CamKetDieuTriTruyenMauInterface();
                    row.Id = Convert.ToInt64(reader.GetLong("id").ToString());
                    decimal temp = 0;
                    decimal.TryParse(reader["MAQUANLY"].ToString(), out temp);
                    row.MaQuanLy = temp;
                    row.NycTen = reader["nyc_ten"].ToString();
                    row.NycGioiTinh = reader["nyc_gioi_tinh"].ToString();
                    row.NycCmtnd = reader["nyc_cmtnd"].ToString();
                    row.NycCapNgay = string.IsNullOrEmpty(reader["nyc_cap_ngay"].ToString()) ? (DateTime?)null : DateTime.Parse(reader["nyc_cap_ngay"].ToString());
                    row.NycNoiCap = reader["nyc_noi_cap"].ToString();
                    row.NycXom = reader["nyc_xom"].ToString();
                    row.NycXa = reader["nyc_xa"].ToString();
                    row.NycHuyen = reader["nyc_huyen"].ToString();
                    row.NycTinh = reader["nyc_tinh"].ToString();
                    row.MaBenhNhan = reader["ma_benh_nhan"].ToString();
                    row.TenBenhNhan = reader["ten_benh_nhan"].ToString();
                    row.NgaySinh = string.IsNullOrEmpty(reader["ngay_sinh"].ToString()) ? (DateTime?)null : DateTime.Parse(reader["ngay_sinh"].ToString());
                    row.TenKhoa = reader["ten_khoa"].ToString();
                    row.BacSy = reader["bac_sy"].ToString();
                    row.HanhDong = reader["hanh_dong"].ToString();
                    row.NgayTao = string.IsNullOrEmpty(reader["ngay_tao"].ToString()) ? (DateTime?)null : DateTime.Parse(reader["ngay_tao"].ToString());
                    row.NguoiTao = reader["nguoi_tao"].ToString();
                    row.NgaySua = string.IsNullOrEmpty(reader["ngay_sua"].ToString()) ? (DateTime?)null : DateTime.Parse(reader["ngay_sua"].ToString());
                    row.NguoiSua = reader["nguoi_sua"].ToString();
                    row.MaSoKy = reader["masokyten"].ToString();
                    row.DaKy = !string.IsNullOrEmpty(row.MaSoKy) ? true : false;
                    lstData.Add(row);
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return lstData;
        }

        public static bool Delete(long Id, MDB.MDBConnection MyConnection)
        {
            bool result = false;
            try
            {
                string sql = @"DELETE CAMKETDIEUTRITRUYENMAU WHERE id = :id";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("id", Id));
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                result = n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return result;
        }

        public static bool Insert(CamKetDieuTriTruyenMauInterface CamKetDieuTriTruyenMau, MDB.MDBConnection MyConnection)
        {
            bool result = false;
            try
            {
                string sql = @"insert into CAMKETDIEUTRITRUYENMAU
                              (nyc_ten, MAQUANLY, nyc_gioi_tinh, nyc_cmtnd, nyc_cap_ngay, nyc_noi_cap, nyc_xom, nyc_xa, nyc_huyen, nyc_tinh, ma_benh_nhan, ten_benh_nhan, ngay_sinh, ten_khoa, bac_sy, hanh_dong, ngay_tao, nguoi_tao, ngay_sua, nguoi_sua)
                            values
                              (:nyc_ten, :MAQUANLY, :nyc_gioi_tinh, :nyc_cmtnd, :nyc_cap_ngay, :nyc_noi_cap, :nyc_xom, :nyc_xa, :nyc_huyen, :nyc_tinh, :ma_benh_nhan, :ten_benh_nhan, :ngay_sinh, :ten_khoa, :bac_sy, :hanh_dong, :ngay_tao, :nguoi_tao, :ngay_sua, :nguoi_sua)";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("nyc_ten", CamKetDieuTriTruyenMau.NycTen));
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", CamKetDieuTriTruyenMau.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("nyc_gioi_tinh", CamKetDieuTriTruyenMau.NycGioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("nyc_cmtnd", CamKetDieuTriTruyenMau.NycCmtnd));
                Command.Parameters.Add(new MDB.MDBParameter("nyc_cap_ngay", CamKetDieuTriTruyenMau.NycCapNgay));
                Command.Parameters.Add(new MDB.MDBParameter("nyc_noi_cap", CamKetDieuTriTruyenMau.NycNoiCap));
                Command.Parameters.Add(new MDB.MDBParameter("nyc_xom", CamKetDieuTriTruyenMau.NycXom));
                Command.Parameters.Add(new MDB.MDBParameter("nyc_xa", CamKetDieuTriTruyenMau.NycXa));
                Command.Parameters.Add(new MDB.MDBParameter("nyc_huyen", CamKetDieuTriTruyenMau.NycHuyen));
                Command.Parameters.Add(new MDB.MDBParameter("nyc_tinh", CamKetDieuTriTruyenMau.NycTinh));
                Command.Parameters.Add(new MDB.MDBParameter("ma_benh_nhan", CamKetDieuTriTruyenMau.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("ten_benh_nhan", CamKetDieuTriTruyenMau.TenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("ngay_sinh", CamKetDieuTriTruyenMau.NgaySinh));
                Command.Parameters.Add(new MDB.MDBParameter("ten_khoa", CamKetDieuTriTruyenMau.TenKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("bac_sy", CamKetDieuTriTruyenMau.BacSy));
                Command.Parameters.Add(new MDB.MDBParameter("hanh_dong", CamKetDieuTriTruyenMau.HanhDong));
                Command.Parameters.Add(new MDB.MDBParameter("ngay_tao", DateTime.Now));
                Command.Parameters.Add(new MDB.MDBParameter("nguoi_tao", CamKetDieuTriTruyenMau.NguoiTao));
                Command.Parameters.Add(new MDB.MDBParameter("ngay_sua",null));
                Command.Parameters.Add(new MDB.MDBParameter("nguoi_sua", null));
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                result = n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return result;
        }

        public static bool Update(CamKetDieuTriTruyenMauInterface CamKetDieuTriTruyenMau, MDB.MDBConnection MyConnection)
        {
            bool result = false;
            try
            {
                string sql = @"update CAMKETDIEUTRITRUYENMAU
                               set nyc_ten = :nyc_ten,
                                MAQUANLY = :MAQUANLY,
                                nyc_gioi_tinh = :nyc_gioi_tinh,
                                nyc_cmtnd = :nyc_cmtnd,
                                nyc_cap_ngay = :nyc_cap_ngay,
                                nyc_noi_cap = :nyc_noi_cap,
                                nyc_xom = :nyc_xom,
                                nyc_xa = :nyc_xa,
                                nyc_huyen = :nyc_huyen,
                                nyc_tinh = :nyc_tinh,
                                ma_benh_nhan = :ma_benh_nhan,
                                ten_benh_nhan = :ten_benh_nhan,
                                ngay_sinh = :ngay_sinh,
                                ten_khoa = :ten_khoa,
                                bac_sy = :bac_sy,
                                hanh_dong = :hanh_dong,
                                ngay_sua = :ngay_sua,
                                nguoi_sua = :nguoi_sua
                             where id = :id";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("id", CamKetDieuTriTruyenMau.Id));
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", CamKetDieuTriTruyenMau.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("nyc_ten", CamKetDieuTriTruyenMau.NycTen));
                Command.Parameters.Add(new MDB.MDBParameter("nyc_gioi_tinh", CamKetDieuTriTruyenMau.NycGioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("nyc_cmtnd", CamKetDieuTriTruyenMau.NycCmtnd));
                Command.Parameters.Add(new MDB.MDBParameter("nyc_cap_ngay", CamKetDieuTriTruyenMau.NycCapNgay));
                Command.Parameters.Add(new MDB.MDBParameter("nyc_noi_cap", CamKetDieuTriTruyenMau.NycNoiCap));
                Command.Parameters.Add(new MDB.MDBParameter("nyc_xom", CamKetDieuTriTruyenMau.NycXom));
                Command.Parameters.Add(new MDB.MDBParameter("nyc_xa", CamKetDieuTriTruyenMau.NycXa));
                Command.Parameters.Add(new MDB.MDBParameter("nyc_huyen", CamKetDieuTriTruyenMau.NycHuyen));
                Command.Parameters.Add(new MDB.MDBParameter("nyc_tinh", CamKetDieuTriTruyenMau.NycTinh));
                Command.Parameters.Add(new MDB.MDBParameter("ma_benh_nhan", CamKetDieuTriTruyenMau.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("ten_benh_nhan", CamKetDieuTriTruyenMau.TenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("ngay_sinh", CamKetDieuTriTruyenMau.NgaySinh));
                Command.Parameters.Add(new MDB.MDBParameter("ten_khoa", CamKetDieuTriTruyenMau.TenKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("bac_sy", CamKetDieuTriTruyenMau.BacSy));
                Command.Parameters.Add(new MDB.MDBParameter("hanh_dong", CamKetDieuTriTruyenMau.HanhDong));
                Command.Parameters.Add(new MDB.MDBParameter("ngay_sua", DateTime.Now));
                Command.Parameters.Add(new MDB.MDBParameter("nguoi_sua", CamKetDieuTriTruyenMau.NguoiSua));
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                result = n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return result;
        }
        public static DataSet getDataSet(MDB.MDBConnection MyConnection, long id)
        {
            string sql = @"SELECT
                P.* 
            FROM
                CAMKETDIEUTRITRUYENMAU P
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "Table");

            ds.Tables[0].AddColumn("SOYTE", typeof(string));
            ds.Tables[0].AddColumn("BENHVIEN", typeof(string));
            ds.Tables[0].AddColumn("KHOA", typeof(string));

            ds.Tables[0].Rows[0]["SOYTE"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["KHOA"] = XemBenhAn._ThongTinDieuTri.Khoa;
            return ds;
        }
    }
}
