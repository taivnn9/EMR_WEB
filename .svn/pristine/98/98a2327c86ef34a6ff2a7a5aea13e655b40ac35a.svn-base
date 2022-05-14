using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class BangKiemSoatBNTruocMo : ThongTinKy
    {
        public BangKiemSoatBNTruocMo()
        {
            TableName = "BangKiemSoatBNTruocMo";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BKSBNTM;
            TenMauPhieu = DanhMucPhieu.BKSBNTM.Description();
        }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Sở y tế")]
        public string SoYTe
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.SoYTe;
            }
        }
        [MoTaDuLieu("Bệnh viện")]
        public string BenhVien
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.BenhVien;
            }
        }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.MaBenhNhan;
            }
        }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            }
        }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.Tuoi;
            }
        }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description().ToString();
            }
        }
       
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Thời gian")]
        public DateTime ThoiGian { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Sửa soạn vùng mổ")]
        public int SuaSoan { get; set; }
        [MoTaDuLieu("Ghi chú(Sửa soạn vùng mổ)")]
        public string SuaSoanGhiChu { get; set; }
        [MoTaDuLieu("Trưởng khoa kiểm soát vùng mổ")]
        public int TruongKhoaKS { get; set; }
        [MoTaDuLieu("Ghi chú(Trưởng khoa kiểm soát vùng mổ)")]
        public string TruongKhoaKSGhiChu { get; set; }
        [MoTaDuLieu("Vệ sinh(Tắm)")]
        public int VeSinh { get; set; }
        [MoTaDuLieu("Ghi chú(vệ sinh)")]
        public string VeSinhGhiChu { get; set; }
        [MoTaDuLieu("Cho bệnh nhân mặc áo mổ")]
        public int MacAoMo { get; set; }
        [MoTaDuLieu("Ghi chú(Cho bệnh nhân mặc áo mổ)")]
        public string MacAoMoGhiChu { get; set; }
        [MoTaDuLieu("Giữ lại nữ trang, son môi nếu có")]
        public int GiuNuTrang { get; set; }
        [MoTaDuLieu("Ghi chú(Giữ lại nữ trang)")]
        public string GiuNuTrangGhiChu { get; set; }
        [MoTaDuLieu("Tháo răng giả")]
        public int ThaoRangGia { get; set; }
        [MoTaDuLieu("Ghi chú(Tháo răng giả)")]
        public string ThaoRangGiaGhiChu { get; set; }
        [MoTaDuLieu("Bím tóc")]
        public int BimToc { get; set; }
        [MoTaDuLieu("Ghi chú(bím tóc)")]
        public string BimTocGhiChu { get; set; }
        [MoTaDuLieu("Đặt thông tiểu")]
        public int DatThongTieu { get; set; }
        [MoTaDuLieu("Ghi chú(đặt thông tiểu)")]
        public string DatThongTieuGhiChu { get; set; }
        [MoTaDuLieu("Thụt đại tràng")]
        public int ThutDaitTrang { get; set; }
        [MoTaDuLieu("Ghi chú(thụt đại tràng)")]
        public string ThutDaitTrangGhiChu { get; set; }
        [MoTaDuLieu("Rửa dạ dày")]
        public int RuaDaDay { get; set; }
        [MoTaDuLieu("Ghi chú(rửa dạ dày)")]
        public string RuaDaDayGhiChu { get; set; }
        [MoTaDuLieu("Đeo vòng tên bệnh nhân")]
        public int DeoVongTen  {get; set; }
        [MoTaDuLieu("Ghi chú(đeo vòng tên)")]
        public string DeoVongTenGhiChu { get; set; }
        [MoTaDuLieu("Nhịn ăn uống")]
        public int NhinAn { get; set; }
        [MoTaDuLieu("Ghi chú(nhịn ăn uống)")]
        public string NhinAnGhiChu { get; set; }
        [MoTaDuLieu("Ký cam kết")]
        public int KyCamKet { get; set; }
        [MoTaDuLieu("Ghi chú(ký cam kết)")]
        public string KyCamKetGhiChu { get; set; }
        [MoTaDuLieu("X-Quang")]
        public int XQuang { get; set; }
        [MoTaDuLieu("Ghi chú(x-quang)")]
        public string XQuangGhiChu { get; set; }
        [MoTaDuLieu("Kháng sinh dự phòng")]
        public int KhangSinh { get; set; }
        [MoTaDuLieu("Ghi chú(kháng sinh dự phòng)")]
        public string KhangSinhGhiChu { get; set; } 
        [MoTaDuLieu("Mạch")]
		public string Mach { get; set; }
        [MoTaDuLieu("Nhiệt độ")]
		public string NhietDo { get; set; }
        [MoTaDuLieu("Huyết áp cao nhất")]
        public string HuyetApMax { get; set; }
        [MoTaDuLieu("Huyết áp thấp nhất")]
        public string HuyetApMin { get; set; }
        [MoTaDuLieu("Nhịp thở")]
		public string NhipTho { get; set; }
        [MoTaDuLieu("Ý kiến")]
        public string YKien { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng phẫu thuật")]
		public string DieuDuongPT { get; set; }
        [MoTaDuLieu("Mã điều dưỡng phẫu thuật")]
		public string MaDieuDuongPT { get; set; }
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

    }
    public class BangKiemSoatBNTruocMoFunc
    {
        public const string TableName = "BangKiemSoatBNTruocMo";
        public const string TablePrimaryKeyName = "ID";
        public static BangKiemSoatBNTruocMo GetListData_Phieu(MDB.MDBConnection _OracleConnection, long ID)
        {
            BangKiemSoatBNTruocMo data = new BangKiemSoatBNTruocMo();
            try
            {
                string sql = @"SELECT * FROM BangKiemSoatBNTruocMo where ID = :ID";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID", ID));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = Common.ConDB_Decimal(DataReader["MaQuanLy"]);
                    data.ThoiGian = Common.ConDB_DateTime(DataReader["ThoiGian"]);
                    data.ChanDoan = Common.ConDBNull(DataReader["ChanDoan"]);
                    data.Khoa = Common.ConDBNull(DataReader["Khoa"]);
                    data.MaKhoa = Common.ConDBNull(DataReader["MaKhoa"]);
                    data.SuaSoan = Common.ConDB_Int(DataReader["SuaSoan"]);
                    data.SuaSoanGhiChu = Common.ConDBNull(DataReader["SuaSoanGhiChu"]);
                    data.TruongKhoaKS = Common.ConDB_Int(DataReader["TruongKhoaKS"]);
                    data.TruongKhoaKSGhiChu = Common.ConDBNull(DataReader["TruongKhoaKSGhiChu"]);
                    data.VeSinh = Common.ConDB_Int(DataReader["VeSinh"]);
                    data.VeSinhGhiChu = Common.ConDBNull(DataReader["VeSinhGhiChu"]);
                    data.MacAoMo = Common.ConDB_Int(DataReader["MacAoMo"]);
                    data.MacAoMoGhiChu = Common.ConDBNull(DataReader["MacAoMoGhiChu"]);
                    data.GiuNuTrang = Common.ConDB_Int(DataReader["GiuNuTrang"]);
                    data.GiuNuTrangGhiChu = Common.ConDBNull(DataReader["GiuNuTrangGhiChu"]);
                    data.ThaoRangGia = Common.ConDB_Int(DataReader["ThaoRangGia"]);
                    data.ThaoRangGiaGhiChu = Common.ConDBNull(DataReader["ThaoRangGiaGhiChu"]);
                    data.BimToc = Common.ConDB_Int(DataReader["BimToc"]);
                    data.BimTocGhiChu = Common.ConDBNull(DataReader["BimTocGhiChu"]);
                    data.DatThongTieu = Common.ConDB_Int(DataReader["DatThongTieu"]);
                    data.DatThongTieuGhiChu = Common.ConDBNull(DataReader["DatThongTieuGhiChu"]);
                    data.ThutDaitTrang = Common.ConDB_Int(DataReader["ThutDaitTrang"]);
                    data.ThutDaitTrangGhiChu = Common.ConDBNull(DataReader["ThutDaitTrangGhiChu"]);
                    data.RuaDaDay = Common.ConDB_Int(DataReader["RuaDaDay"]);
                    data.RuaDaDayGhiChu = Common.ConDBNull(DataReader["RuaDaDayGhiChu"]);
                    data.DeoVongTen = Common.ConDB_Int(DataReader["DeoVongTen"]);
                    data.DeoVongTenGhiChu = Common.ConDBNull(DataReader["DeoVongTenGhiChu"]);
                    data.NhinAn = Common.ConDB_Int(DataReader["NhinAn"]);
                    data.NhinAnGhiChu = Common.ConDBNull(DataReader["NhinAnGhiChu"]);
                    data.KyCamKet = Common.ConDB_Int(DataReader["KyCamKet"]);
                    data.KyCamKetGhiChu = Common.ConDBNull(DataReader["KyCamKetGhiChu"]);
                    data.XQuang = Common.ConDB_Int(DataReader["XQuang"]);
                    data.XQuangGhiChu = Common.ConDBNull(DataReader["XQuangGhiChu"]);
                    data.KhangSinh = Common.ConDB_Int(DataReader["KhangSinh"]);
                    data.KhangSinhGhiChu = Common.ConDBNull(DataReader["KhangSinhGhiChu"]);
                    data.Mach = Common.ConDBNull(DataReader["Mach"]);
                    data.NhietDo = Common.ConDBNull(DataReader["NhietDo"]);
                    data.HuyetApMax = Common.ConDBNull(DataReader["HuyetApMax"]);
                    data.HuyetApMin = Common.ConDBNull(DataReader["HuyetApMin"]);
                    data.NhipTho = Common.ConDBNull(DataReader["NhipTho"]);
                    data.YKien = Common.ConDBNull(DataReader["YKien"]);
                    data.DieuDuongPT = Common.ConDBNull(DataReader["DieuDuongPT"]);
                    data.MaDieuDuongPT = Common.ConDBNull(DataReader["MaDieuDuongPT"]);
                    data.NgayTao = Common.ConDB_DateTime(DataReader["NgayTao"]);
                    data.NguoiTao = Common.ConDBNull(DataReader["NguoiTao"]);
                    data.NgaySua = Common.ConDB_DateTime(DataReader["NgaySua"]);
                    data.NguoiSua = Common.ConDBNull(DataReader["NguoiSua"]);
                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return data;
        }
        public static List<BangKiemSoatBNTruocMo> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BangKiemSoatBNTruocMo> list = new List<BangKiemSoatBNTruocMo>();
            try
            {
                string sql = @"SELECT * FROM BangKiemSoatBNTruocMo where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    BangKiemSoatBNTruocMo data = new BangKiemSoatBNTruocMo(); 
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = Common.ConDB_Decimal(DataReader["MaQuanLy"]); 
                    data.ThoiGian = Common.ConDB_DateTime(DataReader["ThoiGian"]);
                    data.ChanDoan = Common.ConDBNull(DataReader["ChanDoan"]);
                    data.Khoa = Common.ConDBNull(DataReader["Khoa"]);
                    data.MaKhoa = Common.ConDBNull(DataReader["MaKhoa"]);
                    data.SuaSoan = Common.ConDB_Int(DataReader["SuaSoan"]);
                    data.SuaSoanGhiChu = Common.ConDBNull(DataReader["SuaSoanGhiChu"]);
                    data.TruongKhoaKS = Common.ConDB_Int(DataReader["TruongKhoaKS"]);
                    data.TruongKhoaKSGhiChu = Common.ConDBNull(DataReader["TruongKhoaKSGhiChu"]);
                    data.VeSinh = Common.ConDB_Int(DataReader["VeSinh"]);
                    data.VeSinhGhiChu = Common.ConDBNull(DataReader["VeSinhGhiChu"]);
                    data.MacAoMo = Common.ConDB_Int(DataReader["MacAoMo"]);
                    data.MacAoMoGhiChu = Common.ConDBNull(DataReader["MacAoMoGhiChu"]);
                    data.GiuNuTrang = Common.ConDB_Int(DataReader["GiuNuTrang"]);
                    data.GiuNuTrangGhiChu = Common.ConDBNull(DataReader["GiuNuTrangGhiChu"]);
                    data.ThaoRangGia = Common.ConDB_Int(DataReader["ThaoRangGia"]);
                    data.ThaoRangGiaGhiChu = Common.ConDBNull(DataReader["ThaoRangGiaGhiChu"]);
                    data.BimToc = Common.ConDB_Int(DataReader["BimToc"]);
                    data.BimTocGhiChu = Common.ConDBNull(DataReader["BimTocGhiChu"]);
                    data.DatThongTieu = Common.ConDB_Int(DataReader["DatThongTieu"]);
                    data.DatThongTieuGhiChu = Common.ConDBNull(DataReader["DatThongTieuGhiChu"]);
                    data.ThutDaitTrang = Common.ConDB_Int(DataReader["ThutDaitTrang"]);
                    data.ThutDaitTrangGhiChu = Common.ConDBNull(DataReader["ThutDaitTrangGhiChu"]);
                    data.RuaDaDay = Common.ConDB_Int(DataReader["RuaDaDay"]);
                    data.RuaDaDayGhiChu = Common.ConDBNull(DataReader["RuaDaDayGhiChu"]);
                    data.DeoVongTen = Common.ConDB_Int(DataReader["DeoVongTen"]);
                    data.DeoVongTenGhiChu = Common.ConDBNull(DataReader["DeoVongTenGhiChu"]);
                    data.NhinAn = Common.ConDB_Int(DataReader["NhinAn"]);
                    data.NhinAnGhiChu = Common.ConDBNull(DataReader["NhinAnGhiChu"]);
                    data.KyCamKet = Common.ConDB_Int(DataReader["KyCamKet"]);
                    data.KyCamKetGhiChu = Common.ConDBNull(DataReader["KyCamKetGhiChu"]);
                    data.XQuang = Common.ConDB_Int(DataReader["XQuang"]);
                    data.XQuangGhiChu = Common.ConDBNull(DataReader["XQuangGhiChu"]);
                    data.KhangSinh = Common.ConDB_Int(DataReader["KhangSinh"]);
                    data.KhangSinhGhiChu = Common.ConDBNull(DataReader["KhangSinhGhiChu"]);
                    data.Mach = Common.ConDBNull(DataReader["Mach"]);
                    data.NhietDo = Common.ConDBNull(DataReader["NhietDo"]);
                    data.HuyetApMax = Common.ConDBNull(DataReader["HuyetApMax"]);
                    data.HuyetApMin = Common.ConDBNull(DataReader["HuyetApMin"]);
                    data.NhipTho = Common.ConDBNull(DataReader["NhipTho"]);
                    data.YKien = Common.ConDBNull(DataReader["YKien"]);
                    data.DieuDuongPT = Common.ConDBNull(DataReader["DieuDuongPT"]);
                    data.MaDieuDuongPT = Common.ConDBNull(DataReader["MaDieuDuongPT"]);
                    data.NgayTao = Common.ConDB_DateTime(DataReader["NgayTao"]);
                    data.NguoiTao = Common.ConDBNull(DataReader["NguoiTao"]);
                    data.NgaySua = Common.ConDB_DateTime(DataReader["NgaySua"]);
                    data.NguoiSua = Common.ConDBNull(DataReader["NguoiSua"]);
                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy);
                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BangKiemSoatBNTruocMo data)
        {
            try
            {
                string sql = @"INSERT INTO BangKiemSoatBNTruocMo
                (
                    MaQuanLy, 
                    ThoiGian,
                    ChanDoan,
                    Khoa, MaKhoa,
                    SuaSoan,
                    SuaSoanGhiChu,
                    TruongKhoaKS,
                    TruongKhoaKSGhiChu,
                    VeSinh,
                    VeSinhGhiChu,
                    MacAoMo,
                    MacAoMoGhiChu,
                    GiuNuTrang,
                    GiuNuTrangGhiChu,
                    ThaoRangGia,
                    ThaoRangGiaGhiChu,
                    BimToc,
                    BimTocGhiChu,
                    DatThongTieu,
                    DatThongTieuGhiChu,
                    ThutDaitTrang,
                    ThutDaitTrangGhiChu,
                    RuaDaDay,
                    RuaDaDayGhiChu,
                    DeoVongTen,
                    DeoVongTenGhiChu,
                    NhinAn,
                    NhinAnGhiChu,
                    KyCamKet,
                    KyCamKetGhiChu,
                    XQuang,
                    XQuangGhiChu,
                    KhangSinh,
                    KhangSinhGhiChu,
                    Mach,
                    NhietDo,
                    HuyetApMax,
                    HuyetApMin,
                    NhipTho,
                    YKien,
                    DieuDuongPT,
                    MaDieuDuongPT,
                    NgayTao,
                    NguoiTao,
                    NgaySua,
                    NguoiSua
                    )  VALUES
                 (
                    :MaQuanLy, 
                    :ThoiGian,
                    :ChanDoan,
                    :Khoa, :MaKhoa,
                    :SuaSoan,
                    :SuaSoanGhiChu,
                    :TruongKhoaKS,
                    :TruongKhoaKSGhiChu,
                    :VeSinh,
                    :VeSinhGhiChu,
                    :MacAoMo,
                    :MacAoMoGhiChu,
                    :GiuNuTrang,
                    :GiuNuTrangGhiChu,
                    :ThaoRangGia,
                    :ThaoRangGiaGhiChu,
                    :BimToc,
                    :BimTocGhiChu,
                    :DatThongTieu,
                    :DatThongTieuGhiChu,
                    :ThutDaitTrang,
                    :ThutDaitTrangGhiChu,
                    :RuaDaDay,
                    :RuaDaDayGhiChu,
                    :DeoVongTen,
                    :DeoVongTenGhiChu,
                    :NhinAn,
                    :NhinAnGhiChu,
                    :KyCamKet,
                    :KyCamKetGhiChu,
                    :XQuang,
                    :XQuangGhiChu,
                    :KhangSinh,
                    :KhangSinhGhiChu,
                    :Mach,
                    :NhietDo,
                    :HuyetApMax,
                    :HuyetApMin,
                    :NhipTho,
                    :YKien,
                    :DieuDuongPT,
                    :MaDieuDuongPT,
                    :NgayTao,
                    :NguoiTao,
                    :NgaySua,
                    :NguoiSua
                 )  RETURNING ID INTO :ID";
                if (data.ID != 0)
                {
                    sql = @"UPDATE BangKiemSoatBNTruocMo SET 
                    MaQuanLy=:MaQuanLy,
                    ThoiGian=:ThoiGian,
                    ChanDoan=:ChanDoan,
                    Khoa=:Khoa,  MaKhoa=:MaKhoa, 
                    SuaSoan=:SuaSoan,
                    SuaSoanGhiChu=:SuaSoanGhiChu,
                    TruongKhoaKS=:TruongKhoaKS,
                    TruongKhoaKSGhiChu=:TruongKhoaKSGhiChu,
                    VeSinh=:VeSinh,
                    VeSinhGhiChu=:VeSinhGhiChu,
                    MacAoMo=:MacAoMo,
                    MacAoMoGhiChu=:MacAoMoGhiChu,
                    GiuNuTrang=:GiuNuTrang,
                    GiuNuTrangGhiChu=:GiuNuTrangGhiChu,
                    ThaoRangGia=:ThaoRangGia,
                    ThaoRangGiaGhiChu=:ThaoRangGiaGhiChu,
                    BimToc=:BimToc,
                    BimTocGhiChu=:BimTocGhiChu,
                    DatThongTieu=:DatThongTieu,
                    DatThongTieuGhiChu=:DatThongTieuGhiChu,
                    ThutDaitTrang=:ThutDaitTrang,
                    ThutDaitTrangGhiChu=:ThutDaitTrangGhiChu,
                    RuaDaDay=:RuaDaDay,
                    RuaDaDayGhiChu=:RuaDaDayGhiChu,
                    DeoVongTen=:DeoVongTen,
                    DeoVongTenGhiChu=:DeoVongTenGhiChu,
                    NhinAn=:NhinAn,
                    NhinAnGhiChu=:NhinAnGhiChu,
                    KyCamKet=:KyCamKet,
                    KyCamKetGhiChu=:KyCamKetGhiChu,
                    XQuang=:XQuang,
                    XQuangGhiChu=:XQuangGhiChu,
                    KhangSinh=:KhangSinh,
                    KhangSinhGhiChu=:KhangSinhGhiChu,
                    Mach=:Mach,
                    NhietDo=:NhietDo,
                    HuyetApMax=:HuyetApMax,
                    HuyetApMin=:HuyetApMin,
                    NhipTho=:NhipTho,
                    YKien=:YKien,
                    DieuDuongPT=:DieuDuongPT,
                    MaDieuDuongPT=:MaDieuDuongPT,
                    NgaySua=:NgaySua,
                    NguoiSua=:NguoiSua
                    WHERE ID = " + data.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", data.MaQuanLy)); 
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGian", data.ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", data.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa", data.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaKhoa", data.MaKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("SuaSoan", data.SuaSoan));
                Command.Parameters.Add(new MDB.MDBParameter("SuaSoanGhiChu", data.SuaSoanGhiChu));
                Command.Parameters.Add(new MDB.MDBParameter("TruongKhoaKS", data.TruongKhoaKS));
                Command.Parameters.Add(new MDB.MDBParameter("TruongKhoaKSGhiChu", data.TruongKhoaKSGhiChu));
                Command.Parameters.Add(new MDB.MDBParameter("VeSinh", data.VeSinh));
                Command.Parameters.Add(new MDB.MDBParameter("VeSinhGhiChu", data.VeSinhGhiChu));
                Command.Parameters.Add(new MDB.MDBParameter("MacAoMo", data.MacAoMo));
                Command.Parameters.Add(new MDB.MDBParameter("MacAoMoGhiChu", data.MacAoMoGhiChu));
                Command.Parameters.Add(new MDB.MDBParameter("GiuNuTrang", data.GiuNuTrang));
                Command.Parameters.Add(new MDB.MDBParameter("GiuNuTrangGhiChu", data.GiuNuTrangGhiChu));
                Command.Parameters.Add(new MDB.MDBParameter("ThaoRangGia", data.ThaoRangGia));
                Command.Parameters.Add(new MDB.MDBParameter("ThaoRangGiaGhiChu", data.ThaoRangGiaGhiChu));
                Command.Parameters.Add(new MDB.MDBParameter("BimToc", data.BimToc));
                Command.Parameters.Add(new MDB.MDBParameter("BimTocGhiChu", data.BimTocGhiChu));
                Command.Parameters.Add(new MDB.MDBParameter("DatThongTieu", data.DatThongTieu));
                Command.Parameters.Add(new MDB.MDBParameter("DatThongTieuGhiChu", data.DatThongTieuGhiChu));
                Command.Parameters.Add(new MDB.MDBParameter("ThutDaitTrang", data.ThutDaitTrang));
                Command.Parameters.Add(new MDB.MDBParameter("ThutDaitTrangGhiChu", data.ThutDaitTrangGhiChu));
                Command.Parameters.Add(new MDB.MDBParameter("RuaDaDay", data.RuaDaDay));
                Command.Parameters.Add(new MDB.MDBParameter("RuaDaDayGhiChu", data.RuaDaDayGhiChu));
                Command.Parameters.Add(new MDB.MDBParameter("DeoVongTen", data.DeoVongTen));
                Command.Parameters.Add(new MDB.MDBParameter("DeoVongTenGhiChu", data.DeoVongTenGhiChu));
                Command.Parameters.Add(new MDB.MDBParameter("NhinAn", data.NhinAn));
                Command.Parameters.Add(new MDB.MDBParameter("NhinAnGhiChu", data.NhinAnGhiChu));
                Command.Parameters.Add(new MDB.MDBParameter("KyCamKet", data.KyCamKet));
                Command.Parameters.Add(new MDB.MDBParameter("KyCamKetGhiChu", data.KyCamKetGhiChu));
                Command.Parameters.Add(new MDB.MDBParameter("XQuang", data.XQuang));
                Command.Parameters.Add(new MDB.MDBParameter("XQuangGhiChu", data.XQuangGhiChu));
                Command.Parameters.Add(new MDB.MDBParameter("KhangSinh", data.KhangSinh));
                Command.Parameters.Add(new MDB.MDBParameter("KhangSinhGhiChu", data.KhangSinhGhiChu));
                Command.Parameters.Add(new MDB.MDBParameter("Mach", data.Mach));
                Command.Parameters.Add(new MDB.MDBParameter("NhietDo", data.NhietDo));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetApMax", data.HuyetApMax));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetApMin", data.HuyetApMin));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTho", data.NhipTho));
                Command.Parameters.Add(new MDB.MDBParameter("YKien", data.YKien));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuongPT", data.DieuDuongPT));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuongPT", data.MaDieuDuongPT));
                Command.Parameters.Add(new MDB.MDBParameter("NgaySua", DateTime.Now));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiSua", data.NguoiSua));
                if (data.ID == 0)
                {  
                    Command.Parameters.Add(new MDB.MDBParameter("NgayTao", DateTime.Now));
                    Command.Parameters.Add(new MDB.MDBParameter("NguoiTao", data.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("ID", data.ID));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (data.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    data.ID = nextval;
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
                string sql = "DELETE FROM BangKiemSoatBNTruocMo WHERE ID = :ID";
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
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, long id)
        {
            string sql = @"SELECT
                B.*,
                '' MABENHAN, '' SoNhapVien,
                '' SoYTe,
                '' BenhVien,
	            '' TENBENHNHAN,
                '' TUOI,
                '' GioiTinh
            FROM
                BangKiemSoatBNTruocMo B
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            adt.Fill(ds, "BK");
            if (ds != null || ds.Tables[0].Rows.Count > 0)
            {
                ds.Tables[0].Rows[0]["SoNhapVien"] = XemBenhAn._ThongTinDieuTri.SoNhapVien;
                ds.Tables[0].Rows[0]["MaBenhAn"] = XemBenhAn._ThongTinDieuTri.MaBenhAn;
                ds.Tables[0].Rows[0]["SoYTe"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
                ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
                ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                ds.Tables[0].Rows[0]["TUOI"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            }
            return ds;
        }
    }

}
