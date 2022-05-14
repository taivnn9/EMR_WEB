using EMR.KyDienTu;
using System;
using System.Collections.Generic;
using System.Data;
using PMS.Access; 

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuSangLocDanhGiaDinhDuong : ThongTinKy
    {
        public PhieuSangLocDanhGiaDinhDuong()
        {
            TableName = "PHIEUDANHGIADINHDUONG";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.SLDGDD;
            TenMauPhieu = DanhMucPhieu.SLDGDD.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        public string UserCreate { get; set; }
        public string UserUpdate { get; set; }
        public int TrangThai { get; set; } //1 Hoat động, 0 xóa
        public DateTime ThoiGianTao { get; set; }
        public DateTime? ThoiGianSua { get; set; }
        public string TenBenhVien { get; set; }
        [MoTaDuLieu("Tên khoa")]
		public string TenKhoa { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        public double CanNang { get; set; }
        public double ChieuCao { get; set; }
        public double BMI { get; set; }
        public bool XacDinhNguyCo_Khong { get; set; }
        public bool XacDinhNguyCo_Co { get; set; }
        public bool SutCan_Khong { get; set; }
        public bool SutCan_Co { get; set; }
        public double SutCan_Kg { get; set; }
        public double SutCan_Trong { get; set; }
        public double SutCan_PhanTram { get; set; }
        public bool AnUong_Tren50 { get; set; }
        public bool AnUong_BinhThuong { get; set; }
        public bool AnUong_Duoi50 { get; set; }
        public bool TeoMo_Khong { get; set; }
        public bool TeoMo_NheVua { get; set; }
        public bool TeoMo_Nang { get; set; }
        public bool TeoCo_NheVua { get; set; }
        public bool TeoCo_Nang { get; set; }
        public bool TeoCo_Khong { get; set; }
        public bool PhuNgoaiVu_Khong { get; set; }
        public bool PhuNgoaiVu_VuaNhe { get; set; }
        public bool PhuNgoaiVu_Nang { get; set; }
        public bool CoChuong_Khong { get; set; }
        public bool CoChuong_VuaNhe { get; set; }
        public bool CoChuong_Nang { get; set; }
        public bool SGA_Loai1 { get; set; }
        public bool SGA_Loai2 { get; set; }
        public bool SGA_Loai3 { get; set; }
        public bool NhuCauDinhDuong_Loai1 { get; set; }
        public bool NhuCauDinhDuong_Loai2 { get; set; }
        public bool NhuCauDinhDuong_Loai3 { get; set; }
        public bool NhuCauDinhDuong_Loai4 { get; set; }
        public bool NhuCauDinhDuong_Loai5 { get; set; }
        public bool NhuCauDinhDuong_Loai6 { get; set; }
        public bool NhuCauDinhDuong_Loai7 { get; set; }
        public double NhuCauDinhDuongKhac_Calo { get; set; }
        public double NhuCauDinhDuongKhac_Dam { get; set; }
        public double NhuCauDinhDuongKhac_Beo { get; set; }
        public bool KeHoachDinhDuong_DuongMieng { get; set; }
        public bool KeHoachDinhDuong_QuaOngThong { get; set; }
        public bool KeHoachDinhDuong_QuaTinhMach { get; set; }
        public string MaBacSiDieuTri { get; set; }
        [MoTaDuLieu("Bác sỹ điều trị")]
		public string BacSiDieuTri { get; set; }

        //public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
    }
    public class PhieuSangLocDanhGiaDinhDuongFunc
    {
        public const string TableName = "PHIEUDANHGIADINHDUONG";
        public const string TablePrimaryKeyName = "ID";

        public static long InsertOrUpdate(PhieuSangLocDanhGiaDinhDuong PhieuSangLocDanhGiaDinhDuong, MDB.MDBConnection conn)
        {
            try
            {
                string sql = "SELECT ID FROM PHIEUDANHGIADINHDUONG WHERE ID = :ID";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, conn);
                Command.Parameters.Add(new MDB.MDBParameter("ID", PhieuSangLocDanhGiaDinhDuong.ID));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                int count = 0;
                while (DataReader.Read()) count++;
                if (count == 1)
                    sql = "UPDATE PHIEUDANHGIADINHDUONG SET MAQUANLY = :MAQUANLY, USERCREATE = :USERCREATE, USERUPDATE = :USERUPDATE, THOIGIANTAO = :THOIGIANTAO, THOIGIANSUA = :THOIGIANSUA, TENBENHVIEN = :TENBENHVIEN, TENKHOA = :TENKHOA, MABENHNHAN = :MABENHNHAN, TENBENHNHAN = :TENBENHNHAN, TUOI = :TUOI, CANNANG = :CANNANG, CHIEUCAO = :CHIEUCAO, BMI = :BMI, XACDINHNGUYCO_KHONG = :XACDINHNGUYCO_KHONG, XACDINHNGUYCO_CO = :XACDINHNGUYCO_CO, SUTCAN_KHONG = :SUTCAN_KHONG, SUTCAN_CO = :SUTCAN_CO, SUTCAN_KG = :SUTCAN_KG, SUTCAN_TRONG = :SUTCAN_TRONG, SUTCAN_PHANTRAM = :SUTCAN_PHANTRAM, ANUONG_TREN50 = :ANUONG_TREN50, ANUONG_BINHTHUONG = :ANUONG_BINHTHUONG, ANUONG_DUOI50 = :ANUONG_DUOI50, TEOMO_KHONG = :TEOMO_KHONG, TEOMO_NHEVUA = :TEOMO_NHEVUA, TEOMO_NANG = :TEOMO_NANG, TEOCO_NHEVUA = :TEOCO_NHEVUA, TEOCO_NANG = :TEOCO_NANG, TEOCO_KHONG = :TEOCO_KHONG, PHUNGOAIVU_KHONG = :PHUNGOAIVU_KHONG, PHUNGOAIVU_VUANHE = :PHUNGOAIVU_VUANHE, PHUNGOAIVU_NANG = :PHUNGOAIVU_NANG, COCHUONG_KHONG = :COCHUONG_KHONG, COCHUONG_VUANHE = :COCHUONG_VUANHE, COCHUONG_NANG = :COCHUONG_NANG, SGA_LOAI1 = :SGA_LOAI1, SGA_LOAI2 = :SGA_LOAI2, SGA_LOAI3 = :SGA_LOAI3, NHUCAUDINHDUONG_LOAI1 = :NHUCAUDINHDUONG_LOAI1, NHUCAUDINHDUONG_LOAI2 = :NHUCAUDINHDUONG_LOAI2, NHUCAUDINHDUONG_LOAI3 = :NHUCAUDINHDUONG_LOAI3, NHUCAUDINHDUONG_LOAI4 = :NHUCAUDINHDUONG_LOAI4, NHUCAUDINHDUONG_LOAI5 = :NHUCAUDINHDUONG_LOAI5, NHUCAUDINHDUONG_LOAI6 = :NHUCAUDINHDUONG_LOAI6, NHUCAUDINHDUONG_LOAI7 = :NHUCAUDINHDUONG_LOAI7, NHUCAUDINHDUONGKHAC_CALO = :NHUCAUDINHDUONGKHAC_CALO, NHUCAUDINHDUONGKHAC_DAM = :NHUCAUDINHDUONGKHAC_DAM, NHUCAUDINHDUONGKHAC_BEO = :NHUCAUDINHDUONGKHAC_BEO, KEHOACHDINHDUONG_DUONGMIENG = :KEHOACHDINHDUONG_DUONGMIENG, KEHOACHDINHDUONG_QUAONGTHONG = :KEHOACHDINHDUONG_QUAONGTHONG, KEHOACHDINHDUONG_QUATINHMACH = :KEHOACHDINHDUONG_QUATINHMACH, MABACSIDIEUTRI = :MABACSIDIEUTRI, BACSIDIEUTRI = :BACSIDIEUTRI, TRANGTHAI = :TRANGTHAI WHERE ID = :ID";
                else
                    sql = "INSERT INTO PHIEUDANHGIADINHDUONG (MAQUANLY, USERCREATE, USERUPDATE, THOIGIANTAO, THOIGIANSUA, TENBENHVIEN, TENKHOA, MABENHNHAN, TENBENHNHAN, TUOI, CANNANG, CHIEUCAO, BMI, XACDINHNGUYCO_KHONG, XACDINHNGUYCO_CO, SUTCAN_KHONG, SUTCAN_CO, SUTCAN_KG, SUTCAN_TRONG, SUTCAN_PHANTRAM, ANUONG_TREN50, ANUONG_BINHTHUONG, ANUONG_DUOI50, TEOMO_KHONG, TEOMO_NHEVUA, TEOMO_NANG, TEOCO_NHEVUA, TEOCO_NANG, TEOCO_KHONG, PHUNGOAIVU_KHONG, PHUNGOAIVU_VUANHE, PHUNGOAIVU_NANG, COCHUONG_KHONG, COCHUONG_VUANHE, COCHUONG_NANG, SGA_LOAI1, SGA_LOAI2, SGA_LOAI3, NHUCAUDINHDUONG_LOAI1, NHUCAUDINHDUONG_LOAI2, NHUCAUDINHDUONG_LOAI3, NHUCAUDINHDUONG_LOAI4, NHUCAUDINHDUONG_LOAI5, NHUCAUDINHDUONG_LOAI6, NHUCAUDINHDUONG_LOAI7, NHUCAUDINHDUONGKHAC_CALO, NHUCAUDINHDUONGKHAC_DAM, NHUCAUDINHDUONGKHAC_BEO, KEHOACHDINHDUONG_DUONGMIENG, KEHOACHDINHDUONG_QUAONGTHONG, KEHOACHDINHDUONG_QUATINHMACH, MABACSIDIEUTRI, BACSIDIEUTRI, TRANGTHAI) VALUES (:MAQUANLY, :USERCREATE, :USERUPDATE, :THOIGIANTAO, :THOIGIANSUA, :TENBENHVIEN, :TENKHOA, :MABENHNHAN, :TENBENHNHAN, :TUOI, :CANNANG, :CHIEUCAO, :BMI, :XACDINHNGUYCO_KHONG, :XACDINHNGUYCO_CO, :SUTCAN_KHONG, :SUTCAN_CO, :SUTCAN_KG, :SUTCAN_TRONG, :SUTCAN_PHANTRAM, :ANUONG_TREN50, :ANUONG_BINHTHUONG, :ANUONG_DUOI50, :TEOMO_KHONG, :TEOMO_NHEVUA, :TEOMO_NANG, :TEOCO_NHEVUA, :TEOCO_NANG, :TEOCO_KHONG, :PHUNGOAIVU_KHONG, :PHUNGOAIVU_VUANHE, :PHUNGOAIVU_NANG, :COCHUONG_KHONG, :COCHUONG_VUANHE, :COCHUONG_NANG, :SGA_LOAI1, :SGA_LOAI2, :SGA_LOAI3, :NHUCAUDINHDUONG_LOAI1, :NHUCAUDINHDUONG_LOAI2, :NHUCAUDINHDUONG_LOAI3, :NHUCAUDINHDUONG_LOAI4, :NHUCAUDINHDUONG_LOAI5, :NHUCAUDINHDUONG_LOAI6, :NHUCAUDINHDUONG_LOAI7, :NHUCAUDINHDUONGKHAC_CALO, :NHUCAUDINHDUONGKHAC_DAM, :NHUCAUDINHDUONGKHAC_BEO, :KEHOACHDINHDUONG_DUONGMIENG, :KEHOACHDINHDUONG_QUAONGTHONG, :KEHOACHDINHDUONG_QUATINHMACH, :MABACSIDIEUTRI, :BACSIDIEUTRI, :TRANGTHAI) RETURNING ID INTO :ID";
                Command = new MDB.MDBCommand(sql, conn);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", PhieuSangLocDanhGiaDinhDuong.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("USERCREATE", Common.getUserLogin()));
                if (count == 1)
                    Command.Parameters.Add(new MDB.MDBParameter("USERUPDATE", Common.getUserLogin()));
                else
                    Command.Parameters.Add(new MDB.MDBParameter("USERUPDATE", ""));
                Command.Parameters.Add(new MDB.MDBParameter("THOIGIANTAO", PhieuSangLocDanhGiaDinhDuong.ThoiGianTao));
                if (count == 1)
                    Command.Parameters.Add(new MDB.MDBParameter("THOIGIANSUA", DateTime.Now));
                else
                    Command.Parameters.Add(new MDB.MDBParameter("THOIGIANSUA", PhieuSangLocDanhGiaDinhDuong.ThoiGianSua));
                Command.Parameters.Add(new MDB.MDBParameter("TENBENHVIEN", PhieuSangLocDanhGiaDinhDuong.TenBenhVien));
                Command.Parameters.Add(new MDB.MDBParameter("TENKHOA", PhieuSangLocDanhGiaDinhDuong.TenKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("MABENHNHAN", PhieuSangLocDanhGiaDinhDuong.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("TENBENHNHAN", PhieuSangLocDanhGiaDinhDuong.TenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("TUOI", PhieuSangLocDanhGiaDinhDuong.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("CANNANG", PhieuSangLocDanhGiaDinhDuong.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("CHIEUCAO", PhieuSangLocDanhGiaDinhDuong.ChieuCao));
                Command.Parameters.Add(new MDB.MDBParameter("BMI", PhieuSangLocDanhGiaDinhDuong.BMI));
                Command.Parameters.Add(new MDB.MDBParameter("XACDINHNGUYCO_KHONG", PhieuSangLocDanhGiaDinhDuong.XacDinhNguyCo_Khong == true ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("XACDINHNGUYCO_CO", PhieuSangLocDanhGiaDinhDuong.XacDinhNguyCo_Co == true ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("SUTCAN_KHONG", PhieuSangLocDanhGiaDinhDuong.SutCan_Khong == true ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("SUTCAN_CO", PhieuSangLocDanhGiaDinhDuong.SutCan_Co == true ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("SUTCAN_KG", PhieuSangLocDanhGiaDinhDuong.SutCan_Kg));
                Command.Parameters.Add(new MDB.MDBParameter("SUTCAN_TRONG", PhieuSangLocDanhGiaDinhDuong.SutCan_Trong));
                Command.Parameters.Add(new MDB.MDBParameter("SUTCAN_PHANTRAM", PhieuSangLocDanhGiaDinhDuong.SutCan_PhanTram));
                Command.Parameters.Add(new MDB.MDBParameter("ANUONG_TREN50", PhieuSangLocDanhGiaDinhDuong.AnUong_Tren50 == true ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("ANUONG_BINHTHUONG", PhieuSangLocDanhGiaDinhDuong.AnUong_BinhThuong == true ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("ANUONG_DUOI50", PhieuSangLocDanhGiaDinhDuong.AnUong_Duoi50 == true ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("TEOMO_KHONG", PhieuSangLocDanhGiaDinhDuong.TeoMo_Khong == true ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("TEOMO_NHEVUA", PhieuSangLocDanhGiaDinhDuong.TeoMo_NheVua == true ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("TEOMO_NANG", PhieuSangLocDanhGiaDinhDuong.TeoMo_Nang == true ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("TEOCO_NHEVUA", PhieuSangLocDanhGiaDinhDuong.TeoCo_NheVua == true ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("TEOCO_NANG", PhieuSangLocDanhGiaDinhDuong.TeoCo_Nang == true ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("TEOCO_KHONG", PhieuSangLocDanhGiaDinhDuong.TeoCo_Khong == true ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("PHUNGOAIVU_KHONG", PhieuSangLocDanhGiaDinhDuong.PhuNgoaiVu_Khong == true ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("PHUNGOAIVU_VUANHE", PhieuSangLocDanhGiaDinhDuong.PhuNgoaiVu_VuaNhe == true ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("PHUNGOAIVU_NANG", PhieuSangLocDanhGiaDinhDuong.PhuNgoaiVu_Nang == true ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("COCHUONG_KHONG", PhieuSangLocDanhGiaDinhDuong.CoChuong_Khong == true ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("COCHUONG_VUANHE", PhieuSangLocDanhGiaDinhDuong.CoChuong_VuaNhe == true ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("COCHUONG_NANG", PhieuSangLocDanhGiaDinhDuong.CoChuong_Nang == true ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("SGA_LOAI1", PhieuSangLocDanhGiaDinhDuong.SGA_Loai1 == true ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("SGA_LOAI2", PhieuSangLocDanhGiaDinhDuong.SGA_Loai2 == true ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("SGA_LOAI3", PhieuSangLocDanhGiaDinhDuong.SGA_Loai3 == true ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("NHUCAUDINHDUONG_LOAI1", PhieuSangLocDanhGiaDinhDuong.NhuCauDinhDuong_Loai1 == true ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("NHUCAUDINHDUONG_LOAI2", PhieuSangLocDanhGiaDinhDuong.NhuCauDinhDuong_Loai2 == true ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("NHUCAUDINHDUONG_LOAI3", PhieuSangLocDanhGiaDinhDuong.NhuCauDinhDuong_Loai3 == true ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("NHUCAUDINHDUONG_LOAI4", PhieuSangLocDanhGiaDinhDuong.NhuCauDinhDuong_Loai4 == true ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("NHUCAUDINHDUONG_LOAI5", PhieuSangLocDanhGiaDinhDuong.NhuCauDinhDuong_Loai5 == true ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("NHUCAUDINHDUONG_LOAI6", PhieuSangLocDanhGiaDinhDuong.NhuCauDinhDuong_Loai6 == true ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("NHUCAUDINHDUONG_LOAI7", PhieuSangLocDanhGiaDinhDuong.NhuCauDinhDuong_Loai7 == true ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("NHUCAUDINHDUONGKHAC_CALO", PhieuSangLocDanhGiaDinhDuong.NhuCauDinhDuongKhac_Calo));
                Command.Parameters.Add(new MDB.MDBParameter("NHUCAUDINHDUONGKHAC_DAM", PhieuSangLocDanhGiaDinhDuong.NhuCauDinhDuongKhac_Dam));
                Command.Parameters.Add(new MDB.MDBParameter("NHUCAUDINHDUONGKHAC_BEO", PhieuSangLocDanhGiaDinhDuong.NhuCauDinhDuongKhac_Beo));
                Command.Parameters.Add(new MDB.MDBParameter("KEHOACHDINHDUONG_DUONGMIENG", PhieuSangLocDanhGiaDinhDuong.KeHoachDinhDuong_DuongMieng == true ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("KEHOACHDINHDUONG_QUAONGTHONG", PhieuSangLocDanhGiaDinhDuong.KeHoachDinhDuong_QuaOngThong == true ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("KEHOACHDINHDUONG_QUATINHMACH", PhieuSangLocDanhGiaDinhDuong.KeHoachDinhDuong_QuaTinhMach == true ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("MABACSIDIEUTRI", PhieuSangLocDanhGiaDinhDuong.MaBacSiDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("BACSIDIEUTRI", PhieuSangLocDanhGiaDinhDuong.BacSiDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TRANGTHAI", Convert.ToInt32(0)));
                Command.Parameters.Add(new MDB.MDBParameter("ID", PhieuSangLocDanhGiaDinhDuong.ID));
                int n = Command.ExecuteNonQuery();
                long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                return n > 0 ? nextval : 0;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return 0;
        }
        public static bool Delete(PhieuSangLocDanhGiaDinhDuong PhieuSangLocDanhGiaDinhDuong, MDB.MDBConnection conn)
        {
            try
            {
                string sql = "UPDATE PHIEUDANHGIADINHDUONG SET TRANGTHAI = 1, USERUPDATE = :USERUPDATE, THOIGIANSUA = :THOIGIANSUA WHERE ID = :ID";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, conn);
                Command.Parameters.Add(new MDB.MDBParameter("USERUPDATE", Common.getUserLogin()));
                Command.Parameters.Add(new MDB.MDBParameter("THOIGIANSUA", DateTime.Now));
                Command.Parameters.Add(new MDB.MDBParameter("ID", PhieuSangLocDanhGiaDinhDuong.ID));

                int n = Command.ExecuteNonQuery();
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static List<PhieuSangLocDanhGiaDinhDuong> GetData(decimal MaQuanLy, MDB.MDBConnection conn)
        {
            List<PhieuSangLocDanhGiaDinhDuong> lstResult = new List<PhieuSangLocDanhGiaDinhDuong>();
            try
            {
                string sql = "SELECT * FROM PHIEUDANHGIADINHDUONG WHERE MAQUANLY = :MAQUANLY AND TRANGTHAI = 0 ORDER BY THOIGIANTAO DESC";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, conn);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuSangLocDanhGiaDinhDuong Result = new PhieuSangLocDanhGiaDinhDuong();
                    Result.ID = Convert.ToInt64(DataReader.GetLong("ID"));
                    Result.MaQuanLy = Convert.ToDecimal(DataReader.GetDecimal("MAQUANLY"));
                    Result.UserCreate = DataReader["USERCREATE"].ToString();
                    Result.UserUpdate = DataReader["USERUPDATE"].ToString();
                    Result.ThoiGianTao = Convert.ToDateTime(DataReader.GetDate("THOIGIANTAO"));
                    if (DataReader["THOIGIANSUA"] != null && DataReader["THOIGIANSUA"].ToString() != string.Empty)
                        Result.ThoiGianSua = Convert.ToDateTime(DataReader.GetDate("THOIGIANSUA"));
                    Result.TenBenhVien = DataReader["TENBENHVIEN"].ToString();
                    Result.TenKhoa = DataReader["TENKHOA"].ToString();
                    Result.MaBenhNhan = DataReader["MABENHNHAN"].ToString();
                    Result.TenBenhNhan = DataReader["TENBENHNHAN"].ToString();
                    Result.Tuoi = DataReader["TUOI"].ToString();
                    Result.CanNang = Convert.ToDouble(DataReader.GetDecimal("CANNANG"));
                    Result.ChieuCao = Convert.ToDouble(DataReader.GetDecimal("CHIEUCAO"));
                    if (Result.ChieuCao > 0)
                        Result.BMI = Result.CanNang / (Result.ChieuCao * Result.ChieuCao);
                    Result.XacDinhNguyCo_Khong = DataReader["XACDINHNGUYCO_KHONG"].ToString().Equals("1") ? true : false;
                    Result.XacDinhNguyCo_Co = DataReader["XACDINHNGUYCO_CO"].ToString().Equals("1") ? true : false;
                    Result.SutCan_Khong = DataReader["SUTCAN_KHONG"].ToString().Equals("1") ? true : false;
                    Result.SutCan_Co = DataReader["SUTCAN_CO"].ToString().Equals("1") ? true : false;
                    Result.SutCan_Kg = Convert.ToDouble(DataReader.GetDecimal("SUTCAN_KG"));
                    Result.SutCan_Trong = Convert.ToDouble(DataReader.GetDecimal("SUTCAN_TRONG"));
                    Result.SutCan_PhanTram = Convert.ToDouble(DataReader.GetDecimal("SUTCAN_PHANTRAM"));
                    Result.AnUong_Tren50 = DataReader["ANUONG_TREN50"].ToString().Equals("1") ? true : false;
                    Result.AnUong_BinhThuong = DataReader["ANUONG_BINHTHUONG"].ToString().Equals("1") ? true : false;
                    Result.AnUong_Duoi50 = DataReader["ANUONG_DUOI50"].ToString().Equals("1") ? true : false;
                    Result.TeoMo_Khong = DataReader["TEOMO_KHONG"].ToString().Equals("1") ? true : false;
                    Result.TeoMo_NheVua = DataReader["TEOMO_NHEVUA"].ToString().Equals("1") ? true : false;
                    Result.TeoMo_Nang = DataReader["TEOMO_NANG"].ToString().Equals("1") ? true : false;
                    Result.TeoCo_NheVua = DataReader["TEOCO_NHEVUA"].ToString().Equals("1") ? true : false;
                    Result.TeoCo_Nang = DataReader["TEOCO_NANG"].ToString().Equals("1") ? true : false;
                    Result.TeoCo_Khong = DataReader["TEOCO_KHONG"].ToString().Equals("1") ? true : false;
                    Result.PhuNgoaiVu_Khong = DataReader["PHUNGOAIVU_KHONG"].ToString().Equals("1") ? true : false;
                    Result.PhuNgoaiVu_VuaNhe = DataReader["PHUNGOAIVU_VUANHE"].ToString().Equals("1") ? true : false;
                    Result.PhuNgoaiVu_Nang = DataReader["PHUNGOAIVU_NANG"].ToString().Equals("1") ? true : false;
                    Result.CoChuong_Khong = DataReader["COCHUONG_KHONG"].ToString().Equals("1") ? true : false;
                    Result.CoChuong_VuaNhe = DataReader["COCHUONG_VUANHE"].ToString().Equals("1") ? true : false;
                    Result.CoChuong_Nang = DataReader["COCHUONG_NANG"].ToString().Equals("1") ? true : false;
                    Result.SGA_Loai1 = DataReader["SGA_LOAI1"].ToString().Equals("1") ? true : false;
                    Result.SGA_Loai2 = DataReader["SGA_LOAI2"].ToString().Equals("1") ? true : false;
                    Result.SGA_Loai3 = DataReader["SGA_LOAI3"].ToString().Equals("1") ? true : false;
                    Result.NhuCauDinhDuong_Loai1 = DataReader["NHUCAUDINHDUONG_LOAI1"].ToString().Equals("1") ? true : false;
                    Result.NhuCauDinhDuong_Loai2 = DataReader["NHUCAUDINHDUONG_LOAI2"].ToString().Equals("1") ? true : false;
                    Result.NhuCauDinhDuong_Loai3 = DataReader["NHUCAUDINHDUONG_LOAI3"].ToString().Equals("1") ? true : false;
                    Result.NhuCauDinhDuong_Loai4 = DataReader["NHUCAUDINHDUONG_LOAI4"].ToString().Equals("1") ? true : false;
                    Result.NhuCauDinhDuong_Loai5 = DataReader["NHUCAUDINHDUONG_LOAI5"].ToString().Equals("1") ? true : false;
                    Result.NhuCauDinhDuong_Loai6 = DataReader["NHUCAUDINHDUONG_LOAI6"].ToString().Equals("1") ? true : false;
                    Result.NhuCauDinhDuong_Loai7 = DataReader["NHUCAUDINHDUONG_LOAI7"].ToString().Equals("1") ? true : false;
                    Result.NhuCauDinhDuongKhac_Calo = Convert.ToDouble(DataReader.GetDecimal("NHUCAUDINHDUONGKHAC_CALO"));
                    Result.NhuCauDinhDuongKhac_Dam = Convert.ToDouble(DataReader.GetDecimal("NHUCAUDINHDUONGKHAC_DAM"));
                    Result.NhuCauDinhDuongKhac_Beo = Convert.ToDouble(DataReader.GetDecimal("NHUCAUDINHDUONGKHAC_BEO"));
                    Result.KeHoachDinhDuong_DuongMieng = DataReader["KEHOACHDINHDUONG_DUONGMIENG"].ToString().Equals("1") ? true : false;
                    Result.KeHoachDinhDuong_QuaOngThong = DataReader["KEHOACHDINHDUONG_QUAONGTHONG"].ToString().Equals("1") ? true : false;
                    Result.KeHoachDinhDuong_QuaTinhMach = DataReader["KEHOACHDINHDUONG_QUATINHMACH"].ToString().Equals("1") ? true : false;
                    Result.MaBacSiDieuTri = DataReader["MABACSIDIEUTRI"].ToString();
                    Result.BacSiDieuTri = DataReader["BACSIDIEUTRI"].ToString();
                    Result.MaSoKy = DataReader["masokyten"].ToString();
                    Result.DaKy = !string.IsNullOrEmpty(Result.MaSoKy) ? true : false;
                    lstResult.Add(Result);
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return lstResult;
        }
        public static DataSet GetDataSet(PhieuSangLocDanhGiaDinhDuong PhieuSangLocDanhGiaDinhDuong, MDB.MDBConnection conn)
        {
            DataSet ds = new DataSet();
            try
            {
                string sql = "SELECT * FROM PHIEUDANHGIADINHDUONG WHERE ID = :ID";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, conn);
                Command.Parameters.Add(new MDB.MDBParameter("ID", PhieuSangLocDanhGiaDinhDuong.ID));
                MDB.MDBDataAdapter dataAdapter = new MDB.MDBDataAdapter(Command);
                dataAdapter.Fill(ds);
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return ds;
        }
    }
}
