using EMR.KyDienTu;
using EMR_MAIN.Converter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum DanLuu
    {
        [Description("Không")]
        Khong = 0,
        [Description("Có")]
        Co = 1
    }
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum Sonde
    {
        [Description("Không")]
        Khong = 0,
        [Description("Để nguyên")]
        DeNguyen = 1,
        [Description("Rút")]
        Rut = 2
    }
    public class KiemSoatNguoiBenhTruoc : ThongTinKy
    {
        public KiemSoatNguoiBenhTruoc()
        {
            TableName = "KIEMSOATNGUOIBENHTRUOC";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.KSTCK;
            TenMauPhieu = DanhMucPhieu.KSTCK.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public int IDKiemSoatNguoiBenhTruoc { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        public string SoVaoVien { get; set; }
        public DanLuu DanLuu { get; set; }
        public Sonde DuongTruyen { get; set; }
        public Sonde BangQuang { get; set; }
        public Sonde DaDay { get; set; }
        public string DichChuyen { get; set; }
        public string CheDoAnUong { get; set; }
        public string CanLamSang { get; set; }
        [MoTaDuLieu("Nước tiểu")]
		public string NuocTieu { get; set; }
        public string DichDaDay { get; set; }
        public string DichDanLuu { get; set; }
        public string NhanXet { get; set; }
        [MoTaDuLieu("Bác sỹ")]
		public string BacSy { get; set; }
        [MoTaDuLieu("Mã bác sỹ")]
		public string MaBacSy { get; set; }
        public string NguoiGiao { get; set; }
        public string MaNguoiGiao { get; set; }
        public string NguoiNhan { get; set; }
        public string MaNguoiNhan { get; set; }
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
    public class KiemSoatNguoiBenhTrucFunc
    {
        public const string TableName = "KIEMSOATNGUOIBENHTRUOC";
        public const string TablePrimaryKeyName = "IDKiemSoatNguoiBenhTruoc";
        public const string MaPhieu = "KSTCK";
        public static List<KiemSoatNguoiBenhTruoc> getData(decimal maQuanLy, MDB.MDBConnection _OracleConnection)
        {
            List<KiemSoatNguoiBenhTruoc> lstData = new List<KiemSoatNguoiBenhTruoc>();
            try
            {
                string sql = @"SELECT * FROM KIEMSOATNGUOIBENHTRUOC where MaQuanLy = :MaQuanLy and XOA = 0";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maQuanLy));
                Command.BindByName = true;
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    KiemSoatNguoiBenhTruoc data = new KiemSoatNguoiBenhTruoc();
                    data.IDKiemSoatNguoiBenhTruoc = Convert.ToInt32(DataReader.GetLong("IDKiemSoatNguoiBenhTruoc").ToString());
                    data.MaQuanLy = maQuanLy;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.SoVaoVien = DataReader["SoVaoVien"].ToString();
                    int temp = 0;
                    int.TryParse(DataReader["DanLuu"].ToString(), out temp);
                    data.DanLuu = (DanLuu)temp;

                    temp = 0;
                    int.TryParse(DataReader["DuongTruyen"].ToString(), out temp);
                    data.DuongTruyen = (Sonde)temp;

                    temp = 0;
                    int.TryParse(DataReader["BangQuang"].ToString(), out temp);
                    data.BangQuang = (Sonde)temp;

                    temp = 0;
                    int.TryParse(DataReader["DaDay"].ToString(), out temp);
                    data.DaDay = (Sonde)temp;

                    data.DichChuyen = DataReader["DichChuyen"].ToString();
                    data.CheDoAnUong = DataReader["CheDoAnUong"].ToString();
                    data.CanLamSang = DataReader["CanLamSang"].ToString();
                    data.NuocTieu = DataReader["NuocTieu"].ToString();
                    data.DichDaDay = DataReader["DichDaDay"].ToString();
                    data.DichDanLuu = DataReader["DichDanLuu"].ToString();
                    data.NhanXet = DataReader["NhanXet"].ToString();
                    data.BacSy = DataReader["BacSy"].ToString();
                    data.MaBacSy = DataReader["MaBacSy"].ToString();
                    data.NguoiGiao = DataReader["NguoiGiao"].ToString();
                    data.MaNguoiGiao = DataReader["MaNguoiGiao"].ToString();
                    data.NguoiNhan = DataReader["NguoiNhan"].ToString();
                    data.MaNguoiNhan = DataReader["MaNguoiNhan"].ToString();

                    data.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                    data.NguoiTao = DataReader["NguoiTao"].ToString();
                    data.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);
                    data.NguoiSua = DataReader["NguoiSua"].ToString();

                    lstData.Add(data);
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return lstData;
        }
        public static bool insertOrUpdate(MDB.MDBConnection MyConnection, ref KiemSoatNguoiBenhTruoc kiemSoatNguoiBenhTruoc)
        {
            string sql = @"INSERT INTO KIEMSOATNGUOIBENHTRUOC
                (
                    MABENHNHAN, 
                    MAQUANLY,
					SOVAOVIEN, 
					DANLUU, 
					DUONGTRUYEN, 
					BANGQUANG, 
					DADAY, 
					DICHCHUYEN, 
					CHEDOANUONG, 
					CANLAMSANG, 
					NUOCTIEU, 
					DICHDADAY, 
					DICHDANLUU, 
					NHANXET,
					BACSY, 
					MABACSY, 
					NGUOIGIAO, 
					MANGUOIGIAO, 
					NGUOINHAN, 
					MANGUOINHAN,
                    XOA,
                    NGUOITAO,
                    NGAYTAO,
                    NGUOISUA,
                    NGAYSUA)  VALUES
                 (
                    :MABENHNHAN, 
                    :MAQUANLY,
					:SOVAOVIEN, 
					:DANLUU, 
					:DUONGTRUYEN, 
					:BANGQUANG, 
					:DADAY, 
					:DICHCHUYEN, 
					:CHEDOANUONG, 
					:CANLAMSANG, 
					:NUOCTIEU, 
					:DICHDADAY, 
					:DICHDANLUU, 
					:NHANXET,
					:BACSY, 
					:MABACSY, 
					:NGUOIGIAO, 
					:MANGUOIGIAO, 
					:NGUOINHAN, 
					:MANGUOINHAN, 	
                    0,
                    :NGUOITAO,
                    :NGAYTAO,
                    :NGUOISUA,
                    :NGAYSUA
                )  RETURNING IDKIEMSOATNGUOIBENHTRUOC INTO :IDKIEMSOATNGUOIBENHTRUOC";
            if (kiemSoatNguoiBenhTruoc.IDKiemSoatNguoiBenhTruoc != 0)
            {
                sql = @"UPDATE KIEMSOATNGUOIBENHTRUOC SET
                    MABENHNHAN=:MABENHNHAN,
                    MAQUANLY=:MAQUANLY,
					SOVAOVIEN=:SOVAOVIEN, 
					DANLUU=:DANLUU, 
					DUONGTRUYEN=:DUONGTRUYEN, 
					BANGQUANG=:BANGQUANG, 
					DADAY=:DADAY, 
					DICHCHUYEN=:DICHCHUYEN, 
					CHEDOANUONG=:CHEDOANUONG, 
					CANLAMSANG=:CANLAMSANG, 
					NUOCTIEU=:NUOCTIEU, 
					DICHDADAY=:DICHDADAY, 
					DICHDANLUU=:DICHDANLUU, 
					NHANXET=:NHANXET,
					BACSY=:BACSY, 
					MABACSY=:MABACSY, 
					NGUOIGIAO=:NGUOIGIAO, 
					MANGUOIGIAO=:MANGUOIGIAO, 
					NGUOINHAN=:NGUOINHAN, 
					MANGUOINHAN=:MANGUOINHAN,
                    NGUOISUA=:NGUOISUA,
                    NGAYSUA=:NGAYSUA 
					WHERE IDKIEMSOATNGUOIBENHTRUOC = " + kiemSoatNguoiBenhTruoc.IDKiemSoatNguoiBenhTruoc;
            }
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MABENHNHAN", kiemSoatNguoiBenhTruoc.MaBenhNhan));
            Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", kiemSoatNguoiBenhTruoc.MaQuanLy));
            Command.Parameters.Add(new MDB.MDBParameter("SOVAOVIEN", kiemSoatNguoiBenhTruoc.SoVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("DANLUU", (int)kiemSoatNguoiBenhTruoc.DanLuu));
            Command.Parameters.Add(new MDB.MDBParameter("DUONGTRUYEN", (int)kiemSoatNguoiBenhTruoc.DuongTruyen));
            Command.Parameters.Add(new MDB.MDBParameter("BANGQUANG", (int)kiemSoatNguoiBenhTruoc.BangQuang));
            Command.Parameters.Add(new MDB.MDBParameter("DADAY", (int)kiemSoatNguoiBenhTruoc.DaDay));
            Command.Parameters.Add(new MDB.MDBParameter("DICHCHUYEN", kiemSoatNguoiBenhTruoc.DichChuyen));
            Command.Parameters.Add(new MDB.MDBParameter("CHEDOANUONG", kiemSoatNguoiBenhTruoc.CheDoAnUong));
            Command.Parameters.Add(new MDB.MDBParameter("CANLAMSANG", kiemSoatNguoiBenhTruoc.CanLamSang));
            Command.Parameters.Add(new MDB.MDBParameter("NUOCTIEU", kiemSoatNguoiBenhTruoc.NuocTieu));
            Command.Parameters.Add(new MDB.MDBParameter("DICHDADAY", kiemSoatNguoiBenhTruoc.DichDaDay));
            Command.Parameters.Add(new MDB.MDBParameter("DICHDANLUU", kiemSoatNguoiBenhTruoc.DichDanLuu));
            Command.Parameters.Add(new MDB.MDBParameter("NHANXET", kiemSoatNguoiBenhTruoc.NhanXet));
            Command.Parameters.Add(new MDB.MDBParameter("BACSY", kiemSoatNguoiBenhTruoc.BacSy));
            Command.Parameters.Add(new MDB.MDBParameter("MABACSY", kiemSoatNguoiBenhTruoc.MaBacSy));
            Command.Parameters.Add(new MDB.MDBParameter("NGUOIGIAO", kiemSoatNguoiBenhTruoc.NguoiGiao));
            Command.Parameters.Add(new MDB.MDBParameter("MANGUOIGIAO", kiemSoatNguoiBenhTruoc.MaNguoiGiao));
            Command.Parameters.Add(new MDB.MDBParameter("NGUOINHAN", kiemSoatNguoiBenhTruoc.NguoiNhan));
            Command.Parameters.Add(new MDB.MDBParameter("MANGUOINHAN", kiemSoatNguoiBenhTruoc.MaNguoiNhan));
            Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", kiemSoatNguoiBenhTruoc.NguoiSua));
            Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", kiemSoatNguoiBenhTruoc.NgaySua));
            if (kiemSoatNguoiBenhTruoc.IDKiemSoatNguoiBenhTruoc == 0)
            {
                Command.Parameters.Add(new MDB.MDBParameter("IDKIEMSOATNGUOIBENHTRUOC", kiemSoatNguoiBenhTruoc.IDKiemSoatNguoiBenhTruoc));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", kiemSoatNguoiBenhTruoc.NguoiTao));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", kiemSoatNguoiBenhTruoc.NgayTao));
            }
            Command.BindByName = true;
            int n = Command.ExecuteNonQuery(); // C#
            if (kiemSoatNguoiBenhTruoc.IDKiemSoatNguoiBenhTruoc == 0)
            {
                int nextval = Convert.ToInt32((Command.Parameters["IDKIEMSOATNGUOIBENHTRUOC"] as MDB.MDBParameter).Value);
                kiemSoatNguoiBenhTruoc.IDKiemSoatNguoiBenhTruoc = nextval;
            }

            return n > 0 ? true : false;
        }
        public static bool delete(MDB.MDBConnection MyConnection, int idKiemSoatNguoiBenhTruoc)
        {
            string sql = @"UPDATE KIEMSOATNGUOIBENHTRUOC SET 
                    XOA = 1
                    WHERE IDKIEMSOATNGUOIBENHTRUOC = " + idKiemSoatNguoiBenhTruoc;
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static DataSet getDataSet(MDB.MDBConnection MyConnection, int idKiemSoatNguoiBenhTruoc)
        {
            string sql = @"SELECT MABENHNHAN, 
                                 SOVAOVIEN,
                                 DANLUU,
                                 DUONGTRUYEN,
                                 BANGQUANG,
                                 DADAY,
                                 DICHCHUYEN,
                                 CHEDOANUONG,
                                 CANLAMSANG,
                                 NUOCTIEU,
                                 DICHDADAY,
                                 DICHDANLUU,
                                 NHANXET,
                                 BACSY,
                                 NGUOIGIAO,
                                 NGUOINHAN,
                                 MABACSY,
                                 MANGUOIGIAO,
                                 MANGUOINHAN
                                 FROM KIEMSOATNGUOIBENHTRUOC where IDKIEMSOATNGUOIBENHTRUOC = :IDKIEMSOATNGUOIBENHTRUOC and XOA = 0";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("IDKIEMSOATNGUOIBENHTRUOC", idKiemSoatNguoiBenhTruoc));
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            adt.Fill(ds, "KIEMSOAT");

            DataTable thongTinVien = new DataTable("HEADER");
            thongTinVien.Columns.Add("SOYTE");
            thongTinVien.Columns.Add("BENHVIEN");
            thongTinVien.Columns.Add("KHOA");
			if (XemBenhAn._HanhChinhBenhNhan == null) XemBenhAn._HanhChinhBenhNhan = new HanhChinhBenhNhan();
            if (XemBenhAn._ThongTinDieuTri == null) XemBenhAn._ThongTinDieuTri = new ThongTinDieuTri();
            thongTinVien.Rows.Add(XemBenhAn._HanhChinhBenhNhan.SoYTe, XemBenhAn._HanhChinhBenhNhan.BenhVien, XemBenhAn._ThongTinDieuTri.Khoa);
            ds.Tables.Add(thongTinVien);

            return ds;
        }
    }
}
