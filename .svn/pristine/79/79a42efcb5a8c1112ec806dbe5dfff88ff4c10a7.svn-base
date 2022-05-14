
using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuDanhGiaDinhDuongNguoiBenhNhapVien : ThongTinKy
    {
        public PhieuDanhGiaDinhDuongNguoiBenhNhapVien()
        {
            TableName = "PhieuDanhGiaDDNBNV";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PDGDDNBNV;
            TenMauPhieu = DanhMucPhieu.PDGDDNBNV.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Năm sinh")]
		public string NamSinh { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        public double? CanNang { get; set; }
        public double? ChieuCao { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        public DateTime? NgaySua { get; set; }
        public double? BMI { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public bool SutCan_Co { get; set; }
        public bool SutCan_Khong { get; set; }
        public double? SutCan_Kg { get; set; }
        public double? SutCan_Thang { get; set; }
        public double? SutCan_PhanTram { get; set; }
        public bool AnUong_BinhThuong { get; set; }
        public bool AnUong_GiamSut { get; set; }
        public bool AnUong_GiamSut_Tren50 { get; set; }
        public bool AnUong_GiamSut_Duoi50 { get; set; }
        public bool TeoMo { get; set; }
        public bool TeoCo { get; set; }
        public bool PhuChi { get; set; }
        public bool BangBung { get; set; }
        public bool SGA_Loai1 { get; set; }
        public bool SGA_Loai2 { get; set; }
        public bool SGA_Loai3 { get; set; }
        public bool NhuCau_Loai1 { get; set; }
        public bool NhuCau_Loai2 { get; set; }
        public bool NhuCau_Loai3 { get; set; }
        public bool NhuCau_Loai4 { get; set; }
        public bool NhuCau_Loai5 { get; set; }
        public bool NhuCau_Loai6 { get; set; }
        public bool NhuCau_Loai7 { get; set; }
        public double? NhuCau_Calo { get; set; }
        public double? NhuCau_Dam { get; set; }
        public double? NhuCau_Duong { get; set; }
        public double? NhuCau_Beo { get; set; }
        public bool KeHoach_Loai1 { get; set; }
        public string MaCheDoAn { get; set; }
        public bool KeHoach_Loai2 { get; set; }
        public bool KeHoach_Loai3 { get; set; }
        public bool KeHoach_Loai4 { get; set; }
        public int GiamCan { get; set; }
        public int GiamCanCT { get; set; }
        public int AnUong { get; set; }
        public int PhanLoai { get; set; }
        [MoTaDuLieu("Người thực hiện")]
		public string NguoiThucHien { get; set; }
        public string MaNVNguoiThucHien { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        // thêm trường theo issue [STT:1404] Sửa mẫu Phiếu đánh giá tình trạng dinh dưỡng
        public int LymphoBao { get; set; }
        public int Albumin { get; set; }

    }
    public class PhieuDanhGiaDinhDuongNguoiBenhNhapVienFunc
    {
        public static bool InsertOrUpdate(PhieuDanhGiaDinhDuongNguoiBenhNhapVien _PhieuDanhGiaDinhDuongNguoiBenhNhapVien, MDB.MDBConnection conn)
        {
            try
            {
                string sql = "";
                if (_PhieuDanhGiaDinhDuongNguoiBenhNhapVien.ID > 0)
                    sql = "UPDATE PhieuDanhGiaDDNBNV SET MAQUANLY = :MAQUANLY, NGUOISUA = :NGUOISUA, NGAYSUA = :NGAYSUA, CANNANG = :CANNANG, CHIEUCAO = :CHIEUCAO, BMI = :BMI, CHANDOAN = :CHANDOAN, SUTCAN_CO = :SUTCAN_CO, SUTCAN_KHONG = :SUTCAN_KHONG, SUTCAN_KG = :SUTCAN_KG, SUTCAN_THANG = :SUTCAN_THANG, SUTCAN_PHANTRAM = :SUTCAN_PHANTRAM, ANUONG_BINHTHUONG = :ANUONG_BINHTHUONG, ANUONG_GIAMSUT = :ANUONG_GIAMSUT, ANUONG_GIAMSUT_TREN50 = :ANUONG_GIAMSUT_TREN50, ANUONG_GIAMSUT_DUOI50 = :ANUONG_GIAMSUT_DUOI50, TEOMO = :TEOMO, TEOCO = :TEOCO, PHUCHI = :PHUCHI, BANGBUNG = :BANGBUNG, SGA_LOAI1 = :SGA_LOAI1, SGA_LOAI2 = :SGA_LOAI2, SGA_LOAI3 = :SGA_LOAI3, NHUCAU_LOAI1 = :NHUCAU_LOAI1, NHUCAU_LOAI2 = :NHUCAU_LOAI2, NHUCAU_LOAI3 = :NHUCAU_LOAI3, NHUCAU_LOAI4 = :NHUCAU_LOAI4, NHUCAU_LOAI5 = :NHUCAU_LOAI5, NHUCAU_LOAI6 = :NHUCAU_LOAI6, NHUCAU_LOAI7 = :NHUCAU_LOAI7, NHUCAU_CALO = :NHUCAU_CALO, NHUCAU_DAM = :NHUCAU_DAM, NHUCAU_DUONG = :NHUCAU_DUONG, NHUCAU_BEO = :NHUCAU_BEO, KEHOACH_LOAI1 = :KEHOACH_LOAI1, MACHEDOAN = :MACHEDOAN, KEHOACH_LOAI2 = :KEHOACH_LOAI2, KEHOACH_LOAI3 = :KEHOACH_LOAI3, KEHOACH_LOAI4 = :KEHOACH_LOAI4 , GiamCan =:GiamCan, GiamCanCT =:GiamCanCT, AnUong =:AnUong, PhanLoai =:PhanLoai, MaNVNguoiThucHien = :MaNVNguoiThucHien, NguoiThucHien = :NguoiThucHien, LymphoBao = :LymphoBao, Albumin = :Albumin WHERE ID = " + _PhieuDanhGiaDinhDuongNguoiBenhNhapVien.ID;
                else
                    sql = "INSERT INTO PhieuDanhGiaDDNBNV (MAQUANLY, NGUOITAO, NGUOISUA, NGAYTAO, NGAYSUA, CANNANG, CHIEUCAO, BMI, CHANDOAN, SUTCAN_CO, SUTCAN_KHONG, SUTCAN_KG, SUTCAN_THANG, SUTCAN_PHANTRAM, ANUONG_BINHTHUONG, ANUONG_GIAMSUT, ANUONG_GIAMSUT_TREN50, ANUONG_GIAMSUT_DUOI50, TEOMO, TEOCO, PHUCHI, BANGBUNG, SGA_LOAI1, SGA_LOAI2, SGA_LOAI3, NHUCAU_LOAI1, NHUCAU_LOAI2, NHUCAU_LOAI3, NHUCAU_LOAI4, NHUCAU_LOAI5, NHUCAU_LOAI6, NHUCAU_LOAI7, NHUCAU_CALO, NHUCAU_DAM, NHUCAU_DUONG, NHUCAU_BEO, KEHOACH_LOAI1, MACHEDOAN, KEHOACH_LOAI2, KEHOACH_LOAI3, KEHOACH_LOAI4, GiamCan, GiamCanCT, AnUong , PhanLoai, MaNVNguoiThucHien, NguoiThucHien, LymphoBao, Albumin) VALUES (:MAQUANLY, :NGUOITAO, :NGUOISUA, :NGAYTAO, :NGAYSUA, :CANNANG, :CHIEUCAO, :BMI, :CHANDOAN, :SUTCAN_CO, :SUTCAN_KHONG, :SUTCAN_KG, :SUTCAN_THANG, :SUTCAN_PHANTRAM, :ANUONG_BINHTHUONG, :ANUONG_GIAMSUT, :ANUONG_GIAMSUT_TREN50, :ANUONG_GIAMSUT_DUOI50, :TEOMO, :TEOCO, :PHUCHI, :BANGBUNG, :SGA_LOAI1, :SGA_LOAI2, :SGA_LOAI3, :NHUCAU_LOAI1, :NHUCAU_LOAI2, :NHUCAU_LOAI3, :NHUCAU_LOAI4, :NHUCAU_LOAI5, :NHUCAU_LOAI6, :NHUCAU_LOAI7, :NHUCAU_CALO, :NHUCAU_DAM, :NHUCAU_DUONG, :NHUCAU_BEO, :KEHOACH_LOAI1, :MACHEDOAN, :KEHOACH_LOAI2, :KEHOACH_LOAI3, :KEHOACH_LOAI4 , :GiamCan, :GiamCanCT, :AnUong , :PhanLoai, :MaNVNguoiThucHien, :NguoiThucHien, :LymphoBao, :Albumin) RETURNING ID INTO :ID";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, conn);
                command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", _PhieuDanhGiaDinhDuongNguoiBenhNhapVien.MaQuanLy));
                command.Parameters.Add(new MDB.MDBParameter("CANNANG", _PhieuDanhGiaDinhDuongNguoiBenhNhapVien.CanNang));
                command.Parameters.Add(new MDB.MDBParameter("CHIEUCAO", _PhieuDanhGiaDinhDuongNguoiBenhNhapVien.ChieuCao));
                command.Parameters.Add(new MDB.MDBParameter("BMI", _PhieuDanhGiaDinhDuongNguoiBenhNhapVien.BMI));
                command.Parameters.Add(new MDB.MDBParameter("CHANDOAN", _PhieuDanhGiaDinhDuongNguoiBenhNhapVien.ChanDoan));
                command.Parameters.Add(new MDB.MDBParameter("SUTCAN_CO", _PhieuDanhGiaDinhDuongNguoiBenhNhapVien.SutCan_Co == true ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("SUTCAN_KHONG", _PhieuDanhGiaDinhDuongNguoiBenhNhapVien.SutCan_Khong == true ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("SUTCAN_KG", _PhieuDanhGiaDinhDuongNguoiBenhNhapVien.SutCan_Kg));
                command.Parameters.Add(new MDB.MDBParameter("SUTCAN_THANG", _PhieuDanhGiaDinhDuongNguoiBenhNhapVien.SutCan_Thang));
                command.Parameters.Add(new MDB.MDBParameter("SUTCAN_PHANTRAM", _PhieuDanhGiaDinhDuongNguoiBenhNhapVien.SutCan_PhanTram));
                command.Parameters.Add(new MDB.MDBParameter("ANUONG_BINHTHUONG", _PhieuDanhGiaDinhDuongNguoiBenhNhapVien.AnUong_BinhThuong == true ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("ANUONG_GIAMSUT", _PhieuDanhGiaDinhDuongNguoiBenhNhapVien.AnUong_GiamSut == true ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("ANUONG_GIAMSUT_TREN50", _PhieuDanhGiaDinhDuongNguoiBenhNhapVien.AnUong_GiamSut_Tren50 == true ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("ANUONG_GIAMSUT_DUOI50", _PhieuDanhGiaDinhDuongNguoiBenhNhapVien.AnUong_GiamSut_Duoi50 == true ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("TEOMO", _PhieuDanhGiaDinhDuongNguoiBenhNhapVien.TeoMo == true ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("TEOCO", _PhieuDanhGiaDinhDuongNguoiBenhNhapVien.TeoCo == true ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("PHUCHI", _PhieuDanhGiaDinhDuongNguoiBenhNhapVien.PhuChi == true ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("BANGBUNG", _PhieuDanhGiaDinhDuongNguoiBenhNhapVien.BangBung == true ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("SGA_LOAI1", _PhieuDanhGiaDinhDuongNguoiBenhNhapVien.SGA_Loai1 == true ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("SGA_LOAI2", _PhieuDanhGiaDinhDuongNguoiBenhNhapVien.SGA_Loai2 == true ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("SGA_LOAI3", _PhieuDanhGiaDinhDuongNguoiBenhNhapVien.SGA_Loai3 == true ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("NHUCAU_LOAI1", _PhieuDanhGiaDinhDuongNguoiBenhNhapVien.NhuCau_Loai1 == true ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("NHUCAU_LOAI2", _PhieuDanhGiaDinhDuongNguoiBenhNhapVien.NhuCau_Loai2 == true ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("NHUCAU_LOAI3", _PhieuDanhGiaDinhDuongNguoiBenhNhapVien.NhuCau_Loai3 == true ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("NHUCAU_LOAI4", _PhieuDanhGiaDinhDuongNguoiBenhNhapVien.NhuCau_Loai4 == true ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("NHUCAU_LOAI5", _PhieuDanhGiaDinhDuongNguoiBenhNhapVien.NhuCau_Loai5 == true ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("NHUCAU_LOAI6", _PhieuDanhGiaDinhDuongNguoiBenhNhapVien.NhuCau_Loai6 == true ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("NHUCAU_LOAI7", _PhieuDanhGiaDinhDuongNguoiBenhNhapVien.NhuCau_Loai7 == true ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("NHUCAU_CALO", _PhieuDanhGiaDinhDuongNguoiBenhNhapVien.NhuCau_Calo));
                command.Parameters.Add(new MDB.MDBParameter("NHUCAU_DAM", _PhieuDanhGiaDinhDuongNguoiBenhNhapVien.NhuCau_Dam));
                command.Parameters.Add(new MDB.MDBParameter("NHUCAU_DUONG", _PhieuDanhGiaDinhDuongNguoiBenhNhapVien.NhuCau_Duong));
                command.Parameters.Add(new MDB.MDBParameter("NHUCAU_BEO", _PhieuDanhGiaDinhDuongNguoiBenhNhapVien.NhuCau_Beo));
                command.Parameters.Add(new MDB.MDBParameter("KEHOACH_LOAI1", _PhieuDanhGiaDinhDuongNguoiBenhNhapVien.KeHoach_Loai1 == true ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("MACHEDOAN", _PhieuDanhGiaDinhDuongNguoiBenhNhapVien.MaCheDoAn));
                command.Parameters.Add(new MDB.MDBParameter("KEHOACH_LOAI2", _PhieuDanhGiaDinhDuongNguoiBenhNhapVien.KeHoach_Loai2 == true ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("KEHOACH_LOAI3", _PhieuDanhGiaDinhDuongNguoiBenhNhapVien.KeHoach_Loai3 == true ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("KEHOACH_LOAI4", _PhieuDanhGiaDinhDuongNguoiBenhNhapVien.KeHoach_Loai4 == true ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("GiamCan", _PhieuDanhGiaDinhDuongNguoiBenhNhapVien.GiamCan));
                command.Parameters.Add(new MDB.MDBParameter("GiamCanCT", _PhieuDanhGiaDinhDuongNguoiBenhNhapVien.GiamCanCT));
                command.Parameters.Add(new MDB.MDBParameter("AnUong", _PhieuDanhGiaDinhDuongNguoiBenhNhapVien.AnUong ));
                command.Parameters.Add(new MDB.MDBParameter("PhanLoai", _PhieuDanhGiaDinhDuongNguoiBenhNhapVien.PhanLoai));
                command.Parameters.Add(new MDB.MDBParameter("MaNVNguoiThucHien", _PhieuDanhGiaDinhDuongNguoiBenhNhapVien.MaNVNguoiThucHien));
                command.Parameters.Add(new MDB.MDBParameter("NguoiThucHien", _PhieuDanhGiaDinhDuongNguoiBenhNhapVien.NguoiThucHien));
                command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", _PhieuDanhGiaDinhDuongNguoiBenhNhapVien.NguoiSua));
                command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", _PhieuDanhGiaDinhDuongNguoiBenhNhapVien.NgaySua));
                command.Parameters.Add(new MDB.MDBParameter("LymphoBao", _PhieuDanhGiaDinhDuongNguoiBenhNhapVien.LymphoBao));
                command.Parameters.Add(new MDB.MDBParameter("Albumin", _PhieuDanhGiaDinhDuongNguoiBenhNhapVien.Albumin));
                if (_PhieuDanhGiaDinhDuongNguoiBenhNhapVien.ID == 0)
                {
                    command.Parameters.Add(new MDB.MDBParameter("ID", _PhieuDanhGiaDinhDuongNguoiBenhNhapVien.ID));
                    command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", _PhieuDanhGiaDinhDuongNguoiBenhNhapVien.NguoiTao));
                    command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", _PhieuDanhGiaDinhDuongNguoiBenhNhapVien.NgayTao));
                }
                command.BindByName = true;
                int n = command.ExecuteNonQuery();
                if (_PhieuDanhGiaDinhDuongNguoiBenhNhapVien.ID == 0)
                {
                    long nextval = Convert.ToInt64((command.Parameters["ID"] as MDB.MDBParameter).Value);
                    _PhieuDanhGiaDinhDuongNguoiBenhNhapVien.ID = nextval;
                }
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
      
        public static List<PhieuDanhGiaDinhDuongNguoiBenhNhapVien> GetData(decimal MaQuanLy, MDB.MDBConnection conn)
        {
            List<PhieuDanhGiaDinhDuongNguoiBenhNhapVien> lstObject = new List<PhieuDanhGiaDinhDuongNguoiBenhNhapVien>();
            try
            {
                string sql = "SELECT * FROM PhieuDanhGiaDDNBNV WHERE MAQUANLY = :MAQUANLY ORDER BY ID DESC";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, conn);
                command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", MaQuanLy));
                MDB.MDBDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    EMR_MAIN.DATABASE.Other.PhieuDanhGiaDinhDuongNguoiBenhNhapVien obj = new PhieuDanhGiaDinhDuongNguoiBenhNhapVien();
                    obj.ID = Convert.ToInt64(dataReader.GetLong("ID"));
                    obj.MaQuanLy = Convert.ToDecimal(dataReader.GetDecimal("MaQuanLy"));
                    obj.NguoiTao = dataReader["NguoiTao"].ToString();
                    obj.NguoiSua = dataReader["NguoiSua"].ToString();
                    if (dataReader["NgayTao"] != null && dataReader["NgayTao"].ToString() != string.Empty)
                        obj.NgayTao = Convert.ToDateTime(dataReader.GetDate("NgayTao"));
                    if (dataReader["NgaySua"] != null && dataReader["NgaySua"].ToString() != string.Empty)
                        obj.NgaySua = Convert.ToDateTime(dataReader.GetDate("NgaySua"));

                    obj.TenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    obj.NamSinh = XemBenhAn._HanhChinhBenhNhan.NgaySinh?.Year.ToString();
                    double tempDoube = 0;
                    obj.CanNang = double.TryParse(dataReader["CanNang"].ToString(), out tempDoube) ? (double?)tempDoube : null;
                    obj.ChieuCao = double.TryParse(dataReader["ChieuCao"].ToString(), out tempDoube) ? (double?)tempDoube : null;


                    obj.BMI = double.TryParse(dataReader["BMI"].ToString(), out tempDoube) ? (double?)tempDoube : null;
                    obj.ChanDoan = dataReader["ChanDoan"].ToString();
                    obj.SutCan_Co = dataReader["SutCan_Co"].ToString().Equals("1") ? true : false;
                    obj.SutCan_Khong = dataReader["SutCan_Khong"].ToString().Equals("1") ? true : false;
                    obj.SutCan_Kg = double.TryParse(dataReader["SutCan_Kg"].ToString(), out tempDoube) ? (double?)tempDoube : null;
                    obj.SutCan_Thang = double.TryParse(dataReader["SutCan_Thang"].ToString(), out tempDoube) ? (double?)tempDoube : null;
                    obj.SutCan_PhanTram = double.TryParse(dataReader["SutCan_PhanTram"].ToString(), out tempDoube) ? (double?)tempDoube : null;
                    obj.AnUong_BinhThuong = dataReader["AnUong_BinhThuong"].ToString().Equals("1") ? true : false;
                    obj.AnUong_GiamSut = dataReader["AnUong_GiamSut"].ToString().Equals("1") ? true : false;
                    obj.AnUong_GiamSut_Tren50 = dataReader["AnUong_GiamSut_Tren50"].ToString().Equals("1") ? true : false;
                    obj.AnUong_GiamSut_Duoi50 = dataReader["AnUong_GiamSut_Duoi50"].ToString().Equals("1") ? true : false;
                    obj.TeoMo = dataReader["TeoMo"].ToString().Equals("1") ? true : false;
                    obj.TeoCo = dataReader["TeoCo"].ToString().Equals("1") ? true : false;
                    obj.PhuChi = dataReader["PhuChi"].ToString().Equals("1") ? true : false;
                    obj.BangBung = dataReader["BangBung"].ToString().Equals("1") ? true : false;
                    obj.SGA_Loai1 = dataReader["SGA_Loai1"].ToString().Equals("1") ? true : false;
                    obj.SGA_Loai2 = dataReader["SGA_Loai2"].ToString().Equals("1") ? true : false;
                    obj.SGA_Loai3 = dataReader["SGA_Loai3"].ToString().Equals("1") ? true : false;
                    obj.NhuCau_Loai1 = dataReader["NhuCau_Loai1"].ToString().Equals("1") ? true : false;
                    obj.NhuCau_Loai2 = dataReader["NhuCau_Loai2"].ToString().Equals("1") ? true : false;
                    obj.NhuCau_Loai3 = dataReader["NhuCau_Loai3"].ToString().Equals("1") ? true : false;
                    obj.NhuCau_Loai4 = dataReader["NhuCau_Loai4"].ToString().Equals("1") ? true : false;
                    obj.NhuCau_Loai5 = dataReader["NhuCau_Loai5"].ToString().Equals("1") ? true : false;
                    obj.NhuCau_Loai6 = dataReader["NhuCau_Loai6"].ToString().Equals("1") ? true : false;
                    obj.NhuCau_Loai7 = dataReader["NhuCau_Loai7"].ToString().Equals("1") ? true : false;
                    obj.NhuCau_Calo = double.TryParse(dataReader["NhuCau_Calo"].ToString(), out tempDoube) ? (double?)tempDoube : null;
                    obj.NhuCau_Dam = double.TryParse(dataReader["NhuCau_Dam"].ToString(), out tempDoube) ? (double?)tempDoube : null;
                    obj.NhuCau_Duong = double.TryParse(dataReader["NhuCau_Duong"].ToString(), out tempDoube) ? (double?)tempDoube : null;
                    obj.NhuCau_Beo = double.TryParse(dataReader["NhuCau_Beo"].ToString(), out tempDoube) ? (double?)tempDoube : null;
                    obj.KeHoach_Loai1 = dataReader["KeHoach_Loai1"].ToString().Equals("1") ? true : false;
                    obj.MaCheDoAn = dataReader["MaCheDoAn"].ToString();
                    obj.KeHoach_Loai2 = dataReader["KeHoach_Loai2"].ToString().Equals("1") ? true : false;
                    obj.KeHoach_Loai3 = dataReader["KeHoach_Loai3"].ToString().Equals("1") ? true : false;
                    obj.KeHoach_Loai4 = dataReader["KeHoach_Loai4"].ToString().Equals("1") ? true : false;
                    obj.GiamCan =Common.ConDB_Int( dataReader["GiamCan"]);
                    obj.GiamCanCT = Common.ConDB_Int(dataReader["GiamCanCT"]);
                    obj.AnUong = Common.ConDB_Int(dataReader["AnUong"]);
                    obj.PhanLoai = Common.ConDB_Int(dataReader["PhanLoai"]);
                    obj.MaNVNguoiThucHien = Common.ConDBNull(dataReader["MaNVNguoiThucHien"]);
                    obj.NguoiThucHien = Common.ConDBNull(dataReader["NguoiThucHien"]);
                    obj.MaSoKy = dataReader.GetString("masokyten");
                    obj.NgayKy = dataReader.GetDate("ngayky");
                    obj.TenFileKy = dataReader.GetString("tenfileky");
                    obj.UserNameKy = dataReader.GetString("usernameky");
                    obj.LymphoBao = dataReader.GetInt("LymphoBao");
                    obj.Albumin = dataReader.GetInt("Albumin");
                    obj.DaKy = !string.IsNullOrEmpty(obj.MaSoKy) ? true : false;

                    obj.Chon = false;
                    lstObject.Add(obj);
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return lstObject;
        }
     
        public static bool Delete(long ID, MDB.MDBConnection conn)
        {
            try
            {
                string sql = "DELETE FROM PhieuDanhGiaDDNBNV WHERE ID = :ID";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, conn);
                command.Parameters.Add(new MDB.MDBParameter("ID", ID));
                command.BindByName = true;
                int n = command.ExecuteNonQuery();
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static DataSet GetDataSet(long ID, MDB.MDBConnection conn)
        {
            try
            {
                string sql = "SELECT * FROM PhieuDanhGiaDDNBNV WHERE ID = :ID";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, conn);
                command.Parameters.Add(new MDB.MDBParameter("ID", ID));
                MDB.MDBDataAdapter dataAdapter = new MDB.MDBDataAdapter(command);
                DataSet ds = new DataSet();

                dataAdapter.Fill(ds, "Table");
                ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
                ds.Tables[0].AddColumn("NamSinh", typeof(string));

                ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                ds.Tables[0].Rows[0]["NamSinh"] = XemBenhAn._HanhChinhBenhNhan.NgaySinh.Value.ToString("dd-MM-yyyy");

                return ds;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return null;
        }
    }
}
