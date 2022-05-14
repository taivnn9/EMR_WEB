using EMR.KyDienTu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.Access;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuYCSDKhangSinhHCPD : ThongTinKy
    {
        public PhieuYCSDKhangSinhHCPD()
        {
            TableName = "PhieuYCSDKhangSinhHCPD";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PYCSDKSHCPD;
            TenMauPhieu = DanhMucPhieu.PYCSDKSHCPD.Description();
        }
        public long ID { get; set; }
        public decimal MaQuanLy { get; set; }
        public string MaBenhNhan { get; set; }
        public string MaBenhAn { get; set; }
        public string HoTen { get; set; }
        public string Tuoi { get; set; }
        public string GioiTinh { get; set; }
        public string CanNang { get; set; }
        public string ChieuCao { get; set; }
        public string Khoa { get; set; }
        public string MaKhoa { get; set; }
        public DateTime? NgayYeuCau { get; set; }
        public string DiUng { get; set; }
        public bool[] ChanDoanBenhNhiemKhuan_Array { get; } = new bool[] { false, false, false, false, false, false, false, false, false, false, false };
        public string ChanDoanBenhNhiemKhuan
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ChanDoanBenhNhiemKhuan_Array.Length; i++)
                    temp += (ChanDoanBenhNhiemKhuan_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ChanDoanBenhNhiemKhuan_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Bệnh mắc kèm")]
        public string BenhMacKem { get; set; }
        [MoTaDuLieu("Tình trạng LS khi hội chẩn")]
        public string TinhTrangLSKhiHC { get; set; }
        public string NhietDo { get; set; }
        public string BachCau { get; set; }
        public string CRP { get; set; }
        public string PCT { get; set; }
        [MoTaDuLieu("Kết quả CLS khác, dịch não tùy, nước tiểu, chẩn đoán hình ảnh")]
        public string Khac { get; set; }
        [MoTaDuLieu("ml/ph")]
        public string CrCL { get; set; }
        [MoTaDuLieu("Lọc máu HD, 1: có, 2: không")]
        public int LocMauHD { get; set; }
        [MoTaDuLieu("Lọc máu liên tục, 1: có, 2: không")]
        public int LocMauLienTuc { get; set; }
        [MoTaDuLieu("Lý do không làm xét nghiệm vi sinh")]
        public string LyDoKhongXNViSinh { get; set; }
        [MoTaDuLieu("Kết quả xét nghiệm vi sinh")]
        public ObservableCollection<XetNghiemViSinh> XetNghiem { get; set; }
        [MoTaDuLieu("Phác đồ KS đang điều trị (ngày điều trị)")]
        public string PhacDoKSDangDieuTri { get; set; }
        public bool[] LyDoDungPhacDo_Array { get; } = new bool[] { false, false, false, false};
        [MoTaDuLieu("Lý do dùng phác đồ KSƯTQL")]
        public string LyDoDungPhacDo
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < LyDoDungPhacDo_Array.Length; i++)
                    temp += (LyDoDungPhacDo_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        LyDoDungPhacDo_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string KhangSinhGapADR { get; set; }
        [MoTaDuLieu("Lý do khác dùng phác đồ KSƯTQL")]
        public string LyDo_Khac { get; set; }
        [MoTaDuLieu("Phác đồ kháng sinh yêu cầu")]
        public ObservableCollection<PhacDoKSYeuCau> PhacDo { get; set; }
        public string BacSyDieuTri { get; set; }
        public string MaBacSyDieuTri { get; set; }
        public string LanhDaoKhoaLamSang { get; set; }
        public string MaLanhDaoKhoaLamSang { get; set; }
        [MoTaDuLieu("Lãnh đạo thống nhất sử dụng, 1: có, 2: không")]
        public int ThongNhat { get; set; }
        public string YKienKhac { get; set; }
        public string LanhDaoBenhVien { get; set; }
        public string MaLanhDaoBenhVien { get; set; }
        public bool DaKy { get; set; }
        public DateTime NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime NgaySua { get; set; }
        public string NguoiSua { get; set; }
        public bool Chon { get; set; }

    }
    public class XetNghiemViSinh
    {
        [MoTaDuLieu("Bệnh phẩm")]
        public string BenhPham { get; set; }
        [MoTaDuLieu("Ngày cấy")]
        public DateTime? NgayCay { get; set; }
        [MoTaDuLieu("Ngày trả")]
        public DateTime? NgayTra { get; set; }
        [MoTaDuLieu("Kết quả VK nấm, KS đồ")]
        public string KetQua { get; set; }
    }
    public class PhacDoKSYeuCau
    {
        [MoTaDuLieu("Kháng sinh, tên hoạt chât, hàm lượng")]
        public string KS { get; set; }
        [MoTaDuLieu("Liều dùng/lần (liều nạp nếu có)")]
        public string LD { get; set; }
        [MoTaDuLieu("Khoảng cách dùng")]
        public string KCD { get; set; }
        [MoTaDuLieu("Cách dùng")]
        public string CD { get; set; }
        [MoTaDuLieu("Thời gian điều trị (ngày)")]
        public string TG { get; set; }
    }
    public class PhieuYCSDKhangSinhHCPDFunc
    {
        public const string TableName = "PhieuYCSDKhangSinhHCPD";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuYCSDKhangSinhHCPD> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuYCSDKhangSinhHCPD> list = new List<PhieuYCSDKhangSinhHCPD>();
            try
            {
                string sql = @"SELECT * FROM PhieuYCSDKhangSinhHCPD where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuYCSDKhangSinhHCPD data = new PhieuYCSDKhangSinhHCPD();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.MaBenhAn = DataReader["MaBenhAn"].ToString();
                    data.CanNang = DataReader["CanNang"].ToString();
                    data.ChieuCao = DataReader["ChieuCao"].ToString();
                    data.Khoa = DataReader["Khoa"].ToString();
                    data.MaKhoa = DataReader["MaKhoa"].ToString();
                    data.NgayYeuCau = DataReader["NgayYeuCau"] != DBNull.Value ? (DateTime?) Convert.ToDateTime(DataReader["NgayYeuCau"].ToString()) : null;
                    data.DiUng = DataReader["DiUng"].ToString();
                    data.ChanDoanBenhNhiemKhuan = DataReader["ChanDoanBenhNhiemKhuan"].ToString();
                    data.BenhMacKem = DataReader["BenhMacKem"].ToString();
                    data.TinhTrangLSKhiHC = DataReader["TinhTrangLSKhiHC"].ToString();
                    data.NhietDo = DataReader["NhietDo"].ToString();
                    data.BachCau = DataReader["BachCau"].ToString();
                    data.CRP = DataReader["CRP"].ToString();
                    data.PCT = DataReader["PCT"].ToString();
                    data.Khac = DataReader["Khac"].ToString();
                    data.CrCL = DataReader["CrCL"].ToString();
                    int tempInt = 0;
                    data.LocMauHD = int.TryParse(DataReader["LocMauHD"].ToString(), out tempInt) ? tempInt : 0;
                    data.LocMauLienTuc = int.TryParse(DataReader["LocMauLienTuc"].ToString(), out tempInt) ? tempInt : 0;
                    data.LyDoKhongXNViSinh = DataReader["LyDoKhongXNViSinh"].ToString();
                    data.XetNghiem = JsonConvert.DeserializeObject<ObservableCollection<XetNghiemViSinh>>(DataReader["XetNghiem"].ToString());
                    data.PhacDoKSDangDieuTri = DataReader["PhacDoKSDangDieuTri"].ToString();
                    data.LyDoDungPhacDo = DataReader["LyDoDungPhacDo"].ToString();
                    data.KhangSinhGapADR = DataReader["KhangSinhGapADR"].ToString();
                    data.LyDo_Khac = DataReader["LyDo_Khac"].ToString();
                    data.PhacDo = JsonConvert.DeserializeObject<ObservableCollection<PhacDoKSYeuCau>>(DataReader["PhacDo"].ToString());
                    data.BacSyDieuTri = DataReader["BacSyDieuTri"].ToString();
                    data.MaBacSyDieuTri = DataReader["MaBacSyDieuTri"].ToString();
                    data.LanhDaoKhoaLamSang = DataReader["LanhDaoKhoaLamSang"].ToString();
                    data.MaLanhDaoKhoaLamSang = DataReader["MaLanhDaoKhoaLamSang"].ToString();
                    data.ThongNhat = int.TryParse(DataReader["ThongNhat"].ToString(), out tempInt) ? tempInt : 0;
                    data.YKienKhac = DataReader["YKienKhac"].ToString();
                    data.LanhDaoBenhVien = DataReader["LanhDaoBenhVien"].ToString();
                    data.MaLanhDaoBenhVien = DataReader["MaLanhDaoBenhVien"].ToString();

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuYCSDKhangSinhHCPD ketQua)
        {
            try
            {
                string sql = @"INSERT INTO PhieuYCSDKhangSinhHCPD
                (
                    MAQUANLY,
                    MaBenhNhan,
                    MaBenhAn,
                    CanNang,
                    ChieuCao,
                    Khoa,
                    MaKhoa,
                    NgayYeuCau,
                    DiUng,
                    ChanDoanBenhNhiemKhuan,
                    BenhMacKem,
                    TinhTrangLSKhiHC,
                    NhietDo,
                    BachCau,
                    CRP,
                    PCT,
                    Khac,
                    CrCL,
                    LocMauHD,
                    LocMauLienTuc,
                    LyDoKhongXNViSinh,
                    XetNghiem,
                    PhacDoKSDangDieuTri,
                    LyDoDungPhacDo,
                    KhangSinhGapADR,
                    LyDo_Khac,
                    PhacDo,
                    BacSyDieuTri,
                    MaBacSyDieuTri,
                    LanhDaoKhoaLamSang,
                    MaLanhDaoKhoaLamSang,
                    ThongNhat,
                    YKienKhac,
                    LanhDaoBenhVien,
                    MaLanhDaoBenhVien,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :MaBenhAn,
                    :CanNang,
                    :ChieuCao,
                    :Khoa,
                    :MaKhoa,
                    :NgayYeuCau,
                    :DiUng,
                    :ChanDoanBenhNhiemKhuan,
                    :BenhMacKem,
                    :TinhTrangLSKhiHC,
                    :NhietDo,
                    :BachCau,
                    :CRP,
                    :PCT,
                    :Khac,
                    :CrCL,
                    :LocMauHD,
                    :LocMauLienTuc,
                    :LyDoKhongXNViSinh,
                    :XetNghiem,
                    :PhacDoKSDangDieuTri,
                    :LyDoDungPhacDo,
                    :KhangSinhGapADR,
                    :LyDo_Khac,
                    :PhacDo,
                    :BacSyDieuTri,
                    :MaBacSyDieuTri,
                    :LanhDaoKhoaLamSang,
                    :MaLanhDaoKhoaLamSang,
                    :ThongNhat,
                    :YKienKhac,
                    :LanhDaoBenhVien,
                    :MaLanhDaoBenhVien,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE PhieuYCSDKhangSinhHCPD SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    MaBenhAn=:MaBenhAn,
                    CanNang=:CanNang,
                    ChieuCao=:ChieuCao,
                    Khoa=:Khoa,
                    MaKhoa=:MaKhoa,
                    NgayYeuCau=:NgayYeuCau,
                    DiUng=:DiUng,
                    ChanDoanBenhNhiemKhuan=:ChanDoanBenhNhiemKhuan,
                    BenhMacKem=:BenhMacKem,
                    TinhTrangLSKhiHC=:TinhTrangLSKhiHC,
                    NhietDo=:NhietDo,
                    BachCau=:BachCau,
                    CRP=:CRP,
                    PCT=:PCT,
                    Khac=:Khac,
                    CrCL=:CrCL,
                    LocMauHD=:LocMauHD,
                    LocMauLienTuc=:LocMauLienTuc,
                    LyDoKhongXNViSinh=:LyDoKhongXNViSinh,
                    XetNghiem=:XetNghiem,
                    PhacDoKSDangDieuTri=:PhacDoKSDangDieuTri,
                    LyDoDungPhacDo=:LyDoDungPhacDo,
                    KhangSinhGapADR=:KhangSinhGapADR,
                    LyDo_Khac =:LyDo_Khac,
                    PhacDo=:PhacDo,
                    BacSyDieuTri =:BacSyDieuTri,
                    MaBacSyDieuTri =:MaBacSyDieuTri,
                    LanhDaoKhoaLamSang =:LanhDaoKhoaLamSang,
                    MaLanhDaoKhoaLamSang =:MaLanhDaoKhoaLamSang,
                    ThongNhat=:ThongNhat,
                    YKienKhac =:YKienKhac,
                    LanhDaoBenhVien =:LanhDaoBenhVien,
                    MaLanhDaoBenhVien=:MaLanhDaoBenhVien,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ketQua.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhAn", ketQua.MaBenhAn));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang", ketQua.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("ChieuCao", ketQua.ChieuCao));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa", ketQua.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaKhoa", ketQua.MaKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("NgayYeuCau", ketQua.NgayYeuCau));
                Command.Parameters.Add(new MDB.MDBParameter("DiUng", ketQua.DiUng));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanBenhNhiemKhuan", ketQua.ChanDoanBenhNhiemKhuan));
                Command.Parameters.Add(new MDB.MDBParameter("BenhMacKem", ketQua.BenhMacKem));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangLSKhiHC", ketQua.TinhTrangLSKhiHC));
                Command.Parameters.Add(new MDB.MDBParameter("NhietDo", ketQua.NhietDo));
                Command.Parameters.Add(new MDB.MDBParameter("BachCau", ketQua.BachCau));
                Command.Parameters.Add(new MDB.MDBParameter("CRP", ketQua.CRP));
                Command.Parameters.Add(new MDB.MDBParameter("PCT", ketQua.PCT));
                Command.Parameters.Add(new MDB.MDBParameter("Khac", ketQua.Khac));
                Command.Parameters.Add(new MDB.MDBParameter("CrCL", ketQua.CrCL));
                Command.Parameters.Add(new MDB.MDBParameter("LocMauHD", ketQua.LocMauHD));
                Command.Parameters.Add(new MDB.MDBParameter("LocMauLienTuc", ketQua.LocMauLienTuc));
                Command.Parameters.Add(new MDB.MDBParameter("LyDoKhongXNViSinh", ketQua.LyDoKhongXNViSinh));
                Command.Parameters.Add(new MDB.MDBParameter("XetNghiem", JsonConvert.SerializeObject(ketQua.XetNghiem)));
                Command.Parameters.Add(new MDB.MDBParameter("PhacDoKSDangDieuTri", ketQua.PhacDoKSDangDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("LyDoDungPhacDo", ketQua.LyDoDungPhacDo));
                Command.Parameters.Add(new MDB.MDBParameter("KhangSinhGapADR", ketQua.KhangSinhGapADR));
                Command.Parameters.Add(new MDB.MDBParameter("LyDo_Khac", ketQua.LyDo_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("PhacDo", JsonConvert.SerializeObject(ketQua.PhacDo)));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", ketQua.BacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSyDieuTri", ketQua.MaBacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("LanhDaoKhoaLamSang", ketQua.LanhDaoKhoaLamSang));
                Command.Parameters.Add(new MDB.MDBParameter("MaLanhDaoKhoaLamSang", ketQua.MaLanhDaoKhoaLamSang));
                Command.Parameters.Add(new MDB.MDBParameter("ThongNhat", ketQua.ThongNhat));
                Command.Parameters.Add(new MDB.MDBParameter("YKienKhac", ketQua.YKienKhac));
                Command.Parameters.Add(new MDB.MDBParameter("LanhDaoBenhVien", ketQua.LanhDaoBenhVien));
                Command.Parameters.Add(new MDB.MDBParameter("MaLanhDaoBenhVien", ketQua.MaLanhDaoBenhVien));

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
                string sql = "DELETE FROM PhieuYCSDKhangSinhHCPD WHERE ID = :ID";
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
                P.MAQUANLY,
                P.MaBenhNhan,
                P.MaBenhAn,
                P.CanNang,
                P.ChieuCao,
                P.Khoa,
                P.MaKhoa,
                P.NgayYeuCau,
                P.DiUng,
                P.ChanDoanBenhNhiemKhuan,
                P.BenhMacKem,
                P.TinhTrangLSKhiHC,
                P.NhietDo,
                P.BachCau,
                P.CRP,
                P.PCT,
                P.Khac,
                P.CrCL,
                P.LocMauHD,
                P.LocMauLienTuc,
                P.LyDoKhongXNViSinh,
                P.PhacDoKSDangDieuTri,
                P.LyDoDungPhacDo,
                P.KhangSinhGapADR,
                P.LyDo_Khac,
                P.BacSyDieuTri,
                P.MaBacSyDieuTri,
                P.LanhDaoKhoaLamSang,
                P.MaLanhDaoKhoaLamSang,
                P.ThongNhat,
                P.YKienKhac,
                P.LanhDaoBenhVien,
                P.MaLanhDaoBenhVien
            FROM
                PhieuYCSDKhangSinhHCPD P
            WHERE
                P.ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "KQ");

            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(int));
            ds.Tables[0].AddColumn("SOYTE", typeof(string));
            ds.Tables[0].AddColumn("BENHVIEN", typeof(string));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["GioiTinh"] = (int)XemBenhAn._HanhChinhBenhNhan.GioiTinh;
            ds.Tables[0].Rows[0]["SOYTE"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;

            sql = @"SELECT P.XetNghiem, P.PhacDo FROM PhieuYCSDKhangSinhHCPD P where P.ID = :ID";
            Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("ID", id));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            ObservableCollection<XetNghiemViSinh> XetNghiem = new ObservableCollection<XetNghiemViSinh>();
            ObservableCollection<PhacDoKSYeuCau> PhacDo = new ObservableCollection<PhacDoKSYeuCau>();
            while (DataReader.Read())
            {
                XetNghiem = JsonConvert.DeserializeObject<ObservableCollection<XetNghiemViSinh>>(DataReader["XetNghiem"].ToString());
                PhacDo = JsonConvert.DeserializeObject<ObservableCollection<PhacDoKSYeuCau>>(DataReader["PhacDo"].ToString());
            }
            ds.Tables.Add(Common.ListToDataTable(XetNghiem, "XN"));
            ds.Tables.Add(Common.ListToDataTable(PhacDo, "PD"));

            return ds;
        }
    }
}
