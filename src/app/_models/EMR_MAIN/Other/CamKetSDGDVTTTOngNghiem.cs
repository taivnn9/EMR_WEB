using EMR.KyDienTu;
using Newtonsoft.Json;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMR_MAIN.DATABASE.Other
{
    public class CamKetSDGDVTTTOngNghiem : ThongTinKy
    {
        public CamKetSDGDVTTTOngNghiem()
        {
            TableName = "CamKetSDGDVTTTOngNghiem";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.CKSDGDVTTTON;
            TenMauPhieu = DanhMucPhieu.CKSDGDVTTTON.Description();
        }
        [MoTaDuLieu("Mã định danh")]
        public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau", "", 1)]
        public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
        public string MaBenhNhan { get; set; }
        public string KinhGui { get; set; }
        public string HoTenVo { get; set; }
        public string NamSinhVo { get; set; }
        public string HoTenChong { get; set; }
        public string NamSinhChong { get; set; }
        public string DiaChi { get; set; }
        [MoTaDuLieu("Danh sách dịch vụ")]
        public ObservableCollection<DichVuTrongThuTinhOngNghiem> DichVu { get; set; }

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
    public class DichVuTrongThuTinhOngNghiem
    {
        public int TT { get; set; }
        public string TenKyThuat { get; set; }
        public string GiaDichVu { get; set; }
    }
    public class CamKetSDGDVTTTOngNghiemFunc
    {
        public const string TableName = "CamKetSDGDVTTTOngNghiem";
        public const string TablePrimaryKeyName = "ID";
        public static List<CamKetSDGDVTTTOngNghiem> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<CamKetSDGDVTTTOngNghiem> list = new List<CamKetSDGDVTTTOngNghiem>();
            try
            {
                string sql = @"SELECT * FROM CamKetSDGDVTTTOngNghiem where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    CamKetSDGDVTTTOngNghiem data = new CamKetSDGDVTTTOngNghiem();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.KinhGui = DataReader["KinhGui"].ToString();
                    data.HoTenVo = DataReader["HoTenVo"].ToString();
                    data.NamSinhVo = DataReader["NamSinhVo"].ToString();
                    data.HoTenChong = DataReader["HoTenChong"].ToString();
                    data.NamSinhChong = DataReader["NamSinhChong"].ToString();
                    data.DiaChi = DataReader["DiaChi"].ToString();
                    data.DichVu = JsonConvert.DeserializeObject<ObservableCollection<DichVuTrongThuTinhOngNghiem>>(DataReader["DichVu"].ToString());
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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref CamKetSDGDVTTTOngNghiem bangKe)
        {
            try
            {
                string sql = @"INSERT INTO CamKetSDGDVTTTOngNghiem
                (
                    MAQUANLY,
                    MaBenhNhan,
                    KinhGui,
                    HoTenVo,
                    NamSinhVo,
                    HoTenChong,
                    NamSinhChong,
                    DiaChi,
                    DichVu,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :KinhGui,
                    :HoTenVo,
                    :NamSinhVo,
                    :HoTenChong,
                    :NamSinhChong,
                    :DiaChi,
                    :DichVu,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (bangKe.ID != 0)
                {
                    sql = @"UPDATE CamKetSDGDVTTTOngNghiem SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,
                    KinhGui=:KinhGui,
                    HoTenVo=:HoTenVo,
                    NamSinhVo=:NamSinhVo,
                    HoTenChong=:HoTenChong,
                    NamSinhChong=:NamSinhChong,
                    DiaChi=:DiaChi,
                    DichVu=:DichVu,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + bangKe.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangKe.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", bangKe.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("KinhGui", bangKe.KinhGui));
                Command.Parameters.Add(new MDB.MDBParameter("HoTenVo", bangKe.HoTenVo));
                Command.Parameters.Add(new MDB.MDBParameter("NamSinhVo", bangKe.NamSinhVo));
                Command.Parameters.Add(new MDB.MDBParameter("HoTenChong", bangKe.HoTenChong));
                Command.Parameters.Add(new MDB.MDBParameter("NamSinhChong", bangKe.NamSinhChong));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", bangKe.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("DichVu", JsonConvert.SerializeObject(bangKe.DichVu)));
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
                string sql = "DELETE FROM CamKetSDGDVTTTOngNghiem WHERE ID = :ID";
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
                P.* 
            FROM
                CamKetSDGDVTTTOngNghiem P
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "KQ");
            ObservableCollection<DichVuTrongThuTinhOngNghiem> DichVu = JsonConvert.DeserializeObject<ObservableCollection<DichVuTrongThuTinhOngNghiem>>(ds.Tables[0].Rows[0]["DichVu"].ToString());
            DataTable ChiTiet = Common.ListToDataTable(DichVu.ToList(), "CT");

            ds.Tables[0].AddColumn("LoGoPath", typeof(string));
            ds.Tables[0].AddColumn("SOYTE", typeof(string));
            ds.Tables[0].AddColumn("BENHVIEN", typeof(string));
            ds.Tables[0].AddColumn("KHOA", typeof(string));

            ds.Tables[0].Rows[0]["LoGoPath"] = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\PaintLibrary\HinhAnh\LoGoVien\" + "Logo.png";
            ds.Tables[0].Rows[0]["SOYTE"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["KHOA"] = XemBenhAn._ThongTinDieuTri.Khoa;

            ds.Tables.Add(ChiTiet);
            return ds;
        }
    }
}
