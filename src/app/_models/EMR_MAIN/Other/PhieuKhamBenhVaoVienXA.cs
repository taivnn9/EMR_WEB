using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuKhamBenhVaoVienXA : ThongTinKy
    {
        // bắt buộc tạo contructor
        public PhieuKhamBenhVaoVienXA()
        {
            TableName = "PhieuKhamBenhVaoVienXA";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PKBVVXA;
            TenMauPhieu = DanhMucPhieu.PKBVVXA.Description();
        }
        // bắt buộc phải có trường, ID, MaQuanLy, MaBenhNhan
        [MoTaDuLieu("Mã định danh")]
        public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau", "", 1)]
        public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
        public string MaBenhNhan { get; set; }
        public string BuongKhamBenh { get; set; }
        public string SoVaoVien { get; set; }
        public string HoVaTen { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string Tuoi { get; set; }
        public int GioiTinh { get; set; } // 1 nam 2 nữ
        public string NgheNghiep { get; set; }
        public string MaNgheNghiep { get; set; }
        public string DanToc { get; set; }
        public string MaDanToc { get; set; }
        public string NgoaiKieu { get; set; }
        public string MaNgoaiKieu { get; set; }
        public string SoNha { get; set; }
        public string ThonPho { get; set; }
        public string XaPhuong { get; set; }
        public string Huyen { get; set; }
        public string MaHuyen { get; set; }
        public string TinhThanhPho { get; set; }
        public string MaTinhThanhPho { get; set; }
        public string NoiLamViec { get; set; }
        public int LoaiDoiTuong { get; set; } // 1.BHYT, 2.ThuPhi 3.Miễn 4.Khac
        public DateTime? NgayHetHanBHYT { get; set; }
        public string SoTheBHYT { get; set; }
        public string HoTenDiaChiNguoiNha { get; set; }
        public string SoDienThoaiNguoiNha { get; set; }
        public DateTime? GioKhamBenh { get; set; }
        public DateTime? NgayKham { get; set; }
        public string ChanDoanNoiGT { get; set; }
        public string LyDoVaoVien { get; set; }
        public string QuaTrinhBenhLi { get; set; }
        public string TienSuBenhBanThan { get; set; }
        public string TienSuBenhGiaDinh { get; set; }
        public string KhamXetToanThan { get; set; }
        public int? Mach { get; set; }
        public double? NhietDo { get; set; }
        public string HuyetAp { get; set; }
        public int? NhipTho { get; set; }
        public string KhamXetCacBoPhan { get; set; }
        public string TomTatKetQua { get; set; }
        public string ChanDoanVaoVien { get; set; }
        public string DaXuLi { get; set; }
        public string DieuTriTaiKhoa { get; set; }
        public string ChuY { get; set; }
        public DateTime NgayTao { get; set; }
        public string TenBacSi { get; set; }
        public string NguoiTao { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
        public bool Chon { get; set; }
    }
    public class PhieuKhamBenhVaoVienXAFunc
    {
        public const string TableName = "PhieuKhamBenhVaoVienXA";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuKhamBenhVaoVienXA> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuKhamBenhVaoVienXA> list = new List<PhieuKhamBenhVaoVienXA>();
            try
            {
                string sql = @"SELECT * FROM PhieuKhamBenhVaoVienXA where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuKhamBenhVaoVienXA data = new PhieuKhamBenhVaoVienXA();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.BuongKhamBenh = DataReader["BuongKhamBenh"].ToString();
                    data.SoVaoVien = DataReader["SoVaoVien"].ToString();
                    data.HoVaTen = DataReader["HoVaTen"].ToString();
                    data.NgaySinh = DataReader["NgaySinh"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgaySinh"].ToString()) : null;
                    data.Tuoi = DataReader["Tuoi"].ToString();
                    data.GioiTinh = Convert.ToInt32(DataReader["GioiTinh"].ToString());
                    data.NgheNghiep = DataReader["NgheNghiep"].ToString();
                    data.MaNgheNghiep = DataReader["MaNgheNghiep"].ToString();
                    data.DanToc = DataReader["DanToc"].ToString();
                    data.MaDanToc = DataReader["MaDanToc"].ToString();
                    data.NgoaiKieu = DataReader["NgoaiKieu"].ToString();
                    data.MaNgoaiKieu = DataReader["MaNgoaiKieu"].ToString();
                    data.SoNha = DataReader["SoNha"].ToString();
                    data.ThonPho = DataReader["ThonPho"].ToString();
                    data.XaPhuong = DataReader["XaPhuong"].ToString();
                    data.Huyen = DataReader["Huyen"].ToString();
                    data.MaHuyen = DataReader["MaHuyen"].ToString();
                    data.TinhThanhPho = DataReader["TinhThanhPho"].ToString();
                    data.MaTinhThanhPho = DataReader["MaTinhThanhPho"].ToString();
                    data.NoiLamViec = DataReader["NoiLamViec"].ToString();
                    data.LoaiDoiTuong = Convert.ToInt32(DataReader["LoaiDoiTuong"].ToString());
                    data.NgayHetHanBHYT = DataReader["NgayHetHanBHYT"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayHetHanBHYT"].ToString()) : null;
                    data.SoTheBHYT = DataReader["SoTheBHYT"].ToString();
                    data.HoTenDiaChiNguoiNha = DataReader["HoTenDiaChiNguoiNha"].ToString();
                    data.SoDienThoaiNguoiNha = DataReader["SoDienThoaiNguoiNha"].ToString();
                    data.GioKhamBenh = DataReader["GioKhamBenh"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["GioKhamBenh"].ToString()) : null;
                    data.NgayKham = DataReader["NgayKham"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayKham"].ToString()) : null;
                    data.ChanDoanNoiGT = DataReader["SoDienThoaiNguoiNha"].ToString();
                    data.LyDoVaoVien = DataReader["LyDoVaoVien"].ToString();
                    data.QuaTrinhBenhLi = DataReader["QuaTrinhBenhLi"].ToString();
                    data.TienSuBenhBanThan = DataReader["TienSuBenhBanThan"].ToString();
                    data.TienSuBenhGiaDinh = DataReader["TienSuBenhGiaDinh"].ToString();
                    data.KhamXetToanThan = DataReader["KhamXetToanThan"].ToString();
                    data.Mach = DataReader["Mach"] != DBNull.Value ? (int?)Convert.ToInt32(DataReader["Mach"].ToString()) : null;
                    data.NhietDo = DataReader["NhietDo"] != DBNull.Value ? (double?)Convert.ToDouble(DataReader["NhietDo"].ToString()) : null;
                    data.HuyetAp = DataReader["HuyetAp"].ToString();
                    data.NhipTho = DataReader["NhipTho"] != DBNull.Value ? (int?)Convert.ToInt32(DataReader["NhipTho"].ToString()) : null;
                    data.KhamXetCacBoPhan = DataReader["KhamXetCacBoPhan"].ToString();
                    data.TomTatKetQua = DataReader["TomTatKetQua"].ToString();
                    data.ChanDoanVaoVien = DataReader["ChanDoanVaoVien"].ToString();
                    data.DaXuLi = DataReader["DaXuLi"].ToString();
                    data.DieuTriTaiKhoa = DataReader["DieuTriTaiKhoa"].ToString();
                    data.ChuY = DataReader["ChuY"].ToString();
                    data.NgayTao = Convert.ToDateTime(DataReader["NgayTao"].ToString());
                    data.TenBacSi = DataReader["TenBacSi"].ToString();
                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, PhieuKhamBenhVaoVienXA ketQua)
        {
            try
            {
                string sql = @"INSERT INTO PhieuKhamBenhVaoVienXA
                (
                    MAQUANLY,
                    MaBenhNhan,
                    BuongKhamBenh,
                    SoVaoVien,
                    HoVaTen,
                    NgaySinh,
                    Tuoi,
                    GioiTinh,
                    NgheNghiep,
                    MaNgheNghiep,
                    DanToc,
                    MaDanToc,
                    NgoaiKieu,
                    MaNgoaiKieu,
                    SoNha,
                    ThonPho,
                    XaPhuong,
                    Huyen,
                    MaHuyen,
                    TinhThanhPho,
                    MaTinhThanhPho,
                    NoiLamViec,
                    LoaiDoiTuong,
                    NgayHetHanBHYT,
                    SoTheBHYT,
                    HoTenDiaChiNguoiNha,
                    SoDienThoaiNguoiNha,
                    GioKhamBenh,
                    NgayKham,
                    ChanDoanNoiGT,
                    LyDoVaoVien,
                    QuaTrinhBenhLi,
                    TienSuBenhBanThan,
                    TienSuBenhGiaDinh,
                    KhamXetToanThan,
                    Mach,
                    NhietDo,
                    HuyetAp,
                    NhipTho,
                    KhamXetCacBoPhan,
                    TomTatKetQua,
                    ChanDoanVaoVien,
                    DaXuLi,
                    DieuTriTaiKhoa,
                    ChuY,
                    NgayTao,
                    TenBacSi,
                    NguoiTao
                    )  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :BuongKhamBenh,
                    :SoVaoVien,
                    :HoVaTen,
                    :NgaySinh,
                    :Tuoi,
                    :GioiTinh,
                    :NgheNghiep,
                    :MaNgheNghiep,
                    :DanToc,
                    :MaDanToc,
                    :NgoaiKieu,
                    :MaNgoaiKieu,
                    :SoNha,
                    :ThonPho,
                    :XaPhuong,
                    :Huyen,
                    :MaHuyen,
                    :TinhThanhPho,
                    :MaTinhThanhPho,
                    :NoiLamViec,
                    :LoaiDoiTuong,
                    :NgayHetHanBHYT,
                    :SoTheBHYT,
                    :HoTenDiaChiNguoiNha,
                    :SoDienThoaiNguoiNha,
                    :GioKhamBenh,
                    :NgayKham,
                    :ChanDoanNoiGT,
                    :LyDoVaoVien,
                    :QuaTrinhBenhLi,
                    :TienSuBenhBanThan,
                    :TienSuBenhGiaDinh,
                    :KhamXetToanThan,
                    :Mach,
                    :NhietDo,
                    :HuyetAp,
                    :NhipTho,
                    :KhamXetCacBoPhan,
                    :TomTatKetQua,
                    :ChanDoanVaoVien,
                    :DaXuLi,
                    :DieuTriTaiKhoa,
                    :ChuY,
                    :NgayTao,
                    :TenBacSi,
                    :NguoiTao
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE PhieuKhamBenhVaoVienXA SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    BuongKhamBenh =:BuongKhamBenh,
                    SoVaoVien =:SoVaoVien,
                    HoVaTen =:HoVaTen,
                    NgaySinh =:NgaySinh,
                    Tuoi =:Tuoi,
                    GioiTinh =:GioiTinh,
                    NgheNghiep =:NgheNghiep,
                    MaNgheNghiep =:MaNgheNghiep,
                    DanToc =:DanToc,
                    MaDanToc =:MaDanToc,
                    NgoaiKieu =:NgoaiKieu,
                    MaNgoaiKieu =:MaNgoaiKieu,
                    SoNha =:SoNha,
                    ThonPho =:ThonPho,
                    XaPhuong =:XaPhuong,
                    Huyen =:Huyen,
                    MaHuyen =:MaHuyen,
                    TinhThanhPho =:TinhThanhPho,
                    MaTinhThanhPho =:MaTinhThanhPho,
                    NoiLamViec =:NoiLamViec,
                    LoaiDoiTuong =:LoaiDoiTuong,
                    NgayHetHanBHYT =:NgayHetHanBHYT,
                    SoTheBHYT =:SoTheBHYT,
                    HoTenDiaChiNguoiNha  =:HoTenDiaChiNguoiNha,
                    SoDienThoaiNguoiNha =:SoDienThoaiNguoiNha,
                    GioKhamBenh =:GioKhamBenh,
                    NgayKham =:NgayKham,
                    ChanDoanNoiGT =:ChanDoanNoiGT,
                    LyDoVaoVien =:LyDoVaoVien,
                    QuaTrinhBenhLi =:QuaTrinhBenhLi,
                    TienSuBenhBanThan =:TienSuBenhBanThan,
                    TienSuBenhGiaDinh =:TienSuBenhGiaDinh,
                    KhamXetToanThan =:KhamXetToanThan,
                    Mach  =:Mach,
                    NhietDo =:NhietDo,
                    HuyetAp =:HuyetAp,
                    NhipTho =:NhipTho,
                    KhamXetCacBoPhan =:KhamXetCacBoPhan,
                    TomTatKetQua =:TomTatKetQua,
                    ChanDoanVaoVien =:ChanDoanVaoVien,
                    DaXuLi =:DaXuLi,
                    DieuTriTaiKhoa =:DieuTriTaiKhoa,
                    ChuY =:ChuY,
                    NgayTao =:NgayTao,
                    TenBacSi =:TenBacSi,
                    NguoiTao =:NguoiTao
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ketQua.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("BuongKhamBenh", ketQua.BuongKhamBenh));
                Command.Parameters.Add(new MDB.MDBParameter("SoVaoVien", ketQua.SoVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("HoVaTen", ketQua.HoVaTen));
                Command.Parameters.Add(new MDB.MDBParameter("NgaySinh", ketQua.NgaySinh));
                Command.Parameters.Add(new MDB.MDBParameter("Tuoi", ketQua.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("GioiTinh", ketQua.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("NgheNghiep", ketQua.NgheNghiep));
                Command.Parameters.Add(new MDB.MDBParameter("MaNgheNghiep", ketQua.MaNgheNghiep));
                Command.Parameters.Add(new MDB.MDBParameter("DanToc", ketQua.DanToc));
                Command.Parameters.Add(new MDB.MDBParameter("MaDanToc", ketQua.MaDanToc));
                Command.Parameters.Add(new MDB.MDBParameter("NgoaiKieu", ketQua.NgoaiKieu));
                Command.Parameters.Add(new MDB.MDBParameter("MaNgoaiKieu", ketQua.MaNgoaiKieu));
                Command.Parameters.Add(new MDB.MDBParameter("SoNha", ketQua.SoNha));
                Command.Parameters.Add(new MDB.MDBParameter("ThonPho", ketQua.ThonPho));
                Command.Parameters.Add(new MDB.MDBParameter("XaPhuong", ketQua.XaPhuong));
                Command.Parameters.Add(new MDB.MDBParameter("Huyen", ketQua.Huyen));
                Command.Parameters.Add(new MDB.MDBParameter("MaHuyen", ketQua.MaHuyen));
                Command.Parameters.Add(new MDB.MDBParameter("TinhThanhPho", ketQua.TinhThanhPho));
                Command.Parameters.Add(new MDB.MDBParameter("MaTinhThanhPho", ketQua.MaTinhThanhPho));
                Command.Parameters.Add(new MDB.MDBParameter("NoiLamViec", ketQua.NoiLamViec));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiDoiTuong", ketQua.LoaiDoiTuong));
                Command.Parameters.Add(new MDB.MDBParameter("NgayHetHanBHYT", ketQua.NgayHetHanBHYT));
                Command.Parameters.Add(new MDB.MDBParameter("SoTheBHYT", ketQua.SoTheBHYT));
                Command.Parameters.Add(new MDB.MDBParameter("HoTenDiaChiNguoiNha", ketQua.HoTenDiaChiNguoiNha));
                Command.Parameters.Add(new MDB.MDBParameter("SoDienThoaiNguoiNha", ketQua.SoDienThoaiNguoiNha));
                Command.Parameters.Add(new MDB.MDBParameter("GioKhamBenh", ketQua.GioKhamBenh));
                Command.Parameters.Add(new MDB.MDBParameter("NgayKham", ketQua.NgayKham));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanNoiGT", ketQua.ChanDoanNoiGT));
                Command.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", ketQua.LyDoVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("QuaTrinhBenhLi", ketQua.QuaTrinhBenhLi));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhBanThan", ketQua.TienSuBenhBanThan));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhGiaDinh", ketQua.TienSuBenhGiaDinh));
                Command.Parameters.Add(new MDB.MDBParameter("KhamXetToanThan", ketQua.KhamXetToanThan));
                Command.Parameters.Add(new MDB.MDBParameter("Mach", ketQua.Mach));
                Command.Parameters.Add(new MDB.MDBParameter("NhietDo", ketQua.NhietDo));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetAp", ketQua.HuyetAp));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTho", ketQua.NhipTho));
                Command.Parameters.Add(new MDB.MDBParameter("KhamXetCacBoPhan", ketQua.KhamXetCacBoPhan));
                Command.Parameters.Add(new MDB.MDBParameter("TomTatKetQua", ketQua.TomTatKetQua));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanVaoVien", ketQua.ChanDoanVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("DaXuLi", ketQua.DaXuLi));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriTaiKhoa", ketQua.DieuTriTaiKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("ChuY", ketQua.ChuY));
                Command.Parameters.Add(new MDB.MDBParameter("NgayTao", ketQua.NgayTao));
                Command.Parameters.Add(new MDB.MDBParameter("TenBacSi", ketQua.TenBacSi));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiTao", ketQua.NguoiTao));

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
        public static bool Delete(MDB.MDBConnection MyConnection, long id)
        {
            try
            {
                string sql = "DELETE FROM PhieuKhamBenhVaoVienXA WHERE ID = :ID";
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
        public static DataSet getDataSet(MDB.MDBConnection MyConnection, string id)
        {
            string sql = @"SELECT
                P.* 
            FROM
                PhieuKhamBenhVaoVienXA P
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "KQ");
            DateTime NgayTao = Convert.ToDateTime(ds.Tables[0].Rows[0]["NgayTao"]);

            ds.Tables[0].AddColumn("NgayTaoFormat", typeof(string));
            ds.Tables[0].Rows[0]["NgayTaoFormat"] = $"Ngày {NgayTao.Day} tháng {NgayTao.Month} năm {NgayTao.Year}";

            //ngày bảo hiểm y tế format
            DateTime NgayHetHanBHYT = Convert.ToDateTime(ds.Tables[0].Rows[0]["NgayHetHanBHYT"]);
            ds.Tables[0].AddColumn("NgayHetHanBHYTFormat", typeof(string));
            ds.Tables[0].Rows[0]["NgayHetHanBHYTFormat"] = $"Ngày {NgayHetHanBHYT.Day} tháng {NgayHetHanBHYT.Month} năm {NgayHetHanBHYT.Year}";

            //Vào viện lúc format
            DateTime? GioKhamBenh = !string.IsNullOrEmpty(ds.Tables[0].Rows[0]["GioKhamBenh"].ToString()) ? (DateTime?)Convert.ToDateTime(ds.Tables[0].Rows[0]["GioKhamBenh"]) : null;
            DateTime NgayKham = Convert.ToDateTime(ds.Tables[0].Rows[0]["NgayKham"]);
            ds.Tables[0].AddColumn("VaoVienLucFormat", typeof(string));
            ds.Tables[0].Rows[0]["VaoVienLucFormat"] = GioKhamBenh != null ? (GioKhamBenh.Value.Hour + " giờ  " + GioKhamBenh.Value.Minute + " phút, ngày " +
                NgayKham.Day + " tháng " + NgayKham.Month + " năm " + NgayKham.Year) : ("Ngày " + NgayKham.Day + " tháng " + NgayKham.Month + " năm " + NgayKham.Year);

            ds.Tables[0].AddColumn("SOYTE", typeof(string));
            ds.Tables[0].AddColumn("BENHVIEN", typeof(string));
            ds.Tables[0].AddColumn("KHOA", typeof(string));

            //ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            //ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            //ds.Tables[0].Rows[0]["NamSinh"] = XemBenhAn._HanhChinhBenhNhan.NgaySinh.HasValue ? XemBenhAn._HanhChinhBenhNhan.NgaySinh.Value.Year + "": "";
            //ds.Tables[0].Rows[0]["GioiTinh"] = (int)XemBenhAn._HanhChinhBenhNhan.GioiTinh;
            ds.Tables[0].Rows[0]["SOYTE"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["KHOA"] = XemBenhAn._ThongTinDieuTri.Khoa;

            return ds;
        }
    }
}
