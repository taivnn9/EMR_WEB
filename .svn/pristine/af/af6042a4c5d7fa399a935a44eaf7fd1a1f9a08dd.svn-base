using EMR.KyDienTu;
using Newtonsoft.Json;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuChuyenDeTiepTucDieuTri : ThongTinKy
    {
        public PhieuChuyenDeTiepTucDieuTri()
        {
            TableName = "PhieuChuyenDeTiepTucDieuTri";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PCDTTDT;
            TenMauPhieu = DanhMucPhieu.PCDTTDT.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        public string HoTen { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }
        [MoTaDuLieu("Mã bệnh án")]
		public string MaBenhAn { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        public bool[] NoiGioiThieuArr { get; } = new bool[] { false, false, false };
        public string NoiGioiThieu
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < NoiGioiThieuArr.Length; i++)
                    temp += (NoiGioiThieuArr[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NoiGioiThieuArr[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }

        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public DateTime? NgayRaVien { get; set; }
        public string CMU { get; set; }
        public string MaSo { get; set; }

        public bool[] LyDoChuyenArr { get; } = new bool[] { false, false, false };
        public string LyDoChuyen
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < LyDoChuyenArr.Length; i++)
                    temp += (LyDoChuyenArr[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        LyDoChuyenArr[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }

        public bool[] HenMucDoKieuSoatArr { get; } = new bool[] { false, false, false };
        public string HenMucDoKieuSoat
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < HenMucDoKieuSoatArr.Length; i++)
                    temp += (HenMucDoKieuSoatArr[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        HenMucDoKieuSoatArr[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }

        public bool[] COPDGiaiDoanArr { get; } = new bool[] { false, false, false, false };
        public string COPDGiaiDoan
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < COPDGiaiDoanArr.Length; i++)
                    temp += (COPDGiaiDoanArr[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        COPDGiaiDoanArr[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }

        public string BenhKemTheo { get; set; }
        public string XQuangNguc { get; set; }
        public string DienTim { get; set; }
        
        public DateTime? DoThongKhiPhoi { get;set;}
        public DateTime? NgayXNKhiDongMachMau { get;set;}

        public double? PH { get; set; }
        public double? PaCO2 { get; set; }
        public double? PO2 { get; set; }
        public double? SaO2 { get; set; }
        public double? SpO2 { get; set; }

        public string XNCTM { get; set; }
        public string HCT { get; set; }
        public string HBGDL { get; set; }
        public string SieuAmTim { get; set; }
        public string XetNghiemKhac { get; set; }
        
        public string DieuTriHienTai { get; set; }
        public string DieuTriHienTaiKhac { get; set; }
        public string HoSoKemTheoKhac { get; set; }
        public string LuuY { get; set; }
        public string PhimPhoi { get; set; }

        public ObservableCollection<ThongSoGPQ> ListThongSo { get; set; }

        [MoTaDuLieu("Họ tên bác sỹ")]
		public string BacSi { get; set; }
        [MoTaDuLieu("Mã bác sỹ")]
		public string MaBacSi { get; set; }
     
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
    public class ThongSoGPQ
    {
        public string ThongSo { get; set; }
        public string GiaTriTruocTestGPQ { get; set; }
        public string PhanTramTruocTestGPQ { get; set; }
        public string GiaTriSauTestGPQ { get; set; }
        public string PhanTramSauTestGPQ { get; set; }
        public string ThayDoiGPQ { get; set; }
        public string KetQuaGPQ { get; set; }
    }
  
    public class PhieuChuyenDeTiepTucDieuTriFunc
    {
        public const string TableName = "PhieuChuyenDeTiepTucDieuTri";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuChuyenDeTiepTucDieuTri> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuChuyenDeTiepTucDieuTri> list = new List<PhieuChuyenDeTiepTucDieuTri>();
            try
            {
                string sql = @"SELECT * FROM PhieuChuyenDeTiepTucDieuTri where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuChuyenDeTiepTucDieuTri data = new PhieuChuyenDeTiepTucDieuTri();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.Khoa = DataReader["Khoa"].ToString();
                    data.MaKhoa = DataReader["MaKhoa"].ToString();
                    data.MaBenhAn = XemBenhAn._ThongTinDieuTri.MaBenhAn;
                    data.HoTen = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();

                    data.NoiGioiThieu = DataReader["NoiGioiThieu"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.LyDoChuyen = DataReader["LyDoChuyen"].ToString();
                    data.COPDGiaiDoan = DataReader["COPDGiaiDoan"].ToString();
                    data.HenMucDoKieuSoat = DataReader["HenMucDoKieuSoat"].ToString();

                    data.CMU = DataReader["CMU"].ToString();
                    data.MaSo = DataReader["MaSo"].ToString();
                    data.BenhKemTheo = DataReader["BenhKemTheo"].ToString();
                    data.XQuangNguc = DataReader["XQuangNguc"].ToString();
                    data.DienTim = DataReader["DienTim"].ToString();
                    double tempDouble = 0;
                    data.PH = double.TryParse(DataReader["PH"].ToString(), out tempDouble) ? (double?)tempDouble : null;
                    data.PaCO2 = double.TryParse(DataReader["PaCO2"].ToString(), out tempDouble) ? (double?)tempDouble : null;
                    data.PO2 = double.TryParse(DataReader["PO2"].ToString(), out tempDouble) ? (double?)tempDouble : null;
                    data.SaO2 = double.TryParse(DataReader["SaO2"].ToString(), out tempDouble) ? (double?)tempDouble : null;
                    data.SpO2 = double.TryParse(DataReader["SpO2"].ToString(), out tempDouble) ? (double?)tempDouble : null;
                    data.XNCTM = DataReader["XNCTM"].ToString();
                    data.HCT = DataReader["HCT"].ToString();
                    data.HBGDL = DataReader["HBGDL"].ToString();
                    data.SieuAmTim = DataReader["SieuAmTim"].ToString();
                    data.XetNghiemKhac = DataReader["XetNghiemKhac"].ToString();
                    
                    data.DieuTriHienTai = DataReader["DieuTriHienTai"].ToString();
                    data.DieuTriHienTaiKhac = DataReader["DieuTriHienTaiKhac"].ToString();
                    data.HoSoKemTheoKhac = DataReader["HoSoKemTheoKhac"].ToString();
                    data.LuuY = DataReader["LuuY"].ToString();
                    data.PhimPhoi = DataReader["PhimPhoi"].ToString();
                    
                    data.BacSi = DataReader["BacSi"].ToString();
                    data.MaBacSi = DataReader["MaBacSi"].ToString();

                    data.ListThongSo = JsonConvert.DeserializeObject<ObservableCollection<ThongSoGPQ>>(DataReader["ListThongSo"].ToString());

                    data.NgayRaVien = Convert.ToDateTime(DataReader["NgayRaVien"] == DBNull.Value ? DateTime.Now : DataReader["NgayRaVien"]);
                    data.DoThongKhiPhoi = Convert.ToDateTime(DataReader["DoThongKhiPhoi"] == DBNull.Value ? DateTime.Now : DataReader["DoThongKhiPhoi"]);
                    data.NgayXNKhiDongMachMau = Convert.ToDateTime(DataReader["NgayXNKhiDongMachMau"] == DBNull.Value ? DateTime.Now : DataReader["NgayXNKhiDongMachMau"]);

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuChuyenDeTiepTucDieuTri ketQua)
        {
            try
            {
                string sql = @"INSERT INTO PhieuChuyenDeTiepTucDieuTri
                (
                    MaQuanLy,
                    MaBenhNhan,
                    Khoa,
                    MaKhoa,
                    HoTen,
                    Tuoi,
                    GioiTinh,
                    NoiGioiThieu,
                    ChanDoan,
                    NgayRaVien,
                    LyDoChuyen,
                    COPDGiaiDoan,
                    HenMucDoKieuSoat,
                    CMU,
                    MaSo,
                    XQuangNguc,
                    DienTim,
                    PH,
                    PaCO2,
                    PO2,
                    SaO2,
                    SpO2,
                    XNCTM,
                    HCT,
                    HBGDL,
                    SieuAmTim,
                    XetNghiemKhac,
                    DieuTriHienTai,
                    DieuTriHienTaiKhac,
                    HoSoKemTheoKhac,
                    LuuY,
                    PhimPhoi,
                    BenhKemTheo,
                    BacSi,
                    MaBacSi,
                    ListThongSo,
                    DoThongKhiPhoi,
                    NgayXNKhiDongMachMau,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
                    :MaBenhNhan,
                    :Khoa,
                    :MaKhoa,
                    :HoTen,
                    :Tuoi,
                    :GioiTinh,
                    :NoiGioiThieu,
                    :ChanDoan,
                    :NgayRaVien,
                    :LyDoChuyen,
                    :COPDGiaiDoan,
                    :HenMucDoKieuSoat,
                    :CMU,
                    :MaSo,
                    :XQuangNguc,
                    :DienTim,
                    :PH,
                    :PaCO2,
                    :PO2,
                    :SaO2,
                    :SpO2,
                    :XNCTM,
                    :HCT,
                    :HBGDL,
                    :SieuAmTim,
                    :XetNghiemKhac,
                    :DieuTriHienTai,
                    :DieuTriHienTaiKhac,
                    :HoSoKemTheoKhac,
                    :LuuY,
                    :PhimPhoi,
                    :BenhKemTheo,
                    :BacSi,
                    :MaBacSi,
                    :ListThongSo,
                    :DoThongKhiPhoi,
                    :NgayXNKhiDongMachMau,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE PhieuChuyenDeTiepTucDieuTri SET 
                    MaQuanLy = :MaQuanLy,
                    MaBenhNhan = :MaBenhNhan,
                    Khoa = :Khoa,
                    MaKhoa = :MaKhoa,
                    HoTen = :HoTen,
                    Tuoi = :Tuoi,
                    GioiTinh = :GioiTinh,
                    NoiGioiThieu = :NoiGioiThieu,
                    ChanDoan = :ChanDoan,
                    NgayRaVien = :NgayRaVien,
                    LyDoChuyen = :LyDoChuyen,
                    COPDGiaiDoan = :COPDGiaiDoan,
                    HenMucDoKieuSoat = :HenMucDoKieuSoat,
                    CMU = :CMU,
                    MaSo = :MaSo,
                    XQuangNguc = :XQuangNguc,
                    DienTim = :DienTim,
                    PH = :PH,
                    PaCO2 = :PaCO2,
                    PO2 = :PO2,
                    SaO2 = :SaO2,
                    SpO2 = :SpO2,
                    XNCTM = :XNCTM,
                    HCT = :HCT,
                    HBGDL  = :HBGDL,
                    SieuAmTim  = :SieuAmTim,
                    XetNghiemKhac  = :XetNghiemKhac,
                    DieuTriHienTai = :DieuTriHienTai,
                    DieuTriHienTaiKhac  = :DieuTriHienTaiKhac,
                    HoSoKemTheoKhac = :HoSoKemTheoKhac,
                    LuuY  = :LuuY,
                    PhimPhoi  = :PhimPhoi,
                    BenhKemTheo = :BenhKemTheo,
                    BacSi = :BacSi,
                    MaBacSi = :MaBacSi,
                    ListThongSo = :ListThongSo,
                    DoThongKhiPhoi = :DoThongKhiPhoi,
                    NgayXNKhiDongMachMau = :NgayXNKhiDongMachMau,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                     WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ketQua.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa", ketQua.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaKhoa", ketQua.MaKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("HoTen", ketQua.HoTen));
                Command.Parameters.Add(new MDB.MDBParameter("Tuoi", ketQua.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("GioiTinh", ketQua.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("NoiGioiThieu", ketQua.NoiGioiThieu));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", ketQua.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("NgayRaVien", ketQua.NgayRaVien));
                Command.Parameters.Add(new MDB.MDBParameter("LyDoChuyen", ketQua.LyDoChuyen));
                Command.Parameters.Add(new MDB.MDBParameter("COPDGiaiDoan", ketQua.COPDGiaiDoan));
                Command.Parameters.Add(new MDB.MDBParameter("HenMucDoKieuSoat", ketQua.HenMucDoKieuSoat));
                Command.Parameters.Add(new MDB.MDBParameter("CMU", ketQua.CMU));
                Command.Parameters.Add(new MDB.MDBParameter("MaSo", ketQua.MaSo));
                Command.Parameters.Add(new MDB.MDBParameter("XQuangNguc", ketQua.XQuangNguc));
                Command.Parameters.Add(new MDB.MDBParameter("DienTim", ketQua.DienTim));
                Command.Parameters.Add(new MDB.MDBParameter("PH", ketQua.PH));
                Command.Parameters.Add(new MDB.MDBParameter("PaCO2", ketQua.PaCO2));
                Command.Parameters.Add(new MDB.MDBParameter("PO2", ketQua.PO2));
                Command.Parameters.Add(new MDB.MDBParameter("SaO2", ketQua.SaO2));
                Command.Parameters.Add(new MDB.MDBParameter("SpO2", ketQua.SpO2));
                Command.Parameters.Add(new MDB.MDBParameter("XNCTM", ketQua.XNCTM));
                Command.Parameters.Add(new MDB.MDBParameter("HCT", ketQua.HCT));
                Command.Parameters.Add(new MDB.MDBParameter("HBGDL", ketQua.HBGDL));
                Command.Parameters.Add(new MDB.MDBParameter("SieuAmTim", ketQua.SieuAmTim));
                Command.Parameters.Add(new MDB.MDBParameter("XetNghiemKhac", ketQua.XetNghiemKhac));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriHienTai", ketQua.DieuTriHienTai));
                Command.Parameters.Add(new MDB.MDBParameter("DieuTriHienTaiKhac", ketQua.DieuTriHienTaiKhac));
                Command.Parameters.Add(new MDB.MDBParameter("HoSoKemTheoKhac", ketQua.HoSoKemTheoKhac));
                Command.Parameters.Add(new MDB.MDBParameter("LuuY", ketQua.LuuY));
                Command.Parameters.Add(new MDB.MDBParameter("PhimPhoi", ketQua.PhimPhoi));
                Command.Parameters.Add(new MDB.MDBParameter("BenhKemTheo", ketQua.BenhKemTheo));
                Command.Parameters.Add(new MDB.MDBParameter("BacSi", ketQua.BacSi));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSi", ketQua.MaBacSi));
                Command.Parameters.Add(new MDB.MDBParameter("ListThongSo", JsonConvert.SerializeObject(ketQua.ListThongSo)));

                Command.Parameters.Add(new MDB.MDBParameter("DoThongKhiPhoi", ketQua.DoThongKhiPhoi));
                Command.Parameters.Add(new MDB.MDBParameter("NgayXNKhiDongMachMau", ketQua.NgayXNKhiDongMachMau));

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
                string sql = "DELETE FROM PhieuChuyenDeTiepTucDieuTri WHERE ID = :ID";
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
                PhieuChuyenDeTiepTucDieuTri P
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "KQ");

            ds.Tables[0].AddColumn("NgayKiTen", typeof(string));

            ds.Tables[0].Rows[0]["NgayKiTen"] = "Ngày " + DateTime.Now.Day + " Tháng " + DateTime.Now.Month + " Năm " + DateTime.Now.Year;

            DataTable TK = new DataTable("TK");
            TK.Columns.Add("ThongSo", typeof(string));
            TK.Columns.Add("GiaTriTruocTestGPQ", typeof(string));
            TK.Columns.Add("PhanTramTruocTestGPQ", typeof(string));
            TK.Columns.Add("GiaTriSauTestGPQ", typeof(string));
            TK.Columns.Add("PhanTramSauTestGPQ", typeof(string));
            TK.Columns.Add("ThayDoiGPQ", typeof(string));
            TK.Columns.Add("KetQuaGPQ", typeof(string));
            ObservableCollection<ThongSoGPQ> ListThongSo = JsonConvert.DeserializeObject<ObservableCollection<ThongSoGPQ>>(ds.Tables[0].Rows[0]["ListThongSo"].ToString());
            if (ListThongSo != null)
            {
                foreach (ThongSoGPQ thongSoGPQ in ListThongSo)
                {
                    TK.Rows.Add(thongSoGPQ.ThongSo, thongSoGPQ.GiaTriTruocTestGPQ, thongSoGPQ.PhanTramTruocTestGPQ, thongSoGPQ.GiaTriSauTestGPQ, thongSoGPQ.PhanTramSauTestGPQ, thongSoGPQ.ThayDoiGPQ, thongSoGPQ.KetQuaGPQ);
                }
            }
            ds.Tables.Add(TK);

            return ds;
        }
    }
}
