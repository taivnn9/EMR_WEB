using EMR.KyDienTu;
using Newtonsoft.Json;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuKiemSoatNBTruocMo : ThongTinKy
    {
        public PhieuKiemSoatNBTruocMo()
        {
            TableName = "PhieuKiemSoatNBTruocMo";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PKSNBTM;
            TenMauPhieu = DanhMucPhieu.PKSNBTM.Description();
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
        [MoTaDuLieu("Khoa")]
        public string Khoa { get; set; }
        [MoTaDuLieu("Ngày vào viện")]
        public DateTime? NgayVaoVien { get; set; }
        [MoTaDuLieu("Mã điều trị")]
        public string MaDieuTri { get; set; }
        [MoTaDuLieu("Mổ phiên, 1-> có, 0 -> không")]
        public int MoPhien { get; set; }
        [MoTaDuLieu("Mổ cấp cứu, 1-> có, 0 -> không")]
        public int MoCapCuu { get; set; }
        [MoTaDuLieu("Chẩn đoán trước mổ")]
        public string ChanDoanTruocMo { get; set; }
        [MoTaDuLieu("Tiền sử dị ứng, 1-> không, 2-> có")]
        public int TienSuDiUng { get; set; }
        [MoTaDuLieu("Tiền sử dị ứng, ghi rõ")]
        public string TienSuDiUng_GhiRo { get; set; }
        [MoTaDuLieu("Tiền sử bệnh, 1-> không, 2-> có")]
        public int TienSuBenh { get; set; }
        [MoTaDuLieu("Tiền sử bệnh, ghi rõ")]
        public string TienSuBenh_GhiRo { get; set; }
        [MoTaDuLieu("Chiều cao")]
        public string ChieuCao { get; set; }
        [MoTaDuLieu("Cân nặng")]
        public string CanNang { get; set; }
        [MoTaDuLieu("BMI")]
        public string BMI { get; set; }
        [MoTaDuLieu("Nhóm máu")]
        public string NhomMau { get; set; }
        [MoTaDuLieu("Phương pháp phẫu thuật (dự kiến)")]
        public string PhuongPhapPhauThuat { get; set; }
        // CÁC CHI TIẾT CẦN KIỂM TRA
        [MoTaDuLieu("CÁC CHI TIẾT CẦN KIỂM TRA")]
        public ObservableCollection<CacChiTietCanKiemTra> CacChiTietCanKiemTras { get; set; }
        // Dấu hiệu sinh tồn
        [MoTaDuLieu("Mạch, Kiểm tra tại khoa trước khi chuyển đến phòng mổ")]
        public string Mach_Truoc { get; set; }
        [MoTaDuLieu("Huyết Áp, Kiểm tra tại khoa trước khi chuyển đến phòng mổ")]
        public string HA_Truoc { get; set; }
        [MoTaDuLieu("Nhiệt độ, Kiểm tra tại khoa trước khi chuyển đến phòng mổ")]
        public string NhietDo_Truoc { get; set; }
        [MoTaDuLieu("Nhịp thở, Kiểm tra tại khoa trước khi chuyển đến phòng mổ")]
        public string NhipTho_Truoc { get; set; }
        [MoTaDuLieu("Mạch, Kỹ thuật viên/dụng cụ viên khoa phẫu thuật kiểm tra lại ")]
        public string Mach_Sau { get; set; }
        [MoTaDuLieu("Huyết Áp, Kỹ thuật viên/dụng cụ viên khoa phẫu thuật kiểm tra lại ")]
        public string HA_Sau { get; set; }
        [MoTaDuLieu("Nhiệt độ, Kỹ thuật viên/dụng cụ viên khoa phẫu thuật kiểm tra lại ")]
        public string NhietDo_Sau { get; set; }
        [MoTaDuLieu("Nhịp thở, Kỹ thuật viên/dụng cụ viên khoa phẫu thuật kiểm tra lại ")]
        public string NhipTho_Sau { get; set; }
        [MoTaDuLieu("Điều dưỡng giao người bệnh của khoa, ngày")]
        public DateTime? DDGiaoNguoiBenh_Ngay { get; set; }
        [MoTaDuLieu("Điều dưỡng giao người bệnh của khoa")]
        public string DDGiaoNguoiBenh { get; set; }
        [MoTaDuLieu(" Mã điều dưỡng giao người bệnh của khoa")]
        public string MaDDGiaoNguoiBenh { get; set; }
        [MoTaDuLieu("Điều dưỡng nhận người bệnh của khoa PTGM, ngày")]
        public DateTime? DDNhanNguoiBenh_Ngay { get; set; }
        [MoTaDuLieu("Điều dưỡng nhận người bệnh của khoa PTGM")]
        public string DDNhanNguoiBenh { get; set; }
        [MoTaDuLieu(" Mã Điều dưỡng nhận người bệnh của khoa PTGM")]
        public string MaDDNhanNguoiBenh { get; set; }

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
    public class CacChiTietCanKiemTra
    {
        [MoTaDuLieu("Kiểm tra tại khoa trước khi chuyển đến phòng mổ, có")]
        public bool KTT_Co { get; set; }
        [MoTaDuLieu("Kiểm tra tại khoa trước khi chuyển đến phòng mổ, không")]
        public bool KTT_Khong { get; set; }
        [MoTaDuLieu("Nội dung kiểm tra")]
        public string NoiDung { get; set; }
        [MoTaDuLieu("Kỹ thuật viên/dụng cụ viên khoa phẫu thuật kiểm tra lại , có")]
        public bool KTS_Co { get; set; }
        [MoTaDuLieu("Kỹ thuật viên/dụng cụ viên khoa phẫu thuật kiểm tra lại , không")]
        public bool KTS_Khong { get; set; }
    }
    public class PhieuKiemSoatNBTruocMoFunc
    {
        public const string TableName = "PhieuKiemSoatNBTruocMo";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuKiemSoatNBTruocMo> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuKiemSoatNBTruocMo> list = new List<PhieuKiemSoatNBTruocMo>();
            try
            {
                string sql = @"SELECT * FROM PhieuKiemSoatNBTruocMo where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuKiemSoatNBTruocMo data = new PhieuKiemSoatNBTruocMo();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.HoTenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();

                    data.Khoa = DataReader["Khoa"].ToString();
                    data.NgayVaoVien = DataReader["NgayVaoVien"] != DBNull.Value ? (DateTime?) Convert.ToDateTime(DataReader["NgayVaoVien"].ToString()): null;
                    data.MaDieuTri = DataReader["MaDieuTri"].ToString();
                    data.MoPhien = DataReader.GetInt("MoPhien");
                    data.MoCapCuu = DataReader.GetInt("MoCapCuu");
                    data.ChanDoanTruocMo = DataReader["ChanDoanTruocMo"].ToString();
                    data.TienSuDiUng = DataReader.GetInt("TienSuDiUng");
                    data.TienSuDiUng_GhiRo = DataReader["TienSuDiUng_GhiRo"].ToString();
                    data.TienSuBenh = DataReader.GetInt("TienSuBenh");
                    data.TienSuBenh_GhiRo = DataReader["TienSuBenh_GhiRo"].ToString();
                    data.ChieuCao = DataReader["ChieuCao"].ToString();
                    data.CanNang = DataReader["CanNang"].ToString();
                    data.BMI = DataReader["BMI"].ToString();
                    data.NhomMau = DataReader["NhomMau"].ToString();
                    data.PhuongPhapPhauThuat = DataReader["PhuongPhapPhauThuat"].ToString();
                    string bangKeJson = DataReader["CacChiTietCanKiemTras_1"].ToString();
                    if (DataReader["CacChiTietCanKiemTras_2"] != DBNull.Value)
                        bangKeJson += DataReader["CacChiTietCanKiemTras_2"].ToString();
                    if (DataReader["CacChiTietCanKiemTras_3"] != DBNull.Value)
                        bangKeJson += DataReader["CacChiTietCanKiemTras_3"].ToString();
                    data.CacChiTietCanKiemTras = JsonConvert.DeserializeObject<ObservableCollection<CacChiTietCanKiemTra>>(bangKeJson);
                    data.Mach_Truoc = DataReader["Mach_Truoc"].ToString();
                    data.HA_Truoc = DataReader["HA_Truoc"].ToString();
                    data.NhietDo_Truoc = DataReader["NhietDo_Truoc"].ToString();
                    data.NhipTho_Truoc = DataReader["NhipTho_Truoc"].ToString();
                    data.Mach_Sau = DataReader["Mach_Sau"].ToString();
                    data.HA_Sau = DataReader["HA_Sau"].ToString();
                    data.NhietDo_Sau = DataReader["NhietDo_Sau"].ToString();
                    data.NhipTho_Sau = DataReader["NhipTho_Sau"].ToString();
                    data.DDGiaoNguoiBenh_Ngay = DataReader["DDGiaoNguoiBenh_Ngay"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["DDGiaoNguoiBenh_Ngay"].ToString()) : null;
                    data.DDGiaoNguoiBenh = DataReader["DDGiaoNguoiBenh"].ToString();
                    data.MaDDGiaoNguoiBenh = DataReader["MaDDGiaoNguoiBenh"].ToString();
                    data.DDNhanNguoiBenh_Ngay = DataReader["DDNhanNguoiBenh_Ngay"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["DDNhanNguoiBenh_Ngay"].ToString()) : null;
                    data.DDNhanNguoiBenh = DataReader["DDNhanNguoiBenh"].ToString();
                    data.MaDDNhanNguoiBenh = DataReader["MaDDNhanNguoiBenh"].ToString();


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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuKiemSoatNBTruocMo ketQua)
        {
            try
            {
                string sql = @"INSERT INTO PhieuKiemSoatNBTruocMo
                (
                    MAQUANLY,
                    MaBenhNhan,
                    Khoa,
                    NgayVaoVien,
                    MaDieuTri,
                    MoPhien,
                    MoCapCuu,
                    ChanDoanTruocMo,
                    TienSuDiUng,
                    TienSuDiUng_GhiRo,
                    TienSuBenh,
                    TienSuBenh_GhiRo,
                    ChieuCao,
                    CanNang,
                    BMI,
                    NhomMau,
                    PhuongPhapPhauThuat,
                    CacChiTietCanKiemTras_1,
                    CacChiTietCanKiemTras_2,
                    CacChiTietCanKiemTras_3,
                    Mach_Truoc,
                    HA_Truoc,
                    NhietDo_Truoc,
                    NhipTho_Truoc,
                    Mach_Sau,
                    HA_Sau,
                    NhietDo_Sau,
                    NhipTho_Sau,
                    DDGiaoNguoiBenh_Ngay,
                    DDGiaoNguoiBenh,
                    MaDDGiaoNguoiBenh,
                    DDNhanNguoiBenh_Ngay,
                    DDNhanNguoiBenh,
                    MaDDNhanNguoiBenh,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :Khoa,
                    :NgayVaoVien,
                    :MaDieuTri,
                    :MoPhien,
                    :MoCapCuu,
                    :ChanDoanTruocMo,
                    :TienSuDiUng,
                    :TienSuDiUng_GhiRo,
                    :TienSuBenh,
                    :TienSuBenh_GhiRo,
                    :ChieuCao,
                    :CanNang,
                    :BMI,
                    :NhomMau,
                    :PhuongPhapPhauThuat,
                    :CacChiTietCanKiemTras_1,
                    :CacChiTietCanKiemTras_2,
                    :CacChiTietCanKiemTras_3,
                    :Mach_Truoc,
                    :HA_Truoc,
                    :NhietDo_Truoc,
                    :NhipTho_Truoc,
                    :Mach_Sau,
                    :HA_Sau,
                    :NhietDo_Sau,
                    :NhipTho_Sau,
                    :DDGiaoNguoiBenh_Ngay,
                    :DDGiaoNguoiBenh,
                    :MaDDGiaoNguoiBenh,
                    :DDNhanNguoiBenh_Ngay,
                    :DDNhanNguoiBenh,
                    :MaDDNhanNguoiBenh,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE PhieuKiemSoatNBTruocMo SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    Khoa=:Khoa,
                    NgayVaoVien=:NgayVaoVien,
                    MaDieuTri=:MaDieuTri,
                    MoPhien=:MoPhien,
                    MoCapCuu=:MoCapCuu,
                    ChanDoanTruocMo=:ChanDoanTruocMo,
                    TienSuDiUng=:TienSuDiUng,
                    TienSuDiUng_GhiRo=:TienSuDiUng_GhiRo,
                    TienSuBenh=:TienSuBenh,
                    TienSuBenh_GhiRo=:TienSuBenh_GhiRo,
                    ChieuCao=:ChieuCao,
                    CanNang=:CanNang,
                    BMI=:BMI,
                    NhomMau=:NhomMau,
                    PhuongPhapPhauThuat=:PhuongPhapPhauThuat,
                    CacChiTietCanKiemTras_1=:CacChiTietCanKiemTras_1,
                    CacChiTietCanKiemTras_2=:CacChiTietCanKiemTras_2,
                    CacChiTietCanKiemTras_3=:CacChiTietCanKiemTras_3,
                    Mach_Truoc=:Mach_Truoc,
                    HA_Truoc=:HA_Truoc,
                    NhietDo_Truoc=:NhietDo_Truoc,
                    NhipTho_Truoc=:NhipTho_Truoc,
                    Mach_Sau=:Mach_Sau,
                    HA_Sau=:HA_Sau,
                    NhietDo_Sau=:NhietDo_Sau,
                    NhipTho_Sau=:NhipTho_Sau,
                    DDGiaoNguoiBenh_Ngay=:DDGiaoNguoiBenh_Ngay,
                    DDGiaoNguoiBenh=:DDGiaoNguoiBenh,
                    MaDDGiaoNguoiBenh=:MaDDGiaoNguoiBenh,
                    DDNhanNguoiBenh_Ngay=:DDNhanNguoiBenh_Ngay,
                    DDNhanNguoiBenh=:DDNhanNguoiBenh,
                    MaDDNhanNguoiBenh=:MaDDNhanNguoiBenh,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ketQua.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa", ketQua.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("NgayVaoVien", ketQua.NgayVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuTri", ketQua.MaDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("MoPhien", ketQua.MoPhien));
                Command.Parameters.Add(new MDB.MDBParameter("MoCapCuu", ketQua.MoCapCuu));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTruocMo", ketQua.ChanDoanTruocMo));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuDiUng", ketQua.TienSuDiUng));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuDiUng_GhiRo", ketQua.TienSuDiUng_GhiRo));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuBenh", ketQua.TienSuBenh));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuBenh_GhiRo", ketQua.TienSuBenh_GhiRo));
                Command.Parameters.Add(new MDB.MDBParameter("ChieuCao", ketQua.ChieuCao));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang", ketQua.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("BMI", ketQua.BMI));
                Command.Parameters.Add(new MDB.MDBParameter("NhomMau", ketQua.NhomMau));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapPhauThuat", ketQua.PhuongPhapPhauThuat));
                string jsonBangKes = JsonConvert.SerializeObject(ketQua.CacChiTietCanKiemTras);
                List<string> listJson = Common.SplitByLength(jsonBangKes, 3999).ToList();
                Command.Parameters.Add(new MDB.MDBParameter("CacChiTietCanKiemTras_1", listJson[0]));
                Command.Parameters.Add(new MDB.MDBParameter("CacChiTietCanKiemTras_2", listJson.Count > 1 ? listJson[1] : null));
                Command.Parameters.Add(new MDB.MDBParameter("CacChiTietCanKiemTras_3", listJson.Count > 2 ? listJson[2] : null));
                Command.Parameters.Add(new MDB.MDBParameter("Mach_Truoc", ketQua.Mach_Truoc));
                Command.Parameters.Add(new MDB.MDBParameter("HA_Truoc", ketQua.HA_Truoc));
                Command.Parameters.Add(new MDB.MDBParameter("NhietDo_Truoc", ketQua.NhietDo_Truoc));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTho_Truoc", ketQua.NhipTho_Truoc));
                Command.Parameters.Add(new MDB.MDBParameter("Mach_Sau", ketQua.Mach_Sau));
                Command.Parameters.Add(new MDB.MDBParameter("HA_Sau", ketQua.HA_Sau));
                Command.Parameters.Add(new MDB.MDBParameter("NhietDo_Sau", ketQua.NhietDo_Sau));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTho_Sau", ketQua.NhipTho_Sau));
                Command.Parameters.Add(new MDB.MDBParameter("DDGiaoNguoiBenh_Ngay", ketQua.DDGiaoNguoiBenh_Ngay));
                Command.Parameters.Add(new MDB.MDBParameter("DDGiaoNguoiBenh", ketQua.DDGiaoNguoiBenh));
                Command.Parameters.Add(new MDB.MDBParameter("MaDDGiaoNguoiBenh", ketQua.MaDDGiaoNguoiBenh));
                Command.Parameters.Add(new MDB.MDBParameter("DDNhanNguoiBenh_Ngay", ketQua.DDNhanNguoiBenh_Ngay));
                Command.Parameters.Add(new MDB.MDBParameter("DDNhanNguoiBenh", ketQua.DDNhanNguoiBenh));
                Command.Parameters.Add(new MDB.MDBParameter("MaDDNhanNguoiBenh", ketQua.MaDDNhanNguoiBenh));

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
                string sql = "DELETE FROM PhieuKiemSoatNBTruocMo WHERE ID = :ID";
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
                PhieuKiemSoatNBTruocMo P
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "KQ");
            ds.Tables[0].AddColumn("LoGoPath", typeof(string));
            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));
            ds.Tables[0].AddColumn("NamSinh", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(string));
            ds.Tables[0].AddColumn("SOYTE", typeof(string));
            ds.Tables[0].AddColumn("BENHVIEN", typeof(string));

            ds.Tables[0].Rows[0]["LoGoPath"] = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\PaintLibrary\HinhAnh\LoGoVien\" + "Logo.png";
            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["NamSinh"] = XemBenhAn._HanhChinhBenhNhan.NgaySinh.HasValue ? XemBenhAn._HanhChinhBenhNhan.NgaySinh.Value.Year + "" : "";
            ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            ds.Tables[0].Rows[0]["SOYTE"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;

            string bangKeJson = ds.Tables[0].Rows[0]["CacChiTietCanKiemTras_1"].ToString();
            if (ds.Tables[0].Rows[0]["CacChiTietCanKiemTras_2"] != DBNull.Value)
                bangKeJson += ds.Tables[0].Rows[0]["CacChiTietCanKiemTras_2"].ToString();
            if (ds.Tables[0].Rows[0]["CacChiTietCanKiemTras_3"] != DBNull.Value)
                bangKeJson += ds.Tables[0].Rows[0]["CacChiTietCanKiemTras_3"].ToString();
            ObservableCollection<CacChiTietCanKiemTra>  CacChiTietCanKiemTras = JsonConvert.DeserializeObject<ObservableCollection<CacChiTietCanKiemTra>>(bangKeJson);
            ds.Tables.Add(Common.ListToDataTable(CacChiTietCanKiemTras, "CT"));

            return ds;
        }
    }
}
