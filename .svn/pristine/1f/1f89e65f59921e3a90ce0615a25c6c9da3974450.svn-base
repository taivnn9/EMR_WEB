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
    public class DCVT
    {
        [MoTaDuLieu("Số thứ tự")]
        public int STT { get; set; }
        [MoTaDuLieu("Mã dụng cụ vật tư")]
        public string Ma { get; set; }
        [MoTaDuLieu("Tên dụng cụ")]
        public string Ten { get; set; }
        [MoTaDuLieu("Số lượng xuất")]
        public double? SLXuat { get; set; }
        [MoTaDuLieu("Số lượng thu về")]
        public double? SLThu { get; set; }
        [MoTaDuLieu("Kết luận")]
        public string KetLuan { get; set; }
        public ThuocVatTu Clone()
        {
            ThuocVatTu other = (ThuocVatTu)this.MemberwiseClone();
            return other;
        }
        public override string ToString()
        {
            return Ma + ":" + Ten;
        }
    }
    public class DCVT_NoiDung
    {
        [MoTaDuLieu("Tên dụng cụ vật tư 1")]
        public string Ten1 { get; set; }
        [MoTaDuLieu("Số lượng xuất 1")]
        public double? SLXuat1 { get; set; }
        [MoTaDuLieu("Số lượng thu về 1")]
        public double? SLThu1 { get; set; }
        [MoTaDuLieu("Kết luận 1")]
        public string KetLuan1 { get; set; }
        [MoTaDuLieu("Tên dụng cụ vật tư 2")]
        public string Ten2 { get; set; }
        [MoTaDuLieu("Số lượng xuất 2")]
        public double? SLXuat2 { get; set; }
        [MoTaDuLieu("Số lượng thu về 2")]
        public double? SLThu2 { get; set; }
        [MoTaDuLieu("Kết luận 2")]
        public string KetLuan2 { get; set; }
    }
    public class BKDCVTYPT : ThongTinKy
    {
        public BKDCVTYPT()
        {
            TableName = "BKDCVTYPT";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BKDCVTYPT;
            TenMauPhieu = DanhMucPhieu.BKDCVTYPT.Description();
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
        [MoTaDuLieu("Thủ thuật")]
        public string ThuThuat { get; set; }
        [MoTaDuLieu("Ngày làm thủ thuật")]
        public DateTime NgayLamThuThuat { get; set; }
        [MoTaDuLieu("Danh sách gạc")]
        public ObservableCollection<DCVT> lstGac { get; set; }
        [MoTaDuLieu("Danh sách dụng cụ")]
        public ObservableCollection<DCVT> lstDC { get; set; }
        [MoTaDuLieu("Mã dụng cụ viên", null, 0, 0)]
        public string MaDCV { get; set; }
        [MoTaDuLieu("Tên dụng cụ viên", null, 0, 0)]
        public string TenDCV { get; set; }
        [MoTaDuLieu("Mã phẫu thuật viên", null, 0, 0)]
        public string MaPTV { get; set; }
        [MoTaDuLieu("Tên phẫu thuật viên", null, 0, 0)]
        public string TenPTV { get; set; }
        [MoTaDuLieu("Nhận xét của phẫu thuật viên", null, 0, 0)]
        public string NhanXetPTV { get; set; }
        [MoTaDuLieu("Nhận xét của dụng cụ viên", null, 0, 0)]
        public string NhanXetDCV { get; set; }
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
        [MoTaDuLieu("Sở y tế")]
        public string SoYTe
        {
            get
            {
                return XemBenhAn._HanhChinhBenhNhan.SoYTe;
            }
        }
        [MoTaDuLieu("Bệnh viện")]
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
        [MoTaDuLieu("Số vào viện")]
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
        [MoTaDuLieu("Mã bệnh án")]
        public string MaBenhAn
        {
            get
            {
                return XemBenhAn._ThongTinDieuTri.MaBenhAn;
            }
        }
    }
    public class BKDCVTYPTFunc
    {
        public const string TableName = "BKDCVTYPT";
        public const string TablePrimaryKeyName = "ID";
        public static List<BKDCVTYPT> GetListData(MDB.MDBConnection _OracleConnection, decimal maquanly)
        {
            List<BKDCVTYPT> list = new List<BKDCVTYPT>();
            try
            {

                string sql = @"SELECT * FROM BKDCVTYPT where MaQuanLy = :MaQuanLy";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, _OracleConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", maquanly));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    try
                    {
                        BKDCVTYPT data = new BKDCVTYPT();
                        data.ID = DataReader.GetLong("ID");
                        data.MaQuanLy = Common.ConDB_Decimal(DataReader["MaQuanLy"]);
                        data.MaBenhNhan = Common.ConDBNull(DataReader["MABENHNHAN"]); 
                        data.ChanDoan = Common.ConDBNull(DataReader["ChanDoan"]);
                        data.MaKhoa = Common.ConDBNull(DataReader["MaKhoa"]);
                        data.TenKhoa = Common.ConDBNull(DataReader["TenKhoa"]);
                        data.MaGiuong = Common.ConDBNull(DataReader["MaGiuong"]);
                        data.Giuong = Common.ConDBNull(DataReader["Giuong"]);
                        data.ThuThuat = Common.ConDBNull(DataReader["ThuThuat"]);
                        data.NgayLamThuThuat = Common.ConDB_DateTime(DataReader["NgayLamThuThuat"]);
                        data.lstGac = JsonConvert.DeserializeObject<ObservableCollection<DCVT>>(Common.ConDBNull(DataReader["lstGac"]));
                        data.lstDC = JsonConvert.DeserializeObject<ObservableCollection<DCVT>>(Common.ConDBNull(DataReader["lstDC"]));
                        data.MaDCV = Common.ConDBNull(DataReader["MaDCV"]);
                        data.TenDCV = Common.ConDBNull(DataReader["TenDCV"]);
                        data.MaPTV = Common.ConDBNull(DataReader["MaPTV"]);
                        data.TenPTV = Common.ConDBNull(DataReader["TenPTV"]);
                        data.NhanXetPTV = Common.ConDBNull(DataReader["NhanXetPTV"]);
                        data.NhanXetDCV = Common.ConDBNull(DataReader["NhanXetDCV"]);
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
        public static bool InsertOrUpdate(MDB.MDBConnection MyConnection, ref BKDCVTYPT objData)
        {
            string sql;
            int n = 0;
            if (objData.ID == 0)
            {
                sql = @"INSERT INTO BKDCVTYPT (
                                    maquanly,MaKhoa,TenKhoa,MaGiuong,Giuong,
                                    mabenhnhan,
                                    ChanDoan,
                                    ThuThuat,
                                    NgayLamThuThuat,
                                    lstGac,lstDC,
                                    MaDCV,
                                    TenDCV,
                                    MaPTV,
                                    TenPTV,
                                    NhanXetPTV,
                                    NhanXetDCV,
                                    NgayTao,
                                    NguoiTao,
                                    NgaySua,
                                    NguoiSua
                                ) VALUES (
                                    :maquanly,:MaKhoa,:TenKhoa,:MaGiuong,:Giuong,
                                    :mabenhnhan,
                                    :ChanDoan,
                                    :ThuThuat,
                                    :NgayLamThuThuat,
                                    :lstGac,:lstDC,
                                    :MaDCV,
                                    :TenDCV,
                                    :MaPTV,
                                    :TenPTV,
                                    :NhanXetPTV,
                                    :NhanXetDCV,
                                    :NgayTao,
                                    :NguoiTao,
                                    :NgaySua,
                                    :NguoiSua
                                ) RETURNING ID INTO :ID";
            }

            else
            {
                sql = @"UPDATE BKDCVTYPT SET  
                                         maquanly = :maquanly,MaKhoa =:MaKhoa,TenKhoa =:TenKhoa,MaGiuong =:MaGiuong,Giuong =:Giuong,
                                         mabenhnhan = :mabenhnhan,
                                         ChanDoan = :ChanDoan,
                                         ThuThuat = :ThuThuat,
                                         NgayLamThuThuat = :NgayLamThuThuat,
                                         lstGac = :lstGac,lstDC=:lstDC,
                                         MaDCV = :MaDCV,
                                         TenDCV = :TenDCV,
                                         MaPTV = :MaPTV,
                                         TenPTV = :TenPTV,
                                         NhanXetPTV = :NhanXetPTV,
                                         NhanXetDCV = :NhanXetDCV,
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
            Command.Parameters.Add(new MDB.MDBParameter("ThuThuat", objData.ThuThuat));
            Command.Parameters.Add(new MDB.MDBParameter("NgayLamThuThuat", objData.NgayLamThuThuat));
            Command.Parameters.Add(new MDB.MDBParameter("lstGac", JsonConvert.SerializeObject(objData.lstGac)));
            Command.Parameters.Add(new MDB.MDBParameter("lstDC", JsonConvert.SerializeObject(objData.lstDC)));
            Command.Parameters.Add(new MDB.MDBParameter("MaDCV", objData.MaDCV));
            Command.Parameters.Add(new MDB.MDBParameter("TenDCV", objData.TenDCV));
            Command.Parameters.Add(new MDB.MDBParameter("MaPTV", objData.MaPTV));
            Command.Parameters.Add(new MDB.MDBParameter("TenPTV", objData.TenPTV));
            Command.Parameters.Add(new MDB.MDBParameter("NhanXetPTV", objData.NhanXetPTV));
            Command.Parameters.Add(new MDB.MDBParameter("NhanXetDCV", objData.NhanXetDCV));
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
            string sql = "DELETE FROM BKDCVTYPT WHERE ID = :ID";
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
                        '' GioiTinh
            FROM
                BKDCVTYPT D
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
            int cntMax = 0;
            List<DCVT> lstGac = new List<DCVT>();
            if (ds.Tables[0].Rows.Count > 0)
            {
                lstGac = JsonConvert.DeserializeObject < ObservableCollection <DCVT>> (Common.ConDBNull(ds.Tables[0].Rows[0]["lstGac"])).ToList();
            }
            List<DCVT> lstDC = new List<DCVT>();
            if (ds.Tables[0].Rows.Count > 0)
            {
                lstDC = JsonConvert.DeserializeObject<ObservableCollection<DCVT>>(Common.ConDBNull(ds.Tables[0].Rows[0]["lstDC"])).ToList();
            }
            if(lstGac.Count > lstDC.Count)
            {
                cntMax = lstGac.Count;
            }else
            {
                cntMax = lstDC.Count;
            }
            List<DCVT_NoiDung> lstNoiDung = new List<DCVT_NoiDung>();
            for (int i = 0; i < cntMax; i++)
            {
                DCVT_NoiDung item = new DCVT_NoiDung();
                if(i < lstGac.Count)
                {
                    item.Ten1 = lstGac[i].Ten;
                    item.SLThu1 = lstGac[i].SLThu;
                    item.SLXuat1 = lstGac[i].SLXuat;
                    item.KetLuan1 = lstGac[i].KetLuan;
                }
                if (i < lstDC.Count)
                {
                    item.Ten2 = lstDC[i].Ten;
                    item.SLThu2 = lstDC[i].SLThu;
                    item.SLXuat2 = lstDC[i].SLXuat;
                    item.KetLuan2 = lstDC[i].KetLuan;
                }
                lstNoiDung.Add(item);
            }
            ds.Tables.Add(ListToDatatable.ToDataTable(lstNoiDung));
            return ds; 
        }
    }
}
