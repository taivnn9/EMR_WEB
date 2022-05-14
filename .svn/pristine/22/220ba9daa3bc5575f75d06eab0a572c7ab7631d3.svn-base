using EMR.KyDienTu;
using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using System.Data;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class BienBanTuVongNgoaiVien : ThongTinKy
    {
        public BienBanTuVongNgoaiVien()
        {
            TableName = "BienBanTuVongNgoaiVien";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BBTVNV;
            TenMauPhieu = DanhMucPhieu.BBTVNV.Description();
        }
        [MoTaDuLieu("Mã định danh biên bản tử vong ngoài viện")]
		public int IDBienBanTuVongNgoaiVien { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")] 
        public string HoTenBenhNhan { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Ngày vào bệnh viện")]
		public DateTime NgayVaoVien { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        [MoTaDuLieu("Họ tên người đưa vào viện")]
        public string NguoiDuaVao { get; set; }
        [MoTaDuLieu("Địa chỉ người đưa bệnh nhân vào viện")]
		public string DiaChiNguoiDuaVao { get; set; }
        [MoTaDuLieu("Số CMND người đưa bệnh nhân vào viện")]
        public string SoCmnd { get; set; }
        [MoTaDuLieu("Điện thoại người đưa bệnh nhân vào viện")]
        public string DienThoai { get; set; }
        [MoTaDuLieu("Tình trạng khi vào viện")]
        public string TinhTrangVaoVien { get; set; }
        [MoTaDuLieu("Xử lý cấp cứu")]
        public string XuLyCapCuu { get; set; }
        [MoTaDuLieu("Thời gian cấp cứu")]
        public string ThoiGianCapCuu { get; set; }
        [MoTaDuLieu("Tình trạng hiện tại")]
        public string TinhTrangHienTai { get; set; }
        [MoTaDuLieu("Xác nhận tử vong khi vào viện")]
        public string XacNhanTuVongKhiVaoVien { get; set; }
        [MoTaDuLieu("Lãnh đạo trực")]
        public string TrucLanhDao { get; set; }
        [MoTaDuLieu("Mã lãnh đạo trực")]
        public string MaTrucLanhDao { get; set; }
        [MoTaDuLieu("Danh sách nhân viên ca trực cấp cứu")]
        public ObservableCollection<NhanVien> CaTrucCapCuu{ get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Ngày sửa")]
        public DateTime? NgaySua { get; set; }

    }
    public class BienBanTuVongNgoaiVienFunc
    {
        public static BienBanTuVongNgoaiVien select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql = @"select * from BienBanTuVongNgoaiVien WHERE  MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            while (DataReader.Read())
            {
                BienBanTuVongNgoaiVien bienBan = new BienBanTuVongNgoaiVien();
                bienBan.IDBienBanTuVongNgoaiVien = int.Parse(DataReader["IDBienBanTuVongNgoaiVien"].ToString());
                bienBan.MaBenhNhan = DataReader["MaBenhNhan"].ToString();

                bienBan.MaQuanLy = MaQuanLy;
                bienBan.HoTenBenhNhan = DataReader["HoTenBenhNhan"].ToString();
                bienBan.GioiTinh = DataReader["GioiTinh"].ToString();
                bienBan.Tuoi = DataReader["Tuoi"].ToString();
                bienBan.NgayVaoVien = Convert.ToDateTime(DataReader["NgayVaoVien"] == DBNull.Value ? DateTime.Now : DataReader["NgayVaoVien"]);
                bienBan.DiaChi = DataReader["DiaChi"].ToString();
                bienBan.NguoiDuaVao = DataReader["NguoiDuaVao"].ToString();
                bienBan.DiaChiNguoiDuaVao = DataReader["DiaChiNguoiDuaVao"].ToString();
                bienBan.SoCmnd = DataReader["SoCmnd"].ToString();
                bienBan.DienThoai = DataReader["DienThoai"].ToString();
                bienBan.TinhTrangVaoVien = DataReader["TinhTrangVaoVien"].ToString();
                bienBan.XuLyCapCuu = DataReader["XuLyCapCuu"].ToString();
                bienBan.ThoiGianCapCuu = DataReader["ThoiGianCapCuu"].ToString();
                bienBan.TinhTrangHienTai = DataReader["TinhTrangHienTai"].ToString();
                bienBan.XacNhanTuVongKhiVaoVien = DataReader["XacNhanTuVongKhiVaoVien"].ToString();
                bienBan.TrucLanhDao = DataReader["TrucLanhDao"].ToString();
                bienBan.MaTrucLanhDao = DataReader["MaTrucLanhDao"].ToString();
                bienBan.CaTrucCapCuu = JsonConvert.DeserializeObject<ObservableCollection<NhanVien>>(DataReader["CaTrucCapCuu"].ToString());
                bienBan.NguoiTao = DataReader["NguoiTao"].ToString();
                bienBan.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                bienBan.NguoiSua = DataReader["NguoiSua"].ToString();
                bienBan.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);
                return bienBan;
            }
            return null;
        }
        public static DataSet GetDataSet(decimal MaQuanLy, MDB.MDBConnection conn)
        {
            DataSet dataSet = new DataSet();

            string sql = @"SELECT 
                            HOTENBENHNHAN,
                            GIOITINH,
                            TUOI,
                            NGAYVAOVIEN,
                            DIACHI,
                            NGUOIDUAVAO,
                            DIACHINGUOIDUAVAO,
                            SOCMND,
                            DIENTHOAI,
                            TINHTRANGVAOVIEN,
                            XULYCAPCUU,
                            THOIGIANCAPCUU,
                            TINHTRANGHIENTAI,
                            XACNHANTUVONGKHIVAOVIEN,
                            TRUCLANHDAO
                            FROM BIENBANTUVONGNGOAIVIEN WHERE  MAQUANLY = :MAQUANLY";
            MDB.MDBCommand command = new MDB.MDBCommand(sql, conn);
            command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", MaQuanLy));
            MDB.MDBDataAdapter dataAdapter = new MDB.MDBDataAdapter(command);
            dataAdapter.Fill(dataSet, "BIENBAN");


            DataTable caTrucTable = new DataTable("CATRUC");
            caTrucTable.Columns.Add("SO1");
            caTrucTable.Columns.Add("SO2");
            caTrucTable.Columns.Add("SO3");

            sql = @"SELECT CATRUCCAPCUU FROM BIENBANTUVONGNGOAIVIEN WHERE  MAQUANLY = :MAQUANLY";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, conn);
            Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            while (DataReader.Read())
            {
                ObservableCollection<NhanVien>  CaTrucCapCuu = JsonConvert.DeserializeObject<ObservableCollection<NhanVien>>(DataReader["CaTrucCapCuu"].ToString());
                if (CaTrucCapCuu.Count == 1)
                    caTrucTable.Rows.Add(CaTrucCapCuu[0].HoVaTen, "", "");
                if (CaTrucCapCuu.Count == 2)
                    caTrucTable.Rows.Add(CaTrucCapCuu[0].HoVaTen, CaTrucCapCuu[1].HoVaTen, "");
                if (CaTrucCapCuu.Count >= 3)
                    caTrucTable.Rows.Add(CaTrucCapCuu[0].HoVaTen, CaTrucCapCuu[1].HoVaTen, CaTrucCapCuu[2].HoVaTen);
            }
            DataTable thongTinVien = new DataTable("HEADER");
            thongTinVien.Columns.Add("SOYTE");
            thongTinVien.Columns.Add("BENHVIEN");
            if (XemBenhAn._HanhChinhBenhNhan == null) XemBenhAn._HanhChinhBenhNhan = new HanhChinhBenhNhan();
            thongTinVien.Rows.Add(XemBenhAn._HanhChinhBenhNhan.SoYTe, XemBenhAn._HanhChinhBenhNhan.BenhVien);

            dataSet.Tables.Add(caTrucTable);
            dataSet.Tables.Add(thongTinVien);
            return dataSet;
        }
        public static bool insertorUpdate(MDB.MDBConnection MyConnection, ref BienBanTuVongNgoaiVien bienBanTuVongNgoaiVien)
        {
            string sql = @"INSERT INTO BIENBANTUVONGNGOAIVIEN
                (
                    MABENHNHAN,
                    MAQUANLY,
                    HOTENBENHNHAN,
                    GIOITINH,
                    TUOI,
                    NGAYVAOVIEN,
                    DIACHI,
                    NGUOIDUAVAO,
                    DIACHINGUOIDUAVAO,
                    SOCMND,
                    DIENTHOAI,
                    TINHTRANGVAOVIEN,
                    XULYCAPCUU,
                    THOIGIANCAPCUU,
                    TINHTRANGHIENTAI,
                    XACNHANTUVONGKHIVAOVIEN,
                    TRUCLANHDAO,
                    MATRUCLANHDAO,
                    CATRUCCAPCUU,
                    NGUOITAO,
                    NGAYTAO,
                    NGUOISUA,
                    NGAYSUA)  VALUES
                 (
                    :MABENHNHAN,
                    :MAQUANLY,
                    :HOTENBENHNHAN,
                    :GIOITINH,
                    :TUOI,
                    :NGAYVAOVIEN,
                    :DIACHI,
                    :NGUOIDUAVAO,
                    :DIACHINGUOIDUAVAO,
                    :SOCMND,
                    :DIENTHOAI,
                    :TINHTRANGVAOVIEN,
                    :XULYCAPCUU,
                    :THOIGIANCAPCUU,
                    :TINHTRANGHIENTAI,
                    :XACNHANTUVONGKHIVAOVIEN,
                    :TRUCLANHDAO,
                    :MATRUCLANHDAO,    
                    :CATRUCCAPCUU,
                    :NGUOITAO,
                    :NGAYTAO,
                    :NGUOISUA,
                    :NGAYSUA
                )  RETURNING IDBIENBANTUVONGNGOAIVIEN INTO :IDBIENBANTUVONGNGOAIVIEN";
            if (bienBanTuVongNgoaiVien.IDBienBanTuVongNgoaiVien != 0)
            {
                sql = @"UPDATE BIENBANTUVONGNGOAIVIEN SET 
                    MABENHNHAN = :MABENHNHAN, 
                    MAQUANLY = :MAQUANLY,
                    HOTENBENHNHAN = :HOTENBENHNHAN, 
                    GIOITINH = :GIOITINH,
                    TUOI = :TUOI,
                    NGAYVAOVIEN = :NGAYVAOVIEN,
                    DIACHI = :DIACHI,
                    NGUOIDUAVAO = :NGUOIDUAVAO,
                    DIACHINGUOIDUAVAO = :DIACHINGUOIDUAVAO,
                    SOCMND = :SOCMND,
                    DIENTHOAI = :DIENTHOAI,
                    TINHTRANGVAOVIEN = :TINHTRANGVAOVIEN,
                    XULYCAPCUU = :XULYCAPCUU,
                    THOIGIANCAPCUU = :THOIGIANCAPCUU,
                    TINHTRANGHIENTAI = :TINHTRANGHIENTAI,
                    XACNHANTUVONGKHIVAOVIEN = :XACNHANTUVONGKHIVAOVIEN,
                    TRUCLANHDAO = :TRUCLANHDAO,
                    MATRUCLANHDAO = :MATRUCLANHDAO,
                    CATRUCCAPCUU = :CATRUCCAPCUU,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE IDBIENBANTUVONGNGOAIVIEN = " + bienBanTuVongNgoaiVien.IDBienBanTuVongNgoaiVien;
            }
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MABENHNHAN", bienBanTuVongNgoaiVien.MaBenhNhan));
            Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bienBanTuVongNgoaiVien.MaQuanLy));
            Command.Parameters.Add(new MDB.MDBParameter("HOTENBENHNHAN", bienBanTuVongNgoaiVien.HoTenBenhNhan));
            Command.Parameters.Add(new MDB.MDBParameter("GIOITINH", bienBanTuVongNgoaiVien.GioiTinh));
            Command.Parameters.Add(new MDB.MDBParameter("TUOI", bienBanTuVongNgoaiVien.Tuoi));
            Command.Parameters.Add(new MDB.MDBParameter("NGAYVAOVIEN", bienBanTuVongNgoaiVien.NgayVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("DIACHI", bienBanTuVongNgoaiVien.DiaChi));
            Command.Parameters.Add(new MDB.MDBParameter("NGUOIDUAVAO", bienBanTuVongNgoaiVien.NguoiDuaVao));
            Command.Parameters.Add(new MDB.MDBParameter("DIACHINGUOIDUAVAO", bienBanTuVongNgoaiVien.DiaChiNguoiDuaVao));
            Command.Parameters.Add(new MDB.MDBParameter("SOCMND", bienBanTuVongNgoaiVien.SoCmnd));
            Command.Parameters.Add(new MDB.MDBParameter("DIENTHOAI", bienBanTuVongNgoaiVien.DienThoai));
            Command.Parameters.Add(new MDB.MDBParameter("TINHTRANGVAOVIEN", bienBanTuVongNgoaiVien.TinhTrangVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("XULYCAPCUU", bienBanTuVongNgoaiVien.XuLyCapCuu));
            Command.Parameters.Add(new MDB.MDBParameter("THOIGIANCAPCUU", bienBanTuVongNgoaiVien.ThoiGianCapCuu));
            Command.Parameters.Add(new MDB.MDBParameter("TINHTRANGHIENTAI", bienBanTuVongNgoaiVien.TinhTrangHienTai));
            Command.Parameters.Add(new MDB.MDBParameter("TRUCLANHDAO", bienBanTuVongNgoaiVien.TrucLanhDao));
            Command.Parameters.Add(new MDB.MDBParameter("MATRUCLANHDAO", bienBanTuVongNgoaiVien.MaTrucLanhDao));
            Command.Parameters.Add(new MDB.MDBParameter("XACNHANTUVONGKHIVAOVIEN", bienBanTuVongNgoaiVien.XacNhanTuVongKhiVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("CATRUCCAPCUU", JsonConvert.SerializeObject(bienBanTuVongNgoaiVien.CaTrucCapCuu)));
            Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", bienBanTuVongNgoaiVien.NguoiSua));
            Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", bienBanTuVongNgoaiVien.NgaySua));
            if (bienBanTuVongNgoaiVien.IDBienBanTuVongNgoaiVien == 0)
            {
                Command.Parameters.Add(new MDB.MDBParameter("IDBIENBANTUVONGNGOAIVIEN", bienBanTuVongNgoaiVien.IDBienBanTuVongNgoaiVien));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", bienBanTuVongNgoaiVien.NguoiTao));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", bienBanTuVongNgoaiVien.NgayTao));
            }
            Command.BindByName = true;
            int n = Command.ExecuteNonQuery(); // C#
            if (bienBanTuVongNgoaiVien.IDBienBanTuVongNgoaiVien == 0)
            {
                int nextval = Convert.ToInt32((Command.Parameters["IDBIENBANTUVONGNGOAIVIEN"] as MDB.MDBParameter).Value);
                bienBanTuVongNgoaiVien.IDBienBanTuVongNgoaiVien = nextval;
            }
            return n > 0 ? true : false;
        }
    }
}
