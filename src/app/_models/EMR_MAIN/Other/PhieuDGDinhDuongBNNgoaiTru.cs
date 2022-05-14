using EMR.KyDienTu;
using Newtonsoft.Json;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuDGDinhDuongBNNgoaiTru : ThongTinKy
    {
        public PhieuDGDinhDuongBNNgoaiTru()
        {
            TableName = "PhieuDGDinhDuongBNNgoaiTru";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PSLDDBNNT;
            TenMauPhieu = DanhMucPhieu.PSLDDBNNT.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        public string HoTenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Giường")]
		public string Giuong { get; set; }
        [MoTaDuLieu("Buồng")]
		public string Buong { get; set; }
        [MoTaDuLieu("Ngày vào bệnh viện")]
		public DateTime NgayVaoVien { get; set; }
        public string SoVaoVien { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Cân nặng")]
		public string CanNang { get; set; }
        [MoTaDuLieu("Chiều cao")]
		public string ChieuCao { get; set; }
        [MoTaDuLieu("Họ tên điều dưỡng")]
		public string DieuDuong { get; set; }
        [MoTaDuLieu("Mã điều dưỡng")]
		public string MaDieuDuong { get; set; }
        [MoTaDuLieu("Bác sỹ")]
		public string BacSy { get; set; }
        [MoTaDuLieu("Mã bác sỹ")]
		public string MaBacSy { get; set; }

        public bool[] GiamCanArray { get; } = new bool[] { false, false};
        public string GiamCan
        {
            get
            {
                string temp = "";
                for (int i = 0; i < GiamCanArray.Length; i++)
                    temp += (GiamCanArray[i] ? "1" : "0");
                return temp;    
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        GiamCanArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] SoCanArray { get; } = new bool[] { false, false, false, false };
        public string SoCan
        {
            get
            {
                string temp = "";
                for (int i = 0; i < SoCanArray.Length; i++)
                    temp += (SoCanArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        SoCanArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string ChiSoSutCan { get; set; }

        public bool[] NgonMiengArray { get; } = new bool[] { false, false };
        public string NgonMieng
        {
            get
            {
                string temp = "";
                for (int i = 0; i < NgonMiengArray.Length; i++)
                    temp += (NgonMiengArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NgonMiengArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string ChiSoNgonMieng { get; set; }
        public string ChiSoMST { get; set; }
        public bool[] KetLuanArray { get; } = new bool[] { false, false };
        public string KetLuan
        {
            get
            {
                string temp = "";
                for (int i = 0; i < KetLuanArray.Length; i++)
                    temp += (KetLuanArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        KetLuanArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Ghi chú")]
		public string GhiChu { get; set; }
        public string MaCheDoAn { get; set; }
        public bool[] DuongNuoiDuongArray { get; } = new bool[] { false, false, false};
        public string DuongNuoiDuong
        {
            get
            {
                string temp = "";
                for (int i = 0; i < DuongNuoiDuongArray.Length; i++)
                    temp += (DuongNuoiDuongArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DuongNuoiDuongArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string DuongNuoiDuong_Text { get; set; }
        public bool[] TuVanArray { get; } = new bool[] { false, false, false };
        public string TuVan
        {
            get
            {
                string temp = "";
                for (int i = 0; i < TuVanArray.Length; i++)
                    temp += (TuVanArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TuVanArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
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
    public class PhieuDGDinhDuongBNNgoaiTruFunc
    {
        public const string TableName = "PhieuDGDinhDuongBNNgoaiTru";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuDGDinhDuongBNNgoaiTru> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuDGDinhDuongBNNgoaiTru> list = new List<PhieuDGDinhDuongBNNgoaiTru>();
            try
            {
                string sql = @"SELECT * FROM PhieuDGDinhDuongBNNgoaiTru where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuDGDinhDuongBNNgoaiTru data = new PhieuDGDinhDuongBNNgoaiTru();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.HoTenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.Khoa = XemBenhAn._ThongTinDieuTri.Khoa;
                    data.Giuong = DataReader["Giuong"].ToString();
                    data.Buong = DataReader["Buong"].ToString();
                    data.NgayVaoVien = Convert.ToDateTime(DataReader["NgayVaoVien"] == DBNull.Value ? DateTime.Now : DataReader["NgayVaoVien"]);

                    data.SoVaoVien = DataReader["SoVaoVien"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.CanNang = DataReader["CanNang"].ToString();
                    data.ChieuCao = DataReader["ChieuCao"].ToString();
                    data.DieuDuong = DataReader["DieuDuong"].ToString();
                    data.MaDieuDuong = DataReader["MaDieuDuong"].ToString();
                    data.BacSy = DataReader["BacSy"].ToString();
                    data.MaBacSy = DataReader["MaBacSy"].ToString();
                    data.GiamCan = DataReader["GiamCan"].ToString();
                    data.SoCan = DataReader["SoCan"].ToString();
                    data.ChiSoSutCan = DataReader["ChiSoSutCan"].ToString();
                    data.NgonMieng = DataReader["NgonMieng"].ToString();
                    data.ChiSoNgonMieng = DataReader["ChiSoNgonMieng"].ToString();
                    data.ChiSoMST = DataReader["ChiSoMST"].ToString();
                    data.KetLuan = DataReader["KetLuan"].ToString();
                    data.GhiChu = DataReader["GhiChu"].ToString();
                    data.MaCheDoAn = DataReader["MaCheDoAn"].ToString();
                    data.DuongNuoiDuong = DataReader["DuongNuoiDuong"].ToString();
                    data.DuongNuoiDuong_Text = DataReader["DuongNuoiDuong_Text"].ToString();
                    data.TuVan = DataReader["TuVan"].ToString();

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuDGDinhDuongBNNgoaiTru bangKe)
        {
            try
            {
                string sql = @"INSERT INTO PhieuDGDinhDuongBNNgoaiTru
                (
                    MAQUANLY,
                    Giuong,
                    Buong,
                    NgayVaoVien,
                    SoVaoVien,
                    ChanDoan,
                    CanNang,
                    ChieuCao,
                    DieuDuong,
                    MaDieuDuong,
                    BacSy,
                    MaBacSy,
                    GiamCan,
                    SoCan,
                    ChiSoSutCan,
                    NgonMieng,
                    ChiSoNgonMieng,
                    ChiSoMST,
                    KetLuan,
                    GhiChu,
                    MaCheDoAn,
                    DuongNuoiDuong,
                    DuongNuoiDuong_Text,
                    TuVan,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :Giuong,
                    :Buong,
                    :NgayVaoVien,
                    :SoVaoVien,
                    :ChanDoan,
                    :CanNang,
                    :ChieuCao,
                    :DieuDuong,
                    :MaDieuDuong,
                    :BacSy,
                    :MaBacSy,
                    :GiamCan,
                    :SoCan,
                    :ChiSoSutCan,
                    :NgonMieng,
                    :ChiSoNgonMieng,
                    :ChiSoMST,
                    :KetLuan,
                    :GhiChu,
                    :MaCheDoAn,
                    :DuongNuoiDuong,
                    :DuongNuoiDuong_Text,
                    :TuVan,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (bangKe.ID != 0)
                {
                    sql = @"UPDATE PhieuDGDinhDuongBNNgoaiTru SET 
                    MAQUANLY = :MAQUANLY,
                    Giuong = :Giuong,
                    Buong = :Buong,
                    NgayVaoVien = :NgayVaoVien,
                    SoVaoVien = :SoVaoVien,
                    ChanDoan = :ChanDoan,
                    CanNang = :CanNang,
                    ChieuCao = :ChieuCao,
                    DieuDuong = :DieuDuong,
                    MaDieuDuong = :MaDieuDuong,
                    BacSy = :BacSy,
                    MaBacSy = :MaBacSy,
                    GiamCan = :GiamCan,
                    SoCan = :SoCan,
                    ChiSoSutCan = :ChiSoSutCan,
                    NgonMieng = :NgonMieng,
                    ChiSoNgonMieng = :ChiSoNgonMieng,
                    ChiSoMST = :ChiSoMST,
                    KetLuan = :KetLuan,
                    GhiChu = :GhiChu,
                    MaCheDoAn = :MaCheDoAn,
                    DuongNuoiDuong = :DuongNuoiDuong,
                    DuongNuoiDuong_Text = :DuongNuoiDuong_Text,
                    TuVan = :TuVan,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + bangKe.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangKe.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("Giuong", bangKe.Giuong));
                Command.Parameters.Add(new MDB.MDBParameter("Buong", bangKe.Buong));
                Command.Parameters.Add(new MDB.MDBParameter("NgayVaoVien", bangKe.NgayVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("SoVaoVien", bangKe.SoVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", bangKe.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang", bangKe.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("ChieuCao", bangKe.ChieuCao));
                Command.Parameters.Add(new MDB.MDBParameter("DieuDuong", bangKe.DieuDuong));
                Command.Parameters.Add(new MDB.MDBParameter("MaDieuDuong", bangKe.MaDieuDuong));
                Command.Parameters.Add(new MDB.MDBParameter("BacSy", bangKe.BacSy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSy", bangKe.MaBacSy));
                Command.Parameters.Add(new MDB.MDBParameter("GiamCan", bangKe.GiamCan));
                Command.Parameters.Add(new MDB.MDBParameter("SoCan", bangKe.SoCan));
                Command.Parameters.Add(new MDB.MDBParameter("ChiSoSutCan", bangKe.ChiSoSutCan));
                Command.Parameters.Add(new MDB.MDBParameter("NgonMieng", bangKe.NgonMieng));
                Command.Parameters.Add(new MDB.MDBParameter("ChiSoNgonMieng", bangKe.ChiSoNgonMieng));
                Command.Parameters.Add(new MDB.MDBParameter("ChiSoMST", bangKe.ChiSoMST));
                Command.Parameters.Add(new MDB.MDBParameter("KetLuan", bangKe.KetLuan));
                Command.Parameters.Add(new MDB.MDBParameter("GhiChu", bangKe.GhiChu));
                Command.Parameters.Add(new MDB.MDBParameter("MaCheDoAn", bangKe.MaCheDoAn));
                Command.Parameters.Add(new MDB.MDBParameter("DuongNuoiDuong", bangKe.DuongNuoiDuong));
                Command.Parameters.Add(new MDB.MDBParameter("DuongNuoiDuong_Text", bangKe.DuongNuoiDuong_Text));
                Command.Parameters.Add(new MDB.MDBParameter("TuVan", bangKe.TuVan));

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", bangKe.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", bangKe.NgaySua));
                if (bangKe.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", bangKe.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", bangKe.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", bangKe.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (bangKe.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    bangKe.ID = nextval;
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
                string sql = "DELETE FROM PhieuDGDinhDuongBNNgoaiTru WHERE ID = :ID";
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
                *
            FROM
                PhieuDGDinhDuongBNNgoaiTru B
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);

            var ds = new DataSet();

            adt.Fill(ds, "TB");
            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(string));
            ds.Tables[0].AddColumn("Khoa", typeof(string));
            ds.Tables[0].AddColumn("SoYTe", typeof(string));
            ds.Tables[0].AddColumn("BenhVien", typeof(string));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            ds.Tables[0].Rows[0]["Khoa"] = XemBenhAn._ThongTinDieuTri.Khoa;
            ds.Tables[0].Rows[0]["SoYTe"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BenhVien"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;

            return ds;

        }
    }
}
