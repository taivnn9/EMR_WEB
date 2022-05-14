using EMR_MAIN.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using EMR.KyDienTu;

namespace EMR_MAIN.DATABASE.Other
{
    public class HSCS_TTBenhNhanVaoVien
    {
        [MoTaDuLieu("Mã định danh")]
		public long Id { get; set; }
        public decimal Id_hscs_ttbenhnhan { get; set; }
        public string TTBN_TienSuBenh { get; set; }
        [MoTaDuLieu("Nhiệt độ")]
		public string NhietDo { get; set; }
        [MoTaDuLieu("Cân nặng")]
		public string CanNang { get; set; }
        [MoTaDuLieu("Chiều cao")]
		public string ChieuCao { get; set; }
        [MoTaDuLieu("Chỉ số BMI")]
		public string BMI { get; set; }
        public int Da { get; set; }
        public string Da_Text { get; set; }
        public int NiemMac { get; set; }
        public string NiemMac_Khac { get; set; }
        public int ThanKinh { get; set; }
        public int CoGiat { get; set; }
        public string ThanKinh_LyDoKhac { get; set; }
        public string HoHap_NhipTho { get; set; }
        public string HoHap_CRLN { get; set; }
        public string HoHap_SPO2 { get; set; }
        public bool[] HoHapArray { get; } = new bool[] { false, false, false, false, false, false, false, false,
            false, false, false, false, false, false, false, false, false, false };
        public string Hohap
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < HoHapArray.Length; i++)
                    temp += (HoHapArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        HoHapArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public int HoHap_Dom_SoLuong { get; set; }
        public int HoHap_Dom_MauSac { get; set; }
        public int HoHap_Dom_TCDom { get; set; }
        
        public string HoHap_OXYKINH { get; set; }
        public string HoHap_OXYMASK { get; set; }
        public string HoHap_ModeTho { get; set; }
        public string HoHap_FiO2 { get; set; }
        public DateTime HoHap_NgayDat { get; set; }
        public DateTime HoHap_NgayMo { get; set; }
        public string HoHap_MocCoDinh { get; set; }
        public string HoHap_Canuyl { get; set; }
        public string HoHap_TinhChatDomKhac { get; set; }
        public string TuanHoan_Mach { get; set; }
        public string TuanHoan_HA { get; set; }
        public bool[] TuanHoanArray { get; } = new bool[] { false, false, false, false, false};
        public string Tuanhoan
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TuanHoanArray.Length; i++)
                    temp += (TuanHoanArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TuanHoanArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public DateTime TuanHoan_NgayDat { get; set; }
        public string TuanHoan_ViTri { get; set; }
        public string TuanHoan_Chan { get; set; }
        public bool[] TieuHoaArray { get; } = new bool[] { false, false, false, false, false,false, false, false, false };
        public string Tieuhoa
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TieuHoaArray.Length; i++)
                    temp += (TieuHoaArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TieuHoaArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string TieuHoa_Non { get; set; }
        public string TieuHoa_DauBung_SoLan { get; set; }
        public string ThanTN_NuocTieu_SoLuong { get; set; }
        public string ThanTN_NuocTieu_MauSac { get; set; }
        public string ThanTN_NuocTieu_TinhChat { get; set; }
        public string ThanTN_DaiMau { get; set; }
        public int ThanTN { get; set; }
        public string VanDeBatThuongKhac { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Tên file ký")]
		public string TenFileKy { get; set; }
        [MoTaDuLieu("Tên người ký")]
		public string UserNameKy { get; set; }
        [MoTaDuLieu("Ngày ký")]
		public DateTime NgayKy { get; set; }
        [MoTaDuLieu("Tên máy tính ký")]
		public string ComputerKyTen { get; set; }
        public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
    }
    public class HSCS_TTBenhNhanVaoVienFunc
    {
        public const string TableName = "HSCS_TTBenhNhanVaoVien";
        public const string TablePrimaryKeyName = "ID";
        public static List<HSCS_TTBenhNhanVaoVien> GetListData(MDB.MDBConnection _OracleConnection, decimal id_hscs_ttbenhnhan)
        {
            List<HSCS_TTBenhNhanVaoVien> list = new List<HSCS_TTBenhNhanVaoVien>();
            try
            {
                string sql = @"SELECT * FROM HSCS_TTBenhNhanVaoVien where id_hscs_ttbenhnhan = :id_hscs_ttbenhnhan";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("id_hscs_ttbenhnhan", id_hscs_ttbenhnhan));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    HSCS_TTBenhNhanVaoVien data = new HSCS_TTBenhNhanVaoVien();
                    data.Id = DataReader.GetLong("id");
                    data.Id_hscs_ttbenhnhan = DataReader.GetDecimal("id_hscs_ttbenhnhan");
                    data.TTBN_TienSuBenh = DataReader.GetString("ttbn_tiensubenh");
                    data.NhietDo = DataReader.GetString("nhietdo");
                    data.CanNang = DataReader.GetString("cannang");
                    data.ChieuCao = DataReader.GetString("chieucao");
                    data.BMI = DataReader.GetString("bmi");
                    data.Da = DataReader.GetInt("Da");
                    data.Da_Text = DataReader.GetString("Da_Text");
                    data.NiemMac = DataReader.GetInt("NiemMac");
                    data.NiemMac_Khac = DataReader.GetString("niemmac_khac");
                    data.ThanKinh = DataReader.GetInt("ThanKinh");
                    data.CoGiat = DataReader.GetInt("CoGiat");
                    data.ThanKinh_LyDoKhac = DataReader.GetString("thankinh_lydokhac");
                    data.Hohap = DataReader.GetString("hohap");
                    data.HoHap_NhipTho = DataReader.GetString("hohap_nhiptho");
                    data.HoHap_CRLN = DataReader.GetString("hohap_crln");
                    data.HoHap_SPO2 = DataReader.GetString("hohap_spo2");
                    data.HoHap_OXYKINH = DataReader.GetString("hohap_oxykinh");
                    data.HoHap_OXYMASK = DataReader.GetString("hohap_oxymask");
                    data.HoHap_ModeTho = DataReader.GetString("hohap_modetho");
                    data.HoHap_FiO2 = DataReader.GetString("hohap_fio2");
                    data.HoHap_NgayDat = ConDB_DateTime(DataReader["hohap_ngaydat"]);
                    data.HoHap_NgayMo = ConDB_DateTime(DataReader["hohap_ngaymo"]);
                    data.HoHap_MocCoDinh = DataReader.GetString("hohap_moccodinh");
                    data.HoHap_Canuyl = DataReader.GetString("hohap_canuyl");
                    data.HoHap_TinhChatDomKhac = DataReader.GetString("hohap_tinhchatdomkhac");
                    data.Tuanhoan = DataReader.GetString("tuanhoan");
                    data.TuanHoan_Mach = DataReader.GetString("tuanhoan_mach");
                    data.TuanHoan_HA = DataReader.GetString("tuanhoan_ha");
                    data.TuanHoan_NgayDat = ConDB_DateTime(DataReader["tuanhoan_ngaydat"]);
                    data.TuanHoan_ViTri = DataReader.GetString("tuanhoan_vitri");
                    data.TuanHoan_Chan = DataReader.GetString("tuanhoan_chan");
                    data.Tieuhoa = DataReader.GetString("tieuhoa");
                    data.TieuHoa_Non = DataReader.GetString("tieuhoa_non");
                    data.TieuHoa_DauBung_SoLan = DataReader.GetString("tieuhoa_daubung_solan");
                    data.ThanTN = DataReader.GetInt("thantn");
                    data.ThanTN_DaiMau = DataReader.GetString("thantn_daimau");
                    data.ThanTN_NuocTieu_MauSac = DataReader.GetString("thantn_nuoctieu_mausac");
                    data.ThanTN_NuocTieu_SoLuong = DataReader.GetString("thantn_nuoctieu_soluong");
                    data.ThanTN_NuocTieu_TinhChat = DataReader.GetString("thantn_nuoctieu_tinhchat");
                    data.VanDeBatThuongKhac = DataReader.GetString("vandebatthuongkhac");

                    data.NguoiTao = DataReader.GetString("NguoiTao");
                    data.NguoiSua = DataReader.GetString("NguoiSua");
                    data.NgayTao = ConDB_DateTime(DataReader["NgayTao"]);
                    data.NgaySua = ConDB_DateTime(DataReader["NgaySua"]);
                    data.ComputerKyTen = DataReader.GetString("computerkyten");
                    data.MaSoKyTen = DataReader.GetString("MaSoKyTen");
                    data.TenFileKy = DataReader.GetString("TenFileKy");
                    data.UserNameKy = DataReader.GetString("UserNameKy");
                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static HSCS_TTBenhNhanVaoVien GetDataByIDTTBenhNhan(MDB.MDBConnection _OracleConnection, decimal id_hscs_ttbenhnhan)
        {
            HSCS_TTBenhNhanVaoVien data = null;
            try
            {
                string sql = @"SELECT * FROM HSCS_TTBenhNhanVaoVien where id_hscs_ttbenhnhan = :id_hscs_ttbenhnhan";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("id_hscs_ttbenhnhan", id_hscs_ttbenhnhan));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    data = new HSCS_TTBenhNhanVaoVien();
                    data.Id = DataReader.GetLong("id");
                    data.Id_hscs_ttbenhnhan = DataReader.GetDecimal("id_hscs_ttbenhnhan");
                    data.TTBN_TienSuBenh = DataReader.GetString("ttbn_tiensubenh");
                    data.NhietDo = DataReader.GetString("nhietdo");
                    data.CanNang = DataReader.GetString("cannang");
                    data.ChieuCao = DataReader.GetString("chieucao");
                    data.BMI = DataReader.GetString("bmi");
                    data.Da = DataReader.GetInt("Da");
                    data.Da_Text = DataReader.GetString("Da_Text");
                    data.NiemMac = DataReader.GetInt("NiemMac");
                    data.NiemMac_Khac = DataReader.GetString("niemmac_khac");
                    data.ThanKinh = DataReader.GetInt("ThanKinh");
                    data.CoGiat = DataReader.GetInt("CoGiat");
                    data.ThanKinh_LyDoKhac = DataReader.GetString("thankinh_lydokhac");
                    data.HoHap_Dom_SoLuong = DataReader.GetInt("HoHap_Dom_SoLuong");
                    data.HoHap_Dom_MauSac = DataReader.GetInt("HoHap_Dom_MauSac");
                    data.HoHap_Dom_TCDom = DataReader.GetInt("HoHap_Dom_TCDom");
                    data.Hohap = DataReader.GetString("hohap");
                    data.HoHap_NhipTho = DataReader.GetString("hohap_nhiptho");
                    data.HoHap_CRLN = DataReader.GetString("hohap_crln");
                    data.HoHap_SPO2 = DataReader.GetString("hohap_spo2");
                    data.HoHap_OXYKINH = DataReader.GetString("hohap_oxykinh");
                    data.HoHap_OXYMASK = DataReader.GetString("hohap_oxymask");
                    data.HoHap_ModeTho = DataReader.GetString("hohap_modetho");
                    data.HoHap_FiO2 = DataReader.GetString("hohap_fio2");
                    data.HoHap_NgayDat = ConDB_DateTime(DataReader["hohap_ngaydat"]);
                    data.HoHap_NgayMo = ConDB_DateTime(DataReader["hohap_ngaymo"]);
                    data.HoHap_MocCoDinh = DataReader.GetString("hohap_moccodinh");
                    data.HoHap_Canuyl = DataReader.GetString("hohap_canuyl");
                    data.HoHap_TinhChatDomKhac = DataReader.GetString("hohap_tinhchatdomkhac");
                    data.Tuanhoan = DataReader.GetString("tuanhoan");
                    data.TuanHoan_Mach = DataReader.GetString("tuanhoan_mach");
                    data.TuanHoan_HA = DataReader.GetString("tuanhoan_ha");
                    data.TuanHoan_NgayDat = ConDB_DateTime(DataReader["tuanhoan_ngaydat"]);
                    data.TuanHoan_ViTri = DataReader.GetString("tuanhoan_vitri");
                    data.TuanHoan_Chan = DataReader.GetString("tuanhoan_chan");
                    data.Tieuhoa = DataReader.GetString("tieuhoa");
                    data.TieuHoa_Non = DataReader.GetString("tieuhoa_non");
                    data.TieuHoa_DauBung_SoLan = DataReader.GetString("tieuhoa_daubung_solan");
                    data.ThanTN = DataReader.GetInt("thantn");
                    data.ThanTN_DaiMau = DataReader.GetString("thantn_daimau");
                    data.ThanTN_NuocTieu_MauSac = DataReader.GetString("thantn_nuoctieu_mausac");
                    data.ThanTN_NuocTieu_SoLuong = DataReader.GetString("thantn_nuoctieu_soluong");
                    data.ThanTN_NuocTieu_TinhChat = DataReader.GetString("thantn_nuoctieu_tinhchat");
                    data.VanDeBatThuongKhac = DataReader.GetString("vandebatthuongkhac");

                    data.NguoiTao = DataReader.GetString("NguoiTao");
                    data.NguoiSua = DataReader.GetString("NguoiSua");
                    data.NgayTao = ConDB_DateTime(DataReader["NgayTao"]);
                    data.NgaySua = ConDB_DateTime(DataReader["NgaySua"]);
                    data.ComputerKyTen = DataReader.GetString("computerkyten");
                    data.MaSoKyTen = DataReader.GetString("MaSoKyTen");
                    data.TenFileKy = DataReader.GetString("TenFileKy");
                    data.UserNameKy = DataReader.GetString("UserNameKy");
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return data;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref HSCS_TTBenhNhanVaoVien data)
        {
            try
            {
                string sql = @"INSERT INTO HSCS_TTBenhNhanVaoVien
                (
                    id_hscs_ttbenhnhan,
                    ttbn_tiensubenh,
                    nhietdo,
                    cannang,
                    chieucao,
                    bmi,
                    da,
                    da_text,
                    niemmac,
                    niemmac_khac,
                    thankinh,
                    CoGiat,    
                    thankinh_lydokhac,
                    HoHap_Dom_SoLuong,
                    HoHap_Dom_MauSac,
                    HoHap_Dom_TCDom,
                    hohap_nhiptho,
                    hohap_crln,
                    hohap_spo2,
                    hohap,
                    hohap_oxykinh,
                    hohap_oxymask,
                    hohap_modetho,
                    hohap_fio2,
                    hohap_ngaydat,
                    hohap_ngaymo,
                    hohap_moccodinh,
                    hohap_canuyl,
                    hohap_tinhchatdomkhac,
                    tuanhoan_mach,
                    tuanhoan_ha,
                    tuanhoan,
                    tuanhoan_ngaydat,
                    tuanhoan_vitri,
                    tuanhoan_chan,
                    tieuhoa,
                    tieuhoa_non,
                    tieuhoa_daubung_solan,
                    thantn_nuoctieu_soluong,
                    thantn_nuoctieu_mausac,
                    thantn_nuoctieu_tinhchat,
                    thantn_daimau,
                    thantn,
                    vandebatthuongkhac )  VALUES
                 (
                    :id_hscs_ttbenhnhan,
                    :ttbn_tiensubenh,
                    :nhietdo,
                    :cannang,
                    :chieucao,
                    :bmi,
                    :da,
                    :da_text,
                    :niemmac,
                    :niemmac_khac,
                    :thankinh,
                    :CoGiat,
                    :thankinh_lydokhac,
                    :HoHap_Dom_SoLuong,
                    :HoHap_Dom_MauSac,
                    :HoHap_Dom_TCDom,
                    :hohap_nhiptho,
                    :hohap_crln,
                    :hohap_spo2,
                    :hohap,
                    :hohap_oxykinh,
                    :hohap_oxymask,
                    :hohap_modetho,
                    :hohap_fio2,
                    :hohap_ngaydat,
                    :hohap_ngaymo,
                    :hohap_moccodinh,
                    :hohap_canuyl,
                    :hohap_tinhchatdomkhac,
                    :tuanhoan_mach,
                    :tuanhoan_ha,
                    :tuanhoan,
                    :tuanhoan_ngaydat,
                    :tuanhoan_vitri,
                    :tuanhoan_chan,
                    :tieuhoa,
                    :tieuhoa_non,
                    :tieuhoa_daubung_solan,
                    :thantn_nuoctieu_soluong,
                    :thantn_nuoctieu_mausac,
                    :thantn_nuoctieu_tinhchat,
                    :thantn_daimau,
                    :thantn,
                    :vandebatthuongkhac
                 )  RETURNING ID INTO :ID";
                if (data.Id != Decimal.Zero)
                {
                    sql = @"UPDATE HSCS_TTBenhNhanVaoVien SET 
                    
                    id_hscs_ttbenhnhan = : id_hscs_ttbenhnhan,
                    ttbn_tiensubenh = : ttbn_tiensubenh,
                    nhietdo = : nhietdo,
                    cannang = : cannang,
                    chieucao = : chieucao,
                    bmi = :bmi ,
                    da = : da,
                    da_text = : da_text,
                    niemmac = :niemmac ,
                    niemmac_khac = : niemmac_khac,
                    thankinh = :thankinh,
                    CoGiat = :CoGiat,
                    thankinh_lydokhac = :thankinh_lydokhac ,
                    HoHap_Dom_SoLuong =:HoHap_Dom_SoLuong,
                    HoHap_Dom_MauSac =:HoHap_Dom_MauSac,
                    HoHap_Dom_TCDom =:HoHap_Dom_TCDom,
                    hohap_nhiptho = :hohap_nhiptho ,
                    hohap_crln = :hohap_crln ,
                    hohap_spo2 = :hohap_spo2 ,
                    hohap = :hohap ,
                    hohap_oxykinh = :hohap_oxykinh ,
                    hohap_oxymask = :hohap_oxymask ,
                    hohap_modetho = :hohap_modetho ,
                    hohap_fio2 = :hohap_fio2 ,
                    hohap_ngaydat = :hohap_ngaydat ,
                    hohap_ngaymo = :hohap_ngaymo ,
                    hohap_moccodinh = :hohap_moccodinh ,
                    hohap_canuyl = :hohap_canuyl ,
                    hohap_tinhchatdomkhac = :hohap_tinhchatdomkhac ,
                    tuanhoan_mach = :tuanhoan_mach ,
                    tuanhoan_ha = :tuanhoan_ha ,
                    tuanhoan = : tuanhoan,
                    tuanhoan_ngaydat = :tuanhoan_ngaydat ,
                    tuanhoan_vitri = :tuanhoan_vitri ,
                    tuanhoan_chan = :tuanhoan_chan ,
                    tieuhoa = : tieuhoa,
                    tieuhoa_non = : tieuhoa_non,
                    tieuhoa_daubung_solan = : tieuhoa_daubung_solan,
                    thantn_nuoctieu_soluong = : thantn_nuoctieu_soluong,
                    thantn_nuoctieu_mausac = : thantn_nuoctieu_mausac,
                    thantn_nuoctieu_tinhchat = : thantn_nuoctieu_tinhchat,
                    thantn_daimau = :thantn_daimau,
                    thantn = : thantn,
                    vandebatthuongkhac = :vandebatthuongkhac  
                    WHERE ID = " + data.Id;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("id_hscs_ttbenhnhan", data.Id_hscs_ttbenhnhan));
                Command.Parameters.Add(new MDB.MDBParameter("ttbn_tiensubenh", data.TTBN_TienSuBenh));
                Command.Parameters.Add(new MDB.MDBParameter("nhietdo", data.NhietDo));
                Command.Parameters.Add(new MDB.MDBParameter("cannang", data.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("chieucao", data.ChieuCao));
                Command.Parameters.Add(new MDB.MDBParameter("bmi", data.BMI));
                Command.Parameters.Add(new MDB.MDBParameter("da", data.Da));
                Command.Parameters.Add(new MDB.MDBParameter("da_text", data.Da_Text));
                Command.Parameters.Add(new MDB.MDBParameter("niemmac", data.NiemMac));
                Command.Parameters.Add(new MDB.MDBParameter("niemmac_khac", data.NiemMac_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("thankinh", data.ThanKinh));
                Command.Parameters.Add(new MDB.MDBParameter("CoGiat", data.CoGiat));
                Command.Parameters.Add(new MDB.MDBParameter("thankinh_lydokhac", data.ThanKinh_LyDoKhac));
                Command.Parameters.Add(new MDB.MDBParameter("HoHap_Dom_SoLuong", data.HoHap_Dom_SoLuong));
                Command.Parameters.Add(new MDB.MDBParameter("HoHap_Dom_MauSac", data.HoHap_Dom_MauSac));
                Command.Parameters.Add(new MDB.MDBParameter("HoHap_Dom_TCDom", data.HoHap_Dom_TCDom));
                Command.Parameters.Add(new MDB.MDBParameter("hohap_nhiptho", data.HoHap_NhipTho));
                Command.Parameters.Add(new MDB.MDBParameter("hohap_crln", data.HoHap_CRLN));
                Command.Parameters.Add(new MDB.MDBParameter("hohap_spo2", data.HoHap_SPO2));
                Command.Parameters.Add(new MDB.MDBParameter("hohap", data.Hohap));
                Command.Parameters.Add(new MDB.MDBParameter("hohap_oxykinh", data.HoHap_OXYKINH));
                Command.Parameters.Add(new MDB.MDBParameter("hohap_oxymask", data.HoHap_OXYMASK));
                Command.Parameters.Add(new MDB.MDBParameter("hohap_modetho", data.HoHap_ModeTho));
                Command.Parameters.Add(new MDB.MDBParameter("hohap_fio2", data.HoHap_FiO2));
                Command.Parameters.Add(new MDB.MDBParameter("hohap_ngaydat", data.HoHap_NgayDat));
                Command.Parameters.Add(new MDB.MDBParameter("hohap_ngaymo", data.HoHap_NgayMo));
                Command.Parameters.Add(new MDB.MDBParameter("hohap_moccodinh", data.HoHap_MocCoDinh));
                Command.Parameters.Add(new MDB.MDBParameter("hohap_canuyl", data.HoHap_Canuyl));
                Command.Parameters.Add(new MDB.MDBParameter("hohap_tinhchatdomkhac", data.HoHap_TinhChatDomKhac));
                Command.Parameters.Add(new MDB.MDBParameter("tuanhoan_mach", data.TuanHoan_Mach));
                Command.Parameters.Add(new MDB.MDBParameter("tuanhoan_ha", data.TuanHoan_HA));
                Command.Parameters.Add(new MDB.MDBParameter("tuanhoan", data.Tuanhoan));
                Command.Parameters.Add(new MDB.MDBParameter("tuanhoan_ngaydat", data.TuanHoan_NgayDat));
                Command.Parameters.Add(new MDB.MDBParameter("tuanhoan_vitri", data.TuanHoan_ViTri));
                Command.Parameters.Add(new MDB.MDBParameter("tuanhoan_chan", data.TuanHoan_Chan));
                Command.Parameters.Add(new MDB.MDBParameter("tieuhoa", data.Tieuhoa));
                Command.Parameters.Add(new MDB.MDBParameter("tieuhoa_non", data.TieuHoa_Non));
                Command.Parameters.Add(new MDB.MDBParameter("tieuhoa_daubung_solan", data.TieuHoa_DauBung_SoLan));
                Command.Parameters.Add(new MDB.MDBParameter("thantn_nuoctieu_soluong", data.ThanTN_NuocTieu_SoLuong));
                Command.Parameters.Add(new MDB.MDBParameter("thantn_nuoctieu_mausac", data.ThanTN_NuocTieu_MauSac));
                Command.Parameters.Add(new MDB.MDBParameter("thantn_nuoctieu_tinhchat", data.ThanTN_NuocTieu_TinhChat));
                Command.Parameters.Add(new MDB.MDBParameter("thantn_daimau", data.ThanTN_DaiMau));
                Command.Parameters.Add(new MDB.MDBParameter("thantn", data.ThanTN));
                Command.Parameters.Add(new MDB.MDBParameter("vandebatthuongkhac", data.VanDeBatThuongKhac));
                if (data.Id.Equals(Decimal.Zero))
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", data.Id));
                }
                /*Command.Parameters.Add(new MDB.MDBParameter("nguoisua", data.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("ngaysua", data.NgaySua));
                if (data.Id.Equals(Decimal.Zero))
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", data.Id));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", data.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", data.NgayTao));
                }*/
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (data.Id.Equals(Decimal.Zero))
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    data.Id = nextval;
                }
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool deleteByTTBenhNhan(MDB.MDBConnection MyConnection, decimal id_hscs_ttbenhnhan)
        {
            try
            {
                int n = 0;
                string sql = "DELETE FROM HSCS_TTBenhNhanVaoVien WHERE id_hscs_ttbenhnhan = :id_hscs_ttbenhnhan";
                MDB.MDBCommand command;
                using (command = new MDB.MDBCommand(sql, MyConnection)) {
                    command.Parameters.Add(new MDB.MDBParameter("id_hscs_ttbenhnhan", id_hscs_ttbenhnhan));
                    command.BindByName = true;
                    n = command.ExecuteNonQuery();
                }   
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static DataSet getDataSet(MDB.MDBConnection MyConnection, decimal ID)
        {
            string sql = @"SELECT
                P.*
            FROM
                HSCS_TTBenhNhanVaoVien P
            WHERE
                ID = " + ID;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "PT");

            DataTable thongTinVien = new DataTable("HEADER");

            thongTinVien.Columns.Add("BENHVIEN");
            thongTinVien.Columns.Add("KHOA");
            thongTinVien.Columns.Add("MABENHAN");
			if (XemBenhAn._HanhChinhBenhNhan == null) XemBenhAn._HanhChinhBenhNhan = new HanhChinhBenhNhan();
            if (XemBenhAn._ThongTinDieuTri == null) XemBenhAn._ThongTinDieuTri = new ThongTinDieuTri();
            thongTinVien.Rows.Add(XemBenhAn._HanhChinhBenhNhan.BenhVien, XemBenhAn._ThongTinDieuTri.Khoa, XemBenhAn._ThongTinDieuTri.MaBenhAn);
            ds.Tables.Add(thongTinVien);

            return ds;
        }
        
        public static DateTime ConDB_DateTime(object dbVal)
        {
            DateTime ret = DateTime.MinValue;
            if (dbVal == null)
            {
                return ret;
            }
            bool isSuccess = DateTime.TryParse(dbVal.ToString(), out ret);
            return ret;
        }
    }
}
