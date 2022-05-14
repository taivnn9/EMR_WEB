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
    public class PhieuKhamVaTheoDoiDieuTriCopd : ThongTinKy
    {
        public PhieuKhamVaTheoDoiDieuTriCopd()
        {
            TableName = "PKVaTDDieuTriCopd";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PKVTDDTC;
            TenMauPhieu = DanhMucPhieu.PKVTDDTC.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Mã bệnh án")]
		public string MaBenhAn { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        public DateTime? NgayKham { get; set; }
        public int? LanKhamThu { get; set; }
        public bool[] HoKhacDamArray { get; } = new bool[] { false, false, false, false };
        public int HoKhacDam
        {
            get
            {
                return Array.IndexOf(HoKhacDamArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 4; i++)
                {
                    if (i == (value - 1)) HoKhacDamArray[i] = true;
                    else HoKhacDamArray[i] = false;
                }
            }
        }
        public bool[] MRCArray { get; } = new bool[] { false, false, false, false };
        public int MRC
        {
            get
            {
                return Array.IndexOf(MRCArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 4; i++)
                {
                    if (i == (value - 1)) MRCArray[i] = true;
                    else MRCArray[i] = false;
                }
            }
        }
        public bool[] TriGiacArray { get; } = new bool[] { false, false, false };
        public int TriGiac
        {
            get
            {
                return Array.IndexOf(TriGiacArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 3; i++)
                {
                    if (i == (value - 1)) TriGiacArray[i] = true;
                    else TriGiacArray[i] = false;
                }
            }
        }
        public bool[] AnArray { get; } = new bool[] { false, false };
        public int An
        {
            get
            {
                return Array.IndexOf(AnArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) AnArray[i] = true;
                    else AnArray[i] = false;
                }
            }
        }
        public bool[] NguArray { get; } = new bool[] { false, false };
        public int Ngu
        {
            get
            {
                return Array.IndexOf(NguArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) NguArray[i] = true;
                    else NguArray[i] = false;
                }
            }
        }
        public bool[] GiaiTriArray { get; } = new bool[] { false, false };
        public int GiaiTri
        {
            get
            {
                return Array.IndexOf(GiaiTriArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) GiaiTriArray[i] = true;
                    else GiaiTriArray[i] = false;
                }
            }
        }
        public bool[] TamHoatDongArray { get; } = new bool[] { false, false, false, false };
        public string TamHoatDong
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TamHoatDongArray.Length; i++)
                    temp += (TamHoatDongArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TamHoatDongArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public int? SDThuocCatConNgay { get; set; }
        public int? SDThuocCatConTuan { get; set; }
        public int? SDThuocCatConThang { get; set; }
        public bool SDThuocCatConKhongDung { get; set; }

        public double? Cao { get; set; }
        public double? Nang { get; set; }
        public double? BMI { get; set; }
        public DateTime? NgungHut { get; set; }
        public double? ConHut { get; set; }
        public DateTime? HutLai { get; set; }
        public double? HutLaiSoLuong { get; set; }

        public double? FEV1 { get; set; }
        public double? SpO2 { get; set; }
        public double? KhoangCachDiBo { get; set; }

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
    public class PhieuKhamVaTheoDoiDieuTriCopdFunc
    {
        public const string TableName = "PKVaTDDieuTriCopd";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuKhamVaTheoDoiDieuTriCopd> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuKhamVaTheoDoiDieuTriCopd> list = new List<PhieuKhamVaTheoDoiDieuTriCopd>();

            try
            {
                string sql = @"SELECT * FROM PKVaTDDieuTriCopd where MaQuanLy = :MaQuanLy ORDER BY NgayTao";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuKhamVaTheoDoiDieuTriCopd data = new PhieuKhamVaTheoDoiDieuTriCopd();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = DataReader.GetDecimal("MaQuanLy");
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.TenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.MaBenhAn = string.IsNullOrEmpty(DataReader["MaBenhAn"].ToString()) ? XemBenhAn._ThongTinDieuTri.MaBenhAn : DataReader["MaBenhAn"].ToString();
                    data.NgayKham = DataReader["NgayKham"] == DBNull.Value ? null : (DateTime?) DataReader.GetDate("NgayKham");
                    int intTemp = 0;
                    data.LanKhamThu = int.TryParse(DataReader["LanKhamThu"].ToString(), out intTemp) ? (int?)intTemp : null;
                    data.HoKhacDam = DataReader.GetInt("HoKhacDam");
                    data.MRC = DataReader.GetInt("MRC");
                    data.TriGiac = DataReader.GetInt("TriGiac");
                    data.An = DataReader.GetInt("An");
                    data.Ngu = DataReader.GetInt("Ngu");
                    data.GiaiTri = DataReader.GetInt("GiaiTri");
                    data.TamHoatDong = DataReader["TamHoatDong"].ToString();
                    data.SDThuocCatConNgay = int.TryParse(DataReader["SDThuocCatConNgay"].ToString(), out intTemp) ? (int?)intTemp : null;
                    data.SDThuocCatConTuan = int.TryParse(DataReader["SDThuocCatConTuan"].ToString(), out intTemp) ? (int?)intTemp : null;
                    data.SDThuocCatConThang = int.TryParse(DataReader["SDThuocCatConThang"].ToString(), out intTemp) ? (int?)intTemp : null;
                    data.SDThuocCatConKhongDung = DataReader["SDThuocCatConKhongDung"].ToString().Equals("1") ? true : false;
                    
                    double doubTemp = 0;

                    data.Cao = double.TryParse(DataReader["Cao"].ToString(), out doubTemp) ? (double?)doubTemp : null;
                    data.Nang = double.TryParse(DataReader["Nang"].ToString(), out doubTemp) ? (double?)doubTemp : null;
                    data.BMI = double.TryParse(DataReader["BMI"].ToString(), out doubTemp) ? (double?)doubTemp : null;

                    data.NgungHut = DataReader["NgungHut"] == DBNull.Value ? null : (DateTime?)DataReader.GetDate("NgungHut");
                    data.ConHut = double.TryParse(DataReader["ConHut"].ToString(), out doubTemp) ? (double?)doubTemp : null;
                    data.HutLai = DataReader["HutLai"] == DBNull.Value ? null : (DateTime?)DataReader.GetDate("HutLai");
                    data.HutLaiSoLuong = double.TryParse(DataReader["HutLaiSoLuong"].ToString(), out doubTemp) ? (double?)doubTemp : null;
                    data.FEV1 = double.TryParse(DataReader["FEV1"].ToString(), out doubTemp) ? (double?)doubTemp : null;
                    data.SpO2 = double.TryParse(DataReader["SpO2"].ToString(), out doubTemp) ? (double?)doubTemp : null;
                    data.KhoangCachDiBo = double.TryParse(DataReader["KhoangCachDiBo"].ToString(), out doubTemp) ? (double?)doubTemp : null;

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuKhamVaTheoDoiDieuTriCopd phieuKham)
        {
            try
            {
                string sql = @"INSERT INTO PKVaTDDieuTriCopd
                (
                    MAQUANLY,
                    MaBenhNhan,
                    MaBenhAn,
                    NgayKham,
                    LanKhamThu,
                    HoKhacDam,
                    MRC,
                    TriGiac,
                    An,
                    Ngu,
                    GiaiTri,
                    TamHoatDong,
                    SDThuocCatConNgay,
                    SDThuocCatConTuan,
                    SDThuocCatConThang,
                    SDThuocCatConKhongDung,
                    Cao,
                    Nang,
                    BMI,
                    NgungHut,
                    ConHut,
                    HutLai,
                    HutLaiSoLuong,
                    FEV1,
                    SpO2,
                    KhoangCachDiBo,
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
                    :HoKhacDam,
                    :MRC,
                    :TriGiac,
                    :An,
                    :Ngu,
                    :GiaiTri,
                    :TamHoatDong,
                    :SDThuocCatConNgay,
                    :SDThuocCatConTuan,
                    :SDThuocCatConThang,
                    :SDThuocCatConKhongDung,
                    :Cao,
                    :Nang,
                    :BMI,
                    :NgungHut,
                    :ConHut,
                    :HutLai,
                    :HutLaiSoLuong,
                    :FEV1,
                    :SpO2,
                    :KhoangCachDiBo,
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
                    sql = @"UPDATE PKVaTDDieuTriCopd SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    MaBenhAn = :MaBenhAn,
                    NgayKham = :NgayKham,
                    LanKhamThu = :LanKhamThu,
                    HoKhacDam = :HoKhacDam,
                    MRC = :MRC,
                    TriGiac = :TriGiac,
                    An = :An,
                    Ngu = :Ngu,
                    GiaiTri = :GiaiTri,
                    TamHoatDong = :TamHoatDong,
                    SDThuocCatConNgay = :SDThuocCatConNgay,
                    SDThuocCatConTuan = :SDThuocCatConTuan,
                    SDThuocCatConThang = :SDThuocCatConThang,
                    SDThuocCatConKhongDung = :SDThuocCatConKhongDung,
                    Cao = :Cao,
                    Nang = :Nang,
                    BMI = :BMI,
                    NgungHut = :NgungHut,
                    ConHut = :ConHut,
                    HutLai = :HutLai,
                    HutLaiSoLuong = :HutLaiSoLuong,
                    FEV1 = :FEV1,
                    SpO2 = :SpO2,
                    KhoangCachDiBo = :KhoangCachDiBo,
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
                Command.Parameters.Add(new MDB.MDBParameter("HoKhacDam", phieuKham.HoKhacDam));
                Command.Parameters.Add(new MDB.MDBParameter("MRC", phieuKham.MRC));
                Command.Parameters.Add(new MDB.MDBParameter("TriGiac", phieuKham.TriGiac));
                Command.Parameters.Add(new MDB.MDBParameter("An", phieuKham.An));
                Command.Parameters.Add(new MDB.MDBParameter("Ngu", phieuKham.Ngu));
                Command.Parameters.Add(new MDB.MDBParameter("GiaiTri", phieuKham.GiaiTri));
                Command.Parameters.Add(new MDB.MDBParameter("TamHoatDong", phieuKham.TamHoatDong));
                Command.Parameters.Add(new MDB.MDBParameter("SDThuocCatConNgay", phieuKham.SDThuocCatConNgay));
                Command.Parameters.Add(new MDB.MDBParameter("SDThuocCatConTuan", phieuKham.SDThuocCatConTuan));
                Command.Parameters.Add(new MDB.MDBParameter("SDThuocCatConThang", phieuKham.SDThuocCatConThang));
                Command.Parameters.Add(new MDB.MDBParameter("SDThuocCatConKhongDung", phieuKham.SDThuocCatConKhongDung ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("Cao", phieuKham.Cao));
                Command.Parameters.Add(new MDB.MDBParameter("Nang", phieuKham.Nang));
                Command.Parameters.Add(new MDB.MDBParameter("BMI", phieuKham.BMI));
                Command.Parameters.Add(new MDB.MDBParameter("NgungHut", phieuKham.NgungHut));
                Command.Parameters.Add(new MDB.MDBParameter("ConHut", phieuKham.ConHut));
                Command.Parameters.Add(new MDB.MDBParameter("HutLai", phieuKham.HutLai));
                Command.Parameters.Add(new MDB.MDBParameter("HutLaiSoLuong", phieuKham.HutLaiSoLuong));
                Command.Parameters.Add(new MDB.MDBParameter("FEV1", phieuKham.FEV1));
                Command.Parameters.Add(new MDB.MDBParameter("SpO2", phieuKham.SpO2));
                Command.Parameters.Add(new MDB.MDBParameter("KhoangCachDiBo", phieuKham.KhoangCachDiBo));
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
                string sql = "DELETE FROM PKVaTDDieuTriCopd WHERE ID = :ID";
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
                PKVaTDDieuTriCopd B
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

            if (string.IsNullOrEmpty(ds.Tables[0].Rows[0]["MaBenhAn"].ToString()))
            {
                ds.Tables[0].Rows[0]["MaBenhAn"] = XemBenhAn._ThongTinDieuTri.MaBenhAn;
            }
            return ds;

        }
    }
}
