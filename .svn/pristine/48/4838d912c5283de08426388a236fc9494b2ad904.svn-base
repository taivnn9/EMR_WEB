using EMR.KyDienTu;
using System;
using System.Collections.Generic;
using System.Data;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuCBBnTruocCTCuaDDTbl : ThongTinKy
    {
        public PhieuCBBnTruocCTCuaDDTbl()
        {
            TableName = "PhieuCBBnTruocCTCuaDD";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PCBBNTCTCDD;
            TenMauPhieu = DanhMucPhieu.PCBBNTCTCDD.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public decimal IDPhieu { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Năm sinh")]
		public string NamSinh { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        public int CanThiep { get; set; }
        public int Diung { get; set; }
        public string ChiTietDiung { get; set; }
        public string MaDDChuanBi { get; set; }
        public string TenDDChuanBi { get; set; }
        public string MaDDDua { get; set; }
        public string TenDDDua { get; set; }
        public string MaDDNhan { get; set; }
        public string TenDDNhan { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }
        public string ppCanThiepDK { get; set; }
        public int NDI1_1 { get; set; }
        public int NDI1_2 { get; set; }
        public int NDI1_3 { get; set; }
        public int NDI1_4 { get; set; }
        public int NDI2_1 { get; set; }
        public int NDI2_2 { get; set; }
        public int NDI3_1 { get; set; }
        public int NDI3_2 { get; set; }
        public int NDI4_1 { get; set; }
        public int NDI4_2 { get; set; }
        public int NDI5_1 { get; set; }
        public int NDI5_2 { get; set; }
        public int NDI6_1 { get; set; }
        public int NDI6_2 { get; set; }
        public int NDI6_3 { get; set; }
        public int NDI6_4 { get; set; }
        public int NDI7_1 { get; set; }
        public int NDI7_2 { get; set; }
        public int NDI8_1 { get; set; }
        public int NDI8_2 { get; set; }
        public int NDI9_1 { get; set; }
        public int NDI9_2 { get; set; }
        public int NDI9_3 { get; set; }
        public int NDI9_4 { get; set; }
        public int NDI9_5 { get; set; }
        public int NDI9_6 { get; set; }
        public int NDI10_1 { get; set; }
        public int NDI10_2 { get; set; }
        public int NDI11_1 { get; set; }
        public int NDI11_2 { get; set; }
        public int NDI11_3 { get; set; }
        public int NDI11_4 { get; set; }
        public int NDII1_1 { get; set; }
        public int NDII1_2 { get; set; }
        public int NDII2_1 { get; set; }
        public int NDII2_2 { get; set; }
        public int NDII3_1 { get; set; }
        public int NDII3_2 { get; set; }
        public int NDII4_1 { get; set; }
        public int NDII4_2 { get; set; }
        public int NDII5_1 { get; set; }
        public int NDII5_2 { get; set; }
        public int NDII5_3 { get; set; }
        public int NDII5_4 { get; set; }
        public int NDII5_5 { get; set; }
        public int NDII5_6 { get; set; }
        public int NDII5_7 { get; set; }
        public int NDII5_8 { get; set; }
        public int NDII5_9 { get; set; }
        public int NDII5_10 { get; set; }
        public int NDII5_11 { get; set; }
        public int NDII5_12 { get; set; }
        public int NDII6_1 { get; set; }
        public int NDII6_2 { get; set; }
        public int NDII6_3 { get; set; }
        public int NDII6_4 { get; set; }
        public int NDII6_5 { get; set; }
        public int NDII6_6 { get; set; }
        public int NDII6_7 { get; set; }
        public int NDII6_8 { get; set; }
        public string SoLuongRang { get; set; }
        public string LoaiThucAn { get; set; }
        public DateTime ThoiGianAn { get; set; }
        public string HuyetHoc { get; set; }
        public string HbsAg { get; set; }
        public string HCV { get; set; }
        [MoTaDuLieu("HIV")]
		public string HIV { get; set; }
        public string XetNghiem { get; set; }
        public string ChupChieuKhac { get; set; }
        public DateTime ThoiGianTiemThuoc { get; set; }
        public string DaTestDUngKS { get; set; }
        public bool[] ThuocTM_CheckArray { get; } = new bool[] { false, false, false, false };
        public int ThuocTM_Check
        {
            get
            {
                return Array.IndexOf(ThuocTM_CheckArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < ThuocTM_CheckArray.Length; i++)
                {
                    if (i == (value - 1)) ThuocTM_CheckArray[i] = true;
                    else ThuocTM_CheckArray[i] = false;
                }
            }
        }
        public string ThuocTM { get; set; }
        public double? Mach { get; set; }
        public string HAText { get; set; }
        public double? NhipTho { get; set; }
        public double? NhietDo { get; set; }
        public double? CanNang { get; set; }
        public double? ChieuCao { get; set; }
        public double? BMI { get; set; }
        public DateTime? ThoiGianDua { get; set; }
        public DateTime? TestCovidNhanh { get; set; }
        public DateTime? TestPCR { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        //public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }

    }
    public class PhieuCBBnTruocCTCuaDDFunc
    {
        public const string TableName = "PhieuCBBnTruocCTCuaDD";
        public const string TablePrimaryKeyName = "IDPhieu";
        public static List<PhieuCBBnTruocCTCuaDDTbl> GetListData(MDB.MDBConnection MyConnection, decimal MaQuanly)
        {
            try
            {
                {
                    List<PhieuCBBnTruocCTCuaDDTbl> lstObject = new List<PhieuCBBnTruocCTCuaDDTbl>();
                    string sql = "SELECT * FROM PhieuCBBnTruocCTCuaDD   WHERE MaQuanLy = :MaQuanLy ORDER BY IDPhieu DESC";
                    MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                    command.Parameters.Add(new MDB.MDBParameter("MaQuanly", MaQuanly));
                    MDB.MDBDataReader DataReader = command.ExecuteReader();
                    while (DataReader.Read())
                    {
                        PhieuCBBnTruocCTCuaDDTbl obj = new PhieuCBBnTruocCTCuaDDTbl();
                        obj.IDPhieu = Common.ConDB_Decimal(DataReader["IDPhieu"]);
                        obj.MaQuanLy = Common.ConDB_Decimal(DataReader["MaQuanLy"]);
                        obj.TenBenhNhan = Common.ConDBNull(DataReader["TenBenhNhan"]);
                        obj.NamSinh = Common.ConDBNull(DataReader["NamSinh"]);
                        obj.GioiTinh = Common.ConDBNull(DataReader["GioiTinh"]);
                        obj.ChanDoan = Common.ConDBNull(DataReader["ChanDoan"]);
                        obj.Khoa = Common.ConDBNull(DataReader["Khoa"]);
                        obj.CanThiep = Common.ConDB_Int(DataReader["CanThiep"]);
                        obj.Diung = Common.ConDB_Int(DataReader["Diung"]);
                        obj.ChiTietDiung = Common.ConDBNull(DataReader["ChiTietDiung"]);
                        obj.MaDDChuanBi = Common.ConDBNull(DataReader["MaDDChuanBi"]);
                        obj.TenDDChuanBi = Common.ConDBNull(DataReader["TenDDChuanBi"]);
                        obj.MaDDDua = Common.ConDBNull(DataReader["MaDDDua"]);
                        obj.TenDDDua = Common.ConDBNull(DataReader["TenDDDua"]);
                        obj.MaDDNhan = Common.ConDBNull(DataReader["MaDDNhan"]);
                        obj.TenDDNhan = Common.ConDBNull(DataReader["TenDDNhan"]);
                        obj.MaBenhNhan = Common.ConDBNull(DataReader["MaBenhNhan"]);
                        obj.MaKhoa = Common.ConDBNull(DataReader["MaKhoa"]);
                        obj.ppCanThiepDK = Common.ConDBNull(DataReader["ppCanThiepDK"]);
                        obj.NDI1_1 = Common.ConDB_Int(DataReader["NDI1_1"]);
                        obj.NDI1_2 = Common.ConDB_Int(DataReader["NDI1_2"]);
                        obj.NDI1_3 = Common.ConDB_Int(DataReader["NDI1_3"]);
                        obj.NDI1_4 = Common.ConDB_Int(DataReader["NDI1_4"]);
                        obj.NDI2_1 = Common.ConDB_Int(DataReader["NDI2_1"]);
                        obj.NDI2_2 = Common.ConDB_Int(DataReader["NDI2_2"]);
                        obj.NDI3_1 = Common.ConDB_Int(DataReader["NDI3_1"]);
                        obj.NDI3_2 = Common.ConDB_Int(DataReader["NDI3_2"]);
                        obj.NDI4_1 = Common.ConDB_Int(DataReader["NDI4_1"]);
                        obj.NDI4_2 = Common.ConDB_Int(DataReader["NDI4_2"]);
                        obj.NDI5_1 = Common.ConDB_Int(DataReader["NDI5_1"]);
                        obj.NDI5_2 = Common.ConDB_Int(DataReader["NDI5_2"]);
                        obj.NDI6_1 = Common.ConDB_Int(DataReader["NDI6_1"]);
                        obj.NDI6_2 = Common.ConDB_Int(DataReader["NDI6_2"]);
                        obj.NDI6_3 = Common.ConDB_Int(DataReader["NDI6_3"]);
                        obj.NDI6_4 = Common.ConDB_Int(DataReader["NDI6_4"]);
                        obj.NDI7_1 = Common.ConDB_Int(DataReader["NDI7_1"]);
                        obj.NDI7_2 = Common.ConDB_Int(DataReader["NDI7_2"]);
                        obj.NDI8_1 = Common.ConDB_Int(DataReader["NDI8_1"]);
                        obj.NDI8_2 = Common.ConDB_Int(DataReader["NDI8_2"]);
                        obj.NDI9_1 = Common.ConDB_Int(DataReader["NDI9_1"]);
                        obj.NDI9_2 = Common.ConDB_Int(DataReader["NDI9_2"]);
                        obj.NDI9_3 = Common.ConDB_Int(DataReader["NDI9_3"]);
                        obj.NDI9_4 = Common.ConDB_Int(DataReader["NDI9_4"]);
                        obj.NDI9_5 = Common.ConDB_Int(DataReader["NDI9_5"]);
                        obj.NDI9_6 = Common.ConDB_Int(DataReader["NDI9_6"]);
                        obj.NDI10_1 = Common.ConDB_Int(DataReader["NDI10_1"]);
                        obj.NDI10_2 = Common.ConDB_Int(DataReader["NDI10_2"]);
                        obj.NDI11_1 = Common.ConDB_Int(DataReader["NDI11_1"]);
                        obj.NDI11_2 = Common.ConDB_Int(DataReader["NDI11_2"]);
                        obj.NDI11_3 = Common.ConDB_Int(DataReader["NDI11_3"]);
                        obj.NDI11_4 = Common.ConDB_Int(DataReader["NDI11_4"]);
                        obj.NDII1_1 = Common.ConDB_Int(DataReader["NDII1_1"]);
                        obj.NDII1_2 = Common.ConDB_Int(DataReader["NDII1_2"]);
                        obj.NDII2_1 = Common.ConDB_Int(DataReader["NDII2_1"]);
                        obj.NDII2_2 = Common.ConDB_Int(DataReader["NDII2_2"]);
                        obj.NDII3_1 = Common.ConDB_Int(DataReader["NDII3_1"]);
                        obj.NDII3_2 = Common.ConDB_Int(DataReader["NDII3_2"]);
                        obj.NDII4_1 = Common.ConDB_Int(DataReader["NDII4_1"]);
                        obj.NDII4_2 = Common.ConDB_Int(DataReader["NDII4_2"]);
                        obj.NDII5_1 = Common.ConDB_Int(DataReader["NDII5_1"]);
                        obj.NDII5_2 = Common.ConDB_Int(DataReader["NDII5_2"]);
                        obj.NDII5_3 = Common.ConDB_Int(DataReader["NDII5_3"]);
                        obj.NDII5_4 = Common.ConDB_Int(DataReader["NDII5_4"]);
                        obj.NDII5_5 = Common.ConDB_Int(DataReader["NDII5_5"]);
                        obj.NDII5_6 = Common.ConDB_Int(DataReader["NDII5_6"]);
                        obj.NDII5_7 = Common.ConDB_Int(DataReader["NDII5_7"]);
                        obj.NDII5_8 = Common.ConDB_Int(DataReader["NDII5_8"]);
                        obj.NDII5_9 = Common.ConDB_Int(DataReader["NDII5_9"]);
                        obj.NDII5_10 = Common.ConDB_Int(DataReader["NDII5_10"]);
                        obj.NDII5_11 = Common.ConDB_Int(DataReader["NDII5_11"]);
                        obj.NDII5_12 = Common.ConDB_Int(DataReader["NDII5_12"]);
                        obj.NDII6_1 = Common.ConDB_Int(DataReader["NDII6_1"]);
                        obj.NDII6_2 = Common.ConDB_Int(DataReader["NDII6_2"]);
                        obj.NDII6_3 = Common.ConDB_Int(DataReader["NDII6_3"]);
                        obj.NDII6_4 = Common.ConDB_Int(DataReader["NDII6_4"]);
                        obj.NDII6_5 = Common.ConDB_Int(DataReader["NDII6_5"]);
                        obj.NDII6_6 = Common.ConDB_Int(DataReader["NDII6_6"]);
                        obj.NDII6_7 = Common.ConDB_Int(DataReader["NDII6_7"]);
                        obj.NDII6_8 = Common.ConDB_Int(DataReader["NDII6_8"]);
                        obj.SoLuongRang = Common.ConDBNull(DataReader["SoLuongRang"]);
                        obj.LoaiThucAn = Common.ConDBNull(DataReader["LoaiThucAn"]);
                        obj.ThoiGianAn = Common.ConDB_DateTime(DataReader["ThoiGianAn"]);
                        obj.HuyetHoc = Common.ConDBNull(DataReader["HuyetHoc"]);
                        obj.HbsAg = Common.ConDBNull(DataReader["HbsAg"]);
                        obj.HCV = Common.ConDBNull(DataReader["HCV"]);
                        obj.HIV = Common.ConDBNull(DataReader["HIV"]);
                        obj.XetNghiem = Common.ConDBNull(DataReader["XetNghiem"]);
                        obj.ChupChieuKhac = Common.ConDBNull(DataReader["ChupChieuKhac"]);
                        obj.ThoiGianTiemThuoc = Common.ConDB_DateTime(DataReader["ThoiGianTiemThuoc"]);
                        obj.DaTestDUngKS = Common.ConDBNull(DataReader["DaTestDUngKS"]);
                        obj.ThuocTM = Common.ConDBNull(DataReader["ThuocTM"]);
                        obj.Mach = Common.ConDBNull_float(DataReader["Mach"]);
                        obj.HAText = Common.ConDBNull(DataReader["HAText"]);
                        obj.NhipTho = Common.ConDBNull_float(DataReader["NhipTho"]);
                        obj.NhietDo = Common.ConDBNull_float(DataReader["NhietDo"]);
                        obj.CanNang = Common.ConDBNull_float(DataReader["CanNang"]);
                        obj.ChieuCao = Common.ConDBNull_float(DataReader["ChieuCao"]);
                        obj.BMI = Common.ConDBNull_float(DataReader["BMI"]);
                        obj.ThoiGianDua = Common.ConDB_DateTimeNull(DataReader["ThoiGianDua"]);
                        obj.NgayTao = Common.ConDB_DateTime(DataReader["NgayTao"]);
                        obj.NguoiTao = Common.ConDBNull(DataReader["NguoiTao"]);
                        obj.NgaySua = Common.ConDB_DateTime(DataReader["NgaySua"]);
                        obj.NguoiSua = Common.ConDBNull(DataReader["NguoiSua"]);
                        obj.MaSoKy = Common.ConDBNull(DataReader["MaSoKyTen"]);
                        int tempInt = 0;
                        obj.ThuocTM_Check = int.TryParse(DataReader["ThuocTM_Check"].ToString(), out tempInt) ? tempInt: 0;
                        obj.TestCovidNhanh = DataReader["TestCovidNhanh"] != DBNull.Value ? (DateTime?) Convert.ToDateTime(DataReader["TestCovidNhanh"]) : null;
                        obj.TestPCR = DataReader["TestPCR"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["TestPCR"]) : null;
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
            string sql = @"SELECT P.*, T.SoNhapVien,T.MaBenhAn, 
                H.TUOI,H.SoYTe, H.BENHVIEN, H.NgaySinh, H.NgheNghiep
                  FROM PhieuCBBnTruocCTCuaDD P 
                Left JOIN THONGTINDIEUTRI T ON P.MAQUANLY = T.MAQUANLY
                Left JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
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
            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection oracleConnection, PhieuCBBnTruocCTCuaDDTbl obj, ref bool isUpdate)
        {
            try
            {
                string sql = @"SELECT COUNT(*) RECNUM FROM PhieuCBBnTruocCTCuaDD WHERE IDPhieu  = :IDPhieu";
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
                    sql = "update PhieuCBBnTruocCTCuaDD set MaQuanLy=:MaQuanLy,TenBenhNhan=:TenBenhNhan,NamSinh=:NamSinh,GioiTinh=:GioiTinh,ChanDoan=:ChanDoan,Khoa=:Khoa,CanThiep=:CanThiep,Diung=:Diung,ChiTietDiung=:ChiTietDiung,MaDDChuanBi=:MaDDChuanBi,TenDDChuanBi=:TenDDChuanBi,MaDDDua=:MaDDDua,TenDDDua=:TenDDDua,MaDDNhan=:MaDDNhan,TenDDNhan=:TenDDNhan,MaBenhNhan=:MaBenhNhan,MaKhoa=:MaKhoa,ppCanThiepDK=:ppCanThiepDK,NDI1_1=:NDI1_1,NDI1_2=:NDI1_2,NDI1_3=:NDI1_3,NDI1_4=:NDI1_4,NDI2_1=:NDI2_1,NDI2_2=:NDI2_2,NDI3_1=:NDI3_1,NDI3_2=:NDI3_2,NDI4_1=:NDI4_1,NDI4_2=:NDI4_2,NDI5_1=:NDI5_1,NDI5_2=:NDI5_2,NDI6_1=:NDI6_1,NDI6_2=:NDI6_2,NDI6_3=:NDI6_3,NDI6_4=:NDI6_4,NDI7_1=:NDI7_1,NDI7_2=:NDI7_2,NDI8_1=:NDI8_1,NDI8_2=:NDI8_2,NDI9_1=:NDI9_1,NDI9_2=:NDI9_2,NDI9_3=:NDI9_3,NDI9_4=:NDI9_4,NDI9_5=:NDI9_5,NDI9_6=:NDI9_6,NDI10_1=:NDI10_1,NDI10_2=:NDI10_2,NDI11_1=:NDI11_1,NDI11_2=:NDI11_2,NDI11_3=:NDI11_3,NDI11_4=:NDI11_4,NDII1_1=:NDII1_1,NDII1_2=:NDII1_2,NDII2_1=:NDII2_1,NDII2_2=:NDII2_2,NDII3_1=:NDII3_1,NDII3_2=:NDII3_2,NDII4_1=:NDII4_1,NDII4_2=:NDII4_2,NDII5_1=:NDII5_1,NDII5_2=:NDII5_2,NDII5_3=:NDII5_3,NDII5_4=:NDII5_4,NDII5_5=:NDII5_5,NDII5_6=:NDII5_6,NDII5_7=:NDII5_7,NDII5_8=:NDII5_8,NDII5_9=:NDII5_9,NDII5_10=:NDII5_10,NDII5_11=:NDII5_11,NDII5_12=:NDII5_12,NDII6_1=:NDII6_1,NDII6_2=:NDII6_2,NDII6_3=:NDII6_3,NDII6_4=:NDII6_4,NDII6_5=:NDII6_5,NDII6_6=:NDII6_6,NDII6_7=:NDII6_7,NDII6_8=:NDII6_8,SoLuongRang=:SoLuongRang,LoaiThucAn=:LoaiThucAn,ThoiGianAn=:ThoiGianAn,HuyetHoc=:HuyetHoc,HbsAg=:HbsAg,HCV=:HCV,HIV=:HIV,XetNghiem=:XetNghiem,ChupChieuKhac=:ChupChieuKhac,ThoiGianTiemThuoc=:ThoiGianTiemThuoc,DaTestDUngKS=:DaTestDUngKS,ThuocTM=:ThuocTM,Mach=:Mach,HAText=:HAText,NhipTho=:NhipTho,NhietDo=:NhietDo,CanNang=:CanNang,ChieuCao=:ChieuCao,BMI=:BMI,ThoiGianDua=:ThoiGianDua,NgayTao=:NgayTao,NguoiTao=:NguoiTao,NgaySua=:NgaySua,NguoiSua=:NguoiSua, ThuocTM_Check=:ThuocTM_Check, TestCovidNhanh=:TestCovidNhanh, TestPCR=:TestPCR ";
                    sql = sql + " WHERE IDPhieu  = " + obj.IDPhieu.ToString();
                }
                else
                {
                    sql = @"insert into PhieuCBBnTruocCTCuaDD(MaQuanLy,TenBenhNhan,NamSinh,GioiTinh,ChanDoan,Khoa,CanThiep,Diung,ChiTietDiung,MaDDChuanBi,TenDDChuanBi,MaDDDua,TenDDDua,MaDDNhan,TenDDNhan,MaBenhNhan,MaKhoa,ppCanThiepDK,NDI1_1,NDI1_2,NDI1_3,NDI1_4,NDI2_1,NDI2_2,NDI3_1,NDI3_2,NDI4_1,NDI4_2,NDI5_1,NDI5_2,NDI6_1,NDI6_2,NDI6_3,NDI6_4,NDI7_1,NDI7_2,NDI8_1,NDI8_2,NDI9_1,NDI9_2,NDI9_3,NDI9_4,NDI9_5,NDI9_6,NDI10_1,NDI10_2,NDI11_1,NDI11_2,NDI11_3,NDI11_4,NDII1_1,NDII1_2,NDII2_1,NDII2_2,NDII3_1,NDII3_2,NDII4_1,NDII4_2,NDII5_1,NDII5_2,NDII5_3,NDII5_4,NDII5_5,NDII5_6,NDII5_7,NDII5_8,NDII5_9,NDII5_10,NDII5_11,NDII5_12,NDII6_1,NDII6_2,NDII6_3,NDII6_4,NDII6_5,NDII6_6,NDII6_7,NDII6_8,SoLuongRang,LoaiThucAn,ThoiGianAn,HuyetHoc,HbsAg,HCV,HIV,XetNghiem,ChupChieuKhac,ThoiGianTiemThuoc,DaTestDUngKS,ThuocTM,Mach,HAText,NhipTho,NhietDo,CanNang,ChieuCao,BMI,ThoiGianDua,NgayTao,NguoiTao,NgaySua,NguoiSua, ThuocTM_Check, TestCovidNhanh, TestPCR " +
                        ")";
                    sql = sql + @"Values(:MaQuanLy,:TenBenhNhan,:NamSinh,:GioiTinh,:ChanDoan,:Khoa,:CanThiep,:Diung,:ChiTietDiung,:MaDDChuanBi,:TenDDChuanBi,:MaDDDua,:TenDDDua,:MaDDNhan,:TenDDNhan,:MaBenhNhan,:MaKhoa,:ppCanThiepDK,:NDI1_1,:NDI1_2,:NDI1_3,:NDI1_4,:NDI2_1,:NDI2_2,:NDI3_1,:NDI3_2,:NDI4_1,:NDI4_2,:NDI5_1,:NDI5_2,:NDI6_1,:NDI6_2,:NDI6_3,:NDI6_4,:NDI7_1,:NDI7_2,:NDI8_1,:NDI8_2,:NDI9_1,:NDI9_2,:NDI9_3,:NDI9_4,:NDI9_5,:NDI9_6,:NDI10_1,:NDI10_2,:NDI11_1,:NDI11_2,:NDI11_3,:NDI11_4,:NDII1_1,:NDII1_2,:NDII2_1,:NDII2_2,:NDII3_1,:NDII3_2,:NDII4_1,:NDII4_2,:NDII5_1,:NDII5_2,:NDII5_3,:NDII5_4,:NDII5_5,:NDII5_6,:NDII5_7,:NDII5_8,:NDII5_9,:NDII5_10,:NDII5_11,:NDII5_12,:NDII6_1,:NDII6_2,:NDII6_3,:NDII6_4,:NDII6_5,:NDII6_6,:NDII6_7,:NDII6_8,:SoLuongRang,:LoaiThucAn,:ThoiGianAn,:HuyetHoc,:HbsAg,:HCV,:HIV,:XetNghiem,:ChupChieuKhac,:ThoiGianTiemThuoc,:DaTestDUngKS,:ThuocTM,:Mach,:HAText,:NhipTho,:NhietDo,:CanNang,:ChieuCao,:BMI,:ThoiGianDua,:NgayTao,:NguoiTao,:NgaySua,:NguoiSua, :ThuocTM_Check, :TestCovidNhanh, :TestPCR " +
                        ")   RETURNING IDPhieu INTO :IDPhieu";
                }
                oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaQuanLy", obj.MaQuanLy));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenBenhNhan", obj.TenBenhNhan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NamSinh", obj.NamSinh));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("GioiTinh", obj.GioiTinh));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ChanDoan", obj.ChanDoan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Khoa", obj.Khoa));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CanThiep", obj.CanThiep));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Diung", obj.Diung));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ChiTietDiung", obj.ChiTietDiung));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaDDChuanBi", obj.MaDDChuanBi));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenDDChuanBi", obj.TenDDChuanBi));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaDDDua", obj.MaDDDua));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenDDDua", obj.TenDDDua));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaDDNhan", obj.MaDDNhan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenDDNhan", obj.TenDDNhan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", obj.MaBenhNhan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaKhoa", obj.MaKhoa));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ppCanThiepDK", obj.ppCanThiepDK));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDI1_1", obj.NDI1_1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDI1_2", obj.NDI1_2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDI1_3", obj.NDI1_3));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDI1_4", obj.NDI1_4));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDI2_1", obj.NDI2_1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDI2_2", obj.NDI2_2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDI3_1", obj.NDI3_1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDI3_2", obj.NDI3_2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDI4_1", obj.NDI4_1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDI4_2", obj.NDI4_2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDI5_1", obj.NDI5_1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDI5_2", obj.NDI5_2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDI6_1", obj.NDI6_1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDI6_2", obj.NDI6_2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDI6_3", obj.NDI6_3));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDI6_4", obj.NDI6_4));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDI7_1", obj.NDI7_1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDI7_2", obj.NDI7_2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDI8_1", obj.NDI8_1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDI8_2", obj.NDI8_2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDI9_1", obj.NDI9_1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDI9_2", obj.NDI9_2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDI9_3", obj.NDI9_3));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDI9_4", obj.NDI9_4));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDI9_5", obj.NDI9_5));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDI9_6", obj.NDI9_6));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDI10_1", obj.NDI10_1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDI10_2", obj.NDI10_2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDI11_1", obj.NDI11_1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDI11_2", obj.NDI11_2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDI11_3", obj.NDI11_3));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDI11_4", obj.NDI11_4));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDII1_1", obj.NDII1_1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDII1_2", obj.NDII1_2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDII2_1", obj.NDII2_1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDII2_2", obj.NDII2_2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDII3_1", obj.NDII3_1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDII3_2", obj.NDII3_2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDII4_1", obj.NDII4_1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDII4_2", obj.NDII4_2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDII5_1", obj.NDII5_1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDII5_2", obj.NDII5_2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDII5_3", obj.NDII5_3));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDII5_4", obj.NDII5_4));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDII5_5", obj.NDII5_5));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDII5_6", obj.NDII5_6));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDII5_7", obj.NDII5_7));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDII5_8", obj.NDII5_8));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDII5_9", obj.NDII5_9));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDII5_10", obj.NDII5_10));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDII5_11", obj.NDII5_11));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDII5_12", obj.NDII5_12));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDII6_1", obj.NDII6_1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDII6_2", obj.NDII6_2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDII6_3", obj.NDII6_3));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDII6_4", obj.NDII6_4));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDII6_5", obj.NDII6_5));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDII6_6", obj.NDII6_6));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDII6_7", obj.NDII6_7));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NDII6_8", obj.NDII6_8));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("SoLuongRang", obj.SoLuongRang));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("LoaiThucAn", obj.LoaiThucAn));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ThoiGianAn", obj.ThoiGianAn));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("HuyetHoc", obj.HuyetHoc));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("HbsAg", obj.HbsAg));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("HCV", obj.HCV));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("HIV", obj.HIV));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("XetNghiem", obj.XetNghiem));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ChupChieuKhac", obj.ChupChieuKhac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ThoiGianTiemThuoc", obj.ThoiGianTiemThuoc));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DaTestDUngKS", obj.DaTestDUngKS));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ThuocTM", obj.ThuocTM));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Mach", obj.Mach));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("HAText", obj.HAText));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NhipTho", obj.NhipTho));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NhietDo", obj.NhietDo));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CanNang", obj.CanNang));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ChieuCao", obj.ChieuCao));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("BMI", obj.BMI));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ThoiGianDua", obj.ThoiGianDua));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayTao", obj.NgayTao));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiTao", obj.NguoiTao));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgaySua", DateTime.Now));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiSua", Common.getUserLogin()));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ThuocTM_Check", obj.ThuocTM_Check));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TestCovidNhanh", obj.TestCovidNhanh));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TestPCR", obj.TestPCR));

                if (!isUpdate)
                {
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
                sql = @"DELETE FROM PhieuCBBnTruocCTCuaDD WHERE  " + strWhere;
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
