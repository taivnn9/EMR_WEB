using EMR.KyDienTu;
using EMR_MAIN.DATABASE.BenhAn;
using Newtonsoft.Json;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;

namespace EMR_MAIN.DATABASE.Other
{
    public class TaiKhamPhoiTacNghenManTinh : ThongTinKy
    {
        // bắt buộc tạo contructor
        public TaiKhamPhoiTacNghenManTinh()
        {
            TableName = "TaiKhamPhoiTacNghenManTinh";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.TKBAPTNMT;
            TenMauPhieu = DanhMucPhieu.TKBAPTNMT.Description();
        }
        // bắt buộc phải có trường, ID, MaQuanLy, MaBenhNhan
        [MoTaDuLieu("Mã định danh")]
        public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau", "", 1)]
        public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
        public string MaBenhNhan { get; set; }
        public string HoTenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
        public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
        public string GioiTinh { get; set; }
        [MoTaDuLieu("Tái khám lần")]
        public string TaiKhamLan { get; set; }
        public DateTime? NgayKham { get; set; }
        //Triệu chứng bệnh:
        [MoTaDuLieu("Triệu chứng bệnh, ho, 1-> không, 2-> ít, 3-> nhiều")]
        public int TrieuChungBenh_Ho { get; set; }
        [MoTaDuLieu("Triệu chứng bệnh, Khạc đờm, 1-> không, 2-> ít, 3-> nhiều")]
        public int TrieuChungBenh_KhacDom { get; set; }
        [MoTaDuLieu("Triệu chứng bệnh, Dờm màu")]
        public string TrieuChungBenh_DomMau { get; set; }
        [MoTaDuLieu("Triệu chứng bệnh, Khò khè, 1-> không, 2-> ít, 3-> nhiều")]
        public int TrieuChungBenh_KhoKhe { get; set; }
        [MoTaDuLieu("Triệu chứng bệnh, Khó thở, 1-> không, 2-> ít, 3-> nhiều")]
        public int TrieuChungBenh_KhoTho { get; set; }
        [MoTaDuLieu("Triệu chứng bệnh, nặng ngực, 1-> không, 2-> ít, 3-> nhiều")]
        public int TrieuChungBenh_NangNguc { get; set; }
        [MoTaDuLieu("8. Mức độ khó thở phân theo loại Medical Research Council:")]
        public int MucDoKhoTho { get; set; }

        //3. Tuân thủ điều trị
        //Liều lượng:
        [MoTaDuLieu("1. Đúng liều")]
        public int DungLieu { get; set; }
        [MoTaDuLieu("2.Tự giảm liều")]
        public int TuGiamLieu { get; set; }
        [MoTaDuLieu("3.Chỉ sử dụng khi có cơn")]
        public int ChiSuDungKhiCoCon { get; set; }
        [MoTaDuLieu("4. Ngưng điều trị")]
        public int NgungDieuTri { get; set; }
        [MoTaDuLieu("Kỹ năng sử dụng thuốc, 1-> đúng cách, 2 -> không đúng cách")]
        public int KyNangSuDungThuoc { get; set; }

        //III. KHÁM LÂM SÀNG
        [MoTaDuLieu("Mạch")]
        public string Mach { get; set; }
        [MoTaDuLieu("Huyết áp")]
        public string HuyetAp { get; set; }
        [MoTaDuLieu("Nhiệt độ")]
        public string NhietDo { get; set; }
        [MoTaDuLieu("Nhịp thở")]
        public string NhipTho { get; set; }

        [MoTaDuLieu("Phổi, bình thường")]
        public int Phoi_BinhThuong { get; set; }
        [MoTaDuLieu("Phổi, 1.RRFN giảm")]
        public int Phoi_RRFNGiam { get; set; }
        [MoTaDuLieu("Phổi, 2.Ran rít, ran ngáy")]
        public int Phoi_RanRitRanNgay { get; set; }
        [MoTaDuLieu("Phổi, 2.Ran nổ, ẩm")]
        public int Phoi_RanNoAm { get; set; }
        [MoTaDuLieu("Phổi, 4. Khác")]
        public int Phoi_Khac { get; set; }
        [MoTaDuLieu("Phổi, 4. Khác (cụ thể)")]
        public string Phoi_Khac_CuThe { get; set; }
        [MoTaDuLieu("Cơ quan khác:")]
        public string CoQuanKhac { get; set; }

        //IV. CẬN LÂM SÀNG:
        [MoTaDuLieu("2. Đo chức năng hô hấp (% so với chỉ số dự đoán)")]
        public ObservableCollection<DoChucNangHoHap> DoChucNangHoHaps { get; set; }

        [MoTaDuLieu("3. X-quang phổi")]
        public string XQuangPhoi { get; set; }
        [MoTaDuLieu("4. Điện tâm đồ/Siêu âm tim")]
        public string DTD_SAT { get; set; }
        [MoTaDuLieu("5. Xét nghiệm khác")]
        public string XetNghiemKhac { get; set; }
        //VI. CHẨN ĐOÁN:
        [MoTaDuLieu("1. Chẩn đoán xác định: COPD, giai đoạn 1")]
        public int ChanDoan_COPD_1 { get; set; }
        [MoTaDuLieu("1. Chẩn đoán xác định: COPD, giai đoạn 2")]
        public int ChanDoan_COPD_2 { get; set; }
        [MoTaDuLieu("1. Chẩn đoán xác định: COPD, giai đoạn 3")]
        public int ChanDoan_COPD_3 { get; set; }
        [MoTaDuLieu("1. Chẩn đoán xác định: COPD, giai đoạn 4")]
        public int ChanDoan_COPD_4 { get; set; }
        [MoTaDuLieu("2. Bệnh phối hợp:")]
        public string BenhPhoiHop { get; set; }
        [MoTaDuLieu("VII. ĐIỀU TRỊ:")]
        public string DieuTri { get; set; }


        [MoTaDuLieu("Bác sỹ điều trị")]
        public string BacSyDieuTri { get; set; }

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
    public class TaiKhamPhoiTacNghenManTinhFunc
    {
        public const string TableName = "TaiKhamPhoiTacNghenManTinh";
        public const string TablePrimaryKeyName = "ID";
        public static List<TaiKhamPhoiTacNghenManTinh> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<TaiKhamPhoiTacNghenManTinh> list = new List<TaiKhamPhoiTacNghenManTinh>();
            try
            {
                string sql = @"SELECT * FROM TaiKhamPhoiTacNghenManTinh where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    TaiKhamPhoiTacNghenManTinh data = new TaiKhamPhoiTacNghenManTinh();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.HoTenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.TaiKhamLan = DataReader["TaiKhamLan"].ToString();
                    data.NgayKham = DataReader["NgayKham"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayKham"].ToString()) : null;
                    data.TrieuChungBenh_Ho = DataReader.GetInt("TrieuChungBenh_Ho");
                    data.TrieuChungBenh_KhacDom = DataReader.GetInt("TrieuChungBenh_KhacDom");
                    data.TrieuChungBenh_DomMau = DataReader["TrieuChungBenh_DomMau"].ToString();
                    data.TrieuChungBenh_KhoKhe = DataReader.GetInt("TrieuChungBenh_KhoKhe");
                    data.TrieuChungBenh_KhoTho = DataReader.GetInt("TrieuChungBenh_KhoTho");
                    data.TrieuChungBenh_NangNguc = DataReader.GetInt("TrieuChungBenh_NangNguc");
                    data.MucDoKhoTho = DataReader.GetInt("MucDoKhoTho");
                    data.DungLieu = DataReader.GetInt("DungLieu");
                    data.TuGiamLieu = DataReader.GetInt("TuGiamLieu");
                    data.ChiSuDungKhiCoCon = DataReader.GetInt("ChiSuDungKhiCoCon");
                    data.NgungDieuTri = DataReader.GetInt("NgungDieuTri");
                    data.KyNangSuDungThuoc = DataReader.GetInt("KyNangSuDungThuoc");
                    data.Mach = DataReader["Mach"].ToString();
                    data.HuyetAp = DataReader["HuyetAp"].ToString();
                    data.NhietDo = DataReader["NhietDo"].ToString();
                    data.NhipTho = DataReader["NhipTho"].ToString();
                    data.Phoi_BinhThuong = DataReader.GetInt("Phoi_BinhThuong");
                    data.Phoi_RRFNGiam = DataReader.GetInt("Phoi_RRFNGiam");
                    data.Phoi_RanRitRanNgay = DataReader.GetInt("Phoi_RanRitRanNgay");
                    data.Phoi_RanNoAm = DataReader.GetInt("Phoi_RanNoAm");
                    data.Phoi_Khac = DataReader.GetInt("Phoi_Khac");
                    data.Phoi_Khac_CuThe = DataReader["Phoi_Khac_CuThe"].ToString();
                    data.CoQuanKhac = DataReader["CoQuanKhac"].ToString();
                    data.DoChucNangHoHaps = JsonConvert.DeserializeObject<ObservableCollection<DoChucNangHoHap>>(DataReader["DoChucNangHoHaps"].ToString());
                    data.XQuangPhoi = DataReader["XQuangPhoi"].ToString();
                    data.DTD_SAT = DataReader["DTD_SAT"].ToString();
                    data.XetNghiemKhac = DataReader["XetNghiemKhac"].ToString();
                    data.ChanDoan_COPD_1 = DataReader.GetInt("ChanDoan_COPD_1");
                    data.ChanDoan_COPD_2 = DataReader.GetInt("ChanDoan_COPD_2");
                    data.ChanDoan_COPD_3 = DataReader.GetInt("ChanDoan_COPD_3");
                    data.ChanDoan_COPD_4 = DataReader.GetInt("ChanDoan_COPD_4");
                    data.BenhPhoiHop = DataReader["BenhPhoiHop"].ToString();
                    data.DieuTri = DataReader["DieuTri"].ToString();
                    data.BacSyDieuTri = DataReader["BacSyDieuTri"].ToString();

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref TaiKhamPhoiTacNghenManTinh ketQua)
        {
            try
            {
                string sql = @"INSERT INTO TaiKhamPhoiTacNghenManTinh
                (
                    MAQUANLY,
                    MaBenhNhan,
                    TaiKhamLan,
                    NgayKham,
                    TrieuChungBenh_Ho,
                    TrieuChungBenh_KhacDom,
                    TrieuChungBenh_DomMau,
                    TrieuChungBenh_KhoKhe,
                    TrieuChungBenh_KhoTho,
                    TrieuChungBenh_NangNguc,
                    MucDoKhoTho,
                    DungLieu,
                    TuGiamLieu,
                    ChiSuDungKhiCoCon,
                    NgungDieuTri,
                    KyNangSuDungThuoc,
                    Mach,
                    HuyetAp,
                    NhietDo,
                    NhipTho,
                    Phoi_BinhThuong,
                    Phoi_RRFNGiam,
                    Phoi_RanRitRanNgay,
                    Phoi_RanNoAm,
                    Phoi_Khac,
                    Phoi_Khac_CuThe,
                    CoQuanKhac,
                    DoChucNangHoHaps,
                    XQuangPhoi,
                    DTD_SAT,
                    XetNghiemKhac,
                    ChanDoan_COPD_1,
                    ChanDoan_COPD_2,
                    ChanDoan_COPD_3,
                    ChanDoan_COPD_4,
                    BenhPhoiHop,
                    DieuTri,
                    BacSyDieuTri,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :TaiKhamLan,
                    :NgayKham,
                    :TrieuChungBenh_Ho,
                    :TrieuChungBenh_KhacDom,
                    :TrieuChungBenh_DomMau,
                    :TrieuChungBenh_KhoKhe,
                    :TrieuChungBenh_KhoTho,
                    :TrieuChungBenh_NangNguc,
                    :MucDoKhoTho,
                    :DungLieu,
                    :TuGiamLieu,
                    :ChiSuDungKhiCoCon,
                    :NgungDieuTri,
                    :KyNangSuDungThuoc,
                    :Mach,
                    :HuyetAp,
                    :NhietDo,
                    :NhipTho,
                    :Phoi_BinhThuong,
                    :Phoi_RRFNGiam,
                    :Phoi_RanRitRanNgay,
                    :Phoi_RanNoAm,
                    :Phoi_Khac,
                    :Phoi_Khac_CuThe,
                    :CoQuanKhac,
                    :DoChucNangHoHaps,
                    :XQuangPhoi,
                    :DTD_SAT,
                    :XetNghiemKhac,
                    :ChanDoan_COPD_1,
                    :ChanDoan_COPD_2,
                    :ChanDoan_COPD_3,
                    :ChanDoan_COPD_4,
                    :BenhPhoiHop,
                    :DieuTri,
                    :BacSyDieuTri,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE TaiKhamPhoiTacNghenManTinh SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    TaiKhamLan = :TaiKhamLan,
                    NgayKham = :NgayKham,
                    TrieuChungBenh_Ho=:TrieuChungBenh_Ho,
                    TrieuChungBenh_KhacDom=:TrieuChungBenh_KhacDom,
                    TrieuChungBenh_DomMau=:TrieuChungBenh_DomMau,
                    TrieuChungBenh_KhoKhe=:TrieuChungBenh_KhoKhe,
                    TrieuChungBenh_KhoTho=:TrieuChungBenh_KhoTho,
                    TrieuChungBenh_NangNguc=:TrieuChungBenh_NangNguc,
                    MucDoKhoTho=:MucDoKhoTho,
                    DungLieu=:DungLieu,
                    TuGiamLieu=:TuGiamLieu,
                    ChiSuDungKhiCoCon=:ChiSuDungKhiCoCon,
                    NgungDieuTri=:NgungDieuTri,
                    KyNangSuDungThuoc=:KyNangSuDungThuoc,
                    Mach=:Mach,
                    HuyetAp=:HuyetAp,
                    NhietDo=:NhietDo,
                    NhipTho=:NhipTho,
                    Phoi_BinhThuong=:Phoi_BinhThuong,
                    Phoi_RRFNGiam=:Phoi_RRFNGiam,
                    Phoi_RanRitRanNgay=:Phoi_RanRitRanNgay,
                    Phoi_RanNoAm=:Phoi_RanNoAm,
                    Phoi_Khac=:Phoi_Khac,
                    Phoi_Khac_CuThe=:Phoi_Khac_CuThe,
                    CoQuanKhac=:CoQuanKhac,
                    DoChucNangHoHaps=:DoChucNangHoHaps,
                    XQuangPhoi=:XQuangPhoi,
                    DTD_SAT=:DTD_SAT,
                    XetNghiemKhac=:XetNghiemKhac,
                    ChanDoan_COPD_1=:ChanDoan_COPD_1,
                    ChanDoan_COPD_2=:ChanDoan_COPD_2,
                    ChanDoan_COPD_3=:ChanDoan_COPD_3,
                    ChanDoan_COPD_4=:ChanDoan_COPD_4,
                    BenhPhoiHop=:BenhPhoiHop,
                    DieuTri=:DieuTri,
                    BacSyDieuTri=:BacSyDieuTri,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ketQua.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("TaiKhamLan", ketQua.TaiKhamLan));
                Command.Parameters.Add(new MDB.MDBParameter("NgayKham", ketQua.NgayKham));

                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungBenh_Ho", ketQua.TrieuChungBenh_Ho));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungBenh_KhacDom", ketQua.TrieuChungBenh_KhacDom));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungBenh_DomMau", ketQua.TrieuChungBenh_DomMau));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungBenh_KhoKhe", ketQua.TrieuChungBenh_KhoKhe));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungBenh_KhoTho", ketQua.TrieuChungBenh_KhoTho));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungBenh_NangNguc", ketQua.TrieuChungBenh_NangNguc));
                Command.Parameters.Add(new MDB.MDBParameter("MucDoKhoTho", ketQua.MucDoKhoTho));
                Command.Parameters.Add(new MDB.MDBParameter("DungLieu", ketQua.DungLieu));
                Command.Parameters.Add(new MDB.MDBParameter("TuGiamLieu", ketQua.TuGiamLieu));
                Command.Parameters.Add(new MDB.MDBParameter("ChiSuDungKhiCoCon", ketQua.ChiSuDungKhiCoCon));
                Command.Parameters.Add(new MDB.MDBParameter("NgungDieuTri", ketQua.NgungDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("KyNangSuDungThuoc", ketQua.KyNangSuDungThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("Mach", ketQua.Mach));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetAp", ketQua.HuyetAp));
                Command.Parameters.Add(new MDB.MDBParameter("NhietDo", ketQua.NhietDo));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTho", ketQua.NhipTho));
                Command.Parameters.Add(new MDB.MDBParameter("Phoi_BinhThuong", ketQua.Phoi_BinhThuong));
                Command.Parameters.Add(new MDB.MDBParameter("Phoi_RRFNGiam", ketQua.Phoi_RRFNGiam));
                Command.Parameters.Add(new MDB.MDBParameter("Phoi_RanRitRanNgay", ketQua.Phoi_RanRitRanNgay));
                Command.Parameters.Add(new MDB.MDBParameter("Phoi_RanNoAm", ketQua.Phoi_RanNoAm));
                Command.Parameters.Add(new MDB.MDBParameter("Phoi_Khac", ketQua.Phoi_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("Phoi_Khac_CuThe", ketQua.Phoi_Khac_CuThe));
                Command.Parameters.Add(new MDB.MDBParameter("CoQuanKhac", ketQua.CoQuanKhac));
                Command.Parameters.Add(new MDB.MDBParameter("DoChucNangHoHaps", JsonConvert.SerializeObject(ketQua.DoChucNangHoHaps)));
                Command.Parameters.Add(new MDB.MDBParameter("XQuangPhoi", ketQua.XQuangPhoi));
                Command.Parameters.Add(new MDB.MDBParameter("DTD_SAT", ketQua.DTD_SAT));
                Command.Parameters.Add(new MDB.MDBParameter("XetNghiemKhac", ketQua.XetNghiemKhac));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan_COPD_1", ketQua.ChanDoan_COPD_1));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan_COPD_2", ketQua.ChanDoan_COPD_2));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan_COPD_3", ketQua.ChanDoan_COPD_3));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan_COPD_4", ketQua.ChanDoan_COPD_4));
                Command.Parameters.Add(new MDB.MDBParameter("BenhPhoiHop", ketQua.BenhPhoiHop));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri", ketQua.DieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", ketQua.BacSyDieuTri));

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
                string sql = "DELETE FROM TaiKhamPhoiTacNghenManTinh WHERE ID = :ID";
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
                P.*, f.hovaten BacSyDieuTriHoVaTen
            FROM
                TaiKhamPhoiTacNghenManTinh P
            left join nhanvien f on P.BacSyDieuTri = f.manhanvien 
            WHERE
                P.ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds);

            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));
            ds.Tables[0].AddColumn("NamSinh", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(string));
            ds.Tables[0].AddColumn("SOYTE", typeof(string));
            ds.Tables[0].AddColumn("BENHVIEN", typeof(string));
            ds.Tables[0].AddColumn("KHOA", typeof(string));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["NamSinh"] = XemBenhAn._HanhChinhBenhNhan.NgaySinh.HasValue ? XemBenhAn._HanhChinhBenhNhan.NgaySinh.Value.Year + "" : "";
            ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            ds.Tables[0].Rows[0]["SOYTE"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["KHOA"] = XemBenhAn._ThongTinDieuTri.Khoa;

            ObservableCollection<DoChucNangHoHap> DoChucNangHoHaps = JsonConvert.DeserializeObject<ObservableCollection<DoChucNangHoHap>>(ds.Tables[0].Rows[0]["DoChucNangHoHaps"].ToString());
            ds.Tables.Add(Common.ListToDataTable(DoChucNangHoHaps.ToList(), "DoChucNangHoHaps"));


            return ds;
        }
    }
}
