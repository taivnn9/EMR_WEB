using EMR.KyDienTu;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using PMS.Access;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class XetNghiem
    {
        [MoTaDuLieu("Loại xét nghiệm")]
        public string LoaiXetNghiem { get; set; }
        [MoTaDuLieu("Kết quả xét nghiệm")]
        public string KetQua { get; set; }
    }
    public class BienBanHoiChanCanThiepTimMach : ThongTinKy
    {
        public BienBanHoiChanCanThiepTimMach()
        {
            TableName = "BienBanHCCTTimMach";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BBHCTTTM;
            TenMauPhieu = DanhMucPhieu.BBHCTTTM.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }
        [MoTaDuLieu("Tiền sử")]
        public string TienSu { get; set; }
        [MoTaDuLieu("Bệnh sử")]
        public string BenhSu { get; set; }
        [MoTaDuLieu("Khám hiện tại")]
        public string KhamHienTai { get; set; }
        [MoTaDuLieu("Danh sách kết quả xét nghiệm")]
        public ObservableCollection<XetNghiem> KetQuaXetNghiem { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh trước thủ thuật")]
		public string ChanDoanTruocThuThuat { get; set; }
        [MoTaDuLieu("Phương pháp thủ thuật")]
        public string PhuongPhapThuThuat { get; set; }
        [MoTaDuLieu("Danh sách kíp thủ thuật")]
        public ObservableCollection<NhanVien> KipThuThuat{ get;set; }
        [MoTaDuLieu("Ngày can thiệp")]
        public DateTime NgayCanThiep { get; set; }
        [MoTaDuLieu("Họ tên giám đốc duyệt")]
        public string GiamDoc { get; set; }
        [MoTaDuLieu("Mã giám đốc duyệt")]
        public string MaGiamDoc { get; set; }
        [MoTaDuLieu("Họ tên lãnh đạo duyệt")]
        public string LanhDao { get; set; }
        [MoTaDuLieu("Mã lãnh đạo duyệt")]
        public string MaLanhDao { get; set; }
        [MoTaDuLieu("Họ tên phó chủ nhiệm khoa")]
        public string PhoChuNhiemKhoa { get; set; }
        [MoTaDuLieu("Mã phó chủ nhiệm khoa")]
        public string MaPhoChuNhiemKhoa { get; set; }
        [MoTaDuLieu("Họ tên bác sỹ thủ thuật")]
        public string BacSyThuThuat { get; set; }
        [MoTaDuLieu("Mã bác sỹ thủ thuật")]
        public string MaBacSyThuThuat { get; set; }
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
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
    }
    public class BienBanHoiChanCanThiepTimMachFunc
    {
        public const string TableName = "BienBanHCCTTimMach";
        public const string TablePrimaryKeyName = "ID";
        public static List<BienBanHoiChanCanThiepTimMach> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BienBanHoiChanCanThiepTimMach> list = new List<BienBanHoiChanCanThiepTimMach>();
            try
            {
                string sql = @"SELECT * FROM BienBanHCCTTimMach where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    BienBanHoiChanCanThiepTimMach data = new BienBanHoiChanCanThiepTimMach();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.Khoa = DataReader["Khoa"].ToString();
                    data.MaKhoa = DataReader["MaKhoa"].ToString();
                    data.TienSu = DataReader["TienSu"].ToString();
                    data.BenhSu = DataReader["BenhSu"].ToString();
                    data.KhamHienTai = DataReader["KhamHienTai"].ToString();
                    data.KetQuaXetNghiem = JsonConvert.DeserializeObject<ObservableCollection<XetNghiem>>(DataReader["KetQuaXetNghiem"].ToString()); 
                    data.ChanDoanTruocThuThuat = DataReader["ChanDoanTruocThuThuat"].ToString();
                    data.PhuongPhapThuThuat = DataReader["PhuongPhapThuThuat"].ToString();
                    data.KipThuThuat = JsonConvert.DeserializeObject<ObservableCollection<NhanVien>>(DataReader["KipThuThuat"].ToString());
                    data.NgayCanThiep = Convert.ToDateTime(DataReader["NgayCanThiep"] == DBNull.Value ? DateTime.Now : DataReader["NgayCanThiep"]);

                    data.GiamDoc = DataReader["GiamDoc"].ToString();
                    data.MaGiamDoc = DataReader["MaGiamDoc"].ToString();
                    data.LanhDao = DataReader["LanhDao"].ToString();
                    data.MaLanhDao = DataReader["MaLanhDao"].ToString();
                    data.PhoChuNhiemKhoa = DataReader["PhoChuNhiemKhoa"].ToString();
                    data.MaPhoChuNhiemKhoa = DataReader["MaPhoChuNhiemKhoa"].ToString();

                    data.BacSyThuThuat = DataReader["BacSyThuThuat"].ToString();
                    data.MaBacSyThuThuat = DataReader["MaBacSyThuThuat"].ToString();

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BienBanHoiChanCanThiepTimMach bienBan)
        {
            try
            {
                string sql = @"INSERT INTO BienBanHCCTTimMach
                (
                      MAQUANLY,
                      MaBenhNhan,
                      Khoa,
                      MaKhoa,
                      TienSu,
                      BenhSu,
                      KhamHienTai,
                      KetQuaXetNghiem,
                      ChanDoanTruocThuThuat,
                      PhuongPhapThuThuat,
                      KipThuThuat,
                      NgayCanThiep,
                      GiamDoc, 
                      MaGiamDoc, 
                      LanhDao, 
                      MaLanhDao, 
                      PhoChuNhiemKhoa, 
                      MaPhoChuNhiemKhoa, 
                      BacSyThuThuat, 
                      MaBacSyThuThuat, 
                      NGUOITAO,
                      NGUOISUA,
                      NGAYTAO,
                      NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :Khoa,
                    :MaKhoa,
                    :TienSu,
                    :BenhSu,
                    :KhamHienTai,
                    :KetQuaXetNghiem,
                    :ChanDoanTruocThuThuat,
                    :PhuongPhapThuThuat,
                    :KipThuThuat,
                    :NgayCanThiep,
                    :GiamDoc, 
                    :MaGiamDoc, 
                    :LanhDao, 
                    :MaLanhDao, 
                    :PhoChuNhiemKhoa, 
                    :MaPhoChuNhiemKhoa, 
                    :BacSyThuThuat, 
                    :MaBacSyThuThuat, 
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (bienBan.ID != 0)
                {
                    sql = @"UPDATE BienBanHCCTTimMach SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    Khoa = :Khoa,
                    MaKhoa = :MaKhoa,
                    TienSu = :TienSu,
                    BenhSu = :BenhSu,
                    KhamHienTai = :KhamHienTai,
                    KetQuaXetNghiem = :KetQuaXetNghiem,
                    ChanDoanTruocThuThuat = :ChanDoanTruocThuThuat,
                    PhuongPhapThuThuat = :PhuongPhapThuThuat,
                    KipThuThuat = :KipThuThuat,
                    NgayCanThiep = :NgayCanThiep,
                    GiamDoc = :GiamDoc, 
                    MaGiamDoc = :MaGiamDoc, 
                    LanhDao = :LanhDao, 
                    MaLanhDao = :MaLanhDao, 
                    PhoChuNhiemKhoa = :PhoChuNhiemKhoa, 
                    MaPhoChuNhiemKhoa = :MaPhoChuNhiemKhoa, 
                    BacSyThuThuat = :BacSyThuThuat, 
                    MaBacSyThuThuat = :MaBacSyThuThuat, 
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + bienBan.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bienBan.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", bienBan.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa", bienBan.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaKhoa", bienBan.MaKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("TienSu", bienBan.TienSu));
                Command.Parameters.Add(new MDB.MDBParameter("BenhSu", bienBan.BenhSu));
                Command.Parameters.Add(new MDB.MDBParameter("KhamHienTai", bienBan.KhamHienTai));
                Command.Parameters.Add(new MDB.MDBParameter("KetQuaXetNghiem", JsonConvert.SerializeObject(bienBan.KetQuaXetNghiem)));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTruocThuThuat", bienBan.ChanDoanTruocThuThuat));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapThuThuat", bienBan.PhuongPhapThuThuat));
                Command.Parameters.Add(new MDB.MDBParameter("KipThuThuat", JsonConvert.SerializeObject(bienBan.KipThuThuat)));
                Command.Parameters.Add(new MDB.MDBParameter("NgayCanThiep", bienBan.NgayCanThiep));
                Command.Parameters.Add(new MDB.MDBParameter("GiamDoc", bienBan.GiamDoc));
                Command.Parameters.Add(new MDB.MDBParameter("MaGiamDoc", bienBan.MaGiamDoc));
                Command.Parameters.Add(new MDB.MDBParameter("LanhDao", bienBan.LanhDao));
                Command.Parameters.Add(new MDB.MDBParameter("MaLanhDao", bienBan.MaLanhDao));
                Command.Parameters.Add(new MDB.MDBParameter("PhoChuNhiemKhoa", bienBan.PhoChuNhiemKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaPhoChuNhiemKhoa", bienBan.MaPhoChuNhiemKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyThuThuat", bienBan.BacSyThuThuat));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSyThuThuat", bienBan.MaBacSyThuThuat));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", bienBan.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", bienBan.NgaySua));
                if (bienBan.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", bienBan.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", bienBan.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", bienBan.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (bienBan.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    bienBan.ID = nextval;
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
                string sql = "DELETE FROM BienBanHCCTTimMach WHERE ID = :ID";
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
                B.TienSu,
                B.BenhSu,
                B.KhamHienTai,
                B.ChanDoanTruocThuThuat,
                B.PhuongPhapThuThuat,
                B.NgayCanThiep,
                B.GiamDoc,
                B.MaGiamDoc,
                B.LanhDao,
                B.MaLanhDao,
                B.PhoChuNhiemKhoa,
                B.MaPhoChuNhiemKhoa,
                B.BacSyThuThuat,
                B.MaBacSyThuThuat,
                T.MABENHNHAN,
                T.SONHAPVIEN,
                T.NGAYVAOVIEN,
	            H.TENBENHNHAN,
                H.TUOI,
                H.GIOITINH,    
                H.SOYTE,
                H.BENHVIEN
            FROM
                BienBanHCCTTimMach B
                LEFT JOIN THONGTINDIEUTRI T ON B.MAQUANLY = T.MAQUANLY
                LEFT JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            adt.Fill(ds, "BB");

            sql = @"SELECT
                B.KetQuaXetNghiem
            FROM
                BienBanHCCTTimMach B
            WHERE
                ID = " + id;
            Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            ObservableCollection<XetNghiem> KQXetNghiem = new ObservableCollection<XetNghiem>();
            while (DataReader.Read())
            {
                KQXetNghiem = JsonConvert.DeserializeObject<ObservableCollection<XetNghiem>>(DataReader["KetQuaXetNghiem"].ToString());
            }
            DataTable DanhSachXN = new DataTable("XN");
            DanhSachXN.Columns.Add("LoaiXetNghiem");
            DanhSachXN.Columns.Add("KetQua");

            for (int i = 0; i < KQXetNghiem.Count; i++)
            {
                DanhSachXN.Rows.Add(KQXetNghiem[i].LoaiXetNghiem, KQXetNghiem[i].KetQua);
            }
            ds.Tables.Add(DanhSachXN);

            sql = @"SELECT
                B.KipThuThuat
            FROM
                BienBanHCCTTimMach B
            WHERE
                ID = " + id;
            Command = new MDB.MDBCommand(sql, MyConnection);
            DataReader = Command.ExecuteReader();
            ObservableCollection<NhanVien> kipThuThuat = new ObservableCollection<NhanVien>();
            while (DataReader.Read())
            {
                kipThuThuat = JsonConvert.DeserializeObject<ObservableCollection<NhanVien>>(DataReader["KipThuThuat"].ToString());
            }
            DataTable DanhSachThuThuat = new DataTable("KTT");
            DanhSachThuThuat.Columns.Add("HOVATEN");

            for (int i = 0; i < kipThuThuat.Count; i++)
            {
                DanhSachThuThuat.Rows.Add(kipThuThuat[i].HoVaTen);
            }
            ds.Tables.Add(DanhSachThuThuat);
            return ds;
        }
    }
}
