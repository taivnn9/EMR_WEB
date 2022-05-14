using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class ChuanBiBenhNhanChupMSCT : ThongTinKy
    {
        public ChuanBiBenhNhanChupMSCT()
        {
            TableName = "ChuanBiBenhNhanChupMSCT";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.CBBNCMSCT;
            TenMauPhieu = DanhMucPhieu.CBBNCMSCT.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        public string HoTenBenhNhan { get; set; }
        [MoTaDuLieu("Năm sinh")]
		public string NamSinh { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public string YeuCauChup { get; set; }
        public DateTime? NgayChup { get; set; }
        public string ThuocDangDung { get; set; }
        public string DaDung { get; set; }
        public int BangKiem1 { get; set; }
        public string BangKiem1_MoTa { get; set; }
        public int BangKiem2 { get; set; }
        public string BangKiem2_MoTa { get; set; }
        public int BangKiem3 { get; set; }
        public string BangKiem3_MoTa { get; set; }
        public int BangKiem4 { get; set; }
        public string BangKiem4_MoTa { get; set; }
        public int BangKiem5 { get; set; }
        public string BangKiem5_MoTa { get; set; }
        public int BangKiem6 { get; set; }
        public string BangKiem6_MoTa { get; set; }
        public int BangKiem7 { get; set; }
        public string BangKiem7_MoTa { get; set; }
        public int BangKiem8 { get; set; }
        public string BangKiem8_MoTa { get; set; }
        public int BangKiem9 { get; set; }
        public string BangKiem9_MoTa { get; set; }
        public int BangKiem10 { get; set; }
        public string BangKiem10_MoTa { get; set; }
        public int BangKiem11 { get; set; }
        public string BangKiem11_MoTa { get; set; }
        public int BangKiem12 { get; set; }
        public string BangKiem12_MoTa { get; set; }
        public int BangKiem13 { get; set; }
        public string BangKiem13_MoTa { get; set; }
        public int BangKiem14 { get; set; }
        public string BangKiem14_MoTa { get; set; }
        public int BangKiem15 { get; set; }
        public string BangKiem15_MoTa { get; set; }
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
    public class ChuanBiBenhNhanChupMSCTFunc
    {
        public const string TableName = "ChuanBiBenhNhanChupMSCT";
        public const string TablePrimaryKeyName = "ID";
        public static List<ChuanBiBenhNhanChupMSCT> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<ChuanBiBenhNhanChupMSCT> list = new List<ChuanBiBenhNhanChupMSCT>();
            try
            {
                string sql = @"SELECT * FROM ChuanBiBenhNhanChupMSCT where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    ChuanBiBenhNhanChupMSCT data = new ChuanBiBenhNhanChupMSCT();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.HoTenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.NamSinh = XemBenhAn._HanhChinhBenhNhan.NgaySinh.HasValue ? XemBenhAn._HanhChinhBenhNhan.NgaySinh.Value.Year+"": null;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.YeuCauChup = DataReader["YeuCauChup"].ToString();
                    data.NgayChup = DataReader["NgayChup"] != DBNull.Value ? (DateTime?) Convert.ToDateTime(DataReader["NgayChup"].ToString()): null;
                    data.ThuocDangDung = DataReader["ThuocDangDung"].ToString();
                    data.DaDung = DataReader["DaDung"].ToString();
                    int intTemp = 0;
                    data.BangKiem1 = int.TryParse(DataReader["BangKiem1"].ToString(), out intTemp) ? intTemp: 0;
                    data.BangKiem1_MoTa = DataReader["BangKiem1_MoTa"].ToString();
                    data.BangKiem2 = int.TryParse(DataReader["BangKiem2"].ToString(), out intTemp) ? intTemp : 0;
                    data.BangKiem2_MoTa = DataReader["BangKiem2_MoTa"].ToString();
                    data.BangKiem3 = int.TryParse(DataReader["BangKiem3"].ToString(), out intTemp) ? intTemp : 0;
                    data.BangKiem3_MoTa = DataReader["BangKiem3_MoTa"].ToString();
                    data.BangKiem4 = int.TryParse(DataReader["BangKiem4"].ToString(), out intTemp) ? intTemp : 0;
                    data.BangKiem4_MoTa = DataReader["BangKiem4_MoTa"].ToString();
                    data.BangKiem5 = int.TryParse(DataReader["BangKiem5"].ToString(), out intTemp) ? intTemp : 0;
                    data.BangKiem5_MoTa = DataReader["BangKiem5_MoTa"].ToString();
                    data.BangKiem6 = int.TryParse(DataReader["BangKiem6"].ToString(), out intTemp) ? intTemp : 0;
                    data.BangKiem6_MoTa = DataReader["BangKiem6_MoTa"].ToString();
                    data.BangKiem7 = int.TryParse(DataReader["BangKiem7"].ToString(), out intTemp) ? intTemp : 0;
                    data.BangKiem7_MoTa = DataReader["BangKiem7_MoTa"].ToString();
                    data.BangKiem8 = int.TryParse(DataReader["BangKiem8"].ToString(), out intTemp) ? intTemp : 0;
                    data.BangKiem8_MoTa = DataReader["BangKiem8_MoTa"].ToString();
                    data.BangKiem9 = int.TryParse(DataReader["BangKiem9"].ToString(), out intTemp) ? intTemp : 0;
                    data.BangKiem9_MoTa = DataReader["BangKiem9_MoTa"].ToString();
                    data.BangKiem10 = int.TryParse(DataReader["BangKiem10"].ToString(), out intTemp) ? intTemp : 0;
                    data.BangKiem10_MoTa = DataReader["BangKiem10_MoTa"].ToString();
                    data.BangKiem11 = int.TryParse(DataReader["BangKiem11"].ToString(), out intTemp) ? intTemp : 0;
                    data.BangKiem11_MoTa = DataReader["BangKiem11_MoTa"].ToString();
                    data.BangKiem12 = int.TryParse(DataReader["BangKiem12"].ToString(), out intTemp) ? intTemp : 0;
                    data.BangKiem12_MoTa = DataReader["BangKiem12_MoTa"].ToString();
                    data.BangKiem13 = int.TryParse(DataReader["BangKiem13"].ToString(), out intTemp) ? intTemp : 0;
                    data.BangKiem13_MoTa = DataReader["BangKiem13_MoTa"].ToString();
                    data.BangKiem14 = int.TryParse(DataReader["BangKiem14"].ToString(), out intTemp) ? intTemp : 0;
                    data.BangKiem14_MoTa = DataReader["BangKiem14_MoTa"].ToString();
                    data.BangKiem15 = int.TryParse(DataReader["BangKiem15"].ToString(), out intTemp) ? intTemp : 0;
                    data.BangKiem15_MoTa = DataReader["BangKiem15_MoTa"].ToString();

                    data.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                    data.NguoiTao = DataReader["NguoiTao"].ToString();
                    data.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);
                    data.NguoiSua = DataReader["NguoiSua"].ToString();

                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;
                    list.Add(data);
                }
                DataReader.Close();
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref ChuanBiBenhNhanChupMSCT bangKe)
        {
            try
            {
                string sql = @"INSERT INTO ChuanBiBenhNhanChupMSCT
                (
                    MAQUANLY,
                    MaBenhNhan,
                    ChanDoan,
                    YeuCauChup,
                    NgayChup,
                    ThuocDangDung,
                    DaDung,
                    BangKiem1,
                    BangKiem1_MoTa,
                    BangKiem2,
                    BangKiem2_MoTa,
                    BangKiem3,
                    BangKiem3_MoTa,
                    BangKiem4,
                    BangKiem4_MoTa,
                    BangKiem5,
                    BangKiem5_MoTa,
                    BangKiem6,
                    BangKiem6_MoTa,
                    BangKiem7,
                    BangKiem7_MoTa,
                    BangKiem8,
                    BangKiem8_MoTa,
                    BangKiem9,
                    BangKiem9_MoTa,
                    BangKiem10,
                    BangKiem10_MoTa,
                    BangKiem11,
                    BangKiem11_MoTa,
                    BangKiem12,
                    BangKiem12_MoTa,
                    BangKiem13,
                    BangKiem13_MoTa,
                    BangKiem14,
                    BangKiem14_MoTa,
                    BangKiem15,
                    BangKiem15_MoTa,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :ChanDoan,
                    :YeuCauChup,
                    :NgayChup,
                    :ThuocDangDung,
                    :DaDung,
                    :BangKiem1,
                    :BangKiem1_MoTa,
                    :BangKiem2,
                    :BangKiem2_MoTa,
                    :BangKiem3,
                    :BangKiem3_MoTa,
                    :BangKiem4,
                    :BangKiem4_MoTa,
                    :BangKiem5,
                    :BangKiem5_MoTa,
                    :BangKiem6,
                    :BangKiem6_MoTa,
                    :BangKiem7,
                    :BangKiem7_MoTa,
                    :BangKiem8,
                    :BangKiem8_MoTa,
                    :BangKiem9,
                    :BangKiem9_MoTa,
                    :BangKiem10,
                    :BangKiem10_MoTa,
                    :BangKiem11,
                    :BangKiem11_MoTa,
                    :BangKiem12,
                    :BangKiem12_MoTa,
                    :BangKiem13,
                    :BangKiem13_MoTa,
                    :BangKiem14,
                    :BangKiem14_MoTa,
                    :BangKiem15,
                    :BangKiem15_MoTa,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (bangKe.ID != 0)
                {
                    sql = @"UPDATE ChuanBiBenhNhanChupMSCT SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    ChanDoan=:ChanDoan,
                    YeuCauChup=:YeuCauChup,
                    NgayChup=:NgayChup,
                    ThuocDangDung=:ThuocDangDung,
                    DaDung=:DaDung,
                    BangKiem1=:BangKiem1,
                    BangKiem1_MoTa=:BangKiem1_MoTa,
                    BangKiem2=:BangKiem2,
                    BangKiem2_MoTa=:BangKiem2_MoTa,
                    BangKiem3=:BangKiem3,
                    BangKiem3_MoTa=:BangKiem3_MoTa,
                    BangKiem4=:BangKiem4,
                    BangKiem4_MoTa=:BangKiem4_MoTa,
                    BangKiem5=:BangKiem5,
                    BangKiem5_MoTa=:BangKiem5_MoTa,
                    BangKiem6=:BangKiem6,
                    BangKiem6_MoTa = :BangKiem6_MoTa,
                    BangKiem7 = :BangKiem7,
                    BangKiem7_MoTa = :BangKiem7_MoTa,
                    BangKiem8 = :BangKiem8,
                    BangKiem8_MoTa = :BangKiem8_MoTa,
                    BangKiem9 = :BangKiem9,
                    BangKiem9_MoTa = :BangKiem9_MoTa,
                    BangKiem10 = :BangKiem10,
                    BangKiem10_MoTa = :BangKiem10_MoTa,
                    BangKiem11 = :BangKiem11,
                    BangKiem11_MoTa = :BangKiem11_MoTa,
                    BangKiem12 = :BangKiem12,
                    BangKiem12_MoTa = :BangKiem12_MoTa,
                    BangKiem13 = :BangKiem13,
                    BangKiem13_MoTa = :BangKiem13_MoTa,
                    BangKiem14 = :BangKiem14,
                    BangKiem14_MoTa = :BangKiem14_MoTa,
                    BangKiem15 = :BangKiem15,
                    BangKiem15_MoTa = :BangKiem15_MoTa,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + bangKe.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangKe.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", bangKe.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", bangKe.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("YeuCauChup", bangKe.YeuCauChup));
                Command.Parameters.Add(new MDB.MDBParameter("NgayChup", bangKe.NgayChup));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocDangDung", bangKe.ThuocDangDung));
                Command.Parameters.Add(new MDB.MDBParameter("DaDung", bangKe.DaDung));
                Command.Parameters.Add(new MDB.MDBParameter("BangKiem1", bangKe.BangKiem1));
                Command.Parameters.Add(new MDB.MDBParameter("BangKiem1_MoTa", bangKe.BangKiem1_MoTa));
                Command.Parameters.Add(new MDB.MDBParameter("BangKiem2", bangKe.BangKiem2));
                Command.Parameters.Add(new MDB.MDBParameter("BangKiem2_MoTa", bangKe.BangKiem2_MoTa));
                Command.Parameters.Add(new MDB.MDBParameter("BangKiem3", bangKe.BangKiem3));
                Command.Parameters.Add(new MDB.MDBParameter("BangKiem3_MoTa", bangKe.BangKiem3_MoTa));
                Command.Parameters.Add(new MDB.MDBParameter("BangKiem4", bangKe.BangKiem4));
                Command.Parameters.Add(new MDB.MDBParameter("BangKiem4_MoTa", bangKe.BangKiem4_MoTa));
                Command.Parameters.Add(new MDB.MDBParameter("BangKiem5", bangKe.BangKiem5));
                Command.Parameters.Add(new MDB.MDBParameter("BangKiem5_MoTa", bangKe.BangKiem5_MoTa));
                Command.Parameters.Add(new MDB.MDBParameter("BangKiem6", bangKe.BangKiem6));
                Command.Parameters.Add(new MDB.MDBParameter("BangKiem6_MoTa", bangKe.BangKiem6_MoTa));
                Command.Parameters.Add(new MDB.MDBParameter("BangKiem7", bangKe.BangKiem7));
                Command.Parameters.Add(new MDB.MDBParameter("BangKiem7_MoTa", bangKe.BangKiem7_MoTa));
                Command.Parameters.Add(new MDB.MDBParameter("BangKiem8", bangKe.BangKiem8));
                Command.Parameters.Add(new MDB.MDBParameter("BangKiem8_MoTa", bangKe.BangKiem8_MoTa));
                Command.Parameters.Add(new MDB.MDBParameter("BangKiem9", bangKe.BangKiem9));
                Command.Parameters.Add(new MDB.MDBParameter("BangKiem9_MoTa", bangKe.BangKiem9_MoTa));
                Command.Parameters.Add(new MDB.MDBParameter("BangKiem10", bangKe.BangKiem10));
                Command.Parameters.Add(new MDB.MDBParameter("BangKiem10_MoTa", bangKe.BangKiem10_MoTa));
                Command.Parameters.Add(new MDB.MDBParameter("BangKiem11", bangKe.BangKiem11));
                Command.Parameters.Add(new MDB.MDBParameter("BangKiem11_MoTa", bangKe.BangKiem11_MoTa));
                Command.Parameters.Add(new MDB.MDBParameter("BangKiem12", bangKe.BangKiem12));
                Command.Parameters.Add(new MDB.MDBParameter("BangKiem12_MoTa", bangKe.BangKiem12_MoTa));
                Command.Parameters.Add(new MDB.MDBParameter("BangKiem13", bangKe.BangKiem13));
                Command.Parameters.Add(new MDB.MDBParameter("BangKiem13_MoTa", bangKe.BangKiem13_MoTa));
                Command.Parameters.Add(new MDB.MDBParameter("BangKiem14", bangKe.BangKiem14));
                Command.Parameters.Add(new MDB.MDBParameter("BangKiem14_MoTa", bangKe.BangKiem14_MoTa));
                Command.Parameters.Add(new MDB.MDBParameter("BangKiem15", bangKe.BangKiem15));
                Command.Parameters.Add(new MDB.MDBParameter("BangKiem15_MoTa", bangKe.BangKiem15_MoTa));

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
        public static bool Delete(MDB.MDBConnection MyConnection, long id)
        {
            try
            {
                string sql = "DELETE FROM ChuanBiBenhNhanChupMSCT WHERE ID = :ID";
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
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, long id)
        {
            string sql = @"SELECT
                B.*,
                H.SOYTE,
                H.BENHVIEN,
                H.TenBenhNhan,
                H.GioiTinh,
				T.MaBenhAn 
            FROM
                ChuanBiBenhNhanChupMSCT B
                LEFT JOIN HANHCHINHBENHNHAN H ON B.MABENHNHAN = H.MABENHNHAN
                LEFT JOIN THONGTINDIEUTRI T ON B.MAQUANLY = T.MAQUANLY
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            adt.Fill(ds, "BK");

            return ds;
        }
    }
}
