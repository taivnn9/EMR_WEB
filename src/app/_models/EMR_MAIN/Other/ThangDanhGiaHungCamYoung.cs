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
    public class ThangDanhGiaHungCamYoung : ThongTinKy
    {
        public ThangDanhGiaHungCamYoung()
        {
            TableName = "ThangDanhGiaHungCamYoung";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.TDGHCY;
            TenMauPhieu = DanhMucPhieu.TDGHCY.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        public string HoTenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        [MoTaDuLieu("Nghề nghiệp")]
		public string NgheNghiep { get; set; }
        public DateTime NgayLamTest { get; set; }

        public bool[] KhiSacTangArray { get; } = new bool[] { false, false, false, false, false };
        public int KhiSacTang
        {
            get
            {
                return Array.IndexOf(KhiSacTangArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < KhiSacTangArray.Length; i++)
                {
                    if (i == (value - 1)) KhiSacTangArray[i] = true;
                    else KhiSacTangArray[i] = false;
                }
            }
        }
        public bool[] TangHoatDongArray { get; } = new bool[] { false, false, false, false, false };
        public int TangHoatDong
        {
            get
            {
                return Array.IndexOf(TangHoatDongArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < TangHoatDongArray.Length; i++)
                {
                    if (i == (value - 1)) TangHoatDongArray[i] = true;
                    else TangHoatDongArray[i] = false;
                }
            }
        }
        public bool[] HoatDongTinhDucArray { get; } = new bool[] { false, false, false, false, false };
        public int HoatDongTinhDuc
        {
            get
            {
                return Array.IndexOf(HoatDongTinhDucArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < HoatDongTinhDucArray.Length; i++)
                {
                    if (i == (value - 1)) HoatDongTinhDucArray[i] = true;
                    else HoatDongTinhDucArray[i] = false;
                }
            }
        }
        public bool[] NguArray { get; } = new bool[] { false, false, false, false, false };
        public int Ngu
        {
            get
            {
                return Array.IndexOf(NguArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < NguArray.Length; i++)
                {
                    if (i == (value - 1)) NguArray[i] = true;
                    else NguArray[i] = false;
                }
            }
        }
        public bool[] DeBiKichThichArray { get; } = new bool[] { false, false, false, false, false };
        public int DeBiKichThich
        {
            get
            {
                return Array.IndexOf(DeBiKichThichArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < DeBiKichThichArray.Length; i++)
                {
                    if (i == (value - 1)) DeBiKichThichArray[i] = true;
                    else DeBiKichThichArray[i] = false;
                }
            }
        }
        public bool[] NoiArray { get; } = new bool[] { false, false, false, false, false };
        public int Noi
        {
            get
            {
                return Array.IndexOf(NoiArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < NoiArray.Length; i++)
                {
                    if (i == (value - 1)) NoiArray[i] = true;
                    else NoiArray[i] = false;
                }
            }
        }
        public bool[] RoiLoanHinhThucArray { get; } = new bool[] { false, false, false, false, false };
        public int RoiLoanHinhThuc
        {
            get
            {
                return Array.IndexOf(RoiLoanHinhThucArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < RoiLoanHinhThucArray.Length; i++)
                {
                    if (i == (value - 1)) RoiLoanHinhThucArray[i] = true;
                    else RoiLoanHinhThucArray[i] = false;
                }
            }
        }
        public bool[] NoiDungThamKhamArray { get; } = new bool[] { false, false, false, false, false };
        public int NoiDungThamKham
        {
            get
            {
                return Array.IndexOf(NoiDungThamKhamArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < NoiDungThamKhamArray.Length; i++)
                {
                    if (i == (value - 1)) NoiDungThamKhamArray[i] = true;
                    else NoiDungThamKhamArray[i] = false;
                }
            }
        }
        public bool[] HanhViKichDongArray { get; } = new bool[] { false, false, false, false, false };
        public int HanhViKichDong
        {
            get
            {
                return Array.IndexOf(HanhViKichDongArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < HanhViKichDongArray.Length; i++)
                {
                    if (i == (value - 1)) HanhViKichDongArray[i] = true;
                    else HanhViKichDongArray[i] = false;
                }
            }
        }
        public bool[] BieuHienBenNgoaiArray { get; } = new bool[] { false, false, false, false, false };
        public int BieuHienBenNgoai
        {
            get
            {
                return Array.IndexOf(BieuHienBenNgoaiArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < BieuHienBenNgoaiArray.Length; i++)
                {
                    if (i == (value - 1)) BieuHienBenNgoaiArray[i] = true;
                    else BieuHienBenNgoaiArray[i] = false;
                }
            }
        }

        public bool[] TuNhanThucArray { get; } = new bool[] { false, false, false, false, false };
        public int TuNhanThuc
        {
            get
            {
                return Array.IndexOf(TuNhanThucArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < TuNhanThucArray.Length; i++)
                {
                    if (i == (value - 1)) TuNhanThucArray[i] = true;
                    else TuNhanThucArray[i] = false;
                }
            }
        }
        public string TongDiem { get; set; }
        public string NguoiLamTest { get; set; }
        public string MaNguoiLamTest { get; set; }
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
    public class ThangDanhGiaHungCamYoungFunc
    {
        public const string TableName = "ThangDanhGiaHungCamYoung";
        public const string TablePrimaryKeyName = "ID";
        public static List<ThangDanhGiaHungCamYoung> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<ThangDanhGiaHungCamYoung> list = new List<ThangDanhGiaHungCamYoung>();
            try
            {
                string sql = @"SELECT * FROM ThangDanhGiaHungCamYoung where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    ThangDanhGiaHungCamYoung data = new ThangDanhGiaHungCamYoung();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.HoTenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.DiaChi = DataReader["DiaChi"].ToString();
                    data.NgheNghiep = DataReader["NgheNghiep"].ToString();
                    int tempInt = 0;

                    data.NgayLamTest = Convert.ToDateTime(DataReader["NgayLamTest"] == DBNull.Value ? DateTime.Now : DataReader["NgayLamTest"]);

                    data.KhiSacTang = int.TryParse(DataReader["KhiSacTang"].ToString(), out tempInt) ? tempInt : 0;

                    tempInt = 0;
                    data.TangHoatDong = int.TryParse(DataReader["TangHoatDong"].ToString(), out tempInt) ? tempInt : 0;

                    tempInt = 0;
                    data.HoatDongTinhDuc = int.TryParse(DataReader["HoatDongTinhDuc"].ToString(), out tempInt) ? tempInt : 0;

                    tempInt = 0;
                    data.Ngu = int.TryParse(DataReader["Ngu"].ToString(), out tempInt) ? tempInt : 0;

                    tempInt = 0;
                    data.DeBiKichThich = int.TryParse(DataReader["DeBiKichThich"].ToString(), out tempInt) ? tempInt : 0;

                    tempInt = 0;
                    data.Noi = int.TryParse(DataReader["Noi"].ToString(), out tempInt) ? tempInt : 0;

                    tempInt = 0;
                    data.RoiLoanHinhThuc = int.TryParse(DataReader["RoiLoanHinhThuc"].ToString(), out tempInt) ? tempInt : 0;

                    tempInt = 0;
                    data.NoiDungThamKham = int.TryParse(DataReader["NoiDungThamKham"].ToString(), out tempInt) ? tempInt : 0;

                    tempInt = 0;
                    data.HanhViKichDong = int.TryParse(DataReader["HanhViKichDong"].ToString(), out tempInt) ? tempInt : 0;

                    tempInt = 0;
                    data.BieuHienBenNgoai = int.TryParse(DataReader["BieuHienBenNgoai"].ToString(), out tempInt) ? tempInt : 0;
                    
                    tempInt = 0;
                    data.TuNhanThuc = int.TryParse(DataReader["TuNhanThuc"].ToString(), out tempInt) ? tempInt : 0;

                    data.TongDiem = DataReader["TongDiem"].ToString();
                    data.NguoiLamTest = DataReader["NguoiLamTest"].ToString();
                    data.MaNguoiLamTest = DataReader["MaNguoiLamTest"].ToString();

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref ThangDanhGiaHungCamYoung ketQua)
        {
            try
            {
                string sql = @"INSERT INTO ThangDanhGiaHungCamYoung
                (
                    MAQUANLY,
                    MaBenhNhan,
                    ChanDoan,
                    DiaChi, 
                    NgheNghiep, 
                    NgayLamTest,
                    KhiSacTang,
                    TangHoatDong,
                    HoatDongTinhDuc,
                    Ngu,
                    DeBiKichThich,
                    Noi,
                    RoiLoanHinhThuc,
                    NoiDungThamKham,
                    HanhViKichDong,
                    BieuHienBenNgoai,
                    TuNhanThuc,
                    TongDiem,
                    NguoiLamTest,
                    MaNguoiLamTest,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :ChanDoan,
                    :DiaChi, 
                    :NgheNghiep, 
                    :NgayLamTest,
                    :KhiSacTang,
                    :TangHoatDong,
                    :HoatDongTinhDuc,
                    :Ngu,
                    :DeBiKichThich,
                    :Noi,
                    :RoiLoanHinhThuc,
                    :NoiDungThamKham,
                    :HanhViKichDong,
                    :BieuHienBenNgoai,
                    :TuNhanThuc,
                    :TongDiem,
                    :NguoiLamTest,
                    :MaNguoiLamTest,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE ThangDanhGiaHungCamYoung SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    ChanDoan = :ChanDoan,
                    DiaChi = :DiaChi, 
                    NgheNghiep = :NgheNghiep, 
                    NgayLamTest = :NgayLamTest,
                    KhiSacTang = :KhiSacTang,
                    TangHoatDong = :TangHoatDong,
                    HoatDongTinhDuc =:HoatDongTinhDuc,
                    Ngu = :Ngu,
                    DeBiKichThich = :DeBiKichThich,
                    Noi = :Noi,
                    RoiLoanHinhThuc = :RoiLoanHinhThuc,
                    NoiDungThamKham = :NoiDungThamKham,
                    HanhViKichDong = :HanhViKichDong,
                    BieuHienBenNgoai = :BieuHienBenNgoai,
                    TuNhanThuc = :TuNhanThuc,
                    TongDiem = :TongDiem,
                    NguoiLamTest = :NguoiLamTest,
                    MaNguoiLamTest = :MaNguoiLamTest,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ketQua.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", ketQua.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", ketQua.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("NgheNghiep", ketQua.NgheNghiep));
                Command.Parameters.Add(new MDB.MDBParameter("NgayLamTest", ketQua.NgayLamTest));
                Command.Parameters.Add(new MDB.MDBParameter("KhiSacTang", ketQua.KhiSacTang));
                Command.Parameters.Add(new MDB.MDBParameter("TangHoatDong", ketQua.TangHoatDong));
                Command.Parameters.Add(new MDB.MDBParameter("HoatDongTinhDuc", ketQua.HoatDongTinhDuc));
                Command.Parameters.Add(new MDB.MDBParameter("Ngu", ketQua.Ngu));
                Command.Parameters.Add(new MDB.MDBParameter("DeBiKichThich", ketQua.DeBiKichThich));
                Command.Parameters.Add(new MDB.MDBParameter("Noi", ketQua.Noi));
                Command.Parameters.Add(new MDB.MDBParameter("RoiLoanHinhThuc", ketQua.RoiLoanHinhThuc));
                Command.Parameters.Add(new MDB.MDBParameter("NoiDungThamKham", ketQua.NoiDungThamKham));
                Command.Parameters.Add(new MDB.MDBParameter("HanhViKichDong", ketQua.HanhViKichDong));
                Command.Parameters.Add(new MDB.MDBParameter("BieuHienBenNgoai", ketQua.BieuHienBenNgoai));
                Command.Parameters.Add(new MDB.MDBParameter("TuNhanThuc", ketQua.TuNhanThuc));
                Command.Parameters.Add(new MDB.MDBParameter("TongDiem", ketQua.TongDiem));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiLamTest", ketQua.NguoiLamTest));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiLamTest", ketQua.MaNguoiLamTest));
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
                string sql = "DELETE FROM ThangDanhGiaHungCamYoung WHERE ID = :ID";
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
                ThangDanhGiaHungCamYoung P
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "KQ");

            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(int));
            ds.Tables[0].AddColumn("SOYTE", typeof(string));
            ds.Tables[0].AddColumn("BENHVIEN", typeof(string));
            ds.Tables[0].AddColumn("KHOA", typeof(string));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["GioiTinh"] = (int)XemBenhAn._HanhChinhBenhNhan.GioiTinh;
            ds.Tables[0].Rows[0]["SOYTE"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["KHOA"] = XemBenhAn._ThongTinDieuTri.Khoa;

            return ds;
        }
    }
}
