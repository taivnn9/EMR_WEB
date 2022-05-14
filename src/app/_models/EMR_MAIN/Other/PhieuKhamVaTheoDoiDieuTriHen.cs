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
    public class PhieuKhamVaTheoDoiDieuTriHen : ThongTinKy
    {
        public PhieuKhamVaTheoDoiDieuTriHen()
        {
            TableName = "PKVaTDDieuTriHen";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PKVTDDTH;
            TenMauPhieu = DanhMucPhieu.PKVTDDTH.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        public DateTime? NgayKham { get; set; }
        public int? LanKhamThu { get; set; }
        [MoTaDuLieu("Mã bệnh án")]
		public string MaBenhAn { get; set; }
        public double? DiemACT { get; set; }
        public bool[] KSArray { get; } = new bool[] { false, false, false };
        public int KS
        {
            get
            {
                return Array.IndexOf(KSArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 3; i++)
                {
                    if (i == (value - 1)) KSArray[i] = true;
                    else KSArray[i] = false;
                }
            }
        }
        public int? SDThuocCatConNgay { get; set; }
        public int? SDThuocCatConTuan { get; set; }
        public int? SDThuocCatConThang { get; set; }
        public bool SDThuocCatConKhongDung { get; set; }

        public int? SDThuocDuPhongNgay { get; set; }
        public int? SDThuocDuPhongTuan { get; set; }
        public int? SDThuocDuPhongThang { get; set; }
        public bool SDThuocDuPhongKhongDung { get; set; }

        public double? PEF { get; set; }
        public double? FEV1 { get; set; }
        public double? SpO2 { get; set; }
        public bool[] HieuBietArray { get; } = new bool[] { false, false, false };
        public int HieuBiet
        {
            get
            {
                return Array.IndexOf(HieuBietArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 3; i++)
                {
                    if (i == (value - 1)) HieuBietArray[i] = true;
                    else HieuBietArray[i] = false;
                }
            }
        }
        public string KhamLamSang { get; set; }
        public string GhiChuKhamLamSang { get; set; }
        [MoTaDuLieu("Xử trí")]
        public string XuTri { get; set; }
        [MoTaDuLieu("Ghi chú")]
		public string GhiChu { get; set; }
        [MoTaDuLieu("Bác sỹ khám bệnh")]
        public string BacSyKham { get; set; }
        [MoTaDuLieu("Mã bác sỹ khám bệnh")]
        public string MaBacSyKham { get; set; }

        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }

    }
    public class PhieuKhamVaTheoDoiDieuTriHenFunc
    {
        public const string TableName = "PKVaTDDieuTriHen";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuKhamVaTheoDoiDieuTriHen> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuKhamVaTheoDoiDieuTriHen> list = new List<PhieuKhamVaTheoDoiDieuTriHen>();

            try
            {
                string sql = @"SELECT * FROM PKVaTDDieuTriHen where MaQuanLy = :MaQuanLy ORDER BY NgayTao";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuKhamVaTheoDoiDieuTriHen data = new PhieuKhamVaTheoDoiDieuTriHen();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = DataReader.GetDecimal("MaQuanLy");
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.TenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.MaBenhAn = string.IsNullOrEmpty(DataReader["MaBenhAn"].ToString()) ? XemBenhAn._ThongTinDieuTri.MaBenhAn : DataReader["MaBenhAn"].ToString();

                    data.NgayKham = DataReader["NgayKham"] == DBNull.Value ? null : (DateTime?) DataReader.GetDate("NgayKham");
                    int intTemp = 0;
                    data.LanKhamThu = int.TryParse(DataReader["LanKhamThu"].ToString(), out intTemp) ? (int?)intTemp : null;
                    double doubTemp = 0;
                    data.DiemACT = double.TryParse(DataReader["DiemACT"].ToString(), out doubTemp) ? (double?)doubTemp : null;
                    data.KS = DataReader.GetInt("KS");

                    data.SDThuocCatConNgay = int.TryParse(DataReader["SDThuocCatConNgay"].ToString(), out intTemp) ? (int?)intTemp : null;
                    data.SDThuocCatConTuan = int.TryParse(DataReader["SDThuocCatConTuan"].ToString(), out intTemp) ? (int?)intTemp : null;
                    data.SDThuocCatConThang = int.TryParse(DataReader["SDThuocCatConThang"].ToString(), out intTemp) ? (int?)intTemp : null;
                    data.SDThuocCatConKhongDung = DataReader["SDThuocCatConKhongDung"].ToString().Equals("1") ? true : false;

                    data.SDThuocDuPhongNgay = int.TryParse(DataReader["SDThuocDuPhongNgay"].ToString(), out intTemp) ? (int?)intTemp : null;
                    data.SDThuocDuPhongTuan = int.TryParse(DataReader["SDThuocDuPhongTuan"].ToString(), out intTemp) ? (int?)intTemp : null;
                    data.SDThuocDuPhongThang = int.TryParse(DataReader["SDThuocDuPhongThang"].ToString(), out intTemp) ? (int?)intTemp : null;
                    data.SDThuocDuPhongKhongDung = DataReader["SDThuocDuPhongKhongDung"].ToString().Equals("1") ? true : false;

                    data.PEF = double.TryParse(DataReader["PEF"].ToString(), out doubTemp) ? (double?)doubTemp : null;
                    data.FEV1 = double.TryParse(DataReader["FEV1"].ToString(), out doubTemp) ? (double?)doubTemp : null;
                    data.SpO2 = double.TryParse(DataReader["SpO2"].ToString(), out doubTemp) ? (double?)doubTemp : null;

                    data.HieuBiet = DataReader.GetInt("HieuBiet");
                    data.KhamLamSang = DataReader["KhamLamSang"].ToString();
                    data.GhiChuKhamLamSang = DataReader["GhiChuKhamLamSang"].ToString();
                    data.XuTri = DataReader["XuTri"].ToString();
                    data.GhiChu = DataReader["GhiChu"].ToString();
                    data.BacSyKham = DataReader["BacSyKham"].ToString();
                    data.MaBacSyKham = DataReader["MaBacSyKham"].ToString();

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuKhamVaTheoDoiDieuTriHen phieuKham)
        {
            try
            {
                string sql = @"INSERT INTO PKVaTDDieuTriHen
                (
                    MAQUANLY,
                    MaBenhNhan,
                    MaBenhAn,
                    NgayKham,
                    LanKhamThu,
                    DiemACT,
                    KS,
                    SDThuocCatConNgay,
                    SDThuocCatConTuan,
                    SDThuocCatConThang,
                    SDThuocCatConKhongDung,
                    SDThuocDuPhongNgay,
                    SDThuocDuPhongTuan,
                    SDThuocDuPhongThang,
                    SDThuocDuPhongKhongDung,
                    PEF,
                    FEV1,
                    SpO2,
                    HieuBiet,
                    KhamLamSang,
                    GhiChuKhamLamSang,
                    XuTri,
                    GhiChu,
                    BacSyKham,
                    MaBacSyKham,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :MaBenhAn,
                    :NgayKham,
                    :LanKhamThu,
                    :DiemACT,
                    :KS,
                    :SDThuocCatConNgay,
                    :SDThuocCatConTuan,
                    :SDThuocCatConThang,
                    :SDThuocCatConKhongDung,
                    :SDThuocDuPhongNgay,
                    :SDThuocDuPhongTuan,
                    :SDThuocDuPhongThang,
                    :SDThuocDuPhongKhongDung,
                    :PEF,
                    :FEV1,
                    :SpO2,
                    :HieuBiet,
                    :KhamLamSang,
                    :GhiChuKhamLamSang,
                    :XuTri,
                    :GhiChu,
                    :BacSyKham,
                    :MaBacSyKham,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (phieuKham.ID != 0)
                {
                    sql = @"UPDATE PKVaTDDieuTriHen SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    MaBenhAn = :MaBenhAn,
                    NgayKham = :NgayKham,
                    LanKhamThu = :LanKhamThu,
                    DiemACT = :DiemACT,
                    KS = :KS,
                    SDThuocCatConNgay = :SDThuocCatConNgay,
                    SDThuocCatConTuan = :SDThuocCatConTuan,
                    SDThuocCatConThang = :SDThuocCatConThang,
                    SDThuocCatConKhongDung = :SDThuocCatConKhongDung,
                    SDThuocDuPhongNgay = :SDThuocDuPhongNgay,
                    SDThuocDuPhongTuan = :SDThuocDuPhongTuan,
                    SDThuocDuPhongThang = :SDThuocDuPhongThang,
                    SDThuocDuPhongKhongDung = :SDThuocDuPhongKhongDung,
                    PEF = :PEF,
                    FEV1 = :FEV1,
                    SpO2 = :SpO2,
                    HieuBiet = :HieuBiet,
                    KhamLamSang = :KhamLamSang,
                    GhiChuKhamLamSang = :GhiChuKhamLamSang,
                    XuTri = :XuTri,
                    GhiChu = :GhiChu,
                    BacSyKham = :BacSyKham,
                    MaBacSyKham = :MaBacSyKham,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + phieuKham.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", phieuKham.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", phieuKham.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhAn", phieuKham.MaBenhAn));
                Command.Parameters.Add(new MDB.MDBParameter("NgayKham", phieuKham.NgayKham));
                Command.Parameters.Add(new MDB.MDBParameter("LanKhamThu", phieuKham.LanKhamThu));
                Command.Parameters.Add(new MDB.MDBParameter("DiemACT", phieuKham.DiemACT));
                Command.Parameters.Add(new MDB.MDBParameter("KS", phieuKham.KS));
                Command.Parameters.Add(new MDB.MDBParameter("SDThuocCatConNgay", phieuKham.SDThuocCatConNgay));
                Command.Parameters.Add(new MDB.MDBParameter("SDThuocCatConTuan", phieuKham.SDThuocCatConTuan));
                Command.Parameters.Add(new MDB.MDBParameter("SDThuocCatConThang", phieuKham.SDThuocCatConThang));
                Command.Parameters.Add(new MDB.MDBParameter("SDThuocCatConKhongDung", phieuKham.SDThuocCatConKhongDung ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("SDThuocDuPhongNgay", phieuKham.SDThuocDuPhongNgay));
                Command.Parameters.Add(new MDB.MDBParameter("SDThuocDuPhongTuan", phieuKham.SDThuocDuPhongTuan));
                Command.Parameters.Add(new MDB.MDBParameter("SDThuocDuPhongThang", phieuKham.SDThuocDuPhongThang));
                Command.Parameters.Add(new MDB.MDBParameter("SDThuocDuPhongKhongDung", phieuKham.SDThuocDuPhongKhongDung ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("PEF", phieuKham.PEF));
                Command.Parameters.Add(new MDB.MDBParameter("FEV1", phieuKham.FEV1));
                Command.Parameters.Add(new MDB.MDBParameter("SpO2", phieuKham.SpO2));
                Command.Parameters.Add(new MDB.MDBParameter("HieuBiet", phieuKham.HieuBiet));
                Command.Parameters.Add(new MDB.MDBParameter("KhamLamSang", phieuKham.KhamLamSang));
                Command.Parameters.Add(new MDB.MDBParameter("GhiChuKhamLamSang", phieuKham.GhiChuKhamLamSang));
                Command.Parameters.Add(new MDB.MDBParameter("XuTri", phieuKham.XuTri));
                Command.Parameters.Add(new MDB.MDBParameter("GhiChu", phieuKham.GhiChu));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyKham", phieuKham.BacSyKham));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSyKham", phieuKham.MaBacSyKham));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", phieuKham.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", phieuKham.NgaySua));
                if (phieuKham.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", phieuKham.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", phieuKham.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", phieuKham.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (phieuKham.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    phieuKham.ID = nextval;
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
                string sql = "DELETE FROM PKVaTDDieuTriHen WHERE ID = :ID";
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
                B.*
            FROM
                PKVaTDDieuTriHen B
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "BK");

            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("ToSo", typeof(long));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["ToSo"] = id;

            return ds;

        }
    }
}
