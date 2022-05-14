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
    public class BangKiemTruocLamThuThuatChupDSA : ThongTinKy
    {
        public BangKiemTruocLamThuThuatChupDSA()
        {
            TableName = "BangKiemTruocLamThuThuatChupDSA";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BKTLTTCDSA;
            TenMauPhieu = DanhMucPhieu.BKTLTTCDSA.Description();
        }
        // Phần chung
        [MoTaDuLieu("Mã định danh")]
        public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau", "", 1)]
        public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
        public string MaBenhNhan { get; set; }
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
        // End Phần chung 

        public string BenhVien { get; set; }
        public string Khoa { get; set; }
        public string SoVaoVien { get; set; }
        public string HoVaTen { get; set; }
        public string Tuoi { get; set; }
        public string Gioi { get; set; }
        public string CTTM { get; set; }
        public string Phong { get; set; }
        public string ChuanDoan { get; set; }
        public int BienBanHoiChuan { get; set; }
        public int CamKetThuThuat { get; set; }
        public int HoanThanhBenhAn { get; set; }
        public int TamUngThuThuat { get; set; }
        public string BHYT { get; set; }
        public int CongThucMau { get; set; }
        public int DongMauToanBo { get; set; }
        public int GlucoseMau { get; set; }
        public int DienGiaiDo { get; set; }
        public int UreCrea { get; set; }
        public int NhomMau { get; set; }
        public int HBsAg { get; set; }
        public int AntiHCV { get; set; }
        public int AntiHIV { get; set; }
        public int GiangMai { get; set; }
        public int ECG { get; set; }
        public int XQPhoi { get; set; }
        public int SieuAmTim { get; set; }
        public int VeSinhVungBen { get; set; }
        public int ChuanBiDichTruyenTay { get; set; }
        public int DanBenhNhanNhinAn { get; set; }
        public int DanBenhNhanThaoTuTrang { get; set; }
        public int ThuTest { get; set; }
        public string MaBSChuanBi { get; set; }
        public string TenBSChuanBi { get; set; }
        public string MaDDChuanBi { get; set; }
        public string TenDDChuanBi { get; set; }
    }

    public class BangKiemTruocLamThuThuatChupDSAFunc
    {
        public const string TableName = "BangKiemTruocLamThuThuatChupDSAFunc";
        public const string TablePrimaryKeyName = "ID";
        public static List<BangKiemTruocLamThuThuatChupDSA> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BangKiemTruocLamThuThuatChupDSA> list = new List<BangKiemTruocLamThuThuatChupDSA>();
            try
            {
                string sql = @"SELECT * FROM BangKiemTruocLamThuThuatChupDSA where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    BangKiemTruocLamThuThuatChupDSA data = new BangKiemTruocLamThuThuatChupDSA();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();


                    data.BenhVien = DataReader["BenhVien"].ToString();
                    data.Khoa = DataReader["Khoa"].ToString();
                    data.SoVaoVien = DataReader["SoVaoVien"].ToString();
                    data.HoVaTen = DataReader["HoVaTen"].ToString();
                    data.Tuoi = DataReader["Tuoi"].ToString();
                    data.Gioi = DataReader["Gioi"].ToString();
                    data.Tuoi = DataReader["Tuoi"].ToString();
                    data.CTTM = DataReader["CTTM"].ToString();
                    data.Phong = DataReader["Phong"].ToString();
                    data.ChuanDoan = DataReader["ChuanDoan"].ToString();

                    data.BienBanHoiChuan = DataReader.GetInt("BienBanHoiChuan");
                    data.CamKetThuThuat = DataReader.GetInt("CamKetThuThuat");
                    data.HoanThanhBenhAn = DataReader.GetInt("HoanThanhBenhAn");
                    data.TamUngThuThuat = DataReader.GetInt("TamUngThuThuat");
                    data.BHYT = DataReader["BHYT"].ToString();

                    data.CongThucMau = DataReader.GetInt("CongThucMau");
                    data.DongMauToanBo = DataReader.GetInt("DongMauToanBo");
                    data.GlucoseMau = DataReader.GetInt("GlucoseMau");
                    data.DienGiaiDo = DataReader.GetInt("DienGiaiDo");
                    data.UreCrea = DataReader.GetInt("UreCrea");

                    data.NhomMau = DataReader.GetInt("NhomMau");
                    data.HBsAg = DataReader.GetInt("HBsAg");
                    data.AntiHCV = DataReader.GetInt("AntiHCV");
                    data.AntiHIV = DataReader.GetInt("AntiHIV");
                    data.GiangMai = DataReader.GetInt("GiangMai");
                    data.ECG = DataReader.GetInt("ECG");
                    data.XQPhoi = DataReader.GetInt("XQPhoi");
                    data.SieuAmTim = DataReader.GetInt("SieuAmTim");

                    data.VeSinhVungBen = DataReader.GetInt("VeSinhVungBen");
                    data.ChuanBiDichTruyenTay = DataReader.GetInt("ChuanBiDichTruyenTay");
                    data.DanBenhNhanNhinAn = DataReader.GetInt("DanBenhNhanNhinAn");
                    data.DanBenhNhanThaoTuTrang = DataReader.GetInt("DanBenhNhanThaoTuTrang");
                    data.ThuTest = DataReader.GetInt("ThuTest");

                    data.MaBSChuanBi = DataReader["MaBSChuanBi"].ToString();
                    data.TenBSChuanBi = DataReader["TenBSChuanBi"].ToString();
                    data.MaDDChuanBi = DataReader["MaDDChuanBi"].ToString();
                    data.TenDDChuanBi = DataReader["TenDDChuanBi"].ToString();


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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BangKiemTruocLamThuThuatChupDSA ketQua)
        {
            try
            {
                string sql = @"INSERT INTO BangKiemTruocLamThuThuatChupDSA
                (
                    MAQUANLY,
                    MaBenhNhan,

                    BenhVien, 
                    Khoa, 
                    SoVaoVien, 
                    HoVaTen, 
                    Tuoi ,
                    Gioi ,
                    CTTM ,
                    Phong ,
                    ChuanDoan ,
                    BienBanHoiChuan ,
                    CamKetThuThuat ,
                    HoanThanhBenhAn ,
                    TamUngThuThuat ,
                    BHYT ,
		
                    CongThucMau ,
                    DongMauToanBo ,
                    GlucoseMau ,
                    DienGiaiDo ,
                    UreCrea ,
		
                    NhomMau ,
                    HBsAg ,
                    AntiHCV ,
                    AntiHIV ,
                    GiangMai ,
                    ECG ,
                    XQPhoi ,
                    SieuAmTim ,
		
                    VeSinhVungBen ,
                    ChuanBiDichTruyenTay ,
                    DanBenhNhanNhinAn ,
                    DanBenhNhanThaoTuTrang ,
                    ThuTest ,
		
                    MaBSChuanBi ,
                    TenBSChuanBi ,
                    MaDDChuanBi ,
                    TenDDChuanBi,


                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,

                    :BenhVien, 
                    :Khoa, 
                    :SoVaoVien, 
                    :HoVaTen, 
                    :Tuoi ,
                    :Gioi ,
                    :CTTM ,
                    :Phong ,
                    :ChuanDoan ,
                    :BienBanHoiChuan ,
                    :CamKetThuThuat ,
                    :HoanThanhBenhAn ,
                    :TamUngThuThuat ,
                    :BHYT ,
					
                    :CongThucMau ,
                    :DongMauToanBo ,
                    :GlucoseMau ,
                    :DienGiaiDo ,
                    :UreCrea ,
					
                    :NhomMau ,
                    :HBsAg ,
                    :AntiHCV ,
                    :AntiHIV ,
                    :GiangMai ,
                    :ECG ,
                    :XQPhoi ,
                    :SieuAmTim ,
					
                    :VeSinhVungBen ,
                    :ChuanBiDichTruyenTay ,
                    :DanBenhNhanNhinAn ,
                    :DanBenhNhanThaoTuTrang ,
                    :ThuTest ,
					
                    :MaBSChuanBi ,
                    :TenBSChuanBi ,
                    :MaDDChuanBi ,
                    :TenDDChuanBi,

                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE BangKiemTruocLamThuThuatChupDSA SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    
					BenhVien=:BenhVien, 
                    Khoa=:Khoa, 
                    SoVaoVien=:SoVaoVien, 
                    HoVaTen=:HoVaTen, 
                    Tuoi=:Tuoi ,
                    Gioi=:Gioi ,
                    CTTM=:CTTM ,
                    Phong=:Phong ,
                    ChuanDoan=:ChuanDoan ,
                    BienBanHoiChuan=:BienBanHoiChuan ,
                    CamKetThuThuat=:CamKetThuThuat ,
                    HoanThanhBenhAn=:HoanThanhBenhAn ,
                    TamUngThuThuat=:TamUngThuThuat ,
                    BHYT=:BHYT ,
					
                    CongThucMau=:CongThucMau ,
                    DongMauToanBo=:DongMauToanBo ,
                    GlucoseMau=:GlucoseMau ,
                    DienGiaiDo=:DienGiaiDo ,
                    UreCrea=:UreCrea ,
					
                    NhomMau=:NhomMau ,
                    HBsAg=:HBsAg ,
                    AntiHCV=:AntiHCV ,
                    AntiHIV=:AntiHIV ,
                    GiangMai=:GiangMai ,
                    ECG=:ECG ,
                    XQPhoi=:XQPhoi ,
                    SieuAmTim=:SieuAmTim ,
					
                    VeSinhVungBen=:VeSinhVungBen ,
                    ChuanBiDichTruyenTay=:ChuanBiDichTruyenTay ,
                    DanBenhNhanNhinAn=:DanBenhNhanNhinAn ,
                    DanBenhNhanThaoTuTrang=:DanBenhNhanThaoTuTrang ,
                    ThuTest=:ThuTest ,
					
                    MaBSChuanBi=:MaBSChuanBi ,
                    TenBSChuanBi=:TenBSChuanBi ,
                    MaDDChuanBi=:MaDDChuanBi ,
                    TenDDChuanBi=:TenDDChuanBi,


                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ketQua.MaBenhNhan));


                Command.Parameters.Add(new MDB.MDBParameter("BenhVien", ketQua.BenhVien));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa", ketQua.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("SoVaoVien", ketQua.SoVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("HoVaTen", ketQua.HoVaTen));
                Command.Parameters.Add(new MDB.MDBParameter("Tuoi", ketQua.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("Gioi", ketQua.Gioi));
                Command.Parameters.Add(new MDB.MDBParameter("CTTM", ketQua.CTTM));
                Command.Parameters.Add(new MDB.MDBParameter("Phong", ketQua.Phong));
                Command.Parameters.Add(new MDB.MDBParameter("ChuanDoan", ketQua.ChuanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("BienBanHoiChuan", ketQua.BienBanHoiChuan));
                Command.Parameters.Add(new MDB.MDBParameter("CamKetThuThuat", ketQua.CamKetThuThuat));
                Command.Parameters.Add(new MDB.MDBParameter("HoanThanhBenhAn", ketQua.HoanThanhBenhAn));

                Command.Parameters.Add(new MDB.MDBParameter("TamUngThuThuat", ketQua.TamUngThuThuat));
                Command.Parameters.Add(new MDB.MDBParameter("BHYT", ketQua.BHYT));
                Command.Parameters.Add(new MDB.MDBParameter("CongThucMau", ketQua.CongThucMau));
                Command.Parameters.Add(new MDB.MDBParameter("DongMauToanBo", ketQua.DongMauToanBo));
                Command.Parameters.Add(new MDB.MDBParameter("GlucoseMau", ketQua.GlucoseMau));
                Command.Parameters.Add(new MDB.MDBParameter("DienGiaiDo", ketQua.DienGiaiDo));
                Command.Parameters.Add(new MDB.MDBParameter("UreCrea", ketQua.UreCrea));
                Command.Parameters.Add(new MDB.MDBParameter("NhomMau", ketQua.NhomMau));

                Command.Parameters.Add(new MDB.MDBParameter("HBsAg", ketQua.HBsAg));
                Command.Parameters.Add(new MDB.MDBParameter("AntiHCV", ketQua.AntiHCV));
                Command.Parameters.Add(new MDB.MDBParameter("AntiHIV", ketQua.AntiHIV));
                Command.Parameters.Add(new MDB.MDBParameter("GiangMai", ketQua.GiangMai));
                Command.Parameters.Add(new MDB.MDBParameter("ECG", ketQua.ECG));
                Command.Parameters.Add(new MDB.MDBParameter("XQPhoi", ketQua.XQPhoi));
                Command.Parameters.Add(new MDB.MDBParameter("SieuAmTim", ketQua.SieuAmTim));
                Command.Parameters.Add(new MDB.MDBParameter("VeSinhVungBen", ketQua.VeSinhVungBen));
                Command.Parameters.Add(new MDB.MDBParameter("ChuanBiDichTruyenTay", ketQua.ChuanBiDichTruyenTay));
                Command.Parameters.Add(new MDB.MDBParameter("DanBenhNhanNhinAn", ketQua.DanBenhNhanNhinAn));
                Command.Parameters.Add(new MDB.MDBParameter("DanBenhNhanThaoTuTrang", ketQua.DanBenhNhanThaoTuTrang));
                Command.Parameters.Add(new MDB.MDBParameter("ThuTest", ketQua.ThuTest));

                Command.Parameters.Add(new MDB.MDBParameter("MaBSChuanBi", ketQua.MaBSChuanBi));
                var TenBSChuanBi = getTen(MyConnection, ketQua.MaBSChuanBi);
                Command.Parameters.Add(new MDB.MDBParameter("TenBSChuanBi", TenBSChuanBi));

                Command.Parameters.Add(new MDB.MDBParameter("MaDDChuanBi", ketQua.MaDDChuanBi));
                var TenDDChuanBi = getTen(MyConnection, ketQua.MaDDChuanBi);
                Command.Parameters.Add(new MDB.MDBParameter("TenDDChuanBi", TenDDChuanBi));

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
        public static string getTen(MDB.MDBConnection MyConnection, string maNhanVien)
        {
            try
            {
                var result = "";
                string sql = "Select HoVaTen From  NhanVien WHERE MaNhanVien = :maNhanVien";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                command.Parameters.Add(new MDB.MDBParameter("maNhanVien", maNhanVien));
                command.BindByName = true;
                MDB.MDBDataReader DataReader = command.ExecuteReader();
                while (DataReader.Read())
                {
                    result = DataReader["HoVaTen"].ToString();
                }
                return result;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return "";
        }
        public static bool delete(MDB.MDBConnection MyConnection, long id)
        {
            try
            {
                string sql = "DELETE FROM BangKiemTruocLamThuThuatChupDSA WHERE ID = :ID";
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
                BangKiemTruocLamThuThuatChupDSA P
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "KQ");

            return ds;
        }
    }
}
