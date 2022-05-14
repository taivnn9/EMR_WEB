
using EMR.KyDienTu;
using System;
using System.Data;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class DinhDuongPTMT : ThongTinKy
    {
        public DinhDuongPTMT()
        {
            TableName = "DinhDuong_PNMT";
            TablePrimaryKeyName = "Id";
            IDMauPhieu = (int)DanhMucPhieu.DD_PNMT;
            TenMauPhieu = DanhMucPhieu.DD_PNMT.Description();
        }
        public decimal Id { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Sở Y Tế")]
		public string SoYTe { get; set; }
        [MoTaDuLieu("Bệnh viện")]
		public string BenhVien { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        public string HoTenBN { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        public int TuoiThai { get; set; }
        public int BatDauTuoiThai { get; set; } // 0 : Khac , 1: Theo ngay kinh cuoi, 2  : Sieu am 3 thang dau
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public double CanNangTruocMangThai { get; set; }
        public double ChieuCao { get; set; }
        public double BMITruocMangThai {
            get
            {
                return _BMITruocMangThai;
            }
            set
            {
                _BMITruocMangThai = value;
            }
        }
        public double CanNangHienTai { get; set; }
        public double ChuViVongCanhTay {
            get
            {
                return _ChuViVongCanhTay;
            }
            set
            {
                _ChuViVongCanhTay = value;
            }
        }
        public int TocDoTangCan { get; set; } // 0 : Khac, 1 : Theo khuyen nghi, 2 : Khong theo khuyen nghi
        public int BenhKemTheo { get; set; } // 1 : Khong, 2 :Co 
        public int KetLuan { get; set; } // 1 : Binh thuong, 2 :Co nguy co ve dinh duong
        public string MaSoCheDoAn { get; set; }
        public int DuongNuoiAn { get; set; } // 0 : Khac, 1 : Duong mieng, 2 : Ong thong, 3 : Tinh Mach
        public int HoiChanDinhDuong { get; set; } // 1: Khong , 2 : Co
        public int TaiDanhGia { get; set; } //0 : Khac , 1 : 7 ngay , 2 : 3 ngay
        public DateTime ThoiGianKy { get; set; }
        [MoTaDuLieu("Bác sỹ")]
		public string BacSy { get; set; }
        public int TrangThai { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }

        private double _BMITruocMangThai;
        private double _ChuViVongCanhTay;
        public bool IsBMIRange01
        {
            get { return _BMITruocMangThai >= 18.5 && _BMITruocMangThai <= 24.9 ? true : false; }
        }
        public bool IsBMIRange02
        {
            get { return _BMITruocMangThai > 25 ? true : false; }
        }
        public bool IsBMIRange03
        {
            get { return _BMITruocMangThai < 18.5 ? true : false; }
        }
        public bool IsChuViVCTRange01
        {
            get { return _ChuViVongCanhTay >= 23 ? true : false; }
        }
        public bool IsChuViVCTRange02
        {
            get { return _ChuViVongCanhTay < 23 ? true : false; }
        }

        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, DinhDuongPTMT DinhDuongPTMT)
        {
            string sql = @"select MaQuanLy from Dinhduong_PNMT where MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", DinhDuongPTMT.MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            int rowCount = 0;
            while (DataReader.Read()) rowCount++;
            if (rowCount == 1)
            {
                sql = @"update DinhDuong_PNMT set SoYTe= :SoYTe,BenhVien = :BenhVien ,Khoa=:Khoa ,HoTenBN=:HoTenBN ,Tuoi=:Tuoi ,TuoiThai=:TuoiThai ,BatDauTuoiThai=:BatDauTuoiThai,ChanDoan =:ChanDoan, CanNangTruocMangThai=:CanNangTruocMangThai, ChieuCao=:ChieuCao , BMITruocMangThai=:BMITruocMangThai , CanNangHienTai=:CanNangHienTai ,"
                        + " ChuViVongCanhTay=:ChuViVongCanhTay , TocDoTangCan=:TocDoTangCan , BenhKemTheo =:BenhKemTheo, KetLuan=:KetLuan , MaSoCheDoAn=:MaSoCheDoAn , DuongNuoiAn=:DuongNuoiAn, HoiChanDinhDuong =:HoiChanDinhDuong,TaiDanhGia=:TaiDanhGia ,"
                        + " ThoiGianKy=to_date(:ThoiGianKy,'yyyyMMddHH24mi') , BacSy=:BacSy , TrangThai =:TrangThai, NguoiTao=:NguoiTao,NgayTao=to_date(:NgayTao,'yyyyMMddHH24mi'),NgaySua=to_date(:NgaySua,'yyyyMMddHH24mi') WHERE MaQuanLy = :MaQuanLy";
            }
            else
            {
                sql = @"insert into DinhDuong_PNMT (SoYTe, BenhVien ,Khoa ,HoTenBN ,Tuoi ,TuoiThai ,BatDauTuoiThai ,ChanDoan, CanNangTruocMangThai, ChieuCao , BMITruocMangThai , CanNangHienTai , ChuViVongCanhTay , TocDoTangCan , BenhKemTheo , KetLuan , MaSoCheDoAn , DuongNuoiAn, HoiChanDinhDuong ,TaiDanhGia , ThoiGianKy , BacSy , TrangThai , NguoiTao , NgayTao ,NgaySua, MaQuanLy) "
                    + "values (:SoYTe, :BenhVien , :Khoa , :HoTenBN , :Tuoi , :TuoiThai , :BatDauTuoiThai , :ChanDoan, :CanNangTruocMangThai, :ChieuCao , :BMITruocMangThai , :CanNangHienTai , :ChuViVongCanhTay , :TocDoTangCan , :BenhKemTheo , :KetLuan , :MaSoCheDoAn , :DuongNuoiAn, :HoiChanDinhDuong , :TaiDanhGia , to_date(:ThoiGianKy,'yyyyMMddHH24mi') , :BacSy , :TrangThai , :NguoiTao , to_date(:NgayTao,'yyyyMMddHH24mi'), to_date(:NgaySua,'yyyyMMddHH24mi'), :MaQuanLy)";
            }
            Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("SoYTe", DinhDuongPTMT.SoYTe));
            Command.Parameters.Add(new MDB.MDBParameter("BenhVien", DinhDuongPTMT.BenhVien));
            Command.Parameters.Add(new MDB.MDBParameter("Khoa", DinhDuongPTMT.Khoa));
            Command.Parameters.Add(new MDB.MDBParameter("HoTenBN", DinhDuongPTMT.HoTenBN));
            Command.Parameters.Add(new MDB.MDBParameter("Tuoi", DinhDuongPTMT.Tuoi));
            Command.Parameters.Add(new MDB.MDBParameter("TuoiThai", DinhDuongPTMT.TuoiThai));
            Command.Parameters.Add(new MDB.MDBParameter("BatDauTuoiThai", DinhDuongPTMT.BatDauTuoiThai));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", DinhDuongPTMT.ChanDoan));
            Command.Parameters.Add(new MDB.MDBParameter("CanNangTruocMangThai", DinhDuongPTMT.CanNangTruocMangThai));
            Command.Parameters.Add(new MDB.MDBParameter("ChieuCao", DinhDuongPTMT.ChieuCao));
            Command.Parameters.Add(new MDB.MDBParameter("BMITruocMangThai", DinhDuongPTMT.BMITruocMangThai));
            Command.Parameters.Add(new MDB.MDBParameter("CanNangHienTai", DinhDuongPTMT.CanNangHienTai));
            Command.Parameters.Add(new MDB.MDBParameter("ChuViVongCanhTay", DinhDuongPTMT.ChuViVongCanhTay));
            Command.Parameters.Add(new MDB.MDBParameter("TocDoTangCan", DinhDuongPTMT.TocDoTangCan));
            Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", DinhDuongPTMT.BenhKemTheo));
            Command.Parameters.Add(new MDB.MDBParameter("KetLuan", DinhDuongPTMT.KetLuan));
            Command.Parameters.Add(new MDB.MDBParameter("MaSoCheDoAn", DinhDuongPTMT.MaSoCheDoAn));
            Command.Parameters.Add(new MDB.MDBParameter("DuongNuoiAn", DinhDuongPTMT.DuongNuoiAn));
            Command.Parameters.Add(new MDB.MDBParameter("HoiChanDinhDuong", DinhDuongPTMT.HoiChanDinhDuong));
            Command.Parameters.Add(new MDB.MDBParameter("TaiDanhGia", DinhDuongPTMT.TaiDanhGia));
            Command.Parameters.Add(new MDB.MDBParameter("ThoiGianKy", DinhDuongPTMT.ThoiGianKy.ToString("yyyyMMddHHmm")));
            Command.Parameters.Add(new MDB.MDBParameter("BacSy", DinhDuongPTMT.BacSy));
            Command.Parameters.Add(new MDB.MDBParameter("TrangThai", DinhDuongPTMT.TrangThai));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiTao", DinhDuongPTMT.NguoiTao));
            Command.Parameters.Add(new MDB.MDBParameter("NgayTao", DinhDuongPTMT.NgayTao.ToString("yyyyMMddHHmm")));
            Command.Parameters.Add(new MDB.MDBParameter("NgaySua", DinhDuongPTMT.NgaySua.ToString("yyyyMMddHHmm")));
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", DinhDuongPTMT.MaQuanLy));

            int n = Command.ExecuteNonQuery();
            return n > 0 ? true : false;
        }

        public static DinhDuongPTMT GetData(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            DinhDuongPTMT _DinhDuongPTMT = null;
            string sql = @"select * from DinhDuong_PNMT where  MaQuanLy = :MaQuanLy and TrangThai = 1";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            while (DataReader.Read())
            {
                _DinhDuongPTMT = new DinhDuongPTMT
                {
                    Id = decimal.Parse(DataReader["Id"].ToString()),
                    MaQuanLy = Convert.ToDecimal(DataReader.GetDecimal("MaQuanLy").ToString()),
                    SoYTe = DataReader["SoYTe"].ToString(),
                    BenhVien = DataReader["BenhVien"].ToString(),
                    Khoa = DataReader["Khoa"].ToString(),
                    HoTenBN = DataReader["HoTenBN"].ToString(),
                    Tuoi = DataReader["Tuoi"].ToString(),
                    TuoiThai = Convert.ToInt32(DataReader.GetLong("TuoiThai").ToString()),
                    BatDauTuoiThai = Convert.ToInt16(DataReader.GetLong("BatDauTuoiThai").ToString()),
                    ChanDoan = DataReader["ChanDoan"].ToString(),
                    CanNangTruocMangThai = Convert.ToDouble(DataReader.GetDecimal("CanNangTruocMangThai").ToString()),
                    ChieuCao = Convert.ToDouble(DataReader.GetDecimal("ChieuCao").ToString()),
                    BMITruocMangThai = Convert.ToDouble(DataReader.GetDecimal("BMITruocMangThai").ToString()),
                    CanNangHienTai = Convert.ToDouble(DataReader.GetDecimal("CanNangHienTai").ToString()),
                    ChuViVongCanhTay = Convert.ToDouble(DataReader.GetDecimal("ChuViVongCanhTay").ToString()),
                    TocDoTangCan = Convert.ToInt16(DataReader.GetLong("TocDoTangCan").ToString()),
                    BenhKemTheo = Convert.ToInt16(DataReader.GetLong("BenhKemTheo").ToString()),
                    KetLuan = Convert.ToInt16(DataReader.GetLong("KetLuan").ToString()),
                    MaSoCheDoAn = DataReader["MaSoCheDoAn"].ToString(),
                    DuongNuoiAn = Convert.ToInt16(DataReader.GetLong("DuongNuoiAn").ToString()),
                    HoiChanDinhDuong = Convert.ToInt16(DataReader.GetLong("HoiChanDinhDuong").ToString()),
                    TaiDanhGia = Convert.ToInt16(DataReader.GetLong("TaiDanhGia").ToString()),
                    ThoiGianKy = (DateTime)DataReader.GetDate("ThoiGianKy"),
                    BacSy = DataReader["BacSy"].ToString(),
                    TrangThai = Convert.ToInt16(DataReader.GetLong("TrangThai").ToString()),
                    NguoiTao = DataReader["NguoiTao"].ToString(),
                    NgayTao = DataReader.GetDate("NgayTao"),
                    NgaySua = DataReader.GetDate("NgaySua"),
                    MaSoKy = DataReader.GetString("masokyten"),
                    NgayKy = DataReader.GetDate("ngayky"),
                    TenFileKy = DataReader.GetString("tenfileky"),
                    UserNameKy = DataReader.GetString("usernameky"),
                };
            }
            return _DinhDuongPTMT;
        }

        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql = @"select a.*, to_char(ThoiGianKy, 'dd/MM/yyyy') rptThoiGianKy"
                        + " from DinhDuong_PNMT a WHERE  MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            adt.Fill(ds);
            return ds;
        }

        public static bool Delete(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql = @"update Dinhduong_PNMT set TrangThai = 0 where MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy",MaQuanLy));
            int n = Command.ExecuteNonQuery();
            return n > 0 ? true : false;
        }
    }
}
