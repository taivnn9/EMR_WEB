using EMR.KyDienTu;
using Newtonsoft.Json;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuTruyenInsulinChiTiet
    {
        public DateTime ThoiGianBatDau { get; set; }
        public string Glucose { get; set; }
        public string TocDoTruyen { get; set; }
    }
    public class PhieuTruyenInsulin : ThongTinKy
    {
        public PhieuTruyenInsulin()
        {
            TableName = "PhieuTruyenInsulin";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.TYLTITM;
            TenMauPhieu = DanhMucPhieu.TYLTITM.Description();
        }
        [MoTaDuLieu("ID định danh")]
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
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan
        {
            get
            {
                return Common.getChanDoan();
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
        public string NgheNghiep
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.NgheNghiep;
            }
        }
        public string DanToc
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.DanToc;
            }
        }
        public string HoTenDiaChiNguoiNha
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.HoTenDiaChiNguoiNha;
            }
        }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        public string PhaInsulin { get; set; }
        public List<PhieuTruyenInsulinChiTiet> ChiTiet { get; set; }
        public DateTime ThoiGianKetThuc { get; set; }
        public string TongLieu
        {
            get
            {
                if (ChiTiet == null)
                    return "0";
                return ChiTiet.Count() + "";
            }
        }
        public string TongLieu2 { get; set; }
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
    public class PhieuTruyenInsulinFunc
    {
        public const string TableName = "PhieuTruyenInsulin";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuTruyenInsulin> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuTruyenInsulin> list = new List<PhieuTruyenInsulin>();
            try
            {
                string sql = @"SELECT * FROM PhieuTruyenInsulin where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuTruyenInsulin data = new PhieuTruyenInsulin();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.PhaInsulin = Common.ConDBNull(DataReader["PhaInsulin"]);
                    data.ChiTiet = JsonConvert.DeserializeObject<List<PhieuTruyenInsulinChiTiet>>(Common.ConDBNull(DataReader["ChiTiet"]));
                    data.ThoiGianKetThuc = Common.ConDB_DateTime(DataReader["ThoiGianKetThuc"]);
                    data.TongLieu2 = Common.ConDBNull(DataReader["TongLieu2"]);

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuTruyenInsulin data)
        {
            try
            {
                string sql = @"INSERT INTO PhieuTruyenInsulin
                (
                    MaQuanLy,
                    PhaInsulin,
                    ChiTiet,
                    ThoiGianKetThuc,
                    TongLieu2,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
                    :PhaInsulin,
                    :ChiTiet,
                    :ThoiGianKetThuc,
                    :TongLieu2,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (data.ID != 0)
                {
                    sql = @"UPDATE PhieuTruyenInsulin SET 
                    MaQuanLy=:MaQuanLy,
                    PhaInsulin=:PhaInsulin,
                    ChiTiet=:ChiTiet,
                    ThoiGianKetThuc=:ThoiGianKetThuc,
                    TongLieu2=:TongLieu2,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + data.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", data.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("PhaInsulin", data.PhaInsulin));
                Command.Parameters.Add(new MDB.MDBParameter("ChiTiet", JsonConvert.SerializeObject(data.ChiTiet)));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianKetThuc", data.ThoiGianKetThuc));
                Command.Parameters.Add(new MDB.MDBParameter("TongLieu2", data.TongLieu2));
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
                string sql = "DELETE FROM PhieuTruyenInsulin WHERE ID = :ID";
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
            string sql = @"SELECT * FROM PhieuTruyenInsulin WHERE ID = " + id;
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            PhieuTruyenInsulin data = new PhieuTruyenInsulin();
            adt.Fill(ds, "DS");
            if (ds != null && ds.Tables[0] != null)
            {
                ds.Tables[0].Columns.Add("SoYTe");
                ds.Tables[0].Columns.Add("BenhVien");
                ds.Tables[0].Columns.Add("Khoa");
                ds.Tables[0].Columns.Add("MaBenhNhan");
                ds.Tables[0].Columns.Add("MaBenhAn");
                ds.Tables[0].Columns.Add("ChanDoan");
                ds.Tables[0].Columns.Add("SoVaoVien");
                ds.Tables[0].Columns.Add("TenBenhNhan");
                ds.Tables[0].Columns.Add("Tuoi");
                ds.Tables[0].Columns.Add("GioiTinh");
                ds.Tables[0].Columns.Add("DiaChi");
                ds.Tables[0].Columns.Add("Buong");
                ds.Tables[0].Columns.Add("Giuong");
                ds.Tables[0].Columns.Add("NgheNghiep");
                ds.Tables[0].Columns.Add("DanToc");
                ds.Tables[0].Columns.Add("HoTenDiaChiNguoiNha");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    ds.Tables[0].Rows[0]["SoYTe"] = data.SoYTe;
                    ds.Tables[0].Rows[0]["BenhVien"] = data.BenhVien;
                    ds.Tables[0].Rows[0]["Khoa"] = data.Khoa;
                    ds.Tables[0].Rows[0]["MaBenhNhan"] = data.MaBenhNhan;
                    ds.Tables[0].Rows[0]["MaBenhAn"] = XemBenhAn._ThongTinDieuTri.MaBenhAn;
                    ds.Tables[0].Rows[0]["ChanDoan"] = data.ChanDoan;
                    ds.Tables[0].Rows[0]["SoVaoVien"] = data.SoVaoVien;
                    ds.Tables[0].Rows[0]["TenBenhNhan"] = data.TenBenhNhan;
                    ds.Tables[0].Rows[0]["Tuoi"] = data.Tuoi;
                    ds.Tables[0].Rows[0]["GioiTinh"] = data.GioiTinh;
                    ds.Tables[0].Rows[0]["DiaChi"] = data.DiaChi;
                    ds.Tables[0].Rows[0]["Buong"] = data.Buong;
                    ds.Tables[0].Rows[0]["Giuong"] = data.Giuong;
                    ds.Tables[0].Rows[0]["NgheNghiep"] = data.NgheNghiep;
                    ds.Tables[0].Rows[0]["DanToc"] = data.DanToc;
                    ds.Tables[0].Rows[0]["HoTenDiaChiNguoiNha"] = data.HoTenDiaChiNguoiNha;
                }
            }
            return ds;
        }
    }
}
