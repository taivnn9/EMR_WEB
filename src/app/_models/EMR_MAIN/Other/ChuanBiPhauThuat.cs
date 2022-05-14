
using EMR.KyDienTu;
using System;
using System.Collections.Generic;
using System.Data;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class ChuanBiPhauThuat : ThongTinKy
    {
        public ChuanBiPhauThuat()
        {
            IDMauPhieu = (int)DanhMucPhieu.CBTPT;
            TenMauPhieu = DanhMucPhieu.CBTPT.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public decimal IDChuanBiTruocMo { get; set; }
        [MoTaDuLieu("Bệnh viện")]
		public string BenhVien { get; set; }
        [MoTaDuLieu("Tên khoa")]
		public string TenKhoa { get; set; }
        [MoTaDuLieu("Mã bệnh án")]
		public string MaBenhAn { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        public string SoVaoVien { get; set; }
        public string HoTen { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public string DiUng { get; set; }
        public int Is_VeSinh { get; set; } //1: co, 0 :khong
        public int Is_SonMong { get; set; } //1: co, 0 :khong
        public int Is_CatMong { get; set; } //1: co, 0 :khong
        public int Is_ThaoTrangSuc { get; set; } //1: co, 0 :khong
        public int Is_ThaoRangGia { get; set; } //1: co, 0 :khong
        public int Is_QuanAoSach { get; set; } //1: co, 0 :khong
        public int Is_VSRon { get; set; } //1: co, 0 :khong
        public int Is_VSVungDaMo { get; set; } //1: co, 0 :khong
        public int Is_BangVungDaMo { get; set; } //1: co, 0 :khong
        public int Is_DuHoSoBA { get; set; } //1: co, 0 :khong
        public int Is_KyPhieuCamDoan { get; set; } //1: co, 0 :khong
        public int Is_PhieuXNNhomMau { get; set; } //1: co, 0 :khong
        public int Is_PhimChup { get; set; } //1: co, 0 :khong
        public int Is_DienTim { get; set; } //1: co, 0 :khong
        public int Is_NhinAn { get; set; } //1: co, 0 :khong
        [MoTaDuLieu("Mạch")]
		public string Mach { get; set; }
        [MoTaDuLieu("Nhiệt độ")]
		public string NhietDo { get; set; }
        [MoTaDuLieu("Huyết áp")]
		public string HuyetAp { get; set; }
        [MoTaDuLieu("Nhịp thở")]
		public string NhipTho { get; set; }
        [MoTaDuLieu("Chiều cao")]
		public string ChieuCao { get; set; }
        [MoTaDuLieu("Cân nặng")]
		public string CanNang { get; set; }
        public DateTime ThoiGianChuyen { get; set; }
        public DateTime ThoiGianNhan { get; set; }
        public string YKien { get; set; }
        public string NguoiChuanBi { get; set; }
        public string NguoiGiao { get; set; }
        public string NguoiNhan { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        public string ThongTinKhac1 { get; set; }
        public string ThongTinKhac2 { get; set; }
        public string ThongTinKhac3 { get; set; }
        public string ThongTinKhac4 { get; set; }
        public string ThongTinKhac5 { get; set; }
        public string ThongTinKhac6 { get; set; }
        public string ThongTinKhac7 { get; set; }
        public string ThongTinKhac8 { get; set; }
        public string MaNVNguoiChuanBi { get; set; }
        public string MaNVNguoiGiao { get; set; }
        public string MaNVNguoiNhan { get; set; }
        public string TienSuPT { get; set; }
        public string TienSuBenhNoiKhoa { get; set; }
        public string ThuocTruocGM { get; set; }
        public string YLenhTiepTheo { get; set; }

        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }

        //public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
    }

    public class ChuanBiPhauThuatFunc
    {
        public const string TableName = "CHUANBITRUOCMO";
        public const string TablePrimaryKeyName = "IDChuanBiTruocMo";

        public static decimal InsertOrUpdate(MDB.MDBConnection MyConnection, ChuanBiPhauThuat ChuanBiPhauThuat)
        {
            string sql = @"SELECT IDCHUANBITRUOCMO FROM CHUANBITRUOCMO WHERE IDCHUANBITRUOCMO = :IDCHUANBITRUOCMO";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("IDCHUANBITRUOCMO", ChuanBiPhauThuat.IDChuanBiTruocMo));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            decimal sequence_nextval = 0;
            int rowCount = 0;
            while (DataReader.Read()) rowCount++;
            if (rowCount == 1)
            {
                sequence_nextval = ChuanBiPhauThuat.IDChuanBiTruocMo;
                sql = @"update CHUANBITRUOCMO set BenhVien = :BenhVien, MAQUANLY = : MAQUANLY, TenKhoa=:TenKhoa ,MaBenhAn=:MaBenhAn ,SoVaoVien=:SoVaoVien ,HoTen=:HoTen ,Tuoi=:Tuoi ,GioiTinh=:GioiTinh,ChanDoan =:ChanDoan, DiUng=:DiUng, Is_VeSinh=:Is_VeSinh , Is_SonMong=:Is_SonMong , Is_CatMong=:Is_CatMong ,"
                        + " Is_ThaoTrangSuc=:Is_ThaoTrangSuc , Is_ThaoRangGia=:Is_ThaoRangGia , Is_QuanAoSach =:Is_QuanAoSach, Is_VSRon=:Is_VSRon , Is_VSVungDaMo=:Is_VSVungDaMo , Is_BangVungDaMo=:Is_BangVungDaMo, Is_DuHoSoBA =:Is_DuHoSoBA,Is_KyPhieuCamDoan=:Is_KyPhieuCamDoan ,"
                        + " Is_PhieuXNNhomMau=:Is_PhieuXNNhomMau , Is_PhimChup=:Is_PhimChup , Is_DienTim =:Is_DienTim, Is_NhinAn=:Is_NhinAn , Mach=:Mach ,NhietDo=:NhietDo ,HuyetAp=:HuyetAp ,NhipTho=:NhipTho ,ChieuCao=:ChieuCao ,"
                        + " CanNang=:CanNang ,ThoiGianChuyen=to_date(:ThoiGianChuyen,'yyyyMMddHH24mi') ,ThoiGianNhan=to_date(:ThoiGianNhan,'yyyyMMddHH24mi') ,YKien=:YKien ,NguoiChuanBi=:NguoiChuanBi ,NguoiGiao=:NguoiGiao ,NguoiNhan=:NguoiNhan ,NgayTao=to_date(:NgayTao,'yyyyMMddHH24mi') ,NgaySua=to_date(:NgaySua,'yyyyMMddHH24mi'), ThongTinKhac1=:ThongTinKhac1,ThongTinKhac2=:ThongTinKhac2,ThongTinKhac3=:ThongTinKhac3,ThongTinKhac4=:ThongTinKhac4,ThongTinKhac5=:ThongTinKhac5,ThongTinKhac6=:ThongTinKhac6,ThongTinKhac7=:ThongTinKhac7,ThongTinKhac8=:ThongTinKhac8, MaNVNguoiChuanBi=:MaNVNguoiChuanBi, MaNVNguoiGiao=:MaNVNguoiGiao, MaNVNguoiNhan=:MaNVNguoiNhan,TienSuPT = :TienSuPT, TienSuBenhNoiKhoa = :TienSuBenhNoiKhoa , ThuocTruocGM  = :ThuocTruocGM, YLenhTiepTheo = :YLenhTiepTheo WHERE IDChuanBiTruocMo = " + ChuanBiPhauThuat.IDChuanBiTruocMo + "";
            }
            else
            {
                sql = @"select ID_CHUANBITRUOCMO_SEQ.nextval sequence_nextval from dual";
                Command = new MDB.MDBCommand(sql, MyConnection);
                DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    sequence_nextval = decimal.Parse(DataReader["sequence_nextval"].ToString());
                }
                sql = @"insert into CHUANBITRUOCMO (IDChuanBiTruocMo, BenhVien , MAQUANLY, TenKhoa ,MaBenhAn ,SoVaoVien ,HoTen ,Tuoi ,GioiTinh,ChanDoan, DiUng, Is_VeSinh , Is_SonMong , Is_CatMong , Is_ThaoTrangSuc , Is_ThaoRangGia , Is_QuanAoSach , Is_VSRon , Is_VSVungDaMo , Is_BangVungDaMo, Is_DuHoSoBA ,Is_KyPhieuCamDoan , Is_PhieuXNNhomMau , Is_PhimChup , Is_DienTim , Is_NhinAn , Mach ,NhietDo ,HuyetAp ,NhipTho ,ChieuCao ,CanNang ,ThoiGianChuyen ,ThoiGianNhan ,YKien ,NguoiChuanBi ,NguoiGiao ,NguoiNhan ,NgayTao ,NgaySua,ThongTinKhac1,ThongTinKhac2,ThongTinKhac3,ThongTinKhac4,ThongTinKhac5,ThongTinKhac6,ThongTinKhac7,ThongTinKhac8, MaNVNguoiChuanBi, MaNVNguoiGiao, MaNVNguoiNhan,TienSuPT, TienSuBenhNoiKhoa , ThuocTruocGM , YLenhTiepTheo) "
                    + "values (:IDChuanBiTruocMo,:BenhVien , :MAQUANLY, :TenKhoa ,:MaBenhAn ,:SoVaoVien ,:HoTen ,:Tuoi ,:GioiTinh,:ChanDoan, :DiUng, :Is_VeSinh , :Is_SonMong , :Is_CatMong , :Is_ThaoTrangSuc , :Is_ThaoRangGia , :Is_QuanAoSach , :Is_VSRon , :Is_VSVungDaMo , :Is_BangVungDaMo, :Is_DuHoSoBA ,:Is_KyPhieuCamDoan , :Is_PhieuXNNhomMau , :Is_PhimChup , :Is_DienTim , :Is_NhinAn , :Mach ,:NhietDo ,:HuyetAp ,:NhipTho ,:ChieuCao ,:CanNang ,to_date(:ThoiGianChuyen,'yyyyMMddHH24mi') ,to_date(:ThoiGianNhan,'yyyyMMddHH24mi') ,:YKien ,:NguoiChuanBi ,:NguoiGiao ,:NguoiNhan ,to_date(:NgayTao,'yyyyMMddHH24mi') ,to_date(:NgaySua,'yyyyMMddHH24mi'),:ThongTinKhac1,:ThongTinKhac2,:ThongTinKhac3,:ThongTinKhac4,:ThongTinKhac5,:ThongTinKhac6,:ThongTinKhac7,:ThongTinKhac8, :MaNVNguoiChuanBi, :MaNVNguoiGiao, :MaNVNguoiNhan, :TienSuPT, :TienSuBenhNoiKhoa , :ThuocTruocGM , :YLenhTiepTheo)";
            }
            Command = new MDB.MDBCommand(sql, MyConnection);
            if (rowCount != 1) Command.Parameters.Add(new MDB.MDBParameter("IDChuanBiTruocMo", sequence_nextval));
            Command.Parameters.Add(new MDB.MDBParameter("BenhVien", ChuanBiPhauThuat.BenhVien));
            Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", ChuanBiPhauThuat.MaQuanLy));
            Command.Parameters.Add(new MDB.MDBParameter("TenKhoa", ChuanBiPhauThuat.TenKhoa));
            Command.Parameters.Add(new MDB.MDBParameter("MaBenhAn", ChuanBiPhauThuat.MaBenhAn));
            Command.Parameters.Add(new MDB.MDBParameter("SoVaoVien", ChuanBiPhauThuat.SoVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("HoTen", ChuanBiPhauThuat.HoTen));
            Command.Parameters.Add(new MDB.MDBParameter("Tuoi", ChuanBiPhauThuat.Tuoi));
            Command.Parameters.Add(new MDB.MDBParameter("GioiTinh", ChuanBiPhauThuat.GioiTinh));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", ChuanBiPhauThuat.ChanDoan));
            Command.Parameters.Add(new MDB.MDBParameter("DiUng", ChuanBiPhauThuat.DiUng));
            Command.Parameters.Add(new MDB.MDBParameter("Is_VeSinh", ChuanBiPhauThuat.Is_VeSinh));
            Command.Parameters.Add(new MDB.MDBParameter("Is_SonMong", ChuanBiPhauThuat.Is_SonMong));
            Command.Parameters.Add(new MDB.MDBParameter("Is_CatMong", ChuanBiPhauThuat.Is_CatMong));
            Command.Parameters.Add(new MDB.MDBParameter("Is_ThaoTrangSuc", ChuanBiPhauThuat.Is_ThaoTrangSuc));
            Command.Parameters.Add(new MDB.MDBParameter("Is_ThaoRangGia", ChuanBiPhauThuat.Is_ThaoRangGia));
            Command.Parameters.Add(new MDB.MDBParameter("Is_QuanAoSach", ChuanBiPhauThuat.Is_QuanAoSach));
            Command.Parameters.Add(new MDB.MDBParameter("Is_VSRon", ChuanBiPhauThuat.Is_VSRon));
            Command.Parameters.Add(new MDB.MDBParameter("Is_VSVungDaMo", ChuanBiPhauThuat.Is_VSVungDaMo));
            Command.Parameters.Add(new MDB.MDBParameter("Is_BangVungDaMo", ChuanBiPhauThuat.Is_BangVungDaMo));
            Command.Parameters.Add(new MDB.MDBParameter("Is_DuHoSoBA", ChuanBiPhauThuat.Is_DuHoSoBA));
            Command.Parameters.Add(new MDB.MDBParameter("Is_KyPhieuCamDoan", ChuanBiPhauThuat.Is_KyPhieuCamDoan));
            Command.Parameters.Add(new MDB.MDBParameter("Is_PhieuXNNhomMau", ChuanBiPhauThuat.Is_PhieuXNNhomMau));
            Command.Parameters.Add(new MDB.MDBParameter("Is_PhimChup", ChuanBiPhauThuat.Is_PhimChup));
            Command.Parameters.Add(new MDB.MDBParameter("Is_DienTim", ChuanBiPhauThuat.Is_DienTim));
            Command.Parameters.Add(new MDB.MDBParameter("Is_NhinAn", ChuanBiPhauThuat.Is_NhinAn));
            Command.Parameters.Add(new MDB.MDBParameter("Mach", ChuanBiPhauThuat.Mach));
            Command.Parameters.Add(new MDB.MDBParameter("NhietDo", ChuanBiPhauThuat.NhietDo));
            Command.Parameters.Add(new MDB.MDBParameter("HuyetAp", ChuanBiPhauThuat.HuyetAp));
            Command.Parameters.Add(new MDB.MDBParameter("NhipTho", ChuanBiPhauThuat.NhipTho));
            Command.Parameters.Add(new MDB.MDBParameter("ChieuCao", ChuanBiPhauThuat.ChieuCao));
            Command.Parameters.Add(new MDB.MDBParameter("CanNang", ChuanBiPhauThuat.CanNang));
            Command.Parameters.Add(new MDB.MDBParameter("ThoiGianChuyen", ChuanBiPhauThuat.ThoiGianChuyen.ToString("yyyyMMddHHmm")));
            Command.Parameters.Add(new MDB.MDBParameter("ThoiGianNhan", ChuanBiPhauThuat.ThoiGianNhan.ToString("yyyyMMddHHmm")));
            Command.Parameters.Add(new MDB.MDBParameter("YKien", ChuanBiPhauThuat.YKien));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiChuanBi", ChuanBiPhauThuat.NguoiChuanBi));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiGiao", ChuanBiPhauThuat.NguoiGiao));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiNhan", ChuanBiPhauThuat.NguoiNhan));
            Command.Parameters.Add(new MDB.MDBParameter("NgayTao", ChuanBiPhauThuat.NgayTao.ToString("yyyyMMddHHmm")));
            Command.Parameters.Add(new MDB.MDBParameter("NgaySua", ChuanBiPhauThuat.NgaySua.ToString("yyyyMMddHHmm")));
            Command.Parameters.Add(new MDB.MDBParameter("ThongTinKhac1", ChuanBiPhauThuat.ThongTinKhac1));
            Command.Parameters.Add(new MDB.MDBParameter("ThongTinKhac2", ChuanBiPhauThuat.ThongTinKhac2));
            Command.Parameters.Add(new MDB.MDBParameter("ThongTinKhac3", ChuanBiPhauThuat.ThongTinKhac3));
            Command.Parameters.Add(new MDB.MDBParameter("ThongTinKhac4", ChuanBiPhauThuat.ThongTinKhac4));
            Command.Parameters.Add(new MDB.MDBParameter("ThongTinKhac5", ChuanBiPhauThuat.ThongTinKhac5));
            Command.Parameters.Add(new MDB.MDBParameter("ThongTinKhac6", ChuanBiPhauThuat.ThongTinKhac6));
            Command.Parameters.Add(new MDB.MDBParameter("ThongTinKhac7", ChuanBiPhauThuat.ThongTinKhac7));
            Command.Parameters.Add(new MDB.MDBParameter("ThongTinKhac8", ChuanBiPhauThuat.ThongTinKhac8));
            Command.Parameters.Add(new MDB.MDBParameter("MaNVNguoiChuanBi", ChuanBiPhauThuat.MaNVNguoiChuanBi));
            Command.Parameters.Add(new MDB.MDBParameter("MaNVNguoiGiao", ChuanBiPhauThuat.MaNVNguoiGiao));
            Command.Parameters.Add(new MDB.MDBParameter("MaNVNguoiNhan", ChuanBiPhauThuat.MaNVNguoiNhan));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuPT", ChuanBiPhauThuat.TienSuPT));
            Command.Parameters.Add(new MDB.MDBParameter("TienSuBenhNoiKhoa", ChuanBiPhauThuat.TienSuBenhNoiKhoa));
            Command.Parameters.Add(new MDB.MDBParameter("ThuocTruocGM", ChuanBiPhauThuat.ThuocTruocGM));
            Command.Parameters.Add(new MDB.MDBParameter("YLenhTiepTheo", ChuanBiPhauThuat.YLenhTiepTheo));

            int n = Command.ExecuteNonQuery();
            return n > 0 ? sequence_nextval : 0;
        }

        public static List<ChuanBiPhauThuat> GetData(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            List<ChuanBiPhauThuat> lstData = new List<ChuanBiPhauThuat>();
            string sql = @"select * from CHUANBITRUOCMO WHERE  MaQuanLy = :MaQuanLy ORDER BY NgayTao, NgaySua asc";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            while (DataReader.Read())
            {
                decimal temp = 0;
                decimal.TryParse(DataReader["MAQUANLY"].ToString(), out temp);
                lstData.Add(new ChuanBiPhauThuat
                {
                    IDChuanBiTruocMo = decimal.Parse(DataReader["IDChuanBiTruocMo"].ToString()),
                    BenhVien = DataReader["BenhVien"].ToString(),
                    TenKhoa = DataReader["TenKhoa"].ToString(),
                    MaBenhAn = DataReader["MaBenhAn"].ToString(),
                    MaQuanLy = temp,
                    SoVaoVien = DataReader["SoVaoVien"].ToString(),
                    HoTen = DataReader["HoTen"].ToString(),
                    Tuoi = DataReader["Tuoi"].ToString(),
                    GioiTinh = DataReader["GioiTinh"].ToString(),
                    ChanDoan = DataReader["ChanDoan"].ToString(),
                    DiUng = DataReader["DiUng"].ToString(),
                    Is_BangVungDaMo = Convert.ToInt32(DataReader.GetLong("Is_BangVungDaMo").ToString()),
                    Is_CatMong = Convert.ToInt32(DataReader.GetLong("Is_CatMong").ToString()),
                    Is_DienTim = Convert.ToInt32(DataReader.GetLong("Is_DienTim").ToString()),
                    Is_DuHoSoBA = Convert.ToInt32(DataReader.GetLong("Is_DuHoSoBA").ToString()),
                    Is_KyPhieuCamDoan = Convert.ToInt32(DataReader.GetLong("Is_KyPhieuCamDoan").ToString()),
                    Is_NhinAn = Convert.ToInt32(DataReader.GetLong("Is_NhinAn").ToString()),
                    Is_PhieuXNNhomMau = Convert.ToInt32(DataReader.GetLong("Is_PhieuXNNhomMau").ToString()),
                    Is_PhimChup = Convert.ToInt32(DataReader.GetLong("Is_PhimChup").ToString()),
                    Is_QuanAoSach = Convert.ToInt32(DataReader.GetLong("Is_QuanAoSach").ToString()),
                    Is_SonMong = Convert.ToInt32(DataReader.GetLong("Is_SonMong").ToString()),
                    Is_ThaoRangGia = Convert.ToInt32(DataReader.GetLong("Is_ThaoRangGia").ToString()),
                    Is_ThaoTrangSuc = Convert.ToInt32(DataReader.GetLong("Is_ThaoTrangSuc").ToString()),
                    Is_VeSinh = Convert.ToInt32(DataReader.GetLong("Is_VeSinh").ToString()),
                    Is_VSRon = Convert.ToInt32(DataReader.GetLong("Is_VSRon").ToString()),
                    Is_VSVungDaMo = Convert.ToInt32(DataReader.GetLong("Is_VSVungDaMo").ToString()),
                    CanNang = DataReader["CanNang"].ToString(),
                    ChieuCao = DataReader["ChieuCao"].ToString(),
                    HuyetAp = DataReader["HuyetAp"].ToString(),
                    Mach = DataReader["Mach"].ToString(),
                    NguoiChuanBi = DataReader["NguoiChuanBi"].ToString(),
                    NguoiGiao = DataReader["NguoiGiao"].ToString(),
                    NguoiNhan = DataReader["NguoiNhan"].ToString(),
                    NhietDo = DataReader["NhietDo"].ToString(),
                    NhipTho = DataReader["NhipTho"].ToString(),
                    YKien = DataReader["YKien"].ToString(),
                    ThoiGianChuyen = (DateTime)DataReader["ThoiGianChuyen"],
                    ThoiGianNhan = (DateTime)DataReader["ThoiGianNhan"],
                    NgayTao = (DateTime)DataReader["NgayTao"],
                    NgaySua = (DateTime)DataReader["NgaySua"],
                    ThongTinKhac1 = DataReader["ThongTinKhac1"].ToString(),
                    ThongTinKhac2 = DataReader["ThongTinKhac2"].ToString(),
                    ThongTinKhac3 = DataReader["ThongTinKhac3"].ToString(),
                    ThongTinKhac4 = DataReader["ThongTinKhac4"].ToString(),
                    ThongTinKhac5 = DataReader["ThongTinKhac5"].ToString(),
                    ThongTinKhac6 = DataReader["ThongTinKhac6"].ToString(),
                    ThongTinKhac7 = DataReader["ThongTinKhac7"].ToString(),
                    ThongTinKhac8 = DataReader["ThongTinKhac8"].ToString(),
                    MaNVNguoiChuanBi = DataReader["MaNVNguoiChuanBi"].ToString(),
                    MaNVNguoiGiao = DataReader["MaNVNguoiGiao"].ToString(),
                    MaNVNguoiNhan = DataReader["MaNVNguoiNhan"].ToString(),
                    TienSuPT = DataReader["TienSuPT"].ToString(),
                    TienSuBenhNoiKhoa = DataReader["TienSuBenhNoiKhoa"].ToString(),
                    ThuocTruocGM = DataReader["ThuocTruocGM"].ToString(),
                    YLenhTiepTheo = DataReader["YLenhTiepTheo"].ToString(),
                    MaSoKy = DataReader["masokyten"].ToString(),
                    DaKy = !string.IsNullOrEmpty(DataReader["masokyten"].ToString()) ? true : false,
                    Chon = false

                });;
            }
            return lstData;
        }
        public static bool Delete(MDB.MDBConnection MyConnection, decimal IDChuanBiTruocMo)
        {
            string sql = "DELETE FROM CHUANBITRUOCMO WHERE IDChuanBiTruocMo = :IDChuanBiTruocMo";
            MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
            command.Parameters.Add(new MDB.MDBParameter("IDChuanBiTruocMo", IDChuanBiTruocMo));
            command.BindByName = true;
            int n = command.ExecuteNonQuery();
            return n > 0 ? true : false;
        }
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, string IDChuanBiTruocMo)
        {
            string sql = @"select a.*, ThoiGianChuyen  rptThoiGianChuyen,"
                        + "ThoiGianNhan  rptThoiGianNhan,"
                        + "case when is_vesinh = 1 then 'x' else '' end is_vesinh_yes, "
                         + " case when is_vesinh = 1 then 'x' else '' end is_vesinh_yes,"
                          + " case when is_vesinh = 0 then 'x' else '' end is_vesinh_no,"
                           + " case when is_sonmong = 1 then 'x' else '' end is_sonmong_yes,"
                           + " case when is_sonmong = 0 then 'x' else '' end is_sonmong_no,"
                           + " case when Is_CatMong = 1 then 'x' else '' end Is_CatMong_yes,"
                           + " case when Is_CatMong = 0 then 'x' else '' end Is_CatMong_no,"
                           + " case when Is_ThaoTrangSuc = 1 then 'x' else '' end Is_ThaoTrangSuc_yes,"
                           + " case when Is_ThaoTrangSuc = 0 then 'x' else '' end Is_ThaoTrangSuc_no,"
                           + " case when Is_ThaoRangGia = 1 then 'x' else '' end Is_ThaoRangGia_yes,"
                           + " case when Is_ThaoRangGia = 0 then 'x' else '' end Is_ThaoRangGia_no,"
                           + " case when Is_QuanAoSach = 1 then 'x' else '' end Is_QuanAoSach_yes,"
                           + " case when Is_QuanAoSach = 0 then 'x' else '' end Is_QuanAoSach_no,"
                           + " case when Is_VSRon = 1 then 'x' else '' end Is_VSRon_yes,"
                           + " case when Is_VSRon = 0 then 'x' else '' end Is_VSRon_no,"
                           + " case when Is_VSVungDaMo = 1 then 'x' else '' end Is_VSVungDaMo_yes,"
                           + " case when Is_VSVungDaMo = 0 then 'x' else '' end Is_VSVungDaMo_no,"
                           + " case when Is_BangVungDaMo = 1 then 'x' else '' end Is_BangVungDaMo_yes,"
                           + " case when Is_BangVungDaMo = 0 then 'x' else '' end Is_BangVungDaMo_no,"
                           + " case when Is_DuHoSoBA = 1 then 'x' else '' end Is_DuHoSoBA_yes,"
                           + " case when Is_DuHoSoBA = 0 then 'x' else '' end Is_DuHoSoBA_no,"
                           + " case when Is_KyPhieuCamDoan = 1 then 'x' else '' end Is_KyPhieuCamDoan_yes,"
                           + " case when Is_KyPhieuCamDoan = 0 then 'x' else '' end Is_KyPhieuCamDoan_no,"
                           + " case when Is_PhieuXNNhomMau = 1 then 'x' else '' end Is_PhieuXNNhomMau_yes,"
                           + " case when Is_PhieuXNNhomMau = 0 then 'x' else '' end Is_PhieuXNNhomMau_no,"
                           + " case when Is_PhimChup = 1 then 'x' else '' end Is_PhimChup_yes,"
                           + " case when Is_PhimChup = 0 then 'x' else '' end Is_PhimChup_no,"
                           + " case when Is_DienTim = 1 then 'x' else '' end Is_DienTim_yes,"
                           + " case when Is_DienTim = 0 then 'x' else '' end Is_DienTim_no,"
                           + " case when Is_NhinAn = 1 then 'x' else '' end Is_NhinAn_yes,"
                           + " case when Is_NhinAn = 0 then 'x' else '' end Is_NhinAn_no"
                        + " from CHUANBITRUOCMO a WHERE  IDChuanBiTruocMo = :IDChuanBiTruocMo ORDER BY NgayTao, NgaySua asc";

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("IDChuanBiTruocMo", IDChuanBiTruocMo));
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            adt.Fill(ds);
            return ds;
        }
    }
}
