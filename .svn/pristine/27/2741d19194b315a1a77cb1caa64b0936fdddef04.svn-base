
using EMR.KyDienTu;
using Newtonsoft.Json;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuTruyenMauXetNghiem : ThongTinKy
    {
        public PhieuTruyenMauXetNghiem()
        {
            TableName = "PhieuTruyenMauXetNghiem";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PTMXN;
            TenMauPhieu = DanhMucPhieu.PTMXN.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        public string NhomMauBenhNhan { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
        public string SoLuongKhoaXN1 { get; set; }
        public string SoLuongKhoaXN2 { get; set; }
        public string SoLuongKhoaXN3 { get; set; }
        public string SoLuongKhoaXN4 { get; set; }
        public string SoLuongKhoaXN5 { get; set; }
        public string MaNVPhatMau { get; set; }
        public string NVPhatMau { get; set; }
        public string MaNVPhuTrach { get; set; }
        public string NVPhuTrach { get; set; }

        public ObservableCollection<KetQuaXNHoaHop> ListKetQua { get; set; }

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

    public class KetQuaXNHoaHop
    {
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã định danh")]
		public long ID_Phieu { get; set; }

        public string STT { get; set; }
        public string TenChePhamMau { get; set; }
        [MoTaDuLieu("Nhóm máu")]
		public string NhomMau { get; set; }
        public string LoaiChePham { get; set; }
        public string TheTich { get; set; }
        public string KetQuaXN { get; set; }
    }
    public class PhieuTruyenMauXetNghiemFunc
    {
        public const string TableName = "PhieuTruyenMauXetNghiem";
        public const string TablePrimaryKeyName = "ID";

        public static List<PhieuTruyenMauXetNghiem> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuTruyenMauXetNghiem> list = new List<PhieuTruyenMauXetNghiem>();
            try
            {
                string sql = @"SELECT * FROM PhieuTruyenMauXetNghiem where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuTruyenMauXetNghiem data = new PhieuTruyenMauXetNghiem();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;

                    data.MaBenhNhan = XemBenhAn._HanhChinhBenhNhan.MaBenhNhan;
                    data.TenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();

                    data.Khoa = DataReader["Khoa"].ToString();
                    data.NhomMauBenhNhan = DataReader["NhomMauBenhNhan"].ToString();
                    data.SoLuongKhoaXN1 = DataReader["SoLuongKhoaXN1"].ToString();
                    data.SoLuongKhoaXN2 = DataReader["SoLuongKhoaXN2"].ToString();
                    data.SoLuongKhoaXN3 = DataReader["SoLuongKhoaXN3"].ToString();
                    data.SoLuongKhoaXN4 = DataReader["SoLuongKhoaXN4"].ToString();
                    data.SoLuongKhoaXN5 = DataReader["SoLuongKhoaXN5"].ToString();
                    data.MaNVPhatMau = DataReader["MaNVPhatMau"].ToString();
                    data.MaNVPhuTrach = DataReader["MaNVPhuTrach"].ToString();
                    data.NVPhatMau = DataReader["NVPhatMau"].ToString();
                    data.NVPhuTrach = DataReader["NVPhuTrach"].ToString();

                    data.ListKetQua = GetKetQua(_OracleConnection, data.ID);

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
        public static bool DeleteByIDPhieu(MDB.MDBConnection oracleConnection, decimal IDBienBan)
        {
            try
            {
                string sql = "";
                MDB.MDBCommand oracleCommand;
                sql = @"DELETE FROM PhieuTruyenMauXetNghiem WHERE ID =" + IDBienBan;
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
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, long IDBienBan)
        {
            string sql = @"SELECT
                P.* 
            FROM
                PhieuTruyenMauXetNghiem P
            WHERE
                ID = " + IDBienBan;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "TB");

            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));
            ds.Tables[0].AddColumn("BenhVien", typeof(string));
            ds.Tables[0].AddColumn("SoYTe", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(int));
            ds.Tables[0].AddColumn("ThongTinNgayThang", typeof(string));
            ds.Tables[0].AddColumn("MaBenhAn", typeof(string));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh;
            ds.Tables[0].Rows[0]["BenhVien"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["SoYTe"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["ThongTinNgayThang"] = "Ngày " + DateTime.Now.Day + " tháng " + DateTime.Now.Month + " năm " + DateTime.Now.Year;
            ds.Tables[0].Rows[0]["MaBenhAn"] = XemBenhAn._ThongTinDieuTri.MaBenhAn;

            DataTable KQ =  Common.ListToDataTable(GetKetQua(MyConnection, IDBienBan), "KQ");
            ds.Tables.Add(KQ);
            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuTruyenMauXetNghiem ketQua)
        {
            try
            {
                string sql = @"INSERT INTO PhieuTruyenMauXetNghiem
                (
                    MaQuanLy,
                    NhomMauBenhNhan,
                    Khoa,
                    SoLuongKhoaXN1,
                    SoLuongKhoaXN2,
                    SoLuongKhoaXN3,
                    SoLuongKhoaXN4,
                    SoLuongKhoaXN5,
                    MaNVPhatMau,
                    MaNVPhuTrach,
                    NVPhuTrach,
                    NVPhatMau,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
                    :NhomMauBenhNhan,
                    :Khoa,
                    :SoLuongKhoaXN1,
                    :SoLuongKhoaXN2,
                    :SoLuongKhoaXN3,
                    :SoLuongKhoaXN4,
                    :SoLuongKhoaXN5,
                    :MaNVPhatMau,
                    :MaNVPhuTrach,
                    :NVPhuTrach,
                    :NVPhatMau,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE PhieuTruyenMauXetNghiem SET 
                    MaQuanLy = :MaQuanLy,
                    NhomMauBenhNhan = :NhomMauBenhNhan,
                    Khoa = :Khoa,
                    SoLuongKhoaXN1 = :SoLuongKhoaXN1,
                    SoLuongKhoaXN2 = :SoLuongKhoaXN2,
                    SoLuongKhoaXN3 = :SoLuongKhoaXN3,
                    SoLuongKhoaXN4 = :SoLuongKhoaXN4,
                    SoLuongKhoaXN5 = :SoLuongKhoaXN5,
                    MaNVPhatMau = :MaNVPhatMau,
                    MaNVPhuTrach = :MaNVPhuTrach,
                    NVPhuTrach = :NVPhuTrach,
                    NVPhatMau = :NVPhatMau,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", ketQua.MaQuanLy));

                Command.Parameters.Add(new MDB.MDBParameter("NhomMauBenhNhan", ketQua.NhomMauBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa", ketQua.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("SoLuongKhoaXN1", ketQua.SoLuongKhoaXN1));
                Command.Parameters.Add(new MDB.MDBParameter("SoLuongKhoaXN2", ketQua.SoLuongKhoaXN2));
                Command.Parameters.Add(new MDB.MDBParameter("SoLuongKhoaXN3", ketQua.SoLuongKhoaXN3));
                Command.Parameters.Add(new MDB.MDBParameter("SoLuongKhoaXN4", ketQua.SoLuongKhoaXN4));
                Command.Parameters.Add(new MDB.MDBParameter("SoLuongKhoaXN5", ketQua.SoLuongKhoaXN5));
                Command.Parameters.Add(new MDB.MDBParameter("MaNVPhatMau", ketQua.MaNVPhatMau));
                Command.Parameters.Add(new MDB.MDBParameter("MaNVPhuTrach", ketQua.MaNVPhuTrach));
                Command.Parameters.Add(new MDB.MDBParameter("NVPhatMau", ketQua.NVPhatMau));
                Command.Parameters.Add(new MDB.MDBParameter("NVPhuTrach", ketQua.NVPhuTrach));

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
                XuLyLoi.LogError(ex);
            }
            return false;
        }

        public static ObservableCollection<KetQuaXNHoaHop> GetKetQua(MDB.MDBConnection _OracleConnection, long idPhieu)
        {
            ObservableCollection<KetQuaXNHoaHop> KetQuaXNHoaHops = new ObservableCollection<KetQuaXNHoaHop>();
            try
            {
                string sql = @"SELECT * FROM KetQuaXNHoaHop where ID_Phieu = :ID_Phieu ORDER BY ID asc";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID_Phieu", idPhieu));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    KetQuaXNHoaHop data = new KetQuaXNHoaHop();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.ID_Phieu = idPhieu;

                    data.STT = DataReader["STT"].ToString();
                    data.TenChePhamMau = DataReader["TenChePhamMau"].ToString();
                    data.NhomMau = DataReader["NhomMau"].ToString();
                    data.LoaiChePham = DataReader["LoaiChePham"].ToString();
                    data.TheTich = DataReader["TheTich"].ToString();
                    data.KetQuaXN = DataReader["KetQuaXN"].ToString();
                    KetQuaXNHoaHops.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return KetQuaXNHoaHops;
        }
        public static bool DeleteKetQua(MDB.MDBConnection MyConnection, long id)
        {
            try
            {
                string sql = "DELETE FROM KetQuaXNHoaHop WHERE ID = :ID";
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
        public static bool InsertOrUpdateKetQua(MDB.MDBConnection MyConnection, KetQuaXNHoaHop _KetQua)
        {
            try
            {
                string sql = @"INSERT INTO KetQuaXNHoaHop
                (
                    ID_Phieu,
                    STT,
                    TenChePhamMau,
                    NhomMau,
                    LoaiChePham,
                    TheTich,
                    KetQuaXN)  VALUES
                 (
				    :ID_Phieu,
                    :STT,
                    :TenChePhamMau,
                    :NhomMau,
                    :LoaiChePham,
                    :TheTich,
                    :KetQuaXN
                 )";
                if (_KetQua.ID != 0)
                {
                    sql = @"UPDATE KetQuaXNHoaHop SET 
                    ID_Phieu = :ID_Phieu,
                    STT = :STT,
                    TenChePhamMau = :TenChePhamMau,
                    NhomMau = :NhomMau,
                    LoaiChePham = :LoaiChePham,
                    TheTich = :TheTich,
                    KetQuaXN = :KetQuaXN
                    WHERE ID = " + _KetQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID_Phieu", _KetQua.ID_Phieu));
                Command.Parameters.Add(new MDB.MDBParameter("STT", _KetQua.STT));
                Command.Parameters.Add(new MDB.MDBParameter("TenChePhamMau", _KetQua.TenChePhamMau));
                Command.Parameters.Add(new MDB.MDBParameter("NhomMau", _KetQua.NhomMau));
                Command.Parameters.Add(new MDB.MDBParameter("LoaiChePham", _KetQua.LoaiChePham));
                Command.Parameters.Add(new MDB.MDBParameter("TheTich", _KetQua.TheTich));
                Command.Parameters.Add(new MDB.MDBParameter("KetQuaXN", _KetQua.KetQuaXN));

                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
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
