
using EMR.KyDienTu;
using System;
using System.Data;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class HuongDanKhaiThacTienSuDiUng: ThongTinKy
    {
        [MoTaDuLieu("Mã định danh")]
		public decimal IDMaPhieuHuongDan { get; set; }
        [MoTaDuLieu("Bệnh viện")]
		public string BenhVien { get; set; }
        public string KhoaPhong { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        public string MaSo { get; set; }
        public string SoVaoVien { get; set; }
        public string HoTen { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        public string SoGiuong { get; set; }
        public string SoBuong { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Năm sinh")]
		public string NamSinh { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public string DUThuoc_Ten { get; set; }
        public string DUThuoc_CoSoLan { get; set; }
        public int? DUThuoc_Khong { get; set; }
        public string DUThuoc_BieuHien { get; set; }
        public string DUConTrung_Ten { get; set; }
        public string DUConTrung_CoSoLan { get; set; }
        public int? DUConTrung_Khong { get; set; }
        public string DUConTrung_BieuHien { get; set; }
        public string DUThucPham_Ten { get; set; }
        public string DUThucPham_CoSoLan { get; set; }
        public int? DUThucPham_Khong { get; set; }
        public string DUThucPham_BieuHien { get; set; }
        public string DUTacNhanKhac_Ten { get; set; }
        public string DUTacNhanKhac_CoSoLan { get; set; }
        public int? DUTacNhanKhac_Khong { get; set; }
        public string DUTacNhanKhac_BieuHien { get; set; }
        public string DUCaNhanKhac_Ten { get; set; }
        public string DUCaNhanKhac_CoSoLan { get; set; }
        public int? DUCaNhanKhac_Khong { get; set; }
        public string DUCaNhanKhac_BieuHien { get; set; }
        public string DUDiTruyen_Ten { get; set; }
        public string DUDiTruyen_CoSoLan { get; set; }
        public int? DUDiTruyen_Khong { get; set; }
        public string DUDiTruyen_BieuHien { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Bác sỹ điều trị")]
		public string BacSiDieuTri { get; set; }
        public string MaBacSiDieuTri { get; set; }
        [MoTaDuLieu("Ngày ký")]
		public DateTime NgayKi { get; set; }
        //public string MaSoKyTen { get; set; }
        public HuongDanKhaiThacTienSuDiUng()
        {
            TableName = "HuongDanKhaiThacTienSuDiUng";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.HDKTTSDU;
            TenMauPhieu = DanhMucPhieu.HDKTTSDU.Description();
            IDMaPhieuHuongDan = 0;
            BenhVien = "";
            KhoaPhong = "";
            HoTen = "";
            Tuoi = "";
            GioiTinh = "";
            MaSo = "";
            SoVaoVien = "";
            SoGiuong = "";
            SoBuong = "";
            MaBenhNhan = "";
            NamSinh = "";
            DiaChi = "";
            ChanDoan = "";
            DUThuoc_Ten = "";
            DUThuoc_CoSoLan = "";
            DUThuoc_Khong = 0;
            DUThuoc_BieuHien = "";
            DUConTrung_Ten = "";
            DUConTrung_CoSoLan = "";
            DUConTrung_Khong = 0;
            DUConTrung_BieuHien = "";
            DUThucPham_Ten = "";
            DUThucPham_CoSoLan = "";
            DUThucPham_Khong = 0;
            DUThucPham_BieuHien = "";
            DUCaNhanKhac_Ten = "";
            DUCaNhanKhac_CoSoLan = "";
            DUCaNhanKhac_Khong = 0;
            DUCaNhanKhac_BieuHien = "";
            DUDiTruyen_Ten = "";
            DUDiTruyen_CoSoLan = "";
            DUDiTruyen_Khong = 0;
            DUDiTruyen_BieuHien = "";
            BacSiDieuTri = "";
            MaBacSiDieuTri = "";
            TenFileKy = "";
            UserNameKy = "";
            NgayKi = DateTime.Now;
            ComputerKyTen = "";
            MaSoKy = "";
            NgayTao = DateTime.Now;
            MaQuanLy = 0;
        }
        public static bool DeleteByID(MDB.MDBConnection oracleConnection, decimal IDChon)
        {
            try
            {
                string sql = "";
                if (IDChon == 0)
                {
                    return false;
                }
                MDB.MDBCommand oracleCommand;
                sql = @"DELETE FROM HuongDanKhaiThacTienSuDiUng WHERE IDMaPhieuHuongDan =" + IDChon;
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
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, string IDCHon)
        {
            string sql = @"select AA.*"
                         + " from HuongDanKhaiThacTienSuDiUng AA WHERE IDMaPhieuHuongDan =: IDMaPhieuHuongDan ORDER BY NgayTao, NgaySua asc";
            MDB.MDBCommand Command;
            MDB.MDBDataAdapter adt;
            using (Command = new MDB.MDBCommand(sql, MyConnection))
            {
                Command.Parameters.Add(new MDB.MDBParameter("IDMaPhieuHuongDan", IDCHon));
                adt = new MDB.MDBDataAdapter(Command);
            }
            var ds = new DataSet();
            adt.Fill(ds, "TBL");
            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection oracleConnection, HuongDanKhaiThacTienSuDiUng obj, ref bool isUpdate)
        {
            try
            {
                string sql = @"SELECT COUNT(*) RECNUM FROM HuongDanKhaiThacTienSuDiUng WHERE IDMaPhieuHuongDan = :IDMaPhieuHuongDan";
                MDB.MDBCommand oracleCommand;
                int rowCount = 0;
                int nRecord = 0;
                decimal sequence_nextval = 0;
                using (oracleCommand = new MDB.MDBCommand(sql, oracleConnection))
                {
                    oracleCommand.Parameters.Add("IDMaPhieuHuongDan", obj.IDMaPhieuHuongDan);
                    MDB.MDBDataReader oracleDataReader = oracleCommand.ExecuteReader();
                    while (oracleDataReader.Read())
                    {
                        rowCount = int.Parse(oracleDataReader["RECNUM"].ToString());
                    }
                }


                if (rowCount > 0)
                {
                    isUpdate = true;
                    sequence_nextval = obj.IDMaPhieuHuongDan;
                    sql = "update HuongDanKhaiThacTienSuDiUng set ";
                    sql = sql + "BenhVien = :BenhVien,KhoaPhong = :KhoaPhong,MaQuanLy = :MaQuanLy,MaSo = :MaSo,SoVaoVien = :SoVaoVien,HoTen = :HoTen,Tuoi = :Tuoi,GioiTinh = :GioiTinh,SoGiuong = :SoGiuong,SoBuong = :SoBuong,MaBenhNhan = :MaBenhNhan, NamSinh = :NamSinh, DiaChi = :DiaChi,ChanDoan = :ChanDoan,DUThuoc_Ten = :DUThuoc_Ten,DUThuoc_CoSoLan = :DUThuoc_CoSoLan,DUThuoc_Khong = :DUThuoc_Khong,DUThuoc_BieuHien = :DUThuoc_BieuHien,DUConTrung_Ten = :DUConTrung_Ten,DUConTrung_CoSoLan = :DUConTrung_CoSoLan,DUConTrung_Khong = :DUConTrung_Khong,DUConTrung_BieuHien = :DUConTrung_BieuHien,DUThucPham_Ten = :DUThucPham_Ten,DUThucPham_CoSoLan = :DUThucPham_CoSoLan,DUThucPham_Khong = :DUThucPham_Khong,DUThucPham_BieuHien = :DUThucPham_BieuHien,DUTacNhanKhac_Ten  = :DUTacNhanKhac_Ten, DUTacNhanKhac_CoSoLan  = :DUTacNhanKhac_CoSoLan,DUTacNhanKhac_Khong  = :DUTacNhanKhac_Khong, DUTacNhanKhac_BieuHien  = :DUTacNhanKhac_BieuHien,DUCaNhanKhac_Ten = :DUCaNhanKhac_Ten,DUCaNhanKhac_CoSoLan = :DUCaNhanKhac_CoSoLan,DUCaNhanKhac_Khong = :DUCaNhanKhac_Khong,DUCaNhanKhac_BieuHien = :DUCaNhanKhac_BieuHien,DUDiTruyen_Ten = :DUDiTruyen_Ten,DUDiTruyen_CoSoLan = :DUDiTruyen_CoSoLan,DUDiTruyen_Khong = :DUDiTruyen_Khong,DUDiTruyen_BieuHien = :DUDiTruyen_BieuHien,NgayTao = :NgayTao,NgaySua = :NgaySua,BacSiDieuTri = :BacSiDieuTri,MaBacSiDieuTri = :MaBacSiDieuTri,TenFileKy = :TenFileKy,UserNameKy = :UserNameKy,NgayKi = :NgayKi,ComputerKyTen = :ComputerKyTen,MaSoKyTen = :MaSoKyTen";
                    sql = sql + " WHERE IDMaPhieuHuongDan = " + obj.IDMaPhieuHuongDan.ToString();
                }
                else
                {
                    sql = @"select NVL(MAX(IDMaPhieuHuongDan),0) AS sequence_nextval from HuongDanKhaiThacTienSuDiUng";
                    using (oracleCommand = new MDB.MDBCommand(sql, oracleConnection))
                    {
                        MDB.MDBDataReader oracleDataReader = oracleCommand.ExecuteReader();
                        while (oracleDataReader.Read())
                        {
                            sequence_nextval = decimal.Parse(oracleDataReader["sequence_nextval"].ToString()) + 1;
                        }
                    }
                    sql = @"insert into HuongDanKhaiThacTienSuDiUng(" +
                          "IDMaPhieuHuongDan,BenhVien,KhoaPhong,MaQuanLy,MaSo,SoVaoVien,HoTen,Tuoi,GioiTinh,SoGiuong,SoBuong,MaBenhNhan, NamSinh, DiaChi,ChanDoan,DUThuoc_Ten,DUThuoc_CoSoLan,DUThuoc_Khong,DUThuoc_BieuHien,DUConTrung_Ten,DUConTrung_CoSoLan,DUConTrung_Khong,DUConTrung_BieuHien,DUThucPham_Ten,DUThucPham_CoSoLan,DUThucPham_Khong,DUThucPham_BieuHien,DUTacNhanKhac_Ten , DUTacNhanKhac_CoSoLan ,DUTacNhanKhac_Khong, DUTacNhanKhac_BieuHien, DUCaNhanKhac_Ten,DUCaNhanKhac_CoSoLan,DUCaNhanKhac_Khong,DUCaNhanKhac_BieuHien,DUDiTruyen_Ten,DUDiTruyen_CoSoLan,DUDiTruyen_Khong,DUDiTruyen_BieuHien,NgayTao,NgaySua,BacSiDieuTri,MaBacSiDieuTri,TenFileKy,UserNameKy,NgayKi,ComputerKyTen,MaSoKyTen"
                          + ")";
                    sql = sql + @"Values(" +
                        " :IDMaPhieuHuongDan, :BenhVien, :KhoaPhong, :MaQuanLy, :MaSo, :SoVaoVien, :HoTen, :Tuoi, :GioiTinh, :SoGiuong, :SoBuong,:MaBenhNhan, :NamSinh, :DiaChi, :ChanDoan, :DUThuoc_Ten, :DUThuoc_CoSoLan, :DUThuoc_Khong, :DUThuoc_BieuHien, :DUConTrung_Ten, :DUConTrung_CoSoLan, :DUConTrung_Khong, :DUConTrung_BieuHien, :DUThucPham_Ten, :DUThucPham_CoSoLan, :DUThucPham_Khong, :DUThucPham_BieuHien,:DUTacNhanKhac_Ten , :DUTacNhanKhac_CoSoLan , :DUTacNhanKhac_Khong, :DUTacNhanKhac_BieuHien, :DUCaNhanKhac_Ten, :DUCaNhanKhac_CoSoLan, :DUCaNhanKhac_Khong, :DUCaNhanKhac_BieuHien, :DUDiTruyen_Ten, :DUDiTruyen_CoSoLan, :DUDiTruyen_Khong, :DUDiTruyen_BieuHien, :NgayTao, :NgaySua, :BacSiDieuTri, :MaBacSiDieuTri, :TenFileKy, :UserNameKy, :NgayKi, :ComputerKyTen, :MaSoKyTen"
                        + ")";
                }
                using (oracleCommand = new MDB.MDBCommand(sql, oracleConnection))
                {
                    if (rowCount <= 0)
                    {
                        oracleCommand.Parameters.Add(new MDB.MDBParameter("IDMaPhieuHuongDan", sequence_nextval));
                    }
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("BenhVien", obj.BenhVien));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("KhoaPhong", obj.KhoaPhong));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaQuanLy", obj.MaQuanLy));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaSo", obj.MaSo));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SoVaoVien", obj.SoVaoVien));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("HoTen", obj.HoTen));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Tuoi", obj.Tuoi));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("GioiTinh", obj.GioiTinh));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SoGiuong", obj.SoGiuong));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SoBuong", obj.SoBuong));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", obj.MaBenhNhan));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NamSinh", obj.NamSinh));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DiaChi", obj.DiaChi));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ChanDoan", obj.ChanDoan));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DUThuoc_Ten", obj.DUThuoc_Ten));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DUThuoc_CoSoLan", obj.DUThuoc_CoSoLan));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DUThuoc_Khong", obj.DUThuoc_Khong));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DUThuoc_BieuHien", obj.DUThuoc_BieuHien));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DUConTrung_Ten", obj.DUConTrung_Ten));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DUConTrung_CoSoLan", obj.DUConTrung_CoSoLan));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DUConTrung_Khong", obj.DUConTrung_Khong));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DUConTrung_BieuHien", obj.DUConTrung_BieuHien));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DUThucPham_Ten", obj.DUThucPham_Ten));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DUThucPham_CoSoLan", obj.DUThucPham_CoSoLan));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DUThucPham_Khong", obj.DUThucPham_Khong));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DUThucPham_BieuHien", obj.DUThucPham_BieuHien));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DUTacNhanKhac_Ten", obj.DUTacNhanKhac_Ten));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DUTacNhanKhac_CoSoLan", obj.DUTacNhanKhac_CoSoLan));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DUTacNhanKhac_Khong", obj.DUTacNhanKhac_Khong));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DUTacNhanKhac_BieuHien", obj.DUTacNhanKhac_BieuHien));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DUCaNhanKhac_Ten", obj.DUCaNhanKhac_Ten));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DUCaNhanKhac_CoSoLan", obj.DUCaNhanKhac_CoSoLan));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DUCaNhanKhac_Khong", obj.DUCaNhanKhac_Khong));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DUCaNhanKhac_BieuHien", obj.DUCaNhanKhac_BieuHien));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DUDiTruyen_Ten", obj.DUDiTruyen_Ten));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DUDiTruyen_CoSoLan", obj.DUDiTruyen_CoSoLan));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DUDiTruyen_Khong", obj.DUDiTruyen_Khong));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DUDiTruyen_BieuHien", obj.DUDiTruyen_BieuHien));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayTao", obj.NgayTao));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgaySua", obj.NgaySua));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("BacSiDieuTri", obj.BacSiDieuTri));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBacSiDieuTri", obj.MaBacSiDieuTri));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TenFileKy", obj.TenFileKy));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("UserNameKy", obj.UserNameKy));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayKi", obj.NgayKi));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ComputerKyTen", obj.ComputerKyTen));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaSoKyTen", obj.MaSoKy));
                    nRecord = oracleCommand.ExecuteNonQuery();
                }
                if (nRecord > 0)
                {
                    obj.IDMaPhieuHuongDan = sequence_nextval;
                }
                return nRecord > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.LogError(ex);
            }
            return false;
        }
        //public static int countPhieu(MDB.MDBConnection oracleConnection, string MaQuanLy)
        //{
        //    int count = 0;
        //    string sql = @"SELECT COUNT(IDMaPhieuHuongDan) FROM HuongDanKhaiThacTienSuDiUng WHERE MAQUANLY = :MaQuanLy";
        //    MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
        //    oracleCommand.Parameters.Add("MaQuanLy", MaQuanLy);
        //    oracleCommand.BindByName = true;
        //    MDB.MDBDataReader DataReader = oracleCommand.ExecuteReader();
        //    while (DataReader.Read())
        //    {
        //        int temp = 0;
        //        int.TryParse(DataReader["COUNT(IDMaPhieuHuongDan)"].ToString(), out temp);
        //        count = temp;
        //        break;
        //    }
        //    return count;
        //}
        public static HuongDanKhaiThacTienSuDiUng GetData(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            HuongDanKhaiThacTienSuDiUng lstData = new HuongDanKhaiThacTienSuDiUng();
            string sql = @"select * from HuongDanKhaiThacTienSuDiUng WHERE MaQuanLy = :MaQuanLy ";
            MDB.MDBCommand Command;
            using (Command = new MDB.MDBCommand(sql, MyConnection))
            {
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    lstData.IDMaPhieuHuongDan = decimal.Parse(DataReader["IDMaPhieuHuongDan"].ToString());
                    lstData.BenhVien = ConDBNull(DataReader["BenhVien"]);
                    lstData.KhoaPhong = ConDBNull(DataReader["KhoaPhong"]);
                    lstData.MaQuanLy = ConDB_Decimal(DataReader["MaQuanLy"]);
                    lstData.MaSo = ConDBNull(DataReader["MaSo"]);
                    lstData.SoVaoVien = ConDBNull(DataReader["SoVaoVien"]);
                    lstData.HoTen = ConDBNull(DataReader["HoTen"]);
                    lstData.Tuoi = ConDBNull(DataReader["Tuoi"]);
                    lstData.GioiTinh = ConDBNull(DataReader["GioiTinh"]);
                    lstData.SoGiuong = ConDBNull(DataReader["SoGiuong"]);
                    lstData.SoBuong = ConDBNull(DataReader["SoBuong"]);
                    lstData.MaBenhNhan = ConDBNull(DataReader["MaBenhNhan"]);
                    lstData.NamSinh = ConDBNull(DataReader["NamSinh"]);
                    lstData.DiaChi = ConDBNull(DataReader["DiaChi"]);
                    lstData.ChanDoan = ConDBNull(DataReader["ChanDoan"]);
                    lstData.DUThuoc_Ten = ConDBNull(DataReader["DUThuoc_Ten"]);
                    lstData.DUThuoc_CoSoLan = ConDBNull(DataReader["DUThuoc_CoSoLan"]);
                    lstData.DUThuoc_Khong = ConDB_Int(DataReader["DUThuoc_Khong"]);
                    lstData.DUThuoc_BieuHien = ConDBNull(DataReader["DUThuoc_BieuHien"]);
                    lstData.DUConTrung_Ten = ConDBNull(DataReader["DUConTrung_Ten"]);
                    lstData.DUConTrung_CoSoLan = ConDBNull(DataReader["DUConTrung_CoSoLan"]);
                    lstData.DUConTrung_Khong = ConDB_Int(DataReader["DUConTrung_Khong"]);
                    lstData.DUConTrung_BieuHien = ConDBNull(DataReader["DUConTrung_BieuHien"]);
                    lstData.DUThucPham_Ten = ConDBNull(DataReader["DUThucPham_Ten"]);
                    lstData.DUThucPham_CoSoLan = ConDBNull(DataReader["DUThucPham_CoSoLan"]);
                    lstData.DUThucPham_Khong = ConDB_Int(DataReader["DUThucPham_Khong"]);
                    lstData.DUThucPham_BieuHien = ConDBNull(DataReader["DUThucPham_BieuHien"]);
                    lstData.DUTacNhanKhac_Ten = ConDBNull(DataReader["DUTacNhanKhac_Ten"]);
                    lstData.DUTacNhanKhac_CoSoLan = ConDBNull(DataReader["DUTacNhanKhac_CoSoLan"]);
                    lstData.DUTacNhanKhac_Khong = ConDB_Int(DataReader["DUTacNhanKhac_Khong"]);
                    lstData.DUTacNhanKhac_BieuHien = ConDBNull(DataReader["DUTacNhanKhac_BieuHien"]);
                    lstData.DUCaNhanKhac_Ten = ConDBNull(DataReader["DUCaNhanKhac_Ten"]);
                    lstData.DUCaNhanKhac_CoSoLan = ConDBNull(DataReader["DUCaNhanKhac_CoSoLan"]);
                    lstData.DUCaNhanKhac_Khong = ConDB_Int(DataReader["DUCaNhanKhac_Khong"]);
                    lstData.DUCaNhanKhac_BieuHien = ConDBNull(DataReader["DUCaNhanKhac_BieuHien"]);
                    lstData.DUDiTruyen_Ten = ConDBNull(DataReader["DUDiTruyen_Ten"]);
                    lstData.DUDiTruyen_CoSoLan = ConDBNull(DataReader["DUDiTruyen_CoSoLan"]);
                    lstData.DUDiTruyen_Khong = ConDB_Int(DataReader["DUDiTruyen_Khong"]);
                    lstData.DUDiTruyen_BieuHien = ConDBNull(DataReader["DUDiTruyen_BieuHien"]);
                    lstData.NgayTao = ConDB_DateTime(DataReader["NgayTao"]);
                    lstData.NgaySua = ConDB_DateTime(DataReader["NgaySua"]);
                    lstData.BacSiDieuTri = ConDBNull(DataReader["BacSiDieuTri"]);
                    lstData.MaBacSiDieuTri = ConDBNull(DataReader["MaBacSiDieuTri"]);
                    lstData.TenFileKy = ConDBNull(DataReader["TenFileKy"]);
                    lstData.UserNameKy = ConDBNull(DataReader["UserNameKy"]);
                    lstData.NgayKi = ConDB_DateTime(DataReader["NgayKi"]);
                    lstData.ComputerKyTen = ConDBNull(DataReader["ComputerKyTen"]);
                    lstData.MaSoKy = ConDBNull(DataReader["MaSoKyTen"]);
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
    }
    public class HuongDanKhaiThacTienSuDiUngFunc
    {
        public const string TableName = "HuongDanKhaiThacTienSuDiUng";
        public const string TablePrimaryKeyName = "IDMaPhieuHuongDan";
    }
}
