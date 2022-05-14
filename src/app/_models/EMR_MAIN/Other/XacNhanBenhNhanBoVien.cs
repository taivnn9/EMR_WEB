
using EMR.KyDienTu;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.Access; 

namespace EMR_MAIN.DATABASE.Other
{
    public class XacNhanBenhNhanBoVienInterface : ThongTinKy
    {
        public XacNhanBenhNhanBoVienInterface()
        {
            TableName = "BENHNHANBOVE";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.KDBNBV;
            TenMauPhieu = DanhMucPhieu.KDBNBV.Description();
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
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Tên phòng")]
		public string TenPhong { get; set; }
        [MoTaDuLieu("Tên khoa")]
		public string TenKhoa { get; set; }
        public string SoGioVangMat { get; set; }
        public DateTime? PhatHienLuc { get; set; }
        public string SoLuuTru { get; set; }
        public string ThanhVien1 { get; set; }
        public string ThanhVien2 { get; set; }
        public string ThanhVien3 { get; set; }
        public string ThanhVien4 { get; set; }
        public string ThanhVien5 { get; set; }
        public DateTime? NgayTao { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        public DateTime? NgaySua { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        public string PhatHienLuc_Gio { get; set; }
        public string MaNVThanhVien1 { get; set; }
        public string MaNVThanhVien2 { get; set; }
        public string MaNVThanhVien3 { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
    }

    public class XacNhanBenhNhanBoVienStored
    {
        public const string TableName = "benhnhanbove";
        public const string TablePrimaryKeyName = "ID";
        public const string MaPhieu = "KDBNBV";

        public static List<XacNhanBenhNhanBoVienInterface> GetList(decimal MaQuanLy, MDB.MDBConnection MyConnection)
        {
            List<XacNhanBenhNhanBoVienInterface> lstData = new List<XacNhanBenhNhanBoVienInterface>();
            try
            {
                string sql = @"select id, ma_benh_nhan, MAQUANLY, ten_benh_nhan, tuoi, gioi_tinh, dia_chi, chan_doan, ten_phong, ten_khoa, so_gio_vang_mat, phat_hien_luc, so_luu_tru, thanh_vien_1, thanh_vien_2, thanh_vien_3, thanh_vien_4, thanh_vien_5, ngay_tao, nguoi_tao, ngay_sua, nguoi_sua, manv_thanh_vien_1, manv_thanh_vien_2, manv_thanh_vien_3, masokyten from benhnhanbove where MaQuanLy = :MaQuanLy ";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
                MDB.MDBDataReader reader = Command.ExecuteReader();
                while (reader.Read())
                {
                    XacNhanBenhNhanBoVienInterface row = new XacNhanBenhNhanBoVienInterface();
                    row.Id = Convert.ToInt64(reader.GetLong("ID").ToString());
                    row.MaBenhNhan = reader["ma_benh_nhan"].ToString();
                    row.MaQuanLy = MaQuanLy; 
                    row.TenBenhNhan = reader["ten_benh_nhan"].ToString();
                    row.Tuoi = reader["tuoi"].ToString();
                    row.GioiTinh = reader["gioi_tinh"].ToString();
                    row.DiaChi = reader["dia_chi"].ToString();
                    row.ChanDoan = reader["chan_doan"].ToString();
                    row.TenPhong = reader["ten_phong"].ToString();
                    row.TenKhoa = reader["ten_khoa"].ToString();
                    row.SoGioVangMat = reader["so_gio_vang_mat"].ToString();
                    row.PhatHienLuc = string.IsNullOrEmpty(reader["phat_hien_luc"].ToString()) ? (DateTime?)null : DateTime.Parse(reader["phat_hien_luc"].ToString());
                    row.SoLuuTru = reader["so_luu_tru"].ToString();
                    row.ThanhVien1 = reader["thanh_vien_1"].ToString();
                    row.ThanhVien2 = reader["thanh_vien_2"].ToString();
                    row.ThanhVien3 = reader["thanh_vien_3"].ToString();
                    row.ThanhVien4 = reader["thanh_vien_4"].ToString();
                    row.ThanhVien5 = reader["thanh_vien_5"].ToString();
                    row.NgayTao = string.IsNullOrEmpty(reader["ngay_tao"].ToString()) ? (DateTime?)null : DateTime.Parse(reader["ngay_tao"].ToString());
                    row.NguoiTao = reader["nguoi_tao"].ToString();
                    row.NgaySua = string.IsNullOrEmpty(reader["ngay_sua"].ToString()) ? (DateTime?)null : DateTime.Parse(reader["ngay_sua"].ToString());
                    row.NguoiSua = reader["nguoi_sua"].ToString();
                    row.MaNVThanhVien1 = reader["manv_thanh_vien_1"].ToString();
                    row.MaNVThanhVien2 = reader["manv_thanh_vien_2"].ToString();
                    row.MaNVThanhVien3 = reader["manv_thanh_vien_3"].ToString();
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
                string sql = @"DELETE benhnhanbove WHERE id = :id";
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
        public static bool Insert(XacNhanBenhNhanBoVienInterface XacNhanBenhNhanBoVien, MDB.MDBConnection MyConnection)
        {
            bool result = false;
            try
            {
                string sql = @"insert into benhnhanbove
                              (ma_benh_nhan, MAQUANLY, ten_benh_nhan, tuoi, gioi_tinh, dia_chi, chan_doan, ten_phong, ten_khoa, so_gio_vang_mat, phat_hien_luc, so_luu_tru, thanh_vien_1, thanh_vien_2, thanh_vien_3, thanh_vien_4, thanh_vien_5, ngay_tao, nguoi_tao, ngay_sua, nguoi_sua, manv_thanh_vien_1, manv_thanh_vien_2, manv_thanh_vien_3)
                            values
                              (:ma_benh_nhan, :MAQUANLY, :ten_benh_nhan, :tuoi, :gioi_tinh, :dia_chi, :chan_doan, :ten_phong, :ten_khoa, :so_gio_vang_mat, :phat_hien_luc, :so_luu_tru, :thanh_vien_1, :thanh_vien_2, :thanh_vien_3, :thanh_vien_4, :thanh_vien_5, :ngay_tao, :nguoi_tao, :ngay_sua, :nguoi_sua, :manv_thanh_vien_1, :manv_thanh_vien_2, :manv_thanh_vien_3)";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ma_benh_nhan", XacNhanBenhNhanBoVien.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", XacNhanBenhNhanBoVien.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("ten_benh_nhan", XacNhanBenhNhanBoVien.TenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("tuoi", XacNhanBenhNhanBoVien.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("gioi_tinh", XacNhanBenhNhanBoVien.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("dia_chi", XacNhanBenhNhanBoVien.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("chan_doan", XacNhanBenhNhanBoVien.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("ten_phong", XacNhanBenhNhanBoVien.TenPhong));
                Command.Parameters.Add(new MDB.MDBParameter("ten_khoa", XacNhanBenhNhanBoVien.TenKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("so_gio_vang_mat", XacNhanBenhNhanBoVien.SoGioVangMat));
                var phatHienLuc_Ngay = XacNhanBenhNhanBoVien.PhatHienLuc.Value.Date.Add(new TimeSpan(0, 0, 0));
                var phatHienLuc_Gio = Convert.ToDateTime(XacNhanBenhNhanBoVien.PhatHienLuc_Gio).TimeOfDay;
                var phatHienLuc = phatHienLuc_Ngay + phatHienLuc_Gio;
                Command.Parameters.Add(new MDB.MDBParameter("phat_hien_luc", phatHienLuc));
                Command.Parameters.Add(new MDB.MDBParameter("so_luu_tru", XacNhanBenhNhanBoVien.SoLuuTru));
                Command.Parameters.Add(new MDB.MDBParameter("thanh_vien_1", XacNhanBenhNhanBoVien.ThanhVien1));
                Command.Parameters.Add(new MDB.MDBParameter("thanh_vien_2", XacNhanBenhNhanBoVien.ThanhVien2));
                Command.Parameters.Add(new MDB.MDBParameter("thanh_vien_3", XacNhanBenhNhanBoVien.ThanhVien3));
                Command.Parameters.Add(new MDB.MDBParameter("thanh_vien_4", XacNhanBenhNhanBoVien.ThanhVien4));
                Command.Parameters.Add(new MDB.MDBParameter("thanh_vien_5", XacNhanBenhNhanBoVien.ThanhVien5));
                Command.Parameters.Add(new MDB.MDBParameter("ngay_tao", DateTime.Now));
                Command.Parameters.Add(new MDB.MDBParameter("nguoi_tao", XacNhanBenhNhanBoVien.NguoiTao));
                Command.Parameters.Add(new MDB.MDBParameter("ngay_sua", null));
                Command.Parameters.Add(new MDB.MDBParameter("nguoi_sua", null));
                Command.Parameters.Add(new MDB.MDBParameter("manv_thanh_vien_1", XacNhanBenhNhanBoVien.MaNVThanhVien1));
                Command.Parameters.Add(new MDB.MDBParameter("manv_thanh_vien_2", XacNhanBenhNhanBoVien.MaNVThanhVien2));
                Command.Parameters.Add(new MDB.MDBParameter("manv_thanh_vien_3", XacNhanBenhNhanBoVien.MaNVThanhVien3));
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
        public static bool Update(XacNhanBenhNhanBoVienInterface XacNhanBenhNhanBoVien, MDB.MDBConnection MyConnection)
        {
            bool result = false;
            try
            {
                string sql = @"update benhnhanbove
                               set ma_benh_nhan = :ma_benh_nhan,
                                   MAQUANLY = :MAQUANLY, 
                                   ten_benh_nhan = :ten_benh_nhan,
                                   tuoi = :tuoi,
                                   gioi_tinh = :gioi_tinh,
                                   dia_chi = :dia_chi,
                                   chan_doan = :chan_doan,
                                   ten_phong = :ten_phong,
                                   ten_khoa = :ten_khoa,
                                   so_gio_vang_mat = :so_gio_vang_mat,
                                   phat_hien_luc = :phat_hien_luc,
                                   so_luu_tru = :so_luu_tru,
                                   thanh_vien_1 = :thanh_vien_1,
                                   thanh_vien_2 = :thanh_vien_2,
                                   thanh_vien_3 = :thanh_vien_3,
                                   thanh_vien_4 = :thanh_vien_4,
                                   thanh_vien_5 = :thanh_vien_5,
                                   ngay_sua = :ngay_sua,
                                   nguoi_sua = :nguoi_sua,
                                   manv_thanh_vien_1 = :manv_thanh_vien_1,
                                   manv_thanh_vien_2 = :manv_thanh_vien_2,
                                   manv_thanh_vien_3 = :manv_thanh_vien_3
                             where id = :id";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("id", XacNhanBenhNhanBoVien.Id));
                Command.Parameters.Add(new MDB.MDBParameter("ma_benh_nhan", XacNhanBenhNhanBoVien.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", XacNhanBenhNhanBoVien.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("ten_benh_nhan", XacNhanBenhNhanBoVien.TenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("tuoi", XacNhanBenhNhanBoVien.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("gioi_tinh", XacNhanBenhNhanBoVien.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("dia_chi", XacNhanBenhNhanBoVien.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("chan_doan", XacNhanBenhNhanBoVien.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("ten_phong", XacNhanBenhNhanBoVien.TenPhong));
                Command.Parameters.Add(new MDB.MDBParameter("ten_khoa", XacNhanBenhNhanBoVien.TenKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("so_gio_vang_mat", XacNhanBenhNhanBoVien.SoGioVangMat));
                var phatHienLuc_Ngay = XacNhanBenhNhanBoVien.PhatHienLuc.Value.Date.Add(new TimeSpan(0, 0, 0));
                var phatHienLuc_Gio = Convert.ToDateTime(XacNhanBenhNhanBoVien.PhatHienLuc_Gio).TimeOfDay;
                var phatHienLuc = phatHienLuc_Ngay + phatHienLuc_Gio;
                Command.Parameters.Add(new MDB.MDBParameter("phat_hien_luc", phatHienLuc));
                Command.Parameters.Add(new MDB.MDBParameter("so_luu_tru", XacNhanBenhNhanBoVien.SoLuuTru));
                Command.Parameters.Add(new MDB.MDBParameter("thanh_vien_1", XacNhanBenhNhanBoVien.ThanhVien1));
                Command.Parameters.Add(new MDB.MDBParameter("thanh_vien_2", XacNhanBenhNhanBoVien.ThanhVien2));
                Command.Parameters.Add(new MDB.MDBParameter("thanh_vien_3", XacNhanBenhNhanBoVien.ThanhVien3));
                Command.Parameters.Add(new MDB.MDBParameter("thanh_vien_4", XacNhanBenhNhanBoVien.ThanhVien4));
                Command.Parameters.Add(new MDB.MDBParameter("thanh_vien_5", XacNhanBenhNhanBoVien.ThanhVien5));
                Command.Parameters.Add(new MDB.MDBParameter("ngay_sua", DateTime.Now));
                Command.Parameters.Add(new MDB.MDBParameter("nguoi_sua", XacNhanBenhNhanBoVien.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("manv_thanh_vien_1", XacNhanBenhNhanBoVien.MaNVThanhVien1));
                Command.Parameters.Add(new MDB.MDBParameter("manv_thanh_vien_2", XacNhanBenhNhanBoVien.MaNVThanhVien2));
                Command.Parameters.Add(new MDB.MDBParameter("manv_thanh_vien_3", XacNhanBenhNhanBoVien.MaNVThanhVien3));
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
