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
    public class MauPhieuYCSDKhanhSinh2 : ThongTinKy
    {
        public MauPhieuYCSDKhanhSinh2()
        {
            TableName = "PhieuYCSDKhanhSinh";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PYCSDKS;
            TenMauPhieu = DanhMucPhieu.PYCSDKS.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        public string HoTenBenhNhan { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }
        [MoTaDuLieu("Mã bệnh án")]
		public string MaBenhAn { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        public double? CanNang { get; set; }
        public string EGFR { get; set; }
        [MoTaDuLieu("Chiều cao")]
		public string ChieuCao { get; set; }
        public bool[] DiUngArr { get; } = new bool[] { false, false };
        public string DiUng
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < DiUngArr.Length; i++)
                    temp += (DiUngArr[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DiUngArr[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string DiUngKhac { get; set; }

        public bool[] ChuanDoanNKArr { get; } = new bool[] { false, false,false,false,false,false };
        public string ChuanDoanNK
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ChuanDoanNKArr.Length; i++)
                    temp += (ChuanDoanNKArr[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ChuanDoanNKArr[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }

        public string ChuanDoanNKKhac { get; set; }

        public bool[] ChiDinhArr { get; } = new bool[] { false, false, false};
        public string ChiDinh
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ChiDinhArr.Length; i++)
                    temp += (ChiDinhArr[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ChiDinhArr[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }

        public bool[] PhanTangNCArr { get; } = new bool[] { false, false, false };
        public string PhanTangNC
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < PhanTangNCArr.Length; i++)
                    temp += (PhanTangNCArr[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        PhanTangNCArr[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }

        public bool[] LamSangArr { get; } = new bool[] { false, false };
        public string LamSang
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < LamSangArr.Length; i++)
                    temp += (LamSangArr[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        LamSangArr[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }

        public string SotChiTiet { get; set; }
        public string LamSangKhac { get; set; }

        public bool[] CanLamSangArr { get; } = new bool[] { false, false, false, false, false};
        public string CanLamSang
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < CanLamSangArr.Length; i++)
                    temp += (CanLamSangArr[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        CanLamSangArr[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }

        public string CanLamSangKhac { get; set; }
        public string BCChiTiet { get; set; }
        public string BCTTChiTiet { get; set; }
        public string CRPChiTiet { get; set; }
        public string ProcalcitoninChiTiet { get; set; }


        public bool[] NuoiCayArr { get; } = new bool[] { false, false, false};
        public string NuoiCay
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < NuoiCayArr.Length; i++)
                    temp += (NuoiCayArr[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NuoiCayArr[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }

        public bool[] MauArr { get; } = new bool[] { false, false, false, false, false, false };
        public string Mau
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < MauArr.Length; i++)
                    temp += (MauArr[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        MauArr[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string MauKhac { get; set; }

        public bool[] KQNuoiCayArr { get; } = new bool[] { false, false };
        public string KQNuoiCay
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < KQNuoiCayArr.Length; i++)
                    temp += (KQNuoiCayArr[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        KQNuoiCayArr[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }

        public bool[] KQNuoiCayGrArr { get; } = new bool[] { false, false };
        public string KQNuoiCayGr
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < KQNuoiCayGrArr.Length; i++)
                    temp += (KQNuoiCayGrArr[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        KQNuoiCayGrArr[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }

        public bool[] NhatKiArr { get; } = new bool[] { false, false };
        public string NhatKi
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < NhatKiArr.Length; i++)
                    temp += (NhatKiArr[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NhatKiArr[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }

        public bool[] NhatKiThayDoiArr { get; } = new bool[] { false, false,false };
        public string NhatKiThayDoi
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < NhatKiThayDoiArr.Length; i++)
                    temp += (NhatKiThayDoiArr[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NhatKiThayDoiArr[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }

        public string VK1 { get; set; }
        public string VK1Nhay { get; set; }
        public string VK1Khang { get; set; }
        public string VK2 { get; set; }
        public string VK2Khang { get; set; }
        public string VK2Nhay { get; set; }

        public ObservableCollection<KhangSinh> ListKhangSinh { get; set; }
        
        [MoTaDuLieu("Bác sỹ điều trị")]
		public string BacSyDieuTri { get; set; }
        [MoTaDuLieu("Mã bác sỹ điều trị")]
		public string MaBacSyDieuTri { get; set; }
        public string MaTruongKhoaDieuTri { get; set; }
        public string TruongKhoaDieuTri { get; set; }
        public string MaTruongKhoaDuoc { get; set; }
        public string TruongKhoaDuoc { get; set; }
        public string MaLanhDaoBenhVien { get; set; }
        [MoTaDuLieu("Lãnh đạo bệnh viện")]
		public string LanhDaoBenhVien { get; set; }
        public DateTime? NgayKeDon { get; set; }
        
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
    
    public class KhangSinh
    {
        public string TenKhangSinh { get; set; }
        public string Duong { get; set; }
        public string Lieu { get; set; }
        public string SoNgay { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }
    }
    public class MauPhieuYCSDKhanhSinh2Func
    {
        public const string TableName = "PhieuYCSDKhanhSinh";
        public const string TablePrimaryKeyName = "ID";
        public static List<MauPhieuYCSDKhanhSinh2> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<MauPhieuYCSDKhanhSinh2> list = new List<MauPhieuYCSDKhanhSinh2>();
            try
            {
                string sql = @"SELECT * FROM PhieuYCSDKhanhSinh where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    MauPhieuYCSDKhanhSinh2 data = new MauPhieuYCSDKhanhSinh2();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.Khoa = DataReader["Khoa"].ToString();
                    data.MaKhoa = DataReader["MaKhoa"].ToString();
                    data.MaBenhAn = XemBenhAn._ThongTinDieuTri.MaBenhAn;
                    data.HoTenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    double tempDouble = 0;
                    data.CanNang = double.TryParse(DataReader["CanNang"].ToString(), out tempDouble) ? (double?) tempDouble : null;
                    data.EGFR = DataReader["EGFR"].ToString();
                    data.ChieuCao = DataReader["ChieuCao"].ToString();
                    data.DiUng = DataReader["DiUng"].ToString();
                    data.DiUngKhac = DataReader["DiUngKhac"].ToString();

                    data.ChuanDoanNK = DataReader["ChuanDoanNK"].ToString();
                    data.ChuanDoanNKKhac = DataReader["ChuanDoanNKKhac"].ToString();
                    data.ChiDinh = DataReader["ChiDinh"].ToString();
                    data.PhanTangNC = DataReader["PhanTangNC"].ToString();
                    data.LamSang = DataReader["LamSang"].ToString();
                    data.SotChiTiet = DataReader["SotChiTiet"].ToString();
                    data.LamSangKhac = DataReader["LamSangKhac"].ToString();
                    data.CanLamSang = DataReader["CanLamSang"].ToString();
                    data.CanLamSangKhac = DataReader["CanLamSangKhac"].ToString();
                    data.BCChiTiet = DataReader["BCChiTiet"].ToString();
                    data.BCTTChiTiet = DataReader["BCTTChiTiet"].ToString();
                    data.CRPChiTiet = DataReader["CRPChiTiet"].ToString();
                    data.ProcalcitoninChiTiet = DataReader["ProcalcitoninChiTiet"].ToString();

                    data.NuoiCay = DataReader["NuoiCay"].ToString();
                    data.Mau = DataReader["Mau"].ToString();
                    data.MauKhac = DataReader["MauKhac"].ToString();
                    data.KQNuoiCay = DataReader["KQNuoiCay"].ToString();
                    data.KQNuoiCayGr = DataReader["KQNuoiCayGr"].ToString();
                    data.NhatKi = DataReader["NhatKi"].ToString();
                    data.NhatKiThayDoi = DataReader["NhatKiThayDoi"].ToString();

                    data.VK1 = DataReader["VK1"].ToString();
                    data.VK1Nhay = DataReader["VK1Nhay"].ToString();
                    data.VK1Khang = DataReader["VK1Khang"].ToString();
                    data.VK2 = DataReader["VK2"].ToString();
                    data.VK2Nhay = DataReader["VK2Nhay"].ToString();
                    data.VK2Khang = DataReader["VK2Khang"].ToString();

                    data.ListKhangSinh = JsonConvert.DeserializeObject<ObservableCollection<KhangSinh>>(DataReader["ListKhangSinh"].ToString());
                    data.BacSyDieuTri = DataReader["BacSyDieuTri"].ToString();
                    data.MaBacSyDieuTri = DataReader["MaBacSyDieuTri"].ToString();
                    data.MaTruongKhoaDieuTri = DataReader["MaTruongKhoaDieuTri"].ToString();
                    data.TruongKhoaDieuTri = DataReader["TruongKhoaDieuTri"].ToString();
                    data.MaTruongKhoaDuoc = DataReader["MaTruongKhoaDuoc"].ToString();
                    data.TruongKhoaDuoc = DataReader["TruongKhoaDuoc"].ToString();
                    data.MaLanhDaoBenhVien = DataReader["MaLanhDaoBenhVien"].ToString();
                    data.LanhDaoBenhVien = DataReader["LanhDaoBenhVien"].ToString();
                    data.NgayKeDon = Convert.ToDateTime(DataReader["NgayKeDon"] == DBNull.Value ? DateTime.Now : DataReader["NgayKeDon"]);

                    data.NgayTao = Convert.ToDateTime(DataReader["NGAYTAO"] == DBNull.Value ? DateTime.Now : DataReader["NGAYTAO"]);
                    data.NguoiTao = DataReader["NGUOITAO"].ToString();
                    data.NgaySua = Convert.ToDateTime(DataReader["NGAYSUA"] == DBNull.Value ? DateTime.Now : DataReader["NGAYSUA"]);
                    data.NguoiSua = DataReader["NGUOISUA"].ToString();

                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;
                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref MauPhieuYCSDKhanhSinh2 ketQua)
        {
            try
            {
                string sql = @"INSERT INTO PhieuYCSDKhanhSinh
                (
                    MaQuanLy,
                    MaBenhNhan,
                    Khoa,
                    MaKhoa,
                    CanNang,
                    EGFR,
                    ChieuCao,
                    DiUng,
                    DiUngKhac,
                    ChuanDoanNK,
                    ChuanDoanNKKhac,
                    ChiDinh,
                    PhanTangNC,
                    LamSang,
                    SotChiTiet,
                    LamSangKhac,
                    CanLamSang,
                    CanLamSangKhac,
                    BCChiTiet,
                    BCTTChiTiet,
                    CRPChiTiet,
                    ProcalcitoninChiTiet,
                    NuoiCay,
                    Mau,
                    MauKhac,
                    KQNuoiCay,
                    KQNuoiCayGr,
                    NhatKi,
                    NhatKiThayDoi,
                    VK1,
                    VK1Nhay,
                    VK1Khang,
                    VK2,
                    VK2Nhay,
                    VK2Khang,
                    ListKhangSinh,
                    BacSyDieuTri,
                    MaBacSyDieuTri,
                    MaTruongKhoaDieuTri,
                    TruongKhoaDieuTri,
                    MaTruongKhoaDuoc,
                    TruongKhoaDuoc,
                    MaLanhDaoBenhVien,
                    LanhDaoBenhVien,
                    NgayKeDon,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
                    :MaBenhNhan,
                    :Khoa,
                    :MaKhoa,
                    :CanNang,
                    :EGFR,
                    :ChieuCao,
                    :DiUng,
                    :DiUngKhac,
                    :ChuanDoanNK,
                    :ChuanDoanNKKhac,
                    :ChiDinh,
                    :PhanTangNC,
                    :LamSang,
                    :SotChiTiet,
                    :LamSangKhac,
                    :CanLamSang,
                    :CanLamSangKhac,
                    :BCChiTiet,
                    :BCTTChiTiet,
                    :CRPChiTiet,
                    :ProcalcitoninChiTiet,
                    :NuoiCay,
                    :Mau,
                    :MauKhac,
                    :KQNuoiCay,
                    :KQNuoiCayGr,
                    :NhatKi,
                    :NhatKiThayDoi,
                    :VK1,
                    :VK1Nhay,
                    :VK1Khang,
                    :VK2,
                    :VK2Nhay,
                    :VK2Khang,
                    :ListKhangSinh,
                    :BacSyDieuTri,
                    :MaBacSyDieuTri,
                    :MaTruongKhoaDieuTri,
                    :TruongKhoaDieuTri,
                    :MaTruongKhoaDuoc,
                    :TruongKhoaDuoc,
                    :MaLanhDaoBenhVien,
                    :LanhDaoBenhVien,
                    :NgayKeDon,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE PhieuYCSDKhanhSinh SET 
                    MaQuanLy = :MaQuanLy,
                    MaBenhNhan = :MaBenhNhan,
                    Khoa = :Khoa,
                    MaKhoa = :MaKhoa,
                    CanNang = :CanNang,
                    EGFR = :EGFR,
                    ChieuCao = :ChieuCao,
                    DiUng = :DiUng,
                    DiUngKhac = :DiUngKhac,
                    ChuanDoanNK = :ChuanDoanNK,
                    ChuanDoanNKKhac = :ChuanDoanNKKhac,
                    ChiDinh = :ChiDinh,
                    PhanTangNC = :PhanTangNC,
                    LamSang = :LamSang,
                    SotChiTiet = :SotChiTiet,
                    LamSangKhac = :LamSangKhac,
                    CanLamSang = :CanLamSang,
                    CanLamSangKhac = :CanLamSangKhac,
                    BCChiTiet = :BCChiTiet,
                    BCTTChiTiet = :BCTTChiTiet,
                    CRPChiTiet = :CRPChiTiet,
                    ProcalcitoninChiTiet = :ProcalcitoninChiTiet,
                    NuoiCay = :NuoiCay,
                    Mau = :Mau,
                    MauKhac = :MauKhac,
                    KQNuoiCay = :KQNuoiCay,
                    KQNuoiCayGr = :KQNuoiCayGr,
                    NhatKi = :NhatKi,
                    NhatKiThayDoi = :NhatKiThayDoi,
                    VK1 = :VK1,
                    VK1Nhay = :VK1Nhay,
                    VK1Khang = :VK1Khang,
                    VK2 = :VK2,
                    VK2Nhay = :VK2Nhay,
                    VK2Khang = :VK2Khang,
                    ListKhangSinh = :ListKhangSinh,
                    BacSyDieuTri = :BacSyDieuTri,
                    MaBacSyDieuTri = :MaBacSyDieuTri,
                    MaTruongKhoaDieuTri = :MaTruongKhoaDieuTri,
                    TruongKhoaDieuTri = :TruongKhoaDieuTri,
                    MaTruongKhoaDuoc = :MaTruongKhoaDuoc,
                    TruongKhoaDuoc = :TruongKhoaDuoc,
                    MaLanhDaoBenhVien = :MaLanhDaoBenhVien,
                    LanhDaoBenhVien = :LanhDaoBenhVien,
                    NgayKeDon = :NgayKeDon,
                    NGAYSUA = :NGAYSUA,
                    NGUOISUA = :NGUOISUA
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ketQua.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa", ketQua.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaKhoa", ketQua.MaKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang", ketQua.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("EGFR", ketQua.EGFR));
                Command.Parameters.Add(new MDB.MDBParameter("ChieuCao", ketQua.ChieuCao));
                Command.Parameters.Add(new MDB.MDBParameter("DiUng", ketQua.DiUng));
                Command.Parameters.Add(new MDB.MDBParameter("DiUngKhac", ketQua.DiUngKhac));
                Command.Parameters.Add(new MDB.MDBParameter("ChuanDoanNK", ketQua.ChuanDoanNK));
                Command.Parameters.Add(new MDB.MDBParameter("ChuanDoanNKKhac", ketQua.ChuanDoanNKKhac));
                Command.Parameters.Add(new MDB.MDBParameter("ChiDinh", ketQua.ChiDinh));
                Command.Parameters.Add(new MDB.MDBParameter("PhanTangNC", ketQua.PhanTangNC));
                Command.Parameters.Add(new MDB.MDBParameter("LamSang", ketQua.LamSang));
                Command.Parameters.Add(new MDB.MDBParameter("SotChiTiet", ketQua.SotChiTiet));
                Command.Parameters.Add(new MDB.MDBParameter("LamSangKhac", ketQua.LamSangKhac));
                Command.Parameters.Add(new MDB.MDBParameter("CanLamSang", ketQua.CanLamSang));
                Command.Parameters.Add(new MDB.MDBParameter("CanLamSangKhac", ketQua.CanLamSangKhac));
                Command.Parameters.Add(new MDB.MDBParameter("BCChiTiet", ketQua.BCChiTiet));
                Command.Parameters.Add(new MDB.MDBParameter("BCTTChiTiet", ketQua.BCTTChiTiet));
                Command.Parameters.Add(new MDB.MDBParameter("CRPChiTiet", ketQua.CRPChiTiet));
                Command.Parameters.Add(new MDB.MDBParameter("ProcalcitoninChiTiet", ketQua.ProcalcitoninChiTiet));
                Command.Parameters.Add(new MDB.MDBParameter("NuoiCay", ketQua.NuoiCay));
                Command.Parameters.Add(new MDB.MDBParameter("Mau", ketQua.Mau));
                Command.Parameters.Add(new MDB.MDBParameter("MauKhac", ketQua.MauKhac));
                Command.Parameters.Add(new MDB.MDBParameter("KQNuoiCay", ketQua.KQNuoiCay));
                Command.Parameters.Add(new MDB.MDBParameter("KQNuoiCayGr", ketQua.KQNuoiCayGr));
                Command.Parameters.Add(new MDB.MDBParameter("NhatKi", ketQua.NhatKi));
                Command.Parameters.Add(new MDB.MDBParameter("NhatKiThayDoi", ketQua.NhatKiThayDoi));
                Command.Parameters.Add(new MDB.MDBParameter("VK1", ketQua.VK1));
                Command.Parameters.Add(new MDB.MDBParameter("VK1Nhay", ketQua.VK1Nhay));
                Command.Parameters.Add(new MDB.MDBParameter("VK1Khang", ketQua.VK1Khang));
                Command.Parameters.Add(new MDB.MDBParameter("VK2", ketQua.VK2));
                Command.Parameters.Add(new MDB.MDBParameter("VK2Nhay", ketQua.VK2Nhay));
                Command.Parameters.Add(new MDB.MDBParameter("VK2Khang", ketQua.VK2Khang));
                Command.Parameters.Add(new MDB.MDBParameter("ListKhangSinh", JsonConvert.SerializeObject(ketQua.ListKhangSinh)));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", ketQua.BacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSyDieuTri", ketQua.MaBacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("MaTruongKhoaDieuTri", ketQua.MaTruongKhoaDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TruongKhoaDieuTri", ketQua.TruongKhoaDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TruongKhoaDuoc", ketQua.TruongKhoaDuoc));
                Command.Parameters.Add(new MDB.MDBParameter("MaTruongKhoaDuoc", ketQua.MaTruongKhoaDuoc));
                Command.Parameters.Add(new MDB.MDBParameter("MaLanhDaoBenhVien", ketQua.MaLanhDaoBenhVien));
                Command.Parameters.Add(new MDB.MDBParameter("LanhDaoBenhVien", ketQua.LanhDaoBenhVien));
                Command.Parameters.Add(new MDB.MDBParameter("NgayKeDon", ketQua.NgayKeDon));

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
                string sql = "DELETE FROM PhieuYCSDKhanhSinh WHERE ID = :ID";
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
                P.* 
            FROM
                PhieuYCSDKhanhSinh P
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "KQ");

            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));
            ds.Tables[0].AddColumn("NamSinh", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(int));
            //ds.Tables[0].AddColumn("MaBenhAn", typeof(int));//31/05/2021 Close by Hòa Issues 62949
            ds.Tables[0].AddColumn("MaBenhAn", typeof(string));//31/05/2021 Add by Hòa Issues 62949
            ds.Tables[0].AddColumn("Khoa", typeof(string));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["NamSinh"] = XemBenhAn._HanhChinhBenhNhan.NgaySinh.HasValue ? XemBenhAn._HanhChinhBenhNhan.NgaySinh.Value.Year + "" : "";
            ds.Tables[0].Rows[0]["GioiTinh"] = (int)XemBenhAn._HanhChinhBenhNhan.GioiTinh;
            ds.Tables[0].Rows[0]["KHOA"] = XemBenhAn._ThongTinDieuTri.Khoa;
            ds.Tables[0].Rows[0]["MaBenhAn"] = XemBenhAn._ThongTinDieuTri.MaBenhAn;

            DateTime NgayKeDon = ds.Tables[0].Rows[0]["NgayKeDon"].ToDateTime();
            ds.Tables[0].AddColumn("NgayKeDonFormat", typeof(string));

            ds.Tables[0].Rows[0]["NgayKeDonFormat"] = "Ngày kê đơn: " + NgayKeDon.Day + "/" + NgayKeDon.Month + "/" + NgayKeDon.Year;

           

            DataTable KS = new DataTable("KS");
            KS.Columns.Add("TenKhangSinh", typeof(string));

            KS.Columns.Add("Duong", typeof(string));
            KS.Columns.Add("Lieu", typeof(string));
            KS.Columns.Add("SoNgay", typeof(string));

            KS.Columns.Add("NgayBatDau", typeof(DateTime));
            KS.Columns.Add("NgayKetThuc", typeof(DateTime));
            ObservableCollection<KhangSinh> ListKhangSinh = JsonConvert.DeserializeObject<ObservableCollection<KhangSinh>>(ds.Tables[0].Rows[0]["ListKhangSinh"].ToString());
            if (ListKhangSinh != null)
            {
                foreach (KhangSinh khangSinh in ListKhangSinh)
                {
                    KS.Rows.Add(khangSinh.TenKhangSinh, khangSinh.Duong, khangSinh.Lieu, khangSinh.SoNgay, khangSinh.NgayBatDau, khangSinh.NgayKetThuc);
                }
            }
            ds.Tables.Add(KS);

            return ds;
        }
    }
}
