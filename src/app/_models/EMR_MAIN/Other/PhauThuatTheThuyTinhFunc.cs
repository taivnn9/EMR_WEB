using EMR.KyDienTu;
using EMR_MAIN.Converter;
using EMR_MAIN.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace EMR_MAIN.DATABASE.Other
{
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ChuanDoanT3
    {
        [Description("Không")]
        none = 0,
        [Description("Đục T3 bệnh già")]
        DucT3Gia = 1,
        [Description("Đục T3 bệnh lý")]
        DucT3BenhLy = 2,
        [Description("Lệnh T3")]
        LenhT3 = 3,
        [Description("Đục T3 bẩm sinh")]
        DucT3BamSinh = 4,
        [Description("Không có T3")]
        KhongCoT3 = 5
    }
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ChiDinhPhauThuatT3
    {
        [Description("Không")]
        none = 0,
        [Description("MP")]
        MP = 1,
        [Description("MT")]
        MT = 2,
        [Description("Phaco")]
        Phaco = 3,
        [Description("Ngoài bao")]
        NgoaiBao = 4,
        [Description("Trong bao")]
        TrongBao = 5,
        [Description("Treo củng mạc")]
        TreoCungMac = 6
    }
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum PhuongPhapVoCamT3
    {
        [Description("Không")]
        none = 0,
        [Description("Mê")]
        Me = 1,
        [Description("Tê tại mắt")]
        TeTaiMat = 2
    }
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum CoDinhNhanCauT3
    {
       [Description("Không")]
       none = 0,
       [Description("Vành mi")]
       VanhMi = 1,
       [Description("Chỉ cơ trực")]
       ChiCoTruc = 2
    }
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum DoDucT3
    {
        [Description("Không")]
        none = 0,
        [Description("Đục nhân")]
        DucNhan = 1,
        [Description("Đục Vỏ")]
        DucVo = 2,
        [Description("Đục dưới bao")]
        DucDuoiBao = 3,
        [Description("Đục chín")]
        DucChin = 4,
        [Description("Đục quá chín")]
        DucQuaChin = 5,
        [Description("Đục căng phồng")]
        DucCangPhong = 6,
        [Description("Lệnh TTT")]
        LenhTTT = 7,
        [Description("DK trong T phòng")]
        DKTrongTPhong = 8
    }
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum DoCungCuaNhanT3
    {
        [Description("Không")]
        none = 0,
        [Description("Còn trong")]
        ConTrong = 1,
        [Description("Độ 1")]
        Do1 = 2,
        [Description("Độ 2")]
        Do2 = 3,
        [Description("Độ 3")]
        Do3 = 4,
        [Description("Độ 4")]
        Do4 = 5,
        [Description("Độ 5")]
        Do5 = 6
    }
    public class TinhTrangT3
    {
        public DoDucT3 DoDuc { get; set; }
        public DoCungCuaNhanT3 DoCungCuaNhan { get; set; }
    }
    public class MoKMRiaT3
    {
        //0, khong chon, 1 khong, 2 co
        public int MoKMRia { get; set; }
        public int KinhTuyen { get; set; }
    }
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum MoTpT3
    {
        [Description("Không")]
         none = 0,
        [Description("Giác mạc")]
        GiacMac = 1,
        [Description("Vùng rìa")]
        VungRia = 2,
        [Description("Củng mạc")]
        CungMac = 3,
   }
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum XoayNhanT3
    {
        [Description("Không")]
        none = 0,
        [Description("Dễ dàng")]
        dedang = 1,
        [Description("Khó khăn")]
        khokhan = 2
    }
    public class MoVaoTpT3
    {
        public MoTpT3 MoTP { get; set; }
        public int ViTriKinhTuyen { get; set; }
        public int KichThuoc { get; set; }
    }
    public class XeBaoTruocT3
    {
        public bool XeBaoTruoc { get; set; }
        public bool MoBaoHinhNhuTem { get; set; }
    }
    public class TachNhanT3
    {
        public bool TachNhan { get; set; }
        public XoayNhanT3 XoayNhan { get; set; }
    }
    public class DayNhanRaNgoaiT3
    {
        public bool DayNhanRaNgoai { get; set; }
        // 0 không chọn, 1 không, 2 có
        public int ChayNhay { get; set; }
    }
    public class TanNhanT3
    {
        public int NangLuong { get; set; }
        public int LucHut { get; set; }
        public int TocDoDongChay { get; set; }
    }
    public class HutChatT3
    {
        public bool IA { get; set; }
        public bool KimHaiNong { get; set; }
    }
    public class DatIOLT3
    {
        public bool Mem { get; set; }
        public bool Cung { get; set; }
        public bool DatBangPince { get; set; }
        public bool BangSung { get; set; }
        public bool DatTrongTuiBao { get; set; }
        public bool RachTheMi { get; set; }
        public bool CoDinhIOLCungMac { get; set; }
    }
    public class RachBaoSauT3
    {
        public int RachBaoSau { get; set; }
        public string ViTriRach { get; set; }
        public string KichThuoc { get; set; }
    }
    public class CatBaoSauT3
    {
        // 0 không chọn, 1 không, 2 có
        public int CatBaoSau { get; set; }
        public bool CatBangKeo { get; set; }
        public bool MayCatDK { get; set; }
    }
    public class CatMongMatNgoaiViT3
    {
        // 0 không chọn, 1 không, 2 có
        public int CatMongMatNgoaiVi { get; set; }
        public string ViTriCatMongMatNgoaiVi { get; set; }
    }
    public class PhucHoiVetMoT3
    {
        public bool BomPhu { get; set; }
        public bool KhauVat { get; set; }
        public bool MuiRoi { get; set; }
        public int  SoMui { get; set; }
        public string LoaiChi { get; set; }
    }
    public class TiemMatT3 { 
        public bool TiemMat { get; set; }
        public bool DuoiKMCNC { get; set; }
        public string LoaiThuoc { get; set; }
        public string TraMat { get; set; }
        public string Bang { get; set; }
    }
    public class TrinhTuPhauThuatT3
    {
        public TrinhTuPhauThuatT3()
        {
            TinhTrang = new TinhTrangT3();
            MoKMRia = new MoKMRiaT3();
            MoVaoTp = new MoVaoTpT3();
            XeBaoTruoc = new XeBaoTruocT3();
            TachNhan = new TachNhanT3();
            DayNhanRaNgoai = new DayNhanRaNgoaiT3();
            TanNhan = new TanNhanT3();
            HutChatT3IA = new HutChatT3();
            DatIOL = new DatIOLT3();
            RachBaoSau = new RachBaoSauT3();
            CatBaoSau = new CatBaoSauT3();
            CatMongMatNgoaiVi = new CatMongMatNgoaiViT3();
            PhucHoiVetMo = new PhucHoiVetMoT3();
            TiemMat = new TiemMatT3();
        }
        public CoDinhNhanCauT3 CoDinhNhanCau { get; set; }
        public TinhTrangT3 TinhTrang { get; set; }
        public MoKMRiaT3 MoKMRia { get; set; }
        public MoVaoTpT3 MoVaoTp { get; set; }
        //0 không chọn, 1 không, 2 có  
        public int NhuomBao { get; set; }
        public XeBaoTruocT3 XeBaoTruoc { get; set; }
        public TachNhanT3 TachNhan { get; set; }
        public DayNhanRaNgoaiT3 DayNhanRaNgoai { get; set; }
        public TanNhanT3 TanNhan { get; set; }
        public HutChatT3 HutChatT3IA { get; set; }
        public DatIOLT3 DatIOL { get; set; }
        public RachBaoSauT3 RachBaoSau { get; set; }
        public CatBaoSauT3 CatBaoSau { get; set; }
        public CatMongMatNgoaiViT3 CatMongMatNgoaiVi { get; set; }
        public PhucHoiVetMoT3 PhucHoiVetMo { get; set; }
        public TiemMatT3 TiemMat { get; set; }
        public string DienBienKhac { get; set; }
    }
    public class PhauThuatTheThuyTinh : ThongTinKy
    {
        [MoTaDuLieu("Mã định danh")]
		public int IDPhauThuatTheThuyTinh { get; set; }
        public string HoVaTenBenhNhan { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Ngày vào bệnh viện")]
		public DateTime NgayVaoVien { get; set; }
        public DateTime NgayPhauThuat { get; set; }
        public DateTime? NgayPhauThuat_Gio { get; set; }
        public ChuanDoanT3 ChuanDoan { get; set; }
        public ChiDinhPhauThuatT3 ChiDinhPhauThuat { get; set; }
        public string PhauThuatVienChinh { get; set; }
        public string MaPhauThuatVienChinh { get; set; }
        public string PhauThuatVienPhu { get; set; }
        public string MaPhauThuatVienPhu { get; set; }
        public string BacSyGayMe { get; set; }
        public string MaBacSyGayMe { get; set; }
        public PhuongPhapVoCamT3 PhuongPhapVoCam { get; set; }
        public string LoaiThuocTe { get; set; }
        public int DungTichThuocTe { get; set; }
        public string LuocDoPhauThuat { get; set; }
        public string pathLocalAnh { get; set; }
        public TrinhTuPhauThuatT3 TrinhTuPhauThuat { get; set; }
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
    public class PhauThuatTheThuyTinhFunc
    {
        public static List<PhauThuatTheThuyTinh> getData(decimal maQuanLy, MDB.MDBConnection _OracleConnection)
        {

            List<PhauThuatTheThuyTinh> lstData = new List<PhauThuatTheThuyTinh>();
            try
            {
                string sql = @"SELECT * FROM PHAUTHUATTHETHUYTINH where MAQUANLY = :MAQUANLY and XOA = 0";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", maQuanLy));
                Command.BindByName = true;
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhauThuatTheThuyTinh data = new PhauThuatTheThuyTinh();
                    data.IDPhauThuatTheThuyTinh = Convert.ToInt32(DataReader.GetLong("IDPhauThuatTheThuyTinh").ToString());
                    data.HoVaTenBenhNhan = DataReader["HoVaTenBenhNhan"].ToString();
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.MaQuanLy = maQuanLy;
                    data.Tuoi = DataReader["Tuoi"].ToString();
                    data.GioiTinh = DataReader["GioiTinh"].ToString();
                    data.NgayVaoVien = Convert.ToDateTime(DataReader["NgayVaoVien"] == DBNull.Value ? DateTime.Now : DataReader["NgayVaoVien"]);
                    data.NgayPhauThuat = Convert.ToDateTime(DataReader["NgayPhauThuat"] == DBNull.Value ? DateTime.Now : DataReader["NgayPhauThuat"]);
                    int temp = 0;
                    if (DataReader["ChuanDoan"] != null && int.TryParse(DataReader["ChuanDoan"].ToString(), out temp))
                    {
                        data.ChuanDoan = (ChuanDoanT3) temp;
                    }
                    temp = 0;
                    if (DataReader["ChiDinhPhauThuat"] != null && int.TryParse(DataReader["ChiDinhPhauThuat"].ToString(), out temp))
                    {
                        data.ChiDinhPhauThuat = (ChiDinhPhauThuatT3) temp;
                    }
                    data.PhauThuatVienChinh = DataReader["PhauThuatVienChinh"].ToString();
                    data.MaPhauThuatVienChinh = DataReader["MaPhauThuatVienChinh"].ToString();
                    data.PhauThuatVienPhu = DataReader["PhauThuatVienPhu"].ToString();
                    data.MaPhauThuatVienPhu = DataReader["MaPhauThuatVienPhu"].ToString();
                    data.BacSyGayMe = DataReader["BacSyGayMe"].ToString();
                    data.MaBacSyGayMe = DataReader["MaBacSyGayMe"].ToString();
                    temp = 0;
                    if (DataReader["PhuongPhapVoCam"] != null && int.TryParse(DataReader["PhuongPhapVoCam"].ToString(), out temp))
                    {
                        data.PhuongPhapVoCam = (PhuongPhapVoCamT3)temp;
                    }
                    data.LoaiThuocTe = DataReader["LoaiThuocTe"].ToString();
                    temp = 0;
                    if (DataReader["DungTichThuocTe"] != null && int.TryParse(DataReader["DungTichThuocTe"].ToString(), out temp))
                    {
                        data.DungTichThuocTe = temp;
                    }
                    data.LuocDoPhauThuat = DataReader["LuocDoPhauThuat"].ToString();
                    data.pathLocalAnh = DataReader["pathLocalAnh"].ToString();
                    data.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                    data.NguoiTao = DataReader["NguoiTao"].ToString();
                    data.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);
                    data.NguoiSua = DataReader["NguoiSua"].ToString();
                    // add Trinh Tu Phau Thuat
                    TrinhTuPhauThuatT3 trinhTuPhauThuat = new TrinhTuPhauThuatT3();
                    temp = 0;
                    if (DataReader["CoDinhNhanCau"] != null && int.TryParse(DataReader["CoDinhNhanCau"].ToString(), out temp))
                    {
                        trinhTuPhauThuat.CoDinhNhanCau = (CoDinhNhanCauT3) temp;
                    }
                    
                    trinhTuPhauThuat.TinhTrang = JsonConvert.DeserializeObject<TinhTrangT3>(DataReader["TinhTrang"].ToString());
                    trinhTuPhauThuat.MoKMRia = JsonConvert.DeserializeObject<MoKMRiaT3>(DataReader["MoKMRia"].ToString());
                    trinhTuPhauThuat.MoVaoTp = JsonConvert.DeserializeObject<MoVaoTpT3>(DataReader["MoVaoTp"].ToString());
                    temp = 0;
                    int.TryParse(DataReader["NhuomBao"].ToString(), out temp);
                    trinhTuPhauThuat.NhuomBao = temp;
                    trinhTuPhauThuat.XeBaoTruoc = JsonConvert.DeserializeObject<XeBaoTruocT3>(DataReader["XeBaoTruoc"].ToString());
                    trinhTuPhauThuat.TachNhan = JsonConvert.DeserializeObject<TachNhanT3>(DataReader["TachNhan"].ToString());
                    trinhTuPhauThuat.DayNhanRaNgoai = JsonConvert.DeserializeObject<DayNhanRaNgoaiT3>(DataReader["DayNhanRaNgoai"].ToString());
                    trinhTuPhauThuat.TanNhan = JsonConvert.DeserializeObject<TanNhanT3>(DataReader["TanNhan"].ToString());
                    trinhTuPhauThuat.HutChatT3IA = JsonConvert.DeserializeObject<HutChatT3>(DataReader["HutChatT3IA"].ToString());
                    trinhTuPhauThuat.DatIOL = JsonConvert.DeserializeObject<DatIOLT3>(DataReader["DatIOL"].ToString());
                    trinhTuPhauThuat.RachBaoSau = JsonConvert.DeserializeObject<RachBaoSauT3>(DataReader["RachBaoSau"].ToString());
                    trinhTuPhauThuat.CatBaoSau = JsonConvert.DeserializeObject<CatBaoSauT3>(DataReader["CatBaoSau"].ToString());
                    trinhTuPhauThuat.CatMongMatNgoaiVi = JsonConvert.DeserializeObject<CatMongMatNgoaiViT3>(DataReader["CatMongMatNgoaiVi"].ToString());
                    trinhTuPhauThuat.PhucHoiVetMo = JsonConvert.DeserializeObject<PhucHoiVetMoT3>(DataReader["PhucHoiVetMo"].ToString());
                    trinhTuPhauThuat.TiemMat = JsonConvert.DeserializeObject<TiemMatT3>(DataReader["TiemMat"].ToString());
                    trinhTuPhauThuat.DienBienKhac = DataReader["DienBienKhac"].ToString();
                    data.TrinhTuPhauThuat = trinhTuPhauThuat;
                    lstData.Add(data);
                }
            }
            catch (Exception ex) 
            { 
                XuLyLoi.Handle(ex); 
            }
            return lstData;
        }
        public static bool insertOrUpdate(MDB.MDBConnection MyConnection, ref PhauThuatTheThuyTinh phauThuatTheThuyTinh)
        {
            string sql = @"INSERT INTO PHAUTHUATTHETHUYTINH
                (
                    HOVATENBENHNHAN,
                    MABENHNHAN,
                    MAQUANLY,
                    TUOI,
                    GIOITINH,
                    NGAYVAOVIEN,
                    NGAYPHAUTHUAT,
                    CHUANDOAN,
                    CHIDINHPHAUTHUAT,
                    PHAUTHUATVIENCHINH,
                    MAPHAUTHUATVIENCHINH,
                    PHAUTHUATVIENPHU,
                    MAPHAUTHUATVIENPHU,
                    BACSYGAYME,
                    MABACSYGAYME,
                    PHUONGPHAPVOCAM,
                    LOAITHUOCTE,
                    DUNGTICHTHUOCTE,
                    LUOCDOPHAUTHUAT,pathLocalAnh,
                    CODINHNHANCAU,
                    TINHTRANG,
                    MOKMRIA,
                    MOVAOTP,
                    NHUOMBAO,
                    XEBAOTRUOC,
                    TACHNHAN,
                    DAYNHANRANGOAI,
                    TANNHAN,
                    HUTCHATT3IA,
                    DATIOL,
                    RACHBAOSAU,
                    CATBAOSAU,
                    CATMONGMATNGOAIVI,
                    PHUCHOIVETMO,
                    TIEMMAT,
                    DIENBIENKHAC,
                    XOA,
                    NGUOITAO,
                    NGAYTAO,
                    NGUOISUA,
                    NGAYSUA)  VALUES
                 (
                    :HOVATENBENHNHAN,
                    :MABENHNHAN,
                    :MAQUANLY,
                    :TUOI,
                    :GIOITINH,
                    :NGAYVAOVIEN,
                    :NGAYPHAUTHUAT,
                    :CHUANDOAN,
                    :CHIDINHPHAUTHUAT,
                    :PHAUTHUATVIENCHINH,
                    :MAPHAUTHUATVIENCHINH,
                    :PHAUTHUATVIENPHU,
                    :MAPHAUTHUATVIENPHU,
                    :BACSYGAYME,
                    :MABACSYGAYME,
                    :PHUONGPHAPVOCAM,
                    :LOAITHUOCTE,
                    :DUNGTICHTHUOCTE,
                    :LUOCDOPHAUTHUAT,:pathLocalAnh,
                    :CODINHNHANCAU,
                    :TINHTRANG,
                    :MOKMRIA,
                    :MOVAOTP,
                    :NHUOMBAO,
                    :XEBAOTRUOC,
                    :TACHNHAN,
                    :DAYNHANRANGOAI,
                    :TANNHAN,
                    :HUTCHATT3IA,
                    :DATIOL,
                    :RACHBAOSAU,
                    :CATBAOSAU,
                    :CATMONGMATNGOAIVI,
                    :PHUCHOIVETMO,
                    :TIEMMAT,
                    :DIENBIENKHAC,
                    0,
                    :NGUOITAO,
                    :NGAYTAO,
                    :NGUOISUA,
                    :NGAYSUA
                )  RETURNING IDPHAUTHUATTHETHUYTINH INTO :IDPHAUTHUATTHETHUYTINH";
            if (phauThuatTheThuyTinh.IDPhauThuatTheThuyTinh != 0)
            {
                sql = @"UPDATE PHAUTHUATTHETHUYTINH SET 
                    HOVATENBENHNHAN = :HOVATENBENHNHAN, 
                    MABENHNHAN = :MABENHNHAN,
                    MAQUANLY = :MAQUANLY,
                    TUOI = :TUOI,
                    GIOITINH = :GIOITINH,
                    NGAYVAOVIEN = :NGAYVAOVIEN,
                    NGAYPHAUTHUAT = :NGAYPHAUTHUAT,
                    CHUANDOAN = :CHUANDOAN,
                    CHIDINHPHAUTHUAT = :CHIDINHPHAUTHUAT,
                    PHAUTHUATVIENCHINH = :PHAUTHUATVIENCHINH,
                    MAPHAUTHUATVIENCHINH = :MAPHAUTHUATVIENCHINH,
                    PHAUTHUATVIENPHU = :PHAUTHUATVIENPHU,
                    MAPHAUTHUATVIENPHU = :MAPHAUTHUATVIENPHU,
                    BACSYGAYME = :BACSYGAYME,
                    MABACSYGAYME = :MABACSYGAYME,
                    PHUONGPHAPVOCAM = :PHUONGPHAPVOCAM,
                    LOAITHUOCTE = :LOAITHUOCTE,
                    DUNGTICHTHUOCTE = :DUNGTICHTHUOCTE,
                    LUOCDOPHAUTHUAT = :LUOCDOPHAUTHUAT,pathLocalAnh =:pathLocalAnh,
                    CODINHNHANCAU = :CODINHNHANCAU,
                    TINHTRANG = :TINHTRANG,
                    MOKMRIA = :MOKMRIA,
                    MOVAOTP = :MOVAOTP,
                    NHUOMBAO = :NHUOMBAO,
                    XEBAOTRUOC = :XEBAOTRUOC,
                    TACHNHAN = :TACHNHAN,
                    DAYNHANRANGOAI = :DAYNHANRANGOAI,
                    TANNHAN = :TANNHAN,
                    HUTCHATT3IA = :HUTCHATT3IA,
                    DATIOL = :DATIOL,
                    RACHBAOSAU = :RACHBAOSAU,
                    CATBAOSAU = :CATBAOSAU,
                    CATMONGMATNGOAIVI = :CATMONGMATNGOAIVI,
                    PHUCHOIVETMO = :PHUCHOIVETMO,
                    TIEMMAT = :TIEMMAT,
                    DIENBIENKHAC = :DIENBIENKHAC,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE IDPHAUTHUATTHETHUYTINH = " + phauThuatTheThuyTinh.IDPhauThuatTheThuyTinh;
            }
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("HOVATENBENHNHAN", phauThuatTheThuyTinh.HoVaTenBenhNhan));
            Command.Parameters.Add(new MDB.MDBParameter("MABENHNHAN", phauThuatTheThuyTinh.MaBenhNhan));
            Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", phauThuatTheThuyTinh.MaQuanLy));
            Command.Parameters.Add(new MDB.MDBParameter("TUOI", phauThuatTheThuyTinh.Tuoi));
            Command.Parameters.Add(new MDB.MDBParameter("GIOITINH", phauThuatTheThuyTinh.GioiTinh));
            Command.Parameters.Add(new MDB.MDBParameter("NGAYVAOVIEN", phauThuatTheThuyTinh.NgayVaoVien));
            var Ngay = phauThuatTheThuyTinh.NgayPhauThuat.Date.Add(new TimeSpan(0, 0, 0));
            var Gio = phauThuatTheThuyTinh.NgayPhauThuat_Gio != null ? phauThuatTheThuyTinh.NgayPhauThuat_Gio.Value.TimeOfDay : DateTime.Now.TimeOfDay;
            var ngayPhauThuat= Ngay + Gio;
            Command.Parameters.Add(new MDB.MDBParameter("NGAYPHAUTHUAT", ngayPhauThuat));
            Command.Parameters.Add(new MDB.MDBParameter("CHUANDOAN", (int) phauThuatTheThuyTinh.ChuanDoan));
            Command.Parameters.Add(new MDB.MDBParameter("CHIDINHPHAUTHUAT", (int)phauThuatTheThuyTinh.ChiDinhPhauThuat));
            Command.Parameters.Add(new MDB.MDBParameter("PHAUTHUATVIENCHINH", phauThuatTheThuyTinh.PhauThuatVienChinh));
            Command.Parameters.Add(new MDB.MDBParameter("MAPHAUTHUATVIENCHINH", phauThuatTheThuyTinh.MaPhauThuatVienChinh));
            Command.Parameters.Add(new MDB.MDBParameter("PHAUTHUATVIENPHU", phauThuatTheThuyTinh.PhauThuatVienPhu));
            Command.Parameters.Add(new MDB.MDBParameter("MAPHAUTHUATVIENPHU", phauThuatTheThuyTinh.MaPhauThuatVienPhu));
            Command.Parameters.Add(new MDB.MDBParameter("BACSYGAYME", phauThuatTheThuyTinh.BacSyGayMe));
            Command.Parameters.Add(new MDB.MDBParameter("MABACSYGAYME", phauThuatTheThuyTinh.MaBacSyGayMe));
            Command.Parameters.Add(new MDB.MDBParameter("PHUONGPHAPVOCAM", (int) phauThuatTheThuyTinh.PhuongPhapVoCam));
            Command.Parameters.Add(new MDB.MDBParameter("LOAITHUOCTE", phauThuatTheThuyTinh.LoaiThuocTe));
            Command.Parameters.Add(new MDB.MDBParameter("DUNGTICHTHUOCTE", phauThuatTheThuyTinh.DungTichThuocTe));
            Command.Parameters.Add(new MDB.MDBParameter("LUOCDOPHAUTHUAT", phauThuatTheThuyTinh.LuocDoPhauThuat));
            Command.Parameters.Add(new MDB.MDBParameter("pathLocalAnh", phauThuatTheThuyTinh.pathLocalAnh));
            // Trinh Tu Phau Thuat
            TrinhTuPhauThuatT3 trinhTuPhauThuat = phauThuatTheThuyTinh.TrinhTuPhauThuat;
            Command.Parameters.Add(new MDB.MDBParameter("CODINHNHANCAU", (int) trinhTuPhauThuat.CoDinhNhanCau));
            Command.Parameters.Add(new MDB.MDBParameter("TINHTRANG", JsonConvert.SerializeObject(trinhTuPhauThuat.TinhTrang)));
            Command.Parameters.Add(new MDB.MDBParameter("MOKMRIA", JsonConvert.SerializeObject(trinhTuPhauThuat.MoKMRia)));
            Command.Parameters.Add(new MDB.MDBParameter("MOVAOTP", JsonConvert.SerializeObject(trinhTuPhauThuat.MoVaoTp)));
            Command.Parameters.Add(new MDB.MDBParameter("NHUOMBAO", trinhTuPhauThuat.NhuomBao));
            Command.Parameters.Add(new MDB.MDBParameter("XEBAOTRUOC", JsonConvert.SerializeObject(trinhTuPhauThuat.XeBaoTruoc)));
            Command.Parameters.Add(new MDB.MDBParameter("TACHNHAN", JsonConvert.SerializeObject(trinhTuPhauThuat.TachNhan)));
            Command.Parameters.Add(new MDB.MDBParameter("DAYNHANRANGOAI", JsonConvert.SerializeObject(trinhTuPhauThuat.DayNhanRaNgoai)));
            Command.Parameters.Add(new MDB.MDBParameter("TANNHAN", JsonConvert.SerializeObject(trinhTuPhauThuat.TanNhan)));
            Command.Parameters.Add(new MDB.MDBParameter("HUTCHATT3IA", JsonConvert.SerializeObject(trinhTuPhauThuat.HutChatT3IA)));
            Command.Parameters.Add(new MDB.MDBParameter("DATIOL", JsonConvert.SerializeObject(trinhTuPhauThuat.DatIOL)));
            Command.Parameters.Add(new MDB.MDBParameter("RACHBAOSAU", JsonConvert.SerializeObject(trinhTuPhauThuat.RachBaoSau)));
            Command.Parameters.Add(new MDB.MDBParameter("CATBAOSAU", JsonConvert.SerializeObject(trinhTuPhauThuat.CatBaoSau)));
            Command.Parameters.Add(new MDB.MDBParameter("CATMONGMATNGOAIVI", JsonConvert.SerializeObject(trinhTuPhauThuat.CatMongMatNgoaiVi)));
            Command.Parameters.Add(new MDB.MDBParameter("PHUCHOIVETMO", JsonConvert.SerializeObject(trinhTuPhauThuat.PhucHoiVetMo)));
            Command.Parameters.Add(new MDB.MDBParameter("TIEMMAT", JsonConvert.SerializeObject(trinhTuPhauThuat.TiemMat)));
            Command.Parameters.Add(new MDB.MDBParameter("DIENBIENKHAC", trinhTuPhauThuat.DienBienKhac));
            Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", phauThuatTheThuyTinh.NguoiSua));
            Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", phauThuatTheThuyTinh.NgaySua));
            if (phauThuatTheThuyTinh.IDPhauThuatTheThuyTinh == 0)
            {
                Command.Parameters.Add(new MDB.MDBParameter("IDPHAUTHUATTHETHUYTINH", phauThuatTheThuyTinh.IDPhauThuatTheThuyTinh));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", phauThuatTheThuyTinh.NguoiTao));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", phauThuatTheThuyTinh.NgayTao));
            }
            Command.BindByName = true;
            int n = Command.ExecuteNonQuery(); // C#
            if (phauThuatTheThuyTinh.IDPhauThuatTheThuyTinh == 0)
            {
                int nextval = Convert.ToInt32((Command.Parameters["IDPHAUTHUATTHETHUYTINH"] as MDB.MDBParameter).Value);
                phauThuatTheThuyTinh.IDPhauThuatTheThuyTinh = nextval;
            }

            return n > 0 ? true : false;
        }
        public static bool delete(MDB.MDBConnection MyConnection, int idPhauThuatTheThuyTinh)
        {
            string sql = @"UPDATE PHAUTHUATTHETHUYTINH SET 
                    XOA = 1
                    WHERE IDPHAUTHUATTHETHUYTINH = " + idPhauThuatTheThuyTinh;
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            int n = Command.ExecuteNonQuery(); // C#
            return n > 0 ? true : false;
        }
        public static DataSet getDataSet(MDB.MDBConnection MyConnection, int idPhauThuatTheThuyTinh)
        {
            string sql = @"SELECT HOVATENBENHNHAN, 
                                 TUOI,
                                 GIOITINH,
                                 NGAYVAOVIEN,
                                 NGAYPHAUTHUAT,
                                 CHUANDOAN,
                                 CHIDINHPHAUTHUAT,
                                 PHAUTHUATVIENCHINH,
                                 PHAUTHUATVIENPHU,
                                 BACSYGAYME,
                                 PHUONGPHAPVOCAM,
                                 LOAITHUOCTE,
                                 DUNGTICHTHUOCTE,
                                 LUOCDOPHAUTHUAT,pathLocalAnh
                                 FROM PHAUTHUATTHETHUYTINH where IDPHAUTHUATTHETHUYTINH = :IDPHAUTHUATTHETHUYTINH and XOA = 0";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("IDPHAUTHUATTHETHUYTINH", idPhauThuatTheThuyTinh));
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            adt.Fill(ds,"PHAUTHUAT");

            string sql2 = @"SELECT CODINHNHANCAU, 
                                 TINHTRANG,
                                 MOKMRIA,
                                 MOVAOTP,
                                 NHUOMBAO,
                                 XEBAOTRUOC,
                                 TACHNHAN,
                                 DAYNHANRANGOAI,
                                 TANNHAN,
                                 HUTCHATT3IA,
                                 DATIOL,
                                 RACHBAOSAU,
                                 CATBAOSAU,
                                 CATMONGMATNGOAIVI,
                                 PHUCHOIVETMO,
                                 TIEMMAT,
                                 DIENBIENKHAC
                                 FROM PHAUTHUATTHETHUYTINH where IDPHAUTHUATTHETHUYTINH = :IDPHAUTHUATTHETHUYTINH and XOA = 0";
            Command = new MDB.MDBCommand(sql2, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("IDPHAUTHUATTHETHUYTINH", idPhauThuatTheThuyTinh));
            Command.BindByName = true;
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            DataTable tableTrinhTu = new DataTable("TRINHTUPT");
            tableTrinhTu.Columns.Add("CODINHNHANCAU");
            tableTrinhTu.Columns.Add("TINHTRANG");// độ đục của nhãn
            tableTrinhTu.Columns.Add("DOCUNGCUANHAN");
            tableTrinhTu.Columns.Add("MOKMRIA");
            tableTrinhTu.Columns.Add("KINHTUYENKMRIA");
            tableTrinhTu.Columns.Add("MOVAOTP");
            tableTrinhTu.Columns.Add("KINHTUYENTP");
            tableTrinhTu.Columns.Add("KICHTHUOCTP");
            tableTrinhTu.Columns.Add("NHUOMBAO");
            tableTrinhTu.Columns.Add("XEBAOTRUOC");
            tableTrinhTu.Columns.Add("MOBAOHINHTEMTHU");
            tableTrinhTu.Columns.Add("TACHNHAN");
            tableTrinhTu.Columns.Add("XOAYNHAN");
            tableTrinhTu.Columns.Add("DAYNHANRANGOAI");
            tableTrinhTu.Columns.Add("CHATNHAY");
            tableTrinhTu.Columns.Add("NANGLUONG");
            tableTrinhTu.Columns.Add("LUCHUT");
            tableTrinhTu.Columns.Add("TOCDODONGCHAY");
            tableTrinhTu.Columns.Add("IA");
            tableTrinhTu.Columns.Add("KIMHAINONG");
            tableTrinhTu.Columns.Add("MEM");
            tableTrinhTu.Columns.Add("CUNG");
            tableTrinhTu.Columns.Add("PINCE");
            tableTrinhTu.Columns.Add("BANGSUNG");
            tableTrinhTu.Columns.Add("DATTRONGTUIBAO");
            tableTrinhTu.Columns.Add("RANHTHEMI");
            tableTrinhTu.Columns.Add("CODINHIOLCUNGMAC");
            tableTrinhTu.Columns.Add("RACHBAOSAU");
            tableTrinhTu.Columns.Add("VITRIRACH");
            tableTrinhTu.Columns.Add("KICHTHUOCRACH");
            tableTrinhTu.Columns.Add("CATBAOSAU");
            tableTrinhTu.Columns.Add("CATBANGKEO");
            tableTrinhTu.Columns.Add("MAYCATDK");
            tableTrinhTu.Columns.Add("CATMONGMATNGOAIVI");
            tableTrinhTu.Columns.Add("VITRINGOAIVI");
            tableTrinhTu.Columns.Add("BOMPHU");
            tableTrinhTu.Columns.Add("KHAUVAT");
            tableTrinhTu.Columns.Add("KHAUMUIROI");
            tableTrinhTu.Columns.Add("SOMUI");
            tableTrinhTu.Columns.Add("LOAICHI");
            tableTrinhTu.Columns.Add("DIENBIENKHAC");
            tableTrinhTu.Columns.Add("TIEMMAT");
            tableTrinhTu.Columns.Add("DUOIKMCNC");
            tableTrinhTu.Columns.Add("LOAITHUOC");
            tableTrinhTu.Columns.Add("TRAMAT");
            tableTrinhTu.Columns.Add("BANG");

            while (DataReader.Read())
            {
                // add Trinh Tu Phau Thuat
                TrinhTuPhauThuatT3 trinhTuPhauThuat = new TrinhTuPhauThuatT3();
                int temp = 0;
                if (DataReader["CoDinhNhanCau"] != null && int.TryParse(DataReader["CODINHNHANCAU"].ToString(), out temp))
                {
                    trinhTuPhauThuat.CoDinhNhanCau = (CoDinhNhanCauT3)temp;
                }

                trinhTuPhauThuat.TinhTrang = JsonConvert.DeserializeObject<TinhTrangT3>(DataReader["TINHTRANG"].ToString());
                trinhTuPhauThuat.MoKMRia = JsonConvert.DeserializeObject<MoKMRiaT3>(DataReader["MOKMRIA"].ToString());
                trinhTuPhauThuat.MoVaoTp = JsonConvert.DeserializeObject<MoVaoTpT3>(DataReader["MOVAOTP"].ToString());
                temp = 0;
                int.TryParse(DataReader["NHUOMBAO"].ToString(), out temp);
                trinhTuPhauThuat.NhuomBao = temp;
                trinhTuPhauThuat.XeBaoTruoc = JsonConvert.DeserializeObject<XeBaoTruocT3>(DataReader["XEBAOTRUOC"].ToString());
                trinhTuPhauThuat.TachNhan = JsonConvert.DeserializeObject<TachNhanT3>(DataReader["TACHNHAN"].ToString());
                trinhTuPhauThuat.DayNhanRaNgoai = JsonConvert.DeserializeObject<DayNhanRaNgoaiT3>(DataReader["DAYNHANRANGOAI"].ToString());
                trinhTuPhauThuat.TanNhan = JsonConvert.DeserializeObject<TanNhanT3>(DataReader["TANNHAN"].ToString());
                trinhTuPhauThuat.HutChatT3IA = JsonConvert.DeserializeObject<HutChatT3>(DataReader["HUTCHATT3IA"].ToString());
                trinhTuPhauThuat.DatIOL = JsonConvert.DeserializeObject<DatIOLT3>(DataReader["DATIOL"].ToString());
                trinhTuPhauThuat.RachBaoSau = JsonConvert.DeserializeObject<RachBaoSauT3>(DataReader["RACHBAOSAU"].ToString());
                trinhTuPhauThuat.CatBaoSau = JsonConvert.DeserializeObject<CatBaoSauT3>(DataReader["CATBAOSAU"].ToString());
                trinhTuPhauThuat.CatMongMatNgoaiVi = JsonConvert.DeserializeObject<CatMongMatNgoaiViT3>(DataReader["CATMONGMATNGOAIVI"].ToString());
                trinhTuPhauThuat.PhucHoiVetMo = JsonConvert.DeserializeObject<PhucHoiVetMoT3>(DataReader["PHUCHOIVETMO"].ToString());
                trinhTuPhauThuat.TiemMat = JsonConvert.DeserializeObject<TiemMatT3>(DataReader["TIEMMAT"].ToString());
                trinhTuPhauThuat.DienBienKhac = DataReader["DIENBIENKHAC"].ToString();
                tableTrinhTu.Rows.Add(
                   (int)trinhTuPhauThuat.CoDinhNhanCau,
                   (int)trinhTuPhauThuat.TinhTrang.DoDuc,
                   (int)trinhTuPhauThuat.TinhTrang.DoCungCuaNhan,
                   trinhTuPhauThuat.MoKMRia.MoKMRia,
                   trinhTuPhauThuat.MoKMRia.KinhTuyen,
                   (int)trinhTuPhauThuat.MoVaoTp.MoTP,
                   trinhTuPhauThuat.MoVaoTp.ViTriKinhTuyen,
                   trinhTuPhauThuat.MoVaoTp.KichThuoc,
                   trinhTuPhauThuat.NhuomBao,
                   trinhTuPhauThuat.XeBaoTruoc.XeBaoTruoc ? 1: 0,
                   trinhTuPhauThuat.XeBaoTruoc.MoBaoHinhNhuTem ? 1: 0,
                   trinhTuPhauThuat.TachNhan.TachNhan ? 1: 0,
                   (int)trinhTuPhauThuat.TachNhan.XoayNhan,
                   trinhTuPhauThuat.DayNhanRaNgoai.DayNhanRaNgoai ? 1: 0,
                   trinhTuPhauThuat.DayNhanRaNgoai.ChayNhay,
                   trinhTuPhauThuat.TanNhan.NangLuong,
                   trinhTuPhauThuat.TanNhan.LucHut,
                   trinhTuPhauThuat.TanNhan.TocDoDongChay,
                   trinhTuPhauThuat.HutChatT3IA.IA ? 1: 0,
                   trinhTuPhauThuat.HutChatT3IA.KimHaiNong ? 1 : 0,
                   trinhTuPhauThuat.DatIOL.Mem ? 1:0,
                   trinhTuPhauThuat.DatIOL.Cung ? 1:0,
                   trinhTuPhauThuat.DatIOL.DatBangPince ? 1:0,
                   trinhTuPhauThuat.DatIOL.BangSung ? 1:0,
                   trinhTuPhauThuat.DatIOL.DatTrongTuiBao ? 1:0,
                   trinhTuPhauThuat.DatIOL.RachTheMi ? 1:0,
                   trinhTuPhauThuat.DatIOL.CoDinhIOLCungMac ? 1 : 0,
                   trinhTuPhauThuat.RachBaoSau.RachBaoSau,
                   trinhTuPhauThuat.RachBaoSau.ViTriRach,
                   trinhTuPhauThuat.RachBaoSau.KichThuoc,
                   trinhTuPhauThuat.CatBaoSau.CatBaoSau,
                   trinhTuPhauThuat.CatBaoSau.CatBangKeo ? 1:0,
                   trinhTuPhauThuat.CatBaoSau.MayCatDK ? 1: 0,
                   trinhTuPhauThuat.CatMongMatNgoaiVi.CatMongMatNgoaiVi,
                   trinhTuPhauThuat.CatMongMatNgoaiVi.ViTriCatMongMatNgoaiVi,
                   trinhTuPhauThuat.PhucHoiVetMo.BomPhu ? 1:0,
                   trinhTuPhauThuat.PhucHoiVetMo.KhauVat ? 1:0,
                   trinhTuPhauThuat.PhucHoiVetMo.MuiRoi ? 1:0,
                   trinhTuPhauThuat.PhucHoiVetMo.SoMui,
                   trinhTuPhauThuat.PhucHoiVetMo.LoaiChi,
                   trinhTuPhauThuat.DienBienKhac,
                   trinhTuPhauThuat.TiemMat.TiemMat ? 1:0,
                   trinhTuPhauThuat.TiemMat.DuoiKMCNC ? 1:0,
                   trinhTuPhauThuat.TiemMat.LoaiThuoc,
                   trinhTuPhauThuat.TiemMat.TraMat,
                   trinhTuPhauThuat.TiemMat.Bang
                );
            }
            DataTable thongTinVien = new DataTable("HEADER");
            thongTinVien.Columns.Add("SOYTE");
            thongTinVien.Columns.Add("BENHVIEN");
			if (XemBenhAn._HanhChinhBenhNhan == null) XemBenhAn._HanhChinhBenhNhan = new HanhChinhBenhNhan();
            thongTinVien.Rows.Add(XemBenhAn._HanhChinhBenhNhan.SoYTe, XemBenhAn._HanhChinhBenhNhan.BenhVien);

            ds.Tables.Add(tableTrinhTu);
            ds.Tables.Add(thongTinVien);

            return ds;
        }
        public static string DownloadAnhMoTa(decimal IdThuThuat, decimal maQuanLy, bool WSActive, bool IsReplace)
        {
            string fullPath = "";
            try
            {
                string FileHinhAnh = @"\PPTThuyTinh" + @"\" + maQuanLy;
                if (IdThuThuat != 0M)
                {
                    if (WSActive)
                    {
                        using (var client = new HttpClient())
                        {
                            try
                            {
                                string URL = ERMDatabase.WebServiceEMR;
                                client.BaseAddress = new Uri(URL);
                                client.DefaultRequestHeaders.Accept.Clear();
                                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                                client.Timeout = new TimeSpan(0, 0, 1000);
                                string fileName = FileHinhAnh.Trim('\\') + "\\" + IdThuThuat + ".bmp";
                                var url = "api/KetXuat/Get1File?PathFile=" + fileName;
                                HttpResponseMessage response = client.GetAsync(url).Result;
                                response.EnsureSuccessStatusCode();
                                if (response.IsSuccessStatusCode)
                                {
                                    string result = response.Content.ReadAsStringAsync().Result;
                                    if (result != "null" && result != "[]")
                                    {
                                        FileCopy lstFile = JsonConvert.DeserializeObject<FileCopy>(result);
                                        if (lstFile != null)
                                        {
                                            string tempPath = System.IO.Path.GetTempPath().Trim('\\');
                                            fullPath = tempPath.Trim('\\') + "\\" + FileHinhAnh.Trim('\\');
                                            if (!System.IO.Directory.Exists(fullPath)) { System.IO.Directory.CreateDirectory(fullPath); }
                                            string fileHinhAnh = fullPath.Trim('\\') + "\\" + lstFile.FileName;
                                            try
                                            {
                                                File.WriteAllBytes(fileHinhAnh, lstFile.ArrayBytes);
                                            }
                                            catch
                                            {
                                            }
                                        }
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                XuLyLoi.LogError(ex);
                            }
                        }
                    }else
                    {
                        if(IsReplace)
                        {
                            string PathHAMau_Local = @"\PaintLibrary\HinhAnh\PPTThuyTinh\";
                            string FileAnhMau = "PhauThuatTheThuyTinh.bmp";
                            string AppPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                            string FullPathTmp = AppPath + PathHAMau_Local + FileAnhMau;

                            string tempPath = System.IO.Path.GetTempPath().Trim('\\');
                            tempPath = tempPath.Trim('\\') + "\\" + FileHinhAnh.Trim('\\');
                            if (!System.IO.Directory.Exists(tempPath)) { System.IO.Directory.CreateDirectory(tempPath); }
                            fullPath = tempPath.Trim('\\') + "\\" + IdThuThuat + ".bmp";
                            if (File.Exists(FullPathTmp))
                            {
                                try
                                {
                                    File.Copy(FullPathTmp, fullPath, true);
                                }
                                catch { }
                                finally { }

                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return fullPath;
        }
    }
}
