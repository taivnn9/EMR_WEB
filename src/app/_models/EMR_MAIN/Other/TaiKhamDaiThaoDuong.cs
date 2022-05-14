using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class TaiKhamDaiThaoDuong : ThongTinKy
    {
        public TaiKhamDaiThaoDuong()
        {
            TableName = "TaiKhamDaiThaoDuong";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.TKDTD;
            TenMauPhieu = DanhMucPhieu.TKDTD.Description();
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
        [MoTaDuLieu("Tái khám lần")]
        public int? TaiKhamLan { get; set; }
        public DateTime? NgayTaiKham { get; set; }
        // D. Khám lâm sàng
        // 1. Toàn thân

        [MoTaDuLieu("Chiều cao")]
        public string ChieuCao { get; set; }
        [MoTaDuLieu("Cân nặng")]
        public string CanNang { get; set; }
        [MoTaDuLieu("BMT")]
        public string BMT { get; set; }
        [MoTaDuLieu("Vòng eo")]
        public string VongEo { get; set; }
        [MoTaDuLieu("Vòng hông")]
        public string VongHong { get; set; }
        [MoTaDuLieu("Chỉ số eo/hông")]
        public string ChiSoEoHong { get; set; }
        //2. Triệu chứng cơ năng
        [MoTaDuLieu("Khát, uống nhiều")]
        public int KhatUongNhieu { get; set; }
        [MoTaDuLieu("Khát, uống nhiều, số lượng")]
        public string KhatUongNhieu_SL { get; set; }
        [MoTaDuLieu("Tiểu nhiều")]
        public int TieuNhieu { get; set; }
        [MoTaDuLieu("Tiểu nhiều, số lượng")]
        public string TieuNhieu_SL { get; set; }
        [MoTaDuLieu("Mệt mỏi")]
        public int MetMoi { get; set; }
        [MoTaDuLieu("Sụt cân")]
        public int SutCan { get; set; }
        [MoTaDuLieu("Đau ngực")]
        public int DauNguc { get; set; }
        [MoTaDuLieu("Đau cánh hồi")]
        public int DauCanhHoi { get; set; }
        [MoTaDuLieu("Tê bì chân tay")]
        public int TeBiChanTay { get; set; }
        [MoTaDuLieu("Mắt nhìn mở")]
        public int MatNhinMo { get; set; }
        [MoTaDuLieu("Triệu chứng khác")]
        public string TrieuChungKhac { get; set; }
        // 3. khám bộ phận
        // Mắt
        [MoTaDuLieu("Thị lực mắt phải")]
        public string ThiLuc_MP { get; set; }
        [MoTaDuLieu("Thị lực mắt trái")]
        public string ThiLuc_MT { get; set; }
        [MoTaDuLieu("Tổn thương mắt phải")]
        public string TonThuong_MP { get; set; }
        [MoTaDuLieu("Tổn thương mắt trái")]
        public string TonThuong_MT { get; set; }
        [MoTaDuLieu("Da, niêm mạc")]
        public string DaNiemMac { get; set; }
        [MoTaDuLieu("Phù, 1-> có, 2-> không")]
        public int Phu { get; set; }
        [MoTaDuLieu("Phù, vị trí")]
        public string Phu_ViTri { get; set; }
        [MoTaDuLieu("Tình trạng răng lợi")]
        public string TinhTrangRangLoi { get; set; }
        // Tĩm mạch
        //Tư thế nằm
        [MoTaDuLieu("Nhịp tim, Tư thế nằm")]
        public string NhipTim_TuTheNam { get; set; }
        [MoTaDuLieu("Huyết áp, Tư thế nằm")]
        public string HA_TuTheNam { get; set; }
        //Tư thế đứng
        [MoTaDuLieu("Nhịp tim, Tư thế đứng")]
        public string NhipTim_TuTheDung { get; set; }
        [MoTaDuLieu("Huyết áp, Tư thế đứng")]
        public string HA_TuTheDung { get; set; }
        [MoTaDuLieu("Mạch ngoại biên: giảm, mất mạch, 1 -> không, 2 -> có")]
        public int MachNgoaiBien { get; set; }
        [MoTaDuLieu("Mạch ngoại biên: giảm, mất mạch, vị trí")]
        public string MachNgoaiBien_ViTri { get; set; }
        [MoTaDuLieu("Tiếng phổi ĐM lớn ngoại biên, 1-> không, 2 -> có")]
        public int TiengPhoiDM { get; set; }
        [MoTaDuLieu("Tiếng phổi ĐM lớn ngoại biên, vị trí")]
        public string TiengPhoiDM_ViTri { get; set; }
        // Thần kinh
        [MoTaDuLieu("BLTK vận động, 1-> không, 2 -> có")]
        public int BLTK_VanDong { get; set; }
        [MoTaDuLieu("BLTK vận động, ghi rõ")]
        public string BLTK_VanDong_GhiRo { get; set; }
        [MoTaDuLieu("BLTK cảm giác, 1-> không, 2 -> có")]
        public int BLTK_CamGiac { get; set; }
        [MoTaDuLieu("BLTK cảm giác, ghi rõ")]
        public string BLTK_CamGiac_GhiRo { get; set; }
        [MoTaDuLieu("BLTK tự chủ, 1-> không, 2 -> có")]
        public int BLTK_TuChu { get; set; }
        [MoTaDuLieu("BLTK tự chủ, ghi rõ")]
        public string BLTK_TuChu_GhiRo { get; set; }
        [MoTaDuLieu("Các bộ phận khác")]
        public string CacBoPhanKhac { get; set; }
        // E. Cận lâm sàng
        //1. Mau
        [MoTaDuLieu("Đường máu (đói)")]
        public string DuongMau_Doi { get; set; }
        [MoTaDuLieu("Đường máu sau ăn 2 giờ")]
        public string DuongMau_SauAn { get; set; }
        [MoTaDuLieu("HbAlc")]
        public string HbAlc { get; set; }
        [MoTaDuLieu("Insulin")]
        public string Mau_Insulin { get; set; }
        [MoTaDuLieu("Creatimin")]
        public string Creatimin { get; set; }
        [MoTaDuLieu("Acrid Uric")]
        public string Acrid_Uric { get; set; }
        [MoTaDuLieu("Lipid CT")]
        public string Lipid_CT { get; set; }
        [MoTaDuLieu("Lipid TG")]
        public string Lipid_TG { get; set; }
        [MoTaDuLieu("Lipid HDL")]
        public string Lipid_HDL { get; set; }
        [MoTaDuLieu("Lipid LDL")]
        public string Lipid_LDL { get; set; }
        [MoTaDuLieu("Lipid GOT")]
        public string GOT { get; set; }
        [MoTaDuLieu("Lipid GPT")]
        public string GPT { get; set; }
        [MoTaDuLieu("Protein")]
        public string Protein { get; set; }
        [MoTaDuLieu("Albumin")]
        public string Albumin { get; set; }
        [MoTaDuLieu("CTM HC")]
        public string CTM_HC { get; set; }
        [MoTaDuLieu("CTM Hb")]
        public string CTM_Hb { get; set; }
        [MoTaDuLieu("CTM Ht")]
        public string CTM_Ht { get; set; }
        [MoTaDuLieu("CTM BC")]
        public string CTM_BC { get; set; }
        [MoTaDuLieu("CTM TC")]
        public string CTM_TC { get; set; }

        // nước tiểu
        [MoTaDuLieu("Nước tiểu, protein")]
        public string NuocTieu_Protein { get; set; }
        [MoTaDuLieu("Nước tiểu, đường")]
        public string NuocTieu_Duong { get; set; }
        [MoTaDuLieu("Nước tiểu, Cetol")]
        public string NuocTieu_Cetol { get; set; }
        [MoTaDuLieu("Điện tâm đồ")]
        public string DienTamDo { get; set; }
        [MoTaDuLieu("Siêu âm tim")]
        public string SieuAmTim { get; set; }
        [MoTaDuLieu("SA Doppler Mạch")]
        public string SADopplerMach { get; set; }
        [MoTaDuLieu("Xq tim phổi")]
        public string XqTimPhoi { get; set; }
        [MoTaDuLieu("Chẩn đoán")]
        public string ChanDoan { get; set; }
        [MoTaDuLieu("Thể đái tháo đường, 1 -> type 1, 2-> type 2, 3 -> type khác")]
        public int TheDTD { get; set; }
        [MoTaDuLieu("Type 1")]
        public string Type1_Text { get; set; }
        [MoTaDuLieu("Type 2")]
        public string Type2_Text { get; set; }
        [MoTaDuLieu("Type khác")]
        public string Type_Khac { get; set; }
        [MoTaDuLieu("Biến chứng")]
        public string BienChung { get; set; }
        [MoTaDuLieu("Bệnh phối hợp")]
        public string BenhPhoiHop { get; set; }
        [MoTaDuLieu("Điều trị")]
        public string DieuTri { get; set; }
        [MoTaDuLieu("Lý do thêm, thay đổi thuốc")]
        public string LyDoThemThayThuoc { get; set; }
        [MoTaDuLieu("Ngày hẹn khám lại")]
        public DateTime? HenKhamLai { get; set; }
        [MoTaDuLieu("Ngày hẹn XN lại")]
        public DateTime? HenXNLai { get; set; }
        [MoTaDuLieu("Bác sỹ điều trị")]
        public string BacSyDieuTri { get; set; }
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
    public class TaiKhamDaiThaoDuongFunc
    {
        public const string TableName = "TaiKhamDaiThaoDuong";
        public const string TablePrimaryKeyName = "ID";
        public static List<TaiKhamDaiThaoDuong> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<TaiKhamDaiThaoDuong> list = new List<TaiKhamDaiThaoDuong>();
            try
            {
                string sql = @"SELECT * FROM TaiKhamDaiThaoDuong where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    TaiKhamDaiThaoDuong data = new TaiKhamDaiThaoDuong();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.HoTenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.TaiKhamLan = DataReader.GetInt("TaiKhamLan");
                    data.NgayTaiKham = DataReader["NgayTaiKham"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["NgayTaiKham"]) : null;
                    data.ChieuCao = DataReader["ChieuCao"].ToString();
                    data.CanNang = DataReader["CanNang"].ToString();
                    data.BMT = DataReader["BMT"].ToString();
                    data.VongEo = DataReader["VongEo"].ToString();
                    data.VongHong = DataReader["VongHong"].ToString();
                    data.ChiSoEoHong = DataReader["ChiSoEoHong"].ToString();
                    data.KhatUongNhieu = DataReader.GetInt("KhatUongNhieu");
                    data.KhatUongNhieu_SL = DataReader["KhatUongNhieu_SL"].ToString();
                    data.TieuNhieu = DataReader.GetInt("TieuNhieu");
                    data.TieuNhieu_SL = DataReader["TieuNhieu_SL"].ToString();
                    data.MetMoi = DataReader.GetInt("MetMoi");
                    data.SutCan = DataReader.GetInt("SutCan");
                    data.DauNguc = DataReader.GetInt("DauNguc");
                    data.DauCanhHoi = DataReader.GetInt("DauCanhHoi");
                    data.TeBiChanTay = DataReader.GetInt("TeBiChanTay");
                    data.MatNhinMo = DataReader.GetInt("MatNhinMo");
                    data.TrieuChungKhac = DataReader["TrieuChungKhac"].ToString();
                    data.ThiLuc_MP = DataReader["ThiLuc_MP"].ToString();
                    data.ThiLuc_MT = DataReader["ThiLuc_MT"].ToString();
                    data.TonThuong_MP = DataReader["TonThuong_MP"].ToString();
                    data.TonThuong_MT = DataReader["TonThuong_MT"].ToString();
                    data.DaNiemMac = DataReader["DaNiemMac"].ToString();
                    data.Phu = DataReader.GetInt("Phu");
                    data.Phu_ViTri = DataReader["Phu_ViTri"].ToString();
                    data.TinhTrangRangLoi = DataReader["TinhTrangRangLoi"].ToString();
                    data.NhipTim_TuTheNam = DataReader["NhipTim_TuTheNam"].ToString();
                    data.HA_TuTheNam = DataReader["HA_TuTheNam"].ToString();
                    data.NhipTim_TuTheDung = DataReader["NhipTim_TuTheDung"].ToString();
                    data.HA_TuTheDung = DataReader["HA_TuTheDung"].ToString();
                    data.MachNgoaiBien = DataReader.GetInt("MachNgoaiBien");
                    data.MachNgoaiBien_ViTri = DataReader["MachNgoaiBien_ViTri"].ToString();
                    data.TiengPhoiDM = DataReader.GetInt("TiengPhoiDM");
                    data.TiengPhoiDM_ViTri = DataReader["TiengPhoiDM_ViTri"].ToString();
                    data.BLTK_VanDong = DataReader.GetInt("BLTK_VanDong");
                    data.BLTK_VanDong_GhiRo = DataReader["BLTK_VanDong_GhiRo"].ToString();
                    data.BLTK_CamGiac = DataReader.GetInt("BLTK_CamGiac");
                    data.BLTK_CamGiac_GhiRo = DataReader["BLTK_CamGiac_GhiRo"].ToString();
                    data.BLTK_TuChu = DataReader.GetInt("BLTK_TuChu");
                    data.BLTK_TuChu_GhiRo = DataReader["BLTK_TuChu_GhiRo"].ToString();
                    data.CacBoPhanKhac = DataReader["CacBoPhanKhac"].ToString();
                    data.DuongMau_Doi = DataReader["DuongMau_Doi"].ToString();
                    data.DuongMau_SauAn = DataReader["DuongMau_SauAn"].ToString();
                    data.HbAlc = DataReader["HbAlc"].ToString();
                    data.Mau_Insulin = DataReader["Mau_Insulin"].ToString();
                    data.Creatimin = DataReader["Creatimin"].ToString();
                    data.Acrid_Uric = DataReader["Acrid_Uric"].ToString();
                    data.Lipid_CT = DataReader["Lipid_CT"].ToString();
                    data.Lipid_TG = DataReader["Lipid_TG"].ToString();
                    data.Lipid_HDL = DataReader["Lipid_HDL"].ToString();
                    data.Lipid_LDL = DataReader["Lipid_LDL"].ToString();
                    data.GOT = DataReader["GOT"].ToString();
                    data.GPT = DataReader["GPT"].ToString();
                    data.Protein = DataReader["Protein"].ToString();
                    data.Albumin = DataReader["Albumin"].ToString();
                    data.CTM_HC = DataReader["CTM_HC"].ToString();
                    data.CTM_Hb = DataReader["CTM_Hb"].ToString();
                    data.CTM_Ht = DataReader["CTM_Ht"].ToString();
                    data.CTM_BC = DataReader["CTM_BC"].ToString();
                    data.CTM_TC = DataReader["CTM_TC"].ToString();
                    data.NuocTieu_Protein = DataReader["NuocTieu_Protein"].ToString();
                    data.NuocTieu_Duong = DataReader["NuocTieu_Duong"].ToString();
                    data.NuocTieu_Cetol = DataReader["NuocTieu_Cetol"].ToString();
                    data.DienTamDo = DataReader["DienTamDo"].ToString();
                    data.SieuAmTim = DataReader["SieuAmTim"].ToString();
                    data.SADopplerMach = DataReader["SADopplerMach"].ToString();
                    data.XqTimPhoi = DataReader["XqTimPhoi"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.TheDTD = DataReader.GetInt("TheDTD");
                    data.Type1_Text = DataReader["Type1_Text"].ToString();
                    data.Type2_Text = DataReader["Type2_Text"].ToString();
                    data.Type_Khac = DataReader["Type_Khac"].ToString();
                    data.BienChung = DataReader["BienChung"].ToString();
                    data.BenhPhoiHop = DataReader["BenhPhoiHop"].ToString();
                    data.DieuTri = DataReader["DieuTri"].ToString();
                    data.LyDoThemThayThuoc = DataReader["LyDoThemThayThuoc"].ToString();
                    data.HenKhamLai = DataReader["HenKhamLai"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["HenKhamLai"]) : null;
                    data.HenXNLai = DataReader["HenXNLai"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["HenXNLai"]) : null;

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref TaiKhamDaiThaoDuong ketQua)
        {
            try
            {
                string sql = @"INSERT INTO TaiKhamDaiThaoDuong
                (
                    MAQUANLY,
                    MaBenhNhan,
                    TaiKhamLan,
                    NgayTaiKham,
                    ChieuCao,
                    CanNang,
                    BMT,
                    VongEo,
                    VongHong,
                    ChiSoEoHong,
                    KhatUongNhieu,
                    KhatUongNhieu_SL,
                    TieuNhieu,
                    TieuNhieu_SL,
                    MetMoi,
                    SutCan,
                    DauNguc,
                    DauCanhHoi,
                    TeBiChanTay,
                    MatNhinMo,
                    TrieuChungKhac,
                    ThiLuc_MP,
                    ThiLuc_MT,
                    TonThuong_MP,
                    TonThuong_MT,
                    DaNiemMac,
                    Phu,
                    Phu_ViTri,
                    TinhTrangRangLoi,
                    NhipTim_TuTheNam,
                    HA_TuTheNam,
                    NhipTim_TuTheDung,
                    HA_TuTheDung,
                    MachNgoaiBien,
                    MachNgoaiBien_ViTri,
                    TiengPhoiDM,
                    TiengPhoiDM_ViTri,
                    BLTK_VanDong,
                    BLTK_VanDong_GhiRo,
                    BLTK_CamGiac,
                    BLTK_CamGiac_GhiRo,
                    BLTK_TuChu,
                    BLTK_TuChu_GhiRo,
                    CacBoPhanKhac,
                    DuongMau_Doi,
                    DuongMau_SauAn,
                    HbAlc,
                    Mau_Insulin,
                    Creatimin,
                    Acrid_Uric,
                    Lipid_CT,
                    Lipid_TG,
                    Lipid_HDL,
                    Lipid_LDL,
                    GOT,
                    GPT,
                    Protein,
                    Albumin,
                    CTM_HC,
                    CTM_Hb,
                    CTM_Ht,
                    CTM_BC,
                    CTM_TC,
                    NuocTieu_Protein,
                    NuocTieu_Duong,
                    NuocTieu_Cetol,
                    DienTamDo,
                    SieuAmTim,
                    SADopplerMach,
                    XqTimPhoi,
                    ChanDoan,
                    TheDTD,
                    Type1_Text,
                    Type2_Text,
                    Type_Khac,
                    BienChung,
                    BenhPhoiHop,
                    DieuTri,
                    LyDoThemThayThuoc,
                    HenKhamLai,
                    HenXNLai,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :TaiKhamLan,
                    :NgayTaiKham,
                    :ChieuCao,
                    :CanNang,
                    :BMT,
                    :VongEo,
                    :VongHong,
                    :ChiSoEoHong,
                    :KhatUongNhieu,
                    :KhatUongNhieu_SL,
                    :TieuNhieu,
                    :TieuNhieu_SL,
                    :MetMoi,
                    :SutCan,
                    :DauNguc,
                    :DauCanhHoi,
                    :TeBiChanTay,
                    :MatNhinMo,
                    :TrieuChungKhac,
                    :ThiLuc_MP,
                    :ThiLuc_MT,
                    :TonThuong_MP,
                    :TonThuong_MT,
                    :DaNiemMac,
                    :Phu,
                    :Phu_ViTri,
                    :TinhTrangRangLoi,
                    :NhipTim_TuTheNam,
                    :HA_TuTheNam,
                    :NhipTim_TuTheDung,
                    :HA_TuTheDung,
                    :MachNgoaiBien,
                    :MachNgoaiBien_ViTri,
                    :TiengPhoiDM,
                    :TiengPhoiDM_ViTri,
                    :BLTK_VanDong,
                    :BLTK_VanDong_GhiRo,
                    :BLTK_CamGiac,
                    :BLTK_CamGiac_GhiRo,
                    :BLTK_TuChu,
                    :BLTK_TuChu_GhiRo,
                    :CacBoPhanKhac,
                    :DuongMau_Doi,
                    :DuongMau_SauAn,
                    :HbAlc,
                    :Mau_Insulin,
                    :Creatimin,
                    :Acrid_Uric,
                    :Lipid_CT,
                    :Lipid_TG,
                    :Lipid_HDL,
                    :Lipid_LDL,
                    :GOT,
                    :GPT,
                    :Protein,
                    :Albumin,
                    :CTM_HC,
                    :CTM_Hb,
                    :CTM_Ht,
                    :CTM_BC,
                    :CTM_TC,
                    :NuocTieu_Protein,
                    :NuocTieu_Duong,
                    :NuocTieu_Cetol,
                    :DienTamDo,
                    :SieuAmTim,
                    :SADopplerMach,
                    :XqTimPhoi,
                    :ChanDoan,
                    :TheDTD,
                    :Type1_Text,
                    :Type2_Text,
                    :Type_Khac,
                    :BienChung,
                    :BenhPhoiHop,
                    :DieuTri,
                    :LyDoThemThayThuoc,
                    :HenKhamLai,
                    :HenXNLai,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE TaiKhamDaiThaoDuong SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    TaiKhamLan=:TaiKhamLan,
                    NgayTaiKham=:NgayTaiKham,
                    ChieuCao=:ChieuCao,
                    CanNang=:CanNang,
                    BMT=:BMT,
                    VongEo=:VongEo,
                    VongHong=:VongHong,
                    ChiSoEoHong=:ChiSoEoHong,
                    KhatUongNhieu=:KhatUongNhieu,
                    KhatUongNhieu_SL=:KhatUongNhieu_SL,
                    TieuNhieu=:TieuNhieu,
                    TieuNhieu_SL=:TieuNhieu_SL,
                    MetMoi=:MetMoi,
                    SutCan=:SutCan,
                    DauNguc=:DauNguc,
                    DauCanhHoi=:DauCanhHoi,
                    TeBiChanTay=:TeBiChanTay,
                    MatNhinMo=:MatNhinMo,
                    TrieuChungKhac=:TrieuChungKhac,
                    ThiLuc_MP=:ThiLuc_MP,
                    ThiLuc_MT=:ThiLuc_MT,
                    TonThuong_MP=:TonThuong_MP,
                    TonThuong_MT=:TonThuong_MT,
                    DaNiemMac=:DaNiemMac,
                    Phu=:Phu,
                    Phu_ViTri=:Phu_ViTri,
                    TinhTrangRangLoi=:TinhTrangRangLoi,
                    NhipTim_TuTheNam=:NhipTim_TuTheNam,
                    HA_TuTheNam=:HA_TuTheNam,
                    NhipTim_TuTheDung=:NhipTim_TuTheDung,
                    HA_TuTheDung=:HA_TuTheDung,
                    MachNgoaiBien=:MachNgoaiBien,
                    MachNgoaiBien_ViTri=:MachNgoaiBien_ViTri,
                    TiengPhoiDM=:TiengPhoiDM,
                    TiengPhoiDM_ViTri=:TiengPhoiDM_ViTri,
                    BLTK_VanDong=:BLTK_VanDong,
                    BLTK_VanDong_GhiRo=:BLTK_VanDong_GhiRo,
                    BLTK_CamGiac=:BLTK_CamGiac,
                    BLTK_CamGiac_GhiRo=:BLTK_CamGiac_GhiRo,
                    BLTK_TuChu=:BLTK_TuChu,
                    BLTK_TuChu_GhiRo=:BLTK_TuChu_GhiRo,
                    CacBoPhanKhac=:CacBoPhanKhac,
                    DuongMau_Doi=:DuongMau_Doi,
                    DuongMau_SauAn=:DuongMau_SauAn,
                    HbAlc=:HbAlc,
                    Mau_Insulin=:Mau_Insulin,
                    Creatimin=:Creatimin,
                    Acrid_Uric=:Acrid_Uric,
                    Lipid_CT=:Lipid_CT,
                    Lipid_TG=:Lipid_TG,
                    Lipid_HDL=:Lipid_HDL,
                    Lipid_LDL=:Lipid_LDL,
                    GOT=:GOT,
                    GPT=:GPT,
                    Protein=:Protein,
                    Albumin=:Albumin,
                    CTM_HC=:CTM_HC,
                    CTM_Hb=:CTM_Hb,
                    CTM_Ht=:CTM_Ht,
                    CTM_BC=:CTM_BC,
                    CTM_TC=:CTM_TC,
                    NuocTieu_Protein=:NuocTieu_Protein,
                    NuocTieu_Duong=:NuocTieu_Duong,
                    NuocTieu_Cetol=:NuocTieu_Cetol,
                    DienTamDo=:DienTamDo,
                    SieuAmTim=:SieuAmTim,
                    SADopplerMach=:SADopplerMach,
                    XqTimPhoi=:XqTimPhoi,
                    ChanDoan=:ChanDoan,
                    TheDTD=:TheDTD,
                    Type1_Text=:Type1_Text,
                    Type2_Text=:Type2_Text,
                    Type_Khac=:Type_Khac,
                    BienChung=:BienChung,
                    BenhPhoiHop=:BenhPhoiHop,
                    DieuTri=:DieuTri,
                    LyDoThemThayThuoc=:LyDoThemThayThuoc,
                    HenKhamLai=:HenKhamLai,
                    HenXNLai=:HenXNLai,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ketQua.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("TaiKhamLan", ketQua.TaiKhamLan));
                Command.Parameters.Add(new MDB.MDBParameter("NgayTaiKham", ketQua.NgayTaiKham));
                Command.Parameters.Add(new MDB.MDBParameter("ChieuCao", ketQua.ChieuCao));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang", ketQua.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("BMT", ketQua.BMT));
                Command.Parameters.Add(new MDB.MDBParameter("VongEo", ketQua.VongEo));
                Command.Parameters.Add(new MDB.MDBParameter("VongHong", ketQua.VongHong));
                Command.Parameters.Add(new MDB.MDBParameter("ChiSoEoHong", ketQua.ChiSoEoHong));
                Command.Parameters.Add(new MDB.MDBParameter("KhatUongNhieu", ketQua.KhatUongNhieu));
                Command.Parameters.Add(new MDB.MDBParameter("KhatUongNhieu_SL", ketQua.KhatUongNhieu_SL));
                Command.Parameters.Add(new MDB.MDBParameter("TieuNhieu", ketQua.TieuNhieu));
                Command.Parameters.Add(new MDB.MDBParameter("TieuNhieu_SL", ketQua.TieuNhieu_SL));
                Command.Parameters.Add(new MDB.MDBParameter("MetMoi", ketQua.MetMoi));
                Command.Parameters.Add(new MDB.MDBParameter("SutCan", ketQua.SutCan));
                Command.Parameters.Add(new MDB.MDBParameter("DauNguc", ketQua.DauNguc));
                Command.Parameters.Add(new MDB.MDBParameter("DauCanhHoi", ketQua.DauCanhHoi));
                Command.Parameters.Add(new MDB.MDBParameter("TeBiChanTay", ketQua.TeBiChanTay));
                Command.Parameters.Add(new MDB.MDBParameter("MatNhinMo", ketQua.MatNhinMo));
                Command.Parameters.Add(new MDB.MDBParameter("TrieuChungKhac", ketQua.TrieuChungKhac));
                Command.Parameters.Add(new MDB.MDBParameter("ThiLuc_MP", ketQua.ThiLuc_MP));
                Command.Parameters.Add(new MDB.MDBParameter("ThiLuc_MT", ketQua.ThiLuc_MT));
                Command.Parameters.Add(new MDB.MDBParameter("TonThuong_MP", ketQua.TonThuong_MP));
                Command.Parameters.Add(new MDB.MDBParameter("TonThuong_MT", ketQua.TonThuong_MT));
                Command.Parameters.Add(new MDB.MDBParameter("DaNiemMac", ketQua.DaNiemMac));
                Command.Parameters.Add(new MDB.MDBParameter("Phu", ketQua.Phu));
                Command.Parameters.Add(new MDB.MDBParameter("Phu_ViTri", ketQua.Phu_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangRangLoi", ketQua.TinhTrangRangLoi));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTim_TuTheNam", ketQua.NhipTim_TuTheNam));
                Command.Parameters.Add(new MDB.MDBParameter("HA_TuTheNam", ketQua.HA_TuTheNam));
                Command.Parameters.Add(new MDB.MDBParameter("NhipTim_TuTheDung", ketQua.NhipTim_TuTheDung));
                Command.Parameters.Add(new MDB.MDBParameter("HA_TuTheDung", ketQua.HA_TuTheDung));
                Command.Parameters.Add(new MDB.MDBParameter("MachNgoaiBien", ketQua.MachNgoaiBien));
                Command.Parameters.Add(new MDB.MDBParameter("MachNgoaiBien_ViTri", ketQua.MachNgoaiBien_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("TiengPhoiDM", ketQua.TiengPhoiDM));
                Command.Parameters.Add(new MDB.MDBParameter("TiengPhoiDM_ViTri", ketQua.TiengPhoiDM_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("BLTK_VanDong", ketQua.BLTK_VanDong));
                Command.Parameters.Add(new MDB.MDBParameter("BLTK_VanDong_GhiRo", ketQua.BLTK_VanDong_GhiRo));
                Command.Parameters.Add(new MDB.MDBParameter("BLTK_CamGiac", ketQua.BLTK_CamGiac));
                Command.Parameters.Add(new MDB.MDBParameter("BLTK_CamGiac_GhiRo", ketQua.BLTK_CamGiac_GhiRo));
                Command.Parameters.Add(new MDB.MDBParameter("BLTK_TuChu", ketQua.BLTK_TuChu));
                Command.Parameters.Add(new MDB.MDBParameter("BLTK_TuChu_GhiRo", ketQua.BLTK_TuChu_GhiRo));
                Command.Parameters.Add(new MDB.MDBParameter("CacBoPhanKhac", ketQua.CacBoPhanKhac));
                Command.Parameters.Add(new MDB.MDBParameter("DuongMau_Doi", ketQua.DuongMau_Doi));
                Command.Parameters.Add(new MDB.MDBParameter("DuongMau_SauAn", ketQua.DuongMau_SauAn));
                Command.Parameters.Add(new MDB.MDBParameter("HbAlc", ketQua.HbAlc));
                Command.Parameters.Add(new MDB.MDBParameter("Mau_Insulin", ketQua.Mau_Insulin));
                Command.Parameters.Add(new MDB.MDBParameter("Creatimin", ketQua.Creatimin));
                Command.Parameters.Add(new MDB.MDBParameter("Acrid_Uric", ketQua.Acrid_Uric));
                Command.Parameters.Add(new MDB.MDBParameter("Lipid_CT", ketQua.Lipid_CT));
                Command.Parameters.Add(new MDB.MDBParameter("Lipid_TG", ketQua.Lipid_TG));
                Command.Parameters.Add(new MDB.MDBParameter("Lipid_HDL", ketQua.Lipid_HDL));
                Command.Parameters.Add(new MDB.MDBParameter("Lipid_LDL", ketQua.Lipid_LDL));
                Command.Parameters.Add(new MDB.MDBParameter("GOT", ketQua.GOT));
                Command.Parameters.Add(new MDB.MDBParameter("GPT", ketQua.GPT));
                Command.Parameters.Add(new MDB.MDBParameter("Protein", ketQua.Protein));
                Command.Parameters.Add(new MDB.MDBParameter("Albumin", ketQua.Albumin));
                Command.Parameters.Add(new MDB.MDBParameter("CTM_HC", ketQua.CTM_HC));
                Command.Parameters.Add(new MDB.MDBParameter("CTM_Hb", ketQua.CTM_Hb));
                Command.Parameters.Add(new MDB.MDBParameter("CTM_Ht", ketQua.CTM_Ht));
                Command.Parameters.Add(new MDB.MDBParameter("CTM_BC", ketQua.CTM_BC));
                Command.Parameters.Add(new MDB.MDBParameter("CTM_TC", ketQua.CTM_TC));
                Command.Parameters.Add(new MDB.MDBParameter("NuocTieu_Protein", ketQua.NuocTieu_Protein));
                Command.Parameters.Add(new MDB.MDBParameter("NuocTieu_Duong", ketQua.NuocTieu_Duong));
                Command.Parameters.Add(new MDB.MDBParameter("NuocTieu_Cetol", ketQua.NuocTieu_Cetol));
                Command.Parameters.Add(new MDB.MDBParameter("DienTamDo", ketQua.DienTamDo));
                Command.Parameters.Add(new MDB.MDBParameter("SieuAmTim", ketQua.SieuAmTim));
                Command.Parameters.Add(new MDB.MDBParameter("SADopplerMach", ketQua.SADopplerMach));
                Command.Parameters.Add(new MDB.MDBParameter("XqTimPhoi", ketQua.XqTimPhoi));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", ketQua.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("TheDTD", ketQua.TheDTD));
                Command.Parameters.Add(new MDB.MDBParameter("Type1_Text", ketQua.Type1_Text));
                Command.Parameters.Add(new MDB.MDBParameter("Type2_Text", ketQua.Type2_Text));
                Command.Parameters.Add(new MDB.MDBParameter("Type_Khac", ketQua.Type_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("BienChung", ketQua.BienChung));
                Command.Parameters.Add(new MDB.MDBParameter("BenhPhoiHop", ketQua.BenhPhoiHop));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTri", ketQua.DieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("LyDoThemThayThuoc", ketQua.LyDoThemThayThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("HenKhamLai", ketQua.HenKhamLai));
                Command.Parameters.Add(new MDB.MDBParameter("HenXNLai", ketQua.HenXNLai));

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
                string sql = "DELETE FROM TaiKhamDaiThaoDuong WHERE ID = :ID";
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
                P.*, c.hovaten BacSyDieuTriHoVaTen 
            FROM
                TaiKhamDaiThaoDuong P 
            left join nhanvien c on P.bacsydieutri = c.manhanvien 
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "Table");

            return ds;
        }
    }
}
