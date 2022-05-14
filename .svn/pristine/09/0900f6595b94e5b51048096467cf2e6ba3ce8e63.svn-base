using EMR.KyDienTu;
using System;
using System.Collections.Generic;
using System.Data;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class BienBanHoiChanPhauThuat : ThongTinKy
    {
        public BienBanHoiChanPhauThuat()
        {
            TableName = "BienBanHoiChanPhauThuat";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BBHCPT;
            TenMauPhieu = DanhMucPhieu.BBHCPT.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Tiền sử bệnh")]
        public string TienSuBenh { get; set; }
        [MoTaDuLieu("Bệnh sử")]
        public string BenhSu { get; set; }
        [MoTaDuLieu("Khám hiện tại")]
        public string KhamHienTai { get; set; }
        [MoTaDuLieu("Kết quả các xét nghiệm, X-quang, thăm dò chức năng")]
        public string KetQuaXetNghiem { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh trước khi mổ")]
		public string ChanDoanTruocKhiMo { get; set; }
        [MoTaDuLieu("Dự kiến phương pháp mổ")]
        public string DuKienPhuongPhapMo { get; set; }
        [MoTaDuLieu("Ngày mổ")]
        public DateTime NgayMo { get; set; }
        [MoTaDuLieu("Họ tên phẫu thuật viên chính")]
        public string PhauThuatVienChinh { get; set; }
        [MoTaDuLieu("Mã phẩu thuật viên chính")]
        public string MaPhauThuaVienChinh { get; set; }
        [MoTaDuLieu("Phẫu thuật viên phụ")]
        public string PhauThuatVienPhu { get; set; }
        [MoTaDuLieu("Mã phẩu thuật viên phụ")]
        public string MaPhauThuatVienPhu { get; set; }
        [MoTaDuLieu("Bác sỹ gây mê")]
        public string BacSyGayMe { get; set; }
        [MoTaDuLieu("Mã bác sỹ gây mê")]
        public string MaBacSyGayMe { get; set; }
        [MoTaDuLieu("Phương pháp vô cảm")]
        public string PhuongPhapVoCam { get; set; }
        [MoTaDuLieu("Số lượng máu dự trữ")]
        public string SoLuongMauDuTru { get; set; }
        [MoTaDuLieu("Giám đốc")]
        public string GiamDoc { get; set; }
        [MoTaDuLieu("Mã giám đốc")]
        public string MaGiamDoc { get; set; }
        [MoTaDuLieu("Chủ nhiệm khoa")]
        public string ChuNhiemKhoa { get; set; }
        [MoTaDuLieu("Mã chủ nhiệm khoa")]
        public string MaChuNhiemKhoa { get; set; }
        [MoTaDuLieu("Thành viên tham gia")]
        public string ThanhVienThamGia { get; set; }
        [MoTaDuLieu("Danh sách thành viên tham gia")]
        public string DanhSachThanhVienThamGia { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
    }
    public class BienBanHoiChanPhauThuatFunc
    {
        public const string TableName = "BienBanHoiChanPhauThuat";
        public const string TablePrimaryKeyName = "ID";
        public static List<BienBanHoiChanPhauThuat> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BienBanHoiChanPhauThuat> list = new List<BienBanHoiChanPhauThuat>();
            try
            {
                string sql = @"SELECT * FROM BienBanHoiChanPhauThuat where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    BienBanHoiChanPhauThuat data = new BienBanHoiChanPhauThuat();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.TienSuBenh = DataReader["TienSuBenh"].ToString();
                    data.BenhSu = DataReader["BenhSu"].ToString();
                    data.KhamHienTai = DataReader["KhamHienTai"].ToString();
                    data.KetQuaXetNghiem = DataReader["KetQuaXetNghiem"].ToString();
                    data.ChanDoanTruocKhiMo = DataReader["ChanDoanTruocKhiMo"].ToString();
                    data.DuKienPhuongPhapMo = DataReader["DuKienPhuongPhapMo"].ToString();
                   
                    data.NgayMo = Convert.ToDateTime(DataReader["NgayMo"] == DBNull.Value ? DateTime.Now : DataReader["NgayMo"]);
                  
                    data.PhauThuatVienChinh = DataReader["PhauThuatVienChinh"].ToString();
                    data.MaPhauThuaVienChinh = DataReader["MaPhauThuaVienChinh"].ToString();
                    data.PhauThuatVienPhu = DataReader["PhauThuatVienPhu"].ToString();
                    data.MaPhauThuatVienPhu = DataReader["MaPhauThuatVienPhu"].ToString();
                    data.BacSyGayMe = DataReader["BacSyGayMe"].ToString();
                    data.MaBacSyGayMe = DataReader["MaBacSyGayMe"].ToString();

                    data.PhuongPhapVoCam = DataReader["PhuongPhapVoCam"].ToString();
                    data.SoLuongMauDuTru = DataReader["SoLuongMauDuTru"].ToString();
                    data.GiamDoc = DataReader["GiamDoc"].ToString();
                    data.MaGiamDoc = DataReader["MaGiamDoc"].ToString();
                    data.ChuNhiemKhoa = DataReader["ChuNhiemKhoa"].ToString();
                    data.MaChuNhiemKhoa = DataReader["MaChuNhiemKhoa"].ToString();
                    data.ThanhVienThamGia = DataReader["ThanhVienThamGia"].ToString();
                    data.DanhSachThanhVienThamGia = DataReader["DanhSachThanhVienThamGia"].ToString();

                    data.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                    data.NguoiTao = DataReader["NguoiTao"].ToString();
                    data.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);
                    data.NguoiSua = DataReader["NguoiSua"].ToString();

                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;
                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BienBanHoiChanPhauThuat bienBan)
        {
            try
            {
                string sql = @"INSERT INTO BienBanHoiChanPhauThuat
                (
                    MAQUANLY,
                    MaBenhNhan,
                    TienSuBenh,
                    BenhSu,
                    KhamHienTai,
                    KetQuaXetNghiem,
                    ChanDoanTruocKhiMo,
                    DuKienPhuongPhapMo,
                    NgayMo,
                    PhauThuatVienChinh,
                    MaPhauThuaVienChinh,
                    PhauThuatVienPhu,
                    MaPhauThuatVienPhu,
                    BacSyGayMe,
                    MaBacSyGayMe,
                    PhuongPhapVoCam,
                    SoLuongMauDuTru,
                    GiamDoc,
                    MaGiamDoc,
                    ChuNhiemKhoa,
                    MaChuNhiemKhoa,
                    THANHVIENTHAMGIA,
                    DANHSACHTHANHVIENTHAMGIA,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :TienSuBenh,
                    :BenhSu,
                    :KhamHienTai,
                    :KetQuaXetNghiem,
                    :ChanDoanTruocKhiMo,
                    :DuKienPhuongPhapMo,
                    :NgayMo,
                    :PhauThuatVienChinh,
                    :MaPhauThuaVienChinh,
                    :PhauThuatVienPhu,
                    :MaPhauThuatVienPhu,
                    :BacSyGayMe,
                    :MaBacSyGayMe,
                    :PhuongPhapVoCam,
                    :SoLuongMauDuTru,
                    :GiamDoc,
                    :MaGiamDoc,
                    :ChuNhiemKhoa,
                    :MaChuNhiemKhoa,
                    :THANHVIENTHAMGIA,
                    :DANHSACHTHANHVIENTHAMGIA,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (bienBan.ID != 0)
                {
                    sql = @"UPDATE BienBanHoiChanPhauThuat SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    TienSuBenh = :TienSuBenh,
                    BenhSu = :BenhSu,
                    KhamHienTai = :KhamHienTai,
                    KetQuaXetNghiem = :KetQuaXetNghiem,
                    ChanDoanTruocKhiMo = :ChanDoanTruocKhiMo,
                    DuKienPhuongPhapMo = :DuKienPhuongPhapMo,
                    NgayMo = :NgayMo,
                    PhauThuatVienChinh = :PhauThuatVienChinh,
                    MaPhauThuaVienChinh = :MaPhauThuaVienChinh,
                    PhauThuatVienPhu = :PhauThuatVienPhu,
                    MaPhauThuatVienPhu = :MaPhauThuatVienPhu,
                    BacSyGayMe = :BacSyGayMe,
                    MaBacSyGayMe = :MaBacSyGayMe,
                    PhuongPhapVoCam = :PhuongPhapVoCam,
                    SoLuongMauDuTru = :SoLuongMauDuTru,
                    GiamDoc = :GiamDoc,
                    MaGiamDoc = MaGiamDoc,
                    ChuNhiemKhoa = :ChuNhiemKhoa,
                    MaChuNhiemKhoa = :MaChuNhiemKhoa,
                    THANHVIENTHAMGIA =:THANHVIENTHAMGIA,
                    DANHSACHTHANHVIENTHAMGIA=:DANHSACHTHANHVIENTHAMGIA,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + bienBan.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bienBan.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", bienBan.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuBenh", bienBan.TienSuBenh));
                Command.Parameters.Add(new MDB.MDBParameter("BenhSu", bienBan.BenhSu));
                Command.Parameters.Add(new MDB.MDBParameter("KhamHienTai", bienBan.KhamHienTai));
                Command.Parameters.Add(new MDB.MDBParameter("KetQuaXetNghiem", bienBan.KetQuaXetNghiem));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTruocKhiMo", bienBan.ChanDoanTruocKhiMo));
                Command.Parameters.Add(new MDB.MDBParameter("DuKienPhuongPhapMo", bienBan.DuKienPhuongPhapMo));
                Command.Parameters.Add(new MDB.MDBParameter("NgayMo", bienBan.NgayMo));
                Command.Parameters.Add(new MDB.MDBParameter("PhauThuatVienChinh", bienBan.PhauThuatVienChinh));
                Command.Parameters.Add(new MDB.MDBParameter("MaPhauThuaVienChinh", bienBan.MaPhauThuaVienChinh));
                Command.Parameters.Add(new MDB.MDBParameter("PhauThuatVienPhu", bienBan.PhauThuatVienPhu));
                Command.Parameters.Add(new MDB.MDBParameter("MaPhauThuatVienPhu", bienBan.MaPhauThuatVienPhu));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyGayMe", bienBan.BacSyGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSyGayMe", bienBan.MaBacSyGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapVoCam", bienBan.PhuongPhapVoCam));
                Command.Parameters.Add(new MDB.MDBParameter("SoLuongMauDuTru", bienBan.SoLuongMauDuTru));
                Command.Parameters.Add(new MDB.MDBParameter("GiamDoc", bienBan.GiamDoc));
                Command.Parameters.Add(new MDB.MDBParameter("MaGiamDoc", bienBan.MaGiamDoc));
                Command.Parameters.Add(new MDB.MDBParameter("ChuNhiemKhoa", bienBan.ChuNhiemKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaChuNhiemKhoa", bienBan.MaChuNhiemKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("THANHVIENTHAMGIA", bienBan.ThanhVienThamGia));
                Command.Parameters.Add(new MDB.MDBParameter("DANHSACHTHANHVIENTHAMGIA", bienBan.DanhSachThanhVienThamGia));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", bienBan.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", bienBan.NgaySua));
                if (bienBan.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", bienBan.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", bienBan.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", bienBan.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (bienBan.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    bienBan.ID = nextval;
                }
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool delete(MDB.MDBConnection MyConnection, long id)
        {
            try
            {
                string sql = "DELETE FROM BienBanHoiChanPhauThuat WHERE ID = :ID";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                command.Parameters.Add(new MDB.MDBParameter("ID", id));
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
        public static DataSet getDataSet(MDB.MDBConnection MyConnection, long id)
        {
            string sql = @"SELECT
                B.*,
                T.MABENHAN,
                T.NGAYVAOVIEN,
                H.GIOITINH,
	            H.TENBENHNHAN,
                H.TUOI
            FROM
                BienBanHoiChanPhauThuat B
                LEFT JOIN THONGTINDIEUTRI T ON B.MAQUANLY = T.MAQUANLY
                LEFT JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "BB");

            DataTable thongTinVien = new DataTable("HEADER");

            thongTinVien.Columns.Add("BENHVIEN");
            thongTinVien.Columns.Add("KHOA");
            if (XemBenhAn._HanhChinhBenhNhan == null) XemBenhAn._HanhChinhBenhNhan = new HanhChinhBenhNhan();
            if (XemBenhAn._ThongTinDieuTri == null) XemBenhAn._ThongTinDieuTri = new ThongTinDieuTri();
            thongTinVien.Rows.Add(XemBenhAn._HanhChinhBenhNhan.BenhVien, XemBenhAn._ThongTinDieuTri.Khoa);
            ds.Tables.Add(thongTinVien);

            return ds;
        }
    }
}
