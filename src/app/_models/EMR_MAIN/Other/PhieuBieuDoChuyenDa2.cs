using DevExpress.XtraReports.UI;
using EMR.KyDienTu;
using EMR_MAIN.InBenhAn;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuBieuDoChuyenDa2 : ThongTinKy
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
        public int Para { get; set; }
        public ObservableCollection<BenhKhiCoThai> ListBenh { get; set; }
        public bool[] RatXanhArray { get; } = new bool[] { false, false };
        public string RatXanh
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < RatXanhArray.Length; i++)
                    temp += (RatXanhArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        RatXanhArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }

        public bool[] PhuToanThanArray { get; } = new bool[] { false, false };
        public string PhuToanThan
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < PhuToanThanArray.Length; i++)
                    temp += (PhuToanThanArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        PhuToanThanArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }

        public bool[] AlbuminArray { get; } = new bool[] { false, false };
        public string Albumin
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < AlbuminArray.Length; i++)
                    temp += (AlbuminArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        AlbuminArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }

        public bool[] HuyetApCaoArray { get; } = new bool[] { false, false };
        public string HuyetApCao
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < HuyetApCaoArray.Length; i++)
                    temp += (HuyetApCaoArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        HuyetApCaoArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }

        public bool[] SotCaoArray { get; } = new bool[] { false, false };
        public string SotCao
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < SotCaoArray.Length; i++)
                    temp += (SotCaoArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        SotCaoArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }

        public bool[] CanNangArray { get; } = new bool[] { false, false };
        public string CanNang
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < CanNangArray.Length; i++)
                    temp += (CanNangArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        CanNangArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }

        public bool[] ConSoArray { get; } = new bool[] { false, false };
        public string ConSo
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ConSoArray.Length; i++)
                    temp += (ConSoArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ConSoArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }

        public bool[] CaoTuCungArray { get; } = new bool[] { false, false };
        public string CaoTuCung
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < CaoTuCungArray.Length; i++)
                    temp += (CaoTuCungArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        CaoTuCungArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }

        public bool[] NgoiBatThuongArray { get; } = new bool[] { false, false };
        public string NgoiBatThuong
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < NgoiBatThuongArray.Length; i++)
                    temp += (NgoiBatThuongArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NgoiBatThuongArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }

        public bool[] DaThaiArray { get; } = new bool[] { false, false };
        public string DaThai
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < DaThaiArray.Length; i++)
                    temp += (DaThaiArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DaThaiArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }

        public bool[] TimThaiArray { get; } = new bool[] { false, false };
        public string TimThai
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TimThaiArray.Length; i++)
                    temp += (TimThaiArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TimThaiArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }

        public bool[] RaMauArray { get; } = new bool[] { false, false };
        public string RaMau
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < RaMauArray.Length; i++)
                    temp += (RaMauArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        RaMauArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }

        public bool[] ThaiGiaArray { get; } = new bool[] { false, false };
        public string ThaiGia
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ThaiGiaArray.Length; i++)
                    temp += (ThaiGiaArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ThaiGiaArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }

        public bool[] ThaiNonArray { get; } = new bool[] { false, false };
        public string ThaiNon
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ThaiNonArray.Length; i++)
                    temp += (ThaiNonArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ThaiNonArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }

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
    public class BieuDoChuyenDaChiTiet2
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
        public  BieuDoChuyenDaChiTiet2()
        {
            DoMoCoTuCung = null;
            TienTrienNgoiThai = null;
        }
        public BieuDoChuyenDaChiTiet2 Clone()
        {
            return (BieuDoChuyenDaChiTiet2)this.MemberwiseClone();
        }
    }

    public class BenhKhiCoThai
    {
        public DateTime? NgayThang { get; set; }
        public string BenhMacPhai { get; set; }
        public string DieuTriTaiXa { get; set; }
        public string DieuTriTaiBV { get; set; }
        [MoTaDuLieu("Ghi chú")]
		public string GhiChu { get; set; }
    }

    public class PhieuBieuDoChuyenDa2Func
    {
        public const string TableName = "BIEUDOCHUYENDA2";
        public const string TablePrimaryKeyName = "ID";
        public List<BieuDoChuyenDaChiTiet2> SelectBieuDoChuyenDaChiTiet2(MDB.MDBConnection MyConnection, int IdBieuDoChuyenDa, int soPhieu, bool ModeIn= false)
        {
            try
            {

                // Tunght ADD ICLOUD???
                List<BieuDoChuyenDaChiTiet2> listResult = new List<BieuDoChuyenDaChiTiet2>();
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
                        FROM BIEUDOCHUYENDA2_CHITIET  
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
                    BieuDoChuyenDaChiTiet2 bieuDo = new BieuDoChuyenDaChiTiet2();
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
                List<BieuDoChuyenDaChiTiet2> listResult = new List<BieuDoChuyenDaChiTiet2>();
                string sql = @"SELECT min(ngay) as Ngay, ID
                        FROM BIEUDOCHUYENDA2_CHITIET  
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
        public List<BieuDoChuyenDaChiTiet2> GetListBieuDo_TienTrienDe(MDB.MDBConnection MyConnection, int IdBieuDoChuyenDa, int soPhieu, bool ModeIn = false)
        {
            try
            {
                List<BieuDoChuyenDaChiTiet2> listResult = new List<BieuDoChuyenDaChiTiet2>();
                string sql = @"select AA.gio, AA.do_mo_ctc, BB.TT_NGOI_THAI from  (select gio, max(NVL(do_mo_ctc,-1)) as do_mo_ctc   FROM BIEUDOCHUYENDA_CHITIET  WHERE BIEUDOCHUYENDA_ID = :BIEUDOCHUYENDA_ID AND SOPHIEU = :SOPHIEU AND IS_DELETE = 0 group by gio)AA
                        INNER join (select gio,max(NVL(TT_NGOI_THAI,-1)) as  TT_NGOI_THAI  FROM BIEUDOCHUYENDA2_CHITIET WHERE BIEUDOCHUYENDA_ID = :BIEUDOCHUYENDA_ID AND SOPHIEU = :SOPHIEU AND IS_DELETE = 0 group by gio)BB on  
                        AA.gio = BB.gio order by AA.gio ASC";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("BIEUDOCHUYENDA_ID", IdBieuDoChuyenDa));
                Command.Parameters.Add(new MDB.MDBParameter("SOPHIEU", soPhieu));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    BieuDoChuyenDaChiTiet2 bieuDo = new BieuDoChuyenDaChiTiet2();
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
        public bool InsertBieuDoChuyenDaChiTiet2(MDB.MDBConnection MyConnection, BieuDoChuyenDaChiTiet2 bieuDo)
        {
            try
            {
                string sql = @"INSERT INTO BIEUDOCHUYENDA2_CHITIET (BIEUDOCHUYENDA_ID, SOPHIEU, NGAY, GIO, PHUT, MACH, 
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

        public bool deleteBieuDoChiTiet(MDB.MDBConnection MyConnection, BieuDoChuyenDaChiTiet2 BieuDoChuyenDaChiTiet2)
        {
            try
            {
                string sql = @"UPDATE BIEUDOCHUYENDA2_CHITIET SET IS_DELETE = 1 
                                    WHERE (ID = :ID) AND IS_DELETE = 0";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID", BieuDoChuyenDaChiTiet2.ID));
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

        public bool UpdateBieuDoChuyenDaChiTiet2(MDB.MDBConnection MyConnection, BieuDoChuyenDaChiTiet2 bieuDo)
        {
            try
            {
                string sql = @"UPDATE BIEUDOCHUYENDA2_CHITIET SET  
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
        public List<PhieuBieuDoChuyenDa2> Select(MDB.MDBConnection MyConnection, string MaQuanLy)
        {
            try
            {
                List<PhieuBieuDoChuyenDa2> listResult = new List<PhieuBieuDoChuyenDa2>();
                string sql = @"SELECT *
                    FROM BIEUDOCHUYENDA2 
                    WHERE MaQuanLy = :MaQuanLy AND IS_DELETE = 0";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuBieuDoChuyenDa2 currentPhieu = new PhieuBieuDoChuyenDa2();
                    currentPhieu.ID = int.Parse(DataReader["ID"].ToString());
                    currentPhieu.MaBenhNhan = DataReader["MA_BN"] != null ? DataReader["MA_BN"].ToString() : null;
                    currentPhieu.TenBenhNhan = DataReader["TEN_BN"] != null ? DataReader["TEN_BN"].ToString() : null;
                    currentPhieu.SoVaoVien = DataReader["SO_VAO_VIEN"] != null ? DataReader["SO_VAO_VIEN"].ToString() : null;
                    currentPhieu.Tuoi = DataReader["TUOI"] != null ? DataReader["TUOI"].ToString() : null;
                    currentPhieu.GioiTinh = DataReader["GIOI_TINH"] != null ? DataReader["GIOI_TINH"].ToString() : null;
                    currentPhieu.LanCoThai = DataReader["LAN_CO_THAI"] != null ? int.Parse(DataReader["LAN_CO_THAI"].ToString()) : 0;
                    currentPhieu.LanDe = DataReader["LAN_DE"] != null ? int.Parse(DataReader["LAN_DE"].ToString()) : 0;
                    currentPhieu.Para = DataReader["Para"] != null ? int.Parse(DataReader["Para"].ToString()) : 0;
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

                    currentPhieu.ListBenh = JsonConvert.DeserializeObject<ObservableCollection<BenhKhiCoThai>>(DataReader["ListBenh"].ToString());
                    currentPhieu.Para = DataReader["Para"] != null ? Int32.Parse(DataReader["Para"].ToString()) : 0;
                    currentPhieu.RatXanh = DataReader["RatXanh"].ToString();
                    currentPhieu.PhuToanThan = DataReader["PhuToanThan"].ToString();
                    currentPhieu.Albumin = DataReader["Albumin"].ToString();
                    currentPhieu.HuyetApCao = DataReader["HuyetApCao"].ToString();
                    currentPhieu.SotCao = DataReader["SotCao"].ToString();
                    currentPhieu.CanNang = DataReader["CanNang"].ToString();
                    currentPhieu.ConSo = DataReader["ConSo"].ToString();
                    currentPhieu.CaoTuCung = DataReader["CaoTuCung"].ToString();
                    currentPhieu.NgoiBatThuong = DataReader["NgoiBatThuong"].ToString();
                    currentPhieu.DaThai = DataReader["DaThai"].ToString();
                    currentPhieu.TimThai = DataReader["TimThai"].ToString();
                    currentPhieu.RaMau = DataReader["RaMau"].ToString();
                    currentPhieu.ThaiGia = DataReader["ThaiGia"].ToString();
                    currentPhieu.ThaiNon = DataReader["ThaiNon"].ToString();

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
        public PhieuBieuDoChuyenDa2 getPhieuBieuDoChuyenDa2(MDB.MDBConnection MyConnection, string MaBenhNhan, int BieuDoChuyenDaID) {

            string sql  = @"
                SELECT
	                TEN_BN,
	                TUOI,
	                GIOI_TINH,
	                LAN_CO_THAI,
	                LAN_DE,
	                Para,
	                ListBenh,
	                RatXanh,
	                PhuToanThan,
	                Albumin,
	                HuyetApCao,
	                SotCao,
	                CanNang,
	                ConSo,
	                CaoTuCung,
	                NgoiBatThuong,
	                DaThai,
	                TimThai,
	                RaMau,
	                ThaiGia,
	                ThaiNon,
	                NGAY_VAO,
	                GIO_VAO,
	                NGAY_VO_OI,
	                GIO_VO_OI,
                    SOPHIEU,
                    DA_VO_OI,
                    NGUOI_SUA
                FROM
	                BIEUDOCHUYENDA2 
                WHERE
	                ID = :BieuDoChuyenDaID";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("BieuDoChuyenDaID", BieuDoChuyenDaID));
            Command.BindByName = true;
            MDB.MDBDataReader DataReader_BDND = Command.ExecuteReader();
            PhieuBieuDoChuyenDa2 bieudochuyenda = new PhieuBieuDoChuyenDa2();
            while (DataReader_BDND.Read())
            {
                bieudochuyenda.TenBenhNhan = DataReader_BDND["TEN_BN"] != null ? DataReader_BDND["TEN_BN"].ToString() : null;
                bieudochuyenda.Tuoi = DataReader_BDND["TUOI"] != null ? DataReader_BDND["TUOI"].ToString() : null;
                bieudochuyenda.GioiTinh = DataReader_BDND["GIOI_TINH"] != null ? DataReader_BDND["GIOI_TINH"].ToString() : null;
                bieudochuyenda.LanCoThai = DataReader_BDND["LAN_CO_THAI"] != null ? Int32.Parse(DataReader_BDND["LAN_CO_THAI"].ToString()) : 0;
                bieudochuyenda.LanDe = DataReader_BDND["LAN_DE"] != null ? Int32.Parse(DataReader_BDND["LAN_DE"].ToString()) : 0;
                bieudochuyenda.Para = DataReader_BDND["Para"] != null ? Int32.Parse(DataReader_BDND["Para"].ToString()) : 0;
                bieudochuyenda.RatXanh = DataReader_BDND["RatXanh"].ToString();
                bieudochuyenda.PhuToanThan = DataReader_BDND["PhuToanThan"].ToString();
                bieudochuyenda.Albumin = DataReader_BDND["Albumin"].ToString();
                bieudochuyenda.HuyetApCao = DataReader_BDND["HuyetApCao"].ToString();
                bieudochuyenda.SotCao = DataReader_BDND["SotCao"].ToString();
                bieudochuyenda.CanNang = DataReader_BDND["CanNang"].ToString();
                bieudochuyenda.ConSo = DataReader_BDND["ConSo"].ToString();
                bieudochuyenda.CaoTuCung = DataReader_BDND["CaoTuCung"].ToString();
                bieudochuyenda.NgoiBatThuong = DataReader_BDND["NgoiBatThuong"].ToString();
                bieudochuyenda.DaThai = DataReader_BDND["DaThai"].ToString();
                bieudochuyenda.TimThai = DataReader_BDND["TimThai"].ToString();
                bieudochuyenda.RaMau = DataReader_BDND["RaMau"].ToString();
                bieudochuyenda.ThaiGia = DataReader_BDND["ThaiGia"].ToString();
                bieudochuyenda.ThaiNon = DataReader_BDND["ThaiNon"].ToString();
                bieudochuyenda.GioVao = DataReader_BDND["GIO_VAO"] != null ? Int32.Parse(DataReader_BDND["GIO_VAO"].ToString()) : 0;
                bieudochuyenda.GioVoOi = DataReader_BDND["GIO_VO_OI"] != null ? Int32.Parse(DataReader_BDND["GIO_VO_OI"].ToString()) : 0;
                bieudochuyenda.NgayVao = DataReader_BDND["NGAY_VAO"] != null ? DateTime.Parse(DataReader_BDND["NGAY_VAO"].ToString()) : DateTime.Now;
                bieudochuyenda.NgayVoOi = DataReader_BDND["NGAY_VO_OI"] != null ? DateTime.Parse(DataReader_BDND["NGAY_VO_OI"].ToString()) : DateTime.Now;
                bieudochuyenda.SoPhieu = DataReader_BDND["SOPHIEU"] != null ? Int32.Parse(DataReader_BDND["SOPHIEU"].ToString()) : 0;
                bieudochuyenda.DaVoOi = DataReader_BDND["DA_VO_OI"].ToString().Trim().Equals("1") ? true : false;

                bieudochuyenda.ListBenh = JsonConvert.DeserializeObject<ObservableCollection<BenhKhiCoThai>>(DataReader_BDND["ListBenh"].ToString());

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
	                BIEUDOCHUYENDA2 
                WHERE
	                ID = :BieuDoChuyenDaID";
            Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("BieuDoChuyenDaID", BieuDoChuyenDaID));
            Command.BindByName = true;
            MDB.MDBDataReader DataReader_BDND = Command.ExecuteReader();
            PhieuBieuDoChuyenDa2 bieudochuyenda = new PhieuBieuDoChuyenDa2();
            while (DataReader_BDND.Read())
            {
                bieudochuyenda.TenBenhNhan = DataReader_BDND["TEN_BN"] != null ? DataReader_BDND["TEN_BN"].ToString() : null;
                bieudochuyenda.Tuoi = DataReader_BDND["TUOI"] != null ? DataReader_BDND["TUOI"].ToString() : null;
                bieudochuyenda.GioiTinh = DataReader_BDND["GIOI_TINH"] != null ? DataReader_BDND["GIOI_TINH"].ToString() : null;
                bieudochuyenda.LanCoThai = DataReader_BDND["LAN_CO_THAI"] != null ? Int32.Parse(DataReader_BDND["LAN_CO_THAI"].ToString()) : 0;
                bieudochuyenda.LanDe = DataReader_BDND["LAN_DE"] != null ? Int32.Parse(DataReader_BDND["LAN_DE"].ToString()) : 0;
                bieudochuyenda.Para = DataReader_BDND["Para"] != null ? Int32.Parse(DataReader_BDND["Para"].ToString()) : 0;
                bieudochuyenda.GioVao = DataReader_BDND["GIO_VAO"] != null ? Int32.Parse(DataReader_BDND["GIO_VAO"].ToString()) : 0;
                bieudochuyenda.GioVoOi = DataReader_BDND["GIO_VO_OI"] != null ? Int32.Parse(DataReader_BDND["GIO_VO_OI"].ToString()) : 0;
                bieudochuyenda.NgayVao = DataReader_BDND["NGAY_VAO"] != null ? DateTime.Parse(DataReader_BDND["NGAY_VAO"].ToString()) : DateTime.Now;
                bieudochuyenda.NgayVoOi = DataReader_BDND["NGAY_VO_OI"] != null ? DateTime.Parse(DataReader_BDND["NGAY_VO_OI"].ToString()) : DateTime.Now;
                bieudochuyenda.SoPhieu = DataReader_BDND["SOPHIEU"] != null ? Int32.Parse(DataReader_BDND["SOPHIEU"].ToString()) : 0;
                bieudochuyenda.DaVoOi = DataReader_BDND["DA_VO_OI"].ToString().Trim().Equals("1") ? true : false;
            }

            return new string[2] { Newtonsoft.Json.JsonConvert.SerializeObject(hanhchinhbenhnhan), Newtonsoft.Json.JsonConvert.SerializeObject(bieudochuyenda) };
        }
        public bool Insert(MDB.MDBConnection MyConnection, PhieuBieuDoChuyenDa2 PhieuBieuDoChuyenDa2)
        {
            try
            {
                string sql = @"INSERT INTO BIEUDOCHUYENDA2 (MA_BN, TEN_BN, SO_VAO_VIEN, TUOI, GIOI_TINH, 
                                            LAN_CO_THAI, LAN_DE,Para,ListBenh, NGAY_VAO, GIO_VAO, DA_VO_OI, NGAY_VO_OI,
                                            GIO_VO_OI, GHI_CHU, NGAY_TAO, NGUOI_TAO, NGAY_SUA, 
                                            NGUOI_SUA, SOPHIEU, MAQUANLY, IS_DELETE,
	                                        RatXanh,
	                                        PhuToanThan,
	                                        Albumin,
	                                        HuyetApCao,
	                                        SotCao,
	                                        CanNang,
	                                        ConSo,
	                                        CaoTuCung,
	                                        NgoiBatThuong,
	                                        DaThai,
	                                        TimThai,
	                                        RaMau,
	                                        ThaiGia,
	                                        ThaiNon) 
                                        VALUES (:MA_BN, :TEN_BN, :SO_VAO_VIEN, :TUOI, :GIOI_TINH,
                                            :LAN_CO_THAI, :LAN_DE,:Para,:ListBenh, :NGAY_VAO, :GIO_VAO, :DA_VO_OI, :NGAY_VO_OI,
                                            :GIO_VO_OI, :GHI_CHU, :NGAY_TAO, :NGUOI_TAO, :NGAY_SUA, 
											:NGUOI_SUA, :SOPHIEU, :MAQUANLY, 0,
	                                        :RatXanh,
	                                        :PhuToanThan,
	                                        :Albumin,
	                                        :HuyetApCao,
	                                        :SotCao,
	                                        :CanNang,
	                                        :ConSo,
	                                        :CaoTuCung,
	                                        :NgoiBatThuong,
	                                        :DaThai,
	                                        :TimThai,
	                                        :RaMau,
	                                        :ThaiGia,
	                                        :ThaiNon)";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

                Command.Parameters.Add(new MDB.MDBParameter("MA_BN", PhieuBieuDoChuyenDa2.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("TEN_BN", PhieuBieuDoChuyenDa2.TenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("SO_VAO_VIEN", PhieuBieuDoChuyenDa2.SoVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("TUOI", PhieuBieuDoChuyenDa2.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("GIOI_TINH", PhieuBieuDoChuyenDa2.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("LAN_CO_THAI", PhieuBieuDoChuyenDa2.LanCoThai));
                Command.Parameters.Add(new MDB.MDBParameter("LAN_DE", PhieuBieuDoChuyenDa2.LanDe));
                Command.Parameters.Add(new MDB.MDBParameter("Para", PhieuBieuDoChuyenDa2.Para));
                Command.Parameters.Add(new MDB.MDBParameter("ListBenh", JsonConvert.SerializeObject(PhieuBieuDoChuyenDa2.ListBenh)));
                Command.Parameters.Add(new MDB.MDBParameter("NGAY_VAO", PhieuBieuDoChuyenDa2.NgayVao));
                Command.Parameters.Add(new MDB.MDBParameter("GIO_VAO", PhieuBieuDoChuyenDa2.GioVao));
                Command.Parameters.Add(new MDB.MDBParameter("DA_VO_OI", PhieuBieuDoChuyenDa2.DaVoOi ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("NGAY_VO_OI", PhieuBieuDoChuyenDa2.NgayVoOi));
                Command.Parameters.Add(new MDB.MDBParameter("GIO_VO_OI", PhieuBieuDoChuyenDa2.GioVoOi));
                Command.Parameters.Add(new MDB.MDBParameter("GHI_CHU", PhieuBieuDoChuyenDa2.GhiChu));
                Command.Parameters.Add(new MDB.MDBParameter("NGAY_TAO", PhieuBieuDoChuyenDa2.NgayTao));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOI_TAO", PhieuBieuDoChuyenDa2.NguoiTao));
                Command.Parameters.Add(new MDB.MDBParameter("NGAY_SUA", PhieuBieuDoChuyenDa2.NgaySua));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOI_SUA", PhieuBieuDoChuyenDa2.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("SOPHIEU", PhieuBieuDoChuyenDa2.SoPhieu));
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", PhieuBieuDoChuyenDa2.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("RatXanh", PhieuBieuDoChuyenDa2.RatXanh));
                Command.Parameters.Add(new MDB.MDBParameter("PhuToanThan", PhieuBieuDoChuyenDa2.PhuToanThan));
                Command.Parameters.Add(new MDB.MDBParameter("Albumin", PhieuBieuDoChuyenDa2.Albumin));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetApCao", PhieuBieuDoChuyenDa2.HuyetApCao));
                Command.Parameters.Add(new MDB.MDBParameter("SotCao", PhieuBieuDoChuyenDa2.SotCao));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang", PhieuBieuDoChuyenDa2.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("ConSo", PhieuBieuDoChuyenDa2.ConSo));
                Command.Parameters.Add(new MDB.MDBParameter("CaoTuCung", PhieuBieuDoChuyenDa2.CaoTuCung));
                Command.Parameters.Add(new MDB.MDBParameter("NgoiBatThuong", PhieuBieuDoChuyenDa2.NgoiBatThuong));
                Command.Parameters.Add(new MDB.MDBParameter("DaThai", PhieuBieuDoChuyenDa2.DaThai));
                Command.Parameters.Add(new MDB.MDBParameter("TimThai", PhieuBieuDoChuyenDa2.TimThai));
                Command.Parameters.Add(new MDB.MDBParameter("RaMau", PhieuBieuDoChuyenDa2.RaMau));
                Command.Parameters.Add(new MDB.MDBParameter("ThaiGia", PhieuBieuDoChuyenDa2.ThaiGia));
                Command.Parameters.Add(new MDB.MDBParameter("ThaiNon", PhieuBieuDoChuyenDa2.ThaiNon));
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
        public bool Update(MDB.MDBConnection MyConnection, PhieuBieuDoChuyenDa2 PhieuBieuDoChuyenDa2)
        {
            try
            {
                string sql = @"UPDATE BIEUDOCHUYENDA2 SET  
                            LAN_CO_THAI = :LAN_CO_THAI, 
                            LAN_DE = :LAN_DE, 
                            Para = :Para, 
                            ListBenh = :ListBenh,
	                        RatXanh = :RatXanh,
	                        PhuToanThan = :PhuToanThan,
	                        Albumin = :Albumin,
	                        HuyetApCao = :HuyetApCao,
	                        SotCao = :SotCao,
	                        CanNang = :CanNang,
	                        ConSo = :ConSo,
	                        CaoTuCung = :CaoTuCung,
	                        NgoiBatThuong = :NgoiBatThuong,
	                        DaThai = :DaThai,
	                        TimThai = :TimThai,
	                        RaMau = :RaMau,
	                        ThaiGia = :ThaiGia,
	                        ThaiNon = :ThaiNon,
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
                        WHERE ID = " + PhieuBieuDoChuyenDa2.ID;
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("LAN_CO_THAI", PhieuBieuDoChuyenDa2.LanCoThai));
                Command.Parameters.Add(new MDB.MDBParameter("LAN_DE", PhieuBieuDoChuyenDa2.LanDe));
                Command.Parameters.Add(new MDB.MDBParameter("Para", PhieuBieuDoChuyenDa2.Para));
                Command.Parameters.Add(new MDB.MDBParameter("ListBenh", JsonConvert.SerializeObject(PhieuBieuDoChuyenDa2.ListBenh)));
                Command.Parameters.Add(new MDB.MDBParameter("NGAY_VAO", PhieuBieuDoChuyenDa2.NgayVao));
                Command.Parameters.Add(new MDB.MDBParameter("GIO_VAO", PhieuBieuDoChuyenDa2.GioVao));
                Command.Parameters.Add(new MDB.MDBParameter("DA_VO_OI", PhieuBieuDoChuyenDa2.DaVoOi ? 1: 0));
                Command.Parameters.Add(new MDB.MDBParameter("NGAY_VO_OI", PhieuBieuDoChuyenDa2.NgayVoOi));
                Command.Parameters.Add(new MDB.MDBParameter("GIO_VO_OI", PhieuBieuDoChuyenDa2.GioVoOi));
                Command.Parameters.Add(new MDB.MDBParameter("GHI_CHU", PhieuBieuDoChuyenDa2.GhiChu));
                Command.Parameters.Add(new MDB.MDBParameter("NGAY_TAO", PhieuBieuDoChuyenDa2.NgayTao));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOI_TAO", PhieuBieuDoChuyenDa2.NguoiTao));
                Command.Parameters.Add(new MDB.MDBParameter("NGAY_SUA", PhieuBieuDoChuyenDa2.NgaySua));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOI_SUA", PhieuBieuDoChuyenDa2.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("SOPHIEU", PhieuBieuDoChuyenDa2.SoPhieu));
                Command.Parameters.Add(new MDB.MDBParameter("RatXanh", PhieuBieuDoChuyenDa2.RatXanh));
                Command.Parameters.Add(new MDB.MDBParameter("PhuToanThan", PhieuBieuDoChuyenDa2.PhuToanThan));
                Command.Parameters.Add(new MDB.MDBParameter("Albumin", PhieuBieuDoChuyenDa2.Albumin));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetApCao", PhieuBieuDoChuyenDa2.HuyetApCao));
                Command.Parameters.Add(new MDB.MDBParameter("SotCao", PhieuBieuDoChuyenDa2.SotCao));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang", PhieuBieuDoChuyenDa2.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("ConSo", PhieuBieuDoChuyenDa2.ConSo));
                Command.Parameters.Add(new MDB.MDBParameter("CaoTuCung", PhieuBieuDoChuyenDa2.CaoTuCung));
                Command.Parameters.Add(new MDB.MDBParameter("NgoiBatThuong", PhieuBieuDoChuyenDa2.NgoiBatThuong));
                Command.Parameters.Add(new MDB.MDBParameter("DaThai", PhieuBieuDoChuyenDa2.DaThai));
                Command.Parameters.Add(new MDB.MDBParameter("TimThai", PhieuBieuDoChuyenDa2.TimThai));
                Command.Parameters.Add(new MDB.MDBParameter("RaMau", PhieuBieuDoChuyenDa2.RaMau));
                Command.Parameters.Add(new MDB.MDBParameter("ThaiGia", PhieuBieuDoChuyenDa2.ThaiGia));
                Command.Parameters.Add(new MDB.MDBParameter("ThaiNon", PhieuBieuDoChuyenDa2.ThaiNon));
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
        public bool Delete(MDB.MDBConnection MyConnection, PhieuBieuDoChuyenDa2 bieuDo)
        {
            try
            {
                string sql = @"UPDATE BIEUDOCHUYENDA2 SET Is_Delete = 1 
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
