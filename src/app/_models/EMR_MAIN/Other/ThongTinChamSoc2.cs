using EMR.KyDienTu;
using MDB;
using NLog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows;
using static EMR_MAIN.Report;
using PMS.Access; 

namespace EMR_MAIN.DATABASE.Other
{
    public class ThongTinChamSocNew : ThongTinKy
    {
        public ThongTinChamSocNew()
        {
            TableName = "ThongTinChamSocNew";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.CS2;
            TenMauPhieu = DanhMucPhieu.CS2.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long IDThongTinChamSoc { get; set; }
		[MoTaDuLieu("Sở Y Tế")]
		public string SoYTe { get; set; }
        public string MaYTe { get; set; }
        [MoTaDuLieu("Bệnh viện")]
		public string BenhVien { get; set; }
        [MoTaDuLieu("Tên khoa")]
		public string TenKhoa { get; set; }
        [MoTaDuLieu("Mã bệnh án")]
		public string MaBenhAn { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        public string SoPhieu { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }
        [MoTaDuLieu("Buồng")]
		public string Buong { get; set; }
        [MoTaDuLieu("Giường")]
		public string Giuong { get; set; }
        [MoTaDuLieu("Mã giường")]
		public string MaGiuong { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        public string SoVaoVien { get; set; }
        public List<ThongTinChamSocNew_ChiTiet> TTCSChiTiet { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        //public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
        public ThongTinChamSocNew Clone()
        {
            ThongTinChamSocNew other = (ThongTinChamSocNew)this.MemberwiseClone();
            other.TTCSChiTiet = new List<ThongTinChamSocNew_ChiTiet>();
            if (this.TTCSChiTiet != null)
                foreach (ThongTinChamSocNew_ChiTiet item in this.TTCSChiTiet)
                {
                    other.TTCSChiTiet.Add(item.Clone());
                }
            return other;
        }
    }
    public class ThongTinChamSocNew_ChiTiet
    {
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã định danh")]
		public long IDThongTinChamSoc { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan_CT { get; set; }
        public DateTime ThoiGian { get; set; }
        [MoTaDuLieu("Người thực hiện")]
		public string NguoiThucHien { get; set; }
        public string MaNVNguoiThucHien { get; set; }
        [MoTaDuLieu("Diễn biến bệnh")]
		public string DienBienBenh { get; set; }
        [MoTaDuLieu("Y lệnh")]
		public string YLenh { get; set; }
        public string PhieuMau { get; set; }
        public string KyTen { get; set; }
        [MoTaDuLieu("Thực hiện y lệnh")]
		public string ThucHienYLenh { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
        public ThongTinChamSocNew_ChiTiet Clone()
        {
            ThongTinChamSocNew_ChiTiet other = (ThongTinChamSocNew_ChiTiet)this.MemberwiseClone();
            return other;
        }
    }
    public class ThongTinChamSocNewFunc
    {
        static Logger log = LogManager.GetLogger("Log");
        public const string TableName = "ThongTinChamSocNew_ChiTiet";
        public const string TableNameDM = "ThongTinChamSocNew";
        public const string TablePrimaryKeyName = "ID";
        public const string MaPhieu = "CS2";

        public static List<ThuocPha> DanhSachThuocPha = new List<ThuocPha>();


        public List<ThongTinChamSocNew> Select(MDB.MDBConnection MyConnection, string MaQuanLy, string MaKhoa)
        {
            try
            {
                //using (MDB.MDBConnection MyConnection = new MDB.MDBConnection(ERMDatabase.ConnectionString))
                {

                    // @alinhPQ them giup em truong SPO2 trong db nhe
                    List<ThongTinChamSocNew> listResult = new List<ThongTinChamSocNew>();
                    string sql = @"SELECT t.*
                    FROM ThongTinChamSocNew t
                    WHERE t.MaQuanLy = :MaQuanLy "; 
                    if (!string.IsNullOrEmpty(MaKhoa))
                    {
                        sql += " and MaKhoa = '" + MaKhoa + "' ";
                    }
                    sql = sql + "ORDER BY t.NgaySua DESC";
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
                    MDB.MDBDataReader DataReader = Command.ExecuteReader();
                    while (DataReader.Read())
                    {
                        var res = new ThongTinChamSocNew();
                        res.IDThongTinChamSoc = DataReader.GetLong("IDThongTinChamSoc");
                        res.SoYTe = Common.ConDBNull(DataReader["SoYTe"]);
                        res.MaYTe = Common.ConDBNull(DataReader["MaYTe"]);
                        res.BenhVien = Common.ConDBNull(DataReader["BenhVien"]);
                        res.TenKhoa = Common.ConDBNull(DataReader["TenKhoa"]);
                        res.MaBenhAn = Common.ConDBNull(DataReader["MaBenhAn"]);
                        res.MaBenhNhan = Common.ConDBNull(DataReader["MaBenhNhan"]);
                        res.TenBenhNhan = Common.ConDBNull(DataReader["TenBenhNhan"]);
                        res.Tuoi = Common.ConDBNull(DataReader["Tuoi"]);
                        res.DiaChi = Common.ConDBNull(DataReader["DiaChi"]);
                        res.SoPhieu = Common.ConDBNull(DataReader["SoPhieu"]);
                        res.MaQuanLy = Common.ConDB_Decimal(DataReader["MaQuanLy"]);
                        res.ChanDoan = Common.ConDBNull(DataReader["ChanDoan"]);
                        res.MaKhoa = Common.ConDBNull(DataReader["MaKhoa"]);
                        res.Buong = Common.ConDBNull(DataReader["Buong"]);
                        res.Giuong = Common.ConDBNull(DataReader["Giuong"]);
                        res.MaGiuong = Common.ConDBNull(DataReader["MaGiuong"]);
                        res.GioiTinh = Common.ConDBNull(DataReader["GioiTinh"]);
                        res.SoVaoVien = Common.ConDBNull(DataReader["SoVaoVien"]);
                        res.NguoiTao = Common.ConDBNull(DataReader["NguoiTao"]);
                        res.NgayTao = Common.ConDB_DateTime(DataReader["NgayTao"]);
                        res.NguoiSua = Common.ConDBNull(DataReader["NguoiSua"]);
                        res.NgaySua = Common.ConDB_DateTime(DataReader["NgaySua"]);
                        res.TTCSChiTiet = new List<ThongTinChamSocNew_ChiTiet>();
                        res.TTCSChiTiet = Select_PhieuCHiTiet(MyConnection, res.IDThongTinChamSoc.ToString());
                        res.MaSoKy = DataReader["masokyten"].ToString();
                        res.DaKy = !string.IsNullOrEmpty(res.MaSoKy) ? true : false;
                        listResult.Add(res);
                    }
                    return listResult;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Insert(MDB.MDBConnection MyConnection, ThongTinChamSocNew tttd)
        {
            try
            {
                //using (MDB.MDBConnection MyConnection = new MDB.MDBConnection(ERMDatabase.ConnectionString))
                {


                    string sql = @"INSERT INTO ThongTinChamSocNew (
                                SoYTe,
                                MaYTe,
                                BenhVien,
                                TenKhoa,
                                MaBenhAn,
                                MaBenhNhan,
                                TenBenhNhan,
                                Tuoi,
                                DiaChi,
                                SoPhieu,
                                MaQuanLy,
                                ChanDoan,
                                MaKhoa,
                                Buong,
                                Giuong,
                                MaGiuong,
                                GioiTinh,
                                SoVaoVien,
                                NguoiTao,
                                NgayTao,
                                NguoiSua,
                                NgaySua
                                ) 
                                VALUES (
                                :SoYTe,
                                :MaYTe,
                                :BenhVien,
                                :TenKhoa,
                                :MaBenhAn,
                                :MaBenhNhan,
                                :TenBenhNhan,
                                :Tuoi,
                                :DiaChi,
                                :SoPhieu,
                                :MaQuanLy,
                                :ChanDoan,
                                :MaKhoa,
                                :Buong,
                                :Giuong,
                                :MaGiuong,
                                :GioiTinh,
                                :SoVaoVien,
                                :NguoiTao,
                                :NgayTao,
                                :NguoiSua,
                                :NgaySua
                                )  RETURNING IDThongTinChamSoc INTO :IDThongTinChamSoc";
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter("SoYTe" , tttd.SoYTe));
                    Command.Parameters.Add(new MDB.MDBParameter("MaYTe" , tttd.MaYTe));
                    Command.Parameters.Add(new MDB.MDBParameter("BenhVien" , tttd.BenhVien));
                    Command.Parameters.Add(new MDB.MDBParameter("TenKhoa" , tttd.TenKhoa));
                    Command.Parameters.Add(new MDB.MDBParameter("MaBenhAn" , tttd.MaBenhAn));
                    Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan" , tttd.MaBenhNhan));
                    Command.Parameters.Add(new MDB.MDBParameter("TenBenhNhan" , tttd.TenBenhNhan));
                    Command.Parameters.Add(new MDB.MDBParameter("Tuoi" , tttd.Tuoi));
                    Command.Parameters.Add(new MDB.MDBParameter("DiaChi" , tttd.DiaChi));
                    Command.Parameters.Add(new MDB.MDBParameter("SoPhieu" , tttd.SoPhieu));
                    Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy" , tttd.MaQuanLy));
                    Command.Parameters.Add(new MDB.MDBParameter("ChanDoan" , tttd.ChanDoan));
                    Command.Parameters.Add(new MDB.MDBParameter("MaKhoa", tttd.MaKhoa));
                    Command.Parameters.Add(new MDB.MDBParameter("Buong" , tttd.Buong));
                    Command.Parameters.Add(new MDB.MDBParameter("Giuong" , tttd.Giuong));
                    Command.Parameters.Add(new MDB.MDBParameter("MaGiuong" , tttd.MaGiuong));
                    Command.Parameters.Add(new MDB.MDBParameter("GioiTinh", tttd.GioiTinh));
                    Command.Parameters.Add(new MDB.MDBParameter("SoVaoVien", tttd.SoVaoVien));
                    Command.Parameters.Add(new MDB.MDBParameter("NguoiTao", tttd.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NgayTao", DateTime.Now));
                    Command.Parameters.Add(new MDB.MDBParameter("NguoiSua", tttd.NguoiSua));
                    Command.Parameters.Add(new MDB.MDBParameter("NgaySua", DateTime.Now));
                    Command.Parameters.Add(new MDB.MDBParameter("IDThongTinChamSoc", tttd.IDThongTinChamSoc));
                    int n = Command.ExecuteNonQuery();
                    if (tttd.IDThongTinChamSoc == 0)
                    {
                        long nextval = Convert.ToInt64((Command.Parameters["IDThongTinChamSoc"] as MDB.MDBParameter).Value);
                        tttd.IDThongTinChamSoc = nextval;
                    }

                    return n > 0 ? true : false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Update(MDB.MDBConnection MyConnection, ThongTinChamSocNew tttd)
        {
            try
            {
                //using (MDB.MDBConnection MyConnection = new MDB.MDBConnection(ERMDatabase.ConnectionString))
                {

                    string sql = @"UPDATE ThongTinChamSocNew SET 
                        SoYTe=:SoYTe,
                        MaYTe=:MaYTe,
                        BenhVien=:BenhVien,
                        TenKhoa=:TenKhoa,
                        MaBenhAn=:MaBenhAn,
                        MaBenhNhan=:MaBenhNhan,
                        TenBenhNhan=:TenBenhNhan,
                        Tuoi=:Tuoi,
                        DiaChi=:DiaChi,
                        SoPhieu=:SoPhieu,
                        MaQuanLy=:MaQuanLy,
                        ChanDoan=:ChanDoan,
                        MaKhoa=:MaKhoa,
                        Buong=:Buong,
                        Giuong=:Giuong,
                        MaGiuong=:MaGiuong,
                        GioiTinh=:GioiTinh,
                        SoVaoVien=:SoVaoVien,
                        NguoiSua=:NguoiSua,
                        NgaySua=:NgaySua
                        WHERE IDThongTinChamSoc = " + tttd.IDThongTinChamSoc;
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter("SoYTe", tttd.SoYTe));
                    Command.Parameters.Add(new MDB.MDBParameter("MaYTe", tttd.MaYTe));
                    Command.Parameters.Add(new MDB.MDBParameter("BenhVien", tttd.BenhVien));
                    Command.Parameters.Add(new MDB.MDBParameter("TenKhoa", tttd.TenKhoa));
                    Command.Parameters.Add(new MDB.MDBParameter("MaBenhAn", tttd.MaBenhAn));
                    Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", tttd.MaBenhNhan));
                    Command.Parameters.Add(new MDB.MDBParameter("TenBenhNhan", tttd.TenBenhNhan));
                    Command.Parameters.Add(new MDB.MDBParameter("Tuoi", tttd.Tuoi));
                    Command.Parameters.Add(new MDB.MDBParameter("DiaChi", tttd.DiaChi));
                    Command.Parameters.Add(new MDB.MDBParameter("SoPhieu", tttd.SoPhieu));
                    Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", tttd.MaQuanLy));
                    Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", tttd.ChanDoan));
                    Command.Parameters.Add(new MDB.MDBParameter("MaKhoa", tttd.MaKhoa));
                    Command.Parameters.Add(new MDB.MDBParameter("Buong", tttd.Buong));
                    Command.Parameters.Add(new MDB.MDBParameter("Giuong", tttd.Giuong));
                    Command.Parameters.Add(new MDB.MDBParameter("MaGiuong", tttd.MaGiuong));
                    Command.Parameters.Add(new MDB.MDBParameter("GioiTinh", tttd.GioiTinh));
                    Command.Parameters.Add(new MDB.MDBParameter("SoVaoVien", tttd.SoVaoVien));
                    Command.Parameters.Add(new MDB.MDBParameter("NguoiSua", tttd.NguoiSua));
                    Command.Parameters.Add(new MDB.MDBParameter("NgaySua", DateTime.Now));
                    int n = Command.ExecuteNonQuery();

                    return n > 0 ? true : false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Delete(MDB.MDBConnection MyConnection, decimal IDThongTinChamSoc)
        {
            try
            {
                int check = CheckMaSoKy(MyConnection, IDThongTinChamSoc, -1);
                if (check == 1)
                {
                    // phiếu đã ký và tồn tại trên server
                    MessageBox.Show("Phiếu đã được ký, vui lòng xóa văn bản ký trên hệ thống quản lý ký", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return false;
                }

                if (IDThongTinChamSoc != 0)
                {
                    string sql = @"Delete ThongTinChamSocNew 
                                WHERE 
                                (IDThongTinChamSoc = :IDThongTinChamSoc) ";
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter(":IDThongTinChamSoc", IDThongTinChamSoc));
                    int n = Command.ExecuteNonQuery();
                    Command.Dispose();
                    sql = @"Delete ThongTinChamSocNew_ChiTiet 
                                WHERE 
                                (IDThongTinChamSoc = :IDThongTinChamSoc) ";
                    Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter(":IDThongTinChamSoc", IDThongTinChamSoc));
                    n = Command.ExecuteNonQuery();

                    return true;
                }

            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public bool Delete_ChiTiet(MDB.MDBConnection MyConnection, decimal ID)
        {
            int check = CheckMaSoKy(MyConnection, -1, ID);
            if(check == 1)
            {
                // phiếu đã ký và tồn tại trên server
                MessageBox.Show("Phiếu đã được ký, vui lòng xóa văn bản ký trên hệ thống quản lý ký", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
            }    
            try
            {
                if (ID != 0)
                {

                    string sql = @"Delete ThongTinChamSocNew_ChiTiet 
                                WHERE 
                                (ID = :ID) ";
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter(":ID", ID));
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

        //1 : phieu đã kỹ, chưa xóa trên server ký
        //0 : phiếu chưa ký
        //2 : phiếu đã ký, bị xóa trên server ký
        public int CheckMaSoKy(MDB.MDBConnection MyConnection, decimal IDThongTinChamSoc = -1, decimal ID = -1)
        {
            try
            {
                DataPhieuKy dataPhieuKy = Report.GetPhieuKyHisPro(ERMDatabase.KyDienTu_ApplicationCode, XemBenhAn._ThongTinDieuTri.MaBenhAn, "CS2");
                if (dataPhieuKy != null && dataPhieuKy.Data != null && dataPhieuKy.Data.Count > 0)
                {
                    listPhieuKy = dataPhieuKy.Data;
                }
                dataPhieuKy = Report.GetPhieuKyHisPro(ERMDatabase.KyDienTu_ApplicationCode, XemBenhAn._ThongTinDieuTri.MaBenhAn, "CS");
                if (dataPhieuKy != null && dataPhieuKy.Data != null && dataPhieuKy.Data.Count > 0)
                {
                    if (listPhieuKy != null)
                        listPhieuKy.AddRange(dataPhieuKy.Data);
                    else
                        listPhieuKy = dataPhieuKy.Data;
                }

                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT t.masokyten ");
                sql.AppendLine("FROM ThongTinChamSocNew_ChiTiet t ");
                if (ID != -1)
                {
                    sql.AppendLine(" WHERE t.ID = " + ID);
                }
                if (IDThongTinChamSoc != -1)
                {
                    sql.AppendLine(" WHERE t.IDThongTinChamSoc = " + IDThongTinChamSoc);
                }
                ExceptionExtend.Log("ThongTinChamSoc2", "Query command : " + sql.ToString());
                MDB.MDBCommand Command = new MDB.MDBCommand(sql.ToString(), MyConnection);
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                bool checkKy = false;
                while (DataReader.Read())
                {
                    string MaSoKyTen = DataReader["masokyten"].ToString();
                    ExceptionExtend.Log("ThongTinChamSoc2", "res.MaSoKyTen : " + MaSoKyTen);
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
        public List<ThongTinChamSocNew_ChiTiet> Select_PhieuCHiTiet(MDB.MDBConnection MyConnection, string IDThongTinChamSoc, string ID = null)
        {
            ExceptionExtend.Log("ThongTinChamSoc2", "start Select_PhieuCHiTiet");
            var timer = new Stopwatch();
            timer.Start();

            if (listPhieuKy == null && !checkRun)
            { 
                DataPhieuKy dataPhieuKy = Report.GetPhieuKyHisPro(ERMDatabase.KyDienTu_ApplicationCode, XemBenhAn._ThongTinDieuTri.MaBenhAn, "CS2");
                if (dataPhieuKy != null && dataPhieuKy.Data != null && dataPhieuKy.Data.Count > 0)
                {
                    listPhieuKy = dataPhieuKy.Data;
                }
                dataPhieuKy = Report.GetPhieuKyHisPro(ERMDatabase.KyDienTu_ApplicationCode, XemBenhAn._ThongTinDieuTri.MaBenhAn, "CS");
                if (dataPhieuKy != null && dataPhieuKy.Data != null && dataPhieuKy.Data.Count > 0)
                {
                    if(listPhieuKy != null)
                        listPhieuKy.AddRange(dataPhieuKy.Data);
                    else
                        listPhieuKy = dataPhieuKy.Data;
                }
                checkRun = true;
            }
            try
            {
                //using (MDB.MDBConnection MyConnection = new MDB.MDBConnection(ERMDatabase.ConnectionString))
                {

                    // @alinhPQ them giup em truong SPO2 trong db nhe
                    List<ThongTinChamSocNew_ChiTiet> listResult = new List<ThongTinChamSocNew_ChiTiet>();
                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine("SELECT t.*");
                    sql.AppendLine("FROM ThongTinChamSocNew_ChiTiet t");
                    sql.AppendLine("WHERE t.IDThongTinChamSoc = :IDThongTinChamSoc ");
                    if (!string.IsNullOrWhiteSpace(ID))
                    {
                        sql.AppendLine("AND ID = " + ID);
                    }
                    sql.AppendLine("ORDER BY t.ThoiGian DESC"); // datmc update get ThoiGianForMat24H
                    ExceptionExtend.Log("ThongTinChamSoc2", "Query command : " + sql.ToString());
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql.ToString(), MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter("IDThongTinChamSoc", IDThongTinChamSoc));
                    MDB.MDBDataReader DataReader = Command.ExecuteReader();
                    while (DataReader.Read())
                    {
                        var res = new ThongTinChamSocNew_ChiTiet();
                        res.ID =  (long)Common.ConDB_Decimal(DataReader["ID"]);
                        res.IDThongTinChamSoc = (long)Common.ConDB_Decimal(DataReader["IDThongTinChamSoc"]);
                        res.ChanDoan_CT = Common.ConDBNull(DataReader["ChanDoan_CT"]);
                        res.ThoiGian = Common.ConDB_DateTime(DataReader["ThoiGian"]);
                        res.NguoiThucHien = Common.ConDBNull(DataReader["NguoiThucHien"]);
                        res.MaNVNguoiThucHien = Common.ConDBNull(DataReader["MaNVNguoiThucHien"]);
                        res.DienBienBenh = Common.ConDBNull(DataReader["DienBienBenh"]);
                        res.YLenh = Common.ConDBNull(DataReader["YLenh"]);
                        res.PhieuMau = Common.ConDBNull(DataReader["PhieuMau"]);
                        res.KyTen = Common.ConDBNull(DataReader["KyTen"]);
                        res.ThucHienYLenh = Common.ConDBNull(DataReader["ThucHienYLenh"]);
                        res.MaSoKyTen = DataReader["masokyten"].ToString();
                        ExceptionExtend.Log("ThongTinChamSoc2", "res.MaSoKyTen : " + res.MaSoKyTen);
                        bool checkDelete = false;
                        if (!string.IsNullOrEmpty(res.MaSoKyTen) && listPhieuKy != null)
                        {
                            PhieuKy checkPhieu = listPhieuKy.Find(x => res.MaSoKyTen.Equals(x.HIS_CODE));
                            if(checkPhieu != null && checkPhieu.IS_DELETE == 1)
                            {
                                checkDelete = true;
                            }    
                        }
                        res.DaKy = (!checkDelete && !string.IsNullOrEmpty(res.MaSoKyTen)) ? true : false;
                        listResult.Add(res);
                    }
                    ExceptionExtend.Log("ThongTinChamSoc2", "end  Select_PhieuCHiTiet : " + timer.ElapsedMilliseconds + " ms");
                    return listResult;

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        public bool InsertOrUpdate_ChiTiet(MDB.MDBConnection MyConnection, ThongTinChamSocNew_ChiTiet data)
        {
            string sql = @"update ThongTinChamSocNew_ChiTiet set
                        IDThongTinChamSoc=:IDThongTinChamSoc,
                        ChanDoan_CT=:ChanDoan_CT,
                        ThoiGian=:ThoiGian,
                        NguoiThucHien=:NguoiThucHien,
                        MaNVNguoiThucHien=:MaNVNguoiThucHien,
                        DienBienBenh=:DienBienBenh,
                        YLenh=:YLenh,
                        PhieuMau=:PhieuMau,
                        KyTen=:KyTen,
                        ThucHienYLenh=:ThucHienYLenh
                        WHERE ID = " + data.ID + "";

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("IDThongTinChamSoc", data.IDThongTinChamSoc));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoan_CT", data.ChanDoan_CT));
            Command.Parameters.Add(new MDB.MDBParameter("ThoiGian", data.ThoiGian));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiThucHien", data.NguoiThucHien));
            Command.Parameters.Add(new MDB.MDBParameter("MaNVNguoiThucHien", data.MaNVNguoiThucHien));
            Command.Parameters.Add(new MDB.MDBParameter("DienBienBenh", data.DienBienBenh));
            Command.Parameters.Add(new MDB.MDBParameter("YLenh", data.YLenh));
            Command.Parameters.Add(new MDB.MDBParameter("PhieuMau", data.PhieuMau));
            Command.Parameters.Add(new MDB.MDBParameter("KyTen", data.KyTen));
            Command.Parameters.Add(new MDB.MDBParameter("ThucHienYLenh", data.ThucHienYLenh));
            int n = Command.ExecuteNonQuery();
            if (n == 0)
            {
                Command.Dispose();
                sql = @"insert into ThongTinChamSocNew_ChiTiet (
                    IDThongTinChamSoc,
                    ChanDoan_CT,
                    ThoiGian,
                    NguoiThucHien,
                    MaNVNguoiThucHien,
                    DienBienBenh,
                    YLenh,
                    PhieuMau,
                    KyTen,
                    ThucHienYLenh
                    ) values (
                    :IDThongTinChamSoc,
                    :ChanDoan_CT,
                    :ThoiGian,
                    :NguoiThucHien,
                    :MaNVNguoiThucHien,
                    :DienBienBenh,
                    :YLenh,
                    :PhieuMau,
                    :KyTen,
                    :ThucHienYLenh
                    ) RETURNING ID INTO :ID";
                Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("IDThongTinChamSoc", data.IDThongTinChamSoc));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan_CT", data.ChanDoan_CT));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGian", data.ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiThucHien", data.NguoiThucHien));
                Command.Parameters.Add(new MDB.MDBParameter("MaNVNguoiThucHien", data.MaNVNguoiThucHien));
                Command.Parameters.Add(new MDB.MDBParameter("DienBienBenh", data.DienBienBenh));
                Command.Parameters.Add(new MDB.MDBParameter("YLenh", data.YLenh));
                Command.Parameters.Add(new MDB.MDBParameter("PhieuMau", data.PhieuMau));
                Command.Parameters.Add(new MDB.MDBParameter("KyTen", data.KyTen));
                Command.Parameters.Add(new MDB.MDBParameter("ThucHienYLenh", data.ThucHienYLenh));
                Command.Parameters.Add(new MDB.MDBParameter("ID", data.ID));
                n = Command.ExecuteNonQuery();
                long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                data.ID = nextval;
            }
            return n > 0 ? true : false;
        }
        
        public static List<Khoa> getKhoaDaChamSoc(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql = "SELECT DISTINCT K.IDKhoa, K.MaKhoa, T.TenKhoa FROM ThongTinChamSocNew T left join Khoa K on T.TenKhoa = K.TenKhoa WHERE T.MaQuanLy = " + MaQuanLy.ToString(System.Globalization.CultureInfo.InvariantCulture);
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            List<Khoa> lstData = new List<Khoa>(); 
            while (DataReader.Read())
            {
                try
                {   
                    lstData.Add(new Khoa
                    {
                        IdKhoa = DataReader.GetDecimal("IDKhoa"),
                        MaKhoa = DataReader["MaKhoa"].ToString(),
                        TenKhoa = DataReader["TenKhoa"].ToString(),
                    });
                }
                catch (Exception ex)
                {
                    MDB.ExceptionExtend.LogError(ex);
                }
            }
            return lstData;
        }
        public static List<Khoa> getKhoa(MDB.MDBConnection MyConnection, string ID, string MaKhoa, string TenKhoa)
        {
            List<Khoa> Data = new List<Khoa>();
            string sql = "SELECT IDKhoa, MaKhoa, TenKhoa FROM Khoa Where 1 = 1 ";
            if (!string.IsNullOrEmpty(ID))
            {
                sql = sql + " And IDKhoa = " + ID;
            }
            if (!string.IsNullOrEmpty(MaKhoa))
            {
                sql = sql + " And MaKhoa = '" + MaKhoa + "'";
            }
            if (!string.IsNullOrEmpty(TenKhoa))
            {
                sql = sql + " OR TenKhoa = '" + TenKhoa + "' ";
            }
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            while (DataReader.Read())
            {
                try
                {
                    Data.Add(new Khoa
                    {
                        IdKhoa = DataReader.GetDecimal("IDKhoa"),
                        MaKhoa = DataReader["MaKhoa"].ToString(),
                        TenKhoa = DataReader["TenKhoa"].ToString(),
                    });
                }
                catch (Exception ex)
                {
                    MDB.ExceptionExtend.LogError(ex);
                }
            }
            return Data;
        }
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, decimal MaQuanLy, string MaKhoa, decimal? IDThongTinChamSoc = null, string lstStrID = null)
        {
            MDB.ExceptionExtend.Log(typeof(ThongTinChamSoc), "Start get data " + MaQuanLy);
            var timer = new Stopwatch();
            StringBuilder sql = new StringBuilder();
            timer.Start();
            try
            {
                sql.AppendLine(@"select a.*, c.*, to_char(c.thoigian, 'dd/MM/yyyy HH24:mi') thoigianbaocao,");
                sql.AppendLine(@"c.NguoiThucHien hotennguoiky from ThongTinChamSocNew a");
                sql.AppendLine(@"left join ThongTinChamSocNew_ChiTiet c");
                sql.AppendLine("on a.IDThongTinChamSoc = c.IDThongTinChamSoc");
                sql.AppendLine("WHERE a.MaQuanLy = :MaQuanLy");
                if (!String.IsNullOrEmpty(MaKhoa))
                {
                    sql.AppendLine(" and a.MaKhoa = '" + MaKhoa + "' ");
                }
                if (IDThongTinChamSoc != null && IDThongTinChamSoc.HasValue && IDThongTinChamSoc.Value != 0)
                {
                    sql.AppendLine(" and a.IDThongTinChamSoc = " + IDThongTinChamSoc);
                }

                if( !string.IsNullOrEmpty(lstStrID))
                {
                    sql.AppendLine(" and c.ID in (" + lstStrID + ")");
                }
                sql.AppendLine(" ORDER BY c.ThoiGian asc");
                ExceptionExtend.Log("ThongTinChamSoc2", "Command : " + sql.ToString());
                MDB.MDBCommand Command = new MDB.MDBCommand(sql.ToString(), MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
                MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
                var ds = new DataSet();
                adt.Fill(ds);
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
                MDB.ExceptionExtend.Log(typeof(ThongTinChamSoc), "End get data " + MaQuanLy + ". Total " + timer.ElapsedMilliseconds.ToString() + " ms");
            }
        }
    }
}
