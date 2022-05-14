using EMR.KyDienTu;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.Access; 

namespace EMR_MAIN.DATABASE.Other
{
    public class ThongTinNuocTieuTheoGio
    {
        public int Gio { get; set; }
        public double? DungTich { get; set; }
    }
    public class ThongTinNuocTieuTheoNgay
    {
        public DateTime Ngay { get; set; }
        public ObservableCollection<ThongTinNuocTieuTheoGio> KetQuas { get; set; }
    }
    public class PhieuTheoDoiNuocTieu24hDanhChoBenhNhan : ThongTinKy
    {
        public PhieuTheoDoiNuocTieu24hDanhChoBenhNhan()
        {
            TableName = "PhieuTDNuocTieu24H";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PTDNT24HBN;
            TenMauPhieu = DanhMucPhieu.PTDNT24HBN.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        public DateTime? NgayNhapVien { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public string SoPhong { get; set; }
        public string SoGiuong { get; set; }
        public ObservableCollection<ThongTinNuocTieuTheoNgay> KetQuaNgays { get; set; }
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
    public class PhieuTheoDoiNuocTieu24hDanhChoBenhNhanFunc
    {
        public const string TableName = "PhieuTDNuocTieu24H";
        public const string TablePrimaryKeyName = "ID";
        public static PhieuTheoDoiNuocTieu24hDanhChoBenhNhan GetListData_Phieu(MDB.MDBConnection _OracleConnection, long ID)
        {
            PhieuTheoDoiNuocTieu24hDanhChoBenhNhan data = new PhieuTheoDoiNuocTieu24hDanhChoBenhNhan();
            try
            {
                string sql = @"SELECT * FROM PhieuTDNuocTieu24H where ID = :ID";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID", ID));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = DataReader.GetDecimal("MaQuanLy");
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.TenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.NgayNhapVien = DataReader["NgayNhapVien"] == DBNull.Value ? (DateTime?)null : DataReader.GetDate("NgayNhapVien");
                    data.Tuoi = DataReader["Tuoi"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.SoPhong = DataReader["SoPhong"].ToString();
                    data.SoGiuong = DataReader["SoGiuong"].ToString();

                    string KetQuaJson = DataReader["KetQuaNgays_1"].ToString();
                    if (DataReader["KetQuaNgays_2"] != DBNull.Value)
                        KetQuaJson += DataReader["Thuoc_2"].ToString();
                    data.KetQuaNgays = JsonConvert.DeserializeObject<ObservableCollection<ThongTinNuocTieuTheoNgay>>(KetQuaJson);

                    data.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                    data.NguoiTao = DataReader["NguoiTao"].ToString();
                    data.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);
                    data.NguoiSua = DataReader["NguoiSua"].ToString();

                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return data;
        }
        public static List<PhieuTheoDoiNuocTieu24hDanhChoBenhNhan> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuTheoDoiNuocTieu24hDanhChoBenhNhan> list = new List<PhieuTheoDoiNuocTieu24hDanhChoBenhNhan>();
            try
            {
                string sql = @"SELECT * FROM PhieuTDNuocTieu24H where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuTheoDoiNuocTieu24hDanhChoBenhNhan data = new PhieuTheoDoiNuocTieu24hDanhChoBenhNhan();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.TenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.NgayNhapVien = DataReader["NgayNhapVien"] == DBNull.Value ? (DateTime?)null : DataReader.GetDate("NgayNhapVien");
                    data.Tuoi = DataReader["Tuoi"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.SoPhong = DataReader["SoPhong"].ToString();
                    data.SoGiuong = DataReader["SoGiuong"].ToString();

                    string KetQuaJson = DataReader["KetQuaNgays_1"].ToString();
                    if (DataReader["KetQuaNgays_2"] != DBNull.Value)
                        KetQuaJson += DataReader["Thuoc_2"].ToString();
                    data.KetQuaNgays = JsonConvert.DeserializeObject<ObservableCollection<ThongTinNuocTieuTheoNgay>>(KetQuaJson);

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuTheoDoiNuocTieu24hDanhChoBenhNhan bangTheoDoi)
        {
            try
            {
                string sql = @"INSERT INTO PhieuTDNuocTieu24H
                (
                    MAQUANLY,
                    MaBenhNhan,
                    TenBenhNhan,
                    NgayNhapVien,
                    Tuoi,
                    ChanDoan,
                    SoPhong,
                    SoGiuong,
                    KetQuaNgays_1,
                    KetQuaNgays_2,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :TenBenhNhan,
                    :NgayNhapVien,
                    :Tuoi,
                    :ChanDoan,
                    :SoPhong,
                    :SoGiuong,
                    :KetQuaNgays_1,
                    :KetQuaNgays_2,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (bangTheoDoi.ID != 0)
                {
                    sql = @"UPDATE PhieuTDNuocTieu24H SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    TenBenhNhan = :TenBenhNhan,
                    NgayNhapVien = :NgayNhapVien,
                    Tuoi = :Tuoi,
                    ChanDoan = :ChanDoan,
                    SoPhong = :SoPhong,
                    SoGiuong = :SoGiuong,
                    KetQuaNgays_1 = :KetQuaNgays_1,
                    KetQuaNgays_2 = :KetQuaNgays_2,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + bangTheoDoi.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangTheoDoi.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", bangTheoDoi.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("TenBenhNhan", bangTheoDoi.TenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("NgayNhapVien", bangTheoDoi.NgayNhapVien));
                Command.Parameters.Add(new MDB.MDBParameter("Tuoi", bangTheoDoi.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", bangTheoDoi.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("SoPhong", bangTheoDoi.SoPhong));
                Command.Parameters.Add(new MDB.MDBParameter("SoGiuong", bangTheoDoi.SoGiuong));
                string ketQuaJson = JsonConvert.SerializeObject(bangTheoDoi.KetQuaNgays);
                List<string> listJson = new List<string>();
                for (int i = 0; i < ketQuaJson.Length; i += 3999)
                {
                    if ((i + 3999) < ketQuaJson.Length)
                        listJson.Add(ketQuaJson.Substring(i, 3999));
                    else
                        listJson.Add(ketQuaJson.Substring(i));
                }
                Command.Parameters.Add(new MDB.MDBParameter("KetQuaNgays_1", listJson[0]));
                Command.Parameters.Add(new MDB.MDBParameter("KetQuaNgays_2", listJson.Count > 1 ? listJson[1] : null));
                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", bangTheoDoi.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", bangTheoDoi.NgaySua));
                if (bangTheoDoi.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", bangTheoDoi.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", bangTheoDoi.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", bangTheoDoi.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (bangTheoDoi.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    bangTheoDoi.ID = nextval;
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
                string sql = "DELETE FROM PhieuTDNuocTieu24H WHERE ID = :ID";
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
