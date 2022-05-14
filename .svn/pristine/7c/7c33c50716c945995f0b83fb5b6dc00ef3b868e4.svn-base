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
    public class PhieuSLVDGTTDDNBNT : ThongTinKy
    {
        public PhieuSLVDGTTDDNBNT()
        {
            TableName = "PhieuSLVDGTTDDNBNT";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PSLVDGTTDDNBNT;
            TenMauPhieu = DanhMucPhieu.PSLVDGTTDDNBNT.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Mã bệnh án")]
		public string MaBenhAn { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }

        public string HoTenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public double? CanNang { get; set; }
        public double? ChieuCao { get; set; }
        public double? BMI { get; set; }

        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuong { get; set; }
        [MoTaDuLieu("Mã điều dưỡng")]
		public string MaDieuDuong { get; set; }
        [MoTaDuLieu("Bác sỹ")]
		public string BacSy { get; set; }
        [MoTaDuLieu("Mã bác sỹ")]
		public string MaBacSy { get; set; }

        public int ChiSoBMI { get; set; }
        public int SutCan { get; set; }
        public int ChanAn { get; set; }
        public int BenhNang { get; set; }
        public int KQSangLoc { get; set; }
        public int Phu { get; set; }
        public int AnDuongMieng { get; set; }
        public int DGBMI { get; set; }
        public int DGGiamCan { get; set; }
        public int TongDiem { get; set; }
        public int NguyCoDD { get; set; }
        public int DGBNPhu { get; set; }
        public string MaCheDoAn { get; set; }

        public bool[] DuongNuoiAnArray { get; } = new bool[] { false, false, false };
        public string DuongNuoiAn
        {
            get
            {
                string temp = "";
                for (int i = 0; i < DuongNuoiAnArray.Length; i++)
                    temp += DuongNuoiAnArray[i] ? "1" : "0";
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DuongNuoiAnArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public int HoiChanDD { get; set; }

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
        public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
    }
    public class PhieuSLVDGTTDDNBNTFunc
    {
        public const string TableName = "PhieuSLVDGTTDDNBNT";
        public const string TablePrimaryKeyName = "ID";
        public const string MaPhieu = "PSLVDGTTDDNBNT";
        public static List<PhieuSLVDGTTDDNBNT> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuSLVDGTTDDNBNT> list = new List<PhieuSLVDGTTDDNBNT>();
            try
            {
                string sql = @"SELECT * FROM PhieuSLVDGTTDDNBNT where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuSLVDGTTDDNBNT data = new PhieuSLVDGTTDDNBNT();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;

                    data.MaBenhNhan = Common.ConDBNull(DataReader["MaBenhNhan"]);
                    data.MaBenhAn = Common.ConDBNull(DataReader["MaBenhAn"]);

                    data.HoTenBenhNhan = Common.ConDBNull(DataReader["HoTenBenhNhan"]);
                    data.Tuoi = Common.ConDBNull(DataReader["Tuoi"]);
                    data.GioiTinh = Common.ConDBNull(DataReader["GioiTinh"]);
                    data.Khoa = Common.ConDBNull(DataReader["Khoa"]);
                    data.MaKhoa = Common.ConDBNull(DataReader["MaKhoa"]);

                    data.ChanDoan = Common.ConDBNull(DataReader["ChanDoan"]);
                    data.CanNang = Common.ConDBNull_double(DataReader["CanNang"]);
                    data.ChieuCao = Common.ConDBNull_double(DataReader["ChieuCao"]);
                    data.BMI = Common.ConDBNull_double(DataReader["BMI"]);

                    data.DieuDuong = Common.ConDBNull(DataReader["DieuDuong"]);
                    data.MaDieuDuong = Common.ConDBNull(DataReader["MaDieuDuong"]);
                    data.BacSy = Common.ConDBNull(DataReader["BacSy"]);
                    data.MaBacSy = Common.ConDBNull(DataReader["MaBacSy"]);

                    data.ChiSoBMI = Common.ConDB_Int(DataReader["ChiSoBMI"]);
                    data.SutCan = Common.ConDB_Int(DataReader["SutCan"]);
                    data.ChanAn = Common.ConDB_Int(DataReader["ChanAn"]);
                    data.BenhNang = Common.ConDB_Int(DataReader["BenhNang"]);
                    data.KQSangLoc = Common.ConDB_Int(DataReader["KQSangLoc"]);
                    data.Phu = Common.ConDB_Int(DataReader["Phu"]);
                    data.AnDuongMieng = Common.ConDB_Int(DataReader["AnDuongMieng"]);
                    data.DGBMI = Common.ConDB_Int(DataReader["DGBMI"]);
                    data.DGGiamCan = Common.ConDB_Int(DataReader["DGGiamCan"]);
                    data.TongDiem = Common.ConDB_Int(DataReader["TongDiem"]);
                    data.NguyCoDD = Common.ConDB_Int(DataReader["NguyCoDD"]);
                    data.DGBNPhu = Common.ConDB_Int(DataReader["DGBNPhu"]);
                    data.MaCheDoAn = Common.ConDBNull(DataReader["MaCheDoAn"]);
                    data.DuongNuoiAn = Common.ConDBNull(DataReader["DuongNuoiAn"]);
                    data.HoiChanDD = Common.ConDB_Int(DataReader["HoiChanDD"]);

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuSLVDGTTDDNBNT bangKe)
        {
            try
            {
                string sql = @"INSERT INTO PhieuSLVDGTTDDNBNT
                (
                    MaQuanLy,
                    MaBenhNhan,
                    MaBenhAn,
                    Khoa,
                    MaKhoa,
                    HoTenBenhNhan,
                    Tuoi,
                    GioiTinh,
                    ChanDoan,
                    CanNang,
                    ChieuCao,
                    BMI,
                    DieuDuong,
                    MaDieuDuong,
                    BacSy,
                    MaBacSy,
                    ChiSoBMI,
                    SutCan,
                    ChanAn,
                    BenhNang,
                    KQSangLoc,
                    Phu,
                    AnDuongMieng,
                    DGBMI,
                    DGGiamCan,
                    TongDiem,
                    NguyCoDD,
                    DGBNPhu,
                    MaCheDoAn,
                    DuongNuoiAn,
                    HoiChanDD,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
                    :MaBenhNhan,
                    :MaBenhAn,
                    :Khoa,
                    :MaKhoa,
                    :HoTenBenhNhan,
                    :Tuoi,
                    :GioiTinh,
                    :ChanDoan,
                    :CanNang,
                    :ChieuCao,
                    :BMI,
                    :DieuDuong,
                    :MaDieuDuong,
                    :BacSy,
                    :MaBacSy,
                    :ChiSoBMI,
                    :SutCan,
                    :ChanAn,
                    :BenhNang,
                    :KQSangLoc,
                    :Phu,
                    :AnDuongMieng,
                    :DGBMI,
                    :DGGiamCan,
                    :TongDiem,
                    :NguyCoDD,
                    :DGBNPhu,
                    :MaCheDoAn,
                    :DuongNuoiAn,
                    :HoiChanDD,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (bangKe.ID != 0)
                {
                    sql = @"UPDATE PhieuSLVDGTTDDNBNT SET 
                    MaQuanLy=:MaQuanLy,
                    MaBenhNhan=:MaBenhNhan,
                    MaBenhAn=:MaBenhAn,
                    Khoa=:Khoa,
                    MaKhoa=:MaKhoa,
                    HoTenBenhNhan=:HoTenBenhNhan,
                    Tuoi=:Tuoi,
                    GioiTinh=:GioiTinh,
                    ChanDoan=:ChanDoan,
                    CanNang=:CanNang,
                    ChieuCao=:ChieuCao,
                    BMI=:BMI,
                    DieuDuong=:DieuDuong,
                    MaDieuDuong=:MaDieuDuong,
                    BacSy=:BacSy,
                    MaBacSy=:MaBacSy,
                    ChiSoBMI=:ChiSoBMI,
                    SutCan=:SutCan,
                    ChanAn=:ChanAn,
                    BenhNang=:BenhNang,
                    KQSangLoc=:KQSangLoc,
                    Phu=:Phu,
                    AnDuongMieng=:AnDuongMieng,
                    DGBMI=:DGBMI,
                    DGGiamCan=:DGGiamCan,
                    TongDiem=:TongDiem,
                    NguyCoDD=:NguyCoDD,
                    DGBNPhu=:DGBNPhu,
                    MaCheDoAn=:MaCheDoAn,
                    DuongNuoiAn=:DuongNuoiAn,
                    HoiChanDD=:HoiChanDD,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + bangKe.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", bangKe.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", bangKe.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhAn", bangKe.MaBenhAn));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa", bangKe.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaKhoa", bangKe.MaKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("HoTenBenhNhan", bangKe.HoTenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("Tuoi", bangKe.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("GioiTinh", bangKe.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", bangKe.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang", bangKe.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("ChieuCao", bangKe.ChieuCao));
                Command.Parameters.Add(new MDB.MDBParameter("BMI", bangKe.BMI));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuong", bangKe.DieuDuong));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuong", bangKe.MaDieuDuong));
                Command.Parameters.Add(new MDB.MDBParameter("BacSy", bangKe.BacSy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSy", bangKe.MaBacSy));
                Command.Parameters.Add(new MDB.MDBParameter("ChiSoBMI", bangKe.ChiSoBMI));
                Command.Parameters.Add(new MDB.MDBParameter("SutCan", bangKe.SutCan));
                Command.Parameters.Add(new MDB.MDBParameter("ChanAn", bangKe.ChanAn));
                Command.Parameters.Add(new MDB.MDBParameter("BenhNang", bangKe.BenhNang));
                Command.Parameters.Add(new MDB.MDBParameter("KQSangLoc", bangKe.KQSangLoc));
                Command.Parameters.Add(new MDB.MDBParameter("Phu", bangKe.Phu));
                Command.Parameters.Add(new MDB.MDBParameter("AnDuongMieng", bangKe.AnDuongMieng));
                Command.Parameters.Add(new MDB.MDBParameter("DGBMI", bangKe.DGBMI));
                Command.Parameters.Add(new MDB.MDBParameter("DGGiamCan", bangKe.DGGiamCan));
                Command.Parameters.Add(new MDB.MDBParameter("TongDiem", bangKe.TongDiem));
                Command.Parameters.Add(new MDB.MDBParameter("NguyCoDD", bangKe.NguyCoDD));
                Command.Parameters.Add(new MDB.MDBParameter("DGBNPhu", bangKe.DGBNPhu));
                Command.Parameters.Add(new MDB.MDBParameter("MaCheDoAn", bangKe.MaCheDoAn));
                Command.Parameters.Add(new MDB.MDBParameter("DuongNuoiAn", bangKe.DuongNuoiAn));
                Command.Parameters.Add(new MDB.MDBParameter("HoiChanDD", bangKe.HoiChanDD));

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
                string sql = "DELETE FROM PhieuSLVDGTTDDNBNT WHERE ID = :ID";
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
                PhieuSLVDGTTDDNBNT B
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);

            var ds = new DataSet();

            adt.Fill(ds, "TB");
            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(string));
            ds.Tables[0].AddColumn("Khoa", typeof(string));
            ds.Tables[0].AddColumn("SoYTe", typeof(string));
            ds.Tables[0].AddColumn("BenhVien", typeof(string));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            ds.Tables[0].Rows[0]["Khoa"] = XemBenhAn._ThongTinDieuTri.Khoa;
            ds.Tables[0].Rows[0]["SoYTe"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BenhVien"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;

            return ds;

        }
    }
}
