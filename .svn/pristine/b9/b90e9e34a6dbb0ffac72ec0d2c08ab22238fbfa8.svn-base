
using EMR.KyDienTu;
using System;
using System.Data;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class DinhDuongTE:ThongTinKy
    {
        public DinhDuongTE()
        {
            TableName = "Dinhduong_TE";
            TablePrimaryKeyName = "Id";
            IDMauPhieu = (int)DanhMucPhieu.DD_TE;
            TenMauPhieu = DanhMucPhieu.DD_TE.Description();
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
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public double CanNangVaoVien { get; set; }
        public double ChieuCao { get; set; }
        public double BMI { get; set; }
        public int KhoangBMI { get; set; } // 1 : Khoang 1 , 2 : Khoang 2 , 3 : Khoang 3 , 0 : Khac
        public double CanNangRaVien { get; set; }

        public int SutCan { get; set; } // 0 : KhongSutCan, 1,2,3,4,5
        public int LuongAn { get; set; } // 0 : Khong giam ,  1 ,2 
        public int KetLuan { get; set; } // 1 : Binh thuong, 2 :Suy dinh duong
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

        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, DinhDuongTE DinhDuongTE)
        {
            string sql = @"select MaQuanLy from Dinhduong_TE where MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", DinhDuongTE.MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            int rowCount = 0;
            while (DataReader.Read()) rowCount++;
            if (rowCount == 1)
            {
                sql = @"update DinhDuong_TE set SoYTe= :SoYTe,BenhVien = :BenhVien ,Khoa=:Khoa ,HoTenBN=:HoTenBN ,Tuoi=:Tuoi ,GioiTinh=:GioiTinh,ChanDoan =:ChanDoan, CanNangVaoVien=:CanNangVaoVien, ChieuCao=:ChieuCao , BMI=:BMI , CanNangRaVien=:CanNangRaVien ,"
                        + " KhoangBMI=:KhoangBMI , SutCan=:SutCan , LuongAn =:LuongAn, KetLuan=:KetLuan , MaSoCheDoAn=:MaSoCheDoAn , DuongNuoiAn=:DuongNuoiAn, HoiChanDinhDuong =:HoiChanDinhDuong,TaiDanhGia=:TaiDanhGia ,"
                        + " ThoiGianKy=to_date(:ThoiGianKy,'yyyyMMddHH24mi') , BacSy=:BacSy , TrangThai =:TrangThai, NguoiTao=:NguoiTao,NgayTao=to_date(:NgayTao,'yyyyMMddHH24mi'),NgaySua=to_date(:NgaySua,'yyyyMMddHH24mi') WHERE MaQuanLy = :MaQuanLy";
            }
            else
            {
                sql = @"insert into DinhDuong_TE (SoYTe, BenhVien ,Khoa ,HoTenBN ,Tuoi ,GioiTinh ,ChanDoan, CanNangVaoVien, ChieuCao , BMI , CanNangRaVien , KhoangBMI , SutCan , LuongAn , KetLuan , MaSoCheDoAn , DuongNuoiAn, HoiChanDinhDuong ,TaiDanhGia , ThoiGianKy , BacSy , TrangThai , NguoiTao , NgayTao ,NgaySua, MaQuanLy) "
                    + "values (:SoYTe, :BenhVien , :Khoa , :HoTenBN , :Tuoi , :GioiTinh , :ChanDoan, :CanNangVaoVien, :ChieuCao , :BMI , :CanNangRaVien , :KhoangBMI , :SutCan , :LuongAn , :KetLuan , :MaSoCheDoAn , :DuongNuoiAn, :HoiChanDinhDuong , :TaiDanhGia , to_date(:ThoiGianKy,'yyyyMMddHH24mi') , :BacSy , :TrangThai , :NguoiTao , to_date(:NgayTao,'yyyyMMddHH24mi'), to_date(:NgaySua,'yyyyMMddHH24mi'), :MaQuanLy)";
            }
            Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("SoYTe", DinhDuongTE.SoYTe));
            Command.Parameters.Add(new MDB.MDBParameter("BenhVien", DinhDuongTE.BenhVien));
            Command.Parameters.Add(new MDB.MDBParameter("Khoa", DinhDuongTE.Khoa));
            Command.Parameters.Add(new MDB.MDBParameter("HoTenBN", DinhDuongTE.HoTenBN));
            Command.Parameters.Add(new MDB.MDBParameter("Tuoi", DinhDuongTE.Tuoi));
            Command.Parameters.Add(new MDB.MDBParameter("GioiTinh", DinhDuongTE.GioiTinh));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", DinhDuongTE.ChanDoan));
            Command.Parameters.Add(new MDB.MDBParameter("CanNangVaoVien", DinhDuongTE.CanNangVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("ChieuCao", DinhDuongTE.ChieuCao));
            Command.Parameters.Add(new MDB.MDBParameter("BMI", DinhDuongTE.BMI));
            Command.Parameters.Add(new MDB.MDBParameter("CanNangRaVien", DinhDuongTE.CanNangRaVien));
            Command.Parameters.Add(new MDB.MDBParameter("KhoangBMI", DinhDuongTE.KhoangBMI));
            Command.Parameters.Add(new MDB.MDBParameter("SutCan", DinhDuongTE.SutCan));
            Command.Parameters.Add(new MDB.MDBParameter("LuongAn", DinhDuongTE.LuongAn));
            Command.Parameters.Add(new MDB.MDBParameter("KetLuan", DinhDuongTE.KetLuan));
            Command.Parameters.Add(new MDB.MDBParameter("MaSoCheDoAn", DinhDuongTE.MaSoCheDoAn));
            Command.Parameters.Add(new MDB.MDBParameter("DuongNuoiAn", DinhDuongTE.DuongNuoiAn));
            Command.Parameters.Add(new MDB.MDBParameter("HoiChanDinhDuong", DinhDuongTE.HoiChanDinhDuong));
            Command.Parameters.Add(new MDB.MDBParameter("TaiDanhGia", DinhDuongTE.TaiDanhGia));
            Command.Parameters.Add(new MDB.MDBParameter("ThoiGianKy", DinhDuongTE.ThoiGianKy.ToString("yyyyMMddHHmm")));
            Command.Parameters.Add(new MDB.MDBParameter("BacSy", DinhDuongTE.BacSy));
            Command.Parameters.Add(new MDB.MDBParameter("TrangThai", DinhDuongTE.TrangThai));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiTao", DinhDuongTE.NguoiTao));
            Command.Parameters.Add(new MDB.MDBParameter("NgayTao", DinhDuongTE.NgayTao.ToString("yyyyMMddHHmm")));
            Command.Parameters.Add(new MDB.MDBParameter("NgaySua", DinhDuongTE.NgaySua.ToString("yyyyMMddHHmm")));
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", DinhDuongTE.MaQuanLy));

            int n = Command.ExecuteNonQuery();
            return n > 0 ? true : false;
        }

        public static DinhDuongTE GetData(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            DinhDuongTE _DinhDuongTE = null;
            string sql = @"select * from DinhDuong_TE where  MaQuanLy = :MaQuanLy and TrangThai = 1";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            while (DataReader.Read())
            {
                _DinhDuongTE = new DinhDuongTE
                {
                    Id = decimal.Parse(DataReader["Id"].ToString()),
                    MaQuanLy = Convert.ToDecimal(DataReader.GetDecimal("MaQuanLy").ToString()),
                    SoYTe = DataReader["SoYTe"].ToString(),
                    BenhVien = DataReader["BenhVien"].ToString(),
                    Khoa = DataReader["Khoa"].ToString(),
                    HoTenBN = DataReader["HoTenBN"].ToString(),
                    Tuoi = DataReader["Tuoi"].ToString(),
                    GioiTinh = DataReader["GioiTinh"].ToString(),
                    ChanDoan = DataReader["ChanDoan"].ToString(),
                    CanNangVaoVien = Common.ConDB_double(DataReader["CanNangVaoVien"]),
                    ChieuCao = Common.ConDB_double(DataReader["ChieuCao"]),
                    BMI = Common.ConDB_double(DataReader["BMI"]),
                    CanNangRaVien = Common.ConDB_double(DataReader["CanNangRaVien"]),
                    KhoangBMI = Convert.ToInt16(DataReader.GetLong("KhoangBMI").ToString()),
                    SutCan = Convert.ToInt16(DataReader.GetLong("SutCan").ToString()),
                    LuongAn = Convert.ToInt16(DataReader.GetLong("LuongAn").ToString()),
                    KetLuan = Convert.ToInt16(DataReader.GetLong("KetLuan").ToString()),
                    MaSoCheDoAn = DataReader["MaSoCheDoAn"].ToString(),
                    DuongNuoiAn = Convert.ToInt16(DataReader.GetLong("DuongNuoiAn").ToString()),
                    HoiChanDinhDuong = Convert.ToInt16(DataReader.GetLong("HoiChanDinhDuong").ToString()),
                    TaiDanhGia = Convert.ToInt16(DataReader.GetLong("TaiDanhGia").ToString()),
                    ThoiGianKy = (DateTime)DataReader["ThoiGianKy"],
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
            return _DinhDuongTE;
        }

        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql = @"select a.*, to_char(ThoiGianKy, 'dd/MM/yyyy') rptThoiGianKy"
                        + " from DinhDuong_TE a WHERE  MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            adt.Fill(ds);
            return ds;
        }

        public static bool Delete(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            string sql = @"update Dinhduong_TE set TrangThai = 0 where MaQuanLy = :MaQuanLy";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
            int n = Command.ExecuteNonQuery();
            return n > 0 ? true : false;
        }

    }
}
