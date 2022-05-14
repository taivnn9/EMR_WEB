
using EMR.KyDienTu;
using Newtonsoft.Json;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuDieuDuongSotXuatHuyet : ThongTinKy
    {
        public PhieuDieuDuongSotXuatHuyet()
        {
            TableName = "PhieuDDSotXuatHuyet";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PDDSXH;
            TenMauPhieu = DanhMucPhieu.PDDSXH.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Sở Y Tế")]
		public string SoYTe { get; set; }
        [MoTaDuLieu("Bệnh viện")]
		public string BenhVien { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Cân nặng")]
		public string CanNang { get; set; }
        [MoTaDuLieu("Chiều cao")]
		public string ChieuCao { get; set; }
        public DateTime? ThoiGian { get; set; }

        [MoTaDuLieu("Mã điều dưỡng")]
		public string MaDieuDuong1 { get; set; }
        [MoTaDuLieu("Mã điều dưỡng")]
		public string MaDieuDuong2 { get; set; }
        [MoTaDuLieu("Mã điều dưỡng")]
		public string MaDieuDuong3 { get; set; }
        [MoTaDuLieu("Mã điều dưỡng")]
		public string MaDieuDuong4 { get; set; }
        [MoTaDuLieu("Mã điều dưỡng")]
		public string MaDieuDuong5 { get; set; }
        [MoTaDuLieu("Mã điều dưỡng")]
		public string MaDieuDuong6 { get; set; }
        [MoTaDuLieu("Mã điều dưỡng")]
		public string MaDieuDuong7 { get; set; }
        [MoTaDuLieu("Mã điều dưỡng")]
		public string MaDieuDuong8 { get; set; }
        [MoTaDuLieu("Mã điều dưỡng")]
		public string MaDieuDuong9 { get; set; }
        [MoTaDuLieu("Mã điều dưỡng")]
		public string MaDieuDuong10 { get; set; }
        [MoTaDuLieu("Mã điều dưỡng")]
		public string MaDieuDuong11 { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuong1 { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuong2 { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuong3 { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuong4 { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuong5 { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuong6 { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuong7 { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuong8 { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuong9 { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuong10 { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuong11 { get; set; }
        public string LoaiDD { get; set; }
        public string SoLuongDD { get; set; }
        public string GavageDD { get; set; }
        public string DinhDuong1 { get; set; }
        public string DinhDuong2 { get; set; }
        public string DinhDuong3 { get; set; }
        public string DinhDuong4 { get; set; }
        public string DinhDuong5 { get; set; }
        [MoTaDuLieu("Nước tiểu")]
		public string NuocTieu { get; set; }
        public string SoLuongNT { get; set; }
        public string TinhChatNT { get; set; }
        [MoTaDuLieu("Nước tiểu")]
		public string NuocTieu1 { get; set; }
        [MoTaDuLieu("Nước tiểu 2")]
		public string NuocTieu2 { get; set; }
        [MoTaDuLieu("Nước tiểu 3")]
		public string NuocTieu3 { get; set; }
        [MoTaDuLieu("Nước tiểu 4")]
		public string NuocTieu4 { get; set; }
        [MoTaDuLieu("Nước tiểu 5")]
		public string NuocTieu5 { get; set; }
        public string Phan { get; set; }
        public string SoLanPhan { get; set; }
        public string TinhChatPhan { get; set; }
        public string Phan1 { get; set; }
        public string Phan2 { get; set; }
        public string Phan3 { get; set; }
        public string Phan4 { get; set; }
        public string Phan5 { get; set; }
        public string DichDaDay { get; set; }
        public string SoLuongDDD { get; set; }
        public string TinhChatDDD { get; set; }
        public string DichDaDay1 { get; set; }
        public string DichDaDay2 { get; set; }
        public string DichDaDay3 { get; set; }
        public string DichDaDay4 { get; set; }
        public string DichDaDay5 { get; set; }
        public bool[] TongNhapArray { get; } = new bool[] { false, false };
        public int TongNhap
        {
            get
            {
                return Array.IndexOf(TongNhapArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < TongNhapArray.Length; i++)
                {
                    if (i == (value - 1)) TongNhapArray[i] = true;
                    else TongNhapArray[i] = false;
                }
            }
        }

        public string TongNhapText { get; set; }
        public string SuaNhap { get; set; }
        public string BotNhap { get; set; }
        public string ChaoComNhap { get; set; }
        public string DichChuyenNhap { get; set; }
        public string MauNhap { get; set; }
        public string KhacNhap { get; set; }
        public bool[] TongXuatArray { get; } = new bool[] { false, false };
        public int TongXuat
        {
            get
            {
                return Array.IndexOf(TongXuatArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < TongXuatArray.Length; i++)
                {
                    if (i == (value - 1)) TongXuatArray[i] = true;
                    else TongXuatArray[i] = false;
                }
            }
        }

        public string TongXuatText { get; set; }
        public string PhanXuat { get; set; }
        [MoTaDuLieu("Nước tiểu xuất")]
		public string NuocTieuXuat { get; set; }
        public string DichDaDayXuat { get; set; }
        public string KhacXuat { get; set; }
        public string LuuY { get; set; }
        public string BanGiao { get; set; }
        public string GhiChu1 { get; set; }
        public string GhiChu2 { get; set; }
        public string LuuYChamSoc { get; set; }
        public string ThuocHeader1 { get; set; }
        public string ThuocHeader2 { get; set; }
        public string ThuocHeader3 { get; set; }
        public string ThuocHeader4 { get; set; }
        public string ThuocHeader5 { get; set; }
        public string LamSang_Ngay1 { get; set; }
        public string LamSang_Ngay2 { get; set; }
        public string LamSang_Ngay3 { get; set; }
        public string LamSang_Ngay4 { get; set; }
        public string LamSang_Ngay5 { get; set; }
        public string LamSang_Ngay6 { get; set; }
        public string LamSang_Gio1 { get; set; }
        public string LamSang_Gio2 { get; set; }
        public string LamSang_Gio3 { get; set; }
        public string LamSang_Gio4 { get; set; }
        public string LamSang_Gio5 { get; set; }
        public string LamSang_Gio6 { get; set; }
        public string CSHeader1 { get; set; }
        public string CSHeader2 { get; set; }
        public string CSHeader3 { get; set; }
        public string CSHeader4 { get; set; }
        public string CSHeader5 { get; set; }
        public string CSHeader6 { get; set; }
        public string HHHeader1 { get; set; }
        public string HHHeader2 { get; set; }
        public string HHHeader3 { get; set; }
        public string HHHeader4 { get; set; }
        public string HHHeader5 { get; set; }
        public string HHHeader6 { get; set; }

        public ObservableCollection<ThuocDichTruyenXuatHuyet> ListThuoc { get; set; }
        public ObservableCollection<DanhGiaLamSang> ListDanhGia { get; set; }
        public ObservableCollection<ChamSocXuatHuyet> ListChamSoc { get; set; }
        public ObservableCollection<HoHapXuatHuyet> ListHoHap { get; set; }

        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        //public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
    }

    public class ThuocDichTruyenXuatHuyet
    {
        public string Gio { get; set; }
        public string Thuoc1 { get; set; }
        public string Thuoc2 { get; set; }
        public string Thuoc3 { get; set; }
        public string Thuoc4 { get; set; }
        public string Thuoc5 { get; set; }

    }

    public class DanhGiaLamSang
    {
        public string NgayGio { get; set; }
        public string LamSang1 { get; set; }
        public string LamSang2 { get; set; }
        public string LamSang3 { get; set; }
        public string LamSang4 { get; set; }
        public string LamSang5 { get; set; }
        public string LamSang6 { get; set; }

    }
    public class ChamSocXuatHuyet
    {
        public string XetNghiemCS { get; set; }
        public string ChamSoc1 { get; set; }
        public string ChamSoc2 { get; set; }
        public string ChamSoc3 { get; set; }
        public string ChamSoc4 { get; set; }
        public string ChamSoc5 { get; set; }
        public string ChamSoc6 { get; set; }

    }
    public class HoHapXuatHuyet
    {
        public string XetNghiemHH { get; set; }
        public string HoHap1 { get; set; }
        public string HoHap2 { get; set; }
        public string HoHap3 { get; set; }
        public string HoHap4 { get; set; }
        public string HoHap5 { get; set; }
        public string HoHap6 { get; set; }

    }
    public class PhieuDieuDuongSotXuatHuyetFunc
    {
        public const string TableName = "PhieuDDSotXuatHuyet";
        public const string TablePrimaryKeyName = "ID";

        public static List<PhieuDieuDuongSotXuatHuyet> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuDieuDuongSotXuatHuyet> list = new List<PhieuDieuDuongSotXuatHuyet>();
            try
            {
                string sql = @"SELECT * FROM PhieuDDSotXuatHuyet where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuDieuDuongSotXuatHuyet data = new PhieuDieuDuongSotXuatHuyet();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;

                    data.MaBenhNhan = XemBenhAn._HanhChinhBenhNhan.MaBenhNhan;
                    data.TenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.SoYTe = XemBenhAn._HanhChinhBenhNhan.SoYTe;
                    data.BenhVien = XemBenhAn._HanhChinhBenhNhan.BenhVien;

                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.CanNang = DataReader["CanNang"].ToString();
                    data.ChieuCao = DataReader["ChieuCao"].ToString();
                    data.MaDieuDuong1 = DataReader["MaDieuDuong1"].ToString();
                    data.MaDieuDuong2 = DataReader["MaDieuDuong2"].ToString();
                    data.MaDieuDuong3 = DataReader["MaDieuDuong3"].ToString();
                    data.MaDieuDuong4 = DataReader["MaDieuDuong4"].ToString();
                    data.MaDieuDuong5 = DataReader["MaDieuDuong5"].ToString();
                    data.MaDieuDuong6 = DataReader["MaDieuDuong6"].ToString();
                    data.MaDieuDuong7 = DataReader["MaDieuDuong7"].ToString();
                    data.MaDieuDuong8 = DataReader["MaDieuDuong8"].ToString();
                    data.MaDieuDuong9 = DataReader["MaDieuDuong9"].ToString();
                    data.MaDieuDuong10 = DataReader["MaDieuDuong10"].ToString();
                    data.MaDieuDuong11 = DataReader["MaDieuDuong11"].ToString();
                    data.DieuDuong1 = DataReader["DieuDuong1"].ToString();
                    data.DieuDuong2 = DataReader["DieuDuong2"].ToString();
                    data.DieuDuong3 = DataReader["DieuDuong3"].ToString();
                    data.DieuDuong4 = DataReader["DieuDuong4"].ToString();
                    data.DieuDuong5 = DataReader["DieuDuong5"].ToString();
                    data.DieuDuong6 = DataReader["DieuDuong6"].ToString();
                    data.DieuDuong7 = DataReader["DieuDuong7"].ToString();
                    data.DieuDuong8 = DataReader["DieuDuong8"].ToString();
                    data.DieuDuong9 = DataReader["DieuDuong9"].ToString();
                    data.DieuDuong10 = DataReader["DieuDuong10"].ToString();
                    data.DieuDuong11 = DataReader["DieuDuong11"].ToString();

                    data.LoaiDD = DataReader["LoaiDD"].ToString();
                    data.SoLuongDD = DataReader["SoLuongDD"].ToString();
                    data.GavageDD = DataReader["GavageDD"].ToString();
                    data.DinhDuong1 = DataReader["DinhDuong1"].ToString();
                    data.DinhDuong2 = DataReader["DinhDuong2"].ToString();
                    data.DinhDuong3 = DataReader["DinhDuong3"].ToString();
                    data.DinhDuong4 = DataReader["DinhDuong4"].ToString();
                    data.DinhDuong5 = DataReader["DinhDuong5"].ToString();
                    data.NuocTieu = DataReader["NuocTieu"].ToString();
                    data.SoLuongNT = DataReader["SoLuongNT"].ToString();
                    data.TinhChatNT = DataReader["TinhChatNT"].ToString();
                    data.NuocTieu1 = DataReader["NuocTieu1"].ToString();
                    data.NuocTieu2 = DataReader["NuocTieu2"].ToString();
                    data.NuocTieu3 = DataReader["NuocTieu3"].ToString();
                    data.NuocTieu4 = DataReader["NuocTieu4"].ToString();
                    data.NuocTieu5 = DataReader["NuocTieu5"].ToString();
                    data.Phan = DataReader["Phan"].ToString();
                    data.SoLanPhan = DataReader["SoLanPhan"].ToString();
                    data.TinhChatPhan = DataReader["TinhChatPhan"].ToString();
                    data.Phan1 = DataReader["Phan1"].ToString();
                    data.Phan2 = DataReader["Phan2"].ToString();
                    data.Phan3 = DataReader["Phan3"].ToString();
                    data.Phan4 = DataReader["Phan4"].ToString();
                    data.Phan5 = DataReader["Phan5"].ToString();
                    data.DichDaDay = DataReader["DichDaDay"].ToString();
                    data.SoLuongDDD = DataReader["SoLuongDDD"].ToString();
                    data.TinhChatDDD = DataReader["TinhChatDDD"].ToString();
                    data.DichDaDay1 = DataReader["DichDaDay1"].ToString();
                    data.DichDaDay2 = DataReader["DichDaDay2"].ToString();
                    data.DichDaDay3 = DataReader["DichDaDay3"].ToString();
                    data.DichDaDay4 = DataReader["DichDaDay4"].ToString();
                    data.DichDaDay5 = DataReader["DichDaDay5"].ToString();
                    data.TongNhap = DataReader.GetInt("TongNhap");
                    data.TongNhapText = DataReader["TongNhapText"].ToString();
                    data.SuaNhap = DataReader["SuaNhap"].ToString();
                    data.BotNhap = DataReader["BotNhap"].ToString();
                    data.ChaoComNhap = DataReader["ChaoComNhap"].ToString();
                    data.DichChuyenNhap = DataReader["DichChuyenNhap"].ToString();
                    data.MauNhap = DataReader["MauNhap"].ToString();
                    data.KhacNhap = DataReader["KhacNhap"].ToString();
                    data.TongXuat = DataReader.GetInt("TongXuat");
                    data.TongXuatText = DataReader["TongXuatText"].ToString();
                    data.PhanXuat = DataReader["PhanXuat"].ToString();
                    data.NuocTieuXuat = DataReader["NuocTieuXuat"].ToString();
                    data.DichDaDayXuat = DataReader["DichDaDayXuat"].ToString();
                    data.KhacXuat = DataReader["KhacXuat"].ToString();
                    data.LuuY = DataReader["LuuY"].ToString();
                    data.BanGiao = DataReader["BanGiao"].ToString();
                    data.GhiChu1 = DataReader["GhiChu1"].ToString();
                    data.GhiChu2 = DataReader["GhiChu2"].ToString();
                    data.LuuYChamSoc = DataReader["LuuYChamSoc"].ToString();
                    data.ThuocHeader1 = DataReader["ThuocHeader1"].ToString();
                    data.ThuocHeader2 = DataReader["ThuocHeader2"].ToString();
                    data.ThuocHeader3 = DataReader["ThuocHeader3"].ToString();
                    data.ThuocHeader4 = DataReader["ThuocHeader4"].ToString();
                    data.ThuocHeader5 = DataReader["ThuocHeader5"].ToString();
                    data.LamSang_Ngay1 = DataReader["LamSang_Ngay1"].ToString();
                    data.LamSang_Ngay2 = DataReader["LamSang_Ngay2"].ToString();
                    data.LamSang_Ngay3 = DataReader["LamSang_Ngay3"].ToString();
                    data.LamSang_Ngay4 = DataReader["LamSang_Ngay4"].ToString();
                    data.LamSang_Ngay5 = DataReader["LamSang_Ngay5"].ToString();
                    data.LamSang_Ngay6 = DataReader["LamSang_Ngay6"].ToString();
                    data.LamSang_Gio1 = DataReader["LamSang_Gio1"].ToString();
                    data.LamSang_Gio2 = DataReader["LamSang_Gio2"].ToString();
                    data.LamSang_Gio3 = DataReader["LamSang_Gio3"].ToString();
                    data.LamSang_Gio4 = DataReader["LamSang_Gio4"].ToString();
                    data.LamSang_Gio5 = DataReader["LamSang_Gio5"].ToString();
                    data.LamSang_Gio6 = DataReader["LamSang_Gio6"].ToString();
                    data.CSHeader1 = DataReader["CSHeader1"].ToString();
                    data.CSHeader2 = DataReader["CSHeader2"].ToString();
                    data.CSHeader3 = DataReader["CSHeader3"].ToString();
                    data.CSHeader4 = DataReader["CSHeader4"].ToString();
                    data.CSHeader5 = DataReader["CSHeader5"].ToString();
                    data.CSHeader6 = DataReader["CSHeader6"].ToString();
                    data.HHHeader1 = DataReader["HHHeader1"].ToString();
                    data.HHHeader2 = DataReader["HHHeader2"].ToString();
                    data.HHHeader3 = DataReader["HHHeader3"].ToString();
                    data.HHHeader4 = DataReader["HHHeader4"].ToString();
                    data.HHHeader5 = DataReader["HHHeader5"].ToString();
                    data.HHHeader6 = DataReader["HHHeader6"].ToString();

                    data.ThoiGian = Convert.ToDateTime(DataReader["ThoiGian"] == DBNull.Value ? DateTime.Now : DataReader["ThoiGian"]);
                    data.ListThuoc = JsonConvert.DeserializeObject<ObservableCollection<ThuocDichTruyenXuatHuyet>>(DataReader["ListThuoc"].ToString());
                    data.ListChamSoc = JsonConvert.DeserializeObject<ObservableCollection<ChamSocXuatHuyet>>(DataReader["ListChamSoc"].ToString());
                    data.ListDanhGia = JsonConvert.DeserializeObject<ObservableCollection<DanhGiaLamSang>>(DataReader["ListDanhGia"].ToString());
                    data.ListHoHap = JsonConvert.DeserializeObject<ObservableCollection<HoHapXuatHuyet>>(DataReader["ListHoHap"].ToString());

                    data.NgayTao = Convert.ToDateTime(DataReader["NGAYTAO"] == DBNull.Value ? DateTime.Now : DataReader["NGAYTAO"]);
                    data.NguoiTao = DataReader["NGUOITAO"].ToString();
                    data.NgaySua = Convert.ToDateTime(DataReader["NGAYSUA"] == DBNull.Value ? DateTime.Now : DataReader["NGAYSUA"]);
                    data.NguoiSua = DataReader["NGUOISUA"].ToString();

                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;
                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool DeleteByIDPhieu(MDB.MDBConnection oracleConnection, decimal IDBienBan)
        {
            try
            {
                string sql = "";
                MDB.MDBCommand oracleCommand;
                sql = @"DELETE FROM PhieuDDSotXuatHuyet WHERE ID =" + IDBienBan;
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
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, long IDBienBan)
        {
            string sql = @"SELECT
                P.* 
            FROM
                PhieuDDSotXuatHuyet P
            WHERE
                ID = " + IDBienBan;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "TB");

            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(int));
            ds.Tables[0].AddColumn("SoYTe", typeof(string));
            ds.Tables[0].AddColumn("BenhVien", typeof(string));
            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh;
            ds.Tables[0].Rows[0]["SoYTe"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BenhVien"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;

            ObservableCollection<ThuocDichTruyenXuatHuyet> ListThuoc = JsonConvert.DeserializeObject<ObservableCollection<ThuocDichTruyenXuatHuyet>>(ds.Tables[0].Rows[0]["ListThuoc"].ToString());
            ObservableCollection<DanhGiaLamSang> ListDanhGia = JsonConvert.DeserializeObject<ObservableCollection<DanhGiaLamSang>>(ds.Tables[0].Rows[0]["ListDanhGia"].ToString());
            ObservableCollection<ChamSocXuatHuyet> ListChamSoc = JsonConvert.DeserializeObject<ObservableCollection<ChamSocXuatHuyet>>(ds.Tables[0].Rows[0]["ListChamSoc"].ToString());
            ObservableCollection<HoHapXuatHuyet> ListHoHap = JsonConvert.DeserializeObject<ObservableCollection<HoHapXuatHuyet>>(ds.Tables[0].Rows[0]["ListHoHap"].ToString());

            DataTable T = Common.ListToDataTable(ListThuoc, "T");
            DataTable DG = Common.ListToDataTable(ListDanhGia, "DG");
            DataTable CS = Common.ListToDataTable(ListChamSoc, "CS");
            DataTable HH = Common.ListToDataTable(ListHoHap, "HH");

            ds.Tables.Add(T);
            ds.Tables.Add(DG);
            ds.Tables.Add(CS);
            ds.Tables.Add(HH);

            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuDieuDuongSotXuatHuyet ketQua)
        {
            try
            {
                string sql = @"INSERT INTO PhieuDDSotXuatHuyet
                (
                    MaQuanLy,
                    ChanDoan,
                    CanNang,
                    ChieuCao,
                    ThoiGian,
                    MaDieuDuong1,
                    MaDieuDuong2,
                    MaDieuDuong3,
                    MaDieuDuong4,
                    MaDieuDuong5,
                    MaDieuDuong6,
                    MaDieuDuong7,
                    MaDieuDuong8,
                    MaDieuDuong9,
                    MaDieuDuong10,
                    MaDieuDuong11,
                    DieuDuong1,
                    DieuDuong2,
                    DieuDuong3,
                    DieuDuong4,
                    DieuDuong5,
                    DieuDuong6,
                    DieuDuong7,
                    DieuDuong8,
                    DieuDuong9,
                    DieuDuong10,
                    DieuDuong11,
                    LoaiDD,
                    SoLuongDD,
                    GavageDD,
                    DinhDuong1,
                    DinhDuong2,
                    DinhDuong3,
                    DinhDuong4,
                    DinhDuong5,
                    NuocTieu,
                    SoLuongNT,
                    TinhChatNT,
                    NuocTieu1,
                    NuocTieu2,
                    NuocTieu3,
                    NuocTieu4,
                    NuocTieu5,
                    Phan,
                    SoLanPhan,
                    TinhChatPhan,
                    Phan1,
                    Phan2,
                    Phan3,
                    Phan4,
                    Phan5,
                    DichDaDay,
                    SoLuongDDD,
                    TinhChatDDD,
                    DichDaDay1,
                    DichDaDay2,
                    DichDaDay3,
                    DichDaDay4,
                    DichDaDay5,
                    TongNhap,
                    TongNhapText,
                    SuaNhap,
                    BotNhap,
                    ChaoComNhap,
                    DichChuyenNhap,
                    MauNhap,
                    KhacNhap,
                    TongXuat,
                    TongXuatText,
                    PhanXuat,
                    NuocTieuXuat,
                    DichDaDayXuat,
                    KhacXuat,
                    LuuY,
                    BanGiao,
                    GhiChu1,
                    GhiChu2,
                    LuuYChamSoc,
                    ThuocHeader1,
                    ThuocHeader2,
                    ThuocHeader3,
                    ThuocHeader4,
                    ThuocHeader5,
                    LamSang_Ngay1,
                    LamSang_Ngay2,
                    LamSang_Ngay3,
                    LamSang_Ngay4,
                    LamSang_Ngay5,
                    LamSang_Ngay6,
                    LamSang_Gio1,
                    LamSang_Gio2,
                    LamSang_Gio3,
                    LamSang_Gio4,
                    LamSang_Gio5,
                    LamSang_Gio6,
                    CSHeader1,
                    CSHeader2,
                    CSHeader3,
                    CSHeader4,
                    CSHeader5,
                    CSHeader6,
                    HHHeader1,
                    HHHeader2,
                    HHHeader3,
                    HHHeader4,
                    HHHeader5,
                    HHHeader6,
                    ListThuoc,
                    ListDanhGia,
                    ListChamSoc,
                    ListHoHap,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
                    :ChanDoan,
                    :CanNang,
                    :ChieuCao,
                    :ThoiGian,
                    :MaDieuDuong1,
                    :MaDieuDuong2,
                    :MaDieuDuong3,
                    :MaDieuDuong4,
                    :MaDieuDuong5,
                    :MaDieuDuong6,
                    :MaDieuDuong7,
                    :MaDieuDuong8,
                    :MaDieuDuong9,
                    :MaDieuDuong10,
                    :MaDieuDuong11,
                    :DieuDuong1,
                    :DieuDuong2,
                    :DieuDuong3,
                    :DieuDuong4,
                    :DieuDuong5,
                    :DieuDuong6,
                    :DieuDuong7,
                    :DieuDuong8,
                    :DieuDuong9,
                    :DieuDuong10,
                    :DieuDuong11,
                    :LoaiDD,
                    :SoLuongDD,
                    :GavageDD,
                    :DinhDuong1,
                    :DinhDuong2,
                    :DinhDuong3,
                    :DinhDuong4,
                    :DinhDuong5,
                    :NuocTieu,
                    :SoLuongNT,
                    :TinhChatNT,
                    :NuocTieu1,
                    :NuocTieu2,
                    :NuocTieu3,
                    :NuocTieu4,
                    :NuocTieu5,
                    :Phan,
                    :SoLanPhan,
                    :TinhChatPhan,
                    :Phan1,
                    :Phan2,
                    :Phan3,
                    :Phan4,
                    :Phan5,
                    :DichDaDay,
                    :SoLuongDDD,
                    :TinhChatDDD,
                    :DichDaDay1,
                    :DichDaDay2,
                    :DichDaDay3,
                    :DichDaDay4,
                    :DichDaDay5,
                    :TongNhap,
                    :TongNhapText,
                    :SuaNhap,
                    :BotNhap,
                    :ChaoComNhap,
                    :DichChuyenNhap,
                    :MauNhap,
                    :KhacNhap,
                    :TongXuat,
                    :TongXuatText,
                    :PhanXuat,
                    :NuocTieuXuat,
                    :DichDaDayXuat,
                    :KhacXuat,
                    :LuuY,
                    :BanGiao,
                    :GhiChu1,
                    :GhiChu2,
                    :LuuYChamSoc,
                    :ThuocHeader1,
                    :ThuocHeader2,
                    :ThuocHeader3,
                    :ThuocHeader4,
                    :ThuocHeader5,
                    :LamSang_Ngay1,
                    :LamSang_Ngay2,
                    :LamSang_Ngay3,
                    :LamSang_Ngay4,
                    :LamSang_Ngay5,
                    :LamSang_Ngay6,
                    :LamSang_Gio1,
                    :LamSang_Gio2,
                    :LamSang_Gio3,
                    :LamSang_Gio4,
                    :LamSang_Gio5,
                    :LamSang_Gio6,
                    :CSHeader1,
                    :CSHeader2,
                    :CSHeader3,
                    :CSHeader4,
                    :CSHeader5,
                    :CSHeader6,
                    :HHHeader1,
                    :HHHeader2,
                    :HHHeader3,
                    :HHHeader4,
                    :HHHeader5,
                    :HHHeader6,
                    :ListThuoc,
                    :ListDanhGia,
                    :ListChamSoc,
                    :ListHoHap,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE PhieuDDSotXuatHuyet SET 
                    MaQuanLy = :MaQuanLy,
                    ChanDoan = :ChanDoan,
                    CanNang = :CanNang,
                    ChieuCao = :ChieuCao,
                    ThoiGian = :ThoiGian,
                    MaDieuDuong1 = :MaDieuDuong1,
                    MaDieuDuong2 = :MaDieuDuong2,
                    MaDieuDuong3 = :MaDieuDuong3,
                    MaDieuDuong4 = :MaDieuDuong4,
                    MaDieuDuong5 = :MaDieuDuong5,
                    MaDieuDuong6 = :MaDieuDuong6,
                    MaDieuDuong7 = :MaDieuDuong7,
                    MaDieuDuong8 = :MaDieuDuong8,
                    MaDieuDuong9 = :MaDieuDuong9,
                    MaDieuDuong10 = :MaDieuDuong10,
                    MaDieuDuong11 = :MaDieuDuong11,
                    DieuDuong1 = :DieuDuong1,
                    DieuDuong2 = :DieuDuong2,
                    DieuDuong3 = :DieuDuong3,
                    DieuDuong4 = :DieuDuong4,
                    DieuDuong5 = :DieuDuong5,
                    DieuDuong6 = :DieuDuong6,
                    DieuDuong7 = :DieuDuong7,
                    DieuDuong8 = :DieuDuong8,
                    DieuDuong9 = :DieuDuong9,
                    DieuDuong10 = :DieuDuong10,
                    DieuDuong11 = :DieuDuong11,
                    LoaiDD = :LoaiDD,
                    SoLuongDD = :SoLuongDD,
                    GavageDD = :GavageDD,
                    DinhDuong1 = :DinhDuong1,
                    DinhDuong2 = :DinhDuong2,
                    DinhDuong3 = :DinhDuong3,
                    DinhDuong4 = :DinhDuong4,
                    DinhDuong5 = :DinhDuong5,
                    NuocTieu = :NuocTieu,
                    SoLuongNT = :SoLuongNT,
                    TinhChatNT = :TinhChatNT,
                    NuocTieu1 = :NuocTieu1,
                    NuocTieu2 = :NuocTieu2,
                    NuocTieu3 = :NuocTieu3,
                    NuocTieu4 = :NuocTieu4,
                    NuocTieu5 = :NuocTieu5,
                    Phan = :Phan,
                    SoLanPhan = :SoLanPhan,
                    TinhChatPhan = :TinhChatPhan,
                    Phan1 = :Phan1,
                    Phan2 = :Phan2,
                    Phan3 = :Phan3,
                    Phan4 = :Phan4,
                    Phan5 = :Phan5,
                    DichDaDay = :DichDaDay,
                    SoLuongDDD = :SoLuongDDD,
                    TinhChatDDD = :TinhChatDDD,
                    DichDaDay1 = :DichDaDay1,
                    DichDaDay2 = :DichDaDay2,
                    DichDaDay3 = :DichDaDay3,
                    DichDaDay4 = :DichDaDay4,
                    DichDaDay5 = :DichDaDay5,
                    TongNhap = :TongNhap,
                    TongNhapText = :TongNhapText,
                    SuaNhap = :SuaNhap,
                    BotNhap = :BotNhap,
                    ChaoComNhap = :ChaoComNhap,
                    DichChuyenNhap = :DichChuyenNhap,
                    MauNhap = :MauNhap,
                    KhacNhap = :KhacNhap,
                    TongXuat = :TongXuat,
                    TongXuatText = :TongXuatText,
                    PhanXuat = :PhanXuat,
                    NuocTieuXuat = :NuocTieuXuat,
                    DichDaDayXuat = :DichDaDayXuat,
                    KhacXuat = :KhacXuat,
                    LuuY = :LuuY,
                    BanGiao = :BanGiao,
                    GhiChu1 = :GhiChu1,
                    GhiChu2 = :GhiChu2,
                    LuuYChamSoc = :LuuYChamSoc,
                    ThuocHeader1 = :ThuocHeader1,
                    ThuocHeader2 = :ThuocHeader2,
                    ThuocHeader3 = :ThuocHeader3,
                    ThuocHeader4 = :ThuocHeader4,
                    ThuocHeader5 = :ThuocHeader5,
                    LamSang_Ngay1 = :LamSang_Ngay1,
                    LamSang_Ngay2 = :LamSang_Ngay2,
                    LamSang_Ngay3 = :LamSang_Ngay3,
                    LamSang_Ngay4 = :LamSang_Ngay4,
                    LamSang_Ngay5 = :LamSang_Ngay5,
                    LamSang_Ngay6 = :LamSang_Ngay6,
                    LamSang_Gio1 = :LamSang_Gio1,
                    LamSang_Gio2 = :LamSang_Gio2,
                    LamSang_Gio3 = :LamSang_Gio3,
                    LamSang_Gio4 = :LamSang_Gio4,
                    LamSang_Gio5 = :LamSang_Gio5,
                    LamSang_Gio6 = :LamSang_Gio6,
                    CSHeader1 = :CSHeader1,
                    CSHeader2 = :CSHeader2,
                    CSHeader3 = :CSHeader3,
                    CSHeader4 = :CSHeader4,
                    CSHeader5 = :CSHeader5,
                    CSHeader6 = :CSHeader6,
                    HHHeader1 = :HHHeader1,
                    HHHeader2 = :HHHeader2,
                    HHHeader3 = :HHHeader3,
                    HHHeader4 = :HHHeader4,
                    HHHeader5 = :HHHeader5,
                    HHHeader6 = :HHHeader6,
                    ListThuoc = :ListThuoc,
                    ListDanhGia = :ListDanhGia,
                    ListChamSoc = :ListChamSoc,
                    ListHoHap = :ListHoHap,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", ketQua.MaQuanLy));

                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", ketQua.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang", ketQua.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("ChieuCao", ketQua.ChieuCao));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGian", ketQua.ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("ListThuoc", JsonConvert.SerializeObject(ketQua.ListThuoc)));
                Command.Parameters.Add(new MDB.MDBParameter("ListDanhGia", JsonConvert.SerializeObject(ketQua.ListDanhGia)));
                Command.Parameters.Add(new MDB.MDBParameter("ListChamSoc", JsonConvert.SerializeObject(ketQua.ListChamSoc)));
                Command.Parameters.Add(new MDB.MDBParameter("ListHoHap", JsonConvert.SerializeObject(ketQua.ListHoHap)));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuong1", ketQua.MaDieuDuong1));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuong2", ketQua.MaDieuDuong2));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuong3", ketQua.MaDieuDuong3));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuong4", ketQua.MaDieuDuong4));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuong5", ketQua.MaDieuDuong5));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuong6", ketQua.MaDieuDuong6));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuong7", ketQua.MaDieuDuong7));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuong8", ketQua.MaDieuDuong8));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuong9", ketQua.MaDieuDuong9));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuong10", ketQua.MaDieuDuong10));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuong11", ketQua.MaDieuDuong11));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuong1", ketQua.DieuDuong1));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuong2", ketQua.DieuDuong2));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuong3", ketQua.DieuDuong3));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuong4", ketQua.DieuDuong4));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuong5", ketQua.DieuDuong5));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuong6", ketQua.DieuDuong6));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuong7", ketQua.DieuDuong7));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuong8", ketQua.DieuDuong8));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuong9", ketQua.DieuDuong9));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuong10", ketQua.DieuDuong10));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuong11", ketQua.DieuDuong11));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiDD", ketQua.LoaiDD));
                Command.Parameters.Add(new MDB.MDBParameter("SoLuongDD", ketQua.SoLuongDD));
                Command.Parameters.Add(new MDB.MDBParameter("GavageDD", ketQua.GavageDD));
                Command.Parameters.Add(new MDB.MDBParameter("DinhDuong1", ketQua.DinhDuong1));
                Command.Parameters.Add(new MDB.MDBParameter("DinhDuong2", ketQua.DinhDuong2));
                Command.Parameters.Add(new MDB.MDBParameter("DinhDuong3", ketQua.DinhDuong3));
                Command.Parameters.Add(new MDB.MDBParameter("DinhDuong4", ketQua.DinhDuong4));
                Command.Parameters.Add(new MDB.MDBParameter("DinhDuong5", ketQua.DinhDuong5));
                Command.Parameters.Add(new MDB.MDBParameter("NuocTieu", ketQua.NuocTieu));
                Command.Parameters.Add(new MDB.MDBParameter("SoLuongNT", ketQua.SoLuongNT));
                Command.Parameters.Add(new MDB.MDBParameter("TinhChatNT", ketQua.TinhChatNT));
                Command.Parameters.Add(new MDB.MDBParameter("NuocTieu1", ketQua.NuocTieu1));
                Command.Parameters.Add(new MDB.MDBParameter("NuocTieu2", ketQua.NuocTieu2));
                Command.Parameters.Add(new MDB.MDBParameter("NuocTieu3", ketQua.NuocTieu3));
                Command.Parameters.Add(new MDB.MDBParameter("NuocTieu4", ketQua.NuocTieu4));
                Command.Parameters.Add(new MDB.MDBParameter("NuocTieu5", ketQua.NuocTieu5));
                Command.Parameters.Add(new MDB.MDBParameter("Phan", ketQua.Phan));
                Command.Parameters.Add(new MDB.MDBParameter("SoLanPhan", ketQua.SoLanPhan));
                Command.Parameters.Add(new MDB.MDBParameter("TinhChatPhan", ketQua.TinhChatPhan));
                Command.Parameters.Add(new MDB.MDBParameter("Phan1", ketQua.Phan1));
                Command.Parameters.Add(new MDB.MDBParameter("Phan2", ketQua.Phan2));
                Command.Parameters.Add(new MDB.MDBParameter("Phan3", ketQua.Phan3));
                Command.Parameters.Add(new MDB.MDBParameter("Phan4", ketQua.Phan4));
                Command.Parameters.Add(new MDB.MDBParameter("Phan5", ketQua.Phan5));
                Command.Parameters.Add(new MDB.MDBParameter("DichDaDay", ketQua.DichDaDay));
                Command.Parameters.Add(new MDB.MDBParameter("SoLuongDDD", ketQua.SoLuongDDD));
                Command.Parameters.Add(new MDB.MDBParameter("TinhChatDDD", ketQua.TinhChatDDD));
                Command.Parameters.Add(new MDB.MDBParameter("DichDaDay1", ketQua.DichDaDay1));
                Command.Parameters.Add(new MDB.MDBParameter("DichDaDay2", ketQua.DichDaDay2));
                Command.Parameters.Add(new MDB.MDBParameter("DichDaDay3", ketQua.DichDaDay3));
                Command.Parameters.Add(new MDB.MDBParameter("DichDaDay4", ketQua.DichDaDay4));
                Command.Parameters.Add(new MDB.MDBParameter("DichDaDay5", ketQua.DichDaDay5));
                Command.Parameters.Add(new MDB.MDBParameter("TongNhap", ketQua.TongNhap));
                Command.Parameters.Add(new MDB.MDBParameter("TongNhapText", ketQua.TongNhapText));
                Command.Parameters.Add(new MDB.MDBParameter("SuaNhap", ketQua.SuaNhap));
                Command.Parameters.Add(new MDB.MDBParameter("BotNhap", ketQua.BotNhap));
                Command.Parameters.Add(new MDB.MDBParameter("ChaoComNhap", ketQua.ChaoComNhap));
                Command.Parameters.Add(new MDB.MDBParameter("DichChuyenNhap", ketQua.DichChuyenNhap));
                Command.Parameters.Add(new MDB.MDBParameter("MauNhap", ketQua.MauNhap));
                Command.Parameters.Add(new MDB.MDBParameter("KhacNhap", ketQua.KhacNhap));
                Command.Parameters.Add(new MDB.MDBParameter("TongXuat", ketQua.TongXuat));
                Command.Parameters.Add(new MDB.MDBParameter("TongXuatText", ketQua.TongXuatText));
                Command.Parameters.Add(new MDB.MDBParameter("PhanXuat", ketQua.PhanXuat));
                Command.Parameters.Add(new MDB.MDBParameter("NuocTieuXuat", ketQua.NuocTieuXuat));
                Command.Parameters.Add(new MDB.MDBParameter("DichDaDayXuat", ketQua.DichDaDayXuat));
                Command.Parameters.Add(new MDB.MDBParameter("KhacXuat", ketQua.KhacXuat));
                Command.Parameters.Add(new MDB.MDBParameter("LuuY", ketQua.LuuY));
                Command.Parameters.Add(new MDB.MDBParameter("BanGiao", ketQua.BanGiao));
                Command.Parameters.Add(new MDB.MDBParameter("GhiChu1", ketQua.GhiChu1));
                Command.Parameters.Add(new MDB.MDBParameter("GhiChu2", ketQua.GhiChu2));
                Command.Parameters.Add(new MDB.MDBParameter("LuuYChamSoc", ketQua.LuuYChamSoc));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocHeader1", ketQua.ThuocHeader1));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocHeader2", ketQua.ThuocHeader2));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocHeader3", ketQua.ThuocHeader3));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocHeader4", ketQua.ThuocHeader4));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocHeader5", ketQua.ThuocHeader5));
                Command.Parameters.Add(new MDB.MDBParameter("LamSang_Ngay1", ketQua.LamSang_Ngay1));
                Command.Parameters.Add(new MDB.MDBParameter("LamSang_Ngay2", ketQua.LamSang_Ngay2));
                Command.Parameters.Add(new MDB.MDBParameter("LamSang_Ngay3", ketQua.LamSang_Ngay3));
                Command.Parameters.Add(new MDB.MDBParameter("LamSang_Ngay4", ketQua.LamSang_Ngay4));
                Command.Parameters.Add(new MDB.MDBParameter("LamSang_Ngay5", ketQua.LamSang_Ngay5));
                Command.Parameters.Add(new MDB.MDBParameter("LamSang_Ngay6", ketQua.LamSang_Ngay6));
                Command.Parameters.Add(new MDB.MDBParameter("LamSang_Gio1", ketQua.LamSang_Gio1));
                Command.Parameters.Add(new MDB.MDBParameter("LamSang_Gio2", ketQua.LamSang_Gio2));
                Command.Parameters.Add(new MDB.MDBParameter("LamSang_Gio3", ketQua.LamSang_Gio3));
                Command.Parameters.Add(new MDB.MDBParameter("LamSang_Gio4", ketQua.LamSang_Gio4));
                Command.Parameters.Add(new MDB.MDBParameter("LamSang_Gio5", ketQua.LamSang_Gio5));
                Command.Parameters.Add(new MDB.MDBParameter("LamSang_Gio6", ketQua.LamSang_Gio6));
                Command.Parameters.Add(new MDB.MDBParameter("CSHeader1", ketQua.CSHeader1));
                Command.Parameters.Add(new MDB.MDBParameter("CSHeader2", ketQua.CSHeader2));
                Command.Parameters.Add(new MDB.MDBParameter("CSHeader3", ketQua.CSHeader3));
                Command.Parameters.Add(new MDB.MDBParameter("CSHeader4", ketQua.CSHeader4));
                Command.Parameters.Add(new MDB.MDBParameter("CSHeader5", ketQua.CSHeader5));
                Command.Parameters.Add(new MDB.MDBParameter("CSHeader6", ketQua.CSHeader6));
                Command.Parameters.Add(new MDB.MDBParameter("HHHeader1", ketQua.HHHeader1));
                Command.Parameters.Add(new MDB.MDBParameter("HHHeader2", ketQua.HHHeader2));
                Command.Parameters.Add(new MDB.MDBParameter("HHHeader3", ketQua.HHHeader3));
                Command.Parameters.Add(new MDB.MDBParameter("HHHeader4", ketQua.HHHeader4));
                Command.Parameters.Add(new MDB.MDBParameter("HHHeader5", ketQua.HHHeader5));
                Command.Parameters.Add(new MDB.MDBParameter("HHHeader6", ketQua.HHHeader6));

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
                XuLyLoi.LogError(ex);
            }
            return false;
        }
    }
}
