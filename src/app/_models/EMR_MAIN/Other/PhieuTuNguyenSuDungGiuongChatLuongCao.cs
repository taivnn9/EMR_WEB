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
    public class PhieuTuNguyenSuDungGiuongChatLuongCao : ThongTinKy
    {
        public PhieuTuNguyenSuDungGiuongChatLuongCao()
        {
            TableName = "PhieuTuNguyenSuDungGiuongCLC";
            TablePrimaryKeyName = "IDPhieuTuNguyenSuDungGiuongCLC";
            IDMauPhieu = (int)DanhMucPhieu.PTNSDGCLC;
            TenMauPhieu = DanhMucPhieu.PTNSDGCLC.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long IdPhieuTuNguyenSuDungGiuongCLC { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }
        [MoTaDuLieu("Số bệnh án")]
		public string SoBenhAn { get; set; }
        [MoTaDuLieu("Ngày vào bệnh viện")]
		public DateTime NgayVaoVien { get; set; }
        public DateTime NgaySuDungGiuongCLC { get; set; }
        public DateTime NgayRaVien { get; set; }
        public int TongSoNgayGiuongTuNguyen { get; set; }
        public string NguoiXacNhan { get; set; }
        public string MaNguoiXacNhan { get; set; }
        public string LoaiGiuong { get; set; }
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
    }
    public class PhieuTuNguyenSuDungGiuongChatLuongCaoFunc
    {
        public const string TableName = "PhieuTuNguyenSuDungGiuongCLC";
        public const string TablePrimaryKeyName = "IDPhieuTuNguyenSuDungGiuongCLC";
        public static List<PhieuTuNguyenSuDungGiuongChatLuongCao> GetData(decimal maQuanLy, MDB.MDBConnection _OracleConnection)
        {
            List<PhieuTuNguyenSuDungGiuongChatLuongCao> lstData = new List<PhieuTuNguyenSuDungGiuongChatLuongCao>();
            try
            {
                string sql = @"SELECT * FROM PhieuTuNguyenSuDungGiuongCLC where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maQuanLy));
                Command.BindByName = true;
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                if (XemBenhAn._HanhChinhBenhNhan == null) XemBenhAn._HanhChinhBenhNhan = new HanhChinhBenhNhan();
                if (XemBenhAn._ThongTinDieuTri == null) XemBenhAn._ThongTinDieuTri = new ThongTinDieuTri();
                while (DataReader.Read())
                {
                    PhieuTuNguyenSuDungGiuongChatLuongCao data = new PhieuTuNguyenSuDungGiuongChatLuongCao();
                    data.IdPhieuTuNguyenSuDungGiuongCLC = Convert.ToInt64(DataReader.GetLong("IDPhieuTuNguyenSuDungGiuongCLC").ToString());
                    data.MaQuanLy = maQuanLy;
                    data.TenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.MaBenhNhan = XemBenhAn._HanhChinhBenhNhan.MaBenhNhan;
                    data.Khoa = XemBenhAn._ThongTinDieuTri.Khoa;
                    data.MaKhoa = XemBenhAn._ThongTinDieuTri.MaKhoa;
                    data.SoBenhAn = XemBenhAn._ThongTinDieuTri.MaBenhAn;

                    data.MaNguoiXacNhan = DataReader["MaNguoiXacNhan"].ToString();
                    data.NguoiXacNhan = DataReader["NguoiXacNhan"].ToString();
                    int temp = 0;
                    int.TryParse(DataReader["TongSoNgayGiuongTuNguyen"].ToString(), out temp);
                    data.TongSoNgayGiuongTuNguyen = temp;
                    data.NgayVaoVien = Convert.ToDateTime(DataReader["NgayVaoVien"] == DBNull.Value ? DateTime.Now : DataReader["NgayVaoVien"]);
                    data.NgaySuDungGiuongCLC = Convert.ToDateTime(DataReader["NgaySuDungGiuongCLC"] == DBNull.Value ? DateTime.Now : DataReader["NgaySuDungGiuongCLC"]);
                    data.NgayRaVien = Convert.ToDateTime(DataReader["NgayRaVien"] == DBNull.Value ? DateTime.Now : DataReader["NgayRaVien"]);
                    data.LoaiGiuong = DataReader["LoaiGiuong"].ToString();
                    data.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                    data.NguoiTao = DataReader["NguoiTao"].ToString();
                    data.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);
                    data.NguoiSua = DataReader["NguoiSua"].ToString();
                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;
                    lstData.Add(data);
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return lstData;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuTuNguyenSuDungGiuongChatLuongCao phieu)
        {
            string sql = @"INSERT INTO PhieuTuNguyenSuDungGiuongCLC
                (
                    MAQUANLY,
                    MaBenhNhan,
                    Khoa,
                    MaKhoa,
                    MaNguoiXacNhan,
                    NguoiXacNhan,
                    TongSoNgayGiuongTuNguyen,
                    NgayVaoVien,
                    NgaySuDungGiuongCLC,
                    NgayRaVien,
                    LoaiGiuong,
                    NGUOITAO,
                    NGAYTAO,
                    NGUOISUA,
                    NGAYSUA)  VALUES
                 (
                    :MAQUANLY,
                    :MaBenhNhan,
                    :Khoa,
                    :MaKhoa,
                    :MaNguoiXacNhan,
                    :NguoiXacNhan,
                    :TongSoNgayGiuongTuNguyen,
                    :NgayVaoVien,
                    :NgaySuDungGiuongCLC,
                    :NgayRaVien,
                    :LoaiGiuong,
                    :NGUOITAO,
                    :NGAYTAO,
                    :NGUOISUA,
                    :NGAYSUA
                )  RETURNING IdPhieuTuNguyenSuDungGiuongCLC INTO :IDPhieuTuNguyenSuDungGiuongCLC";
            if (phieu.IdPhieuTuNguyenSuDungGiuongCLC != 0)
            {
                sql = @"UPDATE PhieuTuNguyenSuDungGiuongCLC SET 
                    MAQUANLY = :MAQUANLY, 
                    MaBenhNhan = :MaBenhNhan, 
                    Khoa = :Khoa,
                    MaKhoa = :MaKhoa,
                    MaNguoiXacNhan = :MaNguoiXacNhan,
                    NguoiXacNhan = :NguoiXacNhan,
                    TongSoNgayGiuongTuNguyen = :TongSoNgayGiuongTuNguyen,
                    NgayVaoVien = :NgayVaoVien,
                    NgaySuDungGiuongCLC = :NgaySuDungGiuongCLC,
                    NgayRaVien = :NgayRaVien,
                    LoaiGiuong = :LoaiGiuong,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE IdPhieuTuNguyenSuDungGiuongCLC = " + phieu.IdPhieuTuNguyenSuDungGiuongCLC;
            }
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", phieu.MaQuanLy));
            Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", phieu.MaBenhNhan));
            Command.Parameters.Add(new MDB.MDBParameter("Khoa", phieu.Khoa));
            Command.Parameters.Add(new MDB.MDBParameter("MaKhoa", phieu.MaKhoa));
            Command.Parameters.Add(new MDB.MDBParameter("SoBenhAn", phieu.SoBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("MaNguoiXacNhan", phieu.MaNguoiXacNhan));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiXacNhan", phieu.NguoiXacNhan));
            Command.Parameters.Add(new MDB.MDBParameter("TongSoNgayGiuongTuNguyen", phieu.TongSoNgayGiuongTuNguyen));
            Command.Parameters.Add(new MDB.MDBParameter("NgayVaoVien", phieu.NgayVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("NgaySuDungGiuongCLC", phieu.NgaySuDungGiuongCLC));
            Command.Parameters.Add(new MDB.MDBParameter("NgayRaVien", phieu.NgayRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("LoaiGiuong", phieu.LoaiGiuong));
            Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", phieu.NguoiSua));
            Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", phieu.NgaySua));
            if (phieu.IdPhieuTuNguyenSuDungGiuongCLC == 0)
            {
                Command.Parameters.Add(new MDB.MDBParameter("IdPhieuTuNguyenSuDungGiuongCLC", phieu.IdPhieuTuNguyenSuDungGiuongCLC));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", phieu.NguoiTao));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", phieu.NgayTao));
            }
            Command.BindByName = true;
            int n = Command.ExecuteNonQuery(); // C#
            if (phieu.IdPhieuTuNguyenSuDungGiuongCLC == 0)
            {
                long nextval = Convert.ToInt64((Command.Parameters["IdPhieuTuNguyenSuDungGiuongCLC"] as MDB.MDBParameter).Value);
                phieu.IdPhieuTuNguyenSuDungGiuongCLC = nextval;
            }

            return n > 0 ? true : false;
        }
        public static bool delete(MDB.MDBConnection MyConnection, decimal IdPhieuTuNguyenSuDungGiuongCLC)
        {
            try
            {
                string sql = "DELETE FROM PhieuTuNguyenSuDungGiuongCLC WHERE IdPhieuTuNguyenSuDungGiuongCLC = :IdPhieuTuNguyenSuDungGiuongCLC";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                command.Parameters.Add(new MDB.MDBParameter("IdPhieuTuNguyenSuDungGiuongCLC", IdPhieuTuNguyenSuDungGiuongCLC));
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
        public static DataSet getDataSet(MDB.MDBConnection MyConnection, decimal IdPhieuTuNguyenSuDungGiuongCLC)
        {
            string sql = @"SELECT
                P.*,
                T.MABENHAN SOBENHAN,
	            H.TENBENHNHAN
            FROM
                PhieuTuNguyenSuDungGiuongCLC P LEFT JOIN THONGTINDIEUTRI T ON P.MAQUANLY = T.MAQUANLY
                LEFT JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
            WHERE
                IdPhieuTuNguyenSuDungGiuongCLC = " + IdPhieuTuNguyenSuDungGiuongCLC;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "PHIEU");

            DataTable thongTinVien = new DataTable("HEADER");

            thongTinVien.Columns.Add("BENHVIEN");
            thongTinVien.Columns.Add("KHOA");
            if (XemBenhAn._HanhChinhBenhNhan == null) XemBenhAn._HanhChinhBenhNhan = new HanhChinhBenhNhan();
            if (XemBenhAn._ThongTinDieuTri == null) XemBenhAn._ThongTinDieuTri = new ThongTinDieuTri();
            thongTinVien.Rows.Add(XemBenhAn._HanhChinhBenhNhan.BenhVien, XemBenhAn._ThongTinDieuTri.Khoa);
            ds.Tables.Add(thongTinVien);

            return ds;
        }
    }
}
