using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuTaiKhamUngThuHacTo : ThongTinKy
    {
        public PhieuTaiKhamUngThuHacTo()
        {
            TableName = "PhieuTaiKhamUngThuHacTo";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PTKUTHT;
            TenMauPhieu = DanhMucPhieu.PTKUTHT.Description();
        }
        [MoTaDuLieu("Mã định danh")]
        public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau", "", 1)]
        public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
        public string MaBenhNhan { get; set; }
        public string HoTenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
        public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
        public string GioiTinh { get; set; }
        [MoTaDuLieu("Ngày khám")]
        public DateTime? NgayKham { get; set; }
        [MoTaDuLieu("1. Toàn thân")]
        public string ToanThan { get; set; }
        [MoTaDuLieu("2. Các bộ phận")]
        public string CacBoPhan { get; set; }
        [MoTaDuLieu("3. Thương tổn cơ bản")]
        public string ThuongTonCoBan { get; set; }
        [MoTaDuLieu("Mạch")]
        public string Mach { get; set; }
        [MoTaDuLieu("Nhiệt độ")]
        public string NhietDo { get; set; }
        [MoTaDuLieu("Huyết áp")]
        public string HuyetAp { get; set; }
        [MoTaDuLieu("Nhịp thở")]
        public string NhipTho { get; set; }
        [MoTaDuLieu("Cân nặng")]
        public string CanNang { get; set; }
        [MoTaDuLieu("Chiều cao")]
        public string ChieuCao { get; set; }
        [MoTaDuLieu("BMI")]
        public string BMI { get; set; }
        [MoTaDuLieu("Hạch, 1-> không sờ thấy, 2 -> sờ thấy")]
        public int Hach { get; set; }
        [MoTaDuLieu("Vị trí hạch")]
        public string Hach_ViTri { get; set; }
        [MoTaDuLieu("Bất thường bộ phận khác (ghi rõ) ")]
        public string BatThuongBoPhanKhac { get; set; }
        [MoTaDuLieu("Hc")]
        public string HC { get; set; }
        [MoTaDuLieu("Hb")]
        public string Hb { get; set; }
        [MoTaDuLieu("BC")]
        public string BC { get; set; }
        [MoTaDuLieu("Lympho")]
        public string Lympho { get; set; }
        [MoTaDuLieu("TC")]
        public string TC { get; set; }
        [MoTaDuLieu("Nhóm máu")]
        public string NhomMau { get; set; }
        [MoTaDuLieu("Glucose")]
        public string Glucose { get; set; }
        [MoTaDuLieu("Ure")]
        public string Ure { get; set; }
        [MoTaDuLieu("Creatinin")]
        public string Creatinin { get; set; }
        [MoTaDuLieu("Cholesterol")]
        public string Cholesterol { get; set; }
        [MoTaDuLieu("Triglycerid")]
        public string Triglycerid { get; set; }
        [MoTaDuLieu("HDL-C")]
        public string HDLC { get; set; }
        [MoTaDuLieu("LDL-C")]
        public string LDLC { get; set; }
        [MoTaDuLieu("GOT")]
        public string GOT { get; set; }
        [MoTaDuLieu("GPT")]
        public string GPT { get; set; }
        [MoTaDuLieu("Protein TP")]
        public string ProteinTP { get; set; }
        [MoTaDuLieu("Albumin")]
        public string Albumin { get; set; }
        [MoTaDuLieu("Na+")]
        public string Na { get; set; }
        [MoTaDuLieu("K+")]
        public string K { get; set; }
        [MoTaDuLieu("Cl+")]
        public string Cl { get; set; }
        [MoTaDuLieu("Hình ảnh Dermoscopy")]
        public string HinhAnhDermoscopy { get; set; }
        [MoTaDuLieu("Xquang")]
        public string XQuang { get; set; }
        [MoTaDuLieu("Siêu âm (hạch/ổ bụng)")]
        public string SieuAm { get; set; }
        [MoTaDuLieu("Chẩn đoán hình ảnh khác")]
        public string ChanDoanHinhAnh_Khac { get; set; }
        [MoTaDuLieu("Mô bệnh học nhuộm HE")]
        public string MoBenhHocNhuomHe { get; set; }
        [MoTaDuLieu("Hóa mô miễn dịch")]
        public string HoaMoMienDich { get; set; }
        [MoTaDuLieu("Hạch viêm")]
        public int HachViem { get; set; }
        [MoTaDuLieu("Hạch di căn ")]
        public int HachDiCan { get; set; }
        [MoTaDuLieu("Hạch di căn, vị trí ")]
        public string HachDiCan_ViTri { get; set; }
        [MoTaDuLieu("Các xét nghiệm khác")]
        public string CacXetNghiemKhac { get; set; }
        [MoTaDuLieu("CHẨN ĐOÁN XÁC ĐỊNH (TNM VÀ GIAI ĐOẠN)")]
        public string ChanDoanXacDinh { get; set; }
        [MoTaDuLieu("ĐIỀU TRỊ")]
        public string DieuTri { get; set; }
        [MoTaDuLieu("HẸN KHÁM LẠI")]
        public string HenKhamLai { get; set; }
        // bắt buộc
        [MoTaDuLieu("Đã ký", null, 0, 0)]
        public bool DaKy { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
        public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
        public string NguoiTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
        public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
        public string NguoiSua { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
        public bool Chon { get; set; }
    }
    public class PhieuTaiKhamUngThuHacToFunc
    {
        public const string TableName = "PhieuTaiKhamUngThuHacTo";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuTaiKhamUngThuHacTo> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuTaiKhamUngThuHacTo> list = new List<PhieuTaiKhamUngThuHacTo>();
            try
            {
                string sql = @"SELECT * FROM PhieuTaiKhamUngThuHacTo where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuTaiKhamUngThuHacTo data = new PhieuTaiKhamUngThuHacTo();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.HoTenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.NgayKham = DataReader["NgayKham"] != DBNull.Value ? (DateTime?) Convert.ToDateTime(DataReader["NgayKham"].ToString()): null;
                    data.ToanThan = DataReader["ToanThan"].ToString();
                    data.CacBoPhan = DataReader["CacBoPhan"].ToString();
                    data.ThuongTonCoBan = DataReader["ThuongTonCoBan"].ToString();
                    data.Mach = DataReader["Mach"].ToString();
                    data.NhietDo = DataReader["NhietDo"].ToString();
                    data.HuyetAp = DataReader["HuyetAp"].ToString();
                    data.NhipTho = DataReader["NhipTho"].ToString();
                    data.CanNang = DataReader["CanNang"].ToString();
                    data.ChieuCao = DataReader["ChieuCao"].ToString();
                    data.BMI = DataReader["BMI"].ToString();
                    data.Hach = DataReader.GetInt("Hach");
                    data.Hach_ViTri = DataReader["Hach_ViTri"].ToString();
                    data.BatThuongBoPhanKhac = DataReader["BatThuongBoPhanKhac"].ToString();
                    data.HC = DataReader["HC"].ToString();
                    data.Hb = DataReader["Hb"].ToString();
                    data.BC = DataReader["BC"].ToString();
                    data.Lympho = DataReader["Lympho"].ToString();
                    data.TC = DataReader["TC"].ToString();
                    data.NhomMau = DataReader["NhomMau"].ToString();
                    data.Glucose = DataReader["Glucose"].ToString();
                    data.Ure = DataReader["Ure"].ToString();
                    data.Creatinin = DataReader["Creatinin"].ToString();
                    data.Cholesterol = DataReader["Cholesterol"].ToString();
                    data.Triglycerid = DataReader["Triglycerid"].ToString();
                    data.HDLC = DataReader["HDLC"].ToString();
                    data.LDLC = DataReader["LDLC"].ToString();
                    data.GOT = DataReader["GOT"].ToString();
                    data.GPT = DataReader["GPT"].ToString();
                    data.ProteinTP = DataReader["ProteinTP"].ToString();
                    data.Albumin = DataReader["Albumin"].ToString();
                    data.Na = DataReader["Na"].ToString();
                    data.K = DataReader["K"].ToString();
                    data.Cl = DataReader["Cl"].ToString();
                    data.HinhAnhDermoscopy = DataReader["HinhAnhDermoscopy"].ToString();
                    data.XQuang = DataReader["XQuang"].ToString();
                    data.SieuAm = DataReader["SieuAm"].ToString();
                    data.ChanDoanHinhAnh_Khac = DataReader["ChanDoanHinhAnh_Khac"].ToString();
                    data.MoBenhHocNhuomHe = DataReader["MoBenhHocNhuomHe"].ToString();
                    data.HoaMoMienDich = DataReader["HoaMoMienDich"].ToString();
                    data.HachViem = DataReader.GetInt("HachViem");
                    data.HachDiCan = DataReader.GetInt("HachDiCan");
                    data.HachDiCan_ViTri = DataReader["HachDiCan_ViTri"].ToString();
                    data.CacXetNghiemKhac = DataReader["CacXetNghiemKhac"].ToString();
                    data.ChanDoanXacDinh = DataReader["ChanDoanXacDinh"].ToString();
                    data.DieuTri = DataReader["DieuTri"].ToString();
                    data.HenKhamLai = DataReader["HenKhamLai"].ToString();

                    data.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                    data.NguoiTao = DataReader["NguoiTao"].ToString();
                    data.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);
                    data.NguoiSua = DataReader["NguoiSua"].ToString();

                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;
                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuTaiKhamUngThuHacTo ketQua)
        {
            try
            {
                string sql = @"INSERT INTO PhieuTaiKhamUngThuHacTo
                (
                    MAQUANLY,
                    MaBenhNhan,
                    NgayKham,
                    ToanThan,
                    CacBoPhan,
                    ThuongTonCoBan,
                    Mach,
                    NhietDo,
                    HuyetAp,
                    NhipTho,
                    CanNang,
                    ChieuCao,
                    BMI,
                    Hach,
                    Hach_ViTri,
                    BatThuongBoPhanKhac,
                    HC,
                    Hb,
                    BC,
                    Lympho,
                    TC,
                    NhomMau,
                    Glucose,
                    Ure,
                    Creatinin,
                    Cholesterol,
                    Triglycerid,
                    HDLC,
                    LDLC,
                    GOT,
                    GPT,
                    ProteinTP,
                    Albumin,
                    Na,
                    K,
                    Cl,
                    HinhAnhDermoscopy,
                    XQuang,
                    SieuAm,
                    ChanDoanHinhAnh_Khac,
                    MoBenhHocNhuomHe,
                    HoaMoMienDich,
                    HachViem,
                    HachDiCan,
                    HachDiCan_ViTri,
                    CacXetNghiemKhac,
                    ChanDoanXacDinh,
                    DieuTri,
                    HenKhamLai,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :NgayKham,
                    :ToanThan,
                    :CacBoPhan,
                    :ThuongTonCoBan,
                    :Mach,
                    :NhietDo,
                    :HuyetAp,
                    :NhipTho,
                    :CanNang,
                    :ChieuCao,
                    :BMI,
                    :Hach,
                    :Hach_ViTri,
                    :BatThuongBoPhanKhac,
                    :HC,
                    :Hb,
                    :BC,
                    :Lympho,
                    :TC,
                    :NhomMau,
                    :Glucose,
                    :Ure,
                    :Creatinin,
                    :Cholesterol,
                    :Triglycerid,
                    :HDLC,
                    :LDLC,
                    :GOT,
                    :GPT,
                    :ProteinTP,
                    :Albumin,
                    :Na,
                    :K,
                    :Cl,
                    :HinhAnhDermoscopy,
                    :XQuang,
                    :SieuAm,
                    :ChanDoanHinhAnh_Khac,
                    :MoBenhHocNhuomHe,
                    :HoaMoMienDich,
                    :HachViem,
                    :HachDiCan,
                    :HachDiCan_ViTri,
                    :CacXetNghiemKhac,
                    :ChanDoanXacDinh,
                    :DieuTri,
                    :HenKhamLai,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE PhieuTaiKhamUngThuHacTo SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    NgayKham=:NgayKham,
                    ToanThan=:ToanThan,
                    CacBoPhan=:CacBoPhan,
                    ThuongTonCoBan=:ThuongTonCoBan,
                    Mach=:Mach,
                    NhietDo=:NhietDo,
                    HuyetAp=:HuyetAp,
                    NhipTho=:NhipTho,
                    CanNang=:CanNang,
                    ChieuCao=:ChieuCao,
                    BMI=:BMI,
                    Hach=:Hach,
                    Hach_ViTri=:Hach_ViTri,
                    BatThuongBoPhanKhac=:BatThuongBoPhanKhac,
                    HC=:HC,
                    Hb=:Hb,
                    BC=:BC,
                    Lympho=:Lympho,
                    TC=:TC,
                    NhomMau=:NhomMau,
                    Glucose=:Glucose,
                    Ure=:Ure,
                    Creatinin=:Creatinin,
                    Cholesterol=:Cholesterol,
                    Triglycerid=:Triglycerid,
                    HDLC=:HDLC,
                    LDLC=:LDLC,
                    GOT=:GOT,
                    GPT=:GPT,
                    ProteinTP=:ProteinTP,
                    Albumin=:Albumin,
                    Na=:Na,
                    K=:K,
                    Cl=:Cl,
                    HinhAnhDermoscopy=:HinhAnhDermoscopy,
                    XQuang=:XQuang,
                    SieuAm=:SieuAm,
                    ChanDoanHinhAnh_Khac=:ChanDoanHinhAnh_Khac,
                    MoBenhHocNhuomHe=:MoBenhHocNhuomHe,
                    HoaMoMienDich=:HoaMoMienDich,
                    HachViem=:HachViem,
                    HachDiCan=:HachDiCan,
                    HachDiCan_ViTri=:HachDiCan_ViTri,
                    CacXetNghiemKhac=:CacXetNghiemKhac,
                    ChanDoanXacDinh=:ChanDoanXacDinh,
                    DieuTri=:DieuTri,
                    HenKhamLai=:HenKhamLai,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ketQua.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("NgayKham", ketQua.NgayKham));
                Command.Parameters.Add(new MDB.MDBParameter("ToanThan", ketQua.ToanThan));
                Command.Parameters.Add(new MDB.MDBParameter("CacBoPhan", ketQua.CacBoPhan));
                Command.Parameters.Add(new MDB.MDBParameter("ThuongTonCoBan", ketQua.ThuongTonCoBan));
                Command.Parameters.Add(new MDB.MDBParameter("Mach", ketQua.Mach));
                Command.Parameters.Add(new MDB.MDBParameter("NhietDo", ketQua.NhietDo));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetAp", ketQua.HuyetAp));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTho", ketQua.NhipTho));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang", ketQua.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("ChieuCao", ketQua.ChieuCao));
                Command.Parameters.Add(new MDB.MDBParameter("BMI", ketQua.BMI));
                Command.Parameters.Add(new MDB.MDBParameter("Hach", ketQua.Hach));
                Command.Parameters.Add(new MDB.MDBParameter("Hach_ViTri", ketQua.Hach_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("BatThuongBoPhanKhac", ketQua.BatThuongBoPhanKhac));
                Command.Parameters.Add(new MDB.MDBParameter("HC", ketQua.HC));
                Command.Parameters.Add(new MDB.MDBParameter("Hb", ketQua.Hb));
                Command.Parameters.Add(new MDB.MDBParameter("BC", ketQua.BC));
                Command.Parameters.Add(new MDB.MDBParameter("Lympho", ketQua.Lympho));
                Command.Parameters.Add(new MDB.MDBParameter("TC", ketQua.TC));
                Command.Parameters.Add(new MDB.MDBParameter("NhomMau", ketQua.NhomMau));
                Command.Parameters.Add(new MDB.MDBParameter("Glucose", ketQua.Glucose));
                Command.Parameters.Add(new MDB.MDBParameter("Ure", ketQua.Ure));
                Command.Parameters.Add(new MDB.MDBParameter("Creatinin", ketQua.Creatinin));
                Command.Parameters.Add(new MDB.MDBParameter("Cholesterol", ketQua.Cholesterol));
                Command.Parameters.Add(new MDB.MDBParameter("Triglycerid", ketQua.Triglycerid));
                Command.Parameters.Add(new MDB.MDBParameter("HDLC", ketQua.HDLC));
                Command.Parameters.Add(new MDB.MDBParameter("LDLC", ketQua.LDLC));
                Command.Parameters.Add(new MDB.MDBParameter("GOT", ketQua.GOT));
                Command.Parameters.Add(new MDB.MDBParameter("GPT", ketQua.GPT));
                Command.Parameters.Add(new MDB.MDBParameter("ProteinTP", ketQua.ProteinTP));
                Command.Parameters.Add(new MDB.MDBParameter("Albumin", ketQua.Albumin));
                Command.Parameters.Add(new MDB.MDBParameter("Na", ketQua.Na));
                Command.Parameters.Add(new MDB.MDBParameter("K", ketQua.K));
                Command.Parameters.Add(new MDB.MDBParameter("Cl", ketQua.Cl));
                Command.Parameters.Add(new MDB.MDBParameter("HinhAnhDermoscopy", ketQua.HinhAnhDermoscopy));
                Command.Parameters.Add(new MDB.MDBParameter("XQuang", ketQua.XQuang));
                Command.Parameters.Add(new MDB.MDBParameter("SieuAm", ketQua.SieuAm));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanHinhAnh_Khac", ketQua.ChanDoanHinhAnh_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("MoBenhHocNhuomHe", ketQua.MoBenhHocNhuomHe));
                Command.Parameters.Add(new MDB.MDBParameter("HoaMoMienDich", ketQua.HoaMoMienDich));
                Command.Parameters.Add(new MDB.MDBParameter("HachViem", ketQua.HachViem));
                Command.Parameters.Add(new MDB.MDBParameter("HachDiCan", ketQua.HachDiCan));
                Command.Parameters.Add(new MDB.MDBParameter("HachDiCan_ViTri", ketQua.HachDiCan_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("CacXetNghiemKhac", ketQua.CacXetNghiemKhac));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanXacDinh", ketQua.ChanDoanXacDinh));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri", ketQua.DieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("HenKhamLai", ketQua.HenKhamLai));

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
                string sql = "DELETE FROM PhieuTaiKhamUngThuHacTo WHERE ID = :ID";
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
                P.* 
            FROM
                PhieuTaiKhamUngThuHacTo P
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "KQ");
            return ds;
        }
    }
}
