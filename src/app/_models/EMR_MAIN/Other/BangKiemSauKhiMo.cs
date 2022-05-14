using EMR.KyDienTu;
using System;
using System.Collections.Generic;
using System.Data;
using PMS.Access;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class BangKiemSauKhiMo : ThongTinKy
    {
        public BangKiemSauKhiMo()
        {
            TableName = "BangKiemSauKhiMo";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BKSKM;
            TenMauPhieu = DanhMucPhieu.BKSKM.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Ngày mổ")]
        public DateTime NgayMo { get; set; }
        [MoTaDuLieu("Giờ mổ")]
        public DateTime GioMo { get; set; }
        [MoTaDuLieu("Ngày kết thúc mổ")]
        public DateTime NgayKetThuc { get; set; }
        [MoTaDuLieu("Giờ kết thúc mổ")]
        public DateTime GioKetThuc { get; set; }
        [MoTaDuLieu("Chẩn đoán sau mổ")]
		public string ChanDoanSauMo { get; set; }
        [MoTaDuLieu("Loại phẩu thuật")]
        public string LoaiPhauThuat { get; set; }
        [MoTaDuLieu("Số lượng Y cụ")]
        public int YCu_SoLuong { get; set; }
        public bool[] YCuArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Y cụ")]
        public int YCu
        {
            get
            {
                return Array.IndexOf(YCuArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) YCuArray[i] = true;
                    else YCuArray[i] = false;
                }
            }
        }
        [MoTaDuLieu("Lý do(Y cụ)")]
        public string YCu_LyDo { get; set; }
        [MoTaDuLieu("Số lượng gạc bụng")]
        public int GacBung_SoLuong { get; set; }
        public bool[] GacBungArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Gạc bụng")]
        public int GacBung
        {
            get
            {
                return Array.IndexOf(GacBungArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) GacBungArray[i] = true;
                    else GacBungArray[i] = false;
                }
            }
        }
        [MoTaDuLieu("Lý do(Gạc bụng)")]
        public string GacBung_LyDo { get; set; }
        [MoTaDuLieu("Số lượng Gạc Mèche")]
        public int GacMeChe_SoLuong { get; set; }
        public bool[] GacMeCheArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Gạc Mèche")]
        public int GacMeChe
        {
            get
            {
                return Array.IndexOf(GacMeCheArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) GacMeCheArray[i] = true;
                    else GacMeCheArray[i] = false;
                }
            }
        }
        [MoTaDuLieu("Lý do(Gạc Mèche)")]
        public string GacMeChe_LyDo { get; set; }
        [MoTaDuLieu("Số lượng kim phẩu thuật")]
        public int KimPhauThuat_SoLuong { get; set; }
        public bool[] KimPhauThuatArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Kim phẩu thuật")]
        public int KimPhauThuat
        {
            get
            {
                return Array.IndexOf(KimPhauThuatArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) KimPhauThuatArray[i] = true;
                    else KimPhauThuatArray[i] = false;
                }
            }
        }
        [MoTaDuLieu("Lý do(kim phẩu thuật)")]
        public string KimPhauThuat_LyDo { get; set; }
        public bool[] BanGiaoArray { get; } = new bool[] { false, false };
        [MoTaDuLieu("Bàn giao giữa ca")]
        public int BanGiao
        {
            get
            {
                return Array.IndexOf(BanGiaoArray, true) + 1;
            }
            set
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == (value - 1)) BanGiaoArray[i] = true;
                    else BanGiaoArray[i] = false;
                }
            }
        }
        [MoTaDuLieu("Ghi chú(bàn giao giữa ca)")]
        public string BanGiao_GhiChu { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng vòng trong")]
		public string DieuDuongVongTrong { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng vòng ngoài")]
		public string DieuDuongVongNgoai { get; set; }
        [MoTaDuLieu("Họ tên người lập bảng")]
        public string NguoiLapBang { get; set; }
        [MoTaDuLieu("Mã người lập bảng")]
        public string MaNguoiLapBang { get; set; }
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
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
    }
    public class BangKiemSauKhiMoFunc
    {
        public const string TableName = "BangKiemSauKhiMo";
        public const string TablePrimaryKeyName = "ID";
        public static List<BangKiemSauKhiMo> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BangKiemSauKhiMo> list = new List<BangKiemSauKhiMo>();
            try
            {
                string sql = @"SELECT * FROM BangKiemSauKhiMo where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    BangKiemSauKhiMo data = new BangKiemSauKhiMo();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.NgayMo = Convert.ToDateTime(DataReader["NgayGioMo"] == DBNull.Value ? DateTime.Now : DataReader["NgayGioMo"]);
                    data.GioMo = Convert.ToDateTime(DataReader["NgayGioMo"] == DBNull.Value ? DateTime.Now : DataReader["NgayGioMo"]);
                    data.NgayKetThuc = Convert.ToDateTime(DataReader["NgayGioKetThuc"] == DBNull.Value ? DateTime.Now : DataReader["NgayGioKetThuc"]);
                    data.GioKetThuc = Convert.ToDateTime(DataReader["NgayGioKetThuc"] == DBNull.Value ? DateTime.Now : DataReader["NgayGioKetThuc"]);
                    data.ChanDoanSauMo = DataReader["ChanDoanSauMo"].ToString();
                    data.LoaiPhauThuat = DataReader["LoaiPhauThuat"].ToString();

                    int tempInt = -1;
                    int.TryParse(DataReader["YCu_SoLuong"].ToString(), out tempInt);
                    data.YCu_SoLuong = tempInt;

                    tempInt = -1;
                    int.TryParse(DataReader["YCu"].ToString(), out tempInt);
                    data.YCu = tempInt;
                    data.YCu_LyDo = DataReader["YCu_LyDo"].ToString();

                    tempInt = -1;
                    int.TryParse(DataReader["GacBung_SoLuong"].ToString(), out tempInt);
                    data.GacBung_SoLuong = tempInt;

                    tempInt = -1;
                    int.TryParse(DataReader["GacBung"].ToString(), out tempInt);
                    data.GacBung = tempInt;
                    data.GacBung_LyDo = DataReader["GacBung_LyDo"].ToString();

                    tempInt = -1;
                    int.TryParse(DataReader["GacMeChe_SoLuong"].ToString(), out tempInt);
                    data.GacMeChe_SoLuong = tempInt;

                    tempInt = -1;
                    int.TryParse(DataReader["GacMeChe"].ToString(), out tempInt);
                    data.GacMeChe = tempInt;
                    data.GacMeChe_LyDo = DataReader["GacMeChe_LyDo"].ToString();

                    tempInt = -1;
                    int.TryParse(DataReader["KimPhauThuat_SoLuong"].ToString(), out tempInt);
                    data.KimPhauThuat_SoLuong = tempInt;

                    tempInt = -1;
                    int.TryParse(DataReader["KimPhauThuat"].ToString(), out tempInt);
                    data.KimPhauThuat = tempInt;
                    data.KimPhauThuat_LyDo = DataReader["KimPhauThuat_LyDo"].ToString();

                    tempInt = -1;
                    int.TryParse(DataReader["BanGiao"].ToString(), out tempInt);
                    data.BanGiao = tempInt;

                    data.BanGiao_GhiChu = DataReader["BanGiao_GhiChu"].ToString();
                    data.DieuDuongVongTrong = DataReader["DieuDuongVongTrong"].ToString();
                    data.DieuDuongVongNgoai = DataReader["DieuDuongVongNgoai"].ToString();

                    data.NguoiLapBang = DataReader["NguoiLapBang"].ToString();
                    data.MaNguoiLapBang = DataReader["MaNguoiLapBang"].ToString();

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BangKiemSauKhiMo bangKiemSauKhiMo)
        {
            try
            {
                string sql = @"INSERT INTO BangKiemSauKhiMo
                (
                    MAQUANLY,
                    MaBenhNhan,
                    NgayGioMo,
                    NgayGioKetThuc,
                    ChanDoanSauMo,
                    LoaiPhauThuat,
                    YCu_SoLuong,
                    YCu,
                    YCu_LyDo,
                    GacBung_SoLuong,
                    GacBung,
                    GacBung_LyDo,
                    GacMeChe_SoLuong,
                    GacMeChe,
                    GacMeChe_LyDo,
                    KimPhauThuat_SoLuong,
                    KimPhauThuat,
                    KimPhauThuat_LyDo,
                    BanGiao,
                    BanGiao_GhiChu,
                    DieuDuongVongTrong,
                    DieuDuongVongNgoai,
                    NguoiLapBang,
                    MaNguoiLapBang,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :NgayGioMo,
                    :NgayGioKetThuc,
                    :ChanDoanSauMo,
                    :LoaiPhauThuat,
                    :YCu_SoLuong,
                    :YCu,
                    :YCu_LyDo,
                    :GacBung_SoLuong,
                    :GacBung,
                    :GacBung_LyDo,
                    :GacMeChe_SoLuong,
                    :GacMeChe,
                    :GacMeChe_LyDo,
                    :KimPhauThuat_SoLuong,
                    :KimPhauThuat,
                    :KimPhauThuat_LyDo,
                    :BanGiao,
                    :BanGiao_GhiChu,
                    :DieuDuongVongTrong,
                    :DieuDuongVongNgoai,
                    :NguoiLapBang,
                    :MaNguoiLapBang,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (bangKiemSauKhiMo.ID != 0)
                {
                    sql = @"UPDATE BangKiemSauKhiMo SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    NgayGioMo = :NgayGioMo,
                    NgayGioKetThuc = :NgayGioKetThuc,
                    ChanDoanSauMo = :ChanDoanSauMo,
                    LoaiPhauThuat = :LoaiPhauThuat,
                    YCu_SoLuong = :YCu_SoLuong,
                    YCu = :YCu,
                    YCu_LyDo = :YCu_LyDo,
                    GacBung_SoLuong = :GacBung_SoLuong,
                    GacBung = :GacBung,
                    GacBung_LyDo = :GacBung_LyDo,
                    GacMeChe_SoLuong = :GacMeChe_SoLuong,
                    GacMeChe = :GacMeChe,
                    GacMeChe_LyDo = :GacMeChe_LyDo,
                    KimPhauThuat_SoLuong = :KimPhauThuat_SoLuong,
                    KimPhauThuat = :KimPhauThuat,
                    KimPhauThuat_LyDo = :KimPhauThuat_LyDo,
                    BanGiao = :BanGiao,
                    BanGiao_GhiChu = :BanGiao_GhiChu,
                    DieuDuongVongTrong = :DieuDuongVongTrong,
                    DieuDuongVongNgoai = :DieuDuongVongNgoai,
                    NguoiLapBang = :NguoiLapBang,
                    MaNguoiLapBang = :MaNguoiLapBang,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + bangKiemSauKhiMo.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangKiemSauKhiMo.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", bangKiemSauKhiMo.MaBenhNhan));
                var Ngay = bangKiemSauKhiMo.NgayMo.Date.Add(new TimeSpan(0, 0, 0));
                var Gio = bangKiemSauKhiMo.GioMo != null ? bangKiemSauKhiMo.GioMo.TimeOfDay : DateTime.Now.TimeOfDay;
                var NgayGioMo = Ngay + Gio;
                Command.Parameters.Add(new MDB.MDBParameter("NgayGioMo", NgayGioMo));

                Ngay = bangKiemSauKhiMo.NgayKetThuc.Date.Add(new TimeSpan(0, 0, 0));
                Gio = bangKiemSauKhiMo.GioKetThuc != null ? bangKiemSauKhiMo.GioKetThuc.TimeOfDay : DateTime.Now.TimeOfDay;
                var NgayGioKetThuc = Ngay + Gio;
                Command.Parameters.Add(new MDB.MDBParameter("NgayGioKetThuc", NgayGioKetThuc));

                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanSauMo", bangKiemSauKhiMo.ChanDoanSauMo));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiPhauThuat", bangKiemSauKhiMo.LoaiPhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("YCu_SoLuong", bangKiemSauKhiMo.YCu_SoLuong));
                Command.Parameters.Add(new MDB.MDBParameter("YCu", bangKiemSauKhiMo.YCu));
                Command.Parameters.Add(new MDB.MDBParameter("YCu_LyDo", bangKiemSauKhiMo.YCu_LyDo));
                Command.Parameters.Add(new MDB.MDBParameter("GacBung_SoLuong", bangKiemSauKhiMo.GacBung_SoLuong));
                Command.Parameters.Add(new MDB.MDBParameter("GacBung", bangKiemSauKhiMo.GacBung));
                Command.Parameters.Add(new MDB.MDBParameter("GacBung_LyDo", bangKiemSauKhiMo.GacBung_LyDo));
                Command.Parameters.Add(new MDB.MDBParameter("GacMeChe_SoLuong", bangKiemSauKhiMo.GacMeChe_SoLuong));
                Command.Parameters.Add(new MDB.MDBParameter("GacMeChe", bangKiemSauKhiMo.GacMeChe));
                Command.Parameters.Add(new MDB.MDBParameter("GacMeChe_LyDo", bangKiemSauKhiMo.GacMeChe_LyDo));
                Command.Parameters.Add(new MDB.MDBParameter("KimPhauThuat_SoLuong", bangKiemSauKhiMo.KimPhauThuat_SoLuong));
                Command.Parameters.Add(new MDB.MDBParameter("KimPhauThuat", bangKiemSauKhiMo.KimPhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("KimPhauThuat_LyDo", bangKiemSauKhiMo.KimPhauThuat_LyDo));
                Command.Parameters.Add(new MDB.MDBParameter("BanGiao", bangKiemSauKhiMo.BanGiao));
                Command.Parameters.Add(new MDB.MDBParameter("BanGiao_GhiChu", bangKiemSauKhiMo.BanGiao_GhiChu));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuongVongTrong", bangKiemSauKhiMo.DieuDuongVongTrong));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuongVongNgoai", bangKiemSauKhiMo.DieuDuongVongNgoai));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiLapBang", bangKiemSauKhiMo.NguoiLapBang));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiLapBang", bangKiemSauKhiMo.MaNguoiLapBang));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", bangKiemSauKhiMo.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", bangKiemSauKhiMo.NgaySua));
                if (bangKiemSauKhiMo.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", bangKiemSauKhiMo.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", bangKiemSauKhiMo.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", bangKiemSauKhiMo.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (bangKiemSauKhiMo.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    bangKiemSauKhiMo.ID = nextval;
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
                string sql = "DELETE FROM BangKiemSauKhiMo WHERE ID = :ID";
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
                BangKiemSauKhiMo B
                JOIN THONGTINDIEUTRI T ON B.MAQUANLY = T.MAQUANLY
                JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "BK");

            DataTable thongTinVien = new DataTable("HEADER");

            thongTinVien.Columns.Add("BENHVIEN");
            thongTinVien.Columns.Add("KHOA");
			if (XemBenhAn._HanhChinhBenhNhan == null) XemBenhAn._HanhChinhBenhNhan = new HanhChinhBenhNhan();
            if (XemBenhAn._ThongTinDieuTri == null) XemBenhAn._ThongTinDieuTri = new ThongTinDieuTri();
            thongTinVien.Rows.Add(XemBenhAn._HanhChinhBenhNhan.BenhVien, XemBenhAn._ThongTinDieuTri.Khoa);
            ds.Tables.Add(thongTinVien);

            return ds;
        }
    }
}
