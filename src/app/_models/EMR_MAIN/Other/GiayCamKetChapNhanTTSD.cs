using EMR.KyDienTu;
using System;
using System.Collections.Generic;
using System.Data;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class GiayCamKetChapNhanTTSD : ThongTinKy
    {
        public GiayCamKetChapNhanTTSD()
        {
            TableName = "GiayCamKetChapNhanTTSD";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.GCKCNTTSD;
            TenMauPhieu = DanhMucPhieu.GCKCNTTSD.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public decimal ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Bệnh viện")]
		public string BenhVien { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Mã bệnh án")]
		public string MaBenhAn { get; set; }
        [MoTaDuLieu("Sở Y Tế")]
		public string SoYTe { get; set; }
        public string TenToiLa { get; set; }
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
        public string HoVaTen { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }

        public string QuanHeNguoiLamPhieu { get; set; }
        public string NguoiChungThuNhat { get; set; }
        public string NguoiChungThuHai { get; set; }

        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
        
    }
    public class GiayCamKetChapNhanTTSDFunc
    {
        public const string TableName = "GiayCamKetChapNhanTTSD";
        public const string TablePrimaryKeyName = "ID";
        public const string MaPhieu = "GCKCNTTDCTMTT";

        public static bool Delete(MDB.MDBConnection MyConnection, decimal id)
        {
            try
            {
                string sql = "DELETE FROM GiayCamKetChapNhanTTSD WHERE ID = :ID";
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
       
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, string IDCHon)
        {
            string sql = @"select * "
                         + " from GiayCamKetChapNhanTTSD WHERE ID =: ID ORDER BY NgayTao, NgaySua asc";
            MDB.MDBCommand Command;
            MDB.MDBDataAdapter adt;
            using (Command = new MDB.MDBCommand(sql, MyConnection))
            {
                Command.Parameters.Add(new MDB.MDBParameter("ID", IDCHon));
                adt = new MDB.MDBDataAdapter(Command);
            }
            var ds = new DataSet();
            adt.Fill(ds, "TB");
            ds.Tables[0].AddColumn("SOYTE", typeof(string));
            ds.Tables[0].AddColumn("BENHVIEN", typeof(string));
            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["SOYTE"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, GiayCamKetChapNhanTTSD ketQua)
        {
            try
            {
                string sql = @"INSERT INTO GiayCamKetChapNhanTTSD
                (
                    MaQuanLy,
                    MaBenhNhan,
                    MaBenhAn,
                    Khoa,
                    MaKhoa,
                    TenToiLa,
                    Tuoi,
                    GioiTinh,
                    DanToc,
                    NgoaiKieu,
                    NgheNghiep,
                    NoiLamViec,
                    DiaChi,
                    QuanHeNguoiLamPhieu,
                    HoVaTen,
                    NguoiChungThuNhat,
                    NguoiChungThuHai,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
                    :MaBenhNhan,
                    :MaBenhAn,
                    :Khoa,
                    :MaKhoa,
                    :TenToiLa,
                    :Tuoi,
                    :GioiTinh,
				    :DanToc,
                    :NgoaiKieu,
                    :NgheNghiep,
                    :NoiLamViec,
                    :DiaChi,
                    :QuanHeNguoiLamPhieu,
                    :HoVaTen,
                    :NguoiChungThuNhat,
                    :NguoiChungThuHai,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE GiayCamKetChapNhanTTSD SET 
                    MaQuanLy = :MaQuanLy,
                    MaBenhNhan = :MaBenhNhan,
                    MaBenhAn = :MaBenhAn,
                    Khoa = :Khoa,
                    MaKhoa = :MaKhoa,
                    TenToiLa = :TenToiLa,
                    Tuoi = :Tuoi,
                    GioiTinh = :GioiTinh,
                    DanToc = :DanToc,
                    NgoaiKieu = :NgoaiKieu,
                    NgheNghiep = :NgheNghiep,
                    NoiLamViec = :NoiLamViec,
                    DiaChi = :DiaChi,
                    QuanHeNguoiLamPhieu = :QuanHeNguoiLamPhieu,
                    HoVaTen = :HoVaTen,
                    NguoiChungThuNhat = :NguoiChungThuNhat,
                    NguoiChungThuHai = :NguoiChungThuHai,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ketQua.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhAn", ketQua.MaBenhAn));
                Command.Parameters.Add(new MDB.MDBParameter("TenToiLa", ketQua.TenToiLa));
                Command.Parameters.Add(new MDB.MDBParameter("GioiTinh", ketQua.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa", ketQua.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaKhoa", ketQua.Khoa));

                Command.Parameters.Add(new MDB.MDBParameter("Tuoi", ketQua.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("DanToc", ketQua.DanToc));
                Command.Parameters.Add(new MDB.MDBParameter("NgoaiKieu", ketQua.NgoaiKieu));

                Command.Parameters.Add(new MDB.MDBParameter("NgheNghiep", ketQua.NgheNghiep));
                Command.Parameters.Add(new MDB.MDBParameter("NoiLamViec", ketQua.NoiLamViec));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", ketQua.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("QuanHeNguoiLamPhieu", ketQua.QuanHeNguoiLamPhieu));
                Command.Parameters.Add(new MDB.MDBParameter("HoVaTen", ketQua.HoVaTen));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiChungThuNhat", ketQua.NguoiChungThuNhat));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiChungThuHai", ketQua.NguoiChungThuHai));

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
        public static List<GiayCamKetChapNhanTTSD> GetListData(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            List<GiayCamKetChapNhanTTSD> lstData = new List<GiayCamKetChapNhanTTSD>();
            string sql = @"select * from GiayCamKetChapNhanTTSD WHERE MaQuanLy = :MaQuanLy ";
   
            sql += " ORDER BY NgayTao, NgaySua asc";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            while (DataReader.Read())
            {
                GiayCamKetChapNhanTTSD data = new GiayCamKetChapNhanTTSD();

                data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                data.MaQuanLy = MaQuanLy;
                data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                data.MaBenhAn = DataReader["MaBenhAn"].ToString();

                data.TenToiLa = DataReader["TenToiLa"].ToString();
                data.Tuoi = DataReader["Tuoi"].ToString();
                data.GioiTinh = DataReader["GioiTinh"].ToString();
                data.Khoa = DataReader["Khoa"].ToString();
                data.MaKhoa = DataReader["MaKhoa"].ToString();
                data.DanToc = DataReader["DanToc"].ToString();
                data.NgoaiKieu = DataReader["NgoaiKieu"].ToString();
                data.NgheNghiep = DataReader["NgheNghiep"].ToString();
                data.NoiLamViec = DataReader["NoiLamViec"].ToString();
                data.DiaChi = DataReader["DiaChi"].ToString();
                data.QuanHeNguoiLamPhieu = DataReader["QuanHeNguoiLamPhieu"].ToString();
                data.HoVaTen = DataReader["HoVaTen"].ToString();
                data.NguoiChungThuNhat = DataReader["NguoiChungThuNhat"].ToString();
                data.NguoiChungThuHai = DataReader["NguoiChungThuHai"].ToString();

                data.NgayTao = Convert.ToDateTime(DataReader["NGAYTAO"] == DBNull.Value ? DateTime.Now : DataReader["NGAYTAO"]);
                data.NguoiTao = DataReader["NGUOITAO"].ToString();
                data.NgaySua = Convert.ToDateTime(DataReader["NGAYSUA"] == DBNull.Value ? DateTime.Now : DataReader["NGAYSUA"]);
                data.NguoiSua = DataReader["NGUOISUA"].ToString();

                data.MaSoKy = DataReader["masokyten"].ToString();
                data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;

                lstData.Add(data);
                
            }
            return lstData;
        }
    }
}
