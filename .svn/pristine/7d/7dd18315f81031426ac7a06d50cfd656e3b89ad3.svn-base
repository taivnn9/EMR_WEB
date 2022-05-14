
using EMR.KyDienTu;
using System;
using System.Collections.Generic;
using System.Data;
using NLog;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class BangKiemAnToanThuThuat_CTTM : ThongTinKy
    {
        public BangKiemAnToanThuThuat_CTTM()
        {
            TableName = "BangKiemAnToanThuThuat_CTTM";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BKATTTCTTM;
            TenMauPhieu = DanhMucPhieu.BKATTTCTTM.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long Id { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChuanDoan { get; set; }
        [MoTaDuLieu("Phương thức can thiệp")]
        public string PhuongPhapCanThiep { get; set; }
        [MoTaDuLieu("Phương pháp gây tê")]
        public string PhuongPhapGayTe { get; set; }
        [MoTaDuLieu("NB đã được hội chẩn làm can thiệp")]
        public int NBDaDuocHoiChuanLamCanThiep { get; set; }
        [MoTaDuLieu("Can thiệp chương trình")]
        public int CanThiepChuongTrinh { get; set; }
        [MoTaDuLieu("Can thiệp cấp cứu")]
        public int CanThiepCapCuu { get; set; }
        //[start] Truoc Khi vao Phong can thiep
        [MoTaDuLieu("Phương pháp can thiệp đông y")]
        public int DongYPhuongPhapCanThiep { get; set; }
        [MoTaDuLieu("Sát trùng vị trí đường mạch máu")]
        public int SatTrungViTriDuongMachMau { get; set; }
        [MoTaDuLieu("Đã kiểm tra thiết bị gây mê")]
        public int DaKiemTraThietBiGayMe { get; set; }
        [MoTaDuLieu("")]
        public int PhuongTienTDChucNangBT { get; set; }
        public int NbTieuSuDiUng { get; set; }
        [MoTaDuLieu("Phương tiện sưởi ấm cho bệnh nhân")]
        public int PhuongTienSuoiAmChoBenhNhan { get; set; }
        public string PhuongTienSuoiAmChiTiet { get; set; }
        //[END]  Truoc Khi vao Phong can thiep
        //[Start] Truoc Khi Troc Mach
        public int CoCanThiepKhangSinh { get; set; }
        public int CacBatThuongCoTheXayRa { get; set; }
        public string ChiTietBatThuong { get; set; }
        public string ThoiGianThucHien { get; set; }
        public int PhuongTienThucHienDamBao { get; set; }
        public int CoCacVanDeGiVeThietBiKhong { get; set; }
        public string ChiTietVanDeThietBi { get; set; }
        public int DaGiaiThichVaTranAnNguoiBenh { get; set; }
        //[END] Truoc Khi Troc Mach
        //[START] truoc khi nguoi benh roi phong can thiep
        public int BangDuongDMDui { get; set; }
        public int BangDuongDMQuay { get; set; }
        public int BangDuongTinhMachDui { get; set; }
        public int DamBaoAnToanVaVoKhuan { get; set; }
        public int DungThuocTrongNgungTieuCau { get; set; }
        public string ThuocVanMach { get; set; }
        public int TheoDoiDauHieuSinhTon { get; set; }
        public int TheoDoiBangEp { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        public string NgayTaoStr { get; set; }
        public string NgaySuaStr { get; set; }
        //[END] truoc khi nguoi benh roi phong can thiep
        [MoTaDuLieu("Mã điều dưỡng 1")]
		public string MaDieuDuong1 { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng 1")]
		public string DieuDuong1 { get; set; }
        [MoTaDuLieu("Mã điều dưỡng 2")]
		public string MaDieuDuong2 { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng 2")]
		public string DieuDuong2 { get; set; }
        [MoTaDuLieu("Mã điều dưỡng 3")]
		public string MaDieuDuong3 { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng 3")]
		public string DieuDuong3 { get; set; }
        [MoTaDuLieu("Mã bác sĩ 1")]
        public string MaBacSy1 { get; set; }
        [MoTaDuLieu("Họ và tên bác sĩ 1")]
        public string BacSy1 { get; set; }
        [MoTaDuLieu("Mã bác sĩ 2")]
        public string MaBacSy2 { get; set; }
        [MoTaDuLieu("Họ và tên bác sĩ 2")]
        public string BacSy2 { get; set; }
        [MoTaDuLieu("Mã bác sĩ 3")]
        public string MaBacSy3 { get; set; }
        [MoTaDuLieu("Họ và tên bác sĩ 3")]
        public string BacSy3 { get; set; }
        public int ThuocVanManh_Check { get; set; }
        public int Khac_CheckBox { get; set; }
        public string Khac_TextBox { get; set; }
        [MoTaDuLieu("Mã ký")]
        public string Maky { get; set; }
    }

    public class BangKiemAnToanThuThuat_CTTMStored
    {
        public static List<BangKiemAnToanThuThuat_CTTM> GetList(decimal MaQuanLy, MDB.MDBConnection MyConnection, string s_Table)
        {
            List<BangKiemAnToanThuThuat_CTTM> lstData = new List<BangKiemAnToanThuThuat_CTTM>();
            try
            {
                string sql = @"select * from " + s_Table + " where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
                MDB.MDBDataReader reader = Command.ExecuteReader();
                while (reader.Read())
                {
                    BangKiemAnToanThuThuat_CTTM row = new BangKiemAnToanThuThuat_CTTM();
                    row.Id = Convert.ToInt64(reader.GetLong("id").ToString());
                    decimal temp = 0;
                    decimal.TryParse(reader["MAQUANLY"].ToString(), out temp);
                    row.MaQuanLy = temp;
                    row.TenBenhNhan = reader["ten_benh_nhan"].ToString();
                    row.GioiTinh = reader["nyc_gioi_tinh"].ToString();
                    row.Tuoi = reader["Tuoi"].ToString();
                    row.ChuanDoan = reader["chuan_doan"].ToString();
                    row.PhuongPhapCanThiep = reader["phuong_phap_can_thiep"].ToString();
                    row.PhuongPhapGayTe = reader["phuong_phap_gay_te"].ToString();
                    row.NBDaDuocHoiChuanLamCanThiep = reader.GetInt("nb_hoi_chuan_can_thiep");
                    row.CanThiepChuongTrinh = reader.GetInt("can_thiep_chuong_trinh");
                    row.CanThiepCapCuu = reader.GetInt("can_thiep_cap_cuu");
                    row.DongYPhuongPhapCanThiep = reader.GetInt("dong_y_can_thiep");
                    row.SatTrungViTriDuongMachMau = reader.GetInt("sat_trung_duong_mach_mau");
                    row.DaKiemTraThietBiGayMe = reader.GetInt("kiem_tra_thiet_bi");
                    row.PhuongTienTDChucNangBT = reader.GetInt("phuong_tien_hoat_dong_BT");
                    row.NbTieuSuDiUng = reader.GetInt("NB_tien_su_di_ung");
                    row.PhuongTienSuoiAmChoBenhNhan = reader.GetInt("phuong_tien_suoi_am");
                    row.CoCanThiepKhangSinh = reader.GetInt("co_can_thiep_khang_sinh");
                    row.CacBatThuongCoTheXayRa = reader.GetInt("cac_bat_thuong_co_the_xay_ra");
                    row.ChiTietBatThuong = reader["chi_tiet_bat_thuong"].ToString();
                    row.PhuongTienThucHienDamBao = reader.GetInt("phuong_tien_dam_bao");
                    row.CoCacVanDeGiVeThietBiKhong = reader.GetInt("van_de_gi_thiet_bi");
                    row.ChiTietVanDeThietBi = reader.GetString("chi_tiet_van_de_thiet_bi");
                    row.DaGiaiThichVaTranAnNguoiBenh = reader.GetInt("giai_thich_nguoi_benh");
                    row.BangDuongDMDui = reader.GetInt("bang_duong_dm_dui");
                    row.BangDuongDMQuay = reader.GetInt("bang_duong_dm_quay");
                    row.BangDuongTinhMachDui = reader.GetInt("bang_duong_tinh_mach_dui");
                    row.DamBaoAnToanVaVoKhuan = reader.GetInt("vo_khuan_he_thong_do_ap_luc");
                    row.DungThuocTrongNgungTieuCau = reader.GetInt("thuoc_trong_ngung_tieu_cau");
                    row.ThuocVanMach = reader.GetString("thuoc_van_mach");
                    row.TheoDoiDauHieuSinhTon = reader.GetInt("theo_doi_dau_hieu_sinh_ton");
                    row.TheoDoiBangEp = reader.GetInt("theo_doi_bang_ep");
                    row.MaBenhNhan = reader.GetString("ma_benh_nhan");
                    row.ThoiGianThucHien = reader.GetString("thoi_gian_can_thiep");
                    row.PhuongTienSuoiAmChiTiet = reader.GetString("chi_tiet_phuong_tien_suoi");
                    row.NguoiSua = reader.GetString("nguoi_sua");
                    row.NguoiTao = reader.GetString("nguoi_tao");

                    row.NgayTaoStr = reader["ngay_tao"].ToString();
                    row.NgaySuaStr = reader["ngay_sua"].ToString();

                    row.MaBacSy1 = reader["MaBacSy1"].ToString();
                    row.BacSy1 = reader["BacSy1"].ToString();
                    row.MaBacSy2 = reader["MaBacSy2"].ToString();
                    row.BacSy2 = reader["BacSy2"].ToString();
                    row.MaBacSy3 = reader["MaBacSy3"].ToString();
                    row.BacSy3 = reader["BacSy3"].ToString();
                    row.MaDieuDuong1 = reader["MaDieuDuong1"].ToString();
                    row.DieuDuong1 = reader["DieuDuong1"].ToString();
                    row.MaDieuDuong2 = reader["MaDieuDuong2"].ToString();
                    row.DieuDuong2 = reader["DieuDuong2"].ToString();
                    row.MaDieuDuong3 = reader["MaDieuDuong3"].ToString();
                    row.DieuDuong3 = reader["DieuDuong3"].ToString();
                    row.Khac_CheckBox = reader.GetInt("Khac_CheckBox");
                    row.Khac_TextBox = reader["Khac_TextBox"].ToString();
                    lstData.Add(row);
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return lstData;
        }

        public static bool Delete(long Id, MDB.MDBConnection MyConnection, string s_Table)
        {
            bool result = false;
            try
            {
                string sql = @"DELETE " + s_Table + " WHERE id = :id";
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

        public static bool Insert(BangKiemAnToanThuThuat_CTTM bangKiemAnToanThuThuat_CTTM, MDB.MDBConnection MyConnection, string s_Table)
        {
            bool result = false;
            try
            {
                string sql = @"insert into " + s_Table + " " +
                    "(MAQUANLY,ten_benh_nhan,nyc_gioi_tinh,Tuoi,chuan_doan,phuong_phap_can_thiep,phuong_phap_gay_te,nb_hoi_chuan_can_thiep,can_thiep_chuong_trinh"
                + ",can_thiep_cap_cuu,dong_y_can_thiep,sat_trung_duong_mach_mau,kiem_tra_thiet_bi,phuong_tien_hoat_dong_BT,"
                + "NB_tien_su_di_ung,phuong_tien_suoi_am,co_can_thiep_khang_sinh,cac_bat_thuong_co_the_xay_ra,chi_tiet_bat_thuong,"
                + "phuong_tien_dam_bao,van_de_gi_thiet_bi,chi_tiet_van_de_thiet_bi,giai_thich_nguoi_benh,bang_duong_dm_dui,"
                + "bang_duong_dm_quay,bang_duong_tinh_mach_dui,vo_khuan_he_thong_do_ap_luc,thuoc_trong_ngung_tieu_cau,thuoc_van_mach,theo_doi_dau_hieu_sinh_ton,theo_doi_bang_ep,ngay_tao, nguoi_tao, ngay_sua, nguoi_sua, ma_benh_nhan,thoi_gian_can_thiep,chi_tiet_phuong_tien_suoi,"
                + "MaBacSy1, BacSy1, MaBacSy2, BacSy2, MaBacSy3, BacSy3, MaDieuDuong1, DieuDuong1, MaDieuDuong2, DieuDuong2, MaDieuDuong3, DieuDuong3, ThuocVanManh_Check, Khac_CheckBox, Khac_TextBox)";

                sql = sql + "VALUES (:MaQuanLy , :TenBenhNhan, :NycGioiTinh , :Tuoi , :ChuanDoan , :PhuongPhapCanThiep, :PhuongPhapGayTe, :NBDaDuocHoiChuanLamCanThiep, :CanThiepChuongTrinh , :CanThiepCapCuu , :DongYPhuongPhapCanThiep, :SatTrungViTriDuongMachMau, :DaKiemTraThietBiGayMe, :PhuongTienTDChucNangBT, :NbTieuSuDiUng, :PhuongTienSuoiAmChoBenhNhan, :CoCanThiepKhangSinh, :CacBatThuongCoTheXayRa, :ChiTietBatThuong, :PhuongTienThucHienDamBao, :CoCacVanDeGiVeThietBiKhong, :ChiTietVanDeThietBi, :DaGiaiThichVaTranAnNguoiBenh, :BangDuongDMDui, :BangDuongDMQuay, :BangDuongTinhMachDui, :DamBaoAnToanVaVoKhuan, :DungThuocTrongNgungTieuCau, :ThuocVanMach, :TheoDoiDauHieuSinhTon, :TheoDoiBangEp, :ngay_tao, :nguoi_tao, :ngay_sua, :nguoi_sua, :MaBenhNhan, :ThoiGianThucHien, :PhuongTienSuoiAmChiTiet,";
                sql = sql + " :MaBacSy1, :BacSy1, :MaBacSy2, :BacSy2, :MaBacSy3, :BacSy3, :MaDieuDuong1, :DieuDuong1, :MaDieuDuong2, :DieuDuong2, :MaDieuDuong3, :DieuDuong3, :ThuocVanManh_Check, :Khac_CheckBox, :Khac_TextBox)";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangKiemAnToanThuThuat_CTTM.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("TenBenhNhan", bangKiemAnToanThuThuat_CTTM.TenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("NycGioiTinh", bangKiemAnToanThuThuat_CTTM.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("Tuoi", bangKiemAnToanThuThuat_CTTM.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("ChuanDoan", bangKiemAnToanThuThuat_CTTM.ChuanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapCanThiep", bangKiemAnToanThuThuat_CTTM.PhuongPhapCanThiep));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapGayTe", bangKiemAnToanThuThuat_CTTM.PhuongPhapGayTe));
                Command.Parameters.Add(new MDB.MDBParameter("NBDaDuocHoiChuanLamCanThiep", bangKiemAnToanThuThuat_CTTM.NBDaDuocHoiChuanLamCanThiep));
                Command.Parameters.Add(new MDB.MDBParameter("CanThiepChuongTrinh", bangKiemAnToanThuThuat_CTTM.CanThiepChuongTrinh));
                Command.Parameters.Add(new MDB.MDBParameter("CanThiepCapCuu", bangKiemAnToanThuThuat_CTTM.CanThiepCapCuu));
                Command.Parameters.Add(new MDB.MDBParameter("DongYPhuongPhapCanThiep", bangKiemAnToanThuThuat_CTTM.DongYPhuongPhapCanThiep));
                Command.Parameters.Add(new MDB.MDBParameter("SatTrungViTriDuongMachMau", bangKiemAnToanThuThuat_CTTM.SatTrungViTriDuongMachMau));
                Command.Parameters.Add(new MDB.MDBParameter("DaKiemTraThietBiGayMe", bangKiemAnToanThuThuat_CTTM.DaKiemTraThietBiGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongTienTDChucNangBT", bangKiemAnToanThuThuat_CTTM.PhuongTienTDChucNangBT));
                Command.Parameters.Add(new MDB.MDBParameter("NbTieuSuDiUng", bangKiemAnToanThuThuat_CTTM.NbTieuSuDiUng));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongTienSuoiAmChoBenhNhan", bangKiemAnToanThuThuat_CTTM.PhuongTienSuoiAmChoBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("CoCanThiepKhangSinh", bangKiemAnToanThuThuat_CTTM.CoCanThiepKhangSinh));
                Command.Parameters.Add(new MDB.MDBParameter("CacBatThuongCoTheXayRa", bangKiemAnToanThuThuat_CTTM.CacBatThuongCoTheXayRa));
                Command.Parameters.Add(new MDB.MDBParameter("ngay_tao", DateTime.Now));
                Command.Parameters.Add(new MDB.MDBParameter("nguoi_tao", bangKiemAnToanThuThuat_CTTM.NguoiTao));
                Command.Parameters.Add(new MDB.MDBParameter("ngay_sua", null));
                Command.Parameters.Add(new MDB.MDBParameter("nguoi_sua", null));
                Command.Parameters.Add(new MDB.MDBParameter("ChiTietBatThuong", bangKiemAnToanThuThuat_CTTM.ChiTietBatThuong));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongTienThucHienDamBao", bangKiemAnToanThuThuat_CTTM.PhuongTienThucHienDamBao));
                Command.Parameters.Add(new MDB.MDBParameter("CoCacVanDeGiVeThietBiKhong", bangKiemAnToanThuThuat_CTTM.CoCacVanDeGiVeThietBiKhong));
                Command.Parameters.Add(new MDB.MDBParameter("ChiTietVanDeThietBi", bangKiemAnToanThuThuat_CTTM.ChiTietVanDeThietBi));
                Command.Parameters.Add(new MDB.MDBParameter("DaGiaiThichVaTranAnNguoiBenh", bangKiemAnToanThuThuat_CTTM.DaGiaiThichVaTranAnNguoiBenh));
                Command.Parameters.Add(new MDB.MDBParameter("BangDuongDMDui", bangKiemAnToanThuThuat_CTTM.BangDuongDMDui));
                Command.Parameters.Add(new MDB.MDBParameter("BangDuongDMQuay", bangKiemAnToanThuThuat_CTTM.BangDuongDMQuay));
                Command.Parameters.Add(new MDB.MDBParameter("BangDuongTinhMachDui", bangKiemAnToanThuThuat_CTTM.BangDuongTinhMachDui));
                Command.Parameters.Add(new MDB.MDBParameter("DamBaoAnToanVaVoKhuan", bangKiemAnToanThuThuat_CTTM.DamBaoAnToanVaVoKhuan));
                Command.Parameters.Add(new MDB.MDBParameter("DungThuocTrongNgungTieuCau", bangKiemAnToanThuThuat_CTTM.DungThuocTrongNgungTieuCau));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocVanMach", bangKiemAnToanThuThuat_CTTM.ThuocVanMach));
                Command.Parameters.Add(new MDB.MDBParameter("TheoDoiDauHieuSinhTon", bangKiemAnToanThuThuat_CTTM.TheoDoiDauHieuSinhTon));
                Command.Parameters.Add(new MDB.MDBParameter("TheoDoiBangEp", bangKiemAnToanThuThuat_CTTM.TheoDoiBangEp));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", bangKiemAnToanThuThuat_CTTM.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianThucHien", bangKiemAnToanThuThuat_CTTM.ThoiGianThucHien));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongTienSuoiAmChiTiet", bangKiemAnToanThuThuat_CTTM.PhuongTienSuoiAmChiTiet));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSy1", bangKiemAnToanThuThuat_CTTM.MaBacSy1));
                Command.Parameters.Add(new MDB.MDBParameter("BacSy1", bangKiemAnToanThuThuat_CTTM.BacSy1));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSy2", bangKiemAnToanThuThuat_CTTM.MaBacSy2));
                Command.Parameters.Add(new MDB.MDBParameter("BacSy2", bangKiemAnToanThuThuat_CTTM.BacSy2));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSy3", bangKiemAnToanThuThuat_CTTM.MaBacSy3));
                Command.Parameters.Add(new MDB.MDBParameter("BacSy3", bangKiemAnToanThuThuat_CTTM.BacSy3));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuong1", bangKiemAnToanThuThuat_CTTM.MaDieuDuong1));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuong1", bangKiemAnToanThuThuat_CTTM.DieuDuong1));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuong2", bangKiemAnToanThuThuat_CTTM.MaDieuDuong2));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuong2", bangKiemAnToanThuThuat_CTTM.DieuDuong2));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuong3", bangKiemAnToanThuThuat_CTTM.MaDieuDuong3));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuong3", bangKiemAnToanThuThuat_CTTM.DieuDuong3));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocVanManh_Check", bangKiemAnToanThuThuat_CTTM.ThuocVanManh_Check));
                Command.Parameters.Add(new MDB.MDBParameter("Khac_CheckBox", bangKiemAnToanThuThuat_CTTM.Khac_CheckBox));
                Command.Parameters.Add(new MDB.MDBParameter("Khac_TextBox", bangKiemAnToanThuThuat_CTTM.Khac_TextBox));
                Command.BindByName = true;
               string temp = Command.CommandText.ToString();
                int n = Command.ExecuteNonQuery();
                result = n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return result;
        }

        public static bool Update(BangKiemAnToanThuThuat_CTTM bangKiemAnToanThuThuat_CTTM, MDB.MDBConnection MyConnection, string s_Table)
        {
            bool result = false;
            try
            {
                string sql = @"update " + s_Table + " set MAQUANLY = :MaQuanLy ,ten_benh_nhan = :TenBenhNhan,nyc_gioi_tinh = :NycGioiTinh ,Tuoi = :Tuoi ,chuan_doan = :ChuanDoan ,phuong_phap_can_thiep = :PhuongPhapCanThiep,"
                    + " phuong_phap_gay_te = :PhuongPhapGayTe,nb_hoi_chuan_can_thiep = :NBDaDuocHoiChuanLamCanThiep,can_thiep_chuong_trinh = :CanThiepChuongTrinh ,"
                    + " can_thiep_cap_cuu = :CanThiepCapCuu , dong_y_can_thiep = :DongYPhuongPhapCanThiep,sat_trung_duong_mach_mau = :SatTrungViTriDuongMachMau,"
                    + "kiem_tra_thiet_bi = :DaKiemTraThietBiGayMe,phuong_tien_hoat_dong_BT =:PhuongTienTDChucNangBT, "
                    + "NB_tien_su_di_ung = :NbTieuSuDiUng,phuong_tien_suoi_am = :PhuongTienSuoiAmChoBenhNhan, co_can_thiep_khang_sinh =:CoCanThiepKhangSinh,"
                    + "cac_bat_thuong_co_the_xay_ra = :CacBatThuongCoTheXayRa, chi_tiet_bat_thuong =:ChiTietBatThuong,phuong_tien_dam_bao = :PhuongTienThucHienDamBao, "
                    + "van_de_gi_thiet_bi = :CoCacVanDeGiVeThietBiKhong, chi_tiet_van_de_thiet_bi = :ChiTietVanDeThietBi,giai_thich_nguoi_benh = :DaGiaiThichVaTranAnNguoiBenh,"
                    + "bang_duong_dm_dui = :BangDuongDMDui,bang_duong_dm_quay =  :BangDuongDMQuay,bang_duong_tinh_mach_dui = :BangDuongTinhMachDui,vo_khuan_he_thong_do_ap_luc = :DamBaoAnToanVaVoKhuan,"
                    + "thuoc_trong_ngung_tieu_cau = :DungThuocTrongNgungTieuCau,thuoc_van_mach = :ThuocVanMach,theo_doi_dau_hieu_sinh_ton = :TheoDoiDauHieuSinhTon, theo_doi_bang_ep  = :TheoDoiBangEp,"
                    + "ngay_sua = :ngay_sua, nguoi_sua = :nguoi_sua, ma_benh_nhan = :MaBenhNhan,thoi_gian_can_thiep = :ThoiGianThucHien, chi_tiet_phuong_tien_suoi = :PhuongTienSuoiAmChiTiet," +
                    "MaBacSy1=:MaBacSy1, BacSy1 =:BacSy1, MaBacSy2 =:MaBacSy2, BacSy2 =:BacSy2, MaBacSy3 =:MaBacSy3, BacSy3 =:BacSy3, MaDieuDuong1 =:MaDieuDuong1, DieuDuong1 =:DieuDuong1, MaDieuDuong2 =:MaDieuDuong2, DieuDuong2 =:DieuDuong2, MaDieuDuong3 =:MaDieuDuong3, DieuDuong3 =:DieuDuong3, ThuocVanManh_Check= :ThuocVanManh_Check, Khac_CheckBox = :Khac_CheckBox, Khac_TextBox = :Khac_TextBox";

                sql = sql + "  where id = :id";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangKiemAnToanThuThuat_CTTM.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("TenBenhNhan", bangKiemAnToanThuThuat_CTTM.TenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("NycGioiTinh", bangKiemAnToanThuThuat_CTTM.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("Tuoi", bangKiemAnToanThuThuat_CTTM.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("ChuanDoan", bangKiemAnToanThuThuat_CTTM.ChuanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapCanThiep", bangKiemAnToanThuThuat_CTTM.PhuongPhapCanThiep));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapGayTe", bangKiemAnToanThuThuat_CTTM.PhuongPhapGayTe));
                Command.Parameters.Add(new MDB.MDBParameter("NBDaDuocHoiChuanLamCanThiep", bangKiemAnToanThuThuat_CTTM.NBDaDuocHoiChuanLamCanThiep));
                Command.Parameters.Add(new MDB.MDBParameter("CanThiepChuongTrinh", bangKiemAnToanThuThuat_CTTM.CanThiepChuongTrinh));
                Command.Parameters.Add(new MDB.MDBParameter("CanThiepCapCuu", bangKiemAnToanThuThuat_CTTM.CanThiepCapCuu));
                Command.Parameters.Add(new MDB.MDBParameter("DongYPhuongPhapCanThiep", bangKiemAnToanThuThuat_CTTM.DongYPhuongPhapCanThiep));
                Command.Parameters.Add(new MDB.MDBParameter("SatTrungViTriDuongMachMau", bangKiemAnToanThuThuat_CTTM.SatTrungViTriDuongMachMau));
                Command.Parameters.Add(new MDB.MDBParameter("DaKiemTraThietBiGayMe", bangKiemAnToanThuThuat_CTTM.DaKiemTraThietBiGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongTienTDChucNangBT", bangKiemAnToanThuThuat_CTTM.PhuongTienTDChucNangBT));
                Command.Parameters.Add(new MDB.MDBParameter("NbTieuSuDiUng", bangKiemAnToanThuThuat_CTTM.NbTieuSuDiUng));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongTienSuoiAmChoBenhNhan", bangKiemAnToanThuThuat_CTTM.PhuongTienSuoiAmChoBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("CoCanThiepKhangSinh", bangKiemAnToanThuThuat_CTTM.CoCanThiepKhangSinh));
                Command.Parameters.Add(new MDB.MDBParameter("CacBatThuongCoTheXayRa", bangKiemAnToanThuThuat_CTTM.CacBatThuongCoTheXayRa));
                Command.Parameters.Add(new MDB.MDBParameter("ngay_sua", DateTime.Now));
                Command.Parameters.Add(new MDB.MDBParameter("nguoi_sua", bangKiemAnToanThuThuat_CTTM.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("ChiTietBatThuong", bangKiemAnToanThuThuat_CTTM.ChiTietBatThuong));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongTienThucHienDamBao", bangKiemAnToanThuThuat_CTTM.PhuongTienThucHienDamBao));
                Command.Parameters.Add(new MDB.MDBParameter("CoCacVanDeGiVeThietBiKhong", bangKiemAnToanThuThuat_CTTM.CoCacVanDeGiVeThietBiKhong));
                Command.Parameters.Add(new MDB.MDBParameter("ChiTietVanDeThietBi", bangKiemAnToanThuThuat_CTTM.ChiTietVanDeThietBi));
                Command.Parameters.Add(new MDB.MDBParameter("DaGiaiThichVaTranAnNguoiBenh", bangKiemAnToanThuThuat_CTTM.DaGiaiThichVaTranAnNguoiBenh));
                Command.Parameters.Add(new MDB.MDBParameter("BangDuongDMDui", bangKiemAnToanThuThuat_CTTM.BangDuongDMDui));
                Command.Parameters.Add(new MDB.MDBParameter("BangDuongDMQuay", bangKiemAnToanThuThuat_CTTM.BangDuongDMQuay));
                Command.Parameters.Add(new MDB.MDBParameter("BangDuongTinhMachDui", bangKiemAnToanThuThuat_CTTM.BangDuongTinhMachDui));
                Command.Parameters.Add(new MDB.MDBParameter("DamBaoAnToanVaVoKhuan", bangKiemAnToanThuThuat_CTTM.DamBaoAnToanVaVoKhuan));
                Command.Parameters.Add(new MDB.MDBParameter("DungThuocTrongNgungTieuCau", bangKiemAnToanThuThuat_CTTM.DungThuocTrongNgungTieuCau));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocVanMach", bangKiemAnToanThuThuat_CTTM.ThuocVanMach));
                Command.Parameters.Add(new MDB.MDBParameter("TheoDoiDauHieuSinhTon", bangKiemAnToanThuThuat_CTTM.TheoDoiDauHieuSinhTon));
                Command.Parameters.Add(new MDB.MDBParameter("TheoDoiBangEp", bangKiemAnToanThuThuat_CTTM.TheoDoiBangEp));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", bangKiemAnToanThuThuat_CTTM.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianThucHien", bangKiemAnToanThuThuat_CTTM.ThoiGianThucHien));
                Command.Parameters.Add(new MDB.MDBParameter("id", bangKiemAnToanThuThuat_CTTM.Id));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongTienSuoiAmChiTiet", bangKiemAnToanThuThuat_CTTM.PhuongTienSuoiAmChiTiet));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSy1", bangKiemAnToanThuThuat_CTTM.MaBacSy1));
                Command.Parameters.Add(new MDB.MDBParameter("BacSy1", bangKiemAnToanThuThuat_CTTM.BacSy1));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSy2", bangKiemAnToanThuThuat_CTTM.MaBacSy2));
                Command.Parameters.Add(new MDB.MDBParameter("BacSy2", bangKiemAnToanThuThuat_CTTM.BacSy2));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSy3", bangKiemAnToanThuThuat_CTTM.MaBacSy3));
                Command.Parameters.Add(new MDB.MDBParameter("BacSy3", bangKiemAnToanThuThuat_CTTM.BacSy3));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuong1", bangKiemAnToanThuThuat_CTTM.MaDieuDuong1));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuong1", bangKiemAnToanThuThuat_CTTM.DieuDuong1));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuong2", bangKiemAnToanThuThuat_CTTM.MaDieuDuong2));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuong2", bangKiemAnToanThuThuat_CTTM.DieuDuong2));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuong3", bangKiemAnToanThuThuat_CTTM.MaDieuDuong3));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuong3", bangKiemAnToanThuThuat_CTTM.DieuDuong3));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocVanManh_Check", bangKiemAnToanThuThuat_CTTM.ThuocVanManh_Check));
                Command.Parameters.Add(new MDB.MDBParameter("Khac_CheckBox", bangKiemAnToanThuThuat_CTTM.Khac_CheckBox));
                Command.Parameters.Add(new MDB.MDBParameter("Khac_TextBox", bangKiemAnToanThuThuat_CTTM.Khac_TextBox));
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

        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, string sID, string s_Table)
        {
            string sql = @"select a.* from " + s_Table + " a WHERE a.ID =: s_id";
            MDB.MDBCommand Command;
            MDB.MDBDataAdapter adt;
            using (Command = new MDB.MDBCommand(sql, MyConnection))
            {
                Command.Parameters.Add(new MDB.MDBParameter("s_id", sID));
                adt = new MDB.MDBDataAdapter(Command);
            }
            var ds = new DataSet();
            adt.Fill(ds, "BK");
            return ds;
        }
    }
}
