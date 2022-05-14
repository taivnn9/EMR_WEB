
using EMR.KyDienTu;
using System;
using System.Collections.ObjectModel;
using System.Data;
using PMS.Access;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class BangKiemJohnsHopking : ThongTinKy
    {
        public BangKiemJohnsHopking()
        {
            TableName = "BangKiemJohnsHopking";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BKJH;
            TenMauPhieu = DanhMucPhieu.BKJH.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")] 
        public string TenBenhVien { get; set; }
        [MoTaDuLieu("Khoa phòng")]
        public string KhoaPhong { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Thời điểm đánh giá")]
        public int? ThoiDiemDanhGia { get; set; }
        [MoTaDuLieu("Độ tuổi")]
        public int? DoTuoi { get; set; }
        [MoTaDuLieu("Tiền sử té ngã")]
        public int? TienSuTeNga { get; set; }
        [MoTaDuLieu("Bài tiết")]
        public int? BaiTiet { get; set; }
        [MoTaDuLieu("Thuốc")]
        public int? Thuoc { get; set; }
        [MoTaDuLieu("Dụng cụ chăm sóc")]
        public int? DungCuChamSoc { get; set; }
        [MoTaDuLieu("Vận động")]
        public int? VanDong { get; set; }
        [MoTaDuLieu("Tình trạng nhận thức")]
        public int? TinhTrangNhanThuc { get; set; }
        [MoTaDuLieu("Tổng điểm")]
        public int? TongDiem { get; set; }
        [MoTaDuLieu("Xếp loại")]
        public string XepLoai { get; set; }
        [MoTaDuLieu("Kết cục")]
        public int? KetCuc { get; set; }
        [MoTaDuLieu("Mức độ té")]
        public int? MucDoTe { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
    }
    public class BangKiemJohnsHopkingFunc
    {
        public const string TableName = "BangKiemJohnsHopking";
        public const string TablePrimaryKeyName = "ID";
        public static long InsertOrUpdate(BangKiemJohnsHopking bangKiemJohnsHopking, MDB.MDBConnection conn)
        {
            try
            {
                string sSql = "SELECT ID FROM BangKiemJohnsHopking WHERE ID = :ID";
                MDB.MDBCommand command = new MDB.MDBCommand(sSql, conn);
                command.Parameters.Add(new MDB.MDBParameter("ID", bangKiemJohnsHopking.ID));
                MDB.MDBDataReader dataReader = command.ExecuteReader();
                int iCount = 0;
                while (dataReader.Read()) iCount++;
                if (iCount > 0)
                    sSql = "UPDATE BangKiemJohnsHopking SET MAQUANLY = :MAQUANLY, TENBENHVIEN = :TENBENHVIEN, KHOAPHONG = :KHOAPHONG, MABENHNHAN = :MABENHNHAN, TENBENHNHAN = :TENBENHNHAN, TUOI = :TUOI, CHANDOAN = :CHANDOAN, THOIDIEMDANHGIA = :THOIDIEMDANHGIA, DOTUOI = :DOTUOI, TIENSUTENGA = :TIENSUTENGA, BAITIET = :BAITIET, THUOC = :THUOC, DUNGCUCHAMSOC = :DUNGCUCHAMSOC, VANDONG = :VANDONG, TINHTRANGNHANTHUC = :TINHTRANGNHANTHUC, TONGDIEM = :TONGDIEM, XEPLOAI = :XEPLOAI, KETCUC = :KETCUC, MUCDOTE = :MUCDOTE, NGAYTAO = :NGAYTAO, NGAYSUA = :NGAYSUA, NGUOITAO = :NGUOITAO, NGUOISUA = :NGUOISUA WHERE ID = :ID";
                else
                    sSql = "INSERT INTO BangKiemJohnsHopking (MAQUANLY, TENBENHVIEN, KHOAPHONG, MABENHNHAN, TENBENHNHAN, TUOI, CHANDOAN, THOIDIEMDANHGIA, DOTUOI, TIENSUTENGA, BAITIET, THUOC, DUNGCUCHAMSOC, VANDONG, TINHTRANGNHANTHUC, TONGDIEM, XEPLOAI, KETCUC, MUCDOTE, NGAYTAO, NGAYSUA, NGUOITAO, NGUOISUA) VALUES (:MAQUANLY, :TENBENHVIEN, :KHOAPHONG, :MABENHNHAN, :TENBENHNHAN, :TUOI, :CHANDOAN, :THOIDIEMDANHGIA, :DOTUOI, :TIENSUTENGA, :BAITIET, :THUOC, :DUNGCUCHAMSOC, :VANDONG, :TINHTRANGNHANTHUC, :TONGDIEM, :XEPLOAI, :KETCUC, :MUCDOTE, :NGAYTAO, :NGAYSUA, :NGUOITAO, :NGUOISUA) RETURNING ID INTO :ID";
                command = new MDB.MDBCommand(sSql, conn);
                command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangKiemJohnsHopking.MaQuanLy));
                command.Parameters.Add(new MDB.MDBParameter("TENBENHVIEN", bangKiemJohnsHopking.TenBenhVien));
                command.Parameters.Add(new MDB.MDBParameter("KHOAPHONG", bangKiemJohnsHopking.KhoaPhong));
                command.Parameters.Add(new MDB.MDBParameter("MABENHNHAN", bangKiemJohnsHopking.MaBenhNhan));
                command.Parameters.Add(new MDB.MDBParameter("TENBENHNHAN", bangKiemJohnsHopking.TenBenhNhan));
                command.Parameters.Add(new MDB.MDBParameter("TUOI", bangKiemJohnsHopking.Tuoi));
                command.Parameters.Add(new MDB.MDBParameter("CHANDOAN", bangKiemJohnsHopking.ChanDoan));
                command.Parameters.Add(new MDB.MDBParameter("THOIDIEMDANHGIA", bangKiemJohnsHopking.ThoiDiemDanhGia));
                command.Parameters.Add(new MDB.MDBParameter("DOTUOI", bangKiemJohnsHopking.DoTuoi));
                command.Parameters.Add(new MDB.MDBParameter("TIENSUTENGA", bangKiemJohnsHopking.TienSuTeNga));
                command.Parameters.Add(new MDB.MDBParameter("BAITIET", bangKiemJohnsHopking.BaiTiet));
                command.Parameters.Add(new MDB.MDBParameter("THUOC", bangKiemJohnsHopking.Thuoc));
                command.Parameters.Add(new MDB.MDBParameter("DUNGCUCHAMSOC", bangKiemJohnsHopking.DungCuChamSoc));
                command.Parameters.Add(new MDB.MDBParameter("VANDONG", bangKiemJohnsHopking.VanDong));
                command.Parameters.Add(new MDB.MDBParameter("TINHTRANGNHANTHUC", bangKiemJohnsHopking.TinhTrangNhanThuc));
                command.Parameters.Add(new MDB.MDBParameter("TONGDIEM", bangKiemJohnsHopking.TongDiem));
                command.Parameters.Add(new MDB.MDBParameter("XEPLOAI", bangKiemJohnsHopking.XepLoai));
                command.Parameters.Add(new MDB.MDBParameter("KETCUC", bangKiemJohnsHopking.KetCuc));
                command.Parameters.Add(new MDB.MDBParameter("MUCDOTE", bangKiemJohnsHopking.MucDoTe));
                command.Parameters.Add(new MDB.MDBParameter("NgayTao", bangKiemJohnsHopking.NgayTao));
                if (iCount > 0)
                    command.Parameters.Add(new MDB.MDBParameter("NgaySua", DateTime.UtcNow.AddHours(7)));
                else
                    command.Parameters.Add(new MDB.MDBParameter("NgaySua", null));
                command.Parameters.Add(new MDB.MDBParameter("NguoiTao", bangKiemJohnsHopking.NguoiTao));
                if (iCount > 0)
                    command.Parameters.Add(new MDB.MDBParameter("NguoiSua", Common.getUserLogin()));
                else
                    command.Parameters.Add(new MDB.MDBParameter("NguoiSua", ""));
                command.Parameters.Add(new MDB.MDBParameter("ID", bangKiemJohnsHopking.ID));
                int n = command.ExecuteNonQuery();
                long ID = Convert.ToInt64((command.Parameters["ID"] as MDB.MDBParameter).Value);
                return n > 0 ? ID : 0;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return 0;
        }
        public static bool Delete(long ID, MDB.MDBConnection conn)
        {
            try
            {
                string sSql = "UPDATE BangKiemJohnsHopking SET TRANGTHAI = 1 WHERE ID = :ID";
                MDB.MDBCommand command = new MDB.MDBCommand(sSql, conn);
                command.Parameters.Add(new MDB.MDBParameter("ID", ID));
                int n = command.ExecuteNonQuery();
                return n > 0 ? true : false;
            }

            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static ObservableCollection<BangKiemJohnsHopking> GetData(decimal MaQuanLy, MDB.MDBConnection conn)
        {
            ObservableCollection<BangKiemJohnsHopking> bangKiemJohnsHopkings = new ObservableCollection<BangKiemJohnsHopking>();
            try
            {
                string sSql = "SELECT * FROM BangKiemJohnsHopking WHERE TRANGTHAI = 0 AND MAQUANLY = :MAQUANLY";
                MDB.MDBCommand command = new MDB.MDBCommand(sSql, conn);
                command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", MaQuanLy));
                MDB.MDBDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    BangKiemJohnsHopking bangKiemJohnsHopking = new BangKiemJohnsHopking();
                    bangKiemJohnsHopking.ID = Convert.ToInt64(dataReader.GetLong("ID"));
                    bangKiemJohnsHopking.MaQuanLy = Convert.ToDecimal(dataReader.GetDecimal("MaQuanLy"));
                    bangKiemJohnsHopking.TenBenhVien = dataReader["TenBenhVien"].ToString();
                    bangKiemJohnsHopking.KhoaPhong = dataReader["KhoaPhong"].ToString();
                    bangKiemJohnsHopking.MaBenhNhan = dataReader["MaBenhNhan"].ToString();
                    bangKiemJohnsHopking.TenBenhNhan = dataReader["TenBenhNhan"].ToString();
                    bangKiemJohnsHopking.Tuoi = dataReader["Tuoi"].ToString();
                    bangKiemJohnsHopking.ChanDoan = dataReader["ChanDoan"].ToString();
                    if (dataReader["ThoiDiemDanhGia"] != null && dataReader["ThoiDiemDanhGia"].ToString() != string.Empty)
                    {
                        bangKiemJohnsHopking.ThoiDiemDanhGia = Convert.ToInt32(dataReader.GetLong("ThoiDiemDanhGia").ToString());
                    }
                    if (dataReader["DoTuoi"] != null && dataReader["DoTuoi"].ToString() != string.Empty)
                    {
                        bangKiemJohnsHopking.DoTuoi = Convert.ToInt32(dataReader.GetLong("DoTuoi"));
                    }
                    if (!dataReader["TienSuTeNga"].ToString().Equals(""))
                    {
                        bangKiemJohnsHopking.TienSuTeNga = Convert.ToInt32(dataReader.GetLong("TienSuTeNga"));
                    }
                    if (!dataReader["BaiTiet"].ToString().Equals(""))
                    {
                        bangKiemJohnsHopking.BaiTiet = Convert.ToInt32(dataReader.GetLong("BaiTiet"));
                    }
                    if (!dataReader["Thuoc"].ToString().Equals(""))
                    {
                        bangKiemJohnsHopking.Thuoc = Convert.ToInt32(dataReader.GetLong("Thuoc"));
                    }
                    if (!dataReader["DungCuChamSoc"].ToString().Equals(""))
                    {
                        bangKiemJohnsHopking.DungCuChamSoc = Convert.ToInt32(dataReader.GetLong("DungCuChamSoc"));
                    }
                    if (!dataReader["VanDong"].ToString().Equals(""))
                    {
                        bangKiemJohnsHopking.VanDong = Convert.ToInt32(dataReader.GetLong("VanDong"));
                    }
                    if (!dataReader["TinhTrangNhanThuc"].ToString().Equals(""))
                    {
                        bangKiemJohnsHopking.TinhTrangNhanThuc = Convert.ToInt32(dataReader.GetLong("TinhTrangNhanThuc"));
                    }
                    if (!dataReader["TongDiem"].ToString().Equals(""))
                    {
                        bangKiemJohnsHopking.TongDiem = Convert.ToInt32(dataReader.GetLong("TongDiem"));
                    }
                    if (!dataReader["KetCuc"].ToString().Equals(""))
                    {
                        bangKiemJohnsHopking.KetCuc = Convert.ToInt32(dataReader.GetLong("KetCuc"));
                    }
                    bangKiemJohnsHopking.XepLoai = dataReader["XepLoai"].ToString();
                    if (!dataReader["MucDoTe"].ToString().Equals(""))
                    {
                        bangKiemJohnsHopking.MucDoTe = Convert.ToInt32(dataReader.GetLong("MucDoTe"));
                    }
                    bangKiemJohnsHopking.NgayTao = Convert.ToDateTime(dataReader.GetDate("NgayTao"));
                    if (!dataReader["NgaySua"].ToString().Equals(""))
                    {
                        bangKiemJohnsHopking.NgaySua = Convert.ToDateTime(dataReader.GetDate("NgaySua"));
                    }
                    bangKiemJohnsHopking.NguoiTao = dataReader["NguoiTao"].ToString();
                    bangKiemJohnsHopking.NguoiSua = dataReader["NguoiSua"].ToString();
                    try
                    {
                        bangKiemJohnsHopking.MaSoKy = dataReader["masokyten"].ToString();
                        bangKiemJohnsHopking.DaKy = !string.IsNullOrEmpty(bangKiemJohnsHopking.MaSoKy) ? true : false;
                    }
                    catch { }
                    bangKiemJohnsHopkings.Add(bangKiemJohnsHopking);
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return bangKiemJohnsHopkings;
        }
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, long id)
        {
            DataSet dataSet = new DataSet();
            try
            {
                string sql = @"SELECT
                B.*,
                H.SOYTE,
                H.BENHVIEN,
                T.KHOA
            FROM
                BangKiemJohnsHopking B
                LEFT JOIN HANHCHINHBENHNHAN H ON B.MABENHNHAN = H.MABENHNHAN
                LEFT JOIN THONGTINDIEUTRI T ON B.MAQUANLY = T.MAQUANLY
            WHERE
                ID = " + id;
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
                adt.Fill(dataSet, "BK");
                return dataSet;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return dataSet;
        }
    }
}
