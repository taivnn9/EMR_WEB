using EMR.KyDienTu;
using System;
using System.Collections.Generic;
using System.Data;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class BangKiemTruocKhiMo2 : ThongTinKy
    {
        public BangKiemTruocKhiMo2()
        {
            TableName = "BangKiemTruocKhiMo2";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BKTKM2;
            TenMauPhieu = DanhMucPhieu.BKTKM2.Description();
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
        [MoTaDuLieu("Vấn đề đặc biệt")]
        public string SpecialIssue { get; set; }
        [MoTaDuLieu("Ghi chú(Giải thích cho bệnh nhân và người nhà)")]
        public string NoteYEP { get; set; }
        [MoTaDuLieu("Ghi chú(tắm)")]
        public string NoteBATH { get; set; }
        [MoTaDuLieu("Ghi chú(bím tóc hoặc bọc tóc)")]
        public string NoteHAIRWRAP { get; set; }
        [MoTaDuLieu("Ghi chú(sửa soạn vùng mổ)")]
        public string NoteSurgicalArea { get; set; }
        [MoTaDuLieu("Ghi chú(thụt tháo)")]
        public string NoteColonCleanse { get; set; }
        [MoTaDuLieu("Ghi chú(rửa dạ dày)")]
        public string NoteGastricLavage { get; set; }
        [MoTaDuLieu("Ghi chú(Đặt thông tiểu cho bệnh nhân đi tiểu)")]
        public string NoteCatheterization { get; set; }
        [MoTaDuLieu(" Ghi chú(bàn giao tài sản cá nhân)")]
        public string NoteHandoverOfProperty { get; set; }
        [MoTaDuLieu(" Ghi chú(rửa sạch vết son môi, sơn móng tay)")]
        public string NoteClearLipstickNail { get; set; }
        [MoTaDuLieu("Ghi chú(đeo vòng tay hoặc bảng tên)")]
        public string NoteIdentityPatient { get; set; }
        [MoTaDuLieu("Ghi chú(thay quần áo mổ)")]
        public string NoteChangeClothes { get; set; }
        [MoTaDuLieu("Chẩn đoán")]
        public string Diagnose { get; set; }//chan doan
        [MoTaDuLieu("Họ và tên bệnh nhân")]
        public string NamePatient { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng phụ trách")]
		public string DieuDuongPhuTrach { get; set; }
        [MoTaDuLieu("Mã điều dưỡng phụ trách")]
		public string MaDieuDuongPhuTrach { get; set; }
        [MoTaDuLieu("Họ và tên bác sĩ gây mê")]
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
        [MoTaDuLieu("Cam kết phẫu thuật")]
        public string CommitmentSurgery { get; set; }//cam kết phẫu thuật
        [MoTaDuLieu("Kết quả xét nghiệm máu")]
        public string BloodTestResults { get; set; }//ket quả xét nghiệm máu
        [MoTaDuLieu("Kết quả xét nghiệm nước tiểu")]
        public string UrineTestResults { get; set; }//kết quả xét nghiệm nước tiểu
        [MoTaDuLieu("Kết quả đo điện tim")]
        public string ECGResults { get; set; }//kết quả đo điện tim
        [MoTaDuLieu("Kết quả siêu âm")]
        public string SuperSonicResult { get; set; }//kết quả siêu âm
        [MoTaDuLieu("Tên thuốc đã sử dụng trước phẫu thuật thứ 1")]
        public string NameMedicine1 { get; set; }//tên thuốc đã sử dụng trước phẫu thuật.
        [MoTaDuLieu("Tên thuốc đã sử dụng trước phẫu thuật thứ 2")]
        public string NameMedicine2 { get; set; }//tên thuốc đã sử dụng trước phẫu thuật.
        [MoTaDuLieu("Tên thuốc đã sử dụng trước phẫu thuật thứ 3")]
        public string NameMedicine3 { get; set; }//tên thuốc đã sử dụng trước phẫu thuật.
        [MoTaDuLieu("Tên thuốc đã sử dụng trước phẫu thuật thứ 4")]
        public string NameMedicine4 { get; set; }//tên thuốc đã sử dụng trước phẫu thuật.
        [MoTaDuLieu("Tên thuốc đã sử dụng trước phẫu thuật thứ 5")]
        public string NameMedicine5 { get; set; }//tên thuốc đã sử dụng trước phẫu thuật.

        [MoTaDuLieu("Loại thuốc đã sử dụng trước phẫu thuật thứ 1(viên, lọ chai)")]
        public string FormatMedicine1 { get; set; }//dang thuoc(vien, lo, chai ...).
        [MoTaDuLieu("Loại thuốc đã sử dụng trước phẫu thuật thứ 2(viên, lọ chai)")]
        public string FormatMedicine2 { get; set; }//dang thuoc(vien, lo, chai ...).
        [MoTaDuLieu("Loại thuốc đã sử dụng trước phẫu thuật thứ 3(viên, lọ chai)")]
        public string FormatMedicine3 { get; set; }//dang thuoc(vien, lo, chai ...).
        [MoTaDuLieu("Loại thuốc đã sử dụng trước phẫu thuật thứ 4(viên, lọ chai)")]
        public string FormatMedicine4 { get; set; }//dang thuoc(vien, lo, chai ...).
        [MoTaDuLieu("Loại thuốc đã sử dụng trước phẫu thuật thứ 5(viên, lọ chai)")]
        public string FormatMedicine5 { get; set; }//dang thuoc(vien, lo, chai ...).

        [MoTaDuLieu("Số lượng thuốc đã sử dụng trước phẫu thuật thứ 1(viên, lọ chai)")]
        public string NumberMedicine1 { get; set; }//dang thuoc(vien, lo, chai ...).
        [MoTaDuLieu("Số lượng thuốc đã sử dụng trước phẫu thuật thứ 2(viên, lọ chai)")]
        public string NumberMedicine2 { get; set; }//dang thuoc(vien, lo, chai ...).
        [MoTaDuLieu("Số lượng thuốc đã sử dụng trước phẫu thuật thứ 3(viên, lọ chai)")]
        public string NumberMedicine3 { get; set; }//dang thuoc(vien, lo, chai ...).
        [MoTaDuLieu("Số lượng thuốc đã sử dụng trước phẫu thuật thứ 4(viên, lọ chai)")]
        public string NumberMedicine4 { get; set; }//dang thuoc(vien, lo, chai ...).
        [MoTaDuLieu("Số lượng thuốc đã sử dụng trước phẫu thuật thứ 5(viên, lọ chai)")]
        public string NumberMedicine5 { get; set; }//dang thuoc(vien, lo, chai ...).



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
                for (int i = 0; i < 3; i++)
                {
                    if (i == (value - 1)) BathArray[i] = true;
                    else BathArray[i] = false;
                }
            }
        }
        public bool[] YEPArray { get; } = new bool[] { false, false };
        //YEP: yes explain for patient
        [MoTaDuLieu("Giải thích cho bệnh nhân và người nhà")]
        public int YEP
        {
            get
            {
                return Array.IndexOf(YEPArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) YEPArray[i] = true;
                    else YEPArray[i] = false;
                }
            }
        }

        public bool[] HairWrapArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Bím tóc")]
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

        public bool[] ColonCleanseArray { get; } = new bool[] { false, false };
        //ColonCleanse: thụt tháo
        [MoTaDuLieu("Thụt tháo")]
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

        public bool[] CatheterizationArray { get; } = new bool[] { false, false };
        //CatheterizationArray: đặt thông tiểu
        [MoTaDuLieu("Đặt thông tiểu cho bệnh nhân đi tiểu")]
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

        public bool[] HandoverOfPropertyArray { get; } = new bool[] { false, false };
        //HandoverOfPropertyArray: bàn giao tài sản
        [MoTaDuLieu("Bàn giao tài sản cá nhân(tư trang, răng giả)")]
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

        public bool[] ClearLipstickNailArray { get; } = new bool[] { false, false };
        //ClearLipstickNail: làm sạch son môi và móng tay
        [MoTaDuLieu("Rửa sạch vết son môi, sơn móng tay")]
        public int ClearLipstickNail
        {
            get
            {
                return Array.IndexOf(ClearLipstickNailArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) ClearLipstickNailArray[i] = true;
                    else ClearLipstickNailArray[i] = false;
                }
            }
        }

        public bool[] IdentityPatientArray { get; } = new bool[] { false, false };
        //dentityPatientArray: đeo vòng tay xác định bệnh nhân trước khi mổ
        [MoTaDuLieu("Đeo vòng tay hoặc bảng tên xác nhận bệnh nhân trước khi mổ")]
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
        public bool[] ChangeClothesArray { get; } = new bool[] { false, false };
        //ChangeClothesArray: thay quần áo mổ
        [MoTaDuLieu("Thay quần áo mổ")]
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


        public bool[] TamTruocKhiMoArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Tắm trước khi mổ")]
        public int TamTruocKhiMo
        {
            get
            {
                return Array.IndexOf(TamTruocKhiMoArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) TamTruocKhiMoArray[i] = true;
                    else TamTruocKhiMoArray[i] = false;
                }
            }
        }


    }
    public class BangKiemTruocKhiMoFunc2
    {
        public const string TableName = "BangKiemTruocKhiMo2";
        public const string TablePrimaryKeyName = "ID";
        public static List<BangKiemTruocKhiMo2> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BangKiemTruocKhiMo2> list = new List<BangKiemTruocKhiMo2>();
            try
            {
                string sql = @"SELECT * FROM BangKiemTruocKhiMo2 where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    BangKiemTruocKhiMo2 data = new BangKiemTruocKhiMo2();
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
                    int.TryParse(DataReader["EXPLAINPATIENT"].ToString(), out tempInt);
                    data.YEP = tempInt;

                    tempInt = -1;
                    int.TryParse(DataReader["BATHPATIENT"].ToString(), out tempInt);
                    data.Bath = tempInt;

                    tempInt = -1;//boc toc, bim toc
                    int.TryParse(DataReader["HAIRWRAP"].ToString(), out tempInt);
                    data.HairWrap = tempInt;

                    tempInt = -1;//ve sinh vung mo
                    int.TryParse(DataReader["SURGICALAREA"].ToString(), out tempInt);
                    data.SurgicalArea = tempInt;

                    tempInt = -1;//thut thao
                    int.TryParse(DataReader["COLONCLEANSE"].ToString(), out tempInt);
                    data.ColonCleanse = tempInt;

                    tempInt = -1;//rua da day
                    int.TryParse(DataReader["GASTRICLAVAGE"].ToString(), out tempInt);
                    data.GastricLavage = tempInt;

                    tempInt = -1;//dat ong thong tieu
                    int.TryParse(DataReader["CATHETERIZATION"].ToString(), out tempInt);
                    data.Catheterization = tempInt;

                    tempInt = -1;// ban giao tai san ca nhan
                    int.TryParse(DataReader["HANDOVEROFPROPERTY"].ToString(), out tempInt);
                    data.HandoverOfProperty = tempInt;

                    tempInt = -1;//lam sach son moi, mong tay
                    int.TryParse(DataReader["CLEARLIPSNAIL"].ToString(), out tempInt);
                    data.ClearLipstickNail = tempInt;

                    tempInt = -1;// deo vong tay xac nhan benh nhan truoc khi mo
                    int.TryParse(DataReader["IDENTITYPATIENT"].ToString(), out tempInt);
                    data.IdentityPatient = tempInt;

                    tempInt = -1;//thay quan ao mo
                    int.TryParse(DataReader["CHANGECLOTHES"].ToString(), out tempInt);
                    data.ChangeClothes = tempInt;
                    //mach
                    data.BloodVessel = DataReader["BLOODVESSEL"].ToString();
                    //BLOODPRESSURE: huyet ap
                    data.BloodPressure = DataReader["BLOODPRESSURE"].ToString();
                    //nhiet do
                    data.Temperature = DataReader["TEMPERATURE"].ToString();
                    //nhip tho
                    data.Breathing = DataReader["BREATHING"].ToString();
                    //van de dac biet
                    data.SpecialIssue = DataReader["SPECIALISSUE"].ToString();

                    //so phieu xac nhan truoc khi phau thuat
                    data.CommitmentSurgery = DataReader["COMMITMENTSURGERY"].ToString();
                    //ket qua xet nghiem mau
                    data.BloodTestResults = DataReader["BLOODTESTRESULT"].ToString();
                    //URINETESTRESULT: ket qua xet nghiem nuoc tieu
                    data.UrineTestResults = DataReader["URINETESTRESULT"].ToString();
                    //ECG: ket qua do dien tim
                    data.ECGResults = DataReader["ECG"].ToString();
                    //SUPERSONIC: ket qua sieu am
                    data.SuperSonicResult = DataReader["SUPERSONIC"].ToString();
                    data.NoteYEP = DataReader["NOTEYEP"].ToString();
                    data.NoteBATH = DataReader["NOTEBATH"].ToString();
                    data.NoteHAIRWRAP = DataReader["NOTEHAIRWRAP"].ToString();
                    data.NoteSurgicalArea = DataReader["NOTESURGICALAREA"].ToString();
                    data.NoteColonCleanse = DataReader["NOTECOLONCLEANSE"].ToString();
                    data.NoteGastricLavage = DataReader["NOTEGASTRICLAVAGE"].ToString();
                    data.NoteCatheterization = DataReader["NOTECATHETERIZATION"].ToString();
                    data.NoteHandoverOfProperty = DataReader["NoteHandoverOfProperty"].ToString();
                    data.NoteClearLipstickNail = DataReader["NoteClearLipstickNail"].ToString();
                    data.NoteIdentityPatient = DataReader["NoteIdentityPatient"].ToString();
                    data.NoteChangeClothes = DataReader["NoteChangeClothes"].ToString();
                    data.NameMedicine1 = DataReader["NameMedicine1"].ToString();
                    data.NameMedicine2 = DataReader["NameMedicine2"].ToString();
                    data.NameMedicine3 = DataReader["NameMedicine3"].ToString();
                    data.NameMedicine4 = DataReader["NameMedicine4"].ToString();
                    data.NameMedicine5 = DataReader["NameMedicine5"].ToString();
                    data.FormatMedicine1 = DataReader["FormatMedicine1"].ToString();
                    data.FormatMedicine2 = DataReader["FormatMedicine2"].ToString();
                    data.FormatMedicine3 = DataReader["FormatMedicine3"].ToString();
                    data.FormatMedicine4 = DataReader["FormatMedicine4"].ToString();
                    data.FormatMedicine5 = DataReader["FormatMedicine5"].ToString();
                    data.NumberMedicine1 = DataReader["NumberMedicine1"].ToString();
                    data.NumberMedicine2 = DataReader["NumberMedicine2"].ToString();
                    data.NumberMedicine3 = DataReader["NumberMedicine3"].ToString();
                    data.NumberMedicine4 = DataReader["RNumberMedicine4"].ToString();
                    data.NumberMedicine5 = DataReader["NumberMedicine5"].ToString();
                    data.DieuDuongPhuTrach = DataReader["DIEUDUONGBANGIAO"].ToString();
                    data.MaDieuDuongPhuTrach = DataReader["MADIEUDUONGBANGIAO"].ToString();
                    data.BacSyGayMe = DataReader["BACSYGAYME"].ToString();
                    data.MaBacSyGayMe = DataReader["MABACSYGAYME"].ToString();
                    //data.NumberRoom = int.Parse(DataReader["NUMBERROOM"].ToString());


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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BangKiemTruocKhiMo2 BangKiemTruocKhiMo2)
        {
            try
            {
                string sql = @"INSERT INTO BangKiemTruocKhiMo2
                (
                    MAQUANLY,
                    MaBenhNhan,
                    NgayGioMo,
                    NUMBERPATIENT,
                    NAMEPATIENT,
                    AGEPATIENT,
                    SEXPATIENT,
                    NUMBERBED,
                    NUMBERROOM,
                    DIAGNOSE,
                    EXPLAINPATIENT,
                    BATHPATIENT,
                    HAIRWRAP,
                    SURGICALAREA,
                    COLONCLEANSE,
                    GASTRICLAVAGE,
                    CATHETERIZATION,
                    HANDOVEROFPROPERTY,
                    CLEARLIPSNAIL,
                    IDENTITYPATIENT,
                    CHANGECLOTHES,
                    BLOODVESSEL,
                    BLOODPRESSURE,
                    TEMPERATURE,
                    BREATHING,
                    SPECIALISSUE,
                    COMMITMENTSURGERY,
                    BLOODTESTRESULT,
                    URINETESTRESULT,
                    ECG,
                    SUPERSONIC,
                    NOTEYEP,
                    NOTEBATH,
                    NOTEHAIRWRAP,
                    NOTESURGICALAREA,
                    NOTECOLONCLEANSE,
                    NOTEGASTRICLAVAGE,
                    NOTECATHETERIZATION,
                    NOTEHANDOVEROFPROPERTY,
                    NOTECLEARLIPSTICKNAIL,
                    NOTEIDENTITYPATIENT,
                    NOTECHANGECLOTHES,
                    NAMEMEDICINE1,
                    NAMEMEDICINE2,
                    NAMEMEDICINE3,
                    NAMEMEDICINE4,
                    NAMEMEDICINE5,
                    FORMATMEDICINE1,
                    FORMATMEDICINE2,
                    FORMATMEDICINE3,
                    FORMATMEDICINE4,
                    FORMATMEDICINE5,
                    NUMBERMEDICINE1,
                    NUMBERMEDICINE2,
                    NUMBERMEDICINE3,
                    RNUMBERMEDICINE4,
                    NUMBERMEDICINE5,
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
                    :MaBenhNhan,
                    :NgayGioMo,
                    :NUMBERPATIENT,
                    :NAMEPATIENT,
                    :AGEPATIENT,
                    :SEXPATIENT,
                    :NUMBERBED,
                    :NUMBERROOM,
                    :DIAGNOSE,
                    :EXPLAINPATIENT,
                    :BATHPATIENT,
                    :HAIRWRAP,
                    :SURGICALAREA,
                    :COLONCLEANSE,
                    :GASTRICLAVAGE,
                    :CATHETERIZATION,
                    :HANDOVEROFPROPERTY,
                    :CLEARLIPSNAIL,
                    :IDENTITYPATIENT,
                    :CHANGECLOTHES,
                    :BLOODVESSEL,
                    :BLOODPRESSURE,
                    :TEMPERATURE,
                    :BREATHING,
                    :SPECIALISSUE,
                    :COMMITMENTSURGERY,
                    :BLOODTESTRESULT,
                    :URINETESTRESULT,
                    :ECG,
                    :SUPERSONIC,
                    :NOTEYEP,
                    :NOTEBATH,
                    :NOTEHAIRWRAP,
                    :NOTESURGICALAREA,
                    :NOTECOLONCLEANSE,
                    :NOTEGASTRICLAVAGE,
                    :NOTECATHETERIZATION,
                    :NOTEHANDOVEROFPROPERTY,
                    :NOTECLEARLIPSTICKNAIL,
                    :NOTEIDENTITYPATIENT,
                    :NOTECHANGECLOTHES,
                    :NAMEMEDICINE1,
                    :NAMEMEDICINE2,
                    :NAMEMEDICINE3,
                    :NAMEMEDICINE4,
                    :NAMEMEDICINE5,
                    :FORMATMEDICINE1,
                    :FORMATMEDICINE2,
                    :FORMATMEDICINE3,
                    :FORMATMEDICINE4,
                    :FORMATMEDICINE5,
                    :NUMBERMEDICINE1,
                    :NUMBERMEDICINE2,
                    :NUMBERMEDICINE3,
                    :RNUMBERMEDICINE4,
                    :NUMBERMEDICINE5,
                    :DieuDuongBanGiao,
                    :MaDieuDuongBanGiao,
                    :BacSyGayMe,
                    :MaBacSyGayMe,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (BangKiemTruocKhiMo2.ID != 0)
                {
                    sql = @"UPDATE BangKiemTruocKhiMo2 SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    NgayGioMo= :NgayGioMo,
                    NUMBERPATIENT= :NUMBERPATIENT,
                    NAMEPATIENT= :NAMEPATIENT,
                    AGEPATIENT= :AGEPATIENT,
                    SEXPATIENT= :SEXPATIENT,
                    NUMBERBED= :NUMBERBED,
                    NUMBERROOM=:NUMBERROOM,
                    DIAGNOSE= :DIAGNOSE,
                    EXPLAINPATIENT= :EXPLAINPATIENT,
                    BATHPATIENT= :BATHPATIENT,
                    HAIRWRAP= :HAIRWRAP,
                    SURGICALAREA= :SURGICALAREA,
                    COLONCLEANSE= :COLONCLEANSE,
                    GASTRICLAVAGE= :GASTRICLAVAGE,
                    CATHETERIZATION= :CATHETERIZATION,
                    HANDOVEROFPROPERTY= :HANDOVEROFPROPERTY,
                    CLEARLIPSNAIL= :CLEARLIPSNAIL,
                    IDENTITYPATIENT= :IDENTITYPATIENT,
                    CHANGECLOTHES= :CHANGECLOTHES,
                    BLOODVESSEL= :BLOODVESSEL,
                    BLOODPRESSURE= :BLOODPRESSURE,
                    TEMPERATURE= :TEMPERATURE,
                    BREATHING= :BREATHING,
                    SPECIALISSUE= :SPECIALISSUE,
                    COMMITMENTSURGERY= :COMMITMENTSURGERY,
                    BLOODTESTRESULT= :BLOODTESTRESULT,
                    URINETESTRESULT= :URINETESTRESULT,
                    ECG= :ECG,
                    SUPERSONIC= :SUPERSONIC,
                    NOTEYEP= :NOTEYEP,
                    NOTEBATH= :NOTEBATH,
                    NOTEHAIRWRAP= :NOTEHAIRWRAP,
                    NOTESURGICALAREA= :NOTESURGICALAREA,
                    NOTECOLONCLEANSE= :NOTECOLONCLEANSE,
                    NOTEGASTRICLAVAGE= :NOTEGASTRICLAVAGE,
                    NOTECATHETERIZATION= :NOTECATHETERIZATION,
                    NOTEHANDOVEROFPROPERTY= :NOTEHANDOVEROFPROPERTY,
                    NOTECLEARLIPSTICKNAIL= :NOTECLEARLIPSTICKNAIL,
                    NOTEIDENTITYPATIENT= :NOTEIDENTITYPATIENT,
                    NOTECHANGECLOTHES= :NOTECHANGECLOTHES,
                    NAMEMEDICINE1= :NAMEMEDICINE1,
                    NAMEMEDICINE2= :NAMEMEDICINE2,
                    NAMEMEDICINE3= :NAMEMEDICINE3,
                    NAMEMEDICINE4= :NAMEMEDICINE4,
                    NAMEMEDICINE5= :NAMEMEDICINE5,
                    FORMATMEDICINE1= :FORMATMEDICINE1,
                    FORMATMEDICINE2= :FORMATMEDICINE2,
                    FORMATMEDICINE3= :FORMATMEDICINE3,
                    FORMATMEDICINE4= :FORMATMEDICINE4,
                    FORMATMEDICINE5= :FORMATMEDICINE5,
                    NUMBERMEDICINE1= :NUMBERMEDICINE1,
                    NUMBERMEDICINE2= :NUMBERMEDICINE2,
                    NUMBERMEDICINE3= :NUMBERMEDICINE3,
                    RNUMBERMEDICINE4= :RNUMBERMEDICINE4,
                    NUMBERMEDICINE5= :NUMBERMEDICINE5,
                    DieuDuongBanGiao= :DieuDuongBanGiao,
                    MaDieuDuongBanGiao= :MaDieuDuongBanGiao,
                    BacSyGayMe= :BacSyGayMe,
                    MaBacSyGayMe= :MaBacSyGayMe,
                    NGUOISUA= :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + BangKiemTruocKhiMo2.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", BangKiemTruocKhiMo2.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", BangKiemTruocKhiMo2.MaBenhNhan));
                var Ngay = BangKiemTruocKhiMo2.NgayMo.Date.Add(new TimeSpan(0, 0, 0));
                var Gio = BangKiemTruocKhiMo2.GioMo != null ? BangKiemTruocKhiMo2.GioMo.TimeOfDay : DateTime.Now.TimeOfDay;
                var NgayGioMo = Ngay + Gio;
                Command.Parameters.Add(new MDB.MDBParameter("NgayGioMo", NgayGioMo));
                Command.Parameters.Add(new MDB.MDBParameter("NUMBERPATIENT", BangKiemTruocKhiMo2.NumberPatient));
                Command.Parameters.Add(new MDB.MDBParameter("NAMEPATIENT", BangKiemTruocKhiMo2.NamePatient));
                Command.Parameters.Add(new MDB.MDBParameter("AGEPATIENT", BangKiemTruocKhiMo2.AgePatient));
                Command.Parameters.Add(new MDB.MDBParameter("SEXPATIENT", BangKiemTruocKhiMo2.SexPatient));
                Command.Parameters.Add(new MDB.MDBParameter("NUMBERBED", BangKiemTruocKhiMo2.NumberBed));
                Command.Parameters.Add(new MDB.MDBParameter("NUMBERROOM", BangKiemTruocKhiMo2.NumberRoom));
                Command.Parameters.Add(new MDB.MDBParameter("DIAGNOSE", BangKiemTruocKhiMo2.Diagnose));
                Command.Parameters.Add(new MDB.MDBParameter("EXPLAINPATIENT", BangKiemTruocKhiMo2.YEP));
                Command.Parameters.Add(new MDB.MDBParameter("BATHPATIENT", BangKiemTruocKhiMo2.Bath));
                Command.Parameters.Add(new MDB.MDBParameter("HAIRWRAP", BangKiemTruocKhiMo2.HairWrap));
                Command.Parameters.Add(new MDB.MDBParameter("SURGICALAREA", BangKiemTruocKhiMo2.SurgicalArea));
                Command.Parameters.Add(new MDB.MDBParameter("COLONCLEANSE", BangKiemTruocKhiMo2.ColonCleanse));
                Command.Parameters.Add(new MDB.MDBParameter("GASTRICLAVAGE", BangKiemTruocKhiMo2.GastricLavage));
                Command.Parameters.Add(new MDB.MDBParameter("CATHETERIZATION", BangKiemTruocKhiMo2.Catheterization));
                Command.Parameters.Add(new MDB.MDBParameter("HANDOVEROFPROPERTY", BangKiemTruocKhiMo2.HandoverOfProperty));
                Command.Parameters.Add(new MDB.MDBParameter("CLEARLIPSNAIL", BangKiemTruocKhiMo2.ClearLipstickNail));
                Command.Parameters.Add(new MDB.MDBParameter("IDENTITYPATIENT", BangKiemTruocKhiMo2.IdentityPatient));
                Command.Parameters.Add(new MDB.MDBParameter("CHANGECLOTHES", BangKiemTruocKhiMo2.ChangeClothes));
                Command.Parameters.Add(new MDB.MDBParameter("BLOODVESSEL", BangKiemTruocKhiMo2.BloodVessel));
                Command.Parameters.Add(new MDB.MDBParameter("BLOODPRESSURE", BangKiemTruocKhiMo2.BloodPressure));
                Command.Parameters.Add(new MDB.MDBParameter("TEMPERATURE", BangKiemTruocKhiMo2.Temperature));
                Command.Parameters.Add(new MDB.MDBParameter("BREATHING", BangKiemTruocKhiMo2.Breathing));
                Command.Parameters.Add(new MDB.MDBParameter("SPECIALISSUE", BangKiemTruocKhiMo2.SpecialIssue));
                Command.Parameters.Add(new MDB.MDBParameter("COMMITMENTSURGERY", BangKiemTruocKhiMo2.CommitmentSurgery));
                Command.Parameters.Add(new MDB.MDBParameter("BLOODTESTRESULT", BangKiemTruocKhiMo2.BloodTestResults));
                Command.Parameters.Add(new MDB.MDBParameter("URINETESTRESULT", BangKiemTruocKhiMo2.UrineTestResults));
                Command.Parameters.Add(new MDB.MDBParameter("ECG", BangKiemTruocKhiMo2.ECGResults));
                Command.Parameters.Add(new MDB.MDBParameter("SUPERSONIC", BangKiemTruocKhiMo2.SuperSonicResult));
                Command.Parameters.Add(new MDB.MDBParameter("NOTEYEP", BangKiemTruocKhiMo2.NoteYEP));
                Command.Parameters.Add(new MDB.MDBParameter("NOTEBATH", BangKiemTruocKhiMo2.NoteBATH));
                Command.Parameters.Add(new MDB.MDBParameter("NOTEHAIRWRAP", BangKiemTruocKhiMo2.NoteHAIRWRAP));
                Command.Parameters.Add(new MDB.MDBParameter("NOTESURGICALAREA", BangKiemTruocKhiMo2.NoteSurgicalArea));
                Command.Parameters.Add(new MDB.MDBParameter("NOTECOLONCLEANSE", BangKiemTruocKhiMo2.NoteColonCleanse));
                Command.Parameters.Add(new MDB.MDBParameter("NOTEGASTRICLAVAGE", BangKiemTruocKhiMo2.NoteGastricLavage));
                Command.Parameters.Add(new MDB.MDBParameter("NOTECATHETERIZATION", BangKiemTruocKhiMo2.NoteCatheterization));


                Command.Parameters.Add(new MDB.MDBParameter("NOTEHANDOVEROFPROPERTY", BangKiemTruocKhiMo2.NoteHandoverOfProperty));
                Command.Parameters.Add(new MDB.MDBParameter("NOTECLEARLIPSTICKNAIL", BangKiemTruocKhiMo2.NoteClearLipstickNail));
                Command.Parameters.Add(new MDB.MDBParameter("NOTEIDENTITYPATIENT", BangKiemTruocKhiMo2.NoteIdentityPatient));
                Command.Parameters.Add(new MDB.MDBParameter("NOTECHANGECLOTHES", BangKiemTruocKhiMo2.NoteChangeClothes));
                Command.Parameters.Add(new MDB.MDBParameter("NAMEMEDICINE1", BangKiemTruocKhiMo2.NameMedicine1));
                Command.Parameters.Add(new MDB.MDBParameter("NAMEMEDICINE2", BangKiemTruocKhiMo2.NameMedicine2));
                Command.Parameters.Add(new MDB.MDBParameter("NAMEMEDICINE3", BangKiemTruocKhiMo2.NameMedicine3));
                Command.Parameters.Add(new MDB.MDBParameter("NAMEMEDICINE4", BangKiemTruocKhiMo2.NameMedicine4));
                Command.Parameters.Add(new MDB.MDBParameter("NAMEMEDICINE5", BangKiemTruocKhiMo2.NameMedicine5));
                Command.Parameters.Add(new MDB.MDBParameter("FORMATMEDICINE1", BangKiemTruocKhiMo2.FormatMedicine1));
                Command.Parameters.Add(new MDB.MDBParameter("FORMATMEDICINE2", BangKiemTruocKhiMo2.FormatMedicine2));
                Command.Parameters.Add(new MDB.MDBParameter("FORMATMEDICINE3", BangKiemTruocKhiMo2.FormatMedicine3));
                Command.Parameters.Add(new MDB.MDBParameter("FORMATMEDICINE4", BangKiemTruocKhiMo2.FormatMedicine4));
                Command.Parameters.Add(new MDB.MDBParameter("FORMATMEDICINE5", BangKiemTruocKhiMo2.FormatMedicine5));
                Command.Parameters.Add(new MDB.MDBParameter("NUMBERMEDICINE1", BangKiemTruocKhiMo2.NumberMedicine1));
                Command.Parameters.Add(new MDB.MDBParameter("NUMBERMEDICINE2", BangKiemTruocKhiMo2.NumberMedicine2));
                Command.Parameters.Add(new MDB.MDBParameter("NUMBERMEDICINE3", BangKiemTruocKhiMo2.NumberMedicine3));
                Command.Parameters.Add(new MDB.MDBParameter("RNUMBERMEDICINE4", BangKiemTruocKhiMo2.NumberMedicine4));
                Command.Parameters.Add(new MDB.MDBParameter("NUMBERMEDICINE5", BangKiemTruocKhiMo2.NumberMedicine5));

                Command.Parameters.Add(new MDB.MDBParameter("DieuDuongBanGiao", BangKiemTruocKhiMo2.DieuDuongPhuTrach));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuongBanGiao", BangKiemTruocKhiMo2.MaDieuDuongPhuTrach));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyGayMe", BangKiemTruocKhiMo2.BacSyGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSyGayMe", BangKiemTruocKhiMo2.MaBacSyGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", BangKiemTruocKhiMo2.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", BangKiemTruocKhiMo2.NgaySua));
                if (BangKiemTruocKhiMo2.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", BangKiemTruocKhiMo2.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", BangKiemTruocKhiMo2.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", BangKiemTruocKhiMo2.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (BangKiemTruocKhiMo2.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    BangKiemTruocKhiMo2.ID = nextval;
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
                string sql = "DELETE FROM BangKiemTruocKhiMo2 WHERE ID = :ID";
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
                B.*,
                T.MABENHAN,
	            H.TENBENHNHAN,
                H.TUOI
            FROM
                BangKiemTruocKhiMo2 B
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
