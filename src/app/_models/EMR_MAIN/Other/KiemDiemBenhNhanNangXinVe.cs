
using EMR.KyDienTu;
using System;
using System.Collections.Generic;

namespace EMR_MAIN.DATABASE.Other
{
    public class KiemDiemBenhNhanNangXinVeInterface : ThongTinKy
    {
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
        public string SoVaoVien { get; set; }
        public DateTime? VaoVienLuc { get; set; }
        public DateTime? XinVeLuc { get; set; }
        public string ChuToa { get; set; }
        public string ThuKy { get; set; }
        public string ThanhVienThamGia { get; set; }
        public string TomTat { get; set; }
        public string KetLuan { get; set; }
        public string SoLuuTru { get; set; }
        public DateTime? NgayTao { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        public DateTime? NgaySua { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        public string VaoVienLuc_Gio { get; set; }
        public string XinVeLuc_Gio { get; set; }
    }

    public class KiemDiemBenhNhanNangXinVeStored
    {
        public static List<KiemDiemBenhNhanNangXinVeInterface> GetList(decimal MaQuanLy, MDB.MDBConnection MyConnection)
        {
            List<KiemDiemBenhNhanNangXinVeInterface> lstData = new List<KiemDiemBenhNhanNangXinVeInterface>();
            try
            {
                string sql = @"select id, MAQUANLY, ten_benh_nhan, tuoi, gioi_tinh, so_vao_vien, vao_vien_luc, xin_ve_luc, chu_toa, thu_ky, thanh_vien_tham_gia, tom_tat, ket_luan, so_luu_tru, ngay_tao, nguoi_tao, ngay_sua, nguoi_sua, ma_benh_nhan from benhnhannangxinve where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
                MDB.MDBDataReader reader = Command.ExecuteReader();
                while (reader.Read())
                {
                    KiemDiemBenhNhanNangXinVeInterface row = new KiemDiemBenhNhanNangXinVeInterface();
                    row.Id = Convert.ToInt64(reader.GetLong("ID").ToString());
                    row.MaQuanLy = MaQuanLy;
                    row.MaBenhNhan = reader["ma_benh_nhan"].ToString();
                    row.TenBenhNhan = reader["ten_benh_nhan"].ToString();
                    row.Tuoi = reader["tuoi"].ToString();
                    row.GioiTinh = reader["gioi_tinh"].ToString();
                    row.SoVaoVien = reader["so_vao_vien"].ToString();
                    row.VaoVienLuc = string.IsNullOrEmpty(reader["vao_vien_luc"].ToString()) ? (DateTime?)null : DateTime.Parse(reader["vao_vien_luc"].ToString());
                    row.XinVeLuc = string.IsNullOrEmpty(reader["xin_ve_luc"].ToString()) ? (DateTime?)null : DateTime.Parse(reader["xin_ve_luc"].ToString());
                    row.ChuToa = reader["chu_toa"].ToString();
                    row.ThuKy = reader["thu_ky"].ToString();
                    row.ThanhVienThamGia = reader["thanh_vien_tham_gia"].ToString();
                    row.TomTat = reader["tom_tat"].ToString();
                    row.KetLuan = reader["ket_luan"].ToString();
                    row.SoLuuTru = reader["so_luu_tru"].ToString();
                    row.NgayTao = string.IsNullOrEmpty(reader["ngay_tao"].ToString()) ? (DateTime?)null : DateTime.Parse(reader["ngay_tao"].ToString());
                    row.NguoiTao = reader["so_vao_vien"].ToString();
                    row.NgaySua = string.IsNullOrEmpty(reader["ngay_sua"].ToString()) ? (DateTime?)null : DateTime.Parse(reader["ngay_sua"].ToString());
                    row.NguoiSua = reader["so_vao_vien"].ToString();
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
                string sql = @"DELETE BENHNHANNANGXINVE WHERE id = :id";
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
        public static bool Insert(KiemDiemBenhNhanNangXinVeInterface KiemDiemBenhNhanNangXinVe, MDB.MDBConnection MyConnection)
        {
            bool result = false;
            try
            {
                string sql = @"insert into benhnhannangxinve 
                               (ten_benh_nhan, MAQUANLY, tuoi, gioi_tinh, so_vao_vien, vao_vien_luc, xin_ve_luc, chu_toa, thu_ky, thanh_vien_tham_gia, tom_tat, ket_luan, so_luu_tru, ngay_tao, nguoi_tao, ngay_sua, nguoi_sua, ma_benh_nhan) 
                               values 
                               (:ten_benh_nhan, :MAQUANLY, :tuoi, :gioi_tinh, :so_vao_vien, :vao_vien_luc, :xin_ve_luc, :chu_toa, :thu_ky, :thanh_vien_tham_gia, :tom_tat, :ket_luan, :so_luu_tru, :ngay_tao, :nguoi_tao, :ngay_sua, :nguoi_sua, :ma_benh_nhan)";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ten_benh_nhan", KiemDiemBenhNhanNangXinVe.TenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", KiemDiemBenhNhanNangXinVe.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("tuoi", KiemDiemBenhNhanNangXinVe.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("gioi_tinh", KiemDiemBenhNhanNangXinVe.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("so_vao_vien", KiemDiemBenhNhanNangXinVe.SoVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("vao_vien_luc", KiemDiemBenhNhanNangXinVe.VaoVienLuc));
                var xinVeLuc_Ngay = KiemDiemBenhNhanNangXinVe.XinVeLuc.Value.Date.Add(new TimeSpan(0, 0, 0));
                var xinVeLuc_Gio = Convert.ToDateTime(KiemDiemBenhNhanNangXinVe.XinVeLuc_Gio).TimeOfDay;
                var xinVeLuc = xinVeLuc_Ngay + xinVeLuc_Gio;
                Command.Parameters.Add(new MDB.MDBParameter("xin_ve_luc", xinVeLuc));
                Command.Parameters.Add(new MDB.MDBParameter("chu_toa", KiemDiemBenhNhanNangXinVe.ChuToa));
                Command.Parameters.Add(new MDB.MDBParameter("thu_ky", KiemDiemBenhNhanNangXinVe.ThuKy));
                Command.Parameters.Add(new MDB.MDBParameter("thanh_vien_tham_gia", KiemDiemBenhNhanNangXinVe.ThanhVienThamGia));
                Command.Parameters.Add(new MDB.MDBParameter("tom_tat", KiemDiemBenhNhanNangXinVe.TomTat));
                Command.Parameters.Add(new MDB.MDBParameter("ket_luan", KiemDiemBenhNhanNangXinVe.KetLuan));
                Command.Parameters.Add(new MDB.MDBParameter("so_luu_tru", KiemDiemBenhNhanNangXinVe.SoLuuTru));
                Command.Parameters.Add(new MDB.MDBParameter("ngay_tao", DateTime.Now));
                Command.Parameters.Add(new MDB.MDBParameter("nguoi_tao", KiemDiemBenhNhanNangXinVe.NguoiTao));
                Command.Parameters.Add(new MDB.MDBParameter("ngay_sua", null));
                Command.Parameters.Add(new MDB.MDBParameter("nguoi_sua", null));
                Command.Parameters.Add(new MDB.MDBParameter("ma_benh_nhan", KiemDiemBenhNhanNangXinVe.MaBenhNhan));
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
        public static bool Update(KiemDiemBenhNhanNangXinVeInterface KiemDiemBenhNhanNangXinVe, MDB.MDBConnection MyConnection)
        {
            bool result = false;
            try
            {
                string sql = @"update benhnhannangxinve
                               set ten_benh_nhan = :ten_benh_nhan,
                                   MAQUANLY = :MAQUANLY,
                                   tuoi = :tuoi,
                                   gioi_tinh = :gioi_tinh,
                                   so_vao_vien = :so_vao_vien,
                                   vao_vien_luc = :vao_vien_luc,
                                   xin_ve_luc = :xin_ve_luc,
                                   chu_toa = :chu_toa,
                                   thu_ky = :thu_ky,
                                   thanh_vien_tham_gia = :thanh_vien_tham_gia,
                                   tom_tat = :tom_tat,
                                   ket_luan = :ket_luan,
                                   so_luu_tru = :so_luu_tru,
                                   ngay_sua = :ngay_sua,
                                   nguoi_sua = :nguoi_sua,
                                   ma_benh_nhan = :ma_benh_nhan
                             where id = :id";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("id", KiemDiemBenhNhanNangXinVe.Id));
                Command.Parameters.Add(new MDB.MDBParameter("ten_benh_nhan", KiemDiemBenhNhanNangXinVe.TenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", KiemDiemBenhNhanNangXinVe.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("tuoi", KiemDiemBenhNhanNangXinVe.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("gioi_tinh", KiemDiemBenhNhanNangXinVe.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("so_vao_vien", KiemDiemBenhNhanNangXinVe.SoVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("vao_vien_luc", KiemDiemBenhNhanNangXinVe.VaoVienLuc));
                var xinVeLuc_Ngay = KiemDiemBenhNhanNangXinVe.XinVeLuc.Value.Date.Add(new TimeSpan(0, 0, 0));
                var xinVeLuc_Gio = Convert.ToDateTime(KiemDiemBenhNhanNangXinVe.XinVeLuc_Gio).TimeOfDay;
                var xinVeLuc = xinVeLuc_Ngay + xinVeLuc_Gio;
                Command.Parameters.Add(new MDB.MDBParameter("xin_ve_luc", xinVeLuc));
                Command.Parameters.Add(new MDB.MDBParameter("chu_toa", KiemDiemBenhNhanNangXinVe.ChuToa));
                Command.Parameters.Add(new MDB.MDBParameter("thu_ky", KiemDiemBenhNhanNangXinVe.ThuKy));
                Command.Parameters.Add(new MDB.MDBParameter("thanh_vien_tham_gia", KiemDiemBenhNhanNangXinVe.ThanhVienThamGia));
                Command.Parameters.Add(new MDB.MDBParameter("tom_tat", KiemDiemBenhNhanNangXinVe.TomTat));
                Command.Parameters.Add(new MDB.MDBParameter("ket_luan", KiemDiemBenhNhanNangXinVe.KetLuan));
                Command.Parameters.Add(new MDB.MDBParameter("so_luu_tru", KiemDiemBenhNhanNangXinVe.SoLuuTru));
                Command.Parameters.Add(new MDB.MDBParameter("ngay_sua", DateTime.Now));
                Command.Parameters.Add(new MDB.MDBParameter("nguoi_sua", KiemDiemBenhNhanNangXinVe.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("ma_benh_nhan", KiemDiemBenhNhanNangXinVe.MaBenhNhan));
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
