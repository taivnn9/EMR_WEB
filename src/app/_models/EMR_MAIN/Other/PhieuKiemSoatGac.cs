using EMR.KyDienTu;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using PMS.Access; 

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuKiemSoatGac : ThongTinKy
    {
        public PhieuKiemSoatGac()
        {
            TableName = "phieukiemsoatgac";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.KSGTCM;
            TenMauPhieu = DanhMucPhieu.KSGTCM.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        public DateTime ThoiGianTao { get; set; }
        public DateTime? ThoiGianSua { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Bệnh viện")]
		public string BenhVien { get; set; }
        public string KhoaPhong { get; set; }
        public string HoTen { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        [MoTaDuLieu("Chẩn đoán sau mổ")]
		public string ChanDoanSauMo { get; set; }
        public string PhuongPhapPhauThuat { get; set; }
        public List<PhieuKiemSoatGacDichVu> DichVus { get; set; }
        public string PhauThuatVien { get; set; }
        public string DungCu { get; set; }
        public string NguoiDemGac { get; set; }
        public int TrangThai { get; set; }
        public string MaNVPhauThuatVien { get; set; }
        public string MaNVDungCu { get; set; }
        public string MaNVNguoiDemGac { get; set; }
    }
    public class PhieuKiemSoatGacDichVu
    {
        public PhieuKiemSoatGacDichVu() { }
        [MoTaDuLieu("Mã định danh")]
		public int ID { get; set; }
        public string LoaiGac { get; set; }
        public decimal SoLuongChuanBi { get; set; }
        public decimal SoLuongSuDung { get; set; }
        public decimal SoLuongConLai { get; set; }
        [MoTaDuLieu("Ghi chú")]
		public string GhiChu { get; set; }
        public PhieuKiemSoatGacDichVu(int ID, string LoaiGac, decimal SoLuongChuanBi, decimal SoLuongSuDung, decimal SoLuongConLai, string GhiChu)
        {
            this.ID = ID;
            this.LoaiGac = LoaiGac;
            this.SoLuongChuanBi = SoLuongChuanBi;
            this.SoLuongSuDung = SoLuongSuDung;
            this.SoLuongConLai = SoLuongConLai;
            this.GhiChu = GhiChu;
        }
    }
    public class PhieuKiemSoatGacFunc
    {
        public static long InsertOrUpdate(PhieuKiemSoatGac phieuKiemSoatGac, MDB.MDBConnection conn)
        {
            long result = 0;
            try
            {
                string sql = "SELECT ID FROM PHIEUKIEMSOATGAC WHERE ID = :ID AND TRANGTHAI = 0";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, conn);
                command.Parameters.Add(new MDB.MDBParameter("ID", phieuKiemSoatGac.ID));
                int count = 0;
                MDB.MDBDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read()) count++;

                if (count > 0)
                    sql = "UPDATE PHIEUKIEMSOATGAC SET BENHVIEN = :BENHVIEN, KHOAPHONG = :KHOAPHONG, MAQUANLY = :MAQUANLY, HOTEN = :HOTEN, TUOI = :TUOI, GIOITINH = :GIOITINH, CHANDOANSAUMO = :CHANDOANSAUMO, PHUONGPHAPPHAUTHUAT = :PHUONGPHAPPHAUTHUAT, DICHVU = :DICHVU, THOIGIANTAO = :THOIGIANTAO, THOIGIANSUA = :THOIGIANSUA, NGUOITAO = :NGUOITAO, NGUOISUA = :NGUOISUA, PHAUTHUATVIEN = :PHAUTHUATVIEN, DUNGCU = :DUNGCU, NGUOIDEMGAC = :NGUOIDEMGAC, MANVPHAUTHUATVIEN = :MANVPHAUTHUATVIEN, MANVDUNGCU = :MANVDUNGCU, MANVNGUOIDEMGAC = :MANVNGUOIDEMGAC WHERE ID = :ID";
                else
                    sql = "INSERT INTO PHIEUKIEMSOATGAC (BENHVIEN, KHOAPHONG, MAQUANLY, HOTEN, TUOI, GIOITINH, CHANDOANSAUMO, PHUONGPHAPPHAUTHUAT, DICHVU, THOIGIANTAO, THOIGIANSUA, NGUOITAO,  NGUOISUA, PHAUTHUATVIEN, DUNGCU, NGUOIDEMGAC, MANVPHAUTHUATVIEN, MANVDUNGCU, MANVNGUOIDEMGAC) VALUES (:BENHVIEN, :KHOAPHONG, :MAQUANLY, :HOTEN, :TUOI, :GIOITINH, :CHANDOANSAUMO, :PHUONGPHAPPHAUTHUAT, :DICHVU, :THOIGIANTAO, :THOIGIANSUA, :NGUOITAO, :NGUOISUA, :PHAUTHUATVIEN, :DUNGCU, :NGUOIDEMGAC, :MANVPHAUTHUATVIEN, :MANVDUNGCU, :MANVNGUOIDEMGAC) RETURNING ID INTO :ID";
                command = new MDB.MDBCommand(sql, conn);
                command.Parameters.Add("BENHVIEN", phieuKiemSoatGac.BenhVien);
                command.Parameters.Add("KHOAPHONG", phieuKiemSoatGac.KhoaPhong);
                command.Parameters.Add("MAQUANLY", phieuKiemSoatGac.MaQuanLy);
                command.Parameters.Add("HOTEN", phieuKiemSoatGac.HoTen);
                command.Parameters.Add("TUOI", phieuKiemSoatGac.Tuoi);
                command.Parameters.Add("GIOITINH", phieuKiemSoatGac.GioiTinh);
                command.Parameters.Add("CHANDOANSAUMO", phieuKiemSoatGac.ChanDoanSauMo);
                command.Parameters.Add("PHUONGPHAPPHAUTHUAT", phieuKiemSoatGac.PhuongPhapPhauThuat);
                command.Parameters.Add("DICHVU", JsonConvert.SerializeObject(phieuKiemSoatGac.DichVus));
                command.Parameters.Add("THOIGIANTAO", phieuKiemSoatGac.ThoiGianTao);
                if (count > 0)
                    command.Parameters.Add("THOIGIANSUA", DateTime.UtcNow.AddHours(7));
                else
                    command.Parameters.Add("THOIGIANSUA", phieuKiemSoatGac.ThoiGianSua);
                command.Parameters.Add("NGUOITAO", phieuKiemSoatGac.NguoiTao);
                if (count > 0)
                    command.Parameters.Add("NGUOISUA", Common.getUserLogin());
                else
                    command.Parameters.Add("NGUOISUA", phieuKiemSoatGac.NguoiSua);
                command.Parameters.Add("PHAUTHUATVIEN", phieuKiemSoatGac.PhauThuatVien);
                command.Parameters.Add("DUNGCU", phieuKiemSoatGac.DungCu);
                command.Parameters.Add("NGUOIDEMGAC", phieuKiemSoatGac.NguoiDemGac);
                command.Parameters.Add("MANVPHAUTHUATVIEN", phieuKiemSoatGac.MaNVPhauThuatVien);
                command.Parameters.Add("MANVDUNGCU", phieuKiemSoatGac.MaNVDungCu);
                command.Parameters.Add("MANVNGUOIDEMGAC", phieuKiemSoatGac.MaNVNguoiDemGac);
                command.Parameters.Add("ID", phieuKiemSoatGac.ID);
                command.BindByName = true;
                int n = command.ExecuteNonQuery();
                result = Convert.ToInt64((command.Parameters["ID"] as MDB.MDBParameter).Value);
                return n > 0 ? result : 0;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return result;
        }
        public static bool Delete(long ID, MDB.MDBConnection conn)
        {
            try
            {
                string sql = "UPDATE PHIEUKIEMSOATGAC SET TRANGTHAI = 1 WHERE ID = :ID";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, conn);
                command.Parameters.Add(new MDB.MDBParameter("ID", ID));
                int n = command.ExecuteNonQuery();
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static List<PhieuKiemSoatGac> GetPhieuKiemSoatGacs(decimal MaQuanLy, MDB.MDBConnection conn)
        {
            List<PhieuKiemSoatGac> lstPhieuKiemSoatGacs = new List<PhieuKiemSoatGac>();
            try
            {
                string sql = "SELECT * FROM PHIEUKIEMSOATGAC WHERE MAQUANLY = :MAQUANLY AND TRANGTHAI = 0";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, conn);
                command.Parameters.Add("MAQUANLY", MaQuanLy);
                MDB.MDBDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    PhieuKiemSoatGac phieuKiemSoatGac = new PhieuKiemSoatGac();
                    phieuKiemSoatGac.ID = Convert.ToInt64(dataReader.GetLong("ID"));
                    phieuKiemSoatGac.MaQuanLy = Convert.ToDecimal(dataReader.GetDecimal("MAQUANLY"));
                    phieuKiemSoatGac.BenhVien = dataReader["BENHVIEN"].ToString();
                    phieuKiemSoatGac.KhoaPhong = dataReader["KHOAPHONG"].ToString();
                    phieuKiemSoatGac.HoTen = dataReader["HOTEN"].ToString();
                    phieuKiemSoatGac.Tuoi = dataReader["TUOI"].ToString();
                    phieuKiemSoatGac.GioiTinh = dataReader["GIOITINH"].ToString();
                    phieuKiemSoatGac.ChanDoanSauMo = dataReader["CHANDOANSAUMO"].ToString();
                    phieuKiemSoatGac.PhuongPhapPhauThuat = dataReader["PHUONGPHAPPHAUTHUAT"].ToString();
                    if (dataReader["DICHVU"] != null && dataReader["DICHVU"].ToString() != string.Empty)
                        phieuKiemSoatGac.DichVus = JsonConvert.DeserializeObject<List<PhieuKiemSoatGacDichVu>>(dataReader["DICHVU"].ToString());
                    phieuKiemSoatGac.ThoiGianTao = Convert.ToDateTime(dataReader.GetDate("THOIGIANTAO"));
                    if (dataReader["THOIGIANSUA"] != null && dataReader["THOIGIANSUA"].ToString() != string.Empty)
                        phieuKiemSoatGac.ThoiGianSua = Convert.ToDateTime(dataReader.GetDate("THOIGIANSUA"));
                    phieuKiemSoatGac.NguoiTao = dataReader["NGUOITAO"].ToString();
                    phieuKiemSoatGac.NguoiSua = dataReader["NGUOISUA"].ToString();
                    phieuKiemSoatGac.PhauThuatVien = dataReader["PHAUTHUATVIEN"].ToString();
                    phieuKiemSoatGac.DungCu = dataReader["DUNGCU"].ToString();
                    phieuKiemSoatGac.NguoiDemGac = dataReader["NGUOIDEMGAC"].ToString();
                    phieuKiemSoatGac.TrangThai = Convert.ToInt32(dataReader.GetLong("TRANGTHAI"));
                    phieuKiemSoatGac.MaNVPhauThuatVien = dataReader["MANVPHAUTHUATVIEN"].ToString();
                    phieuKiemSoatGac.MaNVDungCu = dataReader["MANVDUNGCU"].ToString();
                    phieuKiemSoatGac.MaNVNguoiDemGac = dataReader["MANVNGUOIDEMGAC"].ToString();
                    lstPhieuKiemSoatGacs.Add(phieuKiemSoatGac);
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return lstPhieuKiemSoatGacs = lstPhieuKiemSoatGacs.OrderByDescending(s => s.ThoiGianTao).ThenBy(s => s.ID).ToList();
        }
        public static DataSet GetDataSet(long ID, MDB.MDBConnection conn)
        {
            DataSet dataSet = new DataSet();
            try
            {
                string sql = "SELECT a.*, b.HOVATEN TENPHAUTHUATVIEN, c.HOVATEN TENDUNGCUVIEN, d.HOVATEN TENNGUOIDEMGAC" +
                    " FROM PHIEUKIEMSOATGAC a " +
                    "left join NHANVIEN b on a.MANVPHAUTHUATVIEN = b.MANHANVIEN " +
                    "left join NHANVIEN c on a.MANVDUNGCU = c.MANHANVIEN " +
                    "left join NHANVIEN d on a.MANVNGUOIDEMGAC = d.MANHANVIEN " +
                    "WHERE ID = :ID AND TRANGTHAI = 0";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, conn);
                command.Parameters.Add(new MDB.MDBParameter("ID", ID));

                MDB.MDBDataAdapter adapter = new MDB.MDBDataAdapter(command);
                DataTable dataTablePhieu = new DataTable();
                adapter.Fill(dataTablePhieu);
                dataTablePhieu.TableName = "dataTablePhieu";

                dataSet.Tables.Add(dataTablePhieu);

                MDB.MDBDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    string dichVu = dataReader["DICHVU"].ToString();
                    if (dichVu != null && dichVu.ToString() != "[]")
                    {
                        var listDichVu = JsonConvert.DeserializeObject<List<PhieuKiemSoatGacDichVu>>(dichVu);
                        DataTable dataTableDichVu = Converter.ListToDatatable.ToDataTable(listDichVu);
                        dataTableDichVu.TableName = "dataTableDichVu";

                        dataSet.Tables.Add(dataTableDichVu);
                    }
                }
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return dataSet;
        }
    }
}
