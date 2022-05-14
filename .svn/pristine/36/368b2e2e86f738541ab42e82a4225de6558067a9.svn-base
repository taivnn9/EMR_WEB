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
    public class PhieuXetNghiemPhatMauChiTiet
    {
        public string TenNguoiHienMau { get; set; }
        public string MaDayTuiMau { get; set; }
        public DateTime NgayLayMau { get; set; }
        public string HanDung { get; set; }
        public PhieuXetNghiemPhatMauChiTiet() { }
        public PhieuXetNghiemPhatMauChiTiet(DateTime NgayLayMau) { this.NgayLayMau = NgayLayMau; }
    }
    public class PhieuXetNghiemPhatMau : ThongTinKy
    {
        public PhieuXetNghiemPhatMau()
        {
            TableName = "PhieuXetNghiemPhatMau";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PXNHHMDPM;
            TenMauPhieu = DanhMucPhieu.PXNHHMDPM.Description();
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
        public DateTime ThoiGian { get; set; }
        public string LoaiChePham { get; set; }
        public string SoDonVi { get; set; }
        public string LoaiTheTich { get; set; }
        public string TongSoLuong { get; set; }
        public List<PhieuXetNghiemPhatMauChiTiet> ChiTiet { get; set; }
        public string KetQuaELISA { get; set; }
        public string KetQuaNAT { get; set; }
        public string NhomMauABODonVi { get; set; }
        public string NhomMauABODonViSL { get; set; }
        public string NhomMauABONguoiBenh { get; set; }
        public string NhomMauABONguoiBenhSL { get; set; }
        public string NhomMauRh { get; set; }
        public string NhomMauRhSL { get; set; }
        public string PhanUng22 { get; set; }
        public string PhanUng22SL { get; set; }
        public string PhanUng37 { get; set; }
        public string PhanUng37SL { get; set; }
        public string XetNghiemKhac { get; set; }
        public string XetNghiemKhacSL { get; set; }
        public string MaNguoiLamXetNghiem1 { get; set; }
        public string NguoiLamXetNghiem1 { get; set; }
        public string MaNguoiLamXetNghiem2 { get; set; }
        public string NguoiLamXetNghiem2 { get; set; }
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
    public class PhieuXetNghiemPhatMauFunc
    {
        public const string TableName = "PhieuXetNghiemPhatMau";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuXetNghiemPhatMau> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuXetNghiemPhatMau> list = new List<PhieuXetNghiemPhatMau>();
            try
            {
                string sql = @"SELECT * FROM PhieuXetNghiemPhatMau where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuXetNghiemPhatMau data = new PhieuXetNghiemPhatMau();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.ThoiGian = Convert.ToDateTime(DataReader["ThoiGian"] == DBNull.Value ? DateTime.Now : DataReader["ThoiGian"]);
                    data.LoaiChePham = DataReader["LoaiChePham"].ToString();
                    data.SoDonVi = DataReader["SoDonVi"].ToString();
                    data.LoaiTheTich = DataReader["LoaiTheTich"].ToString();
                    data.TongSoLuong = DataReader["TongSoLuong"].ToString();
                    data.ChiTiet = JsonConvert.DeserializeObject<List<PhieuXetNghiemPhatMauChiTiet>>(DataReader["ChiTiet"].ToString());
                    data.KetQuaELISA = DataReader["KetQuaELISA"].ToString();
                    data.KetQuaNAT = DataReader["KetQuaNAT"].ToString();
                    data.NhomMauABODonVi = DataReader["NhomMauABODonVi"].ToString();
                    data.NhomMauABODonViSL = DataReader["NhomMauABODonViSL"].ToString();
                    data.NhomMauABONguoiBenh = DataReader["NhomMauABONguoiBenh"].ToString();
                    data.NhomMauABONguoiBenhSL = DataReader["NhomMauABONguoiBenhSL"].ToString();
                    data.NhomMauRh = DataReader["NhomMauRh"].ToString();
                    data.NhomMauRhSL = DataReader["NhomMauRhSL"].ToString();
                    data.PhanUng22 = DataReader["PhanUng22"].ToString();
                    data.PhanUng22SL = DataReader["PhanUng22SL"].ToString();
                    data.PhanUng37 = DataReader["PhanUng37"].ToString();
                    data.PhanUng37SL = DataReader["PhanUng37SL"].ToString();
                    data.XetNghiemKhac = DataReader["XetNghiemKhac"].ToString();
                    data.XetNghiemKhacSL = DataReader["XetNghiemKhacSL"].ToString();
                    data.MaNguoiLamXetNghiem1 = DataReader["MaNguoiLamXetNghiem1"].ToString();
                    data.NguoiLamXetNghiem1 = DataReader["NguoiLamXetNghiem1"].ToString();
                    data.MaNguoiLamXetNghiem2 = DataReader["MaNguoiLamXetNghiem2"].ToString();
                    data.NguoiLamXetNghiem2 = DataReader["NguoiLamXetNghiem2"].ToString();

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuXetNghiemPhatMau data)
        {
            try
            {
                string sql = @"INSERT INTO PhieuXetNghiemPhatMau
                (
                    MaQuanLy,
                    ThoiGian,
                    LoaiChePham,
                    SoDonVi,
                    LoaiTheTich,
                    TongSoLuong,
                    ChiTiet,
                    KetQuaELISA,
                    KetQuaNAT,
                    NhomMauABODonVi,
                    NhomMauABODonViSL,
                    NhomMauABONguoiBenh,
                    NhomMauABONguoiBenhSL,
                    NhomMauRh,
                    NhomMauRhSL,
                    PhanUng22,
                    PhanUng22SL,
                    PhanUng37,
                    PhanUng37SL,
                    XetNghiemKhac,
                    XetNghiemKhacSL,
                    MaNguoiLamXetNghiem1,
                    NguoiLamXetNghiem1,
                    MaNguoiLamXetNghiem2,
                    NguoiLamXetNghiem2,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
                    :ThoiGian,
                    :LoaiChePham,
                    :SoDonVi,
                    :LoaiTheTich,
                    :TongSoLuong,
                    :ChiTiet,
                    :KetQuaELISA,
                    :KetQuaNAT,
                    :NhomMauABODonVi,
                    :NhomMauABODonViSL,
                    :NhomMauABONguoiBenh,
                    :NhomMauABONguoiBenhSL,
                    :NhomMauRh,
                    :NhomMauRhSL,
                    :PhanUng22,
                    :PhanUng22SL,
                    :PhanUng37,
                    :PhanUng37SL,
                    :XetNghiemKhac,
                    :XetNghiemKhacSL,
                    :MaNguoiLamXetNghiem1,
                    :NguoiLamXetNghiem1,
                    :MaNguoiLamXetNghiem2,
                    :NguoiLamXetNghiem2,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (data.ID != 0)
                {
                    sql = @"UPDATE PhieuXetNghiemPhatMau SET 
                    MaQuanLy=:MaQuanLy,
                    ThoiGian=:ThoiGian,
                    LoaiChePham=:LoaiChePham,
                    SoDonVi=:SoDonVi,
                    LoaiTheTich=:LoaiTheTich,
                    TongSoLuong=:TongSoLuong,
                    ChiTiet=:ChiTiet,
                    KetQuaELISA=:KetQuaELISA,
                    KetQuaNAT=:KetQuaNAT,
                    NhomMauABODonVi=:NhomMauABODonVi,
                    NhomMauABODonViSL=:NhomMauABODonViSL,
                    NhomMauABONguoiBenh=:NhomMauABONguoiBenh,
                    NhomMauABONguoiBenhSL=:NhomMauABONguoiBenhSL,
                    NhomMauRh=:NhomMauRh,
                    NhomMauRhSL=:NhomMauRhSL,
                    PhanUng22=:PhanUng22,
                    PhanUng22SL=:PhanUng22SL,
                    PhanUng37=:PhanUng37,
                    PhanUng37SL=:PhanUng37SL,
                    XetNghiemKhac=:XetNghiemKhac,
                    XetNghiemKhacSL=:XetNghiemKhacSL,
                    MaNguoiLamXetNghiem1=:MaNguoiLamXetNghiem1,
                    NguoiLamXetNghiem1=:NguoiLamXetNghiem1,
                    MaNguoiLamXetNghiem2=:MaNguoiLamXetNghiem2,
                    NguoiLamXetNghiem2=:NguoiLamXetNghiem2,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + data.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", data.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGian", data.ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiChePham", data.LoaiChePham));
                Command.Parameters.Add(new MDB.MDBParameter("SoDonVi", data.SoDonVi));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiTheTich", data.LoaiTheTich));
                Command.Parameters.Add(new MDB.MDBParameter("TongSoLuong", data.TongSoLuong));
                Command.Parameters.Add(new MDB.MDBParameter("ChiTiet", JsonConvert.SerializeObject(data.ChiTiet)));
                Command.Parameters.Add(new MDB.MDBParameter("KetQuaELISA", data.KetQuaELISA));
                Command.Parameters.Add(new MDB.MDBParameter("KetQuaNAT", data.KetQuaNAT));
                Command.Parameters.Add(new MDB.MDBParameter("NhomMauABODonVi", data.NhomMauABODonVi));
                Command.Parameters.Add(new MDB.MDBParameter("NhomMauABODonViSL", data.NhomMauABODonViSL));
                Command.Parameters.Add(new MDB.MDBParameter("NhomMauABONguoiBenh", data.NhomMauABONguoiBenh));
                Command.Parameters.Add(new MDB.MDBParameter("NhomMauABONguoiBenhSL", data.NhomMauABONguoiBenhSL));
                Command.Parameters.Add(new MDB.MDBParameter("NhomMauRh", data.NhomMauRh));
                Command.Parameters.Add(new MDB.MDBParameter("NhomMauRhSL", data.NhomMauRhSL));
                Command.Parameters.Add(new MDB.MDBParameter("PhanUng22", data.PhanUng22));
                Command.Parameters.Add(new MDB.MDBParameter("PhanUng22SL", data.PhanUng22SL));
                Command.Parameters.Add(new MDB.MDBParameter("PhanUng37", data.PhanUng37));
                Command.Parameters.Add(new MDB.MDBParameter("PhanUng37SL", data.PhanUng37SL));
                Command.Parameters.Add(new MDB.MDBParameter("XetNghiemKhac", data.XetNghiemKhac));
                Command.Parameters.Add(new MDB.MDBParameter("XetNghiemKhacSL", data.XetNghiemKhacSL));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiLamXetNghiem1", data.MaNguoiLamXetNghiem1));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiLamXetNghiem1", data.NguoiLamXetNghiem1));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiLamXetNghiem2", data.MaNguoiLamXetNghiem2));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiLamXetNghiem2", data.NguoiLamXetNghiem2));
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
                string sql = "DELETE FROM PhieuXetNghiemPhatMau WHERE ID = :ID";
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
            string sql = @"SELECT * FROM PhieuXetNghiemPhatMau WHERE ID = " + id;
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            PhieuXetNghiemPhatMau data = new PhieuXetNghiemPhatMau();
            adt.Fill(ds, "DS");
            if (ds != null && ds.Tables[0] != null)
            {
                ds.Tables[0].Columns.Add("SoYTe");
                ds.Tables[0].Columns.Add("BenhVien");
                ds.Tables[0].Columns.Add("Khoa");
                ds.Tables[0].Columns.Add("MaBenhNhan");
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
