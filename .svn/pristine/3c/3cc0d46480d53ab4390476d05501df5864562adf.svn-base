
using EMR.KyDienTu;
using Newtonsoft.Json;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuCongKhaiDichVuKCBNTTN : ThongTinKy
    {
        public PhieuCongKhaiDichVuKCBNTTN()
        {
            TableName = "PhieuCongKhaiDichVuKCBNTTN";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PCKDVKCBNTTN;
            TenMauPhieu = DanhMucPhieu.PCKDVKCBNTTN.Description();
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
        [MoTaDuLieu("Bệnh án")]
		public string BenhAn { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
        public string MaBN { get; set; }
        [MoTaDuLieu("Buồng")]
		public string Buong { get; set; }
        [MoTaDuLieu("Giường")]
		public string Giuong { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public DateTime? NgayThucHien { get; set; }
        public DateTime? GioVeKhoa { get; set; }
        public string MaNguoiLapPhieu { get; set; }
        public string NguoiLapPhieu { get; set; }
        public int KyXacNhan { get; set; }
        public ObservableCollection<VatTuYTeKCBNTTN> ListVatTu1 { get; set; }
        public ObservableCollection<VatTuYTeKCBNTTN> ListVatTu2 { get; set; }
        public ObservableCollection<DichVuKiThuatKCBNTTN> ListDichVu1 { get; set; }
        public ObservableCollection<DichVuKiThuatKCBNTTN> ListDichVu2 { get; set; }
        public ObservableCollection<MauVaChePhamMau> ListMau { get; set; }

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

    public class VatTuYTeKCBNTTN
    {
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã định danh")]
		public long ID_Phieu { get; set; }
        public string TT { get; set; }
        [MoTaDuLieu("Tên dịch vụ")]
		public string TenDichVu { get; set; }
        public string DonVi { get; set; }
        public string HaoPhi { get; set; }
        public string ThuThuat { get; set; }
        public string BHYT { get; set; }
        public string TuTuc { get; set; }

    }

    public class DichVuKiThuatKCBNTTN
    {
        public string TT { get; set; }
        [MoTaDuLieu("Tên dịch vụ")]
		public string TenDichVu { get; set; }
        public string Lan { get; set; }
    }

    public class MauVaChePhamMau
    {
        public string Ten { get; set; }
        public string DonVi { get; set; }
        public string SoLuong { get; set; }
    }

    public class PhieuCongKhaiDichVuKCBNTTNFunc
    {
        public const string TableName = "PhieuCongKhaiDichVuKCBNTTN";
        public const string TablePrimaryKeyName = "ID";

        public static List<PhieuCongKhaiDichVuKCBNTTN> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuCongKhaiDichVuKCBNTTN> list = new List<PhieuCongKhaiDichVuKCBNTTN>();
            try
            {
                string sql = @"SELECT * FROM PhieuCongKhaiDichVuKCBNTTN where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuCongKhaiDichVuKCBNTTN data = new PhieuCongKhaiDichVuKCBNTTN();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;

                    data.MaBenhNhan = XemBenhAn._HanhChinhBenhNhan.MaBenhNhan;
                    data.TenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.SoYTe = XemBenhAn._HanhChinhBenhNhan.SoYTe;
                    data.BenhVien = XemBenhAn._HanhChinhBenhNhan.BenhVien;

                    data.MaSo = DataReader["MaSo"].ToString();
                    data.BenhAn = DataReader["BenhAn"].ToString();
                    data.MaBN = DataReader["MaBN"].ToString();
                    data.Buong = DataReader["Buong"].ToString();
                    data.Giuong = DataReader["Giuong"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.KyXacNhan = DataReader.GetInt("KyXacNhan");

                    data.NgayThucHien = Convert.ToDateTime(DataReader["NgayThucHien"] == DBNull.Value ? DateTime.Now : DataReader["NgayThucHien"]);
                    data.GioVeKhoa = Convert.ToDateTime(DataReader["GioVeKhoa"] == DBNull.Value ? DateTime.Now : DataReader["GioVeKhoa"]);
                    data.ListMau = JsonConvert.DeserializeObject<ObservableCollection<MauVaChePhamMau>>(DataReader["ListMau"].ToString());
                    data.ListDichVu1 = JsonConvert.DeserializeObject<ObservableCollection<DichVuKiThuatKCBNTTN>>(DataReader["ListDichVu1"].ToString());
                    data.ListDichVu2 = JsonConvert.DeserializeObject<ObservableCollection<DichVuKiThuatKCBNTTN>>(DataReader["ListDichVu2"].ToString());
                    data.ListVatTu1 = GetVatTu(_OracleConnection, data.ID, 1);
                    data.ListVatTu2 = GetVatTu(_OracleConnection, data.ID, 2);

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
                sql = @"DELETE FROM PhieuCongKhaiDichVuKCBNTTN WHERE ID =" + IDBienBan;
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
                PhieuCongKhaiDichVuKCBNTTN P
            WHERE
                ID = " + IDBienBan;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "TB");

            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("SoYTe", typeof(string));
            ds.Tables[0].AddColumn("BenhVien", typeof(string));
            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["SoYTe"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BenhVien"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;

            ObservableCollection<DichVuKiThuatKCBNTTN> ListDichVu1 = JsonConvert.DeserializeObject<ObservableCollection<DichVuKiThuatKCBNTTN>>(ds.Tables[0].Rows[0]["ListDichVu1"].ToString());
            ObservableCollection<DichVuKiThuatKCBNTTN> ListDichVu2 = JsonConvert.DeserializeObject<ObservableCollection<DichVuKiThuatKCBNTTN>>(ds.Tables[0].Rows[0]["ListDichVu2"].ToString());
            ObservableCollection<MauVaChePhamMau> ListMau = JsonConvert.DeserializeObject<ObservableCollection<MauVaChePhamMau>>(ds.Tables[0].Rows[0]["ListMau"].ToString());

            DataTable DV1 = Common.ListToDataTable(ListDichVu1, "DV1");
            DataTable DV2 = Common.ListToDataTable(ListDichVu2, "DV2");
            DataTable M = Common.ListToDataTable(ListMau, "M");
            DataTable VT1 = Common.ListToDataTable(GetVatTu(MyConnection, IDBienBan, 1), "VT1");
            DataTable VT2 = Common.ListToDataTable(GetVatTu(MyConnection, IDBienBan, 2), "VT2");

            ds.Tables.Add(DV1);
            ds.Tables.Add(DV2);
            ds.Tables.Add(M);
            ds.Tables.Add(VT1);
            ds.Tables.Add(VT2);

            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuCongKhaiDichVuKCBNTTN ketQua)
        {
            try
            {
                string sql = @"INSERT INTO PhieuCongKhaiDichVuKCBNTTN
                (
                    MaQuanLy,
                    MaSo,
                    BenhAn,
                    MaBN,
                    Buong,
                    Giuong,
                    ChanDoan,
                    NguoiLapPhieu,
                    MaNguoiLapPhieu,
                    NgayThucHien,
                    GioVeKhoa,
                    ListDichVu1,
                    ListDichVu2,
                    ListMau,
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
                    :NguoiLapPhieu,
                    :MaNguoiLapPhieu,
                    :NgayThucHien,
                    :GioVeKhoa,
                    :ListDichVu1,
                    :ListDichVu2,
                    :ListMau,
                    :KyXacNhan,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE PhieuCongKhaiDichVuKCBNTTN SET 
                    MaQuanLy = :MaQuanLy,
                    MaSo = :MaSo,
                    BenhAn = :BenhAn,
                    MaBN = :MaBN,
                    Buong = :Buong,
                    Giuong = :Giuong,
                    ChanDoan = :ChanDoan,
                    NguoiLapPhieu = :NguoiLapPhieu,
                    MaNguoiLapPhieu = :MaNguoiLapPhieu,
                    NgayThucHien = :NgayThucHien,
                    GioVeKhoa = :GioVeKhoa,
                    ListDichVu1 = :ListDichVu1,
                    ListDichVu2 = :ListDichVu2,
                    ListMau = :ListMau,
                    KyXacNhan = :KyXacNhan,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", ketQua.MaQuanLy));

                Command.Parameters.Add(new MDB.MDBParameter("ListDichVu1", JsonConvert.SerializeObject(ketQua.ListDichVu1)));
                Command.Parameters.Add(new MDB.MDBParameter("ListDichVu2", JsonConvert.SerializeObject(ketQua.ListDichVu2)));
                Command.Parameters.Add(new MDB.MDBParameter("ListMau", JsonConvert.SerializeObject(ketQua.ListMau)));
                Command.Parameters.Add(new MDB.MDBParameter("MaSo", ketQua.MaSo));
                Command.Parameters.Add(new MDB.MDBParameter("BenhAn", ketQua.BenhAn));
                Command.Parameters.Add(new MDB.MDBParameter("MaBN", ketQua.MaBN));
                Command.Parameters.Add(new MDB.MDBParameter("Buong", ketQua.Buong));
                Command.Parameters.Add(new MDB.MDBParameter("Giuong", ketQua.Giuong));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", ketQua.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiLapPhieu", ketQua.NguoiLapPhieu));
                Command.Parameters.Add(new MDB.MDBParameter("GioVeKhoa", ketQua.GioVeKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiLapPhieu", ketQua.MaNguoiLapPhieu));
                Command.Parameters.Add(new MDB.MDBParameter("NgayThucHien", ketQua.NgayThucHien));
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

        public static ObservableCollection<VatTuYTeKCBNTTN> GetVatTu(MDB.MDBConnection _OracleConnection, long idPhieu, int Loai)
        {
            ObservableCollection<VatTuYTeKCBNTTN> VatTuYTeKCBNTTNs = new ObservableCollection<VatTuYTeKCBNTTN>();
            try
            {
                string sql = @"SELECT * FROM VatTuYTeKCBNTTN where ID_Phieu = :ID_Phieu AND Loai = :Loai ORDER BY ID asc";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID_Phieu", idPhieu));
                Command.Parameters.Add(new MDB.MDBParameter("Loai", Loai));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    VatTuYTeKCBNTTN data = new VatTuYTeKCBNTTN();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.ID_Phieu = idPhieu;

                    data.TT = DataReader["TT"].ToString();
                    data.TenDichVu = DataReader["TenDichVu"].ToString();
                    data.DonVi = DataReader["DonVi"].ToString();
                    data.HaoPhi = DataReader["HaoPhi"].ToString();
                    data.ThuThuat = DataReader["ThuThuat"].ToString();
                    data.BHYT = DataReader["BHYT"].ToString();
                    data.TuTuc = DataReader["TuTuc"].ToString();
                    VatTuYTeKCBNTTNs.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return VatTuYTeKCBNTTNs;
        }
        public static bool DeleteVatTu(MDB.MDBConnection MyConnection, long id, int Loai)
        {
            try
            {
                string sql = "DELETE FROM VatTuYTeKCBNTTN WHERE ID = :ID AND Loai = :Loai";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                command.Parameters.Add(new MDB.MDBParameter("ID", id));
                command.Parameters.Add(new MDB.MDBParameter("Loai", Loai));
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
        public static bool InsertOrUpdateVatTu(MDB.MDBConnection MyConnection, VatTuYTeKCBNTTN _VatTuYTeKCBNTTN, int Loai)
        {
            try
            {
                string sql = @"INSERT INTO VatTuYTeKCBNTTN
                (
                    Loai,
                    ID_Phieu,
                    TT,
                    TenDichVu,
                    DonVi,
                    HaoPhi,
                    ThuThuat,
                    BHYT,
                    TuTuc)  VALUES
                 (
                    :Loai,
				    :ID_Phieu,
                    :TT,
                    :TenDichVu,
                    :DonVi,
                    :HaoPhi,
                    :ThuThuat,
                    :BHYT,
                    :TuTuc
                 )";
                if (_VatTuYTeKCBNTTN.ID != 0)
                {
                    sql = @"UPDATE VatTuYTeKCBNTTN SET 
                    Loai = :Loai,
                    ID_Phieu = :ID_Phieu,
                    TT = :TT,
                    TenDichVu = :TenDichVu,
                    DonVi = :DonVi,
                    HaoPhi = :HaoPhi,
                    ThuThuat = :ThuThuat,
                    BHYT = :BHYT,
                    TuTuc = :TuTuc
                    WHERE ID = " + _VatTuYTeKCBNTTN.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("Loai", Loai));
                Command.Parameters.Add(new MDB.MDBParameter("ID_Phieu", _VatTuYTeKCBNTTN.ID_Phieu));
                Command.Parameters.Add(new MDB.MDBParameter("TT", _VatTuYTeKCBNTTN.TT));
                Command.Parameters.Add(new MDB.MDBParameter("TenDichVu", _VatTuYTeKCBNTTN.TenDichVu));
                Command.Parameters.Add(new MDB.MDBParameter("DonVi", _VatTuYTeKCBNTTN.DonVi));
                Command.Parameters.Add(new MDB.MDBParameter("HaoPhi", _VatTuYTeKCBNTTN.HaoPhi));
                Command.Parameters.Add(new MDB.MDBParameter("ThuThuat", _VatTuYTeKCBNTTN.ThuThuat));
                Command.Parameters.Add(new MDB.MDBParameter("BHYT", _VatTuYTeKCBNTTN.BHYT));
                Command.Parameters.Add(new MDB.MDBParameter("TuTuc", _VatTuYTeKCBNTTN.TuTuc));

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
