using EMR.KyDienTu;
using System;
using System.Collections.Generic;
using System.Data;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class KiemSoatBenhNhanTaiPhongMo : ThongTinKy
    {
        public KiemSoatBenhNhanTaiPhongMo()
        {
            TableName = "KiemSoatBenhNhanTaiPhongMo";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.KSBN;
            TenMauPhieu = DanhMucPhieu.KSBN.Description();
        }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { set; get; }
        public decimal IdKiemSoatBenhNhanTaiPhongMo { set; get; } = -1;
        [MoTaDuLieu("Chẩn đoán bệnh trước mổ")]
		public string ChanDoanTruocMo { set; get; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { set; get; }
        public DateTime NgayMo { set; get; }
        public DateTime GioMoBatDau { set; get; } 
        public DateTime GioMoKetThuc { set; get; }
        public string TruocMo_NhietDo { set; get; }
        public string TruocMo_HuyetAp{ set; get; }
        public string TruocMo_Mach { set; get; }
        public string TruocMo_NhipTho { set; get; }
        public bool[] TruocMo_TongTrang_Array { get; } = new bool[] { true, false, false };
        public int TruocMo_TongTrang { get { return Array.IndexOf(TruocMo_TongTrang_Array, true); } set { for (int i = 0; i < 3; i++) { if (i == value) TruocMo_TongTrang_Array[i] = true; else { TruocMo_TongTrang_Array[i] = false; } } } }
        public string TruocMo_TriGiacE { set; get; }
        public string TruocMo_TriGiacV { set; get; }
        public string TruocMo_TriGiacM { set; get; }

        public bool[] TruocMo_MongTayChan_Array { get; } = new bool[] { true, false };
        public int TruocMo_MongTayChan { get { return Array.IndexOf(TruocMo_MongTayChan_Array, true); } set { for (int i = 0; i < 2; i++) { if (i == value) TruocMo_MongTayChan_Array[i] = true; else { TruocMo_MongTayChan_Array[i] = false; } } } }


        public bool[] TruocMo_SacMat_Array { get; } = new bool[] { true, false };
        public int TruocMo_SacMat { get { return Array.IndexOf(TruocMo_SacMat_Array, true); } set { for (int i = 0; i < 2; i++) { if (i == value) TruocMo_SacMat_Array[i] = true; else { TruocMo_SacMat_Array[i] = false; } } } }


        public bool[] TruocMo_NiemMac_Array { get; } = new bool[] { true, false };
        public int TruocMo_NiemMac { get { return Array.IndexOf(TruocMo_NiemMac_Array, true); } set { for (int i = 0; i < 2; i++) { if (i == value) TruocMo_NiemMac_Array[i] = true; else { TruocMo_NiemMac_Array[i] = false; } } } }

        public string TruocMo_DauHieuKhac{ set; get; }
        public string TruocMo_DungCu_Gom{ set; get; }
        public string TruocMo_DungCu_GacGonBao{ set; get; }
        public string TruocMo_DungCu_KhanChamMau{ set; get; }
        public string TruocMo_DungCu_KimChiKau { set; get; }
        public string TruocMo_DungCu_DungCuKhac { set; get; }

        //sau mo
        public string SauMo_NhietDo { set; get; }
        public string SauMo_HuyetAp { set; get; }
        public string SauMo_Mach { set; get; }
        public string SauMo_NhipTho { set; get; }
        public string SauMo_AmThoPhai{ set; get; }
        public string SauMo_AmThoTrai{ set; get; }


        public bool[] SauMo_DapUngKichThich_Array { get; } = new bool[] { true, false ,false};
        public int SauMo_DapUngKichThich { get { return Array.IndexOf(SauMo_DapUngKichThich_Array, true); } set { for (int i = 0; i < 2; i++) { if (i == value) SauMo_DapUngKichThich_Array[i] = true; else { SauMo_DapUngKichThich_Array[i] = false; } } } }
        public bool[] SauMo_MongTayChan_Array { get; } = new bool[] { true, false };
        public int SauMo_MongTayChan { get { return Array.IndexOf(SauMo_MongTayChan_Array, true); } set { for (int i = 0; i < 2; i++) { if (i == value) SauMo_MongTayChan_Array[i] = true; else { SauMo_MongTayChan_Array[i] = false; } } } }
        public bool[] SauMo_SacMat_Array { get; } = new bool[] { true, false };
        public int SauMo_SacMat { get { return Array.IndexOf(SauMo_SacMat_Array, true); } set { for (int i = 0; i < 2; i++) { if (i == value) SauMo_SacMat_Array[i] = true; else { SauMo_SacMat_Array[i] = false; } } } }
        public bool[] SauMo_ChanTay_Array { get; } = new bool[] { true, false };
        public int SauMo_ChanTay { get { return Array.IndexOf(SauMo_ChanTay_Array, true); } set { for (int i = 0; i < 2; i++) { if (i == value) SauMo_ChanTay_Array[i] = true; else { SauMo_ChanTay_Array[i] = false; } } } }
        public string SauMo_VetMo{ set; get; }
        public string SauMo_DanLuu { set; get; }
        public string SauMo_DauHieuKhac { set; get; }
        public string SauMo_DungCu_Gom { set; get; }
        public string SauMo_DungCu_GacGonBao { set; get; }
        public string SauMo_DungCu_KhanChamMau { set; get; }
        public string SauMo_DungCu_KimChiKau { set; get; }
        public string SauMo_DungCu_DungCuKhac { set; get; }

        public NhanVien DieuDuongVongNgoai { set; get; }
        public NhanVien DieuDuongVongTrong { set; get; }
        public NhanVien PhauThuatVien { set; get; }
        public string DichTruyen{ set; get; }
        public string MauTruyen{ set; get; }
        public string TongNhap{ set; get; }
        [MoTaDuLieu("Nước tiểu")]
		public string NuocTieu{ set; get; }
        public string MauMat{ set; get; }
        public string TongXuat { set; get; }
        public string DichTruyenCon { set; get; }
        public string SoLuongPhim { set; get; }

        public string BanGiao_TriGiacE { set; get; }
        public string BanGiao_TriGiacV { set; get; }
        public string BanGiao_TriGiacM { set; get; }

        public string BanGiao_NhietDo { set; get; }
        public string BanGiao_HuyetAp { set; get; }
        public string BanGiao_Mach { set; get; }
        public bool ConNoiKhiQuan_hhht { set; get; }
        public string ConNoiKhiQuan_OxyQuaBKQ { set; get; }
        public string ConNoiKhiQuan_TuTho { set; get; }
        public string KhongConNoiKhiQuan_OxyQuaThong { set; get; }
        public string KhongConNoiKhiQuan_TuTho { set; get; }
        public string BanGiao_DanLuu { set; get; }
        public string BanGiao_DauHieuKhac { set; get; }
        public DateTime NgayGioBanGiao { set; get; }

        public float? CANNANG { set; get; }
        [MoTaDuLieu("Nhóm máu")]
		public string NhomMau { set; get; }

        public NhanVien NguoiGiao { set; get; }
        public NhanVien NguoiNhan { set; get; }

        public class KiemSoatBenhNhanTaiPhongMoFunc
        {
            public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref KiemSoatBenhNhanTaiPhongMo KiemSoatBenhNhanTaiPhongMo)
            {
                //phieuBieuDoChuyenDa.DaVoOi ? 1 : 0)
                string sql;
                int n;
                if (KiemSoatBenhNhanTaiPhongMo.IdKiemSoatBenhNhanTaiPhongMo == -1)
                {
                    sql = @"INSERT INTO KiemSoatBenhNhanTaiPhongMo (
                MaQuanLy,
                ChanDoanTruocMo,
		        NgayMo,
		        GioMoBatDau,
		        GioMoKetThuc,
		        TruocMo_NhietDo,
		        TruocMo_HuyetAp,
		        TruocMo_Mach,
                TruocMo_NhipTho,
		        TruocMo_TongTrang,
                TruocMo_TriGiacE,
                TruocMo_TriGiacV,
                TruocMo_TriGiacM,
                TruocMo_MongTayChan,
                TruocMo_SacMat,
                TruocMo_NiemMac,
                TruocMo_DauHieuKhac,
                TruocMo_DungCu_Gom,
                TruocMo_DungCu_GacGonBao ,
                TruocMo_DungCu_KhanChamMau ,
                TruocMo_DungCu_KimChiKau, 
                TruocMo_DungCu_DungCuKhac, 
                SauMo_NhietDo, 
                SauMo_HuyetAp, 
                SauMo_Mach, 
                SauMo_NhipTho, 
                SauMo_AmThoPhai, 
                SauMo_AmThoTrai, 
                SauMo_DapUngKichThich, 
                SauMo_MongTayChan, 
                SauMo_SacMat, 
                SauMo_ChanTay, 
                SauMo_VetMo, 
                SauMo_DanLuu, 
                SauMo_DauHieuKhac, 
                SauMo_DungCu_Gom, 
                SauMo_DungCu_GacGonBao, 
                SauMo_DungCu_KhanChamMau, 
                SauMo_DungCu_KimChiKau, 
                SauMo_DungCu_DungCuKhac, 
                DieuDuongVongNgoai, 
                DieuDuongVongTrong, 
                PhauThuatVien, 
                DichTruyen, 
                MauTruyen, 
                TongNhap, 
                NuocTieu, 
                MauMat, 
                TongXuat, 
                DichTruyenCon, 
                SoLuongPhim, 
                BanGiao_TriGiacE, 
                BanGiao_TriGiacV, 
                BanGiao_TriGiacM, 
                BanGiao_NhietDo, 
                BanGiao_HuyetAp, 
                BanGiao_Mach, 
                ConNoiKhiQuan_hhht, 
                ConNoiKhiQuan_OxyQuaBKQ, 
                ConNoiKhiQuan_TuTho, 
                KhongConNoiKhiQuan_OxyQuaThong, 
                KhongConNoiKhiQuan_TuTho, 
                BanGiao_DanLuu, 
                BanGiao_DauHieuKhac, 
                NgayGioBanGiao, 
                NguoiGiao, 
                NguoiNhan,
                CANNANG,
                NhomMau
                )
                VALUES
	                    (
                    :MaQuanLy,
                    :ChanDoanTruocMo,
		            :NgayMo,
                    :GioMoBatDau,
                    :GioMoKetThuc,
                    :TruocMo_NhietDo,
                    :TruocMo_HuyetAp,
                    :TruocMo_Mach,
                    :TruocMo_NhipTho,
                    :TruocMo_TongTrang,
                    :TruocMo_TriGiacE,
                    :TruocMo_TriGiacV,
                    :TruocMo_TriGiacM,
                    :TruocMo_MongTayChan,
                    :TruocMo_SacMat,
                    :TruocMo_NiemMac ,
                    :TruocMo_DauHieuKhac ,
                    :TruocMo_DungCu_Gom ,
                    :TruocMo_DungCu_GacGonBao ,
                    :TruocMo_DungCu_KhanChamMau ,
                    :TruocMo_DungCu_KimChiKau, 
                    :TruocMo_DungCu_DungCuKhac, 
                    :SauMo_NhietDo, 
                    :SauMo_HuyetAp, 
                    :SauMo_Mach, 
                    :SauMo_NhipTho, 
                    :SauMo_AmThoPhai, 
                    :SauMo_AmThoTrai, 
                    :SauMo_DapUngKichThich, 
                    :SauMo_MongTayChan, 
                    :SauMo_SacMat, 
                    :SauMo_ChanTay, 
                    :SauMo_VetMo, 
                    :SauMo_DanLuu, 
                    :SauMo_DauHieuKhac, 
                    :SauMo_DungCu_Gom, 
                    :SauMo_DungCu_GacGonBao, 
                    :SauMo_DungCu_KhanChamMau, 
                    :SauMo_DungCu_KimChiKau, 
                    :SauMo_DungCu_DungCuKhac, 
                    :DieuDuongVongNgoai, 
                    :DieuDuongVongTrong, 
                    :PhauThuatVien, 
                    :DichTruyen, 
                    :MauTruyen, 
                    :TongNhap, 
                    :NuocTieu, 
                    :MauMat, 
                    :TongXuat, 
                    :DichTruyenCon, 
                    :SoLuongPhim, 
                    :BanGiao_TriGiacE, 
                    :BanGiao_TriGiacV, 
                    :BanGiao_TriGiacM, 
                    :BanGiao_NhietDo, 
                    :BanGiao_HuyetAp, 
                    :BanGiao_Mach, 
                    :ConNoiKhiQuan_hhht, 
                    :ConNoiKhiQuan_OxyQuaBKQ, 
                    :ConNoiKhiQuan_TuTho, 
                    :KhongConNoiKhiQuan_OxyQuaThong, 
                    :KhongConNoiKhiQuan_TuTho, 
                    :BanGiao_DanLuu, 
                    :BanGiao_DauHieuKhac, 
                    :NgayGioBanGiao, 
                    :NguoiGiao, 
                    :NguoiNhan,
                    :CANNANG,
                    :NhomMau)
                    RETURNING IdKiemSoatBenhNhanTaiPhongMo INTO :IdKiemSoatBenhNhanTaiPhongMo";
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", KiemSoatBenhNhanTaiPhongMo.MaQuanLy));
                    Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTruocMo", KiemSoatBenhNhanTaiPhongMo.ChanDoanTruocMo));
                    Command.Parameters.Add(new MDB.MDBParameter("NgayMo", KiemSoatBenhNhanTaiPhongMo.NgayMo));
                    Command.Parameters.Add(new MDB.MDBParameter("GioMoBatDau", KiemSoatBenhNhanTaiPhongMo.GioMoBatDau));
                    Command.Parameters.Add(new MDB.MDBParameter("GioMoKetThuc", KiemSoatBenhNhanTaiPhongMo.GioMoKetThuc));
                    Command.Parameters.Add(new MDB.MDBParameter("TruocMo_NhietDo", KiemSoatBenhNhanTaiPhongMo.TruocMo_NhietDo));
                    Command.Parameters.Add(new MDB.MDBParameter("TruocMo_HuyetAp", KiemSoatBenhNhanTaiPhongMo.TruocMo_HuyetAp));
                    Command.Parameters.Add(new MDB.MDBParameter("TruocMo_Mach", KiemSoatBenhNhanTaiPhongMo.TruocMo_Mach));
                    Command.Parameters.Add(new MDB.MDBParameter("TruocMo_NhipTho", KiemSoatBenhNhanTaiPhongMo.TruocMo_NhipTho));
                    Command.Parameters.Add(new MDB.MDBParameter("TruocMo_TongTrang", KiemSoatBenhNhanTaiPhongMo.TruocMo_TongTrang));
                    Command.Parameters.Add(new MDB.MDBParameter("TruocMo_TriGiacE", KiemSoatBenhNhanTaiPhongMo.TruocMo_TriGiacE));
                    Command.Parameters.Add(new MDB.MDBParameter("TruocMo_TriGiacV", KiemSoatBenhNhanTaiPhongMo.TruocMo_TriGiacV));
                    Command.Parameters.Add(new MDB.MDBParameter("TruocMo_TriGiacM", KiemSoatBenhNhanTaiPhongMo.TruocMo_TriGiacM));
                    Command.Parameters.Add(new MDB.MDBParameter("TruocMo_MongTayChan", KiemSoatBenhNhanTaiPhongMo.TruocMo_MongTayChan));
                    Command.Parameters.Add(new MDB.MDBParameter("TruocMo_SacMat", KiemSoatBenhNhanTaiPhongMo.TruocMo_SacMat));
                    Command.Parameters.Add(new MDB.MDBParameter("TruocMo_NiemMac", KiemSoatBenhNhanTaiPhongMo.TruocMo_NiemMac));
                    Command.Parameters.Add(new MDB.MDBParameter("TruocMo_DauHieuKhac", KiemSoatBenhNhanTaiPhongMo.TruocMo_DauHieuKhac));
                    Command.Parameters.Add(new MDB.MDBParameter("TruocMo_DungCu_Gom", KiemSoatBenhNhanTaiPhongMo.TruocMo_DungCu_Gom));
                    Command.Parameters.Add(new MDB.MDBParameter("TruocMo_DungCu_GacGonBao", KiemSoatBenhNhanTaiPhongMo.TruocMo_DungCu_GacGonBao));
                    Command.Parameters.Add(new MDB.MDBParameter("TruocMo_DungCu_KhanChamMau", KiemSoatBenhNhanTaiPhongMo.TruocMo_DungCu_KhanChamMau));
                    Command.Parameters.Add(new MDB.MDBParameter("TruocMo_DungCu_KimChiKau", KiemSoatBenhNhanTaiPhongMo.TruocMo_DungCu_KimChiKau));                  
                    Command.Parameters.Add(new MDB.MDBParameter("TruocMo_DungCu_DungCuKhac", KiemSoatBenhNhanTaiPhongMo.TruocMo_DungCu_DungCuKhac));                   
                    Command.Parameters.Add(new MDB.MDBParameter("SauMo_NhietDo", KiemSoatBenhNhanTaiPhongMo.SauMo_NhietDo));                   
                    Command.Parameters.Add(new MDB.MDBParameter("SauMo_HuyetAp", KiemSoatBenhNhanTaiPhongMo.SauMo_HuyetAp));                   
                    Command.Parameters.Add(new MDB.MDBParameter("SauMo_Mach", KiemSoatBenhNhanTaiPhongMo.SauMo_Mach));                  
                    Command.Parameters.Add(new MDB.MDBParameter("SauMo_NhipTho", KiemSoatBenhNhanTaiPhongMo.SauMo_NhipTho));
                    Command.Parameters.Add(new MDB.MDBParameter("SauMo_AmThoPhai", KiemSoatBenhNhanTaiPhongMo.SauMo_AmThoPhai));
                    Command.Parameters.Add(new MDB.MDBParameter("SauMo_AmThoTrai", KiemSoatBenhNhanTaiPhongMo.SauMo_AmThoTrai));
                    Command.Parameters.Add(new MDB.MDBParameter("SauMo_DapUngKichThich", KiemSoatBenhNhanTaiPhongMo.SauMo_DapUngKichThich));
                    Command.Parameters.Add(new MDB.MDBParameter("SauMo_MongTayChan", KiemSoatBenhNhanTaiPhongMo.SauMo_MongTayChan));
                    Command.Parameters.Add(new MDB.MDBParameter("SauMo_SacMat", KiemSoatBenhNhanTaiPhongMo.SauMo_SacMat));
                    Command.Parameters.Add(new MDB.MDBParameter("SauMo_ChanTay", KiemSoatBenhNhanTaiPhongMo.SauMo_ChanTay));
                    Command.Parameters.Add(new MDB.MDBParameter("SauMo_VetMo", KiemSoatBenhNhanTaiPhongMo.SauMo_VetMo));
                    Command.Parameters.Add(new MDB.MDBParameter("SauMo_DanLuu", KiemSoatBenhNhanTaiPhongMo.SauMo_DanLuu));
                    Command.Parameters.Add(new MDB.MDBParameter("SauMo_DauHieuKhac", KiemSoatBenhNhanTaiPhongMo.SauMo_DauHieuKhac));
                    Command.Parameters.Add(new MDB.MDBParameter("SauMo_DungCu_Gom", KiemSoatBenhNhanTaiPhongMo.SauMo_DungCu_Gom));
                    Command.Parameters.Add(new MDB.MDBParameter("SauMo_DungCu_GacGonBao", KiemSoatBenhNhanTaiPhongMo.SauMo_DungCu_GacGonBao));
                    Command.Parameters.Add(new MDB.MDBParameter("SauMo_DungCu_KhanChamMau", KiemSoatBenhNhanTaiPhongMo.SauMo_DungCu_KhanChamMau));
                    Command.Parameters.Add(new MDB.MDBParameter("SauMo_DungCu_KimChiKau", KiemSoatBenhNhanTaiPhongMo.SauMo_DungCu_KimChiKau));
                    Command.Parameters.Add(new MDB.MDBParameter("SauMo_DungCu_DungCuKhac", KiemSoatBenhNhanTaiPhongMo.SauMo_DungCu_DungCuKhac));
                    Command.Parameters.Add(new MDB.MDBParameter("DieuDuongVongNgoai", KiemSoatBenhNhanTaiPhongMo.DieuDuongVongNgoai != null ? KiemSoatBenhNhanTaiPhongMo.DieuDuongVongNgoai.IdNhanVien :0));
                    Command.Parameters.Add(new MDB.MDBParameter("DieuDuongVongTrong", KiemSoatBenhNhanTaiPhongMo.DieuDuongVongTrong != null ? KiemSoatBenhNhanTaiPhongMo.DieuDuongVongTrong.IdNhanVien:0));
                    Command.Parameters.Add(new MDB.MDBParameter("PhauThuatVien", KiemSoatBenhNhanTaiPhongMo.PhauThuatVien != null ? KiemSoatBenhNhanTaiPhongMo.PhauThuatVien.IdNhanVien : 0));
                    Command.Parameters.Add(new MDB.MDBParameter("DichTruyen", KiemSoatBenhNhanTaiPhongMo.DichTruyen));
                    Command.Parameters.Add(new MDB.MDBParameter("MauTruyen", KiemSoatBenhNhanTaiPhongMo.MauTruyen));
                    Command.Parameters.Add(new MDB.MDBParameter("TongNhap", KiemSoatBenhNhanTaiPhongMo.TongNhap));
                    Command.Parameters.Add(new MDB.MDBParameter("NuocTieu", KiemSoatBenhNhanTaiPhongMo.NuocTieu));
                    Command.Parameters.Add(new MDB.MDBParameter("MauMat", KiemSoatBenhNhanTaiPhongMo.MauMat));
                    Command.Parameters.Add(new MDB.MDBParameter("TongXuat", KiemSoatBenhNhanTaiPhongMo.TongXuat));
                    Command.Parameters.Add(new MDB.MDBParameter("DichTruyenCon", KiemSoatBenhNhanTaiPhongMo.DichTruyenCon));
                    Command.Parameters.Add(new MDB.MDBParameter("SoLuongPhim", KiemSoatBenhNhanTaiPhongMo.SoLuongPhim));
                    Command.Parameters.Add(new MDB.MDBParameter("BanGiao_TriGiacE", KiemSoatBenhNhanTaiPhongMo.BanGiao_TriGiacE));
                    Command.Parameters.Add(new MDB.MDBParameter("BanGiao_TriGiacV", KiemSoatBenhNhanTaiPhongMo.BanGiao_TriGiacV));
                    Command.Parameters.Add(new MDB.MDBParameter("BanGiao_TriGiacM", KiemSoatBenhNhanTaiPhongMo.BanGiao_TriGiacM));
                    Command.Parameters.Add(new MDB.MDBParameter("BanGiao_NhietDo", KiemSoatBenhNhanTaiPhongMo.BanGiao_NhietDo));
                    Command.Parameters.Add(new MDB.MDBParameter("BanGiao_HuyetAp", KiemSoatBenhNhanTaiPhongMo.BanGiao_HuyetAp));
                    Command.Parameters.Add(new MDB.MDBParameter("BanGiao_Mach", KiemSoatBenhNhanTaiPhongMo.BanGiao_Mach));
                    Command.Parameters.Add(new MDB.MDBParameter("ConNoiKhiQuan_hhht", KiemSoatBenhNhanTaiPhongMo.ConNoiKhiQuan_hhht ? 1 : 0));
                    Command.Parameters.Add(new MDB.MDBParameter("ConNoiKhiQuan_OxyQuaBKQ", KiemSoatBenhNhanTaiPhongMo.ConNoiKhiQuan_OxyQuaBKQ));
                    Command.Parameters.Add(new MDB.MDBParameter("ConNoiKhiQuan_TuTho", KiemSoatBenhNhanTaiPhongMo.ConNoiKhiQuan_TuTho));
                    Command.Parameters.Add(new MDB.MDBParameter("KhongConNoiKhiQuan_OxyQuaThong", KiemSoatBenhNhanTaiPhongMo.KhongConNoiKhiQuan_OxyQuaThong));
                    Command.Parameters.Add(new MDB.MDBParameter("KhongConNoiKhiQuan_TuTho", KiemSoatBenhNhanTaiPhongMo.KhongConNoiKhiQuan_TuTho));
                    Command.Parameters.Add(new MDB.MDBParameter("BanGiao_DanLuu", KiemSoatBenhNhanTaiPhongMo.BanGiao_DanLuu));
                    Command.Parameters.Add(new MDB.MDBParameter("BanGiao_DauHieuKhac", KiemSoatBenhNhanTaiPhongMo.BanGiao_DauHieuKhac));
                    Command.Parameters.Add(new MDB.MDBParameter("NgayGioBanGiao", KiemSoatBenhNhanTaiPhongMo.NgayGioBanGiao));
                    Command.Parameters.Add(new MDB.MDBParameter("NguoiGiao", KiemSoatBenhNhanTaiPhongMo.NguoiGiao != null ? KiemSoatBenhNhanTaiPhongMo.NguoiGiao.IdNhanVien : 0));
                    Command.Parameters.Add(new MDB.MDBParameter("NguoiNhan", KiemSoatBenhNhanTaiPhongMo.NguoiNhan != null ? KiemSoatBenhNhanTaiPhongMo.NguoiNhan.IdNhanVien : 0));
                    Command.Parameters.Add(new MDB.MDBParameter("IdKiemSoatBenhNhanTaiPhongMo", KiemSoatBenhNhanTaiPhongMo.IdKiemSoatBenhNhanTaiPhongMo));
                    Command.Parameters.Add(new MDB.MDBParameter("CANNANG", KiemSoatBenhNhanTaiPhongMo.CANNANG));
                    Command.Parameters.Add(new MDB.MDBParameter("NhomMau", KiemSoatBenhNhanTaiPhongMo.NhomMau));


                  
                    Command.BindByName = true;
                    n = Command.ExecuteNonQuery();
                    decimal nextval = Convert.ToInt64((Command.Parameters["IdKiemSoatBenhNhanTaiPhongMo"] as MDB.MDBParameter).Value);
                    KiemSoatBenhNhanTaiPhongMo.IdKiemSoatBenhNhanTaiPhongMo = nextval;

                }

                else
                {
                    sql = @"UPDATE KiemSoatBenhNhanTaiPhongMo SET
                                NgayMo = :NgayMo,
                                ChanDoanTruocMo = :ChanDoanTruocMo,
                                GioMoBatDau = :GioMoBatDau,
                                GioMoKetThuc = :GioMoKetThuc,
                                TruocMo_NhietDo = :TruocMo_NhietDo,
                                TruocMo_HuyetAp = :TruocMo_HuyetAp,
                                TruocMo_Mach = :TruocMo_Mach,
                                TruocMo_NhipTho = :TruocMo_NhipTho,
                                TruocMo_TongTrang = :TruocMo_TongTrang,
                                TruocMo_TriGiacE = :TruocMo_TriGiacE,
                                TruocMo_TriGiacV = :TruocMo_TriGiacV,
                                TruocMo_TriGiacM = :TruocMo_TriGiacM,
                                TruocMo_MongTayChan = :TruocMo_MongTayChan,
                                TruocMo_SacMat = :TruocMo_SacMat,
                                TruocMo_NiemMac  = :TruocMo_NiemMac ,
                                TruocMo_DauHieuKhac  = :TruocMo_DauHieuKhac ,
                                TruocMo_DungCu_Gom  = :TruocMo_DungCu_Gom ,
                                TruocMo_DungCu_GacGonBao  = :TruocMo_DungCu_GacGonBao ,
                                TruocMo_DungCu_KhanChamMau  = :TruocMo_DungCu_KhanChamMau ,
                                TruocMo_DungCu_KimChiKau = :TruocMo_DungCu_KimChiKau,
                                TruocMo_DungCu_DungCuKhac = :TruocMo_DungCu_DungCuKhac,
                                SauMo_NhietDo = :SauMo_NhietDo,
                                SauMo_HuyetAp = :SauMo_HuyetAp,
                                SauMo_Mach = :SauMo_Mach,
                                SauMo_NhipTho = :SauMo_NhipTho,
                                SauMo_AmThoPhai = :SauMo_AmThoPhai,
                                SauMo_AmThoTrai = :SauMo_AmThoTrai,
                                SauMo_DapUngKichThich = :SauMo_DapUngKichThich,
                                SauMo_MongTayChan = :SauMo_MongTayChan,
                                SauMo_SacMat = :SauMo_SacMat,
                                SauMo_ChanTay = :SauMo_ChanTay,
                                SauMo_VetMo = :SauMo_VetMo,
                                SauMo_DanLuu = :SauMo_DanLuu,
                                SauMo_DauHieuKhac = :SauMo_DauHieuKhac,
                                SauMo_DungCu_Gom = :SauMo_DungCu_Gom,
                                SauMo_DungCu_GacGonBao = :SauMo_DungCu_GacGonBao,
                                SauMo_DungCu_KhanChamMau = :SauMo_DungCu_KhanChamMau,
                                SauMo_DungCu_KimChiKau = :SauMo_DungCu_KimChiKau,
                                SauMo_DungCu_DungCuKhac = :SauMo_DungCu_DungCuKhac,
                                DieuDuongVongNgoai = :DieuDuongVongNgoai,
                                DieuDuongVongTrong = :DieuDuongVongTrong,
                                PhauThuatVien = :PhauThuatVien,
                                DichTruyen = :DichTruyen,
                                MauTruyen = :MauTruyen,
                                TongNhap = :TongNhap,
                                NuocTieu = :NuocTieu,
                                MauMat = :MauMat,
                                TongXuat = :TongXuat,
                                DichTruyenCon = :DichTruyenCon,
                                SoLuongPhim = :SoLuongPhim,
                                BanGiao_TriGiacE = :BanGiao_TriGiacE,
                                BanGiao_TriGiacV = :BanGiao_TriGiacV,
                                BanGiao_TriGiacM = :BanGiao_TriGiacM,
                                BanGiao_NhietDo = :BanGiao_NhietDo,
                                BanGiao_HuyetAp = :BanGiao_HuyetAp,
                                BanGiao_Mach = :BanGiao_Mach,
                                ConNoiKhiQuan_hhht = :ConNoiKhiQuan_hhht,
                                ConNoiKhiQuan_OxyQuaBKQ = :ConNoiKhiQuan_OxyQuaBKQ,
                                ConNoiKhiQuan_TuTho = :ConNoiKhiQuan_TuTho,
                                KhongConNoiKhiQuan_OxyQuaThong = :KhongConNoiKhiQuan_OxyQuaThong,
                                KhongConNoiKhiQuan_TuTho = :KhongConNoiKhiQuan_TuTho,
                                BanGiao_DanLuu = :BanGiao_DanLuu,
                                BanGiao_DauHieuKhac = :BanGiao_DauHieuKhac,
                                NgayGioBanGiao = :NgayGioBanGiao,
                                NguoiGiao = :NguoiGiao,
                                NguoiNhan = :NguoiNhan,
                                CANNANG = :CANNANG,
                                NhomMau = :NhomMau
                                WHERE IdKiemSoatBenhNhanTaiPhongMo = :IdKiemSoatBenhNhanTaiPhongMo";
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter("NgayMo", KiemSoatBenhNhanTaiPhongMo.NgayMo));
                    Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTruocMo", KiemSoatBenhNhanTaiPhongMo.ChanDoanTruocMo));
                    Command.Parameters.Add(new MDB.MDBParameter("GioMoBatDau", KiemSoatBenhNhanTaiPhongMo.GioMoBatDau));
                    Command.Parameters.Add(new MDB.MDBParameter("GioMoKetThuc", KiemSoatBenhNhanTaiPhongMo.GioMoKetThuc));
                    Command.Parameters.Add(new MDB.MDBParameter("TruocMo_NhietDo", KiemSoatBenhNhanTaiPhongMo.TruocMo_NhietDo));
                    Command.Parameters.Add(new MDB.MDBParameter("TruocMo_HuyetAp", KiemSoatBenhNhanTaiPhongMo.TruocMo_HuyetAp));
                    Command.Parameters.Add(new MDB.MDBParameter("TruocMo_Mach", KiemSoatBenhNhanTaiPhongMo.TruocMo_Mach));
                    Command.Parameters.Add(new MDB.MDBParameter("TruocMo_NhipTho", KiemSoatBenhNhanTaiPhongMo.TruocMo_NhipTho));
                    Command.Parameters.Add(new MDB.MDBParameter("TruocMo_TongTrang", KiemSoatBenhNhanTaiPhongMo.TruocMo_TongTrang));
                    Command.Parameters.Add(new MDB.MDBParameter("TruocMo_TriGiacE", KiemSoatBenhNhanTaiPhongMo.TruocMo_TriGiacE));
                    Command.Parameters.Add(new MDB.MDBParameter("TruocMo_TriGiacV", KiemSoatBenhNhanTaiPhongMo.TruocMo_TriGiacV));
                    Command.Parameters.Add(new MDB.MDBParameter("TruocMo_TriGiacM", KiemSoatBenhNhanTaiPhongMo.TruocMo_TriGiacM));
                    Command.Parameters.Add(new MDB.MDBParameter("TruocMo_MongTayChan", KiemSoatBenhNhanTaiPhongMo.TruocMo_MongTayChan));
                    Command.Parameters.Add(new MDB.MDBParameter("TruocMo_SacMat", KiemSoatBenhNhanTaiPhongMo.TruocMo_SacMat));
                    Command.Parameters.Add(new MDB.MDBParameter("TruocMo_NiemMac", KiemSoatBenhNhanTaiPhongMo.TruocMo_NiemMac));
                    Command.Parameters.Add(new MDB.MDBParameter("TruocMo_DauHieuKhac", KiemSoatBenhNhanTaiPhongMo.TruocMo_DauHieuKhac));
                    Command.Parameters.Add(new MDB.MDBParameter("TruocMo_DungCu_Gom", KiemSoatBenhNhanTaiPhongMo.TruocMo_DungCu_Gom));
                    Command.Parameters.Add(new MDB.MDBParameter("TruocMo_DungCu_GacGonBao", KiemSoatBenhNhanTaiPhongMo.TruocMo_DungCu_GacGonBao));
                    Command.Parameters.Add(new MDB.MDBParameter("TruocMo_DungCu_KhanChamMau", KiemSoatBenhNhanTaiPhongMo.TruocMo_DungCu_KhanChamMau));
                    Command.Parameters.Add(new MDB.MDBParameter("TruocMo_DungCu_KimChiKau", KiemSoatBenhNhanTaiPhongMo.TruocMo_DungCu_KimChiKau));
                    Command.Parameters.Add(new MDB.MDBParameter("TruocMo_DungCu_DungCuKhac", KiemSoatBenhNhanTaiPhongMo.TruocMo_DungCu_DungCuKhac));
                    Command.Parameters.Add(new MDB.MDBParameter("SauMo_NhietDo", KiemSoatBenhNhanTaiPhongMo.SauMo_NhietDo));
                    Command.Parameters.Add(new MDB.MDBParameter("SauMo_HuyetAp", KiemSoatBenhNhanTaiPhongMo.SauMo_HuyetAp));
                    Command.Parameters.Add(new MDB.MDBParameter("SauMo_Mach", KiemSoatBenhNhanTaiPhongMo.SauMo_Mach));
                    Command.Parameters.Add(new MDB.MDBParameter("SauMo_NhipTho", KiemSoatBenhNhanTaiPhongMo.SauMo_NhipTho));
                    Command.Parameters.Add(new MDB.MDBParameter("SauMo_AmThoPhai", KiemSoatBenhNhanTaiPhongMo.SauMo_AmThoPhai));
                    Command.Parameters.Add(new MDB.MDBParameter("SauMo_AmThoTrai", KiemSoatBenhNhanTaiPhongMo.SauMo_AmThoTrai));
                    Command.Parameters.Add(new MDB.MDBParameter("SauMo_DapUngKichThich", KiemSoatBenhNhanTaiPhongMo.SauMo_DapUngKichThich));
                    Command.Parameters.Add(new MDB.MDBParameter("SauMo_MongTayChan", KiemSoatBenhNhanTaiPhongMo.SauMo_MongTayChan));
                    Command.Parameters.Add(new MDB.MDBParameter("SauMo_SacMat", KiemSoatBenhNhanTaiPhongMo.SauMo_SacMat));
                    Command.Parameters.Add(new MDB.MDBParameter("SauMo_ChanTay", KiemSoatBenhNhanTaiPhongMo.SauMo_ChanTay));
                    Command.Parameters.Add(new MDB.MDBParameter("SauMo_VetMo", KiemSoatBenhNhanTaiPhongMo.SauMo_VetMo));
                    Command.Parameters.Add(new MDB.MDBParameter("SauMo_DanLuu", KiemSoatBenhNhanTaiPhongMo.SauMo_DanLuu));
                    Command.Parameters.Add(new MDB.MDBParameter("SauMo_DauHieuKhac", KiemSoatBenhNhanTaiPhongMo.SauMo_DauHieuKhac));
                    Command.Parameters.Add(new MDB.MDBParameter("SauMo_DungCu_Gom", KiemSoatBenhNhanTaiPhongMo.SauMo_DungCu_Gom));
                    Command.Parameters.Add(new MDB.MDBParameter("SauMo_DungCu_GacGonBao", KiemSoatBenhNhanTaiPhongMo.SauMo_DungCu_GacGonBao));
                    Command.Parameters.Add(new MDB.MDBParameter("SauMo_DungCu_KhanChamMau", KiemSoatBenhNhanTaiPhongMo.SauMo_DungCu_KhanChamMau));
                    Command.Parameters.Add(new MDB.MDBParameter("SauMo_DungCu_KimChiKau", KiemSoatBenhNhanTaiPhongMo.SauMo_DungCu_KimChiKau));
                    Command.Parameters.Add(new MDB.MDBParameter("SauMo_DungCu_DungCuKhac", KiemSoatBenhNhanTaiPhongMo.SauMo_DungCu_DungCuKhac));
                    Command.Parameters.Add(new MDB.MDBParameter("DieuDuongVongNgoai", KiemSoatBenhNhanTaiPhongMo.DieuDuongVongNgoai != null ? KiemSoatBenhNhanTaiPhongMo.DieuDuongVongNgoai.IdNhanVien:0));
                    Command.Parameters.Add(new MDB.MDBParameter("DieuDuongVongTrong", KiemSoatBenhNhanTaiPhongMo.DieuDuongVongTrong != null ? KiemSoatBenhNhanTaiPhongMo.DieuDuongVongTrong.IdNhanVien:0));
                    Command.Parameters.Add(new MDB.MDBParameter("PhauThuatVien", KiemSoatBenhNhanTaiPhongMo.PhauThuatVien != null ? KiemSoatBenhNhanTaiPhongMo.PhauThuatVien.IdNhanVien:0));
                    Command.Parameters.Add(new MDB.MDBParameter("DichTruyen", KiemSoatBenhNhanTaiPhongMo.DichTruyen));
                    Command.Parameters.Add(new MDB.MDBParameter("MauTruyen", KiemSoatBenhNhanTaiPhongMo.MauTruyen));
                    Command.Parameters.Add(new MDB.MDBParameter("TongNhap", KiemSoatBenhNhanTaiPhongMo.TongNhap));
                    Command.Parameters.Add(new MDB.MDBParameter("NuocTieu", KiemSoatBenhNhanTaiPhongMo.NuocTieu));
                    Command.Parameters.Add(new MDB.MDBParameter("MauMat", KiemSoatBenhNhanTaiPhongMo.MauMat));
                    Command.Parameters.Add(new MDB.MDBParameter("TongXuat", KiemSoatBenhNhanTaiPhongMo.TongXuat));
                    Command.Parameters.Add(new MDB.MDBParameter("DichTruyenCon", KiemSoatBenhNhanTaiPhongMo.DichTruyenCon));
                    Command.Parameters.Add(new MDB.MDBParameter("SoLuongPhim", KiemSoatBenhNhanTaiPhongMo.SoLuongPhim));
                    Command.Parameters.Add(new MDB.MDBParameter("BanGiao_TriGiacE", KiemSoatBenhNhanTaiPhongMo.BanGiao_TriGiacE));
                    Command.Parameters.Add(new MDB.MDBParameter("BanGiao_TriGiacV", KiemSoatBenhNhanTaiPhongMo.BanGiao_TriGiacV));
                    Command.Parameters.Add(new MDB.MDBParameter("BanGiao_TriGiacM", KiemSoatBenhNhanTaiPhongMo.BanGiao_TriGiacM));
                    Command.Parameters.Add(new MDB.MDBParameter("BanGiao_NhietDo", KiemSoatBenhNhanTaiPhongMo.BanGiao_NhietDo));
                    Command.Parameters.Add(new MDB.MDBParameter("BanGiao_HuyetAp", KiemSoatBenhNhanTaiPhongMo.BanGiao_HuyetAp));
                    Command.Parameters.Add(new MDB.MDBParameter("BanGiao_Mach", KiemSoatBenhNhanTaiPhongMo.BanGiao_Mach));
                    Command.Parameters.Add(new MDB.MDBParameter("ConNoiKhiQuan_hhht", KiemSoatBenhNhanTaiPhongMo.ConNoiKhiQuan_hhht ? 1 : 0));
                    Command.Parameters.Add(new MDB.MDBParameter("ConNoiKhiQuan_OxyQuaBKQ", KiemSoatBenhNhanTaiPhongMo.ConNoiKhiQuan_OxyQuaBKQ));
                    Command.Parameters.Add(new MDB.MDBParameter("ConNoiKhiQuan_TuTho", KiemSoatBenhNhanTaiPhongMo.ConNoiKhiQuan_TuTho));
                    Command.Parameters.Add(new MDB.MDBParameter("KhongConNoiKhiQuan_OxyQuaThong", KiemSoatBenhNhanTaiPhongMo.KhongConNoiKhiQuan_OxyQuaThong));
                    Command.Parameters.Add(new MDB.MDBParameter("KhongConNoiKhiQuan_TuTho", KiemSoatBenhNhanTaiPhongMo.KhongConNoiKhiQuan_TuTho));
                    Command.Parameters.Add(new MDB.MDBParameter("BanGiao_DanLuu", KiemSoatBenhNhanTaiPhongMo.BanGiao_DanLuu));
                    Command.Parameters.Add(new MDB.MDBParameter("BanGiao_DauHieuKhac", KiemSoatBenhNhanTaiPhongMo.BanGiao_DauHieuKhac));
                    Command.Parameters.Add(new MDB.MDBParameter("NgayGioBanGiao", KiemSoatBenhNhanTaiPhongMo.NgayGioBanGiao));
                    Command.Parameters.Add(new MDB.MDBParameter("NguoiGiao", KiemSoatBenhNhanTaiPhongMo.NguoiGiao != null ? KiemSoatBenhNhanTaiPhongMo.NguoiGiao.IdNhanVien:0));
                    Command.Parameters.Add(new MDB.MDBParameter("NguoiNhan", KiemSoatBenhNhanTaiPhongMo.NguoiNhan != null ? KiemSoatBenhNhanTaiPhongMo.NguoiNhan.IdNhanVien:0));
                    Command.Parameters.Add(new MDB.MDBParameter("IdKiemSoatBenhNhanTaiPhongMo", KiemSoatBenhNhanTaiPhongMo.IdKiemSoatBenhNhanTaiPhongMo));
                    Command.Parameters.Add(new MDB.MDBParameter("CANNANG", KiemSoatBenhNhanTaiPhongMo.CANNANG));
                    Command.Parameters.Add(new MDB.MDBParameter("NhomMau", KiemSoatBenhNhanTaiPhongMo.NhomMau));
                    Command.BindByName = true;
                    n = Command.ExecuteNonQuery();

                }


                return n > 0 ? true : false;
            }

            public static bool Delete(MDB.MDBConnection MyConnection, decimal IdKiemSoatBenhNhanTaiPhongMo)
            {
                string sql ="DELETE FROM KiemSoatBenhNhanTaiPhongMo WHERE IdKiemSoatBenhNhanTaiPhongMo = :IdKiemSoatBenhNhanTaiPhongMo";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                command.Parameters.Add(new MDB.MDBParameter("IdKiemSoatBenhNhanTaiPhongMo", IdKiemSoatBenhNhanTaiPhongMo));
                command.BindByName = true;
                int n = command.ExecuteNonQuery();
                return n > 0 ? true : false;
            }

            public static List<KiemSoatBenhNhanTaiPhongMo> GetListKiemSoat(MDB.MDBConnection _OracleConnection, decimal maquanly)
            {
                List<KiemSoatBenhNhanTaiPhongMo> list = new List<KiemSoatBenhNhanTaiPhongMo>();
                try
                {

                    string sql = @"SELECT * FROM KiemSoatBenhNhanTaiPhongMo where MaQuanLy = :MaQuanLy";
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                    Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                    MDB.MDBDataReader DataReader = Command.ExecuteReader();
                    while (DataReader.Read())
                    {
                        KiemSoatBenhNhanTaiPhongMo data = new KiemSoatBenhNhanTaiPhongMo();
                        data.IdKiemSoatBenhNhanTaiPhongMo = Convert.ToInt64(DataReader.GetLong("IdKiemSoatBenhNhanTaiPhongMo").ToString());
                        data.NgayMo = Convert.ToDateTime(DataReader["NgayMo"] == DBNull.Value ? DateTime.Now : DataReader["NgayMo"]);
                        data.GioMoBatDau = Convert.ToDateTime(DataReader["GioMoBatDau"] == DBNull.Value ? DateTime.Now : DataReader["GioMoBatDau"]);
                        data.GioMoKetThuc = Convert.ToDateTime(DataReader["GioMoKetThuc"] == DBNull.Value ? DateTime.Now : DataReader["GioMoKetThuc"]);

                        list.Add(data);
                    }
                }
                catch (Exception ex) { XuLyLoi.Handle(ex); }
                return list;
            }

            public static KiemSoatBenhNhanTaiPhongMo GetData(MDB.MDBConnection _OracleConnection, decimal id)
            {
                try
                {
                    string sql = @"SELECT * FROM KiemSoatBenhNhanTaiPhongMo where IdKiemSoatBenhNhanTaiPhongMo = :IdKiemSoatBenhNhanTaiPhongMo";
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                    Command.Parameters.Add(new MDB.MDBParameter("IdKiemSoatBenhNhanTaiPhongMo", id));
                    MDB.MDBDataReader DataReader = Command.ExecuteReader();
                    while (DataReader.Read())
                    {
                        KiemSoatBenhNhanTaiPhongMo data = new KiemSoatBenhNhanTaiPhongMo();
                        data.IdKiemSoatBenhNhanTaiPhongMo = Convert.ToInt64(DataReader.GetLong("IdKiemSoatBenhNhanTaiPhongMo").ToString());

                        data.NgayMo = Convert.ToDateTime(DataReader["NgayMo"] == DBNull.Value ? DateTime.Now : DataReader["NgayMo"]);
                        data.GioMoBatDau = Convert.ToDateTime(DataReader["GioMoBatDau"] == DBNull.Value ? DateTime.Now : DataReader["GioMoBatDau"]);
                        data.GioMoKetThuc = Convert.ToDateTime(DataReader["GioMoKetThuc"] == DBNull.Value ? DateTime.Now : DataReader["GioMoKetThuc"]);
                        data.ChanDoanTruocMo = DataReader["ChanDoanTruocMo"].ToString();
                        data.ChanDoan = XemBenhAn._ThongTinDieuTri.ChanDoan_KhiVaoKhoaDieuTri;
                        data.TruocMo_NhietDo = DataReader["TruocMo_NhietDo"].ToString();
                        data.TruocMo_HuyetAp = DataReader["TruocMo_HuyetAp"].ToString();
                        data.TruocMo_Mach = DataReader["TruocMo_Mach"].ToString();
                        data.TruocMo_NhipTho = DataReader["TruocMo_NhipTho"].ToString();
                        data.TruocMo_TongTrang = int.Parse(DataReader["TruocMo_TongTrang"].ToString());
                        data.TruocMo_TriGiacE = DataReader["TruocMo_TriGiacE"].ToString();
                        data.TruocMo_TriGiacV = DataReader["TruocMo_TriGiacV"].ToString();
                        data.TruocMo_TriGiacM = DataReader["TruocMo_TriGiacM"].ToString();
                        data.TruocMo_MongTayChan = int.Parse(DataReader["TruocMo_MongTayChan"].ToString());
                        data.TruocMo_SacMat = int.Parse(DataReader["TruocMo_SacMat"].ToString());
                        data.TruocMo_NiemMac = int.Parse(DataReader["TruocMo_NiemMac"].ToString());
                        data.TruocMo_DauHieuKhac = DataReader["TruocMo_DauHieuKhac"].ToString();
                        data.TruocMo_DungCu_Gom = DataReader["TruocMo_DungCu_Gom"].ToString();
                        data.TruocMo_DungCu_GacGonBao = DataReader["TruocMo_DungCu_GacGonBao"].ToString();
                        data.TruocMo_DungCu_KhanChamMau = DataReader["TruocMo_DungCu_KhanChamMau"].ToString();
                        data.TruocMo_DungCu_KimChiKau = DataReader["TruocMo_DungCu_KimChiKau"].ToString();
                        data.TruocMo_DungCu_DungCuKhac = DataReader["TruocMo_DungCu_DungCuKhac"].ToString();
                        data.SauMo_NhietDo = DataReader["SauMo_NhietDo"].ToString();
                        data.SauMo_HuyetAp = DataReader["SauMo_HuyetAp"].ToString();
                        data.SauMo_Mach = DataReader["SauMo_Mach"].ToString();
                        data.SauMo_NhipTho = DataReader["SauMo_NhipTho"].ToString();
                        data.SauMo_AmThoPhai = DataReader["SauMo_AmThoPhai"].ToString();
                        data.SauMo_AmThoTrai = DataReader["SauMo_AmThoTrai"].ToString();
                        data.SauMo_DapUngKichThich = int.Parse(DataReader["SauMo_DapUngKichThich"].ToString());
                        data.SauMo_MongTayChan = int.Parse(DataReader["SauMo_MongTayChan"].ToString());
                        data.SauMo_SacMat = int.Parse(DataReader["SauMo_SacMat"].ToString());
                        data.SauMo_ChanTay = int.Parse(DataReader["SauMo_ChanTay"].ToString());
                        data.SauMo_VetMo = DataReader["SauMo_VetMo"].ToString();
                        data.SauMo_DanLuu = DataReader["SauMo_DanLuu"].ToString();
                        data.SauMo_DauHieuKhac = DataReader["SauMo_DauHieuKhac"].ToString();
                        data.SauMo_DungCu_Gom = DataReader["SauMo_DungCu_Gom"].ToString();
                        data.SauMo_DungCu_GacGonBao = DataReader["SauMo_DungCu_GacGonBao"].ToString();
                        data.SauMo_DungCu_KhanChamMau = DataReader["SauMo_DungCu_KhanChamMau"].ToString();
                        data.SauMo_DungCu_KimChiKau = DataReader["SauMo_DungCu_KimChiKau"].ToString();
                        data.SauMo_DungCu_DungCuKhac = DataReader["SauMo_DungCu_DungCuKhac"].ToString();
                        data.DieuDuongVongNgoai = getNhanVienFromID(decimal.Parse(DataReader["DieuDuongVongNgoai"].ToString()));
                        data.DieuDuongVongTrong = getNhanVienFromID(decimal.Parse(DataReader["DieuDuongVongTrong"].ToString()));
                        data.PhauThuatVien = getNhanVienFromID( decimal.Parse(DataReader["PhauThuatVien"].ToString()));
                        data.DichTruyen = DataReader["DichTruyen"].ToString();
                        data.MauTruyen = DataReader["MauTruyen"].ToString();
                        data.TongNhap = DataReader["TongNhap"].ToString();
                        data.NuocTieu = DataReader["NuocTieu"].ToString();
                        data.MauMat = DataReader["MauMat"].ToString();
                        data.TongXuat = DataReader["TongXuat"].ToString();
                        data.DichTruyenCon = DataReader["DichTruyenCon"].ToString();
                        data.SoLuongPhim = DataReader["SoLuongPhim"].ToString();
                        data.BanGiao_TriGiacE = DataReader["BanGiao_TriGiacE"].ToString();
                        data.BanGiao_TriGiacV = DataReader["BanGiao_TriGiacV"].ToString();
                        data.BanGiao_TriGiacM = DataReader["BanGiao_TriGiacM"].ToString();
                        data.BanGiao_NhietDo = DataReader["BanGiao_NhietDo"].ToString();
                        data.BanGiao_HuyetAp = DataReader["BanGiao_HuyetAp"].ToString();
                        data.BanGiao_Mach = DataReader["BanGiao_Mach"].ToString();
                        data.ConNoiKhiQuan_hhht = DataReader["ConNoiKhiQuan_hhht"].ToString().Trim().Equals("1") ? true : false;
                        data.ConNoiKhiQuan_OxyQuaBKQ = DataReader["ConNoiKhiQuan_OxyQuaBKQ"].ToString();
                        data.ConNoiKhiQuan_TuTho = DataReader["ConNoiKhiQuan_TuTho"].ToString();
                        data.KhongConNoiKhiQuan_OxyQuaThong = DataReader["KhongConNoiKhiQuan_OxyQuaThong"].ToString();
                        data.KhongConNoiKhiQuan_TuTho = DataReader["KhongConNoiKhiQuan_TuTho"].ToString();
                        data.BanGiao_DanLuu = DataReader["BanGiao_DanLuu"].ToString();
                        data.BanGiao_DauHieuKhac = DataReader["BanGiao_DauHieuKhac"].ToString();
                        data.NgayGioBanGiao = Convert.ToDateTime(DataReader["NgayGioBanGiao"] == DBNull.Value ? DateTime.Now : DataReader["NgayGioBanGiao"]);
                        data.NguoiGiao = getNhanVienFromID(decimal.Parse(DataReader["NguoiGiao"].ToString()));
                        data.NguoiNhan = getNhanVienFromID(decimal.Parse(DataReader["NguoiNhan"].ToString()));
                        data.CANNANG = Common.ConDBNull_float(DataReader["CANNANG"]);
                        data.NhomMau = DataReader["NhomMau"].ToString();

                        return data;
                    }
                }
                catch (Exception ex) { XuLyLoi.Handle(ex); }
                return null;
            }

            private static NhanVien getNhanVienFromID(decimal id)
            {
                foreach (NhanVien nv in NhanVienFunc.ListNhanVien)
                {
                    if (nv.IdNhanVien == id)
                    {
                        return nv;
                    }
                }
                return null;

            }
            public static DataSet GetDataSet(MDB.MDBConnection MyConnection, decimal IdKiemSoatBenhNhanTaiPhongMo)
            {
                string sql2 = @"SELECT
                D.*,
	            T.MABENHNHAN,
	            T.KHOA,
	            T.GIUONG,
                T.BUONG,
	            T.NGAYVAOVIEN,
                T.SoNhapVien,
	            H.SOYTE,
	            H.BENHVIEN,
	            H.MABENHNHAN,
	            H.TENBENHNHAN,
	            H.TUOI,
	            H.GIOITINH,
                N.HOVATEN DD_VongNgoai_HT,
                N2.HOVATEN DD_VongTrong_HT,
                N3.HOVATEN PhauThuatVien_HT,
                N4.HOVATEN NguoiGiao_HT,
                N5.HOVATEN NguoiNhan_HT
            FROM
                KiemSoatBenhNhanTaiPhongMo D
                JOIN THONGTINDIEUTRI T ON D.MAQUANLY = T.MAQUANLY
                JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
                LEFT JOIN NHANVIEN N ON D.DieuDuongVongNgoai = N.IDNHANVIEN
                LEFT JOIN NHANVIEN N2 ON D.DieuDuongVongTrong = N2.IDNHANVIEN
                LEFT JOIN NHANVIEN N3 ON D.PhauThuatVien = N3.IDNHANVIEN
                LEFT JOIN NHANVIEN N4 ON D.NguoiGiao = N4.IDNHANVIEN
                LEFT JOIN NHANVIEN N5 ON D.NguoiNhan = N5.IDNHANVIEN
            WHERE
                IdKiemSoatBenhNhanTaiPhongMo = :IdKiemSoatBenhNhanTaiPhongMo";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql2, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("IdKiemSoatBenhNhanTaiPhongMo", IdKiemSoatBenhNhanTaiPhongMo));

                MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
                var ds = new DataSet();
                adt.Fill(ds);
                return ds;
            }
        }

    }



    
}
