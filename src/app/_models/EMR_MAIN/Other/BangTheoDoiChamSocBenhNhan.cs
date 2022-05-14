using EMR.KyDienTu;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using PMS.Access;
using PMS.Access;
namespace EMR_MAIN.DATABASE.Other
{
    // phần góc dưới bên trái
    public class GhiChuGio
    {
        [MoTaDuLieu("Giờ")]
        public int Gio { get; set; }
        [MoTaDuLieu("Ghi chú")]
		public string GhiChu { get; set; }
    }
    public class ThongTinRieng
    {
        [MoTaDuLieu("Tên")]
        public string Ten { get; set; }
        [MoTaDuLieu("Ghi chú giờ")]
        public ObservableCollection<GhiChuGio> GhiChus { get; set; }
    }
    // phần bên phải bệnh án
    public class PhuLuc1
    {
        [MoTaDuLieu("Giờ")]
        public DateTime Gio { get; set; }
        [MoTaDuLieu("Na+")]
        public string Na { get; set; }
        [MoTaDuLieu("K+/Cl-")]
        public string KCl { get; set; }
        [MoTaDuLieu("Calci")]
        public string Calci { get; set; }
        [MoTaDuLieu("Glucose")]
        public string Glucose { get; set; }
        [MoTaDuLieu("Ure")]
        public string Ure { get; set; }
        [MoTaDuLieu("Creatinin")]
        public string Creatinin { get; set; }
        [MoTaDuLieu("Albumim")]
        public string Albumim { get; set; }
        [MoTaDuLieu("Protein")]
        public string Protein { get; set; }
        [MoTaDuLieu("GOT/GPT")]
        public string GOTGPT { get; set; }
        [MoTaDuLieu("CK")]
        public string CK { get; set; }
        [MoTaDuLieu("CKMB")]
        public string CKMB { get; set; }
        [MoTaDuLieu("Troponin")]
        public string Troponin { get; set; }

        public PhuLuc1 Clone(PhuLuc1 obj)
        {
            PhuLuc1 other = (PhuLuc1)obj.MemberwiseClone();
            return other;
        }
    }
    public class PhuLuc2
    {
        [MoTaDuLieu("Giờ")]
        public DateTime Gio { get; set; }
        [MoTaDuLieu("PH")]
        public string PH { get; set; }
        [MoTaDuLieu("pCO2")]
        public string pCO2 { get; set; }
        [MoTaDuLieu("pO2")]
        public string pO2 { get; set; }
        [MoTaDuLieu("HCO3")]
        public string HCO3 { get; set; }
        [MoTaDuLieu("BE")]
        public string BE { get; set; }
        [MoTaDuLieu("Lactac")]
        public string Lactac { get; set; }
        [MoTaDuLieu("SaO2")]
        public string SaO2 { get; set; }
    }
    public class PhuLuc3
    {
        [MoTaDuLieu("Giờ")]
        public DateTime Gio { get; set; }
        // Phụ 3
        [MoTaDuLieu("HC")]
        public string HC { get; set; }
        [MoTaDuLieu("Hb")]
        public string Hb { get; set; }
        [MoTaDuLieu("Hct")]
        public string Hct { get; set; }
        [MoTaDuLieu("BC")]
        public string BC { get; set; }
        [MoTaDuLieu("TC")]
        public string TC { get; set; }
    }
    public class PhuLuc4
    {
        [MoTaDuLieu("Giờ")]
        public DateTime Gio { get; set; }
        // phụ 4
        [MoTaDuLieu("PT")]
        public string PT { get; set; }
        [MoTaDuLieu("APTT")]
        public string APTT { get; set; }
        [MoTaDuLieu("INR")]
        public string INR { get; set; }
        [MoTaDuLieu("Fibrinogen")]
        public string Fibrinogen { get; set; }
        [MoTaDuLieu("PCT")]
        public string PCT { get; set; }
        [MoTaDuLieu("CRP")]
        public string CRP { get; set; }
    }
    public class Bilan
    {
        [MoTaDuLieu("Giờ")]
        public string Gio { get; set; }
        [MoTaDuLieu("Máu")]
        public double? Mau { get; set; }
        [MoTaDuLieu("Dịch")]
        public double? Dich { get; set; }
        [MoTaDuLieu("Thuốc")]
        public double? Thuoc { get; set; }
        [MoTaDuLieu("Ăn")]
        public double? An { get; set; }
        [MoTaDuLieu("Qua da")]
        public double? QuaDa { get; set; }
        [MoTaDuLieu("Dẫn lưu")]
        public double? DanLuu { get; set; }
        [MoTaDuLieu("Nước tiểu")]
        public double? NuocTieu { get; set; }
        [MoTaDuLieu("TPPM")]
        public double? TPPM { get; set; }
        [MoTaDuLieu("BiLan")]
        public double? BiLan { get; set; }

    }
    // phần góc trên bên phải bệnh án
    public class ThongTinChung
    {
        [MoTaDuLieu("Ca thứ")]
        public int CaThu { get; set; }
        [MoTaDuLieu("Giờ")]
        public int Gio { get; set; }
        [MoTaDuLieu("Mạch")]
        public int? Mach { get; set; }
        [MoTaDuLieu("Huyết áp cao nhất")]
        public double? HAMax { get; set; }
        [MoTaDuLieu("Huyết áp thấp nhất")]
        public double? HAMin { get; set; }
        [MoTaDuLieu("Nhiệt độ")]
        public double? NhietDo { get; set; }
        [MoTaDuLieu("Huyết áp trung bình")]
        public double? HATB { get; set; }
        [MoTaDuLieu("PVC")]
        public double? PVC { get; set; }
        [MoTaDuLieu("Mode")]
        public string Mode { get; set; }
        [MoTaDuLieu("Vt/MV")]
        public string VtMV { get; set; }
        [MoTaDuLieu("F/PEEP")]
        public string FPEEP { get; set; }
        [MoTaDuLieu("FiO2/SpO2")]
        public string FiO2SpO2 { get; set; }
        [MoTaDuLieu("PS/PC")]
        public string PSPC { get; set; }
        [MoTaDuLieu("Màng phổi")]
        public string MangPhoi { get; set; }
        [MoTaDuLieu("T.thất")]
        public string TThat { get; set; }
        [MoTaDuLieu("Nước tiểu trên")]
		public string NuocTieuTren { get; set; }
        [MoTaDuLieu("Nước tiểu dưới")]
		public string NuocTieuDuoi { get; set; }
        [MoTaDuLieu("Dinh dưỡng")]
        public string DinhDuong { get; set; }
    }

    public class BangTheoDoiChamSocBenhNhan : ThongTinKy
    {
        public BangTheoDoiChamSocBenhNhan()
        {
            TableName = "BangTDCSBenhNhan";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BTDCSBN;
            TenMauPhieu = DanhMucPhieu.BTDCSBN.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Cân nặng bệnh nhân")]
        public double? CanNang { get; set; }
        [MoTaDuLieu("S-da")]
        public string SDA { get; set; }
        [MoTaDuLieu("BMI")]
        public double? BMI { get; set; }
        [MoTaDuLieu("Nhóm máu")]
		public string NhomMau { get; set; }
        [MoTaDuLieu("Ngày mổ")]
        public DateTime? NgayMo { get; set; }
        [MoTaDuLieu("Phương pháp phẫu thuật")]
        public string PhuongPhapPhauThuat { get; set; }
        [MoTaDuLieu("Họ tên phẫu thuật viên")]
        public string PhauThuatVien { get; set; }
        [MoTaDuLieu("Mã phẩu thuật viên")]
        public string MaPhauThuatVien { get; set; }
        [MoTaDuLieu("Họ tên bác sỹ gây mê")]
        public string BacSyGayMe { get; set; }
        [MoTaDuLieu("Mã bác sỹ gây mê")]
        public string MaBacSyGayMe { get; set; }
        [MoTaDuLieu("Họ tên bác sỹ điều trị")]
		public string BacSyDieuTri { get; set; }
        [MoTaDuLieu("Mã bác sỹ điều trị")]
		public string MaBacSyDieuTri { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng ca 1")]
		public string DieuDuongCa1 { get; set; }
        [MoTaDuLieu("Mã điều dưỡng ca 1")]
		public string MaDieuDuongCa1 { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng ca 2")]
		public string DieuDuongCa2 { get; set; }
        [MoTaDuLieu("Mã điều dưỡng ca 2")]
		public string MaDieuDuongCa2 { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng ca 3")]
		public string DieuDuongCa3 { get; set; }
        [MoTaDuLieu("Mã điều dưỡng ca 3")]
		public string MaDieuDuongCa3 { get; set; }
        // update thong tin theo ca, gio
        [MoTaDuLieu("Thông tin ca 1")]
        public ObservableCollection<ThongTinChung> ThongTinChung_Ca1 { get; set; }
        [MoTaDuLieu("Thông tin ca 2")]
        public ObservableCollection<ThongTinChung> ThongTinChung_Ca2 { get; set; }
        [MoTaDuLieu("Thông tin ca 3")]
        public ObservableCollection<ThongTinChung> ThongTinChung_Ca3 { get; set; }
        // thong tin khac can nhap ten
        [MoTaDuLieu("Máu")]
        public ObservableCollection<ThongTinRieng> Mau { get; set; }
        [MoTaDuLieu("Dịch truyền")]
        public ObservableCollection<ThongTinRieng> DichTruyen { get; set; }
        [MoTaDuLieu("Thuốc")]
        public ObservableCollection<ThongTinRieng> Thuoc { get; set; }
        [MoTaDuLieu("Tình trạng bệnh nhân")]
        public ObservableCollection<ThongTinRieng> TinhTrangBenhNhan { get; set; }
        [MoTaDuLieu("Các TT-CS")]
        public ObservableCollection<ThongTinRieng> TTCS { get; set; }
        //
        [MoTaDuLieu("Phụ lục 1")]
        public ObservableCollection<PhuLuc1> PhuLuc1s { get; set; }
        [MoTaDuLieu("Phụ lục 2")]
        public ObservableCollection<PhuLuc2> PhuLuc2s { get; set; }
        [MoTaDuLieu("Phụ lục 3")]
        public ObservableCollection<PhuLuc3> PhuLuc3s { get; set; }
        [MoTaDuLieu("Phụ lục 4")]
        public ObservableCollection<PhuLuc4> PhuLuc4s { get; set; }
        [MoTaDuLieu("Bilans")]
        public ObservableCollection<Bilan> Bilans { get; set; }
        [MoTaDuLieu("Ghi chú")]
		public string GhiChu { get; set; }
        [MoTaDuLieu("KTTW")]
        public string KTTW { get; set; }
        [MoTaDuLieu("KTDM")]
        public string KTDM { get; set; }
        [MoTaDuLieu("NKQ")]
        public string NKQ { get; set; }
        [MoTaDuLieu("SBQ")]
        public string SBQ { get; set; }

        //
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

    public class BangTheoDoiChamSocBenhNhanFunc
    {
        public const string TableName = "BangTDCSBenhNhan";
        public const string TablePrimaryKeyName = "ID";
        public static List<BangTheoDoiChamSocBenhNhan> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly, decimal IDphieu = -1)
        {
            List<BangTheoDoiChamSocBenhNhan> list = new List<BangTheoDoiChamSocBenhNhan>();
            try
            {
                string sql = @"SELECT * FROM BangTDCSBenhNhan where MaQuanLy = :MaQuanLy";
                if(IDphieu > 0)
                {
                    sql = sql + "  and ID = " + IDphieu.ToString()
;                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    BangTheoDoiChamSocBenhNhan data = new BangTheoDoiChamSocBenhNhan();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.TenBenhNhan = DataReader["TenBenhNhan"].ToString();
                    data.Tuoi = DataReader["Tuoi"].ToString();
                    data.Khoa = DataReader["Khoa"].ToString();
                    data.MaKhoa = DataReader["MaKhoa"].ToString();
                    double tempDouble = 0;
                    data.CanNang = double.TryParse(DataReader["CanNang"].ToString(), out tempDouble) ? (double?)tempDouble : null;
                    data.SDA = DataReader["SDA"].ToString();
                    tempDouble = 0;
                    data.BMI = double.TryParse(DataReader["BMI"].ToString(), out tempDouble) ? (double?)tempDouble : null;
                    data.NhomMau = DataReader["NhomMau"].ToString();
                    data.NgayMo = DataReader["NgayMo"] == DBNull.Value ? null : (DateTime?)Convert.ToDateTime(DataReader["NgayMo"]);
                    data.PhuongPhapPhauThuat = DataReader["PhuongPhapPhauThuat"].ToString();
                    data.PhauThuatVien = DataReader["PhauThuatVien"].ToString();
                    data.MaPhauThuatVien = DataReader["MaPhauThuatVien"].ToString();
                    data.BacSyGayMe = DataReader["BacSyGayMe"].ToString();
                    data.MaBacSyGayMe = DataReader["MaBacSyGayMe"].ToString();
                    data.BacSyDieuTri = DataReader["BacSyDieuTri"].ToString();
                    data.MaBacSyDieuTri = DataReader["MaBacSyDieuTri"].ToString();
                    data.DieuDuongCa1 = DataReader["DieuDuongCa1"].ToString();
                    data.MaDieuDuongCa1 = DataReader["MaDieuDuongCa1"].ToString();
                    data.DieuDuongCa2 = DataReader["DieuDuongCa2"].ToString();
                    data.MaDieuDuongCa2 = DataReader["MaDieuDuongCa2"].ToString();
                    data.DieuDuongCa3 = DataReader["DieuDuongCa3"].ToString();
                    data.MaDieuDuongCa3 = DataReader["MaDieuDuongCa3"].ToString();
                    data.ThongTinChung_Ca1 = JsonConvert.DeserializeObject<ObservableCollection<ThongTinChung>>(DataReader["ThongTinChung_Ca1"].ToString());
                    data.ThongTinChung_Ca2 = JsonConvert.DeserializeObject<ObservableCollection<ThongTinChung>>(DataReader["ThongTinChung_Ca2"].ToString());
                    data.ThongTinChung_Ca3 = JsonConvert.DeserializeObject<ObservableCollection<ThongTinChung>>(DataReader["ThongTinChung_Ca3"].ToString());
                    data.Mau = JsonConvert.DeserializeObject<ObservableCollection<ThongTinRieng>>(DataReader["Mau"].ToString());
                    string DichTruyenJson = DataReader["DichTruyen_1"].ToString();
                    if (DataReader["DichTruyen_2"] != DBNull.Value)
                        DichTruyenJson += DataReader["DichTruyen_2"].ToString();
                    data.DichTruyen = JsonConvert.DeserializeObject<ObservableCollection<ThongTinRieng>>(DichTruyenJson);

                    string ThuocJson = DataReader["Thuoc_1"].ToString();
                    if (DataReader["Thuoc_2"] != DBNull.Value)
                        ThuocJson += DataReader["Thuoc_2"].ToString();
                    if (DataReader["Thuoc_3"] != DBNull.Value)
                        ThuocJson += DataReader["Thuoc_3"].ToString();
                    data.Thuoc = JsonConvert.DeserializeObject<ObservableCollection<ThongTinRieng>>(ThuocJson);

                    string TinhTrangBenhNhanJson = DataReader["TinhTrangBenhNhan_1"].ToString();
                    if (DataReader["TinhTrangBenhNhan_2"] != DBNull.Value)
                        TinhTrangBenhNhanJson += DataReader["TinhTrangBenhNhan_2"].ToString();
                    data.TinhTrangBenhNhan = JsonConvert.DeserializeObject<ObservableCollection<ThongTinRieng>>(TinhTrangBenhNhanJson);

                    data.TTCS = JsonConvert.DeserializeObject<ObservableCollection<ThongTinRieng>>(DataReader["TTCS"].ToString());

                    data.PhuLuc1s = JsonConvert.DeserializeObject<ObservableCollection<PhuLuc1>>(DataReader["PhuLuc1s"].ToString());
                    data.PhuLuc2s = JsonConvert.DeserializeObject<ObservableCollection<PhuLuc2>>(DataReader["PhuLuc2s"].ToString());
                    data.PhuLuc3s = JsonConvert.DeserializeObject<ObservableCollection<PhuLuc3>>(DataReader["PhuLuc3s"].ToString());
                    data.PhuLuc4s = JsonConvert.DeserializeObject<ObservableCollection<PhuLuc4>>(DataReader["PhuLuc4s"].ToString());

                    data.Bilans = JsonConvert.DeserializeObject<ObservableCollection<Bilan>>(DataReader["Bilans"].ToString());
                    data.GhiChu = DataReader["GhiChu"].ToString();
                    data.KTTW = DataReader["KTTW"].ToString();
                    data.KTDM = DataReader["KTDM"].ToString();
                    data.NKQ = DataReader["NKQ"].ToString();
                    data.SBQ = DataReader["SBQ"].ToString();

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
        public static bool InsertOrUpdatePhieu(MDB.MDBConnection MyConnection, ref BangTheoDoiChamSocBenhNhan phieuTheoDoi)
        {
            try
            {
                string sql = @"INSERT INTO BangTDCSBenhNhan
                (
                    MAQUANLY,
                    MaBenhNhan,
                    TenBenhNhan,
                    Tuoi,
                    Khoa,
                    MaKhoa,
                    CanNang,
                    SDA,
                    BMI,
                    NhomMau,
                    NgayMo,
                    PhuongPhapPhauThuat,
                    PhauThuatVien,
                    MaPhauThuatVien,
                    BacSyDieuTri,
                    MaBacSyDieuTri,
                    BacSyGayMe,
                    MaBacSyGayMe,
                    DieuDuongCa1,
                    MaDieuDuongCa1,
                    DieuDuongCa2,
                    MaDieuDuongCa2,
                    DieuDuongCa3,
                    MaDieuDuongCa3,
                    ThongTinChung_Ca1,
                    ThongTinChung_Ca2,
                    ThongTinChung_Ca3,
                    Mau,
                    DichTruyen_1,
                    DichTruyen_2,
                    Thuoc_1,
                    Thuoc_2,
                    Thuoc_3,
                    TinhTrangBenhNhan_1,
                    TinhTrangBenhNhan_2,
                    TTCS,
                    PhuLuc1s,
                    PhuLuc2s,
                    PhuLuc3s,
                    PhuLuc4s,
                    Bilans,
                    GhiChu,
                    KTTW,
                    KTDM,
                    NKQ,
                    SBQ,   
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
                    :MAQUANLY,
                    :MaBenhNhan,
                    :TenBenhNhan,
                    :Tuoi,
                    :Khoa,
                    :MaKhoa,
                    :CanNang,
                    :SDA,
                    :BMI,
                    :NhomMau,
                    :NgayMo,
                    :PhuongPhapPhauThuat,
                    :PhauThuatVien,
                    :MaPhauThuatVien,
                    :BacSyDieuTri,
                    :MaBacSyDieuTri,
                    :BacSyGayMe,
                    :MaBacSyGayMe,
                    :DieuDuongCa1,
                    :MaDieuDuongCa1,
                    :DieuDuongCa2,
                    :MaDieuDuongCa2,
                    :DieuDuongCa3,
                    :MaDieuDuongCa3,
                    :ThongTinChung_Ca1,
                    :ThongTinChung_Ca2,
                    :ThongTinChung_Ca3,
                    :Mau,
                    :DichTruyen_1,
                    :DichTruyen_2,
                    :Thuoc_1,
                    :Thuoc_2,
                    :Thuoc_3,
                    :TinhTrangBenhNhan_1,
                    :TinhTrangBenhNhan_2,
                    :TTCS,
                    :PhuLuc1s,
                    :PhuLuc2s,
                    :PhuLuc3s,
                    :PhuLuc4s,
                    :Bilans,
                    :GhiChu,
                    :KTTW,
                    :KTDM,
                    :NKQ,
                    :SBQ,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (phieuTheoDoi.ID != 0)
                {
                    sql = @"UPDATE BangTDCSBenhNhan SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    TenBenhNhan = :TenBenhNhan,
                    Tuoi = :Tuoi,
                    Khoa = :Khoa,
                    MaKhoa = :MaKhoa,
                    CanNang = :CanNang,
                    SDA = :SDA,
                    BMI = :BMI,
                    NhomMau = :NhomMau,
                    NgayMo = :NgayMo,
                    PhuongPhapPhauThuat = :PhuongPhapPhauThuat,
                    PhauThuatVien = :PhauThuatVien,
                    MaPhauThuatVien = :MaPhauThuatVien,
                    BacSyDieuTri = :BacSyDieuTri,
                    MaBacSyDieuTri = :MaBacSyDieuTri,
                    BacSyGayMe = :BacSyGayMe,
                    MaBacSyGayMe = :MaBacSyGayMe,
                    DieuDuongCa1 = :DieuDuongCa1,
                    MaDieuDuongCa1 = :MaDieuDuongCa1,
                    DieuDuongCa2 = :DieuDuongCa2,
                    MaDieuDuongCa2 = :MaDieuDuongCa2,
                    DieuDuongCa3 = :DieuDuongCa3,
                    MaDieuDuongCa3 = :MaDieuDuongCa3,
                    ThongTinChung_Ca1 = :ThongTinChung_Ca1,
                    ThongTinChung_Ca2 = :ThongTinChung_Ca2,
                    ThongTinChung_Ca3 = :ThongTinChung_Ca3,
                    Mau = :Mau,
                    DichTruyen_1 = :DichTruyen_1,
                    DichTruyen_2 = :DichTruyen_2,
                    Thuoc_1 = :Thuoc_1,
                    Thuoc_2 = :Thuoc_2,
                    Thuoc_3 = :Thuoc_3,
                    TinhTrangBenhNhan_1 = :TinhTrangBenhNhan_1,
                    TinhTrangBenhNhan_2 = :TinhTrangBenhNhan_2,
                    TTCS = :TTCS,
                    PhuLuc1s = :PhuLuc1s,
                    PhuLuc2s = :PhuLuc2s,
                    PhuLuc3s = :PhuLuc3s,
                    PhuLuc4s = :PhuLuc4s,
                    Bilans = :Bilans,
                    GhiChu = :GhiChu,
                    KTTW = :KTTW,
                    KTDM = :KTDM,
                    NKQ = :NKQ,
                    SBQ = :SBQ,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + phieuTheoDoi.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", phieuTheoDoi.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", phieuTheoDoi.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("TenBenhNhan", phieuTheoDoi.TenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("Tuoi", phieuTheoDoi.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa", phieuTheoDoi.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaKhoa", phieuTheoDoi.MaKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang", phieuTheoDoi.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("SDA", phieuTheoDoi.SDA));
                Command.Parameters.Add(new MDB.MDBParameter("BMI", phieuTheoDoi.BMI));
                Command.Parameters.Add(new MDB.MDBParameter("NhomMau", phieuTheoDoi.NhomMau));
                Command.Parameters.Add(new MDB.MDBParameter("NgayMo", phieuTheoDoi.NgayMo));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapPhauThuat", phieuTheoDoi.PhuongPhapPhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("PhauThuatVien", phieuTheoDoi.PhauThuatVien));
                Command.Parameters.Add(new MDB.MDBParameter("MaPhauThuatVien", phieuTheoDoi.MaPhauThuatVien));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", phieuTheoDoi.BacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSyDieuTri", phieuTheoDoi.MaBacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyGayMe", phieuTheoDoi.BacSyGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSyGayMe", phieuTheoDoi.MaBacSyGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuongCa1", phieuTheoDoi.DieuDuongCa1));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuongCa1", phieuTheoDoi.MaDieuDuongCa1));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuongCa2", phieuTheoDoi.DieuDuongCa2));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuongCa2", phieuTheoDoi.MaDieuDuongCa2));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuongCa3", phieuTheoDoi.DieuDuongCa3));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuongCa3", phieuTheoDoi.MaDieuDuongCa3));
                Command.Parameters.Add(new MDB.MDBParameter("ThongTinChung_Ca1", JsonConvert.SerializeObject(phieuTheoDoi.ThongTinChung_Ca1)));
                Command.Parameters.Add(new MDB.MDBParameter("ThongTinChung_Ca2", JsonConvert.SerializeObject(phieuTheoDoi.ThongTinChung_Ca2)));
                Command.Parameters.Add(new MDB.MDBParameter("ThongTinChung_Ca3", JsonConvert.SerializeObject(phieuTheoDoi.ThongTinChung_Ca3)));
                Command.Parameters.Add(new MDB.MDBParameter("Mau", JsonConvert.SerializeObject(phieuTheoDoi.Mau)));

                string jsonDichTruyen = JsonConvert.SerializeObject(phieuTheoDoi.DichTruyen);
                List<string> listJson = new List<string>();
                for (int i = 0; i < jsonDichTruyen.Length; i += 3999)
                {
                    if ((i + 3999) < jsonDichTruyen.Length)
                        listJson.Add(jsonDichTruyen.Substring(i, 3999));
                    else
                        listJson.Add(jsonDichTruyen.Substring(i));
                }
                Command.Parameters.Add(new MDB.MDBParameter("DichTruyen_1", listJson[0]));
                Command.Parameters.Add(new MDB.MDBParameter("DichTruyen_2", listJson.Count > 1? listJson[1] : null));

                string jsonThuoc = JsonConvert.SerializeObject(phieuTheoDoi.Thuoc);
                listJson = new List<string>();
                for (int i = 0; i < jsonThuoc.Length; i += 3999)
                {
                    if ((i + 3999) < jsonThuoc.Length)
                        listJson.Add(jsonThuoc.Substring(i, 3999));
                    else
                        listJson.Add(jsonThuoc.Substring(i));
                }

                Command.Parameters.Add(new MDB.MDBParameter("Thuoc_1", listJson[0]));
                Command.Parameters.Add(new MDB.MDBParameter("Thuoc_2", listJson.Count > 1 ? listJson[1] : null));
                Command.Parameters.Add(new MDB.MDBParameter("Thuoc_3", listJson.Count > 2 ? listJson[2] : null));

                string jsonTinhTrangBenhNhan = JsonConvert.SerializeObject(phieuTheoDoi.TinhTrangBenhNhan);
                listJson = new List<string>();
                for (int i = 0; i < jsonTinhTrangBenhNhan.Length; i += 3999)
                {
                    if ((i + 3999) < jsonTinhTrangBenhNhan.Length)
                        listJson.Add(jsonTinhTrangBenhNhan.Substring(i, 3999));
                    else
                        listJson.Add(jsonTinhTrangBenhNhan.Substring(i));
                }
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangBenhNhan_1", listJson[0]));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangBenhNhan_2", listJson.Count > 1 ? listJson[1] : null));

                Command.Parameters.Add(new MDB.MDBParameter("TTCS", JsonConvert.SerializeObject(phieuTheoDoi.TTCS)));
                Command.Parameters.Add(new MDB.MDBParameter("PhuLuc1s", JsonConvert.SerializeObject(phieuTheoDoi.PhuLuc1s)));
                Command.Parameters.Add(new MDB.MDBParameter("PhuLuc2s", JsonConvert.SerializeObject(phieuTheoDoi.PhuLuc2s)));
                Command.Parameters.Add(new MDB.MDBParameter("PhuLuc3s", JsonConvert.SerializeObject(phieuTheoDoi.PhuLuc3s)));
                Command.Parameters.Add(new MDB.MDBParameter("PhuLuc4s", JsonConvert.SerializeObject(phieuTheoDoi.PhuLuc4s)));
                Command.Parameters.Add(new MDB.MDBParameter("Bilans", JsonConvert.SerializeObject(phieuTheoDoi.Bilans)));
                Command.Parameters.Add(new MDB.MDBParameter("GhiChu", phieuTheoDoi.GhiChu));
                Command.Parameters.Add(new MDB.MDBParameter("KTTW", phieuTheoDoi.KTTW));
                Command.Parameters.Add(new MDB.MDBParameter("KTDM", phieuTheoDoi.KTDM));
                Command.Parameters.Add(new MDB.MDBParameter("NKQ", phieuTheoDoi.NKQ));
                Command.Parameters.Add(new MDB.MDBParameter("SBQ", phieuTheoDoi.SBQ));

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", phieuTheoDoi.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", phieuTheoDoi.NgaySua));
                if (phieuTheoDoi.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", phieuTheoDoi.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", phieuTheoDoi.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", phieuTheoDoi.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (phieuTheoDoi.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    phieuTheoDoi.ID = nextval;
                }
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool deletePhieu(MDB.MDBConnection MyConnection, long id)
        {
            try
            {
                string sql = "DELETE FROM BangTDCSBenhNhan WHERE ID = :ID";
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
    }
}
