
using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuKhaoSatLoet : ThongTinKy
    {
        public PhieuKhaoSatLoet()
        {
            TableName = "PhieuKhaoSatLoet";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PKSL;
            TenMauPhieu = DanhMucPhieu.PKSL.Description();
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
        [MoTaDuLieu("Cân nặng")]
		public string CanNang { get; set; }
        [MoTaDuLieu("Chiều cao")]
		public string ChieuCao { get; set; }
        [MoTaDuLieu("Chỉ số BMI")]
		public string BMI { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string MaHoSo { get; set; }
        public string KhoaDieuTri { get; set; }
        public string KhoaChuyenDen { get; set; }
        public DateTime? NgayVaoVien { get; set; }
        public DateTime? NgayChuyenKhoa { get; set; }
        public DateTime? NgayRaVien { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoanBenhChinh { get; set; }
        public string CacBenhKemTheo { get; set; }

        public ObservableCollection<KhaoSatTinhTrangLoet> ListKhaoSat { get; set; }

        public bool[] SauPTTimArray { get; } = new bool[] { false, false };
        public int SauPTTim
        {
            get
            {
                return Array.IndexOf(SauPTTimArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < SauPTTimArray.Length; i++)
                {
                    if (i == (value - 1)) SauPTTimArray[i] = true;
                    else SauPTTimArray[i] = false;
                }
            }
        }
        public bool[] ThoMayArray { get; } = new bool[] { false, false };
        public int ThoMay
        {
            get
            {
                return Array.IndexOf(ThoMayArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < ThoMayArray.Length; i++)
                {
                    if (i == (value - 1)) ThoMayArray[i] = true;
                    else ThoMayArray[i] = false;
                }
            }
        }
        public bool[] ThoiGianThoMayArray { get; } = new bool[] { false, false };
        public int ThoiGianThoMay
        {
            get
            {
                return Array.IndexOf(ThoiGianThoMayArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < ThoiGianThoMayArray.Length; i++)
                {
                    if (i == (value - 1)) ThoiGianThoMayArray[i] = true;
                    else ThoiGianThoMayArray[i] = false;
                }
            }
        }
        public bool[] TBMMNArray { get; } = new bool[] { false, false };
        public int TBMMN
        {
            get
            {
                return Array.IndexOf(TBMMNArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < TBMMNArray.Length; i++)
                {
                    if (i == (value - 1)) TBMMNArray[i] = true;
                    else TBMMNArray[i] = false;
                }
            }
        }
        public bool[] LietArray { get; } = new bool[] { false, false };
        public int Liet
        {
            get
            {
                return Array.IndexOf(LietArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < LietArray.Length; i++)
                {
                    if (i == (value - 1)) LietArray[i] = true;
                    else LietArray[i] = false;
                }
            }
        }
        public bool[] ThoiGianLoet1Array { get; } = new bool[] { false, false };
        public int ThoiGianLoet1
        {
            get
            {
                return Array.IndexOf(ThoiGianLoet1Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < ThoiGianLoet1Array.Length; i++)
                {
                    if (i == (value - 1)) ThoiGianLoet1Array[i] = true;
                    else ThoiGianLoet1Array[i] = false;
                }
            }
        }
        public bool[] ThoiGianLoet2Array { get; } = new bool[] { false, false };
        public int ThoiGianLoet2
        {
            get
            {
                return Array.IndexOf(ThoiGianLoet2Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < ThoiGianLoet2Array.Length; i++)
                {
                    if (i == (value - 1)) ThoiGianLoet2Array[i] = true;
                    else ThoiGianLoet2Array[i] = false;
                }
            }
        }
        public bool[] ThoiGianLoet3Array { get; } = new bool[] { false, false };
        public int ThoiGianLoet3
        {
            get
            {
                return Array.IndexOf(ThoiGianLoet3Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < ThoiGianLoet3Array.Length; i++)
                {
                    if (i == (value - 1)) ThoiGianLoet3Array[i] = true;
                    else ThoiGianLoet3Array[i] = false;
                }
            }
        }
        public bool[] ThoiGianLoet4Array { get; } = new bool[] { false, false };
        public int ThoiGianLoet4
        {
            get
            {
                return Array.IndexOf(ThoiGianLoet4Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < ThoiGianLoet4Array.Length; i++)
                {
                    if (i == (value - 1)) ThoiGianLoet4Array[i] = true;
                    else ThoiGianLoet4Array[i] = false;
                }
            }
        }
        public bool[] MucDoLoet1Array { get; } = new bool[] { false, false };
        public int MucDoLoet1
        {
            get
            {
                return Array.IndexOf(MucDoLoet1Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < MucDoLoet1Array.Length; i++)
                {
                    if (i == (value - 1)) MucDoLoet1Array[i] = true;
                    else MucDoLoet1Array[i] = false;
                }
            }
        }
        public bool[] MucDoLoet2Array { get; } = new bool[] { false, false };
        public int MucDoLoet2
        {
            get
            {
                return Array.IndexOf(MucDoLoet2Array, true) + 1;
            }
            set
            {
                for (int i = 0; i < MucDoLoet2Array.Length; i++)
                {
                    if (i == (value - 1)) MucDoLoet2Array[i] = true;
                    else MucDoLoet2Array[i] = false;
                }
            }
        }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        //public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
    }

    public class KhaoSatTinhTrangLoet
    {
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã định danh")]
		public long ID_Phieu { get; set; }

        public string ThoiGian { get; set; }
        public string MucDo1 { get; set; }
        public string MucDo2 { get; set; }
        public string MucDo3 { get; set; }
        public string MucDo4 { get; set; }
        public string TinhTrang1 { get; set; }
        public string TinhTrang2 { get; set; }
        public string TinhTrang3 { get; set; }
        public string ThayBang1 { get; set; }
        public string ThayBang2 { get; set; }
        public string ThayBang3 { get; set; }
        public string BienPhap1 { get; set; }
        public string BienPhap2 { get; set; }
        public string BienPhap3 { get; set; }

    }
    public class PhieuKhaoSatLoetFunc
    {
        public const string TableName = "PhieuKhaoSatLoet";
        public const string TablePrimaryKeyName = "ID";

        public static List<PhieuKhaoSatLoet> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuKhaoSatLoet> list = new List<PhieuKhaoSatLoet>();
            try
            {
                string sql = @"SELECT * FROM PhieuKhaoSatLoet where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuKhaoSatLoet data = new PhieuKhaoSatLoet();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;

                    data.MaBenhNhan = XemBenhAn._HanhChinhBenhNhan.MaBenhNhan;
                    data.TenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();

                    data.CanNang = DataReader["CanNang"].ToString();
                    data.ChieuCao = DataReader["ChieuCao"].ToString();
                    data.BMI = DataReader["BMI"].ToString();
                    data.DiaChi = DataReader["DiaChi"].ToString();
                    data.SDT = DataReader["SDT"].ToString();
                    data.MaHoSo = DataReader["MaHoSo"].ToString();
                    data.KhoaChuyenDen = DataReader["KhoaChuyenDen"].ToString();
                    data.KhoaDieuTri = DataReader["KhoaDieuTri"].ToString();
                    data.ChanDoanBenhChinh = DataReader["ChanDoanBenhChinh"].ToString();
                    data.CacBenhKemTheo = DataReader["CacBenhKemTheo"].ToString();
                    
                    data.NgayVaoVien = Convert.ToDateTime(DataReader["NgayVaoVien"] == DBNull.Value ? DateTime.Now : DataReader["NgayVaoVien"]);
                    data.NgayChuyenKhoa = Convert.ToDateTime(DataReader["NgayChuyenKhoa"] == DBNull.Value ? DateTime.Now : DataReader["NgayChuyenKhoa"]);
                    data.NgayRaVien = Convert.ToDateTime(DataReader["NgayRaVien"] == DBNull.Value ? DateTime.Now : DataReader["NgayRaVien"]);

                    data.SauPTTim = DataReader.GetInt("SauPTTim");
                    data.ThoMay = DataReader.GetInt("ThoMay");
                    data.ThoiGianThoMay = DataReader.GetInt("ThoiGianThoMay");
                    data.TBMMN = DataReader.GetInt("TBMMN");
                    data.Liet = DataReader.GetInt("Liet");
                    data.ThoiGianLoet1 = DataReader.GetInt("ThoiGianLoet1");
                    data.ThoiGianLoet2 = DataReader.GetInt("ThoiGianLoet2");
                    data.ThoiGianLoet3 = DataReader.GetInt("ThoiGianLoet3");
                    data.ThoiGianLoet4 = DataReader.GetInt("ThoiGianLoet4");
                    data.MucDoLoet1 = DataReader.GetInt("MucDoLoet1");
                    data.MucDoLoet2 = DataReader.GetInt("MucDoLoet2");

                    data.ListKhaoSat = GetKhaoSat(_OracleConnection, data.ID);

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
        public static bool DeleteByIDPhieu(MDB.MDBConnection oracleConnection, decimal IDBienBan)
        {
            try
            {
                string sql = "";
                MDB.MDBCommand oracleCommand;
                sql = @"DELETE FROM PhieuKhaoSatLoet WHERE ID =" + IDBienBan;
                using (oracleCommand = new MDB.MDBCommand(sql, oracleConnection))
                {
                    oracleCommand.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                XuLyLoi.LogError(ex);
            }
            return false;
        }
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, long IDBienBan)
        {
            string sql = @"SELECT
                P.* 
            FROM
                PhieuKhaoSatLoet P
            WHERE
                ID = " + IDBienBan;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "TB");

            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(int));
            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh;

            DataTable KS =  Common.ListToDataTable(GetKhaoSat(MyConnection, IDBienBan), "KS");
            ds.Tables.Add(KS);
            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuKhaoSatLoet ketQua)
        {
            try
            {
                string sql = @"INSERT INTO PhieuKhaoSatLoet
                (
                    MaQuanLy,
                    CanNang,
                    ChieuCao,
                    BMI,
                    DiaChi,
                    SDT,
                    MaHoSo,
                    KhoaDieuTri,
                    KhoaChuyenDen,
                    NgayVaoVien,
                    NgayChuyenKhoa,
                    NgayRaVien,
                    ChanDoanBenhChinh,
                    CacBenhKemTheo,
                    SauPTTim,
                    ThoMay,
                    ThoiGianThoMay,
                    TBMMN,
                    Liet,
                    ThoiGianLoet1,
                    ThoiGianLoet2,
                    ThoiGianLoet3,
                    ThoiGianLoet4,
                    MucDoLoet1,
                    MucDoLoet2,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
                    :CanNang,
                    :ChieuCao,
                    :BMI,
                    :DiaChi,
                    :SDT,
                    :MaHoSo,
                    :KhoaDieuTri,
                    :KhoaChuyenDen,
                    :NgayVaoVien,
                    :NgayChuyenKhoa,
                    :NgayRaVien,
                    :ChanDoanBenhChinh,
                    :CacBenhKemTheo,
                    :SauPTTim,
                    :ThoMay,
                    :ThoiGianThoMay,
                    :TBMMN,
                    :Liet,
                    :ThoiGianLoet1,
                    :ThoiGianLoet2,
                    :ThoiGianLoet3,
                    :ThoiGianLoet4,
                    :MucDoLoet1,
                    :MucDoLoet2,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE PhieuKhaoSatLoet SET 
                    MaQuanLy = :MaQuanLy,
                    CanNang = :CanNang,
                    ChieuCao = :ChieuCao,
                    BMI = :BMI,
                    DiaChi = :DiaChi,
                    SDT = :SDT,
                    MaHoSo = :MaHoSo,
                    KhoaDieuTri = :KhoaDieuTri,
                    KhoaChuyenDen = :KhoaChuyenDen,
                    NgayVaoVien = :NgayVaoVien,
                    NgayChuyenKhoa = :NgayChuyenKhoa,
                    NgayRaVien = :NgayRaVien,
                    ChanDoanBenhChinh = :ChanDoanBenhChinh,
                    CacBenhKemTheo = :CacBenhKemTheo,
                    SauPTTim = :SauPTTim,
                    ThoMay = :ThoMay,
                    ThoiGianThoMay = :ThoiGianThoMay,
                    TBMMN = :TBMMN,
                    Liet = :Liet,
                    ThoiGianLoet1 = :ThoiGianLoet1,
                    ThoiGianLoet2 = :ThoiGianLoet2,
                    ThoiGianLoet3 = :ThoiGianLoet3,
                    ThoiGianLoet4 = :ThoiGianLoet4,
                    MucDoLoet1 = :MucDoLoet1,
                    MucDoLoet2 = :MucDoLoet2,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", ketQua.MaQuanLy));

                Command.Parameters.Add(new MDB.MDBParameter("CanNang", ketQua.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("ChieuCao", ketQua.ChieuCao));
                Command.Parameters.Add(new MDB.MDBParameter("BMI", ketQua.BMI));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", ketQua.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("SDT", ketQua.SDT));
                Command.Parameters.Add(new MDB.MDBParameter("MaHoSo", ketQua.MaHoSo));
                Command.Parameters.Add(new MDB.MDBParameter("KhoaDieuTri", ketQua.KhoaDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("KhoaChuyenDen", ketQua.KhoaChuyenDen));
                Command.Parameters.Add(new MDB.MDBParameter("NgayVaoVien", ketQua.NgayVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("NgayChuyenKhoa", ketQua.NgayChuyenKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("NgayRaVien", ketQua.NgayRaVien));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanBenhChinh", ketQua.ChanDoanBenhChinh));
                Command.Parameters.Add(new MDB.MDBParameter("CacBenhKemTheo", ketQua.CacBenhKemTheo));
                Command.Parameters.Add(new MDB.MDBParameter("SauPTTim", ketQua.SauPTTim));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianThoMay", ketQua.ThoiGianThoMay));
                Command.Parameters.Add(new MDB.MDBParameter("ThoMay", ketQua.ThoMay));
                Command.Parameters.Add(new MDB.MDBParameter("TBMMN", ketQua.TBMMN));
                Command.Parameters.Add(new MDB.MDBParameter("Liet", ketQua.Liet));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianLoet1", ketQua.ThoiGianLoet1));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianLoet2", ketQua.ThoiGianLoet2));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianLoet3", ketQua.ThoiGianLoet3));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGianLoet4", ketQua.ThoiGianLoet4));
                Command.Parameters.Add(new MDB.MDBParameter("MucDoLoet1", ketQua.MucDoLoet1));
                Command.Parameters.Add(new MDB.MDBParameter("MucDoLoet2", ketQua.MucDoLoet2));

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

        public static ObservableCollection<KhaoSatTinhTrangLoet> GetKhaoSat(MDB.MDBConnection _OracleConnection, long idPhieu)
        {
            ObservableCollection<KhaoSatTinhTrangLoet> KhaoSatTinhTrangLoets = new ObservableCollection<KhaoSatTinhTrangLoet>();
            try
            {
                string sql = @"SELECT * FROM KhaoSatTinhTrangLoet where ID_Phieu = :ID_Phieu ORDER BY ID asc";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID_Phieu", idPhieu));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    KhaoSatTinhTrangLoet data = new KhaoSatTinhTrangLoet();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.ID_Phieu = idPhieu;

                    data.ThoiGian = DataReader["ThoiGian"].ToString();
                    data.MucDo1 = DataReader["MucDo1"].ToString();
                    data.MucDo2 = DataReader["MucDo2"].ToString();
                    data.MucDo3 = DataReader["MucDo3"].ToString();
                    data.MucDo4 = DataReader["MucDo4"].ToString();
                    data.TinhTrang1 = DataReader["TinhTrang1"].ToString();
                    data.TinhTrang2 = DataReader["TinhTrang2"].ToString();
                    data.TinhTrang3 = DataReader["TinhTrang3"].ToString();
                    data.ThayBang1 = DataReader["ThayBang1"].ToString();
                    data.ThayBang2 = DataReader["ThayBang2"].ToString();
                    data.ThayBang3 = DataReader["ThayBang3"].ToString();
                    data.BienPhap1 = DataReader["BienPhap1"].ToString();
                    data.BienPhap2 = DataReader["BienPhap2"].ToString();
                    data.BienPhap3 = DataReader["BienPhap3"].ToString();

                    KhaoSatTinhTrangLoets.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return KhaoSatTinhTrangLoets;
        }
        public static bool DeleteKhaoSat(MDB.MDBConnection MyConnection, long id)
        {
            try
            {
                string sql = "DELETE FROM KhaoSatTinhTrangLoet WHERE ID = :ID";
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
        public static bool InsertOrUpdateKhaoSat(MDB.MDBConnection MyConnection, KhaoSatTinhTrangLoet _ThongSoDieuTri)
        {
            try
            {
                string sql = @"INSERT INTO KhaoSatTinhTrangLoet
                (
                    ID_Phieu,
                    ThoiGian,
                    MucDo1,
                    MucDo2,
                    MucDo3,
                    MucDo4,
                    TinhTrang1,
                    TinhTrang2,
                    TinhTrang3,
                    ThayBang1,
                    ThayBang2,
                    ThayBang3,
                    BienPhap1,
                    BienPhap2,
                    BienPhap3)  VALUES
                 (
				    :ID_Phieu,
                    :ThoiGian,
                    :MucDo1,
                    :MucDo2,
                    :MucDo3,
                    :MucDo4,
                    :TinhTrang1,
                    :TinhTrang2,
                    :TinhTrang3,
                    :ThayBang1,
                    :ThayBang2,
                    :ThayBang3,
                    :BienPhap1,
                    :BienPhap2,
                    :BienPhap3
                 )";
                if (_ThongSoDieuTri.ID != 0)
                {
                    sql = @"UPDATE KhaoSatTinhTrangLoet SET 
                    ID_Phieu = :ID_Phieu,
                    ThoiGian = :ThoiGian,
                    MucDo1 = :MucDo1,
                    MucDo2 = :MucDo2,
                    MucDo3 = :MucDo3,
                    MucDo4 = :MucDo4,
                    TinhTrang1 = :TinhTrang1,
                    TinhTrang2 = :TinhTrang2,
                    TinhTrang3 = :TinhTrang3,
                    ThayBang1 = :ThayBang1,
                    ThayBang2 = :ThayBang2,
                    ThayBang3 = :ThayBang3,
                    BienPhap1 = :BienPhap1,
                    BienPhap2 = :BienPhap2,
                    BienPhap3 = :BienPhap3
                    WHERE ID = " + _ThongSoDieuTri.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID_Phieu", _ThongSoDieuTri.ID_Phieu));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGian", _ThongSoDieuTri.ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("MucDo1", _ThongSoDieuTri.MucDo1));
                Command.Parameters.Add(new MDB.MDBParameter("MucDo2", _ThongSoDieuTri.MucDo2));
                Command.Parameters.Add(new MDB.MDBParameter("MucDo3", _ThongSoDieuTri.MucDo3));
                Command.Parameters.Add(new MDB.MDBParameter("MucDo4", _ThongSoDieuTri.MucDo4));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrang1", _ThongSoDieuTri.TinhTrang1));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrang2", _ThongSoDieuTri.TinhTrang2));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrang3", _ThongSoDieuTri.TinhTrang3));
                Command.Parameters.Add(new MDB.MDBParameter("ThayBang1", _ThongSoDieuTri.ThayBang1));
                Command.Parameters.Add(new MDB.MDBParameter("ThayBang2", _ThongSoDieuTri.ThayBang2));
                Command.Parameters.Add(new MDB.MDBParameter("ThayBang3", _ThongSoDieuTri.ThayBang3));
                Command.Parameters.Add(new MDB.MDBParameter("BienPhap1", _ThongSoDieuTri.BienPhap1));
                Command.Parameters.Add(new MDB.MDBParameter("BienPhap2", _ThongSoDieuTri.BienPhap2));
                Command.Parameters.Add(new MDB.MDBParameter("BienPhap3", _ThongSoDieuTri.BienPhap3));

                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
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
