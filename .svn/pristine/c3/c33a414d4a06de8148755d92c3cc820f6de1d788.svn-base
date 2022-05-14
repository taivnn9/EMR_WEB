using EMR.KyDienTu;
using System;
using System.Collections.Generic;
using System.Data;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class HSCS_TTBenhNhan : ThongTinKy
    {
        public HSCS_TTBenhNhan()
        {
            TableName = "HSCS_TTBenhNhan";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PHSCS;
            TenMauPhieu = DanhMucPhieu.PHSCS.Description();
        }
        [MoTaDuLieu("Mã định danh")]
        public long id { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Năm sinh")]
		public string NamSinh { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        public string LienHeVoi { get; set; }
        public string DienThoaiLienHe { get; set; }
        [MoTaDuLieu("Ngày vào bệnh viện")]
		public DateTime NgayVaoVien { get; set; }
        public DateTime NgayVaoKhoa { get; set; }
        public int BHYT { get; set; }
        public string LyDoVaoVien { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh lúc vào viện")]
		public string ChanDoanLucVaoVien { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh sau 48h")]
		public string ChanDoanSau48h { get; set; }
        public string TienSuBenh { get; set; }
        public int BenhKemTheo { get; set; }
        public int TienSuDiUng { get; set; }
        public string TienSuDiUng_Thuoc { get; set; }
        public string TienSuDiUng_Khac { get; set; }
        public int NoiChuyenDen { get; set; }
        public int GiayChuyenVien { get; set; }
        public int PTVanChuyenNguoiBenh { get; set; }
        public DateTime NgayRaVien { get; set; }
        public string ChuyenVien { get; set; }
        public string ChuyenKhoa { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuongTiepDon { get; set; }
        public string MaNVDieuDuongTiepDon { get; set; }

        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Tên file ký")]
		public string TenFileKy { get; set; }
        [MoTaDuLieu("Tên người ký")]
		public string UserNameKy { get; set; }
        [MoTaDuLieu("Ngày ký")]
		public DateTime NgayKi { get; set; }
        [MoTaDuLieu("Tên máy tính ký")]
		public string ComputerKyTen { get; set; }
        //public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
    }
    public class HSCS_TTBenhNhanFunc
    {
        public const string TableName = "HSCS_TTBenhNhan";
        public const string TablePrimaryKeyName = "ID";
        public static List<HSCS_TTBenhNhan> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<HSCS_TTBenhNhan> list = new List<HSCS_TTBenhNhan>();
            try
            {
                string sql = @"SELECT * FROM HSCS_TTBenhNhan where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    HSCS_TTBenhNhan data = new HSCS_TTBenhNhan();
                    data.id = DataReader.GetLong("id");
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader.GetString("MaBenhNhan");
                    data.TenBenhNhan = DataReader.GetString("TenBenhNhan");
                    data.GioiTinh = DataReader.GetString("GioiTinh");
                    data.NamSinh = DataReader.GetString("NamSinh");
                    data.DiaChi = DataReader.GetString("DiaChi");
                    data.LienHeVoi = DataReader.GetString("LienHeVoi");
                    data.DienThoaiLienHe = DataReader.GetString("DienThoaiLienHe");
                    data.NgayVaoVien = ConDB_DateTime(DataReader["NgayVaoVien"]);
                    data.NgayVaoKhoa = ConDB_DateTime(DataReader["NgayVaoKhoa"]);
                    data.BHYT = DataReader.GetInt("baohiemyt");
                    data.LyDoVaoVien = DataReader.GetString("LyDoVaoVien");
                    data.ChanDoanLucVaoVien = DataReader.GetString("ChanDoanLucVaoVien");
                    data.ChanDoanSau48h = DataReader.GetString("ChanDoanSau48h");
                    data.TienSuBenh = DataReader.GetString("TienSuBenh");
                    data.BenhKemTheo = DataReader.GetInt("BenhKemTheo");
                    data.TienSuDiUng = DataReader.GetInt("TienSuDiUng");
                    data.TienSuDiUng_Thuoc = DataReader.GetString("TienSuDiUng_Thuoc");
                    data.TienSuDiUng_Khac = DataReader.GetString("TienSuDiUng_Khac");
                    data.NoiChuyenDen = DataReader.GetInt("NoiChuyenDen");
                    data.GiayChuyenVien = DataReader.GetInt("GiayChuyenVien");
                    data.PTVanChuyenNguoiBenh = DataReader.GetInt("PTVanChuyenNB");
                    data.NgayRaVien = ConDB_DateTime(DataReader["NgayRaVien"]);
                    data.ChuyenVien = DataReader.GetString("ChuyenVien");
                    data.ChuyenKhoa = DataReader.GetString("ChuyenKhoa");
                    data.DieuDuongTiepDon = DataReader.GetString("DieuDuongTiepDon");
                    data.MaNVDieuDuongTiepDon = DataReader.GetString("MaNVDieuDuongTiepDon");
                    data.NguoiTao = DataReader.GetString("NguoiTao");
                    data.NguoiSua = DataReader.GetString("NguoiSua");
                    data.NgayTao = ConDB_DateTime(DataReader["NgayTao"]);
                    data.NgaySua = ConDB_DateTime(DataReader["NgaySua"]);
                    data.ComputerKyTen = DataReader.GetString("computerkyten");
                    data.MaSoKy = DataReader.GetString("MaSoKyTen");
                    data.TenFileKy = DataReader.GetString("TenFileKy");
                    data.UserNameKy = DataReader.GetString("UserNameKy");
                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static decimal GetLastestID(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            decimal IDTTBenhNhan = 0;
            try
            {
                string sql = @"select ID from HSCS_TTBenhNhan where MaQuanLy = :MaQuanLy ORDER BY ID DESC FETCH FIRST 1 ROWS ONLY";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    IDTTBenhNhan = DataReader.GetDecimal("ID");
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return IDTTBenhNhan;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref HSCS_TTBenhNhan data)
        {
            try
            {
                string sql = @"INSERT INTO HSCS_TTBenhNhan
                (
                    maquanly,
                    mabenhnhan,
                    tenbenhnhan,
                    gioitinh,
                    namsinh,
                    diachi,
                    lienhevoi,
                    dienthoailienhe,
                    ngayvaovien,
                    ngayvaokhoa,
                    baohiemyt,
                    lydovaovien,
                    chandoanlucvaovien,
                    chandoansau48h,
                    tiensubenh,
                    benhkemtheo,
                    tiensudiung,
                    tiensudiung_thuoc,
                    tiensudiung_khac,
                    noichuyenden,
                    giaychuyenvien,
                    ptvanchuyennb,
                    ngayravien,
                    chuyenvien,
                    chuyenkhoa,
                    dieuduongtiepdon,
                    manvdieuduongtiepdon,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
                    :maquanly,
                    :mabenhnhan,
                    :tenbenhnhan,
                    :gioitinh,
                    :namsinh,
                    :diachi,
                    :lienhevoi,
                    :dienthoailienhe,
                    :ngayvaovien,
                    :ngayvaokhoa,
                    :baohiemyt,
                    :lydovaovien,
                    :chandoanlucvaovien,
                    :chandoansau48h,
                    :tiensubenh,
                    :benhkemtheo,
                    :tiensudiung,
                    :tiensudiung_thuoc,
                    :tiensudiung_khac,
                    :noichuyenden,
                    :giaychuyenvien,
                    :ptvanchuyennb,
                    :ngayravien,
                    :chuyenvien,
                    :chuyenkhoa,
                    :dieuduongtiepdon,
                    :manvdieuduongtiepdon,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (data.id != Decimal.Zero)
                {
                    sql = @"UPDATE HSCS_TTBenhNhan SET 
                    maquanly=: maquanly,
                    mabenhnhan=: mabenhnhan,
                    tenbenhnhan=: tenbenhnhan,
                    gioitinh=: gioitinh,
                    namsinh=:namsinh,
                    diachi=: diachi,
                    lienhevoi=: lienhevoi,
                    dienthoailienhe=:dienthoailienhe ,
                    ngayvaovien=: ngayvaovien,
                    ngayvaokhoa=:ngayvaokhoa ,
                    baohiemyt=: baohiemyt,
                    lydovaovien=:lydovaovien ,
                    chandoanlucvaovien=:chandoanlucvaovien ,
                    chandoansau48h=:chandoansau48h ,
                    tiensubenh=:tiensubenh ,
                    benhkemtheo=: benhkemtheo,
                    tiensudiung=:tiensudiung ,
                    tiensudiung_thuoc=: tiensudiung_thuoc,
                    tiensudiung_khac=:tiensudiung_khac ,
                    noichuyenden=: noichuyenden,
                    giaychuyenvien=:giaychuyenvien ,
                    ptvanchuyennb=: ptvanchuyennb,
                    ngayravien=: ngayravien,
                    chuyenvien=: chuyenvien,
                    chuyenkhoa=: chuyenkhoa,
                    dieuduongtiepdon=:dieuduongtiepdon ,
                    manvdieuduongtiepdon=:manvdieuduongtiepdon ,
                    nguoisua = : nguoisua,
                    ngaysua = :ngaysua  
                    WHERE ID = " + data.id;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("maquanly", data.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("mabenhnhan", data.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("tenbenhnhan", data.TenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("gioitinh", data.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("namsinh", data.NamSinh));
                Command.Parameters.Add(new MDB.MDBParameter("diachi", data.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("lienhevoi", data.LienHeVoi));
                Command.Parameters.Add(new MDB.MDBParameter("dienthoailienhe", data.DienThoaiLienHe));
                Command.Parameters.Add(new MDB.MDBParameter("ngayvaovien", data.NgayVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("ngayvaokhoa", data.NgayVaoKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("baohiemyt", data.BHYT));
                Command.Parameters.Add(new MDB.MDBParameter("lydovaovien", data.LyDoVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("chandoanlucvaovien", data.ChanDoanLucVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("chandoansau48h", data.ChanDoanSau48h));
                Command.Parameters.Add(new MDB.MDBParameter("tiensubenh", data.TienSuBenh));
                Command.Parameters.Add(new MDB.MDBParameter("benhkemtheo", data.BenhKemTheo));
                Command.Parameters.Add(new MDB.MDBParameter("tiensudiung", data.TienSuDiUng));
                Command.Parameters.Add(new MDB.MDBParameter("tiensudiung_thuoc", data.TienSuDiUng_Thuoc));
                Command.Parameters.Add(new MDB.MDBParameter("tiensudiung_khac", data.TienSuDiUng_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("noichuyenden", data.NoiChuyenDen));
                Command.Parameters.Add(new MDB.MDBParameter("giaychuyenvien", data.GiayChuyenVien));
                Command.Parameters.Add(new MDB.MDBParameter("ptvanchuyennb", data.PTVanChuyenNguoiBenh));
                Command.Parameters.Add(new MDB.MDBParameter("ngayravien", data.NgayRaVien));
                Command.Parameters.Add(new MDB.MDBParameter("chuyenvien", data.ChuyenVien));
                Command.Parameters.Add(new MDB.MDBParameter("chuyenkhoa", data.ChuyenKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("dieuduongtiepdon", data.DieuDuongTiepDon));
                Command.Parameters.Add(new MDB.MDBParameter("manvdieuduongtiepdon", data.MaNVDieuDuongTiepDon));
                Command.Parameters.Add(new MDB.MDBParameter("nguoisua", data.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("ngaysua", data.NgaySua));
                if (data.id.Equals(Decimal.Zero))
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", data.id));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", data.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", data.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (data.id.Equals(Decimal.Zero))
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    data.id = nextval;
                }
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool delete(MDB.MDBConnection MyConnection, decimal ID)
        {
            try
            {
                int n = 0;
                string sql = "DELETE FROM HSCS_TTBenhNhan WHERE ID = :ID";
                MDB.MDBCommand command;
                using (command = new MDB.MDBCommand(sql, MyConnection)) {
                    command.Parameters.Add(new MDB.MDBParameter("ID", ID));
                    command.BindByName = true;
                    n = command.ExecuteNonQuery();
                }
                if (n > 0) {
                    sql = "DELETE FROM hscs_ttbenhnhanravien WHERE id_hscs_ttbenhnhan = :ID";
                    using (command = new MDB.MDBCommand(sql, MyConnection))
                    {
                        command.Parameters.Add(new MDB.MDBParameter("ID", ID));
                        command.BindByName = true;
                        n = command.ExecuteNonQuery();
                    }
                    sql = "DELETE FROM hscs_ttbenhnhanvaovien WHERE id_hscs_ttbenhnhan = :ID";
                    using (command = new MDB.MDBCommand(sql, MyConnection))
                    {
                        command.Parameters.Add(new MDB.MDBParameter("ID", ID));
                        command.BindByName = true;
                        n = command.ExecuteNonQuery();
                    }
                }
                    
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static DataSet getDataSet(MDB.MDBConnection MyConnection, decimal ID)
        {
            string sql = @"SELECT
                P.*,
                V.*,
                R.*
            FROM
                HSCS_TTBenhNhan P 
                LEFT JOIN HSCS_TTBenhNhanVaoVien V on P.ID = V.Id_hscs_ttbenhnhan 
                LEFT JOIN hscs_ttbenhnhanravien R  on P.ID = R.Id_hscs_ttbenhnhan  
            WHERE
                P.ID = " + ID ;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "PT");

            DataTable thongTinVien = new DataTable("HEADER");

            thongTinVien.Columns.Add("BENHVIEN");
            thongTinVien.Columns.Add("KHOA");
            thongTinVien.Columns.Add("MABENHAN");

			if (XemBenhAn._HanhChinhBenhNhan == null) XemBenhAn._HanhChinhBenhNhan = new HanhChinhBenhNhan();
            if (XemBenhAn._ThongTinDieuTri == null) XemBenhAn._ThongTinDieuTri = new ThongTinDieuTri();
            thongTinVien.Rows.Add(XemBenhAn._HanhChinhBenhNhan.BenhVien, XemBenhAn._ThongTinDieuTri.Khoa, XemBenhAn._ThongTinDieuTri.MaBenhAn);
            ds.Tables.Add(thongTinVien);

            return ds;
        }
        
        public static DateTime ConDB_DateTime(object dbVal)
        {
            DateTime ret = DateTime.MinValue;
            if (dbVal == null)
            {
                return ret;
            }
            bool isSuccess = DateTime.TryParse(dbVal.ToString(), out ret);
            return ret;
        }
    }
}
