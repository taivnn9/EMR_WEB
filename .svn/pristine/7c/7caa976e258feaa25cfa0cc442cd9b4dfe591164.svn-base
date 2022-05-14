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
    public class ChiTietBVTTHDTGM // set lại binding đoạn này lên giao diện file xaml nhé
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
    public class BangKeVTTHDTGayMe : ThongTinKy
    {
        public BangKeVTTHDTGayMe()
        {
            TableName = "BangKeVTTHDTGayMe";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BKTDTGM;
            TenMauPhieu = DanhMucPhieu.BKTDTGM.Description();
        }
        [MoTaDuLieu("Mã định danh")]
        public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau", "", 1)]
        public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
        public string MaBenhNhan { get; set; }


        public string KipPhauThuat { get; set; }
        [MoTaDuLieu("kíp phẫu thuật")]
        public string So { get; set; }
        [MoTaDuLieu("Số")]
        public string Quyen { get; set; }
        [MoTaDuLieu("Quyển")]
        public string Khoa { get; set; }
        [MoTaDuLieu("Khoa")]
        public string PhongMoSo { get; set; }
        [MoTaDuLieu("Phòng Mổ Số")]


        // bảng kê thuốc dùng trong gây meư
        [MoTaDuLieu("Họ tên bệnh nhân")]
        public string HoTenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
        public String Tuoi { get; set; }// d
        [MoTaDuLieu("Giới tính bệnh nhân")]
        public string GioiTinh { get; set; }


        public string MaBenhAn { get; set; }
        [MoTaDuLieu("Mã Bệnh Án")]
        public DateTime? NgayPhauThuat { get; set; }
        [MoTaDuLieu("Ngày Phẫu Thuật")]
        public string CachPhauThuat { get; set; }
        [MoTaDuLieu("Cách Phẫu Thuật")]
        public string BacSyGayMe { get; set; }
        [MoTaDuLieu("Bác Sỹ Gây Mê")]
        public string KTVGayMe { get; set; }
        [MoTaDuLieu("KTV Gây Mê - Kỹ Thuật Viên Gây Mê")]
        public string DVC { get; set; }
        [MoTaDuLieu("DVC")]


        // bảng thuốc vật tư dùng trong gây mê
        public ObservableCollection<ChiTietBVTTHDTGM> VatTuGayMe { get; set; }
        [MoTaDuLieu("Mã bác sĩ làm thủ thuật")]

        //Bắt đầu danh sách người ký
        [MoTaDuLieu("Mã phẫu thuật viên")]
        public string MaPhauThuatVien { get; set; }
        [MoTaDuLieu("Họ tên Phẫu Thuật Viên")]
        public string HoTenPhauThuatVien { get; set; }

        [MoTaDuLieu("Mã bác sĩ gây mê")]
        public string MaNVBacSyGayMe { get; set; }
        [MoTaDuLieu("Họ Tên bác sĩ gây mê")]
        public string HoTenBacSyGayMe { get; set; }

        [MoTaDuLieu("Mã người lập bảng")]
        public string MaNguoiLapBang { get; set; }
        [MoTaDuLieu("Họ tên người lập bảng")]
        public string HoTenNguoiLapBang { get; set; }



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
    public class BangKeVTTHDTGayMeFunc
    {
        public const string TableName = "BangKeVTTHDTGayMe";
        public const string TablePrimaryKeyName = "ID";
        public static List<BangKeVTTHDTGayMe> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BangKeVTTHDTGayMe> list = new List<BangKeVTTHDTGayMe>();
            try
            {
                string sql = @"SELECT * FROM BangKeVTTHDTGayMe where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    BangKeVTTHDTGayMe data = new BangKeVTTHDTGayMe();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();

                    data.So = DataReader["So"].ToString();
                    data.Quyen = DataReader["Quyen"].ToString();
                    data.KipPhauThuat = DataReader["KipPhauThuat"].ToString();
                    data.PhongMoSo = DataReader["PhongMoSo"].ToString();

                    data.HoTenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    //data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                    data.GioiTinh = "Nữ";
                    data.MaBenhAn = XemBenhAn._ThongTinDieuTri.MaBenhAn;

                    data.NgayPhauThuat = Convert.ToDateTime(DataReader["NgayPhauThuat"] == DBNull.Value ? DateTime.Now : DataReader["NgayPhauThuat"]);
                    data.CachPhauThuat = DataReader["CachPhauThuat"].ToString();
                    data.BacSyGayMe = DataReader["BacSyGayMe"].ToString();

                    data.KTVGayMe = DataReader["KTVGayMe"].ToString();
                    data.DVC = DataReader["DVC"].ToString();


                    string bangKeJson = DataReader["ThuocGayMe_1"].ToString();
                    if (DataReader["ThuocGayMe_2"] != DBNull.Value)
                        bangKeJson += DataReader["ThuocGayMe_2"].ToString();
                    data.VatTuGayMe = JsonConvert.DeserializeObject<ObservableCollection<ChiTietBVTTHDTGM>>(bangKeJson);

                    data.MaPhauThuatVien = DataReader["MaPhauThuatVien"].ToString();
                    data.HoTenPhauThuatVien = DataReader["HoTenPhauThuatVien"].ToString();
                    data.MaNVBacSyGayMe = DataReader["MaNVBacSyGayMe"].ToString();


                    data.HoTenBacSyGayMe = DataReader["HoTenBacSyGayMe"].ToString();
                    data.MaNguoiLapBang = DataReader["MaNguoiLapBang"].ToString();
                    data.HoTenNguoiLapBang = DataReader["HoTenNguoiLapBang"].ToString();

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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BangKeVTTHDTGayMe bangKe)
        {
            try
            {
                string sql = @"INSERT INTO BangKeVTTHDTGayMe
                (
                    MAQUANLY,
                    MaBenhNhan,
                    KipPhauThuat, 
                    So,
                    Quyen, 
                    Khoa, 
                    PhongMoSo, 
                    HoTenBenhNhan, 
                    Tuoi,
                    GioiTinh, 
                    MaBenhAn,
                    NgayPhauThuat,
                    CachPhauThuat,
                    BacSyGayMe, 
                    KTVGayMe, 
                    DVC, 
                    ThuocGayMe_1, 
                    ThuocGayMe_2, 
                    MaPhauThuatVien, 
                    HoTenPhauThuatVien, 
                    MaNVBacSyGayMe, 
                    HoTenBacSyGayMe, 
                    MaNguoiLapBang, 
                    HoTenNguoiLapBang, 
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MAQUANLY,
                    :MaBenhNhan,
                    :KipPhauThuat, 
                    :So,
                    :Quyen, 
                    :Khoa, 
                    :PhongMoSo, 
                    :HoTenBenhNhan, 
                    :Tuoi,
                    :GioiTinh, 
                    :MaBenhAn,
                    :NgayPhauThuat,
                    :CachPhauThuat,
                    :BacSyGayMe, 
                    :KTVGayMe, 
                    :DVC, 
                    :ThuocGayMe_1, 
                    :ThuocGayMe_2, 
                    :MaPhauThuatVien, 
                    :HoTenPhauThuatVien, 
                    :MaNVBacSyGayMe, 
                    :HoTenBacSyGayMe, 
                    :MaNguoiLapBang, 
                    :HoTenNguoiLapBang, 
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (bangKe.ID != 0)
                {
                    sql = @"UPDATE BangKeVTTHDTGayMe SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,                   
                    NgayPhauThuat = :NgayPhauThuat,
                    CachPhauThuat = :CachPhauThuat,
                    BacSyGayMe = :BacSyGayMe,             
                    KTVGayMe = :KTVGayMe,
                    ThuocGayMe_1 = :ThuocGayMe_1,
                    ThuocGayMe_2 = :ThuocGayMe_2,                       
                    MaPhauThuatVien = :MaPhauThuatVien,                    
                    HoTenPhauThuatVien = :HoTenPhauThuatVien,
                    MaNVBacSyGayMe  = :MaNVBacSyGayMe,
                    HoTenBacSyGayMe = :HoTenBacSyGayMe,
                    MaNguoiLapBang = :MaNguoiLapBang,
                    HoTenNguoiLapBang = :HoTenNguoiLapBang,                    
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + bangKe.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangKe.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", bangKe.MaBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("KipPhauThuat", bangKe.KipPhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("So", bangKe.So));

                Command.Parameters.Add(new MDB.MDBParameter("Quyen", bangKe.Quyen));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa", bangKe.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("PhongMoSo", bangKe.PhongMoSo));
                Command.Parameters.Add(new MDB.MDBParameter("HoTenBenhNhan", bangKe.HoTenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("Tuoi", bangKe.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("GioiTinh", bangKe.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhAn", bangKe.MaBenhAn));
                Command.Parameters.Add(new MDB.MDBParameter("NgayPhauThuat", bangKe.NgayPhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("CachPhauThuat", bangKe.CachPhauThuat));
                Command.Parameters.Add(new MDB.MDBParameter("KTVGayMe", bangKe.KTVGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("BacSyGayMe", bangKe.BacSyGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("DVC", bangKe.DVC));

                string jsonBangKes = JsonConvert.SerializeObject(bangKe.VatTuGayMe);
                List<string> listJson = Common.SplitByLength(jsonBangKes, 3000).ToList();
                Command.Parameters.Add(new MDB.MDBParameter("ThuocGayMe_1", listJson[0]));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocGayMe_2", listJson.Count > 1 ? listJson[1] : null));
                Command.Parameters.Add(new MDB.MDBParameter("MaPhauThuatVien", bangKe.MaPhauThuatVien));
                Command.Parameters.Add(new MDB.MDBParameter("HoTenPhauThuatVien", bangKe.HoTenPhauThuatVien));
                Command.Parameters.Add(new MDB.MDBParameter("MaNVBacSyGayMe", bangKe.MaNVBacSyGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("HoTenBacSyGayMe", bangKe.HoTenBacSyGayMe));
                Command.Parameters.Add(new MDB.MDBParameter("MaNguoiLapBang", bangKe.MaNguoiLapBang));
                Command.Parameters.Add(new MDB.MDBParameter("HoTenNguoiLapBang", bangKe.HoTenNguoiLapBang));
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
                string sql = "DELETE FROM BangKeVTTHDTGayMe WHERE ID = :ID";
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
                B.KipPhauThuat, 
                B.So,
                B.Quyen, 
                B.Khoa, 
                B.PhongMoSo, 
                B.HoTenBenhNhan, 
                B.Tuoi,
                B.GioiTinh, 
                B.MaBenhAn,
                B.NgayPhauThuat,
                B.CachPhauThuat,
                B.BacSyGayMe, 
                B.KTVGayMe, 
                B.DVC

            FROM
                BangKeVTTHDTGayMe B
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "BK");
            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));
            //ds.Tables[0].AddColumn("GioiTinh", typeof(int));
            ds.Tables[0].AddColumn("GioiTinh", typeof(string));
            ds.Tables[0].AddColumn("SOYTE", typeof(string));
            ds.Tables[0].AddColumn("BENHVIEN", typeof(string));
            ds.Tables[0].AddColumn("KHOA", typeof(string));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            ds.Tables[0].Rows[0]["SOYTE"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["KHOA"] = XemBenhAn._ThongTinDieuTri.Khoa;

            sql = @"SELECT B.ThuocGayMe_1, B.ThuocGayMe_2
            FROM
                BangKeVTTHDTGayMe B
                
            WHERE
                ID = " + id;

            Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            ObservableCollection<ChiTietBVTTHDTGM> saveDatas = new ObservableCollection<ChiTietBVTTHDTGM>();
            while (DataReader.Read())
            {
                string bangKeJson = DataReader["ThuocGayMe_1"].ToString();
                if (DataReader["ThuocGayMe_1"] != DBNull.Value)
                    bangKeJson += DataReader["ThuocGayMe_2"].ToString();
                saveDatas = JsonConvert.DeserializeObject<ObservableCollection<ChiTietBVTTHDTGM>>(bangKeJson);
                break;
            }



            ds.Tables.Add(Common.ListToDataTable(saveDatas, "CT"));

            return ds;

        }
    }
}

