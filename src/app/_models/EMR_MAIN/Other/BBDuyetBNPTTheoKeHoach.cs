
using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class BBDuyetBNPTTheoKeHoach : ThongTinKy
    {
        public BBDuyetBNPTTheoKeHoach()
        {
            IDMauPhieu = (int)DanhMucPhieu.BBDBNPTTKH;
            TenMauPhieu = DanhMucPhieu.BBDBNPTTKH.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
		[MoTaDuLieu("Sở Y Tế")]
		public string SoYTe { get; set; }
        [MoTaDuLieu("Bệnh viện")]
		public string BenhVien { get; set; }
        [MoTaDuLieu("Số biên bản")]
        public string So { get; set; }

        [MoTaDuLieu("Thời gian bắt đầu")]
        public DateTime ThoiGian { get; set; }
        [MoTaDuLieu("Thời gian kết thúc")]
        public DateTime ThoiGianKetThuc { get; set; }
        [MoTaDuLieu("Địa điểm")]
        public string DiaDiem { get; set; }
        [MoTaDuLieu("Họ tên Chủ trì")]
        public string ChuTri { get; set; }
        [MoTaDuLieu("Mã người chủ trì")]
        public string MaChuTri { get; set; }
        [MoTaDuLieu("Chức vụ người chủ trì")]
        public string ChucVuChuTri { get; set; }
        [MoTaDuLieu("Họ tên thư ký")]
        public string ThuKy { get; set; }
        [MoTaDuLieu("Mã thư ký")]
        public string MaThuKy { get; set; }
        [MoTaDuLieu("Chức vụ thư ký")]
        public string ChucVuThuKy { get; set; }
        [MoTaDuLieu("Nội dung cuộc họp")]
        public string NoiDung { get; set; }
        [MoTaDuLieu("Diễn biến cuộc họp")]
        public string DienBien { get; set; }
        [MoTaDuLieu("Kèm theo danh sách bệnh nhân phẫu thuật theo kế hoạch từ ngày")]
        public DateTime DsTuNgay { get; set; }
        [MoTaDuLieu("Kèm theo danh sách bệnh nhân phẫu thuật theo kế hoạch đến ngày")]
        public DateTime DsDenNgay { get; set; }
        [MoTaDuLieu("Danh sách bệnh viện")]
        public string DsBenhVien { get; set; }
        [MoTaDuLieu("Họ tên chủ trì 2")]
        public string ChuTri2 { get; set; }
        [MoTaDuLieu("Mã chủ trì 2")]
        public string MaChuTri2 { get; set; }
        [MoTaDuLieu("Họ tên thư ký 2")]
        public string ThuKy2 { get; set; }
        [MoTaDuLieu("Mã thư ký 2")]
        public string MaThuKy2 { get; set; }

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
        //public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
    }
    public class BBDuyetBNPTTheoKeHoachFunc
    {
        public const string TableName = "BBDuyetBNPTTheoKeHoach";
        public const string TablePrimaryKeyName = "ID";

        public static List<BBDuyetBNPTTheoKeHoach> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BBDuyetBNPTTheoKeHoach> list = new List<BBDuyetBNPTTheoKeHoach>();
            try
            {
                string sql = @"SELECT * FROM BBDuyetBNPTTheoKeHoach where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    BBDuyetBNPTTheoKeHoach data = new BBDuyetBNPTTheoKeHoach();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.SoYTe = XemBenhAn._HanhChinhBenhNhan.SoYTe;
                    data.BenhVien = XemBenhAn._HanhChinhBenhNhan.BenhVien;

                    data.So = Common.ConDBNull(DataReader["So"]);

                    data.So = Common.ConDBNull(DataReader["So"]);
                    data.ThoiGian = Common.ConDB_DateTime(DataReader["ThoiGian"]);
                    data.ThoiGianKetThuc = Common.ConDB_DateTime(DataReader["ThoiGianKetThuc"]);
                    data.DiaDiem = Common.ConDBNull(DataReader["DiaDiem"]);
                    data.ChuTri = Common.ConDBNull(DataReader["ChuTri"]);
                    data.MaChuTri = Common.ConDBNull(DataReader["MaChuTri"]);
                    data.ChucVuChuTri = Common.ConDBNull(DataReader["ChucVuChuTri"]);
                    data.ThuKy = Common.ConDBNull(DataReader["ThuKy"]);
                    data.MaThuKy = Common.ConDBNull(DataReader["MaThuKy"]);
                    data.ChucVuThuKy = Common.ConDBNull(DataReader["ChucVuThuKy"]);
                    data.NoiDung = Common.ConDBNull(DataReader["NoiDung"]);
                    data.DienBien = Common.ConDBNull(DataReader["DienBien"]);
                    data.DsTuNgay = Common.ConDB_DateTime(DataReader["DsTuNgay"]);
                    data.DsDenNgay = Common.ConDB_DateTime(DataReader["DsDenNgay"]);
                    data.DsBenhVien = Common.ConDBNull(DataReader["DsBenhVien"]);
                    data.ChuTri2 = Common.ConDBNull(DataReader["ChuTri2"]);
                    data.MaChuTri2 = Common.ConDBNull(DataReader["MaChuTri2"]);
                    data.ThuKy2 = Common.ConDBNull(DataReader["ThuKy2"]);
                    data.MaThuKy2 = Common.ConDBNull(DataReader["MaThuKy2"]);

                    data.NguoiTao = Common.ConDBNull(DataReader["NguoiTao"]);
                    data.NguoiSua = Common.ConDBNull(DataReader["NguoiSua"]);
                    data.NgayTao = Common.ConDB_DateTime(DataReader["NgayTao"]);
                    data.NgaySua = Common.ConDB_DateTime(DataReader["NgaySua"]);
                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy);
                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool DeleteByIDPhieu(MDB.MDBConnection oracleConnection, decimal ID)
        {
            try
            {
                string sql = "";
                MDB.MDBCommand oracleCommand;
                sql = @"DELETE FROM BBDuyetBNPTTheoKeHoach WHERE ID =" + ID;
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
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, long ID)
        {
            string sql = @"SELECT * FROM BBDuyetBNPTTheoKeHoach WHERE ID =: ID ORDER BY NgayTao, NgaySua asc";
            MDB.MDBCommand Command;
            MDB.MDBDataAdapter adt;
            using (Command = new MDB.MDBCommand(sql, MyConnection))
            {
                Command.Parameters.Add(new MDB.MDBParameter("ID", ID));
                adt = new MDB.MDBDataAdapter(Command);
            }
            var ds = new DataSet();
            adt.Fill(ds, "TBL");
            try
            {
                ds.Tables[0].AddColumn("SoYTe", typeof(string));
                ds.Tables[0].AddColumn("BenhVien", typeof(string));
                ds.Tables[0].Rows[0]["SoYTe"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
                ds.Tables[0].Rows[0]["BenhVien"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            }
            catch { }
            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BBDuyetBNPTTheoKeHoach data)
        {
            try
            {
                string sql = @"INSERT INTO BBDuyetBNPTTheoKeHoach
                (
                    MaQuanLy,
                    So,
                    ThoiGian,
                    ThoiGianKetThuc,
                    DiaDiem,
                    ChuTri,
                    MaChuTri,
                    ChucVuChuTri,
                    ThuKy,
                    MaThuKy,
                    ChucVuThuKy,
                    NoiDung,
                    DienBien,
                    DsTuNgay,
                    DsDenNgay,
                    DsBenhVien,
                    ChuTri2,
                    MaChuTri2,
                    ThuKy2,
                    MaThuKy2,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
                    :So,
                    :ThoiGian,
                    :ThoiGianKetThuc,
                    :DiaDiem,
                    :ChuTri,
                    :MaChuTri,
                    :ChucVuChuTri,
                    :ThuKy,
                    :MaThuKy,
                    :ChucVuThuKy,
                    :NoiDung,
                    :DienBien,
                    :DsTuNgay,
                    :DsDenNgay,
                    :DsBenhVien,
                    :ChuTri2,
                    :MaChuTri2,
                    :ThuKy2,
                    :MaThuKy2,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (data.ID != 0)
                {
                    sql = @"UPDATE BBDuyetBNPTTheoKeHoach SET 
                    MaQuanLy = :MaQuanLy,
                    So=:So,
                    ThoiGian=:ThoiGian,
                    ThoiGianKetThuc=:ThoiGianKetThuc,
                    DiaDiem=:DiaDiem,
                    ChuTri=:ChuTri,
                    MaChuTri=:MaChuTri,
                    ChucVuChuTri=:ChucVuChuTri,
                    ThuKy=:ThuKy,
                    MaThuKy=:MaThuKy,
                    ChucVuThuKy=:ChucVuThuKy,
                    NoiDung=:NoiDung,
                    DienBien=:DienBien,
                    DsTuNgay=:DsTuNgay,
                    DsDenNgay=:DsDenNgay,
                    DsBenhVien=:DsBenhVien,
                    ChuTri2=:ChuTri2,
                    MaChuTri2=:MaChuTri2,
                    ThuKy2=:ThuKy2,
                    MaThuKy2=:MaThuKy2,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + data.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", data.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", data.NgaySua));
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", data.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("So", data.So));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGian", data.ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianKetThuc", data.ThoiGianKetThuc));
                Command.Parameters.Add(new MDB.MDBParameter("DiaDiem", data.DiaDiem));
                Command.Parameters.Add(new MDB.MDBParameter("ChuTri", data.ChuTri));
                Command.Parameters.Add(new MDB.MDBParameter("MaChuTri", data.MaChuTri));
                Command.Parameters.Add(new MDB.MDBParameter("ChucVuChuTri", data.ChucVuChuTri));
                Command.Parameters.Add(new MDB.MDBParameter("ThuKy", data.ThuKy));
                Command.Parameters.Add(new MDB.MDBParameter("MaThuKy", data.MaThuKy));
                Command.Parameters.Add(new MDB.MDBParameter("ChucVuThuKy", data.ChucVuThuKy));
                Command.Parameters.Add(new MDB.MDBParameter("NoiDung", data.NoiDung));
                Command.Parameters.Add(new MDB.MDBParameter("DienBien", data.DienBien));
                Command.Parameters.Add(new MDB.MDBParameter("DsTuNgay", data.DsTuNgay));
                Command.Parameters.Add(new MDB.MDBParameter("DsDenNgay", data.DsDenNgay));
                Command.Parameters.Add(new MDB.MDBParameter("DsBenhVien", data.DsBenhVien));
                Command.Parameters.Add(new MDB.MDBParameter("ChuTri2", data.ChuTri2));
                Command.Parameters.Add(new MDB.MDBParameter("MaChuTri2", data.MaChuTri2));
                Command.Parameters.Add(new MDB.MDBParameter("ThuKy2", data.ThuKy2));
                Command.Parameters.Add(new MDB.MDBParameter("MaThuKy2", data.MaThuKy2));

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
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    data.ID = nextval;
                }
                return n > 0;
            }
            catch (Exception ex)
            {
                XuLyLoi.LogError(ex);
            }
            return false;
        }
    }
}
