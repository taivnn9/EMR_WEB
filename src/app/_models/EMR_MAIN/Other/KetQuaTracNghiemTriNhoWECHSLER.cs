using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMR_MAIN.DATABASE.Other
{
    public class KetQuaTracNghiemTriNhoWECHSLER : ThongTinKy
    {
        public KetQuaTracNghiemTriNhoWECHSLER()
        {
            TableName = "TracNghiemTriNhoWECHSLER";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.KQLTNTNW;
            TenMauPhieu = DanhMucPhieu.KQLTNTNW.Description();
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
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        [MoTaDuLieu("Nghề nghiệp")]
		public string NgheNghiep { get; set; }
        public DateTime NgayLamTest { get; set; }
        public double? ThongTinCaNhan { get; set; }
        public double? DinhHuongChung { get; set; }
        public double? KiemDinhTamLy { get; set; }
        public double? GhiNhoLogic { get; set; }
        public double? TriNhoThinhGiac { get; set; }
        public double? TriNhoThiGiac { get; set; }
        public double? TriNhoLienTuong { get; set; }
        public double? TongKiemTho { get; set; }
        public double? DiemDieuChinh { get; set; }
        public double? ChiSoChiNho { get; set; }
        public string NguoiLamTest { get; set; }
        public string MaNguoiLamTest { get; set; }
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
    public class KetQuaTracNghiemTriNhoWECHSLERFunc
    {
        public const string TableName = "TracNghiemTriNhoWECHSLER";
        public const string TablePrimaryKeyName = "ID";
        public static List<KetQuaTracNghiemTriNhoWECHSLER> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<KetQuaTracNghiemTriNhoWECHSLER> list = new List<KetQuaTracNghiemTriNhoWECHSLER>();
            try
            {
                string sql = @"SELECT * FROM TracNghiemTriNhoWECHSLER where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    KetQuaTracNghiemTriNhoWECHSLER data = new KetQuaTracNghiemTriNhoWECHSLER();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.HoTenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.DiaChi = DataReader["DiaChi"].ToString();
                    data.NgheNghiep = DataReader["NgheNghiep"].ToString();
                    double tempDouble = 0;

                    data.NgayLamTest = Convert.ToDateTime(DataReader["NgayLamTest"] == DBNull.Value ? DateTime.Now : DataReader["NgayLamTest"]);

                    data.ThongTinCaNhan = double.TryParse(DataReader["ThongTinCaNhan"].ToString(), out tempDouble) ? (double?)tempDouble : null;
                    
                    tempDouble = 0;
                    data.DinhHuongChung = double.TryParse(DataReader["DinhHuongChung"].ToString(), out tempDouble) ? (double?)tempDouble : null;

                    tempDouble = 0;
                    data.KiemDinhTamLy = double.TryParse(DataReader["KiemDinhTamLy"].ToString(), out tempDouble) ? (double?)tempDouble : null;

                    tempDouble = 0;
                    data.GhiNhoLogic = double.TryParse(DataReader["GhiNhoLogic"].ToString(), out tempDouble) ? (double?)tempDouble : null;

                    tempDouble = 0;
                    data.TriNhoThinhGiac = double.TryParse(DataReader["TriNhoThinhGiac"].ToString(), out tempDouble) ? (double?)tempDouble : null;
                    
                    tempDouble = 0;
                    data.TriNhoThiGiac = double.TryParse(DataReader["TriNhoThiGiac"].ToString(), out tempDouble) ? (double?)tempDouble : null;

                    tempDouble = 0;
                    data.TriNhoLienTuong = double.TryParse(DataReader["TriNhoLienTuong"].ToString(), out tempDouble) ? (double?)tempDouble : null;

                    tempDouble = 0;
                    data.DiemDieuChinh = double.TryParse(DataReader["DiemDieuChinh"].ToString(), out tempDouble) ? (double?)tempDouble : null;

                    tempDouble = 0;
                    data.ChiSoChiNho = double.TryParse(DataReader["ChiSoChiNho"].ToString(), out tempDouble) ? (double?)tempDouble : null;

                    tempDouble = 0;
                    data.TongKiemTho = double.TryParse(DataReader["TongKiemTho"].ToString(), out tempDouble) ? (double?)tempDouble : null;

                    data.NguoiLamTest = DataReader["NguoiLamTest"].ToString();
                    data.MaNguoiLamTest = DataReader["MaNguoiLamTest"].ToString();
                    
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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref KetQuaTracNghiemTriNhoWECHSLER ketQua)
        {
            try
            {
                string sql = @"INSERT INTO TracNghiemTriNhoWECHSLER
                (
                    MAQUANLY,
                    MaBenhNhan,
                    ChanDoan,
                    DiaChi, 
                    NgheNghiep, 
                    NgayLamTest,
                    ThongTinCaNhan,
                    DinhHuongChung, 
                    KiemDinhTamLy,
                    GhiNhoLogic,
                    TriNhoThinhGiac,
                    TriNhoThiGiac,
                    TriNhoLienTuong,
                    TongKiemTho,
                    DiemDieuChinh,
                    ChiSoChiNho,
                    NguoiLamTest,
                    MaNguoiLamTest,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :ChanDoan,
                    :DiaChi, 
                    :NgheNghiep, 
                    :NgayLamTest,
                    :ThongTinCaNhan,
                    :DinhHuongChung, 
                    :KiemDinhTamLy,
                    :GhiNhoLogic,
                    :TriNhoThinhGiac,
                    :TriNhoThiGiac,
                    :TriNhoLienTuong,
                    :TongKiemTho,
                    :DiemDieuChinh,
                    :ChiSoChiNho,
                    :NguoiLamTest,
                    :MaNguoiLamTest,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE TracNghiemTriNhoWECHSLER SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    ChanDoan = :ChanDoan,
                    DiaChi = :DiaChi, 
                    NgheNghiep = :NgheNghiep, 
                    NgayLamTest = :NgayLamTest,
                    ThongTinCaNhan = :ThongTinCaNhan,
                    DinhHuongChung = :DinhHuongChung, 
                    KiemDinhTamLy = :KiemDinhTamLy,
                    GhiNhoLogic = :GhiNhoLogic,
                    TriNhoThinhGiac = :TriNhoThinhGiac,
                    TriNhoThiGiac = :TriNhoThiGiac,
                    TriNhoLienTuong = :TriNhoLienTuong,
                    TongKiemTho = :TongKiemTho,
                    DiemDieuChinh = :DiemDieuChinh,
                    ChiSoChiNho = :ChiSoChiNho,
                    NguoiLamTest = :NguoiLamTest,
                    MaNguoiLamTest = :MaNguoiLamTest,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ketQua.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", ketQua.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", ketQua.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("NgheNghiep", ketQua.NgheNghiep));
                Command.Parameters.Add(new MDB.MDBParameter("NgayLamTest", ketQua.NgayLamTest));
                Command.Parameters.Add(new MDB.MDBParameter("ThongTinCaNhan", ketQua.ThongTinCaNhan));
                Command.Parameters.Add(new MDB.MDBParameter("DinhHuongChung", ketQua.DinhHuongChung));
                Command.Parameters.Add(new MDB.MDBParameter("KiemDinhTamLy", ketQua.KiemDinhTamLy));
                Command.Parameters.Add(new MDB.MDBParameter("GhiNhoLogic", ketQua.GhiNhoLogic));
                Command.Parameters.Add(new MDB.MDBParameter("TriNhoThinhGiac", ketQua.TriNhoThinhGiac));
                Command.Parameters.Add(new MDB.MDBParameter("TriNhoThiGiac", ketQua.TriNhoThiGiac));
                Command.Parameters.Add(new MDB.MDBParameter("TriNhoLienTuong", ketQua.TriNhoLienTuong));
                Command.Parameters.Add(new MDB.MDBParameter("TongKiemTho", ketQua.TongKiemTho));
                Command.Parameters.Add(new MDB.MDBParameter("DiemDieuChinh", ketQua.DiemDieuChinh));
                Command.Parameters.Add(new MDB.MDBParameter("ChiSoChiNho", ketQua.ChiSoChiNho));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiLamTest", ketQua.NguoiLamTest));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiLamTest", ketQua.MaNguoiLamTest));
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
        public static bool delete(MDB.MDBConnection MyConnection, long id)
        {
            try
            {
                string sql = "DELETE FROM TracNghiemTriNhoWECHSLER WHERE ID = :ID";
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
                P.* 
            FROM
                TracNghiemTriNhoWECHSLER P
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "KQ");

            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(int));
            ds.Tables[0].AddColumn("SOYTE", typeof(string));
            ds.Tables[0].AddColumn("BENHVIEN", typeof(string));
            ds.Tables[0].AddColumn("KHOA", typeof(string));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["GioiTinh"] = (int)XemBenhAn._HanhChinhBenhNhan.GioiTinh;
            ds.Tables[0].Rows[0]["SOYTE"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["KHOA"] = XemBenhAn._ThongTinDieuTri.Khoa;

            return ds;
        }
    }
}
