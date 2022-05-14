using EMR.KyDienTu;
using System;
using System.Collections.Generic;
using System.Data;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuDGDDNguoiBenhNhapVienICU : ThongTinKy
    {
        public PhieuDGDDNguoiBenhNhapVienICU()
        {
            TableName = "PhieuDGDDNguoiBenhNhapVienICU";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PDGDDNBNVICU;
            TenMauPhieu = DanhMucPhieu.PDGDDNBNVICU.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long IDPhieu { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        public double? ChieuCao { get; set; }
        public double? CanNang { get; set; }
        public double? BMI { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public bool SLBDLoai1_Co { get; set; }
        public bool SLBDLoai1_Ko { get; set; }
        public bool SLBDLoai2_Co { get; set; }
        public bool SLBDLoai2_Ko { get; set; }
        public bool SLBDLoai3_Co { get; set; }
        public bool SLBDLoai3_Ko { get; set; }
        public bool SLBDLoai4_Co { get; set; }
        public bool SLBDLoai4_Ko { get; set; }
        public int? TTSDDDiem { get; set; }
        public int? TTBLDiem { get; set; }
        public int? TongDiemTamSoat2 { get; set; }
        public int? TongDiem { get; set; }
        public int NhuCauDD { get; set; }
        public double NhuCau_Calo { get; set; }
        public double NhuCau_Dam { get; set; }
        public double NhuCau_Duong { get; set; }
        public double NhuCau_Beo { get; set; }
        public string MaCheDoAn { get; set; }
        public int DuongNuoiDuong { get; set; }
        public int TuVanDD { get; set; }
        public int BoXungONS { get; set; }
        public int DanhGiaLai { get; set; }
        public string DanhGiaTTDD { get; set; }
        public string KeHoachDD_CheDoAn { get; set; }
        public string BoXungONS_TXT { get; set; }
        public bool[] KeHoachDDArray { get; } = new bool[] { false, false, false, false};
        public string KeHoachDD
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < KeHoachDDArray.Length; i++)
                    temp += (KeHoachDDArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        KeHoachDDArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public int DiemTuoi { get; set; }
        public int TTDDSuyGiam { get; set; }
        public int DoNangBenhLy { get; set; }
        public int TaiDGDDNgay { get; set; }
        public string GhiChu { get; set; }
        public string MaNguoiThucHien { get; set; }
        public string NguoiThucHien { get; set; }
        public DateTime? NgayLapPhieu { get; set; }

        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }

        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        //public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
    }
    public class PhieuDGDDNguoiBenhNhapVienICUFunc
    {
#if HIS2       
        public const string TableName = "PDGDDNBNVICU"; //25/06/2021 Add by Hòa Issues 60582 vì Oracle 11 không tạo tên dài hơn 30 ký tự
#else
        public const string TableName = "PhieuDGDDNguoiBenhNhapVienICU";
#endif
        public const string TablePrimaryKeyName = "IDPhieu";
        public static List<PhieuDGDDNguoiBenhNhapVienICU> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuDGDDNguoiBenhNhapVienICU> list = new List<PhieuDGDDNguoiBenhNhapVienICU>();
            try
            {
                //string sql = @"SELECT * FROM PhieuDGDDNguoiBenhNhapVienICU where MaQuanLy = :MaQuanLy"; //26/06/2021 Close by Hòa Issues 60582
                string sql = @"SELECT * FROM " + TableName + " where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    try
                    {
                        PhieuDGDDNguoiBenhNhapVienICU data = new PhieuDGDDNguoiBenhNhapVienICU();
                        data.IDPhieu = DataReader.GetLong("IDPhieu");
                        data.MaQuanLy = DataReader.GetDecimal("MaQuanLy");
                        data.MaBenhNhan = DataReader.GetString("MaBenhNhan");
                        data.TenBenhNhan = DataReader.GetString("TenBenhNhan");
                        data.CanNang = Convert.ToDouble(DataReader.GetDecimal("CanNang"));
                        data.ChieuCao = Convert.ToDouble(DataReader.GetDecimal("ChieuCao"));
                        data.BMI = Convert.ToDouble(DataReader.GetDecimal("BMI"));
                        data.ChanDoan = DataReader.GetString("ChanDoan");
                        data.SLBDLoai1_Co = Common.ConDBNull(DataReader["SLBDLoai1_Co"]).Equals("1") ? true : false;
                        data.SLBDLoai1_Ko = Common.ConDBNull(DataReader["SLBDLoai1_Ko"]).Equals("1") ? true : false;
                        data.SLBDLoai2_Co = Common.ConDBNull(DataReader["SLBDLoai2_Co"]).Equals("1") ? true : false;
                        data.SLBDLoai2_Ko = Common.ConDBNull(DataReader["SLBDLoai2_Ko"]).Equals("1") ? true : false;
                        data.SLBDLoai3_Co = Common.ConDBNull(DataReader["SLBDLoai3_Co"]).Equals("1") ? true : false;
                        data.SLBDLoai3_Ko = Common.ConDBNull(DataReader["SLBDLoai3_Ko"]).Equals("1") ? true : false;
                        data.SLBDLoai4_Co = Common.ConDBNull(DataReader["SLBDLoai4_Co"]).Equals("1") ? true : false;
                        data.SLBDLoai4_Ko = Common.ConDBNull(DataReader["SLBDLoai4_Ko"]).Equals("1") ? true : false;
                        data.TTSDDDiem = Common.ConDB_Int(DataReader["TTSDDDiem"]);
                        data.TTBLDiem = Common.ConDB_Int(DataReader["TTBLDiem"]);
                        data.TongDiemTamSoat2 = Common.ConDB_Int(DataReader["TongDiemTamSoat2"]);
                        data.TongDiem = Common.ConDB_Int(DataReader["TongDiem"]);
                        data.NhuCauDD = DataReader.GetInt("NhuCauDD");
                        data.NhuCau_Calo = Common.ConDB_float(DataReader["NhuCau_Calo"]);
                        data.NhuCau_Dam = Common.ConDB_float(DataReader["NhuCau_Dam"]);
                        data.NhuCau_Beo = Common.ConDB_float(DataReader["NhuCau_Beo"]);
                        data.NhuCau_Duong = Common.ConDB_float(DataReader["NhuCau_Duong"]);
                        data.MaCheDoAn = DataReader.GetString("MaCheDoAn");
                        data.KeHoachDD = DataReader.GetString("KeHoachDD");
                        data.TaiDGDDNgay = DataReader.GetInt("TaiDGDDNgay");
                        data.NguoiTao = DataReader.GetString("NguoiTao");
                        data.NguoiSua = DataReader.GetString("NguoiSua");
                        data.NgayTao = ConDB_DateTime(DataReader["NgayTao"]);
                        data.NgaySua = ConDB_DateTime(DataReader["NgaySua"]);
                        data.MaSoKy = DataReader.GetString("masokyten");
                        data.NgayKy = DataReader.GetDate("ngayky");
                        data.TenFileKy = DataReader.GetString("tenfileky");
                        data.UserNameKy = DataReader.GetString("usernameky");
                        data.ComputerKyTen = DataReader.GetString("COMPUTERKYTEN");

                        //dunglm thay doi
                        data.TTDDSuyGiam = DataReader.GetInt("TTDDSuyGiam");
                        data.DiemTuoi = DataReader.GetInt("DiemTuoi");
                        data.DoNangBenhLy = DataReader.GetInt("DoNangBenhLy");
                        data.DanhGiaTTDD = DataReader.GetString("DanhGiaTTDD");
                        data.KeHoachDD_CheDoAn = DataReader.GetString("KeHoachDD_CheDoAn");
                        data.DuongNuoiDuong = DataReader.GetInt("DuongNuoiDuong");
                        data.TuVanDD = DataReader.GetInt("TuVanDD");
                        data.BoXungONS = DataReader.GetInt("BoXungONS");
                        data.DanhGiaLai = DataReader.GetInt("DanhGiaLai");
                        data.GhiChu = DataReader.GetString("GhiChu");
                        data.BoXungONS_TXT = DataReader.GetString("BoXungONS_TXT");
                        data.MaNguoiThucHien = DataReader.GetString("MaNguoiThucHien");
                        data.NguoiThucHien = DataReader.GetString("NguoiThucHien");
                        data.NgayLapPhieu = DataReader["NgayLapPhieu"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayLapPhieu"]) : null;

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
        public static PhieuDGDDNguoiBenhNhapVienICU GeData(MDB.MDBConnection MyConnection, decimal MaQuanly)
        {
            try
            {
                {
                    PhieuDGDDNguoiBenhNhapVienICU data = new PhieuDGDDNguoiBenhNhapVienICU();
                    string sql = @"SELECT t.* FROM "+ TableName + " t WHERE t.MaQuanLy = :MaQuanLy";
                    //string sql = @"SELECT t.* FROM PhieuDGDDNguoiBenhNhapVienICU t WHERE t.MaQuanLy = :MaQuanLy";//26/06/2021 Close by Hòa Issues 60582
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanly));
                    MDB.MDBDataReader DataReader = Command.ExecuteReader();
                    while (DataReader.Read())
                    {
                        data.IDPhieu = DataReader.GetLong("IDPhieu");
                        data.MaQuanLy = DataReader.GetDecimal("MaQuanLy");
                        data.MaBenhNhan = DataReader.GetString("MaBenhNhan");
                        data.TenBenhNhan = DataReader.GetString("TenBenhNhan");
                        data.CanNang = Convert.ToDouble(DataReader.GetDecimal("CanNang"));
                        data.ChieuCao = Convert.ToDouble(DataReader.GetDecimal("ChieuCao"));
                        data.BMI = Convert.ToDouble(DataReader.GetDecimal("BMI"));
                        data.ChanDoan = DataReader.GetString("ChanDoan");
                        data.SLBDLoai1_Co = Common.ConDBNull(DataReader["SLBDLoai1_Co"]).Equals("1") ? true : false;
                        data.SLBDLoai1_Ko = Common.ConDBNull(DataReader["SLBDLoai1_Ko"]).Equals("1") ? true : false;
                        data.SLBDLoai2_Co = Common.ConDBNull(DataReader["SLBDLoai2_Co"]).Equals("1") ? true : false;
                        data.SLBDLoai2_Ko = Common.ConDBNull(DataReader["SLBDLoai2_Ko"]).Equals("1") ? true : false;
                        data.SLBDLoai3_Co = Common.ConDBNull(DataReader["SLBDLoai3_Co"]).Equals("1") ? true : false;
                        data.SLBDLoai3_Ko = Common.ConDBNull(DataReader["SLBDLoai3_Ko"]).Equals("1") ? true : false;
                        data.SLBDLoai4_Co = Common.ConDBNull(DataReader["SLBDLoai4_Co"]).Equals("1") ? true : false;
                        data.SLBDLoai4_Ko = Common.ConDBNull(DataReader["SLBDLoai4_Ko"]).Equals("1") ? true : false;
                        data.TTSDDDiem = Common.ConDB_Int(DataReader["TTSDDDiem"]);
                        data.TTBLDiem = Common.ConDB_Int(DataReader["TTBLDiem"]);
                        data.TongDiemTamSoat2 = Common.ConDB_Int(DataReader["TongDiemTamSoat2"]);
                        data.TongDiem = Common.ConDB_Int(DataReader["TongDiem"]);
                        data.NhuCauDD = DataReader.GetInt("NhuCauDD");
                        data.NhuCau_Calo = Common.ConDB_float(DataReader["NhuCau_Calo"]);
                        data.NhuCau_Dam = Common.ConDB_float(DataReader["NhuCau_Dam"]);
                        data.NhuCau_Beo = Common.ConDB_float(DataReader["NhuCau_Beo"]);
                        data.NhuCau_Duong = Common.ConDB_float(DataReader["NhuCau_Duong"]);
                        data.MaCheDoAn = DataReader.GetString("MaCheDoAn");
                        data.KeHoachDD = DataReader.GetString("KeHoachDD");
                        data.TaiDGDDNgay = DataReader.GetInt("TaiDGDDNgay");
                        data.NguoiTao = DataReader.GetString("NguoiTao");
                        data.NguoiSua = DataReader.GetString("NguoiSua");
                        data.NgayTao = ConDB_DateTime(DataReader["NgayTao"]);
                        data.NgaySua = ConDB_DateTime(DataReader["NgaySua"]);
                        data.MaSoKy = DataReader.GetString("masokyten");
                        data.NgayKy = DataReader.GetDate("ngayky");
                        data.TenFileKy = DataReader.GetString("tenfileky");
                        data.UserNameKy = DataReader.GetString("usernameky");
                        data.ComputerKyTen = DataReader.GetString("COMPUTERKYTEN");
                        //dunglm thay doi
                        data.TTDDSuyGiam = DataReader.GetInt("TTDDSuyGiam");
                        data.DiemTuoi = DataReader.GetInt("DiemTuoi");
                        data.DoNangBenhLy = DataReader.GetInt("DoNangBenhLy");
                        data.DanhGiaTTDD = DataReader.GetString("DanhGiaTTDD");
                        data.KeHoachDD_CheDoAn = DataReader.GetString("KeHoachDD_CheDoAn");
                        data.DuongNuoiDuong = DataReader.GetInt("DuongNuoiDuong");
                        data.TuVanDD = DataReader.GetInt("TuVanDD");
                        data.BoXungONS = DataReader.GetInt("BoXungONS");
                        data.DanhGiaLai = DataReader.GetInt("DanhGiaLai");
                        data.GhiChu = DataReader.GetString("GhiChu");
                        data.BoXungONS_TXT = DataReader.GetString("BoXungONS_TXT");
                        data.MaNguoiThucHien = DataReader.GetString("MaNguoiThucHien");
                        data.NguoiThucHien = DataReader.GetString("NguoiThucHien");
                        data.NgayLapPhieu = DataReader["NgayLapPhieu"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayLapPhieu"]) : null;
                    }

                    return data;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, decimal IDBienBan)
        {
            string sql = @"SELECT P.*, T.SoNhapVien,T.MaBenhAn, H.TUOI,H.SoYTe, H.BENHVIEN, H.NgaySinh, H.NgheNghiep FROM " + TableName + " P Left JOIN THONGTINDIEUTRI T ON P.MAQUANLY = T.MAQUANLY Left JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN where IDPhieu  = :IDPhieu";
            //string sql = @"SELECT P.*, T.SoNhapVien,T.MaBenhAn, H.TUOI,H.SoYTe, H.BENHVIEN, H.NgaySinh, H.NgheNghiep FROM PhieuDGDDNguoiBenhNhapVienICU P Left JOIN THONGTINDIEUTRI T ON P.MAQUANLY = T.MAQUANLY Left JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN where IDPhieu  = :IDPhieu"; //26/06/2021 Close by Hòa Issues 60582
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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuDGDDNguoiBenhNhapVienICU obj)
        {
            try
            {
                //string sql = @"INSERT INTO PhieuDGDDNguoiBenhNhapVienICU //26/06/2021 Close by Hòa Issues 60582
                string sql = "INSERT INTO " + TableName +
                "( maquanly, mabenhnhan, tenbenhnhan, " +
                    "cannang, chieucao, bmi, " +
                    "chandoan, slbdloai1_co, slbdloai1_ko, " +
                    "slbdloai2_co, slbdloai2_ko, slbdloai3_co, " +
                    "slbdloai3_ko, slbdloai4_co, slbdloai4_ko, " +
                    "ttsdddiem, ttbldiem, tongdiemtamsoat2, " +
                    "tongdiem, nhucaudd, nhucau_calo," +
                    "nhucau_dam, nhucau_duong, nhucau_beo," +
                    "machedoan, kehoachdd, taidgddngay," +
                    "ngaytao, nguoitao, " +
                    "ttddsuygiam,diemtuoi,donangbenhly,danhgiattdd,kehoachdd_chedoan, " +
                    "duongnuoiduong,tuvandd,boxungons, danhgialai,ghichu,boxungons_txt, " +
                    "MaNguoiThucHien,NguoiThucHien,NgayLapPhieu " +
                 ")  VALUES" +
                 "( :maquanly, :mabenhnhan, :tenbenhnhan, " +
                    ":cannang, :chieucao, :bmi, " +
                    ":chandoan, :slbdloai1_co, :slbdloai1_ko, " +
                    ":slbdloai2_co, :slbdloai2_ko, :slbdloai3_co, " +
                    ":slbdloai3_ko, :slbdloai4_co, :slbdloai4_ko, " +
                    ":ttsdddiem, :ttbldiem, :tongdiemtamsoat2, " +
                    ":tongdiem, :nhucaudd, :nhucau_calo, " +
                    ":nhucau_dam, :nhucau_duong, :nhucau_beo, " +
                    ":machedoan, :kehoachdd, :taidgddngay, " +
                    ":ngaytao, :nguoitao, " +
                    ":ttddsuygiam,:diemtuoi,:donangbenhly,:danhgiattdd," +
                    ":kehoachdd_chedoan,:duongnuoiduong,:tuvandd,:boxungons,:danhgialai,:ghichu,:boxungons_txt," +
                    ":MaNguoiThucHien,:NguoiThucHien,:NgayLapPhieu " +
                 ")  RETURNING IDPHIEU INTO :IDPHIEU";
                if (obj.IDPhieu != 0)
                {
                    //sql = @"UPDATE PhieuDGDDNguoiBenhNhapVienICU SET //26/06/2021 Close by Hòa Issues 60582
                    sql = @"UPDATE " + TableName + " SET " +
                    "maquanly =:maquanly, mabenhnhan=:mabenhnhan, tenbenhnhan=:tenbenhnhan, " +
                    "cannang =:cannang, chieucao=:chieucao, bmi=:bmi, " +
                    "chandoan =:chandoan, slbdloai1_co=:slbdloai1_co, slbdloai1_ko=:slbdloai1_ko, " +
                    "slbdloai2_co =:slbdloai2_co, slbdloai2_ko=:slbdloai2_ko, slbdloai3_co=:slbdloai3_co, " +
                    "slbdloai3_ko =:slbdloai3_ko, slbdloai4_co=:slbdloai4_co, slbdloai4_ko=:slbdloai4_ko, " +
                    "ttsdddiem =:ttsdddiem, ttbldiem=:ttbldiem, tongdiemtamsoat2=:tongdiemtamsoat2, " +
                    "tongdiem =:tongdiem, nhucaudd=:nhucaudd, nhucau_calo=:nhucau_calo, " +
                    "nhucau_dam =:nhucau_dam, nhucau_duong=:nhucau_duong, nhucau_beo=:nhucau_beo, " +
                    "machedoan =:machedoan, kehoachdd=:kehoachdd, taidgddngay=:taidgddngay, " +
                    "NGUOISUA = :NGUOISUA, NGAYSUA = :NGAYSUA, " +
                    "ttddsuygiam =:ttddsuygiam,diemtuoi=:diemtuoi,donangbenhly=:donangbenhly,danhgiattdd=:danhgiattdd," +
                    "kehoachdd_chedoan=:kehoachdd_chedoan, duongnuoiduong=:duongnuoiduong,tuvandd=:tuvandd," +
                    "boxungons=:boxungons, danhgialai=:danhgialai,ghichu=:ghichu,boxungons_txt=:boxungons_txt," +
                    "MaNguoiThucHien=:MaNguoiThucHien,NguoiThucHien=:NguoiThucHien,NgayLapPhieu=:NgayLapPhieu  " +
                    "WHERE IDPHIEU = " + obj.IDPhieu;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("maquanly", obj.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("mabenhnhan", obj.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("tenbenhnhan", obj.TenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("cannang", obj.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("chieucao", obj.ChieuCao));
                Command.Parameters.Add(new MDB.MDBParameter("bmi", obj.BMI));
                Command.Parameters.Add(new MDB.MDBParameter("chandoan", obj.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("slbdloai1_co", obj.SLBDLoai1_Co == true ? 1:0));
                Command.Parameters.Add(new MDB.MDBParameter("slbdloai1_ko", obj.SLBDLoai1_Ko == true ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("slbdloai2_co", obj.SLBDLoai2_Co == true ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("slbdloai2_ko", obj.SLBDLoai2_Ko == true ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("slbdloai3_co", obj.SLBDLoai3_Co == true ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("slbdloai3_ko", obj.SLBDLoai3_Ko == true ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("slbdloai4_co", obj.SLBDLoai4_Co == true ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("slbdloai4_ko", obj.SLBDLoai4_Ko == true ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("ttsdddiem", obj.TTSDDDiem));
                Command.Parameters.Add(new MDB.MDBParameter("ttbldiem", obj.TTBLDiem));
                Command.Parameters.Add(new MDB.MDBParameter("tongdiemtamsoat2", obj.TongDiemTamSoat2));
                Command.Parameters.Add(new MDB.MDBParameter("tongdiem", obj.TongDiem));
                Command.Parameters.Add(new MDB.MDBParameter("nhucaudd", obj.NhuCauDD));
                Command.Parameters.Add(new MDB.MDBParameter("nhucau_calo", obj.NhuCau_Calo));
                Command.Parameters.Add(new MDB.MDBParameter("nhucau_dam", obj.NhuCau_Dam));
                Command.Parameters.Add(new MDB.MDBParameter("nhucau_duong", obj.NhuCau_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("nhucau_beo", obj.NhuCau_Beo));
                Command.Parameters.Add(new MDB.MDBParameter("machedoan", obj.MaCheDoAn));
                Command.Parameters.Add(new MDB.MDBParameter("kehoachdd", obj.KeHoachDD));
                Command.Parameters.Add(new MDB.MDBParameter("taidgddngay", obj.TaiDGDDNgay));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", obj.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", obj.NgaySua));
                //dunglm them moi
                Command.Parameters.Add(new MDB.MDBParameter("ttddsuygiam", obj.TTDDSuyGiam));
                Command.Parameters.Add(new MDB.MDBParameter("diemtuoi", obj.DiemTuoi));
                Command.Parameters.Add(new MDB.MDBParameter("donangbenhly", obj.DoNangBenhLy));
                Command.Parameters.Add(new MDB.MDBParameter("danhgiattdd", obj.DanhGiaTTDD));
                Command.Parameters.Add(new MDB.MDBParameter("kehoachdd_chedoan", obj.KeHoachDD_CheDoAn));
                Command.Parameters.Add(new MDB.MDBParameter("duongnuoiduong", obj.DuongNuoiDuong));
                Command.Parameters.Add(new MDB.MDBParameter("tuvandd", obj.TuVanDD));
                Command.Parameters.Add(new MDB.MDBParameter("boxungons", obj.BoXungONS));
                Command.Parameters.Add(new MDB.MDBParameter("danhgialai", obj.DanhGiaLai));
                Command.Parameters.Add(new MDB.MDBParameter("ghichu", obj.GhiChu));
                Command.Parameters.Add(new MDB.MDBParameter("boxungons_txt", obj.BoXungONS_TXT));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiThucHien", obj.MaNguoiThucHien));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiThucHien", obj.NguoiThucHien));
                Command.Parameters.Add(new MDB.MDBParameter("NgayLapPhieu", obj.NgayLapPhieu));
                if (obj.IDPhieu == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("IDPHIEU", obj.IDPhieu));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", obj.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", obj.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (obj.IDPhieu == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["IDPHIEU"] as MDB.MDBParameter).Value);
                    obj.IDPhieu = nextval;
                }
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool DeleteByIDPhieu(MDB.MDBConnection oracleConnection, decimal IDBienBan)
        {
            try
            {
                string sql = "";
                MDB.MDBCommand oracleCommand;
                sql = @"DELETE FROM " + TableName + " WHERE IDPhieu  = " + IDBienBan.ToString();
                //sql = @"DELETE FROM PhieuDGDDNguoiBenhNhapVienICU WHERE IDPhieu  = " + IDBienBan.ToString(); //26/06/2021 Close by Hòa Issues 60582
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
