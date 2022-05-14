using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuTaiKhamUngThuKhongHacTo : ThongTinKy
    {
        public PhieuTaiKhamUngThuKhongHacTo()
        {
            TableName = "PhieuTKUngThuKhongHacTo";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PTKUTDKHT;
            TenMauPhieu = DanhMucPhieu.PTKUTDKHT.Description();
        }
        [MoTaDuLieu("Mã định danh")]
        public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau", "", 1)]
        public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
        public string MaBenhNhan { get; set; }
        public string HoTenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
        public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
        public string GioiTinh { get; set; }
        [MoTaDuLieu("Ngày khám")]
        public DateTime? NgayKham { get; set; }
        [MoTaDuLieu("1. Toàn thân")]
        public string ToanThan { get; set; }
        [MoTaDuLieu("2. Các bộ phận")]
        public string CacBoPhan { get; set; }
        [MoTaDuLieu("3. Thương tổn cơ bản")]
        public string ThuongTonCoBan { get; set; }
        [MoTaDuLieu("Mạch")]
        public string Mach { get; set; }
        [MoTaDuLieu("Nhiệt độ")]
        public string NhietDo { get; set; }
        [MoTaDuLieu("Huyết áp")]
        public string HuyetAp { get; set; }
        [MoTaDuLieu("Nhịp thở")]
        public string NhipTho { get; set; }
        [MoTaDuLieu("Cân nặng")]
        public string CanNang { get; set; }
        [MoTaDuLieu("Chiều cao")]
        public string ChieuCao { get; set; }
        [MoTaDuLieu("BMI")]
        public string BMI { get; set; }
        [MoTaDuLieu("Hạch, 1-> không sờ thấy, 2 -> sờ thấy")]
        public int Hach { get; set; }
        [MoTaDuLieu("Vị trí hạch")]
        public string Hach_ViTri { get; set; }
        [MoTaDuLieu("Bất thường bộ phận khác (ghi rõ) ")]
        public string BatThuongBoPhanKhac { get; set; }
        [MoTaDuLieu("CHẨN ĐOÁN XÁC ĐỊNH (TNM VÀ GIAI ĐOẠN)")]
        public string ChanDoanXacDinh { get; set; }
        [MoTaDuLieu("ĐIỀU TRỊ")]
        public string DieuTri { get; set; }
        [MoTaDuLieu("HẸN KHÁM LẠI")]
        public string HenKhamLai { get; set; }
        // bắt buộc
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
    public class PhieuTaiKhamUngThuKhongHacToFunc
    {
        public const string TableName = "PhieuTKUngThuKhongHacTo";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuTaiKhamUngThuKhongHacTo> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuTaiKhamUngThuKhongHacTo> list = new List<PhieuTaiKhamUngThuKhongHacTo>();
            try
            {
                string sql = @"SELECT * FROM PhieuTKUngThuKhongHacTo where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuTaiKhamUngThuKhongHacTo data = new PhieuTaiKhamUngThuKhongHacTo();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.HoTenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.NgayKham = DataReader["NgayKham"] != DBNull.Value ? (DateTime?) Convert.ToDateTime(DataReader["NgayKham"].ToString()): null;
                    data.ToanThan = DataReader["ToanThan"].ToString();
                    data.CacBoPhan = DataReader["CacBoPhan"].ToString();
                    data.ThuongTonCoBan = DataReader["ThuongTonCoBan"].ToString();
                    data.Mach = DataReader["Mach"].ToString();
                    data.NhietDo = DataReader["NhietDo"].ToString();
                    data.HuyetAp = DataReader["HuyetAp"].ToString();
                    data.NhipTho = DataReader["NhipTho"].ToString();
                    data.CanNang = DataReader["CanNang"].ToString();
                    data.ChieuCao = DataReader["ChieuCao"].ToString();
                    data.BMI = DataReader["BMI"].ToString();
                    data.Hach = DataReader.GetInt("Hach");
                    data.Hach_ViTri = DataReader["Hach_ViTri"].ToString();
                    data.BatThuongBoPhanKhac = DataReader["BatThuongBoPhanKhac"].ToString();
                    
                    data.ChanDoanXacDinh = DataReader["ChanDoanXacDinh"].ToString();
                    data.DieuTri = DataReader["DieuTri"].ToString();
                    data.HenKhamLai = DataReader["HenKhamLai"].ToString();

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuTaiKhamUngThuKhongHacTo ketQua)
        {
            try
            {
                string sql = @"INSERT INTO PhieuTKUngThuKhongHacTo
                (
                    MAQUANLY,
                    MaBenhNhan,
                    NgayKham,
                    ToanThan,
                    CacBoPhan,
                    ThuongTonCoBan,
                    Mach,
                    NhietDo,
                    HuyetAp,
                    NhipTho,
                    CanNang,
                    ChieuCao,
                    BMI,
                    Hach,
                    Hach_ViTri,
                    BatThuongBoPhanKhac,
                    ChanDoanXacDinh,
                    DieuTri,
                    HenKhamLai,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :NgayKham,
                    :ToanThan,
                    :CacBoPhan,
                    :ThuongTonCoBan,
                    :Mach,
                    :NhietDo,
                    :HuyetAp,
                    :NhipTho,
                    :CanNang,
                    :ChieuCao,
                    :BMI,
                    :Hach,
                    :Hach_ViTri,
                    :BatThuongBoPhanKhac,
                    :ChanDoanXacDinh,
                    :DieuTri,
                    :HenKhamLai,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE PhieuTKUngThuKhongHacTo SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    NgayKham=:NgayKham,
                    ToanThan=:ToanThan,
                    CacBoPhan=:CacBoPhan,
                    ThuongTonCoBan=:ThuongTonCoBan,
                    Mach=:Mach,
                    NhietDo=:NhietDo,
                    HuyetAp=:HuyetAp,
                    NhipTho=:NhipTho,
                    CanNang=:CanNang,
                    ChieuCao=:ChieuCao,
                    BMI=:BMI,
                    Hach=:Hach,
                    Hach_ViTri=:Hach_ViTri,
                    BatThuongBoPhanKhac=:BatThuongBoPhanKhac,
                    CacXetNghiemKhac=:CacXetNghiemKhac,
                    ChanDoanXacDinh=:ChanDoanXacDinh,
                    DieuTri=:DieuTri,
                    HenKhamLai=:HenKhamLai,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ketQua.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("NgayKham", ketQua.NgayKham));
                Command.Parameters.Add(new MDB.MDBParameter("ToanThan", ketQua.ToanThan));
                Command.Parameters.Add(new MDB.MDBParameter("CacBoPhan", ketQua.CacBoPhan));
                Command.Parameters.Add(new MDB.MDBParameter("ThuongTonCoBan", ketQua.ThuongTonCoBan));
                Command.Parameters.Add(new MDB.MDBParameter("Mach", ketQua.Mach));
                Command.Parameters.Add(new MDB.MDBParameter("NhietDo", ketQua.NhietDo));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetAp", ketQua.HuyetAp));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTho", ketQua.NhipTho));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang", ketQua.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("ChieuCao", ketQua.ChieuCao));
                Command.Parameters.Add(new MDB.MDBParameter("BMI", ketQua.BMI));
                Command.Parameters.Add(new MDB.MDBParameter("Hach", ketQua.Hach));
                Command.Parameters.Add(new MDB.MDBParameter("Hach_ViTri", ketQua.Hach_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("BatThuongBoPhanKhac", ketQua.BatThuongBoPhanKhac));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanXacDinh", ketQua.ChanDoanXacDinh));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri", ketQua.DieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("HenKhamLai", ketQua.HenKhamLai));

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
                string sql = "DELETE FROM PhieuTKUngThuKhongHacTo WHERE ID = :ID";
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
                PhieuTKUngThuKhongHacTo P
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
