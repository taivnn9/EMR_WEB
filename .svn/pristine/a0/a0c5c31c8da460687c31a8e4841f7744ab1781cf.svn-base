
using EMR.KyDienTu;
using MDB;
using System;
using System.Collections.Generic;
using System.Data;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class DanhGiaDinhDuong : ThongTinKy
    {
        public DanhGiaDinhDuong()
        {
            TableName = "DanhGiaDinhDuong";
            TablePrimaryKeyName = "IDPHIEUDINHDUONG";
            IDMauPhieu = (int)DanhMucPhieu.DD;
            TenMauPhieu = DanhMucPhieu.DD.Description();
        }

        [MoTaDuLieu("Mã định danh")]
		public decimal IDPhieuDinhDuong { get; set; } = -1;
        public DateTime NgayDanhGia { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public double CanNang { get; set; }
        public double ChieuCao { get; set; }
        public double BMI_So { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        public bool CoGiamCan { get; set; }
        public bool GiamCan { get { return !CoGiamCan; } set { CoGiamCan = !value; } }
        public bool CoAnGiam { get; set; }
        public bool AnGiam { get { return !CoAnGiam; } set { CoAnGiam = !value; } }
        public NhanVien NguoiDanhGia1 { get; set; }
        public NhanVien NguoiDanhGia2 { get; set; }

        public bool[] AnMiengArray { get; } = new bool[] { false, false, false };
        public int AnMieng { get { return Array.IndexOf(AnMiengArray, true); } set { for (int i = 0; i < 3; i++) { if (i == value) AnMiengArray[i] = true; else { AnMiengArray[i] = false; } } } }


        public bool[] BMIArray { get; } = new bool[] { true, false, false };
        public int BMI { get { return Array.IndexOf(BMIArray, true); } set { for (int i = 0; i < 3; i++) { if (i == value) BMIArray[i] = true; else { BMIArray[i] = false; } } } }



        public bool[] GiamCan3ThangArray { get; } = new bool[] { true, false, false };

        public int GiamCan3Thang { get { return Array.IndexOf(GiamCan3ThangArray, true); } set { for (int i = 0; i < 3; i++) { if (i == value) GiamCan3ThangArray[i] = true; else { GiamCan3ThangArray[i] = false; } } } }

        public bool KhongPhu_KhongNguyCo { get; set; }
        public bool KhongPhu_NguyCoNhe { get; set; }
        public bool KhongPhu_NguyCoNang { get; set; }
        public bool CoPhu_KhongNguyCo { get; set; }
        public bool CoPhu_NguyCoNhe { get; set; }
        public bool CoPhu_NguyCoNang { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }

        public int TongDiem
        {
            get
            {
                return AnMieng + BMI + GiamCan3Thang;
            }
        }


    }

    public class DanhGiaDinhDuongFunc
    {
        public static string TableName = "DanhGiaDinhDuong";
        public static string TablePrimaryKeyName = "IDPHIEUDINHDUONG";
        public static string MaPhieu = "DD";
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref DanhGiaDinhDuong danhGiaDinhDuong)
        {
            //phieuBieuDoChuyenDa.DaVoOi ? 1 : 0)
            string sql;
            int n;
            if (danhGiaDinhDuong.IDPhieuDinhDuong == -1)
            {
                sql = @"INSERT INTO DanhGiaDinhDuong (
		        NgayDanhGia,
		        MaQuanLy,
		        CanNang,
		        ChieuCao,
		        BMI_So,
		        ChanDoan,
                CoGiamCan,
		        CoAnGiam,
                NguoiDanhGia1,
                NguoiDanhGia2,
                AnMieng,
                BMI,
                GiamCan3Thang,
                KhongPhu_KhongNguyCo ,
                KhongPhu_NguyCoNhe ,
                KhongPhu_NguyCoNang ,
                CoPhu_KhongNguyCo ,
                CoPhu_NguyCoNhe ,
                CoPhu_NguyCoNang,
                NguoiTao,
                NguoiSua,
                NgayTao,
                NgaySua

                )
                VALUES
	             (
		        :NgayDanhGia, :MaQuanLy, :CanNang,:ChieuCao,:BMI_So, :ChanDoan, :CoGiamCan, :CoAnGiam,
		        :NguoiDanhGia1, :NguoiDanhGia2, :AnMieng, :BMI,
		        :GiamCan3Thang, :KhongPhu_KhongNguyCo, :KhongPhu_NguyCoNhe, :KhongPhu_NguyCoNang,
		        :CoPhu_KhongNguyCo, :CoPhu_NguyCoNhe, :CoPhu_NguyCoNang,
                :NguoiTao,
                :NguoiSua,
                :NgayTao,
                :NgaySua
                ) RETURNING IDPhieuDinhDuong INTO :IDPhieuDinhDuong";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("NgayDanhGia", danhGiaDinhDuong.NgayDanhGia));
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", danhGiaDinhDuong.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang", danhGiaDinhDuong.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("ChieuCao", danhGiaDinhDuong.ChieuCao));
                Command.Parameters.Add(new MDB.MDBParameter("BMI_So", danhGiaDinhDuong.BMI_So));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", danhGiaDinhDuong.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("CoGiamCan", danhGiaDinhDuong.CoGiamCan ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("CoAnGiam", danhGiaDinhDuong.CoAnGiam ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiDanhGia1", danhGiaDinhDuong.NguoiDanhGia1 != null ? danhGiaDinhDuong.NguoiDanhGia1.IdNhanVien : decimal.Zero));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiDanhGia2", danhGiaDinhDuong.NguoiDanhGia2 != null ? danhGiaDinhDuong.NguoiDanhGia2.IdNhanVien : decimal.Zero));
                Command.Parameters.Add(new MDB.MDBParameter("AnMieng", danhGiaDinhDuong.AnMieng));
                Command.Parameters.Add(new MDB.MDBParameter("BMI", danhGiaDinhDuong.BMI));
                Command.Parameters.Add(new MDB.MDBParameter("GiamCan3Thang", danhGiaDinhDuong.GiamCan3Thang));
                Command.Parameters.Add(new MDB.MDBParameter("KhongPhu_KhongNguyCo", danhGiaDinhDuong.KhongPhu_KhongNguyCo ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("KhongPhu_NguyCoNhe", danhGiaDinhDuong.KhongPhu_NguyCoNhe ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("KhongPhu_NguyCoNang", danhGiaDinhDuong.KhongPhu_NguyCoNang ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("CoPhu_KhongNguyCo", danhGiaDinhDuong.CoPhu_KhongNguyCo ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("CoPhu_NguyCoNhe", danhGiaDinhDuong.CoPhu_NguyCoNhe ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("CoPhu_NguyCoNang", danhGiaDinhDuong.CoPhu_NguyCoNang ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("CoPhu_NguyCoNang", danhGiaDinhDuong.CoPhu_NguyCoNang ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiTao", danhGiaDinhDuong.NguoiTao));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiSua", danhGiaDinhDuong.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NgayTao", danhGiaDinhDuong.NgayTao));
                Command.Parameters.Add(new MDB.MDBParameter("NgaySua", danhGiaDinhDuong.NgaySua));
                Command.Parameters.Add(new MDB.MDBParameter("IDPhieuDinhDuong", danhGiaDinhDuong.IDPhieuDinhDuong));
                Command.BindByName = true;
                n = Command.ExecuteNonQuery();

                if (n > 0)
                {
                    if (danhGiaDinhDuong.IDPhieuDinhDuong == -1)
                    {
                        decimal nextval = Convert.ToInt64((Command.Parameters["IDPhieuDinhDuong"] as MDB.MDBParameter).Value);
                        danhGiaDinhDuong.IDPhieuDinhDuong = nextval;
                    }
                }
            }

            else
            {
                sql = @"UPDATE DanhGiaDinhDuong SET NgayDanhGia = :NgayDanhGia, MaQuanLy = :MaQuanLy, ChieuCao = :ChieuCao, CanNang = :CanNang, BMI_So = :BMI_So, ChanDoan = :ChanDoan, 
                CoGiamCan = :CoGiamCan, CoAnGiam = :CoAnGiam,
		        NguoiDanhGia1 = :NguoiDanhGia1,NguoiDanhGia2 = :NguoiDanhGia2,AnMieng = :AnMieng,BMI = :BMI,
		        GiamCan3Thang = :GiamCan3Thang,KhongPhu_KhongNguyCo = :KhongPhu_KhongNguyCo,KhongPhu_NguyCoNhe = :KhongPhu_NguyCoNhe, KhongPhu_NguyCoNang = :KhongPhu_NguyCoNang,
		        CoPhu_KhongNguyCo = :CoPhu_KhongNguyCo,CoPhu_NguyCoNhe = :CoPhu_NguyCoNhe,CoPhu_NguyCoNang = :CoPhu_NguyCoNang,
                NguoiTao = :NguoiTao, NguoiSua = :NguoiSua, NgayTao = :NgayTao, NgaySua = :NgaySua
                WHERE IDPhieuDinhDuong = :IDPhieuDinhDuong";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("NgayDanhGia", danhGiaDinhDuong.NgayDanhGia));
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", danhGiaDinhDuong.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("ChieuCao", danhGiaDinhDuong.ChieuCao));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang", danhGiaDinhDuong.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("BMI_So", danhGiaDinhDuong.BMI_So));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", danhGiaDinhDuong.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("CoGiamCan", danhGiaDinhDuong.CoGiamCan ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("CoAnGiam", danhGiaDinhDuong.CoAnGiam ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiDanhGia1", danhGiaDinhDuong.NguoiDanhGia1 != null ? danhGiaDinhDuong.NguoiDanhGia1.IdNhanVien : decimal.Zero));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiDanhGia2", danhGiaDinhDuong.NguoiDanhGia2 != null ? danhGiaDinhDuong.NguoiDanhGia2.IdNhanVien : decimal.Zero));
                Command.Parameters.Add(new MDB.MDBParameter("AnMieng", danhGiaDinhDuong.AnMieng));
                Command.Parameters.Add(new MDB.MDBParameter("BMI", danhGiaDinhDuong.BMI));
                Command.Parameters.Add(new MDB.MDBParameter("GiamCan3Thang", danhGiaDinhDuong.GiamCan3Thang));
                Command.Parameters.Add(new MDB.MDBParameter("KhongPhu_KhongNguyCo", danhGiaDinhDuong.KhongPhu_KhongNguyCo ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("KhongPhu_NguyCoNhe", danhGiaDinhDuong.KhongPhu_NguyCoNhe ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("KhongPhu_NguyCoNang", danhGiaDinhDuong.KhongPhu_NguyCoNang ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("CoPhu_KhongNguyCo", danhGiaDinhDuong.CoPhu_KhongNguyCo ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("CoPhu_NguyCoNhe", danhGiaDinhDuong.CoPhu_NguyCoNhe ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("CoPhu_NguyCoNang", danhGiaDinhDuong.CoPhu_NguyCoNang ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiTao", danhGiaDinhDuong.NguoiTao));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiSua", danhGiaDinhDuong.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NgayTao", danhGiaDinhDuong.NgayTao));
                Command.Parameters.Add(new MDB.MDBParameter("NgaySua", danhGiaDinhDuong.NgaySua));
                Command.Parameters.Add(new MDB.MDBParameter("IDPhieuDinhDuong", danhGiaDinhDuong.IDPhieuDinhDuong));
                Command.BindByName = true;
                n = Command.ExecuteNonQuery();

            }
            return n > 0;
        }

        public static bool Delete(MDBConnection MyConnection, decimal iDPhieuDinhDuong)
        {
            string sql = "DELETE FROM DanhGiaDinhDuong WHERE IDPhieuDinhDuong = :IDPhieuDinhDuong";
            MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
            command.Parameters.Add(new MDB.MDBParameter("IDPhieuDinhDuong", iDPhieuDinhDuong));
            command.BindByName = true;
            int n = command.ExecuteNonQuery();
            return n > 0;
        }

        public static List<DanhGiaDinhDuong> GetListDanhGia(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<DanhGiaDinhDuong> list = new List<DanhGiaDinhDuong>();
            try
            {

                string sql = @"SELECT * FROM DanhGiaDinhDuong where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    try
                    {
                        DanhGiaDinhDuong data = new DanhGiaDinhDuong();
                        data.IDPhieuDinhDuong = Convert.ToInt64(DataReader.GetLong("IDPhieuDinhDuong").ToString());
                        data.NgayDanhGia = Convert.ToDateTime(DataReader["NgayDanhGia"] == DBNull.Value ? DateTime.Now : DataReader["NgayDanhGia"]);

                        data.NguoiDanhGia1 = getNhanVienFromID(decimal.Parse(DataReader["NguoiDanhGia1"].ToString()));
                        data.NguoiDanhGia2 = getNhanVienFromID(decimal.Parse(DataReader["NguoiDanhGia2"].ToString()));
                        data.MaSoKy = DataReader.GetString("masokyten");
                        data.NgayKy = DataReader.GetDate("ngayky");
                        data.NguoiTao = DataReader.GetString("NguoiTao");
                        data.NguoiSua = DataReader.GetString("NguoiSua");
                        data.NgayTao = DataReader.GetDate("NgayTao");
                        data.NgaySua = DataReader.GetDate("NgaySua");
                        data.TenFileKy = DataReader.GetString("tenfileky");
                        data.UserNameKy = DataReader.GetString("usernameky");
                        list.Add(data);
                    }
                    catch (Exception ex)
                    {
                        MDB.ExceptionExtend.LogError(ex);
                    }
                }
                DataReader.Close();
                DataReader = null;
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }

        public static DanhGiaDinhDuong GetData(MDB.MDBConnection _OracleConnection, decimal id)
        {
            try
            {
                string sql = @"SELECT * FROM DanhGiaDinhDuong where IDPhieuDinhDuong = :IDPhieuDinhDuong";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("IDPhieuDinhDuong", id));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    try
                    {
                        DanhGiaDinhDuong data = new DanhGiaDinhDuong();
                        data.IDPhieuDinhDuong = Convert.ToInt64(DataReader.GetLong("IDPhieuDinhDuong").ToString());
                        data.NgayDanhGia = Convert.ToDateTime(DataReader["NgayDanhGia"] == DBNull.Value ? DateTime.Now : DataReader["NgayDanhGia"]);
                        data.MaQuanLy = decimal.Parse(DataReader["MaQuanLy"].ToString());
                        data.ChieuCao = double.Parse(DataReader["ChieuCao"].ToString());
                        data.CanNang = double.Parse(DataReader["CanNang"].ToString());
                        data.BMI_So = double.Parse(DataReader["BMI_So"].ToString());
                        data.ChanDoan = DataReader["ChanDoan"].ToString();
                        data.CoGiamCan = DataReader["CoGiamCan"].ToString().Trim().Equals("1") ? true : false;
                        data.CoAnGiam = DataReader["CoGiamCan"].ToString().Trim().Equals("1") ? true : false;
                        data.NguoiDanhGia1 = getNhanVienFromID(decimal.Parse(DataReader["NguoiDanhGia1"].ToString()));
                        data.NguoiDanhGia2 = getNhanVienFromID(decimal.Parse(DataReader["NguoiDanhGia2"].ToString()));
                        data.AnMieng = int.Parse(DataReader["AnMieng"].ToString());
                        data.BMI = int.Parse(DataReader["BMI"].ToString());
                        data.GiamCan3Thang = int.Parse(DataReader["GiamCan3Thang"].ToString());
                        data.KhongPhu_KhongNguyCo = DataReader["KhongPhu_KhongNguyCo"].ToString().Trim().Equals("1") ? true : false;
                        data.KhongPhu_NguyCoNhe = DataReader["KhongPhu_NguyCoNhe"].ToString().Trim().Equals("1") ? true : false;
                        data.KhongPhu_NguyCoNang = DataReader["KhongPhu_NguyCoNang"].ToString().Trim().Equals("1") ? true : false;
                        data.CoPhu_KhongNguyCo = DataReader["CoPhu_KhongNguyCo"].ToString().Trim().Equals("1") ? true : false;
                        data.CoPhu_NguyCoNhe = DataReader["CoPhu_NguyCoNhe"].ToString().Trim().Equals("1") ? true : false;
                        data.CoPhu_NguyCoNang = DataReader["CoPhu_NguyCoNang"].ToString().Trim().Equals("1") ? true : false;
                        data.NguoiTao = DataReader.GetString("NguoiTao");
                        data.NguoiSua = DataReader.GetString("NguoiSua");
                        data.NgayTao = DataReader.GetDate("NgayTao");
                        data.NgaySua = DataReader.GetDate("NgaySua");
                        data.MaSoKy = DataReader.GetString("masokyten");
                        data.NgayKy = DataReader.GetDate("ngayky");
                        data.TenFileKy = DataReader.GetString("tenfileky");
                        data.UserNameKy = DataReader.GetString("usernameky");
                        return data;
                    }
                    catch (Exception ex)
                    {
                        MDB.ExceptionExtend.LogError(ex);
                    }
                }
                DataReader.Close();
                DataReader = null;
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return null;
        }

        private static NhanVien getNhanVienFromID(decimal id)
        {
            foreach (NhanVien nv in NhanVienFunc.ListNhanVien)
            {
                if (nv.IdNhanVien == id)
                {
                    return nv;
                }
            }
            return null;

        }
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, decimal IDPhieuDinhDuong)
        {
            string sql2 = @"SELECT
                D.*,
	            T.MABENHNHAN,
	            T.KHOA,
	            T.GIUONG,
                T.BUONG,
	            T.NGAYVAOVIEN,
                D.CHANDOAN CHANDOAN_SOBO,
                D.CHIEUCAO,
                D.CANNANG,
                D.BMI_So BMI_THONGTIN,
	            H.SOYTE,
	            H.BENHVIEN,
	            H.MABENHNHAN,
	            H.TENBENHNHAN,
	            H.TUOI,
	            H.GIOITINH,
                N.HOVATEN NGUOIDANHGIA1HT,
                N2.HOVATEN NGUOIDANHGIA2HT
            FROM
                DanhGiaDinhDuong D
                LEFT JOIN THONGTINDIEUTRI T ON D.MAQUANLY = T.MAQUANLY
                LEFT JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
                LEFT JOIN NHANVIEN N ON D.NGUOIDANHGIA1 = N.IDNHANVIEN
                LEFT JOIN NHANVIEN N2 ON D.NGUOIDANHGIA2 = N2.IDNHANVIEN
            WHERE
                IDPhieuDinhDuong = :IDPhieuDinhDuong";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql2, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("IDPhieuDinhDuong", IDPhieuDinhDuong));

            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            adt.Fill(ds);
            return ds;
        }
    }
}
