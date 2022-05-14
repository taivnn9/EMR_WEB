using EMR.KyDienTu;
using Newtonsoft.Json;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuTomTatBenhAn : ThongTinKy
    {
        public PhieuTomTatBenhAn()
        {
            TableName = "PhieuTomTatBenhAn";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PTTBA;
            TenMauPhieu = DanhMucPhieu.PTTBA.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Họ tên người bệnh")]
        public string HoTenBenhNhan { get; set; }
        [MoTaDuLieu("Năm sinh người bệnh")]
        public string NamSinh { get; set; }
        [MoTaDuLieu("Giới tính người bệnh")]
        public string GioiTinh { get; set; }
        [MoTaDuLieu("Dân tộc")]
        public string DanToc { get; set; }
        [MoTaDuLieu("Mã số bảo hiểm y tế")]
        public string MSBHYT { get; set; }
        [MoTaDuLieu("Nghề nghiệp bệnh nhân")]
        public string NgheNghiep { get; set; }
        [MoTaDuLieu("Đơn vị bệnh nhân")]
        public string DonVi { get; set; }
        [MoTaDuLieu("Địa chỉ bệnh nhân")]
        public string DiaChi { get; set; }
        [MoTaDuLieu("Ngày vào viện")]
        public DateTime NgayVaoVien { get; set; }
        [MoTaDuLieu("Ngày ra viện")]
        public DateTime NgayRaVien { get; set; }
        [MoTaDuLieu(" Chẩn đoán lúc vào viện")]
        public string ChanDoanVaoVien { get; set; }
        [MoTaDuLieu("Chẩn đoán lúc ra viện")]
        public string ChanDoanRaVien { get; set; }
        [MoTaDuLieu("Tóm tắ quá trình bệnh lý")]
        public string TomTatBenhAn { get; set; }
        [MoTaDuLieu("Kết quả khám tim")]
        public string KhamTim { get; set; }
        [MoTaDuLieu("Kết quả khám phổi")]
        public string KhamPhoi { get; set; }
        [MoTaDuLieu("Xét nghiệm")]
        public string XetNghiem { get; set; }
        [MoTaDuLieu("Công thức máu")]
        public string CongThucMau { get; set; }
        [MoTaDuLieu("Sinh hóa máu")]
        public string SinhHoaMau { get; set; }
        [MoTaDuLieu("Kết quả chụp CT - SCANNER")]
        public string KetQuaChup { get; set; }
        [MoTaDuLieu(" Kết quả đo CNHH")]
        public string KetQuaDo { get; set; }
        [MoTaDuLieu("Kết quả nội soi Tai - Mũi - Họng")]
        public string KetQuaNoiSoi { get; set; }
        [MoTaDuLieu("Kết quả điện tim")]
        public string KetQuaDienTim { get; set; }
        [MoTaDuLieu("Kết quả siêu âm")]
        public string KetQuaSieuAm { get; set; }
        [MoTaDuLieu("Kết quả xét nghiệm đờm")]
        public string KetQuaXetNghiem { get; set; }
        [MoTaDuLieu("Phương pháp điều trị")]
        public string PhuongPhapDieuTri { get; set; }
        [MoTaDuLieu("TÌnh trạng ra viện của bệnh nhân")]
        public string TinhTrangRaVien { get; set; }
        [MoTaDuLieu(" Ghi chú đối với bệnh án")]
        public string GhiChu { get; set; }
        [MoTaDuLieu(" Thời gian tóm tắt bệnh án")]
        public DateTime ThoiGian { get; set; }
        [MoTaDuLieu("Nguời sao bệnh an")]
        public string MaNguoiSao { get; set; }
        [MoTaDuLieu("")]
        public string NguoiSao { get; set; }
        [MoTaDuLieu("Thủ trưởng đơn vị")]
        public string MaThuTruong { get; set; }
        public string ThuTruong { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
    }

    public class PhieuTomTatBenhAnFunc
    {
        public const string TableName = "PhieuTomTatBenhAn";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuTomTatBenhAn> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuTomTatBenhAn> list = new List<PhieuTomTatBenhAn>();
            try
            {
                string sql = @"SELECT * FROM PhieuTomTatBenhAn where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuTomTatBenhAn data = new PhieuTomTatBenhAn();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.HoTenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.NamSinh = Common.ConDBNull(DataReader["NamSinh"]);
                    data.GioiTinh = Common.ConDBNull(DataReader["GioiTinh"]);
                    data.DanToc = Common.ConDBNull(DataReader["DanToc"]);
                    data.MSBHYT = Common.ConDBNull(DataReader["MSBHYT"]);
                    data.NgheNghiep = Common.ConDBNull(DataReader["NgheNghiep"]);
                    data.DonVi = Common.ConDBNull(DataReader["DonVi"]);
                    data.DiaChi = Common.ConDBNull(DataReader["DiaChi"]);
                    data.NgayVaoVien = Common.ConDB_DateTime(DataReader["NgayVaoVien"]);
                    data.NgayRaVien = Common.ConDB_DateTime(DataReader["NgayRaVien"]);
                    data.ChanDoanVaoVien = Common.ConDBNull(DataReader["ChanDoanVaoVien"]);
                    data.ChanDoanRaVien = Common.ConDBNull(DataReader["ChanDoanRaVien"]);
                    data.TomTatBenhAn = Common.ConDBNull(DataReader["TomTatBenhAn"]);
                    data.KhamTim = Common.ConDBNull(DataReader["KhamTim"]);
                    data.KhamPhoi = Common.ConDBNull(DataReader["KhamPhoi"]);
                    data.XetNghiem = Common.ConDBNull(DataReader["XetNghiem"]);
                    data.CongThucMau = Common.ConDBNull(DataReader["CongThucMau"]);
                    data.SinhHoaMau = Common.ConDBNull(DataReader["SinhHoaMau"]);
                    data.KetQuaChup = Common.ConDBNull(DataReader["KetQuaChup"]);
                    data.KetQuaDo = Common.ConDBNull(DataReader["KetQuaDo"]);
                    data.KetQuaNoiSoi = Common.ConDBNull(DataReader["KetQuaNoiSoi"]);
                    data.KetQuaDienTim = Common.ConDBNull(DataReader["KetQuaDienTim"]);
                    data.KetQuaSieuAm = Common.ConDBNull(DataReader["KetQuaSieuAm"]);
                    data.KetQuaXetNghiem = Common.ConDBNull(DataReader["KetQuaXetNghiem"]);
                    data.PhuongPhapDieuTri = Common.ConDBNull(DataReader["PhuongPhapDieuTri"]);
                    data.TinhTrangRaVien = Common.ConDBNull(DataReader["TinhTrangRaVien"]);
                    data.GhiChu = Common.ConDBNull(DataReader["GhiChu"]);
                    data.ThoiGian = Common.ConDB_DateTime(DataReader["ThoiGian"]);
                    data.MaNguoiSao = Common.ConDBNull(DataReader["MaNguoiSao"]);
                    data.NguoiSao = Common.ConDBNull(DataReader["NguoiSao"]);
                    data.MaThuTruong = Common.ConDBNull(DataReader["MaThuTruong"]);
                    data.ThuTruong = Common.ConDBNull(DataReader["ThuTruong"]);
                    data.NgayTao = Common.ConDB_DateTime(DataReader["NgayTao"]);
                    data.NguoiTao = DataReader["NguoiTao"].ToString();
                    data.NgaySua = Common.ConDB_DateTime(DataReader["NgaySua"]);
                    data.NguoiSua = DataReader["NguoiSua"].ToString();

                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy);
                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuTomTatBenhAn data)
        {
            try
            {
                string sql = @"INSERT INTO PhieuTomTatBenhAn
                (
                    MaQuanLy,
                    MaBenhNhan,
                    HoTenBenhNhan,
                    NamSinh,
                    GioiTinh,
                    DanToc,
                    MSBHYT,
                    NgheNghiep,
                    DonVi,
                    DiaChi,
                    NgayVaoVien,
                    NgayRaVien,
                    ChanDoanVaoVien,
                    ChanDoanRaVien,
                    TomTatBenhAn,
                    KhamTim,
                    KhamPhoi,
                    XetNghiem,
                    CongThucMau,
                    SinhHoaMau,
                    KetQuaChup,
                    KetQuaDo,
                    KetQuaNoiSoi,
                    KetQuaDienTim,
                    KetQuaSieuAm,
                    KetQuaXetNghiem,
                    PhuongPhapDieuTri,
                    TinhTrangRaVien,
                    GhiChu,
                    ThoiGian,
                    MaNguoiSao,
                    NguoiSao,
                    MaThuTruong,
                    ThuTruong,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
                    :MaQuanLy,
                    :MaBenhNhan,
                    :HoTenBenhNhan,
                    :NamSinh,
                    :GioiTinh,
                    :DanToc,
                    :MSBHYT,
                    :NgheNghiep,
                    :DonVi,
                    :DiaChi,
                    :NgayVaoVien,
                    :NgayRaVien,
                    :ChanDoanVaoVien,
                    :ChanDoanRaVien,
                    :TomTatBenhAn,
                    :KhamTim,
                    :KhamPhoi,
                    :XetNghiem,
                    :CongThucMau,
                    :SinhHoaMau,
                    :KetQuaChup,
                    :KetQuaDo,
                    :KetQuaNoiSoi,
                    :KetQuaDienTim,
                    :KetQuaSieuAm,
                    :KetQuaXetNghiem,
                    :PhuongPhapDieuTri,
                    :TinhTrangRaVien,
                    :GhiChu,
                    :ThoiGian,
                    :MaNguoiSao,
                    :NguoiSao,
                    :MaThuTruong,
                    :ThuTruong,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (data.ID != 0)
                {
                    sql = @"UPDATE PhieuTomTatBenhAn SET 
                   MaQuanLy = :MaQuanLy,
                    MaBenhNhan = :MaBenhNhan,
                    HoTenBenhNhan = :HoTenBenhNhan,
                    NamSinh = :NamSinh,
                    GioiTinh = :GioiTinh,
                    DanToc = :DanToc,
                    MSBHYT = :MSBHYT,
                    NgheNghiep = :NgheNghiep,
                    DonVi = :DonVi,
                    DiaChi = :DiaChi,
                    NgayVaoVien = :NgayVaoVien,
                    NgayRaVien = :NgayRaVien,
                    ChanDoanVaoVien = :ChanDoanVaoVien,
                    ChanDoanRaVien = :ChanDoanRaVien,
                    TomTatBenhAn = :TomTatBenhAn,
                    KhamTim = :KhamTim,
                    KhamPhoi = :KhamPhoi,
                    XetNghiem = :XetNghiem,
                    CongThucMau = :CongThucMau,
                    SinhHoaMau = :SinhHoaMau,
                    KetQuaChup = :KetQuaChup,
                    KetQuaDo = :KetQuaDo,
                    KetQuaNoiSoi = :KetQuaNoiSoi,
                    KetQuaDienTim = :KetQuaDienTim,
                    KetQuaSieuAm = :KetQuaSieuAm,
                    KetQuaXetNghiem = :KetQuaXetNghiem,
                    PhuongPhapDieuTri = :PhuongPhapDieuTri,
                    TinhTrangRaVien = :TinhTrangRaVien,
                    GhiChu = :GhiChu,
                    ThoiGian = :ThoiGian,
                    MaNguoiSao = :MaNguoiSao,
                    NguoiSao = :NguoiSao,
                    MaThuTruong = :MaThuTruong,
                    ThuTruong = :ThuTruong,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + data.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", data.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", data.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("HoTenBenhNhan", data.HoTenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("NamSinh", data.NamSinh));
                Command.Parameters.Add(new MDB.MDBParameter("GioiTinh", data.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("DanToc", data.DanToc));
                Command.Parameters.Add(new MDB.MDBParameter("MSBHYT", data.MSBHYT));
                Command.Parameters.Add(new MDB.MDBParameter("NgheNghiep", data.NgheNghiep));
                Command.Parameters.Add(new MDB.MDBParameter("DonVi", data.DonVi));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", data.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("NgayVaoVien", data.NgayVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("NgayRaVien", data.NgayRaVien));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanVaoVien", data.ChanDoanVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanRaVien", data.ChanDoanRaVien));
                Command.Parameters.Add(new MDB.MDBParameter("TomTatBenhAn", data.TomTatBenhAn));
                Command.Parameters.Add(new MDB.MDBParameter("KhamTim", data.KhamTim));
                Command.Parameters.Add(new MDB.MDBParameter("KhamPhoi", data.KhamPhoi));
                Command.Parameters.Add(new MDB.MDBParameter("XetNghiem", data.XetNghiem));
                Command.Parameters.Add(new MDB.MDBParameter("CongThucMau", data.CongThucMau));
                Command.Parameters.Add(new MDB.MDBParameter("SinhHoaMau", data.SinhHoaMau));
                Command.Parameters.Add(new MDB.MDBParameter("KetQuaChup", data.KetQuaChup));
                Command.Parameters.Add(new MDB.MDBParameter("KetQuaDo", data.KetQuaDo));
                Command.Parameters.Add(new MDB.MDBParameter("KetQuaNoiSoi", data.KetQuaNoiSoi));
                Command.Parameters.Add(new MDB.MDBParameter("KetQuaDienTim", data.KetQuaDienTim));
                Command.Parameters.Add(new MDB.MDBParameter("KetQuaSieuAm", data.KetQuaSieuAm));
                Command.Parameters.Add(new MDB.MDBParameter("KetQuaXetNghiem", data.KetQuaXetNghiem));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapDieuTri", data.PhuongPhapDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangRaVien", data.TinhTrangRaVien));
                Command.Parameters.Add(new MDB.MDBParameter("GhiChu", data.GhiChu));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGian", data.ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiSao", data.MaNguoiSao));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiSao", data.NguoiSao));
                Command.Parameters.Add(new MDB.MDBParameter("MaThuTruong", data.MaThuTruong));
                Command.Parameters.Add(new MDB.MDBParameter("ThuTruong", data.ThuTruong));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", data.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", data.NgaySua));
                if (data.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", data.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", data.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", data.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (data.ID == 0)
                {
                    data.ID = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                }
                return n > 0;
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
                string sql = "DELETE FROM PhieuTomTatBenhAn WHERE ID = :ID";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                command.Parameters.Add(new MDB.MDBParameter("ID", id));
                command.BindByName = true;
                int n = command.ExecuteNonQuery();
                return n > 0;
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
                P.*,
                H.GIOITINH,
	            H.TENBENHNHAN,
                H.TUOI,
                H.SOYTE,
                H.BENHVIEN,
                (H.SONHA || ',' || H.THONPHO || ',' ||  H.XAPHUONG || ',' ||  H.HUYENQUAN || ',' ||  H.TINHTHANHPHO) AS DIACHI 
            FROM
                PhieuTomTatBenhAn P
                LEFT JOIN THONGTINDIEUTRI T ON P.MAQUANLY = T.MAQUANLY
                LEFT JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            adt.Fill(ds, "Table");
            return ds;
        }
    }
}
