
using EMR.KyDienTu;
using Newtonsoft.Json;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class GiayChungNhanPhauThuat2 : ThongTinKy
    {
        public GiayChungNhanPhauThuat2()
        {
            TableName = "GiayChungNhanPhauThuat2";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.GCNPT;
            TenMauPhieu = DanhMucPhieu.GCNPT.Description();
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
        [MoTaDuLieu("Mã hồ sơ")]
        public string MaHoSo { get; set; }
        [MoTaDuLieu("Tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Tuôi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Địa chỉ bệnh nhân")]
        public string DiaChi { get; set; }
        [MoTaDuLieu("Ngày vào viện")]
		public DateTime? NgayVaoVien { get; set; }
        [MoTaDuLieu("Ngày ra viện")]
        public DateTime? NgayRaVien { get; set; }

        [MoTaDuLieu("Phương pháp phẫu thuật")]
        public string PhuongPhapPhauThuat { get; set; }
        [MoTaDuLieu("Mã phẫu thuật viên")]
        public string MaPhauThuatVien { get; set; }
        [MoTaDuLieu("Phẫu thuật viên")]
        public string PhauThuatVien { get; set; }
        [MoTaDuLieu("PTV chính")]
        public string PTVChinh { get; set; }
        [MoTaDuLieu("Gây mê PTV chính")]
        public string GayMePTVChinh { get; set; }
        [MoTaDuLieu("Mã Gây mê PTV chính")]
        public string MaGayMePTVChinh { get; set; }
        [MoTaDuLieu("Mã PTV chính")]
        public string MaPTVChinh { get; set; }
        [MoTaDuLieu("Phụ mổ PTT1")]
        public string PhuMoPTT1 { get; set; }
        [MoTaDuLieu("Mã Phụ mổ PTT1")]
        public string MaPhuMoPTT1 { get; set; }
        [MoTaDuLieu("Gây mê PTT1")]
        public string GayMePTT1 { get; set; }
        [MoTaDuLieu("Mã gây mê PTT1")]
        public string MaGayMePTT1 { get; set; }
        [MoTaDuLieu("Phụ mổ PTT2")]
        public string PhuMoPTT2 { get; set; }
        [MoTaDuLieu("Mã Phụ mổ PTT2")]
        public string MaPhuMoPTT2 { get; set; }
        [MoTaDuLieu("Dụng cụ phẫu thuật viên")]
        public string DungCuPhauThuat { get; set; }
        [MoTaDuLieu("Mã Dụng cụ phẫu thuật viên")]
        public string MaDungCuPhauThuat { get; set; }
        [MoTaDuLieu("Cách thức phẫu thuật")]
        public string CachPhauThuat { get; set; }
        [MoTaDuLieu("Cách gây mê")]
        public string CachGayMe { get; set; }
        [MoTaDuLieu("Nhóm máu")]
        public string NhomMau { get; set; }
        [MoTaDuLieu("Yếu tố Rh")]
        public string Rh { get; set; }
        [MoTaDuLieu("Trưởng khoa")]
        public string TruongKhoa { get; set; }
        [MoTaDuLieu("Mã trưởng khoa")]
        public string MaTruongKhoa { get; set; }
        [MoTaDuLieu("Giám đốc")]
        public string GiamDoc { get; set; }
        [MoTaDuLieu("Mã giám đốc")]
        public string MaGiamDoc { get; set; }

        public ObservableCollection<KhamLai> ListKhamLai { get; set; }

        public ObservableCollection<LanSauVaoVien> ListLanSau { get; set; }

        public DateTime? ThoiGian { get; set; }
        [MoTaDuLieu("Người tạo")]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Người sửa")]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Ngày tạo")]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Ngày sửa")]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Chọn")]
		public bool Chon { get; set; }
        //public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Đã ký")]
		public bool DaKy { get; set; }
    }

    public class KhamLai
    {
        public DateTime? Ngay { get; set; }
        public string NoiKham { get; set; }
        public string KetQua { get; set; }
        public string BSKham { get; set; }
    }

    public class LanSauVaoVien
    {
        public DateTime? VaoNgay { get; set; }
        public DateTime? RaNgay { get; set; }
        public string BenhVien { get; set; }
        public string GhiChu { get; set; }
    }

    public class GiayChungNhanPhauThuat2Func
    {
        public const string TableName = "GiayChungNhanPhauThuat2";
        public const string TablePrimaryKeyName = "ID";

        public static List<GiayChungNhanPhauThuat2> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<GiayChungNhanPhauThuat2> list = new List<GiayChungNhanPhauThuat2>();
            try
            {
                string sql = @"SELECT * FROM GiayChungNhanPhauThuat2 where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    GiayChungNhanPhauThuat2 data = new GiayChungNhanPhauThuat2();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;

                    data.MaBenhNhan = XemBenhAn._HanhChinhBenhNhan.MaBenhNhan;
                    data.SoYTe = XemBenhAn._HanhChinhBenhNhan.SoYTe;
                    data.BenhVien = XemBenhAn._HanhChinhBenhNhan.BenhVien;

                    data.MaHoSo = DataReader["MaHoSo"].ToString();
                    data.TenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.DiaChi = DataReader["DiaChi"].ToString();
                    data.NgayVaoVien = Convert.ToDateTime(DataReader["NgayVaoVien"] == DBNull.Value ? DateTime.Now : DataReader["NgayVaoVien"]);
                    data.NgayRaVien = Convert.ToDateTime(DataReader["NgayRaVien"] == DBNull.Value ? DateTime.Now : DataReader["NgayRaVien"]);

                    data.PTVChinh = DataReader["PTVChinh"].ToString();
                    data.MaPTVChinh = DataReader["MaPTVChinh"].ToString();
                    data.GayMePTVChinh = DataReader["GayMePTVChinh"].ToString();
                    data.MaGayMePTVChinh = DataReader["MaGayMePTVChinh"].ToString();
                    data.PhuMoPTT1 = DataReader["PhuMoPTT1"].ToString();
                    data.MaPhuMoPTT1 = DataReader["MaPhuMoPTT1"].ToString();
                    data.GayMePTT1 = DataReader["GayMePTT1"].ToString();
                    data.MaGayMePTT1 = DataReader["MaGayMePTT1"].ToString();
                    data.PhuMoPTT2 = DataReader["PhuMoPTT2"].ToString();
                    data.MaPhuMoPTT2 = DataReader["MaPhuMoPTT2"].ToString();
                    data.DungCuPhauThuat = DataReader["DungCuPhauThuat"].ToString();
                    data.MaDungCuPhauThuat = DataReader["MaDungCuPhauThuat"].ToString();
                    data.PhuongPhapPhauThuat = DataReader["PhuongPhapPhauThuat"].ToString();

                    data.CachPhauThuat = DataReader["CachPhauThuat"].ToString();
                    data.PhauThuatVien = DataReader["PhauThuatVien"].ToString();
                    data.MaPhauThuatVien = DataReader["MaPhauThuatVien"].ToString();
                    data.CachGayMe = DataReader["CachGayMe"].ToString();
                    data.NhomMau = DataReader["NhomMau"].ToString();
                    data.Rh = DataReader["Rh"].ToString();
                    data.TruongKhoa = DataReader["TruongKhoa"].ToString();
                    data.MaTruongKhoa = DataReader["MaTruongKhoa"].ToString();
                    data.GiamDoc = DataReader["GiamDoc"].ToString();
                    data.MaGiamDoc = DataReader["MaGiamDoc"].ToString();
                    data.ThoiGian = Convert.ToDateTime(DataReader["ThoiGian"] == DBNull.Value ? DateTime.Now : DataReader["ThoiGian"]);

                    data.ListKhamLai = JsonConvert.DeserializeObject<ObservableCollection<KhamLai>>(DataReader["ListKhamLai"].ToString());
                    data.ListLanSau = JsonConvert.DeserializeObject<ObservableCollection<LanSauVaoVien>>(DataReader["ListLanSau"].ToString());

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
                sql = @"DELETE FROM GiayChungNhanPhauThuat2 WHERE ID =" + IDBienBan;
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
                GiayChungNhanPhauThuat2 P
            WHERE
                ID = " + IDBienBan;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "TB");

            ds.Tables[0].AddColumn("SoYTe", typeof(string));
            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("BenhVien", typeof(string));
            ds.Tables[0].AddColumn("MaBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(string));
            ds.Tables[0].AddColumn("ThoiGianFull", typeof(string));
            ds.Tables[0].Rows[0]["SoYTe"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BenhVien"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["MaBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.MaBenhNhan;
            ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();

            ObservableCollection<KhamLai>  ListKhamLai = JsonConvert.DeserializeObject<ObservableCollection<KhamLai>>(ds.Tables[0].Rows[0]["ListKhamLai"].ToString());
            ObservableCollection<LanSauVaoVien>  ListLanSau = JsonConvert.DeserializeObject<ObservableCollection<LanSauVaoVien>>(ds.Tables[0].Rows[0]["ListLanSau"].ToString());

            ds.Tables.Add(Common.ListToDataTable(ListKhamLai, "ListKhamLai"));
            ds.Tables.Add(Common.ListToDataTable(ListLanSau, "ListLanSau"));

            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref GiayChungNhanPhauThuat2 ketQua)
        {
            try
            {
                string sql = @"INSERT INTO GiayChungNhanPhauThuat2
                (
                    MaQuanLy,
                    MaHoSo,
                    DiaChi,
                    NgayVaoVien,
                    NgayRaVien,
                    PTVChinh,
                    MaPTVChinh,
                    GayMePTVChinh,
                    MaGayMePTVChinh,
                    PhuMoPTT1,
                    MaPhuMoPTT1,
                    GayMePTT1,
                    MaGayMePTT1,
                    PhuMoPTT2,
                    MaPhuMoPTT2,
                    DungCuPhauThuat,
                    MaDungCuPhauThuat,
                    PhuongPhapPhauThuat,
                    CachPhauThuat,
                    PhauThuatVien,
                    MaPhauThuatVien,
                    CachGayMe,
                    NhomMau,
                    Rh,
                    TruongKhoa,
                    MaTruongKhoa,
                    GiamDoc,
                    MaGiamDoc,
                    ListLanSau,
                    ListKhamLai,
                    ThoiGian,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
                    :MaQuanLy,
                    :MaHoSo,
                    :DiaChi,
                    :NgayVaoVien,
                    :NgayRaVien,
                    :PTVChinh,
                    :MaPTVChinh,
                    :GayMePTVChinh,
                    :MaGayMePTVChinh,
                    :PhuMoPTT1,
                    :MaPhuMoPTT1,
                    :GayMePTT1,
                    :MaGayMePTT1,
                    :PhuMoPTT2,
                    :MaPhuMoPTT2,
                    :DungCuPhauThuat,
                    :MaDungCuPhauThuat,
                    :PhuongPhapPhauThuat,
                    :CachPhauThuat,
                    :PhauThuatVien,
                    :MaPhauThuatVien,
                    :CachGayMe,
                    :NhomMau,
                    :Rh,
                    :TruongKhoa,
                    :MaTruongKhoa,
                    :GiamDoc,
                    :MaGiamDoc,
                    :ListLanSau,
                    :ListKhamLai,
                    :ThoiGian,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE GiayChungNhanPhauThuat2 SET 
                    MaQuanLy = :MaQuanLy,
                    MaHoSo = :MaHoSo,
                    DiaChi = :DiaChi,
                    NgayVaoVien = :NgayVaoVien,
                    NgayRaVien = :NgayRaVien,
                    PTVChinh = :PTVChinh,
                    MaPTVChinh = :MaPTVChinh,
                    GayMePTVChinh = :GayMePTVChinh,
                    MaGayMePTVChinh = :MaGayMePTVChinh,
                    PhuMoPTT1 = :PhuMoPTT1,
                    MaPhuMoPTT1 = :MaPhuMoPTT1,
                    GayMePTT1 = :GayMePTT1,
                    MaGayMePTT1 = :MaGayMePTT1,
                    PhuMoPTT2 = :PhuMoPTT2,
                    MaPhuMoPTT2 = :MaPhuMoPTT2,
                    DungCuPhauThuat = :DungCuPhauThuat,
                    MaDungCuPhauThuat = :MaDungCuPhauThuat,
                    PhuongPhapPhauThuat = :PhuongPhapPhauThuat,
                    CachPhauThuat = :CachPhauThuat,
                    PhauThuatVien = :PhauThuatVien,
                    MaPhauThuatVien = :MaPhauThuatVien,
                    CachGayMe = :CachGayMe,
                    NhomMau = :NhomMau,
                    Rh = :Rh,
                    TruongKhoa = :TruongKhoa,
                    MaTruongKhoa = :MaTruongKhoa,
                    GiamDoc = :GiamDoc,
                    MaGiamDoc = :MaGiamDoc,
                    ListLanSau = :ListLanSau,
                    ListKhamLai = :ListKhamLai,
                    ThoiGian = :ThoiGian,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", ketQua.MaQuanLy));

                Command.Parameters.Add(new MDB.MDBParameter("MaHoSo", ketQua.MaHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", ketQua.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("NgayVaoVien", ketQua.NgayVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("NgayRaVien", ketQua.NgayRaVien));
                Command.Parameters.Add(new MDB.MDBParameter("PTVChinh", ketQua.PTVChinh));
                Command.Parameters.Add(new MDB.MDBParameter("MaPTVChinh", ketQua.MaPTVChinh));
                Command.Parameters.Add(new MDB.MDBParameter("GayMePTVChinh", ketQua.GayMePTVChinh));
                Command.Parameters.Add(new MDB.MDBParameter("MaGayMePTVChinh", ketQua.MaGayMePTVChinh));
                Command.Parameters.Add(new MDB.MDBParameter("PhuMoPTT1", ketQua.PhuMoPTT1));
                Command.Parameters.Add(new MDB.MDBParameter("MaPhuMoPTT1", ketQua.MaPhuMoPTT1));
                Command.Parameters.Add(new MDB.MDBParameter("GayMePTT1", ketQua.GayMePTT1));
                Command.Parameters.Add(new MDB.MDBParameter("MaGayMePTT1", ketQua.MaGayMePTT1));
                Command.Parameters.Add(new MDB.MDBParameter("PhuMoPTT2", ketQua.PhuMoPTT2));
                Command.Parameters.Add(new MDB.MDBParameter("MaPhuMoPTT2", ketQua.MaPhuMoPTT2));
                Command.Parameters.Add(new MDB.MDBParameter("DungCuPhauThuat", ketQua.DungCuPhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("MaDungCuPhauThuat", ketQua.MaDungCuPhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapPhauThuat", ketQua.PhuongPhapPhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("CachPhauThuat", ketQua.CachPhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("PhauThuatVien", ketQua.PhauThuatVien));
                Command.Parameters.Add(new MDB.MDBParameter("MaPhauThuatVien", ketQua.MaPhauThuatVien));
                Command.Parameters.Add(new MDB.MDBParameter("CachGayMe", ketQua.CachGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("NhomMau", ketQua.NhomMau));
                Command.Parameters.Add(new MDB.MDBParameter("Rh", ketQua.Rh));
                Command.Parameters.Add(new MDB.MDBParameter("TruongKhoa", ketQua.TruongKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaTruongKhoa", ketQua.MaTruongKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("GiamDoc", ketQua.GiamDoc));
                Command.Parameters.Add(new MDB.MDBParameter("MaGiamDoc", ketQua.MaGiamDoc));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGian", ketQua.ThoiGian));

                Command.Parameters.Add(new MDB.MDBParameter("ListKhamLai", JsonConvert.SerializeObject(ketQua.ListKhamLai)));
                Command.Parameters.Add(new MDB.MDBParameter("ListLanSau", JsonConvert.SerializeObject(ketQua.ListLanSau)));



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
