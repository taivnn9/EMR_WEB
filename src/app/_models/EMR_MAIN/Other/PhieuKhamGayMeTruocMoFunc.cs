
using EMR.KyDienTu;
using System;
using System.Collections.Generic;
using System.Data;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuKhamGayMeTruocMo : ThongTinKy
    {
        public PhieuKhamGayMeTruocMo()
        {
            TableName = "PHIEUKHAMGAYMETRUOCMO";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.KGMTM;
            TenMauPhieu = DanhMucPhieu.KGMTM.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        public string MaPhieu { get; set; }
        public DateTime ThoiGianTao { get; set; }
        public DateTime ThoiGianKham { get; set; }
        public DateTime? ThoiGianSua { get; set; }
        public string KhoaPhongTao { get; set; }
        public string HoTen { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Nhóm máu")]
		public string NhomMau { get; set; }
        public decimal CanNang { get; set; }
        public decimal ChieuCao { get; set; }
        public string ASA { get; set; }
        public string KCCamGiap { get; set; }
        public string Mullampati { get; set; }
        public string HaMieng { get; set; }
        public bool RangGia { get; set; }
        public bool KhongRangGia { get; set; }
        public bool RangThaoDuoc { get; set; }
        public bool RangCoDinh { get; set; }
        public string GioAnCuoi { get; set; }
        public bool CapCuu { get; set; }
        public bool DaDayDay { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public string HuongXuLy { get; set; }
        public string TienSuNoiKhoa { get; set; }
        public string TienSuNgoaiKhoa { get; set; }
        public string TienSuGayMe { get; set; }
        public string DiUng { get; set; }
        public bool NghienThuocLaThuocLao { get; set; }
        public bool NghienRuou { get; set; }
        public bool NghienMaTuy { get; set; }
        public string BenhLayNhiem { get; set; }
        public string ThuocDangDieuTri { get; set; }
        public string KhamLamSang { get; set; }
        public string KhamTuanHoan { get; set; }
        public string KhamHoHap { get; set; }
        public string KhamThanKinh { get; set; }
        public string KhamCotSong { get; set; }
        public int Mach { get; set; }
        [MoTaDuLieu("Huyết áp")]
		public string HuyetAp { get; set; }
        public string XetNghiemBatThuong { get; set; }
        public string YeuCauBoSung { get; set; }
        public string DuKienCachVaThuocVoCam { get; set; }
        public string YLenhTruocMoVaThuocTienMe { get; set; }
        public string BacSiThucHien { get; set; }
        public DateTime? ThoiGianKhamLai { get; set; }
        public string BacSiGayMe { get; set; }
        public string BacSiGayMe2 { get; set; }
        public bool GiamDau1 { get; set; }
        public bool GiamDau2 { get; set; }
        public bool GiamDau3 { get; set; }
        public bool GiamDau4 { get; set; }
        public bool GiamDau5 { get; set; }
        public bool GiamDau6 { get; set; }
        public string GiamDau { get; set; }
        public string MaNVBacSiThucHien { get; set; }
        public string MaNVBacSiGayMe { get; set; }
        public string MaNVBacSiGayMe2 { get; set; }

        //add
        public string PPMo { get; set; }
        public DateTime? NgayMo { get; set; }
        public string MaPhauThuatVien { get; set; }
        public string TenPhauThuatVien { get; set; }
        public string ND { get; set; }
        public string CN { get; set; }
        public string TTTimMach { get; set; }
        public string KhamGanThan { get; set; }
        [MoTaDuLieu("Nhịp thở")]
		public string NhipTho { get; set; }
        //public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Nghề nghiệp")]
		public string NgheNghiep { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
    }
    public class PhieuKhamGayMeTruocMoFunc
    {
        public const string TableName = "PHIEUKHAMGAYMETRUOCMO";
        public const string TablePrimaryKeyName = "ID";

        public static long InsertOrUpdate(MDB.MDBConnection MyConnection, PhieuKhamGayMeTruocMo PhieuKhamGayMeTruocMo)
        {
            try
            {
                string sql = @"SELECT ID FROM  PHIEUKHAMGAYMETRUOCMO WHERE ID = :ID";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID", PhieuKhamGayMeTruocMo.ID));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                int rowCount = 0;
                while (DataReader.Read()) rowCount++;
                if (rowCount == 1)
                    sql = @"UPDATE PHIEUKHAMGAYMETRUOCMO SET MAPHIEU = :MAPHIEU, THOIGIANTAO = :THOIGIANTAO, KHOAPHONGTAO = :KHOAPHONGTAO, HOTEN = :HOTEN, TUOI = :TUOI, GIOITINH = :GIOITINH, NHOMMAU = :NHOMMAU, CANNANG = :CANNANG, CHIEUCAO = :CHIEUCAO, ASA = :ASA, KCCAMGIAP = :KCCAMGIAP, MULLAMPATI = :MULLAMPATI, HAMIENG = :HAMIENG, RANGGIA = :RANGGIA, KHONGRANGGIA = :KHONGRANGGIA, RANGTHAODUOC = :RANGTHAODUOC, RANGCODINH = :RANGCODINH, GIOANCUOI = :GIOANCUOI, CAPCUU = :CAPCUU, DADAYDAY = :DADAYDAY, CHANDOAN = :CHANDOAN, HUONGXULY = :HUONGXULY, TIENSUNOIKHOA = :TIENSUNOIKHOA, TIENSUNGOAIKHOA = :TIENSUNGOAIKHOA, TIENSUGAYME = :TIENSUGAYME, DIUNG = :DIUNG, NGHIENTHUOCLATHUOCLAO = :NGHIENTHUOCLATHUOCLAO, NGHIENRUOU = :NGHIENRUOU, NGHIENMATUY = :NGHIENMATUY, BENHLAYNHIEM = :BENHLAYNHIEM, THUOCDANGDIEUTRI = :THUOCDANGDIEUTRI, KHAMLAMSANG = :KHAMLAMSANG, KHAMTUANHOAN = :KHAMTUANHOAN, KHAMHOHAP = :KHAMHOHAP, KHAMTHANKINH = :KHAMTHANKINH, KHAMCOTSONG = :KHAMCOTSONG, MACH = :MACH, HUYETAP = :HUYETAP, XETNGHIEMBATTHUONG = :XETNGHIEMBATTHUONG, YEUCAUBOSUNG = :YEUCAUBOSUNG, DUKIENCACHVATHUOCVOCAM = :DUKIENCACHVATHUOCVOCAM, YLENHTRUOCMOVATHUOCTIENME = :YLENHTRUOCMOVATHUOCTIENME, BACSITHUCHIEN = :BACSITHUCHIEN, THOIGIANKHAMLAI = :THOIGIANKHAMLAI, BACSIGAYME = :BACSIGAYME, THOIGIANSUA = :THOIGIANSUA, MAQUANLY = :MAQUANLY, THOIGIANKHAM = :THOIGIANKHAM, BACSIGAYME2 = :BACSIGAYME2, GIAMDAU1 = :GIAMDAU1, GIAMDAU2 = :GIAMDAU2, GIAMDAU3 = :GIAMDAU3, GIAMDAU4 = :GIAMDAU4, GIAMDAU5 = :GIAMDAU5, GIAMDAU6 = :GIAMDAU6, GIAMDAU = :GIAMDAU , MANVBACSITHUCHIEN = :MANVBACSITHUCHIEN, MANVBACSIGAYME = :MANVBACSIGAYME, MANVBACSIGAYME2 = :MANVBACSIGAYME2,PPMo =:PPMo, NgayMo = :NgayMo, MaPhauThuatVien = :MaPhauThuatVien, TenPhauThuatVien = :TenPhauThuatVien, ND = :ND, CN = :CN, TTTimMach = :TTTimMach, KhamGanThan = :KhamGanThan, NhipTho = :NhipTho, NgheNghiep= :NgheNghiep WHERE ID = :ID";
                else
                    sql = @"INSERT INTO PHIEUKHAMGAYMETRUOCMO (MAPHIEU, THOIGIANTAO, KHOAPHONGTAO, HOTEN, TUOI, GIOITINH, NHOMMAU, CANNANG, CHIEUCAO, ASA, KCCAMGIAP, MULLAMPATI, HAMIENG, RANGGIA, KHONGRANGGIA, RANGTHAODUOC, RANGCODINH, GIOANCUOI, CAPCUU, DADAYDAY, CHANDOAN, HUONGXULY, TIENSUNOIKHOA, TIENSUNGOAIKHOA, TIENSUGAYME, DIUNG, NGHIENTHUOCLATHUOCLAO, NGHIENRUOU, NGHIENMATUY, BENHLAYNHIEM, THUOCDANGDIEUTRI, KHAMLAMSANG, KHAMTUANHOAN, KHAMHOHAP, KHAMTHANKINH, KHAMCOTSONG, MACH, HUYETAP, XETNGHIEMBATTHUONG, YEUCAUBOSUNG, DUKIENCACHVATHUOCVOCAM, YLENHTRUOCMOVATHUOCTIENME, BACSITHUCHIEN, THOIGIANKHAMLAI, BACSIGAYME, THOIGIANSUA, MAQUANLY, THOIGIANKHAM, BACSIGAYME2, GIAMDAU1, GIAMDAU2, GIAMDAU3, GIAMDAU4, GIAMDAU5, GIAMDAU6, GIAMDAU, MANVBACSITHUCHIEN, MANVBACSIGAYME, MANVBACSIGAYME2, PPMo,NgayMo,MaPhauThuatVien,TenPhauThuatVien,ND,CN,TTTimMach,KhamGanThan,NhipTho,NgheNghiep) VALUES (:MAPHIEU, :THOIGIANTAO, :KHOAPHONGTAO, :HOTEN, :TUOI, :GIOITINH, :NHOMMAU, :CANNANG, :CHIEUCAO, :ASA, :KCCAMGIAP, :MULLAMPATI, :HAMIENG, :RANGGIA, :KHONGRANGGIA, :RANGTHAODUOC, :RANGCODINH, :GIOANCUOI, :CAPCUU, :DADAYDAY, :CHANDOAN, :HUONGXULY, :TIENSUNOIKHOA, :TIENSUNGOAIKHOA, :TIENSUGAYME, :DIUNG, :NGHIENTHUOCLATHUOCLAO, :NGHIENRUOU, :NGHIENMATUY, :BENHLAYNHIEM, :THUOCDANGDIEUTRI, :KHAMLAMSANG, :KHAMTUANHOAN, :KHAMHOHAP, :KHAMTHANKINH, :KHAMCOTSONG, :MACH, :HUYETAP, :XETNGHIEMBATTHUONG, :YEUCAUBOSUNG, :DUKIENCACHVATHUOCVOCAM, :YLENHTRUOCMOVATHUOCTIENME, :BACSITHUCHIEN, :THOIGIANKHAMLAI, :BACSIGAYME, :THOIGIANSUA, :MAQUANLY, :THOIGIANKHAM, :BACSIGAYME2, :GIAMDAU1, :GIAMDAU2, :GIAMDAU3, :GIAMDAU4, :GIAMDAU5, :GIAMDAU6, :GIAMDAU, :MANVBACSITHUCHIEN, :MANVBACSIGAYME, :MANVBACSIGAYME2, :PPMo, :NgayMo,:MaPhauThuatVien,:TenPhauThuatVien,:ND,:CN,:TTTimMach,:KhamGanThan,:NhipTho, :NgheNghiep) RETURNING ID INTO :ID";
                Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAPHIEU", PhieuKhamGayMeTruocMo.MaPhieu));
                Command.Parameters.Add(new MDB.MDBParameter("THOIGIANTAO", PhieuKhamGayMeTruocMo.ThoiGianTao));
                Command.Parameters.Add(new MDB.MDBParameter("KHOAPHONGTAO", PhieuKhamGayMeTruocMo.KhoaPhongTao));
                Command.Parameters.Add(new MDB.MDBParameter("HOTEN", PhieuKhamGayMeTruocMo.HoTen));
                Command.Parameters.Add(new MDB.MDBParameter("TUOI", PhieuKhamGayMeTruocMo.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("GIOITINH", PhieuKhamGayMeTruocMo.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("NHOMMAU", PhieuKhamGayMeTruocMo.NhomMau));
                Command.Parameters.Add(new MDB.MDBParameter("CANNANG", PhieuKhamGayMeTruocMo.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("CHIEUCAO", PhieuKhamGayMeTruocMo.ChieuCao));
                Command.Parameters.Add(new MDB.MDBParameter("ASA", PhieuKhamGayMeTruocMo.ASA));
                Command.Parameters.Add(new MDB.MDBParameter("KCCAMGIAP", PhieuKhamGayMeTruocMo.KCCamGiap));
                Command.Parameters.Add(new MDB.MDBParameter("MULLAMPATI", PhieuKhamGayMeTruocMo.Mullampati));
                Command.Parameters.Add(new MDB.MDBParameter("HAMIENG", PhieuKhamGayMeTruocMo.HaMieng));
                Command.Parameters.Add(new MDB.MDBParameter("RANGGIA", PhieuKhamGayMeTruocMo.RangGia == true ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("KHONGRANGGIA", PhieuKhamGayMeTruocMo.KhongRangGia == true ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("RANGTHAODUOC", PhieuKhamGayMeTruocMo.RangThaoDuoc == true ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("RANGCODINH", PhieuKhamGayMeTruocMo.RangCoDinh == true ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("GIOANCUOI", PhieuKhamGayMeTruocMo.GioAnCuoi));
                Command.Parameters.Add(new MDB.MDBParameter("CAPCUU", PhieuKhamGayMeTruocMo.CapCuu == true ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("DADAYDAY", PhieuKhamGayMeTruocMo.DaDayDay == true ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("CHANDOAN", PhieuKhamGayMeTruocMo.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("HUONGXULY", PhieuKhamGayMeTruocMo.HuongXuLy));
                Command.Parameters.Add(new MDB.MDBParameter("TIENSUNOIKHOA", PhieuKhamGayMeTruocMo.TienSuNoiKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("TIENSUNGOAIKHOA", PhieuKhamGayMeTruocMo.TienSuNgoaiKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("TIENSUGAYME", PhieuKhamGayMeTruocMo.TienSuGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("DIUNG", PhieuKhamGayMeTruocMo.DiUng));
                Command.Parameters.Add(new MDB.MDBParameter("NGHIENTHUOCLATHUOCLAO", PhieuKhamGayMeTruocMo.NghienThuocLaThuocLao == true ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("NGHIENRUOU", PhieuKhamGayMeTruocMo.NghienRuou == true ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("NGHIENMATUY", PhieuKhamGayMeTruocMo.NghienMaTuy == true ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("BENHLAYNHIEM", PhieuKhamGayMeTruocMo.BenhLayNhiem));
                Command.Parameters.Add(new MDB.MDBParameter("THUOCDANGDIEUTRI", PhieuKhamGayMeTruocMo.ThuocDangDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("KHAMLAMSANG", PhieuKhamGayMeTruocMo.KhamLamSang));
                Command.Parameters.Add(new MDB.MDBParameter("KHAMTUANHOAN", PhieuKhamGayMeTruocMo.KhamTuanHoan));
                Command.Parameters.Add(new MDB.MDBParameter("KHAMHOHAP", PhieuKhamGayMeTruocMo.KhamHoHap));
                Command.Parameters.Add(new MDB.MDBParameter("KHAMTHANKINH", PhieuKhamGayMeTruocMo.KhamThanKinh));
                Command.Parameters.Add(new MDB.MDBParameter("KHAMCOTSONG", PhieuKhamGayMeTruocMo.KhamCotSong));
                Command.Parameters.Add(new MDB.MDBParameter("MACH", PhieuKhamGayMeTruocMo.Mach));
                Command.Parameters.Add(new MDB.MDBParameter("HUYETAP", PhieuKhamGayMeTruocMo.HuyetAp));
                Command.Parameters.Add(new MDB.MDBParameter("XETNGHIEMBATTHUONG", PhieuKhamGayMeTruocMo.XetNghiemBatThuong));
                Command.Parameters.Add(new MDB.MDBParameter("YEUCAUBOSUNG", PhieuKhamGayMeTruocMo.YeuCauBoSung));
                Command.Parameters.Add(new MDB.MDBParameter("DUKIENCACHVATHUOCVOCAM", PhieuKhamGayMeTruocMo.DuKienCachVaThuocVoCam));
                Command.Parameters.Add(new MDB.MDBParameter("YLENHTRUOCMOVATHUOCTIENME", PhieuKhamGayMeTruocMo.YLenhTruocMoVaThuocTienMe));
                Command.Parameters.Add(new MDB.MDBParameter("BACSITHUCHIEN", PhieuKhamGayMeTruocMo.BacSiThucHien));
                Command.Parameters.Add(new MDB.MDBParameter("THOIGIANKHAMLAI", PhieuKhamGayMeTruocMo.ThoiGianKhamLai));
                Command.Parameters.Add(new MDB.MDBParameter("BACSIGAYME", PhieuKhamGayMeTruocMo.BacSiGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("THOIGIANSUA", PhieuKhamGayMeTruocMo.ThoiGianSua));
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", PhieuKhamGayMeTruocMo.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("THOIGIANKHAM", PhieuKhamGayMeTruocMo.ThoiGianKham));
                Command.Parameters.Add(new MDB.MDBParameter("BACSIGAYME2", PhieuKhamGayMeTruocMo.BacSiGayMe2));
                Command.Parameters.Add(new MDB.MDBParameter("GIAMDAU1", PhieuKhamGayMeTruocMo.GiamDau1 == true ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("GIAMDAU2", PhieuKhamGayMeTruocMo.GiamDau2 == true ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("GIAMDAU3", PhieuKhamGayMeTruocMo.GiamDau3 == true ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("GIAMDAU4", PhieuKhamGayMeTruocMo.GiamDau4 == true ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("GIAMDAU5", PhieuKhamGayMeTruocMo.GiamDau5 == true ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("GIAMDAU6", PhieuKhamGayMeTruocMo.GiamDau6 == true ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("GIAMDAU", PhieuKhamGayMeTruocMo.GiamDau));
                Command.Parameters.Add(new MDB.MDBParameter("MANVBACSITHUCHIEN", PhieuKhamGayMeTruocMo.MaNVBacSiThucHien));
                Command.Parameters.Add(new MDB.MDBParameter("MANVBACSIGAYME", PhieuKhamGayMeTruocMo.MaNVBacSiGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("MANVBACSIGAYME2", PhieuKhamGayMeTruocMo.MaNVBacSiGayMe2));
                Command.Parameters.Add(new MDB.MDBParameter("PPMo", PhieuKhamGayMeTruocMo.PPMo));
                Command.Parameters.Add(new MDB.MDBParameter("NgayMo", PhieuKhamGayMeTruocMo.NgayMo));
                Command.Parameters.Add(new MDB.MDBParameter("MaPhauThuatVien", PhieuKhamGayMeTruocMo.MaPhauThuatVien));
                Command.Parameters.Add(new MDB.MDBParameter("TenPhauThuatVien", PhieuKhamGayMeTruocMo.TenPhauThuatVien));
                Command.Parameters.Add(new MDB.MDBParameter("ND", PhieuKhamGayMeTruocMo.ND));
                Command.Parameters.Add(new MDB.MDBParameter("CN", PhieuKhamGayMeTruocMo.CN));
                Command.Parameters.Add(new MDB.MDBParameter("TTTimMach", PhieuKhamGayMeTruocMo.TTTimMach));
                Command.Parameters.Add(new MDB.MDBParameter("KhamGanThan", PhieuKhamGayMeTruocMo.KhamGanThan));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTho", PhieuKhamGayMeTruocMo.NhipTho));
                Command.Parameters.Add(new MDB.MDBParameter("NgheNghiep", PhieuKhamGayMeTruocMo.NgheNghiep));
                Command.Parameters.Add(new MDB.MDBParameter("ID", PhieuKhamGayMeTruocMo.ID));
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                return n > 0 ? nextval : 0;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return 0;
        }
        public static List<PhieuKhamGayMeTruocMo> GetData(string MaQuanLy, MDB.MDBConnection MyConnection)
        {
            List<PhieuKhamGayMeTruocMo> lstData = new List<PhieuKhamGayMeTruocMo>();
            try
            {
                string sql = @"SELECT * FROM PhieuKhamGayMeTruocMo where MAQUANLY = :MAQUANLY";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuKhamGayMeTruocMo result = new PhieuKhamGayMeTruocMo();
                    result.ID = long.Parse(DataReader["ID"].ToString());
                    result.MaQuanLy = decimal.Parse(DataReader["MaQuanLy"].ToString());
                    result.MaPhieu = DataReader["MaPhieu"].ToString();
                    result.ThoiGianTao = DateTime.Parse(DataReader["ThoiGianTao"].ToString());
                    if (DataReader["ThoiGianSua"] != null && DataReader["ThoiGianSua"].ToString() != "")
                        result.ThoiGianSua = DateTime.Parse(DataReader["ThoiGianSua"].ToString());
                    if (DataReader["ThoiGianKham"] != null && DataReader["ThoiGianKham"].ToString() != "")
                        result.ThoiGianKham = DateTime.Parse(DataReader["ThoiGianKham"].ToString());
                    result.KhoaPhongTao = DataReader["KhoaPhongTao"].ToString();
                    result.HoTen = DataReader["HoTen"].ToString();
                    result.Tuoi = DataReader["Tuoi"].ToString();
                    result.GioiTinh = DataReader["GioiTinh"].ToString();
                    result.NhomMau = DataReader["NhomMau"].ToString();
                    decimal tempdecimal = -1;
                    //result.CanNang = Convert.ToDecimal(DataReader.GetDecimal("CanNang").ToString());
                    decimal.TryParse(DataReader["CanNang"].ToString(), out tempdecimal);
                    result.CanNang = tempdecimal;
                    tempdecimal = -1;
                    //result.ChieuCao = Convert.ToDecimal(DataReader.GetDecimal("ChieuCao").ToString());
                    decimal.TryParse(DataReader["ChieuCao"].ToString(), out tempdecimal);
                    result.ChieuCao = tempdecimal;
                    result.ASA = DataReader["ASA"].ToString();
                    result.KCCamGiap = DataReader["KCCamGiap"].ToString();
                    result.Mullampati = DataReader["Mullampati"].ToString();
                    result.HaMieng = DataReader["HaMieng"].ToString();
                    result.RangGia = Convert.ToInt32(DataReader.GetLong("RangGia")) == 1 ? true : false;
                    result.KhongRangGia = Convert.ToInt32(DataReader.GetLong("KhongRangGia")) == 1 ? true : false;
                    result.RangThaoDuoc = Convert.ToInt32(DataReader.GetLong("RangThaoDuoc")) == 1 ? true : false;
                    result.RangCoDinh = Convert.ToInt32(DataReader.GetLong("RangCoDinh")) == 1 ? true : false;
                    result.GioAnCuoi = DataReader["GioAnCuoi"].ToString();
                    result.CapCuu = Convert.ToInt32(DataReader.GetLong("CapCuu")) == 1 ? true : false;
                    result.DaDayDay = Convert.ToInt32(DataReader.GetLong("DaDayDay")) == 1 ? true : false;
                    result.ChanDoan = DataReader["ChanDoan"].ToString();
                    result.HuongXuLy = DataReader["HuongXuLy"].ToString();
                    result.TienSuNoiKhoa = DataReader["TienSuNoiKhoa"].ToString();
                    result.TienSuNgoaiKhoa = DataReader["TienSuNgoaiKhoa"].ToString();
                    result.TienSuGayMe = DataReader["TienSuGayMe"].ToString();
                    result.DiUng = DataReader["DiUng"].ToString();
                    result.NghienThuocLaThuocLao = Convert.ToInt32(DataReader.GetLong("NghienThuocLaThuocLao")) == 1 ? true : false;
                    result.NghienRuou = Convert.ToInt32(DataReader.GetLong("NghienRuou")) == 1 ? true : false;
                    result.NghienMaTuy = Convert.ToInt32(DataReader.GetLong("NghienMaTuy")) == 1 ? true : false;
                    result.BenhLayNhiem = DataReader["BenhLayNhiem"].ToString();
                    result.ThuocDangDieuTri = DataReader["ThuocDangDieuTri"].ToString();
                    result.KhamLamSang = DataReader["KhamLamSang"].ToString();
                    result.KhamTuanHoan = DataReader["KhamTuanHoan"].ToString();
                    result.KhamHoHap = DataReader["KhamHoHap"].ToString();
                    result.KhamThanKinh = DataReader["KhamThanKinh"].ToString();
                    result.KhamCotSong = DataReader["KhamCotSong"].ToString();
                    result.Mach = int.Parse(DataReader["Mach"].ToString());
                    result.HuyetAp = DataReader["HuyetAp"].ToString();
                    result.XetNghiemBatThuong = DataReader["XetNghiemBatThuong"].ToString();
                    result.YeuCauBoSung = DataReader["YeuCauBoSung"].ToString();
                    result.DuKienCachVaThuocVoCam = DataReader["DuKienCachVaThuocVoCam"].ToString();
                    result.YLenhTruocMoVaThuocTienMe = DataReader["YLenhTruocMoVaThuocTienMe"].ToString();
                    result.BacSiThucHien = DataReader["BacSiThucHien"].ToString();
                    if (DataReader["ThoiGianKhamLai"] != null && DataReader["ThoiGianKhamLai"].ToString() != "")
                        result.ThoiGianKhamLai = DateTime.Parse(DataReader["ThoiGianKhamLai"].ToString());
                    result.BacSiGayMe = DataReader["BacSiGayMe"].ToString();
                    result.BacSiGayMe2 = DataReader["BacSiGayMe2"].ToString();
                    result.GiamDau1 = DataReader["GiamDau1"].ToString().Equals("1") ? true : false;
                    result.GiamDau2 = DataReader["GiamDau2"].ToString().Equals("1") ? true : false;
                    result.GiamDau3 = DataReader["GiamDau3"].ToString().Equals("1") ? true : false;
                    result.GiamDau4 = DataReader["GiamDau4"].ToString().Equals("1") ? true : false;
                    result.GiamDau5 = DataReader["GiamDau5"].ToString().Equals("1") ? true : false;
                    result.GiamDau6 = DataReader["GiamDau6"].ToString().Equals("1") ? true : false;
                    result.GiamDau = DataReader["GiamDau"].ToString();
                    result.MaNVBacSiThucHien = DataReader["MaNVBacSiThucHien"].ToString();
                    result.MaNVBacSiGayMe = DataReader["MaNVBacSiGayMe"].ToString();
                    result.MaNVBacSiGayMe2 = DataReader["MaNVBacSiGayMe2"].ToString();
                    result.PPMo = DataReader["PPMo"].ToString();
                    result.NgayMo = ConDB_DateTime(DataReader["NgayMo"]);
                    result.MaPhauThuatVien = DataReader["MaPhauThuatVien"].ToString();
                    result.TenPhauThuatVien = DataReader["TenPhauThuatVien"].ToString();
                    result.ND = DataReader["ND"].ToString();
                    result.CN = DataReader["CN"].ToString();
                    result.TTTimMach = DataReader["TTTimMach"].ToString();
                    result.KhamGanThan = DataReader["KhamGanThan"].ToString();
                    result.NhipTho = DataReader["NhipTho"].ToString();
                    result.NgheNghiep = DataReader["NgheNghiep"].ToString();
                    result.MaSoKy = DataReader["masokyten"].ToString();
                    result.DaKy = !string.IsNullOrEmpty(result.MaSoKy) ? true : false;

                    lstData.Add(result);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return lstData;
        }
        public static DataSet GetDataSet(long ID, MDB.MDBConnection conn)
        {
            DataSet dataSet = new DataSet();
            try
            {
                string sql = @"SELECT P.*, T.Khoa , T.MaKhoa, T.MaBenhAn,
				H.SoYTe, H.BENHVIEN, 
				H.TenBenhNhan, H.maBenhNhan
			  FROM PHIEUKHAMGAYMETRUOCMO P 
				Left JOIN THONGTINDIEUTRI T ON P.MAQUANLY = T.MAQUANLY
				Left JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
			  where ID = :ID";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, conn);
                command.Parameters.Add(new MDB.MDBParameter("ID", ID));
                MDB.MDBDataAdapter dataAdapter = new MDB.MDBDataAdapter(command);
                dataAdapter.Fill(dataSet);
            }
            catch (Exception ex)
            {
                XuLyLoi.LogError(ex);
            }
            return dataSet;
        }
        public static List<long> GetListID(MDB.MDBConnection oracleConnection, decimal MaQuanLy)
        {
            string sql = @"select * from PHIEUKHAMGAYMETRUOCMO where MaQuanLy = :MaQuanLy";
            MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
            oracleCommand.Parameters.Add("MaQuanLy", MaQuanLy);
            MDB.MDBDataReader oracleDataReader = oracleCommand.ExecuteReader();
            List<long> listID = new List<long>();
            while (oracleDataReader.Read())
            {
                listID.Add(long.Parse(oracleDataReader["ID"].ToString()));
            }
            return listID;
        }
        public static bool Delete(MDB.MDBConnection MyConnection, PhieuKhamGayMeTruocMo PhieuKhamGayMeTruocMo)
        {
            bool result = false;
            try
            {
                string sql = @"DELETE PHIEUKHAMGAYMETRUOCMO WHERE ID = :ID";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID", PhieuKhamGayMeTruocMo.ID));
                int n = Command.ExecuteNonQuery();
                return n > 0 ? true : false;
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return result;
        }
        public static DateTime? ConDB_DateTime(object dbVal)
        {
            DateTime ret = DateTime.MinValue;
            if (dbVal == null)
            {
                return null;
            }
            bool isSuccess = DateTime.TryParse(dbVal.ToString(), out ret);
            return ret;
        }
    }
}
