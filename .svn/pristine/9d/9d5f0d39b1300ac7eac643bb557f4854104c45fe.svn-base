using EMR.KyDienTu;
using Newtonsoft.Json;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class BangKiemAnToanPhauThuat : ThongTinKy
    {
        public BangKiemAnToanPhauThuat()
        {
            IDMauPhieu = (int)DanhMucPhieu.BKATPT;
            TenMauPhieu = DanhMucPhieu.BKATPT.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public decimal IDBangKiemAnToanPhauThuat { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Buồng")]
		public string Buong { get; set; }
        [MoTaDuLieu("Bệnh viện")]
		public string BenhVien { get; set; }
        [MoTaDuLieu("Thời gian tạo bảng kiểm")]
        public DateTime ThoiGianTaoBangKiem { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
        public string NhanTenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Hình thức chuyên phẫu thuật")]
		public decimal IDHinhThucChuyenPhauThuat { get; set; }
        [MoTaDuLieu("Loại phẫu thuật")]
		public decimal IDLoaiPhauThuat { get; set; }
        [MoTaDuLieu("Các thông tin trước khi gây mê")]
        public TruocKhiGayMe TruocKhiGayMe { get; set; }
        [MoTaDuLieu("Các thông tin trước khi rạch da")]
        public TruocKhiRachDa TruocKhiRachDa { get; set; }
        [MoTaDuLieu("Các thông tin trước khi rời phòng phẫu thuật")]
        public TruocKhiRoiPhongPhauThuat TruocKhiRoiPhongPhauThuat { get; set; }

        [MoTaDuLieu("Họ tên phẫu thuật viên")]
        public string PhauThuatVien { get; set; }
        [MoTaDuLieu("Họ tên bác sĩ gây mê")]
        public string BacSyGayMe { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng gây mê")]
		public string DieuDuongGayMe { get; set; }
        [MoTaDuLieu("Mã nhân viên phẫu thuật viên")]
        public string MaNVPhauThuatVien { get; set; }
        [MoTaDuLieu("Mã bác sĩ gây mê")]
        public string MaNVBacSyGayMe { get; set; }
        [MoTaDuLieu("Mã điều dưỡng gây mê")]
        public string MaNVDieuDuongGayMe { get; set; }

        public string DieuDuongDungCu { get; set; }
        public string MaDieuDuongDungCu { get; set; }
        public bool IsSelected { get; set; }
        [MoTaDuLieu("Tên phương thức chuyên phẫu thuật")]
        public string TenPhuongThucChuyenPhauThuat { get; set; }
        [MoTaDuLieu("Loại phẫu thuật")]
        public string TenLoaiPhauThuat { get; set; }
        //public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
    }
    public class TruocKhiGayMe
    {
        public bool XacDinhDanhTinhBenhNhan { get; set; }
        public bool DanhDauVungMo { get; set; }
        public bool BenhNhanTuanThuNhinAnNhinUong { get; set; }
        public bool KiemTraThuocThietBiGayMe { get; set; }
        public bool LapThietBiTheoDoi { get; set; }
        public bool TienSuDiUng { get; set; }
        public bool DuongThoKho { get; set; }
        public bool NguyCoMatMau { get; set; }
    }
    public class TruocKhiRachDa
    {
        public string ThanhVienKipPhauThuat { get; set; }
        public bool XacNhanLaiThanhVien { get; set; }
        public bool ThucHienKhangSinh { get; set; }
        public bool DuKienBatThuong { get; set; }
        public string ThoiGianPhauThuat { get; set; }
        public bool TienLuongMatMau { get; set; }
        public bool VanDeCanChuY { get; set; }
        public string VanDeCanChuY_Text { get; set; }
        public bool DungCuPhuongTienDamBao { get; set; }
        public bool ChatLuongThietBi { get; set; }
        public bool TrinhChieuChanDoanHinhAnh { get; set; }
        // tung
        public bool checkGT { get; set; }
        public bool checkXDNB { get; set; }
        public bool TienLuongL1 { get; set; }
        public bool TienLuongL2 { get; set; }
        public bool TienLuongL3 { get; set; }
        public bool TienLuongL4 { get; set; }
        public bool TienLuongL5 { get; set; }
        public bool TienLuongL6 { get; set; }
    }
    public class TruocKhiRoiPhongPhauThuat
    {
        public bool TenPhuongPhap { get; set; }
        public bool DemKimGacDungCu { get; set; }
        public bool DanNhanBenhPham { get; set; }
        public bool DamBaoHeThongDanLuu { get; set; }
        public string ChamSocSauMo { get; set; }
        //tung
        public bool VanDeHSCS { get; set; }

    }

    public class BangKiemAnToanPhauThuatFunc
    {
        // CONFIG
        public const int IDHinhThucChuyenPT_ChuongTrinh = 1;
        public const int IDHinhThucChuyenPT_CapCuu = 2;

        public const int IDLoaiPhauThuat_DacBiet = 1;
        public const int IDLoaiPhauThuat_LoaiI = 2;
        public const int IDLoaiPhauThuat_LoaiII = 3;
        public const int IDLoaiPhauThuat_LoaiIII = 4;

        public const string TableName = "bangkiemantoanphauthuat";
        public const string TablePrimaryKeyName = "idbangkiemantoanphauthuat";

        public List<BangKiemAnToanPhauThuat> SelectData(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            try
            {
                List<BangKiemAnToanPhauThuat> listResults = new List<BangKiemAnToanPhauThuat>();
                string sql = @"SELECT * FROM BangKiemAnToanPhauThuat WHERE MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    listResults.Add(new BangKiemAnToanPhauThuat()
                    {
                        IDBangKiemAnToanPhauThuat = Convert.ToDecimal(DataReader.GetDecimal("IDBangKiemAnToanPhauThuat").ToString()),
                        Khoa = DataReader["Khoa"].ToString(),
                        Buong = DataReader["Buong"].ToString(),
                        MaQuanLy = Convert.ToDecimal(DataReader.GetDecimal("MaQuanLy").ToString()),
                        MaBenhNhan = DataReader["MaBenhNhan"].ToString(),
                        TenBenhNhan = DataReader["TenBenhNhan"].ToString(),
                        NhanTenBenhNhan = DataReader["NhanTenBenhNhan"].ToString(),
                        GioiTinh = DataReader["GioiTinh"].ToString(),
                        Tuoi = DataReader["Tuoi"].ToString(),
                        ChanDoan = DataReader["ChanDoan"].ToString(),
                        ThoiGianTaoBangKiem = Convert.ToDateTime(DataReader["ThoiGianTaoBangKiem"].ToString()),

                        IDHinhThucChuyenPhauThuat = Convert.ToDecimal(DataReader.GetDecimal("IDHinhThucChuyenPhauThuat").ToString()),
                        IDLoaiPhauThuat = Convert.ToDecimal(DataReader.GetDecimal("IDLoaiPhauThuat").ToString()),

                        TruocKhiGayMe = JsonConvert.DeserializeObject<TruocKhiGayMe>(DataReader["TruocKhiGayMe"].ToString()),
                        TruocKhiRachDa = JsonConvert.DeserializeObject<TruocKhiRachDa>(DataReader["TruocKhiRachDa"].ToString()),
                        TruocKhiRoiPhongPhauThuat = JsonConvert.DeserializeObject<TruocKhiRoiPhongPhauThuat>(DataReader["TruocKhiRoiPhongPhauThuat"].ToString()),

                        PhauThuatVien = DataReader["PhauThuatVien"].ToString(),
                        BacSyGayMe = DataReader["BacSyGayMe"].ToString(),
                        DieuDuongGayMe = DataReader["DieuDuongGayMe"].ToString(),
                        MaNVPhauThuatVien = DataReader["MaNVPhauThuatVien"].ToString(),
                        MaNVBacSyGayMe = DataReader["MaNVBacSyGayMe"].ToString(),
                        MaNVDieuDuongGayMe = DataReader["MaNVDieuDuongGayMe"].ToString(),
                        DieuDuongDungCu = DataReader["DieuDuongDungCu"].ToString(),
                        MaDieuDuongDungCu = DataReader["MaDieuDuongDungCu"].ToString(),
                        IsSelected = false,
                        TenPhuongThucChuyenPhauThuat = Convert.ToDecimal(DataReader.GetDecimal("IDHinhThucChuyenPhauThuat").ToString()) == IDHinhThucChuyenPT_ChuongTrinh ? "Phẫu thuật chương trình" : "Phẫu thuật cấp cứu",
                        TenLoaiPhauThuat = Convert.ToDecimal(DataReader.GetDecimal("IDLoaiPhauThuat").ToString()) == IDLoaiPhauThuat_DacBiet ? "Phẫu thuật loại đặc biệt" :
                                           Convert.ToDecimal(DataReader.GetDecimal("IDLoaiPhauThuat").ToString()) == IDLoaiPhauThuat_LoaiI ? "Phẫu thuật loại I" :
                                           Convert.ToDecimal(DataReader.GetDecimal("IDLoaiPhauThuat").ToString()) == IDLoaiPhauThuat_LoaiII ? "Phẫu thuật loại 2" :
                                           Convert.ToDecimal(DataReader.GetDecimal("IDLoaiPhauThuat").ToString()) == IDLoaiPhauThuat_LoaiIII ? "Phẫu thuật loại 3" : "",
                        MaSoKy = DataReader["masokyten"].ToString(),
                        DaKy = string.IsNullOrEmpty(DataReader["masokyten"].ToString()) ? false : true
                    });
                }
                return listResults;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, decimal IDMaPhieu)
        {
            string sql = @"select AA.Khoa,
                                AA.Buong,
                                AA.MaBenhNhan,
                                AA.TenBenhNhan,
                                AA.NhanTenBenhNhan,
                                AA.GioiTinh,
                                AA.Tuoi,
                                AA.ChanDoan,
                                AA.ThoiGianTaoBangKiem,
                                AA.IDHinhThucChuyenPhauThuat,
                                AA.IDLoaiPhauThuat,
                                AA.PhauThuatVien,
                                AA.BacSyGayMe,
                                AA.DieuDuongGayMe,
                                AA.MaNVPhauThuatVien,
                                AA.MaNVBacSyGayMe,
                                AA.MaNVDieuDuongGayMe,
                                AA.DieuDuongDungCu,
                                AA.MaDieuDuongDungCu,
                                BB.BenhVien "
                         + " from BangKiemAnToanPhauThuat AA left join HanhChinhBenhNhan BB  ON AA.MABENHNHAN = BB.MABENHNHAN WHERE IDBangKiemAnToanPhauThuat =: IDBangKiemAnToanPhauThuat";
            MDB.MDBCommand Command;
            MDB.MDBDataAdapter adt;
            using (Command = new MDB.MDBCommand(sql, MyConnection))
            {
                Command.Parameters.Add(new MDB.MDBParameter("IDBangKiemAnToanPhauThuat", IDMaPhieu));
                adt = new MDB.MDBDataAdapter(Command);
            }
            var ds = new DataSet();
            adt.Fill(ds, "Table");
            ds.Tables[0].AddColumn("LoGoPath", typeof(string));
            ds.Tables[0].Rows[0]["LoGoPath"] = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\PaintLibrary\HinhAnh\LoGoVien\" + "Logo.png";

            sql = @"select AA.TruocKhiGayMe,
                            AA.TruocKhiRachDa,
                            AA.TruocKhiRoiPhongPhauThuat from BangKiemAnToanPhauThuat AA  WHERE IDBangKiemAnToanPhauThuat =: IDBangKiemAnToanPhauThuat";

            Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("IDBangKiemAnToanPhauThuat", IDMaPhieu));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            while (DataReader.Read())
            {
                TruocKhiGayMe TruocKhiGayMe = JsonConvert.DeserializeObject<TruocKhiGayMe>(DataReader["TruocKhiGayMe"].ToString());
                DataTable TGM = new DataTable("TGM");
                TGM.Columns.Add("XacDinhDanhTinhBenhNhan", typeof(int));
                TGM.Columns.Add("DanhDauVungMo", typeof(int));
                TGM.Columns.Add("BenhNhanTuanThuNhinAnNhinUong", typeof(int));
                TGM.Columns.Add("KiemTraThuocThietBiGayMe", typeof(int));
                TGM.Columns.Add("LapThietBiTheoDoi", typeof(int));
                TGM.Columns.Add("TienSuDiUng", typeof(int));
                TGM.Columns.Add("DuongThoKho", typeof(int));
                TGM.Columns.Add("NguyCoMatMau", typeof(int));
                TGM.Rows.Add(
                  TruocKhiGayMe.XacDinhDanhTinhBenhNhan ? 1:0,
                  TruocKhiGayMe.DanhDauVungMo ? 1 : 0,
                  TruocKhiGayMe.BenhNhanTuanThuNhinAnNhinUong ? 1 : 0,
                  TruocKhiGayMe.KiemTraThuocThietBiGayMe ? 1 : 0,
                  TruocKhiGayMe.LapThietBiTheoDoi ? 1 : 0,
                  TruocKhiGayMe.TienSuDiUng ? 1 : 0,
                  TruocKhiGayMe.DuongThoKho ? 1 : 0,
                  TruocKhiGayMe.NguyCoMatMau ? 1 : 0);
                ds.Tables.Add(TGM);

                TruocKhiRachDa TruocKhiRachDa = JsonConvert.DeserializeObject<TruocKhiRachDa>(DataReader["TruocKhiRachDa"].ToString());

                DataTable TRR = new DataTable("TRR");
                TRR.Columns.Add("ThanhVienKipPhauThuat", typeof(string));
                TRR.Columns.Add("XacNhanLaiThanhVien", typeof(int));
                TRR.Columns.Add("ThucHienKhangSinh", typeof(int));
                TRR.Columns.Add("DuKienBatThuong", typeof(int));
                TRR.Columns.Add("ThoiGianPhauThuat", typeof(string));
                TRR.Columns.Add("TienLuongMatMau", typeof(int));
                TRR.Columns.Add("VanDeCanChuY", typeof(int));
                TRR.Columns.Add("VanDeCanChuY_Text", typeof(string));
                TRR.Columns.Add("DungCuPhuongTienDamBao", typeof(int));
                TRR.Columns.Add("ChatLuongThietBi", typeof(int));
                TRR.Columns.Add("TrinhChieuChanDoanHinhAnh", typeof(int));
                TRR.Columns.Add("checkGT", typeof(int));
                TRR.Columns.Add("checkXDNB", typeof(int));
                TRR.Columns.Add("TienLuongL1", typeof(int));
                TRR.Columns.Add("TienLuongL2", typeof(int));
                TRR.Columns.Add("TienLuongL3", typeof(int));
                TRR.Columns.Add("TienLuongL4", typeof(int));
                TRR.Columns.Add("TienLuongL5", typeof(int));
                TRR.Columns.Add("TienLuongL6", typeof(int));
                TRR.Rows.Add(
                 TruocKhiRachDa.ThanhVienKipPhauThuat,
                 TruocKhiRachDa.XacNhanLaiThanhVien ? 1 : 0,
                 TruocKhiRachDa.ThucHienKhangSinh ? 1 : 0,
                 TruocKhiRachDa.DuKienBatThuong ? 1 : 0,
                 TruocKhiRachDa.ThoiGianPhauThuat,
                 TruocKhiRachDa.TienLuongMatMau ? 1 : 0,
                 TruocKhiRachDa.VanDeCanChuY ? 1 : 0,
                 TruocKhiRachDa.VanDeCanChuY_Text,
                 TruocKhiRachDa.DungCuPhuongTienDamBao ? 1 : 0,
                 TruocKhiRachDa.ChatLuongThietBi ? 1 : 0,
                 TruocKhiRachDa.TrinhChieuChanDoanHinhAnh ? 1 : 0,
                 TruocKhiRachDa.checkGT ? 1 : 0,
                 TruocKhiRachDa.checkXDNB ? 1 : 0,
                 TruocKhiRachDa.TienLuongL1 ? 1 : 0,
                 TruocKhiRachDa.TienLuongL2 ? 1 : 0,
                 TruocKhiRachDa.TienLuongL3 ? 1 : 0,
                 TruocKhiRachDa.TienLuongL4 ? 1 : 0,
                 TruocKhiRachDa.TienLuongL5 ? 1 : 0,
                 TruocKhiRachDa.TienLuongL6 ? 1 : 0
                 );
                ds.Tables.Add(TRR);

                TruocKhiRoiPhongPhauThuat TruocKhiRoiPhongPhauThuat = JsonConvert.DeserializeObject<TruocKhiRoiPhongPhauThuat>(DataReader["TruocKhiRoiPhongPhauThuat"].ToString());
                DataTable TKR = new DataTable("TKR");
                TKR.Columns.Add("TenPhuongPhap", typeof(int));
                TKR.Columns.Add("DemKimGacDungCu", typeof(int));
                TKR.Columns.Add("DanNhanBenhPham", typeof(int));
                TKR.Columns.Add("DamBaoHeThongDanLuu", typeof(int));
                TKR.Columns.Add("ChamSocSauMo", typeof(string));
                TKR.Columns.Add("VanDeHSCS", typeof(int));
                TKR.Rows.Add(
                  TruocKhiRoiPhongPhauThuat.TenPhuongPhap ? 1 : 0,
                  TruocKhiRoiPhongPhauThuat.DemKimGacDungCu ? 1 : 0,
                  TruocKhiRoiPhongPhauThuat.DanNhanBenhPham ? 1 : 0,
                  TruocKhiRoiPhongPhauThuat.DamBaoHeThongDanLuu ? 1 : 0,
                  TruocKhiRoiPhongPhauThuat.ChamSocSauMo,
                  TruocKhiRoiPhongPhauThuat.VanDeHSCS ? 1 : 0
                  );
                ds.Tables.Add(TKR);
            }
            return ds;
        }
        public bool Insert(MDB.MDBConnection MyConnection, DATABASE.Other.BangKiemAnToanPhauThuat BangKiem)
        {
            try
            {
                string sql = @"INSERT INTO BangKiemAnToanPhauThuat (MaQuanLy, MaBenhNhan, TenBenhNhan, Khoa,Buong, ThoiGianTaoBangKiem, NhanTenBenhNhan, Tuoi, GioiTinh, ChanDoan, IDHinhThucChuyenPhauThuat, IDLoaiPhauThuat, TruocKhiGayMe, TruocKhiRachDa, TruocKhiRoiPhongPhauThuat, PhauThuatVien, BacSyGayMe, DieuDuongGayMe, MaNVPhauThuatVien, MaNVBacSyGayMe, MaNVDieuDuongGayMe, DieuDuongDungCu, MaDieuDuongDungCu) 
                    VALUES (:MaQuanLy, :MaBenhNhan, :TenBenhNhan, :Khoa, :Buong, :ThoiGianTaoBangKiem, :NhanTenBenhNhan, :Tuoi, :GioiTinh, :ChanDoan, :IDHinhThucChuyenPhauThuat, :IDLoaiPhauThuat, :TruocKhiGayMe, :TruocKhiRachDa, :TruocKhiRoiPhongPhauThuat, :PhauThuatVien, :BacSyGayMe, :DieuDuongGayMe, :MaNVPhauThuatVien, :MaNVBacSyGayMe, :MaNVDieuDuongGayMe, :DieuDuongDungCu, :MaDieuDuongDungCu) ";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BangKiem.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", BangKiem.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("TenBenhNhan", BangKiem.TenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa", BangKiem.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("Buong", BangKiem.Buong));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianTaoBangKiem", BangKiem.ThoiGianTaoBangKiem));
                Command.Parameters.Add(new MDB.MDBParameter("NhanTenBenhNhan", BangKiem.NhanTenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("Tuoi", BangKiem.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("GioiTinh", BangKiem.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", BangKiem.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("IDHinhThucChuyenPhauThuat", BangKiem.IDHinhThucChuyenPhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("IDLoaiPhauThuat", BangKiem.IDLoaiPhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("TruocKhiGayMe", JsonConvert.SerializeObject(BangKiem.TruocKhiGayMe)));
                Command.Parameters.Add(new MDB.MDBParameter("TruocKhiRachDa", JsonConvert.SerializeObject(BangKiem.TruocKhiRachDa)));
                Command.Parameters.Add(new MDB.MDBParameter("TruocKhiRoiPhongPhauThuat", JsonConvert.SerializeObject(BangKiem.TruocKhiRoiPhongPhauThuat)));
                Command.Parameters.Add(new MDB.MDBParameter("PhauThuatVien", BangKiem.PhauThuatVien));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyGayMe", BangKiem.BacSyGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuongGayMe", BangKiem.DieuDuongGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("MaNVPhauThuatVien", BangKiem.MaNVPhauThuatVien));
                Command.Parameters.Add(new MDB.MDBParameter("MaNVBacSyGayMe", BangKiem.MaNVBacSyGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("MaNVDieuDuongGayMe", BangKiem.MaNVDieuDuongGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuongDungCu", BangKiem.DieuDuongDungCu));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuongDungCu", BangKiem.MaDieuDuongDungCu));
                int n = Command.ExecuteNonQuery();
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Update(MDB.MDBConnection MyConnection, DATABASE.Other.BangKiemAnToanPhauThuat BangKiem)
        {
            try
            {
                string sql = @"UPDATE BangKiemAnToanPhauThuat SET 
                        MaQuanLy = :MaQuanLy, 
                        MaBenhNhan = :MaBenhNhan, 
                        TenBenhNhan = :TenBenhNhan,
                        Khoa = :Khoa, 
                        Buong = :Buong, 
                        ThoiGianTaoBangKiem = :ThoiGianTaoBangKiem, 
                        NhanTenBenhNhan = :NhanTenBenhNhan, 
                        Tuoi = :Tuoi, 
                        GioiTinh = :GioiTinh, 
                        ChanDoan = :ChanDoan, 
                        IDHinhThucChuyenPhauThuat = :IDHinhThucChuyenPhauThuat, 
                        IDLoaiPhauThuat = :IDLoaiPhauThuat, 
                        TruocKhiGayMe = :TruocKhiGayMe, 
                        TruocKhiRachDa = :TruocKhiRachDa, 
                        TruocKhiRoiPhongPhauThuat = :TruocKhiRoiPhongPhauThuat, 
                        PhauThuatVien = :PhauThuatVien, 
                        BacSyGayMe = :BacSyGayMe, 
                        DieuDuongGayMe = :DieuDuongGayMe,
                        MaNVPhauThuatVien = :MaNVPhauThuatVien, 
                        MaNVBacSyGayMe = :MaNVBacSyGayMe, 
                        MaNVDieuDuongGayMe = :MaNVDieuDuongGayMe,
                        DieuDuongDungCu = :DieuDuongDungCu,
                        MaDieuDuongDungCu = :MaDieuDuongDungCu 
                        WHERE IDBangKiemAnToanPhauThuat = " + BangKiem.IDBangKiemAnToanPhauThuat;
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", BangKiem.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", BangKiem.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("TenBenhNhan", BangKiem.TenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa", BangKiem.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("Buong", BangKiem.Buong));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianTaoBangKiem", BangKiem.ThoiGianTaoBangKiem));
                Command.Parameters.Add(new MDB.MDBParameter("NhanTenBenhNhan", BangKiem.NhanTenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("Tuoi", BangKiem.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("GioiTinh", BangKiem.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", BangKiem.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("IDHinhThucChuyenPhauThuat", BangKiem.IDHinhThucChuyenPhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("IDLoaiPhauThuat", BangKiem.IDLoaiPhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("TruocKhiGayMe", JsonConvert.SerializeObject(BangKiem.TruocKhiGayMe)));
                Command.Parameters.Add(new MDB.MDBParameter("TruocKhiRachDa", JsonConvert.SerializeObject(BangKiem.TruocKhiRachDa)));
                Command.Parameters.Add(new MDB.MDBParameter("TruocKhiRoiPhongPhauThuat", JsonConvert.SerializeObject(BangKiem.TruocKhiRoiPhongPhauThuat)));
                Command.Parameters.Add(new MDB.MDBParameter("PhauThuatVien", BangKiem.PhauThuatVien));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyGayMe", BangKiem.BacSyGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuongGayMe", BangKiem.DieuDuongGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("MaNVPhauThuatVien", BangKiem.MaNVPhauThuatVien));
                Command.Parameters.Add(new MDB.MDBParameter("MaNVBacSyGayMe", BangKiem.MaNVBacSyGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("MaNVDieuDuongGayMe", BangKiem.MaNVDieuDuongGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuongDungCu", BangKiem.DieuDuongDungCu));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuongDungCu", BangKiem.MaDieuDuongDungCu));
                int n = Command.ExecuteNonQuery();
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Delete(MDB.MDBConnection MyConnection, DATABASE.Other.BangKiemAnToanPhauThuat BangKiem)
        {
            try
            {
                string sql = @"DELETE BangKiemAnToanPhauThuat
                        WHERE IDBangKiemAnToanPhauThuat = " + BangKiem.IDBangKiemAnToanPhauThuat;
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                int n = Command.ExecuteNonQuery();
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Print(MDB.MDBConnection MyConnection, decimal MaQuanLy, bool XemTruoc)
        {
            try
            {
                var listPrint = SelectData(MyConnection, MaQuanLy)?? new List<BangKiemAnToanPhauThuat>();
                foreach (var print in listPrint)
                {
                    var report = new InBenhAn.rptBangKiemAnToanPhauThuat(print);
                    Report.Print(new DataSet(), report, XemTruoc);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
