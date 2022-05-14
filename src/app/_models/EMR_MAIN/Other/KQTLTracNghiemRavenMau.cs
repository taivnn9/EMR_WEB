
using EMR.KyDienTu;
using Newtonsoft.Json;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class KQTLTracNghiemRavenMau : ThongTinKy
    {
        public KQTLTracNghiemRavenMau()
        {
            TableName = "KQTLTracNghiemRavenMau";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.KQTLTNRM;
            TenMauPhieu = DanhMucPhieu.KQTLTNRM.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Khoa")]
		public string Khoa { get; set; }
		[MoTaDuLieu("Sở Y Tế")]
		public string SoYTe { get; set; }
        [MoTaDuLieu("Bệnh viện")]
		public string BenhVien { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        [MoTaDuLieu("Nghề nghiệp")]
		public string NgheNghiep { get; set; }
        public DateTime? NgayChiDinh { get; set; }
      
        public string MaNguoiLamTest { get; set; }
        public string NguoiLamTest { get; set; }
        public string MaBacSiChiDinh { get; set; }
        public string BacSiChiDinh { get; set; }
        public string TongDiem { get; set; }
        public string Diem { get; set; }
        public string IQ { get; set; }

        public ObservableCollection<KetQuaTracNghiemMau> ListKetQua { get; set; }

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

    public class KetQuaTracNghiemMau
    {
        public string STT { get; set; }
        public string TraLoi_A1 { get; set; }
        public string TraLoi_AB { get; set; }
        public string TraLoi_B { get; set; }
        public string Diem_A1 { get; set; }
        public string Diem_AB { get; set; }
        public string Diem_B { get; set; }

    }
    public class KQTLTracNghiemRavenMauFunc
    {
        public const string TableName = "KQTLTracNghiemRavenMau";
        public const string TablePrimaryKeyName = "ID";

        public static List<KQTLTracNghiemRavenMau> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<KQTLTracNghiemRavenMau> list = new List<KQTLTracNghiemRavenMau>();
            try
            {
                string sql = @"SELECT * FROM KQTLTracNghiemRavenMau where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    KQTLTracNghiemRavenMau data = new KQTLTracNghiemRavenMau();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;

                    data.MaBenhNhan = XemBenhAn._HanhChinhBenhNhan.MaBenhNhan;
                    data.TenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.Khoa = XemBenhAn._ThongTinDieuTri.Khoa;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.SoYTe = XemBenhAn._HanhChinhBenhNhan.SoYTe;
                    data.BenhVien = XemBenhAn._HanhChinhBenhNhan.BenhVien;

                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.DiaChi = DataReader["DiaChi"].ToString();
                    data.NgheNghiep = DataReader["NgheNghiep"].ToString();
                    data.NguoiLamTest = DataReader["NguoiLamTest"].ToString();
                    data.MaNguoiLamTest = DataReader["MaNguoiLamTest"].ToString();
                    data.BacSiChiDinh = DataReader["BacSiChiDinh"].ToString();
                    data.MaBacSiChiDinh = DataReader["MaBacSiChiDinh"].ToString();
                    data.TongDiem = DataReader["TongDiem"].ToString();
                    data.Diem = DataReader["Diem"].ToString();
                    data.IQ = DataReader["IQ"].ToString();
                    
                    data.NgayChiDinh = Convert.ToDateTime(DataReader["NgayChiDinh"] == DBNull.Value ? DateTime.Now : DataReader["NgayChiDinh"]);
                    data.ListKetQua = JsonConvert.DeserializeObject<ObservableCollection<KetQuaTracNghiemMau>>(DataReader["ListKetQua"].ToString());

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
                sql = @"DELETE FROM KQTLTracNghiemRavenMau WHERE ID =" + IDBienBan;
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
                KQTLTracNghiemRavenMau P
            WHERE
                ID = " + IDBienBan;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "TB");

            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(string));
            ds.Tables[0].AddColumn("SoYTe", typeof(string));
            ds.Tables[0].AddColumn("BenhVien", typeof(string));
            ds.Tables[0].AddColumn("Khoa", typeof(string));
            ds.Tables[0].AddColumn("ThongTinNgayThang", typeof(string));
            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            ds.Tables[0].Rows[0]["SoYTe"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BenhVien"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["Khoa"] = XemBenhAn._ThongTinDieuTri.Khoa;
            ds.Tables[0].Rows[0]["ThongTinNgayThang"] = "Ngày " + DateTime.Now.Day + " tháng " + DateTime.Now.Month + " năm " + DateTime.Now.Year;

            DataTable KS = new DataTable("KQ");
            KS.Columns.Add("STT", typeof(string));

            KS.Columns.Add("TraLoi_A1", typeof(string));
            KS.Columns.Add("Diem_A1", typeof(string));

            KS.Columns.Add("TraLoi_AB", typeof(string));
            KS.Columns.Add("Diem_AB", typeof(string));

            KS.Columns.Add("TraLoi_B", typeof(string));
            KS.Columns.Add("Diem_B", typeof(string));

           
            ObservableCollection<KetQuaTracNghiemMau> ListKetQua = JsonConvert.DeserializeObject<ObservableCollection<KetQuaTracNghiemMau>>(ds.Tables[0].Rows[0]["ListKetQua"].ToString());
            if (ListKetQua != null)
            {
                foreach (KetQuaTracNghiemMau KetQua in ListKetQua)
                {
                    KS.Rows.Add(KetQua.STT, KetQua.TraLoi_A1, KetQua.Diem_A1, KetQua.TraLoi_AB, KetQua.Diem_AB, KetQua.TraLoi_B, KetQua.Diem_B);
                }
            }
            ds.Tables.Add(KS);

            return ds;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref KQTLTracNghiemRavenMau ketQua)
        {
            try
            {
                string sql = @"INSERT INTO KQTLTracNghiemRavenMau
                (
                    MaQuanLy,
                    ChanDoan,
                    DiaChi,
                    NgheNghiep,
                    NgayChiDinh,
                    ListKetQua,
                    TongDiem,
                    Diem,
                    IQ,
                    NguoiLamTest,
                    MaNguoiLamTest,
                    BacSiChiDinh,
                    MaBacSiChiDinh,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
                    :ChanDoan,
                    :DiaChi,
                    :NgheNghiep,
                    :NgayChiDinh,
                    :ListKetQua,
                    :TongDiem,
                    :Diem,
                    :IQ,
                    :NguoiLamTest,
                    :MaNguoiLamTest,
                    :BacSiChiDinh,
                    :MaBacSiChiDinh,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE KQTLTracNghiemRavenMau SET 
                    MaQuanLy = :MaQuanLy,
                    ChanDoan = :ChanDoan,
                    DiaChi = :DiaChi,
                    NgheNghiep = :NgheNghiep,
                    NgayChiDinh = :NgayChiDinh,
                    ListKetQua = :ListKetQua,
                    TongDiem = :TongDiem,
                    Diem = :Diem,
                    IQ = :IQ,
                    NguoiLamTest = :NguoiLamTest,
                    MaNguoiLamTest = :MaNguoiLamTest,
                    BacSiChiDinh = :BacSiChiDinh,
                    MaBacSiChiDinh = :MaBacSiChiDinh,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA 
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));

                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", ketQua.MaQuanLy));

                Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", ketQua.ChanDoan));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", ketQua.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("NgheNghiep", ketQua.NgheNghiep));
                Command.Parameters.Add(new MDB.MDBParameter("NgayChiDinh", ketQua.NgayChiDinh));
                Command.Parameters.Add(new MDB.MDBParameter("ListKetQua", JsonConvert.SerializeObject(ketQua.ListKetQua)));
                Command.Parameters.Add(new MDB.MDBParameter("TongDiem", ketQua.TongDiem));
                Command.Parameters.Add(new MDB.MDBParameter("Diem", ketQua.Diem));
                Command.Parameters.Add(new MDB.MDBParameter("IQ", ketQua.IQ));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiLamTest", ketQua.NguoiLamTest));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiLamTest", ketQua.MaNguoiLamTest));
                Command.Parameters.Add(new MDB.MDBParameter("BacSiChiDinh", ketQua.BacSiChiDinh));
                Command.Parameters.Add(new MDB.MDBParameter("MaBacSiChiDinh", ketQua.MaBacSiChiDinh));

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
    }
}
