using EMR.KyDienTu;
using MDB;
using System;
using System.Collections.Generic;
using System.Data;
using PMS.Access; 

namespace EMR_MAIN.DATABASE.Other
{
    public class YeuCauSuDungKhangSinh : ThongTinKy
    {
        public YeuCauSuDungKhangSinh()
        {
            TableName = "YeuCauSuDungKhangSinh";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.YCSDKS;
            TenMauPhieu = DanhMucPhieu.YCSDKS.Description();
        }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        public decimal IdKPhieuYeuCauSuDungKhangSinh { set; get; } = -1;
        [MoTaDuLieu("Mã bệnh án")]
		public string MaBenhAn { get; set; }
        public string MoTaTrieuChungLamSang { get; set; }
        public string KhangSinhYeuCau { get; set; }
        public string LieuDung { get; set; }
        public bool NhiemKhuanBV { get; set; }
        public bool NhiemKhuanCongDong { get; set; }
        public string MauBenhPham { get; set; }
        public string KQNuoiCay1 { get; set; }
        public string KQNuoiCay2 { get; set; }
        public string KQNuoiCay3 { get; set; }
        public string KQNuoiCay4 { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Ngày tháng năm")]
        public DateTime NgayThangNam { get; set; }

        public NhanVien BacSyDieuTri { get; set; }
        public NhanVien TruongKhoaDuoc { get; set; }
        public NhanVien LanhDaoBenhVien { get; set; }
    }

    public class YeuCauSuDungKhangSinhFunc
    {


        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, YeuCauSuDungKhangSinh yeuCauSuDungKhangSinh)
        {
            //phieuBieuDoChuyenDa.DaVoOi ? 1 : 0)
            string sql;
            int n;
            decimal xoa = 0;
            if (yeuCauSuDungKhangSinh.IdKPhieuYeuCauSuDungKhangSinh == -1)
            {
                sql = @"INSERT INTO YeuCauSuDungKhangSinh (
		        NgayThangNam,
		        MaQuanLy,
		        MaBenhAn,
		        MoTaTrieuChungLamSang,
		        KhangSinhYeuCau,
		        LieuDung,
                NhiemKhuanBV,
		        NhiemKhuanCongDong,
                MauBenhPham,
                KQNuoiCay1,
                KQNuoiCay2,
                KQNuoiCay3,
                KQNuoiCay4,
                ChanDoan,
                BacSyDieuTri,
                TruongKhoaDuoc,
                LanhDaoBenhVien,
                Xoa
                )
                VALUES
	                    (
		       :NgayThangNam, :MaQuanLy, :MaBenhAn, :MoTaTrieuChungLamSang, 
               :KhangSinhYeuCau, :LieuDung, :NhiemKhuanBV, :NhiemKhuanCongDong,
               :MauBenhPham, :KQNuoiCay1, :KQNuoiCay2, :KQNuoiCay3, :KQNuoiCay4,  :ChanDoan,
               :BacSyDieuTri, :TruongKhoaDuoc, :LanhDaoBenhVien, :Xoa
                ) RETURNING IdKPhieuYeuCauSuDungKhangSinh INTO :IdKPhieuYeuCauSuDungKhangSinh";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("NgayThangNam", yeuCauSuDungKhangSinh.NgayThangNam));
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", yeuCauSuDungKhangSinh.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhAn", yeuCauSuDungKhangSinh.MaBenhAn));
                Command.Parameters.Add(new MDB.MDBParameter("MoTaTrieuChungLamSang", yeuCauSuDungKhangSinh.MoTaTrieuChungLamSang));
                Command.Parameters.Add(new MDB.MDBParameter("KhangSinhYeuCau", yeuCauSuDungKhangSinh.KhangSinhYeuCau));
                Command.Parameters.Add(new MDB.MDBParameter("LieuDung", yeuCauSuDungKhangSinh.LieuDung));
                Command.Parameters.Add(new MDB.MDBParameter("NhiemKhuanBV", yeuCauSuDungKhangSinh.NhiemKhuanBV ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("NhiemKhuanCongDong", yeuCauSuDungKhangSinh.NhiemKhuanCongDong ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("MauBenhPham", yeuCauSuDungKhangSinh.MauBenhPham));
                Command.Parameters.Add(new MDB.MDBParameter("KQNuoiCay1", yeuCauSuDungKhangSinh.KQNuoiCay1));
                Command.Parameters.Add(new MDB.MDBParameter("KQNuoiCay2", yeuCauSuDungKhangSinh.KQNuoiCay2));
                Command.Parameters.Add(new MDB.MDBParameter("KQNuoiCay3", yeuCauSuDungKhangSinh.KQNuoiCay3));
                Command.Parameters.Add(new MDB.MDBParameter("KQNuoiCay4", yeuCauSuDungKhangSinh.KQNuoiCay4));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", yeuCauSuDungKhangSinh.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", (yeuCauSuDungKhangSinh.BacSyDieuTri != null)? yeuCauSuDungKhangSinh.BacSyDieuTri.IdNhanVien:-1));
                Command.Parameters.Add(new MDB.MDBParameter("TruongKhoaDuoc", (yeuCauSuDungKhangSinh.TruongKhoaDuoc != null) ? yeuCauSuDungKhangSinh.TruongKhoaDuoc.IdNhanVien : -1));
                Command.Parameters.Add(new MDB.MDBParameter("LanhDaoBenhVien", (yeuCauSuDungKhangSinh.LanhDaoBenhVien != null) ? yeuCauSuDungKhangSinh.LanhDaoBenhVien.IdNhanVien : -1));
                Command.Parameters.Add(new MDB.MDBParameter("Xoa", xoa));
                Command.Parameters.Add(new MDB.MDBParameter("IdKPhieuYeuCauSuDungKhangSinh", yeuCauSuDungKhangSinh.IdKPhieuYeuCauSuDungKhangSinh));
                n = Command.ExecuteNonQuery();
                decimal nextval = Convert.ToInt64((Command.Parameters["IdKPhieuYeuCauSuDungKhangSinh"] as MDB.MDBParameter).Value);
                yeuCauSuDungKhangSinh.IdKPhieuYeuCauSuDungKhangSinh = nextval;
            }

            else
            {
                sql = @"UPDATE YeuCauSuDungKhangSinh SET 
                NgayThangNam =  :NgayThangNam,MaQuanLy= :MaQuanLy,MaBenhAn= :MaBenhAn, MoTaTrieuChungLamSang= :MoTaTrieuChungLamSang, 
               KhangSinhYeuCau = :KhangSinhYeuCau, LieuDung = :LieuDung, NhiemKhuanBV = :NhiemKhuanBV, NhiemKhuanCongDong = :NhiemKhuanCongDong,
              MauBenhPham = :MauBenhPham,KQNuoiCay1 = :KQNuoiCay1, KQNuoiCay2 = :KQNuoiCay2, KQNuoiCay3 = :KQNuoiCay3, KQNuoiCay4 = :KQNuoiCay4, ChanDoan = :ChanDoan,
               BacSyDieuTri = :BacSyDieuTri, TruongKhoaDuoc = :TruongKhoaDuoc, LanhDaoBenhVien = :LanhDaoBenhVien
               Where IdKPhieuYeuCauSuDungKhangSinh = :IdKPhieuYeuCauSuDungKhangSinh";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("NgayThangNam", yeuCauSuDungKhangSinh.NgayThangNam));
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", yeuCauSuDungKhangSinh.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhAn", yeuCauSuDungKhangSinh.MaBenhAn));
                Command.Parameters.Add(new MDB.MDBParameter("MoTaTrieuChungLamSang", yeuCauSuDungKhangSinh.MoTaTrieuChungLamSang));
                Command.Parameters.Add(new MDB.MDBParameter("KhangSinhYeuCau", yeuCauSuDungKhangSinh.KhangSinhYeuCau));
                Command.Parameters.Add(new MDB.MDBParameter("LieuDung", yeuCauSuDungKhangSinh.LieuDung));
                Command.Parameters.Add(new MDB.MDBParameter("NhiemKhuanBV", yeuCauSuDungKhangSinh.NhiemKhuanBV ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("NhiemKhuanCongDong", yeuCauSuDungKhangSinh.NhiemKhuanCongDong ? 1 : 0));
                Command.Parameters.Add(new MDB.MDBParameter("MauBenhPham", yeuCauSuDungKhangSinh.MauBenhPham));
                Command.Parameters.Add(new MDB.MDBParameter("KQNuoiCay1", yeuCauSuDungKhangSinh.KQNuoiCay1));
                Command.Parameters.Add(new MDB.MDBParameter("KQNuoiCay2", yeuCauSuDungKhangSinh.KQNuoiCay2));
                Command.Parameters.Add(new MDB.MDBParameter("KQNuoiCay3", yeuCauSuDungKhangSinh.KQNuoiCay3));
                Command.Parameters.Add(new MDB.MDBParameter("KQNuoiCay4", yeuCauSuDungKhangSinh.KQNuoiCay4));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", yeuCauSuDungKhangSinh.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", (yeuCauSuDungKhangSinh.BacSyDieuTri != null) ? yeuCauSuDungKhangSinh.BacSyDieuTri.IdNhanVien : -1));
                Command.Parameters.Add(new MDB.MDBParameter("TruongKhoaDuoc", (yeuCauSuDungKhangSinh.TruongKhoaDuoc != null) ? yeuCauSuDungKhangSinh.TruongKhoaDuoc.IdNhanVien : -1));
                Command.Parameters.Add(new MDB.MDBParameter("LanhDaoBenhVien", (yeuCauSuDungKhangSinh.LanhDaoBenhVien != null) ? yeuCauSuDungKhangSinh.LanhDaoBenhVien.IdNhanVien : -1));
                Command.Parameters.Add(new MDB.MDBParameter("IdKPhieuYeuCauSuDungKhangSinh", yeuCauSuDungKhangSinh.IdKPhieuYeuCauSuDungKhangSinh));
                Command.BindByName = true;
                n = Command.ExecuteNonQuery();
            }
            return n > 0 ? true : false;
        }

        public static bool Delete(MDBConnection MyConnection, decimal IdKPhieuYeuCauSuDungKhangSinh)
        {
            string sql = @"UPDATE YeuCauSuDungKhangSinh SET 
                Xoa = 1
               Where IdKPhieuYeuCauSuDungKhangSinh = :IdKPhieuYeuCauSuDungKhangSinh";
            MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
            command.Parameters.Add(new MDB.MDBParameter("IdKPhieuYeuCauSuDungKhangSinh", IdKPhieuYeuCauSuDungKhangSinh));
            command.BindByName = true;
            int n = command.ExecuteNonQuery();
            return n > 0 ? true : false;
        }

        public static List<YeuCauSuDungKhangSinh> GetListYeuCau(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<YeuCauSuDungKhangSinh> list = new List<YeuCauSuDungKhangSinh>();
            try
            {

                string sql = @"SELECT * FROM YeuCauSuDungKhangSinh where MaQuanLy = :MaQuanLy AND XOA = 0";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    YeuCauSuDungKhangSinh data = new YeuCauSuDungKhangSinh();
                    data.IdKPhieuYeuCauSuDungKhangSinh = Convert.ToInt64(DataReader.GetLong("IdKPhieuYeuCauSuDungKhangSinh").ToString());
                    data.NgayThangNam = Convert.ToDateTime(DataReader["NgayThangNam"] == DBNull.Value ? DateTime.Now : DataReader["NgayThangNam"]);

                    data.KhangSinhYeuCau =DataReader["KhangSinhYeuCau"].ToString();
                    data.LieuDung =DataReader["LieuDung"].ToString();
                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }

        public static YeuCauSuDungKhangSinh GetData(MDB.MDBConnection _OracleConnection, decimal id)
        {
            try
            {
                string sql = @"SELECT * FROM YeuCauSuDungKhangSinh where IdKPhieuYeuCauSuDungKhangSinh = :IdKPhieuYeuCauSuDungKhangSinh";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("IdKPhieuYeuCauSuDungKhangSinh", id));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    YeuCauSuDungKhangSinh data = new YeuCauSuDungKhangSinh();
                    data.NgayThangNam = Convert.ToDateTime(DataReader["NgayThangNam"] == DBNull.Value ? DateTime.Now : DataReader["NgayThangNam"]);
                    data.MaQuanLy = decimal.Parse(DataReader["MaQuanLy"].ToString());
                    data.MaBenhAn = DataReader["MaBenhAn"].ToString();
                    data.MoTaTrieuChungLamSang = DataReader["MoTaTrieuChungLamSang"].ToString();
                    data.KhangSinhYeuCau = DataReader["KhangSinhYeuCau"].ToString();
                    data.LieuDung = DataReader["LieuDung"].ToString();
                    data.NhiemKhuanBV = DataReader["NhiemKhuanBV"].ToString().Trim().Equals("1") ? true : false;
                    data.NhiemKhuanCongDong = DataReader["NhiemKhuanCongDong"].ToString().Trim().Equals("1") ? true : false;
                    data.MauBenhPham = DataReader["MauBenhPham"].ToString();
                    data.KQNuoiCay1 = DataReader["KQNuoiCay1"].ToString();
                    data.KQNuoiCay2 = DataReader["KQNuoiCay2"].ToString();
                    data.KQNuoiCay3 = DataReader["KQNuoiCay3"].ToString();
                    data.KQNuoiCay4 = DataReader["KQNuoiCay4"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.BacSyDieuTri = getNhanVienFromID(decimal.Parse(DataReader["BacSyDieuTri"].ToString()));
                    data.TruongKhoaDuoc = getNhanVienFromID(decimal.Parse(DataReader["TruongKhoaDuoc"].ToString()));
                    data.LanhDaoBenhVien = getNhanVienFromID(decimal.Parse(DataReader["LanhDaoBenhVien"].ToString()));                   
                    data.IdKPhieuYeuCauSuDungKhangSinh = id;                   
                    return data;
                }
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
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, decimal IdKPhieuYeuCauSuDungKhangSinh)
        {
            string sql2 = @"SELECT
                Y.*,
	            T.KHOA,
	            T.BUONG,
                T.CHANDOAN_NOICHUYENDEN,
	            H.TENBENHNHAN,
	            H.TUOI,
                H.SoYTe,
                H.BenhVien,
	            H.GIOITINH,
                N.HOVATEN BACSYDIEUTRI_HT,
                N2.HOVATEN TRUONGKHOADUOC_HT,
                N3.HOVATEN LANHDAOBENHVIEN_HT
            FROM
                YeuCauSuDungKhangSinh Y
                LEFT JOIN THONGTINDIEUTRI T ON Y.MAQUANLY = T.MAQUANLY
                LEFT JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
                LEFT JOIN NHANVIEN N ON Y.BACSYDIEUTRI = N.IDNHANVIEN
                LEFT JOIN NHANVIEN N2 ON Y.TRUONGKHOADUOC = N2.IDNHANVIEN
                LEFT JOIN NHANVIEN N3 ON Y.LANHDAOBENHVIEN = N3.IDNHANVIEN
            WHERE
                IdKPhieuYeuCauSuDungKhangSinh = :IdKPhieuYeuCauSuDungKhangSinh";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql2, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("IdKPhieuYeuCauSuDungKhangSinh", IdKPhieuYeuCauSuDungKhangSinh));
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            adt.Fill(ds);
            return ds;
        }
    }
}

