
using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuSangLocDGDDTE : ThongTinKy
    {
        public PhieuSangLocDGDDTE()
        {
            TableName = "PhieuSangLocDGDDTE";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PSLDGDDTE;
            TenMauPhieu = DanhMucPhieu.PSLDGDDTE.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Cân nặng")]
		public string CanNang { get; set; }
        [MoTaDuLieu("Chiều cao")]
		public string ChieuCao { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        public DateTime? NgaySua { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }

        public bool[] SutCanArray { get; } = new bool[] { false, false };
        public string SutCan
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < SutCanArray.Length; i++)
                    temp += (SutCanArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        SutCanArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] TangCanKemArray { get; } = new bool[] { false, false };
        public string TangCanKem
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < TangCanKemArray.Length; i++)
                    temp += (TangCanKemArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        TangCanKemArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] KemAnArray { get; } = new bool[] { false, false };
        public string KemAn
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < KemAnArray.Length; i++)
                    temp += (KemAnArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        KemAnArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] ThapCanArray { get; } = new bool[] { false, false };
        public string ThapCan
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < ThapCanArray.Length; i++)
                    temp += (ThapCanArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        ThapCanArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] PhanLoaiArray { get; } = new bool[] { false, false };
        public string PhanLoai
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < PhanLoaiArray.Length; i++)
                    temp += (PhanLoaiArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        PhanLoaiArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public bool[] DanhGiaArray { get; } = new bool[] { false, false, false };
        public string DanhGia
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < DanhGiaArray.Length; i++)
                    temp += (DanhGiaArray[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        DanhGiaArray[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Mã bác sỹ")]
		public string MaBacSi { get; set; }
        [MoTaDuLieu("Họ tên bác sỹ")]
		public string BacSi { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
       
    }
    public class PhieuSangLocDGDDTEFunc
    {
        public static List<PhieuSangLocDGDDTE> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuSangLocDGDDTE> list = new List<PhieuSangLocDGDDTE>();
            try
            {
                string sql = @"SELECT * FROM PhieuSangLocDGDDTE where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuSangLocDGDDTE data = new PhieuSangLocDGDDTE();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.TenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;

                    data.CanNang = DataReader["CanNang"].ToString();
                    data.ChieuCao = DataReader["ChieuCao"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.SutCan = DataReader["SutCan"].ToString();
                    data.TangCanKem = DataReader["TangCanKem"].ToString();
                    data.KemAn = DataReader["KemAn"].ToString();
                    data.ThapCan = DataReader["ThapCan"].ToString();
                    data.PhanLoai = DataReader["PhanLoai"].ToString();
                    data.DanhGia = DataReader["DanhGia"].ToString();
                    data.MaBacSi = DataReader["MaBacSi"].ToString();
                    data.BacSi = DataReader["BacSi"].ToString();

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuSangLocDGDDTE bangKe)
        {
            try
            {
                string sql = @"INSERT INTO PhieuSangLocDGDDTE
                (
                    MAQUANLY,
                    CanNang,
                    ChieuCao,
                    ChanDoan,
                    SutCan,
                    TangCanKem,
                    KemAn,
                    ThapCan,
                    PhanLoai,
                    DanhGia,
                    MaBacSi,
                    BacSi,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :CanNang,
                    :ChieuCao,
                    :ChanDoan,
                    :SutCan,
                    :TangCanKem,
                    :KemAn,
                    :ThapCan,
                    :PhanLoai,
                    :DanhGia,
                    :MaBacSi,
                    :BacSi,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (bangKe.ID != 0)
                {
                    sql = @"UPDATE PhieuSangLocDGDDTE SET 
                    MAQUANLY = :MAQUANLY,
                    CanNang = :CanNang,
                    ChieuCao = :ChieuCao,
                    ChanDoan = :ChanDoan,
                    SutCan = :SutCan,
                    TangCanKem = :TangCanKem,
                    KemAn = :KemAn,
                    ThapCan = :ThapCan,
                    PhanLoai = :PhanLoai,
                    DanhGia = :DanhGia,
                    MaBacSi = :MaBacSi,
                    BacSi = :BacSi,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + bangKe.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangKe.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang", bangKe.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("ChieuCao", bangKe.ChieuCao));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", bangKe.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("SutCan", bangKe.SutCan));
                Command.Parameters.Add(new MDB.MDBParameter("TangCanKem", bangKe.TangCanKem));
                Command.Parameters.Add(new MDB.MDBParameter("KemAn", bangKe.KemAn));
                Command.Parameters.Add(new MDB.MDBParameter("ThapCan", bangKe.ThapCan));
                Command.Parameters.Add(new MDB.MDBParameter("PhanLoai", bangKe.PhanLoai));
                Command.Parameters.Add(new MDB.MDBParameter("DanhGia", bangKe.DanhGia));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSi", bangKe.MaBacSi));
                Command.Parameters.Add(new MDB.MDBParameter("BacSi", bangKe.BacSi));
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
                string sql = "DELETE FROM PhieuSangLocDGDDTE WHERE ID = :ID";
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
                PhieuSangLocDGDDTE B
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);

            var ds = new DataSet();

            adt.Fill(ds, "TB");
            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("MaBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));
            ds.Tables[0].AddColumn("BenhVien", typeof(string));
            ds.Tables[0].AddColumn("Khoa", typeof(string));
            ds.Tables[0].AddColumn("SoYTe", typeof(string));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["MaBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.MaBenhNhan;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["BenhVien"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["Khoa"] = XemBenhAn._ThongTinDieuTri.Khoa;
            ds.Tables[0].Rows[0]["SoYTe"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;

            return ds;

        }
    }
}
