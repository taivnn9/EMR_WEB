using EMR.KyDienTu;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Data;

namespace EMR_MAIN.DATABASE.Other
{
    public class PhieuDKDaKeDaTrongSanhMo : ThongTinKy
    {
        public PhieuDKDaKeDaTrongSanhMo()
        {
            TableName = "PhieuDKDaKeDaTrongSanhMo";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PDKDKDTSM;
            TenMauPhieu = DanhMucPhieu.PDKDKDTSM.Description();
        }

        [MoTaDuLieu("Mã định danh")]
        public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau", "", 1)]
        public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Họ và tên sản phụ")]
        public string HoTenSanPhu { get; set; }
        [MoTaDuLieu("Sinh năm")]
        public string SinhNam { get; set; }
        [MoTaDuLieu("Số nhập viện")]
        public string SoNhapVien { get; set; }
        [MoTaDuLieu("Đại diện gia đình")]
        public string DDGD { get; set; }
        [MoTaDuLieu("Vai trò người đại diện gia đình")]
        public string DDGDRole { get; set; }
        [MoTaDuLieu("Đại diện gia đình ký tên")]
        public string DDGDKyTen { get; set; }
        [MoTaDuLieu("Đại diện gia đình ghi rõ họ tên")]
        public string DDGDKyTenDu { get; set; }
        [MoTaDuLieu("Sản phụ ký tên")]
        public string SanPhuKyTen { get; set; }
        [MoTaDuLieu("Sản phụ ghi rõ họ và tên")]
        public string SanPhuKyTenDu { get; set; }


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


    public class PhieuDKDaKeDaTrongSanhMoFunc
    {
        public const string TableName = "PhieuDKDaKeDaTrongSanhMo";
        public const string TablePrimaryKeyName = "ID";
        public static List<PhieuDKDaKeDaTrongSanhMo> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PhieuDKDaKeDaTrongSanhMo> list = new List<PhieuDKDaKeDaTrongSanhMo>();
            try
            {
                string sql = @"SELECT * FROM PhieuDKDaKeDaTrongSanhMo where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    PhieuDKDaKeDaTrongSanhMo data = new PhieuDKDaKeDaTrongSanhMo();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = maquanly;
                    data.HoTenSanPhu = DataReader["HoTenSanPhu"].ToString();
                    data.SinhNam = DataReader["SinhNam"].ToString();
                    data.SoNhapVien = DataReader["SoNhapVien"].ToString();
                    data.DDGD = DataReader["DDGD"].ToString();
                    data.DDGDRole = DataReader["DDGDRole"].ToString();
                    data.DDGDKyTen = DataReader["DDGDKyTen"].ToString();
                    data.DDGDKyTenDu = DataReader["DDGDKyTenDu"].ToString();
                    data.SanPhuKyTen = DataReader["SanPhuKyTen"].ToString();
                    data.SanPhuKyTenDu = DataReader["SanPhuKyTenDu"].ToString();

                    data.NguoiTao = DataReader["NguoiTao"].ToString();
                    data.NguoiSua = DataReader["NguoiSua"].ToString();
                    data.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                    data.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);

                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;
                    list.Add(data);
                }
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PhieuDKDaKeDaTrongSanhMo data)
        {
            try
            {
                string sql = @"INSERT INTO PhieuDKDaKeDaTrongSanhMo
                (
                    MaQuanLy,
                    HoTenSanPhu,
                    SinhNam,
                    SoNhapVien,
                    DDGD,
                    DDGDRole,
                    DDGDKyTen,
                    DDGDKyTenDu,
                    SanPhuKyTen,
                    SanPhuKyTenDu,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :MaQuanLy,
                    :HoTenSanPhu,
                    :SinhNam,
                    :SoNhapVien,
                    :DDGD,
                    :DDGDRole,
                    :DDGDKyTen,
                    :DDGDKyTenDu,
                    :SanPhuKyTen,
                    :SanPhuKyTenDu,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (data.ID != 0)
                {
                    sql = @"UPDATE PhieuDKDaKeDaTrongSanhMo SET 
                    MaQuanLy=:MaQuanLy,
                    HoTenSanPhu:HoTenSanPhu,
                    SinhNam:SinhNam,
                    SoNhapVien:SoNhapVien,
                    DDGD:DDGD,
                    DDGDRole:DDGDRole,
                    DDGDKyTen:DDGDKyTen,
                    DDGDKyTenDu:DDGDKyTenDu,
                    SanPhuKyTen:SanPhuKyTen,
                    SanPhuKyTenDu:SanPhuKyTenDu,
                    NGUOITAO=:NGUOITAO,
                    NGUOISUA=:NGUOISUA,
                    NGAYTAO=:NGAYTAO,
                    NGAYSUA=:NGAYSUA 
                    WHERE ID = " + data.ID;
                }

                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", data.MaQuanLy));
                Command.Parameters.Add(new MDB.MDBParameter("HoTenSanPhu", data.HoTenSanPhu));
                Command.Parameters.Add(new MDB.MDBParameter("SinhNam", data.SinhNam));
                Command.Parameters.Add(new MDB.MDBParameter("SoNhapVien", data.SoNhapVien));
                Command.Parameters.Add(new MDB.MDBParameter("DDGD", data.DDGD));
                Command.Parameters.Add(new MDB.MDBParameter("DDGDRole", data.DDGDRole));
                Command.Parameters.Add(new MDB.MDBParameter("DDGDKyTen", data.DDGDKyTen));
                Command.Parameters.Add(new MDB.MDBParameter("DDGDKyTenDu", data.DDGDKyTenDu));
                Command.Parameters.Add(new MDB.MDBParameter("SanPhuKyTen", data.SanPhuKyTen));
                Command.Parameters.Add(new MDB.MDBParameter("SanPhuKyTenDu", data.SanPhuKyTenDu));

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
                string sql = "DELETE FROM PhieuDKDaKeDaTrongSanhMo WHERE ID = :ID";
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
                PhieuDKDaKeDaTrongSanhMo B
            WHERE
                ID = " + id;
            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.BindByName = true;
            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();

            adt.Fill(ds, "PDK");
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