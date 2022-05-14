
using EMR.KyDienTu;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class TheoDoiDieuTriHIVTbl : ThongTinKy
    {
        public List <TheoDoiDieuTriHIV_ChiTietTbl> LstTTChiTiet { get; set; }
        [MoTaDuLieu("Mã định danh")]
		public decimal IDMaPhieu { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Bệnh viện")]
		public string BenhVien { get; set; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }
        public string KhoaPhong { get; set; }
        public string HoTen { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }

        public DateTime? NgayKhangDinh { get; set; }
        public string NoiKhangDinh { get; set; }
        public DateTime? NgayBatDauDieuTriARVLamSan { get; set; }
        public string GiaiDoanLamSanARV { get; set; }
        public string CD4 { get; set; }
        public DateTime? NgayBatDauPhatDoARV { get; set; }
        public string PhatDoARV { get; set; }
        public DateTime? NgayChuyenARV { get; set; }
        public string ChuyenTuARV { get; set; }
        public DateTime? NgayBatDauDieuTriARV { get; set; }
        public DateTime? NgayThayThuoc1PhacDoC1 { get; set; }
        public string PhacDoMoi1PhacDoC1 { get; set; }
        public string LiDo1PhacDoC1 { get; set; }
        public DateTime? NgayThayThuoc2PhacDoC1 { get; set; }
        public string PhacDoMoi2PhacDoC1 { get; set; }
        public string LiDo2PhacDoC1 { get; set; }
        public DateTime? NgayThayThuoc3PhacDoC1 { get; set; }
        public string PhacDoMoi3PhacDoC1 { get; set; }
        public string LiDo3PhacDoC1 { get; set; }
        public DateTime? NgayThayThuoc4PhacDoC1 { get; set; }
        public string PhacDoMoi4PhacDoC1 { get; set; }
        public string LiDo4PhacDoC1 { get; set; }
        public DateTime? NgayThayThuoc1PhacDoC2 { get; set; }
        public string PhacDoMoi1PhacDoC2 { get; set; }
        public string LiDo1PhacDoC2 { get; set; }
        public DateTime? NgayThayThuoc2PhacDoC2 { get; set; }
        public string PhacDoMoi2PhacDoC2 { get; set; }
        public string LiDo2PhacDoC2 { get; set; }
        public DateTime? NgayThayThuoc3PhacDoC2 { get; set; }
        public string PhacDoMoi3PhacDoC2 { get; set; }
        public string LiDo3PhacDoC2 { get; set; }
        public DateTime? NgayThayThuoc4PhacDoC2 { get; set; }
        public string PhacDoMoi4PhacDoC2 { get; set; }
        public string LiDo4PhacDoC2 { get; set; }
        public DateTime? NgayTuVong { get; set; }
        public string TuVong { get; set; }
        public string LiDoKetThucTheoDoi { get; set; }
        public DateTime? NgayChuyenDi { get; set; }
        public string NoiDi { get; set; }
        public DateTime? NgayNgungThuoc1 { get; set; }
        public DateTime? NgayNgungThuoc2 { get; set; }
        public DateTime? NgayBoDieuTri { get; set; }
        public DateTime? NgayMatDau { get; set; }
        public DateTime? NgayNgungThuoc3 { get; set; }
        public DateTime? NgayNgungThuoc4 { get; set; }
        public string LiDoNgungThuoc1 { get; set; }
        public string LiDoNgungThuoc2 { get; set; }
        public string LiDoNgungThuoc3 { get; set; }
        public string LiDoNgungThuoc4 { get; set; }
        public DateTime? NgayTaidieuTri1 { get; set; }
        public DateTime? NgayTaidieuTri2 { get; set; }
        public DateTime? NgayTaidieuTri3 { get; set; }
        public DateTime? NgayTaidieuTri4 { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        //public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
        public TheoDoiDieuTriHIVTbl()
        {
            LstTTChiTiet = new List<TheoDoiDieuTriHIV_ChiTietTbl>();
        }
    }
    public class TheoDoiDieuTriHIV_ChiTietTbl
    {
        [MoTaDuLieu("Mã định danh")]
		public decimal IDMaPhieuChiTiet { get; set; }
        [MoTaDuLieu("Mã định danh")]
		public decimal IDMaPhieu { get; set; }
        public DateTime? NgayKham { get; set; }
        public DateTime? NgayKhamLai { get; set; }
        [MoTaDuLieu("Cân nặng")]
		public string CanNang { get; set; }
        [MoTaDuLieu("Chiều cao")]
		public string ChieuCao { get; set; }
        [MoTaDuLieu("Diễn biến bệnh")]
		public string DienBienBenh { get; set; }
        public string GDLS { get; set; }
        public string DieuTri { get; set; }
        public string TenNguoiDieuTri { get; set; }
        [MoTaDuLieu("Ghi chú")]
		public string GhiChu { get; set; }
    }
    public class TheoDoiDieuTriHIVFunc
    {
        public const string TableName = "TheoDoiDieuTriHIV";
        public const string TablePrimaryKeyName = "IDMaPhieu";
        
        public static bool DeleteByIDMaPhieu(MDB.MDBConnection oracleConnection, List<decimal> IDBienBan)
        {
            try
            {
                string sql = "";
                string strWhere = "";
                MDB.MDBCommand oracleCommand;
                strWhere = "In(";
                if (IDBienBan.Count > 0)
                {
                    for (int i = 0; i < IDBienBan.Count; i++)
                    {
                        strWhere = strWhere + IDBienBan[i].ToString();
                        if (i == (IDBienBan.Count - 1))
                        {
                            strWhere = strWhere + ")";
                        }
                        else
                        {
                            strWhere = strWhere + ",";
                        }
                    }
                }
                sql = @"DELETE FROM TheoDoiDieuTriHIV WHERE IDMaPhieu " + strWhere;
                using (oracleCommand = new MDB.MDBCommand(sql, oracleConnection))
                {
                    oracleCommand.ExecuteNonQuery();
                }
                sql = @"DELETE FROM theodoidieutrihiv_chitiet WHERE IDMaPhieu " + strWhere;
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
        public static bool Delete_ChiTietPhieu(MDB.MDBConnection MyConnection, decimal IDMaPhieuChiTiet)
        {
            try
            {
                string sql = "DELETE FROM theodoidieutrihiv_chitiet WHERE IDMaPhieuChiTiet = :IDMaPhieuChiTiet";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                command.Parameters.Add(new MDB.MDBParameter("IDMaPhieuChiTiet", IDMaPhieuChiTiet));
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
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, string IDMaPhieu)
        {
            string sql = @"select AA.*, BB.Khoa  AS KHOAPHONGNAME "
                         + " from TheoDoiDieuTriHIV AA left join thongtindieutri BB  on AA.MaQuanLy = BB.MaQuanLy WHERE IDMaPhieu =: IDMaPhieu";
            MDB.MDBCommand Command;
            MDB.MDBDataAdapter adt;
            using (Command = new MDB.MDBCommand(sql, MyConnection))
            {
                Command.Parameters.Add(new MDB.MDBParameter("IDMaPhieu", IDMaPhieu));
                adt = new MDB.MDBDataAdapter(Command);
            }
            var ds = new DataSet();
            adt.Fill(ds, "ThongTinTheoDoi");
            sql = @"select AA.*, CONCAT(CONCAT(to_char(NgayKham,'DD/MM/YYYY'), '-'), to_char(NgayKhamLai,'DD/MM/YYYY')) as NgayKham_NgayKhamLai, CONCAT(CONCAT(CanNang, '/'), ChieuCao) as CanNang_ChieuCao  from theodoidieutrihiv_chitiet AA where IDMaPhieu = :IDMaPhieu ORDER BY IDMaPhieuChiTiet";
            Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("IDMaPhieu", IDMaPhieu));
            MDB.MDBDataAdapter adt1 = new MDB.MDBDataAdapter(Command);
            adt1.Fill(ds, "ThongTinCT");

            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection oracleConnection, TheoDoiDieuTriHIVTbl obj, ref bool isUpdate)
        {
            try
            {
                string sql = @"SELECT COUNT(*) RECNUM FROM TheoDoiDieuTriHIV WHERE IDMaPhieu = :IDMaPhieu";
                MDB.MDBCommand oracleCommand;
                int rowCount = 0;
                int nRecord = 0;
                decimal sequence_nextval = 0;
                using (oracleCommand = new MDB.MDBCommand(sql, oracleConnection))
                {
                    oracleCommand.Parameters.Add("IDMaPhieu", obj.IDMaPhieu);
                    MDB.MDBDataReader oracleDataReader = oracleCommand.ExecuteReader();
                    while (oracleDataReader.Read())
                    {
                        rowCount = int.Parse(oracleDataReader["RECNUM"].ToString());
                    }
                }
                if (rowCount > 0)
                {
                    isUpdate = true;
                    sequence_nextval = obj.IDMaPhieu;
                    sql = "update TheoDoiDieuTriHIV set MaQuanLy= :MaQuanLy,KhoaPhong= :KhoaPhong,BenhVien= :BenhVien,MaKhoa= :MaKhoa,HoTen= :HoTen,MaBenhNhan= :MaBenhNhan,NgayKhangDinh= :NgayKhangDinh,NoiKhangDinh= :NoiKhangDinh,NgayBatDauDieuTriARVLamSan= :NgayBatDauDieuTriARVLamSan,GiaiDoanLamSanARV= :GiaiDoanLamSanARV,CD4= :CD4,NgayBatDauPhatDoARV= :NgayBatDauPhatDoARV,PhatDoARV= :PhatDoARV,NgayChuyenARV= :NgayChuyenARV,ChuyenTuARV= :ChuyenTuARV,NgayBatDauDieuTriARV= :NgayBatDauDieuTriARV,NgayThayThuoc1PhacDoC1= :NgayThayThuoc1PhacDoC1,PhacDoMoi1PhacDoC1= :PhacDoMoi1PhacDoC1,LiDo1PhacDoC1= :LiDo1PhacDoC1,NgayThayThuoc2PhacDoC1= :NgayThayThuoc2PhacDoC1,PhacDoMoi2PhacDoC1= :PhacDoMoi2PhacDoC1,LiDo2PhacDoC1= :LiDo2PhacDoC1,NgayThayThuoc3PhacDoC1= :NgayThayThuoc3PhacDoC1,PhacDoMoi3PhacDoC1= :PhacDoMoi3PhacDoC1,LiDo3PhacDoC1= :LiDo3PhacDoC1,NgayThayThuoc4PhacDoC1= :NgayThayThuoc4PhacDoC1,PhacDoMoi4PhacDoC1= :PhacDoMoi4PhacDoC1,LiDo4PhacDoC1= :LiDo4PhacDoC1,NgayThayThuoc1PhacDoC2= :NgayThayThuoc1PhacDoC2,PhacDoMoi1PhacDoC2= :PhacDoMoi1PhacDoC2,LiDo1PhacDoC2= :LiDo1PhacDoC2,NgayThayThuoc2PhacDoC2= :NgayThayThuoc2PhacDoC2,PhacDoMoi2PhacDoC2= :PhacDoMoi2PhacDoC2,LiDo2PhacDoC2= :LiDo2PhacDoC2,NgayThayThuoc3PhacDoC2= :NgayThayThuoc3PhacDoC2,PhacDoMoi3PhacDoC2= :PhacDoMoi3PhacDoC2,LiDo3PhacDoC2= :LiDo3PhacDoC2,NgayThayThuoc4PhacDoC2= :NgayThayThuoc4PhacDoC2,PhacDoMoi4PhacDoC2= :PhacDoMoi4PhacDoC2,LiDo4PhacDoC2= :LiDo4PhacDoC2,NgayTuVong= :NgayTuVong,TuVong= :TuVong,LiDoKetThucTheoDoi= :LiDoKetThucTheoDoi,NgayChuyenDi= :NgayChuyenDi,NoiDi= :NoiDi,NgayBoDieuTri= :NgayBoDieuTri,NgayMatDau= :NgayMatDau,NgayNgungThuoc1= :NgayNgungThuoc1,NgayNgungThuoc2= :NgayNgungThuoc2,NgayNgungThuoc3= :NgayNgungThuoc3,NgayNgungThuoc4= :NgayNgungThuoc4,LiDoNgungThuoc1= :LiDoNgungThuoc1,LiDoNgungThuoc2= :LiDoNgungThuoc2,LiDoNgungThuoc3= :LiDoNgungThuoc3,LiDoNgungThuoc4= :LiDoNgungThuoc4,NgayTaidieuTri1= :NgayTaidieuTri1,NgayTaidieuTri2= :NgayTaidieuTri2,NgayTaidieuTri3= :NgayTaidieuTri3,NgayTaidieuTri4= :NgayTaidieuTri4, NgayTao= :NgayTao, NgaySua= :NgaySua";
                    sql = sql + ",MASOKYTEN = :MASOKYTEN ";
                    sql = sql + " WHERE IDMaPhieu = " + obj.IDMaPhieu.ToString();
                }
                else
                {
                    sql = @"select NVL(MAX(IDMaPhieu),0) AS sequence_nextval from TheoDoiDieuTriHIV";
                    using (oracleCommand = new MDB.MDBCommand(sql, oracleConnection))
                    {
                        MDB.MDBDataReader oracleDataReader = oracleCommand.ExecuteReader();
                        while (oracleDataReader.Read())
                        {
                            sequence_nextval = decimal.Parse(oracleDataReader["sequence_nextval"].ToString()) + 1;
                        }
                    }
                    sql = @"insert into TheoDoiDieuTriHIV(IDMaPhieu,MaQuanLy,KhoaPhong,BenhVien,MaKhoa,HoTen,MaBenhNhan,NgayKhangDinh,NoiKhangDinh,NgayBatDauDieuTriARVLamSan,GiaiDoanLamSanARV,CD4,NgayBatDauPhatDoARV,PhatDoARV,NgayChuyenARV,ChuyenTuARV,NgayBatDauDieuTriARV,NgayThayThuoc1PhacDoC1,PhacDoMoi1PhacDoC1,LiDo1PhacDoC1,NgayThayThuoc2PhacDoC1,PhacDoMoi2PhacDoC1,LiDo2PhacDoC1,NgayThayThuoc3PhacDoC1,PhacDoMoi3PhacDoC1,LiDo3PhacDoC1,NgayThayThuoc4PhacDoC1,PhacDoMoi4PhacDoC1,LiDo4PhacDoC1,NgayThayThuoc1PhacDoC2,PhacDoMoi1PhacDoC2,LiDo1PhacDoC2,NgayThayThuoc2PhacDoC2,PhacDoMoi2PhacDoC2,LiDo2PhacDoC2,NgayThayThuoc3PhacDoC2,PhacDoMoi3PhacDoC2,LiDo3PhacDoC2,NgayThayThuoc4PhacDoC2,PhacDoMoi4PhacDoC2,LiDo4PhacDoC2,NgayTuVong,TuVong,LiDoKetThucTheoDoi,NgayChuyenDi,NoiDi,NgayBoDieuTri,NgayMatDau,NgayNgungThuoc1,NgayNgungThuoc2,NgayNgungThuoc3,NgayNgungThuoc4,LiDoNgungThuoc1,LiDoNgungThuoc2,LiDoNgungThuoc3,LiDoNgungThuoc4,NgayTaidieuTri1,NgayTaidieuTri2,NgayTaidieuTri3,NgayTaidieuTri4, NgayTao,NgaySua" +
                        ",MASOKYTEN)";
                    sql = sql + @"Values( :IDMaPhieu, :MaQuanLy, :KhoaPhong, :BenhVien, :MaKhoa, :HoTen, :MaBenhNhan, :NgayKhangDinh, :NoiKhangDinh, :NgayBatDauDieuTriARVLamSan, :GiaiDoanLamSanARV, :CD4, :NgayBatDauPhatDoARV, :PhatDoARV, :NgayChuyenARV, :ChuyenTuARV, :NgayBatDauDieuTriARV, :NgayThayThuoc1PhacDoC1, :PhacDoMoi1PhacDoC1, :LiDo1PhacDoC1, :NgayThayThuoc2PhacDoC1, :PhacDoMoi2PhacDoC1, :LiDo2PhacDoC1, :NgayThayThuoc3PhacDoC1, :PhacDoMoi3PhacDoC1, :LiDo3PhacDoC1, :NgayThayThuoc4PhacDoC1, :PhacDoMoi4PhacDoC1, :LiDo4PhacDoC1, :NgayThayThuoc1PhacDoC2, :PhacDoMoi1PhacDoC2, :LiDo1PhacDoC2, :NgayThayThuoc2PhacDoC2, :PhacDoMoi2PhacDoC2, :LiDo2PhacDoC2, :NgayThayThuoc3PhacDoC2, :PhacDoMoi3PhacDoC2, :LiDo3PhacDoC2, :NgayThayThuoc4PhacDoC2, :PhacDoMoi4PhacDoC2, :LiDo4PhacDoC2, :NgayTuVong, :TuVong, :LiDoKetThucTheoDoi, :NgayChuyenDi, :NoiDi, :NgayBoDieuTri, :NgayMatDau, :NgayNgungThuoc1, :NgayNgungThuoc2, :NgayNgungThuoc3, :NgayNgungThuoc4, :LiDoNgungThuoc1, :LiDoNgungThuoc2, :LiDoNgungThuoc3, :LiDoNgungThuoc4, :NgayTaidieuTri1, :NgayTaidieuTri2, :NgayTaidieuTri3, :NgayTaidieuTri4, :NgayTao, :NgaySua  " +
                        ",:MASOKYTEN" +
                        ")";
                }
                using (oracleCommand = new MDB.MDBCommand(sql, oracleConnection))
                {
                    if (rowCount <= 0)
                    {
                        oracleCommand.Parameters.Add(new MDB.MDBParameter("IDMaPhieu", sequence_nextval));
                    }

                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaQuanLy", obj.MaQuanLy));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("KhoaPhong", obj.KhoaPhong));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("BenhVien", obj.BenhVien));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaKhoa", obj.MaKhoa));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("HoTen", obj.HoTen));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", obj.MaBenhNhan));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayKhangDinh", obj.NgayKhangDinh));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NoiKhangDinh", obj.NoiKhangDinh));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayBatDauDieuTriARVLamSan", obj.NgayBatDauDieuTriARVLamSan));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("GiaiDoanLamSanARV", obj.GiaiDoanLamSanARV));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CD4", obj.CD4));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayBatDauPhatDoARV", obj.NgayBatDauPhatDoARV));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("PhatDoARV", obj.PhatDoARV));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayChuyenARV", obj.NgayChuyenARV));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ChuyenTuARV", obj.ChuyenTuARV));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayBatDauDieuTriARV", obj.NgayBatDauDieuTriARV));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayThayThuoc1PhacDoC1", obj.NgayThayThuoc1PhacDoC1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("PhacDoMoi1PhacDoC1", obj.PhacDoMoi1PhacDoC1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("LiDo1PhacDoC1", obj.LiDo1PhacDoC1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayThayThuoc2PhacDoC1", obj.NgayThayThuoc2PhacDoC1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("PhacDoMoi2PhacDoC1", obj.PhacDoMoi2PhacDoC1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("LiDo2PhacDoC1", obj.LiDo2PhacDoC1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayThayThuoc3PhacDoC1", obj.NgayThayThuoc3PhacDoC1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("PhacDoMoi3PhacDoC1", obj.PhacDoMoi3PhacDoC1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("LiDo3PhacDoC1", obj.LiDo3PhacDoC1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayThayThuoc4PhacDoC1", obj.NgayThayThuoc4PhacDoC1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("PhacDoMoi4PhacDoC1", obj.PhacDoMoi4PhacDoC1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("LiDo4PhacDoC1", obj.LiDo4PhacDoC1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayThayThuoc1PhacDoC2", obj.NgayThayThuoc1PhacDoC2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("PhacDoMoi1PhacDoC2", obj.PhacDoMoi1PhacDoC2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("LiDo1PhacDoC2", obj.LiDo1PhacDoC2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayThayThuoc2PhacDoC2", obj.NgayThayThuoc2PhacDoC2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("PhacDoMoi2PhacDoC2", obj.PhacDoMoi2PhacDoC2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("LiDo2PhacDoC2", obj.LiDo2PhacDoC2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayThayThuoc3PhacDoC2", obj.NgayThayThuoc3PhacDoC2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("PhacDoMoi3PhacDoC2", obj.PhacDoMoi3PhacDoC2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("LiDo3PhacDoC2", obj.LiDo3PhacDoC2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayThayThuoc4PhacDoC2", obj.NgayThayThuoc4PhacDoC2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("PhacDoMoi4PhacDoC2", obj.PhacDoMoi4PhacDoC2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("LiDo4PhacDoC2", obj.LiDo4PhacDoC2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayTuVong", obj.NgayTuVong));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TuVong", obj.TuVong));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("LiDoKetThucTheoDoi", obj.LiDoKetThucTheoDoi));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayChuyenDi", obj.NgayChuyenDi));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NoiDi", obj.NoiDi));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayBoDieuTri", obj.NgayBoDieuTri));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayMatDau", obj.NgayMatDau));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayNgungThuoc1", obj.NgayNgungThuoc1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayNgungThuoc2", obj.NgayNgungThuoc2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayNgungThuoc3", obj.NgayNgungThuoc3));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayNgungThuoc4", obj.NgayNgungThuoc4));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("LiDoNgungThuoc1", obj.LiDoNgungThuoc1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("LiDoNgungThuoc2", obj.LiDoNgungThuoc2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("LiDoNgungThuoc3", obj.LiDoNgungThuoc3));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("LiDoNgungThuoc4", obj.LiDoNgungThuoc4));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayTaidieuTri1", obj.NgayTaidieuTri1));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayTaidieuTri2", obj.NgayTaidieuTri2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayTaidieuTri3", obj.NgayTaidieuTri3));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayTaidieuTri4", obj.NgayTaidieuTri4));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayTao", obj.NgayTao));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgaySua", obj.NgaySua));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MASOKYTEN", obj.MaSoKy));
                    nRecord = oracleCommand.ExecuteNonQuery();
                }
                if (nRecord > 0)
                {
                    obj.IDMaPhieu = sequence_nextval;
                }
                return nRecord > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.LogError(ex);
            }
            return false;
        }
        public static bool InsertOrUpdate_Chittiet(MDB.MDBConnection oracleConnection, TheoDoiDieuTriHIV_ChiTietTbl obj)
        {
            try
            {
                string sql = @"SELECT COUNT(*) RECNUM FROM TheoDoiDieuTriHIV_ChiTiet WHERE IDMaPhieuChiTiet = :IDMaPhieuChiTiet and IDMaPhieu = :IDMaPhieu";
                MDB.MDBCommand oracleCommand;
                int rowCount = 0;
                int nRecord = 0;
                decimal sequence_nextval = 0;
                using (oracleCommand = new MDB.MDBCommand(sql, oracleConnection))
                {
                    oracleCommand.Parameters.Add("IDMaPhieuChiTiet", obj.IDMaPhieuChiTiet);
                    oracleCommand.Parameters.Add("IDMaPhieu", obj.IDMaPhieu);
                    MDB.MDBDataReader oracleDataReader = oracleCommand.ExecuteReader();
                    while (oracleDataReader.Read())
                    {
                        rowCount = int.Parse(oracleDataReader["RECNUM"].ToString());
                    }
                }
                if (rowCount > 0)
                {
                    sequence_nextval = obj.IDMaPhieu;
                    sql = "update TheoDoiDieuTriHIV_ChiTiet set NgayKham = :NgayKham,NgayKhamLai = :NgayKhamLai,CanNang = :CanNang,ChieuCao = :ChieuCao,DienBienBenh = :DienBienBenh,GDLS = :GDLS,DieuTri = :DieuTri,TenNguoiDieuTri = :TenNguoiDieuTri,GhiChu = :GhiChu";
                    sql = sql + " WHERE IDMaPhieuChiTiet = " + obj.IDMaPhieuChiTiet.ToString() + " and IDMaPhieu = " + obj.IDMaPhieu.ToString() ;
                }
                else
                {
                    sql = @"select NVL(MAX(IDMaPhieuChiTiet),0) AS sequence_nextval from TheoDoiDieuTriHIV_ChiTiet where IDMaPhieu = " + obj.IDMaPhieu.ToString();
                    using (oracleCommand = new MDB.MDBCommand(sql, oracleConnection))
                    {
                        MDB.MDBDataReader oracleDataReader = oracleCommand.ExecuteReader();
                        while (oracleDataReader.Read())
                        {
                            sequence_nextval = decimal.Parse(oracleDataReader["sequence_nextval"].ToString()) + 1;
                        }
                    }
                    sql = @"insert into TheoDoiDieuTriHIV_ChiTiet(IDMaPhieu,IDMaPhieuChiTiet,NgayKham,NgayKhamLai,CanNang,ChieuCao,DienBienBenh,GDLS,DieuTri,TenNguoiDieuTri,GhiChu)";
                    sql = sql + @"Values( :IDMaPhieu, :IDMaPhieuChiTiet, :NgayKham, :NgayKhamLai, :CanNang, :ChieuCao, :DienBienBenh, :GDLS, :DieuTri, :TenNguoiDieuTri, :GhiChu)";
                }
                using (oracleCommand = new MDB.MDBCommand(sql, oracleConnection))
                {
                    if (rowCount <= 0)
                    {
                        oracleCommand.Parameters.Add(new MDB.MDBParameter("IDMaPhieu", obj.IDMaPhieu));
                        oracleCommand.Parameters.Add(new MDB.MDBParameter("IDMaPhieuChiTiet", sequence_nextval));
                    }

                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayKham", obj.NgayKham));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayKhamLai", obj.NgayKhamLai));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CanNang", obj.CanNang));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ChieuCao", obj.ChieuCao));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DienBienBenh", obj.DienBienBenh));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("GDLS", obj.GDLS));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DieuTri", obj.DieuTri));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TenNguoiDieuTri", obj.TenNguoiDieuTri));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("GhiChu", obj.GhiChu));
                    nRecord = oracleCommand.ExecuteNonQuery();
                }
                if (nRecord > 0)
                {
                    obj.IDMaPhieu = sequence_nextval;
                }
                return nRecord > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.LogError(ex);
            }
            return false;
        }
        public static int countPhieu(MDB.MDBConnection oracleConnection, string MaQuanLy)
        {
            int count = 0;
            string sql = @"SELECT COUNT(IDMaPhieu) FROM TheoDoiDieuTriHIV WHERE MAQUANLY = :MaQuanLy";
            MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
            oracleCommand.Parameters.Add("MaQuanLy", MaQuanLy);
            oracleCommand.BindByName = true;
            MDB.MDBDataReader DataReader = oracleCommand.ExecuteReader();
            while (DataReader.Read())
            {
                int temp = 0;
                int.TryParse(DataReader["COUNT(IDMaPhieu)"].ToString(), out temp);
                count = temp;
                break;
            }
            return count;
        }
        public static List<TheoDoiDieuTriHIVTbl> GetData(MDB.MDBConnection MyConnection, decimal IDMaPhieu, decimal MaQuanLy)
        {
            List<TheoDoiDieuTriHIVTbl> lstData = new List<TheoDoiDieuTriHIVTbl>();
            string sql = @"select * from TheoDoiDieuTriHIV WHERE MaQuanLy = :MaQuanLy ";
            if (IDMaPhieu != -1)
            {
                sql += " and IDMaPhieu = " + IDMaPhieu + "";
            }
            sql += " ORDER BY NgayTao, NgaySua asc";
            MDB.MDBCommand Command;
            using (Command = new MDB.MDBCommand(sql, MyConnection))
            {
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    TheoDoiDieuTriHIVTbl phieu = new TheoDoiDieuTriHIVTbl();
                    phieu.IDMaPhieu = decimal.Parse(DataReader["IDMaPhieu"].ToString());
                    phieu.MaQuanLy = decimal.Parse(DataReader["MaQuanLy"].ToString());
                    phieu.BenhVien = ConDBNull(DataReader["BENHVIEN"]);
                    phieu.MaKhoa = ConDBNull(DataReader["MaKhoa"]);
                    phieu.KhoaPhong = ConDBNull(DataReader["KHOAPHONG"]);
                    phieu.HoTen = ConDBNull(DataReader["HoTen"]);
                    phieu.MaBenhNhan = ConDBNull(DataReader["MaBenhNhan"].ToString());
                    phieu.NgayKhangDinh = ConDBNull_DateTime(DataReader["NgayKhangDinh"]);
                    phieu.NoiKhangDinh = ConDBNull(DataReader["NoiKhangDinh"]);
                    phieu.NgayBatDauDieuTriARVLamSan = ConDBNull_DateTime(DataReader["NgayBatDauDieuTriARVLamSan"]);
                    phieu.GiaiDoanLamSanARV = ConDBNull(DataReader["GiaiDoanLamSanARV"]);
                    phieu.CD4 = ConDBNull(DataReader["CD4"]);
                    phieu.NgayBatDauPhatDoARV = ConDBNull_DateTime(DataReader["NgayBatDauPhatDoARV"]);
                    phieu.PhatDoARV = ConDBNull(DataReader["PhatDoARV"]);
                    phieu.NgayChuyenARV = ConDBNull_DateTime(DataReader["NgayChuyenARV"]);
                    phieu.ChuyenTuARV = ConDBNull(DataReader["ChuyenTuARV"]);
                    phieu.NgayBatDauDieuTriARV = ConDBNull_DateTime(DataReader["NgayBatDauDieuTriARV"]);
                    phieu.NgayThayThuoc1PhacDoC1 = ConDBNull_DateTime(DataReader["NgayThayThuoc1PhacDoC1"]);
                    phieu.PhacDoMoi1PhacDoC1 = ConDBNull(DataReader["PhacDoMoi1PhacDoC1"]);
                    phieu.LiDo1PhacDoC1 = ConDBNull(DataReader["LiDo1PhacDoC1"]);
                    phieu.NgayThayThuoc2PhacDoC1 = ConDBNull_DateTime(DataReader["NgayThayThuoc2PhacDoC1"]);
                    phieu.PhacDoMoi2PhacDoC1 = ConDBNull(DataReader["PhacDoMoi2PhacDoC1"]);
                    phieu.LiDo2PhacDoC1 = ConDBNull(DataReader["LiDo2PhacDoC1"]);
                    phieu.NgayThayThuoc3PhacDoC1 = ConDBNull_DateTime(DataReader["NgayThayThuoc3PhacDoC1"]);
                    phieu.PhacDoMoi3PhacDoC1 = ConDBNull(DataReader["PhacDoMoi3PhacDoC1"]);
                    phieu.LiDo3PhacDoC1 = ConDBNull(DataReader["LiDo3PhacDoC1"]);
                    phieu.NgayThayThuoc4PhacDoC1 = ConDBNull_DateTime(DataReader["NgayThayThuoc4PhacDoC1"]);
                    phieu.PhacDoMoi4PhacDoC1 = ConDBNull(DataReader["PhacDoMoi4PhacDoC1"]);
                    phieu.LiDo4PhacDoC1 = ConDBNull(DataReader["LiDo4PhacDoC1"]);
                    phieu.NgayThayThuoc1PhacDoC2 = ConDBNull_DateTime(DataReader["NgayThayThuoc1PhacDoC2"]);
                    phieu.PhacDoMoi1PhacDoC2 = ConDBNull(DataReader["PhacDoMoi1PhacDoC2"]);
                    phieu.LiDo1PhacDoC2 = ConDBNull(DataReader["LiDo1PhacDoC2"]);
                    phieu.NgayThayThuoc2PhacDoC2 = ConDBNull_DateTime(DataReader["NgayThayThuoc2PhacDoC2"]);
                    phieu.PhacDoMoi2PhacDoC2 = ConDBNull(DataReader["PhacDoMoi2PhacDoC2"]);
                    phieu.LiDo2PhacDoC2 = ConDBNull(DataReader["LiDo2PhacDoC2"]);
                    phieu.NgayThayThuoc3PhacDoC2 = ConDBNull_DateTime(DataReader["NgayThayThuoc3PhacDoC2"]);
                    phieu.PhacDoMoi3PhacDoC2 = ConDBNull(DataReader["PhacDoMoi3PhacDoC2"]);
                    phieu.LiDo3PhacDoC2 = ConDBNull(DataReader["LiDo3PhacDoC2"]);
                    phieu.NgayThayThuoc4PhacDoC2 = ConDBNull_DateTime(DataReader["NgayThayThuoc4PhacDoC2"]);
                    phieu.PhacDoMoi4PhacDoC2 = ConDBNull(DataReader["PhacDoMoi4PhacDoC2"]);
                    phieu.LiDo4PhacDoC2 = ConDBNull(DataReader["LiDo4PhacDoC2"]);
                    phieu.NgayTuVong = ConDBNull_DateTime(DataReader["NgayTuVong"]);
                    phieu.TuVong = ConDBNull(DataReader["TuVong"]);
                    phieu.LiDoKetThucTheoDoi = ConDBNull(DataReader["LiDoKetThucTheoDoi"]);
                    phieu.NgayChuyenDi = ConDBNull_DateTime(DataReader["NgayChuyenDi"]);
                    phieu.NoiDi = ConDBNull(DataReader["NoiDi"]);
                    phieu.NgayNgungThuoc1 = ConDBNull_DateTime(DataReader["NgayNgungThuoc1"]);
                    phieu.NgayNgungThuoc2 = ConDBNull_DateTime(DataReader["NgayNgungThuoc2"]);
                    phieu.NgayBoDieuTri = ConDBNull_DateTime(DataReader["NgayBoDieuTri"]);
                    phieu.NgayMatDau = ConDBNull_DateTime(DataReader["NgayMatDau"]);
                    phieu.NgayNgungThuoc3 = ConDBNull_DateTime(DataReader["NgayNgungThuoc3"]);
                    phieu.NgayNgungThuoc4 = ConDBNull_DateTime(DataReader["NgayNgungThuoc4"]);
                    phieu.LiDoNgungThuoc1 = ConDBNull(DataReader["LiDoNgungThuoc1"]);
                    phieu.LiDoNgungThuoc2 = ConDBNull(DataReader["LiDoNgungThuoc2"]);
                    phieu.LiDoNgungThuoc3 = ConDBNull(DataReader["LiDoNgungThuoc3"]);
                    phieu.LiDoNgungThuoc4 = ConDBNull(DataReader["LiDoNgungThuoc4"]);
                    phieu.NgayTaidieuTri1 = ConDBNull_DateTime(DataReader["NgayTaidieuTri1"]);
                    phieu.NgayTaidieuTri2 = ConDBNull_DateTime(DataReader["NgayTaidieuTri2"]);
                    phieu.NgayTaidieuTri3 = ConDBNull_DateTime(DataReader["NgayTaidieuTri3"]);
                    phieu.NgayTaidieuTri4 = ConDBNull_DateTime(DataReader["NgayTaidieuTri4"]);
                    phieu.NgayTao = ConDB_DateTime(DataReader["NgayTao"]);
                    phieu.NgaySua = ConDB_DateTime(DataReader["NgaySua"]);
                    phieu.DaKy = !string.IsNullOrEmpty(ConDBNull(DataReader["masokyten"])) ? true : false;
                    phieu.LstTTChiTiet = GetData_PhieuChiTiet(MyConnection, phieu.IDMaPhieu);
                    phieu.Chon = false;
                    lstData.Add(phieu);
                }
            }
            return lstData;
        }
        public static List<TheoDoiDieuTriHIV_ChiTietTbl> GetData_PhieuChiTiet(MDB.MDBConnection MyConnection, decimal IDMaPhieu)
        {
            List<TheoDoiDieuTriHIV_ChiTietTbl> lstData = new List<TheoDoiDieuTriHIV_ChiTietTbl>();
            string sql = @"select * from theodoidieutrihiv_chitiet WHERE IDMaPhieu = :IDMaPhieu ";
            if (IDMaPhieu != -1)
            {
                sql += " and IDMaPhieu = " + IDMaPhieu + "";
            }
            MDB.MDBCommand Command;
            using (Command = new MDB.MDBCommand(sql, MyConnection))
            {
                Command.Parameters.Add(new MDB.MDBParameter("IDMaPhieu", IDMaPhieu));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    lstData.Add(new TheoDoiDieuTriHIV_ChiTietTbl
                    {
                        IDMaPhieu = decimal.Parse(DataReader["IDMaPhieu"].ToString()),
                        IDMaPhieuChiTiet = decimal.Parse(DataReader["IDMaPhieuChiTiet"].ToString()),
                        NgayKham = ConDBNull_DateTime(DataReader["NgayKham"]),
                        NgayKhamLai = ConDBNull_DateTime(DataReader["NgayKhamLai"]),
                        CanNang = ConDBNull(DataReader["CanNang"]),
                        ChieuCao = ConDBNull(DataReader["ChieuCao"].ToString()),
                        DienBienBenh = ConDBNull(DataReader["DienBienBenh"]),
                        GDLS = ConDBNull(DataReader["GDLS"]),
                        DieuTri = ConDBNull(DataReader["DieuTri"]),
                        TenNguoiDieuTri = ConDBNull(DataReader["TenNguoiDieuTri"]),
                        GhiChu = ConDBNull(DataReader["GhiChu"])
                    });
                }
            }
            return lstData;
        }
        public static string ConDBNull(object dbVal)
        {
            string ret = "";
            if (dbVal == null)
            {
                return ret;
            }
            ret = dbVal.ToString();
            return ret;
        }
        public static decimal ConDB_Decimal(object dbVal, decimal valDefault = 0)
        {
            decimal ret = valDefault;
            if (dbVal == null)
            {
                return ret;
            }
            bool isSuccess = decimal.TryParse(dbVal.ToString(), out ret);
            if (!isSuccess)
            {
                return valDefault;
            }
            return ret;
        }
        public static int ConDB_Int(object dbVal, int valDefault = 0)
        {
            int ret = valDefault;
            if (dbVal == null)
            {
                return ret;
            }
            bool isSuccess = int.TryParse(dbVal.ToString(), out ret);
            if (!isSuccess)
            {
                return valDefault;
            }
            return ret;
        }
        public static DateTime ConDB_DateTime(object dbVal)
        {
            DateTime ret = DateTime.MinValue;
            if (dbVal == null)
            {
                return ret;
            }
            bool isSuccess = DateTime.TryParse(dbVal.ToString(), out ret);
            return ret;
        }
        public static DateTime? ConDBNull_DateTime(object dbVal)
        {
            DateTime ret = DateTime.MinValue;
            if (dbVal == null )
            {
                return null;
            }
            bool isSuccess = DateTime.TryParse(dbVal.ToString(), out ret);
            if (isSuccess == false)
            {
                return null;
            }
            return ret;
        }
    }
}
