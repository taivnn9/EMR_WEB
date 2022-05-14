using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;


namespace EMR_MAIN.DATABASE.Other
{
    public class BangDGTTNBMoiVaoKhoa : ThongTinKy
    {
        public BangDGTTNBMoiVaoKhoa()
        {
            TableName = "BangDGTTNBMoiVaoKhoa";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BDGTTNBMVK;
            TenMauPhieu = DanhMucPhieu.BDGTTNBMVK.Description();
        }
        [MoTaDuLieu("Mã định danh")]
        public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau", "", 1)]
        public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
        public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
        public string HoTenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
        public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
        public string GioiTinh { get; set; }
        [MoTaDuLieu("Khoa tạo phiếu")]
        public string Khoa { get; set; }
        [MoTaDuLieu("Buồng bệnh nhân")]
        public string Buong { get; set; }
        [MoTaDuLieu("Giường bệnh nhân")]
        public string Giuong { get; set; }
        [MoTaDuLieu("Chẩn đoán")]
        public string ChanDoan { get; set; }
        [MoTaDuLieu("Thể chất: Chiều cao")]
        public string ChieuCao { get; set; }
        [MoTaDuLieu("Thể chất: Cân nặng")]
        public string CanNang { get; set; }
        [MoTaDuLieu("Thể chất: BMI")]
        public string BMI { get; set; }
        [MoTaDuLieu("Binh tĩnh, hợp tác")]
        public int BinhTinhHopTac { get; set; }
        [MoTaDuLieu("Lo lắng sợ hãi")]
        public int LoLangSoHai { get; set; }
        [MoTaDuLieu("Chán nản không hợp tác")]
        public int ChanNanKhongHopTac { get; set; }
        [MoTaDuLieu("Tiền sử dị ứng: 1 -> có, 2 -> không")]
        public int TienSuDiUng { get; set; }
        [MoTaDuLieu("Tiền sử dị ứng số lần")]
        public string TienSuDiUng_SoLan { get; set; }
        [MoTaDuLieu("Tác nhân gây dị ứng")]
        public string TacNhanGayDiUng { get; set; }
        [MoTaDuLieu("Mạch")]
        public string Mach { get; set; }
        [MoTaDuLieu("Nhiệt độ")]
        public string NhietDo { get; set; }
        [MoTaDuLieu("Huyết áp")]
        public string HuyetAp { get; set; }
        [MoTaDuLieu("Nhịp thở")]
        public string NhipTho { get; set; }
        [MoTaDuLieu("SPO2")]
        public string SpO2 { get; set; }
        [MoTaDuLieu("Tinh thần tri giác")]
        public string TinhThanTriGiac { get; set; }
        [MoTaDuLieu("Tình trạng da")]
        public string TinhTrangDa { get; set; }
        [MoTaDuLieu("Tình trạng niêm mạc")]
        public string TinhTrangNiemMac { get; set; }
        [MoTaDuLieu("Đại tiện")]
        public string DaiTien { get; set; }
        [MoTaDuLieu("Tiểu tiện")]
        public string TieuTien { get; set; }
        [MoTaDuLieu("Vận động")]
        public string VanDong { get; set; }
        [MoTaDuLieu("Vệ sinh cá nhân")]
        public string VeSinhCaNhan { get; set; }
        [MoTaDuLieu("Vị trí đau")]
        public string Dau_ViTri { get; set; }
        [MoTaDuLieu("Thời gian đau")]
        public string Dau_ThoiGian { get; set; }
        [MoTaDuLieu("Tính chất đau")]
        public string Dau_TinhChat { get; set; }
        [MoTaDuLieu("Vấn đề khác")]
        public string VanDeKhac { get; set; }
        [MoTaDuLieu("Người đánh giá")]
        public string NguoiDanhGia { get; set; }
        [MoTaDuLieu("Mã người đánh giá")]
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
    public class BangDGTTNBMoiVaoKhoaFun
    {
        public const string TableName = "BangDGTTNBMoiVaoKhoa";
        public const string TablePrimaryKeyName = "ID";
        public static List<BangDGTTNBMoiVaoKhoa> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BangDGTTNBMoiVaoKhoa> list = new List<BangDGTTNBMoiVaoKhoa>();
            try
            {
                string sql = @"SELECT * FROM BangDGTTNBMoiVaoKhoa where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    BangDGTTNBMoiVaoKhoa data = new BangDGTTNBMoiVaoKhoa();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.HoTenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.Khoa = DataReader["Khoa"].ToString();
                    data.Buong = DataReader["Buong"].ToString();
                    data.Giuong = DataReader["Giuong"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.ChieuCao = DataReader["ChieuCao"].ToString();
                    data.CanNang = DataReader["CanNang"].ToString();
                    data.BMI = DataReader["BMI"].ToString();
                    data.BinhTinhHopTac = DataReader.GetInt("BinhTinhHopTac");
                    data.LoLangSoHai = DataReader.GetInt("LoLangSoHai");
                    data.ChanNanKhongHopTac = DataReader.GetInt("ChanNanKhongHopTac");
                    data.TienSuDiUng = DataReader.GetInt("TienSuDiUng");
                    data.TienSuDiUng_SoLan = DataReader["TienSuDiUng_SoLan"].ToString();
                    data.TacNhanGayDiUng = DataReader["TacNhanGayDiUng"].ToString();
                    data.Mach = DataReader["Mach"].ToString();
                    data.NhietDo = DataReader["NhietDo"].ToString();
                    data.HuyetAp = DataReader["HuyetAp"].ToString();
                    data.NhipTho = DataReader["NhipTho"].ToString();
                    data.SpO2 = DataReader["SpO2"].ToString();
                    data.TinhThanTriGiac = DataReader["TinhThanTriGiac"].ToString();
                    data.TinhTrangDa = DataReader["TinhTrangDa"].ToString();
                    data.TinhTrangNiemMac = DataReader["TinhTrangNiemMac"].ToString();
                    data.DaiTien = DataReader["DaiTien"].ToString();
                    data.TieuTien = DataReader["TieuTien"].ToString();
                    data.VanDong = DataReader["VanDong"].ToString();
                    data.VeSinhCaNhan = DataReader["VeSinhCaNhan"].ToString();
                    data.Dau_ViTri = DataReader["Dau_ViTri"].ToString();
                    data.Dau_ThoiGian = DataReader["Dau_ThoiGian"].ToString();
                    data.Dau_TinhChat = DataReader["Dau_TinhChat"].ToString();
                    data.VanDeKhac = DataReader["VanDeKhac"].ToString();
                    data.NguoiDanhGia = DataReader["NguoiDanhGia"].ToString();
                    data.MaNguoiDanhGia = DataReader["MaNguoiDanhGia"].ToString();

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BangDGTTNBMoiVaoKhoa ketQua)
        {
            try
            {
                string sql = @"INSERT INTO BangDGTTNBMoiVaoKhoa
                (
                    MAQUANLY,
                    MaBenhNhan,
                    Khoa,
                    Buong,
                    Giuong,
                    ChanDoan,
                    ChieuCao,
                    CanNang,
                    BMI,
                    BinhTinhHopTac,
                    LoLangSoHai,
                    ChanNanKhongHopTac,
                    TienSuDiUng,
                    TienSuDiUng_SoLan,
                    TacNhanGayDiUng,
                    Mach,
                    NhietDo,
                    HuyetAp,
                    NhipTho,
                    SpO2,
                    TinhThanTriGiac,
                    TinhTrangDa,
                    TinhTrangNiemMac,
                    DaiTien,
                    TieuTien,
                    VanDong,
                    VeSinhCaNhan,
                    Dau_ViTri,
                    Dau_ThoiGian,
                    Dau_TinhChat,
                    VanDeKhac,
                    NguoiDanhGia,
                    MaNguoiDanhGia,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :Khoa,
                    :Buong,
                    :Giuong,
                    :ChanDoan,
                    :ChieuCao,
                    :CanNang,
                    :BMI,
                    :BinhTinhHopTac,
                    :LoLangSoHai,
                    :ChanNanKhongHopTac,
                    :TienSuDiUng,
                    :TienSuDiUng_SoLan,
                    :TacNhanGayDiUng,
                    :Mach,
                    :NhietDo,
                    :HuyetAp,
                    :NhipTho,
                    :SpO2,
                    :TinhThanTriGiac,
                    :TinhTrangDa,
                    :TinhTrangNiemMac,
                    :DaiTien,
                    :TieuTien,
                    :VanDong,
                    :VeSinhCaNhan,
                    :Dau_ViTri,
                    :Dau_ThoiGian,
                    :Dau_TinhChat,
                    :VanDeKhac,
                    :NguoiDanhGia,
                    :MaNguoiDanhGia,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE BangDGTTNBMoiVaoKhoa SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    Khoa = :Khoa,
                    Buong=:Buong,
                    Giuong=:Giuong,
                    ChanDoan=:ChanDoan,
                    ChieuCao=:ChieuCao,
                    CanNang=:CanNang,
                    BMI=:BMI,
                    BinhTinhHopTac=:BinhTinhHopTac,
                    LoLangSoHai=:LoLangSoHai,
                    ChanNanKhongHopTac=:ChanNanKhongHopTac,
                    TienSuDiUng=:TienSuDiUng,
                    TienSuDiUng_SoLan=:TienSuDiUng_SoLan,
                    TacNhanGayDiUng=:TacNhanGayDiUng,
                    Mach=:Mach,
                    NhietDo=:NhietDo,
                    HuyetAp=:HuyetAp,
                    NhipTho=:NhipTho,
                    SpO2=:SpO2,
                    TinhThanTriGiac=:TinhThanTriGiac,
                    TinhTrangDa=:TinhTrangDa,
                    TinhTrangNiemMac=:TinhTrangNiemMac,
                    DaiTien=:DaiTien,
                    TieuTien=:TieuTien,
                    VanDong=:VanDong,
                    VeSinhCaNhan=:VeSinhCaNhan,
                    Dau_ViTri=:Dau_ViTri,
                    Dau_ThoiGian=:Dau_ThoiGian,
                    Dau_TinhChat=:Dau_TinhChat,
                    VanDeKhac=:VanDeKhac,
                    NguoiDanhGia=:NguoiDanhGia,
                    MaNguoiDanhGia=:MaNguoiDanhGia,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ketQua.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa", ketQua.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("Buong", ketQua.Buong));
                Command.Parameters.Add(new MDB.MDBParameter("Giuong", ketQua.Giuong));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", ketQua.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("ChieuCao", ketQua.ChieuCao));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang", ketQua.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("BMI", ketQua.BMI));
                Command.Parameters.Add(new MDB.MDBParameter("BinhTinhHopTac", ketQua.BinhTinhHopTac));
                Command.Parameters.Add(new MDB.MDBParameter("LoLangSoHai", ketQua.LoLangSoHai));
                Command.Parameters.Add(new MDB.MDBParameter("ChanNanKhongHopTac", ketQua.ChanNanKhongHopTac));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuDiUng", ketQua.TienSuDiUng));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuDiUng_SoLan", ketQua.TienSuDiUng_SoLan));
                Command.Parameters.Add(new MDB.MDBParameter("TacNhanGayDiUng", ketQua.TacNhanGayDiUng));
                Command.Parameters.Add(new MDB.MDBParameter("Mach", ketQua.Mach));
                Command.Parameters.Add(new MDB.MDBParameter("NhietDo", ketQua.NhietDo));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetAp", ketQua.HuyetAp));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTho", ketQua.NhipTho));
                Command.Parameters.Add(new MDB.MDBParameter("SpO2", ketQua.SpO2));
                Command.Parameters.Add(new MDB.MDBParameter("TinhThanTriGiac", ketQua.TinhThanTriGiac));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangDa", ketQua.TinhTrangDa));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangNiemMac", ketQua.TinhTrangNiemMac));
                Command.Parameters.Add(new MDB.MDBParameter("DaiTien", ketQua.DaiTien));
                Command.Parameters.Add(new MDB.MDBParameter("TieuTien", ketQua.TieuTien));
                Command.Parameters.Add(new MDB.MDBParameter("VanDong", ketQua.VanDong));
                Command.Parameters.Add(new MDB.MDBParameter("VeSinhCaNhan", ketQua.VeSinhCaNhan));
                Command.Parameters.Add(new MDB.MDBParameter("Dau_ViTri", ketQua.Dau_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("Dau_ThoiGian", ketQua.Dau_ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("Dau_TinhChat", ketQua.Dau_TinhChat));
                Command.Parameters.Add(new MDB.MDBParameter("VanDeKhac", ketQua.VanDeKhac));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiDanhGia", ketQua.NguoiDanhGia));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiDanhGia", ketQua.MaNguoiDanhGia));
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
                string sql = "DELETE FROM BangDGTTNBMoiVaoKhoa WHERE ID = :ID";
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
                P.*,
                H.TenBenhNhan,
                H.Tuoi,
                H.GioiTinh,
                H.SOYTE,
                H.BENHVIEN 
            FROM
                BangDGTTNBMoiVaoKhoa P 
                LEFT JOIN HANHCHINHBENHNHAN H ON P.MABENHNHAN = H.MABENHNHAN
                LEFT JOIN THONGTINDIEUTRI T ON P.MAQUANLY = T.MAQUANLY
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
