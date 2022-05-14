using EMR.KyDienTu;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuHoiChanDuyetMo : ThongTinKy
    {
        public PhieuHoiChanDuyetMo()
        {
            TableName = "PhieuHoiChanDuyetMo";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PHCDM;
            TenMauPhieu = DanhMucPhieu.PHCDM.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
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
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public string PhuongPhapMo { get; set; }
        public string PhuongPhapVoCam { get; set; }
        public string PhauThuatVien { get; set; }
        public string MaPhauThuatVien { get; set; }
        public string DuTruMau { get; set; }
        public DateTime? NgayMo { get; set; }
        public string Duyet { get; set; }
        public string GiamDoc { get; set; }
        public string MaGiamDoc { get; set; }
        [MoTaDuLieu("Trưởng khoa")]
		public string TruongKhoa { get; set; }
        [MoTaDuLieu("Mã trưởng khoa")]
		public string MaTruongKhoa { get; set; }
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
    public class PhieuHoiChanDuyetMoFunc
    {
        public const string TableName = "PhieuHoiChanDuyetMo";
        public const string TablePrimaryKeyName = "ID";
        public const string MaPhieu = "PHCDM";
        public static List<PhieuHoiChanDuyetMo> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuHoiChanDuyetMo> list = new List<PhieuHoiChanDuyetMo>();
            try
            {
                string sql = @"SELECT * FROM PhieuHoiChanDuyetMo where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuHoiChanDuyetMo data = new PhieuHoiChanDuyetMo();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.TenBenhNhan = DataReader["TenBenhNhan"].ToString();
                    data.Khoa = DataReader["Khoa"].ToString();
                    data.MaKhoa = DataReader["MaKhoa"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.PhuongPhapMo = DataReader["PhuongPhapMo"].ToString();
                    data.PhuongPhapVoCam = DataReader["PhuongPhapVoCam"].ToString();
                    data.PhauThuatVien = DataReader["PhauThuatVien"].ToString();
                    data.MaPhauThuatVien = DataReader["MaPhauThuatVien"].ToString();
                    data.DuTruMau = DataReader["DuTruMau"].ToString();
                    data.Duyet = DataReader["Duyet"].ToString();
                    data.GiamDoc = DataReader["GiamDoc"].ToString();
                    data.MaGiamDoc = DataReader["MaGiamDoc"].ToString();
                    data.TruongKhoa = DataReader["TruongKhoa"].ToString();
                    data.MaTruongKhoa = DataReader["MaTruongKhoa"].ToString();
                    data.NgayMo = Convert.ToDateTime(DataReader["NgayMo"] == DBNull.Value ? DateTime.Now : DataReader["NgayMo"]);

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuHoiChanDuyetMo phieuHoiChan)
        {
            try
            {
                string sql = @"INSERT INTO PhieuHoiChanDuyetMo
                (
                    MaQuanLy,
                    MaBenhNhan,
                    TenBenhNhan,
                    Khoa,
                    MaKhoa,
                    ChanDoan,
                    PhuongPhapMo,
                    PhuongPhapVoCam,
                    PhauThuatVien,
                    MaPhauThuatVien,
                    DuTruMau,
                    NgayMo,
                    Duyet,
                    GiamDoc,
                    MaGiamDoc,
                    TruongKhoa,
                    MaTruongKhoa,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
                    :MaBenhNhan,
                    :TenBenhNhan,
                    :Khoa,
                    :MaKhoa,
                    :ChanDoan,
                    :PhuongPhapMo,
                    :PhuongPhapVoCam,
                    :PhauThuatVien,
                    :MaPhauThuatVien,
                    :DuTruMau,
                    :NgayMo,
                    :Duyet,
                    :GiamDoc,
                    :MaGiamDoc,
                    :TruongKhoa,
                    :MaTruongKhoa,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (phieuHoiChan.ID != 0)
                {
                    sql = @"UPDATE PhieuHoiChanDuyetMo SET 
                    MaQuanLy = :MaQuanLy,
                    MaBenhNhan = :MaBenhNhan,
                    TenBenhNhan = :TenBenhNhan,
                    Khoa = :Khoa,
                    MaKhoa = :MaKhoa,
                    ChanDoan = :ChanDoan,
                    PhuongPhapMo = :PhuongPhapMo,
                    PhuongPhapVoCam = :PhuongPhapVoCam,
                    PhauThuatVien = :PhauThuatVien,
                    MaPhauThuatVien = :MaPhauThuatVien,
                    DuTruMau = :DuTruMau,
                    NgayMo = :NgayMo,
                    Duyet = :Duyet,
                    GiamDoc = :GiamDoc,
                    MaGiamDoc = :MaGiamDoc,
                    TruongKhoa = :TruongKhoa,
                    MaTruongKhoa = :MaTruongKhoa,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + phieuHoiChan.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", phieuHoiChan.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", phieuHoiChan.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("TenBenhNhan", phieuHoiChan.TenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa", phieuHoiChan.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaKhoa", phieuHoiChan.MaKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", phieuHoiChan.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapMo", phieuHoiChan.PhuongPhapMo));
                Command.Parameters.Add(new MDB.MDBParameter("PhuongPhapVoCam", phieuHoiChan.PhuongPhapVoCam));
                Command.Parameters.Add(new MDB.MDBParameter("PhauThuatVien", phieuHoiChan.PhauThuatVien));
                Command.Parameters.Add(new MDB.MDBParameter("MaPhauThuatVien", phieuHoiChan.MaPhauThuatVien));
                Command.Parameters.Add(new MDB.MDBParameter("DuTruMau", phieuHoiChan.DuTruMau));
                Command.Parameters.Add(new MDB.MDBParameter("NgayMo", phieuHoiChan.NgayMo));
                Command.Parameters.Add(new MDB.MDBParameter("Duyet", phieuHoiChan.Duyet));
                Command.Parameters.Add(new MDB.MDBParameter("GiamDoc", phieuHoiChan.GiamDoc));
                Command.Parameters.Add(new MDB.MDBParameter("MaGiamDoc", phieuHoiChan.MaGiamDoc));
                Command.Parameters.Add(new MDB.MDBParameter("TruongKhoa", phieuHoiChan.TruongKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaTruongKhoa", phieuHoiChan.MaTruongKhoa));

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", phieuHoiChan.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", phieuHoiChan.NgaySua));
                if (phieuHoiChan.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", phieuHoiChan.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", phieuHoiChan.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", phieuHoiChan.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (phieuHoiChan.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    phieuHoiChan.ID = nextval;
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
                string sql = "DELETE FROM PhieuHoiChanDuyetMo WHERE ID = :ID";
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
                B.*
            FROM
                PhieuHoiChanDuyetMo B
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            adt.Fill(ds, "BM");

            return ds;
        }
    }
}
