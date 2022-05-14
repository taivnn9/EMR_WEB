using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMR.KyDienTu;
using PMS.Access;
namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuHoiChanPhauThuat : ThongTinKy
    {
        public PhieuHoiChanPhauThuat()
        {
            TableName = "PhieuHoiChanPhauThuat";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PHCPT;
            TenMauPhieu = DanhMucPhieu.PHCPT.Description();
        }
        [MoTaDuLieu("Mã định danh")]
        public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau", "", 1)]
        public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
        public string MaBenhNhan { get; set; }
        public string MaBenhAn {
            get
            {
                return XemBenhAn._ThongTinDieuTri.MaBenhAn;
            }
        }
        public string Khoa {
            get
            {
                return XemBenhAn._ThongTinDieuTri.Khoa;
            }
        }
        public string Tuoi {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.Tuoi;
            }
        }
        public string GioiTinh {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            }
        }
        public string TenBenhNhan {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            }
        }
        [MoTaDuLieu("Địa chỉ")]
        public string DiaChi { get; set; }
        [MoTaDuLieu("Ngày vào viện")]
        public DateTime? NgayVaoVien { get; set; }
        public string ChanDoan { get; set; }
        [MoTaDuLieu("Tóm tắt diễn biến và khám xét lâm sàng")]
        public string TTDBVaKhamXetLS { get; set; }
        [MoTaDuLieu("kết quả cận lâm sàng - máu - HC")]
        public string HC { get; set; }
        [MoTaDuLieu("kết quả cận lâm sàng - máu - HST")]
        public string HST { get; set; }
        [MoTaDuLieu("kết quả cận lâm sàng - máu - BC")]
        public string BC { get; set; }
        [MoTaDuLieu("kết quả cận lâm sàng - máu - MD")]
        public string MD { get; set; }
        [MoTaDuLieu("kết quả cận lâm sàng - máu - MC")]
        public string MC { get; set; }
        [MoTaDuLieu("kết quả cận lâm sàng - máu - NhomMau")]
        public string NhomMau { get; set; }
        [MoTaDuLieu("kết quả cận lâm sàng - máu - Ure")]
        public string Ure { get; set; }
        [MoTaDuLieu("kết quả cận lâm sàng - máu - Creatimin")]
        public string Creatimin { get; set; }
        [MoTaDuLieu("kết quả cận lâm sàng - máu - Glucoza")]
        public string Glucoza { get; set; }
        [MoTaDuLieu("kết quả cận lâm sàng - máu - ProtitMau")]
        public string ProtitMau { get; set; }
        [MoTaDuLieu("kết quả cận lâm sàng - máu - Howell")]
        public string Howell { get; set; }
        [MoTaDuLieu("kết quả cận lâm sàng - máu - ProThrobin")]
        public string ProThrobin { get; set; }
        [MoTaDuLieu("kết quả cận lâm sàng - NuocTieu")]
        public string NuocTieu { get; set; }
        [MoTaDuLieu("kết quả cận lâm sàng - SieuAm")]
        public string SieuAm { get; set; }
        [MoTaDuLieu("kết quả cận lâm sàng - XQ")]
        public string XQ { get; set; }
        [MoTaDuLieu("kết quả cận lâm sàng - DienTim")]
        public string DienTim { get; set; }
        [MoTaDuLieu("kết quả cận lâm sàng - PhanUngThuoc")]
        public string PhanUngThuoc { get; set; }
        [MoTaDuLieu("dự kiến phương pháp phẫu thuật")]
        public string DKPPPhauThuat { get; set; }
        [MoTaDuLieu("dự kiến phương pháp vô cảm")]
        public string DKPPVoCam { get; set; }
        [MoTaDuLieu("dự kiến khó khăn")]
        public string DKKhoKhan { get; set; }
        [MoTaDuLieu("dự trù máu")]
        public string DuTruMau { get; set; }
        [MoTaDuLieu("Thành viên tham gia")]
        public string ThanhVienThamGia { get; set; }
        [MoTaDuLieu("Danh sách thành viên tham gia")]
        public string DanhSachThanhVienThamGia { get; set; }
        [MoTaDuLieu("ngày mổ")]
        public DateTime? NgayMo { get; set; }
        public string TruongKhoa { get; set; }
        public string MaTruongKhoa { get; set; }
        public string BSGayMePT { get; set; }
        public string MaBSGayMePT { get; set; }
        public string BSDieuTri { get; set; }
        public string MaBSDieuTri { get; set; }
        public string YKienBenhVien { get; set; }
        public string GDBenhVien { get; set; }
        public string MaGDBenhVien { get; set; }

        public string NguoiTao { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
        public string NguoiSua { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
        public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
        public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
        public bool Chon { get; set; }
        //public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
        public bool DaKy { get; set; }
    }
    public class PhieuHoiChanPhauThuatFunc
    {
        public const string TableName = "PhieuHoiChanPhauThuat";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuHoiChanPhauThuat> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuHoiChanPhauThuat> list = new List<PhieuHoiChanPhauThuat>();
            try
            {
                string sql = @"SELECT * FROM PhieuHoiChanPhauThuat where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuHoiChanPhauThuat obj = new PhieuHoiChanPhauThuat();
                    obj.ID = DataReader.GetLong("ID");
                    obj.MaQuanLy = DataReader.GetDecimal("MaQuanLy");
                    obj.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    obj.DiaChi = DataReader["DiaChi"].ToString();
                    obj.NgayVaoVien = Common.ConDB_DateTime(DataReader["NgayVaoVien"]);
                    obj.ChanDoan = DataReader["ChanDoan"].ToString();
                    obj.TTDBVaKhamXetLS = DataReader["TTDBVaKhamXetLS"].ToString();
                    obj.HC = DataReader["HC"].ToString();
                    obj.HST = DataReader["HST"].ToString();
                    obj.BC = DataReader["BC"].ToString();
                    obj.MD = DataReader["MD"].ToString();
                    obj.MC = DataReader["MC"].ToString();
                    obj.NhomMau = DataReader["NhomMau"].ToString();
                    obj.Ure = DataReader["Ure"].ToString();
                    obj.Creatimin = DataReader["Creatimin"].ToString();
                    obj.Glucoza = DataReader["Glucoza"].ToString();
                    obj.ProtitMau = DataReader["ProtitMau"].ToString();
                    obj.Howell = DataReader["Howell"].ToString();
                    obj.ProThrobin = DataReader["ProThrobin"].ToString();
                    obj.NuocTieu = DataReader["NuocTieu"].ToString();
                    obj.SieuAm = DataReader["SieuAm"].ToString();
                    obj.XQ = DataReader["XQ"].ToString();
                    obj.DienTim = DataReader["DienTim"].ToString();
                    obj.PhanUngThuoc = DataReader["PhanUngThuoc"].ToString();
                    obj.DKPPPhauThuat = DataReader["DKPPPhauThuat"].ToString();
                    obj.DKPPVoCam = DataReader["DKPPVoCam"].ToString();
                    obj.DKKhoKhan = DataReader["DKKhoKhan"].ToString();
                    obj.DuTruMau = DataReader["DuTruMau"].ToString();
                    obj.ThanhVienThamGia = DataReader["ThanhVienThamGia"].ToString();
                    obj.DanhSachThanhVienThamGia = DataReader["DanhSachThanhVienThamGia"].ToString();
                    obj.NgayMo = Common.ConDB_DateTime(DataReader["NgayMo"]);
                    obj.TruongKhoa = DataReader["TruongKhoa"].ToString();
                    obj.MaTruongKhoa = DataReader["MaTruongKhoa"].ToString();
                    obj.BSGayMePT = DataReader["BSGayMePT"].ToString();
                    obj.MaBSGayMePT = DataReader["MaBSGayMePT"].ToString();
                    obj.BSDieuTri = DataReader["BSDieuTri"].ToString();
                    obj.MaBSDieuTri = DataReader["MaBSDieuTri"].ToString();
                    obj.YKienBenhVien = DataReader["YKienBenhVien"].ToString();
                    obj.GDBenhVien = DataReader["GDBenhVien"].ToString();
                    obj.MaGDBenhVien = DataReader["MaGDBenhVien"].ToString();


                    obj.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                    obj.NguoiTao = DataReader["NguoiTao"].ToString();
                    obj.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);
                    obj.NguoiSua = DataReader["NguoiSua"].ToString();

                    obj.MaSoKy = DataReader["masokyten"].ToString();
                    obj.DaKy = !string.IsNullOrEmpty(obj.MaSoKy) ? true : false;
                    list.Add(obj);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuHoiChanPhauThuat ketQua)
        {
            try
            {
                string sql = @"INSERT INTO PhieuHoiChanPhauThuat
                (
                    MaQuanLy,
                    MaBenhNhan,
                    DiaChi,
                    NgayVaoVien,
                    ChanDoan,
                    TTDBVaKhamXetLS,
                    HC,
                    HST,
                    BC,
                    MD,
                    MC,
                    NhomMau,
                    Ure,
                    Creatimin,
                    Glucoza,
                    ProtitMau,
                    Howell,
                    ProThrobin,
                    NuocTieu,
                    SieuAm,
                    XQ,
                    DienTim,
                    PhanUngThuoc,
                    DKPPPhauThuat,
                    DKPPVoCam,
                    DKKhoKhan,
                    DuTruMau,
                    ThanhVienThamGia,
                    DanhSachThanhVienThamGia,
                    NgayMo,
                    TruongKhoa,
                    MaTruongKhoa,
                    BSGayMePT,
                    MaBSGayMePT,
                    BSDieuTri,
                    MaBSDieuTri,
                    YKienBenhVien,
                    GDBenhVien,
                    MaGDBenhVien,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
                    :MaQuanLy,
                    :MaBenhNhan,
                    :DiaChi,
                    :NgayVaoVien,
                    :ChanDoan,
                    :TTDBVaKhamXetLS,
                    :HC,
                    :HST,
                    :BC,
                    :MD,
                    :MC,
                    :NhomMau,
                    :Ure,
                    :Creatimin,
                    :Glucoza,
                    :ProtitMau,
                    :Howell,
                    :ProThrobin,
                    :NuocTieu,
                    :SieuAm,
                    :XQ,
                    :DienTim,
                    :PhanUngThuoc,
                    :DKPPPhauThuat,
                    :DKPPVoCam,
                    :DKKhoKhan,
                    :DuTruMau,
                    :ThanhVienThamGia,
                    :DanhSachThanhVienThamGia,
                    :NgayMo,
                    :TruongKhoa,
                    :MaTruongKhoa,
                    :BSGayMePT,
                    :MaBSGayMePT,
                    :BSDieuTri,
                    :MaBSDieuTri,
                    :YKienBenhVien,
                    :GDBenhVien,
                    :MaGDBenhVien,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE PhieuHoiChanPhauThuat SET  
                    MaQuanLy=:MaQuanLy,
                    MaBenhNhan=:MaBenhNhan,
                    DiaChi=:DiaChi,
                    NgayVaoVien=:NgayVaoVien,
                    ChanDoan=:ChanDoan,
                    TTDBVaKhamXetLS=:TTDBVaKhamXetLS,
                    HC=:HC,
                    HST=:HST,
                    BC=:BC,
                    MD=:MD,
                    MC=:MC,
                    NhomMau=:NhomMau,
                    Ure=:Ure,
                    Creatimin=:Creatimin,
                    Glucoza=:Glucoza,
                    ProtitMau=:ProtitMau,
                    Howell=:Howell,
                    ProThrobin=:ProThrobin,
                    NuocTieu=:NuocTieu,
                    SieuAm=:SieuAm,
                    XQ=:XQ,
                    DienTim=:DienTim,
                    PhanUngThuoc=:PhanUngThuoc,
                    DKPPPhauThuat=:DKPPPhauThuat,
                    DKPPVoCam=:DKPPVoCam,
                    DKKhoKhan=:DKKhoKhan,
                    DuTruMau=:DuTruMau,
                    ThanhVienThamGia=:ThanhVienThamGia,
                    DanhSachThanhVienThamGia=:DanhSachThanhVienThamGia,
                    NgayMo=:NgayMo,
                    TruongKhoa=:TruongKhoa,
                    MaTruongKhoa=:MaTruongKhoa,
                    BSGayMePT=:BSGayMePT,
                    MaBSGayMePT=:MaBSGayMePT,
                    BSDieuTri=:BSDieuTri,
                    MaBSDieuTri=:MaBSDieuTri,
                    YKienBenhVien=:YKienBenhVien,
                    GDBenhVien=:GDBenhVien,
                    MaGDBenhVien=:MaGDBenhVien,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ketQua.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", ketQua.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("NgayVaoVien", ketQua.NgayVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", ketQua.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("TTDBVaKhamXetLS", ketQua.TTDBVaKhamXetLS));
                Command.Parameters.Add(new MDB.MDBParameter("HC", ketQua.HC));
                Command.Parameters.Add(new MDB.MDBParameter("HST", ketQua.HST));
                Command.Parameters.Add(new MDB.MDBParameter("BC", ketQua.BC));
                Command.Parameters.Add(new MDB.MDBParameter("MD", ketQua.MD));
                Command.Parameters.Add(new MDB.MDBParameter("MC", ketQua.MC));
                Command.Parameters.Add(new MDB.MDBParameter("NhomMau", ketQua.NhomMau));
                Command.Parameters.Add(new MDB.MDBParameter("Ure", ketQua.Ure));
                Command.Parameters.Add(new MDB.MDBParameter("Creatimin", ketQua.Creatimin));
                Command.Parameters.Add(new MDB.MDBParameter("Glucoza", ketQua.Glucoza));
                Command.Parameters.Add(new MDB.MDBParameter("ProtitMau", ketQua.ProtitMau));
                Command.Parameters.Add(new MDB.MDBParameter("Howell", ketQua.Howell));
                Command.Parameters.Add(new MDB.MDBParameter("ProThrobin", ketQua.ProThrobin));
                Command.Parameters.Add(new MDB.MDBParameter("NuocTieu", ketQua.NuocTieu));
                Command.Parameters.Add(new MDB.MDBParameter("SieuAm", ketQua.SieuAm));
                Command.Parameters.Add(new MDB.MDBParameter("XQ", ketQua.XQ));
                Command.Parameters.Add(new MDB.MDBParameter("DienTim", ketQua.DienTim));
                Command.Parameters.Add(new MDB.MDBParameter("PhanUngThuoc", ketQua.PhanUngThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("DKPPPhauThuat", ketQua.DKPPPhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("DKPPVoCam", ketQua.DKPPVoCam));
                Command.Parameters.Add(new MDB.MDBParameter("DKKhoKhan", ketQua.DKKhoKhan));
                Command.Parameters.Add(new MDB.MDBParameter("DuTruMau", ketQua.DuTruMau));
                Command.Parameters.Add(new MDB.MDBParameter("ThanhVienThamGia", ketQua.ThanhVienThamGia));
                Command.Parameters.Add(new MDB.MDBParameter("DanhSachThanhVienThamGia", ketQua.DanhSachThanhVienThamGia));
                Command.Parameters.Add(new MDB.MDBParameter("NgayMo", ketQua.NgayMo));
                Command.Parameters.Add(new MDB.MDBParameter("TruongKhoa", ketQua.TruongKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaTruongKhoa", ketQua.MaTruongKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("BSGayMePT", ketQua.BSGayMePT));
                Command.Parameters.Add(new MDB.MDBParameter("MaBSGayMePT", ketQua.MaBSGayMePT));
                Command.Parameters.Add(new MDB.MDBParameter("BSDieuTri", ketQua.BSDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("MaBSDieuTri", ketQua.MaBSDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("YKienBenhVien", ketQua.YKienBenhVien));
                Command.Parameters.Add(new MDB.MDBParameter("GDBenhVien", ketQua.GDBenhVien));
                Command.Parameters.Add(new MDB.MDBParameter("MaGDBenhVien", ketQua.MaGDBenhVien));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));
                if (ketQua.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", ketQua.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", ketQua.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", ketQua.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (ketQua.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    ketQua.ID = nextval;
                }
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool delete(MDB.MDBConnection MyConnection, long id)
        {
            try
            {
                string sql = "DELETE FROM PhieuHoiChanPhauThuat WHERE ID = :ID";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                command.Parameters.Add(new MDB.MDBParameter("ID", id));
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
        public static DataSet getDataSet(MDB.MDBConnection MyConnection, long id)
        {
            string sql = @"SELECT
                B.*,
                T.MABENHAN,
                T.NGAYVAOVIEN,
                H.GIOITINH,
	            H.TENBENHNHAN,
                H.TUOI
            FROM
                PhieuHoiChanPhauThuat B
                LEFT JOIN THONGTINDIEUTRI T ON B.MAQUANLY = T.MAQUANLY
                LEFT JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "BB");

            DataTable thongTinVien = new DataTable("HEADER");

            thongTinVien.Columns.Add("BENHVIEN");
            thongTinVien.Columns.Add("KHOA");
            if (XemBenhAn._HanhChinhBenhNhan == null) XemBenhAn._HanhChinhBenhNhan = new HanhChinhBenhNhan();
            if (XemBenhAn._ThongTinDieuTri == null) XemBenhAn._ThongTinDieuTri = new ThongTinDieuTri();
            thongTinVien.Rows.Add(XemBenhAn._HanhChinhBenhNhan.BenhVien, XemBenhAn._ThongTinDieuTri.Khoa);
            ds.Tables.Add(thongTinVien);

            return ds;
        }
    }
}
