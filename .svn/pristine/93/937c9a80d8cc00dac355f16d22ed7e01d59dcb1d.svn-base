using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using static EMR_MAIN.Report;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuTheoDoiChucNangSongTbl : ThongTinKy
    {
        public PhieuTheoDoiChucNangSongTbl()
        {
            TableName = "PhieuTheoDoiChucNangSong";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PTDCNS;
            TenMauPhieu = DanhMucPhieu.PTDCNS.Description();
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
        public string Ten
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
        public string SoNhapVien
        {
            get
            {
                return XemBenhAn._ThongTinDieuTri.SoNhapVien;
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
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi
        {
            get
            {
                return Common.GetDiaChi();
            }
        }
        public string Buong
        {
            get
            {
                return XemBenhAn._ThongTinDieuTri.Buong;
            }
        }
        public decimal SLChiTiet
        {
            get
            {
                if(ChiTiet == null)
                {
                    return 0;
                }
                else
                {
                    return ChiTiet.Count;
                }
                
            }
        }
        [MoTaDuLieu("Mã định danh")]
		public decimal IDPhieu { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; } 
        [MoTaDuLieu("Mã giường")]
		public string MaGiuong { set; get; }
        [MoTaDuLieu("Giường")]
		public string Giuong { get; set; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }    
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; } 
        public List<PhieuTheoDoiChucNangSong_ChiTiet> ChiTiet { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        //public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
        public int SoPhieu { get; set; } 
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        public PhieuTheoDoiChucNangSongTbl Clone()
        {
            PhieuTheoDoiChucNangSongTbl other = (PhieuTheoDoiChucNangSongTbl)this.MemberwiseClone();
            other.ChiTiet = new List<PhieuTheoDoiChucNangSong_ChiTiet>();
            if (this.ChiTiet != null)
                foreach (PhieuTheoDoiChucNangSong_ChiTiet item in this.ChiTiet)
                {
                    other.ChiTiet.Add(item.Clone());
                }
            return other;
        }
    }

    public class PhieuTheoDoiChucNangSong_ChiTiet
    {
        public PhieuTheoDoiChucNangSong_ChiTiet() { 

        }
        [MoTaDuLieu("Mã định danh")]
		public decimal IDPhieuCT { get; set; }
        [MoTaDuLieu("Mã định danh")]
		public decimal IDPhieu { set; get; }
        public DateTime ThoiGianThucHien { get; set; }
        public string ThoiGianThucHien_Text 
        { 
            get
            {
                return ThoiGianThucHien.ToString("dd/MM/yyyy HH:mm");
            }
        }
        public float? Mach { get; set; }
        public float? NhietDo { get; set; }
        public int? HuyetApMax { get; set; }
        public int? HuyetApMin { get; set; }
        [MoTaDuLieu("Cân nặng")]
		public string CanNang { get; set; }
        [MoTaDuLieu("Nhịp thở")]
		public string NhipTho { get; set; }
        [MoTaDuLieu("Người thực hiện")]
		public string NguoiThucHien { get; set; }
        [MoTaDuLieu("Mã người thực hiện")]
		public string MaNguoiThucHien { get; set; }
        public string GiaTri4 { get; set; }
        public string GiaTri5 { get; set; }
        public int SoTT { get; set; }
        public PhieuTheoDoiChucNangSong_ChiTiet Clone()
        {
            PhieuTheoDoiChucNangSong_ChiTiet other = (PhieuTheoDoiChucNangSong_ChiTiet)this.MemberwiseClone();
            return other;
        }
    }

    public class PhieuTheoDoiChucNangSongFunc
    {
        public const string TableName = "PhieuTheoDoiChucNangSong";
        public const string TableNameDetail = "PTheoDoiChucNangSong_CT";
        public const string TablePrimaryKeyName = "IDPhieu";
        public const string TablePrimaryKeyNameDetail = "IDPhieuCT";
        public static List<PhieuKy> listPhieuKy = null;
        public static bool checkRun = false;
        public List<PhieuTheoDoiChucNangSongTbl> Select(MDB.MDBConnection _OracleConnection, decimal MaQuanLy)
        {
            if (listPhieuKy == null && !checkRun)
            {
                DataPhieuKy dataPhieuKy = Report.GetPhieuKyHisPro(ERMDatabase.KyDienTu_ApplicationCode, XemBenhAn._ThongTinDieuTri.MaBenhAn, "PTDCNS");
                if (dataPhieuKy != null && dataPhieuKy.Data != null && dataPhieuKy.Data.Count > 0)
                {
                    listPhieuKy = dataPhieuKy.Data;
                }

                checkRun = true;
            }
            List<PhieuTheoDoiChucNangSongTbl> listPhieuTheoDoiChucNangSong = new List<PhieuTheoDoiChucNangSongTbl>();

            string sql = @"SELECT t.*
                    FROM PhieuTheoDoiChucNangSong t
                    WHERE t.MaQuanLy = :MaQuanLy ORDER BY t.NgayTao ASC";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
            Command.Parameters.Add("MaQuanLy", MDB.MDBType.Decimal).Value = MaQuanLy;
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            while (DataReader.Read())
            {
                var res = new PhieuTheoDoiChucNangSongTbl();
                res.IDPhieu = DataReader.GetDecimal("IDPhieu");
                res.MaQuanLy = Common.ConDB_Decimal(DataReader["MAQUANLY"]);
                res.MaKhoa = DataReader["MaKhoa"].ToString();
                res.MaGiuong = DataReader["MaGiuong"].ToString();
                res.Giuong = DataReader["Giuong"].ToString();
                res.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                res.Khoa = DataReader["KHOA"].ToString(); 
                res.ChanDoan = DataReader["CHANDOAN"].ToString();
                res.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);
                res.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                res.NguoiTao = DataReader["NGUOITAO"].ToString();
                res.NguoiSua = DataReader["NGUOISUA"].ToString();
                res.MaSoKy = DataReader["masokyten"].ToString();
                bool checkDelete = false;
                if (!string.IsNullOrEmpty(res.MaSoKy) && listPhieuKy != null)
                {
                    PhieuKy checkPhieu = listPhieuKy.Find(x => res.MaSoKy.Equals(x.HIS_CODE));
                    if (checkPhieu != null && checkPhieu.IS_DELETE == 1)
                    {
                        checkDelete = true;
                    }
                }
                res.DaKy = (!checkDelete && !string.IsNullOrEmpty(res.MaSoKy)) ? true : false;
                listPhieuTheoDoiChucNangSong.Add(res);
            }
            foreach (var res in listPhieuTheoDoiChucNangSong)
            {
                res.ChiTiet = new List<PhieuTheoDoiChucNangSong_ChiTiet>();
                res.ChiTiet = Select_PhieuCHiTiet(_OracleConnection, res.IDPhieu.ToString());
            }
            return listPhieuTheoDoiChucNangSong;
        }

        public bool Insert(MDB.MDBConnection _OracleConnection, PhieuTheoDoiChucNangSongTbl phieuTheoDoiChucNangSong) {
            try
            {
                //using (MDB.MDBConnection MyConnection = new MDB.MDBConnection(ERMDatabase.ConnectionString))
                {
                    string sql = @"INSERT INTO PhieuTheoDoiChucNangSong
                    (MAQUANLY, MaKhoa,MaGiuong, Giuong, MaBenhNhan, KHOA, CHANDOAN, NGAYSUA, NGAYTAO, NGUOITAO, NGUOISUA) VALUES
                    (:MaQuanLy, :MaKhoa, :MaGiuong, :Giuong, :MaBenhNhan, :Khoa, :ChanDoan, :NGAYSUA , :NGAYTAO , :NGUOITAO, :NGUOISUA ) RETURNING IDPhieu INTO :IDPhieu";

                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                    Command.Parameters.Add(":MaQuanLy", phieuTheoDoiChucNangSong.MaQuanLy);
                    Command.Parameters.Add(":MaKhoa", phieuTheoDoiChucNangSong.MaKhoa);
                    Command.Parameters.Add(":MaGiuong", phieuTheoDoiChucNangSong.MaGiuong);
                    Command.Parameters.Add(":Giuong", phieuTheoDoiChucNangSong.Giuong);
                    Command.Parameters.Add(":MaBenhNhan", phieuTheoDoiChucNangSong.MaBenhNhan);
                    Command.Parameters.Add(":Khoa", phieuTheoDoiChucNangSong.Khoa);
                    Command.Parameters.Add(":ChanDoan", phieuTheoDoiChucNangSong.ChanDoan);
                    Command.Parameters.Add(":NGAYSUA", DateTime.Now);
                    Command.Parameters.Add(":NGAYTAO", DateTime.Now);
                    Command.Parameters.Add(":NGUOITAO", Common.getUserLogin());
                    Command.Parameters.Add(":NGUOISUA", Common.getUserLogin());
                    Command.Parameters.Add(new MDB.MDBParameter("IDPhieu", phieuTheoDoiChucNangSong.IDPhieu));
                    int n = Command.ExecuteNonQuery();
                    if (phieuTheoDoiChucNangSong.IDPhieu == 0)
                    {
                        long nextval = Convert.ToInt64((Command.Parameters["IDPhieu"] as MDB.MDBParameter).Value);
                        phieuTheoDoiChucNangSong.IDPhieu = nextval;
                    }
                    return n > 0 ? true : false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Update(MDB.MDBConnection _OracleConnection, PhieuTheoDoiChucNangSongTbl phieuTheoDoiChucNangSong)
        {
            try
            {
                {

                    string sql = @"UPDATE PhieuTheoDoiChucNangSong SET 
                        MaQuanLy = :MaQuanLy, 
                        MaKhoa = :MaKhoa, MaGiuong = :MaGiuong, Giuong = :Giuong,
                        MaBenhNhan = :MaBenhNhan,
                        Khoa = :Khoa,
                        ChanDoan = :ChanDoan,
                        NGAYSUA = :NGAYSUA, 
                        NGAYTAO = :NGAYTAO, 
                        NGUOITAO = :NGUOITAO,
                        NGUOISUA = :NGUOISUA
                        WHERE IDPHIEU = " + phieuTheoDoiChucNangSong.IDPhieu;
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                    Command.Parameters.Add(":MaQuanLy", phieuTheoDoiChucNangSong.MaQuanLy);
                    Command.Parameters.Add(":MaKhoa", phieuTheoDoiChucNangSong.MaKhoa);
                    Command.Parameters.Add(":MaGiuong", phieuTheoDoiChucNangSong.MaGiuong);
                    Command.Parameters.Add(":Giuong", phieuTheoDoiChucNangSong.Giuong);
                    Command.Parameters.Add(":MaBenhNhan", phieuTheoDoiChucNangSong.MaBenhNhan);
                    Command.Parameters.Add(":Khoa", phieuTheoDoiChucNangSong.Khoa);
                    Command.Parameters.Add(":ChanDoan", phieuTheoDoiChucNangSong.ChanDoan);
                    Command.Parameters.Add(":NGAYSUA", phieuTheoDoiChucNangSong.NgaySua);
                    Command.Parameters.Add(":NGAYTAO", phieuTheoDoiChucNangSong.NgayTao);
                    Command.Parameters.Add(":NGUOITAO", phieuTheoDoiChucNangSong.NguoiTao);
                    Command.Parameters.Add(":NGUOISUA", phieuTheoDoiChucNangSong.NguoiSua);
                    int n = Command.ExecuteNonQuery();

                    return n > 0 ? true : false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Delete(MDB.MDBConnection _OracleConnection, decimal IDPhieu)
        {
            try
            {
                if (IDPhieu != 0)
                {
                    string sql = @"DELETE PhieuTheoDoiChucNangSong WHERE IDPhieu = :IDPhieu";
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                    Command.Parameters.Add(":IDPhieu", MDB.MDBType.Decimal).Value = IDPhieu;
                    int n = Command.ExecuteNonQuery();

                    return n > 0 ? true : false;
                }

            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }   
        public bool Delete_ChiTiet(MDB.MDBConnection MyConnection, decimal IDPhieuCT)
        {
            try
            {
                if (IDPhieuCT != 0)
                {
                    //string sql = @"Delete PhieuTheoDoiChucNangSong_ChiTiet WHERE (IDPhieuCT = :IDPhieuCT) "; //26/06/2021 Add by Hòa Issues 69147 vì Oracle 11 không tạo tên dài hơn 30 ký tự
                    string sql = @"Delete " + TableNameDetail + " WHERE (IDPhieuCT = :IDPhieuCT) ";
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add(":IDPhieuCT", MDB.MDBType.Decimal).Value = IDPhieuCT;
                    int n = Command.ExecuteNonQuery();

                    return true;
                }

            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static List<PhieuTheoDoiChucNangSong_ChiTiet> Select_PhieuCHiTiet(MDB.MDBConnection MyConnection, string IDPhieu, int ModOrder = 0)
        {
            try
            {
                List<PhieuTheoDoiChucNangSong_ChiTiet> listResult = new List<PhieuTheoDoiChucNangSong_ChiTiet>();
                //string sql = @"SELECT t.* FROM PhieuTheoDoiChucNangSong_ChiTiet t WHERE t.IDPhieu = :IDPhieu "; //26/06/2021 Add by Hòa Issues 69147 vì Oracle 11 không tạo tên dài hơn 30 ký tự
                string sql = @"SELECT t.* FROM " + TableNameDetail + " t WHERE t.IDPhieu = :IDPhieu ";
                sql = sql + " ORDER BY t.ThoiGianThucHien ASC";  
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add("IDPhieu", MDB.MDBType.Int).Value = IDPhieu;
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    var obj = new PhieuTheoDoiChucNangSong_ChiTiet();
                    obj.IDPhieuCT = Common.ConDB_Decimal(DataReader["IDPhieuCT"]);
                    obj.IDPhieu = Common.ConDB_Decimal(DataReader["IDPhieu"]);
                    obj.ThoiGianThucHien = Common.ConDB_DateTime(DataReader["ThoiGianThucHien"]);
                    obj.Mach = Common.ConDBNull_float(DataReader["Mach"]);
                    obj.NhietDo = Common.ConDBNull_float(DataReader["NhietDo"]);
                    obj.HuyetApMax = Common.ConDB_IntNull(DataReader["HuyetApMax"]);
                    obj.HuyetApMin = Common.ConDB_IntNull(DataReader["HuyetApMin"]);
                    obj.CanNang = Common.ConDBNull(DataReader["CanNang"]);
                    obj.NhipTho = Common.ConDBNull(DataReader["NhipTho"]);
                    obj.NguoiThucHien = Common.ConDBNull(DataReader["NguoiThucHien"]);
                    obj.MaNguoiThucHien = Common.ConDBNull(DataReader["MaNguoiThucHien"]);
                    obj.GiaTri4 = Common.ConDBNull(DataReader["GiaTri4"]);
                    obj.GiaTri5 = Common.ConDBNull(DataReader["GiaTri5"]);
                    listResult.Add(obj);
                }
                return listResult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool InsertOrUpdate_ChiTiet(MDB.MDBConnection MyConnection, PhieuTheoDoiChucNangSong_ChiTiet obj)
        {
            try
            {
                //string sql = @"update PhieuTheoDoiChucNangSong_ChiTiet set //26/06/2021 Add by Hòa Issues 69147 vì Oracle 11 không tạo tên dài hơn 30 ký tự
                string sql = @"update " + TableNameDetail + " set " +
                    "IDPhieu=:IDPhieu," +
                    "ThoiGianThucHien =:ThoiGianThucHien," +
                    "Mach =:Mach," +
                    "NhietDo =:NhietDo," +
                    "HuyetApMax =:HuyetApMax," +
                    "HuyetApMin =:HuyetApMin," +
                    "CanNang =:CanNang," +
                    "NhipTho =:NhipTho," +
                    "NguoiThucHien =:NguoiThucHien," +
                    "MaNguoiThucHien =:MaNguoiThucHien," +
                    "GiaTri4 =:GiaTri4," +
                    "GiaTri5 =:GiaTri5 " +
                    "WHERE IDPhieuCT = " + obj.IDPhieuCT + "";

                MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, MyConnection);
                oracleCommand.Parameters.Add("IDPhieu", obj.IDPhieu);
                oracleCommand.Parameters.Add("ThoiGianThucHien", obj.ThoiGianThucHien);
                oracleCommand.Parameters.Add("Mach", obj.Mach);
                oracleCommand.Parameters.Add("NhietDo", obj.NhietDo);
                oracleCommand.Parameters.Add("HuyetApMax", obj.HuyetApMax);
                oracleCommand.Parameters.Add("HuyetApMin", obj.HuyetApMin);
                oracleCommand.Parameters.Add("CanNang", obj.CanNang);
                oracleCommand.Parameters.Add("NhipTho", obj.NhipTho);
                oracleCommand.Parameters.Add("NguoiThucHien", obj.NguoiThucHien);
                oracleCommand.Parameters.Add("MaNguoiThucHien", obj.MaNguoiThucHien);
                oracleCommand.Parameters.Add("GiaTri4", obj.GiaTri4);
                oracleCommand.Parameters.Add("GiaTri5", obj.GiaTri5);
                int n = oracleCommand.ExecuteNonQuery();
                if (n == 0)
                {
                    oracleCommand.Dispose();
                    //sql = @"insert into PhieuTheoDoiChucNangSong_ChiTiet ( //26/06/2021 Add by Hòa Issues 69147 vì Oracle 11 không tạo tên dài hơn 30 ký tự
                    sql = @"insert into " + TableNameDetail + " ( " +
                    "IDPhieu, ThoiGianThucHien, Mach," +
                    "NhietDo, HuyetApMax, HuyetApMin," +
                    "CanNang, NhipTho, NguoiThucHien," +
                    "MaNguoiThucHien, GiaTri4, GiaTri5 " +
                    ") values ( " +
                    ":IDPhieu, :ThoiGianThucHien, :Mach, " +
                    ":NhietDo, :HuyetApMax, :HuyetApMin, " +
                    ":CanNang, :NhipTho, :NguoiThucHien, " +
                    ":MaNguoiThucHien, :GiaTri4, :GiaTri5" +
                    " )";
                    if (XemBenhAn.IsHis2 && MDB.Kind.PHANHE == MDB.PhienBanPhanMem.PostgreSQL)
                    {
                        sql += " RETURNING IDPhieuCT";
                    }
                    else
                    {
                        sql += " RETURNING IDPhieuCT INTO :IDPhieuCT";
                    }
                    oracleCommand = new MDB.MDBCommand(sql, MyConnection);
                    oracleCommand.Parameters.Add("IDPhieu", obj.IDPhieu);
                    oracleCommand.Parameters.Add("ThoiGianThucHien", obj.ThoiGianThucHien);
                    oracleCommand.Parameters.Add("Mach", obj.Mach);
                    oracleCommand.Parameters.Add("NhietDo", obj.NhietDo);
                    oracleCommand.Parameters.Add("HuyetApMax", obj.HuyetApMax);
                    oracleCommand.Parameters.Add("HuyetApMin", obj.HuyetApMin);
                    oracleCommand.Parameters.Add("CanNang", obj.CanNang);
                    oracleCommand.Parameters.Add("NhipTho", obj.NhipTho);
                    oracleCommand.Parameters.Add("NguoiThucHien", obj.NguoiThucHien);
                    oracleCommand.Parameters.Add("MaNguoiThucHien", obj.MaNguoiThucHien);
                    oracleCommand.Parameters.Add("GiaTri4", obj.GiaTri4);
                    oracleCommand.Parameters.Add("GiaTri5", obj.GiaTri5);
                    oracleCommand.Parameters.Add("IDPhieuCT", obj.IDPhieuCT);
                    decimal idphieuct = decimal.Zero;
                    if (XemBenhAn.IsHis2 && MDB.Kind.PHANHE == MDB.PhienBanPhanMem.PostgreSQL)
                    {
                        idphieuct = Convert.ToDecimal(oracleCommand.ExecuteScalar());
                        n = 1;
                    }
                    else
                    {
                        n = oracleCommand.ExecuteNonQuery();
                        idphieuct = Convert.ToDecimal((oracleCommand.Parameters["IDPhieuCT"] as MDB.MDBParameter).Value);
                    }
                    obj.IDPhieuCT = idphieuct;
                }
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, decimal IDPhieu)
        {
            var timer = new Stopwatch();
            StringBuilder sql = new StringBuilder();
            timer.Start();
            try
            {  
                sql.AppendLine(@"
                 SELECT P.*, '' SoNhapVien,'' MaBenhAn , '' TenBenhNhan,'' Buong,
                        '' TUOI,'' SoYTe, '' BENHVIEN, 
                        ''  GioiTinh
                  FROM PhieuTheoDoiChucNangSong P");
                sql.AppendLine(" WHERE P.IDPhieu = " + IDPhieu);  
                MDB.MDBCommand Command = new MDB.MDBCommand(sql.ToString(), MyConnection);
                MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
                var ds = new DataSet();
                adt.Fill(ds);
                if (ds != null || ds.Tables[0].Rows.Count > 0)
                {
                    ds.Tables[0].Rows[0]["SoNhapVien"] = XemBenhAn._ThongTinDieuTri.SoNhapVien;
                    ds.Tables[0].Rows[0]["MaBenhAn"] = XemBenhAn._ThongTinDieuTri.MaBenhAn;
                    ds.Tables[0].Rows[0]["Buong"] = XemBenhAn._ThongTinDieuTri.Buong;
                    ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    ds.Tables[0].Rows[0]["TUOI"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    ds.Tables[0].Rows[0]["SoYTe"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
                    ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
                    ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                }
                return ds;
            }
            catch (Exception ex)
            {
                MDB.ExceptionExtend.LogError(ex);
                return null;
            }
            finally
            {
                timer.Stop();
            }
        }
    }
}
