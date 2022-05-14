using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMR_MAIN.DATABASE.Other
{
    public class BangKiemAnToanPhauThuatNew : ThongTinKy
    {
        public BangKiemAnToanPhauThuatNew()
        {
            TableName = "BangKiemAnToanPhauThuatNew";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.GDKBPDV;
            TenMauPhieu = DanhMucPhieu.GDKBPDV.Description();
        }
        // Phần chung
        [MoTaDuLieu("Mã định danh")]
        public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau", "", 1)]
        public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
        public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
        public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
        public string NguoiTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
        public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
        public string NguoiSua { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
        public bool DaKy { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
        public bool Chon { get; set; }
        // End Phần chung 

        public string SoYTe { get; set; }
        public string BenhVien { get; set; }
        public string SoVaoVien { get; set; }
        public int PhauThuatCoKeHoach { get; set; }
        public int PhauThuatCapCuu { get; set; }
        [MoTaDuLieu("Họ tên NB")]
        public string HoVaTen { get; set; }
        [MoTaDuLieu("Sinh năm")]
        public DateTime? SinhNam { get; set; }
        [MoTaDuLieu("Giới")]
        public string Gioi { get; set; }
        [MoTaDuLieu("Chuẩn đoán")]
        public string ChuanDoan { get; set; }
        [MoTaDuLieu("Phương pháp PT")]
        public string PhuongPhapPT { get; set; }
        [MoTaDuLieu("Phương pháp vô cảm")]
        public string PhuongPhapVoCam { get; set; }
        //Truoc khi gây mê/ vô cảm
        public DateTime TimeTruocGayMeVoCam { get; set; }
        public int NguoiBenhDaDongYPhauThuat { get; set; }
        public int VungMoDuocDanhDau { get; set; }
        public int ThuocVaThietBiDaKiemTra { get; set; }
        public int MayDoDoBaoHoa { get; set; }
        public int TienSuDiUng { get; set; }
        public int DuongThoKho { get; set; }
        public int NguyCoMatMau { get; set; }
        //End Truoc khi gây me

        //Truoc khi rach da
        public DateTime TimeTruocKhiRachDa { get; set; }
        // Xac nhan thong tin
        public int XacNhanThongTinCacThanhVienPhauThuat { get; set; }
        public int XacNhanThongTinXacNhanLaiTenNB { get; set; }
        public int KhangSinhDuPhong { get; set; }
        public int DuKienNhungBatThuong { get; set; }
        public string ThoiGianChoCaPhauThuat { get; set; }
        public int TienLuongMatMau { get; set; }
        public int VanDeCanChuY { get; set; }
        public int DungCuPhuongTienDamBao { get; set; }
        public int ChatLuongThietBi { get; set; }
        public string NoteChatLuongThietBi { get; set; }
        //End truoc khi rach da

        // Truoc khi NB rời phòng phẫu thuật
        public DateTime TimeTruocKhiRoiPhongPhauThuat { get; set; }
        public int HoanTatViecDemKim { get; set; }
        public int VanDeGiVeDungCu { get; set; }
        // ktv thực hiện trước khi chuyển NB
        public int KTVDanNhanBenhPham { get; set; }
        public int KTVDamBaoAnToan { get; set; }
        public int NhungVanDeChinhVeHoiSuc { get; set; }
        public string NoteNhungVanDeChinhVeHoiSuc { get; set; }
        // End Trước khi NB rời phòng phẫu thuật
        public string MaPTV { get; set; }
        public string TenPTV { get; set; }
        public string MaBSPTVGayMe { get; set; }
        public string TenBSPTVGayMe { get; set; }
        public string MaKTVDungCu { get; set; }
        public string TenKTVDungCu { get; set; }
        // de hien thi
    }

    public class BangKiemAnToanPhauThuatNewFunc
    {
        public const string TableName = "BangKiemAnToanPhauThuatNewFunc";
        public const string TablePrimaryKeyName = "ID";
        public static List<BangKiemAnToanPhauThuatNew> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BangKiemAnToanPhauThuatNew> list = new List<BangKiemAnToanPhauThuatNew>();
            try
            {
                string sql = @"SELECT * FROM BangKiemAnToanPhauThuatNew where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    BangKiemAnToanPhauThuatNew data = new BangKiemAnToanPhauThuatNew();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();


                    data.SoYTe = DataReader["SoYTe"].ToString();
                    data.BenhVien = DataReader["BenhVien"].ToString();
                    data.SoVaoVien = DataReader["SoVaoVien"].ToString();
                    data.PhauThuatCoKeHoach = DataReader.GetInt("PhauThuatCoKeHoach");
                    data.PhauThuatCapCuu = DataReader.GetInt("PhauThuatCapCuu");
                    data.HoVaTen = DataReader["HoVaTen"].ToString();
                    data.SinhNam = Convert.ToDateTime(DataReader["SinhNam"] == DBNull.Value ? DateTime.Now : DataReader["SinhNam"]);
                    data.Gioi = DataReader["Gioi"].ToString();
                    data.ChuanDoan = DataReader["ChuanDoan"].ToString();
                    data.PhuongPhapPT = DataReader["PhuongPhapPT"].ToString();
                    data.PhuongPhapVoCam = DataReader["PhuongPhapVoCam"].ToString();
                    // Truoc khi gay me
                    data.TimeTruocGayMeVoCam = Convert.ToDateTime(DataReader["TimeTruocGayMeVoCam"] == DBNull.Value ? DateTime.Now : DataReader["TimeTruocGayMeVoCam"]);
                    data.NguoiBenhDaDongYPhauThuat = DataReader.GetInt("NguoiBenhDaDongYPhauThuat");
                    data.VungMoDuocDanhDau = DataReader.GetInt("VungMoDuocDanhDau");
                    data.ThuocVaThietBiDaKiemTra = DataReader.GetInt("ThuocVaThietBiDaKiemTra");
                    data.MayDoDoBaoHoa = DataReader.GetInt("MayDoDoBaoHoa");
                    data.TienSuDiUng = DataReader.GetInt("TienSuDiUng");
                    data.DuongThoKho = DataReader.GetInt("DuongThoKho");
                    data.NguyCoMatMau = DataReader.GetInt("NguyCoMatMau");

                    // Truoc khi rach da
                    data.TimeTruocKhiRachDa = Convert.ToDateTime(DataReader["TimeTruocKhiRachDa"] == DBNull.Value ? DateTime.Now : DataReader["TimeTruocKhiRachDa"]);
                    data.XacNhanThongTinCacThanhVienPhauThuat = DataReader.GetInt("XacNhanThongTinCacThanhVienPhauThuat");
                    data.XacNhanThongTinXacNhanLaiTenNB = DataReader.GetInt("XacNhanThongTinXacNhanLaiTenNB");
                    data.KhangSinhDuPhong = DataReader.GetInt("KhangSinhDuPhong");
                    data.DuKienNhungBatThuong = DataReader.GetInt("DuKienNhungBatThuong");
                    data.ThoiGianChoCaPhauThuat = DataReader["ThoiGianChoCaPhauThuat"].ToString();
                    data.TienLuongMatMau = DataReader.GetInt("TienLuongMatMau");
                    data.VanDeCanChuY = DataReader.GetInt("VanDeCanChuY");
                    data.DungCuPhuongTienDamBao = DataReader.GetInt("DungCuPhuongTienDamBao");
                    data.ChatLuongThietBi = DataReader.GetInt("ChatLuongThietBi");
                    data.NoteChatLuongThietBi = DataReader["NoteChatLuongThietBi"].ToString();


                    // Truoc khi NB rời phòng phẫu thuật
                    data.TimeTruocKhiRoiPhongPhauThuat = Convert.ToDateTime(DataReader["TimeTruocKhiRoiPhongPhauThuat"] == DBNull.Value ? DateTime.Now : DataReader["TimeTruocKhiRoiPhongPhauThuat"]);
                    data.HoanTatViecDemKim = DataReader.GetInt("HoanTatViecDemKim");
                    data.VanDeGiVeDungCu = DataReader.GetInt("VanDeGiVeDungCu");
                    data.KTVDanNhanBenhPham = DataReader.GetInt("KTVDanNhanBenhPham");
                    data.KTVDamBaoAnToan = DataReader.GetInt("KTVDamBaoAnToan");
                    data.NhungVanDeChinhVeHoiSuc = DataReader.GetInt("NhungVanDeChinhVeHoiSuc");
                    data.NoteNhungVanDeChinhVeHoiSuc = DataReader["NoteNhungVanDeChinhVeHoiSuc"].ToString();

                    data.MaPTV = DataReader["MaPTV"].ToString();
                    data.TenPTV = DataReader["TenPTV"].ToString();
                    data.MaBSPTVGayMe = DataReader["MaBSPTVGayMe"].ToString();
                    data.TenBSPTVGayMe = DataReader["TenBSPTVGayMe"].ToString();
                    data.MaKTVDungCu = DataReader["MaKTVDungCu"].ToString();
                    data.TenKTVDungCu = DataReader["TenKTVDungCu"].ToString();


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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BangKiemAnToanPhauThuatNew ketQua)
        {
            try
            {
                string sql = @"INSERT INTO BangKiemAnToanPhauThuatNew
                (
                    MAQUANLY,
                    MaBenhNhan,

                    SoYTe,
                    BenhVien,
                    SoVaoVien,
                    PhauThuatCoKeHoach,
                    PhauThuatCapCuu,
                    HoVaTen,
                    SinhNam,
                    Gioi,
                    ChuanDoan,
                    PhuongPhapPT,
                    PhuongPhapVoCam,
                    
                    TimeTruocGayMeVoCam,
                    NguoiBenhDaDongYPhauThuat,
                    VungMoDuocDanhDau,
                    ThuocVaThietBiDaKiemTra,
                    MayDoDoBaoHoa,
                    TienSuDiUng,
                    DuongThoKho,
                    NguyCoMatMau,

				    TimeTruocKhiRachDa, 
				    XacNhanThongTinCacThanhVienPhauThuat,
				    XacNhanThongTinXacNhanLaiTenNB,
				    KhangSinhDuPhong, 
				    DuKienNhungBatThuong, 
				    ThoiGianChoCaPhauThuat, 
				    TienLuongMatMau, 
				    VanDeCanChuY, 
				    DungCuPhuongTienDamBao, 
				    ChatLuongThietBi,
				    NoteChatLuongThietBi, 


	                TimeTruocKhiRoiPhongPhauThuat,
	                HoanTatViecDemKim, 
                    VanDeGiVeDungCu, 
                    KTVDanNhanBenhPham, 
                    KTVDamBaoAnToan, 
                    NhungVanDeChinhVeHoiSuc, 
                    NoteNhungVanDeChinhVeHoiSuc,

					MaPTV, 
                    TenPTV, 
                    MaBSPTVGayMe, 
                    TenBSPTVGayMe, 
                    MaKTVDungCu, 
                    TenKTVDungCu,


                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,

                    :SoYTe,
                    :BenhVien,
                    :SoVaoVien,
                    :PhauThuatCoKeHoach,
                    :PhauThuatCapCuu,
                    :HoVaTen,
                    :SinhNam,
                    :Gioi,
                    :ChuanDoan,
                    :PhuongPhapPT,
                    :PhuongPhapVoCam,
                    
                    :TimeTruocGayMeVoCam,
                    :NguoiBenhDaDongYPhauThuat,
                    :VungMoDuocDanhDau,
                    :ThuocVaThietBiDaKiemTra,
                    :MayDoDoBaoHoa,
                    :TienSuDiUng,
                    :DuongThoKho,
                    :NguyCoMatMau,
					
				    :TimeTruocKhiRachDa, 
				    :XacNhanThongTinCacThanhVienPhauThuat,
				    :XacNhanThongTinXacNhanLaiTenNB,
				    :KhangSinhDuPhong, 
				    :DuKienNhungBatThuong, 
				    :ThoiGianChoCaPhauThuat, 
				    :TienLuongMatMau, 
				    :VanDeCanChuY, 
				    :DungCuPhuongTienDamBao, 
				    :ChatLuongThietBi,
				    :NoteChatLuongThietBi, 
					
					
	                :TimeTruocKhiRoiPhongPhauThuat,
	                :HoanTatViecDemKim, 
                    :VanDeGiVeDungCu, 
                    :KTVDanNhanBenhPham, 
                    :KTVDamBaoAnToan, 
                    :NhungVanDeChinhVeHoiSuc, 
                    :NoteNhungVanDeChinhVeHoiSuc,
					
					:MaPTV, 
                    :TenPTV, 
                    :MaBSPTVGayMe, 
                    :TenBSPTVGayMe, 
                    :MaKTVDungCu, 
                    :TenKTVDungCu,

                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE BangKiemAnToanPhauThuatNew SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    
					SoYTe=:SoYTe,
                    BenhVien=:BenhVien,
                    SoVaoVien=:SoVaoVien,
                    PhauThuatCoKeHoach=:PhauThuatCoKeHoach,
                    PhauThuatCapCuu=:PhauThuatCapCuu,
                    HoVaTen=:HoVaTen,
                    SinhNam=:SinhNam,
                    Gioi=:Gioi,
                    ChuanDoan=:ChuanDoan,
                    PhuongPhapPT=:PhuongPhapPT,
                    PhuongPhapVoCam=:PhuongPhapVoCam,
                    
                    TimeTruocGayMeVoCam=:TimeTruocGayMeVoCam,
                    NguoiBenhDaDongYPhauThuat=:NguoiBenhDaDongYPhauThuat,
                    VungMoDuocDanhDau=:VungMoDuocDanhDau,
                    ThuocVaThietBiDaKiemTra=:ThuocVaThietBiDaKiemTra,
                    MayDoDoBaoHoa=:MayDoDoBaoHoa,
                    TienSuDiUng=:TienSuDiUng,
                    DuongThoKho=:DuongThoKho,
                    NguyCoMatMau=:NguyCoMatMau,
					
				    TimeTruocKhiRachDa= :TimeTruocKhiRachDa, 
				    XacNhanThongTinCacThanhVienPhauThuat=:XacNhanThongTinCacThanhVienPhauThuat,
				    XacNhanThongTinXacNhanLaiTenNB=:XacNhanThongTinXacNhanLaiTenNB,
				    KhangSinhDuPhong= :KhangSinhDuPhong, 
				    DuKienNhungBatThuong= :DuKienNhungBatThuong, 
				    ThoiGianChoCaPhauThuat=:ThoiGianChoCaPhauThuat, 
				    TienLuongMatMau= :TienLuongMatMau, 
				    VanDeCanChuY= :VanDeCanChuY, 
				    DungCuPhuongTienDamBao=:DungCuPhuongTienDamBao, 
				    ChatLuongThietBi=:ChatLuongThietBi,
				    NoteChatLuongThietBi= :NoteChatLuongThietBi, 
					
					
	                TimeTruocKhiRoiPhongPhauThuat=:TimeTruocKhiRoiPhongPhauThuat,
	                HoanTatViecDemKim= :HoanTatViecDemKim, 
                    VanDeGiVeDungCu= :VanDeGiVeDungCu, 
                    KTVDanNhanBenhPham= :KTVDanNhanBenhPham, 
                    KTVDamBaoAnToan= :KTVDamBaoAnToan, 
                    NhungVanDeChinhVeHoiSuc=:NhungVanDeChinhVeHoiSuc, 
                    NoteNhungVanDeChinhVeHoiSuc=:NoteNhungVanDeChinhVeHoiSuc,
					
					MaPTV= :MaPTV, 
                    TenPTV= :TenPTV, 
                    MaBSPTVGayMe= :MaBSPTVGayMe, 
                    TenBSPTVGayMe= :TenBSPTVGayMe, 
                    MaKTVDungCu= :MaKTVDungCu, 
                    TenKTVDungCu=:TenKTVDungCu,


                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ketQua.MaBenhNhan));


                Command.Parameters.Add(new MDB.MDBParameter("SoYTe", ketQua.SoYTe));
                Command.Parameters.Add(new MDB.MDBParameter("BenhVien", ketQua.BenhVien));
                Command.Parameters.Add(new MDB.MDBParameter("SoVaoVien", ketQua.SoVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("PhauThuatCoKeHoach", ketQua.PhauThuatCoKeHoach));
                Command.Parameters.Add(new MDB.MDBParameter("PhauThuatCapCuu", ketQua.PhauThuatCapCuu));
                Command.Parameters.Add(new MDB.MDBParameter("HoVaTen", ketQua.HoVaTen));
                Command.Parameters.Add(new MDB.MDBParameter("SinhNam", ketQua.SinhNam));
                Command.Parameters.Add(new MDB.MDBParameter("Gioi", ketQua.Gioi));
                Command.Parameters.Add(new MDB.MDBParameter("ChuanDoan", ketQua.ChuanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapPT", ketQua.PhuongPhapPT));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapVoCam", ketQua.PhuongPhapVoCam));

                // truoc khi gay me vo cam
                Command.Parameters.Add(new MDB.MDBParameter("TimeTruocGayMeVoCam", ketQua.TimeTruocGayMeVoCam));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiBenhDaDongYPhauThuat", ketQua.NguoiBenhDaDongYPhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("VungMoDuocDanhDau", ketQua.VungMoDuocDanhDau));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocVaThietBiDaKiemTra", ketQua.ThuocVaThietBiDaKiemTra));
                Command.Parameters.Add(new MDB.MDBParameter("MayDoDoBaoHoa", ketQua.MayDoDoBaoHoa));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuDiUng", ketQua.TienSuDiUng));
                Command.Parameters.Add(new MDB.MDBParameter("DuongThoKho", ketQua.DuongThoKho));
                Command.Parameters.Add(new MDB.MDBParameter("NguyCoMatMau", ketQua.NguyCoMatMau));

                // Truoc khi rach da 
                Command.Parameters.Add(new MDB.MDBParameter("TimeTruocKhiRachDa", ketQua.TimeTruocKhiRachDa));
                Command.Parameters.Add(new MDB.MDBParameter("XacNhanThongTinCacThanhVienPhauThuat", ketQua.XacNhanThongTinCacThanhVienPhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("XacNhanThongTinXacNhanLaiTenNB", ketQua.XacNhanThongTinXacNhanLaiTenNB));
                Command.Parameters.Add(new MDB.MDBParameter("KhangSinhDuPhong", ketQua.KhangSinhDuPhong));
                Command.Parameters.Add(new MDB.MDBParameter("DuKienNhungBatThuong", ketQua.DuKienNhungBatThuong));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianChoCaPhauThuat", ketQua.ThoiGianChoCaPhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("TienLuongMatMau", ketQua.TienLuongMatMau));
                Command.Parameters.Add(new MDB.MDBParameter("VanDeCanChuY", ketQua.VanDeCanChuY));
                Command.Parameters.Add(new MDB.MDBParameter("DungCuPhuongTienDamBao", ketQua.DungCuPhuongTienDamBao));
                Command.Parameters.Add(new MDB.MDBParameter("ChatLuongThietBi", ketQua.ChatLuongThietBi));
                Command.Parameters.Add(new MDB.MDBParameter("NoteChatLuongThietBi", ketQua.NoteChatLuongThietBi));

                // truoc khi roi phong phau thuat
                Command.Parameters.Add(new MDB.MDBParameter("TimeTruocKhiRoiPhongPhauThuat", ketQua.TimeTruocKhiRoiPhongPhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("HoanTatViecDemKim", ketQua.HoanTatViecDemKim));
                Command.Parameters.Add(new MDB.MDBParameter("VanDeGiVeDungCu", ketQua.VanDeGiVeDungCu));
                Command.Parameters.Add(new MDB.MDBParameter("KTVDanNhanBenhPham", ketQua.KTVDanNhanBenhPham));
                Command.Parameters.Add(new MDB.MDBParameter("KTVDamBaoAnToan", ketQua.KTVDamBaoAnToan));
                Command.Parameters.Add(new MDB.MDBParameter("NhungVanDeChinhVeHoiSuc", ketQua.NhungVanDeChinhVeHoiSuc));
                Command.Parameters.Add(new MDB.MDBParameter("NoteNhungVanDeChinhVeHoiSuc", ketQua.NoteNhungVanDeChinhVeHoiSuc));

                Command.Parameters.Add(new MDB.MDBParameter("MaPTV", ketQua.MaPTV));
                var TenPTV = getTen(MyConnection, ketQua.MaPTV);
                Command.Parameters.Add(new MDB.MDBParameter("TenPTV", TenPTV));

                Command.Parameters.Add(new MDB.MDBParameter("MaBSPTVGayMe", ketQua.MaBSPTVGayMe));
                var TenBSPTVGayMe = getTen(MyConnection, ketQua.MaBSPTVGayMe);
                Command.Parameters.Add(new MDB.MDBParameter("TenBSPTVGayMe", TenBSPTVGayMe));

                Command.Parameters.Add(new MDB.MDBParameter("MaKTVDungCu", ketQua.MaKTVDungCu));
                var TenKTVDungCu = getTen(MyConnection, ketQua.MaKTVDungCu);
                Command.Parameters.Add(new MDB.MDBParameter("TenKTVDungCu", TenKTVDungCu));


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
        public static string getTen(MDB.MDBConnection MyConnection, string maNhanVien)
        {
            try
            {
                var result = "";
                string sql = "Select HoVaTen From  NhanVien WHERE MaNhanVien = :maNhanVien";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                command.Parameters.Add(new MDB.MDBParameter("maNhanVien", maNhanVien));
                command.BindByName = true;
                MDB.MDBDataReader DataReader = command.ExecuteReader();
                while (DataReader.Read())
                {
                    result = DataReader["HoVaTen"].ToString();
                }
                return result;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return "";
        }
        public static bool delete(MDB.MDBConnection MyConnection, long id)
        {
            try
            {
                string sql = "DELETE FROM BangKiemAnToanPhauThuatNew WHERE ID = :ID";
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
                BangKiemAnToanPhauThuatNew P
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
