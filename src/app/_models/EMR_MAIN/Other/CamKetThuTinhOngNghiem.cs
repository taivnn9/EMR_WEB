
using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class CamKetThuTinhOngNghiem : ThongTinKy
    {
        public CamKetThuTinhOngNghiem()
        {
            TableName = "CamKetThuTinhOngNghiem";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.CKTTON;
            TenMauPhieu = DanhMucPhieu.CKTTON.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
		[MoTaDuLieu("Sở Y Tế")]
		public string SoYTe { get; set; }
        [MoTaDuLieu("Bệnh viện")]
		public string BenhVien { get; set; }
        [MoTaDuLieu("Họ và tên vợ")]
		public string TenVo { get; set; }
        [MoTaDuLieu("Năm sinh vợ")]
		public string NamSinhVo { get; set; }
        [MoTaDuLieu("Chứng minh thư nhân nhân/hộ chiều của vợ")]
		public string CMNDVo { get; set; }
        [MoTaDuLieu("Ngày cấp chứng minh thư nhân nhân/hộ chiều của vợ")]
		public DateTime? NgayCapCMNDVo { get; set; }
        [MoTaDuLieu("Nơi cấp chứng minh thư nhân nhân/hộ chiều của vợ")]
        public string NoiCapCMNDVo { get; set; }
        [MoTaDuLieu("Địa chỉ vợ")]
		public string DiaChiVo { get; set; }
        [MoTaDuLieu("Họ và tên chồng")]
        public string TenChong { get; set; }
        [MoTaDuLieu("Năm sinh chồng")]
        public string NamSinhChong { get; set; }
        [MoTaDuLieu("Chứng minh thư nhân nhân/hộ chiều của chồng")]
        public string CMNDChong { get; set; }
        [MoTaDuLieu("Ngày cấp chứng minh thư nhân nhân/hộ chiều của chồng")]
        public DateTime? NgayCapCMNDChong { get; set; }
        [MoTaDuLieu("Nơi cấp chứng minh thư nhân nhân/hộ chiều của chồng")]
        public string NoiCapCMNDChong { get; set; }
        [MoTaDuLieu("Địa chỉ chồng")]
        public string DiaChiChong { get; set; }
        [MoTaDuLieu("Mã nhân viên")]
		public string MaNhanVien { get; set; }
        [MoTaDuLieu("Nhân viên")]
		public string NhanVien { get; set; }
		public string KinhGui { get; set; }

        [MoTaDuLieu("Người tạo")]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Người sửa")]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Ngày tạo")]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Ngày sửa")]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Chọn")]
		public bool Chon { get; set; }
        //public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Đã ký")]
		public bool DaKy { get; set; }
    }
    public class CamKetThuTinhOngNghiemFunc
    {
        public const string TableName = "CamKetThuTinhOngNghiem";
        public const string TablePrimaryKeyName = "ID";

        public static List<CamKetThuTinhOngNghiem> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<CamKetThuTinhOngNghiem> list = new List<CamKetThuTinhOngNghiem>();
            try
            {
                string sql = @"SELECT * FROM CamKetThuTinhOngNghiem where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    CamKetThuTinhOngNghiem data = new CamKetThuTinhOngNghiem();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;

                    data.MaBenhNhan = XemBenhAn._HanhChinhBenhNhan.MaBenhNhan;
                    data.SoYTe = XemBenhAn._HanhChinhBenhNhan.SoYTe;
                    data.BenhVien = XemBenhAn._HanhChinhBenhNhan.BenhVien;

                    data.TenVo = DataReader["TenVo"].ToString();
                    data.NamSinhVo = DataReader["NamSinhVo"].ToString();
                    data.CMNDVo = DataReader["CMNDVo"].ToString();
                    data.NgayCapCMNDVo = Convert.ToDateTime(DataReader["NgayCapCMNDVo"] == DBNull.Value ? DateTime.Now : DataReader["NgayCapCMNDVo"]);
                    data.NoiCapCMNDVo = DataReader["NoiCapCMNDVo"].ToString();
                    data.DiaChiVo = DataReader["DiaChiVo"].ToString();
                    
                    data.KinhGui = DataReader["KinhGui"].ToString();

                    data.TenChong = DataReader["TenChong"].ToString();
                    data.NamSinhChong = DataReader["NamSinhChong"].ToString();
                    data.CMNDChong = DataReader["CMNDChong"].ToString();
                    data.NgayCapCMNDChong = Convert.ToDateTime(DataReader["NgayCapCMNDChong"] == DBNull.Value ? DateTime.Now : DataReader["NgayCapCMNDChong"]);
                    data.NoiCapCMNDChong = DataReader["NoiCapCMNDChong"].ToString();
                    data.DiaChiChong = DataReader["DiaChiChong"].ToString();
                    data.MaNhanVien = DataReader["MaNhanVien"].ToString();
                    data.NhanVien = DataReader["NhanVien"].ToString();

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
        public static bool DeleteByIDPhieu(MDB.MDBConnection oracleConnection, decimal IDBienBan)
        {
            try
            {
                string sql = "";
                MDB.MDBCommand oracleCommand;
                sql = @"DELETE FROM CamKetThuTinhOngNghiem WHERE ID =" + IDBienBan;
                using (oracleCommand = new MDB.MDBCommand(sql, oracleConnection))
                {
                    oracleCommand.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                XuLyLoi.LogError(ex);
            }
            return false;
        }
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, long IDBienBan)
        {
            string sql = @"SELECT
                P.* 
            FROM
                CamKetThuTinhOngNghiem P
            WHERE
                ID = " + IDBienBan;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "TB");

            ds.Tables[0].AddColumn("SoYTe", typeof(string));
            ds.Tables[0].AddColumn("ThoiGian", typeof(string));
            ds.Tables[0].AddColumn("BenhVien", typeof(string));
            ds.Tables[0].Rows[0]["SoYTe"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BenhVien"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["ThoiGian"] = "Nghệ An, ngày " + DateTime.Now.Day + " tháng " + DateTime.Now.Month + " năm " + DateTime.Now.Year;

            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref CamKetThuTinhOngNghiem ketQua)
        {
            try
            {
                string sql = @"INSERT INTO CamKetThuTinhOngNghiem
                (
                    MaQuanLy,
                    TenVo,
                    NamSinhVo,
                    CMNDVo,
                    NgayCapCMNDVo,
                    NoiCapCMNDVo,
                    DiaChiVo,
                    KinhGui,
                    TenChong,
                    NamSinhChong,
                    CMNDChong,
                    NgayCapCMNDChong,
                    NoiCapCMNDChong,
                    DiaChiChong,
                    MaNhanVien,
                    NhanVien,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
                    :TenVo,
                    :NamSinhVo,
                    :CMNDVo,
                    :NgayCapCMNDVo,
                    :NoiCapCMNDVo,
                    :DiaChiVo,
                    :KinhGui,
                    :TenChong,
                    :NamSinhChong,
                    :CMNDChong,
                    :NgayCapCMNDChong,
                    :NoiCapCMNDChong,
                    :DiaChiChong,
                    :MaNhanVien,
                    :NhanVien,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE CamKetThuTinhOngNghiem SET 
                    MaQuanLy = :MaQuanLy,
                    TenVo = :TenVo,
                    NamSinhVo = :NamSinhVo,
                    CMNDVo = :CMNDVo,
                    NgayCapCMNDVo = :NgayCapCMNDVo,
                    NoiCapCMNDVo = :NoiCapCMNDVo,
                    DiaChiVo = :DiaChiVo,
                    KinhGui = :KinhGui,
                    TenChong = :TenChong,
                    NamSinhChong = :NamSinhChong,
                    CMNDChong = :CMNDChong,
                    NgayCapCMNDChong = :NgayCapCMNDChong,
                    NoiCapCMNDChong = :NoiCapCMNDChong,
                    DiaChiChong = :DiaChiChong,
                    MaNhanVien = :MaNhanVien,
                    NhanVien = :NhanVien,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", ketQua.MaQuanLy));

                Command.Parameters.Add(new MDB.MDBParameter("TenVo", ketQua.TenVo));
                Command.Parameters.Add(new MDB.MDBParameter("NamSinhVo", ketQua.NamSinhVo));
                Command.Parameters.Add(new MDB.MDBParameter("CMNDVo", ketQua.CMNDVo));
                Command.Parameters.Add(new MDB.MDBParameter("NgayCapCMNDVo", ketQua.NgayCapCMNDVo));
                Command.Parameters.Add(new MDB.MDBParameter("NoiCapCMNDVo", ketQua.NoiCapCMNDVo));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChiVo", ketQua.DiaChiVo));
                Command.Parameters.Add(new MDB.MDBParameter("KinhGui", ketQua.KinhGui));
                Command.Parameters.Add(new MDB.MDBParameter("TenChong", ketQua.TenChong));
                Command.Parameters.Add(new MDB.MDBParameter("NamSinhChong", ketQua.NamSinhChong));
                Command.Parameters.Add(new MDB.MDBParameter("CMNDChong", ketQua.CMNDChong));
                Command.Parameters.Add(new MDB.MDBParameter("NgayCapCMNDChong", ketQua.NgayCapCMNDChong));
                Command.Parameters.Add(new MDB.MDBParameter("NoiCapCMNDChong", ketQua.NoiCapCMNDChong));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChiChong", ketQua.DiaChiChong));
                Command.Parameters.Add(new MDB.MDBParameter("MaNhanVien", ketQua.MaNhanVien));
                Command.Parameters.Add(new MDB.MDBParameter("NhanVien", ketQua.NhanVien));

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
