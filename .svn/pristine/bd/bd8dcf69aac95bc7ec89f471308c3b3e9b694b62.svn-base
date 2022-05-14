
using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuCongKhaiThuocTheoNgay : ThongTinKy
    {
        public PhieuCongKhaiThuocTheoNgay()
        {
            TableName = "PhieuCongKhaiThuocTheoNgay";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PCKTTN;
            TenMauPhieu = DanhMucPhieu.PCKTTN.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
		[MoTaDuLieu("Sở Y Tế")]
		public string SoYTe { get; set; }
        [MoTaDuLieu("Bệnh viện")]
		public string BenhVien { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        public string MaSo { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Bệnh án")]
		public string BenhAn { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
        public string MaBN { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Buồng")]
		public string Buong { get; set; }
        [MoTaDuLieu("Giường")]
		public string Giuong { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public DateTime? NgayVaoVien { get; set; }
        public DateTime? NgayRaVien { get; set; }
        [MoTaDuLieu("Mã điều dưỡng")]
		public string MaDieuDuongCaNgay { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuongCaNgay { get; set; }
        [MoTaDuLieu("Mã điều dưỡng")]
		public string MaDieuDuongCaDem { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuongCaDem { get; set; }
        [MoTaDuLieu("Mã điều dưỡng")]
		public string MaDieuDuongKy { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuongKy { get; set; }
        public DateTime? ThucHienNgayHeader { get; set; }
        public string HeaderGio1 { get; set; }
        public string HeaderGio2 { get; set; }
        public string HeaderGio3 { get; set; }
        public string HeaderGio4 { get; set; }
        public string HeaderGio5 { get; set; }
        public string HeaderGio6 { get; set; }
        public string HeaderGio7 { get; set; }
        public string HeaderGio8 { get; set; }
        public string TongSo { get; set; }
        public string NguoiKyXacNhan { get; set; }
        public bool[] KyXacNhanArray { get; } = new bool[] { false, false };
        public string KyXacNhan
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < KyXacNhanArray.Length; i++)
                    temp += (KyXacNhanArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        KyXacNhanArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public ObservableCollection<ThongKeThuocTheoNgay> ListThongKe { get; set; }
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

    public class ThongKeThuocTheoNgay
    {
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã định danh")]
		public long ID_Phieu { get; set; }
        public string TT { get; set; }
        public string TenThuoc { get; set; }
        public string SoLo { get; set; }
        public string DonVi { get; set; }
        public string HuongDanSuDung { get; set; }
        public string Gio1 { get; set; }
        public string Gio2 { get; set; }
        public string Gio3 { get; set; }
        public string Gio4 { get; set; }
        public string Gio5 { get; set; }
        public string Gio6 { get; set; }
        public string Gio7 { get; set; }
        public string Gio8 { get; set; }
        public string Tong { get; set; }
        public string NguonCap { get; set; }
        [MoTaDuLieu("Ghi chú")]
		public string GhiChu { get; set; }

    }

    public class PhieuCongKhaiThuocTheoNgayFunc
    {
        public const string TableName = "PhieuCongKhaiThuocTheoNgay";
        public const string TablePrimaryKeyName = "ID";

        public static List<PhieuCongKhaiThuocTheoNgay> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuCongKhaiThuocTheoNgay> list = new List<PhieuCongKhaiThuocTheoNgay>();
            try
            {
                string sql = @"SELECT * FROM PhieuCongKhaiThuocTheoNgay where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuCongKhaiThuocTheoNgay data = new PhieuCongKhaiThuocTheoNgay();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;

                    data.MaBenhNhan = XemBenhAn._HanhChinhBenhNhan.MaBenhNhan;
                    data.TenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.SoYTe = XemBenhAn._HanhChinhBenhNhan.SoYTe;
                    data.BenhVien = XemBenhAn._HanhChinhBenhNhan.BenhVien;
                    data.Khoa = XemBenhAn._ThongTinDieuTri.Khoa;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();

                    data.MaSo = DataReader["MaSo"].ToString();
                    data.BenhAn = DataReader["BenhAn"].ToString();
                    data.MaBN = DataReader["MaBN"].ToString();
                    data.Buong = DataReader["Buong"].ToString();
                    data.Giuong = DataReader["Giuong"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.ThucHienNgayHeader = Convert.ToDateTime(DataReader["ThucHienNgayHeader"] == DBNull.Value ? DateTime.Now : DataReader["ThucHienNgayHeader"]);
                    data.NgayVaoVien = Convert.ToDateTime(DataReader["NgayVaoVien"] == DBNull.Value ? DateTime.Now : DataReader["NgayVaoVien"]);
                    data.NgayRaVien = Convert.ToDateTime(DataReader["NgayRaVien"] == DBNull.Value ? DateTime.Now : DataReader["NgayRaVien"]);
                    data.HeaderGio1 = DataReader["HeaderGio1"].ToString();
                    data.HeaderGio2 = DataReader["HeaderGio2"].ToString();
                    data.HeaderGio3 = DataReader["HeaderGio3"].ToString();
                    data.HeaderGio4 = DataReader["HeaderGio4"].ToString();
                    data.HeaderGio5 = DataReader["HeaderGio5"].ToString();
                    data.HeaderGio6 = DataReader["HeaderGio6"].ToString();
                    data.HeaderGio7 = DataReader["HeaderGio7"].ToString();
                    data.HeaderGio8 = DataReader["HeaderGio8"].ToString();
                    data.MaDieuDuongCaDem = DataReader["MaDieuDuongCaDem"].ToString();
                    data.DieuDuongCaDem = DataReader["DieuDuongCaDem"].ToString();
                    data.MaDieuDuongCaNgay = DataReader["MaDieuDuongCaNgay"].ToString();
                    data.DieuDuongCaNgay = DataReader["DieuDuongCaNgay"].ToString();
                    data.MaDieuDuongKy = DataReader["MaDieuDuongKy"].ToString();
                    data.DieuDuongKy = DataReader["DieuDuongKy"].ToString();
                    data.TongSo = DataReader["TongSo"].ToString();
                    data.KyXacNhan = DataReader["KyXacNhan"].ToString();
                    data.NguoiKyXacNhan = DataReader["NguoiKyXacNhan"].ToString();

                    data.ListThongKe = GetThongKe(_OracleConnection, data.ID);

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
                string sql = "";
                MDB.MDBCommand oracleCommand;
                sql = @"DELETE FROM PhieuCongKhaiThuocTheoNgay WHERE ID =" + IDBienBan;
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
                PhieuCongKhaiThuocTheoNgay P
            WHERE
                ID = " + IDBienBan;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "TB");

            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("SoYTe", typeof(string));
            ds.Tables[0].AddColumn("BenhVien", typeof(string));
            ds.Tables[0].AddColumn("Khoa", typeof(string));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(string));
            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["SoYTe"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BenhVien"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["Khoa"] = XemBenhAn._ThongTinDieuTri.Khoa;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();

            DataTable TK = Common.ListToDataTable(GetThongKe(MyConnection, IDBienBan), "TK");

            ds.Tables.Add(TK);

            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuCongKhaiThuocTheoNgay ketQua)
        {
            try
            {
                string sql = @"INSERT INTO PhieuCongKhaiThuocTheoNgay
                (
                    MaQuanLy,
                    MaSo,
                    BenhAn,
                    MaBN,
                    Buong,
                    Giuong,
                    ChanDoan,
                    NgayVaoVien,
                    NgayRaVien,
                    DieuDuongCaNgay,
                    MaDieuDuongCaNgay,
                    DieuDuongCaDem,
                    MaDieuDuongCaDem,
                    MaDieuDuongKy,
                    DieuDuongKy,
                    ThucHienNgayHeader,
                    HeaderGio1,
                    HeaderGio2,
                    HeaderGio3,
                    HeaderGio4,
                    HeaderGio5,
                    HeaderGio6,
                    HeaderGio7,
                    HeaderGio8,
                    TongSo,
                    NguoiKyXacNhan,
                    KyXacNhan,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
                    :MaSo,
                    :BenhAn,
                    :MaBN,
                    :Buong,
                    :Giuong,
                    :ChanDoan,
                    :NgayVaoVien,
                    :NgayRaVien,
                    :DieuDuongCaNgay,
                    :MaDieuDuongCaNgay,
                    :DieuDuongCaDem,
                    :MaDieuDuongCaDem,
                    :MaDieuDuongKy,
                    :DieuDuongKy,
                    :ThucHienNgayHeader,
                    :HeaderGio1,
                    :HeaderGio2,
                    :HeaderGio3,
                    :HeaderGio4,
                    :HeaderGio5,
                    :HeaderGio6,
                    :HeaderGio7,
                    :HeaderGio8,
                    :TongSo,
                    :NguoiKyXacNhan,
                    :KyXacNhan,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE PhieuCongKhaiThuocTheoNgay SET 
                    MaQuanLy = :MaQuanLy,
                    MaSo = :MaSo,
                    BenhAn = :BenhAn,
                    MaBN = :MaBN,
                    Buong = :Buong,
                    Giuong = :Giuong,
                    ChanDoan = :ChanDoan,
                    NgayVaoVien = :NgayVaoVien,
                    NgayRaVien = :NgayRaVien,
                    DieuDuongCaNgay = :DieuDuongCaNgay,
                    MaDieuDuongCaNgay = :MaDieuDuongCaNgay,
                    DieuDuongCaDem = :DieuDuongCaDem,
                    MaDieuDuongCaDem = :MaDieuDuongCaDem,
                    MaDieuDuongKy = :MaDieuDuongKy,
                    DieuDuongKy = :DieuDuongKy,
                    ThucHienNgayHeader = :ThucHienNgayHeader,
                    HeaderGio1 = :HeaderGio1,
                    HeaderGio2 = :HeaderGio2,
                    HeaderGio3 = :HeaderGio3,
                    HeaderGio4 = :HeaderGio4,
                    HeaderGio5 = :HeaderGio5,
                    HeaderGio6 = :HeaderGio6,
                    HeaderGio7 = :HeaderGio7,
                    HeaderGio8 = :HeaderGio8,
                    TongSo = :TongSo,
                    NguoiKyXacNhan = :NguoiKyXacNhan,
                    KyXacNhan = :KyXacNhan,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", ketQua.MaQuanLy));

                Command.Parameters.Add(new MDB.MDBParameter("MaSo", ketQua.MaSo));
                Command.Parameters.Add(new MDB.MDBParameter("BenhAn", ketQua.BenhAn));
                Command.Parameters.Add(new MDB.MDBParameter("MaBN", ketQua.MaBN));
                Command.Parameters.Add(new MDB.MDBParameter("Buong", ketQua.Buong));
                Command.Parameters.Add(new MDB.MDBParameter("Giuong", ketQua.Giuong));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", ketQua.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("NgayVaoVien", ketQua.NgayVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("NgayRaVien", ketQua.NgayRaVien));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuongCaDem", ketQua.DieuDuongCaDem));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuongCaDem", ketQua.MaDieuDuongCaDem));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuongCaNgay", ketQua.MaDieuDuongCaNgay));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuongCaNgay", ketQua.DieuDuongCaNgay));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuongKy", ketQua.DieuDuongKy));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuongKy", ketQua.MaDieuDuongKy));
                Command.Parameters.Add(new MDB.MDBParameter("ThucHienNgayHeader", ketQua.ThucHienNgayHeader));
                Command.Parameters.Add(new MDB.MDBParameter("HeaderGio1", ketQua.HeaderGio1));
                Command.Parameters.Add(new MDB.MDBParameter("HeaderGio2", ketQua.HeaderGio2));
                Command.Parameters.Add(new MDB.MDBParameter("HeaderGio3", ketQua.HeaderGio3));
                Command.Parameters.Add(new MDB.MDBParameter("HeaderGio4", ketQua.HeaderGio4));
                Command.Parameters.Add(new MDB.MDBParameter("HeaderGio5", ketQua.HeaderGio5));
                Command.Parameters.Add(new MDB.MDBParameter("HeaderGio6", ketQua.HeaderGio6));
                Command.Parameters.Add(new MDB.MDBParameter("HeaderGio7", ketQua.HeaderGio7));
                Command.Parameters.Add(new MDB.MDBParameter("HeaderGio8", ketQua.HeaderGio8));
                Command.Parameters.Add(new MDB.MDBParameter("TongSo", ketQua.TongSo));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiKyXacNhan", ketQua.NguoiKyXacNhan));
                Command.Parameters.Add(new MDB.MDBParameter("KyXacNhan", ketQua.KyXacNhan));

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

        public static ObservableCollection<ThongKeThuocTheoNgay> GetThongKe(MDB.MDBConnection _OracleConnection, long idPhieu)
        {
            ObservableCollection<ThongKeThuocTheoNgay> ThongKeThuocTheoNgays = new ObservableCollection<ThongKeThuocTheoNgay>();
            try
            {
                string sql = @"SELECT * FROM ThongKeThuocTheoNgay where ID_Phieu = :ID_Phieu ORDER BY ID asc";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID_Phieu", idPhieu));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    ThongKeThuocTheoNgay data = new ThongKeThuocTheoNgay();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.ID_Phieu = idPhieu;

                    data.TT = DataReader["TT"].ToString();
                    data.TenThuoc = DataReader["TenThuoc"].ToString();
                    data.SoLo = DataReader["SoLo"].ToString();
                    data.DonVi = DataReader["DonVi"].ToString();
                    data.HuongDanSuDung = DataReader["HuongDanSuDung"].ToString();
                    data.Gio1 = DataReader["Gio1"].ToString();
                    data.Gio2 = DataReader["Gio2"].ToString();
                    data.Gio3 = DataReader["Gio3"].ToString();
                    data.Gio4 = DataReader["Gio4"].ToString();
                    data.Gio5 = DataReader["Gio5"].ToString();
                    data.Gio6 = DataReader["Gio6"].ToString();
                    data.Gio7 = DataReader["Gio7"].ToString();
                    data.Gio8 = DataReader["Gio8"].ToString();
                    data.Tong = DataReader["Tong"].ToString();
                    data.NguonCap = DataReader["NguonCap"].ToString();
                    data.GhiChu = DataReader["GhiChu"].ToString();

                    ThongKeThuocTheoNgays.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return ThongKeThuocTheoNgays;
        }
        public static bool DeleteThongKe(MDB.MDBConnection MyConnection, long id)
        {
            try
            {
                string sql = "DELETE FROM ThongKeThuocTheoNgay WHERE ID = :ID";
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
        public static bool InsertOrUpdateThongKe(MDB.MDBConnection MyConnection, ThongKeThuocTheoNgay _ThongKeThuocTheoNgay)
        {
            try
            {
                string sql = @"INSERT INTO ThongKeThuocTheoNgay
                (
                    ID_Phieu,
                    TT,
                    TenThuoc,
                    SoLo,
                    DonVi,
                    HuongDanSuDung,
                    Gio1,
                    Gio2,
                    Gio3,
                    Gio4,
                    Gio5,
                    Gio6,
                    Gio7,
                    Gio8,
                    Tong,
                    NguonCap,
                    GhiChu)  VALUES
                 (
				    :ID_Phieu,
                    :TT,
                    :TenThuoc,
                    :SoLo,
                    :DonVi,
                    :HuongDanSuDung,
                    :Gio1,
                    :Gio2,
                    :Gio3,
                    :Gio4,
                    :Gio5,
                    :Gio6,
                    :Gio7,
                    :Gio8,
                    :Tong,
                    :NguonCap,
                    :GhiChu
                 )";
                if (_ThongKeThuocTheoNgay.ID != 0)
                {
                    sql = @"UPDATE ThongKeThuocTheoNgay SET 
                    ID_Phieu = :ID_Phieu,
                    TT = :TT,
                    TenThuoc = :TenThuoc,
                    SoLo = :SoLo,
                    DonVi = :DonVi,
                    HuongDanSuDung = :HuongDanSuDung,
                    Gio1 = :Gio1,
                    Gio2 = :Gio2,
                    Gio3 = :Gio3,
                    Gio4 = :Gio4,
                    Gio5 = :Gio5,
                    Gio6 = :Gio6,
                    Gio7 = :Gio7,
                    Gio8 = :Gio8,
                    Tong = :Tong,
                    NguonCap = :NguonCap,
                    GhiChu = :GhiChu
                    WHERE ID = " + _ThongKeThuocTheoNgay.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID_Phieu", _ThongKeThuocTheoNgay.ID_Phieu));
                Command.Parameters.Add(new MDB.MDBParameter("TT", _ThongKeThuocTheoNgay.TT));
                Command.Parameters.Add(new MDB.MDBParameter("TenThuoc", _ThongKeThuocTheoNgay.TenThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("SoLo", _ThongKeThuocTheoNgay.SoLo));
                Command.Parameters.Add(new MDB.MDBParameter("DonVi", _ThongKeThuocTheoNgay.DonVi));
                Command.Parameters.Add(new MDB.MDBParameter("HuongDanSuDung", _ThongKeThuocTheoNgay.HuongDanSuDung));
                Command.Parameters.Add(new MDB.MDBParameter("Gio1", _ThongKeThuocTheoNgay.Gio1));
                Command.Parameters.Add(new MDB.MDBParameter("Gio2", _ThongKeThuocTheoNgay.Gio2));
                Command.Parameters.Add(new MDB.MDBParameter("Gio3", _ThongKeThuocTheoNgay.Gio3));
                Command.Parameters.Add(new MDB.MDBParameter("Gio4", _ThongKeThuocTheoNgay.Gio4));
                Command.Parameters.Add(new MDB.MDBParameter("Gio5", _ThongKeThuocTheoNgay.Gio5));
                Command.Parameters.Add(new MDB.MDBParameter("Gio6", _ThongKeThuocTheoNgay.Gio6));
                Command.Parameters.Add(new MDB.MDBParameter("Gio7", _ThongKeThuocTheoNgay.Gio7));
                Command.Parameters.Add(new MDB.MDBParameter("Gio8", _ThongKeThuocTheoNgay.Gio8));
                Command.Parameters.Add(new MDB.MDBParameter("Tong", _ThongKeThuocTheoNgay.Tong));
                Command.Parameters.Add(new MDB.MDBParameter("NguonCap", _ThongKeThuocTheoNgay.NguonCap));
                Command.Parameters.Add(new MDB.MDBParameter("GhiChu", _ThongKeThuocTheoNgay.GhiChu));

                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
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
