using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMR.KyDienTu;
using PMS.Access; 

namespace EMR_MAIN.DATABASE.Other
{
    public class TheoDoiNhanXet
    {
        public DateTime? ThoiGian { get; set; }
        public string NhanXet { get; set; }
    }
    public class SoSinhInterface : ThongTinKy
    {
        public SoSinhInterface()
        {
            TableName = "PHIEUSOSINH";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.SS;
            TenMauPhieu = DanhMucPhieu.SS.Description();
        }
        public bool? Include { get; set; } = false;
        [MoTaDuLieu("Mã định danh")]
		public long Id { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Bệnh án")]
		public string BenhAn { get; set; }
        public string MaSo { get; set; }
        public string TenSoSinh { get; set; }
        public string TenMe { get; set; }
        public string TenBo { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string TuoiMe { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string TuoiBo { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        public string SinhLucGio { get; set; }
        public string SinhLucPhut { get; set; }
        public string SinhLucNgay { get; set; }
        public string SinhLucThang { get; set; }
        public string SinhLucNam { get; set; }
        public string Gioitinh { get; set; }
        public string TrongLuong { get; set; }
        public string TuanThai { get; set; }
        public string PhuongPhapSinh { get; set; }
        public string KhuyetTat { get; set; }
        public string SangLoc { get; set; }
        public string TiemChung { get; set; }
        public string LoaiVacXin { get; set; }
        public string NXPhuSan { get; set; }
        public DateTime? NXPhuSan_ThoiGian { get; set; }
        public string NXKhoaNhi { get; set; }
        public DateTime? NXKhoaNhi_ThoiGian { get; set; }
        public string TheoDoi { get; set; }
        public List<TheoDoiNhanXet> listTheoDoi
        {
            get
            {
                try
                {
                    return JsonConvert.DeserializeObject<List<TheoDoiNhanXet>>(TheoDoi);
                }
                catch { return new List<TheoDoiNhanXet>(); }
            }
        }
        public string KhuyetTatMoTa { get; set; }
        public string BanGiaoGio { get; set; }
        public string BanGiaoPhut { get; set; }
        public string BanGiaoNgay { get; set; }
        public string BanGiaoThang { get; set; }
        public string BanGiaoNam { get; set; }
        public string SoMeCon { get; set; }
        public string CamKet { get; set; }
        public string NhanVienYTe { get; set; }
        public DateTime ThoiGianBanGiao { get; set; }
        public DateTime ThoiGianSinh { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Bệnh viện")]
		public string BenhVien { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
    }
    public class SoSinhStored
    {

        public const string TableName = "PHIEUSOSINH";
        public const string TablePrimaryKeyName = "ID";
        public static List<SoSinhInterface> GetList(decimal MaQuanLy, MDB.MDBConnection MyConnection)
        {
            List<SoSinhInterface> lstData = new List<SoSinhInterface>();
            try
            {
                string sql = @"select * from PHIEUSOSINH where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
                MDB.MDBDataReader reader = Command.ExecuteReader();
                while (reader.Read())
                {
                    SoSinhInterface row = new SoSinhInterface();
                    row.Id = Convert.ToInt64(reader.GetLong("ID").ToString());
                    row.MaBenhNhan = reader["ma_bn"].ToString();
                    row.BenhAn = reader["benh_an"].ToString();
                    row.MaSo = reader["ma_so"].ToString();
                    row.TenSoSinh = reader["ten_so_sinh"].ToString();
                    row.TenMe = reader["ten_me"].ToString();
                    row.TenBo = reader["ten_bo"].ToString();
                    row.TuoiMe = reader["tuoi_me"].ToString();
                    row.TuoiBo = reader["tuoi_bo"].ToString();
                    row.DiaChi = reader["dia_chi"].ToString();
                    row.SinhLucGio = reader["sinh_luc_gio"].ToString();
                    row.SinhLucPhut = reader["sinh_luc_phut"].ToString();
                    row.SinhLucNgay = reader["sinh_luc_ngay"].ToString();
                    row.SinhLucThang = reader["sinh_luc_thang"].ToString();
                    row.SinhLucNam = reader["sinh_luc_nam"].ToString();
                    row.Gioitinh = reader["gioi_tinh"].ToString();
                    row.TrongLuong = reader["trong_luong"].ToString();
                    row.TuanThai = reader["tuan_thai"].ToString();
                    row.PhuongPhapSinh = reader["phuong_phap_sinh"].ToString();
                    row.KhuyetTat = reader["khuyet_tat"].ToString();
                    row.SangLoc = reader["SangLoc"].ToString();
                    row.LoaiVacXin = reader["LoaiVacXin"].ToString();
                    row.TiemChung = reader["TiemChung"].ToString();
                    row.NXPhuSan = reader["NXPhuSan"].ToString();
                    row.NXPhuSan_ThoiGian = reader["NXPhuSan_ThoiGian"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["NXPhuSan_ThoiGian"]);
                    row.NXKhoaNhi = reader["NXKhoaNhi"].ToString();
                    row.NXKhoaNhi_ThoiGian = reader["NXKhoaNhi_ThoiGian"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["NXKhoaNhi_ThoiGian"]);
                    row.TheoDoi = reader["TheoDoi"].ToString();
                    row.KhuyetTatMoTa = reader["khuyet_tat_mo_ta"].ToString();
                    row.BanGiaoGio = reader["ban_giao_gio"].ToString();
                    row.BanGiaoPhut = reader["ban_giao_phut"].ToString();
                    row.BanGiaoNgay = reader["ban_giao_ngay"].ToString();
                    row.BanGiaoThang = reader["ban_giao_thang"].ToString();
                    row.BanGiaoNam = reader["ban_giao_nam"].ToString();
                    row.SoMeCon = reader["so_me_con"].ToString();
                    row.CamKet = reader["cam_ket"].ToString();
                    row.NhanVienYTe = reader["nhan_vien_y_te"].ToString();
                    row.ThoiGianBanGiao = Common.ConDB_DateTime(reader["ThoiGianBanGiao"]);
                    row.ThoiGianSinh = Common.ConDB_DateTime(reader["ThoiGianSinh"]);
                    row.MaQuanLy = Convert.ToDecimal(reader["MaQuanLy"]);
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
        public static bool Delete(long Id, MDB.MDBConnection MyConnection)
        {
            bool result = false;
            try
            {
                string sql = @"DELETE PHIEUSOSINH  WHERE id = :id";
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
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, string Id)
        {
            string sql = @"SELECT * FROM PHIEUSOSINH WHERE id = :id";
            MDB.MDBCommand Command;
            MDB.MDBDataAdapter adt;
            DataSet ds = new DataSet();
            using (Command = new MDB.MDBCommand(sql, MyConnection))
            {
                Command.Parameters.Add(new MDB.MDBParameter("id", Id));
                adt = new MDB.MDBDataAdapter(Command);
                adt.Fill(ds, "TBL");
            }

            return ds;

        }
        public static bool Insert(SoSinhInterface soSinh, MDB.MDBConnection MyConnection)
        {
            bool result = false;
            try
            {
                string sql = @"insert into PHIEUSOSINH
                              (ma_bn, benh_an, ma_so, ten_so_sinh,ten_me, ten_bo,tuoi_me,tuoi_bo,dia_chi, sinh_luc_gio, sinh_luc_phut,sinh_luc_ngay,sinh_luc_thang,sinh_luc_nam,gioi_tinh,trong_luong,tuan_thai,phuong_phap_sinh,khuyet_tat,SangLoc,LoaiVacXin,TiemChung,NXPhuSan,NXPhuSan_ThoiGian,NXKhoaNhi,NXKhoaNhi_ThoiGian,TheoDoi,khuyet_tat_mo_ta,ban_giao_gio,ban_giao_phut,ban_giao_ngay,ban_giao_thang,ban_giao_nam,so_me_con,cam_ket,nhan_vien_y_te,ThoiGianBanGiao,ThoiGianSinh, MaQuanLy)
                            values
                              (:ma_bn, :benh_an, :ma_so, :ten_so_sinh, :ten_me, :ten_bo, :tuoi_me, :tuoi_bo, :dia_chi, :sinh_luc_gio, :sinh_luc_phut, :sinh_luc_ngay, :sinh_luc_thang, :sinh_luc_nam,:gioi_tinh,:trong_luong,:tuan_thai,:phuong_phap_sinh,:khuyet_tat, :SangLoc, :LoaiVacXin, :TiemChung, :NXPhuSan, :NXPhuSan_ThoiGian, :NXKhoaNhi, :NXKhoaNhi_ThoiGian, :TheoDoi,:khuyet_tat_mo_ta,:ban_giao_gio,:ban_giao_phut,:ban_giao_ngay,:ban_giao_thang,:ban_giao_nam,:so_me_con,:cam_ket,:nhan_vien_y_te, :ThoiGianBanGiao, :ThoiGianSinh, :MaQuanLy)";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ma_bn", soSinh.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("benh_an", soSinh.BenhAn));
                Command.Parameters.Add(new MDB.MDBParameter("ma_so", soSinh.MaSo));
                Command.Parameters.Add(new MDB.MDBParameter("ten_so_sinh", soSinh.TenSoSinh));
                Command.Parameters.Add(new MDB.MDBParameter("ten_me", soSinh.TenMe));
                Command.Parameters.Add(new MDB.MDBParameter("ten_bo", soSinh.TenBo));
                Command.Parameters.Add(new MDB.MDBParameter("tuoi_me", soSinh.TuoiMe));
                Command.Parameters.Add(new MDB.MDBParameter("tuoi_bo", soSinh.TuoiBo));
                Command.Parameters.Add(new MDB.MDBParameter("dia_chi", soSinh.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("sinh_luc_gio", soSinh.SinhLucGio));
                Command.Parameters.Add(new MDB.MDBParameter("sinh_luc_phut", soSinh.SinhLucPhut));
                Command.Parameters.Add(new MDB.MDBParameter("sinh_luc_ngay", soSinh.SinhLucNgay));
                Command.Parameters.Add(new MDB.MDBParameter("sinh_luc_thang", soSinh.SinhLucThang));
                Command.Parameters.Add(new MDB.MDBParameter("sinh_luc_nam", soSinh.SinhLucNam));
                Command.Parameters.Add(new MDB.MDBParameter("gioi_tinh", soSinh.Gioitinh));
                Command.Parameters.Add(new MDB.MDBParameter("trong_luong", soSinh.TrongLuong));
                Command.Parameters.Add(new MDB.MDBParameter("tuan_thai", soSinh.TuanThai));
                Command.Parameters.Add(new MDB.MDBParameter("phuong_phap_sinh", soSinh.PhuongPhapSinh));
                Command.Parameters.Add(new MDB.MDBParameter("khuyet_tat", soSinh.KhuyetTat));
                Command.Parameters.Add(new MDB.MDBParameter("SangLoc", soSinh.SangLoc));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiVacXin", soSinh.LoaiVacXin));
                Command.Parameters.Add(new MDB.MDBParameter("TiemChung", soSinh.TiemChung));
                Command.Parameters.Add(new MDB.MDBParameter("NXPhuSan", soSinh.NXPhuSan));
                Command.Parameters.Add(new MDB.MDBParameter("NXPhuSan_ThoiGian", soSinh.NXPhuSan_ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("NXKhoaNhi", soSinh.NXKhoaNhi));
                Command.Parameters.Add(new MDB.MDBParameter("NXKhoaNhi_ThoiGian", soSinh.NXKhoaNhi_ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("TheoDoi", soSinh.TheoDoi));
                Command.Parameters.Add(new MDB.MDBParameter("khuyet_tat_mo_ta", soSinh.KhuyetTatMoTa));
                Command.Parameters.Add(new MDB.MDBParameter("ban_giao_gio", soSinh.BanGiaoGio));
                Command.Parameters.Add(new MDB.MDBParameter("ban_giao_phut", soSinh.BanGiaoPhut));
                Command.Parameters.Add(new MDB.MDBParameter("ban_giao_ngay", soSinh.BanGiaoNgay));
                Command.Parameters.Add(new MDB.MDBParameter("ban_giao_thang", soSinh.BanGiaoThang));
                Command.Parameters.Add(new MDB.MDBParameter("ban_giao_nam", soSinh.BanGiaoNam));
                Command.Parameters.Add(new MDB.MDBParameter("so_me_con", soSinh.SoMeCon));
                Command.Parameters.Add(new MDB.MDBParameter("cam_ket", soSinh.CamKet));
                Command.Parameters.Add(new MDB.MDBParameter("nhan_vien_y_te", soSinh.NhanVienYTe));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianBanGiao", soSinh.ThoiGianBanGiao));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianSinh", soSinh.ThoiGianSinh));
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", soSinh.MaQuanLy));



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

        public static bool Update(SoSinhInterface soSinh, MDB.MDBConnection MyConnection)
        {
            bool result = false;
            try
            {
                string sql = @"update PHIEUSOSINH
                               set 
                                   ma_bn = :ma_bn,
                                   benh_an=:benh_an,
                                   ma_so=:ma_so,
                                   ten_so_sinh=:ten_so_sinh,
                                   ten_me=:ten_me,ten_bo=:ten_bo,tuoi_me=:tuoi_me,tuoi_bo=:tuoi_bo,dia_chi=:dia_chi,sinh_luc_gio=:sinh_luc_gio,sinh_luc_phut=:sinh_luc_phut,sinh_luc_ngay=:sinh_luc_ngay,sinh_luc_thang=:sinh_luc_thang,sinh_luc_nam=:sinh_luc_nam,gioi_tinh=:gioi_tinh,trong_luong=:trong_luong,tuan_thai=:tuan_thai,
                                   phuong_phap_sinh=:phuong_phap_sinh,
                                   khuyet_tat=:khuyet_tat,
                                    SangLoc=:SangLoc,
                                    LoaiVacXin=:LoaiVacXin,
                                    TiemChung=:TiemChung,
                                    NXPhuSan=:NXPhuSan,
                                    NXPhuSan_ThoiGian=:NXPhuSan_ThoiGian,
                                    NXKhoaNhi=:NXKhoaNhi,
                                    NXKhoaNhi_ThoiGian=:NXKhoaNhi_ThoiGian,
                                    TheoDoi=:TheoDoi,
                                   khuyet_tat_mo_ta=:khuyet_tat_mo_ta,
                                   ban_giao_gio=:ban_giao_gio,
                                   ban_giao_phut=:ban_giao_phut,
                                   ban_giao_ngay=:ban_giao_ngay,
                                   ban_giao_thang=:ban_giao_thang,
                                   ban_giao_nam=:ban_giao_nam,
                                   so_me_con=:so_me_con,
                                   cam_ket=:cam_ket,
                                   nhan_vien_y_te=:nhan_vien_y_te,
                                   ThoiGianBanGiao=:ThoiGianBanGiao,
                                   ThoiGianSinh=:ThoiGianSinh,
                                   MaQuanLy=:MaQuanLy
                             where id = :id";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("id", soSinh.Id));
                Command.Parameters.Add(new MDB.MDBParameter("ma_bn", soSinh.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("benh_an", soSinh.BenhAn));
                Command.Parameters.Add(new MDB.MDBParameter("ma_so", soSinh.MaSo));
                Command.Parameters.Add(new MDB.MDBParameter("ten_so_sinh", soSinh.TenSoSinh));
                Command.Parameters.Add(new MDB.MDBParameter("ten_me", soSinh.TenMe));
                Command.Parameters.Add(new MDB.MDBParameter("ten_bo", soSinh.TenBo));
                Command.Parameters.Add(new MDB.MDBParameter("tuoi_me", soSinh.TuoiMe));
                Command.Parameters.Add(new MDB.MDBParameter("tuoi_bo", soSinh.TuoiBo));
                Command.Parameters.Add(new MDB.MDBParameter("dia_chi", soSinh.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("sinh_luc_gio", soSinh.SinhLucGio));
                Command.Parameters.Add(new MDB.MDBParameter("sinh_luc_phut", soSinh.SinhLucPhut));
                Command.Parameters.Add(new MDB.MDBParameter("sinh_luc_ngay", soSinh.SinhLucNgay));
                Command.Parameters.Add(new MDB.MDBParameter("sinh_luc_thang", soSinh.SinhLucThang));
                Command.Parameters.Add(new MDB.MDBParameter("sinh_luc_nam", soSinh.SinhLucNam));
                Command.Parameters.Add(new MDB.MDBParameter("gioi_tinh", soSinh.Gioitinh));
                Command.Parameters.Add(new MDB.MDBParameter("trong_luong", soSinh.TrongLuong));
                Command.Parameters.Add(new MDB.MDBParameter("tuan_thai", soSinh.TuanThai));
                Command.Parameters.Add(new MDB.MDBParameter("phuong_phap_sinh", soSinh.PhuongPhapSinh));
                Command.Parameters.Add(new MDB.MDBParameter("khuyet_tat", soSinh.KhuyetTat));
                Command.Parameters.Add(new MDB.MDBParameter("SangLoc", soSinh.SangLoc));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiVacXin", soSinh.LoaiVacXin));
                Command.Parameters.Add(new MDB.MDBParameter("TiemChung", soSinh.TiemChung));
                Command.Parameters.Add(new MDB.MDBParameter("NXPhuSan", soSinh.NXPhuSan));
                Command.Parameters.Add(new MDB.MDBParameter("NXPhuSan_ThoiGian", soSinh.NXPhuSan_ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("NXKhoaNhi", soSinh.NXKhoaNhi));
                Command.Parameters.Add(new MDB.MDBParameter("NXKhoaNhi_ThoiGian", soSinh.NXKhoaNhi_ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("TheoDoi", soSinh.TheoDoi));
                Command.Parameters.Add(new MDB.MDBParameter("khuyet_tat_mo_ta", soSinh.KhuyetTatMoTa));
                Command.Parameters.Add(new MDB.MDBParameter("ban_giao_gio", soSinh.BanGiaoGio));
                Command.Parameters.Add(new MDB.MDBParameter("ban_giao_phut", soSinh.BanGiaoPhut));
                Command.Parameters.Add(new MDB.MDBParameter("ban_giao_ngay", soSinh.BanGiaoNgay));
                Command.Parameters.Add(new MDB.MDBParameter("ban_giao_thang", soSinh.BanGiaoThang));
                Command.Parameters.Add(new MDB.MDBParameter("ban_giao_nam", soSinh.BanGiaoNam));
                Command.Parameters.Add(new MDB.MDBParameter("so_me_con", soSinh.SoMeCon));
                Command.Parameters.Add(new MDB.MDBParameter("cam_ket", soSinh.CamKet));
                Command.Parameters.Add(new MDB.MDBParameter("nhan_vien_y_te", soSinh.NhanVienYTe));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianBanGiao", soSinh.ThoiGianBanGiao));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianSinh", soSinh.ThoiGianSinh));
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", soSinh.MaQuanLy));
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
    }
}
