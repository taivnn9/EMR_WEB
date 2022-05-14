using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors.Filtering.Templates;
using EMR.KyDienTu;
using EMR_MAIN.ChucNangKhac;
using MDB;
using Newtonsoft.Json;
using PMS.Access;
namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuBanGiaoBenhNhan : ThongTinKy
    {
        public PhieuBanGiaoBenhNhan()
        {
            TableName = "PhieuBanGiaoBenhNhan";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PBGBN;
            TenMauPhieu = DanhMucPhieu.PBGBN.Description();

        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Cân nặng")]
		public string CanNang { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh sau mổ")]
		public string ChanDoanSauMo { get; set; }
        public string CachThucMo { get; set; }
        public string PPGayMe { get; set; }
        public string PTV { get; set; }
        public string MaNVPTV { get; set; }
        public string BacSyGayMe { get; set; }
        public string MaNVBacSyGayMe { get; set; }
        public string MayTho_Mode { get; set; }
        public string MayTho_VTP { get; set; }
        public string MayTho_TanSo { get; set; }
        public string MayTho_PEEP { get; set; }
        public string MayTho_PIO2 { get; set; }
        public string MayTho_NKQ { get; set; }
        public string MayTho_Cuff { get; set; }
        public string MayTho_DuongDat { get; set; }
        public string MayTho_CoDinh { get; set; }
        public string TMNgoaiVi_Loai { get; set; }
        public int TMNgoaiVi { get; set; }
        public string DongMach_Loai { get; set; }
        public int DongMach { get; set; }
        public string KTTW_Loai { get; set; }
        public int KTTW { get; set; }
        public string[] ThuocDangDuyTri { get; set; } = new string[5];
        public string[] TocDo { get; set; } = new string[5];
        public string[] Lieu { get; set; } = new string[5];
        public string MayTaoNhip { get; set; }
        public string MayTaoNhip_Mode { get; set; }
        public string MayTaoNhip_TanSo { get; set; }
        public string MayTaoNhip_OutPut { get; set; }
        public string DHST_NhipTim { get; set; }
        public string DHST_HuyetAp { get; set; }
        public string DHST_ApLucTMTT { get; set; }
        public string DHST_SPO2 { get; set; }
        public string[] LuuY { get; set; } = new string[3];
        public string MauCEC { get; set; }
        public string MauTieuCau { get; set; }
        public string MauKhac { get; set; }
        public string BacSyNhanBN { get; set; }
        public string MaNVBacSyNhanBN { get; set; }
        public DateTime ThoiGianThucHien { get; set; }
        public string MaNVBacSyBanGiao { get; set; }
        public string BacSyBanGiao { get; set; }

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
    public class PhieuBanGiaoBenhNhanFunc
    {
        public const string TableName = "PhieuBanGiaoBenhNhan";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuBanGiaoBenhNhan> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuBanGiaoBenhNhan> list = new List<PhieuBanGiaoBenhNhan>();
            try
            {

                string sql = @"SELECT * FROM PhieuBanGiaoBenhNhan where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    try
                    {
                        PhieuBanGiaoBenhNhan data = new PhieuBanGiaoBenhNhan();
                        data.ID = DataReader.GetLong("id");
                        data.MaQuanLy = DataReader.GetDecimal("maquanly");
                        data.MaBenhNhan = DataReader.GetString("mabenhnhan");
                        data.TenBenhNhan = DataReader.GetString("tenbenhnhan");
                        data.Khoa = DataReader.GetString("khoa");
                        data.Tuoi = DataReader.GetString("tuoi");
                        data.CanNang = DataReader.GetString("cannang");
                        data.ChanDoanSauMo = DataReader.GetString("chandoansaumo");
                        data.CachThucMo = DataReader.GetString("cachthucmo");
                        data.PPGayMe = DataReader.GetString("ppgayme");
                        data.PTV = DataReader.GetString("ptv");
                        data.MaNVPTV = DataReader.GetString("manvptv");
                        data.BacSyGayMe = DataReader.GetString("bacsygayme");
                        data.MaNVBacSyGayMe = DataReader.GetString("manvbacsygayme");
                        data.MayTho_Mode = DataReader.GetString("maytho_mode");
                        data.MayTho_VTP = DataReader.GetString("maytho_vtp");
                        data.MayTho_TanSo = DataReader.GetString("maytho_tanso");
                        data.MayTho_PEEP = DataReader.GetString("maytho_peep");
                        data.MayTho_PIO2 = DataReader.GetString("maytho_pio2");
                        data.MayTho_NKQ = DataReader.GetString("maytho_nkq");
                        data.MayTho_Cuff = DataReader.GetString("maytho_cuff");
                        data.MayTho_DuongDat = DataReader.GetString("maytho_duongdat");
                        data.MayTho_CoDinh = DataReader.GetString("maytho_codinh");
                        data.TMNgoaiVi_Loai = DataReader.GetString("tmngoaivi_loai");
                        data.TMNgoaiVi = DataReader.GetInt("tmngoaivi");
                        data.DongMach_Loai = DataReader.GetString("dongmach_loai");
                        data.DongMach = DataReader.GetInt("dongmach");
                        data.KTTW_Loai = DataReader.GetString("kttw_loai");
                        data.KTTW = DataReader.GetInt("kttw");
                        data.ThuocDangDuyTri = JsonConvert.DeserializeObject<string[]>(DataReader.GetString("thuocdangduytri"));
                        data.TocDo = JsonConvert.DeserializeObject<string[]>(DataReader.GetString("tocdo"));
                        data.Lieu = JsonConvert.DeserializeObject<string[]>(DataReader.GetString("lieu"));
                        data.MayTaoNhip = DataReader.GetString("maytaonhip");
                        data.MayTaoNhip_Mode = DataReader.GetString("maytaonhip_mode");
                        data.MayTaoNhip_TanSo = DataReader.GetString("maytaonhip_tanso");
                        data.MayTaoNhip_OutPut = DataReader.GetString("maytaonhip_output");
                        data.DHST_NhipTim = DataReader.GetString("dhst_nhiptim");
                        data.DHST_HuyetAp = DataReader.GetString("dhst_huyetap");
                        data.DHST_ApLucTMTT = DataReader.GetString("dhst_apluctmtt");
                        data.DHST_SPO2 = DataReader.GetString("dhst_spo2");
                        data.LuuY = JsonConvert.DeserializeObject<string[]>(DataReader.GetString("luuy"));
                        data.MauCEC = DataReader.GetString("maucec");
                        data.MauTieuCau = DataReader.GetString("mautieucau");
                        data.MauKhac = DataReader.GetString("maukhac");
                        data.BacSyNhanBN = DataReader.GetString("bacsynhanbn");
                        data.MaNVBacSyNhanBN = DataReader.GetString("manvbacsynhanbn");
                        data.BacSyBanGiao = DataReader.GetString("manvbacsybangiao");
                        data.MaNVBacSyBanGiao = DataReader.GetString("bacsybangiao");
                        data.ThoiGianThucHien = ConDB_DateTime(DataReader["thoigianthuchien"]);
                        data.NguoiTao = DataReader.GetString("NguoiTao");
                        data.NguoiSua = DataReader.GetString("NguoiSua");
                        data.NgayTao = ConDB_DateTime(DataReader["NgayTao"]);
                        data.NgaySua = ConDB_DateTime(DataReader["NgaySua"]);
                        data.MaSoKy = DataReader.GetString("masokyten");
                        data.NgayKy = DataReader.GetDate("ngayky");
                        data.TenFileKy = DataReader.GetString("tenfileky");
                        data.UserNameKy = DataReader.GetString("usernameky");
                        data.ComputerKyTen = DataReader.GetString("COMPUTERKYTEN");

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuBanGiaoBenhNhan objData)
        {
            string sql;
            int n = 0;
            if (objData.ID == 0)
            {
                sql = @"INSERT INTO PhieuBanGiaoBenhNhan (
                                    maquanly,
                                    mabenhnhan,
                                    tenbenhnhan,
                                    khoa,
                                    tuoi,
                                    cannang,
                                    chandoansaumo,
                                    cachthucmo,
                                    ppgayme,
                                    ptv,
                                    manvptv,
                                    bacsygayme,
                                    manvbacsygayme,
                                    maytho_mode,
                                    maytho_vtp,
                                    maytho_tanso,
                                    maytho_peep,
                                    maytho_pio2,
                                    maytho_nkq,
                                    maytho_cuff,
                                    maytho_duongdat,
                                    maytho_codinh,
                                    tmngoaivi_loai,
                                    tmngoaivi,
                                    dongmach_loai,
                                    dongmach,
                                    kttw_loai,
                                    kttw,
                                    thuocdangduytri,
                                    tocdo,
                                    lieu,
                                    maytaonhip,
                                    maytaonhip_mode,
                                    maytaonhip_tanso,
                                    maytaonhip_output,
                                    dhst_nhiptim,
                                    dhst_huyetap,
                                    dhst_apluctmtt,
                                    dhst_spo2,
                                    luuy,
                                    maucec,
                                    mautieucau,
                                    maukhac,
                                    bacsynhanbn,
                                    manvbacsynhanbn,
                                    manvbacsybangiao,
                                    bacsybangiao,
                                    thoigianthuchien,
                                    nguoitao,
                                    ngaytao
                                ) VALUES (
                                    :maquanly,
                                    :mabenhnhan,
                                    :tenbenhnhan,
                                    :khoa,
                                    :tuoi,
                                    :cannang,
                                    :chandoansaumo,
                                    :cachthucmo,
                                    :ppgayme,
                                    :ptv,
                                    :manvptv,
                                    :bacsygayme,
                                    :manvbacsygayme,
                                    :maytho_mode,
                                    :maytho_vtp,
                                    :maytho_tanso,
                                    :maytho_peep,
                                    :maytho_pio2,
                                    :maytho_nkq,
                                    :maytho_cuff,
                                    :maytho_duongdat,
                                    :maytho_codinh,
                                    :tmngoaivi_loai,
                                    :tmngoaivi,
                                    :dongmach_loai,
                                    :dongmach,
                                    :kttw_loai,
                                    :kttw,
                                    :thuocdangduytri,
                                    :tocdo,
                                    :lieu,
                                    :maytaonhip,
                                    :maytaonhip_mode,
                                    :maytaonhip_tanso,
                                    :maytaonhip_output,
                                    :dhst_nhiptim,
                                    :dhst_huyetap,
                                    :dhst_apluctmtt,
                                    :dhst_spo2,
                                    :luuy,
                                    :maucec,
                                    :mautieucau,
                                    :maukhac,
                                    :bacsynhanbn,
                                    :manvbacsynhanbn,
                                    :manvbacsybangiao,
                                    :bacsybangiao,
                                    :thoigianthuchien,
                                    :nguoitao,
                                    :ngaytao 
                                ) RETURNING ID INTO :ID";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("maquanly", objData.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("mabenhnhan", objData.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("tenbenhnhan", objData.TenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("khoa", objData.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("tuoi", objData.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("cannang", objData.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("chandoansaumo", objData.ChanDoanSauMo));
                Command.Parameters.Add(new MDB.MDBParameter("cachthucmo", objData.CachThucMo));
                Command.Parameters.Add(new MDB.MDBParameter("ppgayme", objData.PPGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("ptv", objData.PTV));
                Command.Parameters.Add(new MDB.MDBParameter("manvptv", objData.MaNVPTV));
                Command.Parameters.Add(new MDB.MDBParameter("bacsygayme", objData.BacSyGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("manvbacsygayme", objData.MaNVBacSyGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("maytho_mode", objData.MayTho_Mode));
                Command.Parameters.Add(new MDB.MDBParameter("maytho_vtp", objData.MayTho_VTP));
                Command.Parameters.Add(new MDB.MDBParameter("maytho_tanso", objData.MayTho_TanSo));
                Command.Parameters.Add(new MDB.MDBParameter("maytho_peep", objData.MayTho_PEEP));
                Command.Parameters.Add(new MDB.MDBParameter("maytho_pio2", objData.MayTho_PIO2));
                Command.Parameters.Add(new MDB.MDBParameter("maytho_nkq", objData.MayTho_NKQ));
                Command.Parameters.Add(new MDB.MDBParameter("maytho_cuff", objData.MayTho_Cuff));
                Command.Parameters.Add(new MDB.MDBParameter("maytho_duongdat", objData.MayTho_DuongDat));
                Command.Parameters.Add(new MDB.MDBParameter("maytho_codinh", objData.MayTho_CoDinh));
                Command.Parameters.Add(new MDB.MDBParameter("tmngoaivi_loai", objData.TMNgoaiVi_Loai));
                Command.Parameters.Add(new MDB.MDBParameter("tmngoaivi", objData.TMNgoaiVi));
                Command.Parameters.Add(new MDB.MDBParameter("dongmach_loai", objData.DongMach_Loai));
                Command.Parameters.Add(new MDB.MDBParameter("dongmach", objData.DongMach));
                Command.Parameters.Add(new MDB.MDBParameter("kttw_loai", objData.KTTW_Loai));
                Command.Parameters.Add(new MDB.MDBParameter("kttw", objData.KTTW));
                Command.Parameters.Add(new MDB.MDBParameter("thuocdangduytri", JsonConvert.SerializeObject(objData.ThuocDangDuyTri)));
                Command.Parameters.Add(new MDB.MDBParameter("tocdo", JsonConvert.SerializeObject(objData.TocDo)));
                Command.Parameters.Add(new MDB.MDBParameter("lieu", JsonConvert.SerializeObject(objData.Lieu)));
                Command.Parameters.Add(new MDB.MDBParameter("maytaonhip", objData.MayTaoNhip));
                Command.Parameters.Add(new MDB.MDBParameter("maytaonhip_mode", objData.MayTaoNhip_Mode));
                Command.Parameters.Add(new MDB.MDBParameter("maytaonhip_tanso", objData.MayTaoNhip_TanSo));
                Command.Parameters.Add(new MDB.MDBParameter("maytaonhip_output", objData.MayTaoNhip_OutPut));
                Command.Parameters.Add(new MDB.MDBParameter("dhst_nhiptim", objData.DHST_NhipTim));
                Command.Parameters.Add(new MDB.MDBParameter("dhst_huyetap", objData.DHST_HuyetAp));
                Command.Parameters.Add(new MDB.MDBParameter("dhst_apluctmtt", objData.DHST_ApLucTMTT));
                Command.Parameters.Add(new MDB.MDBParameter("dhst_spo2", objData.DHST_SPO2));
                Command.Parameters.Add(new MDB.MDBParameter("luuy", JsonConvert.SerializeObject(objData.LuuY)));
                Command.Parameters.Add(new MDB.MDBParameter("maucec", objData.MauCEC));
                Command.Parameters.Add(new MDB.MDBParameter("mautieucau", objData.MauTieuCau));
                Command.Parameters.Add(new MDB.MDBParameter("maukhac", objData.MauKhac));
                Command.Parameters.Add(new MDB.MDBParameter("bacsynhanbn", objData.BacSyNhanBN));
                Command.Parameters.Add(new MDB.MDBParameter("manvbacsynhanbn", objData.MaNVBacSyNhanBN));
                Command.Parameters.Add(new MDB.MDBParameter("manvbacsybangiao", objData.MaNVBacSyBanGiao));
                Command.Parameters.Add(new MDB.MDBParameter("bacsybangiao", objData.BacSyBanGiao));
                Command.Parameters.Add(new MDB.MDBParameter("thoigianthuchien", objData.ThoiGianThucHien));
                Command.Parameters.Add(new MDB.MDBParameter("ID", objData.ID));
                Command.Parameters.Add(new MDB.MDBParameter("nguoitao", objData.NguoiTao));
                Command.Parameters.Add(new MDB.MDBParameter("ngaytao", objData.NgayTao));
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
            }

            else
            {
                sql = @"UPDATE PhieuBanGiaoBenhNhan SET  
                                        maquanly=:maquanly,
                                        mabenhnhan=:mabenhnhan,
                                        tenbenhnhan=:tenbenhnhan,
                                        khoa=:khoa,
                                        tuoi=:tuoi,
                                        cannang=:cannang,
                                        chandoansaumo=:chandoansaumo,
                                        cachthucmo=:cachthucmo,
                                        ppgayme=:ppgayme,
                                        ptv=:ptv,
                                        manvptv=:manvptv,
                                        bacsygayme=:bacsygayme,
                                        manvbacsygayme=:manvbacsygayme,
                                        maytho_mode=:maytho_mode,
                                        maytho_vtp=:maytho_vtp,
                                        maytho_tanso=:maytho_tanso,
                                        maytho_peep=:maytho_peep,
                                        maytho_pio2=:maytho_pio2,
                                        maytho_nkq=:maytho_nkq,
                                        maytho_cuff=:maytho_cuff,
                                        maytho_duongdat=:maytho_duongdat,
                                        maytho_codinh=:maytho_codinh,
                                        tmngoaivi_loai=:tmngoaivi_loai,
                                        tmngoaivi=:tmngoaivi,
                                        dongmach_loai=:dongmach_loai,
                                        dongmach=:dongmach,
                                        kttw_loai=:kttw_loai,
                                        kttw=:kttw,
                                        thuocdangduytri=:thuocdangduytri,
                                        tocdo=:tocdo,
                                        lieu=:lieu,
                                        maytaonhip=:maytaonhip,
                                        maytaonhip_mode=:maytaonhip_mode,
                                        maytaonhip_tanso=:maytaonhip_tanso,
                                        maytaonhip_output=:maytaonhip_output,
                                        dhst_nhiptim=:dhst_nhiptim,
                                        dhst_huyetap=:dhst_huyetap,
                                        dhst_apluctmtt=:dhst_apluctmtt,
                                        dhst_spo2=:dhst_spo2,
                                        luuy=:luuy,
                                        maucec=:maucec,
                                        mautieucau=:mautieucau,
                                        maukhac=:maukhac,
                                        bacsynhanbn=:bacsynhanbn,
                                        manvbacsynhanbn=:manvbacsynhanbn,
                                        manvbacsybangiao=:manvbacsybangiao,
                                        bacsybangiao=:bacsybangiao,
                                        thoigianthuchien=:thoigianthuchien,
                                        nguoisua = :nguoisua,
                                        ngaysua = :ngaysua 
                                        WHERE ID = :IDPhieu";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("maquanly", objData.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("mabenhnhan", objData.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("tenbenhnhan", objData.TenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("khoa", objData.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("tuoi", objData.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("cannang", objData.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("chandoansaumo", objData.ChanDoanSauMo));
                Command.Parameters.Add(new MDB.MDBParameter("cachthucmo", objData.CachThucMo));
                Command.Parameters.Add(new MDB.MDBParameter("ppgayme", objData.PPGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("ptv", objData.PTV));
                Command.Parameters.Add(new MDB.MDBParameter("manvptv", objData.MaNVPTV));
                Command.Parameters.Add(new MDB.MDBParameter("bacsygayme", objData.BacSyGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("manvbacsygayme", objData.MaNVBacSyGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("maytho_mode", objData.MayTho_Mode));
                Command.Parameters.Add(new MDB.MDBParameter("maytho_vtp", objData.MayTho_VTP));
                Command.Parameters.Add(new MDB.MDBParameter("maytho_tanso", objData.MayTho_TanSo));
                Command.Parameters.Add(new MDB.MDBParameter("maytho_peep", objData.MayTho_PEEP));
                Command.Parameters.Add(new MDB.MDBParameter("maytho_pio2", objData.MayTho_PIO2));
                Command.Parameters.Add(new MDB.MDBParameter("maytho_nkq", objData.MayTho_NKQ));
                Command.Parameters.Add(new MDB.MDBParameter("maytho_cuff", objData.MayTho_Cuff));
                Command.Parameters.Add(new MDB.MDBParameter("maytho_duongdat", objData.MayTho_DuongDat));
                Command.Parameters.Add(new MDB.MDBParameter("maytho_codinh", objData.MayTho_CoDinh));
                Command.Parameters.Add(new MDB.MDBParameter("tmngoaivi_loai", objData.TMNgoaiVi_Loai));
                Command.Parameters.Add(new MDB.MDBParameter("tmngoaivi", objData.TMNgoaiVi));
                Command.Parameters.Add(new MDB.MDBParameter("dongmach_loai", objData.DongMach_Loai));
                Command.Parameters.Add(new MDB.MDBParameter("dongmach", objData.DongMach));
                Command.Parameters.Add(new MDB.MDBParameter("kttw_loai", objData.KTTW_Loai));
                Command.Parameters.Add(new MDB.MDBParameter("kttw", objData.KTTW));
                Command.Parameters.Add(new MDB.MDBParameter("thuocdangduytri", JsonConvert.SerializeObject(objData.ThuocDangDuyTri)));
                Command.Parameters.Add(new MDB.MDBParameter("tocdo", JsonConvert.SerializeObject(objData.TocDo)));
                Command.Parameters.Add(new MDB.MDBParameter("lieu", JsonConvert.SerializeObject(objData.Lieu)));
                Command.Parameters.Add(new MDB.MDBParameter("maytaonhip", objData.MayTaoNhip));
                Command.Parameters.Add(new MDB.MDBParameter("maytaonhip_mode", objData.MayTaoNhip_Mode));
                Command.Parameters.Add(new MDB.MDBParameter("maytaonhip_tanso", objData.MayTaoNhip_TanSo));
                Command.Parameters.Add(new MDB.MDBParameter("maytaonhip_output", objData.MayTaoNhip_OutPut));
                Command.Parameters.Add(new MDB.MDBParameter("dhst_nhiptim", objData.DHST_NhipTim));
                Command.Parameters.Add(new MDB.MDBParameter("dhst_huyetap", objData.DHST_HuyetAp));
                Command.Parameters.Add(new MDB.MDBParameter("dhst_apluctmtt", objData.DHST_ApLucTMTT));
                Command.Parameters.Add(new MDB.MDBParameter("dhst_spo2", objData.DHST_SPO2));
                Command.Parameters.Add(new MDB.MDBParameter("luuy", JsonConvert.SerializeObject(objData.LuuY)));
                Command.Parameters.Add(new MDB.MDBParameter("maucec", objData.MauCEC));
                Command.Parameters.Add(new MDB.MDBParameter("mautieucau", objData.MauTieuCau));
                Command.Parameters.Add(new MDB.MDBParameter("maukhac", objData.MauKhac));
                Command.Parameters.Add(new MDB.MDBParameter("bacsynhanbn", objData.BacSyNhanBN));
                Command.Parameters.Add(new MDB.MDBParameter("manvbacsynhanbn", objData.MaNVBacSyNhanBN));
                Command.Parameters.Add(new MDB.MDBParameter("manvbacsybangiao", objData.MaNVBacSyBanGiao));
                Command.Parameters.Add(new MDB.MDBParameter("bacsybangiao", objData.BacSyBanGiao));
                Command.Parameters.Add(new MDB.MDBParameter("thoigianthuchien", objData.ThoiGianThucHien));
                Command.Parameters.Add(new MDB.MDBParameter("nguoisua", objData.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("ngaysua", objData.NgaySua));
                Command.Parameters.Add(new MDB.MDBParameter("IDPhieu", objData.ID));
                Command.BindByName = true;
                n = Command.ExecuteNonQuery();

            }


            return n > 0 ? true : false;
        }

        public static bool Delete(MDB.MDBConnection MyConnection, decimal idPhieu)
        {
            string sql = "DELETE FROM PhieuBanGiaoBenhNhan WHERE ID = :idPhieu";
            MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
            command.Parameters.Add(new MDB.MDBParameter("idPhieu", idPhieu));
            command.BindByName = true;
            int n = command.ExecuteNonQuery();
            return n > 0 ? true : false;
        }
        public static PhieuBanGiaoBenhNhan GetData(MDB.MDBConnection _OracleConnection, decimal id)
        {
            try
            {
                string sql = @"SELECT * FROM PhieuBanGiaoBenhNhan where ID = :ID";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID", id));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    try
                    {
                        PhieuBanGiaoBenhNhan data = new PhieuBanGiaoBenhNhan();
                        data.ID = DataReader.GetLong("id");
                        data.MaQuanLy = DataReader.GetDecimal("maquanly");
                        data.MaBenhNhan = DataReader.GetString("mabenhnhan");
                        data.TenBenhNhan = DataReader.GetString("tenbenhnhan");
                        data.Khoa = DataReader.GetString("khoa");
                        data.Tuoi = DataReader.GetString("tuoi");
                        data.CanNang = DataReader.GetString("cannang");
                        data.ChanDoanSauMo = DataReader.GetString("chandoansaumo");
                        data.CachThucMo = DataReader.GetString("cachthucmo");
                        data.PPGayMe = DataReader.GetString("ppgayme");
                        data.PTV = DataReader.GetString("ptv");
                        data.MaNVPTV = DataReader.GetString("manvptv");
                        data.BacSyGayMe = DataReader.GetString("bacsygayme");
                        data.MaNVBacSyGayMe = DataReader.GetString("manvbacsygayme");
                        data.MayTho_Mode = DataReader.GetString("maytho_mode");
                        data.MayTho_VTP = DataReader.GetString("maytho_vtp");
                        data.MayTho_TanSo = DataReader.GetString("maytho_tanso");
                        data.MayTho_PEEP = DataReader.GetString("maytho_peep");
                        data.MayTho_PIO2 = DataReader.GetString("maytho_pio2");
                        data.MayTho_NKQ = DataReader.GetString("maytho_nkq");
                        data.MayTho_Cuff = DataReader.GetString("maytho_cuff");
                        data.MayTho_DuongDat = DataReader.GetString("maytho_duongdat");
                        data.MayTho_CoDinh = DataReader.GetString("maytho_codinh");
                        data.TMNgoaiVi_Loai = DataReader.GetString("tmngoaivi_loai");
                        data.TMNgoaiVi = DataReader.GetInt("tmngoaivi");
                        data.DongMach_Loai = DataReader.GetString("dongmach_loai");
                        data.DongMach = DataReader.GetInt("dongmach");
                        data.KTTW_Loai = DataReader.GetString("kttw_loai");
                        data.KTTW = DataReader.GetInt("kttw");
                        data.ThuocDangDuyTri = JsonConvert.DeserializeObject<string[]>(DataReader.GetString("thuocdangduytri"));
                        data.TocDo = JsonConvert.DeserializeObject<string[]>(DataReader.GetString("tocdo"));
                        data.Lieu = JsonConvert.DeserializeObject<string[]>(DataReader.GetString("lieu"));
                        data.MayTaoNhip = DataReader.GetString("maytaonhip");
                        data.MayTaoNhip_Mode = DataReader.GetString("maytaonhip_mode");
                        data.MayTaoNhip_TanSo = DataReader.GetString("maytaonhip_tanso");
                        data.MayTaoNhip_OutPut = DataReader.GetString("maytaonhip_output");
                        data.DHST_NhipTim = DataReader.GetString("dhst_nhiptim");
                        data.DHST_HuyetAp = DataReader.GetString("dhst_huyetap");
                        data.DHST_ApLucTMTT = DataReader.GetString("dhst_apluctmtt");
                        data.DHST_SPO2 = DataReader.GetString("dhst_spo2");
                        data.LuuY = JsonConvert.DeserializeObject<string[]>(DataReader.GetString("luuy"));
                        data.MauCEC = DataReader.GetString("maucec");
                        data.MauTieuCau = DataReader.GetString("mautieucau");
                        data.MauKhac = DataReader.GetString("maukhac");
                        data.BacSyNhanBN = DataReader.GetString("bacsynhanbn");
                        data.MaNVBacSyNhanBN = DataReader.GetString("manvbacsynhanbn");
                        data.BacSyBanGiao = DataReader.GetString("manvbacsybangiao");
                        data.MaNVBacSyBanGiao = DataReader.GetString("bacsybangiao");
                        data.ThoiGianThucHien = ConDB_DateTime(DataReader["thoigianthuchien"]);
                        data.NguoiTao = DataReader.GetString("NguoiTao");
                        data.NguoiSua = DataReader.GetString("NguoiSua");
                        data.NgayTao = ConDB_DateTime(DataReader["NgayTao"]);
                        data.NgaySua = ConDB_DateTime(DataReader["NgaySua"]);
                        data.MaSoKy = DataReader.GetString("masokyten");
                        data.NgayKy = DataReader.GetDate("ngayky");
                        data.TenFileKy = DataReader.GetString("tenfileky");
                        data.UserNameKy = DataReader.GetString("usernameky");
                        data.ComputerKyTen = DataReader.GetString("COMPUTERKYTEN");

                        return data;
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
            return null;
        }
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, decimal idPhieu)
        {
            string sql2 = @"SELECT
                D.*,
	            T.MABENHNHAN,
	            T.KHOA,
	            T.GIUONG,
                T.BUONG,
	            T.NGAYVAOVIEN,
	            H.SOYTE,
	            H.BENHVIEN,
	            H.MABENHNHAN,
	            H.TENBENHNHAN,
	            H.TUOI,
	            H.GIOITINH
            FROM
                PhieuBanGiaoBenhNhan D
                LEFT JOIN THONGTINDIEUTRI T ON D.MAQUANLY = T.MAQUANLY
                LEFT JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
            WHERE
                ID = :ID";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql2, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("ID", idPhieu));

            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            adt.Fill(ds,"BK");

            sql2 = @"SELECT
                B.ThuocDangDuyTri, B.TocDo, B.Lieu, B.LuuY
            FROM
                PhieuBanGiaoBenhNhan B
                
            WHERE
                ID = :D";

            Command = new MDB.MDBCommand(sql2, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("ID", idPhieu));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            string[] arrayThuocDangDuyTri = new string[5];
            string[] arrayTocDo = new string[5];
            string[] arrayLieu = new string[5];
            string[] arrayLuuY = new string[3];

            while (DataReader.Read())
            {
                arrayThuocDangDuyTri = JsonConvert.DeserializeObject<string[]>(DataReader["ThuocDangDuyTri"].ToString());
                arrayTocDo = JsonConvert.DeserializeObject<string[]>(DataReader["TocDo"].ToString());
                arrayLieu = JsonConvert.DeserializeObject<string[]>(DataReader["Lieu"].ToString());
                arrayLuuY = JsonConvert.DeserializeObject<string[]>(DataReader["LuuY"].ToString());
                break;
            }
            DataTable BK2 = new DataTable("BK2");
            BK2.Columns.Add("ThuocDangDuyTri_1");
            BK2.Columns.Add("TocDo_1");
            BK2.Columns.Add("Lieu_1");
            BK2.Columns.Add("LuuY");
            BK2.Rows.Add(arrayThuocDangDuyTri[0], arrayTocDo[0], arrayLieu[0], string.Join("\r\n", arrayLuuY));
            DataTable BK3 = new DataTable("BK3");
            BK3.Columns.Add("ThuocDangDuyTri_2");
            BK3.Columns.Add("TocDo_2");
            BK3.Columns.Add("Lieu_2");
            BK3.Rows.Add(arrayThuocDangDuyTri[1], arrayTocDo[1], arrayLieu[1]);
            DataTable BK4 = new DataTable("BK4");
            BK4.Columns.Add("ThuocDangDuyTri_3");
            BK4.Columns.Add("TocDo_3");
            BK4.Columns.Add("Lieu_3");
            BK4.Rows.Add(arrayThuocDangDuyTri[2], arrayTocDo[2], arrayLieu[2]);
            DataTable BK5 = new DataTable("BK5");
            BK5.Columns.Add("ThuocDangDuyTri_4");
            BK5.Columns.Add("TocDo_4");
            BK5.Columns.Add("Lieu_4");
            BK5.Rows.Add(arrayThuocDangDuyTri[3], arrayTocDo[3], arrayLieu[3]);
            DataTable BK6 = new DataTable("BK6");
            BK6.Columns.Add("ThuocDangDuyTri_5");
            BK6.Columns.Add("TocDo_5");
            BK6.Columns.Add("Lieu_5");
            BK6.Rows.Add(arrayThuocDangDuyTri[4], arrayTocDo[4], arrayLieu[4]);

            ds.Tables.Add(BK2);
            ds.Tables.Add(BK3);
            ds.Tables.Add(BK4);
            ds.Tables.Add(BK5);
            ds.Tables.Add(BK6);
            return ds;
        }
    }
}
