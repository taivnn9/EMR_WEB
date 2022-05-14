using EMR.KyDienTu;
using MDB;
using Newtonsoft.Json;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EMR_MAIN.DATABASE.Other
{
    public class ListTenThuoc
    {
        [MoTaDuLieu("Mã thuốc")]
        public string ID { get; set; }
        [MoTaDuLieu("Tên thuốc")]
        public string Name { get; set; }
    }
    public class ThongTinThuoc
    {
        public ThongTinThuoc()
        {
            NoiDungChiTiets = new ObservableCollection<ChiTietThuoc>();
        }
        public string Ten { get; set; }
        public ObservableCollection<ChiTietThuoc> NoiDungChiTiets { get; set; }
        public ThongTinThuoc Clone(ThongTinThuoc obj)
        {
            ThongTinThuoc other = (ThongTinThuoc)obj.MemberwiseClone();
            other.NoiDungChiTiets = new ObservableCollection<ChiTietThuoc>();
            if (this.NoiDungChiTiets != null)
                foreach (ChiTietThuoc item in this.NoiDungChiTiets)
                {
                    other.NoiDungChiTiets.Add(item.Clone(item));
                }
            return other;
        }
    }
    static class Extensions
    {
        public static void Sort<T>(this ObservableCollection<T> collection) where T : IComparable
        {
            List<T> sorted = collection.OrderBy(x => x).ToList();
            for (int i = 0; i < sorted.Count(); i++)
                collection.Move(collection.IndexOf(sorted[i]), i);
        }
    }
    public class ChiTietThuoc
    {
        [MoTaDuLieu("Thời gian sử dụng thuốc")]
        public string ThoiGian { get; set; }
        [MoTaDuLieu("Hàm lượng sử dụng thuốc")]
        public string HamLuong { get; set; }
        public ChiTietThuoc Clone(ChiTietThuoc obj)
        {
            return (ChiTietThuoc)obj.MemberwiseClone();
        }
    }
    public class ThongTinSinhTonHoHap
    {
        [MoTaDuLieu("Dấu hiệu sinh tồn-hô hấp-nước tiểu: Thời gian")]
        public DateTime ThoiGian { get; set; }
        [MoTaDuLieu("Dấu hiệu sinh tồn-hô hấp-nước tiểu: Mạch")]
        public float? Mach { get; set; }
        [MoTaDuLieu("Dấu hiệu sinh tồn-hô hấp-nước tiểu: Huyết áp thấp nhất")]
        public float? HAMin { get; set; }
        [MoTaDuLieu("Dấu hiệu sinh tồn-hô hấp-nước tiểu: Huyết áp cao nhất")]
        public float? HAMax { get; set; }
        [MoTaDuLieu("Dấu hiệu sinh tồn-hô hấp-nước tiểu: Nhiệt độ")]
        public float? NhietDo { get; set; }
        [MoTaDuLieu("Dấu hiệu sinh tồn-hô hấp-nước tiểu: Mode")]
        public string Mode { get; set; }
        [MoTaDuLieu("Dấu hiệu sinh tồn-hô hấp-nước tiểu: SpO2")]
        public string SPO2 { get; set; }
        [MoTaDuLieu("Dấu hiệu sinh tồn-hô hấp-nước tiểu: F")]
        public string HoHap_F { get; set; }
        [MoTaDuLieu("Dấu hiệu sinh tồn-hô hấp-nước tiểu: Nước tiểu")]
		public string NuocTieu { get; set; }
        public ThongTinSinhTonHoHap Clone(ThongTinSinhTonHoHap obj)
        {
            return (ThongTinSinhTonHoHap)obj.MemberwiseClone();
        }
    }

    public class BangTheoDoiBenhNhanCTMVTbl : ThongTinKy
    {
        public BangTheoDoiBenhNhanCTMVTbl()
        {
            TableName = "BangTheoDoiBenhNhanCTMV";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BTDBNCTMV;
            TenMauPhieu = DanhMucPhieu.BTDBNCTMV.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public string CanThiep { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }
        [MoTaDuLieu("Thông tin sinh tồn-hô hấp-nước tiểu: trước can thiệp")]
        public ObservableCollection<ThongTinSinhTonHoHap> TTTheoDoiTruocCT { get; set; }
        [MoTaDuLieu("Thông tin sinh tồn-hô hấp-nước tiểu: trong can thiệp")]
        public ObservableCollection<ThongTinSinhTonHoHap> TTTheoDoiTrongCT { get; set; }
        [MoTaDuLieu("Thông tin sinh tồn-hô hấp-nước tiểu: Sau can thiệp")]
        public ObservableCollection<ThongTinSinhTonHoHap> TTTheoDoiSauCT { get; set; }

        [MoTaDuLieu("Thông tin thuốc: trước can thiệp")]
        public ObservableCollection<ThongTinThuoc> ThuocTruocCT { get; set; }
        [MoTaDuLieu("Thông tin thuốc: trong can thiệp")]
        public ObservableCollection<ThongTinThuoc> ThuocTrongCT { get; set; }
        [MoTaDuLieu("Thông tin thuốc: Sau can thiệp")]
        public ObservableCollection<ThongTinThuoc> ThuocSauCT { get; set; }
        [MoTaDuLieu("Tình trạng người bệnh trước can thiệp")]
        public string TTNguoiBenhTruocCT { get; set; }
        [MoTaDuLieu("Tình trạng người bệnh trong can thiệp")]
        public string TTNguoiBenhTrongCT { get; set; }
        [MoTaDuLieu("Tình trạng người bệnh sau can thiệp")]
        public string TTNguoiBenhSauCT { get; set; }
        [MoTaDuLieu("Họ và tên điều dưỡng trước can thiệp")]
        public string TenDDTruocCT { get; set; }
        [MoTaDuLieu("Mã điều dưỡng trước can thiệp")]
        public string MaDDTruocCT { get; set; }
        [MoTaDuLieu("Họ và tên điều dưỡng trong can thiệp")]
        public string TenDDTrongCT { get; set; }
        [MoTaDuLieu("Mã điều dưỡng trong can thiệp")]
        public string MaDDTrongCT { get; set; }
        [MoTaDuLieu("Họ và tên điều dưỡng sau can thiệp")]
        public string TenDDDSauCT { get; set; }
        [MoTaDuLieu("Mã điều dưỡng sau can thiệp")]
        public string MaDDSauCT { get; set; }
        [MoTaDuLieu("Bàn giao khoa lâm sàng: Vị trí chọc ĐM")]
        public string BGLS_DM { get; set; }
        [MoTaDuLieu("Bàn giao khoa lâm sàng: Vị trí chọc TM")]
        public string BGLS_TM { get; set; }
        [MoTaDuLieu("Bàn giao khoa lâm sàng: Giờ băng ép")]
        public string BGLS_GioBangEp { get; set; }
        [MoTaDuLieu("Thông tin khoa TMCT")]
        public string[] KhoaTMCT { get; set; } = new string[11];
        [MoTaDuLieu("Thông tin khoa lâm sàng")]
        public string[] KhoaLS { get; set; } = new string[11];

        [MoTaDuLieu("Số lần chọc mạch")]
        public int? ChocMach_SoLan { get; set; }
        [MoTaDuLieu("Vị trí chọc mạch")]
        public int? ChocMach_ViTri { get; set; }
        [MoTaDuLieu("Chỉ định sử dụng thuốc chống đông sau can thiệp")]
        public int? ChiDinhSDThuoc { get; set; }
        [MoTaDuLieu("Người bệnh có thể ăn uống khi nào?")]
        public string NBAnUong { get; set; }
        [MoTaDuLieu("Khoa chuyển đến")]
        public string KhoaChuyenDen { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng nhận người bệnh")]
		public string DieuDuongNhanNB { get; set; }
        [MoTaDuLieu("Mã điều dưỡng nhận người bệnh")]
        public string MaNVDieuDuongNhanNB { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Ngày thực hiện thuốc")]
        public DateTime NgayThucHienThuoc { get; set; }
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
    public class BangTheoDoiBenhNhanCTMVTblFunc
    {
        public const string TableName = "BangTheoDoiChamSocNB";
        public const string TableName2 = "BangTheoDoiBenhNhanCTMV";
        public const string TablePrimaryKeyName = "ID";
        public static List<BangTheoDoiBenhNhanCTMVTbl> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly, int loaiRpt, decimal IDphieu = -1)
        {
            List<BangTheoDoiBenhNhanCTMVTbl> list = new List<BangTheoDoiBenhNhanCTMVTbl>();
            try
            {
                string tblName = string.Empty;
                if (loaiRpt == (int)LoaiPhieuTDCS.BTDCSNB)
                {
                    tblName = TableName;
                }
                else if (loaiRpt == (int)LoaiPhieuTDCS.BTDBNCTMV)
                {
                    tblName = TableName2;
                }
                string sql = @"SELECT * FROM " + tblName + " where MaQuanLy = :MaQuanLy";
                if (IDphieu > 0)
                {
                    sql = sql + "  and ID = " + IDphieu.ToString()
;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    try
                    {
                        BangTheoDoiBenhNhanCTMVTbl data = new BangTheoDoiBenhNhanCTMVTbl();
                        data.ID = DataReader.GetLong("ID");
                        data.MaQuanLy = Common.ConDB_Decimal(DataReader["MaQuanLy"]);
                        data.MaBenhNhan = Common.ConDBNull(DataReader["MaBenhNhan"]);
                        data.TenBenhNhan = Common.ConDBNull(DataReader["TenBenhNhan"]);
                        data.Tuoi = Common.ConDBNull(DataReader["Tuoi"]);
                        data.GioiTinh = Common.ConDBNull(DataReader["GioiTinh"]);
                        data.ChanDoan = Common.ConDBNull(DataReader["ChanDoan"]);
                        data.CanThiep = Common.ConDBNull(DataReader["CanThiep"]);
                        data.Khoa = Common.ConDBNull(DataReader["Khoa"]);
                        data.MaKhoa = Common.ConDBNull(DataReader["MaKhoa"]);
                        data.TTTheoDoiTruocCT = JsonConvert.DeserializeObject<ObservableCollection<ThongTinSinhTonHoHap>>(DataReader.GetString("TTTheoDoiTruocCT"));
                        data.TTTheoDoiTrongCT = JsonConvert.DeserializeObject<ObservableCollection<ThongTinSinhTonHoHap>>(DataReader.GetString("TTTheoDoiTrongCT"));
                        data.TTTheoDoiSauCT = JsonConvert.DeserializeObject<ObservableCollection<ThongTinSinhTonHoHap>>(DataReader.GetString("TTTheoDoiSauCT"));
                        data.ThuocTruocCT = JsonConvert.DeserializeObject<ObservableCollection<ThongTinThuoc>>(DataReader.GetString("ThuocTruocCT"));
                        data.ThuocTrongCT = JsonConvert.DeserializeObject<ObservableCollection<ThongTinThuoc>>(DataReader.GetString("ThuocTrongCT"));
                        data.ThuocSauCT = JsonConvert.DeserializeObject<ObservableCollection<ThongTinThuoc>>(DataReader.GetString("ThuocSauCT"));
                        data.TTNguoiBenhTruocCT = Common.ConDBNull(DataReader["TTNguoiBenhTruocCT"]);
                        data.TTNguoiBenhTrongCT = Common.ConDBNull(DataReader["TTNguoiBenhTrongCT"]);
                        data.TTNguoiBenhSauCT = Common.ConDBNull(DataReader["TTNguoiBenhSauCT"]);
                        data.TenDDTruocCT = Common.ConDBNull(DataReader["TenDDTruocCT"]);
                        data.MaDDTruocCT = Common.ConDBNull(DataReader["MaDDTruocCT"]);
                        data.TenDDTrongCT = Common.ConDBNull(DataReader["TenDDTrongCT"]);
                        data.MaDDTrongCT = Common.ConDBNull(DataReader["MaDDTrongCT"]);
                        data.TenDDDSauCT = Common.ConDBNull(DataReader["TenDDDSauCT"]);
                        data.MaDDSauCT = Common.ConDBNull(DataReader["MaDDSauCT"]);
                        data.BGLS_DM = Common.ConDBNull(DataReader["BGLS_DM"]);
                        data.BGLS_TM = Common.ConDBNull(DataReader["BGLS_TM"]);
                        data.KhoaTMCT = JsonConvert.DeserializeObject<string[]>(DataReader.GetString("KhoaTMCT"));
                        data.KhoaLS = JsonConvert.DeserializeObject<string[]>(DataReader.GetString("KhoaLS"));
                        data.BGLS_GioBangEp = Common.ConDBNull(DataReader["BGLS_GioBangEp"]);
                        data.ChocMach_SoLan = Common.ConDB_IntNull(DataReader["ChocMach_SoLan"]);
                        data.ChocMach_ViTri = Common.ConDB_IntNull(DataReader["ChocMach_ViTri"]);
                        data.ChiDinhSDThuoc = Common.ConDB_IntNull(DataReader["ChiDinhSDThuoc"]);
                        data.NBAnUong = Common.ConDBNull(DataReader["NBAnUong"]);
                        data.KhoaChuyenDen = Common.ConDBNull(DataReader["KhoaChuyenDen"]);
                        data.DieuDuongNhanNB = Common.ConDBNull(DataReader["DieuDuongNhanNB"]);
                        data.MaNVDieuDuongNhanNB = Common.ConDBNull(DataReader["MaNVDieuDuongNhanNB"]);
                        data.NgayTao = Common.ConDB_DateTime(DataReader["NgayTao"]);
                        data.NguoiTao = Common.ConDBNull(DataReader["NguoiTao"]);
                        data.NgaySua = Common.ConDB_DateTime(DataReader["NgaySua"]);
                        data.NguoiSua = Common.ConDBNull(DataReader["NguoiSua"]);
                        data.MaSoKy = Common.ConDBNull(DataReader["masokyten"]);
                        data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;
                        //data.NgayKy = Common.ConDB_DateTime(DataReader["ngayky"]);
                        //data.TenFileKy = Common.ConDBNull(DataReader["tenfileky"]);
                        //data.UserNameKy = Common.ConDBNull(DataReader["usernameky"]);
                        list.Add(data);
                    }
                    catch (Exception ex)
                    {
                        MDB.ExceptionExtend.LogError(ex);
                    }
                }
                DataReader.Close();
                DataReader = null;
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool InsertOrUpdatePhieu(MDB.MDBConnection MyConnection, ref BangTheoDoiBenhNhanCTMVTbl obj, int loaiRpt)
        {
            try
            {
                string tblName = string.Empty;
                if (loaiRpt == (int)LoaiPhieuTDCS.BTDCSNB)
                {
                    tblName = TableName;
                }
                else if (loaiRpt == (int)LoaiPhieuTDCS.BTDBNCTMV)
                {
                    tblName = TableName2;
                }
                string sql = "INSERT INTO " + tblName + @"(
                    MaQuanLy,MaBenhNhan,TenBenhNhan,Tuoi,GioiTinh,ChanDoan,CanThiep,Khoa,MaKhoa,TTTheoDoiTruocCT,TTTheoDoiTrongCT,TTTheoDoiSauCT,ThuocTruocCT,ThuocTrongCT,ThuocSauCT,TTNguoiBenhTruocCT, TTNguoiBenhTrongCT, TTNguoiBenhSauCT,TenDDTruocCT,MaDDTruocCT,TenDDTrongCT,MaDDTrongCT,TenDDDSauCT,MaDDSauCT,BGLS_DM,BGLS_TM,KhoaTMCT,KhoaLS,BGLS_GioBangEp,ChocMach_SoLan,ChocMach_ViTri,ChiDinhSDThuoc,NBAnUong,KhoaChuyenDen,DieuDuongNhanNB,MaNVDieuDuongNhanNB,NgayTao,NguoiTao,NgaySua,NguoiSua
                  )  VALUES (
                    :MaQuanLy, :MaBenhNhan, :TenBenhNhan, :Tuoi, :GioiTinh, :ChanDoan, :CanThiep, :Khoa, :MaKhoa, :TTTheoDoiTruocCT, :TTTheoDoiTrongCT, :TTTheoDoiSauCT, :ThuocTruocCT, :ThuocTrongCT, :ThuocSauCT,:TTNguoiBenhTruocCT, :TTNguoiBenhTrongCT, :TTNguoiBenhSauCT, :TenDDTruocCT, :MaDDTruocCT, :TenDDTrongCT, :MaDDTrongCT, :TenDDDSauCT, :MaDDSauCT, :BGLS_DM, :BGLS_TM, :KhoaTMCT, :KhoaLS, :BGLS_GioBangEp, :ChocMach_SoLan, :ChocMach_ViTri, :ChiDinhSDThuoc,  :NBAnUong, :KhoaChuyenDen, :DieuDuongNhanNB, :MaNVDieuDuongNhanNB, :NgayTao, :NguoiTao, :NgaySua, :NguoiSua
                 )  RETURNING ID INTO :ID";
                if (obj.ID != 0)
                {
                    sql = @"UPDATE " + tblName + @" SET 
                    MaQuanLy= :MaQuanLy,MaBenhNhan= :MaBenhNhan,TenBenhNhan= :TenBenhNhan,Tuoi= :Tuoi,GioiTinh= :GioiTinh,ChanDoan= :ChanDoan,CanThiep= :CanThiep,Khoa= :Khoa,MaKhoa= :MaKhoa,TTTheoDoiTruocCT= :TTTheoDoiTruocCT,TTTheoDoiTrongCT= :TTTheoDoiTrongCT,TTTheoDoiSauCT= :TTTheoDoiSauCT,ThuocTruocCT= :ThuocTruocCT,ThuocTrongCT= :ThuocTrongCT,ThuocSauCT= :ThuocSauCT,TTNguoiBenhTruocCT= :TTNguoiBenhTruocCT, TTNguoiBenhTrongCT= :TTNguoiBenhTrongCT, TTNguoiBenhSauCT= :TTNguoiBenhSauCT,TenDDTruocCT= :TenDDTruocCT,MaDDTruocCT= :MaDDTruocCT,TenDDTrongCT= :TenDDTrongCT,MaDDTrongCT= :MaDDTrongCT,TenDDDSauCT= :TenDDDSauCT,MaDDSauCT= :MaDDSauCT,BGLS_DM= :BGLS_DM,BGLS_TM= :BGLS_TM,KhoaTMCT= :KhoaTMCT,KhoaLS= :KhoaLS,BGLS_GioBangEp= :BGLS_GioBangEp,ChocMach_SoLan= :ChocMach_SoLan,ChocMach_ViTri= :ChocMach_ViTri,ChiDinhSDThuoc= :ChiDinhSDThuoc,NBAnUong= :NBAnUong,KhoaChuyenDen= :KhoaChuyenDen,DieuDuongNhanNB= :DieuDuongNhanNB,MaNVDieuDuongNhanNB= :MaNVDieuDuongNhanNB,NgayTao= :NgayTao,NguoiTao= :NguoiTao,NgaySua= :NgaySua,NguoiSua= :NguoiSua
                   WHERE ID = " + obj.ID;
                }
                MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, MyConnection);


                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaQuanLy", obj.MaQuanLy));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", obj.MaBenhNhan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenBenhNhan", obj.TenBenhNhan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Tuoi", obj.Tuoi));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("GioiTinh", obj.GioiTinh));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ChanDoan", obj.ChanDoan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CanThiep", obj.CanThiep));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Khoa", obj.Khoa));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaKhoa", obj.MaKhoa));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TTTheoDoiTruocCT", JsonConvert.SerializeObject(obj.TTTheoDoiTruocCT)));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TTTheoDoiTrongCT", JsonConvert.SerializeObject(obj.TTTheoDoiTrongCT)));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TTTheoDoiSauCT", JsonConvert.SerializeObject(obj.TTTheoDoiSauCT)));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ThuocTruocCT", JsonConvert.SerializeObject(obj.ThuocTruocCT)));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ThuocTrongCT", JsonConvert.SerializeObject(obj.ThuocTrongCT)));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ThuocSauCT", JsonConvert.SerializeObject(obj.ThuocSauCT)));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TTNguoiBenhTruocCT", obj.TTNguoiBenhTruocCT));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TTNguoiBenhTrongCT", obj.TTNguoiBenhTrongCT));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TTNguoiBenhSauCT", obj.TTNguoiBenhSauCT));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenDDTruocCT", obj.TenDDTruocCT));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaDDTruocCT", obj.MaDDTruocCT));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenDDTrongCT", obj.TenDDTrongCT));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaDDTrongCT", obj.MaDDTrongCT));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenDDDSauCT", obj.TenDDDSauCT));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaDDSauCT", obj.MaDDSauCT));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("BGLS_DM", obj.BGLS_DM));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("BGLS_TM", obj.BGLS_TM));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KhoaTMCT", JsonConvert.SerializeObject(obj.KhoaTMCT)));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KhoaLS", JsonConvert.SerializeObject(obj.KhoaLS)));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("BGLS_GioBangEp", obj.BGLS_GioBangEp));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ChocMach_SoLan", obj.ChocMach_SoLan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ChocMach_ViTri", obj.ChocMach_ViTri));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ChiDinhSDThuoc", obj.ChiDinhSDThuoc));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NBAnUong", obj.NBAnUong));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KhoaChuyenDen", obj.KhoaChuyenDen));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DieuDuongNhanNB", obj.DieuDuongNhanNB));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaNVDieuDuongNhanNB", obj.MaNVDieuDuongNhanNB));
                if (obj.ID == 0)
                {
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayTao", obj.NgayTao));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiTao", obj.NguoiTao));
                }
                else
                {
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayTao", DateTime.Now));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiTao", Common.getUserLogin()));
                }
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgaySua", DateTime.Now));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiSua", Common.getUserLogin()));
                if (obj.ID == 0)
                {
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ID", obj.ID));
                }
                oracleCommand.BindByName = true;
                int n = oracleCommand.ExecuteNonQuery();
                if (obj.ID == 0)
                {
                    long nextval = Convert.ToInt64((oracleCommand.Parameters["ID"] as MDB.MDBParameter).Value);
                    obj.ID = nextval;
                }
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool deletePhieu(MDB.MDBConnection MyConnection, long id, int loaiRpt)
        {
            try
            {
                string tblName = string.Empty;
                if (loaiRpt == (int)LoaiPhieuTDCS.BTDCSNB)
                {
                    tblName = TableName;
                }
                else if (loaiRpt == (int)LoaiPhieuTDCS.BTDBNCTMV)
                {
                    tblName = TableName2;
                }
                string sql = "DELETE FROM " + tblName + @" WHERE ID = :ID";
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
        //public static DataSet GetDataSet(MDB.MDBConnection MyConnection, decimal idPhieu)
        //{
        //    string sql2 = @"SELECT
        //        D.*,
        //    T.MABENHNHAN,
        //    T.KHOA,
        //    T.GIUONG,
        //        T.BUONG,
        //    T.NGAYVAOVIEN,
        //    H.SOYTE,
        //    H.BENHVIEN,
        //    H.MABENHNHAN,
        //    H.TENBENHNHAN,
        //    H.TUOI,
        //    H.GIOITINH
        //    FROM
        //        BangTheoDoiBenhNhanCTMV D
        //        LEFT JOIN THONGTINDIEUTRI T ON D.MAQUANLY = T.MAQUANLY
        //        LEFT JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
        //    WHERE
        //        ID = :ID";
        //    MDB.MDBCommand Command = new MDB.MDBCommand(sql2, MyConnection);
        //    Command.Parameters.Add(new MDB.MDBParameter("ID", idPhieu));

        //    MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
        //    var ds = new DataSet();
        //    adt.Fill(ds, "BK");
        //    return ds;
        //}
    }

}
