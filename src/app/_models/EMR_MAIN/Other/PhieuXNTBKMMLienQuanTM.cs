using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMR.KyDienTu;
using System.Collections.ObjectModel;
using PMS.Access;
using Newtonsoft.Json;
using System.Data;
using System.ComponentModel;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuXNTBKMMLienQuanTM : ThongTinKy
    {
        public PhieuXNTBKMMLienQuanTM()
        {
            TableName = "PhieuXNTBKMMLienQuanTM";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PXNTBKMMTM;
            TenMauPhieu = DanhMucPhieu.PXNTBKMMTM.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        public string HoTenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Nhóm máu")]
		public string NhomMau { get; set; }
        public string Rh { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }
        public string SoGiuong { get; set; }
        public string TenNguoiCho { get; set; }
        public string LoaiChePhamMau { get; set; }
        public string TheTichDonViMau { get; set; }
        public DateTime? ThoiDiemBatDau { get; set; }
        public DateTime? ThoiDiemBatDau_Gio{ get; set; }
        public DateTime? ThoiDiemXuatHien { get; set; }
        public DateTime? ThoiDiemXuatHien_Gio { get; set; }
        public DateTime? ThoiDiemNgungTruyen { get; set; }
        public DateTime? ThoiDiemNgungTruyen_Gio { get; set; }
        public string TheTichMauDaTruyen { get; set; }
        public DateTime? ThoiDiemNhanThongBao { get; set; }
        public DateTime? ThoiDiemNhanThongBao_Gio { get; set; }
        public ObservableCollection<KetQuaXetNghiemMau> KetQuas { get; set; }
        public string KetLuan { get; set; }
        public string NguoiPhuTrach { get; set; }
        public string MaNguoiPhuTrach { get; set; }
        public string KyThuatVien { get; set; }
        public string MaKyThuatVien { get; set; }

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
    public class KetQuaXetNghiemMau
    {
        public string KetQua { get; set; }
        [Description("????")]
        public string MauMauTT { get; set; }
        public string MauMauST { get; set; }
        public string MauMauGTB { get; set; }
    }
    public class PhieuXNTBKMMLienQuanTMFunc
    {
        public const string TableName = "PhieuXNTBKMMLienQuanTM";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuXNTBKMMLienQuanTM> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuXNTBKMMLienQuanTM> list = new List<PhieuXNTBKMMLienQuanTM>();
            try
            {
                string sql = @"SELECT * FROM PhieuXNTBKMMLienQuanTM where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuXNTBKMMLienQuanTM data = new PhieuXNTBKMMLienQuanTM();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.HoTenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.NhomMau = DataReader["NhomMau"].ToString();
                    data.Rh = DataReader["Rh"].ToString();
                    data.Khoa = DataReader["Khoa"].ToString();
                    data.MaKhoa = DataReader["MaKhoa"].ToString();
                    data.SoGiuong = DataReader["SoGiuong"].ToString();
                    data.TenNguoiCho = DataReader["TenNguoiCho"].ToString();
                    data.LoaiChePhamMau = DataReader["LoaiChePhamMau"].ToString();
                    data.TheTichDonViMau = DataReader["TheTichDonViMau"].ToString();
                    data.ThoiDiemBatDau = DataReader["ThoiDiemBatDau"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["ThoiDiemBatDau"].ToString()) : null;
                    data.ThoiDiemBatDau_Gio = data.ThoiDiemBatDau;
                    data.ThoiDiemXuatHien = DataReader["ThoiDiemXuatHien"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["ThoiDiemXuatHien"].ToString()) : null;
                    data.ThoiDiemXuatHien_Gio = data.ThoiDiemXuatHien;
                    data.ThoiDiemNgungTruyen = DataReader["ThoiDiemNgungTruyen"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["ThoiDiemNgungTruyen"].ToString()) : null;
                    data.ThoiDiemNgungTruyen_Gio = data.ThoiDiemNgungTruyen;
                    data.TheTichMauDaTruyen = DataReader["TheTichMauDaTruyen"].ToString();
                    data.ThoiDiemNhanThongBao = DataReader["ThoiDiemNhanThongBao"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["ThoiDiemNhanThongBao"].ToString()) : null;
                    data.ThoiDiemNhanThongBao_Gio = data.ThoiDiemNhanThongBao;

                    string KetQuas = DataReader["KetQuas_1"].ToString();
                    if (DataReader["KetQuas_2"] != DBNull.Value)
                        KetQuas += DataReader["KetQuas_2"].ToString();
                    data.KetQuas = JsonConvert.DeserializeObject<ObservableCollection<KetQuaXetNghiemMau>>(KetQuas);

                    data.KetLuan = DataReader["KetLuan"].ToString();
                    data.NguoiPhuTrach = DataReader["NguoiPhuTrach"].ToString();
                    data.MaNguoiPhuTrach = DataReader["MaNguoiPhuTrach"].ToString();

                    data.KyThuatVien = DataReader["KyThuatVien"].ToString();
                    data.MaKyThuatVien = DataReader["MaKyThuatVien"].ToString();

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuXNTBKMMLienQuanTM bangKe)
        {
            try
            {
                string sql = @"INSERT INTO PhieuXNTBKMMLienQuanTM
                (
                    MAQUANLY,
                    MaBenhNhan,
                    ChanDoan,
                    NhomMau,
                    Rh,
                    Khoa,
                    MaKhoa,
                    SoGiuong,
                    TenNguoiCho,
                    LoaiChePhamMau,
                    TheTichDonViMau,
                    ThoiDiemBatDau,
                    ThoiDiemXuatHien,
                    ThoiDiemNgungTruyen,
                    TheTichMauDaTruyen,
                    ThoiDiemNhanThongBao,
                    KetQuas_1,
                    KetQuas_2,
                    KetLuan,
                    NguoiPhuTrach,
                    MaNguoiPhuTrach,
                    KyThuatVien,
                    MaKyThuatVien,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :ChanDoan,
                    :NhomMau,
                    :Rh,
                    :Khoa,
                    :MaKhoa,
                    :SoGiuong,
                    :TenNguoiCho,
                    :LoaiChePhamMau,
                    :TheTichDonViMau,
                    :ThoiDiemBatDau,
                    :ThoiDiemXuatHien,
                    :ThoiDiemNgungTruyen,
                    :TheTichMauDaTruyen,
                    :ThoiDiemNhanThongBao,
                    :KetQuas_1,
                    :KetQuas_2,
                    :KetLuan,
                    :NguoiPhuTrach,
                    :MaNguoiPhuTrach,
                    :KyThuatVien,
                    :MaKyThuatVien,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (bangKe.ID != 0)
                {
                    sql = @"UPDATE PhieuXNTBKMMLienQuanTM SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    ChanDoan=:ChanDoan,
                    NhomMau=:NhomMau,
                    Rh=:Rh,
                    Khoa=:Khoa,
                    MaKhoa=:MaKhoa,
                    SoGiuong=:SoGiuong,
                    TenNguoiCho=:TenNguoiCho,
                    LoaiChePhamMau=:LoaiChePhamMau,
                    TheTichDonViMau=:TheTichDonViMau,
                    ThoiDiemBatDau=:ThoiDiemBatDau,
                    ThoiDiemXuatHien = :ThoiDiemXuatHien,
                    ThoiDiemNgungTruyen=:ThoiDiemNgungTruyen,
                    TheTichMauDaTruyen=:TheTichMauDaTruyen,
                    ThoiDiemNhanThongBao=:ThoiDiemNhanThongBao,
                    KetQuas_1=:KetQuas_1,
                    KetQuas_2=:KetQuas_2,
                    KetLuan=:KetLuan,
                    NguoiPhuTrach=:NguoiPhuTrach,
                    MaNguoiPhuTrach=:MaNguoiPhuTrach,
                    KyThuatVien=:KyThuatVien,
                    MaKyThuatVien=:MaKyThuatVien,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + bangKe.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangKe.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", bangKe.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", bangKe.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("NhomMau", bangKe.NhomMau));
                Command.Parameters.Add(new MDB.MDBParameter("Rh", bangKe.Rh));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa", bangKe.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaKhoa", bangKe.MaKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("SoGiuong", bangKe.SoGiuong));
                Command.Parameters.Add(new MDB.MDBParameter("TenNguoiCho", bangKe.TenNguoiCho));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiChePhamMau", bangKe.LoaiChePhamMau));
                Command.Parameters.Add(new MDB.MDBParameter("TheTichDonViMau", bangKe.TheTichDonViMau));

                DateTime? ThoiGian = bangKe.ThoiDiemBatDau.HasValue ? bangKe.ThoiDiemBatDau.Value.Date : (DateTime?)null;
                var ThoiGianFull = ThoiGian;
                if (ThoiGian != null)
                {
                    var ThoiGian_Gio = bangKe.ThoiDiemBatDau_Gio.HasValue ? bangKe.ThoiDiemBatDau_Gio.Value.TimeOfDay : new TimeSpan(0, 0, 0);
                    ThoiGianFull = ThoiGian + ThoiGian_Gio;
                }
                Command.Parameters.Add(new MDB.MDBParameter("ThoiDiemBatDau", ThoiGianFull));

                ThoiGian = bangKe.ThoiDiemXuatHien.HasValue ? bangKe.ThoiDiemXuatHien.Value.Date : (DateTime?)null;
                ThoiGianFull = ThoiGian;
                if (ThoiGian != null)
                {
                    var ThoiGian_Gio = bangKe.ThoiDiemXuatHien_Gio.HasValue ? bangKe.ThoiDiemXuatHien_Gio.Value.TimeOfDay : new TimeSpan(0, 0, 0);
                    ThoiGianFull = ThoiGian + ThoiGian_Gio;
                }
                Command.Parameters.Add(new MDB.MDBParameter("ThoiDiemXuatHien", ThoiGianFull));

                ThoiGian = bangKe.ThoiDiemNgungTruyen.HasValue ? bangKe.ThoiDiemNgungTruyen.Value.Date : (DateTime?)null;
                ThoiGianFull = ThoiGian;
                if (ThoiGian != null)
                {
                    var ThoiGian_Gio = bangKe.ThoiDiemNgungTruyen_Gio.HasValue ? bangKe.ThoiDiemNgungTruyen_Gio.Value.TimeOfDay : new TimeSpan(0, 0, 0);
                    ThoiGianFull = ThoiGian + ThoiGian_Gio;
                }
                Command.Parameters.Add(new MDB.MDBParameter("ThoiDiemNgungTruyen", ThoiGianFull));

                Command.Parameters.Add(new MDB.MDBParameter("TheTichMauDaTruyen", bangKe.TheTichMauDaTruyen));

                ThoiGian = bangKe.ThoiDiemNhanThongBao.HasValue ? bangKe.ThoiDiemNhanThongBao.Value.Date : (DateTime?)null;
                ThoiGianFull = ThoiGian;
                if (ThoiGian != null)
                {
                    var ThoiGian_Gio = bangKe.ThoiDiemNhanThongBao_Gio.HasValue ? bangKe.ThoiDiemNhanThongBao_Gio.Value.TimeOfDay : new TimeSpan(0, 0, 0);
                    ThoiGianFull = ThoiGian + ThoiGian_Gio;
                }
                Command.Parameters.Add(new MDB.MDBParameter("ThoiDiemNhanThongBao", ThoiGianFull));

                string jsonBangKes = JsonConvert.SerializeObject(bangKe.KetQuas);
                List<string> listJson = new List<string>();
                for (int i = 0; i < jsonBangKes.Length; i += 3999)
                {
                    if ((i + 3999) < jsonBangKes.Length)
                        listJson.Add(jsonBangKes.Substring(i, 3999));
                    else
                        listJson.Add(jsonBangKes.Substring(i));
                }

                Command.Parameters.Add(new MDB.MDBParameter("KetQuas_1", listJson[0]));
                Command.Parameters.Add(new MDB.MDBParameter("KetQuas_2", listJson.Count > 1 ? listJson[1] : null));

                Command.Parameters.Add(new MDB.MDBParameter("KetLuan", bangKe.KetLuan));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiPhuTrach", bangKe.NguoiPhuTrach));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiPhuTrach", bangKe.MaNguoiPhuTrach));
                Command.Parameters.Add(new MDB.MDBParameter("KyThuatVien", bangKe.KyThuatVien));
                Command.Parameters.Add(new MDB.MDBParameter("MaKyThuatVien", bangKe.MaKyThuatVien));

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
                string sql = "DELETE FROM PhieuXNTBKMMLienQuanTM WHERE ID = :ID";
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
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, long id)
        {
            string sql = @"SELECT
                B.*,
                H.SOYTE,
                H.BENHVIEN,
                H.TenBenhNhan,
                H.Tuoi,
                H.GioiTinh,
				T.MaBenhAn 
            FROM
                PhieuXNTBKMMLienQuanTM B
                LEFT JOIN HANHCHINHBENHNHAN H ON B.MABENHNHAN = H.MABENHNHAN
                LEFT JOIN THONGTINDIEUTRI T ON B.MAQUANLY = T.MAQUANLY
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            adt.Fill(ds, "BK");

            string bangKeJson = ds.Tables[0].Rows[0]["KetQuas_1"].ToString();
            if (ds.Tables[0].Rows[0]["KetQuas_2"] != DBNull.Value)
                bangKeJson += ds.Tables[0].Rows[0]["KetQuas_2"].ToString();

            ObservableCollection<KetQuaXetNghiemMau> saveDatas = JsonConvert.DeserializeObject<ObservableCollection<KetQuaXetNghiemMau>>(bangKeJson);
            DataTable ChiTiet = Common.ListToDataTable(saveDatas.ToList(), "CT");
            ds.Tables.Add(ChiTiet);
            
            return ds;
        }
    }
}
