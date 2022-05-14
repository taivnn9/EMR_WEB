using EMR.KyDienTu;
using MDB;
using System;
using System.Collections.Generic;
using System.Data;
using PMS.Access;
namespace EMR_MAIN.DATABASE.Other
{
    public class BangTomTatHoSoBenhAn : ThongTinKy
    {
        public BangTomTatHoSoBenhAn()
        {
            TableName = "BangTomTatHoSoBenhAn";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BTTHSBA;
            TenMauPhieu = DanhMucPhieu.BTTHSBA.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1,1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Năm sinh")]
		public string NamSinh { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Dân tộc")]
		public string DanToc { get; set; }
        [MoTaDuLieu("Số thẻ BHYT")]
        public string SoTheBHYT { get; set; }
        [MoTaDuLieu("Nghề nghiệp")]
		public string NgheNghiep { get; set; }
        [MoTaDuLieu("Cơ quan/đơn vị công tác")]
        public string DonVi { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        [MoTaDuLieu("Thời gian vào viện")]
        public DateTime ThoiGianVaoVien { get; set; }
        [MoTaDuLieu("Thời gian ra viện")]
        public DateTime ThoiGianRaVien { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh lúc vào viện")]
		public string ChanDoanLucVao { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh lúc ra viện")]
		public string ChanDoanLucRa { get; set; }
        [MoTaDuLieu("Tóm tắt bệnh án lâm sàng")]
        public string TTBenhAn_LamSang { get; set; }
        [MoTaDuLieu("Tóm tắt bệnh án: kết quả xét nghiệm cận lâm sàng có giá trị chẩn đoán")]
        public string TTBenhAn_GiaTriChanDoan { get; set; }
        [MoTaDuLieu("Tóm tắt bệnh án: phương pháp điều trị")]
        public string TTBenhAn_PPDieuTri { get; set; }
        [MoTaDuLieu("Tóm tắt bệnh án: tình trạng người bệnh ra viện")]
        public string TTBenhAn_RaVien { get; set; }
        [MoTaDuLieu("Tóm tắt bệnh án: ghi chú")]
        public string TTBenhAn_GhiChu { get; set; }
        [MoTaDuLieu("Bác sỹ điều trị")]
		public string BacSyDieuTri { get; set; }
        [MoTaDuLieu("Mã bác sỹ điều trị")]
        public string MaNVBacSyDieuTri { get; set; }
        [MoTaDuLieu("Trưởng khoa")]
		public string TruongKhoa { get; set; }
        [MoTaDuLieu("Mã trưởng khoa")]
		public string MaNVTruongKhoa { get; set; }
        [MoTaDuLieu("Tên lãnh đạo bệnh viện")]
		public string LanhDaoBenhVien { get; set; }
		public string MaNVLanhDaoBenhVien { get; set; }
        [MoTaDuLieu("Ngày tạo phiếu")]
        public DateTime NgayTaoPhieu { get; set; }
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
        [MoTaDuLieu("Thiết lập ký")]
        public bool ThietLapKy { get; set; }

    }
    public class BangTomTatHoSoBenhAnFunc
    {
        public const string TableName = "BangTomTatHoSoBenhAn";
        public const string TablePrimaryKeyName = "ID";
        public static List<BangTomTatHoSoBenhAn> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BangTomTatHoSoBenhAn> list = new List<BangTomTatHoSoBenhAn>();
            try
            {

                string sql = @"SELECT * FROM BangTomTatHoSoBenhAn where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    try
                    {
                        BangTomTatHoSoBenhAn data = new BangTomTatHoSoBenhAn();
                        data.ID = DataReader.GetLong("id");
                        data.MaQuanLy = DataReader.GetDecimal("maquanly");
                        data.MaBenhNhan = DataReader.GetString("mabenhnhan");
                        data.TenBenhNhan = DataReader.GetString("tenbenhnhan");
                        data.NamSinh = DataReader.GetString("tuoi");
                        data.GioiTinh = DataReader.GetString("gioitinh");
                        data.DanToc = DataReader.GetString("dantoc");
                        data.SoTheBHYT = DataReader.GetString("thebh");
                        data.NgheNghiep = DataReader.GetString("nghenghiep");
                        data.DonVi = DataReader.GetString("coquancongtac");
                        data.DiaChi = DataReader.GetString("diachi");
                        data.ThoiGianVaoVien = ConDB_DateTime(DataReader["thoigianvaovien"]);
                        data.ThoiGianRaVien = ConDB_DateTime(DataReader["thoigianravien"]);
                        data.ChanDoanLucVao = DataReader.GetString("chandoanlucvao");
                        data.ChanDoanLucRa = DataReader.GetString("chandoanlucra");
                        data.TTBenhAn_LamSang = DataReader.GetString("ttbenhan_lamsang");
                        data.TTBenhAn_GiaTriChanDoan = DataReader.GetString("ttbenhan_giatrichandoan");
                        data.TTBenhAn_PPDieuTri = DataReader.GetString("ttbenhan_ppdieutri");
                        data.TTBenhAn_RaVien = DataReader.GetString("ttbenhan_ravien");
                        data.TTBenhAn_GhiChu = DataReader.GetString("ttbenhan_ghichu");
                        data.BacSyDieuTri = DataReader.GetString("bacsydieutri");
                        data.MaNVBacSyDieuTri = DataReader.GetString("manvbacsydieutri");
                        data.TruongKhoa = DataReader.GetString("truongkhoa");
                        data.MaNVTruongKhoa = DataReader.GetString("manvtruongkhoa");
                        data.LanhDaoBenhVien = DataReader.GetString("lanhdaobenhvien");
                        data.MaNVLanhDaoBenhVien = DataReader.GetString("manvlanhdaobenhvien");
                        data.NgayTaoPhieu = ConDB_DateTime(DataReader["ngaytaophieu"]);
                        data.NguoiTao = DataReader.GetString("NguoiTao");
                        data.NguoiSua = DataReader.GetString("NguoiSua");
                        data.NgayTao = ConDB_DateTime(DataReader["NgayTao"]);
                        data.NgaySua = ConDB_DateTime(DataReader["NgaySua"]);
                        data.MaSoKy = DataReader.GetString("masokyten");
                        data.NgayKy = DataReader.GetDate("ngayky");
                        data.TenFileKy = DataReader.GetString("tenfileky");
                        data.UserNameKy = DataReader.GetString("usernameky");
                        data.ComputerKyTen = DataReader.GetString("COMPUTERKYTEN");
                        data.ThietLapKy = DataReader["ThietLapKy"].ToString().Equals("1") ? true : false;
                        list.Add(data);
                    }
                    catch (Exception ex)
                    {
                        MDB.ExceptionExtend.LogError(ex);
                    }
                }
                DataReader.Close();
                DataReader = null;
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BangTomTatHoSoBenhAn objData)
        {
            string sql;
            int n = 0;
            if (objData.ID == 0)
            {
                sql = @"INSERT INTO BangTomTatHoSoBenhAn (
                                    maquanly,
                                    mabenhnhan,
                                    tenbenhnhan,
                                    tuoi,
                                    gioitinh,
                                    dantoc,
                                    thebh,
                                    nghenghiep,
                                    coquancongtac,
                                    diachi,
                                    thoigianvaovien,
                                    thoigianravien,
                                    chandoanlucvao,
                                    chandoanlucra,
                                    ttbenhan_lamsang,
                                    ttbenhan_giatrichandoan,
                                    ttbenhan_ppdieutri,
                                    ttbenhan_ravien,
                                    ttbenhan_ghichu,
                                    ThietLapKy,
                                    bacsydieutri,
                                    manvbacsydieutri,
                                    truongkhoa,
                                    manvtruongkhoa,
                                    lanhdaobenhvien,
                                    manvlanhdaobenhvien,
                                    ngaytaophieu,
                                    nguoitao,
                                    ngaytao
                                ) VALUES (
                                    :maquanly,
                                    :mabenhnhan,
                                    :tenbenhnhan,
                                    :tuoi,
                                    :gioitinh,
                                    :dantoc,
                                    :thebh,
                                    :nghenghiep,
                                    :coquancongtac,
                                    :diachi,
                                    :thoigianvaovien,
                                    :thoigianravien,
                                    :chandoanlucvao,
                                    :chandoanlucra,
                                    :ttbenhan_lamsang,
                                    :ttbenhan_giatrichandoan,
                                    :ttbenhan_ppdieutri,
                                    :ttbenhan_ravien,
                                    :ttbenhan_ghichu,
                                    :ThietLapKy,
                                    :bacsydieutri,
                                    :manvbacsydieutri,
                                    :truongkhoa,
                                    :manvtruongkhoa,
                                    :lanhdaobenhvien,
                                    :manvlanhdaobenhvien,
                                    :ngaytaophieu,
                                    :nguoitao,
                                    :ngaytao
                                ) RETURNING ID INTO :ID";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("maquanly", objData.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("mabenhnhan", objData.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("tenbenhnhan", objData.TenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("tuoi", objData.NamSinh));
                Command.Parameters.Add(new MDB.MDBParameter("gioitinh", objData.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("dantoc", objData.DanToc));
                Command.Parameters.Add(new MDB.MDBParameter("thebh", objData.SoTheBHYT));
                Command.Parameters.Add(new MDB.MDBParameter("nghenghiep", objData.NgheNghiep));
                Command.Parameters.Add(new MDB.MDBParameter("coquancongtac", objData.DonVi));
                Command.Parameters.Add(new MDB.MDBParameter("diachi", objData.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("thoigianvaovien", objData.ThoiGianVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("thoigianravien", objData.ThoiGianRaVien));
                Command.Parameters.Add(new MDB.MDBParameter("chandoanlucvao", objData.ChanDoanLucVao));
                Command.Parameters.Add(new MDB.MDBParameter("chandoanlucra", objData.ChanDoanLucRa));
                Command.Parameters.Add(new MDB.MDBParameter("ttbenhan_lamsang", objData.TTBenhAn_LamSang));
                Command.Parameters.Add(new MDB.MDBParameter("ttbenhan_giatrichandoan", objData.TTBenhAn_GiaTriChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("ttbenhan_ppdieutri", objData.TTBenhAn_PPDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("ttbenhan_ravien", objData.TTBenhAn_RaVien));
                Command.Parameters.Add(new MDB.MDBParameter("ttbenhan_ghichu", objData.TTBenhAn_GhiChu));
                Command.Parameters.Add(new MDB.MDBParameter("ThietLapKy", objData.ThietLapKy ? 1:0));
                Command.Parameters.Add(new MDB.MDBParameter("bacsydieutri", objData.BacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("manvbacsydieutri", objData.MaNVBacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("truongkhoa", objData.TruongKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("manvtruongkhoa", objData.MaNVTruongKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("lanhdaobenhvien", objData.LanhDaoBenhVien));
                Command.Parameters.Add(new MDB.MDBParameter("manvlanhdaobenhvien", objData.MaNVLanhDaoBenhVien));
                Command.Parameters.Add(new MDB.MDBParameter("ngaytaophieu", objData.NgayTaoPhieu));
                Command.Parameters.Add(new MDB.MDBParameter("ID", objData.ID));
                Command.Parameters.Add(new MDB.MDBParameter("nguoitao", objData.NguoiTao));
                Command.Parameters.Add(new MDB.MDBParameter("ngaytao", objData.NgayTao));
                Command.BindByName = true;
                n = Command.ExecuteNonQuery();

                if (n > 0)
                {
                    if (objData.ID == 0)
                    {
                        long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                        objData.ID = nextval;
                    }
                }
            }

            else
            {
                sql = @"UPDATE BangTomTatHoSoBenhAn SET  
                                            maquanly=:maquanly,
                                            mabenhnhan=:mabenhnhan,
                                            tenbenhnhan=:tenbenhnhan,
                                            tuoi=:tuoi,
                                            gioitinh=:gioitinh,
                                            dantoc=:dantoc,
                                            thebh=:thebh,
                                            nghenghiep=:nghenghiep,
                                            coquancongtac=:coquancongtac,
                                            diachi=:diachi,
                                            thoigianvaovien=:thoigianvaovien,
                                            thoigianravien=:thoigianravien,
                                            chandoanlucvao=:chandoanlucvao,
                                            chandoanlucra=:chandoanlucra,
                                            ttbenhan_lamsang=:ttbenhan_lamsang,
                                            ttbenhan_giatrichandoan=:ttbenhan_giatrichandoan,
                                            ttbenhan_ppdieutri=:ttbenhan_ppdieutri,
                                            ttbenhan_ravien=:ttbenhan_ravien,
                                            ttbenhan_ghichu=:ttbenhan_ghichu,
                                            ThietLapKy = :ThietLapKy,
                                            bacsydieutri=:bacsydieutri,
                                            manvbacsydieutri=:manvbacsydieutri,
                                            truongkhoa=:truongkhoa,
                                            manvtruongkhoa=:manvtruongkhoa,
                                            lanhdaobenhvien=:lanhdaobenhvien,
                                            manvlanhdaobenhvien=:manvlanhdaobenhvien,
                                            ngaytaophieu=:ngaytaophieu,
                                            nguoisua = :nguoisua,
                                            ngaysua = :ngaysua 
                                        WHERE ID = :IDPhieu";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("maquanly", objData.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("mabenhnhan", objData.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("tenbenhnhan", objData.TenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("tuoi", objData.NamSinh));
                Command.Parameters.Add(new MDB.MDBParameter("gioitinh", objData.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("dantoc", objData.DanToc));
                Command.Parameters.Add(new MDB.MDBParameter("thebh", objData.SoTheBHYT));
                Command.Parameters.Add(new MDB.MDBParameter("nghenghiep", objData.NgheNghiep));
                Command.Parameters.Add(new MDB.MDBParameter("coquancongtac", objData.DonVi));
                Command.Parameters.Add(new MDB.MDBParameter("diachi", objData.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("thoigianvaovien", objData.ThoiGianVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("thoigianravien", objData.ThoiGianRaVien));
                Command.Parameters.Add(new MDB.MDBParameter("chandoanlucvao", objData.ChanDoanLucVao));
                Command.Parameters.Add(new MDB.MDBParameter("chandoanlucra", objData.ChanDoanLucRa));
                Command.Parameters.Add(new MDB.MDBParameter("ttbenhan_lamsang", objData.TTBenhAn_LamSang));
                Command.Parameters.Add(new MDB.MDBParameter("ttbenhan_giatrichandoan", objData.TTBenhAn_GiaTriChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("ttbenhan_ppdieutri", objData.TTBenhAn_PPDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("ttbenhan_ravien", objData.TTBenhAn_RaVien));
                Command.Parameters.Add(new MDB.MDBParameter("ttbenhan_ghichu", objData.TTBenhAn_GhiChu));
                Command.Parameters.Add(new MDB.MDBParameter("ThietLapKy", objData.ThietLapKy ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("bacsydieutri", objData.BacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("manvbacsydieutri", objData.MaNVBacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("truongkhoa", objData.TruongKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("manvtruongkhoa", objData.MaNVTruongKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("lanhdaobenhvien", objData.LanhDaoBenhVien));
                Command.Parameters.Add(new MDB.MDBParameter("manvlanhdaobenhvien", objData.MaNVLanhDaoBenhVien));
                Command.Parameters.Add(new MDB.MDBParameter("ngaytaophieu", objData.NgayTaoPhieu));
                Command.Parameters.Add(new MDB.MDBParameter("nguoisua", objData.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("ngaysua", objData.NgaySua));
                Command.Parameters.Add(new MDB.MDBParameter("IDPhieu", objData.ID));
                Command.BindByName = true;
                n = Command.ExecuteNonQuery();

            }


            return n > 0 ? true : false;
        }

        public static bool Delete(MDB.MDBConnection MyConnection, decimal idPhieu)
        {
            string sql = "DELETE FROM BangTomTatHoSoBenhAn WHERE ID = :idPhieu";
            MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
            command.Parameters.Add(new MDB.MDBParameter("idPhieu", idPhieu));
            command.BindByName = true;
            int n = command.ExecuteNonQuery();
            return n > 0 ? true : false;
        }
        public static BangTomTatHoSoBenhAn GetData(MDB.MDBConnection _OracleConnection, decimal id)
        {
            try
            {
                string sql = @"SELECT * FROM BangTomTatHoSoBenhAn where ID = :ID";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID", id));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    try
                    {
                        BangTomTatHoSoBenhAn data = new BangTomTatHoSoBenhAn();
                        data.ID = DataReader.GetLong("ID");
                        data.MaQuanLy = DataReader.GetDecimal("maquanly");
                        data.MaBenhNhan = DataReader.GetString("mabenhnhan");
                        data.TenBenhNhan = DataReader.GetString("tenbenhnhan");
                        data.NamSinh = DataReader.GetString("tuoi");
                        data.GioiTinh = DataReader.GetString("gioitinh");
                        data.DanToc = DataReader.GetString("dantoc");
                        data.SoTheBHYT = DataReader.GetString("thebh");
                        data.NgheNghiep = DataReader.GetString("nghenghiep");
                        data.DonVi = DataReader.GetString("coquancongtac");
                        data.DiaChi = DataReader.GetString("diachi");
                        data.ThoiGianVaoVien = ConDB_DateTime(DataReader["thoigianvaovien"]);
                        data.ThoiGianRaVien = ConDB_DateTime(DataReader["thoigianravien"]);
                        data.ChanDoanLucVao = DataReader.GetString("chandoanlucvao");
                        data.ChanDoanLucRa = DataReader.GetString("chandoanlucra");
                        data.TTBenhAn_LamSang = DataReader.GetString("ttbenhan_lamsang");
                        data.TTBenhAn_GiaTriChanDoan = DataReader.GetString("ttbenhan_giatrichandoan");
                        data.TTBenhAn_PPDieuTri = DataReader.GetString("ttbenhan_ppdieutri");
                        data.TTBenhAn_RaVien = DataReader.GetString("ttbenhan_ravien");
                        data.TTBenhAn_GhiChu = DataReader.GetString("ttbenhan_ghichu");
                        data.BacSyDieuTri = DataReader.GetString("bacsydieutri");
                        data.MaNVBacSyDieuTri = DataReader.GetString("manvbacsydieutri");
                        data.TruongKhoa = DataReader.GetString("truongkhoa");
                        data.MaNVTruongKhoa = DataReader.GetString("manvtruongkhoa");
                        data.LanhDaoBenhVien = DataReader.GetString("lanhdaobenhvien");
                        data.MaNVLanhDaoBenhVien = DataReader.GetString("manvlanhdaobenhvien");
                        data.NgayTaoPhieu = ConDB_DateTime(DataReader["ngaytaophieu"]);
                        data.NguoiTao = DataReader.GetString("NguoiTao");
                        data.NguoiSua = DataReader.GetString("NguoiSua");
                        data.NgayTao = ConDB_DateTime(DataReader["NgayTao"]);
                        data.NgaySua = ConDB_DateTime(DataReader["NgaySua"]);
                        data.MaSoKy = DataReader.GetString("masokyten");
                        data.NgayKy = DataReader.GetDate("ngayky");
                        data.TenFileKy = DataReader.GetString("tenfileky");
                        data.UserNameKy = DataReader.GetString("usernameky");
                        data.ComputerKyTen = DataReader.GetString("COMPUTERKYTEN");

                        return data;
                    }
                    catch (Exception ex)
                    {
                        MDB.ExceptionExtend.LogError(ex);
                    }
                }
                DataReader.Close();
                DataReader = null;
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return null;
        }
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, decimal idPhieu)
        {
            string sql2 = @"SELECT
                D.*,
	            T.MABENHNHAN,
	            T.KHOA,
	            T.GIUONG,
                T.BUONG,
	            T.NGAYVAOVIEN,
	            H.SOYTE,
	            H.BENHVIEN,
	            H.MABENHNHAN,
	            H.TENBENHNHAN,
	            H.TUOI,
	            H.GIOITINH
            FROM
                BangTomTatHoSoBenhAn D
                LEFT JOIN THONGTINDIEUTRI T ON D.MAQUANLY = T.MAQUANLY
                LEFT JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
            WHERE
                ID = :ID";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql2, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("ID", idPhieu));

            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            adt.Fill(ds, "BK");
            return ds;
        }
    }
}
