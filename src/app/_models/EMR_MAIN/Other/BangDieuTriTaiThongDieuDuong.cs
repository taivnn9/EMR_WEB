using EMR.KyDienTu;
using System;
using System.Collections.Generic;
using System.Data;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class BangDieuTriTaiThongDieuDuong : ThongTinKy
    {
        public BangDieuTriTaiThongDieuDuong()
        {
            TableName = "BangDieuTriTaiThongDieuDuong";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BKDTTTDD;
            TenMauPhieu = DanhMucPhieu.BKDTTTDD.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        public DateTime NgayCapCuu { get; set; }
        public DateTime GioCapCuu { get; set; }
        public bool[] DDCapCuuBenhNhanArray { get; } = new bool[] { false, false, false, false, false };
        public string DDCapCuuBenhNhan
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < DDCapCuuBenhNhanArray.Length; i++)
                    temp += (DDCapCuuBenhNhanArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DDCapCuuBenhNhanArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Mạch")]
		public string Mach { get; set; }
        [MoTaDuLieu("Huyết áp")]
		public string HuyetAp { get; set; }
        [MoTaDuLieu("Cân nặng")]
		public string CanNang { get; set; }
        public DateTime GioBaoBSCCKham { get; set; }
        public DateTime GioBaoHoiChanKhoa { get; set; }
        public DateTime GioGoiDTChupCT { get; set; }
        public DateTime GioChupCT { get; set; }
        public string KTVCT { get; set; }
        public string MaKTVCTP { get; set; }
        public bool[] XetNghiemMauArray { get; } = new bool[] { false, false, false, false, false, false, false, false };
        public string XetNghiemMau
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < XetNghiemMauArray.Length; i++)
                    temp += (XetNghiemMauArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        XetNghiemMauArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string TTBSXetNghiemMau { get; set; }
        public DateTime GioDDNhanBanGiao { get; set; }
        public bool[] DDNhanBanGiaoArray { get; } = new bool[] { false, false, false, false, false };
        public string DDNhanBanGiao
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < DDNhanBanGiaoArray.Length; i++)
                    temp += (DDNhanBanGiaoArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DDNhanBanGiaoArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string TTBSCamKetDieuTri { get; set; }
        public string TTBSThuocActilyse { get; set; }
        public string TTBSLayDuongTruyenTMThu2 { get; set; }
        public string TTBSMacMonitor { get; set; }
        public DateTime GioPhaThuoc { get; set; }
        public double TongLieu { get; set; }
        public double Bolus { get; set; }
        public double BTTD { get; set; }
        public DateTime GioCanThiepMach { get; set; }
        public DateTime GioChuyenVeNTK { get; set; }
        public string KTVPDSA { get; set; }
        public string MaKTVPDSA { get; set; }
        public string DaiDienKhoa { get; set; }
        public string MaDaiDienKhoa { get; set; }
        public string DaiDienNTK { get; set; }
        public string MaDaiDienNTK { get; set; }
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
    public class BangDieuTriTaiThongDieuDuongFunc
    {
        public const string TableName = "BangDieuTriTaiThongDieuDuong";
        public const string TablePrimaryKeyName = "ID";
        public static List<BangDieuTriTaiThongDieuDuong> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BangDieuTriTaiThongDieuDuong> list = new List<BangDieuTriTaiThongDieuDuong>();
            try
            {
                string sql = @"SELECT * FROM BangDieuTriTaiThongDieuDuong where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    BangDieuTriTaiThongDieuDuong data = new BangDieuTriTaiThongDieuDuong();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.NgayCapCuu = Convert.ToDateTime(DataReader["NgayCapCuu"] == DBNull.Value ? DateTime.Now : DataReader["NgayCapCuu"]);
                    data.GioCapCuu = data.NgayCapCuu;
                    data.DDCapCuuBenhNhan = DataReader["DDCapCuuBenhNhan"].ToString();
                    data.Mach = DataReader["Mach"].ToString();
                    data.HuyetAp = DataReader["HuyetAp"].ToString();
                    data.CanNang = DataReader["CanNang"].ToString();

                    data.GioBaoBSCCKham = Convert.ToDateTime(DataReader["GioBaoBSCCKham"] == DBNull.Value ? DateTime.Now : DataReader["GioBaoBSCCKham"]);
                    data.GioBaoHoiChanKhoa = Convert.ToDateTime(DataReader["GioBaoHoiChanKhoa"] == DBNull.Value ? DateTime.Now : DataReader["GioBaoHoiChanKhoa"]);
                    data.GioGoiDTChupCT = Convert.ToDateTime(DataReader["GioGoiDTChupCT"] == DBNull.Value ? DateTime.Now : DataReader["GioGoiDTChupCT"]);
                    data.GioChupCT = Convert.ToDateTime(DataReader["GioChupCT"] == DBNull.Value ? DateTime.Now : DataReader["GioChupCT"]);

                    data.KTVCT = DataReader["KTVCT"].ToString();
                    data.MaKTVCTP = DataReader["MaKTVCTP"].ToString();
                    data.KTVPDSA = DataReader["KTVPDSA"].ToString();
                    data.MaKTVPDSA = DataReader["MaKTVPDSA"].ToString();

                    data.XetNghiemMau = DataReader["XetNghiemMau"].ToString();
                    data.TTBSXetNghiemMau = DataReader["TTBSXetNghiemMau"].ToString();
                    data.GioDDNhanBanGiao = Convert.ToDateTime(DataReader["GioDDNhanBanGiao"] == DBNull.Value ? DateTime.Now : DataReader["GioDDNhanBanGiao"]);
                    data.DDNhanBanGiao = DataReader["DDNhanBanGiao"].ToString();
                    data.TTBSCamKetDieuTri = DataReader["TTBSCamKetDieuTri"].ToString();
                    data.TTBSThuocActilyse = DataReader["TTBSThuocActilyse"].ToString();
                    data.TTBSLayDuongTruyenTMThu2 = DataReader["TTBSLayDuongTruyenTMThu2"].ToString();
                    data.TTBSMacMonitor = DataReader["TTBSMacMonitor"].ToString();
                    data.GioPhaThuoc = Convert.ToDateTime(DataReader["GioPhaThuoc"] == DBNull.Value ? DateTime.Now : DataReader["GioPhaThuoc"]);

                    double tempDouble = 0;
                    double.TryParse(DataReader["TongLieu"].ToString(), out tempDouble);
                    data.TongLieu = tempDouble;

                    tempDouble = 0;
                    double.TryParse(DataReader["Bolus"].ToString(), out tempDouble);
                    data.Bolus = tempDouble;

                    tempDouble = 0;
                    double.TryParse(DataReader["BTTD"].ToString(), out tempDouble);
                    data.BTTD = tempDouble;

                    data.GioCanThiepMach = Convert.ToDateTime(DataReader["GioCanThiepMach"] == DBNull.Value ? DateTime.Now : DataReader["GioCanThiepMach"]);
                    data.GioChuyenVeNTK = Convert.ToDateTime(DataReader["GioChuyenVeNTK"] == DBNull.Value ? DateTime.Now : DataReader["GioChuyenVeNTK"]);

                    data.DaiDienKhoa = DataReader["DaiDienKhoa"].ToString();
                    data.MaDaiDienKhoa = DataReader["MaDaiDienKhoa"].ToString();
                    data.DaiDienNTK = DataReader["DaiDienNTK"].ToString();
                    data.MaDaiDienNTK = DataReader["MaDaiDienNTK"].ToString();

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BangDieuTriTaiThongDieuDuong bangDieuTri)
        {
            try
            {
                string sql = @"INSERT INTO BangDieuTriTaiThongDieuDuong
                (
                    MAQUANLY,
                    MaBenhNhan,
                    NgayCapCuu,
                    DDCapCuuBenhNhan,
                    Mach,
                    HuyetAp,
                    CanNang,
                    GioBaoBSCCKham,
                    GioBaoHoiChanKhoa,
                    GioGoiDTChupCT,
                    GioChupCT,
                    KTVCT,
                    MaKTVCTP,
                    XetNghiemMau,
                    TTBSXetNghiemMau,
                    GioDDNhanBanGiao,
                    DDNhanBanGiao,
                    TTBSCamKetDieuTri,
                    TTBSThuocActilyse,
                    TTBSLayDuongTruyenTMThu2,
                    TTBSMacMonitor,
                    GioPhaThuoc,
                    TongLieu,
                    Bolus,
                    BTTD,
                    GioCanThiepMach,
                    GioChuyenVeNTK,
                    KTVPDSA,
                    MaKTVPDSA,
                    DaiDienKhoa,
                    MaDaiDienKhoa,
                    DaiDienNTK,
                    MaDaiDienNTK,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :NgayCapCuu,
                    :DDCapCuuBenhNhan,
                    :Mach,
                    :HuyetAp,
                    :CanNang,
                    :GioBaoBSCCKham,
                    :GioBaoHoiChanKhoa,
                    :GioGoiDTChupCT,
                    :GioChupCT,
                    :KTVCT,
                    :MaKTVCTP,
                    :XetNghiemMau,
                    :TTBSXetNghiemMau,
                    :GioDDNhanBanGiao,
                    :DDNhanBanGiao,
                    :TTBSCamKetDieuTri,
                    :TTBSThuocActilyse,
                    :TTBSLayDuongTruyenTMThu2,
                    :TTBSMacMonitor,
                    :GioPhaThuoc,
                    :TongLieu,
                    :Bolus,
                    :BTTD,
                    :GioCanThiepMach,
                    :GioChuyenVeNTK,
                    :KTVPDSA,
                    :MaKTVPDSA,
                    :DaiDienKhoa,
                    :MaDaiDienKhoa,
                    :DaiDienNTK,
                    :MaDaiDienNTK,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (bangDieuTri.ID != 0)
                {
                    sql = @"UPDATE BangDieuTriTaiThongDieuDuong SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    NgayCapCuu = :NgayCapCuu,
                    DDCapCuuBenhNhan = :DDCapCuuBenhNhan,
                    Mach = :Mach,
                    HuyetAp = :HuyetAp,
                    CanNang = :CanNang,
                    GioBaoBSCCKham = :GioBaoBSCCKham,
                    GioBaoHoiChanKhoa = :GioBaoHoiChanKhoa,
                    GioGoiDTChupCT = :GioGoiDTChupCT,
                    GioChupCT = :GioChupCT,
                    KTVCT = :KTVCT,
                    MaKTVCTP = :MaKTVCTP,
                    XetNghiemMau = :XetNghiemMau,
                    TTBSXetNghiemMau = :TTBSXetNghiemMau,
                    GioDDNhanBanGiao = :GioDDNhanBanGiao,
                    DDNhanBanGiao = :DDNhanBanGiao,
                    TTBSCamKetDieuTri = :TTBSCamKetDieuTri,
                    TTBSThuocActilyse = :TTBSThuocActilyse,
                    TTBSLayDuongTruyenTMThu2 = :TTBSLayDuongTruyenTMThu2,
                    TTBSMacMonitor = :TTBSMacMonitor,
                    GioPhaThuoc = :GioPhaThuoc,
                    TongLieu = :TongLieu,
                    Bolus = :Bolus,
                    BTTD = :BTTD,
                    GioCanThiepMach = :GioCanThiepMach,
                    GioChuyenVeNTK = :GioChuyenVeNTK,
                    DaiDienKhoa = :DaiDienKhoa,
                    MaDaiDienKhoa = :MaDaiDienKhoa,
                    DaiDienNTK = :DaiDienNTK,
                    MaDaiDienNTK = :MaDaiDienNTK,
                    KTVPDSA = :KTVPDSA,
                    MaKTVPDSA = :MaKTVPDSA,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + bangDieuTri.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangDieuTri.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", bangDieuTri.MaBenhNhan));
                var Ngay = bangDieuTri.NgayCapCuu.Date.Add(new TimeSpan(0, 0, 0));
                var Gio = bangDieuTri.GioCapCuu != null ? bangDieuTri.GioCapCuu.TimeOfDay : DateTime.Now.TimeOfDay;
                var NgayCapCuu = Ngay + Gio;
                Command.Parameters.Add(new MDB.MDBParameter("NgayCapCuu", NgayCapCuu));

                Command.Parameters.Add(new MDB.MDBParameter("DDCapCuuBenhNhan", bangDieuTri.DDCapCuuBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("Mach", bangDieuTri.Mach));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetAp", bangDieuTri.HuyetAp));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang", bangDieuTri.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("GioBaoBSCCKham", bangDieuTri.GioBaoBSCCKham));
                Command.Parameters.Add(new MDB.MDBParameter("GioBaoHoiChanKhoa", bangDieuTri.GioBaoHoiChanKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("GioGoiDTChupCT", bangDieuTri.GioGoiDTChupCT));
                Command.Parameters.Add(new MDB.MDBParameter("GioChupCT", bangDieuTri.GioChupCT));
                Command.Parameters.Add(new MDB.MDBParameter("KTVCT", bangDieuTri.KTVCT));
                Command.Parameters.Add(new MDB.MDBParameter("MaKTVCTP", bangDieuTri.MaKTVCTP));
                Command.Parameters.Add(new MDB.MDBParameter("XetNghiemMau", bangDieuTri.XetNghiemMau));
                Command.Parameters.Add(new MDB.MDBParameter("TTBSXetNghiemMau", bangDieuTri.TTBSXetNghiemMau));
                Command.Parameters.Add(new MDB.MDBParameter("GioDDNhanBanGiao", bangDieuTri.GioDDNhanBanGiao));
                Command.Parameters.Add(new MDB.MDBParameter("DDNhanBanGiao", bangDieuTri.DDNhanBanGiao));
                Command.Parameters.Add(new MDB.MDBParameter("TTBSCamKetDieuTri", bangDieuTri.TTBSCamKetDieuTri));
                Command.Parameters.Add(new MDB.MDBParameter("TTBSThuocActilyse", bangDieuTri.TTBSThuocActilyse));
                Command.Parameters.Add(new MDB.MDBParameter("TTBSLayDuongTruyenTMThu2", bangDieuTri.TTBSLayDuongTruyenTMThu2));
                Command.Parameters.Add(new MDB.MDBParameter("TTBSMacMonitor", bangDieuTri.TTBSMacMonitor));
                Command.Parameters.Add(new MDB.MDBParameter("GioPhaThuoc", bangDieuTri.GioPhaThuoc));
                Command.Parameters.Add(new MDB.MDBParameter("TongLieu", bangDieuTri.TongLieu));
                Command.Parameters.Add(new MDB.MDBParameter("Bolus", bangDieuTri.Bolus));
                Command.Parameters.Add(new MDB.MDBParameter("BTTD", bangDieuTri.BTTD));
                Command.Parameters.Add(new MDB.MDBParameter("GioCanThiepMach", bangDieuTri.GioCanThiepMach));
                Command.Parameters.Add(new MDB.MDBParameter("GioChuyenVeNTK", bangDieuTri.GioChuyenVeNTK));
                Command.Parameters.Add(new MDB.MDBParameter("DaiDienKhoa", bangDieuTri.DaiDienKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaDaiDienKhoa", bangDieuTri.MaDaiDienKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("DaiDienNTK", bangDieuTri.DaiDienNTK));
                Command.Parameters.Add(new MDB.MDBParameter("MaDaiDienNTK", bangDieuTri.MaDaiDienNTK));
                Command.Parameters.Add(new MDB.MDBParameter("KTVPDSA", bangDieuTri.KTVPDSA));
                Command.Parameters.Add(new MDB.MDBParameter("MaKTVPDSA", bangDieuTri.MaKTVPDSA));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", bangDieuTri.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", bangDieuTri.NgaySua));
                if (bangDieuTri.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", bangDieuTri.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", bangDieuTri.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", bangDieuTri.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (bangDieuTri.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    bangDieuTri.ID = nextval;
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
                string sql = "DELETE FROM BangDieuTriTaiThongDieuDuong WHERE ID = :ID";
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
                H.GIOITINH,
	            H.TENBENHNHAN,
                H.TUOI
            FROM
                BangDieuTriTaiThongDieuDuong B
                LEFT JOIN THONGTINDIEUTRI T ON B.MAQUANLY = T.MAQUANLY
                LEFT JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "BK");

            /*DataTable thongTinVien = new DataTable("HEADER");

            thongTinVien.Columns.Add("BENHVIEN");
            thongTinVien.Columns.Add("KHOA");
			if (XemBenhAn._HanhChinhBenhNhan == null) XemBenhAn._HanhChinhBenhNhan = new HanhChinhBenhNhan();
            if (XemBenhAn._ThongTinDieuTri == null) XemBenhAn._ThongTinDieuTri = new ThongTinDieuTri();
            thongTinVien.Rows.Add(XemBenhAn._HanhChinhBenhNhan.BenhVien, XemBenhAn._ThongTinDieuTri.Khoa);
            ds.Tables.Add(thongTinVien);*/

            return ds;
        }
    }
}
