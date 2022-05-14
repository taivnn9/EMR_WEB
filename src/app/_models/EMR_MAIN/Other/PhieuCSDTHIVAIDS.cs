using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuCSDTHIVAIDS: ThongTinKy
    {
        public PhieuCSDTHIVAIDS()
        {
            TableName = "PhieuCSDTHIVAIDS";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PCSDTHIVAIDS;
            TenMauPhieu = DanhMucPhieu.PCSDTHIVAIDS.Description();
        }
        public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau", "", 1)]
        public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
        public string MaBenhNhan { get; set; }
        // phiếu chăm sóc điều tị HIV/AIDS
        [MoTaDuLieu("Tên tôi là ")]
        public string HoTenBN { get; set; }
        [MoTaDuLieu("Mã số bn ")]
        public string MaSO { get; set; }
        [MoTaDuLieu("Giới Tính ")]
        public string GioiTinh { get; set; }
        [MoTaDuLieu("Sinh ngay ")]
        public DateTime? SinhNgay { get; set; }
        [MoTaDuLieu("Địa chỉ nơi sinh ")]
        public string DiaChiNoiSinh { get; set; }
        [MoTaDuLieu("Địa chỉ thường chú ")]
        public string DiaChiThuongChu { get; set; }
        [MoTaDuLieu("CMND ")]
        public string CMND { get; set; }
        [MoTaDuLieu("Ngày cấp ")]
        public DateTime? NgayCapCMND { get; set; }
        [MoTaDuLieu("Nơi cấp == tại ")]
        public string NoiCapCMND { get; set; }
        [MoTaDuLieu("Khi cần liên hệ")]
        public string KhiCanLienHe { get; set; }

        [MoTaDuLieu("Họ tên người liên hệ")]
        public string  HoTenNguoiLH { get; set; }
        [MoTaDuLieu("Địa chỉ người liên hệ")]
        public string DiaChiNLH { get; set; }
        [MoTaDuLieu("Số điện thoại người liên hệ")]
        public string SDTNLH { get; set; }
        [MoTaDuLieu("Ngày khẳng định HIV")]
        public DateTime? NgayKD_HIV { get; set; }
        [MoTaDuLieu("Nơi khẳng định nhiễm HIV")]
        public string NoiKD_HIV { get; set; }
        [MoTaDuLieu("Nơi nhận thuốc ARV")]
        public string NhanThuocARV { get; set; }
        [MoTaDuLieu("Phòng khám ngoại trú")]
        public string PKNgoaiTru { get; set; }
        [MoTaDuLieu("họ và tên người hỗ trợ chăm sóc và điều trị cho bệnh nhân")]
        public string HoTenNguoiHoTro { get; set; }
        [MoTaDuLieu("Ngày lập tờ phiếu")]
        public DateTime? NgayLapToPhieu { get; set; }
        


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
    public class PhieuCSDTHIVAIDSFunc
    {
        public const string TableName = "PhieuCSDTHIVAIDS";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuCSDTHIVAIDS> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuCSDTHIVAIDS> list = new List<PhieuCSDTHIVAIDS>();
            try
            {
                string sql = @"SELECT * FROM PhieuCSDTHIVAIDS where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuCSDTHIVAIDS data = new PhieuCSDTHIVAIDS();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();

                    data.HoTenBN = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.MaSO = DataReader["MaSO"].ToString();
                    data.SinhNgay  = Convert.ToDateTime(DataReader["SinhNgay"] == DBNull.Value ? DateTime.Now : DataReader["SinhNgay"]);
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.DiaChiNoiSinh = DataReader["DiaChiNoiSinh"].ToString();
                    data.DiaChiThuongChu = DataReader["DiaChiThuongChu"].ToString();
                    data.CMND = XemBenhAn._HanhChinhBenhNhan.CMND;
                    data.NgayCapCMND = Convert.ToDateTime(DataReader["NgayCapCMND"] == DBNull.Value ? DateTime.Now : DataReader["NgayCapCMND"]);
                    data.NoiCapCMND = XemBenhAn._HanhChinhBenhNhan.NoiCap_CMND;
                    data.KhiCanLienHe = DataReader["KhiCanLienHe"].ToString();
                    data.HoTenNguoiLH = DataReader["HoTenNguoiLH"].ToString();
                    data.DiaChiNLH = DataReader["DiaChiNLH"].ToString();
                    data.SDTNLH = DataReader["SDTNLH"].ToString();
                    data.NgayKD_HIV = Convert.ToDateTime(DataReader["NgayKD_HIV"] == DBNull.Value ? DateTime.Now : DataReader["NgayKD_HIV"]);
                    data.NoiKD_HIV = DataReader["NoiKD_HIV"].ToString();
                    data.NhanThuocARV = DataReader["NhanThuocARV"].ToString();
                    data.PKNgoaiTru = DataReader["PKNgoaiTru"].ToString();
                    data.HoTenNguoiHoTro = DataReader["HoTenNguoiHoTro"].ToString();
                    data.NgayLapToPhieu = Convert.ToDateTime(DataReader["NgayLapToPhieu"] == DBNull.Value ? DateTime.Now : DataReader["NgayLapToPhieu"]);
                    


                   

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuCSDTHIVAIDS bangKe)
        {
            try
            {
                string sql = @"INSERT INTO PhieuCSDTHIVAIDS
                (
                    MAQUANLY,
                    MaBenhNhan,                   
                    HoTenBN,
                    MaSO,
                    GioiTinh,
                    SinhNgay,
                    DiaChiNoiSinh,
                    DiaChiThuongChu,
                    CMND,
                    NgayCapCMND,
                    NoiCapCMND,
                    KhiCanLienHe,
                    HoTenNguoiLH,
                    DiaChiNLH,
                    SDTNLH,
                    NgayKD_HIV,
                    NoiKD_HIV,
                    NhanThuocARV,
                    PKNgoaiTru,
                    HoTenNguoiHoTro,
                    NgayLapToPhieu,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :HoTenBN,
                    :MaSO,
                    :GioiTinh,
                    :SinhNgay,
                    :DiaChiNoiSinh,
                    :DiaChiThuongChu,
                    :CMND,
                    :NgayCapCMND,
                    :NoiCapCMND,
                    :KhiCanLienHe,
                    :HoTenNguoiLH,
                    :DiaChiNLH,
                    :SDTNLH,
                    :NgayKD_HIV,
                    :NoiKD_HIV,
                    :NhanThuocARV,
                    :PKNgoaiTru,
                    :HoTenNguoiHoTro,
                    :NgayLapToPhieu, 
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (bangKe.ID != 0)
                {
                    sql = @"UPDATE PhieuCSDTHIVAIDS SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,                   
                    HoTenBN = :HoTenBN,
                    MaSO = :MaSO,
                    GioiTinh = :GioiTinh,
                    SinhNgay = :SinhNgay,
                    DiaChiNoiSinh = :DiaChiNoiSinh,
                    DiaChiThuongChu = :DiaChiThuongChu,
                    CMND = :CMND,
                    NgayCapCMND = :NgayCapCMND,
                    NoiCapCMND = :NoiCapCMND,
                    KhiCanLienHe = :KhiCanLienHe,
                    HoTenNguoiLH = :HoTenNguoiLH,
                    DiaChiNLH = :DiaChiNLH,
                    SDTNLH = :SDTNLH,
                    NgayKD_HIV = :NgayKD_HIV,
                    NoiKD_HIV = :NoiKD_HIV,
                    NhanThuocARV = :NhanThuocARV,
                    PKNgoaiTru = :PKNgoaiTru
                    HoTenNguoiHoTro = :HoTenNguoiHoTro,
                    NgayLapToPhieu = :NgayLapToPhieu,                    
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + bangKe.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangKe.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", bangKe.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("HoTenBN", bangKe.HoTenBN));
                Command.Parameters.Add(new MDB.MDBParameter("MaSO", bangKe.MaSO));

                Command.Parameters.Add(new MDB.MDBParameter("GioiTinh", bangKe.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("SinhNgay", bangKe.SinhNgay));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChiNoiSinh", bangKe.DiaChiNoiSinh));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChiThuongChu", bangKe.DiaChiThuongChu));
                Command.Parameters.Add(new MDB.MDBParameter("CMND", bangKe.CMND));
                Command.Parameters.Add(new MDB.MDBParameter("NgayCapCMND", bangKe.NgayCapCMND));
                Command.Parameters.Add(new MDB.MDBParameter("NoiCapCMND", bangKe.NoiCapCMND));
                Command.Parameters.Add(new MDB.MDBParameter("KhiCanLienHe", bangKe.KhiCanLienHe));
                Command.Parameters.Add(new MDB.MDBParameter("HoTenNguoiLH", bangKe.HoTenNguoiLH));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChiNLH", bangKe.DiaChiNLH));
                Command.Parameters.Add(new MDB.MDBParameter("SDTNLH", bangKe.SDTNLH));
                Command.Parameters.Add(new MDB.MDBParameter("NgayKD_HIV", bangKe.NgayKD_HIV));

               
                Command.Parameters.Add(new MDB.MDBParameter("NoiKD_HIV", bangKe.NoiKD_HIV));
                Command.Parameters.Add(new MDB.MDBParameter("NhanThuocARV", bangKe.NhanThuocARV));
                Command.Parameters.Add(new MDB.MDBParameter("PKNgoaiTru", bangKe.PKNgoaiTru));
                Command.Parameters.Add(new MDB.MDBParameter("HoTenNguoiHoTro", bangKe.HoTenNguoiHoTro));
                Command.Parameters.Add(new MDB.MDBParameter("NgayLapToPhieu", bangKe.NgayLapToPhieu));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", bangKe.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", bangKe.NgaySua));
                if (bangKe.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", bangKe.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", bangKe.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", bangKe.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (bangKe.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    bangKe.ID = nextval;
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
                string sql = "DELETE FROM PhieuCSDTHIVAIDS WHERE ID = :ID";
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
                B.MAQUANLY,
                B.MaBenhNhan,
                B.HoTenBN,
                B.MaSO,
                B.GioiTinh,
                B.SinhNgay,
                B.DiaChiNoiSinh,
                B.DiaChiThuongChu,
                B.CMND,
                B.NgayCapCMND,
                B.NoiCapCMND,
                B.KhiCanLienHe,
                B.HoTenNguoiLH,
                B.DiaChiNLH,
                B.SDTNLH,
                B.NgayKD_HIV,
                B.NoiKD_HIV,
                B.NhanThuocARV,
                B.PKNgoaiTru,
                B.HoTenNguoiHoTro,
                B.NgayLapToPhieu
                
            FROM
                PhieuCSDTHIVAIDS B
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "BK");
          


            return ds;

        }
    }
}
