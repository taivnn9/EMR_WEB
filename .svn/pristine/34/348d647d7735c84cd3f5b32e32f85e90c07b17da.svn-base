
using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;

namespace EMR_MAIN.DATABASE.Other
{
    public class SoKetBenhAnDuyetMo : ThongTinKy
    {
        public SoKetBenhAnDuyetMo()
        {
            TableName = "SOKETBENHANDUYETMO";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.SKBADM;
            TenMauPhieu = DanhMucPhieu.SKBADM.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        public DateTime ThoiGianTao { get; set; }
        public DateTime? ThoiGianSua { get; set; }
        [MoTaDuLieu("Bệnh viện")]
		public string BenhVien { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        public string MaSo { get; set; }
        [MoTaDuLieu("Mã bệnh án")]
		public string MaBenhAn { get; set; }
        public string HoTen { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        [MoTaDuLieu("Buồng")]
		public string Buong { get; set; }
        [MoTaDuLieu("Giường")]
		public string Giuong { get; set; }
        public string VaoVien_Gio { get; set; }
        public string VaoVien_Phut { get; set; }
        public string VaoVien_Ngay { get; set; }
        public string VaoVien_Thang { get; set; }
        public string VaoVien_Nam { get; set; }
        public string LyDoVaoVien { get; set; }
        public string TrieuChungLamSang { get; set; }
        public string CongThucMau_HongCau { get; set; }
        public string CongThucMau_BachCau { get; set; }
        public string CongThucMau_N { get; set; }
        public string CongThucMau_L { get; set; }
        [MoTaDuLieu("Nhóm máu")]
		public string NhomMau { get; set; }
        public string ThoiGianMauChay { get; set; }
        public string ThoiGianMauDong { get; set; }
        public string HuyetSacTo { get; set; }
        [MoTaDuLieu("Nước tiểu hồng cầu")]
		public string NuocTieu_HongCau { get; set; }
        [MoTaDuLieu("Nước tiểu bạch cầu")]
		public string NuocTieu_BachCau { get; set; }
        [MoTaDuLieu("Nước tiểu protein")]
		public string NuocTieu_Protein { get; set; }
        [MoTaDuLieu("Nước tiểu trực niệu")]
		public string NuocTieu_TrucNieu { get; set; }
        [MoTaDuLieu("Nước tiểu dương niệu")]
		public string NuocTieu_DuongNieu { get; set; }
        [MoTaDuLieu("Nước tiểu sắc tố")]
		public string NuocTieu_SacToMat { get; set; }
        public string SinhHoa_Ure { get; set; }
        public string SinhHoa_Creatimin { get; set; }
        public string SinhHoa_Glucose { get; set; }
        public string SinhHoa_BulirubinTP { get; set; }
        public string SinhHoa_BulirubinTT { get; set; }
        public string SinhHoa_BulirubinGT { get; set; }
        public string SinhHoa_ProteinTP { get; set; }
        public string SinhHoa_Albumin { get; set; }
        public string SinhHoa_GOT { get; set; }
        public string SinhHoa_GPT { get; set; }
        public string DongMau_PT { get; set; }
        public string DongMau_APTT { get; set; }
        public string DongMau_Fibrinogen { get; set; }
        [MoTaDuLieu("HIV")]
		public string HIV { get; set; }
        public string HbsAg { get; set; }
        public string HCV { get; set; }
        public string Xquang { get; set; }
        public string SieuAm { get; set; }
        public string DienTim { get; set; }
        public string XetNghiemKhac { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public string PhuongPhapPhauThuat { get; set; }
        public string PhuongPhapVoCam { get; set; }
        public string PhauThuatVien { get; set; }
        public string PhauThuat_Gio { get; set; }
        public string PhauThuat_Phut { get; set; }
        public string PhauThuat_Ngay { get; set; }
        public string PhauThuat_Thang { get; set; }
        public string PhauThuat_Nam { get; set; }
        public string DuTruMauKhiMo { get; set; }
        public string DuyetLanhDao { get; set; }
        public string BacSiGayMe { get; set; }
        public string BacSiTimMach { get; set; }
        public string TruongPhongKh { get; set; }
        [MoTaDuLieu("Trưởng khoa")]
		public string TruongKhoa { get; set; }
        [MoTaDuLieu("Bác sỹ điều trị")]
		public string BacSiDieuTri { get; set; }
        public string MaNVPhauThuatVien { get; set; }
        public string MaNVBacSiGayMe { get; set; }
        public string MaNVBacSiTimMach { get; set; }
        [MoTaDuLieu("Mã bác sỹ điều trị")]
		public string MaNVBacSiDieuTri { get; set; }
        [MoTaDuLieu("Mã trưởng khoa")]
		public string MaNVTruongKhoa { get; set; }
        public string MaNVTruongPhongKh { get; set; }
        public string MaNVDuyetLanhDao { get; set; }

        //public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }

        /// <summary>
        /// 09/06/2021 Add by Hòa Issues 64961 tạo class để lấy dữ liệu cột Map Tag bên SoKetBenhAnMo truyền idxetnghiemqua
        /// </summary>

        public string TagCongThucMau_HongCau { get; set; }
        public string TagCongThucMau_BachCau { get; set; }
        public string TagCongThucMau_N { get; set; }
        public string TagCongThucMau_L { get; set; }
        public string TagNhomMau { get; set; }
        public string TagHuyetSacTo { get; set; }
        public string TagNuocTieu_HongCau { get; set; }
        public string TagNuocTieu_BachCau { get; set; }
        public string TagNuocTieu_Protein { get; set; }
        public string TagNuocTieu_TrucNieu { get; set; }
        public string TagNuocTieu_DuongNieu { get; set; }
        public string TagNuocTieu_SacToMat { get; set; }
        public string TagSinhHoa_Ure { get; set; }
        public string TagSinhHoa_Creatimin { get; set; }
        public string TagSinhHoa_Glucose { get; set; }
        public string TagSinhHoa_BulirubinTP { get; set; }
        public string TagSinhHoa_BulirubinTT { get; set; }
        public string TagSinhHoa_BulirubinGT { get; set; }
        public string TagSinhHoa_ProteinTP { get; set; }
        public string TagSinhHoa_Albumin { get; set; }
        public string TagSinhHoa_GOT { get; set; }
        public string TagSinhHoa_GPT { get; set; }
        public string TagDongMau_PT { get; set; }
        public string TagDongMau_APTT { get; set; }
        public string TagDongMau_Fibrinogen { get; set; }
        public string TagHIV { get; set; }
        public string TagHbsAg { get; set; }
        public string TagHCV { get; set; }
        public string TagXquang { get; set; }
        public string TagSieuAm { get; set; }
        public string TagDienTim { get; set; }
        public string TagXetNghiemKhac { get; set; }
    }
    public class SoKetBenhAnDuyetMoFunc
    {
        public const string TableName = "SOKETBENHANDUYETMO";
        public const string TablePrimaryKeyName = "ID";

        public static long InsertOrUpdate(MDB.MDBConnection _OracleConnection, SoKetBenhAnDuyetMo _SoKetBenhAnDuyetMo)
        {
            try
            {
                string sql = "";
                // Xử lý map xét nghiệm EMR và HIS , dùng các cột cls khai báo sẵn để Map
                //08/06/2021 Add by Hòa Issues 64961
                {
                    string sqlIdXetnghiem = @"SELECT * FROM MapIdxetnghiem WHERE ID = :ID";
                    //MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                    int rowCountId = 0;
                    int nId = 0;
                    if (_SoKetBenhAnDuyetMo.TagCongThucMau_HongCau.IsNotNullOrEmpty())
                    {
                        MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                        CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)EMR_MAIN.CLS_PTTT.CongThucMauHongCau));
                        MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                        rowCountId = 0;
                        while (DataReaderIdxetnghiem.Read()) rowCountId++;
                        if (rowCountId == 0)
                        {
                            sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, IDLOAI) VALUES(" + (int)EMR_MAIN.CLS_PTTT.CongThucMauHongCau + "," + _SoKetBenhAnDuyetMo.TagCongThucMau_HongCau.ToInt32() + ", 0)";
                            CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                            nId = CommandIDxetnghiem.ExecuteNonQuery();
                        }
                    }
                    if (_SoKetBenhAnDuyetMo.TagCongThucMau_BachCau.IsNotNullOrEmpty())
                    {
                        MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                        CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)EMR_MAIN.CLS_PTTT.CongThucMauBachcau));
                        MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                        rowCountId = 0;
                        while (DataReaderIdxetnghiem.Read()) rowCountId++;
                        if (rowCountId == 0)
                        {
                            sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, IDLOAI) VALUES(" + (int)EMR_MAIN.CLS_PTTT.CongThucMauBachcau + "," + _SoKetBenhAnDuyetMo.TagCongThucMau_BachCau.ToInt32() + ", 0)";
                            CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                            nId = CommandIDxetnghiem.ExecuteNonQuery();
                        }
                    }
                    if (_SoKetBenhAnDuyetMo.TagCongThucMau_N.IsNotNullOrEmpty())
                    {
                        MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                        CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)EMR_MAIN.CLS_PTTT.CongThucMauN));
                        MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                        rowCountId = 0;
                        while (DataReaderIdxetnghiem.Read()) rowCountId++;
                        if (rowCountId == 0)
                        {
                            sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, IDLOAI) VALUES(" + (int)EMR_MAIN.CLS_PTTT.CongThucMauN + "," + _SoKetBenhAnDuyetMo.TagCongThucMau_N.ToInt32() + ", 0)";
                            CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                            nId = CommandIDxetnghiem.ExecuteNonQuery();
                        }

                    }
                    if (_SoKetBenhAnDuyetMo.TagCongThucMau_L.IsNotNullOrEmpty())
                    {
                        MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                        CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)EMR_MAIN.CLS_PTTT.CongThucMauL));
                        MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                        rowCountId = 0;
                        while (DataReaderIdxetnghiem.Read()) rowCountId++;
                        if (rowCountId == 0)
                        {
                            sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, IDLOAI) VALUES(" + (int)EMR_MAIN.CLS_PTTT.CongThucMauL + "," + _SoKetBenhAnDuyetMo.TagCongThucMau_L.ToInt32() + ", 0)";
                            CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                            nId = CommandIDxetnghiem.ExecuteNonQuery();
                        }

                    }
                    if (_SoKetBenhAnDuyetMo.TagNhomMau.IsNotNullOrEmpty())
                    {
                        MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                        CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)EMR_MAIN.CLS_PTTT.NhomMau));
                        MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                        rowCountId = 0;
                        while (DataReaderIdxetnghiem.Read()) rowCountId++;
                        if (rowCountId == 0)
                        {
                            sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, IDLOAI) VALUES(" + (int)EMR_MAIN.CLS_PTTT.NhomMau + "," + _SoKetBenhAnDuyetMo.TagNhomMau.ToInt32() + ", 0)";
                            CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                            nId = CommandIDxetnghiem.ExecuteNonQuery();
                        }
                    }
                    if (_SoKetBenhAnDuyetMo.TagHuyetSacTo.IsNotNullOrEmpty())
                    {
                        MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                        CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)EMR_MAIN.CLS_PTTT.HuyetSacTo));
                        MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                        rowCountId = 0;
                        while (DataReaderIdxetnghiem.Read()) rowCountId++;
                        if (rowCountId == 0)
                        {
                            sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, IDLOAI) VALUES(" + (int)EMR_MAIN.CLS_PTTT.HuyetSacTo + "," + _SoKetBenhAnDuyetMo.TagHuyetSacTo.ToInt32() + ", 0)";
                            CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                            nId = CommandIDxetnghiem.ExecuteNonQuery();
                        }
                    }
                    if (_SoKetBenhAnDuyetMo.TagNuocTieu_HongCau.IsNotNullOrEmpty())
                    {
                        MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                        CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)EMR_MAIN.CLS_PTTT.NuocTieuHongCau));
                        MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                        rowCountId = 0;
                        while (DataReaderIdxetnghiem.Read()) rowCountId++;
                        if (rowCountId == 0)
                        {
                            sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, IDLOAI) VALUES(" + (int)EMR_MAIN.CLS_PTTT.NuocTieuHongCau + "," + _SoKetBenhAnDuyetMo.TagNuocTieu_HongCau.ToInt32() + ", 0)";
                            CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                            nId = CommandIDxetnghiem.ExecuteNonQuery();
                        }
                    }
                    if (_SoKetBenhAnDuyetMo.TagNuocTieu_BachCau.IsNotNullOrEmpty())
                    {
                        MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                        CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)EMR_MAIN.CLS_PTTT.NuocTieuBachCau));
                        MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                        rowCountId = 0;
                        while (DataReaderIdxetnghiem.Read()) rowCountId++;
                        if (rowCountId == 0)
                        {
                            sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, idloai) VALUES(" + (int)CLS_PTTT.NuocTieuBachCau + "," + _SoKetBenhAnDuyetMo.TagNuocTieu_BachCau.ToInt32() + ", 0)";
                            CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                            nId = CommandIDxetnghiem.ExecuteNonQuery();
                        }
                    }
                    if (_SoKetBenhAnDuyetMo.TagNuocTieu_Protein.IsNotNullOrEmpty())
                    {
                        MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                        CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)EMR_MAIN.CLS_PTTT.NuocTieuProtein));
                        MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                        rowCountId = 0;
                        while (DataReaderIdxetnghiem.Read()) rowCountId++;
                        if (rowCountId == 0)
                        {
                            sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, idloai) VALUES(" + (int)CLS_PTTT.NuocTieuProtein + "," + _SoKetBenhAnDuyetMo.TagNuocTieu_Protein.ToInt32() + ", 0)";
                            CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                            nId = CommandIDxetnghiem.ExecuteNonQuery();
                        }
                    }
                    if (_SoKetBenhAnDuyetMo.TagNuocTieu_TrucNieu.IsNotNullOrEmpty())
                    {
                        MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                        CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)EMR_MAIN.CLS_PTTT.NuocTieuTrucNieu));
                        MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                        rowCountId = 0;
                        while (DataReaderIdxetnghiem.Read()) rowCountId++;
                        if (rowCountId == 0)
                        {
                            sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, idloai) VALUES(" + (int)CLS_PTTT.NuocTieuTrucNieu + "," + _SoKetBenhAnDuyetMo.TagNuocTieu_TrucNieu.ToInt32() + ", 0)";
                            CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                            nId = CommandIDxetnghiem.ExecuteNonQuery();
                        }
                    }
                    if (_SoKetBenhAnDuyetMo.TagNuocTieu_DuongNieu.IsNotNullOrEmpty())
                    {
                        MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                        CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)EMR_MAIN.CLS_PTTT.NuocTieuDuongNieu));
                        MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                        rowCountId = 0;
                        while (DataReaderIdxetnghiem.Read()) rowCountId++;
                        if (rowCountId == 0)
                        {
                            sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, idloai) VALUES(" + (int)CLS_PTTT.NuocTieuDuongNieu + "," + _SoKetBenhAnDuyetMo.TagNuocTieu_DuongNieu.ToInt32() + ", 0)";
                            CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                            nId = CommandIDxetnghiem.ExecuteNonQuery();
                        }
                    }
                    if (_SoKetBenhAnDuyetMo.TagNuocTieu_SacToMat.IsNotNullOrEmpty())
                    {
                        MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                        CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)EMR_MAIN.CLS_PTTT.NuocTieuSacToMa));
                        MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                        rowCountId = 0;
                        while (DataReaderIdxetnghiem.Read()) rowCountId++;
                        if (rowCountId == 0)
                        {
                            sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, idloai) VALUES(" + (int)CLS_PTTT.NuocTieuSacToMa + "," + _SoKetBenhAnDuyetMo.TagNuocTieu_SacToMat.ToInt32() + ", 0)";
                            CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                            nId = CommandIDxetnghiem.ExecuteNonQuery();
                        }
                    }
                    if (_SoKetBenhAnDuyetMo.TagSinhHoa_Ure.IsNotNullOrEmpty())
                    {
                        MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                        CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)EMR_MAIN.CLS_PTTT.SinhHoaUre));
                        MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                        rowCountId = 0;
                        while (DataReaderIdxetnghiem.Read()) rowCountId++;
                        if (rowCountId == 0)
                        {
                            sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, idloai) VALUES(" + (int)CLS_PTTT.SinhHoaUre + "," + _SoKetBenhAnDuyetMo.TagSinhHoa_Ure.ToInt32() + ", 0)";
                            CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                            nId = CommandIDxetnghiem.ExecuteNonQuery();
                        }
                    }
                    if (_SoKetBenhAnDuyetMo.TagSinhHoa_Creatimin.IsNotNullOrEmpty())
                    {
                        MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                        CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)EMR_MAIN.CLS_PTTT.Creatimin));
                        MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                        rowCountId = 0;
                        while (DataReaderIdxetnghiem.Read()) rowCountId++;
                        if (rowCountId == 0)
                        {
                            sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, idloai) VALUES(" + (int)CLS_PTTT.Creatimin + "," + _SoKetBenhAnDuyetMo.TagSinhHoa_Creatimin.ToInt32() + ", 0)";
                            CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                            nId = CommandIDxetnghiem.ExecuteNonQuery();
                        }
                    }
                    if (_SoKetBenhAnDuyetMo.TagSinhHoa_Glucose.IsNotNullOrEmpty())
                    {
                        MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                        CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)EMR_MAIN.CLS_PTTT.Glucose));
                        MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                        rowCountId = 0;
                        while (DataReaderIdxetnghiem.Read()) rowCountId++;
                        if (rowCountId == 0)
                        {
                            sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, idloai) VALUES(" + (int)CLS_PTTT.Glucose + "," + _SoKetBenhAnDuyetMo.TagSinhHoa_Glucose.ToInt32() + ", 0)";
                            CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                            nId = CommandIDxetnghiem.ExecuteNonQuery();
                        }
                    }
                    if (_SoKetBenhAnDuyetMo.TagSinhHoa_BulirubinTP.IsNotNullOrEmpty())
                    {
                        MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                        CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)EMR_MAIN.CLS_PTTT.BilirubinTP));
                        MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                        rowCountId = 0;
                        while (DataReaderIdxetnghiem.Read()) rowCountId++;
                        if (rowCountId == 0)
                        {
                            sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, idloai) VALUES(" + (int)CLS_PTTT.BilirubinTP + "," + _SoKetBenhAnDuyetMo.TagSinhHoa_BulirubinTP.ToInt32() + ", 0)";
                            CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                            nId = CommandIDxetnghiem.ExecuteNonQuery();
                        }
                    }
                    if (_SoKetBenhAnDuyetMo.TagSinhHoa_BulirubinTT.IsNotNullOrEmpty())
                    {
                        MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                        CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)EMR_MAIN.CLS_PTTT.BilirubinTT));
                        MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                        rowCountId = 0;
                        while (DataReaderIdxetnghiem.Read()) rowCountId++;
                        if (rowCountId == 0)
                        {
                            sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, idloai) VALUES(" + (int)CLS_PTTT.BilirubinTT + "," + _SoKetBenhAnDuyetMo.TagSinhHoa_BulirubinTT.ToInt32() + ", 0)";
                            CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                            nId = CommandIDxetnghiem.ExecuteNonQuery();
                        }
                    }
                    if (_SoKetBenhAnDuyetMo.TagSinhHoa_BulirubinGT.IsNotNullOrEmpty())
                    {
                        MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                        CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)EMR_MAIN.CLS_PTTT.BilirubinGT));
                        MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                        rowCountId = 0;
                        while (DataReaderIdxetnghiem.Read()) rowCountId++;
                        if (rowCountId == 0)
                        {
                            sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, idloai) VALUES(" + (int)CLS_PTTT.BilirubinGT + "," + _SoKetBenhAnDuyetMo.TagSinhHoa_BulirubinGT.ToInt32() + ", 0)";
                            CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                            nId = CommandIDxetnghiem.ExecuteNonQuery();
                        }
                    }
                    if (_SoKetBenhAnDuyetMo.TagSinhHoa_ProteinTP.IsNotNullOrEmpty())
                    {
                        MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                        CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)EMR_MAIN.CLS_PTTT.ProteinTP));
                        MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                        rowCountId = 0;
                        while (DataReaderIdxetnghiem.Read()) rowCountId++;
                        if (rowCountId == 0)
                        {
                            sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, idloai) VALUES(" + (int)CLS_PTTT.ProteinTP + "," + _SoKetBenhAnDuyetMo.TagSinhHoa_ProteinTP.ToInt32() + ", 0)";
                            CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                            nId = CommandIDxetnghiem.ExecuteNonQuery();
                        }
                    }
                    if (_SoKetBenhAnDuyetMo.TagSinhHoa_Albumin.IsNotNullOrEmpty())
                    {
                        MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                        CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)EMR_MAIN.CLS_PTTT.Albumin));
                        MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                        rowCountId = 0;
                        while (DataReaderIdxetnghiem.Read()) rowCountId++;
                        if (rowCountId == 0)
                        {
                            sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, idloai) VALUES(" + (int)CLS_PTTT.Albumin + "," + _SoKetBenhAnDuyetMo.TagSinhHoa_Albumin.ToInt32() + ", 0)";
                            CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                            nId = CommandIDxetnghiem.ExecuteNonQuery();
                        }
                    }
                    if (_SoKetBenhAnDuyetMo.TagSinhHoa_GOT.IsNotNullOrEmpty())
                    {
                        MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                        CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)EMR_MAIN.CLS_PTTT.Got));
                        MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                        rowCountId = 0;
                        while (DataReaderIdxetnghiem.Read()) rowCountId++;
                        if (rowCountId == 0)
                        {
                            sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, idloai) VALUES(" + (int)CLS_PTTT.Got + "," + _SoKetBenhAnDuyetMo.TagSinhHoa_GOT.ToInt32() + ", 0)";
                            CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                            nId = CommandIDxetnghiem.ExecuteNonQuery();
                        }
                    }
                    if (_SoKetBenhAnDuyetMo.TagSinhHoa_GPT.IsNotNullOrEmpty())
                    {
                        MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                        CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)EMR_MAIN.CLS_PTTT.Gpt));
                        MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                        rowCountId = 0;
                        while (DataReaderIdxetnghiem.Read()) rowCountId++;
                        if (rowCountId == 0)
                        {
                            sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, idloai) VALUES(" + (int)CLS_PTTT.Gpt + "," + _SoKetBenhAnDuyetMo.TagSinhHoa_GPT.ToInt32() + ", 0)";
                            CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                            nId = CommandIDxetnghiem.ExecuteNonQuery();
                        }
                    }
                    if (_SoKetBenhAnDuyetMo.TagDongMau_PT.IsNotNullOrEmpty())
                    {
                        MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                        CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)EMR_MAIN.CLS_PTTT.DongMauPT));
                        MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                        rowCountId = 0;
                        while (DataReaderIdxetnghiem.Read()) rowCountId++;
                        if (rowCountId == 0)
                        {
                            sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, idloai) VALUES(" + (int)CLS_PTTT.DongMauPT + "," + _SoKetBenhAnDuyetMo.TagDongMau_PT.ToInt32() + ", 0)";
                            CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                            nId = CommandIDxetnghiem.ExecuteNonQuery();
                        }
                    }
                    if (_SoKetBenhAnDuyetMo.TagDongMau_APTT.IsNotNullOrEmpty())
                    {
                        MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                        CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)EMR_MAIN.CLS_PTTT.Aptt));
                        MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                        rowCountId = 0;
                        while (DataReaderIdxetnghiem.Read()) rowCountId++;
                        if (rowCountId == 0)
                        {
                            sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, idloai) VALUES(" + (int)CLS_PTTT.Aptt + "," + _SoKetBenhAnDuyetMo.TagDongMau_APTT.ToInt32() + ", 0)";
                            CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                            nId = CommandIDxetnghiem.ExecuteNonQuery();
                        }
                    }
                    if (_SoKetBenhAnDuyetMo.TagDongMau_Fibrinogen.IsNotNullOrEmpty())
                    {
                        MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                        CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)EMR_MAIN.CLS_PTTT.Fibrinogen));
                        MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                        rowCountId = 0;
                        while (DataReaderIdxetnghiem.Read()) rowCountId++;
                        if (rowCountId == 0)
                        {
                            sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, idloai) VALUES(" + (int)CLS_PTTT.Fibrinogen + "," + _SoKetBenhAnDuyetMo.TagDongMau_Fibrinogen.ToInt32() + ", 0)";
                            CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                            nId = CommandIDxetnghiem.ExecuteNonQuery();
                        }
                    }
                    if (_SoKetBenhAnDuyetMo.TagHIV.IsNotNullOrEmpty())
                    {
                        MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                        CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)EMR_MAIN.CLS_PTTT.XetNghiemHIV));
                        MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                        rowCountId = 0;
                        while (DataReaderIdxetnghiem.Read()) rowCountId++;
                        if (rowCountId == 0)
                        {
                            sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, idloai) VALUES(" + (int)CLS_PTTT.XetNghiemHIV + "," + _SoKetBenhAnDuyetMo.TagHIV.ToInt32() + ", 0)";
                            CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                            nId = CommandIDxetnghiem.ExecuteNonQuery();
                        }
                    }
                    if (_SoKetBenhAnDuyetMo.TagHbsAg.IsNotNullOrEmpty())
                    {
                        MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                        CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)EMR_MAIN.CLS_PTTT.HbsAg));
                        MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                        rowCountId = 0;
                        while (DataReaderIdxetnghiem.Read()) rowCountId++;
                        if (rowCountId == 0)
                        {
                            sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, idloai) VALUES(" + (int)CLS_PTTT.HbsAg + "," + _SoKetBenhAnDuyetMo.TagHbsAg.ToInt32() + ", 0)";
                            CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                            nId = CommandIDxetnghiem.ExecuteNonQuery();
                        }
                    }
                    if (_SoKetBenhAnDuyetMo.TagHCV.IsNotNullOrEmpty())
                    {
                        MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                        CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)EMR_MAIN.CLS_PTTT.Hcv));
                        MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                        rowCountId = 0;
                        while (DataReaderIdxetnghiem.Read()) rowCountId++;
                        if (rowCountId == 0)
                        {
                            sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, idloai) VALUES(" + (int)CLS_PTTT.Hcv + "," + _SoKetBenhAnDuyetMo.TagHCV.ToInt32() + ", 0)";
                            CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                            nId = CommandIDxetnghiem.ExecuteNonQuery();
                        }
                    }
                    if (_SoKetBenhAnDuyetMo.TagXquang.IsNotNullOrEmpty())
                    {
                        MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                        CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)EMR_MAIN.CLS_PTTT.XQuang));
                        MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                        rowCountId = 0;
                        while (DataReaderIdxetnghiem.Read()) rowCountId++;
                        if (rowCountId == 0)
                        {
                            sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, idloai) VALUES(" + (int)CLS_PTTT.XQuang + "," + _SoKetBenhAnDuyetMo.TagXquang.ToInt32() + ", 1)";
                            CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                            nId = CommandIDxetnghiem.ExecuteNonQuery();
                        }
                    }
                    if (_SoKetBenhAnDuyetMo.TagSieuAm.IsNotNullOrEmpty())
                    {
                        MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                        CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)EMR_MAIN.CLS_PTTT.SieuAm));
                        MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                        rowCountId = 0;
                        while (DataReaderIdxetnghiem.Read()) rowCountId++;
                        if (rowCountId == 0)
                        {
                            sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, idloai) VALUES(" + (int)CLS_PTTT.SieuAm + "," + _SoKetBenhAnDuyetMo.TagSieuAm.ToInt32() + ", 1)";
                            CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                            nId = CommandIDxetnghiem.ExecuteNonQuery();
                        }
                    }
                    if (_SoKetBenhAnDuyetMo.TagDienTim.IsNotNullOrEmpty())
                    {
                        MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                        CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)EMR_MAIN.CLS_PTTT.DienTim));
                        MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                        rowCountId = 0;
                        while (DataReaderIdxetnghiem.Read()) rowCountId++;
                        if (rowCountId == 0)
                        {
                            sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, idloai) VALUES(" + (int)CLS_PTTT.DienTim + "," + _SoKetBenhAnDuyetMo.TagDienTim.ToInt32() + ", 1)";
                            CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                            nId = CommandIDxetnghiem.ExecuteNonQuery();
                        }                        
                    }
                    if (_SoKetBenhAnDuyetMo.TagXetNghiemKhac.IsNotNullOrEmpty())
                    {
                        MDB.MDBCommand CommandIDxetnghiem = new MDB.MDBCommand(sqlIdXetnghiem, _OracleConnection);
                        CommandIDxetnghiem.Parameters.Add(new MDB.MDBParameter("ID", (int)EMR_MAIN.CLS_PTTT.XetNghiemKhac));
                        MDB.MDBDataReader DataReaderIdxetnghiem = CommandIDxetnghiem.ExecuteReader();
                        rowCountId = 0;
                        while (DataReaderIdxetnghiem.Read()) rowCountId++;
                        if (rowCountId == 0)
                        {
                            sql = @"INSERT INTO MapIdxetnghiem(ID, IDXETNGHIEM, idloai) VALUES(" + (int)CLS_PTTT.XetNghiemKhac + "," + _SoKetBenhAnDuyetMo.TagXetNghiemKhac.ToInt32() + ", 0)";
                            CommandIDxetnghiem = new MDB.MDBCommand(sql, _OracleConnection);
                            nId = CommandIDxetnghiem.ExecuteNonQuery();
                        }                                                
                    }
                    //return nId > 0 ? _SoKetBenhAnDuyetMo.ID : 0;

                }
                //08/06/2021 End by Hòa Issues 64961
                sql = @"SELECT * FROM SOKETBENHANDUYETMO WHERE ID = :ID";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID", _SoKetBenhAnDuyetMo.ID));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                int rowCount = 0;
                while (DataReader.Read()) rowCount++;
                if (rowCount == 1)
                    sql = @"UPDATE SOKETBENHANDUYETMO SET MAQUANLY = :MAQUANLY, THOIGIANTAO = :THOIGIANTAO, THOIGIANSUA = :THOIGIANSUA, BENHVIEN = :BENHVIEN, KHOA = :KHOA, MASO = :MASO, MABENHAN = :MABENHAN, HOTEN = :HOTEN, TUOI = :TUOI, GIOITINH = :GIOITINH, DIACHI = :DIACHI, BUONG = :BUONG, GIUONG = :GIUONG, VAOVIEN_GIO = :VAOVIEN_GIO, VAOVIEN_PHUT = :VAOVIEN_PHUT, VAOVIEN_NGAY = :VAOVIEN_NGAY, VAOVIEN_THANG = :VAOVIEN_THANG, VAOVIEN_NAM = :VAOVIEN_NAM, LYDOVAOVIEN = :LYDOVAOVIEN, TRIEUCHUNGLAMSANG = :TRIEUCHUNGLAMSANG, CONGTHUCMAU_HONGCAU = :CONGTHUCMAU_HONGCAU, CONGTHUCMAU_BACHCAU = :CONGTHUCMAU_BACHCAU, CONGTHUCMAU_N = :CONGTHUCMAU_N, CONGTHUCMAU_L = :CONGTHUCMAU_L, NHOMMAU = :NHOMMAU, THOIGIANMAUCHAY = :THOIGIANMAUCHAY, THOIGIANMAUDONG = :THOIGIANMAUDONG, HUYETSACTO = :HUYETSACTO, NUOCTIEU_HONGCAU = :NUOCTIEU_HONGCAU, NUOCTIEU_BACHCAU = :NUOCTIEU_BACHCAU, NUOCTIEU_PROTEIN = :NUOCTIEU_PROTEIN, NUOCTIEU_TRUCNIEU = :NUOCTIEU_TRUCNIEU, NUOCTIEU_DUONGNIEU = :NUOCTIEU_DUONGNIEU, NUOCTIEU_SACTOMAT = :NUOCTIEU_SACTOMAT, SINHHOA_URE = :SINHHOA_URE, SINHHOA_CREATIMIN = :SINHHOA_CREATIMIN, SINHHOA_GLUCOSE = :SINHHOA_GLUCOSE, SINHHOA_BULIRUBINTP = :SINHHOA_BULIRUBINTP, SINHHOA_BULIRUBINTT = :SINHHOA_BULIRUBINTT, SINHHOA_BULIRUBINGT = :SINHHOA_BULIRUBINGT, SINHHOA_PROTEINTP = :SINHHOA_PROTEINTP, SINHHOA_ALBUMIN = :SINHHOA_ALBUMIN, SINHHOA_GOT = :SINHHOA_GOT, SINHHOA_GPT = :SINHHOA_GPT, DONGMAU_PT = :DONGMAU_PT, DONGMAU_APTT = :DONGMAU_APTT, DONGMAU_FIBRINOGEN = :DONGMAU_FIBRINOGEN, HIV = :HIV, HBSAG = :HBSAG, HCV = :HCV, XQUANG = :XQUANG, SIEUAM = :SIEUAM, DIENTIM = :DIENTIM, XETNGHIEMKHAC = :XETNGHIEMKHAC, CHANDOAN = :CHANDOAN, PHUONGPHAPPHAUTHUAT = :PHUONGPHAPPHAUTHUAT, PHUONGPHAPVOCAM = :PHUONGPHAPVOCAM, PHAUTHUATVIEN = :PHAUTHUATVIEN, PHAUTHUAT_GIO = :PHAUTHUAT_GIO, PHAUTHUAT_PHUT = :PHAUTHUAT_PHUT, PHAUTHUAT_NGAY = :PHAUTHUAT_NGAY, PHAUTHUAT_THANG = :PHAUTHUAT_THANG, PHAUTHUAT_NAM = :PHAUTHUAT_NAM, DUTRUMAUKHIMO = :DUTRUMAUKHIMO, DUYETLANHDAO = :DUYETLANHDAO, BACSIGAYME = :BACSIGAYME,BACSITIMMACH = :BACSITIMMACH, TRUONGPHONGKH = :TRUONGPHONGKH, TRUONGKHOA = :TRUONGKHOA, BACSIDIEUTRI = :BACSIDIEUTRI, MANVPHAUTHUATVIEN = :MANVPHAUTHUATVIEN, MANVBACSIGAYME = :MANVBACSIGAYME, MANVBACSITIMMACH = :MANVBACSITIMMACH, MANVBACSIDIEUTRI = :MANVBACSIDIEUTRI, MANVTRUONGKHOA = :MANVTRUONGKHOA, MANVTRUONGPHONGKH = :MANVTRUONGPHONGKH, MANVDUYETLANHDAO = :MANVDUYETLANHDAO   WHERE ID = :ID";
                else
                {
                    sql = @"select ID_SOKETBENHANDUYETMO_REQ.nextval sequence_nextval from dual";
                    Command = new MDB.MDBCommand(sql, _OracleConnection);
                    DataReader = Command.ExecuteReader();
                    while (DataReader.Read())
                    {
                        _SoKetBenhAnDuyetMo.ID = long.Parse(DataReader["sequence_nextval"].ToString());
                    }
                    sql = @"INSERT INTO SOKETBENHANDUYETMO (MAQUANLY, THOIGIANTAO, THOIGIANSUA, BENHVIEN, KHOA, MASO, MABENHAN, HOTEN, TUOI, GIOITINH, DIACHI, BUONG, GIUONG, VAOVIEN_GIO, VAOVIEN_PHUT, VAOVIEN_NGAY, VAOVIEN_THANG, VAOVIEN_NAM, LYDOVAOVIEN, TRIEUCHUNGLAMSANG, CONGTHUCMAU_HONGCAU, CONGTHUCMAU_BACHCAU, CONGTHUCMAU_N, CONGTHUCMAU_L, NHOMMAU, THOIGIANMAUCHAY, THOIGIANMAUDONG, HUYETSACTO, NUOCTIEU_HONGCAU, NUOCTIEU_BACHCAU, NUOCTIEU_PROTEIN, NUOCTIEU_TRUCNIEU, NUOCTIEU_DUONGNIEU, NUOCTIEU_SACTOMAT, SINHHOA_URE, SINHHOA_CREATIMIN, SINHHOA_GLUCOSE, SINHHOA_BULIRUBINTP, SINHHOA_BULIRUBINTT, SINHHOA_BULIRUBINGT, SINHHOA_PROTEINTP, SINHHOA_ALBUMIN, SINHHOA_GOT, SINHHOA_GPT, DONGMAU_PT, DONGMAU_APTT, DONGMAU_FIBRINOGEN, HIV, HBSAG, HCV, XQUANG, SIEUAM, DIENTIM, XETNGHIEMKHAC, CHANDOAN, PHUONGPHAPPHAUTHUAT, PHUONGPHAPVOCAM, PHAUTHUATVIEN, PHAUTHUAT_GIO, PHAUTHUAT_PHUT, PHAUTHUAT_NGAY, PHAUTHUAT_THANG, PHAUTHUAT_NAM, DUTRUMAUKHIMO, DUYETLANHDAO, BACSIGAYME, BACSITIMMACH, TRUONGPHONGKH, TRUONGKHOA, BACSIDIEUTRI, MANVPHAUTHUATVIEN, MANVBACSIGAYME, MANVBACSITIMMACH, MANVBACSIDIEUTRI, MANVTRUONGKHOA, MANVTRUONGPHONGKH, MANVDUYETLANHDAO, ID) VALUES (:MAQUANLY, :THOIGIANTAO, :THOIGIANSUA, :BENHVIEN, :KHOA, :MASO, :MABENHAN, :HOTEN, :TUOI, :GIOITINH, :DIACHI, :BUONG, :GIUONG, :VAOVIEN_GIO, :VAOVIEN_PHUT, :VAOVIEN_NGAY, :VAOVIEN_THANG, :VAOVIEN_NAM, :LYDOVAOVIEN, :TRIEUCHUNGLAMSANG, :CONGTHUCMAU_HONGCAU, :CONGTHUCMAU_BACHCAU, :CONGTHUCMAU_N, :CONGTHUCMAU_L, :NHOMMAU, :THOIGIANMAUCHAY, :THOIGIANMAUDONG, :HUYETSACTO, :NUOCTIEU_HONGCAU, :NUOCTIEU_BACHCAU, :NUOCTIEU_PROTEIN, :NUOCTIEU_TRUCNIEU, :NUOCTIEU_DUONGNIEU, :NUOCTIEU_SACTOMAT, :SINHHOA_URE, :SINHHOA_CREATIMIN, :SINHHOA_GLUCOSE, :SINHHOA_BULIRUBINTP, :SINHHOA_BULIRUBINTT, :SINHHOA_BULIRUBINGT, :SINHHOA_PROTEINTP, :SINHHOA_ALBUMIN, :SINHHOA_GOT, :SINHHOA_GPT, :DONGMAU_PT, :DONGMAU_APTT, :DONGMAU_FIBRINOGEN, :HIV, :HBSAG, :HCV, :XQUANG, :SIEUAM, :DIENTIM, :XETNGHIEMKHAC, :CHANDOAN, :PHUONGPHAPPHAUTHUAT, :PHUONGPHAPVOCAM, :PHAUTHUATVIEN, :PHAUTHUAT_GIO, :PHAUTHUAT_PHUT, :PHAUTHUAT_NGAY, :PHAUTHUAT_THANG, :PHAUTHUAT_NAM, :DUTRUMAUKHIMO, :DUYETLANHDAO, :BACSIGAYME, :BACSITIMMACH, :TRUONGPHONGKH, :TRUONGKHOA, :BACSIDIEUTRI,  :MANVPHAUTHUATVIEN, :MANVBACSIGAYME, :MANVBACSITIMMACH, :MANVBACSIDIEUTRI, :MANVTRUONGKHOA, :MANVTRUONGPHONGKH, :MANVDUYETLANHDAO, :ID)";
                }
                Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", _SoKetBenhAnDuyetMo.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("THOIGIANTAO", _SoKetBenhAnDuyetMo.ThoiGianTao));
                Command.Parameters.Add(new MDB.MDBParameter("THOIGIANSUA", _SoKetBenhAnDuyetMo.ThoiGianSua));
                Command.Parameters.Add(new MDB.MDBParameter("BENHVIEN", _SoKetBenhAnDuyetMo.BenhVien));
                Command.Parameters.Add(new MDB.MDBParameter("KHOA", _SoKetBenhAnDuyetMo.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("MASO", _SoKetBenhAnDuyetMo.MaSo));
                Command.Parameters.Add(new MDB.MDBParameter("MABENHAN", _SoKetBenhAnDuyetMo.MaBenhAn));
                Command.Parameters.Add(new MDB.MDBParameter("HOTEN", _SoKetBenhAnDuyetMo.HoTen));
                Command.Parameters.Add(new MDB.MDBParameter("TUOI", _SoKetBenhAnDuyetMo.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("GIOITINH", _SoKetBenhAnDuyetMo.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("DIACHI", _SoKetBenhAnDuyetMo.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("BUONG", _SoKetBenhAnDuyetMo.Buong));
                Command.Parameters.Add(new MDB.MDBParameter("GIUONG", _SoKetBenhAnDuyetMo.Giuong));
                Command.Parameters.Add(new MDB.MDBParameter("VAOVIEN_GIO", _SoKetBenhAnDuyetMo.VaoVien_Gio));
                Command.Parameters.Add(new MDB.MDBParameter("VAOVIEN_PHUT", _SoKetBenhAnDuyetMo.VaoVien_Phut));
                Command.Parameters.Add(new MDB.MDBParameter("VAOVIEN_NGAY", _SoKetBenhAnDuyetMo.VaoVien_Ngay));
                Command.Parameters.Add(new MDB.MDBParameter("VAOVIEN_THANG", _SoKetBenhAnDuyetMo.VaoVien_Thang));
                Command.Parameters.Add(new MDB.MDBParameter("VAOVIEN_NAM", _SoKetBenhAnDuyetMo.VaoVien_Nam));
                Command.Parameters.Add(new MDB.MDBParameter("LYDOVAOVIEN", _SoKetBenhAnDuyetMo.LyDoVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("TRIEUCHUNGLAMSANG", _SoKetBenhAnDuyetMo.TrieuChungLamSang));
                Command.Parameters.Add(new MDB.MDBParameter("CONGTHUCMAU_HONGCAU", _SoKetBenhAnDuyetMo.CongThucMau_HongCau));
                Command.Parameters.Add(new MDB.MDBParameter("CONGTHUCMAU_BACHCAU", _SoKetBenhAnDuyetMo.CongThucMau_BachCau));
                Command.Parameters.Add(new MDB.MDBParameter("CONGTHUCMAU_N", _SoKetBenhAnDuyetMo.CongThucMau_N));
                Command.Parameters.Add(new MDB.MDBParameter("CONGTHUCMAU_L", _SoKetBenhAnDuyetMo.CongThucMau_L));
                Command.Parameters.Add(new MDB.MDBParameter("NHOMMAU", _SoKetBenhAnDuyetMo.NhomMau));
                Command.Parameters.Add(new MDB.MDBParameter("THOIGIANMAUCHAY", _SoKetBenhAnDuyetMo.ThoiGianMauChay));
                Command.Parameters.Add(new MDB.MDBParameter("THOIGIANMAUDONG", _SoKetBenhAnDuyetMo.ThoiGianMauDong));
                Command.Parameters.Add(new MDB.MDBParameter("HUYETSACTO", _SoKetBenhAnDuyetMo.HuyetSacTo));
                Command.Parameters.Add(new MDB.MDBParameter("NUOCTIEU_HONGCAU", _SoKetBenhAnDuyetMo.NuocTieu_HongCau));
                Command.Parameters.Add(new MDB.MDBParameter("NUOCTIEU_BACHCAU", _SoKetBenhAnDuyetMo.NuocTieu_BachCau));
                Command.Parameters.Add(new MDB.MDBParameter("NUOCTIEU_PROTEIN", _SoKetBenhAnDuyetMo.NuocTieu_Protein));
                Command.Parameters.Add(new MDB.MDBParameter("NUOCTIEU_TRUCNIEU", _SoKetBenhAnDuyetMo.NuocTieu_TrucNieu));
                Command.Parameters.Add(new MDB.MDBParameter("NUOCTIEU_DUONGNIEU", _SoKetBenhAnDuyetMo.NuocTieu_DuongNieu));
                Command.Parameters.Add(new MDB.MDBParameter("NUOCTIEU_SACTOMAT", _SoKetBenhAnDuyetMo.NuocTieu_SacToMat));
                Command.Parameters.Add(new MDB.MDBParameter("SINHHOA_URE", _SoKetBenhAnDuyetMo.SinhHoa_Ure));
                Command.Parameters.Add(new MDB.MDBParameter("SINHHOA_CREATIMIN", _SoKetBenhAnDuyetMo.SinhHoa_Creatimin));
                Command.Parameters.Add(new MDB.MDBParameter("SINHHOA_GLUCOSE", _SoKetBenhAnDuyetMo.SinhHoa_Glucose));
                Command.Parameters.Add(new MDB.MDBParameter("SINHHOA_BULIRUBINTP", _SoKetBenhAnDuyetMo.SinhHoa_BulirubinTP));
                Command.Parameters.Add(new MDB.MDBParameter("SINHHOA_BULIRUBINTT", _SoKetBenhAnDuyetMo.SinhHoa_BulirubinTT));
                Command.Parameters.Add(new MDB.MDBParameter("SINHHOA_BULIRUBINGT", _SoKetBenhAnDuyetMo.SinhHoa_BulirubinGT));
                Command.Parameters.Add(new MDB.MDBParameter("SINHHOA_PROTEINTP", _SoKetBenhAnDuyetMo.SinhHoa_ProteinTP));
                Command.Parameters.Add(new MDB.MDBParameter("SINHHOA_ALBUMIN", _SoKetBenhAnDuyetMo.SinhHoa_Albumin));
                Command.Parameters.Add(new MDB.MDBParameter("SINHHOA_GOT", _SoKetBenhAnDuyetMo.SinhHoa_GOT));
                Command.Parameters.Add(new MDB.MDBParameter("SINHHOA_GPT", _SoKetBenhAnDuyetMo.SinhHoa_GPT));
                Command.Parameters.Add(new MDB.MDBParameter("DONGMAU_PT", _SoKetBenhAnDuyetMo.DongMau_PT));
                Command.Parameters.Add(new MDB.MDBParameter("DONGMAU_APTT", _SoKetBenhAnDuyetMo.DongMau_APTT));
                Command.Parameters.Add(new MDB.MDBParameter("DONGMAU_FIBRINOGEN", _SoKetBenhAnDuyetMo.DongMau_Fibrinogen));
                Command.Parameters.Add(new MDB.MDBParameter("HIV", _SoKetBenhAnDuyetMo.HIV));
                Command.Parameters.Add(new MDB.MDBParameter("HBSAG", _SoKetBenhAnDuyetMo.HbsAg));
                Command.Parameters.Add(new MDB.MDBParameter("HCV", _SoKetBenhAnDuyetMo.HCV));
                Command.Parameters.Add(new MDB.MDBParameter("XQUANG", _SoKetBenhAnDuyetMo.Xquang));
                Command.Parameters.Add(new MDB.MDBParameter("SIEUAM", _SoKetBenhAnDuyetMo.SieuAm));
                Command.Parameters.Add(new MDB.MDBParameter("DIENTIM", _SoKetBenhAnDuyetMo.DienTim));
                Command.Parameters.Add(new MDB.MDBParameter("XETNGHIEMKHAC", _SoKetBenhAnDuyetMo.XetNghiemKhac));
                Command.Parameters.Add(new MDB.MDBParameter("CHANDOAN", _SoKetBenhAnDuyetMo.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("PHUONGPHAPPHAUTHUAT", _SoKetBenhAnDuyetMo.PhuongPhapPhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("PHUONGPHAPVOCAM", _SoKetBenhAnDuyetMo.PhuongPhapVoCam));
                Command.Parameters.Add(new MDB.MDBParameter("PHAUTHUATVIEN", _SoKetBenhAnDuyetMo.PhauThuatVien));
                Command.Parameters.Add(new MDB.MDBParameter("PHAUTHUAT_GIO", _SoKetBenhAnDuyetMo.PhauThuat_Gio));
                Command.Parameters.Add(new MDB.MDBParameter("PHAUTHUAT_PHUT", _SoKetBenhAnDuyetMo.PhauThuat_Phut));
                Command.Parameters.Add(new MDB.MDBParameter("PHAUTHUAT_NGAY", _SoKetBenhAnDuyetMo.PhauThuat_Ngay));
                Command.Parameters.Add(new MDB.MDBParameter("PHAUTHUAT_THANG", _SoKetBenhAnDuyetMo.PhauThuat_Thang));
                Command.Parameters.Add(new MDB.MDBParameter("PHAUTHUAT_NAM", _SoKetBenhAnDuyetMo.PhauThuat_Nam));
                Command.Parameters.Add(new MDB.MDBParameter("DUTRUMAUKHIMO", _SoKetBenhAnDuyetMo.DuTruMauKhiMo));
                Command.Parameters.Add(new MDB.MDBParameter("DUYETLANHDAO", _SoKetBenhAnDuyetMo.DuyetLanhDao));
                Command.Parameters.Add(new MDB.MDBParameter("BACSIGAYME", _SoKetBenhAnDuyetMo.BacSiGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("BACSITIMMACH", _SoKetBenhAnDuyetMo.BacSiTimMach));
                Command.Parameters.Add(new MDB.MDBParameter("TRUONGPHONGKH", _SoKetBenhAnDuyetMo.TruongPhongKh));
                Command.Parameters.Add(new MDB.MDBParameter("TRUONGKHOA", _SoKetBenhAnDuyetMo.TruongKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("BACSIDIEUTRI", _SoKetBenhAnDuyetMo.BacSiDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("MANVPHAUTHUATVIEN", _SoKetBenhAnDuyetMo.MaNVPhauThuatVien));
                Command.Parameters.Add(new MDB.MDBParameter("MANVBACSIGAYME", _SoKetBenhAnDuyetMo.MaNVBacSiGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("MANVBACSITIMMACH", _SoKetBenhAnDuyetMo.MaNVBacSiTimMach));
                Command.Parameters.Add(new MDB.MDBParameter("MANVBACSIDIEUTRI", _SoKetBenhAnDuyetMo.MaNVBacSiDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("MANVTRUONGKHOA", _SoKetBenhAnDuyetMo.MaNVTruongKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("MANVTRUONGPHONGKH", _SoKetBenhAnDuyetMo.MaNVTruongPhongKh));
                Command.Parameters.Add(new MDB.MDBParameter("MANVDUYETLANHDAO", _SoKetBenhAnDuyetMo.MaNVDuyetLanhDao));
                Command.Parameters.Add(new MDB.MDBParameter("ID", _SoKetBenhAnDuyetMo.ID));

                int n = Command.ExecuteNonQuery();
                return n > 0 ? _SoKetBenhAnDuyetMo.ID : 0;
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return 0;
        }
        public static bool Delete(MDB.MDBConnection _OracleConnection, SoKetBenhAnDuyetMo _SoKetBenhAnDuyetMo)
        {
            try
            {
                string sql = @"DELETE SOKETBENHANDUYETMO WHERE ID = :ID";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID", _SoKetBenhAnDuyetMo.ID));
                int n = Command.ExecuteNonQuery();
                return n > 0 ? true : false;
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return false;
        }
        public static List<SoKetBenhAnDuyetMo> GetData(string MaQuanLy, MDB.MDBConnection _OracleConnection)
        {
            List<SoKetBenhAnDuyetMo> lstData = new List<SoKetBenhAnDuyetMo>();
            try
            {
                string sql = @"SELECT * FROM SOKETBENHANDUYETMO where MAQUANLY = :MAQUANLY";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    SoKetBenhAnDuyetMo data = new SoKetBenhAnDuyetMo();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = Convert.ToDecimal(DataReader.GetDecimal("MAQUANLY").ToString());
                    data.ThoiGianTao = Convert.ToDateTime(DataReader.GetDate("THOIGIANTAO"));
                    if (DataReader["THOIGIANSUA"] == null && DataReader["THOIGIANSUA"].ToString() != "")
                        data.ThoiGianSua = Convert.ToDateTime(DataReader.GetDate("THOIGIANSUA"));
                    data.BenhVien = DataReader["BENHVIEN"].ToString();
                    data.Khoa = DataReader["KHOA"].ToString();
                    data.MaSo = DataReader["MASO"].ToString();
                    data.MaBenhAn = DataReader["MABENHAN"].ToString();
                    data.HoTen = DataReader["HOTEN"].ToString();
                    data.Tuoi = DataReader["TUOI"].ToString();
                    data.GioiTinh = DataReader["GIOITINH"].ToString();
                    data.DiaChi = DataReader["DIACHI"].ToString();
                    data.Buong = DataReader["BUONG"].ToString();
                    data.Giuong = DataReader["GIUONG"].ToString();
                    data.VaoVien_Gio = DataReader["VAOVIEN_GIO"].ToString();
                    data.VaoVien_Phut = DataReader["VAOVIEN_PHUT"].ToString();
                    data.VaoVien_Ngay = DataReader["VAOVIEN_NGAY"].ToString();
                    data.VaoVien_Thang = DataReader["VAOVIEN_THANG"].ToString();
                    data.VaoVien_Nam = DataReader["VAOVIEN_NAM"].ToString();
                    data.LyDoVaoVien = DataReader["LYDOVAOVIEN"].ToString();
                    data.TrieuChungLamSang = DataReader["TRIEUCHUNGLAMSANG"].ToString();
                    data.CongThucMau_HongCau = DataReader["CONGTHUCMAU_HONGCAU"].ToString();
                    data.CongThucMau_BachCau = DataReader["CONGTHUCMAU_BACHCAU"].ToString();
                    data.CongThucMau_N = DataReader["CONGTHUCMAU_N"].ToString();
                    data.CongThucMau_L = DataReader["CONGTHUCMAU_L"].ToString();
                    data.NhomMau = DataReader["NHOMMAU"].ToString();
                    data.ThoiGianMauChay = DataReader["THOIGIANMAUCHAY"].ToString();
                    data.ThoiGianMauDong = DataReader["THOIGIANMAUDONG"].ToString();
                    data.HuyetSacTo = DataReader["HUYETSACTO"].ToString();
                    data.NuocTieu_HongCau = DataReader["NUOCTIEU_HONGCAU"].ToString();
                    data.NuocTieu_BachCau = DataReader["NUOCTIEU_BACHCAU"].ToString();
                    data.NuocTieu_Protein = DataReader["NUOCTIEU_PROTEIN"].ToString();
                    data.NuocTieu_TrucNieu = DataReader["NUOCTIEU_TRUCNIEU"].ToString();
                    data.NuocTieu_DuongNieu = DataReader["NUOCTIEU_DUONGNIEU"].ToString();
                    data.NuocTieu_SacToMat = DataReader["NUOCTIEU_SACTOMAT"].ToString();
                    data.SinhHoa_Ure = DataReader["SINHHOA_URE"].ToString();
                    data.SinhHoa_Creatimin = DataReader["SINHHOA_CREATIMIN"].ToString();
                    data.SinhHoa_Glucose = DataReader["SINHHOA_GLUCOSE"].ToString();
                    data.SinhHoa_BulirubinTP = DataReader["SINHHOA_BULIRUBINTP"].ToString();
                    data.SinhHoa_BulirubinTT = DataReader["SINHHOA_BULIRUBINTT"].ToString();
                    data.SinhHoa_BulirubinGT = DataReader["SINHHOA_BULIRUBINGT"].ToString();
                    data.SinhHoa_ProteinTP = DataReader["SINHHOA_PROTEINTP"].ToString();
                    data.SinhHoa_Albumin = DataReader["SINHHOA_ALBUMIN"].ToString();
                    data.SinhHoa_GOT = DataReader["SINHHOA_GOT"].ToString();
                    data.SinhHoa_GPT = DataReader["SINHHOA_GPT"].ToString();
                    data.DongMau_PT = DataReader["DONGMAU_PT"].ToString();
                    data.DongMau_APTT = DataReader["DONGMAU_APTT"].ToString();
                    data.DongMau_Fibrinogen = DataReader["DONGMAU_FIBRINOGEN"].ToString();
                    data.HIV = DataReader["HIV"].ToString();
                    data.HbsAg = DataReader["HBSAG"].ToString();
                    data.HCV = DataReader["HCV"].ToString();
                    data.Xquang = DataReader["XQUANG"].ToString();
                    data.SieuAm = DataReader["SIEUAM"].ToString();
                    data.DienTim = DataReader["DIENTIM"].ToString();
                    data.XetNghiemKhac = DataReader["XETNGHIEMKHAC"].ToString();
                    data.ChanDoan = DataReader["CHANDOAN"].ToString();
                    data.PhuongPhapPhauThuat = DataReader["PHUONGPHAPPHAUTHUAT"].ToString();
                    data.PhuongPhapVoCam = DataReader["PHUONGPHAPVOCAM"].ToString();
                    data.PhauThuatVien = DataReader["PHAUTHUATVIEN"].ToString();
                    data.PhauThuat_Gio = DataReader["PHAUTHUAT_GIO"].ToString();
                    data.PhauThuat_Phut = DataReader["PHAUTHUAT_PHUT"].ToString();
                    data.PhauThuat_Ngay = DataReader["PHAUTHUAT_NGAY"].ToString();
                    data.PhauThuat_Thang = DataReader["PHAUTHUAT_THANG"].ToString();
                    data.PhauThuat_Nam = DataReader["PHAUTHUAT_NAM"].ToString();
                    data.DuTruMauKhiMo = DataReader["DUTRUMAUKHIMO"].ToString();
                    data.DuyetLanhDao = DataReader["DUYETLANHDAO"].ToString();
                    data.BacSiGayMe = DataReader["BACSIGAYME"].ToString();
                    data.BacSiTimMach = DataReader["BACSITIMMACH"].ToString();
                    data.TruongPhongKh = DataReader["TRUONGPHONGKH"].ToString();
                    data.TruongKhoa = DataReader["TRUONGKHOA"].ToString();
                    data.BacSiDieuTri = DataReader["BACSIDIEUTRI"].ToString();
                    data.MaNVPhauThuatVien = DataReader["MANVPHAUTHUATVIEN"].ToString();
                    data.MaNVBacSiGayMe = DataReader["MANVBACSIGAYME"].ToString();
                    data.MaNVBacSiTimMach = DataReader["MANVBACSITIMMACH"].ToString();
                    data.MaNVBacSiDieuTri = DataReader["MANVBACSIDIEUTRI"].ToString();
                    data.MaNVTruongKhoa = DataReader["MANVTRUONGKHOA"].ToString();
                    data.MaNVTruongPhongKh = DataReader["MANVTRUONGPHONGKH"].ToString();
                    data.MaNVDuyetLanhDao = DataReader["MANVDUYETLANHDAO"].ToString();
                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;

                    lstData.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return lstData;
        }        
    }
}
