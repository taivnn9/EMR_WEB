using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuTDGDKhoaSanTbl : ThongTinKy
    {
        public PhieuTDGDKhoaSanTbl()
        {
            TableName = "PhieuTDGDKhoaSan";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PTDGDSK;
            TenMauPhieu = DanhMucPhieu.PTDGDSK.Description();
        }
        public string SoYTe
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.SoYTe;
            }
        }
        public string BenhVien
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.BenhVien;
            }
        }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.MaBenhNhan;
            }
        }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            }
        }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.Tuoi;
            }
        }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            }
        }
        public string NgheNghiep
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.NgheNghiep;
            }
        }
        [MoTaDuLieu("Mã định danh")]
		public decimal IDPhieu { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        public string Para { get; set; }
        public DateTime NgayThucHien { get; set; } 
        public string MaKTV{ get; set; }
        public string TenKTV{ get; set; }
        public string MaBSGMHS { get; set; }
        public string TenBSGMHS { get; set; }
        [MoTaDuLieu("Mạch")]
		public string Mach { get; set; }
        [MoTaDuLieu("Huyết áp")]
		public string HA { get; set; }
        [MoTaDuLieu("Nhịp thở")]
		public string NhipTho { get; set; }
        public string Tim { get; set; }
        public string Phoi { get; set; }
        public string HoHap { get; set; }
        public string GanNachThan { get; set; }
        public string KetLuan { get; set; }
        public string TienCan { get; set; }
        public string KinhChot { get; set; }
        public string DuSinh { get; set; }
        public string BCTC { get; set; }
        public string TimThai { get; set; }
        public string CTCMo { get; set; }
        public string CTCXoa { get; set; }
        public string NgoiKieuTheDL { get; set; }
        public string ConGo { get; set; }
        public string ConGoCuongDo { get; set; }
        public int LoaiChuyenDa { get; set; }
        public string ChiDinh { get; set; }
        public int CdCytotec { get; set; }
        public int CdOxytocin { get; set; }
        public string DcConGoTxt { get; set; }
        public int DcConGo { get; set; }
        public string NghiemPhapLot { get; set; }
        public int KtGayTe { get; set; }
        public string TuTheChocDo { get; set; }
        public int VTChocDo { get; set; }
        public DateTime ThoiGianTeTS { get; set; } 
        public string TTSKimSo { get; set; }
        public string TTSDoDaiKim { get; set; } 
        public int TTSDNT { get; set; }
        public string TTSThuoc { get; set; }
        public string TTSLieu { get; set; }
        public string TTSNongDo { get; set; }
        public string TTSDangTruong { get; set; }
        public int TTSFentanyl { get; set; }
        public DateTime TNMCThoiGianGayTe { get; set; }
        public string DoDaiKim { get; set; }
        public string TNMCLuon { get; set; }
        public string TNMCLieuTest { get; set; }
        public string TNMCLieuBolus { get; set; }
        public string TNMCNongDo { get; set; }
        public string TNMCTheTich { get; set; }
        public int TNMCFentanyl { get; set; }
        public string TNMCTgBom { get; set; } 
        public int TNMCDuyTriBom { get; set; }
        public string TNMCVantoc { get; set; }
        public string KQTTSCamGiac { get; set; }
        public string KQTTSVanDong { get; set; }
        public string KQTNMCCamGiac { get; set; }
        public string KQTNMCVanDong { get; set; }
        public string TDPLanhRun { get; set; }
        public string TDPChongMat { get; set; }
        public string TDPNhucDau { get; set; }
        public string TDPHaHuyetAp { get; set; }
        public string TDPNonOi { get; set; }
        public string TDPNgua { get; set; }
        public string TDPSuyHoHap { get; set; }
        public string TDPCoGiat { get; set; }
        public string TDPLietVD { get; set; }
        public string TDCDMacRan { get; set; }
        public int TDCDHieuQua { get; set; }
        public int TDCDGioiTinh { get; set; }
        public string TDCDApgar1p { get; set; }
        public string TDCDApgar5p { get; set; } 
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        //public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }

    }
    public class PhieuTDGDKhoaSanFunc
    {
        public const string TableName = "PhieuTDGDKhoaSan";
        public const string TablePrimaryKeyName = "IDPhieu";
        public static List<PhieuTDGDKhoaSanTbl> GetListData(MDB.MDBConnection MyConnection, decimal MaQuanly)
        {
            try
            {
                {
                    List<PhieuTDGDKhoaSanTbl> lstObject = new List<PhieuTDGDKhoaSanTbl>();
                    string sql = "SELECT * FROM PhieuTDGDKhoaSan   WHERE MaQuanLy = :MaQuanLy ORDER BY IDPhieu DESC";
                    MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                    command.Parameters.Add(new MDB.MDBParameter("MaQuanly", MaQuanly));
                    MDB.MDBDataReader DataReader = command.ExecuteReader();
                    while (DataReader.Read())
                    {
                        PhieuTDGDKhoaSanTbl obj = new PhieuTDGDKhoaSanTbl();
                        obj.IDPhieu = Common.ConDB_Decimal(DataReader["IDPhieu"]);
                        obj.MaQuanLy = Common.ConDB_Decimal(DataReader["MaQuanLy"]);
                        obj.ChanDoan = Common.ConDBNull(DataReader["ChanDoan"]);
                        obj.MaKhoa = Common.ConDBNull(DataReader["MaKhoa"]);
                        obj.Khoa = Common.ConDBNull(DataReader["Khoa"]);
                        obj.Para = Common.ConDBNull(DataReader["Para"]);
                        obj.NgayThucHien = Common.ConDB_DateTime(DataReader["NgayThucHien"]);
                        obj.MaKTV = Common.ConDBNull(DataReader["MaKTV"]);
                        obj.TenKTV = Common.ConDBNull(DataReader["TenKTV"]);
                        obj.MaBSGMHS = Common.ConDBNull(DataReader["MaBSGMHS"]);
                        obj.TenBSGMHS = Common.ConDBNull(DataReader["TenBSGMHS"]);
                        obj.Mach = Common.ConDBNull(DataReader["Mach"]);
                        obj.HA = Common.ConDBNull(DataReader["HA"]);
                        obj.NhipTho = Common.ConDBNull(DataReader["NhipTho"]);
                        obj.Tim = Common.ConDBNull(DataReader["Tim"]);
                        obj.Phoi = Common.ConDBNull(DataReader["Phoi"]);
                        obj.HoHap = Common.ConDBNull(DataReader["HoHap"]);
                        obj.GanNachThan = Common.ConDBNull(DataReader["GanNachThan"]);
                        obj.KetLuan = Common.ConDBNull(DataReader["KetLuan"]);
                        obj.TienCan = Common.ConDBNull(DataReader["TienCan"]);
                        obj.KinhChot = Common.ConDBNull(DataReader["KinhChot"]);
                        obj.DuSinh = Common.ConDBNull(DataReader["DuSinh"]);
                        obj.BCTC = Common.ConDBNull(DataReader["BCTC"]);
                        obj.TimThai = Common.ConDBNull(DataReader["TimThai"]);
                        obj.CTCMo = Common.ConDBNull(DataReader["CTCMo"]);
                        obj.CTCXoa = Common.ConDBNull(DataReader["CTCXoa"]);
                        obj.NgoiKieuTheDL = Common.ConDBNull(DataReader["NgoiKieuTheDL"]);
                        obj.ConGo = Common.ConDBNull(DataReader["ConGo"]);
                        obj.ConGoCuongDo = Common.ConDBNull(DataReader["ConGoCuongDo"]);
                        obj.LoaiChuyenDa = Common.ConDB_Int(DataReader["LoaiChuyenDa"]);
                        obj.ChiDinh = Common.ConDBNull(DataReader["ChiDinh"]);
                        obj.CdCytotec = Common.ConDB_Int(DataReader["CdCytotec"]);
                        obj.CdOxytocin = Common.ConDB_Int(DataReader["CdOxytocin"]);
                        obj.DcConGoTxt = Common.ConDBNull(DataReader["DcConGoTxt"]);
                        obj.DcConGo = Common.ConDB_Int(DataReader["DcConGo"]);
                        obj.NghiemPhapLot = Common.ConDBNull(DataReader["NghiemPhapLot"]);
                        obj.KtGayTe = Common.ConDB_Int(DataReader["KtGayTe"]);
                        obj.TuTheChocDo = Common.ConDBNull(DataReader["TuTheChocDo"]);
                        obj.VTChocDo = Common.ConDB_Int(DataReader["VTChocDo"]);
                        obj.ThoiGianTeTS = Common.ConDB_DateTime(DataReader["ThoiGianTeTS"]);
                        obj.TTSKimSo = Common.ConDBNull(DataReader["TTSKimSo"]);
                        obj.TTSDoDaiKim = Common.ConDBNull(DataReader["TTSDoDaiKim"]); 
                        obj.TTSDNT = Common.ConDB_Int(DataReader["TTSDNT"]);
                        obj.TTSThuoc = Common.ConDBNull(DataReader["TTSThuoc"]);
                        obj.TTSLieu = Common.ConDBNull(DataReader["TTSLieu"]);
                        obj.TTSNongDo = Common.ConDBNull(DataReader["TTSNongDo"]);
                        obj.TTSDangTruong = Common.ConDBNull(DataReader["TTSDangTruong"]);
                        obj.TTSFentanyl = Common.ConDB_Int(DataReader["TTSFentanyl"]);
                        obj.TNMCThoiGianGayTe = Common.ConDB_DateTime(DataReader["TNMCThoiGianGayTe"]);
                        obj.DoDaiKim = Common.ConDBNull(DataReader["DoDaiKim"]);
                        obj.TNMCLuon = Common.ConDBNull(DataReader["TNMCLuon"]);
                        obj.TNMCLieuTest = Common.ConDBNull(DataReader["TNMCLieuTest"]);
                        obj.TNMCLieuBolus = Common.ConDBNull(DataReader["TNMCLieuBolus"]);
                        obj.TNMCNongDo = Common.ConDBNull(DataReader["TNMCNongDo"]);
                        obj.TNMCTheTich = Common.ConDBNull(DataReader["TNMCTheTich"]);
                        obj.TNMCFentanyl = Common.ConDB_Int(DataReader["TNMCFentanyl"]);
                        obj.TNMCTgBom = Common.ConDBNull(DataReader["TNMCTgBom"]);
                        obj.TNMCDuyTriBom = Common.ConDB_Int(DataReader["TNMCDuyTriBom"]);
                        obj.TNMCVantoc = Common.ConDBNull(DataReader["TNMCVantoc"]);
                        obj.KQTTSCamGiac = Common.ConDBNull(DataReader["KQTTSCamGiac"]);
                        obj.KQTTSVanDong = Common.ConDBNull(DataReader["KQTTSVanDong"]);
                        obj.KQTNMCCamGiac = Common.ConDBNull(DataReader["KQTNMCCamGiac"]);
                        obj.KQTNMCVanDong = Common.ConDBNull(DataReader["KQTNMCVanDong"]);
                        obj.TDPLanhRun = Common.ConDBNull(DataReader["TDPLanhRun"]);
                        obj.TDPChongMat = Common.ConDBNull(DataReader["TDPChongMat"]);
                        obj.TDPNhucDau = Common.ConDBNull(DataReader["TDPNhucDau"]);
                        obj.TDPHaHuyetAp = Common.ConDBNull(DataReader["TDPHaHuyetAp"]);
                        obj.TDPNonOi = Common.ConDBNull(DataReader["TDPNonOi"]);
                        obj.TDPNgua = Common.ConDBNull(DataReader["TDPNgua"]);
                        obj.TDPSuyHoHap = Common.ConDBNull(DataReader["TDPSuyHoHap"]);
                        obj.TDPCoGiat = Common.ConDBNull(DataReader["TDPCoGiat"]);
                        obj.TDPLietVD = Common.ConDBNull(DataReader["TDPLietVD"]);
                        obj.TDCDMacRan = Common.ConDBNull(DataReader["TDCDMacRan"]);
                        obj.TDCDHieuQua = Common.ConDB_Int(DataReader["TDCDHieuQua"]);
                        obj.TDCDGioiTinh = Common.ConDB_Int(DataReader["TDCDGioiTinh"]);
                        obj.TDCDApgar1p = Common.ConDBNull(DataReader["TDCDApgar1p"]);
                        obj.TDCDApgar5p = Common.ConDBNull(DataReader["TDCDApgar5p"]);
                        obj.NgaySua = Common.ConDB_DateTime(DataReader["NgaySua"]);
                        obj.NguoiSua = Common.ConDBNull(DataReader["NguoiSua"]);
                        obj.NgayTao = Common.ConDB_DateTime(DataReader["NgayTao"]);
                        obj.NguoiTao = Common.ConDBNull(DataReader["NguoiTao"]);
                        obj.MaSoKy = Common.ConDBNull(DataReader["MaSoKyTen"]);
                        obj.DaKy = !string.IsNullOrEmpty(obj.MaSoKy) ? true : false;
                        obj.Chon = false;
                        lstObject.Add(obj);
                    }

                    return lstObject;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, decimal IDBienBan)
        {
            string sql = @"SELECT P.*, '' SoNhapVien,'' MaBenhAn, '' TenBenhNhan,
                        '' TUOI,'' SoYTe, '' BENHVIEN, '' NgheNghiep,
                        ''  GioiTinh
                  FROM PhieuTDGDKhoaSan P 
                  where IDPhieu  = :IDPhieu";
            MDB.MDBCommand Command;
            MDB.MDBDataAdapter adt;
            using (Command = new MDB.MDBCommand(sql, MyConnection))
            {
                Command.Parameters.Add(new MDB.MDBParameter("IDPhieu", IDBienBan));
                adt = new MDB.MDBDataAdapter(Command);
            }
            var ds = new DataSet();
            adt.Fill(ds, "TBL");
            if (ds != null || ds.Tables[0].Rows.Count > 0)
            {
                ds.Tables[0].Rows[0]["SoNhapVien"] = XemBenhAn._ThongTinDieuTri.SoNhapVien;
                ds.Tables[0].Rows[0]["MaBenhAn"] = XemBenhAn._ThongTinDieuTri.MaBenhAn;
                ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                ds.Tables[0].Rows[0]["TUOI"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                ds.Tables[0].Rows[0]["SoYTe"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
                ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
                ds.Tables[0].Rows[0]["NgheNghiep"] = XemBenhAn._HanhChinhBenhNhan.NgheNghiep;
                ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            }
            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection oracleConnection, PhieuTDGDKhoaSanTbl obj, ref bool isUpdate)
        {
            try
            {
                string sql = @"SELECT COUNT(*) RECNUM FROM PhieuTDGDKhoaSan WHERE IDPhieu  = :IDPhieu";
                MDB.MDBCommand oracleCommand;
                int rowCount = 0;
                int nRecord = 0;
                oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
                oracleCommand.Parameters.Add("IDPhieu", obj.IDPhieu);
                MDB.MDBDataReader oracleDataReader = oracleCommand.ExecuteReader();
                while (oracleDataReader.Read())
                {
                    rowCount = int.Parse(oracleDataReader["RECNUM"].ToString());
                }


                if (rowCount > 0)
                {
                    isUpdate = true;
                    sql = @"update PhieuTDGDKhoaSan set
                            MaQuanLy =:MaQuanLy,
                            ChanDoan =:ChanDoan,
                            MaKhoa =:MaKhoa,
                            Khoa =:Khoa,
                            Para =:Para,
                            NgayThucHien =:NgayThucHien,
                            MaKTV =:MaKTV,
                            TenKTV =:TenKTV,
                            MaBSGMHS =:MaBSGMHS,
                            TenBSGMHS =:TenBSGMHS,
                            Mach =:Mach,
                            HA =:HA,
                            NhipTho =:NhipTho,
                            Tim =:Tim,
                            Phoi =:Phoi,
                            HoHap =:HoHap,
                            GanNachThan =:GanNachThan,
                            KetLuan =:KetLuan,
                            TienCan =:TienCan,
                            KinhChot =:KinhChot,
                            DuSinh =:DuSinh,
                            BCTC =:BCTC,
                            TimThai =:TimThai,
                            CTCMo =:CTCMo,
                            CTCXoa =:CTCXoa,
                            NgoiKieuTheDL =:NgoiKieuTheDL,
                            ConGo =:ConGo,
                            ConGoCuongDo =:ConGoCuongDo,
                            LoaiChuyenDa =:LoaiChuyenDa,
                            ChiDinh =:ChiDinh,
                            CdCytotec =:CdCytotec,
                            CdOxytocin =:CdOxytocin,
                            DcConGoTxt =:DcConGoTxt,
                            DcConGo =:DcConGo,
                            NghiemPhapLot =:NghiemPhapLot,
                            KtGayTe =:KtGayTe,
                            TuTheChocDo =:TuTheChocDo,
                            VTChocDo =:VTChocDo,
                            ThoiGianTeTS =:ThoiGianTeTS,
                            TTSKimSo =:TTSKimSo,
                            TTSDoDaiKim =:TTSDoDaiKim,
                            TTSDNT =:TTSDNT,
                            TTSThuoc =:TTSThuoc,
                            TTSLieu =:TTSLieu,
                            TTSNongDo =:TTSNongDo,
                            TTSDangTruong =:TTSDangTruong,
                            TTSFentanyl =:TTSFentanyl,
                            TNMCThoiGianGayTe =:TNMCThoiGianGayTe,
                            DoDaiKim =:DoDaiKim,
                            TNMCLuon =:TNMCLuon,
                            TNMCLieuTest =:TNMCLieuTest,
                            TNMCLieuBolus =:TNMCLieuBolus,
                            TNMCNongDo =:TNMCNongDo,
                            TNMCTheTich =:TNMCTheTich,
                            TNMCFentanyl =:TNMCFentanyl,
                            TNMCTgBom =:TNMCTgBom,
                            TNMCDuyTriBom =:TNMCDuyTriBom,
                            TNMCVantoc =:TNMCVantoc,
                            KQTTSCamGiac =:KQTTSCamGiac,
                            KQTTSVanDong =:KQTTSVanDong,
                            KQTNMCCamGiac =:KQTNMCCamGiac,
                            KQTNMCVanDong =:KQTNMCVanDong,
                            TDPLanhRun =:TDPLanhRun,
                            TDPChongMat =:TDPChongMat,
                            TDPNhucDau =:TDPNhucDau,
                            TDPHaHuyetAp =:TDPHaHuyetAp,
                            TDPNonOi =:TDPNonOi,
                            TDPNgua =:TDPNgua,
                            TDPSuyHoHap =:TDPSuyHoHap,
                            TDPCoGiat =:TDPCoGiat,
                            TDPLietVD =:TDPLietVD,
                            TDCDMacRan =:TDCDMacRan,
                            TDCDHieuQua =:TDCDHieuQua,
                            TDCDGioiTinh =:TDCDGioiTinh,
                            TDCDApgar1p =:TDCDApgar1p,
                            TDCDApgar5p =:TDCDApgar5p,
                            NgaySua =:NgaySua,
                            NguoiSua =:NguoiSua ";
                    sql = sql + " WHERE IDPhieu  = " + obj.IDPhieu.ToString();
                }
                else
                {
                    sql = @"insert into PhieuTDGDKhoaSan(
                            MaQuanLy,
                            ChanDoan,
                            MaKhoa,
                            Khoa,
                            Para,
                            NgayThucHien,
                            MaKTV,
                            TenKTV,
                            MaBSGMHS,
                            TenBSGMHS,
                            Mach,
                            HA,
                            NhipTho,
                            Tim,
                            Phoi,
                            HoHap,
                            GanNachThan,
                            KetLuan,
                            TienCan,
                            KinhChot,
                            DuSinh,
                            BCTC,
                            TimThai,
                            CTCMo,
                            CTCXoa,
                            NgoiKieuTheDL,
                            ConGo,
                            ConGoCuongDo,
                            LoaiChuyenDa,
                            ChiDinh,
                            CdCytotec,
                            CdOxytocin,
                            DcConGoTxt,
                            DcConGo,
                            NghiemPhapLot,
                            KtGayTe,
                            TuTheChocDo,
                            VTChocDo,
                            ThoiGianTeTS,
                            TTSKimSo,
                            TTSDoDaiKim,
                            TTSDNT,
                            TTSThuoc,
                            TTSLieu,
                            TTSNongDo,
                            TTSDangTruong,
                            TTSFentanyl,
                            TNMCThoiGianGayTe,
                            DoDaiKim,
                            TNMCLuon,
                            TNMCLieuTest,
                            TNMCLieuBolus,
                            TNMCNongDo,
                            TNMCTheTich,
                            TNMCFentanyl,
                            TNMCTgBom,
                            TNMCDuyTriBom,
                            TNMCVantoc,
                            KQTTSCamGiac,
                            KQTTSVanDong,
                            KQTNMCCamGiac,
                            KQTNMCVanDong,
                            TDPLanhRun,
                            TDPChongMat,
                            TDPNhucDau,
                            TDPHaHuyetAp,
                            TDPNonOi,
                            TDPNgua,
                            TDPSuyHoHap,
                            TDPCoGiat,
                            TDPLietVD,
                            TDCDMacRan,
                            TDCDHieuQua,
                            TDCDGioiTinh,
                            TDCDApgar1p,
                            TDCDApgar5p,
                            NgaySua,
                            NguoiSua,
                            NgayTao,
                            NguoiTao
                            ) VALUES( 
                            :MaQuanLy,
                            :ChanDoan,
                            :MaKhoa,
                            :Khoa,
                            :Para,
                            :NgayThucHien,
                            :MaKTV,
                            :TenKTV,
                            :MaBSGMHS,
                            :TenBSGMHS,
                            :Mach,
                            :HA,
                            :NhipTho,
                            :Tim,
                            :Phoi,
                            :HoHap,
                            :GanNachThan,
                            :KetLuan,
                            :TienCan,
                            :KinhChot,
                            :DuSinh,
                            :BCTC,
                            :TimThai,
                            :CTCMo,
                            :CTCXoa,
                            :NgoiKieuTheDL,
                            :ConGo,
                            :ConGoCuongDo,
                            :LoaiChuyenDa,
                            :ChiDinh,
                            :CdCytotec,
                            :CdOxytocin,
                            :DcConGoTxt,
                            :DcConGo,
                            :NghiemPhapLot,
                            :KtGayTe,
                            :TuTheChocDo,
                            :VTChocDo,
                            :ThoiGianTeTS,
                            :TTSKimSo,
                            :TTSDoDaiKim,
                            :TTSDNT,
                            :TTSThuoc,
                            :TTSLieu,
                            :TTSNongDo,
                            :TTSDangTruong,
                            :TTSFentanyl,
                            :TNMCThoiGianGayTe,
                            :DoDaiKim,
                            :TNMCLuon,
                            :TNMCLieuTest,
                            :TNMCLieuBolus,
                            :TNMCNongDo,
                            :TNMCTheTich,
                            :TNMCFentanyl,
                            :TNMCTgBom,
                            :TNMCDuyTriBom,
                            :TNMCVantoc,
                            :KQTTSCamGiac,
                            :KQTTSVanDong,
                            :KQTNMCCamGiac,
                            :KQTNMCVanDong,
                            :TDPLanhRun,
                            :TDPChongMat,
                            :TDPNhucDau,
                            :TDPHaHuyetAp,
                            :TDPNonOi,
                            :TDPNgua,
                            :TDPSuyHoHap,
                            :TDPCoGiat,
                            :TDPLietVD,
                            :TDCDMacRan,
                            :TDCDHieuQua,
                            :TDCDGioiTinh,
                            :TDCDApgar1p,
                            :TDCDApgar5p,
                            :NgaySua,
                            :NguoiSua,
                            :NgayTao,
                            :NguoiTao
                            )  RETURNING IDPhieu INTO :IDPhieu";
                }
                oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaQuanLy", obj.MaQuanLy));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ChanDoan", obj.ChanDoan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaKhoa", obj.MaKhoa));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Khoa", obj.Khoa));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Para", obj.Para));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayThucHien", obj.NgayThucHien));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaKTV", obj.MaKTV));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenKTV", obj.TenKTV));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBSGMHS", obj.MaBSGMHS));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenBSGMHS", obj.TenBSGMHS));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Mach", obj.Mach));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("HA", obj.HA));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NhipTho", obj.NhipTho));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Tim", obj.Tim));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Phoi", obj.Phoi));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("HoHap", obj.HoHap));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("GanNachThan", obj.GanNachThan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KetLuan", obj.KetLuan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TienCan", obj.TienCan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KinhChot", obj.KinhChot));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DuSinh", obj.DuSinh));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("BCTC", obj.BCTC));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TimThai", obj.TimThai));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CTCMo", obj.CTCMo));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CTCXoa", obj.CTCXoa));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgoiKieuTheDL", obj.NgoiKieuTheDL));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ConGo", obj.ConGo));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ConGoCuongDo", obj.ConGoCuongDo));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("LoaiChuyenDa", obj.LoaiChuyenDa));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ChiDinh", obj.ChiDinh));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CdCytotec", obj.CdCytotec));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CdOxytocin", obj.CdOxytocin));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DcConGoTxt", obj.DcConGoTxt));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DcConGo", obj.DcConGo));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NghiemPhapLot", obj.NghiemPhapLot));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KtGayTe", obj.KtGayTe));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TuTheChocDo", obj.TuTheChocDo));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("VTChocDo", obj.VTChocDo));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ThoiGianTeTS", obj.ThoiGianTeTS));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TTSKimSo", obj.TTSKimSo));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TTSDoDaiKim", obj.TTSDoDaiKim));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TTSDNT", obj.TTSDNT));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TTSThuoc", obj.TTSThuoc));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TTSLieu", obj.TTSLieu));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TTSNongDo", obj.TTSNongDo));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TTSDangTruong", obj.TTSDangTruong));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TTSFentanyl", obj.TTSFentanyl));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TNMCThoiGianGayTe", obj.TNMCThoiGianGayTe));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DoDaiKim", obj.DoDaiKim));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TNMCLuon", obj.TNMCLuon));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TNMCLieuTest", obj.TNMCLieuTest));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TNMCLieuBolus", obj.TNMCLieuBolus));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TNMCNongDo", obj.TNMCNongDo));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TNMCTheTich", obj.TNMCTheTich));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TNMCFentanyl", obj.TNMCFentanyl));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TNMCTgBom", obj.TNMCTgBom));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TNMCDuyTriBom", obj.TNMCDuyTriBom));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TNMCVantoc", obj.TNMCVantoc));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KQTTSCamGiac", obj.KQTTSCamGiac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KQTTSVanDong", obj.KQTTSVanDong));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KQTNMCCamGiac", obj.KQTNMCCamGiac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KQTNMCVanDong", obj.KQTNMCVanDong));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TDPLanhRun", obj.TDPLanhRun));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TDPChongMat", obj.TDPChongMat));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TDPNhucDau", obj.TDPNhucDau));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TDPHaHuyetAp", obj.TDPHaHuyetAp));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TDPNonOi", obj.TDPNonOi));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TDPNgua", obj.TDPNgua));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TDPSuyHoHap", obj.TDPSuyHoHap));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TDPCoGiat", obj.TDPCoGiat));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TDPLietVD", obj.TDPLietVD));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TDCDMacRan", obj.TDCDMacRan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TDCDHieuQua", obj.TDCDHieuQua));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TDCDGioiTinh", obj.TDCDGioiTinh));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TDCDApgar1p", obj.TDCDApgar1p));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TDCDApgar5p", obj.TDCDApgar5p));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgaySua", DateTime.Now));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiSua", obj.NguoiSua));
                if (!isUpdate)
                {

                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayTao", DateTime.Now));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiTao", obj.NguoiTao));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("IDPhieu", obj.IDPhieu));
                }
                nRecord = oracleCommand.ExecuteNonQuery();
                if (nRecord > 0)
                {
                    if (!isUpdate)
                    {
                        decimal nextval = Common.ConDB_Decimal((oracleCommand.Parameters["IDPhieu"] as MDB.MDBParameter).Value);
                        obj.IDPhieu = nextval;
                    }
                }
                return nRecord > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.LogError(ex);
            }
            return false;
        }
        //20201031 tunght icloud custorm 
        //public static bool DeleteByIDPhieu(MDB.MDBConnection oracleConnection, decimal IDbienBan)
        public static bool DeleteByIDPhieu(MDB.MDBConnection oracleConnection, List<decimal> lstIDbienBan)
        {
            try
            {
                string sql = "";
                string strWhere = "";
                MDB.MDBCommand oracleCommand;
                strWhere = " IDPhieu In(";
                if (lstIDbienBan.Count > 0)
                {
                    for (int i = 0; i < lstIDbienBan.Count; i++)
                    {
                        strWhere = strWhere + lstIDbienBan[i].ToString();
                        if (i == (lstIDbienBan.Count - 1))
                        {
                            strWhere = strWhere + ")";
                        }
                        else
                        {
                            strWhere = strWhere + ",";
                        }
                    }
                }
                sql = @"DELETE FROM PhieuTDGDKhoaSan WHERE  " + strWhere;
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
    }
}
