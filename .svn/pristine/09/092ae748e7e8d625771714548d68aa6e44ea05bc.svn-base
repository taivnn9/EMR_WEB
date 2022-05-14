
using EMR.KyDienTu;
using Newtonsoft.Json;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhoiCayMayCTTM : ThongTinKy
    {
        public PhoiCayMayCTTM()
        {
            TableName = "PhoiCayMayCTTM";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PCMCTTM;
            TenMauPhieu = DanhMucPhieu.PCMCTTM.Description();
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
        public ObservableCollection<VatTuCTTM> ListVatTu { get; set; }
        public ObservableCollection<ThuocCTTM> ListThuoc { get; set; }

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

    public class VatTuCTTM
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
        public string GhiChuVatTu { get; set; }
        public static ObservableCollection<VatTuCTTM> CreateListVatTu()
        {
            ObservableCollection<VatTuCTTM> ListVatTu = new ObservableCollection<VatTuCTTM>();
            ListVatTu.Add(new VatTuCTTM { STT = "1", TenDungCu = "Kim chọc dò Introduce", DonViVatTu = "Cái" });
            ListVatTu.Add(new VatTuCTTM { STT = "2", TenDungCu = "Dây điện cực nhĩ/ thất", DonViVatTu = "Cái" });
            ListVatTu.Add(new VatTuCTTM { STT = "3", TenDungCu = "Dây điện cực sốc", DonViVatTu = "Cái" });
            ListVatTu.Add(new VatTuCTTM { STT = "4", TenDungCu = "Dây điện cực thất trái + bộ phụ kiện", DonViVatTu = "Cái" });
            ListVatTu.Add(new VatTuCTTM { STT = "5", TenDungCu = "Máy 1B không đáp ứng", DonViVatTu = "Cái" });
            ListVatTu.Add(new VatTuCTTM { STT = "6", TenDungCu = "Máy 1B có đáp ứng", DonViVatTu = "Cái" });
            ListVatTu.Add(new VatTuCTTM { STT = "7", TenDungCu = "Máy 2B không đáp ứng", DonViVatTu = "Cái" });
            ListVatTu.Add(new VatTuCTTM { STT = "8", TenDungCu = "Máy 2B có đáp ứng", DonViVatTu = "Cái" });
            ListVatTu.Add(new VatTuCTTM { STT = "9", TenDungCu = "Máy 3 buồng", DonViVatTu = "Cái" });
            ListVatTu.Add(new VatTuCTTM { STT = "10", TenDungCu = "Máy phá rung 1B", DonViVatTu = "Cái" });
            ListVatTu.Add(new VatTuCTTM { STT = "11", TenDungCu = "Điện cực tạo nhịp tạm thời", DonViVatTu = "Cái" });
            ListVatTu.Add(new VatTuCTTM { STT = "12", TenDungCu = "Kim chọc mạch", DonViVatTu = "Cái" });
            ListVatTu.Add(new VatTuCTTM { STT = "13", TenDungCu = "Dây dẫn đường cho catheter", DonViVatTu = "Cái" });
            ListVatTu.Add(new VatTuCTTM { STT = "14", TenDungCu = "Dụng cụ mở đường", DonViVatTu = "Cái" });
            ListVatTu.Add(new VatTuCTTM { STT = "15", TenDungCu = "Catheter 4ĐC", DonViVatTu = "Cái" });
            ListVatTu.Add(new VatTuCTTM { STT = "16", TenDungCu = "Cáp 4ĐC", DonViVatTu = "Cái" });

            return ListVatTu;
        }
    }
    public class ThuocCTTM
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
        public static ObservableCollection<ThuocCTTM> CreateListThuoc()
        {
            ObservableCollection<ThuocCTTM> ListThuoc = new ObservableCollection<ThuocCTTM>();
            ListThuoc.Add(new ThuocCTTM { TenThuoc = "A.T Nitroglycerin 5mg/5ml", DonViThuoc = "Lọ", SoLuongThuoc = "1/3", TenHangDungCu = "Băng cuộn 10cm x 7cm", DonViDungCu = "Cái", SoLuongDungCu = "3" });
            ListThuoc.Add(new ThuocCTTM { TenThuoc = "Adrenalin 1mg/1ml", DonViThuoc = "ống", SoLuongThuoc = "", TenHangDungCu = "Băng dính lụa", DonViDungCu = "Cuộn", SoLuongDungCu = "0.2" });
            ListThuoc.Add(new ThuocCTTM { TenThuoc = "Aspirin 81mg", DonViThuoc = "viên", SoLuongThuoc = "", TenHangDungCu = "Bơm tiêm nhựa 10ml", DonViDungCu = "Cái", SoLuongDungCu = "4" });
            ListThuoc.Add(new ThuocCTTM { TenThuoc = "Atropin 0,25mg", DonViThuoc = "ống", SoLuongThuoc = "", TenHangDungCu = "Bơm tiêm nhựa 1ml", DonViDungCu = "Cái", SoLuongDungCu = "1" });
            ListThuoc.Add(new ThuocCTTM { TenThuoc = "Betadin 500ml", DonViThuoc = "Lọ", SoLuongThuoc = "1/2", TenHangDungCu = "Bơm tiêm nhựa 20ml", DonViDungCu = "Cái", SoLuongDungCu = "1" });
            ListThuoc.Add(new ThuocCTTM { TenThuoc = "Diazepham", DonViThuoc = "ống", SoLuongThuoc = "", TenHangDungCu = "Bơm tiêm nhựa 20ml Terumo", DonViDungCu = "Cái", SoLuongDungCu = "" });
            ListThuoc.Add(new ThuocCTTM { TenThuoc = "Dimedron10mg", DonViThuoc = "ống", SoLuongThuoc = "", TenHangDungCu = "Bơm tiêm nhựa 3ml", DonViDungCu = "Cái", SoLuongDungCu = "" });
            ListThuoc.Add(new ThuocCTTM { TenThuoc = "Dobutamine 250mg", DonViThuoc = "Lọ", SoLuongThuoc = "", TenHangDungCu = "Bơm tiêm nhựa 50ml Terumo", DonViDungCu = "Cái", SoLuongDungCu = "" });
            ListThuoc.Add(new ThuocCTTM { TenThuoc = "Fentanyl", DonViThuoc = "ống", SoLuongThuoc = "", TenHangDungCu = "Bơm tiêm nhựa 5ml", DonViDungCu = "Cái", SoLuongDungCu = "1" });
            ListThuoc.Add(new ThuocCTTM { TenThuoc = "Fresofol 1% 20ml", DonViThuoc = "ống", SoLuongThuoc = "", TenHangDungCu = "Dây đo áp lực", DonViDungCu = "Cái", SoLuongDungCu = "1" });
            ListThuoc.Add(new ThuocCTTM { TenThuoc = "Furosemid 20mg", DonViThuoc = "ống", SoLuongThuoc = "", TenHangDungCu = "Dây nối BTĐ các số", DonViDungCu = "Cái", SoLuongDungCu = "" });
            ListThuoc.Add(new ThuocCTTM { TenThuoc = "Heparin 25000UI/5ml", DonViThuoc = "Lọ", SoLuongThuoc = "1/3", TenHangDungCu = "Dây nối dài 30 cm", DonViDungCu = "Cái", SoLuongDungCu = "" });
            ListThuoc.Add(new ThuocCTTM { TenThuoc = "Levonor 1mg/ml", DonViThuoc = "ống", SoLuongThuoc = "", TenHangDungCu = "Dây truyền dịch", DonViDungCu = "Cái", SoLuongDungCu = "1" });
            ListThuoc.Add(new ThuocCTTM { TenThuoc = "Lidocain 200mg", DonViThuoc = "ống", SoLuongThuoc = "1/2", TenHangDungCu = "Điện cực tim", DonViDungCu = "Cái", SoLuongDungCu = "4" });
            ListThuoc.Add(new ThuocCTTM { TenThuoc = "Lovenox", DonViThuoc = "Bơm", SoLuongThuoc = "", TenHangDungCu = "Gạc đã tiệt trùng 12 lớp", DonViDungCu = "Miếng", SoLuongDungCu = "20" });
            ListThuoc.Add(new ThuocCTTM { TenThuoc = "Midarolam 5mg", DonViThuoc = "ống", SoLuongThuoc = "", TenHangDungCu = "Gạc chưa tiệt trùng", DonViDungCu = "Miếng", SoLuongDungCu = "5" });
            ListThuoc.Add(new ThuocCTTM { TenThuoc = "Natriclorua 0,9% 1000ml", DonViThuoc = "Chai", SoLuongThuoc = "2", TenHangDungCu = "Găng tay sạch", DonViDungCu = "Đôi", SoLuongDungCu = "3" });
            ListThuoc.Add(new ThuocCTTM { TenThuoc = "Nerxium 40mg", DonViThuoc = "Lọ", SoLuongThuoc = "", TenHangDungCu = "Găng tay tiệt trùng", DonViDungCu = "Đôi", SoLuongDungCu = "5" });
            ListThuoc.Add(new ThuocCTTM { TenThuoc = "Nicardipin 10mg", DonViThuoc = "ống", SoLuongThuoc = "", TenHangDungCu = "Khóa 3 chạc", DonViDungCu = "Cái", SoLuongDungCu = "1" });
            ListThuoc.Add(new ThuocCTTM { TenThuoc = "Omnipaque 300mg/100ml", DonViThuoc = "Lọ", SoLuongThuoc = "", TenHangDungCu = "Kim lấy thuốc", DonViDungCu = "Cái", SoLuongDungCu = "1" });
            ListThuoc.Add(new ThuocCTTM { TenThuoc = "Osaphin 10mg/1ml", DonViThuoc = "ống", SoLuongThuoc = "", TenHangDungCu = "Kim Luồn", DonViDungCu = "Cái", SoLuongDungCu = "" });
            ListThuoc.Add(new ThuocCTTM { TenThuoc = "Plavic 300mg", DonViThuoc = "Viên", SoLuongThuoc = "", TenHangDungCu = "Lưỡi dao", DonViDungCu = "Cái", SoLuongDungCu = "" });
            ListThuoc.Add(new ThuocCTTM { TenThuoc = "Solumedrol 40mg", DonViThuoc = "Lọ", SoLuongThuoc = "", TenHangDungCu = "Mask thở", DonViDungCu = "Cái", SoLuongDungCu = "" });
            ListThuoc.Add(new ThuocCTTM { TenThuoc = "Vincomid 10mg/2ml", DonViThuoc = "ống", SoLuongThuoc = "", TenHangDungCu = "Mũ Giấy", DonViDungCu = "Cái", SoLuongDungCu = "2" });
            ListThuoc.Add(new ThuocCTTM { TenThuoc = "Xenetix 30mg/100ml", DonViThuoc = "Lọ", SoLuongThuoc = "", TenHangDungCu = "ống thở oxy hai nhánh", DonViDungCu = "Cái", SoLuongDungCu = "" });
            ListThuoc.Add(new ThuocCTTM { TenThuoc = "", DonViThuoc = "", SoLuongThuoc = "", TenHangDungCu = "Optiskin Film 53x80", DonViDungCu = "Cái", SoLuongDungCu = "" });
            ListThuoc.Add(new ThuocCTTM { TenThuoc = "", DonViThuoc = "", SoLuongThuoc = "", TenHangDungCu = "Tấm trải", DonViDungCu = "Cái", SoLuongDungCu = "2" });
            ListThuoc.Add(new ThuocCTTM { TenThuoc = "", DonViThuoc = "", SoLuongThuoc = "", TenHangDungCu = "Túi trùm bóng đèn", DonViDungCu = "Cái", SoLuongDungCu = "2" });
            ListThuoc.Add(new ThuocCTTM { TenThuoc = "", DonViThuoc = "", SoLuongThuoc = "", TenHangDungCu = "Urgocrep4,5*8cm", DonViDungCu = "Cuộn", SoLuongDungCu = "0.4" });
            ListThuoc.Add(new ThuocCTTM { TenThuoc = "", DonViThuoc = "", SoLuongThuoc = "", TenHangDungCu = "W3328", DonViDungCu = "Sợi", SoLuongDungCu = "" });
            ListThuoc.Add(new ThuocCTTM { TenThuoc = "", DonViThuoc = "", SoLuongThuoc = "", TenHangDungCu = "W9121", DonViDungCu = "Sợi", SoLuongDungCu = "" });

            return ListThuoc;
        }

    }

    public class PhoiCayMayCTTMFunc
    {
        public const string TableName = "PhoiCayMayCTTM";
        public const string TablePrimaryKeyName = "ID";

        public static List<PhoiCayMayCTTM> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhoiCayMayCTTM> list = new List<PhoiCayMayCTTM>();
            try
            {
                string sql = @"SELECT * FROM PhoiCayMayCTTM where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhoiCayMayCTTM data = new PhoiCayMayCTTM();
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

                    data.ListThuoc = GetThuocCTTM(_OracleConnection, data.ID);
                    data.ListVatTu = GetVatTuCTTM(_OracleConnection, data.ID);

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
                sql = @"DELETE FROM PhoiCayMayCTTM WHERE ID =" + IDBienBan;
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
                PhoiCayMayCTTM P
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
            VT.Columns.Add("GhiChuVatTu", typeof(string));


            ObservableCollection<VatTuCTTM> ListVatTu = GetVatTuCTTM(MyConnection, IDBienBan);
            if (ListVatTu != null)
            {
                foreach (VatTuCTTM _VatTu in ListVatTu)
                {
                    VT.Rows.Add(_VatTu.STT, _VatTu.TenDungCu, _VatTu.DonViVatTu, _VatTu.SoLuongVatTu, _VatTu.HangVatTu, _VatTu.GhiChuVatTu);
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


            ObservableCollection<ThuocCTTM> ListThuocCTTM = GetThuocCTTM(MyConnection, IDBienBan);
            if (ListThuocCTTM != null)
            {
                foreach (ThuocCTTM _Thuoc in ListThuocCTTM)
                {
                    T.Rows.Add(_Thuoc.TenThuoc, _Thuoc.DonViThuoc, _Thuoc.SoLuongThuoc, _Thuoc.TenHangDungCu, _Thuoc.DonViDungCu, _Thuoc.SoLuongDungCu);
                }
            }
            ds.Tables.Add(T);

            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhoiCayMayCTTM ketQua)
        {
            try
            {
                string sql = @"INSERT INTO PhoiCayMayCTTM
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
                    sql = @"UPDATE PhoiCayMayCTTM SET 
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

        public static ObservableCollection<VatTuCTTM> GetVatTuCTTM(MDB.MDBConnection _OracleConnection, long idPhieu)
        {
            ObservableCollection<VatTuCTTM> VatTuCTTMs = new ObservableCollection<VatTuCTTM>();
            try
            {
                string sql = @"SELECT * FROM VatTuCTTM where ID_Phieu = :ID_Phieu ORDER BY ID asc";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID_Phieu", idPhieu));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    VatTuCTTM data = new VatTuCTTM();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.ID_Phieu = idPhieu;

                    data.STT = DataReader["STT"].ToString();
                    data.TenDungCu = DataReader["TenDungCu"].ToString();
                    data.DonViVatTu = DataReader["DonViVatTu"].ToString();
                    data.SoLuongVatTu = DataReader["SoLuongVatTu"].ToString();
                    data.HangVatTu = DataReader["HangVatTu"].ToString();
                    data.GhiChuVatTu = DataReader["GhiChuVatTu"].ToString();

                    VatTuCTTMs.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return VatTuCTTMs;
        }
        public static bool DeleteVatTuCTTM(MDB.MDBConnection MyConnection, long id)
        {
            try
            {
                string sql = "DELETE FROM VatTuCTTM WHERE ID = :ID";
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
        public static bool InsertOrUpdateVatTuCTTM(MDB.MDBConnection MyConnection, VatTuCTTM _VatTuCTTM)
        {
            try
            {
                string sql = @"INSERT INTO VatTuCTTM
                (
                    ID_Phieu,
                    STT,
                    TenDungCu,
                    DonViVatTu,
                    SoLuongVatTu,
                    HangVatTu,
                    GhiChuVatTu)  VALUES
                 (
				    :ID_Phieu,
                    :STT,
                    :TenDungCu,
                    :DonViVatTu,
                    :SoLuongVatTu,
                    :HangVatTu,
                    :GhiChuVatTu
                 )";
                if (_VatTuCTTM.ID != 0)
                {
                    sql = @"UPDATE VatTuCTTM SET 
                    ID_Phieu = :ID_Phieu,
                    STT = :STT,
                    TenDungCu = :TenDungCu,
                    DonViVatTu = :DonViVatTu,
                    SoLuongVatTu = :SoLuongVatTu,
                    HangVatTu = :HangVatTu,
                    GhiChuVatTu = :GhiChuVatTu
                    WHERE ID = " + _VatTuCTTM.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID_Phieu", _VatTuCTTM.ID_Phieu));
                Command.Parameters.Add(new MDB.MDBParameter("STT", _VatTuCTTM.STT));
                Command.Parameters.Add(new MDB.MDBParameter("TenDungCu", _VatTuCTTM.TenDungCu));
                Command.Parameters.Add(new MDB.MDBParameter("DonViVatTu", _VatTuCTTM.DonViVatTu));
                Command.Parameters.Add(new MDB.MDBParameter("SoLuongVatTu", _VatTuCTTM.SoLuongVatTu));
                Command.Parameters.Add(new MDB.MDBParameter("HangVatTu", _VatTuCTTM.HangVatTu));
                Command.Parameters.Add(new MDB.MDBParameter("GhiChuVatTu", _VatTuCTTM.GhiChuVatTu));
                
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

        public static ObservableCollection<ThuocCTTM> GetThuocCTTM(MDB.MDBConnection _OracleConnection, long idPhieu)
        {
            ObservableCollection<ThuocCTTM> ThuocCTTMs = new ObservableCollection<ThuocCTTM>();
            try
            {
                string sql = @"SELECT * FROM ThuocCTTM where ID_Phieu = :ID_Phieu ORDER BY ID asc";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID_Phieu", idPhieu));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    ThuocCTTM data = new ThuocCTTM();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.ID_Phieu = idPhieu;

                    data.TenThuoc = DataReader["TenThuoc"].ToString();
                    data.DonViThuoc = DataReader["DonViThuoc"].ToString();
                    data.SoLuongThuoc = DataReader["SoLuongThuoc"].ToString();
                    data.TenHangDungCu = DataReader["TenHangDungCu"].ToString();
                    data.DonViDungCu = DataReader["DonViDungCu"].ToString();
                    data.SoLuongDungCu = DataReader["SoLuongDungCu"].ToString();

                    ThuocCTTMs.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return ThuocCTTMs;
        }
        public static bool DeleteThuocCTTM(MDB.MDBConnection MyConnection, long id)
        {
            try
            {
                string sql = "DELETE FROM ThuocCTTM WHERE ID = :ID";
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
        public static bool InsertOrUpdateThuocCTTM(MDB.MDBConnection MyConnection, ThuocCTTM _ThuocCTTM)
        {
            try
            {
                string sql = @"INSERT INTO ThuocCTTM
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
                if (_ThuocCTTM.ID != 0)
                {
                    sql = @"UPDATE ThuocCTTM SET 
                    ID_Phieu = :ID_Phieu,
                    TenThuoc = :TenThuoc,
                    DonViThuoc = :DonViThuoc,
                    SoLuongThuoc = :SoLuongThuoc,
                    TenHangDungCu = :TenHangDungCu,
                    DonViDungCu = :DonViDungCu,
                    SoLuongDungCu = :SoLuongDungCu
                    WHERE ID = " + _ThuocCTTM.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID_Phieu", _ThuocCTTM.ID_Phieu));
                Command.Parameters.Add(new MDB.MDBParameter("TenThuoc", _ThuocCTTM.TenThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("DonViThuoc", _ThuocCTTM.DonViThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("SoLuongThuoc", _ThuocCTTM.SoLuongThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("TenHangDungCu", _ThuocCTTM.TenHangDungCu));
                Command.Parameters.Add(new MDB.MDBParameter("DonViDungCu", _ThuocCTTM.DonViDungCu));
                Command.Parameters.Add(new MDB.MDBParameter("SoLuongDungCu", _ThuocCTTM.SoLuongDungCu));

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
