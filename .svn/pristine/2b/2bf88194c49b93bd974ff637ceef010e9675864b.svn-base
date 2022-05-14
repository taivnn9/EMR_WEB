using EMR.KyDienTu;
using Newtonsoft.Json;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace EMR_MAIN.DATABASE.Other
{
    public class BienBanTongHopThuocHuy : ThongTinKy
    {
        public BienBanTongHopThuocHuy()
        {
            TableName = "BienBanTongHopThuocHuy";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BBTHTH;
            TenMauPhieu = DanhMucPhieu.BBTHTH.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")] 
        public string HoVaTen { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Số hồ sơ bệnh án")]
        public string SoHSBA { get; set; }
        [MoTaDuLieu("Thời gian")]
        public DateTime ThoiGian { get; set; }
        [MoTaDuLieu("Trưởng khpa dược")]
        public string TruongKhoaDuoc { get; set; }
        [MoTaDuLieu("Mã trưởng khoa dược")]
        public string MaTruongKhoaDuoc { get; set; }
        [MoTaDuLieu("Người nhận")]
        public string NguoiNhan { get; set; }
        [MoTaDuLieu("Mã người nhận")]
        public string MaNguoiNhan { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng phụ trách")]
		public string DieuDuongPhuTrach { get; set; }
        [MoTaDuLieu("Mã điều dưỡng phụ trách")]
		public string MaDieuDuongPhuTrach { get; set; }
        [MoTaDuLieu("Trưởng khoa phụ trách")]
		public string TruongKhoa { get; set; }
        [MoTaDuLieu("Mã trưởng khoa phụ trách")]
		public string MaTruongKhoa { get; set; }
        [MoTaDuLieu("Bảng chi tiết thuốc bị huỷ")]
        public List<BienBanTongHopThuocHuy_ChiTiet> ChiTiets { get; set; }

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
    public class BienBanTongHopThuocHuy_ChiTiet
    {
        [MoTaDuLieu("Mã định danh thuốc")]
		public int IDThuoc { get; set; }
        [MoTaDuLieu("Số lượng thuốc huỷ")]
        public decimal SoLuongThuocHuy { get; set; }
        [MoTaDuLieu("Ngày huỷ")]
        public DateTime NgayHuy { get; set; }
        [MoTaDuLieu("Ký xác nhận")]
        public string KyXacNhan { get; set; }
    }
    public class BienBanTongHopThuocHuyFunc
    {
        public const string TableName = "BienBanTongHopThuocHuy";
        public const string TablePrimaryKeyName = "ID";
        public static List<BienBanTongHopThuocHuy> GetListData_Phieu(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BienBanTongHopThuocHuy> list = new List<BienBanTongHopThuocHuy>();
            try
            {
                string sql = @"SELECT * FROM BienBanTongHopThuocHuy where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    BienBanTongHopThuocHuy data = new BienBanTongHopThuocHuy();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.HoVaTen = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    //data.SoHSBA = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();

                    data.ThoiGian = Common.ConDB_DateTime(DataReader["ThoiGian"]);
                    data.TruongKhoaDuoc = DataReader["TruongKhoaDuoc"].ToString();
                    data.MaTruongKhoaDuoc = DataReader["MaTruongKhoaDuoc"].ToString();
                    data.NguoiNhan = DataReader["NguoiNhan"].ToString();
                    data.MaNguoiNhan = DataReader["MaNguoiNhan"].ToString();
                    data.DieuDuongPhuTrach = DataReader["DieuDuongPhuTrach"].ToString();
                    data.MaDieuDuongPhuTrach = DataReader["MaDieuDuongPhuTrach"].ToString();
                    data.TruongKhoa = DataReader["TruongKhoa"].ToString();
                    data.MaTruongKhoa = DataReader["MaTruongKhoa"].ToString();
                    object chiTiet = DataReader["ChiTiets"];
                    if (chiTiet != null && chiTiet.ToString() != string.Empty)
                        data.ChiTiets = JsonConvert.DeserializeObject<List<BienBanTongHopThuocHuy_ChiTiet>>(chiTiet.ToString());
                    else
                        data.ChiTiets = new List<BienBanTongHopThuocHuy_ChiTiet>();

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
        public static bool InsertOrUpdate_Phieu(MDB.MDBConnection MyConnection, ref BienBanTongHopThuocHuy data)
        {
            try
            {
                string sql = @"INSERT INTO BienBanTongHopThuocHuy
                (
                    MAQUANLY,
                    MaBenhNhan,
                    ThoiGian,
                    TruongKhoaDuoc,
                    MaTruongKhoaDuoc,
                    NguoiNhan,
                    MaNguoiNhan,
                    DieuDuongPhuTrach,
                    MaDieuDuongPhuTrach,
                    TruongKhoa,
                    MaTruongKhoa,
                    ChiTiets,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :ThoiGian,
                    :TruongKhoaDuoc,
                    :MaTruongKhoaDuoc,
                    :NguoiNhan,
                    :MaNguoiNhan,
                    :DieuDuongPhuTrach,
                    :MaDieuDuongPhuTrach,
                    :TruongKhoa,
                    :MaTruongKhoa,
                    :ChiTiets,                    
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (data.ID != 0)
                {
                    sql = @"UPDATE BienBanTongHopThuocHuy SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan=:MaBenhNhan,
                    ThoiGian=:ThoiGian,
                    TruongKhoaDuoc=:TruongKhoaDuoc,
                    MaTruongKhoaDuoc=:MaTruongKhoaDuoc,
                    NguoiNhan=:NguoiNhan,
                    MaNguoiNhan=:MaNguoiNhan,
                    DieuDuongPhuTrach=:DieuDuongPhuTrach,
                    MaDieuDuongPhuTrach=:MaDieuDuongPhuTrach,
                    TruongKhoa=:TruongKhoa,
                    MaTruongKhoa=:MaTruongKhoa,
                    ChiTiets=:ChiTiets,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + data.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", data.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", data.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGian", data.ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("TruongKhoaDuoc", data.TruongKhoaDuoc));
                Command.Parameters.Add(new MDB.MDBParameter("MaTruongKhoaDuoc", data.MaTruongKhoaDuoc));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiNhan", data.NguoiNhan));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiNhan", data.MaNguoiNhan));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuongPhuTrach", data.DieuDuongPhuTrach));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuongPhuTrach", data.MaDieuDuongPhuTrach));
                Command.Parameters.Add(new MDB.MDBParameter("TruongKhoa", data.TruongKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaTruongKhoa", data.MaTruongKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("ChiTiets", JsonConvert.SerializeObject(data.ChiTiets)));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", data.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", data.NgaySua));
                if (data.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", data.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", data.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", data.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (data.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    data.ID = nextval;
                }
                return n > 0;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool Delete_Phieu(MDB.MDBConnection MyConnection, long id)
        {
            try
            {

                string sql = "DELETE FROM BienBanTongHopThuocHuy WHERE ID = :ID";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                command.Parameters.Add(new MDB.MDBParameter("ID", id));
                command.BindByName = true;
                return command.ExecuteNonQuery() > 0;
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
                B.*
            FROM
                BienBanTongHopThuocHuy B
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "KH");

            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("MaBenhAn", typeof(string));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));
            ds.Tables[0].AddColumn("NamSinh", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(string));
            ds.Tables[0].AddColumn("SOYTE", typeof(string));
            ds.Tables[0].AddColumn("BENHVIEN", typeof(string));
            ds.Tables[0].AddColumn("KHOA", typeof(string));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["MaBenhAn"] = XemBenhAn._ThongTinDieuTri.MaBenhAn;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["NamSinh"] = XemBenhAn._HanhChinhBenhNhan.NgaySinh.HasValue ? XemBenhAn._HanhChinhBenhNhan.NgaySinh.Value.Year + "" : "";
            ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            ds.Tables[0].Rows[0]["SOYTE"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["KHOA"] = XemBenhAn._ThongTinDieuTri.Khoa;



            sql = @"SELECT
               B.ChiTiets
            FROM
                BienBanTongHopThuocHuy B
                
            WHERE
                ID = " + id;

            Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            List<BienBanTongHopThuocHuy_ChiTiet> saveDatas = new List<BienBanTongHopThuocHuy_ChiTiet>();
            while (DataReader.Read())
            {
                string ChiTiets = DataReader["ChiTiets"].ToString();
                saveDatas = JsonConvert.DeserializeObject<List<BienBanTongHopThuocHuy_ChiTiet>>(ChiTiets).ToList();
                break;
            }



            DataTable ChiTiet = new DataTable("CT");
            ChiTiet.Columns.Add("TenThuoc", typeof(string));
            ChiTiet.Columns.Add("HamLuong", typeof(string));
            ChiTiet.Columns.Add("DonViTinh", typeof(string));
            ChiTiet.Columns.Add("SoLuongThuocHuy", typeof(string));
            ChiTiet.Columns.Add("NgayHuy", typeof(string));
            ChiTiet.Columns.Add("KyXacNhan", typeof(string));
            foreach (BienBanTongHopThuocHuy_ChiTiet ct in saveDatas)
            {
                DsThuocDangSuDung thuoc = GetThuocDangSuDung(ct.IDThuoc);
                ChiTiet.Rows.Add(
                    thuoc.TenThuoc,
                    thuoc.HamLuong,
                    thuoc.DonViTinh,
                    ct.SoLuongThuocHuy,
                    ct.NgayHuy != null ? ct.NgayHuy.ToString("dd/MM/yy") : "",
                    ct.KyXacNhan
                    );
            }
            ds.Tables.Add(ChiTiet);
            return ds;
        }

        private static DsThuocDangSuDung GetThuocDangSuDung(int IDThuoc)
        {
            DsThuocDangSuDung thuoc = XemBenhAn._ThongTinDieuTri.DsThuocDangSuDung.FirstOrDefault(x => x.IDThuoc == IDThuoc);
            return (thuoc != null) ? thuoc : new DsThuocDangSuDung();
        }
    }
}
