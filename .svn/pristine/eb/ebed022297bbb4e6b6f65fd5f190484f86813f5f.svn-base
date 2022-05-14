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
    public class PhieuDanhGiaTinhTrangDinhDuongSGA : ThongTinKy
    {
        public PhieuDanhGiaTinhTrangDinhDuongSGA()
        {
            TableName = "PhieuDanhGiaTinhTDDSGA";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PDGTTDDSGA;
            TenMauPhieu = DanhMucPhieu.PDGTTDDSGA.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Họ tên người bệnh")]
        public string HoTenBN { get; set; }
        [MoTaDuLieu("Tuổi người bệnh")]
        public string Tuoi { get; set; }
        [MoTaDuLieu("Mã số bệnh nhân")]
        public string MaSoBN { get; set; }
        [MoTaDuLieu("Khoa người bệnh nằm")]
        public string Khoa { get; set; }
        [MoTaDuLieu("Mã khoa")]
        public string MaKhoa { get; set; }
        [MoTaDuLieu("Phòng bệnh")]
        public string Phong { get; set; }
        [MoTaDuLieu("")]
        public string CC { get; set; }
        [MoTaDuLieu("Cân nặng")]
        public string CanNang { get; set; }
        [MoTaDuLieu("Cân nặng thay đổi theo KG")]
        public string CanNangThayDoi { get; set; }
        [MoTaDuLieu("Cân nặng thay đổi theo gam")]
        public string CanNangThayDoiG { get; set; }
        [MoTaDuLieu("Cân nặng tiêu chẩn đối với trẻ em")]
        public int TreEm { get; set; }
        [MoTaDuLieu("Cân nặng 6 tháng")]
        public int CanNang6T1 { get; set; }
        [MoTaDuLieu("Cân nặng 6 tháng")]
        public int CanNang6T2 { get; set; }
        [MoTaDuLieu("Cân nặng 6 tháng")]
        public int CanNang6T3 { get; set; }
        [MoTaDuLieu("Cân nặng trong 2 tuần")]
        public int CanNang2T1 { get; set; }
        [MoTaDuLieu("Cân nặng trong 2 tuần")]
        public int CanNang2T2 { get; set; }
        [MoTaDuLieu("Cân nặng trong 2 tuần")]
        public int CanNang2T3 { get; set; }
        [MoTaDuLieu("Khẩu phần ăn thay đổi")]
        public int KhauPhanAn { get; set; }
        [MoTaDuLieu("Tình trạng khẩu phần ăn")]
        public int KhauPhanAn1 { get; set; }
        [MoTaDuLieu("Tình trạng khẩu phần ăn")]
        public int KhauPhanAn2 { get; set; }
        [MoTaDuLieu("Tình trạng khẩu phần ăn")]
        public int KhauPhanAn3 { get; set; }
        [MoTaDuLieu("Triệu chứng")]
        public int TrieuChung { get; set; }
        [MoTaDuLieu("Triệu chứng")]
        public int TrieuChung1 { get; set; }
        [MoTaDuLieu("Triệu chứng")]
        public int TrieuChung2 { get; set; }
        [MoTaDuLieu("Triệu chứng")]
        public int TrieuChung3 { get; set; }
        [MoTaDuLieu("Giảm chức năng tiêu hóa")]
        public int GiamChucNang { get; set; }
        [MoTaDuLieu("Giảm chức năng tiêu hóa")]
        public int GiamChucNang1 { get; set; }
        [MoTaDuLieu("Giảm chức năng tiêu hóa")]
        public int GiamChucNang2 { get; set; }
        [MoTaDuLieu("Giảm chức năng tiêu hóa")]
        public int GiamChucNang3 { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
        public string ChanDoanBenh { get; set; }
        [MoTaDuLieu("Mức độ Stress")]
        public string MucDoStress { get; set; }
        [MoTaDuLieu("Nhu cầu chuyển hóa")]
        public int ChuyenHoa1 { get; set; }
        [MoTaDuLieu("Nhu cầu chuyển hóa")]
        public int ChuyenHoa2 { get; set; }
        [MoTaDuLieu("Nhu cầu chuyển hóa")]
        public int ChuyenHoa3 { get; set; }
        [MoTaDuLieu("Tình trạng mỡ dưới da")]
        public int MoDuoiDa1 { get; set; }
        [MoTaDuLieu("Tình trạng mỡ dưới da")]
        public int MoDuoiDa2 { get; set; }
        [MoTaDuLieu("")]
        public int MoDuoiDa3 { get; set; }
        [MoTaDuLieu("Tình trạng mỡ dưới da")]
        public int TeoCo1 { get; set; }
        [MoTaDuLieu("Tình trạng teo cơ")]
        public int TeoCo2 { get; set; }
        [MoTaDuLieu("Tình trạng teo cơ")]
        public int TeoCo3 { get; set; }
        [MoTaDuLieu("Tình trạng teo cơ")]
        public int Phu1 { get; set; }
        [MoTaDuLieu("Tình trạng teo cơ")]
        public int Phu2 { get; set; }
        [MoTaDuLieu("Tình trạng teo cơ")]
        public int Phu3 { get; set; }
        [MoTaDuLieu("Tình trạng phù")]
        public int CoChuong1 { get; set; }
        [MoTaDuLieu("Tình trạng phù")]
        public int CoChuong2 { get; set; }
        [MoTaDuLieu("Tình trạng phù")]
        public int CoChuong3 { get; set; }
        [MoTaDuLieu("Tình trạng phù")]
        public string TongSoDiem { get; set; }
        [MoTaDuLieu("Tổng điểm SGA")]
        public int NguyCo { get; set; }
        [MoTaDuLieu("Nguy cơ")]
        public string DanhGia { get; set; }
        [MoTaDuLieu("Đánh giá tình trạng dinh dưỡng")]
        public string Protein { get; set; }
        [MoTaDuLieu("Xét nghiệm Protein")]
        public string Albumin { get; set; }
        [MoTaDuLieu("Xét nghiệm Lymphocyte")]
        public string Lymphocyte { get; set; }
        [MoTaDuLieu("Xét nghiệm khác")]
        public string XNKhac { get; set; }
        [MoTaDuLieu("Xét nghiệm khác 1")]
        public string XNKhac1 { get; set; }
        [MoTaDuLieu("Xét nghiệm khác 2")]
        public string XNKhac2 { get; set; }
        [MoTaDuLieu("Chế độ ăn")]
        public string CheDoAn { get; set; }
        [MoTaDuLieu("Đường nuôi dưỡng")]
        public int DuoiNuoiDuong { get; set; }
        [MoTaDuLieu("Hội chẩn dinh dưỡng")]
        public int HoiChanDinhDuong { get; set; }
        [MoTaDuLieu("Chuẩn bị phẫu thuật")]
        public int ChuanBiPhauThuat { get; set; }
        [MoTaDuLieu("Theo dõi")]
        public int TheoDoi { get; set; }
        [MoTaDuLieu("Bác sỹ điều trị")]
        public string NguoiDanhGia { get; set; }
        public string MaNguoiDanhGia { get; set; }
        [MoTaDuLieu("Bác sỹ điều trị")]
		public string BacSiDieuTri { get; set; }
        public string MaBacSiDieuTri { get; set; }
        public DateTime ThoiGian { get; set; }
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

    public class PhieuDanhGiaTinhTrangDinhDuongSGAFunc
    {
        public const string TableName = "PhieuDanhGiaTinhTDDSGA";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuDanhGiaTinhTrangDinhDuongSGA> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuDanhGiaTinhTrangDinhDuongSGA> list = new List<PhieuDanhGiaTinhTrangDinhDuongSGA>();
            try
            {
                string sql = @"SELECT * FROM PhieuDanhGiaTinhTDDSGA where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuDanhGiaTinhTrangDinhDuongSGA data = new PhieuDanhGiaTinhTrangDinhDuongSGA();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.HoTenBN = Common.ConDBNull(DataReader["HoTenBN"]);
                    data.Tuoi = Common.ConDBNull(DataReader["Tuoi"]);
                    data.MaSoBN = Common.ConDBNull(DataReader["MaSoBN"]);
                    data.Khoa = Common.ConDBNull(DataReader["Khoa"]);
                    data.MaKhoa = Common.ConDBNull(DataReader["MaKhoa"]);
                    data.Phong = Common.ConDBNull(DataReader["Phong"]);
                    data.CC = Common.ConDBNull(DataReader["CC"]); 
                    data.CanNang = Common.ConDBNull(DataReader["CanNang"]);
                    data.CanNangThayDoi = Common.ConDBNull(DataReader["CanNangThayDoi"]);
                    data.CanNangThayDoiG = Common.ConDBNull(DataReader["CanNangThayDoiG"]);
                    data.TreEm = Common.ConDB_Int(DataReader["TreEm"]);
                    data.CanNang6T1 = Common.ConDB_Int(DataReader["CanNang6T1"]);
                    data.CanNang6T2 = Common.ConDB_Int(DataReader["CanNang6T2"]);
                    data.CanNang6T3 = Common.ConDB_Int(DataReader["CanNang6T3"]);
                    data.CanNang2T1 = Common.ConDB_Int(DataReader["CanNang2T1"]);
                    data.CanNang2T2 = Common.ConDB_Int(DataReader["CanNang2T2"]);
                    data.CanNang2T3 = Common.ConDB_Int(DataReader["CanNang2T3"]);
                    data.KhauPhanAn = Common.ConDB_Int(DataReader["KhauPhanAn"]);
                    data.KhauPhanAn1 = Common.ConDB_Int(DataReader["KhauPhanAn1"]);
                    data.KhauPhanAn2 = Common.ConDB_Int(DataReader["KhauPhanAn2"]);
                    data.KhauPhanAn3 = Common.ConDB_Int(DataReader["KhauPhanAn3"]);
                    data.TrieuChung = Common.ConDB_Int(DataReader["TrieuChung"]);
                    data.TrieuChung1 = Common.ConDB_Int(DataReader["TrieuChung1"]);
                    data.TrieuChung2 = Common.ConDB_Int(DataReader["TrieuChung2"]);
                    data.TrieuChung3 = Common.ConDB_Int(DataReader["TrieuChung3"]);
                    data.GiamChucNang = Common.ConDB_Int(DataReader["GiamChucNang"]);
                    data.GiamChucNang1 = Common.ConDB_Int(DataReader["GiamChucNang1"]);
                    data.GiamChucNang2 = Common.ConDB_Int(DataReader["GiamChucNang2"]);
                    data.GiamChucNang3 = Common.ConDB_Int(DataReader["GiamChucNang3"]);
                    data.ChanDoanBenh = Common.ConDBNull(DataReader["ChanDoanBenh"]);
                    data.MucDoStress = Common.ConDBNull(DataReader["MucDoStress"]);
                    data.ChuyenHoa1 = Common.ConDB_Int(DataReader["ChuyenHoa1"]);
                    data.ChuyenHoa2 = Common.ConDB_Int(DataReader["ChuyenHoa2"]);
                    data.ChuyenHoa3 = Common.ConDB_Int(DataReader["ChuyenHoa3"]);
                    data.MoDuoiDa1 = Common.ConDB_Int(DataReader["MoDuoiDa1"]);
                    data.MoDuoiDa2 = Common.ConDB_Int(DataReader["MoDuoiDa2"]);
                    data.MoDuoiDa3 = Common.ConDB_Int(DataReader["MoDuoiDa3"]);
                    data.TeoCo1 = Common.ConDB_Int(DataReader["TeoCo1"]);
                    data.TeoCo2 = Common.ConDB_Int(DataReader["TeoCo2"]);
                    data.TeoCo3 = Common.ConDB_Int(DataReader["TeoCo3"]);
                    data.Phu1 = Common.ConDB_Int(DataReader["Phu1"]);
                    data.Phu2 = Common.ConDB_Int(DataReader["Phu2"]);
                    data.Phu3 = Common.ConDB_Int(DataReader["Phu3"]);
                    data.CoChuong1 = Common.ConDB_Int(DataReader["CoChuong1"]);
                    data.CoChuong2 = Common.ConDB_Int(DataReader["CoChuong2"]);
                    data.CoChuong3 = Common.ConDB_Int(DataReader["CoChuong3"]);
                    data.TongSoDiem = Common.ConDBNull(DataReader["TongSoDiem"]);
                    data.NguyCo = Common.ConDB_Int(DataReader["NguyCo"]);
                    data.DanhGia = Common.ConDBNull(DataReader["DanhGia"]);
                    data.Protein = Common.ConDBNull(DataReader["Protein"]);
                    data.Albumin = Common.ConDBNull(DataReader["Albumin"]);
                    data.Lymphocyte = Common.ConDBNull(DataReader["Lymphocyte"]);
                    data.XNKhac = Common.ConDBNull(DataReader["XNKhac"]);
                    data.XNKhac1 = Common.ConDBNull(DataReader["XNKhac1"]);
                    data.XNKhac2 = Common.ConDBNull(DataReader["XNKhac2"]);
                    data.CheDoAn = Common.ConDBNull(DataReader["CheDoAn"]);
                    data.DuoiNuoiDuong = Common.ConDB_Int(DataReader["DuoiNuoiDuong"]);
                    data.HoiChanDinhDuong = Common.ConDB_Int(DataReader["HoiChanDinhDuong"]);
                    data.ChuanBiPhauThuat = Common.ConDB_Int(DataReader["ChuanBiPhauThuat"]);
                    data.TheoDoi = Common.ConDB_Int(DataReader["TheoDoi"]);
                    data.NguoiDanhGia = Common.ConDBNull(DataReader["NguoiDanhGia"]);
                    data.MaNguoiDanhGia = Common.ConDBNull(DataReader["MaNguoiDanhGia"]);
                    data.BacSiDieuTri = Common.ConDBNull(DataReader["BacSiDieuTri"]);
                    data.MaBacSiDieuTri = Common.ConDBNull(DataReader["MaBacSiDieuTri"]);
                    data.ThoiGian = Common.ConDB_DateTime(DataReader["ThoiGian"]);
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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuDanhGiaTinhTrangDinhDuongSGA data)
        {
            try
            {
                string sql = @"INSERT INTO PhieuDanhGiaTinhTDDSGA
                (
                    MaQuanLy,
                    MaBenhNhan,
                    HoTenBN,
                    Tuoi,
                    MaSoBN,
                    Khoa,
                    MaKhoa,
                    Phong,
                    CC,
                    CanNang,
                    CanNangThayDoi,
                    CanNangThayDoiG,
                    TreEm,
                    CanNang6T1,
                    CanNang6T2,
                    CanNang6T3,
                    CanNang2T1,
                    CanNang2T2,
                    CanNang2T3,
                    KhauPhanAn,
                    KhauPhanAn1,
                    KhauPhanAn2,
                    KhauPhanAn3,
                    TrieuChung,
                    TrieuChung1,
                    TrieuChung2,
                    TrieuChung3,
                    GiamChucNang,
                    GiamChucNang1,
                    GiamChucNang2,
                    GiamChucNang3,
                    ChanDoanBenh,
                    MucDoStress,
                    ChuyenHoa1,
                    ChuyenHoa2,
                    ChuyenHoa3,
                    MoDuoiDa1,
                    MoDuoiDa2,
                    MoDuoiDa3,
                    TeoCo1,
                    TeoCo2,
                    TeoCo3,
                    Phu1,
                    Phu2,
                    Phu3,
                    CoChuong1,
                    CoChuong2,
                    CoChuong3,
                    TongSoDiem,
                    NguyCo,
                    DanhGia,
                    Protein,
                    Albumin,
                    Lymphocyte,
                    XNKhac,
                    XNKhac1,
                    XNKhac2,
                    CheDoAn,
                    DuoiNuoiDuong,
                    HoiChanDinhDuong,
                    ChuanBiPhauThuat,
                    TheoDoi,
                    NguoiDanhGia,
                    MaNguoiDanhGia,
                    BacSiDieuTri,
                    MaBacSiDieuTri,
                    ThoiGian,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
                    :MaQuanLy,
                    :MaBenhNhan,
                    :HoTenBN,
                    :Tuoi,
                    :MaSoBN,
                    :Khoa,
                    :MaKhoa,
                    :Phong,
                    :CC,
                    :CanNang,
                    :CanNangThayDoi,
                    :CanNangThayDoiG,
                    :TreEm,
                    :CanNang6T1,
                    :CanNang6T2,
                    :CanNang6T3,
                    :CanNang2T1,
                    :CanNang2T2,
                    :CanNang2T3,
                    :KhauPhanAn,
                    :KhauPhanAn1,
                    :KhauPhanAn2,
                    :KhauPhanAn3,
                    :TrieuChung,
                    :TrieuChung1,
                    :TrieuChung2,
                    :TrieuChung3,
                    :GiamChucNang,
                    :GiamChucNang1,
                    :GiamChucNang2,
                    :GiamChucNang3,
                    :ChanDoanBenh,
                    :MucDoStress,
                    :ChuyenHoa1,
                    :ChuyenHoa2,
                    :ChuyenHoa3,
                    :MoDuoiDa1,
                    :MoDuoiDa2,
                    :MoDuoiDa3,
                    :TeoCo1,
                    :TeoCo2,
                    :TeoCo3,
                    :Phu1,
                    :Phu2,
                    :Phu3,
                    :CoChuong1,
                    :CoChuong2,
                    :CoChuong3,
                    :TongSoDiem,
                    :NguyCo,
                    :DanhGia,
                    :Protein,
                    :Albumin,
                    :Lymphocyte,
                    :XNKhac,
                    :XNKhac1,
                    :XNKhac2,
                    :CheDoAn,
                    :DuoiNuoiDuong,
                    :HoiChanDinhDuong,
                    :ChuanBiPhauThuat,
                    :TheoDoi,
                    :NguoiDanhGia,
                    :MaNguoiDanhGia,
                    :BacSiDieuTri,
                    :MaBacSiDieuTri,
                    :ThoiGian,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (data.ID != 0)
                {
                    sql = @"UPDATE PhieuDanhGiaTinhTDDSGA SET 
                    MaQuanLy=:MaQuanLy,
                    MaBenhNhan=:MaBenhNhan,
                    HoTenBN=:HoTenBN,
                    Tuoi=:Tuoi,
                    MaSoBN=:MaSoBN,
                    Khoa=:Khoa,
                    MaKhoa=:MaKhoa,
                    Phong=:Phong,
                    CC=:CC,
                    CanNang=:CanNang,
                    CanNangThayDoi=:CanNangThayDoi,
                    CanNangThayDoiG=:CanNangThayDoiG,
                    TreEm=:TreEm,
                    CanNang6T1=:CanNang6T1,
                    CanNang6T2=:CanNang6T2,
                    CanNang6T3=:CanNang6T3,
                    CanNang2T1=:CanNang2T1,
                    CanNang2T2=:CanNang2T2,
                    CanNang2T3=:CanNang2T3,
                    KhauPhanAn=:KhauPhanAn,
                    KhauPhanAn1=:KhauPhanAn1,
                    KhauPhanAn2=:KhauPhanAn2,
                    KhauPhanAn3=:KhauPhanAn3,
                    TrieuChung=:TrieuChung,
                    TrieuChung1=:TrieuChung1,
                    TrieuChung2=:TrieuChung2,
                    TrieuChung3=:TrieuChung3,
                    GiamChucNang=:GiamChucNang,
                    GiamChucNang1=:GiamChucNang1,
                    GiamChucNang2=:GiamChucNang2,
                    GiamChucNang3=:GiamChucNang3,
                    ChanDoanBenh=:ChanDoanBenh,
                    MucDoStress=:MucDoStress,
                    ChuyenHoa1=:ChuyenHoa1,
                    ChuyenHoa2=:ChuyenHoa2,
                    ChuyenHoa3=:ChuyenHoa3,
                    MoDuoiDa1=:MoDuoiDa1,
                    MoDuoiDa2=:MoDuoiDa2,
                    MoDuoiDa3=:MoDuoiDa3,
                    TeoCo1=:TeoCo1,
                    TeoCo2=:TeoCo2,
                    TeoCo3=:TeoCo3,
                    Phu1=:Phu1,
                    Phu2=:Phu2,
                    Phu3=:Phu3,
                    CoChuong1=:CoChuong1,
                    CoChuong2=:CoChuong2,
                    CoChuong3=:CoChuong3,
                    TongSoDiem=:TongSoDiem,
                    NguyCo=:NguyCo,
                    DanhGia=:DanhGia,
                    Protein=:Protein,
                    Albumin=:Albumin,
                    Lymphocyte=:Lymphocyte,
                    XNKhac=:XNKhac,
                    XNKhac1=:XNKhac1,
                    XNKhac2=:XNKhac2,
                    CheDoAn=:CheDoAn,
                    DuoiNuoiDuong=:DuoiNuoiDuong,
                   HoiChanDinhDuong=:HoiChanDinhDuong,
                    ChuanBiPhauThuat=:ChuanBiPhauThuat,
                    TheoDoi=:TheoDoi,
                   NguoiDanhGia=:NguoiDanhGia,
                    MaNguoiDanhGia=:MaNguoiDanhGia,
                   BacSiDieuTri=:BacSiDieuTri,
                    MaBacSiDieuTri=:MaBacSiDieuTri,
                    ThoiGian=:ThoiGian,
                    NGUOISUA=:NGUOISUA,
                    NGAYSUA=:NGAYSUA
                    WHERE ID = " + data.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", data.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", data.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("HoTenBN", data.HoTenBN));
                Command.Parameters.Add(new MDB.MDBParameter("Tuoi", data.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("MaSoBN", data.MaSoBN));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa", data.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaKhoa", data.MaKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("Phong", data.Phong));
                Command.Parameters.Add(new MDB.MDBParameter("CC", data.CC));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang", data.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("CanNangThayDoi", data.CanNangThayDoi));
                Command.Parameters.Add(new MDB.MDBParameter("CanNangThayDoiG", data.CanNangThayDoiG));
                Command.Parameters.Add(new MDB.MDBParameter("TreEm", data.TreEm));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang6T1", data.CanNang6T1));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang6T2", data.CanNang6T2));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang6T3", data.CanNang6T3));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang2T1", data.CanNang2T1));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang2T2", data.CanNang2T2));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang2T3", data.CanNang2T3));
                Command.Parameters.Add(new MDB.MDBParameter("KhauPhanAn", data.KhauPhanAn));
                Command.Parameters.Add(new MDB.MDBParameter("KhauPhanAn1", data.KhauPhanAn1));
                Command.Parameters.Add(new MDB.MDBParameter("KhauPhanAn2", data.KhauPhanAn2));
                Command.Parameters.Add(new MDB.MDBParameter("KhauPhanAn3", data.KhauPhanAn3));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChung", data.TrieuChung));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChung1", data.TrieuChung1));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChung2", data.TrieuChung2));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChung3", data.TrieuChung3));
                Command.Parameters.Add(new MDB.MDBParameter("GiamChucNang", data.GiamChucNang));
                Command.Parameters.Add(new MDB.MDBParameter("GiamChucNang1", data.GiamChucNang1));
                Command.Parameters.Add(new MDB.MDBParameter("GiamChucNang2", data.GiamChucNang2));
                Command.Parameters.Add(new MDB.MDBParameter("GiamChucNang3", data.GiamChucNang3));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanBenh", data.ChanDoanBenh));
                Command.Parameters.Add(new MDB.MDBParameter("MucDoStress", data.MucDoStress));
                Command.Parameters.Add(new MDB.MDBParameter("ChuyenHoa1", data.ChuyenHoa1));
                Command.Parameters.Add(new MDB.MDBParameter("ChuyenHoa2", data.ChuyenHoa2));
                Command.Parameters.Add(new MDB.MDBParameter("ChuyenHoa3", data.ChuyenHoa3));
                Command.Parameters.Add(new MDB.MDBParameter("MoDuoiDa1", data.MoDuoiDa1));
                Command.Parameters.Add(new MDB.MDBParameter("MoDuoiDa2", data.MoDuoiDa2));
                Command.Parameters.Add(new MDB.MDBParameter("MoDuoiDa3", data.MoDuoiDa3));
                Command.Parameters.Add(new MDB.MDBParameter("TeoCo1", data.TeoCo1));
                Command.Parameters.Add(new MDB.MDBParameter("TeoCo2", data.TeoCo2));
                Command.Parameters.Add(new MDB.MDBParameter("TeoCo3", data.TeoCo3));
                Command.Parameters.Add(new MDB.MDBParameter("Phu1", data.Phu1));
                Command.Parameters.Add(new MDB.MDBParameter("Phu2", data.Phu2));
                Command.Parameters.Add(new MDB.MDBParameter("Phu3", data.Phu3));
                Command.Parameters.Add(new MDB.MDBParameter("CoChuong1", data.CoChuong1));
                Command.Parameters.Add(new MDB.MDBParameter("CoChuong2", data.CoChuong2));
                Command.Parameters.Add(new MDB.MDBParameter("CoChuong3", data.CoChuong3));
                Command.Parameters.Add(new MDB.MDBParameter("TongSoDiem", data.TongSoDiem));
                Command.Parameters.Add(new MDB.MDBParameter("NguyCo", data.NguyCo));
                Command.Parameters.Add(new MDB.MDBParameter("DanhGia", data.DanhGia));
                Command.Parameters.Add(new MDB.MDBParameter("Protein", data.Protein));
                Command.Parameters.Add(new MDB.MDBParameter("Albumin", data.Albumin));
                Command.Parameters.Add(new MDB.MDBParameter("Lymphocyte", data.Lymphocyte));
                Command.Parameters.Add(new MDB.MDBParameter("XNKhac", data.XNKhac));
                Command.Parameters.Add(new MDB.MDBParameter("XNKhac1", data.XNKhac1));
                Command.Parameters.Add(new MDB.MDBParameter("XNKhac2", data.XNKhac2));
                Command.Parameters.Add(new MDB.MDBParameter("CheDoAn", data.CheDoAn));
                Command.Parameters.Add(new MDB.MDBParameter("DuoiNuoiDuong", data.DuoiNuoiDuong));
                Command.Parameters.Add(new MDB.MDBParameter("HoiChanDinhDuong", data.HoiChanDinhDuong));
                Command.Parameters.Add(new MDB.MDBParameter("ChuanBiPhauThuat", data.ChuanBiPhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("TheoDoi", data.TheoDoi));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiDanhGia", data.NguoiDanhGia));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiDanhGia", data.MaNguoiDanhGia));
                Command.Parameters.Add(new MDB.MDBParameter("BacSiDieuTri", data.BacSiDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSiDieuTri", data.MaBacSiDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGian", data.ThoiGian));
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
                string sql = "DELETE FROM PhieuDanhGiaTinhTDDSGA WHERE ID = :ID";
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
                PhieuDanhGiaTinhTDDSGA P
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
