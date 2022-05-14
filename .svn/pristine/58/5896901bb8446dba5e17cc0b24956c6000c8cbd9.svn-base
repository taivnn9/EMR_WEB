using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;


namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuTDNBSauKhiMo24h : ThongTinKy
    {
        public PhieuTDNBSauKhiMo24h()
        {
            TableName = "PhieuTDNBSauKhiMo24h";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PTDNBSKM24H;
            TenMauPhieu = DanhMucPhieu.PTDNBSKM24H.Description();
        }
        // bắt buộc phải có trường, ID, MaQuanLy, MaBenhNhan
        [MoTaDuLieu("Mã định danh")]
        public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau", "", 1)]
        public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
        public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Họ tên bệnh nhân")]
        public string HoTenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
        public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
        public string GioiTinh { get; set; }
        [MoTaDuLieu("Cách thức vô cảm, 1-> Tê tại chỗ, 2 -> Tê vùng, 3 -> Tê tủy sống, 4 -> Mê toàn thân")]
        public int CachThucVoCam { get; set; }
        [MoTaDuLieu("Ngày mổ")]
        public DateTime? NgayMo { get; set; }
        [MoTaDuLieu("Phẫu thuật viên")]
        public string PhauThuatVien { get; set; }
        [MoTaDuLieu("Phương pháp phẫu thuật")]
        public string PhuongPhapPhauThuat { get; set; }
        [MoTaDuLieu("Giờ về khoa")]
        public DateTime? GioVeKhoa { get; set; }
        [MoTaDuLieu("Số phòng")]
        public string SoPhong { get; set; }
        [MoTaDuLieu("Số giường")]
        public string SoGiuong { get; set; }
        // row giờ
        public DateTime? Gio_1 { get; set; }
        public DateTime? Gio_2 { get; set; }
        public DateTime? Gio_3 { get; set; }
        public DateTime? Gio_4 { get; set; }
        public DateTime? Gio_5 { get; set; }
        public DateTime? Gio_6 { get; set; }
        public DateTime? Gio_7 { get; set; }
        public DateTime? Gio_8 { get; set; }
        public DateTime? Gio_9 { get; set; }
        public DateTime? Gio_10 { get; set; }
        public DateTime? Gio_11 { get; set; }
        public DateTime? Gio_12 { get; set; }
        public DateTime? Gio_13 { get; set; }
        public DateTime? Gio_14 { get; set; }
        public DateTime? Gio_15 { get; set; }
        public DateTime? Gio_16 { get; set; }
        public DateTime? Gio_17 { get; set; }
        public DateTime? Gio_18 { get; set; }
        public DateTime? Gio_19 { get; set; }
        public DateTime? Gio_20 { get; set; }
        public DateTime? Gio_21 { get; set; }
        public DateTime? Gio_22 { get; set; }
        public DateTime? Gio_23 { get; set; }
        public DateTime? Gio_24 { get; set; }
        public DateTime? Gio_25 { get; set; }
        public DateTime? Gio_26 { get; set; }
        public DateTime? Gio_27 { get; set; }
        public DateTime? Gio_28 { get; set; }
        public DateTime? Gio_29 { get; set; }
        public DateTime? Gio_30 { get; set; }
        // row nhip thở
        public string NhipTho_1 { get; set; }
        public string NhipTho_2 { get; set; }
        public string NhipTho_3 { get; set; }
        public string NhipTho_4 { get; set; }
        public string NhipTho_5 { get; set; }
        public string NhipTho_6 { get; set; }
        public string NhipTho_7 { get; set; }
        public string NhipTho_8 { get; set; }
        public string NhipTho_9 { get; set; }
        public string NhipTho_10 { get; set; }
        public string NhipTho_11 { get; set; }
        public string NhipTho_12 { get; set; }
        public string NhipTho_13 { get; set; }
        public string NhipTho_14 { get; set; }
        public string NhipTho_15 { get; set; }
        public string NhipTho_16 { get; set; }
        public string NhipTho_17 { get; set; }
        public string NhipTho_18 { get; set; }
        public string NhipTho_19 { get; set; }
        public string NhipTho_20 { get; set; }
        public string NhipTho_21 { get; set; }
        public string NhipTho_22 { get; set; }
        public string NhipTho_23 { get; set; }
        public string NhipTho_24 { get; set; }
        // row da tái nhợt (-), hồng (+)
        public string Da_1 { get; set; }
        public string Da_2 { get; set; }
        public string Da_3 { get; set; }
        public string Da_4 { get; set; }
        public string Da_5 { get; set; }
        public string Da_6 { get; set; }
        public string Da_7 { get; set; }
        public string Da_8 { get; set; }
        public string Da_9 { get; set; }
        public string Da_10 { get; set; }
        public string Da_11 { get; set; }
        public string Da_12 { get; set; }
        public string Da_13 { get; set; }
        public string Da_14 { get; set; }
        public string Da_15 { get; set; }
        public string Da_16 { get; set; }
        public string Da_17 { get; set; }
        public string Da_18 { get; set; }
        public string Da_19 { get; set; }
        public string Da_20 { get; set; }
        public string Da_21 { get; set; }
        public string Da_22 { get; set; }
        public string Da_23 { get; set; }
        public string Da_24 { get; set; }
        // row tri giác
        public string TriGiac_1 { get; set; }
        public string TriGiac_2 { get; set; }
        public string TriGiac_3 { get; set; }
        public string TriGiac_4 { get; set; }
        public string TriGiac_5 { get; set; }
        public string TriGiac_6 { get; set; }
        public string TriGiac_7 { get; set; }
        public string TriGiac_8 { get; set; }
        public string TriGiac_9 { get; set; }
        public string TriGiac_10 { get; set; }
        public string TriGiac_11 { get; set; }
        public string TriGiac_12 { get; set; }
        public string TriGiac_13 { get; set; }
        public string TriGiac_14 { get; set; }
        public string TriGiac_15 { get; set; }
        public string TriGiac_16 { get; set; }
        public string TriGiac_17 { get; set; }
        public string TriGiac_18 { get; set; }
        public string TriGiac_19 { get; set; }
        public string TriGiac_20 { get; set; }
        public string TriGiac_21 { get; set; }
        public string TriGiac_22 { get; set; }
        public string TriGiac_23 { get; set; }
        public string TriGiac_24 { get; set; }
        // row mạch
        public string Mach_1 { get; set; }
        public string Mach_2 { get; set; }
        public string Mach_3 { get; set; }
        public string Mach_4 { get; set; }
        public string Mach_5 { get; set; }
        public string Mach_6 { get; set; }
        public string Mach_7 { get; set; }
        public string Mach_8 { get; set; }
        public string Mach_9 { get; set; }
        public string Mach_10 { get; set; }
        public string Mach_11 { get; set; }
        public string Mach_12 { get; set; }
        public string Mach_13 { get; set; }
        public string Mach_14 { get; set; }
        public string Mach_15 { get; set; }
        public string Mach_16 { get; set; }
        public string Mach_17 { get; set; }
        public string Mach_18 { get; set; }
        // row huyết áp
        public string HuyetAp_1 { get; set; }
        public string HuyetAp_2 { get; set; }
        public string HuyetAp_3 { get; set; }
        public string HuyetAp_4 { get; set; }
        public string HuyetAp_5 { get; set; }
        public string HuyetAp_6 { get; set; }
        public string HuyetAp_7 { get; set; }
        public string HuyetAp_8 { get; set; }
        public string HuyetAp_9 { get; set; }
        public string HuyetAp_10 { get; set; }
        public string HuyetAp_11 { get; set; }
        public string HuyetAp_12 { get; set; }
        public string HuyetAp_13 { get; set; }
        public string HuyetAp_14 { get; set; }
        public string HuyetAp_15 { get; set; }
        public string HuyetAp_16 { get; set; }
        public string HuyetAp_17 { get; set; }
        public string HuyetAp_18 { get; set; }
        // row nhiệt độ
        public string NhietDo_1 { get; set; }
        public string NhietDo_2 { get; set; }
        public string NhietDo_3 { get; set; }
        public string NhietDo_4 { get; set; }
        public string NhietDo_5 { get; set; }
        public string NhietDo_6 { get; set; }
        public string NhietDo_7 { get; set; }
        public string NhietDo_8 { get; set; }
        public string NhietDo_9 { get; set; }
        public string NhietDo_10 { get; set; }
        public string NhietDo_11 { get; set; }
        public string NhietDo_12 { get; set; }
        public string NhietDo_13 { get; set; }
        public string NhietDo_14 { get; set; }
        // row dau
        public string Dau_1 { get; set; }
        public string Dau_2 { get; set; }
        public string Dau_3 { get; set; }
        public string Dau_4 { get; set; }
        public string Dau_5 { get; set; }
        public string Dau_6 { get; set; }
        public string Dau_7 { get; set; }
        public string Dau_8 { get; set; }
        public string Dau_9 { get; set; }
        public string Dau_10 { get; set; }
        public string Dau_11 { get; set; }
        public string Dau_12 { get; set; }
        public string Dau_13 { get; set; }
        public string Dau_14 { get; set; }
        public string Dau_15 { get; set; }
        public string Dau_16 { get; set; }
        public string Dau_17 { get; set; }
        public string Dau_18 { get; set; }
        // row vêt mổ thấm dịch
        public string VetMoThamDich_1 { get; set; }
        public string VetMoThamDich_2 { get; set; }
        public string VetMoThamDich_3 { get; set; }
        public string VetMoThamDich_4 { get; set; }
        public string VetMoThamDich_5 { get; set; }
        public string VetMoThamDich_6 { get; set; }
        public string VetMoThamDich_7 { get; set; }
        public string VetMoThamDich_8 { get; set; }
        public string VetMoThamDich_9 { get; set; }
        public string VetMoThamDich_10 { get; set; }
        public string VetMoThamDich_11 { get; set; }
        public string VetMoThamDich_12 { get; set; }
        public string VetMoThamDich_13 { get; set; }
        // row đường truyền phổi\
        public string DuongTruyenPhoi_1 { get; set; }
        public string DuongTruyenPhoi_2 { get; set; }
        public string DuongTruyenPhoi_3 { get; set; }
        public string DuongTruyenPhoi_4 { get; set; }
        public string DuongTruyenPhoi_5 { get; set; }
        public string DuongTruyenPhoi_6 { get; set; }
        public string DuongTruyenPhoi_7 { get; set; }
        public string DuongTruyenPhoi_8 { get; set; }
        public string DuongTruyenPhoi_9 { get; set; }
        public string DuongTruyenPhoi_10 { get; set; }
        public string DuongTruyenPhoi_11 { get; set; }
        public string DuongTruyenPhoi_12 { get; set; }
        public string DuongTruyenPhoi_13 { get; set; }
        // row nước tiểu
        public string NuocTieu_1 { get; set; }
        public string NuocTieu_2 { get; set; }
        public string NuocTieu_3 { get; set; }
        public string NuocTieu_4 { get; set; }
        public string NuocTieu_5 { get; set; }
        public string NuocTieu_6 { get; set; }
        public string NuocTieu_7 { get; set; }
        public string NuocTieu_8 { get; set; }
        public string NuocTieu_9 { get; set; }
        public string NuocTieu_10 { get; set; }
        public string NuocTieu_11 { get; set; }
        public string NuocTieu_12 { get; set; }
        public string NuocTieu_13 { get; set; }
        // row dẫn lưu 
        public string DanLuu_Text_1 { get; set; }
        public string DanLuu_Text_2 { get; set; }
        public string DanLuu_Text_3 { get; set; }
        public string DanLuu_Text_4 { get; set; }
        public string DanLuu1_1 { get; set; }
        public string DanLuu1_2 { get; set; }
        public string DanLuu1_3 { get; set; }
        public string DanLuu1_4 { get; set; }
        public string DanLuu1_5 { get; set; }
        public string DanLuu1_6 { get; set; }
        public string DanLuu1_7 { get; set; }
        public string DanLuu1_8 { get; set; }
        public string DanLuu1_9 { get; set; }
        public string DanLuu1_10 { get; set; }
        public string DanLuu1_11 { get; set; }
        public string DanLuu1_12 { get; set; }
        public string DanLuu1_13 { get; set; }
        public string DanLuu2_1 { get; set; }
        public string DanLuu2_2 { get; set; }
        public string DanLuu2_3 { get; set; }
        public string DanLuu2_4 { get; set; }
        public string DanLuu2_5 { get; set; }
        public string DanLuu2_6 { get; set; }
        public string DanLuu2_7 { get; set; }
        public string DanLuu2_8 { get; set; }
        public string DanLuu2_9 { get; set; }
        public string DanLuu2_10 { get; set; }
        public string DanLuu2_11 { get; set; }
        public string DanLuu2_12 { get; set; }
        public string DanLuu2_13 { get; set; }
        // row Sonde dạ dày
        public string SondeDaDay_1 { get; set; }
        public string SondeDaDay_2 { get; set; }
        public string SondeDaDay_3 { get; set; }
        public string SondeDaDay_4 { get; set; }
        public string SondeDaDay_5 { get; set; }
        public string SondeDaDay_6 { get; set; }
        public string SondeDaDay_7 { get; set; }
        public string SondeDaDay_8 { get; set; }
        public string SondeDaDay_9 { get; set; }
        public string SondeDaDay_10 { get; set; }
        public string SondeDaDay_11 { get; set; }
        public string SondeDaDay_12 { get; set; }
        public string SondeDaDay_13 { get; set; }
        // row Tổng dịch vào
        public string TongDichVao_1 { get; set; }
        public string TongDichVao_2 { get; set; }
        public string TongDichVao_3 { get; set; }
        public string TongDichVao_4 { get; set; }
        // row Tổng dịch ra
        public string TongDichRa_1 { get; set; }
        public string TongDichRa_2 { get; set; }
        public string TongDichRa_3 { get; set; }
        public string TongDichRa_4 { get; set; }
        public string TongDichRa_5 { get; set; }
        public string TongDichRa_6 { get; set; }
        public string TongDichRa_7 { get; set; }
        // row tên ĐD theo dõi
        public string TenDDTheoDoi_1 { get; set; }
        public string TenDDTheoDoi_2 { get; set; }
        public string TenDDTheoDoi_3 { get; set; }
        public string TenDDTheoDoi_4 { get; set; }
        public string TenDDTheoDoi_5 { get; set; }
        public string TenDDTheoDoi_6 { get; set; }
        public string TenDDTheoDoi_7 { get; set; }
        public string TenDDTheoDoi_8 { get; set; }
        public string TenDDTheoDoi_9 { get; set; }
        public string TenDDTheoDoi_10 { get; set; }
        public string TenDDTheoDoi_11 { get; set; }
        public string TenDDTheoDoi_12 { get; set; }
        public string TenDDTheoDoi_13 { get; set; }
        public string TenDDTheoDoi_14 { get; set; }
        public string TenDDTheoDoi_15 { get; set; }
        public string TenDDTheoDoi_16 { get; set; }
        public string TenDDTheoDoi_17 { get; set; }
        public string TenDDTheoDoi_18 { get; set; }
        public string TenDDTheoDoi_19 { get; set; }
        public string TenDDTheoDoi_20 { get; set; }
        public string TenDDTheoDoi_21 { get; set; }
        public string TenDDTheoDoi_22 { get; set; }

        // bắt buộc
        [MoTaDuLieu("Đã ký", null, 0, 0)]
        public bool DaKy { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
        public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
        public string NguoiTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
        public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
        public string NguoiSua { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
        public bool Chon { get; set; }
    }
    public class PhieuTDNBSauKhiMo24hFunc
    {
        public const string TableName = "PhieuTDNBSauKhiMo24h";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuTDNBSauKhiMo24h> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuTDNBSauKhiMo24h> list = new List<PhieuTDNBSauKhiMo24h>();
            try
            {
                string sql = @"SELECT * FROM PhieuTDNBSauKhiMo24h where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuTDNBSauKhiMo24h data = new PhieuTDNBSauKhiMo24h();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.HoTenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.CachThucVoCam = DataReader.GetInt("CachThucVoCam");
                    data.NgayMo = DataReader["NgayMo"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayMo"].ToString()) : null;
                    data.PhauThuatVien = DataReader["PhauThuatVien"].ToString();
                    data.PhuongPhapPhauThuat = DataReader["PhuongPhapPhauThuat"].ToString();
                    data.GioVeKhoa = DataReader["GioVeKhoa"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["GioVeKhoa"].ToString()) : null;
                    data.SoPhong = DataReader["SoPhong"].ToString();
                    data.SoGiuong = DataReader["SoGiuong"].ToString();
                    data.Gio_1 = DataReader["Gio_1"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["Gio_1"].ToString()) : null;
                    data.Gio_2 = DataReader["Gio_2"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["Gio_2"].ToString()) : null;
                    data.Gio_3 = DataReader["Gio_3"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["Gio_3"].ToString()) : null;
                    data.Gio_4 = DataReader["Gio_4"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["Gio_4"].ToString()) : null;
                    data.Gio_5 = DataReader["Gio_5"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["Gio_5"].ToString()) : null;
                    data.Gio_6 = DataReader["Gio_6"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["Gio_6"].ToString()) : null;
                    data.Gio_7 = DataReader["Gio_7"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["Gio_7"].ToString()) : null;
                    data.Gio_8 = DataReader["Gio_8"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["Gio_8"].ToString()) : null;
                    data.Gio_9 = DataReader["Gio_9"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["Gio_9"].ToString()) : null;
                    data.Gio_10 = DataReader["Gio_10"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["Gio_10"].ToString()) : null;
                    data.Gio_11 = DataReader["Gio_11"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["Gio_11"].ToString()) : null;
                    data.Gio_12 = DataReader["Gio_12"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["Gio_12"].ToString()) : null;
                    data.Gio_13 = DataReader["Gio_13"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["Gio_13"].ToString()) : null;
                    data.Gio_14 = DataReader["Gio_14"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["Gio_14"].ToString()) : null;
                    data.Gio_15 = DataReader["Gio_15"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["Gio_15"].ToString()) : null;
                    data.Gio_16 = DataReader["Gio_16"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["Gio_16"].ToString()) : null;
                    data.Gio_17 = DataReader["Gio_17"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["Gio_17"].ToString()) : null;
                    data.Gio_18 = DataReader["Gio_18"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["Gio_18"].ToString()) : null;
                    data.Gio_19 = DataReader["Gio_19"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["Gio_19"].ToString()) : null;
                    data.Gio_20 = DataReader["Gio_20"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["Gio_20"].ToString()) : null;
                    data.Gio_21 = DataReader["Gio_21"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["Gio_21"].ToString()) : null;
                    data.Gio_22 = DataReader["Gio_22"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["Gio_22"].ToString()) : null;
                    data.Gio_23 = DataReader["Gio_23"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["Gio_23"].ToString()) : null;
                    data.Gio_24 = DataReader["Gio_24"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["Gio_24"].ToString()) : null;
                    data.Gio_25 = DataReader["Gio_25"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["Gio_25"].ToString()) : null;
                    data.Gio_26 = DataReader["Gio_26"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["Gio_26"].ToString()) : null;
                    data.Gio_27 = DataReader["Gio_27"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["Gio_27"].ToString()) : null;
                    data.Gio_28 = DataReader["Gio_28"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["Gio_28"].ToString()) : null;
                    data.Gio_29 = DataReader["Gio_29"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["Gio_29"].ToString()) : null;
                    data.Gio_30 = DataReader["Gio_30"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["Gio_30"].ToString()) : null;
                    data.NhipTho_1 = DataReader["NhipTho_1"].ToString();
                    data.NhipTho_2 = DataReader["NhipTho_2"].ToString();
                    data.NhipTho_3 = DataReader["NhipTho_3"].ToString();
                    data.NhipTho_4 = DataReader["NhipTho_4"].ToString();
                    data.NhipTho_5 = DataReader["NhipTho_5"].ToString();
                    data.NhipTho_6 = DataReader["NhipTho_6"].ToString();
                    data.NhipTho_7 = DataReader["NhipTho_7"].ToString();
                    data.NhipTho_8 = DataReader["NhipTho_8"].ToString();
                    data.NhipTho_9 = DataReader["NhipTho_9"].ToString();
                    data.NhipTho_10 = DataReader["NhipTho_10"].ToString();
                    data.NhipTho_11 = DataReader["NhipTho_11"].ToString();
                    data.NhipTho_12 = DataReader["NhipTho_12"].ToString();
                    data.NhipTho_13 = DataReader["NhipTho_13"].ToString();
                    data.NhipTho_14 = DataReader["NhipTho_14"].ToString();
                    data.NhipTho_15 = DataReader["NhipTho_15"].ToString();
                    data.NhipTho_16 = DataReader["NhipTho_16"].ToString();
                    data.NhipTho_17 = DataReader["NhipTho_17"].ToString();
                    data.NhipTho_18 = DataReader["NhipTho_18"].ToString();
                    data.NhipTho_19 = DataReader["NhipTho_19"].ToString();
                    data.NhipTho_20 = DataReader["NhipTho_20"].ToString();
                    data.NhipTho_21 = DataReader["NhipTho_21"].ToString();
                    data.NhipTho_22 = DataReader["NhipTho_22"].ToString();
                    data.NhipTho_23 = DataReader["NhipTho_23"].ToString();
                    data.NhipTho_24 = DataReader["NhipTho_24"].ToString();
                    data.Da_1 = DataReader["Da_1"].ToString();
                    data.Da_2 = DataReader["Da_2"].ToString();
                    data.Da_3 = DataReader["Da_3"].ToString();
                    data.Da_4 = DataReader["Da_4"].ToString();
                    data.Da_5 = DataReader["Da_5"].ToString();
                    data.Da_6 = DataReader["Da_6"].ToString();
                    data.Da_7 = DataReader["Da_7"].ToString();
                    data.Da_8 = DataReader["Da_8"].ToString();
                    data.Da_9 = DataReader["Da_9"].ToString();
                    data.Da_10 = DataReader["Da_10"].ToString();
                    data.Da_11 = DataReader["Da_11"].ToString();
                    data.Da_12 = DataReader["Da_12"].ToString();
                    data.Da_13 = DataReader["Da_13"].ToString();
                    data.Da_14 = DataReader["Da_14"].ToString();
                    data.Da_15 = DataReader["Da_15"].ToString();
                    data.Da_16 = DataReader["Da_16"].ToString();
                    data.Da_17 = DataReader["Da_17"].ToString();
                    data.Da_18 = DataReader["Da_18"].ToString();
                    data.Da_19 = DataReader["Da_19"].ToString();
                    data.Da_20 = DataReader["Da_20"].ToString();
                    data.Da_21 = DataReader["Da_21"].ToString();
                    data.Da_22 = DataReader["Da_22"].ToString();
                    data.Da_23 = DataReader["Da_23"].ToString();
                    data.Da_24 = DataReader["Da_24"].ToString();
                    data.TriGiac_1 = DataReader["TriGiac_1"].ToString();
                    data.TriGiac_2 = DataReader["TriGiac_2"].ToString();
                    data.TriGiac_3 = DataReader["TriGiac_3"].ToString();
                    data.TriGiac_4 = DataReader["TriGiac_4"].ToString();
                    data.TriGiac_5 = DataReader["TriGiac_5"].ToString();
                    data.TriGiac_6 = DataReader["TriGiac_6"].ToString();
                    data.TriGiac_7 = DataReader["TriGiac_7"].ToString();
                    data.TriGiac_8 = DataReader["TriGiac_8"].ToString();
                    data.TriGiac_9 = DataReader["TriGiac_9"].ToString();
                    data.TriGiac_10 = DataReader["TriGiac_10"].ToString();
                    data.TriGiac_11 = DataReader["TriGiac_11"].ToString();
                    data.TriGiac_12 = DataReader["TriGiac_12"].ToString();
                    data.TriGiac_13 = DataReader["TriGiac_13"].ToString();
                    data.TriGiac_14 = DataReader["TriGiac_14"].ToString();
                    data.TriGiac_15 = DataReader["TriGiac_15"].ToString();
                    data.TriGiac_16 = DataReader["TriGiac_16"].ToString();
                    data.TriGiac_17 = DataReader["TriGiac_17"].ToString();
                    data.TriGiac_18 = DataReader["TriGiac_18"].ToString();
                    data.TriGiac_19 = DataReader["TriGiac_19"].ToString();
                    data.TriGiac_20 = DataReader["TriGiac_20"].ToString();
                    data.TriGiac_21 = DataReader["TriGiac_21"].ToString();
                    data.TriGiac_22 = DataReader["TriGiac_22"].ToString();
                    data.TriGiac_23 = DataReader["TriGiac_23"].ToString();
                    data.TriGiac_24 = DataReader["TriGiac_24"].ToString();
                    data.Mach_1 = DataReader["Mach_1"].ToString();
                    data.Mach_2 = DataReader["Mach_2"].ToString();
                    data.Mach_3 = DataReader["Mach_3"].ToString();
                    data.Mach_4 = DataReader["Mach_4"].ToString();
                    data.Mach_5 = DataReader["Mach_5"].ToString();
                    data.Mach_6 = DataReader["Mach_6"].ToString();
                    data.Mach_7 = DataReader["Mach_7"].ToString();
                    data.Mach_8 = DataReader["Mach_8"].ToString();
                    data.Mach_9 = DataReader["Mach_9"].ToString();
                    data.Mach_10 = DataReader["Mach_10"].ToString();
                    data.Mach_11 = DataReader["Mach_11"].ToString();
                    data.Mach_12 = DataReader["Mach_12"].ToString();
                    data.Mach_13 = DataReader["Mach_13"].ToString();
                    data.Mach_14 = DataReader["Mach_14"].ToString();
                    data.Mach_15 = DataReader["Mach_15"].ToString();
                    data.Mach_16 = DataReader["Mach_16"].ToString();
                    data.Mach_17 = DataReader["Mach_17"].ToString();
                    data.Mach_18 = DataReader["Mach_18"].ToString();
                    data.HuyetAp_1 = DataReader["HuyetAp_1"].ToString();
                    data.HuyetAp_2 = DataReader["HuyetAp_2"].ToString();
                    data.HuyetAp_3 = DataReader["HuyetAp_3"].ToString();
                    data.HuyetAp_4 = DataReader["HuyetAp_4"].ToString();
                    data.HuyetAp_5 = DataReader["HuyetAp_5"].ToString();
                    data.HuyetAp_6 = DataReader["HuyetAp_6"].ToString();
                    data.HuyetAp_7 = DataReader["HuyetAp_7"].ToString();
                    data.HuyetAp_8 = DataReader["HuyetAp_8"].ToString();
                    data.HuyetAp_9 = DataReader["HuyetAp_9"].ToString();
                    data.HuyetAp_10 = DataReader["HuyetAp_10"].ToString();
                    data.HuyetAp_11 = DataReader["HuyetAp_11"].ToString();
                    data.HuyetAp_12 = DataReader["HuyetAp_12"].ToString();
                    data.HuyetAp_13 = DataReader["HuyetAp_13"].ToString();
                    data.HuyetAp_14 = DataReader["HuyetAp_14"].ToString();
                    data.HuyetAp_15 = DataReader["HuyetAp_15"].ToString();
                    data.HuyetAp_16 = DataReader["HuyetAp_16"].ToString();
                    data.HuyetAp_17 = DataReader["HuyetAp_17"].ToString();
                    data.HuyetAp_18 = DataReader["HuyetAp_18"].ToString();
                    data.NhietDo_1 = DataReader["NhietDo_1"].ToString();
                    data.NhietDo_2 = DataReader["NhietDo_2"].ToString();
                    data.NhietDo_3 = DataReader["NhietDo_3"].ToString();
                    data.NhietDo_4 = DataReader["NhietDo_4"].ToString();
                    data.NhietDo_5 = DataReader["NhietDo_5"].ToString();
                    data.NhietDo_6 = DataReader["NhietDo_6"].ToString();
                    data.NhietDo_7 = DataReader["NhietDo_7"].ToString();
                    data.NhietDo_8 = DataReader["NhietDo_8"].ToString();
                    data.NhietDo_9 = DataReader["NhietDo_9"].ToString();
                    data.NhietDo_10 = DataReader["NhietDo_10"].ToString();
                    data.NhietDo_11 = DataReader["NhietDo_11"].ToString();
                    data.NhietDo_12 = DataReader["NhietDo_12"].ToString();
                    data.NhietDo_13 = DataReader["NhietDo_13"].ToString();
                    data.NhietDo_14 = DataReader["NhietDo_14"].ToString();
                    data.Dau_1 = DataReader["Dau_1"].ToString();
                    data.Dau_2 = DataReader["Dau_2"].ToString();
                    data.Dau_3 = DataReader["Dau_3"].ToString();
                    data.Dau_4 = DataReader["Dau_4"].ToString();
                    data.Dau_5 = DataReader["Dau_5"].ToString();
                    data.Dau_6 = DataReader["Dau_6"].ToString();
                    data.Dau_7 = DataReader["Dau_7"].ToString();
                    data.Dau_8 = DataReader["Dau_8"].ToString();
                    data.Dau_9 = DataReader["Dau_9"].ToString();
                    data.Dau_10 = DataReader["Dau_10"].ToString();
                    data.Dau_11 = DataReader["Dau_11"].ToString();
                    data.Dau_12 = DataReader["Dau_12"].ToString();
                    data.Dau_13 = DataReader["Dau_13"].ToString();
                    data.Dau_14 = DataReader["Dau_14"].ToString();
                    data.Dau_15 = DataReader["Dau_15"].ToString();
                    data.Dau_16 = DataReader["Dau_16"].ToString();
                    data.Dau_17 = DataReader["Dau_17"].ToString();
                    data.Dau_18 = DataReader["Dau_18"].ToString();
                    data.VetMoThamDich_1 = DataReader["VetMoThamDich_1"].ToString();
                    data.VetMoThamDich_2 = DataReader["VetMoThamDich_2"].ToString();
                    data.VetMoThamDich_3 = DataReader["VetMoThamDich_3"].ToString();
                    data.VetMoThamDich_4 = DataReader["VetMoThamDich_4"].ToString();
                    data.VetMoThamDich_5 = DataReader["VetMoThamDich_5"].ToString();
                    data.VetMoThamDich_6 = DataReader["VetMoThamDich_6"].ToString();
                    data.VetMoThamDich_7 = DataReader["VetMoThamDich_7"].ToString();
                    data.VetMoThamDich_8 = DataReader["VetMoThamDich_8"].ToString();
                    data.VetMoThamDich_9 = DataReader["VetMoThamDich_9"].ToString();
                    data.VetMoThamDich_10 = DataReader["VetMoThamDich_10"].ToString();
                    data.VetMoThamDich_11 = DataReader["VetMoThamDich_11"].ToString();
                    data.VetMoThamDich_12 = DataReader["VetMoThamDich_12"].ToString();
                    data.VetMoThamDich_13 = DataReader["VetMoThamDich_13"].ToString();
                    data.DuongTruyenPhoi_1 = DataReader["DuongTruyenPhoi_1"].ToString();
                    data.DuongTruyenPhoi_2 = DataReader["DuongTruyenPhoi_2"].ToString();
                    data.DuongTruyenPhoi_3 = DataReader["DuongTruyenPhoi_3"].ToString();
                    data.DuongTruyenPhoi_4 = DataReader["DuongTruyenPhoi_4"].ToString();
                    data.DuongTruyenPhoi_5 = DataReader["DuongTruyenPhoi_5"].ToString();
                    data.DuongTruyenPhoi_6 = DataReader["DuongTruyenPhoi_6"].ToString();
                    data.DuongTruyenPhoi_7 = DataReader["DuongTruyenPhoi_7"].ToString();
                    data.DuongTruyenPhoi_8 = DataReader["DuongTruyenPhoi_8"].ToString();
                    data.DuongTruyenPhoi_9 = DataReader["DuongTruyenPhoi_9"].ToString();
                    data.DuongTruyenPhoi_10 = DataReader["DuongTruyenPhoi_10"].ToString();
                    data.DuongTruyenPhoi_11 = DataReader["DuongTruyenPhoi_11"].ToString();
                    data.DuongTruyenPhoi_12 = DataReader["DuongTruyenPhoi_12"].ToString();
                    data.DuongTruyenPhoi_13 = DataReader["DuongTruyenPhoi_13"].ToString();
                    data.NuocTieu_1 = DataReader["NuocTieu_1"].ToString();
                    data.NuocTieu_2 = DataReader["NuocTieu_2"].ToString();
                    data.NuocTieu_3 = DataReader["NuocTieu_3"].ToString();
                    data.NuocTieu_4 = DataReader["NuocTieu_4"].ToString();
                    data.NuocTieu_5 = DataReader["NuocTieu_5"].ToString();
                    data.NuocTieu_6 = DataReader["NuocTieu_6"].ToString();
                    data.NuocTieu_7 = DataReader["NuocTieu_7"].ToString();
                    data.NuocTieu_8 = DataReader["NuocTieu_8"].ToString();
                    data.NuocTieu_9 = DataReader["NuocTieu_9"].ToString();
                    data.NuocTieu_10 = DataReader["NuocTieu_10"].ToString();
                    data.NuocTieu_11 = DataReader["NuocTieu_11"].ToString();
                    data.NuocTieu_12 = DataReader["NuocTieu_12"].ToString();
                    data.NuocTieu_13 = DataReader["NuocTieu_13"].ToString();
                    data.DanLuu_Text_1 = DataReader["DanLuu_Text_1"].ToString();
                    data.DanLuu_Text_2 = DataReader["DanLuu_Text_2"].ToString();
                    data.DanLuu_Text_3 = DataReader["DanLuu_Text_3"].ToString();
                    data.DanLuu_Text_4 = DataReader["DanLuu_Text_4"].ToString();
                    data.DanLuu1_1 = DataReader["DanLuu1_1"].ToString();
                    data.DanLuu1_2 = DataReader["DanLuu1_2"].ToString();
                    data.DanLuu1_3 = DataReader["DanLuu1_3"].ToString();
                    data.DanLuu1_4 = DataReader["DanLuu1_4"].ToString();
                    data.DanLuu1_5 = DataReader["DanLuu1_5"].ToString();
                    data.DanLuu1_6 = DataReader["DanLuu1_6"].ToString();
                    data.DanLuu1_7 = DataReader["DanLuu1_7"].ToString();
                    data.DanLuu1_8 = DataReader["DanLuu1_8"].ToString();
                    data.DanLuu1_9 = DataReader["DanLuu1_9"].ToString();
                    data.DanLuu1_10 = DataReader["DanLuu1_10"].ToString();
                    data.DanLuu1_11 = DataReader["DanLuu1_11"].ToString();
                    data.DanLuu1_12 = DataReader["DanLuu1_12"].ToString();
                    data.DanLuu1_13 = DataReader["DanLuu1_13"].ToString();
                    data.DanLuu2_1 = DataReader["DanLuu2_1"].ToString();
                    data.DanLuu2_2 = DataReader["DanLuu2_2"].ToString();
                    data.DanLuu2_3 = DataReader["DanLuu2_3"].ToString();
                    data.DanLuu2_4 = DataReader["DanLuu2_4"].ToString();
                    data.DanLuu2_5 = DataReader["DanLuu2_5"].ToString();
                    data.DanLuu2_6 = DataReader["DanLuu2_6"].ToString();
                    data.DanLuu2_7 = DataReader["DanLuu2_7"].ToString();
                    data.DanLuu2_8 = DataReader["DanLuu2_8"].ToString();
                    data.DanLuu2_9 = DataReader["DanLuu2_9"].ToString();
                    data.DanLuu2_10 = DataReader["DanLuu2_10"].ToString();
                    data.DanLuu2_11 = DataReader["DanLuu2_11"].ToString();
                    data.DanLuu2_12 = DataReader["DanLuu2_12"].ToString();
                    data.DanLuu2_13 = DataReader["DanLuu2_13"].ToString();
                    data.SondeDaDay_1 = DataReader["SondeDaDay_1"].ToString();
                    data.SondeDaDay_2 = DataReader["SondeDaDay_2"].ToString();
                    data.SondeDaDay_3 = DataReader["SondeDaDay_3"].ToString();
                    data.SondeDaDay_4 = DataReader["SondeDaDay_4"].ToString();
                    data.SondeDaDay_5 = DataReader["SondeDaDay_5"].ToString();
                    data.SondeDaDay_6 = DataReader["SondeDaDay_6"].ToString();
                    data.SondeDaDay_7 = DataReader["SondeDaDay_7"].ToString();
                    data.SondeDaDay_8 = DataReader["SondeDaDay_8"].ToString();
                    data.SondeDaDay_9 = DataReader["SondeDaDay_9"].ToString();
                    data.SondeDaDay_10 = DataReader["SondeDaDay_10"].ToString();
                    data.SondeDaDay_11 = DataReader["SondeDaDay_11"].ToString();
                    data.SondeDaDay_12 = DataReader["SondeDaDay_12"].ToString();
                    data.SondeDaDay_13 = DataReader["SondeDaDay_13"].ToString();
                    data.TongDichVao_1 = DataReader["TongDichVao_1"].ToString();
                    data.TongDichVao_2 = DataReader["TongDichVao_2"].ToString();
                    data.TongDichVao_3 = DataReader["TongDichVao_3"].ToString();
                    data.TongDichVao_4 = DataReader["TongDichVao_4"].ToString();
                    data.TongDichRa_1 = DataReader["TongDichRa_1"].ToString();
                    data.TongDichRa_2 = DataReader["TongDichRa_2"].ToString();
                    data.TongDichRa_3 = DataReader["TongDichRa_3"].ToString();
                    data.TongDichRa_4 = DataReader["TongDichRa_4"].ToString();
                    data.TongDichRa_5 = DataReader["TongDichRa_5"].ToString();
                    data.TongDichRa_6 = DataReader["TongDichRa_6"].ToString();
                    data.TongDichRa_7 = DataReader["TongDichRa_7"].ToString();
                    data.TenDDTheoDoi_1 = DataReader["TenDDTheoDoi_1"].ToString();
                    data.TenDDTheoDoi_2 = DataReader["TenDDTheoDoi_2"].ToString();
                    data.TenDDTheoDoi_3 = DataReader["TenDDTheoDoi_3"].ToString();
                    data.TenDDTheoDoi_4 = DataReader["TenDDTheoDoi_4"].ToString();
                    data.TenDDTheoDoi_5 = DataReader["TenDDTheoDoi_5"].ToString();
                    data.TenDDTheoDoi_6 = DataReader["TenDDTheoDoi_6"].ToString();
                    data.TenDDTheoDoi_7 = DataReader["TenDDTheoDoi_7"].ToString();
                    data.TenDDTheoDoi_8 = DataReader["TenDDTheoDoi_8"].ToString();
                    data.TenDDTheoDoi_9 = DataReader["TenDDTheoDoi_9"].ToString();
                    data.TenDDTheoDoi_10 = DataReader["TenDDTheoDoi_10"].ToString();
                    data.TenDDTheoDoi_11 = DataReader["TenDDTheoDoi_11"].ToString();
                    data.TenDDTheoDoi_12 = DataReader["TenDDTheoDoi_12"].ToString();
                    data.TenDDTheoDoi_13 = DataReader["TenDDTheoDoi_13"].ToString();
                    data.TenDDTheoDoi_14 = DataReader["TenDDTheoDoi_14"].ToString();
                    data.TenDDTheoDoi_15 = DataReader["TenDDTheoDoi_15"].ToString();
                    data.TenDDTheoDoi_16 = DataReader["TenDDTheoDoi_16"].ToString();
                    data.TenDDTheoDoi_17 = DataReader["TenDDTheoDoi_17"].ToString();
                    data.TenDDTheoDoi_18 = DataReader["TenDDTheoDoi_18"].ToString();
                    data.TenDDTheoDoi_19 = DataReader["TenDDTheoDoi_19"].ToString();
                    data.TenDDTheoDoi_20 = DataReader["TenDDTheoDoi_20"].ToString();
                    data.TenDDTheoDoi_21 = DataReader["TenDDTheoDoi_21"].ToString();
                    data.TenDDTheoDoi_22 = DataReader["TenDDTheoDoi_22"].ToString();


                    data.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                    data.NguoiTao = DataReader["NguoiTao"].ToString();
                    data.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);
                    data.NguoiSua = DataReader["NguoiSua"].ToString();

                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;
                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuTDNBSauKhiMo24h ketQua)
        {
            try
            {
                string sql = @"INSERT INTO PhieuTDNBSauKhiMo24h
                (
                    MAQUANLY,
                    MaBenhNhan,
                    CachThucVoCam,
                    NgayMo,
                    PhauThuatVien,
                    PhuongPhapPhauThuat,
                    GioVeKhoa,
                    SoPhong,
                    SoGiuong,
                    Gio_1,
                    Gio_2,
                    Gio_3,
                    Gio_4,
                    Gio_5,
                    Gio_6,
                    Gio_7,
                    Gio_8,
                    Gio_9,
                    Gio_10,
                    Gio_11,
                    Gio_12,
                    Gio_13,
                    Gio_14,
                    Gio_15,
                    Gio_16,
                    Gio_17,
                    Gio_18,
                    Gio_19,
                    Gio_20,
                    Gio_21,
                    Gio_22,
                    Gio_23,
                    Gio_24,
                    Gio_25,
                    Gio_26,
                    Gio_27,
                    Gio_28,
                    Gio_29,
                    Gio_30,
                    NhipTho_1,
                    NhipTho_2,
                    NhipTho_3,
                    NhipTho_4,
                    NhipTho_5,
                    NhipTho_6,
                    NhipTho_7,
                    NhipTho_8,
                    NhipTho_9,
                    NhipTho_10,
                    NhipTho_11,
                    NhipTho_12,
                    NhipTho_13,
                    NhipTho_14,
                    NhipTho_15,
                    NhipTho_16,
                    NhipTho_17,
                    NhipTho_18,
                    NhipTho_19,
                    NhipTho_20,
                    NhipTho_21,
                    NhipTho_22,
                    NhipTho_23,
                    NhipTho_24,
                    Da_1,
                    Da_2,
                    Da_3,
                    Da_4,
                    Da_5,
                    Da_6,
                    Da_7,
                    Da_8,
                    Da_9,
                    Da_10,
                    Da_11,
                    Da_12,
                    Da_13,
                    Da_14,
                    Da_15,
                    Da_16,
                    Da_17,
                    Da_18,
                    Da_19,
                    Da_20,
                    Da_21,
                    Da_22,
                    Da_23,
                    Da_24,
                    TriGiac_1,
                    TriGiac_2,
                    TriGiac_3,
                    TriGiac_4,
                    TriGiac_5,
                    TriGiac_6,
                    TriGiac_7,
                    TriGiac_8,
                    TriGiac_9,
                    TriGiac_10,
                    TriGiac_11,
                    TriGiac_12,
                    TriGiac_13,
                    TriGiac_14,
                    TriGiac_15,
                    TriGiac_16,
                    TriGiac_17,
                    TriGiac_18,
                    TriGiac_19,
                    TriGiac_20,
                    TriGiac_21,
                    TriGiac_22,
                    TriGiac_23,
                    TriGiac_24,
                    Mach_1,
                    Mach_2,
                    Mach_3,
                    Mach_4,
                    Mach_5,
                    Mach_6,
                    Mach_7,
                    Mach_8,
                    Mach_9,
                    Mach_10,
                    Mach_11,
                    Mach_12,
                    Mach_13,
                    Mach_14,
                    Mach_15,
                    Mach_16,
                    Mach_17,
                    Mach_18,
                    HuyetAp_1,
                    HuyetAp_2,
                    HuyetAp_3,
                    HuyetAp_4,
                    HuyetAp_5,
                    HuyetAp_6,
                    HuyetAp_7,
                    HuyetAp_8,
                    HuyetAp_9,
                    HuyetAp_10,
                    HuyetAp_11,
                    HuyetAp_12,
                    HuyetAp_13,
                    HuyetAp_14,
                    HuyetAp_15,
                    HuyetAp_16,
                    HuyetAp_17,
                    HuyetAp_18,
                    NhietDo_1,
                    NhietDo_2,
                    NhietDo_3,
                    NhietDo_4,
                    NhietDo_5,
                    NhietDo_6,
                    NhietDo_7,
                    NhietDo_8,
                    NhietDo_9,
                    NhietDo_10,
                    NhietDo_11,
                    NhietDo_12,
                    NhietDo_13,
                    NhietDo_14,
                    Dau_1,
                    Dau_2,
                    Dau_3,
                    Dau_4,
                    Dau_5,
                    Dau_6,
                    Dau_7,
                    Dau_8,
                    Dau_9,
                    Dau_10,
                    Dau_11,
                    Dau_12,
                    Dau_13,
                    Dau_14,
                    Dau_15,
                    Dau_16,
                    Dau_17,
                    Dau_18,
                    VetMoThamDich_1,
                    VetMoThamDich_2,
                    VetMoThamDich_3,
                    VetMoThamDich_4,
                    VetMoThamDich_5,
                    VetMoThamDich_6,
                    VetMoThamDich_7,
                    VetMoThamDich_8,
                    VetMoThamDich_9,
                    VetMoThamDich_10,
                    VetMoThamDich_11,
                    VetMoThamDich_12,
                    VetMoThamDich_13,
                    DuongTruyenPhoi_1,
                    DuongTruyenPhoi_2,
                    DuongTruyenPhoi_3,
                    DuongTruyenPhoi_4,
                    DuongTruyenPhoi_5,
                    DuongTruyenPhoi_6,
                    DuongTruyenPhoi_7,
                    DuongTruyenPhoi_8,
                    DuongTruyenPhoi_9,
                    DuongTruyenPhoi_10,
                    DuongTruyenPhoi_11,
                    DuongTruyenPhoi_12,
                    DuongTruyenPhoi_13,
                    NuocTieu_1,
                    NuocTieu_2,
                    NuocTieu_3,
                    NuocTieu_4,
                    NuocTieu_5,
                    NuocTieu_6,
                    NuocTieu_7,
                    NuocTieu_8,
                    NuocTieu_9,
                    NuocTieu_10,
                    NuocTieu_11,
                    NuocTieu_12,
                    NuocTieu_13,
                    DanLuu_Text_1,
                    DanLuu_Text_2,
                    DanLuu_Text_3,
                    DanLuu_Text_4,
                    DanLuu1_1,
                    DanLuu1_2,
                    DanLuu1_3,
                    DanLuu1_4,
                    DanLuu1_5,
                    DanLuu1_6,
                    DanLuu1_7,
                    DanLuu1_8,
                    DanLuu1_9,
                    DanLuu1_10,
                    DanLuu1_11,
                    DanLuu1_12,
                    DanLuu1_13,
                    DanLuu2_1,
                    DanLuu2_2,
                    DanLuu2_3,
                    DanLuu2_4,
                    DanLuu2_5,
                    DanLuu2_6,
                    DanLuu2_7,
                    DanLuu2_8,
                    DanLuu2_9,
                    DanLuu2_10,
                    DanLuu2_11,
                    DanLuu2_12,
                    DanLuu2_13,
                    SondeDaDay_1,
                    SondeDaDay_2,
                    SondeDaDay_3,
                    SondeDaDay_4,
                    SondeDaDay_5,
                    SondeDaDay_6,
                    SondeDaDay_7,
                    SondeDaDay_8,
                    SondeDaDay_9,
                    SondeDaDay_10,
                    SondeDaDay_11,
                    SondeDaDay_12,
                    SondeDaDay_13,
                    TongDichVao_1,
                    TongDichVao_2,
                    TongDichVao_3,
                    TongDichVao_4,
                    TongDichRa_1,
                    TongDichRa_2,
                    TongDichRa_3,
                    TongDichRa_4,
                    TongDichRa_5,
                    TongDichRa_6,
                    TongDichRa_7,
                    TenDDTheoDoi_1,
                    TenDDTheoDoi_2,
                    TenDDTheoDoi_3,
                    TenDDTheoDoi_4,
                    TenDDTheoDoi_5,
                    TenDDTheoDoi_6,
                    TenDDTheoDoi_7,
                    TenDDTheoDoi_8,
                    TenDDTheoDoi_9,
                    TenDDTheoDoi_10,
                    TenDDTheoDoi_11,
                    TenDDTheoDoi_12,
                    TenDDTheoDoi_13,
                    TenDDTheoDoi_14,
                    TenDDTheoDoi_15,
                    TenDDTheoDoi_16,
                    TenDDTheoDoi_17,
                    TenDDTheoDoi_18,
                    TenDDTheoDoi_19,
                    TenDDTheoDoi_20,
                    TenDDTheoDoi_21,
                    TenDDTheoDoi_22,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :CachThucVoCam,
                    :NgayMo,
                    :PhauThuatVien,
                    :PhuongPhapPhauThuat,
                    :GioVeKhoa,
                    :SoPhong,
                    :SoGiuong,
                    :Gio_1,
                    :Gio_2,
                    :Gio_3,
                    :Gio_4,
                    :Gio_5,
                    :Gio_6,
                    :Gio_7,
                    :Gio_8,
                    :Gio_9,
                    :Gio_10,
                    :Gio_11,
                    :Gio_12,
                    :Gio_13,
                    :Gio_14,
                    :Gio_15,
                    :Gio_16,
                    :Gio_17,
                    :Gio_18,
                    :Gio_19,
                    :Gio_20,
                    :Gio_21,
                    :Gio_22,
                    :Gio_23,
                    :Gio_24,
                    :Gio_25,
                    :Gio_26,
                    :Gio_27,
                    :Gio_28,
                    :Gio_29,
                    :Gio_30,
                    :NhipTho_1,
                    :NhipTho_2,
                    :NhipTho_3,
                    :NhipTho_4,
                    :NhipTho_5,
                    :NhipTho_6,
                    :NhipTho_7,
                    :NhipTho_8,
                    :NhipTho_9,
                    :NhipTho_10,
                    :NhipTho_11,
                    :NhipTho_12,
                    :NhipTho_13,
                    :NhipTho_14,
                    :NhipTho_15,
                    :NhipTho_16,
                    :NhipTho_17,
                    :NhipTho_18,
                    :NhipTho_19,
                    :NhipTho_20,
                    :NhipTho_21,
                    :NhipTho_22,
                    :NhipTho_23,
                    :NhipTho_24,
                    :Da_1,
                    :Da_2,
                    :Da_3,
                    :Da_4,
                    :Da_5,
                    :Da_6,
                    :Da_7,
                    :Da_8,
                    :Da_9,
                    :Da_10,
                    :Da_11,
                    :Da_12,
                    :Da_13,
                    :Da_14,
                    :Da_15,
                    :Da_16,
                    :Da_17,
                    :Da_18,
                    :Da_19,
                    :Da_20,
                    :Da_21,
                    :Da_22,
                    :Da_23,
                    :Da_24,
                    :TriGiac_1,
                    :TriGiac_2,
                    :TriGiac_3,
                    :TriGiac_4,
                    :TriGiac_5,
                    :TriGiac_6,
                    :TriGiac_7,
                    :TriGiac_8,
                    :TriGiac_9,
                    :TriGiac_10,
                    :TriGiac_11,
                    :TriGiac_12,
                    :TriGiac_13,
                    :TriGiac_14,
                    :TriGiac_15,
                    :TriGiac_16,
                    :TriGiac_17,
                    :TriGiac_18,
                    :TriGiac_19,
                    :TriGiac_20,
                    :TriGiac_21,
                    :TriGiac_22,
                    :TriGiac_23,
                    :TriGiac_24,
                    :Mach_1,
                    :Mach_2,
                    :Mach_3,
                    :Mach_4,
                    :Mach_5,
                    :Mach_6,
                    :Mach_7,
                    :Mach_8,
                    :Mach_9,
                    :Mach_10,
                    :Mach_11,
                    :Mach_12,
                    :Mach_13,
                    :Mach_14,
                    :Mach_15,
                    :Mach_16,
                    :Mach_17,
                    :Mach_18,
                    :HuyetAp_1,
                    :HuyetAp_2,
                    :HuyetAp_3,
                    :HuyetAp_4,
                    :HuyetAp_5,
                    :HuyetAp_6,
                    :HuyetAp_7,
                    :HuyetAp_8,
                    :HuyetAp_9,
                    :HuyetAp_10,
                    :HuyetAp_11,
                    :HuyetAp_12,
                    :HuyetAp_13,
                    :HuyetAp_14,
                    :HuyetAp_15,
                    :HuyetAp_16,
                    :HuyetAp_17,
                    :HuyetAp_18,
                    :NhietDo_1,
                    :NhietDo_2,
                    :NhietDo_3,
                    :NhietDo_4,
                    :NhietDo_5,
                    :NhietDo_6,
                    :NhietDo_7,
                    :NhietDo_8,
                    :NhietDo_9,
                    :NhietDo_10,
                    :NhietDo_11,
                    :NhietDo_12,
                    :NhietDo_13,
                    :NhietDo_14,
                    :Dau_1,
                    :Dau_2,
                    :Dau_3,
                    :Dau_4,
                    :Dau_5,
                    :Dau_6,
                    :Dau_7,
                    :Dau_8,
                    :Dau_9,
                    :Dau_10,
                    :Dau_11,
                    :Dau_12,
                    :Dau_13,
                    :Dau_14,
                    :Dau_15,
                    :Dau_16,
                    :Dau_17,
                    :Dau_18,
                    :VetMoThamDich_1,
                    :VetMoThamDich_2,
                    :VetMoThamDich_3,
                    :VetMoThamDich_4,
                    :VetMoThamDich_5,
                    :VetMoThamDich_6,
                    :VetMoThamDich_7,
                    :VetMoThamDich_8,
                    :VetMoThamDich_9,
                    :VetMoThamDich_10,
                    :VetMoThamDich_11,
                    :VetMoThamDich_12,
                    :VetMoThamDich_13,
                    :DuongTruyenPhoi_1,
                    :DuongTruyenPhoi_2,
                    :DuongTruyenPhoi_3,
                    :DuongTruyenPhoi_4,
                    :DuongTruyenPhoi_5,
                    :DuongTruyenPhoi_6,
                    :DuongTruyenPhoi_7,
                    :DuongTruyenPhoi_8,
                    :DuongTruyenPhoi_9,
                    :DuongTruyenPhoi_10,
                    :DuongTruyenPhoi_11,
                    :DuongTruyenPhoi_12,
                    :DuongTruyenPhoi_13,
                    :NuocTieu_1,
                    :NuocTieu_2,
                    :NuocTieu_3,
                    :NuocTieu_4,
                    :NuocTieu_5,
                    :NuocTieu_6,
                    :NuocTieu_7,
                    :NuocTieu_8,
                    :NuocTieu_9,
                    :NuocTieu_10,
                    :NuocTieu_11,
                    :NuocTieu_12,
                    :NuocTieu_13,
                    :DanLuu_Text_1,
                    :DanLuu_Text_2,
                    :DanLuu_Text_3,
                    :DanLuu_Text_4,
                    :DanLuu1_1,
                    :DanLuu1_2,
                    :DanLuu1_3,
                    :DanLuu1_4,
                    :DanLuu1_5,
                    :DanLuu1_6,
                    :DanLuu1_7,
                    :DanLuu1_8,
                    :DanLuu1_9,
                    :DanLuu1_10,
                    :DanLuu1_11,
                    :DanLuu1_12,
                    :DanLuu1_13,
                    :DanLuu2_1,
                    :DanLuu2_2,
                    :DanLuu2_3,
                    :DanLuu2_4,
                    :DanLuu2_5,
                    :DanLuu2_6,
                    :DanLuu2_7,
                    :DanLuu2_8,
                    :DanLuu2_9,
                    :DanLuu2_10,
                    :DanLuu2_11,
                    :DanLuu2_12,
                    :DanLuu2_13,
                    :SondeDaDay_1,
                    :SondeDaDay_2,
                    :SondeDaDay_3,
                    :SondeDaDay_4,
                    :SondeDaDay_5,
                    :SondeDaDay_6,
                    :SondeDaDay_7,
                    :SondeDaDay_8,
                    :SondeDaDay_9,
                    :SondeDaDay_10,
                    :SondeDaDay_11,
                    :SondeDaDay_12,
                    :SondeDaDay_13,
                    :TongDichVao_1,
                    :TongDichVao_2,
                    :TongDichVao_3,
                    :TongDichVao_4,
                    :TongDichRa_1,
                    :TongDichRa_2,
                    :TongDichRa_3,
                    :TongDichRa_4,
                    :TongDichRa_5,
                    :TongDichRa_6,
                    :TongDichRa_7,
                    :TenDDTheoDoi_1,
                    :TenDDTheoDoi_2,
                    :TenDDTheoDoi_3,
                    :TenDDTheoDoi_4,
                    :TenDDTheoDoi_5,
                    :TenDDTheoDoi_6,
                    :TenDDTheoDoi_7,
                    :TenDDTheoDoi_8,
                    :TenDDTheoDoi_9,
                    :TenDDTheoDoi_10,
                    :TenDDTheoDoi_11,
                    :TenDDTheoDoi_12,
                    :TenDDTheoDoi_13,
                    :TenDDTheoDoi_14,
                    :TenDDTheoDoi_15,
                    :TenDDTheoDoi_16,
                    :TenDDTheoDoi_17,
                    :TenDDTheoDoi_18,
                    :TenDDTheoDoi_19,
                    :TenDDTheoDoi_20,
                    :TenDDTheoDoi_21,
                    :TenDDTheoDoi_22,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE PhieuTDNBSauKhiMo24h SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    CachThucVoCam=:CachThucVoCam,
                    NgayMo=:NgayMo,
                    PhauThuatVien=:PhauThuatVien,
                    PhuongPhapPhauThuat=:PhuongPhapPhauThuat,
                    GioVeKhoa=:GioVeKhoa,
                    SoPhong=:SoPhong,
                    SoGiuong=:SoGiuong,
                    Gio_1=:Gio_1,
                    Gio_2=:Gio_2,
                    Gio_3=:Gio_3,
                    Gio_4=:Gio_4,
                    Gio_5=:Gio_5,
                    Gio_6=:Gio_6,
                    Gio_7=:Gio_7,
                    Gio_8=:Gio_8,
                    Gio_9=:Gio_9,
                    Gio_10=:Gio_10,
                    Gio_11=:Gio_11,
                    Gio_12=:Gio_12,
                    Gio_13=:Gio_13,
                    Gio_14=:Gio_14,
                    Gio_15=:Gio_15,
                    Gio_16=:Gio_16,
                    Gio_17=:Gio_17,
                    Gio_18=:Gio_18,
                    Gio_19=:Gio_19,
                    Gio_20=:Gio_20,
                    Gio_21=:Gio_21,
                    Gio_22=:Gio_22,
                    Gio_23=:Gio_23,
                    Gio_24=:Gio_24,
                    Gio_25=:Gio_25,
                    Gio_26=:Gio_26,
                    Gio_27=:Gio_27,
                    Gio_28=:Gio_28,
                    Gio_29=:Gio_29,
                    Gio_30=:Gio_30,
                    NhipTho_1=:NhipTho_1,
                    NhipTho_2=:NhipTho_2,
                    NhipTho_3=:NhipTho_3,
                    NhipTho_4=:NhipTho_4,
                    NhipTho_5=:NhipTho_5,
                    NhipTho_6=:NhipTho_6,
                    NhipTho_7=:NhipTho_7,
                    NhipTho_8=:NhipTho_8,
                    NhipTho_9=:NhipTho_9,
                    NhipTho_10=:NhipTho_10,
                    NhipTho_11=:NhipTho_11,
                    NhipTho_12=:NhipTho_12,
                    NhipTho_13=:NhipTho_13,
                    NhipTho_14=:NhipTho_14,
                    NhipTho_15=:NhipTho_15,
                    NhipTho_16=:NhipTho_16,
                    NhipTho_17=:NhipTho_17,
                    NhipTho_18=:NhipTho_18,
                    NhipTho_19=:NhipTho_19,
                    NhipTho_20=:NhipTho_20,
                    NhipTho_21=:NhipTho_21,
                    NhipTho_22=:NhipTho_22,
                    NhipTho_23=:NhipTho_23,
                    NhipTho_24=:NhipTho_24,
                    Da_1=:Da_1,
                    Da_2=:Da_2,
                    Da_3=:Da_3,
                    Da_4=:Da_4,
                    Da_5=:Da_5,
                    Da_6=:Da_6,
                    Da_7=:Da_7,
                    Da_8=:Da_8,
                    Da_9=:Da_9,
                    Da_10=:Da_10,
                    Da_11=:Da_11,
                    Da_12=:Da_12,
                    Da_13=:Da_13,
                    Da_14=:Da_14,
                    Da_15=:Da_15,
                    Da_16=:Da_16,
                    Da_17=:Da_17,
                    Da_18=:Da_18,
                    Da_19=:Da_19,
                    Da_20=:Da_20,
                    Da_21=:Da_21,
                    Da_22=:Da_22,
                    Da_23=:Da_23,
                    Da_24=:Da_24,
                    TriGiac_1=:TriGiac_1,
                    TriGiac_2=:TriGiac_2,
                    TriGiac_3=:TriGiac_3,
                    TriGiac_4=:TriGiac_4,
                    TriGiac_5=:TriGiac_5,
                    TriGiac_6=:TriGiac_6,
                    TriGiac_7=:TriGiac_7,
                    TriGiac_8=:TriGiac_8,
                    TriGiac_9=:TriGiac_9,
                    TriGiac_10=:TriGiac_10,
                    TriGiac_11=:TriGiac_11,
                    TriGiac_12=:TriGiac_12,
                    TriGiac_13=:TriGiac_13,
                    TriGiac_14=:TriGiac_14,
                    TriGiac_15=:TriGiac_15,
                    TriGiac_16=:TriGiac_16,
                    TriGiac_17=:TriGiac_17,
                    TriGiac_18=:TriGiac_18,
                    TriGiac_19=:TriGiac_19,
                    TriGiac_20=:TriGiac_20,
                    TriGiac_21=:TriGiac_21,
                    TriGiac_22=:TriGiac_22,
                    TriGiac_23=:TriGiac_23,
                    TriGiac_24=:TriGiac_24,
                    Mach_1=:Mach_1,
                    Mach_2=:Mach_2,
                    Mach_3=:Mach_3,
                    Mach_4=:Mach_4,
                    Mach_5=:Mach_5,
                    Mach_6=:Mach_6,
                    Mach_7=:Mach_7,
                    Mach_8=:Mach_8,
                    Mach_9=:Mach_9,
                    Mach_10=:Mach_10,
                    Mach_11=:Mach_11,
                    Mach_12=:Mach_12,
                    Mach_13=:Mach_13,
                    Mach_14=:Mach_14,
                    Mach_15=:Mach_15,
                    Mach_16=:Mach_16,
                    Mach_17=:Mach_17,
                    Mach_18=:Mach_18,
                    HuyetAp_1=:HuyetAp_1,
                    HuyetAp_2=:HuyetAp_2,
                    HuyetAp_3=:HuyetAp_3,
                    HuyetAp_4=:HuyetAp_4,
                    HuyetAp_5=:HuyetAp_5,
                    HuyetAp_6=:HuyetAp_6,
                    HuyetAp_7=:HuyetAp_7,
                    HuyetAp_8=:HuyetAp_8,
                    HuyetAp_9=:HuyetAp_9,
                    HuyetAp_10=:HuyetAp_10,
                    HuyetAp_11=:HuyetAp_11,
                    HuyetAp_12=:HuyetAp_12,
                    HuyetAp_13=:HuyetAp_13,
                    HuyetAp_14=:HuyetAp_14,
                    HuyetAp_15=:HuyetAp_15,
                    HuyetAp_16=:HuyetAp_16,
                    HuyetAp_17=:HuyetAp_17,
                    HuyetAp_18=:HuyetAp_18,
                    NhietDo_1=:NhietDo_1,
                    NhietDo_2=:NhietDo_2,
                    NhietDo_3=:NhietDo_3,
                    NhietDo_4=:NhietDo_4,
                    NhietDo_5=:NhietDo_5,
                    NhietDo_6=:NhietDo_6,
                    NhietDo_7=:NhietDo_7,
                    NhietDo_8=:NhietDo_8,
                    NhietDo_9=:NhietDo_9,
                    NhietDo_10=:NhietDo_10,
                    NhietDo_11=:NhietDo_11,
                    NhietDo_12=:NhietDo_12,
                    NhietDo_13=:NhietDo_13,
                    NhietDo_14=:NhietDo_14,
                    Dau_1=:Dau_1,
                    Dau_2=:Dau_2,
                    Dau_3=:Dau_3,
                    Dau_4=:Dau_4,
                    Dau_5=:Dau_5,
                    Dau_6=:Dau_6,
                    Dau_7=:Dau_7,
                    Dau_8=:Dau_8,
                    Dau_9=:Dau_9,
                    Dau_10=:Dau_10,
                    Dau_11=:Dau_11,
                    Dau_12=:Dau_12,
                    Dau_13=:Dau_13,
                    Dau_14=:Dau_14,
                    Dau_15=:Dau_15,
                    Dau_16=:Dau_16,
                    Dau_17=:Dau_17,
                    Dau_18=:Dau_18,
                    VetMoThamDich_1=:VetMoThamDich_1,
                    VetMoThamDich_2=:VetMoThamDich_2,
                    VetMoThamDich_3=:VetMoThamDich_3,
                    VetMoThamDich_4=:VetMoThamDich_4,
                    VetMoThamDich_5=:VetMoThamDich_5,
                    VetMoThamDich_6=:VetMoThamDich_6,
                    VetMoThamDich_7=:VetMoThamDich_7,
                    VetMoThamDich_8=:VetMoThamDich_8,
                    VetMoThamDich_9=:VetMoThamDich_9,
                    VetMoThamDich_10=:VetMoThamDich_10,
                    VetMoThamDich_11=:VetMoThamDich_11,
                    VetMoThamDich_12=:VetMoThamDich_12,
                    VetMoThamDich_13=:VetMoThamDich_13,
                    DuongTruyenPhoi_1=:DuongTruyenPhoi_1,
                    DuongTruyenPhoi_2=:DuongTruyenPhoi_2,
                    DuongTruyenPhoi_3=:DuongTruyenPhoi_3,
                    DuongTruyenPhoi_4=:DuongTruyenPhoi_4,
                    DuongTruyenPhoi_5=:DuongTruyenPhoi_5,
                    DuongTruyenPhoi_6=:DuongTruyenPhoi_6,
                    DuongTruyenPhoi_7=:DuongTruyenPhoi_7,
                    DuongTruyenPhoi_8=:DuongTruyenPhoi_8,
                    DuongTruyenPhoi_9=:DuongTruyenPhoi_9,
                    DuongTruyenPhoi_10=:DuongTruyenPhoi_10,
                    DuongTruyenPhoi_11=:DuongTruyenPhoi_11,
                    DuongTruyenPhoi_12=:DuongTruyenPhoi_12,
                    DuongTruyenPhoi_13=:DuongTruyenPhoi_13,
                    NuocTieu_1=:NuocTieu_1,
                    NuocTieu_2=:NuocTieu_2,
                    NuocTieu_3=:NuocTieu_3,
                    NuocTieu_4=:NuocTieu_4,
                    NuocTieu_5=:NuocTieu_5,
                    NuocTieu_6=:NuocTieu_6,
                    NuocTieu_7=:NuocTieu_7,
                    NuocTieu_8=:NuocTieu_8,
                    NuocTieu_9=:NuocTieu_9,
                    NuocTieu_10=:NuocTieu_10,
                    NuocTieu_11=:NuocTieu_11,
                    NuocTieu_12=:NuocTieu_12,
                    NuocTieu_13=:NuocTieu_13,
                    DanLuu_Text_1=:DanLuu_Text_1,
                    DanLuu_Text_2=:DanLuu_Text_2,
                    DanLuu_Text_3=:DanLuu_Text_3,
                    DanLuu_Text_4=:DanLuu_Text_4,
                    DanLuu1_1=:DanLuu1_1,
                    DanLuu1_2=:DanLuu1_2,
                    DanLuu1_3=:DanLuu1_3,
                    DanLuu1_4=:DanLuu1_4,
                    DanLuu1_5=:DanLuu1_5,
                    DanLuu1_6=:DanLuu1_6,
                    DanLuu1_7=:DanLuu1_7,
                    DanLuu1_8=:DanLuu1_8,
                    DanLuu1_9=:DanLuu1_9,
                    DanLuu1_10=:DanLuu1_10,
                    DanLuu1_11=:DanLuu1_11,
                    DanLuu1_12=:DanLuu1_12,
                    DanLuu1_13=:DanLuu1_13,
                    DanLuu2_1=:DanLuu2_1,
                    DanLuu2_2=:DanLuu2_2,
                    DanLuu2_3=:DanLuu2_3,
                    DanLuu2_4=:DanLuu2_4,
                    DanLuu2_5=:DanLuu2_5,
                    DanLuu2_6=:DanLuu2_6,
                    DanLuu2_7=:DanLuu2_7,
                    DanLuu2_8=:DanLuu2_8,
                    DanLuu2_9=:DanLuu2_9,
                    DanLuu2_10=:DanLuu2_10,
                    DanLuu2_11=:DanLuu2_11,
                    DanLuu2_12=:DanLuu2_12,
                    DanLuu2_13=:DanLuu2_13,
                    SondeDaDay_1=:SondeDaDay_1,
                    SondeDaDay_2=:SondeDaDay_2,
                    SondeDaDay_3=:SondeDaDay_3,
                    SondeDaDay_4=:SondeDaDay_4,
                    SondeDaDay_5=:SondeDaDay_5,
                    SondeDaDay_6=:SondeDaDay_6,
                    SondeDaDay_7=:SondeDaDay_7,
                    SondeDaDay_8=:SondeDaDay_8,
                    SondeDaDay_9=:SondeDaDay_9,
                    SondeDaDay_10=:SondeDaDay_10,
                    SondeDaDay_11=:SondeDaDay_11,
                    SondeDaDay_12=:SondeDaDay_12,
                    SondeDaDay_13=:SondeDaDay_13,
                    TongDichVao_1=:TongDichVao_1,
                    TongDichVao_2=:TongDichVao_2,
                    TongDichVao_3=:TongDichVao_3,
                    TongDichVao_4=:TongDichVao_4,
                    TongDichRa_1=:TongDichRa_1,
                    TongDichRa_2=:TongDichRa_2,
                    TongDichRa_3=:TongDichRa_3,
                    TongDichRa_4=:TongDichRa_4,
                    TongDichRa_5=:TongDichRa_5,
                    TongDichRa_6=:TongDichRa_6,
                    TongDichRa_7=:TongDichRa_7,
                    TenDDTheoDoi_1=:TenDDTheoDoi_1,
                    TenDDTheoDoi_2=:TenDDTheoDoi_2,
                    TenDDTheoDoi_3=:TenDDTheoDoi_3,
                    TenDDTheoDoi_4=:TenDDTheoDoi_4,
                    TenDDTheoDoi_5=:TenDDTheoDoi_5,
                    TenDDTheoDoi_6=:TenDDTheoDoi_6,
                    TenDDTheoDoi_7=:TenDDTheoDoi_7,
                    TenDDTheoDoi_8=:TenDDTheoDoi_8,
                    TenDDTheoDoi_9=:TenDDTheoDoi_9,
                    TenDDTheoDoi_10=:TenDDTheoDoi_10,
                    TenDDTheoDoi_11=:TenDDTheoDoi_11,
                    TenDDTheoDoi_12=:TenDDTheoDoi_12,
                    TenDDTheoDoi_13=:TenDDTheoDoi_13,
                    TenDDTheoDoi_14=:TenDDTheoDoi_14,
                    TenDDTheoDoi_15=:TenDDTheoDoi_15,
                    TenDDTheoDoi_16=:TenDDTheoDoi_16,
                    TenDDTheoDoi_17=:TenDDTheoDoi_17,
                    TenDDTheoDoi_18=:TenDDTheoDoi_18,
                    TenDDTheoDoi_19=:TenDDTheoDoi_19,
                    TenDDTheoDoi_20=:TenDDTheoDoi_20,
                    TenDDTheoDoi_21=:TenDDTheoDoi_21,
                    TenDDTheoDoi_22=:TenDDTheoDoi_22,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ketQua.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("CachThucVoCam", ketQua.CachThucVoCam));
                Command.Parameters.Add(new MDB.MDBParameter("NgayMo", ketQua.NgayMo));
                Command.Parameters.Add(new MDB.MDBParameter("PhauThuatVien", ketQua.PhauThuatVien));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapPhauThuat", ketQua.PhuongPhapPhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("GioVeKhoa", ketQua.GioVeKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("SoPhong", ketQua.SoPhong));
                Command.Parameters.Add(new MDB.MDBParameter("SoGiuong", ketQua.SoGiuong));
                Command.Parameters.Add(new MDB.MDBParameter("Gio_1", ketQua.Gio_1));
                Command.Parameters.Add(new MDB.MDBParameter("Gio_2", ketQua.Gio_2));
                Command.Parameters.Add(new MDB.MDBParameter("Gio_3", ketQua.Gio_3));
                Command.Parameters.Add(new MDB.MDBParameter("Gio_4", ketQua.Gio_4));
                Command.Parameters.Add(new MDB.MDBParameter("Gio_5", ketQua.Gio_5));
                Command.Parameters.Add(new MDB.MDBParameter("Gio_6", ketQua.Gio_6));
                Command.Parameters.Add(new MDB.MDBParameter("Gio_7", ketQua.Gio_7));
                Command.Parameters.Add(new MDB.MDBParameter("Gio_8", ketQua.Gio_8));
                Command.Parameters.Add(new MDB.MDBParameter("Gio_9", ketQua.Gio_9));
                Command.Parameters.Add(new MDB.MDBParameter("Gio_10", ketQua.Gio_10));
                Command.Parameters.Add(new MDB.MDBParameter("Gio_11", ketQua.Gio_11));
                Command.Parameters.Add(new MDB.MDBParameter("Gio_12", ketQua.Gio_12));
                Command.Parameters.Add(new MDB.MDBParameter("Gio_13", ketQua.Gio_13));
                Command.Parameters.Add(new MDB.MDBParameter("Gio_14", ketQua.Gio_14));
                Command.Parameters.Add(new MDB.MDBParameter("Gio_15", ketQua.Gio_15));
                Command.Parameters.Add(new MDB.MDBParameter("Gio_16", ketQua.Gio_16));
                Command.Parameters.Add(new MDB.MDBParameter("Gio_17", ketQua.Gio_17));
                Command.Parameters.Add(new MDB.MDBParameter("Gio_18", ketQua.Gio_18));
                Command.Parameters.Add(new MDB.MDBParameter("Gio_19", ketQua.Gio_19));
                Command.Parameters.Add(new MDB.MDBParameter("Gio_20", ketQua.Gio_20));
                Command.Parameters.Add(new MDB.MDBParameter("Gio_21", ketQua.Gio_21));
                Command.Parameters.Add(new MDB.MDBParameter("Gio_22", ketQua.Gio_22));
                Command.Parameters.Add(new MDB.MDBParameter("Gio_23", ketQua.Gio_23));
                Command.Parameters.Add(new MDB.MDBParameter("Gio_24", ketQua.Gio_24));
                Command.Parameters.Add(new MDB.MDBParameter("Gio_25", ketQua.Gio_25));
                Command.Parameters.Add(new MDB.MDBParameter("Gio_26", ketQua.Gio_26));
                Command.Parameters.Add(new MDB.MDBParameter("Gio_27", ketQua.Gio_27));
                Command.Parameters.Add(new MDB.MDBParameter("Gio_28", ketQua.Gio_28));
                Command.Parameters.Add(new MDB.MDBParameter("Gio_29", ketQua.Gio_29));
                Command.Parameters.Add(new MDB.MDBParameter("Gio_30", ketQua.Gio_30));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTho_1", ketQua.NhipTho_1));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTho_2", ketQua.NhipTho_2));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTho_3", ketQua.NhipTho_3));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTho_4", ketQua.NhipTho_4));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTho_5", ketQua.NhipTho_5));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTho_6", ketQua.NhipTho_6));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTho_7", ketQua.NhipTho_7));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTho_8", ketQua.NhipTho_8));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTho_9", ketQua.NhipTho_9));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTho_10", ketQua.NhipTho_10));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTho_11", ketQua.NhipTho_11));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTho_12", ketQua.NhipTho_12));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTho_13", ketQua.NhipTho_13));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTho_14", ketQua.NhipTho_14));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTho_15", ketQua.NhipTho_15));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTho_16", ketQua.NhipTho_16));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTho_17", ketQua.NhipTho_17));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTho_18", ketQua.NhipTho_18));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTho_19", ketQua.NhipTho_19));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTho_20", ketQua.NhipTho_20));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTho_21", ketQua.NhipTho_21));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTho_22", ketQua.NhipTho_22));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTho_23", ketQua.NhipTho_23));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTho_24", ketQua.NhipTho_24));
                Command.Parameters.Add(new MDB.MDBParameter("Da_1", ketQua.Da_1));
                Command.Parameters.Add(new MDB.MDBParameter("Da_2", ketQua.Da_2));
                Command.Parameters.Add(new MDB.MDBParameter("Da_3", ketQua.Da_3));
                Command.Parameters.Add(new MDB.MDBParameter("Da_4", ketQua.Da_4));
                Command.Parameters.Add(new MDB.MDBParameter("Da_5", ketQua.Da_5));
                Command.Parameters.Add(new MDB.MDBParameter("Da_6", ketQua.Da_6));
                Command.Parameters.Add(new MDB.MDBParameter("Da_7", ketQua.Da_7));
                Command.Parameters.Add(new MDB.MDBParameter("Da_8", ketQua.Da_8));
                Command.Parameters.Add(new MDB.MDBParameter("Da_9", ketQua.Da_9));
                Command.Parameters.Add(new MDB.MDBParameter("Da_10", ketQua.Da_10));
                Command.Parameters.Add(new MDB.MDBParameter("Da_11", ketQua.Da_11));
                Command.Parameters.Add(new MDB.MDBParameter("Da_12", ketQua.Da_12));
                Command.Parameters.Add(new MDB.MDBParameter("Da_13", ketQua.Da_13));
                Command.Parameters.Add(new MDB.MDBParameter("Da_14", ketQua.Da_14));
                Command.Parameters.Add(new MDB.MDBParameter("Da_15", ketQua.Da_15));
                Command.Parameters.Add(new MDB.MDBParameter("Da_16", ketQua.Da_16));
                Command.Parameters.Add(new MDB.MDBParameter("Da_17", ketQua.Da_17));
                Command.Parameters.Add(new MDB.MDBParameter("Da_18", ketQua.Da_18));
                Command.Parameters.Add(new MDB.MDBParameter("Da_19", ketQua.Da_19));
                Command.Parameters.Add(new MDB.MDBParameter("Da_20", ketQua.Da_20));
                Command.Parameters.Add(new MDB.MDBParameter("Da_21", ketQua.Da_21));
                Command.Parameters.Add(new MDB.MDBParameter("Da_22", ketQua.Da_22));
                Command.Parameters.Add(new MDB.MDBParameter("Da_23", ketQua.Da_23));
                Command.Parameters.Add(new MDB.MDBParameter("Da_24", ketQua.Da_24));
                Command.Parameters.Add(new MDB.MDBParameter("TriGiac_1", ketQua.TriGiac_1));
                Command.Parameters.Add(new MDB.MDBParameter("TriGiac_2", ketQua.TriGiac_2));
                Command.Parameters.Add(new MDB.MDBParameter("TriGiac_3", ketQua.TriGiac_3));
                Command.Parameters.Add(new MDB.MDBParameter("TriGiac_4", ketQua.TriGiac_4));
                Command.Parameters.Add(new MDB.MDBParameter("TriGiac_5", ketQua.TriGiac_5));
                Command.Parameters.Add(new MDB.MDBParameter("TriGiac_6", ketQua.TriGiac_6));
                Command.Parameters.Add(new MDB.MDBParameter("TriGiac_7", ketQua.TriGiac_7));
                Command.Parameters.Add(new MDB.MDBParameter("TriGiac_8", ketQua.TriGiac_8));
                Command.Parameters.Add(new MDB.MDBParameter("TriGiac_9", ketQua.TriGiac_9));
                Command.Parameters.Add(new MDB.MDBParameter("TriGiac_10", ketQua.TriGiac_10));
                Command.Parameters.Add(new MDB.MDBParameter("TriGiac_11", ketQua.TriGiac_11));
                Command.Parameters.Add(new MDB.MDBParameter("TriGiac_12", ketQua.TriGiac_12));
                Command.Parameters.Add(new MDB.MDBParameter("TriGiac_13", ketQua.TriGiac_13));
                Command.Parameters.Add(new MDB.MDBParameter("TriGiac_14", ketQua.TriGiac_14));
                Command.Parameters.Add(new MDB.MDBParameter("TriGiac_15", ketQua.TriGiac_15));
                Command.Parameters.Add(new MDB.MDBParameter("TriGiac_16", ketQua.TriGiac_16));
                Command.Parameters.Add(new MDB.MDBParameter("TriGiac_17", ketQua.TriGiac_17));
                Command.Parameters.Add(new MDB.MDBParameter("TriGiac_18", ketQua.TriGiac_18));
                Command.Parameters.Add(new MDB.MDBParameter("TriGiac_19", ketQua.TriGiac_19));
                Command.Parameters.Add(new MDB.MDBParameter("TriGiac_20", ketQua.TriGiac_20));
                Command.Parameters.Add(new MDB.MDBParameter("TriGiac_21", ketQua.TriGiac_21));
                Command.Parameters.Add(new MDB.MDBParameter("TriGiac_22", ketQua.TriGiac_22));
                Command.Parameters.Add(new MDB.MDBParameter("TriGiac_23", ketQua.TriGiac_23));
                Command.Parameters.Add(new MDB.MDBParameter("TriGiac_24", ketQua.TriGiac_24));
                Command.Parameters.Add(new MDB.MDBParameter("Mach_1", ketQua.Mach_1));
                Command.Parameters.Add(new MDB.MDBParameter("Mach_2", ketQua.Mach_2));
                Command.Parameters.Add(new MDB.MDBParameter("Mach_3", ketQua.Mach_3));
                Command.Parameters.Add(new MDB.MDBParameter("Mach_4", ketQua.Mach_4));
                Command.Parameters.Add(new MDB.MDBParameter("Mach_5", ketQua.Mach_5));
                Command.Parameters.Add(new MDB.MDBParameter("Mach_6", ketQua.Mach_6));
                Command.Parameters.Add(new MDB.MDBParameter("Mach_7", ketQua.Mach_7));
                Command.Parameters.Add(new MDB.MDBParameter("Mach_8", ketQua.Mach_8));
                Command.Parameters.Add(new MDB.MDBParameter("Mach_9", ketQua.Mach_9));
                Command.Parameters.Add(new MDB.MDBParameter("Mach_10", ketQua.Mach_10));
                Command.Parameters.Add(new MDB.MDBParameter("Mach_11", ketQua.Mach_11));
                Command.Parameters.Add(new MDB.MDBParameter("Mach_12", ketQua.Mach_12));
                Command.Parameters.Add(new MDB.MDBParameter("Mach_13", ketQua.Mach_13));
                Command.Parameters.Add(new MDB.MDBParameter("Mach_14", ketQua.Mach_14));
                Command.Parameters.Add(new MDB.MDBParameter("Mach_15", ketQua.Mach_15));
                Command.Parameters.Add(new MDB.MDBParameter("Mach_16", ketQua.Mach_16));
                Command.Parameters.Add(new MDB.MDBParameter("Mach_17", ketQua.Mach_17));
                Command.Parameters.Add(new MDB.MDBParameter("Mach_18", ketQua.Mach_18));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetAp_1", ketQua.HuyetAp_1));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetAp_2", ketQua.HuyetAp_2));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetAp_3", ketQua.HuyetAp_3));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetAp_4", ketQua.HuyetAp_4));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetAp_5", ketQua.HuyetAp_5));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetAp_6", ketQua.HuyetAp_6));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetAp_7", ketQua.HuyetAp_7));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetAp_8", ketQua.HuyetAp_8));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetAp_9", ketQua.HuyetAp_9));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetAp_10", ketQua.HuyetAp_10));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetAp_11", ketQua.HuyetAp_11));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetAp_12", ketQua.HuyetAp_12));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetAp_13", ketQua.HuyetAp_13));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetAp_14", ketQua.HuyetAp_14));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetAp_15", ketQua.HuyetAp_15));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetAp_16", ketQua.HuyetAp_16));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetAp_17", ketQua.HuyetAp_17));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetAp_18", ketQua.HuyetAp_18));
                Command.Parameters.Add(new MDB.MDBParameter("NhietDo_1", ketQua.NhietDo_1));
                Command.Parameters.Add(new MDB.MDBParameter("NhietDo_2", ketQua.NhietDo_2));
                Command.Parameters.Add(new MDB.MDBParameter("NhietDo_3", ketQua.NhietDo_3));
                Command.Parameters.Add(new MDB.MDBParameter("NhietDo_4", ketQua.NhietDo_4));
                Command.Parameters.Add(new MDB.MDBParameter("NhietDo_5", ketQua.NhietDo_5));
                Command.Parameters.Add(new MDB.MDBParameter("NhietDo_6", ketQua.NhietDo_6));
                Command.Parameters.Add(new MDB.MDBParameter("NhietDo_7", ketQua.NhietDo_7));
                Command.Parameters.Add(new MDB.MDBParameter("NhietDo_8", ketQua.NhietDo_8));
                Command.Parameters.Add(new MDB.MDBParameter("NhietDo_9", ketQua.NhietDo_9));
                Command.Parameters.Add(new MDB.MDBParameter("NhietDo_10", ketQua.NhietDo_10));
                Command.Parameters.Add(new MDB.MDBParameter("NhietDo_11", ketQua.NhietDo_11));
                Command.Parameters.Add(new MDB.MDBParameter("NhietDo_12", ketQua.NhietDo_12));
                Command.Parameters.Add(new MDB.MDBParameter("NhietDo_13", ketQua.NhietDo_13));
                Command.Parameters.Add(new MDB.MDBParameter("NhietDo_14", ketQua.NhietDo_14));
                Command.Parameters.Add(new MDB.MDBParameter("Dau_1", ketQua.Dau_1));
                Command.Parameters.Add(new MDB.MDBParameter("Dau_2", ketQua.Dau_2));
                Command.Parameters.Add(new MDB.MDBParameter("Dau_3", ketQua.Dau_3));
                Command.Parameters.Add(new MDB.MDBParameter("Dau_4", ketQua.Dau_4));
                Command.Parameters.Add(new MDB.MDBParameter("Dau_5", ketQua.Dau_5));
                Command.Parameters.Add(new MDB.MDBParameter("Dau_6", ketQua.Dau_6));
                Command.Parameters.Add(new MDB.MDBParameter("Dau_7", ketQua.Dau_7));
                Command.Parameters.Add(new MDB.MDBParameter("Dau_8", ketQua.Dau_8));
                Command.Parameters.Add(new MDB.MDBParameter("Dau_9", ketQua.Dau_9));
                Command.Parameters.Add(new MDB.MDBParameter("Dau_10", ketQua.Dau_10));
                Command.Parameters.Add(new MDB.MDBParameter("Dau_11", ketQua.Dau_11));
                Command.Parameters.Add(new MDB.MDBParameter("Dau_12", ketQua.Dau_12));
                Command.Parameters.Add(new MDB.MDBParameter("Dau_13", ketQua.Dau_13));
                Command.Parameters.Add(new MDB.MDBParameter("Dau_14", ketQua.Dau_14));
                Command.Parameters.Add(new MDB.MDBParameter("Dau_15", ketQua.Dau_15));
                Command.Parameters.Add(new MDB.MDBParameter("Dau_16", ketQua.Dau_16));
                Command.Parameters.Add(new MDB.MDBParameter("Dau_17", ketQua.Dau_17));
                Command.Parameters.Add(new MDB.MDBParameter("Dau_18", ketQua.Dau_18));
                Command.Parameters.Add(new MDB.MDBParameter("VetMoThamDich_1", ketQua.VetMoThamDich_1));
                Command.Parameters.Add(new MDB.MDBParameter("VetMoThamDich_2", ketQua.VetMoThamDich_2));
                Command.Parameters.Add(new MDB.MDBParameter("VetMoThamDich_3", ketQua.VetMoThamDich_3));
                Command.Parameters.Add(new MDB.MDBParameter("VetMoThamDich_4", ketQua.VetMoThamDich_4));
                Command.Parameters.Add(new MDB.MDBParameter("VetMoThamDich_5", ketQua.VetMoThamDich_5));
                Command.Parameters.Add(new MDB.MDBParameter("VetMoThamDich_6", ketQua.VetMoThamDich_6));
                Command.Parameters.Add(new MDB.MDBParameter("VetMoThamDich_7", ketQua.VetMoThamDich_7));
                Command.Parameters.Add(new MDB.MDBParameter("VetMoThamDich_8", ketQua.VetMoThamDich_8));
                Command.Parameters.Add(new MDB.MDBParameter("VetMoThamDich_9", ketQua.VetMoThamDich_9));
                Command.Parameters.Add(new MDB.MDBParameter("VetMoThamDich_10", ketQua.VetMoThamDich_10));
                Command.Parameters.Add(new MDB.MDBParameter("VetMoThamDich_11", ketQua.VetMoThamDich_11));
                Command.Parameters.Add(new MDB.MDBParameter("VetMoThamDich_12", ketQua.VetMoThamDich_12));
                Command.Parameters.Add(new MDB.MDBParameter("VetMoThamDich_13", ketQua.VetMoThamDich_13));
                Command.Parameters.Add(new MDB.MDBParameter("DuongTruyenPhoi_1", ketQua.DuongTruyenPhoi_1));
                Command.Parameters.Add(new MDB.MDBParameter("DuongTruyenPhoi_2", ketQua.DuongTruyenPhoi_2));
                Command.Parameters.Add(new MDB.MDBParameter("DuongTruyenPhoi_3", ketQua.DuongTruyenPhoi_3));
                Command.Parameters.Add(new MDB.MDBParameter("DuongTruyenPhoi_4", ketQua.DuongTruyenPhoi_4));
                Command.Parameters.Add(new MDB.MDBParameter("DuongTruyenPhoi_5", ketQua.DuongTruyenPhoi_5));
                Command.Parameters.Add(new MDB.MDBParameter("DuongTruyenPhoi_6", ketQua.DuongTruyenPhoi_6));
                Command.Parameters.Add(new MDB.MDBParameter("DuongTruyenPhoi_7", ketQua.DuongTruyenPhoi_7));
                Command.Parameters.Add(new MDB.MDBParameter("DuongTruyenPhoi_8", ketQua.DuongTruyenPhoi_8));
                Command.Parameters.Add(new MDB.MDBParameter("DuongTruyenPhoi_9", ketQua.DuongTruyenPhoi_9));
                Command.Parameters.Add(new MDB.MDBParameter("DuongTruyenPhoi_10", ketQua.DuongTruyenPhoi_10));
                Command.Parameters.Add(new MDB.MDBParameter("DuongTruyenPhoi_11", ketQua.DuongTruyenPhoi_11));
                Command.Parameters.Add(new MDB.MDBParameter("DuongTruyenPhoi_12", ketQua.DuongTruyenPhoi_12));
                Command.Parameters.Add(new MDB.MDBParameter("DuongTruyenPhoi_13", ketQua.DuongTruyenPhoi_13));
                Command.Parameters.Add(new MDB.MDBParameter("NuocTieu_1", ketQua.NuocTieu_1));
                Command.Parameters.Add(new MDB.MDBParameter("NuocTieu_2", ketQua.NuocTieu_2));
                Command.Parameters.Add(new MDB.MDBParameter("NuocTieu_3", ketQua.NuocTieu_3));
                Command.Parameters.Add(new MDB.MDBParameter("NuocTieu_4", ketQua.NuocTieu_4));
                Command.Parameters.Add(new MDB.MDBParameter("NuocTieu_5", ketQua.NuocTieu_5));
                Command.Parameters.Add(new MDB.MDBParameter("NuocTieu_6", ketQua.NuocTieu_6));
                Command.Parameters.Add(new MDB.MDBParameter("NuocTieu_7", ketQua.NuocTieu_7));
                Command.Parameters.Add(new MDB.MDBParameter("NuocTieu_8", ketQua.NuocTieu_8));
                Command.Parameters.Add(new MDB.MDBParameter("NuocTieu_9", ketQua.NuocTieu_9));
                Command.Parameters.Add(new MDB.MDBParameter("NuocTieu_10", ketQua.NuocTieu_10));
                Command.Parameters.Add(new MDB.MDBParameter("NuocTieu_11", ketQua.NuocTieu_11));
                Command.Parameters.Add(new MDB.MDBParameter("NuocTieu_12", ketQua.NuocTieu_12));
                Command.Parameters.Add(new MDB.MDBParameter("NuocTieu_13", ketQua.NuocTieu_13));
                Command.Parameters.Add(new MDB.MDBParameter("DanLuu_Text_1", ketQua.DanLuu_Text_1));
                Command.Parameters.Add(new MDB.MDBParameter("DanLuu_Text_2", ketQua.DanLuu_Text_2));
                Command.Parameters.Add(new MDB.MDBParameter("DanLuu_Text_3", ketQua.DanLuu_Text_3));
                Command.Parameters.Add(new MDB.MDBParameter("DanLuu_Text_4", ketQua.DanLuu_Text_4));
                Command.Parameters.Add(new MDB.MDBParameter("DanLuu1_1", ketQua.DanLuu1_1));
                Command.Parameters.Add(new MDB.MDBParameter("DanLuu1_2", ketQua.DanLuu1_2));
                Command.Parameters.Add(new MDB.MDBParameter("DanLuu1_3", ketQua.DanLuu1_3));
                Command.Parameters.Add(new MDB.MDBParameter("DanLuu1_4", ketQua.DanLuu1_4));
                Command.Parameters.Add(new MDB.MDBParameter("DanLuu1_5", ketQua.DanLuu1_5));
                Command.Parameters.Add(new MDB.MDBParameter("DanLuu1_6", ketQua.DanLuu1_6));
                Command.Parameters.Add(new MDB.MDBParameter("DanLuu1_7", ketQua.DanLuu1_7));
                Command.Parameters.Add(new MDB.MDBParameter("DanLuu1_8", ketQua.DanLuu1_8));
                Command.Parameters.Add(new MDB.MDBParameter("DanLuu1_9", ketQua.DanLuu1_9));
                Command.Parameters.Add(new MDB.MDBParameter("DanLuu1_10", ketQua.DanLuu1_10));
                Command.Parameters.Add(new MDB.MDBParameter("DanLuu1_11", ketQua.DanLuu1_11));
                Command.Parameters.Add(new MDB.MDBParameter("DanLuu1_12", ketQua.DanLuu1_12));
                Command.Parameters.Add(new MDB.MDBParameter("DanLuu1_13", ketQua.DanLuu1_13));
                Command.Parameters.Add(new MDB.MDBParameter("DanLuu2_1", ketQua.DanLuu2_1));
                Command.Parameters.Add(new MDB.MDBParameter("DanLuu2_2", ketQua.DanLuu2_2));
                Command.Parameters.Add(new MDB.MDBParameter("DanLuu2_3", ketQua.DanLuu2_3));
                Command.Parameters.Add(new MDB.MDBParameter("DanLuu2_4", ketQua.DanLuu2_4));
                Command.Parameters.Add(new MDB.MDBParameter("DanLuu2_5", ketQua.DanLuu2_5));
                Command.Parameters.Add(new MDB.MDBParameter("DanLuu2_6", ketQua.DanLuu2_6));
                Command.Parameters.Add(new MDB.MDBParameter("DanLuu2_7", ketQua.DanLuu2_7));
                Command.Parameters.Add(new MDB.MDBParameter("DanLuu2_8", ketQua.DanLuu2_8));
                Command.Parameters.Add(new MDB.MDBParameter("DanLuu2_9", ketQua.DanLuu2_9));
                Command.Parameters.Add(new MDB.MDBParameter("DanLuu2_10", ketQua.DanLuu2_10));
                Command.Parameters.Add(new MDB.MDBParameter("DanLuu2_11", ketQua.DanLuu2_11));
                Command.Parameters.Add(new MDB.MDBParameter("DanLuu2_12", ketQua.DanLuu2_12));
                Command.Parameters.Add(new MDB.MDBParameter("DanLuu2_13", ketQua.DanLuu2_13));
                Command.Parameters.Add(new MDB.MDBParameter("SondeDaDay_1", ketQua.SondeDaDay_1));
                Command.Parameters.Add(new MDB.MDBParameter("SondeDaDay_2", ketQua.SondeDaDay_2));
                Command.Parameters.Add(new MDB.MDBParameter("SondeDaDay_3", ketQua.SondeDaDay_3));
                Command.Parameters.Add(new MDB.MDBParameter("SondeDaDay_4", ketQua.SondeDaDay_4));
                Command.Parameters.Add(new MDB.MDBParameter("SondeDaDay_5", ketQua.SondeDaDay_5));
                Command.Parameters.Add(new MDB.MDBParameter("SondeDaDay_6", ketQua.SondeDaDay_6));
                Command.Parameters.Add(new MDB.MDBParameter("SondeDaDay_7", ketQua.SondeDaDay_7));
                Command.Parameters.Add(new MDB.MDBParameter("SondeDaDay_8", ketQua.SondeDaDay_8));
                Command.Parameters.Add(new MDB.MDBParameter("SondeDaDay_9", ketQua.SondeDaDay_9));
                Command.Parameters.Add(new MDB.MDBParameter("SondeDaDay_10", ketQua.SondeDaDay_10));
                Command.Parameters.Add(new MDB.MDBParameter("SondeDaDay_11", ketQua.SondeDaDay_11));
                Command.Parameters.Add(new MDB.MDBParameter("SondeDaDay_12", ketQua.SondeDaDay_12));
                Command.Parameters.Add(new MDB.MDBParameter("SondeDaDay_13", ketQua.SondeDaDay_13));
                Command.Parameters.Add(new MDB.MDBParameter("TongDichVao_1", ketQua.TongDichVao_1));
                Command.Parameters.Add(new MDB.MDBParameter("TongDichVao_2", ketQua.TongDichVao_2));
                Command.Parameters.Add(new MDB.MDBParameter("TongDichVao_3", ketQua.TongDichVao_3));
                Command.Parameters.Add(new MDB.MDBParameter("TongDichVao_4", ketQua.TongDichVao_4));
                Command.Parameters.Add(new MDB.MDBParameter("TongDichRa_1", ketQua.TongDichRa_1));
                Command.Parameters.Add(new MDB.MDBParameter("TongDichRa_2", ketQua.TongDichRa_2));
                Command.Parameters.Add(new MDB.MDBParameter("TongDichRa_3", ketQua.TongDichRa_3));
                Command.Parameters.Add(new MDB.MDBParameter("TongDichRa_4", ketQua.TongDichRa_4));
                Command.Parameters.Add(new MDB.MDBParameter("TongDichRa_5", ketQua.TongDichRa_5));
                Command.Parameters.Add(new MDB.MDBParameter("TongDichRa_6", ketQua.TongDichRa_6));
                Command.Parameters.Add(new MDB.MDBParameter("TongDichRa_7", ketQua.TongDichRa_7));
                Command.Parameters.Add(new MDB.MDBParameter("TenDDTheoDoi_1", ketQua.TenDDTheoDoi_1));
                Command.Parameters.Add(new MDB.MDBParameter("TenDDTheoDoi_2", ketQua.TenDDTheoDoi_2));
                Command.Parameters.Add(new MDB.MDBParameter("TenDDTheoDoi_3", ketQua.TenDDTheoDoi_3));
                Command.Parameters.Add(new MDB.MDBParameter("TenDDTheoDoi_4", ketQua.TenDDTheoDoi_4));
                Command.Parameters.Add(new MDB.MDBParameter("TenDDTheoDoi_5", ketQua.TenDDTheoDoi_5));
                Command.Parameters.Add(new MDB.MDBParameter("TenDDTheoDoi_6", ketQua.TenDDTheoDoi_6));
                Command.Parameters.Add(new MDB.MDBParameter("TenDDTheoDoi_7", ketQua.TenDDTheoDoi_7));
                Command.Parameters.Add(new MDB.MDBParameter("TenDDTheoDoi_8", ketQua.TenDDTheoDoi_8));
                Command.Parameters.Add(new MDB.MDBParameter("TenDDTheoDoi_9", ketQua.TenDDTheoDoi_9));
                Command.Parameters.Add(new MDB.MDBParameter("TenDDTheoDoi_10", ketQua.TenDDTheoDoi_10));
                Command.Parameters.Add(new MDB.MDBParameter("TenDDTheoDoi_11", ketQua.TenDDTheoDoi_11));
                Command.Parameters.Add(new MDB.MDBParameter("TenDDTheoDoi_12", ketQua.TenDDTheoDoi_12));
                Command.Parameters.Add(new MDB.MDBParameter("TenDDTheoDoi_13", ketQua.TenDDTheoDoi_13));
                Command.Parameters.Add(new MDB.MDBParameter("TenDDTheoDoi_14", ketQua.TenDDTheoDoi_14));
                Command.Parameters.Add(new MDB.MDBParameter("TenDDTheoDoi_15", ketQua.TenDDTheoDoi_15));
                Command.Parameters.Add(new MDB.MDBParameter("TenDDTheoDoi_16", ketQua.TenDDTheoDoi_16));
                Command.Parameters.Add(new MDB.MDBParameter("TenDDTheoDoi_17", ketQua.TenDDTheoDoi_17));
                Command.Parameters.Add(new MDB.MDBParameter("TenDDTheoDoi_18", ketQua.TenDDTheoDoi_18));
                Command.Parameters.Add(new MDB.MDBParameter("TenDDTheoDoi_19", ketQua.TenDDTheoDoi_19));
                Command.Parameters.Add(new MDB.MDBParameter("TenDDTheoDoi_20", ketQua.TenDDTheoDoi_20));
                Command.Parameters.Add(new MDB.MDBParameter("TenDDTheoDoi_21", ketQua.TenDDTheoDoi_21));
                Command.Parameters.Add(new MDB.MDBParameter("TenDDTheoDoi_22", ketQua.TenDDTheoDoi_22));

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));
                if (ketQua.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", ketQua.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", ketQua.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", ketQua.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (ketQua.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    ketQua.ID = nextval;
                }
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool delete(MDB.MDBConnection MyConnection, long id)
        {
            try
            {
                string sql = "DELETE FROM PhieuTDNBSauKhiMo24h WHERE ID = :ID";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                command.Parameters.Add(new MDB.MDBParameter("ID", id));
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
        public static DataSet getDataSet(MDB.MDBConnection MyConnection, long id)
        {
            string sql = @"SELECT
                P.*,
                aa.hovaten TenDDTheoDoiHT_1, 
                bb.hovaten TenDDTheoDoiHT_2,
                cc.hovaten TenDDTheoDoiHT_3,
                dd.hovaten TenDDTheoDoiHT_4,
                ee.hovaten TenDDTheoDoiHT_5,
                ff.hovaten TenDDTheoDoiHT_6,
                gg.hovaten TenDDTheoDoiHT_7,
                hh.hovaten TenDDTheoDoiHT_8,
                ii.hovaten TenDDTheoDoiHT_9,
                jj.hovaten TenDDTheoDoiHT_10,
                kk.hovaten TenDDTheoDoiHT_11,
                ll.hovaten TenDDTheoDoiHT_12,
                qq.hovaten TenDDTheoDoiHT_13,
                ww.hovaten TenDDTheoDoiHT_14,
                mm.hovaten TenDDTheoDoiHT_15,
                rr.hovaten TenDDTheoDoiHT_16,
                tt.hovaten TenDDTheoDoiHT_17,
                yy.hovaten TenDDTheoDoiHT_18,
                uu.hovaten TenDDTheoDoiHT_19,
                zz.hovaten TenDDTheoDoiHT_20,
                xx.hovaten TenDDTheoDoiHT_21,
                vv.hovaten TenDDTheoDoiHT_22
            FROM
                PhieuTDNBSauKhiMo24h P
            left join nhanvien aa on P.TenDDTheoDoi_1 = aa.manhanvien 
            left join nhanvien bb on P.TenDDTheoDoi_2 = bb.manhanvien
            left join nhanvien cc on P.TenDDTheoDoi_3 = cc.manhanvien
            left join nhanvien dd on P.TenDDTheoDoi_4 = dd.manhanvien
            left join nhanvien ee on P.TenDDTheoDoi_5 = ee.manhanvien
            left join nhanvien ff on P.TenDDTheoDoi_6 = ff.manhanvien
            left join nhanvien gg on P.TenDDTheoDoi_7 = gg.manhanvien
            left join nhanvien hh on P.TenDDTheoDoi_8 = hh.manhanvien
            left join nhanvien ii on P.TenDDTheoDoi_9 = ii.manhanvien
            left join nhanvien jj on P.TenDDTheoDoi_10 = jj.manhanvien
            left join nhanvien kk on P.TenDDTheoDoi_11 = kk.manhanvien
            left join nhanvien ll on P.TenDDTheoDoi_12 = ll.manhanvien
            left join nhanvien qq on P.TenDDTheoDoi_13 = qq.manhanvien
            left join nhanvien ww on P.TenDDTheoDoi_14 = ww.manhanvien
            left join nhanvien mm on P.TenDDTheoDoi_15 = mm.manhanvien
            left join nhanvien rr on P.TenDDTheoDoi_16 = rr.manhanvien
            left join nhanvien tt on P.TenDDTheoDoi_17 = tt.manhanvien
            left join nhanvien yy on P.TenDDTheoDoi_18 = yy.manhanvien
            left join nhanvien uu on P.TenDDTheoDoi_19 = uu.manhanvien
            left join nhanvien zz on P.TenDDTheoDoi_20 = zz.manhanvien
            left join nhanvien xx on P.TenDDTheoDoi_21 = xx.manhanvien
            left join nhanvien vv on P.TenDDTheoDoi_22 = vv.manhanvien
            WHERE
                P.ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "BK");

            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));
            ds.Tables[0].AddColumn("NamSinh", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(string));
            ds.Tables[0].AddColumn("SOYTE", typeof(string));
            ds.Tables[0].AddColumn("BENHVIEN", typeof(string));
            ds.Tables[0].AddColumn("KHOA", typeof(string));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["NamSinh"] = XemBenhAn._HanhChinhBenhNhan.NgaySinh.HasValue ? XemBenhAn._HanhChinhBenhNhan.NgaySinh.Value.Year + "" : "";
            ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            ds.Tables[0].Rows[0]["SOYTE"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["KHOA"] = XemBenhAn._ThongTinDieuTri.Khoa;

            return ds;
        }
    }
}
