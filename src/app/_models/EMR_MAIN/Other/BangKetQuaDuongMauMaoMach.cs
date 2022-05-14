using EMR.KyDienTu;
using Newtonsoft.Json;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EMR_MAIN.DATABASE.Other
{
    public class GhiChuMaoMach
    {
        [MoTaDuLieu("Giờ cập nhật kết quả")]
        public string Gio { get; set; }
        [MoTaDuLieu("Kết quả")]
        public string KetQua { get; set; }
        public GhiChuMaoMach Clone(GhiChuMaoMach obj)
        {
            return (GhiChuMaoMach)obj.MemberwiseClone();
        }
    }
    public class ThongTinMaoMach
    {
        [MoTaDuLieu("Ngày")]
        public DateTime Ngay { get; set; }
        [MoTaDuLieu("Danh sách kết quả")]
        public ObservableCollection<GhiChuMaoMach> KetQuas { get; set; }
        [MoTaDuLieu("Bác sĩ đọc kết quả")]
        public string BacSyDocKQ { get; set; }
        [MoTaDuLieu("Mã Bác sĩ đọc kết quả")]
        public string MaBacSyDocKQ { get; set; }
        public ThongTinMaoMach Clone(ThongTinMaoMach obj)
        {
            ThongTinMaoMach other = (ThongTinMaoMach)obj.MemberwiseClone();
            other.KetQuas = new ObservableCollection<GhiChuMaoMach>();
            if (this.KetQuas != null)
                foreach (GhiChuMaoMach item in this.KetQuas)
                {
                    other.KetQuas.Add(item.Clone(item));
                }
            return other;

        }
    }
    public class KetQuaMaoMach
    {
        [MoTaDuLieu("Ngày")]
        public DateTime Ngay { get; set; }
        [MoTaDuLieu("Giờ cập nhật kết quả")]
        public DateTime? Gio { set; get; }
        [MoTaDuLieu("Kết quả")]
        public string KetQua { get; set; }
        [MoTaDuLieu("Bác sĩ đọc kết quả")]
        public string BacSyDocKQ { get; set; }
    }
    public class SaveKetQuaMaoMach
    {
        public DateTime NG { get; set; }
        public string KQ { get; set; }
        public string BS { get; set; }
    }
   
    public class BangKetQuaDuongMauMaoMach : ThongTinKy
    {
        public BangKetQuaDuongMauMaoMach()
        {
            TableName = "BangKQDuongMaoMach";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BKQDMMM;
            TenMauPhieu = DanhMucPhieu.BKQDMMM.Description();
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
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Ngày vào viện")]
        public DateTime? NgayVaoVien { get; set; }
        [MoTaDuLieu("Ngày ra viện")]
        public DateTime? NgayRaVien { get; set; }
        [MoTaDuLieu("Số bệnh án")]
		public string SoBenhAn { get; set; }
        [MoTaDuLieu("Buồng")]
		public string Buong { get; set; }
        [MoTaDuLieu("Giường")]
		public string Giuong { get; set; }
        [MoTaDuLieu("Danh sách thông tin mao mạch")]
        public List<ThongTinMaoMach> InKetQuaMaoMach { get; set; }
        [MoTaDuLieu("Thông tin kết quả mao mạch")]
        public ObservableCollection<KetQuaMaoMach> KetQuaMaoMachs { get; set; }
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
    public class BangKetQuaDuongMauMaoMachFunc
    {
        public static KetQuaMaoMach convertSaveToShow(SaveKetQuaMaoMach saveKQ)
        {
            return new KetQuaMaoMach { Ngay = saveKQ.NG, Gio = saveKQ.NG, KetQua = saveKQ.KQ, BacSyDocKQ = saveKQ.BS };
        }
        public static ObservableCollection<KetQuaMaoMach> convertShow(List<SaveKetQuaMaoMach> saveKQs)
        {
            ObservableCollection<KetQuaMaoMach> ketQuas = new ObservableCollection<KetQuaMaoMach>();
            if(saveKQs != null || saveKQs.Count > 0)
            {
                foreach (SaveKetQuaMaoMach s in saveKQs)
                    ketQuas.Add(convertSaveToShow(s));
            }
            return ketQuas;
        }
        public static SaveKetQuaMaoMach convertShowToSave(KetQuaMaoMach showKQ)
        {
            var Ngay = showKQ.Ngay.Date.Add(new TimeSpan(0, 0, 0));
            var Gio = showKQ.Gio.HasValue ? showKQ.Gio.Value.TimeOfDay : DateTime.Now.TimeOfDay;
            var NgayGio = Ngay + Gio;
            return new SaveKetQuaMaoMach {NG = NgayGio, KQ = showKQ.KetQua, BS = showKQ.BacSyDocKQ };
        }
        public static List<SaveKetQuaMaoMach> convertSave(ObservableCollection<KetQuaMaoMach> showKQs)
        {
            List<SaveKetQuaMaoMach> ketQuas = new List<SaveKetQuaMaoMach>();
            if (showKQs != null || showKQs.Count > 0)
            {
                foreach (KetQuaMaoMach s in showKQs)
                    ketQuas.Add(convertShowToSave(s));
            }
            return ketQuas;
        }

        public const string TableName = "BangKQDuongMaoMach";
        public const string TablePrimaryKeyName = "ID";
        public static List<ThongTinMaoMach> convertPrint(ObservableCollection<KetQuaMaoMach> KetQuaMaoMachs)
        {
            List<ThongTinMaoMach> convertMaoMach = new List<ThongTinMaoMach>();
            foreach (KetQuaMaoMach ketQua in KetQuaMaoMachs)
            {
                bool check = convertMaoMach.Exists(W => W.Ngay.Date == ketQua.Ngay.Date);
                string hourString = ketQua.Gio.HasValue ? ketQua.Gio.Value.ToString("HH:mm") : "OOhOO";
                if (!check)
                {
                    ThongTinMaoMach thongTinMaoMach = new ThongTinMaoMach();
                    thongTinMaoMach.KetQuas = new ObservableCollection<GhiChuMaoMach>();
                    thongTinMaoMach.Ngay = ketQua.Ngay;
                    thongTinMaoMach.KetQuas.Add(new GhiChuMaoMach { Gio = hourString, KetQua = ketQua.KetQua });
                    thongTinMaoMach.BacSyDocKQ = ketQua.BacSyDocKQ;
                    convertMaoMach.Add(thongTinMaoMach);
                }
                else
                {
                    ThongTinMaoMach thongTinMaoMach = convertMaoMach.Find(W => W.Ngay.Date == ketQua.Ngay.Date);
                    if (string.IsNullOrEmpty(thongTinMaoMach.BacSyDocKQ) && !string.IsNullOrEmpty(ketQua.BacSyDocKQ))
                    {
                        thongTinMaoMach.BacSyDocKQ = ketQua.BacSyDocKQ;
                    }
                    if (!thongTinMaoMach.KetQuas.ToList().Exists(W => hourString.Equals(W.Gio)))
                    {
                        thongTinMaoMach.KetQuas.Add(new GhiChuMaoMach { Gio = hourString, KetQua = ketQua.KetQua });
                        
                    }
                }
            }


            return convertMaoMach;
        }

        public static BangKetQuaDuongMauMaoMach GetListData_Phieu(MDB.MDBConnection _OracleConnection, long ID)
        {
            BangKetQuaDuongMauMaoMach data = new BangKetQuaDuongMauMaoMach();
            try
            {
                string sql = @"SELECT * FROM BangKQDuongMaoMach where ID = :ID";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID", ID));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {

                    data.TenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.SoBenhAn = XemBenhAn._ThongTinDieuTri.MaBenhAn;
                    data.NgayVaoVien = XemBenhAn._ThongTinDieuTri.NgayVaoVien;
                    data.NgayRaVien = XemBenhAn._ThongTinDieuTri.NgayRaVien;
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.Giuong = DataReader["Giuong"].ToString();
                    data.Buong = DataReader["Buong"].ToString();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = DataReader.GetDecimal("MaQuanLy");
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    List<SaveKetQuaMaoMach>  ketQuaSaves = JsonConvert.DeserializeObject<List<SaveKetQuaMaoMach>>(DataReader["KetQuaMaoMach"].ToString());
                    data.KetQuaMaoMachs = convertShow(ketQuaSaves);
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
        public static List<BangKetQuaDuongMauMaoMach> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BangKetQuaDuongMauMaoMach> list = new List<BangKetQuaDuongMauMaoMach>();
            try
            {
                string sql = @"SELECT * FROM BangKQDuongMaoMach where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    BangKetQuaDuongMauMaoMach data = new BangKetQuaDuongMauMaoMach();
                    data.TenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.SoBenhAn = XemBenhAn._ThongTinDieuTri.MaBenhAn;
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.NgayVaoVien = DataReader.GetDate("NgayVaoVien");
                    data.NgayRaVien = DataReader.GetDate("NgayRaVien");
                    data.Giuong = DataReader["Giuong"].ToString();
                    data.Buong = DataReader["Buong"].ToString();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();

                    List<SaveKetQuaMaoMach> ketQuaSaves = JsonConvert.DeserializeObject<List<SaveKetQuaMaoMach>>(DataReader["KetQuaMaoMach"].ToString());
                    data.KetQuaMaoMachs = convertShow(ketQuaSaves);

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BangKetQuaDuongMauMaoMach bangDieuTri)
        {
            try
            {
                string sql = @"INSERT INTO BangKQDuongMaoMach
                (
                    MAQUANLY,
                    MaBenhNhan,
                    Buong,
                    Giuong,
                    ChanDoan,
                    NgayVaoVien,
                    NgayRaVien,
                    KetQuaMaoMach,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :Buong,
                    :Giuong,
                    :ChanDoan,
                    :NgayVaoVien,
                    :NgayRaVien,
                    :KetQuaMaoMach,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (bangDieuTri.ID != 0)
                {
                    sql = @"UPDATE BangKQDuongMaoMach SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    Buong = :Buong,
                    Giuong = :Giuong,
                    ChanDoan = :ChanDoan,
                    NgayVaoVien = :NgayVaoVien,
                    NgayRaVien = :NgayRaVien,
                    KetQuaMaoMach = :KetQuaMaoMach,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + bangDieuTri.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangDieuTri.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", bangDieuTri.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("Buong", bangDieuTri.Buong));
                Command.Parameters.Add(new MDB.MDBParameter("Giuong", bangDieuTri.Giuong));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", bangDieuTri.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("NgayVaoVien", bangDieuTri.NgayVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("NgayRaVien", bangDieuTri.NgayRaVien));
                Command.Parameters.Add(new MDB.MDBParameter("KetQuaMaoMach", JsonConvert.SerializeObject(convertSave(bangDieuTri.KetQuaMaoMachs))));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", bangDieuTri.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", bangDieuTri.NgaySua));
                if (bangDieuTri.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", bangDieuTri.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", bangDieuTri.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", bangDieuTri.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (bangDieuTri.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    bangDieuTri.ID = nextval;
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
                string sql = "DELETE FROM BangKQDuongMaoMach WHERE ID = :ID";
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
