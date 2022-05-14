using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;


namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuTVPTMoLayThai : ThongTinKy
    {
        public PhieuTVPTMoLayThai()
        {
            TableName = "PhieuTVPTMoLayThai";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PTVPTMLT;
            TenMauPhieu = DanhMucPhieu.PTVPTMLT.Description();
        }

        [MoTaDuLieu("Mã định danh")]
        public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau", "", 1)]
        public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Họ tên bệnh nhân")]
        public string HoTenBenhNhan { get; set; }
        [MoTaDuLieu("Họ tên người đại diện")]
        public string HoTenNguoiDaiDien { get; set; }
        [MoTaDuLieu("Quan hệ người đại diện")]
        public string QuanHeNguoiDaiDien { get; set; }
        [MoTaDuLieu("Bác sĩ")]
        public string BacSi { get; set; }
        [MoTaDuLieu("Họ tên bệnh nhân ở mục không thể tự quyết")]
        public string HoTenBenhNhanTuyChon { get; set; }
        [MoTaDuLieu("Lý do không tự quyết định ở mục không thể tự quyết")]
        public string LyDoKhongQuyetDinhTuyChon { get; set; }
        [MoTaDuLieu("Người đại diện hợp pháp ở mục không thể tự quyết")]
        public string NguoiDDHPTuyChon { get; set; }
        [MoTaDuLieu("Quan hệ với bệnh nhân ở mục không thể tự quyết")]
        public string QuanHeVoiBenhNhanTuyChon { get; set; }

        [MoTaDuLieu("Ngày ký ở mục không thể tự quyết")]
        public DateTime NgayKyTuyChon { get; set; }

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

        public bool Chon { get; set; }

    }


    public class PhieuTVPTMoLayThaiFunc
    {
        public const string TableName = "PhieuTVPTMoLayThai";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuTVPTMoLayThai> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuTVPTMoLayThai> list = new List<PhieuTVPTMoLayThai>();
            try
            {
                string sql = @"SELECT * FROM PhieuTVPTMoLayThai where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuTVPTMoLayThai data = new PhieuTVPTMoLayThai();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.HoTenBenhNhan = DataReader["HOTENBENHNHAN"].ToString();
                    data.HoTenNguoiDaiDien = DataReader["HOTENNGUOIDAIDIEN"].ToString();
                    data.QuanHeNguoiDaiDien = DataReader["QUANHENGUOIDAIDIEN"].ToString();
                    data.BacSi = DataReader["BACSI"].ToString();
                    data.HoTenBenhNhanTuyChon = DataReader["HOTENBENHNHANTUYCHON"].ToString();
                    data.LyDoKhongQuyetDinhTuyChon = DataReader["LYDOKHONGQUYETDINHTUYCHON"].ToString();
                    data.NguoiDDHPTuyChon= DataReader["NGUOIDDHPTUYCHON"].ToString();
                    data.QuanHeVoiBenhNhanTuyChon = DataReader["QUANHEVOIBENHNHANTUYCHON"].ToString();
                    data.NgayKyTuyChon= Convert.ToDateTime(DataReader["NGAYKYTUYCHON"] == DBNull.Value ? DateTime.Now : DataReader["NGAYKYTUYCHON"]);
                    data.NguoiTao = DataReader["NGUOITAO"].ToString();
                    data.NguoiSua = DataReader["NGUOISUA"].ToString();
                    data.NgayTao = Convert.ToDateTime(DataReader["NGAYTAO"] == DBNull.Value ? DateTime.Now : DataReader["NGAYTAO"]);
                    data.NgaySua = Convert.ToDateTime(DataReader["NGAYSUA"] == DBNull.Value ? DateTime.Now : DataReader["NGAYSUA"]);

                    data.MaSoKy = DataReader["MASOKYTEN"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;
                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuTVPTMoLayThai data)
        {
            try
            {
                string sql = @"INSERT INTO PhieuTVPTMoLayThai
                (
                    MaQuanLy,
                    HoTenBenhNhan,
                    HoTenNguoiDaiDien,
                    QuanHeNguoiDaiDien,
                    BacSi,
                    HoTenBenhNhanTuyChon,
                    LyDoKhongQuyetDinhTuyChon,
                    NguoiDDHPTuyChon,
                    QuanHeVoiBenhNhanTuyChon,
                    NgayKyTuyChon,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
                    :HoTenBenhNhan,
                    :HoTenNguoiDaiDien,
                    :QuanHeNguoiDaiDien,
                    :BacSi,
                    :HoTenBenhNhanTuyChon,
                    :LyDoKhongQuyetDinhTuyChon,
                    :NguoiDDHPTuyChon,
                    :QuanHeVoiBenhNhanTuyChon,
                    :NgayKyTuyChon,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (data.ID != 0)
                {
                    sql = @"UPDATE PhieuTVPTMoLayThai SET 
                    MaQuanLy=:MaQuanLy,
                    HoTenBenhNhan:HoTenBenhNhan,
                    HoTenNguoiDaiDien:HoTenNguoiDaiDien,
                    QuanHeNguoiDaiDien:QuanHeNguoiDaiDien,
                    BacSi:BacSi,
                    HoTenBenhNhanTuyChon:HoTenBenhNhanTuyChon,
                    LyDoKhongQuyetDinhTuyChon:LyDoKhongQuyetDinhTuyChon,
                    NguoiDDHPTuyChon:NguoiDDHPTuyChon,
                    QuanHeVoiBenhNhanTuyChon:QuanHeVoiBenhNhanTuyChon,
                    NgayKyTuyChon:NgayKyTuyChon,
                    NGUOITAO=:NGUOITAO,
                    NGUOISUA=:NGUOISUA,
                    NGAYTAO=:NGAYTAO,
                    NGAYSUA=:NGAYSUA 
                    WHERE ID = " + data.ID;
                }

                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", data.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("HoTenBenhNhan", data.HoTenBenhNhan));
                Command.Parameters.Add(new MDB.MDBParameter("HoTenNguoiDaiDien", data.HoTenNguoiDaiDien));
                Command.Parameters.Add(new MDB.MDBParameter("QuanHeNguoiDaiDien", data.QuanHeNguoiDaiDien));
                Command.Parameters.Add(new MDB.MDBParameter("BacSi", data.BacSi));
                Command.Parameters.Add(new MDB.MDBParameter("HoTenBenhNhanTuyChon", data.HoTenBenhNhanTuyChon));
                Command.Parameters.Add(new MDB.MDBParameter("LyDoKhongQuyetDinhTuyChon", data.LyDoKhongQuyetDinhTuyChon));
                Command.Parameters.Add(new MDB.MDBParameter("NguoiDDHPTuyChon", data.NguoiDDHPTuyChon));
                Command.Parameters.Add(new MDB.MDBParameter("QuanHeVoiBenhNhanTuyChon", data.QuanHeVoiBenhNhanTuyChon));
                Command.Parameters.Add(new MDB.MDBParameter("NgayKyTuyChon", data.NgayKyTuyChon));

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", data.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", data.NgaySua));
                if (data.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", data.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", data.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", data.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (data.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    data.ID = nextval;
                }
                return n > 0;
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
                string sql = "DELETE FROM PhieuTVPTMoLayThai WHERE ID = :ID";
                MDB.MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
                command.Parameters.Add(new MDB.MDBParameter("ID", id));
                command.BindByName = true;
                return command.ExecuteNonQuery() > 0;
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
                PhieuTVPTMoLayThai B
            WHERE
                ID = " + id;
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.BindByName = true;
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "PTV");
            //if (ds != null || ds.Tables[0].Rows.Count > 0)
            //{
            //    ds.Tables[0].Rows[0]["SoYTe"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
            //    ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            //    ds.Tables[0].Rows[0]["Khoa"] = XemBenhAn._ThongTinDieuTri.Khoa;
            //    ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
            //    ds.Tables[0].Rows[0]["TUOI"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
            //    ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            //    ds.Tables[0].Rows[0]["MaBenhAn"] = XemBenhAn._ThongTinDieuTri.MaBenhAn;
            //    ds.Tables[0].Rows[0]["MaBenhNhan"] = XemBenhAn._ThongTinDieuTri.MaBenhNhan;
            //    ds.Tables[0].Rows[0]["ChanDoan"] = XemBenhAn._ThongTinDieuTri.ChanDoanTruocPhauThuat;
            //}
            return ds;
        }
    }
}
