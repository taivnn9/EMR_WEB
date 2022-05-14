using EMR.KyDienTu;
using Newtonsoft.Json;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuSLDDChoPNMT : ThongTinKy
    {
        public PhieuSLDDChoPNMT()
        {
            TableName = "PhieuSLDDChoPNMT";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PSLDDCPNMT;
            TenMauPhieu = DanhMucPhieu.PSLDDCPNMT.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        public string HoTenBenhNhan { get; set; }
        [MoTaDuLieu("Năm sinh")]
		public string NamSinh { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public string NguoiSangLoc { get; set; }
        public string MaNguoiSangLoc { get; set; }
        public string An2Bua { get; set; }
        public string An3LanRau { get; set; }
        public string Uong1CocSua { get; set; }
        public string TangCan { get; set; }
        public string ThayMetMoi { get; set; }
        public string KhoangCachMangThai { get; set; }
        public string MacBenhTieuDuong { get; set; }
        public string MacChungBiengAn { get; set; }
        public string LuonThieuAn { get; set; }
        public string TongDiem { get; set; }
        public bool[] DanhGiaArray { get; } = new bool[] { false, false, false};
        public string DanhGia
        {
            get
            {
                string temp = "";
                for (int i = 0; i < DanhGiaArray.Length; i++)
                    temp += (DanhGiaArray[i] ? "1" : "0");
                return temp;    
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DanhGiaArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
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
    public class PhieuSLDDChoPNMTFunc
    {
        public const string TableName = "PhieuSLDDChoPNMT";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuSLDDChoPNMT> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuSLDDChoPNMT> list = new List<PhieuSLDDChoPNMT>();
            try
            {
                string sql = @"SELECT * FROM PhieuSLDDChoPNMT where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuSLDDChoPNMT data = new PhieuSLDDChoPNMT();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.HoTenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.NamSinh = XemBenhAn._HanhChinhBenhNhan.NgaySinh?.Year.ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.NguoiSangLoc = DataReader["NguoiSangLoc"].ToString();
                    data.MaNguoiSangLoc = DataReader["MaNguoiSangLoc"].ToString();
                    data.An2Bua = DataReader["An2Bua"].ToString();
                    data.An3LanRau = DataReader["An3LanRau"].ToString();
                    data.Uong1CocSua = DataReader["Uong1CocSua"].ToString();
                    data.TangCan = DataReader["TangCan"].ToString();
                    data.ThayMetMoi = DataReader["ThayMetMoi"].ToString();
                    data.KhoangCachMangThai = DataReader["KhoangCachMangThai"].ToString();
                    data.MacBenhTieuDuong = DataReader["MacBenhTieuDuong"].ToString();
                    data.MacChungBiengAn = DataReader["MacChungBiengAn"].ToString();
                    data.LuonThieuAn = DataReader["LuonThieuAn"].ToString();
                    data.TongDiem = DataReader["TongDiem"].ToString();
                    data.DanhGia = DataReader["DanhGia"].ToString();

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuSLDDChoPNMT bangKe)
        {
            try
            {
                string sql = @"INSERT INTO PhieuSLDDChoPNMT
                (
                    MAQUANLY,
                    ChanDoan,
                    NguoiSangLoc,
                    MaNguoiSangLoc,
                    An2Bua,
                    An3LanRau,
                    Uong1CocSua,
                    TangCan,
                    ThayMetMoi,
                    KhoangCachMangThai,
                    MacBenhTieuDuong,
                    MacChungBiengAn,
                    LuonThieuAn,
                    TongDiem,
                    DanhGia,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :ChanDoan,
                    :NguoiSangLoc,
                    :MaNguoiSangLoc,
                    :An2Bua,
                    :An3LanRau,
                    :Uong1CocSua,
                    :TangCan,
                    :ThayMetMoi,
                    :KhoangCachMangThai,
                    :MacBenhTieuDuong,
                    :MacChungBiengAn,
                    :LuonThieuAn,
                    :TongDiem,
                    :DanhGia,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (bangKe.ID != 0)
                {
                    sql = @"UPDATE PhieuSLDDChoPNMT SET 
                    MAQUANLY = :MAQUANLY,
                    ChanDoan = :ChanDoan,
                    NguoiSangLoc = :NguoiSangLoc,
                    MaNguoiSangLoc = :MaNguoiSangLoc,
                    An2Bua = :An2Bua,
                    An3LanRau = :An3LanRau,
                    Uong1CocSua = :Uong1CocSua,
                    TangCan = :TangCan,
                    ThayMetMoi = :ThayMetMoi,
                    KhoangCachMangThai = :KhoangCachMangThai,
                    MacBenhTieuDuong = :MacBenhTieuDuong,
                    MacChungBiengAn = :MacChungBiengAn,
                    LuonThieuAn = :LuonThieuAn,
                    TongDiem = :TongDiem,
                    DanhGia = :DanhGia,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + bangKe.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangKe.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", bangKe.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiSangLoc", bangKe.NguoiSangLoc));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiSangLoc", bangKe.MaNguoiSangLoc));
                Command.Parameters.Add(new MDB.MDBParameter("An2Bua", bangKe.An2Bua));
                Command.Parameters.Add(new MDB.MDBParameter("An3LanRau", bangKe.An3LanRau));
                Command.Parameters.Add(new MDB.MDBParameter("Uong1CocSua", bangKe.Uong1CocSua));
                Command.Parameters.Add(new MDB.MDBParameter("TangCan", bangKe.TangCan));
                Command.Parameters.Add(new MDB.MDBParameter("ThayMetMoi", bangKe.ThayMetMoi));
                Command.Parameters.Add(new MDB.MDBParameter("KhoangCachMangThai", bangKe.KhoangCachMangThai));
                Command.Parameters.Add(new MDB.MDBParameter("MacBenhTieuDuong", bangKe.MacBenhTieuDuong));
                Command.Parameters.Add(new MDB.MDBParameter("MacChungBiengAn", bangKe.MacChungBiengAn));
                Command.Parameters.Add(new MDB.MDBParameter("LuonThieuAn", bangKe.LuonThieuAn));
                Command.Parameters.Add(new MDB.MDBParameter("TongDiem", bangKe.TongDiem));
                Command.Parameters.Add(new MDB.MDBParameter("DanhGia", bangKe.DanhGia));

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", bangKe.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", bangKe.NgaySua));
                if (bangKe.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", bangKe.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", bangKe.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", bangKe.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (bangKe.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    bangKe.ID = nextval;
                }
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
                string sql = "DELETE FROM PhieuSLDDChoPNMT WHERE ID = :ID";
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
                *
            FROM
                PhieuSLDDChoPNMT B
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);

            var ds = new DataSet();

            adt.Fill(ds, "TB");
            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("NamSinh", typeof(string));
            ds.Tables[0].AddColumn("MaBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("Khoa", typeof(string));
            ds.Tables[0].AddColumn("SoYTe", typeof(string));
            ds.Tables[0].AddColumn("BenhVien", typeof(string));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["NamSinh"] = XemBenhAn._HanhChinhBenhNhan.NgaySinh?.Year.ToString();
            ds.Tables[0].Rows[0]["MaBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.MaBenhNhan;
            ds.Tables[0].Rows[0]["Khoa"] = XemBenhAn._ThongTinDieuTri.Khoa;
            ds.Tables[0].Rows[0]["SoYTe"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BenhVien"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;

            return ds;

        }
    }
}
