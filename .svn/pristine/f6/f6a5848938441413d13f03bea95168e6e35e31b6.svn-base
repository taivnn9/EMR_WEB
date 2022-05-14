using EMR.KyDienTu;
using Newtonsoft.Json;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;

namespace EMR_MAIN.DATABASE.Other
{
    public class GiayChuyenVienBTCM :ThongTinKy
    {
        public GiayChuyenVienBTCM()
        {
            TableName = "GiayChuyenVienBTCM";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.GCVBTCM;
            TenMauPhieu = DanhMucPhieu.GCVBTCM.Description();
        }
        public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau", "", 1)]
        public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
        public string MaBenhNhan { get; set; }
        // bắt buộc
        // nội dung
        [MoTaDuLieu("Họ và tên bệnh nhân")]
        public string HoTenBN { get; set; }
        [MoTaDuLieu("Sổ lưu trữ")]
        public string SoLuuTru { get; set; }
        [MoTaDuLieu("Kính gửi")]
        public string KinhGui { get; set; }
        [MoTaDuLieu("Tuổi")]
        public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính")]
        public string  GioiTinh { get; set; }
        [MoTaDuLieu("Dân tộc")]
        public string DanToc { get; set; }
        [MoTaDuLieu("Ngoại kiều")]
        public string NgoaiKieu { get; set; }
        [MoTaDuLieu("Nghề nghiệp")]
        public string NgheNghiep { get; set; }
        [MoTaDuLieu("Nơi làm việc")]
        public string NoiLamViec { get; set; }
        [MoTaDuLieu("BHYT giá trị từ")]
        public string BatDauBHYT { get; set; }
        [MoTaDuLieu("kết thúc bảo hyt")]
        public string KetThucBHYT { get; set; }
        [MoTaDuLieu("địa chỉ")]
        public string DiaChi { get; set; }
        // thêm
        [MoTaDuLieu("Số thẻ")]
        public string SoThe { get; set; }

        [MoTaDuLieu("đã điều trị tại")]
        public string DaDieuTriTai { get; set; }
        [MoTaDuLieu("NgayBDDieuTri")]
        public DateTime? NgayBDDieuTri { get; set; }
        [MoTaDuLieu("NgayKTDieuTri")]
        public DateTime? NgayKTDieuTri { get; set; }
        [MoTaDuLieu("dấu hiệu lâm sàn")]
        public string DauHieuLamSan { get; set; }
        [MoTaDuLieu("Tình trạng lúc nhập viện")]
        public string TTLucNhapVien { get; set; }
        [MoTaDuLieu("Tri giác LNV")]
        public string TriGiacLNV { get; set; }
        [MoTaDuLieu("Mạch lúc nhập viện")]
        public string MachLNV { get; set; }
        [MoTaDuLieu("Huyết áp cmHg ")]
        public string HuyetApLNV { get; set; }
        [MoTaDuLieu("Nhịp thở ")]
        public string NhipThoLNV { get; set; }
        [MoTaDuLieu("SPO2 LNV ")]
        public string SPO2LNV { get; set; }
        [MoTaDuLieu("các xét nghiệm ")]
        public string CacXN { get; set; }

        [MoTaDuLieu("Chẩn đoán")]
        public string ChanDoan { get; set; }
        // thêm
        [MoTaDuLieu("Chẩn đoán nhiệt độ")]
        public string ChanDoanND { get; set; }
        [MoTaDuLieu("Chẩn đoán ngày")]
        public DateTime? ChanDoanNgay { get; set; }

        [MoTaDuLieu("Thuốc đã dùng trước khi chueyenr viện ml")]
        public string DTDGml { get; set; }
        [MoTaDuLieu("DTDG giờ")]
        public string DTDGGio { get; set; }
        [MoTaDuLieu("DTDGmlkg")]
        public string DTDGmlkg { get; set; }
        [MoTaDuLieu("Cao phân tử")]
        public string CaoPhanTuml { get; set; }
        [MoTaDuLieu("Cao phân tử giờ")]
        public string CaoPhanTuGio { get; set; }
        [MoTaDuLieu("Cao phân tử ml/kg")]
        public string CaoPhanTumlkg { get; set; }
        [MoTaDuLieu("Hỗ trợ hô hấp")]
        public string HoTroHoHap { get; set; }
        [MoTaDuLieu("Vận mạch DobutamineTu")]
        // dobutamine
        public string DobutamineTu { get; set; }
        [MoTaDuLieu("Dobutamine đến")]
        public string DobutamineDen { get; set; }
        [MoTaDuLieu("Dobutamine giờ")]
        public string DobutamineGio { get; set; }
        [MoTaDuLieu("Dobutamine ngày")]
        public DateTime? DobutamineNgay { get; set; }

        // Adrenaline
        public string AdrenalineTu { get; set; }
        [MoTaDuLieu("Dobutamine đến")]
        public string AdrenalineDen { get; set; }
        [MoTaDuLieu("Dobutamine giờ")]
        public string AdrenalineGio { get; set; }
        [MoTaDuLieu("Dobutamine ngày")]
        public DateTime? AdrenalineNgay { get; set; }

        // Milrinone
        public string MilrinoneTu { get; set; }
        [MoTaDuLieu("Dobutamine đến")]
        public string MilrinoneDen { get; set; }
        [MoTaDuLieu("Dobutamine giờ")]
        public string MilrinoneGio { get; set; }
        [MoTaDuLieu("Dobutamine ngày")]
        public DateTime? MilrinoneNgay { get; set; }

        // IVIG 1
        [MoTaDuLieu("IVIG1 giờ")]
        public string IVIG1Gio { get; set; }
        [MoTaDuLieu("IVIG1 ngày")]
        public DateTime? IVIG1Ngay { get; set; }

        // IVIG 2
        [MoTaDuLieu("IVIG2 giờ")]
        public string IVIG2Gio { get; set; }
        [MoTaDuLieu("IVIG2 ngày")]
        public string IVIG2Ngay { get; set; }

        //  phenobarbital TTM
        [MoTaDuLieu("TTM giờ")]
        public string TTMGio { get; set; }
        [MoTaDuLieu("TTM phút")]
        public string TTMPhut { get; set; }
        [MoTaDuLieu("TTM ngày")]
        public DateTime? TTMNgay { get; set; }

        [MoTaDuLieu("tổng liều TTM 24 g")]
        public string TTMTong { get; set; }
        // tình trạng ngay trước cv
        [MoTaDuLieu("Thuốc khác")]
        public string ThuocKhac { get; set; }
        [MoTaDuLieu("Mạch lúc trước CV")]
        public string MachTCV { get; set; }
        [MoTaDuLieu("Huyết áp cmHg ")]
        public string HuyetApcmHgTCV { get; set; }
        [MoTaDuLieu("Nhịp thở TCV")]
        public string NhipThoTCV { get; set; }
        [MoTaDuLieu("SPO2 TCV  ")]
        public string SPO2TCV { get; set; }
        // trong cv
        [MoTaDuLieu("dịch trong chuyển viện")]
        public string DichTrongCV { get; set; }
        [MoTaDuLieu("dịch còn lại")]
        public string DichConLai { get; set; }
        [MoTaDuLieu("toc dịch trong cv")]
        public string TocDoDichTrongCV { get; set; }
        [MoTaDuLieu("Vận mạch")]
        public string VanMach { get; set; }
        [MoTaDuLieu("Lí do chuyển viện")]
        public string LiDoCV { get; set; }
        [MoTaDuLieu("số giáy chuyển viện của tuyến trước")]
        public string SoGiayCV { get; set; }
        
        [MoTaDuLieu("chuyển viện giờ")]
        public string CVGio { get; set; }

        [MoTaDuLieu("chuyển viện phút")]
        public string CVPhut { get; set; }
        [MoTaDuLieu("ngày chuyển viện")]
        public DateTime? CVNgay { get; set; }
        [MoTaDuLieu("Phuongw tienej vnaja chuyeenr")]
        public string PTVanChuyen { get; set; }
        [MoTaDuLieu("Hoj tene người đưa đi")]
        public string HoTenNDD { get; set; }
        [MoTaDuLieu("Ngày đưa đi")]
        public DateTime? NgayDuaDi { get; set; }
        public string HTBacSyDieuTri { get; set; }
        public string HTGiamDocBV { get; set; }

        // bắt buộc


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
    public class GiayChuyenVienBTCMFunc
    {
        public const string TableName = "GiayChuyenVienBTCM";
        public const string TablePrimaryKeyName = "ID";
        public static List<GiayChuyenVienBTCM> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<GiayChuyenVienBTCM> list = new List<GiayChuyenVienBTCM>();
            try
            {
                string sql = @"SELECT * FROM GiayChuyenVienBTCM where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    GiayChuyenVienBTCM data = new GiayChuyenVienBTCM();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.HoTenBN = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.SoLuuTru = DataReader["SoLuuTru"].ToString();
                    data.KinhGui = DataReader["KinhGui"].ToString();
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.DanToc = XemBenhAn._HanhChinhBenhNhan.DanToc;
                    data.NgoaiKieu = XemBenhAn._HanhChinhBenhNhan.NgoaiKieu;
                    data.NgheNghiep = XemBenhAn._HanhChinhBenhNhan.NgheNghiep;
                    data.NoiLamViec = XemBenhAn._HanhChinhBenhNhan.NoiLamViec;
                    data.BatDauBHYT = XemBenhAn._HanhChinhBenhNhan.NgayDangKyBHYT.ToString();// lưu ý ngày bdbhyt 
                    data.KetThucBHYT = XemBenhAn._HanhChinhBenhNhan.NgayHetHanBHYT.ToString();// lưu ý
                    data.DiaChi = DataReader["DiaChi"].ToString();
                    data.SoThe = XemBenhAn._HanhChinhBenhNhan.SoTheBHYT;
                  

                    // dũng viết
                    data.DaDieuTriTai = DataReader["DaDieuTriTai"].ToString();

                    data.NgayBDDieuTri = DataReader["NgayBDDieuTri"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayBDDieuTri"].ToString()) : null;
                    data.NgayKTDieuTri = DataReader["NgayKTDieuTri"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayKTDieuTri"].ToString()) : null;

                    data.DauHieuLamSan = DataReader["DauHieuLamSan"].ToString();
                    data.TTLucNhapVien = DataReader["TTLucNhapVien"].ToString();
                    data.TriGiacLNV = DataReader["TriGiacLNV"].ToString();
                    data.MachLNV = DataReader["MachLNV"].ToString();
                    data.HuyetApLNV = DataReader["HuyetApLNV"].ToString();
                    data.NhipThoLNV = DataReader["NhipThoLNV"].ToString();
                    data.SPO2LNV = DataReader["SPO2LNV"].ToString();
                    data.CacXN = DataReader["CacXN"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.ChanDoanND = DataReader["ChanDoanND"].ToString();
                    data.ChanDoanNgay = DataReader["ChanDoanNgay"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["ChanDoanNgay"].ToString()) : null;
                    data.DTDGGio = DataReader["DTDGGio"].ToString();
                    data.DTDGmlkg = DataReader["DTDGmlkg"].ToString();
                    data.CaoPhanTuml = DataReader["CaoPhanTuml"].ToString();
                    data.CaoPhanTuGio = DataReader["CaoPhanTuGio"].ToString();
                    data.CaoPhanTumlkg = DataReader["CaoPhanTumlkg"].ToString();
                    data.HoTroHoHap = DataReader["HoTroHoHap"].ToString();
                    data.DobutamineTu = DataReader["DobutamineTu"].ToString();
                    data.DobutamineDen = DataReader["DobutamineDen"].ToString();
                    data.DobutamineGio = DataReader["DobutamineGio"].ToString();

                   data.DobutamineNgay = DataReader["DobutamineNgay"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["DobutamineNgay"].ToString()) : null;

                    data.AdrenalineTu = DataReader["AdrenalineTu"].ToString();
                    data.AdrenalineDen = DataReader["AdrenalineDen"].ToString();
                    data.AdrenalineGio = DataReader["AdrenalineGio"].ToString();

                    data.AdrenalineNgay = DataReader["AdrenalineNgay"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["AdrenalineNgay"].ToString()) : null;

                    data.MilrinoneTu = DataReader["MilrinoneTu"].ToString();
                    data.MilrinoneDen = DataReader["MilrinoneDen"].ToString();
                    data.MilrinoneGio = DataReader["MilrinoneGio"].ToString();

                    data.MilrinoneNgay = DataReader["MilrinoneNgay"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["MilrinoneNgay"].ToString()) : null;

                    data.IVIG1Gio = DataReader["IVIG1Gio"].ToString();

                    data.IVIG1Ngay = DataReader["IVIG1Ngay"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["IVIG1Ngay"].ToString()) : null;

                    data.IVIG2Gio = DataReader["IVIG2Gio"].ToString();
                    data.IVIG2Ngay = DataReader["IVIG2Ngay"].ToString();
                    data.TTMGio = DataReader["TTMGio"].ToString();
                    data.TTMPhut = DataReader["TTMPhut"].ToString();

                    data.TTMNgay = DataReader["TTMNgay"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["TTMNgay"].ToString()) : null;

                    data.TTMTong = DataReader["TTMTong"].ToString();
                    data.ThuocKhac = DataReader["ThuocKhac"].ToString();
                    data.MachTCV = DataReader["MachTCV"].ToString();
                    data.HuyetApcmHgTCV = DataReader["HuyetApcmHgTCV"].ToString();
                    data.NhipThoTCV = DataReader["NhipThoTCV"].ToString();
                    data.DichTrongCV = DataReader["DichTrongCV"].ToString();
                    data.DichConLai = DataReader["DichConLai"].ToString();
                    data.TocDoDichTrongCV = DataReader["TocDoDichTrongCV"].ToString();
                    data.VanMach = DataReader["VanMach"].ToString();
                    data.LiDoCV = DataReader["LiDoCV"].ToString();
                    data.SoGiayCV = DataReader["SoGiayCV"].ToString();
                    data.CVGio = DataReader["CVGio"].ToString();
                    data.CVPhut = DataReader["CVPhut"].ToString();

                    data.CVNgay = DataReader["CVNgay"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["CVNgay"].ToString()) : null;

                    data.PTVanChuyen = DataReader["PTVanChuyen"].ToString();
                    data.HoTenNDD = DataReader["HoTenNDD"].ToString();

                    data.NgayDuaDi = DataReader["NgayDuaDi"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayDuaDi"].ToString()) : null;

                    data.HTBacSyDieuTri = DataReader["HTBacSyDieuTri"].ToString();
                    data.HTGiamDocBV = DataReader["HTGiamDocBV"].ToString();

                    // kết thúc



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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref GiayChuyenVienBTCM ketQua)
        {
            try
            {
                string sql = @"INSERT INTO GiayChuyenVienBTCM
                (
                    MAQUANLY,
                    MaBenhNhan,                                     
                    HoTenBN,
                    SoLuuTru,
                    KinhGui,
                    Tuoi,
                    GioiTinh,
                    DanToc,
                    NgoaiKieu,
                    NgheNghiep,
                    NoiLamViec,
                    BatDauBHYT,
                    KetThucBHYT,
                    DiaChi,
                    SoThe,
                    DaDieuTriTai,
                    NgayBDDieuTri,
                    NgayKTDieuTri,
                    DauHieuLamSan,
                    TTLucNhapVien,
                    TriGiacLNV,
                    MachLNV,
                    HuyetApLNV,
                    NhipThoLNV,
                    SPO2LNV,
                    CacXN,
                    ChanDoan,
                    ChanDoanND,
                    ChanDoanNgay,
                    DTDGml,
                    DTDGGio,
                    DTDGmlkg,
                    CaoPhanTuml,
                    CaoPhanTuGio,
                    CaoPhanTumlkg,
                    HoTroHoHap,
                    DobutamineTu,
                    DobutamineDen,
                    DobutamineGio,
                    DobutamineNgay,
                    AdrenalineTu,
                    AdrenalineDen,
                    AdrenalineGio,
                    AdrenalineNgay,
                    MilrinoneTu,
                    MilrinoneDen,
                    MilrinoneGio,
                    MilrinoneNgay,
                    IVIG1Gio,
                    IVIG1Ngay,
                    IVIG2Gio,
                    IVIG2Ngay,
                    TTMGio,
                    TTMPhut,
                    TTMNgay,
                    TTMTong,
                    ThuocKhac,
                    MachTCV,
                    HuyetApcmHgTCV,
                    NhipThoTCV,
                    SPO2TCV,
                    DichTrongCV,
                    DichConLai,
                    TocDoDichTrongCV,
                    VanMach,
                    LiDoCV,
                    SoGiayCV,
                    CVGio,
                    CVPhut,
                    CVNgay,
                    PTVanChuyen,
                    HoTenNDD,
                    NgayDuaDi,
                    HTBacSyDieuTri,
                    HTGiamDocBV,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :HoTenBN,
                    :SoLuuTru,
                    :KinhGui,
                    :Tuoi,
                    :GioiTinh,
                    :DanToc,
                    :NgoaiKieu,
                    :NgheNghiep,
                    :NoiLamViec,
                    :BatDauBHYT,
                    :KetThucBHYT,
                    :DiaChi,
                    :SoThe,
                    :DaDieuTriTai,
                    :NgayBDDieuTri,
                    :NgayKTDieuTri,
                    :DauHieuLamSan,
                    :TTLucNhapVien,
                    :TriGiacLNV,
                    :MachLNV,
                    :HuyetApLNV,
                    :NhipThoLNV,
                    :SPO2LNV,
                    :CacXN,
                    :ChanDoan,
                    :ChanDoanND,
                    :ChanDoanNgay,
                    :DTDGml,
                    :DTDGGio,
                    :DTDGmlkg,
                    :CaoPhanTuml,
                    :CaoPhanTuGio,
                    :CaoPhanTumlkg,
                    :HoTroHoHap,
                    :DobutamineTu,
                    :DobutamineDen,
                    :DobutamineGio,
                    :DobutamineNgay,
                    :AdrenalineTu,
                    :AdrenalineDen,
                    :AdrenalineGio,
                    :AdrenalineNgay,
                    :MilrinoneTu,
                    :MilrinoneDen,
                    :MilrinoneGio,
                    :MilrinoneNgay,
                    :IVIG1Gio,
                    :IVIG1Ngay,
                    :IVIG2Gio,
                    :IVIG2Ngay,
                    :TTMGio,
                    :TTMPhut,
                    :TTMNgay,
                    :TTMTong,
                    :ThuocKhac,
                    :MachTCV,
                    :HuyetApcmHgTCV,
                    :NhipThoTCV,
                    :SPO2TCV,
                    :DichTrongCV,
                    :DichConLai,
                    :TocDoDichTrongCV,
                    :VanMach,
                    :LiDoCV,
                    :SoGiayCV,
                    :CVGio,
                    :CVPhut,
                    :CVNgay,
                    :PTVanChuyen,
                    :HoTenNDD,
                    :NgayDuaDi,
                    :HTBacSyDieuTri,
                    :HTGiamDocBV,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE GiayChuyenVienBTCM SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                   
                    HoTenBN  = :HoTenBN,
                    SoLuuTru  = :SoLuuTru,
                    KinhGui  = :KinhGui,
                    Tuoi  = :Tuoi,
                    GioiTinh  = :GioiTinh,
                    DanToc  = :DanToc,
                    NgoaiKieu  = :NgoaiKieu,
                    NgheNghiep  = :NgheNghiep,
                    NoiLamViec  = :NoiLamViec,
                    BatDauBHYT  = :BatDauBHYT,
                    KetThucBHYT  = :KetThucBHYT,
                    DiaChi  = :DiaChi,
                    SoThe   = :SoThe,
                    DaDieuTriTai  = :DaDieuTriTai,
                    NgayBDDieuTri  = :NgayBDDieuTri,
                    NgayKTDieuTri  = :NgayKTDieuTri,
                    DauHieuLamSan  = :DauHieuLamSan,
                    TTLucNhapVien  = :TTLucNhapVien,
                    TriGiacLNV  = :TriGiacLNV,
                    MachLNV  = :MachLNV,
                    HuyetApLNV  = :HuyetApLNV,
                    NhipThoLNV  = :NhipThoLNV,
                    SPO2LNV  = :SPO2LNV,
                    CacXN  = :CacXN,
                    ChanDoan  = :ChanDoan,
                    ChanDoanND = :ChanDoanND,
                    ChanDoanNgay = :ChanDoanNgay,
                    DTDGml  = :DTDGml,
                    DTDGGio  = :DTDGGio,
                    DTDGmlkg  = :DTDGmlkg,
                    CaoPhanTuml  = :CaoPhanTuml,
                    CaoPhanTuGio  = :CaoPhanTuGio,
                    CaoPhanTumlkg  = :CaoPhanTumlkg,
                    HoTroHoHap  = :HoTroHoHap,
                    DobutamineTu  = :DobutamineTu,
                    DobutamineDen  = :DobutamineDen,
                    DobutamineGio  = :DobutamineGio,
                    DobutamineNgay  = :DobutamineNgay,
                    AdrenalineTu  = :AdrenalineTu,
                    AdrenalineDen  = :AdrenalineDen,
                    AdrenalineGio  = :AdrenalineGio,
                    AdrenalineNgay  = :AdrenalineNgay,
                    MilrinoneTu  = :MilrinoneTu,
                    MilrinoneDen  = :MilrinoneDen,
                    MilrinoneGio  = :MilrinoneGio,
                    MilrinoneNgay  = :MilrinoneNgay,
                    IVIG1Gio  = :IVIG1Gio,
                    IVIG1Ngay  = :IVIG1Ngay,
                    IVIG2Gio  = :IVIG2Gio,
                    IVIG2Ngay  = :IVIG2Ngay,
                    TTMGio  = :TTMGio,
                    TTMPhut  = :TTMPhut,
                    TTMNgay  = :TTMNgay,
                    TTMTong  = :TTMTong,
                    ThuocKhac = :ThuocKhac,
                    MachTCV  = :MachTCV,
                    HuyetApcmHgTCV  = :HuyetApcmHgTCV,
                    NhipThoTCV  = :NhipThoTCV,
                    SPO2TCV  = :SPO2TCV,
                    DichTrongCV  = :DichTrongCV,
                    DichConLai  = :DichConLai,
                    TocDoDichTrongCV  = :TocDoDichTrongCV,
                    VanMach  = :VanMach,
                    LiDoCV  = :LiDoCV,
                    SoGiayCV  = :SoGiayCV,
                    CVGio  = :CVGio,
                    CVPhut  = :CVPhut,
                    CVNgay  = :CVNgay,
                    PTVanChuyen  = :PTVanChuyen,
                    HoTenNDD  = :HoTenNDD,
                    NgayDuaDi  = :NgayDuaDi,
                    HTBacSyDieuTri  = :HTBacSyDieuTri,
                    HTGiamDocBV  = :HTGiamDocBV,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ketQua.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("HoTenBN", ketQua.HoTenBN));
                Command.Parameters.Add(new MDB.MDBParameter("SoLuuTru", ketQua.SoLuuTru));
                Command.Parameters.Add(new MDB.MDBParameter("KinhGui", ketQua.KinhGui));
                Command.Parameters.Add(new MDB.MDBParameter("Tuoi", ketQua.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("GioiTinh", ketQua.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("DanToc", ketQua.DanToc));
                Command.Parameters.Add(new MDB.MDBParameter("NgoaiKieu", ketQua.NgoaiKieu));
                Command.Parameters.Add(new MDB.MDBParameter("NgheNghiep", ketQua.NgoaiKieu));

                Command.Parameters.Add(new MDB.MDBParameter("NoiLamViec", ketQua.NoiLamViec));
                Command.Parameters.Add(new MDB.MDBParameter("BatDauBHYT", ketQua.BatDauBHYT));
                Command.Parameters.Add(new MDB.MDBParameter("KetThucBHYT", ketQua.KetThucBHYT));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", ketQua.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("SoThe", ketQua.SoThe));

                Command.Parameters.Add(new MDB.MDBParameter("DaDieuTriTai", ketQua.DaDieuTriTai));
                Command.Parameters.Add(new MDB.MDBParameter("NgayBDDieuTri", ketQua.NgayBDDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("NgayKTDieuTri", ketQua.NgayKTDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("DauHieuLamSan", ketQua.DauHieuLamSan));
                Command.Parameters.Add(new MDB.MDBParameter("TTLucNhapVien", ketQua.TTLucNhapVien));
                Command.Parameters.Add(new MDB.MDBParameter("TriGiacLNV", ketQua.TriGiacLNV));
                Command.Parameters.Add(new MDB.MDBParameter("MachLNV", ketQua.MachLNV));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetApLNV", ketQua.HuyetApLNV));
                Command.Parameters.Add(new MDB.MDBParameter("NhipThoLNV", ketQua.NhipThoLNV));
                Command.Parameters.Add(new MDB.MDBParameter("SPO2LNV", ketQua.SPO2LNV));
                Command.Parameters.Add(new MDB.MDBParameter("CacXN", ketQua.CacXN));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", ketQua.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanNgay", ketQua.ChanDoanNgay));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanND", ketQua.ChanDoanND));

                Command.Parameters.Add(new MDB.MDBParameter("DTDGml", ketQua.DTDGml));
                Command.Parameters.Add(new MDB.MDBParameter("DTDGGio", ketQua.DTDGGio));
                Command.Parameters.Add(new MDB.MDBParameter("DTDGmlkg", ketQua.DTDGmlkg));
                Command.Parameters.Add(new MDB.MDBParameter("CaoPhanTuml", ketQua.CaoPhanTuml));
                Command.Parameters.Add(new MDB.MDBParameter("CaoPhanTuGio", ketQua.CaoPhanTuGio));
                Command.Parameters.Add(new MDB.MDBParameter("CaoPhanTumlkg", ketQua.CaoPhanTumlkg));
                Command.Parameters.Add(new MDB.MDBParameter("HoTroHoHap", ketQua.HoTroHoHap));
                Command.Parameters.Add(new MDB.MDBParameter("DobutamineTu", ketQua.DobutamineTu));
                Command.Parameters.Add(new MDB.MDBParameter("DobutamineDen", ketQua.DobutamineDen));
                Command.Parameters.Add(new MDB.MDBParameter("DobutamineGio", ketQua.DobutamineGio));
                Command.Parameters.Add(new MDB.MDBParameter("DobutamineNgay", ketQua.DobutamineNgay));
                Command.Parameters.Add(new MDB.MDBParameter("AdrenalineTu", ketQua.AdrenalineTu));
                Command.Parameters.Add(new MDB.MDBParameter("AdrenalineDen", ketQua.AdrenalineDen));
                Command.Parameters.Add(new MDB.MDBParameter("AdrenalineGio", ketQua.AdrenalineGio));
                Command.Parameters.Add(new MDB.MDBParameter("AdrenalineNgay", ketQua.AdrenalineNgay));
                Command.Parameters.Add(new MDB.MDBParameter("MilrinoneTu", ketQua.MilrinoneTu));
                Command.Parameters.Add(new MDB.MDBParameter("MilrinoneDen", ketQua.MilrinoneDen));
                Command.Parameters.Add(new MDB.MDBParameter("MilrinoneGio", ketQua.MilrinoneGio));
                Command.Parameters.Add(new MDB.MDBParameter("MilrinoneNgay", ketQua.MilrinoneNgay));
                Command.Parameters.Add(new MDB.MDBParameter("IVIG1Gio", ketQua.IVIG1Gio));
                Command.Parameters.Add(new MDB.MDBParameter("IVIG1Ngay", ketQua.IVIG1Ngay));
                Command.Parameters.Add(new MDB.MDBParameter("IVIG2Gio", ketQua.IVIG2Gio));
                Command.Parameters.Add(new MDB.MDBParameter("IVIG2Ngay", ketQua.IVIG2Ngay));
                Command.Parameters.Add(new MDB.MDBParameter("TTMGio", ketQua.TTMGio));
                Command.Parameters.Add(new MDB.MDBParameter("TTMPhut", ketQua.TTMPhut));
                Command.Parameters.Add(new MDB.MDBParameter("TTMNgay", ketQua.TTMNgay));
                Command.Parameters.Add(new MDB.MDBParameter("TTMTong", ketQua.TTMTong));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocKhac", ketQua.ThuocKhac));
                Command.Parameters.Add(new MDB.MDBParameter("MachTCV", ketQua.MachTCV));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetApcmHgTCV", ketQua.HuyetApcmHgTCV));
                Command.Parameters.Add(new MDB.MDBParameter("NhipThoTCV", ketQua.NhipThoTCV));
                Command.Parameters.Add(new MDB.MDBParameter("SPO2TCV", ketQua.SPO2TCV));
                Command.Parameters.Add(new MDB.MDBParameter("DichTrongCV", ketQua.DichTrongCV));
                Command.Parameters.Add(new MDB.MDBParameter("DichConLai", ketQua.DichConLai));
                Command.Parameters.Add(new MDB.MDBParameter("TocDoDichTrongCV", ketQua.TocDoDichTrongCV));
                Command.Parameters.Add(new MDB.MDBParameter("VanMach", ketQua.VanMach));
                Command.Parameters.Add(new MDB.MDBParameter("LiDoCV", ketQua.LiDoCV));
                Command.Parameters.Add(new MDB.MDBParameter("SoGiayCV", ketQua.SoGiayCV));
                Command.Parameters.Add(new MDB.MDBParameter("CVGio", ketQua.CVGio));
                Command.Parameters.Add(new MDB.MDBParameter("CVPhut", ketQua.CVPhut));
                Command.Parameters.Add(new MDB.MDBParameter("CVNgay", ketQua.CVNgay));
                Command.Parameters.Add(new MDB.MDBParameter("PTVanChuyen", ketQua.PTVanChuyen));
                Command.Parameters.Add(new MDB.MDBParameter("HoTenNDD", ketQua.HoTenNDD));
                Command.Parameters.Add(new MDB.MDBParameter("NgayDuaDi", ketQua.NgayDuaDi));
                Command.Parameters.Add(new MDB.MDBParameter("HTBacSyDieuTri", ketQua.HTBacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("HTGiamDocBV", ketQua.HTGiamDocBV));
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
        public static bool delete(MDB.MDBConnection MyConnection, long id)
        {
            try
            {
                string sql = "DELETE FROM GiayChuyenVienBTCM WHERE ID = :ID";
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
                MAQUANLY,
                MaBenhNhan, 
                HoTenBN,
                SoLuuTru,
                KinhGui,
                Tuoi,
                GioiTinh,
                DanToc,
                NgoaiKieu,
                NgheNghiep,
                NoiLamViec,
                BatDauBHYT,
                KetThucBHYT,
                DiaChi,
                SoThe,
                DaDieuTriTai,
                NgayBDDieuTri,
                NgayKTDieuTri,
                DauHieuLamSan,
                TTLucNhapVien,
                TriGiacLNV,
                MachLNV,
                HuyetApLNV,
                NhipThoLNV,
                SPO2LNV,
                CacXN,
                ChanDoan,
                ChanDoanND,
                ChanDoanNgay,
                DTDGml,
                DTDGGio,
                DTDGmlkg,
                CaoPhanTuml,
                CaoPhanTuGio,
                CaoPhanTumlkg,
                HoTroHoHap,
                DobutamineTu,
                DobutamineDen,
                DobutamineGio,
                DobutamineNgay,
                AdrenalineTu,
                AdrenalineDen,
                AdrenalineGio,
                AdrenalineNgay,
                MilrinoneTu,
                MilrinoneDen,
                MilrinoneGio,
                MilrinoneNgay,
                IVIG1Gio,
                IVIG1Ngay,
                IVIG2Gio,
                IVIG2Ngay,
                TTMGio,
                TTMPhut,
                TTMNgay ,
                TTMTong,
                ThuocKhac,
                MachTCV,
                HuyetApcmHgTCV,
                NhipThoTCV,
                SPO2TCV,
                DichTrongCV,
                DichConLai,
                TocDoDichTrongCV,
                VanMach,
                LiDoCV,
                SoGiayCV,
                CVGio,
                CVPhut,
                CVNgay ,
                PTVanChuyen,
                HoTenNDD,
                NgayDuaDi ,
                HTBacSyDieuTri,
                HTGiamDocBV,
                NGUOITAO,
                NGUOISUA,
                NGAYTAO,
                NGAYSUA

            FROM
                GiayChuyenVienBTCM P
            
            WHERE
                P.ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "KQ");

            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));
            ds.Tables[0].AddColumn("NamSinh", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(int));
            ds.Tables[0].AddColumn("SOYTE", typeof(string));
            ds.Tables[0].AddColumn("BENHVIEN", typeof(string));
            ds.Tables[0].AddColumn("KHOA", typeof(string));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["NamSinh"] = XemBenhAn._HanhChinhBenhNhan.NgaySinh.HasValue ? XemBenhAn._HanhChinhBenhNhan.NgaySinh.Value.Year + "" : "";
            ds.Tables[0].Rows[0]["GioiTinh"] = (int)XemBenhAn._HanhChinhBenhNhan.GioiTinh;
            ds.Tables[0].Rows[0]["SOYTE"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["KHOA"] = XemBenhAn._ThongTinDieuTri.Khoa;

            return ds;
        }


    }
}
