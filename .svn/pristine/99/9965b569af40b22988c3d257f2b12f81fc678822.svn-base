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
    public class PhieuTomTatQuaTrinhDieuTri : ThongTinKy
    {
        public PhieuTomTatQuaTrinhDieuTri()
        {
            TableName = "PhieuTomTatQuaTrinhDieuTri";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PTTQTDT;
            TenMauPhieu = DanhMucPhieu.PTTQTDT.Description();
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
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public DateTime DieuTriTuNgay { get; set; }
        public DateTime DieuTriDenNgay { get; set; }
        public string[] TTBNKhiVaoKhoa { get; set; } = new string[1];
        public string[] DBLSTaiKhoa { get; set; } = new string[1];
        public string[] QTDTTaiKhoa { get; set; } = new string[1];
        public int SoNgayDieuTri { get; set; }
        public string[] TTHienTai { get; set; } = new string[1];
        public int NhietDo { get; set; }
        public int NhipTim { get; set; }
        [MoTaDuLieu("Huyết áp")]
		public string HuyetAp { get; set; }
        public int MucLocCauThan { get; set; }
        public DateTime HoiChanBenhVien { get; set; }
        public int BiLanPhauThuat { get; set; }
        public string[] LuuY { get; set; } = new string[1];
        public string ChuyenKhoa { get; set; }
        public int PTTheoLich { get; set; }
        public int TheoDoiDieuTriTiep { get; set; }
        public DateTime DuKienPhauThuat { get; set; }
        public string PhauThuatVien { get; set; }
        public string MaNVPhauThuatVien { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuongKiemSoat { get; set; }
        public string MaNVDieuDuongKiemSoat { get; set; }
        public DateTime ThoiGianThucHien { get; set; }
        [MoTaDuLieu("Bác sỹ điều trị")]
		public string BacSyDieuTri { get; set; }
        public string MaNVBacSyDieuTri { get; set; }
        public int DieuDuongKS_DT { get; set; }
        [MoTaDuLieu("Trưởng khoa")]
		public string TruongKhoa { get; set; }
        [MoTaDuLieu("Mã trưởng khoa")]
		public string MaNVTruongKhoa { get; set; }

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
    public class PhieuTomTatQuaTrinhDieuTriFunc
    {
        public const string TableName = "PhieuTomTatQuaTrinhDieuTri";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuTomTatQuaTrinhDieuTri> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuTomTatQuaTrinhDieuTri> list = new List<PhieuTomTatQuaTrinhDieuTri>();
            try
            {

                string sql = @"SELECT * FROM PhieuTomTatQuaTrinhDieuTri where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    try
                    {
                        PhieuTomTatQuaTrinhDieuTri data = new PhieuTomTatQuaTrinhDieuTri();
                        data.ID = DataReader.GetLong("id");
                        data.MaQuanLy = DataReader.GetDecimal("maquanly");
                        data.MaBenhNhan = DataReader.GetString("mabenhnhan");
                        data.TenBenhNhan = DataReader.GetString("tenbenhnhan");
                        data.Tuoi = DataReader.GetString("tuoi");
                        data.Khoa = DataReader.GetString("khoa");
                        data.GioiTinh = DataReader.GetString("gioitinh");
                        data.ChanDoan = DataReader.GetString("chandoan");
                        data.DieuTriTuNgay = ConDB_DateTime(DataReader["dieutritungay"]);
                        data.DieuTriDenNgay = ConDB_DateTime(DataReader["dieutridenngay"]);
                        data.TTBNKhiVaoKhoa = JsonConvert.DeserializeObject<string[]>(DataReader.GetString("ttbnkhivaokhoa"));
                        data.DBLSTaiKhoa = JsonConvert.DeserializeObject<string[]>(DataReader.GetString("dblstaikhoa"));
                        data.QTDTTaiKhoa = JsonConvert.DeserializeObject<string[]>(DataReader.GetString("qtdttaikhoa"));
                        data.SoNgayDieuTri = DataReader.GetInt("songaydieutri");
                        data.TTHienTai = JsonConvert.DeserializeObject<string[]>(DataReader.GetString("tthientai"));
                        data.NhietDo = DataReader.GetInt("nhietdo");
                        data.NhipTim = DataReader.GetInt("nhiptim");
                        data.HuyetAp = DataReader.GetString("huyetap");
                        data.MucLocCauThan = DataReader.GetInt("mucloccauthan");
                        data.HoiChanBenhVien = ConDB_DateTime(DataReader["hoichanbenhvien"]);
                        data.BiLanPhauThuat = DataReader.GetInt("bilanphauthuat");
                        data.LuuY = JsonConvert.DeserializeObject<string[]>(DataReader.GetString("luuy"));
                        data.ChuyenKhoa = DataReader.GetString("chuyenkhoa");
                        data.PTTheoLich = DataReader.GetInt("pttheolich");
                        data.TheoDoiDieuTriTiep = DataReader.GetInt("theodoidieutritiep");
                        data.DuKienPhauThuat = ConDB_DateTime(DataReader["dukienphauthuat"]);
                        data.PhauThuatVien = DataReader.GetString("phauthuatvien");
                        data.MaNVPhauThuatVien = DataReader.GetString("manvphauthuatvien");
                        data.DieuDuongKiemSoat = DataReader.GetString("dieuduongkiemsoat");
                        data.MaNVDieuDuongKiemSoat = DataReader.GetString("manvdieuduongkiemsoat");
                        data.DieuDuongKS_DT = DataReader.GetInt("dieuduongks_dt");
                        data.BacSyDieuTri = DataReader.GetString("bacsydieutri");
                        data.MaNVBacSyDieuTri = DataReader.GetString("manvbacsydieutri");
                        data.TruongKhoa = DataReader.GetString("truongkhoa");
                        data.MaNVTruongKhoa = DataReader.GetString("manvtruongkhoa");
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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuTomTatQuaTrinhDieuTri objData)
        {
            string sql;
            int n = 0;
            if (objData.ID == 0)
            {
                sql = @"INSERT INTO PhieuTomTatQuaTrinhDieuTri (
                                    maquanly,
                                    mabenhnhan,
                                    tenbenhnhan,
                                    tuoi,
                                    khoa,
                                    gioitinh,
                                    chandoan,
                                    dieutritungay,
                                    dieutridenngay,
                                    ttbnkhivaokhoa,
                                    dblstaikhoa,
                                    qtdttaikhoa,
                                    songaydieutri,
                                    tthientai,
                                    nhietdo,
                                    nhiptim,
                                    huyetap,
                                    mucloccauthan,
                                    hoichanbenhvien,
                                    bilanphauthuat,
                                    luuy,
                                    chuyenkhoa,
                                    pttheolich,
                                    theodoidieutritiep,
                                    dukienphauthuat,
                                    phauthuatvien,
                                    manvphauthuatvien,
                                    dieuduongkiemsoat,
                                    manvdieuduongkiemsoat,
                                    dieuduongks_dt,
                                    thoigianthuchien,
                                    bacsydieutri,
                                    manvbacsydieutri,
                                    truongkhoa,
                                    manvtruongkhoa,
                                    nguoitao,
                                    ngaytao
                                ) VALUES (
                                        :maquanly,
                                        :mabenhnhan,
                                        :tenbenhnhan,
                                        :tuoi,
                                        :khoa,
                                        :gioitinh,
                                        :chandoan,
                                        :dieutritungay,
                                        :dieutridenngay,
                                        :ttbnkhivaokhoa,
                                        :dblstaikhoa,
                                        :qtdttaikhoa,
                                        :songaydieutri,
                                        :tthientai,
                                        :nhietdo,
                                        :nhiptim,
                                        :huyetap,
                                        :mucloccauthan,
                                        :hoichanbenhvien,
                                        :bilanphauthuat,
                                        :luuy,
                                        :chuyenkhoa,
                                        :pttheolich,
                                        :theodoidieutritiep,
                                        :dukienphauthuat,
                                        :phauthuatvien,
                                        :manvphauthuatvien,
                                        :dieuduongkiemsoat,
                                        :manvdieuduongkiemsoat,
                                        :dieuduongks_dt,
                                        :thoigianthuchien,
                                        :bacsydieutri,
                                        :manvbacsydieutri,
                                        :truongkhoa,
                                        :manvtruongkhoa,
                                        :nguoitao,
                                        :ngaytao 
                                ) RETURNING ID INTO :ID";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("maquanly", objData.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("mabenhnhan", objData.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("tenbenhnhan", objData.TenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("tuoi", objData.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("khoa", objData.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("gioitinh", objData.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("chandoan", objData.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("dieutritungay", objData.DieuTriTuNgay));
                Command.Parameters.Add(new MDB.MDBParameter("dieutridenngay", objData.DieuTriDenNgay));
                Command.Parameters.Add(new MDB.MDBParameter("ttbnkhivaokhoa", JsonConvert.SerializeObject(objData.TTBNKhiVaoKhoa)));
                Command.Parameters.Add(new MDB.MDBParameter("dblstaikhoa", JsonConvert.SerializeObject(objData.DBLSTaiKhoa)));
                Command.Parameters.Add(new MDB.MDBParameter("qtdttaikhoa", JsonConvert.SerializeObject(objData.QTDTTaiKhoa)));
                Command.Parameters.Add(new MDB.MDBParameter("songaydieutri", objData.SoNgayDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("tthientai", JsonConvert.SerializeObject(objData.TTHienTai)));
                Command.Parameters.Add(new MDB.MDBParameter("nhietdo", objData.NhietDo));
                Command.Parameters.Add(new MDB.MDBParameter("nhiptim", objData.NhipTim));
                Command.Parameters.Add(new MDB.MDBParameter("huyetap", objData.HuyetAp));
                Command.Parameters.Add(new MDB.MDBParameter("mucloccauthan", objData.MucLocCauThan));
                Command.Parameters.Add(new MDB.MDBParameter("hoichanbenhvien", objData.HoiChanBenhVien));
                Command.Parameters.Add(new MDB.MDBParameter("bilanphauthuat", objData.BiLanPhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("luuy", JsonConvert.SerializeObject(objData.LuuY)));
                Command.Parameters.Add(new MDB.MDBParameter("chuyenkhoa", objData.ChuyenKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("pttheolich", objData.PTTheoLich));
                Command.Parameters.Add(new MDB.MDBParameter("theodoidieutritiep", objData.TheoDoiDieuTriTiep));
                Command.Parameters.Add(new MDB.MDBParameter("dukienphauthuat", objData.DuKienPhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("phauthuatvien", objData.PhauThuatVien));
                Command.Parameters.Add(new MDB.MDBParameter("manvphauthuatvien", objData.MaNVPhauThuatVien));
                Command.Parameters.Add(new MDB.MDBParameter("dieuduongkiemsoat", objData.DieuDuongKiemSoat));
                Command.Parameters.Add(new MDB.MDBParameter("manvdieuduongkiemsoat", objData.MaNVDieuDuongKiemSoat));
                Command.Parameters.Add(new MDB.MDBParameter("dieuduongks_dt", objData.DieuDuongKS_DT));
                Command.Parameters.Add(new MDB.MDBParameter("thoigianthuchien", objData.ThoiGianThucHien));
                Command.Parameters.Add(new MDB.MDBParameter("bacsydieutri", objData.BacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("manvbacsydieutri", objData.MaNVBacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("truongkhoa", objData.TruongKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("manvtruongkhoa", objData.MaNVTruongKhoa));
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
                sql = @"UPDATE PhieuTomTatQuaTrinhDieuTri SET  
                                        	maquanly=:maquanly,
                                            mabenhnhan=:mabenhnhan,
                                            tenbenhnhan=:tenbenhnhan,
                                            tuoi=:tuoi,
                                            khoa=:khoa,
                                            gioitinh=:gioitinh,
                                            chandoan=:chandoan,
                                            dieutritungay=:dieutritungay,
                                            dieutridenngay=:dieutridenngay,
                                            ttbnkhivaokhoa=:ttbnkhivaokhoa,
                                            dblstaikhoa=:dblstaikhoa,
                                            qtdttaikhoa=:qtdttaikhoa,
                                            songaydieutri=:songaydieutri,
                                            tthientai=:tthientai,
                                            nhietdo=:nhietdo,
                                            nhiptim=:nhiptim,
                                            huyetap=:huyetap,
                                            mucloccauthan=:mucloccauthan,
                                            hoichanbenhvien=:hoichanbenhvien,
                                            bilanphauthuat=:bilanphauthuat,
                                            luuy=:luuy,
                                            chuyenkhoa=:chuyenkhoa,
                                            pttheolich=:pttheolich,
                                            theodoidieutritiep=:theodoidieutritiep,
                                            dukienphauthuat=:dukienphauthuat,
                                            phauthuatvien=:phauthuatvien,
                                            manvphauthuatvien=:manvphauthuatvien,
                                            dieuduongkiemsoat=:dieuduongkiemsoat,
                                            manvdieuduongkiemsoat=:manvdieuduongkiemsoat,
                                            dieuduongks_dt=:dieuduongks_dt,
                                            thoigianthuchien=:thoigianthuchien,
                                            bacsydieutri=:bacsydieutri,
                                            manvbacsydieutri=:manvbacsydieutri,
                                            truongkhoa=:truongkhoa,
                                            manvtruongkhoa=:manvtruongkhoa,
                                            nguoisua = :nguoisua,
                                            ngaysua = :ngaysua 
                                        WHERE ID = :IDPhieu";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("maquanly", objData.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("mabenhnhan", objData.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("tenbenhnhan", objData.TenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("tuoi", objData.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("khoa", objData.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("gioitinh", objData.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("chandoan", objData.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("dieutritungay", objData.DieuTriTuNgay));
                Command.Parameters.Add(new MDB.MDBParameter("dieutridenngay", objData.DieuTriDenNgay));
                Command.Parameters.Add(new MDB.MDBParameter("ttbnkhivaokhoa", JsonConvert.SerializeObject(objData.TTBNKhiVaoKhoa)));
                Command.Parameters.Add(new MDB.MDBParameter("dblstaikhoa", JsonConvert.SerializeObject(objData.DBLSTaiKhoa)));
                Command.Parameters.Add(new MDB.MDBParameter("qtdttaikhoa", JsonConvert.SerializeObject(objData.QTDTTaiKhoa)));
                Command.Parameters.Add(new MDB.MDBParameter("songaydieutri", objData.SoNgayDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("tthientai", JsonConvert.SerializeObject(objData.TTHienTai)));
                Command.Parameters.Add(new MDB.MDBParameter("nhietdo", objData.NhietDo));
                Command.Parameters.Add(new MDB.MDBParameter("nhiptim", objData.NhipTim));
                Command.Parameters.Add(new MDB.MDBParameter("huyetap", objData.HuyetAp));
                Command.Parameters.Add(new MDB.MDBParameter("mucloccauthan", objData.MucLocCauThan));
                Command.Parameters.Add(new MDB.MDBParameter("hoichanbenhvien", objData.HoiChanBenhVien));
                Command.Parameters.Add(new MDB.MDBParameter("bilanphauthuat", objData.BiLanPhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("luuy", JsonConvert.SerializeObject(objData.LuuY)));
                Command.Parameters.Add(new MDB.MDBParameter("chuyenkhoa", objData.ChuyenKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("pttheolich", objData.PTTheoLich));
                Command.Parameters.Add(new MDB.MDBParameter("theodoidieutritiep", objData.TheoDoiDieuTriTiep));
                Command.Parameters.Add(new MDB.MDBParameter("dukienphauthuat", objData.DuKienPhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("phauthuatvien", objData.PhauThuatVien));
                Command.Parameters.Add(new MDB.MDBParameter("manvphauthuatvien", objData.MaNVPhauThuatVien));
                Command.Parameters.Add(new MDB.MDBParameter("dieuduongkiemsoat", objData.DieuDuongKiemSoat));
                Command.Parameters.Add(new MDB.MDBParameter("manvdieuduongkiemsoat", objData.MaNVDieuDuongKiemSoat));
                Command.Parameters.Add(new MDB.MDBParameter("dieuduongks_dt", objData.DieuDuongKS_DT));
                Command.Parameters.Add(new MDB.MDBParameter("thoigianthuchien", objData.ThoiGianThucHien));
                Command.Parameters.Add(new MDB.MDBParameter("bacsydieutri", objData.BacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("manvbacsydieutri", objData.MaNVBacSyDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("truongkhoa", objData.TruongKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("manvtruongkhoa", objData.MaNVTruongKhoa));
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
            string sql = "DELETE FROM PhieuTomTatQuaTrinhDieuTri WHERE ID = :idPhieu";
            MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
            command.Parameters.Add(new MDB.MDBParameter("idPhieu", idPhieu));
            command.BindByName = true;
            int n = command.ExecuteNonQuery();
            return n > 0 ? true : false;
        }
        public static PhieuTomTatQuaTrinhDieuTri GetData(MDB.MDBConnection _OracleConnection, decimal id)
        {
            try
            {
                string sql = @"SELECT * FROM PhieuTomTatQuaTrinhDieuTri where ID = :ID";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID", id));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    try
                    {
                        PhieuTomTatQuaTrinhDieuTri data = new PhieuTomTatQuaTrinhDieuTri();
                        data.ID = DataReader.GetLong("id");
                        data.MaQuanLy = DataReader.GetDecimal("maquanly");
                        data.MaBenhNhan = DataReader.GetString("mabenhnhan");
                        data.TenBenhNhan = DataReader.GetString("tenbenhnhan");
                        data.Tuoi = DataReader.GetString("tuoi");
                        data.Khoa = DataReader.GetString("khoa");
                        data.GioiTinh = DataReader.GetString("gioitinh");
                        data.ChanDoan = DataReader.GetString("chandoan");
                        data.DieuTriTuNgay = ConDB_DateTime(DataReader["dieutritungay"]);
                        data.DieuTriDenNgay = ConDB_DateTime(DataReader["dieutridenngay"]);
                        data.TTBNKhiVaoKhoa = JsonConvert.DeserializeObject<string[]>(DataReader.GetString("ttbnkhivaokhoa"));
                        data.DBLSTaiKhoa = JsonConvert.DeserializeObject<string[]>(DataReader.GetString("dblstaikhoa"));
                        data.QTDTTaiKhoa = JsonConvert.DeserializeObject<string[]>(DataReader.GetString("qtdttaikhoa"));
                        data.SoNgayDieuTri = DataReader.GetInt("songaydieutri");
                        data.TTHienTai = JsonConvert.DeserializeObject<string[]>(DataReader.GetString("tthientai"));
                        data.NhietDo = DataReader.GetInt("nhietdo");
                        data.NhipTim = DataReader.GetInt("nhiptim");
                        data.HuyetAp = DataReader.GetString("huyetap");
                        data.MucLocCauThan = DataReader.GetInt("mucloccauthan");
                        data.HoiChanBenhVien = ConDB_DateTime(DataReader["hoichanbenhvien"]);
                        data.BiLanPhauThuat = DataReader.GetInt("bilanphauthuat");
                        data.LuuY = JsonConvert.DeserializeObject<string[]>(DataReader.GetString("luuy"));
                        data.ChuyenKhoa = DataReader.GetString("chuyenkhoa");
                        data.PTTheoLich = DataReader.GetInt("pttheolich");
                        data.TheoDoiDieuTriTiep = DataReader.GetInt("theodoidieutritiep");
                        data.DuKienPhauThuat = ConDB_DateTime(DataReader["dukienphauthuat"]);
                        data.PhauThuatVien = DataReader.GetString("phauthuatvien");
                        data.MaNVPhauThuatVien = DataReader.GetString("manvphauthuatvien");
                        data.DieuDuongKiemSoat = DataReader.GetString("dieuduongkiemsoat");
                        data.MaNVDieuDuongKiemSoat = DataReader.GetString("manvdieuduongkiemsoat");
                        data.DieuDuongKS_DT = DataReader.GetInt("dieuduongks_dt");
                        data.BacSyDieuTri = DataReader.GetString("bacsydieutri");
                        data.MaNVBacSyDieuTri = DataReader.GetString("manvbacsydieutri");
                        data.TruongKhoa = DataReader.GetString("truongkhoa");
                        data.MaNVTruongKhoa = DataReader.GetString("manvtruongkhoa");
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
                PhieuTomTatQuaTrinhDieuTri D
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
                B.TTBNKhiVaoKhoa, B.DBLSTaiKhoa, B.QTDTTaiKhoa,B.TTHienTai, B.LuuY
            FROM
                PhieuTomTatQuaTrinhDieuTri B
                
            WHERE
                ID = :D";

            Command = new MDB.MDBCommand(sql2, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("ID", idPhieu));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            string[] arrayTTBNKhiVaoKhoa = new string[3];
            string[] arrayDBLSTaiKhoa = new string[3];
            string[] arrayQTDTTaiKhoa = new string[3];
            string[] arrayTTHienTai = new string[3];
            string[] arrayLuuY = new string[3];

            while (DataReader.Read())
            {
                arrayTTBNKhiVaoKhoa = JsonConvert.DeserializeObject<string[]>(DataReader["TTBNKhiVaoKhoa"].ToString());
                arrayDBLSTaiKhoa = JsonConvert.DeserializeObject<string[]>(DataReader["DBLSTaiKhoa"].ToString());
                arrayQTDTTaiKhoa = JsonConvert.DeserializeObject<string[]>(DataReader["QTDTTaiKhoa"].ToString());
                arrayTTHienTai = JsonConvert.DeserializeObject<string[]>(DataReader["TTHienTai"].ToString());
                arrayLuuY = JsonConvert.DeserializeObject<string[]>(DataReader["LuuY"].ToString());
                break;
            }
            DataTable BK2 = new DataTable("BK2");
            BK2.Columns.Add("TTBNKhiVaoKhoa");
            BK2.Columns.Add("DBLSTaiKhoa");
            BK2.Columns.Add("QTDTTaiKhoa");
            BK2.Columns.Add("TTHienTai");
            BK2.Columns.Add("LuuY");
            BK2.Rows.Add(string.Join("\r\n", arrayTTBNKhiVaoKhoa), string.Join("\r\n", arrayDBLSTaiKhoa), string.Join("\r\n", arrayQTDTTaiKhoa), string.Join("\r\n", arrayTTHienTai), string.Join("\r\n", arrayLuuY));
            
            ds.Tables.Add(BK2);
            return ds;
        }
    }
}
