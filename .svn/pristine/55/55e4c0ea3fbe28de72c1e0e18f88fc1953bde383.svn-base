
using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class ThangTriTueNguoiLonWechsler : ThongTinKy
    {
        public ThangTriTueNguoiLonWechsler()
        {
            TableName = "TriTueNguoiLonWechsler";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.TTTNLW;
            TenMauPhieu = DanhMucPhieu.TTTNLW.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Mã bệnh án")]
		public string MaBenhAn { get; set; }
        [MoTaDuLieu("Sở Y Tế")]
		public string SoYTe { get; set; }
        [MoTaDuLieu("Bệnh viện")]
		public string BenhVien { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Nghề nghiệp")]
		public string NgheNghiep { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        [MoTaDuLieu("Mã người thực hiện")]
		public string MaNguoiThucHien { get; set; }
        [MoTaDuLieu("Người thực hiện")]
		public string NguoiThucHien { get; set; }
        public DateTime? NgayThucHien { get; set; }
        public double? ThongTin { get; set; }
        public double? HieuBiet { get; set; }
        public double? Toan { get; set; }
        public double? TuongTu { get; set; }
        public double? DaySoXuoi { get; set; }
        public double? VonTu { get; set; }
        public double? KyHieu { get; set; }
        public double? NetThieu { get; set; }
        public double? XepKhoi { get; set; }
        public double? GhepTranh { get; set; }
        public double? ChapHinh { get; set; }
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
    public class ThangTriTueNguoiLonWechslerFunc
    {
        public const string TableName = "TriTueNguoiLonWechsler";
        public const string TablePrimaryKeyName = "ID";

        public static List<ThangTriTueNguoiLonWechsler> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<ThangTriTueNguoiLonWechsler> list = new List<ThangTriTueNguoiLonWechsler>();
            try
            {
                string sql = @"SELECT * FROM TriTueNguoiLonWechsler where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    ThangTriTueNguoiLonWechsler data = new ThangTriTueNguoiLonWechsler();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;

                    data.MaBenhNhan = XemBenhAn._HanhChinhBenhNhan.MaBenhNhan;
                    data.MaBenhAn = XemBenhAn._ThongTinDieuTri.MaBenhAn;
                    data.TenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.MaNguoiThucHien = DataReader["MaNguoiThucHien"].ToString();
                    data.NguoiThucHien = DataReader["NguoiThucHien"].ToString();
                    data.NgheNghiep = DataReader["NgheNghiep"].ToString();
                    data.DiaChi = DataReader["DiaChi"].ToString();
                    data.NgayThucHien = Convert.ToDateTime(DataReader["NgayThucHien"] == DBNull.Value ? DateTime.Now : DataReader["NgayThucHien"]);

                    double tempDouble = 0;
                    data.ThongTin = double.TryParse(DataReader["ThongTin"].ToString(), out tempDouble) ? (double?)tempDouble : null;
                    tempDouble = 0;
                    data.HieuBiet = double.TryParse(DataReader["HieuBiet"].ToString(), out tempDouble) ? (double?)tempDouble : null;
                    tempDouble = 0;
                    data.Toan = double.TryParse(DataReader["Toan"].ToString(), out tempDouble) ? (double?)tempDouble : null;
                    tempDouble = 0;
                    data.TuongTu = double.TryParse(DataReader["TuongTu"].ToString(), out tempDouble) ? (double?)tempDouble : null;
                    tempDouble = 0;
                    data.DaySoXuoi = double.TryParse(DataReader["DaySoXuoi"].ToString(), out tempDouble) ? (double?)tempDouble : null;
                    tempDouble = 0;
                    data.VonTu = double.TryParse(DataReader["VonTu"].ToString(), out tempDouble) ? (double?)tempDouble : null;
                    tempDouble = 0;
                    data.KyHieu = double.TryParse(DataReader["KyHieu"].ToString(), out tempDouble) ? (double?)tempDouble : null;
                    tempDouble = 0;
                    data.NetThieu = double.TryParse(DataReader["NetThieu"].ToString(), out tempDouble) ? (double?)tempDouble : null;
                    tempDouble = 0;
                    data.XepKhoi = double.TryParse(DataReader["XepKhoi"].ToString(), out tempDouble) ? (double?)tempDouble : null;
                    tempDouble = 0;
                    data.GhepTranh = double.TryParse(DataReader["GhepTranh"].ToString(), out tempDouble) ? (double?)tempDouble : null;
                    tempDouble = 0;
                    data.ChapHinh = double.TryParse(DataReader["ChapHinh"].ToString(), out tempDouble) ? (double?)tempDouble : null;

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
        public static bool DeleteByIDPhieu(MDB.MDBConnection oracleConnection, decimal IDBienBan)
        {
            try
            {
                MDB.MDBCommand oracleCommand;
                string sql = @"DELETE FROM TriTueNguoiLonWechsler WHERE ID =" + IDBienBan;
                using (oracleCommand = new MDB.MDBCommand(sql, oracleConnection))
                {
                    oracleCommand.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                XuLyLoi.LogError(ex);
            }
            return false;
        }
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, long IDBienBan)
        {
            string sql = @"SELECT
                P.* 
            FROM
                TriTueNguoiLonWechsler P
            WHERE
                ID = " + IDBienBan;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "TB");
            double ThongTin = ds.Tables[0].Rows[0]["ThongTin"].ToInt32();
            double HieuBiet = ds.Tables[0].Rows[0]["HieuBiet"].ToInt32();
            double Toan = ds.Tables[0].Rows[0]["Toan"].ToInt32();
            double TuongTu = ds.Tables[0].Rows[0]["TuongTu"].ToInt32();
            double DaySoXuoi = ds.Tables[0].Rows[0]["DaySoXuoi"].ToInt32();
            double VonTu = ds.Tables[0].Rows[0]["VonTu"].ToInt32();
            double KyHieu = ds.Tables[0].Rows[0]["KyHieu"].ToInt32();
            double NetThieu = ds.Tables[0].Rows[0]["NetThieu"].ToInt32();
            double XepKhoi = ds.Tables[0].Rows[0]["XepKhoi"].ToInt32();
            double GhepTranh = ds.Tables[0].Rows[0]["GhepTranh"].ToInt32();
            double ChapHinh = ds.Tables[0].Rows[0]["ChapHinh"].ToInt32();

            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(string));
            ds.Tables[0].AddColumn("SoYTe", typeof(string));
            ds.Tables[0].AddColumn("BenhVien", typeof(string));
            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            ds.Tables[0].Rows[0]["SoYTe"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BenhVien"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;

            double ThongTinDT = GetDiemChuanThongTin(ThongTin);
            double HieuBietDT = GetDiemChuanHieuBiet(HieuBiet);
            double ToanDT = GetDiemChuanToan(Toan);
            double TuongTuDT = GetDiemChuanTuongTu(TuongTu);
            double DaySoXuoiDT = GetDiemChuanDaySo(DaySoXuoi);
            double VonTuDT = GetDiemChuanVonTu(VonTu);
            double KyHieuDT = GetDiemChuanKyHieu(KyHieu);
            double NetThieuDT = GetDiemChuanNetThieu(NetThieu);
            double XepKhoiDT = GetDiemChuanXepKhoi(XepKhoi);
            double GhepTranhDT = GetDiemChuanGhepTranh(GhepTranh);
            double ChapHinhDT = GetDiemChuanChapHinh(ChapHinh);

            double TongDiemLoi = ThongTin + HieuBiet + Toan + TuongTu + DaySoXuoi + VonTu;
            double TongDiemViec = KyHieu + NetThieu + XepKhoi + GhepTranh + ChapHinh;
            double TongDiemLoiDT = ThongTinDT + HieuBietDT + ToanDT + TuongTuDT + DaySoXuoiDT + VonTuDT;
            double TongDiemViecDT = KyHieuDT + NetThieuDT + XepKhoiDT + GhepTranhDT + ChapHinhDT;
            double TongDiem = TongDiemLoiDT + TongDiemViecDT;

            ds.Tables[0].AddColumn("ThongTinDT", typeof(double));
            ds.Tables[0].Rows[0]["ThongTinDT"] = ThongTinDT;
            ds.Tables[0].AddColumn("HieuBietDT", typeof(double));
            ds.Tables[0].Rows[0]["HieuBietDT"] = HieuBietDT;
            ds.Tables[0].AddColumn("ToanDT", typeof(double));
            ds.Tables[0].Rows[0]["ToanDT"] = ToanDT;
            ds.Tables[0].AddColumn("TuongTuDT", typeof(double));
            ds.Tables[0].Rows[0]["TuongTuDT"] = TuongTuDT;
            ds.Tables[0].AddColumn("DaySoXuoiDT", typeof(double));
            ds.Tables[0].Rows[0]["DaySoXuoiDT"] = DaySoXuoiDT;
            ds.Tables[0].AddColumn("VonTuDT", typeof(double));
            ds.Tables[0].Rows[0]["VonTuDT"] = VonTuDT;
            ds.Tables[0].AddColumn("KyHieuDT", typeof(double));
            ds.Tables[0].Rows[0]["KyHieuDT"] = KyHieuDT;
            ds.Tables[0].AddColumn("NetThieuDT", typeof(double));
            ds.Tables[0].Rows[0]["NetThieuDT"] = NetThieuDT;
            ds.Tables[0].AddColumn("XepKhoiDT", typeof(double));
            ds.Tables[0].Rows[0]["XepKhoiDT"] = XepKhoiDT;
            ds.Tables[0].AddColumn("GhepTranhDT", typeof(double));
            ds.Tables[0].Rows[0]["GhepTranhDT"] = GhepTranhDT;
            ds.Tables[0].AddColumn("ChapHinhDT", typeof(double));
            ds.Tables[0].Rows[0]["ChapHinhDT"] = ChapHinhDT;

            ds.Tables[0].AddColumn("TongDiemLoi", typeof(double));
            ds.Tables[0].Rows[0]["TongDiemLoi"] = TongDiemLoi;

            ds.Tables[0].AddColumn("TongDiemViec", typeof(double));
            ds.Tables[0].Rows[0]["TongDiemViec"] = TongDiemViec;

            ds.Tables[0].AddColumn("TongDiemLoiDT", typeof(double));
            ds.Tables[0].Rows[0]["TongDiemLoiDT"] = TongDiemLoiDT;

            ds.Tables[0].AddColumn("TongDiemViecDT", typeof(double));
            ds.Tables[0].Rows[0]["TongDiemViecDT"] = TongDiemViecDT;

            ds.Tables[0].AddColumn("TongDiem", typeof(double));
            ds.Tables[0].Rows[0]["TongDiem"] = TongDiem;

            return ds;
        }

        public static double GetDiemChuanThongTin(double DiemTT)
        {
            Dictionary<double, double> ThongTin = new Dictionary<double, double>();
            ThongTin.Add(0, 0);
            ThongTin.Add(1, 1);
            ThongTin.Add(2, 2);
            ThongTin.Add(3, 3);
            ThongTin.Add(4, 4);
            ThongTin.Add(5, 5);
            ThongTin.Add(6, 5);
            ThongTin.Add(7, 6);
            ThongTin.Add(8, 6);
            ThongTin.Add(9, 7);
            ThongTin.Add(10, 7);
            ThongTin.Add(11, 8);
            ThongTin.Add(12, 8);
            ThongTin.Add(13, 9);
            ThongTin.Add(14, 9);
            ThongTin.Add(15, 10);
            ThongTin.Add(16, 10);
            ThongTin.Add(17, 11);
            ThongTin.Add(18, 11);
            ThongTin.Add(19, 12);
            ThongTin.Add(20, 12);
            ThongTin.Add(21, 13);
            ThongTin.Add(22, 13);
            ThongTin.Add(23, 14);
            ThongTin.Add(24, 14);
            ThongTin.Add(25, 15);
            ThongTin.Add(26, 16);
            ThongTin.Add(27, 17);
            ThongTin.Add(28, 18);
            ThongTin.Add(29, 19);
            return ThongTin[DiemTT];

        }

        public static double GetDiemChuanHieuBiet(double DiemHieuBiet)
        {
            Dictionary<double, double> HieuBiet = new Dictionary<double, double>();
            HieuBiet.Add(0, 0);
            HieuBiet.Add(1, 0);
            HieuBiet.Add(2, 0);
            HieuBiet.Add(3, 1);
            HieuBiet.Add(4, 2);
            HieuBiet.Add(5, 3);
            HieuBiet.Add(6, 4);
            HieuBiet.Add(7, 4);
            HieuBiet.Add(8, 5);
            HieuBiet.Add(9, 5);
            HieuBiet.Add(10, 6);
            HieuBiet.Add(11, 6);
            HieuBiet.Add(12, 7);
            HieuBiet.Add(13, 7);
            HieuBiet.Add(14, 8);
            HieuBiet.Add(15, 9);
            HieuBiet.Add(16, 9);
            HieuBiet.Add(17, 10);
            HieuBiet.Add(18, 10);
            HieuBiet.Add(19, 11);
            HieuBiet.Add(20, 12);
            HieuBiet.Add(21, 13);
            HieuBiet.Add(22, 14);
            HieuBiet.Add(23, 15);
            HieuBiet.Add(24, 16);
            HieuBiet.Add(25, 17);
            HieuBiet.Add(26, 18);
            HieuBiet.Add(27, 19);
            HieuBiet.Add(28, 19);
            return HieuBiet[DiemHieuBiet];
        }

        public static double GetDiemChuanToan(double DiemToan)
        {
            Dictionary<double, double> Dict = new Dictionary<double, double>();
            Dict.Add(0, 0);
            Dict.Add(1, 1);
            Dict.Add(2, 2);
            Dict.Add(3, 3);
            Dict.Add(4, 4);
            Dict.Add(5, 5);
            Dict.Add(6, 6);
            Dict.Add(7, 7);
            Dict.Add(8, 7);
            Dict.Add(9, 8);
            Dict.Add(10, 9);
            Dict.Add(11, 10);
            Dict.Add(12, 11);
            Dict.Add(13, 12);
            Dict.Add(14, 13);
            Dict.Add(15, 14);
            Dict.Add(16, 15);
            Dict.Add(17, 16);
            Dict.Add(18, 17);
            
            return Dict[DiemToan];
        }
        public static double GetDiemChuanTuongTu(double Diem)
        {
            Dictionary<double, double> Dict = new Dictionary<double, double>();
            Dict.Add(0, 0);
            Dict.Add(1, 2);
            Dict.Add(2, 3);
            Dict.Add(3, 4);
            Dict.Add(4, 5);
            Dict.Add(5, 6);
            Dict.Add(6, 6);
            Dict.Add(7, 7);
            Dict.Add(8, 7);
            Dict.Add(9, 8);
            Dict.Add(10, 8);
            Dict.Add(11, 9);
            Dict.Add(12, 9);
            Dict.Add(13, 10);
            Dict.Add(14, 10);
            Dict.Add(15, 11);
            Dict.Add(16, 11);
            Dict.Add(17, 12);
            Dict.Add(18, 12);
            Dict.Add(19, 13);
            Dict.Add(20, 13);
            Dict.Add(21, 14);
            Dict.Add(22, 15);
            Dict.Add(23, 16);
            Dict.Add(24, 17);
            Dict.Add(25, 18);
            Dict.Add(26, 19);

            return Dict[Diem];
        }
        public static double GetDiemChuanDaySo(double Diem)
        {
            Dictionary<double, double> Dict = new Dictionary<double, double>();
            Dict.Add(0, 0);
            Dict.Add(1, 0);
            Dict.Add(2, 0);
            Dict.Add(3, 0);
            Dict.Add(4, 1);
            Dict.Add(5, 1);
            Dict.Add(6, 2);
            Dict.Add(7, 4);
            Dict.Add(8, 6);
            Dict.Add(9, 7);
            Dict.Add(10, 9);
            Dict.Add(11, 10);
            Dict.Add(12, 11);
            Dict.Add(13, 12);
            Dict.Add(14, 14);
            Dict.Add(15, 15);
            Dict.Add(16, 16);
            Dict.Add(17, 19);

            return Dict[Diem];
        }
        public static double GetDiemChuanVonTu(double Diem)
        {
            Dictionary<double, double> Dict = new Dictionary<double, double>();
            Dict.Add(0, 0);
            Dict.Add(1, 0);
            Dict.Add(2, 0);
            Dict.Add(3, 0);
            Dict.Add(4, 0);
            Dict.Add(5, 0);
            Dict.Add(6, 0);
            Dict.Add(7, 0);
            Dict.Add(8, 1);
            Dict.Add(9, 2);
            Dict.Add(10, 3);
            Dict.Add(11, 4);
            Dict.Add(12, 4);
            Dict.Add(13, 4);
            Dict.Add(14, 5);
            Dict.Add(15, 5);
            Dict.Add(16, 5);
            Dict.Add(17, 5);
            Dict.Add(18, 5);
            Dict.Add(19, 6);
            Dict.Add(20, 6);
            Dict.Add(21, 6);
            Dict.Add(22, 7);
            Dict.Add(23, 7);
            Dict.Add(24, 7);
            Dict.Add(25, 7);
            Dict.Add(26, 8);
            Dict.Add(27, 8);
            Dict.Add(28, 8);
            Dict.Add(29, 8);
            Dict.Add(30, 8);
            Dict.Add(31, 8);
            Dict.Add(32, 9);
            Dict.Add(33, 9);
            Dict.Add(34, 9);
            Dict.Add(35, 9);
            Dict.Add(36, 9);
            Dict.Add(37, 9);
            Dict.Add(38, 9);
            Dict.Add(39, 9);
            Dict.Add(40, 10);
            Dict.Add(41, 10);
            Dict.Add(42, 10);
            Dict.Add(43, 10);
            Dict.Add(44, 10);
            Dict.Add(45, 10);
            Dict.Add(46, 10);
            Dict.Add(47, 11);
            Dict.Add(48, 11);
            Dict.Add(49, 11);
            Dict.Add(50, 11);
            Dict.Add(51, 11);
            Dict.Add(52, 11);
            Dict.Add(53, 11);
            Dict.Add(54, 12);
            Dict.Add(55, 12);
            Dict.Add(56, 12);
            Dict.Add(57, 12);
            Dict.Add(58, 12);
            Dict.Add(59, 13);
            Dict.Add(60, 13);
            Dict.Add(61, 13);
            Dict.Add(62, 13);
            Dict.Add(63, 14);
            Dict.Add(64, 14);
            Dict.Add(65, 14);
            Dict.Add(66, 14);
            Dict.Add(67, 15);
            Dict.Add(68, 15);
            Dict.Add(69, 15);
            Dict.Add(70, 15);
            Dict.Add(71, 16);
            Dict.Add(72, 16);
            Dict.Add(73, 16);
            Dict.Add(74, 17);
            Dict.Add(75, 17);
            Dict.Add(76, 18);
            Dict.Add(77, 18);
            Dict.Add(78, 19);
            Dict.Add(79, 19);
            Dict.Add(80, 19);

            return Dict[Diem];
        }

        public static double GetDiemChuanKyHieu(double Diem)
        {
            Dictionary<double, double> Dict = new Dictionary<double, double>();
            Dict.Add(0, 0);
            Dict.Add(1, 0);
            Dict.Add(2, 0);
            Dict.Add(3, 0);
            Dict.Add(4, 0);
            Dict.Add(5, 0);
            Dict.Add(6, 0);
            Dict.Add(7, 0);
            Dict.Add(8, 0);
            Dict.Add(9, 0);
            Dict.Add(10, 0);
            Dict.Add(11, 0);
            Dict.Add(12, 1);
            Dict.Add(13, 2);
            Dict.Add(14, 2);
            Dict.Add(15, 3);
            Dict.Add(16, 3);
            Dict.Add(17, 3);
            Dict.Add(18, 4);
            Dict.Add(19, 4);
            Dict.Add(20, 4);
            Dict.Add(21, 4);
            Dict.Add(22, 4);
            Dict.Add(23, 5);
            Dict.Add(24, 5);
            Dict.Add(25, 5);
            Dict.Add(26, 5);
            Dict.Add(27, 5);
            Dict.Add(28, 5);
            Dict.Add(29, 6);
            Dict.Add(30, 6);
            Dict.Add(31, 6);
            Dict.Add(32, 6);
            Dict.Add(33, 6);
            Dict.Add(34, 6);
            Dict.Add(35, 7);
            Dict.Add(36, 7);
            Dict.Add(37, 7);
            Dict.Add(38, 7);
            Dict.Add(39, 7);
            Dict.Add(40, 7);
            Dict.Add(41, 8);
            Dict.Add(42, 8);
            Dict.Add(43, 8);
            Dict.Add(44, 8);
            Dict.Add(45, 8);
            Dict.Add(46, 8);
            Dict.Add(47, 9);
            Dict.Add(48, 9);
            Dict.Add(49, 9);
            Dict.Add(50, 9);
            Dict.Add(51, 9);
            Dict.Add(52, 10);
            Dict.Add(53, 10);
            Dict.Add(54, 10);
            Dict.Add(55, 10);
            Dict.Add(56, 10);
            Dict.Add(57, 10);
            Dict.Add(58, 11);
            Dict.Add(59, 11);
            Dict.Add(60, 11);
            Dict.Add(61, 11);
            Dict.Add(62, 12);
            Dict.Add(63, 12);
            Dict.Add(64, 12);
            Dict.Add(65, 12);
            Dict.Add(66, 13);
            Dict.Add(67, 13);
            Dict.Add(68, 13);
            Dict.Add(69, 14);
            Dict.Add(70, 14);
            Dict.Add(71, 14);
            Dict.Add(72, 15);
            Dict.Add(73, 15);
            Dict.Add(74, 15);
            Dict.Add(75, 15);
            Dict.Add(76, 16);
            Dict.Add(77, 16);
            Dict.Add(78, 16);
            Dict.Add(79, 17);
            Dict.Add(80, 17);
            Dict.Add(81, 17);
            Dict.Add(82, 17);
            Dict.Add(83, 18);
            Dict.Add(84, 18);
            Dict.Add(85, 18);
            Dict.Add(86, 18);
            Dict.Add(87, 19);
            Dict.Add(88, 19);
            Dict.Add(89, 19);
            Dict.Add(90, 19);
        
            return Dict[Diem];
        }
        public static double GetDiemChuanNetThieu(double Diem)
        {
            Dictionary<double, double> Dict = new Dictionary<double, double>();
            Dict.Add(0, 0);
            Dict.Add(1, 1);
            Dict.Add(2, 2);
            Dict.Add(3, 3);
            Dict.Add(4, 4);
            Dict.Add(5, 5);
            Dict.Add(6, 6);
            Dict.Add(7, 6);
            Dict.Add(8, 7);
            Dict.Add(9, 7);
            Dict.Add(10, 8);
            Dict.Add(11, 8);
            Dict.Add(12, 9);
            Dict.Add(13, 9);
            Dict.Add(14, 10);
            Dict.Add(15, 11);
            Dict.Add(16, 11);
            Dict.Add(17, 12);
            Dict.Add(18, 13);
            Dict.Add(19, 14);
            Dict.Add(20, 16);
            Dict.Add(21, 18);

            return Dict[Diem];
        }

        public static double GetDiemChuanXepKhoi(double Diem)
        {
            Dictionary<double, double> Dict = new Dictionary<double, double>();
            Dict.Add(0, 0);
            Dict.Add(1, 0);
            Dict.Add(2, 1);
            Dict.Add(3, 2);
            Dict.Add(4, 2);
            Dict.Add(5, 2);
            Dict.Add(6, 3);
            Dict.Add(7, 3);
            Dict.Add(8, 3);
            Dict.Add(9, 3);
            Dict.Add(10, 4);
            Dict.Add(11, 4);
            Dict.Add(12, 4);
            Dict.Add(13, 5);
            Dict.Add(14, 5);
            Dict.Add(15, 5);
            Dict.Add(16, 5);
            Dict.Add(17, 6);
            Dict.Add(18, 6);
            Dict.Add(19, 6);
            Dict.Add(20, 6);
            Dict.Add(21, 7);
            Dict.Add(22, 7);
            Dict.Add(23, 7);
            Dict.Add(24, 7);
            Dict.Add(25, 8);
            Dict.Add(26, 8);
            Dict.Add(27, 8);
            Dict.Add(28, 9);
            Dict.Add(29, 9);
            Dict.Add(30, 9);
            Dict.Add(31, 10);
            Dict.Add(32, 10);
            Dict.Add(33, 10);
            Dict.Add(34, 10);
            Dict.Add(35, 11);
            Dict.Add(36, 11);
            Dict.Add(37, 11);
            Dict.Add(38, 11);
            Dict.Add(39, 12);
            Dict.Add(40, 12);
            Dict.Add(41, 12);
            Dict.Add(42, 13);
            Dict.Add(43, 13);
            Dict.Add(44, 14);
            Dict.Add(45, 14);
            Dict.Add(46, 15);
            Dict.Add(47, 16);
            Dict.Add(48, 17);

            return Dict[Diem];
        }
        public static double GetDiemChuanGhepTranh(double Diem)
        {
            Dictionary<double, double> Dict = new Dictionary<double, double>();
            Dict.Add(0, 0);
            Dict.Add(1, 0);
            Dict.Add(2, 0);
            Dict.Add(3, 0);
            Dict.Add(4, 0);
            Dict.Add(5, 1);
            Dict.Add(6, 2);
            Dict.Add(7, 3);
            Dict.Add(8, 4);
            Dict.Add(9, 5);
            Dict.Add(10, 5);
            Dict.Add(11, 5);
            Dict.Add(12, 6);
            Dict.Add(13, 6);
            Dict.Add(14, 6);
            Dict.Add(15, 7);
            Dict.Add(16, 7);
            Dict.Add(17, 7);
            Dict.Add(18, 8);
            Dict.Add(19, 8);
            Dict.Add(20, 9);
            Dict.Add(21, 9);
            Dict.Add(22, 9);
            Dict.Add(23, 10);
            Dict.Add(24, 10);
            Dict.Add(25, 10);
            Dict.Add(26, 11);
            Dict.Add(27, 11);
            Dict.Add(28, 12);
            Dict.Add(29, 12);
            Dict.Add(30, 13);
            Dict.Add(31, 13);
            Dict.Add(32, 14);
            Dict.Add(33, 15);
            Dict.Add(34, 16);
            Dict.Add(35, 17);
            Dict.Add(36, 18);

            return Dict[Diem];
        }
        public static double GetDiemChuanChapHinh(double Diem)
        {
            Dictionary<double, double> Dict = new Dictionary<double, double>();
            Dict.Add(0, 0);
            Dict.Add(1, 0);
            Dict.Add(2, 0);
            Dict.Add(3, 1);
            Dict.Add(4, 1);
            Dict.Add(5, 2);
            Dict.Add(6, 2);
            Dict.Add(7, 2);
            Dict.Add(8, 3);
            Dict.Add(9, 3);
            Dict.Add(10, 3);
            Dict.Add(11, 4);
            Dict.Add(12, 4);
            Dict.Add(13, 4);
            Dict.Add(14, 4);
            Dict.Add(15, 5);
            Dict.Add(16, 5);
            Dict.Add(17, 5);
            Dict.Add(18, 5);
            Dict.Add(19, 6);
            Dict.Add(20, 6);
            Dict.Add(21, 6);
            Dict.Add(22, 7);
            Dict.Add(23, 7);
            Dict.Add(24, 7);
            Dict.Add(25, 8);
            Dict.Add(26, 8);
            Dict.Add(27, 8);
            Dict.Add(28, 9);
            Dict.Add(29, 9);
            Dict.Add(30, 9);
            Dict.Add(31, 10);
            Dict.Add(32, 10);
            Dict.Add(33, 10);
            Dict.Add(34, 11);
            Dict.Add(35, 11);
            Dict.Add(36, 12);
            Dict.Add(37, 12);
            Dict.Add(38, 13);
            Dict.Add(39, 13);
            Dict.Add(40, 14);
            Dict.Add(41, 15);
            Dict.Add(42, 16);
            Dict.Add(43, 17);
            Dict.Add(44, 18);

            return Dict[Diem];
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref ThangTriTueNguoiLonWechsler ketQua)
        {
            try
            {
                string sql = @"INSERT INTO TriTueNguoiLonWechsler
                (
                    MaQuanLy,
                    NgheNghiep,
                    DiaChi,
                    MaNguoiThucHien,
                    NguoiThucHien,
                    NgayThucHien,
                    ThongTin,
                    HieuBiet,
                    Toan,
                    TuongTu,
                    DaySoXuoi,
                    VonTu,
                    KyHieu,
                    NetThieu,
                    XepKhoi,
                    GhepTranh,
                    ChapHinh,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
                    :NgheNghiep,
                    :DiaChi,
                    :MaNguoiThucHien,
                    :NguoiThucHien,
                    :NgayThucHien,
                    :ThongTin,
                    :HieuBiet,
                    :Toan,
                    :TuongTu,
                    :DaySoXuoi,
                    :VonTu,
                    :KyHieu,
                    :NetThieu,
                    :XepKhoi,
                    :GhepTranh,
                    :ChapHinh,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE TriTueNguoiLonWechsler SET 
                    MaQuanLy = :MaQuanLy,
                    NgheNghiep = :NgheNghiep,
                    DiaChi = :DiaChi,
                    MaNguoiThucHien = :MaNguoiThucHien,
                    NguoiThucHien = :NguoiThucHien,
                    NgayThucHien = :NgayThucHien,
                    ThongTin = :ThongTin,
                    HieuBiet = :HieuBiet,
                    Toan = :Toan,
                    TuongTu = :TuongTu,
                    DaySoXuoi = :DaySoXuoi,
                    VonTu = :VonTu,
                    KyHieu = :KyHieu,
                    NetThieu = :NetThieu,
                    XepKhoi = :XepKhoi,
                    GhepTranh = :GhepTranh,
                    ChapHinh = :ChapHinh,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("NgheNghiep", ketQua.NgheNghiep));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", ketQua.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiThucHien", ketQua.MaNguoiThucHien));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiThucHien", ketQua.NguoiThucHien));
                Command.Parameters.Add(new MDB.MDBParameter("NgayThucHien", ketQua.NgayThucHien));
                Command.Parameters.Add(new MDB.MDBParameter("ThongTin", ketQua.ThongTin));
                Command.Parameters.Add(new MDB.MDBParameter("HieuBiet", ketQua.HieuBiet));
                Command.Parameters.Add(new MDB.MDBParameter("Toan", ketQua.Toan));
                Command.Parameters.Add(new MDB.MDBParameter("TuongTu", ketQua.TuongTu));
                Command.Parameters.Add(new MDB.MDBParameter("DaySoXuoi", ketQua.DaySoXuoi));
                Command.Parameters.Add(new MDB.MDBParameter("VonTu", ketQua.VonTu));
                Command.Parameters.Add(new MDB.MDBParameter("KyHieu", ketQua.KyHieu));
                Command.Parameters.Add(new MDB.MDBParameter("NetThieu", ketQua.NetThieu));
                Command.Parameters.Add(new MDB.MDBParameter("XepKhoi", ketQua.XepKhoi));
                Command.Parameters.Add(new MDB.MDBParameter("GhepTranh", ketQua.GhepTranh));
                Command.Parameters.Add(new MDB.MDBParameter("ChapHinh", ketQua.ChapHinh));

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
                XuLyLoi.LogError(ex);
            }
            return false;
        }


    }
}
