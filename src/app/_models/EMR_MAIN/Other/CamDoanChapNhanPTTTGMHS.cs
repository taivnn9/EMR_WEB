
using EMR.KyDienTu;
using System;
using System.Collections.Generic;
using System.Data;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class CamDoanChapNhanPTTTGMHSTbl : ThongTinKy
    {
        public CamDoanChapNhanPTTTGMHSTbl()
        {
            IDMauPhieu = (int)DanhMucPhieu.CDCNTTTMGMHS;
            TenMauPhieu = DanhMucPhieu.CDCNTTTMGMHS.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public decimal IDPhieu { get; set; }
        [MoTaDuLieu("Bệnh viện")]
		public string BenhVien { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")] 
        public string HoTen { get; set; }
        [MoTaDuLieu("Năm sinh bệnh nhân")]
        public decimal NamSinh { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Mã hồ sơ bệnh án")]
        public string MaHSBA { get; set; }
        [MoTaDuLieu("Ngày vào viện")]
        public string NgayVaoVien { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Chỉ định phẫu thuật/thủ thuật")]
        public string ChiDinh { get; set; }
        [MoTaDuLieu("Mã phẫu thuật viên")]
        public string MaPTV { get; set; }
        [MoTaDuLieu("Tên phẫu thuật viên")]
        public string TenPTV { get; set; }
        [MoTaDuLieu("Chức danh phẫu thuật viên")]
        public string ChucDanhPTV { get; set; }
        [MoTaDuLieu("Khoa phẫu thuật viên")]
        public string KhoaPTV { get; set; }
        public bool[] NguyCoArray { get; } = new bool[] { false, false, false, false, false, false, false, false, false };
        [MoTaDuLieu("Nguy cơ")]
        public string NguyCo
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < NguyCoArray.Length; i++)
                    temp += (NguyCoArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        NguyCoArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Tên người nhà bệnh nhân")]
        public string TenNguoiNha { get; set; }
        [MoTaDuLieu("Nguy cơ khác")]
        public string NguyCoKhac { get; set; }
        [MoTaDuLieu("Mực độ thành công")]
        public string MucDoThanhCong { get; set; }
        [MoTaDuLieu("Câu hỏi phẫu thuật viên")]
        public string CauHoiPTV { get; set; }
        [MoTaDuLieu("Số chứng minh nhân dân người nhà bệnh nhân")]
        public string SoCMND { get; set; }
        [MoTaDuLieu("Quan hệ với bệnh nhân")]
        public string QuanHeBN { get; set; }
        [MoTaDuLieu("Địa chỉ người nhà bệnh nhân")]
		public string DiaChiNguoiNha { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        //public string MaSoKyTen { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
        public const string TableName = "CamDoanChapNhanPTTTGMHS";
        public const string TablePrimaryKeyName = "IDPhieu";
    }
    public class CamDoanChapNhanPTTTGMHSFunc
    {
        public static bool DeleteByIDPhieu(MDB.MDBConnection oracleConnection, List<decimal> IDBienBan)
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
                sql = @"DELETE FROM CamDoanChapNhanPTTTGMHS WHERE IDPhieu " + strWhere;
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
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, string IDBienBan)
        {
            string sql = @"select AA.*"
                         + " from CamDoanChapNhanPTTTGMHS AA WHERE IDPhieu =: IDPhieu ORDER BY NgayTao, NgaySua asc";
            MDB.MDBCommand Command;
            MDB.MDBDataAdapter adt;
            using (Command = new MDB.MDBCommand(sql, MyConnection))
            {
                Command.Parameters.Add(new MDB.MDBParameter("IDPhieu", IDBienBan));
                adt = new MDB.MDBDataAdapter(Command);
            }
            var ds = new DataSet();
            adt.Fill(ds, "TBL");
            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection oracleConnection, CamDoanChapNhanPTTTGMHSTbl obj, ref bool isUpdate)
        {
            try
            {
                string sql = @"SELECT COUNT(*) RECNUM FROM CamDoanChapNhanPTTTGMHS WHERE IDPhieu  = :IDPhieu ";
                MDB.MDBCommand oracleCommand;
                int rowCount = 0;
                int nRecord = 0;
                decimal IDphieuNext = 0;
                oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
                oracleCommand.Parameters.Add("IDPhieu", obj.IDPhieu);
                MDB.MDBDataReader oracleDataReader = oracleCommand.ExecuteReader();
                while (oracleDataReader.Read())
                {
                    rowCount = int.Parse(oracleDataReader["RECNUM"].ToString());
                }


                if (rowCount > 0)
                {
                    isUpdate = true;
                    IDphieuNext = obj.IDPhieu;
                    sql = "update CamDoanChapNhanPTTTGMHS set BenhVien = :BenhVien,HoTen = :HoTen,NamSinh = :NamSinh,GioiTinh = :GioiTinh,MaHSBA = :MaHSBA,NgayVaoVien = :NgayVaoVien,Khoa = :Khoa,ChanDoan = :ChanDoan,ChiDinh = :ChiDinh,MaPTV = :MaPTV,TenPTV = :TenPTV,ChucDanhPTV = :ChucDanhPTV,KhoaPTV = :KhoaPTV,NguyCo = :NguyCo,NguyCoKhac = :NguyCoKhac,TenNguoiNha = :TenNguoiNha, CauHoiPTV = :CauHoiPTV , MucDoThanhCong = :MucDoThanhCong, SoCMND = :SoCMND,QuanHeBN = :QuanHeBN,DiaChiNguoiNha = :DiaChiNguoiNha,NgayTao = :NgayTao,NgaySua = :NgaySua,MaQuanLy = :MaQuanLy";
                    sql = sql + " WHERE IDPhieu  = " + obj.IDPhieu.ToString();
                }
                else
                {
                    sql = @"insert into CamDoanChapNhanPTTTGMHS(BenhVien,HoTen,NamSinh,GioiTinh,MaHSBA,NgayVaoVien,Khoa,ChanDoan,ChiDinh,MaPTV,TenPTV,ChucDanhPTV,KhoaPTV,NguyCo,NguyCoKhac,TenNguoiNha, CauHoiPTV, MucDoThanhCong,SoCMND,QuanHeBN,DiaChiNguoiNha,NgayTao,NgaySua,MaQuanLy" +
                        ")";
                    sql = sql + @"Values(:BenhVien, :HoTen, :NamSinh, :GioiTinh, :MaHSBA, :NgayVaoVien, :Khoa, :ChanDoan, :ChiDinh, :MaPTV, :TenPTV, :ChucDanhPTV, :KhoaPTV, :NguyCo, :NguyCoKhac, :TenNguoiNha, :CauHoiPTV, :MucDoThanhCong, :SoCMND, :QuanHeBN, :DiaChiNguoiNha, :NgayTao, :NgaySua, :MaQuanLy" +
                        ")   RETURNING IDPhieu INTO :IDPhieu";
                }
                oracleCommand = new MDB.MDBCommand(sql, oracleConnection);
                oracleCommand.Parameters.Add(new MDB.MDBParameter("BenhVien", obj.BenhVien));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("HoTen", obj.HoTen));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NamSinh", obj.NamSinh));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("GioiTinh", obj.GioiTinh));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaHSBA", obj.MaHSBA));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayVaoVien", obj.NgayVaoVien));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("Khoa", obj.Khoa));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ChanDoan", obj.ChanDoan));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ChiDinh", obj.ChiDinh));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaPTV", obj.MaPTV));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenPTV", obj.TenPTV));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("ChucDanhPTV", obj.ChucDanhPTV));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("KhoaPTV", obj.KhoaPTV));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NguyCo", obj.NguyCo));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NguyCoKhac", obj.NguyCoKhac));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("TenNguoiNha", obj.TenNguoiNha));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("CauHoiPTV", obj.CauHoiPTV));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MucDoThanhCong", obj.MucDoThanhCong));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("SoCMND", obj.SoCMND));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("QuanHeBN", obj.QuanHeBN));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("DiaChiNguoiNha", obj.DiaChiNguoiNha));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayTao", obj.NgayTao));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("NgaySua", obj.NgaySua));
                oracleCommand.Parameters.Add(new MDB.MDBParameter("MaQuanLy", obj.MaQuanLy));
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
        public static List<CamDoanChapNhanPTTTGMHSTbl> GetData(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            List<CamDoanChapNhanPTTTGMHSTbl> lstData = new List<CamDoanChapNhanPTTTGMHSTbl>();
            string sql = @"select * from CamDoanChapNhanPTTTGMHS WHERE MaQuanLy = :MaQuanLy ";
            sql += " ORDER BY NgayTao, NgaySua asc";
            MDB.MDBCommand Command;
            using (Command = new MDB.MDBCommand(sql, MyConnection))
            {
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    lstData.Add(new CamDoanChapNhanPTTTGMHSTbl
                    {
                        IDPhieu = Common.ConDB_Decimal(DataReader["IDPhieu"]),
                        BenhVien = Common.ConDBNull(DataReader["BenhVien"]),
                        HoTen = Common.ConDBNull(DataReader["HoTen"]),
                        NamSinh = Common.ConDB_Decimal(DataReader["NamSinh"], 1900),
                        GioiTinh = Common.ConDBNull(DataReader["GioiTinh"]),
                        MaHSBA = Common.ConDBNull(DataReader["MaHSBA"]),
                        NgayVaoVien = Common.ConDBNull(DataReader["NgayVaoVien"]),
                        Khoa = Common.ConDBNull(DataReader["Khoa"]),
                        ChanDoan = Common.ConDBNull(DataReader["ChanDoan"]),
                        ChiDinh = Common.ConDBNull(DataReader["ChiDinh"]),
                        MaPTV = Common.ConDBNull(DataReader["MaPTV"]),
                        TenPTV = Common.ConDBNull(DataReader["TenPTV"]),
                        ChucDanhPTV = Common.ConDBNull(DataReader["ChucDanhPTV"]),
                        KhoaPTV = Common.ConDBNull(DataReader["KhoaPTV"]),
                        NguyCo = Common.ConDBNull(DataReader["NguyCo"]),
                        NguyCoKhac = Common.ConDBNull(DataReader["NguyCoKhac"]),
                        TenNguoiNha = Common.ConDBNull(DataReader["TenNguoiNha"]),
                        CauHoiPTV = Common.ConDBNull(DataReader["CauHoiPTV"]),
                        MucDoThanhCong = Common.ConDBNull(DataReader["MucDoThanhCong"]),
                        SoCMND = Common.ConDBNull(DataReader["SoCMND"]),
                        QuanHeBN = Common.ConDBNull(DataReader["QuanHeBN"]),
                        DiaChiNguoiNha = Common.ConDBNull(DataReader["DiaChiNguoiNha"]),
                        NgayTao = Common.ConDB_DateTime(DataReader["NgayTao"]),
                        NgaySua = Common.ConDB_DateTime(DataReader["NgaySua"]),
                        MaQuanLy = Common.ConDB_Decimal(DataReader["MaQuanLy"]),
                        MaSoKy = Common.ConDBNull(DataReader["MASOKYTEN"]),
                        DaKy = !string.IsNullOrEmpty(Common.ConDBNull(DataReader["masokyten"])) ? true : false,
                        Chon = false
                    });
                }
            }
            return lstData;
        }

    }
}
