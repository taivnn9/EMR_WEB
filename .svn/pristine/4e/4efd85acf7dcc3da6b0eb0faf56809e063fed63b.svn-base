using EMR.KyDienTu;
using System;
using System.Collections.Generic;
using System.Data;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class BangTamSoatBenhNhanNguyCoChatTuongPhanTbl : ThongTinKy
    {
        public BangTamSoatBenhNhanNguyCoChatTuongPhanTbl()
        {
            TableName = "NguyCoChatTuongPhan";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.TSBNCTP;
            TenMauPhieu = DanhMucPhieu.TSBNCTP.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public decimal IDPhieu { get; set; }
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
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        [MoTaDuLieu("Số điện thoại bệnh nhân")]
        public string SoDienThoai { get; set; }
        [MoTaDuLieu("Mạch")]
        public int? Mach { get; set; }
        [MoTaDuLieu("Huyết áp cao nhất")]
        public int? HuyetApMax { get; set; }
        [MoTaDuLieu("Huyết áp thấp nhất")]
        public int? HuyetApMin { get; set; }
        [MoTaDuLieu("Mã người thực hiện")]
		public string MaNguoiThucHien { get; set; }
        [MoTaDuLieu("Họ và tên người thực hiện")]
        public string TenNguoiThucHien { get; set; }
        [MoTaDuLieu("Ghi chú(cho câu hỏi Đã từng có phản ứng dị ứng chưa?)")]
        public string Note_CH1 { get; set; }
        [MoTaDuLieu("Câu trả lời(cho câu hỏi Đã từng có phản ứng dị ứng chưa?)")]
        public int? CH1 { get; set; }
        [MoTaDuLieu("Ghi chú(cho câu hỏi Có bệnh hen suyễn không?)")]
        public string Note_CH2 { get; set; }
        [MoTaDuLieu("Câu trả lời(cho câu hỏi Có bệnh hen suyễn không?)")]
        public int? CH2 { get; set; }
        [MoTaDuLieu("Ghi chú(cho câu hỏi Có bệnh đái tháo đường không?)")]
        public string Note_CH3 { get; set; }
        [MoTaDuLieu("Câu trả lời(cho câu hỏi Có bệnh đái tháo đường không?)")]
        public int? CH3 { get; set; }
        [MoTaDuLieu("Ghi chú(cho câu hỏi Có bệnh lí thận không?)")]
        public string Note_CH4 { get; set; }
        [MoTaDuLieu("Câu trả lời(cho câu hỏi Có bệnh kí thận không?)")]
        public int? CH4 { get; set; }
        [MoTaDuLieu("Ghi chú( cho câu hỏi Có bệnh tăng huyết áp hay bệnh lí tim mạch nào khác hay không)")]
        public string Note_CH5 { get; set; }
        [MoTaDuLieu("Câu trả lời(cho câu hỏi Có bệnh tăng huyết áp hay bệnh lí tim mạch nào khác hay không)")]
        public int? CH5 { get; set; }
        [MoTaDuLieu("Ghi chú(cho câu hỏi Có bệnh lí tuyến giáp hay không?)")]
        public string Note_CH6 { get; set; }
        [MoTaDuLieu("Câu trả lời(cho câu hỏi Có bệnh lí tuyến giáp hay không?)")]
        public int? CH6 { get; set; }
        [MoTaDuLieu("Ghi chú(cho câu hỏi Có thai hay nghi ngờ có thai hay không?)")]
        public string Note_CH7 { get; set; }
        [MoTaDuLieu("Câu trả lời(cho câu hỏi Có thai hay nghi ngờ có thai hay không?)")]
        public int? CH7 { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        //public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
    }
    public class BangTamSoatBenhNhanNguyCoChatTuongPhanFunc
    {
        public const string TableName = "NguyCoChatTuongPhan";
        public const string TablePrimaryKeyName = "IDPhieu";

        public static bool DeleteByIDMaPhieu(MDB.MDBConnection oracleConnection, List<decimal> IDBienBan)
        {
            try
            {
                string sql = "";
                string strWhere = "";
                MDB.MDBCommand oracleCommand;
                strWhere = "In(";
                if (IDBienBan.Count > 0)
                {
                    for (int i = 0; i < IDBienBan.Count; i++)
                    {
                        strWhere = strWhere + IDBienBan[i].ToString();
                        if (i == (IDBienBan.Count - 1))
                        {
                            strWhere = strWhere + ")";
                        }
                        else
                        {
                            strWhere = strWhere + ",";
                        }
                    }
                }
                sql = @"DELETE FROM NguyCoChatTuongPhan WHERE IDPhieu " + strWhere;
                using (oracleCommand = new MDB.MDBCommand(sql, oracleConnection))
                {
                    oracleCommand.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                XuLyLoi.LogError(ex);
            }
            return false;
        }
        public static List<BangTamSoatBenhNhanNguyCoChatTuongPhanTbl> Select(MDB.MDBConnection MyConnection,string MaQuanLy)
        {

            List<BangTamSoatBenhNhanNguyCoChatTuongPhanTbl> list = new List<BangTamSoatBenhNhanNguyCoChatTuongPhanTbl>();

            string sql = @"SELECT t.*
                    FROM NguyCoChatTuongPhan t
                    WHERE t.MaQuanLy = :MaQuanLy ORDER BY t.NgaySua DESC";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
            MDB.MDBDataReader DataReader = Command.ExecuteReader();
            while (DataReader.Read())
            {
                var res = new BangTamSoatBenhNhanNguyCoChatTuongPhanTbl();
                res.IDPhieu = Common.ConDB_Decimal(DataReader["IDPhieu"]);
                res.MaQuanLy = Common.ConDB_Decimal(DataReader["MaQuanLy"]);
                res.MaBenhNhan = Common.ConDBNull(DataReader["MaBenhNhan"]);
                res.TenBenhNhan = Common.ConDBNull(DataReader["TenBenhNhan"]);
                res.Khoa = Common.ConDBNull(DataReader["Khoa"]);
                res.MaKhoa = Common.ConDBNull(DataReader["MaKhoa"]);
                res.Tuoi = Common.ConDBNull(DataReader["Tuoi"]);
                res.GioiTinh = Common.ConDBNull(DataReader["GioiTinh"]);
                res.DiaChi = Common.ConDBNull(DataReader["DiaChi"]);
                res.SoDienThoai = Common.ConDBNull(DataReader["SoDienThoai"]);
                res.Mach = Common.ConDB_IntNull(DataReader["Mach"]);
                res.HuyetApMax = Common.ConDB_IntNull(DataReader["HuyetApMax"]);
                res.HuyetApMin = Common.ConDB_IntNull(DataReader["HuyetApMin"]);
                res.MaNguoiThucHien = Common.ConDBNull(DataReader["MaNguoiThucHien"]);
                res.TenNguoiThucHien = Common.ConDBNull(DataReader["TenNguoiThucHien"]);
                res.Note_CH1 = Common.ConDBNull(DataReader["Note_CH1"]);
                res.CH1 = Common.ConDB_IntNull(DataReader["CH1"]);
                res.Note_CH2 = Common.ConDBNull(DataReader["Note_CH2"]);
                res.CH2 = Common.ConDB_Int(DataReader["CH2"]);
                res.Note_CH3 = Common.ConDBNull(DataReader["Note_CH3"]);
                res.CH3 = Common.ConDB_Int(DataReader["CH3"]);
                res.Note_CH4 = Common.ConDBNull(DataReader["Note_CH4"]);
                res.CH4 = Common.ConDB_Int(DataReader["CH4"]);
                res.Note_CH5 = Common.ConDBNull(DataReader["Note_CH5"]);
                res.CH5 = Common.ConDB_Int(DataReader["CH5"]);
                res.Note_CH6 = Common.ConDBNull(DataReader["Note_CH6"]);
                res.CH6 = Common.ConDB_Int(DataReader["CH6"]);
                res.Note_CH7 = Common.ConDBNull(DataReader["Note_CH7"]);
                res.CH7 = Common.ConDB_Int(DataReader["CH7"]);
                res.NgaySua = Common.ConDB_DateTime(DataReader["NgaySua"]);
                res.MaSoKy = Common.ConDBNull(DataReader["MaSoKyTen"]);
                res.DaKy = !string.IsNullOrEmpty(res.MaSoKy) ? true : false;

                list.Add(res);
            }

            return list;
        }

        public static bool InsertOrUpdate(MDB.MDBConnection oracleConnection, BangTamSoatBenhNhanNguyCoChatTuongPhanTbl obj, ref bool isUpdate)
        {
            try
            {
                isUpdate = false;
                string sql = @"SELECT COUNT(*) RECNUM FROM NguyCoChatTuongPhan WHERE IDPhieu = :IDPhieu";
                MDB.MDBCommand oracleCommand;
                int rowCount = 0;
                int nRecord = 0;
                oracleCommand  = new MDB.MDBCommand(sql, oracleConnection);
                oracleCommand.Parameters.Add("IDPhieu", obj.IDPhieu);
                MDB.MDBDataReader oracleDataReader = oracleCommand.ExecuteReader();
                while (oracleDataReader.Read())
                {
                    rowCount = int.Parse(oracleDataReader["RECNUM"].ToString());
                }


                if (rowCount > 0)
                {
                    isUpdate = true;
                    sql = "update NguyCoChatTuongPhan set MaQuanLy= :MaQuanLy,MaBenhNhan= :MaBenhNhan,TenBenhNhan= :TenBenhNhan,Khoa= :Khoa,MaKhoa= :MaKhoa,Tuoi= :Tuoi,GioiTinh= :GioiTinh,DiaChi= :DiaChi,SoDienThoai= :SoDienThoai,Mach= :Mach,HuyetApMax= :HuyetApMax,HuyetApMin= :HuyetApMin,MaNguoiThucHien= :MaNguoiThucHien,TenNguoiThucHien= :TenNguoiThucHien,Note_CH1= :Note_CH1,CH1= :CH1,Note_CH2= :Note_CH2,CH2= :CH2,Note_CH3= :Note_CH3,CH3= :CH3,Note_CH4= :Note_CH4,CH4= :CH4,Note_CH5= :Note_CH5,CH5= :CH5,Note_CH6= :Note_CH6,CH6= :CH6,Note_CH7= :Note_CH7,CH7= :CH7,NgaySua= :NgaySua, NgayTao= :NgayTao ";
                    sql = sql + " WHERE IDPhieu  = " + obj.IDPhieu.ToString();
                }
                else
                {
                    sql = @"insert into NguyCoChatTuongPhan(MaQuanLy, MaBenhNhan, TenBenhNhan, Khoa, MaKhoa, Tuoi, GioiTinh, DiaChi, SoDienThoai, Mach, HuyetApMax, HuyetApMin, MaNguoiThucHien, TenNguoiThucHien, Note_CH1, CH1, Note_CH2, CH2, Note_CH3, CH3, Note_CH4, CH4, Note_CH5, CH5, Note_CH6, CH6, Note_CH7, CH7, NgaySua,NgayTao" +
                        ")";
                    sql = sql + @"Values(:MaQuanLy, :MaBenhNhan, :TenBenhNhan, :Khoa, :MaKhoa, :Tuoi, :GioiTinh, :DiaChi, :SoDienThoai, :Mach, :HuyetApMax, :HuyetApMin, :MaNguoiThucHien, :TenNguoiThucHien, :Note_CH1, :CH1, :Note_CH2, :CH2, :Note_CH3, :CH3, :Note_CH4, :CH4, :Note_CH5, :CH5, :Note_CH6, :CH6, :Note_CH7, :CH7, :NgaySua, :NgayTao" +
                        ")   RETURNING IDPhieu INTO :IDPhieu";
                }
                oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaQuanLy", obj.MaQuanLy));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", obj.MaBenhNhan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenBenhNhan", obj.TenBenhNhan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Khoa", obj.Khoa));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaKhoa", obj.MaKhoa));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Tuoi", obj.Tuoi));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("GioiTinh", obj.GioiTinh));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DiaChi", obj.DiaChi));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("SoDienThoai", obj.SoDienThoai));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Mach", obj.Mach));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("HuyetApMax", obj.HuyetApMax));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("HuyetApMin", obj.HuyetApMin));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaNguoiThucHien", obj.MaNguoiThucHien));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenNguoiThucHien", obj.TenNguoiThucHien));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Note_CH1", obj.Note_CH1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CH1", obj.CH1));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Note_CH2", obj.Note_CH2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CH2", obj.CH2));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Note_CH3", obj.Note_CH3));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CH3", obj.CH3));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Note_CH4", obj.Note_CH4));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CH4", obj.CH4));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Note_CH5", obj.Note_CH5));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CH5", obj.CH5));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Note_CH6", obj.Note_CH6));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CH6", obj.CH6));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Note_CH7", obj.Note_CH7));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CH7", obj.CH7));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgaySua", DateTime.Now));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayTao", obj.NgayTao));

                if (!isUpdate)
                {
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("IDPhieu", obj.IDPhieu));
                }
                nRecord = oracleCommand.ExecuteNonQuery();
                if (nRecord > 0)
                {
                    if (!isUpdate)
                    {
                        decimal nextval = Common.ConDB_Decimal((oracleCommand.Parameters["IDPhieu"] as MDB.MDBParameter).Value);
                        obj.IDPhieu = nextval;
                    }
                }
                return nRecord > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.LogError(ex);
            }
            return false;
        }

        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, decimal IDPhieu)
        {
            string sql = @"select AA.*"
                         + " from NguyCoChatTuongPhan AA WHERE IDPhieu =: IDPhieu";
            MDB.MDBCommand Command;
            MDB.MDBDataAdapter adt;
            using (Command = new MDB.MDBCommand(sql, MyConnection))
            {
                Command.Parameters.Add(new MDB.MDBParameter("IDPhieu", IDPhieu));
                adt = new MDB.MDBDataAdapter(Command);
            }
            var ds = new DataSet();
            adt.Fill(ds, "TBL");
            return ds;
        }
        public static bool Delete(MDB.MDBConnection MyConnection, decimal IDPhieu)
        {
            try
            {
                if (IDPhieu != 0)
                {
                    string sql = @"DELETE NguyCoChatTuongPhan WHERE IDPhieu = :IDPhieu";
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter(":IDPhieu", IDPhieu));
                    int n = Command.ExecuteNonQuery();

                    return n > 0 ? true : false;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return false;
        }
    }
}
