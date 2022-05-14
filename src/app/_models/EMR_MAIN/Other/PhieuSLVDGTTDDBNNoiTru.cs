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
    public class PhieuSLVDGTTDDBNNoiTru : ThongTinKy
    {
        public PhieuSLVDGTTDDBNNoiTru()
        {
            TableName = "PhieuSLVDGTTDDBNNoiTru";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PSLVDGTTDDBNNT;
            TenMauPhieu = DanhMucPhieu.PSLVDGTTDDBNNT.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        public string HoTenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Giường")]
		public string Giuong { get; set; }
        [MoTaDuLieu("Buồng")]
		public string Buong { get; set; }
        [MoTaDuLieu("Ngày vào bệnh viện")]
		public DateTime NgayVaoVien { get; set; }
        public string SoVaoVien { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Cân nặng")]
		public string CanNang { get; set; }
        [MoTaDuLieu("Chiều cao")]
		public string ChieuCao { get; set; }
        [MoTaDuLieu("Chỉ số BMI")]
		public string BMI { get; set; }
        public string CanNang6Thang { get; set; }
        public string SutCan6Thang { get; set; }
        public DateTime? NgayThang1_1 { get; set; }
        public DateTime? NgayThang1_2 { get; set; }
        public DateTime? NgayThang1_3 { get; set; }
        public DateTime? NgayThang2_1 { get; set; }
        public DateTime? NgayThang2_2 { get; set; }
        public DateTime? NgayThang2_3 { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuong { get; set; }
        [MoTaDuLieu("Mã điều dưỡng")]
		public string MaDieuDuong { get; set; }
        [MoTaDuLieu("Bác sỹ")]
		public string BacSy { get; set; }
        [MoTaDuLieu("Mã bác sỹ")]
		public string MaBacSy { get; set; }

        public bool[] ChiSoBMIArray { get; } = new bool[] { false, false, false};
        public string ChiSoBMI
        {
            get
            {
                string temp = "";
                for (int i = 0; i < ChiSoBMIArray.Length; i++)
                    temp += (ChiSoBMIArray[i] ? "1" : "0");
                return temp;    
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ChiSoBMIArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] BNSutCanArray { get; } = new bool[] { false, false, false };
        public string BNSutCan
        {
            get
            {
                string temp = "";
                for (int i = 0; i < BNSutCanArray.Length; i++)
                    temp += (BNSutCanArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        BNSutCanArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] AnUongArray { get; } = new bool[] { false, false, false };
        public string AnUong
        {
            get
            {
                string temp = "";
                for (int i = 0; i < AnUongArray.Length; i++)
                    temp += (AnUongArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        AnUongArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] BenhNangArray { get; } = new bool[] { false, false, false };
        public string BenhNang
        {
            get
            {
                string temp = "";
                for (int i = 0; i < BenhNangArray.Length; i++)
                    temp += (BenhNangArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        BenhNangArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }

        public string SutCan { get; set; }
        public string ThayDoiCanNang1 { get; set; }
        public string ThayDoiCanNang2 { get; set; }
        public string ThayDoiCanNang3 { get; set; }
        public string DiemBMI1 { get; set; }
        public string DiemBMI2 { get; set; }
        public string DiemBMI3 { get; set; }
        public string KhauPhanAn1 { get; set; }
        public string KhauPhanAn2 { get; set; }
        public string KhauPhanAn3 { get; set; }
        public string TrieuTrungTieuHoa1 { get; set; }
        public string TrieuTrungTieuHoa2 { get; set; }
        public string TrieuTrungTieuHoa3 { get; set; }
        public string ChucNangHoatDong1 { get; set; }
        public string ChucNangHoatDong2 { get; set; }
        public string ChucNangHoatDong3 { get; set; }
        public string TacDongChuyenHoa1 { get; set; }
        public string TacDongChuyenHoa2 { get; set; }
        public string TacDongChuyenHoa3 { get; set; }
        public string LopMoDuoiDa1 { get; set; }
        public string LopMoDuoiDa2 { get; set; }
        public string LopMoDuoiDa3 { get; set; }
        public string TeoCo1 { get; set; }
        public string TeoCo2 { get; set; }
        public string TeoCo3 { get; set; }
        public string Phu1 { get; set; }
        public string Phu2 { get; set; }
        public string Phu3 { get; set; }
        public string CoTruong1 { get; set; }
        public string CoTruong2 { get; set; }
        public string CoTruong3 { get; set; }
        public string TongDiem1 { get; set; }
        public string TongDiem2 { get; set; }
        public string TongDiem3 { get; set; }

        public bool[] KetLuanArray { get; } = new bool[] { false, false, false };
        public string KetLuan
        {
            get
            {
                string temp = "";
                for (int i = 0; i < KetLuanArray.Length; i++)
                    temp += (KetLuanArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        KetLuanArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] KeHoachArray { get; } = new bool[] { false, false };
        public string KeHoach
        {
            get
            {
                string temp = "";
                for (int i = 0; i < KeHoachArray.Length; i++)
                    temp += (KeHoachArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        KeHoachArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }

        public string MaCheDoAn1 { get; set; }
        public bool[] DuongNuoiDuong1Array { get; } = new bool[] { false, false, false};
        public string DuongNuoiDuong1
        {
            get
            {
                string temp = "";
                for (int i = 0; i < DuongNuoiDuong1Array.Length; i++)
                    temp += (DuongNuoiDuong1Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DuongNuoiDuong1Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string DuongNuoiDuong1_Text { get; set; }
        public string MaCheDoAn2 { get; set; }
        public bool[] DuongNuoiDuong2Array { get; } = new bool[] { false, false, false };
        public string DuongNuoiDuong2
        {
            get
            {
                string temp = "";
                for (int i = 0; i < DuongNuoiDuong2Array.Length; i++)
                    temp += (DuongNuoiDuong2Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DuongNuoiDuong2Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string DuongNuoiDuong2_Text { get; set; }

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
    public class PhieuSLVDGTTDDBNNoiTruFunc
    {
        public const string TableName = "PhieuSLVDGTTDDBNNoiTru";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuSLVDGTTDDBNNoiTru> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuSLVDGTTDDBNNoiTru> list = new List<PhieuSLVDGTTDDBNNoiTru>();
            try
            {
                string sql = @"SELECT * FROM PhieuSLVDGTTDDBNNoiTru where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuSLVDGTTDDBNNoiTru data = new PhieuSLVDGTTDDBNNoiTru();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.HoTenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.Khoa = XemBenhAn._ThongTinDieuTri.Khoa;
                    data.Giuong = DataReader["Giuong"].ToString();
                    data.Buong = DataReader["Buong"].ToString();
                    data.NgayVaoVien = Convert.ToDateTime(DataReader["NgayVaoVien"] == DBNull.Value ? DateTime.Now : DataReader["NgayVaoVien"]);

                    data.SoVaoVien = DataReader["SoVaoVien"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.CanNang = DataReader["CanNang"].ToString();
                    data.ChieuCao = DataReader["ChieuCao"].ToString();
                    data.BMI = DataReader["BMI"].ToString();
                    data.CanNang6Thang = DataReader["CanNang6Thang"].ToString();
                    data.SutCan6Thang = DataReader["SutCan6Thang"].ToString();
                    data.DieuDuong = DataReader["DieuDuong"].ToString();
                    data.MaDieuDuong = DataReader["MaDieuDuong"].ToString();
                    data.BacSy = DataReader["BacSy"].ToString();
                    data.MaBacSy = DataReader["MaBacSy"].ToString();
                    data.NgayThang1_1 = Convert.ToDateTime(DataReader["NgayThang1_1"] == DBNull.Value ? DateTime.Now : DataReader["NgayThang1_1"]);
                    data.NgayThang1_2 = Convert.ToDateTime(DataReader["NgayThang1_2"] == DBNull.Value ? DateTime.Now : DataReader["NgayThang1_2"]);
                    data.NgayThang1_3 = Convert.ToDateTime(DataReader["NgayThang1_3"] == DBNull.Value ? DateTime.Now : DataReader["NgayThang1_3"]);
                    data.NgayThang2_1 = Convert.ToDateTime(DataReader["NgayThang2_1"] == DBNull.Value ? DateTime.Now : DataReader["NgayThang2_1"]);
                    data.NgayThang2_2 = Convert.ToDateTime(DataReader["NgayThang2_2"] == DBNull.Value ? DateTime.Now : DataReader["NgayThang2_2"]);
                    data.NgayThang2_3 = Convert.ToDateTime(DataReader["NgayThang2_3"] == DBNull.Value ? DateTime.Now : DataReader["NgayThang2_3"]);

                    data.ChiSoBMI = DataReader["ChiSoBMI"].ToString();
                    data.BNSutCan = DataReader["BNSutCan"].ToString();
                    data.AnUong = DataReader["AnUong"].ToString();
                    data.BenhNang = DataReader["BenhNang"].ToString();
                    data.SutCan = DataReader["SutCan"].ToString();
                    data.ThayDoiCanNang1 = DataReader["ThayDoiCanNang1"].ToString();
                    data.ThayDoiCanNang2 = DataReader["ThayDoiCanNang2"].ToString();
                    data.ThayDoiCanNang3 = DataReader["ThayDoiCanNang3"].ToString();
                    data.DiemBMI1 = DataReader["DiemBMI1"].ToString();
                    data.DiemBMI2 = DataReader["DiemBMI2"].ToString();
                    data.DiemBMI3 = DataReader["DiemBMI3"].ToString();
                    data.KhauPhanAn1 = DataReader["KhauPhanAn1"].ToString();
                    data.KhauPhanAn2 = DataReader["KhauPhanAn2"].ToString();
                    data.KhauPhanAn3 = DataReader["KhauPhanAn3"].ToString();
                    data.TrieuTrungTieuHoa1 = DataReader["TrieuTrungTieuHoa1"].ToString();
                    data.TrieuTrungTieuHoa2 = DataReader["TrieuTrungTieuHoa2"].ToString();
                    data.TrieuTrungTieuHoa3 = DataReader["TrieuTrungTieuHoa3"].ToString();
                    data.ChucNangHoatDong1 = DataReader["ChucNangHoatDong1"].ToString();
                    data.ChucNangHoatDong2 = DataReader["ChucNangHoatDong2"].ToString();
                    data.ChucNangHoatDong3 = DataReader["ChucNangHoatDong3"].ToString();
                    data.TacDongChuyenHoa1 = DataReader["TacDongChuyenHoa1"].ToString();
                    data.TacDongChuyenHoa2 = DataReader["TacDongChuyenHoa2"].ToString();
                    data.TacDongChuyenHoa3 = DataReader["TacDongChuyenHoa3"].ToString();
                    data.LopMoDuoiDa1 = DataReader["LopMoDuoiDa1"].ToString();
                    data.LopMoDuoiDa2 = DataReader["LopMoDuoiDa2"].ToString();
                    data.LopMoDuoiDa3 = DataReader["LopMoDuoiDa3"].ToString();
                    data.TeoCo1 = DataReader["TeoCo1"].ToString();
                    data.TeoCo2 = DataReader["TeoCo2"].ToString();
                    data.TeoCo3 = DataReader["TeoCo3"].ToString();
                    data.Phu1 = DataReader["Phu1"].ToString();
                    data.Phu2 = DataReader["Phu2"].ToString();
                    data.Phu3 = DataReader["Phu3"].ToString();
                    data.CoTruong1 = DataReader["CoTruong1"].ToString();
                    data.CoTruong2 = DataReader["CoTruong2"].ToString();
                    data.CoTruong3 = DataReader["CoTruong3"].ToString();
                    data.TongDiem1 = DataReader["TongDiem1"].ToString();
                    data.TongDiem2 = DataReader["TongDiem2"].ToString();
                    data.TongDiem3 = DataReader["TongDiem3"].ToString();
                    data.KetLuan = DataReader["KetLuan"].ToString();

                    data.KeHoach = DataReader["KeHoach"].ToString();
                    data.MaCheDoAn1 = DataReader["MaCheDoAn1"].ToString();
                    data.DuongNuoiDuong1 = DataReader["DuongNuoiDuong1"].ToString();
                    data.DuongNuoiDuong1_Text = DataReader["DuongNuoiDuong1_Text"].ToString();

                    data.MaCheDoAn2 = DataReader["MaCheDoAn2"].ToString();
                    data.DuongNuoiDuong2 = DataReader["DuongNuoiDuong2"].ToString();
                    data.DuongNuoiDuong2_Text = DataReader["DuongNuoiDuong2_Text"].ToString();

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuSLVDGTTDDBNNoiTru bangKe)
        {
            try
            {
                string sql = @"INSERT INTO PhieuSLVDGTTDDBNNoiTru
                (
                    MAQUANLY,
                    Giuong,
                    Buong,
                    NgayVaoVien,
                    SoVaoVien,
                    ChanDoan,
                    CanNang,
                    ChieuCao,
                    BMI,
                    CanNang6Thang,
                    SutCan6Thang,
                    DieuDuong,
                    MaDieuDuong,
                    BacSy,
                    MaBacSy,
                    NgayThang1_1,
                    NgayThang1_2,
                    NgayThang1_3,
                    NgayThang2_1,
                    NgayThang2_2,
                    NgayThang2_3,
                    ChiSoBMI,
                    BNSutCan,
                    AnUong,
                    BenhNang,
                    SutCan,
                    ThayDoiCanNang1,
                    ThayDoiCanNang2,
                    ThayDoiCanNang3,
                    DiemBMI1,
                    DiemBMI2,
                    DiemBMI3,
                    KhauPhanAn1,
                    KhauPhanAn2,
                    KhauPhanAn3,
                    TrieuTrungTieuHoa1,
                    TrieuTrungTieuHoa2,
                    TrieuTrungTieuHoa3,
                    ChucNangHoatDong1,
                    ChucNangHoatDong2,
                    ChucNangHoatDong3,
                    TacDongChuyenHoa1,
                    TacDongChuyenHoa2,
                    TacDongChuyenHoa3,
                    LopMoDuoiDa1,
                    LopMoDuoiDa2,
                    LopMoDuoiDa3,
                    TeoCo1,
                    TeoCo2,
                    TeoCo3,
                    Phu1,
                    Phu2,
                    Phu3,
                    CoTruong1,
                    CoTruong2,
                    CoTruong3,
                    TongDiem1,
                    TongDiem2,
                    TongDiem3,
                    KetLuan,
                    KeHoach,
                    MaCheDoAn1,
                    DuongNuoiDuong1,
                    DuongNuoiDuong1_Text,
                    MaCheDoAn2,
                    DuongNuoiDuong2,
                    DuongNuoiDuong2_Text,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :Giuong,
                    :Buong,
                    :NgayVaoVien,
                    :SoVaoVien,
                    :ChanDoan,
                    :CanNang,
                    :ChieuCao,
                    :BMI,
                    :CanNang6Thang,
                    :SutCan6Thang,
                    :DieuDuong,
                    :MaDieuDuong,
                    :BacSy,
                    :MaBacSy,
                    :NgayThang1_1,
                    :NgayThang1_2,
                    :NgayThang1_3,
                    :NgayThang2_1,
                    :NgayThang2_2,
                    :NgayThang2_3,
                    :ChiSoBMI,
                    :BNSutCan,
                    :AnUong,
                    :BenhNang,
                    :SutCan,
                    :ThayDoiCanNang1,
                    :ThayDoiCanNang2,
                    :ThayDoiCanNang3,
                    :DiemBMI1,
                    :DiemBMI2,
                    :DiemBMI3,
                    :KhauPhanAn1,
                    :KhauPhanAn2,
                    :KhauPhanAn3,
                    :TrieuTrungTieuHoa1,
                    :TrieuTrungTieuHoa2,
                    :TrieuTrungTieuHoa3,
                    :ChucNangHoatDong1,
                    :ChucNangHoatDong2,
                    :ChucNangHoatDong3,
                    :TacDongChuyenHoa1,
                    :TacDongChuyenHoa2,
                    :TacDongChuyenHoa3,
                    :LopMoDuoiDa1,
                    :LopMoDuoiDa2,
                    :LopMoDuoiDa3,
                    :TeoCo1,
                    :TeoCo2,
                    :TeoCo3,
                    :Phu1,
                    :Phu2,
                    :Phu3,
                    :CoTruong1,
                    :CoTruong2,
                    :CoTruong3,
                    :TongDiem1,
                    :TongDiem2,
                    :TongDiem3,
                    :KetLuan,
                    :KeHoach,
                    :MaCheDoAn1,
                    :DuongNuoiDuong1,
                    :DuongNuoiDuong1_Text,
                    :MaCheDoAn2,
                    :DuongNuoiDuong2,
                    :DuongNuoiDuong2_Text,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (bangKe.ID != 0)
                {
                    sql = @"UPDATE PhieuSLVDGTTDDBNNoiTru SET 
                    MAQUANLY = :MAQUANLY,
                    Giuong = :Giuong,
                    Buong = :Buong,
                    NgayVaoVien = :NgayVaoVien,
                    SoVaoVien = :SoVaoVien,
                    ChanDoan = :ChanDoan,
                    CanNang = :CanNang,
                    ChieuCao = :ChieuCao,
                    BMI = :BMI,
                    CanNang6Thang = :CanNang6Thang,
                    SutCan6Thang = :SutCan6Thang,
                    DieuDuong = :DieuDuong,
                    MaDieuDuong = :MaDieuDuong,
                    BacSy = :BacSy,
                    MaBacSy = :MaBacSy,
                    NgayThang1_1 = :NgayThang1_1,
                    NgayThang1_2 = :NgayThang1_2,
                    NgayThang1_3 = :NgayThang1_3,
                    NgayThang2_1 = :NgayThang2_1,
                    NgayThang2_2 = :NgayThang2_2,
                    NgayThang2_3 = :NgayThang2_3,
                    ChiSoBMI = :ChiSoBMI,
                    BNSutCan = :BNSutCan,
                    AnUong = :AnUong,
                    BenhNang = :BenhNang,
                    SutCan = :SutCan,
                    ThayDoiCanNang1 = :ThayDoiCanNang1,
                    ThayDoiCanNang2 = :ThayDoiCanNang2,
                    ThayDoiCanNang3= :ThayDoiCanNang3,
                    DiemBMI1 = :DiemBMI1,
                    DiemBMI2 = :DiemBMI2,
                    DiemBMI3 = :DiemBMI3,
                    KhauPhanAn1 = :KhauPhanAn1,
                    KhauPhanAn2 = :KhauPhanAn2,
                    KhauPhanAn3 = :KhauPhanAn3,
                    TrieuTrungTieuHoa1 = :TrieuTrungTieuHoa1,
                    TrieuTrungTieuHoa2 = :TrieuTrungTieuHoa2,
                    TrieuTrungTieuHoa3 = :TrieuTrungTieuHoa3,
                    ChucNangHoatDong1 = :ChucNangHoatDong1,
                    ChucNangHoatDong2 = :ChucNangHoatDong2,
                    ChucNangHoatDong3 = :ChucNangHoatDong3,
                    TacDongChuyenHoa1 = :TacDongChuyenHoa1,
                    TacDongChuyenHoa2 = :TacDongChuyenHoa2,
                    TacDongChuyenHoa3 = :TacDongChuyenHoa3,
                    LopMoDuoiDa1 = :LopMoDuoiDa1,
                    LopMoDuoiDa2 = :LopMoDuoiDa2,
                    LopMoDuoiDa3 = :LopMoDuoiDa3,
                    TeoCo1 = :TeoCo1,
                    TeoCo2 = :TeoCo2,
                    TeoCo3 = :TeoCo3,
                    Phu1 = :Phu1,
                    Phu2 = :Phu2,
                    Phu3 = :Phu3,
                    CoTruong1 = :CoTruong1,
                    CoTruong2 = :CoTruong2,
                    CoTruong3 = :CoTruong3,
                    TongDiem1 = :TongDiem1,
                    TongDiem2 = :TongDiem2,
                    TongDiem3 = :TongDiem3,
                    KetLuan = :KetLuan,
                    KeHoach = :KeHoach,
                    MaCheDoAn1 = :MaCheDoAn1,
                    DuongNuoiDuong1 = :DuongNuoiDuong1,
                    DuongNuoiDuong1_Text = :DuongNuoiDuong1_Text,
                    MaCheDoAn2 = :MaCheDoAn2,
                    DuongNuoiDuong2 = :DuongNuoiDuong2,
                    DuongNuoiDuong2_Text = :DuongNuoiDuong2_Text,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + bangKe.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangKe.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("Giuong", bangKe.Giuong));
                Command.Parameters.Add(new MDB.MDBParameter("Buong", bangKe.Buong));
                Command.Parameters.Add(new MDB.MDBParameter("NgayVaoVien", bangKe.NgayVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("SoVaoVien", bangKe.SoVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", bangKe.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang", bangKe.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("ChieuCao", bangKe.ChieuCao));
                Command.Parameters.Add(new MDB.MDBParameter("BMI", bangKe.BMI));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang6Thang", bangKe.CanNang6Thang));
                Command.Parameters.Add(new MDB.MDBParameter("SutCan6Thang", bangKe.SutCan6Thang));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuong", bangKe.DieuDuong));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuong", bangKe.MaDieuDuong));
                Command.Parameters.Add(new MDB.MDBParameter("BacSy", bangKe.BacSy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSy", bangKe.MaBacSy));
                Command.Parameters.Add(new MDB.MDBParameter("NgayThang1_1", bangKe.NgayThang1_1));
                Command.Parameters.Add(new MDB.MDBParameter("NgayThang1_2", bangKe.NgayThang1_2));
                Command.Parameters.Add(new MDB.MDBParameter("NgayThang1_3", bangKe.NgayThang1_3));
                Command.Parameters.Add(new MDB.MDBParameter("NgayThang2_1", bangKe.NgayThang2_1));
                Command.Parameters.Add(new MDB.MDBParameter("NgayThang2_2", bangKe.NgayThang2_2));
                Command.Parameters.Add(new MDB.MDBParameter("NgayThang2_3", bangKe.NgayThang2_3));
                Command.Parameters.Add(new MDB.MDBParameter("ChiSoBMI", bangKe.ChiSoBMI));
                Command.Parameters.Add(new MDB.MDBParameter("BNSutCan", bangKe.BNSutCan));
                Command.Parameters.Add(new MDB.MDBParameter("AnUong", bangKe.AnUong));
                Command.Parameters.Add(new MDB.MDBParameter("BenhNang", bangKe.BenhNang));
                Command.Parameters.Add(new MDB.MDBParameter("SutCan", bangKe.SutCan));
                Command.Parameters.Add(new MDB.MDBParameter("ThayDoiCanNang1", bangKe.ThayDoiCanNang1));
                Command.Parameters.Add(new MDB.MDBParameter("ThayDoiCanNang2", bangKe.ThayDoiCanNang2));
                Command.Parameters.Add(new MDB.MDBParameter("ThayDoiCanNang3", bangKe.ThayDoiCanNang3));
                Command.Parameters.Add(new MDB.MDBParameter("DiemBMI1", bangKe.DiemBMI1));
                Command.Parameters.Add(new MDB.MDBParameter("DiemBMI2", bangKe.DiemBMI2));
                Command.Parameters.Add(new MDB.MDBParameter("DiemBMI3", bangKe.DiemBMI3));
                Command.Parameters.Add(new MDB.MDBParameter("KhauPhanAn1", bangKe.KhauPhanAn1));
                Command.Parameters.Add(new MDB.MDBParameter("KhauPhanAn2", bangKe.KhauPhanAn2));
                Command.Parameters.Add(new MDB.MDBParameter("KhauPhanAn3", bangKe.KhauPhanAn3));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuTrungTieuHoa1", bangKe.TrieuTrungTieuHoa1));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuTrungTieuHoa2", bangKe.TrieuTrungTieuHoa2));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuTrungTieuHoa3", bangKe.TrieuTrungTieuHoa3));
                Command.Parameters.Add(new MDB.MDBParameter("ChucNangHoatDong1", bangKe.ChucNangHoatDong1));
                Command.Parameters.Add(new MDB.MDBParameter("ChucNangHoatDong2", bangKe.ChucNangHoatDong2));
                Command.Parameters.Add(new MDB.MDBParameter("ChucNangHoatDong3", bangKe.ChucNangHoatDong3));
                Command.Parameters.Add(new MDB.MDBParameter("TacDongChuyenHoa1", bangKe.TacDongChuyenHoa1));
                Command.Parameters.Add(new MDB.MDBParameter("TacDongChuyenHoa2", bangKe.TacDongChuyenHoa2));
                Command.Parameters.Add(new MDB.MDBParameter("TacDongChuyenHoa3", bangKe.TacDongChuyenHoa3));
                Command.Parameters.Add(new MDB.MDBParameter("LopMoDuoiDa1", bangKe.LopMoDuoiDa1));
                Command.Parameters.Add(new MDB.MDBParameter("LopMoDuoiDa2", bangKe.LopMoDuoiDa2));
                Command.Parameters.Add(new MDB.MDBParameter("LopMoDuoiDa3", bangKe.LopMoDuoiDa3));
                Command.Parameters.Add(new MDB.MDBParameter("TeoCo1", bangKe.TeoCo1));
                Command.Parameters.Add(new MDB.MDBParameter("TeoCo2", bangKe.TeoCo2));
                Command.Parameters.Add(new MDB.MDBParameter("TeoCo3", bangKe.TeoCo3));
                Command.Parameters.Add(new MDB.MDBParameter("Phu1", bangKe.Phu1));
                Command.Parameters.Add(new MDB.MDBParameter("Phu2", bangKe.Phu2));
                Command.Parameters.Add(new MDB.MDBParameter("Phu3", bangKe.Phu3));
                Command.Parameters.Add(new MDB.MDBParameter("CoTruong1", bangKe.CoTruong1));
                Command.Parameters.Add(new MDB.MDBParameter("CoTruong2", bangKe.CoTruong2));
                Command.Parameters.Add(new MDB.MDBParameter("CoTruong3", bangKe.CoTruong3));
                Command.Parameters.Add(new MDB.MDBParameter("TongDiem1", bangKe.TongDiem1));
                Command.Parameters.Add(new MDB.MDBParameter("TongDiem2", bangKe.TongDiem2));
                Command.Parameters.Add(new MDB.MDBParameter("TongDiem3", bangKe.TongDiem3));
                Command.Parameters.Add(new MDB.MDBParameter("KetLuan", bangKe.KetLuan));
                Command.Parameters.Add(new MDB.MDBParameter("KeHoach", bangKe.KeHoach));
                Command.Parameters.Add(new MDB.MDBParameter("MaCheDoAn1", bangKe.MaCheDoAn1));
                Command.Parameters.Add(new MDB.MDBParameter("DuongNuoiDuong1", bangKe.DuongNuoiDuong1));
                Command.Parameters.Add(new MDB.MDBParameter("DuongNuoiDuong1_Text", bangKe.DuongNuoiDuong1_Text));
                Command.Parameters.Add(new MDB.MDBParameter("MaCheDoAn2", bangKe.MaCheDoAn2));
                Command.Parameters.Add(new MDB.MDBParameter("DuongNuoiDuong2", bangKe.DuongNuoiDuong2));
                Command.Parameters.Add(new MDB.MDBParameter("DuongNuoiDuong2_Text", bangKe.DuongNuoiDuong2_Text));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", bangKe.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", bangKe.NgaySua));
                if (bangKe.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", bangKe.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", bangKe.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", bangKe.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (bangKe.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    bangKe.ID = nextval;
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
                string sql = "DELETE FROM PhieuSLVDGTTDDBNNoiTru WHERE ID = :ID";
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
                *
            FROM
                PhieuSLVDGTTDDBNNoiTru B
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);

            var ds = new DataSet();

            adt.Fill(ds, "TB");
            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(string));
            ds.Tables[0].AddColumn("Khoa", typeof(string));
            ds.Tables[0].AddColumn("SoYTe", typeof(string));
            ds.Tables[0].AddColumn("BenhVien", typeof(string));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            ds.Tables[0].Rows[0]["Khoa"] = XemBenhAn._ThongTinDieuTri.Khoa;
            ds.Tables[0].Rows[0]["SoYTe"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BenhVien"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;

            return ds;

        }
    }
}
