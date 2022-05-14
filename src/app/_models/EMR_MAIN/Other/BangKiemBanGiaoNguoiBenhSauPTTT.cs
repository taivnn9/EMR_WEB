using EMR.KyDienTu;
using MDB;
using Newtonsoft.Json;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class KetQuaBanGiao
    {
        public string NoiDung { get; set; }
        public bool BanGiaoCo { get; set; }
        public bool BanGiaoKhong { get; set; }
        public bool NhanBanGiaoCo { get; set; }
        public bool NhanBanGiaoKhong { get; set; }
    }
    public class BangKiemBanGiaoNguoiBenhSauPTTT : ThongTinKy
    {
        public BangKiemBanGiaoNguoiBenhSauPTTT()
        {
            TableName = "BangKiemCBBGSauPTTT";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BKCBBGSPTTT;
            TenMauPhieu = DanhMucPhieu.BKCBBGSPTTT.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")] 
        public string HoTenNguoiBenh { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Họ tên người nhận bàn giao")]
        public string NguoiNhanBanGiao { get; set; }
        [MoTaDuLieu("Mã người nhận bàn giao")]
        public string MaNguoiNhanBanGiao { get; set; }
        [MoTaDuLieu("Thời gian bàn giao")]
        public DateTime? ThoiGianBanGiao { get; set; }
        [MoTaDuLieu("Tình hình tiếp xúc")]
        public bool[] TinhHinhTiepXucArray { get; } = new bool[] { false, false, false, false, false, false };
        public string TinhHinhTiepXuc
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TinhHinhTiepXucArray.Length; i++)
                    temp += (TinhHinhTiepXucArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TinhHinhTiepXucArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] DHSTArray { get; } = new bool[] { false, false, false, false };
        public string DHST
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < DHSTArray.Length; i++)
                    temp += (DHSTArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DHSTArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public int? Mach { get; set; }
        public double? NhietDo { get; set; }
        [MoTaDuLieu("Huyết áp")]
		public string HuyetAp { get; set; }
        public int? NhipTho { get; set; }
        public int? ThoOxy { get; set; }
        public bool[] ThoOxyCheckArray { get; } = new bool[] { false, false, false, false, false, false };
        public string ThoOxyCheck
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ThoOxyCheckArray.Length; i++)
                    temp += (ThoOxyCheckArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ThoOxyCheckArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string LoaiSondeDanluu { get; set; }
        public bool[] LoaiSondeArray { get; } = new bool[] { false, false, false, false };
        public string LoaiSonde
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < LoaiSondeArray.Length; i++)
                    temp += (LoaiSondeArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        LoaiSondeArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] ThayQuanAoArray { get; } = new bool[] { false, false, false, false };
        public string ThayQuanAo
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ThayQuanAoArray.Length; i++)
                    temp += (ThayQuanAoArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ThayQuanAoArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] BenhAnArray { get; } = new bool[] { false, false, false, false };
        public string BenhAn
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < BenhAnArray.Length; i++)
                    temp += (BenhAnArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        BenhAnArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public ObservableCollection<KetQuaBanGiao> XetNghiem { get; set; }
        public ObservableCollection<KetQuaBanGiao> BanGiaoThuoc { get; set; }
        public ObservableCollection<KetQuaBanGiao> NoiDungKhac { get; set; }
        [MoTaDuLieu("Họ tên người bàn giao")]
        public string NguoiBanGiao { get; set; }
        [MoTaDuLieu("Mã người bàn giao")]
        public string MaNguoiBanGiao { get; set; }
        [MoTaDuLieu("Người xác nhận")]
        public string NguoiXacNhan { get; set; }
        [MoTaDuLieu("Mã người xác nhận")]
        public string MaNguoiXacNhan { get; set; }
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
    public class BangKiemBanGiaoNguoiBenhSauPTTTFunc
    {
        public const string TableName = "BangKiemCBBGSauPTTT";
        public const string TablePrimaryKeyName = "ID";
        public static List<BangKiemBanGiaoNguoiBenhSauPTTT> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BangKiemBanGiaoNguoiBenhSauPTTT> list = new List<BangKiemBanGiaoNguoiBenhSauPTTT>();
            try
            {
                string sql = @"SELECT * FROM BangKiemCBBGSauPTTT where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    BangKiemBanGiaoNguoiBenhSauPTTT data = new BangKiemBanGiaoNguoiBenhSauPTTT();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.HoTenNguoiBenh = DataReader["HoTenNguoiBenh"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.NguoiNhanBanGiao = DataReader["NguoiNhanBanGiao"].ToString();
                    data.MaNguoiNhanBanGiao = DataReader["MaNguoiNhanBanGiao"].ToString();
                    data.ThoiGianBanGiao = DataReader["ThoiGianBanGiao"] == DBNull.Value ? (DateTime?)null : DataReader.GetDate("ThoiGianBanGiao");
                    data.TinhHinhTiepXuc = DataReader["TinhHinhTiepXuc"].ToString();
                    data.DHST = DataReader["DHST"].ToString();

                    int intTemp = 0;
                    data.Mach = int.TryParse(DataReader["Mach"].ToString(), out intTemp) ? intTemp : (int?) null;
                    double doubleTemp = 0;
                    data.NhietDo = double.TryParse(DataReader["NhietDo"].ToString(), out doubleTemp) ? doubleTemp : (double?)null;
                    data.HuyetAp = DataReader["HuyetAp"].ToString();
                    intTemp = 0;
                    data.NhipTho = int.TryParse(DataReader["NhipTho"].ToString(), out intTemp) ? intTemp : (int?)null;
                    intTemp = 0;
                    data.ThoOxy = int.TryParse(DataReader["ThoOxy"].ToString(), out intTemp) ? intTemp : (int?)null;

                    data.ThoOxyCheck = DataReader["ThoOxyCheck"].ToString();
                    data.LoaiSondeDanluu = DataReader["LoaiSondeDanluu"].ToString();
                    data.LoaiSonde = DataReader["LoaiSonde"].ToString();
                    data.ThayQuanAo = DataReader["ThayQuanAo"].ToString();
                    data.BenhAn = DataReader["BenhAn"].ToString();
                    data.XetNghiem = JsonConvert.DeserializeObject<ObservableCollection<KetQuaBanGiao>>(DataReader["XetNghiem"].ToString());
                    data.BanGiaoThuoc = JsonConvert.DeserializeObject<ObservableCollection<KetQuaBanGiao>>(DataReader["BanGiaoThuoc"].ToString());
                    data.NoiDungKhac = JsonConvert.DeserializeObject<ObservableCollection<KetQuaBanGiao>>(DataReader["NoiDungKhac"].ToString());

                    data.NguoiBanGiao = DataReader["NguoiBanGiao"].ToString();
                    data.MaNguoiBanGiao = DataReader["MaNguoiBanGiao"].ToString();
                    data.NguoiXacNhan = DataReader["NguoiXacNhan"].ToString();
                    data.MaNguoiXacNhan = DataReader["MaNguoiXacNhan"].ToString();

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BangKiemBanGiaoNguoiBenhSauPTTT bangKiem)
        {
            try
            {
                string sql = @"INSERT INTO BangKiemCBBGSauPTTT
                (
                    MAQUANLY,
                    MaBenhNhan,
                    HoTenNguoiBenh,
                    ChanDoan,
                    NguoiNhanBanGiao,
                    MaNguoiNhanBanGiao,
                    ThoiGianBanGiao,
                    TinhHinhTiepXuc,
                    DHST,
                    Mach,
                    NhietDo,
                    HuyetAp,
                    NhipTho,
                    ThoOxy,
                    ThoOxyCheck,
                    LoaiSondeDanluu,
                    LoaiSonde,
                    ThayQuanAo,
                    BenhAn,
                    XetNghiem,
                    BanGiaoThuoc,
                    NoiDungKhac,
                    NguoiBanGiao,
                    MaNguoiBanGiao,
                    NguoiXacNhan,
                    MaNguoiXacNhan,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :HoTenNguoiBenh,
                    :ChanDoan,
                    :NguoiNhanBanGiao,
                    :MaNguoiNhanBanGiao,
                    :ThoiGianBanGiao,
                    :TinhHinhTiepXuc,
                    :DHST,
                    :Mach,
                    :NhietDo,
                    :HuyetAp,
                    :NhipTho,
                    :ThoOxy,
                    :ThoOxyCheck,
                    :LoaiSondeDanluu,
                    :LoaiSonde,
                    :ThayQuanAo,
                    :BenhAn,
                    :XetNghiem,
                    :BanGiaoThuoc,
                    :NoiDungKhac,
                    :NguoiBanGiao,
                    :MaNguoiBanGiao,
                    :NguoiXacNhan,
                    :MaNguoiXacNhan,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (bangKiem.ID != 0)
                {
                    sql = @"UPDATE BangKiemCBBGSauPTTT SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    HoTenNguoiBenh = :HoTenNguoiBenh,
                    ChanDoan = :ChanDoan,
                    NguoiNhanBanGiao = :NguoiNhanBanGiao,
                    MaNguoiNhanBanGiao = :MaNguoiNhanBanGiao,
                    ThoiGianBanGiao = :ThoiGianBanGiao,
                    TinhHinhTiepXuc = :TinhHinhTiepXuc,
                    DHST = :DHST,
                    Mach = :Mach,
                    NhietDo = :NhietDo,
                    HuyetAp = :HuyetAp,
                    NhipTho = :NhipTho,
                    ThoOxy = :ThoOxy,
                    ThoOxyCheck = :ThoOxyCheck,
                    LoaiSondeDanluu = :LoaiSondeDanluu,
                    LoaiSonde = :LoaiSonde,
                    ThayQuanAo = :ThayQuanAo,
                    BenhAn = :BenhAn,
                    XetNghiem = :XetNghiem,
                    BanGiaoThuoc = :BanGiaoThuoc,
                    NoiDungKhac = :NoiDungKhac,
                    NguoiBanGiao = :NguoiBanGiao,
                    MaNguoiBanGiao = :MaNguoiBanGiao,
                    NguoiXacNhan = :NguoiXacNhan,
                    MaNguoiXacNhan = :MaNguoiXacNhan,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + bangKiem.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangKiem.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", bangKiem.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("HoTenNguoiBenh", bangKiem.HoTenNguoiBenh));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", bangKiem.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiNhanBanGiao", bangKiem.NguoiNhanBanGiao));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiNhanBanGiao", bangKiem.MaNguoiNhanBanGiao));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianBanGiao", bangKiem.ThoiGianBanGiao));
                Command.Parameters.Add(new MDB.MDBParameter("TinhHinhTiepXuc", bangKiem.TinhHinhTiepXuc));
                Command.Parameters.Add(new MDB.MDBParameter("DHST", bangKiem.DHST));
                Command.Parameters.Add(new MDB.MDBParameter("Mach", bangKiem.Mach));
                Command.Parameters.Add(new MDB.MDBParameter("NhietDo", bangKiem.NhietDo));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetAp", bangKiem.HuyetAp));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTho", bangKiem.NhipTho));
                Command.Parameters.Add(new MDB.MDBParameter("ThoOxy", bangKiem.ThoOxy));
                Command.Parameters.Add(new MDB.MDBParameter("ThoOxyCheck", bangKiem.ThoOxyCheck));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiSondeDanluu", bangKiem.LoaiSondeDanluu));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiSonde", bangKiem.LoaiSonde));
                Command.Parameters.Add(new MDB.MDBParameter("ThayQuanAo", bangKiem.ThayQuanAo));
                Command.Parameters.Add(new MDB.MDBParameter("BenhAn", bangKiem.BenhAn));
                Command.Parameters.Add(new MDB.MDBParameter("XetNghiem", JsonConvert.SerializeObject(bangKiem.XetNghiem)));
                Command.Parameters.Add(new MDB.MDBParameter("BanGiaoThuoc", JsonConvert.SerializeObject(bangKiem.BanGiaoThuoc)));
                Command.Parameters.Add(new MDB.MDBParameter("NoiDungKhac", JsonConvert.SerializeObject(bangKiem.NoiDungKhac)));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiBanGiao", bangKiem.NguoiBanGiao));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiBanGiao", bangKiem.MaNguoiBanGiao));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiXacNhan", bangKiem.NguoiXacNhan));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiXacNhan", bangKiem.MaNguoiXacNhan));

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", bangKiem.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", bangKiem.NgaySua));
                if (bangKiem.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", bangKiem.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", bangKiem.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", bangKiem.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (bangKiem.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    bangKiem.ID = nextval;
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
                string sql = "DELETE FROM BangKiemCBBGSauPTTT WHERE ID = :ID";
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
                B.MAQUANLY,
                B.MaBenhNhan,
                B.HoTenNguoiBenh,
                B.ChanDoan,
                B.NguoiNhanBanGiao,
                B.MaNguoiNhanBanGiao,
                B.ThoiGianBanGiao,
                B.TinhHinhTiepXuc,
                B.DHST,
                B.Mach,
                B.NhietDo,
                B.HuyetAp,
                B.NhipTho,
                B.ThoOxy,
                B.ThoOxyCheck,
                B.LoaiSondeDanluu,
                B.LoaiSonde,
                B.ThayQuanAo,
                B.BenhAn,
                B.NguoiBanGiao,
                B.MaNguoiBanGiao,
                B.NguoiXacNhan,
                B.MaNguoiXacNhan 
            FROM
                BangKiemCBBGSauPTTT B
            WHERE
                B.ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "BK");
            ds.Tables[0].AddColumn("SOYTE", typeof(string));
            ds.Tables[0].AddColumn("BENHVIEN", typeof(string));
            ds.Tables[0].AddColumn("KHOA", typeof(string));

            ds.Tables[0].Rows[0]["SOYTE"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["KHOA"] = XemBenhAn._ThongTinDieuTri.Khoa;

            ExceptionExtend.Log("getDataSet", "==== Count ds.Tables[0].Rows : '" + ds.Tables[0].Rows.Count + "'");
            sql = @"SELECT
                B.XetNghiem, B.BanGiaoThuoc, B.NoiDungKhac
            FROM
                BangKiemCBBGSauPTTT B
                
            WHERE
                B.ID = " + id;

            Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            ObservableCollection<KetQuaBanGiao> XetNghiem = new ObservableCollection<KetQuaBanGiao> ();
            ObservableCollection<KetQuaBanGiao> BanGiaoThuoc = new ObservableCollection<KetQuaBanGiao>();
            ObservableCollection<KetQuaBanGiao> NoiDungKhac = new ObservableCollection<KetQuaBanGiao>();
            while (DataReader.Read())
            {
                XetNghiem = JsonConvert.DeserializeObject<ObservableCollection<KetQuaBanGiao>>(DataReader["XetNghiem"].ToString());
                BanGiaoThuoc = JsonConvert.DeserializeObject<ObservableCollection<KetQuaBanGiao>>(DataReader["BanGiaoThuoc"].ToString());
                NoiDungKhac = JsonConvert.DeserializeObject<ObservableCollection<KetQuaBanGiao>>(DataReader["NoiDungKhac"].ToString());
                break;
            }
            DataTable BK2 = new DataTable("BK2");
            BK2.Columns.Add("NoiDung");
            BK2.Columns.Add("BanGiaoCo");
            BK2.Columns.Add("BanGiaoKhong");
            BK2.Columns.Add("NhanBanGiaoCo");
            BK2.Columns.Add("NhanBanGiaoKhong");
            foreach (KetQuaBanGiao ketQua in XetNghiem)
            {
                BK2.Rows.Add(ketQua.NoiDung, ketQua.BanGiaoCo ? 1 : 0, ketQua.BanGiaoKhong ? 1 : 0, ketQua.NhanBanGiaoCo ? 1 : 0, ketQua.NhanBanGiaoKhong ? 1 : 0);
            }
            DataTable BK3 = new DataTable("BK3");
            BK3.Columns.Add("NoiDung");
            BK3.Columns.Add("BanGiaoCo");
            BK3.Columns.Add("BanGiaoKhong");
            BK3.Columns.Add("NhanBanGiaoCo");
            BK3.Columns.Add("NhanBanGiaoKhong");
            foreach (KetQuaBanGiao ketQua in BanGiaoThuoc)
            {
                BK3.Rows.Add(ketQua.NoiDung, ketQua.BanGiaoCo ? 1 : 0, ketQua.BanGiaoKhong ? 1 : 0, ketQua.NhanBanGiaoCo ? 1 : 0, ketQua.NhanBanGiaoKhong ? 1 : 0);
            }
            DataTable BK4 = new DataTable("BK4");
            BK4.Columns.Add("NoiDung");
            BK4.Columns.Add("BanGiaoCo");
            BK4.Columns.Add("BanGiaoKhong");
            BK4.Columns.Add("NhanBanGiaoCo");
            BK4.Columns.Add("NhanBanGiaoKhong");
            foreach (KetQuaBanGiao ketQua in NoiDungKhac)
            {
                BK4.Rows.Add(ketQua.NoiDung, ketQua.BanGiaoCo ? 1 : 0, ketQua.BanGiaoKhong ? 1 : 0, ketQua.NhanBanGiaoCo ? 1 : 0, ketQua.NhanBanGiaoKhong ? 1 : 0);
            }
            ds.Tables.Add(BK2);
            ds.Tables.Add(BK3);
            ds.Tables.Add(BK4);
            return ds;
        }
    }
}
