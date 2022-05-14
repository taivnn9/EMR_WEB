using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMR.KyDienTu;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class KHCSNguoiBenhCovid19 : ThongTinKy
    {
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { set; get; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { set; get; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { set; get; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Giường")]
		public string Giuong { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }
        public string SoPhong { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public List<KHCSNguoiBenhCovid19_ChiTiet> KHCSChiTiet { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { set; get; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { set; get; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { set; get; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { set; get; }
        public string SoPhieu { set; get; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        public KHCSNguoiBenhCovid19 Clone()
        {
            KHCSNguoiBenhCovid19 other = (KHCSNguoiBenhCovid19)this.MemberwiseClone();
            return other;
        }
    }
    public class KHCSNguoiBenhCovid19_ChiTiet: ThongTinKy
    {
        [MoTaDuLieu("Mã định danh")]
		public long ID { set; get; }
        [MoTaDuLieu("Mã định danh")]
		public long IDPhieu { set; get; }
        public DateTime? ThoiGian { set; get; }
        public DateTime? ThoiGian_Gio { set; get; }
        public string ThoiGian_Text
        {
            get
            {
                return ThoiGian_Gio.Value.ToString("HH:mm ") + ThoiGian.Value.ToString("dd/MM/yyyy");
            }
        }
        public bool[] YThuc_Array { get; } = new bool[] { false, false, false, false };
        public int YThuc
        {
            get
            {
                return Array.IndexOf(YThuc_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < YThuc_Array.Length; i++)
                {
                    if (i == (value - 1)) YThuc_Array[i] = true;
                    else YThuc_Array[i] = false;
                }
            }
        }
        public string NgayDieuTriThu { get; set; }
        public bool MetMoi { get; set; }
        public bool DauDau { get; set; }
        public bool Sot { get; set; }
        [MoTaDuLieu("Nhiệt độ")]
		public string NhietDo { get; set; }
        public bool DauHong { get; set; }
        public bool MatViGiac { get; set; }
        public bool NgetMui { get; set; }
        public bool Ho { get; set; }
        public bool Dom { get; set; }
        public bool[] MauSacDom_Array { get; } = new bool[] { false, false, false };
        public int MauSacDom
        {
            get
            {
                return Array.IndexOf(MauSacDom_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < MauSacDom_Array.Length; i++)
                {
                    if (i == (value - 1)) MauSacDom_Array[i] = true;
                    else MauSacDom_Array[i] = false;
                }
            }
        }
        public string MauSacDom_Khac { get; set; }
        public bool KhoTho { get; set; }
        [MoTaDuLieu("Nhịp thở")]
		public string NhipTho { get; set; }
        [MoTaDuLieu("Nồng độ Oxy trong máu")]
		public string SpO2 { get; set; }
        public bool DauNguc { get; set; }
        [MoTaDuLieu("Nhịp tim")]
		public string NhipTim { get; set; }
        [MoTaDuLieu("Huyết áp")]
		public string HA { get; set; }
        public bool DauBung { get; set; }
        public bool Non { get; set; }
        public bool TieuChay { get; set; }
        public string NhanDinh_Khac { get; set; }
        // ke hoach cham soc
        public bool HaSot { get; set; }
        public bool CSHoHap { get; set; }
        public bool DinhDuong { get; set; }
        public bool TuVanGDSK { get; set; }
        // Thuc hien ke hoach cham soc
        public string DoDHST { get; set; }
        public bool[] ThuocUong_Array { get; } = new bool[] { false, false, false };
        public string ThuocUong
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ThuocUong_Array.Length; i++)
                    temp += (ThuocUong_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ThuocUong_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] XN_Array { get; } = new bool[] { false, false, false };
        public string XN
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < XN_Array.Length; i++)
                    temp += (XN_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        XN_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] ChuomMat_Array { get; } = new bool[] { false, false, false };
        public string ChuomMat
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ChuomMat_Array.Length; i++)
                    temp += (ChuomMat_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ChuomMat_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] DamBaoHoHap_Array { get; } = new bool[] { false, false, false };
        public int DamBaoHoHap
        {
            get
            {
                return Array.IndexOf(DamBaoHoHap_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DamBaoHoHap_Array.Length; i++)
                {
                    if (i == (value - 1)) DamBaoHoHap_Array[i] = true;
                    else DamBaoHoHap_Array[i] = false;
                }
            }
        }
        public bool[] ThoOxy_Array { get; } = new bool[] { false, false, false, false };
        public string ThoOxy
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ThoOxy_Array.Length; i++)
                    temp += (ThoOxy_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ThoOxy_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string Oxy_Text { get; set; }
        public bool[] Com_Array { get; } = new bool[] { false, false, false, false, false };
        public string Com
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < Com_Array.Length; i++)
                    temp += (Com_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        Com_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string Com_Khac { get; set; }
        public bool NoiQuyPhongBenh { get; set; }
        public string ThucHienKHCS_Khac { get; set; }
        // Danh gia
        public bool[] PCR_Array { get; } = new bool[] { false, false};
        public int PCR
        {
            get
            {
                return Array.IndexOf(PCR_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < PCR_Array.Length; i++)
                {
                    if (i == (value - 1)) PCR_Array[i] = true;
                    else PCR_Array[i] = false;
                }
            }
        }
        public bool[] HetSot_Array { get; } = new bool[] { false, false };
        public int HetSot
        {
            get
            {
                return Array.IndexOf(HetSot_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < HetSot_Array.Length; i++)
                {
                    if (i == (value - 1)) HetSot_Array[i] = true;
                    else HetSot_Array[i] = false;
                }
            }
        }
        public bool[] DanhGiaDung_Array { get; } = new bool[] { false, false };
        public int DanhGiaDung
        {
            get
            {
                return Array.IndexOf(DanhGiaDung_Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < DanhGiaDung_Array.Length; i++)
                {
                    if (i == (value - 1)) DanhGiaDung_Array[i] = true;
                    else DanhGiaDung_Array[i] = false;
                }
            }
        }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuong { get; set; }
        [MoTaDuLieu("Mã điều dưỡng")]
		public string MaDieuDuong { get; set; }
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
        public KHCSNguoiBenhCovid19_ChiTiet Clone()
        {
            KHCSNguoiBenhCovid19_ChiTiet other = (KHCSNguoiBenhCovid19_ChiTiet)this.MemberwiseClone();
            return other;
        }
    }
    public class KHCSNguoiBenhCovid19Func
    {
        public const string TableName = "KHCSNBCovid19_ChiTiet";
        public const string TablePrimaryKeyName = "ID";
        public static List<KHCSNguoiBenhCovid19> Select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            try
            {
                List<KHCSNguoiBenhCovid19> listResult = new List<KHCSNguoiBenhCovid19>();
                string sql = @"SELECT t.* FROM KHCSNBCovid19 t  WHERE t.MaQuanLy = :MaQuanLy ORDER BY t.NgayTao DESC";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    var data = new KHCSNguoiBenhCovid19();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = MaQuanLy;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.TenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.Giuong = DataReader["Giuong"].ToString();
                    data.SoPhong = DataReader["SoPhong"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();

                    data.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                    data.NguoiTao = DataReader["NguoiTao"].ToString();
                    data.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);
                    data.NguoiSua = DataReader["NguoiSua"].ToString();
                    data.KHCSChiTiet = Select_PhieuChiTiet(MyConnection, data.ID, 1);
                    listResult.Add(data);
                }
                return listResult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<KHCSNguoiBenhCovid19_ChiTiet> Select_PhieuChiTiet(MDB.MDBConnection MyConnection, long IDPhieu, int ModOrder = 0) 
        {
            try
            {
                List<KHCSNguoiBenhCovid19_ChiTiet> list = new List<KHCSNguoiBenhCovid19_ChiTiet>();
                string sql = @"SELECT t.* FROM KHCSNBCovid19_ChiTiet t WHERE t.IDPhieu = :IDPhieu ";

                if (ModOrder == 1)
                {
                    sql = sql + " ORDER BY t.ThoiGian ASC";
                }
                else
                {
                    sql = sql + " ORDER BY t.ThoiGian DESC";
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("IDPhieu", IDPhieu));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    var data = new KHCSNguoiBenhCovid19_ChiTiet();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.IDPhieu = IDPhieu;
                    data.ThoiGian = DataReader["ThoiGian"] != DBNull.Value ? (DateTime?) Convert.ToDateTime(DataReader["ThoiGian"]) : null;
                    data.ThoiGian_Gio = data.ThoiGian;
                    data.NgayDieuTriThu = DataReader["NgayDieuTriThu"].ToString();
                    int tempInt = 0;
                    data.YThuc = int.TryParse(DataReader["YThuc"].ToString(), out tempInt) ? tempInt : 0;
                    data.MetMoi = DataReader["MetMoi"].ToString().Equals("1") ? true : false;
                    data.DauDau = DataReader["DauDau"].ToString().Equals("1") ? true : false;
                    data.Sot = DataReader["Sot"].ToString().Equals("1") ? true : false;
                    data.NhietDo = DataReader["NhietDo"].ToString();
                    data.DauHong = DataReader["DauHong"].ToString().Equals("1") ? true : false;
                    data.MatViGiac = DataReader["MatViGiac"].ToString().Equals("1") ? true : false;
                    data.NgetMui = DataReader["NgetMui"].ToString().Equals("1") ? true : false;
                    data.Ho = DataReader["Ho"].ToString().Equals("1") ? true : false;
                    data.Dom = DataReader["Dom"].ToString().Equals("1") ? true : false;
                    data.MauSacDom = int.TryParse(DataReader["MauSacDom"].ToString(), out tempInt) ? tempInt : 0;
                    data.MauSacDom_Khac = DataReader["MauSacDom_Khac"].ToString();
                    data.KhoTho = DataReader["KhoTho"].ToString().Equals("1") ? true : false;
                    data.NhipTho = DataReader["NhipTho"].ToString();
                    data.SpO2 = DataReader["SpO2"].ToString();
                    data.DauNguc = DataReader["DauNguc"].ToString().Equals("1") ? true : false;
                    data.NhipTim = DataReader["NhipTim"].ToString();
                    data.HA = DataReader["HA"].ToString();
                    data.DauBung = DataReader["DauBung"].ToString().Equals("1") ? true : false;
                    data.Non = DataReader["Non"].ToString().Equals("1") ? true : false;
                    data.TieuChay = DataReader["TieuChay"].ToString().Equals("1") ? true : false;
                    data.NhanDinh_Khac = DataReader["NhanDinh_Khac"].ToString();
                    data.HaSot = DataReader["HaSot"].ToString().Equals("1") ? true : false;
                    data.CSHoHap = DataReader["CSHoHap"].ToString().Equals("1") ? true : false;
                    data.DinhDuong = DataReader["DinhDuong"].ToString().Equals("1") ? true : false;
                    data.TuVanGDSK = DataReader["TuVanGDSK"].ToString().Equals("1") ? true : false;
                    data.DoDHST = DataReader["DoDHST"].ToString();
                    data.ThuocUong = DataReader["ThuocUong"].ToString();
                    data.XN = DataReader["XN"].ToString();
                    data.ChuomMat = DataReader["ChuomMat"].ToString();
                    data.DamBaoHoHap = int.TryParse(DataReader["DamBaoHoHap"].ToString(), out tempInt) ? tempInt : 0;
                    data.ThoOxy = DataReader["ThoOxy"].ToString();
                    data.Oxy_Text = DataReader["Oxy_Text"].ToString();
                    data.Com = DataReader["Com"].ToString();
                    data.Com_Khac = DataReader["Com_Khac"].ToString();
                    data.NoiQuyPhongBenh = DataReader["NoiQuyPhongBenh"].ToString().Equals("1") ? true : false;
                    data.ThucHienKHCS_Khac = DataReader["ThucHienKHCS_Khac"].ToString();
                    data.PCR = int.TryParse(DataReader["PCR"].ToString(), out tempInt) ? tempInt : 0;
                    data.HetSot = int.TryParse(DataReader["HetSot"].ToString(), out tempInt) ? tempInt : 0;
                    data.DanhGiaDung = int.TryParse(DataReader["DanhGiaDung"].ToString(), out tempInt) ? tempInt : 0;
                    data.DieuDuong = DataReader["DieuDuong"].ToString();
                    data.MaDieuDuong = DataReader["MaDieuDuong"].ToString();
                    data.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                    data.NguoiTao = DataReader["NguoiTao"].ToString();
                    data.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);
                    data.NguoiSua = DataReader["NguoiSua"].ToString();

                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;
                    list.Add(data);
                }
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref KHCSNguoiBenhCovid19 ketQua)
        {
            try
            {
                string sql = @"INSERT INTO KHCSNBCovid19
                (
                    MAQUANLY,
                    MaBenhNhan,
                    Khoa,
                    MaKhoa,
                    Giuong,
                    SoPhong,
                    ChanDoan,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :Khoa,
                    :MaKhoa,
                    :Giuong,
                    :SoPhong,
                    :ChanDoan,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE KHCSNBCovid19 SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    Khoa = :Khoa,
                    MaKhoa = :MaKhoa,
                    Giuong = :Giuong,
                    SoPhong = :SoPhong,
                    ChanDoan = :ChanDoan,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ketQua.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa", ketQua.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaKhoa", ketQua.MaKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("Giuong", ketQua.Giuong));
                Command.Parameters.Add(new MDB.MDBParameter("SoPhong", ketQua.SoPhong));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", ketQua.ChanDoan));
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
        public static bool Delete(MDB.MDBConnection MyConnection, long id)
        {
            try
            {
                string sql = "DELETE FROM KHCSNBCovid19 WHERE ID = :ID";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                command.Parameters.Add(new MDB.MDBParameter("ID", id));
                command.BindByName = true;
                command.ExecuteNonQuery();

                sql = @"Delete KHCSNBCovid19_ChiTiet 
                                WHERE  IDPhieu = :IDPhieu";
                command = new MDB.MDBCommand(sql, MyConnection);
                command.Parameters.Add(new MDB.MDBParameter(":IDPhieu", id));
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool InsertOrUpdate_PhieuChiTiet(MDB.MDBConnection MyConnection, ref KHCSNguoiBenhCovid19_ChiTiet ketQua)
        {
            try
            {
                string sql = @"INSERT INTO KHCSNBCovid19_ChiTiet
                (
                    IDPhieu,
                    ThoiGian,
                    NgayDieuTriThu,
                    YThuc,
                    MetMoi,
                    DauDau,
                    Sot,
                    NhietDo,
                    DauHong,
                    MatViGiac,
                    NgetMui,
                    Ho,
                    Dom,
                    MauSacDom,
                    MauSacDom_Khac,
                    KhoTho,
                    NhipTho,
                    SpO2,
                    DauNguc,
                    NhipTim,
                    HA,
                    DauBung,
                    Non,
                    TieuChay,
                    NhanDinh_Khac,
                    HaSot,
                    CSHoHap,
                    DinhDuong,
                    TuVanGDSK,
                    DoDHST,
                    ThuocUong,
                    XN,
                    ChuomMat,
                    DamBaoHoHap,
                    ThoOxy,
                    Oxy_Text,
                    Com,
                    Com_Khac,
                    NoiQuyPhongBenh,
                    ThucHienKHCS_Khac,
                    PCR,
                    HetSot,
                    DanhGiaDung,
                    DieuDuong,
                    MaDieuDuong,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :IDPhieu,
                    :ThoiGian,
                    :NgayDieuTriThu,
                    :YThuc,
                    :MetMoi,
                    :DauDau,
                    :Sot,
                    :NhietDo,
                    :DauHong,
                    :MatViGiac,
                    :NgetMui,
                    :Ho,
                    :Dom,
                    :MauSacDom,
                    :MauSacDom_Khac,
                    :KhoTho,
                    :NhipTho,
                    :SpO2,
                    :DauNguc,
                    :NhipTim,
                    :HA,
                    :DauBung,
                    :Non,
                    :TieuChay,
                    :NhanDinh_Khac,
                    :HaSot,
                    :CSHoHap,
                    :DinhDuong,
                    :TuVanGDSK,
                    :DoDHST,
                    :ThuocUong,
                    :XN,
                    :ChuomMat,
                    :DamBaoHoHap,
                    :ThoOxy,
                    :Oxy_Text,
                    :Com,
                    :Com_Khac,
                    :NoiQuyPhongBenh,
                    :ThucHienKHCS_Khac,
                    :PCR,
                    :HetSot,
                    :DanhGiaDung,
                    :DieuDuong,
                    :MaDieuDuong,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 ) RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE KHCSNBCovid19_ChiTiet SET 
                    IDPhieu = :IDPhieu,
                    ThoiGian = :ThoiGian,
                    NgayDieuTriThu = :NgayDieuTriThu,
                    YThuc = :YThuc,
                    MetMoi = :MetMoi,
                    DauDau = :DauDau,
                    Sot = :Sot,
                    NhietDo = :NhietDo,
                    DauHong = :DauHong,
                    MatViGiac = :MatViGiac,
                    NgetMui = :NgetMui,
                    Ho = :Ho,
                    Dom = :Dom,
                    MauSacDom = :MauSacDom,
                    MauSacDom_Khac = :MauSacDom_Khac,
                    KhoTho = :KhoTho,
                    NhipTho = :NhipTho,
                    SpO2 = :SpO2,
                    DauNguc = :DauNguc,
                    NhipTim = :NhipTim,
                    HA = :HA,
                    DauBung = :DauBung,
                    Non = :Non,
                    TieuChay = :TieuChay,
                    NhanDinh_Khac = :NhanDinh_Khac,
                    HaSot = :HaSot,
                    CSHoHap = :CSHoHap,
                    DinhDuong = :DinhDuong,
                    TuVanGDSK = :TuVanGDSK,
                    DoDHST = :DoDHST,
                    ThuocUong = :ThuocUong,
                    XN = :XN,
                    ChuomMat = :ChuomMat,
                    DamBaoHoHap = :DamBaoHoHap,
                    ThoOxy = :ThoOxy,
                    Oxy_Text = :Oxy_Text,
                    Com = :Com,
                    Com_Khac = :Com_Khac,
                    NoiQuyPhongBenh = :NoiQuyPhongBenh,
                    ThucHienKHCS_Khac = :ThucHienKHCS_Khac,
                    PCR = :PCR,
                    HetSot = :HetSot,
                    DanhGiaDung = :DanhGiaDung,
                    DieuDuong = :DieuDuong,
                    MaDieuDuong = :MaDieuDuong,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("IDPhieu", ketQua.IDPhieu));
                DateTime Ngay = ketQua.ThoiGian.HasValue ? ketQua.ThoiGian.Value.Date.Add(new TimeSpan(0, 0, 0)) : DateTime.Now;
                var Gio = ketQua.ThoiGian_Gio.HasValue? ketQua.ThoiGian_Gio.Value.TimeOfDay: DateTime.Now.TimeOfDay;

                var ngayHoiChan = Ngay+ Gio;
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGian", ngayHoiChan));
                Command.Parameters.Add(new MDB.MDBParameter("NgayDieuTriThu", ketQua.NgayDieuTriThu));
                Command.Parameters.Add(new MDB.MDBParameter("YThuc", ketQua.YThuc));
                Command.Parameters.Add(new MDB.MDBParameter("MetMoi", ketQua.MetMoi ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("DauDau", ketQua.DauDau ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("Sot", ketQua.Sot ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("NhietDo", ketQua.NhietDo));
                Command.Parameters.Add(new MDB.MDBParameter("DauHong", ketQua.DauHong ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("MatViGiac", ketQua.MatViGiac ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("NgetMui", ketQua.NgetMui ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("Ho", ketQua.Ho ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("Dom", ketQua.Dom ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("MauSacDom", ketQua.MauSacDom));
                Command.Parameters.Add(new MDB.MDBParameter("MauSacDom_Khac", ketQua.MauSacDom_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("KhoTho", ketQua.KhoTho ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTho", ketQua.NhipTho));
                Command.Parameters.Add(new MDB.MDBParameter("SpO2", ketQua.SpO2));
                Command.Parameters.Add(new MDB.MDBParameter("DauNguc", ketQua.DauNguc ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTim", ketQua.NhipTim));
                Command.Parameters.Add(new MDB.MDBParameter("HA", ketQua.HA));
                Command.Parameters.Add(new MDB.MDBParameter("DauBung", ketQua.DauBung ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("Non", ketQua.Non ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("TieuChay", ketQua.TieuChay ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("NhanDinh_Khac", ketQua.NhanDinh_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("HaSot", ketQua.HaSot ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("CSHoHap", ketQua.CSHoHap ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("DinhDuong", ketQua.DinhDuong ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("TuVanGDSK", ketQua.TuVanGDSK ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("DoDHST", ketQua.DoDHST));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocUong", ketQua.ThuocUong));
                Command.Parameters.Add(new MDB.MDBParameter("XN", ketQua.XN));
                Command.Parameters.Add(new MDB.MDBParameter("ChuomMat", ketQua.ChuomMat));
                Command.Parameters.Add(new MDB.MDBParameter("DamBaoHoHap", ketQua.DamBaoHoHap));
                Command.Parameters.Add(new MDB.MDBParameter("ThoOxy", ketQua.ThoOxy));
                Command.Parameters.Add(new MDB.MDBParameter("Oxy_Text", ketQua.Oxy_Text));
                Command.Parameters.Add(new MDB.MDBParameter("Com", ketQua.Com));
                Command.Parameters.Add(new MDB.MDBParameter("Com_Khac", ketQua.Com_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("NoiQuyPhongBenh", ketQua.NoiQuyPhongBenh ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("ThucHienKHCS_Khac", ketQua.ThucHienKHCS_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("PCR", ketQua.PCR));
                Command.Parameters.Add(new MDB.MDBParameter("HetSot", ketQua.HetSot));
                Command.Parameters.Add(new MDB.MDBParameter("DanhGiaDung", ketQua.DanhGiaDung));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuong", ketQua.DieuDuong));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuong", ketQua.MaDieuDuong));
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
        public static bool Delete_ChiTiet(MDB.MDBConnection MyConnection, decimal IDPhieuCT)
        {
            try
            {
                if (IDPhieuCT != 0)
                {
                    string sql = @"Delete KHCSNBCovid19_ChiTiet 
                                WHERE 
                                (ID = :ID) ";
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter(":IDPhieuCT", IDPhieuCT));
                    int n = Command.ExecuteNonQuery();

                    return true;
                }

            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, long IDPhieu)
        {
            StringBuilder sql = new StringBuilder();
            try
            {
                sql.AppendLine(@" select a.* ");
                sql.AppendLine(@" from KHCSNBCovid19 a");
                sql.AppendLine(" WHERE a.ID = " + IDPhieu);
                MDB.MDBCommand Command = new MDB.MDBCommand(sql.ToString(), MyConnection);
                MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
                var ds = new DataSet();
                adt.Fill(ds,"KQ");
                ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
                ds.Tables[0].AddColumn("Tuoi", typeof(string));
                ds.Tables[0].AddColumn("GioiTinh", typeof(string));
                ds.Tables[0].AddColumn("BENHVIEN", typeof(string));
                ds.Tables[0].AddColumn("KHOA", typeof(string));

                ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
                ds.Tables[0].Rows[0]["KHOA"] = XemBenhAn._ThongTinDieuTri.Khoa;

                string sqlcommand = @"SELECT t.* FROM KHCSNBCovid19_ChiTiet t WHERE t.IDPhieu = :IDPhieu ORDER BY t.ThoiGian ASC";
                Command = new MDB.MDBCommand(sqlcommand, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("IDPhieu", IDPhieu));
                adt = new MDB.MDBDataAdapter(Command);
                adt.Fill(ds, "CT");
                return ds;
            }
            catch (Exception ex)
            {
                MDB.ExceptionExtend.LogError(ex);
                return null;
            }
          
        }
        public static DataSet GetDataSet_ChiTietPhieu(MDB.MDBConnection MyConnection,long ID, long IDPhieu)
        {
            StringBuilder sql = new StringBuilder();
            try
            {
                sql.AppendLine(@" select a.* ");
                sql.AppendLine(@" from KHCSNBCovid19 a");
                sql.AppendLine(" WHERE a.ID = " + ID);
                MDB.MDBCommand Command = new MDB.MDBCommand(sql.ToString(), MyConnection);
                MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
                var ds = new DataSet();
                adt.Fill(ds, "KQ");

                ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
                ds.Tables[0].AddColumn("Tuoi", typeof(string));
                ds.Tables[0].AddColumn("GioiTinh", typeof(string));
                ds.Tables[0].AddColumn("BENHVIEN", typeof(string));
                ds.Tables[0].AddColumn("KHOA", typeof(string));

                ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
                ds.Tables[0].Rows[0]["KHOA"] = XemBenhAn._ThongTinDieuTri.Khoa;

                string sqlcommand = @"SELECT t.* FROM KHCSNBCovid19_ChiTiet t WHERE t.ID = :ID";
                Command = new MDB.MDBCommand(sqlcommand, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID", IDPhieu));
                adt = new MDB.MDBDataAdapter(Command);
                adt.Fill(ds, "CT");
                return ds;
            }
            catch (Exception ex)
            {
                MDB.ExceptionExtend.LogError(ex);
                return null;
            }

        }
    }
}
