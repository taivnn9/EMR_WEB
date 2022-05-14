using EMR.KyDienTu;
using System;
using System.Collections.Generic;
using System.Data;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class BangKiemTruocKhiMo3 : ThongTinKy
    {
        public BangKiemTruocKhiMo3()
        {
            TableName = "BangKiemTruocKhiMo3";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BKTKM3;
            TenMauPhieu = DanhMucPhieu.BKTKM3.Description();
        }
        [MoTaDuLieu("Mã bác sĩ gây mê")]
        public string MaBacSyGayMe { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Tuổi của bệnh nhân")]
        public int AgePatient { get; set; }
        [MoTaDuLieu("Ngày mổ")]
        public DateTime NgayMo { get; set; }
        [MoTaDuLieu("Giờ mổ")]
        public DateTime GioMo { get; set; }
        [MoTaDuLieu("Số bệnh án")]
        public string NumberPatient { get; set; }
        [MoTaDuLieu("Số giường")]
        public int NumberBed { get; set; }
        [MoTaDuLieu("Số phòng")]
        public int NumberRoom { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Mạch(lần/phút)")]
        public string BloodVessel { get; set; }
        [MoTaDuLieu("Huyết áp(mmHg)")]
        public string BloodPressure { get; set; }
        [MoTaDuLieu("Nhiệt độ")]
        public string Temperature { get; set; }
        [MoTaDuLieu("Nhịp thở(lần/phút)")]
        public string Breathing { get; set; }
        [MoTaDuLieu("Ghi chú(sửa soạn vùng mổ)")]
        public string NoteSurgicalArea { get; set; }
        [MoTaDuLieu("Ghi chú(trưởng khoa kiểm soát vùng mổ)")]
        public string NoteTruongKhoa { get; set; }
        [MoTaDuLieu("Ghi chú(tắm)")]
        public string NoteBath { get; set; }
        [MoTaDuLieu("Ghi chú(thay quần áo mổ)")]
        public string NoteChangeClothes { get; set; }
        [MoTaDuLieu(" Ghi chú(bàn giao tài sản cá nhân)")]
        public string NoteHandoverOfProperty { get; set; }
        [MoTaDuLieu("Ghi chú(tháo răng giả nếu có)")]
        public string NoteRangGia { get; set; }
        [MoTaDuLieu("Ghi chú(bím tóc hoặc bọc tóc)")]
        public string NoteHairwrap { get; set; }
        [MoTaDuLieu("Ghi chú(Đặt thông tiểu cho bệnh nhân đi tiểu)")]
        public string NoteCatheterization { get; set; }
        [MoTaDuLieu("Ghi chú(thụt tháo)")]
        public string NoteColonCleanse { get; set; }
        [MoTaDuLieu("Ghi chú(đeo vòng tay hoặc bảng tên)")]
        public string NoteIdentityPatient { get; set; }
        [MoTaDuLieu("Ghi chú(nhịn ăn uống)")]
        public string NoteNhinAnUong { get; set; }
        [MoTaDuLieu("Ghi chú(số tờ phim X quang)")]
        public string NoteXQuang { get; set; }
        [MoTaDuLieu("Ghi chú(kháng sinh dự phòng)")]
        public string NoteKhangSinh { get; set; }
        [MoTaDuLieu("Ghi chú(ký cam kết phẩu thuật)")]
        public string NoteKyCamKet { get; set; }
        [MoTaDuLieu("Chẩn đoán")]
        public string Diagnose { get; set; }//chan doan
        [MoTaDuLieu("Họ và tên bệnh nhân")]
        public string NamePatient { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng phụ trách")]
		public string DieuDuongPhuTrach { get; set; }
        [MoTaDuLieu("Mã điều dưỡng phụ trách")]
		public string MaDieuDuongPhuTrach { get; set; }
        public string BacSyGayMe { get; set; }
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
        public bool[] SurgicalAreaArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Sửa soạn vùng mổ")]
        public int SurgicalArea
        {
            get
            {
                return Array.IndexOf(SurgicalAreaArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) SurgicalAreaArray[i] = true;
                    else SurgicalAreaArray[i] = false;
                }
            }
        }
        public bool[] TruongKhoaArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Trưởng khoa kiểm soát vùng mổ")]
        public int TruongKhoa
        {
            get
            {
                return Array.IndexOf(TruongKhoaArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) TruongKhoaArray[i] = true;
                    else TruongKhoaArray[i] = false;
                }
            }
        }
        public bool[] BathArray { get; } = new bool[] { false, false, false };
        [MoTaDuLieu("Tắm")]
        public int Bath
        {
            get
            {
                return Array.IndexOf(BathArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) BathArray[i] = true;
                    else BathArray[i] = false;
                }
            }
        }
        public bool[] ChangeClothesArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Cho bệnh nhân mặc áo mổ")]
        public int ChangeClothes
        {
            get
            {
                return Array.IndexOf(ChangeClothesArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) ChangeClothesArray[i] = true;
                    else ChangeClothesArray[i] = false;
                }
            }
        }
        public bool[] HandoverOfPropertyArray { get; } = new bool[] { false, false };
        //HandoverOfPropertyArray: bàn giao tài sản
        [MoTaDuLieu("Giữ lại nữ trang và son môi nếu có")]
        public int HandoverOfProperty
        {
            get
            {
                return Array.IndexOf(HandoverOfPropertyArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) HandoverOfPropertyArray[i] = true;
                    else HandoverOfPropertyArray[i] = false;
                }
            }
        }
        public bool[] RangGiaArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Tháo răng giả nếu có")]
        public int RangGia
        {
            get
            {
                return Array.IndexOf(RangGiaArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) RangGiaArray[i] = true;
                    else RangGiaArray[i] = false;
                }
            }
        }
        public bool[] HairWrapArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Bím tóc hoặc bọc tóc")]
        public int HairWrap
        {
            get
            {
                return Array.IndexOf(HairWrapArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) HairWrapArray[i] = true;
                    else HairWrapArray[i] = false;
                }
            }
        }
        public bool[] CatheterizationArray { get; } = new bool[] { false, false };
        //CatheterizationArray: đặt thông tiểu
        [MoTaDuLieu("Đặt thông tiểu")]
        public int Catheterization
        {
            get
            {
                return Array.IndexOf(CatheterizationArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) CatheterizationArray[i] = true;
                    else CatheterizationArray[i] = false;
                }
            }
        }
        public bool[] ColonCleanseArray { get; } = new bool[] { false, false };
        //ColonCleanse: thụt tháo
        [MoTaDuLieu("Thụt đại tràng")]
        public int ColonCleanse
        {
            get
            {
                return Array.IndexOf(ColonCleanseArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) ColonCleanseArray[i] = true;
                    else ColonCleanseArray[i] = false;
                }
            }
        }
        public bool[] GastricLavageArray { get; } = new bool[] { false, false };
        //GastricLavageArray: rửa dạ dày
        [MoTaDuLieu("Rửa dạ dày")]
        public int GastricLavage
        {
            get
            {
                return Array.IndexOf(GastricLavageArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) GastricLavageArray[i] = true;
                    else GastricLavageArray[i] = false;
                }
            }
        }
        public bool[] IdentityPatientArray { get; } = new bool[] { false, false };
        //dentityPatientArray: đeo vòng tay xác định bệnh nhân trước khi mổ
        [MoTaDuLieu("Deo vòng tên xác định bệnh nhân trước khi mổ")]
        public int IdentityPatient
        {
            get
            {
                return Array.IndexOf(IdentityPatientArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) IdentityPatientArray[i] = true;
                    else IdentityPatientArray[i] = false;
                }
            }
        }
        public bool[] NhinAnUongArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Nhịn ăn uống")]
        public int NhinAnUong
        {
            get
            {
                return Array.IndexOf(NhinAnUongArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) NhinAnUongArray[i] = true;
                    else NhinAnUongArray[i] = false;
                }
            }
        }
        public bool[] XQuangArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Số tờ phim X quang")]
        public int XQuang
        {
            get
            {
                return Array.IndexOf(XQuangArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) XQuangArray[i] = true;
                    else XQuangArray[i] = false;
                }
            }
        }
        public bool[] KhangSinhArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Kháng sinh dự phòng")]
        public int KhangSinh
        {
            get
            {
                return Array.IndexOf(KhangSinhArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) KhangSinhArray[i] = true;
                    else KhangSinhArray[i] = false;
                }
            }
        }
        public bool[] KyCamKetArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Ký cam kết phẩu thuật")]
        public int KyCamKet
        {
            get
            {
                return Array.IndexOf(KyCamKetArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) KyCamKetArray[i] = true;
                    else KyCamKetArray[i] = false;
                }
            }
        }
        public bool[] SexPatientArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Giới tính bệnh nhân")]
        public int SexPatient
        {
            get
            {
                return Array.IndexOf(SexPatientArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) SexPatientArray[i] = true;
                    else SexPatientArray[i] = false;
                }
            }
        }
    }
    public class BangKiemTruocKhiMo3Func
    {
        public const string TableName = "BangKiemTruocKhiMo3";
        public const string TablePrimaryKeyName = "ID";
        public static List<BangKiemTruocKhiMo3> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BangKiemTruocKhiMo3> list = new List<BangKiemTruocKhiMo3>();
            try
            {
                string sql = @"SELECT * FROM BangKiemTruocKhiMo3 where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    BangKiemTruocKhiMo3 data = new BangKiemTruocKhiMo3();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.NgayMo = Convert.ToDateTime(DataReader["NgayGioMo"] == DBNull.Value ? DateTime.Now : DataReader["NgayGioMo"]);
                    data.GioMo = Convert.ToDateTime(DataReader["NgayGioMo"] == DBNull.Value ? DateTime.Now : DataReader["NgayGioMo"]);
                    data.NumberPatient = DataReader["NUMBERPATIENT"].ToString();
                    data.NamePatient = DataReader["NAMEPATIENT"].ToString();
                    if (DataReader["AGEPATIENT"].ToString() == null || DataReader["AGEPATIENT"].ToString() == "") data.AgePatient = 0;
                    else data.AgePatient = int.Parse(DataReader["AGEPATIENT"].ToString());
                    if (DataReader["NUMBERBED"].ToString() == null || DataReader["NUMBERBED"].ToString() == "") data.NumberBed = 0;
                    else data.NumberBed = int.Parse(DataReader["NUMBERBED"].ToString());
                    if (DataReader["NUMBERROOM"].ToString() == null || DataReader["NUMBERROOM"].ToString() == "") data.NumberRoom = 0;
                    else data.NumberRoom = int.Parse(DataReader["NUMBERROOM"].ToString());
                    data.Diagnose = DataReader["DIAGNOSE"].ToString();

                    int tempInt = -1;
                    int.TryParse(DataReader["SEXPATIENT"].ToString(), out tempInt);
                    data.SexPatient = tempInt;

                    tempInt = -1;
                    int.TryParse(DataReader["SURGICALAREA"].ToString(), out tempInt);
                    data.SurgicalArea = tempInt;

                    tempInt = -1;
                    int.TryParse(DataReader["TruongKhoa"].ToString(), out tempInt);
                    data.TruongKhoa = tempInt;

                    tempInt = -1;
                    int.TryParse(DataReader["BATH"].ToString(), out tempInt);
                    data.Bath = tempInt;

                    tempInt = -1;//thay quan ao mo
                    int.TryParse(DataReader["CHANGECLOTHES"].ToString(), out tempInt);
                    data.ChangeClothes = tempInt;

                    tempInt = -1;// ban giao tai san ca nhan
                    int.TryParse(DataReader["HANDOVEROFPROPERTY"].ToString(), out tempInt);
                    data.HandoverOfProperty = tempInt;

                    tempInt = -1;
                    int.TryParse(DataReader["RangGia"].ToString(), out tempInt);
                    data.RangGia = tempInt;

                    tempInt = -1;//boc toc, bim toc
                    int.TryParse(DataReader["HAIRWRAP"].ToString(), out tempInt);
                    data.HairWrap = tempInt;

                    tempInt = -1;//dat ong thong tieu
                    int.TryParse(DataReader["CATHETERIZATION"].ToString(), out tempInt);
                    data.Catheterization = tempInt;

                    tempInt = -1;//thut thao
                    int.TryParse(DataReader["COLONCLEANSE"].ToString(), out tempInt);
                    data.ColonCleanse = tempInt;

                    tempInt = -1;//rua da day
                    int.TryParse(DataReader["GASTRICLAVAGE"].ToString(), out tempInt);
                    data.GastricLavage = tempInt;

                    tempInt = -1;// deo vong tay xac nhan benh nhan truoc khi mo
                    int.TryParse(DataReader["IDENTITYPATIENT"].ToString(), out tempInt);
                    data.IdentityPatient = tempInt;

                    tempInt = -1;
                    int.TryParse(DataReader["NhinAnUong"].ToString(), out tempInt);
                    data.NhinAnUong = tempInt;

                    tempInt = -1;
                    int.TryParse(DataReader["XQuang"].ToString(), out tempInt);
                    data.XQuang = tempInt;

                    tempInt = -1;
                    int.TryParse(DataReader["KhangSinh"].ToString(), out tempInt);
                    data.KhangSinh = tempInt;

                    tempInt = -1;
                    int.TryParse(DataReader["KyCamKet"].ToString(), out tempInt);
                    data.KyCamKet = tempInt;

                    //mach
                    data.BloodVessel = DataReader["BLOODVESSEL"].ToString();
                    //BLOODPRESSURE: huyet ap
                    data.BloodPressure = DataReader["BLOODPRESSURE"].ToString();
                    //nhiet do
                    data.Temperature = DataReader["TEMPERATURE"].ToString();
                    //nhip tho
                    data.Breathing = DataReader["BREATHING"].ToString();

                    data.NoteSurgicalArea = DataReader["NoteSurgicalArea"].ToString();
                    data.NoteTruongKhoa = DataReader["NoteTruongKhoa"].ToString();
                    data.NoteBath = DataReader["NoteBath"].ToString();
                    data.NoteChangeClothes = DataReader["NoteChangeClothes"].ToString();
                    data.NoteHandoverOfProperty = DataReader["NoteHandoverOfProperty"].ToString();
                    data.NoteRangGia = DataReader["NoteRangGia"].ToString();
                    data.NoteHairwrap = DataReader["NoteHairwrap"].ToString();
                    data.NoteCatheterization = DataReader["NoteCatheterization"].ToString();
                    data.NoteColonCleanse = DataReader["NoteColonCleanse"].ToString();
                    data.NoteIdentityPatient = DataReader["NoteIdentityPatient"].ToString();
                    data.NoteNhinAnUong = DataReader["NoteNhinAnUong"].ToString();
                    data.NoteXQuang = DataReader["NoteXQuang"].ToString();
                    data.NoteKhangSinh = DataReader["NoteKhangSinh"].ToString();
                    data.NoteKyCamKet = DataReader["NoteKyCamKet"].ToString();

                    data.DieuDuongPhuTrach = DataReader["DIEUDUONGBANGIAO"].ToString();
                    data.MaDieuDuongPhuTrach = DataReader["MADIEUDUONGBANGIAO"].ToString();
                    data.BacSyGayMe = DataReader["BACSYGAYME"].ToString();
                    data.MaBacSyGayMe = DataReader["MABACSYGAYME"].ToString();

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BangKiemTruocKhiMo3 data)
        {
            try
            {
                string sql = @"INSERT INTO BangKiemTruocKhiMo3
                (
                    MAQUANLY,
                    MABENHNHAN,
                    NGAYGIOMO,
                    NUMBERPATIENT,
                    NAMEPATIENT,
                    AGEPATIENT,
                    SEXPATIENT,
                    NUMBERBED,
                    NUMBERROOM,
                    DIAGNOSE,
                    SURGICALAREA,
                    TruongKhoa,
                    BATH,
                    CHANGECLOTHES,
                    HANDOVEROFPROPERTY,
                    RangGia,
                    HAIRWRAP,
                    CATHETERIZATION,
                    COLONCLEANSE,
                    GASTRICLAVAGE,
                    IDENTITYPATIENT,
                    NhinAnUong,
                    XQuang,
                    KhangSinh,
                    KyCamKet,
                    NoteSurgicalArea,
                    NoteTruongKhoa,
                    NoteBath,
                    NoteChangeClothes,
                    NoteHandoverOfProperty,
                    NoteRangGia,
                    NoteHairwrap,
                    NoteCatheterization,
                    NoteColonCleanse,
                    NoteIdentityPatient,
                    NoteNhinAnUong,
                    NoteXQuang,
                    NoteKhangSinh,
                    NoteKyCamKet,
                    BLOODVESSEL,
                    BLOODPRESSURE,
                    TEMPERATURE,
                    BREATHING,
                    DieuDuongBanGiao,
                    MaDieuDuongBangiao,
                    BacSyGayMe,
                    MaBacSyGayMe,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MABENHNHAN,
                    :NGAYGIOMO,
                    :NUMBERPATIENT,
                    :NAMEPATIENT,
                    :AGEPATIENT,
                    :SEXPATIENT,
                    :NUMBERBED,
                    :NUMBERROOM,
                    :DIAGNOSE,
                    :SURGICALAREA,
                    :TruongKhoa,
                    :BATH,
                    :CHANGECLOTHES,
                    :HANDOVEROFPROPERTY,
                    :RangGia,
                    :HAIRWRAP,
                    :CATHETERIZATION,
                    :COLONCLEANSE,
                    :GASTRICLAVAGE,
                    :IDENTITYPATIENT,
                    :NhinAnUong,
                    :XQuang,
                    :KhangSinh,
                    :KyCamKet,
                    :NoteSurgicalArea,
                    :NoteTruongKhoa,
                    :NoteBath,
                    :NoteChangeClothes,
                    :NoteHandoverOfProperty,
                    :NoteRangGia,
                    :NoteHairwrap,
                    :NoteCatheterization,
                    :NoteColonCleanse,
                    :NoteIdentityPatient,
                    :NoteNhinAnUong,
                    :NoteXQuang,
                    :NoteKhangSinh,
                    :NoteKyCamKet,
                    :BLOODVESSEL,
                    :BLOODPRESSURE,
                    :TEMPERATURE,
                    :BREATHING,
                    :DieuDuongBanGiao,
                    :MaDieuDuongBanGiao,
                    :BacSyGayMe,
                    :MaBacSyGayMe,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (data.ID != 0)
                {
                    sql = @"UPDATE BangKiemTruocKhiMo3 SET 
                    MAQUANLY=:MAQUANLY,
                    MABENHNHAN=:MABENHNHAN,
                    NGAYGIOMO=:NGAYGIOMO,
                    NUMBERPATIENT=:NUMBERPATIENT,
                    NAMEPATIENT=:NAMEPATIENT,
                    AGEPATIENT=:AGEPATIENT,
                    SEXPATIENT=:SEXPATIENT,
                    NUMBERBED=:NUMBERBED,
                    NUMBERROOM=:NUMBERROOM,
                    DIAGNOSE=:DIAGNOSE,
                    SURGICALAREA=:SURGICALAREA,
                    TruongKhoa=:TruongKhoa,
                    BATH=:BATH,
                    CHANGECLOTHES=:CHANGECLOTHES,
                    HANDOVEROFPROPERTY=:HANDOVEROFPROPERTY,
                    RangGia=:RangGia,
                    HAIRWRAP=:HAIRWRAP,
                    CATHETERIZATION=:CATHETERIZATION,
                    COLONCLEANSE=:COLONCLEANSE,
                    GASTRICLAVAGE=:GASTRICLAVAGE,
                    IDENTITYPATIENT=:IDENTITYPATIENT,
                    NhinAnUong=:NhinAnUong,
                    XQuang=:XQuang,
                    KhangSinh=:KhangSinh,
                    KyCamKet=:KyCamKet,
                    NoteSurgicalArea=:NoteSurgicalArea,
                    NoteTruongKhoa=:NoteTruongKhoa,
                    NoteBath=:NoteBath,
                    NoteChangeClothes=:NoteChangeClothes,
                    NoteHandoverOfProperty=:NoteHandoverOfProperty,
                    NoteRangGia=:NoteRangGia,
                    NoteHairwrap=:NoteHairwrap,
                    NoteCatheterization=:NoteCatheterization,
                    NoteColonCleanse=:NoteColonCleanse,
                    NoteIdentityPatient=:NoteIdentityPatient,
                    NoteNhinAnUong=:NoteNhinAnUong,
                    NoteXQuang=:NoteXQuang,
                    NoteKhangSinh=:NoteKhangSinh,
                    NoteKyCamKet=:NoteKyCamKet,
                    BLOODVESSEL=:BLOODVESSEL,
                    BLOODPRESSURE=:BLOODPRESSURE,
                    TEMPERATURE=:TEMPERATURE,
                    BREATHING=:BREATHING,
                    DieuDuongBanGiao= :DieuDuongBanGiao,
                    MaDieuDuongBanGiao= :MaDieuDuongBanGiao,
                    BacSyGayMe= :BacSyGayMe,
                    MaBacSyGayMe= :MaBacSyGayMe,
                    NGUOISUA= :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + data.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", data.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", data.MaBenhNhan));
                var Ngay = data.NgayMo.Date.Add(new TimeSpan(0, 0, 0));
                var Gio = data.GioMo != null ? data.GioMo.TimeOfDay : DateTime.Now.TimeOfDay;
                var NgayGioMo = Ngay + Gio;
                Command.Parameters.Add(new MDB.MDBParameter("NgayGioMo", NgayGioMo));
                Command.Parameters.Add(new MDB.MDBParameter("NUMBERPATIENT", data.NumberPatient));
                Command.Parameters.Add(new MDB.MDBParameter("NAMEPATIENT", data.NamePatient));
                Command.Parameters.Add(new MDB.MDBParameter("AGEPATIENT", data.AgePatient));
                Command.Parameters.Add(new MDB.MDBParameter("SEXPATIENT", data.SexPatient));
                Command.Parameters.Add(new MDB.MDBParameter("NUMBERBED", data.NumberBed));
                Command.Parameters.Add(new MDB.MDBParameter("NUMBERROOM", data.NumberRoom));
                Command.Parameters.Add(new MDB.MDBParameter("DIAGNOSE", data.Diagnose));
                Command.Parameters.Add(new MDB.MDBParameter("SURGICALAREA", data.SurgicalArea));
                Command.Parameters.Add(new MDB.MDBParameter("TruongKhoa", data.TruongKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("BATH", data.Bath));
                Command.Parameters.Add(new MDB.MDBParameter("CHANGECLOTHES", data.ChangeClothes));
                Command.Parameters.Add(new MDB.MDBParameter("HANDOVEROFPROPERTY", data.HandoverOfProperty));
                Command.Parameters.Add(new MDB.MDBParameter("RangGia", data.RangGia));
                Command.Parameters.Add(new MDB.MDBParameter("HAIRWRAP", data.HairWrap));
                Command.Parameters.Add(new MDB.MDBParameter("CATHETERIZATION", data.Catheterization));
                Command.Parameters.Add(new MDB.MDBParameter("COLONCLEANSE", data.ColonCleanse));
                Command.Parameters.Add(new MDB.MDBParameter("GASTRICLAVAGE", data.GastricLavage));
                Command.Parameters.Add(new MDB.MDBParameter("IDENTITYPATIENT", data.IdentityPatient));
                Command.Parameters.Add(new MDB.MDBParameter("NhinAnUong", data.NhinAnUong));
                Command.Parameters.Add(new MDB.MDBParameter("XQuang", data.XQuang));
                Command.Parameters.Add(new MDB.MDBParameter("KhangSinh", data.KhangSinh));
                Command.Parameters.Add(new MDB.MDBParameter("KyCamKet", data.KyCamKet));
                Command.Parameters.Add(new MDB.MDBParameter("NoteSurgicalArea", data.NoteSurgicalArea));
                Command.Parameters.Add(new MDB.MDBParameter("NoteTruongKhoa", data.NoteTruongKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("NoteBath", data.NoteBath));
                Command.Parameters.Add(new MDB.MDBParameter("NoteChangeClothes", data.NoteChangeClothes));
                Command.Parameters.Add(new MDB.MDBParameter("NoteHandoverOfProperty", data.NoteHandoverOfProperty));
                Command.Parameters.Add(new MDB.MDBParameter("NoteRangGia", data.NoteRangGia));
                Command.Parameters.Add(new MDB.MDBParameter("NoteHairwrap", data.NoteHairwrap));
                Command.Parameters.Add(new MDB.MDBParameter("NoteCatheterization", data.NoteCatheterization));
                Command.Parameters.Add(new MDB.MDBParameter("NoteColonCleanse", data.NoteColonCleanse));
                Command.Parameters.Add(new MDB.MDBParameter("NoteIdentityPatient", data.NoteIdentityPatient));
                Command.Parameters.Add(new MDB.MDBParameter("NoteNhinAnUong", data.NoteNhinAnUong));
                Command.Parameters.Add(new MDB.MDBParameter("NoteXQuang", data.NoteXQuang));
                Command.Parameters.Add(new MDB.MDBParameter("NoteKhangSinh", data.NoteKhangSinh));
                Command.Parameters.Add(new MDB.MDBParameter("NoteKyCamKet", data.NoteKyCamKet));
                Command.Parameters.Add(new MDB.MDBParameter("BLOODVESSEL", data.BloodVessel));
                Command.Parameters.Add(new MDB.MDBParameter("BLOODPRESSURE", data.BloodPressure));
                Command.Parameters.Add(new MDB.MDBParameter("TEMPERATURE", data.Temperature));
                Command.Parameters.Add(new MDB.MDBParameter("BREATHING", data.Breathing));


                Command.Parameters.Add(new MDB.MDBParameter("DieuDuongBanGiao", data.DieuDuongPhuTrach));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuongBanGiao", data.MaDieuDuongPhuTrach));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyGayMe", data.BacSyGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSyGayMe", data.MaBacSyGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", data.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", data.NgaySua));
                if (data.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", data.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", data.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", data.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (data.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    data.ID = nextval;
                }
                return n > 0;
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
                string sql = "DELETE FROM BangKiemTruocKhiMo3 WHERE ID = :ID";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                command.Parameters.Add(new MDB.MDBParameter("ID", id));
                command.BindByName = true;
                int n = command.ExecuteNonQuery();
                return n > 0;
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
                B.*,
                T.MABENHAN,
                T.SoNhapVien,
	            H.TENBENHNHAN,
                H.TUOI
            FROM
                BangKiemTruocKhiMo3 B
                JOIN THONGTINDIEUTRI T ON B.MAQUANLY = T.MAQUANLY
                JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "BK");

            /*DataTable thongTinVien = new DataTable("HEADER");

            thongTinVien.Columns.Add("BENHVIEN");
            thongTinVien.Columns.Add("KHOA");
            thongTinVien.Rows.Add(XemBenhAn._HanhChinhBenhNhan.BenhVien, XemBenhAn._ThongTinDieuTri.Khoa);
            ds.Tables.Add(thongTinVien);*/

            return ds;
        }
    }
}