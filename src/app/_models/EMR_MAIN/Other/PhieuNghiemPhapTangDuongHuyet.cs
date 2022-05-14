using EMR.KyDienTu;
using System;
using System.Collections.Generic;
using PMS.Access; 

namespace EMR_MAIN.DATABASE.Other
{

    public class PhieuNghiemPhapTangDuongHuyet : ThongTinKy
    {
        public PhieuNghiemPhapTangDuongHuyet()
        {
            TableName = "PhieuNghiemPhapTangDuongHuyet";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PNPTDH;
            TenMauPhieu = DanhMucPhieu.PNPTDH.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            }
        }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.Tuoi;
            }
        }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.GioiTinh.ToString();
            }
        }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan
        {
            get
            {
                return XemBenhAn._ThongTinDieuTri.ChanDoan_KhiVaoKhoaDieuTri;
            }
        }
        public string Khoa
        {
            get
            {
                return XemBenhAn._ThongTinDieuTri.Khoa;
            }
        }
        [MoTaDuLieu("Chiều cao")]
		public string ChieuCao { get; set; }
        [MoTaDuLieu("Cân nặng")]
		public string CanNang { get; set; }
        [MoTaDuLieu("Chỉ số BMI")]
		public string BMI { get; set; }
        public string VongEo { get; set; }
        public string VongBung { get; set; }
        public string DuongMauM0 { get; set; }
        public string DuongMauM1 { get; set; }
        public string DuongMauM2 { get; set; }
        public string KetLuan { get; set; }
        public DateTime ThoiGian { get; set; }
        public string MaBSDocKQ { get; set; }
        public string BSDocKQ { get; set; }
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
    public class PhieuNghiemPhapTangDuongHuyetFunc
    {
        public const string TableName = "PhieuNghiemPhapTangDuongHuyet";
        public const string TablePrimaryKeyName = "ID";
        public static PhieuNghiemPhapTangDuongHuyet GetListData_Phieu(MDB.MDBConnection _OracleConnection, long ID)
        {
            PhieuNghiemPhapTangDuongHuyet data = new PhieuNghiemPhapTangDuongHuyet();
            try
            {
                string sql = @"SELECT * FROM PhieuNghiemPhapTangDuongHuyet where ID = :ID";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID", ID));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    data.ChieuCao = DataReader["ChieuCao"].ToString();
                    data.CanNang = DataReader["CanNang"].ToString();
                    data.BMI = DataReader["BMI"].ToString();
                    data.VongEo = DataReader["VongEo"].ToString();
                    data.VongBung = DataReader["VongBung"].ToString();
                    data.DuongMauM0 = DataReader["DuongMauM0"].ToString();
                    data.DuongMauM1 = DataReader["DuongMauM1"].ToString();
                    data.DuongMauM2 = DataReader["DuongMauM2"].ToString();
                    data.KetLuan = DataReader["KetLuan"].ToString();
                    data.ThoiGian = Convert.ToDateTime(DataReader["ThoiGian"] == DBNull.Value ? DateTime.Now : DataReader["ThoiGian"]);
                    data.MaBSDocKQ = DataReader["MaBSDocKQ"].ToString();
                    data.BSDocKQ = DataReader["BSDocKQ"].ToString();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = DataReader.GetDecimal("MaQuanLy");
                    data.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                    data.NguoiTao = DataReader["NguoiTao"].ToString();
                    data.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);
                    data.NguoiSua = DataReader["NguoiSua"].ToString();
                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return data;
        }
        public static List<PhieuNghiemPhapTangDuongHuyet> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuNghiemPhapTangDuongHuyet> list = new List<PhieuNghiemPhapTangDuongHuyet>();
            try
            {
                string sql = @"SELECT * FROM PhieuNghiemPhapTangDuongHuyet where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuNghiemPhapTangDuongHuyet data = new PhieuNghiemPhapTangDuongHuyet();
                    data.ChieuCao = DataReader["ChieuCao"].ToString();
                    data.CanNang = DataReader["CanNang"].ToString();
                    data.BMI = DataReader["BMI"].ToString();
                    data.VongEo = DataReader["VongEo"].ToString();
                    data.VongBung = DataReader["VongBung"].ToString();
                    data.DuongMauM0 = DataReader["DuongMauM0"].ToString();
                    data.DuongMauM1 = DataReader["DuongMauM1"].ToString();
                    data.DuongMauM2 = DataReader["DuongMauM2"].ToString();
                    data.KetLuan = DataReader["KetLuan"].ToString();
                    data.ThoiGian = Convert.ToDateTime(DataReader["ThoiGian"] == DBNull.Value ? DateTime.Now : DataReader["ThoiGian"]);
                    data.MaBSDocKQ = DataReader["MaBSDocKQ"].ToString();
                    data.BSDocKQ = DataReader["BSDocKQ"].ToString();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = DataReader.GetDecimal("MaQuanLy");
                    data.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                    data.NguoiTao = DataReader["NguoiTao"].ToString();
                    data.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);
                    data.NguoiSua = DataReader["NguoiSua"].ToString();
                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy);
                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuNghiemPhapTangDuongHuyet bangDieuTri)
        {
            try
            {
                string sql = @"INSERT INTO PhieuNghiemPhapTangDuongHuyet
                (
                    MAQUANLY,
                    ChieuCao,
                    CanNang,
                    BMI,
                    VongEo,
                    VongBung,
                    DuongMauM0,
                    DuongMauM1,
                    DuongMauM2,
                    KetLuan,
                    ThoiGian,
                    MaBSDocKQ,
                    BSDocKQ,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :ChieuCao,
                    :CanNang,
                    :BMI,
                    :VongEo,
                    :VongBung,
                    :DuongMauM0,
                    :DuongMauM1,
                    :DuongMauM2,
                    :KetLuan,
                    :ThoiGian,
                    :MaBSDocKQ,
                    :BSDocKQ,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (bangDieuTri.ID != 0)
                {
                    sql = @"UPDATE PhieuNghiemPhapTangDuongHuyet SET 
                    MAQUANLY = :MAQUANLY,
                    ChieuCao = :ChieuCao,
                    CanNang = :CanNang,
                    BMI = :BMI,
                    VongEo = :VongEo,
                    VongBung = :VongBung,
                    DuongMauM0 = :DuongMauM0,
                    DuongMauM1 = :DuongMauM1,
                    DuongMauM2 = :DuongMauM2,
                    KetLuan = :KetLuan,
                    ThoiGian = :ThoiGian,
                    MaBSDocKQ = :MaBSDocKQ,
                    BSDocKQ = :BSDocKQ,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + bangDieuTri.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangDieuTri.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("ChieuCao", bangDieuTri.ChieuCao));
                Command.Parameters.Add(new MDB.MDBParameter("CanNang", bangDieuTri.CanNang));
                Command.Parameters.Add(new MDB.MDBParameter("BMI", bangDieuTri.BMI));
                Command.Parameters.Add(new MDB.MDBParameter("VongEo", bangDieuTri.VongEo));
                Command.Parameters.Add(new MDB.MDBParameter("VongBung", bangDieuTri.VongBung));
                Command.Parameters.Add(new MDB.MDBParameter("DuongMauM0", bangDieuTri.DuongMauM0));
                Command.Parameters.Add(new MDB.MDBParameter("DuongMauM1", bangDieuTri.DuongMauM1));
                Command.Parameters.Add(new MDB.MDBParameter("DuongMauM2", bangDieuTri.DuongMauM2));
                Command.Parameters.Add(new MDB.MDBParameter("KetLuan", bangDieuTri.KetLuan));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGian", bangDieuTri.ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("MaBSDocKQ", bangDieuTri.MaBSDocKQ));
                Command.Parameters.Add(new MDB.MDBParameter("BSDocKQ", bangDieuTri.BSDocKQ));
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
                return n > 0;
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
                string sql = "DELETE FROM PhieuNghiemPhapTangDuongHuyet WHERE ID = :ID";
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
    }
}
