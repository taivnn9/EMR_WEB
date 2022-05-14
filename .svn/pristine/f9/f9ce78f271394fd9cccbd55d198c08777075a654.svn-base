using EMR.KyDienTu;
using Newtonsoft.Json;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class BangKiemTraDungCu : ThongTinKy
    {
        public BangKiemTraDungCu()
        {
            TableName = "BangKiemtraDungCu";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BKTDC;
            TenMauPhieu = DanhMucPhieu.BKTDC.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Mã bệnh án")]
		public string MaBenhAn { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
        public string HoTenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }
        [MoTaDuLieu("Buồng")]
		public string Buong { get; set; }
        [MoTaDuLieu("Giường")]
		public string Giuong { get; set; }
        public DateTime? NgayPhauThuat { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("ICD")]
        public string ICD { get; set; }
        [MoTaDuLieu("Phương pháp phẫu thuật")]
        public string PhuongPhapPhauThuat { get; set; }
        [MoTaDuLieu("Họ tênPhẫu thuật viên chính")]
        public string PTVChinh { get; set; }
        [MoTaDuLieu("Mã phẫu thuật viên chính")]
        public string MaPTVChinh { get; set; }
        [MoTaDuLieu("Họ và tên phụ mổ")]
        public string PhuMo { get; set; }
        [MoTaDuLieu("Mã người phụ mổ")]
        public string MaPhuMo { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng VT")]
		public string DieuDuongVT { get; set; }
        [MoTaDuLieu("Mã điều dưỡng VT")]
		public string MaDieuDuongVT { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng VN")]
		public string DieuDuongVN { get; set; }
        [MoTaDuLieu("Mã điều dưỡng VN")]
		public string MaDieuDuongVN { get; set; }
        [MoTaDuLieu("Họ tên người gây mê")]
        public string GayMe { get; set; }
        [MoTaDuLieu("Mã người gây mê")]
        public string MaGayMe { get; set; }
        [MoTaDuLieu("Điều dưỡng gây mê")]
        public string DDGayMe { get; set; }
        [MoTaDuLieu("Mã điều dưỡng gây mê")]
        public string MaDDGayMe { get; set; }
        [MoTaDuLieu("Bảng chi tiết")]
        public BangChiTiet ChiTiets { get; set; }
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
    public class BangChiTiet
    {
        public ObservableCollection<BangKiemDichVuChiTiet> BoDungCu { get; set; }
        public ObservableCollection<BangKiemDichVuChiTiet> GonGac { get; set; }
        public ObservableCollection<BangKiemDichVuChiTiet> Dao { get; set; }
    }
    public class BangKiemDichVuChiTiet
    {
        public string STT { get; set; }
        public string TDC { get; set; }
        public string TM_SL { get; set; }
        public string TM_DV { get; set; }
        public string SM_SL { get; set; }
        public string SM_DV { get; set; }
        public string GC { get; set; }
    }
    public class BangKiemTraDungCuFunc
    {
        public const string TableName = "BangKiemTraDungCu";
        public const string TablePrimaryKeyName = "ID";
        public static List<BangKiemTraDungCu> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BangKiemTraDungCu> list = new List<BangKiemTraDungCu>();
            try
            {
                string sql = @"SELECT * FROM BangKiemTraDungCu where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    BangKiemTraDungCu data = new BangKiemTraDungCu();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.MaBenhAn = DataReader["MaBenhAn"].ToString();
                    data.HoTenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.ICD = DataReader["ICD"].ToString();
                    data.DiaChi = DataReader["DiaChi"].ToString();
                    data.Khoa = DataReader["Khoa"].ToString();
                    data.MaKhoa = DataReader["MaKhoa"].ToString();
                    data.Buong = DataReader["Buong"].ToString();
                    data.Giuong = DataReader["Giuong"].ToString();
                    data.NgayPhauThuat = DataReader["NgayPhauThuat"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayPhauThuat"]) : null;
                    data.PhuongPhapPhauThuat = DataReader["PhuongPhapPhauThuat"].ToString();
                    data.PTVChinh = DataReader["PTVChinh"].ToString();
                    data.MaPTVChinh = DataReader["MaPTVChinh"].ToString();
                    data.PhuMo = DataReader["PhuMo"].ToString();
                    data.MaPhuMo = DataReader["MaPhuMo"].ToString();
                    data.DieuDuongVT = DataReader["DieuDuongVT"].ToString();
                    data.MaDieuDuongVT = DataReader["MaDieuDuongVT"].ToString();
                    data.DieuDuongVN = DataReader["DieuDuongVN"].ToString();
                    data.MaDieuDuongVN = DataReader["MaDieuDuongVN"].ToString();
                    data.GayMe = DataReader["GayMe"].ToString();
                    data.MaGayMe = DataReader["MaGayMe"].ToString();
                    data.DDGayMe = DataReader["DDGayMe"].ToString();
                    data.MaDDGayMe = DataReader["MaDDGayMe"].ToString();

                    string bangKeJson = DataReader["ChiTiets_1"].ToString();
                    if (DataReader["ChiTiets_2"] != DBNull.Value)
                        bangKeJson += DataReader["ChiTiets_2"].ToString();
                    data.ChiTiets = JsonConvert.DeserializeObject<BangChiTiet>(bangKeJson);

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BangKiemTraDungCu bangKe)
        {
            try
            {
                string sql = @"INSERT INTO BangKiemTraDungCu
                (
                    MAQUANLY,
                    MaBenhNhan,
                    MaBenhAn,
                    DiaChi,
                    Khoa,
                    MaKhoa,
                    Buong,
                    Giuong,
                    NgayPhauThuat,
                    ChanDoan,
                    ICD,
                    PhuongPhapPhauThuat,
                    PTVChinh,
                    MaPTVChinh,
                    PhuMo,
                    MaPhuMo,
                    DieuDuongVT,
                    MaDieuDuongVT,
                    DieuDuongVN,
                    MaDieuDuongVN,
                    GayMe,
                    MaGayMe,
                    DDGayMe,
                    MaDDGayMe,
                    ChiTiets_1,
                    ChiTiets_2,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :MaBenhAn,
                    :DiaChi,
                    :Khoa,
                    :MaKhoa,
                    :Buong,
                    :Giuong,
                    :NgayPhauThuat,
                    :ChanDoan,
                    :ICD,
                    :PhuongPhapPhauThuat,
                    :PTVChinh,
                    :MaPTVChinh,
                    :PhuMo,
                    :MaPhuMo,
                    :DieuDuongVT,
                    :MaDieuDuongVT,
                    :DieuDuongVN,
                    :MaDieuDuongVN,
                    :GayMe,
                    :MaGayMe,
                    :DDGayMe,
                    :MaDDGayMe,
                    :ChiTiets_1,
                    :ChiTiets_2,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (bangKe.ID != 0)
                {
                    sql = @"UPDATE BangKiemTraDungCu SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    MaBenhAn = :MaBenhAn,
                    DiaChi = :DiaChi,
                    Khoa = :Khoa,
                    MaKhoa = :MaKhoa,
                    Buong = :Buong,
                    Giuong = :Giuong,
                    NgayPhauThuat = :NgayPhauThuat,
                    ChanDoan = :ChanDoan,
                    ICD = :ICD,
                    PhuongPhapPhauThuat = :PhuongPhapPhauThuat,
                    PTVChinh = :PTVChinh,
                    MaPTVChinh = :MaPTVChinh,
                    PhuMo = :PhuMo,
                    MaPhuMo = :MaPhuMo,
                    DieuDuongVT = :DieuDuongVT,
                    MaDieuDuongVT = :MaDieuDuongVT,
                    DieuDuongVN = :DieuDuongVN,
                    MaDieuDuongVN = :MaDieuDuongVN,
                    GayMe = :GayMe,
                    MaGayMe = :MaGayMe,
                    DDGayMe = :DDGayMe,
                    MaDDGayMe = :MaDDGayMe,
                    ChiTiets_1 = :ChiTiets_1,
                    ChiTiets_2 = :ChiTiets_2,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + bangKe.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangKe.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", bangKe.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhAn", bangKe.MaBenhAn));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", bangKe.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa", bangKe.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaKhoa", bangKe.MaKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("Buong", bangKe.Buong));
                Command.Parameters.Add(new MDB.MDBParameter("Giuong", bangKe.Giuong));
                Command.Parameters.Add(new MDB.MDBParameter("NgayPhauThuat", bangKe.NgayPhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", bangKe.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("ICD", bangKe.ICD));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapPhauThuat", bangKe.PhuongPhapPhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("PTVChinh", bangKe.PTVChinh));
                Command.Parameters.Add(new MDB.MDBParameter("MaPTVChinh", bangKe.MaPTVChinh));
                Command.Parameters.Add(new MDB.MDBParameter("PhuMo", bangKe.PhuMo));
                Command.Parameters.Add(new MDB.MDBParameter("MaPhuMo", bangKe.MaPhuMo));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuongVT", bangKe.DieuDuongVT));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuongVT", bangKe.MaDieuDuongVT));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuongVN", bangKe.DieuDuongVN));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuongVN", bangKe.MaDieuDuongVN));
                Command.Parameters.Add(new MDB.MDBParameter("GayMe", bangKe.GayMe));
                Command.Parameters.Add(new MDB.MDBParameter("MaGayMe", bangKe.MaGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("DDGayMe", bangKe.DDGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("MaDDGayMe", bangKe.MaDDGayMe));
                string jsonBangKes = JsonConvert.SerializeObject(bangKe.ChiTiets);
                List<string> listJson = new List<string>();
                for (int i = 0; i < jsonBangKes.Length; i += 3999)
                {
                    if ((i + 3999) < jsonBangKes.Length)
                        listJson.Add(jsonBangKes.Substring(i, 3999));
                    else
                        listJson.Add(jsonBangKes.Substring(i));
                }
                Command.Parameters.Add(new MDB.MDBParameter("ChiTiets_1", listJson[0]));
                Command.Parameters.Add(new MDB.MDBParameter("ChiTiets_2", listJson.Count > 1 ? listJson[1] : null));

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
                string sql = "DELETE FROM BangKiemTraDungCu WHERE ID = :ID";
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
                B.MaBenhAn,
                B.DiaChi,
                B.Khoa,
                B.MaKhoa,
                B.Buong,
                B.Giuong,
                B.NgayPhauThuat,
                B.ChanDoan,
                B.PhuongPhapPhauThuat,
                B.PTVChinh,
                B.MaPTVChinh,
                B.PhuMo,
                B.MaPhuMo,
                B.DieuDuongVT,
                B.MaDieuDuongVT,
                B.DieuDuongVN,
                B.MaDieuDuongVN,
                B.GayMe,
                B.MaGayMe,
                B.DDGayMe,
                B.MaDDGayMe
            FROM
                BangKiemTraDungCu B
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "BK");
            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(int));
            ds.Tables[0].AddColumn("SOYTE", typeof(string));
            ds.Tables[0].AddColumn("BENHVIEN", typeof(string));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["GioiTinh"] = (int)XemBenhAn._HanhChinhBenhNhan.GioiTinh;
            ds.Tables[0].Rows[0]["SOYTE"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;

            sql = @"SELECT
               B.ChiTiets_1, B.ChiTiets_2
            FROM
                BangKiemTraDungCu B
                
            WHERE
                ID = " + id;

            Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            BangChiTiet saveDatas = new BangChiTiet();
            while (DataReader.Read())
            {
                string bangKeJson = DataReader["ChiTiets_1"].ToString();
                if (DataReader["ChiTiets_2"] != DBNull.Value)
                    bangKeJson += DataReader["ChiTiets_2"].ToString();
                saveDatas = JsonConvert.DeserializeObject<BangChiTiet>(bangKeJson);
                break;
            }
            DataTable ChiTiet = new DataTable("CT");
            ChiTiet.Columns.Add("STT", typeof(string));
            ChiTiet.Columns.Add("TDC", typeof(string));
            ChiTiet.Columns.Add("TM_SL", typeof(string));
            ChiTiet.Columns.Add("TM_DV", typeof(string));
            ChiTiet.Columns.Add("SM_SL", typeof(string));
            ChiTiet.Columns.Add("SM_DV", typeof(string));
            ChiTiet.Columns.Add("GC", typeof(string));
            ChiTiet.Rows.Add("", "1. BỘ DỤNG CỤ", "", "", "");
            foreach(BangKiemDichVuChiTiet ct in saveDatas.BoDungCu)
            {
                ChiTiet.Rows.Add(ct.STT, ct.TDC, ct.TM_SL, ct.TM_DV, ct.SM_SL, ct.SM_DV, ct.GC);
            }
            ChiTiet.Rows.Add("", "2. GÒN - GẠC", "", "", "");
            foreach (BangKiemDichVuChiTiet ct in saveDatas.GonGac)
            {
                ChiTiet.Rows.Add(ct.STT, ct.TDC, ct.TM_SL, ct.TM_DV, ct.SM_SL, ct.SM_DV, ct.GC);
            }
            ChiTiet.Rows.Add("", "3. DAO, KIM CHỈ, VTYT KHÁC", "", "", "");
            foreach (BangKiemDichVuChiTiet ct in saveDatas.Dao)
            {
                ChiTiet.Rows.Add(ct.STT, ct.TDC, ct.TM_SL, ct.TM_DV, ct.SM_SL, ct.SM_DV, ct.GC);
            }
            ds.Tables.Add(ChiTiet);

            return ds;

        }
    }
}
