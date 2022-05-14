
using EMR.KyDienTu;
using System;
using System.Collections.Generic;
using System.Data;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuDanhGiaDinhDuongChung : ThongTinKy
    {
        public PhieuDanhGiaDinhDuongChung()
        {
            TableName = "phieudanhgiadinhduongchung";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.DGDDC;
            TenMauPhieu = DanhMucPhieu.DGDDC.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        public string KhoaPhong { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        public DateTime? NgaySua { get; set; }
        public string TenBenhVien { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Năm sinh")]
		public string NamSinh { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        public double CanNang { get; set; }
        [MoTaDuLieu("Chiều cao")]
		public string ChieuCao { get; set; }
        public double BMI { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public bool GiamCan_Co { get; set; }
        public bool GiamCan_Khong { get; set; }
        public bool GiamCan_1Diem { get; set; }
        public bool GiamCan_2Diem { get; set; }
        public bool KemAn_Co { get; set; }
        public bool KemAn_Khong { get; set; }
        public bool PhanLoai_Co { get; set; }
        public bool PhanLoai_Khong { get; set; }
        public bool SutCan_Co { get; set; }
        public bool SutCan_Khong { get; set; }
        public double SutCan_Kg { get; set; }
        public double SutCan_Thang { get; set; }
        public double SutCan_PhanTram { get; set; }
        public bool AnUong_BinhThuong { get; set; }
        public bool AnUong_GiamSut { get; set; }
        public bool AnUong_GiamSut_Tren50 { get; set; }
        public bool AnUong_GiamSut_Duoi50 { get; set; }
        public bool TeoMo { get; set; }
        public bool TeoCo { get; set; }
        public bool PhuChi { get; set; }
        public bool BangBung { get; set; }
        public bool SGA_Loai1 { get; set; }
        public bool SGA_Loai2 { get; set; }
        public bool SGA_Loai3 { get; set; }
        public bool NhuCau_Loai1 { get; set; }
        public bool NhuCau_Loai2 { get; set; }
        public bool NhuCau_Loai3 { get; set; }
        public bool NhuCau_Loai4 { get; set; }
        public bool NhuCau_Loai5 { get; set; }
        public bool NhuCau_Loai6 { get; set; }
        public bool NhuCau_Loai7 { get; set; }
        public double NhuCau_Calo { get; set; }
        public double NhuCau_Dam { get; set; }
        public double NhuCau_Duong { get; set; }
        public double NhuCau_Beo { get; set; }
        public bool KeHoach_Loai1 { get; set; }
        public string MaCheDoAn { get; set; }
        public bool KeHoach_Loai2 { get; set; }
        public bool KeHoach_Loai3 { get; set; }
        public bool KeHoach_Loai4 { get; set; }
        [MoTaDuLieu("Bác sỹ điều trị")]
		public string BacSiDieuTri { get; set; }
        public int TrangThai { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        //tunght Add
        public double? CanNangTruoc { get; set; }
        public string TuanThang { get; set; }
        public double? PhanTramSutCan { get; set; }
        public double? VongCanhTayTrai { get; set; }
        public bool TamSoat1 { get; set; }
        public bool TamSoat2 { get; set; }
        public bool TamSoat3 { get; set; }
        public bool TamSoat4 { get; set; }
        public int TamSoat_Co_khong { get; set; }
        public int intSutCan_Co { get; set; }
        public int intAnUong_BinhThuong { get; set; }
        public int intTeoMo { get; set; }
        public int intTeoCo { get; set; }
        public int intPhuChi { get; set; }
        public int intBangBung { get; set; }
        public int DdSGA { get; set; }
        public int Albumin { get; set; }
        public int intSGA_Loai1 { get; set; }
        public int intNhuCau_Loai1 { get; set; }
        public int MoiHoiChuan { get; set; }
        public int XetNghiem_Loai1 { get; set; }
        public int XetNghiem_Loai2 { get; set; }
        public double? DGBSCanNang { get; set; }

        public double? BSDGBMI { get; set; }
        public double? BSDGProMau { get; set; }
        public double? BSDGAlbuminMau { get; set; }
        public int BSDGSGA { get; set; }
    }
    public class PhieuDanhGiaDinhDuongChungFunc
    {
        public static bool InsertOrUpdate2(PhieuDanhGiaDinhDuongChung phieuDanhGiaDinhDuongChung, MDB.MDBConnection conn, ref Boolean isUpdate)
        {
            try
            {
                string sql = "SELECT ID FROM PHIEUDANHGIADINHDUONGCHUNG WHERE ID = :ID AND TRANGTHAI = 0";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, conn);
                command.Parameters.Add(new MDB.MDBParameter("ID", phieuDanhGiaDinhDuongChung.ID));
                MDB.MDBDataReader dataReader = command.ExecuteReader();
                int count = 0;
                while (dataReader.Read()) count++;
                if (count > 0)
                {
                    sql = "UPDATE PHIEUDANHGIADINHDUONGCHUNG SET MAQUANLY = :MAQUANLY, NGUOITAO = :NGUOITAO, NGUOISUA = :NGUOISUA, KHOAPHONG = :KHOAPHONG, NGAYTAO = :NGAYTAO, NGAYSUA = :NGAYSUA, TENBENHVIEN = :TENBENHVIEN, TENBENHNHAN = :TENBENHNHAN, NAMSINH = :NAMSINH, GioiTinh =:GioiTinh,CANNANG = :CANNANG, CHIEUCAO = :CHIEUCAO, BMI = :BMI, CHANDOAN = :CHANDOAN, CanNangTruoc= :CanNangTruoc,TuanThang= :TuanThang,PhanTramSutCan= :PhanTramSutCan,VongCanhTayTrai= :VongCanhTayTrai,TamSoat1= :TamSoat1,TamSoat2= :TamSoat2,TamSoat3= :TamSoat3,TamSoat4= :TamSoat4,TamSoat_Co_khong= :TamSoat_Co_khong,SutCan_Co= :SutCan_Co,AnUong_BinhThuong= :AnUong_BinhThuong,TeoCo= :TeoCo,PhuChi= :PhuChi,BangBung= :BangBung,DdSGA= :DdSGA,Albumin =:Albumin, SGA_Loai1= :SGA_Loai1,NhuCau_Calo= :NhuCau_Calo,NhuCau_Dam= :NhuCau_Dam,NhuCau_Beo= :NhuCau_Beo,NhuCau_Duong= :NhuCau_Duong,KeHoach_Loai1= :KeHoach_Loai1,KeHoach_Loai2= :KeHoach_Loai2,KeHoach_Loai4= :KeHoach_Loai4,MoiHoiChuan= :MoiHoiChuan,DGBSCanNang= :DGBSCanNang,BSDGBMI= :BSDGBMI,BSDGProMau= :BSDGProMau,BSDGAlbuminMau= :BSDGAlbuminMau,BSDGSGA= :BSDGSGA,NhuCau_Loai1= :NhuCau_Loai1, BACSIDIEUTRI = :BACSIDIEUTRI WHERE ID = :ID AND TRANGTHAI = 0";
                    isUpdate = true;
                }
                else
                    sql = "INSERT INTO PHIEUDANHGIADINHDUONGCHUNG (MAQUANLY, NGUOITAO, NGUOISUA, KHOAPHONG, NGAYTAO, NGAYSUA, TENBENHVIEN, TENBENHNHAN, NAMSINH,GioiTinh, CANNANG, CHIEUCAO, BMI, CHANDOAN, CanNangTruoc,TuanThang,PhanTramSutCan,VongCanhTayTrai,TamSoat1,TamSoat2,TamSoat3,TamSoat4,TamSoat_Co_khong,SutCan_Co,AnUong_BinhThuong,TeoCo,PhuChi,BangBung,DdSGA,Albumin,SGA_Loai1,NhuCau_Calo,NhuCau_Dam,NhuCau_Beo,NhuCau_Duong,KeHoach_Loai1,KeHoach_Loai2,KeHoach_Loai4,MoiHoiChuan,DGBSCanNang,BSDGBMI,BSDGProMau,BSDGAlbuminMau,BSDGSGA,NhuCau_Loai1, BACSIDIEUTRI) " +
                       " VALUES (:MAQUANLY, :NGUOITAO, :NGUOISUA, :KHOAPHONG, :NGAYTAO, :NGAYSUA, :TENBENHVIEN, :TENBENHNHAN, :NAMSINH, :GioiTinh,:CANNANG, :CHIEUCAO, :BMI, :CHANDOAN, :CanNangTruoc, :TuanThang, :PhanTramSutCan, :VongCanhTayTrai, :TamSoat1, :TamSoat2, :TamSoat3, :TamSoat4, :TamSoat_Co_khong, :SutCan_Co, :AnUong_BinhThuong, :TeoCo, :PhuChi, :BangBung, :DdSGA, :Albumin, :SGA_Loai1, :NhuCau_Calo, :NhuCau_Dam, :NhuCau_Beo, :NhuCau_Duong, :KeHoach_Loai1, :KeHoach_Loai2, :KeHoach_Loai4, :MoiHoiChuan, :DGBSCanNang, :BSDGBMI, :BSDGProMau, :BSDGAlbuminMau, :BSDGSGA, :NhuCau_Loai1, :BACSIDIEUTRI) RETURNING ID INTO :ID";
                command = new MDB.MDBCommand(sql, conn);
                command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", phieuDanhGiaDinhDuongChung.MaQuanLy));
                command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", phieuDanhGiaDinhDuongChung.NguoiTao));
                if (count > 0)
                    command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", XemBenhAn.UserCodeLogin));
                command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", phieuDanhGiaDinhDuongChung.NguoiSua));
                command.Parameters.Add(new MDB.MDBParameter("KHOAPHONG", phieuDanhGiaDinhDuongChung.KhoaPhong));
                command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", phieuDanhGiaDinhDuongChung.NgayTao));
                //if (count > 0)
                command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", DateTime.UtcNow));
                //command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", phieuDanhGiaDinhDuongChung.NgaySua));
                command.Parameters.Add(new MDB.MDBParameter("TENBENHVIEN", phieuDanhGiaDinhDuongChung.TenBenhVien));
                command.Parameters.Add(new MDB.MDBParameter("TENBENHNHAN", phieuDanhGiaDinhDuongChung.TenBenhNhan));
                command.Parameters.Add(new MDB.MDBParameter("NAMSINH", phieuDanhGiaDinhDuongChung.NamSinh));
                command.Parameters.Add(new MDB.MDBParameter("GioiTinh", phieuDanhGiaDinhDuongChung.GioiTinh));
                command.Parameters.Add(new MDB.MDBParameter("CANNANG", phieuDanhGiaDinhDuongChung.CanNang));
                command.Parameters.Add(new MDB.MDBParameter("CHIEUCAO", phieuDanhGiaDinhDuongChung.ChieuCao));
                command.Parameters.Add(new MDB.MDBParameter("BMI", phieuDanhGiaDinhDuongChung.BMI));
                command.Parameters.Add(new MDB.MDBParameter("CHANDOAN", phieuDanhGiaDinhDuongChung.ChanDoan));
                command.Parameters.Add(new MDB.MDBParameter("CanNangTruoc", phieuDanhGiaDinhDuongChung.CanNangTruoc));
                command.Parameters.Add(new MDB.MDBParameter("TuanThang", phieuDanhGiaDinhDuongChung.TuanThang));
                command.Parameters.Add(new MDB.MDBParameter("PhanTramSutCan", phieuDanhGiaDinhDuongChung.PhanTramSutCan));
                command.Parameters.Add(new MDB.MDBParameter("VongCanhTayTrai", phieuDanhGiaDinhDuongChung.VongCanhTayTrai));
                command.Parameters.Add(new MDB.MDBParameter("TamSoat1", phieuDanhGiaDinhDuongChung.TamSoat1 == true ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("TamSoat2", phieuDanhGiaDinhDuongChung.TamSoat2 == true ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("TamSoat3", phieuDanhGiaDinhDuongChung.TamSoat3 == true ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("TamSoat4", phieuDanhGiaDinhDuongChung.TamSoat4 == true ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("TamSoat_Co_khong", phieuDanhGiaDinhDuongChung.TamSoat_Co_khong));
                command.Parameters.Add(new MDB.MDBParameter("SutCan_Co", phieuDanhGiaDinhDuongChung.intSutCan_Co));
                command.Parameters.Add(new MDB.MDBParameter("AnUong_BinhThuong", phieuDanhGiaDinhDuongChung.intAnUong_BinhThuong));
                command.Parameters.Add(new MDB.MDBParameter("TeoCo", phieuDanhGiaDinhDuongChung.intTeoCo));
                command.Parameters.Add(new MDB.MDBParameter("PhuChi", phieuDanhGiaDinhDuongChung.intPhuChi));
                command.Parameters.Add(new MDB.MDBParameter("BangBung", phieuDanhGiaDinhDuongChung.intBangBung));
                command.Parameters.Add(new MDB.MDBParameter("DdSGA", phieuDanhGiaDinhDuongChung.DdSGA));
                command.Parameters.Add(new MDB.MDBParameter("Albumin", phieuDanhGiaDinhDuongChung.Albumin));
                command.Parameters.Add(new MDB.MDBParameter("SGA_Loai1", phieuDanhGiaDinhDuongChung.intSGA_Loai1));
                command.Parameters.Add(new MDB.MDBParameter("NhuCau_Calo", phieuDanhGiaDinhDuongChung.NhuCau_Calo));
                command.Parameters.Add(new MDB.MDBParameter("NhuCau_Dam", phieuDanhGiaDinhDuongChung.NhuCau_Dam));
                command.Parameters.Add(new MDB.MDBParameter("NhuCau_Beo", phieuDanhGiaDinhDuongChung.NhuCau_Beo));
                command.Parameters.Add(new MDB.MDBParameter("NhuCau_Duong", phieuDanhGiaDinhDuongChung.NhuCau_Duong));
                command.Parameters.Add(new MDB.MDBParameter("KeHoach_Loai1", phieuDanhGiaDinhDuongChung.KeHoach_Loai1 == true ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("KeHoach_Loai2", phieuDanhGiaDinhDuongChung.KeHoach_Loai2 == true ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("KeHoach_Loai4", phieuDanhGiaDinhDuongChung.KeHoach_Loai4 == true ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("MoiHoiChuan", phieuDanhGiaDinhDuongChung.MoiHoiChuan));
                command.Parameters.Add(new MDB.MDBParameter("DGBSCanNang", phieuDanhGiaDinhDuongChung.DGBSCanNang));
                command.Parameters.Add(new MDB.MDBParameter("BSDGBMI", phieuDanhGiaDinhDuongChung.BSDGBMI));
                command.Parameters.Add(new MDB.MDBParameter("BSDGProMau", phieuDanhGiaDinhDuongChung.BSDGProMau));
                command.Parameters.Add(new MDB.MDBParameter("BSDGAlbuminMau", phieuDanhGiaDinhDuongChung.BSDGAlbuminMau));
                command.Parameters.Add(new MDB.MDBParameter("BSDGSGA", phieuDanhGiaDinhDuongChung.BSDGSGA));
                command.Parameters.Add(new MDB.MDBParameter("NhuCau_Loai1", phieuDanhGiaDinhDuongChung.intNhuCau_Loai1));
                command.Parameters.Add(new MDB.MDBParameter("BACSIDIEUTRI", phieuDanhGiaDinhDuongChung.BacSiDieuTri));
                command.Parameters.Add(new MDB.MDBParameter("ID", phieuDanhGiaDinhDuongChung.ID));
                command.BindByName = true;
                int n = command.ExecuteNonQuery();
                phieuDanhGiaDinhDuongChung.ID = Convert.ToInt64((command.Parameters["ID"] as MDB.MDBParameter).Value);
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
                return false;
            }
        }
        public static List<EMR_MAIN.DATABASE.Other.PhieuDanhGiaDinhDuongChung> GetData2(decimal MaQuanLy, MDB.MDBConnection conn)
        {
            List<EMR_MAIN.DATABASE.Other.PhieuDanhGiaDinhDuongChung> lstObject = new List<PhieuDanhGiaDinhDuongChung>();
            try
            {
                string sql = "SELECT * FROM PHIEUDANHGIADINHDUONGCHUNG WHERE MAQUANLY = :MAQUANLY AND TRANGTHAI = 0 ORDER BY ID DESC";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, conn);
                command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", MaQuanLy));
                MDB.MDBDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    EMR_MAIN.DATABASE.Other.PhieuDanhGiaDinhDuongChung obj = new PhieuDanhGiaDinhDuongChung();
                    obj.ID = Convert.ToInt64(dataReader.GetLong("ID"));
                    obj.MaQuanLy = Convert.ToDecimal(dataReader.GetDecimal("MaQuanLy"));
                    obj.NguoiTao = dataReader["NguoiTao"].ToString();
                    obj.NguoiSua = dataReader["NguoiSua"].ToString();
                    obj.KhoaPhong = dataReader["KhoaPhong"].ToString();
                    if (dataReader["NgayTao"] != null && dataReader["NgayTao"].ToString() != string.Empty)
                        obj.NgayTao = Convert.ToDateTime(dataReader.GetDate("NgayTao"));
                    if (dataReader["NgaySua"] != null && dataReader["NgaySua"].ToString() != string.Empty)
                        obj.NgaySua = Convert.ToDateTime(dataReader.GetDate("NgaySua"));
                    obj.TenBenhVien = dataReader["TenBenhVien"].ToString();
                    obj.TenBenhNhan = dataReader["TenBenhNhan"].ToString();
                    obj.NamSinh = dataReader["NamSinh"].ToString();
                    obj.GioiTinh = dataReader["GioiTinh"].ToString();
                    obj.CanNang = Convert.ToDouble(dataReader.GetDecimal("CanNang"));
                    //obj.ChieuCao = Convert.ToDouble(dataReader.GetDecimal("ChieuCao")).ToString();
                    obj.ChieuCao = dataReader.GetDecimal("ChieuCao").ToString();
                    obj.BMI = Convert.ToDouble(dataReader.GetDecimal("BMI"));
                    obj.ChanDoan = dataReader["ChanDoan"].ToString();
                    obj.CanNangTruoc = Common.ConDB_Int(dataReader["CanNangTruoc"]);
                    obj.TuanThang = Common.ConDBNull(dataReader["TuanThang"]);
                    obj.PhanTramSutCan = Common.ConDBNull_float(dataReader["PhanTramSutCan"]);
                    obj.VongCanhTayTrai = Common.ConDBNull_float(dataReader["VongCanhTayTrai"]);
                    obj.TamSoat1 = Common.ConDBNull(dataReader["TamSoat1"]).Equals("1") ? true : false;
                    obj.TamSoat2 = Common.ConDBNull(dataReader["TamSoat2"]).Equals("1") ? true : false;
                    obj.TamSoat3 = Common.ConDBNull(dataReader["TamSoat3"]).Equals("1") ? true : false;
                    obj.TamSoat4 = Common.ConDBNull(dataReader["TamSoat4"]).Equals("1") ? true : false;
                    obj.TamSoat_Co_khong = Common.ConDB_Int(dataReader["TamSoat_Co_khong"]);
                    obj.intSutCan_Co = Common.ConDB_Int(dataReader["SutCan_Co"]);
                    obj.intAnUong_BinhThuong = Common.ConDB_Int(dataReader["AnUong_BinhThuong"]);
                    obj.intTeoCo = Common.ConDB_Int(dataReader["TeoCo"]);
                    obj.intPhuChi = Common.ConDB_Int(dataReader["PhuChi"]);
                    obj.intBangBung = Common.ConDB_Int(dataReader["BangBung"]);
                    obj.DdSGA = Common.ConDB_Int(dataReader["DdSGA"]);
                    obj.Albumin = Common.ConDB_Int(dataReader["Albumin"]);
                    obj.intSGA_Loai1 = Common.ConDB_Int(dataReader["SGA_Loai1"]);
                    obj.NhuCau_Calo = Common.ConDB_float(dataReader["NhuCau_Calo"]);
                    obj.NhuCau_Dam = Common.ConDB_float(dataReader["NhuCau_Dam"]);
                    obj.NhuCau_Beo = Common.ConDB_float(dataReader["NhuCau_Beo"]);
                    obj.NhuCau_Duong = Common.ConDB_float(dataReader["NhuCau_Duong"]);
                    obj.KeHoach_Loai1 = Common.ConDBNull(dataReader["KeHoach_Loai1"]).Equals("1") ? true : false;
                    obj.KeHoach_Loai2 = Common.ConDBNull(dataReader["KeHoach_Loai2"]).Equals("1") ? true : false;
                    obj.KeHoach_Loai4 = Common.ConDBNull(dataReader["KeHoach_Loai4"]).Equals("1") ? true : false;
                    obj.MoiHoiChuan = Common.ConDB_Int(dataReader["MoiHoiChuan"]);
                    obj.DGBSCanNang = Common.ConDBNull_float(dataReader["DGBSCanNang"]);
                    obj.BSDGBMI = Common.ConDBNull_float(dataReader["BSDGBMI"]);
                    obj.BSDGProMau = Common.ConDBNull_float(dataReader["BSDGProMau"]);
                    obj.BSDGAlbuminMau = Common.ConDBNull_float(dataReader["BSDGAlbuminMau"]);
                    obj.BSDGAlbuminMau = Common.ConDBNull_float(dataReader["BSDGAlbuminMau"]);
                    obj.intNhuCau_Loai1 = Common.ConDB_Int(dataReader["NhuCau_Loai1"]);
                    obj.BacSiDieuTri = dataReader["BacSiDieuTri"].ToString();
                    obj.MaSoKy = dataReader.GetString("masokyten");
                    obj.NgayKy = dataReader.GetDate("ngayky");
                    obj.TenFileKy = dataReader.GetString("tenfileky");
                    obj.UserNameKy = dataReader.GetString("usernameky");
                    obj.Chon = false;
                    lstObject.Add(obj);
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return lstObject;
        }

        public static long InsertOrUpdate(PhieuDanhGiaDinhDuongChung phieuDanhGiaDinhDuongChung, MDB.MDBConnection conn)
        {
            try
            {
                string sql = "SELECT ID FROM PHIEUDANHGIADINHDUONGCHUNG WHERE ID = :ID AND TRANGTHAI = 0";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, conn);
                command.Parameters.Add(new MDB.MDBParameter("ID", phieuDanhGiaDinhDuongChung.ID));
                MDB.MDBDataReader dataReader = command.ExecuteReader();
                int count = 0;
                while (dataReader.Read()) count++;
                if (count > 0)
                    sql = "UPDATE PHIEUDANHGIADINHDUONGCHUNG SET MAQUANLY = :MAQUANLY, NGUOITAO = :NGUOITAO, NGUOISUA = :NGUOISUA, KHOAPHONG = :KHOAPHONG, NGAYTAO = :NGAYTAO, NGAYSUA = :NGAYSUA, TENBENHVIEN = :TENBENHVIEN, TENBENHNHAN = :TENBENHNHAN, NAMSINH = :NAMSINH, CANNANG = :CANNANG, CHIEUCAO = :CHIEUCAO, BMI = :BMI, CHANDOAN = :CHANDOAN, GIAMCAN_CO = :GIAMCAN_CO, GIAMCAN_KHONG = :GIAMCAN_KHONG, GIAMCAN_1DIEM = :GIAMCAN_1DIEM, GIAMCAN_2DIEM = :GIAMCAN_2DIEM, KEMAN_CO = :KEMAN_CO, KEMAN_KHONG = :KEMAN_KHONG, PHANLOAI_CO = :PHANLOAI_CO, PHANLOAI_KHONG = :PHANLOAI_KHONG, SUTCAN_CO = :SUTCAN_CO, SUTCAN_KHONG = :SUTCAN_KHONG, SUTCAN_KG = :SUTCAN_KG, SUTCAN_THANG = :SUTCAN_THANG, SUTCAN_PHANTRAM = :SUTCAN_PHANTRAM, ANUONG_BINHTHUONG = :ANUONG_BINHTHUONG, ANUONG_GIAMSUT = :ANUONG_GIAMSUT, ANUONG_GIAMSUT_TREN50 = :ANUONG_GIAMSUT_TREN50, ANUONG_GIAMSUT_DUOI50 = :ANUONG_GIAMSUT_DUOI50, TEOMO = :TEOMO, TEOCO = :TEOCO, PHUCHI = :PHUCHI, BANGBUNG = :BANGBUNG, SGA_LOAI1 = :SGA_LOAI1, SGA_LOAI2 = :SGA_LOAI2, SGA_LOAI3 = :SGA_LOAI3, NHUCAU_LOAI1 = :NHUCAU_LOAI1, NHUCAU_LOAI2 = :NHUCAU_LOAI2, NHUCAU_LOAI3 = :NHUCAU_LOAI3, NHUCAU_LOAI4 = :NHUCAU_LOAI4, NHUCAU_LOAI5 = :NHUCAU_LOAI5, NHUCAU_LOAI6 = :NHUCAU_LOAI6, NHUCAU_LOAI7 = :NHUCAU_LOAI7, NHUCAU_CALO = :NHUCAU_CALO, NHUCAU_DAM = :NHUCAU_DAM, NHUCAU_DUONG = :NHUCAU_DUONG, NHUCAU_BEO = :NHUCAU_BEO, KEHOACH_LOAI1 = :KEHOACH_LOAI1, MACHEDOAN = :MACHEDOAN, KEHOACH_LOAI2 = :KEHOACH_LOAI2, KEHOACH_LOAI3 = :KEHOACH_LOAI3, KEHOACH_LOAI4 = :KEHOACH_LOAI4, XetNghiem_Loai1 = :XetNghiem_Loai1, XetNghiem_Loai2 = :XetNghiem_Loai2, BACSIDIEUTRI = :BACSIDIEUTRI WHERE ID = :ID AND TRANGTHAI = 0";
                else
                    sql = "INSERT INTO PHIEUDANHGIADINHDUONGCHUNG (MAQUANLY, NGUOITAO, NGUOISUA, KHOAPHONG, NGAYTAO, NGAYSUA, TENBENHVIEN, TENBENHNHAN, NAMSINH, CANNANG, CHIEUCAO, BMI, CHANDOAN, GIAMCAN_CO, GIAMCAN_KHONG, GIAMCAN_1DIEM, GIAMCAN_2DIEM, KEMAN_CO, KEMAN_KHONG, PHANLOAI_CO, PHANLOAI_KHONG, SUTCAN_CO, SUTCAN_KHONG, SUTCAN_KG, SUTCAN_THANG, SUTCAN_PHANTRAM, ANUONG_BINHTHUONG, ANUONG_GIAMSUT, ANUONG_GIAMSUT_TREN50, ANUONG_GIAMSUT_DUOI50, TEOMO, TEOCO, PHUCHI, BANGBUNG, SGA_LOAI1, SGA_LOAI2, SGA_LOAI3, NHUCAU_LOAI1, NHUCAU_LOAI2, NHUCAU_LOAI3, NHUCAU_LOAI4, NHUCAU_LOAI5, NHUCAU_LOAI6, NHUCAU_LOAI7, NHUCAU_CALO, NHUCAU_DAM, NHUCAU_DUONG, NHUCAU_BEO, KEHOACH_LOAI1, MACHEDOAN, KEHOACH_LOAI2, KEHOACH_LOAI3, KEHOACH_LOAI4,XetNghiem_Loai1, XetNghiem_Loai2, BACSIDIEUTRI) VALUES (:MAQUANLY, :NGUOITAO, :NGUOISUA, :KHOAPHONG, :NGAYTAO, :NGAYSUA, :TENBENHVIEN, :TENBENHNHAN, :NAMSINH, :CANNANG, :CHIEUCAO, :BMI, :CHANDOAN, :GIAMCAN_CO, :GIAMCAN_KHONG, :GIAMCAN_1DIEM, :GIAMCAN_2DIEM, :KEMAN_CO, :KEMAN_KHONG, :PHANLOAI_CO, :PHANLOAI_KHONG, :SUTCAN_CO, :SUTCAN_KHONG, :SUTCAN_KG, :SUTCAN_THANG, :SUTCAN_PHANTRAM, :ANUONG_BINHTHUONG, :ANUONG_GIAMSUT, :ANUONG_GIAMSUT_TREN50, :ANUONG_GIAMSUT_DUOI50, :TEOMO, :TEOCO, :PHUCHI, :BANGBUNG, :SGA_LOAI1, :SGA_LOAI2, :SGA_LOAI3, :NHUCAU_LOAI1, :NHUCAU_LOAI2, :NHUCAU_LOAI3, :NHUCAU_LOAI4, :NHUCAU_LOAI5, :NHUCAU_LOAI6, :NHUCAU_LOAI7, :NHUCAU_CALO, :NHUCAU_DAM, :NHUCAU_DUONG, :NHUCAU_BEO, :KEHOACH_LOAI1, :MACHEDOAN, :KEHOACH_LOAI2, :KEHOACH_LOAI3, :KEHOACH_LOAI4, :XetNghiem_Loai1, :XetNghiem_Loai2, :BACSIDIEUTRI) RETURNING ID INTO :ID";
                command = new MDB.MDBCommand(sql, conn);
                command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", phieuDanhGiaDinhDuongChung.MaQuanLy));
                command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", phieuDanhGiaDinhDuongChung.NguoiTao));
                if (count > 0)
                    command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", Common.getUserLogin()));
                command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", phieuDanhGiaDinhDuongChung.NguoiSua));
                command.Parameters.Add(new MDB.MDBParameter("KHOAPHONG", phieuDanhGiaDinhDuongChung.KhoaPhong));
                command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", phieuDanhGiaDinhDuongChung.NgayTao));
                //if (count > 0)
                command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", DateTime.UtcNow));
                command.Parameters.Add(new MDB.MDBParameter("TENBENHVIEN", phieuDanhGiaDinhDuongChung.TenBenhVien));
                command.Parameters.Add(new MDB.MDBParameter("TENBENHNHAN", phieuDanhGiaDinhDuongChung.TenBenhNhan));
                command.Parameters.Add(new MDB.MDBParameter("NAMSINH", phieuDanhGiaDinhDuongChung.NamSinh));
                command.Parameters.Add(new MDB.MDBParameter("CANNANG", phieuDanhGiaDinhDuongChung.CanNang));
                command.Parameters.Add(new MDB.MDBParameter("CHIEUCAO", phieuDanhGiaDinhDuongChung.ChieuCao));
                command.Parameters.Add(new MDB.MDBParameter("BMI", phieuDanhGiaDinhDuongChung.BMI));
                command.Parameters.Add(new MDB.MDBParameter("CHANDOAN", phieuDanhGiaDinhDuongChung.ChanDoan));
                command.Parameters.Add(new MDB.MDBParameter("GIAMCAN_CO", phieuDanhGiaDinhDuongChung.GiamCan_Co == true ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("GIAMCAN_KHONG", phieuDanhGiaDinhDuongChung.GiamCan_Khong == true ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("GIAMCAN_1DIEM", phieuDanhGiaDinhDuongChung.GiamCan_1Diem == true ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("GIAMCAN_2DIEM", phieuDanhGiaDinhDuongChung.GiamCan_2Diem == true ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("KEMAN_CO", phieuDanhGiaDinhDuongChung.KemAn_Co == true ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("KEMAN_KHONG", phieuDanhGiaDinhDuongChung.KemAn_Khong == true ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("PHANLOAI_CO", phieuDanhGiaDinhDuongChung.PhanLoai_Co == true ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("PHANLOAI_KHONG", phieuDanhGiaDinhDuongChung.PhanLoai_Khong == true ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("SUTCAN_CO", phieuDanhGiaDinhDuongChung.SutCan_Co == true ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("SUTCAN_KHONG", phieuDanhGiaDinhDuongChung.SutCan_Khong == true ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("SUTCAN_KG", phieuDanhGiaDinhDuongChung.SutCan_Kg));
                command.Parameters.Add(new MDB.MDBParameter("SUTCAN_THANG", phieuDanhGiaDinhDuongChung.SutCan_Thang));
                command.Parameters.Add(new MDB.MDBParameter("SUTCAN_PHANTRAM", phieuDanhGiaDinhDuongChung.SutCan_PhanTram));
                command.Parameters.Add(new MDB.MDBParameter("ANUONG_BINHTHUONG", phieuDanhGiaDinhDuongChung.AnUong_BinhThuong == true ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("ANUONG_GIAMSUT", phieuDanhGiaDinhDuongChung.AnUong_GiamSut == true ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("ANUONG_GIAMSUT_TREN50", phieuDanhGiaDinhDuongChung.AnUong_GiamSut_Tren50 == true ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("ANUONG_GIAMSUT_DUOI50", phieuDanhGiaDinhDuongChung.AnUong_GiamSut_Duoi50 == true ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("TEOMO", phieuDanhGiaDinhDuongChung.TeoMo == true ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("TEOCO", phieuDanhGiaDinhDuongChung.TeoCo == true ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("PHUCHI", phieuDanhGiaDinhDuongChung.PhuChi == true ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("BANGBUNG", phieuDanhGiaDinhDuongChung.BangBung == true ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("SGA_LOAI1", phieuDanhGiaDinhDuongChung.SGA_Loai1 == true ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("SGA_LOAI2", phieuDanhGiaDinhDuongChung.SGA_Loai2 == true ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("SGA_LOAI3", phieuDanhGiaDinhDuongChung.SGA_Loai3 == true ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("NHUCAU_LOAI1", phieuDanhGiaDinhDuongChung.NhuCau_Loai1 == true ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("NHUCAU_LOAI2", phieuDanhGiaDinhDuongChung.NhuCau_Loai2 == true ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("NHUCAU_LOAI3", phieuDanhGiaDinhDuongChung.NhuCau_Loai3 == true ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("NHUCAU_LOAI4", phieuDanhGiaDinhDuongChung.NhuCau_Loai4 == true ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("NHUCAU_LOAI5", phieuDanhGiaDinhDuongChung.NhuCau_Loai5 == true ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("NHUCAU_LOAI6", phieuDanhGiaDinhDuongChung.NhuCau_Loai6 == true ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("NHUCAU_LOAI7", phieuDanhGiaDinhDuongChung.NhuCau_Loai7 == true ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("NHUCAU_CALO", phieuDanhGiaDinhDuongChung.NhuCau_Calo));
                command.Parameters.Add(new MDB.MDBParameter("NHUCAU_DAM", phieuDanhGiaDinhDuongChung.NhuCau_Dam));
                command.Parameters.Add(new MDB.MDBParameter("NHUCAU_DUONG", phieuDanhGiaDinhDuongChung.NhuCau_Duong));
                command.Parameters.Add(new MDB.MDBParameter("NHUCAU_BEO", phieuDanhGiaDinhDuongChung.NhuCau_Beo));
                command.Parameters.Add(new MDB.MDBParameter("KEHOACH_LOAI1", phieuDanhGiaDinhDuongChung.KeHoach_Loai1 == true ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("MACHEDOAN", phieuDanhGiaDinhDuongChung.MaCheDoAn));
                command.Parameters.Add(new MDB.MDBParameter("KEHOACH_LOAI2", phieuDanhGiaDinhDuongChung.KeHoach_Loai2 == true ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("KEHOACH_LOAI3", phieuDanhGiaDinhDuongChung.KeHoach_Loai3 == true ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("KEHOACH_LOAI4", phieuDanhGiaDinhDuongChung.KeHoach_Loai4 == true ? 1 : 0));
                command.Parameters.Add(new MDB.MDBParameter("XetNghiem_Loai1", phieuDanhGiaDinhDuongChung.XetNghiem_Loai1));
                command.Parameters.Add(new MDB.MDBParameter("XetNghiem_Loai2", phieuDanhGiaDinhDuongChung.XetNghiem_Loai2));
                command.Parameters.Add(new MDB.MDBParameter("BACSIDIEUTRI", phieuDanhGiaDinhDuongChung.BacSiDieuTri));
                command.Parameters.Add(new MDB.MDBParameter("ID", phieuDanhGiaDinhDuongChung.ID));
                command.BindByName = true;
                int n = command.ExecuteNonQuery();
                long nextval = Convert.ToInt64((command.Parameters["ID"] as MDB.MDBParameter).Value);
                return n > 0 ? nextval : 0;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return 0;
        }
        public static List<EMR_MAIN.DATABASE.Other.PhieuDanhGiaDinhDuongChung> GetData(decimal MaQuanLy, MDB.MDBConnection conn)
        {
            List<EMR_MAIN.DATABASE.Other.PhieuDanhGiaDinhDuongChung> lstObject = new List<PhieuDanhGiaDinhDuongChung>();
            try
            {
                string sql = "SELECT * FROM PHIEUDANHGIADINHDUONGCHUNG WHERE MAQUANLY = :MAQUANLY AND TRANGTHAI = 0 ORDER BY ID DESC";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, conn);
                command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", MaQuanLy));
                MDB.MDBDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    EMR_MAIN.DATABASE.Other.PhieuDanhGiaDinhDuongChung obj = new PhieuDanhGiaDinhDuongChung();
                    obj.ID = Convert.ToInt64(dataReader.GetLong("ID"));
                    obj.MaQuanLy = Convert.ToDecimal(dataReader.GetDecimal("MaQuanLy"));
                    obj.NguoiTao = dataReader["NguoiTao"].ToString();
                    obj.NguoiSua = dataReader["NguoiSua"].ToString();
                    obj.KhoaPhong = dataReader["KhoaPhong"].ToString();
                    if (dataReader["NgayTao"] != null && dataReader["NgayTao"].ToString() != string.Empty)
                        obj.NgayTao = Convert.ToDateTime(dataReader.GetDate("NgayTao"));
                    if (dataReader["NgaySua"] != null && dataReader["NgaySua"].ToString() != string.Empty)
                        obj.NgaySua = Convert.ToDateTime(dataReader.GetDate("NgaySua"));
                    obj.TenBenhVien = dataReader["TenBenhVien"].ToString();
                    obj.TenBenhNhan = dataReader["TenBenhNhan"].ToString();
                    obj.NamSinh = dataReader["NamSinh"].ToString();
                    obj.CanNang = Convert.ToDouble(dataReader.GetDecimal("CanNang"));
                    //obj.ChieuCao = Convert.ToDouble(dataReader.GetDecimal("ChieuCao"));
                    obj.ChieuCao = dataReader.GetDecimal("ChieuCao").ToString();
                    obj.BMI = Convert.ToDouble(dataReader.GetDecimal("BMI"));
                    obj.ChanDoan = dataReader["ChanDoan"].ToString();
                    obj.GiamCan_Co = dataReader["GiamCan_Co"].ToString().Equals("1") ? true : false;
                    obj.GiamCan_Khong = dataReader["GiamCan_Khong"].ToString().Equals("1") ? true : false;
                    obj.GiamCan_1Diem = dataReader["GiamCan_1Diem"].ToString().Equals("1") ? true : false;
                    obj.GiamCan_2Diem = dataReader["GiamCan_2Diem"].ToString().Equals("1") ? true : false;
                    obj.KemAn_Co = dataReader["KemAn_Co"].ToString().Equals("1") ? true : false;
                    obj.KemAn_Khong = dataReader["KemAn_Khong"].ToString().Equals("1") ? true : false;
                    obj.PhanLoai_Co = dataReader["PhanLoai_Co"].ToString().Equals("1") ? true : false;
                    obj.PhanLoai_Khong = dataReader["PhanLoai_Khong"].ToString().Equals("1") ? true : false;
                    obj.SutCan_Co = dataReader["SutCan_Co"].ToString().Equals("1") ? true : false;
                    obj.SutCan_Khong = dataReader["SutCan_Khong"].ToString().Equals("1") ? true : false;
                    obj.SutCan_Kg = Convert.ToDouble(dataReader.GetDecimal("SutCan_Kg"));
                    obj.SutCan_Thang = Convert.ToDouble(dataReader.GetDecimal("SutCan_Thang"));
                    obj.SutCan_PhanTram = Convert.ToDouble(dataReader.GetDecimal("SutCan_PhanTram"));
                    obj.AnUong_BinhThuong = dataReader["AnUong_BinhThuong"].ToString().Equals("1") ? true : false;
                    obj.AnUong_GiamSut = dataReader["AnUong_GiamSut"].ToString().Equals("1") ? true : false;
                    obj.AnUong_GiamSut_Tren50 = dataReader["AnUong_GiamSut_Tren50"].ToString().Equals("1") ? true : false;
                    obj.AnUong_GiamSut_Duoi50 = dataReader["AnUong_GiamSut_Duoi50"].ToString().Equals("1") ? true : false;
                    obj.TeoMo = dataReader["TeoMo"].ToString().Equals("1") ? true : false;
                    obj.TeoCo = dataReader["TeoCo"].ToString().Equals("1") ? true : false;
                    obj.PhuChi = dataReader["PhuChi"].ToString().Equals("1") ? true : false;
                    obj.BangBung = dataReader["BangBung"].ToString().Equals("1") ? true : false;
                    obj.SGA_Loai1 = dataReader["SGA_Loai1"].ToString().Equals("1") ? true : false;
                    obj.SGA_Loai2 = dataReader["SGA_Loai2"].ToString().Equals("1") ? true : false;
                    obj.SGA_Loai3 = dataReader["SGA_Loai3"].ToString().Equals("1") ? true : false;
                    obj.NhuCau_Loai1 = dataReader["NhuCau_Loai1"].ToString().Equals("1") ? true : false;
                    obj.NhuCau_Loai2 = dataReader["NhuCau_Loai2"].ToString().Equals("1") ? true : false;
                    obj.NhuCau_Loai3 = dataReader["NhuCau_Loai3"].ToString().Equals("1") ? true : false;
                    obj.NhuCau_Loai4 = dataReader["NhuCau_Loai4"].ToString().Equals("1") ? true : false;
                    obj.NhuCau_Loai5 = dataReader["NhuCau_Loai5"].ToString().Equals("1") ? true : false;
                    obj.NhuCau_Loai6 = dataReader["NhuCau_Loai6"].ToString().Equals("1") ? true : false;
                    obj.NhuCau_Loai7 = dataReader["NhuCau_Loai7"].ToString().Equals("1") ? true : false;
                    obj.NhuCau_Calo = Convert.ToDouble(dataReader.GetDecimal("NhuCau_Calo"));
                    obj.NhuCau_Dam = Convert.ToDouble(dataReader.GetDecimal("NhuCau_Dam"));
                    obj.NhuCau_Duong = Convert.ToDouble(dataReader.GetDecimal("NhuCau_Duong"));
                    obj.NhuCau_Beo = Convert.ToDouble(dataReader.GetDecimal("NhuCau_Beo"));
                    obj.KeHoach_Loai1 = dataReader["KeHoach_Loai1"].ToString().Equals("1") ? true : false;
                    obj.MaCheDoAn = dataReader["MaCheDoAn"].ToString();
                    obj.KeHoach_Loai2 = dataReader["KeHoach_Loai2"].ToString().Equals("1") ? true : false;
                    obj.KeHoach_Loai3 = dataReader["KeHoach_Loai3"].ToString().Equals("1") ? true : false;
                    obj.KeHoach_Loai4 = dataReader["KeHoach_Loai4"].ToString().Equals("1") ? true : false;
                    obj.XetNghiem_Loai1 = Common.ConDB_Int(dataReader["XetNghiem_Loai1"]);
                    obj.XetNghiem_Loai2 = Common.ConDB_Int(dataReader["XetNghiem_Loai2"]);
                    obj.BacSiDieuTri = dataReader["BacSiDieuTri"].ToString();
                    obj.MaSoKy = dataReader.GetString("masokyten");
                    obj.NgayKy = dataReader.GetDate("ngayky");
                    obj.TenFileKy = dataReader.GetString("tenfileky");
                    obj.UserNameKy = dataReader.GetString("usernameky");
                    obj.Chon = false;
                    lstObject.Add(obj);
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return lstObject;
        }
        public static bool DeleteByIDMaPhieu(MDB.MDBConnection oracleConnection, List<decimal> IDBienBan)
        {
            try
            {
                string sql = "";
                string strWhere = "";
                MDB.MDBCommand oracleCommand;
                strWhere = "In(";
                if (IDBienBan.Count > 0)
                {
                    for (int i = 0; i < IDBienBan.Count; i++)
                    {
                        strWhere = strWhere + IDBienBan[i].ToString();
                        if (i == (IDBienBan.Count - 1))
                        {
                            strWhere = strWhere + ")";
                        }
                        else
                        {
                            strWhere = strWhere + ",";
                        }
                    }
                }
                sql = @"UPDATE PHIEUDANHGIADINHDUONGCHUNG SET TRANGTHAI = 1 WHERE ID " + strWhere;
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
        public static bool Delete(long ID, MDB.MDBConnection conn)
        {
            try
            {
                string sql = "UPDATE PHIEUDANHGIADINHDUONGCHUNG SET TRANGTHAI = 1 WHERE ID = :ID";
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
        public static DataSet GetDataSet(long ID, MDB.MDBConnection conn)
        {
            try
            {
                string sql = "SELECT a.*, b.HOVATEN FROM PHIEUDANHGIADINHDUONGCHUNG a JOIN NHANVIEN b ON a.BACSIDIEUTRI = b.MANHANVIEN WHERE ID = :ID";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, conn);
                command.Parameters.Add(new MDB.MDBParameter("ID", ID));
                MDB.MDBDataAdapter dataAdapter = new MDB.MDBDataAdapter(command);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return null;
        }
    }
}
