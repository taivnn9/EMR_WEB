using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class BaoCaoTaiBienTruyenMau : ThongTinKy
    {
        public BaoCaoTaiBienTruyenMau()
        {
            TableName = "BaoCaoTaiBienTruyenMau";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BCTBTM;
            TenMauPhieu = DanhMucPhieu.BCTBTM.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Nhóm máu hệ ABO")]
        public string ABO { get; set; }
        [MoTaDuLieu("Rh")]
        public string Rh { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Giường")]
		public string Giuong { get; set; }
        [MoTaDuLieu("Giờ truyền máu")]
        public DateTime? NgayTruyenMau_Gio { get; set; }
        [MoTaDuLieu("Ngày truyền máu")]
        public DateTime? NgayTruyenMau { get; set; }
        [MoTaDuLieu("Tên người cho máu/Mã số đơn vị máu")]
        public string TenNguoiChoMau { get; set; }
        [MoTaDuLieu("Loại chế phẩm máu")]
        public string LoaiChePhamMau { get; set; }
        [MoTaDuLieu("Thể tích đơn vị(ml)")]
        public string TheTichDonVi { get; set; }
        [MoTaDuLieu("Tốc độ truyền(giọt/phút)")]
        public string TocDoTruyen { get; set; }
        [MoTaDuLieu("Ngừng truyền lúc")]
        public DateTime? NgungTruyenLuc { get; set; }
        [MoTaDuLieu("Thể tíchd đã truyền(ml)")]
        public string TheTichDaTruyen { get; set; }
        [MoTaDuLieu("Nhóm máu hệ ABO")]
        public string NhomMauHeABO { get; set; }
        [MoTaDuLieu("Nhóm máu hệ Rh")]
        public string NhomMauHeRh { get; set; }
        [MoTaDuLieu("Ngày lấy máu")]
        public DateTime? NgayLayMau { get; set; }
        [MoTaDuLieu("Hạn sử dụng")]
        public string HanSuDung { get; set; }
        [MoTaDuLieu("Tên cơ sở lấy máu")]
        public string TenCoSo { get; set; }
        [MoTaDuLieu("Các loại dung dịch")]
        public string LoaiDungDich { get; set; }
        [MoTaDuLieu("Dấu hiệu đầu tiên")]
        public string DauHieuDauTien { get; set; }
        [MoTaDuLieu("Thời điểm xuất hiện dấu hiệu đầu tiên: giờ")]
        public DateTime? ThoiDiemXuatHien_Gio { get; set; }
        [MoTaDuLieu("Thời điểm xuất hiện dấu hiệu đầu tiên: ngày")]
        public DateTime? ThoiDiemXuatHien { get; set; }
        [MoTaDuLieu("Diễn biến và xử trí đã thực hiện")]
        public string DienBien { get; set; }
        [MoTaDuLieu("Máu người bệnh")]
        public string MauNguoiBenh { get; set; }
        [MoTaDuLieu("Đơn vị truyền máu")]
        public string DonViTruyenMau { get; set; }
        [MoTaDuLieu("Thời điểm lấy máu: giờ")]
        public DateTime? ThoiDiemLayMau_Gio { get; set; }
        [MoTaDuLieu("Thời điểm lấy máu: ngày")]
        public DateTime? ThoiDiemLayMau { get; set; }
        [MoTaDuLieu("Thời gian báo cáo: giờ")]
        public DateTime? ThoiGianBaoCao_Gio { get; set; }
        [MoTaDuLieu("Thời gian báo cáo: ngày")]
        public DateTime? ThoiGianBaoCao { get; set; }
        [MoTaDuLieu("Mã bác sỹ")]
		public string MaBacSi { get; set; }
        [MoTaDuLieu("Họ tên bác sỹ")]
		public string BacSi { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuong { get; set; }
        [MoTaDuLieu("Mã điều dưỡng")]
		public string MaDieuDuong { get; set; }
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
    public class BaoCaoTaiBienTruyenMauFunc
    {
        public const string TableName = "BaoCaoTaiBienTruyenMau";
        public const string TablePrimaryKeyName = "ID";
        public static List<BaoCaoTaiBienTruyenMau> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BaoCaoTaiBienTruyenMau> list = new List<BaoCaoTaiBienTruyenMau>();
            try
            {
                string sql = @"SELECT * FROM BaoCaoTaiBienTruyenMau where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    BaoCaoTaiBienTruyenMau data = new BaoCaoTaiBienTruyenMau();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.TenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.ABO = DataReader["ABO"].ToString();
                    data.Rh = DataReader["Rh"].ToString();
                    data.Khoa = DataReader["Khoa"].ToString();
                    data.Giuong = DataReader["Giuong"].ToString();
                    data.NgayTruyenMau = Convert.ToDateTime(DataReader["NgayTruyenMau"] == DBNull.Value ? DateTime.Now : DataReader["NgayTruyenMau"]);
                    data.NgayTruyenMau_Gio = data.NgayTruyenMau;
                    data.TenNguoiChoMau = DataReader["TenNguoiChoMau"].ToString();
                    data.LoaiChePhamMau = DataReader["LoaiChePhamMau"].ToString();
                    data.TheTichDonVi = DataReader["TheTichDonVi"].ToString();
                    data.TocDoTruyen = DataReader["TocDoTruyen"].ToString();
                    data.NgungTruyenLuc = Convert.ToDateTime(DataReader["NgungTruyenLuc"] == DBNull.Value ? DateTime.Now : DataReader["NgungTruyenLuc"]);
                    data.TheTichDaTruyen = DataReader["TheTichDaTruyen"].ToString();
                    data.NhomMauHeABO = DataReader["NhomMauHeABO"].ToString();
                    data.NhomMauHeRh = DataReader["NhomMauHeRh"].ToString();
                    data.NgayLayMau = Convert.ToDateTime(DataReader["NgayLayMau"] == DBNull.Value ? DateTime.Now : DataReader["NgayLayMau"]);

                    data.HanSuDung = DataReader["HanSuDung"].ToString();
                    data.TenCoSo = DataReader["TenCoSo"].ToString();
                    data.LoaiDungDich = DataReader["LoaiDungDich"].ToString();
                    data.DauHieuDauTien = DataReader["DauHieuDauTien"].ToString();
                    data.ThoiDiemXuatHien = Convert.ToDateTime(DataReader["ThoiDiemXuatHien"] == DBNull.Value ? DateTime.Now : DataReader["ThoiDiemXuatHien"]);
                    data.ThoiDiemXuatHien_Gio = data.ThoiDiemXuatHien;
                    data.DienBien = DataReader["DienBien"].ToString();
                    data.MauNguoiBenh = DataReader["MauNguoiBenh"].ToString();
                    data.DonViTruyenMau = DataReader["DonViTruyenMau"].ToString();
                    data.ThoiDiemLayMau = Convert.ToDateTime(DataReader["ThoiDiemLayMau"] == DBNull.Value ? DateTime.Now : DataReader["ThoiDiemLayMau"]);
                    data.ThoiDiemLayMau_Gio = data.ThoiDiemLayMau;

                    data.ThoiGianBaoCao = Convert.ToDateTime(DataReader["ThoiGianBaoCao"] == DBNull.Value ? DateTime.Now : DataReader["ThoiGianBaoCao"]);
                    data.ThoiGianBaoCao_Gio = data.ThoiGianBaoCao;

                    data.BacSi = DataReader["BacSi"].ToString();
                    data.MaBacSi = DataReader["MaBacSi"].ToString();
                    data.DieuDuong = DataReader["DieuDuong"].ToString();
                    data.MaDieuDuong = DataReader["MaDieuDuong"].ToString();

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BaoCaoTaiBienTruyenMau bangKe)
        {
            try
            {
                string sql = @"INSERT INTO BaoCaoTaiBienTruyenMau
                (
                    MAQUANLY,
                    ChanDoan,
                    ABO,
                    Rh,
                    Khoa,
                    Giuong,
                    NgayTruyenMau,
                    TenNguoiChoMau,
                    LoaiChePhamMau,
                    TheTichDonVi,
                    TocDoTruyen,
                    NgungTruyenLuc,
                    TheTichDaTruyen,
                    NhomMauHeABO,
                    NhomMauHeRh,
                    NgayLayMau,
                    HanSuDung,
                    TenCoSo,
                    LoaiDungDich,
                    DauHieuDauTien,
                    ThoiDiemXuatHien,
                    DienBien,
                    MauNguoiBenh,
                    DonViTruyenMau,
                    ThoiDiemLayMau,
                    ThoiGianBaoCao,
                    BacSi,
                    MaBacSi,
                    DieuDuong,
                    MaDieuDuong,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :ChanDoan,
                    :ABO,
                    :Rh,
                    :Khoa,
                    :Giuong,
                    :NgayTruyenMau,
                    :TenNguoiChoMau,
                    :LoaiChePhamMau,
                    :TheTichDonVi,
                    :TocDoTruyen,
                    :NgungTruyenLuc,
                    :TheTichDaTruyen,
                    :NhomMauHeABO,
                    :NhomMauHeRh,
                    :NgayLayMau,
                    :HanSuDung,
                    :TenCoSo,
                    :LoaiDungDich,
                    :DauHieuDauTien,
                    :ThoiDiemXuatHien,
                    :DienBien,
                    :MauNguoiBenh,
                    :DonViTruyenMau,
                    :ThoiDiemLayMau,
                    :ThoiGianBaoCao,
                    :BacSi,
                    :MaBacSi,
                    :DieuDuong,
                    :MaDieuDuong,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (bangKe.ID != 0)
                {
                    sql = @"UPDATE BaoCaoTaiBienTruyenMau SET 
                    MAQUANLY = :MAQUANLY,
                    ChanDoan = :ChanDoan,
                    ABO = :ABO,
                    Rh = :Rh,
                    Khoa = :Khoa,
                    Giuong = :Giuong,
                    NgayTruyenMau = :NgayTruyenMau,
                    TenNguoiChoMau = :TenNguoiChoMau,
                    LoaiChePhamMau = :LoaiChePhamMau,
                    TheTichDonVi = :TheTichDonVi,
                    TocDoTruyen = :TocDoTruyen,
                    NgungTruyenLuc = :NgungTruyenLuc,
                    TheTichDaTruyen = :TheTichDaTruyen,
                    NhomMauHeABO = :NhomMauHeABO,
                    NhomMauHeRh = :NhomMauHeRh,
                    NgayLayMau = :NgayLayMau,
                    HanSuDung = :HanSuDung,
                    TenCoSo = :TenCoSo,
                    LoaiDungDich = :LoaiDungDich,
                    DauHieuDauTien = :DauHieuDauTien,
                    ThoiDiemXuatHien = :ThoiDiemXuatHien,
                    DienBien = :DienBien,
                    MauNguoiBenh = :MauNguoiBenh,
                    DonViTruyenMau = :DonViTruyenMau,
                    ThoiDiemLayMau = :ThoiDiemLayMau,
                    ThoiGianBaoCao = :ThoiGianBaoCao,
                    BacSi = :BacSi,
                    MaBacSi = :MaBacSi,
                    DieuDuong = :DieuDuong,
                    MaDieuDuong = :MaDieuDuong,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + bangKe.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangKe.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", bangKe.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("ABO", bangKe.ABO));
                Command.Parameters.Add(new MDB.MDBParameter("Rh", bangKe.Rh));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa", bangKe.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("Giuong", bangKe.Giuong));
                DateTime? NgayTruyenMau = bangKe.NgayTruyenMau.HasValue ? bangKe.NgayTruyenMau.Value.Date : (DateTime?)null;
                var NgayTruyenMauFull = NgayTruyenMau;
                if (NgayTruyenMau != null)
                {
                    var NgayTruyenMau_Gio = bangKe.NgayTruyenMau_Gio.HasValue ? bangKe.NgayTruyenMau_Gio.Value.TimeOfDay : new TimeSpan(0, 0, 0);
                    NgayTruyenMauFull = NgayTruyenMau + NgayTruyenMau_Gio;
                }
                Command.Parameters.Add(new MDB.MDBParameter("NgayTruyenMau", NgayTruyenMauFull));
                Command.Parameters.Add(new MDB.MDBParameter("TenNguoiChoMau", bangKe.TenNguoiChoMau));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiChePhamMau", bangKe.LoaiChePhamMau));
                Command.Parameters.Add(new MDB.MDBParameter("TheTichDonVi", bangKe.TheTichDonVi));
                Command.Parameters.Add(new MDB.MDBParameter("TocDoTruyen", bangKe.TocDoTruyen));
                Command.Parameters.Add(new MDB.MDBParameter("NgungTruyenLuc", bangKe.NgungTruyenLuc));
                Command.Parameters.Add(new MDB.MDBParameter("TheTichDaTruyen", bangKe.TheTichDaTruyen));
                Command.Parameters.Add(new MDB.MDBParameter("NhomMauHeABO", bangKe.NhomMauHeABO));
                Command.Parameters.Add(new MDB.MDBParameter("NhomMauHeRh", bangKe.NhomMauHeRh));
                Command.Parameters.Add(new MDB.MDBParameter("NgayLayMau", bangKe.NgayLayMau));
                Command.Parameters.Add(new MDB.MDBParameter("HanSuDung", bangKe.HanSuDung));
                Command.Parameters.Add(new MDB.MDBParameter("TenCoSo", bangKe.TenCoSo));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiDungDich", bangKe.LoaiDungDich));
                Command.Parameters.Add(new MDB.MDBParameter("DauHieuDauTien", bangKe.DauHieuDauTien));
                DateTime? ThoiDiemXuatHien = bangKe.ThoiDiemXuatHien.HasValue ? bangKe.ThoiDiemXuatHien.Value.Date : (DateTime?)null;
                var ThoiDiemXuatHienFull = ThoiDiemXuatHien;
                if (ThoiDiemXuatHien != null)
                {
                    var ThoiDiemXuatHien_Gio = bangKe.ThoiDiemXuatHien_Gio.HasValue ? bangKe.ThoiDiemXuatHien_Gio.Value.TimeOfDay : new TimeSpan(0, 0, 0);
                    ThoiDiemXuatHienFull = ThoiDiemXuatHien + ThoiDiemXuatHien_Gio;
                }
                Command.Parameters.Add(new MDB.MDBParameter("ThoiDiemXuatHien", ThoiDiemXuatHienFull));
                Command.Parameters.Add(new MDB.MDBParameter("DienBien", bangKe.DienBien));
                Command.Parameters.Add(new MDB.MDBParameter("MauNguoiBenh", bangKe.MauNguoiBenh));
                Command.Parameters.Add(new MDB.MDBParameter("DonViTruyenMau", bangKe.DonViTruyenMau));
                DateTime? ThoiDiemLayMau = bangKe.ThoiDiemLayMau.HasValue ? bangKe.ThoiDiemLayMau.Value.Date : (DateTime?)null;
                var ThoiDiemLayMauFull = ThoiDiemLayMau;
                if (ThoiDiemLayMau != null)
                {
                    var ThoiDiemLayMau_Gio = bangKe.ThoiDiemLayMau_Gio.HasValue ? bangKe.ThoiDiemLayMau_Gio.Value.TimeOfDay : new TimeSpan(0, 0, 0);
                    ThoiDiemLayMauFull = ThoiDiemLayMau + ThoiDiemLayMau_Gio;
                }
                Command.Parameters.Add(new MDB.MDBParameter("ThoiDiemLayMau", ThoiDiemLayMauFull));
                DateTime? ThoiGianBaoCao = bangKe.ThoiGianBaoCao.HasValue ? bangKe.ThoiGianBaoCao.Value.Date : (DateTime?)null;
                var ThoiGianBaoCaoFull = ThoiGianBaoCao;
                if (ThoiGianBaoCao != null)
                {
                    var ThoiGianBaoCao_Gio = bangKe.ThoiGianBaoCao_Gio.HasValue ? bangKe.ThoiGianBaoCao_Gio.Value.TimeOfDay : new TimeSpan(0, 0, 0);
                    ThoiGianBaoCaoFull = ThoiGianBaoCao + ThoiGianBaoCao_Gio;
                }
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianBaoCao", ThoiGianBaoCaoFull));
                Command.Parameters.Add(new MDB.MDBParameter("BacSi", bangKe.BacSi));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSi", bangKe.MaBacSi));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuong", bangKe.DieuDuong));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuong", bangKe.MaDieuDuong));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", bangKe.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", bangKe.NgaySua));
                if (bangKe.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", bangKe.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", bangKe.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", bangKe.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (bangKe.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    bangKe.ID = nextval;
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
                string sql = "DELETE FROM BaoCaoTaiBienTruyenMau WHERE ID = :ID";
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
                *
            FROM
                BaoCaoTaiBienTruyenMau B
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);

            var ds = new DataSet();

            adt.Fill(ds, "TB");
            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(string));
            ds.Tables[0].AddColumn("BenhVien", typeof(string));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            ds.Tables[0].Rows[0]["BenhVien"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;

            return ds;

        }
    }
}
