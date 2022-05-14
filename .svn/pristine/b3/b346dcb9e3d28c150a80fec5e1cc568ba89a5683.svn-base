using EMR.KyDienTu;
using Newtonsoft.Json;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMR_MAIN.DATABASE.Other
{
    public class KHCS_Nhi
    {
        public DateTime? ThoiGian { get; set; }
        public string KeHoach { get; set; }
        public string ThucHien { get; set; }
        public string MaDD { get; set; }
        public string TenDD
        {
            get
            {
                string temp = String.Empty;
                if(MaDD != null)
                {
                    var Objtemp = NhanVienFunc.ListNhanVien.Where(x => x.MaNhanVien == MaDD).FirstOrDefault();
                    if(Objtemp!=null)
                    {
                        temp = Objtemp.HoVaTen;
                    }
                }
                return temp;
            }
        }
    }
    public class PhieuCSNhi_ChiTiet
    {
        public PhieuCSNhi_ChiTiet()
        {
            DanhGia = new ObservableCollection<TDCS>();
            DanhGia.Add(new TDCS { TieuDe = "Nhiệt độ ( °C)" });
            DanhGia.Add(new TDCS { TieuDe = "Mạch (lần/phút)" });
            DanhGia.Add(new TDCS { TieuDe = "Nhịp thở (lần/phút)" });
            DanhGia.Add(new TDCS { TieuDe = "Rút lõm ngực / Cơn ngưng thở dài" });
            DanhGia.Add(new TDCS { TieuDe = "Tím tái / SpO2(%)" });
            DanhGia.Add(new TDCS { TieuDe = "Chi ẩm" });
            DanhGia.Add(new TDCS { TieuDe = "Tri giác (*)" });
            DanhGia.Add(new TDCS { TieuDe = "Co giật / Thóp phồng" });
            DanhGia.Add(new TDCS { TieuDe = "Da : Hồng, Vàng da, Xanh, Đỏ" });
            DanhGia.Add(new TDCS { TieuDe = "Rốn đỏ, mủ" });
            DanhGia.Add(new TDCS { TieuDe = "Bụng chướng" });
            DanhGia.Add(new TDCS { TieuDe = "Vết mổ" });
            DanhGia.Add(new TDCS { TieuDe = "Khác" });
            //
            Thuoc = new ObservableCollection<TDCS>();
            Thuoc.Add(new TDCS { TieuDe = "Đầu cao 30°" });
            Thuoc.Add(new TDCS { TieuDe = "Hút đàm" });
            Thuoc.Add(new TDCS { TieuDe = "Ủ ấm / Lồng ấp / Giường sưởi" });
            Thuoc.Add(new TDCS { TieuDe = "Chiếu đèn" });
            Thuoc.Add(new TDCS { TieuDe = "Chăm sóc rốn / Thay băng" });
            Thuoc.Add(new TDCS { TieuDe = "Dẫn lưu dạ dày" });
            Thuoc.Add(new TDCS { TieuDe = "Thực hiện y lệnh thuốc" });
            //
            HotroHH = new ObservableCollection<TDCS>();
            HotroHH.Add(new TDCS { TieuDe = "Oxy Cannala (lít/phút)" });
            HotroHH.Add(new TDCS { TieuDe = "Oxy Mark (lít/phút)" });
            HotroHH.Add(new TDCS { TieuDe = "NCPAP : PEEP(cm H2O) FiO2 (%)" });
            HotroHH.Add(new TDCS { TieuDe = "Oxy (lít/phút) / Air (lít/phút)" });
            HotroHH.Add(new TDCS { TieuDe = "Bóp bóng O2 (lít/phút) / NKQ (cm)" });
            //
            Nhap = new ObservableCollection<TDCS>();
            Nhap.Add(new TDCS { TieuDe = "Dịch truyền       ml/giờ" });
            Nhap.Add(new TDCS { TieuDe = "Sữa :    ml*  cữ; ( Gavage/Uống/ Bú)" });
            Nhap.Add(new TDCS { TieuDe = "Máu nhóm    số lượng   ml" });
            //
            Xuat = new ObservableCollection<TDCS>();
            Xuat.Add(new TDCS { TieuDe = "Nôn ói/ Dịch dạ dày (ml)" });
            Xuat.Add(new TDCS { TieuDe = "Trong, Vàng, Xanh, Đỏ, Nâu, Sữa cũ" });
            Xuat.Add(new TDCS { TieuDe = "Nước tiểu (ml) / màu sắc" });
            Xuat.Add(new TDCS { TieuDe = "Phân : số lần / tính chất" });
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã định danh")]
		public long ID_Phieu { get; set; }
        public DateTime? ThoiGian { get; set; }
        public string XetNghiem { get; set; }
        public string HoTroHHLoai { get; set; }
        public ObservableCollection<TDCS> DanhGia { get; set; }
        public ObservableCollection<TDCS> Thuoc { get; set; }
        public ObservableCollection<TDCS> HotroHH { get; set; }
        public ObservableCollection<TDCS> Nhap { get; set; }
        public ObservableCollection<TDCS> Xuat { get; set; }
        public ObservableCollection<NhanVien> DieuDuong { get; set; }
        public PhieuCSNhi_ChiTiet clone()
        {
            PhieuCSNhi_ChiTiet other = (PhieuCSNhi_ChiTiet) this.MemberwiseClone();
            other.DanhGia = new ObservableCollection<TDCS>();
            other.Thuoc = new ObservableCollection<TDCS>();
            other.HotroHH = new ObservableCollection<TDCS>();
            other.Nhap = new ObservableCollection<TDCS>();
            other.Xuat = new ObservableCollection<TDCS>();
            other.DieuDuong = new ObservableCollection<NhanVien>();

            if (this.DanhGia != null)
            {
                foreach(TDCS tdcs in this.DanhGia)
                {
                    other.DanhGia.Add(tdcs.Clone());
                }
            }
            if (this.HotroHH != null)
            {
                foreach (TDCS tdcs in this.HotroHH)
                {
                    other.HotroHH.Add(tdcs.Clone());
                }
            }
            if (this.Thuoc != null)
            {
                foreach (TDCS tdcs in this.Thuoc)
                {
                    other.Thuoc.Add(tdcs.Clone());
                }
            }
            if (this.Nhap != null)
            {
                foreach (TDCS tdcs in this.Nhap)
                {
                    other.Nhap.Add(tdcs.Clone());
                }
            }
            if (this.Xuat != null)
            {
                foreach (TDCS tdcs in this.Xuat)
                {
                    other.Xuat.Add(tdcs.Clone());
                }
            }
            if (this.DieuDuong != null)
            {
                foreach (NhanVien nv in this.DieuDuong)
                {
                    other.DieuDuong.Add(new NhanVien { IdNhanVien = nv.IdNhanVien,
                        MaNhanVien = nv.MaNhanVien,
                        HoVaTen = nv.HoVaTen,
                        MatKhau = nv.MatKhau,
                        Chon = nv.Chon,
                        Admin = nv.Admin });
                }
            }
            return other;
        }
    }
    public class PhieuCSNhi : ThongTinKy
    {
        public PhieuCSNhi()
        {
            TableName = "PhieuCSNhi";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PCSN;
            TenMauPhieu = DanhMucPhieu.PCSN.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Giường")]
		public string Giuong { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public List<KHCS_Nhi> LstKHCSThoiGian { get; set; }
        [MoTaDuLieu("Cân nặng")]
		public string CanNang { get; set; }
        [MoTaDuLieu("Chiều cao")]
		public string ChieuCao { get; set; }
        public bool[] HoTroHHArray { get; } = new bool[] { false, false };
        public string HoTroHHLoai
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < HoTroHHArray.Length; i++)
                    temp += (HoTroHHArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        HoTroHHArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public DateTime NgayThucHien { get; set; }
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
    public class PhieuCSNhiFunc
    {
        public const string TableName = "PhieuCSNhi";
        public const string TablePrimaryKeyName = "ID";
        public static ObservableCollection<PhieuCSNhi_ChiTiet> GetListData_ChiTiet(MDB.MDBConnection _OracleConnection, long ID_Phieu)
        {
            ObservableCollection<PhieuCSNhi_ChiTiet> list = new ObservableCollection<PhieuCSNhi_ChiTiet>();

            try
            {
                string sql = @"SELECT * FROM PhieuCSNhi_CT where ID_Phieu = :ID_Phieu ORDER BY ThoiGian";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID_Phieu", ID_Phieu));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuCSNhi_ChiTiet data = new PhieuCSNhi_ChiTiet();
                    data.ID = DataReader.GetLong("ID");
                    data.ID_Phieu = ID_Phieu;
                    data.ThoiGian = Common.ConDB_DateTimeNull(DataReader["ThoiGian"].ToString());
                    data.XetNghiem = DataReader[ "XetNghiem"].ToString();
                    data.HoTroHHLoai = DataReader["HoTroHHLoai"].ToString();
                    data.DanhGia = JsonConvert.DeserializeObject<ObservableCollection<TDCS>>(DataReader["DanhGia"].ToString());
                    data.Thuoc = JsonConvert.DeserializeObject<ObservableCollection<TDCS>>(DataReader["Thuoc"].ToString());
                    data.HotroHH = JsonConvert.DeserializeObject<ObservableCollection<TDCS>>(DataReader["HotroHH"].ToString());
                    data.Nhap = JsonConvert.DeserializeObject<ObservableCollection<TDCS>>(DataReader["Nhap"].ToString());
                    data.Xuat = JsonConvert.DeserializeObject<ObservableCollection<TDCS>>(DataReader["Xuat"].ToString());
                    data.DieuDuong = JsonConvert.DeserializeObject<ObservableCollection<NhanVien>>(DataReader["DieuDuong"].ToString());
                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool InsertOrUpdate_ChiTiet(MDB.MDBConnection MyConnection, ref PhieuCSNhi_ChiTiet chiTietPhieu)
        {
            try
            {
                string sql = @"INSERT INTO PhieuCSNhi_CT
                (
                    ID_Phieu,
                    ThoiGian,XetNghiem,HoTroHHLoai,
                    DanhGia,Thuoc,HotroHH,Nhap,Xuat,
                    DieuDuong)  VALUES
                 (
				    :ID_Phieu,
                    :ThoiGian,:XetNghiem,:HoTroHHLoai,
                    :DanhGia,:Thuoc,:HotroHH,:Nhap,:Xuat,
                    :DieuDuong
                 )  RETURNING ID INTO :ID";
                if (chiTietPhieu.ID != 0)
                {
                    sql = @"UPDATE PhieuCSNhi_CT SET 
                    ID_Phieu = :ID_Phieu,
                    ThoiGian = :ThoiGian,XetNghiem = :XetNghiem,HoTroHHLoai = :HoTroHHLoai,
                    DanhGia = :DanhGia,Thuoc = :Thuoc,HotroHH = :HotroHH,Nhap = :Nhap,Xuat = :Xuat,
                    DieuDuong = :DieuDuong
                    WHERE ID = " + chiTietPhieu.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID_Phieu", chiTietPhieu.ID_Phieu));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGian", chiTietPhieu.ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("XetNghiem", chiTietPhieu.XetNghiem));
                Command.Parameters.Add(new MDB.MDBParameter("HoTroHHLoai", chiTietPhieu.HoTroHHLoai));
                Command.Parameters.Add(new MDB.MDBParameter("DanhGia", JsonConvert.SerializeObject(chiTietPhieu.DanhGia)));
                Command.Parameters.Add(new MDB.MDBParameter("Thuoc", JsonConvert.SerializeObject(chiTietPhieu.Thuoc)));
                Command.Parameters.Add(new MDB.MDBParameter("HotroHH", JsonConvert.SerializeObject(chiTietPhieu.HotroHH)));
                Command.Parameters.Add(new MDB.MDBParameter("Nhap", JsonConvert.SerializeObject(chiTietPhieu.Nhap)));
                Command.Parameters.Add(new MDB.MDBParameter("Xuat", JsonConvert.SerializeObject(chiTietPhieu.Xuat)));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuong", JsonConvert.SerializeObject(chiTietPhieu.DieuDuong)));

                if (chiTietPhieu.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", chiTietPhieu.ID));;
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (chiTietPhieu.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    chiTietPhieu.ID = nextval;
                }
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static bool Delete_ChiTiet(MDB.MDBConnection MyConnection, long id)
        {
            try
            {
                string sql = "DELETE FROM PhieuCSNhi_CT WHERE ID = :ID";
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
        public static PhieuCSNhi GetDataPhieu(MDB.MDBConnection _OracleConnection, long ID)
        {
            PhieuCSNhi data = new PhieuCSNhi();
            try
            {
                string sql = @"SELECT * FROM PhieuCSNhi where ID = :ID ";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID", ID));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = DataReader.GetDecimal("MaQuanLy");
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.Giuong = DataReader["Giuong"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.LstKHCSThoiGian = JsonConvert.DeserializeObject<List<KHCS_Nhi>>(Common.ConDBNull(DataReader["LstKHCSThoiGian"]));
                    data.CanNang = DataReader["CanNang"].ToString();
                    data.ChieuCao = DataReader["ChieuCao"].ToString();
                    data.HoTroHHLoai = DataReader["HoTroHHLoai"].ToString();
                    data.NgayThucHien = Common.ConDB_DateTime(DataReader["NgayThucHien"].ToString());
                    data.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                    data.NguoiTao = DataReader["NguoiTao"].ToString();
                    data.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);
                    data.NguoiSua = DataReader["NguoiSua"].ToString();

                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return data;
        }
        public static ObservableCollection<PhieuCSNhi> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            ObservableCollection<PhieuCSNhi> list = new ObservableCollection<PhieuCSNhi>();
            
            try
            {
                string sql = @"SELECT * FROM PhieuCSNhi where MaQuanLy = :MaQuanLy ORDER BY NgayThucHien";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuCSNhi data = new PhieuCSNhi();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = DataReader.GetDecimal("MaQuanLy");
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.TenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.Giuong = DataReader["Giuong"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.LstKHCSThoiGian = JsonConvert.DeserializeObject<List<KHCS_Nhi>>(Common.ConDBNull(DataReader["LstKHCSThoiGian"]));
                    data.CanNang = DataReader["CanNang"].ToString();
                    data.ChieuCao = DataReader["ChieuCao"].ToString();
                    data.HoTroHHLoai = DataReader["HoTroHHLoai"].ToString();
                    data.NgayThucHien =Common.ConDB_DateTime(DataReader["NgayThucHien"].ToString());
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

        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuCSNhi bangTheoDoi)
        {
            try
            {
                string sql = @"INSERT INTO PhieuCSNhi
                (
                    MAQUANLY,
                    MaBenhNhan,
                    Giuong,
                    ChanDoan,LstKHCSThoiGian,CanNang,ChieuCao,HoTroHHLoai,NgayThucHien,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :Giuong,
                    :ChanDoan,:LstKHCSThoiGian,:CanNang,:ChieuCao,:HoTroHHLoai, :NgayThucHien,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (bangTheoDoi.ID != 0)
                {
                    sql = @"UPDATE PhieuCSNhi SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    Giuong = :Giuong,
                    ChanDoan = :ChanDoan,LstKHCSThoiGian = :LstKHCSThoiGian,CanNang = :CanNang,ChieuCao = :ChieuCao,HoTroHHLoai = : HoTroHHLoai,NgayThucHien = :NgayThucHien,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + bangTheoDoi.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangTheoDoi.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", bangTheoDoi.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("Giuong", bangTheoDoi.Giuong));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", bangTheoDoi.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("LstKHCSThoiGian", JsonConvert.SerializeObject(bangTheoDoi.LstKHCSThoiGian)));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang", bangTheoDoi.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("ChieuCao", bangTheoDoi.ChieuCao));
                Command.Parameters.Add(new MDB.MDBParameter("HoTroHHLoai", bangTheoDoi.HoTroHHLoai));
                Command.Parameters.Add(new MDB.MDBParameter("NgayThucHien", bangTheoDoi.NgayThucHien));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", bangTheoDoi.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", bangTheoDoi.NgaySua));
                if (bangTheoDoi.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", bangTheoDoi.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", bangTheoDoi.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", bangTheoDoi.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (bangTheoDoi.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    bangTheoDoi.ID = nextval;
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
                string sql = "DELETE FROM PhieuCSNhi WHERE ID = :ID";
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
    }
}

