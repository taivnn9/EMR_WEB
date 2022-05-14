using EMR.KyDienTu;
using Newtonsoft.Json;
using NLog;
using PMS.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Diagnostics;
using System.Text;

namespace EMR_MAIN.DATABASE.Other
{
    public class BangTDCSNBKhoaBND : ThongTinKy
    {
        public BangTDCSNBKhoaBND()
        {
            TableName = "BangTDCSNBKhoaBND";
            TablePrimaryKeyName = "ID";
            IDMauPhieu = (int)DanhMucPhieu.BTDCSNBKBND;
            TenMauPhieu = DanhMucPhieu.BTDCSNBKBND.Description();
        }
        [MoTaDuLieu("Mã định danh")]
        public decimal ID { set; get; }
        [MoTaDuLieu("Mã quản lý: mã duy nhất trong 1 đợt khám chữa bệnh (kcb), không trùng giữa các đợt kcb khác nhau", "", 1)]
        public decimal MaQuanLy { set; get; }
        [MoTaDuLieu("Mã bệnh nhân")]
        public string MaBenhNhan { set; get; }
        [MoTaDuLieu("Tên khoa")]
        public string TenKhoa { set; get; }
        [MoTaDuLieu("Mã khoa")]
        public string MaKhoa { set; get; }
        [MoTaDuLieu("Họ và tên người bệnh")]
        public string HoTenNguoiBenh { get; set; }
        [MoTaDuLieu("Họ và tên người bệnh")]
        public string Tuoi { get; set; }
        [MoTaDuLieu("Giới tính")]
        public string GioiTinh { get; set; }
        [MoTaDuLieu("BMI")]
        public string BMI { get; set; }
        [MoTaDuLieu("Cân nặng")]
        public string CanNang { get; set; }
        [MoTaDuLieu("Nhóm máu")]
        public string NhomMau { get; set; }
        [MoTaDuLieu("Ngày")]
        public DateTime? Ngay { get; set; }
        [MoTaDuLieu("Ngày điều trị thứ")]
        public string NgayDieuTriThu { get; set; }
        [MoTaDuLieu("Chẩn đoán")]
        public string ChanDoan { get; set; }
        [MoTaDuLieu("Bs điều trị")]
        public string BSDieuTri { get; set; }
        [MoTaDuLieu("Mã Bs điều trị")]
        public string MaBSDieuTri { get; set; }
        [MoTaDuLieu("Điều dưỡng HC")]
        public string DieuDuongHC { get; set; }
        [MoTaDuLieu("Mã Điều dưỡng HC")]
        public string MaDieuDuongHC { get; set; }
        [MoTaDuLieu("Trực")]
        public string Truc { get; set; }
        [MoTaDuLieu("NKQ/Canuyn KQ: ")]
        public string Canuyn_KQ{get;set;}
        [MoTaDuLieu("Sonde dạ dày")]
        public string SondeDaDay { get; set; }
        [MoTaDuLieu("Sonde tiểu")]
        public string SondeTieu { get; set; }
        [MoTaDuLieu("Dẫn lưu")]
        public string DanLuu { get; set; }
        [MoTaDuLieu("Loét ép (vị trí/độ)")]
        public string LoetEp { get; set; }
        [MoTaDuLieu("Phân")]
        public string Phan { get; set; }
        [MoTaDuLieu("Đờm")]
        public string Dom { get; set; }
        public ObservableCollection<BangTDCSNBKhoaBND_ChiTiet> ChiTiets { get; set; }
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
        public BangTDCSNBKhoaBND Clone()
        {
            BangTDCSNBKhoaBND other = (BangTDCSNBKhoaBND)this.MemberwiseClone();
            other.ChiTiets = new ObservableCollection<BangTDCSNBKhoaBND_ChiTiet>();
            if (this.ChiTiets != null)
                foreach (BangTDCSNBKhoaBND_ChiTiet item in this.ChiTiets)
                {
                    other.ChiTiets.Add(item.Clone());
                }
            return other;
        }
    }
    public class BangTDCSNBKhoaBND_ChiTiet : ThongTinKy
    {
        public BangTDCSNBKhoaBND_ChiTiet()
        {
            TableName = "BangTDCSNBKhoaBND_ChiTiet";
            TablePrimaryKeyName = "ID";
        }
        [MoTaDuLieu("Mã định danh")]
        public decimal ID { set; get; }
        [MoTaDuLieu("Mã định danh")]
        public decimal IDPhieu { set; get; }
        public DateTime ThoiGian { set; get; }
        [MoTaDuLieu("Mạch")]
        public double? Mach { get; set; }
        [MoTaDuLieu("Nhiệt độ")]
        public double? NhietDo { get; set; }
        [MoTaDuLieu("Huyết áp min")]
        public string HuyetAp_Min { get; set; }
        [MoTaDuLieu("Huyết áp max")]
        public string HuyetAp_Max { get; set; }
        [MoTaDuLieu("Glassgow")]
        public string Glassgow { get; set; }
        [MoTaDuLieu("Tình trạng liệt")]
        public string TinhTrangLiet { get; set; }
        [MoTaDuLieu("Những vị trí tổn thương")]
        public string NhungViTriTonThuong { get; set; }
        [MoTaDuLieu("Đánh giá khác")]
        public string DanhGiaKhac { get; set; }
        [MoTaDuLieu("Tần số thở/SP02")]
        public string SPO2 { get; set; }
        [MoTaDuLieu("MODE/Liệu pháp  Oxy")]
        public string LieuPhapOxy { get; set; }
        [MoTaDuLieu("Vt/F")]
        public string VtF { get; set; }
        [MoTaDuLieu("Fi02/PEEP")]
        public string FiO2 { get; set; }
        [MoTaDuLieu("Dịch vào, thuốc")]
        public string DichVao_Thuoc { get; set; }
        [MoTaDuLieu("Dịch vào, Ăn")]
        public string DichVao_An { get; set; }
        [MoTaDuLieu("Dịch vào, Khác")]
        public string DichVao_Khac { get; set; }
        [MoTaDuLieu("Dịch vào, Tong")]
        public string DichVao_Tong { get; set; }
        [MoTaDuLieu("Dịch ra, Tiểu")]
        public string DichRa_Tieu { get; set; }
        [MoTaDuLieu("Dịch ra, Khác")]
        public string DichRa_Khac { get; set; }
        [MoTaDuLieu("Dịch ra, Tổng")]
        public string DichRa_Tong { get; set; }
        [MoTaDuLieu("Dịch vào – Dịch ra (ml)")]
        public string DichVaoRa { get; set; }
        [MoTaDuLieu("[MoTaDuLieu(Dịch vào – Dịch ra(ml))]")]
        public string Mau { get; set; }
        [MoTaDuLieu("DỊCH TRUYỀN VÀ THUỐC")]
        public ObservableCollection<DichTruyenThuoc> DichTruyenThuocs { get; set; }
        [MoTaDuLieu("Hút đờm")]
        public string HutDom { get; set; }
        [MoTaDuLieu("Thay băng")]
        public string ThayBang { get; set; }
        [MoTaDuLieu("Các chăm sóc khác")]
        public string CacChamSocKhac { get; set; }
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
        public BangTDCSNBKhoaBND_ChiTiet Clone()
        {
            BangTDCSNBKhoaBND_ChiTiet other = (BangTDCSNBKhoaBND_ChiTiet)this.MemberwiseClone();
            other.DichTruyenThuocs = new ObservableCollection<DichTruyenThuoc>();
            if(this.DichTruyenThuocs != null)
                foreach (DichTruyenThuoc item in this.DichTruyenThuocs)
                {
                    other.DichTruyenThuocs.Add(item.Clone());
                }
            return other;
        }
    }
    public class DichTruyenThuoc
    {
        public string TenThuoc { get; set; }
        public string ThongSo { get; set; }
        public DichTruyenThuoc Clone()
        {
            DichTruyenThuoc other = (DichTruyenThuoc)this.MemberwiseClone();
            return other;
        }
    }
    public class BangTDCSNBKhoaBNDFunc
    {
        public const string TableName = "BangTDCSNBKhoaBND";
        public const string TablePrimaryKeyName = "ID";
        public static List<BangTDCSNBKhoaBND> Select(MDB.MDBConnection MyConnection, decimal MaQuanLy)
        {
            try
            {
                List<BangTDCSNBKhoaBND> listResult = new List<BangTDCSNBKhoaBND>();
                string sql = @"SELECT t.*
                FROM BangTDCSNBKhoaBND t
                WHERE t.MaQuanLy = :MaQuanLy";
                sql = sql + " ORDER BY t.NgayTao DESC";
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("MaQuanLy", MaQuanLy));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    BangTDCSNBKhoaBND data = new BangTDCSNBKhoaBND();
                    data.ID = Convert.ToInt64(DataReader.GetLong("ID").ToString());
                    data.MaQuanLy = MaQuanLy;
                    data.MaBenhNhan = DataReader["MaBenhNhan"].ToString();
                    data.HoTenNguoiBenh = XemBenhAn._HanhChinhBenhNhan.TenBenhNhan;
                    data.Tuoi = XemBenhAn._HanhChinhBenhNhan.Tuoi;
                    data.GioiTinh = XemBenhAn._HanhChinhBenhNhan.GioiTinh.Description();

                    data.TenKhoa = DataReader["TenKhoa"].ToString();
                    data.MaKhoa = DataReader["MaKhoa"].ToString();
                    data.BMI = DataReader["BMI"].ToString();
                    data.CanNang = DataReader["CanNang"].ToString();
                    data.NhomMau = DataReader["NhomMau"].ToString();
                    data.Ngay = Convert.ToDateTime(DataReader["Ngay"] == DBNull.Value ? DateTime.Now : DataReader["Ngay"]);
                    data.NgayDieuTriThu = DataReader["NgayDieuTriThu"].ToString();
                    data.ChanDoan = DataReader["ChanDoan"].ToString();
                    data.BSDieuTri = DataReader["BSDieuTri"].ToString();
                    data.MaBSDieuTri = DataReader["MaBSDieuTri"].ToString();
                    data.DieuDuongHC = DataReader["DieuDuongHC"].ToString();
                    data.MaDieuDuongHC = DataReader["MaDieuDuongHC"].ToString();
                    data.Truc = DataReader["Truc"].ToString();
                    data.Canuyn_KQ = DataReader["Canuyn_KQ"].ToString();
                    data.SondeDaDay = DataReader["SondeDaDay"].ToString();
                    data.SondeTieu = DataReader["SondeTieu"].ToString();
                    data.DanLuu = DataReader["DanLuu"].ToString();
                    data.LoetEp = DataReader["LoetEp"].ToString();
                    data.Phan = DataReader["Phan"].ToString();
                    data.Dom = DataReader["Dom"].ToString();
                    data.ChiTiets = Select_PhieuCHiTiet(MyConnection, data.ID, 1);
                    data.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                    data.NguoiTao = DataReader["NguoiTao"].ToString();
                    data.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);
                    data.NguoiSua = DataReader["NguoiSua"].ToString();

                    data.MaSoKy = DataReader["masokyten"].ToString();
                    data.DaKy = !string.IsNullOrEmpty(data.MaSoKy) ? true : false;

                    listResult.Add(data);
                }
                return listResult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static bool Insert(MDB.MDBConnection MyConnection, BangTDCSNBKhoaBND obj)
        {
            try
            {
                {
                    string sql = @"INSERT INTO BangTDCSNBKhoaBND (
                    MaQuanLy,
                    MaBenhNhan,
                    TenKhoa,
                    MaKhoa,
                    BMI,
                    CanNang,
                    NhomMau,
                    Ngay,
                    NgayDieuTriThu,
                    ChanDoan,
                    BSDieuTri,
                    MaBSDieuTri,
                    DieuDuongHC,
                    MaDieuDuongHC,
                    Truc,
                    Canuyn_KQ,
                    SondeDaDay,
                    SondeTieu,
                    DanLuu,
                    LoetEp,
                    Phan,
                    Dom,
                    NguoiTao,
                    NgayTao,
                    NguoiSua,
                    NgaySua
                    ) 
                    VALUES (
                    :MaQuanLy,
                    :MaBenhNhan,
                    :TenKhoa,
                    :MaKhoa,
                    :BMI,
                    :CanNang,
                    :NhomMau,
                    :Ngay,
                    :NgayDieuTriThu,
                    :ChanDoan,
                    :BSDieuTri,
                    :MaBSDieuTri,
                    :DieuDuongHC,
                    :MaDieuDuongHC,
                    :Truc,
                    :Canuyn_KQ,
                    :SondeDaDay,
                    :SondeTieu,
                    :DanLuu,
                    :LoetEp,
                    :Phan,
                    :Dom,
                    :NguoiTao,
                    :NgayTao,
                    :NguoiSua,
                    :NgaySua
                    ) RETURNING ID INTO :ID ";
                    MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, MyConnection);
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaQuanLy", obj.MaQuanLy));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", obj.MaBenhNhan));

                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TenKhoa", obj.TenKhoa));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaKhoa", obj.MaKhoa));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("BMI", obj.BMI));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CanNang", obj.CanNang));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NhomMau", obj.NhomMau));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Ngay", obj.Ngay));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayDieuTriThu", obj.NgayDieuTriThu));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ChanDoan", obj.ChanDoan));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("BSDieuTri", obj.BSDieuTri));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBSDieuTri", obj.MaBSDieuTri));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DieuDuongHC", obj.DieuDuongHC));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaDieuDuongHC", obj.MaDieuDuongHC));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Truc", obj.Truc));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Canuyn_KQ", obj.Canuyn_KQ));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SondeDaDay", obj.SondeDaDay));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SondeTieu", obj.SondeTieu));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DanLuu", obj.DanLuu));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("LoetEp", obj.LoetEp));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Phan", obj.Phan));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Dom", obj.Dom));

                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiTao", Common.getUserLogin()));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayTao", DateTime.Now));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiSua", Common.getUserLogin()));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgaySua", DateTime.Now));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ID", obj.ID));
                    int n = oracleCommand.ExecuteNonQuery();
                    if (n > 0)
                    {
                        decimal ID = Common.ConDB_Decimal((oracleCommand.Parameters["ID"] as MDB.MDBParameter).Value);
                        obj.ID = ID;
                    }

                    return n > 0 ? true : false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static bool Update(MDB.MDBConnection MyConnection, BangTDCSNBKhoaBND obj)
        {
            try
            {
                {

                    string sql = @"UPDATE BangTDCSNBKhoaBND SET 
                        MaQuanLy=:MaQuanLy,
                        MaBenhNhan=:MaBenhNhan,
                        TenKhoa=:TenKhoa,
                        MaKhoa=:MaKhoa,
                        BMI=:BMI,
                        CanNang=:CanNang,
                        NhomMau=:NhomMau,
                        Ngay=:Ngay,
                        NgayDieuTriThu=:NgayDieuTriThu,
                        ChanDoan=:ChanDoan,
                        BSDieuTri=:BSDieuTri,
                        MaBSDieuTri=:MaBSDieuTri,
                        DieuDuongHC=:DieuDuongHC,
                        MaDieuDuongHC=:MaDieuDuongHC,
                        Truc=:Truc,
                        Canuyn_KQ=:Canuyn_KQ,
                        SondeDaDay=:SondeDaDay,
                        SondeTieu=:SondeTieu,
                        DanLuu=:DanLuu,
                        LoetEp=:LoetEp,
                        Phan=:Phan,
                        Dom=:Dom,
                        NguoiSua = :NguoiSua,
                        NgaySua=:NgaySua
                        WHERE ID = " + obj.ID;
                    MDB.MDBCommand oracleCommand = new MDB.MDBCommand(sql, MyConnection);
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaQuanLy", obj.MaQuanLy));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBenhNhan", obj.MaBenhNhan));

                    oracleCommand.Parameters.Add(new MDB.MDBParameter("TenKhoa", obj.TenKhoa));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaKhoa", obj.MaKhoa));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("BMI", obj.BMI));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("CanNang", obj.CanNang));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NhomMau", obj.NhomMau));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Ngay", obj.Ngay));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgayDieuTriThu", obj.NgayDieuTriThu));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("ChanDoan", obj.ChanDoan));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("BSDieuTri", obj.BSDieuTri));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaBSDieuTri", obj.MaBSDieuTri));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DieuDuongHC", obj.DieuDuongHC));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("MaDieuDuongHC", obj.MaDieuDuongHC));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Truc", obj.Truc));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Canuyn_KQ", obj.Canuyn_KQ));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SondeDaDay", obj.SondeDaDay));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("SondeTieu", obj.SondeTieu));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("DanLuu", obj.DanLuu));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("LoetEp", obj.LoetEp));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Phan", obj.Phan));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("Dom", obj.Dom));

                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NguoiSua", Common.getUserLogin()));
                    oracleCommand.Parameters.Add(new MDB.MDBParameter("NgaySua", DateTime.Now));
                    int n = oracleCommand.ExecuteNonQuery();

                    return n > 0 ? true : false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static bool Delete(MDB.MDBConnection MyConnection, decimal IDPhieu)
        {
            try
            {
                if (IDPhieu != 0)
                {
                    string sql = @"Delete BangTDCSNBKhoaBND 
                                WHERE 
                                (ID = :ID) ";
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter(":ID", IDPhieu));
                    int n = Command.ExecuteNonQuery();
                    Command.Dispose();
                    sql = @"Delete BangTDCSNBKhoaBND_ChiTiet 
                                WHERE 
                                (IDPhieu = :IDPhieu) ";
                    Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter(":IDPhieu", IDPhieu));
                    n = Command.ExecuteNonQuery();

                    return true;
                }

            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static bool Delete_ChiTiet(MDB.MDBConnection MyConnection, decimal ID)
        {
            try
            {
                if (ID != 0)
                {
                    string sql = @"Delete BangTDCSNBKhoaBND_ChiTiet 
                                WHERE 
                                (ID = :ID) ";
                    MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                    Command.Parameters.Add(new MDB.MDBParameter(":ID", ID));
                    int n = Command.ExecuteNonQuery();

                    return true;
                }

            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;
        }
        public static ObservableCollection<BangTDCSNBKhoaBND_ChiTiet> Select_PhieuCHiTiet(MDB.MDBConnection MyConnection, decimal IDPhieu, int ModOrder = 0)
        {
            try
            {
                ObservableCollection<BangTDCSNBKhoaBND_ChiTiet> listResult = new ObservableCollection<BangTDCSNBKhoaBND_ChiTiet>();
                string sql = @"SELECT t.*
                FROM BangTDCSNBKhoaBND_ChiTiet t
                WHERE t.IDPhieu = :IDPhieu ";

                if (ModOrder == 1)
                {
                    sql = sql + " ORDER BY t.ThoiGian ASC";
                }
                else
                {
                    sql = sql + " ORDER BY t.ThoiGian DESC";
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("IDPhieu", IDPhieu));
                MDB.MDBDataReader DataReader = Command.ExecuteReader();
                while (DataReader.Read())
                {
                    var obj = new BangTDCSNBKhoaBND_ChiTiet();
                    obj.ID = DataReader.GetDecimal("ID");
                    obj.IDPhieu = DataReader.GetDecimal("IDPhieu");

                    obj.ThoiGian = Convert.ToDateTime(DataReader["ThoiGian"] == DBNull.Value ? DateTime.Now : DataReader["ThoiGian"]);
                    obj.Mach = Common.ConDB_double(DataReader["Mach"]);
                    obj.NhietDo = Common.ConDB_double(DataReader["NhietDo"]);
                    obj.HuyetAp_Min = DataReader["HuyetAp_Min"].ToString();
                    obj.HuyetAp_Max = DataReader["HuyetAp_Max"].ToString();
                    obj.Glassgow = DataReader["Glassgow"].ToString();
                    obj.TinhTrangLiet = DataReader["TinhTrangLiet"].ToString();
                    obj.NhungViTriTonThuong = DataReader["NhungViTriTonThuong"].ToString();
                    obj.DanhGiaKhac = DataReader["DanhGiaKhac"].ToString();
                    obj.SPO2 = DataReader["SPO2"].ToString();
                    obj.LieuPhapOxy = DataReader["LieuPhapOxy"].ToString();
                    obj.VtF = DataReader["VtF"].ToString();
                    obj.FiO2 = DataReader["FiO2"].ToString();
                    obj.DichVao_Thuoc = DataReader["DichVao_Thuoc"].ToString();
                    obj.DichVao_An = DataReader["DichVao_An"].ToString();
                    obj.DichVao_Khac = DataReader["DichVao_Khac"].ToString();
                    obj.DichVao_Tong = DataReader["DichVao_Tong"].ToString();
                    obj.DichRa_Tieu = DataReader["DichRa_Tieu"].ToString();
                    obj.DichRa_Khac = DataReader["DichRa_Khac"].ToString();
                    obj.DichVaoRa = DataReader["DichVaoRa"].ToString();
                    obj.Mau = DataReader["Mau"].ToString();
                    obj.DichTruyenThuocs = JsonConvert.DeserializeObject<ObservableCollection<DichTruyenThuoc>>(DataReader["DichTruyenThuocs"].ToString());
                    if (obj.DichTruyenThuocs == null)
                    {
                        obj.DichTruyenThuocs = new ObservableCollection<DichTruyenThuoc>();
                    }
                    obj.HutDom = DataReader["HutDom"].ToString();
                    obj.ThayBang = DataReader["ThayBang"].ToString();
                    obj.CacChamSocKhac = DataReader["CacChamSocKhac"].ToString();


                    obj.NgayTao = Convert.ToDateTime(DataReader["NgayTao"] == DBNull.Value ? DateTime.Now : DataReader["NgayTao"]);
                    obj.NguoiTao = DataReader["NguoiTao"].ToString();
                    obj.NgaySua = Convert.ToDateTime(DataReader["NgaySua"] == DBNull.Value ? DateTime.Now : DataReader["NgaySua"]);
                    obj.NguoiSua = DataReader["NguoiSua"].ToString();

                    obj.MaSoKy = DataReader["masokyten"].ToString();
                    obj.DaKy = !string.IsNullOrEmpty(obj.MaSoKy) ? true : false;
                    listResult.Add(obj);
                }
                return listResult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static bool InsertOrUpdate_ChiTiet(MDB.MDBConnection MyConnection, ref BangTDCSNBKhoaBND_ChiTiet ketQua)
        {
            try
            {
                string sql = @"INSERT INTO BangTDCSNBKhoaBND_ChiTiet
                (
                    IDPhieu,
                    ThoiGian,
                    Mach,
                    NhietDo,
                    HuyetAp_Min,
                    HuyetAp_Max,
                    Glassgow,
                    TinhTrangLiet,
                    NhungViTriTonThuong,
                    DanhGiaKhac,
                    SPO2,
                    LieuPhapOxy,
                    VtF,
                    FiO2,
                    DichVao_Thuoc,
                    DichVao_An,
                    DichVao_Khac,
                    DichVao_Tong,
                    DichRa_Tieu,
                    DichRa_Khac,
                    DichVaoRa,
                    Mau,
                    DichTruyenThuocs,
                    HutDom,
                    ThayBang,
                    CacChamSocKhac,
                    NGUOITAO,
                    NGUOISUA,
                    NGAYTAO,
                    NGAYSUA)  VALUES
                 (
				    :IDPhieu,
                    :ThoiGian,
                    :Mach,
                    :NhietDo,
                    :HuyetAp_Min,
                    :HuyetAp_Max,
                    :Glassgow,
                    :TinhTrangLiet,
                    :NhungViTriTonThuong,
                    :DanhGiaKhac,
                    :SPO2,
                    :LieuPhapOxy,
                    :VtF,
                    :FiO2,
                    :DichVao_Thuoc,
                    :DichVao_An,
                    :DichVao_Khac,
                    :DichVao_Tong,
                    :DichRa_Tieu,
                    :DichRa_Khac,
                    :DichVaoRa,
                    :Mau,
                    :DichTruyenThuocs,
                    :HutDom,
                    :ThayBang,
                    :CacChamSocKhac,
                    :NGUOITAO,
                    :NGUOISUA,
                    :NGAYTAO,
                    :NGAYSUA
                 )  RETURNING ID INTO :ID";
                if (ketQua.ID != 0)
                {
                    sql = @"UPDATE BangTDCSNBKhoaBND_ChiTiet SET 
                    IDPhieu=:IDPhieu,
                    ThoiGian=:ThoiGian,
                    Mach=:Mach,
                    NhietDo=:NhietDo,
                    HuyetAp_Min=:HuyetAp_Min,
                    HuyetAp_Max=:HuyetAp_Max,
                    Glassgow=:Glassgow,
                    TinhTrangLiet=:TinhTrangLiet,
                    NhungViTriTonThuong=:NhungViTriTonThuong,
                    DanhGiaKhac=:DanhGiaKhac,
                    SPO2=:SPO2,
                    LieuPhapOxy=:LieuPhapOxy,
                    VtF=:VtF,
                    FiO2=:FiO2,
                    DichVao_Thuoc=:DichVao_Thuoc,
                    DichVao_An=:DichVao_An,
                    DichVao_Khac=:DichVao_Khac,
                    DichVao_Tong=:DichVao_Tong,
                    DichRa_Tieu=:DichRa_Tieu,
                    DichRa_Khac=:DichRa_Khac,
                    DichVaoRa=:DichVaoRa,
                    Mau=:Mau,
                    DichTruyenThuocs=:DichTruyenThuocs,
                    HutDom=:HutDom,
                    ThayBang=:ThayBang,
                    CacChamSocKhac=:CacChamSocKhac,
                    NGUOISUA = :NGUOISUA,
                    NGAYSUA = :NGAYSUA
                    WHERE ID = " + ketQua.ID;
                }
                MDB.MDBCommand Command = new MDB.MDBCommand(sql, MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("IDPhieu", ketQua.IDPhieu));
                Command.Parameters.Add(new MDB.MDBParameter("ThoiGian", ketQua.ThoiGian));
                Command.Parameters.Add(new MDB.MDBParameter("Mach", ketQua.Mach));
                Command.Parameters.Add(new MDB.MDBParameter("NhietDo", ketQua.NhietDo));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetAp_Min", ketQua.HuyetAp_Min));
                Command.Parameters.Add(new MDB.MDBParameter("HuyetAp_Max", ketQua.HuyetAp_Max));
                Command.Parameters.Add(new MDB.MDBParameter("Glassgow", ketQua.Glassgow));
                Command.Parameters.Add(new MDB.MDBParameter("TinhTrangLiet", ketQua.TinhTrangLiet));
                Command.Parameters.Add(new MDB.MDBParameter("NhungViTriTonThuong", ketQua.NhungViTriTonThuong));
                Command.Parameters.Add(new MDB.MDBParameter("DanhGiaKhac", ketQua.DanhGiaKhac));
                Command.Parameters.Add(new MDB.MDBParameter("SPO2", ketQua.SPO2));
                Command.Parameters.Add(new MDB.MDBParameter("LieuPhapOxy", ketQua.LieuPhapOxy));
                Command.Parameters.Add(new MDB.MDBParameter("VtF", ketQua.VtF));
                Command.Parameters.Add(new MDB.MDBParameter("FiO2", ketQua.FiO2));
                Command.Parameters.Add(new MDB.MDBParameter("DichVao_Thuoc", ketQua.DichVao_Thuoc));
                Command.Parameters.Add(new MDB.MDBParameter("DichVao_An", ketQua.DichVao_An));
                Command.Parameters.Add(new MDB.MDBParameter("DichVao_Khac", ketQua.DichVao_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("DichVao_Tong", ketQua.DichVao_Tong));
                Command.Parameters.Add(new MDB.MDBParameter("DichRa_Tieu", ketQua.DichRa_Tieu));
                Command.Parameters.Add(new MDB.MDBParameter("DichRa_Khac", ketQua.DichRa_Khac));
                Command.Parameters.Add(new MDB.MDBParameter("DichVaoRa", ketQua.DichVaoRa));
                Command.Parameters.Add(new MDB.MDBParameter("Mau", ketQua.Mau));
                Command.Parameters.Add(new MDB.MDBParameter("DichTruyenThuocs",JsonConvert.SerializeObject(ketQua.DichTruyenThuocs)));
                Command.Parameters.Add(new MDB.MDBParameter("HutDom", ketQua.HutDom));
                Command.Parameters.Add(new MDB.MDBParameter("ThayBang", ketQua.ThayBang));
                Command.Parameters.Add(new MDB.MDBParameter("CacChamSocKhac", ketQua.CacChamSocKhac));

                Command.Parameters.Add(new MDB.MDBParameter("NGUOISUA", ketQua.NguoiSua));
                Command.Parameters.Add(new MDB.MDBParameter("NGAYSUA", ketQua.NgaySua));
                if (ketQua.ID == 0)
                {
                    Command.Parameters.Add(new MDB.MDBParameter("ID", ketQua.ID));
                    Command.Parameters.Add(new MDB.MDBParameter("NGUOITAO", ketQua.NguoiTao));
                    Command.Parameters.Add(new MDB.MDBParameter("NGAYTAO", ketQua.NgayTao));
                }
                Command.BindByName = true;
                int n = Command.ExecuteNonQuery();
                if (ketQua.ID == 0)
                {
                    long nextval = Convert.ToInt64((Command.Parameters["ID"] as MDB.MDBParameter).Value);
                    ketQua.ID = nextval;
                }
                return n > 0 ? true : false;
            }
            catch (Exception ex)
            {
                XuLyLoi.Handle(ex);
            }
            return false;

        }
        public static DataSet GetDataSet(MDB.MDBConnection MyConnection, decimal ID)
        {
            var timer = new Stopwatch();
            StringBuilder sql = new StringBuilder();
            timer.Start();
            try
            {
                sql.AppendLine(@"SELECT P.*, T.SoNhapVien, T.MaBenhAn, H.TenBenhNhan, H.Tuoi, H.SoYTe, H.BenhVien, H.GioiTinh 
                    FROM BangTDCSNBKhoaBND P
                    LEFT JOIN THONGTINDIEUTRI T ON P.MAQUANLY = T.MAQUANLY
                    LEFT JOIN HANHCHINHBENHNHAN H ON T.MABENHNHAN = H.MABENHNHAN
                ");
                sql.AppendLine(" WHERE P.ID = :ID ");
                MDB.MDBCommand Command = new MDB.MDBCommand(sql.ToString(), MyConnection);
                Command.Parameters.Add(new MDB.MDBParameter("ID", ID));
                MDB.MDBDataAdapter adt = new MDB.MDBDataAdapter(Command);
                var ds = new DataSet();
                adt.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                MDB.ExceptionExtend.LogError(ex);
                return null;
            }
            finally
            {
                timer.Stop();
            }
        }
    }
}
