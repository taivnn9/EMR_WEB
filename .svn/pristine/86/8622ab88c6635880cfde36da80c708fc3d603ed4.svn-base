using EMR.KyDienTu;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuDichVuKyThuatChiTiet
    {
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã định danh")]
		public long ID_Phieu { get; set; }
        [MoTaDuLieu("Ngày tháng")]
		public DateTime NgayThang { get; set; }
        public string TenDVKTTT { get; set; }
        [MoTaDuLieu("Ghi chú")]
		public string GhiChu { get; set; }
        [MoTaDuLieu("Mã người thực hiện")]
		public string MaNguoiThucHien { get; set; }
        [MoTaDuLieu("Người thực hiện")]
		public string NguoiThucHien { get; set; }
    }
    public class PhieuDichVuKyThuat : ThongTinKy
    {
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public ObservableCollection<PhieuDichVuKyThuatChiTiet> ChiTiet { get; set; }
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
        //public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
    }
    public class PhieuDichVuKyThuatFunc
    {
        public const string TableName = "PhieuDichVuKTTT";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuDichVuKyThuat> Select_Phieu(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            List<PhieuDichVuKyThuat> listResult = new List<PhieuDichVuKyThuat>();
            try
            {
                string sql = @"SELECT *
                                FROM PhieuDichVuKTTT
                                WHERE MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    var data = new PhieuDichVuKyThuat();
                    data.ID = DataReader.GetLong("ID");
                    data.MaQuanLy = MaQuanLy;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();

                    data.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                    data.NguoiTao = DataReader["NguoiTao"].ToString();
                    data.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);
                    data.NguoiSua = DataReader["NguoiSua"].ToString();
                    data.ChiTiet = Select_ChiTiet(MyConnection, data.ID);
                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;
                    listResult.Add(data);
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return listResult;
        }
        public static ObservableCollection<PhieuDichVuKyThuatChiTiet> Select_ChiTiet(MDB.MDBConnection MyConnection, long ID_Phieu)
        {
            ObservableCollection<PhieuDichVuKyThuatChiTiet> listResult = new ObservableCollection<PhieuDichVuKyThuatChiTiet>();
            try
            {
                string sql = @"SELECT *
                                FROM PhieuDichVuKTTT_ChiTiet
                                WHERE ID_Phieu = :ID_Phieu";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID_Phieu", ID_Phieu));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    var data = new PhieuDichVuKyThuatChiTiet();
                    data.ID = DataReader.GetLong("ID");
                    data.ID_Phieu = ID_Phieu;
                    data.NgayThang = Convert.ToDateTime(DataReader["NgayThang"] == DBNull.Value ? DateTime.Now : DataReader["NgayThang"]);
                    data.TenDVKTTT = DataReader["TenDVKTTT"].ToString();
                    data.NguoiThucHien = DataReader["NguoiThucHien"].ToString();
                    data.MaNguoiThucHien = DataReader["MaNguoiThucHien"].ToString();
                    data.GhiChu = DataReader["GhiChu"].ToString();
                    listResult.Add(data);
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return listResult;
        }
        public static bool InsertOrUpdate_Phieu(MDB.MDBConnection MyConnection, ref PhieuDichVuKyThuat phieuDichVu)
        {
            try
            {
                string sql = @"INSERT INTO PhieuDichVuKTTT
                (
                    MAQUANLY,
                    MaBenhNhan,
                    ChanDoan,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :ChanDoan,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (phieuDichVu.ID != 0)
                {
                    sql = @"UPDATE PhieuDichVuKTTT SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    ChanDoan = :ChanDoan,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + phieuDichVu.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", phieuDichVu.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", phieuDichVu.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", phieuDichVu.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", phieuDichVu.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", phieuDichVu.NgaySua));
                if (phieuDichVu.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", phieuDichVu.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", phieuDichVu.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", phieuDichVu.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (phieuDichVu.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    phieuDichVu.ID = nextval;
                }
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool InsertOrUpdate_ChiTiet(MDB.MDBConnection MyConnection, PhieuDichVuKyThuatChiTiet phieuDichVu)
        {
            try
            {
                string sql = @"INSERT INTO PhieuDichVuKTTT_ChiTiet
                (
                    ID_Phieu,
                    NgayThang,
                    TenDVKTTT,
                    NguoiThucHien,
                    MaNguoiThucHien,
                    GhiChu
                )  VALUES
                 (
				    :ID_Phieu,
                    :NgayThang,
                    :TenDVKTTT,
                    :NguoiThucHien,
                    :MaNguoiThucHien,
                    :GhiChu
                 )";
                if (phieuDichVu.ID != 0)
                {
                    sql = @"UPDATE PhieuDichVuKTTT_ChiTiet SET 
                    ID_Phieu = :ID_Phieu,
                    NgayThang = :NgayThang,
                    TenDVKTTT = :TenDVKTTT,
                    NguoiThucHien = :NguoiThucHien,
                    MaNguoiThucHien = :MaNguoiThucHien,
                    GhiChu = :GhiChu
                    WHERE ID = " + phieuDichVu.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID_Phieu", phieuDichVu.ID_Phieu));
                Command.Parameters.Add(new MDB.MDBParameter("NgayThang", phieuDichVu.NgayThang));
                Command.Parameters.Add(new MDB.MDBParameter("TenDVKTTT", phieuDichVu.TenDVKTTT));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiThucHien", phieuDichVu.NguoiThucHien));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiThucHien", phieuDichVu.MaNguoiThucHien));
                Command.Parameters.Add(new MDB.MDBParameter("GhiChu", phieuDichVu.GhiChu));
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
        public static bool Delete_Phieu(MDB.MDBConnection MyConnection, long IDPhieuDichVuKyThuat)
        {
            try
            {
                if (IDPhieuDichVuKyThuat != 0)
                {
                    string sql = @"DELETE FROM PhieuDichVuKTTT WHERE ID = :ID";
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter(":ID", IDPhieuDichVuKyThuat));
                    int n = Command.ExecuteNonQuery();
                    return n > 0 ? true : false;
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool Delete_ChiTiet(MDB.MDBConnection MyConnection, long ID)
        {
            try
            {
                if (ID != 0)
                {
                    string sql = @"DELETE FROM PhieuDichVuKTTT_ChiTiet WHERE ID = :ID";
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter(":ID", ID));
                    int n = Command.ExecuteNonQuery();
                    return n > 0 ? true : false;
                }
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
                B.*,
                T.MABENHAN,
                T.KHOA,
	            H.TENBENHNHAN,
                H.TUOI,
                H.TENNOIDANGKYBHYT,
                H.SOYTE,
                H.BENHVIEN
            FROM
                PhieuDichVuKTTT B
                LEFT JOIN THONGTINDIEUTRI T ON B.MAQUANLY = T.MAQUANLY
                LEFT JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
            WHERE
                B.ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            adt.Fill(ds, "PDV");
            ObservableCollection<PhieuDichVuKyThuatChiTiet> lstPhieuChiTiet = Select_ChiTiet(MyConnection, id);
            DataTable ChiTiets = new DataTable("CT");
            ChiTiets.Columns.Add("NgayThang");
            ChiTiets.Columns.Add("TenDVKTTT");
            ChiTiets.Columns.Add("NguoiThucHien");
            ChiTiets.Columns.Add("GhiChu");
            foreach (PhieuDichVuKyThuatChiTiet p in lstPhieuChiTiet)
            {
                ChiTiets.Rows.Add(p.NgayThang.ToString("dd/MM/yyyy"), p.TenDVKTTT, p.NguoiThucHien, p.GhiChu);
            }
            ds.Tables.Add(ChiTiets);
            return ds;
        }
    }
}