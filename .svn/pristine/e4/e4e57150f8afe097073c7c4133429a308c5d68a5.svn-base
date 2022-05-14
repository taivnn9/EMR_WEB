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
    public class TDCS
    {
        public string TieuDe { get; set; }
        public string GiaTri { get; set; }
        public TDCS Clone()
        {
            return (TDCS)this.MemberwiseClone();
        }
    }
    public class NhanDinhHanhDong
    {
        public decimal ID { get; set; }
        [MoTaDuLieu("Mã định danh")]
        public string TenMau { get; set; }
        public DateTime? NgayGio { get; set; }
        public ObservableCollection<TDCS> NhanDinh { get; set; }
        public ObservableCollection<TDCS> HanhDong { get; set; }
        
    }
    public class PhieuTDVaTHKHCSNguoiBenh_ChiTiet
    {
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã định danh")]
		public long ID_Phieu { get; set; }
        public DateTime? Ngay { get; set; }
        public DateTime? Gio { get; set; }
        public ObservableCollection<TDCS> NhanDinh { get; set; }
        public ObservableCollection<TDCS> HanhDong { get; set; }
        public ObservableCollection<NhanVien> DieuDuong { get; set; }
        public PhieuTDVaTHKHCSNguoiBenh_ChiTiet clone()
        {
            PhieuTDVaTHKHCSNguoiBenh_ChiTiet other = (PhieuTDVaTHKHCSNguoiBenh_ChiTiet) this.MemberwiseClone();
            other.NhanDinh = new ObservableCollection<TDCS>();
            other.HanhDong = new ObservableCollection<TDCS>();
            other.DieuDuong = new ObservableCollection<NhanVien>();

            if (this.NhanDinh != null)
            {
                foreach(TDCS tdcs in this.NhanDinh)
                {
                    other.NhanDinh.Add(tdcs.Clone());
                }
            }
            if (this.HanhDong != null)
            {
                foreach (TDCS tdcs in this.HanhDong)
                {
                    other.HanhDong.Add(tdcs.Clone());
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
    public class PhieuTDVaTHKHCSNguoiBenh : ThongTinKy
    {
        public PhieuTDVaTHKHCSNguoiBenh()
        {
            TableName = "PhieuTDVaTHKHCSNguoiBenh";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PTDTHKHCS;
            TenMauPhieu = DanhMucPhieu.PTDTHKHCS.Description();
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
        public PhieuTDVaTHKHCSNguoiBenh Clone()
        {
            PhieuTDVaTHKHCSNguoiBenh other = (PhieuTDVaTHKHCSNguoiBenh)this.MemberwiseClone();
            return other;
        }
    }
    public class PhieuTDVaTHKHCSNguoiBenhFunc
    {
        public const string TableName = "PhieuTDVaTHKHCSNguoiBenh";
        public const string TablePrimaryKeyName = "ID";
        public static ObservableCollection<PhieuTDVaTHKHCSNguoiBenh_ChiTiet> GetListData_ChiTiet(MDB.MDBConnection _OracleConnection, long ID_Phieu)
        {
            ObservableCollection<PhieuTDVaTHKHCSNguoiBenh_ChiTiet> list = new ObservableCollection<PhieuTDVaTHKHCSNguoiBenh_ChiTiet>();

            try
            {
                string sql = @"SELECT * FROM PhieuTDVaTHKHCSNB_CT where ID_Phieu = :ID_Phieu ORDER BY NgayGio";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID_Phieu", ID_Phieu));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuTDVaTHKHCSNguoiBenh_ChiTiet data = new PhieuTDVaTHKHCSNguoiBenh_ChiTiet();
                    data.ID = DataReader.GetLong("ID");
                    data.ID_Phieu = ID_Phieu;
                    data.Ngay = DataReader["NgayGio"] == DBNull.Value ? null : (DateTime?) DataReader.GetDate("NgayGio");
                    data.Gio = DataReader["NgayGio"] == DBNull.Value ? null : (DateTime?)DataReader.GetDate("NgayGio");
                    data.NhanDinh = JsonConvert.DeserializeObject<ObservableCollection<TDCS>>(DataReader["NhanDinh"].ToString());
                    data.HanhDong = JsonConvert.DeserializeObject<ObservableCollection<TDCS>>(DataReader["HanhDong"].ToString());
                    data.DieuDuong = JsonConvert.DeserializeObject<ObservableCollection<NhanVien>>(DataReader["DieuDuong"].ToString());
                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool InsertOrUpdate_ChiTiet(MDB.MDBConnection MyConnection, ref PhieuTDVaTHKHCSNguoiBenh_ChiTiet chiTietPhieu)
        {
            try
            {
                string sql = @"INSERT INTO PhieuTDVaTHKHCSNB_CT
                (
                    ID_Phieu,
                    NgayGio,
                    NhanDinh,
                    HanhDong,
                    DieuDuong)  VALUES
                 (
				    :ID_Phieu,
                    :NgayGio,
                    :NhanDinh,
                    :HanhDong,
                    :DieuDuong
                 )  RETURNING ID INTO :ID";
                if (chiTietPhieu.ID != 0)
                {
                    sql = @"UPDATE PhieuTDVaTHKHCSNB_CT SET 
                    ID_Phieu = :ID_Phieu,
                    NgayGio = :NgayGio,
                    NhanDinh = :NhanDinh,
                    HanhDong = :HanhDong,
                    DieuDuong = :DieuDuong
                    WHERE ID = " + chiTietPhieu.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID_Phieu", chiTietPhieu.ID_Phieu));
                var Ngay = chiTietPhieu.Ngay.Value.Date.Add(new TimeSpan(0, 0, 0));
                var Gio = chiTietPhieu.Gio != null ? chiTietPhieu.Gio.Value.TimeOfDay : DateTime.Now.TimeOfDay;
                var NgayGio = Ngay + Gio;

                Command.Parameters.Add(new MDB.MDBParameter("NgayGio", NgayGio));
                Command.Parameters.Add(new MDB.MDBParameter("NhanDinh", JsonConvert.SerializeObject(chiTietPhieu.NhanDinh)));
                Command.Parameters.Add(new MDB.MDBParameter("HanhDong", JsonConvert.SerializeObject(chiTietPhieu.HanhDong)));
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
        public static bool InsertOrUpdate_NhanDinhHanhdong(MDB.MDBConnection MyConnection, ref NhanDinhHanhDong objData)
        {
            try
            {
                string sql = @"INSERT INTO PHIEUTDVATHKHCSNB_CT_LUUMAU
                (
                    tenmau,
                    ngaygio,
                    nhandinh,
                    hanhdong)  VALUES
                 (
                    :tenmau,
                    :ngaygio,
                    :nhandinh,
                    :hanhdong
                 )  RETURNING ID INTO :ID";
                if (objData.ID != 0)
                {
                    sql = @"UPDATE PHIEUTDVATHKHCSNB_CT_LUUMAU SET 
                    tenmau=:tenmau,
                    ngaygio=:ngaygio,
                    nhandinh=:nhandinh,
                    hanhdong=:hanhdong  
                    WHERE ID = " + objData.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ngaygio", objData.NgayGio));
                Command.Parameters.Add(new MDB.MDBParameter("nhandinh", JsonConvert.SerializeObject(objData.NhanDinh)));
                Command.Parameters.Add(new MDB.MDBParameter("hanhdong", JsonConvert.SerializeObject(objData.HanhDong)));
                Command.Parameters.Add(new MDB.MDBParameter("tenmau", JsonConvert.SerializeObject(objData.TenMau)));

                if (objData.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", objData.ID)); ;
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (objData.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    objData.ID = nextval;
                }
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static ObservableCollection<NhanDinhHanhDong> GetListMau(MDB.MDBConnection _OracleConnection)
        {
            ObservableCollection<NhanDinhHanhDong> list = new ObservableCollection<NhanDinhHanhDong>();

            try
            {
                string sql = @"SELECT * FROM PHIEUTDVATHKHCSNB_CT_LUUMAU ";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    NhanDinhHanhDong data = new NhanDinhHanhDong();
                    data.ID = DataReader.GetDecimal("ID");
                    data.NgayGio = DataReader["NgayGio"] == DBNull.Value ? null : (DateTime?)DataReader.GetDate("NgayGio");
                    data.NhanDinh = JsonConvert.DeserializeObject<ObservableCollection<TDCS>>(DataReader["NhanDinh"].ToString());
                    data.HanhDong = JsonConvert.DeserializeObject<ObservableCollection<TDCS>>(DataReader["HanhDong"].ToString());
                    data.TenMau = DataReader["TenMau"].ToString();
                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool Delete_ChiTiet(MDB.MDBConnection MyConnection, long id)
        {
            try
            {
                string sql = "DELETE FROM PhieuTDVaTHKHCSNB_CT WHERE ID = :ID";
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
        public static PhieuTDVaTHKHCSNguoiBenh GetDataPhieu(MDB.MDBConnection _OracleConnection, long ID)
        {
            PhieuTDVaTHKHCSNguoiBenh data = new PhieuTDVaTHKHCSNguoiBenh();
            try
            {
                string sql = @"SELECT * FROM PhieuTDVaTHKHCSNguoiBenh where ID = :ID ";
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
        public static ObservableCollection<PhieuTDVaTHKHCSNguoiBenh> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            ObservableCollection<PhieuTDVaTHKHCSNguoiBenh> list = new ObservableCollection<PhieuTDVaTHKHCSNguoiBenh>();
            
            try
            {
                string sql = @"SELECT * FROM PhieuTDVaTHKHCSNguoiBenh where MaQuanLy = :MaQuanLy ORDER BY NgayTao";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuTDVaTHKHCSNguoiBenh data = new PhieuTDVaTHKHCSNguoiBenh();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = DataReader.GetDecimal("MaQuanLy");
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.TenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.Giuong = DataReader["Giuong"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();


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

        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuTDVaTHKHCSNguoiBenh bangTheoDoi)
        {
            try
            {
                string sql = @"INSERT INTO PhieuTDVaTHKHCSNguoiBenh
                (
                    MAQUANLY,
                    MaBenhNhan,
                    Giuong,
                    ChanDoan,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :Giuong,
                    :ChanDoan,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (bangTheoDoi.ID != 0)
                {
                    sql = @"UPDATE PhieuTDVaTHKHCSNguoiBenh SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    Giuong = :Giuong,
                    ChanDoan = :ChanDoan,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + bangTheoDoi.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangTheoDoi.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", bangTheoDoi.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("Giuong", bangTheoDoi.Giuong));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", bangTheoDoi.ChanDoan));

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
                string sql = "DELETE FROM PhieuTDVaTHKHCSNguoiBenh WHERE ID = :ID";
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

