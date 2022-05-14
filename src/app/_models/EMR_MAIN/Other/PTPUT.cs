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
    public class PTPUT : ThongTinKy
    {
        public PTPUT()
        {
            TableName = "PTPUT";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.PTPUT;
            TenMauPhieu = DanhMucPhieu.PTPUT.Description();
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
        public string TenThuoc { get; set; }
        [MoTaDuLieu("Chẩn đoán bệnh")]
		public string ChanDoan { get; set; }
        public string NuocSx { get; set; }
        public DateTime? TgThu { get; set; }
        public string LoSx { get; set; }
        public DateTime? TgDocKQ { get; set; }
        public string PPThu { get; set; }
        public bool[] PhanUng_Array { get; } = new bool[] { false, false, false };
        public string PhanUng
        {
            get
            {
                string temp = String.Empty;
                for (int i = 0; i < PhanUng_Array.Length; i++)
                    temp += (PhanUng_Array[i] ? "1" : "0");
                return temp;
            }
            set
            {
                if (value != null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        int intTemp = value[i] - '0';
                        PhanUng_Array[i] = intTemp == 1 ? true : false;
                    }
                }
            }
        }
        public string NguoiThuPhanUng { get; set; }
        public string MaNguoiThuPhanUng { get; set; }
        public string MaNgDocKQ { get; set; }
        public string TenNgDocKQ { get; set; }
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
    public class PTPUTFunc
    {
        public const string TableName = "PTPUT";
        public const string TablePrimaryKeyName = "ID";
        public static List<PTPUT> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<PTPUT> list = new List<PTPUT>();
            try
            {

                string sql = @"SELECT * FROM PTPUT where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    try
                    {
                        PTPUT data = new PTPUT();
                        data.ID = DataReader.GetLong("ID");
                        data.MaQuanLy = Common.ConDB_Decimal(DataReader["MaQuanLy"]);
                        data.MaBenhNhan = Common.ConDBNull(DataReader["MABENHNHAN"]);
                        data.MaKhoa = Common.ConDBNull(DataReader["MaKhoa"]);
                        data.TenKhoa = Common.ConDBNull(DataReader["TenKhoa"]);
                        data.MaGiuong = Common.ConDBNull(DataReader["MaGiuong"]);
                        data.Giuong = Common.ConDBNull(DataReader["Giuong"]);
                        data.Buong = Common.ConDBNull(DataReader["Buong"]);
                        data.TenThuoc = Common.ConDBNull(DataReader["TenThuoc"]);
                        data.ChanDoan = Common.ConDBNull(DataReader["ChanDoan"]);
                        data.TgThu = Common.ConDB_DateTimeNull(DataReader["TgThu"]);
                        data.NuocSx = Common.ConDBNull(DataReader["NuocSx"]);
                        data.TgDocKQ = Common.ConDB_DateTimeNull(DataReader["TgDocKQ"]);
                        data.LoSx = Common.ConDBNull(DataReader["LoSx"]);
                        data.PPThu = Common.ConDBNull(DataReader["PPThu"]);
                        data.PhanUng = Common.ConDBNull(DataReader["PhanUng"]);
                        data.MaNgDocKQ = Common.ConDBNull(DataReader["MaNgDocKQ"]);
                        data.TenNgDocKQ = Common.ConDBNull(DataReader["TenNgDocKQ"]);
                        data.NguoiTao = Common.ConDBNull(DataReader["NguoiTao"]);
                        data.NguoiSua = Common.ConDBNull(DataReader["NguoiSua"]);
                        data.NgayTao = Common.ConDB_DateTime(DataReader["NgayTao"]);
                        data.NgaySua = Common.ConDB_DateTime(DataReader["NgaySua"]);
                        data.NgayKy = Common.ConDB_DateTime(DataReader["NGAYKY"]);
                        data.ComputerKyTen = Common.ConDBNull(DataReader["COMPUTERKYTEN"]);
                        data.MaSoKy = Common.ConDBNull(DataReader["MASOKYTEN"]);
                        data.TenFileKy = Common.ConDBNull(DataReader["TENFILEKY"]);
                        data.UserNameKy = Common.ConDBNull(DataReader["USERNAMEKY"]);
                        data.NguoiThuPhanUng = Common.ConDBNull(DataReader["NguoiThuPhanUng"]);
                        data.MaNguoiThuPhanUng = Common.ConDBNull(DataReader["MaNguoiThuPhanUng"]);
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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref PTPUT objData)
        {
            string sql;
            int n = 0;
            if (objData.ID == 0)
            {
                sql = @"INSERT INTO PTPUT (
                                    maquanly,MaKhoa,TenKhoa,MaGiuong,Giuong,Buong,
                                    mabenhnhan,
                                    TenThuoc,
                                    ChanDoan,
                                    TgThu,
                                    NuocSx,MaNgDocKQ,TenNgDocKQ,LoSx,TgDocKQ,PPThu,PhanUng,NguoiThuPhanUng,MaNguoiThuPhanUng,
                                    NgayTao,
                                    NguoiTao,
                                    NgaySua,
                                    NguoiSua
                                ) VALUES (
                                    :maquanly,:MaKhoa,:TenKhoa,:MaGiuong,:Giuong,:Buong,
                                    :mabenhnhan,
                                    :TenThuoc,
                                    :ChanDoan,
                                    :TgThu,
                                    :NuocSx,:MaNgDocKQ,:TenNgDocKQ,:LoSx,:TgDocKQ,:PPThu,:PhanUng,:NguoiThuPhanUng,:MaNguoiThuPhanUng,
                                    :NgayTao,
                                    :NguoiTao,
                                    :NgaySua,
                                    :NguoiSua
                                ) RETURNING ID INTO :ID";
            }

            else
            {
                sql = @"UPDATE PTPUT SET  
                                         maquanly = :maquanly,MaKhoa =:MaKhoa,TenKhoa =:TenKhoa,MaGiuong =:MaGiuong,Giuong =:Giuong,Buong =:Buong,
                                         mabenhnhan = :mabenhnhan,
                                         TenThuoc = :TenThuoc,
                                         ChanDoan = :ChanDoan,
                                         TgThu = :TgThu,
                                        NuocSx=:NuocSx,MaNgDocKQ=:MaNgDocKQ,TenNgDocKQ=:TenNgDocKQ,LoSx=:LoSx,TgDocKQ=:TgDocKQ,PPThu=:PPThu,PhanUng=:PhanUng,NguoiThuPhanUng=:NguoiThuPhanUng,MaNguoiThuPhanUng=:MaNguoiThuPhanUng,
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
            Command.Parameters.Add(new MDB.MDBParameter("TenThuoc", objData.TenThuoc));
            Command.Parameters.Add(new MDB.MDBParameter("ChanDoan", objData.ChanDoan));
            Command.Parameters.Add(new MDB.MDBParameter("TgThu", objData.TgThu));
            Command.Parameters.Add(new MDB.MDBParameter("NuocSx", objData.NuocSx));
            Command.Parameters.Add(new MDB.MDBParameter("LoSx", objData.LoSx));
            Command.Parameters.Add(new MDB.MDBParameter("TgDocKQ", objData.TgDocKQ));
            Command.Parameters.Add(new MDB.MDBParameter("PPThu", objData.PPThu));
            Command.Parameters.Add(new MDB.MDBParameter("PhanUng", objData.PhanUng));
            Command.Parameters.Add(new MDB.MDBParameter("MaNgDocKQ", objData.MaNgDocKQ));
            Command.Parameters.Add(new MDB.MDBParameter("TenNgDocKQ", objData.TenNgDocKQ));
            Command.Parameters.Add(new MDB.MDBParameter("MaNguoiThuPhanUng", objData.MaNguoiThuPhanUng));
            Command.Parameters.Add(new MDB.MDBParameter("NguoiThuPhanUng", objData.NguoiThuPhanUng));
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
            string sql = "DELETE FROM PTPUT WHERE ID = :ID";
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
                        ''  GioiTinh
            FROM
                PTPUT D
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
