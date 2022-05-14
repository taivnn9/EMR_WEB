using EMR.KyDienTu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.Access; 

namespace EMR_MAIN.DATABASE.Other
{
    public class BenhNhanThayBangDaVetThuongInterface : ThongTinKy
    {
        public BenhNhanThayBangDaVetThuongInterface()
        {
            TableName = "THAYBANGDAVETTHUONG_BENHNHAN";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.TBDVT;
            TenMauPhieu = DanhMucPhieu.TBDVT.Description();
        }
        public bool? Include { get; set; } = false;
        [MoTaDuLieu("Mã định danh")]
		public long Id { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }

        [MoTaDuLieu("Tên khoa")]
		public string TenKhoa { get; set; }
        public string TenGiuong { get; set; }
        public DateTime? ThoiGianVao { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChuanDoan { get; set; }
        public string LoaiPhauThuat { get; set; }
        public DateTime? NgayTao { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        public DateTime? NgaySua { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        public string ThoiGianVao_Gio { get; set; }
        public string ThuTuRuaVetThuong { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
    }
    public class BenhNhanThayBangDaVetThuongStored
    {
        public static List<BenhNhanThayBangDaVetThuongInterface> GetList(decimal maQuanLy, MDB.MDBConnection MyConnection)
        {
            List<BenhNhanThayBangDaVetThuongInterface> lstData = new List<BenhNhanThayBangDaVetThuongInterface>();
            try
            {
                string sql = @"select id, ma_bn, ten_bn, tuoi, gioi_tinh,ten_khoa,giuong,thoi_gian_vao,chuan_doan, loai_phau_thuat, thu_tu_rua_vet_thuong, ngay_tao, nguoi_tao, ngay_sua, nguoi_sua from thaybangdavetthuong_benhnhan where MAQUANLY = :MAQUANLY";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", maQuanLy));
                MDB.MDBDataReader reader = Command.ExecuteReader();
                while (reader.Read())
                {
                    BenhNhanThayBangDaVetThuongInterface row = new BenhNhanThayBangDaVetThuongInterface();
                    row.Id = Convert.ToInt64(reader.GetLong("ID").ToString());
                    row.MaBenhNhan = reader["ma_bn"].ToString();
                    row.MaQuanLy = maQuanLy;
                    row.TenBenhNhan = reader["ten_bn"].ToString();
                    row.Tuoi = reader["tuoi"].ToString();
                    row.GioiTinh = reader["gioi_tinh"].ToString();
                    row.TenKhoa = reader["ten_khoa"].ToString();
                    row.TenGiuong = reader["giuong"].ToString();
                    row.ThoiGianVao = string.IsNullOrEmpty(reader["thoi_gian_vao"].ToString()) ? (DateTime?)null : DateTime.Parse(reader["thoi_gian_vao"].ToString());
                    row.ChuanDoan = reader["chuan_doan"].ToString();
                    row.LoaiPhauThuat = reader["loai_phau_thuat"].ToString();
                    row.NgayTao = string.IsNullOrEmpty(reader["ngay_tao"].ToString()) ? (DateTime?)null : DateTime.Parse(reader["ngay_tao"].ToString());
                    row.NguoiTao = reader["nguoi_tao"].ToString();
                    row.NgaySua = string.IsNullOrEmpty(reader["ngay_sua"].ToString()) ? (DateTime?)null : DateTime.Parse(reader["ngay_sua"].ToString());
                    row.NguoiSua = reader["nguoi_sua"].ToString();
                    row.ThuTuRuaVetThuong = reader["thu_tu_rua_vet_thuong"].ToString();
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
                string sql = @"DELETE thaybangdavetthuong_benhnhan  WHERE id = :id";
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

        public static int Insert(ref BenhNhanThayBangDaVetThuongInterface BenhNhanThayBangDaVetThuong, MDB.MDBConnection MyConnection)
        {
            int result = 0;
            try
            {
                string sql = @"insert into thaybangdavetthuong_benhnhan
                              (ma_bn, MAQUANLY, ten_bn, tuoi, gioi_tinh,ten_khoa, giuong,thoi_gian_vao,chuan_doan,loai_phau_thuat, thu_tu_rua_vet_thuong, ngay_tao, nguoi_tao, ngay_sua, nguoi_sua)
                            values
                              (:ma_bn, :MAQUANLY, :ten_bn, :tuoi, :gioi_tinh, :ten_khoa, :giuong,:thoi_gian_vao, :chuan_doan, :loai_phau_thuat,:thu_tu_rua_vet_thuong, :ngay_tao, :nguoi_tao, :ngay_sua, :nguoi_sua)
                            returning id into :id";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", BenhNhanThayBangDaVetThuong.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("ma_bn", BenhNhanThayBangDaVetThuong.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("ten_bn", BenhNhanThayBangDaVetThuong.TenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("tuoi", BenhNhanThayBangDaVetThuong.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("gioi_tinh", BenhNhanThayBangDaVetThuong.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("ten_khoa", BenhNhanThayBangDaVetThuong.TenKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("giuong", BenhNhanThayBangDaVetThuong.TenGiuong));
                var ThoiGianVao_Ngay = BenhNhanThayBangDaVetThuong.ThoiGianVao.Value.Date.Add(new TimeSpan(0, 0, 0));
                var ThoiGianVao_Gio = Convert.ToDateTime(BenhNhanThayBangDaVetThuong.ThoiGianVao_Gio).TimeOfDay;
                var ThoiGianVao = ThoiGianVao_Ngay + ThoiGianVao_Gio;
                Command.Parameters.Add(new MDB.MDBParameter("thoi_gian_vao", ThoiGianVao));
                Command.Parameters.Add(new MDB.MDBParameter("chuan_doan", BenhNhanThayBangDaVetThuong.ChuanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("loai_phau_thuat", BenhNhanThayBangDaVetThuong.LoaiPhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("ngay_tao", DateTime.Now));
                Command.Parameters.Add(new MDB.MDBParameter("nguoi_tao", BenhNhanThayBangDaVetThuong.NguoiTao));
                Command.Parameters.Add(new MDB.MDBParameter("ngay_sua", null));
                Command.Parameters.Add(new MDB.MDBParameter("nguoi_sua", null));
                Command.Parameters.Add(new MDB.MDBParameter("thu_tu_rua_vet_thuong", BenhNhanThayBangDaVetThuong.ThuTuRuaVetThuong));
                Command.Parameters.Add(new MDB.MDBParameter("id", BenhNhanThayBangDaVetThuong.Id));
                Command.BindByName = true;
                result = Command.ExecuteNonQuery();
                long nextval = Convert.ToInt64((Command.Parameters["id"] as MDB.MDBParameter).Value);
                BenhNhanThayBangDaVetThuong.Id = nextval;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return result;
        }

        public static int Update(BenhNhanThayBangDaVetThuongInterface BenhNhanThayBangDaVetThuong, MDB.MDBConnection MyConnection)
        {
            int result = 0;
            try
            {
                string sql = @"update thaybangdavetthuong_benhnhan
                               set 
                                   ma_bn = :ma_bn,
                                   ten_bn = :ten_bn,
                                   tuoi = :tuoi,
                                   gioi_tinh = :gioi_tinh,
                                   ten_khoa = :ten_khoa,
                                   giuong=:giuong,
                                   chuan_doan=:chuan_doan,
                                   loai_phau_thuat=:loai_phau_thuat,
                                   ngay_sua = :ngay_sua,
                                   nguoi_sua = :nguoi_sua,
                                   thu_tu_rua_vet_thuong = :thu_tu_rua_vet_thuong,
                                   MAQUANLY = :MAQUANLY
                             where id = :id";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("id", BenhNhanThayBangDaVetThuong.Id));
                Command.Parameters.Add(new MDB.MDBParameter("ma_bn", BenhNhanThayBangDaVetThuong.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", BenhNhanThayBangDaVetThuong.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("ten_bn", BenhNhanThayBangDaVetThuong.TenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("tuoi", BenhNhanThayBangDaVetThuong.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("gioi_tinh", BenhNhanThayBangDaVetThuong.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("ten_khoa", BenhNhanThayBangDaVetThuong.TenKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("giuong", BenhNhanThayBangDaVetThuong.TenGiuong));
                var ThoiGianVao_Ngay = BenhNhanThayBangDaVetThuong.ThoiGianVao.Value.Date.Add(new TimeSpan(0, 0, 0));
                var ThoiGianVao_Gio = Convert.ToDateTime(BenhNhanThayBangDaVetThuong.ThoiGianVao_Gio).TimeOfDay;
                var ThoiGianVao = ThoiGianVao_Ngay + ThoiGianVao_Gio;
                Command.Parameters.Add(new MDB.MDBParameter("thoi_gian_vao", ThoiGianVao));
                Command.Parameters.Add(new MDB.MDBParameter("chuan_doan", BenhNhanThayBangDaVetThuong.ChuanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("loai_phau_thuat", BenhNhanThayBangDaVetThuong.LoaiPhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("ngay_sua", DateTime.Now));
                Command.Parameters.Add(new MDB.MDBParameter("nguoi_sua", BenhNhanThayBangDaVetThuong.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("thu_tu_rua_vet_thuong", BenhNhanThayBangDaVetThuong.ThuTuRuaVetThuong));
                Command.BindByName = true;
                result = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return result;
        }
    }


    public class BacSyThayBangDaVetThuongInterface
    {
        public bool? Include { get; set; } = false;
        [MoTaDuLieu("Mã định danh")]
		public long Id { get; set; }
        public long BenhNhanId { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        public string TenBacSy { get; set; }
        public string TenDieuDuong { get; set; }
        public DateTime? ThoiGianPhauThuat { get; set; }
        public string DienBienBenhNhan { get; set; }
        public DateTime? NgayTao { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        public DateTime? NgaySua { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        public string ThoiGianPhauThuat_Gio { get; set; }

    }
    public class BacSyThayBangDaVetThuongStored
    {
        public static List<BacSyThayBangDaVetThuongInterface> GetList(long bnId, MDB.MDBConnection MyConnection)
        {
            List<BacSyThayBangDaVetThuongInterface> lstData = new List<BacSyThayBangDaVetThuongInterface>();
            try
            {
                string sql = @"select id, thoigian_phauthuat, ten_bs, ten_dd, ma_bn, dienbien_benhnhan, ngay_tao, nguoi_tao, ngay_sua, nguoi_sua from thaybangdavetthuong_bacsy where bn_id = :bn_id";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("bn_id", bnId));
                MDB.MDBDataReader reader = Command.ExecuteReader();
                while (reader.Read())
                {
                    BacSyThayBangDaVetThuongInterface row = new BacSyThayBangDaVetThuongInterface();
                    row.Id = Convert.ToInt64(reader.GetLong("ID").ToString());
                    row.TenBacSy = reader["ten_bs"].ToString();
                    row.TenDieuDuong = reader["ten_dd"].ToString();
                    row.MaBenhNhan = reader["ma_bn"].ToString();
                    row.ThoiGianPhauThuat = string.IsNullOrEmpty(reader["thoigian_phauthuat"].ToString()) ? (DateTime?)null : DateTime.Parse(reader["thoigian_phauthuat"].ToString());
                    row.DienBienBenhNhan = reader["dienbien_benhnhan"].ToString();
                    row.NgayTao = string.IsNullOrEmpty(reader["ngay_tao"].ToString()) ? (DateTime?)null : DateTime.Parse(reader["ngay_tao"].ToString());
                    row.NguoiTao = reader["nguoi_tao"].ToString();
                    row.NgaySua = string.IsNullOrEmpty(reader["ngay_sua"].ToString()) ? (DateTime?)null : DateTime.Parse(reader["ngay_sua"].ToString());
                    row.NguoiSua = reader["nguoi_sua"].ToString();
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
                string sql = @"DELETE thaybangdavetthuong_bacsy  WHERE id = :id";
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

        public static bool Insert(ref BacSyThayBangDaVetThuongInterface BacSyThayBangDaVetThuong, MDB.MDBConnection MyConnection)
        {
            bool result = false;
            string sql = @"insert into thaybangdavetthuong_bacsy
                                  (ten_bs, ten_dd, ma_bn, dienbien_benhnhan, ngay_tao, nguoi_tao,  thoigian_phauthuat,bn_id)
                                values
                                  (:ten_bs, :ten_dd, :ma_bn, :dienbien_benhnhan, :ngay_tao, :nguoi_tao,:thoigian_phauthuat,:bn_id) returning id into :id";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("ten_bs", BacSyThayBangDaVetThuong.TenBacSy));
            Command.Parameters.Add(new MDB.MDBParameter("ten_dd", BacSyThayBangDaVetThuong.TenDieuDuong));
            Command.Parameters.Add(new MDB.MDBParameter("ma_bn", BacSyThayBangDaVetThuong.MaBenhNhan));
            var thoiGianPhauThuat_Ngay = BacSyThayBangDaVetThuong.ThoiGianPhauThuat.Value.Date.Add(new TimeSpan(0, 0, 0));
            var thoiGianPhauThuat_Gio = Convert.ToDateTime(BacSyThayBangDaVetThuong.ThoiGianPhauThuat_Gio).TimeOfDay;
            var thoiGianPhauThuat = thoiGianPhauThuat_Ngay + thoiGianPhauThuat_Gio;
            Command.Parameters.Add(new MDB.MDBParameter("thoigian_phauthuat", thoiGianPhauThuat));
            Command.Parameters.Add(new MDB.MDBParameter("dienbien_benhnhan", BacSyThayBangDaVetThuong.DienBienBenhNhan));
            Command.Parameters.Add(new MDB.MDBParameter("ngay_tao", DateTime.Now));
            Command.Parameters.Add(new MDB.MDBParameter("nguoi_tao", BacSyThayBangDaVetThuong.NguoiTao));
            Command.Parameters.Add(new MDB.MDBParameter("bn_id", BacSyThayBangDaVetThuong.BenhNhanId));
            Command.Parameters.Add(new MDB.MDBParameter("id", BacSyThayBangDaVetThuong.Id));
            Command.BindByName = true;
            int n = Command.ExecuteNonQuery();
            long nextval = Convert.ToInt64((Command.Parameters["id"] as MDB.MDBParameter).Value);
            BacSyThayBangDaVetThuong.Id = nextval;
            result = n > 0 ? true : false;

            return result;

        }

        public static bool Update(BacSyThayBangDaVetThuongInterface BacSyThayBangDaVetThuong, MDB.MDBConnection MyConnection)
        {
            bool result = false;
            string sql = @"update thaybangdavetthuong_bacsy
                               set ten_bs = :ten_bs,
                                   ten_dd = :ten_dd,
                                   dienbien_benhnhan = :dienbien_benhnhan,
                                   ngay_sua = :ngay_sua,
                                   nguoi_sua = :nguoi_sua,
                                   thoigian_phauthuat = :thoigian_phauthuat
                             where id = :id";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("id", BacSyThayBangDaVetThuong.Id));
            Command.Parameters.Add(new MDB.MDBParameter("ten_bs", BacSyThayBangDaVetThuong.TenBacSy));
            Command.Parameters.Add(new MDB.MDBParameter("ten_dd", BacSyThayBangDaVetThuong.TenDieuDuong));
            var thoiGianPhauThuat_Ngay = BacSyThayBangDaVetThuong.ThoiGianPhauThuat.Value.Date.Add(new TimeSpan(0, 0, 0));
            var thoiGianPhauThuat_Gio = Convert.ToDateTime(BacSyThayBangDaVetThuong.ThoiGianPhauThuat_Gio).TimeOfDay;
            var thoiGianPhauThuat = thoiGianPhauThuat_Ngay + thoiGianPhauThuat_Gio;
            Command.Parameters.Add(new MDB.MDBParameter("thoigian_phauthuat", thoiGianPhauThuat));
            Command.Parameters.Add(new MDB.MDBParameter("dienbien_benhnhan", BacSyThayBangDaVetThuong.DienBienBenhNhan));
            Command.Parameters.Add(new MDB.MDBParameter("ngay_sua", DateTime.Now));
            Command.Parameters.Add(new MDB.MDBParameter("nguoi_sua", BacSyThayBangDaVetThuong.NguoiSua));
            Command.BindByName = true;
            int n = Command.ExecuteNonQuery();
            result = n > 0 ? true : false;

            return result;
        }
    }
}
