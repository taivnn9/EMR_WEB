using EMR.KyDienTu;
using Newtonsoft.Json;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class BangKeVTTHPhongPTTT : ThongTinKy
    {
        public BangKeVTTHPhongPTTT()
        {
            TableName = "BangKeVTTHPhongPTTT";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BKVTTHPTTT;
            TenMauPhieu = DanhMucPhieu.BKVTTHPTTT.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")] 
        public string HoTenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }
        [MoTaDuLieu("Giường")]
		public string Giuong { get; set; }
        public DateTime? Ngay11 { get; set; }
        public DateTime? Ngay12 { get; set; }
        public DateTime? Ngay13 { get; set; }
        public DateTime? Ngay14 { get; set; }
        public DateTime? Ngay21 { get; set; }
        public DateTime? Ngay22 { get; set; }
        public DateTime? Ngay23 { get; set; }
        public DateTime? Ngay24 { get; set; }
        [MoTaDuLieu("Danh sách vật tư tiêu hao thứ 1")]
        public ObservableCollection<DataVatTuTieuHao> List1 { get; set; }
        [MoTaDuLieu("Danh sách vật tư tiêu hao thứ 2")]
        public ObservableCollection<DataVatTuTieuHao> List2 { get; set; }
        [MoTaDuLieu("Người lập phiếu")]
        public string NguoiLapPhieu { get; set; }
        [MoTaDuLieu("Mã người lập phiếu")]
        public string MaNguoiLapPhieu { get; set; }
        // bắt buộc
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
    public class DataVatTuTieuHao
    {
        public int STT { get; set; }
        public string TVT { get; set; }
        public string DV { get; set; }
        public string SL_1 { get; set; }
        public string SL_2 { get; set; }
        public string SL_3 { get; set; }
        public string SL_4 { get; set; }
    }
    public class BangKeVTTHPhongPTTTFunc
    {
        public const string TableName = "BangKeVTTHPhongPTTT";
        public const string TablePrimaryKeyName = "ID";
        public static List<BangKeVTTHPhongPTTT> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BangKeVTTHPhongPTTT> list = new List<BangKeVTTHPhongPTTT>();
            try
            {
                string sql = @"SELECT * FROM BangKeVTTHPhongPTTT where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    BangKeVTTHPhongPTTT data = new BangKeVTTHPhongPTTT();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.HoTenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.Khoa = DataReader["Khoa"].ToString();
                    data.MaKhoa = DataReader["MaKhoa"].ToString();
                    data.Giuong = DataReader["Giuong"].ToString();

                    data.Ngay11 = DataReader["Ngay11"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["Ngay11"]) : null;
                    data.Ngay12 = DataReader["Ngay12"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["Ngay12"]) : null;
                    data.Ngay13 = DataReader["Ngay13"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["Ngay13"]) : null;
                    data.Ngay14 = DataReader["Ngay14"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["Ngay14"]) : null;
                    data.Ngay21 = DataReader["Ngay21"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["Ngay21"]) : null;
                    data.Ngay22 = DataReader["Ngay22"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["Ngay22"]) : null;
                    data.Ngay23 = DataReader["Ngay23"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["Ngay23"]) : null;
                    data.Ngay24 = DataReader["Ngay24"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(DataReader["Ngay24"]) : null;
                    data.List1 = JsonConvert.DeserializeObject<ObservableCollection<DataVatTuTieuHao>>(DataReader["List1"].ToString());
                    data.List2 = JsonConvert.DeserializeObject<ObservableCollection<DataVatTuTieuHao>>(DataReader["List2"].ToString());

                    data.NguoiLapPhieu = DataReader["NguoiLapPhieu"].ToString();
                    data.MaNguoiLapPhieu = DataReader["MaNguoiLapPhieu"].ToString();

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BangKeVTTHPhongPTTT ketQua)
        {
            try
            {
                string sql = @"INSERT INTO BangKeVTTHPhongPTTT
                (
                    MAQUANLY,
                    MaBenhNhan,
                    ChanDoan,
                    Khoa,
                    MaKhoa,
                    Giuong,
                    Ngay11,
                    Ngay12,
                    Ngay13,
                    Ngay14,
                    Ngay21,
                    Ngay22,
                    Ngay23,
                    Ngay24,
                    List1,
                    List2,
                    NguoiLapPhieu,
                    MaNguoiLapPhieu,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :ChanDoan,
                    :Khoa,
                    :MaKhoa,
                    :Giuong,
                    :Ngay11,
                    :Ngay12,
                    :Ngay13,
                    :Ngay14,
                    :Ngay21,
                    :Ngay22,
                    :Ngay23,
                    :Ngay24,
                    :List1,
                    :List2,
                    :NguoiLapPhieu,
                    :MaNguoiLapPhieu,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE BangKeVTTHPhongPTTT SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    ChanDoan = :ChanDoan,
                    Khoa = :Khoa,
                    MaKhoa = :MaKhoa,
                    Giuong = :Giuong,
                    Ngay11 = :Ngay11,
                    Ngay12 = :Ngay12,
                    Ngay13 = :Ngay13,
                    Ngay14 = :Ngay14,
                    Ngay21 = :Ngay21,
                    Ngay22 = :Ngay22,
                    Ngay23 = :Ngay23,
                    Ngay24 = :Ngay24,
                    List1 = :List1,
                    List2 = :List2,
                    NguoiLapPhieu = :NguoiLapPhieu,
                    MaNguoiLapPhieu = :MaNguoiLapPhieu,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", ketQua.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", ketQua.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", ketQua.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa", ketQua.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaKhoa", ketQua.MaKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("Giuong", ketQua.Giuong));
                Command.Parameters.Add(new MDB.MDBParameter("Ngay11", ketQua.Ngay11));
                Command.Parameters.Add(new MDB.MDBParameter("Ngay12", ketQua.Ngay12));
                Command.Parameters.Add(new MDB.MDBParameter("Ngay13", ketQua.Ngay13));
                Command.Parameters.Add(new MDB.MDBParameter("Ngay14", ketQua.Ngay14));
                Command.Parameters.Add(new MDB.MDBParameter("Ngay21", ketQua.Ngay21));
                Command.Parameters.Add(new MDB.MDBParameter("Ngay22", ketQua.Ngay22));
                Command.Parameters.Add(new MDB.MDBParameter("Ngay23", ketQua.Ngay23));
                Command.Parameters.Add(new MDB.MDBParameter("Ngay24", ketQua.Ngay24));
                Command.Parameters.Add(new MDB.MDBParameter("List1", JsonConvert.SerializeObject(ketQua.List1)));
                Command.Parameters.Add(new MDB.MDBParameter("List2", JsonConvert.SerializeObject(ketQua.List2)));

                Command.Parameters.Add(new MDB.MDBParameter("NguoiLapPhieu", ketQua.NguoiLapPhieu));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiLapPhieu", ketQua.MaNguoiLapPhieu));

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));
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
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool delete(MDB.MDBConnection MyConnection, long id)
        {
            try
            {
                string sql = "DELETE FROM BangKeVTTHPhongPTTT WHERE ID = :ID";
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
                P.MAQUANLY,
                P.MaBenhNhan,
                P.ChanDoan,
                P.Khoa,
                P.MaKhoa,
                P.Giuong,
                P.Ngay11,
                P.Ngay12,
                P.Ngay13,
                P.Ngay14,
                P.Ngay21,
                P.Ngay22,
                P.Ngay23,
                P.Ngay24,
                P.NguoiLapPhieu,
                P.MaNguoiLapPhieu,
	            H.SOYTE,
	            H.BENHVIEN
            FROM
                BangKeVTTHPhongPTTT P 
                LEFT JOIN HANHCHINHBENHNHAN H ON P.MABENHNHAN = H.MABENHNHAN
            WHERE
                P.ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "KQ");

            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(string));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();

            sql = @"SELECT List1, List2 FROM BangKeVTTHPhongPTTT where ID = :ID";
            Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("ID", id));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            ObservableCollection<DataVatTuTieuHao> List1 = new ObservableCollection<DataVatTuTieuHao>();
            ObservableCollection<DataVatTuTieuHao> List2 = new ObservableCollection<DataVatTuTieuHao>();
            while (DataReader.Read())
            {
                List1 = JsonConvert.DeserializeObject<ObservableCollection<DataVatTuTieuHao>>(DataReader["List1"].ToString());
                List2 = JsonConvert.DeserializeObject<ObservableCollection<DataVatTuTieuHao>>(DataReader["List2"].ToString());
            }
            DataTable ChiTiet = new DataTable("CT");
            ChiTiet.AddColumn("STT1", typeof(string));
            ChiTiet.AddColumn("TVT1", typeof(string));
            ChiTiet.AddColumn("DV1", typeof(string));
            ChiTiet.AddColumn("N11", typeof(string));
            ChiTiet.AddColumn("N12", typeof(string));
            ChiTiet.AddColumn("N13", typeof(string));
            ChiTiet.AddColumn("N14", typeof(string));

            ChiTiet.AddColumn("STT2", typeof(string));
            ChiTiet.AddColumn("TVT2", typeof(string));
            ChiTiet.AddColumn("DV2", typeof(string));
            ChiTiet.AddColumn("N21", typeof(string));
            ChiTiet.AddColumn("N22", typeof(string));
            ChiTiet.AddColumn("N23", typeof(string));
            ChiTiet.AddColumn("N24", typeof(string));

            if(List1.Count >= List2.Count)
            {
                for(int i = 0;i < List1.Count; i++)
                {
                    if(i < List2.Count)
                    {
                        ChiTiet.Rows.Add(List1[i].STT.ToString(),
                            List1[i].TVT,
                            List1[i].DV,
                            List1[i].SL_1,
                            List1[i].SL_2,
                            List1[i].SL_3,
                            List1[i].SL_4,
                            List2[i].STT.ToString(),
                            List2[i].TVT,
                            List2[i].DV,
                            List2[i].SL_1,
                            List2[i].SL_2,
                            List2[i].SL_3,
                            List2[i].SL_4);
                    }
                    else
                    {
                        ChiTiet.Rows.Add(List1[i].STT.ToString(),
                            List1[i].TVT,
                            List1[i].DV,
                            List1[i].SL_1,
                            List1[i].SL_2,
                            List1[i].SL_3,
                            List1[i].SL_4,
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                            "");
                    }    
                }
            }
            else
            {
                for (int i = 0; i < List2.Count; i++)
                {
                    if (i < List1.Count)
                    {
                        ChiTiet.Rows.Add(List1[i].STT.ToString(),
                            List1[i].TVT,
                            List1[i].DV,
                            List1[i].SL_1,
                            List1[i].SL_2,
                            List1[i].SL_3,
                            List1[i].SL_4,
                            List2[i].STT.ToString(),
                            List2[i].TVT,
                            List2[i].DV,
                            List2[i].SL_1,
                            List2[i].SL_2,
                            List2[i].SL_3,
                            List2[i].SL_4);
                    }
                    else
                    {
                        ChiTiet.Rows.Add("",
                           "",
                           "",
                           "",
                           "",
                           "",
                           "",
                           List2[i].STT.ToString(),
                           List2[i].TVT,
                           List2[i].DV,
                           List2[i].SL_1,
                           List2[i].SL_2,
                           List2[i].SL_3,
                           List2[i].SL_4);
                    }
                }
            }
            ds.Tables.Add(ChiTiet);
            return ds;
        }
    }

}
