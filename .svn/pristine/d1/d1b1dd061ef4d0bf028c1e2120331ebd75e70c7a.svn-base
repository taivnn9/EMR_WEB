
using EMR.KyDienTu;
using System;
using System.Data;
using PMS.Access; 

namespace EMR_MAIN.DATABASE.Other
{
    public class ThangDiemDotQuyNIHSSCls : ThongTinKy
    {
        public ThangDiemDotQuyNIHSSCls()
        {
            TableName = "ThangDiemDotQuyNIHSS";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.TDDQNIHSS;
            TenMauPhieu = DanhMucPhieu.TDDQNIHSS.Description();
        }

        [MoTaDuLieu("Mã định danh")]
		public long IDPhieu { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChuanDoan { get; set; }
        public string TD1a { get; set; }
        public string TD1b { get; set; }
        public string TD1c { get; set; }
        public string TD2 { get; set; }
        public string TD3 { get; set; }
        public string TD4 { get; set; }
        public string TD5a { get; set; }
        public string TD5b { get; set; }
        public string TD5_GhiChu { get; set; }
        public string TD6a { get; set; }
        public string TD6b { get; set; }
        public string TD6_GhiChu { get; set; }
        public string TD7 { get; set; }
        public string TD8 { get; set; }
        public string TD9 { get; set; }
        public string TD10 { get; set; }
        public string TD10_GhiChu { get; set; }
        public string TD11 { get; set; }
        public string TongDiem { get; set; }
        public bool RoiLoan_Co { get; set; }
        public bool RoiLoan_Khong { get; set; }
        public bool CTM { get; set; }
        public bool CTP { get; set; }
        public bool DuongMau { get; set; }
        public bool CKMP { get; set; }
        public bool PTINR { get; set; }
        public bool Urea { get; set; }
        public bool Triglycerides { get; set; }
        public bool HbA1C { get; set; }
        public bool TroponinI { get; set; }
        public bool aPTT { get; set; }
        public bool Creatinine { get; set; }
        public bool LDLCho { get; set; }
        public bool LDH { get; set; }
        public bool SGOT { get; set; }
        public bool HDLCho { get; set; }
        public bool CRP { get; set; }
        public bool TSH { get; set; }
        public bool SGPT { get; set; }
        public bool NaKCl { get; set; }
        public bool ProBNP { get; set; }
        public bool Albumine { get; set; }
        public bool MauLang { get; set; }
        public bool Fibrinogen { get; set; }
        public bool CA199 { get; set; }
        public bool DDimer { get; set; }
        public bool ProteinTP { get; set; }
        public bool ANA { get; set; }
        public bool AntithrombinIII { get; set; }
        public bool CA1513 { get; set; }
        public bool Cetone { get; set; }
        public bool Calcium { get; set; }
        public bool LECell { get; set; }
        public bool YeuTo4Leiden { get; set; }
        public bool Cyfra211 { get; set; }
        public bool NH3 { get; set; }
        public bool Magne { get; set; }
        public bool AntidsDNA { get; set; }
        public bool Antiphospho { get; set; }
        public bool CA724 { get; set; }
        public bool KhiMauDm { get; set; }
        public bool Phospho { get; set; }
        public bool RF { get; set; }
        public bool ProteinS { get; set; }
        public bool CEA { get; set; }
        public bool Procalcitonin { get; set; }
        public bool AcidUric { get; set; }
        public bool VDRL { get; set; }
        public bool ProteinC { get; set; }
        public bool AFP { get; set; }
        public bool TPTTGT { get; set; }
        public bool HIVTestNhanh { get; set; }
        public bool Homocystein { get; set; }
        public bool CA125 { get; set; }
        public bool TPTNT { get; set; }
        public string CLSDotQuy_Khac { get; set; }
        public string CLSDotQuy_TC { get; set; }
        public bool ECG { get; set; }
        public bool SieuAmTim { get; set; }
        public bool SieuAmTimQua { get; set; }
        public bool CTSoNao { get; set; }
        public bool MRISoNao { get; set; }
        public bool XQNgucThang { get; set; }
        public bool SieuAmDM { get; set; }
        public bool TQ { get; set; }
        public bool CTA { get; set; }
        public bool SieuAmBung { get; set; }
        public bool CanhSongTN { get; set; }
        public bool HolterECG { get; set; }
        public bool DSA { get; set; }
        public string HAH_Khac { get; set; }
        public string HAH_TC { get; set; }
        public bool FT4 { get; set; }
        public string MaBacSyDanhGiaXetNghiem { get; set; }
        public string TenBacSyDanhGiaXetNghiem { get; set; }
        public string MaBacSyDanhGiaRoiLoan { get; set; }
        public string TenBacSyDanhGiaRoiLoan { get; set; }
        public string MaBacSyDanhGiaThangDiem { get; set; }
        public string TenBacSyDanhGiaThangDiem { get; set; }
        public DateTime NgayDanhGia { get; set; }
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
    public class ThangDiemDotQuyNIHSSFunc
    {
        public const string TableName = "ThangDiemDotQuyNIHSS";
        public const string TablePrimaryKeyName = "IDPhieu";
        public static bool DeleteByIDPhieu(MDB.MDBConnection oracleConnection, decimal IDBienBan)
        {
            try
            {
                string sql = "";
                MDB.MDBCommand oracleCommand;
                sql = @"DELETE FROM ThangDiemDotQuyNIHSS WHERE IDPhieu =" + IDBienBan;
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
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, string IDBienBan)
        {
            string sql = @"SELECT P.*, T.SoNhapVien, T.Khoa , T.NgayVaoVien ,  T.MaKhoa, T.MaBenhAn, T.Giuong, T.Buong,            
				H.TUOI,H.SoYTe, H.BENHVIEN, 
				 H.GIOITINH,  H.TenBenhNhan, H.maBenhNhan
			  FROM ThangDiemDotQuyNIHSS P 
				Left JOIN THONGTINDIEUTRI T ON P.MAQUANLY = T.MAQUANLY
				Left JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
			  where IDPhieu = :IDPhieu";
            MDB.MDBCommand Command;
            MDB.MDBDataAdapter adt;
            using (Command = new MDB.MDBCommand(sql, MyConnection))
            {
                Command.Parameters.Add(new MDB.MDBParameter("IDPhieu", IDBienBan));
                adt = new MDB.MDBDataAdapter(Command);
            }
            var ds = new DataSet();
            adt.Fill(ds, "TBL");
            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection oracleConnection, ThangDiemDotQuyNIHSSCls obj, ref bool isUpdate)
        {
            try
            {
                string sql = @"SELECT COUNT(*) RECNUM FROM ThangDiemDotQuyNIHSS WHERE IDPhieu = :IDPhieu";
                MDB.MDBCommand oracleCommand;
                int rowCount = 0;
                int nRecord = 0;
                long sequence_nextval = 0;
                using (oracleCommand = new MDB.MDBCommand(sql, oracleConnection))
                {
                    oracleCommand.Parameters.Add("IDPhieu", obj.IDPhieu);
                    MDB.MDBDataReader oracleDataReader = oracleCommand.ExecuteReader();
                    while (oracleDataReader.Read())
                    {
                        rowCount = int.Parse(oracleDataReader["RECNUM"].ToString());
                    }
                }


                if (rowCount > 0)
                {
                    isUpdate = true;
                    sequence_nextval = obj.IDPhieu;
                    sql = "update ThangDiemDotQuyNIHSS set MaQuanLy= :MaQuanLy,MaBenhNhan= :MaBenhNhan,TenBenhNhan= :TenBenhNhan,ChuanDoan= :ChuanDoan,TD1a= :TD1a,TD1b= :TD1b,TD1c= :TD1c,TD2= :TD2,TD3= :TD3,TD4= :TD4,TD5a= :TD5a,TD5b= :TD5b,TD5_GhiChu= :TD5_GhiChu,TD6a= :TD6a,TD6b= :TD6b,TD6_GhiChu= :TD6_GhiChu,TD7= :TD7,TD8= :TD8,TD9= :TD9,TD10= :TD10,TD10_GhiChu= :TD10_GhiChu,TD11= :TD11,TongDiem= :TongDiem,RoiLoan_Co= :RoiLoan_Co,RoiLoan_Khong= :RoiLoan_Khong,CTM= :CTM,CTP= :CTP,DuongMau= :DuongMau,CKMP= :CKMP,PTINR= :PTINR,Urea= :Urea,Triglycerides= :Triglycerides,HbA1C= :HbA1C,TroponinI= :TroponinI,aPTT= :aPTT,Creatinine= :Creatinine,LDLCho= :LDLCho,LDH= :LDH,SGOT= :SGOT,HDLCho= :HDLCho,CRP= :CRP,TSH= :TSH,SGPT= :SGPT,NaKCl= :NaKCl,ProBNP= :ProBNP,Albumine= :Albumine,MauLang= :MauLang,Fibrinogen= :Fibrinogen,CA199= :CA199,DDimer= :DDimer,ProteinTP= :ProteinTP,ANA= :ANA,AntithrombinIII= :AntithrombinIII,CA1513= :CA1513,Cetone= :Cetone,Calcium= :Calcium,LECell= :LECell,YeuTo4Leiden= :YeuTo4Leiden,Cyfra211= :Cyfra211,NH3= :NH3,Magne= :Magne,AntidsDNA= :AntidsDNA,Antiphospho= :Antiphospho,CA724= :CA724,KhiMauDm= :KhiMauDm,Phospho= :Phospho,RF= :RF,ProteinS= :ProteinS,CEA= :CEA,Procalcitonin= :Procalcitonin,AcidUric= :AcidUric,VDRL= :VDRL,ProteinC= :ProteinC,AFP= :AFP,TPTTGT= :TPTTGT,HIVTestNhanh= :HIVTestNhanh,Homocystein= :Homocystein,CA125= :CA125,TPTNT= :TPTNT,CLSDotQuy_Khac= :CLSDotQuy_Khac,CLSDotQuy_TC= :CLSDotQuy_TC,ECG= :ECG,SieuAmTim= :SieuAmTim,SieuAmTimQua= :SieuAmTimQua,CTSoNao= :CTSoNao,MRISoNao= :MRISoNao,XQNgucThang= :XQNgucThang,SieuAmDM= :SieuAmDM,TQ= :TQ,CTA= :CTA,SieuAmBung= :SieuAmBung,CanhSongTN= :CanhSongTN,HolterECG= :HolterECG,DSA= :DSA,HAH_Khac= :HAH_Khac,HAH_TC= :HAH_TC,MaBacSyDanhGiaXetNghiem= :MaBacSyDanhGiaXetNghiem,TenBacSyDanhGiaXetNghiem= :TenBacSyDanhGiaXetNghiem,MaBacSyDanhGiaRoiLoan= :MaBacSyDanhGiaRoiLoan,TenBacSyDanhGiaRoiLoan= :TenBacSyDanhGiaRoiLoan,MaBacSyDanhGiaThangDiem= :MaBacSyDanhGiaThangDiem, TenBacSyDanhGiaThangDiem= :TenBacSyDanhGiaThangDiem, FT4= :FT4, NgayDanhGia= :NgayDanhGia,";
                    sql = sql + "NgayTao = :NgayTao,NgaySua = :NgaySua, MaSoKyTen = :MaSoKyTen ";
                    sql = sql + ", NguoiTao = :NguoiTao, NguoiSua = :NguoiSua";
                    sql = sql + " WHERE IDPhieu = " + obj.IDPhieu.ToString();
                }
                else
                {
                    sql = @"select NVL(MAX(IDPhieu),0) AS sequence_nextval from ThangDiemDotQuyNIHSS";
                    using (oracleCommand = new MDB.MDBCommand(sql, oracleConnection))
                    {
                        MDB.MDBDataReader oracleDataReader = oracleCommand.ExecuteReader();
                        while (oracleDataReader.Read())
                        {
                            sequence_nextval = long.Parse(oracleDataReader["sequence_nextval"].ToString()) + 1;
                        }
                    }
                    sql = @"insert into ThangDiemDotQuyNIHSS(IDPhieu,MaQuanLy,MaBenhNhan,TenBenhNhan,ChuanDoan,TD1a,TD1b,TD1c,TD2,TD3,TD4,TD5a,TD5b,TD5_GhiChu,TD6a,TD6b,TD6_GhiChu,TD7,TD8,TD9,TD10,TD10_GhiChu, TD11,TongDiem,RoiLoan_Co,RoiLoan_Khong,CTM,CTP,DuongMau,CKMP,PTINR,Urea,Triglycerides,HbA1C,TroponinI,aPTT,Creatinine,LDLCho,LDH,SGOT,HDLCho,CRP,TSH,SGPT,NaKCl,ProBNP,Albumine,MauLang,Fibrinogen,CA199,DDimer,ProteinTP,ANA,AntithrombinIII,CA1513,Cetone,Calcium,LECell,YeuTo4Leiden,Cyfra211,NH3,Magne,AntidsDNA,Antiphospho,CA724,KhiMauDm,Phospho,RF,ProteinS,CEA,Procalcitonin,AcidUric,VDRL,ProteinC,AFP,TPTTGT,HIVTestNhanh,Homocystein,CA125,TPTNT,CLSDotQuy_Khac,CLSDotQuy_TC,ECG,SieuAmTim,SieuAmTimQua,CTSoNao,MRISoNao,XQNgucThang,SieuAmDM,TQ,CTA,SieuAmBung,CanhSongTN,HolterECG,DSA,HAH_Khac,HAH_TC,MaBacSyDanhGiaXetNghiem,TenBacSyDanhGiaXetNghiem,MaBacSyDanhGiaRoiLoan,TenBacSyDanhGiaRoiLoan,MaBacSyDanhGiaThangDiem, TenBacSyDanhGiaThangDiem, FT4, NgayDanhGia," +
                            "NgayTao,NgaySua," +
                            "MaSoKyTen" +
                            ",NguoiTao, NguoiSua" +
                          ")";
                    sql = sql + @"Values(:IDPhieu,:MaQuanLy, :MaBenhNhan, :TenBenhNhan, :ChuanDoan, :TD1a, :TD1b, :TD1c, :TD2, :TD3, :TD4, :TD5a, :TD5b, :TD5_GhiChu, :TD6a, :TD6b, :TD6_GhiChu, :TD7, :TD8, :TD9, :TD10, :TD10_GhiChu, :TD11, :TongDiem, :RoiLoan_Co, :RoiLoan_Khong, :CTM, :CTP, :DuongMau, :CKMP, :PTINR, :Urea, :Triglycerides, :HbA1C, :TroponinI, :aPTT, :Creatinine, :LDLCho, :LDH, :SGOT, :HDLCho, :CRP, :TSH, :SGPT, :NaKCl, :ProBNP, :Albumine, :MauLang, :Fibrinogen, :CA199, :DDimer, :ProteinTP, :ANA, :AntithrombinIII, :CA1513, :Cetone, :Calcium, :LECell, :YeuTo4Leiden, :Cyfra211, :NH3, :Magne, :AntidsDNA, :Antiphospho, :CA724, :KhiMauDm, :Phospho, :RF, :ProteinS, :CEA, :Procalcitonin, :AcidUric, :VDRL, :ProteinC, :AFP, :TPTTGT, :HIVTestNhanh, :Homocystein, :CA125, :TPTNT, :CLSDotQuy_Khac, :CLSDotQuy_TC, :ECG, :SieuAmTim, :SieuAmTimQua, :CTSoNao, :MRISoNao, :XQNgucThang, :SieuAmDM, :TQ, :CTA, :SieuAmBung, :CanhSongTN, :HolterECG, :DSA, :HAH_Khac, :HAH_TC, :MaBacSyDanhGiaXetNghiem, :TenBacSyDanhGiaXetNghiem, :MaBacSyDanhGiaRoiLoan, :TenBacSyDanhGiaRoiLoan, :MaBacSyDanhGiaThangDiem, :TenBacSyDanhGiaThangDiem, :FT4, :NgayDanhGia, " +
                        ":NgayTao,:NgaySua," +
                        ":MaSoKyTen" +
                        ",:NguoiTao, :NguoiSua" +
                        ")";
                }
                using (oracleCommand = new MDB.MDBCommand(sql, oracleConnection))
                {
                    if (rowCount <= 0)
                    {
                        oracleCommand.Parameters.Add(new MDB.MDBParameter("IDPhieu", sequence_nextval));
                    }

                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaQuanLy", obj.MaQuanLy));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", obj.MaBenhNhan));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TenBenhNhan", obj.TenBenhNhan));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ChuanDoan", obj.ChuanDoan));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TD1a", obj.TD1a));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TD1b", obj.TD1b));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TD1c", obj.TD1c));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TD2", obj.TD2));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TD3", obj.TD3));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TD4", obj.TD4));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TD5a", obj.TD5a));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TD5b", obj.TD5b));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TD5_GhiChu", obj.TD5_GhiChu));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TD6a", obj.TD6a));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TD6b", obj.TD6b));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TD6_GhiChu", obj.TD6_GhiChu));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TD7", obj.TD7));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TD8", obj.TD8));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TD9", obj.TD9));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TD10", obj.TD10));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TD10_GhiChu", obj.TD10_GhiChu));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TD11", obj.TD11));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TongDiem", obj.TongDiem));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("RoiLoan_Co", obj.RoiLoan_Co == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("RoiLoan_Khong", obj.RoiLoan_Khong == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CTM", obj.CTM == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CTP", obj.CTP == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DuongMau", obj.DuongMau == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CKMP", obj.CKMP == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("PTINR", obj.PTINR == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Urea", obj.Urea == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Triglycerides", obj.Triglycerides == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("HbA1C", obj.HbA1C == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TroponinI", obj.TroponinI == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("aPTT", obj.aPTT == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Creatinine", obj.Creatinine == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("LDLCho", obj.LDLCho == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("LDH", obj.LDH == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SGOT", obj.SGOT == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("HDLCho", obj.HDLCho == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CRP", obj.CRP == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TSH", obj.TSH == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SGPT", obj.SGPT == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NaKCl", obj.NaKCl == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ProBNP", obj.ProBNP == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Albumine", obj.Albumine == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MauLang", obj.MauLang == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Fibrinogen", obj.Fibrinogen == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CA199", obj.CA199 == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DDimer", obj.DDimer == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ProteinTP", obj.ProteinTP == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ANA", obj.ANA == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("AntithrombinIII", obj.AntithrombinIII == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CA1513", obj.CA1513 == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Cetone", obj.Cetone == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Calcium", obj.Calcium == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("LECell", obj.LECell == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("YeuTo4Leiden", obj.YeuTo4Leiden == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Cyfra211", obj.Cyfra211 == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NH3", obj.NH3 == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Magne", obj.Magne == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("AntidsDNA", obj.AntidsDNA == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Antiphospho", obj.Antiphospho == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CA724", obj.CA724 == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("KhiMauDm", obj.KhiMauDm == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Phospho", obj.Phospho == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("RF", obj.RF == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ProteinS", obj.ProteinS == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CEA", obj.CEA == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Procalcitonin", obj.Procalcitonin == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("AcidUric", obj.AcidUric == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("VDRL", obj.VDRL == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ProteinC", obj.ProteinC == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("AFP", obj.AFP == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TPTTGT", obj.TPTTGT == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("HIVTestNhanh", obj.HIVTestNhanh == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Homocystein", obj.Homocystein == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CA125", obj.CA125 == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TPTNT", obj.TPTNT == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CLSDotQuy_Khac", obj.CLSDotQuy_Khac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CLSDotQuy_TC", obj.CLSDotQuy_TC));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ECG", obj.ECG == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SieuAmTim", obj.SieuAmTim == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SieuAmTimQua", obj.SieuAmTimQua == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CTSoNao", obj.CTSoNao == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MRISoNao", obj.MRISoNao == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("XQNgucThang", obj.XQNgucThang == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SieuAmDM", obj.SieuAmDM == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TQ", obj.TQ == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CTA", obj.CTA == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SieuAmBung", obj.SieuAmBung == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CanhSongTN", obj.CanhSongTN == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("HolterECG", obj.HolterECG == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DSA", obj.DSA == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("HAH_Khac", obj.HAH_Khac));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("HAH_TC", obj.HAH_TC));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBacSyDanhGiaXetNghiem", obj.MaBacSyDanhGiaXetNghiem));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TenBacSyDanhGiaXetNghiem", obj.TenBacSyDanhGiaXetNghiem));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBacSyDanhGiaRoiLoan", obj.MaBacSyDanhGiaRoiLoan));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TenBacSyDanhGiaRoiLoan", obj.TenBacSyDanhGiaRoiLoan));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBacSyDanhGiaThangDiem", obj.MaBacSyDanhGiaThangDiem));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TenBacSyDanhGiaThangDiem", obj.TenBacSyDanhGiaThangDiem));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("FT4", obj.FT4 == true ? "1" : "0"));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayDanhGia", obj.NgayDanhGia));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayTao", obj.NgayTao));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgaySua", obj.NgaySua));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiTao", obj.NguoiTao));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiSua", obj.NguoiSua));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaSoKyTen", obj.MaSoKy));
                    nRecord = oracleCommand.ExecuteNonQuery();
                }
                if (nRecord > 0)
                {
                    obj.IDPhieu = sequence_nextval;
                }
                return nRecord > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.LogError(ex);
            }
            return false;
        }
        public static int countPhieu(MDB.MDBConnection oracleConnection, string MaQuanLy)
        {
            int count = 0;
            string sql = @"SELECT COUNT(IDPhieu) FROM ThangDiemDotQuyNIHSS WHERE MAQUANLY = :MaQuanLy";
            MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
            oracleCommand.Parameters.Add("MaQuanLy", MaQuanLy);
            oracleCommand.BindByName = true;
            MDB.MDBDataReader DataReader = oracleCommand.ExecuteReader();
            while (DataReader.Read())
            {
                int temp = 0;
                int.TryParse(DataReader["COUNT(IDPhieu)"].ToString(), out temp);
                count = temp;
                break;
            }
            return count;
        }
        public static ThangDiemDotQuyNIHSSCls GetData(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            ThangDiemDotQuyNIHSSCls obj = new ThangDiemDotQuyNIHSSCls();
            string sql = @"select * from ThangDiemDotQuyNIHSS WHERE MaQuanLy = :MaQuanLy ";
            sql += " ORDER BY NgayTao, NgaySua asc";
            MDB.MDBCommand Command;
            using (Command = new MDB.MDBCommand(sql, MyConnection))
            {
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    obj.IDPhieu = long.Parse(DataReader["IDPhieu"].ToString());
                    obj.MaQuanLy = decimal.Parse(DataReader["MaQuanLy"].ToString());
                    obj.MaBenhNhan = ConDBNull(DataReader["MaBenhNhan"]);
                    obj.TenBenhNhan = ConDBNull(DataReader["TenBenhNhan"]);
                    obj.ChuanDoan = ConDBNull(DataReader["ChuanDoan"]);
                    obj.TD1a = ConDBNull(DataReader["TD1a"]);
                    obj.TD1b = ConDBNull(DataReader["TD1b"]);
                    obj.TD1c = ConDBNull(DataReader["TD1c"]);
                    obj.TD2 = ConDBNull(DataReader["TD2"]);
                    obj.TD3 = ConDBNull(DataReader["TD3"]);
                    obj.TD4 = ConDBNull(DataReader["TD4"]);
                    obj.TD5a = ConDBNull(DataReader["TD5a"]);
                    obj.TD5b = ConDBNull(DataReader["TD5b"]);
                    obj.TD5_GhiChu = ConDBNull(DataReader["TD5_GhiChu"]);
                    obj.TD6a = ConDBNull(DataReader["TD6a"]);
                    obj.TD6b = ConDBNull(DataReader["TD6b"]);
                    obj.TD6_GhiChu = ConDBNull(DataReader["TD6_GhiChu"]);
                    obj.TD7 = ConDBNull(DataReader["TD7"]);
                    obj.TD8 = ConDBNull(DataReader["TD8"]);
                    obj.TD9 = ConDBNull(DataReader["TD9"]);
                    obj.TD10 = ConDBNull(DataReader["TD10"]);
                     obj.TD10_GhiChu = ConDBNull(DataReader["TD10_GhiChu"]);
                    obj.TD11 = ConDBNull(DataReader["TD11"]);
                    obj.TongDiem = ConDBNull(DataReader["TongDiem"]);
                    obj.RoiLoan_Co = DataReader["RoiLoan_Co"].ToString() == "1" ? true : false;
                    obj.RoiLoan_Khong = DataReader["RoiLoan_Khong"].ToString() == "1" ? true : false;
                    obj.CTM = DataReader["CTM"].ToString() == "1" ? true : false;
                    obj.CTP = DataReader["CTP"].ToString() == "1" ? true : false;
                    obj.DuongMau = DataReader["DuongMau"].ToString() == "1" ? true : false;
                    obj.CKMP = DataReader["CKMP"].ToString() == "1" ? true : false;
                    obj.PTINR = DataReader["PTINR"].ToString() == "1" ? true : false;
                    obj.Urea = DataReader["Urea"].ToString() == "1" ? true : false;
                    obj.Triglycerides = DataReader["Triglycerides"].ToString() == "1" ? true : false;
                    obj.HbA1C = DataReader["HbA1C"].ToString() == "1" ? true : false;
                    obj.TroponinI = DataReader["TroponinI"].ToString() == "1" ? true : false;
                    obj.aPTT = DataReader["aPTT"].ToString() == "1" ? true : false;
                    obj.Creatinine = DataReader["Creatinine"].ToString() == "1" ? true : false;
                    obj.LDLCho = DataReader["LDLCho"].ToString() == "1" ? true : false;
                    obj.LDH = DataReader["LDH"].ToString() == "1" ? true : false;
                    obj.SGOT = DataReader["SGOT"].ToString() == "1" ? true : false;
                    obj.HDLCho = DataReader["HDLCho"].ToString() == "1" ? true : false;
                    obj.CRP = DataReader["CRP"].ToString() == "1" ? true : false;
                    obj.TSH = DataReader["TSH"].ToString() == "1" ? true : false;
                    obj.SGPT = DataReader["SGPT"].ToString() == "1" ? true : false;
                    obj.NaKCl = DataReader["NaKCl"].ToString() == "1" ? true : false;
                    obj.ProBNP = DataReader["ProBNP"].ToString() == "1" ? true : false;
                    obj.Albumine = DataReader["Albumine"].ToString() == "1" ? true : false;
                    obj.MauLang = DataReader["MauLang"].ToString() == "1" ? true : false;
                    obj.Fibrinogen = DataReader["Fibrinogen"].ToString() == "1" ? true : false;
                    obj.CA199 = DataReader["CA199"].ToString() == "1" ? true : false;
                    obj.DDimer = DataReader["DDimer"].ToString() == "1" ? true : false;
                    obj.ProteinTP = DataReader["ProteinTP"].ToString() == "1" ? true : false;
                    obj.ANA = DataReader["ANA"].ToString() == "1" ? true : false;
                    obj.AntithrombinIII = DataReader["AntithrombinIII"].ToString() == "1" ? true : false;
                    obj.CA1513 = DataReader["CA1513"].ToString() == "1" ? true : false;
                    obj.Cetone = DataReader["Cetone"].ToString() == "1" ? true : false;
                    obj.Calcium = DataReader["Calcium"].ToString() == "1" ? true : false;
                    obj.LECell = DataReader["LECell"].ToString() == "1" ? true : false;
                    obj.YeuTo4Leiden = DataReader["YeuTo4Leiden"].ToString() == "1" ? true : false;
                    obj.Cyfra211 = DataReader["Cyfra211"].ToString() == "1" ? true : false;
                    obj.NH3 = DataReader["NH3"].ToString() == "1" ? true : false;
                    obj.Magne = DataReader["Magne"].ToString() == "1" ? true : false;
                    obj.AntidsDNA = DataReader["AntidsDNA"].ToString() == "1" ? true : false;
                    obj.Antiphospho = DataReader["Antiphospho"].ToString() == "1" ? true : false;
                    obj.CA724 = DataReader["CA724"].ToString() == "1" ? true : false;
                    obj.KhiMauDm = DataReader["KhiMauDm"].ToString() == "1" ? true : false;
                    obj.Phospho = DataReader["Phospho"].ToString() == "1" ? true : false;
                    obj.RF = DataReader["RF"].ToString() == "1" ? true : false;
                    obj.ProteinS = DataReader["ProteinS"].ToString() == "1" ? true : false;
                    obj.CEA = DataReader["CEA"].ToString() == "1" ? true : false;
                    obj.Procalcitonin = DataReader["Procalcitonin"].ToString() == "1" ? true : false;
                    obj.AcidUric = DataReader["AcidUric"].ToString() == "1" ? true : false;
                    obj.VDRL = DataReader["VDRL"].ToString() == "1" ? true : false;
                    obj.ProteinC = DataReader["ProteinC"].ToString() == "1" ? true : false;
                    obj.AFP = DataReader["AFP"].ToString() == "1" ? true : false;
                    obj.TPTTGT = DataReader["TPTTGT"].ToString() == "1" ? true : false;
                    obj.HIVTestNhanh = DataReader["HIVTestNhanh"].ToString() == "1" ? true : false;
                    obj.Homocystein = DataReader["Homocystein"].ToString() == "1" ? true : false;
                    obj.CA125 = DataReader["CA125"].ToString() == "1" ? true : false;
                    obj.TPTNT = DataReader["TPTNT"].ToString() == "1" ? true : false;
                    obj.CLSDotQuy_Khac = ConDBNull(DataReader["CLSDotQuy_Khac"]);
                    obj.CLSDotQuy_TC = ConDBNull(DataReader["CLSDotQuy_TC"]);
                    obj.ECG = DataReader["ECG"].ToString() == "1" ? true : false;
                    obj.SieuAmTim = DataReader["SieuAmTim"].ToString() == "1" ? true : false;
                    obj.SieuAmTimQua = DataReader["SieuAmTimQua"].ToString() == "1" ? true : false;
                    obj.CTSoNao = DataReader["CTSoNao"].ToString() == "1" ? true : false;
                    obj.MRISoNao = DataReader["MRISoNao"].ToString() == "1" ? true : false;
                    obj.XQNgucThang = DataReader["XQNgucThang"].ToString() == "1" ? true : false;
                    obj.SieuAmDM = DataReader["SieuAmDM"].ToString() == "1" ? true : false;
                    obj.TQ = DataReader["TQ"].ToString() == "1" ? true : false;
                    obj.CTA = DataReader["CTA"].ToString() == "1" ? true : false;
                    obj.SieuAmBung = DataReader["SieuAmBung"].ToString() == "1" ? true : false;
                    obj.CanhSongTN = DataReader["CanhSongTN"].ToString() == "1" ? true : false;
                    obj.HolterECG = DataReader["HolterECG"].ToString() == "1" ? true : false;
                    obj.DSA = DataReader["DSA"].ToString() == "1" ? true : false;
                    obj.HAH_Khac = ConDBNull(DataReader["HAH_Khac"]);
                    obj.HAH_TC = ConDBNull(DataReader["HAH_TC"]);
                    obj.FT4 = DataReader["FT4"].ToString() == "1" ? true : false;
                    obj.MaBacSyDanhGiaXetNghiem = ConDBNull(DataReader["MaBacSyDanhGiaXetNghiem"]);
                    obj.TenBacSyDanhGiaXetNghiem = ConDBNull(DataReader["TenBacSyDanhGiaXetNghiem"]);
                    obj.MaBacSyDanhGiaRoiLoan = ConDBNull(DataReader["MaBacSyDanhGiaRoiLoan"]);
                    obj.TenBacSyDanhGiaRoiLoan = ConDBNull(DataReader["TenBacSyDanhGiaRoiLoan"]);
                    obj.MaBacSyDanhGiaThangDiem = ConDBNull(DataReader["MaBacSyDanhGiaThangDiem"]);
                    obj.TenBacSyDanhGiaThangDiem = ConDBNull(DataReader["TenBacSyDanhGiaThangDiem"]);
                    obj.FT4 = DataReader["FT4"].ToString() == "1" ? true : false;
                    obj.NgayDanhGia = ConDB_DateTime(DataReader["NgayDanhGia"]);
                    obj.NgayTao = ConDB_DateTime(DataReader["NGAYTAO"]);
                    obj.NgaySua = ConDB_DateTime(DataReader["NGAYSUA"]);
                    obj.NguoiTao = ConDBNull(DataReader["NGUOITAO"]);
                    obj.NguoiSua = ConDBNull(DataReader["NGUOISUA"]);
                    obj.MaSoKy = ConDBNull(DataReader["MASOKYTEN"]);
                    obj.DaKy = !string.IsNullOrEmpty(ConDBNull(DataReader["masokyten"])) ? true : false;
                    obj.Chon = false;
                }
            }
            return obj;
        }
        public static string ConDBNull(object dbVal)
        {
            string ret = "";
            if (dbVal == null)
            {
                return ret;
            }
            ret = dbVal.ToString();
            return ret;
        }
        public static decimal ConDB_Decimal(object dbVal, decimal valDefault = 0)
        {
            decimal ret = valDefault;
            if (dbVal == null)
            {
                return ret;
            }
            bool isSuccess = decimal.TryParse(dbVal.ToString(), out ret);
            if (!isSuccess)
            {
                return valDefault;
            }
            return ret;
        }
        public static int ConDB_Int(object dbVal, int valDefault = 0)
        {
            int ret = valDefault;
            if (dbVal == null)
            {
                return ret;
            }
            bool isSuccess = int.TryParse(dbVal.ToString(), out ret);
            if (!isSuccess)
            {
                return valDefault;
            }
            return ret;
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
