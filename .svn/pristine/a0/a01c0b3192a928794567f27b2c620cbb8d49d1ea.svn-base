using DevExpress.XtraReports.UI;
using EMR.KyDienTu;
using EMR_MAIN.InBenhAn;
using EMR_MAIN.KhamBenh;
using EMR_MAIN.ViewModel;
using Newtonsoft.Json;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;
/// <summary>
/// by tunght
/// </summary>
namespace EMR_MAIN.DATABASE.Other
{
  
    public class PhieuDienTimTbl: ThongTinKy
    {

        public PhieuDienTimTbl()
        {
            DaoTrinhList = new List<PhieuDienTim_DaoTrinh>();
            TableName = "PhieuDienTim";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PDT;
            TenMauPhieu = DanhMucPhieu.PDT.Description();
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
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi
        {
            get
            {
                return Common.GetDiaChi();
            }
        }
        [MoTaDuLieu("Buồng")]
        public string Buong
        {
            get
            {
                return XemBenhAn._ThongTinDieuTri.Buong;
            }
        }
        [MoTaDuLieu("Giường")]
        public string Giuong
        {
            get
            {
                return XemBenhAn._ThongTinDieuTri.Giuong;
            }
        }
        [MoTaDuLieu("Mã định danh")]
		public decimal ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan{ get; set; }
        [MoTaDuLieu("Cân nặng")]
		public string CanNang { get; set; }
        [MoTaDuLieu("Chiều cao")]
		public string ChieuCao { get; set; }
        public string YeuCauKT { get; set; }
        public DateTime NgayThucHien { get; set; }  
        public string TenBSDieuTri{ get; set; }
        public string MaBSDieuTri { get; set; }
        public string TenBSChuyenKhoa { get; set; }
        public string MaBSChuyenKhoa { get; set; }
        public string ChuyenDaoMau { get; set; }
        public string Nhip { get; set; }
        public string Goc { get; set; }
        public string Truc { get; set; }
        public string TuTheTim { get; set; }
        public string P { get; set; }
        public string PR { get; set; }
        public string QRS { get; set; }
        public string ST { get; set; }
        public string T { get; set; }
        public string QT { get; set; }
        public string ChuyenDaoTruocTim { get; set; }
        public string KetLuan { get; set; }
        public string LoiDan { get; set; }
        public List<PhieuDienTim_DaoTrinh> DaoTrinhList { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }

    }
    public class PhieuDienTimFunc
    {
        public const string TableName = "PhieuDienTim";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuDienTimTbl> GetListData(MDB.MDBConnection MyConnection, decimal MaQuanly)
        {
            try
            {
                {
                    List<PhieuDienTimTbl> lstObject = new List<PhieuDienTimTbl>();
                    string sql = "SELECT * FROM PhieuDienTim   WHERE MaQuanLy = :MaQuanLy ORDER BY ID DESC";
                    MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                    command.Parameters.Add(new MDB.MDBParameter("MaQuanly", MaQuanly));
                    MDB.MDBDataReader DataReader = command.ExecuteReader();
                    while (DataReader.Read())
                    {
                        PhieuDienTimTbl obj = new PhieuDienTimTbl();
                        obj.ID = Common.ConDB_Decimal(DataReader["ID"]);
                        obj.MaQuanLy = Common.ConDB_Decimal(DataReader["MaQuanLy"]);
                        obj.ChanDoan = Common.ConDBNull(DataReader["ChanDoan"]);
                        obj.MaKhoa = Common.ConDBNull(DataReader["MaKhoa"]);
                        obj.Khoa = Common.ConDBNull(DataReader["Khoa"]);
                        obj.MaBenhNhan = Common.ConDBNull(DataReader["MaBenhNhan"]);
                        obj.CanNang = Common.ConDBNull(DataReader["CanNang"]);
                        obj.ChieuCao = Common.ConDBNull(DataReader["ChieuCao"]);
                        obj.YeuCauKT = Common.ConDBNull(DataReader["YeuCauKT"]);
                        obj.NgayThucHien = Common.ConDB_DateTime(DataReader["NgayThucHien"]);
                        obj.TenBSDieuTri = Common.ConDBNull(DataReader["TenBSDieuTri"]);
                        obj.MaBSDieuTri = Common.ConDBNull(DataReader["MaBSDieuTri"]);
                        obj.TenBSChuyenKhoa = Common.ConDBNull(DataReader["TenBSChuyenKhoa"]);
                        obj.MaBSChuyenKhoa = Common.ConDBNull(DataReader["MaBSChuyenKhoa"]);
                        obj.ChuyenDaoMau = Common.ConDBNull(DataReader["ChuyenDaoMau"]);
                        obj.Nhip = Common.ConDBNull(DataReader["Nhip"]);
                        obj.Goc = Common.ConDBNull(DataReader["Goc"]);
                        obj.Truc = Common.ConDBNull(DataReader["Truc"]);
                        obj.TuTheTim = Common.ConDBNull(DataReader["TuTheTim"]);
                        obj.P = Common.ConDBNull(DataReader["P"]);
                        obj.PR = Common.ConDBNull(DataReader["PR"]);
                        obj.QRS = Common.ConDBNull(DataReader["QRS"]);
                        obj.ST = Common.ConDBNull(DataReader["ST"]);
                        obj.T = Common.ConDBNull(DataReader["T"]);
                        obj.QT = Common.ConDBNull(DataReader["QT"]);
                        obj.ChuyenDaoTruocTim = Common.ConDBNull(DataReader["ChuyenDaoTruocTim"]);
                        obj.KetLuan = Common.ConDBNull(DataReader["KetLuan"]);
                        obj.LoiDan = Common.ConDBNull(DataReader["LoiDan"]);
                        obj.DaoTrinhList = JsonConvert.DeserializeObject<List<PhieuDienTim_DaoTrinh>>(Common.ConDBNull(DataReader["DaoTrinhList"]));
                        obj.NgaySua = Common.ConDB_DateTime(DataReader["NgaySua"]);
                        obj.NguoiSua = Common.ConDBNull(DataReader["NguoiSua"]);
                        obj.NgayTao = Common.ConDB_DateTime(DataReader["NgayTao"]);
                        obj.NguoiTao = Common.ConDBNull(DataReader["NguoiTao"]);
                        obj.MaSoKy = Common.ConDBNull(DataReader["MaSoKy"]);
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
            string sql = @"SELECT P.*, '' SoNhapVien,'' MaBenhAn, '' as DiaChi , '' TenBenhNhan,'' Buong, '' Giuong,
                        '' TUOI,'' SoYTe, '' BENHVIEN, '' NgheNghiep,
                        ''  GioiTinh
                        FROM PhieuDienTim P 
                        where ID  = :ID";
            MDB.MDBCommand Command;
            MDB.MDBDataAdapter adt;
            using (Command = new MDB.MDBCommand(sql, MyConnection))
            {
                Command.Parameters.Add(new MDB.MDBParameter("ID", IDBienBan));
                adt = new MDB.MDBDataAdapter(Command);
            }
            var ds = new DataSet();
            adt.Fill(ds, "Table");
            if (ds != null || ds.Tables[0].Rows.Count > 0)
            {
                ds.Tables[0].Rows[0]["SoNhapVien"] = XemBenhAn._ThongTinDieuTri.SoNhapVien;
                ds.Tables[0].Rows[0]["MaBenhAn"] = XemBenhAn._ThongTinDieuTri.MaBenhAn;
                ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                ds.Tables[0].Rows[0]["Buong"] = XemBenhAn._ThongTinDieuTri.Buong;
                ds.Tables[0].Rows[0]["Giuong"] = XemBenhAn._ThongTinDieuTri.Giuong;
                ds.Tables[0].Rows[0]["TUOI"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                ds.Tables[0].Rows[0]["SoYTe"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
                ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
                ds.Tables[0].Rows[0]["NgheNghiep"] = XemBenhAn._HanhChinhBenhNhan.NgheNghiep;
                ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            }
            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection oracleConnection, PhieuDienTimTbl obj, ref bool isUpdate)
        {
            try
            {
                string sql = @"SELECT COUNT(*) RECNUM FROM PhieuDienTim WHERE ID  = :ID";
                MDB.MDBCommand oracleCommand;
                int rowCount = 0;
                int nRecord = 0;
                oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
                oracleCommand.Parameters.Add("ID", obj.ID);
                MDB.MDBDataReader oracleDataReader = oracleCommand.ExecuteReader();
                while (oracleDataReader.Read())
                {
                    rowCount = int.Parse(oracleDataReader["RECNUM"].ToString());
                }


                if (rowCount > 0)
                {
                    isUpdate = true;
                    sql = @"update PhieuDienTim set
                            MaQuanLy=:MaQuanLy,
                            ChanDoan=:ChanDoan,
                            MaKhoa=:MaKhoa,
                            Khoa=:Khoa,
                            MaBenhNhan=:MaBenhNhan,
                            CanNang=:CanNang,
                            ChieuCao=:ChieuCao,
                            YeuCauKT=:YeuCauKT,
                            NgayThucHien=:NgayThucHien,
                            TenBSDieuTri=:TenBSDieuTri,
                            MaBSDieuTri=:MaBSDieuTri,
                            TenBSChuyenKhoa=:TenBSChuyenKhoa,
                            MaBSChuyenKhoa=:MaBSChuyenKhoa,
                            ChuyenDaoMau=:ChuyenDaoMau,
                            Nhip=:Nhip,
                            Goc=:Goc,
                            Truc=:Truc,
                            TuTheTim=:TuTheTim,
                            P=:P,
                            PR=:PR,
                            QRS=:QRS,
                            ST=:ST,
                            T=:T,
                            QT=:QT,
                            ChuyenDaoTruocTim=:ChuyenDaoTruocTim,
                            KetLuan=:KetLuan,
                            LoiDan=:LoiDan,
                            DaoTrinhList=:DaoTrinhList,
                            NgaySua =:NgaySua,
                            NguoiSua =:NguoiSua ";
                    sql = sql + " WHERE ID  = " + obj.ID.ToString();
                }
                else
                {
                    sql = @"insert into PhieuDienTim(
                            MaQuanLy,
                            ChanDoan,
                            MaKhoa,
                            Khoa,
                            MaBenhNhan,
                            CanNang,
                            ChieuCao,
                            YeuCauKT,
                            NgayThucHien,
                            TenBSDieuTri,
                            MaBSDieuTri,
                            TenBSChuyenKhoa,
                            MaBSChuyenKhoa,
                            ChuyenDaoMau,
                            Nhip,
                            Goc,
                            Truc,
                            TuTheTim,
                            P,
                            PR,
                            QRS,
                            ST,
                            T,
                            QT,
                            ChuyenDaoTruocTim,
                            KetLuan,
                            LoiDan,
                            DaoTrinhList,
                            NgaySua,
                            NguoiSua,
                            NgayTao,
                            NguoiTao
                            ) VALUES( 
                            :MaQuanLy,
                            :ChanDoan,
                            :MaKhoa,
                            :Khoa,
                            :MaBenhNhan,
                            :CanNang,
                            :ChieuCao,
                            :YeuCauKT,
                            :NgayThucHien,
                            :TenBSDieuTri,
                            :MaBSDieuTri,
                            :TenBSChuyenKhoa,
                            :MaBSChuyenKhoa,
                            :ChuyenDaoMau,
                            :Nhip,
                            :Goc,
                            :Truc,
                            :TuTheTim,
                            :P,
                            :PR,
                            :QRS,
                            :ST,
                            :T,
                            :QT,
                            :ChuyenDaoTruocTim,
                            :KetLuan,
                            :LoiDan,
                            :DaoTrinhList,
                            :NgaySua,
                            :NguoiSua,
                            :NgayTao,
                            :NguoiTao
                            )  RETURNING ID INTO :ID";
                }
                oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaQuanLy", obj.MaQuanLy));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ChanDoan", obj.ChanDoan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaKhoa", obj.MaKhoa));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Khoa", obj.Khoa));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", obj.MaBenhNhan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CanNang", obj.CanNang));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ChieuCao", obj.ChieuCao));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("YeuCauKT", obj.YeuCauKT));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayThucHien", obj.NgayThucHien));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenBSDieuTri", obj.TenBSDieuTri));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBSDieuTri", obj.MaBSDieuTri));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenBSChuyenKhoa", obj.TenBSChuyenKhoa));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBSChuyenKhoa", obj.MaBSChuyenKhoa));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ChuyenDaoMau", obj.ChuyenDaoMau));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Nhip", obj.Nhip));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Goc", obj.Goc));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Truc", obj.Truc));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TuTheTim", obj.TuTheTim));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("P", obj.P));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("PR", obj.PR));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("QRS", obj.QRS));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ST", obj.ST));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("T", obj.T));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("QT", obj.QT));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ChuyenDaoTruocTim", obj.ChuyenDaoTruocTim));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KetLuan", obj.KetLuan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("LoiDan", obj.LoiDan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DaoTrinhList", JsonConvert.SerializeObject(obj.DaoTrinhList))); 
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgaySua", DateTime.Now));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiSua", Common.getUserLogin()));
                if (!isUpdate)
                {                         
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayTao", DateTime.Now));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiTao", Common.getUserLogin()));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ID", obj.ID));
                }
                nRecord = oracleCommand.ExecuteNonQuery();
                if (nRecord > 0)
                {
                    if (!isUpdate)
                    {
                        decimal nextval = Common.ConDB_Decimal((oracleCommand.Parameters["ID"] as MDB.MDBParameter).Value);
                        obj.ID = nextval;
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
        //public static bool DeleteByID(MDB.MDBConnection oracleConnection, decimal IDbienBan)
        public static bool DeleteByID(MDB.MDBConnection oracleConnection, List<decimal> lstIDbienBan)
        {
            try
            {
                string sql = "";
                string strWhere = "";
                MDB.MDBCommand oracleCommand;
                strWhere = " ID In(";
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
                sql = @"DELETE FROM PhieuDienTim WHERE  " + strWhere;
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
        public static bool InsertMauPhieuDienTim(MDB.MDBConnection oracleConnection, List<PhieuDienTim_DaoTrinh> lstDaoTrinh)
        {
            try
            {
                string sql = "";
                MDB.MDBCommand oracleCommand;
                if (lstDaoTrinh.Count > 0)
                {
                    sql = @"DELETE FROM MauPhieuDienTim ";
                    using (oracleCommand = new MDB.MDBCommand(sql, oracleConnection))
                    {
                        oracleCommand.ExecuteNonQuery();
                    }
                    for (int i = 0; i < lstDaoTrinh.Count; i++)
                    {  
                            sql = @"insert into MauPhieuDienTim(
                            SoTT,
                            ChuThich1,
                            ChuThich2,
                            FileName, 
                            NgayTao,
                            NguoiTao
                            ) VALUES( 
                            :SoTT,
                            :ChuThich1,
                            :ChuThich2,
                            :FileName, 
                            :NgayTao,
                            :NguoiTao
                            )";
                        oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
                        oracleCommand.Parameters.Add(new MDB.MDBParameter("SoTT", lstDaoTrinh[i].SoTT));
                        oracleCommand.Parameters.Add(new MDB.MDBParameter("ChuThich1", lstDaoTrinh[i].ChuThich1));
                        oracleCommand.Parameters.Add(new MDB.MDBParameter("ChuThich2", lstDaoTrinh[i].ChuThich2));
                        oracleCommand.Parameters.Add(new MDB.MDBParameter("FileName", lstDaoTrinh[i].FileName));
                        oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayTao", DateTime.Now));
                        oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiTao", Common.getUserLogin()));
                        int nRecord = oracleCommand.ExecuteNonQuery();
                    }
                } 
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<PhieuDienTim_DaoTrinh> getMauPhieuDienTim(MDB.MDBConnection MyConnection)
        {
            try
            {
                {
                    List<PhieuDienTim_DaoTrinh> lstObject = new List<PhieuDienTim_DaoTrinh>();
                    string sql = "SELECT * FROM MauPhieuDienTim  ORDER BY SoTT ASC";
                    MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                    MDB.MDBDataReader DataReader = command.ExecuteReader();
                    while (DataReader.Read())
                    {
                        PhieuDienTim_DaoTrinh obj = new PhieuDienTim_DaoTrinh();
                        obj.SoTT = Common.ConDBNull(DataReader["SoTT"]); 
                        obj.ChuThich1 = Common.ConDBNull(DataReader["ChuThich1"]);
                        obj.ChuThich2 = Common.ConDBNull(DataReader["ChuThich2"]);
                        obj.FileName = Common.ConDBNull(DataReader["FileName"]); 
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
    } 
    public class PhieuDienTim_DaoTrinh
    {
        public PhieuDienTim_DaoTrinh Clone()
        {
            PhieuDienTim_DaoTrinh other = (PhieuDienTim_DaoTrinh)this.MemberwiseClone();
            return other;
        }
        public string SoTT { get; set; }
        public string FileName { get; set;}
        public string ChuThich1 { get; set; }
        public string ChuThich2 { get; set; }
        public BitmapImage DuongDanAnh {
            get
            {
                //if (isSave) return null;
                if(string.IsNullOrWhiteSpace(FileName))
                {
                    return null;
                }
                if (!File.Exists(FileName))
                {
                    return null;
                }
                BitmapImage image = new BitmapImage();
                try
                {
                    using (var stream = File.OpenRead(FileName))
                    {  
                        image.BeginInit();
                        image.CacheOption = BitmapCacheOption.OnLoad;
                        image.StreamSource = stream;
                        image.EndInit();
                        //image.UriSource = new Uri(FileName);
                        //image.CacheOption = BitmapCacheOption.OnDemand;
                        //image.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
                        //image.EndInit();
                        image.Freeze();
                    }
                }
                catch (Exception ex)
                {
                    XuLyLoi.Handle(ex);
                }
                return image;
            }
        }
        public string linkAnhSelect { get; set; }

    }

}
