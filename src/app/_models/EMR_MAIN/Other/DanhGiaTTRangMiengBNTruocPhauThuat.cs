using EMR.KyDienTu;
using MDB;
using System;
using System.Collections.Generic;
using System.Data;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class DanhGiaTTRangMiengBNTruocPhauThuat : ThongTinKy
    {
        public DanhGiaTTRangMiengBNTruocPhauThuat()
        {
            TableName = "DanhGiaTTRangMiengBNTruocPhauThuat";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.DGTTRMBNTPT;
            TenMauPhieu = DanhMucPhieu.DGTTRMBNTPT.Description();
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
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        public string Phong { get; set; }
        [MoTaDuLieu("Giường")]
		public string Giuong { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public DateTime NgayChuyenMo_1 { get; set; }
        public DateTime NgayChuyenMo_2 { get; set; }
        public DateTime NgayChuyenMo_3 { get; set; }
        public DateTime NgayChuyenMo_4 { get; set; }

        //public DateTime? GioChuyenMo_1 { get; set; }
        //public DateTime? GioChuyenMo_2 { get; set; }
        //public DateTime? GioChuyenMo_3 { get; set; }
        //public DateTime? GioChuyenMo_4 { get; set; }

        public int HoiTho_1 { get; set; }
        public int HoiTho_2 { get; set; }
        public int HoiTho_3 { get; set; }
        public int HoiTho_4 { get; set; }

        public int RangSach_1 { get; set; }
        public int RangSach_2 { get; set; }
        public int RangSach_3 { get; set; }
        public int RangSach_4 { get; set; }

        public int LuoiSach_1 { get; set; }
        public int LuoiSach_2 { get; set; }
        public int LuoiSach_3 { get; set; }
        public int LuoiSach_4 { get; set; }

        public bool[] CacBenhDaDieuTriArray_1 { get; } = new bool[] { false, false, false };
        public string CacBenhDaDieuTri_1
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < CacBenhDaDieuTriArray_1.Length; i++)
                    temp += (CacBenhDaDieuTriArray_1[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        CacBenhDaDieuTriArray_1[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }

        public bool[] CacBenhDaDieuTriArray_2 { get; } = new bool[] { false, false, false };
        public string CacBenhDaDieuTri_2
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < CacBenhDaDieuTriArray_2.Length; i++)
                    temp += (CacBenhDaDieuTriArray_2[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        CacBenhDaDieuTriArray_2[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }

        public bool[] CacBenhDaDieuTriArray_3 { get; } = new bool[] { false, false, false };
        public string CacBenhDaDieuTri_3
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < CacBenhDaDieuTriArray_3.Length; i++)
                    temp += (CacBenhDaDieuTriArray_3[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        CacBenhDaDieuTriArray_3[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }

        public bool[] CacBenhDaDieuTriArray_4 { get; } = new bool[] { false, false, false };
        public string CacBenhDaDieuTri_4
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < CacBenhDaDieuTriArray_4.Length; i++)
                    temp += (CacBenhDaDieuTriArray_4[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        CacBenhDaDieuTriArray_4[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string MaNVDieuDuongKiemTra_1 { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuongKiemTra_1 { get; set; }
        public string MaNVDieuDuongKiemTra_2 { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuongKiemTra_2 { get; set; }
        public string MaNVDieuDuongKiemTra_3 { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuongKiemTra_3 { get; set; }
        public string MaNVDieuDuongKiemTra_4 { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuongKiemTra_4 { get; set; }

        public string MaNVDieuDuongNhanBenh_1 { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuongNhanBenh_1 { get; set; }
        public string MaNVDieuDuongNhanBenh_2 { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuongNhanBenh_2 { get; set; }
        public string MaNVDieuDuongNhanBenh_3 { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuongNhanBenh_3 { get; set; }
        public string MaNVDieuDuongNhanBenh_4 { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuongNhanBenh_4 { get; set; }

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
    public class DanhGiaTTRangMiengBNTruocPhauThuatFunc
    {
        public const string TableName = "DanhGiaTTRangMiengBNTruocPhauThuat";
        public const string TablePrimaryKeyName = "ID";
        public static List<DanhGiaTTRangMiengBNTruocPhauThuat> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<DanhGiaTTRangMiengBNTruocPhauThuat> list = new List<DanhGiaTTRangMiengBNTruocPhauThuat>();
            try
            {

                string sql = @"SELECT * FROM dgttrangmiengbntruocpt where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    try
                    {
                        DanhGiaTTRangMiengBNTruocPhauThuat data = new DanhGiaTTRangMiengBNTruocPhauThuat();
                        data.ID = DataReader.GetLong("ID");
                        data.MaQuanLy = DataReader.GetDecimal("maquanly");
                        data.MaBenhNhan = DataReader.GetString("mabenhnhan");
                        data.TenBenhNhan = DataReader.GetString("tenbenhnhan");
                        data.Tuoi = DataReader.GetString("tuoi");
                        data.GioiTinh = DataReader.GetString("gioitinh");
                        data.Khoa = DataReader.GetString("khoa");
                        data.Phong = DataReader.GetString("phong");
                        data.Giuong = DataReader.GetString("giuong");
                        data.ChanDoan = DataReader.GetString("chandoan");
                        data.NgayChuyenMo_1 = ConDB_DateTime(DataReader["ngaychuyenmo_1"]);
                        data.NgayChuyenMo_2 = ConDB_DateTime(DataReader["ngaychuyenmo_2"]);
                        data.NgayChuyenMo_3 = ConDB_DateTime(DataReader["ngaychuyenmo_3"]);
                        data.NgayChuyenMo_4 = ConDB_DateTime(DataReader["ngaychuyenmo_4"]);
                        data.HoiTho_1 = DataReader.GetInt("hoitho_1");
                        data.HoiTho_2 = DataReader.GetInt("hoitho_2");
                        data.HoiTho_3 = DataReader.GetInt("hoitho_3");
                        data.HoiTho_4 = DataReader.GetInt("hoitho_4");
                        data.RangSach_1 = DataReader.GetInt("rangsach_1");
                        data.RangSach_2 = DataReader.GetInt("rangsach_2");
                        data.RangSach_3 = DataReader.GetInt("rangsach_3");
                        data.RangSach_4 = DataReader.GetInt("rangsach_4");
                        data.LuoiSach_1 = DataReader.GetInt("luoisach_1");
                        data.LuoiSach_2 = DataReader.GetInt("luoisach_2");
                        data.LuoiSach_3 = DataReader.GetInt("luoisach_3");
                        data.LuoiSach_4 = DataReader.GetInt("luoisach_4");
                        data.CacBenhDaDieuTri_1 = DataReader.GetString("cacbenhdadieutri_1");
                        data.CacBenhDaDieuTri_2 = DataReader.GetString("cacbenhdadieutri_2");
                        data.CacBenhDaDieuTri_3 = DataReader.GetString("cacbenhdadieutri_3");
                        data.CacBenhDaDieuTri_4 = DataReader.GetString("cacbenhdadieutri_4");
                        data.MaNVDieuDuongKiemTra_1 = DataReader.GetString("manvdieuduongkiemtra_1");
                        data.DieuDuongKiemTra_1 = DataReader.GetString("dieuduongkiemtra_1");
                        data.MaNVDieuDuongKiemTra_2 = DataReader.GetString("manvdieuduongkiemtra_2");
                        data.DieuDuongKiemTra_2 = DataReader.GetString("dieuduongkiemtra_2");
                        data.MaNVDieuDuongKiemTra_3 = DataReader.GetString("manvdieuduongkiemtra_3");
                        data.DieuDuongKiemTra_3 = DataReader.GetString("dieuduongkiemtra_3");
                        data.MaNVDieuDuongKiemTra_4 = DataReader.GetString("manvdieuduongkiemtra_4");
                        data.DieuDuongKiemTra_4 = DataReader.GetString("dieuduongkiemtra_4");
                        data.MaNVDieuDuongNhanBenh_1 = DataReader.GetString("manvdieuduongnhanbenh_1");
                        data.DieuDuongNhanBenh_1 = DataReader.GetString("dieuduongnhanbenh_1");
                        data.MaNVDieuDuongNhanBenh_2 = DataReader.GetString("manvdieuduongnhanbenh_2");
                        data.DieuDuongNhanBenh_2 = DataReader.GetString("dieuduongnhanbenh_2");
                        data.MaNVDieuDuongNhanBenh_3 = DataReader.GetString("manvdieuduongnhanbenh_3");
                        data.DieuDuongNhanBenh_3 = DataReader.GetString("dieuduongnhanbenh_3");
                        data.MaNVDieuDuongNhanBenh_4 = DataReader.GetString("manvdieuduongnhanbenh_4");
                        data.DieuDuongNhanBenh_4 = DataReader.GetString("dieuduongnhanbenh_4");
                        data.NguoiTao = DataReader.GetString("nguoitao");
                        data.NguoiSua = DataReader.GetString("nguoisua");
                        data.NgayTao = ConDB_DateTime(DataReader["NgayTao"]);
                        data.NgaySua = ConDB_DateTime(DataReader["NgaySua"]);
                        data.MaSoKy = DataReader.GetString("masokyten");
                        data.NgayKy = DataReader.GetDate("ngayky");
                        data.TenFileKy = DataReader.GetString("tenfileky");
                        data.UserNameKy = DataReader.GetString("usernameky");
                        list.Add(data);
                    }
                    catch (Exception ex)
                    {
                        MDB.ExceptionExtend.LogError(ex);
                    }
                }
                DataReader.Close();
                DataReader = null;
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static DateTime ConDB_DateTime(object dbVal)
        {
            DateTime ret = DateTime.MinValue;
            if (dbVal == null)
            {
                return ret;
            }
            DateTime.TryParse(dbVal.ToString(), out ret);
            return ret;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref DanhGiaTTRangMiengBNTruocPhauThuat objData)
        {
            string sql;
            int n = 0;
            
            if (objData.ID == 0)
            {
                sql = @"INSERT INTO dgttrangmiengbntruocpt (
                                    maquanly,
                                    mabenhnhan,
                                    tenbenhnhan,
                                    tuoi,
                                    gioitinh,
                                    khoa,
                                    phong,
                                    giuong,
                                    chandoan,
                                    ngaychuyenmo_1,
                                    ngaychuyenmo_2,
                                    ngaychuyenmo_3,
                                    ngaychuyenmo_4,
                                    hoitho_1,
                                    hoitho_2,
                                    hoitho_3,
                                    hoitho_4,
                                    rangsach_1,
                                    rangsach_2,
                                    rangsach_3,
                                    rangsach_4,
                                    luoisach_1,
                                    luoisach_2,
                                    luoisach_3,
                                    luoisach_4,
                                    cacbenhdadieutri_1,
                                    cacbenhdadieutri_2,
                                    cacbenhdadieutri_3,
                                    cacbenhdadieutri_4,
                                    manvdieuduongkiemtra_1,
                                    dieuduongkiemtra_1,
                                    manvdieuduongkiemtra_2,
                                    dieuduongkiemtra_2,
                                    manvdieuduongkiemtra_3,
                                    dieuduongkiemtra_3,
                                    manvdieuduongkiemtra_4,
                                    dieuduongkiemtra_4,
                                    manvdieuduongnhanbenh_1,
                                    dieuduongnhanbenh_1,
                                    manvdieuduongnhanbenh_2,
                                    dieuduongnhanbenh_2,
                                    manvdieuduongnhanbenh_3,
                                    dieuduongnhanbenh_3,
                                    manvdieuduongnhanbenh_4,
                                    dieuduongnhanbenh_4,
                                    nguoitao,
                                    ngaytao
                                ) VALUES (
                                    :maquanly,
                                    :mabenhnhan,
                                    :tenbenhnhan,
                                    :tuoi,
                                    :gioitinh,
                                    :khoa,
                                    :phong,
                                    :giuong,
                                    :chandoan,
                                    :ngaychuyenmo_1,
                                    :ngaychuyenmo_2,
                                    :ngaychuyenmo_3,
                                    :ngaychuyenmo_4,
                                    :hoitho_1,
                                    :hoitho_2,
                                    :hoitho_3,
                                    :hoitho_4,
                                    :rangsach_1,
                                    :rangsach_2,
                                    :rangsach_3,
                                    :rangsach_4,
                                    :luoisach_1,
                                    :luoisach_2,
                                    :luoisach_3,
                                    :luoisach_4,
                                    :cacbenhdadieutri_1,
                                    :cacbenhdadieutri_2,
                                    :cacbenhdadieutri_3,
                                    :cacbenhdadieutri_4,
                                    :manvdieuduongkiemtra_1,
                                    :dieuduongkiemtra_1,
                                    :manvdieuduongkiemtra_2,
                                    :dieuduongkiemtra_2,
                                    :manvdieuduongkiemtra_3,
                                    :dieuduongkiemtra_3,
                                    :manvdieuduongkiemtra_4,
                                    :dieuduongkiemtra_4,
                                    :manvdieuduongnhanbenh_1,
                                    :dieuduongnhanbenh_1,
                                    :manvdieuduongnhanbenh_2,
                                    :dieuduongnhanbenh_2,
                                    :manvdieuduongnhanbenh_3,
                                    :dieuduongnhanbenh_3,
                                    :manvdieuduongnhanbenh_4,
                                    :dieuduongnhanbenh_4,
                                    :nguoitao,
                                    :ngaytao 
                    ) RETURNING ID INTO :ID";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("maquanly", objData.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("mabenhnhan", objData.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("tenbenhnhan", objData.TenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("tuoi", objData.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("gioitinh", objData.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("khoa", objData.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("phong", objData.Phong));
                Command.Parameters.Add(new MDB.MDBParameter("giuong", objData.Giuong));
                Command.Parameters.Add(new MDB.MDBParameter("chandoan", objData.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("ngaychuyenmo_1", objData.NgayChuyenMo_1));
                Command.Parameters.Add(new MDB.MDBParameter("ngaychuyenmo_2", objData.NgayChuyenMo_2));
                Command.Parameters.Add(new MDB.MDBParameter("ngaychuyenmo_3", objData.NgayChuyenMo_3));
                Command.Parameters.Add(new MDB.MDBParameter("ngaychuyenmo_4", objData.NgayChuyenMo_4));
                Command.Parameters.Add(new MDB.MDBParameter("hoitho_1", objData.HoiTho_1));
                Command.Parameters.Add(new MDB.MDBParameter("hoitho_2", objData.HoiTho_2));
                Command.Parameters.Add(new MDB.MDBParameter("hoitho_3", objData.HoiTho_3));
                Command.Parameters.Add(new MDB.MDBParameter("hoitho_4", objData.HoiTho_4));
                Command.Parameters.Add(new MDB.MDBParameter("rangsach_1", objData.RangSach_1));
                Command.Parameters.Add(new MDB.MDBParameter("rangsach_2", objData.RangSach_2));
                Command.Parameters.Add(new MDB.MDBParameter("rangsach_3", objData.RangSach_3));
                Command.Parameters.Add(new MDB.MDBParameter("rangsach_4", objData.RangSach_4));
                Command.Parameters.Add(new MDB.MDBParameter("luoisach_1", objData.LuoiSach_1));
                Command.Parameters.Add(new MDB.MDBParameter("luoisach_2", objData.LuoiSach_2));
                Command.Parameters.Add(new MDB.MDBParameter("luoisach_3", objData.LuoiSach_3));
                Command.Parameters.Add(new MDB.MDBParameter("luoisach_4", objData.LuoiSach_4));
                Command.Parameters.Add(new MDB.MDBParameter("cacbenhdadieutri_1", objData.CacBenhDaDieuTri_1));
                Command.Parameters.Add(new MDB.MDBParameter("cacbenhdadieutri_2", objData.CacBenhDaDieuTri_2));
                Command.Parameters.Add(new MDB.MDBParameter("cacbenhdadieutri_3", objData.CacBenhDaDieuTri_3));
                Command.Parameters.Add(new MDB.MDBParameter("cacbenhdadieutri_4", objData.CacBenhDaDieuTri_4));
                Command.Parameters.Add(new MDB.MDBParameter("manvdieuduongkiemtra_1", objData.MaNVDieuDuongKiemTra_1));
                Command.Parameters.Add(new MDB.MDBParameter("dieuduongkiemtra_1", objData.DieuDuongKiemTra_1));
                Command.Parameters.Add(new MDB.MDBParameter("manvdieuduongkiemtra_2", objData.MaNVDieuDuongKiemTra_2));
                Command.Parameters.Add(new MDB.MDBParameter("dieuduongkiemtra_2", objData.DieuDuongKiemTra_2));
                Command.Parameters.Add(new MDB.MDBParameter("manvdieuduongkiemtra_3", objData.MaNVDieuDuongKiemTra_3));
                Command.Parameters.Add(new MDB.MDBParameter("dieuduongkiemtra_3", objData.DieuDuongKiemTra_3));
                Command.Parameters.Add(new MDB.MDBParameter("manvdieuduongkiemtra_4", objData.MaNVDieuDuongKiemTra_4));
                Command.Parameters.Add(new MDB.MDBParameter("dieuduongkiemtra_4", objData.DieuDuongKiemTra_4));
                Command.Parameters.Add(new MDB.MDBParameter("manvdieuduongnhanbenh_1", objData.MaNVDieuDuongNhanBenh_1));
                Command.Parameters.Add(new MDB.MDBParameter("dieuduongnhanbenh_1", objData.DieuDuongNhanBenh_1));
                Command.Parameters.Add(new MDB.MDBParameter("manvdieuduongnhanbenh_2", objData.MaNVDieuDuongNhanBenh_2));
                Command.Parameters.Add(new MDB.MDBParameter("dieuduongnhanbenh_2", objData.DieuDuongNhanBenh_2));
                Command.Parameters.Add(new MDB.MDBParameter("manvdieuduongnhanbenh_3", objData.MaNVDieuDuongNhanBenh_3));
                Command.Parameters.Add(new MDB.MDBParameter("dieuduongnhanbenh_3", objData.DieuDuongNhanBenh_3));
                Command.Parameters.Add(new MDB.MDBParameter("manvdieuduongnhanbenh_4", objData.MaNVDieuDuongNhanBenh_4));
                Command.Parameters.Add(new MDB.MDBParameter("dieuduongnhanbenh_4", objData.DieuDuongNhanBenh_4));
                Command.Parameters.Add(new MDB.MDBParameter("ID", objData.ID));
                Command.Parameters.Add(new MDB.MDBParameter("nguoitao", objData.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("ngaytao", objData.NgayTao));
            
                Command.BindByName = true;
                n = Command.ExecuteNonQuery();

                if (n > 0)
                {
                    if (objData.ID == 0)
                    {
                        long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                        objData.ID = nextval;
                    }
                }
            }

            else
            {
                sql = @"UPDATE dgttrangmiengbntruocpt SET 
                                        maquanly=:maquanly,
                                        mabenhnhan=:mabenhnhan,
                                        tenbenhnhan=:tenbenhnhan,
                                        tuoi=:tuoi,
                                        gioitinh=:gioitinh,
                                        khoa=:khoa,
                                        phong=:phong,
                                        giuong=:giuong,
                                        chandoan=:chandoan,
                                        ngaychuyenmo_1=:ngaychuyenmo_1,
                                        ngaychuyenmo_2=:ngaychuyenmo_2,
                                        ngaychuyenmo_3=:ngaychuyenmo_3,
                                        ngaychuyenmo_4=:ngaychuyenmo_4,
                                        hoitho_1=:hoitho_1,
                                        hoitho_2=:hoitho_2,
                                        hoitho_3=:hoitho_3,
                                        hoitho_4=:hoitho_4,
                                        rangsach_1=:rangsach_1,
                                        rangsach_2=:rangsach_2,
                                        rangsach_3=:rangsach_3,
                                        rangsach_4=:rangsach_4,
                                        luoisach_1=:luoisach_1,
                                        luoisach_2=:luoisach_2,
                                        luoisach_3=:luoisach_3,
                                        luoisach_4=:luoisach_4,
                                        cacbenhdadieutri_1=:cacbenhdadieutri_1,
                                        cacbenhdadieutri_2=:cacbenhdadieutri_2,
                                        cacbenhdadieutri_3=:cacbenhdadieutri_3,
                                        cacbenhdadieutri_4=:cacbenhdadieutri_4,
                                        manvdieuduongkiemtra_1=:manvdieuduongkiemtra_1,
                                        dieuduongkiemtra_1=:dieuduongkiemtra_1,
                                        manvdieuduongkiemtra_2=:manvdieuduongkiemtra_2,
                                        dieuduongkiemtra_2=:dieuduongkiemtra_2,
                                        manvdieuduongkiemtra_3=:manvdieuduongkiemtra_3,
                                        dieuduongkiemtra_3=:dieuduongkiemtra_3,
                                        manvdieuduongkiemtra_4=:manvdieuduongkiemtra_4,
                                        dieuduongkiemtra_4=:dieuduongkiemtra_4,
                                        manvdieuduongnhanbenh_1=:manvdieuduongnhanbenh_1,
                                        dieuduongnhanbenh_1=:dieuduongnhanbenh_1,
                                        manvdieuduongnhanbenh_2=:manvdieuduongnhanbenh_2,
                                        dieuduongnhanbenh_2=:dieuduongnhanbenh_2,
                                        manvdieuduongnhanbenh_3=:manvdieuduongnhanbenh_3,
                                        dieuduongnhanbenh_3=:dieuduongnhanbenh_3,
                                        manvdieuduongnhanbenh_4=:manvdieuduongnhanbenh_4,
                                        dieuduongnhanbenh_4=:dieuduongnhanbenh_4,
                                        nguoisua=:nguoisua,
                                        ngaysua=:ngaysua 
                                        WHERE ID = :IDPhieu";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("maquanly", objData.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("mabenhnhan", objData.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("tenbenhnhan", objData.TenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("tuoi", objData.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("gioitinh", objData.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("khoa", objData.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("phong", objData.Phong));
                Command.Parameters.Add(new MDB.MDBParameter("giuong", objData.Giuong));
                Command.Parameters.Add(new MDB.MDBParameter("chandoan", objData.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("ngaychuyenmo_1", objData.NgayChuyenMo_1));
                Command.Parameters.Add(new MDB.MDBParameter("ngaychuyenmo_2", objData.NgayChuyenMo_2));
                Command.Parameters.Add(new MDB.MDBParameter("ngaychuyenmo_3", objData.NgayChuyenMo_3));
                Command.Parameters.Add(new MDB.MDBParameter("ngaychuyenmo_4", objData.NgayChuyenMo_4));
                Command.Parameters.Add(new MDB.MDBParameter("hoitho_1", objData.HoiTho_1));
                Command.Parameters.Add(new MDB.MDBParameter("hoitho_2", objData.HoiTho_2));
                Command.Parameters.Add(new MDB.MDBParameter("hoitho_3", objData.HoiTho_3));
                Command.Parameters.Add(new MDB.MDBParameter("hoitho_4", objData.HoiTho_4));
                Command.Parameters.Add(new MDB.MDBParameter("rangsach_1", objData.RangSach_1));
                Command.Parameters.Add(new MDB.MDBParameter("rangsach_2", objData.RangSach_2));
                Command.Parameters.Add(new MDB.MDBParameter("rangsach_3", objData.RangSach_3));
                Command.Parameters.Add(new MDB.MDBParameter("rangsach_4", objData.RangSach_4));
                Command.Parameters.Add(new MDB.MDBParameter("luoisach_1", objData.LuoiSach_1));
                Command.Parameters.Add(new MDB.MDBParameter("luoisach_2", objData.LuoiSach_2));
                Command.Parameters.Add(new MDB.MDBParameter("luoisach_3", objData.LuoiSach_3));
                Command.Parameters.Add(new MDB.MDBParameter("luoisach_4", objData.LuoiSach_4));
                Command.Parameters.Add(new MDB.MDBParameter("cacbenhdadieutri_1", objData.CacBenhDaDieuTri_1));
                Command.Parameters.Add(new MDB.MDBParameter("cacbenhdadieutri_2", objData.CacBenhDaDieuTri_2));
                Command.Parameters.Add(new MDB.MDBParameter("cacbenhdadieutri_3", objData.CacBenhDaDieuTri_3));
                Command.Parameters.Add(new MDB.MDBParameter("cacbenhdadieutri_4", objData.CacBenhDaDieuTri_4));
                Command.Parameters.Add(new MDB.MDBParameter("manvdieuduongkiemtra_1", objData.MaNVDieuDuongKiemTra_1));
                Command.Parameters.Add(new MDB.MDBParameter("dieuduongkiemtra_1", objData.DieuDuongKiemTra_1));
                Command.Parameters.Add(new MDB.MDBParameter("manvdieuduongkiemtra_2", objData.MaNVDieuDuongKiemTra_2));
                Command.Parameters.Add(new MDB.MDBParameter("dieuduongkiemtra_2", objData.DieuDuongKiemTra_2));
                Command.Parameters.Add(new MDB.MDBParameter("manvdieuduongkiemtra_3", objData.MaNVDieuDuongKiemTra_3));
                Command.Parameters.Add(new MDB.MDBParameter("dieuduongkiemtra_3", objData.DieuDuongKiemTra_3));
                Command.Parameters.Add(new MDB.MDBParameter("manvdieuduongkiemtra_4", objData.MaNVDieuDuongKiemTra_4));
                Command.Parameters.Add(new MDB.MDBParameter("dieuduongkiemtra_4", objData.DieuDuongKiemTra_4));
                Command.Parameters.Add(new MDB.MDBParameter("manvdieuduongnhanbenh_1", objData.MaNVDieuDuongNhanBenh_1));
                Command.Parameters.Add(new MDB.MDBParameter("dieuduongnhanbenh_1", objData.DieuDuongNhanBenh_1));
                Command.Parameters.Add(new MDB.MDBParameter("manvdieuduongnhanbenh_2", objData.MaNVDieuDuongNhanBenh_2));
                Command.Parameters.Add(new MDB.MDBParameter("dieuduongnhanbenh_2", objData.DieuDuongNhanBenh_2));
                Command.Parameters.Add(new MDB.MDBParameter("manvdieuduongnhanbenh_3", objData.MaNVDieuDuongNhanBenh_3));
                Command.Parameters.Add(new MDB.MDBParameter("dieuduongnhanbenh_3", objData.DieuDuongNhanBenh_3));
                Command.Parameters.Add(new MDB.MDBParameter("manvdieuduongnhanbenh_4", objData.MaNVDieuDuongNhanBenh_4));
                Command.Parameters.Add(new MDB.MDBParameter("dieuduongnhanbenh_4", objData.DieuDuongNhanBenh_4));
                Command.Parameters.Add(new MDB.MDBParameter("nguoisua", objData.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("ngaysua", objData.NgaySua));
                Command.Parameters.Add(new MDB.MDBParameter("IDPhieu", objData.ID));
                Command.BindByName = true;
                n = Command.ExecuteNonQuery();

            }


            return n > 0 ? true : false;
        }

        public static bool Delete(MDB.MDBConnection MyConnection, decimal idPhieu)
        {
            string sql = "DELETE FROM dgttrangmiengbntruocpt WHERE ID = :idPhieu";
            MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
            command.Parameters.Add(new MDB.MDBParameter("idPhieu", idPhieu));
            command.BindByName = true;
            int n = command.ExecuteNonQuery();
            return n > 0 ? true : false;
        }
        public static DanhGiaTTRangMiengBNTruocPhauThuat GetData(MDB.MDBConnection _OracleConnection, decimal id)
        {
            try
            {
                string sql = @"SELECT * FROM dgttrangmiengbntruocpt where ID = :ID";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID", id));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    try
                    {
                        DanhGiaTTRangMiengBNTruocPhauThuat data = new DanhGiaTTRangMiengBNTruocPhauThuat();
                        data.ID = DataReader.GetLong("ID");
                        data.MaQuanLy = DataReader.GetDecimal("maquanly");
                        data.MaBenhNhan = DataReader.GetString("mabenhnhan");
                        data.TenBenhNhan = DataReader.GetString("tenbenhnhan");
                        data.Tuoi = DataReader.GetString("tuoi");
                        data.GioiTinh = DataReader.GetString("gioitinh");
                        data.Khoa = DataReader.GetString("khoa");
                        data.Phong = DataReader.GetString("phong");
                        data.Giuong = DataReader.GetString("giuong");
                        data.ChanDoan = DataReader.GetString("chandoan");
                        data.NgayChuyenMo_1 = ConDB_DateTime(DataReader["ngaychuyenmo_1"]);
                        data.NgayChuyenMo_2 = ConDB_DateTime(DataReader["ngaychuyenmo_2"]);
                        data.NgayChuyenMo_3 = ConDB_DateTime(DataReader["ngaychuyenmo_3"]);
                        data.NgayChuyenMo_4 = ConDB_DateTime(DataReader["ngaychuyenmo_4"]);
                        data.HoiTho_1 = DataReader.GetInt("hoitho_1");
                        data.HoiTho_2 = DataReader.GetInt("hoitho_2");
                        data.HoiTho_3 = DataReader.GetInt("hoitho_3");
                        data.HoiTho_4 = DataReader.GetInt("hoitho_4");
                        data.RangSach_1 = DataReader.GetInt("rangsach_1");
                        data.RangSach_2 = DataReader.GetInt("rangsach_2");
                        data.RangSach_3 = DataReader.GetInt("rangsach_3");
                        data.RangSach_4 = DataReader.GetInt("rangsach_4");
                        data.LuoiSach_1 = DataReader.GetInt("luoisach_1");
                        data.LuoiSach_2 = DataReader.GetInt("luoisach_2");
                        data.LuoiSach_3 = DataReader.GetInt("luoisach_3");
                        data.LuoiSach_4 = DataReader.GetInt("luoisach_4");
                        data.CacBenhDaDieuTri_1 = DataReader.GetString("cacbenhdadieutri_1");
                        data.CacBenhDaDieuTri_2 = DataReader.GetString("cacbenhdadieutri_2");
                        data.CacBenhDaDieuTri_3 = DataReader.GetString("cacbenhdadieutri_3");
                        data.CacBenhDaDieuTri_4 = DataReader.GetString("cacbenhdadieutri_4");
                        data.MaNVDieuDuongKiemTra_1 = DataReader.GetString("manvdieuduongkiemtra_1");
                        data.DieuDuongKiemTra_1 = DataReader.GetString("dieuduongkiemtra_1");
                        data.MaNVDieuDuongKiemTra_2 = DataReader.GetString("manvdieuduongkiemtra_2");
                        data.DieuDuongKiemTra_2 = DataReader.GetString("dieuduongkiemtra_2");
                        data.MaNVDieuDuongKiemTra_3 = DataReader.GetString("manvdieuduongkiemtra_3");
                        data.DieuDuongKiemTra_3 = DataReader.GetString("dieuduongkiemtra_3");
                        data.MaNVDieuDuongKiemTra_4 = DataReader.GetString("manvdieuduongkiemtra_4");
                        data.DieuDuongKiemTra_4 = DataReader.GetString("dieuduongkiemtra_4");
                        data.MaNVDieuDuongNhanBenh_1 = DataReader.GetString("manvdieuduongnhanbenh_1");
                        data.DieuDuongNhanBenh_1 = DataReader.GetString("dieuduongnhanbenh_1");
                        data.MaNVDieuDuongNhanBenh_2 = DataReader.GetString("manvdieuduongnhanbenh_2");
                        data.DieuDuongNhanBenh_2 = DataReader.GetString("dieuduongnhanbenh_2");
                        data.MaNVDieuDuongNhanBenh_3 = DataReader.GetString("manvdieuduongnhanbenh_3");
                        data.DieuDuongNhanBenh_3 = DataReader.GetString("dieuduongnhanbenh_3");
                        data.MaNVDieuDuongNhanBenh_4 = DataReader.GetString("manvdieuduongnhanbenh_4");
                        data.DieuDuongNhanBenh_4 = DataReader.GetString("dieuduongnhanbenh_4");
                        data.NguoiTao = DataReader.GetString("nguoitao");
                        data.NguoiSua = DataReader.GetString("nguoisua");
                        data.NgayTao = ConDB_DateTime(DataReader["NgayTao"]);
                        data.NgaySua = ConDB_DateTime(DataReader["NgaySua"]);
                        data.MaSoKy = DataReader.GetString("masokyten");
                        data.NgayKy = DataReader.GetDate("ngayky");
                        data.TenFileKy = DataReader.GetString("tenfileky");
                        data.UserNameKy = DataReader.GetString("usernameky");

                        return data;
                    }
                    catch (Exception ex)
                    {
                        MDB.ExceptionExtend.LogError(ex);
                    }
                }
                DataReader.Close();
                DataReader = null;
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return null;
        }
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, decimal idPhieu)
        {
            string sql2 = @"SELECT
                D.*,
	            T.MABENHNHAN,
	            T.KHOA,
	            T.GIUONG,
                T.BUONG,
	            T.NGAYVAOVIEN,
	            H.SOYTE,
	            H.BENHVIEN,
	            H.MABENHNHAN,
	            H.TENBENHNHAN,
	            H.TUOI,
	            H.GIOITINH
            FROM
                dgttrangmiengbntruocpt D
                LEFT JOIN THONGTINDIEUTRI T ON D.MAQUANLY = T.MAQUANLY
                LEFT JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
            WHERE
                ID = :ID";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql2, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("ID", idPhieu));

            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            adt.Fill(ds,"BK");
            return ds;
        }
        public static DateTime ConvertDayChuyenMo(DateTime ngaychuyenmo, DateTime? giochuyenmo) {
            try
            {
                var Ngay = ngaychuyenmo.Date.Add(new TimeSpan(0, 0, 0));
                var Gio = giochuyenmo != null ? giochuyenmo.Value.TimeOfDay : DateTime.Now.TimeOfDay;
                var ngaychuyenmofull = Ngay + Gio;
                return ngaychuyenmofull;
            }
            catch (Exception ex) {
                XuLyLoi.Handle(ex);
            }
            return DateTime.Now;
            
        }
    }
}
