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
    public class PSLDDNB : ThongTinKy
    {
        public PSLDDNB()
        {
            TableName = "PSLDDNB";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PSLDDNB;
            TenMauPhieu = DanhMucPhieu.PSLDDNB.Description();
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
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public double? CanNang { get; set; }
        public double? ChieuCao { get; set; }
        public double? BMI { get; set; }
        public DateTime NgayThucHien { get; set; }
        public int DG1 { get; set; }
        public int DG2 { get; set; }
        public int Diem_DG1
        {
            get
            {
                if (DG1 == 1)
                {
                    return 0;
                }
                else if (DG1 == 2)
                {
                    return 2;
                }
                else if (DG1 == 3)
                {
                    return 1;
                }
                else if (DG1 == 4)
                {
                    return 2;
                }
                else if (DG1 == 5)
                {
                    return 3;
                }
                else if (DG1 == 6)
                {
                    return 4;
                }
                else if (DG1 == 7)
                {
                    return 2;
                }
                return 0;
            }
        }

        public int Diem_DG2
        {
            get
            {
                if (DG2 == 1)
                {
                    return 0;
                }
                else if (DG2 == 2)
                {
                    return 1;
                }
                return 0;
            }
        }
        public int TongDiem { get; set; }
        public string MaNgTH { get; set; }
        public string TenNgTH { get; set; }
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
		public string Tuoi
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.Tuoi;
            }
        }
        [MoTaDuLieu("Giới tính bệnh nhân")]
		public string GioiTinh
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            }
        }
        public string SoVaoVien
        {
            get
            {
                return XemBenhAn._ThongTinDieuTri.SoNhapVien;
            }
        }
        [MoTaDuLieu("Họ và tên bệnh nhân")]
		public string TenBenhNhan
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
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
    public class PSLDDNBFunc
    {
        public const string TableName = "PSLDDNB";
        public const string TablePrimaryKeyName = "ID";
        public static List<PSLDDNB> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PSLDDNB> list = new List<PSLDDNB>();
            try
            {

                string sql = @"SELECT * FROM PSLDDNB where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    try
                    {
                        PSLDDNB data = new PSLDDNB();
                        data.ID = DataReader.GetLong("ID");
                        data.MaQuanLy = Common.ConDB_Decimal(DataReader["MaQuanLy"]);
                        data.MaBenhNhan = Common.ConDBNull(DataReader["MABENHNHAN"]);
                        data.ChanDoan = Common.ConDBNull(DataReader["ChanDoan"]);
                        data.MaKhoa = Common.ConDBNull(DataReader["MaKhoa"]);
                        data.TenKhoa = Common.ConDBNull(DataReader["TenKhoa"]);
                        data.MaGiuong = Common.ConDBNull(DataReader["MaGiuong"]);
                        data.Giuong = Common.ConDBNull(DataReader["Giuong"]);
                        data.NgayThucHien = Common.ConDB_DateTime(DataReader["NgayThucHien"]);
                         data.CanNang = Common.ConDBNull_double(DataReader["CanNang"]);
                        data.ChieuCao = Common.ConDBNull_double(DataReader["ChieuCao"]);
                        data.CanNang = Common.ConDBNull_double(DataReader["CanNang"]);
                        data.BMI = Common.ConDBNull_double(DataReader["BMI"]);
                        data.DG2 = Common.ConDB_Int(DataReader["DG2"]);
                        data.MaNgTH = Common.ConDBNull(DataReader["MaNgTH"]);
                        data.TenNgTH = Common.ConDBNull(DataReader["TenNgTH"]);
                        data.DG1 = Common.ConDB_Int(DataReader["DG1"]);
                        data.TongDiem = Common.ConDB_Int(DataReader["TongDiem"]);
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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PSLDDNB objData)
        {
            string sql;
            int n = 0;
            if (objData.ID == 0)
            {
                sql = @"INSERT INTO PSLDDNB (
                                    maquanly,MaKhoa,TenKhoa,MaGiuong,Giuong,
                                    mabenhnhan,
                                    ChanDoan,
                                    NgayThucHien,
                                    ChieuCao,CanNang,BMI,DG2,MaNgTH,TenNgTH,DG1,TongDiem,
                                    NgayTao,
                                    NguoiTao,
                                    NgaySua,
                                    NguoiSua
                                ) VALUES (
                                    :maquanly,:MaKhoa,:TenKhoa,:MaGiuong,:Giuong,
                                    :mabenhnhan,
                                    :ChanDoan,
                                    :NgayThucHien,
                                    :ChieuCao,:CanNang,:BMI,:DG2,:MaNgTH,:TenNgTH,:DG1,:TongDiem,
                                    :NgayTao,
                                    :NguoiTao,
                                    :NgaySua,
                                    :NguoiSua
                                ) RETURNING ID INTO :ID";
            }

            else
            {
                sql = @"UPDATE PSLDDNB SET  
                                         maquanly = :maquanly,MaKhoa =:MaKhoa,TenKhoa =:TenKhoa,MaGiuong =:MaGiuong,Giuong =:Giuong,
                                         mabenhnhan = :mabenhnhan,
                                         ChanDoan = :ChanDoan,
                                         NgayThucHien = :NgayThucHien,
                                        ChieuCao=:ChieuCao,CanNang=:CanNang,BMI=:BMI,DG2=:DG2,MaNgTH=:MaNgTH,TenNgTH=:TenNgTH,DG1=:DG1,TongDiem=:TongDiem,
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
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", objData.ChanDoan));
            Command.Parameters.Add(new MDB.MDBParameter("NgayThucHien", objData.NgayThucHien));
            Command.Parameters.Add(new MDB.MDBParameter("ChieuCao", objData.ChieuCao));
            Command.Parameters.Add(new MDB.MDBParameter("CanNang", objData.CanNang));
            Command.Parameters.Add(new MDB.MDBParameter("BMI", objData.BMI));
            Command.Parameters.Add(new MDB.MDBParameter("DG2", objData.DG2));
            Command.Parameters.Add(new MDB.MDBParameter("MaNgTH", objData.MaNgTH));
            Command.Parameters.Add(new MDB.MDBParameter("TenNgTH", objData.TenNgTH));
            Command.Parameters.Add(new MDB.MDBParameter("DG1", objData.DG1));
            Command.Parameters.Add(new MDB.MDBParameter("TongDiem", objData.TongDiem));
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
            string sql = "DELETE FROM PSLDDNB WHERE ID = :ID";
            MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
            command.Parameters.Add(new MDB.MDBParameter("ID", ID));
            command.BindByName = true;
            int n = command.ExecuteNonQuery();
            return n > 0 ? true : false;
        }
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, decimal ID)
        {
            string sql2 = @"SELECT D.*, '' SoNhapVien, '' MaBenhAn , '' SoVaoVien, '' TenBenhNhan,
                        '' TUOI, '' SoYTe, '' BENHVIEN,
                        '' GioiTinh,
                        (case D.DG1
                        when 1 then 0
                        when 2 then 2
                        when 3 then 1
                        when 4 then 2
                        when 5 then 3
                        when 6 then 4
                        when 7 then 2
                        else 0
                        end) Diem_DG1, 
                        (case D.DG2
                        when 1 then 0
                        when 2 then 1
                        else 0
                        end) Diem_DG2
            FROM
                PSLDDNB D
            WHERE
                ID = :ID";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql2, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("ID", ID));

            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            adt.Fill(ds);

            if (ds != null || ds.Tables[0].Rows.Count > 0)
            {
                ds.Tables[0].Rows[0]["SoNhapVien"] = XemBenhAn._ThongTinDieuTri.SoNhapVien;
                ds.Tables[0].Rows[0]["MaBenhAn"] = XemBenhAn._ThongTinDieuTri.MaBenhAn;
                ds.Tables[0].Rows[0]["SoVaoVien"] = XemBenhAn._ThongTinDieuTri.SoNhapVien;
                ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                ds.Tables[0].Rows[0]["TUOI"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                ds.Tables[0].Rows[0]["SoYTe"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
                ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
                ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
            }
            return ds;
        }
    }
}
