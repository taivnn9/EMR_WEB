using EMR.KyDienTu;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{

    public class PhieuKhamChuyenKhoa : ThongTinKy
    {
        public PhieuKhamChuyenKhoa()
        {
            TableName = "PhieuKhamChuyenKhoa";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PKCK;
            TenMauPhieu = DanhMucPhieu.PKCK.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        public string SoYTe
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.SoYTe;
            }
        }
        public string BenhVien
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.BenhVien;
            }
        }
        public string Khoa
        {
            get
            {
                return XemBenhAn._ThongTinDieuTri.Khoa;
            }
        }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan
        {
            get
            {
                return XemBenhAn._ThongTinDieuTri.MaBenhNhan;
            }
        }
        public string SoVaoVien
        {
            get
            {
                return XemBenhAn._ThongTinDieuTri.SoNhapVien;
            }
        }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            }
        }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.Tuoi;
            }
        }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.GioiTinh.ToString();
            }
        }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi
        {
            get
            {
                return Common.GetDiaChi();
            }
        }
        public string Buong
        {
            get
            {
                return XemBenhAn._ThongTinDieuTri.Buong;
            }
        }
        public string Giuong
        {
            get
            {
                return XemBenhAn._ThongTinDieuTri.TenGiuong;
            }
        }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan
        {
            get
            {
                return Common.getChanDoan();
            }
        }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        public string YeuCau { get; set; }
        public string KetQua { get; set; }
        public DateTime ThoiGian { get; set; }
        [MoTaDuLieu("Mã bác sỹ")]
		public string MaBacSi { get; set; }
        [MoTaDuLieu("Họ tên bác sỹ")]
		public string BacSi { get; set; }
        public DateTime ThoiGian2 { get; set; }
        public string MaBacSi2 { get; set; }
        public string BacSi2 { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
    }
    public class PhieuKhamChuyenKhoaFunc
    {
        public const string TableName = "PhieuKhamChuyenKhoa";
        public const string TablePrimaryKeyName = "ID";
        public const string MaPhieu = "PKCK";
        public static List<PhieuKhamChuyenKhoa> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuKhamChuyenKhoa> list = new List<PhieuKhamChuyenKhoa>();
            try
            {
                string sql = @"SELECT * FROM PhieuKhamChuyenKhoa where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuKhamChuyenKhoa data = new PhieuKhamChuyenKhoa();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.YeuCau = DataReader["YeuCau"].ToString();
                    data.KetQua = DataReader["KetQua"].ToString();
                    data.ThoiGian = Convert.ToDateTime(DataReader["ThoiGian"] == DBNull.Value ? DateTime.Now : DataReader["ThoiGian"]);
                    data.MaBacSi = DataReader["MaBacSi"].ToString();
                    data.BacSi = DataReader["BacSi"].ToString();
                    data.ThoiGian2 = Convert.ToDateTime(DataReader["ThoiGian2"] == DBNull.Value ? DateTime.Now : DataReader["ThoiGian2"]);
                    data.MaBacSi2 = DataReader["MaBacSi2"].ToString();
                    data.BacSi2 = DataReader["BacSi2"].ToString();

                    data.NguoiTao = DataReader["NguoiTao"].ToString();
                    data.NguoiSua = DataReader["NguoiSua"].ToString();
                    data.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                    data.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);
                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy);
                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuKhamChuyenKhoa data)
        {
            try
            {
                string sql = @"INSERT INTO PhieuKhamChuyenKhoa
                (
                    MAQUANLY,
                    YeuCau,
                    KetQua,
                    ThoiGian,
                    MaBacSi,
                    BacSi,
                    ThoiGian2,
                    MaBacSi2,
                    BacSi2,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :YeuCau,
                    :KetQua,
                    :ThoiGian,
                    :MaBacSi,
                    :BacSi,
                    :ThoiGian2,
                    :MaBacSi2,
                    :BacSi2,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (data.ID != 0)
                {
                    sql = @"UPDATE PhieuKhamChuyenKhoa SET 
                    MAQUANLY = :MAQUANLY,
                    YeuCau=:YeuCau,
                    KetQua=:KetQua,
                    ThoiGian=:ThoiGian,
                    MaBacSi=:MaBacSi,
                    BacSi=:BacSi,
                    ThoiGian2=:ThoiGian2,
                    MaBacSi2=:MaBacSi2,
                    BacSi2=:BacSi2,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + data.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", data.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("YeuCau", data.YeuCau));
                Command.Parameters.Add(new MDB.MDBParameter("KetQua", data.KetQua));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGian", data.ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSi", data.MaBacSi));
                Command.Parameters.Add(new MDB.MDBParameter("BacSi", data.BacSi));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGian2", data.ThoiGian2));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSi2", data.MaBacSi2));
                Command.Parameters.Add(new MDB.MDBParameter("BacSi2", data.BacSi2));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", data.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", data.NgaySua));
                if (data.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", data.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", data.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", data.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (data.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    data.ID = nextval;
                }
                return n > 0;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool Delete(MDB.MDBConnection MyConnection, long id)
        {
            try
            {
                string sql = "DELETE FROM PhieuKhamChuyenKhoa WHERE ID = :ID";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                command.Parameters.Add(new MDB.MDBParameter("ID", id));
                command.BindByName = true;
                int n = command.ExecuteNonQuery();
                return n > 0;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, long id)
        {
            string sql = @"SELECT * FROM PhieuKhamChuyenKhoa WHERE ID = " + id;
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            PhieuKhamChuyenKhoa data = new PhieuKhamChuyenKhoa();
            adt.Fill(ds, "DS");
            if (ds != null && ds.Tables[0] != null)
            {
                ds.Tables[0].Columns.Add("SoYTe");
                ds.Tables[0].Columns.Add("BenhVien");
                ds.Tables[0].Columns.Add("Khoa");
                ds.Tables[0].Columns.Add("MaBenhNhan");
                ds.Tables[0].Columns.Add("SoVaoVien");
                ds.Tables[0].Columns.Add("TenBenhNhan");
                ds.Tables[0].Columns.Add("Tuoi");
                ds.Tables[0].Columns.Add("GioiTinh");
                ds.Tables[0].Columns.Add("DiaChi");
                ds.Tables[0].Columns.Add("Buong");
                ds.Tables[0].Columns.Add("Giuong");
                ds.Tables[0].Columns.Add("ChanDoan");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    ds.Tables[0].Rows[0]["SoYTe"] = data.SoYTe;
                    ds.Tables[0].Rows[0]["BenhVien"] = data.BenhVien;
                    ds.Tables[0].Rows[0]["Khoa"] = data.Khoa;
                    ds.Tables[0].Rows[0]["MaBenhNhan"] = data.MaBenhNhan;
                    ds.Tables[0].Rows[0]["SoVaoVien"] = data.SoVaoVien;
                    ds.Tables[0].Rows[0]["TenBenhNhan"] = data.TenBenhNhan;
                    ds.Tables[0].Rows[0]["Tuoi"] = data.Tuoi;
                    ds.Tables[0].Rows[0]["GioiTinh"] = data.GioiTinh;
                    ds.Tables[0].Rows[0]["DiaChi"] = data.DiaChi;
                    ds.Tables[0].Rows[0]["Buong"] = data.Buong;
                    ds.Tables[0].Rows[0]["Giuong"] = data.Giuong;
                    ds.Tables[0].Rows[0]["ChanDoan"] = data.ChanDoan;
                }
            }
            return ds;
        }
    }
}
