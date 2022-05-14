using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace EMR_MAIN.DATABASE.Other
{
    public class ChiTietPTBangThuoc // set lại binding đoạn này lên giao diện file xaml nhé
    {
        [MoTaDuLieu("Dữ liệu cột 1, ngày giờ")]
        public string C1 { get; set; }
        [MoTaDuLieu("Dữ liệu cột 2, diễn biến")]
        public string C2 { get; set; }
        [MoTaDuLieu("Dữ liệu cột 3, y lệnh")]
        public string C3 { get; set; }
       

        
    }
    public class PhaThaiBangThuoc : ThongTinKy
    {
        public PhaThaiBangThuoc()
        {
            TableName = "PhaThaiBangThuoc";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PTBT;
            TenMauPhieu = DanhMucPhieu.PTBT.Description();
        }
        [MoTaDuLieu("Mã định danh")]
        public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau", "", 1)]
        public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
        public string MaBenhNhan { get; set; }

        // phần nọi dung phiếu
        [MoTaDuLieu("Tờ điều trị số")]
        public string So { get; set; }
        [MoTaDuLieu("HoTenBenhNhan")]
        public string HoTenBN { get; set; }
        [MoTaDuLieu("Năm sinh bệnh nhân")]
        public string NamSinh { get; set; }
        // bảng nội dung phá thai
        public ObservableCollection<ChiTietPTBangThuoc> ThuocVatTus { get; set; }

        // bắt buộc
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
    public class PhaThaiBangThuocFunc
    {
        public const string TableName = "PhaThaiBangThuoc";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhaThaiBangThuoc> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhaThaiBangThuoc> list = new List<PhaThaiBangThuoc>();
            try
            {
                string sql = @"SELECT * FROM PhaThaiBangThuoc where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhaThaiBangThuoc data = new PhaThaiBangThuoc();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();

                    data.So = DataReader["So"].ToString();
                    data.HoTenBN = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.NamSinh = DataReader["NamSinh"].ToString();


                    string bangKeJson = DataReader["ThuocGayMe_1"].ToString();
                    if (DataReader["ThuocGayMe_2"] != DBNull.Value)
                        bangKeJson += DataReader["ThuocGayMe_2"].ToString();
                    data.ThuocVatTus = JsonConvert.DeserializeObject<ObservableCollection<ChiTietPTBangThuoc>>(bangKeJson);

                    


                    data.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                    data.NguoiTao = DataReader["NguoiTao"].ToString();
                    data.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);
                    data.NguoiSua = DataReader["NguoiSua"].ToString();

                    data.MaSoKy = DataReader["Masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;
                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhaThaiBangThuoc bangKe)
        {
            try
            {
                string sql = @"INSERT INTO PhaThaiBangThuoc
                (
                    MAQUANLY,
                    MaBenhNhan,
                    So,  
                    HoTenBN,
                    NamSinh,
                    ThuocGayMe_1,
                    ThuocGayMe_2,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (  :MAQUANLY,
                    :MaBenhNhan,
                    :So,  
                    :HoTenBN,
                    :NamSinh,
                    :ThuocGayMe_1,
                    :ThuocGayMe_2,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (bangKe.ID != 0)
                {
                    sql = @"UPDATE PhaThaiBangThuoc SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,                   
                    So = :So,
                    HoTenBN = :HoTenBN,
                    NamSinh = :NamSinh,
                    ThuocGayMe_1= :ThuocGayMe_1,
                    ThuocGayMe_2 = :ThuocGayMe_2,                   
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + bangKe.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangKe.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", bangKe.MaBenhNhan));

                Command.Parameters.Add(new MDB.MDBParameter("So", bangKe.So));

                Command.Parameters.Add(new MDB.MDBParameter("HoTenBN", bangKe.HoTenBN));
                Command.Parameters.Add(new MDB.MDBParameter("NamSinh", bangKe.NamSinh));
 
                string jsonBangKes = JsonConvert.SerializeObject(bangKe.ThuocVatTus);
                List<string> listJson = Common.SplitByLength(jsonBangKes, 3999).ToList();
                Command.Parameters.Add(new MDB.MDBParameter("ThuocGayMe_1", listJson[0]));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocGayMe_2", listJson.Count > 1 ? listJson[1] : null));
               

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
                string sql = "DELETE FROM PhaThaiBangThuoc WHERE ID = :ID";
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
                B.MaQuanLy,
                B.MaBenhNhan,
                B.So,    
                B.HoTenBN,
                B.NamSinh
                    

            FROM
                PhaThaiBangThuoc B
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "BK");
            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));
            // ds.Tables[0].AddColumn("GioiTinh", typeof(int));
            ds.Tables[0].AddColumn("SOYTE", typeof(string));
            ds.Tables[0].AddColumn("BENHVIEN", typeof(string));
            ds.Tables[0].AddColumn("KHOA", typeof(string));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            //ds.Tables[0].Rows[0]["GioiTinh"] = (int)XemBenhAn._HanhChinhBenhNhan.GioiTinh;
            ds.Tables[0].Rows[0]["SOYTE"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["KHOA"] = XemBenhAn._ThongTinDieuTri.Khoa;

            sql = @"SELECT B.ThuocGayMe_1, B.ThuocGayMe_2
            FROM
                PhaThaiBangThuoc B
                
            WHERE
                ID = " + id;

            Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            ObservableCollection<ChiTietPTBangThuoc> saveDatas = new ObservableCollection<ChiTietPTBangThuoc>();
            while (DataReader.Read())
            {
                string bangKeJson = DataReader["ThuocGayMe_1"].ToString();
                if (DataReader["ThuocGayMe_1"] != DBNull.Value)
                    bangKeJson += DataReader["ThuocGayMe_2"].ToString();
                saveDatas = JsonConvert.DeserializeObject<ObservableCollection<ChiTietPTBangThuoc>>(bangKeJson);
                break;
            }

            ds.Tables.Add(Common.ListToDataTable(saveDatas, "CT"));

            return ds;

        }
    }

}
