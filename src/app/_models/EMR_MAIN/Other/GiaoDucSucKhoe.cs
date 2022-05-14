using EMR.KyDienTu;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class GiaoDucSucKhoe : ThongTinKy
    {
        public GiaoDucSucKhoe()
        {
            TableName = "GiaoDucSucKhoe";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PTVGDSK;
            TenMauPhieu = DanhMucPhieu.PTVGDSK.Description();
        }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Ngày vào bệnh viện")]
		public DateTime NgayVaoVien { get; set; }

        [MoTaDuLieu("Mã bệnh án")]
		public string MaBenhAn { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        public int Giuong { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public string Khac { get; set; }
        public string Khac2 { get; set; }
        public int ThuTucNhapVienNC { get; set; }
        public int NoiQuyNC { get; set; }
        public int TTBYTNC { get; set; }
        public int TienIchNC { get; set; }
        public int VongDeoTayNC { get; set; }
        public int CachDungThuocNC { get; set; }
        public int CheDoDinhDuongNC { get; set; }
        public int BenhLyNC { get; set; }
        public int PHCNNC { get; set; }
        public int NgaNC { get; set; }
        public int LoetNC { get; set; }
        public int KhacNC { get; set; }
        public string ThuTucNhapVienTN { get; set; }
        public string NoiQuyTN { get; set; }
        public string TTBYTTN { get; set; }
        public string TienIchTN { get; set; }
        public string VongDeoTayTN { get; set; }
        public string CachDungThuocTN { get; set; }
        public string CheDoDinhDuongTN { get; set; }
        public string BenhLyTN { get; set; }
        public string PHCNTN { get; set; }
        public string NgaTN { get; set; }
        public string LoetTN { get; set; }
        public string KhacTN { get; set; }
        public string ThuTucNhapVienPP { get; set; }
        public string NoiQuyPP { get; set; }
        public string TTBYTPP { get; set; }
        public string TienIchPP { get; set; }
        public string VongDeoTayPP { get; set; }
        public string CachDungThuocPP { get; set; }
        public string CheDoDinhDuongPP { get; set; }
        public string BenhLyPP { get; set; }
        public string PHCNPP { get; set; }
        public string NgaPP { get; set; }
        public string LoetPP { get; set; }
        public string KhacPP { get; set; }
        public string ThuTucNhapVienPPK { get; set; }
        public string NoiQuyPPK { get; set; }
        public string TTBYTPPK { get; set; }
        public string TienIchPPK { get; set; }
        public string VongDeoTayPPK { get; set; }
        public string CachDungThuocPPK { get; set; }
        public string CheDoDinhDuongPPK { get; set; }
        public string BenhLyPPK { get; set; }
        public string PHCNPPK { get; set; }
        public string NgaPPK { get; set; }
        public string LoetPPK { get; set; }
        public string KhacPPK { get; set; }
        public int ThuTucRaVienNC { get; set; }
        public int DonThuocNC { get; set; }
        public int CheDoDinhDuong2NC { get; set; }
        public int CachChamSocNC { get; set; }
        public int TaiKhamNC { get; set; }
        public int Khac2NC { get; set; }
        public string ThuTucRaVienTN { get; set; }
        public string DonThuocTN { get; set; }
        public string CheDoDinhDuong2TN { get; set; }
        public string CachChamSocTN { get; set; }
        public string TaiKhamTN { get; set; }
        public string Khac2TN { get; set; }
        public string ThuTucRaVienPP { get; set; }
        public string DonThuocPP { get; set; }
        public string CheDoDinhDuong2PP { get; set; }
        public string CachChamSocPP { get; set; }
        public string TaiKhamPP { get; set; }
        public string Khac2PP { get; set; }
        public string ThuTucRaVienPPK { get; set; }
        public string DonThuocPPK { get; set; }
        public string CheDoDinhDuong2PPK { get; set; }
        public string CachChamSocPPK { get; set; }
        public string TaiKhamPPK { get; set; }
        public string Khac2PPK { get; set; }
        public DateTime ThoiGian { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuong { get; set; }
        [MoTaDuLieu("Mã điều dưỡng")]
		public string MaDieuDuong { get; set; }
        public DateTime ThoiGian2 { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuong2 { get; set; }
        [MoTaDuLieu("Mã điều dưỡng")]
		public string MaDieuDuong2 { get; set; }

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
    public class GiaoDucSucKhoeFunc
    {
        public const string TableName = "GiaoDucSucKhoe";
        public const string TablePrimaryKeyName = "ID";
        public static List<GiaoDucSucKhoe> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<GiaoDucSucKhoe> list = new List<GiaoDucSucKhoe>();
            try
            {
                string sql = @"SELECT * FROM GiaoDucSucKhoe where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    GiaoDucSucKhoe data = new GiaoDucSucKhoe();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.NgayVaoVien = Common.ConDB_DateTime(DataReader["NgayVaoVien"]);
                    data.MaBenhAn = DataReader["MaBenhAn"].ToString();
                    data.GioiTinh = DataReader["GioiTinh"].ToString();
                    data.Giuong = Common.ConDB_Int(DataReader["Giuong"]);
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.Khac = DataReader["Khac"].ToString();
                    data.Khac2 = DataReader["Khac2"].ToString();
                    data.ThuTucNhapVienNC = Common.ConDB_Int(DataReader["ThuTucNhapVienNC"]);
                    data.NoiQuyNC = Common.ConDB_Int(DataReader["NoiQuyNC"]);
                    data.TTBYTNC = Common.ConDB_Int(DataReader["TTBYTNC"]);
                    data.TienIchNC = Common.ConDB_Int(DataReader["TienIchNC"]);
                    data.VongDeoTayNC = Common.ConDB_Int(DataReader["VongDeoTayNC"]);
                    data.CachDungThuocNC = Common.ConDB_Int(DataReader["CachDungThuocNC"]);
                    data.CheDoDinhDuongNC = Common.ConDB_Int(DataReader["CheDoDinhDuongNC"]);
                    data.BenhLyNC = Common.ConDB_Int(DataReader["BenhLyNC"]);
                    data.PHCNNC = Common.ConDB_Int(DataReader["PHCNNC"]);
                    data.NgaNC = Common.ConDB_Int(DataReader["NgaNC"]);
                    data.LoetNC = Common.ConDB_Int(DataReader["LoetNC"]);
                    data.KhacNC = Common.ConDB_Int(DataReader["KhacNC"]);
                    data.ThuTucNhapVienTN = DataReader["ThuTucNhapVienTN"].ToString();
                    data.NoiQuyTN = DataReader["NoiQuyTN"].ToString();
                    data.TTBYTTN = DataReader["TTBYTTN"].ToString();
                    data.TienIchTN = DataReader["TienIchTN"].ToString();
                    data.VongDeoTayTN = DataReader["VongDeoTayTN"].ToString();
                    data.CachDungThuocTN = DataReader["CachDungThuocTN"].ToString();
                    data.CheDoDinhDuongTN = DataReader["CheDoDinhDuongTN"].ToString();
                    data.BenhLyTN = DataReader["BenhLyTN"].ToString();
                    data.PHCNTN = DataReader["PHCNTN"].ToString();
                    data.NgaTN = DataReader["NgaTN"].ToString();
                    data.LoetTN = DataReader["LoetTN"].ToString();
                    data.KhacTN = DataReader["KhacTN"].ToString();
                    data.ThuTucNhapVienPP = DataReader["ThuTucNhapVienPP"].ToString();
                    data.NoiQuyPP = DataReader["NoiQuyPP"].ToString();
                    data.TTBYTPP = DataReader["TTBYTPP"].ToString();
                    data.TienIchPP = DataReader["TienIchPP"].ToString();
                    data.VongDeoTayPP = DataReader["VongDeoTayPP"].ToString();
                    data.CachDungThuocPP = DataReader["CachDungThuocPP"].ToString();
                    data.CheDoDinhDuongPP = DataReader["CheDoDinhDuongPP"].ToString();
                    data.BenhLyPP = DataReader["BenhLyPP"].ToString();
                    data.PHCNPP = DataReader["PHCNPP"].ToString();
                    data.NgaPP = DataReader["NgaPP"].ToString();
                    data.LoetPP = DataReader["LoetPP"].ToString();
                    data.KhacPP = DataReader["KhacPP"].ToString();
                    data.ThuTucNhapVienPPK = DataReader["ThuTucNhapVienPPK"].ToString();
                    data.NoiQuyPPK = DataReader["NoiQuyPPK"].ToString();
                    data.TTBYTPPK = DataReader["TTBYTPPK"].ToString();
                    data.TienIchPPK = DataReader["TienIchPPK"].ToString();
                    data.VongDeoTayPPK = DataReader["VongDeoTayPPK"].ToString();
                    data.CachDungThuocPPK = DataReader["CachDungThuocPPK"].ToString();
                    data.CheDoDinhDuongPPK = DataReader["CheDoDinhDuongPPK"].ToString();
                    data.BenhLyPPK = DataReader["BenhLyPPK"].ToString();
                    data.PHCNPPK = DataReader["PHCNPPK"].ToString();
                    data.NgaPPK = DataReader["NgaPPK"].ToString();
                    data.LoetPPK = DataReader["LoetPPK"].ToString();
                    data.KhacPPK = DataReader["KhacPPK"].ToString();
                    data.ThuTucRaVienNC = Common.ConDB_Int(DataReader["ThuTucRaVienNC"]);
                    data.DonThuocNC = Common.ConDB_Int(DataReader["DonThuocNC"]);
                    data.CheDoDinhDuong2NC = Common.ConDB_Int(DataReader["CheDoDinhDuong2NC"]);
                    data.CachChamSocNC = Common.ConDB_Int(DataReader["CachChamSocNC"]);
                    data.TaiKhamNC = Common.ConDB_Int(DataReader["TaiKhamNC"]);
                    data.Khac2NC = Common.ConDB_Int(DataReader["Khac2NC"]);
                    data.ThuTucRaVienTN = DataReader["ThuTucRaVienTN"].ToString();
                    data.DonThuocTN = DataReader["DonThuocTN"].ToString();
                    data.CheDoDinhDuong2TN = DataReader["CheDoDinhDuong2TN"].ToString();
                    data.CachChamSocTN = DataReader["CachChamSocTN"].ToString();
                    data.TaiKhamTN = DataReader["TaiKhamTN"].ToString();
                    data.Khac2TN = DataReader["Khac2TN"].ToString();
                    data.ThuTucRaVienPP = DataReader["ThuTucRaVienPP"].ToString();
                    data.DonThuocPP = DataReader["DonThuocPP"].ToString();
                    data.CheDoDinhDuong2PP = DataReader["CheDoDinhDuong2PP"].ToString();
                    data.CachChamSocPP = DataReader["CachChamSocPP"].ToString();
                    data.TaiKhamPP = DataReader["TaiKhamPP"].ToString();
                    data.Khac2PP = DataReader["Khac2PP"].ToString();
                    data.ThuTucRaVienPPK = DataReader["ThuTucRaVienPPK"].ToString();
                    data.DonThuocPPK = DataReader["DonThuocPPK"].ToString();
                    data.CheDoDinhDuong2PPK = DataReader["CheDoDinhDuong2PPK"].ToString();
                    data.CachChamSocPPK = DataReader["CachChamSocPPK"].ToString();
                    data.TaiKhamPPK = DataReader["TaiKhamPPK"].ToString();
                    data.Khac2PPK = DataReader["Khac2PPK"].ToString();
                    data.ThoiGian = Common.ConDB_DateTime(DataReader["ThoiGian"]);
                    data.DieuDuong = DataReader["DieuDuong"].ToString();
                    data.MaDieuDuong = DataReader["MaDieuDuong"].ToString();
                    data.ThoiGian2 = Common.ConDB_DateTime(DataReader["ThoiGian2"]);
                    data.DieuDuong2 = DataReader["DieuDuong2"].ToString();
                    data.MaDieuDuong2 = DataReader["MaDieuDuong2"].ToString();


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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref GiaoDucSucKhoe data)
        {
            try
            {
                string sql = @"INSERT INTO GiaoDucSucKhoe
                (
                    MAQUANLY,
                    MaBenhNhan,
                    NgayVaoVien,
                    MaBenhAn,
                    GioiTinh,
                    Giuong,
                    ChanDoan,
                    Khac,
                    Khac2,
                    ThuTucNhapVienNC,
                    NoiQuyNC,
                    TTBYTNC,
                    TienIchNC,
                    VongDeoTayNC,
                    CachDungThuocNC,
                    CheDoDinhDuongNC,
                    BenhLyNC,
                    PHCNNC,
                    NgaNC,
                    LoetNC,
                    KhacNC,
                    ThuTucNhapVienTN,
                    NoiQuyTN,
                    TTBYTTN,
                    TienIchTN,
                    VongDeoTayTN,
                    CachDungThuocTN,
                    CheDoDinhDuongTN,
                    BenhLyTN,
                    PHCNTN,
                    NgaTN,
                    LoetTN,
                    KhacTN,
                    ThuTucNhapVienPP,
                    NoiQuyPP,
                    TTBYTPP,
                    TienIchPP,
                    VongDeoTayPP,
                    CachDungThuocPP,
                    CheDoDinhDuongPP,
                    BenhLyPP,
                    PHCNPP,
                    NgaPP,
                    LoetPP,
                    KhacPP,
                    ThuTucNhapVienPPK,
                    NoiQuyPPK,
                    TTBYTPPK,
                    TienIchPPK,
                    VongDeoTayPPK,
                    CachDungThuocPPK,
                    CheDoDinhDuongPPK,
                    BenhLyPPK,
                    PHCNPPK,
                    NgaPPK,
                    LoetPPK,
                    KhacPPK,
                    ThuTucRaVienNC,
                    DonThuocNC,
                    CheDoDinhDuong2NC,
                    CachChamSocNC,
                    TaiKhamNC,
                    Khac2NC,
                    ThuTucRaVienTN,
                    DonThuocTN,
                    CheDoDinhDuong2TN,
                    CachChamSocTN,
                    TaiKhamTN,
                    Khac2TN,
                    ThuTucRaVienPP,
                    DonThuocPP,
                    CheDoDinhDuong2PP,
                    CachChamSocPP,
                    TaiKhamPP,
                    Khac2PP,
                    ThuTucRaVienPPK,
                    DonThuocPPK,
                    CheDoDinhDuong2PPK,
                    CachChamSocPPK,
                    TaiKhamPPK,
                    Khac2PPK,
                    ThoiGian,
                    DieuDuong,
                    MaDieuDuong,
                    ThoiGian2,
                    DieuDuong2,
                    MaDieuDuong2,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :NgayVaoVien,
                    :MaBenhAn,
                    :GioiTinh,
                    :Giuong,
                    :ChanDoan,
                    :Khac,
                    :Khac2,
                    :ThuTucNhapVienNC,
                    :NoiQuyNC,
                    :TTBYTNC,
                    :TienIchNC,
                    :VongDeoTayNC,
                    :CachDungThuocNC,
                    :CheDoDinhDuongNC,
                    :BenhLyNC,
                    :PHCNNC,
                    :NgaNC,
                    :LoetNC,
                    :KhacNC,
                    :ThuTucNhapVienTN,
                    :NoiQuyTN,
                    :TTBYTTN,
                    :TienIchTN,
                    :VongDeoTayTN,
                    :CachDungThuocTN,
                    :CheDoDinhDuongTN,
                    :BenhLyTN,
                    :PHCNTN,
                    :NgaTN,
                    :LoetTN,
                    :KhacTN,
                    :ThuTucNhapVienPP,
                    :NoiQuyPP,
                    :TTBYTPP,
                    :TienIchPP,
                    :VongDeoTayPP,
                    :CachDungThuocPP,
                    :CheDoDinhDuongPP,
                    :BenhLyPP,
                    :PHCNPP,
                    :NgaPP,
                    :LoetPP,
                    :KhacPP,
                    :ThuTucNhapVienPPK,
                    :NoiQuyPPK,
                    :TTBYTPPK,
                    :TienIchPPK,
                    :VongDeoTayPPK,
                    :CachDungThuocPPK,
                    :CheDoDinhDuongPPK,
                    :BenhLyPPK,
                    :PHCNPPK,
                    :NgaPPK,
                    :LoetPPK,
                    :KhacPPK,
                    :ThuTucRaVienNC,
                    :DonThuocNC,
                    :CheDoDinhDuong2NC,
                    :CachChamSocNC,
                    :TaiKhamNC,
                    :Khac2NC,
                    :ThuTucRaVienTN,
                    :DonThuocTN,
                    :CheDoDinhDuong2TN,
                    :CachChamSocTN,
                    :TaiKhamTN,
                    :Khac2TN,
                    :ThuTucRaVienPP,
                    :DonThuocPP,
                    :CheDoDinhDuong2PP,
                    :CachChamSocPP,
                    :TaiKhamPP,
                    :Khac2PP,
                    :ThuTucRaVienPPK,
                    :DonThuocPPK,
                    :CheDoDinhDuong2PPK,
                    :CachChamSocPPK,
                    :TaiKhamPPK,
                    :Khac2PPK,
                    :ThoiGian,
                    :DieuDuong,
                    :MaDieuDuong,
                    :ThoiGian2,
                    :DieuDuong2,
                    :MaDieuDuong2,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (data.ID != 0)
                {
                    sql = @"UPDATE GiaoDucSucKhoe SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    NgayVaoVien=:NgayVaoVien,
                    MaBenhAn=:MaBenhAn,
                    GioiTinh=:GioiTinh,
                    Giuong=:Giuong,
                    ChanDoan=:ChanDoan,
                    Khac=:Khac,
                    Khac2=:Khac2,
                    ThuTucNhapVienNC=:ThuTucNhapVienNC,
                    NoiQuyNC=:NoiQuyNC,
                    TTBYTNC=:TTBYTNC,
                    TienIchNC=:TienIchNC,
                    VongDeoTayNC=:VongDeoTayNC,
                    CachDungThuocNC=:CachDungThuocNC,
                    CheDoDinhDuongNC=:CheDoDinhDuongNC,
                    BenhLyNC=:BenhLyNC,
                    PHCNNC=:PHCNNC,
                    NgaNC=:NgaNC,
                    LoetNC=:LoetNC,
                    KhacNC=:KhacNC,
                    ThuTucNhapVienTN=:ThuTucNhapVienTN,
                    NoiQuyTN=:NoiQuyTN,
                    TTBYTTN=:TTBYTTN,
                    TienIchTN=:TienIchTN,
                    VongDeoTayTN=:VongDeoTayTN,
                    CachDungThuocTN=:CachDungThuocTN,
                    CheDoDinhDuongTN=:CheDoDinhDuongTN,
                    BenhLyTN=:BenhLyTN,
                    PHCNTN=:PHCNTN,
                    NgaTN=:NgaTN,
                    LoetTN=:LoetTN,
                    KhacTN=:KhacTN,
                    ThuTucNhapVienPP=:ThuTucNhapVienPP,
                    NoiQuyPP=:NoiQuyPP,
                    TTBYTPP=:TTBYTPP,
                    TienIchPP=:TienIchPP,
                    VongDeoTayPP=:VongDeoTayPP,
                    CachDungThuocPP=:CachDungThuocPP,
                    CheDoDinhDuongPP=:CheDoDinhDuongPP,
                    BenhLyPP=:BenhLyPP,
                    PHCNPP=:PHCNPP,
                    NgaPP=:NgaPP,
                    LoetPP=:LoetPP,
                    KhacPP=:KhacPP,
                    ThuTucNhapVienPPK=:ThuTucNhapVienPPK,
                    NoiQuyPPK=:NoiQuyPPK,
                    TTBYTPPK=:TTBYTPPK,
                    TienIchPPK=:TienIchPPK,
                    VongDeoTayPPK=:VongDeoTayPPK,
                    CachDungThuocPPK=:CachDungThuocPPK,
                    CheDoDinhDuongPPK=:CheDoDinhDuongPPK,
                    BenhLyPPK=:BenhLyPPK,
                    PHCNPPK=:PHCNPPK,
                    NgaPPK=:NgaPPK,
                    LoetPPK=:LoetPPK,
                    KhacPPK=:KhacPPK,
                    ThuTucRaVienNC=:ThuTucRaVienNC,
                    DonThuocNC=:DonThuocNC,
                    CheDoDinhDuong2NC=:CheDoDinhDuong2NC,
                    CachChamSocNC=:CachChamSocNC,
                    TaiKhamNC=:TaiKhamNC,
                    Khac2NC=:Khac2NC,
                    ThuTucRaVienTN=:ThuTucRaVienTN,
                    DonThuocTN=:DonThuocTN,
                    CheDoDinhDuong2TN=:CheDoDinhDuong2TN,
                    CachChamSocTN=:CachChamSocTN,
                    TaiKhamTN=:TaiKhamTN,
                    Khac2TN=:Khac2TN,
                    ThuTucRaVienPP=:ThuTucRaVienPP,
                    DonThuocPP=:DonThuocPP,
                    CheDoDinhDuong2PP=:CheDoDinhDuong2PP,
                    CachChamSocPP=:CachChamSocPP,
                    TaiKhamPP=:TaiKhamPP,
                    Khac2PP=:Khac2PP,
                    ThuTucRaVienPPK=:ThuTucRaVienPPK,
                    DonThuocPPK=:DonThuocPPK,
                    CheDoDinhDuong2PPK=:CheDoDinhDuong2PPK,
                    CachChamSocPPK=:CachChamSocPPK,
                    TaiKhamPPK=:TaiKhamPPK,
                    Khac2PPK=:Khac2PPK,
                    ThoiGian=:ThoiGian,
                    DieuDuong=:DieuDuong,
                    MaDieuDuong=:MaDieuDuong,
                    ThoiGian2=:ThoiGian2,
                    DieuDuong2=:DieuDuong2,
                    MaDieuDuong2=:MaDieuDuong2,
                    NGUOISUA= :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + data.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", data.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", data.MaBenhNhan));
                var Ngay = data.NgayVaoVien.Date.Add(new TimeSpan(0, 0, 0));
                var Gio = data.NgayVaoVien != null ? data.NgayVaoVien.TimeOfDay : DateTime.Now.TimeOfDay;
                var NgayVaoVien = Ngay + Gio;
                Command.Parameters.Add(new MDB.MDBParameter("NgayVaoVien", NgayVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhAn", data.MaBenhAn));
                Command.Parameters.Add(new MDB.MDBParameter("GioiTinh", data.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("Giuong", data.Giuong));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", data.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("Khac", data.Khac));
                Command.Parameters.Add(new MDB.MDBParameter("Khac2", data.Khac2));
                Command.Parameters.Add(new MDB.MDBParameter("ThuTucNhapVienNC", data.ThuTucNhapVienNC));
                Command.Parameters.Add(new MDB.MDBParameter("NoiQuyNC", data.NoiQuyNC));
                Command.Parameters.Add(new MDB.MDBParameter("TTBYTNC", data.TTBYTNC));
                Command.Parameters.Add(new MDB.MDBParameter("TienIchNC", data.TienIchNC));
                Command.Parameters.Add(new MDB.MDBParameter("VongDeoTayNC", data.VongDeoTayNC));
                Command.Parameters.Add(new MDB.MDBParameter("CachDungThuocNC", data.CachDungThuocNC));
                Command.Parameters.Add(new MDB.MDBParameter("CheDoDinhDuongNC", data.CheDoDinhDuongNC));
                Command.Parameters.Add(new MDB.MDBParameter("BenhLyNC", data.BenhLyNC));
                Command.Parameters.Add(new MDB.MDBParameter("PHCNNC", data.PHCNNC));
                Command.Parameters.Add(new MDB.MDBParameter("NgaNC", data.NgaNC));
                Command.Parameters.Add(new MDB.MDBParameter("LoetNC", data.LoetNC));
                Command.Parameters.Add(new MDB.MDBParameter("KhacNC", data.KhacNC));
                Command.Parameters.Add(new MDB.MDBParameter("ThuTucNhapVienTN", data.ThuTucNhapVienTN));
                Command.Parameters.Add(new MDB.MDBParameter("NoiQuyTN", data.NoiQuyTN));
                Command.Parameters.Add(new MDB.MDBParameter("TTBYTTN", data.TTBYTTN));
                Command.Parameters.Add(new MDB.MDBParameter("TienIchTN", data.TienIchTN));
                Command.Parameters.Add(new MDB.MDBParameter("VongDeoTayTN", data.VongDeoTayTN));
                Command.Parameters.Add(new MDB.MDBParameter("CachDungThuocTN", data.CachDungThuocTN));
                Command.Parameters.Add(new MDB.MDBParameter("CheDoDinhDuongTN", data.CheDoDinhDuongTN));
                Command.Parameters.Add(new MDB.MDBParameter("BenhLyTN", data.BenhLyTN));
                Command.Parameters.Add(new MDB.MDBParameter("PHCNTN", data.PHCNTN));
                Command.Parameters.Add(new MDB.MDBParameter("NgaTN", data.NgaTN));
                Command.Parameters.Add(new MDB.MDBParameter("LoetTN", data.LoetTN));
                Command.Parameters.Add(new MDB.MDBParameter("KhacTN", data.KhacTN));
                Command.Parameters.Add(new MDB.MDBParameter("ThuTucNhapVienPP", data.ThuTucNhapVienPP));
                Command.Parameters.Add(new MDB.MDBParameter("NoiQuyPP", data.NoiQuyPP));
                Command.Parameters.Add(new MDB.MDBParameter("TTBYTPP", data.TTBYTPP));
                Command.Parameters.Add(new MDB.MDBParameter("TienIchPP", data.TienIchPP));
                Command.Parameters.Add(new MDB.MDBParameter("VongDeoTayPP", data.VongDeoTayPP));
                Command.Parameters.Add(new MDB.MDBParameter("CachDungThuocPP", data.CachDungThuocPP));
                Command.Parameters.Add(new MDB.MDBParameter("CheDoDinhDuongPP", data.CheDoDinhDuongPP));
                Command.Parameters.Add(new MDB.MDBParameter("BenhLyPP", data.BenhLyPP));
                Command.Parameters.Add(new MDB.MDBParameter("PHCNPP", data.PHCNPP));
                Command.Parameters.Add(new MDB.MDBParameter("NgaPP", data.NgaPP));
                Command.Parameters.Add(new MDB.MDBParameter("LoetPP", data.LoetPP));
                Command.Parameters.Add(new MDB.MDBParameter("KhacPP", data.KhacPP));
                Command.Parameters.Add(new MDB.MDBParameter("ThuTucNhapVienPPK", data.ThuTucNhapVienPPK));
                Command.Parameters.Add(new MDB.MDBParameter("NoiQuyPPK", data.NoiQuyPPK));
                Command.Parameters.Add(new MDB.MDBParameter("TTBYTPPK", data.TTBYTPPK));
                Command.Parameters.Add(new MDB.MDBParameter("TienIchPPK", data.TienIchPPK));
                Command.Parameters.Add(new MDB.MDBParameter("VongDeoTayPPK", data.VongDeoTayPPK));
                Command.Parameters.Add(new MDB.MDBParameter("CachDungThuocPPK", data.CachDungThuocPPK));
                Command.Parameters.Add(new MDB.MDBParameter("CheDoDinhDuongPPK", data.CheDoDinhDuongPPK));
                Command.Parameters.Add(new MDB.MDBParameter("BenhLyPPK", data.BenhLyPPK));
                Command.Parameters.Add(new MDB.MDBParameter("PHCNPPK", data.PHCNPPK));
                Command.Parameters.Add(new MDB.MDBParameter("NgaPPK", data.NgaPPK));
                Command.Parameters.Add(new MDB.MDBParameter("LoetPPK", data.LoetPPK));
                Command.Parameters.Add(new MDB.MDBParameter("KhacPPK", data.KhacPPK));
                Command.Parameters.Add(new MDB.MDBParameter("ThuTucRaVienNC", data.ThuTucRaVienNC));
                Command.Parameters.Add(new MDB.MDBParameter("DonThuocNC", data.DonThuocNC));
                Command.Parameters.Add(new MDB.MDBParameter("CheDoDinhDuong2NC", data.CheDoDinhDuong2NC));
                Command.Parameters.Add(new MDB.MDBParameter("CachChamSocNC", data.CachChamSocNC));
                Command.Parameters.Add(new MDB.MDBParameter("TaiKhamNC", data.TaiKhamNC));
                Command.Parameters.Add(new MDB.MDBParameter("Khac2NC", data.Khac2NC));
                Command.Parameters.Add(new MDB.MDBParameter("ThuTucRaVienTN", data.ThuTucRaVienTN));
                Command.Parameters.Add(new MDB.MDBParameter("DonThuocTN", data.DonThuocTN));
                Command.Parameters.Add(new MDB.MDBParameter("CheDoDinhDuong2TN", data.CheDoDinhDuong2TN));
                Command.Parameters.Add(new MDB.MDBParameter("CachChamSocTN", data.CachChamSocTN));
                Command.Parameters.Add(new MDB.MDBParameter("TaiKhamTN", data.TaiKhamTN));
                Command.Parameters.Add(new MDB.MDBParameter("Khac2TN", data.Khac2TN));
                Command.Parameters.Add(new MDB.MDBParameter("ThuTucRaVienPP", data.ThuTucRaVienPP));
                Command.Parameters.Add(new MDB.MDBParameter("DonThuocPP", data.DonThuocPP));
                Command.Parameters.Add(new MDB.MDBParameter("CheDoDinhDuong2PP", data.CheDoDinhDuong2PP));
                Command.Parameters.Add(new MDB.MDBParameter("CachChamSocPP", data.CachChamSocPP));
                Command.Parameters.Add(new MDB.MDBParameter("TaiKhamPP", data.TaiKhamPP));
                Command.Parameters.Add(new MDB.MDBParameter("Khac2PP", data.Khac2PP));
                Command.Parameters.Add(new MDB.MDBParameter("ThuTucRaVienPPK", data.ThuTucRaVienPPK));
                Command.Parameters.Add(new MDB.MDBParameter("DonThuocPPK", data.DonThuocPPK));
                Command.Parameters.Add(new MDB.MDBParameter("CheDoDinhDuong2PPK", data.CheDoDinhDuong2PPK));
                Command.Parameters.Add(new MDB.MDBParameter("CachChamSocPPK", data.CachChamSocPPK));
                Command.Parameters.Add(new MDB.MDBParameter("TaiKhamPPK", data.TaiKhamPPK));
                Command.Parameters.Add(new MDB.MDBParameter("Khac2PPK", data.Khac2PPK));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGian", data.ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuong", data.DieuDuong));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuong", data.MaDieuDuong));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGian2", data.ThoiGian2));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuong2", data.DieuDuong2));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuong2", data.MaDieuDuong2));

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
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    data.ID = nextval;
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
                string sql = "DELETE FROM GiaoDucSucKhoe WHERE ID = :ID";
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
                B.*,
                T.MABENHAN,
	            H.TENBENHNHAN,
                H.TUOI
            FROM
                GiaoDucSucKhoe B
                JOIN THONGTINDIEUTRI T ON B.MAQUANLY = T.MAQUANLY
                JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "BK");

            /*DataTable thongTinVien = new DataTable("HEADER");

            thongTinVien.Columns.Add("BENHVIEN");
            thongTinVien.Columns.Add("KHOA");
            thongTinVien.Rows.Add(XemBenhAn._HanhChinhBenhNhan.BenhVien, XemBenhAn._ThongTinDieuTri.Khoa);
            ds.Tables.Add(thongTinVien);*/

            return ds;
        }
    }

}
