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
    public class DanhGiaTinhTrangNguoiBenh : ThongTinKy
    {
        public DanhGiaTinhTrangNguoiBenh()
        {
            TableName = "BangDanhGiaTTNBMVK";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BDGTTNBMVK;
            TenMauPhieu = DanhMucPhieu.BDGTTNBMVK.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        public string Khoa { get; set; }
        public string MaKhoa { get; set; }
        public string Buong { get; set; }
        public string Giuong { get; set; }
        public string HoTenNB { get; set; }
        public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
        public string GioiTinh { get; set; }
        public string ChanDoan { get; set; }
        public string ChieuCao { get; set; }
        public string CanNang { get; set; }
        public string BMI { get; set; }
        public int TamLy { get; set; }
        public int TienSuDiUng { get; set; }
        public string SoLanDiUng { get; set; }
        public string TacNhanDiUng1 { get; set; }
        public string TacNhanDiUng2 { get; set; }
        public string TacNhanDiUng3 { get; set; }
        public string Mach { get; set; }
        public string NhietDo { get; set; }
        public string HuyetAp { get; set; }
        public string NhipTho { get; set; }
        public string SP02 { get; set; }
        public string TinhThan { get; set; }
        public string TinhTrangDa { get; set; }
        public string TinhTrangNiemMac { get; set; }
        public string DaiTien { get; set; }
        public string TieuTien { get; set; }
        public string VanDong { get; set; }
        public string VeSinh { get; set; }
        public string ViTriDau { get; set; }
        public DateTime ThoiGianDau { get; set; }
        public string TinhChat { get; set; }
        public string VanDeKhac { get; set; }
        public DateTime ThoiGianKy { get; set; }
        public string NguoiDanhGia { get; set; }
        public string MaNguoiDanhGia { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
    }

    public class DanhGiaTinhTrangNguoiBenhFunc
    {
        public const string TableName = "BangDanhGiaTTNBMVK";
        public const string TablePrimaryKeyName = "ID";
        public static List<DanhGiaTinhTrangNguoiBenh> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<DanhGiaTinhTrangNguoiBenh> list = new List<DanhGiaTinhTrangNguoiBenh>();
            try
            {
                string sql = @"SELECT * FROM BangDanhGiaTTNBMVK where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    DanhGiaTinhTrangNguoiBenh data = new DanhGiaTinhTrangNguoiBenh();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.Khoa = Common.ConDBNull(DataReader["Khoa"]);
                    data.MaKhoa = Common.ConDBNull(DataReader["MaKhoa"]);
                    data.Buong = Common.ConDBNull(DataReader["Buong"]);
                    data.Giuong = Common.ConDBNull(DataReader["Giuong"]);
                    data.HoTenNB = Common.ConDBNull(DataReader["HoTenNB"]);
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.ChanDoan = Common.ConDBNull(DataReader["ChanDoan"]);
                    data.ChieuCao = Common.ConDBNull(DataReader["ChieuCao"]);
                    data.CanNang = Common.ConDBNull(DataReader["CanNang"]);
                    data.BMI = Common.ConDBNull(DataReader["BMI"]);
                    data.TamLy = Common.ConDB_Int(DataReader["TamLy"]);
                    data.TienSuDiUng = Common.ConDB_Int(DataReader["TienSuDiUng"]);
                    data.SoLanDiUng = Common.ConDBNull(DataReader["SoLanDiUng"]);
                    data.TacNhanDiUng1 = Common.ConDBNull(DataReader["TacNhanDiUng1"]);
                    data.TacNhanDiUng2 = Common.ConDBNull(DataReader["TacNhanDiUng2"]);
                    data.TacNhanDiUng3 = Common.ConDBNull(DataReader["TacNhanDiUng3"]);
                    data.Mach = Common.ConDBNull(DataReader["Mach"]);
                    data.NhietDo = Common.ConDBNull(DataReader["NhietDo"]);
                    data.HuyetAp = Common.ConDBNull(DataReader["HuyetAp"]);
                    data.NhipTho = Common.ConDBNull(DataReader["NhipTho"]);
                    data.SP02 = Common.ConDBNull(DataReader["SP02"]);
                    data.TinhThan = Common.ConDBNull(DataReader["TinhThan"]);
                    data.TinhTrangDa = Common.ConDBNull(DataReader["TinhTrangDa"]);
                    data.TinhTrangNiemMac = Common.ConDBNull(DataReader["TinhTrangNiemMac"]);
                    data.DaiTien = Common.ConDBNull(DataReader["DaiTien"]);
                    data.TieuTien = Common.ConDBNull(DataReader["TieuTien"]);
                    data.VanDong = Common.ConDBNull(DataReader["VanDong"]);
                    data.VeSinh = Common.ConDBNull(DataReader["VeSinh"]);
                    data.ViTriDau = Common.ConDBNull(DataReader["ViTriDau"]);
                    data.ThoiGianDau = Common.ConDB_DateTime(DataReader["ThoiGianDau"]);
                    data.TinhChat = Common.ConDBNull(DataReader["TinhChat"]);
                    data.VanDeKhac = Common.ConDBNull(DataReader["VanDeKhac"]);
                    data.ThoiGianKy = Common.ConDB_DateTime(DataReader["ThoiGianKy"]);
                    data.NguoiDanhGia = Common.ConDBNull(DataReader["NguoiDanhGia"]);
                    data.MaNguoiDanhGia = Common.ConDBNull(DataReader["MaNguoiDanhGia"]);
                    data.NgayTao = Common.ConDB_DateTime(DataReader["NgayTao"]);
                    data.NguoiTao = DataReader["NguoiTao"].ToString();
                    data.NgaySua = Common.ConDB_DateTime(DataReader["NgaySua"]);
                    data.NguoiSua = DataReader["NguoiSua"].ToString();
                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy);
                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref DanhGiaTinhTrangNguoiBenh data)
        {
            try
            {
                string sql = @"INSERT INTO BangDanhGiaTTNBMVK
                (
                    MaQuanLy,
                    MaBenhNhan,
                    Khoa,
                    MaKhoa,
                    Buong,
                    Giuong,
                    HoTenNB,
                    Tuoi,
                    GioiTinh,
                    ChanDoan,
                    ChieuCao,
                    CanNang,
                    BMI,
                    TamLy,
                    TienSuDiUng,
                    SoLanDiUng,
                    TacNhanDiUng1,
                    TacNhanDiUng2,
                    TacNhanDiUng3,
                    Mach,
                    NhietDo,
                    HuyetAp,
                    NhipTho,
                    SP02,
                    TinhThan,
                    TinhTrangDa,
                    TinhTrangNiemMac,
                    DaiTien,
                    TieuTien,
                    VanDong,
                    VeSinh,
                    ViTriDau,
                    ThoiGianDau,
                    TinhChat,
                    VanDeKhac,
                    ThoiGianKy,
                    NguoiDanhGia,
                    MaNguoiDanhGia,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
                    :MaQuanLy,
                    :MaBenhNhan,
                    :Khoa,
                    :MaKhoa,
                    :Buong,
                    :Giuong,
                    :HoTenNB,
                    :Tuoi,
                    :GioiTinh,
                    :ChanDoan,
                    :ChieuCao,
                    :CanNang,
                    :BMI,
                    :TamLy,
                    :TienSuDiUng,
                    :SoLanDiUng,
                    :TacNhanDiUng1,
                    :TacNhanDiUng2,
                    :TacNhanDiUng3,
                    :Mach,
                    :NhietDo,
                    :HuyetAp,
                    :NhipTho,
                    :SP02,
                    :TinhThan,
                    :TinhTrangDa,
                    :TinhTrangNiemMac,
                    :DaiTien,
                    :TieuTien,
                    :VanDong,
                    :VeSinh,
                    :ViTriDau,
                    :ThoiGianDau,
                    :TinhChat,
                    :VanDeKhac,
                    :ThoiGianKy,
                    :NguoiDanhGia,
                    :MaNguoiDanhGia,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (data.ID != 0)
                {
                    sql = @"UPDATE BangDanhGiaTTNBMVK SET 
                    MaQuanLy=:MaQuanLy,
                    MaBenhNhan=:MaBenhNhan,
                    Khoa=:Khoa,
                    MaKhoa=:MaKhoa,
                    Buong=:Buong,
                    Giuong=:Giuong,
                    HoTenNB=:HoTenNB,
                    Tuoi=:Tuoi,
                    GioiTinh=:GioiTinh,
                    ChanDoan=:ChanDoan,
                    ChieuCao=:ChieuCao,
                    CanNang=:CanNang,
                    BMI=:BMI,
                    TamLy=:TamLy,
                    TienSuDiUng=:TienSuDiUng,
                    SoLanDiUng=:SoLanDiUng,
                    TacNhanDiUng1=:TacNhanDiUng1,
                    TacNhanDiUng2=:TacNhanDiUng2,
                    TacNhanDiUng3=:TacNhanDiUng3,
                    Mach=:Mach,
                    NhietDo=:NhietDo,
                    HuyetAp=:HuyetAp,
                    NhipTho=:NhipTho,
                    SP02=:SP02,
                    TinhThan=:TinhThan,
                    TinhTrangDa=:TinhTrangDa,
                    TinhTrangNiemMac=:TinhTrangNiemMac,
                    DaiTien=:DaiTien,
                    TieuTien=:TieuTien,
                    VanDong=:VanDong,
                    VeSinh=:VeSinh,
                    ViTriDau=:ViTriDau,
                    ThoiGianDau=:ThoiGianDau,
                    TinhChat=:TinhChat,
                    VanDeKhac=:VanDeKhac,
                    ThoiGianKy=:ThoiGianKy,
                    NguoiDanhGia=:NguoiDanhGia,
                    MaNguoiDanhGia=:MaNguoiDanhGia,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + data.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", data.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", data.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa", data.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaKhoa", data.MaKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("Buong", data.Buong));
                Command.Parameters.Add(new MDB.MDBParameter("Giuong", data.Giuong));
                Command.Parameters.Add(new MDB.MDBParameter("HoTenNB", data.HoTenNB));
                Command.Parameters.Add(new MDB.MDBParameter("Tuoi", data.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("GioiTinh", data.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", data.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("ChieuCao", data.ChieuCao));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang", data.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("BMI", data.BMI));
                Command.Parameters.Add(new MDB.MDBParameter("TamLy", data.TamLy));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuDiUng", data.TienSuDiUng));
                Command.Parameters.Add(new MDB.MDBParameter("SoLanDiUng", data.SoLanDiUng));
                Command.Parameters.Add(new MDB.MDBParameter("TacNhanDiUng1", data.TacNhanDiUng1));
                Command.Parameters.Add(new MDB.MDBParameter("TacNhanDiUng2", data.TacNhanDiUng2));
                Command.Parameters.Add(new MDB.MDBParameter("TacNhanDiUng3", data.TacNhanDiUng3));
                Command.Parameters.Add(new MDB.MDBParameter("Mach", data.Mach));
                Command.Parameters.Add(new MDB.MDBParameter("NhietDo", data.NhietDo));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetAp", data.HuyetAp));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTho", data.NhipTho));
                Command.Parameters.Add(new MDB.MDBParameter("SP02", data.SP02));
                Command.Parameters.Add(new MDB.MDBParameter("TinhThan", data.TinhThan));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangDa", data.TinhTrangDa));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangNiemMac", data.TinhTrangNiemMac));
                Command.Parameters.Add(new MDB.MDBParameter("DaiTien", data.DaiTien));
                Command.Parameters.Add(new MDB.MDBParameter("TieuTien", data.TieuTien));
                Command.Parameters.Add(new MDB.MDBParameter("VanDong", data.VanDong));
                Command.Parameters.Add(new MDB.MDBParameter("VeSinh", data.VeSinh));
                Command.Parameters.Add(new MDB.MDBParameter("ViTriDau", data.ViTriDau));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianDau", data.ThoiGianDau));
                Command.Parameters.Add(new MDB.MDBParameter("TinhChat", data.TinhChat));
                Command.Parameters.Add(new MDB.MDBParameter("VanDeKhac", data.VanDeKhac));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianKy", data.ThoiGianKy));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiDanhGia", data.NguoiDanhGia));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiDanhGia", data.MaNguoiDanhGia));
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
                    data.ID = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                }
                return n > 0;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool Delete(MDB.MDBConnection MyConnection, long id)
        {
            try
            {
                string sql = "DELETE FROM BangDanhGiaTTNBMVK WHERE ID = :ID";
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
        public static DataSet getDataSet(MDB.MDBConnection MyConnection, long id)
        {
            string sql = @"SELECT
                P.*,
                H.GIOITINH,
	            H.TENBENHNHAN,
                H.TUOI,
                H.SOYTE,
                H.BENHVIEN,
                (H.SONHA || ',' || H.THONPHO || ',' ||  H.XAPHUONG || ',' ||  H.HUYENQUAN || ',' ||  H.TINHTHANHPHO) AS DIACHI 
            FROM
                BangDanhGiaTTNBMVK P
                LEFT JOIN THONGTINDIEUTRI T ON P.MAQUANLY = T.MAQUANLY
                LEFT JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            adt.Fill(ds, "Table");
            return ds;
        }
    }
}
