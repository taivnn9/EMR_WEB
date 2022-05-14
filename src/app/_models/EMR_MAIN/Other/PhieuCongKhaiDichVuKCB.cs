
using EMR.KyDienTu;
using Newtonsoft.Json;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuCongKhaiDichVuKCB : ThongTinKy
    {
        public PhieuCongKhaiDichVuKCB()
        {
            TableName = "PhieuCongKhaiDichVuKCB";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PCKDVKCB;
            TenMauPhieu = DanhMucPhieu.PCKDVKCB.Description();
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
        public string TTNgoai { get; set; }
        [MoTaDuLieu("Buồng")]
		public string Buong { get; set; }
        [MoTaDuLieu("Giường")]
		public string Giuong { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public DateTime? NgayThucHien { get; set; }
        [MoTaDuLieu("Mã điều dưỡng")]
		public string MaDieuDuong { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuong { get; set; }
        public string Nhom2_Header1 { get; set; }
        public string Nhom2_Header2 { get; set; }
        public string Nhom2_Header3 { get; set; }
        public string Nhom2_Header4 { get; set; }
        public ObservableCollection<VatTuYTeKCB> ListVatTu { get; set; }
        public ObservableCollection<DichVuKiThuatKCB> ListDichVu { get; set; }
        public ObservableCollection<DichVuKiThuatKCB> ListXetNghiem { get; set; }
        public ObservableCollection<DichVuKiThuatKCB> ListMau { get; set; }
        public ObservableCollection<DichVuKiThuatKCB> ListGiuong { get; set; }

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

    public class VatTuYTeKCB
    {
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã định danh")]
		public long ID_Phieu { get; set; }
        public string TT { get; set; }
        public string VatTuYTe { get; set; }
        public string DonVi { get; set; }
        public string Nhom1_1 { get; set; }
        public string Nhom1_2 { get; set; }
        public string Nhom1_3 { get; set; }
        public string Nhom1_4 { get; set; }
        public string Nhom2_1 { get; set; }
        public string Nhom2_2 { get; set; }
        public string Nhom2_3 { get; set; }
        public string Nhom2_4 { get; set; }
        public string Nhom2_5 { get; set; }

    }

    public class DichVuKiThuatKCB
    {
        public string Ten { get; set; }
        public string SL { get; set; }
    }

    public class PhieuCongKhaiDichVuKCBFunc
    {
        public const string TableName = "PhieuCongKhaiDichVuKCB";
        public const string TablePrimaryKeyName = "ID";

        public static List<PhieuCongKhaiDichVuKCB> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuCongKhaiDichVuKCB> list = new List<PhieuCongKhaiDichVuKCB>();
            try
            {
                string sql = @"SELECT * FROM PhieuCongKhaiDichVuKCB where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuCongKhaiDichVuKCB data = new PhieuCongKhaiDichVuKCB();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;

                    data.MaBenhNhan = XemBenhAn._HanhChinhBenhNhan.MaBenhNhan;
                    data.TenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.SoYTe = XemBenhAn._HanhChinhBenhNhan.SoYTe;
                    data.BenhVien = XemBenhAn._HanhChinhBenhNhan.BenhVien;

                    data.TTNgoai = DataReader["TTNgoai"].ToString();
                    data.MaSo = DataReader["MaSo"].ToString();
                    data.BenhAn = DataReader["BenhAn"].ToString();
                    data.MaBN = DataReader["MaBN"].ToString();
                    data.Buong = DataReader["Buong"].ToString();
                    data.Giuong = DataReader["Giuong"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.Nhom2_Header1 = DataReader["Nhom2_Header1"].ToString();
                    data.Nhom2_Header2 = DataReader["Nhom2_Header2"].ToString();
                    data.Nhom2_Header3 = DataReader["Nhom2_Header3"].ToString();
                    data.Nhom2_Header4 = DataReader["Nhom2_Header4"].ToString();
                    data.MaDieuDuong = DataReader["MaDieuDuong"].ToString();
                    data.DieuDuong = DataReader["DieuDuong"].ToString();

                    data.NgayThucHien = Convert.ToDateTime(DataReader["NgayThucHien"] == DBNull.Value ? DateTime.Now : DataReader["NgayThucHien"]);
                    data.ListDichVu = JsonConvert.DeserializeObject<ObservableCollection<DichVuKiThuatKCB>>(DataReader["ListDichVu"].ToString());
                    data.ListXetNghiem = JsonConvert.DeserializeObject<ObservableCollection<DichVuKiThuatKCB>>(DataReader["ListXetNghiem"].ToString());
                    data.ListMau = JsonConvert.DeserializeObject<ObservableCollection<DichVuKiThuatKCB>>(DataReader["ListMau"].ToString());
                    data.ListGiuong = JsonConvert.DeserializeObject<ObservableCollection<DichVuKiThuatKCB>>(DataReader["ListGiuong"].ToString());
                    data.ListVatTu = GetVatTu(_OracleConnection, data.ID);

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
                sql = @"DELETE FROM PhieuCongKhaiDichVuKCB WHERE ID =" + IDBienBan;
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
                PhieuCongKhaiDichVuKCB P
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

            ObservableCollection<DichVuKiThuatKCB> ListDichVu = JsonConvert.DeserializeObject<ObservableCollection<DichVuKiThuatKCB>>(ds.Tables[0].Rows[0]["ListDichVu"].ToString());
            ObservableCollection<DichVuKiThuatKCB> ListXetNghiem = JsonConvert.DeserializeObject<ObservableCollection<DichVuKiThuatKCB>>(ds.Tables[0].Rows[0]["ListXetNghiem"].ToString());
            ObservableCollection<DichVuKiThuatKCB> ListMau = JsonConvert.DeserializeObject<ObservableCollection<DichVuKiThuatKCB>>(ds.Tables[0].Rows[0]["ListMau"].ToString());
            ObservableCollection<DichVuKiThuatKCB> ListGiuong = JsonConvert.DeserializeObject<ObservableCollection<DichVuKiThuatKCB>>(ds.Tables[0].Rows[0]["ListGiuong"].ToString());

            DataTable DV = Common.ListToDataTable(ListDichVu, "DV");
            DataTable XN = Common.ListToDataTable(ListXetNghiem, "XN");
            DataTable M = Common.ListToDataTable(ListMau, "M");
            DataTable G = Common.ListToDataTable(ListGiuong, "G");
            DataTable VT = Common.ListToDataTable(GetVatTu(MyConnection, IDBienBan), "VT");

            ds.Tables.Add(DV);
            ds.Tables.Add(XN);
            ds.Tables.Add(M);
            ds.Tables.Add(G);
            ds.Tables.Add(VT);

            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuCongKhaiDichVuKCB ketQua)
        {
            try
            {
                string sql = @"INSERT INTO PhieuCongKhaiDichVuKCB
                (
                    MaQuanLy,
                    TTNgoai,
                    MaSo,
                    BenhAn,
                    MaBN,
                    Buong,
                    Giuong,
                    ChanDoan,
                    DieuDuong,
                    MaDieuDuong,
                    NgayThucHien,
                    Nhom2_Header1,
                    Nhom2_Header2,
                    Nhom2_Header3,
                    Nhom2_Header4,
                    ListDichVu,
                    ListXetNghiem,
                    ListMau,
                    ListGiuong,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
                    :TTNgoai,
                    :MaSo,
                    :BenhAn,
                    :MaBN,
                    :Buong,
                    :Giuong,
                    :ChanDoan,
                    :DieuDuong,
                    :MaDieuDuong,
                    :NgayThucHien,
                    :Nhom2_Header1,
                    :Nhom2_Header2,
                    :Nhom2_Header3,
                    :Nhom2_Header4,
                    :ListDichVu,
                    :ListXetNghiem,
                    :ListMau,
                    :ListGiuong,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE PhieuCongKhaiDichVuKCB SET 
                    MaQuanLy = :MaQuanLy,
                    TTNgoai = :TTNgoai,
                    MaSo = :MaSo,
                    BenhAn = :BenhAn,
                    MaBN = :MaBN,
                    Buong = :Buong,
                    Giuong = :Giuong,
                    ChanDoan = :ChanDoan,
                    DieuDuong = :DieuDuong,
                    MaDieuDuong = :MaDieuDuong,
                    NgayThucHien = :NgayThucHien,
                    Nhom2_Header1 = :Nhom2_Header1,
                    Nhom2_Header2 = :Nhom2_Header2,
                    Nhom2_Header3 = :Nhom2_Header3,
                    Nhom2_Header4 = :Nhom2_Header4,
                    ListDichVu = :ListDichVu,
                    ListXetNghiem = :ListXetNghiem,
                    ListMau = :ListMau,
                    ListGiuong = :ListGiuong,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", ketQua.MaQuanLy));

                Command.Parameters.Add(new MDB.MDBParameter("ListDichVu", JsonConvert.SerializeObject(ketQua.ListDichVu)));
                Command.Parameters.Add(new MDB.MDBParameter("ListXetNghiem", JsonConvert.SerializeObject(ketQua.ListXetNghiem)));
                Command.Parameters.Add(new MDB.MDBParameter("ListMau", JsonConvert.SerializeObject(ketQua.ListMau)));
                Command.Parameters.Add(new MDB.MDBParameter("ListGiuong", JsonConvert.SerializeObject(ketQua.ListGiuong)));
                Command.Parameters.Add(new MDB.MDBParameter("TTNgoai", ketQua.TTNgoai));
                Command.Parameters.Add(new MDB.MDBParameter("MaSo", ketQua.MaSo));
                Command.Parameters.Add(new MDB.MDBParameter("BenhAn", ketQua.BenhAn));
                Command.Parameters.Add(new MDB.MDBParameter("MaBN", ketQua.MaBN));
                Command.Parameters.Add(new MDB.MDBParameter("Buong", ketQua.Buong));
                Command.Parameters.Add(new MDB.MDBParameter("Giuong", ketQua.Giuong));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", ketQua.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuong", ketQua.DieuDuong));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuong", ketQua.MaDieuDuong));
                Command.Parameters.Add(new MDB.MDBParameter("NgayThucHien", ketQua.NgayThucHien));
                Command.Parameters.Add(new MDB.MDBParameter("Nhom2_Header1", ketQua.Nhom2_Header1));
                Command.Parameters.Add(new MDB.MDBParameter("Nhom2_Header2", ketQua.Nhom2_Header2));
                Command.Parameters.Add(new MDB.MDBParameter("Nhom2_Header3", ketQua.Nhom2_Header3));
                Command.Parameters.Add(new MDB.MDBParameter("Nhom2_Header4", ketQua.Nhom2_Header4));

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

        public static ObservableCollection<VatTuYTeKCB> GetVatTu(MDB.MDBConnection _OracleConnection, long idPhieu)
        {
            ObservableCollection<VatTuYTeKCB> VatTuYTeKCBs = new ObservableCollection<VatTuYTeKCB>();
            try
            {
                string sql = @"SELECT * FROM VatTuYTeKCB where ID_Phieu = :ID_Phieu ORDER BY ID asc";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID_Phieu", idPhieu));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    VatTuYTeKCB data = new VatTuYTeKCB();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.ID_Phieu = idPhieu;

                    data.TT = DataReader["TT"].ToString();
                    data.VatTuYTe = DataReader["VatTuYTe"].ToString();
                    data.DonVi = DataReader["DonVi"].ToString();
                    data.Nhom1_1 = DataReader["Nhom1_1"].ToString();
                    data.Nhom1_2 = DataReader["Nhom1_2"].ToString();
                    data.Nhom1_3 = DataReader["Nhom1_3"].ToString();
                    data.Nhom1_4 = DataReader["Nhom1_4"].ToString();
                    data.Nhom2_1 = DataReader["Nhom2_1"].ToString();
                    data.Nhom2_2 = DataReader["Nhom2_2"].ToString();
                    data.Nhom2_3 = DataReader["Nhom2_3"].ToString();
                    data.Nhom2_4 = DataReader["Nhom2_4"].ToString();
                    data.Nhom2_5 = DataReader["Nhom2_5"].ToString();

                    VatTuYTeKCBs.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return VatTuYTeKCBs;
        }
        public static bool DeleteVatTu(MDB.MDBConnection MyConnection, long id)
        {
            try
            {
                string sql = "DELETE FROM VatTuYTeKCB WHERE ID = :ID";
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
        public static bool InsertOrUpdateVatTu(MDB.MDBConnection MyConnection, VatTuYTeKCB _VatTuYTeKCB)
        {
            try
            {
                string sql = @"INSERT INTO VatTuYTeKCB
                (
                    ID_Phieu,
                    TT,
                    VatTuYTe,
                    DonVi,
                    Nhom1_1,
                    Nhom1_2,
                    Nhom1_3,
                    Nhom1_4,
                    Nhom2_1,
                    Nhom2_2,
                    Nhom2_3,
                    Nhom2_4,
                    Nhom2_5)  VALUES
                 (
				    :ID_Phieu,
                    :TT,
                    :VatTuYTe,
                    :DonVi,
                    :Nhom1_1,
                    :Nhom1_2,
                    :Nhom1_3,
                    :Nhom1_4,
                    :Nhom2_1,
                    :Nhom2_2,
                    :Nhom2_3,
                    :Nhom2_4,
                    :Nhom2_5
                 )";
                if (_VatTuYTeKCB.ID != 0)
                {
                    sql = @"UPDATE VatTuYTeKCB SET 
                    ID_Phieu = :ID_Phieu,
                    TT = :TT,
                    VatTuYTe = :VatTuYTe,
                    DonVi = :DonVi,
                    Nhom1_1 = :Nhom1_1,
                    Nhom1_2 = :Nhom1_2,
                    Nhom1_3 = :Nhom1_3,
                    Nhom1_4 = :Nhom1_4,
                    Nhom2_1 = :Nhom2_1,
                    Nhom2_2 = :Nhom2_2,
                    Nhom2_3 = :Nhom2_3,
                    Nhom2_4 = :Nhom2_4,
                    Nhom2_5 = :Nhom2_5
                    WHERE ID = " + _VatTuYTeKCB.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID_Phieu", _VatTuYTeKCB.ID_Phieu));
                Command.Parameters.Add(new MDB.MDBParameter("TT", _VatTuYTeKCB.TT));
                Command.Parameters.Add(new MDB.MDBParameter("VatTuYTe", _VatTuYTeKCB.VatTuYTe));
                Command.Parameters.Add(new MDB.MDBParameter("DonVi", _VatTuYTeKCB.DonVi));
                Command.Parameters.Add(new MDB.MDBParameter("Nhom1_1", _VatTuYTeKCB.Nhom1_1));
                Command.Parameters.Add(new MDB.MDBParameter("Nhom1_2", _VatTuYTeKCB.Nhom1_2));
                Command.Parameters.Add(new MDB.MDBParameter("Nhom1_3", _VatTuYTeKCB.Nhom1_3));
                Command.Parameters.Add(new MDB.MDBParameter("Nhom1_4", _VatTuYTeKCB.Nhom1_4));
                Command.Parameters.Add(new MDB.MDBParameter("Nhom2_1", _VatTuYTeKCB.Nhom2_1));
                Command.Parameters.Add(new MDB.MDBParameter("Nhom2_2", _VatTuYTeKCB.Nhom2_2));
                Command.Parameters.Add(new MDB.MDBParameter("Nhom2_3", _VatTuYTeKCB.Nhom2_3));
                Command.Parameters.Add(new MDB.MDBParameter("Nhom2_4", _VatTuYTeKCB.Nhom2_4));
                Command.Parameters.Add(new MDB.MDBParameter("Nhom2_5", _VatTuYTeKCB.Nhom2_5));

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
