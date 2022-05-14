
using EMR.KyDienTu;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMR_MAIN.DATABASE.Other
{
    public class KiemDiemBenhNhanTuVongInterface : ThongTinKy
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
        [MoTaDuLieu("Tên khoa")]
		public string TenKhoa { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        public string SoVaoVien { get; set; }
        public DateTime? VaoVienLuc { get; set; }
        public DateTime? TuVongLuc { get; set; }
        public DateTime? KiemDiemTuVongLuc { get; set; }
        public DateTime? KiemDiemTuVongLuc_Gio { get; set; }
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
        public string TuVongLuc_Gio { get; set; }
        public string MaNVChuToa { get; set; }
        public string MaNVThuKy { get; set; }

    }

    public class KiemDiemBenhNhanTuVongStored
    {
        public const string TableName = "BENHNHANTUVONG";
        public const string TablePrimaryKeyName = "ID";
        public const string MaPhieu = "KDBNTV";
        public static List<KiemDiemBenhNhanTuVongInterface> GetList(decimal MaQuanLy, MDB.MDBConnection MyConnection)
        {
            List<KiemDiemBenhNhanTuVongInterface> lstData = new List<KiemDiemBenhNhanTuVongInterface>();
            try
            {
                string sql = @"select * from BENHNHANTUVONG where MAQUANLY = :MAQUANLY";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", MaQuanLy));
                MDB.MDBDataReader reader = Command.ExecuteReader();
                while (reader.Read())
                {
                    KiemDiemBenhNhanTuVongInterface row = new KiemDiemBenhNhanTuVongInterface();
                    row.Id = Convert.ToInt64(reader.GetLong("ID").ToString());
                    row.MaQuanLy = MaQuanLy;
                    row.MaBenhNhan = reader["ma_benh_nhan"].ToString();
                    row.TenBenhNhan = reader["ten_benh_nhan"].ToString();
                    row.TenKhoa = reader["TenKhoa"].ToString();
                    row.Tuoi = reader["tuoi"].ToString();
                    row.GioiTinh = reader["gioi_tinh"].ToString();
                    row.SoVaoVien = reader["so_vao_vien"].ToString();
                    row.VaoVienLuc = string.IsNullOrEmpty(reader["vao_vien_luc"].ToString()) ? (DateTime?)null : DateTime.Parse(reader["vao_vien_luc"].ToString());
                    row.TuVongLuc = string.IsNullOrEmpty(reader["tu_vong_luc"].ToString()) ? (DateTime?)null : DateTime.Parse(reader["tu_vong_luc"].ToString());
                    row.KiemDiemTuVongLuc = reader["KiemDiemTuVongLuc"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(reader["KiemDiemTuVongLuc"]) : null;
                    if (row.KiemDiemTuVongLuc.HasValue)
                    {
                        row.KiemDiemTuVongLuc_Gio = row.KiemDiemTuVongLuc;
                    }
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
                    row.MaNVChuToa = reader["manv_chu_toa"].ToString();
                    row.MaNVThuKy = reader["manv_thu_ky"].ToString();
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
                string sql = @"DELETE BENHNHANTUVONG WHERE id = :id";
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
        public static bool Insert(KiemDiemBenhNhanTuVongInterface KiemDiemBenhNhanTuVong, MDB.MDBConnection MyConnection)
        {
            bool result = false;
            try
            {
                string sql = @"insert into BENHNHANTUVONG 
                               (ten_benh_nhan, MAQUANLY, tuoi, TenKhoa, gioi_tinh, so_vao_vien, vao_vien_luc, tu_vong_luc, KiemDiemTuVongLuc, chu_toa, thu_ky, thanh_vien_tham_gia, tom_tat, ket_luan, so_luu_tru, ngay_tao, nguoi_tao, ngay_sua, nguoi_sua, ma_benh_nhan, manv_chu_toa, manv_thu_ky) 
                               values 
                               (:ten_benh_nhan, :MAQUANLY, :tuoi, :TenKhoa, :gioi_tinh, :so_vao_vien, :vao_vien_luc, :tu_vong_luc, :KiemDiemTuVongLuc, :chu_toa, :thu_ky, :thanh_vien_tham_gia, :tom_tat, :ket_luan, :so_luu_tru, :ngay_tao, :nguoi_tao, :ngay_sua, :nguoi_sua, :ma_benh_nhan, :manv_chu_toa, :manv_thu_ky)";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ten_benh_nhan", KiemDiemBenhNhanTuVong.TenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", KiemDiemBenhNhanTuVong.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("tuoi", KiemDiemBenhNhanTuVong.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("TenKhoa", KiemDiemBenhNhanTuVong.TenKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("gioi_tinh", KiemDiemBenhNhanTuVong.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("so_vao_vien", KiemDiemBenhNhanTuVong.SoVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("vao_vien_luc", KiemDiemBenhNhanTuVong.VaoVienLuc));
                var tuVongLuc_Ngay = KiemDiemBenhNhanTuVong.TuVongLuc.Value.Date.Add(new TimeSpan(0, 0, 0));
                string gio = "00:00";
                if (!string.IsNullOrEmpty(KiemDiemBenhNhanTuVong.TuVongLuc_Gio))
                {
                    string[] split = KiemDiemBenhNhanTuVong.TuVongLuc_Gio.Split(' ');
                    if (split.Length > 1)
                    {
                        gio = split[1];
                    }
                    else
                        gio = split[0];
                }
                var tuVongLuc_Gio = Convert.ToDateTime(gio).TimeOfDay;
                var tuVongLuc = tuVongLuc_Ngay + tuVongLuc_Gio;
                Command.Parameters.Add(new MDB.MDBParameter("tu_vong_luc", tuVongLuc));
                if (KiemDiemBenhNhanTuVong.KiemDiemTuVongLuc.HasValue)
                {
                    var thoiGianPhauThuat_Ngay = KiemDiemBenhNhanTuVong.KiemDiemTuVongLuc.Value.Date.Add(new TimeSpan(0, 0, 0));
                    if (KiemDiemBenhNhanTuVong.KiemDiemTuVongLuc_Gio.HasValue)
                    {
                        thoiGianPhauThuat_Ngay += Convert.ToDateTime(KiemDiemBenhNhanTuVong.KiemDiemTuVongLuc_Gio).TimeOfDay;
                    }
                    Command.Parameters.Add(new MDB.MDBParameter("KiemDiemTuVongLuc", thoiGianPhauThuat_Ngay));
                }
                else
                {
                    Command.Parameters.Add(new MDB.MDBParameter("KiemDiemTuVongLuc", KiemDiemBenhNhanTuVong.KiemDiemTuVongLuc));
                }    
                Command.Parameters.Add(new MDB.MDBParameter("chu_toa", KiemDiemBenhNhanTuVong.ChuToa));
                Command.Parameters.Add(new MDB.MDBParameter("thu_ky", KiemDiemBenhNhanTuVong.ThuKy));
                Command.Parameters.Add(new MDB.MDBParameter("thanh_vien_tham_gia", KiemDiemBenhNhanTuVong.ThanhVienThamGia));
                Command.Parameters.Add(new MDB.MDBParameter("tom_tat", KiemDiemBenhNhanTuVong.TomTat));
                Command.Parameters.Add(new MDB.MDBParameter("ket_luan", KiemDiemBenhNhanTuVong.KetLuan));
                Command.Parameters.Add(new MDB.MDBParameter("so_luu_tru", KiemDiemBenhNhanTuVong.SoLuuTru));
                Command.Parameters.Add(new MDB.MDBParameter("ngay_tao", DateTime.Now));
                Command.Parameters.Add(new MDB.MDBParameter("nguoi_tao", KiemDiemBenhNhanTuVong.NguoiTao));
                Command.Parameters.Add(new MDB.MDBParameter("ngay_sua", null));
                Command.Parameters.Add(new MDB.MDBParameter("nguoi_sua", null));
                Command.Parameters.Add(new MDB.MDBParameter("ma_benh_nhan", KiemDiemBenhNhanTuVong.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("manv_chu_toa", KiemDiemBenhNhanTuVong.MaNVChuToa));
                Command.Parameters.Add(new MDB.MDBParameter("manv_thu_ky", KiemDiemBenhNhanTuVong.MaNVThuKy));
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
        public static bool Update(KiemDiemBenhNhanTuVongInterface KiemDiemBenhNhanTuVong, MDB.MDBConnection MyConnection)
        {
            bool result = false;
            try
            {
                string sql = @"update BENHNHANTUVONG
                               set ten_benh_nhan = :ten_benh_nhan,
                                   MAQUANLY = :MAQUANLY,
                                   tuoi = :tuoi,
                                   TenKhoa = :TenKhoa,
                                   gioi_tinh = :gioi_tinh,
                                   so_vao_vien = :so_vao_vien,
                                   vao_vien_luc = :vao_vien_luc,
                                   tu_vong_luc = :tu_vong_luc,
                                   KiemDiemTuVongLuc = :KiemDiemTuVongLuc,
                                   chu_toa = :chu_toa,
                                   thu_ky = :thu_ky,
                                   thanh_vien_tham_gia = :thanh_vien_tham_gia,
                                   tom_tat = :tom_tat,
                                   ket_luan = :ket_luan,
                                   so_luu_tru = :so_luu_tru,
                                   ngay_sua = :ngay_sua,
                                   nguoi_sua = :nguoi_sua,
                                   ma_benh_nhan = :ma_benh_nhan,
                                   manv_chu_toa = :manv_chu_toa,
                                   manv_thu_ky = :manv_thu_ky
                             where id = :id";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("id", KiemDiemBenhNhanTuVong.Id));
                Command.Parameters.Add(new MDB.MDBParameter("ten_benh_nhan", KiemDiemBenhNhanTuVong.TenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", KiemDiemBenhNhanTuVong.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("tuoi", KiemDiemBenhNhanTuVong.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("TenKhoa", KiemDiemBenhNhanTuVong.TenKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("gioi_tinh", KiemDiemBenhNhanTuVong.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("so_vao_vien", KiemDiemBenhNhanTuVong.SoVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("vao_vien_luc", KiemDiemBenhNhanTuVong.VaoVienLuc));
                var tuVongLuc_Ngay = KiemDiemBenhNhanTuVong.TuVongLuc.Value.Date.Add(new TimeSpan(0, 0, 0));
                string gio = "00:00";
                if(!string.IsNullOrEmpty(KiemDiemBenhNhanTuVong.TuVongLuc_Gio))
                {
                    string[] split = KiemDiemBenhNhanTuVong.TuVongLuc_Gio.Split(' ');
                    if(split.Length > 1)
                    {
                        gio = split[1];
                    }
                    else
                        gio = split[0];
                }    
                var tuVongLuc_Gio = Convert.ToDateTime(gio).TimeOfDay;
                var tuVongLuc = tuVongLuc_Ngay + tuVongLuc_Gio;
                Command.Parameters.Add(new MDB.MDBParameter("tu_vong_luc", tuVongLuc));
                if (KiemDiemBenhNhanTuVong.KiemDiemTuVongLuc.HasValue)
                {
                    var thoiGianPhauThuat_Ngay = KiemDiemBenhNhanTuVong.KiemDiemTuVongLuc.Value.Date.Add(new TimeSpan(0, 0, 0));
                    if (KiemDiemBenhNhanTuVong.KiemDiemTuVongLuc_Gio.HasValue)
                    {
                        thoiGianPhauThuat_Ngay += Convert.ToDateTime(KiemDiemBenhNhanTuVong.KiemDiemTuVongLuc_Gio).TimeOfDay;
                    }
                    Command.Parameters.Add(new MDB.MDBParameter("KiemDiemTuVongLuc", thoiGianPhauThuat_Ngay));
                }
                else
                {
                    Command.Parameters.Add(new MDB.MDBParameter("KiemDiemTuVongLuc", KiemDiemBenhNhanTuVong.KiemDiemTuVongLuc));
                }
                Command.Parameters.Add(new MDB.MDBParameter("chu_toa", KiemDiemBenhNhanTuVong.ChuToa));
                Command.Parameters.Add(new MDB.MDBParameter("thu_ky", KiemDiemBenhNhanTuVong.ThuKy));
                Command.Parameters.Add(new MDB.MDBParameter("thanh_vien_tham_gia", KiemDiemBenhNhanTuVong.ThanhVienThamGia));
                Command.Parameters.Add(new MDB.MDBParameter("tom_tat", KiemDiemBenhNhanTuVong.TomTat));
                Command.Parameters.Add(new MDB.MDBParameter("ket_luan", KiemDiemBenhNhanTuVong.KetLuan));
                Command.Parameters.Add(new MDB.MDBParameter("so_luu_tru", KiemDiemBenhNhanTuVong.SoLuuTru));
                Command.Parameters.Add(new MDB.MDBParameter("ngay_sua", DateTime.Now));
                Command.Parameters.Add(new MDB.MDBParameter("nguoi_sua", KiemDiemBenhNhanTuVong.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("ma_benh_nhan", KiemDiemBenhNhanTuVong.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("manv_chu_toa", KiemDiemBenhNhanTuVong.MaNVChuToa));
                Command.Parameters.Add(new MDB.MDBParameter("manv_thu_ky", KiemDiemBenhNhanTuVong.MaNVThuKy));
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
                B.*,
                H.SOYTE,
                H.BENHVIEN,
                T.MaBenhAn, 
                C.hovaten chu_toa, D.hovaten thu_ky
            FROM
                BENHNHANTUVONG B
                LEFT JOIN HANHCHINHBENHNHAN H ON B.ma_benh_nhan = H.MABENHNHAN 
                LEFT JOIN THONGTINDIEUTRI T ON B.MAQUANLY = T.MAQUANLY 
                left join nhanvien C on B.manv_chu_toa = C.manhanvien 
                left join nhanvien D on B.manv_thu_ky = D.manhanvien 
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            adt.Fill(ds, "BB");

            return ds;
        }
    }

}
