using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class BienBanHoiChanNguoiBenhSuDungThuocCoDauSao : ThongTinKy
    {
        public BienBanHoiChanNguoiBenhSuDungThuocCoDauSao()
        {
            IDMauPhieu = (int)DanhMucPhieu.HCTDS;
            TenMauPhieu = DanhMucPhieu.HCTDS.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public int ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Tên bệnh viện")]
        public string TenBenhVien { get; set; }
        [MoTaDuLieu("Khoa phòng")]
        public string KhoaPhong { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giường")]
		public string Giuong { get; set; }
        [MoTaDuLieu("Ngày vào viện")]
        public DateTime? NgayVaoVien { get; set; }
        [MoTaDuLieu("Ngày hội chẩn")]
        public DateTime NgayHoiChan { get; set; }
        [MoTaDuLieu("Ngày sửa")]
        public DateTime? NgaySua { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Tóm tắt tình trạng bệnh")]
        public string TomTatTinhTrangBenh { get; set; }
        [MoTaDuLieu("Thuốc kháng sinh")]
        public string ThuocKhangSinh { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh sau hội chẩn")]
		public string ChanDoanSauHoiChan { get; set; }
        [MoTaDuLieu("")]
        public string ThuocDauSao { get; set; }
        [MoTaDuLieu("Mã bác sỹ điều trị")]
		public string MaBacSyDieuTri { get; set; }
        [MoTaDuLieu("Bác sỹ điều trị")]
		public string BacSyDieuTri { get; set; }
        [MoTaDuLieu("Mã lãnh đạo bệnh viện")]
		public string MaLanhDaoBenhVien { get; set; }
        [MoTaDuLieu("Lãnh đạo bệnh viện")]
		public string LanhDaoBenhVien { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
    }
    public class BienBanHoiChanNguoiBenhSuDungThuocCoDauSaoFunc
    {
        public const string TableName = "BIENBANHOICHANTHUOCCODAUSAO";
        public const string TablePrimaryKeyName = "ID";
        public static int InsertOrUpdate(BienBanHoiChanNguoiBenhSuDungThuocCoDauSao bienBanHoiChanNguoiBenhSuDungThuocCoDauSao, MDB.MDBConnection conn)
        {
            try
            {
                string sql = "SELECT ID FROM BIENBANHOICHANTHUOCCODAUSAO WHERE ID = :ID AND TRANGTHAI = 0";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, conn);
                command.Parameters.Add(new MDB.MDBParameter("ID", bienBanHoiChanNguoiBenhSuDungThuocCoDauSao.ID));
                MDB.MDBDataReader dataReader = command.ExecuteReader();
                int count = 0;
                while (dataReader.Read()) count++;
                if (count == 1)
                    sql = "UPDATE BIENBANHOICHANTHUOCCODAUSAO SET MAQUANLY = :MAQUANLY,TENBENHVIEN = :TENBENHVIEN, KHOAPHONG = :KHOAPHONG, TENBENHNHAN = :TENBENHNHAN, GIOITINH = :GIOITINH, TUOI = :TUOI, GIUONG = :GIUONG, NGAYVAOVIEN = :NGAYVAOVIEN, NGAYHOICHAN = :NGAYHOICHAN, ThuocKhangSinh = :ThuocKhangSinh, CHANDOAN = :CHANDOAN,TOMTATTINHTRANGBENH = :TOMTATTINHTRANGBENH,CHANDOANSAUHOICHAN = :CHANDOANSAUHOICHAN, THUOCDAUSAO = :THUOCDAUSAO, BACSYDIEUTRI = :BACSYDIEUTRI, MABACSYDIEUTRI = :MABACSYDIEUTRI, MALANHDAOBENHVIEN = :MALANHDAOBENHVIEN, LANHDAOBENHVIEN = :LANHDAOBENHVIEN, NGAYSUA = :NGAYSUA, NGUOITAO = :NGUOITAO, NGUOISUA = :NGUOISUA WHERE TRANGTHAI = 0 AND ID = :ID";
                else
                    sql = "INSERT INTO BIENBANHOICHANTHUOCCODAUSAO (MAQUANLY, TENBENHVIEN, KHOAPHONG, TENBENHNHAN, GIOITINH, TUOI, GIUONG, NGAYVAOVIEN, NGAYHOICHAN, ThuocKhangSinh, CHANDOAN, TOMTATTINHTRANGBENH, CHANDOANSAUHOICHAN, THUOCDAUSAO, MABACSYDIEUTRI, BACSYDIEUTRI, MALANHDAOBENHVIEN, LANHDAOBENHVIEN, NGAYSUA, NGUOITAO, NGUOISUA) VALUES (:MAQUANLY, :TENBENHVIEN, :KHOAPHONG, :TENBENHNHAN, :GIOITINH, :TUOI, :GIUONG, :NGAYVAOVIEN, :NGAYHOICHAN, :ThuocKhangSinh, :CHANDOAN, :TOMTATTINHTRANGBENH, :CHANDOANSAUHOICHAN, :THUOCDAUSAO, :MABACSYDIEUTRI, :BACSYDIEUTRI, :MALANHDAOBENHVIEN, :LANHDAOBENHVIEN, :NGAYSUA, :NGUOITAO, :NGUOISUA) RETURNING ID INTO :ID";
                command = new MDB.MDBCommand(sql, conn);
                command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bienBanHoiChanNguoiBenhSuDungThuocCoDauSao.MaQuanLy));
                command.Parameters.Add(new MDB.MDBParameter("TENBENHVIEN", bienBanHoiChanNguoiBenhSuDungThuocCoDauSao.TenBenhVien));
                command.Parameters.Add(new MDB.MDBParameter("KHOAPHONG", bienBanHoiChanNguoiBenhSuDungThuocCoDauSao.KhoaPhong));
                command.Parameters.Add(new MDB.MDBParameter("TENBENHNHAN", bienBanHoiChanNguoiBenhSuDungThuocCoDauSao.TenBenhNhan));
                command.Parameters.Add(new MDB.MDBParameter("GIOITINH", bienBanHoiChanNguoiBenhSuDungThuocCoDauSao.GioiTinh));
                command.Parameters.Add(new MDB.MDBParameter("TUOI", bienBanHoiChanNguoiBenhSuDungThuocCoDauSao.Tuoi));
                command.Parameters.Add(new MDB.MDBParameter("GIUONG", bienBanHoiChanNguoiBenhSuDungThuocCoDauSao.Giuong));
                command.Parameters.Add(new MDB.MDBParameter("NGAYVAOVIEN", bienBanHoiChanNguoiBenhSuDungThuocCoDauSao.NgayVaoVien));
                command.Parameters.Add(new MDB.MDBParameter("ThuocKhangSinh", bienBanHoiChanNguoiBenhSuDungThuocCoDauSao.ThuocKhangSinh));
                command.Parameters.Add(new MDB.MDBParameter("NGAYHOICHAN", bienBanHoiChanNguoiBenhSuDungThuocCoDauSao.NgayHoiChan));
                command.Parameters.Add(new MDB.MDBParameter("CHANDOAN", bienBanHoiChanNguoiBenhSuDungThuocCoDauSao.ChanDoan));
                command.Parameters.Add(new MDB.MDBParameter("TOMTATTINHTRANGBENH", bienBanHoiChanNguoiBenhSuDungThuocCoDauSao.TomTatTinhTrangBenh));
                command.Parameters.Add(new MDB.MDBParameter("CHANDOANSAUHOICHAN", bienBanHoiChanNguoiBenhSuDungThuocCoDauSao.ChanDoanSauHoiChan));
                command.Parameters.Add(new MDB.MDBParameter("THUOCDAUSAO", bienBanHoiChanNguoiBenhSuDungThuocCoDauSao.ThuocDauSao));
                command.Parameters.Add(new MDB.MDBParameter("MABACSYDIEUTRI", bienBanHoiChanNguoiBenhSuDungThuocCoDauSao.MaBacSyDieuTri));
                command.Parameters.Add(new MDB.MDBParameter("BACSYDIEUTRI", bienBanHoiChanNguoiBenhSuDungThuocCoDauSao.BacSyDieuTri));
                command.Parameters.Add(new MDB.MDBParameter("MALANHDAOBENHVIEN", bienBanHoiChanNguoiBenhSuDungThuocCoDauSao.MaLanhDaoBenhVien));
                command.Parameters.Add(new MDB.MDBParameter("LANHDAOBENHVIEN", bienBanHoiChanNguoiBenhSuDungThuocCoDauSao.LanhDaoBenhVien));
                if (count == 1)
                    command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", DateTime.Now));
                else
                    command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", bienBanHoiChanNguoiBenhSuDungThuocCoDauSao.NgaySua));
                command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", bienBanHoiChanNguoiBenhSuDungThuocCoDauSao.NguoiTao));
                if (count == 1)
                    command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", Common.getUserLogin()));
                else
                    command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", bienBanHoiChanNguoiBenhSuDungThuocCoDauSao.NguoiSua));
                command.Parameters.Add(new MDB.MDBParameter("ID", bienBanHoiChanNguoiBenhSuDungThuocCoDauSao.ID));
                command.BindByName = true;
                var n = command.ExecuteNonQuery();
                int nextval = Convert.ToInt32((command.Parameters["ID"] as MDB.MDBParameter).Value);
                return n > 0 ? nextval : 0;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return 0;
        }
        public static bool Delete(int ID, MDB.MDBConnection conn)
        {
            try
            {
                string sql = "UPDATE BIENBANHOICHANTHUOCCODAUSAO SET TRANGTHAI = 1 WHERE ID = :ID";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, conn);
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
        public static List<BienBanHoiChanNguoiBenhSuDungThuocCoDauSao> GetBienBanHoiChanNguoiBenhSuDungThuocCoDauSaos(decimal MaQuanLy, MDB.MDBConnection conn)
        {
            List<BienBanHoiChanNguoiBenhSuDungThuocCoDauSao> lstData = new List<BienBanHoiChanNguoiBenhSuDungThuocCoDauSao>();
            try
            {
                string sql = "SELECT * FROM BIENBANHOICHANTHUOCCODAUSAO WHERE MAQUANLY = :MAQUANLY AND TRANGTHAI = 0 ORDER BY NGAYHOICHAN DESC";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, conn);
                command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", MaQuanLy));
                MDB.MDBDataReader oracleDataReader = command.ExecuteReader();
                while (oracleDataReader.Read())
                {
                    BienBanHoiChanNguoiBenhSuDungThuocCoDauSao result = new BienBanHoiChanNguoiBenhSuDungThuocCoDauSao();
                    result.ID = Convert.ToInt32(oracleDataReader.GetLong("ID"));
                    result.MaQuanLy = Convert.ToDecimal(oracleDataReader.GetDecimal("MAQUANLY"));
                    result.TenBenhVien = oracleDataReader["TENBENHVIEN"].ToString();
                    result.KhoaPhong = oracleDataReader["KHOAPHONG"].ToString();
                    result.TenBenhNhan = oracleDataReader["TENBENHNHAN"].ToString();
                    result.GioiTinh = oracleDataReader["GIOITINH"].ToString();
                    result.Tuoi = oracleDataReader["TUOI"].ToString();
                    result.Giuong = oracleDataReader["GIUONG"].ToString();
                    if (oracleDataReader["NGAYVAOVIEN"] != null && oracleDataReader["NGAYVAOVIEN"].ToString() != string.Empty)
                        result.NgayVaoVien = Convert.ToDateTime(oracleDataReader.GetDate("NGAYVAOVIEN"));
                    if (oracleDataReader["NGAYHOICHAN"] != null && oracleDataReader["NGAYHOICHAN"].ToString() != string.Empty)
                        result.NgayHoiChan = Convert.ToDateTime(oracleDataReader.GetDate("NGAYHOICHAN"));
                    result.ChanDoan = oracleDataReader["CHANDOAN"].ToString();
                    result.TomTatTinhTrangBenh = oracleDataReader["TOMTATTINHTRANGBENH"].ToString();
                    result.ChanDoanSauHoiChan = oracleDataReader["CHANDOANSAUHOICHAN"].ToString();
                    result.ThuocKhangSinh = oracleDataReader["ThuocKhangSinh"].ToString();
                    result.ThuocDauSao = oracleDataReader["THUOCDAUSAO"].ToString();
                    result.MaBacSyDieuTri = oracleDataReader["MABACSYDIEUTRI"].ToString();
                    result.BacSyDieuTri = oracleDataReader["BACSYDIEUTRI"].ToString();
                    result.MaLanhDaoBenhVien = oracleDataReader["MALANHDAOBENHVIEN"].ToString();
                    result.LanhDaoBenhVien = oracleDataReader["LANHDAOBENHVIEN"].ToString();
                    result.NgayTao = Convert.ToDateTime(oracleDataReader.GetDate("NGAYTAO"));
                    if (oracleDataReader["NGAYSUA"] != null && oracleDataReader["NGAYSUA"].ToString() != string.Empty)
                        result.NgaySua = Convert.ToDateTime(oracleDataReader.GetDate("NGAYSUA"));
                    result.NguoiTao = oracleDataReader["NGUOITAO"].ToString();
                    result.NguoiSua = oracleDataReader["NGUOISUA"].ToString();

                    result.MaSoKy = oracleDataReader["masokyten"].ToString();
                    result.DaKy = !string.IsNullOrEmpty(result.MaSoKy) ? true : false;
                    lstData.Add(result);
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return lstData;
        }
        public static DataSet GetDataSet(int ID, MDB.MDBConnection conn)
        {
            try
            {
                string sql = "SELECT * FROM BIENBANHOICHANTHUOCCODAUSAO WHERE ID = :ID AND TRANGTHAI = 0";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, conn);
                command.Parameters.Add(new MDB.MDBParameter("ID", ID));
                MDB.MDBDataAdapter dataAdapter = new MDB.MDBDataAdapter(command);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                return dataSet;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return null;
        }
    }
}
