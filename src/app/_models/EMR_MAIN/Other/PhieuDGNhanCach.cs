
using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuDGNhanCach : ThongTinKy
    {
        public PhieuDGNhanCach()
        {
            TableName = "PhieuDGNhanCach";
            TablePrimaryKeyName = "IDPhieu";
            IDMauPhieu = (int)DanhMucPhieu.PDGNC;
            TenMauPhieu = DanhMucPhieu.PDGNC.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public decimal IDPhieu { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
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
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.Tuoi;
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
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public DateTime ThoiGian { get; set; }
        public string KetLuan { get; set; }
        public int DG1 { set; get; }
        public int DG2 { set; get; }
        public int DG3 { set; get; }
        public int DG4 { set; get; }
        public int DG5 { set; get; }
        public int DG6 { set; get; }
        public int DG7 { set; get; }
        public int DG8 { set; get; }
        public int DG9 { set; get; }
        public int DG10 { set; get; }
        public int DG11 { set; get; }
        public int DG12 { set; get; }
        public int DG13 { set; get; }
        public int DG14 { set; get; }
        public int DG15 { set; get; }
        public int DG16 { set; get; }
        public int DG17 { set; get; }
        public int DG18 { set; get; }
        public int DG19 { set; get; }
        public int DG20 { set; get; }
        public int DG21 { set; get; }
        public int DG22 { set; get; }
        public int DG23 { set; get; }
        public int DG24 { set; get; }
        public int DG25 { set; get; }
        public int DG26 { set; get; }
        public int DG27 { set; get; }
        public int DG28 { set; get; }
        public int DG29 { set; get; }
        public int DG30 { set; get; }
        public int DG31 { set; get; }
        public int DG32 { set; get; }
        public int DG33 { set; get; }
        public int DG34 { set; get; }
        public int DG35 { set; get; }
        public int DG36 { set; get; }
        public int DG37 { set; get; }
        public int DG38 { set; get; }
        public int DG39 { set; get; }
        public int DG40 { set; get; }
        public int DG41 { set; get; }
        public int DG42 { set; get; }
        public int DG43 { set; get; }
        public int DG44 { set; get; }
        public int DG45 { set; get; }
        public int DG46 { set; get; }
        public int DG47 { set; get; }
        public int DG48 { set; get; }
        public int DG49 { set; get; }
        public int DG50 { set; get; }
        public int DG51 { set; get; }
        public int DG52 { set; get; }
        public int DG53 { set; get; }
        public int DG54 { set; get; }
        public int DG55 { set; get; }
        public int DG56 { set; get; }
        public int DG57 { set; get; }
        public int DG58 { set; get; }
        public int DG59 { set; get; }
        public int DG60 { set; get; }
        public int DG61 { set; get; }
        public int DG62 { set; get; }
        public int DG63 { set; get; }
        public int DG64 { set; get; }
        public int DG65 { set; get; }
        public int DG66 { set; get; }
        public int DG67 { set; get; }
        public int DG68 { set; get; }
        public int DG69 { set; get; }
        public int DG70 { set; get; }
        public int DG71 { set; get; }
        public string DG1_Txt1 { set; get; }
        public string DG2_Txt1 { set; get; }
        public string DG3_Txt1 { set; get; }
        public string DG4_Txt1 { set; get; }
        public string DG5_Txt1 { set; get; }
        public string DG6_Txt1 { set; get; }
        public string DG7_Txt1 { set; get; }
        public string DG8_Txt1 { set; get; }
        public string DG9_Txt1 { set; get; }
        public string DG10_Txt1 { set; get; }
        public string DG11_Txt1 { set; get; }
        public string DG12_Txt1 { set; get; }
        public string DG13_Txt1 { set; get; }
        public string DG14_Txt1 { set; get; }
        public string DG15_Txt1 { set; get; }
        public string DG16_Txt1 { set; get; }
        public string DG17_Txt1 { set; get; }
        public string DG18_Txt1 { set; get; }
        public string DG19_Txt1 { set; get; }
        public string DG20_Txt1 { set; get; }
        public string DG21_Txt1 { set; get; }
        public string DG22_Txt1 { set; get; }
        public string DG23_Txt1 { set; get; }
        public string DG24_Txt1 { set; get; }
        public string DG25_Txt1 { set; get; }
        public string DG26_Txt1 { set; get; }
        public string DG27_Txt1 { set; get; }
        public string DG28_Txt1 { set; get; }
        public string DG29_Txt1 { set; get; }
        public string DG30_Txt1 { set; get; }
        public string DG31_Txt1 { set; get; }
        public string DG32_Txt1 { set; get; }
        public string DG33_Txt1 { set; get; }
        public string DG34_Txt1 { set; get; }
        public string DG35_Txt1 { set; get; }
        public string DG36_Txt1 { set; get; }
        public string DG37_Txt1 { set; get; }
        public string DG38_Txt1 { set; get; }
        public string DG39_Txt1 { set; get; }
        public string DG40_Txt1 { set; get; }
        public string DG41_Txt1 { set; get; }
        public string DG42_Txt1 { set; get; }
        public string DG43_Txt1 { set; get; }
        public string DG44_Txt1 { set; get; }
        public string DG45_Txt1 { set; get; }
        public string DG46_Txt1 { set; get; }
        public string DG47_Txt1 { set; get; }
        public string DG48_Txt1 { set; get; }
        public string DG49_Txt1 { set; get; }
        public string DG50_Txt1 { set; get; }
        public string DG51_Txt1 { set; get; }
        public string DG52_Txt1 { set; get; }
        public string DG53_Txt1 { set; get; }
        public string DG54_Txt1 { set; get; }
        public string DG55_Txt1 { set; get; }
        public string DG56_Txt1 { set; get; }
        public string DG57_Txt1 { set; get; }
        public string DG58_Txt1 { set; get; }
        public string DG59_Txt1 { set; get; }
        public string DG60_Txt1 { set; get; }
        public string DG61_Txt1 { set; get; }
        public string DG62_Txt1 { set; get; }
        public string DG63_Txt1 { set; get; }
        public string DG64_Txt1 { set; get; }
        public string DG65_Txt1 { set; get; }
        public string DG66_Txt1 { set; get; }
        public string DG67_Txt1 { set; get; }
        public string DG68_Txt1 { set; get; }
        public string DG69_Txt1 { set; get; }
        public string DG70_Txt1 { set; get; }
        public string DG71_Txt1 { set; get; }
        public string DG1_Txt2 { set; get; }
        public string DG2_Txt2 { set; get; }
        public string DG3_Txt2 { set; get; }
        public string DG4_Txt2 { set; get; }
        public string DG5_Txt2 { set; get; }
        public string DG6_Txt2 { set; get; }
        public string DG7_Txt2 { set; get; }
        public string DG8_Txt2 { set; get; }
        public string DG9_Txt2 { set; get; }
        public string DG10_Txt2 { set; get; }
        public string DG11_Txt2 { set; get; }
        public string DG12_Txt2 { set; get; }
        public string DG13_Txt2 { set; get; }
        public string DG14_Txt2 { set; get; }
        public string DG15_Txt2 { set; get; }
        public string DG16_Txt2 { set; get; }
        public string DG17_Txt2 { set; get; }
        public string DG18_Txt2 { set; get; }
        public string DG19_Txt2 { set; get; }
        public string DG20_Txt2 { set; get; }
        public string DG21_Txt2 { set; get; }
        public string DG22_Txt2 { set; get; }
        public string DG23_Txt2 { set; get; }
        public string DG24_Txt2 { set; get; }
        public string DG25_Txt2 { set; get; }
        public string DG26_Txt2 { set; get; }
        public string DG27_Txt2 { set; get; }
        public string DG28_Txt2 { set; get; }
        public string DG29_Txt2 { set; get; }
        public string DG30_Txt2 { set; get; }
        public string DG31_Txt2 { set; get; }
        public string DG32_Txt2 { set; get; }
        public string DG33_Txt2 { set; get; }
        public string DG34_Txt2 { set; get; }
        public string DG35_Txt2 { set; get; }
        public string DG36_Txt2 { set; get; }
        public string DG37_Txt2 { set; get; }
        public string DG38_Txt2 { set; get; }
        public string DG39_Txt2 { set; get; }
        public string DG40_Txt2 { set; get; }
        public string DG41_Txt2 { set; get; }
        public string DG42_Txt2 { set; get; }
        public string DG43_Txt2 { set; get; }
        public string DG44_Txt2 { set; get; }
        public string DG45_Txt2 { set; get; }
        public string DG46_Txt2 { set; get; }
        public string DG47_Txt2 { set; get; }
        public string DG48_Txt2 { set; get; }
        public string DG49_Txt2 { set; get; }
        public string DG50_Txt2 { set; get; }
        public string DG51_Txt2 { set; get; }
        public string DG52_Txt2 { set; get; }
        public string DG53_Txt2 { set; get; }
        public string DG54_Txt2 { set; get; }
        public string DG55_Txt2 { set; get; }
        public string DG56_Txt2 { set; get; }
        public string DG57_Txt2 { set; get; }
        public string DG58_Txt2 { set; get; }
        public string DG59_Txt2 { set; get; }
        public string DG60_Txt2 { set; get; }
        public string DG61_Txt2 { set; get; }
        public string DG62_Txt2 { set; get; }
        public string DG63_Txt2 { set; get; }
        public string DG64_Txt2 { set; get; }
        public string DG65_Txt2 { set; get; }
        public string DG66_Txt2 { set; get; }
        public string DG67_Txt2 { set; get; }
        public string DG68_Txt2 { set; get; }
        public string DG69_Txt2 { set; get; }
        public string DG70_Txt2 { set; get; }
        public string DG71_Txt2 { set; get; }
        [MoTaDuLieu("Người thực hiện")]
		public string NguoiThucHien { get; set; }
        public string MaNVNguoiThucHien { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        public DateTime? NgaySua { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }

    }
    public class PhieuDGNhanCachFunc
    {
        public static bool InsertOrUpdate(PhieuDGNhanCach obj, MDB.MDBConnection conn)
        {
            try
            {
                string sql = "";
                if (obj.IDPhieu > 0)
                    sql = @"UPDATE PhieuDGNhanCach SET 
                        MaQuanLy =:MaQuanLy,
                        MaBenhNhan =:MaBenhNhan,
                        ChanDoan =:ChanDoan,
                        DiaChi =:DiaChi,
                        ThoiGian =:ThoiGian,
                        DG1=:DG1,
                        DG2=:DG2,
                        DG3=:DG3,
                        DG4=:DG4,
                        DG5=:DG5,
                        DG6=:DG6,
                        DG7=:DG7,
                        DG8=:DG8,
                        DG9=:DG9,
                        DG10=:DG10,
                        DG11=:DG11,
                        DG12=:DG12,
                        DG13=:DG13,
                        DG14=:DG14,
                        DG15=:DG15,
                        DG16=:DG16,
                        DG17=:DG17,
                        DG18=:DG18,
                        DG19=:DG19,
                        DG20=:DG20,
                        DG21=:DG21,
                        DG22=:DG22,
                        DG23=:DG23,
                        DG24=:DG24,
                        DG25=:DG25,
                        DG26=:DG26,
                        DG27=:DG27,
                        DG28=:DG28,
                        DG29=:DG29,
                        DG30=:DG30,
                        DG31=:DG31,
                        DG32=:DG32,
                        DG33=:DG33,
                        DG34=:DG34,
                        DG35=:DG35,
                        DG36=:DG36,
                        DG37=:DG37,
                        DG38=:DG38,
                        DG39=:DG39,
                        DG40=:DG40,
                        DG41=:DG41,
                        DG42=:DG42,
                        DG43=:DG43,
                        DG44=:DG44,
                        DG45=:DG45,
                        DG46=:DG46,
                        DG47=:DG47,
                        DG48=:DG48,
                        DG49=:DG49,
                        DG50=:DG50,
                        DG51=:DG51,
                        DG52=:DG52,
                        DG53=:DG53,
                        DG54=:DG54,
                        DG55=:DG55,
                        DG56=:DG56,
                        DG57=:DG57,
                        DG58=:DG58,
                        DG59=:DG59,
                        DG60=:DG60,
                        DG61=:DG61,
                        DG62=:DG62,
                        DG63=:DG63,
                        DG64=:DG64,
                        DG65=:DG65,
                        DG66=:DG66,
                        DG67=:DG67,
                        DG68=:DG68,
                        DG69=:DG69,
                        DG70=:DG70,
                        DG71=:DG71,
                        DG1_Txt1=:DG1_Txt1,
                        DG2_Txt1=:DG2_Txt1,
                        DG3_Txt1=:DG3_Txt1,
                        DG4_Txt1=:DG4_Txt1,
                        DG5_Txt1=:DG5_Txt1,
                        DG6_Txt1=:DG6_Txt1,
                        DG7_Txt1=:DG7_Txt1,
                        DG8_Txt1=:DG8_Txt1,
                        DG9_Txt1=:DG9_Txt1,
                        DG10_Txt1=:DG10_Txt1,
                        DG11_Txt1=:DG11_Txt1,
                        DG12_Txt1=:DG12_Txt1,
                        DG13_Txt1=:DG13_Txt1,
                        DG14_Txt1=:DG14_Txt1,
                        DG15_Txt1=:DG15_Txt1,
                        DG16_Txt1=:DG16_Txt1,
                        DG17_Txt1=:DG17_Txt1,
                        DG18_Txt1=:DG18_Txt1,
                        DG19_Txt1=:DG19_Txt1,
                        DG20_Txt1=:DG20_Txt1,
                        DG21_Txt1=:DG21_Txt1,
                        DG22_Txt1=:DG22_Txt1,
                        DG23_Txt1=:DG23_Txt1,
                        DG24_Txt1=:DG24_Txt1,
                        DG25_Txt1=:DG25_Txt1,
                        DG26_Txt1=:DG26_Txt1,
                        DG27_Txt1=:DG27_Txt1,
                        DG28_Txt1=:DG28_Txt1,
                        DG29_Txt1=:DG29_Txt1,
                        DG30_Txt1=:DG30_Txt1,
                        DG31_Txt1=:DG31_Txt1,
                        DG32_Txt1=:DG32_Txt1,
                        DG33_Txt1=:DG33_Txt1,
                        DG34_Txt1=:DG34_Txt1,
                        DG35_Txt1=:DG35_Txt1,
                        DG36_Txt1=:DG36_Txt1,
                        DG37_Txt1=:DG37_Txt1,
                        DG38_Txt1=:DG38_Txt1,
                        DG39_Txt1=:DG39_Txt1,
                        DG40_Txt1=:DG40_Txt1,
                        DG41_Txt1=:DG41_Txt1,
                        DG42_Txt1=:DG42_Txt1,
                        DG43_Txt1=:DG43_Txt1,
                        DG44_Txt1=:DG44_Txt1,
                        DG45_Txt1=:DG45_Txt1,
                        DG46_Txt1=:DG46_Txt1,
                        DG47_Txt1=:DG47_Txt1,
                        DG48_Txt1=:DG48_Txt1,
                        DG49_Txt1=:DG49_Txt1,
                        DG50_Txt1=:DG50_Txt1,
                        DG51_Txt1=:DG51_Txt1,
                        DG52_Txt1=:DG52_Txt1,
                        DG53_Txt1=:DG53_Txt1,
                        DG54_Txt1=:DG54_Txt1,
                        DG55_Txt1=:DG55_Txt1,
                        DG56_Txt1=:DG56_Txt1,
                        DG57_Txt1=:DG57_Txt1,
                        DG58_Txt1=:DG58_Txt1,
                        DG59_Txt1=:DG59_Txt1,
                        DG60_Txt1=:DG60_Txt1,
                        DG61_Txt1=:DG61_Txt1,
                        DG62_Txt1=:DG62_Txt1,
                        DG63_Txt1=:DG63_Txt1,
                        DG64_Txt1=:DG64_Txt1,
                        DG65_Txt1=:DG65_Txt1,
                        DG66_Txt1=:DG66_Txt1,
                        DG67_Txt1=:DG67_Txt1,
                        DG68_Txt1=:DG68_Txt1,
                        DG69_Txt1=:DG69_Txt1,
                        DG70_Txt1=:DG70_Txt1,
                        DG71_Txt1=:DG71_Txt1,
                        DG1_Txt2=:DG1_Txt2,
                        DG2_Txt2=:DG2_Txt2,
                        DG3_Txt2=:DG3_Txt2,
                        DG4_Txt2=:DG4_Txt2,
                        DG5_Txt2=:DG5_Txt2,
                        DG6_Txt2=:DG6_Txt2,
                        DG7_Txt2=:DG7_Txt2,
                        DG8_Txt2=:DG8_Txt2,
                        DG9_Txt2=:DG9_Txt2,
                        DG10_Txt2=:DG10_Txt2,
                        DG11_Txt2=:DG11_Txt2,
                        DG12_Txt2=:DG12_Txt2,
                        DG13_Txt2=:DG13_Txt2,
                        DG14_Txt2=:DG14_Txt2,
                        DG15_Txt2=:DG15_Txt2,
                        DG16_Txt2=:DG16_Txt2,
                        DG17_Txt2=:DG17_Txt2,
                        DG18_Txt2=:DG18_Txt2,
                        DG19_Txt2=:DG19_Txt2,
                        DG20_Txt2=:DG20_Txt2,
                        DG21_Txt2=:DG21_Txt2,
                        DG22_Txt2=:DG22_Txt2,
                        DG23_Txt2=:DG23_Txt2,
                        DG24_Txt2=:DG24_Txt2,
                        DG25_Txt2=:DG25_Txt2,
                        DG26_Txt2=:DG26_Txt2,
                        DG27_Txt2=:DG27_Txt2,
                        DG28_Txt2=:DG28_Txt2,
                        DG29_Txt2=:DG29_Txt2,
                        DG30_Txt2=:DG30_Txt2,
                        DG31_Txt2=:DG31_Txt2,
                        DG32_Txt2=:DG32_Txt2,
                        DG33_Txt2=:DG33_Txt2,
                        DG34_Txt2=:DG34_Txt2,
                        DG35_Txt2=:DG35_Txt2,
                        DG36_Txt2=:DG36_Txt2,
                        DG37_Txt2=:DG37_Txt2,
                        DG38_Txt2=:DG38_Txt2,
                        DG39_Txt2=:DG39_Txt2,
                        DG40_Txt2=:DG40_Txt2,
                        DG41_Txt2=:DG41_Txt2,
                        DG42_Txt2=:DG42_Txt2,
                        DG43_Txt2=:DG43_Txt2,
                        DG44_Txt2=:DG44_Txt2,
                        DG45_Txt2=:DG45_Txt2,
                        DG46_Txt2=:DG46_Txt2,
                        DG47_Txt2=:DG47_Txt2,
                        DG48_Txt2=:DG48_Txt2,
                        DG49_Txt2=:DG49_Txt2,
                        DG50_Txt2=:DG50_Txt2,
                        DG51_Txt2=:DG51_Txt2,
                        DG52_Txt2=:DG52_Txt2,
                        DG53_Txt2=:DG53_Txt2,
                        DG54_Txt2=:DG54_Txt2,
                        DG55_Txt2=:DG55_Txt2,
                        DG56_Txt2=:DG56_Txt2,
                        DG57_Txt2=:DG57_Txt2,
                        DG58_Txt2=:DG58_Txt2,
                        DG59_Txt2=:DG59_Txt2,
                        DG60_Txt2=:DG60_Txt2,
                        DG61_Txt2=:DG61_Txt2,
                        DG62_Txt2=:DG62_Txt2,
                        DG63_Txt2=:DG63_Txt2,
                        DG64_Txt2=:DG64_Txt2,
                        DG65_Txt2=:DG65_Txt2,
                        DG66_Txt2=:DG66_Txt2,
                        DG67_Txt2=:DG67_Txt2,
                        DG68_Txt2=:DG68_Txt2,
                        DG69_Txt2=:DG69_Txt2,
                        DG70_Txt2=:DG70_Txt2,
                        DG71_Txt2=:DG71_Txt2,
                        KetLuan=:KetLuan,
                        NguoiThucHien =:NguoiThucHien,
                        MaNVNguoiThucHien =:MaNVNguoiThucHien,
                        NgaySua =:NgaySua,
                        NguoiSua =:NguoiSua
                        WHERE IDPhieu = " + obj.IDPhieu;
                else
                    sql = @"INSERT INTO PhieuDGNhanCach (
                        MaQuanLy,
                        MaBenhNhan,
                        ChanDoan,
                        DiaChi,
                        ThoiGian,
                        DG1,
                        DG2,
                        DG3,
                        DG4,
                        DG5,
                        DG6,
                        DG7,
                        DG8,
                        DG9,
                        DG10,
                        DG11,
                        DG12,
                        DG13,
                        DG14,
                        DG15,
                        DG16,
                        DG17,
                        DG18,
                        DG19,
                        DG20,
                        DG21,
                        DG22,
                        DG23,
                        DG24,
                        DG25,
                        DG26,
                        DG27,
                        DG28,
                        DG29,
                        DG30,
                        DG31,
                        DG32,
                        DG33,
                        DG34,
                        DG35,
                        DG36,
                        DG37,
                        DG38,
                        DG39,
                        DG40,
                        DG41,
                        DG42,
                        DG43,
                        DG44,
                        DG45,
                        DG46,
                        DG47,
                        DG48,
                        DG49,
                        DG50,
                        DG51,
                        DG52,
                        DG53,
                        DG54,
                        DG55,
                        DG56,
                        DG57,
                        DG58,
                        DG59,
                        DG60,
                        DG61,
                        DG62,
                        DG63,
                        DG64,
                        DG65,
                        DG66,
                        DG67,
                        DG68,
                        DG69,
                        DG70,
                        DG71,
                        DG1_Txt1,
                        DG2_Txt1,
                        DG3_Txt1,
                        DG4_Txt1,
                        DG5_Txt1,
                        DG6_Txt1,
                        DG7_Txt1,
                        DG8_Txt1,
                        DG9_Txt1,
                        DG10_Txt1,
                        DG11_Txt1,
                        DG12_Txt1,
                        DG13_Txt1,
                        DG14_Txt1,
                        DG15_Txt1,
                        DG16_Txt1,
                        DG17_Txt1,
                        DG18_Txt1,
                        DG19_Txt1,
                        DG20_Txt1,
                        DG21_Txt1,
                        DG22_Txt1,
                        DG23_Txt1,
                        DG24_Txt1,
                        DG25_Txt1,
                        DG26_Txt1,
                        DG27_Txt1,
                        DG28_Txt1,
                        DG29_Txt1,
                        DG30_Txt1,
                        DG31_Txt1,
                        DG32_Txt1,
                        DG33_Txt1,
                        DG34_Txt1,
                        DG35_Txt1,
                        DG36_Txt1,
                        DG37_Txt1,
                        DG38_Txt1,
                        DG39_Txt1,
                        DG40_Txt1,
                        DG41_Txt1,
                        DG42_Txt1,
                        DG43_Txt1,
                        DG44_Txt1,
                        DG45_Txt1,
                        DG46_Txt1,
                        DG47_Txt1,
                        DG48_Txt1,
                        DG49_Txt1,
                        DG50_Txt1,
                        DG51_Txt1,
                        DG52_Txt1,
                        DG53_Txt1,
                        DG54_Txt1,
                        DG55_Txt1,
                        DG56_Txt1,
                        DG57_Txt1,
                        DG58_Txt1,
                        DG59_Txt1,
                        DG60_Txt1,
                        DG61_Txt1,
                        DG62_Txt1,
                        DG63_Txt1,
                        DG64_Txt1,
                        DG65_Txt1,
                        DG66_Txt1,
                        DG67_Txt1,
                        DG68_Txt1,
                        DG69_Txt1,
                        DG70_Txt1,
                        DG71_Txt1,
                        DG1_Txt2,
                        DG2_Txt2,
                        DG3_Txt2,
                        DG4_Txt2,
                        DG5_Txt2,
                        DG6_Txt2,
                        DG7_Txt2,
                        DG8_Txt2,
                        DG9_Txt2,
                        DG10_Txt2,
                        DG11_Txt2,
                        DG12_Txt2,
                        DG13_Txt2,
                        DG14_Txt2,
                        DG15_Txt2,
                        DG16_Txt2,
                        DG17_Txt2,
                        DG18_Txt2,
                        DG19_Txt2,
                        DG20_Txt2,
                        DG21_Txt2,
                        DG22_Txt2,
                        DG23_Txt2,
                        DG24_Txt2,
                        DG25_Txt2,
                        DG26_Txt2,
                        DG27_Txt2,
                        DG28_Txt2,
                        DG29_Txt2,
                        DG30_Txt2,
                        DG31_Txt2,
                        DG32_Txt2,
                        DG33_Txt2,
                        DG34_Txt2,
                        DG35_Txt2,
                        DG36_Txt2,
                        DG37_Txt2,
                        DG38_Txt2,
                        DG39_Txt2,
                        DG40_Txt2,
                        DG41_Txt2,
                        DG42_Txt2,
                        DG43_Txt2,
                        DG44_Txt2,
                        DG45_Txt2,
                        DG46_Txt2,
                        DG47_Txt2,
                        DG48_Txt2,
                        DG49_Txt2,
                        DG50_Txt2,
                        DG51_Txt2,
                        DG52_Txt2,
                        DG53_Txt2,
                        DG54_Txt2,
                        DG55_Txt2,
                        DG56_Txt2,
                        DG57_Txt2,
                        DG58_Txt2,
                        DG59_Txt2,
                        DG60_Txt2,
                        DG61_Txt2,
                        DG62_Txt2,
                        DG63_Txt2,
                        DG64_Txt2,
                        DG65_Txt2,
                        DG66_Txt2,
                        DG67_Txt2,
                        DG68_Txt2,
                        DG69_Txt2,
                        DG70_Txt2,
                        DG71_Txt2,
                        KetLuan,
                        NguoiThucHien,
                        MaNVNguoiThucHien,
                        NgayTao,
                        NguoiTao,
                        NgaySua,
                        NguoiSua
                        )VALUES
                        (
                        :MaQuanLy,
                        :MaBenhNhan,
                        :ChanDoan,
                        :DiaChi,
                        :ThoiGian,
                        :DG1,
                        :DG2,
                        :DG3,
                        :DG4,
                        :DG5,
                        :DG6,
                        :DG7,
                        :DG8,
                        :DG9,
                        :DG10,
                        :DG11,
                        :DG12,
                        :DG13,
                        :DG14,
                        :DG15,
                        :DG16,
                        :DG17,
                        :DG18,
                        :DG19,
                        :DG20,
                        :DG21,
                        :DG22,
                        :DG23,
                        :DG24,
                        :DG25,
                        :DG26,
                        :DG27,
                        :DG28,
                        :DG29,
                        :DG30,
                        :DG31,
                        :DG32,
                        :DG33,
                        :DG34,
                        :DG35,
                        :DG36,
                        :DG37,
                        :DG38,
                        :DG39,
                        :DG40,
                        :DG41,
                        :DG42,
                        :DG43,
                        :DG44,
                        :DG45,
                        :DG46,
                        :DG47,
                        :DG48,
                        :DG49,
                        :DG50,
                        :DG51,
                        :DG52,
                        :DG53,
                        :DG54,
                        :DG55,
                        :DG56,
                        :DG57,
                        :DG58,
                        :DG59,
                        :DG60,
                        :DG61,
                        :DG62,
                        :DG63,
                        :DG64,
                        :DG65,
                        :DG66,
                        :DG67,
                        :DG68,
                        :DG69,
                        :DG70,
                        :DG71,
                        :DG1_Txt1,
                        :DG2_Txt1,
                        :DG3_Txt1,
                        :DG4_Txt1,
                        :DG5_Txt1,
                        :DG6_Txt1,
                        :DG7_Txt1,
                        :DG8_Txt1,
                        :DG9_Txt1,
                        :DG10_Txt1,
                        :DG11_Txt1,
                        :DG12_Txt1,
                        :DG13_Txt1,
                        :DG14_Txt1,
                        :DG15_Txt1,
                        :DG16_Txt1,
                        :DG17_Txt1,
                        :DG18_Txt1,
                        :DG19_Txt1,
                        :DG20_Txt1,
                        :DG21_Txt1,
                        :DG22_Txt1,
                        :DG23_Txt1,
                        :DG24_Txt1,
                        :DG25_Txt1,
                        :DG26_Txt1,
                        :DG27_Txt1,
                        :DG28_Txt1,
                        :DG29_Txt1,
                        :DG30_Txt1,
                        :DG31_Txt1,
                        :DG32_Txt1,
                        :DG33_Txt1,
                        :DG34_Txt1,
                        :DG35_Txt1,
                        :DG36_Txt1,
                        :DG37_Txt1,
                        :DG38_Txt1,
                        :DG39_Txt1,
                        :DG40_Txt1,
                        :DG41_Txt1,
                        :DG42_Txt1,
                        :DG43_Txt1,
                        :DG44_Txt1,
                        :DG45_Txt1,
                        :DG46_Txt1,
                        :DG47_Txt1,
                        :DG48_Txt1,
                        :DG49_Txt1,
                        :DG50_Txt1,
                        :DG51_Txt1,
                        :DG52_Txt1,
                        :DG53_Txt1,
                        :DG54_Txt1,
                        :DG55_Txt1,
                        :DG56_Txt1,
                        :DG57_Txt1,
                        :DG58_Txt1,
                        :DG59_Txt1,
                        :DG60_Txt1,
                        :DG61_Txt1,
                        :DG62_Txt1,
                        :DG63_Txt1,
                        :DG64_Txt1,
                        :DG65_Txt1,
                        :DG66_Txt1,
                        :DG67_Txt1,
                        :DG68_Txt1,
                        :DG69_Txt1,
                        :DG70_Txt1,
                        :DG71_Txt1,
                        :DG1_Txt2,
                        :DG2_Txt2,
                        :DG3_Txt2,
                        :DG4_Txt2,
                        :DG5_Txt2,
                        :DG6_Txt2,
                        :DG7_Txt2,
                        :DG8_Txt2,
                        :DG9_Txt2,
                        :DG10_Txt2,
                        :DG11_Txt2,
                        :DG12_Txt2,
                        :DG13_Txt2,
                        :DG14_Txt2,
                        :DG15_Txt2,
                        :DG16_Txt2,
                        :DG17_Txt2,
                        :DG18_Txt2,
                        :DG19_Txt2,
                        :DG20_Txt2,
                        :DG21_Txt2,
                        :DG22_Txt2,
                        :DG23_Txt2,
                        :DG24_Txt2,
                        :DG25_Txt2,
                        :DG26_Txt2,
                        :DG27_Txt2,
                        :DG28_Txt2,
                        :DG29_Txt2,
                        :DG30_Txt2,
                        :DG31_Txt2,
                        :DG32_Txt2,
                        :DG33_Txt2,
                        :DG34_Txt2,
                        :DG35_Txt2,
                        :DG36_Txt2,
                        :DG37_Txt2,
                        :DG38_Txt2,
                        :DG39_Txt2,
                        :DG40_Txt2,
                        :DG41_Txt2,
                        :DG42_Txt2,
                        :DG43_Txt2,
                        :DG44_Txt2,
                        :DG45_Txt2,
                        :DG46_Txt2,
                        :DG47_Txt2,
                        :DG48_Txt2,
                        :DG49_Txt2,
                        :DG50_Txt2,
                        :DG51_Txt2,
                        :DG52_Txt2,
                        :DG53_Txt2,
                        :DG54_Txt2,
                        :DG55_Txt2,
                        :DG56_Txt2,
                        :DG57_Txt2,
                        :DG58_Txt2,
                        :DG59_Txt2,
                        :DG60_Txt2,
                        :DG61_Txt2,
                        :DG62_Txt2,
                        :DG63_Txt2,
                        :DG64_Txt2,
                        :DG65_Txt2,
                        :DG66_Txt2,
                        :DG67_Txt2,
                        :DG68_Txt2,
                        :DG69_Txt2,
                        :DG70_Txt2,
                        :DG71_Txt2,
                        :KetLuan,
                        :NguoiThucHien,
                        :MaNVNguoiThucHien,
                        :NgayTao,
                        :NguoiTao,
                        :NgaySua,
                        :NguoiSua
                        ) RETURNING IDPhieu INTO :IDPhieu";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, conn);
                command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", obj.MaQuanLy));
                command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", obj.MaBenhNhan));
                command.Parameters.Add(new MDB.MDBParameter("DiaChi", obj.DiaChi));
                command.Parameters.Add(new MDB.MDBParameter("ChanDoan", obj.ChanDoan));
                command.Parameters.Add(new MDB.MDBParameter("ThoiGian", obj.ThoiGian));
                command.Parameters.Add(new MDB.MDBParameter("DG1", obj.DG1));
                command.Parameters.Add(new MDB.MDBParameter("DG2", obj.DG2));
                command.Parameters.Add(new MDB.MDBParameter("DG3", obj.DG3));
                command.Parameters.Add(new MDB.MDBParameter("DG4", obj.DG4));
                command.Parameters.Add(new MDB.MDBParameter("DG5", obj.DG5));
                command.Parameters.Add(new MDB.MDBParameter("DG6", obj.DG6));
                command.Parameters.Add(new MDB.MDBParameter("DG7", obj.DG7));
                command.Parameters.Add(new MDB.MDBParameter("DG8", obj.DG8));
                command.Parameters.Add(new MDB.MDBParameter("DG9", obj.DG9));
                command.Parameters.Add(new MDB.MDBParameter("DG10", obj.DG10));
                command.Parameters.Add(new MDB.MDBParameter("DG11", obj.DG11));
                command.Parameters.Add(new MDB.MDBParameter("DG12", obj.DG12));
                command.Parameters.Add(new MDB.MDBParameter("DG13", obj.DG13));
                command.Parameters.Add(new MDB.MDBParameter("DG14", obj.DG14));
                command.Parameters.Add(new MDB.MDBParameter("DG15", obj.DG15));
                command.Parameters.Add(new MDB.MDBParameter("DG16", obj.DG16));
                command.Parameters.Add(new MDB.MDBParameter("DG17", obj.DG17));
                command.Parameters.Add(new MDB.MDBParameter("DG18", obj.DG18));
                command.Parameters.Add(new MDB.MDBParameter("DG19", obj.DG19));
                command.Parameters.Add(new MDB.MDBParameter("DG20", obj.DG20));
                command.Parameters.Add(new MDB.MDBParameter("DG21", obj.DG21));
                command.Parameters.Add(new MDB.MDBParameter("DG22", obj.DG22));
                command.Parameters.Add(new MDB.MDBParameter("DG23", obj.DG23));
                command.Parameters.Add(new MDB.MDBParameter("DG24", obj.DG24));
                command.Parameters.Add(new MDB.MDBParameter("DG25", obj.DG25));
                command.Parameters.Add(new MDB.MDBParameter("DG26", obj.DG26));
                command.Parameters.Add(new MDB.MDBParameter("DG27", obj.DG27));
                command.Parameters.Add(new MDB.MDBParameter("DG28", obj.DG28));
                command.Parameters.Add(new MDB.MDBParameter("DG29", obj.DG29));
                command.Parameters.Add(new MDB.MDBParameter("DG30", obj.DG30));
                command.Parameters.Add(new MDB.MDBParameter("DG31", obj.DG31));
                command.Parameters.Add(new MDB.MDBParameter("DG32", obj.DG32));
                command.Parameters.Add(new MDB.MDBParameter("DG33", obj.DG33));
                command.Parameters.Add(new MDB.MDBParameter("DG34", obj.DG34));
                command.Parameters.Add(new MDB.MDBParameter("DG35", obj.DG35));
                command.Parameters.Add(new MDB.MDBParameter("DG36", obj.DG36));
                command.Parameters.Add(new MDB.MDBParameter("DG37", obj.DG37));
                command.Parameters.Add(new MDB.MDBParameter("DG38", obj.DG38));
                command.Parameters.Add(new MDB.MDBParameter("DG39", obj.DG39));
                command.Parameters.Add(new MDB.MDBParameter("DG40", obj.DG40));
                command.Parameters.Add(new MDB.MDBParameter("DG41", obj.DG41));
                command.Parameters.Add(new MDB.MDBParameter("DG42", obj.DG42));
                command.Parameters.Add(new MDB.MDBParameter("DG43", obj.DG43));
                command.Parameters.Add(new MDB.MDBParameter("DG44", obj.DG44));
                command.Parameters.Add(new MDB.MDBParameter("DG45", obj.DG45));
                command.Parameters.Add(new MDB.MDBParameter("DG46", obj.DG46));
                command.Parameters.Add(new MDB.MDBParameter("DG47", obj.DG47));
                command.Parameters.Add(new MDB.MDBParameter("DG48", obj.DG48));
                command.Parameters.Add(new MDB.MDBParameter("DG49", obj.DG49));
                command.Parameters.Add(new MDB.MDBParameter("DG50", obj.DG50));
                command.Parameters.Add(new MDB.MDBParameter("DG51", obj.DG51));
                command.Parameters.Add(new MDB.MDBParameter("DG52", obj.DG52));
                command.Parameters.Add(new MDB.MDBParameter("DG53", obj.DG53));
                command.Parameters.Add(new MDB.MDBParameter("DG54", obj.DG54));
                command.Parameters.Add(new MDB.MDBParameter("DG55", obj.DG55));
                command.Parameters.Add(new MDB.MDBParameter("DG56", obj.DG56));
                command.Parameters.Add(new MDB.MDBParameter("DG57", obj.DG57));
                command.Parameters.Add(new MDB.MDBParameter("DG58", obj.DG58));
                command.Parameters.Add(new MDB.MDBParameter("DG59", obj.DG59));
                command.Parameters.Add(new MDB.MDBParameter("DG60", obj.DG60));
                command.Parameters.Add(new MDB.MDBParameter("DG61", obj.DG61));
                command.Parameters.Add(new MDB.MDBParameter("DG62", obj.DG62));
                command.Parameters.Add(new MDB.MDBParameter("DG63", obj.DG63));
                command.Parameters.Add(new MDB.MDBParameter("DG64", obj.DG64));
                command.Parameters.Add(new MDB.MDBParameter("DG65", obj.DG65));
                command.Parameters.Add(new MDB.MDBParameter("DG66", obj.DG66));
                command.Parameters.Add(new MDB.MDBParameter("DG67", obj.DG67));
                command.Parameters.Add(new MDB.MDBParameter("DG68", obj.DG68));
                command.Parameters.Add(new MDB.MDBParameter("DG69", obj.DG69));
                command.Parameters.Add(new MDB.MDBParameter("DG70", obj.DG70));
                command.Parameters.Add(new MDB.MDBParameter("DG71", obj.DG71));
                command.Parameters.Add(new MDB.MDBParameter("DG1_Txt1", obj.DG1_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG2_Txt1", obj.DG2_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG3_Txt1", obj.DG3_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG4_Txt1", obj.DG4_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG5_Txt1", obj.DG5_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG6_Txt1", obj.DG6_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG7_Txt1", obj.DG7_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG8_Txt1", obj.DG8_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG9_Txt1", obj.DG9_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG10_Txt1", obj.DG10_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG11_Txt1", obj.DG11_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG12_Txt1", obj.DG12_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG13_Txt1", obj.DG13_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG14_Txt1", obj.DG14_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG15_Txt1", obj.DG15_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG16_Txt1", obj.DG16_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG17_Txt1", obj.DG17_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG18_Txt1", obj.DG18_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG19_Txt1", obj.DG19_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG20_Txt1", obj.DG20_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG21_Txt1", obj.DG21_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG22_Txt1", obj.DG22_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG23_Txt1", obj.DG23_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG24_Txt1", obj.DG24_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG25_Txt1", obj.DG25_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG26_Txt1", obj.DG26_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG27_Txt1", obj.DG27_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG28_Txt1", obj.DG28_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG29_Txt1", obj.DG29_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG30_Txt1", obj.DG30_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG31_Txt1", obj.DG31_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG32_Txt1", obj.DG32_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG33_Txt1", obj.DG33_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG34_Txt1", obj.DG34_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG35_Txt1", obj.DG35_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG36_Txt1", obj.DG36_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG37_Txt1", obj.DG37_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG38_Txt1", obj.DG38_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG39_Txt1", obj.DG39_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG40_Txt1", obj.DG40_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG41_Txt1", obj.DG41_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG42_Txt1", obj.DG42_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG43_Txt1", obj.DG43_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG44_Txt1", obj.DG44_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG45_Txt1", obj.DG45_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG46_Txt1", obj.DG46_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG47_Txt1", obj.DG47_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG48_Txt1", obj.DG48_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG49_Txt1", obj.DG49_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG50_Txt1", obj.DG50_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG51_Txt1", obj.DG51_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG52_Txt1", obj.DG52_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG53_Txt1", obj.DG53_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG54_Txt1", obj.DG54_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG55_Txt1", obj.DG55_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG56_Txt1", obj.DG56_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG57_Txt1", obj.DG57_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG58_Txt1", obj.DG58_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG59_Txt1", obj.DG59_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG60_Txt1", obj.DG60_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG61_Txt1", obj.DG61_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG62_Txt1", obj.DG62_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG63_Txt1", obj.DG63_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG64_Txt1", obj.DG64_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG65_Txt1", obj.DG65_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG66_Txt1", obj.DG66_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG67_Txt1", obj.DG67_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG68_Txt1", obj.DG68_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG69_Txt1", obj.DG69_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG70_Txt1", obj.DG70_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG71_Txt1", obj.DG71_Txt1));
                command.Parameters.Add(new MDB.MDBParameter("DG1_Txt2", obj.DG1_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG2_Txt2", obj.DG2_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG3_Txt2", obj.DG3_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG4_Txt2", obj.DG4_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG5_Txt2", obj.DG5_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG6_Txt2", obj.DG6_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG7_Txt2", obj.DG7_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG8_Txt2", obj.DG8_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG9_Txt2", obj.DG9_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG10_Txt2", obj.DG10_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG11_Txt2", obj.DG11_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG12_Txt2", obj.DG12_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG13_Txt2", obj.DG13_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG14_Txt2", obj.DG14_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG15_Txt2", obj.DG15_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG16_Txt2", obj.DG16_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG17_Txt2", obj.DG17_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG18_Txt2", obj.DG18_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG19_Txt2", obj.DG19_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG20_Txt2", obj.DG20_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG21_Txt2", obj.DG21_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG22_Txt2", obj.DG22_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG23_Txt2", obj.DG23_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG24_Txt2", obj.DG24_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG25_Txt2", obj.DG25_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG26_Txt2", obj.DG26_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG27_Txt2", obj.DG27_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG28_Txt2", obj.DG28_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG29_Txt2", obj.DG29_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG30_Txt2", obj.DG30_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG31_Txt2", obj.DG31_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG32_Txt2", obj.DG32_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG33_Txt2", obj.DG33_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG34_Txt2", obj.DG34_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG35_Txt2", obj.DG35_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG36_Txt2", obj.DG36_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG37_Txt2", obj.DG37_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG38_Txt2", obj.DG38_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG39_Txt2", obj.DG39_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG40_Txt2", obj.DG40_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG41_Txt2", obj.DG41_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG42_Txt2", obj.DG42_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG43_Txt2", obj.DG43_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG44_Txt2", obj.DG44_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG45_Txt2", obj.DG45_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG46_Txt2", obj.DG46_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG47_Txt2", obj.DG47_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG48_Txt2", obj.DG48_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG49_Txt2", obj.DG49_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG50_Txt2", obj.DG50_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG51_Txt2", obj.DG51_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG52_Txt2", obj.DG52_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG53_Txt2", obj.DG53_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG54_Txt2", obj.DG54_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG55_Txt2", obj.DG55_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG56_Txt2", obj.DG56_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG57_Txt2", obj.DG57_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG58_Txt2", obj.DG58_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG59_Txt2", obj.DG59_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG60_Txt2", obj.DG60_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG61_Txt2", obj.DG61_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG62_Txt2", obj.DG62_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG63_Txt2", obj.DG63_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG64_Txt2", obj.DG64_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG65_Txt2", obj.DG65_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG66_Txt2", obj.DG66_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG67_Txt2", obj.DG67_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG68_Txt2", obj.DG68_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG69_Txt2", obj.DG69_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG70_Txt2", obj.DG70_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("DG71_Txt2", obj.DG71_Txt2));
                command.Parameters.Add(new MDB.MDBParameter("KetLuan", obj.KetLuan));
                command.Parameters.Add(new MDB.MDBParameter("NguoiThucHien", obj.NguoiThucHien));
                command.Parameters.Add(new MDB.MDBParameter("MaNVNguoiThucHien", obj.MaNVNguoiThucHien));
                command.Parameters.Add(new MDB.MDBParameter("NgaySua", DateTime.Now));
                command.Parameters.Add(new MDB.MDBParameter("NguoiSua", Common.getUserLogin()));
                if (obj.IDPhieu == 0)
                {
                    command.Parameters.Add(new MDB.MDBParameter("IDPhieu", obj.IDPhieu));
                    command.Parameters.Add(new MDB.MDBParameter("NgayTao", DateTime.Now));
                    command.Parameters.Add(new MDB.MDBParameter("NguoiTao", Common.getUserLogin()));
                }
                command.BindByName = true;
                int n = command.ExecuteNonQuery();
                if (obj.IDPhieu == 0)
                {
                    long nextval = Convert.ToInt64((command.Parameters["IDPhieu"] as MDB.MDBParameter).Value);
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

        public static List<PhieuDGNhanCach> GetData(decimal MaQuanLy, MDB.MDBConnection conn)
        {
            List<PhieuDGNhanCach> lstObject = new List<PhieuDGNhanCach>();
            try
            {
                string sql = "SELECT * FROM PhieuDGNhanCach WHERE MAQUANLY = :MAQUANLY ORDER BY IDPhieu DESC";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, conn);
                command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", MaQuanLy));
                MDB.MDBDataReader DataReader = command.ExecuteReader();
                while (DataReader.Read())
                {
                    EMR_MAIN.DATABASE.Other.PhieuDGNhanCach obj = new PhieuDGNhanCach();
                    obj.IDPhieu = Convert.ToInt64(DataReader.GetLong("IDPhieu"));
                    obj.MaQuanLy = Common.ConDB_Decimal(DataReader["MaQuanLy"]);
                    obj.MaBenhNhan = Common.ConDBNull(DataReader["MaBenhNhan"]);
                    obj.ChanDoan = Common.ConDBNull(DataReader["ChanDoan"]);
                    obj.DiaChi = Common.ConDBNull(DataReader["DiaChi"]);
                    obj.ThoiGian = Common.ConDB_DateTime(DataReader["ThoiGian"]);
                    obj.DG1 = Common.ConDB_Int(DataReader["DG1"]);
                    obj.DG2 = Common.ConDB_Int(DataReader["DG2"]);
                    obj.DG3 = Common.ConDB_Int(DataReader["DG3"]);
                    obj.DG4 = Common.ConDB_Int(DataReader["DG4"]);
                    obj.DG5 = Common.ConDB_Int(DataReader["DG5"]);
                    obj.DG6 = Common.ConDB_Int(DataReader["DG6"]);
                    obj.DG7 = Common.ConDB_Int(DataReader["DG7"]);
                    obj.DG8 = Common.ConDB_Int(DataReader["DG8"]);
                    obj.DG9 = Common.ConDB_Int(DataReader["DG9"]);
                    obj.DG10 = Common.ConDB_Int(DataReader["DG10"]);
                    obj.DG11 = Common.ConDB_Int(DataReader["DG11"]);
                    obj.DG12 = Common.ConDB_Int(DataReader["DG12"]);
                    obj.DG13 = Common.ConDB_Int(DataReader["DG13"]);
                    obj.DG14 = Common.ConDB_Int(DataReader["DG14"]);
                    obj.DG15 = Common.ConDB_Int(DataReader["DG15"]);
                    obj.DG16 = Common.ConDB_Int(DataReader["DG16"]);
                    obj.DG17 = Common.ConDB_Int(DataReader["DG17"]);
                    obj.DG18 = Common.ConDB_Int(DataReader["DG18"]);
                    obj.DG19 = Common.ConDB_Int(DataReader["DG19"]);
                    obj.DG20 = Common.ConDB_Int(DataReader["DG20"]);
                    obj.DG21 = Common.ConDB_Int(DataReader["DG21"]);
                    obj.DG22 = Common.ConDB_Int(DataReader["DG22"]);
                    obj.DG23 = Common.ConDB_Int(DataReader["DG23"]);
                    obj.DG24 = Common.ConDB_Int(DataReader["DG24"]);
                    obj.DG25 = Common.ConDB_Int(DataReader["DG25"]);
                    obj.DG26 = Common.ConDB_Int(DataReader["DG26"]);
                    obj.DG27 = Common.ConDB_Int(DataReader["DG27"]);
                    obj.DG28 = Common.ConDB_Int(DataReader["DG28"]);
                    obj.DG29 = Common.ConDB_Int(DataReader["DG29"]);
                    obj.DG30 = Common.ConDB_Int(DataReader["DG30"]);
                    obj.DG31 = Common.ConDB_Int(DataReader["DG31"]);
                    obj.DG32 = Common.ConDB_Int(DataReader["DG32"]);
                    obj.DG33 = Common.ConDB_Int(DataReader["DG33"]);
                    obj.DG34 = Common.ConDB_Int(DataReader["DG34"]);
                    obj.DG35 = Common.ConDB_Int(DataReader["DG35"]);
                    obj.DG36 = Common.ConDB_Int(DataReader["DG36"]);
                    obj.DG37 = Common.ConDB_Int(DataReader["DG37"]);
                    obj.DG38 = Common.ConDB_Int(DataReader["DG38"]);
                    obj.DG39 = Common.ConDB_Int(DataReader["DG39"]);
                    obj.DG40 = Common.ConDB_Int(DataReader["DG40"]);
                    obj.DG41 = Common.ConDB_Int(DataReader["DG41"]);
                    obj.DG42 = Common.ConDB_Int(DataReader["DG42"]);
                    obj.DG43 = Common.ConDB_Int(DataReader["DG43"]);
                    obj.DG44 = Common.ConDB_Int(DataReader["DG44"]);
                    obj.DG45 = Common.ConDB_Int(DataReader["DG45"]);
                    obj.DG46 = Common.ConDB_Int(DataReader["DG46"]);
                    obj.DG47 = Common.ConDB_Int(DataReader["DG47"]);
                    obj.DG48 = Common.ConDB_Int(DataReader["DG48"]);
                    obj.DG49 = Common.ConDB_Int(DataReader["DG49"]);
                    obj.DG50 = Common.ConDB_Int(DataReader["DG50"]);
                    obj.DG51 = Common.ConDB_Int(DataReader["DG51"]);
                    obj.DG52 = Common.ConDB_Int(DataReader["DG52"]);
                    obj.DG53 = Common.ConDB_Int(DataReader["DG53"]);
                    obj.DG54 = Common.ConDB_Int(DataReader["DG54"]);
                    obj.DG55 = Common.ConDB_Int(DataReader["DG55"]);
                    obj.DG56 = Common.ConDB_Int(DataReader["DG56"]);
                    obj.DG57 = Common.ConDB_Int(DataReader["DG57"]);
                    obj.DG58 = Common.ConDB_Int(DataReader["DG58"]);
                    obj.DG59 = Common.ConDB_Int(DataReader["DG59"]);
                    obj.DG60 = Common.ConDB_Int(DataReader["DG60"]);
                    obj.DG61 = Common.ConDB_Int(DataReader["DG61"]);
                    obj.DG62 = Common.ConDB_Int(DataReader["DG62"]);
                    obj.DG63 = Common.ConDB_Int(DataReader["DG63"]);
                    obj.DG64 = Common.ConDB_Int(DataReader["DG64"]);
                    obj.DG65 = Common.ConDB_Int(DataReader["DG65"]);
                    obj.DG66 = Common.ConDB_Int(DataReader["DG66"]);
                    obj.DG67 = Common.ConDB_Int(DataReader["DG67"]);
                    obj.DG68 = Common.ConDB_Int(DataReader["DG68"]);
                    obj.DG69 = Common.ConDB_Int(DataReader["DG69"]);
                    obj.DG70 = Common.ConDB_Int(DataReader["DG70"]);
                    obj.DG71 = Common.ConDB_Int(DataReader["DG71"]);
                    obj.DG1_Txt1 = Common.ConDBNull(DataReader["DG1_Txt1"]);
                    obj.DG2_Txt1 = Common.ConDBNull(DataReader["DG2_Txt1"]);
                    obj.DG3_Txt1 = Common.ConDBNull(DataReader["DG3_Txt1"]);
                    obj.DG4_Txt1 = Common.ConDBNull(DataReader["DG4_Txt1"]);
                    obj.DG5_Txt1 = Common.ConDBNull(DataReader["DG5_Txt1"]);
                    obj.DG6_Txt1 = Common.ConDBNull(DataReader["DG6_Txt1"]);
                    obj.DG7_Txt1 = Common.ConDBNull(DataReader["DG7_Txt1"]);
                    obj.DG8_Txt1 = Common.ConDBNull(DataReader["DG8_Txt1"]);
                    obj.DG9_Txt1 = Common.ConDBNull(DataReader["DG9_Txt1"]);
                    obj.DG10_Txt1 = Common.ConDBNull(DataReader["DG10_Txt1"]);
                    obj.DG11_Txt1 = Common.ConDBNull(DataReader["DG11_Txt1"]);
                    obj.DG12_Txt1 = Common.ConDBNull(DataReader["DG12_Txt1"]);
                    obj.DG13_Txt1 = Common.ConDBNull(DataReader["DG13_Txt1"]);
                    obj.DG14_Txt1 = Common.ConDBNull(DataReader["DG14_Txt1"]);
                    obj.DG15_Txt1 = Common.ConDBNull(DataReader["DG15_Txt1"]);
                    obj.DG16_Txt1 = Common.ConDBNull(DataReader["DG16_Txt1"]);
                    obj.DG17_Txt1 = Common.ConDBNull(DataReader["DG17_Txt1"]);
                    obj.DG18_Txt1 = Common.ConDBNull(DataReader["DG18_Txt1"]);
                    obj.DG19_Txt1 = Common.ConDBNull(DataReader["DG19_Txt1"]);
                    obj.DG20_Txt1 = Common.ConDBNull(DataReader["DG20_Txt1"]);
                    obj.DG21_Txt1 = Common.ConDBNull(DataReader["DG21_Txt1"]);
                    obj.DG22_Txt1 = Common.ConDBNull(DataReader["DG22_Txt1"]);
                    obj.DG23_Txt1 = Common.ConDBNull(DataReader["DG23_Txt1"]);
                    obj.DG24_Txt1 = Common.ConDBNull(DataReader["DG24_Txt1"]);
                    obj.DG25_Txt1 = Common.ConDBNull(DataReader["DG25_Txt1"]);
                    obj.DG26_Txt1 = Common.ConDBNull(DataReader["DG26_Txt1"]);
                    obj.DG27_Txt1 = Common.ConDBNull(DataReader["DG27_Txt1"]);
                    obj.DG28_Txt1 = Common.ConDBNull(DataReader["DG28_Txt1"]);
                    obj.DG29_Txt1 = Common.ConDBNull(DataReader["DG29_Txt1"]);
                    obj.DG30_Txt1 = Common.ConDBNull(DataReader["DG30_Txt1"]);
                    obj.DG31_Txt1 = Common.ConDBNull(DataReader["DG31_Txt1"]);
                    obj.DG32_Txt1 = Common.ConDBNull(DataReader["DG32_Txt1"]);
                    obj.DG33_Txt1 = Common.ConDBNull(DataReader["DG33_Txt1"]);
                    obj.DG34_Txt1 = Common.ConDBNull(DataReader["DG34_Txt1"]);
                    obj.DG35_Txt1 = Common.ConDBNull(DataReader["DG35_Txt1"]);
                    obj.DG36_Txt1 = Common.ConDBNull(DataReader["DG36_Txt1"]);
                    obj.DG37_Txt1 = Common.ConDBNull(DataReader["DG37_Txt1"]);
                    obj.DG38_Txt1 = Common.ConDBNull(DataReader["DG38_Txt1"]);
                    obj.DG39_Txt1 = Common.ConDBNull(DataReader["DG39_Txt1"]);
                    obj.DG40_Txt1 = Common.ConDBNull(DataReader["DG40_Txt1"]);
                    obj.DG41_Txt1 = Common.ConDBNull(DataReader["DG41_Txt1"]);
                    obj.DG42_Txt1 = Common.ConDBNull(DataReader["DG42_Txt1"]);
                    obj.DG43_Txt1 = Common.ConDBNull(DataReader["DG43_Txt1"]);
                    obj.DG44_Txt1 = Common.ConDBNull(DataReader["DG44_Txt1"]);
                    obj.DG45_Txt1 = Common.ConDBNull(DataReader["DG45_Txt1"]);
                    obj.DG46_Txt1 = Common.ConDBNull(DataReader["DG46_Txt1"]);
                    obj.DG47_Txt1 = Common.ConDBNull(DataReader["DG47_Txt1"]);
                    obj.DG48_Txt1 = Common.ConDBNull(DataReader["DG48_Txt1"]);
                    obj.DG49_Txt1 = Common.ConDBNull(DataReader["DG49_Txt1"]);
                    obj.DG50_Txt1 = Common.ConDBNull(DataReader["DG50_Txt1"]);
                    obj.DG51_Txt1 = Common.ConDBNull(DataReader["DG51_Txt1"]);
                    obj.DG52_Txt1 = Common.ConDBNull(DataReader["DG52_Txt1"]);
                    obj.DG53_Txt1 = Common.ConDBNull(DataReader["DG53_Txt1"]);
                    obj.DG54_Txt1 = Common.ConDBNull(DataReader["DG54_Txt1"]);
                    obj.DG55_Txt1 = Common.ConDBNull(DataReader["DG55_Txt1"]);
                    obj.DG56_Txt1 = Common.ConDBNull(DataReader["DG56_Txt1"]);
                    obj.DG57_Txt1 = Common.ConDBNull(DataReader["DG57_Txt1"]);
                    obj.DG58_Txt1 = Common.ConDBNull(DataReader["DG58_Txt1"]);
                    obj.DG59_Txt1 = Common.ConDBNull(DataReader["DG59_Txt1"]);
                    obj.DG60_Txt1 = Common.ConDBNull(DataReader["DG60_Txt1"]);
                    obj.DG61_Txt1 = Common.ConDBNull(DataReader["DG61_Txt1"]);
                    obj.DG62_Txt1 = Common.ConDBNull(DataReader["DG62_Txt1"]);
                    obj.DG63_Txt1 = Common.ConDBNull(DataReader["DG63_Txt1"]);
                    obj.DG64_Txt1 = Common.ConDBNull(DataReader["DG64_Txt1"]);
                    obj.DG65_Txt1 = Common.ConDBNull(DataReader["DG65_Txt1"]);
                    obj.DG66_Txt1 = Common.ConDBNull(DataReader["DG66_Txt1"]);
                    obj.DG67_Txt1 = Common.ConDBNull(DataReader["DG67_Txt1"]);
                    obj.DG68_Txt1 = Common.ConDBNull(DataReader["DG68_Txt1"]);
                    obj.DG69_Txt1 = Common.ConDBNull(DataReader["DG69_Txt1"]);
                    obj.DG70_Txt1 = Common.ConDBNull(DataReader["DG70_Txt1"]);
                    obj.DG71_Txt1 = Common.ConDBNull(DataReader["DG71_Txt1"]);
                    obj.DG1_Txt2 = Common.ConDBNull(DataReader["DG1_Txt2"]);
                    obj.DG2_Txt2 = Common.ConDBNull(DataReader["DG2_Txt2"]);
                    obj.DG3_Txt2 = Common.ConDBNull(DataReader["DG3_Txt2"]);
                    obj.DG4_Txt2 = Common.ConDBNull(DataReader["DG4_Txt2"]);
                    obj.DG5_Txt2 = Common.ConDBNull(DataReader["DG5_Txt2"]);
                    obj.DG6_Txt2 = Common.ConDBNull(DataReader["DG6_Txt2"]);
                    obj.DG7_Txt2 = Common.ConDBNull(DataReader["DG7_Txt2"]);
                    obj.DG8_Txt2 = Common.ConDBNull(DataReader["DG8_Txt2"]);
                    obj.DG9_Txt2 = Common.ConDBNull(DataReader["DG9_Txt2"]);
                    obj.DG10_Txt2 = Common.ConDBNull(DataReader["DG10_Txt2"]);
                    obj.DG11_Txt2 = Common.ConDBNull(DataReader["DG11_Txt2"]);
                    obj.DG12_Txt2 = Common.ConDBNull(DataReader["DG12_Txt2"]);
                    obj.DG13_Txt2 = Common.ConDBNull(DataReader["DG13_Txt2"]);
                    obj.DG14_Txt2 = Common.ConDBNull(DataReader["DG14_Txt2"]);
                    obj.DG15_Txt2 = Common.ConDBNull(DataReader["DG15_Txt2"]);
                    obj.DG16_Txt2 = Common.ConDBNull(DataReader["DG16_Txt2"]);
                    obj.DG17_Txt2 = Common.ConDBNull(DataReader["DG17_Txt2"]);
                    obj.DG18_Txt2 = Common.ConDBNull(DataReader["DG18_Txt2"]);
                    obj.DG19_Txt2 = Common.ConDBNull(DataReader["DG19_Txt2"]);
                    obj.DG20_Txt2 = Common.ConDBNull(DataReader["DG20_Txt2"]);
                    obj.DG21_Txt2 = Common.ConDBNull(DataReader["DG21_Txt2"]);
                    obj.DG22_Txt2 = Common.ConDBNull(DataReader["DG22_Txt2"]);
                    obj.DG23_Txt2 = Common.ConDBNull(DataReader["DG23_Txt2"]);
                    obj.DG24_Txt2 = Common.ConDBNull(DataReader["DG24_Txt2"]);
                    obj.DG25_Txt2 = Common.ConDBNull(DataReader["DG25_Txt2"]);
                    obj.DG26_Txt2 = Common.ConDBNull(DataReader["DG26_Txt2"]);
                    obj.DG27_Txt2 = Common.ConDBNull(DataReader["DG27_Txt2"]);
                    obj.DG28_Txt2 = Common.ConDBNull(DataReader["DG28_Txt2"]);
                    obj.DG29_Txt2 = Common.ConDBNull(DataReader["DG29_Txt2"]);
                    obj.DG30_Txt2 = Common.ConDBNull(DataReader["DG30_Txt2"]);
                    obj.DG31_Txt2 = Common.ConDBNull(DataReader["DG31_Txt2"]);
                    obj.DG32_Txt2 = Common.ConDBNull(DataReader["DG32_Txt2"]);
                    obj.DG33_Txt2 = Common.ConDBNull(DataReader["DG33_Txt2"]);
                    obj.DG34_Txt2 = Common.ConDBNull(DataReader["DG34_Txt2"]);
                    obj.DG35_Txt2 = Common.ConDBNull(DataReader["DG35_Txt2"]);
                    obj.DG36_Txt2 = Common.ConDBNull(DataReader["DG36_Txt2"]);
                    obj.DG37_Txt2 = Common.ConDBNull(DataReader["DG37_Txt2"]);
                    obj.DG38_Txt2 = Common.ConDBNull(DataReader["DG38_Txt2"]);
                    obj.DG39_Txt2 = Common.ConDBNull(DataReader["DG39_Txt2"]);
                    obj.DG40_Txt2 = Common.ConDBNull(DataReader["DG40_Txt2"]);
                    obj.DG41_Txt2 = Common.ConDBNull(DataReader["DG41_Txt2"]);
                    obj.DG42_Txt2 = Common.ConDBNull(DataReader["DG42_Txt2"]);
                    obj.DG43_Txt2 = Common.ConDBNull(DataReader["DG43_Txt2"]);
                    obj.DG44_Txt2 = Common.ConDBNull(DataReader["DG44_Txt2"]);
                    obj.DG45_Txt2 = Common.ConDBNull(DataReader["DG45_Txt2"]);
                    obj.DG46_Txt2 = Common.ConDBNull(DataReader["DG46_Txt2"]);
                    obj.DG47_Txt2 = Common.ConDBNull(DataReader["DG47_Txt2"]);
                    obj.DG48_Txt2 = Common.ConDBNull(DataReader["DG48_Txt2"]);
                    obj.DG49_Txt2 = Common.ConDBNull(DataReader["DG49_Txt2"]);
                    obj.DG50_Txt2 = Common.ConDBNull(DataReader["DG50_Txt2"]);
                    obj.DG51_Txt2 = Common.ConDBNull(DataReader["DG51_Txt2"]);
                    obj.DG52_Txt2 = Common.ConDBNull(DataReader["DG52_Txt2"]);
                    obj.DG53_Txt2 = Common.ConDBNull(DataReader["DG53_Txt2"]);
                    obj.DG54_Txt2 = Common.ConDBNull(DataReader["DG54_Txt2"]);
                    obj.DG55_Txt2 = Common.ConDBNull(DataReader["DG55_Txt2"]);
                    obj.DG56_Txt2 = Common.ConDBNull(DataReader["DG56_Txt2"]);
                    obj.DG57_Txt2 = Common.ConDBNull(DataReader["DG57_Txt2"]);
                    obj.DG58_Txt2 = Common.ConDBNull(DataReader["DG58_Txt2"]);
                    obj.DG59_Txt2 = Common.ConDBNull(DataReader["DG59_Txt2"]);
                    obj.DG60_Txt2 = Common.ConDBNull(DataReader["DG60_Txt2"]);
                    obj.DG61_Txt2 = Common.ConDBNull(DataReader["DG61_Txt2"]);
                    obj.DG62_Txt2 = Common.ConDBNull(DataReader["DG62_Txt2"]);
                    obj.DG63_Txt2 = Common.ConDBNull(DataReader["DG63_Txt2"]);
                    obj.DG64_Txt2 = Common.ConDBNull(DataReader["DG64_Txt2"]);
                    obj.DG65_Txt2 = Common.ConDBNull(DataReader["DG65_Txt2"]);
                    obj.DG66_Txt2 = Common.ConDBNull(DataReader["DG66_Txt2"]);
                    obj.DG67_Txt2 = Common.ConDBNull(DataReader["DG67_Txt2"]);
                    obj.DG68_Txt2 = Common.ConDBNull(DataReader["DG68_Txt2"]);
                    obj.DG69_Txt2 = Common.ConDBNull(DataReader["DG69_Txt2"]);
                    obj.DG70_Txt2 = Common.ConDBNull(DataReader["DG70_Txt2"]);
                    obj.DG71_Txt2 = Common.ConDBNull(DataReader["DG71_Txt2"]);
                    obj.KetLuan = Common.ConDBNull(DataReader["KetLuan"]);
                    obj.NguoiThucHien = Common.ConDBNull(DataReader["NguoiThucHien"]);
                    obj.MaNVNguoiThucHien = Common.ConDBNull(DataReader["MaNVNguoiThucHien"]);
                    obj.NgayTao = Common.ConDB_DateTime(DataReader["NgayTao"]);
                    obj.NguoiTao = Common.ConDBNull(DataReader["NguoiTao"]);
                    obj.NgaySua = Common.ConDB_DateTime(DataReader["NgaySua"]);
                    obj.NguoiSua = Common.ConDBNull(DataReader["NguoiSua"]);
                    obj.MaSoKy = DataReader.GetString("masokyten");
                    obj.NgayKy = DataReader.GetDate("ngayky");
                    obj.TenFileKy = DataReader.GetString("tenfileky");
                    obj.UserNameKy = DataReader.GetString("usernameky");
                    obj.DaKy = !string.IsNullOrEmpty(obj.MaSoKy) ? true : false;

                    obj.Chon = false;
                    lstObject.Add(obj);
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return lstObject;
        }

        public static bool Delete(decimal ID, MDB.MDBConnection conn)
        {
            try
            {
                string sql = "DELETE FROM PhieuDGNhanCach WHERE IDPhieu = :IDPhieu";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, conn);
                command.Parameters.Add(new MDB.MDBParameter("IDPhieu", ID));
                command.BindByName = true;
                int n = command.ExecuteNonQuery();
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static DataSet GetDataSet(decimal ID, MDB.MDBConnection conn)
        {
            try
            {
                string sql = "SELECT * FROM PhieuDGNhanCach WHERE IDPhieu = :IDPhieu";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, conn);
                command.Parameters.Add(new MDB.MDBParameter("IDPhieu", ID));
                MDB.MDBDataAdapter dataAdapter = new MDB.MDBDataAdapter(command);
                DataSet ds = new DataSet();

                dataAdapter.Fill(ds, "Table");
                ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
                ds.Tables[0].AddColumn("Tuoi", typeof(string));
                ds.Tables[0].AddColumn("SoYTe", typeof(string));
                ds.Tables[0].AddColumn("BenhVien", typeof(string));

                ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                ds.Tables[0].Rows[0]["SoYTe"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
                ds.Tables[0].Rows[0]["BenhVien"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;

                return ds;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return null;
        }
    }
}
