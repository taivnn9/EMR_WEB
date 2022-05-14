using EMR.KyDienTu;
using MDB;
using Newtonsoft.Json;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class BBHCTTT : ThongTinKy
    {
        public BBHCTTT()
        {
            TableName = "BBHCTTT";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BBHCTTT;
            TenMauPhieu = DanhMucPhieu.BBHCTTT.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }
        [MoTaDuLieu("Tên khoa")]
		public string TenKhoa { get; set; }
        [MoTaDuLieu("Mã giường")]
		public string MaGiuong { get; set; }
        [MoTaDuLieu("Giường")]
		public string Giuong { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        [MoTaDuLieu("Ngày vào viện")]
        public DateTime? NgayVaoVien { get; set; }
        [MoTaDuLieu("Danh sách hội chẩn viên")]
        public ObservableCollection<NhanVien> lstHoiChanVien { get; set; }
        [MoTaDuLieu("Lý do vào viện")]
        public string LyDoVaoVien { get; set; }
        [MoTaDuLieu("Diễn biến bệnh")]
		public string DienBienBenh { get; set; }
        [MoTaDuLieu("Tiền sử")]
        public string TienSu { get; set; }
        [MoTaDuLieu("Toàn trạng")]
        public string ToanTrang { get; set; }
        [MoTaDuLieu("Mạch")]
		public string Mach { get; set; }
        [MoTaDuLieu("Nhiệt độ")]
        public string T { get; set; }
        [MoTaDuLieu("Huyết áp")]
		public string HA { get; set; }
        [MoTaDuLieu("Nhịp tim")]
		public string NT { get; set; }
        [MoTaDuLieu("Nhóm máu")]
		public string NhomMau { get; set; }
        [MoTaDuLieu("Hồng cầu")]
		public string HongCau { get; set; }
        [MoTaDuLieu("HGB")]
        public string HGB { get; set; }
        [MoTaDuLieu("HCT")]
        public string HCT { get; set; }
        [MoTaDuLieu("Bạch cầu")]
		public string BachCau { get; set; }
        [MoTaDuLieu("Neu %")]
        public string Neu { get; set; }
        [MoTaDuLieu("Lymph%")]
        public string Lymph { get; set; }
        [MoTaDuLieu("Tiểu cầu")]
		public string TieuCau { get; set; }
        [MoTaDuLieu("Glucose")]
        public string Glucose { get; set; }
        [MoTaDuLieu("Ure")]
        public string Ure { get; set; }
        [MoTaDuLieu("Creatinin")]
        public string Creatinin { get; set; }
        [MoTaDuLieu("GOT")]
        public string GOT { get; set; }
        [MoTaDuLieu("GPT")]
        public string GPT { get; set; }
        [MoTaDuLieu("Bilirubin TP")]
        public string Bilirubin { get; set; }
        [MoTaDuLieu("Protein")]
        public string Protein { get; set; }
        [MoTaDuLieu("Albumin")]
        public string Albumin { get; set; }
        [MoTaDuLieu("HIV")]
		public string HIV { get; set; }
        [MoTaDuLieu("Giang mai")]
		public string GiangMai { get; set; }
        [MoTaDuLieu("PT%")]
        public string PT { get; set; }
        [MoTaDuLieu("Fibrinogen")]
        public string Fibrinogen { get; set; }
        [MoTaDuLieu("APTT")]
        public string APTT { get; set; }
        [MoTaDuLieu("Na")]
        public string Na { get; set; }
        [MoTaDuLieu("K")]
        public string K { get; set; }
        [MoTaDuLieu("Cl")]
        public string Cl { get; set; }
        [MoTaDuLieu("HbsAg")]
        public string HbsAg { get; set; }
        [MoTaDuLieu("HPV")]
        public string HPV { get; set; }
        [MoTaDuLieu("Điện tim")]
        public string DienTim { get; set; }
        [MoTaDuLieu("Siêu âm tim")]
        public string SieuAmTim { get; set; }
        [MoTaDuLieu("Chụp tim phổi")]
        public string ChupTimPhoi { get; set; }
        [MoTaDuLieu("Siêu âm ổ bụng")]
        public string SieuAmOBung { get; set; }
        [MoTaDuLieu("Nước tiểu")]
		public string NuocTieu { get; set; }
        [MoTaDuLieu("Giải phẫu bệnh")]
        public string GiaiPhauBenh { get; set; }
        [MoTaDuLieu("Xét nghiệm khác")]
        public string XetNghiemKhac { get; set; }
        [MoTaDuLieu("Hội chẩn chuyên khoa")]
        public string HoiChanCK { get; set; }
        [MoTaDuLieu("Dự kiến phương pháp phẫu thuật")]
        public string DuKien { get; set; }
        [MoTaDuLieu("Phương pháp vô cảm")]
        public string PPVoCam { get; set; }
        [MoTaDuLieu("Mã người thực hiện thủ thuật")]
        public string MaNgTHTT { get; set; }
        [MoTaDuLieu("Họ tên người thực hiện thủ thuật")]
        public string TenNgTHTT { get; set; }
        [MoTaDuLieu("Ngày thực hiện thủ thuật")]
        public DateTime? NgayTH { get; set; }
        [MoTaDuLieu("Ý kiến chẩn đoán")]
        public string YKChanDoan { get; set; }
        [MoTaDuLieu("Phương pháp phẫu thuật")]
        public string CTThuThuat { get; set; }
        [MoTaDuLieu("Ý kiến vô cảm")]
        public string YKVoCam { get; set; }
        [MoTaDuLieu("Y kiến tiên lượng")]
        public string YKTienLuong { get; set; }
        [MoTaDuLieu("Mã lãnh đạo duyệt")]
        public string MaLanhDao { get; set; }
        [MoTaDuLieu("Họ tên lãnh đạo duyệt")]
        public string TenLanhDao { get; set; }
        [MoTaDuLieu("Mã trưởng khoa")]
		public string MaTruongKhoa { get; set; }
        [MoTaDuLieu("Họ tên trưởng khoa")]
        public string TenTruongKhoa { get; set; }
        [MoTaDuLieu("Mã bác sỹ phẩu thuật")]
        public string MaBacSyPT { get; set; }
        [MoTaDuLieu("Họ tên bác sỹ phẫu thuật")]
        public string TenBacSyPT { get; set; }
        [MoTaDuLieu("Mã bác sỹ điều trị")]
        public string MaBacSyDT { get; set; }
        [MoTaDuLieu("Họ tên bác sỹ điều trị")]
        public string TenBacSyDT { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }

        [MoTaDuLieu("Nhóm máu")]
        public string TagNhomMau { get; set; }
        [MoTaDuLieu("Hồng cầu")]
        public string TagHongCau { get; set; }
        [MoTaDuLieu("HGB")]
        public string TagHGB { get; set; }
        [MoTaDuLieu("HCT")]
        public string TagHCT { get; set; }
        [MoTaDuLieu("Bạch cầu")]
        public string TagBachCau { get; set; }
        [MoTaDuLieu("Neu%")]
        public string TagNeu { get; set; }
        [MoTaDuLieu("Lymph%")]
        public string TagLymph { get; set; }
        [MoTaDuLieu("Tiểu cầu")]
        public string TagTieuCau { get; set; }
        [MoTaDuLieu("Glucose")]
        public string TagGlucose { get; set; }
        [MoTaDuLieu("Ure")]
        public string TagUre { get; set; }
        [MoTaDuLieu("Creatinin")]
        public string TagCreatinin { get; set; }
        [MoTaDuLieu("GOT")]
        public string TagGOT { get; set; }
        [MoTaDuLieu("GPT")]
        public string TagGPT { get; set; }
        [MoTaDuLieu("Bilirubin")]
        public string TagBilirubin { get; set; }
        [MoTaDuLieu("Protein")]
        public string TagProtein { get; set; }
        [MoTaDuLieu("Albumin")]
        public string TagAlbumin { get; set; }
        [MoTaDuLieu("HIV")]
        public string TagHIV { get; set; }
        [MoTaDuLieu("Giang mai")]
        public string TagGiangMai { get; set; }
        [MoTaDuLieu("PT%")]
        public string TagPT { get; set; }
        [MoTaDuLieu("Fibrinogen")]
        public string TagFibrinogen { get; set; }
        [MoTaDuLieu("APTT")]
        public string TagAPTT { get; set; }
        [MoTaDuLieu("Na")]
        public string TagNa { get; set; }
        [MoTaDuLieu("K")]
        public string TagK { get; set; }
        [MoTaDuLieu("Cl")]
        public string TagCl { get; set; }
        [MoTaDuLieu("HbsAg")]
        public string TagHbsAg { get; set; }
        [MoTaDuLieu("HPV")]
        public string TagHPV { get; set; }
        [MoTaDuLieu("Điện tim")]
        public string TagDienTim { get; set; }
        [MoTaDuLieu("Siêu âm tim")]
        public string TagSieuAmTim { get; set; }
        [MoTaDuLieu("Chụp tim phổi")]
        public string TagChupTimPhoi { get; set; }
        [MoTaDuLieu("Siêu âm ổ bụng")]
        public string TagSieuAmOBung { get; set; }
        [MoTaDuLieu("Nước tiểu")]
        public string TagNuocTieu { get; set; }
        [MoTaDuLieu("Giải phẫu bệnh")]
        public string TagGiaiPhauBenh { get; set; }
        [MoTaDuLieu("Xét nghiệm khác")]
        public string TagXetNghiemKhac { get; set; }
        [MoTaDuLieu("Sở y tế")]
        public string SoYTe
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.SoYTe;
            }
        }
        [MoTaDuLieu("Bệnh viện")]
        public string BenhVien
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.BenhVien;
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
                return XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            }
        }
        [MoTaDuLieu("Số vào viện")]
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
        [MoTaDuLieu("Mã bệnh án")]
        public string MaBenhAn
        {
            get
            {
                return XemBenhAn._ThongTinDieuTri.MaBenhAn;
            }
        }
        [MoTaDuLieu("")]
        public string DienThoaiLienLac
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.DienThoaiLienLac;
            }
        }
    }
    public class BBHCTTTFunc
    {
        public const string TableName = "BBHCTTT";
        public const string TablePrimaryKeyName = "ID";
        public static List<BBHCTTT> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BBHCTTT> list = new List<BBHCTTT>();
            try
            {

                string sql = @"SELECT * FROM BBHCTTT where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    try
                    {
                        BBHCTTT data = new BBHCTTT();
                        data.ID = DataReader.GetLong("ID");
                        data.MaQuanLy = Common.ConDB_Decimal(DataReader["MaQuanLy"]);
                        data.MaBenhNhan = Common.ConDBNull(DataReader["MaBenhNhan"]);
                        data.MaKhoa = Common.ConDBNull(DataReader["MaKhoa"]);
                        data.TenKhoa = Common.ConDBNull(DataReader["TenKhoa"]);
                        data.MaGiuong = Common.ConDBNull(DataReader["MaGiuong"]);
                        data.Giuong = Common.ConDBNull(DataReader["Giuong"]);
                        data.ChanDoan = Common.ConDBNull(DataReader["ChanDoan"]);
                        data.DiaChi = Common.ConDBNull(DataReader["DiaChi"]);
                        data.NgayVaoVien = Common.ConDB_DateTimeNull(DataReader["NgayVaoVien"]);
                        data.lstHoiChanVien = JsonConvert.DeserializeObject<ObservableCollection<NhanVien>>(Common.ConDBNull(DataReader["lstHoiChanVien"]));
                        data.LyDoVaoVien = Common.ConDBNull(DataReader["LyDoVaoVien"]);
                        data.DienBienBenh = Common.ConDBNull(DataReader["DienBienBenh"]);
                        data.TienSu = Common.ConDBNull(DataReader["TienSu"]);
                        data.ToanTrang = Common.ConDBNull(DataReader["ToanTrang"]);
                        data.Mach = Common.ConDBNull(DataReader["Mach"]);
                        data.T = Common.ConDBNull(DataReader["T"]);
                        data.HA = Common.ConDBNull(DataReader["HA"]);
                        data.NT = Common.ConDBNull(DataReader["NT"]);
                        data.NhomMau = Common.ConDBNull(DataReader["NhomMau"]);
                        data.HongCau = Common.ConDBNull(DataReader["HongCau"]);
                        data.HGB = Common.ConDBNull(DataReader["HGB"]);
                        data.HCT = Common.ConDBNull(DataReader["HCT"]);
                        data.BachCau = Common.ConDBNull(DataReader["BachCau"]);
                        data.Neu = Common.ConDBNull(DataReader["Neu"]);
                        data.Lymph = Common.ConDBNull(DataReader["Lymph"]);
                        data.TieuCau = Common.ConDBNull(DataReader["TieuCau"]);
                        data.Glucose = Common.ConDBNull(DataReader["Glucose"]);
                        data.Ure = Common.ConDBNull(DataReader["Ure"]);
                        data.Creatinin = Common.ConDBNull(DataReader["Creatinin"]);
                        data.GOT = Common.ConDBNull(DataReader["GOT"]);
                        data.GPT = Common.ConDBNull(DataReader["GPT"]);
                        data.Bilirubin = Common.ConDBNull(DataReader["Bilirubin"]);
                        data.Protein = Common.ConDBNull(DataReader["Protein"]);
                        data.Albumin = Common.ConDBNull(DataReader["Albumin"]);
                        data.HIV = Common.ConDBNull(DataReader["HIV"]);
                        data.GiangMai = Common.ConDBNull(DataReader["GiangMai"]);
                        data.PT = Common.ConDBNull(DataReader["PT"]);
                        data.Fibrinogen = Common.ConDBNull(DataReader["Fibrinogen"]);
                        data.APTT = Common.ConDBNull(DataReader["APTT"]);
                        data.Na = Common.ConDBNull(DataReader["Na"]);
                        data.K = Common.ConDBNull(DataReader["K"]);
                        data.Cl = Common.ConDBNull(DataReader["Cl"]);
                        data.HbsAg = Common.ConDBNull(DataReader["HbsAg"]);
                        data.HPV = Common.ConDBNull(DataReader["HPV"]);
                        data.DienTim = Common.ConDBNull(DataReader["DienTim"]);
                        data.SieuAmTim = Common.ConDBNull(DataReader["SieuAmTim"]);
                        data.ChupTimPhoi = Common.ConDBNull(DataReader["ChupTimPhoi"]);
                        data.SieuAmOBung = Common.ConDBNull(DataReader["SieuAmOBung"]);
                        data.NuocTieu = Common.ConDBNull(DataReader["NuocTieu"]);
                        data.GiaiPhauBenh = Common.ConDBNull(DataReader["GiaiPhauBenh"]);
                        data.XetNghiemKhac = Common.ConDBNull(DataReader["XetNghiemKhac"]);
                        data.HoiChanCK = Common.ConDBNull(DataReader["HoiChanCK"]);
                        data.DuKien = Common.ConDBNull(DataReader["DuKien"]);
                        data.PPVoCam = Common.ConDBNull(DataReader["PPVoCam"]);
                        data.MaNgTHTT = Common.ConDBNull(DataReader["MaNgTHTT"]);
                        data.TenNgTHTT = Common.ConDBNull(DataReader["TenNgTHTT"]);
                        data.NgayTH = Common.ConDB_DateTimeNull(DataReader["NgayTH"]);
                        data.YKChanDoan = Common.ConDBNull(DataReader["YKChanDoan"]);
                        data.CTThuThuat = Common.ConDBNull(DataReader["CTThuThuat"]);
                        data.YKVoCam = Common.ConDBNull(DataReader["YKVoCam"]);
                        data.YKTienLuong = Common.ConDBNull(DataReader["YKTienLuong"]);
                        data.MaLanhDao = Common.ConDBNull(DataReader["MaLanhDao"]);
                        data.TenLanhDao = Common.ConDBNull(DataReader["TenLanhDao"]);
                        data.MaTruongKhoa = Common.ConDBNull(DataReader["MaTruongKhoa"]);
                        data.TenTruongKhoa = Common.ConDBNull(DataReader["TenTruongKhoa"]);
                        data.MaBacSyPT = Common.ConDBNull(DataReader["MaBacSyPT"]);
                        data.TenBacSyPT = Common.ConDBNull(DataReader["TenBacSyPT"]);
                        data.MaBacSyDT = Common.ConDBNull(DataReader["MaBacSyDT"]);
                        data.TenBacSyDT = Common.ConDBNull(DataReader["TenBacSyDT"]);
                        data.NguoiTao = Common.ConDBNull(DataReader["NguoiTao"]);
                        data.NguoiSua = Common.ConDBNull(DataReader["NguoiSua"]);
                        data.NgayTao = Common.ConDB_DateTime(DataReader["NgayTao"]);
                        data.NgaySua = Common.ConDB_DateTime(DataReader["NgaySua"]);
                        data.NgayKy = Common.ConDB_DateTime(DataReader["NGAYKY"]);
                        data.ComputerKyTen = Common.ConDBNull(DataReader["COMPUTERKYTEN"]);
                        data.MaSoKy = Common.ConDBNull(DataReader["MASOKYTEN"]);
                        data.TenFileKy = Common.ConDBNull(DataReader["TENFILEKY"]);
                        data.UserNameKy = Common.ConDBNull(DataReader["USERNAMEKY"]);
                        data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;
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
        public static bool InsertOrUpdate(MDB.MDBConnection _OracleConnection, ref BBHCTTT obj)
        {
            string sql;
            int n = 0;
            {
                int rowCountId = 0;
                int nId = 0;
                string sqlIdXetnghiem = @"SELECT * FROM MapIdxetnghiem WHERE ID = :ID";
                if (obj.TagNhomMau.IsNotNullOrEmpty())//1
                {
                    MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                    CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)EMR_MAIN.CLS_PTTT.NhomMau));
                    MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                    rowCountId = 0;
                    while (DataReaderIdxetnghiem.Read()) rowCountId++;
                    if (rowCountId == 0)
                    {
                        sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, IDLOAI) VALUES(" + (int)EMR_MAIN.CLS_PTTT.NhomMau + "," + obj.TagNhomMau.ToInt32() + ", 0)";
                        CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                        nId = CommandIDxetnghiem.ExecuteNonQuery();
                    }
                }
                if (obj.TagHongCau.IsNotNullOrEmpty())//2
                {
                    MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                    CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)EMR_MAIN.CLS_PTTT.CongThucMauHongCau));
                    MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                    rowCountId = 0;
                    while (DataReaderIdxetnghiem.Read()) rowCountId++;
                    if (rowCountId == 0)
                    {
                        sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, IDLOAI) VALUES(" + (int)EMR_MAIN.CLS_PTTT.CongThucMauHongCau + "," + obj.TagHongCau.ToInt32() + ", 0)";
                        CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                        nId = CommandIDxetnghiem.ExecuteNonQuery();
                    }
                }
                if (obj.TagHGB.IsNotNullOrEmpty())//3
                {
                    MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                    CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)(EMR_MAIN.CLS_PTTT.HGB)));
                    MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                    rowCountId = 0;
                    while (DataReaderIdxetnghiem.Read()) rowCountId++;
                    if (rowCountId == 0)
                    {
                        sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, IDLOAI) VALUES(" + (int)(EMR_MAIN.CLS_PTTT.HGB) + "," + obj.TagHGB.ToInt32() + ", 0)";
                        CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                        nId = CommandIDxetnghiem.ExecuteNonQuery();
                    }
                }
                if (obj.TagHCT.IsNotNullOrEmpty())//4
                {
                    MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                    CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)(EMR_MAIN.CLS_PTTT.HCT )));
                    MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                    rowCountId = 0;
                    while (DataReaderIdxetnghiem.Read()) rowCountId++;
                    if (rowCountId == 0)
                    {
                        sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, IDLOAI) VALUES(" + (int)(EMR_MAIN.CLS_PTTT.HCT) + "," + obj.TagHCT.ToInt32() + ", 0)";
                        CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                        nId = CommandIDxetnghiem.ExecuteNonQuery();
                    }
                }
                if (obj.TagBachCau.IsNotNullOrEmpty())//5
                {
                    MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                    CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)(EMR_MAIN.CLS_PTTT.CongThucMauBachcau)));
                    MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                    rowCountId = 0;
                    while (DataReaderIdxetnghiem.Read()) rowCountId++;
                    if (rowCountId == 0)
                    {
                        sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, IDLOAI) VALUES(" + (int)(EMR_MAIN.CLS_PTTT.CongThucMauBachcau) + "," + obj.TagBachCau.ToInt32() + ", 0)";
                        CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                        nId = CommandIDxetnghiem.ExecuteNonQuery();
                    }
                }
                if (obj.TagNeu.IsNotNullOrEmpty())//6
                {
                    MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                    CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)EMR_MAIN.CLS_PTTT.Neu));
                    MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                    rowCountId = 0;
                    while (DataReaderIdxetnghiem.Read()) rowCountId++;
                    if (rowCountId == 0)
                    {
                        sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, IDLOAI) VALUES(" + (int)(EMR_MAIN.CLS_PTTT.Neu) + "," + obj.TagNeu.ToInt32() + ", 0)";
                        CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                        nId = CommandIDxetnghiem.ExecuteNonQuery();
                    }
                }
                if (obj.TagLymph.IsNotNullOrEmpty())//7
                {
                    MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                    CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)EMR_MAIN.CLS_PTTT.Lymph));
                    MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                    rowCountId = 0;
                    while (DataReaderIdxetnghiem.Read()) rowCountId++;
                    if (rowCountId == 0)
                    {
                        sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, IDLOAI) VALUES(" + (int)(EMR_MAIN.CLS_PTTT.Lymph) + "," + obj.TagLymph.ToInt32() + ", 0)";
                        CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                        nId = CommandIDxetnghiem.ExecuteNonQuery();
                    }
                }
                if (obj.TagTieuCau.IsNotNullOrEmpty())//8
                {
                    MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                    CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)(EMR_MAIN.CLS_PTTT.TieuCau)));
                    MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                    rowCountId = 0;
                    while (DataReaderIdxetnghiem.Read()) rowCountId++;
                    if (rowCountId == 0)
                    {
                        sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, IDLOAI) VALUES(" + (int)(EMR_MAIN.CLS_PTTT.TieuCau ) + "," + obj.TagTieuCau.ToInt32() + ", 0)";
                        CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                        nId = CommandIDxetnghiem.ExecuteNonQuery();
                    }
                }
                if (obj.TagGlucose.IsNotNullOrEmpty())//9
                {
                    MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                    CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)(EMR_MAIN.CLS_PTTT.Glucose)));
                    MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                    rowCountId = 0;
                    while (DataReaderIdxetnghiem.Read()) rowCountId++;
                    if (rowCountId == 0)
                    {
                        sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, IDLOAI) VALUES(" + (int)(EMR_MAIN.CLS_PTTT.Glucose ) + "," + obj.TagGlucose.ToInt32() + ", 0)";
                        CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                        nId = CommandIDxetnghiem.ExecuteNonQuery();
                    }
                }

                if (obj.TagUre.IsNotNullOrEmpty())//10
                {
                    MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                    CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)(EMR_MAIN.CLS_PTTT.SinhHoaUre)));
                    MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                    rowCountId = 0;
                    while (DataReaderIdxetnghiem.Read()) rowCountId++;
                    if (rowCountId == 0)
                    {
                        sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, IDLOAI) VALUES(" + (int)(EMR_MAIN.CLS_PTTT.SinhHoaUre) + "," + obj.TagUre.ToInt32() + ", 0)";
                        CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                        nId = CommandIDxetnghiem.ExecuteNonQuery();
                    }
                }
                if (obj.TagCreatinin.IsNotNullOrEmpty())//11
                {
                    MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                    CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)(EMR_MAIN.CLS_PTTT.Creatimin)));
                    MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                    rowCountId = 0;
                    while (DataReaderIdxetnghiem.Read()) rowCountId++;
                    if (rowCountId == 0)
                    {
                        sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, IDLOAI) VALUES(" + (int)(EMR_MAIN.CLS_PTTT.Creatimin) + "," + obj.TagCreatinin.ToInt32() + ", 0)";
                        CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                        nId = CommandIDxetnghiem.ExecuteNonQuery();
                    }
                }
                if (obj.TagGOT.IsNotNullOrEmpty())//12
                {
                    MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                    CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)(EMR_MAIN.CLS_PTTT.Got)));
                    MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                    rowCountId = 0;
                    while (DataReaderIdxetnghiem.Read()) rowCountId++;
                    if (rowCountId == 0)
                    {
                        sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, IDLOAI) VALUES(" + (int)(EMR_MAIN.CLS_PTTT.Got) + "," + obj.TagGOT.ToInt32() + ", 0)";
                        CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                        nId = CommandIDxetnghiem.ExecuteNonQuery();
                    }
                }
                if (obj.TagGPT.IsNotNullOrEmpty())//13
                {
                    MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                    CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)(EMR_MAIN.CLS_PTTT.Gpt)));
                    MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                    rowCountId = 0;
                    while (DataReaderIdxetnghiem.Read()) rowCountId++;
                    if (rowCountId == 0)
                    {
                        sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, IDLOAI) VALUES(" + (int)(EMR_MAIN.CLS_PTTT.Gpt) + "," + obj.TagGPT.ToInt32() + ", 0)";
                        CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                        nId = CommandIDxetnghiem.ExecuteNonQuery();
                    }
                }
                if (obj.TagBilirubin.IsNotNullOrEmpty())//14
                {
                    MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                    CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)(EMR_MAIN.CLS_PTTT.BilirubinTP)));
                    MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                    rowCountId = 0;
                    while (DataReaderIdxetnghiem.Read()) rowCountId++;
                    if (rowCountId == 0)
                    {
                        sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, IDLOAI) VALUES(" + (int)(EMR_MAIN.CLS_PTTT.BilirubinTP) + "," + obj.TagBilirubin.ToInt32() + ", 0)";
                        CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                        nId = CommandIDxetnghiem.ExecuteNonQuery();
                    }
                }

                if (obj.TagProtein.IsNotNullOrEmpty())//15
                {
                    MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                    CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)(EMR_MAIN.CLS_PTTT.ProteinTP)));
                    MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                    rowCountId = 0;
                    while (DataReaderIdxetnghiem.Read()) rowCountId++;
                    if (rowCountId == 0)
                    {
                        sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, IDLOAI) VALUES(" + (int)(EMR_MAIN.CLS_PTTT.ProteinTP) + "," + obj.TagProtein.ToInt32() + ", 0)";
                        CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                        nId = CommandIDxetnghiem.ExecuteNonQuery();
                    }
                }

                if (obj.TagAlbumin.IsNotNullOrEmpty())//16
                {
                    MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                    CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)(EMR_MAIN.CLS_PTTT.Albumin)));
                    MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                    rowCountId = 0;
                    while (DataReaderIdxetnghiem.Read()) rowCountId++;
                    if (rowCountId == 0)
                    {
                        sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, IDLOAI) VALUES(" + (int)(EMR_MAIN.CLS_PTTT.Albumin) + "," + obj.TagAlbumin.ToInt32() + ", 0)";
                        CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                        nId = CommandIDxetnghiem.ExecuteNonQuery();
                    }
                }

                if (obj.TagHIV.IsNotNullOrEmpty())//17
                {
                    MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                    CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)(EMR_MAIN.CLS_PTTT.XetNghiemHIV)));
                    MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                    rowCountId = 0;
                    while (DataReaderIdxetnghiem.Read()) rowCountId++;
                    if (rowCountId == 0)
                    {
                        sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, IDLOAI) VALUES(" + (int)(EMR_MAIN.CLS_PTTT.XetNghiemHIV) + "," + obj.TagHIV.ToInt32() + ", 0)";
                        CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                        nId = CommandIDxetnghiem.ExecuteNonQuery();
                    }
                }

                if (obj.TagGiangMai.IsNotNullOrEmpty())//18
                {
                    MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                    CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)(EMR_MAIN.CLS_PTTT.GiangMai)));
                    MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                    rowCountId = 0;
                    while (DataReaderIdxetnghiem.Read()) rowCountId++;
                    if (rowCountId == 0)
                    {
                        sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, IDLOAI) VALUES(" + (int)(EMR_MAIN.CLS_PTTT.GiangMai) + "," + obj.TagGiangMai.ToInt32() + ", 0)";
                        CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                        nId = CommandIDxetnghiem.ExecuteNonQuery();
                    }
                }
                if (obj.TagPT.IsNotNullOrEmpty())//19
                {
                    MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                    CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)(EMR_MAIN.CLS_PTTT.PT )));
                    MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                    rowCountId = 0;
                    while (DataReaderIdxetnghiem.Read()) rowCountId++;
                    if (rowCountId == 0)
                    {
                        sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, IDLOAI) VALUES(" + (int)(EMR_MAIN.CLS_PTTT.PT) + "," + obj.TagPT.ToInt32() + ", 0)";
                        CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                        nId = CommandIDxetnghiem.ExecuteNonQuery();
                    }
                }

                if (obj.TagFibrinogen.IsNotNullOrEmpty())//20
                {
                    MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                    CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)(EMR_MAIN.CLS_PTTT.Fibrinogen)));
                    MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                    rowCountId = 0;
                    while (DataReaderIdxetnghiem.Read()) rowCountId++;
                    if (rowCountId == 0)
                    {
                        sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, IDLOAI) VALUES(" + (int)(EMR_MAIN.CLS_PTTT.Fibrinogen) + "," + obj.TagFibrinogen.ToInt32() + ", 0)";
                        CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                        nId = CommandIDxetnghiem.ExecuteNonQuery();
                    }
                }

                if (obj.TagAPTT.IsNotNullOrEmpty())//21
                {
                    MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                    CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)(EMR_MAIN.CLS_PTTT.Aptt)));
                    MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                    rowCountId = 0;
                    while (DataReaderIdxetnghiem.Read()) rowCountId++;
                    if (rowCountId == 0)
                    {
                        sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, IDLOAI) VALUES(" + (int)(EMR_MAIN.CLS_PTTT.Aptt) + "," + obj.TagAPTT.ToInt32() + ", 0)";
                        CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                        nId = CommandIDxetnghiem.ExecuteNonQuery();
                    }
                }
                if (obj.TagNa.IsNotNullOrEmpty())//22
                {
                    MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                    CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)(EMR_MAIN.CLS_PTTT.Na )));
                    MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                    rowCountId = 0;
                    while (DataReaderIdxetnghiem.Read()) rowCountId++;
                    if (rowCountId == 0)
                    {
                        sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, IDLOAI) VALUES(" + (int)(EMR_MAIN.CLS_PTTT.Na ) + "," + obj.TagNa.ToInt32() + ", 0)";
                        CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                        nId = CommandIDxetnghiem.ExecuteNonQuery();
                    }
                }

                if (obj.TagK.IsNotNullOrEmpty())//23
                {
                    MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                    CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)(EMR_MAIN.CLS_PTTT.K )));
                    MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                    rowCountId = 0;
                    while (DataReaderIdxetnghiem.Read()) rowCountId++;
                    if (rowCountId == 0)
                    {
                        sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, IDLOAI) VALUES(" + (int)(EMR_MAIN.CLS_PTTT.K) + "," + obj.TagK.ToInt32() + ", 0)";
                        CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                        nId = CommandIDxetnghiem.ExecuteNonQuery();
                    }
                }

                if (obj.TagCl.IsNotNullOrEmpty())//24
                {
                    MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                    CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)(EMR_MAIN.CLS_PTTT.Cl )));
                    MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                    rowCountId = 0;
                    while (DataReaderIdxetnghiem.Read()) rowCountId++;
                    if (rowCountId == 0)
                    {
                        sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, IDLOAI) VALUES(" + (int)(EMR_MAIN.CLS_PTTT.Cl) + "," + obj.TagCl.ToInt32() + ", 0)";
                        CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                        nId = CommandIDxetnghiem.ExecuteNonQuery();
                    }
                }
                if (obj.TagHbsAg.IsNotNullOrEmpty())//25
                {
                    MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                    CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)(EMR_MAIN.CLS_PTTT.HbsAg)));
                    MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                    rowCountId = 0;
                    while (DataReaderIdxetnghiem.Read()) rowCountId++;
                    if (rowCountId == 0)
                    {
                        sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, IDLOAI) VALUES(" + (int)(EMR_MAIN.CLS_PTTT.HbsAg) + "," + obj.TagHbsAg.ToInt32() + ", 0)";
                        CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                        nId = CommandIDxetnghiem.ExecuteNonQuery();
                    }
                }

                if (obj.TagHPV.IsNotNullOrEmpty())//26
                {
                    MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                    CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)(EMR_MAIN.CLS_PTTT.HPV)));
                    MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                    rowCountId = 0;
                    while (DataReaderIdxetnghiem.Read()) rowCountId++;
                    if (rowCountId == 0)
                    {
                        sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, IDLOAI) VALUES(" + (int)(EMR_MAIN.CLS_PTTT.HPV) + "," + obj.TagHPV.ToInt32() + ", 0)";
                        CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                        nId = CommandIDxetnghiem.ExecuteNonQuery();
                    }
                }

                if (obj.TagDienTim.IsNotNullOrEmpty())//27
                {
                    MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                    CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)(EMR_MAIN.CLS_PTTT.DienTim)));
                    MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                    rowCountId = 0;
                    while (DataReaderIdxetnghiem.Read()) rowCountId++;
                    if (rowCountId == 0)
                    {
                        sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, IDLOAI) VALUES(" + (int)(EMR_MAIN.CLS_PTTT.DienTim) + "," + obj.TagDienTim.ToInt32() + ", 0)";
                        CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                        nId = CommandIDxetnghiem.ExecuteNonQuery();
                    }
                }
                if (obj.TagSieuAmTim.IsNotNullOrEmpty())//28
                {
                    MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                    CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)(EMR_MAIN.CLS_PTTT.SieuAmTim)));
                    MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                    rowCountId = 0;
                    while (DataReaderIdxetnghiem.Read()) rowCountId++;
                    if (rowCountId == 0)
                    {
                        sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, IDLOAI) VALUES(" + (int)(EMR_MAIN.CLS_PTTT.SieuAmTim) + "," + obj.TagSieuAmTim.ToInt32() + ", 0)";
                        CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                        nId = CommandIDxetnghiem.ExecuteNonQuery();
                    }
                }

                if (obj.TagChupTimPhoi.IsNotNullOrEmpty())//29
                {
                    MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                    CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)(EMR_MAIN.CLS_PTTT.ChupTimPhoi )));
                    MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                    rowCountId = 0;
                    while (DataReaderIdxetnghiem.Read()) rowCountId++;
                    if (rowCountId == 0)
                    {
                        sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, IDLOAI) VALUES(" + (int)(EMR_MAIN.CLS_PTTT.ChupTimPhoi) + "," + obj.TagChupTimPhoi.ToInt32() + ", 0)";
                        CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                        nId = CommandIDxetnghiem.ExecuteNonQuery();
                    }
                }

                if (obj.TagSieuAmOBung.IsNotNullOrEmpty())//30
                {
                    MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                    CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)(EMR_MAIN.CLS_PTTT.SieuAmOBung )));
                    MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                    rowCountId = 0;
                    while (DataReaderIdxetnghiem.Read()) rowCountId++;
                    if (rowCountId == 0)
                    {
                        sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, IDLOAI) VALUES(" + (int)(EMR_MAIN.CLS_PTTT.SieuAmOBung) + "," + obj.TagSieuAmOBung.ToInt32() + ", 0)";
                        CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                        nId = CommandIDxetnghiem.ExecuteNonQuery();
                    }
                }
                if (obj.TagNuocTieu.IsNotNullOrEmpty())//31
                {
                    MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                    CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)(EMR_MAIN.CLS_PTTT.NuocTieuDuongNieu)));
                    MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                    rowCountId = 0;
                    while (DataReaderIdxetnghiem.Read()) rowCountId++;
                    if (rowCountId == 0)
                    {
                        sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, IDLOAI) VALUES(" + (int)(EMR_MAIN.CLS_PTTT.NuocTieuDuongNieu) + "," + obj.TagNuocTieu.ToInt32() + ", 0)";
                        CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                        nId = CommandIDxetnghiem.ExecuteNonQuery();
                    }
                }
                if (obj.TagGiaiPhauBenh.IsNotNullOrEmpty())//32
                {
                    MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                    CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)(EMR_MAIN.CLS_PTTT.GiaiPhauBenh)));
                    MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                    rowCountId = 0;
                    while (DataReaderIdxetnghiem.Read()) rowCountId++;
                    if (rowCountId == 0)
                    {
                        sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, IDLOAI) VALUES(" + (int)(EMR_MAIN.CLS_PTTT.GiaiPhauBenh) + "," + obj.TagGiaiPhauBenh.ToInt32() + ", 0)";
                        CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                        nId = CommandIDxetnghiem.ExecuteNonQuery();
                    }
                }
                if (obj.TagXetNghiemKhac.IsNotNullOrEmpty())//33
                {
                    MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                    CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)(EMR_MAIN.CLS_PTTT.XetNghiemKhac)));
                    MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                    rowCountId = 0;
                    while (DataReaderIdxetnghiem.Read()) rowCountId++;
                    if (rowCountId == 0)
                    {
                        sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, IDLOAI) VALUES(" + (int)(EMR_MAIN.CLS_PTTT.XetNghiemKhac) + "," + obj.TagXetNghiemKhac.ToInt32() + ", 0)";
                        CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                        nId = CommandIDxetnghiem.ExecuteNonQuery();
                    }
                }
            }
            if (obj.ID == 0)
            {
                sql = @"INSERT INTO BBHCTTT (
                MaQuanLy,
                MaBenhNhan,
                MaKhoa,
                TenKhoa,
                MaGiuong,
                Giuong,
                ChanDoan,
                DiaChi,
                NgayVaoVien,
                lstHoiChanVien,
                LyDoVaoVien,
                DienBienBenh,
                TienSu,
                ToanTrang,
                Mach,
                T,
                HA,
                NT,
                NhomMau,
                HongCau,
                HGB,
                HCT,
                BachCau,
                Neu,
                Lymph,
                TieuCau,
                Glucose,
                Ure,
                Creatinin,
                GOT,
                GPT,
                Bilirubin,
                Protein,
                Albumin,
                HIV,
                GiangMai,
                PT,
                Fibrinogen,
                APTT,
                Na,
                K,
                Cl,
                HbsAg,
                HPV,
                DienTim,
                SieuAmTim,
                ChupTimPhoi,
                SieuAmOBung,
                NuocTieu,
                GiaiPhauBenh,
                XetNghiemKhac,
                HoiChanCK,
                DuKien,
                PPVoCam,
                MaNgTHTT,
                TenNgTHTT,
                NgayTH,
                YKChanDoan,
                CTThuThuat,
                YKVoCam,
                YKTienLuong,
                MaLanhDao,
                TenLanhDao,
                MaTruongKhoa,
                TenTruongKhoa,
                MaBacSyPT,
                TenBacSyPT,
                MaBacSyDT,
                TenBacSyDT,
                NgayTao,
                NguoiTao,
                NgaySua,
                NguoiSua
            ) VALUES (
                :MaQuanLy,
                :MaBenhNhan,
                :MaKhoa,
                :TenKhoa,
                :MaGiuong,
                :Giuong,
                :ChanDoan,
                :DiaChi,
                :NgayVaoVien,
                :lstHoiChanVien,
                :LyDoVaoVien,
                :DienBienBenh,
                :TienSu,
                :ToanTrang,
                :Mach,
                :T,
                :HA,
                :NT,
                :NhomMau,
                :HongCau,
                :HGB,
                :HCT,
                :BachCau,
                :Neu,
                :Lymph,
                :TieuCau,
                :Glucose,
                :Ure,
                :Creatinin,
                :GOT,
                :GPT,
                :Bilirubin,
                :Protein,
                :Albumin,
                :HIV,
                :GiangMai,
                :PT,
                :Fibrinogen,
                :APTT,
                :Na,
                :K,
                :Cl,
                :HbsAg,
                :HPV,
                :DienTim,
                :SieuAmTim,
                :ChupTimPhoi,
                :SieuAmOBung,
                :NuocTieu,
                :GiaiPhauBenh,
                :XetNghiemKhac,
                :HoiChanCK,
                :DuKien,
                :PPVoCam,
                :MaNgTHTT,
                :TenNgTHTT,
                :NgayTH,
                :YKChanDoan,
                :CTThuThuat,
                :YKVoCam,
                :YKTienLuong,
                :MaLanhDao,
                :TenLanhDao,
                :MaTruongKhoa,
                :TenTruongKhoa,
                :MaBacSyPT,
                :TenBacSyPT,
                :MaBacSyDT,
                :TenBacSyDT,
                :NgayTao,
                :NguoiTao,
                :NgaySua,
                :NguoiSua
            ) RETURNING ID INTO :ID";
            }

            else
            {
                sql = @"UPDATE BBHCTTT SET  
                MaQuanLy=:MaQuanLy,
                MaBenhNhan=:MaBenhNhan,
                MaKhoa=:MaKhoa,
                TenKhoa=:TenKhoa,
                MaGiuong=:MaGiuong,
                Giuong=:Giuong,
                ChanDoan=:ChanDoan,
                DiaChi=:DiaChi,
                NgayVaoVien=:NgayVaoVien,
                lstHoiChanVien=:lstHoiChanVien,
                LyDoVaoVien=:LyDoVaoVien,
                DienBienBenh=:DienBienBenh,
                TienSu=:TienSu,
                ToanTrang=:ToanTrang,
                Mach=:Mach,
                T=:T,
                HA=:HA,
                NT=:NT,
                NhomMau=:NhomMau,
                HongCau=:HongCau,
                HGB=:HGB,
                HCT=:HCT,
                BachCau=:BachCau,
                Neu=:Neu,
                Lymph=:Lymph,
                TieuCau=:TieuCau,
                Glucose=:Glucose,
                Ure=:Ure,
                Creatinin=:Creatinin,
                GOT=:GOT,
                GPT=:GPT,
                Bilirubin=:Bilirubin,
                Protein=:Protein,
                Albumin=:Albumin,
                HIV=:HIV,
                GiangMai=:GiangMai,
                PT=:PT,
                Fibrinogen=:Fibrinogen,
                APTT=:APTT,
                Na=:Na,
                K=:K,
                Cl=:Cl,
                HbsAg=:HbsAg,
                HPV=:HPV,
                DienTim=:DienTim,
                SieuAmTim=:SieuAmTim,
                ChupTimPhoi=:ChupTimPhoi,
                SieuAmOBung=:SieuAmOBung,
                NuocTieu=:NuocTieu,
                GiaiPhauBenh=:GiaiPhauBenh,
                XetNghiemKhac=:XetNghiemKhac,
                HoiChanCK=:HoiChanCK,
                DuKien=:DuKien,
                PPVoCam=:PPVoCam,
                MaNgTHTT=:MaNgTHTT,
                TenNgTHTT=:TenNgTHTT,
                NgayTH=:NgayTH,
                YKChanDoan=:YKChanDoan,
                CTThuThuat=:CTThuThuat,
                YKVoCam=:YKVoCam,
                YKTienLuong=:YKTienLuong,
                MaLanhDao=:MaLanhDao,
                TenLanhDao=:TenLanhDao,
                MaTruongKhoa=:MaTruongKhoa,
                TenTruongKhoa=:TenTruongKhoa,
                MaBacSyPT=:MaBacSyPT,
                TenBacSyPT=:TenBacSyPT,
                MaBacSyDT=:MaBacSyDT,
                TenBacSyDT=:TenBacSyDT,
                nguoisua = :nguoisua,
                ngaysua = :ngaysua 
            WHERE ID = :ID";

            }

            MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, _OracleConnection);
            oracleCommand.Parameters.Add(new MDB.MDBParameter("MaQuanLy", obj.MaQuanLy));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", obj.MaBenhNhan));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("MaKhoa", obj.MaKhoa));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("TenKhoa", obj.TenKhoa));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("MaGiuong", obj.MaGiuong));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("Giuong", obj.Giuong));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("ChanDoan", obj.ChanDoan));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("DiaChi", obj.DiaChi));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayVaoVien", obj.NgayVaoVien));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("lstHoiChanVien", JsonConvert.SerializeObject(obj.lstHoiChanVien)));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("LyDoVaoVien", obj.LyDoVaoVien));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("DienBienBenh", obj.DienBienBenh));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("TienSu", obj.TienSu));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("ToanTrang", obj.ToanTrang));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("Mach", obj.Mach));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("T", obj.T));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("HA", obj.HA));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("NT", obj.NT));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("NhomMau", obj.NhomMau));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("HongCau", obj.HongCau));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("HGB", obj.HGB));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("HCT", obj.HCT));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("BachCau", obj.BachCau));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("Neu", obj.Neu));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("Lymph", obj.Lymph));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("TieuCau", obj.TieuCau));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("Glucose", obj.Glucose));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("Ure", obj.Ure));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("Creatinin", obj.Creatinin));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("GOT", obj.GOT));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("GPT", obj.GPT));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("Bilirubin", obj.Bilirubin));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("Protein", obj.Protein));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("Albumin", obj.Albumin));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("HIV", obj.HIV));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("GiangMai", obj.GiangMai));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("PT", obj.PT));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("Fibrinogen", obj.Fibrinogen));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("APTT", obj.APTT));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("Na", obj.Na));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("K", obj.K));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("Cl", obj.Cl));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("HbsAg", obj.HbsAg));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("HPV", obj.HPV));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("DienTim", obj.DienTim));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("SieuAmTim", obj.SieuAmTim));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("ChupTimPhoi", obj.ChupTimPhoi));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("SieuAmOBung", obj.SieuAmOBung));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("NuocTieu", obj.NuocTieu));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("GiaiPhauBenh", obj.GiaiPhauBenh));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("XetNghiemKhac", obj.XetNghiemKhac));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("HoiChanCK", obj.HoiChanCK));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("DuKien", obj.DuKien));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("PPVoCam", obj.PPVoCam));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("MaNgTHTT", obj.MaNgTHTT));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("TenNgTHTT", obj.TenNgTHTT));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayTH", obj.NgayTH));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("YKChanDoan", obj.YKChanDoan));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("CTThuThuat", obj.CTThuThuat));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("YKVoCam", obj.YKVoCam));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("YKTienLuong", obj.YKTienLuong));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("MaLanhDao", obj.MaLanhDao));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("TenLanhDao", obj.TenLanhDao));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("MaTruongKhoa", obj.MaTruongKhoa));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("TenTruongKhoa", obj.TenTruongKhoa));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBacSyPT", obj.MaBacSyPT));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("TenBacSyPT", obj.TenBacSyPT));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBacSyDT", obj.MaBacSyDT));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("TenBacSyDT", obj.TenBacSyDT));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("nguoisua", Common.getUserLogin()));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("ngaysua", DateTime.Now));
            oracleCommand.Parameters.Add(new MDB.MDBParameter("ID", obj.ID));
            if (obj.ID == 0)
            {
                oracleCommand.Parameters.Add(new MDB.MDBParameter("nguoitao", Common.getUserLogin()));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ngaytao", DateTime.Now));
            }
            oracleCommand.BindByName = true;
            n = oracleCommand.ExecuteNonQuery();
            if (n > 0)
            {
                if (obj.ID == 0)
                {
                    long nextval = Convert.ToInt64((oracleCommand.Parameters["ID"] as MDB.MDBParameter).Value);
                    obj.ID = nextval;
                }
            }
            return n > 0 ? true : false;
        }

        public static bool Delete(MDB.MDBConnection MyConnection, decimal ID)
        {
            string sql = "DELETE FROM BBHCTTT WHERE ID = :ID";
            MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
            command.Parameters.Add(new MDB.MDBParameter("ID", ID));
            command.BindByName = true;
            int n = command.ExecuteNonQuery();
            return n > 0 ? true : false;
        }
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, decimal ID)
        {
            string sql2 = @"SELECT D.*, '' SoNhapVien, '' MaBenhAn , '' SoVaoVien,'' TenBenhNhan,
                        '' TUOI, '' SoYTe, '' BENHVIEN, '' DienThoaiLienLac,
                        '' GioiTinh
            FROM
                BBHCTTT D
            WHERE
                ID = :ID";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql2, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("ID", ID));

            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            adt.Fill(ds);
            if (ds != null || ds.Tables[0].Rows.Count > 0)
            {
                ds.Tables[0].Rows[0]["SoNhapVien"] = XemBenhAn._ThongTinDieuTri.SoNhapVien;
                ds.Tables[0].Rows[0]["MaBenhAn"] = XemBenhAn._ThongTinDieuTri.MaBenhAn;
                ds.Tables[0].Rows[0]["SoVaoVien"] = XemBenhAn._ThongTinDieuTri.SoNhapVien;
                ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                ds.Tables[0].Rows[0]["TUOI"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                ds.Tables[0].Rows[0]["SoYTe"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
                ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
                ds.Tables[0].Rows[0]["DienThoaiLienLac"] = XemBenhAn._HanhChinhBenhNhan.DienThoaiLienLac;
                ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            }
            return ds;
        }
    }
}
