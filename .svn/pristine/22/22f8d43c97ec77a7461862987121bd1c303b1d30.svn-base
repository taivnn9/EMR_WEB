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
    public class PDCNHH : ThongTinKy
    {
        public PDCNHH()
        {
            TableName = "PDCNHH";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PDCNHH;
            TenMauPhieu = DanhMucPhieu.PDCNHH.Description();
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
        [MoTaDuLieu("Buồng")]
		public string Buong { get; set; }
        [MoTaDuLieu("Địa chỉ nhà bệnh nhân")]
		public string DiaChi { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        [MoTaDuLieu("Chiều cao")]
		public string ChieuCao { get; set; }
        [MoTaDuLieu("Cân nặng")]
		public string CanNang { get; set; }
        public string KetLuan { get; set; }
        public string DuKien1 { get; set; }
        public string DuKien2 { get; set; }
        public string DuKien3 { get; set; }
        public string DuKien4 { get; set; }
        public string DuKien5 { get; set; }
        public string DuKien6 { get; set; }
        public string ThucTe1 { get; set; }
        public string ThucTe2 { get; set; }
        public string ThucTe3 { get; set; }
        public string ThucTe4 { get; set; }
        public string ThucTe5 { get; set; }
        public string ThucTe6 { get; set; }
        public string TyLe1 { get; set; }
        public string TyLe2 { get; set; }
        public string TyLe3 { get; set; }
        public string TyLe4 { get; set; }
        public string TyLe5 { get; set; }
        public string TyLe6 { get; set; }
        [MoTaDuLieu("Bác sỹ điều trị")]
		public string BacSyDieuTri { get; set; }
        [MoTaDuLieu("Mã bác sỹ điều trị")]
		public string MaBacSyDieuTri { get; set; }
        public string MaChuyenKhoa { get; set; }
        public string ChuyenKhoa { get; set; }
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
    public class PDCNHHFunc
    {
        public const string TableName = "PDCNHH";
        public const string TablePrimaryKeyName = "ID";
        public static List<PDCNHH> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PDCNHH> list = new List<PDCNHH>();
            try
            {

                string sql = @"SELECT * FROM PDCNHH where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    try
                    {
                        PDCNHH data = new PDCNHH();
                        data.ID = DataReader.GetLong("ID");
                        data.MaQuanLy = Common.ConDB_Decimal(DataReader["MaQuanLy"]);
                        data.MaBenhNhan = Common.ConDBNull(DataReader["MABENHNHAN"]);
                        data.MaKhoa = Common.ConDBNull(DataReader["MaKhoa"]);
                        data.TenKhoa = Common.ConDBNull(DataReader["TenKhoa"]);
                        data.MaGiuong = Common.ConDBNull(DataReader["MaGiuong"]);
                        data.Giuong = Common.ConDBNull(DataReader["Giuong"]);
                        data.Buong = Common.ConDBNull(DataReader["Buong"]);
                        data.DiaChi = Common.ConDBNull(DataReader["DiaChi"]);
                        data.ChanDoan = Common.ConDBNull(DataReader["ChanDoan"]);
                        data.CanNang = Common.ConDBNull(DataReader["CanNang"]);
                        data.ChieuCao = Common.ConDBNull(DataReader["ChieuCao"]);
                        data.KetLuan = Common.ConDBNull(DataReader["KetLuan"]);
                        data.DuKien1 = Common.ConDBNull(DataReader["DuKien1"]);
                        data.DuKien2 = Common.ConDBNull(DataReader["DuKien2"]);
                        data.DuKien3 = Common.ConDBNull(DataReader["DuKien3"]);
                        data.DuKien4 = Common.ConDBNull(DataReader["DuKien4"]);
                        data.DuKien5 = Common.ConDBNull(DataReader["DuKien5"]);
                        data.DuKien6 = Common.ConDBNull(DataReader["DuKien6"]);
                        data.ThucTe1 = Common.ConDBNull(DataReader["ThucTe1"]);
                        data.ThucTe2 = Common.ConDBNull(DataReader["ThucTe2"]);
                        data.ThucTe3 = Common.ConDBNull(DataReader["ThucTe3"]);
                        data.ThucTe4 = Common.ConDBNull(DataReader["ThucTe4"]);
                        data.ThucTe5 = Common.ConDBNull(DataReader["ThucTe5"]);
                        data.ThucTe6 = Common.ConDBNull(DataReader["ThucTe6"]);
                        data.TyLe1 = Common.ConDBNull(DataReader["TyLe1"]);
                        data.TyLe2 = Common.ConDBNull(DataReader["TyLe2"]);
                        data.TyLe3 = Common.ConDBNull(DataReader["TyLe3"]);
                        data.TyLe4 = Common.ConDBNull(DataReader["TyLe4"]);
                        data.TyLe5 = Common.ConDBNull(DataReader["TyLe5"]);
                        data.TyLe6 = Common.ConDBNull(DataReader["TyLe6"]);
                        data.MaChuyenKhoa = Common.ConDBNull(DataReader["MaChuyenKhoa"]);
                        data.ChuyenKhoa = Common.ConDBNull(DataReader["ChuyenKhoa"]);
                        data.NguoiTao = Common.ConDBNull(DataReader["NguoiTao"]);
                        data.NguoiSua = Common.ConDBNull(DataReader["NguoiSua"]);
                        data.NgayTao = Common.ConDB_DateTime(DataReader["NgayTao"]);
                        data.NgaySua = Common.ConDB_DateTime(DataReader["NgaySua"]);
                        data.NgayKy = Common.ConDB_DateTime(DataReader["NGAYKY"]);
                        data.ComputerKyTen = Common.ConDBNull(DataReader["COMPUTERKYTEN"]);
                        data.MaSoKy = Common.ConDBNull(DataReader["MASOKYTEN"]);
                        data.TenFileKy = Common.ConDBNull(DataReader["TENFILEKY"]);
                        data.UserNameKy = Common.ConDBNull(DataReader["USERNAMEKY"]);
                        data.BacSyDieuTri = Common.ConDBNull(DataReader["BacSyDieuTri"]);
                        data.MaBacSyDieuTri = Common.ConDBNull(DataReader["MaBacSyDieuTri"]);
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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PDCNHH objData)
        {
            string sql;
            int n = 0;
            if (objData.ID == 0)
            {
                sql = @"INSERT INTO PDCNHH (
                                    maquanly,MaKhoa,TenKhoa,MaGiuong,Giuong,Buong,
                                    mabenhnhan,
                                    DiaChi,
                                    ChanDoan,
                                    CanNang,
                                    ChieuCao,MaChuyenKhoa,ChuyenKhoa,KetLuan,
                                    DuKien1,DuKien2,DuKien3,DuKien4, DuKien5, DuKien6,
                                    ThucTe1,ThucTe2,ThucTe3,ThucTe4, ThucTe5, ThucTe6,
                                    TyLe1,TyLe2,TyLe3,TyLe4, TyLe5, TyLe6,
                                    BacSyDieuTri,MaBacSyDieuTri,
                                    NgayTao,
                                    NguoiTao,
                                    NgaySua,
                                    NguoiSua
                                ) VALUES (
                                    :maquanly,:MaKhoa,:TenKhoa,:MaGiuong,:Giuong,:Buong,
                                    :mabenhnhan,
                                    :DiaChi,
                                    :ChanDoan,
                                    :CanNang,
                                    :ChieuCao,:MaChuyenKhoa,:ChuyenKhoa,:KetLuan,
                                    :DuKien1,:DuKien2,:DuKien3,:DuKien4, :DuKien5, :DuKien6,
                                    :ThucTe1,:ThucTe2,:ThucTe3,:ThucTe4, :ThucTe5, :ThucTe6,
                                    :TyLe1,:TyLe2,:TyLe3,:TyLe4, :TyLe5, :TyLe6,
                                    :BacSyDieuTri,:MaBacSyDieuTri,
                                    :NgayTao,
                                    :NguoiTao,
                                    :NgaySua,
                                    :NguoiSua
                                ) RETURNING ID INTO :ID";
            }

            else
            {
                sql = @"UPDATE PDCNHH SET  
                                         maquanly = :maquanly,MaKhoa =:MaKhoa,TenKhoa =:TenKhoa,MaGiuong =:MaGiuong,Giuong =:Giuong,Buong =:Buong,
                                         mabenhnhan = :mabenhnhan,
                                         DiaChi = :DiaChi,
                                         ChanDoan = :ChanDoan,
                                         CanNang = :CanNang,
                                         ChieuCao=:ChieuCao,MaChuyenKhoa=:MaChuyenKhoa,ChuyenKhoa=:ChuyenKhoa,KetLuan=:KetLuan,
                                         DuKien1=:DuKien1,DuKien2=:DuKien2,DuKien3=:DuKien3,DuKien4=:DuKien4,DuKien5=:DuKien5,DuKien6=:DuKien6,
                                         ThucTe1=:ThucTe1,ThucTe2=:ThucTe2,ThucTe3=:ThucTe3,ThucTe4=:ThucTe4,ThucTe5=:ThucTe5,ThucTe6=:ThucTe6,
                                         TyLe1=:TyLe1,TyLe2=:TyLe2,TyLe3=:TyLe3,TyLe4=:TyLe4,TyLe5=:TyLe5,TyLe6=:TyLe6,
                                         BacSyDieuTri=:BacSyDieuTri,MaBacSyDieuTri=:MaBacSyDieuTri,
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
            Command.Parameters.Add(new MDB.MDBParameter("Buong", objData.Buong));
            Command.Parameters.Add(new MDB.MDBParameter("mabenhnhan", objData.MaBenhNhan));
            Command.Parameters.Add(new MDB.MDBParameter("DiaChi", objData.DiaChi));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", objData.ChanDoan));
            Command.Parameters.Add(new MDB.MDBParameter("CanNang", objData.CanNang));
            Command.Parameters.Add(new MDB.MDBParameter("ChieuCao", objData.ChieuCao));
            Command.Parameters.Add(new MDB.MDBParameter("KetLuan", objData.KetLuan));
            Command.Parameters.Add(new MDB.MDBParameter("DuKien1", objData.DuKien1));
            Command.Parameters.Add(new MDB.MDBParameter("DuKien2", objData.DuKien2));
            Command.Parameters.Add(new MDB.MDBParameter("DuKien3", objData.DuKien3));
            Command.Parameters.Add(new MDB.MDBParameter("DuKien4", objData.DuKien4));
            Command.Parameters.Add(new MDB.MDBParameter("DuKien5", objData.DuKien5));
            Command.Parameters.Add(new MDB.MDBParameter("DuKien6", objData.DuKien6));
            Command.Parameters.Add(new MDB.MDBParameter("ThucTe1", objData.ThucTe1));
            Command.Parameters.Add(new MDB.MDBParameter("ThucTe2", objData.ThucTe2));
            Command.Parameters.Add(new MDB.MDBParameter("ThucTe3", objData.ThucTe3));
            Command.Parameters.Add(new MDB.MDBParameter("ThucTe4", objData.ThucTe4));
            Command.Parameters.Add(new MDB.MDBParameter("ThucTe5", objData.ThucTe5));
            Command.Parameters.Add(new MDB.MDBParameter("ThucTe6", objData.ThucTe6));
            Command.Parameters.Add(new MDB.MDBParameter("TyLe1", objData.TyLe1));
            Command.Parameters.Add(new MDB.MDBParameter("TyLe2", objData.TyLe2));
            Command.Parameters.Add(new MDB.MDBParameter("TyLe3", objData.TyLe3));
            Command.Parameters.Add(new MDB.MDBParameter("TyLe4", objData.TyLe4));
            Command.Parameters.Add(new MDB.MDBParameter("TyLe5", objData.TyLe5));
            Command.Parameters.Add(new MDB.MDBParameter("TyLe6", objData.TyLe6));
            Command.Parameters.Add(new MDB.MDBParameter("MaChuyenKhoa", objData.MaChuyenKhoa));
            Command.Parameters.Add(new MDB.MDBParameter("ChuyenKhoa", objData.ChuyenKhoa));
            Command.Parameters.Add(new MDB.MDBParameter("MaBacSyDieuTri", objData.MaBacSyDieuTri));
            Command.Parameters.Add(new MDB.MDBParameter("BacSyDieuTri", objData.BacSyDieuTri));
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
            string sql = "DELETE FROM PDCNHH WHERE ID = :ID";
            MDBCommand command = new MDB.MDBCommand(sql, MyConnection);
            command.Parameters.Add(new MDB.MDBParameter("ID", ID));
            command.BindByName = true;
            int n = command.ExecuteNonQuery();
            return n > 0 ? true : false;
        }
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, decimal ID)
        {
            string sql2 = @"SELECT D.*, '' SoNhapVien, '' MaBenhAn , '' SoVaoVien, '' SoLuuTru,  '' TenBenhNhan,
                        '' TUOI, '' SoYTe, '' BENHVIEN,
                        ''  GioiTinh
            FROM
                PDCNHH D
            WHERE
                ID = :ID";
            MDB.MDBCommand Command = new MDB.MDBCommand(sql2, MyConnection);
            Command.Parameters.Add(new MDB.MDBParameter("ID", ID));

            MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
            var ds = new DataSet();
            adt.Fill(ds);
            if (ds !=null || ds.Tables[0].Rows.Count > 0)
            {
                ds.Tables[0].Rows[0]["SoNhapVien"] = XemBenhAn._ThongTinDieuTri.SoNhapVien;
                ds.Tables[0].Rows[0]["MaBenhAn"] = XemBenhAn._ThongTinDieuTri.MaBenhAn;
                ds.Tables[0].Rows[0]["SoLuuTru"] = XemBenhAn._ThongTinDieuTri.SoLuuTru;
                ds.Tables[0].Rows[0]["SoVaoVien"] = XemBenhAn._ThongTinDieuTri.SoNhapVien;
                ds.Tables[0].Rows[0]["SoYTe"] = XemBenhAn._HanhChinhBenhNhan.SoYTe;
                ds.Tables[0].Rows[0]["TenBenhNhan"] = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                ds.Tables[0].Rows[0]["TUOI"] = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                ds.Tables[0].Rows[0]["GioiTinh"] = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();
                ds.Tables[0].Rows[0]["BENHVIEN"] = XemBenhAn._HanhChinhBenhNhan.BenhVien;
            }
            return ds;
        }
    }
}
