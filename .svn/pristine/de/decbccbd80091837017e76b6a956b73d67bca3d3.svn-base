
using EMR.KyDienTu;
using System;
using System.Collections.Generic;
using System.Data;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuKhamGayMeTruocMo2 : ThongTinKy
    {
        public PhieuKhamGayMeTruocMo2()
        {
            TableName = "PhieuKhamGayMeTruocMo2";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PKGMTM2;
            TenMauPhieu = DanhMucPhieu.PKGMTM2.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        public string CanNang { get; set; }
        public string ChieuCao { get; set; }
        [MoTaDuLieu("Tên bệnh nhân")]
        public string TenBenhNhan { get { return XemBenhAn._HanhChinhBenhNhan.TenBenhNhan; } }
        public string MaBenhNhan { get { return XemBenhAn._HanhChinhBenhNhan.MaBenhNhan; } }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get { return XemBenhAn._HanhChinhBenhNhan.Tuoi; } }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get { return XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description(); } }
        [MoTaDuLieu("Nhóm máu")]
		public string NhomMau { get; set; }
        public string ASA { get; set; }
        public string KCCamGiap { get; set; }
        public string Mullampati { get; set; }
        public string HaMieng { get; set; }
        public int RangGia { get; set; }
        public string GioAnCuoi { get; set; }
        public int CapCuu { get; set; }
		public string ChanDoan { get; set; }
        public string HuongXuTri { get; set; }
        public string TienSuNoiKhoa { get; set; }
        public string TienSuNgoaiKhoa { get; set; }
        public string TienSuGayMe { get; set; }
        public string DiUng { get; set; }
        public int NghienThuocLaThuocLao { get; set; }
        public int NghienRuou { get; set; }
        public int NghienMaTuy { get; set; }
        public string BenhLayNhiem { get; set; }
        public string ThuocDangDieuTri { get; set; }
        public string KhamLamSang { get; set; }
        public string KhamTuanHoan { get; set; }
        public string Mach { get; set; }
		public string HuyetAp { get; set; }
        public string KhamHoHap { get; set; }
        public string KhamThanKinh { get; set; }
        public string KhamCotSong { get; set; }
        public string XetNghiemBatThuong { get; set; }
        public string YeuCauBoSung { get; set; }
        public string DuKienCachVaThuocVoCam { get; set; }
        public string GiamDauSauMo { get; set; }
        public string YLenhTruocMoVaThuocTienMe { get; set; }
        public string MaNVBacSiThucHien { get; set; }
        public string NVBacSiThucHien { get; set; }
        public DateTime? ThoiGianKham { get; set; }
        public DateTime? ThoiGianKhamLai { get; set; }
        public string MaNVBacSiGayMe { get; set; }
        public string NVBacSiGayMe { get; set; }
        public string MaNVBacSiGayMe2 { get; set; }
        public string NVBacSiGayMe2 { get; set; }
        public string NguoiTao { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
        public string NguoiSua { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
        public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
        public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
        public bool Chon { get; set; }
        //public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
        public bool DaKy { get; set; }
    }
    public class PhieuKhamGayMeTruocMo2Func
    {
        public const string TableName = "PhieuKhamGayMeTruocMo2";
        public const string TablePrimaryKeyName = "ID";

        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuKhamGayMeTruocMo2 ketQua)
        {
            try
            {
                string sql = @"INSERT INTO PhieuKhamGayMeTruocMo2
                (
                    MaQuanLy,
                    CanNang,
                    ChieuCao,
                    NhomMau,
                    ASA,
                    KCCamGiap,
                    Mullampati,
                    HaMieng,
                    RangGia,
                    GioAnCuoi,
                    CapCuu,
                    ChanDoan,
                    HuongXuTri,
                    TienSuNoiKhoa,
                    TienSuNgoaiKhoa,
                    TienSuGayMe,
                    DiUng,
                    NghienThuocLaThuocLao,
                    NghienRuou,
                    NghienMaTuy,
                    BenhLayNhiem,
                    ThuocDangDieuTri,
                    KhamLamSang,
                    KhamTuanHoan,
                    Mach,
                    HuyetAp,
                    KhamHoHap,
                    KhamThanKinh,
                    KhamCotSong,
                    XetNghiemBatThuong,
                    YeuCauBoSung,
                    DuKienCachVaThuocVoCam,
                    GiamDauSauMo,
                    YLenhTruocMoVaThuocTienMe,
                    MaNVBacSiThucHien,
                    NVBacSiThucHien,
                    ThoiGianKham,
                    ThoiGianKhamLai,
                    MaNVBacSiGayMe,
                    NVBacSiGayMe,
                    MaNVBacSiGayMe2,
                    NVBacSiGayMe2,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
                    :MaQuanLy,
                    :CanNang,
                    :ChieuCao,
                    :NhomMau,
                    :ASA,
                    :KCCamGiap,
                    :Mullampati,
                    :HaMieng,
                    :RangGia,
                    :GioAnCuoi,
                    :CapCuu,
                    :ChanDoan,
                    :HuongXuTri,
                    :TienSuNoiKhoa,
                    :TienSuNgoaiKhoa,
                    :TienSuGayMe,
                    :DiUng,
                    :NghienThuocLaThuocLao,
                    :NghienRuou,
                    :NghienMaTuy,
                    :BenhLayNhiem,
                    :ThuocDangDieuTri,
                    :KhamLamSang,
                    :KhamTuanHoan,
                    :Mach,
                    :HuyetAp,
                    :KhamHoHap,
                    :KhamThanKinh,
                    :KhamCotSong,
                    :XetNghiemBatThuong,
                    :YeuCauBoSung,
                    :DuKienCachVaThuocVoCam,
                    :GiamDauSauMo,
                    :YLenhTruocMoVaThuocTienMe,
                    :MaNVBacSiThucHien,
                    :NVBacSiThucHien,
                    :ThoiGianKham,
                    :ThoiGianKhamLai,
                    :MaNVBacSiGayMe,
                    :NVBacSiGayMe,
                    :MaNVBacSiGayMe2,
                    :NVBacSiGayMe2,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE PhieuKhamGayMeTruocMo2 SET  
                    MaQuanLy=:MaQuanLy,
                    CanNang=:CanNang,
                    ChieuCao=:ChieuCao,
                    NhomMau=:NhomMau,
                    ASA=:ASA,
                    KCCamGiap=:KCCamGiap,
                    Mullampati=:Mullampati,
                    HaMieng=:HaMieng,
                    RangGia=:RangGia,
                    GioAnCuoi=:GioAnCuoi,
                    CapCuu=:CapCuu,
                    ChanDoan=:ChanDoan,
                    HuongXuTri=:HuongXuTri,
                    TienSuNoiKhoa=:TienSuNoiKhoa,
                    TienSuNgoaiKhoa=:TienSuNgoaiKhoa,
                    TienSuGayMe=:TienSuGayMe,
                    DiUng=:DiUng,
                    NghienThuocLaThuocLao=:NghienThuocLaThuocLao,
                    NghienRuou=:NghienRuou,
                    NghienMaTuy=:NghienMaTuy,
                    BenhLayNhiem=:BenhLayNhiem,
                    ThuocDangDieuTri=:ThuocDangDieuTri,
                    KhamLamSang=:KhamLamSang,
                    KhamTuanHoan=:KhamTuanHoan,
                    Mach=:Mach,
                    HuyetAp=:HuyetAp,
                    KhamHoHap=:KhamHoHap,
                    KhamThanKinh=:KhamThanKinh,
                    KhamCotSong=:KhamCotSong,
                    XetNghiemBatThuong=:XetNghiemBatThuong,
                    YeuCauBoSung=:YeuCauBoSung,
                    DuKienCachVaThuocVoCam=:DuKienCachVaThuocVoCam,
                    GiamDauSauMo=:GiamDauSauMo,
                    YLenhTruocMoVaThuocTienMe=:YLenhTruocMoVaThuocTienMe,
                    MaNVBacSiThucHien=:MaNVBacSiThucHien,
                    NVBacSiThucHien=:NVBacSiThucHien,
                    ThoiGianKham=:ThoiGianKham,
                    ThoiGianKhamLai=:ThoiGianKhamLai,
                    MaNVBacSiGayMe=:MaNVBacSiGayMe,
                    NVBacSiGayMe=:NVBacSiGayMe,
                    MaNVBacSiGayMe2=:MaNVBacSiGayMe2,
                    NVBacSiGayMe2=:NVBacSiGayMe2,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang", ketQua.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("ChieuCao", ketQua.ChieuCao));
                Command.Parameters.Add(new MDB.MDBParameter("NhomMau", ketQua.NhomMau));
                Command.Parameters.Add(new MDB.MDBParameter("ASA", ketQua.ASA));
                Command.Parameters.Add(new MDB.MDBParameter("KCCamGiap", ketQua.KCCamGiap));
                Command.Parameters.Add(new MDB.MDBParameter("Mullampati", ketQua.Mullampati));
                Command.Parameters.Add(new MDB.MDBParameter("HaMieng", ketQua.HaMieng));
                Command.Parameters.Add(new MDB.MDBParameter("RangGia", ketQua.RangGia));
                Command.Parameters.Add(new MDB.MDBParameter("GioAnCuoi", ketQua.GioAnCuoi));
                Command.Parameters.Add(new MDB.MDBParameter("CapCuu", ketQua.CapCuu));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", ketQua.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("HuongXuTri", ketQua.HuongXuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuNoiKhoa", ketQua.TienSuNoiKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuNgoaiKhoa", ketQua.TienSuNgoaiKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuGayMe", ketQua.TienSuGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("DiUng", ketQua.DiUng));
                Command.Parameters.Add(new MDB.MDBParameter("NghienThuocLaThuocLao", ketQua.NghienThuocLaThuocLao));
                Command.Parameters.Add(new MDB.MDBParameter("NghienRuou", ketQua.NghienRuou));
                Command.Parameters.Add(new MDB.MDBParameter("NghienMaTuy", ketQua.NghienMaTuy));
                Command.Parameters.Add(new MDB.MDBParameter("BenhLayNhiem", ketQua.BenhLayNhiem));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocDangDieuTri", ketQua.ThuocDangDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("KhamLamSang", ketQua.KhamLamSang));
                Command.Parameters.Add(new MDB.MDBParameter("KhamTuanHoan", ketQua.KhamTuanHoan));
                Command.Parameters.Add(new MDB.MDBParameter("Mach", ketQua.Mach));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetAp", ketQua.HuyetAp));
                Command.Parameters.Add(new MDB.MDBParameter("KhamHoHap", ketQua.KhamHoHap));
                Command.Parameters.Add(new MDB.MDBParameter("KhamThanKinh", ketQua.KhamThanKinh));
                Command.Parameters.Add(new MDB.MDBParameter("KhamCotSong", ketQua.KhamCotSong));
                Command.Parameters.Add(new MDB.MDBParameter("XetNghiemBatThuong", ketQua.XetNghiemBatThuong));
                Command.Parameters.Add(new MDB.MDBParameter("YeuCauBoSung", ketQua.YeuCauBoSung));
                Command.Parameters.Add(new MDB.MDBParameter("DuKienCachVaThuocVoCam", ketQua.DuKienCachVaThuocVoCam));
                Command.Parameters.Add(new MDB.MDBParameter("GiamDauSauMo", ketQua.GiamDauSauMo));
                Command.Parameters.Add(new MDB.MDBParameter("YLenhTruocMoVaThuocTienMe", ketQua.YLenhTruocMoVaThuocTienMe));
                Command.Parameters.Add(new MDB.MDBParameter("MaNVBacSiThucHien", ketQua.MaNVBacSiThucHien));
                Command.Parameters.Add(new MDB.MDBParameter("NVBacSiThucHien", ketQua.NVBacSiThucHien));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianKham", ketQua.ThoiGianKham));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianKhamLai", ketQua.ThoiGianKhamLai));
                Command.Parameters.Add(new MDB.MDBParameter("MaNVBacSiGayMe", ketQua.MaNVBacSiGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("NVBacSiGayMe", ketQua.NVBacSiGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("MaNVBacSiGayMe2", ketQua.MaNVBacSiGayMe2));
                Command.Parameters.Add(new MDB.MDBParameter("NVBacSiGayMe2", ketQua.NVBacSiGayMe2));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));
                if (ketQua.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", ketQua.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", ketQua.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", ketQua.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (ketQua.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    ketQua.ID = nextval;
                }
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static List<PhieuKhamGayMeTruocMo2> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuKhamGayMeTruocMo2> list = new List<PhieuKhamGayMeTruocMo2>();
            try
            {
                string sql = @"SELECT * FROM PhieuKhamGayMeTruocMo2 where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuKhamGayMeTruocMo2 obj = new PhieuKhamGayMeTruocMo2();
                    obj.ID = DataReader.GetLong("ID");
                    obj.MaQuanLy = DataReader.GetDecimal("MaQuanLy");
                    obj.CanNang = DataReader["CanNang"].ToString();
                    obj.ChieuCao = DataReader["ChieuCao"].ToString();
                    obj.NhomMau = DataReader["NhomMau"].ToString();
                    obj.ASA = DataReader["ASA"].ToString();
                    obj.KCCamGiap = DataReader["KCCamGiap"].ToString();
                    obj.Mullampati = DataReader["Mullampati"].ToString();
                    obj.HaMieng = DataReader["HaMieng"].ToString();
                    obj.RangGia = DataReader.GetInt("RangGia");
                    obj.GioAnCuoi = DataReader["GioAnCuoi"].ToString();
                    obj.CapCuu = DataReader.GetInt("CapCuu");
                    obj.ChanDoan = DataReader["ChanDoan"].ToString();
                    obj.HuongXuTri = DataReader["HuongXuTri"].ToString();
                    obj.TienSuNoiKhoa = DataReader["TienSuNoiKhoa"].ToString();
                    obj.TienSuNgoaiKhoa = DataReader["TienSuNgoaiKhoa"].ToString();
                    obj.TienSuGayMe = DataReader["TienSuGayMe"].ToString();
                    obj.DiUng = DataReader["DiUng"].ToString();
                    obj.NghienThuocLaThuocLao = DataReader.GetInt("NghienThuocLaThuocLao");
                    obj.NghienRuou = DataReader.GetInt("NghienRuou");
                    obj.NghienMaTuy = DataReader.GetInt("NghienMaTuy");
                    obj.BenhLayNhiem = DataReader["BenhLayNhiem"].ToString();
                    obj.ThuocDangDieuTri = DataReader["ThuocDangDieuTri"].ToString();
                    obj.KhamLamSang = DataReader["KhamLamSang"].ToString();
                    obj.KhamTuanHoan = DataReader["KhamTuanHoan"].ToString();
                    obj.Mach = DataReader["Mach"].ToString();
                    obj.HuyetAp = DataReader["HuyetAp"].ToString();
                    obj.KhamHoHap = DataReader["KhamHoHap"].ToString();
                    obj.KhamThanKinh = DataReader["KhamThanKinh"].ToString();
                    obj.KhamCotSong = DataReader["KhamCotSong"].ToString();
                    obj.XetNghiemBatThuong = DataReader["XetNghiemBatThuong"].ToString();
                    obj.YeuCauBoSung = DataReader["YeuCauBoSung"].ToString();
                    obj.DuKienCachVaThuocVoCam = DataReader["DuKienCachVaThuocVoCam"].ToString();
                    obj.GiamDauSauMo = DataReader["GiamDauSauMo"].ToString();
                    obj.YLenhTruocMoVaThuocTienMe = DataReader["YLenhTruocMoVaThuocTienMe"].ToString();
                    obj.MaNVBacSiThucHien = DataReader["MaNVBacSiThucHien"].ToString();
                    obj.NVBacSiThucHien = DataReader["NVBacSiThucHien"].ToString();
                    obj.ThoiGianKham = Common.ConDB_DateTime("ThoiGianKham"); 
                    obj.ThoiGianKhamLai = Common.ConDB_DateTime("ThoiGianKhamLai");
                    obj.MaNVBacSiGayMe = DataReader["MaNVBacSiGayMe"].ToString();
                    obj.NVBacSiGayMe = DataReader["NVBacSiGayMe"].ToString();
                    obj.MaNVBacSiGayMe2 = DataReader["MaNVBacSiGayMe2"].ToString();
                    obj.NVBacSiGayMe2 = DataReader["NVBacSiGayMe2"].ToString();
                    obj.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                    obj.NguoiTao = DataReader["NguoiTao"].ToString();
                    obj.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);
                    obj.NguoiSua = DataReader["NguoiSua"].ToString();
                    obj.MaSoKy = DataReader["masokyten"].ToString();
                    obj.DaKy = !string.IsNullOrEmpty(obj.MaSoKy) ? true : false;
                    list.Add(obj);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool delete(MDB.MDBConnection MyConnection, long id)
        {
            try
            {
                string sql = "DELETE FROM PhieuKhamGayMeTruocMo2 WHERE ID = :ID";
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
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, long IDBienBan)
        {
            string sql = @"SELECT
                D.*,
	            T.MABENHNHAN,
	            H.SOYTE,
	            H.BENHVIEN
            FROM
                PhieuKhamGayMeTruocMo2 D
                LEFT JOIN THONGTINDIEUTRI T ON D.MAQUANLY = T.MAQUANLY
                LEFT JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
            WHERE
                ID = " + IDBienBan;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "TB");

            DataTable ttbenhnhan = new DataTable("TTBENHNHAN");

            ttbenhnhan.Columns.Add("TenBenhNhan");
            ttbenhnhan.Columns.Add("Tuoi");
            ttbenhnhan.Columns.Add("GioiTinh");
            ttbenhnhan.Columns.Add("CanNang");
            ttbenhnhan.Columns.Add("ChieuCao");
            if (XemBenhAn._HanhChinhBenhNhan == null) XemBenhAn._HanhChinhBenhNhan = new HanhChinhBenhNhan();
            if (XemBenhAn._ThongTinDieuTri == null) XemBenhAn._ThongTinDieuTri = new ThongTinDieuTri();
            ttbenhnhan.Rows.Add(XemBenhAn._HanhChinhBenhNhan.TenBenhNhan, XemBenhAn._HanhChinhBenhNhan.Tuoi, XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description(), XemBenhAn._ThongTinDieuTri.DauSinhTon.CanNang.ToString(), XemBenhAn._ThongTinDieuTri.DauSinhTon.ChieuCao.ToString());
            ds.Tables.Add(ttbenhnhan);

            return ds;
        }
    }
}
