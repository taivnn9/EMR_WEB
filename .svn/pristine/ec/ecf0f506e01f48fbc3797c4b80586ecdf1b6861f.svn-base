
using EMR.KyDienTu;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class DieuTriPhucHoiChucNang : ThongTinKy
    {
        public DieuTriPhucHoiChucNang()
        {
            IDMauPhieu = (int)DanhMucPhieu.PDTPHCN;
            TenMauPhieu = DanhMucPhieu.PDTPHCN.Description();
        }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        public string NoiGui { get; set; }
        public DateTime ThoiGian { get; set; }
        public string ViTri { get; set; }
        public string PhuongPhapDieuTri { get; set; }
        public string PhuongPhapDieuTriChiTiet { get; set; }
        [MoTaDuLieu("Mã bác sỹ điều trị")]
		public string MaBacSyDieuTri { get; set; }
        public string TenBacSyDieuTri { get; set; }
        [MoTaDuLieu("Mã người thực hiện")]
		public string MaNguoiThucHien { get; set; }
        public string TenNguoiThucHien { get; set; }
        public string HinhAnhTruoc { get; set; }
        public string HinhAnhSau { get; set; }
        public string HinhAnhTrai { get; set; }
        public string HinhAnhPhai { get; set; }
        //[MoTaDuLieu("Tên file ký")]
		public string TenFileKy { get; set; }
        //[MoTaDuLieu("Tên người ký")]
		public string UserNameKy { get; set; }
        //[MoTaDuLieu("Ngày ký")]
		public DateTime NgayKy { get; set; }
        //[MoTaDuLieu("Tên máy tính ký")]
		public string ComputerKyTen { get; set; } = System.Environment.MachineName;
        //public string MaSoKy { get; set; }
        public List<PPDTCT> listPPDTCT
        {
            get
            {
                try
                {
                    return JsonConvert.DeserializeObject<List<PPDTCT>>(PhuongPhapDieuTriChiTiet);
                }
                catch { return new List<PPDTCT>(); }
            }
        }
        public List<PPDTCT_REPORT> listPPDTCT_In
        {
            get
            {
                try
                {
                    return JsonConvert.DeserializeObject<List<PPDTCT_REPORT>>(PhuongPhapDieuTriChiTiet);
                }
                catch { return new List<PPDTCT_REPORT>(); }
            }
        }
    }

    public class PPDTCT
    {
        public string PPDT { get; set; }
        public string Ngay { get; set; }
    }

    public class PPDTCT_REPORT
    {
        public string PPDT { get; set; }
        public string Ngay { get; set; }
        public bool is1 { get { return !string.IsNullOrEmpty(Ngay) && Ngay.Split(',').Any(x => x.Trim().Equals("1")); } }
        public bool is2 { get { return !string.IsNullOrEmpty(Ngay) && Ngay.Split(',').Any(x => x.Trim().Equals("2")); } }
        public bool is3 { get { return !string.IsNullOrEmpty(Ngay) && Ngay.Split(',').Any(x => x.Trim().Equals("3")); } }
        public bool is4 { get { return !string.IsNullOrEmpty(Ngay) && Ngay.Split(',').Any(x => x.Trim().Equals("4")); } }
        public bool is5 { get { return !string.IsNullOrEmpty(Ngay) && Ngay.Split(',').Any(x => x.Trim().Equals("5")); } }
        public bool is6 { get { return !string.IsNullOrEmpty(Ngay) && Ngay.Split(',').Any(x => x.Trim().Equals("6")); } }
        public bool is7 { get { return !string.IsNullOrEmpty(Ngay) && Ngay.Split(',').Any(x => x.Trim().Equals("7")); } }
        public bool is8 { get { return !string.IsNullOrEmpty(Ngay) && Ngay.Split(',').Any(x => x.Trim().Equals("8")); } }
        public bool is9 { get { return !string.IsNullOrEmpty(Ngay) && Ngay.Split(',').Any(x => x.Trim().Equals("9")); } }
        public bool is10 { get { return !string.IsNullOrEmpty(Ngay) && Ngay.Split(',').Any(x => x.Trim().Equals("10")); } }
        public bool is11 { get { return !string.IsNullOrEmpty(Ngay) && Ngay.Split(',').Any(x => x.Trim().Equals("11")); } }
        public bool is12 { get { return !string.IsNullOrEmpty(Ngay) && Ngay.Split(',').Any(x => x.Trim().Equals("12")); } }
        public bool is13 { get { return !string.IsNullOrEmpty(Ngay) && Ngay.Split(',').Any(x => x.Trim().Equals("13")); } }
        public bool is14 { get { return !string.IsNullOrEmpty(Ngay) && Ngay.Split(',').Any(x => x.Trim().Equals("14")); } }
        public bool is15 { get { return !string.IsNullOrEmpty(Ngay) && Ngay.Split(',').Any(x => x.Trim().Equals("15")); } }
        public bool is16 { get { return !string.IsNullOrEmpty(Ngay) && Ngay.Split(',').Any(x => x.Trim().Equals("16")); } }
        public bool is17 { get { return !string.IsNullOrEmpty(Ngay) && Ngay.Split(',').Any(x => x.Trim().Equals("17")); } }
        public bool is18 { get { return !string.IsNullOrEmpty(Ngay) && Ngay.Split(',').Any(x => x.Trim().Equals("18")); } }
        public bool is19 { get { return !string.IsNullOrEmpty(Ngay) && Ngay.Split(',').Any(x => x.Trim().Equals("19")); } }
        public bool is20 { get { return !string.IsNullOrEmpty(Ngay) && Ngay.Split(',').Any(x => x.Trim().Equals("20")); } }
        public bool is21 { get { return !string.IsNullOrEmpty(Ngay) && Ngay.Split(',').Any(x => x.Trim().Equals("21")); } }
        public bool is22 { get { return !string.IsNullOrEmpty(Ngay) && Ngay.Split(',').Any(x => x.Trim().Equals("22")); } }
        public bool is23 { get { return !string.IsNullOrEmpty(Ngay) && Ngay.Split(',').Any(x => x.Trim().Equals("23")); } }
        public bool is24 { get { return !string.IsNullOrEmpty(Ngay) && Ngay.Split(',').Any(x => x.Trim().Equals("24")); } }
        public bool is25 { get { return !string.IsNullOrEmpty(Ngay) && Ngay.Split(',').Any(x => x.Trim().Equals("25")); } }
        public bool is26 { get { return !string.IsNullOrEmpty(Ngay) && Ngay.Split(',').Any(x => x.Trim().Equals("26")); } }
        public bool is27 { get { return !string.IsNullOrEmpty(Ngay) && Ngay.Split(',').Any(x => x.Trim().Equals("27")); } }
        public bool is28 { get { return !string.IsNullOrEmpty(Ngay) && Ngay.Split(',').Any(x => x.Trim().Equals("28")); } }
        public bool is29 { get { return !string.IsNullOrEmpty(Ngay) && Ngay.Split(',').Any(x => x.Trim().Equals("29")); } }
        public bool is30 { get { return !string.IsNullOrEmpty(Ngay) && Ngay.Split(',').Any(x => x.Trim().Equals("30")); } }
        public bool is31 { get { return !string.IsNullOrEmpty(Ngay) && Ngay.Split(',').Any(x => x.Trim().Equals("31")); } }
    }
}