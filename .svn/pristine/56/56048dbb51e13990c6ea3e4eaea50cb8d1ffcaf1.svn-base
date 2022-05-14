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
    public class PhieuDemGacChiTiet
    {
        public string Loai { get; set; }
        public string Xuat { get; set; }
        public string Thu { get; set; }
        public string KetLuan { get; set; }
        public PhieuDemGacChiTiet() { }
        public PhieuDemGacChiTiet(string loai)
        {
            Loai = loai;
        }
    }
    public class PhieuDemGac : ThongTinKy
    {
        public PhieuDemGac()
        {
            TableName = "PhieuDemGac";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PDG;
            TenMauPhieu = DanhMucPhieu.PDG.Description();
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
        public string MaBenhAn
        {
            get
            {
                return XemBenhAn._ThongTinDieuTri.MaBenhAn;
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
                return XemBenhAn._ThongTinDieuTri.Giuong;
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
        public string CachThucPhauThuat { get; set; }
        public string MaPhauThuatVien { get; set; }
        public string PhauThuatVien { get; set; }
        public string MaDungCuVien { get; set; }
        public string DungCuVien { get; set; }
        public string PhongMo { get; set; }
        public DateTime ThoiGianBatDau { get; set; }
        public DateTime ThoiGianKetThuc { get; set; }
        public List<PhieuDemGacChiTiet> ChiTietGac { get; set; }
        public List<PhieuDemGacChiTiet> ChiTietDungCu { get; set; }
        public string NhanXet { get; set; }
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
    public class PhieuDemGacFunc
    {
        public const string TableName = "PhieuDemGac";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuDemGac> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuDemGac> list = new List<PhieuDemGac>();
            try
            {
                string sql = @"SELECT * FROM PhieuDemGac where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuDemGac data = new PhieuDemGac();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.CachThucPhauThuat = DataReader["CachThucPhauThuat"].ToString();
                    data.MaPhauThuatVien = DataReader["MaPhauThuatVien"].ToString();
                    data.PhauThuatVien = DataReader["PhauThuatVien"].ToString();
                    data.MaDungCuVien = DataReader["MaDungCuVien"].ToString();
                    data.DungCuVien = DataReader["DungCuVien"].ToString();
                    data.PhongMo = DataReader["PhongMo"].ToString();
                    data.ThoiGianBatDau = Convert.ToDateTime(DataReader["ThoiGianBatDau"] == DBNull.Value ? DateTime.Now : DataReader["ThoiGianBatDau"]);
                    data.ThoiGianKetThuc = Convert.ToDateTime(DataReader["ThoiGianKetThuc"] == DBNull.Value ? DateTime.Now : DataReader["ThoiGianKetThuc"]);
                    data.ChiTietGac = JsonConvert.DeserializeObject<List<PhieuDemGacChiTiet>>(DataReader["ChiTietGac"].ToString());
                    data.ChiTietDungCu = JsonConvert.DeserializeObject<List<PhieuDemGacChiTiet>>(DataReader["ChiTietDungCu"].ToString());
                    data.NhanXet = DataReader["NhanXet"].ToString();

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuDemGac data)
        {
            try
            {
                string sql = @"INSERT INTO PhieuDemGac
                (
                    MaQuanLy,
                    CachThucPhauThuat,
                    MaPhauThuatVien,
                    PhauThuatVien,
                    MaDungCuVien,
                    DungCuVien,
                    PhongMo,
                    ThoiGianBatDau,
                    ThoiGianKetThuc,
                    ChiTietGac,
                    ChiTietDungCu,
                    NhanXet,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
                    :CachThucPhauThuat,
                    :MaPhauThuatVien,
                    :PhauThuatVien,
                    :MaDungCuVien,
                    :DungCuVien,
                    :PhongMo,
                    :ThoiGianBatDau,
                    :ThoiGianKetThuc,
                    :ChiTietGac,
                    :ChiTietDungCu,
                    :NhanXet,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (data.ID != 0)
                {
                    sql = @"UPDATE PhieuDemGac SET 
                    MaQuanLy=:MaQuanLy,
                    CachThucPhauThuat=:CachThucPhauThuat,
                    MaPhauThuatVien=:MaPhauThuatVien,
                    PhauThuatVien=:PhauThuatVien,
                    MaDungCuVien=:MaDungCuVien,
                    DungCuVien=:DungCuVien,
                    PhongMo=:PhongMo,
                    ThoiGianBatDau=:ThoiGianBatDau,
                    ThoiGianKetThuc=:ThoiGianKetThuc,
                    ChiTietGac=:ChiTietGac,
                    ChiTietDungCu=:ChiTietDungCu,
                    NhanXet=:NhanXet,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + data.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", data.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("CachThucPhauThuat", data.CachThucPhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("MaPhauThuatVien", data.MaPhauThuatVien));
                Command.Parameters.Add(new MDB.MDBParameter("PhauThuatVien", data.PhauThuatVien));
                Command.Parameters.Add(new MDB.MDBParameter("MaDungCuVien", data.MaDungCuVien));
                Command.Parameters.Add(new MDB.MDBParameter("DungCuVien", data.DungCuVien));
                Command.Parameters.Add(new MDB.MDBParameter("PhongMo", data.PhongMo));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianBatDau", data.ThoiGianBatDau));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianKetThuc", data.ThoiGianKetThuc));
                Command.Parameters.Add(new MDB.MDBParameter("ChiTietGac", JsonConvert.SerializeObject(data.ChiTietGac)));
                Command.Parameters.Add(new MDB.MDBParameter("ChiTietDungCu", JsonConvert.SerializeObject(data.ChiTietDungCu)));
                Command.Parameters.Add(new MDB.MDBParameter("NhanXet", data.NhanXet));
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
                string sql = "DELETE FROM PhieuDemGac WHERE ID = :ID";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                command.Parameters.Add(new MDB.MDBParameter("ID", id));
                command.BindByName = true;
                return command.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, long id)
        {
            string sql = @"SELECT * FROM PhieuDemGac WHERE ID = " + id;
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            PhieuDemGac data = new PhieuDemGac();
            adt.Fill(ds, "DS");
            if (ds != null && ds.Tables[0] != null)
            {
                ds.Tables[0].Columns.Add("SoYTe");
                ds.Tables[0].Columns.Add("BenhVien");
                ds.Tables[0].Columns.Add("Khoa");
                ds.Tables[0].Columns.Add("MaBenhNhan");
                ds.Tables[0].Columns.Add("MaBenhAn");
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
                    ds.Tables[0].Rows[0]["MaBenhAn"] = data.MaBenhAn;
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
