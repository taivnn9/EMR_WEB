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
    public class GiayCamDoanDYTTDQT : ThongTinKy
    {
        public GiayCamDoanDYTTDQT()
        {
            TableName = "GiayCamDoanDYTTDQT";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.GCDDYTTDQT;
            TenMauPhieu = DanhMucPhieu.GCDDYTTDQT.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Mã bệnh án")]
		public string MaBenhAn { get; set; }
        public string TenToiLa { get; set; }

        [MoTaDuLieu("Năm sinh")]
		public string NamSinh { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }

        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        public string HoVaTen { get; set; }

        public string TinhOrHuyen { get; set; }
        public DateTime? NgayVietDon { get; set; }

        public bool[] DaTungTiemArray { get; } = new bool[] { false, false };
        public string DaTungTiem
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < DaTungTiemArray.Length; i++)
                    temp += DaTungTiemArray[i] ? "1" : "0";
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DaTungTiemArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string DaTungTiem_Text { get; set; }

        public bool[] DiUngThuocArray { get; } = new bool[] { false, false };
        public string DiUngThuoc
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < DiUngThuocArray.Length; i++)
                    temp += DiUngThuocArray[i] ? "1" : "0";
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DiUngThuocArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string DiUngThuoc_Text { get; set; }
        public bool[] DieuTriDiUngArray { get; } = new bool[] { false, false };
        public string DieuTriDiUng
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < DieuTriDiUngArray.Length; i++)
                    temp += DieuTriDiUngArray[i] ? "1" : "0";
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DieuTriDiUngArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string DieuTriDiUng_Text { get; set; }
        public bool[] DiUngKSArray { get; } = new bool[] { false, false };
        public string DiUngKS
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < DiUngKSArray.Length; i++)
                    temp += DiUngKSArray[i] ? "1" : "0";
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DiUngKSArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string DiUngKS_Text { get; set; }
        public bool[] DiUngTAArray { get; } = new bool[] { false, false };
        public string DiUngTA
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < DiUngTAArray.Length; i++)
                    temp += DiUngTAArray[i] ? "1" : "0";
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DiUngTAArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string DiUngTA_Text { get; set; }     
        public bool[] DiUngConTrungArray { get; } = new bool[] { false, false };
        public string DiUngConTrung
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < DiUngConTrungArray.Length; i++)
                    temp += DiUngConTrungArray[i] ? "1" : "0";
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DiUngConTrungArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string DiUngConTrung_Text { get; set; }     
        public bool[] HenPheQuanArray { get; } = new bool[] { false, false };
        public string HenPheQuan
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < HenPheQuanArray.Length; i++)
                    temp += HenPheQuanArray[i] ? "1" : "0";
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        HenPheQuanArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string HenPheQuan_Text { get; set; }
        public bool[] TimGanThanArray { get; } = new bool[] { false, false };
        public string TimGanThan
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TimGanThanArray.Length; i++)
                    temp += TimGanThanArray[i] ? "1" : "0";
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TimGanThanArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string TimGanThan_Text { get; set; }
        public bool[] BLManTinhArray { get; } = new bool[] { false, false };
        public string BLManTinh
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < BLManTinhArray.Length; i++)
                    temp += BLManTinhArray[i] ? "1" : "0";
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        BLManTinhArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string BLManTinh_Text { get; set; }
        public bool[] NuoiConArray { get; } = new bool[] { false, false };
        public string NuoiCon
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < NuoiConArray.Length; i++)
                    temp += NuoiConArray[i] ? "1" : "0";
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NuoiConArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string NuoiCon_Text { get; set; }
        public bool[] CoThaiArray { get; } = new bool[] { false, false };
        public string CoThai
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < CoThaiArray.Length; i++)
                    temp += CoThaiArray[i] ? "1" : "0";
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        CoThaiArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string CoThai_Text { get; set; }

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
        public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }

    }
    
    public class GiayCamDoanDYTTDQTFunc
    {
        public const string TableName = "GiayCamDoanDYTTDQT";
        public const string TablePrimaryKeyName = "ID";
        public const string MaPhieu = "GCDDYTTDQT";

        public static List<GiayCamDoanDYTTDQT> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<GiayCamDoanDYTTDQT> list = new List<GiayCamDoanDYTTDQT>();
            try
            {
                string sql = @"SELECT * FROM GiayCamDoanDYTTDQT where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    GiayCamDoanDYTTDQT data = new GiayCamDoanDYTTDQT();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.MaBenhAn = DataReader["MaBenhAn"].ToString();

                    data.TenToiLa = DataReader["TenToiLa"].ToString();
                    data.DiaChi = DataReader["DiaChi"].ToString();
                    data.NamSinh = DataReader["NamSinh"].ToString();
                    data.HoVaTen = DataReader["HoVaTen"].ToString();
                    data.GioiTinh = DataReader["GioiTinh"].ToString();

                    data.TinhOrHuyen = DataReader["TinhOrHuyen"].ToString();
                    data.NgayVietDon = Convert.ToDateTime(DataReader["NgayVietDon"] == DBNull.Value ? DateTime.Now : DataReader["NgayVietDon"]);

                    data.DaTungTiem = DataReader["DaTungTiem"].ToString();
                    data.DaTungTiem_Text = DataReader["DaTungTiem_Text"].ToString();

                    data.DiUngThuoc = DataReader["DiUngThuoc"].ToString();
                    data.DiUngThuoc_Text = DataReader["DiUngThuoc_Text"].ToString();

                    data.DieuTriDiUng = DataReader["DieuTriDiUng"].ToString();
                    data.DieuTriDiUng_Text = DataReader["DieuTriDiUng_Text"].ToString();

                    data.DiUngKS = DataReader["DiUngKS"].ToString();
                    data.DiUngKS_Text = DataReader["DiUngKS_Text"].ToString();

                    data.DiUngTA = DataReader["DiUngTA"].ToString();
                    data.DiUngTA_Text = DataReader["DiUngTA_Text"].ToString();

                    data.DiUngConTrung = DataReader["DiUngConTrung"].ToString();
                    data.DiUngConTrung_Text = DataReader["DiUngConTrung_Text"].ToString();

                    data.HenPheQuan = DataReader["HenPheQuan"].ToString();
                    data.HenPheQuan_Text = DataReader["HenPheQuan_Text"].ToString();

                    data.TimGanThan = DataReader["TimGanThan"].ToString();
                    data.TimGanThan_Text = DataReader["TimGanThan_Text"].ToString();

                    data.BLManTinh = DataReader["BLManTinh"].ToString();
                    data.BLManTinh_Text = DataReader["BLManTinh_Text"].ToString();

                    data.NuoiCon = DataReader["NuoiCon"].ToString();
                    data.NuoiCon_Text = DataReader["NuoiCon_Text"].ToString();

                    data.CoThai = DataReader["CoThai"].ToString();
                    data.CoThai_Text = DataReader["CoThai_Text"].ToString();


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

        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref GiayCamDoanDYTTDQT bangKiem)
        {
            try
            {
                string sql = @"INSERT INTO GiayCamDoanDYTTDQT
                (
                    MAQUANLY,
                    MaBenhNhan,
                    MaBenhAn,
                    TenToiLa,
                    NamSinh,
                    GioiTinh,
                    DiaChi,
                    HoVaTen,
                    TinhOrHuyen,
                    NgayVietDon,
                    DaTungTiem,
                    DaTungTiem_Text,
                    DiUngThuoc,
                    DiUngThuoc_Text,
                    DieuTriDiUng,
                    DieuTriDiUng_Text,
                    DiUngKS,
                    DiUngKS_Text,
                    DiUngTA,
                    DiUngTA_Text,
                    DiUngConTrung,
                    DiUngConTrung_Text,
                    HenPheQuan,
                    HenPheQuan_Text,
                    TimGanThan,
                    TimGanThan_Text,
                    BLManTinh,
                    BLManTinh_Text,
                    NuoiCon,
                    NuoiCon_Text,
                    CoThai,
                    CoThai_Text,

                    NgayTao,
                    NguoiTao,
                    NguoiSua,
                    NgaySua)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :MaBenhAn,
                    :TenToiLa,
                    :NamSinh,
                    :GioiTinh,
                    :DiaChi,
                    :HoVaTen,
                    :TinhOrHuyen,
                    :NgayVietDon,
                    :DaTungTiem,
                    :DaTungTiem_Text,
                    :DiUngThuoc,
                    :DiUngThuoc_Text,
                    :DieuTriDiUng,
                    :DieuTriDiUng_Text,
                    :DiUngKS,
                    :DiUngKS_Text,
                    :DiUngTA,
                    :DiUngTA_Text,
                    :DiUngConTrung,
                    :DiUngConTrung_Text,
                    :HenPheQuan,
                    :HenPheQuan_Text,
                    :TimGanThan,
                    :TimGanThan_Text,
                    :BLManTinh,
                    :BLManTinh_Text,
                    :NuoiCon,
                    :NuoiCon_Text,
                    :CoThai,
                    :CoThai_Text,

                    :NgayTao,
                    :NguoiTao,
                    :NguoiSua,
                    :NgaySua
                 )  RETURNING ID INTO :ID";
                if (bangKiem.ID != 0)
                {
                    sql = @"UPDATE GiayCamDoanDYTTDQT SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    MaBenhAn = :MaBenhAn,
					TenToiLa = :TenToiLa,
                    NamSinh = :NamSinh,
                    GioiTinh = :GioiTinh,
                    DiaChi = :DiaChi,
                    HoVaTen = :HoVaTen,
                    TinhOrHuyen = :TinhOrHuyen,
                    NgayVietDon = :NgayVietDon,
                    DaTungTiem = :DaTungTiem,
                    DaTungTiem_Text = :DaTungTiem_Text,
                    DiUngThuoc = :DiUngThuoc,
                    DiUngThuoc_Text = :DiUngThuoc_Text,
                    DieuTriDiUng = :DieuTriDiUng,
                    DieuTriDiUng_Text = :DieuTriDiUng_Text,
                    DiUngKS = :DiUngKS,
                    DiUngKS_Text = :DiUngKS_Text,
                    DiUngTA = :DiUngTA,
                    DiUngTA_Text = :DiUngTA_Text,
                    DiUngConTrung = :DiUngConTrung,
                    DiUngConTrung_Text = :DiUngConTrung_Text,
                    HenPheQuan = :HenPheQuan,
                    HenPheQuan_Text = :HenPheQuan_Text,
                    TimGanThan = :TimGanThan,
                    TimGanThan_Text = :TimGanThan_Text,
                    BLManTinh = :BLManTinh,
                    BLManTinh_Text = :BLManTinh_Text,
                    NuoiCon = :NuoiCon,
                    NuoiCon_Text = :NuoiCon_Text,
                    CoThai = :CoThai,
                    CoThai_Text = :CoThai_Text,

                    NguoiSua = :NguoiSua,
                    NgaySua = :NgaySua
                    WHERE ID = " + bangKiem.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangKiem.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", bangKiem.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhAn", bangKiem.MaBenhAn));
                Command.Parameters.Add(new MDB.MDBParameter("TenToiLa", bangKiem.TenToiLa));
                Command.Parameters.Add(new MDB.MDBParameter("NamSinh", bangKiem.NamSinh));
                Command.Parameters.Add(new MDB.MDBParameter("GioiTinh", bangKiem.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", bangKiem.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("HoVaTen", bangKiem.HoVaTen));
                Command.Parameters.Add(new MDB.MDBParameter("TinhOrHuyen", bangKiem.TinhOrHuyen));
                Command.Parameters.Add(new MDB.MDBParameter("NgayVietDon", bangKiem.NgayVietDon));
                Command.Parameters.Add(new MDB.MDBParameter("DaTungTiem", bangKiem.DaTungTiem));
                Command.Parameters.Add(new MDB.MDBParameter("DaTungTiem_Text", bangKiem.DaTungTiem_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiUngThuoc", bangKiem.DiUngThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("DiUngThuoc_Text", bangKiem.DiUngThuoc_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriDiUng", bangKiem.DieuTriDiUng));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriDiUng_Text", bangKiem.DieuTriDiUng_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiUngKS", bangKiem.DiUngKS));
                Command.Parameters.Add(new MDB.MDBParameter("DiUngKS_Text", bangKiem.DiUngKS_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiUngTA", bangKiem.DiUngTA));
                Command.Parameters.Add(new MDB.MDBParameter("DiUngTA_Text", bangKiem.DiUngTA_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiUngConTrung", bangKiem.DiUngConTrung));
                Command.Parameters.Add(new MDB.MDBParameter("DiUngConTrung_Text", bangKiem.DiUngConTrung_Text));
                Command.Parameters.Add(new MDB.MDBParameter("HenPheQuan", bangKiem.HenPheQuan));
                Command.Parameters.Add(new MDB.MDBParameter("HenPheQuan_Text", bangKiem.HenPheQuan_Text));
                Command.Parameters.Add(new MDB.MDBParameter("TimGanThan", bangKiem.TimGanThan));
                Command.Parameters.Add(new MDB.MDBParameter("TimGanThan_Text", bangKiem.TimGanThan_Text));
                Command.Parameters.Add(new MDB.MDBParameter("BLManTinh", bangKiem.BLManTinh));
                Command.Parameters.Add(new MDB.MDBParameter("BLManTinh_Text", bangKiem.BLManTinh_Text));
                Command.Parameters.Add(new MDB.MDBParameter("NuoiCon", bangKiem.NuoiCon));
                Command.Parameters.Add(new MDB.MDBParameter("NuoiCon_Text", bangKiem.NuoiCon_Text));
                Command.Parameters.Add(new MDB.MDBParameter("CoThai", bangKiem.CoThai));
                Command.Parameters.Add(new MDB.MDBParameter("CoThai_Text", bangKiem.CoThai_Text));

                Command.Parameters.Add(new MDB.MDBParameter("NguoiSua", bangKiem.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NgaySua", bangKiem.NgaySua));
                if (bangKiem.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", bangKiem.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NguoiTao", bangKiem.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NgayTao", bangKiem.NgayTao));
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
                string sql = "DELETE FROM GiayCamDoanDYTTDQT WHERE ID = :ID";
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
                GiayCamDoanDYTTDQT B
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);

            var ds = new DataSet();

            adt.Fill(ds, "TB");
            ds.Tables[0].AddColumn("SOYTE", typeof(string));
            ds.Tables[0].AddColumn("BENHVIEN", typeof(string));
            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["SOYTE"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;

            return ds;
        }
    }
}
