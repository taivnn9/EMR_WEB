using EMR.KyDienTu;
using Newtonsoft.Json;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMR_MAIN.DATABASE.Other
{
    public class PTDCSNBCT_TDCS
    {
        public string TieuDe { get; set; }
        public string GiaTri { get; set; }
        public PTDCSNBCT_TDCS Clone()
        {
            return (PTDCSNBCT_TDCS)this.MemberwiseClone();
        }
    }
    public class PTDCSNBCT_ChiTiet
    {
        public PTDCSNBCT_ChiTiet()
        {
            CSThuoc = new ObservableCollection<PTDCSNBCT_TDCS>();
            CSThuoc.Add(new PTDCSNBCT_TDCS { TieuDe = "Natriclorid 0,9%/500 ml" });
            CSThuoc.Add(new PTDCSNBCT_TDCS { TieuDe = "Heparin 25000 UI/5 ml" });
            CSThuoc.Add(new PTDCSNBCT_TDCS { TieuDe = "Lovenox" });
            CSThuoc.Add(new PTDCSNBCT_TDCS { TieuDe = "Nitro glyceryl 10mg/10ml" });
            CSThuoc.Add(new PTDCSNBCT_TDCS { TieuDe = "Xenetic 300/100ml" });
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã định danh")]
		public long ID_Phieu { get; set; }
        public int Loai_CT { get; set; }
        public string TenLoai_CT
        {
            get
            {
                if (Loai_CT == 0)
                {
                    return "Trước CT";
                }
                else if (Loai_CT == 1)
                {
                    return "Trong CT";
                }
                else if (Loai_CT == 2)
                {
                    return "Sau CT";
                }
                else return "";
            }
        }
        public DateTime? ThoiGian { get; set; }
        public ObservableCollection<PTDCSNBCT_TDCS> CSThuoc { get; set; }
        [MoTaDuLieu("Mạch")]
		public string Mach { get; set; }
        [MoTaDuLieu("Huyết áp")]
		public string HA { get; set; }
        [MoTaDuLieu("Nhiệt độ")]
		public string NhietDo { get; set; }
        public string ModeHH { get; set; }
        public string F { get; set; }
        [MoTaDuLieu("Nồng độ Oxy trong máu")]
		public string SpO2 { get; set; }
        [MoTaDuLieu("Nước tiểu")]
		public string NuocTieu { get; set; }
        public string TTNB { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuong { get; set; }
        [MoTaDuLieu("Mã điều dưỡng")]
		public string MaDieuDuong { get; set; }
        public PTDCSNBCT_ChiTiet clone()
        {
            PTDCSNBCT_ChiTiet other = (PTDCSNBCT_ChiTiet) this.MemberwiseClone();
            other.CSThuoc = new ObservableCollection<PTDCSNBCT_TDCS>();

            if (this.CSThuoc != null)
            {
                foreach(PTDCSNBCT_TDCS tdcs in this.CSThuoc)
                {
                    other.CSThuoc.Add(tdcs.Clone());
                }
            }
            return other;
        }
    }
    public class PTDCSNBCT : ThongTinKy
    {
        public PTDCSNBCT()
        {
            TableName = "PTDCSNBCT";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PTDCSNBCT;
            TenMauPhieu = DanhMucPhieu.PTDCSNBCT.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Giường")]
		public string Giuong { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public string DM { get; set; }
        public string TM { get; set; }
        public string Quay1 { get; set; }
        public string Quay2 { get; set; }
        public string Quay3 { get; set; }
        public string Quay4 { get; set; }
        public string Quay5 { get; set; }
        public string Quay6 { get; set; }
        public string Quay7 { get; set; }
        public string Quay8 { get; set; }
        public string Quay9 { get; set; }
        public string Quay10 { get; set; }
        public string Dui1 { get; set; }
        public string Dui2 { get; set; }
        public string Dui3 { get; set; }
        public string Dui4 { get; set; }
        public string Dui5 { get; set; }
        public string Dui6 { get; set; }
        public string Dui7 { get; set; }
        public string Dui8 { get; set; }
        public string Dui9 { get; set; }
        public string Dui10 { get; set; }
        public string KhoaChuyenDen { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }
        public string MaDD { get; set; }
        public string DD { get; set; }
        public bool[] ChocMachArr { get; } = new bool[] { false, false , false, false };
        public string ChocMach
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ChocMachArr.Length; i++)
                    temp += (ChocMachArr[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ChocMachArr[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] ChiDinhArr { get; } = new bool[] { false, false, false };
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
        public string CanThiep { get; set; }
        public string GioEp { get; set; }
        public string TTNBTruocCT { get; set; }
        public string TTNBTrongCT { get; set; }
        public string TTNBSauCT { get; set; }
        public string Quay11 { get; set; }
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
    public class PTDCSNBCTFunc
    {
        public const string TableName = "PTDCSNBCT";
        public const string TablePrimaryKeyName = "ID";
        public static ObservableCollection<PTDCSNBCT_ChiTiet> GetListData_ChiTiet(MDB.MDBConnection _OracleConnection, long ID_Phieu)
        {
            ObservableCollection<PTDCSNBCT_ChiTiet> list = new ObservableCollection<PTDCSNBCT_ChiTiet>();

            try
            {
                string sql = @"SELECT * FROM PTDCSNBCT_CT where ID_Phieu = :ID_Phieu ORDER BY Loai_CT, ThoiGian";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID_Phieu", ID_Phieu));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PTDCSNBCT_ChiTiet data = new PTDCSNBCT_ChiTiet();
                    data.ID = DataReader.GetLong("ID");
                    data.ID_Phieu = ID_Phieu;
                    data.Loai_CT = DataReader.GetInt("Loai_CT");
                    data.ThoiGian =Common.ConDB_DateTimeNull( DataReader["ThoiGian"]);
                    data.CSThuoc = JsonConvert.DeserializeObject<ObservableCollection<PTDCSNBCT_TDCS>>(DataReader["CSThuoc"].ToString());
                    data.Mach = DataReader["Mach"].ToString();
                    data.HA = DataReader["HA"].ToString();
                    data.NhietDo = DataReader["NhietDo"].ToString();
                    data.ModeHH = DataReader["ModeHH"].ToString();
                    data.F = DataReader["F"].ToString();
                    data.SpO2 = DataReader["SpO2"].ToString();
                    data.NuocTieu = DataReader["NuocTieu"].ToString();
                    data.TTNB = DataReader["TTNB"].ToString();
                    data.DieuDuong = DataReader["DieuDuong"].ToString();
                    data.MaDieuDuong = DataReader["MaDieuDuong"].ToString();
                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool InsertOrUpdate_ChiTiet(MDB.MDBConnection MyConnection, ref PTDCSNBCT_ChiTiet chiTietPhieu)
        {
            try
            {
                string sql = @"INSERT INTO PTDCSNBCT_CT
                (
                ID_Phieu,
                Loai_CT,
                ThoiGian,
                CSThuoc,
                Mach,
                HA,
                NhietDo,
                ModeHH,
                F,
                SpO2, NuocTieu,
                TTNB,
                DieuDuong,
                MaDieuDuong
                )  VALUES
                 (
                :ID_Phieu,
                :Loai_CT,
                :ThoiGian,
                :CSThuoc,
                :Mach,
                :HA,
                :NhietDo,
                :ModeHH,
                :F,
                :SpO2, :NuocTieu,
                :TTNB,
                :DieuDuong,
                :MaDieuDuong
                 )  RETURNING ID INTO :ID";
                if (chiTietPhieu.ID != 0)
                {
                    sql = @"UPDATE PTDCSNBCT_CT SET 
                    ID_Phieu =:ID_Phieu,
                    Loai_CT =:Loai_CT,
                    ThoiGian =:ThoiGian,
                    CSThuoc =:CSThuoc,
                    Mach =:Mach,
                    HA =:HA,
                    NhietDo =:NhietDo,
                    ModeHH =:ModeHH,
                    F =:F,
                    SpO2 =:SpO2,NuocTieu =:NuocTieu,
                    TTNB =:TTNB,
                    DieuDuong =:DieuDuong,
                    MaDieuDuong =:MaDieuDuong
                    WHERE ID = " + chiTietPhieu.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID_Phieu", chiTietPhieu.ID_Phieu));
                Command.Parameters.Add(new MDB.MDBParameter("Loai_CT", chiTietPhieu.Loai_CT));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGian", chiTietPhieu.ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("CSThuoc", JsonConvert.SerializeObject(chiTietPhieu.CSThuoc)));
                Command.Parameters.Add(new MDB.MDBParameter("Mach", chiTietPhieu.Mach));
                Command.Parameters.Add(new MDB.MDBParameter("HA", chiTietPhieu.HA));
                Command.Parameters.Add(new MDB.MDBParameter("NhietDo", chiTietPhieu.NhietDo));
                Command.Parameters.Add(new MDB.MDBParameter("ModeHH", chiTietPhieu.ModeHH));
                Command.Parameters.Add(new MDB.MDBParameter("F", chiTietPhieu.F));
                Command.Parameters.Add(new MDB.MDBParameter("SpO2", chiTietPhieu.SpO2));
                Command.Parameters.Add(new MDB.MDBParameter("NuocTieu", chiTietPhieu.NuocTieu));
                Command.Parameters.Add(new MDB.MDBParameter("TTNB", chiTietPhieu.TTNB));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuong", chiTietPhieu.DieuDuong));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuong", chiTietPhieu.MaDieuDuong));

                if (chiTietPhieu.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", chiTietPhieu.ID));;
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (chiTietPhieu.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    chiTietPhieu.ID = nextval;
                }
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static bool Delete_ChiTiet(MDB.MDBConnection MyConnection, long id)
        {
            try
            {
                string sql = "DELETE FROM PTDCSNBCT_CT WHERE ID = :ID";
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
        public static PTDCSNBCT GetDataPhieu(MDB.MDBConnection _OracleConnection, long ID)
        {
            PTDCSNBCT data = new PTDCSNBCT();
            try
            {
                string sql = @"SELECT * FROM PTDCSNBCT where ID = :ID ";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID", ID));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = DataReader.GetDecimal("MaQuanLy");
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.Giuong = DataReader["Giuong"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.DM = DataReader["DM"].ToString();
                    data.TM = DataReader["TM"].ToString();
                    data.Quay1 = DataReader["Quay1"].ToString();
                    data.Quay2 = DataReader["Quay2"].ToString();
                    data.Quay3 = DataReader["Quay3"].ToString();
                    data.Quay4 = DataReader["Quay4"].ToString();
                    data.Quay5 = DataReader["Quay5"].ToString();
                    data.Quay6 = DataReader["Quay6"].ToString();
                    data.Quay7 = DataReader["Quay7"].ToString();
                    data.Quay8 = DataReader["Quay8"].ToString();
                    data.Quay9 = DataReader["Quay9"].ToString();
                    data.Quay10 = DataReader["Quay10"].ToString();
                    data.Dui1 = DataReader["Dui1"].ToString();
                    data.Dui2 = DataReader["Dui2"].ToString();
                    data.Dui3 = DataReader["Dui3"].ToString();
                    data.Dui4 = DataReader["Dui4"].ToString();
                    data.Dui5 = DataReader["Dui5"].ToString();
                    data.Dui6 = DataReader["Dui6"].ToString();
                    data.Dui7 = DataReader["Dui7"].ToString();
                    data.Dui8 = DataReader["Dui8"].ToString();
                    data.Dui9 = DataReader["Dui9"].ToString();
                    data.Dui10 = DataReader["Dui10"].ToString();
                    data.KhoaChuyenDen = DataReader["KhoaChuyenDen"].ToString();
                    data.Khoa = DataReader["Khoa"].ToString();
                    data.MaKhoa = DataReader["MaKhoa"].ToString();
                    data.MaDD = DataReader["MaDD"].ToString();
                    data.DD = DataReader["DD"].ToString();
                    data.ChocMach = DataReader["ChocMach"].ToString();
                    data.ChiDinh = DataReader["ChiDinh"].ToString();
                    data.CanThiep = DataReader["CanThiep"].ToString();
                    data.GioEp = DataReader["GioEp"].ToString();
                    data.TTNBTruocCT = DataReader["TTNBTruocCT"].ToString();
                    data.TTNBTrongCT = DataReader["TTNBTrongCT"].ToString();
                    data.TTNBSauCT = DataReader["TTNBSauCT"].ToString();
                    data.Quay11 = DataReader["Quay11"].ToString();
                    data.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                    data.NguoiTao = DataReader["NguoiTao"].ToString();
                    data.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);
                    data.NguoiSua = DataReader["NguoiSua"].ToString();

                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return data;
        }
        public static ObservableCollection<PTDCSNBCT> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            ObservableCollection<PTDCSNBCT> list = new ObservableCollection<PTDCSNBCT>();
            
            try
            {
                string sql = @"SELECT * FROM PTDCSNBCT where MaQuanLy = :MaQuanLy ORDER BY NgayTao";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PTDCSNBCT data = new PTDCSNBCT();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = DataReader.GetDecimal("MaQuanLy");
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.TenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.Giuong = DataReader["Giuong"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.DM = DataReader["DM"].ToString();
                    data.TM = DataReader["TM"].ToString();
                    data.Quay1 = DataReader["Quay1"].ToString();
                    data.Quay2 = DataReader["Quay2"].ToString();
                    data.Quay3 = DataReader["Quay3"].ToString();
                    data.Quay4 = DataReader["Quay4"].ToString();
                    data.Quay5 = DataReader["Quay5"].ToString();
                    data.Quay6 = DataReader["Quay6"].ToString();
                    data.Quay7 = DataReader["Quay7"].ToString();
                    data.Quay8 = DataReader["Quay8"].ToString();
                    data.Quay9 = DataReader["Quay9"].ToString();
                    data.Quay10 = DataReader["Quay10"].ToString();
                    data.Dui1 = DataReader["Dui1"].ToString();
                    data.Dui2 = DataReader["Dui2"].ToString();
                    data.Dui3 = DataReader["Dui3"].ToString();
                    data.Dui4 = DataReader["Dui4"].ToString();
                    data.Dui5 = DataReader["Dui5"].ToString();
                    data.Dui6 = DataReader["Dui6"].ToString();
                    data.Dui7 = DataReader["Dui7"].ToString();
                    data.Dui8 = DataReader["Dui8"].ToString();
                    data.Dui9 = DataReader["Dui9"].ToString();
                    data.Dui10 = DataReader["Dui10"].ToString();
                    data.KhoaChuyenDen = DataReader["KhoaChuyenDen"].ToString();
                    data.Khoa = DataReader["Khoa"].ToString();
                    data.MaKhoa = DataReader["MaKhoa"].ToString();
                    data.MaDD = DataReader["MaDD"].ToString();
                    data.DD = DataReader["DD"].ToString();
                    data.ChocMach = DataReader["ChocMach"].ToString();
                    data.ChiDinh = DataReader["ChiDinh"].ToString(); 
                    data.CanThiep = DataReader["CanThiep"].ToString();
                    data.GioEp = DataReader["GioEp"].ToString();
                    data.TTNBTruocCT = DataReader["TTNBTruocCT"].ToString();
                    data.TTNBTrongCT = DataReader["TTNBTrongCT"].ToString();
                    data.TTNBSauCT = DataReader["TTNBSauCT"].ToString();
                    data.Quay11 = DataReader["Quay11"].ToString();
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

        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PTDCSNBCT bangTheoDoi)
        {
            try
            {
                string sql = @"INSERT INTO PTDCSNBCT
                (
                    MAQUANLY,
                    MaBenhNhan,
                    Giuong,
                    ChanDoan,
                    DM,
                    TM,
                    Quay1,
                    Quay2,
                    Quay3,
                    Quay4,
                    Quay5,
                    Quay6,
                    Quay7,
                    Quay8,
                    Quay9,
                    Quay10,
                    Dui1,
                    Dui2,
                    Dui3,
                    Dui4,
                    Dui5,
                    Dui6,
                    Dui7,
                    Dui8,
                    Dui9,
                    Dui10,
                    KhoaChuyenDen, Khoa, MaKhoa,
                    MaDD,
                    DD,
                    ChocMach,
                    ChiDinh,CanThiep, GioEp,TTNBTruocCT,TTNBTrongCT,TTNBSauCT,Quay11,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :Giuong,
                    :ChanDoan,
                    :DM,
                    :TM,
                    :Quay1,
                    :Quay2,
                    :Quay3,
                    :Quay4,
                    :Quay5,
                    :Quay6,
                    :Quay7,
                    :Quay8,
                    :Quay9,
                    :Quay10,
                    :Dui1,
                    :Dui2,
                    :Dui3,
                    :Dui4,
                    :Dui5,
                    :Dui6,
                    :Dui7,
                    :Dui8,
                    :Dui9,
                    :Dui10,
                    :KhoaChuyenDen, :Khoa, :MaKhoa,
                    :MaDD,
                    :DD,
                    :ChocMach,
                    :ChiDinh,:CanThiep, :GioEp,:TTNBTruocCT,:TTNBTrongCT,:TTNBSauCT,:Quay11,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (bangTheoDoi.ID != 0)
                {
                    sql = @"UPDATE PTDCSNBCT SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    Giuong = :Giuong,
                    ChanDoan = :ChanDoan,
                    DM = :DM,
                    TM = :TM,
                    Quay1 =:Quay1,
                    Quay2 =:Quay2,
                    Quay3 =:Quay3,
                    Quay4 =:Quay4,
                    Quay5 =:Quay5,
                    Quay6 =:Quay6,
                    Quay7 =:Quay7,
                    Quay8 =:Quay8,
                    Quay9 =:Quay9,
                    Quay10 =:Quay10,
                    Dui1 =:Dui1,
                    Dui2 =:Dui2,
                    Dui3 =:Dui3,
                    Dui4 =:Dui4,
                    Dui5 =:Dui5,
                    Dui6 =:Dui6,
                    Dui7 =:Dui7,
                    Dui8 =:Dui8,
                    Dui9 =:Dui9,
                    Dui10 =:Dui10,
                    KhoaChuyenDen =:KhoaChuyenDen, Khoa =:Khoa, MaKhoa =:MaKhoa,
                    MaDD =:MaDD,
                    DD =:DD,
                    ChocMach =:ChocMach,
                    ChiDinh =:ChiDinh,CanThiep =:CanThiep, GioEp =:GioEp,TTNBTruocCT =:TTNBTruocCT,TTNBTrongCT =:TTNBTrongCT,TTNBSauCT =:TTNBSauCT,Quay11 =:Quay11,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + bangTheoDoi.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangTheoDoi.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", bangTheoDoi.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("Giuong", bangTheoDoi.Giuong));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", bangTheoDoi.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("DM", bangTheoDoi.DM));
                Command.Parameters.Add(new MDB.MDBParameter("TM", bangTheoDoi.TM));
                Command.Parameters.Add(new MDB.MDBParameter("Quay1", bangTheoDoi.Quay1));
                Command.Parameters.Add(new MDB.MDBParameter("Quay2", bangTheoDoi.Quay2));
                Command.Parameters.Add(new MDB.MDBParameter("Quay3", bangTheoDoi.Quay3));
                Command.Parameters.Add(new MDB.MDBParameter("Quay4", bangTheoDoi.Quay4));
                Command.Parameters.Add(new MDB.MDBParameter("Quay5", bangTheoDoi.Quay5));
                Command.Parameters.Add(new MDB.MDBParameter("Quay6", bangTheoDoi.Quay6));
                Command.Parameters.Add(new MDB.MDBParameter("Quay7", bangTheoDoi.Quay7));
                Command.Parameters.Add(new MDB.MDBParameter("Quay8", bangTheoDoi.Quay8));
                Command.Parameters.Add(new MDB.MDBParameter("Quay9", bangTheoDoi.Quay9));
                Command.Parameters.Add(new MDB.MDBParameter("Quay10", bangTheoDoi.Quay10));
                Command.Parameters.Add(new MDB.MDBParameter("Dui1", bangTheoDoi.Dui1));
                Command.Parameters.Add(new MDB.MDBParameter("Dui2", bangTheoDoi.Dui2));
                Command.Parameters.Add(new MDB.MDBParameter("Dui3", bangTheoDoi.Dui3));
                Command.Parameters.Add(new MDB.MDBParameter("Dui4", bangTheoDoi.Dui4));
                Command.Parameters.Add(new MDB.MDBParameter("Dui5", bangTheoDoi.Dui5));
                Command.Parameters.Add(new MDB.MDBParameter("Dui6", bangTheoDoi.Dui6));
                Command.Parameters.Add(new MDB.MDBParameter("Dui7", bangTheoDoi.Dui7));
                Command.Parameters.Add(new MDB.MDBParameter("Dui8", bangTheoDoi.Dui8));
                Command.Parameters.Add(new MDB.MDBParameter("Dui9", bangTheoDoi.Dui9));
                Command.Parameters.Add(new MDB.MDBParameter("Dui10", bangTheoDoi.Dui10));
                Command.Parameters.Add(new MDB.MDBParameter("KhoaChuyenDen", bangTheoDoi.KhoaChuyenDen));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa", bangTheoDoi.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaKhoa", bangTheoDoi.MaKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaDD", bangTheoDoi.MaDD));
                Command.Parameters.Add(new MDB.MDBParameter("DD", bangTheoDoi.DD));
                Command.Parameters.Add(new MDB.MDBParameter("ChocMach", bangTheoDoi.ChocMach));
                Command.Parameters.Add(new MDB.MDBParameter("ChiDinh", bangTheoDoi.ChiDinh));
                Command.Parameters.Add(new MDB.MDBParameter("CanThiep", bangTheoDoi.CanThiep));
                Command.Parameters.Add(new MDB.MDBParameter("GioEp", bangTheoDoi.GioEp));
                Command.Parameters.Add(new MDB.MDBParameter("TTNBTruocCT", bangTheoDoi.TTNBTruocCT));
                Command.Parameters.Add(new MDB.MDBParameter("TTNBTrongCT", bangTheoDoi.TTNBTrongCT));
                Command.Parameters.Add(new MDB.MDBParameter("TTNBSauCT", bangTheoDoi.TTNBSauCT));
                Command.Parameters.Add(new MDB.MDBParameter("Quay11", bangTheoDoi.Quay11));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", bangTheoDoi.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", bangTheoDoi.NgaySua));
                if (bangTheoDoi.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", bangTheoDoi.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", bangTheoDoi.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", bangTheoDoi.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (bangTheoDoi.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    bangTheoDoi.ID = nextval;
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
                string sql = "DELETE FROM PTDCSNBCT WHERE ID = :ID";
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

