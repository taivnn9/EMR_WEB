
using EMR.KyDienTu;
using Newtonsoft.Json;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class MauPhieuPTSDThuoc : ThongTinKy
    {
        public MauPhieuPTSDThuoc()
        {
            TableName = "MauPhieuPTSDThuoc";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.MPPTSDT;
            TenMauPhieu = DanhMucPhieu.MPPTSDT.Description();
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
        
        public string MaNguoiCongTac { get; set; }
        public string NguoiCongTac { get; set; }
        public string MaNguoiKeDon { get; set; }
        public string NguoiKeDon { get; set; }

        public ObservableCollection<MauPhanTichThuoc> ListPhanTich { get; set; }

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

    public class MauPhanTichThuoc
    {
        public DateTime? Ngay { get; set; }
        public string LanCanThiep { get; set; }
        public string VanDeLienQuan { get; set; }
        public string YKienNguoiCongTac { get; set; }
        public string YKienNguoiKeDon_Text { get; set; }
        public int YKienNguoiKeDon1 { get; set; }
        public int YKienNguoiKeDon2 { get; set; }
    }
    public class MauPhieuPTSDThuocFunc
    {
        public const string TableName = "MauPhieuPTSDThuoc";
        public const string TablePrimaryKeyName = "ID";

        public static List<MauPhieuPTSDThuoc> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<MauPhieuPTSDThuoc> list = new List<MauPhieuPTSDThuoc>();
            try
            {
                string sql = @"SELECT * FROM MauPhieuPTSDThuoc where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    MauPhieuPTSDThuoc data = new MauPhieuPTSDThuoc();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;

                    data.MaBenhNhan = XemBenhAn._HanhChinhBenhNhan.MaBenhNhan;
                    data.HoTenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.NguoiCongTac = DataReader["NguoiCongTac"].ToString();
                    data.NguoiKeDon = DataReader["NguoiKeDon"].ToString();
                    data.MaNguoiCongTac = DataReader["MaNguoiCongTac"].ToString();
                    data.MaNguoiKeDon = DataReader["MaNguoiKeDon"].ToString();
                    
                    data.ListPhanTich = JsonConvert.DeserializeObject<ObservableCollection<MauPhanTichThuoc>>(DataReader["ListPhanTich"].ToString());

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
                sql = @"DELETE FROM MauPhieuPTSDThuoc WHERE ID =" + IDBienBan;
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
                MauPhieuPTSDThuoc P
            WHERE
                ID = " + IDBienBan;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "TB");
            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(string));
            ds.Tables[0].AddColumn("Khoa", typeof(string));
            ds.Tables[0].AddColumn("BenhVien", typeof(string));
            ds.Tables[0].AddColumn("MaBenhAn", typeof(string));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            ds.Tables[0].Rows[0]["Khoa"] = XemBenhAn._ThongTinDieuTri.Khoa;
            ds.Tables[0].Rows[0]["BenhVien"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["MaBenhAn"] = XemBenhAn._ThongTinDieuTri.MaBenhAn;

            ObservableCollection<MauPhanTichThuoc> ListPhanTich = JsonConvert.DeserializeObject<ObservableCollection<MauPhanTichThuoc>>(ds.Tables[0].Rows[0]["ListPhanTich"].ToString());

            DataTable PT = Common.ListToDataTable(ListPhanTich, "PT");
            
            ds.Tables.Add(PT);

            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref MauPhieuPTSDThuoc ketQua)
        {
            try
            {
                string sql = @"INSERT INTO MauPhieuPTSDThuoc
                (
                    MaQuanLy,
                    NguoiCongTac,
                    MaNguoiCongTac,
                    NguoiKeDon,
                    MaNguoiKeDon,
                    ListPhanTich,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
                    :NguoiCongTac,
                    :MaNguoiCongTac,
                    :NguoiKeDon,
                    :MaNguoiKeDon,
                    :ListPhanTich,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE MauPhieuPTSDThuoc SET 
                    MaQuanLy = :MaQuanLy,
                    NguoiCongTac = :NguoiCongTac,
                    MaNguoiCongTac = :MaNguoiCongTac,
                    NguoiKeDon = :NguoiKeDon,
                    MaNguoiKeDon = :MaNguoiKeDon,
                    ListPhanTich = :ListPhanTich,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", ketQua.MaQuanLy));

                Command.Parameters.Add(new MDB.MDBParameter("NguoiKeDon", ketQua.NguoiKeDon));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiKeDon", ketQua.MaNguoiKeDon));
                Command.Parameters.Add(new MDB.MDBParameter("ListPhanTich", JsonConvert.SerializeObject(ketQua.ListPhanTich)));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiCongTac", ketQua.MaNguoiCongTac));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiCongTac", ketQua.NguoiCongTac));

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
