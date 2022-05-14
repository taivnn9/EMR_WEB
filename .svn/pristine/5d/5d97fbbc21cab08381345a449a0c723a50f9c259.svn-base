
using EMR.KyDienTu;
using System;
using System.Collections.Generic;
using System.Data;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class BienBanBanGiaoTreSoSinh : ThongTinKy
    {
        public BienBanBanGiaoTreSoSinh()
        {
            IDMauPhieu = (int)DanhMucPhieu.BBBGTSS;
            TenMauPhieu = DanhMucPhieu.BBBGTSS.Description();
        }
        [MoTaDuLieu("Mã định danh biên bản bàn giao")]
		public decimal IDBienBanBanGiao { get; set; }
        [MoTaDuLieu("Bệnh viện")]
		public string BenhVien { get; set; }
        [MoTaDuLieu("Khoa phòng")]
        public string KhoaPhong { get; set; }
        [MoTaDuLieu("Họ tên mẹ")]
        public string HoTenMe { get; set; }
        [MoTaDuLieu("Năm sinh mẹ")]
        public decimal NamSinh { get; set; }
        [MoTaDuLieu("Địa chỉ mẹ")]
		public string DiaChi { get; set; }
        [MoTaDuLieu("Số CMND")]
        public string SoCMND { get; set; }
        [MoTaDuLieu("Dân tộc")]
		public string DanToc { get; set; }
        [MoTaDuLieu("Thời gian sinh")]
        public DateTime ThoiGianSinh { get; set; }
        [MoTaDuLieu("Sinh tại")]
        public string Tai { get; set; }
        [MoTaDuLieu("Số con")]
        public string SoCon { get; set; }
        [MoTaDuLieu("Giới tính con thứ 1")]
        public string GioiTinhCon1 { get; set; }
        [MoTaDuLieu("Cân nặng con thứ 1")]
        public string CanNangCon1 { get; set; }
        [MoTaDuLieu("Chiều dài con thứ 1")]
        public string ChieuDaiCon1 { get; set; }
        [MoTaDuLieu("Vòng đầu con thứ 1")]
        public string VongDauCon1 { get; set; }
        [MoTaDuLieu("Giới tính con thứ 2")]
        public string GioiTinhCon2 { get; set; }
        [MoTaDuLieu("Cân nặng con thứ 2")]
        public string CanNangCon2 { get; set; }
        [MoTaDuLieu("Chiều dài con thứ 2")]
        public string ChieuDaiCon2 { get; set; }
        [MoTaDuLieu("Vòng đầu con thứ 2")]
        public string VongDauCon2 { get; set; }
        [MoTaDuLieu("Nhịp thở")]
		public string NhipTho { get; set; }
        [MoTaDuLieu("Kiểu thở")]
        public string KieuTho { get; set; }
        [MoTaDuLieu("Nhịp tim")]
		public string NhipTim { get; set; }
        [MoTaDuLieu("Nhiệt độ")]
		public string NhietDo { get; set; }
        [MoTaDuLieu("Màu sắc da")]
        public int? MauSacDa { get; set; }
        [MoTaDuLieu("Dị tật đầu, mặt, cổ")]
        public int? DiTatDauMatCo { get; set; }
        [MoTaDuLieu("Dị tật thân hình")]
        public int? DiTatThanHinh { get; set; }
        [MoTaDuLieu("Dị tật tứ chi")]
        public int? DiTatTuChi { get; set; }
        [MoTaDuLieu("Phản xạ tứ chi")]
        public string PhanXaTuChi { get; set; }
        [MoTaDuLieu("Dị tật khác")]
        public int? DiTatKhac { get; set; }
        [MoTaDuLieu("Sang chấn phần mềm")]
        public int? SangChanPhanMem { get; set; }
        [MoTaDuLieu("Xương khớp")]
        public int? XuongKhop { get; set; }
        [MoTaDuLieu("Thần kinh")]
        public int? ThanKinh { get; set; }
        [MoTaDuLieu("Tình trạng rốn")]
        public int? TinhTrangRon { get; set; }
        [MoTaDuLieu("Cơ quan sinh dục")]
        public int? CoQuanSinhDuc { get; set; }
        [MoTaDuLieu("Đại tiểu tiện")]
        public int? DaiTieuTien { get; set; }
        [MoTaDuLieu("Thuốc đã dùng")]
        public string ThuocDaDung { get; set; }
        [MoTaDuLieu("Họ tên người đỡ đẻ")]
        public string NguoiDoDe { get; set; }
        [MoTaDuLieu("Họ tên người giao con")]
        public string NguoiGiaoCon { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Mã nhân viên đỡ đẻ")]
        public string MaNVDoDe { get; set; }
        [MoTaDuLieu("Mã nhân viên giao con")]
        public string MaNVGiaoCon{ get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        //public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
        public const string TableName = "BienBanBanGiaoTreSoSinh";
        public const string TablePrimaryKeyName = "IDBienBanBanGiao";
        public static bool DeleteByIDBienBanBanGiao(MDB.MDBConnection oracleConnection, List <decimal> IDBienBan)
        {
            try
            {
                string sql = "";
                string strWhere = "";
                MDB.MDBCommand oracleCommand;
                strWhere = "In(";
                if (IDBienBan.Count > 0)
                {
                    for(int i =0 ; i < IDBienBan.Count; i++)
                    {
                        strWhere = strWhere + IDBienBan[i].ToString();
                        if(i == (IDBienBan.Count -1))
                        {
                            strWhere = strWhere + ")";
                        }
                        else
                        {
                            strWhere = strWhere + ",";
                        }
                    }
                }
                sql = @"DELETE FROM BIENBANBANGIAOTRESOSINH WHERE IDBIENBANBANGIAO " + strWhere;
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
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, string IDBienBan)
        {
            string sql = @"select AA.*"
                         + " from BIENBANBANGIAOTRESOSINH AA WHERE IDBIENBANBANGIAO =: IDBIENBANBANGIAO ORDER BY NgayTao, NgaySua asc";
            MDB.MDBCommand Command;
            MDB.MDBDataAdapter adt;
            using (Command = new MDB.MDBCommand(sql, MyConnection))
            {
                Command.Parameters.Add(new MDB.MDBParameter("IDBIENBANBANGIAO", IDBienBan));
                adt = new MDB.MDBDataAdapter(Command);
            }
            var ds = new DataSet();
            adt.Fill(ds, "TBL");
            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection oracleConnection, BienBanBanGiaoTreSoSinh obj,ref bool isUpdate)
        {
            try
            {
                string sql = @"SELECT COUNT(*) RECNUM FROM BIENBANBANGIAOTRESOSINH WHERE IDBIENBANBANGIAO = :IDBIENBANBANGIAO";
                MDB.MDBCommand oracleCommand;
                int rowCount = 0;
                int nRecord = 0;
                decimal sequence_nextval = 0;
                using (oracleCommand = new MDB.MDBCommand(sql, oracleConnection))
                {
                    oracleCommand.Parameters.Add("IDBIENBANBANGIAO", obj.IDBienBanBanGiao);
                    MDB.MDBDataReader oracleDataReader = oracleCommand.ExecuteReader();
                    while (oracleDataReader.Read())
                    {
                        rowCount = int.Parse(oracleDataReader["RECNUM"].ToString());
                    }
                }
                   
             
                if (rowCount > 0)
                {
                    isUpdate = true;
                    sequence_nextval = obj.IDBienBanBanGiao;
                    sql = "update BIENBANBANGIAOTRESOSINH set BENHVIEN = :BENHVIEN,KHOAPHONG = :KHOAPHONG,";
                    sql = sql + "HOTENME = :HOTENME,NAMSINH = :NAMSINH,DIACHI = :DIACHI,SOCMND = :SOCMND,DANTOC = :DANTOC,THOIGIANSINH = :THOIGIANSINH";
                    sql = sql + ",TAI = :TAI,SOCON = :SOCON,GIOITINHCON1 = :GIOITINHCON1,CANNANGCON1 = :CANNANGCON1,CHIEUDAICON1 = :CHIEUDAICON1,VONGDAUCON1 = :VONGDAUCON1,";
                    sql = sql + "GIOITINHCON2 = :GIOITINHCON2,CANNANGCON2 = :CANNANGCON2,CHIEUDAICON2 = :CHIEUDAICON2,VONGDAUCON2 = :VONGDAUCON2,NHIPTHO = :NHIPTHO,KIEUTHO = :KIEUTHO,";
                    sql = sql + "NHIPTIM = :NHIPTIM,NHIETDO = :NHIETDO,MAUSACDA = :MAUSACDA,DITATDAUMATCO = :DITATDAUMATCO,DITATTHANHINH = :DITATTHANHINH,DITATTUCHI = :DITATTUCHI,";
                    sql = sql + "PHANXATUCHI = :PHANXATUCHI,DITATKHAC = :DITATKHAC,SANGCHANPHANMEM = :SANGCHANPHANMEM,XUONGKHOP = :XUONGKHOP,THANKINH = :THANKINH,COQUANSINHDUC = :COQUANSINHDUC,";
                    sql = sql + "TINHTRANGRON = :TINHTRANGRON,DAITIEUTIEN = :DAITIEUTIEN,THUOCDADUNG = :THUOCDADUNG,NGUOIDODE = :NGUOIDODE, NGUOIGIAOCON = :NGUOIGIAOCON,MANVDODE = :MANVDODE, MANVGIAOCON = :MANVGIAOCON,";
                    sql = sql + "NGAYTAO = :NGAYTAO,NGAYSUA = :NGAYSUA,MAQUANLY = :MAQUANLY,MASOKYTEN = :MASOKYTEN ";
                    sql = sql + " WHERE IDBIENBANBANGIAO = " + obj.IDBienBanBanGiao.ToString();
                }
                else
                {
                    sql = @"select NVL(MAX(IDBIENBANBANGIAO),0) AS sequence_nextval from BIENBANBANGIAOTRESOSINH";
                    using (oracleCommand = new MDB.MDBCommand(sql, oracleConnection))
                    {
                        MDB.MDBDataReader oracleDataReader = oracleCommand.ExecuteReader();
                        while (oracleDataReader.Read())
                        {
                            sequence_nextval = decimal.Parse(oracleDataReader["sequence_nextval"].ToString()) + 1;
                        }
                    }
                    sql = @"insert into BIENBANBANGIAOTRESOSINH(IDBienBanBanGiao"+
                          ",BenhVien,KhoaPhong," +
                          "HoTenMe,NamSinh,DiaChi,SoCMND,DanToc,ThoiGianSinh,"+
                          "Tai,SoCon,GioiTinhCon1,CanNangCon1,ChieuDaiCon1,VongDauCon1,"+
                          "GioiTinhCon2,CanNangCon2,ChieuDaiCon2,VongDauCon2,NhipTho,KieuTho," +
                          "NhipTim,NhietDo,MauSacDa,DiTatDauMatCo,DiTatThanHinh,DiTatTuChi,PhanXaTuChi," +
                          "DiTatKhac,SangChanPhanMem,XuongKhop,ThanKinh,CoQuanSinhDuc," +
                          "TinhTrangRon,DaiTieuTien,ThuocDaDung,NguoiDoDe,NguoiGiaoCon,MaNVDoDe,MANVGiaoCon," +
                          "NgayTao,NgaySua," +
                          "MaQuanLy," +
                          "MaSoKyTen" +
                          ")";
                    sql = sql + @"Values(:IDBIENBANBANGIAO"+
                        ",:BENHVIEN,:KHOAPHONG,"+
                        ":HOTENME,:NAMSINH,:DIACHI,:SOCMND,:DANTOC,:THOIGIANSINH,"+
                        ":TAI,:SOCON,:GIOITINHCON1,:CANNANGCON1,:CHIEUDAICON1,:VONGDAUCON1,"+
                        ":GIOITINHCON2,:CANNANGCON2,:CHIEUDAICON2,:VONGDAUCON2,:NHIPTHO,:KIEUTHO," +
                        ":NHIPTIM,:NHIETDO,:MAUSACDA,:DITATDAUMATCO,:DITATTHANHINH,:DITATTUCHI,:PHANXATUCHI," +
                        ":DITATKHAC,:SANGCHANPHANMEM,:XUONGKHOP,:THANKINH,:COQUANSINHDUC," +
                        ":TINHTRANGRON,:DAITIEUTIEN,:THUOCDADUNG,:NGUOIDODE,:NGUOIGIAOCON,:MANVDODE,:MANVGIAOCON" +
                        ",:NGAYTAO,:NGAYSUA," +
                        ":MAQUANLY," +
                        ":MASOKYTEN" +
                        ")";
                }
                using (oracleCommand = new MDB.MDBCommand(sql, oracleConnection))
                {
                    if (rowCount <= 0)
                    {
                        oracleCommand.Parameters.Add(new MDB.MDBParameter("IDBIENBANBANGIAO", sequence_nextval));
                    }

                    oracleCommand.Parameters.Add(new MDB.MDBParameter("BENHVIEN", obj.BenhVien));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("KHOAPHONG", obj.KhoaPhong));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("HOTENME", obj.HoTenMe));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NAMSINH", obj.NamSinh));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DIACHI", obj.DiaChi));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SOCMND", obj.SoCMND));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DANTOC", obj.DanToc));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("THOIGIANSINH", obj.ThoiGianSinh));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TAI", obj.Tai));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SOCON", obj.SoCon));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("GIOITINHCON1", obj.GioiTinhCon1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CANNANGCON1", obj.CanNangCon1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CHIEUDAICON1", obj.ChieuDaiCon1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("VONGDAUCON1", obj.VongDauCon1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("GIOITINHCON2", obj.GioiTinhCon2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CANNANGCON2", obj.CanNangCon2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CHIEUDAICON2", obj.ChieuDaiCon2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("VONGDAUCON2", obj.VongDauCon2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NHIPTHO", obj.NhipTho));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("KIEUTHO", obj.KieuTho));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NHIPTIM", obj.NhipTim));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NHIETDO", obj.NhietDo));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MAUSACDA", obj.MauSacDa));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DITATDAUMATCO", obj.DiTatDauMatCo));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DITATTHANHINH", obj.DiTatThanHinh));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DITATTUCHI", obj.DiTatTuChi));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("PHANXATUCHI", obj.PhanXaTuChi));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DITATKHAC", obj.DiTatKhac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SANGCHANPHANMEM", obj.SangChanPhanMem));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("XUONGKHOP", obj.XuongKhop));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("THANKINH", obj.ThanKinh));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("COQUANSINHDUC", obj.CoQuanSinhDuc));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TINHTRANGRON",obj.TinhTrangRon));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DAITIEUTIEN", obj.DaiTieuTien));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("THUOCDADUNG", obj.ThuocDaDung));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NGUOIDODE", obj.NguoiDoDe));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NGUOIGIAOCON", obj.NguoiGiaoCon));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MANVDODE", obj.MaNVDoDe));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MANVGIAOCON", obj.MaNVGiaoCon));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NGAYTAO", obj.NgayTao));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NGAYSUA", obj.NgaySua));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MAQUANLY", obj.MaQuanLy));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MASOKYTEN", obj.MaSoKy));
                    nRecord = oracleCommand.ExecuteNonQuery();
                }
                if(nRecord >  0)
                {
                    obj.IDBienBanBanGiao = sequence_nextval;
                }
                return nRecord > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.LogError(ex);
            }
            return false;
        }
        public static int countPhieu(MDB.MDBConnection oracleConnection, string MaQuanLy)
        {
            int count = 0;
            string sql = @"SELECT COUNT(IDBIENBANBANGIAO) FROM BIENBANBANGIAOTRESOSINH WHERE MAQUANLY = :MaQuanLy";
            MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
            oracleCommand.Parameters.Add("MaQuanLy", MaQuanLy);
            oracleCommand.BindByName = true;
            MDB.MDBDataReader DataReader = oracleCommand.ExecuteReader();
            while (DataReader.Read())
            {
                int temp = 0;
                int.TryParse(DataReader["COUNT(IDBIENBANBANGIAO)"].ToString(), out temp);
                count = temp;
                break;
            }
            return count;
        }
        public static List<BienBanBanGiaoTreSoSinh> GetData(MDB.MDBConnection MyConnection, decimal IDBienBanBanGiao, decimal MaQuanLy, string TenKhoa)
        {
            List<BienBanBanGiaoTreSoSinh> lstData = new List<BienBanBanGiaoTreSoSinh>();
            string sql = @"select * from BIENBANBANGIAOTRESOSINH WHERE MaQuanLy = :MaQuanLy ";
            if (IDBienBanBanGiao != -1)
            {
                sql += " and IDThongTinTruyenMau = " + IDBienBanBanGiao + "";
            }
            sql += " ORDER BY NgayTao, NgaySua asc";
            MDB.MDBCommand Command;
            using (Command = new MDB.MDBCommand(sql, MyConnection))
            {
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    lstData.Add(new BienBanBanGiaoTreSoSinh
                    {
                        IDBienBanBanGiao = decimal.Parse(DataReader["IDBIENBANBANGIAO"].ToString()),
                        BenhVien = ConDBNull(DataReader["BENHVIEN"]),
                        KhoaPhong = ConDBNull(DataReader["KHOAPHONG"]),
                        HoTenMe = ConDBNull(DataReader["HOTENME"]),
                        NamSinh = ConDB_Decimal(DataReader["NAMSINH"], 1900),
                        DiaChi = ConDBNull(DataReader["DIACHI"]),
                        SoCMND = ConDBNull(DataReader["SOCMND"]),
                        DanToc = ConDBNull(DataReader["DANTOC"]),
                        ThoiGianSinh = ConDB_DateTime(DataReader["THOIGIANSINH"]),
                        Tai = ConDBNull(DataReader["TAI"]),
                        SoCon = ConDBNull(DataReader["SOCON"]),
                        GioiTinhCon1 = ConDBNull(DataReader["GIOITINHCON1"]),
                        CanNangCon1 = ConDBNull(DataReader["CANNANGCON1"]),
                        ChieuDaiCon1 = ConDBNull(DataReader["CHIEUDAICON1"]),
                        VongDauCon1 = ConDBNull(DataReader["VONGDAUCON1"]),
                        GioiTinhCon2 = ConDBNull(DataReader["GIOITINHCON2"]),
                        CanNangCon2 = ConDBNull(DataReader["CANNANGCON2"]),
                        ChieuDaiCon2 = ConDBNull(DataReader["CHIEUDAICON2"]),
                        VongDauCon2 = ConDBNull(DataReader["VONGDAUCON2"]),
                        NhipTho = ConDBNull(DataReader["NHIPTHO"]),
                        KieuTho = ConDBNull(DataReader["KIEUTHO"]),
                        NhipTim = ConDBNull(DataReader["NHIPTIM"]),
                        NhietDo = ConDBNull(DataReader["NHIETDO"]),
                        MauSacDa = (int)ConDB_Decimal(DataReader["MAUSACDA"]),
                        DiTatDauMatCo = ConDB_Int(DataReader["DITATDAUMATCO"]),
                        DiTatThanHinh = ConDB_Int(DataReader["DITATTHANHINH"]),
                        DiTatTuChi = ConDB_Int(DataReader["DITATTUCHI"]),
                        PhanXaTuChi = ConDBNull(DataReader["PHANXATUCHI"]),
                        DiTatKhac = ConDB_Int(DataReader["DITATKHAC"]),
                        SangChanPhanMem = ConDB_Int(DataReader["SANGCHANPHANMEM"]),
                        XuongKhop = ConDB_Int(DataReader["XUONGKHOP"]),
                        ThanKinh = ConDB_Int(DataReader["THANKINH"]),
                        CoQuanSinhDuc = ConDB_Int(DataReader["COQUANSINHDUC"]),
                        TinhTrangRon = ConDB_Int(DataReader["TINHTRANGRON"]),
                        DaiTieuTien = ConDB_Int(DataReader["DAITIEUTIEN"]),
                        ThuocDaDung = ConDBNull(DataReader["THUOCDADUNG"]),
                        NguoiDoDe = ConDBNull(DataReader["NGUOIDODE"]),
                        NguoiGiaoCon = ConDBNull(DataReader["NGUOIGIAOCON"]),
                        MaNVDoDe = ConDBNull(DataReader["MANVDODE"]),
                        MaNVGiaoCon = ConDBNull(DataReader["MANVGIAOCON"]),
                        NgayTao = ConDB_DateTime(DataReader["NGAYTAO"]),
                        NgaySua = ConDB_DateTime(DataReader["NGAYSUA"]),
                        MaQuanLy = ConDB_Decimal(DataReader["MAQUANLY"]),
                        MaSoKy = ConDBNull(DataReader["MASOKYTEN"]),
                        DaKy = !string.IsNullOrEmpty(ConDBNull(DataReader["masokyten"])) ? true : false,
                        Chon = false
                    });
                }
            }
            return lstData;
        }
        public static string ConDBNull(object dbVal)
        {
            string ret = "";
            if(dbVal == null)
            {
                return ret;
            }
            ret = dbVal.ToString();
            return ret;
        }
        public static decimal ConDB_Decimal(object dbVal, decimal valDefault = 0)
        {
            decimal ret = valDefault;
            if (dbVal == null)
            {
                return ret;
            }
            bool isSuccess = decimal.TryParse(dbVal.ToString(), out ret);
            if(!isSuccess)
            {
                return valDefault;
            }
            return ret;
        }
        public static int ConDB_Int(object dbVal, int valDefault = 0)
        {
            int ret = valDefault;
            if (dbVal == null)
            {
                return ret;
            }
            bool isSuccess = int.TryParse(dbVal.ToString(), out ret);
            if (!isSuccess)
            {
                return valDefault;
            }
            return ret;
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
