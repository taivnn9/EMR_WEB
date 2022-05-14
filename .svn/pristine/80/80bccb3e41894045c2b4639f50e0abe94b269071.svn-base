
using EMR.KyDienTu;
using System;
using System.Collections.Generic;
using PMS.Access; 

namespace EMR_MAIN.DATABASE.Other
{
    public class XacNhanBenhNhanCapCuuInterface : ThongTinKy
    {
        public XacNhanBenhNhanCapCuuInterface()
        {
            TableName = "BENHNHANCAPCUU";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.KDBNCC;
            TenMauPhieu = DanhMucPhieu.KDBNCC.Description();
        }
        public bool? Include { get; set; } = false;
        [MoTaDuLieu("Mã định danh")]
		public long Id { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        public DateTime? CapCuuLuc { get; set; }
        [MoTaDuLieu("Tên phòng")]
		public string TenPhong { get; set; }
        [MoTaDuLieu("Tên khoa")]
		public string TenKhoa { get; set; }
        [MoTaDuLieu("Chẩn đoán lúc vào viện")]
		public string ChanDoanLucVao { get; set; }
        [MoTaDuLieu("Chẩn đoán hiện tại")]
		public string ChanDoanHienTai { get; set; }
        public string TrieuChung { get; set; }
        [MoTaDuLieu("Xử trí")]
        public string XuTri { get; set; }
        public string LanhDaoKhoa { get; set; }
        public string BacSyTruc { get; set; }
        public DateTime? NgayTao { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        public DateTime? NgaySua { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        public string CapCuuLuc_Gio { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
    }

    public class XacNhanBenhNhanCapCuuStored
    {
        public const string TableName = "benhnhancapcuu";
        public const string TablePrimaryKeyName = "ID";
        public const string MaPhieu = "KDBNCC";
        public static List<XacNhanBenhNhanCapCuuInterface> GetList(decimal MaQuanLy, MDB.MDBConnection MyConnection)
        {
            List<XacNhanBenhNhanCapCuuInterface> lstData = new List<XacNhanBenhNhanCapCuuInterface>();
            try
            {
                string sql = @"select id, ma_benh_nhan, MAQUANLY, ten_benh_nhan, tuoi, gioi_tinh, dia_chi, cap_cuu_luc, chan_doan_luc_vao, chan_doan_hien_tai, ten_phong, ten_khoa, trieu_chung, xu_tri, lanh_dao_khoa, bac_sy_truc, ngay_tao, nguoi_tao, ngay_sua, nguoi_sua, masokyten from benhnhancapcuu where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
                MDB.MDBDataReader reader = Command.ExecuteReader();
                while (reader.Read())
                {
                    XacNhanBenhNhanCapCuuInterface row = new XacNhanBenhNhanCapCuuInterface();
                    row.Id = Convert.ToInt64(reader.GetLong("ID").ToString());
                    row.MaQuanLy = MaQuanLy;
                    row.MaBenhNhan = reader["ma_benh_nhan"].ToString();
                    row.TenBenhNhan = reader["ten_benh_nhan"].ToString();
                    row.Tuoi = reader["tuoi"].ToString();
                    row.GioiTinh = reader["gioi_tinh"].ToString();
                    row.DiaChi = reader["dia_chi"].ToString();
                    row.TenPhong = reader["ten_phong"].ToString();
                    row.TenKhoa = reader["ten_khoa"].ToString();
                    row.CapCuuLuc = string.IsNullOrEmpty(reader["cap_cuu_luc"].ToString()) ? (DateTime?)null : DateTime.Parse(reader["cap_cuu_luc"].ToString());
                    row.ChanDoanLucVao = reader["chan_doan_luc_vao"].ToString();
                    row.ChanDoanHienTai = reader["chan_doan_hien_tai"].ToString();
                    row.TrieuChung = reader["trieu_chung"].ToString();
                    row.XuTri = reader["xu_tri"].ToString();
                    row.LanhDaoKhoa = reader["lanh_dao_khoa"].ToString();
                    row.BacSyTruc = reader["bac_sy_truc"].ToString();
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
                string sql = @"DELETE benhnhancapcuu WHERE id = :id";
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

        public static bool Insert(ref XacNhanBenhNhanCapCuuInterface XacNhanBenhNhanCapCuu, MDB.MDBConnection MyConnection)
        {
            bool result = false;
            try
            {
                string sql = @"insert into benhnhancapcuu
                              (ma_benh_nhan, MAQUANLY, ten_benh_nhan, tuoi, gioi_tinh, dia_chi, cap_cuu_luc, chan_doan_luc_vao, chan_doan_hien_tai, ten_phong, ten_khoa, trieu_chung, xu_tri, lanh_dao_khoa, bac_sy_truc, ngay_tao, nguoi_tao, ngay_sua, nguoi_sua)
                            values
                              (:ma_benh_nhan, :MAQUANLY, :ten_benh_nhan, :tuoi, :gioi_tinh, :dia_chi, :cap_cuu_luc, :chan_doan_luc_vao, :chan_doan_hien_tai, :ten_phong, :ten_khoa, :trieu_chung, :xu_tri, :lanh_dao_khoa, :bac_sy_truc, :ngay_tao, :nguoi_tao, :ngay_sua, :nguoi_sua) RETURNING Id INTO :Id";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ma_benh_nhan", XacNhanBenhNhanCapCuu.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", XacNhanBenhNhanCapCuu.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("ten_benh_nhan", XacNhanBenhNhanCapCuu.TenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("tuoi", XacNhanBenhNhanCapCuu.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("gioi_tinh", XacNhanBenhNhanCapCuu.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("dia_chi", XacNhanBenhNhanCapCuu.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("ten_phong", XacNhanBenhNhanCapCuu.TenPhong));
                Command.Parameters.Add(new MDB.MDBParameter("ten_khoa", XacNhanBenhNhanCapCuu.TenKhoa));
                var capCuuLuc_Ngay = XacNhanBenhNhanCapCuu.CapCuuLuc.Value.Date.Add(new TimeSpan(0, 0, 0));
                var capCuuLuc_Gio = Convert.ToDateTime(XacNhanBenhNhanCapCuu.CapCuuLuc_Gio).TimeOfDay;
                var capCuuLuc = capCuuLuc_Ngay + capCuuLuc_Gio;
                Command.Parameters.Add(new MDB.MDBParameter("cap_cuu_luc", capCuuLuc));
                Command.Parameters.Add(new MDB.MDBParameter("chan_doan_luc_vao", XacNhanBenhNhanCapCuu.ChanDoanLucVao));
                Command.Parameters.Add(new MDB.MDBParameter("chan_doan_hien_tai", XacNhanBenhNhanCapCuu.ChanDoanHienTai));
                Command.Parameters.Add(new MDB.MDBParameter("trieu_chung", XacNhanBenhNhanCapCuu.TrieuChung));
                Command.Parameters.Add(new MDB.MDBParameter("xu_tri", XacNhanBenhNhanCapCuu.XuTri));
                Command.Parameters.Add(new MDB.MDBParameter("lanh_dao_khoa", XacNhanBenhNhanCapCuu.LanhDaoKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("bac_sy_truc", XacNhanBenhNhanCapCuu.BacSyTruc));
                Command.Parameters.Add(new MDB.MDBParameter("ngay_tao", DateTime.Now));
                Command.Parameters.Add(new MDB.MDBParameter("nguoi_tao", XacNhanBenhNhanCapCuu.NguoiTao));
                Command.Parameters.Add(new MDB.MDBParameter("ngay_sua", null));
                Command.Parameters.Add(new MDB.MDBParameter("nguoi_sua", null));
                Command.Parameters.Add(new MDB.MDBParameter("Id", XacNhanBenhNhanCapCuu.Id));
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                int nextval = Convert.ToInt32((Command.Parameters["Id"] as MDB.MDBParameter).Value);
                XacNhanBenhNhanCapCuu.Id = nextval;
                result = n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return result;
        }

        public static bool Update(XacNhanBenhNhanCapCuuInterface XacNhanBenhNhanCapCuu, MDB.MDBConnection MyConnection)
        {
            bool result = false;
            try
            {
                string sql = @"update benhnhancapcuu
                               set ma_benh_nhan = :ma_benh_nhan,
                                   MAQUANLY = :MAQUANLY,
                                   ten_benh_nhan = :ten_benh_nhan,
                                   tuoi = :tuoi,
                                   gioi_tinh = :gioi_tinh,
                                   dia_chi = :dia_chi,
                                   cap_cuu_luc = :cap_cuu_luc,
                                   chan_doan_luc_vao = :chan_doan_luc_vao,
                                   chan_doan_hien_tai = :chan_doan_hien_tai,
                                   ten_phong = :ten_phong,
                                   ten_khoa = :ten_khoa,
                                   trieu_chung = :trieu_chung,
                                   xu_tri = :xu_tri,
                                   lanh_dao_khoa = :lanh_dao_khoa,
                                   bac_sy_truc = :bac_sy_truc,
                                   ngay_sua = :ngay_sua,
                                   nguoi_sua = :nguoi_sua
                             where id = :id";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("id", XacNhanBenhNhanCapCuu.Id));
                Command.Parameters.Add(new MDB.MDBParameter("ma_benh_nhan", XacNhanBenhNhanCapCuu.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", XacNhanBenhNhanCapCuu.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("ten_benh_nhan", XacNhanBenhNhanCapCuu.TenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("tuoi", XacNhanBenhNhanCapCuu.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("gioi_tinh", XacNhanBenhNhanCapCuu.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("dia_chi", XacNhanBenhNhanCapCuu.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("ten_phong", XacNhanBenhNhanCapCuu.TenPhong));
                Command.Parameters.Add(new MDB.MDBParameter("ten_khoa", XacNhanBenhNhanCapCuu.TenKhoa));
                var capCuuLuc_Ngay = XacNhanBenhNhanCapCuu.CapCuuLuc.Value.Date.Add(new TimeSpan(0, 0, 0));
                var capCuuLuc_Gio = Convert.ToDateTime(XacNhanBenhNhanCapCuu.CapCuuLuc_Gio).TimeOfDay;
                var capCuuLuc = capCuuLuc_Ngay + capCuuLuc_Gio;
                Command.Parameters.Add(new MDB.MDBParameter("cap_cuu_luc", capCuuLuc));
                Command.Parameters.Add(new MDB.MDBParameter("chan_doan_luc_vao", XacNhanBenhNhanCapCuu.ChanDoanLucVao));
                Command.Parameters.Add(new MDB.MDBParameter("chan_doan_hien_tai", XacNhanBenhNhanCapCuu.ChanDoanHienTai));
                Command.Parameters.Add(new MDB.MDBParameter("trieu_chung", XacNhanBenhNhanCapCuu.TrieuChung));
                Command.Parameters.Add(new MDB.MDBParameter("xu_tri", XacNhanBenhNhanCapCuu.XuTri));
                Command.Parameters.Add(new MDB.MDBParameter("lanh_dao_khoa", XacNhanBenhNhanCapCuu.LanhDaoKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("bac_sy_truc", XacNhanBenhNhanCapCuu.BacSyTruc));
                Command.Parameters.Add(new MDB.MDBParameter("ngay_sua", DateTime.Now));
                Command.Parameters.Add(new MDB.MDBParameter("nguoi_sua", XacNhanBenhNhanCapCuu.NguoiSua));
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
    }
}
