using EMR.KyDienTu;
using MDB;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class BienBanHoiChanUngBuou : ThongTinKy
    {
        public BienBanHoiChanUngBuou()
        {
            TableName = "BienBanHoiChanUngBuou";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BBHCUB;
            TenMauPhieu = DanhMucPhieu.BBHCUB.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")] 
        public string HoTenBN { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string TuoiBN { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinhBN { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        [MoTaDuLieu("Điện thoại")]
        public string DienThoai { get; set; }
        [MoTaDuLieu("Mã y tế")]
        public string MaYTe { get; set; }
        [MoTaDuLieu("Số phiếu")]
        public string SoPhieu { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Mã ICD")]
        public string MaICD { get; set; }
        [MoTaDuLieu("Thành viên tham gia")]
        public string ThanhVienThamGia { get; set; }
        [MoTaDuLieu("Mã thành viên tham gia")]
        public string MaThanhVienThamGia { get; set; }
        [MoTaDuLieu("Bệnh sử")]
        public string BenhSu { get; set; }
        [MoTaDuLieu("Tiền căn")]
        public string TienCan { get; set; }
        [MoTaDuLieu("Khám lâm sàng")]
        public string KhamLamSang { get; set; }
        [MoTaDuLieu("Két quả xét nghiệm chuyên khoa")]
        public string KQXNChuyenKhoa { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh xác định")]
		public string ChanDoanXacDinh { get; set; }
        [MoTaDuLieu("Hoá trị")]
        public int HoaTri { get; set; }
        [MoTaDuLieu("Xạ trị")]
        public int XaTri { get; set; }
        [MoTaDuLieu("Phẫu thuật")]
        public int PhauThuat { get; set; }
        [MoTaDuLieu("Khác")]
        public int Khac { get; set; }
        [MoTaDuLieu("Hướng xử trí khác")]
        public string HuongXuTriKhac { get; set; }
        [MoTaDuLieu("Phác đồ")]
        public string PhacDo { get; set; }
        [MoTaDuLieu("Ngày hẹn")]
        public DateTime NgayHen { get; set; }
        [MoTaDuLieu("Ngày chẩn đoán")]
        public DateTime NgayChanDoan { get; set; }
        [MoTaDuLieu("Ghi chú")]
		public string GhiChu { get; set; }
        [MoTaDuLieu("Thư ký")]
        public string ThuKy { get; set; }
        [MoTaDuLieu("Mã thư ký")]
        public string MaThuKy { get; set; }
        [MoTaDuLieu("Chủ toạ")]
        public string ChuToa { get; set; }
        [MoTaDuLieu("Mã chủ toạ")]
        public string MaChuToa { get; set; }

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
    public class BienBanHoiChanUngBuouFunc
    {
        public const string TableName = "BienBanHoiChanUngBuou";
        public const string TablePrimaryKeyName = "ID";
        public static List<BienBanHoiChanUngBuou> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BienBanHoiChanUngBuou> list = new List<BienBanHoiChanUngBuou>();
            try
            {
                string sql = @"SELECT * FROM BienBanHoiChanUngBuou where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    try
                    {
                        BienBanHoiChanUngBuou data = new BienBanHoiChanUngBuou();
                        data.ID = DataReader.GetLong("ID");
                        data.MaQuanLy = Convert.ToDecimal(DataReader["MaQuanLy"].ToString());
                        data.MaBenhNhan = Common.ConDBNull(DataReader["MaBenhNhan"]);
                        data.HoTenBN = Common.ConDBNull(DataReader["HoTenBN"]);
                        data.TuoiBN = Common.ConDBNull(DataReader["TuoiBN"]);
                        data.GioiTinhBN = Common.ConDBNull(DataReader["GioiTinhBN"]);
                        data.DiaChi = Common.ConDBNull(DataReader["DiaChi"]);
                        data.DienThoai = Common.ConDBNull(DataReader["DienThoai"]);
                        data.MaYTe = Common.ConDBNull(DataReader["MaYTe"]);
                        data.SoPhieu = Common.ConDBNull(DataReader["SoPhieu"]);
                        data.ChanDoan = Common.ConDBNull(DataReader["ChanDoan"]);
                        data.MaICD = Common.ConDBNull(DataReader["MaICD"]);
                        data.ThanhVienThamGia = Common.ConDBNull(DataReader["ThanhVienThamGia"]);
                        data.MaThanhVienThamGia = Common.ConDBNull(DataReader["MaThanhVienThamGia"]);
                        data.BenhSu = Common.ConDBNull(DataReader["BenhSu"]);
                        data.TienCan = Common.ConDBNull(DataReader["TienCan"]);
                        data.KhamLamSang = Common.ConDBNull(DataReader["KhamLamSang"]);
                        data.KQXNChuyenKhoa = Common.ConDBNull(DataReader["KQXNChuyenKhoa"]);
                        data.ChanDoanXacDinh = Common.ConDBNull(DataReader["ChanDoanXacDinh"]);
                        data.HoaTri = Common.ConDB_Int(DataReader["HoaTri"]);
                        data.XaTri = Common.ConDB_Int(DataReader["XaTri"]);
                        data.PhauThuat = Common.ConDB_Int(DataReader["PhauThuat"]);
                        data.Khac = Common.ConDB_Int(DataReader["Khac"]);
                        data.HuongXuTriKhac = Common.ConDBNull(DataReader["HuongXuTriKhac"]);
                        data.PhacDo = Common.ConDBNull(DataReader["PhacDo"]);
                        data.NgayHen = Common.ConDB_DateTime(DataReader["NgayHen"]);
                        data.NgayChanDoan = Common.ConDB_DateTime(DataReader["NgayChanDoan"]);
                        data.GhiChu = Common.ConDBNull(DataReader["GhiChu"]);
                        data.ThuKy = Common.ConDBNull(DataReader["ThuKy"]);
                        data.MaThuKy = Common.ConDBNull(DataReader["MaThuKy"]);
                        data.ChuToa = Common.ConDBNull(DataReader["ChuToa"]);
                        data.MaChuToa = Common.ConDBNull(DataReader["MaChuToa"]);

                        data.NgayTao = Common.ConDB_DateTime(DataReader["NgayTao"]);
                        data.NgaySua = Common.ConDB_DateTime(DataReader["NgaySua"]);
                        data.MaSoKy = DataReader.GetString("masokyten");
                        data.NgayKy = DataReader.GetDate("ngayky");
                        data.TenFileKy = DataReader.GetString("tenfileky");
                        data.UserNameKy = DataReader.GetString("usernameky");

                        data.NgayTao = Common.ConDB_DateTime(DataReader["NgayTao"]);
                        data.NguoiTao = Common.ConDBNull(DataReader["NGUOITAO"]);
                        data.NgaySua = Common.ConDB_DateTime(DataReader["NgaySua"]);
                        data.NguoiSua = Common.ConDBNull(DataReader["NGUOISUA"]);
                        data.MaSoKy = DataReader["masokyten"].ToString();
                        data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;
                        data.TenFileKy = Common.ConDBNull(DataReader["tenfileky"]);
                        data.UserNameKy = Common.ConDBNull(DataReader["usernameky"]);

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BienBanHoiChanUngBuou data)
        {
            try
            {
                string sql = @"INSERT INTO BienBanHoiChanUngBuou
                (
                    MaQuanLy,
                    MaBenhNhan,
                    HoTenBN,
                    TuoiBN,
                    GioiTinhBN,
                    DiaChi,
                    DienThoai,
                    MaYTe,
                    SoPhieu,
                    ChanDoan,
                    MaICD,
                    ThanhVienThamGia,
                    MaThanhVienThamGia,
                    BenhSu,
                    TienCan,
                    KhamLamSang,
                    KQXNChuyenKhoa,
                    ChanDoanXacDinh,
                    HoaTri,
                    XaTri,
                    PhauThuat,
                    Khac,
                    HuongXuTriKhac,
                    PhacDo,
                    NgayHen,
                    NgayChanDoan,
                    GhiChu,
                    ThuKy,
                    MaThuKy,
                    ChuToa,
                    MaChuToa,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA
                    )  VALUES (
				    :MaQuanLy,
                    :MaBenhNhan,
                    :HoTenBN,
                    :TuoiBN,
                    :GioiTinhBN,
                    :DiaChi,
                    :DienThoai,
                    :MaYTe,
                    :SoPhieu,
                    :ChanDoan,
                    :MaICD,
                    :ThanhVienThamGia,
                    :MaThanhVienThamGia,
                    :BenhSu,
                    :TienCan,
                    :KhamLamSang,
                    :KQXNChuyenKhoa,
                    :ChanDoanXacDinh,
                    :HoaTri,
                    :XaTri,
                    :PhauThuat,
                    :Khac,
                    :HuongXuTriKhac,
                    :PhacDo,
                    :NgayHen,
                    :NgayChanDoan,
                    :GhiChu,
                    :ThuKy,
                    :MaThuKy,
                    :ChuToa,
                    :MaChuToa,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                    )  RETURNING ID INTO :ID";
                if (data.ID != 0)
                {
                    sql = @"UPDATE BienBanHoiChanUngBuou SET 
                    MaQuanLy = :MaQuanLy,
                    MaBenhNhan=:MaBenhNhan,
                    HoTenBN=:HoTenBN,
                    TuoiBN=:TuoiBN,
                    GioiTinhBN=:GioiTinhBN,
                    DiaChi=:DiaChi,
                    DienThoai=:DienThoai,
                    MaYTe=:MaYTe,
                    SoPhieu=:SoPhieu,
                    ChanDoan=:ChanDoan,
                    MaICD=:MaICD,
                    ThanhVienThamGia=:ThanhVienThamGia,
                    MaThanhVienThamGia=:MaThanhVienThamGia,
                    BenhSu=:BenhSu,
                    TienCan=:TienCan,
                    KhamLamSang=:KhamLamSang,
                    KQXNChuyenKhoa=:KQXNChuyenKhoa,
                    ChanDoanXacDinh=:ChanDoanXacDinh,
                    HoaTri=:HoaTri,
                    XaTri=:XaTri,
                    PhauThuat=:PhauThuat,
                    Khac=:Khac,
                    HuongXuTriKhac=:HuongXuTriKhac,
                    PhacDo=:PhacDo,
                    NgayHen=:NgayHen,
                    NgayChanDoan=:NgayChanDoan,
                    GhiChu=:GhiChu,
                    ThuKy=:ThuKy,
                    MaThuKy=:MaThuKy,
                    ChuToa=:ChuToa,
                    MaChuToa=:MaChuToa,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + data.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", data.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", data.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("HoTenBN", data.HoTenBN));
                Command.Parameters.Add(new MDB.MDBParameter("TuoiBN", data.TuoiBN));
                Command.Parameters.Add(new MDB.MDBParameter("GioiTinhBN", data.GioiTinhBN));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", data.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("DienThoai", data.DienThoai));
                Command.Parameters.Add(new MDB.MDBParameter("MaYTe", data.MaYTe));
                Command.Parameters.Add(new MDB.MDBParameter("SoPhieu", data.SoPhieu));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", data.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("MaICD", data.MaICD));
                Command.Parameters.Add(new MDB.MDBParameter("ThanhVienThamGia", data.ThanhVienThamGia));
                Command.Parameters.Add(new MDB.MDBParameter("MaThanhVienThamGia", data.MaThanhVienThamGia));
                Command.Parameters.Add(new MDB.MDBParameter("BenhSu", data.BenhSu));
                Command.Parameters.Add(new MDB.MDBParameter("TienCan", data.TienCan));
                Command.Parameters.Add(new MDB.MDBParameter("KhamLamSang", data.KhamLamSang));
                Command.Parameters.Add(new MDB.MDBParameter("KQXNChuyenKhoa", data.KQXNChuyenKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanXacDinh", data.ChanDoanXacDinh));
                Command.Parameters.Add(new MDB.MDBParameter("HoaTri", data.HoaTri));
                Command.Parameters.Add(new MDB.MDBParameter("XaTri", data.XaTri));
                Command.Parameters.Add(new MDB.MDBParameter("PhauThuat", data.PhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("Khac", data.Khac));
                Command.Parameters.Add(new MDB.MDBParameter("HuongXuTriKhac", data.HuongXuTriKhac));
                Command.Parameters.Add(new MDB.MDBParameter("PhacDo", data.PhacDo));
                Command.Parameters.Add(new MDB.MDBParameter("NgayHen", data.NgayHen));
                Command.Parameters.Add(new MDB.MDBParameter("NgayChanDoan", data.NgayChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("GhiChu", data.GhiChu));
                Command.Parameters.Add(new MDB.MDBParameter("ThuKy", data.ThuKy));
                Command.Parameters.Add(new MDB.MDBParameter("MaThuKy", data.MaThuKy));
                Command.Parameters.Add(new MDB.MDBParameter("ChuToa", data.ChuToa));
                Command.Parameters.Add(new MDB.MDBParameter("MaChuToa", data.MaChuToa));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", data.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", data.NgaySua));
                if (data.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", data.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", data.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", data.NgayTao));
                }
                Command.BindByName = true;
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
                XuLyLoi.LogError(ex);
            }
            return false;
        }

        public static bool Delete(MDB.MDBConnection MyConnection, decimal idPhieu)
        {
            string sql = "DELETE FROM BienBanHoiChanUngBuou WHERE ID = :idPhieu";
            MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
            command.Parameters.Add(new MDB.MDBParameter("idPhieu", idPhieu));
            command.BindByName = true;
            int n = command.ExecuteNonQuery();
            return n > 0;
        }
        public static BienBanHoiChanUngBuou GetData(MDB.MDBConnection _OracleConnection, decimal id)
        {
            try
            {
                string sql = @"SELECT * FROM BienBanHoiChuanBenhVien where ID = :ID";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID", id));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    try
                    {
                        BienBanHoiChanUngBuou data = new BienBanHoiChanUngBuou();
                        data.ID = DataReader.GetLong("ID");
                        data.MaQuanLy = Convert.ToDecimal(DataReader["MaQuanLy"].ToString());
                        data.MaQuanLy = Convert.ToDecimal(DataReader["MaQuanLy"].ToString());
                        data.MaBenhNhan = Common.ConDBNull(DataReader["MaBenhNhan"]);
                        data.HoTenBN = Common.ConDBNull(DataReader["HoTenBN"]);
                        data.TuoiBN = Common.ConDBNull(DataReader["TuoiBN"]);
                        data.GioiTinhBN = Common.ConDBNull(DataReader["GioiTinhBN"]);
                        data.DiaChi = Common.ConDBNull(DataReader["DiaChi"]);
                        data.DienThoai = Common.ConDBNull(DataReader["DienThoai"]);
                        data.MaYTe = Common.ConDBNull(DataReader["MaYTe"]);
                        data.SoPhieu = Common.ConDBNull(DataReader["SoPhieu"]);
                        data.ChanDoan = Common.ConDBNull(DataReader["ChanDoan"]);
                        data.MaICD = Common.ConDBNull(DataReader["MaICD"]);
                        data.ThanhVienThamGia = Common.ConDBNull(DataReader["ThanhVienThamGia"]);
                        data.MaThanhVienThamGia = Common.ConDBNull(DataReader["MaThanhVienThamGia"]);
                        data.BenhSu = Common.ConDBNull(DataReader["BenhSu"]);
                        data.TienCan = Common.ConDBNull(DataReader["TienCan"]);
                        data.KhamLamSang = Common.ConDBNull(DataReader["KhamLamSang"]);
                        data.KQXNChuyenKhoa = Common.ConDBNull(DataReader["KQXNChuyenKhoa"]);
                        data.ChanDoanXacDinh = Common.ConDBNull(DataReader["ChanDoanXacDinh"]);
                        data.HoaTri = Common.ConDB_Int(DataReader["HoaTri"]);
                        data.XaTri = Common.ConDB_Int(DataReader["XaTri"]);
                        data.PhauThuat = Common.ConDB_Int(DataReader["PhauThuat"]);
                        data.Khac = Common.ConDB_Int(DataReader["Khac"]);
                        data.HuongXuTriKhac = Common.ConDBNull(DataReader["HuongXuTriKhac"]);
                        data.PhacDo = Common.ConDBNull(DataReader["PhacDo"]);
                        data.NgayHen = Common.ConDB_DateTime(DataReader["NgayHen"]);
                        data.NgayChanDoan = Common.ConDB_DateTime(DataReader["NgayChanDoan"]);
                        data.GhiChu = Common.ConDBNull(DataReader["GhiChu"]);
                        data.ThuKy = Common.ConDBNull(DataReader["ThuKy"]);
                        data.MaThuKy = Common.ConDBNull(DataReader["MaThuKy"]);
                        data.ChuToa = Common.ConDBNull(DataReader["ChuToa"]);
                        data.MaChuToa = Common.ConDBNull(DataReader["MaChuToa"]);

                        data.NgayTao = Common.ConDB_DateTime(DataReader["NgayTao"]);
                        data.NgaySua = Common.ConDB_DateTime(DataReader["NgaySua"]);
                        data.MaSoKy = DataReader.GetString("masokyten");
                        data.NgayKy = DataReader.GetDate("ngayky");
                        data.TenFileKy = DataReader.GetString("tenfileky");
                        data.UserNameKy = DataReader.GetString("usernameky");

                        data.NgayTao = Common.ConDB_DateTime(DataReader["NgayTao"]);
                        data.NguoiTao = Common.ConDBNull(DataReader["NGUOITAO"]);
                        data.NgaySua = Common.ConDB_DateTime(DataReader["NgaySua"]);
                        data.NguoiSua = Common.ConDBNull(DataReader["NGUOISUA"]);
                        data.MaSoKy = DataReader["masokyten"].ToString();
                        data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;
                        data.TenFileKy = Common.ConDBNull(DataReader["tenfileky"]);
                        data.UserNameKy = Common.ConDBNull(DataReader["usernameky"]);
                        return data;
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
            return null;
        }
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, decimal idPhieu)
        {
            string sql2 = @"SELECT
                D.*,
	            T.KHOA,
	            T.GIUONG,
                T.BUONG,
	            T.NGAYVAOVIEN,
	            H.SOYTE,
	            H.BENHVIEN,
	            H.MABENHNHAN,
	            H.TENBENHNHAN,
	            H.TUOI,
	            H.GIOITINH
            FROM
                BienBanHoiChanUngBuou D
                LEFT JOIN THONGTINDIEUTRI T ON D.MAQUANLY = T.MAQUANLY
                LEFT JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
            WHERE
                ID = :ID";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql2, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("ID", idPhieu));

            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            adt.Fill(ds, "BK");
            return ds;
        }
    }
}
