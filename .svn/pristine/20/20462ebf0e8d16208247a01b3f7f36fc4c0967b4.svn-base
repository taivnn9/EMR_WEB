using EMR.KyDienTu;
using MDB;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows;
using static EMR_MAIN.Report;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuTheoDoiChucNangSong2Tbl : ThongTinKy
    {
        [MoTaDuLieu("Sở Y Tế")]
        public string SoYTe
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.SoYTe;
            }
        }
        [MoTaDuLieu("Bệnh viện")]
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
        public List<PhieuTheoDoiChucNangSong2_ChiTiet> ChiTiet { get; set; }
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
        public PhieuTheoDoiChucNangSong2Tbl Clone()
        {
            PhieuTheoDoiChucNangSong2Tbl other = (PhieuTheoDoiChucNangSong2Tbl)this.MemberwiseClone();
            other.ChiTiet = new List<PhieuTheoDoiChucNangSong2_ChiTiet>();
            if (this.ChiTiet != null)
                foreach (PhieuTheoDoiChucNangSong2_ChiTiet item in this.ChiTiet)
                {
                    other.ChiTiet.Add(item.Clone());
                }
            return other;
        }
    }

    public class PhieuTheoDoiChucNangSong2_ChiTiet
    {
        public PhieuTheoDoiChucNangSong2_ChiTiet() { 

        }
        [MoTaDuLieu("Mã định danh chi tiết phiếu")]
		public decimal IDPhieuCT { get; set; }
        [MoTaDuLieu("Mã định danh phiếu")]
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
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
        public PhieuTheoDoiChucNangSong2_ChiTiet Clone()
        {
            PhieuTheoDoiChucNangSong2_ChiTiet other = (PhieuTheoDoiChucNangSong2_ChiTiet)this.MemberwiseClone();
            return other;
        }
    }

    public class PhieuTheoDoiChucNangSong2Func
    {
        public const string TableName = "PTheoDoiChucNangSong_CT";
        public const string TableNameDetail = "PTheoDoiChucNangSong_CT";
        public const string TablePrimaryKeyName = "IDPhieu";
        public const string TablePrimaryKeyNameDetail = "IDPhieuCT";
        public const string MaPhieu = "PTDCNS";

        public List<PhieuTheoDoiChucNangSong2Tbl> Select(MDB.MDBConnection _OracleConnection, decimal MaQuanLy)
        {

            List<PhieuTheoDoiChucNangSong2Tbl> listPhieuTheoDoiChucNangSong2 = new List<PhieuTheoDoiChucNangSong2Tbl>();

            string sql = @"SELECT t.*
                    FROM PhieuTheoDoiChucNangSong t
                    WHERE t.MaQuanLy = :MaQuanLy ORDER BY t.NgayTao ASC";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            while (DataReader.Read())
            {
                var res = new PhieuTheoDoiChucNangSong2Tbl();
                res.IDPhieu = DataReader.GetDecimal("IDPhieu");
                res.MaQuanLy = Common.ConDB_Decimal(DataReader["MAQUANLY"]);
                res.MaKhoa = DataReader["MaKhoa"].ToString();
                res.MaGiuong = DataReader["MaGiuong"].ToString();
                res.Giuong = DataReader["Giuong"].ToString();
                res.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                res.Khoa = DataReader["KHOA"].ToString(); 
                res.ChanDoan = DataReader["CHANDOAN"].ToString();

                try {
                    res.ChiTiet = new List<PhieuTheoDoiChucNangSong2_ChiTiet>();
                    res.ChiTiet = Select_PhieuCHiTiet(_OracleConnection, res.IDPhieu.ToString());
                }
                catch (Exception e) {
                    XuLyLoi.Handle(e);
                } 
                res.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);
                res.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                res.NguoiTao = DataReader["NGUOITAO"].ToString();
                res.NguoiSua = DataReader["NGUOISUA"].ToString();
                res.MaSoKy = DataReader["masokyten"].ToString();
                res.DaKy = !string.IsNullOrEmpty(res.MaSoKy) ? true : false;

                listPhieuTheoDoiChucNangSong2.Add(res);
            }

            return listPhieuTheoDoiChucNangSong2;
        }

        public bool Insert(MDB.MDBConnection _OracleConnection, PhieuTheoDoiChucNangSong2Tbl obj) {
            try
            {
                //using (MDB.MDBConnection MyConnection = new MDB.MDBConnection(ERMDatabase.ConnectionString))
                {
                    string sql = @"INSERT INTO PhieuTheoDoiChucNangSong
                    (MAQUANLY, MaKhoa,MaGiuong, Giuong, MaBenhNhan, KHOA, CHANDOAN, NGAYSUA, NGAYTAO, NGUOITAO, NGUOISUA) VALUES
                    (:MaQuanLy, :MaKhoa, :MaGiuong, :Giuong, :MaBenhNhan, :Khoa, :ChanDoan, :NGAYSUA , :NGAYTAO , :NGUOITAO, :NGUOISUA )";

                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                    Command.Parameters.Add(new MDB.MDBParameter(":MaQuanLy", obj.MaQuanLy));
                    Command.Parameters.Add(new MDB.MDBParameter(":MaKhoa", obj.MaKhoa));
                    Command.Parameters.Add(new MDB.MDBParameter(":MaGiuong", obj.MaGiuong));
                    Command.Parameters.Add(new MDB.MDBParameter(":Giuong", obj.Giuong));
                    Command.Parameters.Add(new MDB.MDBParameter(":MaBenhNhan", obj.MaBenhNhan));
                    Command.Parameters.Add(new MDB.MDBParameter(":Khoa", obj.Khoa)); 
                    Command.Parameters.Add(new MDB.MDBParameter(":ChanDoan", obj.ChanDoan));  
                    Command.Parameters.Add(new MDB.MDBParameter(":NGAYSUA", DateTime.Now));
                    Command.Parameters.Add(new MDB.MDBParameter(":NGAYTAO", DateTime.Now));
                    Command.Parameters.Add(new MDB.MDBParameter(":NGUOITAO", Common.getUserLogin()));
                    Command.Parameters.Add(new MDB.MDBParameter(":NGUOISUA", Common.getUserLogin()));

                    int n = Command.ExecuteNonQuery();

                    return n > 0 ? true : false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Update(MDB.MDBConnection _OracleConnection, PhieuTheoDoiChucNangSong2Tbl obj)
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
                        WHERE IDPHIEU = " + obj.IDPhieu;
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                    Command.Parameters.Add(new MDB.MDBParameter(":MaQuanLy", obj.MaQuanLy));
                    Command.Parameters.Add(new MDB.MDBParameter(":MaKhoa", obj.MaKhoa));
                    Command.Parameters.Add(new MDB.MDBParameter(":MaGiuong", obj.MaGiuong));
                    Command.Parameters.Add(new MDB.MDBParameter(":Giuong", obj.Giuong));
                    Command.Parameters.Add(new MDB.MDBParameter(":MaBenhNhan", obj.MaBenhNhan));
                    Command.Parameters.Add(new MDB.MDBParameter(":Khoa", obj.Khoa)); 
                    Command.Parameters.Add(new MDB.MDBParameter(":ChanDoan", obj.ChanDoan));
                    Command.Parameters.Add(new MDB.MDBParameter(":NGAYSUA", obj.NgaySua));
                    Command.Parameters.Add(new MDB.MDBParameter(":NGAYTAO", obj.NgayTao));
                    Command.Parameters.Add(new MDB.MDBParameter(":NGUOITAO", obj.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter(":NGUOISUA", obj.NguoiSua));
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
                int check = CheckMaSoKy(_OracleConnection, IDPhieu, -1);
                if (check == 1)
                {
                    // phiếu đã ký và tồn tại trên server
                    MessageBox.Show("Phiếu đã được ký, vui lòng xóa văn bản ký trên hệ thống quản lý ký", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return false;
                }
                if (IDPhieu != 0)
                {
                    string sql = @"DELETE PhieuTheoDoiChucNangSong WHERE IDPhieu = :IDPhieu";
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                    Command.Parameters.Add(new MDB.MDBParameter(":IDPhieu", IDPhieu));
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
        //1 : phieu đã kỹ, chưa xóa trên server ký
        //0 : phiếu chưa ký
        //2 : phiếu đã ký, bị xóa trên server ký
        public int CheckMaSoKy(MDB.MDBConnection MyConnection, decimal IDPhieuTong = -1, decimal ID = -1)
        {
            try
            {
                DataPhieuKy dataPhieuKy = Report.GetPhieuKyHisPro(ERMDatabase.KyDienTu_ApplicationCode, XemBenhAn._ThongTinDieuTri.MaBenhAn, "PTDCNS");
                if (dataPhieuKy != null && dataPhieuKy.Data != null && dataPhieuKy.Data.Count > 0)
                {
                    listPhieuKy = dataPhieuKy.Data;
                }

                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT t.masokyten ");
                sql.AppendLine("FROM PTheoDoiChucNangSong_CT t ");
                if (ID != -1)
                {
                    sql.AppendLine(" WHERE t.IDPhieuCT = " + ID);
                }
                if (IDPhieuTong != -1)
                {
                    sql.AppendLine(" WHERE t.IDPhieu = " + IDPhieuTong);
                }
                ExceptionExtend.Log("PhieuTheoDoiChucNangSong2Func", "Query command : " + sql.ToString());
                MDB.MDBCommand Command = new MDB.MDBCommand(sql.ToString(), MyConnection);
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                bool checkKy = false;
                while (DataReader.Read())
                {
                    string MaSoKyTen = DataReader["masokyten"].ToString();
                    ExceptionExtend.Log("PhieuTheoDoiChucNangSong2Func", "res.MaSoKyTen : " + MaSoKyTen);
                    if (!string.IsNullOrEmpty(MaSoKyTen))
                        checkKy = true;
                    if (!string.IsNullOrEmpty(MaSoKyTen) && listPhieuKy != null)
                    {
                        PhieuKy checkPhieu = listPhieuKy.Find(x => MaSoKyTen.Equals(x.HIS_CODE));
                        if (checkPhieu != null && checkPhieu.IS_DELETE == 1)
                        {
                            return 2;
                        }
                    }

                }
                if (checkKy)
                    return 1;
                else return 0;

            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public bool Delete_ChiTiet(MDB.MDBConnection MyConnection, decimal IDPhieuCT)
        {
            try
            {
                int check = CheckMaSoKy(MyConnection, -1, IDPhieuCT);
                if (check == 1)
                {
                    // phiếu đã ký và tồn tại trên server
                    MessageBox.Show("Phiếu đã được ký, vui lòng xóa văn bản ký trên hệ thống quản lý ký", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return false;
                }
                if (IDPhieuCT != 0)
                {
                   string sql = @"Delete " + TableNameDetail + " WHERE (IDPhieuCT = :IDPhieuCT) ";
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter(":IDPhieuCT", IDPhieuCT));
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

        public static List<PhieuKy> listPhieuKy = null;
        public static bool checkRun = false;
        public static List<PhieuTheoDoiChucNangSong2_ChiTiet> Select_PhieuCHiTiet(MDB.MDBConnection MyConnection, string IDPhieu, string IDPhieuCT = "")
        {
            try
            {
                var timer = new Stopwatch();
                timer.Start();

                if (listPhieuKy == null && !checkRun)
                {
                    DataPhieuKy dataPhieuKy = Report.GetPhieuKyHisPro(ERMDatabase.KyDienTu_ApplicationCode, XemBenhAn._ThongTinDieuTri.MaBenhAn, "PTDCNS");
                    if (dataPhieuKy != null && dataPhieuKy.Data != null && dataPhieuKy.Data.Count > 0)
                    {
                        listPhieuKy = dataPhieuKy.Data;
                    }
                    checkRun = true;
                }

                List<PhieuTheoDoiChucNangSong2_ChiTiet> listResult = new List<PhieuTheoDoiChucNangSong2_ChiTiet>();
                StringBuilder sql = new StringBuilder();
                sql.AppendLine(@"SELECT t.* FROM " + TableNameDetail + " t WHERE 1 = 1 ");
                if (IDPhieu.Length != 0)
                {
                    sql.AppendLine(" and t.IDPhieu = " + IDPhieu);
                }
                if (IDPhieuCT.Length != 0)
                {
                    sql.AppendLine(" and t.IDPhieuCT in (" + IDPhieuCT + ")");
                }
                sql.AppendLine(" ORDER BY t.ThoiGianThucHien ASC");  
                MDB.MDBCommand Command = new MDB.MDBCommand(sql.ToString(), MyConnection);
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    var obj = new PhieuTheoDoiChucNangSong2_ChiTiet();
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
                    obj.MaSoKyTen = DataReader["masokyten"].ToString();
                    bool checkDelete = false;
                    if (!string.IsNullOrEmpty(obj.MaSoKyTen) && listPhieuKy != null)
                    {
                        PhieuKy checkPhieu = listPhieuKy.Find(x => obj.MaSoKyTen.Equals(x.HIS_CODE));
                        if (checkPhieu != null && checkPhieu.IS_DELETE == 1)
                        {
                            checkDelete = true;
                        }
                    }
                    obj.DaKy = (!checkDelete && !string.IsNullOrEmpty(obj.MaSoKyTen)) ? true : false;
                    listResult.Add(obj);
                }
                return listResult;
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool InsertOrUpdate_ChiTiet(MDB.MDBConnection MyConnection, PhieuTheoDoiChucNangSong2_ChiTiet obj)
        {
            try
            {
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
                oracleCommand.Parameters.Add(new MDB.MDBParameter("IDPhieu", obj.IDPhieu));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ThoiGianThucHien", obj.ThoiGianThucHien));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Mach", obj.Mach));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NhietDo", obj.NhietDo));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("HuyetApMax", obj.HuyetApMax));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("HuyetApMin", obj.HuyetApMin));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CanNang", obj.CanNang));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NhipTho", obj.NhipTho));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiThucHien", obj.NguoiThucHien));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaNguoiThucHien", obj.MaNguoiThucHien));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("GiaTri4", obj.GiaTri4));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("GiaTri5", obj.GiaTri5)); 
                int n = oracleCommand.ExecuteNonQuery();
                if (n == 0)
                {
                    oracleCommand.Dispose();
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
                    " ) RETURNING IDPhieuCT INTO :IDPhieuCT";
                    oracleCommand = new MDB.MDBCommand(sql, MyConnection);
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("IDPhieu", obj.IDPhieu));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ThoiGianThucHien", obj.ThoiGianThucHien));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Mach", obj.Mach));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NhietDo", obj.NhietDo));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("HuyetApMax", obj.HuyetApMax));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("HuyetApMin", obj.HuyetApMin));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CanNang", obj.CanNang));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NhipTho", obj.NhipTho));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiThucHien", obj.NguoiThucHien));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaNguoiThucHien", obj.MaNguoiThucHien));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("GiaTri4", obj.GiaTri4));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("GiaTri5", obj.GiaTri5));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("IDPhieuCT", obj.IDPhieuCT));
                    n = oracleCommand.ExecuteNonQuery();
                    long nextval = Convert.ToInt64((oracleCommand.Parameters["IDPhieuCT"] as MDB.MDBParameter).Value);
                    obj.IDPhieuCT = nextval;
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
                 SELECT P.*, '' SoNhapVien,'' MaBenhAn ,'' TenBenhNhan,'' Buong,
                       '' TUOI,'' SoYTe, '' BENHVIEN, 
                        '' GioiTinh
                  FROM PhieuTheoDoiChucNangSong P ");
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
