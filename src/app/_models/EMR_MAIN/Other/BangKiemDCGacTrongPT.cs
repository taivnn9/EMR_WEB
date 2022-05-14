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
    public class ChiTietBKDCGTPT // set lại binding đoạn này lên giao diện file xaml nhé
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
       
    }
    public class BangKiemDCGacTrongPT : ThongTinKy
    {
        public BangKiemDCGacTrongPT()
        {
            // tên bảng dài quá, tên bảng dưới 27 ký tự
            TableName = "BangKiemDCGacTrongPT";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BKDCGTPT;
            TenMauPhieu = DanhMucPhieu.BKDCGTPT.Description();
        }
        [MoTaDuLieu("Mã định danh")]
        public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau", "", 1)]
        public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
        public string MaBenhNhan { get; set; }

        [MoTaDuLieu("Họ tên bệnh nhân")]
        public string HoTenBenhNhan { get; set; }
        [MoTaDuLieu("Tuổi bệnh nhân")]
        public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính")]
        public string GioiTinh { get; set; }
        [MoTaDuLieu("Khoa")]
        public string Khoa { get; set; }
        [MoTaDuLieu("Số bệnh án = mã bệnh án")]
        public string SoBA { get; set; }
        [MoTaDuLieu("Ngày mổ Bệnh nhân")]
        public DateTime? NgayMo { get; set; }
        [MoTaDuLieu("Phương pháp phẫu thuật")]
        public string PPPhauThuat { get; set; }
        [MoTaDuLieu("Chẩn đoán trước mổ")]
        public string ChanDoanTruocMo { get; set; }
        [MoTaDuLieu("Chẩn đoán sau mổ")]
        public string ChanDoanSauMo { get; set; }
        [MoTaDuLieu("Phẫu thuật viên")]
        public string PhauThuatVien { get; set; }
        [MoTaDuLieu("Dụng cụ viên")]
        public string DungCuVien { get; set; }

        // bảng dụng cụ
        public ObservableCollection<ChiTietBKDCGTPT> ThuocVatTus { get; set; }
        [MoTaDuLieu("kết luận ")]
        public string KetLuan { get; set; }

        // phần bắt buộc có
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
    public class BangKiemDCGacTrongPTFunc
    {
        public const string TableName = "BangKiemDCGacTrongPT";
        public const string TablePrimaryKeyName = "ID";
        public static List<BangKiemDCGacTrongPT> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BangKiemDCGacTrongPT> list = new List<BangKiemDCGacTrongPT>();
            try
            {
                string sql = @"SELECT * FROM BangKiemDCGacTrongPT where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    BangKiemDCGacTrongPT data = new BangKiemDCGacTrongPT();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();

                 
                    data.HoTenBenhNhan = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = DataReader["Tuoi"].ToString();
                    data.GioiTinh = DataReader["GioiTinh"].ToString();
                   
                    data.Khoa = DataReader["Khoa"].ToString();
                    data.SoBA = XemBenhAn._ThongTinDieuTri.MaBenhAn;

                    data.NgayMo = Convert.ToDateTime(DataReader["NgayMo"] == DBNull.Value ? DateTime.Now : DataReader["NgayMo"]);
                    data.PPPhauThuat = DataReader["PPPhauThuat"].ToString();
                    data.ChanDoanTruocMo = DataReader["ChanDoanTruocMo"].ToString();
                    data.ChanDoanSauMo = DataReader["ChanDoanSauMo"].ToString();
                    data.PhauThuatVien = DataReader["PhauThuatVien"].ToString();
                    data.DungCuVien = DataReader["DungCuVien"].ToString();


                    string bangKeJson = DataReader["ThuocGayMe_1"].ToString();
                    if (DataReader["ThuocGayMe_2"] != DBNull.Value)
                        bangKeJson += DataReader["ThuocGayMe_2"].ToString();
                    data.ThuocVatTus = JsonConvert.DeserializeObject<ObservableCollection<ChiTietBKDCGTPT>>(bangKeJson);

                    data.KetLuan = DataReader["KetLuan"].ToString();


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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BangKiemDCGacTrongPT bangKe)
        {
            try
            {
                string sql = @"INSERT INTO BangKiemDCGacTrongPT
                (
                    MAQUANLY,
                    MaBenhNhan,
                    HoTenBenhNhan,
                    Tuoi,
                    GioiTinh,
                    Khoa,
                    SoBA,
                    NgayMo,
                    PPPhauThuat,
                    ChanDoanTruocMo,
                    ChanDoanSauMo, 
                    PhauThuatVien,
                    DungCuVien,
                    ThuocGayMe_1,
                    ThuocGayMe_2,
                    KetLuan,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (  :MAQUANLY,
                    :MaBenhNhan,
                    :HoTenBenhNhan,
                    :Tuoi,
                    :GioiTinh,
                    :Khoa,
                    :SoBA,
                    :NgayMo,
                    :PPPhauThuat,
                    :ChanDoanTruocMo,
                    :ChanDoanSauMo, 
                    :PhauThuatVien,
                    :DungCuVien,
                    :ThuocGayMe_1,
                    :ThuocGayMe_2,
                    :KetLuan,  
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (bangKe.ID != 0)
                {
                    sql = @"UPDATE BangKiemDCGacTrongPT SET 
                    MAQUANLY = :MAQUANLY,
                    MaBenhNhan = :MaBenhNhan,                     
                    HoTenBenhNhan = :HoTenBenhNhan,
                    Tuoi = :Tuoi,
                    GioiTinh = :GioiTinh,
                    Khoa = :Khoa,
                    SoBA = :SoBA,
                    NgayMo = :NgayMo,
                    PPPhauThuat = :PPPhauThuat,
                    ChanDoanTruocMo = :ChanDoanTruocMo,
                    ChanDoanSauMo = :ChanDoanSauMo, 
                    PhauThuatVien = :PhauThuatVien,
                    DungCuVien = :DungCuVien,
                    ThuocGayMe_1 = :ThuocGayMe_1,
                    ThuocGayMe_2 = :ThuocGayMe_2,
                    KetLuan = :KetLuan,                                    
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + bangKe.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MAQUANLY", bangKe.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", bangKe.MaBenhNhan));

                Command.Parameters.Add(new MDB.MDBParameter("HoTenBenhNhan", bangKe.HoTenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("Tuoi", bangKe.Tuoi));
                Command.Parameters.Add(new MDB.MDBParameter("GioiTinh", bangKe.GioiTinh));
                Command.Parameters.Add(new MDB.MDBParameter("Khoa", bangKe.Khoa));
                Command.Parameters.Add(new MDB.MDBParameter("SoBA", bangKe.SoBA));

                Command.Parameters.Add(new MDB.MDBParameter("NgayMo", bangKe.NgayMo));
                Command.Parameters.Add(new MDB.MDBParameter("PPPhauThuat", bangKe.PPPhauThuat));

                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanTruocMo", bangKe.ChanDoanTruocMo));
                Command.Parameters.Add(new MDB.MDBParameter("ChanDoanSauMo", bangKe.ChanDoanSauMo));
                Command.Parameters.Add(new MDB.MDBParameter("PhauThuatVien", bangKe.PhauThuatVien));
                Command.Parameters.Add(new MDB.MDBParameter("DungCuVien", bangKe.DungCuVien));

                string jsonBangKes = JsonConvert.SerializeObject(bangKe.ThuocVatTus);
                List<string> listJson = Common.SplitByLength(jsonBangKes, 3999).ToList();
                Command.Parameters.Add(new MDB.MDBParameter("ThuocGayMe_1", listJson[0]));
                Command.Parameters.Add(new MDB.MDBParameter("ThuocGayMe_2", listJson.Count > 1 ? listJson[1] : null));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", bangKe.NgaySua));
                

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", bangKe.NgaySua));
                Command.Parameters.Add(new MDB.MDBParameter("KetLuan", bangKe.KetLuan));

                
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
                string sql = "DELETE FROM BangKiemDCGacTrongPT WHERE ID = :ID"; 
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
                B.HoTenBenhNhan,  
                B.Tuoi,  
                B.Khoa,  
                B.SoBA,  
                B.NgayMo,  
                B.PPPhauThuat,  
                B.ChanDoanTruocMo,
                B.ChanDoanSauMo,                  
                B.PhauThuatVien,                
                B.DungCuVien,
                B.KetLuan,
                B.NguoiSua
            FROM
                BangKiemDCGacTrongPT B
            WHERE
                ID = " + id;

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "BK");
            ds.Tables[0].AddColumn("TenBenhNhan", typeof(string));
            ds.Tables[0].AddColumn("Tuoi", typeof(string));
            ds.Tables[0].AddColumn("GioiTinh", typeof(int));
            ds.Tables[0].AddColumn("SOYTE", typeof(string));
            ds.Tables[0].AddColumn("BENHVIEN", typeof(string));
            ds.Tables[0].AddColumn("KHOA", typeof(string));

            ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            ds.Tables[0].Rows[0]["Tuoi"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            ds.Tables[0].Rows[0]["GioiTinh"] = (int)XemBenhAn._HanhChinhBenhNhan.GioiTinh;
            ds.Tables[0].Rows[0]["SOYTE"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            ds.Tables[0].Rows[0]["KHOA"] = XemBenhAn._ThongTinDieuTri.Khoa;

            sql = @"SELECT B.ThuocGayMe_1, B.ThuocGayMe_2
            FROM
                BangKiemDCGacTrongPT B
                
            WHERE
                ID = " + id;

            Command = new MDB.MDBCommand(sql, MyConnection);
            MDB.MDBDataReader DataReader = Command.ExecuteReader();

            ObservableCollection<ChiTietBKDCGTPT> saveDatas = new ObservableCollection<ChiTietBKDCGTPT>();
            while (DataReader.Read())
            {
                string bangKeJson = DataReader["ThuocGayMe_1"].ToString();
                if (DataReader["ThuocGayMe_1"] != DBNull.Value)
                    bangKeJson += DataReader["ThuocGayMe_2"].ToString();
                saveDatas = JsonConvert.DeserializeObject<ObservableCollection<ChiTietBKDCGTPT>>(bangKeJson);
                break;
            }

            ds.Tables.Add(Common.ListToDataTable(saveDatas, "CT"));

            return ds;

        }
    }
}
