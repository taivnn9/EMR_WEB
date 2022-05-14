using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class BangKiemTraTruocSATQTQ : ThongTinKy
    {
        public BangKiemTraTruocSATQTQ()
        {
            TableName = "BangKiemTraTruocSATQTQ";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BKTTSATQTQ;
            TenMauPhieu = DanhMucPhieu.BKTTSATQTQ.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public decimal ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Năm sinh")]
		public string NamSinh { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Yêu cầu siêu âm")]
        public string YeuCauSA { get; set; }
        [MoTaDuLieu("Mã bác sỹ")]
		public string MaBacSi { get; set; }
        [MoTaDuLieu("Họ tên bác sỹ")]
		public string BacSi { get; set; }
        [MoTaDuLieu("Mã điều dưỡng")]
		public string MaDieuDuong { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuong { get; set; }
        [MoTaDuLieu("Ngày làm siêu âm")]
        public DateTime? NgayLam { get; set; }

        public bool[] NuotNghenArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Nuốt nghẹn")]
        public string NuotNghen
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < NuotNghenArray.Length; i++)
                    temp += (NuotNghenArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NuotNghenArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Mô tả(nuốt nghẹn) nếu có")]
        public string NuotNghen_Text { get; set; }

        public bool[] NuotDauArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Nuốt đau")]
        public string NuotDau
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < NuotDauArray.Length; i++)
                    temp += (NuotDauArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NuotDauArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Mô tả(nuốt đau) nếu có")]
        public string NuotDau_Text { get; set; }

        public bool[] XuatHuyetArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Xuất huyết tiêu hoá trong vòng 3 tháng")]
        public string XuatHuyet
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < XuatHuyetArray.Length; i++)
                    temp += (XuatHuyetArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        XuatHuyetArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Mô tả(xuất huyết) nếu có")]
        public string XuatHuyet_Text { get; set; }

        public bool[] XaTriVungArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Xạ vi trùng trung thất")]
        public string XaTriVung
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < XaTriVungArray.Length; i++)
                    temp += (XaTriVungArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        XaTriVungArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Mô tả(xạ vi trùng) nếu có")]
        public string XaTriVung_Text { get; set; }

        public bool[] VanDeDSCArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Các vấn đề liên quan đến cột sống cổ")]
        public string VanDeDSC
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < VanDeDSCArray.Length; i++)
                    temp += (VanDeDSCArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        VanDeDSCArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Mô tả(các vấn đề liên quan đến cột sống cổ) nếu có")]
        public string VanDeDSC_Text { get; set; }

        public bool[] ChanThuongLNArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Chấn thương lồng ngực")]
        public string ChanThuongLN
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ChanThuongLNArray.Length; i++)
                    temp += (ChanThuongLNArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ChanThuongLNArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Mô tả(chấn thương lồng ngực) nếu có")]

        public string ChanThuongLN_Text { get; set; }

        public bool[] PhauThuatDDArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Phẫu thuật dạ dày ruột")]
        public string PhauThuatDD
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < PhauThuatDDArray.Length; i++)
                    temp += (PhauThuatDDArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        PhauThuatDDArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Mô tả(phẫu thuật dạ dày) nếu có")]
        public string PhauThuatDD_Text { get; set; }
        public bool[] LamNoiSoiArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("làm nội soi mới đây")]
        public string LamNoiSoi
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < LamNoiSoiArray.Length; i++)
                    temp += (LamNoiSoiArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        LamNoiSoiArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Mô tả(làm nội soi) nếu có")]
        public string LamNoiSoi_Text { get; set; }
        public bool[] ThuocDangSDArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Thuốc đang sử dụng")]
        public string ThuocDangSD
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ThuocDangSDArray.Length; i++)
                    temp += (ThuocDangSDArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ThuocDangSDArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Mô tả(thuốc đang sử dụng) nếu có")]
        public string ThuocDangSD_Text { get; set; }
        public bool[] XetNghiemMauArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Xét nghiệm máu")]
        public string XetNghiemMau
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < XetNghiemMauArray.Length; i++)
                    temp += (XetNghiemMauArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        XetNghiemMauArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Mô tả(xét nghiệm máu) nếu có")]
        public string XetNghiemMau_Text { get; set; }
        public bool[] DiUngThuocArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Dị ứng thuốc")]
        public string DiUngThuoc
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < DiUngThuocArray.Length; i++)
                    temp += (DiUngThuocArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DiUngThuocArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Mô tả(dị ứng thuốc) nếu có")]
        public string DiUngThuoc_Text { get; set; }
        public bool[] TienSuNghienRuouArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Tiền sử nghiện rượu")]
        public string TienSuNghienRuou
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TienSuNghienRuouArray.Length; i++)
                    temp += (TienSuNghienRuouArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TienSuNghienRuouArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Mô tả(tiền sử nghiện rượu) nếu có")]
        public string TienSuNghienRuou_Text { get; set; }
        public bool[] TienSuBiTieuArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Tiền sử bí tiểu")]
        public string TienSuBiTieu
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TienSuBiTieuArray.Length; i++)
                    temp += (TienSuBiTieuArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TienSuBiTieuArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Mô tả(tiền sử bí tiểu) nếu có")]
        public string TienSuBiTieu_Text { get; set; }
        public bool[] TienSuTangNhanArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Tiền sử tăng nhãn áp góc hẹp")]
        public string TienSuTangNhan
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TienSuTangNhanArray.Length; i++)
                    temp += (TienSuTangNhanArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TienSuTangNhanArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Mổ tả(tiền sử tăng nhãn áp góc hẹp) nếu có")]
        public string TienSuTangNhan_Text { get; set; }
        public bool[] TienSuHenArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Tiền sử hen phế quản")]
        public string TienSuHen
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TienSuHenArray.Length; i++)
                    temp += (TienSuHenArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TienSuHenArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Mô tả(tiển sử hen phế quản) nếu có")]
        public string TienSuHen_Text { get; set; }
        [MoTaDuLieu("Mạch trước khi thủ thuật")]
        public string Mach_TruocTT { get; set; }
        [MoTaDuLieu("Huyết áp trước khi thủ thuật")]
        public string HA_TruocTT { get; set; }
        [MoTaDuLieu("Nhiệt độ trước khi thủ thuật")]
		public string NhietDo_TruocTT { get; set; }
        [MoTaDuLieu("SpO2 trước khi thủ thuật")]
        public string SpO2_TruocTT { get; set; }
        public bool[] RangMiengArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Răng miệng, sự di động và độ lệch của cổ họng, tháo răng giả có thể tháo lắp được")]
        public string RangMieng
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < RangMiengArray.Length; i++)
                    temp += (RangMiengArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        RangMiengArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Mô tả(răng miệng...)")]
        public string RangMieng_Text { get; set; }
        public bool[] DanhGiaDuongThoArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Đánh giá đường thở cho việc đặt nội khí quản nếu có và cần khi xảy ra tai biến")]
        public string DanhGiaDuongTho
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < DanhGiaDuongThoArray.Length; i++)
                    temp += (DanhGiaDuongThoArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DanhGiaDuongThoArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Mô tả(đánh giá đường thở...)nếu có")]
        public string DanhGiaDuongTho_Text { get; set; }
        public bool[] TinhTrangNhinAnArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Tình trạng nhịn ăn(Ăn trong vòng 6h / uống nước lọc trong vòng 2h.)")]
        public string TinhTrangNhinAn
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TinhTrangNhinAnArray.Length; i++)
                    temp += (TinhTrangNhinAnArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TinhTrangNhinAnArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Mô tả(tình trạng nhịn ăn) nếu có")]
        public string TinhTrangNhinAn_Text { get; set; }
        public bool[] GiaiThichArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Giải thích và ký cam kết làm thủ thuật")]
        public string GiaiThich
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < GiaiThichArray.Length; i++)
                    temp += (GiaiThichArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        GiaiThichArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Mô tả(giải thích) nếu có")]
        public string GiaiThich_Text { get; set; }
        [MoTaDuLieu("Huyết áp trong thủ thuật")]
        public string HA_TrongTT { get; set; }
        [MoTaDuLieu("Điện tim trong thủ thuật")]
        public string DienTim_TrongTT { get; set; }
        [MoTaDuLieu("SpO2 trong thủ thuật")]
        public string SpO2_TrongTT { get; set; }
        [MoTaDuLieu("Huyết áp sau thủ thuật")]
        public string HA_SauTT { get; set; }
        [MoTaDuLieu("Điện tim sau thủ thuật")]
        public string DienTim_SauTT { get; set; }
        [MoTaDuLieu("SpO2 sau thủ thuật")]
        public string SpO2_SauTT { get; set; }
        public bool[] DatDuongTruyenTMArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Đặt đường truyền tĩnh mạch")]
        public string DatDuongTruyenTM
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < DatDuongTruyenTMArray.Length; i++)
                    temp += (DatDuongTruyenTMArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DatDuongTruyenTMArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Mô tả(đặt đường truyền tĩnh mạch) nếu có")]
        public string DatDuongTruyenTM_Text { get; set; }
        public bool[] DungCuHoiSucArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Dụng cụ hồi sức cấp cứu và máy hút đờm nhớt")]
        public string DungCuHoiSuc
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < DungCuHoiSucArray.Length; i++)
                    temp += (DungCuHoiSucArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DungCuHoiSucArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Mô tả(Dụng cụ hồi sức cấp cứu và máy hút đờm nhớt) nếu có")]
        public string DungCuHoiSuc_Text { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Ngày ký")]
		public DateTime NgayKi { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        //public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
    }
    public class BangKiemTraTruocSATQTQFunc
    {

        public const string TableName = "BangKiemTraTruocSATQTQ";
        public const string TablePrimaryKeyName = "ID";

        public static bool Delete(MDB.MDBConnection MyConnection, decimal id)
        {
            try
            {
                string sql = "DELETE FROM BangKiemTraTruocSATQTQ WHERE ID = :ID";
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

        public static List<BangKiemTraTruocSATQTQ> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BangKiemTraTruocSATQTQ> list = new List<BangKiemTraTruocSATQTQ>();
            try
            {
                string sql = @"SELECT * FROM BangKiemTraTruocSATQTQ where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    BangKiemTraTruocSATQTQ data = new BangKiemTraTruocSATQTQ();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;

                    data.TenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.NamSinh = XemBenhAn._HanhChinhBenhNhan.NgaySinh?.Year.ToString();
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.YeuCauSA = DataReader["YeuCauSA"].ToString();
                    data.MaBacSi = DataReader["MaBacSi"].ToString();
                    data.BacSi = DataReader["BacSi"].ToString();
                    data.MaDieuDuong = DataReader["MaDieuDuong"].ToString();
                    data.DieuDuong = DataReader["DieuDuong"].ToString();
                    data.NgayLam = Convert.ToDateTime(DataReader["NgayLam"] == DBNull.Value ? DateTime.Now : DataReader["NgayLam"]);

                    data.NuotNghen = DataReader["NuotNghen"].ToString();
                    data.NuotNghen_Text = DataReader["NuotNghen_Text"].ToString();
                    data.NuotDau = DataReader["NuotDau"].ToString();
                    data.NuotDau_Text = DataReader["NuotDau_Text"].ToString();
                    data.XuatHuyet = DataReader["XuatHuyet"].ToString();
                    data.XuatHuyet_Text = DataReader["XuatHuyet_Text"].ToString();
                    data.XaTriVung = DataReader["XaTriVung"].ToString();
                    data.XaTriVung_Text = DataReader["XaTriVung_Text"].ToString();
                    data.VanDeDSC = DataReader["VanDeDSC"].ToString();
                    data.VanDeDSC_Text = DataReader["VanDeDSC_Text"].ToString();
                    data.ChanThuongLN = DataReader["ChanThuongLN"].ToString();
                    data.ChanThuongLN_Text = DataReader["ChanThuongLN_Text"].ToString();
                    data.PhauThuatDD = DataReader["PhauThuatDD"].ToString();
                    data.PhauThuatDD_Text = DataReader["PhauThuatDD_Text"].ToString();
                    data.LamNoiSoi = DataReader["LamNoiSoi"].ToString();
                    data.LamNoiSoi_Text = DataReader["LamNoiSoi_Text"].ToString();
                    data.ThuocDangSD = DataReader["ThuocDangSD"].ToString();
                    data.ThuocDangSD_Text = DataReader["ThuocDangSD_Text"].ToString();
                    data.XetNghiemMau = DataReader["XetNghiemMau"].ToString();
                    data.XetNghiemMau_Text = DataReader["XetNghiemMau_Text"].ToString();
                    data.DiUngThuoc = DataReader["DiUngThuoc"].ToString();
                    data.DiUngThuoc_Text = DataReader["DiUngThuoc_Text"].ToString();
                    data.TienSuNghienRuou = DataReader["TienSuNghienRuou"].ToString();
                    data.TienSuNghienRuou_Text = DataReader["TienSuNghienRuou_Text"].ToString();
                    data.TienSuBiTieu = DataReader["TienSuBiTieu"].ToString();
                    data.TienSuBiTieu_Text = DataReader["TienSuBiTieu_Text"].ToString();
                    data.TienSuTangNhan = DataReader["TienSuTangNhan"].ToString();
                    data.TienSuTangNhan_Text = DataReader["TienSuTangNhan_Text"].ToString();
                    data.TienSuHen = DataReader["TienSuHen"].ToString();
                    data.TienSuHen_Text = DataReader["TienSuHen_Text"].ToString();
                    data.Mach_TruocTT = DataReader["Mach_TruocTT"].ToString();
                    data.HA_TruocTT = DataReader["HA_TruocTT"].ToString();
                    data.NhietDo_TruocTT = DataReader["NhietDo_TruocTT"].ToString();
                    data.SpO2_TruocTT = DataReader["SpO2_TruocTT"].ToString();
                    data.RangMieng = DataReader["RangMieng"].ToString();
                    data.RangMieng_Text = DataReader["RangMieng_Text"].ToString();
                    data.DanhGiaDuongTho = DataReader["DanhGiaDuongTho"].ToString();
                    data.DanhGiaDuongTho_Text = DataReader["DanhGiaDuongTho_Text"].ToString();
                    data.TinhTrangNhinAn = DataReader["TinhTrangNhinAn"].ToString();
                    data.TinhTrangNhinAn_Text = DataReader["TinhTrangNhinAn_Text"].ToString();
                    data.GiaiThich = DataReader["GiaiThich"].ToString();
                    data.GiaiThich_Text = DataReader["GiaiThich_Text"].ToString();
                    data.HA_TrongTT = DataReader["HA_TrongTT"].ToString();
                    data.DienTim_TrongTT = DataReader["DienTim_TrongTT"].ToString();
                    data.SpO2_TrongTT = DataReader["SpO2_TrongTT"].ToString();
                    data.HA_SauTT = DataReader["HA_SauTT"].ToString();
                    data.DienTim_SauTT = DataReader["DienTim_SauTT"].ToString();
                    data.SpO2_SauTT = DataReader["SpO2_SauTT"].ToString();
                    data.DatDuongTruyenTM = DataReader["DatDuongTruyenTM"].ToString();
                    data.DatDuongTruyenTM_Text = DataReader["DatDuongTruyenTM_Text"].ToString();
                    data.DungCuHoiSuc = DataReader["DungCuHoiSuc"].ToString();
                    data.DungCuHoiSuc_Text = DataReader["DungCuHoiSuc_Text"].ToString();

                    data.NgayTao = Convert.ToDateTime(DataReader["NGAYTAO"] == DBNull.Value ? DateTime.Now : DataReader["NGAYTAO"]);
                    data.NguoiTao = DataReader["NGUOITAO"].ToString();
                    data.NgaySua = Convert.ToDateTime(DataReader["NGAYSUA"] == DBNull.Value ? DateTime.Now : DataReader["NGAYSUA"]);
                    data.NguoiSua = DataReader["NGUOISUA"].ToString();

                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;
                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, string IDBienBan)
        {
            string sql = @"SELECT
                P.* 
            FROM
                BangKiemTraTruocSATQTQ P
            WHERE
                ID = " + IDBienBan;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "TB");

            ds.Tables[0].AddColumn("BenhVien", typeof(string));
            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("NamSinh", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(string));
            ds.Tables[0].AddColumn("SoYTe", typeof(string));

            ds.Tables[0].Rows[0]["BenhVien"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["SoYTe"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["NamSinh"] = XemBenhAn._HanhChinhBenhNhan.NgaySinh?.Year.ToString();
            ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();

            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, BangKiemTraTruocSATQTQ ketQua)
        {
            try
            {
                string sql = @"INSERT INTO BangKiemTraTruocSATQTQ
                (
                    MaQuanLy,
                    ChanDoan,
                    YeuCauSA,
                    MaBacSi,
                    BacSi,
                    MaDieuDuong,
                    DieuDuong,
                    NgayLam,
                    NuotNghen,
                    NuotNghen_Text,
                    NuotDau,
                    NuotDau_Text,
                    XuatHuyet,
                    XuatHuyet_Text,
                    XaTriVung,
                    XaTriVung_Text,
                    VanDeDSC,
                    VanDeDSC_Text,
                    ChanThuongLN,
                    ChanThuongLN_Text,
                    PhauThuatDD,
                    PhauThuatDD_Text,
                    LamNoiSoi,
                    LamNoiSoi_Text,
                    ThuocDangSD,
                    ThuocDangSD_Text,
                    XetNghiemMau,
                    XetNghiemMau_Text,
                    DiUngThuoc,
                    DiUngThuoc_Text,
                    TienSuNghienRuou,
                    TienSuNghienRuou_Text,
                    TienSuBiTieu,
                    TienSuBiTieu_Text,
                    TienSuTangNhan,
                    TienSuTangNhan_Text,
                    TienSuHen,
                    TienSuHen_Text,
                    Mach_TruocTT,
                    HA_TruocTT,
                    NhietDo_TruocTT,
                    SpO2_TruocTT,
                    RangMieng,
                    RangMieng_Text,
                    DanhGiaDuongTho,
                    DanhGiaDuongTho_Text,
                    TinhTrangNhinAn,
                    TinhTrangNhinAn_Text,
                    GiaiThich,
                    GiaiThich_Text,
                    HA_TrongTT,
                    DienTim_TrongTT,
                    SpO2_TrongTT,
                    HA_SauTT,
                    DienTim_SauTT,
                    SpO2_SauTT,
                    DatDuongTruyenTM,
                    DatDuongTruyenTM_Text,
                    DungCuHoiSuc,
                    DungCuHoiSuc_Text,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
                    :ChanDoan,
                    :YeuCauSA,
                    :MaBacSi,
                    :BacSi,
                    :MaDieuDuong,
                    :DieuDuong,
                    :NgayLam,
                    :NuotNghen,
                    :NuotNghen_Text,
                    :NuotDau,
                    :NuotDau_Text,
                    :XuatHuyet,
                    :XuatHuyet_Text,
                    :XaTriVung,
                    :XaTriVung_Text,
                    :VanDeDSC,
                    :VanDeDSC_Text,
                    :ChanThuongLN,
                    :ChanThuongLN_Text,
                    :PhauThuatDD,
                    :PhauThuatDD_Text,
                    :LamNoiSoi,
                    :LamNoiSoi_Text,
                    :ThuocDangSD,
                    :ThuocDangSD_Text,
                    :XetNghiemMau,
                    :XetNghiemMau_Text,
                    :DiUngThuoc,
                    :DiUngThuoc_Text,
                    :TienSuNghienRuou,
                    :TienSuNghienRuou_Text,
                    :TienSuBiTieu,
                    :TienSuBiTieu_Text,
                    :TienSuTangNhan,
                    :TienSuTangNhan_Text,
                    :TienSuHen,
                    :TienSuHen_Text,
                    :Mach_TruocTT,
                    :HA_TruocTT,
                    :NhietDo_TruocTT,
                    :SpO2_TruocTT,
                    :RangMieng,
                    :RangMieng_Text,
                    :DanhGiaDuongTho,
                    :DanhGiaDuongTho_Text,
                    :TinhTrangNhinAn,
                    :TinhTrangNhinAn_Text,
                    :GiaiThich,
                    :GiaiThich_Text,
                    :HA_TrongTT,
                    :DienTim_TrongTT,
                    :SpO2_TrongTT,
                    :HA_SauTT,
                    :DienTim_SauTT,
                    :SpO2_SauTT,
                    :DatDuongTruyenTM,
                    :DatDuongTruyenTM_Text,
                    :DungCuHoiSuc,
                    :DungCuHoiSuc_Text,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE BangKiemTraTruocSATQTQ SET 
                    MaQuanLy = :MaQuanLy,
                    ChanDoan = :ChanDoan,
                    YeuCauSA = :YeuCauSA,
                    MaBacSi = :MaBacSi,
                    BacSi = :BacSi,
                    MaDieuDuong = :MaDieuDuong,
                    DieuDuong = :DieuDuong,
                    NgayLam = :NgayLam,
                    NuotNghen = :NuotNghen,
                    NuotNghen_Text = :NuotNghen_Text,
                    NuotDau = :NuotDau,
                    NuotDau_Text = :NuotDau_Text,
                    XuatHuyet = :XuatHuyet,
                    XuatHuyet_Text = :XuatHuyet_Text,
                    XaTriVung = :XaTriVung,
                    XaTriVung_Text = :XaTriVung_Text,
                    VanDeDSC = :VanDeDSC,
                    VanDeDSC_Text = :VanDeDSC_Text,
                    ChanThuongLN = :ChanThuongLN,
                    ChanThuongLN_Text = :ChanThuongLN_Text,
                    PhauThuatDD = :PhauThuatDD,
                    PhauThuatDD_Text = :PhauThuatDD_Text,
                    LamNoiSoi = :LamNoiSoi,
                    LamNoiSoi_Text = :LamNoiSoi_Text,
                    ThuocDangSD = :ThuocDangSD,
                    ThuocDangSD_Text = :ThuocDangSD_Text,
                    XetNghiemMau = :XetNghiemMau,
                    XetNghiemMau_Text = :XetNghiemMau_Text,
                    DiUngThuoc = :DiUngThuoc,
                    DiUngThuoc_Text = :DiUngThuoc_Text,
                    TienSuNghienRuou = :TienSuNghienRuou,
                    TienSuNghienRuou_Text = :TienSuNghienRuou_Text,
                    TienSuBiTieu = :TienSuBiTieu,
                    TienSuBiTieu_Text = :TienSuBiTieu_Text,
                    TienSuTangNhan = :TienSuTangNhan,
                    TienSuTangNhan_Text = :TienSuTangNhan_Text,
                    TienSuHen = :TienSuHen,
                    TienSuHen_Text = :TienSuHen_Text,
                    Mach_TruocTT = :Mach_TruocTT,
                    HA_TruocTT = :HA_TruocTT,
                    NhietDo_TruocTT = :NhietDo_TruocTT,
                    SpO2_TruocTT = :SpO2_TruocTT,
                    RangMieng = :RangMieng,
                    RangMieng_Text = :RangMieng_Text,
                    DanhGiaDuongTho = :DanhGiaDuongTho,
                    DanhGiaDuongTho_Text= :DanhGiaDuongTho_Text,
                    TinhTrangNhinAn = :TinhTrangNhinAn,
                    TinhTrangNhinAn_Text = :TinhTrangNhinAn_Text,
                    GiaiThich = :GiaiThich,
                    GiaiThich_Text = :GiaiThich_Text,
                    HA_TrongTT = :HA_TrongTT,
                    DienTim_TrongTT = :DienTim_TrongTT,
                    SpO2_TrongTT = :SpO2_TrongTT,
                    HA_SauTT = :HA_SauTT,
                    DienTim_SauTT = :DienTim_SauTT,
                    SpO2_SauTT = :SpO2_SauTT,
                    DatDuongTruyenTM = :DatDuongTruyenTM,
                    DatDuongTruyenTM_Text = :DatDuongTruyenTM_Text,
                    DungCuHoiSuc = :DungCuHoiSuc,
                    DungCuHoiSuc_Text = :DungCuHoiSuc_Text,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", ketQua.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("YeuCauSA", ketQua.YeuCauSA));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSi", ketQua.MaBacSi));
                Command.Parameters.Add(new MDB.MDBParameter("BacSi", ketQua.BacSi));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuong", ketQua.MaDieuDuong));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuong", ketQua.DieuDuong));
                Command.Parameters.Add(new MDB.MDBParameter("NgayLam", ketQua.NgayLam));
                Command.Parameters.Add(new MDB.MDBParameter("NuotNghen", ketQua.NuotNghen));
                Command.Parameters.Add(new MDB.MDBParameter("NuotNghen_Text", ketQua.NuotNghen_Text));
                Command.Parameters.Add(new MDB.MDBParameter("NuotDau", ketQua.NuotDau));
                Command.Parameters.Add(new MDB.MDBParameter("NuotDau_Text", ketQua.NuotDau_Text));
                Command.Parameters.Add(new MDB.MDBParameter("XuatHuyet", ketQua.XuatHuyet));
                Command.Parameters.Add(new MDB.MDBParameter("XuatHuyet_Text", ketQua.XuatHuyet_Text));
                Command.Parameters.Add(new MDB.MDBParameter("XaTriVung", ketQua.XaTriVung));
                Command.Parameters.Add(new MDB.MDBParameter("XaTriVung_Text", ketQua.XaTriVung_Text));
                Command.Parameters.Add(new MDB.MDBParameter("VanDeDSC", ketQua.VanDeDSC));
                Command.Parameters.Add(new MDB.MDBParameter("VanDeDSC_Text", ketQua.VanDeDSC_Text));
                Command.Parameters.Add(new MDB.MDBParameter("ChanThuongLN", ketQua.ChanThuongLN));
                Command.Parameters.Add(new MDB.MDBParameter("ChanThuongLN_Text", ketQua.ChanThuongLN_Text));
                Command.Parameters.Add(new MDB.MDBParameter("PhauThuatDD", ketQua.PhauThuatDD));
                Command.Parameters.Add(new MDB.MDBParameter("PhauThuatDD_Text", ketQua.PhauThuatDD_Text));
                Command.Parameters.Add(new MDB.MDBParameter("LamNoiSoi", ketQua.LamNoiSoi));
                Command.Parameters.Add(new MDB.MDBParameter("LamNoiSoi_Text", ketQua.LamNoiSoi_Text));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocDangSD", ketQua.ThuocDangSD));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocDangSD_Text", ketQua.ThuocDangSD_Text));
                Command.Parameters.Add(new MDB.MDBParameter("XetNghiemMau", ketQua.XetNghiemMau));
                Command.Parameters.Add(new MDB.MDBParameter("XetNghiemMau_Text", ketQua.XetNghiemMau_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DiUngThuoc", ketQua.DiUngThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("DiUngThuoc_Text", ketQua.DiUngThuoc_Text));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuNghienRuou", ketQua.TienSuNghienRuou));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuNghienRuou_Text", ketQua.TienSuNghienRuou_Text));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuBiTieu", ketQua.TienSuBiTieu));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuBiTieu_Text", ketQua.TienSuBiTieu_Text));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuTangNhan", ketQua.TienSuTangNhan));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuTangNhan_Text", ketQua.TienSuTangNhan_Text));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuHen", ketQua.TienSuHen));
                Command.Parameters.Add(new MDB.MDBParameter("TienSuHen_Text", ketQua.TienSuHen_Text));
                Command.Parameters.Add(new MDB.MDBParameter("Mach_TruocTT", ketQua.Mach_TruocTT));
                Command.Parameters.Add(new MDB.MDBParameter("HA_TruocTT", ketQua.HA_TruocTT));
                Command.Parameters.Add(new MDB.MDBParameter("NhietDo_TruocTT", ketQua.NhietDo_TruocTT));
                Command.Parameters.Add(new MDB.MDBParameter("SpO2_TruocTT", ketQua.SpO2_TruocTT));
                Command.Parameters.Add(new MDB.MDBParameter("RangMieng", ketQua.RangMieng));
                Command.Parameters.Add(new MDB.MDBParameter("RangMieng_Text", ketQua.RangMieng_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DanhGiaDuongTho", ketQua.DanhGiaDuongTho));
                Command.Parameters.Add(new MDB.MDBParameter("DanhGiaDuongTho_Text", ketQua.DanhGiaDuongTho_Text));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangNhinAn", ketQua.TinhTrangNhinAn));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangNhinAn_Text", ketQua.TinhTrangNhinAn_Text));
                Command.Parameters.Add(new MDB.MDBParameter("GiaiThich", ketQua.GiaiThich));
                Command.Parameters.Add(new MDB.MDBParameter("GiaiThich_Text", ketQua.GiaiThich_Text));
                Command.Parameters.Add(new MDB.MDBParameter("HA_TrongTT", ketQua.HA_TrongTT));
                Command.Parameters.Add(new MDB.MDBParameter("DienTim_TrongTT", ketQua.DienTim_TrongTT));
                Command.Parameters.Add(new MDB.MDBParameter("SpO2_TrongTT", ketQua.SpO2_TrongTT));
                Command.Parameters.Add(new MDB.MDBParameter("HA_SauTT", ketQua.HA_SauTT));
                Command.Parameters.Add(new MDB.MDBParameter("DienTim_SauTT", ketQua.DienTim_SauTT));
                Command.Parameters.Add(new MDB.MDBParameter("SpO2_SauTT", ketQua.SpO2_SauTT));
                Command.Parameters.Add(new MDB.MDBParameter("DatDuongTruyenTM", ketQua.DatDuongTruyenTM));
                Command.Parameters.Add(new MDB.MDBParameter("DatDuongTruyenTM_Text", ketQua.DatDuongTruyenTM_Text));
                Command.Parameters.Add(new MDB.MDBParameter("DungCuHoiSuc", ketQua.DungCuHoiSuc));
                Command.Parameters.Add(new MDB.MDBParameter("DungCuHoiSuc_Text", ketQua.DungCuHoiSuc_Text));

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
                XuLyLoi.LogError(ex);
            }
            return false;
        }
    }
}
