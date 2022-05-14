using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm.Native;
using DevExpress.XtraEditors.Filtering.Templates;
using EMR.KyDienTu;
using EMR_MAIN.ChucNangKhac;
using EMR_MAIN.Converter;
using MDB;
using Newtonsoft.Json;
using PMS.Access;

namespace EMR_MAIN.DATABASE.Other
{
    public class PXNDYXNHIV : ThongTinKy
    {
        public PXNDYXNHIV()
        {
            TableName = "PXNDYXNHIV";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PXNDYXNHIV;
            TenMauPhieu = DanhMucPhieu.PXNDYXNHIV.Description();
        }
        [MoTaDuLieu("Mã định danh")]
		public long ID { get; set; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau","",1)]
		public decimal MaQuanLy { get; set; }
        [MoTaDuLieu("Mã bệnh nhân")]
		public string MaBenhNhan { get; set; }
        [MoTaDuLieu("Mã khoa")]
		public string MaKhoa { get; set; }
        [MoTaDuLieu("Tên khoa")]
		public string TenKhoa { get; set; }
        [MoTaDuLieu("Mã giường")]
		public string MaGiuong { get; set; }
        [MoTaDuLieu("Giường")]
		public string Giuong { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChiHT { get; set; }
        public bool[] LoaiDT_Array { get; } = new bool[] { false, false , false, false , false, false , false, false , false, false , false};
        public string LoaiDT
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < LoaiDT_Array.Length; i++)
                    temp += (LoaiDT_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        LoaiDT_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        [MoTaDuLieu("Nghề nghiệp")]
		public string NgheNghiep { get; set; }
        public string LoaiDTKhac { get; set; }
        public DateTime NgayThucHien { get; set; }
        public string MaCBYT { get; set; }
        public string TenCBYT { get; set; }
        [MoTaDuLieu("Số chứng minh nhân dân")]
		public string CMND { get; set; }
        [MoTaDuLieu("Ngày sửa", null, 0, 0)]
		public DateTime NgaySua { get; set; }
        [MoTaDuLieu("Người sửa", null, 0, 0)]
		public string NguoiSua { get; set; }
        [MoTaDuLieu("Ngày tạo", null, 0, 0)]
		public DateTime NgayTao { get; set; }
        [MoTaDuLieu("Người tạo", null, 0, 0)]
		public string NguoiTao { get; set; }
        [MoTaDuLieu("Đã ký", null, 0, 0)]
		public bool DaKy { get; set; }
        [MoTaDuLieu("Chọn", null, 0, 0)]
		public bool Chon { get; set; }
        public string SoYTe
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.SoYTe;
            }
        }
        public string BenhVien
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.BenhVien;
            }
        }
        [MoTaDuLieu("Tuổi bệnh nhân")]
		public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh { get; set; }
        public string DienThoaiLienLac { get; set; }
        [MoTaDuLieu("Dân tộc")]
		public string DanToc { get; set; }
        [MoTaDuLieu("Năm sinh")]
		public string NamSinh { get; set; }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan { get; set; }
        public string SoVaoVien
        {
            get
            {
                return XemBenhAn._ThongTinDieuTri.SoNhapVien;
            }
        }
        public string MaBenhAn
        {
            get
            {
                return XemBenhAn._ThongTinDieuTri.MaBenhAn;
            }
        }
    }
    public class PXNDYXNHIVFunc
    {
        public const string TableName = "PXNDYXNHIV";
        public const string TablePrimaryKeyName = "ID";
        public static List<PXNDYXNHIV> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PXNDYXNHIV> list = new List<PXNDYXNHIV>();
            try
            {

                string sql = @"SELECT * FROM PXNDYXNHIV where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    try
                    {
                        PXNDYXNHIV data = new PXNDYXNHIV();
                        data.ID = DataReader.GetLong("ID");
                        data.MaQuanLy = Common.ConDB_Decimal(DataReader["MaQuanLy"]);
                        data.MaBenhNhan = Common.ConDBNull(DataReader["MABENHNHAN"]);
                        data.DiaChi = Common.ConDBNull(DataReader["DiaChi"]);
                        data.MaKhoa = Common.ConDBNull(DataReader["MaKhoa"]);
                        data.TenKhoa = Common.ConDBNull(DataReader["TenKhoa"]);
                        data.MaGiuong = Common.ConDBNull(DataReader["MaGiuong"]);
                        data.Giuong = Common.ConDBNull(DataReader["Giuong"]);
                        data.DiaChiHT = Common.ConDBNull(DataReader["DiaChiHT"]);
                        data.NgayThucHien = Common.ConDB_DateTime(DataReader["NgayThucHien"]);
                        data.LoaiDT = Common.ConDBNull(DataReader["LoaiDT"]);
                        data.NgheNghiep = Common.ConDBNull(DataReader["NgheNghiep"]);
                        data.LoaiDTKhac = Common.ConDBNull(DataReader["LoaiDTKhac"]);
                        data.MaCBYT = Common.ConDBNull(DataReader["MaCBYT"]);
                        data.TenCBYT = Common.ConDBNull(DataReader["TenCBYT"]);
                        data.CMND = Common.ConDBNull(DataReader["CMND"]);
                        data.Tuoi = Common.ConDBNull(DataReader["Tuoi"]);
                        data.GioiTinh = Common.ConDBNull(DataReader["GioiTinh"]);
                        data.DienThoaiLienLac = Common.ConDBNull(DataReader["DienThoaiLienLac"]);
                        data.DanToc = Common.ConDBNull(DataReader["DanToc"]);
                        data.NamSinh = Common.ConDBNull(DataReader["NamSinh"]);
                        data.TenBenhNhan = Common.ConDBNull(DataReader["TenBenhNhan"]);
                        data.NguoiTao = Common.ConDBNull(DataReader["NguoiTao"]);
                        data.NguoiSua = Common.ConDBNull(DataReader["NguoiSua"]);
                        data.NgayTao = Common.ConDB_DateTime(DataReader["NgayTao"]);
                        data.NgaySua = Common.ConDB_DateTime(DataReader["NgaySua"]);
                        data.NgayKy = Common.ConDB_DateTime(DataReader["NGAYKY"]);
                        data.ComputerKyTen = Common.ConDBNull(DataReader["COMPUTERKYTEN"]);
                        data.MaSoKy = Common.ConDBNull(DataReader["MASOKYTEN"]);
                        data.TenFileKy = Common.ConDBNull(DataReader["TENFILEKY"]);
                        data.UserNameKy = Common.ConDBNull(DataReader["USERNAMEKY"]);
                        data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;
                        list.Add(data);
                    }
                    catch (Exception ex)
                    {
                        MDB.ExceptionExtend.LogError(ex);
                    }
                }
                DataReader.Close();
                DataReader = null;
            }
            catch (Exception ex) { XuLyLoi.Handle(ex); }
            return list;
        }
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PXNDYXNHIV objData)
        {
            string sql;
            int n = 0;
            if (objData.ID == 0)
            {
                sql = @"INSERT INTO PXNDYXNHIV (
                                    maquanly,MaKhoa,TenKhoa,MaGiuong,Giuong,
                                    mabenhnhan,
                                    DiaChi,
                                    DiaChiHT,
                                    NgayThucHien,LoaiDT,
                                    NgheNghiep,LoaiDTKhac,MaCBYT,TenCBYT,CMND,Tuoi,GioiTinh,DienThoaiLienLac,DanToc,NamSinh,TenBenhNhan,
                                    NgayTao,
                                    NguoiTao,
                                    NgaySua,
                                    NguoiSua
                                ) VALUES (
                                    :maquanly,:MaKhoa,:TenKhoa,:MaGiuong,:Giuong,
                                    :mabenhnhan,
                                    :DiaChi,
                                    :DiaChiHT,
                                    :NgayThucHien,:LoaiDT,
                                    :NgheNghiep,:LoaiDTKhac,:MaCBYT,:TenCBYT,:CMND,:Tuoi,:GioiTinh,:DienThoaiLienLac,:DanToc,:NamSinh,:TenBenhNhan,
                                    :NgayTao,
                                    :NguoiTao,
                                    :NgaySua,
                                    :NguoiSua
                                ) RETURNING ID INTO :ID";
            }

            else
            {
                sql = @"UPDATE PXNDYXNHIV SET  
                                         maquanly = :maquanly,MaKhoa =:MaKhoa,TenKhoa =:TenKhoa,MaGiuong =:MaGiuong,Giuong =:Giuong,
                                         mabenhnhan = :mabenhnhan,
                                         DiaChi = :DiaChi,
                                         DiaChiHT = :DiaChiHT,
                                         NgayThucHien = :NgayThucHien, LoaiDT =:LoaiDT,
                                        NgheNghiep=:NgheNghiep,LoaiDTKhac=:LoaiDTKhac,MaCBYT=:MaCBYT,TenCBYT=:TenCBYT,CMND=:CMND,Tuoi =:Tuoi,GioiTinh =:GioiTinh,DienThoaiLienLac =:DienThoaiLienLac,DanToc =:DanToc,NamSinh =:NamSinh,TenBenhNhan =:TenBenhNhan,
                                         nguoisua = :nguoisua,
                                         ngaysua = :ngaysua 
                                        WHERE ID = :ID";

            }

            MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("maquanly", objData.MaQuanLy));
            Command.Parameters.Add(new MDB.MDBParameter("MaKhoa", objData.MaKhoa));
            Command.Parameters.Add(new MDB.MDBParameter("TenKhoa", objData.TenKhoa));
            Command.Parameters.Add(new MDB.MDBParameter("MaGiuong", objData.MaGiuong));
            Command.Parameters.Add(new MDB.MDBParameter("Giuong", objData.Giuong));
            Command.Parameters.Add(new MDB.MDBParameter("mabenhnhan", objData.MaBenhNhan));
            Command.Parameters.Add(new MDB.MDBParameter("DiaChi", objData.DiaChi));
            Command.Parameters.Add(new MDB.MDBParameter("DiaChiHT", objData.DiaChiHT));
            Command.Parameters.Add(new MDB.MDBParameter("NgayThucHien", objData.NgayThucHien));
            Command.Parameters.Add(new MDB.MDBParameter("LoaiDT", objData.LoaiDT));
            Command.Parameters.Add(new MDB.MDBParameter("NgheNghiep", objData.NgheNghiep));
            Command.Parameters.Add(new MDB.MDBParameter("LoaiDTKhac", objData.LoaiDTKhac));
            Command.Parameters.Add(new MDB.MDBParameter("MaCBYT", objData.MaCBYT));
            Command.Parameters.Add(new MDB.MDBParameter("TenCBYT", objData.TenCBYT));
            Command.Parameters.Add(new MDB.MDBParameter("CMND", objData.CMND));
            Command.Parameters.Add(new MDB.MDBParameter("Tuoi", objData.Tuoi));
            Command.Parameters.Add(new MDB.MDBParameter("GioiTinh", objData.GioiTinh));
            Command.Parameters.Add(new MDB.MDBParameter("DienThoaiLienLac", objData.DienThoaiLienLac));
            Command.Parameters.Add(new MDB.MDBParameter("DanToc", objData.DanToc));
            Command.Parameters.Add(new MDB.MDBParameter("NamSinh", objData.NamSinh));
            Command.Parameters.Add(new MDB.MDBParameter("TenBenhNhan", objData.TenBenhNhan));
            Command.Parameters.Add(new MDB.MDBParameter("nguoisua", Common.getUserLogin()));
            Command.Parameters.Add(new MDB.MDBParameter("ngaysua", DateTime.Now));
            Command.Parameters.Add(new MDB.MDBParameter("ID", objData.ID));
            if (objData.ID == 0)
            {
                Command.Parameters.Add(new MDB.MDBParameter("nguoitao", Common.getUserLogin()));
                Command.Parameters.Add(new MDB.MDBParameter("ngaytao", DateTime.Now));
            }
            Command.BindByName = true;
            n = Command.ExecuteNonQuery();
            if (n > 0)
            {
                if (objData.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    objData.ID = nextval;
                }
            }
            return n > 0 ? true : false;
        }

        public static bool Delete(MDB.MDBConnection MyConnection, decimal ID)
        {
            string sql = "DELETE FROM PXNDYXNHIV WHERE ID = :ID";
            MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
            command.Parameters.Add(new MDB.MDBParameter("ID", ID));
            command.BindByName = true;
            int n = command.ExecuteNonQuery();
            return n > 0 ? true : false;
        }
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, decimal ID)
        {
            string sql2 = @"SELECT D.*, '' SoNhapVien, '' MaBenhAn , '' SoVaoVien, '' SoYTe,
                        '' BENHVIEN
            FROM
                PXNDYXNHIV D
            WHERE
                ID = :ID";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql2, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("ID", ID));

            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            adt.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                ds.Tables[0].Rows[0]["SoNhapVien"] = XemBenhAn._ThongTinDieuTri.SoNhapVien;
                ds.Tables[0].Rows[0]["MaBenhAn"] = XemBenhAn._ThongTinDieuTri.MaBenhAn;
                ds.Tables[0].Rows[0]["SoVaoVien"] = XemBenhAn._ThongTinDieuTri.SoNhapVien;
                ds.Tables[0].Rows[0]["SoYTe"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
                ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            }
            return ds;
        }
    }
}
