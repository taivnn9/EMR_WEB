using EMR.KyDienTu;
using Newtonsoft.Json;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuTDCSNBTaiKhoaCapCuu : ThongTinKy
    {
        public PhieuTDCSNBTaiKhoaCapCuu()
        {
            TableName = "PhieuTDCSNBTaiKhoaCapCuu";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PTDCSNBTKCC;
            TenMauPhieu = DanhMucPhieu.PTDCSNBTKCC.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        public string HoTenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        [MoTaDuLieu("Chẩn đoán nơi chuyển đến")]
		public string ChanDoanNoiChuyenDen { get; set; }
        [MoTaDuLieu("Chẩn đoán tại khoa cấp cứu")]
		public string ChanDoanTaiKhoaCapCuu { get; set; }
        public ObservableCollection<DauHieuSinhTon_CT> DHSTs { get; set; }
        public ObservableCollection<ThuocDichChuyen_CT> ThuocDichChuyens { get; set; }
        public bool[] ChamSocNB1Array { get; } = new bool[] { false, false, false };
        public string ChamSocNB1
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ChamSocNB1Array.Length; i++)
                    temp += (ChamSocNB1Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ChamSocNB1Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] ChamSocNB2Array { get; } = new bool[] { false, false, false };
        public string ChamSocNB2
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ChamSocNB2Array.Length; i++)
                    temp += (ChamSocNB2Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ChamSocNB2Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] ChamSocNB3Array { get; } = new bool[] { false, false, false };
        public string ChamSocNB3
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ChamSocNB3Array.Length; i++)
                    temp += (ChamSocNB3Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ChamSocNB3Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] ChamSocNB4Array { get; } = new bool[] { false, false, false };
        public string ChamSocNB4
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ChamSocNB4Array.Length; i++)
                    temp += (ChamSocNB4Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ChamSocNB4Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] ChamSocNB5Array { get; } = new bool[] { false, false, false };
        public string ChamSocNB5
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ChamSocNB5Array.Length; i++)
                    temp += (ChamSocNB5Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ChamSocNB5Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] ChamSocNB6Array { get; } = new bool[] { false, false, false };
        public string ChamSocNB6
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ChamSocNB6Array.Length; i++)
                    temp += (ChamSocNB6Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ChamSocNB6Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] ChamSocNB7Array { get; } = new bool[] { false, false, false };
        public string ChamSocNB7
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ChamSocNB7Array.Length; i++)
                    temp += (ChamSocNB7Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ChamSocNB7Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] ChamSocNB8Array { get; } = new bool[] { false, false, false };
        public string ChamSocNB8
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ChamSocNB8Array.Length; i++)
                    temp += (ChamSocNB8Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ChamSocNB8Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public ObservableCollection<TheoDoiDacBiet_CT> TheoDoiDBs { get; set; }
        public bool[] CacVanDeKhacArray { get; } = new bool[] { false, false, false, false };
        public string CacVanDeKhac
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < CacVanDeKhacArray.Length; i++)
                    temp += (CacVanDeKhacArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        CacVanDeKhacArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string CacVanDeKhac_Text { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuongPT { get; set; }
        [MoTaDuLieu("Mã điều dưỡng")]
		public string MaDieuDuongPT { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        //public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }

    }
    public class DauHieuSinhTon_CT
    {
        public DateTime? Ngay { get; set; }
        public DateTime? Gio { get; set; }
        public string M { get; set; }
        public string ND { get; set; }
        [MoTaDuLieu("Huyết áp")]
		public string HA { get; set; }
        [MoTaDuLieu("Nhịp tim")]
		public string NT { get; set; }
        public string SPO2 { get; set; }
        public string TG { get; set; }
        public string MaDD { get; set;}
       
    }
    public class ThuocDichChuyen_CT
    {
        public string THL { get; set; }
        public string SL { get; set; }
        public string DuongDung { get; set; }
        public string TocDo { get; set; }
        public string BatDau { get; set; }
        public string KetThuc { get; set; }
        public string DD { get; set; }
        [MoTaDuLieu("Ghi chú")]
		public string GhiChu { get; set; }
        public ThuocDichChuyen_CT Clone()
        {
            return (ThuocDichChuyen_CT)this.MemberwiseClone();
        }
    }
    public class TheoDoiDacBiet_CT
    {
        public DateTime? Ngay { get; set; }
        public DateTime? Gio { get; set; }
        public string DDD { get; set; }
        public string CN { get; set; }
        [MoTaDuLieu("Nhịp tim")]
		public string NT { get; set; }
        public string P { get; set; }
        public string DL { get; set; }
    }
    public class PhieuTDCSNBTaiKhoaCapCuuFunc
    {
        public const string TableName = "PhieuTDCSNBTaiKhoaCapCuu";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuTDCSNBTaiKhoaCapCuu> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuTDCSNBTaiKhoaCapCuu> list = new List<PhieuTDCSNBTaiKhoaCapCuu>();
            try
            {
                string sql = @"SELECT * FROM PhieuTDCSNBTaiKhoaCapCuu where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuTDCSNBTaiKhoaCapCuu data = new PhieuTDCSNBTaiKhoaCapCuu();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.HoTenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.DiaChi = DataReader["DiaChi"].ToString();
                    data.ChanDoanNoiChuyenDen = DataReader["ChanDoanNoiChuyenDen"].ToString();
                    data.ChanDoanTaiKhoaCapCuu = DataReader["ChanDoanTaiKhoaCapCuu"].ToString();
                    int tempInt = 0;
                    
                    string bangKeJson = DataReader["DHSTs_1"].ToString();
                    if (DataReader["DHSTs_2"] != DBNull.Value)
                        bangKeJson += DataReader["DHSTs_2"].ToString();
                    data.DHSTs = JsonConvert.DeserializeObject<ObservableCollection<DauHieuSinhTon_CT>>(bangKeJson);

                    bangKeJson = DataReader["ThuocDichChuyens_1"].ToString();
                    if (DataReader["ThuocDichChuyens_2"] != DBNull.Value)
                        bangKeJson += DataReader["ThuocDichChuyens_2"].ToString();
                    data.ThuocDichChuyens = JsonConvert.DeserializeObject<ObservableCollection<ThuocDichChuyen_CT>>(bangKeJson);

                    data.ChamSocNB1 = DataReader["ChamSocNB1"].ToString();
                    data.ChamSocNB2 = DataReader["ChamSocNB2"].ToString();
                    data.ChamSocNB3 = DataReader["ChamSocNB3"].ToString();
                    data.ChamSocNB4 = DataReader["ChamSocNB4"].ToString();
                    data.ChamSocNB5 = DataReader["ChamSocNB5"].ToString();
                    data.ChamSocNB6 = DataReader["ChamSocNB6"].ToString();
                    data.ChamSocNB7 = DataReader["ChamSocNB7"].ToString();
                    data.ChamSocNB8 = DataReader["ChamSocNB8"].ToString();

                    bangKeJson = DataReader["TheoDoiDBs_1"].ToString();
                    if (DataReader["TheoDoiDBs_2"] != DBNull.Value)
                        bangKeJson += DataReader["TheoDoiDBs_2"].ToString();
                    data.TheoDoiDBs = JsonConvert.DeserializeObject<ObservableCollection<TheoDoiDacBiet_CT>>(bangKeJson);

                    data.CacVanDeKhac = DataReader["CacVanDeKhac"].ToString();
                    data.CacVanDeKhac_Text = DataReader["CacVanDeKhac_Text"].ToString();
                    data.DieuDuongPT = DataReader["DieuDuongPT"].ToString();
                    data.MaDieuDuongPT = DataReader["MaDieuDuongPT"].ToString();

                    data.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                    data.NguoiTao = DataReader["NguoiTao"].ToString();
                    data.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);
                    data.NguoiSua = DataReader["NguoiSua"].ToString();

                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;
                    list.Add(data);
                }
                DataReader.Close();
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuTDCSNBTaiKhoaCapCuu bangKe)
        {
            try
            {
                string sql = @"INSERT INTO PhieuTDCSNBTaiKhoaCapCuu
                (
                    MAQUANLY,
                    MaBenhNhan,
                    DiaChi,
                    ChanDoanNoiChuyenDen,
                    ChanDoanTaiKhoaCapCuu,
                    DHSTs_1,
                    DHSTs_2,
                    ThuocDichChuyens_1,
                    ThuocDichChuyens_2,
                    ChamSocNB1,
                    ChamSocNB2,
                    ChamSocNB3,
                    ChamSocNB4,
                    ChamSocNB5,
                    ChamSocNB6,
                    ChamSocNB7,
                    ChamSocNB8,
                    TheoDoiDBs_1,
                    TheoDoiDBs_2,
                    CacVanDeKhac,
                    CacVanDeKhac_Text,
                    DieuDuongPT,
                    MaDieuDuongPT,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :DiaChi,
                    :ChanDoanNoiChuyenDen,
                    :ChanDoanTaiKhoaCapCuu,
                    :DHSTs_1,
                    :DHSTs_2,
                    :ThuocDichChuyens_1,
                    :ThuocDichChuyens_2,
                    :ChamSocNB1,
                    :ChamSocNB2,
                    :ChamSocNB3,
                    :ChamSocNB4,
                    :ChamSocNB5,
                    :ChamSocNB6,
                    :ChamSocNB7,
                    :ChamSocNB8,
                    :TheoDoiDBs_1,
                    :TheoDoiDBs_2,
                    :CacVanDeKhac,
                    :CacVanDeKhac_Text,
                    :DieuDuongPT,
                    :MaDieuDuongPT,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (bangKe.ID != 0)
                {
                    sql = @"UPDATE PhieuTDCSNBTaiKhoaCapCuu SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    DiaChi = :DiaChi,
                    ChanDoanNoiChuyenDen=:ChanDoanNoiChuyenDen,
                    ChanDoanTaiKhoaCapCuu=:ChanDoanTaiKhoaCapCuu,
                    DHSTs_1=:DHSTs_1,
                    DHSTs_2=:DHSTs_2,
                    ThuocDichChuyens_1=:ThuocDichChuyens_1,
                    ThuocDichChuyens_2=:ThuocDichChuyens_2,
                    ChamSocNB1=:ChamSocNB1,
                    ChamSocNB2=:ChamSocNB2,
                    ChamSocNB3=:ChamSocNB3,
                    ChamSocNB4=:ChamSocNB4,
                    ChamSocNB5=:ChamSocNB5,
                    ChamSocNB6=:ChamSocNB6,
                    ChamSocNB7=:ChamSocNB7,
                    ChamSocNB8=:ChamSocNB8,
                    TheoDoiDBs_1=:TheoDoiDBs_1,
                    TheoDoiDBs_2=:TheoDoiDBs_2,
                    CacVanDeKhac=:CacVanDeKhac,
                    CacVanDeKhac_Text=:CacVanDeKhac_Text,
                    DieuDuongPT=:DieuDuongPT,
                    MaDieuDuongPT=:MaDieuDuongPT,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + bangKe.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangKe.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", bangKe.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", bangKe.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanNoiChuyenDen", bangKe.ChanDoanNoiChuyenDen));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTaiKhoaCapCuu", bangKe.ChanDoanTaiKhoaCapCuu));
                string jsonBangKes = JsonConvert.SerializeObject(bangKe.DHSTs);
                List<string> listJson = new List<string>();
                for (int i = 0; i < jsonBangKes.Length; i += 3999)
                {
                    if ((i + 3999) < jsonBangKes.Length)
                        listJson.Add(jsonBangKes.Substring(i, 3999));
                    else
                        listJson.Add(jsonBangKes.Substring(i));
                }
                Command.Parameters.Add(new MDB.MDBParameter("DHSTs_1", listJson[0]));
                Command.Parameters.Add(new MDB.MDBParameter("DHSTs_2", listJson.Count > 1 ? listJson[1] : null));

                jsonBangKes = JsonConvert.SerializeObject(bangKe.ThuocDichChuyens);
                listJson = new List<string>();
                for (int i = 0; i < jsonBangKes.Length; i += 3999)
                {
                    if ((i + 3999) < jsonBangKes.Length)
                        listJson.Add(jsonBangKes.Substring(i, 3999));
                    else
                        listJson.Add(jsonBangKes.Substring(i));
                }
                Command.Parameters.Add(new MDB.MDBParameter("ThuocDichChuyens_1", listJson[0]));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocDichChuyens_2", listJson.Count > 1 ? listJson[1] : null));
                
                Command.Parameters.Add(new MDB.MDBParameter("ChamSocNB1", bangKe.ChamSocNB1));
                Command.Parameters.Add(new MDB.MDBParameter("ChamSocNB2", bangKe.ChamSocNB2));
                Command.Parameters.Add(new MDB.MDBParameter("ChamSocNB3", bangKe.ChamSocNB3));
                Command.Parameters.Add(new MDB.MDBParameter("ChamSocNB4", bangKe.ChamSocNB4));
                Command.Parameters.Add(new MDB.MDBParameter("ChamSocNB5", bangKe.ChamSocNB5));
                Command.Parameters.Add(new MDB.MDBParameter("ChamSocNB6", bangKe.ChamSocNB6));
                Command.Parameters.Add(new MDB.MDBParameter("ChamSocNB7", bangKe.ChamSocNB7));
                Command.Parameters.Add(new MDB.MDBParameter("ChamSocNB8", bangKe.ChamSocNB8));
                
                jsonBangKes = JsonConvert.SerializeObject(bangKe.TheoDoiDBs);
                listJson = new List<string>();
                for (int i = 0; i < jsonBangKes.Length; i += 3999)
                {
                    if ((i + 3999) < jsonBangKes.Length)
                        listJson.Add(jsonBangKes.Substring(i, 3999));
                    else
                        listJson.Add(jsonBangKes.Substring(i));
                }
                Command.Parameters.Add(new MDB.MDBParameter("TheoDoiDBs_1", listJson[0]));
                Command.Parameters.Add(new MDB.MDBParameter("TheoDoiDBs_2", listJson.Count > 1 ? listJson[1] : null));
                Command.Parameters.Add(new MDB.MDBParameter("CacVanDeKhac", bangKe.CacVanDeKhac));
                Command.Parameters.Add(new MDB.MDBParameter("CacVanDeKhac_Text", bangKe.CacVanDeKhac_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuongPT", bangKe.DieuDuongPT));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuongPT", bangKe.MaDieuDuongPT));

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
        public static bool Delete(MDB.MDBConnection MyConnection, long id)
        {
            try
            {
                string sql = "DELETE FROM PhieuTDCSNBTaiKhoaCapCuu WHERE ID = :ID";
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
                B.MAQUANLY,
                B.MaBenhNhan,
                B.DiaChi,
                B.ChanDoanNoiChuyenDen,
                B.ChanDoanTaiKhoaCapCuu,
                B.ChamSocNB1,
                B.ChamSocNB2,
                B.ChamSocNB3,
                B.ChamSocNB4,
                B.ChamSocNB5,
                B.ChamSocNB6,
                B.ChamSocNB7,
                B.ChamSocNB8,
                B.CacVanDeKhac,
                B.CacVanDeKhac_Text,
                B.DieuDuongPT,
                B.MaDieuDuongPT
            FROM
                PhieuTDCSNBTaiKhoaCapCuu B
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "KQ");

            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(int));
            ds.Tables[0].AddColumn("SOYTE", typeof(string));
            ds.Tables[0].AddColumn("BENHVIEN", typeof(string));
            ds.Tables[0].AddColumn("MaBenhAn", typeof(string));
            ds.Tables[0].AddColumn("SoVaoVien", typeof(string));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["GioiTinh"] = (int)XemBenhAn._HanhChinhBenhNhan.GioiTinh;
            ds.Tables[0].Rows[0]["SOYTE"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["MaBenhAn"] = XemBenhAn._ThongTinDieuTri.MaBenhAn;
            ds.Tables[0].Rows[0]["SoVaoVien"] = XemBenhAn._ThongTinDieuTri.SoNhapVien;

            sql = @"SELECT
               B.DHSTs_1,
               B.DHSTs_2,
               B.ThuocDichChuyens_1,
               B.ThuocDichChuyens_2,
               B.ThuocDichChuyens_1,
               B.ThuocDichChuyens_2,
               B.TheoDoiDBs_1,
               B.TheoDoiDBs_2 
            FROM
                PhieuTDCSNBTaiKhoaCapCuu B   
            WHERE
                ID = " + id;

            Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            ObservableCollection<DauHieuSinhTon_CT> DHSTs = new ObservableCollection<DauHieuSinhTon_CT>();
            ObservableCollection<ThuocDichChuyen_CT> ThuocDichChuyens = new ObservableCollection<ThuocDichChuyen_CT>();
            ObservableCollection<TheoDoiDacBiet_CT> TheoDoiDBs = new ObservableCollection<TheoDoiDacBiet_CT>();
            while (DataReader.Read())
            {
                string bangKeJson = DataReader["DHSTs_1"].ToString();
                if (DataReader["DHSTs_2"] != DBNull.Value)
                    bangKeJson += DataReader["DHSTs_2"].ToString();
                DHSTs = JsonConvert.DeserializeObject<ObservableCollection<DauHieuSinhTon_CT>>(bangKeJson);

                bangKeJson = DataReader["ThuocDichChuyens_1"].ToString();
                if (DataReader["ThuocDichChuyens_2"] != DBNull.Value)
                    bangKeJson += DataReader["ThuocDichChuyens_2"].ToString();
                ThuocDichChuyens = JsonConvert.DeserializeObject<ObservableCollection<ThuocDichChuyen_CT>>(bangKeJson);

                bangKeJson = DataReader["TheoDoiDBs_1"].ToString();
                if (DataReader["TheoDoiDBs_2"] != DBNull.Value)
                    bangKeJson += DataReader["TheoDoiDBs_2"].ToString();
                TheoDoiDBs = JsonConvert.DeserializeObject<ObservableCollection<TheoDoiDacBiet_CT>>(bangKeJson);
            }
            DataReader.Close();
            DataTable tableDHST = Common.ListToDataTable(DHSTs.ToList(), "DHST");
            tableDHST.AddColumn("DD", typeof(string));
            for(int i = 0; i < tableDHST.Rows.Count; i++)
            {
                NhanVien DieuDuong = NhanVienFunc.ListNhanVien.Find(x => x.MaNhanVien.Equals(tableDHST.Rows[i]["MaDD"]));
                if (DieuDuong != null)
                    tableDHST.Rows[i]["DD"] = DieuDuong.HoVaTen;
            }

            DataTable tableThuocDichChuyens = Common.ListToDataTable(ThuocDichChuyens.ToList(), "TDT");
            DataTable tableTheoDoiDBs = Common.ListToDataTable(TheoDoiDBs.ToList(), "TD");

            ds.Tables.Add(tableDHST);
            ds.Tables.Add(tableThuocDichChuyens);
            ds.Tables.Add(tableTheoDoiDBs);

            return ds;
        }
    }
}
