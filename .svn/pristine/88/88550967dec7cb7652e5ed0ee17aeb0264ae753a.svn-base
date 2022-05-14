
using EMR.KyDienTu;
using EMR_MAIN.Converter;
using MDB;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using static EMR_MAIN.DATABASE.Other.MauMaHoaChamSocFunc;

namespace EMR_MAIN.DATABASE.Other
{
    public class ThongTinChamSoc : ThongTinKy
    {
        public ThongTinChamSoc()
        {
            TableName = "THONGTINCHAMSOC";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.CS;
            TenMauPhieu = DanhMucPhieu.CS.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public decimal IDThongTinChamSoc { get; set; }
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
        [MoTaDuLieu("Buồng")]
		public string Buong { get; set; }
        [MoTaDuLieu("Giường")]
		public string Giuong { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public DateTime ThoiGian { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Diễn biến bệnh")]
		public string DienBienBenh { get; set; }
        [MoTaDuLieu("Y lệnh")]
		public string YLenh { get; set; }
        public string KyTen { get; set; }
        public string PhieuMau { get; set; }
        [MoTaDuLieu("Bác sỹ điều trị")]
		public string BacSyDieuTri { get; set; }
        public string SoVaoVien { get; set; }
        [MoTaDuLieu("Thực hiện y lệnh")]
		public string ThucHienYLenh { get; set; }
        public int TrangThai { get; set; } // 1: active , 0 : delete
        public decimal? MaDieuTri { get; set; }
        public DateTime? NgayVaoKhoa { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        public int NguonGoc { get; set; } = 0;
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
        public ThongTinChamSoc Clone()
        {
            return (ThongTinChamSoc)this.MemberwiseClone();
        }

    }

    public class ThongTinChamSocFunc
    {
        public const string TableName = "THONGTINCHAMSOC";
        public const string TablePrimaryKeyName = "IDTHONGTINCHAMSOC";
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ThongTinChamSoc ThongTinChamSoc)
        {

            string sql = @"update THONGTINCHAMSOC set SoYTe = :SoYTe, MaYTe= :MaYTe, BenhVien= :BenhVien, TenKhoa= :TenKhoa, MaBenhAn= :MaBenhAn, MaBenhNhan= :MaBenhNhan, TenBenhNhan= :TenBenhNhan, Tuoi= :Tuoi, DiaChi= :DiaChi, Buong= :Buong, Giuong= :Giuong, ChanDoan= :ChanDoan, ThoiGian= to_date(:ThoiGian,'yyyyMMddHH24mi'), DienBienBenh= :DienBienBenh,YLenh= :YLenh, KyTen= :KyTen, BacSyDieuTri= :BacSyDieuTri, GioiTinh = :GioiTinh, SoVaoVien =:SoVaoVien, ThucHienYLenh = :ThucHienYLenh, TrangThai = :TrangThai , MaQuanLy =:MaQuanLy, MaDieuTri = :MaDieuTri, NgayVaoKhoa = :NgayVaoKhoa WHERE IDThongTinChamSoc = " + ThongTinChamSoc.IDThongTinChamSoc + "";

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("SoYTe", ThongTinChamSoc.SoYTe));
            Command.Parameters.Add(new MDB.MDBParameter("MaYTe", ThongTinChamSoc.MaYTe));
            Command.Parameters.Add(new MDB.MDBParameter("BenhVien", ThongTinChamSoc.BenhVien));
            Command.Parameters.Add(new MDB.MDBParameter("TenKhoa", ThongTinChamSoc.TenKhoa));
            Command.Parameters.Add(new MDB.MDBParameter("MaBenhAn", ThongTinChamSoc.MaBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ThongTinChamSoc.MaBenhNhan));
            Command.Parameters.Add(new MDB.MDBParameter("TenBenhNhan", ThongTinChamSoc.TenBenhNhan));
            Command.Parameters.Add(new MDB.MDBParameter("Tuoi", ThongTinChamSoc.Tuoi));
            Command.Parameters.Add(new MDB.MDBParameter("DiaChi", ThongTinChamSoc.DiaChi));
            Command.Parameters.Add(new MDB.MDBParameter("Buong", ThongTinChamSoc.Buong));
            Command.Parameters.Add(new MDB.MDBParameter("Giuong", ThongTinChamSoc.Giuong));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", ThongTinChamSoc.ChanDoan));
            Command.Parameters.Add(new MDB.MDBParameter("ThoiGian", ThongTinChamSoc.ThoiGian.ToString("yyyyMMddHHmm")));
            Command.Parameters.Add(new MDB.MDBParameter("DienBienBenh", ThongTinChamSoc.DienBienBenh));
            Command.Parameters.Add(new MDB.MDBParameter("YLenh", ThongTinChamSoc.YLenh));
            Command.Parameters.Add(new MDB.MDBParameter("KyTen", ThongTinChamSoc.KyTen));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", ThongTinChamSoc.BacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("GioiTinh", ThongTinChamSoc.GioiTinh));
            Command.Parameters.Add(new MDB.MDBParameter("SoVaoVien", ThongTinChamSoc.SoVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("ThucHienYLenh", ThongTinChamSoc.ThucHienYLenh));
            Command.Parameters.Add(new MDB.MDBParameter("TrangThai", ThongTinChamSoc.TrangThai));
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", ThongTinChamSoc.MaQuanLy));
            Command.Parameters.Add(new MDB.MDBParameter("MaDieuTri", ThongTinChamSoc.MaDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("NgayVaoKhoa", ThongTinChamSoc.NgayVaoKhoa));
            int n = Command.ExecuteNonQuery();
            if (n == 0)
            {
                Command.Dispose();
                sql = @"insert into THONGTINCHAMSOC (SoYTe, MaYTe, BenhVien, TenKhoa, MaBenhAn, MaBenhNhan, TenBenhNhan, Tuoi, DiaChi, Buong, Giuong, ChanDoan, ThoiGian, DienBienBenh,YLenh, KyTen, BacSyDieuTri, GioiTinh,SoVaoVien,ThucHienYLenh, TrangThai, MaQuanLy, MaDieuTri, NgayVaoKhoa) values (:SoYTe, :MaYTe, :BenhVien, :TenKhoa, :MaBenhAn, :MaBenhNhan, :TenBenhNhan, :Tuoi, :DiaChi, :Buong, :Giuong, :ChanDoan,to_date(:ThoiGian,'yyyyMMddHH24mi'), :DienBienBenh, :YLenh, :KyTen, :BacSyDieuTri, :GioiTinh,:SoVaoVien,:ThucHienYLenh,:TrangThai, :MaQuanLy, :MaDieuTri, :NgayVaoKhoa)";
                Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("SoYTe", ThongTinChamSoc.SoYTe));
                Command.Parameters.Add(new MDB.MDBParameter("MaYTe", ThongTinChamSoc.MaYTe));
                Command.Parameters.Add(new MDB.MDBParameter("BenhVien", ThongTinChamSoc.BenhVien));
                Command.Parameters.Add(new MDB.MDBParameter("TenKhoa", ThongTinChamSoc.TenKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhAn", ThongTinChamSoc.MaBenhAn));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ThongTinChamSoc.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("TenBenhNhan", ThongTinChamSoc.TenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("Tuoi", ThongTinChamSoc.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", ThongTinChamSoc.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("Buong", ThongTinChamSoc.Buong));
                Command.Parameters.Add(new MDB.MDBParameter("Giuong", ThongTinChamSoc.Giuong));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", ThongTinChamSoc.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGian", ThongTinChamSoc.ThoiGian.ToString("yyyyMMddHHmm")));
                Command.Parameters.Add(new MDB.MDBParameter("DienBienBenh", ThongTinChamSoc.DienBienBenh));
                Command.Parameters.Add(new MDB.MDBParameter("YLenh", ThongTinChamSoc.YLenh));
                Command.Parameters.Add(new MDB.MDBParameter("KyTen", ThongTinChamSoc.KyTen));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", ThongTinChamSoc.BacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("GioiTinh", ThongTinChamSoc.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("SoVaoVien", ThongTinChamSoc.SoVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("ThucHienYLenh", ThongTinChamSoc.ThucHienYLenh));
                Command.Parameters.Add(new MDB.MDBParameter("TrangThai", ThongTinChamSoc.TrangThai));
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", ThongTinChamSoc.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuTri", ThongTinChamSoc.MaDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("NgayVaoKhoa", ThongTinChamSoc.NgayVaoKhoa));
                n = Command.ExecuteNonQuery();
                
            }
            return n > 0 ? true : false;
        }
        public static bool UpdateChanDoan_Maquanly(MDB.MDBConnection MyConnection, string Maquanly, string chanDoantxt)
        {
           string sql = @"update THONGTINCHAMSOC set ChanDoan = :ChanDoan WHERE MaQuanLy = " + Maquanly + "";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", chanDoantxt));
            int n = Command.ExecuteNonQuery();
            return n > 0 ? true : false;
        }
        public void TaoVanBanKy(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            if (XemBenhAn.TokenKy.IsNullOrEmpty())
            {
                ClientTokenManager clientTokenManager = new ClientTokenManager(ERMDatabase.KyDienTu_ApplicationCode, ERMDatabase.KyDienTu_DiaChiACS);
                clientTokenManager.UseRegistry(true);
                CommonParam param = new CommonParam();
                var tokenData = clientTokenManager.Init(param);
                if (tokenData != null)
                {
                    XemBenhAn.TokenKy = tokenData != null ? tokenData.TokenCode : "";
                    this.Info("TokenCode : " + XemBenhAn.TokenKy + ", UserName : " + tokenData != null && tokenData.User != null ? tokenData.User.LoginName : "");
                }
            }
            ChuKySo ky = new ChuKySo();

            if (XemBenhAn.TokenKy.IsNullOrEmpty())
            {
                throw new Exception("Không lấy được token ký");
            }
            else
            {
                var valid = ky.CheckTokenIsValid(XemBenhAn.TokenKy, ERMDatabase.KyDienTu_DiaChiACS, ERMDatabase.KyDienTu_ApplicationCode);
                if (valid == null)
                {
                    throw new Exception("Không lấy được token ký");
                }
            }

            MauMaHoaChamSocFunc lib = new MauMaHoaChamSocFunc();
            List<MaHoaChamSoc> _lstMaHoaChamSoc = lib.GetMaHoaChamSoc(MyConnection, "");
            DataSet ds = ThongTinChamSocFunc.GetDataSet(MyConnection, MaQuanLy, "");
            ds.Tables.Add(ListToDatatable.ToDataTable(_lstMaHoaChamSoc));
            InBenhAn.rptToChamSoc report = new InBenhAn.rptToChamSoc(ds);
            Report.Print(ds, report, true, false);
            string file = Report.PathExportPDF + "//" + Report.MyReport.DisplayName + ".pdf";
            if (System.IO.File.Exists(file))
            {
                byte[] bytes = System.IO.File.ReadAllBytes(file);
                var base64 = System.Convert.ToBase64String(bytes);
                ApiDataVanBanKy vb = new ApiDataVanBanKy()
                {
                    DocumentName = "Phiếu chăm sóc",
                    DocumentTypeId = 1,
                    TreatmentCode = MaQuanLy.ToString(),
                    HisCode =LoaiVanBanKyDienTu.PhieuChamSoc.ToString()+ "_" + MaQuanLy.ToString(),
                    OriginalVersion = new OriginalVersion()
                    {
                        Base64Data = base64,
                    }
                };
                ky.GoiVanBanSangEMRKy(ERMDatabase.KyDienTu_DiaChiEMR, ERMDatabase.KyDienTu_ApplicationCode, XemBenhAn.TokenKy, vb);
            }
            else
            {
                throw new Exception("Văn bản '"+ Report.MyReport.DisplayName + ".pdf" + "' không tồn tại");
            }
        }

        public static List<ThongTinChamSoc> GetData(MDB.MDBConnection MyConnection, decimal MaQuanLy, string TenKhoa, decimal? maDieuTri = null)
        {
            List<ThongTinChamSoc> lstData = new List<ThongTinChamSoc>();
            string sql = @"select * from THONGTINCHAMSOC WHERE  MaQuanLy = :MaQuanLy ";
            if (!string.IsNullOrEmpty(TenKhoa))
            {
                sql += " and TenKhoa = '" + TenKhoa + "' ";
            }
            if(maDieuTri != null)
            {
                sql += " and MaDieuTri = " + maDieuTri;
            }    
            sql += " ORDER BY ThoiGian asc";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            decimal temp = 0;
            DateTime dateTimeTemp = DateTime.Now;
            while (DataReader.Read())
            {
                try
                {
                    lstData.Add(new ThongTinChamSoc
                    {
                        IDThongTinChamSoc = DataReader.GetDecimal("IDThongTinChamSoc"),
                        BacSyDieuTri = DataReader["BacSyDieuTri"].ToString(),
                        BenhVien = DataReader["BenhVien"].ToString(),
                        Buong = DataReader["Buong"].ToString(),
                        ChanDoan = DataReader["ChanDoan"].ToString(),
                        SoYTe = DataReader["SoYTe"].ToString(),
                        DiaChi = DataReader["DiaChi"].ToString(),
                        DienBienBenh = DataReader["DienBienBenh"].ToString(),
                        Giuong = DataReader["Giuong"].ToString(),
                        KyTen = DataReader["KyTen"].ToString(),
                        MaBenhAn = DataReader["MaBenhAn"].ToString(),
                        MaBenhNhan = DataReader["MaBenhNhan"].ToString(),
                        MaYTe = DataReader["MaYTe"].ToString(),
                        ThoiGian = DataReader.GetDate("ThoiGian"),
                        TenBenhNhan = DataReader["TenBenhNhan"].ToString(),
                        TenKhoa = DataReader["TenKhoa"].ToString(),
                        Tuoi = DataReader["Tuoi"].ToString(),
                        YLenh = DataReader["YLenh"].ToString(),
                        GioiTinh = DataReader["GioiTinh"].ToString(),
                        SoVaoVien = DataReader["SoVaoVien"].ToString(),
                        ThucHienYLenh = DataReader["ThucHienYLenh"].ToString(),
                        TrangThai = DataReader.GetInt("TrangThai"),
                        MaQuanLy = DataReader.GetDecimal("MaQuanLy"),
                        MaSoKy = DataReader["masokyten"].ToString(),
                        DaKy = !string.IsNullOrEmpty(DataReader["masokyten"].ToString()) ? true : false,
                        MaDieuTri = decimal.TryParse(DataReader["MaDieuTri"].ToString(), out temp) ? (decimal?)temp : null,
                        NgayVaoKhoa = DateTime.TryParse(DataReader["NgayVaoKhoa"].ToString(), out dateTimeTemp) ? (DateTime?)dateTimeTemp : null,
                        NguonGoc = 1,
                    }); ;
                } catch (Exception ex)
                {
                    MDB.ExceptionExtend.LogError(ex);
                }
            }
            return lstData;
        }

        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, decimal MaQuanLy, string TenKhoa, string _DateFrom="", string _DateTo = "", decimal? IDThongTinChamSoc=null)
        {
            MDB.ExceptionExtend.Log(typeof(ThongTinChamSoc), "Start get data " + MaQuanLy);
            var timer = new Stopwatch();
            timer.Start();
            try
            {
                string sql = @"select a.*, to_char(thoigian, 'dd/MM/yyyy HH24:mi') thoigianbaocao, b.hovaten hotennguoiky from THONGTINCHAMSOC a left join NHANVIEN b on a.kyten = b.manhanvien WHERE a.MaQuanLy = :MaQuanLy";
                if (!String.IsNullOrEmpty(TenKhoa))
                {
                    sql += " and a.TenKhoa = '" + TenKhoa + "' ";
                }
                if (IDThongTinChamSoc != null && IDThongTinChamSoc.HasValue && IDThongTinChamSoc.Value != 0)
                {
                    sql += " and a.IDThongTinChamSoc = " + IDThongTinChamSoc;
                }
                if (_DateFrom.IsNotNullOrEmpty() && _DateTo.IsNotNullOrEmpty())
                {
                    try
                    {
                        DateTime dtiTu = PMS.Access.ThuVien.ToDate(_DateFrom);
                        DateTime dtiDen = PMS.Access.ThuVien.ToDate(_DateTo);
                        sql += " and a.ThoiGian >= to_date('" + dtiTu.ToString("dd/MM/yyyy HH:mm:ss") + "','dd/MM/yyyy hh24:mi:ss') and a.ThoiGian <= to_date('" + _DateTo + "','dd/MM/yyyy hh24:mi:ss') ";
                    }
                    catch(Exception ex) {
                        MDB.ExceptionExtend.LogError(ex);
                    }
                }
                sql += " ORDER BY a.ThoiGian asc";
                //XuLyLoi.LogDebug("dangtung - sql : " + sql);
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
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
                MDB.ExceptionExtend.Log(typeof(ThongTinChamSoc), "End get data " + MaQuanLy+". Total "+timer.ElapsedMilliseconds.ToString()+" ms");
            }
        }

        public static DataSet GetDataSetByDate(MDB.MDBConnection MyConnection, decimal MaQuanLy, string TenKhoa, DateTime _DateFrom, DateTime _DateTo)
        {
            if (_DateFrom == Convert.ToDateTime(null) || _DateTo == Convert.ToDateTime(null))
            {
                return GetDataSet(MyConnection, MaQuanLy, TenKhoa, "", "");
            }
            else
            {
                return GetDataSet(MyConnection, MaQuanLy, TenKhoa, _DateFrom.ToString("dd/MM/yyyy HH:mm:ss"), _DateTo.ToString("dd/MM/yyyy HH:mm:ss"));
            }
        }

        public static bool Delete(MDB.MDBConnection oracleConnection, string MaBenhAn, string TenKhoa)
        {
            string sql = @"Delete from ThongTinChamSoc where MaBenhAn = :MaBenhAn";
            if (!String.IsNullOrEmpty(TenKhoa))
                sql += " and TenKhoa = '" + TenKhoa + "' ";
            MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
            oracleCommand.Parameters.Add("MaBenhAn", MaBenhAn);

            int n = oracleCommand.ExecuteNonQuery();
            return n > 0 ? true : false;
        }

        public static bool DeleteById(MDB.MDBConnection oracleConnection, decimal IdThongTinChamSoc)
        {
            string sql = @"Delete from ThongTinChamSoc where IdThongTinChamSoc = :Id";
            MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
            oracleCommand.Parameters.Add("Id", IdThongTinChamSoc);

            int n = oracleCommand.ExecuteNonQuery();
            return n > 0 ? true : false;
        }

        public static DataTable GetToDieuTri(MDB.MDBConnection MyConnection, decimal MaQuanLy, string IDKhoaPhong)
        {
            try
            {
                string s_Sql = @"select x.idtodieutri, dienbien as DienBienBenh, x.tenbenh as ChanDoan, to_char(x.ngay,'dd/mm') as NgayTao, y.ylenh as YLenh from p_todieutri x inner join p_todieutri_ylenh y on y.idtodieutri=x.idtodieutri where x.maql=:maql and x.idkhoaphong=:idkhoaphong order by x.ngay desc";

                MDB.MDBCommand Command = new MDB.MDBCommand(s_Sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("maql", MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("idkhoaphong", IDKhoaPhong));
                MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                if (dt != null && dt.Rows.Count > 0)
                {
                    var value = from a in dt.AsEnumerable()
                                select new
                                {
                                    idtodieutri = Convert.ToDecimal(a["idtodieutri"].ToString()),
                                    DienBienBenh = a["DienBienBenh"].ToString(),
                                    ChanDoan = a["ChanDoan"].ToString(),
                                    NgayTao = a["NgayTao"].ToString(),
                                    YLenh = a["YLenh"].ToString(),
                                };
                    dt = Newtonsoft.Json.JsonConvert.DeserializeObject<DataTable>(Newtonsoft.Json.JsonConvert.SerializeObject(value));
                }
                return dt;
            }
            catch (Exception ex)
            {
                XuLyLoi.LogError(ex);
            }
            return null;
        }
        public static List<Khoa> getKhoaDaChamSoc(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql = "SELECT DISTINCT K.IDKhoa, K.MaKhoa, T.TenKhoa FROM ThongTinChamSoc T left join Khoa K on T.TenKhoa = K.TenKhoa WHERE T.MaQuanLy = " + MaQuanLy.ToString(System.Globalization.CultureInfo.InvariantCulture);
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            List<Khoa> lstData = new List<Khoa>();
            decimal decTemp = 0;
            if (decimal.TryParse(XemBenhAn._ThongTinDieuTri.MaKhoa, out decTemp))
                lstData.Add(new Khoa { IdKhoa = decTemp, TenKhoa = XemBenhAn._ThongTinDieuTri.Khoa });
            else
                lstData.Add(new Khoa { MaKhoa = XemBenhAn._ThongTinDieuTri.MaKhoa, TenKhoa = XemBenhAn._ThongTinDieuTri.Khoa });
            while (DataReader.Read())
            {
                try
                {
                    decimal idKhoa = decimal.TryParse(DataReader["IDKhoa"].ToString(), out decTemp) ? decTemp : 0;
                    if (idKhoa.ToString().Equals(XemBenhAn._ThongTinDieuTri.MaKhoa))
                    {
                        // Cần thiết lấy lại Tên khoa do vấn đề mã hóa 
                        lstData[0].TenKhoa = DataReader["TenKhoa"].ToString();
                        continue;
                    }
                    if (!lstData.Exists(x => x.TenKhoa.Equals(DataReader["TenKhoa"].ToString())))
                    {
                        lstData.Add(new Khoa
                        {
                            MaKhoa = DataReader["MaKhoa"].ToString(),
                            TenKhoa = DataReader["TenKhoa"].ToString(),
                        });
                    }
                }
                catch (Exception ex)
                {
                    MDB.ExceptionExtend.LogError(ex);
                }
            }
            return lstData;
        }
        public static List<DuLieuDieuTri> GetMaDieuTri(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            List<DuLieuDieuTri> listMaDieuTri = new List<DuLieuDieuTri>();
            try
            {
                string sql = "SELECT DISTINCT MaDieuTri, NgayVaoKhoa FROM ThongTinChamSoc  WHERE MaQuanLy = :MaQuanLy order by MaDieuTri";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                decimal decTemp = 0;
                DateTime NgayVaoKhoaTemp = DateTime.Now;
                while (DataReader.Read())
                {
                    bool check1 = decimal.TryParse(DataReader["MaDieuTri"].ToString(), out decTemp);
                    bool check2 =  DateTime.TryParse(DataReader["NgayVaoKhoa"].ToString(), out NgayVaoKhoaTemp);
                    if (check1 && check2)
                    {
                        listMaDieuTri.Add(new DuLieuDieuTri { MaDieuTri  = decTemp, NgayVaoKhoa = NgayVaoKhoaTemp });
                        decTemp = 0;
                    }
                    else if(check1)
                    {
                        listMaDieuTri.Add(new DuLieuDieuTri { MaDieuTri = decTemp});
                        decTemp = 0;
                    }    
                }
            }
            catch (Exception ex)
            {
                MDB.ExceptionExtend.LogError(ex);
            }
            return listMaDieuTri;
        }
    }
    public class DuLieuDieuTri
    {
        public decimal? MaDieuTri { get; set; }
        public DateTime? NgayVaoKhoa { get; set; }
        public string ToString()
        {
            string content = string.Empty;
            if (MaDieuTri.HasValue)
            {
                content = MaDieuTri.Value.ToString();
            }
            if(NgayVaoKhoa.HasValue)
            {
                content += " - " + NgayVaoKhoa.Value.ToString("dd/MM/yyyy");
            }
            return content;
        }    
    }
}
