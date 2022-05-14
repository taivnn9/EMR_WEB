using DevExpress.XtraReports.UI;
using EMR.KyDienTu;
using EMR_MAIN.InBenhAn;
using Inventec.WCF.JsonConvert;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuBieuDoChuyenDa : ThongTinKy
    {
        [MoTaDuLieu("Mã định danh")]
		public int ID { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        public string SoVaoVien { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        public int LanCoThai { get; set; }
        public int LanDe { get; set; }
        public DateTime NgayVao { get; set; }
        public int GioVao { get; set; }
        public bool DaVoOi { get; set; }
        public DateTime? NgayVoOi { get; set; }
        public int? GioVoOi { get; set; }
        [MoTaDuLieu("Ghi chú")]
		public string GhiChu { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        public int SoPhieu { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon {get;set;}

    }
    public class BieuDoChuyenDaChiTiet
    {
        [MoTaDuLieu("Mã định danh")]
		public int ID { set; get; }
        public int BieuDoChuyenDaID { get; set; }
        public int SoPhieu { get; set; }
        public DateTime Ngay { get; set; }
        public int Gio { get; set; }
        public int Phut { get; set; }
        public float Mach { get; set; }
        public float HuyetApMax { get; set; }
        public float HuyetApMin { get; set; }
        public float NhietDo { get; set; }
        [MoTaDuLieu("Nước tiểu")]
		public string NuocTieu { get; set; }
        public float NhipTimThai { get; set; }
        public string TinhTrangOi { get; set; }
        public string ChongKhop { get; set; }
        public float? DoMoCoTuCung { get; set; }
        public float? TienTrienNgoiThai { get; set; }
        public float SoConCo { get; set; }
        public float ThoiGianCo { get; set; }
        public string DienBietXuTri { get; set; }
        public string NguoiTheoDoi { get; set; }
        public string GhiChuCoTC { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        public  BieuDoChuyenDaChiTiet()
        {
            DoMoCoTuCung = null;
            TienTrienNgoiThai = null;
        }
        public BieuDoChuyenDaChiTiet Clone()
        {
            return (BieuDoChuyenDaChiTiet)this.MemberwiseClone();
        }
    }
    public class PhieuBieuDoChuyenDaFunc
    {
        public const string TableName = "BIEUDOCHUYENDA";
        public const string TablePrimaryKeyName = "ID";
        public List<BieuDoChuyenDaChiTiet> SelectBieuDoChuyenDaChiTiet(MDB.MDBConnection MyConnection, int IdBieuDoChuyenDa, int soPhieu, bool ModeIn= false)
        {
            try
            {

                // Tunght ADD ICLOUD???
                List<BieuDoChuyenDaChiTiet> listResult = new List<BieuDoChuyenDaChiTiet>();
                DateTime? dateRet = null;
                if (ModeIn)
                {
                    decimal ID = 0;
                    dateRet = ThoiGianBatDauVe(MyConnection, IdBieuDoChuyenDa, soPhieu, ref ID);
                    if (dateRet == null)
                    {
                        return listResult;
                    }
                }
                string sql = @"SELECT *
                        FROM BIEUDOCHUYENDA_CHITIET  
                        WHERE BIEUDOCHUYENDA_ID = :BIEUDOCHUYENDA_ID AND SOPHIEU = :SOPHIEU AND IS_DELETE = 0 ";
                if(ModeIn)
                {
                    sql = sql + " and Ngay >= To_Date('" + Common.ConDB_DateTime(dateRet).ToString("yyyy-MM-dd HH:00") + "', 'YYYY-MM-DD hh24:mi') and Ngay <To_Date('" + Common.ConDB_DateTime(dateRet).AddDays(1).ToString("yyyy-MM-dd HH:00") + "', 'YYYY-MM-DD hh24:mi') ";
                }
                sql = sql + " order by NGAY ASC ";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("BIEUDOCHUYENDA_ID", IdBieuDoChuyenDa));
                Command.Parameters.Add(new MDB.MDBParameter("SOPHIEU", soPhieu));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    BieuDoChuyenDaChiTiet bieuDo = new BieuDoChuyenDaChiTiet();
                    bieuDo.ID = int.Parse(DataReader["ID"].ToString());
                    bieuDo.BieuDoChuyenDaID = IdBieuDoChuyenDa;
                    bieuDo.SoPhieu = soPhieu;
                    DateTime tempDate = DateTime.Now;
                    if(DataReader["NGAY"] != null)
                        DateTime.TryParse(DataReader["NGAY"].ToString(), out tempDate);
                    bieuDo.Ngay = tempDate;
                    int intTemp = 0;
                    if (DataReader["GIO"] != null)
                        int.TryParse(DataReader["GIO"].ToString(), out intTemp);
                    bieuDo.Gio = intTemp;

                    intTemp = 0;
                    if(DataReader["PHUT"] != null)
                        int.TryParse(DataReader["PHUT"].ToString(), out intTemp);
                    bieuDo.Phut = intTemp;

                    float floatTemp = 0;
                    if(DataReader["MACH"] != null)
                        float.TryParse(DataReader["MACH"].ToString(), out floatTemp);
                    bieuDo.Mach = floatTemp;

                    floatTemp = 0;
                    if (DataReader["HUYET_AP_MAX"] != null)
                        float.TryParse(DataReader["HUYET_AP_MAX"].ToString(), out floatTemp);
                    bieuDo.HuyetApMax = floatTemp;

                    floatTemp = 0;
                    if(DataReader["HUYET_AP_MIN"] != null)
                        float.TryParse(DataReader["HUYET_AP_MIN"].ToString(), out floatTemp);
                    bieuDo.HuyetApMin = floatTemp;

                    floatTemp = 0;
                    if(DataReader["NHIET_DO"] != null)
                        float.TryParse(DataReader["NHIET_DO"].ToString(), out floatTemp);
                    bieuDo.NhietDo = floatTemp;

                    //floatTemp = 0;
                    //if(DataReader["NUOC_TIEU"] != null)
                    //{
                    //    float.TryParse(DataReader["NUOC_TIEU"].ToString(), out floatTemp);
                    //}
                    bieuDo.NuocTieu = DataReader["ProteinNuocTieu"].ToString();

                    floatTemp = 0;
                    if (DataReader["NHIP_TIM_THAI"] != null)
                        float.TryParse(DataReader["NHIP_TIM_THAI"].ToString(), out floatTemp);
                    bieuDo.NhipTimThai = floatTemp;

                    bieuDo.TinhTrangOi = DataReader["TINH_TRANG_OI"].ToString();

                    bieuDo.ChongKhop = DataReader["CHONG_KHOP"].ToString();


                    bieuDo.GhiChuCoTC = DataReader["GHI_CHU_CO_TC"].ToString();

                    //floatTemp = 0;
                    //if(DataReader["DO_MO_CTC"] != null)
                    //    float.TryParse(DataReader["DO_MO_CTC"].ToString(), out floatTemp);
                    bieuDo.DoMoCoTuCung = ConDBNull_float(DataReader["DO_MO_CTC"]);

                    floatTemp = 0;
                    if(DataReader["TT_NGOI_THAI"] != null)
                        float.TryParse(DataReader["TT_NGOI_THAI"].ToString(), out floatTemp);
                    bieuDo.TienTrienNgoiThai = ConDBNull_float(DataReader["TT_NGOI_THAI"]);

                    floatTemp = 0;
                    if (DataReader["SO_CON_CO"] != null)
                        float.TryParse(DataReader["SO_CON_CO"].ToString(), out floatTemp);
                    bieuDo.SoConCo = floatTemp;

                    floatTemp = 0;
                    if (DataReader["THOI_GIAN_CO"] != null)
                        float.TryParse(DataReader["THOI_GIAN_CO"].ToString(), out floatTemp);
                    bieuDo.ThoiGianCo = floatTemp;

                    bieuDo.DienBietXuTri = DataReader["DIENBIEUXUTRI"] != null ? DataReader["DIENBIEUXUTRI"].ToString() : null;
                    bieuDo.NguoiTheoDoi = DataReader["NGUOI_THEO_DOI"] != null ? DataReader["NGUOI_THEO_DOI"].ToString() : null;
                    bieuDo.NguoiTao = DataReader["NGUOI_TAO"] != null ? DataReader["NGUOI_TAO"].ToString() : null;

                    tempDate = DateTime.Now;
                    if (DataReader["NGAY_TAO"] != null)
                        DateTime.TryParse(DataReader["NGAY_TAO"].ToString(), out tempDate);
                    bieuDo.NgayTao = tempDate;
                    bieuDo.NguoiSua = DataReader["NGUOI_SUA"] != null ? DataReader["NGUOI_SUA"].ToString() : null;
                    
                    tempDate = DateTime.Now;
                    if (DataReader["NGAY_SUA"] != null)
                        DateTime.TryParse(DataReader["NGAY_SUA"].ToString(), out tempDate);
                    bieuDo.NgaySua = tempDate;
                    listResult.Add(bieuDo);
                }
                return listResult;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return null;
        }
        public DateTime? ThoiGianBatDauVe(MDB.MDBConnection MyConnection, int IdBieuDoChuyenDa, int soPhieu, ref decimal ID)
        {
            DateTime? bRet = null;
            try
            {
                // Tunght ADD ICLOUD???
                List<BieuDoChuyenDaChiTiet> listResult = new List<BieuDoChuyenDaChiTiet>();
                string sql = @"SELECT min(ngay) as Ngay, ID
                        FROM BIEUDOCHUYENDA_CHITIET  
                        WHERE BIEUDOCHUYENDA_ID = :BIEUDOCHUYENDA_ID AND SOPHIEU = :SOPHIEU AND IS_DELETE = 0 AND DO_MO_CTC >= 0  AND TT_NGOI_Thai >= 0 Group by ID  order by NGAY ASC ";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("BIEUDOCHUYENDA_ID", IdBieuDoChuyenDa));
                Command.Parameters.Add(new MDB.MDBParameter("SOPHIEU", soPhieu));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    bRet = Common.ConDB_DateTimeNull(DataReader["Ngay"]);
                    ID = Common.ConDB_Decimal(DataReader["ID"]);
                    break;
                }
                return bRet;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return null;
        }
        public static float? ConDBNull_float(object dbVal)
        {
            float ret = 0;
            if (dbVal == null)
            {
                return null;
            }
            bool isSuccess = float.TryParse(dbVal.ToString(), out ret);
            if (isSuccess == false)
            {
                return null;
            }
            return ret;
        }
        public List<BieuDoChuyenDaChiTiet> GetListBieuDo_TienTrienDe(MDB.MDBConnection MyConnection, int IdBieuDoChuyenDa, int soPhieu, bool ModeIn = false)
        {
            try
            {
                List<BieuDoChuyenDaChiTiet> listResult = new List<BieuDoChuyenDaChiTiet>();
                string sql = @"select AA.gio, AA.do_mo_ctc, BB.TT_NGOI_THAI from  (select gio, max(NVL(do_mo_ctc,-1)) as do_mo_ctc   FROM BIEUDOCHUYENDA_CHITIET  WHERE BIEUDOCHUYENDA_ID = :BIEUDOCHUYENDA_ID AND SOPHIEU = :SOPHIEU AND IS_DELETE = 0 group by gio)AA
                        INNER join (select gio,max(NVL(TT_NGOI_THAI,-1)) as  TT_NGOI_THAI  FROM BIEUDOCHUYENDA_CHITIET WHERE BIEUDOCHUYENDA_ID = :BIEUDOCHUYENDA_ID AND SOPHIEU = :SOPHIEU AND IS_DELETE = 0 group by gio)BB on  
                        AA.gio = BB.gio order by AA.gio ASC";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("BIEUDOCHUYENDA_ID", IdBieuDoChuyenDa));
                Command.Parameters.Add(new MDB.MDBParameter("SOPHIEU", soPhieu));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    BieuDoChuyenDaChiTiet bieuDo = new BieuDoChuyenDaChiTiet();
                    int intTemp = 0;
                    if (DataReader["GIO"] != null)
                        int.TryParse(DataReader["GIO"].ToString(), out intTemp);
                    bieuDo.Gio = intTemp;
                    
                    //float floatTemp = 0;
                    //if (DataReader["DO_MO_CTC"] != null)
                    //    float.TryParse(DataReader["DO_MO_CTC"].ToString(), out floatTemp);
                    bieuDo.DoMoCoTuCung = ConDBNull_float(DataReader["DO_MO_CTC"]);

                    //floatTemp = 0;
                    //if (DataReader["TT_NGOI_THAI"] != null)
                    //    float.TryParse(DataReader["TT_NGOI_THAI"].ToString(), out floatTemp);
                    bieuDo.TienTrienNgoiThai = ConDBNull_float(DataReader["TT_NGOI_THAI"]);
                    listResult.Add(bieuDo);
                }
                return listResult;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return null;
        }
        public bool InsertBieuDoChuyenDaChiTiet(MDB.MDBConnection MyConnection, BieuDoChuyenDaChiTiet bieuDo)
        {
            try
            {
                string sql = @"INSERT INTO BIEUDOCHUYENDA_CHITIET (BIEUDOCHUYENDA_ID, SOPHIEU, NGAY, GIO, PHUT, MACH, 
                                            HUYET_AP_MAX, HUYET_AP_MIN, NHIET_DO, ProteinNuocTieu, NHIP_TIM_THAI, TINH_TRANG_OI,
                                            CHONG_KHOP, DO_MO_CTC, GHI_CHU_CO_TC, TT_NGOI_THAI, SO_CON_CO, THOI_GIAN_CO, DIENBIEUXUTRI, NGUOI_THEO_DOI, 
                                            NGUOI_TAO, NGAY_TAO, NGUOI_SUA, NGAY_SUA, IS_DELETE) 
                                        VALUES (:BIEUDOCHUYENDA_ID, :SOPHIEU, :NGAY, :GIO, :PHUT, :MACH,
                                            :HUYET_AP_MAX, :HUYET_AP_MIN, :NHIET_DO, :ProteinNuocTieu, :NHIP_TIM_THAI, :TINH_TRANG_OI,
                                            :CHONG_KHOP, :DO_MO_CTC, :GHI_CHU_CO_TC, :TT_NGOI_THAI, :SO_CON_CO, :THOI_GIAN_CO, :DIENBIEUXUTRI, :NGUOI_THEO_DOI,
                                            :NGUOI_TAO, :NGAY_TAO, :NGUOI_SUA, :NGAY_SUA, 0) RETURNING ID INTO :ID";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

                Command.Parameters.Add(new MDB.MDBParameter("BIEUDOCHUYENDA_ID", bieuDo.BieuDoChuyenDaID));
                Command.Parameters.Add(new MDB.MDBParameter("SOPHIEU", bieuDo.SoPhieu));
                Command.Parameters.Add(new MDB.MDBParameter("NGAY", bieuDo.Ngay));
                Command.Parameters.Add(new MDB.MDBParameter("GIO", bieuDo.Gio));
                Command.Parameters.Add(new MDB.MDBParameter("PHUT", bieuDo.Phut));
                Command.Parameters.Add(new MDB.MDBParameter("MACH", bieuDo.Mach));
                Command.Parameters.Add(new MDB.MDBParameter("HUYET_AP_MAX", bieuDo.HuyetApMax));
                Command.Parameters.Add(new MDB.MDBParameter("HUYET_AP_MIN", bieuDo.HuyetApMin));
                Command.Parameters.Add(new MDB.MDBParameter("NHIET_DO", bieuDo.NhietDo));
                Command.Parameters.Add(new MDB.MDBParameter("ProteinNuocTieu", bieuDo.NuocTieu));
                Command.Parameters.Add(new MDB.MDBParameter("NHIP_TIM_THAI", bieuDo.NhipTimThai));
                Command.Parameters.Add(new MDB.MDBParameter("TINH_TRANG_OI", bieuDo.TinhTrangOi));
                Command.Parameters.Add(new MDB.MDBParameter("CHONG_KHOP", bieuDo.ChongKhop));
                Command.Parameters.Add(new MDB.MDBParameter("DO_MO_CTC", bieuDo.DoMoCoTuCung));
                Command.Parameters.Add(new MDB.MDBParameter("GHI_CHU_CO_TC", bieuDo.GhiChuCoTC));
                Command.Parameters.Add(new MDB.MDBParameter("TT_NGOI_THAI", bieuDo.TienTrienNgoiThai));
                Command.Parameters.Add(new MDB.MDBParameter("SO_CON_CO", bieuDo.SoConCo));
                Command.Parameters.Add(new MDB.MDBParameter("THOI_GIAN_CO", bieuDo.ThoiGianCo));
                Command.Parameters.Add(new MDB.MDBParameter("DIENBIEUXUTRI", bieuDo.DienBietXuTri));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOI_THEO_DOI", bieuDo.NguoiTheoDoi));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOI_TAO", bieuDo.NguoiTao));
                Command.Parameters.Add(new MDB.MDBParameter("NGAY_TAO", bieuDo.NgayTao));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOI_SUA", bieuDo.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAY_SUA", bieuDo.NgaySua));
                Command.Parameters.Add(new MDB.MDBParameter("ID", bieuDo.ID));
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery(); // C#
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }

        public bool deleteBieuDoChiTiet(MDB.MDBConnection MyConnection, BieuDoChuyenDaChiTiet bieuDoChuyenDaChiTiet)
        {
            try
            {
                string sql = @"UPDATE BIEUDOCHUYENDA_CHITIET SET IS_DELETE = 1 
                                    WHERE (ID = :ID) AND IS_DELETE = 0";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID", bieuDoChuyenDaChiTiet.ID));
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();

                return n > 0 ? true : false;

            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }

        public bool UpdateBieuDoChuyenDaChiTiet(MDB.MDBConnection MyConnection, BieuDoChuyenDaChiTiet bieuDo)
        {
            try
            {
                string sql = @"UPDATE BIEUDOCHUYENDA_CHITIET SET  
                            NGAY = :NGAY, 
                            GIO = :GIO, 
                            PHUT = :PHUT, 
                            MACH = :MACH, 
                            HUYET_AP_MAX = :HUYET_AP_MAX,
                            HUYET_AP_MIN = :HUYET_AP_MIN, 
                            NHIET_DO = :NHIET_DO, 
                            ProteinNuocTieu = :ProteinNuocTieu, 
                            NHIP_TIM_THAI = :NHIP_TIM_THAI, 
                            TINH_TRANG_OI = :TINH_TRANG_OI, 
                            CHONG_KHOP = :CHONG_KHOP, 
                            DO_MO_CTC = :DO_MO_CTC,
                            GHI_CHU_CO_TC = :GHI_CHU_CO_TC,
                            TT_NGOI_THAI = :TT_NGOI_THAI,
                            SO_CON_CO = :SO_CON_CO,
                            THOI_GIAN_CO = :THOI_GIAN_CO,
                            DIENBIEUXUTRI = :DIENBIEUXUTRI, 
                            NGUOI_THEO_DOI = :NGUOI_THEO_DOI,
                            NGUOI_SUA = :NGUOI_SUA,
                            NGAY_SUA = :NGAY_SUA   
                        WHERE ID = " + bieuDo.ID;
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

                Command.Parameters.Add(new MDB.MDBParameter("NGAY", bieuDo.Ngay));
                Command.Parameters.Add(new MDB.MDBParameter("GIO", bieuDo.Gio));
                Command.Parameters.Add(new MDB.MDBParameter("PHUT", bieuDo.Phut));
                Command.Parameters.Add(new MDB.MDBParameter("MACH", bieuDo.Mach));
                Command.Parameters.Add(new MDB.MDBParameter("HUYET_AP_MAX", bieuDo.HuyetApMax));
                Command.Parameters.Add(new MDB.MDBParameter("HUYET_AP_MIN", bieuDo.HuyetApMin));
                Command.Parameters.Add(new MDB.MDBParameter("NHIET_DO", bieuDo.NhietDo));
                Command.Parameters.Add(new MDB.MDBParameter("ProteinNuocTieu", bieuDo.NuocTieu));
                Command.Parameters.Add(new MDB.MDBParameter("NHIP_TIM_THAI", bieuDo.NhipTimThai));
                Command.Parameters.Add(new MDB.MDBParameter("TINH_TRANG_OI", bieuDo.TinhTrangOi));
                Command.Parameters.Add(new MDB.MDBParameter("CHONG_KHOP", bieuDo.ChongKhop));
                Command.Parameters.Add(new MDB.MDBParameter("DO_MO_CTC", bieuDo.DoMoCoTuCung));
                Command.Parameters.Add(new MDB.MDBParameter("GHI_CHU_CO_TC", bieuDo.GhiChuCoTC));
                Command.Parameters.Add(new MDB.MDBParameter("TT_NGOI_THAI", bieuDo.TienTrienNgoiThai));
                Command.Parameters.Add(new MDB.MDBParameter("SO_CON_CO", bieuDo.SoConCo));
                Command.Parameters.Add(new MDB.MDBParameter("THOI_GIAN_CO", bieuDo.ThoiGianCo));
                Command.Parameters.Add(new MDB.MDBParameter("DIENBIEUXUTRI", bieuDo.DienBietXuTri));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOI_THEO_DOI", bieuDo.NguoiTheoDoi));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOI_SUA", bieuDo.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAY_SUA", bieuDo.NgaySua));
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery(); // C#
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public List<PhieuBieuDoChuyenDa> Select(MDB.MDBConnection MyConnection, string MaQuanLy)
        {
            try
            {
                List<PhieuBieuDoChuyenDa> listResult = new List<PhieuBieuDoChuyenDa>();
                string sql = @"SELECT *
                    FROM BIEUDOCHUYENDA 
                    WHERE MaQuanLy = :MaQuanLy AND IS_DELETE = 0";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuBieuDoChuyenDa currentPhieu = new PhieuBieuDoChuyenDa();
                    currentPhieu.ID = int.Parse(DataReader["ID"].ToString());
                    currentPhieu.MaBenhNhan = DataReader["MA_BN"] != null ? DataReader["MA_BN"].ToString() : null;
                    currentPhieu.TenBenhNhan = DataReader["TEN_BN"] != null ? DataReader["TEN_BN"].ToString() : null;
                    currentPhieu.SoVaoVien = DataReader["SO_VAO_VIEN"] != null ? DataReader["SO_VAO_VIEN"].ToString() : null;
                    currentPhieu.Tuoi = DataReader["TUOI"] != null ? DataReader["TUOI"].ToString() : null;
                    currentPhieu.GioiTinh = DataReader["GIOI_TINH"] != null ? DataReader["GIOI_TINH"].ToString() : null;
                    currentPhieu.LanCoThai = DataReader["LAN_CO_THAI"] != null ? int.Parse(DataReader["LAN_CO_THAI"].ToString()) : 0;
                    currentPhieu.LanDe = DataReader["LAN_DE"] != null ? int.Parse(DataReader["LAN_DE"].ToString()) : 0;
                    currentPhieu.NgayVao = DataReader["NGAY_VAO"] != null ? DateTime.Parse(DataReader["NGAY_VAO"].ToString()) : DateTime.Today;
                    currentPhieu.GioVao = DataReader["GIO_VAO"] != null ? int.Parse(DataReader["GIO_VAO"].ToString()) : 0;
                    int intTemp = 0;
                    if(DataReader["DA_VO_OI"] != null )
                    {
                        int.TryParse(DataReader["DA_VO_OI"].ToString(), out intTemp);
                    }
                    if (intTemp == 1)
                        currentPhieu.DaVoOi = true;
                    else
                        currentPhieu.DaVoOi = false;
                    currentPhieu.NgayVoOi = DataReader["NGAY_VO_OI"] != null ? DateTime.Parse(DataReader["NGAY_VO_OI"].ToString()) : DateTime.Today;
                    currentPhieu.GioVoOi = DataReader["GIO_VO_OI"] != null ? int.Parse(DataReader["GIO_VO_OI"].ToString()) : 0;
                    currentPhieu.GhiChu = DataReader["GHI_CHU"] != null ? DataReader["GHI_CHU"].ToString() : null;
                    currentPhieu.NgayTao = DataReader["NGAY_TAO"] != null ? DateTime.Parse(DataReader["NGAY_TAO"].ToString()) : DateTime.Today;
                    currentPhieu.NguoiTao = DataReader["NGUOI_TAO"] != null ? DataReader["NGUOI_TAO"].ToString() : null;
                    currentPhieu.NgaySua = DataReader["NGAY_SUA"] != null ? DateTime.Parse(DataReader["NGAY_SUA"].ToString()) : DateTime.Today;
                    currentPhieu.NguoiSua = DataReader["NGUOI_SUA"] != null ? DataReader["NGUOI_SUA"].ToString() : null;
                    currentPhieu.SoPhieu = DataReader["SOPHIEU"] != null ? int.Parse(DataReader["SOPHIEU"].ToString()) : 1;

                    currentPhieu.MaSoKy = DataReader["masokyten"].ToString();
                    currentPhieu.DaKy = !string.IsNullOrEmpty(currentPhieu.MaSoKy) ? true : false;
                    listResult.Add(currentPhieu);
                }
                return listResult;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return null;
        }
        public PhieuBieuDoChuyenDa getPhieuBieuDoChuyenDa(MDB.MDBConnection MyConnection, string MaBenhNhan, int BieuDoChuyenDaID) {

            string sql  = @"
                SELECT
	                TEN_BN,
	                TUOI,
	                GIOI_TINH,
	                LAN_CO_THAI,
	                LAN_DE,
	                NGAY_VAO,
	                GIO_VAO,
	                NGAY_VO_OI,
	                GIO_VO_OI,
                    SOPHIEU,
                    DA_VO_OI
                FROM
	                BIEUDOCHUYENDA 
                WHERE
	                ID = :BieuDoChuyenDaID";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("BieuDoChuyenDaID", BieuDoChuyenDaID));
            Command.BindByName = true;
            MDB.MDBDataReader DataReader_BDND = Command.ExecuteReader();
            PhieuBieuDoChuyenDa bieudochuyenda = new PhieuBieuDoChuyenDa();
            while (DataReader_BDND.Read())
            {
                bieudochuyenda.TenBenhNhan = DataReader_BDND["TEN_BN"] != null ? DataReader_BDND["TEN_BN"].ToString() : null;
                bieudochuyenda.Tuoi = DataReader_BDND["TUOI"] != null ? DataReader_BDND["TUOI"].ToString() : null;
                bieudochuyenda.GioiTinh = DataReader_BDND["GIOI_TINH"] != null ? DataReader_BDND["GIOI_TINH"].ToString() : null;
                bieudochuyenda.LanCoThai = DataReader_BDND["LAN_CO_THAI"] != null ? Int32.Parse(DataReader_BDND["LAN_CO_THAI"].ToString()) : 0;
                bieudochuyenda.LanDe = DataReader_BDND["LAN_DE"] != null ? Int32.Parse(DataReader_BDND["LAN_DE"].ToString()) : 0;
                bieudochuyenda.GioVao = DataReader_BDND["GIO_VAO"] != null ? Int32.Parse(DataReader_BDND["GIO_VAO"].ToString()) : 0;
                bieudochuyenda.GioVoOi = DataReader_BDND["GIO_VO_OI"] != null ? Int32.Parse(DataReader_BDND["GIO_VO_OI"].ToString()) : 0;
                bieudochuyenda.NgayVao = DataReader_BDND["NGAY_VAO"] != null ? DateTime.Parse(DataReader_BDND["NGAY_VAO"].ToString()) : DateTime.Now;
                bieudochuyenda.NgayVoOi = DataReader_BDND["NGAY_VO_OI"] != null ? DateTime.Parse(DataReader_BDND["NGAY_VO_OI"].ToString()) : DateTime.Now;
                bieudochuyenda.SoPhieu = DataReader_BDND["SOPHIEU"] != null ? Int32.Parse(DataReader_BDND["SOPHIEU"].ToString()) : 0;
                bieudochuyenda.DaVoOi = DataReader_BDND["DA_VO_OI"].ToString().Trim().Equals("1") ? true : false;
            }
            return bieudochuyenda;
          
            //new ReportPrintTool(report).Print();
        }
        //using for API CLOUD
        public string[] getDataForPrint(MDB.MDBConnection MyConnection, string MaBenhNhan, int BieuDoChuyenDaID)
        {

            string sql = @"
                SELECT
	                SOYTE, BENHVIEN
                FROM
	                HANHCHINHBENHNHAN 
                WHERE
	                MABENHNHAN = :MABENHNHAN";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MABENHNHAN", MaBenhNhan));
            Command.BindByName = true;
            MDB.MDBDataReader DataReader_HCBN = Command.ExecuteReader();
            HanhChinhBenhNhan hanhchinhbenhnhan = new HanhChinhBenhNhan();
            while (DataReader_HCBN.Read())
            {
                hanhchinhbenhnhan.SoYTe = DataReader_HCBN["SOYTE"] != null ? DataReader_HCBN["SOYTE"].ToString() : null;
                hanhchinhbenhnhan.BenhVien = DataReader_HCBN["BENHVIEN"] != null ? DataReader_HCBN["BENHVIEN"].ToString() : null;
            }


            sql = @"
                SELECT
	                TEN_BN,
	                TUOI,
	                GIOI_TINH,
	                LAN_CO_THAI,
	                LAN_DE,
	                NGAY_VAO,
	                GIO_VAO,
	                NGAY_VO_OI,
	                GIO_VO_OI,
                    SOPHIEU,
                    DA_VO_OI
                FROM
	                BIEUDOCHUYENDA 
                WHERE
	                ID = :BieuDoChuyenDaID";
            Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("BieuDoChuyenDaID", BieuDoChuyenDaID));
            Command.BindByName = true;
            MDB.MDBDataReader DataReader_BDND = Command.ExecuteReader();
            PhieuBieuDoChuyenDa bieudochuyenda = new PhieuBieuDoChuyenDa();
            while (DataReader_BDND.Read())
            {
                bieudochuyenda.TenBenhNhan = DataReader_BDND["TEN_BN"] != null ? DataReader_BDND["TEN_BN"].ToString() : null;
                bieudochuyenda.Tuoi = DataReader_BDND["TUOI"] != null ? DataReader_BDND["TUOI"].ToString() : null;
                bieudochuyenda.GioiTinh = DataReader_BDND["GIOI_TINH"] != null ? DataReader_BDND["GIOI_TINH"].ToString() : null;
                bieudochuyenda.LanCoThai = DataReader_BDND["LAN_CO_THAI"] != null ? Int32.Parse(DataReader_BDND["LAN_CO_THAI"].ToString()) : 0;
                bieudochuyenda.LanDe = DataReader_BDND["LAN_DE"] != null ? Int32.Parse(DataReader_BDND["LAN_DE"].ToString()) : 0;
                bieudochuyenda.GioVao = DataReader_BDND["GIO_VAO"] != null ? Int32.Parse(DataReader_BDND["GIO_VAO"].ToString()) : 0;
                bieudochuyenda.GioVoOi = DataReader_BDND["GIO_VO_OI"] != null ? Int32.Parse(DataReader_BDND["GIO_VO_OI"].ToString()) : 0;
                bieudochuyenda.NgayVao = DataReader_BDND["NGAY_VAO"] != null ? DateTime.Parse(DataReader_BDND["NGAY_VAO"].ToString()) : DateTime.Now;
                bieudochuyenda.NgayVoOi = DataReader_BDND["NGAY_VO_OI"] != null ? DateTime.Parse(DataReader_BDND["NGAY_VO_OI"].ToString()) : DateTime.Now;
                bieudochuyenda.SoPhieu = DataReader_BDND["SOPHIEU"] != null ? Int32.Parse(DataReader_BDND["SOPHIEU"].ToString()) : 0;
                bieudochuyenda.DaVoOi = DataReader_BDND["DA_VO_OI"].ToString().Trim().Equals("1") ? true : false;
            }

            return new string[2] { Newtonsoft.Json.JsonConvert.SerializeObject(hanhchinhbenhnhan), Newtonsoft.Json.JsonConvert.SerializeObject(bieudochuyenda) };
        }
        public bool Insert(MDB.MDBConnection MyConnection, PhieuBieuDoChuyenDa phieuBieuDoChuyenDa)
        {
            try
            {
                string sql = @"INSERT INTO BIEUDOCHUYENDA (MA_BN, TEN_BN, SO_VAO_VIEN, TUOI, GIOI_TINH, 
                                            LAN_CO_THAI, LAN_DE, NGAY_VAO, GIO_VAO, DA_VO_OI, NGAY_VO_OI,
                                            GIO_VO_OI, GHI_CHU, NGAY_TAO, NGUOI_TAO, NGAY_SUA, 
                                            NGUOI_SUA, SOPHIEU, MAQUANLY, IS_DELETE) 
                                        VALUES (:MA_BN, :TEN_BN, :SO_VAO_VIEN, :TUOI, :GIOI_TINH,
                                            :LAN_CO_THAI, :LAN_DE, :NGAY_VAO, :GIO_VAO, :DA_VO_OI, :NGAY_VO_OI,
                                            :GIO_VO_OI, :GHI_CHU, :NGAY_TAO, :NGUOI_TAO, :NGAY_SUA, 
											:NGUOI_SUA, :SOPHIEU, :MAQUANLY, 0)";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

                Command.Parameters.Add(new MDB.MDBParameter("MA_BN", phieuBieuDoChuyenDa.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("TEN_BN", phieuBieuDoChuyenDa.TenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("SO_VAO_VIEN", phieuBieuDoChuyenDa.SoVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("TUOI", phieuBieuDoChuyenDa.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("GIOI_TINH", phieuBieuDoChuyenDa.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("LAN_CO_THAI", phieuBieuDoChuyenDa.LanCoThai));
                Command.Parameters.Add(new MDB.MDBParameter("LAN_DE", phieuBieuDoChuyenDa.LanDe));
                Command.Parameters.Add(new MDB.MDBParameter("NGAY_VAO", phieuBieuDoChuyenDa.NgayVao));
                Command.Parameters.Add(new MDB.MDBParameter("GIO_VAO", phieuBieuDoChuyenDa.GioVao));
                Command.Parameters.Add(new MDB.MDBParameter("DA_VO_OI", phieuBieuDoChuyenDa.DaVoOi ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("NGAY_VO_OI", phieuBieuDoChuyenDa.NgayVoOi));
                Command.Parameters.Add(new MDB.MDBParameter("GIO_VO_OI", phieuBieuDoChuyenDa.GioVoOi));
                Command.Parameters.Add(new MDB.MDBParameter("GHI_CHU", phieuBieuDoChuyenDa.GhiChu));
                Command.Parameters.Add(new MDB.MDBParameter("NGAY_TAO", phieuBieuDoChuyenDa.NgayTao));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOI_TAO", phieuBieuDoChuyenDa.NguoiTao));
                Command.Parameters.Add(new MDB.MDBParameter("NGAY_SUA", phieuBieuDoChuyenDa.NgaySua));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOI_SUA", phieuBieuDoChuyenDa.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("SOPHIEU", phieuBieuDoChuyenDa.SoPhieu));
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", phieuBieuDoChuyenDa.MaQuanLy));
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery(); // C#
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public bool Update(MDB.MDBConnection MyConnection, PhieuBieuDoChuyenDa phieuBieuDoChuyenDa)
        {
            try
            {
                string sql = @"UPDATE BIEUDOCHUYENDA SET  
                            LAN_CO_THAI = :LAN_CO_THAI, 
                            LAN_DE = :LAN_DE, 
                            NGAY_VAO = :NGAY_VAO,
                            GIO_VAO = :GIO_VAO,
                            DA_VO_OI = :DA_VO_OI,
                            NGAY_VO_OI = :NGAY_VO_OI, 
                            GIO_VO_OI = :GIO_VO_OI, 
                            GHI_CHU = :GHI_CHU, 
                            NGAY_TAO = :NGAY_TAO, 
                            NGUOI_TAO = :NGUOI_TAO, 
                            NGAY_SUA = :NGAY_SUA, 
                            NGUOI_SUA = :NGUOI_SUA,
                            SOPHIEU = :SOPHIEU 
                        WHERE ID = " + phieuBieuDoChuyenDa.ID;
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("LAN_CO_THAI", phieuBieuDoChuyenDa.LanCoThai));
                Command.Parameters.Add(new MDB.MDBParameter("LAN_DE", phieuBieuDoChuyenDa.LanDe));
                Command.Parameters.Add(new MDB.MDBParameter("NGAY_VAO", phieuBieuDoChuyenDa.NgayVao));
                Command.Parameters.Add(new MDB.MDBParameter("GIO_VAO", phieuBieuDoChuyenDa.GioVao));
                Command.Parameters.Add(new MDB.MDBParameter("DA_VO_OI", phieuBieuDoChuyenDa.DaVoOi ? 1: 0));
                Command.Parameters.Add(new MDB.MDBParameter("NGAY_VO_OI", phieuBieuDoChuyenDa.NgayVoOi));
                Command.Parameters.Add(new MDB.MDBParameter("GIO_VO_OI", phieuBieuDoChuyenDa.GioVoOi));
                Command.Parameters.Add(new MDB.MDBParameter("GHI_CHU", phieuBieuDoChuyenDa.GhiChu));
                Command.Parameters.Add(new MDB.MDBParameter("NGAY_TAO", phieuBieuDoChuyenDa.NgayTao));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOI_TAO", phieuBieuDoChuyenDa.NguoiTao));
                Command.Parameters.Add(new MDB.MDBParameter("NGAY_SUA", phieuBieuDoChuyenDa.NgaySua));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOI_SUA", phieuBieuDoChuyenDa.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("SOPHIEU", phieuBieuDoChuyenDa.SoPhieu));
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery(); // C#
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public bool Delete(MDB.MDBConnection MyConnection, PhieuBieuDoChuyenDa bieuDo)
        {
            try
            {
                string sql = @"UPDATE BIEUDOCHUYENDA SET Is_Delete = 1 
                        WHERE (ID = :ID) AND Is_Delete = 0";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID", bieuDo.ID));
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();

                return n > 0 ? true : false;

            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
    }
}
