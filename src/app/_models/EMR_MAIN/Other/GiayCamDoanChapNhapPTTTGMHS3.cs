using EMR.KyDienTu;
using System;
using System.Collections.Generic;
using System.Data;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
        public class GiayCamDoanChapNhapPTTTGMHS3 : ThongTinKy
    {
        [MoTaDuLieu("Mã định danh")]
		public decimal ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Bệnh viện")]
		public string BenhVien { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
		[MoTaDuLieu("Sở Y Tế")]
		public string SoYTe { get; set; }
        public string MaSo { get; set; }
        public string HoTen { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Dân tộc")]
		public string DanToc { get; set; }
        public string NgoaiKieu { get; set; }
        [MoTaDuLieu("Nghề nghiệp")]
		public string NgheNghiep { get; set; }
        public string NoiLamViec { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        [MoTaDuLieu("Họ tên người thân")]
		public string NguoiThan { get; set; }
        public string MaPhauThuatVien { get; set; }
        public string PhauThuatVien { get; set; }

        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Ngày ký")]
		public DateTime NgayKi { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        //public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
    }
    public class GiayCamDoanChapNhapPTTTGMHS3Func
    {

        public const string TableName = "GiayCamDoanCNPTTTGMHS3";
        public const string TablePrimaryKeyName = "ID";

        public static bool Delete(MDB.MDBConnection MyConnection, decimal id)
        {
            try
            {
                string sql = "DELETE FROM GiayCamDoanCNPTTTGMHS3 WHERE ID = :ID";
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

        public static List<GiayCamDoanChapNhapPTTTGMHS3> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<GiayCamDoanChapNhapPTTTGMHS3> list = new List<GiayCamDoanChapNhapPTTTGMHS3>();
            try
            {
                string sql = @"SELECT * FROM GiayCamDoanCNPTTTGMHS3 where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    GiayCamDoanChapNhapPTTTGMHS3 data = new GiayCamDoanChapNhapPTTTGMHS3();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;

                    data.MaBenhNhan = XemBenhAn._HanhChinhBenhNhan.MaBenhNhan;
                    data.HoTen = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();

                    data.DanToc = DataReader["DanToc"].ToString();
                    data.NgoaiKieu = DataReader["NgoaiKieu"].ToString();
                    data.NgheNghiep = DataReader["NgheNghiep"].ToString();
                    data.NoiLamViec = DataReader["NoiLamViec"].ToString();
                    data.DiaChi = DataReader["DiaChi"].ToString();
                    data.NguoiThan = DataReader["NguoiThan"].ToString();
                    data.MaPhauThuatVien = DataReader["MaPhauThuatVien"].ToString();
                    data.PhauThuatVien = DataReader["PhauThuatVien"].ToString();

                    data.NgayTao = Convert.ToDateTime(DataReader["NGAYTAO"] == DBNull.Value ? DateTime.Now : DataReader["NGAYTAO"]);
                    data.NguoiTao = DataReader["NGUOITAO"].ToString();
                    data.NgaySua = Convert.ToDateTime(DataReader["NGAYSUA"] == DBNull.Value ? DateTime.Now : DataReader["NGAYSUA"]);
                    data.NguoiSua = DataReader["NGUOISUA"].ToString();

                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;
                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, string IDBienBan)
        {
            string sql = @"SELECT
                P.* 
            FROM
                GiayCamDoanCNPTTTGMHS3 P
            WHERE
                ID = " + IDBienBan;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "TB");

            ds.Tables[0].AddColumn("HoTen", typeof(string));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));
            ds.Tables[0].AddColumn("BenhVien", typeof(string));
            ds.Tables[0].AddColumn("Khoa", typeof(string));
            ds.Tables[0].AddColumn("SoYTe", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(string));
            ds.Tables[0].AddColumn("ThongTinNgayThang", typeof(string));
            ds.Tables[0].AddColumn("SoBenhAn", typeof(string));
            ds.Tables[0].AddColumn("MaBenhAn", typeof(string));

            ds.Tables[0].Rows[0]["HoTen"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            ds.Tables[0].Rows[0]["BenhVien"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["SoYTe"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["SoBenhAn"] = XemBenhAn._ThongTinDieuTri.SoNhapVien;
            ds.Tables[0].Rows[0]["Khoa"] = XemBenhAn._ThongTinDieuTri.Khoa;
            ds.Tables[0].Rows[0]["ThongTinNgayThang"] = DateTime.Now.Hour + " giờ " + DateTime.Now.Minute + ", ngày " + DateTime.Now.Day + " tháng " + DateTime.Now.Month + " năm " + DateTime.Now.Year;
            ds.Tables[0].Rows[0]["MaBenhAn"] = XemBenhAn._ThongTinDieuTri.MaBenhAn;

            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, GiayCamDoanChapNhapPTTTGMHS3 ketQua)
        {
            try
            {
                string sql = @"INSERT INTO GiayCamDoanCNPTTTGMHS3
                (
                    MaQuanLy,
                    DanToc,
                    NgoaiKieu,
                    NgheNghiep,
                    NoiLamViec,
                    DiaChi,
                    NguoiThan,
                    MaPhauThuatVien,
                    PhauThuatVien,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
				    :DanToc,
                    :NgoaiKieu,
                    :NgheNghiep,
                    :NoiLamViec,
                    :DiaChi,
                    :NguoiThan,
                    :MaPhauThuatVien,
                    :PhauThuatVien,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE GiayCamDoanCNPTTTGMHS3 SET 
                    MaQuanLy = :MaQuanLy,
                    DanToc = :DanToc,
                    NgoaiKieu = :NgoaiKieu,
                    NgheNghiep = :NgheNghiep,
                    NoiLamViec = :NoiLamViec,
                    DiaChi = :DiaChi,
                    NguoiThan = :NguoiThan,
                    MaPhauThuatVien = :MaPhauThuatVien,
                    PhauThuatVien = :PhauThuatVien,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("DanToc", ketQua.DanToc));
                Command.Parameters.Add(new MDB.MDBParameter("NgoaiKieu", ketQua.NgoaiKieu));

                Command.Parameters.Add(new MDB.MDBParameter("NgheNghiep", ketQua.NgheNghiep));
                Command.Parameters.Add(new MDB.MDBParameter("NoiLamViec", ketQua.NoiLamViec));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", ketQua.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiThan", ketQua.NguoiThan));
                Command.Parameters.Add(new MDB.MDBParameter("PhauThuatVien", ketQua.PhauThuatVien));
                Command.Parameters.Add(new MDB.MDBParameter("MaPhauThuatVien", ketQua.MaPhauThuatVien));

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
                XuLyLoi.LogError(ex);
            }
            return false;
        }
    }
}
