using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuTheoDoiThucHienLocMangBung : ThongTinKy
    {
        public PhieuTheoDoiThucHienLocMangBung()
        {
            TableName = "PhieuTDTHLocMangBung";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PTDTHLMB;
            TenMauPhieu = DanhMucPhieu.PTDTHLMB.Description();
        }
        [MoTaDuLieu("Mã định danh")]
        public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau", "", 1)]
        public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
        public string MaBenhNhan { get; set; }
        public string HoTenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
        public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
        public string GioiTinh { get; set; }
        public string SoGiuong { get; set; }
        public string Buong { get; set; }
        public string ChanDoan { get; set; }
        public ObservableCollection<PhieuTheoDoiThucHienLocMangBung_ChiTiet> ChiTiets { get; set; }
        // bắt buộc
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
    public class PhieuTheoDoiThucHienLocMangBung_ChiTiet
    {
        public long ID { get; set; }
        public long ID_Phieu { get; set; }
        public DateTime? NgayThang { get; set; }
        public string TenDich { get; set; }
        public DateTime? Gio { get; set; }
        public string DichVao { get; set; }
        public string DichRa { get; set; }
        public string MauSacDich { get; set; }
        public string BSChiDinh { get; set; }
        public string YTaThucHien { get; set; }
    }
    public class PhieuTheoDoiThucHienLocMangBungFunc
    {
        public const string TableName = "PhieuTDTHLocMangBung";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuTheoDoiThucHienLocMangBung> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuTheoDoiThucHienLocMangBung> list = new List<PhieuTheoDoiThucHienLocMangBung>();
            try
            {
                string sql = @"SELECT * FROM PhieuTDTHLocMangBung where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuTheoDoiThucHienLocMangBung data = new PhieuTheoDoiThucHienLocMangBung();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.HoTenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.SoGiuong = DataReader["SoGiuong"].ToString();
                    data.Buong = DataReader["Buong"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.ChiTiets = GetChiTiet(_OracleConnection, data.ID);
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
        public static ObservableCollection<PhieuTheoDoiThucHienLocMangBung_ChiTiet> GetChiTiet(MDB.MDBConnection _OracleConnection, long ID_Phieu)
        {
            ObservableCollection<PhieuTheoDoiThucHienLocMangBung_ChiTiet> chiTiets = new ObservableCollection<PhieuTheoDoiThucHienLocMangBung_ChiTiet>();
            try
            {
                string sql = @"SELECT * FROM PhieuTDTHLocMangBung_CT where ID_Phieu = :ID_Phieu";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID_Phieu", ID_Phieu));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuTheoDoiThucHienLocMangBung_ChiTiet data = new PhieuTheoDoiThucHienLocMangBung_ChiTiet();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.ID_Phieu = ID_Phieu;
                    data.NgayThang = DataReader["NgayThang"] != DBNull.Value ? (DateTime?) Convert.ToDateTime(DataReader["NgayThang"].ToString()): null;
                    data.TenDich = DataReader["TenDich"].ToString();
                    data.Gio = DataReader["Gio"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["Gio"].ToString()) : null;
                    data.DichVao = DataReader["DichVao"].ToString();
                    data.DichRa = DataReader["DichRa"].ToString();
                    data.MauSacDich = DataReader["MauSacDich"].ToString();
                    data.BSChiDinh = DataReader["BSChiDinh"].ToString();
                    data.YTaThucHien = DataReader["YTaThucHien"].ToString();
                    chiTiets.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return chiTiets;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuTheoDoiThucHienLocMangBung ketQua)
        {
            try
            {
                string sql = @"INSERT INTO PhieuTDTHLocMangBung
                (
                    MAQUANLY,
                    MaBenhNhan,
                    SoGiuong,
                    Buong,
                    ChanDoan,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :SoGiuong,
                    :Buong,
                    :ChanDoan,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE PhieuTDTHLocMangBung SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    SoGiuong = :SoGiuong,
                    Buong = :Buong,
                    ChanDoan = :ChanDoan,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ketQua.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("SoGiuong", ketQua.SoGiuong));
                Command.Parameters.Add(new MDB.MDBParameter("Buong", ketQua.Buong));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", ketQua.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));
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
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool InsertOrUpdate_ChiTiet(MDB.MDBConnection MyConnection, PhieuTheoDoiThucHienLocMangBung_ChiTiet ketQua)
        {
            try
            {
                string sql = @"INSERT INTO PhieuTDTHLocMangBung_CT
                (
                    ID_Phieu,
                    NgayThang,
                    TenDich,
                    Gio,
                    DichVao,
                    DichRa,
                    MauSacDich,
                    BSChiDinh,
                    YTaThucHien)  VALUES
                 (
				    :ID_Phieu,
                    :NgayThang,
                    :TenDich,
                    :Gio,
                    :DichVao,
                    :DichRa,
                    :MauSacDich,
                    :BSChiDinh,
                    :YTaThucHien
                 ) ";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE PhieuTDTHLocMangBung_CT SET 
                    ID_Phieu = :ID_Phieu,
                    NgayThang = :NgayThang,
                    TenDich = :TenDich,
                    Gio = :Gio,
                    DichVao = :DichVao,
                    DichRa = :DichRa,
                    MauSacDich = :MauSacDich,
                    BSChiDinh = :BSChiDinh,
                    YTaThucHien = :YTaThucHien 
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID_Phieu", ketQua.ID_Phieu));
                Command.Parameters.Add(new MDB.MDBParameter("NgayThang", ketQua.NgayThang));
                Command.Parameters.Add(new MDB.MDBParameter("TenDich", ketQua.TenDich));
                Command.Parameters.Add(new MDB.MDBParameter("Gio", ketQua.Gio));
                Command.Parameters.Add(new MDB.MDBParameter("DichVao", ketQua.DichVao));
                Command.Parameters.Add(new MDB.MDBParameter("DichRa", ketQua.DichRa));
                Command.Parameters.Add(new MDB.MDBParameter("MauSacDich", ketQua.MauSacDich));
                Command.Parameters.Add(new MDB.MDBParameter("BSChiDinh", ketQua.BSChiDinh));
                Command.Parameters.Add(new MDB.MDBParameter("YTaThucHien", ketQua.YTaThucHien));
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
        public static bool delete(MDB.MDBConnection MyConnection, long id)
        {
            try
            {
                string sql = "DELETE FROM PhieuTDTHLocMangBung WHERE ID = :ID";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                command.Parameters.Add(new MDB.MDBParameter("ID", id));
                command.BindByName = true;
                int n = command.ExecuteNonQuery();
                if(n > 0)
                {
                    sql = "DELETE FROM PhieuTDTHLocMangBung_CT WHERE ID_Phieu = :ID_Phieu";
                    command = new MDB.MDBCommand(sql, MyConnection);
                    command.Parameters.Add(new MDB.MDBParameter("ID_Phieu", id));
                    command.BindByName = true;
                    n = command.ExecuteNonQuery();
                }
               
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool delete_ChiTiet(MDB.MDBConnection MyConnection, long id)
        {
            try
            {
                string sql = "DELETE FROM PhieuTDTHLocMangBung_CT WHERE ID = :ID";
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
                P.*, 
                H.SoYTe,
                H.BenhVien,
                H.TenBenhNhan,
                H.Tuoi,
                H.GioiTinh,
                T.Khoa,
                T.SoNhapVien 
            FROM
                PhieuTDTHLocMangBung P
            LEFT JOIN HANHCHINHBENHNHAN H ON P.MABENHNHAN = H.MABENHNHAN
            LEFT JOIN THONGTINDIEUTRI T ON P.MAQUANLY = T.MAQUANLY
            WHERE
                P.ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "KQ");
            ObservableCollection<PhieuTheoDoiThucHienLocMangBung_ChiTiet> lstChiTiet = GetChiTiet(MyConnection, id);
            DataTable ChiTiet = Common.ListToDataTable(lstChiTiet.ToList(), "CT");
            ds.Tables.Add(ChiTiet);
            return ds;
        }
    }
}
