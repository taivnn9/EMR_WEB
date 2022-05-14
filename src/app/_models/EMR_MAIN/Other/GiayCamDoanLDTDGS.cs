using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class GiayCamDoanLDTDGS : ThongTinKy
    {
        public GiayCamDoanLDTDGS()
        {
            TableName = "GiayCamDoanLDTDGS";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.GCDLDTDGS;
            TenMauPhieu = DanhMucPhieu.GCDLDTDGS.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }

        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Mã bệnh án")]
		public string MaBenhAn { get; set; }

        public string HoTen { get; set; }

        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }

        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        [MoTaDuLieu("Họ tên người thân")]
		public string NguoiThan { get; set; }

        public string TinhOrHuyen { get; set; }
        public DateTime? NgayVietDon { get; set; }

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
    
    public class GiayCamDoanLDTDGSFunc
    {
        public const string TableName = "GiayCamDoanLDTDGS";
        public const string TablePrimaryKeyName = "ID";
        public const string MaPhieu = "GCDLDTDGS";

        public static List<GiayCamDoanLDTDGS> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<GiayCamDoanLDTDGS> list = new List<GiayCamDoanLDTDGS>();
            try
            {
                string sql = @"SELECT * FROM GiayCamDoanLDTDGS where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    GiayCamDoanLDTDGS data = new GiayCamDoanLDTDGS();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.MaBenhAn = DataReader["MaBenhAn"].ToString();

                    data.HoTen = DataReader["HoTen"].ToString();
                    data.DiaChi = DataReader["DiaChi"].ToString();
                    data.DienThoai = DataReader["DienThoai"].ToString();
                    data.Tuoi = DataReader["Tuoi"].ToString();
                    data.TinhOrHuyen = DataReader["TinhOrHuyen"].ToString();
                    data.NguoiThan = DataReader["NguoiThan"].ToString();
                    data.GioiTinh = DataReader["GioiTinh"].ToString(); 
                   
                    data.NgayVietDon = Convert.ToDateTime(DataReader["NgayVietDon"] == DBNull.Value ? DateTime.Now : DataReader["NgayVietDon"]);
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

        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref GiayCamDoanLDTDGS bangKiem)
        {
            try
            {
                string sql = @"INSERT INTO GiayCamDoanLDTDGS
                (
                    MAQUANLY,
                    MaBenhNhan,
                    MaBenhAn,
                    HoTen,
                    Tuoi,
                    GioiTinh,
                    DiaChi,
                    DienThoai,
                    NguoiThan,
                    TinhOrHuyen,
                    NgayVietDon,
                    NgayTao,
                    NguoiTao,
                    NguoiSua,
                    NgaySua)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :MaBenhAn,
                    :HoTen,
                    :Tuoi,
                    :GioiTinh,
                    :DiaChi,
                    :DienThoai,
                    :NguoiThan,
                    :TinhOrHuyen,
                    :NgayVietDon,
                    :NgayTao,
                    :NguoiTao,
                    :NguoiSua,
                    :NgaySua
                 )  RETURNING ID INTO :ID";
                if (bangKiem.ID != 0)
                {
                    sql = @"UPDATE GiayCamDoanLDTDGS SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    MaBenhAn = :MaBenhAn,
					HoTen = :HoTen,
                    Tuoi = :Tuoi,
                    GioiTinh = :GioiTinh,
                    DiaChi = :DiaChi,
                    DienThoai = :DienThoai,
                    NguoiThan = :NguoiThan,
                    TinhOrHuyen = :TinhOrHuyen,
                    NgayVietDon = :NgayVietDon,
                    NguoiSua = :NguoiSua,
                    NgaySua = :NgaySua
                    WHERE ID = " + bangKiem.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangKiem.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", bangKiem.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhAn", bangKiem.MaBenhAn));
                Command.Parameters.Add(new MDB.MDBParameter("HoTen", bangKiem.HoTen));
                Command.Parameters.Add(new MDB.MDBParameter("Tuoi", bangKiem.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("GioiTinh", bangKiem.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", bangKiem.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("DienThoai", bangKiem.DienThoai));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiThan", bangKiem.NguoiThan));
                Command.Parameters.Add(new MDB.MDBParameter("TinhOrHuyen", bangKiem.TinhOrHuyen));
                Command.Parameters.Add(new MDB.MDBParameter("NgayVietDon", bangKiem.NgayVietDon));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiSua", bangKiem.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NgaySua", bangKiem.NgaySua));
                if (bangKiem.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", bangKiem.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NguoiTao", bangKiem.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NgayTao", bangKiem.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (bangKiem.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    bangKiem.ID = nextval;
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
                string sql = "DELETE FROM GiayCamDoanLDTDGS WHERE ID = :ID";
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
                GiayCamDoanLDTDGS B
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);

            var ds = new DataSet();

            adt.Fill(ds, "TB");
            ds.Tables[0].AddColumn("SOYTE", typeof(string));
            ds.Tables[0].AddColumn("BENHVIEN", typeof(string));
            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["SOYTE"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;

            return ds;
        }
    }
}
