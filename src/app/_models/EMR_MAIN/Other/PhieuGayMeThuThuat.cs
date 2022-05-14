using EMR.KyDienTu;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    // phần góc dưới bên trái
    public class NoiDungChiTiet
    {
        public int Phut { get; set; }
        public string NoiDung { get; set; }
        public double? TheTich { get; set; }
        public double? TocDoTruyen { get; set; }
        public NoiDungChiTiet Clone(NoiDungChiTiet obj)
        {
            return (NoiDungChiTiet)obj.MemberwiseClone();
        }
    }
    public class ThongTinDanhMuc
    {
        public ThongTinDanhMuc()
        {
            NoiDungChiTiets = new ObservableCollection<NoiDungChiTiet>();
        }
        public string Ten { get; set; }
        public string DonVi { get; set; }
        public ObservableCollection<NoiDungChiTiet> NoiDungChiTiets { get; set; }
        public ThongTinDanhMuc Clone(ThongTinDanhMuc obj)
        {
            ThongTinDanhMuc other = (ThongTinDanhMuc)obj.MemberwiseClone();
            other.NoiDungChiTiets = new ObservableCollection<NoiDungChiTiet>();
            if (this.NoiDungChiTiets != null)
                foreach (NoiDungChiTiet item in this.NoiDungChiTiets)
                {
                    other.NoiDungChiTiets.Add(item.Clone(item));
                }
            return other;
        }
    }
    // phần góc trên bên phải bệnh án
    public class ThongTinPhieuGayMe
    {
        public int CaThu { get; set; }
        public int Phut { get; set; }
        public int? Mach { get; set; }
        public double? HAMax { get; set; }
        public double? HAMin { get; set; }
        public double? NhietDo { get; set; }
        public string FiO2SpO2 { get; set; }
        public ThongTinPhieuGayMe Clone(ThongTinPhieuGayMe obj)
        {
            return (ThongTinPhieuGayMe)obj.MemberwiseClone();
        }
    }

    public class PhieuGayMeThuThuatTbl : ThongTinKy
    {
        public PhieuGayMeThuThuatTbl()
        {
            TableName = "PhieuGayMeThuThuat";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.GMTT;
            TenMauPhieu = DanhMucPhieu.GMTT.Description();
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
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Giường")]
		public string Giuong { get; set; }
        public double? CanNang { get; set; }
        public int? LoaiChiDinh { get; set; }
        public int? LoaiPPVC { get; set; }
        public string NhomGayMe { get; set; }
        public string NhomTHTT { get; set; }
        public DateTime? NgayMo { get; set; }
        public string BacSyGayMe { get; set; }
        public string MaBacSyGayMe { get; set; }

        // update thong tin theo ca, gio
        public ObservableCollection<ThongTinPhieuGayMe> ThongTinChung_Gio1 { get; set; }
        public ObservableCollection<ThongTinPhieuGayMe> ThongTinChung_Gio2 { get; set; }
        public ObservableCollection<ThongTinPhieuGayMe> ThongTinChung_Gio3 { get; set; }
        // thong tin khac can nhap ten
        public ObservableCollection<ThongTinDanhMuc> DichTruyen_Gio1 { get; set; }
        public ObservableCollection<ThongTinDanhMuc> DichTruyen_Gio2 { get; set; }
        public ObservableCollection<ThongTinDanhMuc> DichTruyen_Gio3 { get; set; }

        public ObservableCollection<ThongTinDanhMuc> Thuoc_Gio1 { get; set; }
        public ObservableCollection<ThongTinDanhMuc> Thuoc_Gio2 { get; set; }
        public ObservableCollection<ThongTinDanhMuc> Thuoc_Gio3 { get; set; }

        public ObservableCollection<ThongTinDanhMuc> Khac_Gio1 { get; set; }
        public ObservableCollection<ThongTinDanhMuc> Khac_Gio2 { get; set; }
        public ObservableCollection<ThongTinDanhMuc> Khac_Gio3 { get; set; }
        //
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

    public class PhieuGayMeThuThuatTblFunc
    {
        public const string TableName = "PhieuGayMeThuThuat";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuGayMeThuThuatTbl> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly, decimal IDphieu = -1)
        {
            List<PhieuGayMeThuThuatTbl> list = new List<PhieuGayMeThuThuatTbl>();
            try
            {
                string sql = @"SELECT * FROM PhieuGayMeThuThuat where MaQuanLy = :MaQuanLy";
                if (IDphieu > 0)
                {
                    sql = sql + "  and ID = " + IDphieu.ToString()
;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuGayMeThuThuatTbl data = new PhieuGayMeThuThuatTbl();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = Common.ConDBNull(DataReader["MaBenhNhan"]);
                    data.TenBenhNhan = Common.ConDBNull(DataReader["TenBenhNhan"]);
                    data.Tuoi = Common.ConDBNull(DataReader["Tuoi"]);
                    data.Khoa = Common.ConDBNull(DataReader["Khoa"]);
                    data.MaKhoa = Common.ConDBNull(DataReader["MaKhoa"]);
                    data.GioiTinh = Common.ConDBNull(DataReader["GioiTinh"]);
                    data.Giuong = Common.ConDBNull(DataReader["Giuong"]);
                    data.CanNang = Common.ConDBNull_float(DataReader["CanNang"]);
                    data.ChanDoan = Common.ConDBNull(DataReader["ChanDoan"]);
                    data.LoaiChiDinh = Common.ConDB_IntNull(DataReader["LoaiChiDinh"]);
                    data.LoaiPPVC = Common.ConDB_IntNull(DataReader["LoaiPPVC"]);
                    data.NhomGayMe = Common.ConDBNull(DataReader["NhomGayMe"]);
                    data.NhomTHTT = Common.ConDBNull(DataReader["NhomTHTT"]);
                    data.NgayMo = Common.ConDB_DateTime(DataReader["NgayMo"]);
                    data.BacSyGayMe = Common.ConDBNull(DataReader["BacSyGayMe"]);
                    data.MaBacSyGayMe = Common.ConDBNull(DataReader["MaBacSyGayMe"]);
                    data.ThongTinChung_Gio1 = JsonConvert.DeserializeObject<ObservableCollection<ThongTinPhieuGayMe>>(DataReader["ThongTinChung_Gio1"].ToString());
                    data.ThongTinChung_Gio2 = JsonConvert.DeserializeObject<ObservableCollection<ThongTinPhieuGayMe>>(DataReader["ThongTinChung_Gio2"].ToString());
                    data.ThongTinChung_Gio3 = JsonConvert.DeserializeObject<ObservableCollection<ThongTinPhieuGayMe>>(DataReader["ThongTinChung_Gio3"].ToString());

                    data.DichTruyen_Gio1 = JsonConvert.DeserializeObject<ObservableCollection<ThongTinDanhMuc>>(DataReader["DichTruyen_Gio1"].ToString());
                    data.DichTruyen_Gio2 = JsonConvert.DeserializeObject<ObservableCollection<ThongTinDanhMuc>>(DataReader["DichTruyen_Gio2"].ToString());
                    data.DichTruyen_Gio3 = JsonConvert.DeserializeObject<ObservableCollection<ThongTinDanhMuc>>(DataReader["DichTruyen_Gio3"].ToString());

                    data.Thuoc_Gio1 = JsonConvert.DeserializeObject<ObservableCollection<ThongTinDanhMuc>>(DataReader["Thuoc_Gio1"].ToString());
                    data.Thuoc_Gio2 = JsonConvert.DeserializeObject<ObservableCollection<ThongTinDanhMuc>>(DataReader["Thuoc_Gio2"].ToString());
                    data.Thuoc_Gio3 = JsonConvert.DeserializeObject<ObservableCollection<ThongTinDanhMuc>>(DataReader["Thuoc_Gio3"].ToString());

                    data.Khac_Gio1 = JsonConvert.DeserializeObject<ObservableCollection<ThongTinDanhMuc>>(DataReader["Khac_Gio1"].ToString());
                    data.Khac_Gio2 = JsonConvert.DeserializeObject<ObservableCollection<ThongTinDanhMuc>>(DataReader["Khac_Gio2"].ToString());
                    data.Khac_Gio3 = JsonConvert.DeserializeObject<ObservableCollection<ThongTinDanhMuc>>(DataReader["Khac_Gio3"].ToString());

                    data.NgayTao = Common.ConDB_DateTime(DataReader["NgayTao"]);
                    data.NguoiTao = Common.ConDBNull(DataReader["NguoiTao"]);
                    data.NgaySua = Common.ConDB_DateTime(DataReader["NgaySua"]);
                    data.NguoiSua = Common.ConDBNull(DataReader["NguoiSua"]);

                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;
                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }

            return list;
        }
        public static bool InsertOrUpdatePhieu(MDB.MDBConnection MyConnection, ref PhieuGayMeThuThuatTbl obj)
        {
            try
            {
                string sql = @"INSERT INTO PhieuGayMeThuThuat
                (
                    MaQuanLy,MaBenhNhan,TenBenhNhan,Tuoi,Khoa,MaKhoa,GioiTinh,Giuong,CanNang,ChanDoan,LoaiChiDinh,LoaiPPVC,NhomGayMe,NhomTHTT,NgayMo,BacSyGayMe,MaBacSyGayMe,ThongTinChung_Gio1,ThongTinChung_Gio2,ThongTinChung_Gio3,DichTruyen_Gio1,DichTruyen_Gio2,DichTruyen_Gio3,Thuoc_Gio1,Thuoc_Gio2,Thuoc_Gio3,Khac_Gio1,Khac_Gio2,Khac_Gio3,NgayTao,NguoiTao,NgaySua,NguoiSua
                  )  VALUES (
                    :MaQuanLy, :MaBenhNhan, :TenBenhNhan, :Tuoi, :Khoa, :MaKhoa, :GioiTinh, :Giuong, :CanNang, :ChanDoan, :LoaiChiDinh, :LoaiPPVC, :NhomGayMe, :NhomTHTT, :NgayMo, :BacSyGayMe, :MaBacSyGayMe, :ThongTinChung_Gio1, :ThongTinChung_Gio2, :ThongTinChung_Gio3, :DichTruyen_Gio1, :DichTruyen_Gio2, :DichTruyen_Gio3, :Thuoc_Gio1, :Thuoc_Gio2, :Thuoc_Gio3, :Khac_Gio1, :Khac_Gio2, :Khac_Gio3, :NgayTao, :NguoiTao, :NgaySua, :NguoiSua
                 )  RETURNING ID INTO :ID";
                if (obj.ID != 0)
                {
                    sql = @"UPDATE PhieuGayMeThuThuat SET 
                    MaQuanLy= :MaQuanLy,MaBenhNhan= :MaBenhNhan,TenBenhNhan= :TenBenhNhan,Tuoi= :Tuoi,Khoa= :Khoa,MaKhoa= :MaKhoa,GioiTinh= :GioiTinh,Giuong= :Giuong,CanNang= :CanNang,ChanDoan= :ChanDoan,LoaiChiDinh= :LoaiChiDinh,LoaiPPVC= :LoaiPPVC,NhomGayMe= :NhomGayMe,NhomTHTT= :NhomTHTT,NgayMo= :NgayMo,BacSyGayMe= :BacSyGayMe,MaBacSyGayMe= :MaBacSyGayMe,ThongTinChung_Gio1= :ThongTinChung_Gio1,ThongTinChung_Gio2= :ThongTinChung_Gio2,ThongTinChung_Gio3= :ThongTinChung_Gio3,DichTruyen_Gio1= :DichTruyen_Gio1,DichTruyen_Gio2= :DichTruyen_Gio2,DichTruyen_Gio3= :DichTruyen_Gio3,Thuoc_Gio1= :Thuoc_Gio1,Thuoc_Gio2= :Thuoc_Gio2,Thuoc_Gio3= :Thuoc_Gio3,Khac_Gio1= :Khac_Gio1,Khac_Gio2= :Khac_Gio2,Khac_Gio3= :Khac_Gio3,NgayTao= :NgayTao,NguoiTao= :NguoiTao,NgaySua= :NgaySua,NguoiSua= :NguoiSua
                   WHERE ID = " + obj.ID;
                }
                MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, MyConnection);
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaQuanLy", obj.MaQuanLy));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", obj.MaBenhNhan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenBenhNhan", obj.TenBenhNhan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Tuoi", obj.Tuoi));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Khoa", obj.Khoa));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaKhoa", obj.MaKhoa));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("GioiTinh", obj.GioiTinh));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Giuong", obj.Giuong));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", obj.MaBenhNhan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CanNang", obj.CanNang));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ChanDoan", obj.ChanDoan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("LoaiChiDinh", obj.LoaiChiDinh));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("LoaiPPVC", obj.LoaiPPVC));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NhomGayMe", obj.NhomGayMe));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NhomTHTT", obj.NhomTHTT));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayMo", obj.NgayMo));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("BacSyGayMe", obj.BacSyGayMe));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBacSyGayMe", obj.MaBacSyGayMe));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ThongTinChung_Gio1", JsonConvert.SerializeObject(obj.ThongTinChung_Gio1)));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ThongTinChung_Gio2", JsonConvert.SerializeObject(obj.ThongTinChung_Gio2)));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ThongTinChung_Gio3", JsonConvert.SerializeObject(obj.ThongTinChung_Gio3)));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DichTruyen_Gio1", JsonConvert.SerializeObject(obj.DichTruyen_Gio1)));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DichTruyen_Gio2", JsonConvert.SerializeObject(obj.DichTruyen_Gio2)));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DichTruyen_Gio3", JsonConvert.SerializeObject(obj.DichTruyen_Gio3)));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Thuoc_Gio1", JsonConvert.SerializeObject(obj.Thuoc_Gio1)));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Thuoc_Gio2", JsonConvert.SerializeObject(obj.Thuoc_Gio2)));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Thuoc_Gio3", JsonConvert.SerializeObject(obj.Thuoc_Gio3)));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Khac_Gio1", JsonConvert.SerializeObject(obj.Khac_Gio1)));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Khac_Gio2", JsonConvert.SerializeObject(obj.Khac_Gio2)));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Khac_Gio3", JsonConvert.SerializeObject(obj.Khac_Gio3)));
                if (obj.ID == 0)
                {
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayTao", obj.NgayTao));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiTao", obj.NguoiTao));
                }
                else
                {
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayTao", DateTime.Now));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiTao", Common.getUserLogin()));
                }
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgaySua", DateTime.Now));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiSua", Common.getUserLogin()));
                if (obj.ID == 0)
                {
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ID", obj.ID));
                }
                oracleCommand.BindByName = true;
                int n = oracleCommand.ExecuteNonQuery();
                if (obj.ID == 0)
                {
                    long nextval = Convert.ToInt64((oracleCommand.Parameters["ID"] as MDB.MDBParameter).Value);
                    obj.ID = nextval;
                }
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool deletePhieu(MDB.MDBConnection MyConnection, long id)
        {
            try
            {
                string sql = "DELETE FROM PhieuGayMeThuThuat WHERE ID = :ID";
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
    }
}
