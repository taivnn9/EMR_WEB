
using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class NguoiNhaCamKetInterface : ThongTinKy
    {
        public bool? Include { get; set; } = false;
        [MoTaDuLieu("Mã định danh")]
		public long Id { get; set; }
        public string NycTen { get; set; }
        public string NycGioiTinh { get; set; }
        public string NycCmtnd { get; set; }
        public string NycTuoi { get; set; }
        public DateTime? NycCapNgay { get; set; }
        public string NycNoiCap { get; set; }
        public string NycXom { get; set; }
        public string NycXa { get; set; }
        public string NycHuyen { get; set; }
        public string NycTinh { get; set; }
        public string NycDienThoai { get; set; }
        public string DienThoaiNguoiNha { get; set; }
        public string NycNgheNghiep { get; set; }
        public string PhuongPhapPhaThai { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        public DateTime? NgaySinh { get; set; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }
        [MoTaDuLieu("Tên khoa")]
		public string TenKhoa { get; set; }
        [MoTaDuLieu("Mã bác sỹ")]
		public string MaBacSy { get; set; }
        [MoTaDuLieu("Bác sỹ")]
		public string BacSy { get; set; }
        public string HanhDong { get; set; }
        public DateTime? NgayTao { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        public DateTime? NgaySua { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Ghi chú")]
		public string GhiChu { get; set; }
        public string NycMaBN { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
        public string NycDanToc { get; set; }
        public string QuanHeVoiBN { get; set; }
        public string NycNoiLamViec { get; set; }
        public long NycNamSinh { get; set; }
        public string NycQuocTich { get; set; }
        public string ChiDinh { get; set; }
    }

    public class NguoiNhaCamKetStored
    {
        public static ObservableCollection<NguoiNhaCamKetInterface> GetList(decimal MaQuanLy, MDB.MDBConnection MyConnection, string s_Table)
        {
            ObservableCollection<NguoiNhaCamKetInterface> lstData = new ObservableCollection<NguoiNhaCamKetInterface>();
            try
            {
                string sql = @"select * from " + s_Table + " where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
                MDB.MDBDataReader reader = Command.ExecuteReader();
                while (reader.Read())
                {
                    NguoiNhaCamKetInterface row = new NguoiNhaCamKetInterface();
                    row.Id = Convert.ToInt64(reader.GetLong("id").ToString());
                    decimal temp = 0;
                    decimal.TryParse(reader["MAQUANLY"].ToString(), out temp);
                    row.MaQuanLy = temp;
                    row.NycTen = reader["nyc_ten"].ToString();
                    row.NycGioiTinh = reader["nyc_gioi_tinh"].ToString();
                    row.NycCmtnd = reader["nyc_cmtnd"].ToString();
                    row.NycCapNgay = string.IsNullOrEmpty(reader["nyc_cap_ngay"].ToString()) ? (DateTime?)null : DateTime.Parse(reader["nyc_cap_ngay"].ToString());
                    row.NycNoiCap = reader["nyc_noi_cap"].ToString();
                    row.NycXom = reader["nyc_xom"].ToString();
                    row.NycXa = reader["nyc_xa"].ToString();
                    row.NycHuyen = reader["nyc_huyen"].ToString();
                    row.NycTinh = reader["nyc_tinh"].ToString();
                    row.NycMaBN = reader["nyc_mabn"].ToString();
                    row.TenBenhNhan = reader["ten_benh_nhan"].ToString();
                    row.NgaySinh = string.IsNullOrEmpty(reader["ngay_sinh"].ToString()) ? (DateTime?)null : DateTime.Parse(reader["ngay_sinh"].ToString());
                    row.TenKhoa = reader["ten_khoa"].ToString();
                    row.MaKhoa = reader["MaKhoa"].ToString();
                    row.MaBacSy = reader["MaBacSy"].ToString();
                    row.BacSy = reader["bac_sy"].ToString();
                    row.HanhDong = reader["hanh_dong"].ToString();
                    row.NgayTao = string.IsNullOrEmpty(reader["ngay_tao"].ToString()) ? (DateTime?)null : DateTime.Parse(reader["ngay_tao"].ToString());
                    row.NguoiTao = reader["nguoi_tao"].ToString();
                    row.NgaySua = string.IsNullOrEmpty(reader["ngay_sua"].ToString()) ? (DateTime?)null : DateTime.Parse(reader["ngay_sua"].ToString());
                    row.NguoiSua = reader["nguoi_sua"].ToString();
                    row.GhiChu = reader["ghichu"].ToString();
                    row.MaBenhNhan = reader["ma_benh_nhan"].ToString();
                    if (s_Table.Equals("NNXCamDoanLamThuThuat"))
                    {
                        row.NycDienThoai = reader["NycDienThoai"].ToString();
                        row.NycTuoi = reader["NycTuoi"].ToString();
                    }
                    if (s_Table.Equals("GiayCamDoanTuNguyenPhaThai"))
                    {
                        row.NycDienThoai = reader["nyc_dien_thoai"].ToString();
                        row.NycTuoi = reader["nyc_tuoi"].ToString();
                        row.NycNgheNghiep = reader["nyc_nghe_nghiep"].ToString();
                        row.PhuongPhapPhaThai = reader["phuong_phap_pha_thai"].ToString();
                    }
                    if (s_Table.Equals("CamDoanChapNhanPTTTGMHS2")|| s_Table.Equals("CamDoanChapNhanPTTTGMHS3"))
                    {
                        row.NycNoiLamViec = reader["NycNoiLamViec"].ToString();
                        row.NycDanToc = reader["NycDanToc"].ToString();
                        row.QuanHeVoiBN = reader["QuanHeVoiBN"].ToString();
                        row.NycTuoi = reader["nyc_tuoi"].ToString();
                        row.NycNgheNghiep = reader["nyc_nghe_nghiep"].ToString();
                        row.NycQuocTich = reader["NYC_QUOC_TICH"].ToString();
                        row.DienThoaiNguoiNha = reader["DienThoaiNguoiNha"].ToString();
                    }
                    if (s_Table.Equals("BanCamKet"))
                    {
                        row.NycDienThoai = reader["NYC_DienThoai"].ToString();
                        row.NycTuoi = reader["NYC_Tuoi"].ToString();
                    }
                    if (s_Table.Equals("GiayGiaiThichVaCamKet"))
                    {
                        DateTime now = DateTime.Now;
                        row.NycNamSinh = Convert.ToInt64(reader.GetLong("NYC_NAMSINH").ToString());
                        row.NycDienThoai = reader["NYC_DienThoai"].ToString();
                        long v = now.Year - row.NycNamSinh;
                        row.NycTuoi = v.ToString();
                    }
                    if (s_Table.Equals("GiayCamKetDYTMVCPM"))
                    {
                        row.NycTuoi = reader["NYC_Tuoi"].ToString();
                        row.QuanHeVoiBN = reader["QuanHeVoiBN"].ToString();
                    }
                    if (s_Table.Equals("GiayGiaiThichVaCamKetTDTCQ"))
                    {
                        row.ChiDinh = reader["CHIDINH"].ToString();
                    }
                    if (s_Table.Equals("GiayCamKetDNGTVTTB") || s_Table.Equals("CamKetTMCT_GMHS")) 
                    {
                        row.NycNoiLamViec = reader["NYC_NOI_LAM_VIEC"].ToString();
                        row.NycDanToc = reader["NYC_Dan_Toc"].ToString();
                        row.QuanHeVoiBN = reader["QuanHeVoiBN"].ToString();
                        row.NycTuoi = reader["nyc_tuoi"].ToString();
                        row.NycNgheNghiep = reader["nyc_nghe_nghiep"].ToString();
                        row.NycQuocTich = reader["NYC_QUOC_TICH"].ToString();
                    }
                    if (s_Table.Equals("GiayCamKetCXHTMCT"))
                    {
                        row.NycTuoi = reader["nyc_tuoi"].ToString();
                    }
                    if (s_Table.Equals("CamKetTMCT_GMHS")) 
                    {
                        row.NycTuoi = reader["nyc_tuoi"].ToString();
                        row.NycDanToc = reader["NYC_Dan_Toc"].ToString();
                        row.NycQuocTich = reader["NYC_QUOC_TICH"].ToString();
                        row.NycNgheNghiep = reader["nyc_nghe_nghiep"].ToString();
                        row.NycNoiLamViec = reader["NYC_NOI_LAM_VIEC"].ToString();
                        row.QuanHeVoiBN = reader["QuanHeVoiBN"].ToString();
                    }
                        row.MaSoKy = reader["masokyten"].ToString();
                    row.DaKy = !string.IsNullOrEmpty(row.MaSoKy) ? true : false;
                    lstData.Add(row);
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return lstData;
        }

        public static bool Delete(long Id, MDB.MDBConnection MyConnection, string s_Table)
        {
            bool result = false;
            try
            {
                string sql = @"DELETE " + s_Table + " WHERE id = :id";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("id", Id));
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                result = n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return result;
        }

        public static bool Insert(ref NguoiNhaCamKetInterface NguoiNhaCamKet, MDB.MDBConnection MyConnection, string s_Table)
        {
            bool result = false;
            try
            {
                string sql = @"insert into " + s_Table + " " +
                    "(nyc_ten, MAQUANLY, nyc_gioi_tinh, nyc_cmtnd, nyc_cap_ngay, nyc_noi_cap, nyc_xom, nyc_xa, nyc_huyen, nyc_tinh,nyc_mabn, ten_benh_nhan, ngay_sinh, MaKhoa, ten_khoa, MaBacSy, bac_sy, hanh_dong, ngay_tao, nguoi_tao, ngay_sua, nguoi_sua, ghichu,ma_benh_nhan ";
                if (s_Table.Equals("BanCamKet"))
                {
                    sql = sql + ", NYC_DienThoai, NYC_Tuoi ";
                }
                if (s_Table.Equals("GiayGiaiThichVaCamKet"))
                {
                    sql = sql + ", NYC_NAMSINH, NYC_DienThoai ";
                }
                if (s_Table.Equals("GiayCamKetDYTMVCPM"))
                {
                    sql = sql + ", NYC_Tuoi, QuanHeVoiBN ";
                }
                if (s_Table.Equals("GiayGiaiThichVaCamKetTDTCQ"))
                {
                    sql = sql + ", CHIDINH ";
                }
                if (s_Table.Equals("GiayCamKetDNGTVTTB") || s_Table.Equals("CamKetTMCT_GMHS"))
                {
                    sql = sql + ", NYC_NOI_LAM_VIEC, NYC_Dan_Toc, QuanHeVoiBN,  nyc_tuoi, nyc_nghe_nghiep, NYC_QUOC_TICH";
                }
                if (s_Table.Equals("GiayCamKetCXHTMCT"))
                {
                    sql = sql + ", NYC_Tuoi";
                }
                if (s_Table.Equals("NNXCamDoanLamThuThuat"))
                {
                    sql = sql + ", NycDienThoai, NycTuoi";
                }
                if (s_Table.Equals("GiayCamDoanTuNguyenPhaThai"))
                {
                    sql = sql + ", nyc_dien_thoai, nyc_tuoi, nyc_nghe_nghiep, phuong_phap_pha_thai";
                }
                if (s_Table.Equals("CamDoanChapNhanPTTTGMHS2") || s_Table.Equals("CamDoanChapNhanPTTTGMHS3"))
                {
                    sql = sql + ", NycNoiLamViec, NycDanToc, QuanHeVoiBN, nyc_tuoi, nyc_nghe_nghiep, Nyc_quoc_tich, DienThoaiNguoiNha ";
                }
                if (s_Table.Equals("CamDoanChapNhanTTTMVGMHS"))
                {
                    sql = sql + ", NycDienThoai, NycTuoi, Nyc_Noi_Lam_Viec, nyc_nghe_nghiep, Nyc_quoc_tich, Nyc_Dan_Toc ";
                }
                if (s_Table.Equals("CamDoanChapNhanPTTTVGMHS"))
                {
                    sql = sql + ", NycDienThoai, NycTuoi, Nyc_Noi_Lam_Viec, nyc_nghe_nghiep, Nyc_quoc_tich, Nyc_Dan_Toc ";
                }
                sql = sql + ") values(:nyc_ten, :MAQUANLY, :nyc_gioi_tinh, :nyc_cmtnd, :nyc_cap_ngay, :nyc_noi_cap, :nyc_xom, :nyc_xa, :nyc_huyen, :nyc_tinh, :nyc_mabn, :ten_benh_nhan, :ngay_sinh, :MaKhoa, :ten_khoa, :MaBacSy, :bac_sy, :hanh_dong, :ngay_tao, :nguoi_tao, :ngay_sua, :nguoi_sua, :ghichu, :ma_benh_nhan ";

                if (s_Table.Equals("NNXCamDoanLamThuThuat"))
                {
                    sql = sql + ", :NycDienThoai, :NycTuoi";
                }
                if (s_Table.Equals("GiayCamDoanTuNguyenPhaThai"))
                {
                    sql = sql + ", :nyc_dien_thoai, :nyc_tuoi, :nyc_nghe_nghiep, :phuong_phap_pha_thai";
                }
                if (s_Table.Equals("CamDoanChapNhanPTTTGMHS2") || s_Table.Equals("CamDoanChapNhanPTTTGMHS3"))
                {
                    sql = sql + ", :NycNoiLamViec, :NycDanToc, :QuanHeVoiBN, :nyc_tuoi, :nyc_nghe_nghiep, :Nyc_quoc_tich, :DienThoaiNguoiNha ";
                }
                if (s_Table.Equals("BanCamKet"))
                {
                    sql = sql + ", :NYC_DienThoai, :NYC_Tuoi";
                }
                if (s_Table.Equals("GiayGiaiThichVaCamKet"))
                {
                    sql = sql + ", :NYC_NAMSINH, :NYC_DienThoai";
                }
                if (s_Table.Equals("GiayCamKetDYTMVCPM"))
                {
                    sql = sql + ", :NYC_Tuoi, :QuanHeVoiBN";
                }
                if (s_Table.Equals("GiayGiaiThichVaCamKetTDTCQ"))
                {
                    sql = sql + ", :ChiDinh";
                }
                if (s_Table.Equals("GiayCamKetDNGTVTTB") || s_Table.Equals("CamKetTMCT_GMHS"))
                {
                    sql = sql + ", :NycNoiLamViec, :NycDanToc, :QuanHeVoiBN, :NycTuoi, :NycNgheNghiep, :NycQuocTich";
                }
                if (s_Table.Equals("GiayCamKetCXHTMCT"))
                {
                    sql = sql + ", :NYC_Tuoi";
                }
                if (s_Table.Equals("CamDoanChapNhanTTTMVGMHS"))
                {
                    sql = sql + ", :NycDienThoai, :NycTuoi, :Nyc_Noi_Lam_Viec, :nyc_nghe_nghiep, :Nyc_quoc_tich, :Nyc_Dan_Toc ";
                }
               
                sql = sql + ") RETURNING ID INTO :ID";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("nyc_ten", NguoiNhaCamKet.NycTen));
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", NguoiNhaCamKet.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("nyc_gioi_tinh", NguoiNhaCamKet.NycGioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("nyc_cmtnd", NguoiNhaCamKet.NycCmtnd));
                Command.Parameters.Add(new MDB.MDBParameter("nyc_cap_ngay", NguoiNhaCamKet.NycCapNgay));
                Command.Parameters.Add(new MDB.MDBParameter("nyc_noi_cap", NguoiNhaCamKet.NycNoiCap));
                Command.Parameters.Add(new MDB.MDBParameter("nyc_xom", NguoiNhaCamKet.NycXom));
                Command.Parameters.Add(new MDB.MDBParameter("nyc_xa", NguoiNhaCamKet.NycXa));
                Command.Parameters.Add(new MDB.MDBParameter("nyc_huyen", NguoiNhaCamKet.NycHuyen));
                Command.Parameters.Add(new MDB.MDBParameter("nyc_tinh", NguoiNhaCamKet.NycTinh));
                Command.Parameters.Add(new MDB.MDBParameter("nyc_mabn", NguoiNhaCamKet.NycMaBN));
                Command.Parameters.Add(new MDB.MDBParameter("ten_benh_nhan", NguoiNhaCamKet.TenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("ngay_sinh", NguoiNhaCamKet.NgaySinh));
                Command.Parameters.Add(new MDB.MDBParameter("ten_khoa", NguoiNhaCamKet.TenKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaKhoa", NguoiNhaCamKet.MaKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("bac_sy", NguoiNhaCamKet.BacSy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSy", NguoiNhaCamKet.MaBacSy));
                Command.Parameters.Add(new MDB.MDBParameter("hanh_dong", NguoiNhaCamKet.HanhDong));
                Command.Parameters.Add(new MDB.MDBParameter("ngay_tao", DateTime.Now));
                Command.Parameters.Add(new MDB.MDBParameter("nguoi_tao", NguoiNhaCamKet.NguoiTao));
                Command.Parameters.Add(new MDB.MDBParameter("ngay_sua", null));
                Command.Parameters.Add(new MDB.MDBParameter("nguoi_sua", null));
                Command.Parameters.Add(new MDB.MDBParameter("ghichu", NguoiNhaCamKet.GhiChu));
                Command.Parameters.Add(new MDB.MDBParameter("ma_benh_nhan", NguoiNhaCamKet.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("nyc_mabn", NguoiNhaCamKet.MaBenhNhan));
                if (s_Table.Equals("NNXCamDoanLamThuThuat"))
                {
                    Command.Parameters.Add(new MDB.MDBParameter("NycDienThoai", NguoiNhaCamKet.NycDienThoai));
                    Command.Parameters.Add(new MDB.MDBParameter("NycTuoi", NguoiNhaCamKet.NycTuoi));
                }
                if (s_Table.Equals("GiayCamDoanTuNguyenPhaThai"))
                {
                    Command.Parameters.Add(new MDB.MDBParameter("nyc_dien_thoai", NguoiNhaCamKet.NycDienThoai));
                    Command.Parameters.Add(new MDB.MDBParameter("nyc_tuoi", NguoiNhaCamKet.NycTuoi));
                    Command.Parameters.Add(new MDB.MDBParameter("nyc_nghe_nghiep", NguoiNhaCamKet.NycNgheNghiep));
                    Command.Parameters.Add(new MDB.MDBParameter("phuong_phap_pha_thai", NguoiNhaCamKet.PhuongPhapPhaThai));
                }
                if (s_Table.Equals("CamDoanChapNhanPTTTGMHS2") || s_Table.Equals("CamDoanChapNhanPTTTGMHS3"))
                {
                    Command.Parameters.Add(new MDB.MDBParameter("NycNoiLamViec", NguoiNhaCamKet.NycNoiLamViec));
                    Command.Parameters.Add(new MDB.MDBParameter("NycDanToc", NguoiNhaCamKet.NycDanToc));
                    Command.Parameters.Add(new MDB.MDBParameter("QuanHeVoiBN", NguoiNhaCamKet.QuanHeVoiBN));
                    Command.Parameters.Add(new MDB.MDBParameter("nyc_tuoi", NguoiNhaCamKet.NycTuoi));
                    Command.Parameters.Add(new MDB.MDBParameter("nyc_nghe_nghiep", NguoiNhaCamKet.NycNgheNghiep));
                    Command.Parameters.Add(new MDB.MDBParameter("Nyc_quoc_tich", NguoiNhaCamKet.NycQuocTich));
                    Command.Parameters.Add(new MDB.MDBParameter("DienThoaiNguoiNha", NguoiNhaCamKet.DienThoaiNguoiNha));
                }
                if (s_Table.Equals("BanCamKet"))
                {
                    Command.Parameters.Add(new MDB.MDBParameter("NYC_DienThoai", NguoiNhaCamKet.NycDienThoai));
                    Command.Parameters.Add(new MDB.MDBParameter("NYC_Tuoi", NguoiNhaCamKet.NycTuoi));
                }
                if (s_Table.Equals("GiayGiaiThichVaCamKet"))
                {
                    Command.Parameters.Add(new MDB.MDBParameter("NYC_NAMSINH", NguoiNhaCamKet.NycNamSinh));
                    Command.Parameters.Add(new MDB.MDBParameter("NYC_DienThoai", NguoiNhaCamKet.NycDienThoai));
                }
                if (s_Table.Equals("GiayCamKetDYTMVCPM"))
                {
                    Command.Parameters.Add(new MDB.MDBParameter("NYC_Tuoi", NguoiNhaCamKet.NycTuoi));
                    Command.Parameters.Add(new MDB.MDBParameter("QuanHeVoiBN", NguoiNhaCamKet.QuanHeVoiBN));
                }
                if (s_Table.Equals("GiayGiaiThichVaCamKetTDTCQ"))
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ChiDinh", NguoiNhaCamKet.ChiDinh));
                }
                if (s_Table.Equals("GiayCamKetDNGTVTTB") || s_Table.Equals("CamKetTMCT_GMHS"))
                {
                    Command.Parameters.Add(new MDB.MDBParameter("NycNoiLamViec", NguoiNhaCamKet.NycNoiLamViec));
                    Command.Parameters.Add(new MDB.MDBParameter("NycDanToc", NguoiNhaCamKet.NycDanToc));
                    Command.Parameters.Add(new MDB.MDBParameter("QuanHeVoiBN", NguoiNhaCamKet.QuanHeVoiBN));
                    Command.Parameters.Add(new MDB.MDBParameter("NycTuoi", NguoiNhaCamKet.NycTuoi));
                    Command.Parameters.Add(new MDB.MDBParameter("NycNgheNghiep", NguoiNhaCamKet.NycNgheNghiep));
                    Command.Parameters.Add(new MDB.MDBParameter("NycQuocTich", NguoiNhaCamKet.NycQuocTich));
                }
                if (s_Table.Equals("GiayCamKetCXHTMCT"))
                {
                    Command.Parameters.Add(new MDB.MDBParameter("NYC_Tuoi", NguoiNhaCamKet.NycTuoi));
                }
                if (s_Table.Equals("CamDoanChapNhanTTTMVGMHS"))
                {

                    Command.Parameters.Add(new MDB.MDBParameter("NycDienThoai", NguoiNhaCamKet.NycDienThoai));
                    Command.Parameters.Add(new MDB.MDBParameter("NycTuoi", NguoiNhaCamKet.NycTuoi));
                    Command.Parameters.Add(new MDB.MDBParameter("Nyc_Noi_Lam_Viec", NguoiNhaCamKet.NycNoiLamViec));
                    Command.Parameters.Add(new MDB.MDBParameter("Nyc_Dan_Toc", NguoiNhaCamKet.NycDanToc));
                    Command.Parameters.Add(new MDB.MDBParameter("nyc_nghe_nghiep", NguoiNhaCamKet.NycNgheNghiep));
                    Command.Parameters.Add(new MDB.MDBParameter("Nyc_quoc_tich", NguoiNhaCamKet.NycQuocTich));
                }
                if (NguoiNhaCamKet.Id == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", NguoiNhaCamKet.Id));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (NguoiNhaCamKet.Id == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    NguoiNhaCamKet.Id = nextval;
                }
                result = n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return result;
        }

        public static bool Update(NguoiNhaCamKetInterface NguoiNhaCamKet, MDB.MDBConnection MyConnection, string s_Table)
        {
            bool result = false;
            try
            {
                string sql = @"update " + s_Table + " set nyc_ten = :nyc_ten,MAQUANLY = :MAQUANLY,nyc_gioi_tinh = :nyc_gioi_tinh,nyc_cmtnd = :nyc_cmtnd,nyc_cap_ngay = :nyc_cap_ngay,nyc_noi_cap = :nyc_noi_cap,nyc_xom = :nyc_xom,nyc_xa = :nyc_xa,nyc_huyen = :nyc_huyen,nyc_tinh = :nyc_tinh,nyc_mabn = :nyc_mabn,ten_benh_nhan = :ten_benh_nhan,ngay_sinh = :ngay_sinh,MaKhoa = :MaKhoa, ten_khoa = :ten_khoa,MaBacSy = :MaBacSy, bac_sy = :bac_sy,hanh_dong = :hanh_dong,ngay_sua = :ngay_sua,nguoi_sua = :nguoi_sua,ghichu = :ghichu,ma_benh_nhan = :ma_benh_nhan";
                if (s_Table.Equals("NNXCamDoanLamThuThuat"))
                {
                    sql = sql + ",NycDienThoai = :NycDienThoai";
                }
                if (s_Table.Equals("GiayCamDoanTuNguyenPhaThai"))
                {
                    sql = sql + ", nyc_dien_thoai = :nyc_dien_thoai, nyc_tuoi = :nyc_tuoi, nyc_nghe_nghiep = :nyc_nghe_nghiep, phuong_phap_pha_thai = :phuong_phap_pha_thai";
                }
                if (s_Table.Equals("CamDoanChapNhanPTTTGMHS2") || s_Table.Equals("CamDoanChapNhanPTTTGMHS3"))
                {
                    sql = sql + ", NycNoiLamViec = :NycNoiLamViec, NycDanToc = :NycDanToc, QuanHeVoiBN = :QuanHeVoiBN, nyc_tuoi = :nyc_tuoi, nyc_nghe_nghiep = :nyc_nghe_nghiep, Nyc_quoc_tich = :Nyc_quoc_tich, DienThoaiNguoiNha = :DienThoaiNguoiNha ";
                }
                if (s_Table.Equals("BanCamKet"))
                {
                    sql = sql + ", NYC_DienThoai = :NycDienThoai , NYC_Tuoi = : NycTuoi ";
                }
                if (s_Table.Equals("GiayGiaiThichVaCamKet"))
                {
                    sql = sql + ",NYC_NAMSINH = :NycNamSinh,  NYC_DienThoai = :NycDienThoai ";
                }
                if (s_Table.Equals("GiayCamKetDYTMVCPM"))
                {
                    sql = sql + ",NYC_Tuoi = :NycTuoi,   QuanHeVoiBN = :QuanHeVoiBN ";
                }
                if (s_Table.Equals("GiayCamKetCXHTMCT"))
                {
                    sql = sql + ",NYC_Tuoi = :NycTuoi ";
                }
                if (s_Table.Equals("GiayGiaiThichVaCamKetTDTCQ"))
                {
                    sql = sql + ",CHIDINH = :ChiDinh ";
                }
                if (s_Table.Equals("GiayCamKetDNGTVTTB") || s_Table.Equals("CamKetTMCT_GMHS"))
                {
                    sql = sql + ", Nyc_Noi_Lam_Viec = :NycNoiLamViec, Nyc_Dan_Toc = :NycDanToc, QuanHeVoiBN = :QuanHeVoiBN, nyc_tuoi = :nyc_tuoi, nyc_nghe_nghiep = :nyc_nghe_nghiep, Nyc_quoc_tich = :NycQuocTich";

                }
                if (s_Table.Equals("CamDoanChapNhanTTTMVGMHS"))
                {
                    sql = sql + ", NycDienThoai = :NycDienThoai , NycTuoi = : NycTuoi, Nyc_Noi_Lam_Viec = :Nyc_Noi_Lam_Viec, nyc_nghe_nghiep = :nyc_nghe_nghiep, Nyc_quoc_tich = :Nyc_quoc_tich, Nyc_Dan_Toc = :Nyc_Dan_Toc ";
                }
                sql = sql + "  where id = :id";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("id", NguoiNhaCamKet.Id));
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", NguoiNhaCamKet.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("nyc_ten", NguoiNhaCamKet.NycTen));
                Command.Parameters.Add(new MDB.MDBParameter("nyc_gioi_tinh", NguoiNhaCamKet.NycGioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("nyc_cmtnd", NguoiNhaCamKet.NycCmtnd));
                Command.Parameters.Add(new MDB.MDBParameter("nyc_cap_ngay", NguoiNhaCamKet.NycCapNgay));
                Command.Parameters.Add(new MDB.MDBParameter("nyc_noi_cap", NguoiNhaCamKet.NycNoiCap));
                Command.Parameters.Add(new MDB.MDBParameter("nyc_xom", NguoiNhaCamKet.NycXom));
                Command.Parameters.Add(new MDB.MDBParameter("nyc_xa", NguoiNhaCamKet.NycXa));
                Command.Parameters.Add(new MDB.MDBParameter("nyc_huyen", NguoiNhaCamKet.NycHuyen));
                Command.Parameters.Add(new MDB.MDBParameter("nyc_tinh", NguoiNhaCamKet.NycTinh));
                Command.Parameters.Add(new MDB.MDBParameter("nyc_mabn", NguoiNhaCamKet.NycMaBN));
                Command.Parameters.Add(new MDB.MDBParameter("ten_benh_nhan", NguoiNhaCamKet.TenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("ngay_sinh", NguoiNhaCamKet.NgaySinh));
                Command.Parameters.Add(new MDB.MDBParameter("ten_khoa", NguoiNhaCamKet.TenKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaKhoa", NguoiNhaCamKet.MaKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("bac_sy", NguoiNhaCamKet.BacSy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSy", NguoiNhaCamKet.MaBacSy));
                Command.Parameters.Add(new MDB.MDBParameter("hanh_dong", NguoiNhaCamKet.HanhDong));
                Command.Parameters.Add(new MDB.MDBParameter("ngay_sua", DateTime.Now));
                Command.Parameters.Add(new MDB.MDBParameter("nguoi_sua", NguoiNhaCamKet.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("ghichu", NguoiNhaCamKet.GhiChu));
                Command.Parameters.Add(new MDB.MDBParameter("ma_benh_nhan", NguoiNhaCamKet.MaBenhNhan));
                if (s_Table.Equals("NNXCamDoanLamThuThuat"))
                {
                    Command.Parameters.Add(new MDB.MDBParameter("NycDienThoai", NguoiNhaCamKet.NycDienThoai));
                    Command.Parameters.Add(new MDB.MDBParameter("NycTuoi", NguoiNhaCamKet.NycTuoi));
                }
                if (s_Table.Equals("GiayCamDoanTuNguyenPhaThai"))
                {
                    Command.Parameters.Add(new MDB.MDBParameter("nyc_dien_thoai", NguoiNhaCamKet.NycDienThoai));
                    Command.Parameters.Add(new MDB.MDBParameter("nyc_tuoi", NguoiNhaCamKet.NycTuoi));
                    Command.Parameters.Add(new MDB.MDBParameter("nyc_nghe_nghiep", NguoiNhaCamKet.NycNgheNghiep));
                    Command.Parameters.Add(new MDB.MDBParameter("phuong_phap_pha_thai", NguoiNhaCamKet.PhuongPhapPhaThai));
                }
                if (s_Table.Equals("CamDoanChapNhanPTTTGMHS2") || s_Table.Equals("CamDoanChapNhanPTTTGMHS3"))
                {
                    Command.Parameters.Add(new MDB.MDBParameter("NycNoiLamViec", NguoiNhaCamKet.NycNoiLamViec));
                    Command.Parameters.Add(new MDB.MDBParameter("NycDanToc", NguoiNhaCamKet.NycDanToc));
                    Command.Parameters.Add(new MDB.MDBParameter("QuanHeVoiBN", NguoiNhaCamKet.QuanHeVoiBN));
                    Command.Parameters.Add(new MDB.MDBParameter("nyc_tuoi", NguoiNhaCamKet.NycTuoi));
                    Command.Parameters.Add(new MDB.MDBParameter("nyc_nghe_nghiep", NguoiNhaCamKet.NycNgheNghiep));
                    Command.Parameters.Add(new MDB.MDBParameter("Nyc_quoc_tich", NguoiNhaCamKet.NycQuocTich));
                    Command.Parameters.Add(new MDB.MDBParameter("DienThoaiNguoiNha", NguoiNhaCamKet.DienThoaiNguoiNha));
                }
                if (s_Table.Equals("BanCamKet"))
                {
                    Command.Parameters.Add(new MDB.MDBParameter("NycDienThoai", NguoiNhaCamKet.NycDienThoai));
                    Command.Parameters.Add(new MDB.MDBParameter("NycTuoi", NguoiNhaCamKet.NycTuoi));
                }
                if (s_Table.Equals("GiayGiaiThichVaCamKet"))
                {
                    Command.Parameters.Add(new MDB.MDBParameter("NycNamSinh", NguoiNhaCamKet.NycNamSinh));
                    Command.Parameters.Add(new MDB.MDBParameter("NycDienThoai", NguoiNhaCamKet.NycDienThoai));
                }
                if (s_Table.Equals("GiayCamKetDYTMVCPM"))
                {
                    Command.Parameters.Add(new MDB.MDBParameter("QuanHeVoiBN", NguoiNhaCamKet.QuanHeVoiBN));
                    Command.Parameters.Add(new MDB.MDBParameter("NycTuoi", NguoiNhaCamKet.NycTuoi));
                }
                if (s_Table.Equals("GiayGiaiThichVaCamKetTDTCQ"))
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ChiDinh", NguoiNhaCamKet.ChiDinh));
                }
                if (s_Table.Equals("GiayCamKetDNGTVTTB") || s_Table.Equals("CamKetTMCT_GMHS"))
                {
                    Command.Parameters.Add(new MDB.MDBParameter("NycNoiLamViec", NguoiNhaCamKet.NycNoiLamViec));
                    Command.Parameters.Add(new MDB.MDBParameter("NycDanToc", NguoiNhaCamKet.NycDanToc));
                    Command.Parameters.Add(new MDB.MDBParameter("QuanHeVoiBN", NguoiNhaCamKet.QuanHeVoiBN));
                    Command.Parameters.Add(new MDB.MDBParameter("nyc_tuoi", NguoiNhaCamKet.NycTuoi));
                    Command.Parameters.Add(new MDB.MDBParameter("nyc_nghe_nghiep", NguoiNhaCamKet.NycNgheNghiep));
                    Command.Parameters.Add(new MDB.MDBParameter("NycQuocTich", NguoiNhaCamKet.NycQuocTich));
                }
                if (s_Table.Equals("GiayCamKetCXHTMCT"))
                {
                    Command.Parameters.Add(new MDB.MDBParameter("nyc_tuoi", NguoiNhaCamKet.NycTuoi));
                }
                if (s_Table.Equals("CamDoanChapNhanTTTMVGMHS"))
                {
                    Command.Parameters.Add(new MDB.MDBParameter("NycDienThoai", NguoiNhaCamKet.NycDienThoai));
                    Command.Parameters.Add(new MDB.MDBParameter("NycTuoi", NguoiNhaCamKet.NycTuoi));
                    Command.Parameters.Add(new MDB.MDBParameter("Nyc_Noi_Lam_Viec", NguoiNhaCamKet.NycNoiLamViec));
                    Command.Parameters.Add(new MDB.MDBParameter("Nyc_Dan_Toc", NguoiNhaCamKet.NycDanToc));
                    Command.Parameters.Add(new MDB.MDBParameter("nyc_nghe_nghiep", NguoiNhaCamKet.NycNgheNghiep));
                    Command.Parameters.Add(new MDB.MDBParameter("Nyc_quoc_tich", NguoiNhaCamKet.NycQuocTich));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                result = n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return result;
        }

        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, string sID, string s_Table)
        {
            string sql = @"select a.*, b.*  from " + s_Table + " a inner join thongtindieutri b ON a.maquanly = b.maquanly " +
                " WHERE a.ID =: s_id";
            MDB.MDBCommand Command;
            MDB.MDBDataAdapter adt;
            using (Command = new MDB.MDBCommand(sql, MyConnection))
            {
                Command.Parameters.Add(new MDB.MDBParameter("s_id", sID));
                adt = new MDB.MDBDataAdapter(Command);
            }
            var ds = new DataSet();

            adt.Fill(ds, "PhieuNNX");
            ds.Tables[0].Columns.Add("SOYTE", typeof(string));
            ds.Tables[0].Columns.Add("BENHVIEN", typeof(string));
            ds.Tables[0].Columns.Add("TENBENHNHAN", typeof(string));
            ds.Tables[0].Columns.Add("TUOI", typeof(string));
            ds.Tables[0].Columns.Add("GIOITINH", typeof(string));
            ds.Tables[0].Columns.Add("NGAYSINH", typeof(string));
            ds.Tables[0].Columns.Add("SOVAOVIEN", typeof(string));

            ds.Tables[0].Rows[0]["SOYTE"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["TENBENHNHAN"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["TUOI"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["GIOITINH"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            ds.Tables[0].Rows[0]["NGAYSINH"] = XemBenhAn._HanhChinhBenhNhan.NgaySinh.HasValue ? XemBenhAn._HanhChinhBenhNhan.NgaySinh.Value.ToString("dd/MM/yyyy") :"";
            ds.Tables[0].Rows[0]["SOVAOVIEN"] = XemBenhAn._ThongTinDieuTri.SoNhapVien;

            return ds;
        }
    }
}
