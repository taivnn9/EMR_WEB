
using EMR.KyDienTu;
using Newtonsoft.Json;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;


namespace EMR_MAIN.DATABASE.Other
{
    [JsonObject]
    public class PhoiIPTMCT : ThongTinKy
    {
        public PhoiIPTMCT()
        {
            TableName = "PhoiIPTMCT";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PIPTMCT;
            TenMauPhieu = DanhMucPhieu.PIPTMCT.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Bệnh viện")]
		public string BenhVien { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Năm sinh")]
		public string NamSinh { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        public string ThuThuat { get; set; }
        public DateTime? NgayLamThuThuat { get; set; }
      
        public string MaBacSiThuThuat { get; set; }
        public string BacSiThuThuat { get; set; }
        public string MaNguoiThongKe { get; set; }
        public string NguoiThongKe { get; set; }
        public ObservableCollection<PhoiIP_VatTuCTTM> ListVatTu { get; set; }
        public ObservableCollection<PhoiIP_ThuocCTTM> ListThuoc { get; set; }

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
    [JsonObject]
    public class PhoiIP_VatTuCTTM
    {
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã định danh")]
		public long ID_Phieu { get; set; }
        public string STT { get; set; }
        public string TenDungCu { get; set; }
        public string DonViVatTu { get; set; }
        public string SoLuongVatTu { get; set; }
        public string HangVatTu { get; set; }

        public static ObservableCollection<PhoiIP_VatTuCTTM> CreateListVatTu()
        {
            ObservableCollection<PhoiIP_VatTuCTTM> ListVatTu = new ObservableCollection<PhoiIP_VatTuCTTM>();
            ListVatTu.Add(new PhoiIP_VatTuCTTM { STT = "1", TenDungCu = "Kim chọc mạch", DonViVatTu = "Cái" });
            ListVatTu.Add(new PhoiIP_VatTuCTTM { STT = "2", TenDungCu = "Dụng cụ mở đường đùi", DonViVatTu = "Cái" });
            ListVatTu.Add(new PhoiIP_VatTuCTTM { STT = "3", TenDungCu = "Catheter 4 ĐC", DonViVatTu = "Cái" });
            ListVatTu.Add(new PhoiIP_VatTuCTTM { STT = "4", TenDungCu = "Catheter 10 ĐC", DonViVatTu = "Cái" });
            ListVatTu.Add(new PhoiIP_VatTuCTTM { STT = "5", TenDungCu = "Cáp 4 ĐC", DonViVatTu = "Cái" });
            ListVatTu.Add(new PhoiIP_VatTuCTTM { STT = "6", TenDungCu = "Cáp 10 ĐC", DonViVatTu = "Cái" });
            ListVatTu.Add(new PhoiIP_VatTuCTTM { STT = "7", TenDungCu = "Catheter đốt", DonViVatTu = "Cái" });
            ListVatTu.Add(new PhoiIP_VatTuCTTM { STT = "8", TenDungCu = "Cáp đốt", DonViVatTu = "Cái" });
            ListVatTu.Add(new PhoiIP_VatTuCTTM { STT = "9", TenDungCu = "Điện cực âm", DonViVatTu = "Cái" });
            ListVatTu.Add(new PhoiIP_VatTuCTTM { STT = "10", TenDungCu = "Bộ dây truyền lạnh", DonViVatTu = "Cái" });
            ListVatTu.Add(new PhoiIP_VatTuCTTM { STT = "11", TenDungCu = "Longsheath", DonViVatTu = "Cái" });
            ListVatTu.Add(new PhoiIP_VatTuCTTM { STT = "12", TenDungCu = "Kim chọc vách", DonViVatTu = "Cái" });
            ListVatTu.Add(new PhoiIP_VatTuCTTM { STT = "13", TenDungCu = "Catheter mapping", DonViVatTu = "Cái" });
            ListVatTu.Add(new PhoiIP_VatTuCTTM { STT = "14", TenDungCu = "Cáp mapping", DonViVatTu = "Cái" });
            ListVatTu.Add(new PhoiIP_VatTuCTTM { STT = "15", TenDungCu = "Dụng cụ lái hướng", DonViVatTu = "Cái" });
            ListVatTu.Add(new PhoiIP_VatTuCTTM { STT = "16", TenDungCu = "Dụng cụ mở đường quay", DonViVatTu = "Cái" });
            ListVatTu.Add(new PhoiIP_VatTuCTTM { STT = "17", TenDungCu = "Sylanh đầu xoáy", DonViVatTu = "Cái" });
            ListVatTu.Add(new PhoiIP_VatTuCTTM { STT = "18", TenDungCu = "Bộ phận kết nối( Biotronic)", DonViVatTu = "Cái" });
            ListVatTu.Add(new PhoiIP_VatTuCTTM { STT = "19", TenDungCu = "Dây dẫn đường Catherter 145cm", DonViVatTu = "Cái" });
            ListVatTu.Add(new PhoiIP_VatTuCTTM { STT = "20", TenDungCu = "Catheter chụp 2 bên", DonViVatTu = "Cái" });
            ListVatTu.Add(new PhoiIP_VatTuCTTM { STT = "21", TenDungCu = "Catheter chụp động mạch thường", DonViVatTu = "Cái" });

            return ListVatTu;
        }
    }
    [JsonObject]
    public class PhoiIP_ThuocCTTM
    {
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã định danh")]
		public long ID_Phieu { get; set; }
        public string TenThuoc { get; set; }
        public string DonViThuoc { get; set; }
        public string SoLuongThuoc { get; set; }
        public string TenHangDungCu { get; set; }
        public string DonViDungCu { get; set; }
        public string SoLuongDungCu { get; set; }

        public static ObservableCollection<PhoiIP_ThuocCTTM> CreateListThuoc()
        {
            ObservableCollection<PhoiIP_ThuocCTTM> ListThuoc = new ObservableCollection<PhoiIP_ThuocCTTM>();
            ListThuoc.Add(new PhoiIP_ThuocCTTM {TenThuoc= "A.T Nitroglycerin 5mg/5ml", DonViThuoc = "Lọ", SoLuongThuoc = "1/3", TenHangDungCu = "Băng cuộn 10cm x 7cm", DonViDungCu= "Cái", SoLuongDungCu="3" });
            ListThuoc.Add(new PhoiIP_ThuocCTTM {TenThuoc= "Adrenalin 1mg/1ml", DonViThuoc = "ống", SoLuongThuoc = "",TenHangDungCu = "Băng dính lụa", DonViDungCu= "Cuộn", SoLuongDungCu="0.2" });
            ListThuoc.Add(new PhoiIP_ThuocCTTM {TenThuoc= "Aspirin 81mg", DonViThuoc = "viên", SoLuongThuoc = "",TenHangDungCu = "Bơm tiêm nhựa 10ml", DonViDungCu= "Cái", SoLuongDungCu="4" });
            ListThuoc.Add(new PhoiIP_ThuocCTTM {TenThuoc= "Atropin 0,25mg", DonViThuoc = "ống", SoLuongThuoc = "",TenHangDungCu = "Bơm tiêm nhựa 1ml", DonViDungCu= "Cái", SoLuongDungCu="1" });
            ListThuoc.Add(new PhoiIP_ThuocCTTM {TenThuoc= "Betadin 500ml", DonViThuoc = "Lọ", SoLuongThuoc = "1/2",TenHangDungCu = "Bơm tiêm nhựa 20ml", DonViDungCu= "Cái", SoLuongDungCu="1" });
            ListThuoc.Add(new PhoiIP_ThuocCTTM {TenThuoc= "Diazepham", DonViThuoc = "ống", SoLuongThuoc = "",TenHangDungCu = "Bơm tiêm nhựa 20ml Terumo", DonViDungCu= "Cái", SoLuongDungCu="" });
            ListThuoc.Add(new PhoiIP_ThuocCTTM {TenThuoc= "Dimedron10mg", DonViThuoc = "ống", SoLuongThuoc = "",TenHangDungCu = "Bơm tiêm nhựa 3ml", DonViDungCu= "Cái", SoLuongDungCu="" });
            ListThuoc.Add(new PhoiIP_ThuocCTTM {TenThuoc= "Dobutamine 250mg", DonViThuoc = "Lọ", SoLuongThuoc = "",TenHangDungCu = "Bơm tiêm nhựa 50ml Terumo", DonViDungCu= "Cái", SoLuongDungCu="" });
            ListThuoc.Add(new PhoiIP_ThuocCTTM {TenThuoc= "Fentanyl", DonViThuoc = "ống", SoLuongThuoc = "",TenHangDungCu = "Bơm tiêm nhựa 5ml", DonViDungCu= "Cái", SoLuongDungCu="1" });
            ListThuoc.Add(new PhoiIP_ThuocCTTM {TenThuoc= "Fresofol 1% 20ml", DonViThuoc = "ống", SoLuongThuoc = "",TenHangDungCu = "Dây đo áp lực", DonViDungCu= "Cái", SoLuongDungCu="1" });
            ListThuoc.Add(new PhoiIP_ThuocCTTM {TenThuoc= "Furosemid 20mg", DonViThuoc = "ống", SoLuongThuoc = "",TenHangDungCu = "Dây nối BTĐ các số", DonViDungCu= "Cái", SoLuongDungCu="" });
            ListThuoc.Add(new PhoiIP_ThuocCTTM {TenThuoc= "Heparin 25000UI/5ml", DonViThuoc = "Lọ", SoLuongThuoc = "1/3",TenHangDungCu = "Dây nối dài 30 cm", DonViDungCu= "Cái", SoLuongDungCu="" });
            ListThuoc.Add(new PhoiIP_ThuocCTTM {TenThuoc= "Levonor 1mg/ml", DonViThuoc = "ống", SoLuongThuoc = "",TenHangDungCu = "Dây truyền dịch", DonViDungCu= "Cái", SoLuongDungCu="1" });
            ListThuoc.Add(new PhoiIP_ThuocCTTM {TenThuoc= "Lidocain 200mg", DonViThuoc = "ống", SoLuongThuoc = "1/2",TenHangDungCu = "Điện cực tim", DonViDungCu= "Cái", SoLuongDungCu="4" });
            ListThuoc.Add(new PhoiIP_ThuocCTTM {TenThuoc= "Lovenox", DonViThuoc = "Bơm", SoLuongThuoc = "",TenHangDungCu = "Gạc đã tiệt trùng 12 lớp", DonViDungCu= "Miếng", SoLuongDungCu="20" });
            ListThuoc.Add(new PhoiIP_ThuocCTTM {TenThuoc= "Midarolam 5mg", DonViThuoc = "ống", SoLuongThuoc = "",TenHangDungCu = "Gạc chưa tiệt trùng", DonViDungCu= "Miếng", SoLuongDungCu="5" });
            ListThuoc.Add(new PhoiIP_ThuocCTTM {TenThuoc= "Natriclorua 0,9% 1000ml", DonViThuoc = "Chai", SoLuongThuoc = "2",TenHangDungCu = "Găng tay sạch", DonViDungCu= "Đôi", SoLuongDungCu="3" });
            ListThuoc.Add(new PhoiIP_ThuocCTTM {TenThuoc= "Nerxium 40mg", DonViThuoc = "Lọ", SoLuongThuoc = "",TenHangDungCu = "Găng tay tiệt trùng", DonViDungCu= "Đôi", SoLuongDungCu="5" });
            ListThuoc.Add(new PhoiIP_ThuocCTTM {TenThuoc= "Nicardipin 10mg", DonViThuoc = "ống", SoLuongThuoc = "",TenHangDungCu = "Khóa 3 chạc", DonViDungCu= "Cái", SoLuongDungCu="1" });
            ListThuoc.Add(new PhoiIP_ThuocCTTM {TenThuoc= "Omnipaque 300mg/100ml", DonViThuoc = "Lọ", SoLuongThuoc = "",TenHangDungCu = "Kim lấy thuốc", DonViDungCu= "Cái", SoLuongDungCu="1" });
            ListThuoc.Add(new PhoiIP_ThuocCTTM {TenThuoc= "Osaphin 10mg/1ml", DonViThuoc = "ống", SoLuongThuoc = "",TenHangDungCu = "Kim Luồn", DonViDungCu= "Cái", SoLuongDungCu="" });
            ListThuoc.Add(new PhoiIP_ThuocCTTM {TenThuoc= "Plavic 300mg", DonViThuoc = "Viên", SoLuongThuoc = "",TenHangDungCu = "Lưỡi dao", DonViDungCu= "Cái", SoLuongDungCu="" });
            ListThuoc.Add(new PhoiIP_ThuocCTTM {TenThuoc= "Solumedrol 40mg", DonViThuoc = "Lọ", SoLuongThuoc = "",TenHangDungCu = "Mask thở", DonViDungCu= "Cái", SoLuongDungCu="" });
            ListThuoc.Add(new PhoiIP_ThuocCTTM {TenThuoc= "Vincomid 10mg/2ml", DonViThuoc = "ống", SoLuongThuoc = "",TenHangDungCu = "Mũ Giấy", DonViDungCu= "Cái", SoLuongDungCu="2" });
            ListThuoc.Add(new PhoiIP_ThuocCTTM {TenThuoc= "Xenetix 30mg/100ml", DonViThuoc = "Lọ", SoLuongThuoc = "",TenHangDungCu = "ống thở oxy hai nhánh", DonViDungCu= "Cái", SoLuongDungCu="" });
            ListThuoc.Add(new PhoiIP_ThuocCTTM {TenThuoc= "", DonViThuoc = "", SoLuongThuoc = "",TenHangDungCu = "Optiskin Film 53x80", DonViDungCu= "Cái", SoLuongDungCu="" });
            ListThuoc.Add(new PhoiIP_ThuocCTTM {TenThuoc= "", DonViThuoc = "", SoLuongThuoc = "",TenHangDungCu = "Tấm trải", DonViDungCu= "Cái", SoLuongDungCu="2" });
            ListThuoc.Add(new PhoiIP_ThuocCTTM {TenThuoc= "", DonViThuoc = "", SoLuongThuoc = "",TenHangDungCu = "Túi trùm bóng đèn", DonViDungCu= "Cái", SoLuongDungCu="2" });
            ListThuoc.Add(new PhoiIP_ThuocCTTM {TenThuoc= "", DonViThuoc = "", SoLuongThuoc = "",TenHangDungCu = "Urgocrep4,5*8cm", DonViDungCu= "Cuộn", SoLuongDungCu="0.4" });
            ListThuoc.Add(new PhoiIP_ThuocCTTM {TenThuoc= "", DonViThuoc = "", SoLuongThuoc = "",TenHangDungCu = "W3328", DonViDungCu= "Sợi", SoLuongDungCu="" });
            ListThuoc.Add(new PhoiIP_ThuocCTTM {TenThuoc= "", DonViThuoc = "", SoLuongThuoc = "",TenHangDungCu = "W9121", DonViDungCu= "Sợi", SoLuongDungCu="" });

            return ListThuoc;
        }
    }
    [JsonObject]
    public class PhoiIPTMCTFunc
    {
        public const string TableName = "PhoiIPTMCT";
        public const string TablePrimaryKeyName = "ID";

        public static List<PhoiIPTMCT> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhoiIPTMCT> list = new List<PhoiIPTMCT>();
            try
            {
                string sql = @"SELECT * FROM PhoiIPTMCT where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhoiIPTMCT data = new PhoiIPTMCT();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;

                    data.MaBenhNhan = XemBenhAn._HanhChinhBenhNhan.MaBenhNhan;
                    data.TenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.NamSinh = XemBenhAn._HanhChinhBenhNhan.NgaySinh?.Year.ToString();
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.Khoa = XemBenhAn._ThongTinDieuTri.Khoa;
                    data.BenhVien = XemBenhAn._HanhChinhBenhNhan.BenhVien;

                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.DiaChi = DataReader["DiaChi"].ToString();
                    data.ThuThuat = DataReader["ThuThuat"].ToString();
                    data.MaBacSiThuThuat = DataReader["MaBacSiThuThuat"].ToString();
                    data.BacSiThuThuat = DataReader["BacSiThuThuat"].ToString();
                    data.NguoiThongKe = DataReader["NguoiThongKe"].ToString();
                    data.MaNguoiThongKe = DataReader["MaNguoiThongKe"].ToString();
                    
                    data.NgayLamThuThuat = Convert.ToDateTime(DataReader["NgayLamThuThuat"] == DBNull.Value ? DateTime.Now : DataReader["NgayLamThuThuat"]);

                    data.ListThuoc = GetPhoiIP_ThuocCTTM(_OracleConnection, data.ID);
                    data.ListVatTu = GetPhoiIP_VatTuCTTM(_OracleConnection, data.ID);

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
                sql = @"DELETE FROM PhoiIPTMCT WHERE ID =" + IDBienBan;
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
                PhoiIPTMCT P
            WHERE
                ID = " + IDBienBan;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "TB");

            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("NamSinh", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(string));
            ds.Tables[0].AddColumn("Khoa", typeof(string));
            ds.Tables[0].AddColumn("BenhVien", typeof(string));
            ds.Tables[0].AddColumn("MaBenhAn", typeof(string));
            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["NamSinh"] = XemBenhAn._HanhChinhBenhNhan.NgaySinh.HasValue ? XemBenhAn._HanhChinhBenhNhan.NgaySinh.Value.Year + "" : "";
            ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            ds.Tables[0].Rows[0]["Khoa"] = XemBenhAn._ThongTinDieuTri.Khoa;
            ds.Tables[0].Rows[0]["BenhVien"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["MaBenhAn"] = XemBenhAn._ThongTinDieuTri.MaBenhAn;

            DataTable VT = new DataTable("VT");
            VT.Columns.Add("STT", typeof(string));

            VT.Columns.Add("TenDungCu", typeof(string));
            VT.Columns.Add("DonViVatTu", typeof(string));
            VT.Columns.Add("SoLuongVatTu", typeof(string));
            VT.Columns.Add("HangVatTu", typeof(string));

            ObservableCollection<PhoiIP_VatTuCTTM> ListVatTu = GetPhoiIP_VatTuCTTM(MyConnection, IDBienBan);
            if (ListVatTu != null)
            {
                foreach (PhoiIP_VatTuCTTM _VatTu in ListVatTu)
                {
                    VT.Rows.Add(_VatTu.STT, _VatTu.TenDungCu, _VatTu.DonViVatTu, _VatTu.SoLuongVatTu, _VatTu.HangVatTu);
                }
            }
            ds.Tables.Add(VT);

            DataTable T = new DataTable("T");
            T.Columns.Add("TenThuoc", typeof(string));

            T.Columns.Add("DonViThuoc", typeof(string));
            T.Columns.Add("SoLuongThuoc", typeof(string));
            T.Columns.Add("TenHangDungCu", typeof(string));
            T.Columns.Add("DonViDungCu", typeof(string));
            T.Columns.Add("SoLuongDungCu", typeof(string));


            ObservableCollection<PhoiIP_ThuocCTTM> ListPhoiIP_ThuocCTTM = GetPhoiIP_ThuocCTTM(MyConnection, IDBienBan);
            if (ListPhoiIP_ThuocCTTM != null)
            {
                foreach (PhoiIP_ThuocCTTM _Thuoc in ListPhoiIP_ThuocCTTM)
                {
                    T.Rows.Add(_Thuoc.TenThuoc, _Thuoc.DonViThuoc, _Thuoc.SoLuongThuoc, _Thuoc.TenHangDungCu, _Thuoc.DonViDungCu, _Thuoc.SoLuongDungCu);
                }
            }
            ds.Tables.Add(T);

            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhoiIPTMCT ketQua)
        {
            try
            {
                string sql = @"INSERT INTO PhoiIPTMCT
                (
                    MaQuanLy,
                    ChanDoan,
                    ThuThuat,
                    NgayLamThuThuat,
                    DiaChi,
                    MaBacSiThuThuat,
                    BacSiThuThuat,
                    MaNguoiThongKe,
                    NguoiThongKe,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
                    :ChanDoan,
                    :ThuThuat,
                    :NgayLamThuThuat,
                    :DiaChi,
                    :MaBacSiThuThuat,
                    :BacSiThuThuat,
                    :MaNguoiThongKe,
                    :NguoiThongKe,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE PhoiIPTMCT SET 
                    MaQuanLy = :MaQuanLy,
                    ChanDoan = :ChanDoan,
                    ThuThuat = :ThuThuat,
                    NgayLamThuThuat = :NgayLamThuThuat,
                    DiaChi = :DiaChi,
                    MaBacSiThuThuat = :MaBacSiThuThuat,
                    BacSiThuThuat = :BacSiThuThuat,
                    MaNguoiThongKe = :MaNguoiThongKe,
                    NguoiThongKe = :NguoiThongKe,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", ketQua.MaQuanLy));

                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", ketQua.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("ThuThuat", ketQua.ThuThuat));
                Command.Parameters.Add(new MDB.MDBParameter("NgayLamThuThuat", ketQua.NgayLamThuThuat));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", ketQua.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSiThuThuat", ketQua.MaBacSiThuThuat));
                Command.Parameters.Add(new MDB.MDBParameter("BacSiThuThuat", ketQua.BacSiThuThuat));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiThongKe", ketQua.MaNguoiThongKe));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiThongKe", ketQua.NguoiThongKe));

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

        public static ObservableCollection<PhoiIP_VatTuCTTM> GetPhoiIP_VatTuCTTM(MDB.MDBConnection _OracleConnection, long idPhieu)
        {
            ObservableCollection<PhoiIP_VatTuCTTM> PhoiIP_VatTuCTTMs = new ObservableCollection<PhoiIP_VatTuCTTM>();
            try
            {
                string sql = @"SELECT * FROM PhoiIP_VatTuCTTM where ID_Phieu = :ID_Phieu ORDER BY ID asc";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID_Phieu", idPhieu));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhoiIP_VatTuCTTM data = new PhoiIP_VatTuCTTM();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.ID_Phieu = idPhieu;

                    data.STT = DataReader["STT"].ToString();
                    data.TenDungCu = DataReader["TenDungCu"].ToString();
                    data.DonViVatTu = DataReader["DonViVatTu"].ToString();
                    data.SoLuongVatTu = DataReader["SoLuongVatTu"].ToString();
                    data.HangVatTu = DataReader["HangVatTu"].ToString();

                    PhoiIP_VatTuCTTMs.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return PhoiIP_VatTuCTTMs;
        }
        public static bool DeletePhoiIP_VatTuCTTM(MDB.MDBConnection MyConnection, long id)
        {
            try
            {
                string sql = "DELETE FROM PhoiIP_VatTuCTTM WHERE ID = :ID";
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
        public static bool InsertOrUpdatePhoiIP_VatTuCTTM(MDB.MDBConnection MyConnection, PhoiIP_VatTuCTTM _PhoiIP_VatTuCTTM)
        {
            try
            {
                string sql = @"INSERT INTO PhoiIP_VatTuCTTM
                (
                    ID_Phieu,
                    STT,
                    TenDungCu,
                    DonViVatTu,
                    SoLuongVatTu,
                    HangVatTu)  VALUES
                 (
				    :ID_Phieu,
                    :STT,
                    :TenDungCu,
                    :DonViVatTu,
                    :SoLuongVatTu,
                    :HangVatTu
                 )";
                if (_PhoiIP_VatTuCTTM.ID != 0)
                {
                    sql = @"UPDATE PhoiIP_VatTuCTTM SET 
                    ID_Phieu = :ID_Phieu,
                    STT = :STT,
                    TenDungCu = :TenDungCu,
                    DonViVatTu = :DonViVatTu,
                    SoLuongVatTu = :SoLuongVatTu,
                    HangVatTu = :HangVatTu
                    WHERE ID = " + _PhoiIP_VatTuCTTM.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID_Phieu", _PhoiIP_VatTuCTTM.ID_Phieu));
                Command.Parameters.Add(new MDB.MDBParameter("STT", _PhoiIP_VatTuCTTM.STT));
                Command.Parameters.Add(new MDB.MDBParameter("TenDungCu", _PhoiIP_VatTuCTTM.TenDungCu));
                Command.Parameters.Add(new MDB.MDBParameter("DonViVatTu", _PhoiIP_VatTuCTTM.DonViVatTu));
                Command.Parameters.Add(new MDB.MDBParameter("SoLuongVatTu", _PhoiIP_VatTuCTTM.SoLuongVatTu));
                Command.Parameters.Add(new MDB.MDBParameter("HangVatTu", _PhoiIP_VatTuCTTM.HangVatTu));
                
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

        public static ObservableCollection<PhoiIP_ThuocCTTM> GetPhoiIP_ThuocCTTM(MDB.MDBConnection _OracleConnection, long idPhieu)
        {
            ObservableCollection<PhoiIP_ThuocCTTM> PhoiIP_ThuocCTTMs = new ObservableCollection<PhoiIP_ThuocCTTM>();
            try
            {
                string sql = @"SELECT * FROM PhoiIP_ThuocCTTM where ID_Phieu = :ID_Phieu ORDER BY ID asc";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID_Phieu", idPhieu));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhoiIP_ThuocCTTM data = new PhoiIP_ThuocCTTM();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.ID_Phieu = idPhieu;

                    data.TenThuoc = DataReader["TenThuoc"].ToString();
                    data.DonViThuoc = DataReader["DonViThuoc"].ToString();
                    data.SoLuongThuoc = DataReader["SoLuongThuoc"].ToString();
                    data.TenHangDungCu = DataReader["TenHangDungCu"].ToString();
                    data.DonViDungCu = DataReader["DonViDungCu"].ToString();
                    data.SoLuongDungCu = DataReader["SoLuongDungCu"].ToString();

                    PhoiIP_ThuocCTTMs.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return PhoiIP_ThuocCTTMs;
        }
        public static bool DeletePhoiIP_ThuocCTTM(MDB.MDBConnection MyConnection, long id)
        {
            try
            {
                string sql = "DELETE FROM PhoiIP_ThuocCTTM WHERE ID = :ID";
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
        public static bool InsertOrUpdatePhoiIP_ThuocCTTM(MDB.MDBConnection MyConnection, PhoiIP_ThuocCTTM _PhoiIP_ThuocCTTM)
        {
            try
            {
                string sql = @"INSERT INTO PhoiIP_ThuocCTTM
                (
                    ID_Phieu,
                    TenThuoc,
                    DonViThuoc,
                    SoLuongThuoc,
                    TenHangDungCu,
                    DonViDungCu,
                    SoLuongDungCu)  VALUES
                 (
				    :ID_Phieu,
                    :TenThuoc,
                    :DonViThuoc,
                    :SoLuongThuoc,
                    :TenHangDungCu,
                    :DonViDungCu,
                    :SoLuongDungCu
                 )";
                if (_PhoiIP_ThuocCTTM.ID != 0)
                {
                    sql = @"UPDATE PhoiIP_ThuocCTTM SET 
                    ID_Phieu = :ID_Phieu,
                    TenThuoc = :TenThuoc,
                    DonViThuoc = :DonViThuoc,
                    SoLuongThuoc = :SoLuongThuoc,
                    TenHangDungCu = :TenHangDungCu,
                    DonViDungCu = :DonViDungCu,
                    SoLuongDungCu = :SoLuongDungCu
                    WHERE ID = " + _PhoiIP_ThuocCTTM.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID_Phieu", _PhoiIP_ThuocCTTM.ID_Phieu));
                Command.Parameters.Add(new MDB.MDBParameter("TenThuoc", _PhoiIP_ThuocCTTM.TenThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("DonViThuoc", _PhoiIP_ThuocCTTM.DonViThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("SoLuongThuoc", _PhoiIP_ThuocCTTM.SoLuongThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("TenHangDungCu", _PhoiIP_ThuocCTTM.TenHangDungCu));
                Command.Parameters.Add(new MDB.MDBParameter("DonViDungCu", _PhoiIP_ThuocCTTM.DonViDungCu));
                Command.Parameters.Add(new MDB.MDBParameter("SoLuongDungCu", _PhoiIP_ThuocCTTM.SoLuongDungCu));

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
