using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm.Native;
using DevExpress.XtraEditors.Filtering.Templates;
using EMR.KyDienTu;
using EMR_MAIN.ChucNangKhac;
using EMR_MAIN.Converter;
using MDB;
using Newtonsoft.Json;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class NoiDungDGBG
    {
        public int STT { get; set; }
        public string NoiDung { get; set; }
        public bool[] NG_Arr { get; } = new bool[] { false, false };
        public string NG
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < NG_Arr.Length; i++)
                    temp += (NG_Arr[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NG_Arr[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] NN_Arr { get; } = new bool[] { false, false };
        public string NN
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < NN_Arr.Length; i++)
                    temp += (NN_Arr[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NN_Arr[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public ThuocVatTu Clone()
        {
            ThuocVatTu other = (ThuocVatTu)this.MemberwiseClone();
            return other;
        }
    }
    public class PCBVBGNBTPTTT : ThongTinKy
    {
        public PCBVBGNBTPTTT()
        {
            TableName = "PCBVBGNBTPTTT";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PCBVBGNBTPTTT;
            TenMauPhieu = DanhMucPhieu.PCBVBGNBTPTTT.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }
        [MoTaDuLieu("Tên khoa")]
		public string TenKhoa { get; set; }
        [MoTaDuLieu("Mã giường")]
		public string MaGiuong { get; set; }
        [MoTaDuLieu("Giường")]
		public string Giuong { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public string ThuThuat { get; set; }
        public bool[] LoaiPT_Array { get; } = new bool[] { false, false };
        public string LoaiPT
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < LoaiPT_Array.Length; i++)
                    temp += (LoaiPT_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        LoaiPT_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] TSDU_Array { get; } = new bool[] { false, false };
        public string TSDU
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TSDU_Array.Length; i++)
                    temp += (TSDU_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TSDU_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Cân nặng")]
		public string CanNang { get; set; }
        [MoTaDuLieu("Mạch")]
		public string Mach { get; set; }
        public string T { get; set; }
        [MoTaDuLieu("Huyết áp")]
		public string HA { get; set; }
        public DateTime NgayLamThuThuat { get; set; }
        public ObservableCollection<NoiDungDGBG> lstDGNB { get; set; }
        public ObservableCollection<NoiDungDGBG> lstDGHSBA { get; set; }
        public string MaNCB { get; set; }
        public string TenNCB { get; set; }
        public string MaNBG { get; set; }
        public string TenBG { get; set; }
        public string MaNN { get; set; }
        public string TenNN { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        public string SoYTe
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.SoYTe;
            }
        }
        public string BenhVien
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.BenhVien;
            }
        }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.Tuoi;
            }
        }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            }
        }
        public string SoVaoVien
        {
            get
            {
                return XemBenhAn._ThongTinDieuTri.SoNhapVien;
            }
        }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            }
        }
        public string MaBenhAn
        {
            get
            {
                return XemBenhAn._ThongTinDieuTri.MaBenhAn;
            }
        }
    }
    public class PCBVBGNBTPTTTFunc
    {
        public const string TableName = "PCBVBGNBTPTTT";
        public const string TablePrimaryKeyName = "ID";
        public static List<PCBVBGNBTPTTT> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PCBVBGNBTPTTT> list = new List<PCBVBGNBTPTTT>();
            try
            {

                string sql = @"SELECT * FROM PCBVBGNBTPTTT where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    try
                    {
                        PCBVBGNBTPTTT data = new PCBVBGNBTPTTT();
                        data.ID = DataReader.GetLong("ID");
                        data.MaQuanLy = Common.ConDB_Decimal(DataReader["MaQuanLy"]);
                        data.MaBenhNhan = Common.ConDBNull(DataReader["MABENHNHAN"]);
                        data.ChanDoan = Common.ConDBNull(DataReader["ChanDoan"]);
                        data.MaKhoa = Common.ConDBNull(DataReader["MaKhoa"]);
                        data.TenKhoa = Common.ConDBNull(DataReader["TenKhoa"]);
                        data.MaGiuong = Common.ConDBNull(DataReader["MaGiuong"]);
                        data.Giuong = Common.ConDBNull(DataReader["Giuong"]);
                        data.ThuThuat = Common.ConDBNull(DataReader["ThuThuat"]);
                        data.NgayLamThuThuat = Common.ConDB_DateTime(DataReader["NgayLamThuThuat"]);
                        data.lstDGNB = JsonConvert.DeserializeObject<ObservableCollection<NoiDungDGBG>>(Common.ConDBNull(DataReader["lstDGNB"]));
                        data.lstDGHSBA = JsonConvert.DeserializeObject<ObservableCollection<NoiDungDGBG>>(Common.ConDBNull(DataReader["lstDGHSBA"]));
                        data.LoaiPT = Common.ConDBNull(DataReader["LoaiPT"]);
                        data.TSDU = Common.ConDBNull(DataReader["TSDU"]);
                        data.CanNang = Common.ConDBNull(DataReader["CanNang"]);
                        data.Mach = Common.ConDBNull(DataReader["Mach"]);
                        data.T = Common.ConDBNull(DataReader["T"]);
                        data.HA = Common.ConDBNull(DataReader["HA"]);
                        data.MaNCB = Common.ConDBNull(DataReader["MaNCB"]);
                        data.TenNCB = Common.ConDBNull(DataReader["TenNCB"]);
                        data.MaNBG = Common.ConDBNull(DataReader["MaNBG"]);
                        data.TenBG = Common.ConDBNull(DataReader["TenBG"]);
                        data.MaNN = Common.ConDBNull(DataReader["MaNN"]);
                        data.TenNN = Common.ConDBNull(DataReader["TenNN"]);
                        data.NguoiTao = Common.ConDBNull(DataReader["NguoiTao"]);
                        data.NguoiSua = Common.ConDBNull(DataReader["NguoiSua"]);
                        data.NgayTao = Common.ConDB_DateTime(DataReader["NgayTao"]);
                        data.NgaySua = Common.ConDB_DateTime(DataReader["NgaySua"]);
                        data.NgayKy = Common.ConDB_DateTime(DataReader["NGAYKY"]);
                        data.ComputerKyTen = Common.ConDBNull(DataReader["COMPUTERKYTEN"]);
                        data.MaSoKy = Common.ConDBNull(DataReader["MASOKYTEN"]);
                        data.TenFileKy = Common.ConDBNull(DataReader["TENFILEKY"]);
                        data.UserNameKy = Common.ConDBNull(DataReader["USERNAMEKY"]);
                        data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;
                        list.Add(data);
                    }
                    catch (Exception ex)
                    {
                        MDB.ExceptionExtend.LogError(ex);
                    }
                }
                DataReader.Close();
                DataReader = null;
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PCBVBGNBTPTTT objData)
        {
            string sql;
            int n = 0;
            if (objData.ID == 0)
            {
                sql = @"INSERT INTO PCBVBGNBTPTTT (
                                    maquanly,MaKhoa,TenKhoa,MaGiuong,Giuong,
                                    mabenhnhan,
                                    ChanDoan,
                                    ThuThuat,
                                    NgayLamThuThuat,
                                    lstDGNB,lstDGHSBA,
                                    LoaiPT,
                                    TSDU,CanNang,Mach,T,HA,MaNCB,TenNCB,MaNBG,TenBG,MaNN,TenNN,
                                    NgayTao,
                                    NguoiTao,
                                    NgaySua,
                                    NguoiSua
                                ) VALUES (
                                    :maquanly,:MaKhoa,:TenKhoa,:MaGiuong,:Giuong,
                                    :mabenhnhan,
                                    :ChanDoan,
                                    :ThuThuat,
                                    :NgayLamThuThuat,
                                    :lstDGNB,:lstDGHSBA,
                                    :LoaiPT,
                                    :TSDU,:CanNang,:Mach,:T,:HA,:MaNCB,:TenNCB,:MaNBG,:TenBG,:MaNN,:TenNN,
                                    :NgayTao,
                                    :NguoiTao,
                                    :NgaySua,
                                    :NguoiSua
                                ) RETURNING ID INTO :ID";
            }

            else
            {
                sql = @"UPDATE PCBVBGNBTPTTT SET  
                                         maquanly = :maquanly,MaKhoa =:MaKhoa,TenKhoa =:TenKhoa,MaGiuong =:MaGiuong,Giuong =:Giuong,
                                         mabenhnhan = :mabenhnhan,
                                         ChanDoan = :ChanDoan,
                                         ThuThuat = :ThuThuat,
                                         NgayLamThuThuat = :NgayLamThuThuat,
                                         lstDGNB = :lstDGNB,lstDGHSBA=:lstDGHSBA,
                                        LoaiPT =:LoaiPT,
                                        TSDU=:TSDU,CanNang=:CanNang,Mach=:Mach,T=:T,HA=:HA,MaNCB=:MaNCB,TenNCB=:TenNCB,MaNBG=:MaNBG,TenBG=:TenBG,MaNN=:MaNN,TenNN=:TenNN,
                                         nguoisua = :nguoisua,
                                         ngaysua = :ngaysua 
                                        WHERE ID = :ID";

            }

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("maquanly", objData.MaQuanLy));
            Command.Parameters.Add(new MDB.MDBParameter("MaKhoa", objData.MaKhoa));
            Command.Parameters.Add(new MDB.MDBParameter("TenKhoa", objData.TenKhoa));
            Command.Parameters.Add(new MDB.MDBParameter("MaGiuong", objData.MaGiuong));
            Command.Parameters.Add(new MDB.MDBParameter("Giuong", objData.Giuong));
            Command.Parameters.Add(new MDB.MDBParameter("mabenhnhan", objData.MaBenhNhan));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", objData.ChanDoan));
            Command.Parameters.Add(new MDB.MDBParameter("ThuThuat", objData.ThuThuat));
            Command.Parameters.Add(new MDB.MDBParameter("NgayLamThuThuat", objData.NgayLamThuThuat));
            Command.Parameters.Add(new MDB.MDBParameter("lstDGNB", JsonConvert.SerializeObject(objData.lstDGNB)));
            Command.Parameters.Add(new MDB.MDBParameter("lstDGHSBA", JsonConvert.SerializeObject(objData.lstDGHSBA)));
            Command.Parameters.Add(new MDB.MDBParameter("LoaiPT", objData.LoaiPT));
            Command.Parameters.Add(new MDB.MDBParameter("TSDU", objData.TSDU));
            Command.Parameters.Add(new MDB.MDBParameter("CanNang", objData.CanNang));
            Command.Parameters.Add(new MDB.MDBParameter("Mach", objData.Mach));
            Command.Parameters.Add(new MDB.MDBParameter("T", objData.T));
            Command.Parameters.Add(new MDB.MDBParameter("HA", objData.HA));
            Command.Parameters.Add(new MDB.MDBParameter("MaNCB", objData.MaNCB));
            Command.Parameters.Add(new MDB.MDBParameter("TenNCB", objData.TenNCB));
            Command.Parameters.Add(new MDB.MDBParameter("MaNBG", objData.MaNBG));
            Command.Parameters.Add(new MDB.MDBParameter("TenBG", objData.TenBG));
            Command.Parameters.Add(new MDB.MDBParameter("MaNN", objData.MaNN));
            Command.Parameters.Add(new MDB.MDBParameter("TenNN", objData.TenNN));
            Command.Parameters.Add(new MDB.MDBParameter("nguoisua", Common.getUserLogin()));
            Command.Parameters.Add(new MDB.MDBParameter("ngaysua", DateTime.Now));
            Command.Parameters.Add(new MDB.MDBParameter("ID", objData.ID));
            if (objData.ID == 0)
            {
                Command.Parameters.Add(new MDB.MDBParameter("nguoitao", Common.getUserLogin()));
                Command.Parameters.Add(new MDB.MDBParameter("ngaytao", DateTime.Now));
            }
            Command.BindByName = true;
            n = Command.ExecuteNonQuery();
            if (n > 0)
            {
                if (objData.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    objData.ID = nextval;
                }
            }
            return n > 0 ? true : false;
        }

        public static bool Delete(MDB.MDBConnection MyConnection, decimal ID)
        {
            string sql = "DELETE FROM PCBVBGNBTPTTT WHERE ID = :ID";
            MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
            command.Parameters.Add(new MDB.MDBParameter("ID", ID));
            command.BindByName = true;
            int n = command.ExecuteNonQuery();
            return n > 0 ? true : false;
        }
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, decimal ID)
        {
            string sql2 = @"SELECT D.*, '' SoNhapVien, '' MaBenhAn , '' SoVaoVien, '' TenBenhNhan,
                        '' TUOI, '' SoYTe, '' BENHVIEN,
                        '' GioiTinh
            FROM
                PCBVBGNBTPTTT D
            WHERE
                ID = :ID";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql2, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("ID", ID));

            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            adt.Fill(ds);
            if (ds != null || ds.Tables[0].Rows.Count > 0)
            {
                ds.Tables[0].Rows[0]["SoNhapVien"] = XemBenhAn._ThongTinDieuTri.SoNhapVien;
                ds.Tables[0].Rows[0]["MaBenhAn"] = XemBenhAn._ThongTinDieuTri.MaBenhAn;
                ds.Tables[0].Rows[0]["SoVaoVien"] = XemBenhAn._ThongTinDieuTri.SoNhapVien;
                ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                ds.Tables[0].Rows[0]["TUOI"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                ds.Tables[0].Rows[0]["SoYTe"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
                ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
                ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            }
            List<NoiDungDGBG> lstDGNB = new List<NoiDungDGBG>();
            if (ds.Tables[0].Rows.Count > 0)
            {
                lstDGNB = JsonConvert.DeserializeObject<ObservableCollection<NoiDungDGBG>>(Common.ConDBNull(ds.Tables[0].Rows[0]["lstDGNB"])).ToList();
            }
            DataTable dttbl1 = new DataTable();
            dttbl1 = ListToDatatable.ToDataTable(lstDGNB);
            ds.Tables.Add(dttbl1);
            ds.Tables[1].TableName = "NoiDungDGBG_NB";
            List<NoiDungDGBG> lstDGHSBA = new List<NoiDungDGBG>();
            if (ds.Tables[0].Rows.Count > 0)
            {
                lstDGHSBA = JsonConvert.DeserializeObject<ObservableCollection<NoiDungDGBG>>(Common.ConDBNull(ds.Tables[0].Rows[0]["lstDGHSBA"])).ToList();
            }

            DataTable dttbl2 = new DataTable();
            dttbl2 = ListToDatatable.ToDataTable(lstDGHSBA);
            ds.Tables.Add(dttbl2);
            ds.Tables[2].TableName = "NoiDungDGBG_HSBA";
            return ds;
        }
    }
}
