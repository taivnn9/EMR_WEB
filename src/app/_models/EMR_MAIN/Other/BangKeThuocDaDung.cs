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
    public class ChiTietBKTDD // set lại binding đoạn này lên giao diện file xaml nhé
    {
        [MoTaDuLieu("Dữ liệu cột 1")]
        public string C1 { get; set; }
        [MoTaDuLieu("Dữ liệu cột 2")]
        public string C2 { get; set; }
        [MoTaDuLieu("Dữ liệu cột 3")]
        public string C3 { get; set; }
        [MoTaDuLieu("Dữ liệu cột 4")]
        public string C4 { get; set; }
        [MoTaDuLieu("Dữ liệu cột 5")]
        public string C5 { get; set; }
        [MoTaDuLieu("Dữ liệu cột 6")]
        public string C6 { get; set; }
        [MoTaDuLieu("Dữ liệu cột 7")]
        public string C7 { get; set; }
        [MoTaDuLieu("Dữ liệu cột 8")]
        public string C8 { get; set; }
    }
    public class BangKeThuocDaDung : ThongTinKy
    {
        public BangKeThuocDaDung()
        {
            TableName = "BangKeThuocDaDung";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BKTDD;
            TenMauPhieu = DanhMucPhieu.BKTDD.Description();
        }
        [MoTaDuLieu("Mã định danh")]
        public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau", "", 1)]
        public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
        public string MaBenhNhan { get; set; }

        // Tiêu đề
        public string So { get; set; }
        [MoTaDuLieu("Số")]
        // kết thúc

        // bảng kê thuốc dùng trong gây meư
        [MoTaDuLieu("Họ tên bệnh nhân")]
        public string HoTenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
        public String Tuoi { get; set; }// d
        [MoTaDuLieu("Địa chỉ bệnh nhân")]
        public string DiaChi { get; set; }
        public string Khoa { get; set; }
        [MoTaDuLieu("Khoa")]

        public string MaBenhAn { get; set; }// số bệnh án
        [MoTaDuLieu("Mã Bệnh Án")]

        public string CanBenh { get; set; }
        [MoTaDuLieu("Căn bệnh mắc phải")]
        public DateTime? NgayVaoVien { get; set; }
        [MoTaDuLieu("Ngày vào viện")]
        public DateTime? NgayRaVien { get; set; }
        [MoTaDuLieu("Ngày ra viện")]


        // bảng thuốc vật tư dùng trong gây mê
        public ObservableCollection<ChiTietBKTDD> ThuocVatTus { get; set; }


        //Bắt đầu danh sách người ký
        [MoTaDuLieu("Mã trưởng khoa")]
        public string MaTruongKhoa { get; set; }
        [MoTaDuLieu("Họ tên mã trưởng khoa")]
        public string HoTenTruongKhoa { get; set; }

        [MoTaDuLieu("Mã Bệnh nhân")]
        // public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Họ Tên bệnh nhân")]
        //public string HoTenBenhNhan { get; set; }
        [MoTaDuLieu("Ngày ký")]
        public DateTime? NgayKyBKTDD { get; set; }

        [MoTaDuLieu("Mã Kế Toán")]
        public string MaKeToan { get; set; }
        [MoTaDuLieu("Họ tên người kế toán")]
        public string HoTenKeToan { get; set; }



        //Kết thúc danh sách người ký

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
    public class BangKeThuocDaDungFunc
    {   
        public const string TableName = "BangKeThuocDaDung";
        public const string TablePrimaryKeyName = "ID";
        public static List<BangKeThuocDaDung> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BangKeThuocDaDung> list = new List<BangKeThuocDaDung>();
            try
            {
                string sql = @"SELECT * FROM BangKeThuocDaDung where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    BangKeThuocDaDung data = new BangKeThuocDaDung();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();

                    data.So = DataReader["So"].ToString();
                    data.HoTenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = DataReader["Tuoi"].ToString();
                    data.DiaChi = DataReader["DiaChi"].ToString();
                    data.Khoa = XemBenhAn._ThongTinDieuTri.Khoa;
                    data.MaBenhAn = XemBenhAn._ThongTinDieuTri.MaBenhAn;
                    data.CanBenh = DataReader["CanBenh"].ToString();

                    data.NgayVaoVien = Convert.ToDateTime(DataReader["NgayVaoVien"] == DBNull.Value ? DateTime.Now : DataReader["NgayVaoVien"]);
                    data.NgayRaVien = Convert.ToDateTime(DataReader["NgayRaVien"] == DBNull.Value ? DateTime.Now : DataReader["NgayRaVien"]);



                    string bangKeJson = DataReader["ThuocGayMe_1"].ToString();
                    if (DataReader["ThuocGayMe_2"] != DBNull.Value)
                        bangKeJson += DataReader["ThuocGayMe_2"].ToString();
                    data.ThuocVatTus = JsonConvert.DeserializeObject<ObservableCollection<ChiTietBKTDD>>(bangKeJson);

                    data.MaTruongKhoa = DataReader["MaTruongKhoa"].ToString();
                    data.HoTenTruongKhoa = DataReader["HoTenTruongKhoa"].ToString();
                    data.NgayKyBKTDD = Convert.ToDateTime(DataReader["NgayKyBKTDD"] == DBNull.Value ? DateTime.Now : DataReader["NgayKyBKTDD"]);
                    data.MaKeToan = DataReader["MaKeToan"].ToString();

                    data.HoTenKeToan = DataReader["HoTenKeToan"].ToString();


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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BangKeThuocDaDung bangKe)
        {
            try
            {
                string sql = @"INSERT INTO BangKeThuocDaDung
                (
                    MAQUANLY,
                    MaBenhNhan,
                    So,  
                    HoTenBenhNhan,  
                    Tuoi,  
                    DiaChi,  
                    Khoa,  
                    MaBenhAn,  
                    CanBenh,  
                    NgayVaoVien,
                    NgayRaVien,
                    ThuocGayMe_1,  
                    ThuocGayMe_2,  
                    MaTruongKhoa,  
                    HoTenTruongKhoa,  
                    NgayKyBKTDD,
                    MaKeToan,  
                    HoTenKeToan,  
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (  :MAQUANLY,
                    :MaBenhNhan,
                    :So,  
                    :HoTenBenhNhan,  
                    :Tuoi,  
                    :DiaChi,  
                    :Khoa,  
                    :MaBenhAn,  
                    :CanBenh,  
                    :NgayVaoVien,
                    :NgayRaVien,
                    :ThuocGayMe_1,  
                    :ThuocGayMe_2,  
                    :MaTruongKhoa,  
                    :HoTenTruongKhoa,  
                    :NgayKyBKTDD,
                    :MaKeToan,  
                    :HoTenKeToan,   
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (bangKe.ID != 0)
                {
                    sql = @"UPDATE BangKeThuocDaDung SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,                   
                    So = :So,
                    HoTenBenhNhan = :HoTenBenhNhan,  
                    Tuoi = :Tuoi,
                    DiaChi = :DiaChi, 
                    Khoa= :Khoa, 
                    MaBenhAn = :MaBenhAn,
                    CanBenh = :CanBenh, 
                    NgayVaoVien = :NgayVaoVien,
                    NgayRaVien = :NgayRaVien,
                    ThuocGayMe_1= :ThuocGayMe_1,
                    ThuocGayMe_2 = :ThuocGayMe_2, 
                    MaTruongKhoa = :MaTruongKhoa, 
                    HoTenTruongKhoa = :HoTenTruongKhoa, 
                    NgayKyBKTDD = :NgayKyBKTDD,
                    MaKeToan = :MaKeToan,
                    HoTenKeToan  =  :HoTenKeToan,                  
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + bangKe.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangKe.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", bangKe.MaBenhNhan));

                Command.Parameters.Add(new MDB.MDBParameter("So", bangKe.So));

                Command.Parameters.Add(new MDB.MDBParameter("HoTenBenhNhan", bangKe.HoTenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("Tuoi", bangKe.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("DiaChi", bangKe.DiaChi));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa", bangKe.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhAn", bangKe.MaBenhAn));

                Command.Parameters.Add(new MDB.MDBParameter("CanBenh", bangKe.CanBenh));
                Command.Parameters.Add(new MDB.MDBParameter("NgayVaoVien", bangKe.NgayVaoVien));
                Command.Parameters.Add(new MDB.MDBParameter("NgayRaVien", bangKe.NgayRaVien));


                string jsonBangKes = JsonConvert.SerializeObject(bangKe.ThuocVatTus);
                List<string> listJson = Common.SplitByLength(jsonBangKes, 3999).ToList();
                Command.Parameters.Add(new MDB.MDBParameter("ThuocGayMe_1", listJson[0]));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocGayMe_2", listJson.Count > 1 ? listJson[1] : null));
                Command.Parameters.Add(new MDB.MDBParameter("MaTruongKhoa", bangKe.MaTruongKhoa));
                Command.Parameters.Add(new MDB.MDBParameter("HoTenTruongKhoa", bangKe.HoTenTruongKhoa));

                Command.Parameters.Add(new MDB.MDBParameter("NgayKyBKTDD", bangKe.NgayKyBKTDD));
                Command.Parameters.Add(new MDB.MDBParameter("MaKeToan", bangKe.MaKeToan));
                Command.Parameters.Add(new MDB.MDBParameter("HoTenKeToan", bangKe.HoTenKeToan));
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
                string sql = "DELETE FROM BangKeThuocDaDung WHERE ID = :ID";
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
                B.HoTenBenhNhan,  
                B.Tuoi,  
                B.DiaChi,  
                B.Khoa,  
                B.MaBenhAn,  
                B.CanBenh,  
                B.NgayVaoVien,
                B.NgayRaVien,                  
                B.MaTruongKhoa,  
                B.HoTenTruongKhoa,  
                B.NgayKyBKTDD,
                B.MaKeToan,  
                B.HoTenKeToan  

            FROM
                BangKeThuocDaDung B
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
                BangKeThuocDaDung B
                
            WHERE
                ID = " + id;

            Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            ObservableCollection<ChiTietBKTDD> saveDatas = new ObservableCollection<ChiTietBKTDD>();
            while (DataReader.Read())
            {
                string bangKeJson = DataReader["ThuocGayMe_1"].ToString();
                if (DataReader["ThuocGayMe_1"] != DBNull.Value)
                    bangKeJson += DataReader["ThuocGayMe_2"].ToString();
                saveDatas = JsonConvert.DeserializeObject<ObservableCollection<ChiTietBKTDD>>(bangKeJson);
                break;
            }



            ds.Tables.Add(Common.ListToDataTable(saveDatas, "CT"));

            return ds;

        }
    }
}
