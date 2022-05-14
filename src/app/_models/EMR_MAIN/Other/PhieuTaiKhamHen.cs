using EMR.KyDienTu;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuTaiKhamHen : ThongTinKy
    {
        public PhieuTaiKhamHen()
        {
            TableName = "PhieuTaiKhamHen";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PTKH;
            TenMauPhieu = DanhMucPhieu.PTKH.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public decimal ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        public int? BHYT { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }
        public string Lan { get; set; }
        public DateTime? Ngay { get; set; }
        public string SoHHK { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        public string SoHoSo { get; set; }
        public string Cao { get; set; }
        [MoTaDuLieu("Cân nặng")]
		public string CanNang { get; set; }
        [MoTaDuLieu("Mạch")]
		public string Mach { get; set; }
        [MoTaDuLieu("Huyết áp")]
		public string HuyetAp { get; set; }
        [MoTaDuLieu("Nhiệt độ")]
		public string NhietDo { get; set; }
        [MoTaDuLieu("Nhịp thở")]
		public string NhipTho { get; set; }
        public int? TrieuChungChung { get; set; }
        public int? Ho { get; set; }
        public int? KhacDam { get; set; }
        public string MauDam { get; set; }
        public int? KhoKhe { get; set; }
        public int? KhoTho { get; set; }
        public string TrieuChungMuiHong { get; set; }
        public int? TinhTrangHutThuocLa { get; set; }
        public string DieuTrenNgay { get; set; }
        public string GoiTrenNam { get; set; }
        public string ACT { get; set; }
        public int? DanhGiaNguyCo { get; set; }
        public int? KiemSoatKem { get; set; }
        public int? KichPhatThuongXuyen { get; set; }
        public int? NhapICUDoHen { get; set; }
        public int? FEVThap { get; set; }
        public int? HutThuocLa { get; set; }
        public int? LieuThuocCao { get; set; }
        public string YeuToKhoiPhatCon { get; set; }
        public int? DungCachDungLieu { get; set; }
        public int? SuDungSai { get; set; }
        public int? KhongDungLieu { get; set; }
        public int? KhongLienTuc { get; set; }
        public int? Khong { get; set; }
        public int? KhanGiong { get; set; }
        public int? KhoHong { get; set; }
        public int? NamHong { get; set; }
        public int? TangCan { get; set; }
        public int? TimDapNhanh { get; set; }
        public int? RunTay { get; set; }
        public int? ChuotRut { get; set; }
        public int? MatNgu { get; set; }
        public string Khac { get; set; }
        public string MuiHong { get; set; }
        public string Tim { get; set; }
        public int? PhoiBinhThuong { get; set; }
        public int? PhoiRanRit { get; set; }
        public int? PhoiRanNgay { get; set; }
        public int? PhoiRanAm { get; set; }
        public int? PhoiRanNo { get; set; }
        public int? PhoiGiamAmPheBao { get; set; }
        public string XQuang { get; set; }
        public string HoHapVC1 { get; set; }
        public string HoHapFEV1 { get; set; }
        public string HoHapFEV1VC { get; set; }
        public string HoHapPEF { get; set; }
        public string HoHapFEF { get; set; }
        public string HoHapRV { get; set; }
        public int? ChanDoanCOPD { get; set; }
        public int? ChanDoanHen { get; set; }
        public string GiaiDoan { get; set; }
        public int? VMDU { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoanKhac { get; set; }
        public int? MucDoKiemSoatHen { get; set; }
        public string DieuTri { get; set; }
        public string TaiKham { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
    }
    public class PhieuTaiKhamHenFunc
    {
        public const string TableName = "PhieuTaiKhamHen";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuTaiKhamHen> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuTaiKhamHen> list = new List<PhieuTaiKhamHen>();
            try
            {
                string sql = @"SELECT * FROM PhieuTaiKhamHen where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuTaiKhamHen data = new PhieuTaiKhamHen();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.BHYT = ConDB_Int(DataReader["BHYT"]);
                    data.Khoa = DataReader["Khoa"].ToString();
                    data.MaKhoa = DataReader["MaKhoa"].ToString();
                    data.Lan = DataReader["Lan"].ToString();
                    data.Ngay = Convert.ToDateTime(DataReader["Ngay"] == DBNull.Value ? DateTime.Now : DataReader["Ngay"]);
                    data.SoHHK = DataReader["SoHHK"].ToString();
                    data.TenBenhNhan = DataReader["TenBenhNhan"].ToString();
                    data.SoHoSo = DataReader["SoHoSo"].ToString();
                    data.Cao = DataReader["Cao"].ToString();
                    data.CanNang = DataReader["CanNang"].ToString();
                    data.Mach = DataReader["Mach"].ToString();
                    data.HuyetAp = DataReader["HuyetAp"].ToString();
                    data.NhietDo = DataReader["NhietDo"].ToString();
                    data.NhipTho = DataReader["NhipTho"].ToString();
                    data.TrieuChungChung = ConDB_Int(DataReader["TrieuChungChung"]);
                    data.Ho = ConDB_Int(DataReader["Ho"]);
                    data.KhacDam = ConDB_Int(DataReader["KhacDam"]);
                    data.MauDam = DataReader["MauDam"].ToString();
                    data.KhoKhe = ConDB_Int(DataReader["KhoKhe"]);
                    data.KhoTho = ConDB_Int(DataReader["KhoTho"]);
                    data.TrieuChungMuiHong = DataReader["TrieuChungMuiHong"].ToString();
                    data.TinhTrangHutThuocLa = ConDB_Int(DataReader["TinhTrangHutThuocLa"]);
                    data.DieuTrenNgay = DataReader["DieuTrenNgay"].ToString();
                    data.GoiTrenNam = DataReader["GoiTrenNam"].ToString();
                    data.ACT = DataReader["ACT"].ToString();
                    data.DanhGiaNguyCo = ConDB_Int(DataReader["DanhGiaNguyCo"]);
                    data.KiemSoatKem = ConDB_Int(DataReader["KiemSoatKem"]);
                    data.KichPhatThuongXuyen = ConDB_Int(DataReader["KichPhatThuongXuyen"]);
                    data.NhapICUDoHen = ConDB_Int(DataReader["NhapICUDoHen"]);
                    data.FEVThap = ConDB_Int(DataReader["FEVThap"]);
                    data.HutThuocLa = ConDB_Int(DataReader["HutThuocLa"]);
                    data.LieuThuocCao = ConDB_Int(DataReader["LieuThuocCao"]);
                    data.YeuToKhoiPhatCon = DataReader["YeuToKhoiPhatCon"].ToString();
                    data.DungCachDungLieu = ConDB_Int(DataReader["DungCachDungLieu"]);
                    data.KhongDungLieu = ConDB_Int(DataReader["KhongDungLieu"]);
                    data.KhongLienTuc = ConDB_Int(DataReader["KhongLienTuc"]);
                    data.Khong = ConDB_Int(DataReader["Khong"]);
                    data.KhanGiong = ConDB_Int(DataReader["KhanGiong"]);
                    data.KhoHong = ConDB_Int(DataReader["KhoHong"]);
                    data.NamHong = ConDB_Int(DataReader["NamHong"]);
                    data.TangCan = ConDB_Int(DataReader["TangCan"]);
                    data.TimDapNhanh = ConDB_Int(DataReader["TimDapNhanh"]);
                    data.RunTay = ConDB_Int(DataReader["RunTay"]);
                    data.ChuotRut = ConDB_Int(DataReader["ChuotRut"]);
                    data.MatNgu = ConDB_Int(DataReader["MatNgu"]);
                    data.Khac = DataReader.GetString("Khac");
                    data.MuiHong = DataReader.GetString("MuiHong");
                    data.PhoiBinhThuong = ConDB_Int(DataReader["PhoiBinhThuong"]);
                    data.PhoiRanRit = ConDB_Int(DataReader["PhoiRanRit"]);
                    data.PhoiRanNgay = ConDB_Int(DataReader["PhoiRanNgay"]);
                    data.PhoiRanAm = ConDB_Int(DataReader["PhoiRanAm"]);
                    data.PhoiRanNo = ConDB_Int(DataReader["PhoiRanNo"]);
                    data.PhoiGiamAmPheBao = ConDB_Int(DataReader["PhoiGiamAmPheBao"]);
                    data.XQuang = DataReader.GetString("XQuang");
                    data.HoHapVC1 = DataReader.GetString("HoHapVC1");
                    data.HoHapFEV1 = DataReader.GetString("HoHapFEV1");
                    data.HoHapFEV1VC = DataReader.GetString("HoHapFEV1VC");
                    data.HoHapPEF = DataReader.GetString("HoHapPEF");
                    data.HoHapFEF = DataReader.GetString("HoHapFEF");
                    data.HoHapRV = DataReader.GetString("HoHapRV");
                    data.ChanDoanCOPD = ConDB_Int(DataReader["ChanDoanCOPD"]);
                    data.ChanDoanHen = ConDB_Int(DataReader["ChanDoanHen"]);
                    data.GiaiDoan = DataReader.GetString("GiaiDoan");
                    data.VMDU = ConDB_Int(DataReader["VMDU"]);
                    data.ChanDoanKhac = DataReader.GetString("ChanDoanKhac");
                    data.MucDoKiemSoatHen = ConDB_Int(DataReader["MucDoKiemSoatHen"]);
                    data.DieuTri = DataReader.GetString("DieuTri");
                    data.TaiKham = DataReader.GetString("TaiKham");
                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;
                    data.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                    data.NguoiTao = DataReader["NguoiTao"].ToString();
                    data.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);
                    data.NguoiSua = DataReader["NguoiSua"].ToString();
                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuTaiKhamHen data)
        {
            try
            {
                string sql = @"insert into PhieuTaiKhamHen(MaQuanLy,BHYT,Khoa,MaKhoa,Lan,Ngay,SoHHK,TenBenhNhan,SoHoSo,Cao,CanNang,Mach,HuyetAp,NhietDo,NhipTho,TrieuChungChung,Ho,KhacDam,MauDam,KhoKhe,KhoTho,TrieuChungMuiHong,TinhTrangHutThuocLa,DieuTrenNgay,GoiTrenNam,ACT,DanhGiaNguyCo,KiemSoatKem,KichPhatThuongXuyen,NhapICUDoHen,FEVThap,HutThuocLa,LieuThuocCao,YeuToKhoiPhatCon,DungCachDungLieu,SuDungSai,KhongDungLieu,KhongLienTuc,Khong,KhanGiong,KhoHong,NamHong,TangCan,TimDapNhanh,RunTay,ChuotRut,MatNgu,Khac,MuiHong,Tim,PhoiBinhThuong,PhoiRanRit,PhoiRanNgay,PhoiRanAm,PhoiRanNo,PhoiGiamAmPheBao,XQuang,HoHapVC1,HoHapFEV1,HoHapFEV1VC,HoHapPEF,HoHapFEF,HoHapRV,ChanDoanCOPD,ChanDoanHen,GiaiDoan,VMDU,ChanDoanKhac,MucDoKiemSoatHen,DieuTri,TaiKham,NguoiTao,NguoiSua,NgayTao,NgaySua" +
                        ")";
                sql = sql + @"Values(:MaQuanLy, :BHYT, :Khoa, :MaKhoa, :Lan, :Ngay, :SoHHK, :TenBenhNhan, :SoHoSo, :Cao, :CanNang, :Mach, :HuyetAp, :NhietDo, :NhipTho, :TrieuChungChung, :Ho, :KhacDam, :MauDam, :KhoKhe, :KhoTho, :TrieuChungMuiHong, :TinhTrangHutThuocLa, :DieuTrenNgay, :GoiTrenNam, :ACT, :DanhGiaNguyCo, :KiemSoatKem, :KichPhatThuongXuyen, :NhapICUDoHen, :FEVThap, :HutThuocLa, :LieuThuocCao, :YeuToKhoiPhatCon, :DungCachDungLieu, :SuDungSai, :KhongDungLieu, :KhongLienTuc, :Khong, :KhanGiong, :KhoHong, :NamHong, :TangCan, :TimDapNhanh, :RunTay, :ChuotRut, :MatNgu, :Khac, :MuiHong, :Tim, :PhoiBinhThuong, :PhoiRanRit, :PhoiRanNgay, :PhoiRanAm, :PhoiRanNo, :PhoiGiamAmPheBao, :XQuang, :HoHapVC1, :HoHapFEV1, :HoHapFEV1VC, :HoHapPEF, :HoHapFEF, :HoHapRV, :ChanDoanCOPD, :ChanDoanHen, :GiaiDoan, :VMDU, :ChanDoanKhac, :MucDoKiemSoatHen, :DieuTri, :TaiKham, :NguoiTao, :NguoiSua, :NgayTao, :NgaySua" +
                    ")   RETURNING ID INTO :ID";
                if (data.ID != 0)
                {
                    sql = sql = "update PhieuTaiKhamHen set MaQuanLy= :MaQuanLy,BHYT = :BHYT,Khoa = :Khoa,MaKhoa = :MaKhoa,Lan = :Lan,Ngay = :Ngay,SoHHK = :SoHHK,TenBenhNhan = :TenBenhNhan,SoHoSo = :SoHoSo,Cao = :Cao,CanNang = :CanNang,Mach = :Mach,HuyetAp = :HuyetAp,NhietDo = :NhietDo,NhipTho = :NhipTho,TrieuChungChung = :TrieuChungChung,Ho = :Ho,KhacDam = :KhacDam,MauDam = :MauDam,KhoKhe = :KhoKhe,KhoTho = :KhoTho,TrieuChungMuiHong = :TrieuChungMuiHong,TinhTrangHutThuocLa = :TinhTrangHutThuocLa,DieuTrenNgay = :DieuTrenNgay,GoiTrenNam = :GoiTrenNam,ACT = :ACT,DanhGiaNguyCo = :DanhGiaNguyCo,KiemSoatKem = :KiemSoatKem,KichPhatThuongXuyen = :KichPhatThuongXuyen,NhapICUDoHen = :NhapICUDoHen,FEVThap = :FEVThap,HutThuocLa = :HutThuocLa,LieuThuocCao = :LieuThuocCao,YeuToKhoiPhatCon = :YeuToKhoiPhatCon,DungCachDungLieu = :DungCachDungLieu,SuDungSai = :SuDungSai,KhongDungLieu = :KhongDungLieu,KhongLienTuc = :KhongLienTuc,Khong = :Khong,KhanGiong = :KhanGiong,KhoHong = :KhoHong,NamHong = :NamHong,TangCan = :TangCan,TimDapNhanh = :TimDapNhanh,RunTay = :RunTay,ChuotRut = :ChuotRut,MatNgu = :MatNgu,Khac = :Khac,MuiHong = :MuiHong,Tim = :Tim,PhoiBinhThuong = :PhoiBinhThuong,PhoiRanRit = :PhoiRanRit,PhoiRanNgay = :PhoiRanNgay,PhoiRanAm = :PhoiRanAm,PhoiRanNo = :PhoiRanNo,PhoiGiamAmPheBao = :PhoiGiamAmPheBao,XQuang = :XQuang,HoHapVC1 = :HoHapVC1,HoHapFEV1 = :HoHapFEV1,HoHapFEV1VC = :HoHapFEV1VC,HoHapPEF = :HoHapPEF,HoHapFEF = :HoHapFEF,HoHapRV = :HoHapRV,ChanDoanCOPD = :ChanDoanCOPD,ChanDoanHen = :ChanDoanHen,GiaiDoan = :GiaiDoan,VMDU = :VMDU,ChanDoanKhac = :ChanDoanKhac,MucDoKiemSoatHen = :MucDoKiemSoatHen,DieuTri = :DieuTri,TaiKham = :TaiKham,NguoiTao = :NguoiTao,NguoiSua = :NguoiSua,NgayTao = :NgayTao,NgaySua  = :NgaySua";
                    sql = sql + " WHERE ID = " + data.ID.ToString();
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", data.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("BHYT", data.BHYT));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa", data.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaKhoa", data.MaKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("Lan", data.Lan));
                Command.Parameters.Add(new MDB.MDBParameter("Ngay", data.Ngay));
                Command.Parameters.Add(new MDB.MDBParameter("SoHHK", data.SoHHK));
                Command.Parameters.Add(new MDB.MDBParameter("TenBenhNhan", data.TenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("SoHoSo", data.SoHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("Cao", data.Cao));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang", data.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("Mach", data.Mach));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetAp", data.HuyetAp));
                Command.Parameters.Add(new MDB.MDBParameter("NhietDo", data.NhietDo));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTho", data.NhipTho));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungChung", data.TrieuChungChung));
                Command.Parameters.Add(new MDB.MDBParameter("Ho", data.Ho));
                Command.Parameters.Add(new MDB.MDBParameter("KhacDam", data.KhacDam));
                Command.Parameters.Add(new MDB.MDBParameter("MauDam", data.MauDam));
                Command.Parameters.Add(new MDB.MDBParameter("KhoKhe", data.KhoKhe));
                Command.Parameters.Add(new MDB.MDBParameter("KhoTho", data.KhoTho));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungMuiHong", data.TrieuChungMuiHong));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangHutThuocLa", data.TinhTrangHutThuocLa));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTrenNgay", data.DieuTrenNgay));
                Command.Parameters.Add(new MDB.MDBParameter("GoiTrenNam", data.GoiTrenNam));
                Command.Parameters.Add(new MDB.MDBParameter("ACT", data.ACT));
                Command.Parameters.Add(new MDB.MDBParameter("DanhGiaNguyCo", data.DanhGiaNguyCo));
                Command.Parameters.Add(new MDB.MDBParameter("KiemSoatKem", data.KiemSoatKem));
                Command.Parameters.Add(new MDB.MDBParameter("KichPhatThuongXuyen", data.KichPhatThuongXuyen));
                Command.Parameters.Add(new MDB.MDBParameter("NhapICUDoHen", data.NhapICUDoHen));
                Command.Parameters.Add(new MDB.MDBParameter("FEVThap", data.FEVThap));
                Command.Parameters.Add(new MDB.MDBParameter("HutThuocLa", data.HutThuocLa));
                Command.Parameters.Add(new MDB.MDBParameter("LieuThuocCao", data.LieuThuocCao));
                Command.Parameters.Add(new MDB.MDBParameter("YeuToKhoiPhatCon", data.YeuToKhoiPhatCon));
                Command.Parameters.Add(new MDB.MDBParameter("DungCachDungLieu", data.DungCachDungLieu));
                Command.Parameters.Add(new MDB.MDBParameter("SuDungSai", data.SuDungSai));
                Command.Parameters.Add(new MDB.MDBParameter("KhongDungLieu", data.KhongDungLieu));
                Command.Parameters.Add(new MDB.MDBParameter("KhongLienTuc", data.KhongLienTuc));
                Command.Parameters.Add(new MDB.MDBParameter("Khong", data.Khong));
                Command.Parameters.Add(new MDB.MDBParameter("KhanGiong", data.KhanGiong));
                Command.Parameters.Add(new MDB.MDBParameter("KhoHong", data.KhoHong));
                Command.Parameters.Add(new MDB.MDBParameter("NamHong", data.NamHong));
                Command.Parameters.Add(new MDB.MDBParameter("TangCan", data.TangCan));
                Command.Parameters.Add(new MDB.MDBParameter("TimDapNhanh", data.TimDapNhanh));
                Command.Parameters.Add(new MDB.MDBParameter("RunTay", data.RunTay));
                Command.Parameters.Add(new MDB.MDBParameter("ChuotRut", data.ChuotRut));
                Command.Parameters.Add(new MDB.MDBParameter("MatNgu", data.MatNgu));
                Command.Parameters.Add(new MDB.MDBParameter("Khac", data.Khac));
                Command.Parameters.Add(new MDB.MDBParameter("MuiHong", data.MuiHong));
                Command.Parameters.Add(new MDB.MDBParameter("Tim", data.Tim));
                Command.Parameters.Add(new MDB.MDBParameter("PhoiBinhThuong", data.PhoiBinhThuong));
                Command.Parameters.Add(new MDB.MDBParameter("PhoiRanRit", data.PhoiRanRit));
                Command.Parameters.Add(new MDB.MDBParameter("PhoiRanNgay", data.PhoiRanNgay));
                Command.Parameters.Add(new MDB.MDBParameter("PhoiRanAm", data.PhoiRanAm));
                Command.Parameters.Add(new MDB.MDBParameter("PhoiRanNo", data.PhoiRanNo));
                Command.Parameters.Add(new MDB.MDBParameter("PhoiGiamAmPheBao", data.PhoiGiamAmPheBao));
                Command.Parameters.Add(new MDB.MDBParameter("XQuang", data.XQuang));
                Command.Parameters.Add(new MDB.MDBParameter("HoHapVC1", data.HoHapVC1));
                Command.Parameters.Add(new MDB.MDBParameter("HoHapFEV1", data.HoHapFEV1));
                Command.Parameters.Add(new MDB.MDBParameter("HoHapFEV1VC", data.HoHapFEV1VC));
                Command.Parameters.Add(new MDB.MDBParameter("HoHapPEF", data.HoHapPEF));
                Command.Parameters.Add(new MDB.MDBParameter("HoHapFEF", data.HoHapFEF));
                Command.Parameters.Add(new MDB.MDBParameter("HoHapRV", data.HoHapRV));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanCOPD", data.ChanDoanCOPD));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanHen", data.ChanDoanHen));
                Command.Parameters.Add(new MDB.MDBParameter("GiaiDoan", data.GiaiDoan));
                Command.Parameters.Add(new MDB.MDBParameter("VMDU", data.VMDU));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanKhac", data.ChanDoanKhac));
                Command.Parameters.Add(new MDB.MDBParameter("MucDoKiemSoatHen", data.MucDoKiemSoatHen));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri", data.DieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TaiKham", data.TaiKham));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiTao", data.NguoiTao));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiSua", data.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NgayTao", data.NgayTao));
                Command.Parameters.Add(new MDB.MDBParameter("NgaySua ", DateTime.Now));
                if (data.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", data.ID));
                }
                //Command.BindByName = true;
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
        public static bool Delete(MDB.MDBConnection MyConnection, decimal id)
        {
            try
            {
                string sql = "DELETE FROM PhieuTaiKhamHen WHERE ID = :ID";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                command.Parameters.Add(new MDB.MDBParameter("ID", id));
                command.BindByName = true;
                int n = command.ExecuteNonQuery();
                return n > 0;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static DataSet GetData(MDB.MDBConnection MyConnection, decimal id)
        {
            string sql = @"SELECT
                B.*
            FROM
                PhieuTaiKhamHen B
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            adt.Fill(ds,"PTK");

            return ds;
        }

        public static int ConDB_Int(object dbVal, int valDefault = 0)
        {
            int ret = valDefault;
            if (dbVal == null)
            {
                return ret;
            }
            bool isSuccess = int.TryParse(dbVal.ToString(), out ret);
            if (!isSuccess)
            {
                return valDefault;
            }
            return ret;
        }
    }
}