using EMR_MAIN.Converter;
using Newtonsoft.Json;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMR.KyDienTu;

namespace EMR_MAIN.DATABASE.Other
{   
    public class TrichBienBanHoiChan : ThongTinKy
    {
        public TrichBienBanHoiChan()
        {
            TableName = "TRICHBIENBANHOICHAN";
            TablePrimaryKeyName = "IDBienBanHoiChan";
            IDMauPhieu = (int)DanhMucPhieu.TBBHC;
            TenMauPhieu = DanhMucPhieu.TBBHC.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public decimal IDBienBanHoiChan { get; set; }
        // phan hanh chinh
        public string BacSyTruongKhoa { get; set; }
        public string MaBacSyTruongKhoa { get; set; }
        public bool LyDoHC_ChanDoanKho { get; set; }
        public bool LyDoHC_TienLuongDeDat { get; set; }
        public bool LyDoHC_CapCuu { get; set; }
        public bool LyDoHC_ChiDinhPhauThuat { get; set; }
        public DateTime NgayHoiChan { get; set; }
        public DateTime? NgayHoiChan_Gio { get; set; }
        public ObservableCollection<NhanVien> DanhSachHoiChan { get; set; }
        public string HopTai { get; set; }
        public string ChuToa { get; set; }
        public string MaChuToa { get; set; }
        public string ThuKy { get; set; }
        public string MaThuKy { get; set; }
        // noi dung hoi chan
        // Hanh chinh benh nhan
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        public string SoHoChieu { get; set; }
        public string NgayVaNoiCap { get; set; }
        public string YeuCauHoiChan { get; set; }
        // dien bien benh
        public string TomTatBenhSu { get; set; }
        public string TinhTrangLucVaoVien { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh tuyến dưới")]
		public string ChanDoanTuyenDuoi { get; set; }
        public string TomTatDienBien { get; set; }
        // y kien thong nhat
        [MoTaDuLieu("Chẩn đoán nguyên nhân")]
		public string ChanDoanNguyenNhan { get; set; }
        public string PhuongPhapDieuTri { get; set; }
        public string ChamSoc { get; set; }
        public string KetLuan { get; set; }
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
    }
    public class TrichBienBanHoiChanFunc
    {
        public const string TableName = "TRICHBIENBANHOICHAN";
        public const string TablePrimaryKeyName = "IDBienBanHoiChan";
        public static List<TrichBienBanHoiChan> getData(decimal maQuanLy, MDB.MDBConnection _OracleConnection)
        {
            List<TrichBienBanHoiChan> lstData = new List<TrichBienBanHoiChan>();
            try
            {
                string sql = @"SELECT * FROM TRICHBIENBANHOICHAN where MaQuanLy = :MaQuanLy and XOA = 0";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maQuanLy));
                Command.BindByName = true;
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    TrichBienBanHoiChan data = new TrichBienBanHoiChan();
                    data.IDBienBanHoiChan = Convert.ToInt64(DataReader.GetLong("IDBienBanHoiChan").ToString());
                    data.BacSyTruongKhoa = DataReader["BacSyTruongKhoa"].ToString();
                    data.MaBacSyTruongKhoa = DataReader["MaBacSyTruongKhoa"].ToString();
                    int temp = 0;
                    int.TryParse(DataReader["LyDoHC_ChanDoanKho"].ToString(), out temp);
                    data.LyDoHC_ChanDoanKho = temp == 1 ? true : false;

                    temp = 0;
                    int.TryParse(DataReader["LyDoHC_TienLuongDeDat"].ToString(), out temp);
                    data.LyDoHC_TienLuongDeDat = temp == 1 ? true : false;

                    temp = 0;
                    int.TryParse(DataReader["LyDoHC_CapCuu"].ToString(), out temp);
                    data.LyDoHC_CapCuu = temp == 1 ? true : false;

                    temp = 0;
                    int.TryParse(DataReader["LyDoHC_ChiDinhPhauThuat"].ToString(), out temp);
                    data.LyDoHC_ChiDinhPhauThuat = temp == 1 ? true : false;
                    data.NgayHoiChan = Convert.ToDateTime(DataReader["NgayHoiChan"] == DBNull.Value ? DateTime.Now : DataReader["NgayHoiChan"]);
                    data.DanhSachHoiChan = JsonConvert.DeserializeObject<ObservableCollection<NhanVien>>(DataReader["DanhSachHoiChan"].ToString());
                    data.HopTai = DataReader["HopTai"].ToString();
                    data.ChuToa = DataReader["ChuToa"].ToString();
                    data.MaChuToa = DataReader["MaChuToa"].ToString();
                    data.ThuKy = DataReader["ThuKy"].ToString();
                    data.MaThuKy = DataReader["MaThuKy"].ToString();
                    data.MaQuanLy = maQuanLy;
                    data.SoHoChieu = DataReader["SoHoChieu"].ToString();
                    data.NgayVaNoiCap = DataReader["NgayVaNoiCap"].ToString();
                    data.YeuCauHoiChan = DataReader["YeuCauHoiChan"].ToString();
                    data.TomTatBenhSu = DataReader["TomTatBenhSu"].ToString();
                    data.TinhTrangLucVaoVien = DataReader["TinhTrangLucVaoVien"].ToString();
                    data.ChanDoanTuyenDuoi = DataReader["ChanDoanTuyenDuoi"].ToString();
                    data.TomTatDienBien = DataReader["TomTatDienBien"].ToString();
                    data.ChanDoanNguyenNhan = DataReader["ChanDoanNguyenNhan"].ToString();
                    data.PhuongPhapDieuTri = DataReader["PhuongPhapDieuTri"].ToString();
                    data.ChamSoc = DataReader["ChamSoc"].ToString();
                    data.KetLuan = DataReader["KetLuan"].ToString();

                    data.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                    data.NguoiTao = DataReader["NguoiTao"].ToString();
                    data.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);
                    data.NguoiSua = DataReader["NguoiSua"].ToString();
                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;

                    lstData.Add(data);
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return lstData;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref TrichBienBanHoiChan bienBanHoiChan)
        {
            string sql = @"INSERT INTO TRICHBIENBANHOICHAN
                (
                    BACSYTRUONGKHOA,
                    MABACSYTRUONGKHOA,
                    LYDOHC_CHANDOANKHO,
                    LYDOHC_TIENLUONGDEDAT,
                    LYDOHC_CAPCUU,
                    LYDOHC_CHIDINHPHAUTHUAT,
                    NGAYHOICHAN,
                    DANHSACHHOICHAN,
                    HOPTAI,
                    CHUTOA,
                    MACHUTOA,
                    THUKY,
                    MATHUKY,
                    MAQUANLY,
                    SOHOCHIEU,
                    NGAYVANOICAP,
                    YEUCAUHOICHAN,
                    TOMTATBENHSU,
                    TINHTRANGLUCVAOVIEN,
                    CHANDOANTUYENDUOI,
                    TOMTATDIENBIEN,
                    CHANDOANNGUYENNHAN,
                    PHUONGPHAPDIEUTRI,
                    CHAMSOC,
                    KETLUAN,
                    XOA,
                    NGUOITAO,
                    NGAYTAO,
                    NGUOISUA,
                    NGAYSUA)  VALUES
                 (
                    :BACSYTRUONGKHOA,
                    :MABACSYTRUONGKHOA,
                    :LYDOHC_CHANDOANKHO,
                    :LYDOHC_TIENLUONGDEDAT,
                    :LYDOHC_CAPCUU,
                    :LYDOHC_CHIDINHPHAUTHUAT,
                    :NGAYHOICHAN,
                    :DANHSACHHOICHAN,
                    :HOPTAI,
                    :CHUTOA,
                    :MACHUTOA,
                    :THUKY,
                    :MATHUKY,
                    :MAQUANLY,
                    :SOHOCHIEU,
                    :NGAYVANOICAP,
                    :YEUCAUHOICHAN,
                    :TOMTATBENHSU,
                    :TINHTRANGLUCVAOVIEN,
                    :CHANDOANTUYENDUOI,
                    :TOMTATDIENBIEN,
                    :CHANDOANNGUYENNHAN,
                    :PHUONGPHAPDIEUTRI,
                    :CHAMSOC,
                    :KETLUAN,
                    0,
                    :NGUOITAO,
                    :NGAYTAO,
                    :NGUOISUA,
                    :NGAYSUA
                )  RETURNING IDBIENBANHOICHAN INTO :IDBIENBANHOICHAN";
            if (bienBanHoiChan.IDBienBanHoiChan != Decimal.Zero)
            {
                sql = @"UPDATE TRICHBIENBANHOICHAN SET 
                    BACSYTRUONGKHOA = :BACSYTRUONGKHOA, 
                    MABACSYTRUONGKHOA = :MABACSYTRUONGKHOA, 
                    LYDOHC_CHANDOANKHO = :LYDOHC_CHANDOANKHO,
                    LYDOHC_TIENLUONGDEDAT = :LYDOHC_TIENLUONGDEDAT,
                    LYDOHC_CAPCUU = :LYDOHC_CAPCUU,
                    LYDOHC_CHIDINHPHAUTHUAT = :LYDOHC_CHIDINHPHAUTHUAT,
                    NGAYHOICHAN = :NGAYHOICHAN,
                    DANHSACHHOICHAN = :DANHSACHHOICHAN,
                    HOPTAI = :HOPTAI,
                    CHUTOA = :CHUTOA,
                    MACHUTOA = :MACHUTOA,
                    THUKY = :THUKY,
                    MATHUKY = :MATHUKY,
                    MAQUANLY = :MAQUANLY,
                    SOHOCHIEU = :SOHOCHIEU,
                    NGAYVANOICAP = :NGAYVANOICAP,
                    YEUCAUHOICHAN = :YEUCAUHOICHAN,
                    TOMTATBENHSU = :TOMTATBENHSU,
                    TINHTRANGLUCVAOVIEN = :TINHTRANGLUCVAOVIEN,
                    CHANDOANTUYENDUOI = :CHANDOANTUYENDUOI,
                    TOMTATDIENBIEN = :TOMTATDIENBIEN,
                    CHANDOANNGUYENNHAN = :CHANDOANNGUYENNHAN,
                    PHUONGPHAPDIEUTRI = :PHUONGPHAPDIEUTRI,
                    KETLUAN = :KETLUAN,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE IDBIENBANHOICHAN = " + bienBanHoiChan.IDBienBanHoiChan;
            }
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("BACSYTRUONGKHOA", bienBanHoiChan.BacSyTruongKhoa));
            Command.Parameters.Add(new MDB.MDBParameter("MABACSYTRUONGKHOA", bienBanHoiChan.MaBacSyTruongKhoa));
            Command.Parameters.Add(new MDB.MDBParameter("LYDOHC_CHANDOANKHO", bienBanHoiChan.LyDoHC_ChanDoanKho ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("LYDOHC_TIENLUONGDEDAT", bienBanHoiChan.LyDoHC_TienLuongDeDat ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("LYDOHC_CAPCUU", bienBanHoiChan.LyDoHC_CapCuu ? 1 : 0));
            Command.Parameters.Add(new MDB.MDBParameter("LYDOHC_CHIDINHPHAUTHUAT", bienBanHoiChan.LyDoHC_ChiDinhPhauThuat ? 1 : 0));
            var Ngay = bienBanHoiChan.NgayHoiChan.Date.Add(new TimeSpan(0, 0, 0));
            var Gio = bienBanHoiChan.NgayHoiChan_Gio != null ? bienBanHoiChan.NgayHoiChan_Gio.Value.TimeOfDay : DateTime.Now.TimeOfDay;
            var ngayHoiChan = Ngay + Gio;
            Command.Parameters.Add(new MDB.MDBParameter("NGAYHOICHAN", ngayHoiChan));
            Command.Parameters.Add(new MDB.MDBParameter("DANHSACHHOICHAN", JsonConvert.SerializeObject(bienBanHoiChan.DanhSachHoiChan)));
            Command.Parameters.Add(new MDB.MDBParameter("HOPTAI", bienBanHoiChan.HopTai));
            Command.Parameters.Add(new MDB.MDBParameter("CHUTOA", bienBanHoiChan.ChuToa));
            Command.Parameters.Add(new MDB.MDBParameter("MACHUTOA", bienBanHoiChan.MaChuToa));
            Command.Parameters.Add(new MDB.MDBParameter("THUKY", bienBanHoiChan.ThuKy));
            Command.Parameters.Add(new MDB.MDBParameter("MATHUKY", bienBanHoiChan.MaThuKy));
            Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bienBanHoiChan.MaQuanLy));
            Command.Parameters.Add(new MDB.MDBParameter("SOHOCHIEU", bienBanHoiChan.SoHoChieu));
            Command.Parameters.Add(new MDB.MDBParameter("NGAYVANOICAP", bienBanHoiChan.NgayVaNoiCap));
            Command.Parameters.Add(new MDB.MDBParameter("YEUCAUHOICHAN", bienBanHoiChan.YeuCauHoiChan));
            Command.Parameters.Add(new MDB.MDBParameter("TOMTATBENHSU", bienBanHoiChan.TomTatBenhSu));
            Command.Parameters.Add(new MDB.MDBParameter("TINHTRANGLUCVAOVIEN", bienBanHoiChan.TinhTrangLucVaoVien));
            Command.Parameters.Add(new MDB.MDBParameter("CHANDOANTUYENDUOI", bienBanHoiChan.ChanDoanTuyenDuoi));
            Command.Parameters.Add(new MDB.MDBParameter("TOMTATDIENBIEN", bienBanHoiChan.TomTatDienBien));
            Command.Parameters.Add(new MDB.MDBParameter("CHANDOANNGUYENNHAN", bienBanHoiChan.ChanDoanNguyenNhan));
            Command.Parameters.Add(new MDB.MDBParameter("PHUONGPHAPDIEUTRI", bienBanHoiChan.PhuongPhapDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("CHAMSOC", bienBanHoiChan.ChamSoc));
            Command.Parameters.Add(new MDB.MDBParameter("KETLUAN", bienBanHoiChan.KetLuan));
            Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", bienBanHoiChan.NguoiSua));
            Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", bienBanHoiChan.NgaySua));
            if (bienBanHoiChan.IDBienBanHoiChan.Equals(Decimal.Zero))
            {
                Command.Parameters.Add(new MDB.MDBParameter("IDBIENBANHOICHAN", bienBanHoiChan.IDBienBanHoiChan));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", bienBanHoiChan.NguoiTao));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", bienBanHoiChan.NgayTao));
            }
            Command.BindByName = true;
            int n = Command.ExecuteNonQuery(); // C#
            if (bienBanHoiChan.IDBienBanHoiChan.Equals(Decimal.Zero))
            {
                decimal nextval = Convert.ToInt64((Command.Parameters["IDBIENBANHOICHAN"] as MDB.MDBParameter).Value);
                bienBanHoiChan.IDBienBanHoiChan = nextval;
            }

            return n > 0 ? true : false;
        }
        public static bool delete(MDB.MDBConnection MyConnection, decimal idBienBanhoiChan)
        {
            string sql = @"UPDATE TRICHBIENBANHOICHAN SET 
                    XOA = 1
                    WHERE IDBIENBANHOICHAN = " + idBienBanhoiChan;
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static DataSet getDataSet(MDB.MDBConnection MyConnection, decimal idBienBanHoiChan)
        {
            //var ds = new DataSet();
            // implement code here
            string sql = @"SELECT
                B.BACSYTRUONGKHOA,
                B.MABACSYTRUONGKHOA,
				B.LYDOHC_CHANDOANKHO,
				B.LYDOHC_TIENLUONGDEDAT,
				B.LYDOHC_CAPCUU,
				B.LYDOHC_CHIDINHPHAUTHUAT,
				B.NGAYHOICHAN,
				B.HOPTAI,
				B.CHUTOA,
                B.MACHUTOA,
				B.THUKY,
                B.MATHUKY,
				B.SOHOCHIEU,
				B.NGAYVANOICAP,
				B.YEUCAUHOICHAN,
				B.TOMTATBENHSU,
				B.TINHTRANGLUCVAOVIEN,
				B.CHANDOANTUYENDUOI,
				B.TOMTATDIENBIEN,
				B.CHANDOANNGUYENNHAN,
				B.PHUONGPHAPDIEUTRI,
				B.CHAMSOC,
				B.KETLUAN,
	            T.SONHAPVIEN,
	            T.NGAYVAOVIEN,
                T.TENKHOAVAO,
	            H.TENBENHNHAN,
	            H.TUOI,
	            H.GIOITINH,
				H.DANTOC,
				H.NGOAIKIEU,
				H.NGHENGHIEP,
				H.NOILAMVIEC,
				H.SOTHEBHYT,
				H.SONHA,
				H.THONPHO,
				H.XAPHUONG,
				H.HUYENQUAN,
				H.TINHTHANHPHO
            FROM
                TRICHBIENBANHOICHAN B
                JOIN THONGTINDIEUTRI T ON B.MAQUANLY = T.MAQUANLY
                JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
            WHERE
                IDBienBanHoiChan = " + idBienBanHoiChan;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            adt.Fill(ds,"HC");

            ds.Tables[0].AddColumn("NguoiThamGia", typeof(string));
            ds.Tables[0].AddColumn("MaNguoiThamGia", typeof(string));

            sql = @"SELECT DANHSACHHOICHAN FROM TRICHBIENBANHOICHAN where IDBienBanHoiChan = " + idBienBanHoiChan;
            Command = new MDB.MDBCommand(sql, MyConnection);
            Command.BindByName = true;
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            ObservableCollection<NhanVien> listDanhSach = new ObservableCollection<NhanVien>();
            while (DataReader.Read())
            {
                listDanhSach = JsonConvert.DeserializeObject<ObservableCollection<NhanVien>>(DataReader["DANHSACHHOICHAN"].ToString());
            }
           
            DataTable DanhSachHoiChan = new DataTable("DSHC");
            DanhSachHoiChan.Columns.Add("LIST1");
            DanhSachHoiChan.Columns.Add("LIST2");
            string NguoiThamGia = string.Empty;
            string MaNguoiThamGia = string.Empty;
            
            if (listDanhSach.Count >= 2)
            {
                for (int i = 0; i < listDanhSach.Count / 2; i++)
                {
                    NguoiThamGia += listDanhSach[i].HoVaTen + "\t  " + listDanhSach[listDanhSach.Count / 2 + i].HoVaTen + "\n\n";
                    DanhSachHoiChan.Rows.Add(listDanhSach[i].HoVaTen, listDanhSach[listDanhSach.Count / 2 + i].HoVaTen);
                    MaNguoiThamGia += listDanhSach[i].MaNhanVien + ";" + listDanhSach[listDanhSach.Count / 2 + i].MaNhanVien + ";";

                }
                if (listDanhSach.Count % 2 == 1)
                {
                    DanhSachHoiChan.Rows.Add(listDanhSach[listDanhSach.Count - 1].HoVaTen, "");
                    NguoiThamGia += listDanhSach[listDanhSach.Count - 1].HoVaTen;
                    MaNguoiThamGia += listDanhSach[listDanhSach.Count - 1].MaNhanVien + ";";
                }
             }
            else
            {
                for (int i = 0; i < listDanhSach.Count; i++)
                {
                    DanhSachHoiChan.Rows.Add(listDanhSach[i].HoVaTen, "");
                    NguoiThamGia += listDanhSach[i].HoVaTen;
                    MaNguoiThamGia += listDanhSach[i].MaNhanVien + ";";
                }
            }
            ds.Tables[0].Rows[0]["NguoiThamGia"] = NguoiThamGia;
            ds.Tables[0].Rows[0]["MaNguoiThamGia"] = MaNguoiThamGia;

            ds.Tables.Add(DanhSachHoiChan);
            return ds;
        }
    }
}
