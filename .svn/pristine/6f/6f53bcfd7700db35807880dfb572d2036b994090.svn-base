using EMR.KyDienTu;
using Newtonsoft.Json;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class BaoCaoPhanUngCoHaiCuaThuoc : ThongTinKy
    {
        public BaoCaoPhanUngCoHaiCuaThuoc()
        {
            TableName = "BaoCaoPhanUngCoHaiCuaThuoc";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BCPUCHCT;
            TenMauPhieu = DanhMucPhieu.BCPUCHCT.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Nơi báo cáo")]
        public string NoiBaoCao { get; set; }
        [MoTaDuLieu("Mã số báo cáo của đơn vị")]
        public string MaSoBaoCaoDV { get; set; }
        [MoTaDuLieu("Mã số báo cáo(do trung tâm quốc gia quản lý)")]
        public string MaSoBaoCaoTT { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
        public string HoTenBenhNhan { get; set; }
        [MoTaDuLieu("Ngày sinh bệnh nhân")]
        public DateTime? NamSinh { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Cân nặng")]
		public string CanNang { get; set; }
        [MoTaDuLieu("Ngày xuất hiện phản ứng")]
        public DateTime? NgayXHPU { get; set; }
        [MoTaDuLieu("Thời gian phản ứng")]
        public string ThoiGianPU { get; set; }
        [MoTaDuLieu("Mô tả biểu hiện")]
        public string MoTaBieuHien { get; set; }
        [MoTaDuLieu("Các xét nghiệm liên quan đến phản ứng")]
        public string CacXetNghiemLQ { get; set; }
        [MoTaDuLieu("Tiền sử")]
        public string TienSu { get; set; }
        [MoTaDuLieu("Cách xử trí phản ứng")]
        public string CachXuTri { get; set; }
       
        public bool[] MucDoNghiemTrongArray { get; } = new bool[] { false, false, false, false, false, false };
        [MoTaDuLieu("Mức độ nghiệm trọng của phản ứng")]
        public string MucDoNghiemTrong
        {
            get
            {
                string temp = "";
                for (int i = 0; i < MucDoNghiemTrongArray.Length; i++)
                    temp += (MucDoNghiemTrongArray[i] ? "1" : "0");
                return temp;    
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        MucDoNghiemTrongArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] KetQuaSauXuTriArray { get; } = new bool[] { false, false, false, false, false, false, false };
        [MoTaDuLieu("Kết quả sau khi xử trí phản ứng")]
        public string KetQuaSauXuTri
        {
            get
            {
                string temp = "";
                for (int i = 0; i < KetQuaSauXuTriArray.Length; i++)
                    temp += (KetQuaSauXuTriArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        KetQuaSauXuTriArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] DanhGiaMoiLQArray { get; } = new bool[] { false, false, false, false, false, false, false };
        [MoTaDuLieu("Đánh giá mối liên quan giữa thuốc và ADR")]
        public string DanhGiaMoiLQ
        {
            get
            {
                string temp = "";
                for (int i = 0; i < DanhGiaMoiLQArray.Length; i++)
                    temp += (DanhGiaMoiLQArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DanhGiaMoiLQArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Khác(Đánh giá mối liên quan giữa thuốc và ADR)")]
        public string DanhGiaMoiLQ_Text { get; set; }
        public bool[] DonViThamDinhArray { get; } = new bool[] { false, false, false};
        [MoTaDuLieu("Đơn vị thẩm định ADR theo thang nào?")]
        public string DonViThamDinh
        {
            get
            {
                string temp = "";
                for (int i = 0; i < DonViThamDinhArray.Length; i++)
                    temp += (DonViThamDinhArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DonViThamDinhArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Thang khác")]
        public string DonViThamDinh_Text { get; set; }
        [MoTaDuLieu("Phần bình luận của cán bộ y tế")]
        public string BinhLuan { get; set; }
        [MoTaDuLieu("Họ và tên người báo cáo")]
        public string HoTen_NBC { get; set; }
        [MoTaDuLieu("Nghề nghiệp người báo cáo")]
        public string NgheNghiep_NBC { get; set; }
        [MoTaDuLieu("Điện thoại liên lạc người báo cáo")]
        public string DT_NBC { get; set; }
        [MoTaDuLieu("")]
        public string Email_NBC { get; set; }
        [MoTaDuLieu("Chữ ký người báo cáo")]
        public string ChuKy_NBC { get; set; }
        public bool[] DangBaoCaoArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Dạng báo cáo")]
        public string DangBaoCao
        {
            get
            {
                string temp = "";
                for (int i = 0; i < DangBaoCaoArray.Length; i++)
                    temp += (DangBaoCaoArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DangBaoCaoArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Ngày báo cáo")]
        public DateTime? NgayBaoCao { get; set; }
        [MoTaDuLieu("Gửi xác nhận tới đơn vị báo cáo")]
        public string GuiXacNhan { get; set; }
        [MoTaDuLieu("Phản ứng đã có trong y văn/SPC/CSDL")]
        public string PhanUngDaCo { get; set; }
        public bool[] PhanLoaiPhanUngArray { get; } = new bool[] { false, false, false, false };
        [MoTaDuLieu("Phân loại phản ứng")]
        public string PhanLoaiPhanUng
        {
            get
            {
                string temp = "";
                for (int i = 0; i < PhanLoaiPhanUngArray.Length; i++)
                    temp += (PhanLoaiPhanUngArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        PhanLoaiPhanUngArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Phân loại phản ứng chính")]
        public string PhanLoaiPhanUng_Main { get; set; }
        [MoTaDuLieu("Nhập dữ liệu vào hệ cơ sở dữ liệu quốc gia")]
        public string NhapDuieu { get; set; }
        [MoTaDuLieu("Nhập dữ liệu vào phần mềm Vigiflow")]
        public string NhapDuieuVigi { get; set; }
        public bool[] MucDoNghiemTrong_TTArray { get; } = new bool[] { false, false, false, false };
        [MoTaDuLieu("Mức độ nghiêm trọng của phản ứng")]
        public string MucDoNghiemTrong_TT
        {
            get
            {
                string temp = "";
                for (int i = 0; i < MucDoNghiemTrong_TTArray.Length; i++)
                    temp += (MucDoNghiemTrong_TTArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        MucDoNghiemTrong_TTArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Gửi báo cáo tới hội đồng thẩm định")]
        public string GuiChoThamDinh { get; set; }
        [MoTaDuLieu("Ngày gửi báo cáo tới hội đồng thẩm định")]
        public DateTime? NgayGuiChoThamDinh { get; set; }
        [MoTaDuLieu("Gửi báo cáo cho UMC")]
        public string GuiChoUMC { get; set; }
        [MoTaDuLieu("Ngày gửi báo cáo cho UMC")]
        public DateTime? NgayGuiChoUMC { get; set; }
        public bool[] KetQuaThamDinhArray { get; } = new bool[] { false, false, false, false, false, false, false };
        [MoTaDuLieu("Kết quả thẩm định")]
        public string KetQuaThamDinh
        {
            get
            {
                string temp = "";
                for (int i = 0; i < KetQuaThamDinhArray.Length; i++)
                    temp += (KetQuaThamDinhArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        KetQuaThamDinhArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Kết quả thẩm định khác")]
        public string KetQuaThamDinh_Text { get; set; }
        [MoTaDuLieu("Người quản lý báo cáo")]
        public string NguoiQuanLy_TT { get; set; }
        [MoTaDuLieu("Chữ ký người quản lý báo cáo")]
        public string ChuKy_TT { get; set; }
        [MoTaDuLieu("Ngày báo cáo")]
        public DateTime? NgayBaoCao_TT { get; set; }

        [MoTaDuLieu("Danh sách thuốc nghi ngờ gây ADR")]
        public ObservableCollection<ThuocNghiNgoGayADR> ListThuocADR { get; set; }
        [MoTaDuLieu("Danh sách kết quả sử dụng thuốc")]
        public ObservableCollection<KetQuaSuDungThuoc> ListKetQua { get; set; }
        [MoTaDuLieu("Danh sách thuốc đồng thời")]
        public ObservableCollection<ThuocDongThoi> ListThuocDT { get; set; }

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

    public class ThuocNghiNgoGayADR
    {
        [MoTaDuLieu("STT")]
        public string STT { get; set; }
        [MoTaDuLieu("Tên thuốc")]
        public string TenThuoc { get; set; }
        [MoTaDuLieu("Dạng bào chế")]
        public string DangBaoChe { get; set; }
        [MoTaDuLieu("Nhà sản xuất")]
        public string NhaSanXuat { get; set; }
        [MoTaDuLieu("Số lô")]
        public string SoLo { get; set; }
        [MoTaDuLieu("Liều dùng một lần")]
        public string LieuDungMotLan { get; set; }
        [MoTaDuLieu("Số lần dùng trong ngày/tuần/tháng")]
        public string SoLanDung { get; set; }
        [MoTaDuLieu("Đường dùng")]
        public string DuongDung { get; set; }
        [MoTaDuLieu("Ngày bắt đầu điều trị")]
        public DateTime? NgayBatDau { get; set; }
        [MoTaDuLieu("Ngày kết thúc điều trị")]
        public DateTime? NgayKetThuc { get; set; }
        [MoTaDuLieu("Lý do dùng thuốc")]
        public string LyDoDungThuoc { get; set; }
    }

    public class KetQuaSuDungThuoc
    {
        [MoTaDuLieu("STT")]
        public string STT { get; set; }
        [MoTaDuLieu("Sau khi ngừng/giảm liều của thuốc bị nghi ngờ, phản ứng có được cải thiện không?: Có")]
        public string CaiThien_1 { get; set; }
        [MoTaDuLieu("Sau khi ngừng/giảm liều của thuốc bị nghi ngờ, phản ứng có được cải thiện không?: Không")]
        public string CaiThien_2 { get; set; }
        [MoTaDuLieu("Sau khi ngừng/giảm liều của thuốc bị nghi ngờ, phản ứng có được cải thiện không?: Không ngừng/giảm liều")]
        public string CaiThien_3 { get; set; }
        [MoTaDuLieu("Sau khi ngừng/giảm liều của thuốc bị nghi ngờ, phản ứng có được cải thiện không?: Không có thông tin")]
        public string CaiThien_4 { get; set; }
        [MoTaDuLieu("Tái sử dụng thuốc bị nghi ngờ có xuất hiện lại phản ứng không?: Có")]
        public string PhanUng_1 { get; set; }
        [MoTaDuLieu("Tái sử dụng thuốc bị nghi ngờ có xuất hiện lại phản ứng không?: Không")]
        public string PhanUng_2 { get; set; }
        [MoTaDuLieu("Tái sử dụng thuốc bị nghi ngờ có xuất hiện lại phản ứng không?: Không ngừng/giảm liều")]
        public string PhanUng_3 { get; set; }
        [MoTaDuLieu("Tái sử dụng thuốc bị nghi ngờ có xuất hiện lại phản ứng không?: Không có thông tin")]
        public string PhanUng_4 { get; set; }
    }

    public class ThuocDongThoi
    {
        [MoTaDuLieu("Tên thuốc")]
        public string TenThuoc { get; set; }
        [MoTaDuLieu("Dạng bào chế")]
        public string DangBaoChe { get; set; }
        [MoTaDuLieu("Ngày bắt đầu điều trị")]
        public DateTime? NgayBatDau { get; set; }
        [MoTaDuLieu("Ngày kết thúc điều trị")]
        public DateTime? NgayKetThuc { get; set; }

    }
    public class BaoCaoPhanUngCoHaiCuaThuocFunc
    {
        public const string TableName = "BaoCaoPhanUngCoHaiCuaThuoc";
        public const string TablePrimaryKeyName = "ID";
        public static List<BaoCaoPhanUngCoHaiCuaThuoc> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BaoCaoPhanUngCoHaiCuaThuoc> list = new List<BaoCaoPhanUngCoHaiCuaThuoc>();
            try
            {
                string sql = @"SELECT * FROM BaoCaoPhanUngCoHaiCuaThuoc where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    BaoCaoPhanUngCoHaiCuaThuoc data = new BaoCaoPhanUngCoHaiCuaThuoc();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.HoTenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.NamSinh = XemBenhAn._HanhChinhBenhNhan.NgaySinh;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.NoiBaoCao = DataReader["NoiBaoCao"].ToString();
                    data.MaSoBaoCaoDV = DataReader["MaSoBaoCaoDV"].ToString();
                    data.MaSoBaoCaoTT = DataReader["MaSoBaoCaoTT"].ToString();
                    data.CanNang = DataReader["CanNang"].ToString();
                    data.NgayXHPU = Convert.ToDateTime(DataReader["NgayXHPU"] == DBNull.Value ? DateTime.Now : DataReader["NgayXHPU"]);
                    data.ThoiGianPU = DataReader["ThoiGianPU"].ToString();
                    data.MoTaBieuHien = DataReader["MoTaBieuHien"].ToString();
                    data.CacXetNghiemLQ = DataReader["CacXetNghiemLQ"].ToString();
                    data.TienSu = DataReader["TienSu"].ToString();
                    data.CachXuTri = DataReader["CachXuTri"].ToString();
                    data.MucDoNghiemTrong = DataReader["MucDoNghiemTrong"].ToString();
                    data.KetQuaSauXuTri = DataReader["KetQuaSauXuTri"].ToString();
                    data.DanhGiaMoiLQ = DataReader["DanhGiaMoiLQ"].ToString();
                    data.DanhGiaMoiLQ_Text = DataReader["DanhGiaMoiLQ_Text"].ToString();
                    data.DonViThamDinh = DataReader["DonViThamDinh"].ToString();
                    data.DonViThamDinh_Text = DataReader["DonViThamDinh_Text"].ToString();
                    data.BinhLuan = DataReader["BinhLuan"].ToString();
                    data.HoTen_NBC = DataReader["HoTen_NBC"].ToString();
                    data.NgheNghiep_NBC = DataReader["NgheNghiep_NBC"].ToString();
                    data.DT_NBC = DataReader["DT_NBC"].ToString();
                    data.Email_NBC = DataReader["Email_NBC"].ToString();
                    data.ChuKy_NBC = DataReader["ChuKy_NBC"].ToString();
                    data.DangBaoCao = DataReader["DangBaoCao"].ToString();
                    data.NgayBaoCao = Convert.ToDateTime(DataReader["NgayBaoCao"] == DBNull.Value ? DateTime.Now : DataReader["NgayBaoCao"]);
                    data.GuiXacNhan = DataReader["GuiXacNhan"].ToString();
                    data.PhanUngDaCo = DataReader["PhanUngDaCo"].ToString();
                    data.PhanLoaiPhanUng = DataReader["PhanLoaiPhanUng"].ToString();
                    data.PhanLoaiPhanUng_Main = DataReader["PhanLoaiPhanUng_Main"].ToString();
                    data.NhapDuieu = DataReader["NhapDuieu"].ToString();
                    data.NhapDuieuVigi = DataReader["NhapDuieuVigi"].ToString();
                    data.MucDoNghiemTrong_TT = DataReader["MucDoNghiemTrong_TT"].ToString();
                    data.GuiChoThamDinh = DataReader["GuiChoThamDinh"].ToString();
                    data.NgayGuiChoThamDinh = Convert.ToDateTime(DataReader["NgayGuiChoThamDinh"] == DBNull.Value ? DateTime.Now : DataReader["NgayGuiChoThamDinh"]);
                    data.GuiChoUMC = DataReader["GuiChoUMC"].ToString();
                    data.NgayGuiChoUMC = Convert.ToDateTime(DataReader["NgayGuiChoUMC"] == DBNull.Value ? DateTime.Now : DataReader["NgayGuiChoUMC"]);
                    data.KetQuaThamDinh = DataReader["KetQuaThamDinh"].ToString();
                    data.KetQuaThamDinh_Text = DataReader["KetQuaThamDinh_Text"].ToString();
                    data.ChuKy_TT = DataReader["ChuKy_TT"].ToString();
                    data.NguoiQuanLy_TT = DataReader["NguoiQuanLy_TT"].ToString();
                    data.NgayBaoCao_TT = Convert.ToDateTime(DataReader["NgayBaoCao_TT"] == DBNull.Value ? DateTime.Now : DataReader["NgayGuiChoThamDinh"]);

                    data.ListKetQua = JsonConvert.DeserializeObject<ObservableCollection<KetQuaSuDungThuoc>>(DataReader["ListKetQua"].ToString());
                    data.ListThuocADR = JsonConvert.DeserializeObject<ObservableCollection<ThuocNghiNgoGayADR>>(DataReader["ListThuocADR"].ToString());
                    data.ListThuocDT = JsonConvert.DeserializeObject<ObservableCollection<ThuocDongThoi>>(DataReader["ListThuocDT"].ToString());

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BaoCaoPhanUngCoHaiCuaThuoc bangKe)
        {
            try
            {
                string sql = @"INSERT INTO BaoCaoPhanUngCoHaiCuaThuoc
                (
                    MAQUANLY,
                    NoiBaoCao,
                    MaSoBaoCaoDV,
                    MaSoBaoCaoTT,
                    CanNang,
                    NgayXHPU,
                    ThoiGianPU,
                    MoTaBieuHien,
                    CacXetNghiemLQ,
                    TienSu,
                    CachXuTri,
                    MucDoNghiemTrong,
                    KetQuaSauXuTri,
                    DanhGiaMoiLQ,
                    DanhGiaMoiLQ_Text,
                    DonViThamDinh,
                    DonViThamDinh_Text,
                    BinhLuan,
                    HoTen_NBC,
                    NgheNghiep_NBC,
                    DT_NBC,
                    Email_NBC,
                    ChuKy_NBC,
                    DangBaoCao,
                    NgayBaoCao,
                    GuiXacNhan,
                    PhanUngDaCo,
                    PhanLoaiPhanUng,
                    PhanLoaiPhanUng_Main,
                    NhapDuieu,
                    NhapDuieuVigi,
                    MucDoNghiemTrong_TT,
                    GuiChoThamDinh,
                    NgayGuiChoThamDinh,
                    GuiChoUMC,
                    NgayGuiChoUMC,
                    KetQuaThamDinh,
                    KetQuaThamDinh_Text,
                    ChuKy_TT,
                    NguoiQuanLy_TT,
                    NgayBaoCao_TT,
                    ListKetQua,
                    ListThuocADR,
                    ListThuocDT,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :NoiBaoCao,
                    :MaSoBaoCaoDV,
                    :MaSoBaoCaoTT,
                    :CanNang,
                    :NgayXHPU,
                    :ThoiGianPU,
                    :MoTaBieuHien,
                    :CacXetNghiemLQ,
                    :TienSu,
                    :CachXuTri,
                    :MucDoNghiemTrong,
                    :KetQuaSauXuTri,
                    :DanhGiaMoiLQ,
                    :DanhGiaMoiLQ_Text,
                    :DonViThamDinh,
                    :DonViThamDinh_Text,
                    :BinhLuan,
                    :HoTen_NBC,
                    :NgheNghiep_NBC,
                    :DT_NBC,
                    :Email_NBC,
                    :ChuKy_NBC,
                    :DangBaoCao,
                    :NgayBaoCao,
                    :GuiXacNhan,
                    :PhanUngDaCo,
                    :PhanLoaiPhanUng,
                    :PhanLoaiPhanUng_Main,
                    :NhapDuieu,
                    :NhapDuieuVigi,
                    :MucDoNghiemTrong_TT,
                    :GuiChoThamDinh,
                    :NgayGuiChoThamDinh,
                    :GuiChoUMC,
                    :NgayGuiChoUMC,
                    :KetQuaThamDinh,
                    :KetQuaThamDinh_Text,
                    :ChuKy_TT,
                    :NguoiQuanLy_TT,
                    :NgayBaoCao_TT,
                    :ListKetQua,
                    :ListThuocADR,
                    :ListThuocDT,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (bangKe.ID != 0)
                {
                    sql = @"UPDATE BaoCaoPhanUngCoHaiCuaThuoc SET 
                    MAQUANLY = :MAQUANLY,
                    NoiBaoCao = :NoiBaoCao,
                    MaSoBaoCaoDV = :MaSoBaoCaoDV,
                    MaSoBaoCaoTT = :MaSoBaoCaoTT,
                    CanNang = :CanNang,
                    NgayXHPU = :NgayXHPU,
                    ThoiGianPU = :ThoiGianPU,
                    MoTaBieuHien = :MoTaBieuHien,
                    CacXetNghiemLQ = :CacXetNghiemLQ,
                    TienSu = :TienSu,
                    CachXuTri = :CachXuTri,
                    MucDoNghiemTrong = :MucDoNghiemTrong,
                    KetQuaSauXuTri = :KetQuaSauXuTri,
                    DanhGiaMoiLQ = :DanhGiaMoiLQ,
                    DanhGiaMoiLQ_Text = :DanhGiaMoiLQ_Text,
                    DonViThamDinh = :DonViThamDinh,
                    DonViThamDinh_Text = :DonViThamDinh_Text,
                    BinhLuan = :BinhLuan,
                    HoTen_NBC = :HoTen_NBC,
                    NgheNghiep_NBC = :NgheNghiep_NBC,
                    DT_NBC = :DT_NBC,
                    Email_NBC = :Email_NBC,
                    ChuKy_NBC = :ChuKy_NBC,
                    DangBaoCao = :DangBaoCao,
                    NgayBaoCao = :NgayBaoCao,
                    GuiXacNhan = :GuiXacNhan,
                    PhanUngDaCo = :PhanUngDaCo,
                    PhanLoaiPhanUng = :PhanLoaiPhanUng,
                    PhanLoaiPhanUng_Main = :PhanLoaiPhanUng_Main,
                    NhapDuieu = :NhapDuieu,
                    NhapDuieuVigi = :NhapDuieuVigi,
                    MucDoNghiemTrong_TT = :MucDoNghiemTrong_TT,
                    GuiChoThamDinh = :GuiChoThamDinh,
                    NgayGuiChoThamDinh = :NgayGuiChoThamDinh,
                    GuiChoUMC = :GuiChoUMC,
                    NgayGuiChoUMC = :NgayGuiChoUMC,
                    KetQuaThamDinh = :KetQuaThamDinh,
                    KetQuaThamDinh_Text = :KetQuaThamDinh_Text,
                    ChuKy_TT = :ChuKy_TT,
                    NguoiQuanLy_TT = :NguoiQuanLy_TT,
                    NgayBaoCao_TT = :NgayBaoCao_TT,
                    ListKetQua = :ListKetQua,
                    ListThuocADR = :ListThuocADR,
                    ListThuocDT = :ListThuocDT,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + bangKe.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangKe.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("NoiBaoCao", bangKe.NoiBaoCao));
                Command.Parameters.Add(new MDB.MDBParameter("MaSoBaoCaoDV", bangKe.MaSoBaoCaoDV));
                Command.Parameters.Add(new MDB.MDBParameter("MaSoBaoCaoTT", bangKe.MaSoBaoCaoTT));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang", bangKe.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("NgayXHPU", bangKe.NgayXHPU));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianPU", bangKe.ThoiGianPU));
                Command.Parameters.Add(new MDB.MDBParameter("MoTaBieuHien", bangKe.MoTaBieuHien));
                Command.Parameters.Add(new MDB.MDBParameter("CacXetNghiemLQ", bangKe.CacXetNghiemLQ));
                Command.Parameters.Add(new MDB.MDBParameter("TienSu", bangKe.TienSu));
                Command.Parameters.Add(new MDB.MDBParameter("CachXuTri", bangKe.CachXuTri));
                Command.Parameters.Add(new MDB.MDBParameter("MucDoNghiemTrong", bangKe.MucDoNghiemTrong));
                Command.Parameters.Add(new MDB.MDBParameter("KetQuaSauXuTri", bangKe.KetQuaSauXuTri));
                Command.Parameters.Add(new MDB.MDBParameter("DanhGiaMoiLQ", bangKe.DanhGiaMoiLQ));
                Command.Parameters.Add(new MDB.MDBParameter("DanhGiaMoiLQ_Text", bangKe.DanhGiaMoiLQ_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DonViThamDinh", bangKe.DonViThamDinh));
                Command.Parameters.Add(new MDB.MDBParameter("DonViThamDinh_Text", bangKe.DonViThamDinh_Text));
                Command.Parameters.Add(new MDB.MDBParameter("BinhLuan", bangKe.BinhLuan));
                Command.Parameters.Add(new MDB.MDBParameter("HoTen_NBC", bangKe.HoTen_NBC));
                Command.Parameters.Add(new MDB.MDBParameter("NgheNghiep_NBC", bangKe.NgheNghiep_NBC));
                Command.Parameters.Add(new MDB.MDBParameter("DT_NBC", bangKe.DT_NBC));
                Command.Parameters.Add(new MDB.MDBParameter("Email_NBC", bangKe.Email_NBC));
                Command.Parameters.Add(new MDB.MDBParameter("ChuKy_NBC", bangKe.ChuKy_NBC));
                Command.Parameters.Add(new MDB.MDBParameter("DangBaoCao", bangKe.DangBaoCao));
                Command.Parameters.Add(new MDB.MDBParameter("NgayBaoCao", bangKe.NgayBaoCao));
                Command.Parameters.Add(new MDB.MDBParameter("GuiXacNhan", bangKe.GuiXacNhan));
                Command.Parameters.Add(new MDB.MDBParameter("PhanUngDaCo", bangKe.PhanUngDaCo));
                Command.Parameters.Add(new MDB.MDBParameter("PhanLoaiPhanUng", bangKe.PhanLoaiPhanUng));
                Command.Parameters.Add(new MDB.MDBParameter("PhanLoaiPhanUng_Main", bangKe.PhanLoaiPhanUng_Main));
                Command.Parameters.Add(new MDB.MDBParameter("NhapDuieu", bangKe.NhapDuieu));
                Command.Parameters.Add(new MDB.MDBParameter("NhapDuieuVigi", bangKe.NhapDuieuVigi));
                Command.Parameters.Add(new MDB.MDBParameter("MucDoNghiemTrong_TT", bangKe.MucDoNghiemTrong_TT));
                Command.Parameters.Add(new MDB.MDBParameter("GuiChoThamDinh", bangKe.GuiChoThamDinh));
                Command.Parameters.Add(new MDB.MDBParameter("NgayGuiChoThamDinh", bangKe.NgayGuiChoThamDinh));
                Command.Parameters.Add(new MDB.MDBParameter("GuiChoUMC", bangKe.GuiChoUMC));
                Command.Parameters.Add(new MDB.MDBParameter("NgayGuiChoUMC", bangKe.NgayGuiChoUMC));
                Command.Parameters.Add(new MDB.MDBParameter("KetQuaThamDinh", bangKe.KetQuaThamDinh));
                Command.Parameters.Add(new MDB.MDBParameter("KetQuaThamDinh_Text", bangKe.KetQuaThamDinh_Text));
                Command.Parameters.Add(new MDB.MDBParameter("ChuKy_TT", bangKe.ChuKy_TT));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiQuanLy_TT", bangKe.NguoiQuanLy_TT));
                Command.Parameters.Add(new MDB.MDBParameter("NgayBaoCao_TT", bangKe.NgayBaoCao_TT));
                Command.Parameters.Add(new MDB.MDBParameter("ListKetQua", JsonConvert.SerializeObject(bangKe.ListKetQua)));
                Command.Parameters.Add(new MDB.MDBParameter("ListThuocADR", JsonConvert.SerializeObject(bangKe.ListThuocADR)));
                Command.Parameters.Add(new MDB.MDBParameter("ListThuocDT", JsonConvert.SerializeObject(bangKe.ListThuocDT)));

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", bangKe.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", bangKe.NgaySua));
                if (bangKe.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", bangKe.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", bangKe.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", bangKe.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (bangKe.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    bangKe.ID = nextval;
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
                string sql = "DELETE FROM BaoCaoPhanUngCoHaiCuaThuoc WHERE ID = :ID";
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
                *
            FROM
                BaoCaoPhanUngCoHaiCuaThuoc B
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);

            var ds = new DataSet();

            adt.Fill(ds, "TB");
            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("NamSinh", typeof(DateTime));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(int));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["NamSinh"] = XemBenhAn._HanhChinhBenhNhan.NgaySinh;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh;

            ObservableCollection<ThuocNghiNgoGayADR> ListThuocADR = JsonConvert.DeserializeObject<ObservableCollection<ThuocNghiNgoGayADR>>(ds.Tables[0].Rows[0]["ListThuocADR"].ToString());
            ObservableCollection<KetQuaSuDungThuoc> ListKetQua = JsonConvert.DeserializeObject<ObservableCollection<KetQuaSuDungThuoc>>(ds.Tables[0].Rows[0]["ListKetQua"].ToString());
            ObservableCollection<ThuocDongThoi> ListThuocDT = JsonConvert.DeserializeObject<ObservableCollection<ThuocDongThoi>>(ds.Tables[0].Rows[0]["ListThuocDT"].ToString());


            DataTable T1 = Common.ListToDataTable(ListThuocADR, "T1");
            ds.Tables.Add(T1);
            DataTable KQ = Common.ListToDataTable(ListKetQua, "KQ");
            ds.Tables.Add(KQ);
            DataTable T2 = Common.ListToDataTable(ListThuocDT, "T2");
            ds.Tables.Add(T2);


            return ds;

        }
    }
}
