using DevExpress.XtraReports.UI;
using EMR.KyDienTu;
using EMR_MAIN.InBenhAn;
using MDB;
using Newtonsoft.Json;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using PMS.Access; 

namespace EMR_MAIN.DATABASE.Other
{
    public class ThongTinTruyenDich : ThongTinKy
    {
        public ThongTinTruyenDich()
        {
            TableName = "THONGTINTRUYENDICH";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.TD;
            TenMauPhieu = DanhMucPhieu.TD.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long IDThongTinTruyenDich { get; set; }
        [MoTaDuLieu("Mã định danh")]
		public long IDPhieuThongTinTruyenDich { get; set; }
        public string SoPhieu { get; set; }
        public string MaQuanLy { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Buồng")]
		public string Buong { get; set; }
        [MoTaDuLieu("Giường")]
		public string Giuong { get; set; }
        [MoTaDuLieu("Mã giường")]
		public string MaGiuong { get; set; }
        public bool CapCuu { get; set; }  // save int 1/0

        public long ThoiGianThucHien_Order { get; set; }
        public DateTime ThoiGianThucHien { get; set; }
        public string ThoiGianThucHienFormat24H
        {
            get
            {
                return ThoiGianThucHien.ToString("dd/MM/yyyy HH:mm");
            }
        } // datmc add new for 29830
        public DateTime THOIGIANTHOOXY_BD { get; set; } //tungnd add new for 22309
        public DateTime THOIGIANTHOOXY_KT { get; set; }//tungnd add new for 22309
        [MoTaDuLieu("Người thực hiện")]
		public string NguoiThucHien { get; set; }
        public string MaNVNguoiThucHien { get; set; }
        public float? Mach { get; set; }
        public float NhietDo { get; set; }
        public float HuyetAp_Tren { get; set; }
        public float HuyetAp_Duoi { get; set; }
        public float NhipTho { get; set; }
        public bool ThoMay { get; set; }
        public bool BopBong { get; set; }
        public string TanSo { get; set; }
        public string Glasgow { get; set; }
        public string Dom { get; set; }
        public string DuongMauMaoMach { get; set; }
        public decimal SPO2 { get; set; } //tungnd add new for 22300
        public string DV_DichThuoc { get; set; }
        public string DV_AnUong { get; set; }
        public string DR_NuocTieu { get; set; }
        public string DR_Phan { get; set; }
        public string DR_Khac { get; set; }
        public string DichDanLuuVetMo { get; set; }
        public string DichDaDay { get; set; }
        [MoTaDuLieu("Cân nặng")]
		public string CanNang { get; set; }
        [MoTaDuLieu("Chiều cao")]
		public string ChieuCao { get; set; }
        [MoTaDuLieu("Chỉ số BMI")]
		public string BMI { get; set; }
        public string Bilan { get; set; }

        public string ThoOxy { get; set; }

        public bool CoThoOxyKhong { get; set; }

        public bool MachNhanhNho { get; set; } //tungnd
        public bool IsBoQuaVeDuongMach { get; set; } //tunght
        public bool HAKhongDoDuoc { get; set; }//tungnd

        public List<DauHieuSinhTon> DauHieuSinhTon { get; set; }

        public List<DichTruyen> DichTruyen { get; set; }

        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }

        //public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
        public ThongTinTruyenDich Clone()
        {
            ThongTinTruyenDich other = (ThongTinTruyenDich)this.MemberwiseClone();
            other.DauHieuSinhTon = new List<DauHieuSinhTon>();
            if (this.DauHieuSinhTon != null)
            foreach (DauHieuSinhTon item in this.DauHieuSinhTon)
            {
                other.DauHieuSinhTon.Add(item.Clone());
            }
            other.DichTruyen = new List<DichTruyen>();
            if (this.DichTruyen != null)
                foreach (DichTruyen item in this.DichTruyen)
                {
                    other.DichTruyen.Add(item.Clone());
                }
            return other;
        }
    }

    public class MaHoaDichTruyen : IEquatable<MaHoaDichTruyen>
    {
        public string MaDichTruyen { get; set; }
        public string TenDichTruyen { get; set; }

        public override int GetHashCode()
        {
            int hashMaDichTruyen = MaDichTruyen == null ? 0 : MaDichTruyen.GetHashCode();
            int hashTenDichTruyen = TenDichTruyen == null ? 0 : TenDichTruyen.GetHashCode();
            return hashMaDichTruyen ^ hashTenDichTruyen;
        }

        public bool Equals(MaHoaDichTruyen item)
        {
            if (Object.ReferenceEquals(item, null)) return false;
            if (Object.ReferenceEquals(this, item)) return true;
            if ((item == null && this != null) || (item != null && this == null))
                return false;
            //return this.MaDichTruyen.Equals(item.MaDichTruyen) && this.TenDichTruyen.Equals(item.TenDichTruyen);
            return item.MaDichTruyen == this.MaDichTruyen && item.TenDichTruyen == this.TenDichTruyen;
        }
    }
    public class MaHoaDichTruyen2
    {
        public string MaDichTruyen { get; set; }
        public string TenDichTruyen { get; set; }
        public string SoLuong { get; set; }
        public override string ToString()
        {
            if (string.IsNullOrEmpty(SoLuong))
                return MaDichTruyen;
            return "(" + SoLuong + ")" + MaDichTruyen;
        }
    }
    public class DauHieuSinhTon
    {
        public string TenDauHieu { get; set; }
        public string GiaTri { get; set; }
        public DauHieuSinhTon Clone()
        {
            DauHieuSinhTon other = (DauHieuSinhTon)this.MemberwiseClone();
            return other;
        }
    }
    public class DichTruyen
    {
        public int? DT { get; set; } // so duong truyen ton tai trong 1 phieu
        //public int ViTri { get; set; } // Vi tri Duong Truyen

        [MoTaDuLieu("Mã định danh")]
		public int ID { get; set; }
        public string MaDichTruyen { get; set; }
        public string TenDichTruyen { get; set; }
        public string SoLo { get; set; }
        public float TheTich { get; set; }
        public float TocDoTruyen { get; set; }
        public string LoaiTruyen { get; set; }
        [MoTaDuLieu("Ghi chú")]
		public string GhiChu { get; set; }
        public string GiaTri { get; set; }
        public DateTime ThoiGianBatDau { get; set; }
        public DateTime ThoiGianKetThuc { get; set; }
        public List<string> ThuocPha { get; set; }
        public List<ThuocPha> ThuocPha2 { get; set; }
        public DichTruyen Clone()
        {
            DichTruyen other = (DichTruyen)this.MemberwiseClone();
            other.ThuocPha2 = new List<ThuocPha>();
            if (this.ThuocPha2 != null)
            {
                foreach (ThuocPha item in this.ThuocPha2)
                {
                    other.ThuocPha2.Add(item.Clone());
                }
            }
            return other;
        }
    }

    public class ThuocPha
    {
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        public string TenThuoc { get; set; }
        public string SoLuong { get; set; }
        public ThuocPha() { }
        public ThuocPha(string TenThuoc, string SoLuong)
        {
            this.TenThuoc = TenThuoc;
            this.SoLuong = SoLuong;
        }
        public ThuocPha Clone()
        {
            ThuocPha other = (ThuocPha)this.MemberwiseClone();
            return other;
        }
    }

    public class ThongTinTruyenDichFunc
    {
        static Logger log = LogManager.GetLogger("Log");
        public const string TableName = "thongtintruyendich";
        public const string TablePrimaryKeyName = "idthongtintruyendich";

        public static List<ThuocPha> DanhSachThuocPha = new List<ThuocPha>();


        public List<ThongTinTruyenDich> Select(MDB.MDBConnection MyConnection,string MaQuanLy)
        {
            try
            {
                //using (MDB.MDBConnection MyConnection = new MDB.MDBConnection(ERMDatabase.ConnectionString))
                {

                    // @alinhPQ them giup em truong SPO2 trong db nhe
                    List<ThongTinTruyenDich> listResult = new List<ThongTinTruyenDich>();
                    List<ThongTinChamSoc> lstData = new List<ThongTinChamSoc>();
                    string sql = @"SELECT t.*
                    FROM ThongTinTruyenDich t
                    WHERE t.MaQuanLy = :MaQuanLy AND t.Is_Delete = 0 ORDER BY  t.SoPhieu DESC , t.ThoiGianThucHien DESC"; // datmc update get ThoiGianThucHienForMat24H
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
                    MDB.MDBDataReader DataReader = Command.ExecuteReader();
                    while (DataReader.Read())
                    {
                        var res = new ThongTinTruyenDich();
                        res.IDThongTinTruyenDich = DataReader.GetLong("IDThongTinTruyenDich");
                        res.IDPhieuThongTinTruyenDich = DataReader.GetLong("IDPhieuThongTinTruyenDich");
                        res.MaQuanLy = DataReader["MaQuanLy"].ToString();
                        res.SoPhieu = DataReader["SoPhieu"].ToString();
                        res.ChanDoan = DataReader["ChanDoan"].ToString();
                        res.Khoa = DataReader["Khoa"].ToString();
                        res.Buong = DataReader["Buong"].ToString();
                        res.Giuong = DataReader["Giuong"].ToString();
                        res.MaGiuong = DataReader["MaGiuong"].ToString();
                        res.Tuoi = DataReader["Tuoi"].ToString();
                        res.CapCuu = DataReader["HSTC"].ToString().Trim().Equals("1") ? true : false;
                        try
                        {
                            res.ThoiGianThucHien = DataReader.GetDate("ThoiGianThucHien");
                            res.THOIGIANTHOOXY_BD = DataReader.GetDate("THOIGIANTHOOXY_BD");//tungnd add new for 22309
                            res.THOIGIANTHOOXY_KT = DataReader.GetDate("THOIGIANTHOOXY_KT");//tungnd add new for 22309
                            res.ThoiGianThucHien_Order = Convert.ToInt64(res.ThoiGianThucHien.ToString("yyyyMMddHHmmss"));
                        }
                        catch (Exception ex)
                        {
                            log.Error("Error Check time: '" + ex.Message + "'");
                        }
                        res.NguoiThucHien = DataReader["NguoiThucHien"].ToString();
                        res.MaNVNguoiThucHien = DataReader["MaNVNguoiThucHien"].ToString();
                        // theo dõi
                        res.Mach = Common.ConDBNull_float(DataReader["Mach"]);
                        res.NhietDo = Convert.ToSingle(DataReader["NhietDo"].ToString());
                        res.HuyetAp_Tren = Convert.ToSingle(DataReader["HuyetAp_Tren"].ToString());
                        res.HuyetAp_Duoi = Convert.ToSingle(DataReader["HuyetAp_Duoi"].ToString());

                        res.NhipTho = Convert.ToSingle(DataReader["NhipTho"].ToString());
                        res.ThoMay = DataReader["ThoMay"].ToString().Trim().Equals("1") ? true : false;
                        res.BopBong = DataReader["ThoMay"].ToString().Trim().Equals("2") ? true : false;
                        res.TanSo = DataReader["TanSo"].ToString();
                        res.Glasgow = DataReader["Glasgow"].ToString();
                        res.Dom = DataReader["Dom"].ToString();
                        res.DuongMauMaoMach = DataReader["DuongMauMaoMach"].ToString();
                        res.SPO2 = DataReader.GetDecimal("SPO2");

                        res.DV_DichThuoc = DataReader["DV_DichThuoc"].ToString();
                        res.DV_AnUong = DataReader["DV_AnUong"].ToString();
                        res.DR_NuocTieu = DataReader["DR_NuocTieu"].ToString();
                        res.DR_Phan = DataReader["DR_Phan"].ToString();
                        res.DR_Khac = DataReader["DR_Khac"].ToString();
                        res.DichDanLuuVetMo = DataReader["DichDanLuuVetMo"].ToString();
                        res.DichDaDay = DataReader["DichDaDay"].ToString();
                        res.CanNang = DataReader["CanNang"].ToString();
                        res.ChieuCao = DataReader["ChieuCao"].ToString();
                        res.BMI = DataReader["BMI"].ToString();
                        res.Bilan = DataReader["Bilan"].ToString();
                        res.ThoOxy = DataReader["ThoOxy"].ToString();
                        res.CoThoOxyKhong = DataReader["CoThoOxyKhong"].ToString().Trim().Equals("1") ? true : false;
                        res.MachNhanhNho = DataReader["MACHNHANHNHO"].ToString().Trim().Equals("1") ? true : false;
                        res.HAKhongDoDuoc = DataReader["HAKHONGDODUOC"].ToString().Trim().Equals("1") ? true : false;
                        res.DauHieuSinhTon = JsonConvert.DeserializeObject<List<DauHieuSinhTon>>(DataReader["DauHieuSinhTon"].ToString());
                        // truyền dịch
                        res.DichTruyen = JsonConvert.DeserializeObject<List<DichTruyen>>(DataReader["DichTruyen"].ToString()) ?? new List<DichTruyen>();
                        if (!DataReader["MaDichTruyen"].ToString().Trim().Equals("")
                            && res.DichTruyen.Where(w => w.MaDichTruyen == DataReader["MaDichTruyen"].ToString().Trim()).Count() == 0)
                        {
                            DichTruyen old = new DichTruyen();
                            old.MaDichTruyen = DataReader["MaDichTruyen"].ToString();
                            old.TenDichTruyen = DataReader["TenDichTruyen"].ToString();
                            old.TheTich = 0;
                            old.TocDoTruyen = 0;
                            old.LoaiTruyen = "ml/giờ";
                            old.GhiChu = "";
                            old.GiaTri = DataReader["GiaTri"].ToString();
                            old.ThoiGianBatDau = (DateTime)DataReader["ThoiGianBatDau"];
                            old.ThoiGianKetThuc = (DateTime)DataReader["ThoiGianKetThuc"];
                            res.DichTruyen.Add(old);
                        }
                        // chọn in
                        //res.Chon = false;
                        res.MaSoKy = DataReader["masokyten"].ToString();
                        res.DaKy = !string.IsNullOrEmpty(res.MaSoKy) ? true : false;


                        listResult.Add(res);
                    }
                    return listResult;
                }
            }
            catch (Exception ex)
            {
                this.Log("Error : " + ex.Message + ", in Select function");
                throw ex;
            }
        }
        public bool Insert(MDB.MDBConnection MyConnection, ThongTinTruyenDich tttd)
        {
            try
            {
                //using (MDB.MDBConnection MyConnection = new MDB.MDBConnection(ERMDatabase.ConnectionString))
                {


                    string sql = @"INSERT INTO ThongTinTruyenDich (
                                IDPhieuThongTinTruyenDich, MaQuanLy, SoPhieu, ChanDoan, Tuoi, Khoa, Buong, Giuong, MaGiuong, HSTC, ThoiGianThucHien, CoThoOxyKhong, MACHNHANHNHO, HAKHONGDODUOC, THOIGIANTHOOXY_BD, THOIGIANTHOOXY_KT, NguoiThucHien, 
                                Mach, NhietDo, HuyetAp_Tren, HuyetAp_Duoi, NhipTho, ThoMay, TanSo, Glasgow, Dom, DuongMauMaoMach, SPO2, DV_DichThuoc, DV_AnUong, DR_NuocTieu, DR_Phan, DR_Khac, DichDanLuuVetMo, DichDaDay, CanNang, ChieuCao, BMI, Bilan, ThoOxy, DauHieuSinhTon, DichTruyen, Is_Delete, MaNVNguoiThucHien) 
                                VALUES (
								:IDPhieuThongTinTruyenDich, :MaQuanLy, :SoPhieu, :ChanDoan, :Tuoi, :Khoa, :Buong, :Giuong, :MaGiuong, :HSTC, :ThoiGianThucHien, :CoThoOxyKhong, :MACHNHANHNHO, :HAKHONGDODUOC, :THOIGIANTHOOXY_BD, :THOIGIANTHOOXY_KT, :NguoiThucHien, 
								:Mach, :NhietDo, :HuyetAp_Tren, :HuyetAp_Duoi, :NhipTho, :ThoMay, :TanSo, :Glasgow, :Dom, :DuongMauMaoMach, :SPO2, :DV_DichThuoc, :DV_AnUong, :DR_NuocTieu, :DR_Phan, :DR_Khac, :DichDanLuuVetMo, :DichDaDay, :CanNang, :ChieuCao, :BMI, :Bilan, :ThoOxy, :DauHieuSinhTon, :DichTruyen, 0, :MaNVNguoiThucHien) RETURNING IDThongTinTruyenDich INTO :IDThongTinTruyenDich";
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter(":IDPhieuThongTinTruyenDich", tttd.IDPhieuThongTinTruyenDich));
                    Command.Parameters.Add(new MDB.MDBParameter(":MaQuanLy", tttd.MaQuanLy));
                    Command.Parameters.Add(new MDB.MDBParameter(":SoPhieu", tttd.SoPhieu));
                    Command.Parameters.Add(new MDB.MDBParameter(":ChanDoan", tttd.ChanDoan));
                    Command.Parameters.Add(new MDB.MDBParameter(":Tuoi", tttd.Tuoi));
                    Command.Parameters.Add(new MDB.MDBParameter(":Khoa", tttd.Khoa));
                    Command.Parameters.Add(new MDB.MDBParameter(":Buong", tttd.Buong));
                    Command.Parameters.Add(new MDB.MDBParameter(":Giuong", tttd.Giuong));
                    Command.Parameters.Add(new MDB.MDBParameter(":MaGiuong", tttd.MaGiuong));
                    Command.Parameters.Add(new MDB.MDBParameter(":HSTC", tttd.CapCuu ? 1 : 0));
                    Command.Parameters.Add(new MDB.MDBParameter(":ThoiGianThucHien", tttd.ThoiGianThucHien));
                    Command.Parameters.Add(new MDB.MDBParameter(":CoThoOxyKhong", tttd.CoThoOxyKhong ? 1 : 0));
                    Command.Parameters.Add(new MDB.MDBParameter(":MACHNHANHNHO", tttd.MachNhanhNho ? 1 : 0));
                    Command.Parameters.Add(new MDB.MDBParameter(":HAKHONGDODUOC", tttd.HAKhongDoDuoc ? 1 : 0));
                    Command.Parameters.Add(new MDB.MDBParameter(":THOIGIANTHOOXY_BD", tttd.THOIGIANTHOOXY_BD));
                    Command.Parameters.Add(new MDB.MDBParameter(":THOIGIANTHOOXY_KT", tttd.THOIGIANTHOOXY_KT));
                    Command.Parameters.Add(new MDB.MDBParameter(":NguoiThucHien", tttd.NguoiThucHien));

                    Command.Parameters.Add(new MDB.MDBParameter(":Mach", tttd.Mach));
                    Command.Parameters.Add(new MDB.MDBParameter(":NhietDo", tttd.NhietDo));
                    Command.Parameters.Add(new MDB.MDBParameter(":HuyetAp_Tren", tttd.HuyetAp_Tren));
                    Command.Parameters.Add(new MDB.MDBParameter(":HuyetAp_Duoi", tttd.HuyetAp_Duoi));
                    Command.Parameters.Add(new MDB.MDBParameter(":NhipTho", tttd.NhipTho));
                    Command.Parameters.Add(new MDB.MDBParameter(":ThoMay", tttd.ThoMay ? 1 : (tttd.BopBong ? 2 : 0)));
                    Command.Parameters.Add(new MDB.MDBParameter(":TanSo", tttd.TanSo));
                    Command.Parameters.Add(new MDB.MDBParameter(":Glasgow", tttd.Glasgow));
                    Command.Parameters.Add(new MDB.MDBParameter(":Dom", tttd.Dom));
                    Command.Parameters.Add(new MDB.MDBParameter(":DuongMauMaoMach", tttd.DuongMauMaoMach));
                    Command.Parameters.Add(new MDB.MDBParameter(":SPO2", tttd.SPO2));// tungnd them truong cho issue 22300
                    Command.Parameters.Add(new MDB.MDBParameter(":DV_DichThuoc", tttd.DV_DichThuoc));
                    Command.Parameters.Add(new MDB.MDBParameter(":DV_AnUong", tttd.DV_AnUong));
                    Command.Parameters.Add(new MDB.MDBParameter(":DR_NuocTieu", tttd.DR_NuocTieu));
                    Command.Parameters.Add(new MDB.MDBParameter(":DR_Phan", tttd.DR_Phan));
                    Command.Parameters.Add(new MDB.MDBParameter(":DR_Khac", tttd.DR_Khac));
                    Command.Parameters.Add(new MDB.MDBParameter(":DichDanLuuVetMo", tttd.DichDanLuuVetMo));
                    Command.Parameters.Add(new MDB.MDBParameter(":DichDaDay", tttd.DichDaDay));
                    Command.Parameters.Add(new MDB.MDBParameter(":CanNang", tttd.CanNang));
                    Command.Parameters.Add(new MDB.MDBParameter(":ChieuCao", tttd.ChieuCao));
                    Command.Parameters.Add(new MDB.MDBParameter(":BMI", tttd.BMI));
                    Command.Parameters.Add(new MDB.MDBParameter(":Bilan", tttd.Bilan));
                    Command.Parameters.Add(new MDB.MDBParameter(":ThoOxy", tttd.ThoOxy));
                    Command.Parameters.Add(new MDB.MDBParameter(":DauHieuSinhTon", JsonConvert.SerializeObject(tttd.DauHieuSinhTon)));

                    Command.Parameters.Add(new MDB.MDBParameter(":DichTruyen", JsonConvert.SerializeObject(tttd.DichTruyen)));
                    Command.Parameters.Add(new MDB.MDBParameter("MANVNguoiThucHien", tttd.MaNVNguoiThucHien));
                    Command.Parameters.Add(new MDB.MDBParameter("IDThongTinTruyenDich", tttd.IDThongTinTruyenDich));

                    int n = Command.ExecuteNonQuery();
                    if (tttd.IDThongTinTruyenDich == 0)
                    {
                        long nextval = Convert.ToInt64((Command.Parameters["IDThongTinTruyenDich"] as MDB.MDBParameter).Value);
                        tttd.IDThongTinTruyenDich = nextval;
                    }
                    Command.Dispose();
                    return n > 0 ? true : false;
                    
                }
            }
            catch (Exception ex)
            {
                this.Log("Error : " + ex.Message + ", json :" + JsonConvert.SerializeObject(tttd));
                throw ex;
            }
        }
        public bool Update(MDB.MDBConnection MyConnection, ThongTinTruyenDich tttd)
        {
            try
            {
                //using (MDB.MDBConnection MyConnection = new MDB.MDBConnection(ERMDatabase.ConnectionString))
                {

                    string sql = @"UPDATE ThongTinTruyenDich SET 
                        IDPhieuThongTinTruyenDich = :IDPhieuThongTinTruyenDich, 
                        MaQuanLy = :MaQuanLy, 
                        SoPhieu = :SoPhieu, 
                        ChanDoan = :ChanDoan, 
                        Tuoi = :Tuoi, 
                        Khoa = :Khoa, 
                        Buong = :Buong, 
                        Giuong = :Giuong, 
                        MaGiuong = :MaGiuong,
                        HSTC = :HSTC, 

                        ThoiGianThucHien = :ThoiGianThucHien, 
                        CoThoOxyKhong = :CoThoOxyKhong,
                        MACHNHANHNHO = :MACHNHANHNHO,
                        HAKHONGDODUOC = :HAKHONGDODUOC,
                        THOIGIANTHOOXY_BD = :THOIGIANTHOOXY_BD, 
                        THOIGIANTHOOXY_KT = :THOIGIANTHOOXY_KT, 
                        NguoiThucHien = :NguoiThucHien, 

                        Mach = :Mach, 
                        NhietDo = :NhietDo, 
                        HuyetAp_Tren = :HuyetAp_Tren, 
                        HuyetAp_Duoi = :HuyetAp_Duoi, 
                        NhipTho = :NhipTho, 
                        ThoMay = :ThoMay,
                        TanSo = :TanSo,
                        Glasgow = :Glasgow,
                        Dom = :Dom,
                        DuongMauMaoMach = :DuongMauMaoMach,
                        SPO2 = :SPO2,
                        DV_DichThuoc = :DV_DichThuoc,
                        DV_AnUong = :DV_AnUong,
                        DR_NuocTieu = :DR_NuocTieu,
                        DR_Phan = :DR_Phan,
                        DR_Khac = :DR_Khac,
                        DichDanLuuVetMo = :DichDanLuuVetMo,
                        DichDaDay = :DichDaDay,
                        CanNang = :CanNang,
                        ChieuCao = :ChieuCao,
                        BMI = :BMI,
                        Bilan = :Bilan,
                        ThoOxy = :ThoOxy,
                        DauHieuSinhTon = :DauHieuSinhTon, 

                        DichTruyen = :DichTruyen,
                        MaNVNguoiThucHien = :MaNVNguoiThucHien 
                        WHERE IDThongTinTruyenDich = " + tttd.IDThongTinTruyenDich;
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter(":IDPhieuThongTinTruyenDich", tttd.IDPhieuThongTinTruyenDich));
                    Command.Parameters.Add(new MDB.MDBParameter(":MaQuanLy", tttd.MaQuanLy));
                    Command.Parameters.Add(new MDB.MDBParameter(":SoPhieu", tttd.SoPhieu));
                    Command.Parameters.Add(new MDB.MDBParameter(":ChanDoan", tttd.ChanDoan));
                    Command.Parameters.Add(new MDB.MDBParameter(":Tuoi", tttd.Tuoi));
                    Command.Parameters.Add(new MDB.MDBParameter(":Khoa", tttd.Khoa));
                    Command.Parameters.Add(new MDB.MDBParameter(":Buong", tttd.Buong));
                    Command.Parameters.Add(new MDB.MDBParameter(":Giuong", tttd.Giuong));
                    Command.Parameters.Add(new MDB.MDBParameter(":MaGiuong", tttd.MaGiuong));
                    Command.Parameters.Add(new MDB.MDBParameter(":HSTC", tttd.CapCuu ? 1 : 0));

                    Command.Parameters.Add(new MDB.MDBParameter(":ThoiGianThucHien", tttd.ThoiGianThucHien));
                    Command.Parameters.Add(new MDB.MDBParameter(":CoThoOxyKhong", tttd.CoThoOxyKhong ? 1 : 0));
                    Command.Parameters.Add(new MDB.MDBParameter(":MACHNHANHNHO", tttd.MachNhanhNho ? 1 : 0));
                    Command.Parameters.Add(new MDB.MDBParameter(":HAKHONGDODUOC", tttd.HAKhongDoDuoc ? 1 : 0));
                    Command.Parameters.Add(new MDB.MDBParameter(":THOIGIANTHOOXY_BD", tttd.THOIGIANTHOOXY_BD));
                    Command.Parameters.Add(new MDB.MDBParameter(":THOIGIANTHOOXY_KT", tttd.THOIGIANTHOOXY_KT));
                    Command.Parameters.Add(new MDB.MDBParameter(":NguoiThucHien", tttd.NguoiThucHien));

                    Command.Parameters.Add(new MDB.MDBParameter(":Mach", tttd.Mach));
                    Command.Parameters.Add(new MDB.MDBParameter(":NhietDo", tttd.NhietDo));
                    Command.Parameters.Add(new MDB.MDBParameter(":HuyetAp_Tren", tttd.HuyetAp_Tren));
                    Command.Parameters.Add(new MDB.MDBParameter(":HuyetAp_Duoi", tttd.HuyetAp_Duoi));
                    Command.Parameters.Add(new MDB.MDBParameter(":NhipTho", tttd.NhipTho));
                    Command.Parameters.Add(new MDB.MDBParameter(":ThoMay", tttd.ThoMay ? 1 : (tttd.BopBong ? 2 : 0)));
                    Command.Parameters.Add(new MDB.MDBParameter(":TanSo", tttd.TanSo));
                    Command.Parameters.Add(new MDB.MDBParameter(":Glasgow", tttd.Glasgow));
                    Command.Parameters.Add(new MDB.MDBParameter(":Dom", tttd.Dom));
                    Command.Parameters.Add(new MDB.MDBParameter(":DuongMauMaoMach", tttd.DuongMauMaoMach));
                    Command.Parameters.Add(new MDB.MDBParameter(":SPO2", tttd.SPO2));
                    Command.Parameters.Add(new MDB.MDBParameter(":DV_DichThuoc", tttd.DV_DichThuoc));
                    Command.Parameters.Add(new MDB.MDBParameter(":DV_AnUong", tttd.DV_AnUong));
                    Command.Parameters.Add(new MDB.MDBParameter(":DR_NuocTieu", tttd.DR_NuocTieu));
                    Command.Parameters.Add(new MDB.MDBParameter(":DR_Phan", tttd.DR_Phan));
                    Command.Parameters.Add(new MDB.MDBParameter(":DR_Khac", tttd.DR_Khac));
                    Command.Parameters.Add(new MDB.MDBParameter(":DichDanLuuVetMo", tttd.DichDanLuuVetMo));
                    Command.Parameters.Add(new MDB.MDBParameter(":DichDaDay", tttd.DichDaDay));
                    Command.Parameters.Add(new MDB.MDBParameter(":CanNang", tttd.CanNang));
                    Command.Parameters.Add(new MDB.MDBParameter(":ChieuCao", tttd.ChieuCao));
                    Command.Parameters.Add(new MDB.MDBParameter(":BMI", tttd.BMI));
                    Command.Parameters.Add(new MDB.MDBParameter(":Bilan", tttd.Bilan));
                    Command.Parameters.Add(new MDB.MDBParameter(":ThoOxy", tttd.ThoOxy));
                    Command.Parameters.Add(new MDB.MDBParameter(":DauHieuSinhTon", JsonConvert.SerializeObject(tttd.DauHieuSinhTon)));

                    Command.Parameters.Add(new MDB.MDBParameter("DichTruyen", JsonConvert.SerializeObject(tttd.DichTruyen)));
                    Command.Parameters.Add(new MDB.MDBParameter(":MANVNguoiThucHien", tttd.MaNVNguoiThucHien));
                    int n = Command.ExecuteNonQuery();

                    return n > 0 ? true : false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Delete(MDB.MDBConnection MyConnection, decimal IDThongTinTruyenDich)
        {
            try
            {
                if (IDThongTinTruyenDich != 0)
                {
                    string sql = @"UPDATE ThongTinTruyenDich SET Is_Delete = 1 
                                WHERE 
                                (IDThongTinTruyenDich = :IDThongTinTruyenDich) 
                                AND Is_Delete = 0";
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter(":IDThongTinTruyenDich", IDThongTinTruyenDich));
                    int n = Command.ExecuteNonQuery();

                    return n > 0 ? true : false;
                }

            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public bool DeleteChiTietPhieu(MDB.MDBConnection MyConnection, decimal IDThongTinTruyenDich)
        {
            try
            {
                if (IDThongTinTruyenDich != 0)
                {
                    string sql = @"UPDATE ThongTinTruyenDich SET Is_Delete = 1 
                                WHERE 
                                (IDPhieuThongTinTruyenDich = :IDPhieuThongTinTruyenDich) 
                                AND Is_Delete = 0";
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter(":IDPhieuThongTinTruyenDich", IDThongTinTruyenDich));
                    int n = Command.ExecuteNonQuery();

                    return n > 0 ? true : false;
                }

            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public void Print(MDB.MDBConnection MyConnection,HanhChinhBenhNhan hcbn, ThongTinDieuTri ttdt, List<ThongTinTruyenDich> lstPrints, bool isUseKyDT = true
            , DateTime? fromDate = null, DateTime? toDate = null, string tenPhieu = null)
        {
            try
            {
                if (lstPrints == null)
                {
                    lstPrints = Select(MyConnection, ttdt.MaQuanLy.ToString());
                }

                var lstRoots = lstPrints.Where(w => w.IDPhieuThongTinTruyenDich == 0).ToList()
                    ?? new List<ThongTinTruyenDich>();
                foreach (var root in lstRoots)
                {
                    //Report.lstKy = new List<Inventec.Common.SignLibrary.DTO.SignerConfigDTO> { };
                    Report.thongTinKy = new EMR.KyDienTu.ThongTinKy();
                    Report.thongTinKy.LoaiVanBan = (EMR.KyDienTu.LoaiVanBanKyDienTu) Report.GetMaKyPhieu(XemBenhAn.MyConnection, "TD");

                    //int i = 0;

                    var lstLeafs = Select(MyConnection, ttdt.MaQuanLy.ToString()).Where(w => w.IDPhieuThongTinTruyenDich == root.IDThongTinTruyenDich).ToList()
                    ?? new List<ThongTinTruyenDich>();
                    if (fromDate != null && toDate != null)
                    {
                        lstLeafs = lstLeafs.Where(w => w.ThoiGianThucHien >= fromDate
                                                && w.ThoiGianThucHien <= toDate).ToList();
                    }
                    //foreach (ThongTinTruyenDich tttd in lstLeafs)
                    //{
                    //    string NguoiThucHien = tttd.MaNVNguoiThucHien;
                    //    if (NguoiThucHien != "")
                    //    {
                    //        i = i + 1;
                    //        Report.lstKy.Add((new Inventec.Common.SignLibrary.DTO.SignerConfigDTO() { Loginname = NguoiThucHien, NumOrder = i }));
                    //    }
                    //}
                    // test
                    bool preview = true;
                    rptPhieuTruyenDich temp = new rptPhieuTruyenDich(hcbn, ttdt, root, lstLeafs, isUseKyDT, tenPhieu);
                    if (preview)
                    {
                        Report.Print(null, temp, true
                            , (Report.GetMaKyPhieu(XemBenhAn.MyConnection, "TD")).ToString().PadLeft(2, '0')
                            , TableName
                            , TablePrimaryKeyName
                            , Convert.ToInt64(root.IDThongTinTruyenDich)
                            , root.MaSoKy);
                    }
                    else
                    {
                        new ReportPrintTool(temp).Print();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
