using System;
using System.Collections.Generic;
using System.Data;
using DevExpress.Xpo;
using EMR.KyDienTu;
using Newtonsoft.Json;
using PMS.Access; 

namespace EMR_MAIN.DATABASE.Other
{
    public class ThuocVatTuTieuHaoTrongMo : ThongTinKy
    {
        public ThuocVatTuTieuHaoTrongMo()
        {
            TableName = "THUOCVATTUTIEUHAOTRONGMO";
            TablePrimaryKeyName = "IDTHUOCVATTUTIEUHAOTRONGMO";
            IDMauPhieu = (int)DanhMucPhieu.TVTTM;
            TenMauPhieu = DanhMucPhieu.TVTTM.Description();
        }
        public decimal IdThuocVatTuTieuHaoTrongMo { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        public DateTime NgayMo { get; set; }
        public DateTime? NgayMo_Gio { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public string PhuongPhapPhuatThuat { get; set; }
        public string TuThe { get; set; }
        public string MaBacSyPhauThuat { get; set; }
        public string BacSyPhauThuat { get; set; }
        public string MaBacSyGayMe { get; set; }
        public string BacSyGayMe { get; set; }
        public List<ThuocVatTuTrongMo> ListThuocVatTu1 { get; set; }
        public List<ThuocVatTuTrongMo> ListThuocVatTu2 { get; set; }
        public List<ThuocVatTuTrongMo> ListThuocVatTu3 { get; set; }
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
    public class ThuocVatTuTrongMo
    {
        public string Ma { get; set; }
        public string TenLoai { get; set; }
        public string DonVi { get; set; }
        public string SoLuong { get; set; }
        public static List<ThuocVatTuTrongMo> createDanhSachThuocVatTu1()
        {
            List<ThuocVatTuTrongMo> lstDanhSachVatTu = new List<ThuocVatTuTrongMo>();
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() {  TenLoai = "Fentanyl 0,1mg", DonVi = "ống"});
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() {  TenLoai = "Dolargan 100mg", DonVi = "ống"});
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() {  TenLoai = "Morphin 10mg", DonVi = "ống"});
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() {  TenLoai = "Seduxen 10mg", DonVi = "ống"});
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() {  TenLoai = "Ketamin 50mg/1ml", DonVi = "lọ"});
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() {  TenLoai = "Ephedrrin 10mg", DonVi = "ống"});
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() {  TenLoai = "Propofol 20mg/1ml", DonVi = "ống"});
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() {  TenLoai = "Thiopental 1g", DonVi = "lọ"});
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() {  TenLoai = "Bupivacain 20mg", DonVi = "ống"});
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() {  TenLoai = "Suxamethonium 0.1g", DonVi = "ống"});
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() {  TenLoai = "ArDuan 4mg", DonVi = "lọ"});
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() {  TenLoai = "Neostigmine 0.5mg", DonVi = "ống"});
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() {  TenLoai = "Atropin 0.25mg", DonVi = "ống"});
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() {  TenLoai = "Adrenalin 1mg", DonVi = "ống"});
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() {  TenLoai = "Oxytoxcin 5UI", DonVi = "ống"});
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() {  TenLoai = "Ergometrin 0.2mg", DonVi = "ống"});
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() {  TenLoai = "Lidocain 40mg", DonVi = "ống"});
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() {  TenLoai = "Tranxamin 250mg", DonVi = "ống"});
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() {  TenLoai = "Dimedron", DonVi = "ống"});
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() {  TenLoai = "Canxiclorit 0.5g", DonVi = "ống"});
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() {  TenLoai = "Ouabain 0.25mg", DonVi = "ống"});
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() {  TenLoai = "Methiprednisolon", DonVi = "lọ"});
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() {  TenLoai = "Dopacmin 40mg", DonVi = "ống"});
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() {  TenLoai = "Furocemid 20mg", DonVi = "ống"});
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() {  TenLoai = "Adalat 10mg", DonVi = "V"});
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() {  TenLoai = "Dd Glucoza 5%", DonVi = "chai"});
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() {  TenLoai = "Dd Natriclorua 0.9%", DonVi = "chai"});
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() {  TenLoai = "Dd Ringelactat", DonVi = "chai"});
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() {  TenLoai = "Dd Glucoza 10%", DonVi = "chai"});
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() {  TenLoai = "Dd Hestars", DonVi = "túi"});
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() {  TenLoai = "Nước cất 5ml", DonVi = "ống"});
            return lstDanhSachVatTu;
        }
        public static List<ThuocVatTuTrongMo> createDanhSachThuocVatTu2()
        {
            List<ThuocVatTuTrongMo> lstDanhSachVatTu = new List<ThuocVatTuTrongMo>();
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() { TenLoai = "Dầu Paraphin", DonVi = "ống" });
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() { TenLoai = "Găng VK", DonVi = "đôi" });
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() { TenLoai = "Găng rời", DonVi = "đôi" });
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() { TenLoai = "Bơm tiêm 5ml", DonVi = "cái" });
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() { TenLoai = "Bơm tiêm 10ml", DonVi = "cái" });
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() { TenLoai = "Bơm tiêm 20ml", DonVi = "cái" });
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() { TenLoai = "Bơm tiêm 50ml", DonVi = "cái" });
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() { TenLoai = "Bông", DonVi = "g" });
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() { TenLoai = "Băng cuộn", DonVi = "cuộn" });
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() { TenLoai = "Băng rốn", DonVi = "hộp" });
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() { TenLoai = "Kẹp rốn", DonVi = "cái" });
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() { TenLoai = "Cồn 70 độ", DonVi = "ml" });
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() { TenLoai = "Povidin lod 10%", DonVi = "lọ" });
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() { TenLoai = "Gạc mét", DonVi = "mét" });
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() { TenLoai = "Oxy già 3%", DonVi = "lọ" });
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() { TenLoai = "Dây truyền", DonVi = "cái" });
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() { TenLoai = "Kim luồn", DonVi = "cái" });
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() { TenLoai = "Chỉ Lin", DonVi = "mét" });
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() { TenLoai = "Chỉ Peclon", DonVi = "mét" });
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() { TenLoai = "Chỉ Catgus", DonVi = "vỉ" });
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() { TenLoai = "Chỉ Vincryl 1.0", DonVi = "vỉ" });
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() { TenLoai = "Chỉ Vincryl 2.0", DonVi = "vỉ" });
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() { TenLoai = "Chỉ Vincryl 3.0", DonVi = "vỉ" });
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() { TenLoai = "Chỉ Vincryl 4.0", DonVi = "vỉ" });
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() { TenLoai = "Kim lấy thuốc", DonVi = "cái" });
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() { TenLoai = "Kim tê tủy sống", DonVi = "cái" });
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() { TenLoai = "Ống NKQ số", DonVi = "cái" });
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() { TenLoai = "lưỡi dao", DonVi = "cái" });
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() { TenLoai = "Băng dính vải", DonVi = "cuộn" });
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() { TenLoai = "Băng dính trong", DonVi = "cuộn" });
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() { TenLoai = "Pas điện cựu", DonVi = "cái" });

            return lstDanhSachVatTu;
        }
        public static List<ThuocVatTuTrongMo> createDanhSachThuocVatTu3()
        {
            List<ThuocVatTuTrongMo> lstDanhSachVatTu = new List<ThuocVatTuTrongMo>();
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() { TenLoai = "Dây hút nhớt số", DonVi = "cái" });
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() { TenLoai = "Folay 2 nhánh", DonVi = "cái" });
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() { TenLoai = "Folay 3 nhánh", DonVi = "cái" });
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() { TenLoai = "Túi nước tiểu", DonVi = "cái" });
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() { TenLoai = "Prepspep 0.25g", DonVi = "V" });
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() { TenLoai = "Cloramin B", DonVi = "gói" });
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() { TenLoai = "Dây dẫn silicon", DonVi = "cái" });
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() { TenLoai = "Gạc PT nhỏ", DonVi = "túi" });
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() { TenLoai = "Gạc PT lớn", DonVi = "túi" });
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() { TenLoai = "Gạc miếng", DonVi = "miếng" });
            lstDanhSachVatTu.Add(new ThuocVatTuTrongMo() { TenLoai = "Sonde Netalon", DonVi = "cái" });
            return lstDanhSachVatTu;
        }
    }
    public class ThuocVatTuTieuHoaTrongMoFunc
    {
        public const string TableName = "THUOCVATTUTIEUHAOTRONGMO";
        public const string TablePrimaryKeyName = "IDTHUOCVATTUTIEUHAOTRONGMO";
        public static List<ThuocVatTuTieuHaoTrongMo> getData(decimal maQuanLy, MDB.MDBConnection _OracleConnection)
        {
            List<ThuocVatTuTieuHaoTrongMo> lstData = new List<ThuocVatTuTieuHaoTrongMo>();
            try
            {
                string sql = @"SELECT * FROM THUOCVATTUTIEUHAOTRONGMO where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maQuanLy));
                Command.BindByName = true;
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    ThuocVatTuTieuHaoTrongMo data = new ThuocVatTuTieuHaoTrongMo();
                    data.IdThuocVatTuTieuHaoTrongMo = Convert.ToInt64(DataReader.GetLong("IdThuocVatTuTieuHaoTrongMo").ToString());
                    data.MaQuanLy = maQuanLy;

                    data.NgayMo = Convert.ToDateTime(DataReader["NgayMo"] == DBNull.Value ? DateTime.Now : DataReader["NgayMo"]);
                    data.NgayMo_Gio = data.NgayMo;
                    data.ListThuocVatTu1 = JsonConvert.DeserializeObject<List<ThuocVatTuTrongMo>>(DataReader["ListThuocVatTu1"].ToString());
                    data.ListThuocVatTu2 = JsonConvert.DeserializeObject<List<ThuocVatTuTrongMo>>(DataReader["ListThuocVatTu2"].ToString());
                    data.ListThuocVatTu3 = JsonConvert.DeserializeObject<List<ThuocVatTuTrongMo>>(DataReader["ListThuocVatTu3"].ToString());
                    data.TuThe = DataReader["TuThe"].ToString();
                    data.MaBacSyPhauThuat = DataReader["MaBacSyPhauThuat"].ToString();
                    data.BacSyPhauThuat = DataReader["BacSyPhauThuat"].ToString();
                    data.MaBacSyGayMe = DataReader["MaBacSyGayMe"].ToString();
                    data.BacSyGayMe = DataReader["BacSyGayMe"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.PhuongPhapPhuatThuat = DataReader["PhuongPhapPhuatThuat"].ToString();
                    data.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                    data.NguoiTao = DataReader["NguoiTao"].ToString();
                    data.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);
                    data.NguoiSua = DataReader["NguoiSua"].ToString();

                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;
                    lstData.Add(data);
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return lstData;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref ThuocVatTuTieuHaoTrongMo thuocVatTuTieuHaoTrongMo)
        {
            string sql = @"INSERT INTO THUOCVATTUTIEUHAOTRONGMO
                (
                    MAQUANLY,
                    NGAYMO,
                    CHANDOAN,
                    PHUONGPHAPPHUATTHUAT,
                    TUTHE,
                    MABACSYPHAUTHUAT,
                    BACSYPHAUTHUAT,
                    MABACSYGAYME,
                    BACSYGAYME,
                    LISTTHUOCVATTU1,
                    LISTTHUOCVATTU2,
                    LISTTHUOCVATTU3,
                    NGUOITAO,
                    NGAYTAO,
                    NGUOISUA,
                    NGAYSUA)  VALUES
                 (
                    :MAQUANLY,
                    :NGAYMO,
                    :CHANDOAN,
                    :PHUONGPHAPPHUATTHUAT,
                    :TUTHE,
                    :MABACSYPHAUTHUAT,
                    :BACSYPHAUTHUAT,
                    :MABACSYGAYME,
                    :BACSYGAYME,
                    :LISTTHUOCVATTU1,
                    :LISTTHUOCVATTU2,
                    :LISTTHUOCVATTU3,
                    :NGUOITAO,
                    :NGAYTAO,
                    :NGUOISUA,
                    :NGAYSUA
                )  RETURNING IDTHUOCVATTUTIEUHAOTRONGMO INTO :IDTHUOCVATTUTIEUHAOTRONGMO";
            if (thuocVatTuTieuHaoTrongMo.IdThuocVatTuTieuHaoTrongMo != Decimal.Zero)
            {
                sql = @"UPDATE THUOCVATTUTIEUHAOTRONGMO SET 
                    MAQUANLY = :MAQUANLY,
                    NGAYMO = :NGAYMO,
                    CHANDOAN = :CHANDOAN,
                    PHUONGPHAPPHUATTHUAT = :PHUONGPHAPPHUATTHUAT,
                    TUTHE = :TUTHE,
                    MABACSYPHAUTHUAT = :MABACSYPHAUTHUAT,
                    BACSYPHAUTHUAT = :BACSYPHAUTHUAT,
                    MABACSYGAYME = :MABACSYGAYME,
                    BACSYGAYME = :BACSYGAYME,
                    LISTTHUOCVATTU1 = :LISTTHUOCVATTU1,
                    LISTTHUOCVATTU2 = :LISTTHUOCVATTU2,
                    LISTTHUOCVATTU3 = :LISTTHUOCVATTU3,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE IDTHUOCVATTUTIEUHAOTRONGMO = " + thuocVatTuTieuHaoTrongMo.IdThuocVatTuTieuHaoTrongMo;
            }
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", thuocVatTuTieuHaoTrongMo.MaQuanLy));
            var Ngay = thuocVatTuTieuHaoTrongMo.NgayMo.Date.Add(new TimeSpan(0, 0, 0));
            var Gio = thuocVatTuTieuHaoTrongMo.NgayMo_Gio != null ? thuocVatTuTieuHaoTrongMo.NgayMo_Gio.Value.TimeOfDay : DateTime.Now.TimeOfDay;
            var ngayMo = Ngay + Gio;
            Command.Parameters.Add(new MDB.MDBParameter("NGAYMO", ngayMo));
            Command.Parameters.Add(new MDB.MDBParameter("CHANDOAN", thuocVatTuTieuHaoTrongMo.ChanDoan));
            Command.Parameters.Add(new MDB.MDBParameter("PHUONGPHAPPHUATTHUAT", thuocVatTuTieuHaoTrongMo.PhuongPhapPhuatThuat));
            Command.Parameters.Add(new MDB.MDBParameter("LISTTHUOCVATTU1", JsonConvert.SerializeObject(thuocVatTuTieuHaoTrongMo.ListThuocVatTu1)));
            Command.Parameters.Add(new MDB.MDBParameter("LISTTHUOCVATTU2", JsonConvert.SerializeObject(thuocVatTuTieuHaoTrongMo.ListThuocVatTu2)));
            Command.Parameters.Add(new MDB.MDBParameter("LISTTHUOCVATTU3", JsonConvert.SerializeObject(thuocVatTuTieuHaoTrongMo.ListThuocVatTu3)));
            Command.Parameters.Add(new MDB.MDBParameter("TUTHE", thuocVatTuTieuHaoTrongMo.TuThe));
            Command.Parameters.Add(new MDB.MDBParameter("MABACSYPHAUTHUAT", thuocVatTuTieuHaoTrongMo.MaBacSyPhauThuat));
            Command.Parameters.Add(new MDB.MDBParameter("BACSYPHAUTHUAT", thuocVatTuTieuHaoTrongMo.BacSyPhauThuat));
            Command.Parameters.Add(new MDB.MDBParameter("MABACSYGAYME", thuocVatTuTieuHaoTrongMo.MaBacSyGayMe));
            Command.Parameters.Add(new MDB.MDBParameter("BACSYGAYME", thuocVatTuTieuHaoTrongMo.BacSyGayMe));

            Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", thuocVatTuTieuHaoTrongMo.NguoiSua));
            Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", thuocVatTuTieuHaoTrongMo.NgaySua));
            if (thuocVatTuTieuHaoTrongMo.IdThuocVatTuTieuHaoTrongMo.Equals(Decimal.Zero))
            {
                Command.Parameters.Add(new MDB.MDBParameter("IDTHUOCVATTUTIEUHAOTRONGMO", thuocVatTuTieuHaoTrongMo.IdThuocVatTuTieuHaoTrongMo));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", thuocVatTuTieuHaoTrongMo.NguoiTao));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", thuocVatTuTieuHaoTrongMo.NgayTao));
            }
            Command.BindByName = true;
            int n = Command.ExecuteNonQuery(); // C#
            if (thuocVatTuTieuHaoTrongMo.IdThuocVatTuTieuHaoTrongMo.Equals(Decimal.Zero))
            {
                decimal nextval = Convert.ToInt64((Command.Parameters["IDTHUOCVATTUTIEUHAOTRONGMO"] as MDB.MDBParameter).Value);
                thuocVatTuTieuHaoTrongMo.IdThuocVatTuTieuHaoTrongMo = nextval;
            }

            return n > 0 ? true : false;
        }
        public static bool Delete(MDB.MDBConnection MyConnection, decimal id)
        {
            string sql = "DELETE FROM THUOCVATTUTIEUHAOTRONGMO WHERE IDTHUOCVATTUTIEUHAOTRONGMO = :IDTHUOCVATTUTIEUHAOTRONGMO";
            MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
            command.Parameters.Add(new MDB.MDBParameter("IDTHUOCVATTUTIEUHAOTRONGMO", id));
            command.BindByName = true;
            int n = command.ExecuteNonQuery();
            return n > 0 ? true : false;
        }
        public static DataSet getDataSet(MDB.MDBConnection MyConnection, decimal idThuocVatTuTieuHaoTrongMo)
        {
            //var ds = new DataSet();
            // implement code here
            string sql = @"SELECT
                B.NGAYMO,
                B.TUTHE,
                B.CHANDOAN,
                B.PHUONGPHAPPHUATTHUAT,
				B.BACSYPHAUTHUAT,
                B.MABACSYPHAUTHUAT,
				B.BACSYGAYME,
                B.MABACSYGAYME, 
                T.MABENHNHAN,
	            T.SONHAPVIEN,
                T.KHOA,
	            H.TENBENHNHAN,
                H.DOITUONG,
	            H.TUOI,
				H.SONHA,
				H.THONPHO,
				H.XAPHUONG,
				H.HUYENQUAN,
				H.TINHTHANHPHO
            FROM
                THUOCVATTUTIEUHAOTRONGMO B
                JOIN THONGTINDIEUTRI T ON B.MAQUANLY = T.MAQUANLY
                JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
            WHERE
                IDTHUOCVATTUTIEUHAOTRONGMO = " + idThuocVatTuTieuHaoTrongMo;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            adt.Fill(ds, "TV");

            sql = @"SELECT LISTTHUOCVATTU1, LISTTHUOCVATTU2, LISTTHUOCVATTU3  FROM THUOCVATTUTIEUHAOTRONGMO where IDTHUOCVATTUTIEUHAOTRONGMO = " + idThuocVatTuTieuHaoTrongMo;
            Command = new MDB.MDBCommand(sql, MyConnection);
            Command.BindByName = true;
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            List<ThuocVatTuTrongMo> listVaTu1 = new List<ThuocVatTuTrongMo>();
            List<ThuocVatTuTrongMo> listVaTu2 = new List<ThuocVatTuTrongMo>();
            List<ThuocVatTuTrongMo> listVaTu3 = new List<ThuocVatTuTrongMo>();
            while (DataReader.Read())
            {
                listVaTu1 = JsonConvert.DeserializeObject<List<ThuocVatTuTrongMo>>(DataReader["LISTTHUOCVATTU1"].ToString());
                listVaTu2 = JsonConvert.DeserializeObject<List<ThuocVatTuTrongMo>>(DataReader["LISTTHUOCVATTU2"].ToString());
                listVaTu3 = JsonConvert.DeserializeObject<List<ThuocVatTuTrongMo>>(DataReader["LISTTHUOCVATTU3"].ToString());
            }
            listVaTu1 = listVaTu1.FindAll(x => !string.IsNullOrEmpty(x.SoLuong));
            listVaTu2 = listVaTu2.FindAll(x => !string.IsNullOrEmpty(x.SoLuong));
            listVaTu3 = listVaTu3.FindAll(x => !string.IsNullOrEmpty(x.SoLuong));

            List<ThuocVatTuTrongMo> listAll = new List<ThuocVatTuTrongMo>();
            listAll.AddRange(listVaTu1);
            listAll.AddRange(listVaTu2);
            listAll.AddRange(listVaTu3);

            DataTable DanhSach = new DataTable("DS");
            DanhSach.Columns.Add("MA1");
            DanhSach.Columns.Add("TENLOAI1");
            DanhSach.Columns.Add("DV1");
            DanhSach.Columns.Add("SL1");

            DanhSach.Columns.Add("MA2");
            DanhSach.Columns.Add("TENLOAI2");
            DanhSach.Columns.Add("DV2");
            DanhSach.Columns.Add("SL2");

            DanhSach.Columns.Add("MA3");
            DanhSach.Columns.Add("TENLOAI3");
            DanhSach.Columns.Add("DV3");
            DanhSach.Columns.Add("SL3");
            if (listAll.Count >= 3)
            {
                for (int i = 0; i < listAll.Count; i += 3)
                {
                    DanhSach.Rows.Add(
                        listAll[i].Ma,
                        listAll[i].TenLoai,
                        listAll[i].DonVi,
                        listAll[i].SoLuong,
                        i + 1 < listAll.Count ? listAll[i + 1].Ma : "",
                        i + 1 < listAll.Count ? listAll[i + 1].TenLoai : "",
                        i + 1 < listAll.Count ? listAll[i + 1].DonVi : "",
                        i + 1 < listAll.Count ? listAll[i + 1].SoLuong : "",
                        i + 2 < listAll.Count ? listAll[i + 2].Ma : "",
                        i + 2 < listAll.Count ? listAll[i + 2].TenLoai : "",
                        i + 2 < listAll.Count ? listAll[i + 2].DonVi : "",
                        i + 2 < listAll.Count ? listAll[i + 2].SoLuong : ""
                    );
                }
            }
            

            ds.Tables.Add(DanhSach);

            DataTable thongTinVien = new DataTable("HEADER");
            thongTinVien.Columns.Add("SOYTE");
            thongTinVien.Columns.Add("BENHVIEN");
            thongTinVien.Columns.Add("KHOA");
			if (XemBenhAn._HanhChinhBenhNhan == null) XemBenhAn._HanhChinhBenhNhan = new HanhChinhBenhNhan();
            if (XemBenhAn._ThongTinDieuTri == null) XemBenhAn._ThongTinDieuTri = new ThongTinDieuTri();
            thongTinVien.Rows.Add(XemBenhAn._HanhChinhBenhNhan.SoYTe, XemBenhAn._HanhChinhBenhNhan.BenhVien, XemBenhAn._ThongTinDieuTri.Khoa);
            ds.Tables.Add(thongTinVien);

            return ds;
        }
    }
}